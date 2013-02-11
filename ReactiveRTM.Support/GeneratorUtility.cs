using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReactiveRTM.Support
{
    public static class GeneratorUtility
    {
        public const string BaseNamespace = "ReactiveRTM";

        public static string SnakeCaseToCamelCase(string snake, bool firstIsLarge = true)
        {
            string camel = "";

            bool nextIsLarge = firstIsLarge;

            foreach (var c in snake)
            {
                if (c == '_')
                {
                    nextIsLarge = true;
                    continue;
                }
                if (nextIsLarge)
                {
                    camel += c.ToString().ToUpper();
                    nextIsLarge = false;
                }
                else
                {
                    camel += c;
                }
            }
            return camel;
        }

        public static bool IsPrimitive(Type type)
        {
            if (type.IsPrimitive) return true;
            if (type == typeof(string)) return true;
            if (type == typeof(object)) return true;

            return false;
        }

        public static bool IsInterface(Type type)
        {
            return type.IsInterface 
                && type.GetInterfaces().Any(i => i == typeof(Ch.Elca.Iiop.Idl.IIdlEntity));
        }
        public static bool IsStruct(Type type)
        {
            return type.IsValueType 
                && type.GetInterfaces().Any(i => i == typeof(Ch.Elca.Iiop.Idl.IIdlEntity)) 
                && type.GetCustomAttributes<Ch.Elca.Iiop.Idl.IdlStructAttribute>().Any();
        }
        public static bool IsEnum(Type type)
        {
            return type.IsEnum 
                && type.GetCustomAttributes<Ch.Elca.Iiop.Idl.IdlEnumAttribute>().Any();
        }
        public static bool IsUnion(Type type)
        {
            return type.IsValueType
                && type.GetInterfaces().Any(i => i == typeof(Ch.Elca.Iiop.Idl.IIdlEntity)) 
                && type.GetCustomAttributes<Ch.Elca.Iiop.Idl.IdlUnionAttribute>().Any();
        }

        public static string GetIiopName(Type type)
        {
            if (type == typeof(void)) return "void";
            if (type.IsByRef)
            {
                return GetIiopName(type.GetElementType());
            }
            if (IsPrimitive(type)) return type.FullName;
            
            return "global::" + type.FullName;
        }

        public static string GetFullName(Type type)
        {
            if (type == typeof(void)) return "void";
            if (IsPrimitive(type)) return type.FullName;
            return Join(BaseNamespace, type.Namespace.Split('.').LastOrDefault(), type.Name);
        }

        public static string GetFullDataName(Type type)
        {
            if (type == typeof(void)) return "void";

            if (type.IsByRef)
            {
                return GetFullDataName(type.GetElementType());
            }
            if (IsPrimitive(type)) return type.FullName;
            if (IsUnion(type)) return GetIiopName(type);
            return Join(BaseNamespace, type.Namespace.Split('.').LastOrDefault(), type.Name);
        }

        public static string GetFullRefTypeName(Type type)
        {
            if (type == typeof(void)) return "void";
            if (type.IsByRef)
            {
                return GetFullRefTypeName(type.GetElementType());
            }
            if (type.IsArray)
            {
                if (type.GetElementType() == typeof(global::org.omg.SDOPackage.NameValue))
                {
                    return "Dictionary<string,object>";
                }
                //return "ObservableCollection<" + GetFullRefTypeName(type.GetElementType()) + ">";
                return "List<" + GetFullRefTypeName(type.GetElementType()) + ">";
            }

            if (type == typeof(RTC.Time)) return typeof(DateTime).FullName;
            if (IsPrimitive(type)) return type.FullName;
            if (IsEnum(type) || IsStruct(type)) return GetFullDataName(type);
            if (IsInterface(type)) return GetFullName(type);
            if (IsUnion(type)) return GetIiopName(type);

            return typeof(object).FullName;
        }


        public static string GetEqualsMethod(Type type)
        {
            if (type.IsArray) return "SequenceEqual";
            return "Equals";
        }
        
        public static string ToIiop(Type type, string name)
        {
            if (type == typeof(void)) return "";
            if (type.IsByRef)
            {
                return ToIiop(type.GetElementType(), name);
            }
            if (type.IsArray)
            {
                if (type.GetElementType() == typeof(global::org.omg.SDOPackage.NameValue))
                {
                    return "Converter.DictionaryToNVList(" + name + ")";
                }
                return name + ".Select(x=>" + ToIiop(type.GetElementType(), "x") + ").ToArray()";
            }

            if (type == typeof(RTC.Time)) return "Converter.DateTimeToRtcTime(" + name + ")";
            if (IsPrimitive(type)) return name;
            if (IsStruct(type)) return "((" + GetIiopName(type) + ")((IStub)" + name + ").GetTarget())";
            if (IsInterface(type)) return "((" + GetIiopName(type) + ")((IStub)" + name + ").GetTarget())";
            if (IsUnion(type)) return name;
            if (type == typeof(MarshalByRefObject)) return "(MarshalByRefObject)" + name;

            //if (IsEnum(type)) 
            return "(" + GetIiopName(type) + ")" + name;

        }

        public static string FromIiop(Type type, string name)
        {
            if (type == typeof(void)) return "";
            if (type.IsByRef)
            {
                return FromIiop(type.GetElementType(), name);
            }

            if (type.IsArray)
            {
                if (type.GetElementType() == typeof(global::org.omg.SDOPackage.NameValue))
                {
                    return "Converter.NVListToDictionary(" + name + ")";
                }
                return name + ".Select(x => (" + GetFullRefTypeName(type.GetElementType()) + ")" + FromIiop(type.GetElementType(), "x") + ").ToList()";
            }

            if (IsPrimitive(type)) return name;
            if (type == typeof(RTC.Time)) return "Converter.RtcTimeToDateTime(" + name + ")";
            if (IsStruct(type)) return "new " + GetFullDataName(type) + "(" + name + ")";
            if (IsInterface(type)) return "new " + GetFullName(type) + "Stub(" + name + ")";
            if (IsUnion(type)) return name;
            if (type == typeof(MarshalByRefObject)) return "(object)" + name;

            //if (IsEnum(type)) 
            return "(" + GetFullName(type)+ ")" + name;
        }



        public static string Join(params string[] sttrs)
        {
            return string.Join(".", sttrs.Where(x => !string.IsNullOrEmpty(x)));
        }

    }
}
