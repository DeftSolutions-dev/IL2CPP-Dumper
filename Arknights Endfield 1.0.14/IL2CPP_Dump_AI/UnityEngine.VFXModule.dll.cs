// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.VFXModule.dll
// Classes:  11
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UnityEngine.VFX.VFXEventAttribute
TYPE:  class
TOKEN: 0x2000002
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private           System.Boolean                  m_Owner  // 0x18
  private           UnityEngine.VFX.VisualEffectAssetm_VfxAsset  // 0x20
METHODS:
  System.Void .ctor(System.IntPtr ptr, System.Boolean owner, UnityEngine.VFX.VisualEffectAsset vfxAsset)
  UnityEngine.VFX.VFXEventAttribute CreateEventAttributeWrapper()
  System.Void SetWrapValue(System.IntPtr ptrToEventAttribute)
  System.IntPtr Internal_Create()
  UnityEngine.VFX.VFXEventAttribute Internal_InstanciateVFXEventAttribute(UnityEngine.VFX.VisualEffectAsset vfxAsset)
  System.Void Internal_InitFromAsset(UnityEngine.VFX.VisualEffectAsset vfxAsset)
  System.Void Release()
  System.Void Finalize()
  System.Void Dispose()
  System.Void Internal_Destroy(System.IntPtr ptr)
END_CLASS

CLASS: UnityEngine.VFX.VFXExpressionValues
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
METHODS:
  System.Void .ctor()
  UnityEngine.VFX.VFXExpressionValues CreateExpressionValuesWrapper(System.IntPtr ptr)
END_CLASS

CLASS: UnityEngine.VFX.VFXCameraXRSettings
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.UInt32                   viewTotal  // 0x10
  public            System.UInt32                   viewCount  // 0x14
  public            System.UInt32                   viewOffset  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.VFX.VFXManager
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private   static readonly UnityEngine.VFX.VFXCameraXRSettingskDefaultCameraXRSettings  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.VFX.VFXSpawnerCallbacks
TYPE:  class
TOKEN: 0x2000006
EXTENDS: ScriptableObject
FIELDS:
METHODS:
  System.Void OnPlay(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent)
  System.Void OnUpdate(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent)
  System.Void OnStop(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.VFX.VFXSpawnerState
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private           System.IntPtr                   m_Ptr  // 0x10
  private           System.Boolean                  m_Owner  // 0x18
  private           UnityEngine.VFX.VFXEventAttributem_WrapEventAttribute  // 0x20
METHODS:
  System.Void .ctor(System.IntPtr ptr, System.Boolean owner)
  UnityEngine.VFX.VFXSpawnerState CreateSpawnerStateWrapper()
  System.Void PrepareWrapper()
  System.Void SetWrapValue(System.IntPtr ptrToSpawnerState, System.IntPtr ptrToEventAttribute)
  System.Void Release()
  System.Void Finalize()
  System.Void Dispose()
  System.Void Internal_Destroy(System.IntPtr ptr)
END_CLASS

CLASS: UnityEngine.VFX.VisualEffectObject
TYPE:  class
TOKEN: 0x2000008
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.VFX.VisualEffectAsset
TYPE:  class
TOKEN: 0x2000009
EXTENDS: VisualEffectObject
FIELDS:
  public    static readonly System.Int32                    PlayEventID  // 0x0
  public    static readonly System.Int32                    StopEventID  // 0x4
METHODS:
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.VFX.VFXOutputEventArgs
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  private   readonly System.Int32                    <nameId>k__BackingField  // 0x10
  private   readonly UnityEngine.VFX.VFXEventAttribute<eventAttribute>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Int32 nameId, UnityEngine.VFX.VFXEventAttribute eventAttribute)
END_CLASS

CLASS: UnityEngine.VFX.VisualEffect
TYPE:  class
TOKEN: 0x200000B
EXTENDS: Behaviour
FIELDS:
  private           UnityEngine.VFX.VFXEventAttributem_cachedEventAttribute  // 0x18
  public            System.Action<UnityEngine.VFX.VFXOutputEventArgs>outputEventReceived  // 0x20
METHODS:
  UnityEngine.VFX.VisualEffectAsset get_visualEffectAsset()
  UnityEngine.VFX.VFXEventAttribute CreateVFXEventAttribute()
  UnityEngine.VFX.VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(UnityEngine.VFX.VisualEffect source)
  System.Void InvokeOutputEventReceived_Internal(UnityEngine.VFX.VisualEffect source, System.Int32 eventNameId)
END_CLASS

