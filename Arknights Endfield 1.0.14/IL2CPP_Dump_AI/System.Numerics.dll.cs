// ========================================================
// Dumped by @desirepro
// Assembly: System.Numerics.dll
// Classes:  23
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: SR
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.String Format(System.String resourceFormat, System.Object p1)
END_CLASS

CLASS: GetBytesMode
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Numerics.BigInteger.GetBytesModeAllocateArray  // 0x0
  public    static  System.Numerics.BigInteger.GetBytesModeCount  // 0x0
  public    static  System.Numerics.BigInteger.GetBytesModeSpan  // 0x0
METHODS:
END_CLASS

CLASS: BigNumberBuffer
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.Text.StringBuilder       digits  // 0x10
  public            System.Int32                    precision  // 0x18
  public            System.Int32                    scale  // 0x1C
  public            System.Boolean                  sign  // 0x20
METHODS:
  System.Numerics.BigNumber.BigNumberBuffer Create()
END_CLASS

CLASS: NumberBuffer
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            System.Int32                    precision  // 0x10
  public            System.Int32                    scale  // 0x14
  public            System.Boolean                  sign  // 0x18
  public            System.Char*                    overrideDigits  // 0x20
METHODS:
  System.Char* get_digits()
END_CLASS

CLASS: Number
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  private   static  System.String[]                 s_posCurrencyFormats  // 0x0
  private   static  System.String[]                 s_negCurrencyFormats  // 0x8
  private   static  System.String[]                 s_posPercentFormats  // 0x10
  private   static  System.String[]                 s_negPercentFormats  // 0x18
  private   static  System.String[]                 s_negNumberFormats  // 0x20
  private   static  System.String                   s_posNumberFormat  // 0x28
METHODS:
  System.Boolean IsWhite(System.Char ch)
  System.Char* MatchChars(System.Char* p, System.Char* pEnd, System.String str)
  System.Char* MatchChars(System.Char* p, System.Char* pEnd, System.Char* str)
  System.Boolean ParseNumber(System.Char*& str, System.Char* strEnd, System.Globalization.NumberStyles options, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Text.StringBuilder sb, System.Globalization.NumberFormatInfo numfmt, System.Boolean parseDecimal)
  System.Boolean TrailingZeros(System.ReadOnlySpan<System.Char> s, System.Int32 index)
  System.Boolean TryStringToNumber(System.ReadOnlySpan<System.Char> str, System.Globalization.NumberStyles options, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Text.StringBuilder sb, System.Globalization.NumberFormatInfo numfmt, System.Boolean parseDecimal)
  System.Void Int32ToDecChars(System.Char* buffer, System.Int32& index, System.UInt32 value, System.Int32 digits)
  System.Char ParseFormatSpecifier(System.ReadOnlySpan<System.Char> format, System.Int32& digits)
  System.Void NumberToString(System.Text.ValueStringBuilder& sb, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Char format, System.Int32 nMaxDigits, System.Globalization.NumberFormatInfo info, System.Boolean isDecimal)
  System.Void FormatCurrency(System.Text.ValueStringBuilder& sb, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Int32 nMinDigits, System.Int32 nMaxDigits, System.Globalization.NumberFormatInfo info)
  System.Int32 wcslen(System.Char* s)
  System.Void FormatFixed(System.Text.ValueStringBuilder& sb, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Int32 nMinDigits, System.Int32 nMaxDigits, System.Globalization.NumberFormatInfo info, System.Int32[] groupDigits, System.String sDecimal, System.String sGroup)
  System.Void FormatNumber(System.Text.ValueStringBuilder& sb, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Int32 nMinDigits, System.Int32 nMaxDigits, System.Globalization.NumberFormatInfo info)
  System.Void FormatScientific(System.Text.ValueStringBuilder& sb, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Int32 nMinDigits, System.Int32 nMaxDigits, System.Globalization.NumberFormatInfo info, System.Char expChar)
  System.Void FormatExponent(System.Text.ValueStringBuilder& sb, System.Globalization.NumberFormatInfo info, System.Int32 value, System.Char expChar, System.Int32 minDigits, System.Boolean positiveSign)
  System.Void FormatGeneral(System.Text.ValueStringBuilder& sb, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Int32 nMinDigits, System.Int32 nMaxDigits, System.Globalization.NumberFormatInfo info, System.Char expChar, System.Boolean bSuppressScientific)
  System.Void FormatPercent(System.Text.ValueStringBuilder& sb, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Int32 nMinDigits, System.Int32 nMaxDigits, System.Globalization.NumberFormatInfo info)
  System.Void RoundNumber(System.Globalization.FormatProvider.Number.NumberBuffer& number, System.Int32 pos)
  System.Int32 FindSection(System.ReadOnlySpan<System.Char> format, System.Int32 section)
  System.Void NumberToStringFormat(System.Text.ValueStringBuilder& sb, System.Globalization.FormatProvider.Number.NumberBuffer& number, System.ReadOnlySpan<System.Char> format, System.Globalization.NumberFormatInfo info)
  System.Void .cctor()
END_CLASS

CLASS: System.Globalization.FormatProvider
TYPE:  class
TOKEN: 0x2000013
FIELDS:
METHODS:
  System.Void FormatBigInteger(System.Text.ValueStringBuilder& sb, System.Int32 precision, System.Int32 scale, System.Boolean sign, System.ReadOnlySpan<System.Char> format, System.Globalization.NumberFormatInfo numberFormatInfo, System.Char[] digits, System.Int32 startIndex)
  System.Boolean TryStringToBigInteger(System.ReadOnlySpan<System.Char> s, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo numberFormatInfo, System.Text.StringBuilder receiver, System.Int32& precision, System.Int32& scale, System.Boolean& sign)
END_CLASS

CLASS: System.Numerics.Matrix3x2
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Single                   M11  // 0x10
  public            System.Single                   M12  // 0x14
  public            System.Single                   M21  // 0x18
  public            System.Single                   M22  // 0x1C
  public            System.Single                   M31  // 0x20
  public            System.Single                   M32  // 0x24
  private   static readonly System.Numerics.Matrix3x2       _identity  // 0x0
METHODS:
  System.Void .ctor(System.Single m11, System.Single m12, System.Single m21, System.Single m22, System.Single m31, System.Single m32)
  System.Boolean Equals(System.Numerics.Matrix3x2 other)
  System.Boolean Equals(System.Object obj)
  System.String ToString()
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: System.Numerics.Matrix4x4
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Single                   M11  // 0x10
  public            System.Single                   M12  // 0x14
  public            System.Single                   M13  // 0x18
  public            System.Single                   M14  // 0x1C
  public            System.Single                   M21  // 0x20
  public            System.Single                   M22  // 0x24
  public            System.Single                   M23  // 0x28
  public            System.Single                   M24  // 0x2C
  public            System.Single                   M31  // 0x30
  public            System.Single                   M32  // 0x34
  public            System.Single                   M33  // 0x38
  public            System.Single                   M34  // 0x3C
  public            System.Single                   M41  // 0x40
  public            System.Single                   M42  // 0x44
  public            System.Single                   M43  // 0x48
  public            System.Single                   M44  // 0x4C
  private   static readonly System.Numerics.Matrix4x4       _identity  // 0x0
METHODS:
  System.Void .ctor(System.Single m11, System.Single m12, System.Single m13, System.Single m14, System.Single m21, System.Single m22, System.Single m23, System.Single m24, System.Single m31, System.Single m32, System.Single m33, System.Single m34, System.Single m41, System.Single m42, System.Single m43, System.Single m44)
  System.Boolean Equals(System.Numerics.Matrix4x4 other)
  System.Boolean Equals(System.Object obj)
  System.String ToString()
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: System.Numerics.Plane
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Numerics.Vector3         Normal  // 0x10
  public            System.Single                   D  // 0x1C
METHODS:
  System.Boolean Equals(System.Numerics.Plane other)
  System.Boolean Equals(System.Object obj)
  System.String ToString()
  System.Int32 GetHashCode()
END_CLASS

CLASS: System.Numerics.Quaternion
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Single                   X  // 0x10
  public            System.Single                   Y  // 0x14
  public            System.Single                   Z  // 0x18
  public            System.Single                   W  // 0x1C
METHODS:
  System.Boolean Equals(System.Numerics.Quaternion other)
  System.Boolean Equals(System.Object obj)
  System.String ToString()
  System.Int32 GetHashCode()
END_CLASS

CLASS: System.Numerics.Vector2
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Single                   X  // 0x10
  public            System.Single                   Y  // 0x14
METHODS:
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Boolean Equals(System.Numerics.Vector2 other)
END_CLASS

CLASS: System.Numerics.Vector3
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Single                   X  // 0x10
  public            System.Single                   Y  // 0x14
  public            System.Single                   Z  // 0x18
METHODS:
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Boolean Equals(System.Numerics.Vector3 other)
END_CLASS

CLASS: System.Numerics.Vector4
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Single                   X  // 0x10
  public            System.Single                   Y  // 0x14
  public            System.Single                   Z  // 0x18
  public            System.Single                   W  // 0x1C
METHODS:
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Boolean Equals(System.Numerics.Vector4 other)
END_CLASS

CLASS: System.Numerics.BigInteger
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  private   readonly System.Int32                    _sign  // 0x10
  private   readonly System.UInt32[]                 _bits  // 0x18
  private   static readonly System.Numerics.BigInteger      s_bnMinInt  // 0x0
  private   static readonly System.Numerics.BigInteger      s_bnOneInt  // 0x10
  private   static readonly System.Numerics.BigInteger      s_bnZeroInt  // 0x20
  private   static readonly System.Numerics.BigInteger      s_bnMinusOneInt  // 0x30
  private   static readonly System.Byte[]                   s_success  // 0x40
METHODS:
  System.Void .ctor(System.Int32 value)
  System.Void .ctor(System.UInt32 value)
  System.Void .ctor(System.Int64 value)
  System.Void .ctor(System.UInt64 value)
  System.Void .ctor(System.Single value)
  System.Void .ctor(System.Double value)
  System.Void .ctor(System.Decimal value)
  System.Void .ctor(System.Byte[] value)
  System.Void .ctor(System.ReadOnlySpan<System.Byte> value, System.Boolean isUnsigned, System.Boolean isBigEndian)
  System.Void .ctor(System.Int32 n, System.UInt32[] rgu)
  System.Void .ctor(System.UInt32[] value, System.Boolean negative)
  System.Numerics.BigInteger get_Zero()
  System.Numerics.BigInteger get_MinusOne()
  System.Boolean get_IsZero()
  System.Numerics.BigInteger Parse(System.String value, System.IFormatProvider provider)
  System.Numerics.BigInteger Parse(System.String value, System.Globalization.NumberStyles style, System.IFormatProvider provider)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(System.Int64 other)
  System.Boolean Equals(System.Numerics.BigInteger other)
  System.Int32 CompareTo(System.Int64 other)
  System.Int32 CompareTo(System.Numerics.BigInteger other)
  System.Int32 CompareTo(System.Object obj)
  System.Boolean TryWriteBytes(System.Span<System.Byte> destination, System.Int32& bytesWritten, System.Boolean isUnsigned, System.Boolean isBigEndian)
  System.Boolean TryWriteOrCountBytes(System.Span<System.Byte> destination, System.Int32& bytesWritten, System.Boolean isUnsigned, System.Boolean isBigEndian)
  System.Byte[] TryGetBytes(System.Numerics.BigInteger.GetBytesMode mode, System.Span<System.Byte> destination, System.Boolean isUnsigned, System.Boolean isBigEndian, System.Int32& bytesWritten)
  System.String ToString()
  System.String ToString(System.IFormatProvider provider)
  System.String ToString(System.String format, System.IFormatProvider provider)
  System.Numerics.BigInteger Add(System.UInt32[] leftBits, System.Int32 leftSign, System.UInt32[] rightBits, System.Int32 rightSign)
  System.Numerics.BigInteger op_Subtraction(System.Numerics.BigInteger left, System.Numerics.BigInteger right)
  System.Numerics.BigInteger Subtract(System.UInt32[] leftBits, System.Int32 leftSign, System.UInt32[] rightBits, System.Int32 rightSign)
  System.Numerics.BigInteger op_Implicit(System.Byte value)
  System.Numerics.BigInteger op_Implicit(System.SByte value)
  System.Numerics.BigInteger op_Implicit(System.Int16 value)
  System.Numerics.BigInteger op_Implicit(System.UInt16 value)
  System.Numerics.BigInteger op_Implicit(System.Int32 value)
  System.Numerics.BigInteger op_Implicit(System.UInt32 value)
  System.Numerics.BigInteger op_Implicit(System.Int64 value)
  System.Numerics.BigInteger op_Implicit(System.UInt64 value)
  System.Byte op_Explicit(System.Numerics.BigInteger value)
  System.SByte op_Explicit(System.Numerics.BigInteger value)
  System.Int16 op_Explicit(System.Numerics.BigInteger value)
  System.UInt16 op_Explicit(System.Numerics.BigInteger value)
  System.Int32 op_Explicit(System.Numerics.BigInteger value)
  System.UInt32 op_Explicit(System.Numerics.BigInteger value)
  System.Int64 op_Explicit(System.Numerics.BigInteger value)
  System.UInt64 op_Explicit(System.Numerics.BigInteger value)
  System.Single op_Explicit(System.Numerics.BigInteger value)
  System.Double op_Explicit(System.Numerics.BigInteger value)
  System.Decimal op_Explicit(System.Numerics.BigInteger value)
  System.Numerics.BigInteger op_LeftShift(System.Numerics.BigInteger value, System.Int32 shift)
  System.Numerics.BigInteger op_RightShift(System.Numerics.BigInteger value, System.Int32 shift)
  System.Numerics.BigInteger op_UnaryNegation(System.Numerics.BigInteger value)
  System.Numerics.BigInteger op_Addition(System.Numerics.BigInteger left, System.Numerics.BigInteger right)
  System.Numerics.BigInteger op_Multiply(System.Numerics.BigInteger left, System.Numerics.BigInteger right)
  System.Numerics.BigInteger op_Division(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor)
  System.Boolean op_LessThanOrEqual(System.Numerics.BigInteger left, System.Numerics.BigInteger right)
  System.Boolean op_Inequality(System.Numerics.BigInteger left, System.Numerics.BigInteger right)
  System.Boolean op_LessThan(System.Numerics.BigInteger left, System.Int64 right)
  System.Boolean op_LessThanOrEqual(System.Numerics.BigInteger left, System.Int64 right)
  System.Boolean op_Equality(System.Numerics.BigInteger left, System.Int64 right)
  System.Boolean op_Inequality(System.Numerics.BigInteger left, System.Int64 right)
  System.Boolean op_LessThan(System.Int64 left, System.Numerics.BigInteger right)
  System.Boolean op_LessThanOrEqual(System.Int64 left, System.Numerics.BigInteger right)
  System.Boolean GetPartsForBitManipulation(System.Numerics.BigInteger& x, System.UInt32[]& xd, System.Int32& xl)
  System.Int32 GetDiffLength(System.UInt32[] rgu1, System.UInt32[] rgu2, System.Int32 cu)
  System.Void .cctor()
END_CLASS

CLASS: System.Numerics.BigIntegerCalculator
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  private   static  System.Int32                    ReducerThreshold  // 0x0
  private   static  System.Int32                    SquareThreshold  // 0x4
  private   static  System.Int32                    AllocationThreshold  // 0x8
  private   static  System.Int32                    MultiplyThreshold  // 0xC
METHODS:
  System.UInt32[] Add(System.UInt32[] left, System.UInt32 right)
  System.UInt32[] Add(System.UInt32[] left, System.UInt32[] right)
  System.Void Add(System.UInt32* left, System.Int32 leftLength, System.UInt32* right, System.Int32 rightLength, System.UInt32* bits, System.Int32 bitsLength)
  System.Void AddSelf(System.UInt32* left, System.Int32 leftLength, System.UInt32* right, System.Int32 rightLength)
  System.UInt32[] Subtract(System.UInt32[] left, System.UInt32 right)
  System.UInt32[] Subtract(System.UInt32[] left, System.UInt32[] right)
  System.Void Subtract(System.UInt32* left, System.Int32 leftLength, System.UInt32* right, System.Int32 rightLength, System.UInt32* bits, System.Int32 bitsLength)
  System.Int32 Compare(System.UInt32[] left, System.UInt32[] right)
  System.UInt32[] Divide(System.UInt32[] left, System.UInt32 right)
  System.UInt32[] Divide(System.UInt32[] left, System.UInt32[] right)
  System.Void Divide(System.UInt32* left, System.Int32 leftLength, System.UInt32* right, System.Int32 rightLength, System.UInt32* bits, System.Int32 bitsLength)
  System.UInt32 AddDivisor(System.UInt32* left, System.Int32 leftLength, System.UInt32* right, System.Int32 rightLength)
  System.UInt32 SubtractDivisor(System.UInt32* left, System.Int32 leftLength, System.UInt32* right, System.Int32 rightLength, System.UInt64 q)
  System.Boolean DivideGuessTooBig(System.UInt64 q, System.UInt64 valHi, System.UInt32 valLo, System.UInt32 divHi, System.UInt32 divLo)
  System.UInt32[] CreateCopy(System.UInt32[] value)
  System.Int32 LeadingZeros(System.UInt32 value)
  System.UInt32[] Square(System.UInt32[] value)
  System.Void Square(System.UInt32* value, System.Int32 valueLength, System.UInt32* bits, System.Int32 bitsLength)
  System.UInt32[] Multiply(System.UInt32[] left, System.UInt32 right)
  System.UInt32[] Multiply(System.UInt32[] left, System.UInt32[] right)
  System.Void Multiply(System.UInt32* left, System.Int32 leftLength, System.UInt32* right, System.Int32 rightLength, System.UInt32* bits, System.Int32 bitsLength)
  System.Void SubtractCore(System.UInt32* left, System.Int32 leftLength, System.UInt32* right, System.Int32 rightLength, System.UInt32* core, System.Int32 coreLength)
  System.Void .cctor()
END_CLASS

CLASS: System.Numerics.BigNumber
TYPE:  class
TOKEN: 0x200000D
FIELDS:
METHODS:
  System.Boolean TryValidateParseStyleInteger(System.Globalization.NumberStyles style, System.ArgumentException& e)
  System.Boolean TryParseBigInteger(System.ReadOnlySpan<System.Char> value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info, System.Numerics.BigInteger& result)
  System.Numerics.BigInteger ParseBigInteger(System.String value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info)
  System.Numerics.BigInteger ParseBigInteger(System.ReadOnlySpan<System.Char> value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info)
  System.Boolean HexNumberToBigInteger(System.Numerics.BigNumber.BigNumberBuffer& number, System.Numerics.BigInteger& value)
  System.Boolean NumberToBigInteger(System.Numerics.BigNumber.BigNumberBuffer& number, System.Numerics.BigInteger& value)
  System.Char ParseFormatSpecifier(System.ReadOnlySpan<System.Char> format, System.Int32& digits)
  System.String FormatBigIntegerToHex(System.Boolean targetSpan, System.Numerics.BigInteger value, System.Char format, System.Int32 digits, System.Globalization.NumberFormatInfo info, System.Span<System.Char> destination, System.Int32& charsWritten, System.Boolean& spanSuccess)
  System.String FormatBigInteger(System.Numerics.BigInteger value, System.String format, System.Globalization.NumberFormatInfo info)
  System.String FormatBigInteger(System.Boolean targetSpan, System.Numerics.BigInteger value, System.String formatString, System.ReadOnlySpan<System.Char> formatSpan, System.Globalization.NumberFormatInfo info, System.Span<System.Char> destination, System.Int32& charsWritten, System.Boolean& spanSuccess)
END_CLASS

CLASS: System.Numerics.Complex
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public    static readonly System.Numerics.Complex         Zero  // 0x0
  public    static readonly System.Numerics.Complex         One  // 0x10
  public    static readonly System.Numerics.Complex         ImaginaryOne  // 0x20
  private   static readonly System.Double                   s_sqrtRescaleThreshold  // 0x30
  private   static readonly System.Double                   s_asinOverflowThreshold  // 0x38
  private   static readonly System.Double                   s_log2  // 0x40
  private           System.Double                   m_real  // 0x10
  private           System.Double                   m_imaginary  // 0x18
METHODS:
  System.Void .ctor(System.Double real, System.Double imaginary)
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(System.Numerics.Complex value)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider provider)
  System.Void .cctor()
END_CLASS

CLASS: System.Numerics.DoubleUlong
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public            System.Double                   dbl  // 0x10
  public            System.UInt64                   uu  // 0x10
METHODS:
END_CLASS

CLASS: System.Numerics.NumericsHelpers
TYPE:  class
TOKEN: 0x2000011
FIELDS:
METHODS:
  System.Void GetDoubleParts(System.Double dbl, System.Int32& sign, System.Int32& exp, System.UInt64& man, System.Boolean& fFinite)
  System.Double GetDoubleFromParts(System.Int32 sign, System.Int32 exp, System.UInt64 man)
  System.Void DangerousMakeTwosComplement(System.UInt32[] d)
  System.UInt64 MakeUlong(System.UInt32 uHi, System.UInt32 uLo)
  System.UInt32 Abs(System.Int32 a)
  System.UInt32 CombineHash(System.UInt32 u1, System.UInt32 u2)
  System.Int32 CombineHash(System.Int32 n1, System.Int32 n2)
  System.Int32 CbitHighZero(System.UInt32 u)
  System.Int32 CbitHighZero(System.UInt64 uu)
END_CLASS

CLASS: System.Numerics.Hashing.HashHelpers
TYPE:  class
TOKEN: 0x2000012
FIELDS:
  public    static readonly System.Int32                    RandomSeed  // 0x0
METHODS:
  System.Int32 Combine(System.Int32 h1, System.Int32 h2)
  System.Void .cctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IntrinsicAttribute
TYPE:  class
TOKEN: 0x2000017
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Text.ValueStringBuilder
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  private           System.Char[]                   _arrayToReturnToPool  // 0x10
  private           System.Span<System.Char>        _chars  // 0x18
  private           System.Int32                    _pos  // 0x28
METHODS:
  System.Void .ctor(System.Span<System.Char> initialBuffer)
  System.Int32 get_Length()
  System.String ToString()
  System.Boolean TryCopyTo(System.Span<System.Char> destination, System.Int32& charsWritten)
  System.Void Insert(System.Int32 index, System.Char value, System.Int32 count)
  System.Void Append(System.Char c)
  System.Void Append(System.String s)
  System.Void AppendSlow(System.String s)
  System.Void Append(System.Char c, System.Int32 count)
  System.Void Append(System.Char* value, System.Int32 length)
  System.Span<System.Char> AppendSpan(System.Int32 length)
  System.Void GrowAndAppend(System.Char c)
  System.Void Grow(System.Int32 requiredAdditionalCapacity)
  System.Void Dispose()
END_CLASS

