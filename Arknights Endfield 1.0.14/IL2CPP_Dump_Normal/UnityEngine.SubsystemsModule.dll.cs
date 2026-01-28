// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.SubsystemsModule.dll
// Classes:  14
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace UnityEngine
{

    // TypeToken: 0x2000002
    public class IntegratedSubsystem
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private UnityEngine.ISubsystemDescriptor m_SubsystemDescriptor;        // 0x18

        // Methods
        private System.Void SetHandle(UnityEngine.IntegratedSubsystem subsystem) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000003
    public class IntegratedSubsystem`1 : IntegratedSubsystem
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class IntegratedSubsystemDescriptor, ISubsystemDescriptor
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.String get_id() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class IntegratedSubsystemDescriptor`1 : IntegratedSubsystemDescriptor
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class SubsystemDescriptorBindings
    {
        // Methods
        private System.String GetId(System.IntPtr descriptorPtr) { }

    }

    // TypeToken: 0x2000007
    public interface ISubsystemDescriptor
    {
        // Methods
        private System.String get_id() { }

    }

    // TypeToken: 0x2000008
    public class Subsystem
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class SubsystemDescriptor, ISubsystemDescriptor
    {
        // Fields
        private System.String <id>k__BackingField;        // 0x10

        // Methods
        private System.String get_id() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000A
    public class Internal_SubsystemDescriptors
    {
        // Methods
        private System.Void Internal_AddDescriptor(UnityEngine.SubsystemDescriptor descriptor) { }

    }

    // TypeToken: 0x200000B
    public class SubsystemManager
    {
        // Fields
        private static System.Action beforeReloadSubsystems;        // 0x0
        private static System.Action afterReloadSubsystems;        // 0x8
        private static System.Collections.Generic.List<UnityEngine.IntegratedSubsystem> s_IntegratedSubsystems;        // 0x10
        private static System.Collections.Generic.List<UnityEngine.SubsystemsImplementation.SubsystemWithProvider> s_StandaloneSubsystems;        // 0x18
        private static System.Collections.Generic.List<UnityEngine.Subsystem> s_DeprecatedSubsystems;        // 0x20
        private static System.Action reloadSubsytemsStarted;        // 0x28
        private static System.Action reloadSubsytemsCompleted;        // 0x30

        // Methods
        private System.Void ReloadSubsystemsStarted() { }
        private System.Void ReloadSubsystemsCompleted() { }
        private System.Void InitializeIntegratedSubsystem(System.IntPtr ptr, UnityEngine.IntegratedSubsystem subsystem) { }
        private System.Void ClearSubsystems() { }
        private System.Void StaticConstructScriptingClassMap() { }
        private System.Void .cctor() { }
        private UnityEngine.IntegratedSubsystem GetIntegratedSubsystemByPtr(System.IntPtr ptr) { }

    }

}

namespace UnityEngine.SubsystemsImplementation
{

    // TypeToken: 0x200000C
    public class SubsystemDescriptorStore
    {
        // Fields
        private static System.Collections.Generic.List<UnityEngine.IntegratedSubsystemDescriptor> s_IntegratedDescriptors;        // 0x0
        private static System.Collections.Generic.List<UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider> s_StandaloneDescriptors;        // 0x8
        private static System.Collections.Generic.List<UnityEngine.SubsystemDescriptor> s_DeprecatedDescriptors;        // 0x10

        // Methods
        private System.Void InitializeManagedDescriptor(System.IntPtr ptr, UnityEngine.IntegratedSubsystemDescriptor desc) { }
        private System.Void ClearManagedDescriptors() { }
        private System.Void ReportSingleSubsystemAnalytics(System.String id) { }
        private System.Void RegisterDescriptor(TDescriptor descriptor, System.Collections.Generic.List<TBaseTypeInList> storeInList) { }
        private System.Void RegisterDeprecatedDescriptor(UnityEngine.SubsystemDescriptor descriptor) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000D
    public class SubsystemDescriptorWithProvider, ISubsystemDescriptor
    {
        // Fields
        private System.String <id>k__BackingField;        // 0x10

        // Methods
        private System.String get_id() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000E
    public class SubsystemWithProvider
    {
        // Methods
        private System.Void .ctor() { }

    }

}

