using System;
using System.Runtime.Serialization;

namespace NestorHub.Common.Api.Exceptions
{
    [Serializable]
    public class SentinelKeyEmptyException : Exception
    {
        protected SentinelKeyEmptyException(SerializationInfo info, StreamingContext ctx)
            : base(info, ctx)
        {}

        public SentinelKeyEmptyException()
            : base("Sentinel key cannot be empty")
        {}
    }
}