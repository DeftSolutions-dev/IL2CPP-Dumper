// ========================================================
// Dumped by @desirepro
// Assembly: IFix.Core.dll
// Classes:  37
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000024
    public class CalliInvokerInfo
    {
        // Fields
        public IFix.Core.ExternInvoker Invoker;        // 0x10
        public System.Int32 ArgumentCount;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

namespace IFix
{

    // TypeToken: 0x200001C
    public class CustomBridgeAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace IFix.Core
{

    // TypeToken: 0x2000002
    public class IDTagAttribute : Attribute
    {
        // Fields
        public System.Int32 ID;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 id) { }

    }

    // TypeToken: 0x2000003
    public class PatchManager
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Reflection.Assembly,System.Action> removers;        // 0x0
        private static System.Func<System.Reflection.ParameterInfo,System.Type> <>f__am$cache0;        // 0x8

        // Methods
        private System.Reflection.MethodBase readMethod(System.IO.BinaryReader reader, System.Type[] externTypes) { }
        private System.Int32 getMapId(System.Collections.Generic.List<System.Type> idMapArray, System.Reflection.MethodBase method) { }
        private System.Int32[] readSlotInfo(System.IO.BinaryReader reader, System.Collections.Generic.Dictionary<System.Reflection.MethodInfo,System.Int32> itfMethodToId, System.Type[] externTypes, System.Int32 maxId) { }
        private IFix.Core.VirtualMachine Load(System.IO.Stream stream, System.Boolean checkNew) { }
        private System.Void Unload(System.Reflection.Assembly assembly) { }
        private System.Void .cctor() { }
        private System.Type <readMethod>m__0(System.Reflection.ParameterInfo p) { }

    }

    // TypeToken: 0x2000007
    public struct Code
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.Core.Code Blt_Un;        // 0x0
        public static IFix.Core.Code Ldind_U1;        // 0x0
        public static IFix.Core.Code Stelem_Any;        // 0x0
        public static IFix.Core.Code Ldelem_I;        // 0x0
        public static IFix.Core.Code Endfinally;        // 0x0
        public static IFix.Core.Code Arglist;        // 0x0
        public static IFix.Core.Code Shl;        // 0x0
        public static IFix.Core.Code Conv_Ovf_I4;        // 0x0
        public static IFix.Core.Code Stloc;        // 0x0
        public static IFix.Core.Code Refanytype;        // 0x0
        public static IFix.Core.Code Callvirt;        // 0x0
        public static IFix.Core.Code Ldelem_R8;        // 0x0
        public static IFix.Core.Code Unaligned;        // 0x0
        public static IFix.Core.Code Conv_I2;        // 0x0
        public static IFix.Core.Code Ldfld;        // 0x0
        public static IFix.Core.Code Sizeof;        // 0x0
        public static IFix.Core.Code Newanon;        // 0x0
        public static IFix.Core.Code Sub;        // 0x0
        public static IFix.Core.Code Conv_Ovf_U2;        // 0x0
        public static IFix.Core.Code Cgt_Un;        // 0x0
        public static IFix.Core.Code Call;        // 0x0
        public static IFix.Core.Code Stind_R8;        // 0x0
        public static IFix.Core.Code Conv_Ovf_I8;        // 0x0
        public static IFix.Core.Code Readonly;        // 0x0
        public static IFix.Core.Code Newobj;        // 0x0
        public static IFix.Core.Code Shr_Un;        // 0x0
        public static IFix.Core.Code Ldvirtftn;        // 0x0
        public static IFix.Core.Code Jmp;        // 0x0
        public static IFix.Core.Code Cgt;        // 0x0
        public static IFix.Core.Code Ldtoken;        // 0x0
        public static IFix.Core.Code Conv_Ovf_U;        // 0x0
        public static IFix.Core.Code Ldind_Ref;        // 0x0
        public static IFix.Core.Code Conv_Ovf_I_Un;        // 0x0
        public static IFix.Core.Code Conv_I1;        // 0x0
        public static IFix.Core.Code Ldloc;        // 0x0
        public static IFix.Core.Code Ldind_R8;        // 0x0
        public static IFix.Core.Code Ldind_U4;        // 0x0
        public static IFix.Core.Code Ldlen;        // 0x0
        public static IFix.Core.Code Rem_Un;        // 0x0
        public static IFix.Core.Code Starg;        // 0x0
        public static IFix.Core.Code Calli;        // 0x0
        public static IFix.Core.Code Conv_Ovf_U1_Un;        // 0x0
        public static IFix.Core.Code Add;        // 0x0
        public static IFix.Core.Code Switch;        // 0x0
        public static IFix.Core.Code CallExtern;        // 0x0
        public static IFix.Core.Code Ldelem_I8;        // 0x0
        public static IFix.Core.Code Ldelema;        // 0x0
        public static IFix.Core.Code Div;        // 0x0
        public static IFix.Core.Code Br;        // 0x0
        public static IFix.Core.Code Ret;        // 0x0
        public static IFix.Core.Code Ldind_I4;        // 0x0
        public static IFix.Core.Code Clt;        // 0x0
        public static IFix.Core.Code Conv_I4;        // 0x0
        public static IFix.Core.Code Ceq;        // 0x0
        public static IFix.Core.Code Conv_U;        // 0x0
        public static IFix.Core.Code Initobj;        // 0x0
        public static IFix.Core.Code Stelem_Ref;        // 0x0
        public static IFix.Core.Code Mul_Ovf_Un;        // 0x0
        public static IFix.Core.Code Ldstr;        // 0x0
        public static IFix.Core.Code Mul_Ovf;        // 0x0
        public static IFix.Core.Code Sub_Ovf;        // 0x0
        public static IFix.Core.Code Ldelem_U1;        // 0x0
        public static IFix.Core.Code Conv_I;        // 0x0
        public static IFix.Core.Code Conv_U4;        // 0x0
        public static IFix.Core.Code Blt;        // 0x0
        public static IFix.Core.Code Conv_Ovf_I;        // 0x0
        public static IFix.Core.Code No;        // 0x0
        public static IFix.Core.Code Brtrue;        // 0x0
        public static IFix.Core.Code Unbox_Any;        // 0x0
        public static IFix.Core.Code Not;        // 0x0
        public static IFix.Core.Code Neg;        // 0x0
        public static IFix.Core.Code Ldind_I8;        // 0x0
        public static IFix.Core.Code Stind_Ref;        // 0x0
        public static IFix.Core.Code Conv_R4;        // 0x0
        public static IFix.Core.Code Conv_Ovf_U4;        // 0x0
        public static IFix.Core.Code Conv_Ovf_U8;        // 0x0
        public static IFix.Core.Code Ldind_I;        // 0x0
        public static IFix.Core.Code Tail;        // 0x0
        public static IFix.Core.Code Initblk;        // 0x0
        public static IFix.Core.Code Conv_Ovf_U8_Un;        // 0x0
        public static IFix.Core.Code Shr;        // 0x0
        public static IFix.Core.Code Callvirtvirt;        // 0x0
        public static IFix.Core.Code StackSpace;        // 0x0
        public static IFix.Core.Code Ldsflda;        // 0x0
        public static IFix.Core.Code Ble;        // 0x0
        public static IFix.Core.Code Ldloca;        // 0x0
        public static IFix.Core.Code Ldtype;        // 0x0
        public static IFix.Core.Code Conv_I8;        // 0x0
        public static IFix.Core.Code Conv_Ovf_U2_Un;        // 0x0
        public static IFix.Core.Code Add_Ovf;        // 0x0
        public static IFix.Core.Code Isinst;        // 0x0
        public static IFix.Core.Code Stobj;        // 0x0
        public static IFix.Core.Code Conv_Ovf_I1_Un;        // 0x0
        public static IFix.Core.Code Cpblk;        // 0x0
        public static IFix.Core.Code Pop;        // 0x0
        public static IFix.Core.Code And;        // 0x0
        public static IFix.Core.Code Box;        // 0x0
        public static IFix.Core.Code Mul;        // 0x0
        public static IFix.Core.Code Conv_U1;        // 0x0
        public static IFix.Core.Code Nop;        // 0x0
        public static IFix.Core.Code Conv_R_Un;        // 0x0
        public static IFix.Core.Code Ldarga;        // 0x0
        public static IFix.Core.Code Bgt;        // 0x0
        public static IFix.Core.Code Break;        // 0x0
        public static IFix.Core.Code Div_Un;        // 0x0
        public static IFix.Core.Code Ldc_I4;        // 0x0
        public static IFix.Core.Code Refanyval;        // 0x0
        public static IFix.Core.Code Conv_U8;        // 0x0
        public static IFix.Core.Code Bgt_Un;        // 0x0
        public static IFix.Core.Code Stelem_R8;        // 0x0
        public static IFix.Core.Code Bge;        // 0x0
        public static IFix.Core.Code Ldflda;        // 0x0
        public static IFix.Core.Code Ldelem_I1;        // 0x0
        public static IFix.Core.Code Localloc;        // 0x0
        public static IFix.Core.Code Ldind_I1;        // 0x0
        public static IFix.Core.Code Ldelem_U4;        // 0x0
        public static IFix.Core.Code Volatile;        // 0x0
        public static IFix.Core.Code Ldarg;        // 0x0
        public static IFix.Core.Code Ldftn;        // 0x0
        public static IFix.Core.Code Xor;        // 0x0
        public static IFix.Core.Code Conv_Ovf_I2;        // 0x0
        public static IFix.Core.Code Conv_Ovf_U_Un;        // 0x0
        public static IFix.Core.Code Stind_I2;        // 0x0
        public static IFix.Core.Code Ldc_R4;        // 0x0
        public static IFix.Core.Code Stelem_I2;        // 0x0
        public static IFix.Core.Code Or;        // 0x0
        public static IFix.Core.Code Castclass;        // 0x0
        public static IFix.Core.Code Newarr;        // 0x0
        public static IFix.Core.Code Throw;        // 0x0
        public static IFix.Core.Code Conv_U2;        // 0x0
        public static IFix.Core.Code Clt_Un;        // 0x0
        public static IFix.Core.Code Conv_Ovf_U4_Un;        // 0x0
        public static IFix.Core.Code Dup;        // 0x0
        public static IFix.Core.Code Ldvirtftn2;        // 0x0
        public static IFix.Core.Code Add_Ovf_Un;        // 0x0
        public static IFix.Core.Code Ldc_R8;        // 0x0
        public static IFix.Core.Code Ldelem_Any;        // 0x0
        public static IFix.Core.Code Sub_Ovf_Un;        // 0x0
        public static IFix.Core.Code Brfalse;        // 0x0
        public static IFix.Core.Code Conv_R8;        // 0x0
        public static IFix.Core.Code Unbox;        // 0x0
        public static IFix.Core.Code Endfilter;        // 0x0
        public static IFix.Core.Code Rethrow;        // 0x0
        public static IFix.Core.Code Rem;        // 0x0
        public static IFix.Core.Code Ldnull;        // 0x0
        public static IFix.Core.Code Conv_Ovf_U1;        // 0x0
        public static IFix.Core.Code Stfld;        // 0x0
        public static IFix.Core.Code Stelem_I;        // 0x0
        public static IFix.Core.Code Mkrefany;        // 0x0
        public static IFix.Core.Code Stelem_R4;        // 0x0
        public static IFix.Core.Code Ldc_I8;        // 0x0
        public static IFix.Core.Code Cpobj;        // 0x0
        public static IFix.Core.Code Stind_I8;        // 0x0
        public static IFix.Core.Code Bne_Un;        // 0x0
        public static IFix.Core.Code Constrained;        // 0x0
        public static IFix.Core.Code Stelem_I1;        // 0x0
        public static IFix.Core.Code Beq;        // 0x0
        public static IFix.Core.Code Bge_Un;        // 0x0
        public static IFix.Core.Code Ldind_I2;        // 0x0
        public static IFix.Core.Code Ldelem_I2;        // 0x0
        public static IFix.Core.Code Conv_Ovf_I8_Un;        // 0x0
        public static IFix.Core.Code Conv_Ovf_I1;        // 0x0
        public static IFix.Core.Code Ldobj;        // 0x0
        public static IFix.Core.Code Leave;        // 0x0
        public static IFix.Core.Code Stind_I;        // 0x0
        public static IFix.Core.Code Stind_I1;        // 0x0
        public static IFix.Core.Code Ldelem_R4;        // 0x0
        public static IFix.Core.Code Conv_Ovf_I4_Un;        // 0x0
        public static IFix.Core.Code Ldelem_I4;        // 0x0
        public static IFix.Core.Code Ldind_R4;        // 0x0
        public static IFix.Core.Code Ckfinite;        // 0x0
        public static IFix.Core.Code Ldelem_Ref;        // 0x0
        public static IFix.Core.Code Stsfld;        // 0x0
        public static IFix.Core.Code Ldsfld;        // 0x0
        public static IFix.Core.Code Stelem_I8;        // 0x0
        public static IFix.Core.Code Stelem_I4;        // 0x0
        public static IFix.Core.Code Ldelem_U2;        // 0x0
        public static IFix.Core.Code Conv_Ovf_I2_Un;        // 0x0
        public static IFix.Core.Code Stind_R4;        // 0x0
        public static IFix.Core.Code Ldind_U2;        // 0x0
        public static IFix.Core.Code Ble_Un;        // 0x0
        public static IFix.Core.Code Stind_I4;        // 0x0

    }

    // TypeToken: 0x2000008
    public struct Instruction
    {
        // Fields
        public IFix.Core.Code Code;        // 0x10
        public System.Int32 Operand;        // 0x14

    }

    // TypeToken: 0x2000009
    public struct ExceptionHandlerType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.Core.ExceptionHandlerType Catch;        // 0x0
        public static IFix.Core.ExceptionHandlerType Filter;        // 0x0
        public static IFix.Core.ExceptionHandlerType Finally;        // 0x0
        public static IFix.Core.ExceptionHandlerType Fault;        // 0x0

    }

    // TypeToken: 0x200000A
    public class ExceptionHandler
    {
        // Fields
        public System.Type CatchType;        // 0x10
        public System.Int32 CatchTypeId;        // 0x18
        public System.Int32 HandlerEnd;        // 0x1C
        public System.Int32 HandlerStart;        // 0x20
        public IFix.Core.ExceptionHandlerType HandlerType;        // 0x24
        public System.Int32 TryEnd;        // 0x28
        public System.Int32 TryStart;        // 0x2C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public class AnonymousStorey
    {
        // Fields
        private IFix.Core.Value[] unmanagedFields;        // 0x10
        private System.Object[] managedFields;        // 0x18
        private System.Int32 typeId;        // 0x20
        protected IFix.Core.VirtualMachine virtualMachine;        // 0x28
        private System.Int32 equalMethodId;        // 0x30
        private System.Int32 finalizeMethodId;        // 0x34
        private System.Int32 getHashCodeMethodId;        // 0x38
        private System.Int32 toStringMethodId;        // 0x3C

        // Methods
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeID, System.Int32[] vTable, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void Ldfld(System.Int32 fieldIndex, IFix.Core.Value* evaluationStackBase, IFix.Core.Value* evaluationStackPointer, System.Object[] managedStack) { }
        private System.Void Stfld(System.Int32 fieldIndex, IFix.Core.Value* evaluationStackBase, IFix.Core.Value* evaluationStackPointer, System.Object[] managedStack) { }
        private System.Object Get(System.Int32 fieldIndex, System.Type type, IFix.Core.VirtualMachine virtualMachine, System.Boolean valueTypeClone) { }
        private System.Void Set(System.Int32 fieldIndex, System.Object obj, System.Type type, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Boolean ObjectEquals(System.Object obj) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 ObjectGetHashCode() { }
        private System.Int32 GetHashCode() { }
        private System.String ObjectToString() { }
        private System.String ToString() { }
        private System.Void Finalize() { }

    }

    // TypeToken: 0x200000C
    public class AnonymousStoreyInfo
    {
        // Fields
        public System.Int32 FieldNum;        // 0x10
        public System.Int32[] FieldTypes;        // 0x18
        public System.Int32 CtorId;        // 0x20
        public System.Int32 CtorParamNum;        // 0x24
        public System.Int32[] Slots;        // 0x28
        public System.Int32[] VTable;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000D
    public struct ValueType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.Core.ValueType Integer;        // 0x0
        public static IFix.Core.ValueType Long;        // 0x0
        public static IFix.Core.ValueType Float;        // 0x0
        public static IFix.Core.ValueType Double;        // 0x0
        public static IFix.Core.ValueType StackReference;        // 0x0
        public static IFix.Core.ValueType StaticFieldReference;        // 0x0
        public static IFix.Core.ValueType FieldReference;        // 0x0
        public static IFix.Core.ValueType ChainFieldReference;        // 0x0
        public static IFix.Core.ValueType Object;        // 0x0
        public static IFix.Core.ValueType ValueType;        // 0x0
        public static IFix.Core.ValueType ArrayReference;        // 0x0

    }

    // TypeToken: 0x200000E
    public struct Value
    {
        // Fields
        public IFix.Core.ValueType Type;        // 0x10
        public System.Int32 Value1;        // 0x14
        public System.Int32 Value2;        // 0x18

    }

    // TypeToken: 0x200000F
    public class GenericDelegateFactory
    {
        // Fields
        private static System.Reflection.MethodInfo[] genericAction;        // 0x0
        private static System.Reflection.MethodInfo[] genericFunc;        // 0x8
        private static System.Collections.Generic.Dictionary<System.Type,System.Func<IFix.Core.GenericDelegate,System.Delegate>> genericDelegateCreatorCache;        // 0x10
        private static System.Func<System.Reflection.MethodInfo,System.Boolean> <>f__am$cache0;        // 0x18
        private static System.Func<System.Reflection.MethodInfo,System.Int32> <>f__am$cache1;        // 0x20
        private static System.Func<System.Reflection.MethodInfo,System.Boolean> <>f__am$cache2;        // 0x28
        private static System.Func<System.Reflection.MethodInfo,System.Int32> <>f__am$cache3;        // 0x30
        private static System.Func<System.Reflection.ParameterInfo,System.Boolean> <>f__am$cache4;        // 0x38
        private static System.Func<IFix.Core.GenericDelegate,System.Delegate> <>f__am$cache5;        // 0x40
        private static System.Func<System.Reflection.ParameterInfo,System.Type> <>f__am$cache6;        // 0x48

        // Methods
        private System.Void PreventStripping(System.Object obj) { }
        private System.Delegate Create(System.Type delegateType, IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.Void .cctor() { }
        private System.Boolean <Create>m__0(System.Reflection.MethodInfo m) { }
        private System.Int32 <Create>m__1(System.Reflection.MethodInfo m) { }
        private System.Boolean <Create>m__2(System.Reflection.MethodInfo m) { }
        private System.Int32 <Create>m__3(System.Reflection.MethodInfo m) { }
        private System.Boolean <Create>m__4(System.Reflection.ParameterInfo p) { }
        private System.Delegate <Create>m__5(IFix.Core.GenericDelegate x) { }
        private System.Type <Create>m__6(System.Reflection.ParameterInfo pinfo) { }

    }

    // TypeToken: 0x2000013
    public class GenericDelegate
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        private System.Boolean pushSelf;        // 0x28
        private System.Int32 extraArgNum;        // 0x2C

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.Void Action() { }
        private System.Void Action(T1 p1) { }
        private System.Void Action(T1 p1, T2 p2) { }
        private System.Void Action(T1 p1, T2 p2, T3 p3) { }
        private System.Void Action(T1 p1, T2 p2, T3 p3, T4 p4) { }
        private TResult Func() { }
        private TResult Func(T1 p1) { }
        private TResult Func(T1 p1, T2 p2) { }
        private TResult Func(T1 p1, T2 p2, T3 p3) { }
        private TResult Func(T1 p1, T2 p2, T3 p3, T4 p4) { }

    }

    // TypeToken: 0x2000016
    public class ObjectClone
    {
        // Fields
        private System.Reflection.MethodInfo memberwiseClone;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Object Clone(System.Object obj) { }

    }

    // TypeToken: 0x2000017
    public class ReflectionMethodInvoker
    {
        // Fields
        private System.Int32 paramCount;        // 0x10
        private System.Boolean hasThis;        // 0x14
        private System.Boolean hasReturn;        // 0x15
        private System.Boolean[] refFlags;        // 0x18
        private System.Boolean[] outFlags;        // 0x20
        private System.Type[] rawTypes;        // 0x28
        private System.Reflection.MethodBase method;        // 0x30
        private System.Reflection.ConstructorInfo ctor;        // 0x38
        private System.Type returnType;        // 0x40
        private System.Boolean isNullableHasValue;        // 0x48
        private System.Boolean isNullableValue;        // 0x49

        // Methods
        private System.Void .ctor(System.Reflection.MethodBase method) { }
        private System.Void Invoke(IFix.Core.VirtualMachine virtualMachine, IFix.Core.Call& call, System.Boolean isInstantiate) { }

    }

    // TypeToken: 0x2000018
    public struct UnmanagedStack
    {
        // Fields
        public IFix.Core.Value* Base;        // 0x10
        public IFix.Core.Value* Top;        // 0x18

    }

    // TypeToken: 0x2000019
    public class ThreadStackInfo
    {
        // Fields
        public IFix.Core.UnmanagedStack* UnmanagedStack;        // 0x10
        public System.Object[] ManagedStack;        // 0x18
        private System.IntPtr evaluationStackHandler;        // 0x20
        private System.IntPtr unmanagedStackHandler;        // 0x28
        private static System.LocalDataStoreSlot localSlot;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private IFix.Core.ThreadStackInfo get_Stack() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001A
    public class EvaluationStackOperation
    {
        // Methods
        private System.Void UnboxPrimitive(IFix.Core.Value* evaluationStackPointer, System.Object obj, System.Type type) { }
        private System.Object mGet(System.Boolean isArray, System.Object root, System.Int32 layer, System.Int32[] fieldIdList, System.Reflection.FieldInfo[] fieldInfos, System.Collections.Generic.Dictionary<System.Int32,IFix.Core.NewFieldInfo> newFieldInfos) { }
        private System.Void mSet(System.Boolean isArray, System.Object root, System.Object val, System.Int32 layer, System.Int32[] fieldIdList, System.Reflection.FieldInfo[] fieldInfos, System.Collections.Generic.Dictionary<System.Int32,IFix.Core.NewFieldInfo> newFieldInfos) { }
        private System.Object ToObject(IFix.Core.Value* evaluationStackBase, IFix.Core.Value* evaluationStackPointer, System.Object[] managedStack, System.Type type, IFix.Core.VirtualMachine virtualMachine, System.Boolean valueTypeClone) { }
        private System.Void PushObject(IFix.Core.Value* evaluationStackBase, IFix.Core.Value* evaluationStackPointer, System.Object[] managedStack, System.Object obj, System.Type type) { }
        private System.Void UpdateReference(IFix.Core.Value* evaluationStackBase, IFix.Core.Value* evaluationStackPointer, System.Object[] managedStack, System.Object obj, IFix.Core.VirtualMachine virtualMachine, System.Type type) { }

    }

    // TypeToken: 0x200001B
    public struct Call
    {
        // Fields
        private IFix.Core.Value* argumentBase;        // 0x10
        private IFix.Core.Value* evaluationStackBase;        // 0x18
        private System.Object[] managedStack;        // 0x20
        private IFix.Core.Value* currentTop;        // 0x28
        private IFix.Core.Value** topWriteBack;        // 0x30

        // Methods
        private IFix.Core.Call Begin() { }
        private IFix.Core.Call BeginForStack(IFix.Core.ThreadStackInfo stack) { }
        private System.Void PushBoolean(System.Boolean b) { }
        private System.Boolean GetBoolean(System.Int32 offset) { }
        private System.Void PushByte(System.Byte b) { }
        private System.Byte GetByte(System.Int32 offset) { }
        private System.SByte GetSByte(System.Int32 offset) { }
        private System.Void PushInt16(System.Int16 s) { }
        private System.Int16 GetInt16(System.Int32 offset) { }
        private System.Void PushChar(System.Char c) { }
        private System.Char GetChar(System.Int32 offset) { }
        private System.Void PushUInt16(System.UInt16 us) { }
        private System.UInt16 GetUInt16(System.Int32 offset) { }
        private System.Void PushInt32(System.Int32 i) { }
        private System.Int32 GetInt32(System.Int32 offset) { }
        private System.Void PushUInt32(System.UInt32 ui) { }
        private System.UInt32 GetUInt32(System.Int32 offset) { }
        private System.Void PushInt64(System.Int64 i) { }
        private System.Int64 GetInt64(System.Int32 offset) { }
        private System.Void PushUInt64(System.UInt64 i) { }
        private System.UInt64 GetUInt64(System.Int32 offset) { }
        private System.Void PushSingle(System.Single f) { }
        private System.Single GetSingle(System.Int32 offset) { }
        private System.Void PushDouble(System.Double d) { }
        private System.Double GetDouble(System.Int32 offset) { }
        private System.Void PushIntPtr(System.IntPtr i) { }
        private System.IntPtr GetIntPtr(System.Int32 offset) { }
        private System.Void PushObject(System.Object o) { }
        private System.Void PushValueType(System.Object o) { }
        private System.Object GetObject(System.Int32 offset) { }
        private T GetAsType(System.Int32 offset) { }
        private System.Void PushObjectAsResult(System.Object obj, System.Type type) { }
        private System.Void PushRef(System.Int32 offset) { }
        private System.Void UpdateReference(System.Int32 offset, System.Object obj, IFix.Core.VirtualMachine virtualMachine, System.Type type) { }

    }

    // TypeToken: 0x200001D
    public class Utils
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Type,System.Reflection.MethodInfo> delegateAdptCache;        // 0x0

        // Methods
        private System.Boolean IsAssignable(System.Reflection.MethodInfo delegateMethod, System.Reflection.MethodInfo method) { }
        private System.Delegate TryAdapterToDelegate(System.Object obj, System.Type delegateType, System.String perfix) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001E
    public class RuntimeException : Exception
    {
        // Fields
        private System.Exception <Real>k__BackingField;        // 0x90

        // Methods
        private System.Void .ctor() { }
        private System.Exception get_Real() { }
        private System.Void set_Real(System.Exception value) { }

    }

    // TypeToken: 0x200001F
    public class ExternInvoker : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(IFix.Core.VirtualMachine vm, IFix.Core.Call& call, System.Boolean isInstantiate) { }

    }

    // TypeToken: 0x2000020
    public class FieldAddr
    {
        // Fields
        public System.Object Object;        // 0x10
        public System.Int32[] FieldIdList;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public class Cleanner
    {
        // Fields
        private static System.Boolean start;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void Start() { }
        private System.Void Stop() { }
        private System.Void Finalize() { }

    }

    // TypeToken: 0x2000022
    public class NewFieldInfo
    {
        // Fields
        public System.String Name;        // 0x10
        public System.Type DeclaringType;        // 0x18
        public System.Type FieldType;        // 0x20
        public System.Int32 MethodId;        // 0x28
        private static readonly System.Int32 staticObjectKey;        // 0x0
        private static readonly IFix.Core.ThreadStackInfo stack;        // 0x8
        private static readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.String,System.Object>> newFieldValues;        // 0x10
        private static readonly System.Collections.Generic.Dictionary<System.Int32,System.WeakReference> objList;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Object SetDefaultValue(System.Object obj) { }
        private System.Void Sweep() { }
        private System.Void CheckInit(IFix.Core.VirtualMachine virtualMachine, System.Object obj) { }
        private System.Int32 ObjectToIndex(System.Object obj) { }
        private System.Boolean HasInitialize(System.Object obj) { }
        private System.Object GetValue(System.Object obj) { }
        private System.Void SetValue(System.Object obj, System.Object value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000023
    public class VirtualMachine
    {
        // Fields
        private IFix.Core.ObjectClone objectClone;        // 0x10
        private IFix.Core.Instruction** unmanagedCodes;        // 0x18
        private IFix.Core.ExceptionHandler[][] exceptionHandlers;        // 0x20
        private System.Action onDispose;        // 0x28
        private IFix.Core.ExternInvoker[] externInvokers;        // 0x30
        private System.Collections.Generic.Dictionary<System.Reflection.MethodBase,IFix.Core.VirtualMachine.CalliInvokerInfo> calliInvokerCache;        // 0x38
        private System.Reflection.MethodBase[] externMethods;        // 0x40
        private System.Type[] externTypes;        // 0x48
        private System.String[] internStrings;        // 0x50
        private System.Reflection.FieldInfo[] fieldInfos;        // 0x58
        private System.Collections.Generic.Dictionary<System.Int32,IFix.Core.NewFieldInfo> newFieldInfos;        // 0x60
        private IFix.Core.AnonymousStoreyInfo[] anonymousStoreyInfos;        // 0x68
        private System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.Reflection.MethodInfo,System.Reflection.MethodInfo>> overrideCache;        // 0x70
        private System.Type[] staticFieldTypes;        // 0x78
        private System.Object[] staticFields;        // 0x80
        private System.Int32[] cctors;        // 0x88
        private IFix.Core.WrappersManager wrappersManager;        // 0x90
        public static System.Action<System.String> Info;        // 0x0
        private static System.Action<System.String> <>f__mg$cache0;        // 0x8

        // Methods
        private System.Void .ctor(IFix.Core.Instruction** unmanaged_codes, System.Action on_dispose) { }
        private System.Void set_ExceptionHandlers(IFix.Core.ExceptionHandler[][] value) { }
        private System.Type[] get_ExternTypes() { }
        private System.Void set_ExternTypes(System.Type[] value) { }
        private System.Void set_ExternMethods(System.Reflection.MethodBase[] value) { }
        private System.Void set_InternStrings(System.String[] value) { }
        private System.Void set_FieldInfos(System.Reflection.FieldInfo[] value) { }
        private System.Void set_NewFieldInfos(System.Collections.Generic.Dictionary<System.Int32,IFix.Core.NewFieldInfo> value) { }
        private System.Void set_AnonymousStoreyInfos(IFix.Core.AnonymousStoreyInfo[] value) { }
        private System.Void set_StaticFieldTypes(System.Type[] value) { }
        private System.Void set_Cctors(System.Int32[] value) { }
        private IFix.Core.WrappersManager get_WrappersManager() { }
        private System.Void set_WrappersManager(IFix.Core.WrappersManager value) { }
        private System.Void Finalize() { }
        private System.Void checkCctorExecute(System.Int32 fieldId, IFix.Core.Value* argumentBase, System.Object[] managedStack, IFix.Core.Value* evaluationStackBase) { }
        private System.Void store(IFix.Core.Value* stackBase, IFix.Core.Value* dst, IFix.Core.Value* src, System.Object[] managedStack) { }
        private System.Void copy(IFix.Core.Value* stackBase, IFix.Core.Value* dst, IFix.Core.Value* src, System.Object[] managedStack) { }
        private System.Void resolveStackReference(IFix.Core.Value* value, IFix.Core.Value* stackBase, System.Object[] managedStack) { }
        private System.Byte* stackReferenceToPointer(IFix.Core.Value* value) { }
        private System.Boolean tryConvertStackReferenceToPointer(IFix.Core.Value* value) { }
        private System.Byte* pointerValueToAddress(IFix.Core.Value* value, System.Object[] managedStack) { }
        private System.Int64 valueToInt64(IFix.Core.Value* value) { }
        private System.Single valueToFloat(IFix.Core.Value* value) { }
        private System.Double valueToDouble(IFix.Core.Value* value) { }
        private System.Void storeToRawPointer(System.Byte* destination, IFix.Core.Value* src, IFix.Core.Code code) { }
        private System.Void loadFromRawPointer(System.Byte* source, IFix.Core.Value* dest, IFix.Core.Code code) { }
        private System.Void Execute(System.Int32 methodIndex, IFix.Core.Call& call, System.Int32 argsCount, System.Int32 refCount) { }
        private IFix.Core.Value* Execute(System.Int32 methodIndex, IFix.Core.Value* argumentBase, System.Object[] managedStack, IFix.Core.Value* evaluationStackBase, System.Int32 argsCount) { }
        private System.Void throwRuntimeException(System.Exception e, System.Boolean bWrap) { }
        private IFix.Core.ExceptionHandler getExceptionHandler(System.Int32 methodIndex, System.Type exceptionType, System.Int32 pc) { }
        private System.Void arrayGet(System.Object obj, System.Int32 idx, IFix.Core.Value* val, System.Object[] managedStack, IFix.Core.Value* evaluationStackBase) { }
        private System.Void arraySet(System.Object obj, System.Int32 idx, IFix.Core.Value* val, System.Object[] managedStack, IFix.Core.Value* evaluationStackBase) { }
        private System.Void _Info(System.String a) { }
        private IFix.Core.Value* Execute(IFix.Core.Instruction* pc, IFix.Core.Value* argumentBase, System.Object[] managedStack, IFix.Core.Value* evaluationStackBase, System.Int32 argsCount, System.Int32 methodIndex, System.Int32 refCount, IFix.Core.Value** topWriteBack) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000025
    public interface WrappersManager
    {
        // Methods
        private System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        private IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Object CreateWrapper(System.Int32 id) { }
        private System.Object InitWrapperArray(System.Int32 len) { }

    }

}

namespace Unity.IL2CPP.CompilerServices
{

    // TypeToken: 0x2000014
    public struct Option
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Unity.IL2CPP.CompilerServices.Option NullChecks;        // 0x0
        public static Unity.IL2CPP.CompilerServices.Option ArrayBoundsChecks;        // 0x0
        public static Unity.IL2CPP.CompilerServices.Option DivideByZeroChecks;        // 0x0

    }

    // TypeToken: 0x2000015
    public class Il2CppSetOptionAttribute : Attribute
    {
        // Fields
        private Unity.IL2CPP.CompilerServices.Option <Option>k__BackingField;        // 0x10
        private System.Object <Value>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(Unity.IL2CPP.CompilerServices.Option option, System.Object value) { }
        private System.Void set_Option(Unity.IL2CPP.CompilerServices.Option value) { }
        private System.Void set_Value(System.Object value) { }

    }

}

