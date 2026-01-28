// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.SubsystemsModule.dll
// Classes:  14
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UnityEngine.IntegratedSubsystem
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private           UnityEngine.ISubsystemDescriptorm_SubsystemDescriptor  // 0x18
METHODS:
  System.Void SetHandle(UnityEngine.IntegratedSubsystem subsystem)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.IntegratedSubsystem`1
TYPE:  class
TOKEN: 0x2000003
EXTENDS: IntegratedSubsystem
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.IntegratedSubsystemDescriptor
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.String get_id()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.IntegratedSubsystemDescriptor`1
TYPE:  class
TOKEN: 0x2000005
EXTENDS: IntegratedSubsystemDescriptor
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.SubsystemDescriptorBindings
TYPE:  class
TOKEN: 0x2000006
FIELDS:
METHODS:
  System.String GetId(System.IntPtr descriptorPtr)
END_CLASS

CLASS: UnityEngine.ISubsystemDescriptor
TYPE:  interface
TOKEN: 0x2000007
FIELDS:
METHODS:
  System.String get_id()
END_CLASS

CLASS: UnityEngine.Subsystem
TYPE:  class
TOKEN: 0x2000008
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.SubsystemDescriptor
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  private           System.String                   <id>k__BackingField  // 0x10
METHODS:
  System.String get_id()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.Internal_SubsystemDescriptors
TYPE:  class
TOKEN: 0x200000A
FIELDS:
METHODS:
  System.Void Internal_AddDescriptor(UnityEngine.SubsystemDescriptor descriptor)
END_CLASS

CLASS: UnityEngine.SubsystemManager
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  private   static  System.Action                   beforeReloadSubsystems  // 0x0
  private   static  System.Action                   afterReloadSubsystems  // 0x8
  private   static  System.Collections.Generic.List<UnityEngine.IntegratedSubsystem>s_IntegratedSubsystems  // 0x10
  private   static  System.Collections.Generic.List<UnityEngine.SubsystemsImplementation.SubsystemWithProvider>s_StandaloneSubsystems  // 0x18
  private   static  System.Collections.Generic.List<UnityEngine.Subsystem>s_DeprecatedSubsystems  // 0x20
  private   static  System.Action                   reloadSubsytemsStarted  // 0x28
  private   static  System.Action                   reloadSubsytemsCompleted  // 0x30
METHODS:
  System.Void ReloadSubsystemsStarted()
  System.Void ReloadSubsystemsCompleted()
  System.Void InitializeIntegratedSubsystem(System.IntPtr ptr, UnityEngine.IntegratedSubsystem subsystem)
  System.Void ClearSubsystems()
  System.Void StaticConstructScriptingClassMap()
  System.Void .cctor()
  UnityEngine.IntegratedSubsystem GetIntegratedSubsystemByPtr(System.IntPtr ptr)
END_CLASS

CLASS: UnityEngine.SubsystemsImplementation.SubsystemDescriptorStore
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  private   static  System.Collections.Generic.List<UnityEngine.IntegratedSubsystemDescriptor>s_IntegratedDescriptors  // 0x0
  private   static  System.Collections.Generic.List<UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider>s_StandaloneDescriptors  // 0x8
  private   static  System.Collections.Generic.List<UnityEngine.SubsystemDescriptor>s_DeprecatedDescriptors  // 0x10
METHODS:
  System.Void InitializeManagedDescriptor(System.IntPtr ptr, UnityEngine.IntegratedSubsystemDescriptor desc)
  System.Void ClearManagedDescriptors()
  System.Void ReportSingleSubsystemAnalytics(System.String id)
  System.Void RegisterDescriptor(TDescriptor descriptor, System.Collections.Generic.List<TBaseTypeInList> storeInList)
  System.Void RegisterDeprecatedDescriptor(UnityEngine.SubsystemDescriptor descriptor)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private           System.String                   <id>k__BackingField  // 0x10
METHODS:
  System.String get_id()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.SubsystemsImplementation.SubsystemWithProvider
TYPE:  class
TOKEN: 0x200000E
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

