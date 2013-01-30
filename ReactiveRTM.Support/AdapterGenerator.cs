using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM.Support
{
    using GU = GeneratorUtility;
    public static class AdapterGenerator
    {
        public static IEnumerable<StubTemplate> GenerateTemplates(Type[] types)
        {
            return types.Where(GU.IsInterface)
                .Distinct()
                .GroupBy(t => t.Namespace)
                .Select(g => new StubTemplate
                {
                    Namespace = GU.Join(GU.BaseNamespace, g.Key),
                    ClassTemplates = g.Select(t => new ClassTemplate(t)).ToArray()
                })
                .Where(a => a.ClassTemplates.Any())
                .OrderBy(a => a.Namespace);
        }

        public class StubTemplate
        {
            public string Namespace { get; set; }
            public ClassTemplate[] ClassTemplates { get; set; }
        }

        public class ClassTemplate
        {
            public string ClassName { get; set; }
            public string IiopClassName { get; set; }
            public string[] Parents { get; set; }
            public MethodTemplate[] MethodTemplates { get; set; }

            public ClassTemplate(Type type)
            {
                ClassName = type.Name;
                IiopClassName = GU.GetIiopName(type);

                Parents = type.GetInterfaces()
                    .Where(i => i != typeof(Ch.Elca.Iiop.Idl.IIdlEntity))
                    .Select(i => i.FullName).ToArray();

                MethodTemplates = type.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                    .Concat(type.GetInterfaces().SelectMany(i => i.GetMethods(BindingFlags.Public | BindingFlags.Instance)))
                    .Select(a => new MethodTemplate
                    {
                        Name = GeneratorUtility.SnakeCaseToCamelCase(a.Name),
                        IiopName = a.Name,
                        IiopReturnType = GU.GetIiopName(a.ReturnType),
                        ReturnType = GU.GetFullRefTypeName(a.ReturnType),

                        DecArgs = string.Join(",", a.GetParameters().Select(p => "global::" + p.ParameterType.ToString().Replace("&", "") + " " + p.Name)),
                        BeforeCall = a.GetParameters().Where(p => p.IsOut || p.ParameterType.IsByRef).Select(p => "var tmp" + p.Name + " = " + GU.FromIiop(p.ParameterType, p.Name)).ToArray(),
                        CallMethod = (a.ReturnType == typeof(void) ? "" : "var ret = ") + "_target." + GU.SnakeCaseToCamelCase(a.Name) + "(" + GetCallArgs(a) + ");",
                        AfterCall = a.GetParameters().Where(p => p.IsOut || p.ParameterType.IsByRef).Select(p => p.Name + " = " + GU.ToIiop(p.ParameterType, "tmp" + p.Name)).ToArray(),
                        ReturnValue = "return" + (a.ReturnType == typeof(void) ? "" : " " + GU.ToIiop(a.ReturnType, "ret")) + ";"
                    })
                    .ToArray();
            }

            private static string GetCallArgs(MethodInfo mi)
            {
                return string.Join(",", mi.GetParameters().Select(p => (p.IsOut ? "out tmp" : p.ParameterType.IsByRef ? "ref tmp" : "") + p.Name));
            }

        }

        public class MethodTemplate
        {
            public string Name { get; set; }
            public string IiopName { get; set; }
            public string DecArgs { get; set; }

            public string IiopReturnType { get; set; }
            public string ReturnType { get; set; }
            public string[] BeforeCall { get; set; }
            public string CallMethod { get; set; }
            public string[] AfterCall { get; set; }
            public string ReturnValue { get; set; }
        }

    }
}
