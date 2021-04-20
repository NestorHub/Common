using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using NestorHub.Common.Api.Exceptions;
using Newtonsoft.Json;
using Value;

namespace NestorHub.Common.Api
{
    public class StateValueKey : ValueType<StateValueKey>
    {
        public string Key { get; private set; }

        public StateValueKey()
        {}

        public StateValueKey(string sentinelName, string packageName, string name)
        {
            if (string.IsNullOrEmpty(sentinelName))
            {
                throw new StateValueKeyEmptyException("Sentinel name");
            }

            if (string.IsNullOrEmpty(packageName))
            {
                throw new StateValueKeyEmptyException("Package name");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new StateValueKeyEmptyException("Name");
            }

            Key = $"{sentinelName}.{packageName}.{name}";
        }

        [JsonConstructor]
        public StateValueKey(string key)
        {
            var matchStateValueKeyFormat = Regex.Match(key, "^[a-zA-Z0-9]*[.][a-zA-Z0-9]*[.][a-zA-Z0-9]*$",
                RegexOptions.IgnoreCase);
            if (!matchStateValueKeyFormat.Success)
            {
                throw new StateValueKeyBadFormatException(key);
            }

            var components = key.Split('.');
            Key = $"{components[0]}.{components[1]}.{components[2]}";
        }

        public StateValueKey(StateValue stateValue) 
            : this(stateValue.SentinelName, stateValue.PackageName, stateValue.Name)
        {}

        public Tuple<string, string, string> GetComponents()
        {
            var components = Key.Split('.');
            return new Tuple<string, string, string>(components[0], components[1], components[2]);
        }

        public override string ToString()
        {
            return Key;
        }

        protected override IEnumerable<object> GetAllAttributesToBeUsedForEquality()
        {
            return new List<object>{ Key };
        }
    }
}