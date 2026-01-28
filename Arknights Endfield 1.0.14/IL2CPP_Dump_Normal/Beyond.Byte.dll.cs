// ========================================================
// Dumped by @desirepro
// Assembly: Beyond.Byte.dll
// Classes:  8
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace Beyond.Byte
{

    // TypeToken: 0x2000002
    public struct UInt128, IComparable`1, IEquatable`1
    {
        // Fields
        public System.UInt64 high;        // 0x10
        public System.UInt64 low;        // 0x18

        // Methods
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void .ctor(System.UInt64 high, System.UInt64 low) { }
        private System.Void .ctor(System.Byte[] bytes) { }
        private Beyond.Byte.UInt128 op_Implicit(System.Byte[] bytes) { }
        private System.Guid ToGuid() { }
        private System.Int32 CompareTo(Beyond.Byte.UInt128 other) { }
        private System.Boolean Equals(Beyond.Byte.UInt128 other) { }
        private System.Boolean op_Equality(Beyond.Byte.UInt128 a, Beyond.Byte.UInt128 b) { }
        private System.Boolean op_Inequality(Beyond.Byte.UInt128 a, Beyond.Byte.UInt128 B) { }
        private System.Boolean <>iFixBaseProxy_Equals(System.Object P0) { }
        private System.Int32 <>iFixBaseProxy_GetHashCode() { }

    }

    // TypeToken: 0x2000003
    public struct ByteBufStream
    {
        // Fields
        public System.Int32 currentIdx;        // 0x10
        public System.Byte[] datas;        // 0x18

        // Methods
        private System.Int32 GetCurrentIdx() { }
        private System.Byte[] GetRaw() { }
        private System.Byte[] GetDataCopy() { }
        private System.UInt32 ReadUInt() { }
        private System.Int32 ReadInt() { }
        private System.Int32 ReadByte() { }
        private System.UInt64 ReadULong() { }
        private System.Int64 ReadLong() { }
        private Beyond.Byte.UInt128 ReadUInt128() { }
        private System.String ReadUTF8() { }
        private System.Void SkipReadUTF8() { }
        private System.Void WriteByte(System.Byte val) { }
        private System.Void WriteUInt(System.UInt32 val) { }
        private System.Void WriteInt(System.Int32 val) { }
        private System.Void WriteULong(System.UInt64 val) { }
        private System.Void WriteLong(System.Int64 val) { }
        private System.Void WriteUInt128(Beyond.Byte.UInt128 val) { }
        private System.Void WriteUTF8(System.String val) { }
        private System.Void SkipBytes(System.Int32 offset) { }
        private System.Int32 RemainBytes() { }
        private Beyond.Byte.ByteBufStream CreateFromByte(System.Byte[] bs, System.Int32 startIdx) { }
        private Beyond.Byte.ByteBufStream Create(System.Int32 cap) { }

    }

    // TypeToken: 0x2000004
    public class ByteHelper
    {
        // Methods
        private Beyond.Byte.UInt128 ReadUInt128(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle) { }
        private System.Int64 ReadLong(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle) { }
        private System.UInt64 ReadULong(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle) { }
        private System.UInt32 ReadUInt(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle) { }
        private System.Int32 ReadInt(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle) { }
        private System.UInt16 ReadUShort(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle) { }
        private System.Int16 ReadShort(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle) { }
        private System.Byte ReadByte(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle) { }
        private System.Single ReadFloat(System.Byte[] bs, System.Int32 startIndex, System.Boolean bIsLittle) { }
        private System.String ReadUTF8(System.Byte[] bs, System.Int32 startIndex, System.Int16& len) { }
        private System.Void SkipReadUTF8(System.Byte[] bs, System.Int32 startIndex, System.Int16& len) { }
        private System.Byte[] WriteByte(System.Byte[] data, System.Int32 writerIndex, System.Byte value) { }
        private System.Byte[] WriteUShort(System.Byte[] data, System.Int32 writerIndex, System.UInt16 value, System.Boolean bIsLittle) { }
        private System.Byte[] WriteShort(System.Byte[] data, System.Int32 writerIndex, System.Int16 value, System.Boolean bIsLittle) { }
        private System.Byte[] WriteUInt(System.Byte[] data, System.Int32 writerIndex, System.UInt32 value, System.Boolean bIsLittle) { }
        private System.Span<System.Byte> WriteUInt(System.Span<System.Byte> data, System.Int32 writerIndex, System.UInt32 value, System.Boolean bIsLittle) { }
        private System.Byte[] WriteInt(System.Byte[] data, System.Int32 writerIndex, System.Int32 value, System.Boolean bIsLittle) { }
        private System.Byte[] WriteULong(System.Byte[] data, System.Int32 writerIndex, System.UInt64 value, System.Boolean bIsLittle) { }
        private System.Span<System.Byte> WriteULong(System.Span<System.Byte> data, System.Int32 writerIndex, System.UInt64 value, System.Boolean bIsLittle) { }
        private System.Byte[] WriteLong(System.Byte[] data, System.Int32 writerIndex, System.Int64 value, System.Boolean bIsLittle) { }
        private System.Byte[] WriteUInt128(System.Byte[] data, System.Int32 writerIndex, Beyond.Byte.UInt128 value, System.Boolean bIsLittle) { }
        private System.Span<System.Byte> WriteUInt128(System.Span<System.Byte> data, System.Int32 writerIndex, Beyond.Byte.UInt128 value, System.Boolean bIsLittle) { }
        private System.Byte[] WriteFloat(System.Byte[] data, System.Int32 writerIndex, System.Single value) { }
        private System.Byte[] WriteUTF8(System.Byte[] data, System.Int32 writerIndex, System.String value, System.Int32& len) { }
        private System.Void SplitLong(System.Int64 longValue, System.Int32& highInt, System.Int32& lowInt) { }
        private System.Int64 MergeLong(System.Int32 highInt, System.Int32 lowInt) { }
        private System.Int32 SingleToInt32Bits(System.Single value) { }
        private System.Single Int32BitsToSingle(System.Int32 value) { }
        private System.String GetHexString(System.Byte[] byteArray) { }
        private System.String GetHexString(System.Byte[] byteArray, System.Int32 startIdx, System.Int32 length) { }
        private System.String GetHexString(System.Span<System.Byte> byteArray) { }
        private System.String GetHexString(System.Span<System.Byte> byteArray, System.Int32 startIdx, System.Int32 length) { }
        private System.Void AppendHexString(Beyond.UnSafeString str, System.Span<System.Byte> byteArray) { }
        private System.Void AppendHexString(Beyond.UnSafeString str, System.Span<System.Byte> byteArray, System.Int32 startIdx, System.Int32 length) { }
        private System.String GetHexStringUnsafeString(System.Span<System.Byte> byteArray) { }
        private System.String GetHexStringUnsafeString(System.Span<System.Byte> byteArray, System.Int32 startIdx, System.Int32 length) { }
        private Beyond.Byte.UInt128 ComputeMD5Bytes(System.Byte[] bs, System.Int32 offset, System.Int32 count) { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000005
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.Boolean __Gen_Wrap_0(Beyond.Byte.UInt128& P0, Beyond.Byte.UInt128 P1) { }
        private System.Boolean __Gen_Wrap_1(Beyond.Byte.UInt128& P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_2(Beyond.Byte.UInt128& P0) { }
        private Beyond.Byte.UInt128 __Gen_Wrap_3(System.Object P0) { }
        private System.Guid __Gen_Wrap_4(Beyond.Byte.UInt128& P0) { }
        private System.Int32 __Gen_Wrap_5(Beyond.Byte.UInt128& P0, Beyond.Byte.UInt128 P1) { }
        private System.Boolean __Gen_Wrap_6(Beyond.Byte.UInt128 P0, Beyond.Byte.UInt128 P1) { }
        private System.Int32 __Gen_Wrap_7(Beyond.Byte.ByteBufStream& P0) { }
        private System.Byte[] __Gen_Wrap_8(Beyond.Byte.ByteBufStream& P0) { }
        private System.UInt32 __Gen_Wrap_9(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        private System.UInt32 __Gen_Wrap_10(Beyond.Byte.ByteBufStream& P0) { }
        private System.Int32 __Gen_Wrap_11(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        private System.Byte __Gen_Wrap_12(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        private System.UInt64 __Gen_Wrap_13(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        private System.UInt64 __Gen_Wrap_14(Beyond.Byte.ByteBufStream& P0) { }
        private System.Int64 __Gen_Wrap_15(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        private System.Int64 __Gen_Wrap_16(Beyond.Byte.ByteBufStream& P0) { }
        private Beyond.Byte.UInt128 __Gen_Wrap_17(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        private Beyond.Byte.UInt128 __Gen_Wrap_18(Beyond.Byte.ByteBufStream& P0) { }
        private System.UInt16 __Gen_Wrap_19(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        private System.Int16 __Gen_Wrap_20(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        private System.String __Gen_Wrap_21(System.Object P0, System.Int32 P1, System.Int16& P2) { }
        private System.String __Gen_Wrap_22(Beyond.Byte.ByteBufStream& P0) { }
        private System.Void __Gen_Wrap_23(System.Object P0, System.Int32 P1, System.Int16& P2) { }
        private System.Void __Gen_Wrap_24(Beyond.Byte.ByteBufStream& P0) { }
        private System.Byte[] __Gen_Wrap_25(System.Object P0, System.Int32 P1, System.Byte P2) { }
        private System.Void __Gen_Wrap_26(Beyond.Byte.ByteBufStream& P0, System.Byte P1) { }
        private System.Byte[] __Gen_Wrap_27(System.Object P0, System.Int32 P1, System.UInt32 P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_28(Beyond.Byte.ByteBufStream& P0, System.UInt32 P1) { }
        private System.Void __Gen_Wrap_29(Beyond.Byte.ByteBufStream& P0, System.Int32 P1) { }
        private System.Byte[] __Gen_Wrap_30(System.Object P0, System.Int32 P1, System.UInt64 P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_31(Beyond.Byte.ByteBufStream& P0, System.UInt64 P1) { }
        private System.Void __Gen_Wrap_32(Beyond.Byte.ByteBufStream& P0, System.Int64 P1) { }
        private System.Byte[] __Gen_Wrap_33(System.Object P0, System.Int32 P1, Beyond.Byte.UInt128 P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_34(Beyond.Byte.ByteBufStream& P0, Beyond.Byte.UInt128 P1) { }
        private System.Byte[] __Gen_Wrap_35(System.Object P0, System.Int32 P1, System.UInt16 P2, System.Boolean P3) { }
        private System.Byte[] __Gen_Wrap_36(System.Object P0, System.Int32 P1, System.Int16 P2, System.Boolean P3) { }
        private System.Byte[] __Gen_Wrap_37(System.Object P0, System.Int32 P1, System.Object P2, System.Int32& P3) { }
        private System.Void __Gen_Wrap_38(Beyond.Byte.ByteBufStream& P0, System.Object P1) { }
        private Beyond.Byte.ByteBufStream __Gen_Wrap_39(System.Object P0, System.Int32 P1) { }
        private Beyond.Byte.ByteBufStream __Gen_Wrap_40(System.Int32 P0) { }
        private System.Single __Gen_Wrap_41(System.Int32 P0) { }
        private System.Single __Gen_Wrap_42(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        private System.Span<System.Byte> __Gen_Wrap_43(System.Span<System.Byte> P0, System.Int32 P1, System.UInt32 P2, System.Boolean P3) { }
        private System.Byte[] __Gen_Wrap_44(System.Object P0, System.Int32 P1, System.Int32 P2, System.Boolean P3) { }
        private System.Span<System.Byte> __Gen_Wrap_45(System.Span<System.Byte> P0, System.Int32 P1, System.UInt64 P2, System.Boolean P3) { }
        private System.Byte[] __Gen_Wrap_46(System.Object P0, System.Int32 P1, System.Int64 P2, System.Boolean P3) { }
        private System.Span<System.Byte> __Gen_Wrap_47(System.Span<System.Byte> P0, System.Int32 P1, Beyond.Byte.UInt128 P2, System.Boolean P3) { }
        private System.Int32 __Gen_Wrap_48(System.Single P0) { }
        private System.Byte[] __Gen_Wrap_49(System.Object P0, System.Int32 P1, System.Single P2) { }
        private System.Void __Gen_Wrap_50(System.Int64 P0, System.Int32& P1, System.Int32& P2) { }
        private System.Int64 __Gen_Wrap_51(System.Int32 P0, System.Int32 P1) { }
        private System.String __Gen_Wrap_52(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        private System.String __Gen_Wrap_53(System.Object P0) { }
        private System.String __Gen_Wrap_54(System.Span<System.Byte> P0, System.Int32 P1, System.Int32 P2) { }
        private System.String __Gen_Wrap_55(System.Span<System.Byte> P0) { }
        private System.Void __Gen_Wrap_56(System.Object P0, System.Span<System.Byte> P1, System.Int32 P2, System.Int32 P3) { }
        private System.Void __Gen_Wrap_57(System.Object P0, System.Span<System.Byte> P1) { }
        private Beyond.Byte.UInt128 __Gen_Wrap_58(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000006
    public class ILFixInterfaceBridge : AnonymousStorey
    {
        // Methods
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000007
    public class WrappersManagerImpl, WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        private IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        private System.Boolean IsPatched(System.Int32 id) { }
        private System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        private System.Object CreateWrapper(System.Int32 id) { }
        private System.Object InitWrapperArray(System.Int32 len) { }
        private IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000008
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-Byte-UInt128-Equals0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-UInt128-Equals1;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-UInt128-GetHashCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-UInt128-op_Implicit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-UInt128-ToGuid0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-UInt128-CompareTo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-UInt128-op_Equality0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-UInt128-op_Inequality0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-GetCurrentIdx0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-GetRaw0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-GetDataCopy0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-ReadUInt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-ReadUInt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-ReadInt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-ReadInt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-ReadByte0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-ReadByte0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-ReadULong0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-ReadULong0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-ReadLong0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-ReadLong0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-ReadUInt1280;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-ReadUInt1280;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-ReadUShort0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-ReadShort0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-ReadUTF80;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-ReadUTF80;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-SkipReadUTF80;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-SkipReadUTF80;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-WriteByte0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-WriteByte0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-WriteUInt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-WriteUInt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-WriteInt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-WriteULong0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-WriteULong0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-WriteLong0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-WriteUInt1280;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-WriteUInt1280;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-WriteUShort0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-WriteShort0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-WriteUTF80;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-WriteUTF80;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-SkipBytes0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-RemainBytes0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-CreateFromByte0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteBufStream-Create0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-Int32BitsToSingle0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-ReadFloat0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-WriteUInt1;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-WriteInt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-WriteULong1;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-WriteLong0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-WriteUInt1281;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-SingleToInt32Bits0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-WriteFloat0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-SplitLong0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-MergeLong0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-GetHexString0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-GetHexString1;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-GetHexString2;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-GetHexString3;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-AppendHexString0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-AppendHexString1;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-GetHexStringUnsafeString0;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-GetHexStringUnsafeString1;        // 0x0
        public static IFix.IDMAP0 Beyond-Byte-ByteHelper-ComputeMD5Bytes0;        // 0x0

    }

}

