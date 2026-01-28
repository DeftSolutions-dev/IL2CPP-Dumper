// ========================================================
// Dumped by @desirepro
// Assembly: System.Numerics.dll
// Classes:  23
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class SR
    {
        // Methods
        private System.String Format(System.String resourceFormat, System.Object p1) { }

    }

    // TypeToken: 0x200000B
    public struct GetBytesMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Numerics.BigInteger.GetBytesMode AllocateArray;        // 0x0
        public static System.Numerics.BigInteger.GetBytesMode Count;        // 0x0
        public static System.Numerics.BigInteger.GetBytesMode Span;        // 0x0

    }

    // TypeToken: 0x200000E
    public struct BigNumberBuffer
    {
        // Fields
        public System.Text.StringBuilder digits;        // 0x10
        public System.Int32 precision;        // 0x18
        public System.Int32 scale;        // 0x1C
        public System.Boolean sign;        // 0x20

        // Methods
        private System.Numerics.BigNumber.BigNumberBuffer Create() { }

    }

    // TypeToken: 0x2000015
    public struct NumberBuffer
    {
        // Fields
        public System.Int32 precision;        // 0x10
        public System.Int32 scale;        // 0x14
        public System.Boolean sign;        // 0x18
        public System.Char* overrideDigits;        // 0x20

        // Methods
        private System.Char* get_digits() { }

    }

    // TypeToken: 0x2000014
    public class Number
    {
        // Fields
        private static System.String[] s_posCurrencyFormats;        // 0x0
        private static System.String[] s_negCurrencyFormats;        // 0x8
        private static System.String[] s_posPercentFormats;        // 0x10
        private static System.String[] s_negPercentFormats;        // 0x18
        private static System.String[] s_negNumberFormats;        // 0x20
        private static System.String s_posNumberFormat;        // 0x28

        // Methods
        private System.Boolean IsWhite(System.Char ch) { }
        private System.Char* MatchChars(System.Char* p, System.Char* pEnd, System.String str) { }
        private System.Char* MatchChars(System.Char* p, System.Char* pEnd, System.Char* str) { }
        private System.Boolean ParseNumber(System.Char*& str, System.Char* strEnd, System.Globalization.NumberStyles options, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Text.StringBuilder sb, System.Globalization.NumberFormatInfo numfmt, System.Boolean parseDecimal) { }
        private System.Boolean TrailingZeros(System.ReadOnlySpan<System.Char> s, System.Int32 index) { }
        private System.Boolean TryStringToNumber(System.ReadOnlySpan<System.Char> str, System.Globalization.NumberStyles options, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Text.StringBuilder sb, System.Globalization.NumberFormatInfo numfmt, System.Boolean parseDecimal) { }
        private System.Void Int32ToDecChars(System.Char* buffer, System.Int32& index, System.UInt32 value, System.Int32 digits) { }
        private System.Char ParseFormatSpecifier(System.ReadOnlySpan<System.Char> format, System.Int32& digits) { }
        private System.Void NumberToString(System.Text.ValueStringBuilder& sb, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Char format, System.Int32 nMaxDigits, System.Globalization.NumberFormatInfo info, System.Boolean isDecimal) { }
        private System.Void FormatCurrency(System.Text.ValueStringBuilder& sb, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Int32 nMinDigits, System.Int32 nMaxDigits, System.Globalization.NumberFormatInfo info) { }
        private System.Int32 wcslen(System.Char* s) { }
        private System.Void FormatFixed(System.Text.ValueStringBuilder& sb, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Int32 nMinDigits, System.Int32 nMaxDigits, System.Globalization.NumberFormatInfo info, System.Int32[] groupDigits, System.String sDecimal, System.String sGroup) { }
        private System.Void FormatNumber(System.Text.ValueStringBuilder& sb, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Int32 nMinDigits, System.Int32 nMaxDigits, System.Globalization.NumberFormatInfo info) { }
        private System.Void FormatScientific(System.Text.ValueStringBuilder& sb, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Int32 nMinDigits, System.Int32 nMaxDigits, System.Globalization.NumberFormatInfo info, System.Char expChar) { }
        private System.Void FormatExponent(System.Text.ValueStringBuilder& sb, System.Globalization.NumberFormatInfo info, System.Int32 value, System.Char expChar, System.Int32 minDigits, System.Boolean positiveSign) { }
        private System.Void FormatGeneral(System.Text.ValueStringBuilder& sb, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Int32 nMinDigits, System.Int32 nMaxDigits, System.Globalization.NumberFormatInfo info, System.Char expChar, System.Boolean bSuppressScientific) { }
        private System.Void FormatPercent(System.Text.ValueStringBuilder& sb, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Int32 nMinDigits, System.Int32 nMaxDigits, System.Globalization.NumberFormatInfo info) { }
        private System.Void RoundNumber(System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Int32 pos) { }
        private System.Int32 FindSection(System.ReadOnlySpan<System.Char> format, System.Int32 section) { }
        private System.Void NumberToStringFormat(System.Text.ValueStringBuilder& sb, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.ReadOnlySpan<System.Char> format, System.Globalization.NumberFormatInfo info) { }
        private System.Void .cctor() { }

    }

namespace System.Globalization
{

    // TypeToken: 0x2000013
    public class FormatProvider
    {
        // Methods
        private System.Void FormatBigInteger(System.Text.ValueStringBuilder& sb, System.Int32 precision, System.Int32 scale, System.Boolean sign, System.ReadOnlySpan<System.Char> format, System.Globalization.NumberFormatInfo numberFormatInfo, System.Char[] digits, System.Int32 startIndex) { }
        private System.Boolean TryStringToBigInteger(System.ReadOnlySpan<System.Char> s, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo numberFormatInfo, System.Text.StringBuilder receiver, System.Int32& precision, System.Int32& scale, System.Boolean& sign) { }

    }

}

namespace System.Numerics
{

    // TypeToken: 0x2000003
    public struct Matrix3x2, IEquatable`1
    {
        // Fields
        public System.Single M11;        // 0x10
        public System.Single M12;        // 0x14
        public System.Single M21;        // 0x18
        public System.Single M22;        // 0x1C
        public System.Single M31;        // 0x20
        public System.Single M32;        // 0x24
        private static readonly System.Numerics.Matrix3x2 _identity;        // 0x0

        // Methods
        private System.Void .ctor(System.Single m11, System.Single m12, System.Single m21, System.Single m22, System.Single m31, System.Single m32) { }
        private System.Boolean Equals(System.Numerics.Matrix3x2 other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000004
    public struct Matrix4x4, IEquatable`1
    {
        // Fields
        public System.Single M11;        // 0x10
        public System.Single M12;        // 0x14
        public System.Single M13;        // 0x18
        public System.Single M14;        // 0x1C
        public System.Single M21;        // 0x20
        public System.Single M22;        // 0x24
        public System.Single M23;        // 0x28
        public System.Single M24;        // 0x2C
        public System.Single M31;        // 0x30
        public System.Single M32;        // 0x34
        public System.Single M33;        // 0x38
        public System.Single M34;        // 0x3C
        public System.Single M41;        // 0x40
        public System.Single M42;        // 0x44
        public System.Single M43;        // 0x48
        public System.Single M44;        // 0x4C
        private static readonly System.Numerics.Matrix4x4 _identity;        // 0x0

        // Methods
        private System.Void .ctor(System.Single m11, System.Single m12, System.Single m13, System.Single m14, System.Single m21, System.Single m22, System.Single m23, System.Single m24, System.Single m31, System.Single m32, System.Single m33, System.Single m34, System.Single m41, System.Single m42, System.Single m43, System.Single m44) { }
        private System.Boolean Equals(System.Numerics.Matrix4x4 other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000005
    public struct Plane, IEquatable`1
    {
        // Fields
        public System.Numerics.Vector3 Normal;        // 0x10
        public System.Single D;        // 0x1C

        // Methods
        private System.Boolean Equals(System.Numerics.Plane other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000006
    public struct Quaternion, IEquatable`1
    {
        // Fields
        public System.Single X;        // 0x10
        public System.Single Y;        // 0x14
        public System.Single Z;        // 0x18
        public System.Single W;        // 0x1C

        // Methods
        private System.Boolean Equals(System.Numerics.Quaternion other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000007
    public struct Vector2, IEquatable`1, IFormattable
    {
        // Fields
        public System.Single X;        // 0x10
        public System.Single Y;        // 0x14

        // Methods
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.String ToString() { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private System.Boolean Equals(System.Numerics.Vector2 other) { }

    }

    // TypeToken: 0x2000008
    public struct Vector3, IEquatable`1, IFormattable
    {
        // Fields
        public System.Single X;        // 0x10
        public System.Single Y;        // 0x14
        public System.Single Z;        // 0x18

        // Methods
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.String ToString() { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private System.Boolean Equals(System.Numerics.Vector3 other) { }

    }

    // TypeToken: 0x2000009
    public struct Vector4, IEquatable`1, IFormattable
    {
        // Fields
        public System.Single X;        // 0x10
        public System.Single Y;        // 0x14
        public System.Single Z;        // 0x18
        public System.Single W;        // 0x1C

        // Methods
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.String ToString() { }
        private System.String ToString(System.String format, System.IFormatProvider formatProvider) { }
        private System.Boolean Equals(System.Numerics.Vector4 other) { }

    }

    // TypeToken: 0x200000A
    public struct BigInteger, IFormattable, IComparable, IComparable`1, IEquatable`1
    {
        // Fields
        private readonly System.Int32 _sign;        // 0x10
        private readonly System.UInt32[] _bits;        // 0x18
        private static readonly System.Numerics.BigInteger s_bnMinInt;        // 0x0
        private static readonly System.Numerics.BigInteger s_bnOneInt;        // 0x10
        private static readonly System.Numerics.BigInteger s_bnZeroInt;        // 0x20
        private static readonly System.Numerics.BigInteger s_bnMinusOneInt;        // 0x30
        private static readonly System.Byte[] s_success;        // 0x40

        // Methods
        private System.Void .ctor(System.Int32 value) { }
        private System.Void .ctor(System.UInt32 value) { }
        private System.Void .ctor(System.Int64 value) { }
        private System.Void .ctor(System.UInt64 value) { }
        private System.Void .ctor(System.Single value) { }
        private System.Void .ctor(System.Double value) { }
        private System.Void .ctor(System.Decimal value) { }
        private System.Void .ctor(System.Byte[] value) { }
        private System.Void .ctor(System.ReadOnlySpan<System.Byte> value, System.Boolean isUnsigned, System.Boolean isBigEndian) { }
        private System.Void .ctor(System.Int32 n, System.UInt32[] rgu) { }
        private System.Void .ctor(System.UInt32[] value, System.Boolean negative) { }
        private System.Numerics.BigInteger get_Zero() { }
        private System.Numerics.BigInteger get_MinusOne() { }
        private System.Boolean get_IsZero() { }
        private System.Numerics.BigInteger Parse(System.String value, System.IFormatProvider provider) { }
        private System.Numerics.BigInteger Parse(System.String value, System.Globalization.NumberStyles style, System.IFormatProvider provider) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(System.Int64 other) { }
        private System.Boolean Equals(System.Numerics.BigInteger other) { }
        private System.Int32 CompareTo(System.Int64 other) { }
        private System.Int32 CompareTo(System.Numerics.BigInteger other) { }
        private System.Int32 CompareTo(System.Object obj) { }
        private System.Boolean TryWriteBytes(System.Span<System.Byte> destination, System.Int32& bytesWritten, System.Boolean isUnsigned, System.Boolean isBigEndian) { }
        private System.Boolean TryWriteOrCountBytes(System.Span<System.Byte> destination, System.Int32& bytesWritten, System.Boolean isUnsigned, System.Boolean isBigEndian) { }
        private System.Byte[] TryGetBytes(System.Numerics.BigInteger.GetBytesMode mode, System.Span<System.Byte> destination, System.Boolean isUnsigned, System.Boolean isBigEndian, System.Int32& bytesWritten) { }
        private System.String ToString() { }
        private System.String ToString(System.IFormatProvider provider) { }
        private System.String ToString(System.String format, System.IFormatProvider provider) { }
        private System.Numerics.BigInteger Add(System.UInt32[] leftBits, System.Int32 leftSign, System.UInt32[] rightBits, System.Int32 rightSign) { }
        private System.Numerics.BigInteger op_Subtraction(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { }
        private System.Numerics.BigInteger Subtract(System.UInt32[] leftBits, System.Int32 leftSign, System.UInt32[] rightBits, System.Int32 rightSign) { }
        private System.Numerics.BigInteger op_Implicit(System.Byte value) { }
        private System.Numerics.BigInteger op_Implicit(System.SByte value) { }
        private System.Numerics.BigInteger op_Implicit(System.Int16 value) { }
        private System.Numerics.BigInteger op_Implicit(System.UInt16 value) { }
        private System.Numerics.BigInteger op_Implicit(System.Int32 value) { }
        private System.Numerics.BigInteger op_Implicit(System.UInt32 value) { }
        private System.Numerics.BigInteger op_Implicit(System.Int64 value) { }
        private System.Numerics.BigInteger op_Implicit(System.UInt64 value) { }
        private System.Byte op_Explicit(System.Numerics.BigInteger value) { }
        private System.SByte op_Explicit(System.Numerics.BigInteger value) { }
        private System.Int16 op_Explicit(System.Numerics.BigInteger value) { }
        private System.UInt16 op_Explicit(System.Numerics.BigInteger value) { }
        private System.Int32 op_Explicit(System.Numerics.BigInteger value) { }
        private System.UInt32 op_Explicit(System.Numerics.BigInteger value) { }
        private System.Int64 op_Explicit(System.Numerics.BigInteger value) { }
        private System.UInt64 op_Explicit(System.Numerics.BigInteger value) { }
        private System.Single op_Explicit(System.Numerics.BigInteger value) { }
        private System.Double op_Explicit(System.Numerics.BigInteger value) { }
        private System.Decimal op_Explicit(System.Numerics.BigInteger value) { }
        private System.Numerics.BigInteger op_LeftShift(System.Numerics.BigInteger value, System.Int32 shift) { }
        private System.Numerics.BigInteger op_RightShift(System.Numerics.BigInteger value, System.Int32 shift) { }
        private System.Numerics.BigInteger op_UnaryNegation(System.Numerics.BigInteger value) { }
        private System.Numerics.BigInteger op_Addition(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { }
        private System.Numerics.BigInteger op_Multiply(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { }
        private System.Numerics.BigInteger op_Division(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor) { }
        private System.Boolean op_LessThanOrEqual(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { }
        private System.Boolean op_Inequality(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { }
        private System.Boolean op_LessThan(System.Numerics.BigInteger left, System.Int64 right) { }
        private System.Boolean op_LessThanOrEqual(System.Numerics.BigInteger left, System.Int64 right) { }
        private System.Boolean op_Equality(System.Numerics.BigInteger left, System.Int64 right) { }
        private System.Boolean op_Inequality(System.Numerics.BigInteger left, System.Int64 right) { }
        private System.Boolean op_LessThan(System.Int64 left, System.Numerics.BigInteger right) { }
        private System.Boolean op_LessThanOrEqual(System.Int64 left, System.Numerics.BigInteger right) { }
        private System.Boolean GetPartsForBitManipulation(System.Numerics.BigInteger& x, System.UInt32[]& xd, System.Int32& xl) { }
        private System.Int32 GetDiffLength(System.UInt32[] rgu1, System.UInt32[] rgu2, System.Int32 cu) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000C
    public class BigIntegerCalculator
    {
        // Fields
        private static System.Int32 ReducerThreshold;        // 0x0
        private static System.Int32 SquareThreshold;        // 0x4
        private static System.Int32 AllocationThreshold;        // 0x8
        private static System.Int32 MultiplyThreshold;        // 0xC

        // Methods
        private System.UInt32[] Add(System.UInt32[] left, System.UInt32 right) { }
        private System.UInt32[] Add(System.UInt32[] left, System.UInt32[] right) { }
        private System.Void Add(System.UInt32* left, System.Int32 leftLength, System.UInt32* right, System.Int32 rightLength, System.UInt32* bits, System.Int32 bitsLength) { }
        private System.Void AddSelf(System.UInt32* left, System.Int32 leftLength, System.UInt32* right, System.Int32 rightLength) { }
        private System.UInt32[] Subtract(System.UInt32[] left, System.UInt32 right) { }
        private System.UInt32[] Subtract(System.UInt32[] left, System.UInt32[] right) { }
        private System.Void Subtract(System.UInt32* left, System.Int32 leftLength, System.UInt32* right, System.Int32 rightLength, System.UInt32* bits, System.Int32 bitsLength) { }
        private System.Int32 Compare(System.UInt32[] left, System.UInt32[] right) { }
        private System.UInt32[] Divide(System.UInt32[] left, System.UInt32 right) { }
        private System.UInt32[] Divide(System.UInt32[] left, System.UInt32[] right) { }
        private System.Void Divide(System.UInt32* left, System.Int32 leftLength, System.UInt32* right, System.Int32 rightLength, System.UInt32* bits, System.Int32 bitsLength) { }
        private System.UInt32 AddDivisor(System.UInt32* left, System.Int32 leftLength, System.UInt32* right, System.Int32 rightLength) { }
        private System.UInt32 SubtractDivisor(System.UInt32* left, System.Int32 leftLength, System.UInt32* right, System.Int32 rightLength, System.UInt64 q) { }
        private System.Boolean DivideGuessTooBig(System.UInt64 q, System.UInt64 valHi, System.UInt32 valLo, System.UInt32 divHi, System.UInt32 divLo) { }
        private System.UInt32[] CreateCopy(System.UInt32[] value) { }
        private System.Int32 LeadingZeros(System.UInt32 value) { }
        private System.UInt32[] Square(System.UInt32[] value) { }
        private System.Void Square(System.UInt32* value, System.Int32 valueLength, System.UInt32* bits, System.Int32 bitsLength) { }
        private System.UInt32[] Multiply(System.UInt32[] left, System.UInt32 right) { }
        private System.UInt32[] Multiply(System.UInt32[] left, System.UInt32[] right) { }
        private System.Void Multiply(System.UInt32* left, System.Int32 leftLength, System.UInt32* right, System.Int32 rightLength, System.UInt32* bits, System.Int32 bitsLength) { }
        private System.Void SubtractCore(System.UInt32* left, System.Int32 leftLength, System.UInt32* right, System.Int32 rightLength, System.UInt32* core, System.Int32 coreLength) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000D
    public class BigNumber
    {
        // Methods
        private System.Boolean TryValidateParseStyleInteger(System.Globalization.NumberStyles style, System.ArgumentException& e) { }
        private System.Boolean TryParseBigInteger(System.ReadOnlySpan<System.Char> value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info, System.Numerics.BigInteger& result) { }
        private System.Numerics.BigInteger ParseBigInteger(System.String value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info) { }
        private System.Numerics.BigInteger ParseBigInteger(System.ReadOnlySpan<System.Char> value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info) { }
        private System.Boolean HexNumberToBigInteger(System.Numerics.BigNumber.BigNumberBuffer& number, System.Numerics.BigInteger& value) { }
        private System.Boolean NumberToBigInteger(System.Numerics.BigNumber.BigNumberBuffer& number, System.Numerics.BigInteger& value) { }
        private System.Char ParseFormatSpecifier(System.ReadOnlySpan<System.Char> format, System.Int32& digits) { }
        private System.String FormatBigIntegerToHex(System.Boolean targetSpan, System.Numerics.BigInteger value, System.Char format, System.Int32 digits, System.Globalization.NumberFormatInfo info, System.Span<System.Char> destination, System.Int32& charsWritten, System.Boolean& spanSuccess) { }
        private System.String FormatBigInteger(System.Numerics.BigInteger value, System.String format, System.Globalization.NumberFormatInfo info) { }
        private System.String FormatBigInteger(System.Boolean targetSpan, System.Numerics.BigInteger value, System.String formatString, System.ReadOnlySpan<System.Char> formatSpan, System.Globalization.NumberFormatInfo info, System.Span<System.Char> destination, System.Int32& charsWritten, System.Boolean& spanSuccess) { }

    }

    // TypeToken: 0x200000F
    public struct Complex, IEquatable`1, IFormattable
    {
        // Fields
        public static readonly System.Numerics.Complex Zero;        // 0x0
        public static readonly System.Numerics.Complex One;        // 0x10
        public static readonly System.Numerics.Complex ImaginaryOne;        // 0x20
        private static readonly System.Double s_sqrtRescaleThreshold;        // 0x30
        private static readonly System.Double s_asinOverflowThreshold;        // 0x38
        private static readonly System.Double s_log2;        // 0x40
        private System.Double m_real;        // 0x10
        private System.Double m_imaginary;        // 0x18

        // Methods
        private System.Void .ctor(System.Double real, System.Double imaginary) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(System.Numerics.Complex value) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.String ToString(System.String format, System.IFormatProvider provider) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000010
    public struct DoubleUlong
    {
        // Fields
        public System.Double dbl;        // 0x10
        public System.UInt64 uu;        // 0x10

    }

    // TypeToken: 0x2000011
    public class NumericsHelpers
    {
        // Methods
        private System.Void GetDoubleParts(System.Double dbl, System.Int32& sign, System.Int32& exp, System.UInt64& man, System.Boolean& fFinite) { }
        private System.Double GetDoubleFromParts(System.Int32 sign, System.Int32 exp, System.UInt64 man) { }
        private System.Void DangerousMakeTwosComplement(System.UInt32[] d) { }
        private System.UInt64 MakeUlong(System.UInt32 uHi, System.UInt32 uLo) { }
        private System.UInt32 Abs(System.Int32 a) { }
        private System.UInt32 CombineHash(System.UInt32 u1, System.UInt32 u2) { }
        private System.Int32 CombineHash(System.Int32 n1, System.Int32 n2) { }
        private System.Int32 CbitHighZero(System.UInt32 u) { }
        private System.Int32 CbitHighZero(System.UInt64 uu) { }

    }

}

namespace System.Numerics.Hashing
{

    // TypeToken: 0x2000012
    public class HashHelpers
    {
        // Fields
        public static readonly System.Int32 RandomSeed;        // 0x0

        // Methods
        private System.Int32 Combine(System.Int32 h1, System.Int32 h2) { }
        private System.Void .cctor() { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000017
    public class IntrinsicAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace System.Text
{

    // TypeToken: 0x2000016
    public struct ValueStringBuilder
    {
        // Fields
        private System.Char[] _arrayToReturnToPool;        // 0x10
        private System.Span<System.Char> _chars;        // 0x18
        private System.Int32 _pos;        // 0x28

        // Methods
        private System.Void .ctor(System.Span<System.Char> initialBuffer) { }
        private System.Int32 get_Length() { }
        private System.String ToString() { }
        private System.Boolean TryCopyTo(System.Span<System.Char> destination, System.Int32& charsWritten) { }
        private System.Void Insert(System.Int32 index, System.Char value, System.Int32 count) { }
        private System.Void Append(System.Char c) { }
        private System.Void Append(System.String s) { }
        private System.Void AppendSlow(System.String s) { }
        private System.Void Append(System.Char c, System.Int32 count) { }
        private System.Void Append(System.Char* value, System.Int32 length) { }
        private System.Span<System.Char> AppendSpan(System.Int32 length) { }
        private System.Void GrowAndAppend(System.Char c) { }
        private System.Void Grow(System.Int32 requiredAdditionalCapacity) { }
        private System.Void Dispose() { }

    }

}

