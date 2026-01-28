// ========================================================
// Dumped by @desirepro
// Assembly: Unsafe.VFS.dll
// Classes:  8
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Beyond.VFS.FVFSUntrackedLowIOReadHandle
TYPE:  struct
TOKEN: 0x2000002
FIELDS:
  public            Unity.IO.LowLevel.Unsafe.ReadCommand*readCommand  // 0x10
  public            Unity.IO.LowLevel.Unsafe.ReadHandlereadHandle  // 0x18
  public            System.Boolean                  isEnc  // 0x28
METHODS:
  System.Void .ctor(System.String path, System.Int64 offset, System.Int64 len, System.Boolean async, System.Boolean isEnc)
  System.Void .ctor(Beyond.UnSafeString path, System.Int64 offset, System.Int64 len, System.Boolean async, System.Boolean isEnc)
  System.Void Dispose()
  System.Boolean IsValid()
  System.Boolean IsComplete()
  Unity.IO.LowLevel.Unsafe.ReadStatus GetStatus()
  Unity.Collections.NativeArray<System.Byte> GetData()
  Unity.Collections.NativeArray<System.Byte> GetDataThread()
END_CLASS

CLASS: Beyond.VFS.FVFSPathInfo
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            System.String                   fullPathFormat  // 0x10
  public            System.String                   param0  // 0x18
  public            System.String                   param1  // 0x20
  public            System.String                   param2  // 0x28
METHODS:
  System.String GetResultString()
  Beyond.UnSafeString GetUnsafeString()
END_CLASS

CLASS: Beyond.VFS.ThreadUnsafeStringUtils
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private   static  System.Collections.Concurrent.ConcurrentStack<Beyond.UnSafeString>s_stack  // 0x0
METHODS:
  Beyond.UnSafeString ThreadStringAlloc()
  System.Void ThreadStringRelease(Beyond.UnSafeString value)
  Beyond.UnSafeString AppendPathInfo(Beyond.UnSafeString str, Beyond.VFS.FVFSPathInfo& info)
  System.Void .cctor()
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
  System.Void __Gen_Wrap_0(Beyond.VFS.FVFSUntrackedLowIOReadHandle& P0)
  System.Boolean __Gen_Wrap_1(Beyond.VFS.FVFSUntrackedLowIOReadHandle& P0)
  Unity.IO.LowLevel.Unsafe.ReadStatus __Gen_Wrap_2(Beyond.VFS.FVFSUntrackedLowIOReadHandle& P0)
  Unity.Collections.NativeArray<System.Byte> __Gen_Wrap_3(Beyond.VFS.FVFSUntrackedLowIOReadHandle& P0)
  System.String __Gen_Wrap_4(Beyond.VFS.FVFSPathInfo& P0)
  Beyond.UnSafeString __Gen_Wrap_5(Beyond.VFS.FVFSPathInfo& P0)
  Beyond.UnSafeString __Gen_Wrap_6()
  System.Void __Gen_Wrap_7(System.Object P0)
  Beyond.UnSafeString __Gen_Wrap_8(System.Object P0, Beyond.VFS.FVFSPathInfo& P1)
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
  public    static  IFix.IDMAP0                     Beyond-VFS-FVFSUntrackedLowIOReadHandle-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VFS-FVFSUntrackedLowIOReadHandle-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VFS-FVFSUntrackedLowIOReadHandle-IsComplete0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VFS-FVFSUntrackedLowIOReadHandle-GetStatus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VFS-FVFSUntrackedLowIOReadHandle-GetData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VFS-FVFSUntrackedLowIOReadHandle-GetDataThread0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VFS-FVFSPathInfo-GetResultString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VFS-FVFSPathInfo-GetUnsafeString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VFS-ThreadUnsafeStringUtils-ThreadStringAlloc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VFS-ThreadUnsafeStringUtils-ThreadStringRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-VFS-ThreadUnsafeStringUtils-AppendPathInfo0  // 0x0
METHODS:
END_CLASS

