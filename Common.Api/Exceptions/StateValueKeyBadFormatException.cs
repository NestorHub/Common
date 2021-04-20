using System;
using System.Runtime.Serialization;

namespace NestorHub.Common.Api.Exceptions
{
    [Serializable]
    public class StateValueKeyBadFormatException : Exception
    {
        protected StateValueKeyBadFormatException(SerializationInfo info, StreamingContext ctx)
            : base(info, ctx)
        {}

        public StateValueKeyBadFormatException(string value)
            : base($"The value {value} is a bad format for StateValueKey")
        {}
    }
}