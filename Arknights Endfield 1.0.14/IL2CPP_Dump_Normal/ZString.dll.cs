// ========================================================
// Dumped by @desirepro
// Assembly: ZString.dll
// Classes:  30
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000A
    public class HgStringBlock, IDisposable
    {
        // Fields
        private readonly System.Collections.Generic.Stack<Beyond.UnSafeString> m_stack;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void Push(Beyond.UnSafeString str) { }
        private System.Void System.IDisposable.Dispose() { }

    }

    // TypeToken: 0x200000B
    public struct UnSafeStringHandle, IDisposable
    {
        // Fields
        private System.Runtime.InteropServices.GCHandle m_stringHandler;        // 0x10

        // Methods
        private Beyond.UnSafeString.UnSafeStringHandle CreateHandle(System.Int32 count) { }
        private System.Void .ctor(Beyond.UnSafeString unSafeString) { }
        private System.Void Dispose() { }
        private Beyond.UnSafeString Get() { }

    }

    // TypeToken: 0x2000011
    public struct ParseResult
    {
        // Fields
        public readonly System.Int32 Index;        // 0x10
        public readonly System.ReadOnlySpan<System.Char> FormatString;        // 0x18
        public readonly System.Int32 LastIndex;        // 0x28
        public readonly System.Int32 Alignment;        // 0x2C

        // Methods
        private System.Void .ctor(System.Int32 index, System.ReadOnlySpan<System.Char> formatString, System.Int32 lastIndex, System.Int32 alignment) { }

    }

    // TypeToken: 0x2000015
    public class TryFormat`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(T value, System.Span<System.Char> destination, System.Int32& charsWritten, System.ReadOnlySpan<System.Char> format) { }

    }

    // TypeToken: 0x2000016
    public class FormatterCache`1
    {
        // Fields
        public static Cysharp.Text.Utf16ValueStringBuilder.TryFormat<T> TryFormatDelegate;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.Boolean TryFormatString(T value, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }
        private System.Boolean TryFormatDefault(T value, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format) { }

    }

    // TypeToken: 0x200001B
    public struct __StaticArrayInitTypeSize=32
    {
    }

    // TypeToken: 0x200001C
    public struct __StaticArrayInitTypeSize=256
    {
    }

namespace Beyond
{

    // TypeToken: 0x2000005
    public struct MonoObject_64
    {
        // Fields
        public System.Void* p1;        // 0x10
        public System.Void* p2;        // 0x18

    }

    // TypeToken: 0x2000006
    public struct MonoObject_32
    {
        // Fields
        public System.Void* p1;        // 0x10
        public System.Void* p2;        // 0x14

    }

    // TypeToken: 0x2000007
    public struct MonoString_64
    {
        // Fields
        public Beyond.MonoObject_64 obj;        // 0x10
        public System.Int32 length;        // 0x20
        public System.Char firstChar;        // 0x24

    }

    // TypeToken: 0x2000008
    public struct MonoString_32
    {
        // Fields
        public Beyond.MonoObject_32 obj;        // 0x10
        public System.Int32 length;        // 0x18
        public System.Char firstChar;        // 0x1C

    }

    // TypeToken: 0x2000009
    public class UnSafeString
    {
        // Fields
        private static System.Collections.Generic.Stack<Beyond.UnSafeString.HgStringBlock> s_blocks;        // 0x0
        private static System.Collections.Generic.Stack<Beyond.UnSafeString.HgStringBlock> s_stackBlocks;        // 0x8
        private static Beyond.UnSafeString.HgStringBlock s_currentBlock;        // 0x10
        private static readonly System.Char[] UP_TABLE;        // 0x18
        private static readonly System.Char[] LOW_TABLE;        // 0x20
        private System.String m_buffer;        // 0x10
        private System.UInt64 m_handler;        // 0x18
        private System.Int32* m_strCount;        // 0x20
        private System.Int32 m_length;        // 0x28
        private System.Boolean m_resizeFlag;        // 0x2C
        public static Beyond.UnSafeString Empty;        // 0x28
        public static System.Int32 s_mainThread;        // 0x30
        private static System.Collections.Generic.Queue<Beyond.UnSafeString>[] s_freeListPool;        // 0x38
        private static System.Collections.Generic.Queue<Beyond.UnSafeString>[] s_secondFreeListPool;        // 0x40
        private static System.Collections.Generic.Dictionary<Unity.Mathematics.uint2,System.String> s_sharedStringPool;        // 0x48

        // Methods
        private System.Void Append(System.Char value) { }
        private System.Void Append(System.Char* value, System.Int32 count) { }
        private System.Void Append(System.Int32 value) { }
        private System.Void Append(System.String value) { }
        private System.Void Append(System.Span<System.Char> value) { }
        private System.Void Replace(System.Char newChar, System.Int32 Index) { }
        private System.Void Append(Beyond.UnSafeString value) { }
        private System.Void Append(System.Byte* value, System.Int32 count) { }
        private System.Int32 _GetUTF8ByteCnt(System.Byte bt) { }
        private System.IDisposable Scope() { }
        private Beyond.UnSafeString Concat(T1 arg1, T2 arg2) { }
        private Beyond.UnSafeString Concat(T1 arg1, T2 arg2, T3 arg3) { }
        private Beyond.UnSafeString Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        private System.Int32 get_Length() { }
        private System.Void set_Length(System.Int32 value) { }
        private System.Void .cctor() { }
        private System.Void .ctor(System.Int32 count) { }
        private Beyond.UnSafeString Create(System.Int32 count) { }
        private Beyond.UnSafeString CreateRaw(System.Int32 count) { }
        private System.Void Dispose() { }
        private System.Int32 GetStringBufferSize() { }
        private System.Void Clear() { }
        private System.String CloneString() { }
        private System.Void CloneToBytes(System.Span<System.Byte> bytes) { }
        private System.String ToString() { }
        private System.Void _Resize(System.Int32 size) { }
        private System.Int32 GetHashCode() { }
        private System.Void ToLow() { }
        private Beyond.UnSafeString GetUnsafeString(System.Char* ptr, System.Int32 length) { }
        private Beyond.UnSafeString GetUnsafeStringUTF8(System.Span<System.Byte> span) { }
        private Beyond.UnSafeString Format(System.String formatString, T arg) { }
        private Beyond.UnSafeString Format(System.String formatString, T1 arg, T2 arg1) { }
        private Beyond.UnSafeString Format(System.String format, T1 arg1, T2 arg2, T3 arg3) { }
        private Beyond.UnSafeString Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        private Beyond.UnSafeString Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
        private System.String op_Implicit(Beyond.UnSafeString value) { }
        private Beyond.UnSafeString op_Implicit(System.String value) { }
        private Beyond.UnSafeString TryGetUnSafeStringFromPool(System.Int32 requestStringLength, System.Boolean inScope) { }
        private System.Void _RecycleString(Beyond.UnSafeString uString) { }
        private System.Void FreeCacheMemory() { }
        private System.Void Split(System.Char separator, System.Collections.Generic.List<Beyond.UnSafeString>& list) { }

    }

}

namespace Cysharp.Text
{

    // TypeToken: 0x200000D
    public class EnumUtil`1
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<T,System.String> names;        // 0x0
        private static readonly System.Collections.Generic.Dictionary<T,System.Byte[]> utf8names;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.Boolean TryFormatUtf16(T value, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> _) { }

    }

    // TypeToken: 0x200000E
    public class ExceptionUtil
    {
        // Methods
        private System.Void ThrowFormatException() { }
        private System.Void ThrowFormatError() { }

    }

    // TypeToken: 0x200000F
    public class FastNumberWriter
    {
        // Methods
        private System.Boolean TryWriteInt64(System.Span<System.Char> buffer, System.Int32& charsWritten, System.Int64 value) { }
        private System.Boolean TryWriteUInt64(System.Span<System.Char> buffer, System.Int32& charsWritten, System.UInt64 value) { }

    }

    // TypeToken: 0x2000010
    public class FormatParser
    {
        // Methods
        private System.Boolean IsDigit(System.Char c) { }
        private Cysharp.Text.FormatParser.ParseResult Parse(System.String format, System.Int32 i) { }

    }

    // TypeToken: 0x2000012
    public class NestedStringBuilderCreationException : InvalidOperationException
    {
        // Methods
        private System.Void .ctor(System.String typeName, System.String extraMessage) { }

    }

    // TypeToken: 0x2000013
    public struct ReadOnlyListAdaptor`1, IReadOnlyList`1, IEnumerable`1, IEnumerable, IReadOnlyCollection`1
    {
        // Fields
        private readonly System.Collections.Generic.IList<T> _list;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.IList<T> list) { }
        private T get_Item(System.Int32 index) { }
        private System.Int32 get_Count() { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000014
    public struct Utf16ValueStringBuilder, IDisposable, IBufferWriter`1
    {
        // Fields
        private static System.Char newLine1;        // 0x0
        private static System.Char newLine2;        // 0x2
        private static System.Boolean crlf;        // 0x4
        private static System.Char[] scratchBuffer;        // 0xFFFFFFFF
        private static System.Boolean scratchBufferUsed;        // 0xFFFFFFFF
        private System.Char[] buffer;        // 0x10
        private System.Int32 index;        // 0x18
        private System.Boolean disposeImmediately;        // 0x1C

        // Methods
        private System.Void AppendJoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IReadOnlyList<T> values) { }
        private System.Void AppendJoinInternal(System.ReadOnlySpan<System.Char> separator, System.ReadOnlySpan<T> values) { }
        private System.Void AppendJoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IEnumerable<T> values) { }
        private System.Void AppendFormat(System.String format, T1 arg1) { }
        private System.Void AppendFormat(System.String format, T1 arg1, T2 arg2) { }
        private System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3) { }
        private System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        private System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
        private System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
        private System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
        private System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
        private System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
        private System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
        private System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
        private System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
        private System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
        private System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
        private System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) { }
        private System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) { }
        private System.Object CreateFormatter(System.Type type) { }
        private System.Void Append(System.Int32 value) { }
        private System.Void .cctor() { }
        private System.Int32 get_Length() { }
        private System.ReadOnlySpan<System.Char> AsSpan() { }
        private System.ArraySegment<System.Char> AsArraySegment() { }
        private System.Void .ctor(System.Boolean disposeImmediately) { }
        private System.Void Dispose() { }
        private System.Void Grow(System.Int32 sizeHint) { }
        private System.Void AppendLine() { }
        private System.Void Append(System.Char value) { }
        private System.Void Append(System.Char value, System.Int32 repeatCount) { }
        private System.Void Append(System.String value) { }
        private System.Void AppendLine(System.String value) { }
        private System.Void Append(System.String value, System.Int32 startIndex, System.Int32 count) { }
        private System.Void Append(System.ReadOnlySpan<System.Char> value) { }
        private System.Void Append(T value) { }
        private System.String ToString() { }
        private System.Memory<System.Char> GetMemory(System.Int32 sizeHint) { }
        private System.Span<System.Char> GetSpan(System.Int32 sizeHint) { }
        private System.Void Advance(System.Int32 count) { }
        private System.Void ThrowArgumentException(System.String paramName) { }
        private System.Void ThrowFormatException() { }
        private System.Void AppendFormatInternal(T arg, System.Int32 width, System.ReadOnlySpan<System.Char> format, System.String argName) { }
        private System.Void ThrowNestedException() { }
        private Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Nullable<T>> CreateNullableFormatter() { }
        private System.Char& GetPinnableReference() { }

    }

    // TypeToken: 0x2000019
    public class ZString
    {
        // Fields
        private static System.Text.Encoding UTF8NoBom;        // 0x0

        // Methods
        private System.String Concat(T1 arg1, T2 arg2) { }
        private System.String Concat(T1 arg1, T2 arg2, T3 arg3) { }
        private System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        private System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
        private System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
        private System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
        private System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
        private System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
        private System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
        private System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
        private System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
        private System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
        private System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
        private System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) { }
        private System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) { }
        private Cysharp.Text.Utf16ValueStringBuilder CreateStringBuilder() { }
        private System.String Join(System.Char separator, T[] values) { }
        private System.String Join(System.Char separator, System.Collections.Generic.List<T> values) { }
        private System.String Join(System.Char separator, System.Collections.Generic.IEnumerable<T> values) { }
        private System.String Join(System.Char separator, System.Collections.Generic.ICollection<T> values) { }
        private System.String Join(System.Char separator, System.Collections.Generic.IList<T> values) { }
        private System.String Join(System.Char separator, System.Collections.Generic.IReadOnlyList<T> values) { }
        private System.String Join(System.Char separator, System.Collections.Generic.IReadOnlyCollection<T> values) { }
        private System.String Join(System.String separator, System.Collections.Generic.List<T> values) { }
        private System.String Join(System.String separator, System.Collections.Generic.ICollection<T> values) { }
        private System.String Join(System.String separator, System.Collections.Generic.IList<T> values) { }
        private System.String Join(System.String separator, System.Collections.Generic.IReadOnlyList<T> values) { }
        private System.String Join(System.String separator, System.Collections.Generic.IReadOnlyCollection<T> values) { }
        private System.String Join(System.String separator, System.Collections.Generic.IEnumerable<T> values) { }
        private System.String JoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IList<T> values) { }
        private System.String JoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IReadOnlyList<T> values) { }
        private System.String JoinInternal(System.ReadOnlySpan<System.Char> separator, System.ReadOnlySpan<T> values) { }
        private System.String JoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IEnumerable<T> values) { }
        private System.String Format(System.String format, T1 arg1) { }
        private System.String Format(System.String format, T1 arg1, T2 arg2) { }
        private System.String Format(System.String format, T1 arg1, T2 arg2, T3 arg3) { }
        private System.String Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        private System.String Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
        private System.String Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
        private System.Void .cctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x200001D
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void __Gen_Wrap_0(System.Object P0, System.Char P1) { }
        private System.Void __Gen_Wrap_2(System.Object P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_3(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_5(System.Object P0, System.Span<System.Char> P1) { }
        private System.Void __Gen_Wrap_6(System.Object P0, System.Char P1, System.Int32 P2) { }
        private System.Int32 __Gen_Wrap_8(System.Object P0, System.Byte P1) { }
        private System.IDisposable __Gen_Wrap_9() { }
        private Beyond.UnSafeString __Gen_Wrap_10(System.Int32 P0, System.Boolean P1) { }
        private Beyond.UnSafeString __Gen_Wrap_11(System.Int32 P0) { }
        private System.Void __Gen_Wrap_12(System.Object P0) { }
        private System.Int32 __Gen_Wrap_13(System.Object P0) { }
        private System.String __Gen_Wrap_14(System.Object P0) { }
        private System.Void __Gen_Wrap_15(System.Object P0, System.Span<System.Byte> P1) { }
        private Beyond.UnSafeString __Gen_Wrap_22(System.Span<System.Byte> P0) { }
        private Beyond.UnSafeString __Gen_Wrap_23(System.Object P0) { }
        private System.Void __Gen_Wrap_29() { }
        private System.Void __Gen_Wrap_31(System.Object P0, System.Char P1, System.Collections.Generic.List<Beyond.UnSafeString>& P2) { }
        private Beyond.UnSafeString.UnSafeStringHandle __Gen_Wrap_32(System.Int32 P0) { }
        private System.Void __Gen_Wrap_33(Beyond.UnSafeString.UnSafeStringHandle& P0) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001E
    public class WrappersManagerImpl
    {
        // Methods
        private IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        private System.Boolean IsPatched(System.Int32 id) { }

    }

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

namespace System.Numerics
{

    // TypeToken: 0x200000C
    public class BitOperations
    {
        // Methods
        private System.ReadOnlySpan<System.Byte> get_TrailingZeroCountDeBruijn() { }
        private System.ReadOnlySpan<System.Byte> get_Log2DeBruijn() { }
        private System.Int32 LeadingZeroCount(System.UInt32 value) { }
        private System.Int32 Log2SoftwareFallback(System.UInt32 value) { }
        private System.Int32 TrailingZeroCount(System.UInt32 value) { }
        private System.Int32 TrailingZeroCount(System.UInt64 value) { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003
    public class NullableAttribute : Attribute
    {
        // Fields
        public readonly System.Byte[] NullableFlags;        // 0x10

        // Methods
        private System.Void .ctor(System.Byte ) { }
        private System.Void .ctor(System.Byte[] ) { }

    }

    // TypeToken: 0x2000004
    public class NullableContextAttribute : Attribute
    {
        // Fields
        public readonly System.Byte Flag;        // 0x10

        // Methods
        private System.Void .ctor(System.Byte ) { }

    }

}

