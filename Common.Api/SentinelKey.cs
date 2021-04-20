using System.Collections.Generic;
using NestorHub.Common.Api.Exceptions;
using Value;

namespace NestorHub.Common.Api
{
    public class SentinelKey : ValueType<SentinelKey>
    {
        public string Key { get; }

        public SentinelKey(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new SentinelKeyEmptyException();
            }
            Key = key;
        }

        protected override IEnumerable<object> GetAllAttributesToBeUsedForEquality()
        {
            return new List<object>{ Key };
        }
    }
}