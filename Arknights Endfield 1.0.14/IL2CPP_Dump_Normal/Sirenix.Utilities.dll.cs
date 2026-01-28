// ========================================================
// Dumped by @desirepro
// Assembly: Sirenix.Utilities.dll
// Classes:  13
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace Sirenix.Utilities
{

    // TypeToken: 0x2000002
    public class LinqExtensions
    {
        // Methods
        private System.Void Sort(System.Collections.Generic.IList<T> list, System.Comparison<T> comparison) { }

    }

    // TypeToken: 0x2000003
    public class TypeExtensions
    {
        // Fields
        private static readonly System.Func<System.Single,System.Single,System.Boolean> FloatEqualityComparerFunc;        // 0x0
        private static readonly System.Func<System.Double,System.Double,System.Boolean> DoubleEqualityComparerFunc;        // 0x8
        private static readonly System.Func<UnityEngine.Quaternion,UnityEngine.Quaternion,System.Boolean> QuaternionEqualityComparerFunc;        // 0x10
        private static readonly System.Object GenericConstraintsSatisfaction_LOCK;        // 0x18
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Type> GenericConstraintsSatisfactionInferredParameters;        // 0x20
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Type> GenericConstraintsSatisfactionResolvedMap;        // 0x28
        private static readonly System.Collections.Generic.HashSet<System.Type> GenericConstraintsSatisfactionProcessedParams;        // 0x30
        private static readonly System.Collections.Generic.HashSet<System.Type> GenericConstraintsSatisfactionTypesToCheck;        // 0x38
        private static readonly System.Collections.Generic.List<System.Type> GenericConstraintsSatisfactionTypesToCheck_ToAdd;        // 0x40
        private static readonly System.Type GenericListInterface;        // 0x48
        private static readonly System.Type GenericCollectionInterface;        // 0x50
        private static readonly System.Object WeaklyTypedTypeCastDelegates_LOCK;        // 0x58
        private static readonly System.Object StronglyTypedTypeCastDelegates_LOCK;        // 0x60
        private static readonly Sirenix.Utilities.DoubleLookupDictionary<System.Type,System.Type,System.Func<System.Object,System.Object>> WeaklyTypedTypeCastDelegates;        // 0x68
        private static readonly Sirenix.Utilities.DoubleLookupDictionary<System.Type,System.Type,System.Delegate> StronglyTypedTypeCastDelegates;        // 0x70
        private static readonly System.Type[] TwoLengthTypeArray_Cached;        // 0x78
        private static readonly System.Collections.Generic.Stack<System.Type> GenericArgumentsContainsTypes_ArgsToCheckCached;        // 0x80
        private static System.Collections.Generic.HashSet<System.String> ReservedCSharpKeywords;        // 0x88
        public static readonly System.Collections.Generic.Dictionary<System.Type,System.String> TypeNameAlternatives;        // 0x90
        private static readonly System.Object CachedNiceNames_LOCK;        // 0x98
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.String> CachedNiceNames;        // 0xA0
        private static readonly System.Type VoidPointerType;        // 0xA8
        private static readonly System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.HashSet<System.Type>> PrimitiveImplicitCasts;        // 0xB0
        private static readonly System.Collections.Generic.HashSet<System.Type> ExplicitCastIntegrals;        // 0xB8

        // Methods
        private System.String GetCachedNiceName(System.Type type) { }
        private System.String CreateNiceName(System.Type type) { }
        private System.Boolean FloatEqualityComparer(System.Single a, System.Single b) { }
        private System.Boolean DoubleEqualityComparer(System.Double a, System.Double b) { }
        private System.Boolean QuaternionEqualityComparer(UnityEngine.Quaternion a, UnityEngine.Quaternion b) { }
        private System.String GetMaybeSimplifiedTypeName(System.Type type) { }
        private System.String GetNiceName(System.Type type) { }
        private T GetCustomAttribute(System.Type type, System.Boolean inherit) { }
        private T GetCustomAttribute(System.Type type) { }
        private System.Boolean InheritsFrom(System.Type type, System.Type baseType) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000004
    public class DoubleLookupDictionary`3 : Dictionary`2
    {
        // Fields
        private readonly System.Collections.Generic.IEqualityComparer<TSecondKey> secondKeyComparer;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public interface IGlobalConfigEvents
    {
        // Methods
        private System.Void OnConfigAutoCreated() { }
        private System.Void OnConfigInstanceFirstAccessed() { }

    }

    // TypeToken: 0x2000006
    public class GlobalConfig`1 : ScriptableObject, IGlobalConfigEvents
    {
        // Fields
        private static Sirenix.Utilities.GlobalConfigAttribute configAttribute;        // 0x0
        private static T instance;        // 0x0

        // Methods
        private Sirenix.Utilities.GlobalConfigAttribute get_ConfigAttribute() { }
        private System.Boolean get_HasInstanceLoaded() { }
        private T get_Instance() { }
        private System.Void LoadInstanceIfAssetExists() { }
        private System.Void OpenInEditor() { }
        private System.Void OnConfigInstanceFirstAccessed() { }
        private System.Void OnConfigAutoCreated() { }
        private System.Void Sirenix.Utilities.IGlobalConfigEvents.OnConfigAutoCreated() { }
        private System.Void Sirenix.Utilities.IGlobalConfigEvents.OnConfigInstanceFirstAccessed() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class GlobalConfigUtility`1
    {
        // Fields
        private static T instance;        // 0x0

        // Methods
        private System.Boolean get_HasInstanceLoaded() { }
        private T GetInstance(System.String defaultAssetFolderPath, System.String defaultFileNameWithoutExtension) { }
        private System.Void LoadInstanceIfAssetExists(System.String assetPath, System.String defaultFileNameWithoutExtension) { }

    }

    // TypeToken: 0x2000008
    public class GlobalConfigAttribute : Attribute
    {
        // Fields
        private System.String assetPath;        // 0x10
        private System.Boolean <UseAsset>k__BackingField;        // 0x18

        // Methods
        private System.String get_AssetPath() { }
        private System.Void .ctor(System.String assetPath) { }

    }

    // TypeToken: 0x2000009
    public class PersistentAssemblyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000A
    public class ProjectPathFinder : ScriptableObject
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public class SirenixAssetPaths
    {
        // Fields
        public static readonly System.String OdinPath;        // 0x0
        public static readonly System.String SirenixAssetsPath;        // 0x8
        public static readonly System.String SirenixPluginPath;        // 0x10
        public static readonly System.String SirenixAssembliesPath;        // 0x18
        public static readonly System.String OdinResourcesPath;        // 0x20
        public static readonly System.String OdinEditorConfigsPath;        // 0x28
        public static readonly System.String OdinResourcesConfigsPath;        // 0x30

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000C
    public class SirenixGlobalConfigAttribute : GlobalConfigAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000D
    public class UnityVersion
    {
        // Fields
        public static readonly System.Int32 Major;        // 0x0
        public static readonly System.Int32 Minor;        // 0x4

        // Methods
        private System.Void .cctor() { }
        private System.Void EnsureLoaded() { }

    }

}

