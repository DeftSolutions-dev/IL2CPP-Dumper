// ========================================================
// Dumped by @desirepro
// Assembly: Lua.Beyond.dll
// Classes:  51
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: StartLuaGC
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
METHODS:
END_CLASS

CLASS: WaitLuaGC
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
METHODS:
END_CLASS

CLASS: OnGCEnd
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
METHODS:
END_CLASS

CLASS: DispatchEventFunc
TYPE:  class
TOKEN: 0x2000010
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String eventName, XLua.LuaTable luaTable)
  System.IAsyncResult BeginInvoke(System.String eventName, XLua.LuaTable luaTable, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ValueType
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Lua.LuaCustomConfig.ValueTypeBool  // 0x0
  public    static  Beyond.Lua.LuaCustomConfig.ValueTypeInt  // 0x0
  public    static  Beyond.Lua.LuaCustomConfig.ValueTypeFloat  // 0x0
  public    static  Beyond.Lua.LuaCustomConfig.ValueTypeString  // 0x0
  public    static  Beyond.Lua.LuaCustomConfig.ValueTypeVector2  // 0x0
  public    static  Beyond.Lua.LuaCustomConfig.ValueTypeVector3  // 0x0
  public    static  Beyond.Lua.LuaCustomConfig.ValueTypeColor  // 0x0
  public    static  Beyond.Lua.LuaCustomConfig.ValueTypeLua  // 0x0
  public    static  Beyond.Lua.LuaCustomConfig.ValueTypeGameObject  // 0x0
  public    static  Beyond.Lua.LuaCustomConfig.ValueTypeRectTransform  // 0x0
  public    static  Beyond.Lua.LuaCustomConfig.ValueTypeAnimationCurve  // 0x0
  public    static  Beyond.Lua.LuaCustomConfig.ValueTypeLayerMask  // 0x0
  public    static  Beyond.Lua.LuaCustomConfig.ValueTypeMaterial  // 0x0
  public    static  Beyond.Lua.LuaCustomConfig.ValueTypeEnum  // 0x0
  public    static  Beyond.Lua.LuaCustomConfig.ValueTypeVector4  // 0x0
METHODS:
END_CLASS

CLASS: Item
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   description  // 0x18
  public            Beyond.Lua.LuaCustomConfig.ValueTypevalueType  // 0x20
  public            System.Boolean                  boolValue  // 0x24
  public            System.Int32                    intValue  // 0x28
  public            System.Single                   floatValue  // 0x2C
  public            System.String                   stringValue  // 0x30
  public            UnityEngine.Vector2             vector2Value  // 0x38
  public            UnityEngine.Vector3             vector3Value  // 0x40
  public            UnityEngine.Vector4             vector4Value  // 0x4C
  public            UnityEngine.Color               colorValue  // 0x5C
  public            System.String                   luaValue  // 0x70
  public            UnityEngine.GameObject          gameObjectValue  // 0x78
  public            UnityEngine.RectTransform       rectTransformValue  // 0x80
  public            UnityEngine.AnimationCurve      curveValue  // 0x88
  public            UnityEngine.LayerMask           layerMaskValue  // 0x90
  public            UnityEngine.Material            material  // 0x98
  public            System.String                   enumTypeAQName  // 0xA0
  public            System.String                   enumTypeFullName  // 0xA8
  public            System.String                   enumAssemblyName  // 0xB0
  public            System.Int32                    enumValue  // 0xB8
  public            System.String                   luaTableJson  // 0xC0
  private           System.String                   m_lastLuaValue  // 0xC8
  private           System.Type                     m_cachedEnumType  // 0xD0
METHODS:
  System.Boolean HasLuaValueChanged()
  System.Boolean ShouldSerializeLuaTableJson()
  System.Void MarkLuaValueProcessed()
  System.Type GetEnumType()
  System.Object GetEnumValueObject()
  System.Void .ctor()
END_CLASS

CLASS: TickEvent
TYPE:  class
TOKEN: 0x2000021
EXTENDS: DisposedUnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ComponentRefDict
TYPE:  class
TOKEN: 0x2000023
EXTENDS: SerializeReferenceDictionary`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CustomUIStyleInfo
TYPE:  class
TOKEN: 0x2000025
FIELDS:
  public            Beyond.UI.CustomUIStyle         style  // 0x10
  public            UnityEngine.Component           component  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: RefExtraInfo
TYPE:  class
TOKEN: 0x2000024
FIELDS:
  public            System.Collections.Generic.List<Beyond.Lua.LuaReference.RefExtraInfo.CustomUIStyleInfo>customUIStyles  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ImageContentParam
TYPE:  class
TOKEN: 0x200002E
FIELDS:
  public            System.String                   path  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Lua.CsToLuaClass
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  protected         XLua.LuaTable                   m_luaTable  // 0x10
METHODS:
  System.Void .ctor(System.String luaPath)
END_CLASS

CLASS: Beyond.Lua.LuaEventSystem
TYPE:  class
TOKEN: 0x200000F
FIELDS:
  private           Beyond.Lua.LuaEventSystem.DispatchEventFuncm_luaNotify  // 0x10
  private           System.IntPtr                   L  // 0x18
  private           XLua.ObjectTranslator           m_translator  // 0x20
  private           System.IntPtr                   m_eventNameBytesPtr  // 0x28
  private           System.Byte[]                   m_eventNameBytes  // 0x30
  private           XLua.LuaEnv                     m_luaEnv  // 0x38
  private           System.Int32                    csNotifyRef  // 0x40
METHODS:
  System.Void .ctor()
  System.Void DispatchEvent(System.String eventName)
  System.Void DispatchEvent(System.String eventName, T arg)
  System.Void DispatchEvent(System.String eventName, T0 arg0, T1 arg1)
  System.Void DispatchEvent(System.String eventName, T0 arg0, T1 arg1, T2 arg2)
  System.Void DispatchEvent(System.String eventName, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
  System.Void DispatchEvent(System.String eventName, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  System.Void PushEventName(System.String eventName)
  System.Void Dispose()
END_CLASS

CLASS: Beyond.Lua.CSharpCallLuaRegistration
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  private           Beyond.Lua.LuaEventSystem       m_luaEventSystem  // 0x10
METHODS:
  System.Void Init()
  System.Void Dispose()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Lua.LuaCustomConfig
TYPE:  class
TOKEN: 0x2000018
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Collections.Generic.List<Beyond.Lua.LuaCustomConfig.Item>itemList  // 0x18
  private           System.Collections.Generic.Dictionary<System.String,Beyond.Lua.LuaCustomConfig.Item>m_itemDict  // 0x20
METHODS:
  System.Collections.Generic.Dictionary<System.String,Beyond.Lua.LuaCustomConfig.Item> get_itemDict()
  System.Void OnBeforeSerialize()
  System.Void OnAfterDeserialize()
  System.Boolean _ProcessLuaTableItem(Beyond.Lua.LuaCustomConfig.Item item)
  System.Boolean ShouldProcessEnumItem(Beyond.Lua.LuaCustomConfig.Item item)
  System.Boolean _ProcessEnumItem(Beyond.Lua.LuaCustomConfig.Item item)
  System.Boolean _ValidateLuaTableConsistency(System.String luaCode, System.String json)
  XLua.LuaTable _JsonToLuaTableForValidation(System.String json, XLua.LuaEnv luaEnv)
  System.Void _PopulateLuaTableFromJTokenForValidation(XLua.LuaTable luaTable, Newtonsoft.Json.Linq.JToken jToken, XLua.LuaEnv luaEnv)
  System.Object _ConvertJValueToObjectForValidation(Newtonsoft.Json.Linq.JToken jValue)
  System.Boolean _CompareLuaTables(XLua.LuaTable table1, XLua.LuaTable table2)
  System.Boolean _CompareValues(System.Object value1, System.Object value2)
  System.Boolean _IsNumericType(System.Object obj)
  System.Void InitConfigTable(XLua.LuaTable configTable)
  XLua.LuaTable _JsonToLuaTable(System.String json, XLua.LuaEnv luaEnv)
  System.Void _PopulateLuaTableFromJToken(XLua.LuaTable luaTable, Newtonsoft.Json.Linq.JToken jToken)
  System.Object _ConvertJValueToObject(Newtonsoft.Json.Linq.JToken jValue)
  System.String ConvertLuaCodeToJson(System.String luaCode)
  System.String ConvertLuaTableToJson(XLua.LuaTable luaTable)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Lua.LuaDebugSocketManager
TYPE:  class
TOKEN: 0x200001D
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Lua.LoadLuaProxy
TYPE:  class
TOKEN: 0x200001E
FIELDS:
METHODS:
  System.Void _RunOnStart()
  System.Byte[] LoadLua(System.String name)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Lua.LuaMethodPointerModule
TYPE:  class
TOKEN: 0x200001F
FIELDS:
METHODS:
  System.Void _RunOnStart()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Lua.LuaManager
TYPE:  class
TOKEN: 0x2000020
EXTENDS: BaseTickManager
FIELDS:
  private   static  Beyond.Lua.LuaManager           <instance>k__BackingField  // 0x0
  private   static  System.Single                   TICK_INTERVAL  // 0x0
  private   static  System.Boolean                  ENABLE_MULTITHREAD_GC  // 0x8
  private   readonly Beyond.Lua.CSharpCallLuaRegistrationm_csCallLua  // 0x70
  private           Beyond.Gameplay.PeriodicTimer   m_envTickTimer  // 0x78
  private           Beyond.Scripts.Lua.LuaMultithreadingGCm_luaMultithreadingGC  // 0x80
  public    static  System.Boolean                  s_xluaReflectionOpt  // 0x9
  private           XLua.LuaEnv                     <luaEnv>k__BackingField  // 0x88
  public            System.Action<XLua.LuaTable,System.String,Beyond.Lua.LuaUIWidget>wrapUIWidgetFunction  // 0x90
  public            System.Action<XLua.LuaTable,System.String,Beyond.Lua.LuaReference>bindLuaRefFunction  // 0x98
  public            System.Boolean                  isQuittingApplication  // 0xA0
  public            Beyond.Lua.LuaManager.TickEvent actionTick  // 0xA8
  public            Beyond.Lua.LuaManager.TickEvent actionLateTick  // 0xB0
  public            Beyond.Lua.LuaManager.TickEvent actionTailTick  // 0xB8
  public            Beyond.Lua.LuaManager.TickEvent actionRenderDone  // 0xC0
METHODS:
  Beyond.Lua.LuaManager get_instance()
  System.Void set_instance(Beyond.Lua.LuaManager value)
  System.Void CreateInstance()
  System.Void DestroyInstance()
  System.Void .ctor()
  XLua.LuaEnv get_luaEnv()
  System.Void set_luaEnv(XLua.LuaEnv value)
  System.Boolean IsEnableMultithreadGC()
  System.Boolean IsLuaGCing()
  System.Void OnInit()
  System.String GetLuaStack()
  System.Void OnRelease()
  System.Void _ReleaseDelegateInAnotherStackFrame()
  System.Void Tick(System.Single deltaTime)
  System.Void LateTick(System.Single deltaTime)
  System.Void TailLateTick(System.Single deltaTime)
  System.String GetLuaFileRealPath(System.String modulePath)
  System.Boolean IsLuaFileExist(System.String modulePath)
  System.Int64 LoadLuaByteByFileRealPath(System.String modulePath, System.Int32& len)
  System.Byte[] LoadLua(System.String modulePath)
  System.IntPtr LoadLuaBytePtr(System.String modulePath)
  System.Byte[] LoadLuaBytes(System.String& modulePath)
  System.Void _RegisterCSharpCallLua()
  System.Void _Register3rdPartyLibraries(XLua.LuaEnv env)
  System.Void _HyperLuaLogCallback(System.IntPtr L, System.Int32 level, System.String text)
  System.Void _LuaUtilsLogCallback(System.Int32 level, System.String text)
  System.Void _OnEnvLangChanged(Beyond.GEnums.EnvLang lang)
  System.Object[] DoString(System.String code)
  System.IntPtr GetLuaState()
  System.Void ClearAllUnityObjectUserdata()
  System.Void _OnRenderDone(HG.Rendering.Runtime.HGRenderPipeCallbackArgs args)
  System.Void _OnRenderDone()
  System.Boolean AddLuaEventAfterGCDo(UnityEngine.Events.UnityAction action)
  System.Void RemoveLuaEventAfterGCDo(UnityEngine.Events.UnityAction action)
  System.Void AddOnceLuaEventAfterGCDo(UnityEngine.Events.UnityAction action)
  System.Int32 LuaCalculateABPathHash(System.IntPtr L)
  System.Void CasterStringPathHash(System.IntPtr L, System.Int32 index, Beyond.Resource.StringPathHash& o)
  System.Boolean CheckStringPathHash(System.IntPtr L, System.Int32 index)
  Beyond.FrameTickGroup get_frameTickGroup()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  System.Void <>iFixBaseProxy_TailLateTick(System.Single P0)
END_CLASS

CLASS: Beyond.Lua.LuaReference
TYPE:  class
TOKEN: 0x2000022
EXTENDS: MonoBehaviour
FIELDS:
  public            Beyond.Lua.LuaReference.ComponentRefDictrefDict  // 0x18
  public            Beyond.SerializeReferenceDictionary<System.String,Beyond.Lua.LuaReference.RefExtraInfo>refExtraInfoDict  // 0x20
  public            System.Boolean                  isRootRef  // 0x28
  public            System.Collections.Generic.List<Beyond.Lua.LuaReference>subReferences  // 0x30
  private           XLua.LuaTable                   m_table  // 0x38
METHODS:
  System.Void Reset()
  System.Void OnDestroy()
  System.Void _UnBindFromXluaRef()
  System.Void BindToLua(XLua.LuaTable table)
  System.Void _BindSelfReferences(XLua.LuaTable table)
  System.Boolean ContainsGameObject(UnityEngine.GameObject obj, System.Boolean recursive)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Lua.LuaTestReflectionOptStruct
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Int32                    a  // 0x10
  public            System.String                   b  // 0x18
  public            System.Int64                    l  // 0x20
  public            System.UInt64                   ul  // 0x28
  public            System.Single                   f  // 0x30
  public            System.Double                   d  // 0x38
  public            System.Boolean                  bl  // 0x40
METHODS:
  System.Int32 get_a1()
  System.String get_b1()
  System.Int64 get_l1()
  System.UInt64 get_ul1()
  System.Single get_f1()
  System.Double get_d1()
  System.Boolean get_bl1()
  System.Void .ctor(System.Int32 a, System.String b, System.Int64 l, System.UInt64 ul, System.Single f, System.Double d, System.Boolean bl)
  System.Int32 TestInt(System.Int32 a)
  System.Void TestVoid()
  System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct testStruct)
  System.Void TestStructParam2(Beyond.Lua.LuaTestReflectionOptStruct& testStruct)
  System.Object TestReturnObj()
  System.Void TestObjParam(System.Object obj)
END_CLASS

CLASS: Beyond.Lua.LuaTestReflectionOptStruct2
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  public            System.Int32                    a  // 0x10
  public            System.String                   b  // 0x18
  public            System.Int64                    l  // 0x20
  public            System.UInt64                   ul  // 0x28
  public            System.Single                   f  // 0x30
  public            System.Double                   d  // 0x38
  public            System.Boolean                  bl  // 0x40
METHODS:
  System.Int32 get_a1()
  System.String get_b1()
  System.Int64 get_l1()
  System.UInt64 get_ul1()
  System.Single get_f1()
  System.Double get_d1()
  System.Boolean get_bl1()
  System.Int32 TestInt(System.Int32 a)
  System.Void TestVoid()
  System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct2 testStruct)
  System.Void TestStructParam2(Beyond.Lua.LuaTestReflectionOptStruct2& testStruct)
  System.Object TestReturnObj()
  System.Void TestObjParam(System.Object obj)
END_CLASS

CLASS: Beyond.Lua.ETestEnum
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Lua.ETestEnum            Test1  // 0x0
  public    static  Beyond.Lua.ETestEnum            Test2  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Lua.LuaTestReflectionOpt2
TYPE:  class
TOKEN: 0x200002A
FIELDS:
  public            System.Collections.Generic.List<System.Int32>TestList  // 0x10
  public            System.Collections.Generic.Dictionary<System.Int32,System.String>TestDict  // 0x18
METHODS:
  System.Void TestVoid()
  System.Int32 TestInt(System.Int32 a)
  System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct testStruct)
  System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct2 testStruct)
  System.Void TestStructParam2(Beyond.Lua.LuaTestReflectionOptStruct& testStruct)
  System.Object TestReturnObj()
  System.Void TestObjParam(System.Object obj)
  System.Void TestEnum(Beyond.Lua.ETestEnum e)
  Beyond.Lua.ETestEnum TestReturnEnum()
  Beyond.Lua.LuaTestReflectionOptStruct TestStruct(Beyond.Lua.LuaTestReflectionOptStruct a)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Lua.LuaTestReflectionOpt
TYPE:  class
TOKEN: 0x200002B
FIELDS:
  public            System.Collections.Generic.List<System.Int32>TestList  // 0x10
  public            System.Collections.Generic.Dictionary<System.Int32,System.String>TestDict  // 0x18
METHODS:
  System.Void TestVoid()
  System.Int32 TestInt(System.Int32 a)
  System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct testStruct)
  System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct2 testStruct)
  System.Void TestStructParam2(Beyond.Lua.LuaTestReflectionOptStruct& testStruct)
  System.Object TestReturnObj()
  System.Void TestObjParam(System.Object obj)
  System.Void TestEnum(Beyond.Lua.ETestEnum e)
  Beyond.Lua.ETestEnum TestReturnEnum()
  Beyond.Lua.LuaTestReflectionOptStruct TestStruct(Beyond.Lua.LuaTestReflectionOptStruct a)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Lua.LuaUIWidget
TYPE:  class
TOKEN: 0x200002C
EXTENDS: MonoBehaviour
FIELDS:
  public            System.String                   id  // 0x18
  public            System.Boolean                  isEmbeddedWidget  // 0x20
  private           XLua.LuaTable                   <table>k__BackingField  // 0x28
  public            XLua.LuaFunction                onEnable  // 0x30
  public            XLua.LuaFunction                onDisable  // 0x38
  public            XLua.LuaFunction                onDestroy  // 0x40
METHODS:
  XLua.LuaTable get_table()
  System.Void set_table(XLua.LuaTable value)
  System.Void Reset()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void ClearComponent()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Lua.UtilsForLua
TYPE:  class
TOKEN: 0x200002D
FIELDS:
  private   static  UnityEngine.Vector3[]           s_worldCorners  // 0x0
METHODS:
  UnityEngine.GameObject CreateObject(UnityEngine.GameObject asset)
  UnityEngine.GameObject CreateObject(UnityEngine.GameObject asset, UnityEngine.Transform parent)
  UnityEngine.GameObject CreateObject(UnityEngine.GameObject asset, UnityEngine.GameObject parent)
  System.Void UIContainerResize(UnityEngine.Transform container, System.Int32 size, System.Int32 templateIndex)
  System.Int32 TurnOffLayer(System.Int32 value, System.String layerName)
  System.Int32 TurnOnLayer(System.Int32 value, System.String layerName)
  System.Int32 ToggleLayer(System.Int32 value, System.String layerName)
  System.Void SetPosX(UnityEngine.Transform t, System.Single value)
  System.Void SetPosY(UnityEngine.Transform t, System.Single value)
  System.Void SetPosZ(UnityEngine.Transform t, System.Single value)
  System.Void SetRotX(UnityEngine.Transform t, System.Single value)
  System.Void SetRotY(UnityEngine.Transform t, System.Single value)
  System.Void SetRotZ(UnityEngine.Transform t, System.Single value)
  System.Void SetScaleX(UnityEngine.Transform t, System.Single value)
  System.Void SetScaleY(UnityEngine.Transform t, System.Single value)
  System.Void SetScaleZ(UnityEngine.Transform t, System.Single value)
  System.Void ClearUIComponents(UnityEngine.GameObject gameObject)
  System.Boolean RayCast(UnityEngine.RaycastHit& hitInfo, UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction interaction)
  System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction interaction)
  UnityEngine.Bounds GetRectTransformBounds(UnityEngine.RectTransform transform)
  UnityEngine.Rect RectTransformToScreenRect(UnityEngine.RectTransform rectTransform, UnityEngine.Camera uiCamera)
  UnityEngine.Vector3 GetRectTransformCenterPosition(UnityEngine.RectTransform rectTransform)
  UnityEngine.Bounds CalcBoundOfRectTransform(UnityEngine.RectTransform transform, UnityEngine.RectTransform local)
  System.Boolean IsMarkable(Beyond.Gameplay.Core.Entity obj)
  System.Collections.Generic.List<System.String> GetStringList()
  System.Single EntityDistance(Beyond.Gameplay.Core.Entity a, Beyond.Gameplay.Core.Entity b)
  System.Void OpenAccountCenter()
  System.Void ExitGame()
  System.String GetCurrentUID()
  System.Boolean StartPayment(System.String productId, System.String signParams)
  System.Boolean TryGetCharacterVolume(UnityEngine.Rendering.Volume volume, HG.Rendering.Runtime.HGCharacterVolume& hgCharacterVolume)
  System.Single GetAnimationCurveLength(UnityEngine.AnimationCurve curve)
  DG.Tweening.Tweener TweenTo(System.Single from, System.Single to, System.Single duration, XLua.LuaFunction setter)
  System.Boolean IsNull(UnityEngine.Object o)
  Beyond.Lua.UtilsForLua.ImageContentParam ParseImageContent(System.String xml)
  System.Void ReturnToLogin()
  System.Void QuitGame(System.Int32 exitCode)
  System.Void ToggleCharInfoInUpgradePanelOption(System.Boolean isIn)
  System.Void ToggleWeaponInUpgradePanelOption(System.Boolean isIn)
  Cinemachine.CinemachineTransposer GetCinemachineTransposer(Cinemachine.CinemachineVirtualCamera vcam)
  Cinemachine.CinemachineComposer GetCinemachineComposer(Cinemachine.CinemachineVirtualCamera vcam)
  CinemachineCameraOffset GetOrAddCinemachineCameraOffset(Cinemachine.CinemachineVirtualCamera vcam)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Scripts.Lua.ELuaMultithreadingGCState
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Scripts.Lua.ELuaMultithreadingGCStateMinorGC  // 0x0
  public    static  Beyond.Scripts.Lua.ELuaMultithreadingGCStateMajorGC  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Scripts.Lua.OnGCEndEvent
TYPE:  class
TOKEN: 0x2000008
EXTENDS: UnityEvent
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Scripts.Lua.LuaMultithreadingGC
TYPE:  class
TOKEN: 0x2000009
FIELDS:
  public    static  System.Int32                    threadGcCount  // 0x0
  public    static  System.Int32                    mainThreadSignalCount  // 0x4
  public    static  System.Int32                    mainTheadForceGCCount  // 0x8
  public    static  System.Int32                    gcMarkCount  // 0xC
  public    static  System.Int32                    gcSweepCount  // 0x10
  private           System.Threading.Thread         m_gcThread  // 0x10
  private           System.Threading.AutoResetEvent m_workSignal  // 0x18
  private           XLua.LuaEnv                     m_luaEnv  // 0x20
  private           System.Int32                    m_lastMajorGCMemory  // 0x28
  private           System.Int32                    m_lastMinorGCMemory  // 0x2C
  private           System.Int32                    m_badGCCounter  // 0x30
  private           System.Int32                    m_badGCThreshold  // 0x34
  private           System.Single                   m_genGcIncreaseThreshold  // 0x38
  private           System.Single                   m_genGcIncreaseThresholdDiff  // 0x3C
  private           System.Int32                    m_incGCThreshold  // 0x40
  private           Beyond.Scripts.Lua.OnGCEndEvent m_afterGCEvent  // 0x48
  private           System.Collections.Generic.List<UnityEngine.Events.UnityAction>m_afterGCEventOnceEvents  // 0x50
  public            Beyond.Scripts.Lua.ELuaMultithreadingGCStategcState  // 0x58
  public            System.Int64                    mainThreadWait  // 0x60
  public            System.Int64                    gcThreadStop  // 0x68
  public            System.Boolean                  stop  // 0x70
  public            System.Boolean                  isRunning  // 0x71
  private           XLua.LuaDLL.lua_Hook            hook  // 0x78
  private   static  XLua.LuaDLL.lua_Hook            oldHook  // 0x18
  private   static  System.Int32                    oldHookMask  // 0x20
  private           System.Boolean                  haveRunOnce  // 0x80
  private   static readonly Unity.Profiling.ProfilerMarker  PROFILER_MARKER_START_GC  // 0x28
  private   static readonly Unity.Profiling.ProfilerMarker  PROFILER_MARKER_THREAD_NOTIFY  // 0x30
METHODS:
  System.Void .ctor(XLua.LuaEnv luaEnv)
  System.Void StartGCAsync()
  System.Void NormalStop()
  System.Void ForceStopAsyncGC()
  System.Void MainThreadWait()
  System.Void AddLuaAfterGCEvent(UnityEngine.Events.UnityAction action)
  System.Void AddLuaAfterGCOnceEvent(UnityEngine.Events.UnityAction action)
  System.Void RemoveLuaAfterGCEvent(UnityEngine.Events.UnityAction action)
  System.Void _OnGCEnd()
  System.Void _Init()
  System.Void _Dispose()
  System.Int32 _FindLoopSystemIndex(UnityEngine.LowLevel.PlayerLoopSystem[] playerLoopList, System.String typeName)
  System.Int32 LuaHook(System.IntPtr L, XLua.lua_debug& ar)
  System.Void _UpdateOldHook()
  System.Boolean _DoLock()
  System.Boolean _DoGc(System.Int32 work)
  System.Void _GCMethodWrapper()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000006
EXTENDS: Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000030
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.Void __Gen_Wrap_0(System.Object P0)
  System.Boolean __Gen_Wrap_1(UnityEngine.LowLevel.PlayerLoopSystem P0)
  System.Void __Gen_Wrap_2(System.Object P0, System.Object P1)
  System.Int32 __Gen_Wrap_3(System.Object P0, System.Object P1)
  System.Int32 __Gen_Wrap_4(System.IntPtr P0, XLua.lua_debug& P1)
  System.Boolean __Gen_Wrap_5(System.Object P0)
  System.Boolean __Gen_Wrap_6(System.Object P0, System.Int32 P1)
  System.Boolean __Gen_Wrap_7()
  System.Void __Gen_Wrap_8()
  System.Collections.Generic.Dictionary<System.String,Beyond.Lua.LuaCustomConfig.Item> __Gen_Wrap_9(System.Object P0)
  System.String __Gen_Wrap_10(System.Object P0)
  System.Object __Gen_Wrap_11(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_12(System.Object P0, System.Object P1, System.Object P2, System.Object P3)
  XLua.LuaTable __Gen_Wrap_13(System.Object P0, System.Object P1, System.Object P2)
  System.Boolean __Gen_Wrap_14(System.Object P0, System.Object P1)
  System.Boolean __Gen_Wrap_15(System.Object P0, System.Object P1, System.Object P2)
  System.Void __Gen_Wrap_16(System.Object P0, System.Object P1, System.Object P2)
  System.Type __Gen_Wrap_17(System.Object P0)
  System.Object __Gen_Wrap_18(System.Object P0)
  System.Byte[] __Gen_Wrap_19(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_20(System.Object P0, HG.Rendering.Runtime.HGRenderPipeCallbackArgs P1)
  System.String __Gen_Wrap_21()
  System.Void __Gen_Wrap_22(System.IntPtr P0, System.Int32 P1, System.Object P2)
  System.Void __Gen_Wrap_23(System.Int32 P0, System.Object P1)
  System.Byte[] __Gen_Wrap_24(System.Object P0, System.String& P1)
  System.Int32 __Gen_Wrap_25(System.IntPtr P0)
  System.Void __Gen_Wrap_26(System.IntPtr P0, System.Int32 P1, Beyond.Resource.StringPathHash& P2)
  System.Boolean __Gen_Wrap_27(System.IntPtr P0, System.Int32 P1)
  System.Void __Gen_Wrap_28(System.Object P0, Beyond.GEnums.EnvLang P1)
  System.Void __Gen_Wrap_29(System.Object P0, System.Single P1)
  System.String __Gen_Wrap_30(System.Object P0, System.Object P1)
  System.Int64 __Gen_Wrap_31(System.Object P0, System.Object P1, System.Int32& P2)
  System.IntPtr __Gen_Wrap_32(System.Object P0, System.Object P1)
  System.Object[] __Gen_Wrap_33(System.Object P0, System.Object P1)
  System.IntPtr __Gen_Wrap_34(System.Object P0)
  System.Boolean __Gen_Wrap_35(Beyond.Lua.LuaReference P0)
  System.Boolean __Gen_Wrap_36(System.Object P0, System.Object P1, System.Boolean P2)
  System.Int32 __Gen_Wrap_37(Beyond.Lua.LuaTestReflectionOptStruct& P0, System.Int32 P1)
  System.Void __Gen_Wrap_38(Beyond.Lua.LuaTestReflectionOptStruct& P0)
  System.Void __Gen_Wrap_39(Beyond.Lua.LuaTestReflectionOptStruct& P0, Beyond.Lua.LuaTestReflectionOptStruct P1)
  System.Void __Gen_Wrap_40(Beyond.Lua.LuaTestReflectionOptStruct& P0, Beyond.Lua.LuaTestReflectionOptStruct& P1)
  System.Object __Gen_Wrap_41(Beyond.Lua.LuaTestReflectionOptStruct& P0)
  System.Void __Gen_Wrap_42(Beyond.Lua.LuaTestReflectionOptStruct& P0, System.Object P1)
  System.Int32 __Gen_Wrap_43(Beyond.Lua.LuaTestReflectionOptStruct2& P0, System.Int32 P1)
  System.Void __Gen_Wrap_44(Beyond.Lua.LuaTestReflectionOptStruct2& P0)
  System.Void __Gen_Wrap_45(Beyond.Lua.LuaTestReflectionOptStruct2& P0, Beyond.Lua.LuaTestReflectionOptStruct2 P1)
  System.Void __Gen_Wrap_46(Beyond.Lua.LuaTestReflectionOptStruct2& P0, Beyond.Lua.LuaTestReflectionOptStruct2& P1)
  System.Object __Gen_Wrap_47(Beyond.Lua.LuaTestReflectionOptStruct2& P0)
  System.Void __Gen_Wrap_48(Beyond.Lua.LuaTestReflectionOptStruct2& P0, System.Object P1)
  System.Int32 __Gen_Wrap_49(System.Object P0, System.Int32 P1)
  System.Void __Gen_Wrap_50(System.Object P0, Beyond.Lua.LuaTestReflectionOptStruct P1)
  System.Void __Gen_Wrap_51(System.Object P0, Beyond.Lua.LuaTestReflectionOptStruct2 P1)
  System.Void __Gen_Wrap_52(System.Object P0, Beyond.Lua.LuaTestReflectionOptStruct& P1)
  System.Void __Gen_Wrap_53(System.Object P0, Beyond.Lua.ETestEnum P1)
  Beyond.Lua.ETestEnum __Gen_Wrap_54(System.Object P0)
  Beyond.Lua.LuaTestReflectionOptStruct __Gen_Wrap_55(System.Object P0, Beyond.Lua.LuaTestReflectionOptStruct P1)
  UnityEngine.GameObject __Gen_Wrap_56(System.Object P0)
  UnityEngine.GameObject __Gen_Wrap_57(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_58(System.Object P0, System.Int32 P1, System.Int32 P2)
  System.Int32 __Gen_Wrap_59(System.Int32 P0, System.Object P1)
  System.Boolean __Gen_Wrap_60(UnityEngine.RaycastHit& P0, UnityEngine.Ray P1, System.Single P2, System.Int32 P3, UnityEngine.QueryTriggerInteraction P4)
  System.Int32 __Gen_Wrap_61(UnityEngine.Ray P0, System.Object P1, System.Single P2, System.Int32 P3, UnityEngine.QueryTriggerInteraction P4)
  UnityEngine.Bounds __Gen_Wrap_62(System.Object P0)
  UnityEngine.Rect __Gen_Wrap_63(System.Object P0, System.Object P1)
  UnityEngine.Vector3 __Gen_Wrap_64(System.Object P0)
  UnityEngine.Bounds __Gen_Wrap_65(System.Object P0, System.Object P1)
  System.Collections.Generic.List<System.String> __Gen_Wrap_66()
  System.Single __Gen_Wrap_67(System.Object P0, System.Object P1)
  System.Boolean __Gen_Wrap_68(System.Object P0, HG.Rendering.Runtime.HGCharacterVolume& P1)
  System.Single __Gen_Wrap_69(System.Object P0)
  System.Single __Gen_Wrap_70()
  System.Void __Gen_Wrap_71(System.Single P0)
  DG.Tweening.Tweener __Gen_Wrap_72(System.Single P0, System.Single P1, System.Single P2, System.Object P3)
  Beyond.Lua.UtilsForLua.ImageContentParam __Gen_Wrap_73(System.Object P0)
  System.Void __Gen_Wrap_74(System.Int32 P0)
  System.Void __Gen_Wrap_75(System.Boolean P0)
  Cinemachine.CinemachineTransposer __Gen_Wrap_76(System.Object P0)
  Cinemachine.CinemachineComposer __Gen_Wrap_77(System.Object P0)
  CinemachineCameraOffset __Gen_Wrap_78(System.Object P0)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000031
EXTENDS: AnonymousStorey
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000032
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine)
  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  System.Boolean IsPatched(System.Int32 id)
  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  System.Object CreateWrapper(System.Int32 id)
  System.Object InitWrapperArray(System.Int32 len)
  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
END_CLASS

CLASS: IFix.IDMAP0
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-Scripts-Lua-LuaMultithreadingGC-StartGCAsync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Lua-LuaMultithreadingGC-_OnGCEnd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Lua-LuaMultithreadingGC-_Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Lua-LuaMultithreadingGC-NormalStop0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Lua-LuaMultithreadingGC-ForceStopAsyncGC0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Lua-LuaMultithreadingGC-MainThreadWait0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Lua-LuaMultithreadingGC-AddLuaAfterGCEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Lua-LuaMultithreadingGC-AddLuaAfterGCOnceEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Lua-LuaMultithreadingGC-RemoveLuaAfterGCEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Lua-LuaMultithreadingGC-_FindLoopSystemIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Lua-LuaMultithreadingGC-_Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Lua-LuaMultithreadingGC-LuaHook0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Lua-LuaMultithreadingGC-_UpdateOldHook0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Lua-LuaMultithreadingGC-_DoLock0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Lua-LuaMultithreadingGC-_DoGc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-Lua-LuaMultithreadingGC-_GCMethodWrapper0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaEventSystem-PushEventName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-IsLuaGCing0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-AddOnceLuaEventAfterGCDo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaEventSystem-DispatchEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaEventSystem-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-CSharpCallLuaRegistration-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-CSharpCallLuaRegistration-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-get_itemDict0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-OnBeforeSerialize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-OnAfterDeserialize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-Item-MarkLuaValueProcessed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-ConvertLuaTableToJson0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-ConvertLuaCodeToJson0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-_ConvertJValueToObjectForValidation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-_PopulateLuaTableFromJTokenForValidation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-_JsonToLuaTableForValidation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-_IsNumericType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-_CompareValues0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-_CompareLuaTables0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-_ValidateLuaTableConsistency0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-_ProcessLuaTableItem0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-ShouldProcessEnumItem0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-_ProcessEnumItem0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-_ConvertJValueToObject0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-_PopulateLuaTableFromJToken0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-_JsonToLuaTable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-Item-GetEnumType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-Item-GetEnumValueObject0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-InitConfigTable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-Item-HasLuaValueChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaCustomConfig-Item-ShouldSerializeLuaTableJson0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LoadLuaProxy-_RunOnStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LoadLuaProxy-LoadLua0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaMethodPointerModule-_RunOnStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-CreateInstance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-DestroyInstance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-IsEnableMultithreadGC0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-_OnRenderDone0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-_OnRenderDone1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-GetLuaStack0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-_HyperLuaLogCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-_LuaUtilsLogCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-_Register3rdPartyLibraries0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-LoadLuaBytes0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-LuaCalculateABPathHash0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-CasterStringPathHash0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-CheckStringPathHash0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-_RegisterCSharpCallLua0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-OnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-_OnEnvLangChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-_ReleaseDelegateInAnotherStackFrame0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-TailLateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-GetLuaFileRealPath0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-IsLuaFileExist0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-LoadLuaByteByFileRealPath0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-LoadLua0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-LoadLuaBytePtr0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-DoString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-GetLuaState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-ClearAllUnityObjectUserdata0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-AddLuaEventAfterGCDo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaManager-RemoveLuaEventAfterGCDo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaReference-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaReference-_UnBindFromXluaRef0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaReference-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaReference-_BindSelfReferences0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaReference-BindToLua0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaReference-ContainsGameObject0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOptStruct-TestInt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOptStruct-TestVoid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOptStruct-TestStructParam0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOptStruct-TestStructParam20  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOptStruct-TestReturnObj0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOptStruct-TestObjParam0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOptStruct2-TestInt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOptStruct2-TestVoid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOptStruct2-TestStructParam0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOptStruct2-TestStructParam20  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOptStruct2-TestReturnObj0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOptStruct2-TestObjParam0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt2-TestVoid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt2-TestInt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt2-TestStructParam0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt2-TestStructParam1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt2-TestStructParam20  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt2-TestReturnObj0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt2-TestObjParam0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt2-TestEnum0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt2-TestReturnEnum0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt2-TestStruct0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt-TestVoid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt-TestInt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt-TestStructParam0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt-TestStructParam1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt-TestStructParam20  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt-TestReturnObj0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt-TestObjParam0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt-TestEnum0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt-TestReturnEnum0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaTestReflectionOpt-TestStruct0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaUIWidget-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaUIWidget-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaUIWidget-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaUIWidget-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-LuaUIWidget-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-CreateObject0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-CreateObject1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-CreateObject2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-UIContainerResize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-TurnOffLayer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-TurnOnLayer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-ToggleLayer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-SetPosX0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-SetPosY0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-SetPosZ0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-SetRotX0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-SetRotY0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-SetRotZ0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-SetScaleX0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-SetScaleY0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-SetScaleZ0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-ClearUIComponents0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-RayCast0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-RaycastNonAlloc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-GetRectTransformBounds0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-RectTransformToScreenRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-GetRectTransformCenterPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-CalcBoundOfRectTransform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-IsMarkable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-GetStringList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-EntityDistance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-OpenAccountCenter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-ExitGame0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-GetCurrentUID0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-StartPayment0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-TryGetCharacterVolume0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-GetAnimationCurveLength0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-TweenTo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-IsNull0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-ParseImageContent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-ReturnToLogin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-QuitGame0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-ToggleCharInfoInUpgradePanelOption0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-ToggleWeaponInUpgradePanelOption0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-GetCinemachineTransposer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-GetCinemachineComposer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Lua-UtilsForLua-GetOrAddCinemachineCameraOffset0  // 0x0
METHODS:
END_CLASS

