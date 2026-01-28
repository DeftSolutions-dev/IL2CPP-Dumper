// ========================================================
// Dumped by @desirepro
// Assembly: SRSA.dll
// Classes:  6
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Beyond.SRSA
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private   static  System.String                   EncryptionLib  // 0x0
  public    static  System.Int32                    s_keyLength  // 0x0
METHODS:
  System.IntPtr mono_method_h_get_code(System.IntPtr message, System.Int32 message_size)
  System.IntPtr mono_method_h_set_code(System.IntPtr message)
  System.Void mono_method_h_remove_code(System.IntPtr message)
  System.Void LoadFromFile(System.Span<System.Byte> message, System.Span<System.Byte>& buffer)
  System.Void LoadFromFile2(System.Span<System.Byte> inputData, System.Span<System.Byte>& outputBytes)
  System.Void test()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.Void __Gen_Wrap_0(System.Span<System.Byte> P0, System.Span<System.Byte>& P1)
  System.Void __Gen_Wrap_1()
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000004
EXTENDS: AnonymousStorey
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000005
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
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-SRSA-LoadFromFile0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SRSA-LoadFromFile20  // 0x0
  public    static  IFix.IDMAP0                     Beyond-SRSA-test0  // 0x0
METHODS:
END_CLASS

