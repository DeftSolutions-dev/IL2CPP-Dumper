// ========================================================
// Dumped by @desirepro
// Assembly: Unsafe.VFS.dll
// Classes:  8
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace Beyond.VFS
{

    // TypeToken: 0x2000002
    public struct FVFSUntrackedLowIOReadHandle, IDisposable
    {
        // Fields
        public Unity.IO.LowLevel.Unsafe.ReadCommand* readCommand;        // 0x10
        public Unity.IO.LowLevel.Unsafe.ReadHandle readHandle;        // 0x18
        public System.Boolean isEnc;        // 0x28

        // Methods
        private System.Void .ctor(System.String path, System.Int64 offset, System.Int64 len, System.Boolean async, System.Boolean isEnc) { }
        private System.Void .ctor(Beyond.UnSafeString path, System.Int64 offset, System.Int64 len, System.Boolean async, System.Boolean isEnc) { }
        private System.Void Dispose() { }
        private System.Boolean IsValid() { }
        private System.Boolean IsComplete() { }
        private Unity.IO.LowLevel.Unsafe.ReadStatus GetStatus() { }
        private Unity.Collections.NativeArray<System.Byte> GetData() { }
        private Unity.Collections.NativeArray<System.Byte> GetDataThread() { }

    }

    // TypeToken: 0x2000003
    public struct FVFSPathInfo
    {
        // Fields
        public System.String fullPathFormat;        // 0x10
        public System.String param0;        // 0x18
        public System.String param1;        // 0x20
        public System.String param2;        // 0x28

        // Methods
        private System.String GetResultString() { }
        private Beyond.UnSafeString GetUnsafeString() { }

    }

    // TypeToken: 0x2000004
    public class ThreadUnsafeStringUtils
    {
        // Fields
        private static System.Collections.Concurrent.ConcurrentStack<Beyond.UnSafeString> s_stack;        // 0x0

        // Methods
        private Beyond.UnSafeString ThreadStringAlloc() { }
        private System.Void ThreadStringRelease(Beyond.UnSafeString value) { }
        private Beyond.UnSafeString AppendPathInfo(Beyond.UnSafeString str, Beyond.VFS.FVFSPathInfo& info) { }
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
        private System.Void __Gen_Wrap_0(Beyond.VFS.FVFSUntrackedLowIOReadHandle& P0) { }
        private System.Boolean __Gen_Wrap_1(Beyond.VFS.FVFSUntrackedLowIOReadHandle& P0) { }
        private Unity.IO.LowLevel.Unsafe.ReadStatus __Gen_Wrap_2(Beyond.VFS.FVFSUntrackedLowIOReadHandle& P0) { }
        private Unity.Collections.NativeArray<System.Byte> __Gen_Wrap_3(Beyond.VFS.FVFSUntrackedLowIOReadHandle& P0) { }
        private System.String __Gen_Wrap_4(Beyond.VFS.FVFSPathInfo& P0) { }
        private Beyond.UnSafeString __Gen_Wrap_5(Beyond.VFS.FVFSPathInfo& P0) { }
        private Beyond.UnSafeString __Gen_Wrap_6() { }
        private System.Void __Gen_Wrap_7(System.Object P0) { }
        private Beyond.UnSafeString __Gen_Wrap_8(System.Object P0, Beyond.VFS.FVFSPathInfo& P1) { }
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
        public static IFix.IDMAP0 Beyond-VFS-FVFSUntrackedLowIOReadHandle-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-VFS-FVFSUntrackedLowIOReadHandle-IsValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-VFS-FVFSUntrackedLowIOReadHandle-IsComplete0;        // 0x0
        public static IFix.IDMAP0 Beyond-VFS-FVFSUntrackedLowIOReadHandle-GetStatus0;        // 0x0
        public static IFix.IDMAP0 Beyond-VFS-FVFSUntrackedLowIOReadHandle-GetData0;        // 0x0
        public static IFix.IDMAP0 Beyond-VFS-FVFSUntrackedLowIOReadHandle-GetDataThread0;        // 0x0
        public static IFix.IDMAP0 Beyond-VFS-FVFSPathInfo-GetResultString0;        // 0x0
        public static IFix.IDMAP0 Beyond-VFS-FVFSPathInfo-GetUnsafeString0;        // 0x0
        public static IFix.IDMAP0 Beyond-VFS-ThreadUnsafeStringUtils-ThreadStringAlloc0;        // 0x0
        public static IFix.IDMAP0 Beyond-VFS-ThreadUnsafeStringUtils-ThreadStringRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-VFS-ThreadUnsafeStringUtils-AppendPathInfo0;        // 0x0

    }

}

