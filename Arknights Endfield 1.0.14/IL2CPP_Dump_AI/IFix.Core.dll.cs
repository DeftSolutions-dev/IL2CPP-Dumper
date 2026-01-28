// ========================================================
// Dumped by @desirepro
// Assembly: IFix.Core.dll
// Classes:  37
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: CalliInvokerInfo
TYPE:  class
TOKEN: 0x2000024
FIELDS:
  public            IFix.Core.ExternInvoker         Invoker  // 0x10
  public            System.Int32                    ArgumentCount  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: IFix.CustomBridgeAttribute
TYPE:  class
TOKEN: 0x200001C
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: IFix.Core.IDTagAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
  public            System.Int32                    ID  // 0x10
METHODS:
  System.Void .ctor(System.Int32 id)
END_CLASS

CLASS: IFix.Core.PatchManager
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Reflection.Assembly,System.Action>removers  // 0x0
  private   static  System.Func<System.Reflection.ParameterInfo,System.Type><>f__am$cache0  // 0x8
METHODS:
  System.Reflection.MethodBase readMethod(System.IO.BinaryReader reader, System.Type[] externTypes)
  System.Int32 getMapId(System.Collections.Generic.List<System.Type> idMapArray, System.Reflection.MethodBase method)
  System.Int32[] readSlotInfo(System.IO.BinaryReader reader, System.Collections.Generic.Dictionary<System.Reflection.MethodInfo,System.Int32> itfMethodToId, System.Type[] externTypes, System.Int32 maxId)
  IFix.Core.VirtualMachine Load(System.IO.Stream stream, System.Boolean checkNew)
  System.Void Unload(System.Reflection.Assembly assembly)
  System.Void .cctor()
  System.Type <readMethod>m__0(System.Reflection.ParameterInfo p)
END_CLASS

CLASS: IFix.Core.Code
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.Core.Code                  Blt_Un  // 0x0
  public    static  IFix.Core.Code                  Ldind_U1  // 0x0
  public    static  IFix.Core.Code                  Stelem_Any  // 0x0
  public    static  IFix.Core.Code                  Ldelem_I  // 0x0
  public    static  IFix.Core.Code                  Endfinally  // 0x0
  public    static  IFix.Core.Code                  Arglist  // 0x0
  public    static  IFix.Core.Code                  Shl  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_I4  // 0x0
  public    static  IFix.Core.Code                  Stloc  // 0x0
  public    static  IFix.Core.Code                  Refanytype  // 0x0
  public    static  IFix.Core.Code                  Callvirt  // 0x0
  public    static  IFix.Core.Code                  Ldelem_R8  // 0x0
  public    static  IFix.Core.Code                  Unaligned  // 0x0
  public    static  IFix.Core.Code                  Conv_I2  // 0x0
  public    static  IFix.Core.Code                  Ldfld  // 0x0
  public    static  IFix.Core.Code                  Sizeof  // 0x0
  public    static  IFix.Core.Code                  Newanon  // 0x0
  public    static  IFix.Core.Code                  Sub  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_U2  // 0x0
  public    static  IFix.Core.Code                  Cgt_Un  // 0x0
  public    static  IFix.Core.Code                  Call  // 0x0
  public    static  IFix.Core.Code                  Stind_R8  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_I8  // 0x0
  public    static  IFix.Core.Code                  Readonly  // 0x0
  public    static  IFix.Core.Code                  Newobj  // 0x0
  public    static  IFix.Core.Code                  Shr_Un  // 0x0
  public    static  IFix.Core.Code                  Ldvirtftn  // 0x0
  public    static  IFix.Core.Code                  Jmp  // 0x0
  public    static  IFix.Core.Code                  Cgt  // 0x0
  public    static  IFix.Core.Code                  Ldtoken  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_U  // 0x0
  public    static  IFix.Core.Code                  Ldind_Ref  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_I_Un  // 0x0
  public    static  IFix.Core.Code                  Conv_I1  // 0x0
  public    static  IFix.Core.Code                  Ldloc  // 0x0
  public    static  IFix.Core.Code                  Ldind_R8  // 0x0
  public    static  IFix.Core.Code                  Ldind_U4  // 0x0
  public    static  IFix.Core.Code                  Ldlen  // 0x0
  public    static  IFix.Core.Code                  Rem_Un  // 0x0
  public    static  IFix.Core.Code                  Starg  // 0x0
  public    static  IFix.Core.Code                  Calli  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_U1_Un  // 0x0
  public    static  IFix.Core.Code                  Add  // 0x0
  public    static  IFix.Core.Code                  Switch  // 0x0
  public    static  IFix.Core.Code                  CallExtern  // 0x0
  public    static  IFix.Core.Code                  Ldelem_I8  // 0x0
  public    static  IFix.Core.Code                  Ldelema  // 0x0
  public    static  IFix.Core.Code                  Div  // 0x0
  public    static  IFix.Core.Code                  Br  // 0x0
  public    static  IFix.Core.Code                  Ret  // 0x0
  public    static  IFix.Core.Code                  Ldind_I4  // 0x0
  public    static  IFix.Core.Code                  Clt  // 0x0
  public    static  IFix.Core.Code                  Conv_I4  // 0x0
  public    static  IFix.Core.Code                  Ceq  // 0x0
  public    static  IFix.Core.Code                  Conv_U  // 0x0
  public    static  IFix.Core.Code                  Initobj  // 0x0
  public    static  IFix.Core.Code                  Stelem_Ref  // 0x0
  public    static  IFix.Core.Code                  Mul_Ovf_Un  // 0x0
  public    static  IFix.Core.Code                  Ldstr  // 0x0
  public    static  IFix.Core.Code                  Mul_Ovf  // 0x0
  public    static  IFix.Core.Code                  Sub_Ovf  // 0x0
  public    static  IFix.Core.Code                  Ldelem_U1  // 0x0
  public    static  IFix.Core.Code                  Conv_I  // 0x0
  public    static  IFix.Core.Code                  Conv_U4  // 0x0
  public    static  IFix.Core.Code                  Blt  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_I  // 0x0
  public    static  IFix.Core.Code                  No  // 0x0
  public    static  IFix.Core.Code                  Brtrue  // 0x0
  public    static  IFix.Core.Code                  Unbox_Any  // 0x0
  public    static  IFix.Core.Code                  Not  // 0x0
  public    static  IFix.Core.Code                  Neg  // 0x0
  public    static  IFix.Core.Code                  Ldind_I8  // 0x0
  public    static  IFix.Core.Code                  Stind_Ref  // 0x0
  public    static  IFix.Core.Code                  Conv_R4  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_U4  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_U8  // 0x0
  public    static  IFix.Core.Code                  Ldind_I  // 0x0
  public    static  IFix.Core.Code                  Tail  // 0x0
  public    static  IFix.Core.Code                  Initblk  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_U8_Un  // 0x0
  public    static  IFix.Core.Code                  Shr  // 0x0
  public    static  IFix.Core.Code                  Callvirtvirt  // 0x0
  public    static  IFix.Core.Code                  StackSpace  // 0x0
  public    static  IFix.Core.Code                  Ldsflda  // 0x0
  public    static  IFix.Core.Code                  Ble  // 0x0
  public    static  IFix.Core.Code                  Ldloca  // 0x0
  public    static  IFix.Core.Code                  Ldtype  // 0x0
  public    static  IFix.Core.Code                  Conv_I8  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_U2_Un  // 0x0
  public    static  IFix.Core.Code                  Add_Ovf  // 0x0
  public    static  IFix.Core.Code                  Isinst  // 0x0
  public    static  IFix.Core.Code                  Stobj  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_I1_Un  // 0x0
  public    static  IFix.Core.Code                  Cpblk  // 0x0
  public    static  IFix.Core.Code                  Pop  // 0x0
  public    static  IFix.Core.Code                  And  // 0x0
  public    static  IFix.Core.Code                  Box  // 0x0
  public    static  IFix.Core.Code                  Mul  // 0x0
  public    static  IFix.Core.Code                  Conv_U1  // 0x0
  public    static  IFix.Core.Code                  Nop  // 0x0
  public    static  IFix.Core.Code                  Conv_R_Un  // 0x0
  public    static  IFix.Core.Code                  Ldarga  // 0x0
  public    static  IFix.Core.Code                  Bgt  // 0x0
  public    static  IFix.Core.Code                  Break  // 0x0
  public    static  IFix.Core.Code                  Div_Un  // 0x0
  public    static  IFix.Core.Code                  Ldc_I4  // 0x0
  public    static  IFix.Core.Code                  Refanyval  // 0x0
  public    static  IFix.Core.Code                  Conv_U8  // 0x0
  public    static  IFix.Core.Code                  Bgt_Un  // 0x0
  public    static  IFix.Core.Code                  Stelem_R8  // 0x0
  public    static  IFix.Core.Code                  Bge  // 0x0
  public    static  IFix.Core.Code                  Ldflda  // 0x0
  public    static  IFix.Core.Code                  Ldelem_I1  // 0x0
  public    static  IFix.Core.Code                  Localloc  // 0x0
  public    static  IFix.Core.Code                  Ldind_I1  // 0x0
  public    static  IFix.Core.Code                  Ldelem_U4  // 0x0
  public    static  IFix.Core.Code                  Volatile  // 0x0
  public    static  IFix.Core.Code                  Ldarg  // 0x0
  public    static  IFix.Core.Code                  Ldftn  // 0x0
  public    static  IFix.Core.Code                  Xor  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_I2  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_U_Un  // 0x0
  public    static  IFix.Core.Code                  Stind_I2  // 0x0
  public    static  IFix.Core.Code                  Ldc_R4  // 0x0
  public    static  IFix.Core.Code                  Stelem_I2  // 0x0
  public    static  IFix.Core.Code                  Or  // 0x0
  public    static  IFix.Core.Code                  Castclass  // 0x0
  public    static  IFix.Core.Code                  Newarr  // 0x0
  public    static  IFix.Core.Code                  Throw  // 0x0
  public    static  IFix.Core.Code                  Conv_U2  // 0x0
  public    static  IFix.Core.Code                  Clt_Un  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_U4_Un  // 0x0
  public    static  IFix.Core.Code                  Dup  // 0x0
  public    static  IFix.Core.Code                  Ldvirtftn2  // 0x0
  public    static  IFix.Core.Code                  Add_Ovf_Un  // 0x0
  public    static  IFix.Core.Code                  Ldc_R8  // 0x0
  public    static  IFix.Core.Code                  Ldelem_Any  // 0x0
  public    static  IFix.Core.Code                  Sub_Ovf_Un  // 0x0
  public    static  IFix.Core.Code                  Brfalse  // 0x0
  public    static  IFix.Core.Code                  Conv_R8  // 0x0
  public    static  IFix.Core.Code                  Unbox  // 0x0
  public    static  IFix.Core.Code                  Endfilter  // 0x0
  public    static  IFix.Core.Code                  Rethrow  // 0x0
  public    static  IFix.Core.Code                  Rem  // 0x0
  public    static  IFix.Core.Code                  Ldnull  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_U1  // 0x0
  public    static  IFix.Core.Code                  Stfld  // 0x0
  public    static  IFix.Core.Code                  Stelem_I  // 0x0
  public    static  IFix.Core.Code                  Mkrefany  // 0x0
  public    static  IFix.Core.Code                  Stelem_R4  // 0x0
  public    static  IFix.Core.Code                  Ldc_I8  // 0x0
  public    static  IFix.Core.Code                  Cpobj  // 0x0
  public    static  IFix.Core.Code                  Stind_I8  // 0x0
  public    static  IFix.Core.Code                  Bne_Un  // 0x0
  public    static  IFix.Core.Code                  Constrained  // 0x0
  public    static  IFix.Core.Code                  Stelem_I1  // 0x0
  public    static  IFix.Core.Code                  Beq  // 0x0
  public    static  IFix.Core.Code                  Bge_Un  // 0x0
  public    static  IFix.Core.Code                  Ldind_I2  // 0x0
  public    static  IFix.Core.Code                  Ldelem_I2  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_I8_Un  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_I1  // 0x0
  public    static  IFix.Core.Code                  Ldobj  // 0x0
  public    static  IFix.Core.Code                  Leave  // 0x0
  public    static  IFix.Core.Code                  Stind_I  // 0x0
  public    static  IFix.Core.Code                  Stind_I1  // 0x0
  public    static  IFix.Core.Code                  Ldelem_R4  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_I4_Un  // 0x0
  public    static  IFix.Core.Code                  Ldelem_I4  // 0x0
  public    static  IFix.Core.Code                  Ldind_R4  // 0x0
  public    static  IFix.Core.Code                  Ckfinite  // 0x0
  public    static  IFix.Core.Code                  Ldelem_Ref  // 0x0
  public    static  IFix.Core.Code                  Stsfld  // 0x0
  public    static  IFix.Core.Code                  Ldsfld  // 0x0
  public    static  IFix.Core.Code                  Stelem_I8  // 0x0
  public    static  IFix.Core.Code                  Stelem_I4  // 0x0
  public    static  IFix.Core.Code                  Ldelem_U2  // 0x0
  public    static  IFix.Core.Code                  Conv_Ovf_I2_Un  // 0x0
  public    static  IFix.Core.Code                  Stind_R4  // 0x0
  public    static  IFix.Core.Code                  Ldind_U2  // 0x0
  public    static  IFix.Core.Code                  Ble_Un  // 0x0
  public    static  IFix.Core.Code                  Stind_I4  // 0x0
METHODS:
END_CLASS

CLASS: IFix.Core.Instruction
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            IFix.Core.Code                  Code  // 0x10
  public            System.Int32                    Operand  // 0x14
METHODS:
END_CLASS

CLASS: IFix.Core.ExceptionHandlerType
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.Core.ExceptionHandlerType  Catch  // 0x0
  public    static  IFix.Core.ExceptionHandlerType  Filter  // 0x0
  public    static  IFix.Core.ExceptionHandlerType  Finally  // 0x0
  public    static  IFix.Core.ExceptionHandlerType  Fault  // 0x0
METHODS:
END_CLASS

CLASS: IFix.Core.ExceptionHandler
TYPE:  class
TOKEN: 0x200000A
FIELDS:
  public            System.Type                     CatchType  // 0x10
  public            System.Int32                    CatchTypeId  // 0x18
  public            System.Int32                    HandlerEnd  // 0x1C
  public            System.Int32                    HandlerStart  // 0x20
  public            IFix.Core.ExceptionHandlerType  HandlerType  // 0x24
  public            System.Int32                    TryEnd  // 0x28
  public            System.Int32                    TryStart  // 0x2C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: IFix.Core.AnonymousStorey
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  private           IFix.Core.Value[]               unmanagedFields  // 0x10
  private           System.Object[]                 managedFields  // 0x18
  private           System.Int32                    typeId  // 0x20
  protected         IFix.Core.VirtualMachine        virtualMachine  // 0x28
  private           System.Int32                    equalMethodId  // 0x30
  private           System.Int32                    finalizeMethodId  // 0x34
  private           System.Int32                    getHashCodeMethodId  // 0x38
  private           System.Int32                    toStringMethodId  // 0x3C
METHODS:
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeID, System.Int32[] vTable, IFix.Core.VirtualMachine virtualMachine)
  System.Void Ldfld(System.Int32 fieldIndex, IFix.Core.Value* evaluationStackBase, IFix.Core.Value* evaluationStackPointer, System.Object[] managedStack)
  System.Void Stfld(System.Int32 fieldIndex, IFix.Core.Value* evaluationStackBase, IFix.Core.Value* evaluationStackPointer, System.Object[] managedStack)
  System.Object Get(System.Int32 fieldIndex, System.Type type, IFix.Core.VirtualMachine virtualMachine, System.Boolean valueTypeClone)
  System.Void Set(System.Int32 fieldIndex, System.Object obj, System.Type type, IFix.Core.VirtualMachine virtualMachine)
  System.Boolean ObjectEquals(System.Object obj)
  System.Boolean Equals(System.Object obj)
  System.Int32 ObjectGetHashCode()
  System.Int32 GetHashCode()
  System.String ObjectToString()
  System.String ToString()
  System.Void Finalize()
END_CLASS

CLASS: IFix.Core.AnonymousStoreyInfo
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    FieldNum  // 0x10
  public            System.Int32[]                  FieldTypes  // 0x18
  public            System.Int32                    CtorId  // 0x20
  public            System.Int32                    CtorParamNum  // 0x24
  public            System.Int32[]                  Slots  // 0x28
  public            System.Int32[]                  VTable  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: IFix.Core.ValueType
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.Core.ValueType             Integer  // 0x0
  public    static  IFix.Core.ValueType             Long  // 0x0
  public    static  IFix.Core.ValueType             Float  // 0x0
  public    static  IFix.Core.ValueType             Double  // 0x0
  public    static  IFix.Core.ValueType             StackReference  // 0x0
  public    static  IFix.Core.ValueType             StaticFieldReference  // 0x0
  public    static  IFix.Core.ValueType             FieldReference  // 0x0
  public    static  IFix.Core.ValueType             ChainFieldReference  // 0x0
  public    static  IFix.Core.ValueType             Object  // 0x0
  public    static  IFix.Core.ValueType             ValueType  // 0x0
  public    static  IFix.Core.ValueType             ArrayReference  // 0x0
METHODS:
END_CLASS

CLASS: IFix.Core.Value
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            IFix.Core.ValueType             Type  // 0x10
  public            System.Int32                    Value1  // 0x14
  public            System.Int32                    Value2  // 0x18
METHODS:
END_CLASS

CLASS: IFix.Core.GenericDelegateFactory
TYPE:  class
TOKEN: 0x200000F
FIELDS:
  private   static  System.Reflection.MethodInfo[]  genericAction  // 0x0
  private   static  System.Reflection.MethodInfo[]  genericFunc  // 0x8
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Func<IFix.Core.GenericDelegate,System.Delegate>>genericDelegateCreatorCache  // 0x10
  private   static  System.Func<System.Reflection.MethodInfo,System.Boolean><>f__am$cache0  // 0x18
  private   static  System.Func<System.Reflection.MethodInfo,System.Int32><>f__am$cache1  // 0x20
  private   static  System.Func<System.Reflection.MethodInfo,System.Boolean><>f__am$cache2  // 0x28
  private   static  System.Func<System.Reflection.MethodInfo,System.Int32><>f__am$cache3  // 0x30
  private   static  System.Func<System.Reflection.ParameterInfo,System.Boolean><>f__am$cache4  // 0x38
  private   static  System.Func<IFix.Core.GenericDelegate,System.Delegate><>f__am$cache5  // 0x40
  private   static  System.Func<System.Reflection.ParameterInfo,System.Type><>f__am$cache6  // 0x48
METHODS:
  System.Void PreventStripping(System.Object obj)
  System.Delegate Create(System.Type delegateType, IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.Void .cctor()
  System.Boolean <Create>m__0(System.Reflection.MethodInfo m)
  System.Int32 <Create>m__1(System.Reflection.MethodInfo m)
  System.Boolean <Create>m__2(System.Reflection.MethodInfo m)
  System.Int32 <Create>m__3(System.Reflection.MethodInfo m)
  System.Boolean <Create>m__4(System.Reflection.ParameterInfo p)
  System.Delegate <Create>m__5(IFix.Core.GenericDelegate x)
  System.Type <Create>m__6(System.Reflection.ParameterInfo pinfo)
END_CLASS

CLASS: IFix.Core.GenericDelegate
TYPE:  class
TOKEN: 0x2000013
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  private           System.Boolean                  pushSelf  // 0x28
  private           System.Int32                    extraArgNum  // 0x2C
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.Void Action()
  System.Void Action(T1 p1)
  System.Void Action(T1 p1, T2 p2)
  System.Void Action(T1 p1, T2 p2, T3 p3)
  System.Void Action(T1 p1, T2 p2, T3 p3, T4 p4)
  TResult Func()
  TResult Func(T1 p1)
  TResult Func(T1 p1, T2 p2)
  TResult Func(T1 p1, T2 p2, T3 p3)
  TResult Func(T1 p1, T2 p2, T3 p3, T4 p4)
END_CLASS

CLASS: IFix.Core.ObjectClone
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  private           System.Reflection.MethodInfo    memberwiseClone  // 0x10
METHODS:
  System.Void .ctor()
  System.Object Clone(System.Object obj)
END_CLASS

CLASS: IFix.Core.ReflectionMethodInvoker
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  private           System.Int32                    paramCount  // 0x10
  private           System.Boolean                  hasThis  // 0x14
  private           System.Boolean                  hasReturn  // 0x15
  private           System.Boolean[]                refFlags  // 0x18
  private           System.Boolean[]                outFlags  // 0x20
  private           System.Type[]                   rawTypes  // 0x28
  private           System.Reflection.MethodBase    method  // 0x30
  private           System.Reflection.ConstructorInfoctor  // 0x38
  private           System.Type                     returnType  // 0x40
  private           System.Boolean                  isNullableHasValue  // 0x48
  private           System.Boolean                  isNullableValue  // 0x49
METHODS:
  System.Void .ctor(System.Reflection.MethodBase method)
  System.Void Invoke(IFix.Core.VirtualMachine virtualMachine, IFix.Core.Call& call, System.Boolean isInstantiate)
END_CLASS

CLASS: IFix.Core.UnmanagedStack
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            IFix.Core.Value*                Base  // 0x10
  public            IFix.Core.Value*                Top  // 0x18
METHODS:
END_CLASS

CLASS: IFix.Core.ThreadStackInfo
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  public            IFix.Core.UnmanagedStack*       UnmanagedStack  // 0x10
  public            System.Object[]                 ManagedStack  // 0x18
  private           System.IntPtr                   evaluationStackHandler  // 0x20
  private           System.IntPtr                   unmanagedStackHandler  // 0x28
  private   static  System.LocalDataStoreSlot       localSlot  // 0x0
METHODS:
  System.Void .ctor()
  IFix.Core.ThreadStackInfo get_Stack()
  System.Void .cctor()
END_CLASS

CLASS: IFix.Core.EvaluationStackOperation
TYPE:  class
TOKEN: 0x200001A
FIELDS:
METHODS:
  System.Void UnboxPrimitive(IFix.Core.Value* evaluationStackPointer, System.Object obj, System.Type type)
  System.Object mGet(System.Boolean isArray, System.Object root, System.Int32 layer, System.Int32[] fieldIdList, System.Reflection.FieldInfo[] fieldInfos, System.Collections.Generic.Dictionary<System.Int32,IFix.Core.NewFieldInfo> newFieldInfos)
  System.Void mSet(System.Boolean isArray, System.Object root, System.Object val, System.Int32 layer, System.Int32[] fieldIdList, System.Reflection.FieldInfo[] fieldInfos, System.Collections.Generic.Dictionary<System.Int32,IFix.Core.NewFieldInfo> newFieldInfos)
  System.Object ToObject(IFix.Core.Value* evaluationStackBase, IFix.Core.Value* evaluationStackPointer, System.Object[] managedStack, System.Type type, IFix.Core.VirtualMachine virtualMachine, System.Boolean valueTypeClone)
  System.Void PushObject(IFix.Core.Value* evaluationStackBase, IFix.Core.Value* evaluationStackPointer, System.Object[] managedStack, System.Object obj, System.Type type)
  System.Void UpdateReference(IFix.Core.Value* evaluationStackBase, IFix.Core.Value* evaluationStackPointer, System.Object[] managedStack, System.Object obj, IFix.Core.VirtualMachine virtualMachine, System.Type type)
END_CLASS

CLASS: IFix.Core.Call
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  private           IFix.Core.Value*                argumentBase  // 0x10
  private           IFix.Core.Value*                evaluationStackBase  // 0x18
  private           System.Object[]                 managedStack  // 0x20
  private           IFix.Core.Value*                currentTop  // 0x28
  private           IFix.Core.Value**               topWriteBack  // 0x30
METHODS:
  IFix.Core.Call Begin()
  IFix.Core.Call BeginForStack(IFix.Core.ThreadStackInfo stack)
  System.Void PushBoolean(System.Boolean b)
  System.Boolean GetBoolean(System.Int32 offset)
  System.Void PushByte(System.Byte b)
  System.Byte GetByte(System.Int32 offset)
  System.SByte GetSByte(System.Int32 offset)
  System.Void PushInt16(System.Int16 s)
  System.Int16 GetInt16(System.Int32 offset)
  System.Void PushChar(System.Char c)
  System.Char GetChar(System.Int32 offset)
  System.Void PushUInt16(System.UInt16 us)
  System.UInt16 GetUInt16(System.Int32 offset)
  System.Void PushInt32(System.Int32 i)
  System.Int32 GetInt32(System.Int32 offset)
  System.Void PushUInt32(System.UInt32 ui)
  System.UInt32 GetUInt32(System.Int32 offset)
  System.Void PushInt64(System.Int64 i)
  System.Int64 GetInt64(System.Int32 offset)
  System.Void PushUInt64(System.UInt64 i)
  System.UInt64 GetUInt64(System.Int32 offset)
  System.Void PushSingle(System.Single f)
  System.Single GetSingle(System.Int32 offset)
  System.Void PushDouble(System.Double d)
  System.Double GetDouble(System.Int32 offset)
  System.Void PushIntPtr(System.IntPtr i)
  System.IntPtr GetIntPtr(System.Int32 offset)
  System.Void PushObject(System.Object o)
  System.Void PushValueType(System.Object o)
  System.Object GetObject(System.Int32 offset)
  T GetAsType(System.Int32 offset)
  System.Void PushObjectAsResult(System.Object obj, System.Type type)
  System.Void PushRef(System.Int32 offset)
  System.Void UpdateReference(System.Int32 offset, System.Object obj, IFix.Core.VirtualMachine virtualMachine, System.Type type)
END_CLASS

CLASS: IFix.Core.Utils
TYPE:  class
TOKEN: 0x200001D
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Reflection.MethodInfo>delegateAdptCache  // 0x0
METHODS:
  System.Boolean IsAssignable(System.Reflection.MethodInfo delegateMethod, System.Reflection.MethodInfo method)
  System.Delegate TryAdapterToDelegate(System.Object obj, System.Type delegateType, System.String perfix)
  System.Void .cctor()
END_CLASS

CLASS: IFix.Core.RuntimeException
TYPE:  class
TOKEN: 0x200001E
EXTENDS: Exception
FIELDS:
  private           System.Exception                <Real>k__BackingField  // 0x90
METHODS:
  System.Void .ctor()
  System.Exception get_Real()
  System.Void set_Real(System.Exception value)
END_CLASS

CLASS: IFix.Core.ExternInvoker
TYPE:  class
TOKEN: 0x200001F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(IFix.Core.VirtualMachine vm, IFix.Core.Call& call, System.Boolean isInstantiate)
END_CLASS

CLASS: IFix.Core.FieldAddr
TYPE:  class
TOKEN: 0x2000020
FIELDS:
  public            System.Object                   Object  // 0x10
  public            System.Int32[]                  FieldIdList  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: IFix.Core.Cleanner
TYPE:  class
TOKEN: 0x2000021
FIELDS:
  private   static  System.Boolean                  start  // 0x0
METHODS:
  System.Void .ctor()
  System.Void Start()
  System.Void Stop()
  System.Void Finalize()
END_CLASS

CLASS: IFix.Core.NewFieldInfo
TYPE:  class
TOKEN: 0x2000022
FIELDS:
  public            System.String                   Name  // 0x10
  public            System.Type                     DeclaringType  // 0x18
  public            System.Type                     FieldType  // 0x20
  public            System.Int32                    MethodId  // 0x28
  private   static readonly System.Int32                    staticObjectKey  // 0x0
  private   static readonly IFix.Core.ThreadStackInfo       stack  // 0x8
  private   static readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.String,System.Object>>newFieldValues  // 0x10
  private   static readonly System.Collections.Generic.Dictionary<System.Int32,System.WeakReference>objList  // 0x18
METHODS:
  System.Void .ctor()
  System.Object SetDefaultValue(System.Object obj)
  System.Void Sweep()
  System.Void CheckInit(IFix.Core.VirtualMachine virtualMachine, System.Object obj)
  System.Int32 ObjectToIndex(System.Object obj)
  System.Boolean HasInitialize(System.Object obj)
  System.Object GetValue(System.Object obj)
  System.Void SetValue(System.Object obj, System.Object value)
  System.Void .cctor()
END_CLASS

CLASS: IFix.Core.VirtualMachine
TYPE:  class
TOKEN: 0x2000023
FIELDS:
  private           IFix.Core.ObjectClone           objectClone  // 0x10
  private           IFix.Core.Instruction**         unmanagedCodes  // 0x18
  private           IFix.Core.ExceptionHandler[][]  exceptionHandlers  // 0x20
  private           System.Action                   onDispose  // 0x28
  private           IFix.Core.ExternInvoker[]       externInvokers  // 0x30
  private           System.Collections.Generic.Dictionary<System.Reflection.MethodBase,IFix.Core.VirtualMachine.CalliInvokerInfo>calliInvokerCache  // 0x38
  private           System.Reflection.MethodBase[]  externMethods  // 0x40
  private           System.Type[]                   externTypes  // 0x48
  private           System.String[]                 internStrings  // 0x50
  private           System.Reflection.FieldInfo[]   fieldInfos  // 0x58
  private           System.Collections.Generic.Dictionary<System.Int32,IFix.Core.NewFieldInfo>newFieldInfos  // 0x60
  private           IFix.Core.AnonymousStoreyInfo[] anonymousStoreyInfos  // 0x68
  private           System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.Reflection.MethodInfo,System.Reflection.MethodInfo>>overrideCache  // 0x70
  private           System.Type[]                   staticFieldTypes  // 0x78
  private           System.Object[]                 staticFields  // 0x80
  private           System.Int32[]                  cctors  // 0x88
  private           IFix.Core.WrappersManager       wrappersManager  // 0x90
  public    static  System.Action<System.String>    Info  // 0x0
  private   static  System.Action<System.String>    <>f__mg$cache0  // 0x8
METHODS:
  System.Void .ctor(IFix.Core.Instruction** unmanaged_codes, System.Action on_dispose)
  System.Void set_ExceptionHandlers(IFix.Core.ExceptionHandler[][] value)
  System.Type[] get_ExternTypes()
  System.Void set_ExternTypes(System.Type[] value)
  System.Void set_ExternMethods(System.Reflection.MethodBase[] value)
  System.Void set_InternStrings(System.String[] value)
  System.Void set_FieldInfos(System.Reflection.FieldInfo[] value)
  System.Void set_NewFieldInfos(System.Collections.Generic.Dictionary<System.Int32,IFix.Core.NewFieldInfo> value)
  System.Void set_AnonymousStoreyInfos(IFix.Core.AnonymousStoreyInfo[] value)
  System.Void set_StaticFieldTypes(System.Type[] value)
  System.Void set_Cctors(System.Int32[] value)
  IFix.Core.WrappersManager get_WrappersManager()
  System.Void set_WrappersManager(IFix.Core.WrappersManager value)
  System.Void Finalize()
  System.Void checkCctorExecute(System.Int32 fieldId, IFix.Core.Value* argumentBase, System.Object[] managedStack, IFix.Core.Value* evaluationStackBase)
  System.Void store(IFix.Core.Value* stackBase, IFix.Core.Value* dst, IFix.Core.Value* src, System.Object[] managedStack)
  System.Void copy(IFix.Core.Value* stackBase, IFix.Core.Value* dst, IFix.Core.Value* src, System.Object[] managedStack)
  System.Void resolveStackReference(IFix.Core.Value* value, IFix.Core.Value* stackBase, System.Object[] managedStack)
  System.Byte* stackReferenceToPointer(IFix.Core.Value* value)
  System.Boolean tryConvertStackReferenceToPointer(IFix.Core.Value* value)
  System.Byte* pointerValueToAddress(IFix.Core.Value* value, System.Object[] managedStack)
  System.Int64 valueToInt64(IFix.Core.Value* value)
  System.Single valueToFloat(IFix.Core.Value* value)
  System.Double valueToDouble(IFix.Core.Value* value)
  System.Void storeToRawPointer(System.Byte* destination, IFix.Core.Value* src, IFix.Core.Code code)
  System.Void loadFromRawPointer(System.Byte* source, IFix.Core.Value* dest, IFix.Core.Code code)
  System.Void Execute(System.Int32 methodIndex, IFix.Core.Call& call, System.Int32 argsCount, System.Int32 refCount)
  IFix.Core.Value* Execute(System.Int32 methodIndex, IFix.Core.Value* argumentBase, System.Object[] managedStack, IFix.Core.Value* evaluationStackBase, System.Int32 argsCount)
  System.Void throwRuntimeException(System.Exception e, System.Boolean bWrap)
  IFix.Core.ExceptionHandler getExceptionHandler(System.Int32 methodIndex, System.Type exceptionType, System.Int32 pc)
  System.Void arrayGet(System.Object obj, System.Int32 idx, IFix.Core.Value* val, System.Object[] managedStack, IFix.Core.Value* evaluationStackBase)
  System.Void arraySet(System.Object obj, System.Int32 idx, IFix.Core.Value* val, System.Object[] managedStack, IFix.Core.Value* evaluationStackBase)
  System.Void _Info(System.String a)
  IFix.Core.Value* Execute(IFix.Core.Instruction* pc, IFix.Core.Value* argumentBase, System.Object[] managedStack, IFix.Core.Value* evaluationStackBase, System.Int32 argsCount, System.Int32 methodIndex, System.Int32 refCount, IFix.Core.Value** topWriteBack)
  System.Void .cctor()
END_CLASS

CLASS: IFix.Core.WrappersManager
TYPE:  interface
TOKEN: 0x2000025
FIELDS:
METHODS:
  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
  System.Object CreateWrapper(System.Int32 id)
  System.Object InitWrapperArray(System.Int32 len)
END_CLASS

CLASS: Unity.IL2CPP.CompilerServices.Option
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Unity.IL2CPP.CompilerServices.OptionNullChecks  // 0x0
  public    static  Unity.IL2CPP.CompilerServices.OptionArrayBoundsChecks  // 0x0
  public    static  Unity.IL2CPP.CompilerServices.OptionDivideByZeroChecks  // 0x0
METHODS:
END_CLASS

CLASS: Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute
TYPE:  class
TOKEN: 0x2000015
EXTENDS: Attribute
FIELDS:
  private           Unity.IL2CPP.CompilerServices.Option<Option>k__BackingField  // 0x10
  private           System.Object                   <Value>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(Unity.IL2CPP.CompilerServices.Option option, System.Object value)
  System.Void set_Option(Unity.IL2CPP.CompilerServices.Option value)
  System.Void set_Value(System.Object value)
END_CLASS

