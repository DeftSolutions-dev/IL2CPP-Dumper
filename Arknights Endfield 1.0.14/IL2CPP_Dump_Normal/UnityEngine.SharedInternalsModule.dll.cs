// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.SharedInternalsModule.dll
// Classes:  29
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace UnityEngine
{

    // TypeToken: 0x2000002
    public class AssetFileNameExtensionAttribute : Attribute
    {
        // Fields
        private readonly System.String <preferredExtension>k__BackingField;        // 0x10
        private readonly System.Collections.Generic.IEnumerable<System.String> <otherExtensions>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.String preferredExtension, System.String[] otherExtensions) { }

    }

    // TypeToken: 0x2000003
    public class ThreadAndSerializationSafeAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class WritableAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class UnityEngineModuleAssembly : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class NativeClassAttribute : Attribute
    {
        // Fields
        private System.String <QualifiedNativeName>k__BackingField;        // 0x10
        private System.String <Declaration>k__BackingField;        // 0x18

        // Methods
        private System.Void set_QualifiedNativeName(System.String value) { }
        private System.Void set_Declaration(System.String value) { }
        private System.Void .ctor(System.String qualifiedCppName) { }
        private System.Void .ctor(System.String qualifiedCppName, System.String declaration) { }

    }

    // TypeToken: 0x2000007
    public class UnityString
    {
        // Methods
        private System.String Format(System.String fmt, System.Object[] args) { }

    }

}

namespace UnityEngine.Bindings
{

    // TypeToken: 0x2000008
    public class VisibleToOtherModulesAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String[] modules) { }

    }

    // TypeToken: 0x2000009
    public class NativeConditionalAttribute : Attribute
    {
        // Fields
        private System.String <Condition>k__BackingField;        // 0x10
        private System.String <StubReturnStatement>k__BackingField;        // 0x18
        private System.Boolean <Enabled>k__BackingField;        // 0x20

        // Methods
        private System.Void set_Condition(System.String value) { }
        private System.Void set_StubReturnStatement(System.String value) { }
        private System.Void set_Enabled(System.Boolean value) { }
        private System.Void .ctor(System.String condition) { }
        private System.Void .ctor(System.String condition, System.String stubReturnStatement) { }

    }

    // TypeToken: 0x200000A
    public class NativeHeaderAttribute : Attribute
    {
        // Fields
        private System.String <Header>k__BackingField;        // 0x10

        // Methods
        private System.Void set_Header(System.String value) { }
        private System.Void .ctor(System.String header) { }

    }

    // TypeToken: 0x200000B
    public class NativeNameAttribute : Attribute
    {
        // Fields
        private System.String <Name>k__BackingField;        // 0x10

        // Methods
        private System.Void set_Name(System.String value) { }
        private System.Void .ctor(System.String name) { }

    }

    // TypeToken: 0x200000C
    public class NativeWritableSelfAttribute : Attribute
    {
        // Fields
        private System.Boolean <WritableSelf>k__BackingField;        // 0x10

        // Methods
        private System.Void set_WritableSelf(System.Boolean value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000D
    public class NativeMethodAttribute : Attribute
    {
        // Fields
        private System.String <Name>k__BackingField;        // 0x10
        private System.Boolean <IsThreadSafe>k__BackingField;        // 0x18
        private System.Boolean <IsFreeFunction>k__BackingField;        // 0x19
        private System.Boolean <ThrowsException>k__BackingField;        // 0x1A
        private System.Boolean <HasExplicitThis>k__BackingField;        // 0x1B

        // Methods
        private System.Void set_Name(System.String value) { }
        private System.Void set_IsThreadSafe(System.Boolean value) { }
        private System.Void set_IsFreeFunction(System.Boolean value) { }
        private System.Void set_ThrowsException(System.Boolean value) { }
        private System.Void set_HasExplicitThis(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name) { }
        private System.Void .ctor(System.String name, System.Boolean isFreeFunction) { }
        private System.Void .ctor(System.String name, System.Boolean isFreeFunction, System.Boolean isThreadSafe) { }

    }

    // TypeToken: 0x200000E
    public struct TargetType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Bindings.TargetType Function;        // 0x0
        public static UnityEngine.Bindings.TargetType Field;        // 0x0

    }

    // TypeToken: 0x200000F
    public class NativePropertyAttribute : NativeMethodAttribute
    {
        // Fields
        private UnityEngine.Bindings.TargetType <TargetType>k__BackingField;        // 0x20

        // Methods
        private System.Void set_TargetType(UnityEngine.Bindings.TargetType value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name) { }
        private System.Void .ctor(System.String name, System.Boolean isFree, UnityEngine.Bindings.TargetType targetType) { }
        private System.Void .ctor(System.String name, System.Boolean isFree, UnityEngine.Bindings.TargetType targetType, System.Boolean isThreadSafe) { }

    }

    // TypeToken: 0x2000010
    public struct CodegenOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Bindings.CodegenOptions Auto;        // 0x0
        public static UnityEngine.Bindings.CodegenOptions Custom;        // 0x0
        public static UnityEngine.Bindings.CodegenOptions Force;        // 0x0

    }

    // TypeToken: 0x2000011
    public class NativeAsStructAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public class NativeTypeAttribute : Attribute
    {
        // Fields
        private System.String <Header>k__BackingField;        // 0x10
        private System.String <IntermediateScriptingStructName>k__BackingField;        // 0x18
        private UnityEngine.Bindings.CodegenOptions <CodegenOptions>k__BackingField;        // 0x20

        // Methods
        private System.Void set_Header(System.String value) { }
        private System.Void set_IntermediateScriptingStructName(System.String value) { }
        private System.Void set_CodegenOptions(UnityEngine.Bindings.CodegenOptions value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Bindings.CodegenOptions codegenOptions) { }
        private System.Void .ctor(System.String header) { }
        private System.Void .ctor(UnityEngine.Bindings.CodegenOptions codegenOptions, System.String intermediateStructName) { }

    }

    // TypeToken: 0x2000013
    public class NotNullAttribute : Attribute
    {
        // Fields
        private System.String <Exception>k__BackingField;        // 0x10

        // Methods
        private System.Void set_Exception(System.String value) { }
        private System.Void .ctor(System.String exception) { }

    }

    // TypeToken: 0x2000014
    public class UnmarshalledAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000015
    public class FreeFunctionAttribute : NativeMethodAttribute
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name) { }
        private System.Void .ctor(System.String name, System.Boolean isThreadSafe) { }

    }

    // TypeToken: 0x2000016
    public class ThreadSafeAttribute : NativeMethodAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000017
    public struct StaticAccessorType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.Bindings.StaticAccessorType Dot;        // 0x0
        public static UnityEngine.Bindings.StaticAccessorType Arrow;        // 0x0
        public static UnityEngine.Bindings.StaticAccessorType DoubleColon;        // 0x0
        public static UnityEngine.Bindings.StaticAccessorType ArrowWithDefaultReturnIfNull;        // 0x0

    }

    // TypeToken: 0x2000018
    public class StaticAccessorAttribute : Attribute
    {
        // Fields
        private System.String <Name>k__BackingField;        // 0x10
        private UnityEngine.Bindings.StaticAccessorType <Type>k__BackingField;        // 0x18

        // Methods
        private System.Void set_Name(System.String value) { }
        private System.Void set_Type(UnityEngine.Bindings.StaticAccessorType value) { }
        private System.Void .ctor(System.String name) { }
        private System.Void .ctor(System.String name, UnityEngine.Bindings.StaticAccessorType type) { }

    }

    // TypeToken: 0x2000019
    public class NativeThrowsAttribute : Attribute
    {
        // Fields
        private System.Boolean <ThrowsException>k__BackingField;        // 0x10

        // Methods
        private System.Void set_ThrowsException(System.Boolean value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001A
    public class IgnoreAttribute : Attribute
    {
        // Fields
        private System.Boolean <DoesNotContributeToSize>k__BackingField;        // 0x10

        // Methods
        private System.Void set_DoesNotContributeToSize(System.Boolean value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001B
    public class PreventReadOnlyInstanceModificationAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.Scripting
{

    // TypeToken: 0x200001C
    public class UsedByNativeCodeAttribute : Attribute
    {
        // Fields
        private System.String <Name>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name) { }
        private System.Void set_Name(System.String value) { }

    }

    // TypeToken: 0x200001D
    public class RequiredByNativeCodeAttribute : Attribute
    {
        // Fields
        private System.String <Name>k__BackingField;        // 0x10
        private System.Boolean <Optional>k__BackingField;        // 0x18
        private System.Boolean <GenerateProxy>k__BackingField;        // 0x19

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name) { }
        private System.Void set_Name(System.String value) { }
        private System.Void set_Optional(System.Boolean value) { }
        private System.Void set_GenerateProxy(System.Boolean value) { }

    }

}

