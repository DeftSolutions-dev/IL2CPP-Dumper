// ========================================================
// Dumped by @desirepro
// Assembly: IFix.Define.dll
// Classes:  8
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Beyond.HotFix.PatchClipboardData
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  public            System.Int32                    ver  // 0x10
  public            System.Int32                    overrideVFSIFixVersionFrom  // 0x14
  public            System.Int32                    overrideVFSIFixVersionTo  // 0x18
  public            System.String                   platform  // 0x20
  public            System.Collections.Generic.List<Beyond.HotFix.PatchItem>patches  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.HotFix.PatchItem
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   md5  // 0x18
  public            System.Int32                    size  // 0x20
  public            System.String                   data  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.HotFix.HotFixPatchDefine
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  public    static readonly System.String                   hotFixPatchFileExtension  // 0x0
  public    static readonly System.String                   CLIENT_NET_RSA_PUBLIC_KEY  // 0x8
METHODS:
  System.Boolean VerifyMD5(System.Byte[] bytes, System.String expectMd5)
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
  System.Boolean __Gen_Wrap_0(System.Object P0, System.Object P1)
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
  public    static  IFix.IDMAP0                     Beyond-HotFix-HotFixPatchDefine-VerifyMD50  // 0x0
METHODS:
END_CLASS

