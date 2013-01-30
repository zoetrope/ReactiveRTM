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

        public static string GetFullStubName(Type type)
        {
            if (type == typeof(void)) return "void";
            if (IsPrimitive(type)) return type.FullName;
            return Join(BaseNamespace, type.FullName) + "Stub";
        }

        public static string GetFullDataName(Type type)
        {
            if (type == typeof(void)) return "void";
            if (type.IsByRef)
            {
                return GetFullDataName(type.GetElementType());
            }
            if (IsPrimitive(type)) return type.FullName;
            return Join(BaseNamespace, type.FullName);
        }

        public static string GetFullRefTypeName(Type type)
        {
            if (type == typeof(void)) return "void";
            if (type.IsByRef)
            {
                return GetIiopName(type.GetElementType());
            }
            if (type.IsArray)
            {
                return "List<" + GetFullRefTypeName(type.GetElementType()) + ">";
            }

            if (IsPrimitive(type)) return type.FullName;
            if (IsEnum(type) || IsStruct(type)) return GetFullDataName(type);
            if (IsInterface(type)) return GetFullStubName(type);

            return typeof(object).FullName;
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
                return name + ".Select(x=>" +  ToIiop(type.GetElementType(), "x") + ").ToArray()";
            }

            if (IsPrimitive(type)) return name;

            if (IsStruct(type)) return "((" + GetIiopName(type) + ")((IStub)" + name + ").GetTarget())";
            if (IsInterface(type)) return "((" + GetIiopName(type) + ")((IStub)" + name + ").GetTarget())";

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
                return name + ".Select(x=>" + FromIiop(type.GetElementType(), "x") + ").ToList()";
            }

            if (IsPrimitive(type)) return name;

            if (IsStruct(type)) return "new " + GetFullDataName(type) + "(" + name + ")";
            if (IsInterface(type)) return "new " + GetFullStubName(type) + "(" + name + ")";

            //if (IsEnum(type)) 
            return "(" + type.FullName + ")" + name;
        }



        public static string Join(string s1, string s2)
        {
            
            if (string.IsNullOrEmpty(s1))
            {
                return s2;
            }
            if (string.IsNullOrEmpty(s2))
            {
                return s1;
            }

            return s1 + "." + s2;
        }

        public const string BaseNamespace = "ReactiveRTM";
    }
}
