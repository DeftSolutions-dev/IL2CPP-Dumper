// ========================================================
// Dumped by @desirepro
// Assembly: Lua.Beyond.dll
// Classes:  51
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000A
    public struct StartLuaGC
    {
    }

    // TypeToken: 0x200000B
    public struct WaitLuaGC
    {
    }

    // TypeToken: 0x200000C
    public struct OnGCEnd
    {
    }

    // TypeToken: 0x2000010
    public class DispatchEventFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String eventName, XLua.LuaTable luaTable) { }
        private System.IAsyncResult BeginInvoke(System.String eventName, XLua.LuaTable luaTable, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000019
    public struct ValueType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Lua.LuaCustomConfig.ValueType Bool;        // 0x0
        public static Beyond.Lua.LuaCustomConfig.ValueType Int;        // 0x0
        public static Beyond.Lua.LuaCustomConfig.ValueType Float;        // 0x0
        public static Beyond.Lua.LuaCustomConfig.ValueType String;        // 0x0
        public static Beyond.Lua.LuaCustomConfig.ValueType Vector2;        // 0x0
        public static Beyond.Lua.LuaCustomConfig.ValueType Vector3;        // 0x0
        public static Beyond.Lua.LuaCustomConfig.ValueType Color;        // 0x0
        public static Beyond.Lua.LuaCustomConfig.ValueType Lua;        // 0x0
        public static Beyond.Lua.LuaCustomConfig.ValueType GameObject;        // 0x0
        public static Beyond.Lua.LuaCustomConfig.ValueType RectTransform;        // 0x0
        public static Beyond.Lua.LuaCustomConfig.ValueType AnimationCurve;        // 0x0
        public static Beyond.Lua.LuaCustomConfig.ValueType LayerMask;        // 0x0
        public static Beyond.Lua.LuaCustomConfig.ValueType Material;        // 0x0
        public static Beyond.Lua.LuaCustomConfig.ValueType Enum;        // 0x0
        public static Beyond.Lua.LuaCustomConfig.ValueType Vector4;        // 0x0

    }

    // TypeToken: 0x200001A
    public class Item, ILuaCallCSharp
    {
        // Fields
        public System.String name;        // 0x10
        public System.String description;        // 0x18
        public Beyond.Lua.LuaCustomConfig.ValueType valueType;        // 0x20
        public System.Boolean boolValue;        // 0x24
        public System.Int32 intValue;        // 0x28
        public System.Single floatValue;        // 0x2C
        public System.String stringValue;        // 0x30
        public UnityEngine.Vector2 vector2Value;        // 0x38
        public UnityEngine.Vector3 vector3Value;        // 0x40
        public UnityEngine.Vector4 vector4Value;        // 0x4C
        public UnityEngine.Color colorValue;        // 0x5C
        public System.String luaValue;        // 0x70
        public UnityEngine.GameObject gameObjectValue;        // 0x78
        public UnityEngine.RectTransform rectTransformValue;        // 0x80
        public UnityEngine.AnimationCurve curveValue;        // 0x88
        public UnityEngine.LayerMask layerMaskValue;        // 0x90
        public UnityEngine.Material material;        // 0x98
        public System.String enumTypeAQName;        // 0xA0
        public System.String enumTypeFullName;        // 0xA8
        public System.String enumAssemblyName;        // 0xB0
        public System.Int32 enumValue;        // 0xB8
        public System.String luaTableJson;        // 0xC0
        private System.String m_lastLuaValue;        // 0xC8
        private System.Type m_cachedEnumType;        // 0xD0

        // Methods
        private System.Boolean HasLuaValueChanged() { }
        private System.Boolean ShouldSerializeLuaTableJson() { }
        private System.Void MarkLuaValueProcessed() { }
        private System.Type GetEnumType() { }
        private System.Object GetEnumValueObject() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public class TickEvent : DisposedUnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000023
    public class ComponentRefDict : SerializeReferenceDictionary`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000025
    public class CustomUIStyleInfo
    {
        // Fields
        public Beyond.UI.CustomUIStyle style;        // 0x10
        public UnityEngine.Component component;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000024
    public class RefExtraInfo
    {
        // Fields
        public System.Collections.Generic.List<Beyond.Lua.LuaReference.RefExtraInfo.CustomUIStyleInfo> customUIStyles;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002E
    public class ImageContentParam
    {
        // Fields
        public System.String path;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

namespace Beyond.Lua
{

    // TypeToken: 0x200000E
    public class CsToLuaClass
    {
        // Fields
        protected XLua.LuaTable m_luaTable;        // 0x10

        // Methods
        private System.Void .ctor(System.String luaPath) { }

    }

    // TypeToken: 0x200000F
    public class LuaEventSystem, ILuaEventSystem, ICommonCallLua, IDisposable
    {
        // Fields
        private Beyond.Lua.LuaEventSystem.DispatchEventFunc m_luaNotify;        // 0x10
        private System.IntPtr L;        // 0x18
        private XLua.ObjectTranslator m_translator;        // 0x20
        private System.IntPtr m_eventNameBytesPtr;        // 0x28
        private System.Byte[] m_eventNameBytes;        // 0x30
        private XLua.LuaEnv m_luaEnv;        // 0x38
        private System.Int32 csNotifyRef;        // 0x40

        // Methods
        private System.Void .ctor() { }
        private System.Void DispatchEvent(System.String eventName) { }
        private System.Void DispatchEvent(System.String eventName, T arg) { }
        private System.Void DispatchEvent(System.String eventName, T0 arg0, T1 arg1) { }
        private System.Void DispatchEvent(System.String eventName, T0 arg0, T1 arg1, T2 arg2) { }
        private System.Void DispatchEvent(System.String eventName, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
        private System.Void DispatchEvent(System.String eventName, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        private System.Void PushEventName(System.String eventName) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000017
    public class CSharpCallLuaRegistration
    {
        // Fields
        private Beyond.Lua.LuaEventSystem m_luaEventSystem;        // 0x10

        // Methods
        private System.Void Init() { }
        private System.Void Dispose() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000018
    public class LuaCustomConfig : MonoBehaviour, ILuaCallCSharp, ISerializationCallbackReceiver
    {
        // Fields
        public System.Collections.Generic.List<Beyond.Lua.LuaCustomConfig.Item> itemList;        // 0x18
        private System.Collections.Generic.Dictionary<System.String,Beyond.Lua.LuaCustomConfig.Item> m_itemDict;        // 0x20

        // Methods
        private System.Collections.Generic.Dictionary<System.String,Beyond.Lua.LuaCustomConfig.Item> get_itemDict() { }
        private System.Void OnBeforeSerialize() { }
        private System.Void OnAfterDeserialize() { }
        private System.Boolean _ProcessLuaTableItem(Beyond.Lua.LuaCustomConfig.Item item) { }
        private System.Boolean ShouldProcessEnumItem(Beyond.Lua.LuaCustomConfig.Item item) { }
        private System.Boolean _ProcessEnumItem(Beyond.Lua.LuaCustomConfig.Item item) { }
        private System.Boolean _ValidateLuaTableConsistency(System.String luaCode, System.String json) { }
        private XLua.LuaTable _JsonToLuaTableForValidation(System.String json, XLua.LuaEnv luaEnv) { }
        private System.Void _PopulateLuaTableFromJTokenForValidation(XLua.LuaTable luaTable, Newtonsoft.Json.Linq.JToken jToken, XLua.LuaEnv luaEnv) { }
        private System.Object _ConvertJValueToObjectForValidation(Newtonsoft.Json.Linq.JToken jValue) { }
        private System.Boolean _CompareLuaTables(XLua.LuaTable table1, XLua.LuaTable table2) { }
        private System.Boolean _CompareValues(System.Object value1, System.Object value2) { }
        private System.Boolean _IsNumericType(System.Object obj) { }
        private System.Void InitConfigTable(XLua.LuaTable configTable) { }
        private XLua.LuaTable _JsonToLuaTable(System.String json, XLua.LuaEnv luaEnv) { }
        private System.Void _PopulateLuaTableFromJToken(XLua.LuaTable luaTable, Newtonsoft.Json.Linq.JToken jToken) { }
        private System.Object _ConvertJValueToObject(Newtonsoft.Json.Linq.JToken jValue) { }
        private System.String ConvertLuaCodeToJson(System.String luaCode) { }
        private System.String ConvertLuaTableToJson(XLua.LuaTable luaTable) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001D
    public class LuaDebugSocketManager : MonoBehaviour
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001E
    public class LoadLuaProxy, ILoadLuaProxy
    {
        // Methods
        private System.Void _RunOnStart() { }
        private System.Byte[] LoadLua(System.String name) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public class LuaMethodPointerModule
    {
        // Methods
        private System.Void _RunOnStart() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000020
    public class LuaManager : BaseTickManager, ILuaProxy
    {
        // Fields
        private static Beyond.Lua.LuaManager <instance>k__BackingField;        // 0x0
        private static System.Single TICK_INTERVAL;        // 0x0
        private static System.Boolean ENABLE_MULTITHREAD_GC;        // 0x8
        private readonly Beyond.Lua.CSharpCallLuaRegistration m_csCallLua;        // 0x70
        private Beyond.Gameplay.PeriodicTimer m_envTickTimer;        // 0x78
        private Beyond.Scripts.Lua.LuaMultithreadingGC m_luaMultithreadingGC;        // 0x80
        public static System.Boolean s_xluaReflectionOpt;        // 0x9
        private XLua.LuaEnv <luaEnv>k__BackingField;        // 0x88
        public System.Action<XLua.LuaTable,System.String,Beyond.Lua.LuaUIWidget> wrapUIWidgetFunction;        // 0x90
        public System.Action<XLua.LuaTable,System.String,Beyond.Lua.LuaReference> bindLuaRefFunction;        // 0x98
        public System.Boolean isQuittingApplication;        // 0xA0
        public Beyond.Lua.LuaManager.TickEvent actionTick;        // 0xA8
        public Beyond.Lua.LuaManager.TickEvent actionLateTick;        // 0xB0
        public Beyond.Lua.LuaManager.TickEvent actionTailTick;        // 0xB8
        public Beyond.Lua.LuaManager.TickEvent actionRenderDone;        // 0xC0

        // Methods
        private Beyond.Lua.LuaManager get_instance() { }
        private System.Void set_instance(Beyond.Lua.LuaManager value) { }
        private System.Void CreateInstance() { }
        private System.Void DestroyInstance() { }
        private System.Void .ctor() { }
        private XLua.LuaEnv get_luaEnv() { }
        private System.Void set_luaEnv(XLua.LuaEnv value) { }
        private System.Boolean IsEnableMultithreadGC() { }
        private System.Boolean IsLuaGCing() { }
        private System.Void OnInit() { }
        private System.String GetLuaStack() { }
        private System.Void OnRelease() { }
        private System.Void _ReleaseDelegateInAnotherStackFrame() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void TailLateTick(System.Single deltaTime) { }
        private System.String GetLuaFileRealPath(System.String modulePath) { }
        private System.Boolean IsLuaFileExist(System.String modulePath) { }
        private System.Int64 LoadLuaByteByFileRealPath(System.String modulePath, System.Int32& len) { }
        private System.Byte[] LoadLua(System.String modulePath) { }
        private System.IntPtr LoadLuaBytePtr(System.String modulePath) { }
        private System.Byte[] LoadLuaBytes(System.String& modulePath) { }
        private System.Void _RegisterCSharpCallLua() { }
        private System.Void _Register3rdPartyLibraries(XLua.LuaEnv env) { }
        private System.Void _HyperLuaLogCallback(System.IntPtr L, System.Int32 level, System.String text) { }
        private System.Void _LuaUtilsLogCallback(System.Int32 level, System.String text) { }
        private System.Void _OnEnvLangChanged(Beyond.GEnums.EnvLang lang) { }
        private System.Object[] DoString(System.String code) { }
        private System.IntPtr GetLuaState() { }
        private System.Void ClearAllUnityObjectUserdata() { }
        private System.Void _OnRenderDone(HG.Rendering.Runtime.HGRenderPipeCallbackArgs args) { }
        private System.Void _OnRenderDone() { }
        private System.Boolean AddLuaEventAfterGCDo(UnityEngine.Events.UnityAction action) { }
        private System.Void RemoveLuaEventAfterGCDo(UnityEngine.Events.UnityAction action) { }
        private System.Void AddOnceLuaEventAfterGCDo(UnityEngine.Events.UnityAction action) { }
        private System.Int32 LuaCalculateABPathHash(System.IntPtr L) { }
        private System.Void CasterStringPathHash(System.IntPtr L, System.Int32 index, Beyond.Resource.StringPathHash& o) { }
        private System.Boolean CheckStringPathHash(System.IntPtr L, System.Int32 index) { }
        private Beyond.FrameTickGroup get_frameTickGroup() { }
        private System.Void .cctor() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_TailLateTick(System.Single P0) { }

    }

    // TypeToken: 0x2000022
    public class LuaReference : MonoBehaviour, ILuaCallCSharp
    {
        // Fields
        public Beyond.Lua.LuaReference.ComponentRefDict refDict;        // 0x18
        public Beyond.SerializeReferenceDictionary<System.String,Beyond.Lua.LuaReference.RefExtraInfo> refExtraInfoDict;        // 0x20
        public System.Boolean isRootRef;        // 0x28
        public System.Collections.Generic.List<Beyond.Lua.LuaReference> subReferences;        // 0x30
        private XLua.LuaTable m_table;        // 0x38

        // Methods
        private System.Void Reset() { }
        private System.Void OnDestroy() { }
        private System.Void _UnBindFromXluaRef() { }
        private System.Void BindToLua(XLua.LuaTable table) { }
        private System.Void _BindSelfReferences(XLua.LuaTable table) { }
        private System.Boolean ContainsGameObject(UnityEngine.GameObject obj, System.Boolean recursive) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000027
    public struct LuaTestReflectionOptStruct
    {
        // Fields
        public System.Int32 a;        // 0x10
        public System.String b;        // 0x18
        public System.Int64 l;        // 0x20
        public System.UInt64 ul;        // 0x28
        public System.Single f;        // 0x30
        public System.Double d;        // 0x38
        public System.Boolean bl;        // 0x40

        // Methods
        private System.Int32 get_a1() { }
        private System.String get_b1() { }
        private System.Int64 get_l1() { }
        private System.UInt64 get_ul1() { }
        private System.Single get_f1() { }
        private System.Double get_d1() { }
        private System.Boolean get_bl1() { }
        private System.Void .ctor(System.Int32 a, System.String b, System.Int64 l, System.UInt64 ul, System.Single f, System.Double d, System.Boolean bl) { }
        private System.Int32 TestInt(System.Int32 a) { }
        private System.Void TestVoid() { }
        private System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct testStruct) { }
        private System.Void TestStructParam2(Beyond.Lua.LuaTestReflectionOptStruct& testStruct) { }
        private System.Object TestReturnObj() { }
        private System.Void TestObjParam(System.Object obj) { }

    }

    // TypeToken: 0x2000028
    public struct LuaTestReflectionOptStruct2
    {
        // Fields
        public System.Int32 a;        // 0x10
        public System.String b;        // 0x18
        public System.Int64 l;        // 0x20
        public System.UInt64 ul;        // 0x28
        public System.Single f;        // 0x30
        public System.Double d;        // 0x38
        public System.Boolean bl;        // 0x40

        // Methods
        private System.Int32 get_a1() { }
        private System.String get_b1() { }
        private System.Int64 get_l1() { }
        private System.UInt64 get_ul1() { }
        private System.Single get_f1() { }
        private System.Double get_d1() { }
        private System.Boolean get_bl1() { }
        private System.Int32 TestInt(System.Int32 a) { }
        private System.Void TestVoid() { }
        private System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct2 testStruct) { }
        private System.Void TestStructParam2(Beyond.Lua.LuaTestReflectionOptStruct2& testStruct) { }
        private System.Object TestReturnObj() { }
        private System.Void TestObjParam(System.Object obj) { }

    }

    // TypeToken: 0x2000029
    public struct ETestEnum
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Lua.ETestEnum Test1;        // 0x0
        public static Beyond.Lua.ETestEnum Test2;        // 0x0

    }

    // TypeToken: 0x200002A
    public class LuaTestReflectionOpt2
    {
        // Fields
        public System.Collections.Generic.List<System.Int32> TestList;        // 0x10
        public System.Collections.Generic.Dictionary<System.Int32,System.String> TestDict;        // 0x18

        // Methods
        private System.Void TestVoid() { }
        private System.Int32 TestInt(System.Int32 a) { }
        private System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct testStruct) { }
        private System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct2 testStruct) { }
        private System.Void TestStructParam2(Beyond.Lua.LuaTestReflectionOptStruct& testStruct) { }
        private System.Object TestReturnObj() { }
        private System.Void TestObjParam(System.Object obj) { }
        private System.Void TestEnum(Beyond.Lua.ETestEnum e) { }
        private Beyond.Lua.ETestEnum TestReturnEnum() { }
        private Beyond.Lua.LuaTestReflectionOptStruct TestStruct(Beyond.Lua.LuaTestReflectionOptStruct a) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002B
    public class LuaTestReflectionOpt
    {
        // Fields
        public System.Collections.Generic.List<System.Int32> TestList;        // 0x10
        public System.Collections.Generic.Dictionary<System.Int32,System.String> TestDict;        // 0x18

        // Methods
        private System.Void TestVoid() { }
        private System.Int32 TestInt(System.Int32 a) { }
        private System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct testStruct) { }
        private System.Void TestStructParam(Beyond.Lua.LuaTestReflectionOptStruct2 testStruct) { }
        private System.Void TestStructParam2(Beyond.Lua.LuaTestReflectionOptStruct& testStruct) { }
        private System.Object TestReturnObj() { }
        private System.Void TestObjParam(System.Object obj) { }
        private System.Void TestEnum(Beyond.Lua.ETestEnum e) { }
        private Beyond.Lua.ETestEnum TestReturnEnum() { }
        private Beyond.Lua.LuaTestReflectionOptStruct TestStruct(Beyond.Lua.LuaTestReflectionOptStruct a) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002C
    public class LuaUIWidget : MonoBehaviour, IUIClearable, ILuaCallCSharp
    {
        // Fields
        public System.String id;        // 0x18
        public System.Boolean isEmbeddedWidget;        // 0x20
        private XLua.LuaTable <table>k__BackingField;        // 0x28
        public XLua.LuaFunction onEnable;        // 0x30
        public XLua.LuaFunction onDisable;        // 0x38
        public XLua.LuaFunction onDestroy;        // 0x40

        // Methods
        private XLua.LuaTable get_table() { }
        private System.Void set_table(XLua.LuaTable value) { }
        private System.Void Reset() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void ClearComponent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002D
    public class UtilsForLua
    {
        // Fields
        private static UnityEngine.Vector3[] s_worldCorners;        // 0x0

        // Methods
        private UnityEngine.GameObject CreateObject(UnityEngine.GameObject asset) { }
        private UnityEngine.GameObject CreateObject(UnityEngine.GameObject asset, UnityEngine.Transform parent) { }
        private UnityEngine.GameObject CreateObject(UnityEngine.GameObject asset, UnityEngine.GameObject parent) { }
        private System.Void UIContainerResize(UnityEngine.Transform container, System.Int32 size, System.Int32 templateIndex) { }
        private System.Int32 TurnOffLayer(System.Int32 value, System.String layerName) { }
        private System.Int32 TurnOnLayer(System.Int32 value, System.String layerName) { }
        private System.Int32 ToggleLayer(System.Int32 value, System.String layerName) { }
        private System.Void SetPosX(UnityEngine.Transform t, System.Single value) { }
        private System.Void SetPosY(UnityEngine.Transform t, System.Single value) { }
        private System.Void SetPosZ(UnityEngine.Transform t, System.Single value) { }
        private System.Void SetRotX(UnityEngine.Transform t, System.Single value) { }
        private System.Void SetRotY(UnityEngine.Transform t, System.Single value) { }
        private System.Void SetRotZ(UnityEngine.Transform t, System.Single value) { }
        private System.Void SetScaleX(UnityEngine.Transform t, System.Single value) { }
        private System.Void SetScaleY(UnityEngine.Transform t, System.Single value) { }
        private System.Void SetScaleZ(UnityEngine.Transform t, System.Single value) { }
        private System.Void ClearUIComponents(UnityEngine.GameObject gameObject) { }
        private System.Boolean RayCast(UnityEngine.RaycastHit& hitInfo, UnityEngine.Ray ray, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction interaction) { }
        private System.Int32 RaycastNonAlloc(UnityEngine.Ray ray, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction interaction) { }
        private UnityEngine.Bounds GetRectTransformBounds(UnityEngine.RectTransform transform) { }
        private UnityEngine.Rect RectTransformToScreenRect(UnityEngine.RectTransform rectTransform, UnityEngine.Camera uiCamera) { }
        private UnityEngine.Vector3 GetRectTransformCenterPosition(UnityEngine.RectTransform rectTransform) { }
        private UnityEngine.Bounds CalcBoundOfRectTransform(UnityEngine.RectTransform transform, UnityEngine.RectTransform local) { }
        private System.Boolean IsMarkable(Beyond.Gameplay.Core.Entity obj) { }
        private System.Collections.Generic.List<System.String> GetStringList() { }
        private System.Single EntityDistance(Beyond.Gameplay.Core.Entity a, Beyond.Gameplay.Core.Entity b) { }
        private System.Void OpenAccountCenter() { }
        private System.Void ExitGame() { }
        private System.String GetCurrentUID() { }
        private System.Boolean StartPayment(System.String productId, System.String signParams) { }
        private System.Boolean TryGetCharacterVolume(UnityEngine.Rendering.Volume volume, HG.Rendering.Runtime.HGCharacterVolume& hgCharacterVolume) { }
        private System.Single GetAnimationCurveLength(UnityEngine.AnimationCurve curve) { }
        private DG.Tweening.Tweener TweenTo(System.Single from, System.Single to, System.Single duration, XLua.LuaFunction setter) { }
        private System.Boolean IsNull(UnityEngine.Object o) { }
        private Beyond.Lua.UtilsForLua.ImageContentParam ParseImageContent(System.String xml) { }
        private System.Void ReturnToLogin() { }
        private System.Void QuitGame(System.Int32 exitCode) { }
        private System.Void ToggleCharInfoInUpgradePanelOption(System.Boolean isIn) { }
        private System.Void ToggleWeaponInUpgradePanelOption(System.Boolean isIn) { }
        private Cinemachine.CinemachineTransposer GetCinemachineTransposer(Cinemachine.CinemachineVirtualCamera vcam) { }
        private Cinemachine.CinemachineComposer GetCinemachineComposer(Cinemachine.CinemachineVirtualCamera vcam) { }
        private CinemachineCameraOffset GetOrAddCinemachineCameraOffset(Cinemachine.CinemachineVirtualCamera vcam) { }
        private System.Void .cctor() { }

    }

}

namespace Beyond.Scripts.Lua
{

    // TypeToken: 0x2000007
    public struct ELuaMultithreadingGCState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.Scripts.Lua.ELuaMultithreadingGCState MinorGC;        // 0x0
        public static Beyond.Scripts.Lua.ELuaMultithreadingGCState MajorGC;        // 0x0

    }

    // TypeToken: 0x2000008
    public class OnGCEndEvent : UnityEvent
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class LuaMultithreadingGC
    {
        // Fields
        public static System.Int32 threadGcCount;        // 0x0
        public static System.Int32 mainThreadSignalCount;        // 0x4
        public static System.Int32 mainTheadForceGCCount;        // 0x8
        public static System.Int32 gcMarkCount;        // 0xC
        public static System.Int32 gcSweepCount;        // 0x10
        private System.Threading.Thread m_gcThread;        // 0x10
        private System.Threading.AutoResetEvent m_workSignal;        // 0x18
        private XLua.LuaEnv m_luaEnv;        // 0x20
        private System.Int32 m_lastMajorGCMemory;        // 0x28
        private System.Int32 m_lastMinorGCMemory;        // 0x2C
        private System.Int32 m_badGCCounter;        // 0x30
        private System.Int32 m_badGCThreshold;        // 0x34
        private System.Single m_genGcIncreaseThreshold;        // 0x38
        private System.Single m_genGcIncreaseThresholdDiff;        // 0x3C
        private System.Int32 m_incGCThreshold;        // 0x40
        private Beyond.Scripts.Lua.OnGCEndEvent m_afterGCEvent;        // 0x48
        private System.Collections.Generic.List<UnityEngine.Events.UnityAction> m_afterGCEventOnceEvents;        // 0x50
        public Beyond.Scripts.Lua.ELuaMultithreadingGCState gcState;        // 0x58
        public System.Int64 mainThreadWait;        // 0x60
        public System.Int64 gcThreadStop;        // 0x68
        public System.Boolean stop;        // 0x70
        public System.Boolean isRunning;        // 0x71
        private XLua.LuaDLL.lua_Hook hook;        // 0x78
        private static XLua.LuaDLL.lua_Hook oldHook;        // 0x18
        private static System.Int32 oldHookMask;        // 0x20
        private System.Boolean haveRunOnce;        // 0x80
        private static readonly Unity.Profiling.ProfilerMarker PROFILER_MARKER_START_GC;        // 0x28
        private static readonly Unity.Profiling.ProfilerMarker PROFILER_MARKER_THREAD_NOTIFY;        // 0x30

        // Methods
        private System.Void .ctor(XLua.LuaEnv luaEnv) { }
        private System.Void StartGCAsync() { }
        private System.Void NormalStop() { }
        private System.Void ForceStopAsyncGC() { }
        private System.Void MainThreadWait() { }
        private System.Void AddLuaAfterGCEvent(UnityEngine.Events.UnityAction action) { }
        private System.Void AddLuaAfterGCOnceEvent(UnityEngine.Events.UnityAction action) { }
        private System.Void RemoveLuaAfterGCEvent(UnityEngine.Events.UnityAction action) { }
        private System.Void _OnGCEnd() { }
        private System.Void _Init() { }
        private System.Void _Dispose() { }
        private System.Int32 _FindLoopSystemIndex(UnityEngine.LowLevel.PlayerLoopSystem[] playerLoopList, System.String typeName) { }
        private System.Int32 LuaHook(System.IntPtr L, XLua.lua_debug& ar) { }
        private System.Void _UpdateOldHook() { }
        private System.Boolean _DoLock() { }
        private System.Boolean _DoGc(System.Int32 work) { }
        private System.Void _GCMethodWrapper() { }
        private System.Void .cctor() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000003
    public class AnimatorBlackboardAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class DataNAttribute : Attribute
    {
        // Fields
        public System.Int32 capacity;        // 0x10
        public System.Int32 tSize;        // 0x14
        public System.Boolean ring;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class ECSComponentAttribute : Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;        // 0x10
        public System.Boolean isTag;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000002
    public class HGConstantBufferLayoutAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000030
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.Void __Gen_Wrap_0(System.Object P0) { }
        private System.Boolean __Gen_Wrap_1(UnityEngine.LowLevel.PlayerLoopSystem P0) { }
        private System.Void __Gen_Wrap_2(System.Object P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_3(System.Object P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_4(System.IntPtr P0, XLua.lua_debug& P1) { }
        private System.Boolean __Gen_Wrap_5(System.Object P0) { }
        private System.Boolean __Gen_Wrap_6(System.Object P0, System.Int32 P1) { }
        private System.Boolean __Gen_Wrap_7() { }
        private System.Void __Gen_Wrap_8() { }
        private System.Collections.Generic.Dictionary<System.String,Beyond.Lua.LuaCustomConfig.Item> __Gen_Wrap_9(System.Object P0) { }
        private System.String __Gen_Wrap_10(System.Object P0) { }
        private System.Object __Gen_Wrap_11(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_12(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        private XLua.LuaTable __Gen_Wrap_13(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Boolean __Gen_Wrap_14(System.Object P0, System.Object P1) { }
        private System.Boolean __Gen_Wrap_15(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_16(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Type __Gen_Wrap_17(System.Object P0) { }
        private System.Object __Gen_Wrap_18(System.Object P0) { }
        private System.Byte[] __Gen_Wrap_19(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_20(System.Object P0, HG.Rendering.Runtime.HGRenderPipeCallbackArgs P1) { }
        private System.String __Gen_Wrap_21() { }
        private System.Void __Gen_Wrap_22(System.IntPtr P0, System.Int32 P1, System.Object P2) { }
        private System.Void __Gen_Wrap_23(System.Int32 P0, System.Object P1) { }
        private System.Byte[] __Gen_Wrap_24(System.Object P0, System.String& P1) { }
        private System.Int32 __Gen_Wrap_25(System.IntPtr P0) { }
        private System.Void __Gen_Wrap_26(System.IntPtr P0, System.Int32 P1, Beyond.Resource.StringPathHash& P2) { }
        private System.Boolean __Gen_Wrap_27(System.IntPtr P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_28(System.Object P0, Beyond.GEnums.EnvLang P1) { }
        private System.Void __Gen_Wrap_29(System.Object P0, System.Single P1) { }
        private System.String __Gen_Wrap_30(System.Object P0, System.Object P1) { }
        private System.Int64 __Gen_Wrap_31(System.Object P0, System.Object P1, System.Int32& P2) { }
        private System.IntPtr __Gen_Wrap_32(System.Object P0, System.Object P1) { }
        private System.Object[] __Gen_Wrap_33(System.Object P0, System.Object P1) { }
        private System.IntPtr __Gen_Wrap_34(System.Object P0) { }
        private System.Boolean __Gen_Wrap_35(Beyond.Lua.LuaReference P0) { }
        private System.Boolean __Gen_Wrap_36(System.Object P0, System.Object P1, System.Boolean P2) { }
        private System.Int32 __Gen_Wrap_37(Beyond.Lua.LuaTestReflectionOptStruct& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_38(Beyond.Lua.LuaTestReflectionOptStruct& P0) { }
        private System.Void __Gen_Wrap_39(Beyond.Lua.LuaTestReflectionOptStruct& P0, Beyond.Lua.LuaTestReflectionOptStruct P1) { }
        private System.Void __Gen_Wrap_40(Beyond.Lua.LuaTestReflectionOptStruct& P0, Beyond.Lua.LuaTestReflectionOptStruct& P1) { }
        private System.Object __Gen_Wrap_41(Beyond.Lua.LuaTestReflectionOptStruct& P0) { }
        private System.Void __Gen_Wrap_42(Beyond.Lua.LuaTestReflectionOptStruct& P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_43(Beyond.Lua.LuaTestReflectionOptStruct2& P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_44(Beyond.Lua.LuaTestReflectionOptStruct2& P0) { }
        private System.Void __Gen_Wrap_45(Beyond.Lua.LuaTestReflectionOptStruct2& P0, Beyond.Lua.LuaTestReflectionOptStruct2 P1) { }
        private System.Void __Gen_Wrap_46(Beyond.Lua.LuaTestReflectionOptStruct2& P0, Beyond.Lua.LuaTestReflectionOptStruct2& P1) { }
        private System.Object __Gen_Wrap_47(Beyond.Lua.LuaTestReflectionOptStruct2& P0) { }
        private System.Void __Gen_Wrap_48(Beyond.Lua.LuaTestReflectionOptStruct2& P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_49(System.Object P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_50(System.Object P0, Beyond.Lua.LuaTestReflectionOptStruct P1) { }
        private System.Void __Gen_Wrap_51(System.Object P0, Beyond.Lua.LuaTestReflectionOptStruct2 P1) { }
        private System.Void __Gen_Wrap_52(System.Object P0, Beyond.Lua.LuaTestReflectionOptStruct& P1) { }
        private System.Void __Gen_Wrap_53(System.Object P0, Beyond.Lua.ETestEnum P1) { }
        private Beyond.Lua.ETestEnum __Gen_Wrap_54(System.Object P0) { }
        private Beyond.Lua.LuaTestReflectionOptStruct __Gen_Wrap_55(System.Object P0, Beyond.Lua.LuaTestReflectionOptStruct P1) { }
        private UnityEngine.GameObject __Gen_Wrap_56(System.Object P0) { }
        private UnityEngine.GameObject __Gen_Wrap_57(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_58(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        private System.Int32 __Gen_Wrap_59(System.Int32 P0, System.Object P1) { }
        private System.Boolean __Gen_Wrap_60(UnityEngine.RaycastHit& P0, UnityEngine.Ray P1, System.Single P2, System.Int32 P3, UnityEngine.QueryTriggerInteraction P4) { }
        private System.Int32 __Gen_Wrap_61(UnityEngine.Ray P0, System.Object P1, System.Single P2, System.Int32 P3, UnityEngine.QueryTriggerInteraction P4) { }
        private UnityEngine.Bounds __Gen_Wrap_62(System.Object P0) { }
        private UnityEngine.Rect __Gen_Wrap_63(System.Object P0, System.Object P1) { }
        private UnityEngine.Vector3 __Gen_Wrap_64(System.Object P0) { }
        private UnityEngine.Bounds __Gen_Wrap_65(System.Object P0, System.Object P1) { }
        private System.Collections.Generic.List<System.String> __Gen_Wrap_66() { }
        private System.Single __Gen_Wrap_67(System.Object P0, System.Object P1) { }
        private System.Boolean __Gen_Wrap_68(System.Object P0, HG.Rendering.Runtime.HGCharacterVolume& P1) { }
        private System.Single __Gen_Wrap_69(System.Object P0) { }
        private System.Single __Gen_Wrap_70() { }
        private System.Void __Gen_Wrap_71(System.Single P0) { }
        private DG.Tweening.Tweener __Gen_Wrap_72(System.Single P0, System.Single P1, System.Single P2, System.Object P3) { }
        private Beyond.Lua.UtilsForLua.ImageContentParam __Gen_Wrap_73(System.Object P0) { }
        private System.Void __Gen_Wrap_74(System.Int32 P0) { }
        private System.Void __Gen_Wrap_75(System.Boolean P0) { }
        private Cinemachine.CinemachineTransposer __Gen_Wrap_76(System.Object P0) { }
        private Cinemachine.CinemachineComposer __Gen_Wrap_77(System.Object P0) { }
        private CinemachineCameraOffset __Gen_Wrap_78(System.Object P0) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000031
    public class ILFixInterfaceBridge : AnonymousStorey
    {
        // Methods
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000032
    public class WrappersManagerImpl, WrappersManager
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine) { }
        private IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        private System.Boolean IsPatched(System.Int32 id) { }
        private System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon) { }
        private System.Object CreateWrapper(System.Int32 id) { }
        private System.Object InitWrapperArray(System.Int32 len) { }
        private IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine) { }

    }

    // TypeToken: 0x2000033
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-Scripts-Lua-LuaMultithreadingGC-StartGCAsync0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Lua-LuaMultithreadingGC-_OnGCEnd0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Lua-LuaMultithreadingGC-_Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Lua-LuaMultithreadingGC-NormalStop0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Lua-LuaMultithreadingGC-ForceStopAsyncGC0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Lua-LuaMultithreadingGC-MainThreadWait0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Lua-LuaMultithreadingGC-AddLuaAfterGCEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Lua-LuaMultithreadingGC-AddLuaAfterGCOnceEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Lua-LuaMultithreadingGC-RemoveLuaAfterGCEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Lua-LuaMultithreadingGC-_FindLoopSystemIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Lua-LuaMultithreadingGC-_Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Lua-LuaMultithreadingGC-LuaHook0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Lua-LuaMultithreadingGC-_UpdateOldHook0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Lua-LuaMultithreadingGC-_DoLock0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Lua-LuaMultithreadingGC-_DoGc0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-Lua-LuaMultithreadingGC-_GCMethodWrapper0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaEventSystem-PushEventName0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-IsLuaGCing0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-AddOnceLuaEventAfterGCDo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaEventSystem-DispatchEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaEventSystem-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-CSharpCallLuaRegistration-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-CSharpCallLuaRegistration-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-get_itemDict0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-OnBeforeSerialize0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-OnAfterDeserialize0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-Item-MarkLuaValueProcessed0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-ConvertLuaTableToJson0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-ConvertLuaCodeToJson0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_ConvertJValueToObjectForValidation0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_PopulateLuaTableFromJTokenForValidation0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_JsonToLuaTableForValidation0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_IsNumericType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_CompareValues0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_CompareLuaTables0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_ValidateLuaTableConsistency0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_ProcessLuaTableItem0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-ShouldProcessEnumItem0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_ProcessEnumItem0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_ConvertJValueToObject0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_PopulateLuaTableFromJToken0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-_JsonToLuaTable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-Item-GetEnumType0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-Item-GetEnumValueObject0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-InitConfigTable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-Item-HasLuaValueChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaCustomConfig-Item-ShouldSerializeLuaTableJson0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LoadLuaProxy-_RunOnStart0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LoadLuaProxy-LoadLua0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaMethodPointerModule-_RunOnStart0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-CreateInstance0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-DestroyInstance0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-IsEnableMultithreadGC0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-_OnRenderDone0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-_OnRenderDone1;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-GetLuaStack0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-_HyperLuaLogCallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-_LuaUtilsLogCallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-_Register3rdPartyLibraries0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-LoadLuaBytes0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-LuaCalculateABPathHash0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-CasterStringPathHash0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-CheckStringPathHash0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-_RegisterCSharpCallLua0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-OnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-_OnEnvLangChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-_ReleaseDelegateInAnotherStackFrame0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-OnRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-TailLateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-GetLuaFileRealPath0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-IsLuaFileExist0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-LoadLuaByteByFileRealPath0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-LoadLua0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-LoadLuaBytePtr0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-DoString0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-GetLuaState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-ClearAllUnityObjectUserdata0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-AddLuaEventAfterGCDo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaManager-RemoveLuaEventAfterGCDo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaReference-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaReference-_UnBindFromXluaRef0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaReference-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaReference-_BindSelfReferences0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaReference-BindToLua0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaReference-ContainsGameObject0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct-TestInt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct-TestVoid0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct-TestStructParam0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct-TestStructParam20;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct-TestReturnObj0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct-TestObjParam0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct2-TestInt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct2-TestVoid0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct2-TestStructParam0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct2-TestStructParam20;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct2-TestReturnObj0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOptStruct2-TestObjParam0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestVoid0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestInt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestStructParam0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestStructParam1;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestStructParam20;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestReturnObj0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestObjParam0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestEnum0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestReturnEnum0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt2-TestStruct0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestVoid0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestInt0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestStructParam0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestStructParam1;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestStructParam20;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestReturnObj0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestObjParam0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestEnum0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestReturnEnum0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaTestReflectionOpt-TestStruct0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaUIWidget-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaUIWidget-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaUIWidget-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaUIWidget-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-LuaUIWidget-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-CreateObject0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-CreateObject1;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-CreateObject2;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-UIContainerResize0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-TurnOffLayer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-TurnOnLayer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-ToggleLayer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetPosX0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetPosY0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetPosZ0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetRotX0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetRotY0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetRotZ0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetScaleX0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetScaleY0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-SetScaleZ0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-ClearUIComponents0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-RayCast0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-RaycastNonAlloc0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetRectTransformBounds0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-RectTransformToScreenRect0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetRectTransformCenterPosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-CalcBoundOfRectTransform0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-IsMarkable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetStringList0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-EntityDistance0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-OpenAccountCenter0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-ExitGame0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetCurrentUID0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-StartPayment0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-TryGetCharacterVolume0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetAnimationCurveLength0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-TweenTo0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-IsNull0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-ParseImageContent0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-ReturnToLogin0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-QuitGame0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-ToggleCharInfoInUpgradePanelOption0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-ToggleWeaponInUpgradePanelOption0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetCinemachineTransposer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetCinemachineComposer0;        // 0x0
        public static IFix.IDMAP0 Beyond-Lua-UtilsForLua-GetOrAddCinemachineCameraOffset0;        // 0x0

    }

}

