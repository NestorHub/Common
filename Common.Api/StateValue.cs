using System;
using NestorHub.Common.Api.Enum;
using NestorHub.Common.Api.Exceptions;

namespace NestorHub.Common.Api
{
    public delegate void ValueChangedEventHandler(StateValue stateValue);

    public class StateValue
    {
        public event ValueChangedEventHandler ValueChanged;

        public string SentinelName { get;  }
        public string PackageName { get;  }
        public string Name { get;  }

        private object _value;
        public object Value
        {
            get => _value;
            set
            {
                _value = value;
                _lastUpdate = DateTime.Now;
                NotifyOnChanged();
            }
        }

        private DateTime _lastUpdate;

        public DateTime LastUpdate => _lastUpdate;

        public TypeOfValue TypeOfValue { get; }

        public StateValue(string sentinelName, string packageName, string name, object value, TypeOfValue typeOfValue)
        {
            if (string.IsNullOrEmpty(sentinelName) || string.IsNullOrEmpty(packageName) ||
                string.IsNullOrEmpty(name))
            {
                throw new StateValueUniquenessException();
            }

            SentinelName = sentinelName;
            PackageName = packageName;
            Name = name;
            Value = value;
            TypeOfValue = typeOfValue;
        }

        private void NotifyOnChanged()
        {
            ValueChanged?.Invoke(this);
        }
    }
}
