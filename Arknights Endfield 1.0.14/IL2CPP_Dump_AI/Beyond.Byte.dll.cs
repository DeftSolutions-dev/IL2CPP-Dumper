// ========================================================
// Dumped by @desirepro
// Assembly: Beyond.Byte.dll
// Classes:  8
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Beyond.Byte.UInt128
TYPE:  struct
TOKEN: 0x2000002
FIELDS:
  public            System.UInt64                   high  // 0x10
  public            System.UInt64                   low  // 0x18
METHODS:
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void .ctor(System.UInt64 high, System.UInt64 low)
  System.Void .ctor(System.Byte[] bytes)
  Beyond.Byte.UInt128 op_Implicit(System.Byte[] bytes)
  System.Guid ToGuid()
  System.Int32 CompareTo(Beyond.Byte.UInt128 other)
  System.Boolean Equals(Beyond.Byte.UInt128 other)
  System.Boolean op_Equality(Beyond.Byte.UInt128 a, Beyond.Byte.UInt128 b)
  System.Boolean op_Inequality(Beyond.Byte.UInt128 a, Beyond.Byte.UInt128 B)
  System.Boolean <>iFixBaseProxy_Equals(System.Object P0)
  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: Beyond.Byte.ByteBufStream
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.Int32                    currentIdx  // 0x10
  public            System.Byte[]                   datas  // 0x18
METHODS:
  System.Int32 GetCurrentIdx()
  System.Byte[] GetRaw()
  System.Byte[] GetDataCopy()
  System.UInt32 ReadUInt()
  System.Int32 ReadInt()
  System.Int32 ReadByte()
  System.UInt64 ReadULong()
  System.Int64 ReadLong()
  Beyond.Byte.UInt128 ReadUInt128()
  System.String ReadUTF8()
  System.Void SkipReadUTF8()
  System.Void WriteByte(System.Byte val)
  System.Void WriteUInt(System.UInt32 val)
  System.Void WriteInt(System.Int32 val)
  System.Void WriteULong(System.UInt64 val)
  System.Void WriteLong(System.Int64 val)
  System.Void WriteUInt128(Beyond.Byte.UInt128 val)
  System.Void WriteUTF8(System.String val)
  System.Void SkipBytes(System.Int32 offset)
  System.Int32 RemainBytes()
  Beyond.Byte.ByteBufStream CreateFromByte(System.Byte[] bs, System.Int32 startIdx)
  Beyond.Byte.ByteBufStream Create(System.Int32 cap)
END_CLASS

CLASS: Beyond.Byte.ByteHelper
TYPE:  class
TOKEN: 0x2000004
FIELDS:
METHODS:
  Beyond.Byte.UInt128 ReadUInt128(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  System.Int64 ReadLong(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  System.UInt64 ReadULong(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  System.UInt32 ReadUInt(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  System.Int32 ReadInt(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  System.UInt16 ReadUShort(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  System.Int16 ReadShort(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  System.Byte ReadByte(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  System.Single ReadFloat(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle)
  System.String ReadUTF8(System.Byte[] bs, System.Int32 startIndex, System.Int16& len)
  System.Void SkipReadUTF8(System.Byte[] bs, System.Int32 startIndex, System.Int16& len)
  System.Byte[] WriteByte(System.Byte[] data, System.Int32 writerIndex, System.Byte value)
  System.Byte[] WriteUShort(System.Byte[] data, System.Int32 writerIndex, System.UInt16 value, System.Boolean bIsLittle)
  System.Byte[] WriteShort(System.Byte[] data, System.Int32 writerIndex, System.Int16 value, System.Boolean bIsLittle)
  System.Byte[] WriteUInt(System.Byte[] data, System.Int32 writerIndex, System.UInt32 value, System.Boolean bIsLittle)
  System.Span<System.Byte> WriteUInt(System.Span<System.Byte> data, System.Int32 writerIndex, System.UInt32 value, System.Boolean bIsLittle)
  System.Byte[] WriteInt(System.Byte[] data, System.Int32 writerIndex, System.Int32 value, System.Boolean bIsLittle)
  System.Byte[] WriteULong(System.Byte[] data, System.Int32 writerIndex, System.UInt64 value, System.Boolean bIsLittle)
  System.Span<System.Byte> WriteULong(System.Span<System.Byte> data, System.Int32 writerIndex, System.UInt64 value, System.Boolean bIsLittle)
  System.Byte[] WriteLong(System.Byte[] data, System.Int32 writerIndex, System.Int64 value, System.Boolean bIsLittle)
  System.Byte[] WriteUInt128(System.Byte[] data, System.Int32 writerIndex, Beyond.Byte.UInt128 value, System.Boolean bIsLittle)
  System.Span<System.Byte> WriteUInt128(System.Span<System.Byte> data, System.Int32 writerIndex, Beyond.Byte.UInt128 value, System.Boolean bIsLittle)
  System.Byte[] WriteFloat(System.Byte[] data, System.Int32 writerIndex, System.Single value)
  System.Byte[] WriteUTF8(System.Byte[] data, System.Int32 writerIndex, System.String value, System.Int32& len)
  System.Void SplitLong(System.Int64 longValue, System.Int32& highInt, System.Int32& lowInt)
  System.Int64 MergeLong(System.Int32 highInt, System.Int32 lowInt)
  System.Int32 SingleToInt32Bits(System.Single value)
  System.Single Int32BitsToSingle(System.Int32 value)
  System.String GetHexString(System.Byte[] byteArray)
  System.String GetHexString(System.Byte[] byteArray, System.Int32 startIdx, System.Int32 length)
  System.String GetHexString(System.Span<System.Byte> byteArray)
  System.String GetHexString(System.Span<System.Byte> byteArray, System.Int32 startIdx, System.Int32 length)
  System.Void AppendHexString(Beyond.UnSafeString str, System.Span<System.Byte> byteArray)
  System.Void AppendHexString(Beyond.UnSafeString str, System.Span<System.Byte> byteArray, System.Int32 startIdx, System.Int32 length)
  System.String GetHexStringUnsafeString(System.Span<System.Byte> byteArray)
  System.String GetHexStringUnsafeString(System.Span<System.Byte> byteArray, System.Int32 startIdx, System.Int32 length)
  Beyond.Byte.UInt128 ComputeMD5Bytes(System.Byte[] bs, System.Int32 offset, System.Int32 count)
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.Boolean __Gen_Wrap_0(Beyond.Byte.UInt128& P0, Beyond.Byte.UInt128 P1)
  System.Boolean __Gen_Wrap_1(Beyond.Byte.UInt128& P0, System.Object P1)
  System.Int32 __Gen_Wrap_2(Beyond.Byte.UInt128& P0)
  Beyond.Byte.UInt128 __Gen_Wrap_3(System.Object P0)
  System.Guid __Gen_Wrap_4(Beyond.Byte.UInt128& P0)
  System.Int32 __Gen_Wrap_5(Beyond.Byte.UInt128& P0, Beyond.Byte.UInt128 P1)
  System.Boolean __Gen_Wrap_6(Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1)
  System.Int32 __Gen_Wrap_7(Beyond.Byte.ByteBufStream& P0)
  System.Byte[] __Gen_Wrap_8(Beyond.Byte.ByteBufStream& P0)
  System.UInt32 __Gen_Wrap_9(System.Object P0, System.Int32 P1, System.Boolean P2)
  System.UInt32 __Gen_Wrap_10(Beyond.Byte.ByteBufStream& P0)
  System.Int32 __Gen_Wrap_11(System.Object P0, System.Int32 P1, System.Boolean P2)
  System.Byte __Gen_Wrap_12(System.Object P0, System.Int32 P1, System.Boolean P2)
  System.UInt64 __Gen_Wrap_13(System.Object P0, System.Int32 P1, System.Boolean P2)
  System.UInt64 __Gen_Wrap_14(Beyond.Byte.ByteBufStream& P0)
  System.Int64 __Gen_Wrap_15(System.Object P0, System.Int32 P1, System.Boolean P2)
  System.Int64 __Gen_Wrap_16(Beyond.Byte.ByteBufStream& P0)
  Beyond.Byte.UInt128 __Gen_Wrap_17(System.Object P0, System.Int32 P1, System.Boolean P2)
  Beyond.Byte.UInt128 __Gen_Wrap_18(Beyond.Byte.ByteBufStream& P0)
  System.UInt16 __Gen_Wrap_19(System.Object P0, System.Int32 P1, System.Boolean P2)
  System.Int16 __Gen_Wrap_20(System.Object P0, System.Int32 P1, System.Boolean P2)
  System.String __Gen_Wrap_21(System.Object P0, System.Int32 P1, System.Int16& P2)
  System.String __Gen_Wrap_22(Beyond.Byte.ByteBufStream& P0)
  System.Void __Gen_Wrap_23(System.Object P0, System.Int32 P1, System.Int16& P2)
  System.Void __Gen_Wrap_24(Beyond.Byte.ByteBufStream& P0)
  System.Byte[] __Gen_Wrap_25(System.Object P0, System.Int32 P1, System.Byte P2)
  System.Void __Gen_Wrap_26(Beyond.Byte.ByteBufStream& P0, System.Byte P1)
  System.Byte[] __Gen_Wrap_27(System.Object P0, System.Int32 P1, System.UInt32 P2, System.Boolean P3)
  System.Void __Gen_Wrap_28(Beyond.Byte.ByteBufStream& P0, System.UInt32 P1)
  System.Void __Gen_Wrap_29(Beyond.Byte.ByteBufStream& P0, System.Int32 P1)
  System.Byte[] __Gen_Wrap_30(System.Object P0, System.Int32 P1, System.UInt64 P2, System.Boolean P3)
  System.Void __Gen_Wrap_31(Beyond.Byte.ByteBufStream& P0, System.UInt64 P1)
  System.Void __Gen_Wrap_32(Beyond.Byte.ByteBufStream& P0, System.Int64 P1)
  System.Byte[] __Gen_Wrap_33(System.Object P0, System.Int32 P1, Beyond.Byte.UInt128 P2, System.Boolean P3)
  System.Void __Gen_Wrap_34(Beyond.Byte.ByteBufStream& P0, Beyond.Byte.UInt128 P1)
  System.Byte[] __Gen_Wrap_35(System.Object P0, System.Int32 P1, System.UInt16 P2, System.Boolean P3)
  System.Byte[] __Gen_Wrap_36(System.Object P0, System.Int32 P1, System.Int16 P2, System.Boolean P3)
  System.Byte[] __Gen_Wrap_37(System.Object P0, System.Int32 P1, System.Object P2, System.Int32& P3)
  System.Void __Gen_Wrap_38(Beyond.Byte.ByteBufStream& P0, System.Object P1)
  Beyond.Byte.ByteBufStream __Gen_Wrap_39(System.Object P0, System.Int32 P1)
  Beyond.Byte.ByteBufStream __Gen_Wrap_40(System.Int32 P0)
  System.Single __Gen_Wrap_41(System.Int32 P0)
  System.Single __Gen_Wrap_42(System.Object P0, System.Int32 P1, System.Boolean P2)
  System.Span<System.Byte> __Gen_Wrap_43(System.Span<System.Byte> P0, System.Int32 P1, System.UInt32 P2, System.Boolean P3)
  System.Byte[] __Gen_Wrap_44(System.Object P0, System.Int32 P1, System.Int32 P2, System.Boolean P3)
  System.Span<System.Byte> __Gen_Wrap_45(System.Span<System.Byte> P0, System.Int32 P1, System.UInt64 P2, System.Boolean P3)
  System.Byte[] __Gen_Wrap_46(System.Object P0, System.Int32 P1, System.Int64 P2, System.Boolean P3)
  System.Span<System.Byte> __Gen_Wrap_47(System.Span<System.Byte> P0, System.Int32 P1, Beyond.Byte.UInt128 P2, System.Boolean P3)
  System.Int32 __Gen_Wrap_48(System.Single P0)
  System.Byte[] __Gen_Wrap_49(System.Object P0, System.Int32 P1, System.Single P2)
  System.Void __Gen_Wrap_50(System.Int64 P0, System.Int32& P1, System.Int32& P2)
  System.Int64 __Gen_Wrap_51(System.Int32 P0, System.Int32 P1)
  System.String __Gen_Wrap_52(System.Object P0, System.Int32 P1, System.Int32 P2)
  System.String __Gen_Wrap_53(System.Object P0)
  System.String __Gen_Wrap_54(System.Span<System.Byte> P0, System.Int32 P1, System.Int32 P2)
  System.String __Gen_Wrap_55(System.Span<System.Byte> P0)
  System.Void __Gen_Wrap_56(System.Object P0, System.Span<System.Byte> P1, System.Int32 P2, System.Int32 P3)
  System.Void __Gen_Wrap_57(System.Object P0, System.Span<System.Byte> P1)
  Beyond.Byte.UInt128 __Gen_Wrap_58(System.Object P0, System.Int32 P1, System.Int32 P2)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000006
EXTENDS: AnonymousStorey
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine)
  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  System.Boolean IsPatched(System.Int32 id)
  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  System.Object CreateWrapper(System.Int32 id)
  System.Object InitWrapperArray(System.Int32 len)
  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
END_CLASS

CLASS: IFix.IDMAP0
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-Byte-UInt128-Equals0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-UInt128-Equals1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-UInt128-GetHashCode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-UInt128-op_Implicit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-UInt128-ToGuid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-UInt128-CompareTo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-UInt128-op_Equality0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-UInt128-op_Inequality0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-GetCurrentIdx0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-GetRaw0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-GetDataCopy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadUInt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-ReadUInt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadInt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-ReadInt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadByte0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-ReadByte0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadULong0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-ReadULong0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadLong0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-ReadLong0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadUInt1280  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-ReadUInt1280  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadUShort0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadShort0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadUTF80  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-ReadUTF80  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-SkipReadUTF80  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-SkipReadUTF80  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteByte0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-WriteByte0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteUInt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-WriteUInt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-WriteInt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteULong0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-WriteULong0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-WriteLong0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteUInt1280  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-WriteUInt1280  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteUShort0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteShort0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteUTF80  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-WriteUTF80  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-SkipBytes0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-RemainBytes0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-CreateFromByte0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteBufStream-Create0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-Int32BitsToSingle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ReadFloat0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteUInt1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteInt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteULong1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteLong0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteUInt1281  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-SingleToInt32Bits0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-WriteFloat0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-SplitLong0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-MergeLong0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-GetHexString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-GetHexString1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-GetHexString2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-GetHexString3  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-AppendHexString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-AppendHexString1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-GetHexStringUnsafeString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-GetHexStringUnsafeString1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Byte-ByteHelper-ComputeMD5Bytes0  // 0x0
METHODS:
END_CLASS

