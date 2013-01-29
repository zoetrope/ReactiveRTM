using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM.Support
{
    public static class DataGenerator
    {
        public static IEnumerable<DataTemplate> GenerateTemplates(Type[] types)
        {
            return types.Where(t => t.IsValueType && t.GetInterfaces().Any(i => i == typeof(Ch.Elca.Iiop.Idl.IIdlEntity)))
                .Distinct()
                .GroupBy(t => t.Namespace)
                .Select(g => new DataTemplate
                {
                    Namespace = g.Key,
                    ClassTemplates = g.Select(t => new StructTemplate(t))
                        .Where(t => t.PropertyTemplates.Any())
                        .ToArray()
                })
                .Where(a => a.ClassTemplates.Any())
                .OrderBy(a => a.Namespace);
        }

        public class DataTemplate
        {
            public string Namespace;
            public StructTemplate[] ClassTemplates;
        }

        public class StructTemplate
        {
            public string StructName;
            public PropertyTemplate[] PropertyTemplates;

            public StructTemplate(Type type)
            {
                StructName = type.Name;
                PropertyTemplates = type.GetFields(BindingFlags.Public | BindingFlags.Instance)
                    .Select(a => new PropertyTemplate
                    {
                        Name = a.Name,
                        TypeName = a.FieldType.FullName
                    })
                    .ToArray();
            }
        }

        public class PropertyTemplate
        {
            public string Name{get;set;}
            public string TypeName{get;set;}
        }
    }
}
