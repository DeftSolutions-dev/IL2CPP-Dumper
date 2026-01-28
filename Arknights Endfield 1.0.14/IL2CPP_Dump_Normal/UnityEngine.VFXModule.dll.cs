// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.VFXModule.dll
// Classes:  11
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace UnityEngine.VFX
{

    // TypeToken: 0x2000002
    public class VFXEventAttribute, IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private System.Boolean m_Owner;        // 0x18
        private UnityEngine.VFX.VisualEffectAsset m_VfxAsset;        // 0x20

        // Methods
        private System.Void .ctor(System.IntPtr ptr, System.Boolean owner, UnityEngine.VFX.VisualEffectAsset vfxAsset) { }
        private UnityEngine.VFX.VFXEventAttribute CreateEventAttributeWrapper() { }
        private System.Void SetWrapValue(System.IntPtr ptrToEventAttribute) { }
        private System.IntPtr Internal_Create() { }
        private UnityEngine.VFX.VFXEventAttribute Internal_InstanciateVFXEventAttribute(UnityEngine.VFX.VisualEffectAsset vfxAsset) { }
        private System.Void Internal_InitFromAsset(UnityEngine.VFX.VisualEffectAsset vfxAsset) { }
        private System.Void Release() { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Internal_Destroy(System.IntPtr ptr) { }

    }

    // TypeToken: 0x2000003
    public class VFXExpressionValues
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.VFX.VFXExpressionValues CreateExpressionValuesWrapper(System.IntPtr ptr) { }

    }

    // TypeToken: 0x2000004
    public struct VFXCameraXRSettings
    {
        // Fields
        public System.UInt32 viewTotal;        // 0x10
        public System.UInt32 viewCount;        // 0x14
        public System.UInt32 viewOffset;        // 0x18

    }

    // TypeToken: 0x2000005
    public class VFXManager
    {
        // Fields
        private static readonly UnityEngine.VFX.VFXCameraXRSettings kDefaultCameraXRSettings;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000006
    public class VFXSpawnerCallbacks : ScriptableObject
    {
        // Methods
        private System.Void OnPlay(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent) { }
        private System.Void OnUpdate(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent) { }
        private System.Void OnStop(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class VFXSpawnerState, IDisposable
    {
        // Fields
        private System.IntPtr m_Ptr;        // 0x10
        private System.Boolean m_Owner;        // 0x18
        private UnityEngine.VFX.VFXEventAttribute m_WrapEventAttribute;        // 0x20

        // Methods
        private System.Void .ctor(System.IntPtr ptr, System.Boolean owner) { }
        private UnityEngine.VFX.VFXSpawnerState CreateSpawnerStateWrapper() { }
        private System.Void PrepareWrapper() { }
        private System.Void SetWrapValue(System.IntPtr ptrToSpawnerState, System.IntPtr ptrToEventAttribute) { }
        private System.Void Release() { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Internal_Destroy(System.IntPtr ptr) { }

    }

    // TypeToken: 0x2000008
    public class VisualEffectObject
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class VisualEffectAsset : VisualEffectObject
    {
        // Fields
        public static readonly System.Int32 PlayEventID;        // 0x0
        public static readonly System.Int32 StopEventID;        // 0x4

        // Methods
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000A
    public struct VFXOutputEventArgs
    {
        // Fields
        private readonly System.Int32 <nameId>k__BackingField;        // 0x10
        private readonly UnityEngine.VFX.VFXEventAttribute <eventAttribute>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 nameId, UnityEngine.VFX.VFXEventAttribute eventAttribute) { }

    }

    // TypeToken: 0x200000B
    public class VisualEffect : Behaviour
    {
        // Fields
        private UnityEngine.VFX.VFXEventAttribute m_cachedEventAttribute;        // 0x18
        public System.Action<UnityEngine.VFX.VFXOutputEventArgs> outputEventReceived;        // 0x20

        // Methods
        private UnityEngine.VFX.VisualEffectAsset get_visualEffectAsset() { }
        private UnityEngine.VFX.VFXEventAttribute CreateVFXEventAttribute() { }
        private UnityEngine.VFX.VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(UnityEngine.VFX.VisualEffect source) { }
        private System.Void InvokeOutputEventReceived_Internal(UnityEngine.VFX.VisualEffect source, System.Int32 eventNameId) { }

    }

}

