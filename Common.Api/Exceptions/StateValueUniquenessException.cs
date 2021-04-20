using System;
using System.Runtime.Serialization;

namespace NestorHub.Common.Api.Exceptions
{
    [Serializable]
    public class StateValueUniquenessException : Exception
    {
        protected StateValueUniquenessException(SerializationInfo info, StreamingContext ctx)
            : base(info, ctx)
        {}

        public StateValueUniquenessException()
            : base("Sentinel name, package name or state value name is missing, and uniqueness of object is broken")
        {}
    }
}
