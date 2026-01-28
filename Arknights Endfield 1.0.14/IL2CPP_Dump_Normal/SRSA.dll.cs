// ========================================================
// Dumped by @desirepro
// Assembly: SRSA.dll
// Classes:  6
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace Beyond
{

    // TypeToken: 0x2000002
    public class SRSA
    {
        // Fields
        private static System.String EncryptionLib;        // 0x0
        public static System.Int32 s_keyLength;        // 0x0

        // Methods
        private System.IntPtr mono_method_h_get_code(System.IntPtr message, System.Int32 message_size) { }
        private System.IntPtr mono_method_h_set_code(System.IntPtr message) { }
        private System.Void mono_method_h_remove_code(System.IntPtr message) { }
        private System.Void LoadFromFile(System.Span<System.Byte> message, System.Span<System.Byte>& buffer) { }
        private System.Void LoadFromFile2(System.Span<System.Byte> inputData, System.Span<System.Byte>& outputBytes) { }
        private System.Void test() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000003
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.Void __Gen_Wrap_0(System.Span<System.Byte> P0, System.Span<System.Byte>& P1) { }
        private System.Void __Gen_Wrap_1() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000004
    public class ILFixInterfaceBridge : AnonymousStorey
    {
        // Methods
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000005
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

    // TypeToken: 0x2000006
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-SRSA-LoadFromFile0;        // 0x0
        public static IFix.IDMAP0 Beyond-SRSA-LoadFromFile20;        // 0x0
        public static IFix.IDMAP0 Beyond-SRSA-test0;        // 0x0

    }

}

