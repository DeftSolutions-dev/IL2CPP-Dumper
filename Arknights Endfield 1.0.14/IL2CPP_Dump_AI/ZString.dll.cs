// ========================================================
// Dumped by @desirepro
// Assembly: ZString.dll
// Classes:  30
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: HgStringBlock
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  private   readonly System.Collections.Generic.Stack<Beyond.UnSafeString>m_stack  // 0x10
METHODS:
  System.Void .ctor(System.Int32 capacity)
  System.Void Push(Beyond.UnSafeString str)
  System.Void System.IDisposable.Dispose()
END_CLASS

CLASS: UnSafeStringHandle
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  private           System.Runtime.InteropServices.GCHandlem_stringHandler  // 0x10
METHODS:
  Beyond.UnSafeString.UnSafeStringHandle CreateHandle(System.Int32 count)
  System.Void .ctor(Beyond.UnSafeString unSafeString)
  System.Void Dispose()
  Beyond.UnSafeString Get()
END_CLASS

CLASS: ParseResult
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public    readonly System.Int32                    Index  // 0x10
  public    readonly System.ReadOnlySpan<System.Char>FormatString  // 0x18
  public    readonly System.Int32                    LastIndex  // 0x28
  public    readonly System.Int32                    Alignment  // 0x2C
METHODS:
  System.Void .ctor(System.Int32 index, System.ReadOnlySpan<System.Char> formatString, System.Int32 lastIndex, System.Int32 alignment)
END_CLASS

CLASS: TryFormat`1
TYPE:  class
TOKEN: 0x2000015
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(T value, System.Span<System.Char> destination, System.Int32& charsWritten, System.ReadOnlySpan<System.Char> format)
END_CLASS

CLASS: FormatterCache`1
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  public    static  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<T>TryFormatDelegate  // 0x0
METHODS:
  System.Void .cctor()
  System.Boolean TryFormatString(T value, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
  System.Boolean TryFormatDefault(T value, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> format)
END_CLASS

CLASS: __StaticArrayInitTypeSize=32
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=256
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
METHODS:
END_CLASS

CLASS: Beyond.MonoObject_64
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Void*                    p1  // 0x10
  public            System.Void*                    p2  // 0x18
METHODS:
END_CLASS

CLASS: Beyond.MonoObject_32
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Void*                    p1  // 0x10
  public            System.Void*                    p2  // 0x14
METHODS:
END_CLASS

CLASS: Beyond.MonoString_64
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            Beyond.MonoObject_64            obj  // 0x10
  public            System.Int32                    length  // 0x20
  public            System.Char                     firstChar  // 0x24
METHODS:
END_CLASS

CLASS: Beyond.MonoString_32
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            Beyond.MonoObject_32            obj  // 0x10
  public            System.Int32                    length  // 0x18
  public            System.Char                     firstChar  // 0x1C
METHODS:
END_CLASS

CLASS: Beyond.UnSafeString
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  private   static  System.Collections.Generic.Stack<Beyond.UnSafeString.HgStringBlock>s_blocks  // 0x0
  private   static  System.Collections.Generic.Stack<Beyond.UnSafeString.HgStringBlock>s_stackBlocks  // 0x8
  private   static  Beyond.UnSafeString.HgStringBlocks_currentBlock  // 0x10
  private   static readonly System.Char[]                   UP_TABLE  // 0x18
  private   static readonly System.Char[]                   LOW_TABLE  // 0x20
  private           System.String                   m_buffer  // 0x10
  private           System.UInt64                   m_handler  // 0x18
  private           System.Int32*                   m_strCount  // 0x20
  private           System.Int32                    m_length  // 0x28
  private           System.Boolean                  m_resizeFlag  // 0x2C
  public    static  Beyond.UnSafeString             Empty  // 0x28
  public    static  System.Int32                    s_mainThread  // 0x30
  private   static  System.Collections.Generic.Queue<Beyond.UnSafeString>[]s_freeListPool  // 0x38
  private   static  System.Collections.Generic.Queue<Beyond.UnSafeString>[]s_secondFreeListPool  // 0x40
  private   static  System.Collections.Generic.Dictionary<Unity.Mathematics.uint2,System.String>s_sharedStringPool  // 0x48
METHODS:
  System.Void Append(System.Char value)
  System.Void Append(System.Char* value, System.Int32 count)
  System.Void Append(System.Int32 value)
  System.Void Append(System.String value)
  System.Void Append(System.Span<System.Char> value)
  System.Void Replace(System.Char newChar, System.Int32 Index)
  System.Void Append(Beyond.UnSafeString value)
  System.Void Append(System.Byte* value, System.Int32 count)
  System.Int32 _GetUTF8ByteCnt(System.Byte bt)
  System.IDisposable Scope()
  Beyond.UnSafeString Concat(T1 arg1, T2 arg2)
  Beyond.UnSafeString Concat(T1 arg1, T2 arg2, T3 arg3)
  Beyond.UnSafeString Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  System.Int32 get_Length()
  System.Void set_Length(System.Int32 value)
  System.Void .cctor()
  System.Void .ctor(System.Int32 count)
  Beyond.UnSafeString Create(System.Int32 count)
  Beyond.UnSafeString CreateRaw(System.Int32 count)
  System.Void Dispose()
  System.Int32 GetStringBufferSize()
  System.Void Clear()
  System.String CloneString()
  System.Void CloneToBytes(System.Span<System.Byte> bytes)
  System.String ToString()
  System.Void _Resize(System.Int32 size)
  System.Int32 GetHashCode()
  System.Void ToLow()
  Beyond.UnSafeString GetUnsafeString(System.Char* ptr, System.Int32 length)
  Beyond.UnSafeString GetUnsafeStringUTF8(System.Span<System.Byte> span)
  Beyond.UnSafeString Format(System.String formatString, T arg)
  Beyond.UnSafeString Format(System.String formatString, T1 arg, T2 arg1)
  Beyond.UnSafeString Format(System.String format, T1 arg1, T2 arg2, T3 arg3)
  Beyond.UnSafeString Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  Beyond.UnSafeString Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  System.String op_Implicit(Beyond.UnSafeString value)
  Beyond.UnSafeString op_Implicit(System.String value)
  Beyond.UnSafeString TryGetUnSafeStringFromPool(System.Int32 requestStringLength, System.Boolean inScope)
  System.Void _RecycleString(Beyond.UnSafeString uString)
  System.Void FreeCacheMemory()
  System.Void Split(System.Char separator, System.Collections.Generic.List<Beyond.UnSafeString>& list)
END_CLASS

CLASS: Cysharp.Text.EnumUtil`1
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<T,System.String>names  // 0x0
  private   static readonly System.Collections.Generic.Dictionary<T,System.Byte[]>utf8names  // 0x0
METHODS:
  System.Void .cctor()
  System.Boolean TryFormatUtf16(T value, System.Span<System.Char> dest, System.Int32& written, System.ReadOnlySpan<System.Char> _)
END_CLASS

CLASS: Cysharp.Text.ExceptionUtil
TYPE:  class
TOKEN: 0x200000E
FIELDS:
METHODS:
  System.Void ThrowFormatException()
  System.Void ThrowFormatError()
END_CLASS

CLASS: Cysharp.Text.FastNumberWriter
TYPE:  class
TOKEN: 0x200000F
FIELDS:
METHODS:
  System.Boolean TryWriteInt64(System.Span<System.Char> buffer, System.Int32& charsWritten, System.Int64 value)
  System.Boolean TryWriteUInt64(System.Span<System.Char> buffer, System.Int32& charsWritten, System.UInt64 value)
END_CLASS

CLASS: Cysharp.Text.FormatParser
TYPE:  class
TOKEN: 0x2000010
FIELDS:
METHODS:
  System.Boolean IsDigit(System.Char c)
  Cysharp.Text.FormatParser.ParseResult Parse(System.String format, System.Int32 i)
END_CLASS

CLASS: Cysharp.Text.NestedStringBuilderCreationException
TYPE:  class
TOKEN: 0x2000012
EXTENDS: InvalidOperationException
FIELDS:
METHODS:
  System.Void .ctor(System.String typeName, System.String extraMessage)
END_CLASS

CLASS: Cysharp.Text.ReadOnlyListAdaptor`1
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  private   readonly System.Collections.Generic.IList<T>_list  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.IList<T> list)
  T get_Item(System.Int32 index)
  System.Int32 get_Count()
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: Cysharp.Text.Utf16ValueStringBuilder
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  private   static  System.Char                     newLine1  // 0x0
  private   static  System.Char                     newLine2  // 0x2
  private   static  System.Boolean                  crlf  // 0x4
  private   static  System.Char[]                   scratchBuffer  // 0xFFFFFFFF
  private   static  System.Boolean                  scratchBufferUsed  // 0xFFFFFFFF
  private           System.Char[]                   buffer  // 0x10
  private           System.Int32                    index  // 0x18
  private           System.Boolean                  disposeImmediately  // 0x1C
METHODS:
  System.Void AppendJoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IReadOnlyList<T> values)
  System.Void AppendJoinInternal(System.ReadOnlySpan<System.Char> separator, System.ReadOnlySpan<T> values)
  System.Void AppendJoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IEnumerable<T> values)
  System.Void AppendFormat(System.String format, T1 arg1)
  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2)
  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3)
  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
  System.Void AppendFormat(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
  System.Object CreateFormatter(System.Type type)
  System.Void Append(System.Int32 value)
  System.Void .cctor()
  System.Int32 get_Length()
  System.ReadOnlySpan<System.Char> AsSpan()
  System.ArraySegment<System.Char> AsArraySegment()
  System.Void .ctor(System.Boolean disposeImmediately)
  System.Void Dispose()
  System.Void Grow(System.Int32 sizeHint)
  System.Void AppendLine()
  System.Void Append(System.Char value)
  System.Void Append(System.Char value, System.Int32 repeatCount)
  System.Void Append(System.String value)
  System.Void AppendLine(System.String value)
  System.Void Append(System.String value, System.Int32 startIndex, System.Int32 count)
  System.Void Append(System.ReadOnlySpan<System.Char> value)
  System.Void Append(T value)
  System.String ToString()
  System.Memory<System.Char> GetMemory(System.Int32 sizeHint)
  System.Span<System.Char> GetSpan(System.Int32 sizeHint)
  System.Void Advance(System.Int32 count)
  System.Void ThrowArgumentException(System.String paramName)
  System.Void ThrowFormatException()
  System.Void AppendFormatInternal(T arg, System.Int32 width, System.ReadOnlySpan<System.Char> format, System.String argName)
  System.Void ThrowNestedException()
  Cysharp.Text.Utf16ValueStringBuilder.TryFormat<System.Nullable<T>> CreateNullableFormatter()
  System.Char& GetPinnableReference()
END_CLASS

CLASS: Cysharp.Text.ZString
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  private   static  System.Text.Encoding            UTF8NoBom  // 0x0
METHODS:
  System.String Concat(T1 arg1, T2 arg2)
  System.String Concat(T1 arg1, T2 arg2, T3 arg3)
  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
  System.String Concat(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
  Cysharp.Text.Utf16ValueStringBuilder CreateStringBuilder()
  System.String Join(System.Char separator, T[] values)
  System.String Join(System.Char separator, System.Collections.Generic.List<T> values)
  System.String Join(System.Char separator, System.Collections.Generic.IEnumerable<T> values)
  System.String Join(System.Char separator, System.Collections.Generic.ICollection<T> values)
  System.String Join(System.Char separator, System.Collections.Generic.IList<T> values)
  System.String Join(System.Char separator, System.Collections.Generic.IReadOnlyList<T> values)
  System.String Join(System.Char separator, System.Collections.Generic.IReadOnlyCollection<T> values)
  System.String Join(System.String separator, System.Collections.Generic.List<T> values)
  System.String Join(System.String separator, System.Collections.Generic.ICollection<T> values)
  System.String Join(System.String separator, System.Collections.Generic.IList<T> values)
  System.String Join(System.String separator, System.Collections.Generic.IReadOnlyList<T> values)
  System.String Join(System.String separator, System.Collections.Generic.IReadOnlyCollection<T> values)
  System.String Join(System.String separator, System.Collections.Generic.IEnumerable<T> values)
  System.String JoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IList<T> values)
  System.String JoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IReadOnlyList<T> values)
  System.String JoinInternal(System.ReadOnlySpan<System.Char> separator, System.ReadOnlySpan<T> values)
  System.String JoinInternal(System.ReadOnlySpan<System.Char> separator, System.Collections.Generic.IEnumerable<T> values)
  System.String Format(System.String format, T1 arg1)
  System.String Format(System.String format, T1 arg1, T2 arg2)
  System.String Format(System.String format, T1 arg1, T2 arg2, T3 arg3)
  System.String Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  System.String Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  System.String Format(System.String format, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x200001D
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void __Gen_Wrap_0(System.Object P0, System.Char P1)
  System.Void __Gen_Wrap_2(System.Object P0, System.Int32 P1)
  System.Void __Gen_Wrap_3(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_5(System.Object P0, System.Span<System.Char> P1)
  System.Void __Gen_Wrap_6(System.Object P0, System.Char P1, System.Int32 P2)
  System.Int32 __Gen_Wrap_8(System.Object P0, System.Byte P1)
  System.IDisposable __Gen_Wrap_9()
  Beyond.UnSafeString __Gen_Wrap_10(System.Int32 P0, System.Boolean P1)
  Beyond.UnSafeString __Gen_Wrap_11(System.Int32 P0)
  System.Void __Gen_Wrap_12(System.Object P0)
  System.Int32 __Gen_Wrap_13(System.Object P0)
  System.String __Gen_Wrap_14(System.Object P0)
  System.Void __Gen_Wrap_15(System.Object P0, System.Span<System.Byte> P1)
  Beyond.UnSafeString __Gen_Wrap_22(System.Span<System.Byte> P0)
  Beyond.UnSafeString __Gen_Wrap_23(System.Object P0)
  System.Void __Gen_Wrap_29()
  System.Void __Gen_Wrap_31(System.Object P0, System.Char P1, System.Collections.Generic.List<Beyond.UnSafeString>& P2)
  Beyond.UnSafeString.UnSafeStringHandle __Gen_Wrap_32(System.Int32 P0)
  System.Void __Gen_Wrap_33(Beyond.UnSafeString.UnSafeStringHandle& P0)
  System.Void .cctor()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x200001E
FIELDS:
METHODS:
  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  System.Boolean IsPatched(System.Int32 id)
END_CLASS

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Numerics.BitOperations
TYPE:  class
TOKEN: 0x200000C
FIELDS:
METHODS:
  System.ReadOnlySpan<System.Byte> get_TrailingZeroCountDeBruijn()
  System.ReadOnlySpan<System.Byte> get_Log2DeBruijn()
  System.Int32 LeadingZeroCount(System.UInt32 value)
  System.Int32 Log2SoftwareFallback(System.UInt32 value)
  System.Int32 TrailingZeroCount(System.UInt32 value)
  System.Int32 TrailingZeroCount(System.UInt64 value)
END_CLASS

CLASS: System.Runtime.CompilerServices.NullableAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
  public    readonly System.Byte[]                   NullableFlags  // 0x10
METHODS:
  System.Void .ctor(System.Byte )
  System.Void .ctor(System.Byte[] )
END_CLASS

CLASS: System.Runtime.CompilerServices.NullableContextAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
  public    readonly System.Byte                     Flag  // 0x10
METHODS:
  System.Void .ctor(System.Byte )
END_CLASS

