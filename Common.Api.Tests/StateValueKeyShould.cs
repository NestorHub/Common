using System;
using NestorHub.Common.Api.Enum;
using NestorHub.Common.Api.Exceptions;
using NFluent;
using Xunit;

namespace NestorHub.Common.Api.Tests
{
    public class StateValueKeyShould
    {
        [Fact]
        public void throw_exception_when_no_sentinel_name()
        {
            Check.ThatCode(() => new StateValueKey("", "package1", "name1"))
                .Throws<StateValueKeyEmptyException>();
        }

        [Fact]
        public void throw_exception_when_no_package_name()
        {
            Check.ThatCode(() => new StateValueKey("sentinel1", "", "name1"))
                .Throws<StateValueKeyEmptyException>();
        }

        [Fact]
        public void throw_exception_when_no_name()
        {
            Check.ThatCode(() => new StateValueKey("sentinel1", "package", ""))
                .Throws<StateValueKeyEmptyException>();
        }

        [Fact]
        public void throw_exception_when_state_value_key_format_is_not_correct()
        {
            Check.ThatCode(() => new StateValueKey("sentinel1.package1name2"))
                .Throws<StateValueKeyBadFormatException>();
        }

        [Fact]
        public void throw_exception_when_state_value_key_is_empty()
        {
            Check.ThatCode(() => new StateValueKey(""))
                .Throws<StateValueKeyBadFormatException>();
        }

        [Fact]
        public void return_sentinel1_dot_package1_dot_name1_when_state_value_key_init_with_state_value()
        {
            var stateValueKey = new StateValueKey(new StateValue("sentinel1", "package1", "name1", 2, TypeOfValue.Int));
            Check.That(stateValueKey.Key).IsEqualTo("sentinel1.package1.name1");
        }

        [Fact]
        public void return_true_when_2_state_value_key_are_equals()
        {
            var stateValueKey1 = new StateValueKey("sentinel1", "package1", "name1");
            var stateValueKey2 = new StateValueKey("sentinel1", "package1", "name1");
            Check.That(stateValueKey1 == stateValueKey2).IsEqualTo(true);
        }
        
        [Fact]
        public void return_true_when_2_state_value_key_are_equals_with_override_equals_method()
        {
            var stateValueKey1 = new StateValueKey("sentinel1", "package1", "name1");
            var stateValueKey2 = new StateValueKey("sentinel1", "package1", "name1");
            Check.That(stateValueKey1.Equals(stateValueKey2)).IsEqualTo(true);
        }

        [Fact]
        public void return_true_when_2_state_value_key_arent_equals()
        {
            var stateValueKey1 = new StateValueKey("sentinel1", "package1", "name1");
            var stateValueKey2 = new StateValueKey("sentinel1", "package2", "name1");
            Check.That(stateValueKey1 != stateValueKey2).IsEqualTo(true);
        }

        [Fact]
        public void return_sentinel1_package1_name1_when_get_components_of_state_value_key()
        {
            var stateValueKey = new StateValueKey("sentinel1.package1.name1");
            (string sentinelName, string packageName, string name) = stateValueKey.GetComponents();

            Check.That(sentinelName).IsEqualTo("sentinel1");
            Check.That(packageName).IsEqualTo("package1");
            Check.That(name).IsEqualTo("name1");
        }
    }
}
