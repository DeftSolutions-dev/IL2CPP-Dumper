// ========================================================
// Dumped by @desirepro
// Assembly: IFix.Define.dll
// Classes:  8
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace Beyond.HotFix
{

    // TypeToken: 0x2000002
    public class PatchClipboardData
    {
        // Fields
        public System.Int32 ver;        // 0x10
        public System.Int32 overrideVFSIFixVersionFrom;        // 0x14
        public System.Int32 overrideVFSIFixVersionTo;        // 0x18
        public System.String platform;        // 0x20
        public System.Collections.Generic.List<Beyond.HotFix.PatchItem> patches;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000003
    public class PatchItem
    {
        // Fields
        public System.String name;        // 0x10
        public System.String md5;        // 0x18
        public System.Int32 size;        // 0x20
        public System.String data;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class HotFixPatchDefine
    {
        // Fields
        public static readonly System.String hotFixPatchFileExtension;        // 0x0
        public static readonly System.String CLIENT_NET_RSA_PUBLIC_KEY;        // 0x8

        // Methods
        private System.Boolean VerifyMD5(System.Byte[] bytes, System.String expectMd5) { }
        private System.Void .cctor() { }

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
        private System.Boolean __Gen_Wrap_0(System.Object P0, System.Object P1) { }
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
        public static IFix.IDMAP0 Beyond-HotFix-HotFixPatchDefine-VerifyMD50;        // 0x0

    }

}

