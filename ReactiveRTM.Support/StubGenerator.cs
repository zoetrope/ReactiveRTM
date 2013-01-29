using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM.Support
{
    public static class StubGenerator
    {
        public static IEnumerable<ObservableTemplate> GenerateTemplates(Type[] types)
        {
            return types.Where(t => t.IsInterface && t.GetInterfaces().Any(i => i == typeof(Ch.Elca.Iiop.Idl.IIdlEntity)))
                .Distinct()
                .GroupBy(t => t.Namespace)
                .Select(g => new ObservableTemplate
                {
                    Namespace = g.Key,
                    ClassTemplates = g.Select(t => new ClassTemplate(t))
                        .Where(t => t.MethodTemplates.Any())
                        .ToArray()
                })
                .Where(a => a.ClassTemplates.Any())
                .OrderBy(a => a.Namespace);
        }

        public class ObservableTemplate
        {
            public string Namespace;
            public ClassTemplate[] ClassTemplates;
        }

        public class ClassTemplate
        {
            public string Classname;
            public MethodTemplate[] MethodTemplates;

            public ClassTemplate(Type type)
            {
                Classname = type.Name;
                MethodTemplates = type.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                    .Select(a => new MethodTemplate
                    {
                        Name = a.Name,
                        Return = a.ReturnType == typeof(void) ? "" : "<" + a.ReturnType.FullName + ">",
                        DecArgs = a.GetParameters().Count() != 0 ? "," + string.Join(",", a.GetParameters().Select(p => p.ParameterType.ToString().Replace("&", "") + " " + p.Name)) : string.Empty,
                        CallArgs = string.Join(",", a.GetParameters().Select(p => (p.IsOut ? "out " : p.ParameterType.IsByRef ? "ref " : "") + p.Name))
                    })
                    .ToArray();
            }
        }

        public class MethodTemplate
        {
            public string Name, DecArgs, CallArgs, Return;
        }

    }
}
