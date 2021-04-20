using NestorHub.Common.Api.Exceptions;
using NFluent;
using Xunit;

namespace NestorHub.Common.Api.Tests
{
    public class SentinelKeyShould
    {
        [Fact]
        public void throw_exception_when_sentinel_key_init_with_empty_value()
        {
            Check.ThatCode(() => new SentinelKey("")).Throws<SentinelKeyEmptyException>();
        }

        [Fact]
        public void return_true_when_2_sentinel_key_are_equals()
        {
            var sentinelKey1 = new SentinelKey("sentinel1");
            var sentinelKey2 = new SentinelKey("sentinel1");
            Check.That(sentinelKey1 == sentinelKey2).IsEqualTo(true);
        }
        
        [Fact]
        public void return_true_when_2_sentinel_key_are_equals_with_override_equals_method()
        {
            var sentinelKey1 = new SentinelKey("sentinel1");
            var sentinelKey2 = new SentinelKey("sentinel1");
            Check.That(sentinelKey1.Equals(sentinelKey2)).IsEqualTo(true);
        }

        [Fact]
        public void return_true_when_2_sentinel_key_arent_equals()
        {
            var sentinelKey1 = new SentinelKey("sentinel1");
            var sentinelKey2 = new SentinelKey("sentinel2");
            Check.That(sentinelKey1 != sentinelKey2).IsEqualTo(true);
        }

        [Fact]
        public void return_false_when_first_sentinel_key_is_null_on_equal()
        {
            var sentinelKey = new SentinelKey("sentinel1");
            Check.That(null == sentinelKey).IsFalse();
        }

        [Fact]
        public void return_false_when_second_sentinel_key_is_null_on_equal()
        {
            var sentinelKey = new SentinelKey("sentinel1");
            Check.That(null == sentinelKey).IsFalse();
        }

        [Fact]
        public void return_true_when_first_sentinel_key_is_null_on_different()
        {
            var sentinelKey = new SentinelKey("sentinel1");
            Check.That(null != sentinelKey).IsTrue();
        }

        [Fact]
        public void return_true_when_second_sentinel_key_is_null_on_different()
        {
            var sentinelKey = new SentinelKey("sentinel1");
            Check.That(null != sentinelKey).IsTrue();
        }
    }
}
