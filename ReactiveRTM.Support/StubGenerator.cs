using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM.Support
{
    using GU = GeneratorUtility;
    public static class ClassGenerator
    {
        public static IEnumerable<ClassesTemplate> GenerateTemplates(Type[] types)
        {
            return types.Where(GU.IsInterface)
                .Distinct()
                .GroupBy(t => t.Namespace)
                .Select(g => new ClassesTemplate
                {
                    Namespace = GU.Join(GU.BaseNamespace, g.Key),
                    ClassTemplates = g.Select(t => new ClassTemplate(t)).ToArray()
                })
                .Where(a => a.ClassTemplates.Any())
                .OrderBy(a => a.Namespace);
        }

        public class ClassesTemplate
        {
            public string Namespace { get; set; }
            public ClassTemplate[] ClassTemplates { get; set; }
        }

        public class ClassTemplate
        {
            public string ClassName { get; set; }
            public string FullName { get; set; }
            public string IiopClassName { get; set; }
            public InterfaceTemplate[] Parents { get; set; }
            public MethodTemplate[] MethodTemplates { get; set; }

            public ClassTemplate(Type type)
            {
                ClassName = type.Name;
                FullName = GU.GetFullName(type);
                IiopClassName = GU.GetIiopName(type);

                Parents = type.GetInterfaces()
                    .Where(i => i != typeof(Ch.Elca.Iiop.Idl.IIdlEntity))
                    .Select(i => new InterfaceTemplate(){
                        Name = GU.GetFullName(i),
                        IiopName = GU.GetIiopName(i)
                    }).ToArray();

                MethodTemplates = type.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                    .Concat(type.GetInterfaces().SelectMany(i => i.GetMethods(BindingFlags.Public | BindingFlags.Instance)))
                    .Select(mi => new MethodTemplate
                    {
                        Name = GeneratorUtility.SnakeCaseToCamelCase(mi.Name),
                        ReturnType = GU.GetFullRefTypeName(mi.ReturnType),
                        DecArgs = string.Join(",", mi.GetParameters().Select(p => (p.IsOut ? "out " : p.ParameterType.IsByRef ? "ref " : "") + GU.GetFullRefTypeName(p.ParameterType) + " " + GU.SnakeCaseToCamelCase(p.Name,false))),

                        ExtReturnType = GetExtReturnType(mi),
                        ExtDecArgs = string.Join(",", new[] { "this " + type.Name + " target" }.Concat(mi.GetParameters().Select(p => GU.GetFullRefTypeName(p.ParameterType) + " " + GU.SnakeCaseToCamelCase(p.Name, false)))),

                        IiopName = mi.Name,
                        IiopReturnType = GU.GetIiopName(mi.ReturnType),
                        IiopDecArgs = string.Join(",", mi.GetParameters().Select(p => (p.IsOut ? "out " : p.ParameterType.IsByRef ? "ref " : "") + GU.GetIiopName(p.ParameterType) + " " + p.Name)),
                        
                        StubBeforeCall = mi.GetParameters().Where(p=>p.IsOut || p.ParameterType.IsByRef).Select(p=> "var tmp" + p.Name + " = " + GU.ToIiop(p.ParameterType, p.Name)).ToArray(),
                        StubCallMethod = (mi.ReturnType == typeof(void) ? "" : "var ret = ") + "_target." + mi.Name + "(" + GetStubCallArgs(mi) + ");",
                        StubAfterCall = mi.GetParameters().Where(p=>p.IsOut || p.ParameterType.IsByRef).Select(p=> p.Name + " = " + GU.FromIiop(p.ParameterType, "tmp"+p.Name)).ToArray(),
                        StubReturnValue = "return" + (mi.ReturnType == typeof(void) ? "" : " " + GU.FromIiop(mi.ReturnType, "ret")) + ";",
                        
                        AdapterBeforeCall = mi.GetParameters().Where(p => p.IsOut || p.ParameterType.IsByRef).Select(p => "var tmp" + p.Name + " = " + GU.FromIiop(p.ParameterType, p.Name)).ToArray(),
                        AdapterCallMethod = (mi.ReturnType == typeof(void) ? "" : "var ret = ") + "_target." + GU.SnakeCaseToCamelCase(mi.Name) + "(" + GetAdapterCallArgs(mi) + ");",
                        AdapterAfterCall = mi.GetParameters().Where(p => p.IsOut || p.ParameterType.IsByRef).Select(p => p.Name + " = " + GU.ToIiop(p.ParameterType, "tmp" + p.Name)).ToArray(),
                        AdapterReturnValue = "return" + (mi.ReturnType == typeof(void) ? "" : " " + GU.ToIiop(mi.ReturnType, "ret")) + ";",

                        ExtCallMethod = (mi.ReturnType == typeof(void) ? "" : "var ret = ") + "target." + GU.SnakeCaseToCamelCase(mi.Name) + "(" + GetExtCallArgs(mi) + ");",
                        ExtReturnValue = GetExtReturnValue(mi),
                        
                    })
                    .ToArray();
            }

            public class InterfaceTemplate
            {
                public string Name { get; set; }
                public string IiopName { get; set; }
            }
            
            private static string GetAdapterCallArgs(MethodInfo mi)
            {
                return string.Join(",", mi.GetParameters()
                    .Select(p =>
                    {
                        if (p.IsOut)
                        {
                            return "out tmp" + p.Name;
                        }
                        else if (p.ParameterType.IsByRef)
                        {
                            return "ref tmp" + p.Name;
                        }
                        else
                        {
                            return GU.FromIiop(p.ParameterType, p.Name);
                        }
                    }));
            }
            private static string GetStubCallArgs(MethodInfo mi)
            {
                return string.Join(",", mi.GetParameters()
                    .Select(p =>
                    {
                        if (p.IsOut)
                        {
                            return "out tmp" + p.Name;
                        }
                        else if (p.ParameterType.IsByRef)
                        {
                            return "ref tmp" + p.Name;
                        }
                        else
                        {
                            return GU.ToIiop(p.ParameterType, GU.SnakeCaseToCamelCase(p.Name, false));
                        }
                    }));
            }
            private static string GetExtReturnType(MethodInfo mi)
            {
                var refParams = mi.GetParameters().Where(p => p.IsOut || p.ParameterType.IsByRef);
                if (refParams.Any())
                {
                    return "Task<Tuple<" + 
                        (mi.ReturnType == typeof(void) ? "" : GU.GetFullRefTypeName(mi.ReturnType) + ",")
                        + string.Join(",", refParams.Select(p => GU.GetFullRefTypeName(p.ParameterType))) + ">>";
                }
                else
                {
                    return mi.ReturnType == typeof(void) ? "Task" : "Task<" + GU.GetFullRefTypeName(mi.ReturnType) + ">";
                }
                
            }
            
            private static string GetExtCallArgs(MethodInfo mi)
            {
                return string.Join(",", mi.GetParameters().Select(p => (p.IsOut ? "out " : p.ParameterType.IsByRef ? "ref " : "") + GU.SnakeCaseToCamelCase(p.Name, false)));
            }

            private static string GetExtReturnValue(MethodInfo mi)
            {
                var refParams = mi.GetParameters().Where(p => p.IsOut || p.ParameterType.IsByRef);
                if (refParams.Any())
                {
                    return "return Tuple.Create(" + (mi.ReturnType == typeof(void) ? "" : "ret,") + string.Join(",", refParams.Select(p => GU.SnakeCaseToCamelCase(p.Name, false))) + ");";
                }
                else
                {
                    return "return" + (mi.ReturnType == typeof(void) ? "" : " ret") + ";";
                }
            }
        }

        public class MethodTemplate
        {
            public string Name { get; set; }
            public string ReturnType { get; set; }
            public string DecArgs { get; set; }

            public string ExtReturnType { get; set; }
            public string ExtDecArgs { get; set; }
            
            public string IiopName { get; set; }
            public string IiopReturnType { get; set; }
            public string IiopDecArgs { get; set; }
            

            public string[] StubBeforeCall { get; set; }
            public string StubCallMethod { get; set; }
            public string[] StubAfterCall { get; set; }
            public string StubReturnValue { get; set; }

            public string[] AdapterBeforeCall { get; set; }
            public string AdapterCallMethod { get; set; }
            public string[] AdapterAfterCall { get; set; }
            public string AdapterReturnValue { get; set; }

            public string ExtCallMethod { get; set; }
            public string ExtReturnValue { get; set; }
        }

    }
}
