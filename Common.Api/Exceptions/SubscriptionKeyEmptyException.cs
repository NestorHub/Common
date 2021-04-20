using System;
using System.Runtime.Serialization;

namespace NestorHub.Common.Api.Exceptions
{
    [Serializable]
    public class SubscriptionKeyEmptyException : Exception
    {
        protected SubscriptionKeyEmptyException(SerializationInfo info, StreamingContext ctx)
            : base(info, ctx)
        {}

        public SubscriptionKeyEmptyException()
            : base("Subscription key cannot be empty")
        {}
    }
}