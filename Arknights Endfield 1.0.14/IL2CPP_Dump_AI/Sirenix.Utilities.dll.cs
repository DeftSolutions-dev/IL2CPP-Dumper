// ========================================================
// Dumped by @desirepro
// Assembly: Sirenix.Utilities.dll
// Classes:  13
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Sirenix.Utilities.LinqExtensions
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.Void Sort(System.Collections.Generic.IList<T> list, System.Comparison<T> comparison)
END_CLASS

CLASS: Sirenix.Utilities.TypeExtensions
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private   static readonly System.Func<System.Single,System.Single,System.Boolean>FloatEqualityComparerFunc  // 0x0
  private   static readonly System.Func<System.Double,System.Double,System.Boolean>DoubleEqualityComparerFunc  // 0x8
  private   static readonly System.Func<UnityEngine.Quaternion,UnityEngine.Quaternion,System.Boolean>QuaternionEqualityComparerFunc  // 0x10
  private   static readonly System.Object                   GenericConstraintsSatisfaction_LOCK  // 0x18
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Type>GenericConstraintsSatisfactionInferredParameters  // 0x20
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Type>GenericConstraintsSatisfactionResolvedMap  // 0x28
  private   static readonly System.Collections.Generic.HashSet<System.Type>GenericConstraintsSatisfactionProcessedParams  // 0x30
  private   static readonly System.Collections.Generic.HashSet<System.Type>GenericConstraintsSatisfactionTypesToCheck  // 0x38
  private   static readonly System.Collections.Generic.List<System.Type>GenericConstraintsSatisfactionTypesToCheck_ToAdd  // 0x40
  private   static readonly System.Type                     GenericListInterface  // 0x48
  private   static readonly System.Type                     GenericCollectionInterface  // 0x50
  private   static readonly System.Object                   WeaklyTypedTypeCastDelegates_LOCK  // 0x58
  private   static readonly System.Object                   StronglyTypedTypeCastDelegates_LOCK  // 0x60
  private   static readonly Sirenix.Utilities.DoubleLookupDictionary<System.Type,System.Type,System.Func<System.Object,System.Object>>WeaklyTypedTypeCastDelegates  // 0x68
  private   static readonly Sirenix.Utilities.DoubleLookupDictionary<System.Type,System.Type,System.Delegate>StronglyTypedTypeCastDelegates  // 0x70
  private   static readonly System.Type[]                   TwoLengthTypeArray_Cached  // 0x78
  private   static readonly System.Collections.Generic.Stack<System.Type>GenericArgumentsContainsTypes_ArgsToCheckCached  // 0x80
  private   static  System.Collections.Generic.HashSet<System.String>ReservedCSharpKeywords  // 0x88
  public    static readonly System.Collections.Generic.Dictionary<System.Type,System.String>TypeNameAlternatives  // 0x90
  private   static readonly System.Object                   CachedNiceNames_LOCK  // 0x98
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.String>CachedNiceNames  // 0xA0
  private   static readonly System.Type                     VoidPointerType  // 0xA8
  private   static readonly System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.HashSet<System.Type>>PrimitiveImplicitCasts  // 0xB0
  private   static readonly System.Collections.Generic.HashSet<System.Type>ExplicitCastIntegrals  // 0xB8
METHODS:
  System.String GetCachedNiceName(System.Type type)
  System.String CreateNiceName(System.Type type)
  System.Boolean FloatEqualityComparer(System.Single a, System.Single b)
  System.Boolean DoubleEqualityComparer(System.Double a, System.Double b)
  System.Boolean QuaternionEqualityComparer(UnityEngine.Quaternion a, UnityEngine.Quaternion b)
  System.String GetMaybeSimplifiedTypeName(System.Type type)
  System.String GetNiceName(System.Type type)
  T GetCustomAttribute(System.Type type, System.Boolean inherit)
  T GetCustomAttribute(System.Type type)
  System.Boolean InheritsFrom(System.Type type, System.Type baseType)
  System.Void .cctor()
END_CLASS

CLASS: Sirenix.Utilities.DoubleLookupDictionary`3
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Dictionary`2
FIELDS:
  private   readonly System.Collections.Generic.IEqualityComparer<TSecondKey>secondKeyComparer  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Sirenix.Utilities.IGlobalConfigEvents
TYPE:  interface
TOKEN: 0x2000005
FIELDS:
METHODS:
  System.Void OnConfigAutoCreated()
  System.Void OnConfigInstanceFirstAccessed()
END_CLASS

CLASS: Sirenix.Utilities.GlobalConfig`1
TYPE:  class
TOKEN: 0x2000006
EXTENDS: ScriptableObject
FIELDS:
  private   static  Sirenix.Utilities.GlobalConfigAttributeconfigAttribute  // 0x0
  private   static  T                               instance  // 0x0
METHODS:
  Sirenix.Utilities.GlobalConfigAttribute get_ConfigAttribute()
  System.Boolean get_HasInstanceLoaded()
  T get_Instance()
  System.Void LoadInstanceIfAssetExists()
  System.Void OpenInEditor()
  System.Void OnConfigInstanceFirstAccessed()
  System.Void OnConfigAutoCreated()
  System.Void Sirenix.Utilities.IGlobalConfigEvents.OnConfigAutoCreated()
  System.Void Sirenix.Utilities.IGlobalConfigEvents.OnConfigInstanceFirstAccessed()
  System.Void .ctor()
END_CLASS

CLASS: Sirenix.Utilities.GlobalConfigUtility`1
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private   static  T                               instance  // 0x0
METHODS:
  System.Boolean get_HasInstanceLoaded()
  T GetInstance(System.String defaultAssetFolderPath, System.String defaultFileNameWithoutExtension)
  System.Void LoadInstanceIfAssetExists(System.String assetPath, System.String defaultFileNameWithoutExtension)
END_CLASS

CLASS: Sirenix.Utilities.GlobalConfigAttribute
TYPE:  class
TOKEN: 0x2000008
EXTENDS: Attribute
FIELDS:
  private           System.String                   assetPath  // 0x10
  private           System.Boolean                  <UseAsset>k__BackingField  // 0x18
METHODS:
  System.String get_AssetPath()
  System.Void .ctor(System.String assetPath)
END_CLASS

CLASS: Sirenix.Utilities.PersistentAssemblyAttribute
TYPE:  class
TOKEN: 0x2000009
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Sirenix.Utilities.ProjectPathFinder
TYPE:  class
TOKEN: 0x200000A
EXTENDS: ScriptableObject
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Sirenix.Utilities.SirenixAssetPaths
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  public    static readonly System.String                   OdinPath  // 0x0
  public    static readonly System.String                   SirenixAssetsPath  // 0x8
  public    static readonly System.String                   SirenixPluginPath  // 0x10
  public    static readonly System.String                   SirenixAssembliesPath  // 0x18
  public    static readonly System.String                   OdinResourcesPath  // 0x20
  public    static readonly System.String                   OdinEditorConfigsPath  // 0x28
  public    static readonly System.String                   OdinResourcesConfigsPath  // 0x30
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Sirenix.Utilities.SirenixGlobalConfigAttribute
TYPE:  class
TOKEN: 0x200000C
EXTENDS: GlobalConfigAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Sirenix.Utilities.UnityVersion
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  public    static readonly System.Int32                    Major  // 0x0
  public    static readonly System.Int32                    Minor  // 0x4
METHODS:
  System.Void .cctor()
  System.Void EnsureLoaded()
END_CLASS

