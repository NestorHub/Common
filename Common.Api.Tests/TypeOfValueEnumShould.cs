using NestorHub.Common.Api.Class;
using NestorHub.Common.Api.Enum;
using NestorHub.Common.Api.Helpers;
using NFluent;
using Xunit;

namespace NestorHub.Common.Api.Tests
{
    public class TypeOfValueEnumShould
    {
        [Fact]
        public void return_type_int()
        {
            Check.That(TypeOfValueEnum.GetTypeOf(TypeOfValue.Int)).IsEqualTo(typeof(int));
        }

        [Fact]
        public void return_typeofvalue_int()
        {
            Check.That(TypeOfValueEnum.GetEnumTypeOf(typeof(int))).IsEqualTo(TypeOfValue.Int);
        }

        [Fact]
        public void return_undefined_when_type_is_object()
        {
            Check.That(TypeOfValueEnum.GetEnumTypeOf(typeof(StateValue))).IsEqualTo(TypeOfValue.Undefined);
        }

        [Fact]
        public void return_typeof_decimal_when_enum_is_decimal()
        {
            Check.That(TypeOfValue.Decimal.TypeOf()).IsEqualTo(typeof(decimal));
        }

        [Fact]
        public void return_enum_decimal_when_type_is_decimal()
        {
            Check.That(typeof(decimal).GetTypeOfValue()).IsEqualTo(TypeOfValue.Decimal);
        }
    }
}
