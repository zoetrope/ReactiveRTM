using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM.Support
{
    using GU = GeneratorUtility;
    
    public static class DataGenerator
    {
        public static IEnumerable<DataTemplate> GenerateTemplates(Type[] types)
        {
            return types
                .Distinct()
                .GroupBy(t => t.Namespace)
                .Select(g => new DataTemplate
                {
                    Namespace = GU.Join(GU.BaseNamespace,g.Key),
                    StructTemplates = g.Where(GU.IsStruct)
                        .Select(t => new StructTemplate(t))
                        .ToArray(),
                    EnumTemplates = g.Where(GU.IsEnum)
                        .Select(t => new EnumTemplate(t))
                        .ToArray()
                })
                .Where(a => a.StructTemplates.Any())
                .OrderBy(a => a.Namespace);
        }

        public class DataTemplate
        {
            public string Namespace;
            public StructTemplate[] StructTemplates;
            public EnumTemplate[] EnumTemplates;
            public StructTemplate[] UnionTemplates;//TODO:
        }

        public class StructTemplate
        {
            public string StructName { get; set; }
            public string FullName { get; set; }
            public string IiopName { get; set; }
            public PropertyTemplate[] PropertyTemplates;

            public StructTemplate(Type type)
            {
                StructName = type.Name;
                FullName = GU.GetFullDataName(type);
                IiopName = GU.GetIiopName(type);
                PropertyTemplates = type.GetFields(BindingFlags.Public | BindingFlags.Instance)
                    .Select(a => new PropertyTemplate
                    {
                        Type = a.FieldType,
                        Name = GU.SnakeCaseToCamelCase(a.Name),
                        TypeName = GU.GetFullRefTypeName(a.FieldType),
                        IiopName = a.Name,
                        IiopTypeName = GU.GetIiopName(a.FieldType)
                    })
                    .ToArray();
            }
        }

        public class PropertyTemplate
        {
            public Type Type { get; set; }

            public string Name{get;set;}
            public string TypeName{get;set;}

            public string IiopName { get; set; }
            public string IiopTypeName { get; set; }
        }

        public class EnumTemplate
        {
            public string Name { get; set; }
            public string FullName { get; set; }
            public string IiopName { get; set; }
            public FieldTemplate[] FieldTemplates;

            public EnumTemplate(Type type)
            {
                Name = type.Name;
                FullName = GU.GetFullDataName(type);
                IiopName = GU.GetIiopName(type);

                FieldTemplates = type.GetFields(BindingFlags.Public | BindingFlags.Static)
                    .Select(a => new FieldTemplate
                    {
                        Name = a.Name,
                        Value = a.GetRawConstantValue().ToString()
                    })
                    .ToArray();

            }
        }

        public class FieldTemplate
        {
            public string Name { get; set; }
            public string Value { get; set; }

        }
    }
}
