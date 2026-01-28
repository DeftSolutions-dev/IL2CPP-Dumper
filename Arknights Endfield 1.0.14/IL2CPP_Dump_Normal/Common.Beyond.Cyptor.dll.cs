// ========================================================
// Dumped by @desirepro
// Assembly: Common.Beyond.Cyptor.dll
// Classes:  10
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000005
    public struct __StaticArrayInitTypeSize=15
    {
    }

    // TypeToken: 0x2000006
    public struct __StaticArrayInitTypeSize=1024
    {
    }

namespace Beyond.Cryptor
{

    // TypeToken: 0x2000002
    public class Crc32Utils
    {
        // Fields
        private static readonly System.String UNITY_CRC_SALT;        // 0x0
        private static readonly System.Int32 MAX_CACHE_CHAR_NUM;        // 0x8
        private static readonly System.Int32 MAX_CACHE_CHAR_BYTE_NUM;        // 0xC
        private static readonly System.UInt32[] crctable;        // 0x10

        // Methods
        private System.UInt32 CalculateCrc32(System.Byte[] data, System.Int32 offset, System.Int32 length, System.UInt32 startCRC) { }
        private System.UInt32 CalculateCrc32(System.ReadOnlySpan<System.Byte> data, System.Int32 offset, System.Int32 length, System.UInt32 startCRC) { }
        private System.Int32 UnityCRC(System.String s) { }
        private System.Int64 UnityCRC64(System.String s) { }
        private System.Int64 XXHash64(System.String input) { }
        private System.UInt64 XXHash64(System.Byte[] bytes) { }
        private System.Int32 XXHash32(System.String input) { }
        private System.Int32 CRC32(System.Byte[] input, System.Int32 offset, System.Int32 length) { }
        private System.Int32 CRC32(System.String s) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000003
    public class RSACryptoUtils
    {
        // Methods
        private System.Security.Cryptography.RSACryptoServiceProvider CreateRsaProviderFromPrivateKey(System.String privateKey) { }
        private System.Int32 _GetIntegerSize(System.IO.BinaryReader binr) { }
        private System.Security.Cryptography.RSACryptoServiceProvider CreateRsaProviderFromPublicKey(System.String publicKeyString) { }
        private System.Boolean VerfyStream(System.IO.Stream stream, System.String publicKey) { }
        private System.Security.Cryptography.RSACryptoServiceProvider CreateRsaProviderFromPublicKey(System.Byte[] x509key) { }
        private System.Boolean _CompareBytearrays(System.Byte[] a, System.Byte[] b) { }
        private System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000007
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.UInt32 __Gen_Wrap_0(System.ReadOnlySpan<System.Byte> P0, System.Int32 P1, System.Int32 P2, System.UInt32 P3) { }
        private System.Int32 __Gen_Wrap_1(System.Object P0) { }
        private System.Int64 __Gen_Wrap_2(System.Object P0) { }
        private System.UInt64 __Gen_Wrap_3(System.Object P0) { }
        private System.Security.Cryptography.RSACryptoServiceProvider __Gen_Wrap_4(System.Object P0) { }
        private System.Boolean __Gen_Wrap_5(System.Object P0, System.Object P1) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000008
    public class ILFixInterfaceBridge : AnonymousStorey
    {
        // Methods
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000009
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

    // TypeToken: 0x200000A
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-Cryptor-Crc32Utils-CalculateCrc320;        // 0x0
        public static IFix.IDMAP0 Beyond-Cryptor-Crc32Utils-UnityCRC0;        // 0x0
        public static IFix.IDMAP0 Beyond-Cryptor-Crc32Utils-UnityCRC640;        // 0x0
        public static IFix.IDMAP0 Beyond-Cryptor-Crc32Utils-XXHash640;        // 0x0
        public static IFix.IDMAP0 Beyond-Cryptor-Crc32Utils-XXHash641;        // 0x0
        public static IFix.IDMAP0 Beyond-Cryptor-Crc32Utils-XXHash320;        // 0x0
        public static IFix.IDMAP0 Beyond-Cryptor-Crc32Utils-CRC320;        // 0x0
        public static IFix.IDMAP0 Beyond-Cryptor-RSACryptoUtils-_GetIntegerSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-Cryptor-RSACryptoUtils-CreateRsaProviderFromPrivateKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-Cryptor-RSACryptoUtils-CreateRsaProviderFromPublicKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-Cryptor-RSACryptoUtils-CreateRsaProviderFromPublicKey1;        // 0x0
        public static IFix.IDMAP0 Beyond-Cryptor-RSACryptoUtils-VerfyStream0;        // 0x0
        public static IFix.IDMAP0 Beyond-Cryptor-RSACryptoUtils-_CompareBytearrays0;        // 0x0

    }

}

