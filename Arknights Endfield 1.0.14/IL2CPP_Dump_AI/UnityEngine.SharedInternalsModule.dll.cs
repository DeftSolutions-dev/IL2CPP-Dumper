// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.SharedInternalsModule.dll
// Classes:  29
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UnityEngine.AssetFileNameExtensionAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
  private   readonly System.String                   <preferredExtension>k__BackingField  // 0x10
  private   readonly System.Collections.Generic.IEnumerable<System.String><otherExtensions>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.String preferredExtension, System.String[] otherExtensions)
END_CLASS

CLASS: UnityEngine.ThreadAndSerializationSafeAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.WritableAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UnityEngineModuleAssembly
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.NativeClassAttribute
TYPE:  class
TOKEN: 0x2000006
EXTENDS: Attribute
FIELDS:
  private           System.String                   <QualifiedNativeName>k__BackingField  // 0x10
  private           System.String                   <Declaration>k__BackingField  // 0x18
METHODS:
  System.Void set_QualifiedNativeName(System.String value)
  System.Void set_Declaration(System.String value)
  System.Void .ctor(System.String qualifiedCppName)
  System.Void .ctor(System.String qualifiedCppName, System.String declaration)
END_CLASS

CLASS: UnityEngine.UnityString
TYPE:  class
TOKEN: 0x2000007
FIELDS:
METHODS:
  System.String Format(System.String fmt, System.Object[] args)
END_CLASS

CLASS: UnityEngine.Bindings.VisibleToOtherModulesAttribute
TYPE:  class
TOKEN: 0x2000008
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String[] modules)
END_CLASS

CLASS: UnityEngine.Bindings.NativeConditionalAttribute
TYPE:  class
TOKEN: 0x2000009
EXTENDS: Attribute
FIELDS:
  private           System.String                   <Condition>k__BackingField  // 0x10
  private           System.String                   <StubReturnStatement>k__BackingField  // 0x18
  private           System.Boolean                  <Enabled>k__BackingField  // 0x20
METHODS:
  System.Void set_Condition(System.String value)
  System.Void set_StubReturnStatement(System.String value)
  System.Void set_Enabled(System.Boolean value)
  System.Void .ctor(System.String condition)
  System.Void .ctor(System.String condition, System.String stubReturnStatement)
END_CLASS

CLASS: UnityEngine.Bindings.NativeHeaderAttribute
TYPE:  class
TOKEN: 0x200000A
EXTENDS: Attribute
FIELDS:
  private           System.String                   <Header>k__BackingField  // 0x10
METHODS:
  System.Void set_Header(System.String value)
  System.Void .ctor(System.String header)
END_CLASS

CLASS: UnityEngine.Bindings.NativeNameAttribute
TYPE:  class
TOKEN: 0x200000B
EXTENDS: Attribute
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
METHODS:
  System.Void set_Name(System.String value)
  System.Void .ctor(System.String name)
END_CLASS

CLASS: UnityEngine.Bindings.NativeWritableSelfAttribute
TYPE:  class
TOKEN: 0x200000C
EXTENDS: Attribute
FIELDS:
  private           System.Boolean                  <WritableSelf>k__BackingField  // 0x10
METHODS:
  System.Void set_WritableSelf(System.Boolean value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Bindings.NativeMethodAttribute
TYPE:  class
TOKEN: 0x200000D
EXTENDS: Attribute
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
  private           System.Boolean                  <IsThreadSafe>k__BackingField  // 0x18
  private           System.Boolean                  <IsFreeFunction>k__BackingField  // 0x19
  private           System.Boolean                  <ThrowsException>k__BackingField  // 0x1A
  private           System.Boolean                  <HasExplicitThis>k__BackingField  // 0x1B
METHODS:
  System.Void set_Name(System.String value)
  System.Void set_IsThreadSafe(System.Boolean value)
  System.Void set_IsFreeFunction(System.Boolean value)
  System.Void set_ThrowsException(System.Boolean value)
  System.Void set_HasExplicitThis(System.Boolean value)
  System.Void .ctor()
  System.Void .ctor(System.String name)
  System.Void .ctor(System.String name, System.Boolean isFreeFunction)
  System.Void .ctor(System.String name, System.Boolean isFreeFunction, System.Boolean isThreadSafe)
END_CLASS

CLASS: UnityEngine.Bindings.TargetType
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Bindings.TargetType Function  // 0x0
  public    static  UnityEngine.Bindings.TargetType Field  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Bindings.NativePropertyAttribute
TYPE:  class
TOKEN: 0x200000F
EXTENDS: NativeMethodAttribute
FIELDS:
  private           UnityEngine.Bindings.TargetType <TargetType>k__BackingField  // 0x20
METHODS:
  System.Void set_TargetType(UnityEngine.Bindings.TargetType value)
  System.Void .ctor()
  System.Void .ctor(System.String name)
  System.Void .ctor(System.String name, System.Boolean isFree, UnityEngine.Bindings.TargetType targetType)
  System.Void .ctor(System.String name, System.Boolean isFree, UnityEngine.Bindings.TargetType targetType, System.Boolean isThreadSafe)
END_CLASS

CLASS: UnityEngine.Bindings.CodegenOptions
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Bindings.CodegenOptionsAuto  // 0x0
  public    static  UnityEngine.Bindings.CodegenOptionsCustom  // 0x0
  public    static  UnityEngine.Bindings.CodegenOptionsForce  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Bindings.NativeAsStructAttribute
TYPE:  class
TOKEN: 0x2000011
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Bindings.NativeTypeAttribute
TYPE:  class
TOKEN: 0x2000012
EXTENDS: Attribute
FIELDS:
  private           System.String                   <Header>k__BackingField  // 0x10
  private           System.String                   <IntermediateScriptingStructName>k__BackingField  // 0x18
  private           UnityEngine.Bindings.CodegenOptions<CodegenOptions>k__BackingField  // 0x20
METHODS:
  System.Void set_Header(System.String value)
  System.Void set_IntermediateScriptingStructName(System.String value)
  System.Void set_CodegenOptions(UnityEngine.Bindings.CodegenOptions value)
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Bindings.CodegenOptions codegenOptions)
  System.Void .ctor(System.String header)
  System.Void .ctor(UnityEngine.Bindings.CodegenOptions codegenOptions, System.String intermediateStructName)
END_CLASS

CLASS: UnityEngine.Bindings.NotNullAttribute
TYPE:  class
TOKEN: 0x2000013
EXTENDS: Attribute
FIELDS:
  private           System.String                   <Exception>k__BackingField  // 0x10
METHODS:
  System.Void set_Exception(System.String value)
  System.Void .ctor(System.String exception)
END_CLASS

CLASS: UnityEngine.Bindings.UnmarshalledAttribute
TYPE:  class
TOKEN: 0x2000014
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Bindings.FreeFunctionAttribute
TYPE:  class
TOKEN: 0x2000015
EXTENDS: NativeMethodAttribute
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String name)
  System.Void .ctor(System.String name, System.Boolean isThreadSafe)
END_CLASS

CLASS: UnityEngine.Bindings.ThreadSafeAttribute
TYPE:  class
TOKEN: 0x2000016
EXTENDS: NativeMethodAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Bindings.StaticAccessorType
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.Bindings.StaticAccessorTypeDot  // 0x0
  public    static  UnityEngine.Bindings.StaticAccessorTypeArrow  // 0x0
  public    static  UnityEngine.Bindings.StaticAccessorTypeDoubleColon  // 0x0
  public    static  UnityEngine.Bindings.StaticAccessorTypeArrowWithDefaultReturnIfNull  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.Bindings.StaticAccessorAttribute
TYPE:  class
TOKEN: 0x2000018
EXTENDS: Attribute
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
  private           UnityEngine.Bindings.StaticAccessorType<Type>k__BackingField  // 0x18
METHODS:
  System.Void set_Name(System.String value)
  System.Void set_Type(UnityEngine.Bindings.StaticAccessorType value)
  System.Void .ctor(System.String name)
  System.Void .ctor(System.String name, UnityEngine.Bindings.StaticAccessorType type)
END_CLASS

CLASS: UnityEngine.Bindings.NativeThrowsAttribute
TYPE:  class
TOKEN: 0x2000019
EXTENDS: Attribute
FIELDS:
  private           System.Boolean                  <ThrowsException>k__BackingField  // 0x10
METHODS:
  System.Void set_ThrowsException(System.Boolean value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Bindings.IgnoreAttribute
TYPE:  class
TOKEN: 0x200001A
EXTENDS: Attribute
FIELDS:
  private           System.Boolean                  <DoesNotContributeToSize>k__BackingField  // 0x10
METHODS:
  System.Void set_DoesNotContributeToSize(System.Boolean value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Bindings.PreventReadOnlyInstanceModificationAttribute
TYPE:  class
TOKEN: 0x200001B
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Scripting.UsedByNativeCodeAttribute
TYPE:  class
TOKEN: 0x200001C
EXTENDS: Attribute
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String name)
  System.Void set_Name(System.String value)
END_CLASS

CLASS: UnityEngine.Scripting.RequiredByNativeCodeAttribute
TYPE:  class
TOKEN: 0x200001D
EXTENDS: Attribute
FIELDS:
  private           System.String                   <Name>k__BackingField  // 0x10
  private           System.Boolean                  <Optional>k__BackingField  // 0x18
  private           System.Boolean                  <GenerateProxy>k__BackingField  // 0x19
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String name)
  System.Void set_Name(System.String value)
  System.Void set_Optional(System.Boolean value)
  System.Void set_GenerateProxy(System.Boolean value)
END_CLASS

