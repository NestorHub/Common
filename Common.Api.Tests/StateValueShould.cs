using System;
using NestorHub.Common.Api.Enum;
using NestorHub.Common.Api.Exceptions;
using NFluent;
using Xunit;

namespace NestorHub.Common.Api.Tests
{
    public class StateValueShould
    {
        [Fact]
        public void return_parameters_not_null_on_new_state_value_with_2_on_value()
        {
            var stateValue = new StateValue("sentinel", "package", "name", 2, TypeOfValue.Int);
            Check.That(stateValue.Value).IsNotNull();
            Check.That(stateValue.TypeOfValue).IsEqualTo(TypeOfValue.Int);
            Check.That(stateValue.LastUpdate).IsInstanceOf<DateTime>();
            Check.That(stateValue.SentinelName).IsNotEmpty();
            Check.That(stateValue.PackageName).IsNotEmpty();
            Check.That(stateValue.Name).IsNotEmpty();
        }

        [Fact]
        public void throw_exception_when_no_sentinel_name()
        {
            Check.ThatCode(() => new StateValue("", "package", "name", 2, TypeOfValue.Int)).Throws<StateValueUniquenessException>();
        }

        [Fact]
        public void return_true_when_2_state_key_are_equals_and_operator_equal_is_use()
        {
            var stateValueKeyOne = new StateValueKey("sentinel", "package", "name");
            var stateValueKeyTwo = new StateValueKey("sentinel", "package", "name");
            Check.That(stateValueKeyOne == stateValueKeyTwo).IsTrue();
        }

        [Fact]
        public void return_false_when_2_state_key_are_equals_and_operator_different_is_use()
        {
            var stateValueKeyOne = new StateValueKey("sentinel", "package", "name");
            var stateValueKeyTwo = new StateValueKey("sentinel", "package", "name");
            Check.That(stateValueKeyOne != stateValueKeyTwo).IsFalse();
        }

        [Fact]
        public void return_false_when_first_state_value_key_is_null_on_equal()
        {
            var stateValueKey = new StateValueKey("sentinel", "package", "name");
            Check.That(null == stateValueKey).IsFalse();
        }

        [Fact]
        public void return_false_when_second_state_value_key_is_null_on_equal()
        {
            var stateValueKey = new StateValueKey("sentinel", "package", "name");
            Check.That(null == stateValueKey).IsFalse();
        }

        [Fact]
        public void return_true_when_first_state_value_key_is_null_on_different()
        {
            var stateValueKey = new StateValueKey("sentinel", "package", "name");
            Check.That(null != stateValueKey).IsTrue();
        }

        [Fact]
        public void return_true_when_second_state_value_key_is_null_on_diffrent()
        {
            var stateValueKey = new StateValueKey("sentinel", "package", "name");
            Check.That(null != stateValueKey).IsTrue();
        }
    }
}
