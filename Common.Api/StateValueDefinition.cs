using Newtonsoft.Json;

namespace NestorHub.Common.Api
{
    public class StateValueDefinition
    {
        private readonly string _description;
        public string Name { get; }
        public object DefaultValue { get; }

        [JsonConstructor]
        public StateValueDefinition(string name, object defaultValue, string description)
        {
            _description = description;
            Name = name;
            DefaultValue = defaultValue;
        }
    }
}