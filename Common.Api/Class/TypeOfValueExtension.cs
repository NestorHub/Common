using System;
using NestorHub.Common.Api.Enum;
using NestorHub.Common.Api.Helpers;

namespace NestorHub.Common.Api.Class
{
    public static class TypeOfValueExtension
    {
        public static Type TypeOf(this TypeOfValue typeOfValue)
        {
            return TypeOfValueEnum.GetTypeOf(typeOfValue);
        }

        public static TypeOfValue GetTypeOfValue(this Type type)
        {
            return TypeOfValueEnum.GetEnumTypeOf(type);
        }
    }
}
