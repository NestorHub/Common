using NestorHub.Common.Api.Class;

namespace NestorHub.Common.Api.Enum
{
    public enum TypeOfValue
    {
        [TypeOf(null)]
        Undefined = 0,
        [TypeOf(typeof(int))]
        Int = 1,
        [TypeOf(typeof(double))]
        Double = 2,
        [TypeOf(typeof(string))]
        String = 3,
        [TypeOf(typeof(long))]
        Long = 4,
        [TypeOf(typeof(uint))]
        UInt = 5,
        [TypeOf(typeof(ulong))]
        ULong = 6,
        [TypeOf(typeof(char))]
        Char = 7,
        [TypeOf(typeof(float))]
        Float = 8,
        [TypeOf(typeof(bool))]
        Boolean = 9,
        [TypeOf(typeof(byte))]
        Byte = 10,
        [TypeOf(typeof(sbyte))]
        Sbyte = 11,
        [TypeOf(typeof(decimal))]
        Decimal = 12,
        [TypeOf(typeof(short))]
        Short = 13,
        [TypeOf(typeof(ushort))]
        Ushort = 14
    }
}