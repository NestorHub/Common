using System;

namespace NestorHub.Common.Api.Class
{
    public class TypeOfAttribute : Attribute
    {
        public Type Type { get; }

        public TypeOfAttribute(Type type)
        {
            Type = type;
        }
    }
}
