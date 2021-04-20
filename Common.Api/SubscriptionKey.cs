using System.Collections.Generic;
using NestorHub.Common.Api.Exceptions;
using Value;

namespace NestorHub.Common.Api
{
    public class SubscriptionKey : ValueType<SubscriptionKey>
    {
        public string Key { get; }

        public SubscriptionKey(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new SubscriptionKeyEmptyException();
            }
            Key = key;
        }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Key);
        }

        protected override IEnumerable<object> GetAllAttributesToBeUsedForEquality()
        {
            return new List<object>{ Key };
        }
    }
}
