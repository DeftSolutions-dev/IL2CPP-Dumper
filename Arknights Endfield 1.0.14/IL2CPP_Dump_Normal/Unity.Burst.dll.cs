// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Burst.dll
// Classes:  52
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000009
    public class StaticTypeReinitAttribute : Attribute
    {
        // Fields
        public readonly System.Type reinitType;        // 0x10

        // Methods
        private System.Void .ctor(System.Type toReinit) { }

    }

    // TypeToken: 0x200000B
    public class IsBurstEnabledDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke() { }

    }

    // TypeToken: 0x200000A
    public class BurstCompilerHelper
    {
        // Fields
        private static readonly Unity.Burst.BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate IsBurstEnabledImpl;        // 0x0
        public static readonly System.Boolean IsBurstGenerated;        // 0x8

        // Methods
        private System.Boolean IsBurstEnabled() { }
        private System.Void DiscardedMethod(System.Boolean& value) { }
        private System.Boolean IsCompiledByBurst(System.Delegate del) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000C
    public class FakeDelegate
    {
        // Fields
        private readonly System.Reflection.MethodInfo <Method>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo method) { }
        private System.Reflection.MethodInfo get_Method() { }

    }

    // TypeToken: 0x2000010
    public struct HashCode64`1
    {
        // Fields
        public static readonly System.Int64 Value;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000011
    public class PreserveAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public class PreserveAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public struct NumberBufferKind
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Burst.BurstString.NumberBufferKind Integer;        // 0x0
        public static Unity.Burst.BurstString.NumberBufferKind Float;        // 0x0

    }

    // TypeToken: 0x2000015
    public struct NumberBuffer
    {
        // Fields
        private readonly System.Byte* _buffer;        // 0x10
        public Unity.Burst.BurstString.NumberBufferKind Kind;        // 0x18
        public System.Int32 DigitsCount;        // 0x1C
        public System.Int32 Scale;        // 0x20
        public readonly System.Boolean IsNegative;        // 0x24

        // Methods
        private System.Void .ctor(Unity.Burst.BurstString.NumberBufferKind kind, System.Byte* buffer, System.Int32 digitsCount, System.Int32 scale, System.Boolean isNegative) { }
        private System.Byte* GetDigitsPointer() { }

    }

    // TypeToken: 0x2000016
    public struct NumberFormatKind
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static Unity.Burst.BurstString.NumberFormatKind General;        // 0x0
        public static Unity.Burst.BurstString.NumberFormatKind Decimal;        // 0x0
        public static Unity.Burst.BurstString.NumberFormatKind DecimalForceSigned;        // 0x0
        public static Unity.Burst.BurstString.NumberFormatKind Hexadecimal;        // 0x0

    }

    // TypeToken: 0x2000017
    public struct FormatOptions
    {
        // Fields
        public Unity.Burst.BurstString.NumberFormatKind Kind;        // 0x10
        public System.SByte AlignAndSize;        // 0x11
        public System.Byte Specifier;        // 0x12
        public System.Boolean Lowercase;        // 0x13

        // Methods
        private System.Void .ctor(Unity.Burst.BurstString.NumberFormatKind kind, System.SByte alignAndSize, System.Byte specifier, System.Boolean lowercase) { }
        private System.Boolean get_Uppercase() { }
        private System.Int32 GetBase() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000018
    public struct tBigInt
    {
        // Fields
        public System.Int32 m_length;        // 0x10
        public Unity.Burst.BurstString.tBigInt.<m_blocks>e__FixedBuffer m_blocks;        // 0x14

        // Methods
        private System.Int32 GetLength() { }
        private System.UInt32 GetBlock(System.Int32 idx) { }
        private System.Boolean IsZero() { }
        private System.Void SetU64(System.UInt64 val) { }
        private System.Void SetU32(System.UInt32 val) { }

    }

    // TypeToken: 0x200001A
    public struct CutoffMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Burst.BurstString.CutoffMode Unique;        // 0x0
        public static Unity.Burst.BurstString.CutoffMode TotalLength;        // 0x0
        public static Unity.Burst.BurstString.CutoffMode FractionLength;        // 0x0

    }

    // TypeToken: 0x200001B
    public struct tFloatUnion32
    {
        // Fields
        public System.Single m_floatingPoint;        // 0x10
        public System.UInt32 m_integer;        // 0x10

        // Methods
        private System.Boolean IsNegative() { }
        private System.UInt32 GetExponent() { }
        private System.UInt32 GetMantissa() { }

    }

    // TypeToken: 0x200001C
    public struct tFloatUnion64
    {
        // Fields
        public System.Double m_floatingPoint;        // 0x10
        public System.UInt64 m_integer;        // 0x10

        // Methods
        private System.Boolean IsNegative() { }
        private System.UInt32 GetExponent() { }
        private System.UInt64 GetMantissa() { }

    }

    // TypeToken: 0x2000021
    public class PreserveAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002B
    public class Avx
    {
        // Methods
        private Unity.Burst.Intrinsics.v256 mm256_load_ps(System.Void* ptr) { }
        private System.Void mm256_store_ps(System.Void* ptr, Unity.Burst.Intrinsics.v256 val) { }
        private Unity.Burst.Intrinsics.v256 mm256_loadu_si256(System.Void* ptr) { }
        private System.Void mm256_storeu_si256(System.Void* ptr, Unity.Burst.Intrinsics.v256 v) { }
        private Unity.Burst.Intrinsics.v256 mm256_set1_epi32(System.Int32 a) { }

    }

    // TypeToken: 0x200002C
    public class Avx2
    {
        // Methods
        private System.Boolean get_IsAvx2Supported() { }
        private Unity.Burst.Intrinsics.v256 mm256_xor_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b) { }
        private Unity.Burst.Intrinsics.v256 mm256_add_epi64(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b) { }
        private Unity.Burst.Intrinsics.v256 mm256_mul_epu32(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b) { }
        private Unity.Burst.Intrinsics.v256 mm256_slli_epi64(Unity.Burst.Intrinsics.v256 a, System.Int32 imm8) { }
        private Unity.Burst.Intrinsics.v256 mm256_srli_epi64(Unity.Burst.Intrinsics.v256 a, System.Int32 imm8) { }
        private Unity.Burst.Intrinsics.v256 mm256_shuffle_epi32(Unity.Burst.Intrinsics.v256 a, System.Int32 imm8) { }

    }

    // TypeToken: 0x200002D
    public class Sse
    {
        // Methods
        private System.Int32 SHUFFLE(System.Int32 d, System.Int32 c, System.Int32 b, System.Int32 a) { }

    }

    // TypeToken: 0x200002E
    public class Sse2
    {
        // Methods
        private Unity.Burst.Intrinsics.v128 add_epi64(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b) { }
        private Unity.Burst.Intrinsics.v128 mul_epu32(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b) { }
        private Unity.Burst.Intrinsics.v128 slli_epi64(Unity.Burst.Intrinsics.v128 a, System.Int32 imm8) { }
        private Unity.Burst.Intrinsics.v128 srli_epi64(Unity.Burst.Intrinsics.v128 a, System.Int32 imm8) { }
        private Unity.Burst.Intrinsics.v128 xor_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b) { }
        private Unity.Burst.Intrinsics.v128 shuffle_epi32(Unity.Burst.Intrinsics.v128 a, System.Int32 imm8) { }

    }

    // TypeToken: 0x2000032
    public struct __StaticArrayInitTypeSize=3
    {
    }

    // TypeToken: 0x2000033
    public struct __StaticArrayInitTypeSize=32
    {
    }

    // TypeToken: 0x2000034
    public struct __StaticArrayInitTypeSize=256
    {
    }

namespace Microsoft.CodeAnalysis
{

    // TypeToken: 0x2000002
    public class EmbeddedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003
    public class IsReadOnlyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace Unity.Burst
{

    // TypeToken: 0x2000004
    public struct OptimizeFor
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Burst.OptimizeFor Default;        // 0x0
        public static Unity.Burst.OptimizeFor Performance;        // 0x0
        public static Unity.Burst.OptimizeFor Size;        // 0x0
        public static Unity.Burst.OptimizeFor FastCompilation;        // 0x0
        public static Unity.Burst.OptimizeFor Balanced;        // 0x0

    }

    // TypeToken: 0x2000005
    public struct FloatMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Burst.FloatMode Default;        // 0x0
        public static Unity.Burst.FloatMode Strict;        // 0x0
        public static Unity.Burst.FloatMode Deterministic;        // 0x0
        public static Unity.Burst.FloatMode Fast;        // 0x0

    }

    // TypeToken: 0x2000006
    public struct FloatPrecision
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.Burst.FloatPrecision Standard;        // 0x0
        public static Unity.Burst.FloatPrecision High;        // 0x0
        public static Unity.Burst.FloatPrecision Medium;        // 0x0
        public static Unity.Burst.FloatPrecision Low;        // 0x0

    }

    // TypeToken: 0x2000007
    public class BurstCompileAttribute : Attribute
    {
        // Fields
        private Unity.Burst.FloatMode <FloatMode>k__BackingField;        // 0x10
        private Unity.Burst.FloatPrecision <FloatPrecision>k__BackingField;        // 0x14
        private System.Nullable<System.Boolean> _compileSynchronously;        // 0x18
        private System.Nullable<System.Boolean> _disableDirectCall;        // 0x1A
        private Unity.Burst.OptimizeFor <OptimizeFor>k__BackingField;        // 0x1C
        private System.String[] <Options>k__BackingField;        // 0x20

        // Methods
        private System.Void set_FloatMode(Unity.Burst.FloatMode value) { }
        private System.Void set_FloatPrecision(Unity.Burst.FloatPrecision value) { }
        private System.Void set_CompileSynchronously(System.Boolean value) { }
        private System.Void set_DisableDirectCall(System.Boolean value) { }
        private System.Void set_OptimizeFor(Unity.Burst.OptimizeFor value) { }
        private System.Void set_Options(System.String[] value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(Unity.Burst.FloatPrecision floatPrecision, Unity.Burst.FloatMode floatMode) { }

    }

    // TypeToken: 0x2000008
    public class BurstCompiler
    {
        // Fields
        private static System.Boolean _IsEnabled;        // 0x0
        public static readonly Unity.Burst.BurstCompilerOptions Options;        // 0x8
        private static System.Action OnCompileILPPMethod2;        // 0x10
        private static readonly System.Reflection.MethodInfo DummyMethodInfo;        // 0x18

        // Methods
        private System.Boolean get_IsEnabled() { }
        private System.IntPtr CompileILPPMethod2(System.RuntimeMethodHandle burstMethodHandle) { }
        private System.Void* GetILPPMethodFunctionPointer2(System.IntPtr ilppMethod, System.RuntimeMethodHandle managedMethodHandle, System.RuntimeTypeHandle delegateTypeHandle) { }
        private Unity.Burst.FunctionPointer<T> CompileFunctionPointer(T delegateMethod) { }
        private System.Void* Compile(System.Object delegateObj, System.Boolean isFunctionPointer) { }
        private System.Void* Compile(System.Object delegateObj, System.Reflection.MethodInfo methodInfo, System.Boolean isFunctionPointer, System.Boolean isILPostProcessing) { }
        private System.Void DummyMethod() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000E
    public class BurstCompilerOptions
    {
        // Fields
        private static readonly System.Boolean ForceDisableBurstCompilation;        // 0x0
        private static readonly System.Boolean ForceBurstCompilationSynchronously;        // 0x1
        private static readonly System.Boolean IsSecondaryUnityProcess;        // 0x2
        private System.Boolean _enableBurstCompilation;        // 0x10
        private System.Boolean _enableBurstSafetyChecks;        // 0x11
        private readonly System.Boolean <IsGlobal>k__BackingField;        // 0x12
        private System.Action <OptionsChanged>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Boolean isGlobal) { }
        private System.Boolean get_IsGlobal() { }
        private System.Boolean get_EnableBurstCompilation() { }
        private System.Void set_EnableBurstCompilation(System.Boolean value) { }
        private System.Void set_EnableBurstSafetyChecks(System.Boolean value) { }
        private System.Action get_OptionsChanged() { }
        private System.Boolean TryGetAttribute(System.Reflection.MemberInfo member, Unity.Burst.BurstCompileAttribute& attribute) { }
        private Unity.Burst.BurstCompileAttribute GetBurstCompileAttribute(System.Reflection.MemberInfo memberInfo) { }
        private System.Boolean HasBurstCompileAttribute(System.Reflection.MemberInfo member) { }
        private System.Void OnOptionsChanged() { }
        private System.Void MaybeTriggerRecompilation() { }
        private System.Void .cctor() { }
        private System.Boolean CheckIsSecondaryUnityProcess() { }

    }

    // TypeToken: 0x200000F
    public class BurstRuntime
    {
        // Methods
        private System.Int64 GetHashCode64() { }
        private System.Int64 HashStringWithFNV1A64(System.String text) { }
        private System.Void PreventRequiredAttributeStrip() { }
        private System.Void Log(System.Byte* message, System.Int32 logType, System.Byte* fileName, System.Int32 lineNumber) { }

    }

    // TypeToken: 0x2000012
    public class BurstString
    {
        // Fields
        private static readonly System.Char[] SplitByColon;        // 0x0
        private static readonly System.Byte[] logTable;        // 0x8
        private static readonly System.UInt32[] g_PowerOf10_U32;        // 0x10
        private static readonly System.Byte[] InfinityString;        // 0x18
        private static readonly System.Byte[] NanString;        // 0x20

        // Methods
        private System.Void CopyFixedString(System.Byte* dest, System.Int32 destLength, System.Byte* src, System.Int32 srcLength) { }
        private System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Byte* src, System.Int32 srcLength, System.Int32 formatOptionsRaw) { }
        private System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Single value, System.Int32 formatOptionsRaw) { }
        private System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Double value, System.Int32 formatOptionsRaw) { }
        private System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Boolean value, System.Int32 formatOptionsRaw) { }
        private System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Char value, System.Int32 formatOptionsRaw) { }
        private System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Byte value, System.Int32 formatOptionsRaw) { }
        private System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.UInt16 value, System.Int32 formatOptionsRaw) { }
        private System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.UInt32 value, System.Int32 formatOptionsRaw) { }
        private System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.UInt64 value, System.Int32 formatOptionsRaw) { }
        private System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.SByte value, System.Int32 formatOptionsRaw) { }
        private System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Int16 value, System.Int32 formatOptionsRaw) { }
        private System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Int32 value, System.Int32 formatOptionsRaw) { }
        private System.Void Format(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Int64 value, System.Int32 formatOptionsRaw) { }
        private System.Void ConvertUnsignedIntegerToString(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.UInt64 value, Unity.Burst.BurstString.FormatOptions options) { }
        private System.Int32 GetLengthIntegerToString(System.Int64 value, System.Int32 basis, System.Int32 zeroPadding) { }
        private System.Void ConvertIntegerToString(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Int64 value, Unity.Burst.BurstString.FormatOptions options) { }
        private System.Void FormatNumber(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, Unity.Burst.BurstString.NumberBuffer& number, System.Int32 nMaxDigits, Unity.Burst.BurstString.FormatOptions options) { }
        private System.Void FormatDecimalOrHexadecimal(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, Unity.Burst.BurstString.NumberBuffer& number, System.Int32 zeroPadding, System.Boolean outputPositiveSign) { }
        private System.Byte ValueToIntegerChar(System.Int32 value, System.Boolean uppercase) { }
        private System.Boolean AlignRight(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Int32 align, System.Int32 length) { }
        private System.Boolean AlignLeft(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Int32 align, System.Int32 length) { }
        private System.Int32 GetLengthForFormatGeneral(Unity.Burst.BurstString.NumberBuffer& number, System.Int32 nMaxDigits) { }
        private System.Void FormatGeneral(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, Unity.Burst.BurstString.NumberBuffer& number, System.Int32 nMaxDigits, System.Byte expChar) { }
        private System.Void RoundNumber(Unity.Burst.BurstString.NumberBuffer& number, System.Int32 pos, System.Boolean isCorrectlyRounded) { }
        private System.Boolean ShouldRoundUp(System.Byte* dig, System.Int32 i, System.Boolean isCorrectlyRounded) { }
        private System.UInt32 LogBase2(System.UInt32 val) { }
        private System.Int32 BigInt_Compare(Unity.Burst.BurstString.tBigInt& lhs, Unity.Burst.BurstString.tBigInt& rhs) { }
        private System.Void BigInt_Add(Unity.Burst.BurstString.tBigInt& pResult, Unity.Burst.BurstString.tBigInt& lhs, Unity.Burst.BurstString.tBigInt& rhs) { }
        private System.Void BigInt_Add_internal(Unity.Burst.BurstString.tBigInt& pResult, Unity.Burst.BurstString.tBigInt& pLarge, Unity.Burst.BurstString.tBigInt& pSmall) { }
        private System.Void BigInt_Multiply(Unity.Burst.BurstString.tBigInt& pResult, Unity.Burst.BurstString.tBigInt& lhs, Unity.Burst.BurstString.tBigInt& rhs) { }
        private System.Void BigInt_Multiply_internal(Unity.Burst.BurstString.tBigInt& pResult, Unity.Burst.BurstString.tBigInt& pLarge, Unity.Burst.BurstString.tBigInt& pSmall) { }
        private System.Void BigInt_Multiply(Unity.Burst.BurstString.tBigInt& pResult, Unity.Burst.BurstString.tBigInt& lhs, System.UInt32 rhs) { }
        private System.Void BigInt_Multiply2(Unity.Burst.BurstString.tBigInt& pResult, Unity.Burst.BurstString.tBigInt& input) { }
        private System.Void BigInt_Multiply2(Unity.Burst.BurstString.tBigInt& pResult) { }
        private System.Void BigInt_Multiply10(Unity.Burst.BurstString.tBigInt& pResult) { }
        private Unity.Burst.BurstString.tBigInt g_PowerOf10_Big(System.Int32 i) { }
        private System.Void BigInt_Pow10(Unity.Burst.BurstString.tBigInt& pResult, System.UInt32 exponent) { }
        private System.Void BigInt_MultiplyPow10(Unity.Burst.BurstString.tBigInt& pResult, Unity.Burst.BurstString.tBigInt& input, System.UInt32 exponent) { }
        private System.Void BigInt_Pow2(Unity.Burst.BurstString.tBigInt& pResult, System.UInt32 exponent) { }
        private System.UInt32 BigInt_DivideWithRemainder_MaxQuotient9(Unity.Burst.BurstString.tBigInt& pDividend, Unity.Burst.BurstString.tBigInt& divisor) { }
        private System.Void BigInt_ShiftLeft(Unity.Burst.BurstString.tBigInt& pResult, System.UInt32 shift) { }
        private System.UInt32 Dragon4(System.UInt64 mantissa, System.Int32 exponent, System.UInt32 mantissaHighBitIdx, System.Boolean hasUnequalMargins, Unity.Burst.BurstString.CutoffMode cutoffMode, System.UInt32 cutoffNumber, System.Byte* pOutBuffer, System.UInt32 bufferSize, System.Int32& pOutExponent) { }
        private System.Void FormatInfinityNaN(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.UInt64 mantissa, System.Boolean isNegative, Unity.Burst.BurstString.FormatOptions formatOptions) { }
        private System.Void ConvertFloatToString(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Single value, Unity.Burst.BurstString.FormatOptions formatOptions) { }
        private System.Void ConvertDoubleToString(System.Byte* dest, System.Int32& destIndex, System.Int32 destLength, System.Double value, Unity.Burst.BurstString.FormatOptions formatOptions) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001D
    public struct FunctionPointer`1
    {
        // Fields
        private readonly System.IntPtr _ptr;        // 0x0

        // Methods
        private System.Void .ctor(System.IntPtr ptr) { }
        private T get_Invoke() { }

    }

    // TypeToken: 0x200001E
    public class NoAliasAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public struct SharedStatic`1
    {
        // Fields
        private readonly System.Void* _buffer;        // 0x0

        // Methods
        private System.Void .ctor(System.Void* buffer) { }
        private T& get_Data() { }
        private System.Void* get_UnsafeDataPointer() { }
        private Unity.Burst.SharedStatic<T> GetOrCreate(System.UInt32 alignment) { }
        private Unity.Burst.SharedStatic<T> GetOrCreateUnsafe(System.UInt32 alignment, System.Int64 hashCode, System.Int64 subHashCode) { }

    }

    // TypeToken: 0x2000020
    public class SharedStatic
    {
        // Methods
        private System.Void* GetOrCreateSharedStaticInternal(System.Int64 getHashCode64, System.Int64 getSubHashCode64, System.UInt32 sizeOf, System.UInt32 alignment) { }

    }

}

namespace Unity.Burst.CompilerServices
{

    // TypeToken: 0x200002F
    public class AssumeRangeAttribute : Attribute
    {
        // Methods
        private System.Void .ctor(System.Int64 min, System.Int64 max) { }

    }

    // TypeToken: 0x2000030
    public class Hint
    {
        // Methods
        private System.Boolean Likely(System.Boolean condition) { }

    }

}

namespace Unity.Burst.Intrinsics
{

    // TypeToken: 0x2000022
    public class Common
    {
        // Methods
        private System.UInt64 umul128(System.UInt64 x, System.UInt64 y, System.UInt64& high) { }

    }

    // TypeToken: 0x2000023
    public class BurstTargetCpuAttribute : Attribute
    {
    }

    // TypeToken: 0x2000024
    public class V64DebugView
    {
    }

    // TypeToken: 0x2000025
    public class V128DebugView
    {
    }

    // TypeToken: 0x2000026
    public class V256DebugView
    {
    }

    // TypeToken: 0x2000027
    public struct v128
    {
        // Fields
        public System.Byte Byte0;        // 0x10
        public System.Byte Byte1;        // 0x11
        public System.Byte Byte2;        // 0x12
        public System.Byte Byte3;        // 0x13
        public System.Byte Byte4;        // 0x14
        public System.Byte Byte5;        // 0x15
        public System.Byte Byte6;        // 0x16
        public System.Byte Byte7;        // 0x17
        public System.Byte Byte8;        // 0x18
        public System.Byte Byte9;        // 0x19
        public System.Byte Byte10;        // 0x1A
        public System.Byte Byte11;        // 0x1B
        public System.Byte Byte12;        // 0x1C
        public System.Byte Byte13;        // 0x1D
        public System.Byte Byte14;        // 0x1E
        public System.Byte Byte15;        // 0x1F
        public System.SByte SByte0;        // 0x10
        public System.SByte SByte1;        // 0x11
        public System.SByte SByte2;        // 0x12
        public System.SByte SByte3;        // 0x13
        public System.SByte SByte4;        // 0x14
        public System.SByte SByte5;        // 0x15
        public System.SByte SByte6;        // 0x16
        public System.SByte SByte7;        // 0x17
        public System.SByte SByte8;        // 0x18
        public System.SByte SByte9;        // 0x19
        public System.SByte SByte10;        // 0x1A
        public System.SByte SByte11;        // 0x1B
        public System.SByte SByte12;        // 0x1C
        public System.SByte SByte13;        // 0x1D
        public System.SByte SByte14;        // 0x1E
        public System.SByte SByte15;        // 0x1F
        public System.UInt16 UShort0;        // 0x10
        public System.UInt16 UShort1;        // 0x12
        public System.UInt16 UShort2;        // 0x14
        public System.UInt16 UShort3;        // 0x16
        public System.UInt16 UShort4;        // 0x18
        public System.UInt16 UShort5;        // 0x1A
        public System.UInt16 UShort6;        // 0x1C
        public System.UInt16 UShort7;        // 0x1E
        public System.Int16 SShort0;        // 0x10
        public System.Int16 SShort1;        // 0x12
        public System.Int16 SShort2;        // 0x14
        public System.Int16 SShort3;        // 0x16
        public System.Int16 SShort4;        // 0x18
        public System.Int16 SShort5;        // 0x1A
        public System.Int16 SShort6;        // 0x1C
        public System.Int16 SShort7;        // 0x1E
        public System.UInt32 UInt0;        // 0x10
        public System.UInt32 UInt1;        // 0x14
        public System.UInt32 UInt2;        // 0x18
        public System.UInt32 UInt3;        // 0x1C
        public System.Int32 SInt0;        // 0x10
        public System.Int32 SInt1;        // 0x14
        public System.Int32 SInt2;        // 0x18
        public System.Int32 SInt3;        // 0x1C
        public System.UInt64 ULong0;        // 0x10
        public System.UInt64 ULong1;        // 0x18
        public System.Int64 SLong0;        // 0x10
        public System.Int64 SLong1;        // 0x18
        public System.Single Float0;        // 0x10
        public System.Single Float1;        // 0x14
        public System.Single Float2;        // 0x18
        public System.Single Float3;        // 0x1C
        public System.Double Double0;        // 0x10
        public System.Double Double1;        // 0x18
        public Unity.Burst.Intrinsics.v64 Lo64;        // 0x10
        public Unity.Burst.Intrinsics.v64 Hi64;        // 0x18

    }

    // TypeToken: 0x2000028
    public struct v256
    {
        // Fields
        public System.Byte Byte0;        // 0x10
        public System.Byte Byte1;        // 0x11
        public System.Byte Byte2;        // 0x12
        public System.Byte Byte3;        // 0x13
        public System.Byte Byte4;        // 0x14
        public System.Byte Byte5;        // 0x15
        public System.Byte Byte6;        // 0x16
        public System.Byte Byte7;        // 0x17
        public System.Byte Byte8;        // 0x18
        public System.Byte Byte9;        // 0x19
        public System.Byte Byte10;        // 0x1A
        public System.Byte Byte11;        // 0x1B
        public System.Byte Byte12;        // 0x1C
        public System.Byte Byte13;        // 0x1D
        public System.Byte Byte14;        // 0x1E
        public System.Byte Byte15;        // 0x1F
        public System.Byte Byte16;        // 0x20
        public System.Byte Byte17;        // 0x21
        public System.Byte Byte18;        // 0x22
        public System.Byte Byte19;        // 0x23
        public System.Byte Byte20;        // 0x24
        public System.Byte Byte21;        // 0x25
        public System.Byte Byte22;        // 0x26
        public System.Byte Byte23;        // 0x27
        public System.Byte Byte24;        // 0x28
        public System.Byte Byte25;        // 0x29
        public System.Byte Byte26;        // 0x2A
        public System.Byte Byte27;        // 0x2B
        public System.Byte Byte28;        // 0x2C
        public System.Byte Byte29;        // 0x2D
        public System.Byte Byte30;        // 0x2E
        public System.Byte Byte31;        // 0x2F
        public System.SByte SByte0;        // 0x10
        public System.SByte SByte1;        // 0x11
        public System.SByte SByte2;        // 0x12
        public System.SByte SByte3;        // 0x13
        public System.SByte SByte4;        // 0x14
        public System.SByte SByte5;        // 0x15
        public System.SByte SByte6;        // 0x16
        public System.SByte SByte7;        // 0x17
        public System.SByte SByte8;        // 0x18
        public System.SByte SByte9;        // 0x19
        public System.SByte SByte10;        // 0x1A
        public System.SByte SByte11;        // 0x1B
        public System.SByte SByte12;        // 0x1C
        public System.SByte SByte13;        // 0x1D
        public System.SByte SByte14;        // 0x1E
        public System.SByte SByte15;        // 0x1F
        public System.SByte SByte16;        // 0x20
        public System.SByte SByte17;        // 0x21
        public System.SByte SByte18;        // 0x22
        public System.SByte SByte19;        // 0x23
        public System.SByte SByte20;        // 0x24
        public System.SByte SByte21;        // 0x25
        public System.SByte SByte22;        // 0x26
        public System.SByte SByte23;        // 0x27
        public System.SByte SByte24;        // 0x28
        public System.SByte SByte25;        // 0x29
        public System.SByte SByte26;        // 0x2A
        public System.SByte SByte27;        // 0x2B
        public System.SByte SByte28;        // 0x2C
        public System.SByte SByte29;        // 0x2D
        public System.SByte SByte30;        // 0x2E
        public System.SByte SByte31;        // 0x2F
        public System.UInt16 UShort0;        // 0x10
        public System.UInt16 UShort1;        // 0x12
        public System.UInt16 UShort2;        // 0x14
        public System.UInt16 UShort3;        // 0x16
        public System.UInt16 UShort4;        // 0x18
        public System.UInt16 UShort5;        // 0x1A
        public System.UInt16 UShort6;        // 0x1C
        public System.UInt16 UShort7;        // 0x1E
        public System.UInt16 UShort8;        // 0x20
        public System.UInt16 UShort9;        // 0x22
        public System.UInt16 UShort10;        // 0x24
        public System.UInt16 UShort11;        // 0x26
        public System.UInt16 UShort12;        // 0x28
        public System.UInt16 UShort13;        // 0x2A
        public System.UInt16 UShort14;        // 0x2C
        public System.UInt16 UShort15;        // 0x2E
        public System.Int16 SShort0;        // 0x10
        public System.Int16 SShort1;        // 0x12
        public System.Int16 SShort2;        // 0x14
        public System.Int16 SShort3;        // 0x16
        public System.Int16 SShort4;        // 0x18
        public System.Int16 SShort5;        // 0x1A
        public System.Int16 SShort6;        // 0x1C
        public System.Int16 SShort7;        // 0x1E
        public System.Int16 SShort8;        // 0x20
        public System.Int16 SShort9;        // 0x22
        public System.Int16 SShort10;        // 0x24
        public System.Int16 SShort11;        // 0x26
        public System.Int16 SShort12;        // 0x28
        public System.Int16 SShort13;        // 0x2A
        public System.Int16 SShort14;        // 0x2C
        public System.Int16 SShort15;        // 0x2E
        public System.UInt32 UInt0;        // 0x10
        public System.UInt32 UInt1;        // 0x14
        public System.UInt32 UInt2;        // 0x18
        public System.UInt32 UInt3;        // 0x1C
        public System.UInt32 UInt4;        // 0x20
        public System.UInt32 UInt5;        // 0x24
        public System.UInt32 UInt6;        // 0x28
        public System.UInt32 UInt7;        // 0x2C
        public System.Int32 SInt0;        // 0x10
        public System.Int32 SInt1;        // 0x14
        public System.Int32 SInt2;        // 0x18
        public System.Int32 SInt3;        // 0x1C
        public System.Int32 SInt4;        // 0x20
        public System.Int32 SInt5;        // 0x24
        public System.Int32 SInt6;        // 0x28
        public System.Int32 SInt7;        // 0x2C
        public System.UInt64 ULong0;        // 0x10
        public System.UInt64 ULong1;        // 0x18
        public System.UInt64 ULong2;        // 0x20
        public System.UInt64 ULong3;        // 0x28
        public System.Int64 SLong0;        // 0x10
        public System.Int64 SLong1;        // 0x18
        public System.Int64 SLong2;        // 0x20
        public System.Int64 SLong3;        // 0x28
        public System.Single Float0;        // 0x10
        public System.Single Float1;        // 0x14
        public System.Single Float2;        // 0x18
        public System.Single Float3;        // 0x1C
        public System.Single Float4;        // 0x20
        public System.Single Float5;        // 0x24
        public System.Single Float6;        // 0x28
        public System.Single Float7;        // 0x2C
        public System.Double Double0;        // 0x10
        public System.Double Double1;        // 0x18
        public System.Double Double2;        // 0x20
        public System.Double Double3;        // 0x28
        public Unity.Burst.Intrinsics.v128 Lo128;        // 0x10
        public Unity.Burst.Intrinsics.v128 Hi128;        // 0x20

        // Methods
        private System.Void .ctor(System.Int32 v) { }
        private System.Void .ctor(Unity.Burst.Intrinsics.v128 lo, Unity.Burst.Intrinsics.v128 hi) { }

    }

    // TypeToken: 0x2000029
    public struct v64
    {
        // Fields
        public System.Byte Byte0;        // 0x10
        public System.Byte Byte1;        // 0x11
        public System.Byte Byte2;        // 0x12
        public System.Byte Byte3;        // 0x13
        public System.Byte Byte4;        // 0x14
        public System.Byte Byte5;        // 0x15
        public System.Byte Byte6;        // 0x16
        public System.Byte Byte7;        // 0x17
        public System.SByte SByte0;        // 0x10
        public System.SByte SByte1;        // 0x11
        public System.SByte SByte2;        // 0x12
        public System.SByte SByte3;        // 0x13
        public System.SByte SByte4;        // 0x14
        public System.SByte SByte5;        // 0x15
        public System.SByte SByte6;        // 0x16
        public System.SByte SByte7;        // 0x17
        public System.UInt16 UShort0;        // 0x10
        public System.UInt16 UShort1;        // 0x12
        public System.UInt16 UShort2;        // 0x14
        public System.UInt16 UShort3;        // 0x16
        public System.Int16 SShort0;        // 0x10
        public System.Int16 SShort1;        // 0x12
        public System.Int16 SShort2;        // 0x14
        public System.Int16 SShort3;        // 0x16
        public System.UInt32 UInt0;        // 0x10
        public System.UInt32 UInt1;        // 0x14
        public System.Int32 SInt0;        // 0x10
        public System.Int32 SInt1;        // 0x14
        public System.UInt64 ULong0;        // 0x10
        public System.Int64 SLong0;        // 0x10
        public System.Single Float0;        // 0x10
        public System.Single Float1;        // 0x14
        public System.Double Double0;        // 0x10

    }

    // TypeToken: 0x200002A
    public class X86
    {
    }

}

