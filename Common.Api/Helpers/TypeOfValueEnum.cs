using System;
using NestorHub.Common.Api.Class;
using NestorHub.Common.Api.Enum;

namespace NestorHub.Common.Api.Helpers
{
    public static class TypeOfValueEnum
    {
        public static Type GetTypeOf(System.Enum value)
        {
            var output = ReadValueOnAttribute(value, value.GetType());
            return output;
        }

        public static TypeOfValue GetEnumTypeOf(Type type)
        {
            var enumValues = System.Enum.GetValues(typeof(TypeOfValue));
            foreach (TypeOfValue enumValue in enumValues)
            {
                if (GetTypeOf(enumValue) == type)
                {
                    return enumValue;
                }
            }
            return TypeOfValue.Undefined;
        }

        private static Type ReadValueOnAttribute(System.Enum value, Type type)
        {
            Type output = null;
            var fi = type.GetField(value.ToString());
            if (fi.GetCustomAttributes(typeof(TypeOfAttribute), false) is TypeOfAttribute[] attrs && attrs.Length > 0)
            {
                if (attrs[0].Type != null)
                {
                    output = attrs[0].Type ?? null;
                }
            }
            return output;
        }
    }
}
