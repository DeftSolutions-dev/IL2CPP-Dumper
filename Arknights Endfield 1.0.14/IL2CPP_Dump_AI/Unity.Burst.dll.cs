// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Burst.dll
// Classes:  52
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: StaticTypeReinitAttribute
TYPE:  class
TOKEN: 0x2000009
EXTENDS: Attribute
FIELDS:
  public    readonly System.Type                     reinitType  // 0x10
METHODS:
  System.Void .ctor(System.Type toReinit)
END_CLASS

CLASS: IsBurstEnabledDelegate
TYPE:  class
TOKEN: 0x200000B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke()
END_CLASS

CLASS: BurstCompilerHelper
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private   static readonly Unity.Burst.BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegateIsBurstEnabledImpl  // 0x0
  public    static readonly System.Boolean                  IsBurstGenerated  // 0x8
METHODS:
  System.Boolean IsBurstEnabled()
  System.Void DiscardedMethod(System.Boolean& value)
  System.Boolean IsCompiledByBurst(System.Delegate del)
  System.Void .cctor()
END_CLASS

CLASS: FakeDelegate
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  private   readonly System.Reflection.MethodInfo    <Method>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo method)
  System.Reflection.MethodInfo get_Method()
END_CLASS

CLASS: HashCode64`1
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public    static readonly System.Int64                    Value  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: PreserveAttribute
TYPE:  class
TOKEN: 0x2000011
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: PreserveAttribute
TYPE:  class
TOKEN: 0x2000013
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NumberBufferKind
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Burst.BurstString.NumberBufferKindInteger  // 0x0
  public    static  Unity.Burst.BurstString.NumberBufferKindFloat  // 0x0
METHODS:
END_CLASS

CLASS: NumberBuffer
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  private   readonly System.Byte*                    _buffer  // 0x10
  public            Unity.Burst.BurstString.NumberBufferKindKind  // 0x18
  public            System.Int32                    DigitsCount  // 0x1C
  public            System.Int32                    Scale  // 0x20
  public    readonly System.Boolean                  IsNegative  // 0x24
METHODS:
  System.Void .ctor(Unity.Burst.BurstString.NumberBufferKind kind, System.Byte* buffer, System.Int32 digitsCount, System.Int32 scale, System.Boolean isNegative)
  System.Byte* GetDigitsPointer()
END_CLASS

CLASS: NumberFormatKind
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Unity.Burst.BurstString.NumberFormatKindGeneral  // 0x0
  public    static  Unity.Burst.BurstString.NumberFormatKindDecimal  // 0x0
  public    static  Unity.Burst.BurstString.NumberFormatKindDecimalForceSigned  // 0x0
  public    static  Unity.Burst.BurstString.NumberFormatKindHexadecimal  // 0x0
METHODS:
END_CLASS

CLASS: FormatOptions
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            Unity.Burst.BurstString.NumberFormatKindKind  // 0x10
  public            System.SByte                    AlignAndSize  // 0x11
  public            System.Byte                     Specifier  // 0x12
  public            System.Boolean                  Lowercase  // 0x13
METHODS:
  System.Void .ctor(Unity.Burst.BurstString.NumberFormatKind kind, System.SByte alignAndSize, System.Byte specifier, System.Boolean lowercase)
  System.Boolean get_Uppercase()
  System.Int32 GetBase()
  System.String ToString()
END_CLASS

CLASS: tBigInt
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            System.Int32                    m_length  // 0x10
  public            Unity.Burst.BurstString.tBigInt.<m_blocks>e__FixedBufferm_blocks  // 0x14
METHODS:
  System.Int32 GetLength()
  System.UInt32 GetBlock(System.Int32 idx)
  System.Boolean IsZero()
  System.Void SetU64(System.UInt64 val)
  System.Void SetU32(System.UInt32 val)
END_CLASS

CLASS: CutoffMode
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Burst.BurstString.CutoffModeUnique  // 0x0
  public    static  Unity.Burst.BurstString.CutoffModeTotalLength  // 0x0
  public    static  Unity.Burst.BurstString.CutoffModeFractionLength  // 0x0
METHODS:
END_CLASS

CLASS: tFloatUnion32
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            System.Single                   m_floatingPoint  // 0x10
  public            System.UInt32                   m_integer  // 0x10
METHODS:
  System.Boolean IsNegative()
  System.UInt32 GetExponent()
  System.UInt32 GetMantissa()
END_CLASS

CLASS: tFloatUnion64
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Double                   m_floatingPoint  // 0x10
  public            System.UInt64                   m_integer  // 0x10
METHODS:
  System.Boolean IsNegative()
  System.UInt32 GetExponent()
  System.UInt64 GetMantissa()
END_CLASS

CLASS: PreserveAttribute
TYPE:  class
TOKEN: 0x2000021
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Avx
TYPE:  class
TOKEN: 0x200002B
FIELDS:
METHODS:
  Unity.Burst.Intrinsics.v256 mm256_load_ps(System.Void* ptr)
  System.Void mm256_store_ps(System.Void* ptr, Unity.Burst.Intrinsics.v256 val)
  Unity.Burst.Intrinsics.v256 mm256_loadu_si256(System.Void* ptr)
  System.Void mm256_storeu_si256(System.Void* ptr, Unity.Burst.Intrinsics.v256 v)
  Unity.Burst.Intrinsics.v256 mm256_set1_epi32(System.Int32 a)
END_CLASS

CLASS: Avx2
TYPE:  class
TOKEN: 0x200002C
FIELDS:
METHODS:
  System.Boolean get_IsAvx2Supported()
  Unity.Burst.Intrinsics.v256 mm256_xor_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b)
  Unity.Burst.Intrinsics.v256 mm256_add_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b)
  Unity.Burst.Intrinsics.v256 mm256_mul_epu32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b)
  Unity.Burst.Intrinsics.v256 mm256_slli_epi64(Unity.Burst.Intrinsics.v256 a, System.Int32 imm8)
  Unity.Burst.Intrinsics.v256 mm256_srli_epi64(Unity.Burst.Intrinsics.v256 a, System.Int32 imm8)
  Unity.Burst.Intrinsics.v256 mm256_shuffle_epi32(Unity.Burst.Intrinsics.v256 a, System.Int32 imm8)
END_CLASS

CLASS: Sse
TYPE:  class
TOKEN: 0x200002D
FIELDS:
METHODS:
  System.Int32 SHUFFLE(System.Int32 d, System.Int32 c, System.Int32 b, System.Int32 a)
END_CLASS

CLASS: Sse2
TYPE:  class
TOKEN: 0x200002E
FIELDS:
METHODS:
  Unity.Burst.Intrinsics.v128 add_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b)
  Unity.Burst.Intrinsics.v128 mul_epu32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b)
  Unity.Burst.Intrinsics.v128 slli_epi64(Unity.Burst.Intrinsics.v128 a, System.Int32 imm8)
  Unity.Burst.Intrinsics.v128 srli_epi64(Unity.Burst.Intrinsics.v128 a, System.Int32 imm8)
  Unity.Burst.Intrinsics.v128 xor_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b)
  Unity.Burst.Intrinsics.v128 shuffle_epi32(Unity.Burst.Intrinsics.v128 a, System.Int32 imm8)
END_CLASS

CLASS: __StaticArrayInitTypeSize=3
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=32
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=256
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
METHODS:
END_CLASS

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsReadOnlyAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Burst.OptimizeFor
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Burst.OptimizeFor         Default  // 0x0
  public    static  Unity.Burst.OptimizeFor         Performance  // 0x0
  public    static  Unity.Burst.OptimizeFor         Size  // 0x0
  public    static  Unity.Burst.OptimizeFor         FastCompilation  // 0x0
  public    static  Unity.Burst.OptimizeFor         Balanced  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Burst.FloatMode
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Burst.FloatMode           Default  // 0x0
  public    static  Unity.Burst.FloatMode           Strict  // 0x0
  public    static  Unity.Burst.FloatMode           Deterministic  // 0x0
  public    static  Unity.Burst.FloatMode           Fast  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Burst.FloatPrecision
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.Burst.FloatPrecision      Standard  // 0x0
  public    static  Unity.Burst.FloatPrecision      High  // 0x0
  public    static  Unity.Burst.FloatPrecision      Medium  // 0x0
  public    static  Unity.Burst.FloatPrecision      Low  // 0x0
METHODS:
END_CLASS

CLASS: Unity.Burst.BurstCompileAttribute
TYPE:  class
TOKEN: 0x2000007
EXTENDS: Attribute
FIELDS:
  private           Unity.Burst.FloatMode           <FloatMode>k__BackingField  // 0x10
  private           Unity.Burst.FloatPrecision      <FloatPrecision>k__BackingField  // 0x14
  private           System.Nullable<System.Boolean> _compileSynchronously  // 0x18
  private           System.Nullable<System.Boolean> _disableDirectCall  // 0x1A
  private           Unity.Burst.OptimizeFor         <OptimizeFor>k__BackingField  // 0x1C
  private           System.String[]                 <Options>k__BackingField  // 0x20
METHODS:
  System.Void set_FloatMode(Unity.Burst.FloatMode value)
  System.Void set_FloatPrecision(Unity.Burst.FloatPrecision value)
  System.Void set_CompileSynchronously(System.Boolean value)
  System.Void set_DisableDirectCall(System.Boolean value)
  System.Void set_OptimizeFor(Unity.Burst.OptimizeFor value)
  System.Void set_Options(System.String[] value)
  System.Void .ctor()
  System.Void .ctor(Unity.Burst.FloatPrecision floatPrecision, Unity.Burst.FloatMode floatMode)
END_CLASS

CLASS: Unity.Burst.BurstCompiler
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  private   static  System.Boolean                  _IsEnabled  // 0x0
  public    static readonly Unity.Burst.BurstCompilerOptionsOptions  // 0x8
  private   static  System.Action                   OnCompileILPPMethod2  // 0x10
  private   static readonly System.Reflection.MethodInfo    DummyMethodInfo  // 0x18
METHODS:
  System.Boolean get_IsEnabled()
  System.IntPtr CompileILPPMethod2(System.RuntimeMethodHandle burstMethodHandle)
  System.Void* GetILPPMethodFunctionPointer2(System.IntPtr ilppMethod, System.RuntimeMethodHandle managedMethodHandle, System.RuntimeTypeHandle delegateTypeHandle)
  Unity.Burst.FunctionPointer<T> CompileFunctionPointer(T delegateMethod)
  System.Void* Compile(System.Object delegateObj, System.Boolean isFunctionPointer)
  System.Void* Compile(System.Object delegateObj, System.Reflection.MethodInfo methodInfo, System.Boolean isFunctionPointer, System.Boolean isILPostProcessing)
  System.Void DummyMethod()
  System.Void .cctor()
END_CLASS

CLASS: Unity.Burst.BurstCompilerOptions
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  private   static readonly System.Boolean                  ForceDisableBurstCompilation  // 0x0
  private   static readonly System.Boolean                  ForceBurstCompilationSynchronously  // 0x1
  private   static readonly System.Boolean                  IsSecondaryUnityProcess  // 0x2
  private           System.Boolean                  _enableBurstCompilation  // 0x10
  private           System.Boolean                  _enableBurstSafetyChecks  // 0x11
  private   readonly System.Boolean                  <IsGlobal>k__BackingField  // 0x12
  private           System.Action                   <OptionsChanged>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Boolean isGlobal)
  System.Boolean get_IsGlobal()
  System.Boolean get_EnableBurstCompilation()
  System.Void set_EnableBurstCompilation(System.Boolean value)
  System.Void set_EnableBurstSafetyChecks(System.Boolean value)
  System.Action get_OptionsChanged()
  System.Boolean TryGetAttribute(System.Reflection.MemberInfo member, Unity.Burst.BurstCompileAttribute& attribute)
  Unity.Burst.BurstCompileAttribute GetBurstCompileAttribute(System.Reflection.MemberInfo memberInfo)
  System.Boolean HasBurstCompileAttribute(System.Reflection.MemberInfo member)
  System.Void OnOptionsChanged()
  System.Void MaybeTriggerRecompilation()
  System.Void .cctor()
  System.Boolean CheckIsSecondaryUnityProcess()
END_CLASS

CLASS: Unity.Burst.BurstRuntime
TYPE:  class
TOKEN: 0x200000F
FIELDS:
METHODS:
  System.Int64 GetHashCode64()
  System.Int64 HashStringWithFNV1A64(System.String text)
  System.Void PreventRequiredAttributeStrip()
  System.Void Log(System.Byte* message, System.Int32 logType, System.Byte* fileName, System.Int32 lineNumber)
END_CLASS

CLASS: Unity.Burst.BurstString
TYPE:  class
TOKEN: 0x2000012
FIELDS:
  private   static readonly System.Char[]                   SplitByColon  // 0x0
  private   static readonly System.Byte[]                   logTable  // 0x8
  private   static readonly System.UInt32[]                 g_PowerOf10_U32  // 0x10
  private   static readonly System.Byte[]                   InfinityString  // 0x18
  private   static readonly System.Byte[]                   NanString  // 0x20
METHODS:
  System.Void CopyFixedString(System.Byte* dest, System.Int32 destLength, System.Byte* src, System.Int32 srcLength)
  System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Byte* src, System.Int32 srcLength, System.Int32 formatOptionsRaw)
  System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Single value, System.Int32 formatOptionsRaw)
  System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Double value, System.Int32 formatOptionsRaw)
  System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Boolean value, System.Int32 formatOptionsRaw)
  System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Char value, System.Int32 formatOptionsRaw)
  System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Byte value, System.Int32 formatOptionsRaw)
  System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.UInt16 value, System.Int32 formatOptionsRaw)
  System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.UInt32 value, System.Int32 formatOptionsRaw)
  System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.UInt64 value, System.Int32 formatOptionsRaw)
  System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.SByte value, System.Int32 formatOptionsRaw)
  System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Int16 value, System.Int32 formatOptionsRaw)
  System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Int32 value, System.Int32 formatOptionsRaw)
  System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Int64 value, System.Int32 formatOptionsRaw)
  System.Void ConvertUnsignedIntegerToString(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.UInt64 value, Unity.Burst.BurstString.FormatOptions options)
  System.Int32 GetLengthIntegerToString(System.Int64 value, System.Int32 basis, System.Int32 zeroPadding)
  System.Void ConvertIntegerToString(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Int64 value, Unity.Burst.BurstString.FormatOptions options)
  System.Void FormatNumber(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, Unity.Burst.BurstString.NumberBuffer& number, System.Int32 nMaxDigits, Unity.Burst.BurstString.FormatOptions options)
  System.Void FormatDecimalOrHexadecimal(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, Unity.Burst.BurstString.NumberBuffer& number, System.Int32 zeroPadding, System.Boolean outputPositiveSign)
  System.Byte ValueToIntegerChar(System.Int32 value, System.Boolean uppercase)
  System.Boolean AlignRight(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Int32 align, System.Int32 length)
  System.Boolean AlignLeft(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Int32 align, System.Int32 length)
  System.Int32 GetLengthForFormatGeneral(Unity.Burst.BurstString.NumberBuffer& number, System.Int32 nMaxDigits)
  System.Void FormatGeneral(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, Unity.Burst.BurstString.NumberBuffer& number, System.Int32 nMaxDigits, System.Byte expChar)
  System.Void RoundNumber(Unity.Burst.BurstString.NumberBuffer& number, System.Int32 pos, System.Boolean isCorrectlyRounded)
  System.Boolean ShouldRoundUp(System.Byte* dig, System.Int32 i, System.Boolean isCorrectlyRounded)
  System.UInt32 LogBase2(System.UInt32 val)
  System.Int32 BigInt_Compare(Unity.Burst.BurstString.tBigInt& lhs, Unity.Burst.BurstString.tBigInt& rhs)
  System.Void BigInt_Add(Unity.Burst.BurstString.tBigInt& pResult, Unity.Burst.BurstString.tBigInt& lhs, Unity.Burst.BurstString.tBigInt& rhs)
  System.Void BigInt_Add_internal(Unity.Burst.BurstString.tBigInt& pResult, Unity.Burst.BurstString.tBigInt& pLarge, Unity.Burst.BurstString.tBigInt& pSmall)
  System.Void BigInt_Multiply(Unity.Burst.BurstString.tBigInt& pResult, Unity.Burst.BurstString.tBigInt& lhs, Unity.Burst.BurstString.tBigInt& rhs)
  System.Void BigInt_Multiply_internal(Unity.Burst.BurstString.tBigInt& pResult, Unity.Burst.BurstString.tBigInt& pLarge, Unity.Burst.BurstString.tBigInt& pSmall)
  System.Void BigInt_Multiply(Unity.Burst.BurstString.tBigInt& pResult, Unity.Burst.BurstString.tBigInt& lhs, System.UInt32 rhs)
  System.Void BigInt_Multiply2(Unity.Burst.BurstString.tBigInt& pResult, Unity.Burst.BurstString.tBigInt& input)
  System.Void BigInt_Multiply2(Unity.Burst.BurstString.tBigInt& pResult)
  System.Void BigInt_Multiply10(Unity.Burst.BurstString.tBigInt& pResult)
  Unity.Burst.BurstString.tBigInt g_PowerOf10_Big(System.Int32 i)
  System.Void BigInt_Pow10(Unity.Burst.BurstString.tBigInt& pResult, System.UInt32 exponent)
  System.Void BigInt_MultiplyPow10(Unity.Burst.BurstString.tBigInt& pResult, Unity.Burst.BurstString.tBigInt& input, System.UInt32 exponent)
  System.Void BigInt_Pow2(Unity.Burst.BurstString.tBigInt& pResult, System.UInt32 exponent)
  System.UInt32 BigInt_DivideWithRemainder_MaxQuotient9(Unity.Burst.BurstString.tBigInt& pDividend, Unity.Burst.BurstString.tBigInt& divisor)
  System.Void BigInt_ShiftLeft(Unity.Burst.BurstString.tBigInt& pResult, System.UInt32 shift)
  System.UInt32 Dragon4(System.UInt64 mantissa, System.Int32 exponent, System.UInt32 mantissaHighBitIdx, System.Boolean hasUnequalMargins, Unity.Burst.BurstString.CutoffMode cutoffMode, System.UInt32 cutoffNumber, System.Byte* pOutBuffer, System.UInt32 bufferSize, System.Int32& pOutExponent)
  System.Void FormatInfinityNaN(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.UInt64 mantissa, System.Boolean isNegative, Unity.Burst.BurstString.FormatOptions formatOptions)
  System.Void ConvertFloatToString(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Single value, Unity.Burst.BurstString.FormatOptions formatOptions)
  System.Void ConvertDoubleToString(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Double value, Unity.Burst.BurstString.FormatOptions formatOptions)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Burst.FunctionPointer`1
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  private   readonly System.IntPtr                   _ptr  // 0x0
METHODS:
  System.Void .ctor(System.IntPtr ptr)
  T get_Invoke()
END_CLASS

CLASS: Unity.Burst.NoAliasAttribute
TYPE:  class
TOKEN: 0x200001E
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Burst.SharedStatic`1
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  private   readonly System.Void*                    _buffer  // 0x0
METHODS:
  System.Void .ctor(System.Void* buffer)
  T& get_Data()
  System.Void* get_UnsafeDataPointer()
  Unity.Burst.SharedStatic<T> GetOrCreate(System.UInt32 alignment)
  Unity.Burst.SharedStatic<T> GetOrCreateUnsafe(System.UInt32 alignment, System.Int64 hashCode, System.Int64 subHashCode)
END_CLASS

CLASS: Unity.Burst.SharedStatic
TYPE:  class
TOKEN: 0x2000020
FIELDS:
METHODS:
  System.Void* GetOrCreateSharedStaticInternal(System.Int64 getHashCode64, System.Int64 getSubHashCode64, System.UInt32 sizeOf, System.UInt32 alignment)
END_CLASS

CLASS: Unity.Burst.CompilerServices.AssumeRangeAttribute
TYPE:  class
TOKEN: 0x200002F
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor(System.Int64 min, System.Int64 max)
END_CLASS

CLASS: Unity.Burst.CompilerServices.Hint
TYPE:  class
TOKEN: 0x2000030
FIELDS:
METHODS:
  System.Boolean Likely(System.Boolean condition)
END_CLASS

CLASS: Unity.Burst.Intrinsics.Common
TYPE:  class
TOKEN: 0x2000022
FIELDS:
METHODS:
  System.UInt64 umul128(System.UInt64 x, System.UInt64 y, System.UInt64& high)
END_CLASS

CLASS: Unity.Burst.Intrinsics.BurstTargetCpuAttribute
TYPE:  class
TOKEN: 0x2000023
EXTENDS: Attribute
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Burst.Intrinsics.V64DebugView
TYPE:  class
TOKEN: 0x2000024
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Burst.Intrinsics.V128DebugView
TYPE:  class
TOKEN: 0x2000025
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Burst.Intrinsics.V256DebugView
TYPE:  class
TOKEN: 0x2000026
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.Burst.Intrinsics.v128
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Byte                     Byte0  // 0x10
  public            System.Byte                     Byte1  // 0x11
  public            System.Byte                     Byte2  // 0x12
  public            System.Byte                     Byte3  // 0x13
  public            System.Byte                     Byte4  // 0x14
  public            System.Byte                     Byte5  // 0x15
  public            System.Byte                     Byte6  // 0x16
  public            System.Byte                     Byte7  // 0x17
  public            System.Byte                     Byte8  // 0x18
  public            System.Byte                     Byte9  // 0x19
  public            System.Byte                     Byte10  // 0x1A
  public            System.Byte                     Byte11  // 0x1B
  public            System.Byte                     Byte12  // 0x1C
  public            System.Byte                     Byte13  // 0x1D
  public            System.Byte                     Byte14  // 0x1E
  public            System.Byte                     Byte15  // 0x1F
  public            System.SByte                    SByte0  // 0x10
  public            System.SByte                    SByte1  // 0x11
  public            System.SByte                    SByte2  // 0x12
  public            System.SByte                    SByte3  // 0x13
  public            System.SByte                    SByte4  // 0x14
  public            System.SByte                    SByte5  // 0x15
  public            System.SByte                    SByte6  // 0x16
  public            System.SByte                    SByte7  // 0x17
  public            System.SByte                    SByte8  // 0x18
  public            System.SByte                    SByte9  // 0x19
  public            System.SByte                    SByte10  // 0x1A
  public            System.SByte                    SByte11  // 0x1B
  public            System.SByte                    SByte12  // 0x1C
  public            System.SByte                    SByte13  // 0x1D
  public            System.SByte                    SByte14  // 0x1E
  public            System.SByte                    SByte15  // 0x1F
  public            System.UInt16                   UShort0  // 0x10
  public            System.UInt16                   UShort1  // 0x12
  public            System.UInt16                   UShort2  // 0x14
  public            System.UInt16                   UShort3  // 0x16
  public            System.UInt16                   UShort4  // 0x18
  public            System.UInt16                   UShort5  // 0x1A
  public            System.UInt16                   UShort6  // 0x1C
  public            System.UInt16                   UShort7  // 0x1E
  public            System.Int16                    SShort0  // 0x10
  public            System.Int16                    SShort1  // 0x12
  public            System.Int16                    SShort2  // 0x14
  public            System.Int16                    SShort3  // 0x16
  public            System.Int16                    SShort4  // 0x18
  public            System.Int16                    SShort5  // 0x1A
  public            System.Int16                    SShort6  // 0x1C
  public            System.Int16                    SShort7  // 0x1E
  public            System.UInt32                   UInt0  // 0x10
  public            System.UInt32                   UInt1  // 0x14
  public            System.UInt32                   UInt2  // 0x18
  public            System.UInt32                   UInt3  // 0x1C
  public            System.Int32                    SInt0  // 0x10
  public            System.Int32                    SInt1  // 0x14
  public            System.Int32                    SInt2  // 0x18
  public            System.Int32                    SInt3  // 0x1C
  public            System.UInt64                   ULong0  // 0x10
  public            System.UInt64                   ULong1  // 0x18
  public            System.Int64                    SLong0  // 0x10
  public            System.Int64                    SLong1  // 0x18
  public            System.Single                   Float0  // 0x10
  public            System.Single                   Float1  // 0x14
  public            System.Single                   Float2  // 0x18
  public            System.Single                   Float3  // 0x1C
  public            System.Double                   Double0  // 0x10
  public            System.Double                   Double1  // 0x18
  public            Unity.Burst.Intrinsics.v64      Lo64  // 0x10
  public            Unity.Burst.Intrinsics.v64      Hi64  // 0x18
METHODS:
END_CLASS

CLASS: Unity.Burst.Intrinsics.v256
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  public            System.Byte                     Byte0  // 0x10
  public            System.Byte                     Byte1  // 0x11
  public            System.Byte                     Byte2  // 0x12
  public            System.Byte                     Byte3  // 0x13
  public            System.Byte                     Byte4  // 0x14
  public            System.Byte                     Byte5  // 0x15
  public            System.Byte                     Byte6  // 0x16
  public            System.Byte                     Byte7  // 0x17
  public            System.Byte                     Byte8  // 0x18
  public            System.Byte                     Byte9  // 0x19
  public            System.Byte                     Byte10  // 0x1A
  public            System.Byte                     Byte11  // 0x1B
  public            System.Byte                     Byte12  // 0x1C
  public            System.Byte                     Byte13  // 0x1D
  public            System.Byte                     Byte14  // 0x1E
  public            System.Byte                     Byte15  // 0x1F
  public            System.Byte                     Byte16  // 0x20
  public            System.Byte                     Byte17  // 0x21
  public            System.Byte                     Byte18  // 0x22
  public            System.Byte                     Byte19  // 0x23
  public            System.Byte                     Byte20  // 0x24
  public            System.Byte                     Byte21  // 0x25
  public            System.Byte                     Byte22  // 0x26
  public            System.Byte                     Byte23  // 0x27
  public            System.Byte                     Byte24  // 0x28
  public            System.Byte                     Byte25  // 0x29
  public            System.Byte                     Byte26  // 0x2A
  public            System.Byte                     Byte27  // 0x2B
  public            System.Byte                     Byte28  // 0x2C
  public            System.Byte                     Byte29  // 0x2D
  public            System.Byte                     Byte30  // 0x2E
  public            System.Byte                     Byte31  // 0x2F
  public            System.SByte                    SByte0  // 0x10
  public            System.SByte                    SByte1  // 0x11
  public            System.SByte                    SByte2  // 0x12
  public            System.SByte                    SByte3  // 0x13
  public            System.SByte                    SByte4  // 0x14
  public            System.SByte                    SByte5  // 0x15
  public            System.SByte                    SByte6  // 0x16
  public            System.SByte                    SByte7  // 0x17
  public            System.SByte                    SByte8  // 0x18
  public            System.SByte                    SByte9  // 0x19
  public            System.SByte                    SByte10  // 0x1A
  public            System.SByte                    SByte11  // 0x1B
  public            System.SByte                    SByte12  // 0x1C
  public            System.SByte                    SByte13  // 0x1D
  public            System.SByte                    SByte14  // 0x1E
  public            System.SByte                    SByte15  // 0x1F
  public            System.SByte                    SByte16  // 0x20
  public            System.SByte                    SByte17  // 0x21
  public            System.SByte                    SByte18  // 0x22
  public            System.SByte                    SByte19  // 0x23
  public            System.SByte                    SByte20  // 0x24
  public            System.SByte                    SByte21  // 0x25
  public            System.SByte                    SByte22  // 0x26
  public            System.SByte                    SByte23  // 0x27
  public            System.SByte                    SByte24  // 0x28
  public            System.SByte                    SByte25  // 0x29
  public            System.SByte                    SByte26  // 0x2A
  public            System.SByte                    SByte27  // 0x2B
  public            System.SByte                    SByte28  // 0x2C
  public            System.SByte                    SByte29  // 0x2D
  public            System.SByte                    SByte30  // 0x2E
  public            System.SByte                    SByte31  // 0x2F
  public            System.UInt16                   UShort0  // 0x10
  public            System.UInt16                   UShort1  // 0x12
  public            System.UInt16                   UShort2  // 0x14
  public            System.UInt16                   UShort3  // 0x16
  public            System.UInt16                   UShort4  // 0x18
  public            System.UInt16                   UShort5  // 0x1A
  public            System.UInt16                   UShort6  // 0x1C
  public            System.UInt16                   UShort7  // 0x1E
  public            System.UInt16                   UShort8  // 0x20
  public            System.UInt16                   UShort9  // 0x22
  public            System.UInt16                   UShort10  // 0x24
  public            System.UInt16                   UShort11  // 0x26
  public            System.UInt16                   UShort12  // 0x28
  public            System.UInt16                   UShort13  // 0x2A
  public            System.UInt16                   UShort14  // 0x2C
  public            System.UInt16                   UShort15  // 0x2E
  public            System.Int16                    SShort0  // 0x10
  public            System.Int16                    SShort1  // 0x12
  public            System.Int16                    SShort2  // 0x14
  public            System.Int16                    SShort3  // 0x16
  public            System.Int16                    SShort4  // 0x18
  public            System.Int16                    SShort5  // 0x1A
  public            System.Int16                    SShort6  // 0x1C
  public            System.Int16                    SShort7  // 0x1E
  public            System.Int16                    SShort8  // 0x20
  public            System.Int16                    SShort9  // 0x22
  public            System.Int16                    SShort10  // 0x24
  public            System.Int16                    SShort11  // 0x26
  public            System.Int16                    SShort12  // 0x28
  public            System.Int16                    SShort13  // 0x2A
  public            System.Int16                    SShort14  // 0x2C
  public            System.Int16                    SShort15  // 0x2E
  public            System.UInt32                   UInt0  // 0x10
  public            System.UInt32                   UInt1  // 0x14
  public            System.UInt32                   UInt2  // 0x18
  public            System.UInt32                   UInt3  // 0x1C
  public            System.UInt32                   UInt4  // 0x20
  public            System.UInt32                   UInt5  // 0x24
  public            System.UInt32                   UInt6  // 0x28
  public            System.UInt32                   UInt7  // 0x2C
  public            System.Int32                    SInt0  // 0x10
  public            System.Int32                    SInt1  // 0x14
  public            System.Int32                    SInt2  // 0x18
  public            System.Int32                    SInt3  // 0x1C
  public            System.Int32                    SInt4  // 0x20
  public            System.Int32                    SInt5  // 0x24
  public            System.Int32                    SInt6  // 0x28
  public            System.Int32                    SInt7  // 0x2C
  public            System.UInt64                   ULong0  // 0x10
  public            System.UInt64                   ULong1  // 0x18
  public            System.UInt64                   ULong2  // 0x20
  public            System.UInt64                   ULong3  // 0x28
  public            System.Int64                    SLong0  // 0x10
  public            System.Int64                    SLong1  // 0x18
  public            System.Int64                    SLong2  // 0x20
  public            System.Int64                    SLong3  // 0x28
  public            System.Single                   Float0  // 0x10
  public            System.Single                   Float1  // 0x14
  public            System.Single                   Float2  // 0x18
  public            System.Single                   Float3  // 0x1C
  public            System.Single                   Float4  // 0x20
  public            System.Single                   Float5  // 0x24
  public            System.Single                   Float6  // 0x28
  public            System.Single                   Float7  // 0x2C
  public            System.Double                   Double0  // 0x10
  public            System.Double                   Double1  // 0x18
  public            System.Double                   Double2  // 0x20
  public            System.Double                   Double3  // 0x28
  public            Unity.Burst.Intrinsics.v128     Lo128  // 0x10
  public            Unity.Burst.Intrinsics.v128     Hi128  // 0x20
METHODS:
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Burst.Intrinsics.v128 lo, Unity.Burst.Intrinsics.v128 hi)
END_CLASS

CLASS: Unity.Burst.Intrinsics.v64
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.Byte                     Byte0  // 0x10
  public            System.Byte                     Byte1  // 0x11
  public            System.Byte                     Byte2  // 0x12
  public            System.Byte                     Byte3  // 0x13
  public            System.Byte                     Byte4  // 0x14
  public            System.Byte                     Byte5  // 0x15
  public            System.Byte                     Byte6  // 0x16
  public            System.Byte                     Byte7  // 0x17
  public            System.SByte                    SByte0  // 0x10
  public            System.SByte                    SByte1  // 0x11
  public            System.SByte                    SByte2  // 0x12
  public            System.SByte                    SByte3  // 0x13
  public            System.SByte                    SByte4  // 0x14
  public            System.SByte                    SByte5  // 0x15
  public            System.SByte                    SByte6  // 0x16
  public            System.SByte                    SByte7  // 0x17
  public            System.UInt16                   UShort0  // 0x10
  public            System.UInt16                   UShort1  // 0x12
  public            System.UInt16                   UShort2  // 0x14
  public            System.UInt16                   UShort3  // 0x16
  public            System.Int16                    SShort0  // 0x10
  public            System.Int16                    SShort1  // 0x12
  public            System.Int16                    SShort2  // 0x14
  public            System.Int16                    SShort3  // 0x16
  public            System.UInt32                   UInt0  // 0x10
  public            System.UInt32                   UInt1  // 0x14
  public            System.Int32                    SInt0  // 0x10
  public            System.Int32                    SInt1  // 0x14
  public            System.UInt64                   ULong0  // 0x10
  public            System.Int64                    SLong0  // 0x10
  public            System.Single                   Float0  // 0x10
  public            System.Single                   Float1  // 0x14
  public            System.Double                   Double0  // 0x10
METHODS:
END_CLASS

CLASS: Unity.Burst.Intrinsics.X86
TYPE:  class
TOKEN: 0x200002A
FIELDS:
METHODS:
END_CLASS

