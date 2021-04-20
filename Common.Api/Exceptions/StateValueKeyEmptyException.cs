using System;
using System.Runtime.Serialization;

namespace NestorHub.Common.Api.Exceptions
{
    [Serializable]
    public class StateValueKeyEmptyException : Exception
    {
        protected StateValueKeyEmptyException(SerializationInfo info, StreamingContext ctx)
            : base(info, ctx)
        {}

        public StateValueKeyEmptyException(string argument)
            : base("{0} argument could not have empty value for state value key")
        {}
    }
}