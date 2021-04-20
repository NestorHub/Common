using System;
using NestorHub.Common.Api.Exceptions;
using NFluent;
using Xunit;

namespace NestorHub.Common.Api.Tests
{
    public class SubscriptionKeyShould
    {
        [Fact]
        public void throw_exception_when_subscription_key_init_with_empty_value()
        {
            Check.ThatCode(() => new SubscriptionKey("")).Throws<SubscriptionKeyEmptyException>();
        }

        [Fact]
        public void return_true_when_2_subscription_key_are_equals()
        {
            var id = Guid.NewGuid().ToString();
            var subscriptionKey1 = new SubscriptionKey(id);
            var subscriptionKey2 = new SubscriptionKey(id);
            Check.That(subscriptionKey1 == subscriptionKey2).IsEqualTo(true);
        }

        [Fact]
        public void return_true_when_subscription_key_is_not_empty()
        {
            var subscriptionKey= new SubscriptionKey(Guid.NewGuid().ToString());
            Check.That(subscriptionKey.IsValid()).IsEqualTo(true);
        }

        [Fact]
        public void return_true_when_2_subscription_key_are_equals_with_override_equals_method()
        {
            var id = Guid.NewGuid().ToString();
            var subscriptionKey1 = new SubscriptionKey(id);
            var subscriptionKey2 = new SubscriptionKey(id);
            Check.That(subscriptionKey1.Equals(subscriptionKey2)).IsEqualTo(true);
        }

        [Fact]
        public void return_true_when_2_subscription_key_arent_equals()
        {
            var subscriptionKey1 = new SubscriptionKey(Guid.NewGuid().ToString());
            var subscriptionKey2 = new SubscriptionKey(Guid.NewGuid().ToString());
            Check.That(subscriptionKey1 != subscriptionKey2).IsEqualTo(true);
        }

        [Fact]
        public void return_false_when_first_subscription_key_is_null_on_equal()
        {
            var subscriptionKey = new SubscriptionKey(Guid.NewGuid().ToString());
            Check.That(null == subscriptionKey).IsFalse();
        }

        [Fact]
        public void return_false_when_second_subscription_key_is_null_on_equal()
        {
            var subscriptionKey = new SubscriptionKey(Guid.NewGuid().ToString());
            Check.That(null == subscriptionKey).IsFalse();
        }

        [Fact]
        public void return_true_when_first_subscription_key_is_null_on_different()
        {
            var subscriptionKey = new SubscriptionKey(Guid.NewGuid().ToString());
            Check.That(null != subscriptionKey).IsTrue();
        }

        [Fact]
        public void return_true_when_second_subscription_key_is_null_on_diffrent()
        {
            var subscriptionKey = new SubscriptionKey(Guid.NewGuid().ToString());
            Check.That(null != subscriptionKey).IsTrue();
        }
    }
}
