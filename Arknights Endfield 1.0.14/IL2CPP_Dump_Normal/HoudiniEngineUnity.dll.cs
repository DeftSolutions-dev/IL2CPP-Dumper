// ========================================================
// Dumped by @desirepro
// Assembly: HoudiniEngineUnity.dll
// Classes:  439
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000003
    public class HEU_BoundingVolume : MonoBehaviour
    {
        // Methods
        private UnityEngine.Collider get_BoundingCollider() { }
        private System.Collections.Generic.List<UnityEngine.GameObject> GetAllIntersectingObjects() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class HEU_ExampleEvergreenQuery
    {
        // Methods
        private System.Void StartQuery() { }
        private HoudiniEngineUnity.HEU_HoudiniAsset QueryHoudiniAsset(UnityEngine.GameObject rootGO) { }
        private System.Void CookAsset(HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset) { }
        private System.Void ChangeParmsAndCook(HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset) { }
        private System.Void QueryObjects(HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset) { }
        private System.Void QueryGeoParts(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_GeoInfo& geoInfo) { }
        private System.Void QueryPartAttributeByOwner(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HAPI_AttributeOwner owner, System.Int32 count, System.Text.StringBuilder sb) { }
        private System.Void QueryAttributeByStorageType(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.String attrName) { }
        private System.Void QueryAttribute(HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset, System.String objName, System.String geoName, System.Int32 partID, System.String attrName) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class HEU_ExampleInstanceCustomAttribute : MonoBehaviour
    {
        // Methods
        private System.Void InstancerCallback() { }
        private System.Void LogArray(System.String name, T[] arr, System.Int32 tupleSize) { }
        private System.Void LogAttr(HoudiniEngineUnity.HEU_OutputAttribute outAttr) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class HEU_ScriptCallbackExample : MonoBehaviour
    {
        // Fields
        public System.String _msg;        // 0x18

        // Methods
        private System.Void AssetCallbackWithMsg(System.String msg) { }
        private System.Void AssetCallbackNoMsg() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public struct OutputMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HEU_ScriptMeshInputUVLayoutExample.OutputMode COPY;        // 0x0
        public static HEU_ScriptMeshInputUVLayoutExample.OutputMode REPLACE;        // 0x0

    }

    // TypeToken: 0x2000007
    public class HEU_ScriptMeshInputUVLayoutExample
    {
        // Methods
        private System.Void ApplyUVLayoutTo(UnityEngine.GameObject[] gameObjects, HEU_ScriptMeshInputUVLayoutExample.OutputMode outputMode, System.String output_name_suffix) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class HEU_ScriptParameterExample : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject _evergreenGameObject;        // 0x18
        private HoudiniEngineUnity.HEU_HoudiniAsset _evergreenAsset;        // 0x20
        public System.Single _updateRate;        // 0x28
        public System.Single _scale;        // 0x2C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000A
    public class HEU_AssetEventReceiverTest : MonoBehaviour
    {
        // Methods
        private System.Void ReloadCallback(HoudiniEngineUnity.HEU_ReloadEventData Data) { }
        private System.Void CookedCallback(HoudiniEngineUnity.HEU_CookedEventData Data) { }
        private System.Void BakedCallback(HoudiniEngineUnity.HEU_BakedEventData Data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000025
    public struct CurveEditState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_Curve.CurveEditState INVALID;        // 0x0
        public static HoudiniEngineUnity.HEU_Curve.CurveEditState GENERATED;        // 0x0
        public static HoudiniEngineUnity.HEU_Curve.CurveEditState EDITING;        // 0x0
        public static HoudiniEngineUnity.HEU_Curve.CurveEditState REQUIRES_GENERATION;        // 0x0

    }

    // TypeToken: 0x2000026
    public struct Interaction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_Curve.Interaction VIEW;        // 0x0
        public static HoudiniEngineUnity.HEU_Curve.Interaction ADD;        // 0x0
        public static HoudiniEngineUnity.HEU_Curve.Interaction EDIT;        // 0x0

    }

    // TypeToken: 0x2000027
    public struct CurveDrawCollision
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_Curve.CurveDrawCollision COLLIDERS;        // 0x0
        public static HoudiniEngineUnity.HEU_Curve.CurveDrawCollision LAYERMASK;        // 0x0

    }

    // TypeToken: 0x2000030
    public struct HEU_AssetType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType TYPE_INVALID;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType TYPE_HDA;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType TYPE_CURVE;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType TYPE_INPUT;        // 0x0

    }

    // TypeToken: 0x2000031
    public struct AssetBuildAction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction NONE;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction RELOAD;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction COOK;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction INVALID;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction STRIP_HEDATA;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction DUPLICATE;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction RESET_PARAMS;        // 0x0

    }

    // TypeToken: 0x2000032
    public struct AssetCookStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus NONE;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus COOKING;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus POSTCOOK;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus LOADING;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus POSTLOAD;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus PRELOAD;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus SELECT_SUBASSET;        // 0x0

    }

    // TypeToken: 0x2000033
    public struct AssetCookResult
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult NONE;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult SUCCESS;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult ERRORED;        // 0x0

    }

    // TypeToken: 0x2000034
    public class UpdateUIDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000035
    public struct AssetInstantiationMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetInstantiationMethod DEFAULT;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetInstantiationMethod DUPLICATED;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniAsset.AssetInstantiationMethod UNDO;        // 0x0

    }

    // TypeToken: 0x200003B
    public struct InputNodeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_InputNode.InputNodeType CONNECTION;        // 0x0
        public static HoudiniEngineUnity.HEU_InputNode.InputNodeType NODE;        // 0x0
        public static HoudiniEngineUnity.HEU_InputNode.InputNodeType PARAMETER;        // 0x0

    }

    // TypeToken: 0x200003C
    public struct InputObjectType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_InputNode.InputObjectType HDA;        // 0x0
        public static HoudiniEngineUnity.HEU_InputNode.InputObjectType UNITY_MESH;        // 0x0
        public static HoudiniEngineUnity.HEU_InputNode.InputObjectType CURVE;        // 0x0
        public static HoudiniEngineUnity.HEU_InputNode.InputObjectType TERRAIN;        // 0x0
        public static HoudiniEngineUnity.HEU_InputNode.InputObjectType BOUNDING_BOX;        // 0x0
        public static HoudiniEngineUnity.HEU_InputNode.InputObjectType TILEMAP;        // 0x0

    }

    // TypeToken: 0x200003D
    public struct InternalObjectType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_InputNode.InternalObjectType UNKNOWN;        // 0x0
        public static HoudiniEngineUnity.HEU_InputNode.InternalObjectType HDA;        // 0x0
        public static HoudiniEngineUnity.HEU_InputNode.InternalObjectType UNITY_MESH;        // 0x0

    }

    // TypeToken: 0x200003E
    public struct InputActions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_InputNode.InputActions ACTION;        // 0x0
        public static HoudiniEngineUnity.HEU_InputNode.InputActions DELETE;        // 0x0
        public static HoudiniEngineUnity.HEU_InputNode.InputActions INSERT;        // 0x0

    }

    // TypeToken: 0x2000042
    public class HEU_InputObjectUICache
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000043
    public class HEU_InputAssetUICache
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000049
    public struct PartOutputType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_PartData.PartOutputType NONE;        // 0x0
        public static HoudiniEngineUnity.HEU_PartData.PartOutputType MESH;        // 0x0
        public static HoudiniEngineUnity.HEU_PartData.PartOutputType VOLUME;        // 0x0
        public static HoudiniEngineUnity.HEU_PartData.PartOutputType CURVE;        // 0x0
        public static HoudiniEngineUnity.HEU_PartData.PartOutputType INSTANCER;        // 0x0

    }

    // TypeToken: 0x200004F
    public struct AttributeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeType UNDEFINED;        // 0x0
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeType BOOL;        // 0x0
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeType INT;        // 0x0
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeType FLOAT;        // 0x0
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeType STRING;        // 0x0
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeType MAX;        // 0x0

    }

    // TypeToken: 0x2000050
    public struct AttributeState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeState INVALID;        // 0x0
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeState SYNCED;        // 0x0
        public static HoudiniEngineUnity.HEU_AttributeData.AttributeState LOCAL_DIRTY;        // 0x0

    }

    // TypeToken: 0x2000052
    public class SetAttributeValueFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        private System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000057
    public struct HEU_ImportAssetOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptions Default;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptions ForceUpdate;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptions ForceSynchronousImport;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptions ImportRecursive;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptions DontDownloadFromCacheServer;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptions ForceUncompressedImport;        // 0x0

    }

    // TypeToken: 0x200005D
    public struct RegSAM
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM QueryValue;        // 0x0
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM SetValue;        // 0x0
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM CreateSubKey;        // 0x0
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM EnumerateSubKeys;        // 0x0
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM Notify;        // 0x0
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM CreateLink;        // 0x0
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM WOW64_32Key;        // 0x0
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM WOW64_64Key;        // 0x0
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM WOW64_Res;        // 0x0
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM Read;        // 0x0
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM Write;        // 0x0
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM Execute;        // 0x0
        public static HoudiniEngineUnity.HEU_PlatformWin.RegSAM AllAccess;        // 0x0

    }

    // TypeToken: 0x2000060
    public struct DataType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_PluginStorage.DataType BOOL;        // 0x0
        public static HoudiniEngineUnity.HEU_PluginStorage.DataType INT;        // 0x0
        public static HoudiniEngineUnity.HEU_PluginStorage.DataType LONG;        // 0x0
        public static HoudiniEngineUnity.HEU_PluginStorage.DataType FLOAT;        // 0x0
        public static HoudiniEngineUnity.HEU_PluginStorage.DataType STRING;        // 0x0

    }

    // TypeToken: 0x2000061
    public class StoreData
    {
        // Fields
        public HoudiniEngineUnity.HEU_PluginStorage.DataType _type;        // 0x10
        public System.String _valueStr;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000062
    public class StoreDataArray`1
    {
        // Fields
        public T[] _array;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000064
    public struct HEU_HandleType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_Handle.HEU_HandleType XFORM;        // 0x0
        public static HoudiniEngineUnity.HEU_Handle.HEU_HandleType UNSUPPORTED;        // 0x0

    }

    // TypeToken: 0x2000066
    public struct HEU_HandleParamType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_HandleParamBinding.HEU_HandleParamType TRANSLATE;        // 0x0
        public static HoudiniEngineUnity.HEU_HandleParamBinding.HEU_HandleParamType ROTATE;        // 0x0
        public static HoudiniEngineUnity.HEU_HandleParamBinding.HEU_HandleParamType SCALE;        // 0x0

    }

    // TypeToken: 0x20000C3
    public struct ModifierAction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction MULTIPARM_INSERT;        // 0x0
        public static HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction MULTIPARM_REMOVE;        // 0x0
        public static HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction MULTIPARM_CLEAR;        // 0x0
        public static HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction SET_FLOAT;        // 0x0
        public static HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction SET_INT;        // 0x0

    }

    // TypeToken: 0x20000CB
    public struct LinkState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_PDGAssetLink.LinkState INACTIVE;        // 0x0
        public static HoudiniEngineUnity.HEU_PDGAssetLink.LinkState LINKING;        // 0x0
        public static HoudiniEngineUnity.HEU_PDGAssetLink.LinkState LINKED;        // 0x0
        public static HoudiniEngineUnity.HEU_PDGAssetLink.LinkState ERROR_NOT_LINKED;        // 0x0

    }

    // TypeToken: 0x20000CC
    public class UpdateUIDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000D2
    public struct PDGState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_TOPNodeData.PDGState NONE;        // 0x0
        public static HoudiniEngineUnity.HEU_TOPNodeData.PDGState DIRTIED;        // 0x0
        public static HoudiniEngineUnity.HEU_TOPNodeData.PDGState DIRTYING;        // 0x0
        public static HoudiniEngineUnity.HEU_TOPNodeData.PDGState COOKING;        // 0x0
        public static HoudiniEngineUnity.HEU_TOPNodeData.PDGState COOK_COMPLETE;        // 0x0
        public static HoudiniEngineUnity.HEU_TOPNodeData.PDGState COOK_FAILED;        // 0x0

    }

    // TypeToken: 0x20000D6
    public class OnWorkItemLoadResultsDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(HoudiniEngineUnity.HEU_SyncedEventData OnSynced) { }
        private System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_SyncedEventData OnSynced, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000D7
    public struct EventMessageColor
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_PDGSession.EventMessageColor DEFAULT;        // 0x0
        public static HoudiniEngineUnity.HEU_PDGSession.EventMessageColor WARNING;        // 0x0
        public static HoudiniEngineUnity.HEU_PDGSession.EventMessageColor ERROR;        // 0x0

    }

    // TypeToken: 0x20000F2
    public struct Source
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_MaterialData.Source DEFAULT;        // 0x0
        public static HoudiniEngineUnity.HEU_MaterialData.Source HOUDINI;        // 0x0
        public static HoudiniEngineUnity.HEU_MaterialData.Source UNITY;        // 0x0
        public static HoudiniEngineUnity.HEU_MaterialData.Source SUBSTANCE;        // 0x0

    }

    // TypeToken: 0x20000FB
    public class CreateSessionFromTypeDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private HoudiniEngineUnity.HEU_SessionBase Invoke(System.Type type) { }
        private System.IAsyncResult BeginInvoke(System.Type type, System.AsyncCallback callback, System.Object object) { }
        private HoudiniEngineUnity.HEU_SessionBase EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20000FE
    public struct Status
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_SessionSyncData.Status Stopped;        // 0x0
        public static HoudiniEngineUnity.HEU_SessionSyncData.Status Started;        // 0x0
        public static HoudiniEngineUnity.HEU_SessionSyncData.Status Connecting;        // 0x0
        public static HoudiniEngineUnity.HEU_SessionSyncData.Status Initializing;        // 0x0
        public static HoudiniEngineUnity.HEU_SessionSyncData.Status Connected;        // 0x0

    }

    // TypeToken: 0x2000100
    public class AssetSyncCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(HoudiniEngineUnity.HEU_AssetSync assetSync) { }
        private System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_AssetSync assetSync, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000107
    public struct TaskStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_Task.TaskStatus NONE;        // 0x0
        public static HoudiniEngineUnity.HEU_Task.TaskStatus PENDING_START;        // 0x0
        public static HoudiniEngineUnity.HEU_Task.TaskStatus STARTED;        // 0x0
        public static HoudiniEngineUnity.HEU_Task.TaskStatus REQUIRE_UPDATE;        // 0x0
        public static HoudiniEngineUnity.HEU_Task.TaskStatus PENDING_COMPLETE;        // 0x0
        public static HoudiniEngineUnity.HEU_Task.TaskStatus COMPLETED;        // 0x0
        public static HoudiniEngineUnity.HEU_Task.TaskStatus UNUSED;        // 0x0

    }

    // TypeToken: 0x2000108
    public struct TaskResult
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_Task.TaskResult NONE;        // 0x0
        public static HoudiniEngineUnity.HEU_Task.TaskResult SUCCESS;        // 0x0
        public static HoudiniEngineUnity.HEU_Task.TaskResult FAILED;        // 0x0
        public static HoudiniEngineUnity.HEU_Task.TaskResult KILLED;        // 0x0

    }

    // TypeToken: 0x2000109
    public class TaskCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(HoudiniEngineUnity.HEU_Task task) { }
        private System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_Task task, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200010B
    public struct BuildType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_AssetTask.BuildType NONE;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetTask.BuildType LOAD;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetTask.BuildType COOK;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetTask.BuildType RELOAD;        // 0x0

    }

    // TypeToken: 0x2000114
    public struct LoadType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadType FILE;        // 0x0
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadType NODE;        // 0x0
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadType ASSET;        // 0x0

    }

    // TypeToken: 0x2000116
    public struct LoadStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus NONE;        // 0x0
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus STARTED;        // 0x0
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus SUCCESS;        // 0x0
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus ERROR;        // 0x0

    }

    // TypeToken: 0x2000115
    public class HEU_LoadData
    {
        // Fields
        public System.Int32 _cookNodeID;        // 0x10
        public HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus _loadStatus;        // 0x14
        public System.Text.StringBuilder _logStr;        // 0x18
        public HoudiniEngineUnity.HEU_SessionBase _session;        // 0x20
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadObject> _loadedObjects;        // 0x28
        public System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_LoadBufferBase> _idBuffersMap;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000117
    public class HEU_LoadObject
    {
        // Fields
        public System.Int32 _objectNodeID;        // 0x10
        public System.Int32 _displayNodeID;        // 0x14
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolume> _terrainBuffers;        // 0x18
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferMesh> _meshBuffers;        // 0x20
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferInstancer> _instancerBuffers;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000118
    public struct HEU_LoadCallbackType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallbackType PRECOOK;        // 0x0
        public static HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallbackType POSTCOOK;        // 0x0

    }

    // TypeToken: 0x2000119
    public class HEU_LoadCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallbackType callbackType) { }
        private System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallbackType callbackType, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200011D
    public struct HEU_ReplacePrefabOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_EditorUtility.HEU_ReplacePrefabOptions Default;        // 0x0
        public static HoudiniEngineUnity.HEU_EditorUtility.HEU_ReplacePrefabOptions ConnectToPrefab;        // 0x0
        public static HoudiniEngineUnity.HEU_EditorUtility.HEU_ReplacePrefabOptions ReplaceNameBased;        // 0x0

    }

    // TypeToken: 0x2000123
    public class GetArray1ArgDel`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.Int32 arg1, T[] data, System.Int32 start, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(System.Int32 arg1, T[] data, System.Int32 start, System.Int32 length, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000124
    public class GetArray2ArgDel`2 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.Int32 arg1, ARG2 arg2, T[] data, System.Int32 start, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(System.Int32 arg1, ARG2 arg2, T[] data, System.Int32 start, System.Int32 length, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000125
    public class GetArray3ArgDel`3 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.Int32 arg1, ARG2 arg2, ARG3 arg3, T[] data, System.Int32 start, System.Int32 length) { }
        private System.IAsyncResult BeginInvoke(System.Int32 arg1, ARG2 arg2, ARG3 arg3, T[] data, System.Int32 start, System.Int32 length, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000126
    public class GetAttributeArrayInputFunc`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[] items, System.Int32 start, System.Int32 end) { }
        private System.IAsyncResult BeginInvoke(System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[] items, System.Int32 start, System.Int32 end, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(HoudiniEngineUnity.HAPI_AttributeInfo& info, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000127
    public class SetAttributeArrayFunc`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, T[] items, System.Int32 start, System.Int32 end) { }
        private System.IAsyncResult BeginInvoke(System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, T[] items, System.Int32 start, System.Int32 end, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200012B
    public struct ColliderType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType NONE;        // 0x0
        public static HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType BOX;        // 0x0
        public static HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType SPHERE;        // 0x0
        public static HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType MESH;        // 0x0
        public static HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType SIMPLE_BOX;        // 0x0
        public static HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType SIMPLE_SPHERE;        // 0x0
        public static HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType SIMPLE_CAPSULE;        // 0x0

    }

    // TypeToken: 0x200012A
    public class HEU_ColliderInfo
    {
        // Fields
        public HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType _colliderType;        // 0x10
        public UnityEngine.Vector3 _colliderCenter;        // 0x14
        public UnityEngine.Vector3 _colliderSize;        // 0x20
        public System.Single _colliderRadius;        // 0x2C
        public System.Boolean _convexCollider;        // 0x30
        public System.String _collisionGroupName;        // 0x38
        public UnityEngine.Vector3[] _collisionVertices;        // 0x40
        public System.Int32[] _collisionIndices;        // 0x48
        public UnityEngine.MeshTopology _meshTopology;        // 0x50
        public System.Boolean _isTrigger;        // 0x54

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000134
    public class HEU_InputDataMeshes : HEU_InputData
    {
        // Fields
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataMesh> _inputMeshes;        // 0x18
        public System.Boolean _hasLOD;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000135
    public struct HEU_InputColliderType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderType NONE;        // 0x0
        public static HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderType BOX;        // 0x0
        public static HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderType SPHERE;        // 0x0
        public static HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderType CAPSULE;        // 0x0
        public static HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderType MESH;        // 0x0

    }

    // TypeToken: 0x2000136
    public class HEU_InputDataCollider
    {
        // Fields
        public UnityEngine.Collider _collider;        // 0x10
        public HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderType _colliderType;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000137
    public class HEU_InputDataMesh
    {
        // Fields
        public UnityEngine.Mesh _mesh;        // 0x10
        public UnityEngine.Material[] _materials;        // 0x18
        public System.String _meshPath;        // 0x20
        public System.String _meshName;        // 0x28
        public System.Int32 _numVertices;        // 0x30
        public System.Int32 _numSubMeshes;        // 0x34
        public System.UInt32[] _indexStart;        // 0x38
        public System.UInt32[] _indexCount;        // 0x40
        public System.Single _LODScreenTransition;        // 0x48
        public UnityEngine.Transform _transform;        // 0x50
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataCollider> _colliders;        // 0x58

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000139
    public class HEU_InputDataTerrain : HEU_InputData
    {
        // Fields
        public System.String _heightFieldName;        // 0x18
        public System.Int32 _parentNodeID;        // 0x20
        public System.Single _voxelSize;        // 0x24
        public UnityEngine.Terrain _terrain;        // 0x28
        public UnityEngine.TerrainData _terrainData;        // 0x30
        public System.Int32 _numPointsX;        // 0x38
        public System.Int32 _numPointsY;        // 0x3C
        public HoudiniEngineUnity.HAPI_Transform _transform;        // 0x40
        public System.Single _heightScale;        // 0x68
        public System.Int32 _heightfieldNodeID;        // 0x6C
        public System.Int32 _heightNodeID;        // 0x70
        public System.Int32 _maskNodeID;        // 0x74
        public System.Int32 _mergeNodeID;        // 0x78

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013C
    public class HEU_InputDataTilemap : HEU_InputData
    {
        // Fields
        public UnityEngine.Tilemaps.Tilemap _tilemap;        // 0x18
        public UnityEngine.Transform _transform;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000146
    public struct ToolType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_ShelfToolData.ToolType GENERATOR;        // 0x0
        public static HoudiniEngineUnity.HEU_ShelfToolData.ToolType OPERATOR_SINGLE;        // 0x0
        public static HoudiniEngineUnity.HEU_ShelfToolData.ToolType OPERATOR_MULTI;        // 0x0
        public static HoudiniEngineUnity.HEU_ShelfToolData.ToolType BATCH;        // 0x0

    }

    // TypeToken: 0x200014E
    public struct Type
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.JSONNode.Enumerator.Type None;        // 0x0
        public static HoudiniEngineUnity.JSONNode.Enumerator.Type Array;        // 0x0
        public static HoudiniEngineUnity.JSONNode.Enumerator.Type Object;        // 0x0

    }

    // TypeToken: 0x200014D
    public struct Enumerator
    {
        // Fields
        private HoudiniEngineUnity.JSONNode.Enumerator.Type type;        // 0x10
        private System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode> m_Object;        // 0x18
        private System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode> m_Array;        // 0x40

        // Methods
        private System.Boolean get_IsValid() { }
        private System.Void .ctor(System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode> aArrayEnum) { }
        private System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode> aDictEnum) { }
        private System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode> get_Current() { }
        private System.Boolean MoveNext() { }

    }

    // TypeToken: 0x200014F
    public struct ValueEnumerator
    {
        // Fields
        private HoudiniEngineUnity.JSONNode.Enumerator m_Enumerator;        // 0x10

        // Methods
        private System.Void .ctor(System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode> aArrayEnum) { }
        private System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode> aDictEnum) { }
        private System.Void .ctor(HoudiniEngineUnity.JSONNode.Enumerator aEnumerator) { }
        private HoudiniEngineUnity.JSONNode get_Current() { }
        private System.Boolean MoveNext() { }
        private HoudiniEngineUnity.JSONNode.ValueEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x2000150
    public struct KeyEnumerator
    {
        // Fields
        private HoudiniEngineUnity.JSONNode.Enumerator m_Enumerator;        // 0x10

        // Methods
        private System.Void .ctor(System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode> aArrayEnum) { }
        private System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode> aDictEnum) { }
        private System.Void .ctor(HoudiniEngineUnity.JSONNode.Enumerator aEnumerator) { }
        private System.String get_Current() { }
        private System.Boolean MoveNext() { }
        private HoudiniEngineUnity.JSONNode.KeyEnumerator GetEnumerator() { }

    }

    // TypeToken: 0x2000151
    public class LinqEnumerator, IEnumerator`1, IEnumerator, IDisposable, IEnumerable`1, IEnumerable
    {
        // Fields
        private HoudiniEngineUnity.JSONNode m_Node;        // 0x10
        private HoudiniEngineUnity.JSONNode.Enumerator m_Enumerator;        // 0x18

        // Methods
        private System.Void .ctor(HoudiniEngineUnity.JSONNode aNode) { }
        private System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode> get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Void Dispose() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode>> GetEnumerator() { }
        private System.Void Reset() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000164
    public class RequireStruct`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000165
    public class RequireClass`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001AF
    public struct PaintMergeMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeMode REPLACE;        // 0x0
        public static HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeMode ADD;        // 0x0
        public static HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeMode SUBTRACT;        // 0x0
        public static HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeMode MULTIPLY;        // 0x0

    }

    // TypeToken: 0x20001B0
    public struct PaintMeshVisibility
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_ToolsInfo.PaintMeshVisibility AUTO;        // 0x0
        public static HoudiniEngineUnity.HEU_ToolsInfo.PaintMeshVisibility SHOW;        // 0x0
        public static HoudiniEngineUnity.HEU_ToolsInfo.PaintMeshVisibility HIDE;        // 0x0

    }

namespace HoudiniEngineUnity
{

    // TypeToken: 0x200000B
    public struct HEU_AssetEventType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_AssetEventType UNKNOWN;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetEventType RELOAD;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetEventType COOK;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetEventType BAKE_NEW;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetEventType BAKE_UPDATE;        // 0x0

    }

    // TypeToken: 0x200000C
    public class HEU_AssetEventData
    {
        // Fields
        public HoudiniEngineUnity.HEU_HoudiniAsset Asset;        // 0x10
        public System.Boolean CookSuccess;        // 0x18
        public System.Collections.Generic.List<UnityEngine.GameObject> OutputObjects;        // 0x20
        public HoudiniEngineUnity.HEU_AssetEventType EventType;        // 0x28

        // Methods
        private System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean successful, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }

    }

    // TypeToken: 0x200000D
    public class HEU_ReloadEventData : HEU_AssetEventData
    {
        // Methods
        private System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean successful, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }

    }

    // TypeToken: 0x200000E
    public class HEU_CookedEventData : HEU_AssetEventData
    {
        // Methods
        private System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean successful, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }

    }

    // TypeToken: 0x200000F
    public class HEU_BakedEventData : HEU_AssetEventData
    {
        // Fields
        public System.Boolean IsNewBake;        // 0x30

        // Methods
        private System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean successful, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects, System.Boolean isNewBake) { }

    }

    // TypeToken: 0x2000010
    public class HEU_PreAssetEventData
    {
        // Fields
        public HoudiniEngineUnity.HEU_HoudiniAsset Asset;        // 0x10
        public HoudiniEngineUnity.HEU_AssetEventType AssetType;        // 0x18

        // Methods
        private System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, HoudiniEngineUnity.HEU_AssetEventType assetType) { }

    }

    // TypeToken: 0x2000011
    public class HEU_ReloadDataEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public class HEU_CookedDataEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public class HEU_BakedDataEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public class HEU_PreAssetEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000015
    public class HEU_AssetPreset
    {
        // Fields
        public System.Char[] _identifier;        // 0x10
        public System.Int32 _version;        // 0x18
        public System.String _assetOPName;        // 0x20
        public System.Byte[] _parameterPreset;        // 0x28
        public System.Collections.Generic.List<System.String> _curveNames;        // 0x30
        public System.Collections.Generic.List<System.Byte[]> _curvePresets;        // 0x38
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputPreset> inputPresets;        // 0x40
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCachePreset> volumeCachePresets;        // 0x48

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public class HEU_InputPreset
    {
        // Fields
        private HoudiniEngineUnity.HEU_InputNode.InputObjectType _inputObjectType;        // 0x10
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputObjectPreset> _inputObjectPresets;        // 0x18
        public System.String _inputAssetName;        // 0x20
        public System.Int32 _inputIndex;        // 0x28
        public System.String _inputName;        // 0x30
        public System.Boolean _keepWorldTransform;        // 0x38
        public System.Boolean _packGeometryBeforeMerging;        // 0x39
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputAssetPreset> _inputAssetPresets;        // 0x40

        // Methods
        private HoudiniEngineUnity.HEU_InputObjectTypeWrapper get_InputObjectType() { }
        private System.Void set_InputObjectType(HoudiniEngineUnity.HEU_InputObjectTypeWrapper value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000017
    public class HEU_InputObjectPreset
    {
        // Fields
        public System.String _gameObjectName;        // 0x10
        public System.Boolean _isSceneObject;        // 0x18
        public System.Boolean _useTransformOffset;        // 0x19
        public UnityEngine.Vector3 _translateOffset;        // 0x1C
        public UnityEngine.Vector3 _rotateOffset;        // 0x28
        public UnityEngine.Vector3 _scaleOffset;        // 0x34

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000018
    public class HEU_InputAssetPreset
    {
        // Fields
        public System.String _gameObjectName;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public class HEU_VolumeLayerPreset
    {
        // Fields
        public System.String _layerName;        // 0x10
        public System.Single _strength;        // 0x18
        public System.Boolean _uiExpanded;        // 0x1C
        public System.Int32 _tile;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001A
    public class HEU_VolumeCachePreset
    {
        // Fields
        public System.String _objName;        // 0x10
        public System.String _geoName;        // 0x18
        public System.Boolean _uiExpanded;        // 0x20
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayerPreset> _volumeLayersPresets;        // 0x28
        public System.String _terrainDataPath;        // 0x30
        public System.Int32 _tile;        // 0x38

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001B
    public class HEU_RecookPreset
    {
        // Fields
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCachePreset> _volumeCachePresets;        // 0x10
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputPreset> _inputPresets;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001C
    public class HEU_AssetPresetUtility
    {
        // Fields
        public static System.Char[] PRESET_IDENTIFIER;        // 0x0
        public static System.Int32 PRESET_VERSION;        // 0x8

        // Methods
        private System.Void SaveAssetPresetToFile(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String filePath) { }
        private System.Void LoadPresetFileIntoAssetAndCook(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String filePath) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001D
    public class HEU_Vector3SerializationSurrogate, ISerializationSurrogate
    {
        // Methods
        private System.Void System.Runtime.Serialization.ISerializationSurrogate.GetObjectData(System.Object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Object System.Runtime.Serialization.ISerializationSurrogate.SetObjectData(System.Object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Runtime.Serialization.ISurrogateSelector selector) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001E
    public class HEU_Vector2SerializationSurrogate, ISerializationSurrogate
    {
        // Methods
        private System.Void System.Runtime.Serialization.ISerializationSurrogate.GetObjectData(System.Object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Object System.Runtime.Serialization.ISerializationSurrogate.SetObjectData(System.Object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Runtime.Serialization.ISurrogateSelector selector) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public class HEU_AssetSerializedMetaData : ScriptableObject, IEquivable`1
    {
        // Fields
        private System.Boolean _softDeleted;        // 0x18
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData>> _savedCurveNodeData;        // 0x20
        private System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_InputCurveInfo> _savedInputCurveInfo;        // 0x28

        // Methods
        private System.Boolean get_SoftDeleted() { }
        private System.Void set_SoftDeleted(System.Boolean value) { }
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData>> get_SavedCurveNodeData() { }
        private System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_InputCurveInfo> get_SavedInputCurveInfo() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_AssetSerializedMetaData other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000020
    public class HEU_AssetUpdater
    {
        // Methods
        private System.Void .cctor() { }
        private System.Void OnBeforeAssemblyReload() { }
        private System.Void Update() { }
        private System.Void AddAssetForUpdate(HoudiniEngineUnity.HEU_HoudiniAsset asset) { }
        private System.Void RemoveAsset(HoudiniEngineUnity.HEU_HoudiniAsset asset) { }
        private System.Void AddNodeSyncForUpdate(HoudiniEngineUnity.HEU_BaseSync nodeSync) { }
        private System.Void RemoveNodeSync(HoudiniEngineUnity.HEU_BaseSync nodeSync) { }
        private System.Void OnPrefabInstanceUpdate(UnityEngine.GameObject instance) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public class CurveNodeData, IEquivable`1
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x10
        public UnityEngine.Vector3 rotation;        // 0x1C
        public UnityEngine.Vector3 scale;        // 0x28
        public System.Int32 curveCountIndex;        // 0x34

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Vector3 position) { }
        private System.Void .ctor(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void .ctor(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale) { }
        private System.Void .ctor(HoudiniEngineUnity.CurveNodeData other) { }
        private UnityEngine.Quaternion GetRotation() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.CurveNodeData other) { }

    }

    // TypeToken: 0x2000022
    public class HEU_InputCurveInfo
    {
        // Fields
        public HoudiniEngineUnity.HAPI_CurveType curveType;        // 0x10
        public System.Int32 order;        // 0x14
        public System.Boolean closed;        // 0x18
        public System.Boolean reverse;        // 0x19
        public HoudiniEngineUnity.HAPI_InputCurveMethod inputMethod;        // 0x1C
        public HoudiniEngineUnity.HAPI_InputCurveParameterization breakpointParameterization;        // 0x20

        // Methods
        private HoudiniEngineUnity.HEU_InputCurveInfo CreateFromHAPI_InputCurveInfo(HoudiniEngineUnity.HAPI_InputCurveInfo curveInfo) { }
        private System.String[] GetCurveTypeNames() { }
        private System.String[] GetInputMethodNames() { }
        private System.String[] GetBreakpointParameterizationNames() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000023
    public struct HEU_CurveDataType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_CurveDataType INVALID;        // 0x0
        public static HoudiniEngineUnity.HEU_CurveDataType GEO_COORDS_PARAM;        // 0x0
        public static HoudiniEngineUnity.HEU_CurveDataType HAPI_COORDS_PARAM;        // 0x0
        public static HoudiniEngineUnity.HEU_CurveDataType POSITION_ATTRIBUTE;        // 0x0

    }

    // TypeToken: 0x2000024
    public class HEU_Curve : ScriptableObject, IHEU_Curve, IHEU_HoudiniAssetSubcomponent, IEquivable`1
    {
        // Fields
        private System.Int32 _geoID;        // 0x18
        private System.Int32 _partID;        // 0x1C
        private System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> _curveNodeData;        // 0x20
        private UnityEngine.Vector3[] _vertices;        // 0x28
        private System.Boolean _isEditable;        // 0x30
        private HoudiniEngineUnity.HEU_Parameters _parameters;        // 0x38
        private System.Boolean _bUploadParameterPreset;        // 0x40
        private System.String _curveName;        // 0x48
        private UnityEngine.GameObject _targetGameObject;        // 0x50
        private System.Boolean _isGeoCurve;        // 0x58
        private HoudiniEngineUnity.HEU_Curve.CurveEditState _editState;        // 0x5C
        public static HoudiniEngineUnity.HEU_Curve.Interaction PreferredNextInteractionMode;        // 0x0
        private HoudiniEngineUnity.HEU_HoudiniAsset _parentAsset;        // 0x60
        private System.Boolean _bIsInputCurve;        // 0x68
        private System.Boolean _bIsPartCurve;        // 0x69
        private System.Boolean _cachedCurveInfoValid;        // 0x6A
        private System.Int32[] _cachedCurveCounts;        // 0x70
        private System.Int32[] _cachedCurveCountSums;        // 0x78
        private HoudiniEngineUnity.HEU_CurveDataType _curveDataType;        // 0x80
        private HoudiniEngineUnity.HEU_InputCurveInfo _inputCurveInfo;        // 0x88

        // Methods
        private UnityEngine.GameObject get_TargetGameObject() { }
        private System.Void set_TargetGameObject(UnityEngine.GameObject value) { }
        private System.Int32 get_GeoID() { }
        private System.Int32 get_PartID() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> get_CurveNodeData() { }
        private HoudiniEngineUnity.HEU_Parameters get_Parameters() { }
        private System.String get_CurveName() { }
        private System.Boolean get_IsInputCurve() { }
        private System.Boolean get_IsPartCurve() { }
        private HoudiniEngineUnity.HEU_InputCurveInfo get_InputCurveInfo() { }
        private System.Void SetUploadParameterPreset(System.Boolean bValue) { }
        private HoudiniEngineUnity.HEU_Curve.CurveEditState get_EditState() { }
        private HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset() { }
        private HoudiniEngineUnity.HEU_CurveDataType get_CurveDataType() { }
        private HoudiniEngineUnity.HEU_SessionBase GetSession() { }
        private System.Void Recook() { }
        private System.Boolean IsEditable() { }
        private System.Boolean IsGeoCurve() { }
        private System.Void SetCurveName(System.String name) { }
        private System.Void SetCurvePoint(System.Int32 pointIndex, UnityEngine.Vector3 newPosition, System.Boolean bRecookAsset) { }
        private System.Void SetCurvePoint(System.Int32 pointIndex, HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset) { }
        private System.Void SetCurveNodeData(System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> curveNodeData, System.Boolean bRecookAsset) { }
        private UnityEngine.Vector3 GetCurvePoint(System.Int32 pointIndex) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> GetAllPointTransforms() { }
        private System.Collections.Generic.List<UnityEngine.Vector3> GetAllPoints() { }
        private System.Int32 GetNumPoints() { }
        private System.Void InsertCurvePoint(System.Int32 index, UnityEngine.Vector3 position, System.Boolean bRecookAsset) { }
        private System.Void InsertCurvePoint(System.Int32 index, HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset) { }
        private System.Void AddCurvePointToEnd(UnityEngine.Vector3 position, System.Boolean bRecookAsset) { }
        private System.Void AddCurvePointToEnd(HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset) { }
        private System.Void RemoveCurvePoint(System.Int32 pointIndex, System.Boolean bRecookAsset) { }
        private System.Void ClearCurveNodeData(System.Boolean bRecookAsset) { }
        private System.Void ProjectToColliders(UnityEngine.Vector3 rayDirection, System.Single rayDistance, System.Boolean bRecookAsset) { }
        private System.Void SetCurveGeometryVisibility(System.Boolean bVisible, System.Boolean bRecookAsset) { }
        private UnityEngine.Vector3 GetTransformedPoint(System.Int32 pointIndex) { }
        private System.Collections.Generic.List<UnityEngine.Vector3> GetTransformedPoints() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> DuplicateCurveNodeData() { }
        private HoudiniEngineUnity.HEU_Curve CreateSetupCurve(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean isEditable, System.String curveName, System.Int32 geoID, System.Int32 partID, System.Boolean bGeoCurve) { }
        private System.Void UsePreviousCurveData(System.String curveName) { }
        private HoudiniEngineUnity.HEU_CurveDataType GetCurveDataType(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Boolean ShouldKeepNode(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void DestroyAllData(System.Boolean bIsRebuild) { }
        private System.Void UploadParameterPreset(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset) { }
        private System.Void ResetCurveParameters(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset) { }
        private System.Void SetCurveParameterPreset(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Byte[] parameterPreset) { }
        private System.Void UpdateCurve(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 partId) { }
        private System.Int32[] GetCurveCounts(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoId, System.Int32 partID) { }
        private System.Void GenerateMesh(UnityEngine.GameObject inGameObject, HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void GenerateMeshForSingleObject(UnityEngine.GameObject targetObject, UnityEngine.Vector3[] vertexList) { }
        private System.Void OnPresyncParameters(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset) { }
        private System.Int32 GetOrderForCurveType(System.Int32 requestedOrder, HoudiniEngineUnity.HAPI_CurveType curveType) { }
        private System.Boolean UpdateCurveInputForCurveParts(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset) { }
        private System.Boolean UpdateCurveInputForCustomAttributes(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset) { }
        private System.Void SyncFromParameters(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean bNewCurve) { }
        private System.Void UpdatePoints(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void ProjectToCollidersInternal(HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, UnityEngine.Vector3 rayDirection, System.Single rayDistance) { }
        private System.String GetPointsString(System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> points) { }
        private System.String GetPointsString(System.Collections.Generic.List<UnityEngine.Vector3> points) { }
        private System.Void SetEditState(HoudiniEngineUnity.HEU_Curve.CurveEditState editState) { }
        private UnityEngine.Vector3 GetTransformedPosition(UnityEngine.Vector3 inPosition) { }
        private UnityEngine.Vector3 GetInvertedTransformedPosition(UnityEngine.Vector3 inPosition) { }
        private UnityEngine.Vector3 GetInvertedTransformedDirection(UnityEngine.Vector3 inPosition) { }
        private UnityEngine.Vector3[] GetVertices() { }
        private System.Void SetCurveGeometryVisibilityInternal(System.Boolean bVisible) { }
        private System.Void DownloadPresetData(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void UploadPresetData(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void DownloadAsDefaultPresetData(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void UpdateCachedCurveInfo(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean copyCurveSettings) { }
        private System.Int32 GetCurveCountIndexFromPositionIndex(System.Int32 positionIndex) { }
        private System.Boolean IsMeshCurve(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_Curve other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002C
    public class HEU_GeneratedOutput, IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HEU_GeneratedOutputData _outputData;        // 0x10
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutputData> _childOutputs;        // 0x18
        private System.Boolean isInstancer;        // 0x20

        // Methods
        private System.Boolean get_IsInstancer() { }
        private System.Void set_IsInstancer(System.Boolean value) { }
        private System.Void ResetMaterialOverrides(HoudiniEngineUnity.HEU_GeneratedOutput output) { }
        private System.Void ResetMaterialOverrides(HoudiniEngineUnity.HEU_GeneratedOutputData outputData) { }
        private UnityEngine.Material[] GetGeneratedMaterialsForGameObject(HoudiniEngineUnity.HEU_GeneratedOutput output, UnityEngine.GameObject inGameObject) { }
        private System.Boolean HasLODGroup(HoudiniEngineUnity.HEU_GeneratedOutput output) { }
        private System.Boolean IsOutputUsingMaterial(UnityEngine.Material checkMaterial, HoudiniEngineUnity.HEU_GeneratedOutput output) { }
        private System.Boolean IsOutputDataUsingMaterial(UnityEngine.Material checkMaterial, HoudiniEngineUnity.HEU_GeneratedOutputData outputData) { }
        private System.Void ClearGeneratedMaterialReferences(HoudiniEngineUnity.HEU_GeneratedOutputData generatedOutputData) { }
        private System.Void DestroyAllGeneratedColliders(HoudiniEngineUnity.HEU_GeneratedOutputData outputData) { }
        private System.Void DestroyGeneratedOutput(HoudiniEngineUnity.HEU_GeneratedOutput generatedOutput) { }
        private System.Void DestroyGeneratedOutputChildren(HoudiniEngineUnity.HEU_GeneratedOutput generatedOutput) { }
        private System.Void DestroyGeneratedOutputData(HoudiniEngineUnity.HEU_GeneratedOutputData generatedOutputData, System.Boolean bDontDeletePersistantResources) { }
        private System.Void ClearMaterialsNoLongerUsed(UnityEngine.Material[] materialsToCheck, UnityEngine.Material[] materialsInUse) { }
        private System.Void CopyMaterialOverrides(HoudiniEngineUnity.HEU_GeneratedOutputData sourceOutputData, HoudiniEngineUnity.HEU_GeneratedOutputData destOutputData) { }
        private System.Void WriteOutputToAssetCache(UnityEngine.GameObject parentObject, System.String outputPath, System.Boolean bIsInstancer) { }
        private System.Void BakeGameObjectComponents(UnityEngine.GameObject sourceGO, UnityEngine.GameObject targetGO, System.String assetName, System.String outputPath, System.Boolean bIsInstancer) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_GeneratedOutput other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002D
    public class HEU_GeneratedOutputData, IEquivable`1
    {
        // Fields
        public UnityEngine.GameObject _gameObject;        // 0x10
        public UnityEngine.Material[] _renderMaterials;        // 0x18
        public System.Collections.Generic.List<UnityEngine.Collider> _colliders;        // 0x20

        // Methods
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_GeneratedOutputData other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002E
    public class HEU_GeoNode : ScriptableObject, IHEU_GeoNode, IHEU_HoudiniAssetSubcomponent, ISerializationCallbackReceiver, IEquivable`1
    {
        // Fields
        private HoudiniEngineUnity.HAPI_GeoInfo _geoInfo;        // 0x18
        private System.String _geoName;        // 0x40
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> _parts;        // 0x48
        private HoudiniEngineUnity.HEU_ObjectNode _containerObjectNode;        // 0x50
        private HoudiniEngineUnity.HEU_InputNode _inputNode;        // 0x58
        private HoudiniEngineUnity.HEU_Curve _geoCurve;        // 0x60
        private HoudiniEngineUnity.HEU_VolumeCache _volumeCache;        // 0x68
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> _volumeCaches;        // 0x70

        // Methods
        private HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset() { }
        private System.Int32 get_GeoID() { }
        private HoudiniEngineUnity.HAPI_GeoInfo get_GeoInfo() { }
        private System.String get_GeoName() { }
        private HoudiniEngineUnity.HAPI_GeoType get_GeoType() { }
        private System.Boolean get_Editable() { }
        private System.Boolean get_Displayable() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> get_Parts() { }
        private HoudiniEngineUnity.HEU_ObjectNode get_ObjectNode() { }
        private HoudiniEngineUnity.HEU_InputNode get_InputNode() { }
        private HoudiniEngineUnity.HEU_Curve get_GeoCurve() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> get_VolumeCaches() { }
        private System.Void .ctor() { }
        private System.Void OnBeforeSerialize() { }
        private System.Void OnAfterDeserialize() { }
        private HoudiniEngineUnity.HEU_SessionBase GetSession() { }
        private System.Void Recook() { }
        private System.Boolean IsVisible() { }
        private System.Boolean IsIntermediate() { }
        private System.Boolean IsIntermediateOrEditable() { }
        private System.Boolean IsGeoInputType() { }
        private System.Boolean IsGeoCurveType() { }
        private System.Void DestroyAllData(System.Boolean bIsRebuild) { }
        private System.Void RemoveAndDestroyPart(HoudiniEngineUnity.HEU_PartData part) { }
        private System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        private System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs) { }
        private HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject outputGameObject) { }
        private HoudiniEngineUnity.HEU_PartData GetPartFromPartID(System.Int32 partID) { }
        private System.Void GetCurves(System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> curves, System.Boolean bEditableOnly) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> GetParts() { }
        private System.Void HideAllGeometry() { }
        private System.Void DisableAllColliders() { }
        private HoudiniEngineUnity.HEU_VolumeCache GetVolumeCacheByTileIndex(System.Int32 tileIndex) { }
        private System.Void Reset() { }
        private System.Void Initialize(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_GeoInfo geoInfo, HoudiniEngineUnity.HEU_ObjectNode containerObjectNode) { }
        private System.Boolean DoesThisRequirePotentialCook() { }
        private System.Void UpdateGeo(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void ProcessUnityScriptAttribute(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void ProcessPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 partID, HoudiniEngineUnity.HAPI_PartInfo& partInfo, HoudiniEngineUnity.HEU_PartData& partData) { }
        private System.Void SetupGameObjectAndTransform(HoudiniEngineUnity.HEU_PartData partData, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset) { }
        private System.Void GetPartsByOutputType(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> meshParts, System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> volumeParts) { }
        private System.Void GeneratePartInstances(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void GenerateAttributesStore(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void ProcessGeoCurve(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void SetupGeoCurveGameObjectAndTransform(HoudiniEngineUnity.HEU_Curve curve) { }
        private System.Void ClearObjectInstances() { }
        private System.Void SetGeoInfo(HoudiniEngineUnity.HAPI_GeoInfo geoInfo) { }
        private System.String GeneratePartFullName(System.String partName) { }
        private System.String GenerateGeoCurveName() { }
        private System.Boolean HasGeoNodeChanged(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void ApplyHAPITransform(HoudiniEngineUnity.HAPI_Transform& hapiTransform) { }
        private System.Void GetDebugInfo(System.Text.StringBuilder sb) { }
        private System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData) { }
        private System.Void GetClonableParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> clonableParts) { }
        private System.Boolean HasAttribInstancer() { }
        private System.Void SetAttributeModifiersOnPartOutputs(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void CalculateVisiblity(System.Boolean bParentVisibility) { }
        private System.Void CalculateColliderState() { }
        private System.Void ProcessVolumeParts(HoudiniEngineUnity.HEU_SessionBase session, System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> volumeParts, System.Boolean bRebuild) { }
        private System.Void DestroyVolumeCache() { }
        private System.String ToString() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_GeoNode other) { }

    }

    // TypeToken: 0x200002F
    public class HEU_HoudiniAsset : MonoBehaviour, IHEU_HoudiniAsset, IEquivable`1
    {
        // Fields
        private HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType _assetType;        // 0x18
        private HoudiniEngineUnity.HAPI_AssetInfo _assetInfo;        // 0x1C
        private HoudiniEngineUnity.HAPI_NodeInfo _nodeInfo;        // 0x5C
        private System.String _assetName;        // 0xA0
        private System.String _assetOpName;        // 0xA8
        private System.String _assetHelp;        // 0xB0
        private System.Int32 _assetID;        // 0xB8
        private System.String _assetPath;        // 0xC0
        private System.Boolean _loadAssetFromMemory;        // 0xC8
        private System.Boolean _alwaysOverwriteOnLoad;        // 0xC9
        private UnityEngine.Object _assetFileObject;        // 0xD0
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectNode> _objectNodes;        // 0xD8
        private UnityEngine.GameObject _rootGameObject;        // 0xE0
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> _materialCache;        // 0xE8
        private HoudiniEngineUnity.HEU_Parameters _parameters;        // 0xF0
        private UnityEngine.Matrix4x4 _lastSyncedTransformMatrix;        // 0xF8
        private System.Collections.Generic.List<UnityEngine.Matrix4x4> _lastSyncedChildTransformMatrices;        // 0x138
        private System.String _assetCacheFolderPath;        // 0x140
        private System.String[] _subassetNames;        // 0x148
        private System.Int32 _selectedSubassetIndex;        // 0x150
        private HoudiniEngineUnity.HEU_AssetPreset _savedAssetPreset;        // 0x158
        private HoudiniEngineUnity.HEU_RecookPreset _recookPreset;        // 0x160
        private System.Int32 _totalCookCount;        // 0x168
        private HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction _requestBuildAction;        // 0x16C
        private System.Boolean _checkParameterChangeForCook;        // 0x170
        private System.Boolean _skipCookCheck;        // 0x171
        private System.Boolean _uploadParameters;        // 0x172
        private System.Boolean _forceUploadInputs;        // 0x173
        private System.Boolean _upstreamCookChanged;        // 0x174
        private HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus _cookStatus;        // 0x178
        private HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult _lastCookResult;        // 0x17C
        private System.Boolean _isCookingAssetReloaded;        // 0x180
        private System.Boolean _bForceUpdate;        // 0x181
        private System.Int64 _sessionID;        // 0x188
        private System.Boolean <WarnedPrefabNotSupported>k__BackingField;        // 0x190
        private System.Boolean _uiLocked;        // 0x191
        private System.Boolean _showHDAOptions;        // 0x192
        private System.Boolean _showGenerateSection;        // 0x193
        private System.Boolean _showBakeSection;        // 0x194
        private System.Boolean _showEventsSection;        // 0x195
        private System.Boolean _showCurvesSection;        // 0x196
        private System.Boolean _showInputNodesSection;        // 0x197
        private System.Boolean _showToolsSection;        // 0x198
        private System.Boolean _showTerrainSection;        // 0x199
        private HoudiniEngineUnity.HEU_InstanceInputUIState _instanceInputUIState;        // 0x1A0
        private HoudiniEngineUnity.HEU_ReloadDataEvent _reloadDataEvent;        // 0x1A8
        private HoudiniEngineUnity.HEU_CookedDataEvent _cookedDataEvent;        // 0x1B0
        private HoudiniEngineUnity.HEU_BakedDataEvent _bakedDataEvent;        // 0x1B8
        private HoudiniEngineUnity.HEU_PreAssetEvent _preAssetEvent;        // 0x1C0
        private HoudiniEngineUnity.HEU_HoudiniAsset.UpdateUIDelegate _refreshUIDelegate;        // 0x1C8
        private HoudiniEngineUnity.HEU_CookedDataEvent _downstreamConnectionCookedEvent;        // 0x1D0
        private System.Boolean _generateUVs;        // 0x1D8
        private System.Boolean _generateTangents;        // 0x1D9
        private System.Boolean _generateNormals;        // 0x1DA
        private System.Boolean _pushTransformToHoudini;        // 0x1DB
        private System.Boolean _transformChangeTriggersCooks;        // 0x1DC
        private System.Boolean _cookingTriggersDownCooks;        // 0x1DD
        private System.Boolean _autoCookOnParameterChange;        // 0x1DE
        private System.Boolean _ignoreNonDisplayNodes;        // 0x1DF
        private System.Boolean _useOutputNodes;        // 0x1E0
        private System.Boolean _generateMeshUsingPoints;        // 0x1E1
        private System.Boolean _useLODGroups;        // 0x1E2
        private System.Boolean _splitGeosByGroup;        // 0x1E3
        private System.Boolean _sessionSyncAutoCook;        // 0x1E4
        private System.Boolean _bakeUpdateKeepPreviousTransformValues;        // 0x1E5
        private System.Boolean _pauseCooking;        // 0x1E6
        private System.Boolean _curveEditorEnabled;        // 0x1E7
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> _curves;        // 0x1E8
        private HoudiniEngineUnity.HEU_Curve.CurveDrawCollision _curveDrawCollision;        // 0x1F0
        private System.Collections.Generic.List<UnityEngine.Collider> _curveDrawColliders;        // 0x1F8
        private UnityEngine.LayerMask _curveDrawLayerMask;        // 0x200
        private System.Single _curveProjectMaxDistance;        // 0x204
        private UnityEngine.Vector3 _curveProjectDirection;        // 0x208
        private System.Boolean _curveProjectDirectionToView;        // 0x214
        private System.Boolean _curveDisableScaleRotation;        // 0x215
        private System.Boolean _curveCookOnDrag;        // 0x216
        private System.Boolean _curveFrameSelectedNodes;        // 0x217
        private System.Single _curveFrameSelectedNodeDistance;        // 0x218
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> _inputNodes;        // 0x220
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> _handles;        // 0x228
        private System.Boolean _handlesEnabled;        // 0x230
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> _volumeCaches;        // 0x238
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributesStore> _attributeStores;        // 0x240
        private System.Boolean _editableNodesToolsEnabled;        // 0x248
        private HoudiniEngineUnity.HEU_ToolsInfo _toolsInfo;        // 0x250
        private HoudiniEngineUnity.HEU_AssetSerializedMetaData _serializedMetaData;        // 0x258
        private System.Boolean _pendingAutoCookOnMouseRelease;        // 0x260

        // Methods
        private System.Boolean get_LoadAssetFromMemory() { }
        private System.Void set_LoadAssetFromMemory(System.Boolean value) { }
        private System.Boolean get_AlwaysOverwriteOnLoad() { }
        private System.Void set_AlwaysOverwriteOnLoad(System.Boolean value) { }
        private System.Boolean get_GenerateUVs() { }
        private System.Void set_GenerateUVs(System.Boolean value) { }
        private System.Boolean get_GenerateTangents() { }
        private System.Void set_GenerateTangents(System.Boolean value) { }
        private System.Boolean get_GenerateNormals() { }
        private System.Void set_GenerateNormals(System.Boolean value) { }
        private System.Boolean get_PushTransformToHoudini() { }
        private System.Void set_PushTransformToHoudini(System.Boolean value) { }
        private System.Boolean get_TransformChangeTriggersCooks() { }
        private System.Void set_TransformChangeTriggersCooks(System.Boolean value) { }
        private System.Boolean get_CookingTriggersDownCooks() { }
        private System.Void set_CookingTriggersDownCooks(System.Boolean value) { }
        private System.Boolean get_AutoCookOnParameterChange() { }
        private System.Void set_AutoCookOnParameterChange(System.Boolean value) { }
        private System.Boolean get_IgnoreNonDisplayNodes() { }
        private System.Void set_IgnoreNonDisplayNodes(System.Boolean value) { }
        private System.Boolean get_UseOutputNodes() { }
        private System.Void set_UseOutputNodes(System.Boolean value) { }
        private System.Boolean get_GenerateMeshUsingPoints() { }
        private System.Void set_GenerateMeshUsingPoints(System.Boolean value) { }
        private System.Boolean get_UseLODGroups() { }
        private System.Void set_UseLODGroups(System.Boolean value) { }
        private System.Boolean get_SplitGeosByGroup() { }
        private System.Void set_SplitGeosByGroup(System.Boolean value) { }
        private System.Boolean get_SessionSyncAutoCook() { }
        private System.Void set_SessionSyncAutoCook(System.Boolean value) { }
        private System.Boolean get_BakeUpdateKeepPreviousTransformValues() { }
        private System.Void set_BakeUpdateKeepPreviousTransformValues(System.Boolean value) { }
        private System.Boolean get_PauseCooking() { }
        private System.Void set_PauseCooking(System.Boolean value) { }
        private System.Boolean get_CurveEditorEnabled() { }
        private System.Void set_CurveEditorEnabled(System.Boolean value) { }
        private HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper get_CurveDrawCollision() { }
        private System.Void set_CurveDrawCollision(HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper value) { }
        private UnityEngine.LayerMask get_CurveDrawLayerMask() { }
        private System.Void set_CurveDrawLayerMask(UnityEngine.LayerMask value) { }
        private System.Single get_CurveProjectMaxDistance() { }
        private System.Void set_CurveProjectMaxDistance(System.Single value) { }
        private UnityEngine.Vector3 get_CurveProjectDirection() { }
        private System.Void set_CurveProjectDirection(UnityEngine.Vector3 value) { }
        private System.Boolean get_CurveProjectDirectionToView() { }
        private System.Void set_CurveProjectDirectionToView(System.Boolean value) { }
        private System.Boolean get_CurveDisableScaleRotation() { }
        private System.Void set_CurveDisableScaleRotation(System.Boolean value) { }
        private System.Boolean get_CurveFrameSelectedNodes() { }
        private System.Void set_CurveFrameSelectedNodes(System.Boolean value) { }
        private System.Single get_CurveFrameSelectedNodeDistance() { }
        private System.Void set_CurveFrameSelectedNodeDistance(System.Single value) { }
        private System.Boolean get_HandlesEnabled() { }
        private System.Void set_HandlesEnabled(System.Boolean value) { }
        private System.Boolean get_EditableNodesToolsEnabled() { }
        private System.Void set_EditableNodesToolsEnabled(System.Boolean value) { }
        private HoudiniEngineUnity.HEU_AssetTypeWrapper get_AssetType() { }
        private HoudiniEngineUnity.HAPI_AssetInfo get_AssetInfo() { }
        private HoudiniEngineUnity.HAPI_NodeInfo get_NodeInfo() { }
        private System.String get_AssetName() { }
        private System.String get_AssetOpName() { }
        private System.String get_AssetHelp() { }
        private System.Int32 get_AssetID() { }
        private System.String get_AssetPath() { }
        private UnityEngine.GameObject get_OwnerGameObject() { }
        private UnityEngine.GameObject get_RootGameObject() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> get_MaterialCache() { }
        private HoudiniEngineUnity.HEU_Parameters get_Parameters() { }
        private System.String get_AssetCacheFolder() { }
        private System.String[] get_SubassetNames() { }
        private System.Int32 get_SelectedSubassetIndex() { }
        private HoudiniEngineUnity.HEU_AssetCookStatusWrapper get_CookStatus() { }
        private HoudiniEngineUnity.HEU_AssetCookResultWrapper get_LastCookResult() { }
        private System.Int64 get_SessionID() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> get_Curves() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> get_InputNodes() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> get_VolumeCaches() { }
        private HoudiniEngineUnity.HEU_ReloadDataEvent get_ReloadDataEvent() { }
        private HoudiniEngineUnity.HEU_CookedDataEvent get_CookedDataEvent() { }
        private HoudiniEngineUnity.HEU_BakedDataEvent get_BakedDataEvent() { }
        private HoudiniEngineUnity.HEU_PreAssetEvent get_PreAssetEvent() { }
        private HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType get_AssetTypeInternal() { }
        private HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus GetCookStatus() { }
        private HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult GetLastCookResult() { }
        private System.Boolean get_WarnedPrefabNotSupported() { }
        private System.Void set_WarnedPrefabNotSupported(System.Boolean value) { }
        private HoudiniEngineUnity.HEU_InstanceInputUIState get_InstanceInputUIState() { }
        private System.Void set_InstanceInputUIState(HoudiniEngineUnity.HEU_InstanceInputUIState value) { }
        private HoudiniEngineUnity.HEU_HoudiniAsset.UpdateUIDelegate get_RefreshUIDelegate() { }
        private System.Void set_RefreshUIDelegate(HoudiniEngineUnity.HEU_HoudiniAsset.UpdateUIDelegate value) { }
        private HoudiniEngineUnity.HEU_Curve.CurveDrawCollision get_CurveDrawCollisionInternal() { }
        private System.Collections.Generic.List<UnityEngine.Collider> GetCurveDrawColliders() { }
        private UnityEngine.LayerMask GetCurveDrawLayerMask() { }
        private System.Void SetCurveDrawLayerMask(UnityEngine.LayerMask mask) { }
        private System.Boolean get_CurveCookOnDrag() { }
        private System.Void set_CurveCookOnDrag(System.Boolean value) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> get_Handles() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributesStore> get_AttributeStores() { }
        private HoudiniEngineUnity.HEU_ToolsInfo get_ToolsInfo() { }
        private HoudiniEngineUnity.HEU_AssetSerializedMetaData get_SerializedMetaData() { }
        private System.Boolean get_PendingAutoCookOnMouseRelease() { }
        private System.Void set_PendingAutoCookOnMouseRelease(System.Boolean value) { }
        private System.Boolean RequestCook(System.Boolean bCheckParametersChanged, System.Boolean bAsync, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters) { }
        private System.Boolean RequestReload(System.Boolean bAsync) { }
        private System.Boolean RequestResetParameters(System.Boolean bAsync) { }
        private UnityEngine.GameObject DuplicateAsset(UnityEngine.GameObject newRootGameObject) { }
        private System.Boolean DeleteAllGeneratedData(System.Boolean bIsRebuild) { }
        private UnityEngine.GameObject BakeToNewPrefab(System.String destinationPrefabPath) { }
        private UnityEngine.GameObject BakeToNewStandalone() { }
        private System.Boolean BakeToExistingPrefab(UnityEngine.GameObject bakeTargetGO) { }
        private System.Boolean BakeToExistingStandalone(UnityEngine.GameObject bakeTargetGO) { }
        private System.Boolean IsAssetValid() { }
        private System.Boolean GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        private System.Boolean GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs) { }
        private HoudiniEngineUnity.HEU_Curve GetCurve(System.String curveName) { }
        private System.Boolean AddCurveDrawCollider(UnityEngine.Collider newCollider) { }
        private System.Boolean RemoveCurveDrawCollider(UnityEngine.Collider collider) { }
        private System.Boolean ClearCurveDrawColliders() { }
        private HoudiniEngineUnity.HEU_InputNode GetInputNode(System.String inputName) { }
        private HoudiniEngineUnity.HEU_InputNode GetAssetInputNode(System.String inputName) { }
        private HoudiniEngineUnity.HEU_InputNode GetInputNodeByIndex(System.Int32 index) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> GetNonParameterInputNodes() { }
        private System.Int32 GetVolumeCacheCount() { }
        private HoudiniEngineUnity.HEU_SessionBase GetAssetSession(System.Boolean bCreateIfInvalid) { }
        private HoudiniEngineUnity.HEU_ObjectNode GetObjectNodeByName(System.String objName) { }
        private System.Void GetOutputGeoNodes(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> outputGeoNodes) { }
        private HoudiniEngineUnity.HEU_PartData GetInternalHDAPartWithGameObject(UnityEngine.GameObject outputGameObject) { }
        private System.Void ResetParametersToDefault() { }
        private System.Void HideAllGeometry() { }
        private System.Void DisableAllColliders() { }
        private HoudiniEngineUnity.HEU_MaterialData GetMaterialData(UnityEngine.Material material) { }
        private System.Void ClearMaterialCache() { }
        private System.Void RemoveMaterial(UnityEngine.Material material) { }
        private System.Void ResetMaterialOverrides() { }
        private HoudiniEngineUnity.HEU_AssetPreset GetAssetPreset() { }
        private HoudiniEngineUnity.HEU_PDGAssetLink GetOrCreatePDGAssetLink() { }
        private HoudiniEngineUnity.HEU_HoudiniAssetRoot InstantiateHDA(System.String filePath, System.Boolean bAsync, UnityEngine.Vector3 initialPosition) { }
        private HoudiniEngineUnity.HEU_PartData GetSceneHDAPartWithGameObject(UnityEngine.GameObject outputGameObject) { }
        private HoudiniEngineUnity.HEU_HoudiniAsset GetSceneHDAAssetFromGameObject(UnityEngine.GameObject outputGameObject) { }
        private System.Boolean IsHoudiniAssetOutput(UnityEngine.GameObject go) { }
        private System.Boolean IsHoudiniAssetRoot(UnityEngine.GameObject go) { }
        private System.Void SetupAsset(HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType assetType, System.String filePath, UnityEngine.GameObject rootGameObject, HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void CleanUpAndDisable() { }
        private System.Boolean IsAssetSavedInScene() { }
        private System.Void Awake() { }
        private System.Void InvalidateAsset() { }
        private System.Void OnEnable() { }
        private System.Void OnDestroy() { }
        private System.Void AssetUpdate() { }
        private System.Void PostAssetUpdate() { }
        private System.Void RequestBakeInPlace() { }
        private System.Void ClearBuildRequest() { }
        private System.Boolean HasValidAssetPath() { }
        private System.Void ProcessRebuild(System.Boolean bPromptForSubasset, System.Int32 desiredSubassetIndex) { }
        private System.Void InvokeReloadEvent(System.Boolean bCookSuccess, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        private System.Boolean StartRebuild(System.Boolean bPromptForSubasset, System.Int32 desiredSubassetIndex) { }
        private System.Boolean FinishRebuild() { }
        private System.Boolean RecookAsync(System.Boolean bCheckParamsChanged, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters, System.Boolean bUploadParameterPreset, System.Boolean bForceUploadInputs, System.Boolean bCookingSessionSync) { }
        private System.Boolean RecookBlocking(System.Boolean bCheckParamsChanged, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters, System.Boolean bUploadParameterPreset, System.Boolean bForceUploadInputs, System.Boolean bCookingSessionSync) { }
        private System.Void DoPostCookWork(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Boolean IsValidForInteraction(System.String& errorMessage) { }
        private System.Void OnValidate() { }
        private System.Void ExecutePostCookCallbacks() { }
        private System.Void InvokePostCookEvent(System.Boolean bCookSuccess, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        private System.Boolean InternalStartRecook(System.Boolean bCheckParamsChanged, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters, System.Boolean bUploadParameterPreset, System.Boolean bForceUploadInputs, System.Boolean bCookingSessionSync) { }
        private System.Void InternalSetAssetID(System.Int32 assetID) { }
        private System.Void SetCookStatus(HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus status, HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult result) { }
        private System.Void ProcessPoskCook() { }
        private System.Boolean StartHoudiniCookNode(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void ProcessHoudiniCookStatus(System.Boolean bAsync) { }
        private System.Boolean DoesAssetRequireRecook() { }
        private System.Void DeleteSessionDataOnly() { }
        private System.Void CleanUpInputNodes() { }
        private System.Void DeleteAssetCacheData(System.Boolean bRegisterUndo) { }
        private System.Void GenerateParameters(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void DownloadParameterPresetFromHoudini(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void UploadParameterPresetToHoudini(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void UpdateParameterInputsToHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bForceUpdate) { }
        private System.Boolean LoadAssetFileWithSubasset(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bPromptForSubasset, System.Int32 desiredSubassetIndex) { }
        private System.Boolean CreateAndCookAsset(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 subassetIndex, System.Int32& newAssetID, System.Boolean bCookTemplatedGeos) { }
        private System.Void CreateAssetInputs(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void ForceUploadParameters(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void UploadCurvesParameters(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bCheckParamsChanged) { }
        private System.Void UploadAttributeValues(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void SyncDirtyAttributesToHoudini(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void UploadInputNodes(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bForceUpdate, System.Boolean bUpdateAll) { }
        private System.Boolean HasInputNodeTransformChanged() { }
        private System.Void NotifyInputNodesCookFinished() { }
        private System.Boolean CreateObjects(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void UpdateAllObjectNodes(HoudiniEngineUnity.HEU_SessionBase session) { }
        private HoudiniEngineUnity.HEU_ObjectNode CreateObjectNode(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ObjectInfo& objectInfo, HoudiniEngineUnity.HAPI_Transform& objectTranform) { }
        private System.Void GenerateObjectsGeometry(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bRebuild) { }
        private System.Int32 NumAttributeStores() { }
        private HoudiniEngineUnity.HEU_AttributesStore GetAttributeStore(System.String geoName, System.Int32 partID) { }
        private System.Void GenerateAttributesStore(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void GenerateInstances(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void GenerateHandles(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void CleanUpHandles() { }
        private HoudiniEngineUnity.HEU_Handle GetHandleByName(System.String handleName) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> GetHandles() { }
        private System.Int32 NumHandles() { }
        private HoudiniEngineUnity.HAPI_Transform GetObjectTransform(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 objectID) { }
        private HoudiniEngineUnity.HEU_ObjectNode GetObjectWithID(System.Int32 objId) { }
        private System.Void InvokeBakedEvent(System.Boolean bSuccess, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects, System.Boolean isNewBake) { }
        private UnityEngine.GameObject CloneAssetWithoutHDA(System.String& bakedAssetPath, System.Boolean bWriteMeshesToAssetDatabase, System.Boolean bReconnectPrefabInstances) { }
        private System.Void NotifyUpstreamCooked(HoudiniEngineUnity.HEU_CookedEventData Data) { }
        private System.Void ConnectToUpstream(HoudiniEngineUnity.HEU_HoudiniAsset upstreamAsset) { }
        private System.Void DisconnectFromUpstream(HoudiniEngineUnity.HEU_HoudiniAsset upstreamAsset) { }
        private System.Void AddDownstreamConnection(UnityEngine.Events.UnityAction<HoudiniEngineUnity.HEU_CookedEventData> receiver) { }
        private System.Void RemoveDownstreamConnection(UnityEngine.Events.UnityAction<HoudiniEngineUnity.HEU_CookedEventData> receiver) { }
        private System.Void ClearAllUpstreamConnections() { }
        private System.Void UpdateInputsOnAssetRecreation(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void ReconnectInputsUpstreamNotifications() { }
        private System.Void GetHoudiniTransformAndApply(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void UploadUnityTransform(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bOnlySendIfChangedFromLastSync) { }
        private System.Void UpdateHoudiniMaterials(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void RemoveUnusedMaterials() { }
        private System.Boolean IsAssetValidInHoudini(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Boolean HasTransformChangedSinceLastUpdate() { }
        private System.Void GetClonableParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> clonableParts) { }
        private System.Void ClearInvalidCurves() { }
        private System.Int32 GetEditableCurveCount() { }
        private System.Void AddCurve(HoudiniEngineUnity.HEU_Curve curve) { }
        private System.Void RemoveCurve(HoudiniEngineUnity.HEU_Curve curve) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> GetInputNodes() { }
        private System.Void AddInputNode(HoudiniEngineUnity.HEU_InputNode node) { }
        private System.Void RemoveInputNode(HoudiniEngineUnity.HEU_InputNode node) { }
        private System.Void InputNodeNotifyRemoved(HoudiniEngineUnity.HEU_InputNode node) { }
        private System.Void AddVolumeCache(HoudiniEngineUnity.HEU_VolumeCache cache) { }
        private System.Void RemoveVolumeCache(HoudiniEngineUnity.HEU_VolumeCache cache) { }
        private System.Void AddAttributeStore(HoudiniEngineUnity.HEU_AttributesStore attributeStore) { }
        private System.Void RemoveAttributeStore(HoudiniEngineUnity.HEU_AttributesStore attributeStore) { }
        private System.Void ReorderAttributeStore(System.Int32 oldIndex, System.Int32 newIndex) { }
        private System.Void PopulateObjectInstanceInfos(System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> objInstanceInfos) { }
        private System.Void AddToAssetDBCache(System.String assetObjectFileName, UnityEngine.Object objectToAdd, System.String relativeFolderPath, UnityEngine.Object& targetAssetDBObject) { }
        private System.Void SetCurvesVisibilityInScene(System.Boolean bShow) { }
        private System.String GetValidAssetCacheFolderPath() { }
        private System.Void CalculateVisibility() { }
        private System.Void CalculateColliderState() { }
        private System.Void LoadAssetPresetAndCook(HoudiniEngineUnity.HEU_AssetPreset assetPreset) { }
        private System.Void ApplyRecookPreset() { }
        private System.Boolean ApplyInputPresets(HoudiniEngineUnity.HEU_SessionBase session, System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputPreset> inputPresets, System.Boolean bAddMissingInputsToRecookPreset) { }
        private HoudiniEngineUnity.HEU_VolumeCachePreset GetVolumeCachePreset(System.String objName, System.String geoName, System.Int32 tile) { }
        private System.Void RemoveVolumeCachePreset(HoudiniEngineUnity.HEU_VolumeCachePreset preset) { }
        private System.Boolean ApplyVolumeCachePresets(System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCachePreset> volumeCachePresets) { }
        private System.Void SyncInternalParametersForUndoCompare() { }
        private System.Boolean UpdateSessionSync() { }
        private System.Void UpdateTotalCookCount() { }
        private System.Void ResetAndCopyInstantiatedProperties(HoudiniEngineUnity.HEU_HoudiniAsset newAsset) { }
        private HoudiniEngineUnity.HEU_HoudiniAsset.AssetInstantiationMethod GetInstantiationMethod() { }
        private HoudiniEngineUnity.HEU_HoudiniAsset GetInstantiatedObject() { }
        private System.Void ClearInvalidLists() { }
        private System.Void CopyPropertiesTo(HoudiniEngineUnity.HEU_HoudiniAsset newAsset) { }
        private System.Void SetSoftDeleted() { }
        private System.Void SyncChildTransforms() { }
        private HoudiniEngineUnity.HEU_AssetCookStatusWrapper AssetCookStatus_InternalToWrappper(HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus assetCookStatus) { }
        private HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus AssetCookStatus_WrapperToInternal(HoudiniEngineUnity.HEU_AssetCookStatusWrapper assetCookStatus) { }
        private HoudiniEngineUnity.HEU_AssetCookResultWrapper AssetCookResult_InternalToWrapper(HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult assetCookResult) { }
        private HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult AssetCookResult_WrapperToInternal(HoudiniEngineUnity.HEU_AssetCookResultWrapper assetCookResult) { }
        private HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper CurveDrawCollision_InternalToWrapper(HoudiniEngineUnity.HEU_Curve.CurveDrawCollision curveDrawCollision) { }
        private HoudiniEngineUnity.HEU_Curve.CurveDrawCollision CurveDrawCollision_WrapperToInternal(HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper curveDrawCollision) { }
        private HoudiniEngineUnity.HEU_AssetTypeWrapper AssetType_InternalToWrapper(HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType assetType) { }
        private HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType AssetType_WrapperToInternal(HoudiniEngineUnity.HEU_AssetTypeWrapper assetType) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_HoudiniAsset asset) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000039
    public class HEU_HoudiniAssetRoot : MonoBehaviour
    {
        // Fields
        private HoudiniEngineUnity.HEU_HoudiniAsset _houdiniAsset;        // 0x18
        private System.Collections.Generic.List<UnityEngine.GameObject> _bakeTargets;        // 0x20

        // Methods
        private HoudiniEngineUnity.HEU_HoudiniAsset get_HoudiniAsset() { }
        private System.Collections.Generic.List<UnityEngine.GameObject> get_BakeTargets() { }
        private System.Void OnDestroy() { }
        private System.Void RemoveHoudiniEngineAssetData() { }
        private System.Void ClearHoudiniEngineReferences() { }
        private System.Void DestroyRootComponent(HoudiniEngineUnity.HEU_HoudiniAssetRoot assetRoot) { }
        private System.Void Reset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003A
    public class HEU_InputNode : ScriptableObject, IHEU_InputNode, IHEU_HoudiniAssetSubcomponent, IEquivable`1
    {
        // Fields
        private HoudiniEngineUnity.HEU_InputNode.InputNodeType _inputNodeType;        // 0x18
        private HoudiniEngineUnity.HEU_InputNode.InputObjectType _inputObjectType;        // 0x1C
        private HoudiniEngineUnity.HEU_InputNode.InputObjectType _pendingInputObjectType;        // 0x20
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputObjectInfo> _inputObjects;        // 0x28
        private System.Collections.Generic.List<System.Int32> _inputObjectsConnectedAssetIDs;        // 0x30
        private UnityEngine.GameObject _inputAsset;        // 0x38
        private UnityEngine.GameObject _connectedInputAsset;        // 0x40
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputHDAInfo> _inputAssetInfos;        // 0x48
        private System.Int32 _nodeID;        // 0x50
        private System.Int32 _inputIndex;        // 0x54
        private System.Boolean _requiresCook;        // 0x58
        private System.Boolean _requiresUpload;        // 0x59
        private System.String _inputName;        // 0x60
        private System.String _labelName;        // 0x68
        private System.String _paramName;        // 0x70
        private System.Int32 _connectedNodeID;        // 0x78
        private System.Boolean _keepWorldTransform;        // 0x7C
        private System.Boolean _packGeometryBeforeMerging;        // 0x7D
        private HoudiniEngineUnity.HEU_HoudiniAsset _parentAsset;        // 0x80
        private HoudiniEngineUnity.HEU_InputInterfaceMeshSettings _meshSettings;        // 0x88
        private HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings _tilemapSettings;        // 0x90
        private System.Boolean _usingSelectFromHierarchy;        // 0x98
        public HoudiniEngineUnity.HEU_InputNodeUICache _uiCache;        // 0xA0

        // Methods
        private HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset() { }
        private System.Boolean get_KeepWorldTransform() { }
        private System.Void set_KeepWorldTransform(System.Boolean value) { }
        private System.Boolean get_PackGeometryBeforeMerging() { }
        private System.Void set_PackGeometryBeforeMerging(System.Boolean value) { }
        private HoudiniEngineUnity.HEU_InputNodeTypeWrapper get_NodeType() { }
        private HoudiniEngineUnity.HEU_InputObjectTypeWrapper get_ObjectType() { }
        private HoudiniEngineUnity.HEU_InputObjectTypeWrapper get_PendingObjectType() { }
        private System.Void set_PendingObjectType(HoudiniEngineUnity.HEU_InputObjectTypeWrapper value) { }
        private System.Int32 get_InputNodeID() { }
        private System.String get_InputName() { }
        private System.String get_LabelName() { }
        private System.String get_ParamName() { }
        private HoudiniEngineUnity.HEU_InputInterfaceMeshSettings get_MeshSettings() { }
        private HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings get_TilemapSettings() { }
        private HoudiniEngineUnity.HEU_InputNode.InputNodeType get_InputType() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputObjectInfo> get_InputObjects() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputHDAInfo> get_InputAssetInfos() { }
        private System.Boolean get_RequiresCook() { }
        private System.Void set_RequiresCook(System.Boolean value) { }
        private System.Boolean get_RequiresUpload() { }
        private System.Void set_RequiresUpload(System.Boolean value) { }
        private HoudiniEngineUnity.HEU_SessionBase GetSession() { }
        private System.Void Recook() { }
        private System.Boolean IsAssetInput() { }
        private System.Int32 NumInputEntries() { }
        private UnityEngine.GameObject GetInputEntryGameObject(System.Int32 index) { }
        private UnityEngine.GameObject[] GetInputEntryGameObjects() { }
        private System.Void SetInputEntry(System.Int32 index, UnityEngine.GameObject newInputGameObject, System.Boolean bRecookAsset) { }
        private System.Void InsertInputEntry(System.Int32 index, UnityEngine.GameObject newInputGameObject, System.Boolean bRecookAsset) { }
        private System.Void AddInputEntryAtEnd(UnityEngine.GameObject newEntryGameObject, System.Boolean bRecookAsset) { }
        private System.Void ResetInputNode(System.Boolean bRecookAsset) { }
        private System.Void ChangeInputType(HoudiniEngineUnity.HEU_InputObjectTypeWrapper newType, System.Boolean bRecookAsset) { }
        private System.Void RemoveInputEntry(System.Int32 index, System.Boolean bRecookAsset) { }
        private System.Void RemoveAllInputEntries(System.Boolean bRecookAsset) { }
        private System.Void SetInputEntryObjectUseTransformOffset(System.Int32 index, System.Boolean value, System.Boolean bRecookAsset) { }
        private System.Void SetInputEntryObjectTransformTranslateOffset(System.Int32 index, UnityEngine.Vector3 translateOffset, System.Boolean bRecookAsset) { }
        private System.Void SetInputEntryObjectTransformRotateOffset(System.Int32 index, UnityEngine.Vector3 rotateOffset, System.Boolean bRecookAsset) { }
        private System.Void SetInputEntryObjectTransformScaleOffset(System.Int32 index, UnityEngine.Vector3 scaleOffset, System.Boolean bRecookAsset) { }
        private System.Boolean AreAnyInputHDAsConnected() { }
        private System.Int32 GetConnectedInputCount() { }
        private System.Int32 GetConnectedNodeID(System.Int32 index) { }
        private System.Void LoadPreset(HoudiniEngineUnity.HEU_InputPreset inputPreset) { }
        private System.Void PopulateInputPreset(HoudiniEngineUnity.HEU_InputPreset inputPreset) { }
        private HoudiniEngineUnity.HEU_InputNode CreateSetupInput(System.Int32 nodeID, System.Int32 inputIndex, System.String inputName, System.String labelName, HoudiniEngineUnity.HEU_InputNode.InputNodeType inputNodeType, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset) { }
        private System.Void SetInputNodeID(System.Int32 nodeID) { }
        private System.Void DestroyAllData(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void ResetInputObjectTransforms() { }
        private System.Void ResetInputNode(HoudiniEngineUnity.HEU_SessionBase session) { }
        private HoudiniEngineUnity.HEU_InputObjectInfo AddInputEntryAtEndMesh(UnityEngine.GameObject newEntryGameObject) { }
        private HoudiniEngineUnity.HEU_InputHDAInfo AddInputEntryAtEndHDA(UnityEngine.GameObject newEntryGameObject) { }
        private System.Void ChangeInputType(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputNode.InputObjectType newType) { }
        private System.Void ResetConnectionForForceUpdate(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void UploadInput(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void UploadHDAInput(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void UploadUnityInput(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void ReconnectToUpstreamAsset() { }
        private HoudiniEngineUnity.HEU_InputObjectInfo CreateInputObjectInfo(UnityEngine.GameObject inputGameObject) { }
        private HoudiniEngineUnity.HEU_InputHDAInfo CreateInputHDAInfo(UnityEngine.GameObject inputGameObject) { }
        private HoudiniEngineUnity.HEU_InputObjectInfo InternalAddInputObjectAtEnd(UnityEngine.GameObject newInputGameObject) { }
        private HoudiniEngineUnity.HEU_InputHDAInfo InternalAddInputHDAAtEnd(UnityEngine.GameObject newInputHDA) { }
        private System.Void DisconnectConnectedMergeNode(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void ClearConnectedInputHDAs() { }
        private System.Void ConnectToMergeObject(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void DisconnectAndDestroyInputs(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Boolean UploadObjectMergeTransformType(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Boolean UploadObjectMergePackGeometry(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Boolean HasInputNodeTransformChanged() { }
        private System.Void UploadInputObjectTransforms(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void UpdateOnAssetRecreation(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void CopyInputValuesTo(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputNode destInputNode) { }
        private System.Void LoadPreset(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputPreset inputPreset) { }
        private System.Boolean FindAddToInputHDA(System.String gameObjectName) { }
        private System.Void NotifyParentRemovedInput() { }
        private System.Void ClearUICache() { }
        private System.Void HandleSelectedObjectsForInputObjects(UnityEngine.GameObject[] selectedObjects) { }
        private System.Void HandleSelectedObjectsForInputHDAs(UnityEngine.GameObject[] selectedObjects) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InputNode other) { }
        private HoudiniEngineUnity.HEU_InputNode.InternalObjectType GetInternalObjectType(HoudiniEngineUnity.HEU_InputNode.InputObjectType type) { }
        private HoudiniEngineUnity.HEU_InputNodeTypeWrapper InputNodeType_InternalToWrapper(HoudiniEngineUnity.HEU_InputNode.InputNodeType inputNodeType) { }
        private HoudiniEngineUnity.HEU_InputNode.InputNodeType InputNodeType_InternalToWrapper(HoudiniEngineUnity.HEU_InputNodeTypeWrapper inputNodeType) { }
        private HoudiniEngineUnity.HEU_InputObjectTypeWrapper InputObjectType_InternalToWrapper(HoudiniEngineUnity.HEU_InputNode.InputObjectType inputType) { }
        private HoudiniEngineUnity.HEU_InputNode.InputObjectType InputObjectType_WrapperToInternal(HoudiniEngineUnity.HEU_InputObjectTypeWrapper inputType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003F
    public class HEU_InputObjectInfo, IEquivable`1
    {
        // Fields
        public UnityEngine.GameObject _gameObject;        // 0x10
        public UnityEngine.Terrain _terrainReference;        // 0x18
        public HEU_BoundingVolume _boundingVolumeReference;        // 0x20
        public UnityEngine.Tilemaps.Tilemap _tilemapReference;        // 0x28
        public UnityEngine.Matrix4x4 _syncdTransform;        // 0x30
        public System.Collections.Generic.List<UnityEngine.Matrix4x4> _syncdChildTransforms;        // 0x70
        public System.Boolean _useTransformOffset;        // 0x78
        public UnityEngine.Vector3 _translateOffset;        // 0x7C
        public UnityEngine.Vector3 _rotateOffset;        // 0x88
        public UnityEngine.Vector3 _scaleOffset;        // 0x94
        public System.Type _inputInterfaceType;        // 0xA0

        // Methods
        private System.Void CopyTo(HoudiniEngineUnity.HEU_InputObjectInfo destObject) { }
        private System.Void SetReferencesFromGameObject() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InputObjectInfo other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000040
    public class HEU_InputHDAInfo, IEquivable`1
    {
        // Fields
        public UnityEngine.GameObject _pendingGO;        // 0x10
        public UnityEngine.GameObject _connectedGO;        // 0x18
        public System.Int32 _connectedInputNodeID;        // 0x20
        public System.Int32 _connectedMergeNodeID;        // 0x24

        // Methods
        private System.Void CopyTo(HoudiniEngineUnity.HEU_InputHDAInfo destInfo) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InputHDAInfo other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000041
    public class HEU_InputNodeUICache
    {
        // Fields
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNodeUICache.HEU_InputObjectUICache> _inputObjectCache;        // 0x10
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNodeUICache.HEU_InputAssetUICache> _inputAssetCache;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000044
    public class HEU_InstanceInputUIState : ScriptableObject, IEquivable`1
    {
        // Fields
        public System.Boolean _showInstanceInputs;        // 0x18
        public System.Int32 _numInputsToShowUI;        // 0x1C
        public System.Int32 _inputsPageIndexUI;        // 0x20

        // Methods
        private System.Void CopyTo(HoudiniEngineUnity.HEU_InstanceInputUIState dest) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InstanceInputUIState other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000045
    public class HEU_ObjectInstanceInfo : ScriptableObject, IEquivable`1
    {
        // Fields
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_InstancedInput> _instancedInputs;        // 0x18
        public HoudiniEngineUnity.HEU_PartData _partTarget;        // 0x20
        public System.Int32 _instancedObjectNodeID;        // 0x28
        public System.String _instancedObjectPath;        // 0x30
        public System.Collections.Generic.List<UnityEngine.GameObject> _instances;        // 0x38

        // Methods
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ObjectInstanceInfo other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000046
    public class HEU_InstancedInput, IEquivable`1
    {
        // Fields
        public UnityEngine.GameObject _instancedGameObject;        // 0x10
        public UnityEngine.Vector3 _rotationOffset;        // 0x18
        public UnityEngine.Vector3 _scaleOffset;        // 0x24

        // Methods
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InstancedInput other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000047
    public class HEU_ObjectNode : ScriptableObject, IHEU_ObjectNode, IHEU_HoudiniAssetSubcomponent, IEquivable`1
    {
        // Fields
        private System.String _objName;        // 0x18
        private HoudiniEngineUnity.HEU_HoudiniAsset _parentAsset;        // 0x20
        private HoudiniEngineUnity.HAPI_ObjectInfo _objectInfo;        // 0x28
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> _geoNodes;        // 0x48
        private HoudiniEngineUnity.HAPI_Transform _objectTransform;        // 0x50
        private System.Collections.Generic.List<System.Int32> _recentlyDestroyedParts;        // 0x78

        // Methods
        private HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset() { }
        private System.Int32 get_ObjectID() { }
        private System.String get_ObjectName() { }
        private HoudiniEngineUnity.HAPI_ObjectInfo get_ObjectInfo() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> get_GeoNodes() { }
        private HoudiniEngineUnity.HAPI_Transform get_ObjectTransform() { }
        private HoudiniEngineUnity.HEU_SessionBase GetSession() { }
        private System.Void Recook() { }
        private System.Boolean IsInstanced() { }
        private System.Boolean IsVisible() { }
        private System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData) { }
        private System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        private System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs) { }
        private HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject outputGameObject) { }
        private HoudiniEngineUnity.HEU_GeoNode GetGeoNode(System.String geoName) { }
        private System.Void GetCurves(System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> curves, System.Boolean bEditableOnly) { }
        private System.Void GetOutputGeoNodes(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> outGeoNodes) { }
        private System.Void HideAllGeometry() { }
        private System.Void DisableAllColliders() { }
        private System.Boolean IsInstancer() { }
        private System.Void .ctor() { }
        private System.Void Reset() { }
        private System.Void SyncWithObjectInfo(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void Initialize(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ObjectInfo objectInfo, HoudiniEngineUnity.HAPI_Transform objectTranform, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean bUseOutputNodes) { }
        private System.Void GatherAllAssetOutputsLegacy(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ObjectInfo objectInfo, System.Boolean bUseOutputNodes, System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode>& geoNodes) { }
        private System.Void DestroyAllData(System.Boolean bIsRebuild) { }
        private HoudiniEngineUnity.HEU_GeoNode CreateGeoNode(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_GeoInfo geoInfo) { }
        private System.Void GetDebugInfo(System.Text.StringBuilder sb) { }
        private System.Void SetObjectInfo(HoudiniEngineUnity.HAPI_ObjectInfo newObjectInfo) { }
        private System.Void UpdateObject(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bForceUpdate) { }
        private System.Void GenerateGeometry(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bRebuild) { }
        private System.Void GeneratePartInstances(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void GenerateAttributesStore(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void ApplyObjectTransformToGeoNodes() { }
        private System.Void GetClonableParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> clonableParts) { }
        private System.Void GenerateObjectInstances(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void ClearObjectInstances(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void PopulateObjectInstanceInfos(System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> objInstanceInfos) { }
        private System.Void ProcessUnityScriptAttributes(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void CalculateVisibility() { }
        private System.Void CalculateColliderState() { }
        private System.String ToString() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ObjectNode other) { }

    }

    // TypeToken: 0x2000048
    public class HEU_PartData : ScriptableObject, IHEU_PartData, IHEU_HoudiniAssetSubcomponent, IEquivable`1
    {
        // Fields
        private System.Int32 _partID;        // 0x18
        private System.String _partName;        // 0x20
        private System.Int32 _objectNodeID;        // 0x28
        private System.Int32 _geoID;        // 0x2C
        private HoudiniEngineUnity.HAPI_PartType _partType;        // 0x30
        private HoudiniEngineUnity.HEU_GeoNode _geoNode;        // 0x38
        private System.Boolean _isAttribInstancer;        // 0x40
        private System.Boolean _isPartInstanced;        // 0x41
        private System.Int32 _partPointCount;        // 0x44
        private System.Boolean _isObjectInstancer;        // 0x48
        private System.Boolean _objectInstancesGenerated;        // 0x49
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> _objectInstanceInfos;        // 0x50
        private UnityEngine.Vector3 _terrainOffsetPosition;        // 0x58
        private UnityEngine.Object _assetDBTerrainData;        // 0x68
        private System.Boolean _isPartEditable;        // 0x70
        private HoudiniEngineUnity.HEU_PartData.PartOutputType _partOutputType;        // 0x74
        private HoudiniEngineUnity.HEU_Curve _curve;        // 0x78
        private HoudiniEngineUnity.HEU_AttributesStore _attributesStore;        // 0x80
        private System.Boolean _haveInstancesBeenGenerated;        // 0x88
        private System.Int32 _meshVertexCount;        // 0x8C
        private HoudiniEngineUnity.HEU_GeneratedOutput _generatedOutput;        // 0x90
        private System.String _volumeLayerName;        // 0x98

        // Methods
        private HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset() { }
        private System.Int32 get_PartID() { }
        private System.String get_PartName() { }
        private System.Int32 get_GeoID() { }
        private HoudiniEngineUnity.HAPI_PartType get_PartType() { }
        private HoudiniEngineUnity.HEU_GeoNode get_ParentGeoNode() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> get_ObjectInstanceInfos() { }
        private HoudiniEngineUnity.HEU_Curve get_Curve() { }
        private System.Int32 get_MeshVertexCount() { }
        private HoudiniEngineUnity.HEU_GeneratedOutput get_GeneratedOutput() { }
        private UnityEngine.GameObject get_OutputGameObject() { }
        private System.Void .ctor() { }
        private HoudiniEngineUnity.HEU_SessionBase GetSession() { }
        private System.Void Recook() { }
        private System.Boolean IsPartInstancer() { }
        private System.Boolean IsAttribInstancer() { }
        private System.Boolean IsInstancerAnyType() { }
        private System.Boolean IsPartInstanced() { }
        private System.Int32 GetPartPointCount() { }
        private System.Boolean IsObjectInstancer() { }
        private System.Boolean IsPartVolume() { }
        private System.Boolean IsPartCurve() { }
        private System.Boolean IsPartMesh() { }
        private System.Boolean IsPartEditable() { }
        private System.Boolean HaveInstancesBeenGenerated() { }
        private System.Void SetGameObjectName(System.String partName) { }
        private System.Void SetGameObject(UnityEngine.GameObject gameObject) { }
        private System.Void SetVolumeLayerName(System.String name) { }
        private System.String GetVolumeLayerName() { }
        private System.Void DestroyAllData(System.Boolean bIsRebuild) { }
        private System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData) { }
        private System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        private System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs) { }
        private HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject inGameObject) { }
        private System.Void CalculateVisibility(System.Boolean bParentVisibility, System.Boolean bParentDisplayGeo) { }
        private System.Void ClearInstances() { }
        private HoudiniEngineUnity.HEU_Curve GetCurve(System.Boolean bEditableOnly) { }
        private System.Void SetVisiblity(System.Boolean bVisibility) { }
        private System.Void SetColliderState(System.Boolean bEnabled) { }
        private HoudiniEngineUnity.HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectPath(System.String path) { }
        private HoudiniEngineUnity.HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectID(System.Int32 objNodeID) { }
        private System.Void SetTerrainOffsetPosition(UnityEngine.Vector3 offsetPosition) { }
        private System.Void SetTerrainData(UnityEngine.TerrainData terrainData, System.String exportPathRelative, System.String exportPathUser) { }
        private System.Void Initialize(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 partID, System.Int32 geoID, System.Int32 objectNodeID, HoudiniEngineUnity.HEU_GeoNode geoNode, HoudiniEngineUnity.HAPI_PartInfo& partInfo, HoudiniEngineUnity.HEU_PartData.PartOutputType partOutputType, System.Boolean isEditable, System.Boolean isObjectInstancer, System.Boolean isAttribInstancer) { }
        private System.Void ApplyHAPITransform(HoudiniEngineUnity.HAPI_Transform& hapiTransform) { }
        private System.Void GetDebugInfo(System.Text.StringBuilder sb) { }
        private System.Void GetClonableObjects(System.Collections.Generic.List<UnityEngine.GameObject> clonableObjects) { }
        private System.Void GetClonableParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> clonableParts) { }
        private System.Void SetObjectInstancer(System.Boolean bObjectInstancer) { }
        private System.Void ClearObjectInstanceInfos() { }
        private System.Void ClearInvalidObjectInstanceInfos() { }
        private System.Void ClearGeneratedData() { }
        private System.Void ClearGeneratedMeshOutput() { }
        private System.Void ClearGeneratedVolumeOutput() { }
        private System.Boolean GeneratePartInstances(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void GenerateInstancesFromObjectID(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 objectNodeID, System.String[] instancePrefixes, System.String[] instanceMaterialPaths) { }
        private System.Void GenerateInstancesFromObject(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_ObjectNode sourceObject, System.String[] instancePrefixes, System.String[] instanceMaterialPaths) { }
        private System.Void GenerateInstancesFromObjectIds(HoudiniEngineUnity.HEU_SessionBase session, System.String[] instancePrefixes, System.String[] instanceMaterialPaths) { }
        private System.Void GenerateInstancesFromUnityAssetPathAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.String unityInstanceAttr) { }
        private System.Void CreateNewInstanceFromObject(UnityEngine.GameObject sourceObject, System.Int32 instanceIndex, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HAPI_Transform& hapiTransform, System.Int32 instancedObjectNodeID, System.String instancedObjectPath, UnityEngine.Vector3 rotationOffset, UnityEngine.Vector3 scaleOffset, System.String[] instancePrefixes, System.String[] instanceMaterialPaths, UnityEngine.GameObject collisionSrcGO, System.Boolean copyParentFlags) { }
        private System.Void GenerateAttributesStore(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void CalculateColliderState() { }
        private System.Void CopyGameObjectComponents(HoudiniEngineUnity.HEU_PartData partData, UnityEngine.GameObject sourceGO, UnityEngine.GameObject targetGO, System.String assetName, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bDeleteExistingComponents, System.Boolean bDontDeletePersistantResources, System.Collections.Generic.List<HoudiniEngineUnity.TransformData> lodTransformValues) { }
        private System.Void CopyChildGameObjects(HoudiniEngineUnity.HEU_PartData partData, UnityEngine.GameObject sourceGO, UnityEngine.GameObject targetGO, System.String assetName, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bDeleteExistingComponents, System.Boolean bDontDeletePersistantResources, System.Boolean bKeepPreviousTransformValues) { }
        private UnityEngine.GameObject BakePartToNewGameObject(UnityEngine.Transform parentTransform, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bReconnectPrefabInstances) { }
        private System.Void BakePartToGameObject(HoudiniEngineUnity.HEU_PartData partData, UnityEngine.GameObject srcGO, UnityEngine.GameObject targetGO, System.String assetName, System.Boolean bIsInstancer, System.Boolean bDeleteExistingComponents, System.Boolean bDontDeletePersistantResources, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bReconnectPrefabInstances, System.Boolean bKeepPreviousTransformValues) { }
        private System.Void BakePartToGameObject(UnityEngine.GameObject targetGO, System.Boolean bDeleteExistingComponents, System.Boolean bDontDeletePersistantResources, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bReconnectPrefabInstances, System.Boolean bKeepPreviousTransformValues) { }
        private System.Boolean GenerateMesh(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bUseLODGroups) { }
        private System.Void ProcessCurvePart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 partId) { }
        private System.Void SyncAttributesStore(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, HoudiniEngineUnity.HAPI_PartInfo& partInfo) { }
        private System.Void SetupAttributeGeometry(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void DestroyAttributesStore() { }
        private System.Void PopulateObjectInstanceInfos(System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> objInstanceInfos) { }
        private System.Void SetObjectInstanceInfos(System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> sourceObjectInstanceInfos) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> GetObjectInstanceInfos() { }
        private HoudiniEngineUnity.HEU_ObjectInstanceInfo CreateObjectInstanceInfo(UnityEngine.GameObject instancedObject, System.Int32 instancedObjectNodeID, System.String instancedObjectPath) { }
        private System.String AppendBakedCloneName(System.String name) { }
        private System.String ToString() { }
        private System.Void DestroyParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> parts, System.Boolean bIsRebuild) { }
        private System.Void DestroyPart(HoudiniEngineUnity.HEU_PartData part, System.Boolean bIsRebuild) { }
        private System.Boolean ComposeUnityInstanceSplitHierarchy(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.Transform parentTransform, System.Int32 numInstances, UnityEngine.Transform[]& instanceToChildTransform) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_PartData other) { }

    }

    // TypeToken: 0x200004E
    public class HEU_AttributeData, IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_AttributeInfo _attributeInfo;        // 0x10
        public System.String _name;        // 0x38
        public HoudiniEngineUnity.HEU_AttributeData.AttributeType _attributeType;        // 0x40
        public System.Int32[] _intValues;        // 0x48
        public System.Single[] _floatValues;        // 0x50
        public System.String[] _stringValues;        // 0x58
        public HoudiniEngineUnity.HEU_AttributeData.AttributeState _attributeState;        // 0x60

        // Methods
        private System.Boolean IsColorAttribute() { }
        private System.Void CopyValuesTo(HoudiniEngineUnity.HEU_AttributeData destAttrData) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_AttributeData other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000051
    public class HEU_AttributesStore : ScriptableObject, IEquivable`1
    {
        // Fields
        private System.Int32 _geoID;        // 0x18
        private System.Int32 _partID;        // 0x1C
        private System.String _geoName;        // 0x20
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributeData> _attributeDatas;        // 0x28
        private System.Boolean _hasColorAttribute;        // 0x30
        private UnityEngine.Material _localMaterial;        // 0x38
        private UnityEngine.Transform _outputTransform;        // 0x40
        private UnityEngine.Vector3[] _positionAttributeValues;        // 0x48
        private System.Int32[] _vertexIndices;        // 0x50
        private UnityEngine.GameObject _outputGameObject;        // 0x58
        private UnityEngine.Mesh _outputMesh;        // 0x60
        private UnityEngine.Material[] _outputMaterials;        // 0x68
        private UnityEngine.MeshCollider _outputCollider;        // 0x70
        private UnityEngine.Mesh _outputColliderMesh;        // 0x78
        private UnityEngine.MeshCollider _outputMeshCollider;        // 0x80
        private UnityEngine.MeshCollider _localMeshCollider;        // 0x88
        private System.Boolean _outputMeshRendererInitiallyEnabled;        // 0x90
        private System.Boolean _outputMeshColliderInitiallyEnabled;        // 0x91

        // Methods
        private System.Int32 get_GeoID() { }
        private System.Int32 get_PartID() { }
        private System.String get_GeoName() { }
        private System.Boolean HasColorAttribute() { }
        private UnityEngine.Transform get_OutputTransform() { }
        private UnityEngine.Mesh get_OutputMesh() { }
        private System.Void DestroyAllData(HoudiniEngineUnity.HEU_HoudiniAsset asset) { }
        private System.Void SyncAllAttributesFrom(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Int32 geoID, HoudiniEngineUnity.HAPI_PartInfo& partInfo, UnityEngine.GameObject outputGameObject) { }
        private System.Void SetupMeshAndMaterials(HoudiniEngineUnity.HEU_HoudiniAsset asset, HoudiniEngineUnity.HAPI_PartType partType, UnityEngine.GameObject outputGameObject) { }
        private System.Boolean HasDirtyAttributes() { }
        private System.Void SyncDirtyAttributesToHoudini(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void PopulateAttributeData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_AttributeData attributeData, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo) { }
        private System.Void GetAttributesList(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributeData> attributesList, HoudiniEngineUnity.HAPI_AttributeOwner ownerType, System.Int32 attributeCount) { }
        private System.Void UpdateAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_AttributeData attributeData) { }
        private System.Void UpdateAttributeList(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributeData> attributeDataList) { }
        private System.Void RefreshUpstreamInputs(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Boolean UploadAttributeViaMeshInput(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID) { }
        private System.Void SetAttributeDataSyncd(HoudiniEngineUnity.HEU_AttributeData attributeData) { }
        private System.Void SetAttributeDataDirty(HoudiniEngineUnity.HEU_AttributeData attributeData) { }
        private HoudiniEngineUnity.HEU_AttributeData CreateAttribute(System.String attributeName, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo) { }
        private HoudiniEngineUnity.HEU_AttributeData GetAttributeData(System.String name) { }
        private HoudiniEngineUnity.HEU_AttributeData GetAttributeData(System.Int32 index) { }
        private System.Collections.Generic.List<System.String> GetAttributeNames() { }
        private System.Void EnablePaintCollider() { }
        private System.Void DisablePaintCollider() { }
        private System.Void ShowPaintMesh() { }
        private System.Void HidePaintMesh() { }
        private System.Boolean HasMeshForPainting() { }
        private UnityEngine.MeshCollider GetPaintMeshCollider() { }
        private System.Void PaintAttribute(HoudiniEngineUnity.HEU_AttributeData attributeData, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 attributeIndex, System.Single paintFactor, HoudiniEngineUnity.HEU_AttributesStore.SetAttributeValueFunc setAttrFunc) { }
        private System.Void SetAttributeEditValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 startIndex, System.Int32[] values) { }
        private System.Void SetAttributeEditValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 startIndex, System.Single[] values) { }
        private System.Void SetAttributeEditValueString(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 startIndex, System.String[] values) { }
        private System.Void ReplaceAttributeValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        private System.Void AddAttributeValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        private System.Void SubtractAttributeValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        private System.Void MultiplyAttributeValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        private System.Void ReplaceAttributeValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        private System.Void AddAttributeValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        private System.Void SubtractAttributeValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        private System.Void MultiplyAttributeValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        private System.Void SetAttributeValueString(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor) { }
        private System.Void FillAttribute(HoudiniEngineUnity.HEU_AttributeData attributeData, HoudiniEngineUnity.HEU_ToolsInfo sourceTools) { }
        private System.Boolean AreAttributesDirty() { }
        private System.Void GetPositionAttributeValues(UnityEngine.Vector3[]& positionArray) { }
        private System.Void GetVertexIndices(System.Int32[]& indices) { }
        private HoudiniEngineUnity.HEU_AttributesStore.SetAttributeValueFunc GetAttributeSetValueFunction(HoudiniEngineUnity.HEU_AttributeData.AttributeType attrType, HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeMode paintMergeMode) { }
        private System.Void CopyAttributeValuesTo(HoudiniEngineUnity.HEU_AttributesStore destAttrStore) { }
        private System.Boolean IsValidStore(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_AttributesStore other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000053
    public class HEU_OutputAttribute
    {
        // Fields
        public System.String _name;        // 0x10
        public HoudiniEngineUnity.HAPI_AttributeOwner _class;        // 0x18
        public HoudiniEngineUnity.HAPI_StorageType _type;        // 0x1C
        public System.Int32 _count;        // 0x20
        public System.Int32 _tupleSize;        // 0x24
        public System.Int32[] _intValues;        // 0x28
        public System.Single[] _floatValues;        // 0x30
        public System.String[] _stringValues;        // 0x38

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000054
    public class HEU_OutputAttributeDictionary : HEU_SerializableDictionary`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000055
    public class HEU_OutputAttributesStore : MonoBehaviour
    {
        // Fields
        private HoudiniEngineUnity.HEU_OutputAttributeDictionary _attributes;        // 0x18

        // Methods
        private System.Void SetAttribute(HoudiniEngineUnity.HEU_OutputAttribute attribute) { }
        private HoudiniEngineUnity.HEU_OutputAttribute GetAttribute(System.String name) { }
        private System.Void Clear() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000056
    public class HEU_AssetDatabase
    {
        // Methods
        private System.String GetAssetCachePath() { }
        private System.String GetUnityProjectPath() { }
        private System.String GetAssetRelativePath(System.String inFullPath) { }
        private System.String GetPackagesRelativePath(System.String inFullPath) { }
        private System.String GetValidAssetPath(System.String inPath) { }
        private System.String GetAssetPath(UnityEngine.Object asset) { }
        private System.String GetAssetPathWithSubAssetSupport(UnityEngine.Object asset) { }
        private System.Void GetSubAssetPathFromPath(System.String fullPath, System.String& mainPath, System.String& subPath) { }
        private System.String GetAssetRelativePathStart() { }
        private System.String GetPackagesRelativePathStart() { }
        private System.String GetAssetFullPath(System.String inPath) { }
        private System.Boolean IsPathRelativeToAssets(System.String inPath) { }
        private System.Boolean IsPathRelativeToPackages(System.String inPath) { }
        private System.String GetAssetRootPath(UnityEngine.Object asset) { }
        private System.String GetUniqueAssetPath(System.String path) { }
        private System.String GetAssetOrScenePath(UnityEngine.Object inputObject) { }
        private System.Boolean IsPathInAssetCache(System.String path) { }
        private System.Boolean IsPathInAssetCacheBakedFolder(System.String path) { }
        private System.Boolean IsPathInAssetCacheWorkingFolder(System.String path) { }
        private System.Boolean IsAssetInAssetCacheBakedFolder(UnityEngine.Object asset) { }
        private System.Boolean IsAssetInAssetCacheWorkingFolder(UnityEngine.Object asset) { }
        private System.String CreateAssetCacheFolder(System.String suggestedAssetPath, System.Int32 hash) { }
        private System.Void DeleteAssetCacheFolder(System.String assetCacheFolderPath) { }
        private System.Void DeleteAsset(UnityEngine.Object asset) { }
        private System.Void DeleteAssetAtPath(System.String path) { }
        private System.Void DeleteAssetIfInBakedFolder(UnityEngine.Object asset) { }
        private System.Boolean ContainsAsset(UnityEngine.Object assetObject) { }
        private System.Boolean CopyAsset(System.String path, System.String newPath) { }
        private UnityEngine.Object CopyAndLoadAssetWithRelativePath(UnityEngine.Object srcAsset, System.String copyAssetFolder, System.String relativePath, System.Type type, System.Boolean bOverwriteExisting) { }
        private UnityEngine.Object CopyAndLoadAssetFromAssetCachePath(UnityEngine.Object srcAsset, System.String copyPath, System.Type type, System.Boolean bOverwriteExisting) { }
        private UnityEngine.Object CopyAndLoadAssetAtAnyPath(UnityEngine.Object srcAsset, System.String copyPath, System.Type type, System.Boolean bOverwriteExisting) { }
        private UnityEngine.Object CopyAndLoadAssetAtGivenPath(UnityEngine.Object srcAsset, System.String targetPath, System.Type type) { }
        private UnityEngine.Object CopyUniqueAndLoadAssetAtAnyPath(UnityEngine.Object srcAsset, System.String copyPath, System.Type type) { }
        private System.Void CreateObjectInAssetCacheFolder(UnityEngine.Object objectToCreate, System.String assetCacheRoot, System.String relativeFolderPath, System.String assetFileName, System.Type type, System.Boolean bOverwriteExisting) { }
        private System.Void CreateAsset(UnityEngine.Object asset, System.String path) { }
        private System.Void CreateAddObjectInAssetCacheFolder(System.String assetName, System.String assetObjectFileName, UnityEngine.Object objectToAdd, System.String relativeFolderPath, System.String& exportRootPath, UnityEngine.Object& assetDBObject) { }
        private System.Void AddObjectToAsset(UnityEngine.Object objectToAdd, UnityEngine.Object assetObject) { }
        private System.Void SaveAndRefreshDatabase() { }
        private System.Void SaveAssetDatabase() { }
        private System.Void RefreshAssetDatabase() { }
        private UnityEngine.Object LoadAssetAtPath(System.String assetPath, System.Type type) { }
        private UnityEngine.Object LoadSubAssetAtPath(System.String mainPath, System.String subAssetPath) { }
        private UnityEngine.Object[] LoadAllAssetsAtPath(System.String assetPath) { }
        private UnityEngine.Object[] LoadAllAssetRepresentationsAtPath(System.String assetPath) { }
        private System.Void ImportAsset(System.String assetPath, HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptions heuOptions) { }
        private System.String GetAssetWorkingPath() { }
        private System.String GetAssetBakedPath() { }
        private System.String GetAssetBakedPathWithAssetName(System.String assetName) { }
        private System.String CreateUniqueBakePath(System.String assetName) { }
        private System.Void CreatePathWithFolders(System.String inPath) { }
        private System.String AppendMeshesPathToAssetFolder(System.String inAssetCacheFolder) { }
        private System.String AppendTexturesPathToAssetFolder(System.String inAssetCacheFolder) { }
        private System.String AppendMaterialsPathToAssetFolder(System.String inAssetCacheFolder) { }
        private System.String AppendTerrainPathToAssetFolder(System.String inAssetCacheFolder) { }
        private System.String[] GetAssetSubFolders() { }
        private System.String AppendPrefabPath(System.String inAssetCacheFolder, System.String assetName) { }
        private System.String AppendMeshesAssetFileName(System.String assetName) { }
        private System.Boolean IsSubAsset(UnityEngine.Object obj) { }
        private System.String[] GetAssetPathsFromAssetBundle(System.String assetBundleFileName) { }
        private System.Boolean IsAssetSavedInScene(UnityEngine.GameObject go) { }
        private System.Void SelectAssetAtPath(System.String path) { }
        private System.Void PrintDependencies(UnityEngine.GameObject targetGO) { }
        private System.String GetUniqueAssetPathForUnityAsset(UnityEngine.Object obj) { }
        private System.Boolean IsValidFolderName(System.String name) { }
        private T LoadUnityAssetFromUniqueAssetPath(System.String assetPath) { }
        private T GetBuiltinExtraResource(System.String resourceName) { }

    }

    // TypeToken: 0x2000058
    public class HEU_Defines
    {
        // Fields
        public static System.String HEU_PRODUCT_NAME;        // 0x0
        public static System.String HEU_NAME;        // 0x0
        public static System.String HEU_PLUGIN_PATH;        // 0x0
        public static System.String HEU_TEXTURES_PATH;        // 0x8
        public static System.String HEU_BAKED_ASSETS_PATH;        // 0x10
        public static System.String HEU_ENGINE_ASSETS;        // 0x18
        public static System.String HAPI_PATH;        // 0x0
        public static System.String HEU_ENVPATH_PREFIX;        // 0x0
        public static System.String HEU_ENVPATH_KEY;        // 0x0
        public static System.Int32 HEU_INVALID_NODE_ID;        // 0x0
        public static System.String HEU_DEFAULT_ASSET_NAME;        // 0x0
        public static System.String HEU_SESSION_PIPENAME;        // 0x0
        public static System.String HEU_SESSION_LOCALHOST;        // 0x0
        public static System.Int32 HEU_SESSION_PORT;        // 0x0
        public static System.Single HEU_SESSION_TIMEOUT;        // 0x0
        public static System.Boolean HEU_SESSION_AUTOCLOSE;        // 0x0
        public static System.Int32 HAPI_MAX_PAGE_SIZE;        // 0x0
        public static System.Int32 HAPI_SEC_BEFORE_PROGRESS_BAR_SHOW;        // 0x0
        public static System.Int32 HAPI_MAX_VERTICES_PER_FACE;        // 0x0
        public static System.Boolean HAPI_CURVE_REFINE_TO_LINEAR;        // 0x0
        public static System.Single HAPI_CURVE_LOD;        // 0x0
        public static System.Single HAPI_VOLUME_POSITION_MULT;        // 0x0
        public static System.Single HAPI_VOLUME_SURFACE_MAX_PT_PER_C;        // 0x0
        public static System.Single HAPI_VOLUME_SURFACE_DELTA_MULT;        // 0x0
        public static System.Single HAPI_VOLUME_SURFACE_PT_SIZE_MULT;        // 0x0
        public static System.String DEFAULT_TOP_NODE_FILTER;        // 0x0
        public static System.String DEFAULT_TOP_OUTPUT_FILTER;        // 0x0
        public static System.String HAPI_ATTRIB_ORIENT;        // 0x0
        public static System.String HAPI_ATTRIB_ROTATION;        // 0x0
        public static System.String HAPI_ATTRIB_SCALE;        // 0x0
        public static System.String HAPI_ATTRIB_ALPHA;        // 0x0
        public static System.String HAPI_HANDLE_TRANSFORM;        // 0x0
        public static System.Int32 HAPI_MAX_UVS;        // 0x0
        public static System.String HAPI_OBJMERGE_TRANSFORM_PARAM;        // 0x0
        public static System.String HAPI_OBJMERGE_PACK_GEOMETRY;        // 0x0
        public static System.String HAPI_OBJPATH_1_PARAM;        // 0x0
        public static System.String NO_EXISTING_SESSION;        // 0x0
        public static System.String HEU_ERROR_TITLE;        // 0x0
        public static System.String HEU_INSTALL_INFO;        // 0x0
        public static System.String PLUGIN_STORE_KEYS;        // 0x0
        public static System.String PLUGIN_STORE_DATA;        // 0x0
        public static System.String PLUGIN_SESSION_DATA;        // 0x0
        public static System.String PLUGIN_SETTINGS_FILE;        // 0x0
        public static System.String PLUGIN_SESSION_FILE;        // 0x0
        public static System.String COOK_LOGS_FILE;        // 0x0
        public static System.String DEFAULT_COLLISION_GEO;        // 0x0
        public static System.String DEFAULT_RENDERED_COLLISION_GEO;        // 0x0
        public static System.String DEFAULT_RENDERED_CONVEX_COLLISION_GEO;        // 0x0
        public static System.String DEFAULT_CONVEX_COLLISION_GEO;        // 0x0
        public static System.String DEFAULT_SIMPLE_COLLISION_GEO;        // 0x0
        public static System.String DEFAULT_SIMPLE_RENDERED_COLLISION_GEO;        // 0x0
        public static System.String DEFAULT_SIMPLE_RENDERED_CONVEX_COLLISION_GEO;        // 0x0
        public static System.String DEFAULT_COLLISION_TRIGGER;        // 0x0
        public static System.String DEFAULT_UNITY_MATERIAL_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_SUBMATERIAL_NAME_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_SUBMATERIAL_INDEX_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_DIFFUSE_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_MASK_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_NORMAL_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_NORMAL_SCALE_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_METALLIC_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_SMOOTHNESS_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_SPECULAR_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TILE_OFFSET_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TILE_SIZE_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_FILE_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_EXPORT_FILE_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TERRAINLAYER_FILE_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_EXPORT_PATH;        // 0x0
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_HEIGHT_RANGE;        // 0x0
        public static System.String DEFAULT_UNITY_HEIGHTFIELD_YPOS;        // 0x0
        public static System.String HEIGHTFIELD_TREEPROTOTYPE;        // 0x0
        public static System.String HEIGHTFIELD_TREEINSTANCE_PROTOTYPEINDEX;        // 0x0
        public static System.String HEIGHTFIELD_TREEINSTANCE_HEIGHTSCALE;        // 0x0
        public static System.String HEIGHTFIELD_TREEINSTANCE_WIDTHSCALE;        // 0x0
        public static System.String HEIGHTFIELD_TREEINSTANCE_LIGHTMAPCOLOR;        // 0x0
        public static System.String HEIGHTFIELD_DETAIL_RESOLUTION_PER_PATCH;        // 0x0
        public static System.String HEIGHTFIELD_UNITY_TILE;        // 0x0
        public static System.String HEIGHTFIELD_DETAIL_DISTANCE;        // 0x0
        public static System.String HEIGHTFIELD_DETAIL_DENSITY;        // 0x0
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_PREFAB;        // 0x0
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_TEXTURE;        // 0x0
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_BENDFACTOR;        // 0x0
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_DRYCOLOR;        // 0x0
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_HEALTHYCOLOR;        // 0x0
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_MAXHEIGHT;        // 0x0
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_MAXWIDTH;        // 0x0
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_MINHEIGHT;        // 0x0
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_MINWIDTH;        // 0x0
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_NOISESPREAD;        // 0x0
        public static System.String HEIGHTFIELD_DETAIL_PROTOTYPE_RENDERMODE;        // 0x0
        public static System.String HEIGHTFIELD_LAYER_ATTR_TYPE;        // 0x0
        public static System.String HEIGHTFIELD_LAYER_TYPE_DETAIL;        // 0x0
        public static System.String HAPI_HEIGHTFIELD_TILE_ATTR;        // 0x0
        public static System.String HAPI_HEIGHTFIELD_LAYERNAME_HEIGHT;        // 0x0
        public static System.String HAPI_HEIGHTFIELD_LAYERNAME_MASK;        // 0x0
        public static System.String MAT_OGL_DIFF_ATTR;        // 0x0
        public static System.String MAT_DIFF_ATTR;        // 0x0
        public static System.String MAT_OGL_TEX1_ATTR;        // 0x0
        public static System.String MAT_OGL_TEX1_ATTR_ENABLED;        // 0x0
        public static System.String MAT_BASECOLOR_ATTR;        // 0x0
        public static System.String MAT_BASECOLOR_ATTR_ENABLED;        // 0x0
        public static System.String MAT_MAP_ATTR;        // 0x0
        public static System.String MAT_OGL_NORMAL_ATTR;        // 0x0
        public static System.String MAT_NORMAL_ATTR;        // 0x0
        public static System.String MAT_NORMAL_ATTR_ENABLED;        // 0x0
        public static System.String MAT_OGL_SPEC_ATTR;        // 0x0
        public static System.String MAT_SPEC_ATTR;        // 0x0
        public static System.String MAT_OGL_SPEC_MAP_ATTR;        // 0x0
        public static System.String MAT_OGL_SPEC_MAP_ATTR_ENABLED;        // 0x0
        public static System.String MAT_SPEC_MAP_ATTR;        // 0x0
        public static System.String MAT_SPEC_MAP_ATTR_ENABLED;        // 0x0
        public static System.String MAT_OGL_ROUGH_ATTR;        // 0x0
        public static System.String MAT_ROUGH_ATTR;        // 0x0
        public static System.String MAT_OGL_ROUGH_MAP_ATTR;        // 0x0
        public static System.String MAT_OGL_ROUGH_MAP_ATTR_ENABLED;        // 0x0
        public static System.String MAT_ROUGH_MAP_ATTR;        // 0x0
        public static System.String MAT_ROUGH_MAP_ATTR_ENABLED;        // 0x0
        public static System.String MAT_OGL_METALLIC_ATTR;        // 0x0
        public static System.String MAT_METALLIC_ATTR;        // 0x0
        public static System.String MAT_OGL_METALLIC_MAP_ATTR;        // 0x0
        public static System.String MAT_OGL_METALLIC_MAP_ATTR_ENABLED;        // 0x0
        public static System.String MAT_METALLIC_MAP_ATTR;        // 0x0
        public static System.String MAT_METALLIC_MAP_ATTR_ENABLED;        // 0x0
        public static System.String MAT_OGL_EMISSIVE_ATTR;        // 0x0
        public static System.String MAT_EMISSIVE_ATTR;        // 0x0
        public static System.String MAT_OGL_EMISSIVE_MAP_ATTR;        // 0x0
        public static System.String MAT_OGL_EMISSIVE_MAP_ATTR_ENABLED;        // 0x0
        public static System.String MAT_EMISSIVE_MAP_ATTR;        // 0x0
        public static System.String MAT_EMISSIVE_MAP_ATTR_ENABLED;        // 0x0
        public static System.String MAT_OGL_ALPHA_ATTR;        // 0x0
        public static System.String MAT_ALPHA_ATTR;        // 0x0
        public static System.String MAT_OGL_OPACITY_MAP_ATTR;        // 0x0
        public static System.String MAT_OGL_OPACITY_MAP_ATTR_ENABLED;        // 0x0
        public static System.String MAT_OPACITY_MAP_ATTR;        // 0x0
        public static System.String MAT_OPACITY_MAP_ATTR_ENABLED;        // 0x0
        public static System.String MAT_OGL_TRANSPARENCY_ATTR;        // 0x0
        public static System.String MAT_OGL_TRANSPARENCY_ATTR_ENABLED;        // 0x0
        public static System.String MAT_OGL_OCCLUSION_MAP_ATTR;        // 0x0
        public static System.String MAT_OGL_OCCLUSION_MAP_ATTR_ENABLED;        // 0x0
        public static System.String CURVE_COORDS_PARAM;        // 0x0
        public static System.String CURVE_TYPE_PARAM;        // 0x0
        public static System.String CURVE_METHOD_PARAM;        // 0x0
        public static System.String CURVE_CLOSE_PARAM;        // 0x0
        public static System.String CURVE_REVERSE_PARAM;        // 0x0
        public static System.String HENGINE_STORE_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_TAG_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_SCRIPT_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_INSTANCE_ATTR;        // 0x0
        public static System.String UNITY_USE_INSTANCE_FLAGS_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_INPUT_MESH_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_STATIC_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_LAYER_ATTR;        // 0x0
        public static System.String DEFAULT_UNITY_MESH_READABLE;        // 0x0
        public static System.String DEFAULT_INSTANCE_PREFIX_ATTR;        // 0x0
        public static System.String UNITY_SHADER_COLOR;        // 0x0
        public static System.String UNITY_SHADER_SPEC_COLOR;        // 0x0
        public static System.String UNITY_SHADER_SPEC_MAP;        // 0x0
        public static System.String UNITY_SHADER_METALLIC;        // 0x0
        public static System.String UNITY_SHADER_METALLIC_MAP;        // 0x0
        public static System.String UNITY_SHADER_BUMP_MAP;        // 0x0
        public static System.String UNITY_SHADER_EMISSION_COLOR;        // 0x0
        public static System.String UNITY_SHADER_EMISSION_MAP;        // 0x0
        public static System.String UNITY_SHADER_SMOOTHNESS;        // 0x0
        public static System.String UNITY_SHADER_SMOOTHNESS_MAP;        // 0x0
        public static System.String UNITY_SHADER_SHININESS;        // 0x0
        public static System.String UNITY_SHADER_OCCLUSION;        // 0x0
        public static System.String UNITY_SHADER_OCCLUSION_MAP;        // 0x0
        public static System.String UNITY_SHADER_OPACITY;        // 0x0
        public static System.String UNITY_SHADER_OPACITY_MAP;        // 0x0
        public static System.String UNITY_EDITORONLY_TAG;        // 0x0
        public static System.String UNITY_HDADATA_NAME;        // 0x0
        public static System.String HOUDINI_SHADER_PREFIX;        // 0x0
        public static System.String DEFAULT_STANDARD_SHADER;        // 0x0
        public static System.String DEFAULT_VERTEXCOLOR_SHADER;        // 0x0
        public static System.String DEFAULT_TRANSPARENT_SHADER;        // 0x0
        public static System.String DEFAULT_STANDARD_SHADER_SPECULAR;        // 0x0
        public static System.String DEFAULT_STANDARD_SHADER_SPECULAR_LEGACY;        // 0x0
        public static System.String DEFAULT_VERTEXCOLOR_SHADER_SPECULAR;        // 0x0
        public static System.String DEFAULT_VERTEXCOLOR_SHADER_SPECULAR_LEGACY;        // 0x0
        public static System.String DEFAULT_TRANSPARENT_SHADER_SPECULAR;        // 0x0
        public static System.String DEFAULT_TRANSPARENT_SHADER_SPECULAR_LEGACY;        // 0x0
        public static System.String DEFAULT_CURVE_SHADER;        // 0x0
        public static System.String DEFAULT_TERRAIN_SHADER;        // 0x0
        public static System.String DEFAULT_STANDARD_SHADER_HDRP;        // 0x0
        public static System.String DEFAULT_VERTEXCOLOR_SHADER_HDRP;        // 0x0
        public static System.String DEFAULT_TRANSPARENT_SHADER_HDRP;        // 0x0
        public static System.String DEFAULT_STANDARD_SHADER_HDRP_SPECULAR;        // 0x0
        public static System.String DEFAULT_VERTEXCOLOR_SHADER_HDRP_SPECULAR;        // 0x0
        public static System.String DEFAULT_TRANSPARENT_SHADER_HDRP_SPECULAR;        // 0x0
        public static System.String DEFAULT_CURVE_SHADER_HDRP;        // 0x0
        public static System.String DEFAULT_TERRAIN_SHADER_HDRP;        // 0x0
        public static System.String DEFAULT_STANDARD_SHADER_URP;        // 0x0
        public static System.String DEFAULT_VERTEXCOLOR_SHADER_URP;        // 0x0
        public static System.String DEFAULT_TRANSPARENT_SHADER_URP;        // 0x0
        public static System.String DEFAULT_STANDARD_SHADER_URP_SPECULAR;        // 0x0
        public static System.String DEFAULT_VERTEXCOLOR_SHADER_URP_SPECULAR;        // 0x0
        public static System.String DEFAULT_TRANSPARENT_SHADER_URP_SPECULAR;        // 0x0
        public static System.String DEFAULT_CURVE_SHADER_URP;        // 0x0
        public static System.String DEFAULT_TERRAIN_SHADER_URP;        // 0x0
        public static System.String DEFAULT_UNITY_BUILTIN_RESOURCES;        // 0x0
        public static System.String DEFAULT_TERRAIN_MATERIAL_PATH;        // 0x0
        public static System.String DEFAULT_TERRAIN_MATERIAL_PATH_HDRP;        // 0x0
        public static System.String DEFAULT_TERRAIN_MATERIAL_PATH_URP;        // 0x0
        public static System.String DEFAULT_MATERIAL;        // 0x0
        public static System.Int32 DEFAULT_MATERIAL_KEY;        // 0x20
        public static System.String EDITABLE_MATERIAL;        // 0x0
        public static System.Int32 EDITABLE_MATERIAL_KEY;        // 0x24
        public static System.Int32 HEU_INVALID_MATERIAL;        // 0x0
        public static System.String HEU_ASSET_CACHE_PATH;        // 0x0
        public static System.String HEU_WORKING_PATH;        // 0x0
        public static System.String HEU_BAKED_PATH;        // 0x0
        public static System.String HEU_BAKED_HDA;        // 0x0
        public static System.String HEU_BAKED_CLONE;        // 0x0
        public static System.String HEU_INSTANCE;        // 0x0
        public static System.String HEU_INSTANCE_PATTERN;        // 0x0
        public static System.String HEU_INSTANCE_SPLIT_ATTR;        // 0x0
        public static System.String HEU_DEFAULT_GEO_GROUP_NAME;        // 0x0
        public static System.String HEU_DEFAULT_LOD_NAME;        // 0x0
        public static System.String HEU_UNITY_LOD_TRANSITION_ATTR;        // 0x0
        public static System.String HEU_SUBASSET;        // 0x0
        public static System.String HEU_HENGINE_TOOLS_SHIPPED_FOLDER;        // 0x0
        public static System.String HEU_HENGINE_SHIPPED_SHELF;        // 0x0
        public static System.String HEU_PATH_KEY_PROJECT;        // 0x0
        public static System.String HEU_PATH_KEY_PLUGIN;        // 0x0
        public static System.String HEU_PATH_KEY_HFS;        // 0x0
        public static System.String HEU_PATH_KEY_TOOL;        // 0x0
        public static System.String HEU_USERMSG_NONEDITOR_NOT_SUPPORTED;        // 0x0
        public static System.String HEU_TERRAIN_SPLAT_DEFAULT;        // 0x0
        public static System.String HEU_FOLDER_MESHES;        // 0x0
        public static System.String HEU_FOLDER_MATERIALS;        // 0x0
        public static System.String HEU_FOLDER_TERRAIN;        // 0x0
        public static System.String HEU_FOLDER_TILE;        // 0x0
        public static System.String HEU_FOLDER_TEXTURES;        // 0x0
        public static System.String HEU_EXT_ASSET;        // 0x0
        public static System.String HEU_EXT_MAT;        // 0x0
        public static System.String HEU_EXT_TERRAINDATA;        // 0x0
        public static System.String HEU_EXT_TERRAINLAYER;        // 0x0
        public static System.String HEU_KEY_CTRL;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000059
    public class HEU_HAPIUtility
    {
        // Methods
        private System.String GetHoudiniEngineInstallationInfo() { }
        private System.String GetEnvironmentPath() { }
        private System.String GetRealPathFromHFSPath(System.String inPath) { }
        private System.Boolean DoesMappedPathExist(System.String inPath) { }
        private System.Boolean IsHoudiniAssetFile(System.String filePath) { }
        private System.String FindHoudiniAssetFileInPathWithExt(System.String filePath) { }
        private System.Void Log(System.String message) { }
        private System.Void LogWarning(System.String message) { }
        private System.Void LogError(System.String message) { }
        private System.String LocateValidFilePath(UnityEngine.Object inObject) { }
        private System.String LocateValidFilePath(System.String assetName, System.String inFilePath) { }
        private UnityEngine.GameObject InstantiateHDA(System.String filePath, UnityEngine.Vector3 initialPosition, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, System.Boolean bLoadFromMemory, System.Boolean bAlwaysOverwriteOnLoad, UnityEngine.GameObject rootGO) { }
        private System.Boolean LoadHDAFile(HoudiniEngineUnity.HEU_SessionBase session, System.String assetPath, System.Int32& assetLibraryID, System.String[]& assetNames) { }
        private System.Boolean CreateAndCookAssetNode(HoudiniEngineUnity.HEU_SessionBase session, System.String assetName, System.Boolean bCookTemplatedGeos, System.Int32& newAssetID) { }
        private System.Boolean CreateAndCookCurveAsset(HoudiniEngineUnity.HEU_SessionBase session, System.String assetName, System.Boolean bCookTemplatedGeos, System.Int32& newAssetID) { }
        private System.Boolean CreateAndCookInputAsset(HoudiniEngineUnity.HEU_SessionBase session, System.String assetName, System.Boolean bCookTemplatedGeos, System.Int32& newAssetID) { }
        private System.Boolean CookNodeInHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Boolean bCookTemplatedGeos, System.String assetName) { }
        private System.Boolean CookNodeInHoudiniWithOptions(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_CookOptions options, System.String assetName) { }
        private HoudiniEngineUnity.HAPI_CookOptions GetDefaultCookOptions(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Boolean ProcessHoudiniCookStatus(HoudiniEngineUnity.HEU_SessionBase session, System.String assetName) { }
        private UnityEngine.GameObject CreateNewAsset(HoudiniEngineUnity.HEU_AssetTypeWrapper assetType, System.String rootName, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, UnityEngine.GameObject rootGO) { }
        private UnityEngine.GameObject CreateNewAsset(HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType assetType, System.String rootName, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, UnityEngine.GameObject rootGO) { }
        private UnityEngine.GameObject CreateNewCurveAsset(System.String name, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, UnityEngine.GameObject rootGO) { }
        private UnityEngine.GameObject CreateNewInputAsset(System.String name, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, UnityEngine.GameObject rootGO) { }
        private UnityEngine.GameObject LoadGeoWithNewGeoSync(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void DestroyChildren(UnityEngine.Transform inTransform) { }
        private System.Void DestroyGameObject(UnityEngine.GameObject gameObect, System.Boolean bRegisterUndo) { }
        private System.Void DestroyChildrenWithComponent(UnityEngine.GameObject gameObject) { }
        private System.Boolean IsNodeValidInHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID) { }
        private HoudiniEngineUnity.HEU_HoudiniAssetRoot GetAssetInScene(System.Int32 assetID) { }
        private System.Void ApplyWorldTransfromFromHoudiniToUnity(HoudiniEngineUnity.HAPI_Transform& hapiTransform, UnityEngine.Transform unityTransform) { }
        private System.Void ApplyLocalTransfromFromHoudiniToUnity(HoudiniEngineUnity.HAPI_Transform& hapiTransform, UnityEngine.Transform unityTransform) { }
        private System.Void ApplyLocalTransfromFromHoudiniToUnityForInstance(HoudiniEngineUnity.HAPI_Transform& hapiTransform, UnityEngine.Transform unityTransform) { }
        private System.Void ApplyMatrixToLocalTransform(UnityEngine.Matrix4x4& matrix, UnityEngine.Transform transform) { }
        private UnityEngine.Matrix4x4 GetMatrixFromHAPITransform(HoudiniEngineUnity.HAPI_Transform& hapiTransform, System.Boolean bConvertToUnity) { }
        private UnityEngine.Quaternion GetQuaternion(UnityEngine.Matrix4x4& m) { }
        private UnityEngine.Vector3 GetPosition(UnityEngine.Matrix4x4& m) { }
        private System.Void SetMatrixPosition(UnityEngine.Matrix4x4& m, UnityEngine.Vector3& position) { }
        private UnityEngine.Vector3 GetScale(UnityEngine.Matrix4x4& m) { }
        private HoudiniEngineUnity.HAPI_TransformEuler GetHAPITransformFromMatrix(UnityEngine.Matrix4x4& mat) { }
        private HoudiniEngineUnity.HAPI_TransformEuler GetHAPITransform(UnityEngine.Vector3& p, UnityEngine.Vector3& r, UnityEngine.Vector3& s) { }
        private HoudiniEngineUnity.HAPI_Transform GetHAPITransformQuatFromMatrix(UnityEngine.Matrix4x4& mat) { }
        private UnityEngine.Matrix4x4 GetMatrix4x4(UnityEngine.Vector3& p, UnityEngine.Vector3& r, UnityEngine.Vector3& s) { }
        private System.Boolean IsSameTransform(UnityEngine.Matrix4x4& transformMatrix, UnityEngine.Vector3& p, UnityEngine.Vector3& r, UnityEngine.Vector3& s) { }
        private System.Boolean IsEqualTol(System.Single a, System.Single b, System.Single t) { }
        private System.Boolean IsTransformEqual(HoudiniEngineUnity.HAPI_Transform& transA, HoudiniEngineUnity.HAPI_Transform& transB) { }
        private System.Boolean IsViewportEqual(HoudiniEngineUnity.HAPI_Viewport& viewA, HoudiniEngineUnity.HAPI_Viewport& viewB) { }
        private System.Boolean IsSessionSyncEqual(HoudiniEngineUnity.HAPI_SessionSyncInfo& syncA, HoudiniEngineUnity.HAPI_SessionSyncInfo& syncB) { }
        private System.Boolean DoesGeoPartHaveAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeOwner owner, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo) { }
        private System.Void SetAnimationCurveTangentModes(UnityEngine.AnimationCurve animCurve, System.Collections.Generic.List<System.Int32> tangentValues) { }
        private System.Boolean IsSupportedPolygonType(HoudiniEngineUnity.HAPI_PartType partType) { }
        private System.Int32 GetParentNodeID(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID) { }
        private System.Boolean GetObjectInfos(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, HoudiniEngineUnity.HAPI_ObjectInfo[]& objectInfos, HoudiniEngineUnity.HAPI_Transform[]& objectTransforms) { }
        private System.Boolean ContainsSopNodes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeId) { }
        private System.Boolean IsObjNodeFullyVisible(HoudiniEngineUnity.HEU_SessionBase session, System.Collections.Generic.HashSet<System.Int32> allObjectIds, System.Int32 inRootNodeId, System.Int32 inChildNodeId) { }
        private System.Boolean GetOutputIndex(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeId, System.Int32& outputIndex) { }
        private System.Void GatherAllAssetGeoInfos(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_AssetInfo assetInfo, HoudiniEngineUnity.HAPI_ObjectInfo objectInfo, System.Boolean bUseOutputNodes, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_GeoInfo>& outGeoInfos) { }
        private System.Void GatherAllObjectGeoInfos(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetId, System.Boolean bUseOutputNodes, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_GeoInfo>& outGeoInfos) { }
        private System.Void GatherAllAssetOutputs(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeId, System.Boolean bUseOutputNodes, System.Boolean bOutputTemplatedGeos, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_GeoInfo>& outGeoInfos) { }
        private System.String ToHapiVariableName(System.String name) { }
        private System.Void ConvertPositionUnityToHoudini(UnityEngine.Vector3& position) { }
        private System.Void ConvertPositionUnityToHoudini(UnityEngine.Vector3 position, System.Single& outputX, System.Single& outputY, System.Single& outputZ) { }
        private UnityEngine.Vector3 ConvertPositionUnityToHoudini(System.Single inputX, System.Single inputY, System.Single inputZ) { }
        private UnityEngine.Vector3 ConvertPositionUnityToHoudini(UnityEngine.Vector3 inputVec) { }
        private System.Void ConvertPositionUnityToHoudini(System.Single inputX, System.Single inputY, System.Single inputZ, UnityEngine.Vector3& outputVec) { }
        private System.Void ConvertRotationUnityToHoudini(UnityEngine.Quaternion& rotation) { }
        private System.Void ConvertRotationUnityToHoudini(UnityEngine.Quaternion rotation, System.Single& outputX, System.Single& outputY, System.Single& outputZ, System.Single& outputW) { }
        private UnityEngine.Quaternion ConvertRotationUnityToHoudini(System.Single inputX, System.Single inputY, System.Single inputZ, System.Single inputW) { }
        private UnityEngine.Quaternion ConvertRotationUnityToHoudini(UnityEngine.Quaternion inputQuat) { }
        private System.Void ConvertScaleUnityToHoudini(UnityEngine.Vector3& position) { }
        private System.Void ConvertScaleUnityToHoudini(UnityEngine.Vector3 position, System.Single& outputX, System.Single& outputY, System.Single& outputZ) { }
        private UnityEngine.Vector3 ConvertScaleUnityToHoudini(System.Single inputX, System.Single inputY, System.Single inputZ) { }
        private UnityEngine.Vector3 ConvertScaleUnityToHoudini(UnityEngine.Vector3 inputVec) { }

    }

    // TypeToken: 0x200005A
    public class HEU_HoudiniEngineError : Exception
    {
        // Fields
        protected System.String _errorMsg;        // 0x90

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String errorMsg) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200005B
    public class HEU_Platform
    {
        // Fields
        private static System.String _lastErrorMsg;        // 0x0
        private static System.String _libPath;        // 0x8
        private static System.Boolean _pathSet;        // 0x10

        // Methods
        private System.String get_LibPath() { }
        private System.Boolean get_IsPathSet() { }
        private System.Void .cctor() { }
        private System.String GetHoudiniEnginePath() { }
        private System.String GetHoudiniEngineDefaultPath() { }
        private System.String GetSavedHoudiniPath() { }
        private System.Void SetHapiClientName() { }
        private System.Void SetHoudiniEnginePath() { }
        private System.String GetAllFoldersInPath(System.String path) { }
        private System.Void GetAllFoldersInPathHelper(System.String inPath, System.Text.StringBuilder pathBuilder) { }
        private System.String[] GetFilesInFolder(System.String folderPath, System.String searchPattern, System.Boolean bRecursive) { }
        private System.String GetFileName(System.String path) { }
        private System.String GetFileNameWithoutExtension(System.String path) { }
        private System.String GetFolderPath(System.String path, System.Boolean bRemoveDirectorySeparatorAtEnd) { }
        private System.Char get_DirectorySeparator() { }
        private System.String get_DirectorySeparatorStr() { }
        private System.String BuildPath(System.String folder1, System.String folder2, System.Object[] args) { }
        private System.String TrimLastDirectorySeparator(System.String inPath) { }
        private System.Boolean DoesPathExist(System.String inPath) { }
        private System.Boolean DoesFileExist(System.String inPath) { }
        private System.Boolean DoesDirectoryExist(System.String inPath) { }
        private System.Boolean CreateDirectory(System.String inPath) { }
        private System.String GetParentDirectory(System.String inPath) { }
        private System.String GetFullPath(System.String inPath) { }
        private System.Boolean IsPathRooted(System.String inPath) { }
        private System.Void WriteBytes(System.String path, System.Byte[] bytes) { }
        private System.Boolean WriteAllText(System.String path, System.String text) { }
        private System.String ReadAllText(System.String path) { }
        private System.String GetEnvironmentValue(System.String key) { }
        private System.String GetHoudiniEngineEnvironmentFilePathFull() { }
        private System.Boolean LoadFileIntoMemory(System.String path, System.Byte[]& buffer) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005C
    public class HEU_PlatformWin
    {
        // Fields
        public static System.UIntPtr HKEY_LOCAL_MACHINE;        // 0x0
        public static System.UIntPtr HKEY_CURRENT_USER;        // 0x8

        // Methods
        private System.UInt32 RegOpenKeyEx(System.UIntPtr hKey, System.String lpSubKey, System.UInt32 ulOptions, System.Int32 samDesired, System.Int32& phkResult) { }
        private System.Int32 RegQueryValueEx(System.Int32 hKey, System.String lpValueName, System.Int32 lpReserved, System.UInt32& lpType, System.Text.StringBuilder lpData, System.UInt32& lpcbData) { }
        private System.UInt32 RegCloseKey(System.Int32 hKey) { }
        private System.String GetRegistryKeyValue(System.UIntPtr rootKey, System.String keyName, HoudiniEngineUnity.HEU_PlatformWin.RegSAM is32or64Key, System.String inPropertyName) { }
        private System.String GetRegistryKeyvalue_x86(System.UIntPtr rootKey, System.String keyName, System.String inPropertyName) { }
        private System.String GetRegistryKeyvalue_x64(System.UIntPtr rootKey, System.String keyName, System.String inPropertyName) { }
        private System.String GetApplicationPath(System.String appName) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005E
    public class HEU_PluginSettings
    {
        // Fields
        public static System.Action<System.Boolean> s_onEnableRawHoudiniChanged;        // 0x0

        // Methods
        private System.String get_HoudiniEngineEnvFilePath() { }
        private System.Void set_HoudiniEngineEnvFilePath(System.String value) { }
        private System.Boolean get_EnableRawHoudini() { }
        private System.Void set_EnableRawHoudini(System.Boolean value) { }
        private System.Boolean get_CookingEnabled() { }
        private System.Void set_CookingEnabled(System.Boolean value) { }
        private System.Boolean get_CookingTriggersDownstreamCooks() { }
        private System.Void set_CookingTriggersDownstreamCooks(System.Boolean value) { }
        private System.Boolean get_CookDisabledGameObjects() { }
        private System.Void set_CookDisabledGameObjects(System.Boolean value) { }
        private System.Boolean get_CookTemplatedGeos() { }
        private System.Void set_CookTemplatedGeos(System.Boolean value) { }
        private System.Boolean get_PushUnityTransformToHoudini() { }
        private System.Void set_PushUnityTransformToHoudini(System.Boolean value) { }
        private System.Boolean get_TransformChangeTriggersCooks() { }
        private System.Void set_TransformChangeTriggersCooks(System.Boolean value) { }
        private System.Boolean get_ChildTransformChangeTriggersCooks() { }
        private System.Void set_ChildTransformChangeTriggersCooks(System.Boolean value) { }
        private System.String get_CollisionGroupName() { }
        private System.Void set_CollisionGroupName(System.String value) { }
        private System.String get_RenderedCollisionGroupName() { }
        private System.Void set_RenderedCollisionGroupName(System.String value) { }
        private System.String get_RenderedConvexCollisionGroupName() { }
        private System.Void set_RenderedConvexCollisionGroupName(System.String value) { }
        private System.String get_UnityMaterialAttribName() { }
        private System.Void set_UnityMaterialAttribName(System.String value) { }
        private System.String get_UnitySubMaterialAttribName() { }
        private System.Void set_UnitySubMaterialAttribName(System.String value) { }
        private System.String get_UnitySubMaterialIndexAttribName() { }
        private System.Void set_UnitySubMaterialIndexAttribName(System.String value) { }
        private System.String get_UnityTagAttributeName() { }
        private System.Void set_UnityTagAttributeName(System.String value) { }
        private System.String get_UnityStaticAttributeName() { }
        private System.Void set_UnityStaticAttributeName(System.String value) { }
        private System.String get_UnityScriptAttributeName() { }
        private System.Void set_UnityScriptAttributeName(System.String value) { }
        private System.String get_UnityLayerAttributeName() { }
        private System.Void set_UnityLayerAttributeName(System.String value) { }
        private System.Single get_ImageGamma() { }
        private System.Void set_ImageGamma(System.Single value) { }
        private System.Single get_NormalGenerationThresholdAngle() { }
        private System.Void set_NormalGenerationThresholdAngle(System.Single value) { }
        private System.String get_LastLoadHDAPath() { }
        private System.Void set_LastLoadHDAPath(System.String value) { }
        private System.String get_LastLoadHIPPath() { }
        private System.Void set_LastLoadHIPPath(System.String value) { }
        private System.String get_InstanceAttr() { }
        private System.Void set_InstanceAttr(System.String value) { }
        private System.String get_UnityInstanceAttr() { }
        private System.Void set_UnityInstanceAttr(System.String value) { }
        private System.String get_UnityInputMeshAttr() { }
        private System.Void set_UnityInputMeshAttr(System.String value) { }
        private UnityEngine.Color get_LineColor() { }
        private System.Void set_LineColor(UnityEngine.Color value) { }
        private System.Boolean get_UseHybridCurveEditing() { }
        private System.Void set_UseHybridCurveEditing(System.Boolean value) { }
        private System.String get_EditorOnly_Tag() { }
        private System.Void set_EditorOnly_Tag(System.String value) { }
        private System.String get_HDAData_Name() { }
        private System.Void set_HDAData_Name(System.String value) { }
        private HoudiniEngineUnity.SessionMode get_Session_Mode() { }
        private System.Void set_Session_Mode(HoudiniEngineUnity.SessionMode value) { }
        private System.String get_Session_PipeName() { }
        private System.Void set_Session_PipeName(System.String value) { }
        private System.String get_Session_Localhost() { }
        private System.Void set_Session_Localhost(System.String value) { }
        private System.Int32 get_Session_Port() { }
        private System.Void set_Session_Port(System.Int32 value) { }
        private System.Single get_Session_Timeout() { }
        private System.Void set_Session_Timeout(System.Single value) { }
        private System.Boolean get_Session_AutoClose() { }
        private System.Void set_Session_AutoClose(System.Boolean value) { }
        private System.Boolean get_Curves_ShowInSceneView() { }
        private System.Void set_Curves_ShowInSceneView(System.Boolean value) { }
        private System.String get_AssetCachePath() { }
        private System.Void set_AssetCachePath(System.String value) { }
        private System.Boolean get_UseFullPathNamesForOutput() { }
        private System.Void set_UseFullPathNamesForOutput(System.Boolean value) { }
        private System.Collections.Generic.List<System.String> get_HEngineToolsShelves() { }
        private System.Void set_HEngineToolsShelves(System.Collections.Generic.List<System.String> value) { }
        private System.Int32 get_HEngineShelfSelectedIndex() { }
        private System.Void set_HEngineShelfSelectedIndex(System.Int32 value) { }
        private System.String get_DefaultTerrainMaterial() { }
        private System.Void set_DefaultTerrainMaterial(System.String value) { }
        private System.String get_TerrainSplatTextureDefault() { }
        private System.Void set_TerrainSplatTextureDefault(System.String value) { }
        private System.String get_DefaultStandardShader() { }
        private System.Void set_DefaultStandardShader(System.String value) { }
        private System.String get_DefaultVertexColorShader() { }
        private System.Void set_DefaultVertexColorShader(System.String value) { }
        private System.String get_DefaultTransparentShader() { }
        private System.Void set_DefaultTransparentShader(System.String value) { }
        private System.String get_DefaultCurveShader() { }
        private System.Void set_DefaultCurveShader(System.String value) { }
        private System.Boolean get_SupportHoudiniBoxType() { }
        private System.Void set_SupportHoudiniBoxType(System.Boolean value) { }
        private System.Boolean get_SupportHoudiniSphereType() { }
        private System.Void set_SupportHoudiniSphereType(System.Boolean value) { }
        private System.Boolean get_SetCurrentThreadToInvariantCulture() { }
        private System.Void set_SetCurrentThreadToInvariantCulture(System.Boolean value) { }
        private System.String get_HoudiniDebugLaunchPath() { }
        private System.Void set_HoudiniDebugLaunchPath(System.String value) { }
        private System.String get_LastExportPath() { }
        private System.Void set_LastExportPath(System.String value) { }
        private System.Int32 get_InputSelectionFilterLocation() { }
        private System.Void set_InputSelectionFilterLocation(System.Int32 value) { }
        private System.Int32 get_InputSelectionFilterState() { }
        private System.Void set_InputSelectionFilterState(System.Int32 value) { }
        private System.Boolean get_InputSelectionFilterRoots() { }
        private System.Void set_InputSelectionFilterRoots(System.Boolean value) { }
        private System.String get_InputSelectionFilterName() { }
        private System.Void set_InputSelectionFilterName(System.String value) { }
        private System.Boolean get_CookOptionSplitGeosByGroup() { }
        private System.Void set_CookOptionSplitGeosByGroup(System.Boolean value) { }
        private System.Int32 get_MaxVerticesPerPrimitive() { }
        private System.Void set_MaxVerticesPerPrimitive(System.Int32 value) { }
        private System.String get_HoudiniInstallPath() { }
        private System.Void set_HoudiniInstallPath(System.String value) { }
        private System.String get_LastHoudiniVersion() { }
        private System.Void set_LastHoudiniVersion(System.String value) { }
        private System.Boolean get_SessionSyncAutoCook() { }
        private System.Void set_SessionSyncAutoCook(System.Boolean value) { }
        private System.Boolean get_WriteCookLogs() { }
        private System.Void set_WriteCookLogs(System.Boolean value) { }
        private System.Boolean get_UseHDRColor() { }
        private System.Void set_UseHDRColor(System.Boolean value) { }
        private System.Boolean get_UseSpecularShader() { }
        private System.Void set_UseSpecularShader(System.Boolean value) { }
        private System.Boolean get_UseLegacyShaders() { }
        private System.Void set_UseLegacyShaders(System.Boolean value) { }
        private System.Boolean get_ShortenFolderPaths() { }
        private System.Void set_ShortenFolderPaths(System.Boolean value) { }
        private System.Boolean get_UseLegacyInputCurves() { }
        private System.Void set_UseLegacyInputCurves(System.Boolean value) { }
        private System.Boolean get_CookOnMouseUp() { }
        private System.Void set_CookOnMouseUp(System.Boolean value) { }

    }

    // TypeToken: 0x200005F
    public class HEU_PluginStorage
    {
        // Fields
        protected System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_PluginStorage.StoreData> _dataMap;        // 0x10
        private System.Collections.Generic.Dictionary<System.String,System.String> _envPathMap;        // 0x18
        protected System.Boolean _requiresSave;        // 0x20
        private static HoudiniEngineUnity.HEU_PluginStorage _instance;        // 0x0
        public static System.String PluginSettingsLine1;        // 0x0
        public static System.String PluginSettingsLine2;        // 0x0
        public static System.String PluginSettingsVersion;        // 0x0

        // Methods
        private System.Collections.Generic.Dictionary<System.String,System.String> GetEnvironmentPathMap() { }
        private System.Boolean get_RequiresSave() { }
        private HoudiniEngineUnity.HEU_PluginStorage get_Instance() { }
        private System.Void InstantiateAndLoad() { }
        private System.Void SetCurrentCulture(System.Boolean useInvariant) { }
        private T[] GetJSONArray(System.String jsonArray) { }
        private System.Void Set(System.String key, System.Boolean value) { }
        private System.Void Set(System.String key, System.Int32 value) { }
        private System.Void Set(System.String key, System.Int64 value) { }
        private System.Void Set(System.String key, System.Single value) { }
        private System.Void Set(System.String key, System.String value) { }
        private System.Void Set(System.String key, System.Collections.Generic.List<System.String> values, System.Char delimiter) { }
        private System.Boolean Get(System.String key, System.Boolean& value, System.Boolean defaultValue) { }
        private System.Boolean Get(System.String key, System.Int32& value, System.Int32 defaultValue) { }
        private System.Boolean Get(System.String key, System.Int64& value, System.Int64 defaultValue) { }
        private System.Boolean Get(System.String key, System.Single& value, System.Single defaultValue) { }
        private System.Boolean Get(System.String key, System.String& value, System.String defaultValue) { }
        private System.Boolean Get(System.String key, System.Collections.Generic.List<System.String>& values, System.Char delimiter) { }
        private System.Void MarkDirtyForSave() { }
        private System.Void SaveIfRequired() { }
        private System.String SettingsFilePath() { }
        private System.Boolean SavePluginData(System.String file) { }
        private System.Boolean LoadPluginData(System.String file) { }
        private System.Boolean ReadFromEditorPrefs() { }
        private System.Void ClearPluginData() { }
        private System.Void LoadFromSavedFile() { }
        private System.String SessionFilePath() { }
        private System.Void SaveAllSessionData(System.Collections.Generic.List<HoudiniEngineUnity.HEU_SessionBase> allSessions, System.String path) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_SessionData> LoadAllSessionData(System.String path) { }
        private System.Void DeleteAllSavedSessionData(System.String file) { }
        private System.Void LoadAssetEnvironmentPaths() { }
        private System.String ConvertRealPathToEnvKeyedPath(System.String inPath) { }
        private System.String ConvertEnvKeyedPathToReal(System.String inPath) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000063
    public class HEU_Handle : ScriptableObject, IEquivable`1
    {
        // Fields
        private System.String _handleName;        // 0x18
        private HoudiniEngineUnity.HEU_Handle.HEU_HandleType _handleType;        // 0x20
        private System.Int32 _handleIndex;        // 0x24
        private HoudiniEngineUnity.HEU_HandleParamBinding _handleParamTranslateBinding;        // 0x28
        private HoudiniEngineUnity.HEU_HandleParamBinding _handleParamRotateBinding;        // 0x30
        private HoudiniEngineUnity.HEU_HandleParamBinding _handleParamScaleBinding;        // 0x38
        private UnityEngine.Vector3 _handlePosition;        // 0x40
        private UnityEngine.Quaternion _handleRotation;        // 0x4C
        private UnityEngine.Vector3 _handleScale;        // 0x5C
        private HoudiniEngineUnity.HAPI_RSTOrder _rstOrder;        // 0x68
        private HoudiniEngineUnity.HAPI_XYZOrder _xyzOrder;        // 0x6C
        private HoudiniEngineUnity.HAPI_TransformEuler _convertedTransformEuler;        // 0x70

        // Methods
        private System.String get_HandleName() { }
        private HoudiniEngineUnity.HEU_Handle.HEU_HandleType get_HandleType() { }
        private HoudiniEngineUnity.HAPI_RSTOrder get_RSTOrder() { }
        private HoudiniEngineUnity.HAPI_XYZOrder get_XYZOrder() { }
        private HoudiniEngineUnity.HAPI_TransformEuler get_ConvertedTransformEuler() { }
        private System.Boolean HasTranslateHandle() { }
        private System.Boolean HasRotateHandle() { }
        private System.Boolean HasScaleHandle() { }
        private System.Boolean IsTranslateHandleDisabled() { }
        private System.Boolean IsRotateHandleDisabled() { }
        private System.Boolean IsScaleHandleDisabled() { }
        private HoudiniEngineUnity.HEU_HandleParamBinding GetTranslateBinding() { }
        private HoudiniEngineUnity.HEU_HandleParamBinding GetRotateBinding() { }
        private HoudiniEngineUnity.HEU_HandleParamBinding GetScaleBinding() { }
        private UnityEngine.Vector3 get_HandlePosition() { }
        private UnityEngine.Quaternion get_HandleRotation() { }
        private UnityEngine.Vector3 get_HandleScale() { }
        private System.Boolean SetupHandle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, System.Int32 handleIndex, System.String handleName, HoudiniEngineUnity.HEU_Handle.HEU_HandleType handleType, HoudiniEngineUnity.HAPI_HandleInfo& handleInfo, HoudiniEngineUnity.HEU_Parameters parameters) { }
        private System.Void CleanUp() { }
        private System.Void GenerateTransform(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_Parameters parameters) { }
        private System.Boolean GetUpdatedPosition(HoudiniEngineUnity.HEU_HoudiniAsset asset, UnityEngine.Vector3& inPosition) { }
        private System.Boolean GetUpdatedRotation(HoudiniEngineUnity.HEU_HoudiniAsset asset, UnityEngine.Quaternion& inRotation) { }
        private System.Boolean IsSpecialRSTOrder(HoudiniEngineUnity.HAPI_RSTOrder rstOrder) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_Handle other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000065
    public class HEU_HandleParamBinding, IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HEU_HandleParamBinding.HEU_HandleParamType _paramType;        // 0x10
        public System.Int32 _parmID;        // 0x14
        public System.String _paramName;        // 0x18
        public System.Boolean _bDisabled;        // 0x20
        public System.Boolean[] _boundChannels;        // 0x28

        // Methods
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_HandleParamBinding other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000067
    public class HEU_HAPIConstants
    {
        // Fields
        public static System.Int32 HAPI_POSITION_VECTOR_SIZE;        // 0x0
        public static System.Int32 HAPI_SCALE_VECTOR_SIZE;        // 0x0
        public static System.Int32 HAPI_SHEAR_VECTOR_SIZE;        // 0x0
        public static System.Int32 HAPI_NORMAL_VECTOR_SIZE;        // 0x0
        public static System.Int32 HAPI_QUATERNION_VECTOR_SIZE;        // 0x0
        public static System.Int32 HAPI_EULER_VECTOR_SIZE;        // 0x0
        public static System.Int32 HAPI_UV_VECTOR_SIZE;        // 0x0
        public static System.Int32 HAPI_COLOR_VECTOR_SIZE;        // 0x0
        public static System.Int32 HAPI_CV_VECTOR_SIZE;        // 0x0
        public static System.Int32 HAPI_PRIM_MIN_VERTEX_COUNT;        // 0x0
        public static System.Int32 HAPI_PRIM_MAX_VERTEX_COUNT;        // 0x0
        public static System.Int32 HAPI_INVALID_PARM_ID;        // 0x0
        public static System.String HAPI_ATTRIB_POSITION;        // 0x0
        public static System.String HAPI_ATTRIB_UV;        // 0x0
        public static System.String HAPI_ATTRIB_UV2;        // 0x0
        public static System.String HAPI_ATTRIB_NORMAL;        // 0x0
        public static System.String HAPI_ATTRIB_TANGENT;        // 0x0
        public static System.String HAPI_ATTRIB_TANGENT2;        // 0x0
        public static System.String HAPI_ATTRIB_COLOR;        // 0x0
        public static System.String HAPI_ATTRIB_NAME;        // 0x0
        public static System.String HAPI_ATTRIB_INSTANCE;        // 0x0
        public static System.String HAPI_ATTRIB_ROT;        // 0x0
        public static System.String HAPI_ATTRIB_SCALE;        // 0x0
        public static System.String HAPI_UNGROUPED_GROUP_NAME;        // 0x0
        public static System.String HAPI_RAW_FORMAT_NAME;        // 0x0
        public static System.String HAPI_PNG_FORMAT_NAME;        // 0x0
        public static System.String HAPI_JPEG_FORMAT_NAME;        // 0x0
        public static System.String HAPI_BMP_FORMAT_NAME;        // 0x0
        public static System.String HAPI_TIFF_FORMAT_NAME;        // 0x0
        public static System.String HAPI_TGA_FORMAT_NAME;        // 0x0
        public static System.String HAPI_DEFAULT_IMAGE_FORMAT_NAME;        // 0x0
        public static System.String HAPI_GLOBAL_NODES_NODE_NAME;        // 0x0
        public static System.String HAPI_ENV_HIP;        // 0x0
        public static System.String HAPI_ENV_JOB;        // 0x0
        public static System.String HAPI_ENV_CLIENT_NAME;        // 0x0
        public static System.String HAPI_CACHE_COP_COOK;        // 0x0
        public static System.String HAPI_CACHE_COP_FLIPBOOK;        // 0x0
        public static System.String HAPI_CACHE_IMAGE;        // 0x0
        public static System.String HAPI_CACHE_OBJ;        // 0x0
        public static System.String HAPI_CACHE_GL_TEXTURE;        // 0x0
        public static System.String HAPI_CACHE_GL_VERTEX;        // 0x0
        public static System.String HAPI_CACHE_SOP;        // 0x0
        public static System.String HAPI_CACHE_VEX;        // 0x0
        public static System.String HAPI_ATTRIB_INPUT_CURVE_COORDS;        // 0x0

    }

    // TypeToken: 0x2000068
    public struct HAPI_License
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_License HAPI_LICENSE_NONE;        // 0x0
        public static HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_ENGINE;        // 0x0
        public static HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI;        // 0x0
        public static HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_FX;        // 0x0
        public static HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_ENGINE_INDIE;        // 0x0
        public static HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_INDIE;        // 0x0
        public static HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_ENGINE_UNITY_UNREAL;        // 0x0
        public static HoudiniEngineUnity.HAPI_License HAPI_LICENSE_MAX;        // 0x0

    }

    // TypeToken: 0x2000069
    public struct HAPI_StatusType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_StatusType HAPI_STATUS_CALL_RESULT;        // 0x0
        public static HoudiniEngineUnity.HAPI_StatusType HAPI_STATUS_COOK_RESULT;        // 0x0
        public static HoudiniEngineUnity.HAPI_StatusType HAPI_STATUS_COOK_STATE;        // 0x0
        public static HoudiniEngineUnity.HAPI_StatusType HAPI_STATUS_MAX;        // 0x0

    }

    // TypeToken: 0x200006A
    public struct HAPI_StatusVerbosity
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_StatusVerbosity HAPI_STATUSVERBOSITY_0;        // 0x0
        public static HoudiniEngineUnity.HAPI_StatusVerbosity HAPI_STATUSVERBOSITY_1;        // 0x0
        public static HoudiniEngineUnity.HAPI_StatusVerbosity HAPI_STATUSVERBOSITY_2;        // 0x0
        public static HoudiniEngineUnity.HAPI_StatusVerbosity HAPI_STATUSVERBOSITY_ALL;        // 0x0
        public static HoudiniEngineUnity.HAPI_StatusVerbosity HAPI_STATUSVERBOSITY_ERRORS;        // 0x0
        public static HoudiniEngineUnity.HAPI_StatusVerbosity HAPI_STATUSVERBOSITY_WARNINGS;        // 0x0
        public static HoudiniEngineUnity.HAPI_StatusVerbosity HAPI_STATUSVERBOSITY_MESSAGES;        // 0x0

    }

    // TypeToken: 0x200006B
    public struct HAPI_Result
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_SUCCESS;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_FAILURE;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_ALREADY_INITIALIZED;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_NOT_INITIALIZED;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_CANT_LOADFILE;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_PARM_SET_FAILED;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_INVALID_ARGUMENT;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_CANT_LOAD_GEO;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_CANT_GENERATE_PRESET;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_CANT_LOAD_PRESET;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_ASSET_DEF_ALREADY_LOADED;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_NO_LICENSE_FOUND;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_DISALLOWED_NC_LICENSE_FOUND;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_DISALLOWED_NC_ASSET_WITH_C_LICENSE;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_DISALLOWED_NC_ASSET_WITH_LC_LICENSE;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_DISALLOWED_LC_ASSET_WITH_C_LICENSE;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_DISALLOWED_HENGINEINDIE_W_3PARTY_PLUGIN;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_ASSET_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_NODE_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_USER_INTERRUPTED;        // 0x0
        public static HoudiniEngineUnity.HAPI_Result HAPI_RESULT_INVALID_SESSION;        // 0x0

    }

    // TypeToken: 0x200006C
    public struct HAPI_ErrorCode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_ErrorCode HAPI_ERRORCODE_ASSET_DEF_NOT_FOUND;        // 0x0
        public static HoudiniEngineUnity.HAPI_ErrorCode HAPI_ERRORCODE_PYTHON_NODE_ERROR;        // 0x0

    }

    // TypeToken: 0x200006D
    public struct HAPI_SessionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_SessionType HAPI_SESSION_INPROCESS;        // 0x0
        public static HoudiniEngineUnity.HAPI_SessionType HAPI_SESSION_THRIFT;        // 0x0
        public static HoudiniEngineUnity.HAPI_SessionType HAPI_SESSION_CUSTOM1;        // 0x0
        public static HoudiniEngineUnity.HAPI_SessionType HAPI_SESSION_CUSTOM2;        // 0x0
        public static HoudiniEngineUnity.HAPI_SessionType HAPI_SESSION_CUSTOM3;        // 0x0
        public static HoudiniEngineUnity.HAPI_SessionType HAPI_SESSION_MAX;        // 0x0

    }

    // TypeToken: 0x200006E
    public struct HAPI_State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_READY;        // 0x0
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_READY_WITH_FATAL_ERRORS;        // 0x0
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_READY_WITH_COOK_ERRORS;        // 0x0
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_STARTING_COOK;        // 0x0
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_COOKING;        // 0x0
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_STARTING_LOAD;        // 0x0
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_LOADING;        // 0x0
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_MAX;        // 0x0
        public static HoudiniEngineUnity.HAPI_State HAPI_STATE_MAX_READY_STATE;        // 0x0

    }

    // TypeToken: 0x200006F
    public struct HAPI_PackedPrimInstancingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_PackedPrimInstancingMode HAPI_PACKEDPRIM_INSTANCING_MODE_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_PackedPrimInstancingMode HAPI_PACKEDPRIM_INSTANCING_MODE_DISABLED;        // 0x0
        public static HoudiniEngineUnity.HAPI_PackedPrimInstancingMode HAPI_PACKEDPRIM_INSTANCING_MODE_HIERARCHY;        // 0x0
        public static HoudiniEngineUnity.HAPI_PackedPrimInstancingMode HAPI_PACKEDPRIM_INSTANCING_MODE_FLAT;        // 0x0
        public static HoudiniEngineUnity.HAPI_PackedPrimInstancingMode HAPI_PACKEDPRIM_INSTANCING_MODE_MAX;        // 0x0

    }

    // TypeToken: 0x2000070
    public struct HAPI_Permissions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_Permissions HAPI_PERMISSIONS_NON_APPLICABLE;        // 0x0
        public static HoudiniEngineUnity.HAPI_Permissions HAPI_PERMISSIONS_READ_WRITE;        // 0x0
        public static HoudiniEngineUnity.HAPI_Permissions HAPI_PERMISSIONS_READ_ONLY;        // 0x0
        public static HoudiniEngineUnity.HAPI_Permissions HAPI_PERMISSIONS_WRITE_ONLY;        // 0x0
        public static HoudiniEngineUnity.HAPI_Permissions HAPI_PERMISSIONS_MAX;        // 0x0

    }

    // TypeToken: 0x2000071
    public struct HAPI_RampType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_RampType HAPI_RAMPTYPE_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_RampType HAPI_RAMPTYPE_FLOAT;        // 0x0
        public static HoudiniEngineUnity.HAPI_RampType HAPI_RAMPTYPE_COLOR;        // 0x0
        public static HoudiniEngineUnity.HAPI_RampType HAPI_RAMPTYPE_MAX;        // 0x0

    }

    // TypeToken: 0x2000072
    public struct HAPI_ParmType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_INT;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_MULTIPARMLIST;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_TOGGLE;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_BUTTON;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_FLOAT;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_COLOR;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_STRING;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_PATH_FILE;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_PATH_FILE_GEO;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_PATH_FILE_IMAGE;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_NODE;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_FOLDERLIST;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_FOLDERLIST_RADIO;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_FOLDER;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_LABEL;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_SEPARATOR;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_PATH_FILE_DIR;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_MAX;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_INT_START;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_INT_END;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_FLOAT_START;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_FLOAT_END;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_STRING_START;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_STRING_END;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_PATH_START;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_PATH_END;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_NODE_START;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_NODE_END;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_CONTAINER_START;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_CONTAINER_END;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_NONVALUE_START;        // 0x0
        public static HoudiniEngineUnity.HAPI_ParmType HAPI_PARMTYPE_NONVALUE_END;        // 0x0

    }

    // TypeToken: 0x2000073
    public struct HAPI_PrmScriptType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_INT;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_FLOAT;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_ANGLE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_STRING;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_FILE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_DIRECTORY;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_IMAGE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_GEOMETRY;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_TOGGLE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_BUTTON;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_VECTOR2;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_VECTOR3;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_VECTOR4;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_INTVECTOR2;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_INTVECTOR3;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_INTVECTOR4;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_UV;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_UVW;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_DIR;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_COLOR;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_COLOR4;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_OPPATH;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_OPLIST;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_OBJECT;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_OBJECTLIST;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_RENDER;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_SEPARATOR;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_GEOMETRY_DATA;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_KEY_VALUE_DICT;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_LABEL;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_RGBAMASK;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_ORDINAL;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_RAMP_FLT;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_RAMP_RGB;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_FLOAT_LOG;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_INT_LOG;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_DATA;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_FLOAT_MINMAX;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_INT_MINMAX;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_INT_STARTEND;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_BUTTONSTRIP;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_ICONSTRIP;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_GROUPRADIO;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_GROUPCOLLAPSIBLE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_GROUPSIMPLE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PrmScriptType HAPI_PRM_SCRIPT_TYPE_GROUP;        // 0x0

    }

    // TypeToken: 0x2000074
    public struct HAPI_ChoiceListType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_ChoiceListType HAPI_CHOICELISTTYPE_NONE;        // 0x0
        public static HoudiniEngineUnity.HAPI_ChoiceListType HAPI_CHOICELISTTYPE_NORMAL;        // 0x0
        public static HoudiniEngineUnity.HAPI_ChoiceListType HAPI_CHOICELISTTYPE_MINI;        // 0x0
        public static HoudiniEngineUnity.HAPI_ChoiceListType HAPI_CHOICELISTTYPE_REPLACE;        // 0x0
        public static HoudiniEngineUnity.HAPI_ChoiceListType HAPI_CHOICELISTTYPE_TOGGLE;        // 0x0

    }

    // TypeToken: 0x2000075
    public struct HAPI_PresetType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_PresetType HAPI_PRESETTYPE_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_PresetType HAPI_PRESETTYPE_BINARY;        // 0x0
        public static HoudiniEngineUnity.HAPI_PresetType HAPI_PRESETTYPE_IDX;        // 0x0
        public static HoudiniEngineUnity.HAPI_PresetType HAPI_PRESETTYPE_MAX;        // 0x0

    }

    // TypeToken: 0x2000076
    public struct HAPI_NodeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_ANY;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_NONE;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_OBJ;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_SOP;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_CHOP;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_ROP;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_SHOP;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_COP;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_VOP;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_DOP;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeType HAPI_NODETYPE_TOP;        // 0x0

    }

    // TypeToken: 0x2000077
    public struct HAPI_NodeFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_ANY;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_NONE;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_DISPLAY;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_RENDER;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_TEMPLATED;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_LOCKED;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_EDITABLE;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_BYPASS;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_NETWORK;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_OBJ_GEOMETRY;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_OBJ_CAMERA;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_OBJ_LIGHT;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_OBJ_SUBNET;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_SOP_CURVE;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_SOP_GUIDE;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_TOP_NONSCHEDULER;        // 0x0
        public static HoudiniEngineUnity.HAPI_NodeFlags HAPI_NODEFLAGS_NON_BYPASS;        // 0x0

    }

    // TypeToken: 0x2000078
    public struct HAPI_GroupType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_GroupType HAPI_GROUPTYPE_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_GroupType HAPI_GROUPTYPE_POINT;        // 0x0
        public static HoudiniEngineUnity.HAPI_GroupType HAPI_GROUPTYPE_PRIM;        // 0x0
        public static HoudiniEngineUnity.HAPI_GroupType HAPI_GROUPTYPE_EDGE;        // 0x0
        public static HoudiniEngineUnity.HAPI_GroupType HAPI_GROUPTYPE_MAX;        // 0x0

    }

    // TypeToken: 0x2000079
    public struct HAPI_AttributeOwner
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_AttributeOwner HAPI_ATTROWNER_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeOwner HAPI_ATTROWNER_VERTEX;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeOwner HAPI_ATTROWNER_POINT;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeOwner HAPI_ATTROWNER_PRIM;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeOwner HAPI_ATTROWNER_DETAIL;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeOwner HAPI_ATTROWNER_MAX;        // 0x0

    }

    // TypeToken: 0x200007A
    public struct HAPI_CurveType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_CurveType HAPI_CURVETYPE_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_CurveType HAPI_CURVETYPE_LINEAR;        // 0x0
        public static HoudiniEngineUnity.HAPI_CurveType HAPI_CURVETYPE_NURBS;        // 0x0
        public static HoudiniEngineUnity.HAPI_CurveType HAPI_CURVETYPE_BEZIER;        // 0x0
        public static HoudiniEngineUnity.HAPI_CurveType HAPI_CURVETYPE_MAX;        // 0x0

    }

    // TypeToken: 0x200007B
    public struct HAPI_InputCurveMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_InputCurveMethod HAPI_CURVEMETHOD_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_InputCurveMethod HAPI_CURVEMETHOD_CVS;        // 0x0
        public static HoudiniEngineUnity.HAPI_InputCurveMethod HAPI_CURVEMETHOD_BREAKPOINTS;        // 0x0
        public static HoudiniEngineUnity.HAPI_InputCurveMethod HAPI_CURVEMETHOD_MAX;        // 0x0

    }

    // TypeToken: 0x200007C
    public struct HAPI_InputCurveParameterization
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_InputCurveParameterization HAPI_CURVEPARAMETERIZATION_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_InputCurveParameterization HAPI_CURVEPARAMETERIZATION_UNIFORM;        // 0x0
        public static HoudiniEngineUnity.HAPI_InputCurveParameterization HAPI_CURVEPARAMETERIZATION_CHORD;        // 0x0
        public static HoudiniEngineUnity.HAPI_InputCurveParameterization HAPI_CURVEPARAMETERIZATION_CENTRIPETAL;        // 0x0
        public static HoudiniEngineUnity.HAPI_InputCurveParameterization HAPI_CURVEPARAMETERIZATION_MAX;        // 0x0

    }

    // TypeToken: 0x200007D
    public struct HAPI_VolumeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_VolumeType HAPI_VOLUMETYPE_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_VolumeType HAPI_VOLUMETYPE_HOUDINI;        // 0x0
        public static HoudiniEngineUnity.HAPI_VolumeType HAPI_VOLUMETYPE_VDB;        // 0x0
        public static HoudiniEngineUnity.HAPI_VolumeType HAPI_VOLUMETYPE_MAX;        // 0x0

    }

    // TypeToken: 0x200007E
    public struct HAPI_VolumeVisualType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_VolumeVisualType HAPI_VOLUMEVISTYPE_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_VolumeVisualType HAPI_VOLUMEVISTYPE_SMOKE;        // 0x0
        public static HoudiniEngineUnity.HAPI_VolumeVisualType HAPI_VOLUMEVISTYPE_RAINBOW;        // 0x0
        public static HoudiniEngineUnity.HAPI_VolumeVisualType HAPI_VOLUMEVISTYPE_ISO;        // 0x0
        public static HoudiniEngineUnity.HAPI_VolumeVisualType HAPI_VOLUMEVISTYPE_INVISIBLE;        // 0x0
        public static HoudiniEngineUnity.HAPI_VolumeVisualType HAPI_VOLUMEVISTYPE_HEIGHTFIELD;        // 0x0
        public static HoudiniEngineUnity.HAPI_VolumeVisualType HAPI_VOLUMEVISTYPE_MAX;        // 0x0

    }

    // TypeToken: 0x200007F
    public struct HAPI_StorageType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INT;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INT64;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_FLOAT;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_FLOAT64;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_STRING;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_UINT8;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INT8;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INT16;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INT_ARRAY;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INT64_ARRAY;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_FLOAT_ARRAY;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_FLOAT64_ARRAY;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_STRING_ARRAY;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_UINT8_ARRAY;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INT8_ARRAY;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_INT16_ARRAY;        // 0x0
        public static HoudiniEngineUnity.HAPI_StorageType HAPI_STORAGETYPE_MAX;        // 0x0

    }

    // TypeToken: 0x2000080
    public struct HAPI_AttributeTypeInfo
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_NONE;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_POINT;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_HPOINT;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_VECTOR;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_NORMAL;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_COLOR;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_QUATERNION;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_MATRIX3;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_MATRIX;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_ST;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_HIDDEN;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_BOX2;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_BOX;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_TEXTURE;        // 0x0
        public static HoudiniEngineUnity.HAPI_AttributeTypeInfo HAPI_ATTRIBUTE_TYPE_MAX;        // 0x0

    }

    // TypeToken: 0x2000081
    public struct HAPI_GeoType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_DEFAULT;        // 0x0
        public static HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_INTERMEDIATE;        // 0x0
        public static HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_INPUT;        // 0x0
        public static HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_CURVE;        // 0x0
        public static HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_MAX;        // 0x0

    }

    // TypeToken: 0x2000082
    public struct HAPI_PartType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_PartType HAPI_PARTTYPE_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_PartType HAPI_PARTTYPE_MESH;        // 0x0
        public static HoudiniEngineUnity.HAPI_PartType HAPI_PARTTYPE_CURVE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PartType HAPI_PARTTYPE_VOLUME;        // 0x0
        public static HoudiniEngineUnity.HAPI_PartType HAPI_PARTTYPE_INSTANCER;        // 0x0
        public static HoudiniEngineUnity.HAPI_PartType HAPI_PARTTYPE_BOX;        // 0x0
        public static HoudiniEngineUnity.HAPI_PartType HAPI_PARTTYPE_SPHERE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PartType HAPI_PARTTYPE_MAX;        // 0x0

    }

    // TypeToken: 0x2000083
    public struct HAPI_InputType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_InputType HAPI_INPUT_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_InputType HAPI_INPUT_TRANSFORM;        // 0x0
        public static HoudiniEngineUnity.HAPI_InputType HAPI_INPUT_GEOMETRY;        // 0x0
        public static HoudiniEngineUnity.HAPI_InputType HAPI_INPUT_MAX;        // 0x0

    }

    // TypeToken: 0x2000084
    public struct HAPI_CurveOrders
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_CurveOrders HAPI_CURVE_ORDER_VARYING;        // 0x0
        public static HoudiniEngineUnity.HAPI_CurveOrders HAPI_CURVE_ORDER_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_CurveOrders HAPI_CURVE_ORDER_LINEAR;        // 0x0
        public static HoudiniEngineUnity.HAPI_CurveOrders HAPI_CURVE_ORDER_QUADRATIC;        // 0x0
        public static HoudiniEngineUnity.HAPI_CurveOrders HAPI_CURVE_ORDER_CUBIC;        // 0x0

    }

    // TypeToken: 0x2000085
    public struct HAPI_TransformComponent
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_TX;        // 0x0
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_TY;        // 0x0
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_TZ;        // 0x0
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_RX;        // 0x0
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_RY;        // 0x0
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_RZ;        // 0x0
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_QX;        // 0x0
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_QY;        // 0x0
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_QZ;        // 0x0
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_QW;        // 0x0
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_SX;        // 0x0
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_SY;        // 0x0
        public static HoudiniEngineUnity.HAPI_TransformComponent HAPI_TRANSFORM_SZ;        // 0x0

    }

    // TypeToken: 0x2000086
    public struct HAPI_RSTOrder
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_RSTOrder HAPI_TRS;        // 0x0
        public static HoudiniEngineUnity.HAPI_RSTOrder HAPI_TSR;        // 0x0
        public static HoudiniEngineUnity.HAPI_RSTOrder HAPI_RTS;        // 0x0
        public static HoudiniEngineUnity.HAPI_RSTOrder HAPI_RST;        // 0x0
        public static HoudiniEngineUnity.HAPI_RSTOrder HAPI_STR;        // 0x0
        public static HoudiniEngineUnity.HAPI_RSTOrder HAPI_SRT;        // 0x0
        public static HoudiniEngineUnity.HAPI_RSTOrder HAPI_RSTORDER_DEFAULT;        // 0x0

    }

    // TypeToken: 0x2000087
    public struct HAPI_XYZOrder
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_XYZOrder HAPI_XYZ;        // 0x0
        public static HoudiniEngineUnity.HAPI_XYZOrder HAPI_XZY;        // 0x0
        public static HoudiniEngineUnity.HAPI_XYZOrder HAPI_YXZ;        // 0x0
        public static HoudiniEngineUnity.HAPI_XYZOrder HAPI_YZX;        // 0x0
        public static HoudiniEngineUnity.HAPI_XYZOrder HAPI_ZXY;        // 0x0
        public static HoudiniEngineUnity.HAPI_XYZOrder HAPI_ZYX;        // 0x0
        public static HoudiniEngineUnity.HAPI_XYZOrder HAPI_XYZORDER_DEFAULT;        // 0x0

    }

    // TypeToken: 0x2000088
    public struct HAPI_ImageDataFormat
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_ImageDataFormat HAPI_IMAGE_DATA_UNKNOWN;        // 0x0
        public static HoudiniEngineUnity.HAPI_ImageDataFormat HAPI_IMAGE_DATA_INT8;        // 0x0
        public static HoudiniEngineUnity.HAPI_ImageDataFormat HAPI_IMAGE_DATA_INT16;        // 0x0
        public static HoudiniEngineUnity.HAPI_ImageDataFormat HAPI_IMAGE_DATA_INT32;        // 0x0
        public static HoudiniEngineUnity.HAPI_ImageDataFormat HAPI_IMAGE_DATA_FLOAT16;        // 0x0
        public static HoudiniEngineUnity.HAPI_ImageDataFormat HAPI_IMAGE_DATA_FLOAT32;        // 0x0
        public static HoudiniEngineUnity.HAPI_ImageDataFormat HAPI_IMAGE_DATA_MAX;        // 0x0
        public static HoudiniEngineUnity.HAPI_ImageDataFormat HAPI_IMAGE_DATA_DEFAULT;        // 0x0

    }

    // TypeToken: 0x2000089
    public struct HAPI_ImagePacking
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_UNKNOWN;        // 0x0
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_SINGLE;        // 0x0
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_DUAL;        // 0x0
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_RGB;        // 0x0
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_BGR;        // 0x0
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_RGBA;        // 0x0
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_ABGR;        // 0x0
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_MAX;        // 0x0
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_DEFAULT3;        // 0x0
        public static HoudiniEngineUnity.HAPI_ImagePacking HAPI_IMAGE_PACKING_DEFAULT4;        // 0x0

    }

    // TypeToken: 0x200008A
    public struct HAPI_EnvIntType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_VERSION_HOUDINI_MAJOR;        // 0x0
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_VERSION_HOUDINI_MINOR;        // 0x0
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_VERSION_HOUDINI_BUILD;        // 0x0
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_VERSION_HOUDINI_PATCH;        // 0x0
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_VERSION_HOUDINI_ENGINE_MAJOR;        // 0x0
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_VERSION_HOUDINI_ENGINE_MINOR;        // 0x0
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_VERSION_HOUDINI_ENGINE_API;        // 0x0
        public static HoudiniEngineUnity.HAPI_EnvIntType HAPI_ENVINT_MAX;        // 0x0

    }

    // TypeToken: 0x200008B
    public struct HAPI_SessionEnvIntType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_SessionEnvIntType HAPI_SESSIONENVINT_INVALID;        // 0x0
        public static HoudiniEngineUnity.HAPI_SessionEnvIntType HAPI_SESSIONENVINT_LICENSE;        // 0x0
        public static HoudiniEngineUnity.HAPI_SessionEnvIntType HAPI_SESSIONENVINT_MAX;        // 0x0

    }

    // TypeToken: 0x200008C
    public struct HAPI_CacheProperty
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_CacheProperty HAPI_CACHEPROP_CURRENT;        // 0x0
        public static HoudiniEngineUnity.HAPI_CacheProperty HAPI_CACHEPROP_HAS_MIN;        // 0x0
        public static HoudiniEngineUnity.HAPI_CacheProperty HAPI_CACHEPROP_MIN;        // 0x0
        public static HoudiniEngineUnity.HAPI_CacheProperty HAPI_CACHEPROP_HAS_MAX;        // 0x0
        public static HoudiniEngineUnity.HAPI_CacheProperty HAPI_CACHEPROP_MAX;        // 0x0
        public static HoudiniEngineUnity.HAPI_CacheProperty HAPI_CACHEPROP_CULL_LEVEL;        // 0x0

    }

    // TypeToken: 0x200008D
    public struct HAPI_HeightFieldSampling
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_HeightFieldSampling HAPI_HEIGHTFIELD_SAMPLING_CENTER;        // 0x0
        public static HoudiniEngineUnity.HAPI_HeightFieldSampling HAPI_HEIGHTFIELD_SAMPLING_CORNER;        // 0x0

    }

    // TypeToken: 0x200008E
    public struct HAPI_PDG_State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_PDG_State HAPI_PDG_STATE_READY;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_State HAPI_PDG_STATE_COOKING;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_State HAPI_PDG_STATE_MAX;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_State HAPI_PDG_STATE_MAX_READY_STATE;        // 0x0

    }

    // TypeToken: 0x200008F
    public struct HAPI_PDG_EventType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NULL;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_ADD;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_REMOVE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_STATE_CHANGE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_ADD_DEP;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_REMOVE_DEP;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_ADD_PARENT;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_REMOVE_PARENT;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_CLEAR;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_COOK_ERROR;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_COOK_WARNING;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_COOK_COMPLETE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_DIRTY_START;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_DIRTY_STOP;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_DIRTY_ALL;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_UI_SELECT;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_CREATE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_REMOVE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_RENAME;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_CONNECT;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_DISCONNECT;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_SET_INT;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_SET_FLOAT;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_SET_STRING;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_SET_FILE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_SET_PYOBJECT;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_SET_GEOMETRY;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_MERGE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_RESULT;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_PRIORITY;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_COOK_START;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_ADD_STATIC_ANCESTOR;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_WORKITEM_REMOVE_STATIC_ANCESTOR;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_PROGRESS_UPDATE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_BATCH_ITEM_INITIALIZED;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_ALL;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_LOG;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_SCHEDULER_ADDED;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_SCHEDULER_REMOVED;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_SET_SCHEDULER;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_SERVICE_MANAGER_ALL;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_COOKED;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_EVENT_NODE_GENERATED;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_EventType HAPI_PDG_CONTEXT_EVENTS;        // 0x0

    }

    // TypeToken: 0x2000090
    public struct HAPI_PDG_WorkItemState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_UNDEFINED;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_UNCOOKED;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_WAITING;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_SCHEDULED;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_COOKING;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_COOKED_SUCCESS;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_COOKED_CACHE;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_COOKED_FAIL;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_COOKED_CANCEL;        // 0x0
        public static HoudiniEngineUnity.HAPI_PDG_WorkItemState HAPI_PDG_WORKITEM_DIRTY;        // 0x0

    }

    // TypeToken: 0x2000091
    public class HEU_HAPIFunctions
    {
    }

    // TypeToken: 0x2000092
    public struct HAPI_Transform
    {
        // Fields
        public System.Single[] position;        // 0x10
        public System.Single[] rotationQuaternion;        // 0x18
        public System.Single[] scale;        // 0x20
        public System.Single[] shear;        // 0x28
        public HoudiniEngineUnity.HAPI_RSTOrder rstOrder;        // 0x30

        // Methods
        private System.Void .ctor(System.Boolean initializeFields) { }
        private System.Void Init() { }

    }

    // TypeToken: 0x2000093
    public struct HAPI_TransformEuler
    {
        // Fields
        public System.Single[] position;        // 0x10
        public System.Single[] rotationEuler;        // 0x18
        public System.Single[] scale;        // 0x20
        public System.Single[] shear;        // 0x28
        public HoudiniEngineUnity.HAPI_XYZOrder rotationOrder;        // 0x30
        public HoudiniEngineUnity.HAPI_RSTOrder rstOrder;        // 0x34

        // Methods
        private System.Void .ctor(System.Boolean initializeFields) { }
        private System.Void Init() { }

    }

    // TypeToken: 0x2000094
    public struct HAPI_Session
    {
        // Fields
        public HoudiniEngineUnity.HAPI_SessionType type;        // 0x10
        public System.Int64 id;        // 0x18

    }

    // TypeToken: 0x2000095
    public struct HAPI_ThriftServerOptions
    {
        // Fields
        public System.Boolean autoClose;        // 0x10
        public System.Single timeoutMs;        // 0x14
        public HoudiniEngineUnity.HAPI_StatusVerbosity verbosity;        // 0x18

    }

    // TypeToken: 0x2000096
    public struct HAPI_TimelineOptions
    {
        // Fields
        public System.Single fps;        // 0x10
        public System.Single startTime;        // 0x14
        public System.Single endTime;        // 0x18

    }

    // TypeToken: 0x2000097
    public struct HAPI_AssetInfo
    {
        // Fields
        public System.Int32 nodeId;        // 0x10
        public System.Int32 objectNodeId;        // 0x14
        public System.Boolean hasEverCooked;        // 0x18
        public System.Int32 nameSH;        // 0x1C
        public System.Int32 labelSH;        // 0x20
        public System.Int32 filePathSH;        // 0x24
        public System.Int32 versionSH;        // 0x28
        public System.Int32 fullOpNameSH;        // 0x2C
        public System.Int32 helpTextSH;        // 0x30
        public System.Int32 helpURLSH;        // 0x34
        public System.Int32 objectCount;        // 0x38
        public System.Int32 handleCount;        // 0x3C
        public System.Int32 transformInputCount;        // 0x40
        public System.Int32 geoInputCount;        // 0x44
        public System.Int32 geoOutputCount;        // 0x48
        public System.Boolean haveObjectsChanged;        // 0x4C
        public System.Boolean haveMaterialsChanged;        // 0x4D

    }

    // TypeToken: 0x2000098
    public struct HAPI_CookOptions
    {
        // Fields
        public System.Boolean splitGeosByGroup;        // 0x10
        public System.Int32 splitGroupSH;        // 0x14
        public System.Boolean splitGeosByAttribute;        // 0x18
        public System.Int32 splitAttrSH;        // 0x1C
        public System.Int32 maxVerticesPerPrimitive;        // 0x20
        public System.Boolean refineCurveToLinear;        // 0x24
        public System.Single curveRefineLOD;        // 0x28
        public System.Boolean clearErrorsAndWarnings;        // 0x2C
        public System.Boolean cookTemplatedGeos;        // 0x2D
        public System.Boolean splitPointsByVertexAttributes;        // 0x2E
        public HoudiniEngineUnity.HAPI_PackedPrimInstancingMode packedPrimInstancingMode;        // 0x30
        public System.Boolean handleBoxPartTypes;        // 0x34
        public System.Boolean handleSpherePartTypes;        // 0x35
        public System.Boolean checkPartChanges;        // 0x36
        public System.Boolean cacheMeshTopology;        // 0x37
        public System.Boolean preferOutputNodes;        // 0x38
        public System.Int32 extraFlags;        // 0x3C

    }

    // TypeToken: 0x2000099
    public struct HAPI_NodeInfo
    {
        // Fields
        public System.Int32 id;        // 0x10
        public System.Int32 parentId;        // 0x14
        public System.Int32 nameSH;        // 0x18
        public HoudiniEngineUnity.HAPI_NodeType type;        // 0x1C
        public System.Boolean isValid;        // 0x20
        public System.Int32 totalCookCount;        // 0x24
        public System.Int32 uniqueHoudiniNodeId;        // 0x28
        public System.Int32 internalNodePathSH;        // 0x2C
        public System.Int32 parmCount;        // 0x30
        public System.Int32 parmIntValueCount;        // 0x34
        public System.Int32 parmFloatValueCount;        // 0x38
        public System.Int32 parmStringValueCount;        // 0x3C
        public System.Int32 parmChoiceCount;        // 0x40
        public System.Int32 childNodeCount;        // 0x44
        public System.Int32 inputCount;        // 0x48
        public System.Int32 outputCount;        // 0x4C
        public System.Boolean createdPostAssetLoad;        // 0x50
        public System.Boolean isTimeDependent;        // 0x51

    }

    // TypeToken: 0x200009A
    public struct HAPI_ParmInfo
    {
        // Fields
        public System.Int32 id;        // 0x10
        public System.Int32 parentId;        // 0x14
        public System.Int32 childIndex;        // 0x18
        public HoudiniEngineUnity.HAPI_ParmType type;        // 0x1C
        public HoudiniEngineUnity.HAPI_PrmScriptType scriptType;        // 0x20
        public System.Int32 typeInfoSH;        // 0x24
        public HoudiniEngineUnity.HAPI_Permissions permissions;        // 0x28
        public System.Int32 tagCount;        // 0x2C
        public System.Int32 size;        // 0x30
        public HoudiniEngineUnity.HAPI_ChoiceListType choiceListType;        // 0x34
        public System.Int32 choiceCount;        // 0x38
        public System.Int32 nameSH;        // 0x3C
        public System.Int32 labelSH;        // 0x40
        public System.Int32 templateNameSH;        // 0x44
        public System.Int32 helpSH;        // 0x48
        public System.Boolean hasMin;        // 0x4C
        public System.Boolean hasMax;        // 0x4D
        public System.Boolean hasUIMin;        // 0x4E
        public System.Boolean hasUIMax;        // 0x4F
        public System.Single min;        // 0x50
        public System.Single max;        // 0x54
        public System.Single UIMin;        // 0x58
        public System.Single UIMax;        // 0x5C
        public System.Boolean invisible;        // 0x60
        public System.Boolean disabled;        // 0x61
        public System.Boolean spare;        // 0x62
        public System.Boolean joinNext;        // 0x63
        public System.Boolean labelNone;        // 0x64
        public System.Int32 intValuesIndex;        // 0x68
        public System.Int32 floatValuesIndex;        // 0x6C
        public System.Int32 stringValuesIndex;        // 0x70
        public System.Int32 choiceIndex;        // 0x74
        public HoudiniEngineUnity.HAPI_NodeType inputNodeType;        // 0x78
        public HoudiniEngineUnity.HAPI_NodeFlags inputNodeFlag;        // 0x7C
        public System.Boolean isChildOfMultiParm;        // 0x80
        public System.Int32 instanceNum;        // 0x84
        public System.Int32 instanceLength;        // 0x88
        public System.Int32 instanceCount;        // 0x8C
        public System.Int32 instanceStartOffset;        // 0x90
        public HoudiniEngineUnity.HAPI_RampType rampType;        // 0x94
        public System.Int32 visibilityConditionSH;        // 0x98
        public System.Int32 disabledConditionSH;        // 0x9C
        public System.Boolean useMenuItemTokenAsValue;        // 0xA0

        // Methods
        private System.Boolean isInt() { }
        private System.Boolean isFloat() { }
        private System.Boolean isString() { }
        private System.Boolean isPath() { }
        private System.Boolean isNode() { }
        private System.Boolean isNonValue() { }

    }

    // TypeToken: 0x200009B
    public struct HAPI_ParmChoiceInfo
    {
        // Fields
        public System.Int32 parentParmId;        // 0x10
        public System.Int32 labelSH;        // 0x14
        public System.Int32 valueSH;        // 0x18

    }

    // TypeToken: 0x200009C
    public struct HAPI_HandleInfo
    {
        // Fields
        public System.Int32 nameSH;        // 0x10
        public System.Int32 typeNameSH;        // 0x14
        public System.Int32 bindingsCount;        // 0x18

    }

    // TypeToken: 0x200009D
    public struct HAPI_HandleBindingInfo
    {
        // Fields
        public System.Int32 handleParmNameSH;        // 0x10
        public System.Int32 assetParmNameSH;        // 0x14
        public System.Int32 assetParmId;        // 0x18
        public System.Int32 assetParmIndex;        // 0x1C

    }

    // TypeToken: 0x200009E
    public struct HAPI_ObjectInfo
    {
        // Fields
        public System.Int32 nameSH;        // 0x10
        public System.Int32 objectInstancePathSH;        // 0x14
        public System.Boolean hasTransformChanged;        // 0x18
        public System.Boolean haveGeosChanged;        // 0x19
        public System.Boolean isVisible;        // 0x1A
        public System.Boolean isInstancer;        // 0x1B
        public System.Boolean isInstanced;        // 0x1C
        public System.Int32 geoCount;        // 0x20
        public System.Int32 nodeId;        // 0x24
        public System.Int32 objectToInstanceId;        // 0x28

    }

    // TypeToken: 0x200009F
    public struct HAPI_GeoInfo
    {
        // Fields
        public HoudiniEngineUnity.HAPI_GeoType type;        // 0x10
        public System.Int32 nameSH;        // 0x14
        public System.Int32 nodeId;        // 0x18
        public System.Boolean isEditable;        // 0x1C
        public System.Boolean isTemplated;        // 0x1D
        public System.Boolean isDisplayGeo;        // 0x1E
        public System.Boolean hasGeoChanged;        // 0x1F
        public System.Boolean hasMaterialChanged;        // 0x20
        public System.Int32 pointGroupCount;        // 0x24
        public System.Int32 primitiveGroupCount;        // 0x28
        public System.Int32 edgeGroupCount;        // 0x2C
        public System.Int32 partCount;        // 0x30

        // Methods
        private System.Int32 getGroupCountByType(HoudiniEngineUnity.HAPI_GroupType type) { }

    }

    // TypeToken: 0x20000A0
    public struct HAPI_PartInfo
    {
        // Fields
        public System.Int32 id;        // 0x10
        public System.Int32 nameSH;        // 0x14
        public HoudiniEngineUnity.HAPI_PartType type;        // 0x18
        public System.Int32 faceCount;        // 0x1C
        public System.Int32 vertexCount;        // 0x20
        public System.Int32 pointCount;        // 0x24
        public System.Int32[] attributeCounts;        // 0x28
        public System.Boolean isInstanced;        // 0x30
        public System.Int32 instancedPartCount;        // 0x34
        public System.Int32 instanceCount;        // 0x38
        public System.Boolean hasChanged;        // 0x3C

        // Methods
        private System.Int32 getElementCountByAttributeOwner(HoudiniEngineUnity.HAPI_AttributeOwner owner) { }
        private System.Int32 getElementCountByGroupType(HoudiniEngineUnity.HAPI_GroupType type) { }
        private System.Void init() { }
        private System.Int32 get_pointAttributeCount() { }
        private System.Void set_pointAttributeCount(System.Int32 value) { }
        private System.Int32 get_primitiveAttributeCount() { }
        private System.Void set_primitiveAttributeCount(System.Int32 value) { }
        private System.Int32 get_vertexAttributeCount() { }
        private System.Void set_vertexAttributeCount(System.Int32 value) { }
        private System.Int32 get_detailAttributeCount() { }
        private System.Void set_detailAttributeCount(System.Int32 value) { }

    }

    // TypeToken: 0x20000A1
    public struct HAPI_AttributeInfo
    {
        // Fields
        public System.Boolean exists;        // 0x10
        public HoudiniEngineUnity.HAPI_AttributeOwner owner;        // 0x14
        public HoudiniEngineUnity.HAPI_StorageType storage;        // 0x18
        public HoudiniEngineUnity.HAPI_AttributeOwner originalOwner;        // 0x1C
        public System.Int32 count;        // 0x20
        public System.Int32 tupleSize;        // 0x24
        public System.Int64 totalArrayElements;        // 0x28
        public HoudiniEngineUnity.HAPI_AttributeTypeInfo typeInfo;        // 0x30

        // Methods
        private System.Void .ctor(System.String ignored) { }

    }

    // TypeToken: 0x20000A2
    public struct HAPI_MaterialInfo
    {
        // Fields
        public System.Int32 nodeId;        // 0x10
        public System.Boolean exists;        // 0x14
        public System.Boolean hasChanged;        // 0x15

    }

    // TypeToken: 0x20000A3
    public struct HAPI_ImageFileFormat
    {
        // Fields
        public System.Int32 nameSH;        // 0x10
        public System.Int32 descriptionSH;        // 0x14
        public System.Int32 defaultExtensionSH;        // 0x18

    }

    // TypeToken: 0x20000A4
    public struct HAPI_ImageInfo
    {
        // Fields
        public System.Int32 imageFileFormatNameSH;        // 0x10
        public System.Int32 xRes;        // 0x14
        public System.Int32 yRes;        // 0x18
        public HoudiniEngineUnity.HAPI_ImageDataFormat dataFormat;        // 0x1C
        public System.Boolean interleaved;        // 0x20
        public HoudiniEngineUnity.HAPI_ImagePacking packing;        // 0x24
        public System.Double gamma;        // 0x28

    }

    // TypeToken: 0x20000A5
    public struct HAPI_Keyframe
    {
        // Fields
        public System.Single time;        // 0x10
        public System.Single value;        // 0x14
        public System.Single inTangent;        // 0x18
        public System.Single outTangent;        // 0x1C

        // Methods
        private System.Void .ctor(System.Single t, System.Single v, System.Single in_tangent, System.Single out_tangent) { }

    }

    // TypeToken: 0x20000A6
    public struct HAPI_VolumeInfo
    {
        // Fields
        public System.Int32 nameSH;        // 0x10
        public HoudiniEngineUnity.HAPI_VolumeType type;        // 0x14
        public System.Int32 xLength;        // 0x18
        public System.Int32 yLength;        // 0x1C
        public System.Int32 zLength;        // 0x20
        public System.Int32 minX;        // 0x24
        public System.Int32 minY;        // 0x28
        public System.Int32 minZ;        // 0x2C
        public System.Int32 tupleSize;        // 0x30
        public HoudiniEngineUnity.HAPI_StorageType storage;        // 0x34
        public System.Int32 tileSize;        // 0x38
        public HoudiniEngineUnity.HAPI_Transform transform;        // 0x40
        public System.Boolean hasTaper;        // 0x68
        public System.Single xTaper;        // 0x6C
        public System.Single yTaper;        // 0x70

    }

    // TypeToken: 0x20000A7
    public struct HAPI_VolumeTileInfo
    {
        // Fields
        public System.Int32 minX;        // 0x10
        public System.Int32 minY;        // 0x14
        public System.Int32 minZ;        // 0x18
        public System.Boolean isValid;        // 0x1C

    }

    // TypeToken: 0x20000A8
    public struct HAPI_VolumeVisualInfo
    {
        // Fields
        public HoudiniEngineUnity.HAPI_VolumeVisualType type;        // 0x10
        public System.Single iso;        // 0x14
        public System.Single density;        // 0x18

    }

    // TypeToken: 0x20000A9
    public struct HAPI_CurveInfo
    {
        // Fields
        public HoudiniEngineUnity.HAPI_CurveType curveType;        // 0x10
        public System.Int32 curveCount;        // 0x14
        public System.Int32 vertexCount;        // 0x18
        public System.Int32 knotCount;        // 0x1C
        public System.Boolean isPeriodic;        // 0x20
        public System.Boolean isRational;        // 0x21
        public System.Int32 order;        // 0x24
        public System.Boolean hasKnots;        // 0x28
        public System.Boolean isClosed;        // 0x29

    }

    // TypeToken: 0x20000AA
    public struct HAPI_InputCurveInfo
    {
        // Fields
        public HoudiniEngineUnity.HAPI_CurveType curveType;        // 0x10
        public System.Int32 order;        // 0x14
        public System.Boolean closed;        // 0x18
        public System.Boolean reverse;        // 0x19
        public HoudiniEngineUnity.HAPI_InputCurveMethod inputMethod;        // 0x1C
        public HoudiniEngineUnity.HAPI_InputCurveParameterization breakpointParameterization;        // 0x20

        // Methods
        private System.Void FillData(HoudiniEngineUnity.HEU_InputCurveInfo curveInfo) { }

    }

    // TypeToken: 0x20000AB
    public struct HAPI_BoxInfo
    {
        // Fields
        public System.Single[] center;        // 0x10
        public System.Single[] size;        // 0x18
        public System.Single[] rotation;        // 0x20

        // Methods
        private System.Void .ctor(System.Boolean initialize_fields) { }

    }

    // TypeToken: 0x20000AC
    public struct HAPI_SphereInfo
    {
        // Fields
        public System.Single[] center;        // 0x10
        public System.Single radius;        // 0x18

        // Methods
        private System.Void .ctor(System.Boolean initialize_fields) { }

    }

    // TypeToken: 0x20000AD
    public struct HAPI_PDG_EventInfo
    {
        // Fields
        public System.Int32 nodeId;        // 0x10
        public System.Int32 workItemId;        // 0x14
        public System.Int32 dependencyId;        // 0x18
        public System.Int32 currentState;        // 0x1C
        public System.Int32 lastState;        // 0x20
        public System.Int32 eventType;        // 0x24
        public System.Int32 msgSH;        // 0x28

    }

    // TypeToken: 0x20000AE
    public struct HAPI_PDG_WorkItemInfo
    {
        // Fields
        public System.Int32 index;        // 0x10
        public System.Int32 outputFileCount;        // 0x14
        public System.Int32 nameSH;        // 0x18

    }

    // TypeToken: 0x20000AF
    public struct HAPI_PDG_WorkItemOutputFile
    {
        // Fields
        public System.Int32 filePathSH;        // 0x10
        public System.Int32 tagSH;        // 0x14
        public System.Int64 hash;        // 0x18

    }

    // TypeToken: 0x20000B0
    public struct HAPI_Viewport
    {
        // Fields
        public System.Single[] position;        // 0x10
        public System.Single[] rotationQuaternion;        // 0x18
        public System.Single offset;        // 0x20

        // Methods
        private System.Void .ctor(System.Boolean initializeFields) { }
        private System.Void Init() { }

    }

    // TypeToken: 0x20000B1
    public struct HAPI_SessionSyncInfo
    {
        // Fields
        public System.Boolean cookUsingHoudiniTime;        // 0x10
        public System.Boolean syncViewport;        // 0x11

    }

    // TypeToken: 0x20000B2
    public struct HAPI_CompositorOptions
    {
        // Fields
        public System.Int32 maximumResolutionX;        // 0x10
        public System.Int32 maximumResolutionY;        // 0x14

    }

    // TypeToken: 0x20000B3
    public class HEU_HARCImports
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B4
    public class HEU_HoudiniVersion
    {
        // Fields
        public static System.Int32 HOUDINI_MAJOR;        // 0x0
        public static System.Int32 HOUDINI_MINOR;        // 0x0
        public static System.Int32 HOUDINI_BUILD;        // 0x0
        public static System.Int32 HOUDINI_PATCH;        // 0x0
        public static System.String HOUDINI_VERSION_STRING;        // 0x0
        public static System.Int32 HOUDINI_ENGINE_MAJOR;        // 0x0
        public static System.Int32 HOUDINI_ENGINE_MINOR;        // 0x0
        public static System.Int32 HOUDINI_ENGINE_API;        // 0x0
        public static System.Int32 UNITY_PLUGIN_VERSION;        // 0x0
        public static System.String HAPI_BIN_PATH;        // 0x0
        public static System.String HAPI_LIBRARY;        // 0x0
        public static System.String HARC_LIBRARY;        // 0x0
        public static System.String SIDEFX_SOFTWARE_REGISTRY;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B5
    public class HTC_APIConstants
    {
        // Fields
        public static System.String HOUDINI_MASTER_SERVER_HOSTNAME;        // 0x0
        public static System.Int32 HOUDINI_MASTER_QUERY_FOR_UNITY_PORT;        // 0x0
        public static System.Int32 TCP_HEADER_SIZE;        // 0x0
        public static System.Int32 MAX_ERROR_INFO_SIZE;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B6
    public class HTC_VERSION
    {
        // Fields
        public static System.String LIBRARY;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B7
    public class HoudiniConstsIdentifier
    {
        // Fields
        public static System.String HOUDINI_VERSION;        // 0x0
        public static System.String PROJECT_TAG;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B8
    public class HTC_APIFunctions
    {
        // Methods
        private System.Void InitHoudiniTcpClient(System.String address, System.Int32 port, System.Boolean use_ip, System.Text.StringBuilder error_msg) { }
        private System.Void GetHarsInfo(HoudiniEngineUnity.HarsInfo& harsInfo, System.Text.StringBuilder error_msg) { }
        private System.Void UninitializeHoudiniTcpClient(System.Text.StringBuilder error_msg) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B9
    public struct HarsInfo
    {
        // Fields
        public System.String hars_address;        // 0x10
        public System.Int32 port;        // 0x18

    }

    // TypeToken: 0x20000BA
    public struct GenericMessage
    {
        // Fields
        public System.String protocol;        // 0x10
        public System.Object body;        // 0x18

    }

    // TypeToken: 0x20000BB
    public class Logger
    {
        // Methods
        private System.Void LogError(System.String msg) { }
        private System.Void LogWarning(System.String msg) { }
        private System.Void LogInfo(System.String msg) { }

    }

    // TypeToken: 0x20000BC
    public class HTC_SessionManager, IDisposable
    {
        // Fields
        private System.Boolean disposedValue;        // 0x10
        private static HoudiniEngineUnity.HTC_SessionManager instance_;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void Finalize() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Dispose() { }
        private System.Boolean GetOrRequestAvailableHARSInfo(System.String& harsAddress, System.Int32& harsPort, System.String& errorInfo) { }
        private System.Void Close() { }
        private HoudiniEngineUnity.HTC_SessionManager get_Instance() { }

    }

    // TypeToken: 0x20000BD
    public class HTC_Utils
    {
        // Fields
        private static readonly System.String CurrentUnityProjectPrefix;        // 0x0

        // Methods
        private System.String GetUnityPathFromSystemPath(System.String systemPath) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000BE
    public class HoudiniExtTools
    {
        // Fields
        private static readonly System.String LOCAL_IP_ADDRESS;        // 0x0
        private static readonly System.String REMOTE_HOUDINI_SMB_PATH_PREFIX;        // 0x8
        private static readonly System.String REMOTE_HOUDINI_DEBUG_SMB_PATH_PREFIX;        // 0x10
        public static System.String REMOTE_HOUDINI_HDA_SMB_URL;        // 0x0
        public static System.String REMOTE_HOUDINI_SMB_URL;        // 0x0
        public static System.String LINUX_MOUNT_DIR_PREFIX;        // 0x0
        public static System.String PROJECT_TAG;        // 0x0

        // Methods
        private System.Int64 GetSessionID(System.Int64 sessionId) { }
        private System.String GetDefaultDirectoryOnTheSMB() { }
        private System.String GetDefaultSessionDirectoryOnTheSMB(System.Int64 sessionId) { }
        private System.String ConvertLocalDirPathToSessionDirPath(System.String localPath, System.Boolean doMd5, System.Int64 sessionId) { }
        private System.String ConvertLocalDebugFilePathToSessionDebugFilePath(System.String localFilePath, System.Int64 sessionId) { }
        private System.String ConvertLocalFilePathToSessionFilePath(System.String localFilePath, System.Int64 sessionId) { }
        private System.Boolean IsLocalPath(System.String path) { }
        private System.String GetMD5WithString(System.String str) { }
        private System.String GetLocalIPv4() { }
        private System.String GetHoudiniSMBUrl() { }
        private System.String GetDefaultCachePath(System.Int64 sessionId) { }
        private System.String GetDefaultHdaPath() { }
        private System.Int64 get_DefaultSessionID() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000BF
    public class HoudiniExtBridge
    {
        // Methods
        private System.Boolean GetParametersFromHDA(System.Byte[] hdaBytes, HoudiniEngineUnity.HEU_Parameters& parameters, System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode>& inputNodes) { }
        private System.Void AddInputNodeToHoudiniAsset(HoudiniEngineUnity.HEU_HoudiniAsset asset, HoudiniEngineUnity.HEU_InputNode node) { }
        private System.Void Clear(HoudiniEngineUnity.HEU_Parameters parameters) { }

    }

    // TypeToken: 0x20000C0
    public class HEU_ParameterData, IEquivable`1
    {
        // Fields
        public System.Int32 _unityIndex;        // 0x10
        public System.String _name;        // 0x18
        public System.String _labelName;        // 0x20
        public System.String _help;        // 0x28
        public System.Collections.Generic.List<System.Int32> _childParameterIDs;        // 0x30
        public System.Int32 _choiceValue;        // 0x38
        public System.Int32[] _intValues;        // 0x40
        public System.Single[] _floatValues;        // 0x48
        public System.String[] _stringValues;        // 0x50
        public System.Boolean _toggle;        // 0x58
        public UnityEngine.Color _color;        // 0x5C
        public UnityEngine.Gradient _gradient;        // 0x70
        public UnityEngine.AnimationCurve _animCurve;        // 0x78
        public UnityEngine.GUIContent[] _choiceLabels;        // 0x80
        public System.String[] _choiceStringValues;        // 0x88
        public System.Int32[] _choiceIntValues;        // 0x90
        public HoudiniEngineUnity.HAPI_ParmInfo _parmInfo;        // 0x98
        public System.Boolean _showChildren;        // 0x12C
        public System.String _fileTypeInfo;        // 0x130
        public System.Int32 _folderListChildrenProcessed;        // 0x138
        public System.Int32 _tabSelectedIndex;        // 0x13C
        public HoudiniEngineUnity.HEU_InputNode _paramInputNode;        // 0x140
        public System.Boolean _hasAssetPathTag;        // 0x148

        // Methods
        private System.Int32 get_ParmID() { }
        private System.Int32 get_ParentID() { }
        private System.Int32 get_ChildIndex() { }
        private System.Int32 get_ParmSize() { }
        private System.Boolean IsInt() { }
        private System.Boolean IsFloat() { }
        private System.Boolean IsString() { }
        private System.Boolean IsPathFile() { }
        private System.Boolean HasMin() { }
        private System.Boolean HasMax() { }
        private System.Boolean HasUIMin() { }
        private System.Boolean HasUIMax() { }
        private System.Int32 get_IntMin() { }
        private System.Int32 get_IntMax() { }
        private System.Int32 get_IntUIMin() { }
        private System.Int32 get_IntUIMax() { }
        private System.Single get_FloatMin() { }
        private System.Single get_FloatMax() { }
        private System.Single get_FloatUIMin() { }
        private System.Single get_FloatUIMax() { }
        private System.Boolean IsContainer() { }
        private System.Boolean IsMultiParam() { }
        private System.Boolean IsRamp() { }
        private System.Boolean IsFloatRamp() { }
        private System.Boolean IsColorRamp() { }
        private System.Boolean IsToggle() { }
        private System.Boolean IsColor() { }
        private System.Boolean IsFolder() { }
        private System.Boolean IsButton() { }
        private UnityEngine.Vector3 ToVector3() { }
        private System.Boolean IsAssetPath() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ParameterData other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C1
    public struct HEU_ModifierActionWrapper
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_ModifierActionWrapper MULTIPARM_INSERT;        // 0x0
        public static HoudiniEngineUnity.HEU_ModifierActionWrapper MULTIPARM_REMOVE;        // 0x0
        public static HoudiniEngineUnity.HEU_ModifierActionWrapper MULTIPARM_CLEAR;        // 0x0
        public static HoudiniEngineUnity.HEU_ModifierActionWrapper SET_FLOAT;        // 0x0
        public static HoudiniEngineUnity.HEU_ModifierActionWrapper SET_INT;        // 0x0

    }

    // TypeToken: 0x20000C2
    public class HEU_ParameterModifier, IEquivable`1
    {
        // Fields
        private System.Int32 _parameterIndex;        // 0x10
        private HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction _action;        // 0x14
        private System.Int32 _instanceIndex;        // 0x18
        private System.Int32 _modifierValue;        // 0x1C
        private System.Single _floatValue;        // 0x20
        private System.Int32 _intValue;        // 0x24

        // Methods
        private System.Int32 get_ParameterIndex() { }
        private System.Void set_ParameterIndex(System.Int32 value) { }
        private HoudiniEngineUnity.HEU_ModifierActionWrapper get_Action() { }
        private System.Void set_Action(HoudiniEngineUnity.HEU_ModifierActionWrapper value) { }
        private System.Int32 get_InstanceIndex() { }
        private System.Void set_InstanceIndex(System.Int32 value) { }
        private System.Int32 get_ModifierValue() { }
        private System.Void set_ModifierValue(System.Int32 value) { }
        private System.Single get_FloatValue() { }
        private System.Void set_FloatValue(System.Single value) { }
        private System.Int32 get_IntValue() { }
        private System.Void set_IntValue(System.Int32 value) { }
        private HoudiniEngineUnity.HEU_ParameterModifier GetNewModifier(HoudiniEngineUnity.HEU_ModifierActionWrapper action, System.Int32 parameterIndex, System.Int32 instanceIndex, System.Int32 modifierValue) { }
        private HoudiniEngineUnity.HEU_ParameterModifier GetNewModifier(HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction action, System.Int32 parameterIndex, System.Int32 instanceIndex, System.Int32 modifierValue) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ParameterModifier other) { }
        private HoudiniEngineUnity.HEU_ModifierActionWrapper ModifierAction_InternalToWrapper(HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction action) { }
        private HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction ModifierAction_WrapperToInternal(HoudiniEngineUnity.HEU_ModifierActionWrapper action) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C4
    public class HEU_Parameters : ScriptableObject, IHEU_Parameters, IHEU_HoudiniAssetSubcomponent, IEquivable`1
    {
        // Fields
        private System.Int32 _nodeID;        // 0x18
        private System.String _uiLabel;        // 0x20
        private System.Int32[] _paramInts;        // 0x28
        private System.Single[] _paramFloats;        // 0x30
        private System.String[] _paramStrings;        // 0x38
        private HoudiniEngineUnity.HAPI_ParmChoiceInfo[] _paramChoices;        // 0x40
        private System.Collections.Generic.List<System.Int32> _rootParameters;        // 0x48
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterData> _parameterList;        // 0x50
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterModifier> _parameterModifiers;        // 0x58
        private System.Boolean _regenerateParameters;        // 0x60
        private System.Byte[] _presetData;        // 0x68
        private System.Byte[] _defaultPresetData;        // 0x70
        private System.Boolean _validParameters;        // 0x78
        private System.Boolean _showParameters;        // 0x79
        private System.Boolean _recacheUI;        // 0x7A
        private HoudiniEngineUnity.HEU_HoudiniAsset _parentAsset;        // 0x80

        // Methods
        private HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset() { }
        private System.Boolean get_ShowParameters() { }
        private System.Void set_ShowParameters(System.Boolean value) { }
        private System.Int32 get_NodeID() { }
        private System.Void set_NodeID(System.Int32 value) { }
        private System.Collections.Generic.List<System.Int32> get_RootParameters() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterModifier> get_ParameterModifiers() { }
        private System.Boolean get_RequiresRegeneration() { }
        private System.Void set_RequiresRegeneration(System.Boolean value) { }
        private System.Byte[] GetPresetData() { }
        private System.Void SetPresetData(System.Byte[] data) { }
        private System.Byte[] GetDefaultPresetData() { }
        private System.Boolean get_RecacheUI() { }
        private System.Void set_RecacheUI(System.Boolean value) { }
        private System.Boolean AreParametersValid() { }
        private HoudiniEngineUnity.HEU_SessionBase GetSession() { }
        private System.Void Recook() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterData> GetParameters() { }
        private HoudiniEngineUnity.HEU_ParameterData GetParameter(System.Int32 listIndex) { }
        private HoudiniEngineUnity.HEU_ParameterData GetParameter(System.String name) { }
        private HoudiniEngineUnity.HEU_ParameterData GetParameterWithParmID(System.Int32 parmID) { }
        private System.Void RemoveParameter(System.Int32 listIndex) { }
        private System.Boolean HaveParametersChanged() { }
        private System.Boolean ResetAllToDefault(System.Boolean bRecookAsset) { }
        private System.Boolean SetFloatParameterValue(System.String parameterName, System.Single value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        private System.Boolean GetFloatParameterValue(System.String parameterName, System.Single& value, System.Int32 atIndex) { }
        private System.Boolean SetFloatParameterValues(System.String parameterName, System.Single[] values, System.Boolean bRecookAsset) { }
        private System.Boolean GetFloatParameterValues(System.String parameterName, System.Single[]& values) { }
        private System.Boolean SetColorParameterValue(System.String parameterName, UnityEngine.Color value, System.Boolean bRecookAsset) { }
        private System.Boolean GetColorParameterValue(System.String parameterName, UnityEngine.Color& value) { }
        private System.Boolean SetIntParameterValue(System.String parameterName, System.Int32 value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        private System.Boolean GetIntParameterValue(System.String parameterName, System.Int32& value, System.Int32 atIndex) { }
        private System.Boolean SetIntParameterValues(System.String parameterName, System.Int32[] values, System.Boolean bRecookAsset) { }
        private System.Boolean GetIntParameterValues(System.String parameterName, System.Int32[]& values) { }
        private System.Boolean SetChoiceParameterValue(System.String parameterName, System.Int32 value, System.Boolean bRecookAsset) { }
        private System.Boolean GetChoiceParameterValue(System.String parameterName, System.Int32& value) { }
        private System.Boolean SetBoolParameterValue(System.String parameterName, System.Boolean value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        private System.Boolean GetBoolParameterValue(System.String parameterName, System.Boolean& value, System.Int32 atIndex) { }
        private System.Boolean SetStringParameterValue(System.String parameterName, System.String value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        private System.Boolean GetStringParameterValue(System.String parameterName, System.String& value, System.Int32 atIndex) { }
        private System.Boolean SetStringParameterValues(System.String parameterName, System.String[] values, System.Boolean bRecookAsset) { }
        private System.Boolean GetStringParameterValues(System.String parameterName, System.String[]& values) { }
        private System.Boolean SetAssetRefParameterValue(System.String parameterName, UnityEngine.GameObject value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        private System.Boolean SetAssetRefParameterValues(System.String parameterName, UnityEngine.GameObject[] values, System.Boolean bRecookAsset) { }
        private System.Boolean GetAssetRefParameterValue(System.String parameterName, UnityEngine.GameObject& value, System.Int32 atIndex) { }
        private System.Boolean GetAssetRefParameterValues(System.String parameterName, UnityEngine.GameObject[]& values) { }
        private System.Boolean SetRampParameterNumPoints(System.String parameterName, System.Int32 numPoints, System.Boolean bRecookAsset) { }
        private System.Boolean GetRampParameterNumPoints(System.String parameterName, System.Int32& numPoints) { }
        private System.Boolean SetFloatRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single pointPosition, System.Single pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolationType, System.Boolean bRecookAsset) { }
        private System.Boolean GetFloatRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single& pointPosition, System.Single& pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper& interpolationType) { }
        private System.Boolean SetFloatRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_FloatRampPointWrapper[] rampPoints, System.Boolean bRecookAsset) { }
        private System.Boolean GetFloatRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_FloatRampPointWrapper[]& rampPoints) { }
        private System.Boolean SetColorRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single pointPosition, UnityEngine.Color pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolationType, System.Boolean bRecookAsset) { }
        private System.Boolean GetColorRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single& pointPosition, UnityEngine.Color& pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper& interpolationType) { }
        private System.Boolean SetColorRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_ColorRampPointWrapper[] rampPoints, System.Boolean bRecookAsset) { }
        private System.Boolean GetColorRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_ColorRampPointWrapper[]& rampPoints) { }
        private System.Boolean TriggerButtonParameter(System.String parameterName) { }
        private System.Boolean SetParameterTuples(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterTupleWrapper> parameterTuples, System.Boolean bRecook) { }
        private System.Boolean GetParameterTuples(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterTupleWrapper>& parameterTuples) { }
        private System.Boolean Initialize(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterData> previousParamFolders, System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_InputNode> previousParamInputNodes, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset) { }
        private System.Boolean Initialize4HGTool(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, System.Int32 parentNodeId) { }
        private System.Void SetupRampParameter(HoudiniEngineUnity.HEU_ParameterData rampParameter) { }
        private System.Boolean UploadValuesToHoudini(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean bDoCheck, System.Boolean bForceUploadInputs) { }
        private System.Void InsertInstanceToMultiParm(System.Int32 unityParamIndex, System.Int32 instanceIndex, System.Int32 numInstancesToAdd) { }
        private System.Void RemoveInstancesFromMultiParm(System.Int32 unityParamIndex, System.Int32 instanceIndex, System.Int32 numInstancesToRemove) { }
        private System.Void ClearInstancesFromMultiParm(System.Int32 unityParamIndex) { }
        private System.Boolean HasModifiersPending() { }
        private System.Void ProcessModifiers(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void GetParameterDataForUIRestore(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterData> folderParams, System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_InputNode> inputNodeParams) { }
        private System.Void GetInputNodeConnectionObjects(System.Collections.Generic.List<UnityEngine.GameObject> inputNodeObjects) { }
        private System.Void DownloadPresetData(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void UploadPresetData(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void DownloadAsDefaultPresetData(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void UploadParameterInputs(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean bForceUpdate) { }
        private System.Void UpdateTransformParameters(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_TransformEuler& HAPITransform) { }
        private System.Void SyncParameterFromHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.String parameterName) { }
        private System.Void SyncInternalParametersForUndoCompare(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void CleanUp() { }
        private System.Void ResetAllToDefault(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_Parameters other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C7
    public class HEU_ParameterUtility
    {
        // Methods
        private System.Boolean GetToggle(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Boolean& outValue) { }
        private System.Boolean SetToggle(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Boolean setValue) { }
        private System.Boolean GetInt(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32& outValue) { }
        private System.Boolean SetInt(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32 setValue) { }
        private System.Boolean GetFloat(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Single& outValue) { }
        private System.Boolean GetFloats(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Single[]& outValues) { }
        private System.Boolean SetFloat(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Single setValue) { }
        private System.Boolean SetFloats(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Single[] setValues) { }
        private System.Boolean GetString(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.String& outValue) { }
        private System.Boolean SetString(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.String setValue) { }
        private System.Boolean SetChoice(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32 setValue) { }
        private System.Boolean GetChoice(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32& outValue) { }
        private System.Boolean SetInputNode(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, UnityEngine.GameObject obj, System.Int32 index) { }
        private System.Boolean GetInputNode(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32 index, UnityEngine.GameObject& obj) { }
        private System.Boolean GetColor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, UnityEngine.Color& getValue) { }
        private System.Boolean SetColor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, UnityEngine.Color setValue) { }
        private System.Int32 GetParameterIndexFromName(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName) { }
        private System.Int32 GetParameterIndexFromNameOrTag(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName) { }
        private System.Int32 FindTextureParamByNameOrTag(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName, System.String useTextureParmName) { }
        private System.Boolean GetParameterFloatValue(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName, System.Single defaultValue, System.Single& returnValue) { }
        private System.Boolean GetParameterColor3Value(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName, UnityEngine.Color defaultValue, UnityEngine.Color& outputColor) { }

    }

    // TypeToken: 0x20000C8
    public class HEU_PDGCookedDataEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C9
    public class HEU_PDGCookedEventData
    {
        // Fields
        public System.Boolean CookSuccess;        // 0x10
        public HoudiniEngineUnity.HEU_TOPNodeData TopNodeData;        // 0x18

        // Methods
        private System.Void .ctor(System.Boolean bSuccess, HoudiniEngineUnity.HEU_TOPNodeData bTopNodeData) { }

    }

    // TypeToken: 0x20000CA
    public class HEU_PDGAssetLink : MonoBehaviour, ISerializationCallbackReceiver
    {
        // Fields
        private HoudiniEngineUnity.HEU_PDGCookedDataEvent _cookedDataEvent;        // 0x18
        private System.String _assetPath;        // 0x20
        private UnityEngine.GameObject _assetGO;        // 0x28
        private System.String _assetName;        // 0x30
        private System.Int32 _assetID;        // 0x38
        private HoudiniEngineUnity.HEU_HoudiniAsset _heu;        // 0x40
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNetworkData> _topNetworks;        // 0x48
        private System.String[] _topNetworkNames;        // 0x50
        private System.Int32 _selectedTOPNetwork;        // 0x58
        private HoudiniEngineUnity.HEU_PDGAssetLink.LinkState _linkState;        // 0x5C
        private System.Boolean _autoCook;        // 0x60
        private System.Boolean _useHEngineData;        // 0x61
        public HoudiniEngineUnity.HEU_PDGAssetLink.UpdateUIDelegate _repaintUIDelegate;        // 0x68
        public HoudiniEngineUnity.HEU_WorkItemTally _workItemTally;        // 0x70
        private UnityEngine.GameObject _loadRootGameObject;        // 0x78
        private System.String _outputCachePathRoot;        // 0x80
        private System.Boolean _bUseTOPNodeFilter;        // 0x88
        private System.Boolean _bUseTOPOutputFilter;        // 0x89
        private System.String _topNodeFilter;        // 0x90
        private System.String _topOutputFilter;        // 0x98
        private System.Int32 _numLoadingResults;        // 0xA0
        private System.Int32 _numTotalResults;        // 0xA4

        // Methods
        private System.Boolean get_AutoCook() { }
        private System.Void set_AutoCook(System.Boolean value) { }
        private System.Boolean get_UseHEngineData() { }
        private System.Void set_UseHEngineData(System.Boolean value) { }
        private System.Boolean get_UseTOPNodeFilter() { }
        private System.Void set_UseTOPNodeFilter(System.Boolean value) { }
        private System.Boolean get_UseTOPOutputFilter() { }
        private System.Void set_UseTOPOutputFilter(System.Boolean value) { }
        private System.String get_TopNodeFilter() { }
        private System.Void set_TopNodeFilter(System.String value) { }
        private System.String get_TopOutputFilter() { }
        private System.Void set_TopOutputFilter(System.String value) { }
        private HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset() { }
        private System.String get_AssetPath() { }
        private UnityEngine.GameObject get_AssetGO() { }
        private System.String get_AssetName() { }
        private System.Int32 get_AssetID() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNetworkData> get_TopNetworks() { }
        private System.String[] get_TopNetworkNames() { }
        private System.Int32 get_SelectedTOPNetwork() { }
        private HoudiniEngineUnity.HEU_LinkStateWrapper get_PDGLinkState() { }
        private UnityEngine.GameObject get_LoadRootGameObject() { }
        private System.String get_OutputCachePathRoot() { }
        private HoudiniEngineUnity.HEU_PDGCookedDataEvent get_CookedDataEvent() { }
        private HoudiniEngineUnity.HEU_PDGAssetLink.LinkState get_AssetLinkStateInternal() { }
        private System.Void Setup(HoudiniEngineUnity.HEU_HoudiniAsset hdaAsset) { }
        private System.Void Reset() { }
        private System.Void Refresh() { }
        private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32,HoudiniEngineUnity.HEU_TOPNodeData>> GetNonHiddenTOPNodes(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork) { }
        private System.Void SelectTOPNetwork(System.Int32 newIndex) { }
        private System.Void SelectTOPNode(HoudiniEngineUnity.HEU_TOPNetworkData network, System.Int32 newIndex) { }
        private HoudiniEngineUnity.HEU_TOPNetworkData GetSelectedTOPNetwork() { }
        private HoudiniEngineUnity.HEU_TOPNodeData GetSelectedTOPNode() { }
        private HoudiniEngineUnity.HEU_TOPNetworkData GetTOPNetwork(System.Int32 index) { }
        private System.Void DirtyTOPNode(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        private System.Void CookTOPNode(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        private System.Void DirtyAll() { }
        private System.Void CookOutput() { }
        private System.Void PauseCook() { }
        private System.Void CancelCook() { }
        private HoudiniEngineUnity.HEU_SessionBase GetHAPISession() { }
        private HoudiniEngineUnity.HEU_TOPNodeData GetTOPNode(System.Int32 nodeID) { }
        private System.String GetTOPNodeStatus(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        private HoudiniEngineUnity.HEU_TOPNetworkData GetTOPNetworkByName(System.String name, System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNetworkData> topNetworks) { }
        private HoudiniEngineUnity.HEU_TOPNodeData GetTOPNodeByName(System.String name, System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNodeData> topNodes) { }
        private System.Void Awake() { }
        private System.Void OnBeforeSerialize() { }
        private System.Void OnAfterDeserialize() { }
        private System.Void HandleInitialLoad() { }
        private System.Void OnDestroy() { }
        private System.Void NotifyAssetCooked(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean bSuccess, System.Collections.Generic.List<UnityEngine.GameObject> generatedOutputs) { }
        private System.Void NotifyAssetCooked(HoudiniEngineUnity.HEU_CookedEventData cookedEventData) { }
        private System.Void NotifyAssetCooked(HoudiniEngineUnity.HEU_ReloadEventData reloadEventData) { }
        private System.Void PopulateFromHDA() { }
        private System.Boolean PopulateTOPNetworks() { }
        private System.Boolean PopulateTOPNodes(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_TOPNetworkData topNetwork, System.Int32[] topNodeIDs, System.Boolean useHEngineData) { }
        private System.Void ClearAllTOPData() { }
        private System.Void ClearTOPNetworkWorkItemResults(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork) { }
        private System.Void ClearTOPNodeWorkItemResults(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        private System.Void ClearWorkItemResultByID(HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 workItemID) { }
        private System.Void ClearWorkItemResult(HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HEU_TOPWorkResult result) { }
        private System.Void UpdateTOPNodeResultsVisibility(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        private HoudiniEngineUnity.HEU_TOPWorkResult GetWorkResultByID(HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 workItemID) { }
        private System.Void DestroyWorkItemResultData(HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HEU_TOPWorkResult result) { }
        private System.Void LoadResults(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HAPI_PDG_WorkItemInfo workItemInfo, HoudiniEngineUnity.HAPI_PDG_WorkItemOutputFile[] resultInfos, System.Int32 workItemID, System.Action<HoudiniEngineUnity.HEU_TOPNodeData,HoudiniEngineUnity.HEU_SyncedEventData> OnSynced) { }
        private UnityEngine.Transform GetLoadRootTransform() { }
        private System.Void RepaintUI() { }
        private System.Void UpdateWorkItemTally() { }
        private System.Void ResetTOPNetworkWorkItemTally(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork) { }
        private System.Void OnTOPNodeFilterChanged(System.String filter) { }
        private System.Void OnTOPOutputFilterChanged(System.String filter) { }
        private System.Void ParseHEngineData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 topNodeID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, HoudiniEngineUnity.TOPNodeTags& nodeTags) { }
        private System.Void SetupTopNetworkNames(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork) { }
        private System.Void OnSyncComplete(HoudiniEngineUnity.HEU_PDGCookedEventData Data) { }
        private HoudiniEngineUnity.HEU_LinkStateWrapper LinkState_InternalToWrapper(HoudiniEngineUnity.HEU_PDGAssetLink.LinkState linkState) { }
        private HoudiniEngineUnity.HEU_PDGAssetLink.LinkState LinkState_WrapperToInternal(HoudiniEngineUnity.HEU_LinkStateWrapper linkState) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CF
    public class TOPNodeTags
    {
        // Fields
        public System.Boolean _show;        // 0x10
        public System.Boolean _autoload;        // 0x11
        public System.Boolean _showHEngineData;        // 0x12
        public System.Boolean _autoloadHEngineData;        // 0x13

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D0
    public class HEU_TOPNetworkData
    {
        // Fields
        public System.Int32 _nodeID;        // 0x10
        public System.String _nodeName;        // 0x18
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNodeData> _topNodes;        // 0x20
        public System.String[] _topNodeNames;        // 0x28
        public System.Int32 _selectedTOPIndex;        // 0x30
        public System.String _parentName;        // 0x38
        public HoudiniEngineUnity.TOPNodeTags _tags;        // 0x40

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D1
    public class HEU_TOPNodeData
    {
        // Fields
        public System.Int32 _nodeID;        // 0x10
        public System.String _nodeName;        // 0x18
        public System.String _parentName;        // 0x20
        public UnityEngine.GameObject _workResultParentGO;        // 0x28
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPWorkResult> _workResults;        // 0x30
        public HoudiniEngineUnity.TOPNodeTags _tags;        // 0x38
        public System.Boolean _showResults;        // 0x40
        public HoudiniEngineUnity.HEU_TOPNodeData.PDGState _pdgState;        // 0x44
        public HoudiniEngineUnity.HEU_WorkItemTally _workItemTally;        // 0x48

        // Methods
        private System.Void Reset() { }
        private System.Boolean AreAllWorkItemsComplete() { }
        private System.Boolean AnyWorkItemsFailed() { }
        private System.Boolean AnyWorkItemsPending() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D3
    public class HEU_TOPWorkResult
    {
        // Fields
        public System.Int32 _workItemIndex;        // 0x10
        public System.Int32 _workItemID;        // 0x14
        public System.Collections.Generic.List<UnityEngine.GameObject> _generatedGOs;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D4
    public class HEU_WorkItemTally
    {
        // Fields
        public System.Int32 _totalWorkItems;        // 0x10
        public System.Int32 _waitingWorkItems;        // 0x14
        public System.Int32 _scheduledWorkItems;        // 0x18
        public System.Int32 _cookingWorkItems;        // 0x1C
        public System.Int32 _cookedWorkItems;        // 0x20
        public System.Int32 _erroredWorkItems;        // 0x24

        // Methods
        private System.Void ZeroAll() { }
        private System.Boolean AreAllWorkItemsComplete() { }
        private System.Boolean AnyWorkItemsFailed() { }
        private System.Boolean AnyWorkItemsPending() { }
        private System.String ProgressRatio() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D5
    public class HEU_PDGSession
    {
        // Fields
        private static HoudiniEngineUnity.HEU_PDGSession _pdgSession;        // 0x0
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_PDGAssetLink> _pdgAssets;        // 0x10
        public System.Int32 _pdgMaxProcessEvents;        // 0x18
        public HoudiniEngineUnity.HAPI_PDG_EventInfo[] _pdgQueryEvents;        // 0x20
        public System.Int32[] _pdgContextIDs;        // 0x28
        public System.Boolean _errored;        // 0x30
        public System.String _errorMsg;        // 0x38
        public HoudiniEngineUnity.HAPI_PDG_State _pdgState;        // 0x40
        private System.Action<HoudiniEngineUnity.HEU_PDGCookedEventData> _cookedDataEvent;        // 0x48
        private System.Boolean _pendingCallback;        // 0x50
        private System.Int32 _numItemsCompleted;        // 0x54
        private System.Int32 _totalNumItems;        // 0x58
        private System.Boolean _callbackSuccess;        // 0x5C
        private System.Text.StringBuilder _pdgEventMessages;        // 0x60
        private System.String[] _eventMessageColorCode;        // 0x68

        // Methods
        private HoudiniEngineUnity.HEU_PDGSession GetPDGSession() { }
        private System.Void .ctor() { }
        private System.Void AddAsset(HoudiniEngineUnity.HEU_PDGAssetLink asset) { }
        private System.Void RemoveAsset(HoudiniEngineUnity.HEU_PDGAssetLink asset) { }
        private System.Void Update() { }
        private System.Void CleanUp() { }
        private System.Void UpdatePDGContext() { }
        private System.Void ReinitializePDGContext() { }
        private System.Void ProcessPDGEvent(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 contextID, HoudiniEngineUnity.HAPI_PDG_EventInfo& eventInfo) { }
        private System.Void OnWorkItemLoadResults(HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HEU_SyncedEventData OnSynced) { }
        private System.Void CheckCallback(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        private System.Boolean GetTOPAssetLinkAndNode(System.Int32 nodeID, HoudiniEngineUnity.HEU_PDGAssetLink& assetLink, HoudiniEngineUnity.HEU_TOPNodeData& topNode) { }
        private System.Void SetTOPNodePDGState(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HEU_TOPNodeData.PDGState pdgState) { }
        private System.Void NotifyTOPNodePDGStateClear(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        private System.Void NotifyTOPNodeTotalWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 inc) { }
        private System.Void NotifyTOPNodeCookedWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        private System.Void NotifyTOPNodeErrorWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        private System.Void NotifyTOPNodeWaitingWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 inc) { }
        private System.Void NotifyTOPNodeScheduledWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 inc) { }
        private System.Void NotifyTOPNodeCookingWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 inc) { }
        private System.Void ResetPDGEventInfo(HoudiniEngineUnity.HAPI_PDG_EventInfo& eventInfo) { }
        private System.Void SetErrorState(System.String msg, System.Boolean bLogIt) { }
        private System.Void ClearErrorState() { }
        private HoudiniEngineUnity.HEU_SessionBase GetHAPIPDGSession(System.Boolean bCreate) { }
        private System.Void CookTOPNetworkOutputNode(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork, System.Action<HoudiniEngineUnity.HEU_PDGCookedEventData> OnCook) { }
        private System.Void PauseCook(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork) { }
        private System.Void CancelCook(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork) { }
        private System.Void ClearWorkItemResult(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 contextID, HoudiniEngineUnity.HAPI_PDG_EventInfo eventInfo, HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        private System.Boolean DirtyTOPNode(System.Int32 nodeID) { }
        private System.Boolean CookTOPNode(System.Int32 nodeID) { }
        private System.Boolean DirtyAll(System.Int32 nodeID) { }
        private System.Void AddEventMessage(System.String msg) { }
        private System.String GetEventMessages() { }
        private System.Void ClearEventMessages() { }
        private System.Int32[] GetNonBypassedNetworkIds(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetId) { }
        private System.Boolean IsPDGAsset(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetId) { }
        private System.Void ResetCallbackVariables() { }
        private System.Action<HoudiniEngineUnity.HEU_PDGCookedEventData> get_CookedDataEvent() { }
        private System.Void set_CookedDataEvent(System.Action<HoudiniEngineUnity.HEU_PDGCookedEventData> value) { }

    }

    // TypeToken: 0x20000D9
    public interface IHEU_Curve
    {
        // Methods
        private UnityEngine.GameObject get_TargetGameObject() { }
        private System.Void set_TargetGameObject(UnityEngine.GameObject value) { }
        private System.Int32 get_GeoID() { }
        private System.Int32 get_PartID() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> get_CurveNodeData() { }
        private HoudiniEngineUnity.HEU_Parameters get_Parameters() { }
        private System.String get_CurveName() { }
        private System.Boolean get_IsInputCurve() { }
        private System.Boolean get_IsPartCurve() { }
        private HoudiniEngineUnity.HEU_InputCurveInfo get_InputCurveInfo() { }
        private System.Boolean IsEditable() { }
        private System.Boolean IsGeoCurve() { }
        private System.Void SetCurveName(System.String name) { }
        private System.Void SetCurvePoint(System.Int32 pointIndex, UnityEngine.Vector3 newPosition, System.Boolean bRecookAsset) { }
        private System.Void SetCurvePoint(System.Int32 pointIndex, HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset) { }
        private System.Void SetCurveNodeData(System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> curveNodeData, System.Boolean bRecookAsset) { }
        private UnityEngine.Vector3 GetCurvePoint(System.Int32 pointIndex) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> GetAllPointTransforms() { }
        private System.Collections.Generic.List<UnityEngine.Vector3> GetAllPoints() { }
        private System.Int32 GetNumPoints() { }
        private System.Void InsertCurvePoint(System.Int32 index, UnityEngine.Vector3 position, System.Boolean bRecookAsset) { }
        private System.Void InsertCurvePoint(System.Int32 index, HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset) { }
        private System.Void AddCurvePointToEnd(UnityEngine.Vector3 position, System.Boolean bRecookAsset) { }
        private System.Void AddCurvePointToEnd(HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset) { }
        private System.Void RemoveCurvePoint(System.Int32 pointIndex, System.Boolean bRecookAsset) { }
        private System.Void ClearCurveNodeData(System.Boolean bRecookAsset) { }
        private System.Void ProjectToColliders(UnityEngine.Vector3 rayDirection, System.Single rayDistance, System.Boolean bRecookAsset) { }
        private System.Void SetCurveGeometryVisibility(System.Boolean bVisible, System.Boolean bRecookAsset) { }
        private UnityEngine.Vector3 GetTransformedPoint(System.Int32 pointIndex) { }
        private System.Collections.Generic.List<UnityEngine.Vector3> GetTransformedPoints() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> DuplicateCurveNodeData() { }

    }

    // TypeToken: 0x20000DA
    public interface IHEU_GeoNode
    {
        // Methods
        private System.Int32 get_GeoID() { }
        private HoudiniEngineUnity.HAPI_GeoInfo get_GeoInfo() { }
        private System.String get_GeoName() { }
        private HoudiniEngineUnity.HAPI_GeoType get_GeoType() { }
        private System.Boolean get_Editable() { }
        private System.Boolean get_Displayable() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> get_Parts() { }
        private HoudiniEngineUnity.HEU_ObjectNode get_ObjectNode() { }
        private HoudiniEngineUnity.HEU_InputNode get_InputNode() { }
        private HoudiniEngineUnity.HEU_Curve get_GeoCurve() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> get_VolumeCaches() { }
        private System.Boolean IsVisible() { }
        private System.Boolean IsIntermediate() { }
        private System.Boolean IsIntermediateOrEditable() { }
        private System.Boolean IsGeoInputType() { }
        private System.Boolean IsGeoCurveType() { }
        private System.Void DestroyAllData(System.Boolean bIsRebuild) { }
        private System.Void RemoveAndDestroyPart(HoudiniEngineUnity.HEU_PartData part) { }
        private System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        private System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs) { }
        private HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject outputGameObject) { }
        private HoudiniEngineUnity.HEU_PartData GetPartFromPartID(System.Int32 partID) { }
        private System.Void GetCurves(System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> curves, System.Boolean bEditableOnly) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> GetParts() { }
        private System.Void HideAllGeometry() { }
        private System.Void DisableAllColliders() { }
        private HoudiniEngineUnity.HEU_VolumeCache GetVolumeCacheByTileIndex(System.Int32 tileIndex) { }

    }

    // TypeToken: 0x20000DB
    public struct HEU_AssetCookStatusWrapper
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_AssetCookStatusWrapper NONE;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetCookStatusWrapper COOKING;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetCookStatusWrapper POSTCOOK;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetCookStatusWrapper LOADING;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetCookStatusWrapper POSTLOAD;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetCookStatusWrapper PRELOAD;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetCookStatusWrapper SELECT_SUBASSET;        // 0x0

    }

    // TypeToken: 0x20000DC
    public struct HEU_AssetCookResultWrapper
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_AssetCookResultWrapper NONE;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetCookResultWrapper SUCCESS;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetCookResultWrapper ERRORED;        // 0x0

    }

    // TypeToken: 0x20000DD
    public struct HEU_CurveDrawCollisionWrapper
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper INVALID;        // 0x0
        public static HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper COLLIDERS;        // 0x0
        public static HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper LAYERMASK;        // 0x0

    }

    // TypeToken: 0x20000DE
    public struct HEU_AssetTypeWrapper
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_AssetTypeWrapper TYPE_INVALID;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetTypeWrapper TYPE_HDA;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetTypeWrapper TYPE_CURVE;        // 0x0
        public static HoudiniEngineUnity.HEU_AssetTypeWrapper TYPE_INPUT;        // 0x0

    }

    // TypeToken: 0x20000DF
    public interface IHEU_HoudiniAsset
    {
        // Methods
        private System.Boolean get_LoadAssetFromMemory() { }
        private System.Void set_LoadAssetFromMemory(System.Boolean value) { }
        private System.Boolean get_AlwaysOverwriteOnLoad() { }
        private System.Void set_AlwaysOverwriteOnLoad(System.Boolean value) { }
        private System.Boolean get_GenerateUVs() { }
        private System.Void set_GenerateUVs(System.Boolean value) { }
        private System.Boolean get_GenerateTangents() { }
        private System.Void set_GenerateTangents(System.Boolean value) { }
        private System.Boolean get_GenerateNormals() { }
        private System.Void set_GenerateNormals(System.Boolean value) { }
        private System.Boolean get_PushTransformToHoudini() { }
        private System.Void set_PushTransformToHoudini(System.Boolean value) { }
        private System.Boolean get_TransformChangeTriggersCooks() { }
        private System.Void set_TransformChangeTriggersCooks(System.Boolean value) { }
        private System.Boolean get_CookingTriggersDownCooks() { }
        private System.Void set_CookingTriggersDownCooks(System.Boolean value) { }
        private System.Boolean get_AutoCookOnParameterChange() { }
        private System.Void set_AutoCookOnParameterChange(System.Boolean value) { }
        private System.Boolean get_IgnoreNonDisplayNodes() { }
        private System.Void set_IgnoreNonDisplayNodes(System.Boolean value) { }
        private System.Boolean get_UseOutputNodes() { }
        private System.Void set_UseOutputNodes(System.Boolean value) { }
        private System.Boolean get_GenerateMeshUsingPoints() { }
        private System.Void set_GenerateMeshUsingPoints(System.Boolean value) { }
        private System.Boolean get_UseLODGroups() { }
        private System.Void set_UseLODGroups(System.Boolean value) { }
        private System.Boolean get_SplitGeosByGroup() { }
        private System.Void set_SplitGeosByGroup(System.Boolean value) { }
        private System.Boolean get_SessionSyncAutoCook() { }
        private System.Void set_SessionSyncAutoCook(System.Boolean value) { }
        private System.Boolean get_BakeUpdateKeepPreviousTransformValues() { }
        private System.Void set_BakeUpdateKeepPreviousTransformValues(System.Boolean value) { }
        private System.Boolean get_PauseCooking() { }
        private System.Void set_PauseCooking(System.Boolean value) { }
        private System.Boolean get_CurveEditorEnabled() { }
        private System.Void set_CurveEditorEnabled(System.Boolean value) { }
        private HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper get_CurveDrawCollision() { }
        private System.Void set_CurveDrawCollision(HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper value) { }
        private UnityEngine.LayerMask get_CurveDrawLayerMask() { }
        private System.Void set_CurveDrawLayerMask(UnityEngine.LayerMask value) { }
        private System.Single get_CurveProjectMaxDistance() { }
        private System.Void set_CurveProjectMaxDistance(System.Single value) { }
        private UnityEngine.Vector3 get_CurveProjectDirection() { }
        private System.Void set_CurveProjectDirection(UnityEngine.Vector3 value) { }
        private System.Boolean get_CurveProjectDirectionToView() { }
        private System.Void set_CurveProjectDirectionToView(System.Boolean value) { }
        private System.Boolean get_CurveDisableScaleRotation() { }
        private System.Void set_CurveDisableScaleRotation(System.Boolean value) { }
        private System.Boolean get_CurveFrameSelectedNodes() { }
        private System.Void set_CurveFrameSelectedNodes(System.Boolean value) { }
        private System.Single get_CurveFrameSelectedNodeDistance() { }
        private System.Void set_CurveFrameSelectedNodeDistance(System.Single value) { }
        private System.Boolean get_HandlesEnabled() { }
        private System.Void set_HandlesEnabled(System.Boolean value) { }
        private System.Boolean get_EditableNodesToolsEnabled() { }
        private System.Void set_EditableNodesToolsEnabled(System.Boolean value) { }
        private HoudiniEngineUnity.HEU_AssetTypeWrapper get_AssetType() { }
        private HoudiniEngineUnity.HAPI_AssetInfo get_AssetInfo() { }
        private HoudiniEngineUnity.HAPI_NodeInfo get_NodeInfo() { }
        private System.String get_AssetName() { }
        private System.String get_AssetOpName() { }
        private System.String get_AssetHelp() { }
        private System.Int32 get_AssetID() { }
        private System.String get_AssetPath() { }
        private UnityEngine.GameObject get_OwnerGameObject() { }
        private UnityEngine.GameObject get_RootGameObject() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> get_MaterialCache() { }
        private HoudiniEngineUnity.HEU_Parameters get_Parameters() { }
        private System.String get_AssetCacheFolder() { }
        private System.String[] get_SubassetNames() { }
        private System.Int32 get_SelectedSubassetIndex() { }
        private HoudiniEngineUnity.HEU_AssetCookStatusWrapper get_CookStatus() { }
        private HoudiniEngineUnity.HEU_AssetCookResultWrapper get_LastCookResult() { }
        private System.Int64 get_SessionID() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> get_Curves() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> get_InputNodes() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> get_VolumeCaches() { }
        private HoudiniEngineUnity.HEU_ReloadDataEvent get_ReloadDataEvent() { }
        private HoudiniEngineUnity.HEU_CookedDataEvent get_CookedDataEvent() { }
        private HoudiniEngineUnity.HEU_BakedDataEvent get_BakedDataEvent() { }
        private HoudiniEngineUnity.HEU_PreAssetEvent get_PreAssetEvent() { }
        private System.Boolean RequestCook(System.Boolean bCheckParametersChanged, System.Boolean bAsync, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters) { }
        private System.Boolean RequestReload(System.Boolean bAsync) { }
        private System.Boolean RequestResetParameters(System.Boolean bAsync) { }
        private UnityEngine.GameObject DuplicateAsset(UnityEngine.GameObject newRootGameObject) { }
        private System.Boolean DeleteAllGeneratedData(System.Boolean bIsRebuild) { }
        private UnityEngine.GameObject BakeToNewPrefab(System.String destinationPrefabPath) { }
        private UnityEngine.GameObject BakeToNewStandalone() { }
        private System.Boolean BakeToExistingPrefab(UnityEngine.GameObject bakeTargetGO) { }
        private System.Boolean BakeToExistingStandalone(UnityEngine.GameObject bakeTargetGO) { }
        private System.Boolean IsAssetValid() { }
        private System.Boolean GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        private System.Boolean GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs) { }
        private HoudiniEngineUnity.HEU_Curve GetCurve(System.String curveName) { }
        private System.Boolean AddCurveDrawCollider(UnityEngine.Collider newCollider) { }
        private System.Boolean RemoveCurveDrawCollider(UnityEngine.Collider collider) { }
        private System.Boolean ClearCurveDrawColliders() { }
        private HoudiniEngineUnity.HEU_InputNode GetInputNode(System.String inputName) { }
        private HoudiniEngineUnity.HEU_InputNode GetAssetInputNode(System.String inputName) { }
        private HoudiniEngineUnity.HEU_InputNode GetInputNodeByIndex(System.Int32 index) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> GetNonParameterInputNodes() { }
        private System.Int32 GetVolumeCacheCount() { }
        private HoudiniEngineUnity.HEU_SessionBase GetAssetSession(System.Boolean bCreateIfInvalid) { }
        private HoudiniEngineUnity.HEU_ObjectNode GetObjectNodeByName(System.String objName) { }
        private System.Void GetOutputGeoNodes(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> outputGeoNodes) { }
        private HoudiniEngineUnity.HEU_PartData GetInternalHDAPartWithGameObject(UnityEngine.GameObject outputGameObject) { }
        private System.Void ResetParametersToDefault() { }
        private System.Void HideAllGeometry() { }
        private System.Void DisableAllColliders() { }
        private HoudiniEngineUnity.HEU_MaterialData GetMaterialData(UnityEngine.Material material) { }
        private System.Void ClearMaterialCache() { }
        private System.Void RemoveMaterial(UnityEngine.Material material) { }
        private System.Void ResetMaterialOverrides() { }
        private HoudiniEngineUnity.HEU_AssetPreset GetAssetPreset() { }
        private HoudiniEngineUnity.HEU_PDGAssetLink GetOrCreatePDGAssetLink() { }

    }

    // TypeToken: 0x20000E0
    public interface IHEU_HoudiniAssetSubcomponent
    {
        // Methods
        private HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset() { }
        private HoudiniEngineUnity.HEU_SessionBase GetSession() { }
        private System.Void Recook() { }

    }

    // TypeToken: 0x20000E1
    public struct HEU_InputNodeTypeWrapper
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_InputNodeTypeWrapper CONNECTION;        // 0x0
        public static HoudiniEngineUnity.HEU_InputNodeTypeWrapper NODE;        // 0x0
        public static HoudiniEngineUnity.HEU_InputNodeTypeWrapper PARAMETER;        // 0x0

    }

    // TypeToken: 0x20000E2
    public struct HEU_InputObjectTypeWrapper
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_InputObjectTypeWrapper HDA;        // 0x0
        public static HoudiniEngineUnity.HEU_InputObjectTypeWrapper UNITY_MESH;        // 0x0
        public static HoudiniEngineUnity.HEU_InputObjectTypeWrapper CURVE;        // 0x0
        public static HoudiniEngineUnity.HEU_InputObjectTypeWrapper TERRAIN;        // 0x0
        public static HoudiniEngineUnity.HEU_InputObjectTypeWrapper BOUNDING_BOX;        // 0x0
        public static HoudiniEngineUnity.HEU_InputObjectTypeWrapper TILEMAP;        // 0x0

    }

    // TypeToken: 0x20000E3
    public interface IHEU_InputNode
    {
        // Methods
        private System.Boolean get_KeepWorldTransform() { }
        private System.Void set_KeepWorldTransform(System.Boolean value) { }
        private System.Boolean get_PackGeometryBeforeMerging() { }
        private System.Void set_PackGeometryBeforeMerging(System.Boolean value) { }
        private HoudiniEngineUnity.HEU_InputNodeTypeWrapper get_NodeType() { }
        private HoudiniEngineUnity.HEU_InputObjectTypeWrapper get_ObjectType() { }
        private HoudiniEngineUnity.HEU_InputObjectTypeWrapper get_PendingObjectType() { }
        private System.Int32 get_InputNodeID() { }
        private System.String get_InputName() { }
        private System.String get_LabelName() { }
        private System.String get_ParamName() { }
        private HoudiniEngineUnity.HEU_InputInterfaceMeshSettings get_MeshSettings() { }
        private HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings get_TilemapSettings() { }
        private System.Boolean IsAssetInput() { }
        private System.Int32 NumInputEntries() { }
        private UnityEngine.GameObject GetInputEntryGameObject(System.Int32 index) { }
        private UnityEngine.GameObject[] GetInputEntryGameObjects() { }
        private System.Void SetInputEntry(System.Int32 index, UnityEngine.GameObject newInputGameObject, System.Boolean bRecookAsset) { }
        private System.Void InsertInputEntry(System.Int32 index, UnityEngine.GameObject newInputGameObject, System.Boolean bRecookAsset) { }
        private System.Void AddInputEntryAtEnd(UnityEngine.GameObject newEntryGameObject, System.Boolean bRecookAsset) { }
        private System.Void ResetInputNode(System.Boolean bRecookAsset) { }
        private System.Void ChangeInputType(HoudiniEngineUnity.HEU_InputObjectTypeWrapper newType, System.Boolean bRecookAsset) { }
        private System.Void RemoveInputEntry(System.Int32 index, System.Boolean bRecookAsset) { }
        private System.Void RemoveAllInputEntries(System.Boolean bRecookAsset) { }
        private System.Void SetInputEntryObjectUseTransformOffset(System.Int32 index, System.Boolean value, System.Boolean bRecookAsset) { }
        private System.Void SetInputEntryObjectTransformTranslateOffset(System.Int32 index, UnityEngine.Vector3 translateOffset, System.Boolean bRecookAsset) { }
        private System.Void SetInputEntryObjectTransformRotateOffset(System.Int32 index, UnityEngine.Vector3 rotateOffset, System.Boolean bRecookAsset) { }
        private System.Void SetInputEntryObjectTransformScaleOffset(System.Int32 index, UnityEngine.Vector3 scaleOffset, System.Boolean bRecookAsset) { }
        private System.Boolean AreAnyInputHDAsConnected() { }
        private System.Int32 GetConnectedInputCount() { }
        private System.Int32 GetConnectedNodeID(System.Int32 index) { }
        private System.Void LoadPreset(HoudiniEngineUnity.HEU_InputPreset inputPreset) { }
        private System.Void PopulateInputPreset(HoudiniEngineUnity.HEU_InputPreset inputPreset) { }

    }

    // TypeToken: 0x20000E4
    public struct HEU_MaterialSourceWrapper
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_MaterialSourceWrapper DEFAULT;        // 0x0
        public static HoudiniEngineUnity.HEU_MaterialSourceWrapper HOUDINI;        // 0x0
        public static HoudiniEngineUnity.HEU_MaterialSourceWrapper UNITY;        // 0x0
        public static HoudiniEngineUnity.HEU_MaterialSourceWrapper SUBSTANCE;        // 0x0

    }

    // TypeToken: 0x20000E5
    public interface IHEU_MaterialData
    {
        // Methods
        private UnityEngine.Material get_Material() { }
        private HoudiniEngineUnity.HEU_MaterialSourceWrapper get_MaterialSource() { }
        private System.Int32 get_MaterialKey() { }
        private System.Void set_MaterialKey(System.Int32 value) { }
        private System.Boolean UpdateMaterialFromHoudini(HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String assetCacheFolderPath) { }
        private System.Boolean IsExistingMaterial() { }

    }

    // TypeToken: 0x20000E6
    public interface IHEU_ObjectNode
    {
        // Methods
        private System.Int32 get_ObjectID() { }
        private System.String get_ObjectName() { }
        private HoudiniEngineUnity.HAPI_ObjectInfo get_ObjectInfo() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> get_GeoNodes() { }
        private HoudiniEngineUnity.HAPI_Transform get_ObjectTransform() { }
        private System.Boolean IsInstanced() { }
        private System.Boolean IsVisible() { }
        private System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData) { }
        private System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        private System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs) { }
        private HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject outputGameObject) { }
        private HoudiniEngineUnity.HEU_GeoNode GetGeoNode(System.String geoName) { }
        private System.Void GetCurves(System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> curves, System.Boolean bEditableOnly) { }
        private System.Void GetOutputGeoNodes(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> outGeoNodes) { }
        private System.Void HideAllGeometry() { }
        private System.Void DisableAllColliders() { }
        private System.Boolean IsInstancer() { }

    }

    // TypeToken: 0x20000E7
    public struct HEU_HoudiniRampInterpolationTypeWrapper
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper CONSTANT;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper LINEAR;        // 0x0
        public static HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper CATMULL_ROM;        // 0x0

    }

    // TypeToken: 0x20000E8
    public class HEU_RampPointWrapper
    {
        // Fields
        private System.Single <Position>k__BackingField;        // 0x10
        private HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper <Interpolation>k__BackingField;        // 0x14

        // Methods
        private System.Single get_Position() { }
        private System.Void set_Position(System.Single value) { }
        private HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper get_Interpolation() { }
        private System.Void set_Interpolation(HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper value) { }
        private System.Void .ctor(System.Single position, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolation) { }

    }

    // TypeToken: 0x20000E9
    public class HEU_FloatRampPointWrapper : HEU_RampPointWrapper
    {
        // Fields
        private System.Single <Value>k__BackingField;        // 0x18

        // Methods
        private System.Single get_Value() { }
        private System.Void set_Value(System.Single value) { }
        private System.Void .ctor(System.Single position, System.Single value, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolation) { }

    }

    // TypeToken: 0x20000EA
    public class HEU_ColorRampPointWrapper : HEU_RampPointWrapper
    {
        // Fields
        private UnityEngine.Color <Value>k__BackingField;        // 0x18

        // Methods
        private UnityEngine.Color get_Value() { }
        private System.Void set_Value(UnityEngine.Color value) { }
        private System.Void .ctor(System.Single position, UnityEngine.Color value, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolation) { }

    }

    // TypeToken: 0x20000EB
    public class HEU_ParameterTupleWrapper
    {
        // Fields
        private System.Boolean[] _boolValues;        // 0x10
        private System.Int32[] _intValues;        // 0x18
        private System.Single[] _floatValues;        // 0x20
        private System.String[] _stringValues;        // 0x28
        private HoudiniEngineUnity.HEU_FloatRampPointWrapper[] _floatRampValues;        // 0x30
        private HoudiniEngineUnity.HEU_ColorRampPointWrapper[] _colorRampValues;        // 0x38

        // Methods
        private System.Boolean[] get_BoolValues() { }
        private System.Void set_BoolValues(System.Boolean[] value) { }
        private System.Int32[] get_IntValues() { }
        private System.Void set_IntValues(System.Int32[] value) { }
        private System.Single[] get_FloatValues() { }
        private System.Void set_FloatValues(System.Single[] value) { }
        private System.String[] get_StringValues() { }
        private System.Void set_StringValues(System.String[] value) { }
        private HoudiniEngineUnity.HEU_FloatRampPointWrapper[] get_FloatRampValues() { }
        private System.Void set_FloatRampValues(HoudiniEngineUnity.HEU_FloatRampPointWrapper[] value) { }
        private HoudiniEngineUnity.HEU_ColorRampPointWrapper[] get_ColorRampValues() { }
        private System.Void set_ColorRampValues(HoudiniEngineUnity.HEU_ColorRampPointWrapper[] value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Boolean[] boolValues) { }
        private System.Void .ctor(System.Int32[] intValues) { }
        private System.Void .ctor(System.Single[] floatValues) { }
        private System.Void .ctor(System.String[] stringValues) { }
        private System.Void .ctor(HoudiniEngineUnity.HEU_FloatRampPointWrapper[] floatRampValues) { }
        private System.Void .ctor(HoudiniEngineUnity.HEU_ColorRampPointWrapper[] colorRampValues) { }

    }

    // TypeToken: 0x20000EC
    public interface IHEU_Parameters
    {
        // Methods
        private System.Boolean get_ShowParameters() { }
        private System.Void set_ShowParameters(System.Boolean value) { }
        private System.Int32 get_NodeID() { }
        private System.Collections.Generic.List<System.Int32> get_RootParameters() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterModifier> get_ParameterModifiers() { }
        private System.Boolean AreParametersValid() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterData> GetParameters() { }
        private HoudiniEngineUnity.HEU_ParameterData GetParameter(System.Int32 listIndex) { }
        private HoudiniEngineUnity.HEU_ParameterData GetParameter(System.String name) { }
        private HoudiniEngineUnity.HEU_ParameterData GetParameterWithParmID(System.Int32 parmID) { }
        private System.Void RemoveParameter(System.Int32 listIndex) { }
        private System.Boolean HaveParametersChanged() { }
        private System.Boolean ResetAllToDefault(System.Boolean bRecookAsset) { }
        private System.Boolean SetFloatParameterValue(System.String parameterName, System.Single value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        private System.Boolean GetFloatParameterValue(System.String parameterName, System.Single& value, System.Int32 atIndex) { }
        private System.Boolean SetFloatParameterValues(System.String parameterName, System.Single[] values, System.Boolean bRecookAsset) { }
        private System.Boolean GetFloatParameterValues(System.String parameterName, System.Single[]& values) { }
        private System.Boolean SetColorParameterValue(System.String parameterName, UnityEngine.Color value, System.Boolean bRecookAsset) { }
        private System.Boolean GetColorParameterValue(System.String parameterName, UnityEngine.Color& value) { }
        private System.Boolean SetIntParameterValue(System.String parameterName, System.Int32 value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        private System.Boolean GetIntParameterValue(System.String parameterName, System.Int32& value, System.Int32 atIndex) { }
        private System.Boolean SetIntParameterValues(System.String parameterName, System.Int32[] values, System.Boolean bRecookAsset) { }
        private System.Boolean GetIntParameterValues(System.String parameterName, System.Int32[]& values) { }
        private System.Boolean SetChoiceParameterValue(System.String parameterName, System.Int32 value, System.Boolean bRecookAsset) { }
        private System.Boolean GetChoiceParameterValue(System.String parameterName, System.Int32& value) { }
        private System.Boolean SetBoolParameterValue(System.String parameterName, System.Boolean value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        private System.Boolean GetBoolParameterValue(System.String parameterName, System.Boolean& value, System.Int32 atIndex) { }
        private System.Boolean SetStringParameterValue(System.String parameterName, System.String value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        private System.Boolean GetStringParameterValue(System.String parameterName, System.String& value, System.Int32 atIndex) { }
        private System.Boolean SetStringParameterValues(System.String parameterName, System.String[] values, System.Boolean bRecookAsset) { }
        private System.Boolean GetStringParameterValues(System.String parameterName, System.String[]& values) { }
        private System.Boolean SetAssetRefParameterValue(System.String parameterName, UnityEngine.GameObject value, System.Int32 atIndex, System.Boolean bRecookAsset) { }
        private System.Boolean GetAssetRefParameterValue(System.String parameterName, UnityEngine.GameObject& value, System.Int32 atIndex) { }
        private System.Boolean SetAssetRefParameterValues(System.String parameterName, UnityEngine.GameObject[] values, System.Boolean bRecookAsset) { }
        private System.Boolean GetAssetRefParameterValues(System.String parameterName, UnityEngine.GameObject[]& values) { }
        private System.Boolean SetRampParameterNumPoints(System.String parameterName, System.Int32 numPoints, System.Boolean bRecookAsset) { }
        private System.Boolean GetRampParameterNumPoints(System.String parameterName, System.Int32& numPoints) { }
        private System.Boolean SetFloatRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single pointPosition, System.Single pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolationType, System.Boolean bRecookAsset) { }
        private System.Boolean GetFloatRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single& pointPosition, System.Single& pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper& interpolationType) { }
        private System.Boolean SetFloatRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_FloatRampPointWrapper[] rampPoints, System.Boolean bRecookAsset) { }
        private System.Boolean GetFloatRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_FloatRampPointWrapper[]& rampPoints) { }
        private System.Boolean SetColorRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single pointPosition, UnityEngine.Color pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolation, System.Boolean bRecookAsset) { }
        private System.Boolean GetColorRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single& pointPosition, UnityEngine.Color& pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper& interpolationType) { }
        private System.Boolean SetColorRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_ColorRampPointWrapper[] rampPoints, System.Boolean bRecookAsset) { }
        private System.Boolean GetColorRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_ColorRampPointWrapper[]& rampPoints) { }
        private System.Boolean TriggerButtonParameter(System.String parameterName) { }
        private System.Boolean SetParameterTuples(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterTupleWrapper> parameterTuples, System.Boolean bRecookAsset) { }
        private System.Boolean GetParameterTuples(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterTupleWrapper>& parameterTuples) { }

    }

    // TypeToken: 0x20000ED
    public interface IHEU_PartData
    {
        // Methods
        private System.Int32 get_PartID() { }
        private System.String get_PartName() { }
        private System.Int32 get_GeoID() { }
        private HoudiniEngineUnity.HAPI_PartType get_PartType() { }
        private HoudiniEngineUnity.HEU_GeoNode get_ParentGeoNode() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> get_ObjectInstanceInfos() { }
        private HoudiniEngineUnity.HEU_Curve get_Curve() { }
        private System.Int32 get_MeshVertexCount() { }
        private HoudiniEngineUnity.HEU_GeneratedOutput get_GeneratedOutput() { }
        private UnityEngine.GameObject get_OutputGameObject() { }
        private System.Boolean IsPartInstancer() { }
        private System.Boolean IsAttribInstancer() { }
        private System.Boolean IsInstancerAnyType() { }
        private System.Boolean IsPartInstanced() { }
        private System.Int32 GetPartPointCount() { }
        private System.Boolean IsObjectInstancer() { }
        private System.Boolean IsPartVolume() { }
        private System.Boolean IsPartCurve() { }
        private System.Boolean IsPartMesh() { }
        private System.Boolean IsPartEditable() { }
        private System.Boolean HaveInstancesBeenGenerated() { }
        private System.Void SetGameObjectName(System.String partName) { }
        private System.Void SetGameObject(UnityEngine.GameObject gameObject) { }
        private System.Void SetVolumeLayerName(System.String name) { }
        private System.String GetVolumeLayerName() { }
        private System.Void DestroyAllData(System.Boolean bIsRebuild) { }
        private System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData) { }
        private System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects) { }
        private System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs) { }
        private HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject inGameObject) { }
        private System.Void ClearInstances() { }
        private HoudiniEngineUnity.HEU_Curve GetCurve(System.Boolean bEditableOnly) { }
        private System.Void SetVisiblity(System.Boolean bVisibility) { }
        private System.Void SetColliderState(System.Boolean bEnabled) { }
        private HoudiniEngineUnity.HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectPath(System.String path) { }
        private HoudiniEngineUnity.HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectID(System.Int32 objNodeID) { }
        private System.Void SetTerrainOffsetPosition(UnityEngine.Vector3 offsetPosition) { }
        private System.Void SetTerrainData(UnityEngine.TerrainData terrainData, System.String exportPathRelative, System.String exportPathUser) { }

    }

    // TypeToken: 0x20000EE
    public struct HEU_LinkStateWrapper
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_LinkStateWrapper INACTIVE;        // 0x0
        public static HoudiniEngineUnity.HEU_LinkStateWrapper LINKING;        // 0x0
        public static HoudiniEngineUnity.HEU_LinkStateWrapper LINKED;        // 0x0
        public static HoudiniEngineUnity.HEU_LinkStateWrapper ERROR_NOT_LINKED;        // 0x0

    }

    // TypeToken: 0x20000EF
    public interface IHEU_PDGAssetLink
    {
        // Methods
        private System.Boolean get_AutoCook() { }
        private System.Void set_AutoCook(System.Boolean value) { }
        private System.Boolean get_UseHEngineData() { }
        private System.Void set_UseHEngineData(System.Boolean value) { }
        private System.Boolean get_UseTOPNodeFilter() { }
        private System.Void set_UseTOPNodeFilter(System.Boolean value) { }
        private System.Boolean get_UseTOPOutputFilter() { }
        private System.Void set_UseTOPOutputFilter(System.Boolean value) { }
        private System.String get_TopNodeFilter() { }
        private System.Void set_TopNodeFilter(System.String value) { }
        private System.String get_TopOutputFilter() { }
        private System.Void set_TopOutputFilter(System.String value) { }
        private HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset() { }
        private System.String get_AssetPath() { }
        private UnityEngine.GameObject get_AssetGO() { }
        private System.String get_AssetName() { }
        private System.Int32 get_AssetID() { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNetworkData> get_TopNetworks() { }
        private System.String[] get_TopNetworkNames() { }
        private System.Int32 get_SelectedTOPNetwork() { }
        private HoudiniEngineUnity.HEU_LinkStateWrapper get_PDGLinkState() { }
        private UnityEngine.GameObject get_LoadRootGameObject() { }
        private System.String get_OutputCachePathRoot() { }
        private System.Void Setup(HoudiniEngineUnity.HEU_HoudiniAsset hdaAsset) { }
        private System.Void Reset() { }
        private System.Void Refresh() { }
        private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32,HoudiniEngineUnity.HEU_TOPNodeData>> GetNonHiddenTOPNodes(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork) { }
        private System.Void SelectTOPNetwork(System.Int32 newIndex) { }
        private System.Void SelectTOPNode(HoudiniEngineUnity.HEU_TOPNetworkData network, System.Int32 newIndex) { }
        private HoudiniEngineUnity.HEU_TOPNetworkData GetSelectedTOPNetwork() { }
        private HoudiniEngineUnity.HEU_TOPNodeData GetSelectedTOPNode() { }
        private HoudiniEngineUnity.HEU_TOPNetworkData GetTOPNetwork(System.Int32 index) { }
        private System.Void DirtyTOPNode(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        private System.Void CookTOPNode(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }
        private System.Void DirtyAll() { }
        private System.Void CookOutput() { }
        private System.Void PauseCook() { }
        private System.Void CancelCook() { }
        private HoudiniEngineUnity.HEU_SessionBase GetHAPISession() { }
        private HoudiniEngineUnity.HEU_TOPNodeData GetTOPNode(System.Int32 nodeID) { }
        private System.String GetTOPNodeStatus(HoudiniEngineUnity.HEU_TOPNodeData topNode) { }

    }

    // TypeToken: 0x20000F0
    public interface IHEU_VolumeCache
    {
        // Methods
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayer> get_Layers() { }
        private System.Int32 get_TileIndex() { }
        private System.String get_ObjectName() { }
        private System.String get_GeoName() { }
        private UnityEngine.TerrainData get_TerrainData() { }
        private HoudiniEngineUnity.HEU_VolumeScatterTrees get_ScatterTrees() { }
        private HoudiniEngineUnity.HEU_DetailProperties get_DetailProperties() { }
        private System.Void ResetParameters() { }
        private HoudiniEngineUnity.HEU_VolumeLayer GetLayer(System.String layerName) { }
        private System.Void PopulatePreset(HoudiniEngineUnity.HEU_VolumeCachePreset cachePreset) { }
        private System.Boolean ApplyPreset(HoudiniEngineUnity.HEU_VolumeCachePreset volumeCachePreset) { }

    }

    // TypeToken: 0x20000F1
    public class HEU_MaterialData : ScriptableObject, IHEU_MaterialData, IEquivable`1
    {
        // Fields
        private UnityEngine.Material _material;        // 0x18
        private HoudiniEngineUnity.HEU_MaterialData.Source _materialSource;        // 0x20
        private System.Int32 _materialKey;        // 0x24

        // Methods
        private UnityEngine.Material get_Material() { }
        private HoudiniEngineUnity.HEU_MaterialSourceWrapper get_MaterialSource() { }
        private System.Int32 get_MaterialKey() { }
        private System.Void set_MaterialKey(System.Int32 value) { }
        private System.Boolean UpdateMaterialFromHoudini(HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String assetCacheFolderPath) { }
        private System.Boolean IsExistingMaterial() { }
        private System.Boolean UseLegacyShaders(HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String assetCacheFolderPath, HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_NodeInfo nodeInfo, HoudiniEngineUnity.HAPI_ParmInfo[] parmInfos) { }
        private System.String GetTextureFileNameFromMaterialParam(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo parmInfo) { }
        private System.Boolean IsTransparentMaterial(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters) { }
        private System.Boolean GetMaterialAlpha(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.Single defaultValue, System.Single& alpha) { }
        private System.String GetSupportedFileFormat(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ImageInfo& imageInfo) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_MaterialData other) { }
        private HoudiniEngineUnity.HEU_MaterialData.Source MaterialSource_WrapperToInternal(HoudiniEngineUnity.HEU_MaterialSourceWrapper materialSource) { }
        private HoudiniEngineUnity.HEU_MaterialSourceWrapper MaterialSource_WrapperToInternal(HoudiniEngineUnity.HEU_MaterialData.Source materialSource) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F3
    public class HEU_MaterialFactory
    {
        // Fields
        public static UnityEngine.Material _defaultStandardMaterial;        // 0x0

        // Methods
        private UnityEngine.Shader FindShader(System.String shaderName) { }
        private UnityEngine.Shader FindPluginShader(System.String shaderName) { }
        private UnityEngine.Material GetNewMaterialWithShader(System.String assetCacheFolderPath, System.String shaderName, System.String materialName, System.Boolean bWriteToFile) { }
        private UnityEngine.Material CreateNewHoudiniStandardMaterial(System.String assetCacheFolderPath, System.String materialName, System.Boolean bWriteToFile) { }
        private System.Void WriteMaterialToAssetCache(UnityEngine.Material material, System.String assetCacheFolderPath, System.String materialName, System.Boolean bOverwriteExisting) { }
        private System.Boolean DoesMaterialExistInAssetCache(UnityEngine.Material material) { }
        private System.Void DestroyNonAssetMaterial(UnityEngine.Material material, System.Boolean bRegisterUndo) { }
        private System.Void DeleteAssetMaterial(UnityEngine.Material material) { }
        private UnityEngine.Texture2D RenderAndExtractImageToTexture(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.Int32 textureParmID, System.String textureName, System.String assetCacheFolderPath, System.Boolean isNormalMap, System.Boolean invertTexture) { }
        private UnityEngine.Texture2D ExtractHoudiniImageToTexturePNGJPEG(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String imagePlanes) { }
        private UnityEngine.Texture2D ExtractHoudiniImageToTextureRaw(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String imagePlanes) { }
        private UnityEngine.Texture2D ExtractHoudiniImageToTextureFile(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String imagePlanes, System.String assetCacheFolderPath) { }
        private UnityEngine.Material LoadUnityMaterial(System.String materialPath) { }
        private UnityEngine.Material LoadSubstanceMaterialWithName(System.String materialPath, System.String substanceName) { }
        private UnityEngine.Material LoadSubstanceMaterialWithIndex(System.String materialPath, System.Int32 substanceMaterialIndex) { }
        private System.Int32 GetUnitySubstanceMaterialKey(System.String unityMaterialPath, System.String substanceName, System.Int32 substanceIndex) { }
        private System.Int32 MaterialNameToKey(System.String materialName) { }
        private System.Void EnableGPUInstancing(UnityEngine.Material material) { }
        private System.Boolean MaterialHasGPUInstancingEnabled(UnityEngine.Material material) { }
        private UnityEngine.Material CopyMaterial(UnityEngine.Material material) { }
        private UnityEngine.Material GetDefaultStandardMaterial() { }
        private UnityEngine.Texture2D LoadTexture(System.String path) { }
        private UnityEngine.Texture2D WhiteTexture() { }
        private HoudiniEngineUnity.HEU_MaterialData CreateUnitySubstanceMaterialData(System.Int32 materialKey, System.String materialPath, System.String substanceName, System.Int32 substanceIndex, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath) { }
        private HoudiniEngineUnity.HEU_MaterialData CreateMaterialInCache(System.Int32 materialKey, System.String materialName, HoudiniEngineUnity.HEU_MaterialSourceWrapper sourceType, System.Boolean bWriteToFile, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath) { }
        private HoudiniEngineUnity.HEU_MaterialData CreateMaterialInCache(System.Int32 materialKey, System.String materialName, HoudiniEngineUnity.HEU_MaterialData.Source sourceType, System.Boolean bWriteToFile, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath) { }
        private HoudiniEngineUnity.HEU_MaterialData GetOrCreateDefaultMaterialInCache(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Boolean bWriteToFile, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath) { }
        private HoudiniEngineUnity.HEU_MaterialData GetMaterialDataFromCache(System.Int32 materialKey, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache) { }
        private System.String GenerateDefaultMaterialName(System.Int32 geoID, System.Int32 partID) { }
        private HoudiniEngineUnity.HEU_MaterialData CreateHoudiniMaterialData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, System.Int32 materialID, System.Int32 geoID, System.Int32 partID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath) { }
        private System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MaterialData> GetMaterialDataMapFromCache(System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F4
    public class HEU_UnityMaterialInfo
    {
        // Fields
        public System.String _unityMaterialPath;        // 0x10
        public System.String _substancePath;        // 0x18
        public System.Int32 _substanceIndex;        // 0x20

        // Methods
        private System.Void .ctor(System.String unityMaterialPath, System.String substancePath, System.Int32 substanceIndex) { }

    }

    // TypeToken: 0x20000F5
    public class HEU_SessionBase
    {
        // Fields
        protected HoudiniEngineUnity.HEU_SessionData _sessionData;        // 0x10
        private System.Boolean <UserNotifiedSessionInvalid>k__BackingField;        // 0x18
        private System.String _sessionErrorMsg;        // 0x20
        private System.Boolean <LogErrorOverride>k__BackingField;        // 0x28
        private System.Boolean <ThrowErrorOverride>k__BackingField;        // 0x29
        private HoudiniEngineUnity.HAPI_Result <LastCallResultCode>k__BackingField;        // 0x2C

        // Methods
        private System.Boolean get_UserNotifiedSessionInvalid() { }
        private System.Void set_UserNotifiedSessionInvalid(System.Boolean value) { }
        private HoudiniEngineUnity.SessionConnectionState get_ConnectionState() { }
        private System.Void set_ConnectionState(HoudiniEngineUnity.SessionConnectionState value) { }
        private HoudiniEngineUnity.SessionMode get_ThisSessionMode() { }
        private System.Void set_ThisSessionMode(HoudiniEngineUnity.SessionMode value) { }
        private System.String GetSessionErrorMsg() { }
        private System.Boolean get_LogErrorOverride() { }
        private System.Void set_LogErrorOverride(System.Boolean value) { }
        private System.Boolean get_ThrowErrorOverride() { }
        private System.Void set_ThrowErrorOverride(System.Boolean value) { }
        private System.Boolean IsSessionSync() { }
        private HoudiniEngineUnity.HAPI_Result get_LastCallResultCode() { }
        private System.Void set_LastCallResultCode(HoudiniEngineUnity.HAPI_Result value) { }
        private HoudiniEngineUnity.HEU_HoudiniAsset GetRegisteredAssetFromID(System.Int32 id) { }
        private System.Boolean IsAssetRegistered(HoudiniEngineUnity.HEU_HoudiniAsset asset) { }
        private System.Void RegisterAsset(HoudiniEngineUnity.HEU_HoudiniAsset asset) { }
        private System.Void UnregisterAsset(System.Int32 id) { }
        private System.Void ReregisterOnAwake(HoudiniEngineUnity.HEU_HoudiniAsset asset) { }
        private System.Void .ctor() { }
        private System.Void SetSessionErrorMsg(System.String msg, System.Boolean bLogError) { }
        private System.Void SetSessionConnectionErrorMsg(System.String introMsg, HoudiniEngineUnity.HAPI_Result result, System.Boolean bIsHARSRunning, System.Boolean bLogError) { }
        private System.Void SetLibraryErrorMsg(System.Boolean bLogError) { }
        private System.Boolean CreateSessionData(System.Boolean bOverwriteExisting, System.Boolean bIsDefaultSession) { }
        private System.Boolean CreateInProcessSession(System.Boolean bIsDefaultSession) { }
        private System.Boolean CreateThriftSocketSession(System.Boolean bIsDefaultSession, System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout, System.Boolean bLogError) { }
        private System.Boolean CreateThriftPipeSession(System.Boolean bIsDefaultSession, System.String pipeName, System.Boolean autoClose, System.Single timeout, System.Boolean bLogError) { }
        private System.Boolean CreateCustomSession(System.Boolean bIsDefaultSession) { }
        private System.Boolean ConnectThriftSocketSession(System.Boolean bIsDefaultSession, System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout, System.Boolean logError, System.Boolean autoInitialize) { }
        private System.Boolean ConnectThriftPipeSession(System.Boolean bIsDefaultSession, System.String pipeName, System.Boolean autoClose, System.Single timeout, System.Boolean logError, System.Boolean autoInitialize) { }
        private System.Boolean CloseSession() { }
        private System.Boolean CheckAndCloseExistingSession() { }
        private System.Void ClearSessionInfo() { }
        private System.Void SetSessionData(HoudiniEngineUnity.HEU_SessionData sessionData) { }
        private HoudiniEngineUnity.HEU_SessionData GetSessionData() { }
        private System.String GetSessionInfo() { }
        private System.Boolean IsSessionValid() { }
        private System.Boolean RestartSession() { }
        private System.String GetLastSessionError() { }
        private System.Boolean CheckVersionMatch() { }
        private System.Boolean InitializeSession(HoudiniEngineUnity.HEU_SessionData sessionData) { }
        private System.Boolean HandleStatusResult(HoudiniEngineUnity.HAPI_Result result, System.String prependMsg, System.Boolean bThrowError, System.Boolean bLogError) { }
        private System.Void SetServerEnvString(System.String name, System.String value) { }
        private System.Boolean GetServerEnvString(System.String name, System.String& value) { }
        private System.Boolean GetServerEnvVarCount(System.Int32& env_count) { }
        private System.Boolean GetCallResult(HoudiniEngineUnity.HAPI_Result& result) { }
        private System.Boolean GetCookResult(HoudiniEngineUnity.HAPI_Result& result) { }
        private System.Boolean GetCookState(HoudiniEngineUnity.HAPI_State& state) { }
        private System.String GetStatusString(HoudiniEngineUnity.HAPI_StatusType statusType, HoudiniEngineUnity.HAPI_StatusVerbosity verbosity) { }
        private System.String ComposeNodeCookResult(System.Int32 nodeId, HoudiniEngineUnity.HAPI_StatusVerbosity verbosity) { }
        private System.Int32 GetEnvInt(HoudiniEngineUnity.HAPI_EnvIntType intType) { }
        private System.Int32 GetSessionEnvInt(HoudiniEngineUnity.HAPI_SessionEnvIntType intType, System.Boolean bLogError) { }
        private System.Boolean GetString(System.Int32 stringHandle, System.String& resultString, System.Int32 bufferLength) { }
        private System.Int32 GetStringBufferLength(System.Int32 stringHandle) { }
        private System.Int32 CheckForSpecificErrors(System.Int32 nodeID, System.Int32 errorsToCheck) { }
        private System.Single GetTime() { }
        private System.Boolean SetTime(System.Single time) { }
        private System.Boolean GetUseHoudiniTime() { }
        private System.Boolean SetUseHoudiniTime(System.Boolean enable) { }
        private System.Boolean LoadAssetLibraryFromFile(System.String assetPath, System.Boolean bAllowOverwrite, System.Int32& libraryID) { }
        private System.Boolean LoadAssetLibraryFromMemory(System.Byte[] buffer, System.Boolean bAllowOverwrite, System.Int32& libraryID) { }
        private System.Boolean CreateNode(System.Int32 parentNodeID, System.String operatorName, System.String nodeLabel, System.Boolean bCookOnCreation, System.Int32& newNodeID) { }
        private System.Void DeleteNode(System.Int32 nodeID) { }
        private System.Boolean CookNode(System.Int32 nodeID, System.Boolean bCookTemplatedGeos, System.Boolean bSplitGeosByGroup) { }
        private System.Boolean CookNodeWithOptions(System.Int32 nodeID, HoudiniEngineUnity.HAPI_CookOptions cookOptions) { }
        private System.Boolean RenameNode(System.Int32 nodeID, System.String newName) { }
        private System.Boolean ConnectNodeInput(System.Int32 nodeID, System.Int32 inputIndex, System.Int32 nodeIDToConnect, System.Int32 outputIndex) { }
        private System.Boolean DisconnectNodeInput(System.Int32 nodeID, System.Int32 inputIndex, System.Boolean bLogError) { }
        private System.Boolean QueryNodeInput(System.Int32 nodeID, System.Int32 inputIndex, System.Int32& connectedNodeID, System.Boolean bLogError) { }
        private System.Boolean GetNodeInputName(System.Int32 nodeID, System.Int32 inputIndex, System.Int32& nodeNameIndex) { }
        private System.Boolean GetAvailableAssetCount(System.Int32 libraryID, System.Int32& assetCount) { }
        private System.Boolean GetAvailableAssets(System.Int32 libraryID, System.Int32[]& assetNames, System.Int32 assetCount) { }
        private System.Boolean GetAssetInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_AssetInfo& assetInfo, System.Boolean bLogError) { }
        private System.Boolean GetNodeInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, System.Boolean bLogError) { }
        private System.Boolean GetNodePath(System.Int32 nodeID, System.Int32 relativeNodeID, System.String& path) { }
        private System.Boolean IsNodeValid(System.Int32 nodeID, System.Int32 uniqueNodeID) { }
        private System.Boolean ComposeChildNodeList(System.Int32 parentNodeID, System.Int32 nodeTypeFilter, System.Int32 nodeFlagFilter, System.Boolean bRecursive, System.Int32& count, System.Boolean bLogError) { }
        private System.Boolean GetComposedChildNodeList(System.Int32 parentNodeID, System.Int32[] childNodeIDs, System.Int32 count, System.Boolean bLogError) { }
        private System.Boolean LoadHIPFile(System.String fileName, System.Boolean bCookOnLoad) { }
        private System.Boolean SaveHIPFile(System.String fileName, System.Boolean bLockNodes) { }
        private System.Boolean GetObjectInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_ObjectInfo& objectInfo) { }
        private System.Boolean GetObjectTransform(System.Int32 nodeID, System.Int32 relativeToNodeID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform& hapiTransform) { }
        private System.Boolean SetObjectTransform(System.Int32 nodeID, HoudiniEngineUnity.HAPI_TransformEuler& hapiTransform) { }
        private System.Boolean ComposeObjectList(System.Int32 nodeID, System.Int32& objectCount) { }
        private System.Boolean GetComposedObjectList(System.Int32 nodeID, HoudiniEngineUnity.HAPI_ObjectInfo[] objectInfos, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetComposedObjectTransforms(System.Int32 nodeID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform[] transforms, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetDisplayGeoInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_GeoInfo& geoInfo, System.Boolean bLogError) { }
        private System.Boolean GetOutputGeoCount(System.Int32 nodeID, System.Int32& count, System.Boolean bLogError) { }
        private System.Boolean GetOutputGeoInfos(System.Int32 nodeID, HoudiniEngineUnity.HAPI_GeoInfo[]& geoInfosArray, System.Int32 count, System.Boolean bLogError) { }
        private System.Boolean GetGeoInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_GeoInfo& geoInfo, System.Boolean bLogError) { }
        private System.Boolean GetPartInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_PartInfo& partInfo) { }
        private System.Boolean GetAttributeInfo(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeOwner owner, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo) { }
        private System.Boolean GetAttributeNames(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_AttributeOwner owner, System.String[]& attributeNames, System.Int32 count) { }
        private System.Boolean GetAttributeStringData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Int32[] dataArray, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetAttributeFloatData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Single[] data, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetAttributeFloatArrayData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Single[]& data, System.Int32 dataLength, System.Int32[]& sizesArray, System.Int32 start, System.Int32 sizesLength) { }
        private System.Boolean GetAttributeFloat64Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Double[] data, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetAttributeIntData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Int32[] data, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetAttributeUInt8Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Byte[] data, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetAttributeInt8Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.SByte[] data, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetAttributeInt16Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Int16[] data, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetAttributeInt64Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Int64[] data, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetGroupNames(System.Int32 nodeID, HoudiniEngineUnity.HAPI_GroupType groupType, System.Int32[]& names, System.Int32 count) { }
        private System.Boolean GetGroupMembership(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName, System.Boolean& membershipArrayAllEqual, System.Int32[] membershipArray, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetGroupCountOnPackedInstancePart(System.Int32 nodeID, System.Int32 partID, System.Int32& pointGroupCount, System.Int32& primitiveGroupCount) { }
        private System.Boolean GetGroupNamesOnPackedInstancePart(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.Int32[]& groupNamesArray, System.Int32 groupCount) { }
        private System.Boolean GetGroupMembershipOnPackedInstancePart(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName, System.Boolean& membershipArrayAllEqual, System.Int32[] membershipArray, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetInstancedPartIds(System.Int32 nodeID, System.Int32 partID, System.Int32[] instancedPartsArray, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetInstancerPartTransforms(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform[] transformsArray, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetInstanceTransformsOnPart(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform[] transformsArray, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetInstancedObjectIds(System.Int32 nodeID, System.Int32[] instanced_node_id_array, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetFaceCounts(System.Int32 nodeID, System.Int32 partID, System.Int32[] faceCounts, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetFaceCounts(System.Int32 nodeID, System.Int32 partID, System.Int32[] faceCounts, System.Int32 start, System.Int32 length, System.Boolean bLogError) { }
        private System.Boolean GetVertexList(System.Int32 nodeID, System.Int32 partID, System.Int32[] vertexList, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetBoxInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_BoxInfo& boxInfo) { }
        private System.Boolean GetSphereInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_SphereInfo& sphereInfo) { }
        private System.Boolean GetCurveInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_CurveInfo& curveInfo) { }
        private System.Boolean GetCurveCounts(System.Int32 nodeID, System.Int32 partID, System.Int32[] counts, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetCurveOrders(System.Int32 nodeID, System.Int32 partID, System.Int32[] orders, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetCurveKnots(System.Int32 nodeID, System.Int32 partID, System.Single[] knots, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetInputCurveInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_InputCurveInfo& inputCurveInfo) { }
        private System.Boolean SetPartInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_PartInfo& partInfo) { }
        private System.Boolean SetFaceCount(System.Int32 nodeID, System.Int32 partID, System.Int32[] faceCounts, System.Int32 start, System.Int32 length) { }
        private System.Boolean SetVertexList(System.Int32 nodeID, System.Int32 partID, System.Int32[] vertexList, System.Int32 start, System.Int32 length) { }
        private System.Boolean SetAttributeIntData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Int32[] data, System.Int32 start, System.Int32 length) { }
        private System.Boolean SetAttributeInt8Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.SByte[] data, System.Int32 start, System.Int32 length) { }
        private System.Boolean SetAttributeInt16Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Int16[] data, System.Int32 start, System.Int32 length) { }
        private System.Boolean SetAttributeInt64Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Int64[] data, System.Int32 start, System.Int32 length) { }
        private System.Boolean SetAttributeFloatData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Single[] data, System.Int32 start, System.Int32 length) { }
        private System.Boolean SetAttributeFloatArrayData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Single[] data, System.Int32 dataLength, System.Int32[] sizesArray, System.Int32 start, System.Int32 sizesLength) { }
        private System.Boolean SetAttributeStringData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.String[] data, System.Int32 start, System.Int32 length) { }
        private System.Boolean AddAttribute(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo) { }
        private System.Boolean AddGroup(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName) { }
        private System.Boolean DeleteGroup(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName) { }
        private System.Boolean SetGroupMembership(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName, System.Int32[] membershipArray, System.Int32 start, System.Int32 length) { }
        private System.Boolean CommitGeo(System.Int32 nodeID) { }
        private System.Boolean RevertGeo(System.Int32 nodeID) { }
        private System.Boolean SetCurveInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_CurveInfo& curveInfo) { }
        private System.Boolean SetCurveCounts(System.Int32 nodeID, System.Int32 partID, System.Int32[] counts, System.Int32 start, System.Int32 length) { }
        private System.Boolean SetCurveOrders(System.Int32 nodeID, System.Int32 partID, System.Int32[] orders, System.Int32 start, System.Int32 length) { }
        private System.Boolean SetCurveKnots(System.Int32 nodeID, System.Int32 partID, System.Single[] knots, System.Int32 start, System.Int32 length) { }
        private System.Boolean SetInputCurveInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_InputCurveInfo& curveInfo) { }
        private System.Boolean SetInputCurvePositions(System.Int32 nodeID, System.Int32 partID, System.Single[] positionsArray, System.Int32 start, System.Int32 length) { }
        private System.Boolean SetInputCurvePositionsRotationsScales(System.Int32 nodeID, System.Int32 partID, System.Single[] positionsArray, System.Int32 start, System.Int32 length, System.Single[] rotationsArray, System.Int32 rotationsStart, System.Int32 rotationsLength, System.Single[] scalesArray, System.Int32 scalesStart, System.Int32 scalesLength) { }
        private System.Boolean GetMaterialOnPart(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_MaterialInfo& materialInfo) { }
        private System.Boolean GetMaterialNodeIDsOnFaces(System.Int32 nodeID, System.Int32 partID, System.Boolean& bSingleFaceMaterial, System.Int32[] materialNodeIDs, System.Int32 faceCount) { }
        private System.Boolean GetMaterialInfo(System.Int32 materialNodeID, HoudiniEngineUnity.HAPI_MaterialInfo& materialInfo, System.Boolean bLogError) { }
        private System.Boolean GetImageInfo(System.Int32 materialNodeID, HoudiniEngineUnity.HAPI_ImageInfo& imageInfo) { }
        private System.Boolean SetImageInfo(System.Int32 materialNodeID, HoudiniEngineUnity.HAPI_ImageInfo& imageInfo) { }
        private System.Boolean RenderTextureToImage(System.Int32 materialNodeID, System.Int32 parmID, System.Boolean bLogError) { }
        private System.Boolean RenderCOPToImage(System.Int32 copNodeID) { }
        private System.Boolean ExtractImageToMemory(System.Int32 nodeID, System.String fileFormat, System.String imagePlanes, System.Byte[]& buffer) { }
        private System.Boolean GetImagePlanes(System.Int32 nodeID, System.Int32[] imagePlanes, System.Int32 numImagePlanes) { }
        private System.Boolean ExtractImageToFile(System.Int32 nodeID, System.String fileFormat, System.String imagePlanes, System.String destinationFolderPath, System.String& destinationFilePath) { }
        private System.Boolean GetParams(System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parmInfos, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetParmTagName(System.Int32 nodeID, System.Int32 parmID, System.Int32 tagIndex, System.Int32& tagName) { }
        private System.Boolean GetParmTagValue(System.Int32 nodeID, System.Int32 parmID, System.String tagName, System.Int32& tagValue) { }
        private System.Boolean ParmHasTag(System.Int32 nodeID, System.Int32 parmID, System.String tagName, System.Boolean& hasTag) { }
        private System.Boolean GetParamIntValues(System.Int32 nodeID, System.Int32[] values, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetParamIntValue(System.Int32 nodeID, System.String parmName, System.Int32 index, System.Int32& value) { }
        private System.Boolean GetParamFloatValues(System.Int32 nodeID, System.Single[] values, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetParamFloatValue(System.Int32 nodeID, System.String parmName, System.Int32 index, System.Single& value) { }
        private System.Boolean GetParamStringValues(System.Int32 nodeID, System.Int32[] values, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetParamStringValue(System.Int32 nodeID, System.String parmName, System.Int32 index, System.Int32& value) { }
        private System.Boolean GetParamNodeValue(System.Int32 nodeID, System.String paramName, System.Int32& nodeValue) { }
        private System.Boolean GetParamChoiceValues(System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmChoiceInfo[] values, System.Int32 start, System.Int32 length) { }
        private System.Boolean SetParamIntValues(System.Int32 nodeID, System.Int32[]& values, System.Int32 start, System.Int32 length) { }
        private System.Boolean SetParamIntValue(System.Int32 nodeID, System.String paramName, System.Int32 index, System.Int32 value) { }
        private System.Boolean SetParamFloatValues(System.Int32 nodeID, System.Single[]& values, System.Int32 start, System.Int32 length) { }
        private System.Boolean SetParamFloatValue(System.Int32 nodeID, System.String paramName, System.Int32 index, System.Single value) { }
        private System.Boolean SetParamStringValue(System.Int32 nodeID, System.String strValue, System.Int32 parmID, System.Int32 index) { }
        private System.Boolean SetParamStringValue(System.Int32 nodeID, System.String parmName, System.String parmValue, System.Int32 index) { }
        private System.Boolean SetParamNodeValue(System.Int32 nodeID, System.String paramName, System.Int32 nodeValueID) { }
        private System.Boolean InsertMultiparmInstance(System.Int32 nodeID, System.Int32 parmID, System.Int32 instancePosition) { }
        private System.Boolean RemoveMultiParmInstance(System.Int32 nodeID, System.Int32 parmID, System.Int32 instancePosition) { }
        private System.Boolean GetParmWithTag(System.Int32 nodeID, System.String tagName, System.Int32& parmID) { }
        private System.Boolean RevertParmToDefault(System.Int32 nodeID, System.String parm_name, System.Int32 index) { }
        private System.Boolean RevertParmToDefaults(System.Int32 nodeID, System.String parm_name) { }
        private System.Boolean GetParmIDFromName(System.Int32 nodeID, System.String parmName, System.Int32& parmID) { }
        private System.Boolean GetParmStringValue(System.Int32 nodeID, System.String parmName, System.Int32 index, System.Boolean evaluate, System.Int32& value) { }
        private System.Boolean CreateInputNode(System.Int32& nodeID, System.String name) { }
        private System.Boolean CreateInputCurveNode(System.Int32& nodeID, System.String name) { }
        private System.Boolean CreateHeightFieldInput(System.Int32 parentNodeID, System.String name, System.Int32 xSize, System.Int32 ySize, System.Single voxelSize, HoudiniEngineUnity.HAPI_HeightFieldSampling sampling, System.Int32& heightfieldNodeID, System.Int32& heightNodeID, System.Int32& maskNodeID, System.Int32& mergeNodeID) { }
        private System.Boolean CreateHeightfieldInputVolumeNode(System.Int32 parentNodeID, System.Int32& newNodeID, System.String name, System.Int32 xSize, System.Int32 ySize, System.Single voxelSize) { }
        private System.Boolean GetPreset(System.Int32 nodeID, System.Byte[]& presetData) { }
        private System.Boolean SetPreset(System.Int32 nodeID, System.Byte[] presetData) { }
        private System.Boolean GetVolumeInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_VolumeInfo& volumeInfo) { }
        private System.Boolean GetHeightFieldData(System.Int32 nodeID, System.Int32 partID, System.Single[] valuesArray, System.Int32 start, System.Int32 length) { }
        private System.Boolean SetVolumeInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_VolumeInfo& volumeInfo) { }
        private System.Boolean SetVolumeTileFloatData(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_VolumeTileInfo& tileInfo, System.Single[] valuesArray, System.Int32 length) { }
        private System.Boolean GetVolumeBounds(System.Int32 nodeID, System.Int32 partID, System.Single& x_min, System.Single& y_min, System.Single& z_min, System.Single& x_max, System.Single& y_max, System.Single& z_max, System.Single& x_center, System.Single& y_center, System.Single& z_center) { }
        private System.Boolean SetHeightFieldData(System.Int32 nodeID, System.Int32 partID, System.String name, System.Single[] valuesArray, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetActiveCacheCount(System.Int32& activeCacheCount) { }
        private System.Boolean GetActiveCacheNames(System.Int32[] cacheNamesArray, System.Int32 activeCacheCount) { }
        private System.Boolean GetCacheProperty(System.String cacheName, HoudiniEngineUnity.HAPI_CacheProperty cacheProperty, System.Int32& propertyValue) { }
        private System.Boolean SetCacheProperty(System.String cacheName, HoudiniEngineUnity.HAPI_CacheProperty cacheProperty, System.Int32 propertyValue) { }
        private System.Boolean SaveGeoToFile(System.Int32 nodeID, System.String fileName) { }
        private System.Boolean LoadGeoFromFile(System.Int32 nodeID, System.String file_name) { }
        private System.Boolean SaveNodeToFile(System.Int32 nodeID, System.String fileName) { }
        private System.Boolean LoadNodeFromFile(System.String file_name, System.Int32 parentNodeID, System.String nodeLabel, System.Boolean cook_on_load, System.Int32& newNodeID) { }
        private System.Boolean GetGeoSize(System.Int32 nodeID, System.String format, System.Int32& size) { }
        private System.Boolean GetHandleInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_HandleInfo[] handleInfos, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetHandleBindingInfo(System.Int32 nodeID, System.Int32 handleIndex, HoudiniEngineUnity.HAPI_HandleBindingInfo[] handleBindingInfos, System.Int32 start, System.Int32 length) { }
        private System.Boolean ConvertTransform(HoudiniEngineUnity.HAPI_TransformEuler& inTransform, HoudiniEngineUnity.HAPI_RSTOrder RSTOrder, HoudiniEngineUnity.HAPI_XYZOrder ROTOrder, HoudiniEngineUnity.HAPI_TransformEuler& outTransform) { }
        private System.Boolean GetTotalCookCount(System.Int32 nodeID, System.Int32 nodeTypeFilter, System.Int32 nodeFlagFilter, System.Boolean includeChildren, System.Int32& count) { }
        private System.Boolean SetSessionSync(System.Boolean enable) { }
        private System.Boolean GetViewport(HoudiniEngineUnity.HAPI_Viewport& viewport) { }
        private System.Boolean SetViewport(HoudiniEngineUnity.HAPI_Viewport& viewport) { }
        private System.Boolean GetSessionSyncInfo(HoudiniEngineUnity.HAPI_SessionSyncInfo& syncInfo) { }
        private System.Boolean SetSessionSyncInfo(HoudiniEngineUnity.HAPI_SessionSyncInfo& syncInfo) { }
        private System.Boolean SetNodeDisplay(System.Int32 node_id, System.Int32 onOff) { }

    }

    // TypeToken: 0x20000F6
    public struct SessionConnectionState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.SessionConnectionState NOT_CONNECTED;        // 0x0
        public static HoudiniEngineUnity.SessionConnectionState CONNECTED;        // 0x0
        public static HoudiniEngineUnity.SessionConnectionState FAILED_TO_CONNECT;        // 0x0

    }

    // TypeToken: 0x20000F7
    public struct SessionMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.SessionMode Socket;        // 0x0
        public static HoudiniEngineUnity.SessionMode Pipe;        // 0x0

    }

    // TypeToken: 0x20000F8
    public class HEU_SessionData
    {
        // Fields
        public static System.Int64 INVALID_SESSION_ID;        // 0x0
        public HoudiniEngineUnity.HAPI_Session _HAPISession;        // 0x10
        private System.Int32 _serverProcessID;        // 0x20
        private System.Boolean _initialized;        // 0x24
        private System.String _pipeName;        // 0x28
        private System.Int32 _port;        // 0x30
        private System.String _sessionClassType;        // 0x38
        private System.Boolean _isDefaultSession;        // 0x40
        private HoudiniEngineUnity.HEU_SessionSyncData _sessionSync;        // 0x48
        private HoudiniEngineUnity.SessionConnectionState _connectionState;        // 0x50
        private HoudiniEngineUnity.SessionMode _sessionMode;        // 0x54

        // Methods
        private HoudiniEngineUnity.HEU_SessionSyncData GetOrCreateSessionSync() { }
        private HoudiniEngineUnity.HEU_SessionSyncData GetSessionSync() { }
        private System.Void SetSessionSync(HoudiniEngineUnity.HEU_SessionSyncData syncData) { }
        private System.Int64 get_SessionID() { }
        private System.Void set_SessionID(System.Int64 value) { }
        private System.Int32 get_ProcessID() { }
        private System.Void set_ProcessID(System.Int32 value) { }
        private HoudiniEngineUnity.HAPI_SessionType get_SessionType() { }
        private System.Void set_SessionType(HoudiniEngineUnity.HAPI_SessionType value) { }
        private System.Boolean get_IsInitialized() { }
        private System.Void set_IsInitialized(System.Boolean value) { }
        private System.Boolean get_IsValidSessionID() { }
        private System.String get_PipeName() { }
        private System.Void set_PipeName(System.String value) { }
        private System.Int32 get_Port() { }
        private System.Void set_Port(System.Int32 value) { }
        private System.Type get_SessionClassType() { }
        private System.Void set_SessionClassType(System.Type value) { }
        private System.Boolean get_IsDefaultSession() { }
        private System.Void set_IsDefaultSession(System.Boolean value) { }
        private System.Boolean get_IsSessionSync() { }
        private HoudiniEngineUnity.SessionConnectionState get_ThisConnectionMode() { }
        private System.Void set_ThisConnectionMode(HoudiniEngineUnity.SessionConnectionState value) { }
        private HoudiniEngineUnity.SessionMode get_ThisSessionMode() { }
        private System.Void set_ThisSessionMode(HoudiniEngineUnity.SessionMode value) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000F9
    public class HEU_SessionHAPI : HEU_SessionBase
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FA
    public class HEU_SessionManager
    {
        // Fields
        private static HoudiniEngineUnity.HEU_SessionBase _defaultSession;        // 0x0
        private static System.Collections.Generic.Dictionary<System.Int64,HoudiniEngineUnity.HEU_SessionBase> _sessionMap;        // 0x8
        public static HoudiniEngineUnity.HEU_SessionManager.CreateSessionFromTypeDelegate _createSessionFromTypeDelegate;        // 0x10

        // Methods
        private HoudiniEngineUnity.HEU_SessionBase CreateSessionObject() { }
        private HoudiniEngineUnity.HEU_SessionBase CreateSessionFromType(System.Type type) { }
        private HoudiniEngineUnity.HEU_SessionBase GetDefaultSession() { }
        private System.Void RegisterSession(System.Int64 sessionID, HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void UnregisterSession(System.Int64 sessionID) { }
        private HoudiniEngineUnity.HEU_SessionBase GetSessionWithID(System.Int64 sessionID) { }
        private System.Void SaveAllSessionData() { }
        private System.Void LoadAllSessionData() { }
        private System.Void InternalValidateSceneAssets() { }
        private HoudiniEngineUnity.HEU_SessionBase GetOrCreateDefaultSession(System.Boolean bNotifyUserError) { }
        private System.Boolean CreateInProcessSession() { }
        private System.Boolean CreateThriftSocketSession(System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout, System.Boolean logError) { }
        private System.Boolean CreateThriftPipeSession(System.String pipeName, System.Boolean autoClose, System.Single timeout, System.Boolean logError) { }
        private System.Boolean CreateCustomSession() { }
        private System.Boolean ConnectThriftSocketSession(System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout) { }
        private System.Boolean ConnectThriftPipeSession(System.String pipeName, System.Boolean autoClose, System.Single timeout) { }
        private System.Void RecreateDefaultSessionData() { }
        private System.Boolean ConnectSessionSyncUsingThriftSocket(System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout, System.Boolean logError) { }
        private System.Boolean ConnectSessionSyncUsingThriftPipe(System.String pipeName, System.Boolean autoClose, System.Single timeout, System.Boolean logError) { }
        private System.Boolean InitializeDefaultSession() { }
        private System.Boolean CloseDefaultSession() { }
        private System.Void CloseAllSessions() { }
        private System.Void CheckAndCloseExistingSession() { }
        private HoudiniEngineUnity.HEU_SessionData GetSessionData() { }
        private System.String GetSessionInfo() { }
        private System.Boolean LoadStoredDefaultSession() { }
        private System.Boolean RestartSession() { }
        private System.Boolean ValidatePluginSession(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.String GetLastSessionError() { }
        private System.Boolean CheckVersionMatch() { }
        private System.Boolean ClearConnectionError() { }
        private System.String GetConnectionError(System.Boolean clear) { }
        private System.Boolean IsHARSProcessRunning(System.Int32 processID) { }
        private System.Boolean LoadSessionFromHIP(System.Boolean bCookNodes, HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Boolean SaveSessionToHIP(System.Boolean bLockNodes, HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.String GetHoudiniPathOnMacOS(System.String houdiniPath) { }
        private System.Boolean OpenHoudini(System.String args) { }
        private System.Boolean OpenSessionInHoudini(HoudiniEngineUnity.HEU_SessionBase session) { }
        private HoudiniEngineUnity.HAPI_License GetCurrentLicense(System.Boolean bLogError) { }
        private System.String GetString(System.Int32 stringHandle, HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.String[] GetStringValuesFromStringIndices(System.Int32[] strIndices) { }
        private System.String[] GetGroupNames(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.Boolean isInstanced) { }
        private System.Boolean GetGroupMembership(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName, System.Int32[]& membership, System.Boolean isInstanced) { }
        private System.String GetNodeName(System.Int32 nodeID, HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Boolean GetNodeInputName(System.Int32 nodeID, System.Int32 inputIndex, System.String& inputName) { }
        private System.Boolean GetComposedChildNodeList(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 parentNodeID, System.Int32 nodeTypeFilter, System.Int32 nodeFlagFilter, System.Boolean bRecursive, System.Int32[]& childNodeIDs, System.Boolean bLogIfError) { }
        private System.Boolean GetComposedObjectListMemorySafe(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ObjectInfo[] objectInfos, System.Int32 start, System.Int32 length) { }
        private System.Boolean GetComposedObjectTransformsMemorySafe(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform[] transforms, System.Int32 start, System.Int32 length) { }
        private System.String GetUniqueMaterialShopName(System.Int32 assetID, System.Int32 materialID) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000FC
    public class HEU_SessionPDG
    {
    }

    // TypeToken: 0x20000FD
    public class HEU_SessionSyncData
    {
        // Fields
        private System.Int32 _status;        // 0x10
        public System.Single _timeLastUpdate;        // 0x14
        public System.Single _timeStartConnection;        // 0x18
        public System.String _newNodeName;        // 0x20
        public System.Int32 _nodeTypeIndex;        // 0x28
        public System.Boolean _validForConnection;        // 0x2C
        public HoudiniEngineUnity.HAPI_Viewport _viewportHAPI;        // 0x30
        public HoudiniEngineUnity.HAPI_Viewport _viewportLocal;        // 0x48
        public System.Boolean _viewportJustUpdated;        // 0x60
        public HoudiniEngineUnity.HAPI_SessionSyncInfo _syncInfo;        // 0x61

        // Methods
        private HoudiniEngineUnity.HEU_SessionSyncData.Status get_SyncStatus() { }
        private System.Void set_SyncStatus(HoudiniEngineUnity.HEU_SessionSyncData.Status value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FF
    public class HEU_AssetSync : HEU_BaseSync
    {
        // Fields
        public HoudiniEngineUnity.HEU_AssetSync.AssetSyncCallback _onAssetLoaded;        // 0x88
        public System.String _assetPath;        // 0x90

        // Methods
        private System.Void OnEnable() { }
        private System.Void OnDestroy() { }
        private System.Void InitializeAsset(HoudiniEngineUnity.HEU_SessionBase session, System.String assetPath, System.String nodeName, UnityEngine.Transform parent, UnityEngine.Vector3 startPosition) { }
        private HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo CreateThreadedTask() { }
        private System.Void SetLoadCallback(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallback callback) { }
        private System.Void SetupLoadTask(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void OnLoadComplete(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) { }
        private System.Void Resync() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000101
    public class HEU_SyncedEventData
    {
        // Fields
        public System.Boolean CookSuccess;        // 0x10
        public HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData TopNodeData;        // 0x18
        public HoudiniEngineUnity.HEU_BaseSync OutputObject;        // 0x20

        // Methods
        private System.Void .ctor(System.Boolean bSuccess, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData bTopNodeData, HoudiniEngineUnity.HEU_BaseSync bOutputObject) { }

    }

    // TypeToken: 0x2000102
    public class HEU_BaseSync : MonoBehaviour
    {
        // Fields
        public System.Int32 _cookNodeID;        // 0x18
        public System.Int64 _sessionID;        // 0x20
        public System.String _nodeName;        // 0x28
        public System.Boolean _initialized;        // 0x30
        public System.Boolean _syncing;        // 0x31
        public System.Boolean _deleteParent;        // 0x32
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> _generatedOutputs;        // 0x38
        public System.String _outputCacheDirectory;        // 0x40
        public System.Collections.Generic.List<System.String> _outputCacheFilePaths;        // 0x48
        public HoudiniEngineUnity.HEU_GenerateOptions _generateOptions;        // 0x50
        public System.Text.StringBuilder _log;        // 0x58
        public System.Text.StringBuilder _error;        // 0x60
        public System.Boolean _sessionSyncAutoCook;        // 0x68
        private System.Action<HoudiniEngineUnity.HEU_SyncedEventData> _onSynced;        // 0x70
        protected HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo _loadTask;        // 0x78
        protected System.Int32 _totalCookCount;        // 0x80
        protected System.Boolean _firstSyncComplete;        // 0x84

        // Methods
        private System.Void Awake() { }
        private System.Void OnDestroy() { }
        private System.Void DeleteSessionData() { }
        private System.Void DestroyGeneratedData() { }
        private System.Void Initialize() { }
        private HoudiniEngineUnity.HEU_SessionBase GetHoudiniSession(System.Boolean bCreateIfNotFound) { }
        private System.Int32 GetParentNodeID(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void Log(System.String msg) { }
        private System.Void ClearLog() { }
        private System.Void Error(System.String error) { }
        private System.Boolean IsLoaded() { }
        private System.Void StartSync() { }
        private System.Void SetupLoadTask(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void StopSync() { }
        private System.Void Resync() { }
        private System.Void Bake() { }
        private System.Void Unload() { }
        private System.Void Reset() { }
        private System.Void OnLoadComplete(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) { }
        private System.Void GenerateObjects(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) { }
        private System.Void GenerateGeometry(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData, System.Int32 objIndex) { }
        private System.Void OnStopped(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) { }
        private System.Void GenerateTerrain(System.Int32 cookNodeId, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolume> terrainBuffers) { }
        private System.Void GenerateMesh(System.Int32 cookNodeId, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferMesh> meshBuffers) { }
        private System.Void GenerateAllInstancers(System.Int32 cookNodeId, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferInstancer> instancerBuffers, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) { }
        private System.Void GenerateInstancer(System.Int32 cookNodeId, HoudiniEngineUnity.HEU_LoadBufferInstancer instancerBuffer, System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_LoadBufferBase> idBuffersMap) { }
        private System.Void GenerateInstancesFromNodeIDs(System.Int32 cookNodeId, HoudiniEngineUnity.HEU_LoadBufferInstancer instancerBuffer, System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_LoadBufferBase> idBuffersMap, UnityEngine.Transform instanceRootTransform) { }
        private System.Void GenerateInstancesFromAssetPaths(HoudiniEngineUnity.HEU_LoadBufferInstancer instancerBuffer, UnityEngine.Transform instanceRootTransform) { }
        private System.Void CreateNewInstanceFromObject(UnityEngine.GameObject assetSourceGO, System.Int32 instanceIndex, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HAPI_Transform& hapiTransform, System.String[] instancePrefixes, System.String instanceName, UnityEngine.GameObject collisionSourceGO) { }
        private System.Void ApplyAttributeModifiersOnGameObjectOutput(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partId, UnityEngine.GameObject& go) { }
        private System.Void DestroyOutputs() { }
        private System.Void SetOutputVisiblity(HoudiniEngineUnity.HEU_LoadBufferBase buffer) { }
        private System.String GetOutputCacheDirectory() { }
        private System.Void SetOutputCacheDirectory(System.String directory) { }
        private System.Void AddGeneratedOutputFilePath(System.String path) { }
        private System.Void SyncUpdate() { }
        private System.Action<HoudiniEngineUnity.HEU_SyncedEventData> get_OnSynced() { }
        private System.Void set_OnSynced(System.Action<HoudiniEngineUnity.HEU_SyncedEventData> value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000103
    public struct HEU_GenerateOptions
    {
        // Fields
        public System.Boolean _generateUVs;        // 0x10
        public System.Boolean _generateTangents;        // 0x11
        public System.Boolean _generateNormals;        // 0x12
        public System.Boolean _useLODGroups;        // 0x13
        public System.Boolean _splitPoints;        // 0x14

    }

    // TypeToken: 0x2000104
    public class HEU_GeoSync : HEU_BaseSync
    {
        // Fields
        public System.String _filePath;        // 0x88

        // Methods
        private System.Void SetupLoadTask(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000105
    public class HEU_NodeSync : HEU_BaseSync
    {
        // Fields
        public System.String _nodeSaveFilePath;        // 0x88

        // Methods
        private System.Void OnEnable() { }
        private System.Void OnDestroy() { }
        private System.Void InitializeFromHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.String nodeName, System.String filePath) { }
        private System.Void SetupLoadTask(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Boolean SaveNodeToFile(System.String filePath) { }
        private System.Void CreateNodeSync(HoudiniEngineUnity.HEU_SessionBase session, System.String opName, System.String nodeNabel) { }
        private System.Void Resync() { }
        private System.Void SyncUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000106
    public class HEU_Task
    {
        // Fields
        public HoudiniEngineUnity.HEU_Task.TaskStatus _status;        // 0x10
        public HoudiniEngineUnity.HEU_Task.TaskResult _result;        // 0x14
        private System.Guid _guid;        // 0x18
        public HoudiniEngineUnity.HEU_Task.TaskCallback _taskCompletedDelegate;        // 0x28

        // Methods
        private System.Guid get_TaskGuid() { }
        private System.Void .ctor() { }
        private System.Void DoTask() { }
        private System.Void UpdateTask() { }
        private System.Void KillTask() { }
        private System.Void CompleteTask(HoudiniEngineUnity.HEU_Task.TaskResult result) { }

    }

    // TypeToken: 0x200010A
    public class HEU_AssetTask : HEU_Task
    {
        // Fields
        public HoudiniEngineUnity.HEU_AssetTask.BuildType _buildType;        // 0x30
        public HoudiniEngineUnity.HEU_HoudiniAsset _asset;        // 0x38
        public System.String _assetPath;        // 0x40
        public UnityEngine.Vector3 _position;        // 0x48
        public System.Boolean _buildResult;        // 0x54
        public System.Int64 _forceSessionID;        // 0x58

        // Methods
        private HoudiniEngineUnity.HEU_SessionBase GetTaskSession() { }
        private System.Void DoTask() { }
        private System.Void KillTask() { }
        private System.Void CompleteTask(HoudiniEngineUnity.HEU_Task.TaskResult result) { }
        private System.Void CookCompletedCallback(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean bSuccess, System.Collections.Generic.List<UnityEngine.GameObject> outputs) { }
        private System.Void CookCompletedCallback(HoudiniEngineUnity.HEU_CookedEventData cookedEventData) { }
        private System.Void CookCompletedCallback(HoudiniEngineUnity.HEU_ReloadEventData reloadEventData) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010C
    public class HEU_TaskManager
    {
        // Fields
        private static System.Collections.Generic.List<HoudiniEngineUnity.HEU_Task> _tasks;        // 0x0
        private static System.Collections.Generic.List<HoudiniEngineUnity.HEU_Task> _pendingAdd;        // 0x8
        private static System.Collections.Generic.List<HoudiniEngineUnity.HEU_Task> _pendingRemove;        // 0x10

        // Methods
        private System.Void .cctor() { }
        private System.Void Update() { }
        private HoudiniEngineUnity.HEU_Task GetTask(System.Guid taskGuid) { }
        private System.Void AddTask(HoudiniEngineUnity.HEU_Task task) { }
        private System.Void KillTask(HoudiniEngineUnity.HEU_Task task, System.Boolean bRemove) { }
        private System.Void KillTask(System.Guid taskGuid, System.Boolean bRemove) { }
        private System.Void RemoveTask(HoudiniEngineUnity.HEU_Task task) { }
        private System.Void ExecuteTask(HoudiniEngineUnity.HEU_Task task) { }
        private System.Void CompleteTask(HoudiniEngineUnity.HEU_Task task, HoudiniEngineUnity.HEU_Task.TaskResult result) { }
        private System.Void InternalCompleteTask(HoudiniEngineUnity.HEU_Task task) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010D
    public class HEU_LoadBufferBase
    {
        // Fields
        public System.Int32 _id;        // 0x10
        public System.String _name;        // 0x18
        public System.Boolean _bInstanced;        // 0x20
        public System.Boolean _bInstancer;        // 0x21
        public HoudiniEngineUnity.HEU_GeneratedOutput _generatedOutput;        // 0x28

        // Methods
        private System.Void InitializeBuffer(System.Int32 id, System.String name, System.Boolean bInstanced, System.Boolean bInstancer) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010E
    public class HEU_LoadBufferMesh : HEU_LoadBufferBase
    {
        // Fields
        public HoudiniEngineUnity.HEU_GenerateGeoCache _geoCache;        // 0x30
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoGroup> _LODGroupMeshes;        // 0x38
        public System.Int32 _defaultMaterialKey;        // 0x40
        public System.Boolean _bGenerateUVs;        // 0x44
        public System.Boolean _bGenerateTangents;        // 0x45
        public System.Boolean _bGenerateNormals;        // 0x46
        public System.Boolean _bPartInstanced;        // 0x47

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010F
    public class HEU_LoadBufferVolume : HEU_LoadBufferBase
    {
        // Fields
        public System.Int32 _tileIndex;        // 0x30
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolumeLayer> _splatLayers;        // 0x38
        public System.Int32 _heightMapWidth;        // 0x40
        public System.Int32 _heightMapHeight;        // 0x44
        public System.Single[,] _heightMap;        // 0x48
        public System.Single[,,] _splatMaps;        // 0x50
        public System.Single _terrainSizeX;        // 0x58
        public System.Single _terrainSizeY;        // 0x5C
        public System.Single _heightRange;        // 0x60
        public UnityEngine.Vector3 _position;        // 0x64
        public System.String _terrainDataPath;        // 0x70
        public System.String _terrainDataExportPath;        // 0x78
        public HoudiniEngineUnity.HEU_VolumeScatterTrees _scatterTrees;        // 0x80
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_DetailPrototype> _detailPrototypes;        // 0x88
        public System.Collections.Generic.List<System.Int32[,]> _detailMaps;        // 0x90
        public HoudiniEngineUnity.HEU_DetailProperties _detailProperties;        // 0x98
        public System.String _specifiedTerrainMaterialName;        // 0xA0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000110
    public class HEU_LoadBufferVolumeLayer
    {
        // Fields
        public System.String _layerName;        // 0x10
        public System.Int32 _partID;        // 0x18
        public System.Int32 _heightMapWidth;        // 0x1C
        public System.Int32 _heightMapHeight;        // 0x20
        public System.Single _strength;        // 0x24
        public System.String _diffuseTexturePath;        // 0x28
        public System.String _maskTexturePath;        // 0x30
        public System.Single _metallic;        // 0x38
        public System.String _normalTexturePath;        // 0x40
        public System.Single _normalScale;        // 0x48
        public System.Single _smoothness;        // 0x4C
        public UnityEngine.Color _specularColor;        // 0x50
        public UnityEngine.Vector2 _tileSize;        // 0x60
        public UnityEngine.Vector2 _tileOffset;        // 0x68
        public System.Boolean _uiExpanded;        // 0x70
        public System.Int32 _tile;        // 0x74
        public System.Single[] _normalizedHeights;        // 0x78
        public System.Single _minHeight;        // 0x80
        public System.Single _maxHeight;        // 0x84
        public System.Single _heightRange;        // 0x88
        public System.Single _terrainSizeX;        // 0x8C
        public System.Single _terrainSizeY;        // 0x90
        public UnityEngine.Vector3 _position;        // 0x94
        public UnityEngine.Vector3 _minBounds;        // 0xA0
        public UnityEngine.Vector3 _maxBounds;        // 0xAC
        public UnityEngine.Vector3 _center;        // 0xB8
        public System.String _layerPath;        // 0xC8
        public System.Boolean _hasLayerAttributes;        // 0xD0
        public HoudiniEngineUnity.HFLayerType _layerType;        // 0xD4

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000111
    public class HEU_LoadBufferInstancer : HEU_LoadBufferBase
    {
        // Fields
        public HoudiniEngineUnity.HAPI_Transform[] _instanceTransforms;        // 0x30
        public System.String[] _instancePrefixes;        // 0x38
        public System.Int32[] _instanceNodeIDs;        // 0x40
        public System.String[] _assetPaths;        // 0x48
        public System.String[] _collisionAssetPaths;        // 0x50

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000112
    public class HEU_ThreadedTask
    {
        // Fields
        private System.Boolean _isComplete;        // 0x10
        private System.Boolean _isActive;        // 0x11
        private System.Boolean _stopRequested;        // 0x12
        private System.Object _lockHandle;        // 0x18
        private System.Threading.Thread _thread;        // 0x20
        private System.Threading.ThreadPriority _priority;        // 0x28
        private System.Boolean _isBackground;        // 0x2C
        protected System.String _name;        // 0x30

        // Methods
        private System.Void Start() { }
        private System.Void Stop() { }
        private System.Void Abort() { }
        private System.Void Reset() { }
        private System.Void Update() { }
        private System.Void DoWork() { }
        private System.Void OnComplete() { }
        private System.Void OnStopped() { }
        private System.Void CleanUp() { }
        private System.Void Run() { }
        private System.String get_TaskName() { }
        private System.Boolean get_IsComplete() { }
        private System.Void set_IsComplete(System.Boolean value) { }
        private System.Boolean get_IsActive() { }
        private System.Void set_IsActive(System.Boolean value) { }
        private System.Boolean get_StopRequested() { }
        private System.Void set_StopRequested(System.Boolean value) { }
        private System.Threading.ThreadPriority get_Priority() { }
        private System.Void set_Priority(System.Threading.ThreadPriority value) { }
        private System.Boolean get_IsBackground() { }
        private System.Void set_IsBackground(System.Boolean value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000113
    public class HEU_ThreadedTaskLoadGeo : HEU_ThreadedTask
    {
        // Fields
        private HoudiniEngineUnity.HEU_BaseSync _ownerSync;        // 0x38
        private HoudiniEngineUnity.HEU_SessionBase _session;        // 0x40
        private HoudiniEngineUnity.HEU_GenerateOptions _generateOptions;        // 0x48
        protected System.String _assetCachePath;        // 0x50
        private HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadType _loadType;        // 0x58
        private System.String _filePath;        // 0x60
        private HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData _loadData;        // 0x68
        private HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallback _loadCallback;        // 0x70

        // Methods
        private System.Void SetupLoad(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_BaseSync ownerSync, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadType loadType, System.Int32 cookNodeID, System.String name, System.String filePath) { }
        private System.Void SetupLoadNode(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_BaseSync ownerSync, System.Int32 cookNodeID, System.String name) { }
        private System.Void SetupLoadFile(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_BaseSync ownerSync, System.Int32 cookNodeID, System.String filePath) { }
        private System.Void SetupLoadAsset(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_BaseSync ownerSync, System.String assetPath, System.String name) { }
        private System.Void SetLoadCallback(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallback loadCallback) { }
        private System.Void DoWork() { }
        private System.Boolean CookNode(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 cookNodeID) { }
        private System.Boolean LoadObjectBuffers(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ObjectInfo& objectInfo) { }
        private System.Boolean LoadNodeBuffer(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadObject loadObject) { }
        private System.Void BuildBufferIDsMap(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData) { }
        private System.Boolean DoFileLoad() { }
        private System.Boolean DoAssetLoad() { }
        private System.Boolean QueryParts(System.Int32 nodeID, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& meshParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& volumeParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& instancerParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& curveParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& scatterInstancerParts) { }
        private System.Void OnComplete() { }
        private System.Void OnStopped() { }
        private System.Void CleanUp() { }
        private System.String CreateLogString(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus status, System.String logStr) { }
        private System.Void AppendLog(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus status, System.String logStr) { }
        private System.Void SetLog(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus status, System.String logStr) { }
        private System.Boolean CreateFileNode(System.Int32& fileNodeID) { }
        private System.Int32 GetCookNodeID() { }
        private System.Int32 GetDisplayNodeID(System.Int32 objNodeID) { }
        private System.Boolean SetFileParm(System.Int32 fileNodeID, System.String filePath) { }
        private System.Void Sleep() { }
        private System.Boolean GenerateTerrainBuffers(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo> volumeParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo> scatterInstancerParts, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolume>& volumeBuffers) { }
        private System.Void LoadStringFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.String& strValue) { }
        private System.Void LoadFloatFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Single& floatValue) { }
        private System.Void LoadLayerColorFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Color& colorValue) { }
        private System.Void LoadLayerVector2FromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Vector2& vectorValue) { }
        private System.Boolean GenerateMeshBuffers(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo> meshParts, System.Boolean bSplitPoints, System.Boolean bUseLODGroups, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadObject loadObject, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferMesh>& meshBuffers) { }
        private System.Boolean GenerateInstancerBuffers(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo> instancerParts, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferInstancer>& instancerBuffers) { }
        private HoudiniEngineUnity.HEU_LoadBufferInstancer GeneratePartsInstancerBuffer(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String partName, HoudiniEngineUnity.HAPI_PartInfo partInfo) { }
        private HoudiniEngineUnity.HEU_LoadBufferInstancer GeneratePointAttributeInstancerBuffer(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String partName, HoudiniEngineUnity.HAPI_PartInfo partInfo) { }
        private HoudiniEngineUnity.HEU_LoadBufferVolume GetLoadBufferVolumeFromTileIndex(System.Int32 tileIndex, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolume> buffers) { }
        private System.String GetValidAssetCacheFolderPath(System.String name) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011A
    public class HEU_ThreadManager
    {
        // Fields
        private static HoudiniEngineUnity.HEU_ThreadManager _instance;        // 0x0
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ThreadedTask> _tasks;        // 0x10
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ThreadedTask> _pendingAdd;        // 0x18
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_ThreadedTask> _pendingRemove;        // 0x20

        // Methods
        private HoudiniEngineUnity.HEU_ThreadManager get_Instance() { }
        private System.Void CreateInstance() { }
        private System.Void Finalize() { }
        private System.Void Register() { }
        private System.Void Unregister() { }
        private System.Void Update() { }
        private System.Void AddTask(HoudiniEngineUnity.HEU_ThreadedTask task) { }
        private System.Void RemoveTask(HoudiniEngineUnity.HEU_ThreadedTask task) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011B
    public class HEU_CookLogs
    {
        // Fields
        private static HoudiniEngineUnity.HEU_CookLogs _instance;        // 0x0
        private System.Text.StringBuilder _cookLogs;        // 0x10
        private System.Int32 _currentCookLogCount;        // 0x18
        private static System.Int32 MAX_COOK_LOG_COUNT;        // 0x0
        private System.String _lastLogStr;        // 0x20
        private System.Boolean _uniqueStrOnly;        // 0x28
        public static System.Int64 MaxLogSize;        // 0x0

        // Methods
        private HoudiniEngineUnity.HEU_CookLogs get_Instance() { }
        private System.String GetCookLogString() { }
        private System.Void AppendCookLog(System.String logStr) { }
        private System.Void ClearCookLog() { }
        private System.String GetCookLogFilePath() { }
        private System.Void DeleteCookingFile() { }
        private System.Void WriteToLogFile(System.String logStr, System.Boolean checkLastLogStr) { }
        private System.Int64 GetFileSizeOfLogFile() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011C
    public class HEU_EditorUtility
    {
        // Methods
        private System.Void MarkSceneDirty() { }
        private System.Void SelectObject(UnityEngine.GameObject gameObject) { }
        private System.Void SelectObjects(UnityEngine.GameObject[] gameObjects) { }
        private UnityEngine.Vector3 GetSelectedObjectsMeanPosition() { }
        private UnityEngine.Matrix4x4 GetSelectedObjectsMeanTransform() { }
        private UnityEngine.GameObject SaveAsPrefabAsset(System.String path, UnityEngine.GameObject go) { }
        private System.Boolean PrefabIsAddedComponentOverride(UnityEngine.Component comp) { }
        private System.Boolean IsEditorPlaying() { }
        private UnityEngine.GameObject ReplacePrefab(UnityEngine.GameObject go, UnityEngine.Object targetPrefab, HoudiniEngineUnity.HEU_EditorUtility.HEU_ReplacePrefabOptions heuOptions) { }
        private System.Boolean IsPrefabInstance(UnityEngine.GameObject go) { }
        private System.Boolean IsPrefabAsset(UnityEngine.GameObject go) { }
        private System.Boolean IsEditingInPrefabMode(UnityEngine.GameObject obj) { }
        private System.Boolean IsDisconnectedPrefabInstance(UnityEngine.GameObject go) { }
        private UnityEngine.Object GetPrefabAsset(UnityEngine.GameObject go) { }
        private System.String GetPrefabAssetPath(UnityEngine.Object obj) { }
        private System.Void DisconnectPrefabInstance(UnityEngine.GameObject instance) { }
        private UnityEngine.Object InstantiatePrefab(UnityEngine.GameObject prefabOriginal) { }
        private UnityEngine.GameObject InstantiateGameObject(UnityEngine.GameObject sourceGameObject, UnityEngine.Transform parentTransform, System.Boolean instantiateInWorldSpace, System.Boolean bRegisterUndo) { }
        private UnityEngine.Component AddComponent(UnityEngine.GameObject target, System.Boolean bRegisterUndo) { }
        private System.Void UndoRecordObject(UnityEngine.Object objectToUndo, System.String name) { }
        private System.Void UndoCollapseCurrentGroup() { }
        private UnityEngine.Object[] CollectDependencies(UnityEngine.Object obj) { }
        private System.Boolean IsPersistant(UnityEngine.Object obj) { }
        private System.String GetUniqueNameForSibling(UnityEngine.Transform parentTransform, System.String name) { }
        private System.Void DisplayProgressBar(System.String title, System.String info, System.Single progress) { }
        private System.Void ClearProgressBar() { }
        private System.Boolean IsEditorNotInPlayModeAndNotGoingToPlayMode() { }
        private System.Boolean DisplayDialog(System.String title, System.String message, System.String ok, System.String cancel) { }
        private System.Boolean DisplayErrorDialog(System.String title, System.String message, System.String ok, System.String cancel) { }
        private System.Void RevealInFinder(System.String path) { }
        private System.Void SetObjectDirtyForEditorUpdate(UnityEngine.Object obj) { }
        private System.Void SetStatic(UnityEngine.GameObject go, System.Boolean bStatic, System.Boolean bIncludeChildren) { }
        private System.Void SetIsHidden(UnityEngine.GameObject go, System.Boolean isHidden, System.Boolean bIncludeChildren) { }
        private UnityEngine.GameObject[] GetSelectedObjects() { }
        private HoudiniEngineUnity.HEU_HoudiniAssetRoot[] GetSelectedAssetRoots() { }
        private HoudiniEngineUnity.HEU_HoudiniAssetRoot[] GetAllAssetRoots() { }
        private System.Void CookSelected() { }
        private System.Void CookAll() { }
        private System.Void CookAssets(HoudiniEngineUnity.HEU_HoudiniAssetRoot[] rootAssets) { }
        private System.Void RebuildSelected() { }
        private System.Void RebuildAll() { }
        private System.Void RebuildAssets(HoudiniEngineUnity.HEU_HoudiniAssetRoot[] rootAssets) { }
        private System.Void BakeAndReplaceSelectedInScene() { }
        private System.Void BakeAndReplaceAllInScene() { }
        private System.Void BakeAndReplaceAssets(HoudiniEngineUnity.HEU_HoudiniAssetRoot[] rootAssets) { }
        private System.Void ExportSelectedAssetsToGeoFiles() { }
        private System.Void ExportAllAssetsToGeoFiles() { }
        private System.Void ExportAssetsToGeoFiles(HoudiniEngineUnity.HEU_HoudiniAssetRoot[] rootAssets) { }
        private System.String EditorSaveFolderPanel(System.String title, System.String folder, System.String defaultName) { }
        private System.Void QuerySelectedMeshTopology() { }
        private System.String GetObjectParentFolder(UnityEngine.GameObject parentObject, System.Collections.Generic.HashSet<UnityEngine.Material> generatedMaterials) { }
        private System.String GetObjectParentFolderHelper(System.Int32 instanceID) { }
        private System.Void RepaintScene() { }
        private System.Void SetTextureToNormalMap(System.String filename) { }
        private System.Boolean ReleasedMouse() { }

    }

    // TypeToken: 0x200011E
    public class HEU_Extensions
    {
        // Methods
        private System.Collections.Generic.List<R> Map(System.Collections.Generic.IEnumerable<T> self, System.Func<T,R> selector) { }
        private T Reduce(System.Collections.Generic.IEnumerable<T> self, System.Func<T,T,T> func) { }
        private System.Collections.Generic.List<T> Filter(System.Collections.Generic.IEnumerable<T> self, System.Func<T,System.Boolean> predicate) { }
        private System.Boolean IsValidIndex(System.Collections.Generic.List<T> self, System.Int32 index) { }
        private System.Boolean IsEquivalentList(System.Collections.Generic.List<T> self, System.Collections.Generic.List<T> other) { }
        private System.Boolean ApproximatelyEquals(UnityEngine.Quaternion quatA, UnityEngine.Quaternion value) { }
        private System.Collections.Generic.List<U> ConvertList(System.Collections.Generic.List<T> self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.IEquivable<T>> ConvertListToEquivable(System.Collections.Generic.List<T> self) { }
        private HoudiniEngineUnity.IEquivable<T>[] ConvertArrayToEquivable(T[] self) { }
        private System.Boolean ApproximatelyEquals(System.Single self, System.Single other, System.Single epsilon) { }
        private System.Byte[] AsByteArray(System.String self) { }
        private System.String AsString(System.Byte[] buffer) { }
        private UnityEngine.Vector3 SwapXAndY(UnityEngine.Vector3 self) { }
        private UnityEngine.Vector3 SwapXAndZ(UnityEngine.Vector3 self) { }
        private UnityEngine.Vector3 SwapYAndZ(UnityEngine.Vector3 self) { }
        private UnityEngine.Vector3 DecomposeToPosition(UnityEngine.Matrix4x4 self) { }
        private UnityEngine.Quaternion DecomposeToRotation(UnityEngine.Matrix4x4 self) { }
        private UnityEngine.Vector3 DecomposeToScale(UnityEngine.Matrix4x4 self) { }

    }

    // TypeToken: 0x200011F
    public class ArrayExtensions
    {
        // Methods
        private System.Void Init(T[] array, T defaultValue) { }
        private System.Void Init(System.Collections.Generic.List<T> array, T defaultValue) { }
        private System.Void CopyToWithResize(T[] srcArray, T[]& destArray) { }
        private System.Boolean IsEquivalentArray(T[] arr, T[] other) { }
        private System.Boolean IsNull(T[] arr) { }

    }

    // TypeToken: 0x2000120
    public class DictionaryExtensions
    {
        // Methods
        private System.Void AddOrSet(System.Collections.Generic.Dictionary<T,U> dict, T key, U value) { }

    }

    // TypeToken: 0x2000121
    public struct TransformData
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x10
        public UnityEngine.Quaternion rotation;        // 0x1C
        public UnityEngine.Vector3 localPosition;        // 0x2C
        public UnityEngine.Vector3 localScale;        // 0x38
        public UnityEngine.Quaternion localRotation;        // 0x44
        public UnityEngine.Transform parent;        // 0x58

        // Methods
        private System.Void .ctor(UnityEngine.Transform other) { }
        private System.Void CopyTo(UnityEngine.Transform other, System.Boolean copyParent) { }
        private System.Void CopyToLocal(UnityEngine.Transform other, System.Boolean copyParent) { }

    }

    // TypeToken: 0x2000122
    public class HEU_GeneralUtility
    {
        // Methods
        private System.Boolean GetArray1Arg(System.Int32 arg1, HoudiniEngineUnity.HEU_GeneralUtility.GetArray1ArgDel<T> func, T[] data, System.Int32 start, System.Int32 count) { }
        private System.Boolean GetArray2Arg(System.Int32 arg1, ARG2 arg2, HoudiniEngineUnity.HEU_GeneralUtility.GetArray2ArgDel<ARG2,T> func, T[] data, System.Int32 start, System.Int32 count) { }
        private System.Boolean GetArray3Arg(System.Int32 arg1, ARG2 arg2, ARG3 arg3, HoudiniEngineUnity.HEU_GeneralUtility.GetArray3ArgDel<ARG3,ARG2,T> func, T[] data, System.Int32 start, System.Int32 count) { }
        private System.Boolean GetArray(System.Int32 arg1, ARG2 arg2, ARG3 arg3, HoudiniEngineUnity.HEU_GeneralUtility.GetArray1ArgDel<T> func1, HoudiniEngineUnity.HEU_GeneralUtility.GetArray2ArgDel<ARG2,T> func2, HoudiniEngineUnity.HEU_GeneralUtility.GetArray3ArgDel<ARG3,ARG2,T> func3, T[] data, System.Int32 start, System.Int32 count, System.Int32 tupleSize) { }
        private System.Boolean SetArray1Arg(System.Int32 arg1, HoudiniEngineUnity.HEU_GeneralUtility.GetArray1ArgDel<T> func, T[] data, System.Int32 start, System.Int32 count) { }
        private System.Boolean SetArray2Arg(System.Int32 arg1, ARG2 arg2, HoudiniEngineUnity.HEU_GeneralUtility.GetArray2ArgDel<ARG2,T> func, T[] data, System.Int32 start, System.Int32 count) { }
        private System.Boolean SetArray(System.Int32 arg1, ARG2 arg2, HoudiniEngineUnity.HEU_GeneralUtility.GetArray1ArgDel<T> func1, HoudiniEngineUnity.HEU_GeneralUtility.GetArray2ArgDel<ARG2,T> func2, T[] data, System.Int32 start, System.Int32 count, System.Int32 tupleSize) { }
        private System.Boolean DoArrayElementsMatch(T[] array1, T[] array2) { }
        private System.Boolean DoArrayElementsMatch(T[] array1, System.Int32 startOffset1, T[] array2, System.Int32 startOffset2, System.Int32 length) { }
        private System.Boolean GetAttributeArray(System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[] items, HoudiniEngineUnity.HEU_GeneralUtility.GetAttributeArrayInputFunc<T> getFunc, System.Int32 count) { }
        private System.Boolean GetAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[]& data, HoudiniEngineUnity.HEU_GeneralUtility.GetAttributeArrayInputFunc<T> getFunc) { }
        private System.Boolean GetAttributeStrict(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HAPI_AttributeOwner attrOwner, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[]& data, HoudiniEngineUnity.HEU_GeneralUtility.GetAttributeArrayInputFunc<T> getFunc) { }
        private System.Void GetAttributeStringDataHelper(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, System.Int32[]& data) { }
        private System.String[] GetAttributeStringData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo) { }
        private System.String[] GetAttributeDataAsString(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo) { }
        private System.Boolean SetAttributeArray(System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, T[] items, HoudiniEngineUnity.HEU_GeneralUtility.SetAttributeArrayFunc<T> setFunc, System.Int32 count, System.Int32 start) { }
        private System.Boolean SetAttribute(System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, T[] items, HoudiniEngineUnity.HEU_GeneralUtility.SetAttributeArrayFunc<T> setFunc) { }
        private System.Boolean CheckAttributeExists(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attribName, HoudiniEngineUnity.HAPI_AttributeOwner attribOwner) { }
        private System.Boolean GetAttributeInfo(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attribName, HoudiniEngineUnity.HAPI_AttributeInfo& attribInfo) { }
        private System.Boolean HasValidInstanceAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attribName) { }
        private System.Void UpdateGeneratedAttributeStore(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject go) { }
        private HoudiniEngineUnity.HEU_OutputAttribute CreateOutputAttributeHelper(System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo) { }
        private HoudiniEngineUnity.HEU_OutputAttribute CreateOutputAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo) { }
        private System.Void CopyWorldTransformValues(UnityEngine.Transform src, UnityEngine.Transform dest) { }
        private System.Void ApplyTransformTo(UnityEngine.Transform src, UnityEngine.Transform target) { }
        private System.Void CopyLocalTransformValues(UnityEngine.Transform src, UnityEngine.Transform dest) { }
        private System.Collections.Generic.List<UnityEngine.GameObject> GetChildGameObjects(UnityEngine.GameObject parentGO) { }
        private System.Collections.Generic.List<UnityEngine.GameObject> GetChildGameObjectsWithNamePattern(UnityEngine.GameObject parentGO, System.String pattern, System.Boolean bExclude) { }
        private System.Collections.Generic.List<UnityEngine.GameObject> GetInstanceChildObjects(UnityEngine.GameObject parentGO) { }
        private System.Collections.Generic.List<UnityEngine.GameObject> GetNonInstanceChildObjects(UnityEngine.GameObject parentGO) { }
        private UnityEngine.GameObject GetGameObjectByName(System.Collections.Generic.List<UnityEngine.GameObject> goList, System.String name) { }
        private UnityEngine.GameObject GetGameObjectByNameInProjectOnly(System.String name) { }
        private System.Boolean IsGameObjectInProject(UnityEngine.GameObject go) { }
        private UnityEngine.GameObject GetGameObjectByNameInScene(System.String name) { }
        private HoudiniEngineUnity.HEU_HoudiniAssetRoot GetHDAByGameObjectNameInScene(System.String name) { }
        private T GetOrCreateComponent(UnityEngine.GameObject gameObject) { }
        private System.Void DestroyGeneratedComponents(UnityEngine.GameObject gameObject) { }
        private System.Void DestroyGeneratedMeshComponents(UnityEngine.GameObject gameObject) { }
        private System.Void DestroyTerrainComponents(UnityEngine.GameObject gameObject) { }
        private System.Void DestroyComponent(UnityEngine.GameObject gameObject) { }
        private System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean bAllowDestroyingAssets, System.Boolean bRegisterUndo) { }
        private System.Void DestroyBakedGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> gameObjectsToDestroy) { }
        private System.Void DestroyBakedGameObjectsWithEndName(System.Collections.Generic.List<UnityEngine.GameObject> gameObjectsToDestroy, System.String endName) { }
        private System.Void DestroyLODGroup(UnityEngine.GameObject targetGO, System.Boolean bDontDeletePersistantResources) { }
        private System.Collections.Generic.List<UnityEngine.Transform> GetLODTransforms(UnityEngine.GameObject targetGO) { }
        private System.Void SetLODTransformValues(UnityEngine.GameObject targetGO, System.Collections.Generic.List<HoudiniEngineUnity.TransformData> transformData) { }
        private System.Void DestroyGeneratedMeshMaterialsLODGroups(UnityEngine.GameObject targetGO, System.Boolean bDontDeletePersistantResources) { }
        private System.Void DestroyGeneratedMaterial(UnityEngine.Material material) { }
        private System.Void DestroyMeshCollider(UnityEngine.MeshCollider meshCollider, System.Boolean bDontDeletePersistantResources) { }
        private System.Void SetGameObjectRenderVisiblity(UnityEngine.GameObject gameObject, System.Boolean bVisible) { }
        private System.Void SetGameObjectChildrenRenderVisibility(UnityEngine.GameObject gameObject, System.Boolean bVisible) { }
        private System.Void SetGameObjectColliderState(UnityEngine.GameObject gameObject, System.Boolean bEnabled) { }
        private System.Void SetGameObjectChildrenColliderState(UnityEngine.GameObject gameObject, System.Boolean bVisible) { }
        private System.String ColorToString(UnityEngine.Color c) { }
        private UnityEngine.Color StringToColor(System.String colorString) { }
        private System.Boolean DoesUnityTagExist(System.String tagName) { }
        private System.Void SetLayer(UnityEngine.GameObject rootGO, System.Int32 layer, System.Boolean bIncludeChildren) { }
        private System.Void SetTag(UnityEngine.GameObject rootGO, System.String tag, System.Boolean bIncludeChildren) { }
        private System.Void CopyFlags(UnityEngine.GameObject srcGO, UnityEngine.GameObject dstGO, System.Boolean bIncludeChildren) { }
        private System.Boolean IsMouseWithinSceneView(UnityEngine.Camera camera, UnityEngine.Vector2 mousePosition) { }
        private System.Boolean IsMouseOverRect(UnityEngine.Camera camera, UnityEngine.Vector2 mousePosition, UnityEngine.Rect& rect) { }
        private System.Type GetSystemTypeByName(System.String typeName) { }
        private System.Void AssignUnityTag(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject gameObject) { }
        private System.Void AssignUnityLayer(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject gameObject) { }
        private System.Void MakeStaticIfHasAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject gameObject) { }
        private System.String GetUnityScriptAttributeValue(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID) { }
        private System.String GetAttributeStringValueSingle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeOwner attrOwner) { }
        private System.String GetAttributeStringValueSingleStrict(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeOwner attrOwner) { }
        private System.Boolean GetAttributeFloatSingle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Single& value) { }
        private System.Boolean GetAttributeIntSingle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32& value) { }
        private System.Boolean GetAttributeColorSingle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Color& value) { }
        private System.Boolean HasAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeOwner attrOwner) { }
        private System.Void AttachScriptWithInvokeFunction(System.String scriptSet, UnityEngine.GameObject gameObject) { }
        private System.Boolean IsInCameraView(UnityEngine.Camera camera, UnityEngine.Vector3 point) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> FindOrGenerateHandles(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_AssetInfo& assetInfo, System.Int32 assetID, System.String assetName, HoudiniEngineUnity.HEU_Parameters parameters, System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> currentHandles) { }
        private System.Void CopyComponents(UnityEngine.GameObject srcGO, UnityEngine.GameObject destGO) { }
        private UnityEngine.Texture LoadTextureFromFile(System.String filePath) { }
        private UnityEngine.Texture2D MakeTexture(System.Int32 width, System.Int32 height, UnityEngine.Color color) { }
        private System.String ReplaceFirstOccurrence(System.String srcStr, System.String searchStr, System.String replaceStr) { }
        private System.Void SetParentWithCleanTransform(UnityEngine.Transform parentTransform, UnityEngine.Transform childTransform) { }
        private System.Void CopyHAPITransform(HoudiniEngineUnity.HAPI_Transform& src, HoudiniEngineUnity.HAPI_Transform& dest) { }
        private System.String GetMaterialAttributeValueFromPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID) { }
        private System.Void ReplaceColliderMeshFromMeshFilter(UnityEngine.GameObject targetGO, UnityEngine.GameObject sourceColliderGO) { }
        private System.Void ReplaceColliderMeshFromMeshCollider(UnityEngine.GameObject targetGO, UnityEngine.GameObject sourceColliderGO) { }
        private System.Single BiLerpf(System.Single p00, System.Single p10, System.Single p01, System.Single p11, System.Single fracX, System.Single fracY) { }
        private System.Single Fractionalf(System.Single value) { }
        private System.String LongestCommonPrefix(System.Collections.Generic.List<System.String> list) { }
        private System.String GetRawOperatorName(System.String assetOpName) { }
        private UnityEngine.GameObject GetPrefabFromPath(System.String path) { }
        private System.Void ComposeNChildren(UnityEngine.GameObject parent, System.Int32 n, System.Collections.Generic.List<UnityEngine.GameObject>& childGameObjects, System.Boolean destroyIfExists) { }
        private System.Void DestroyChildWithName(UnityEngine.Transform parent, System.String name) { }
        private System.Void DestroyAutoGeneratedChildren(UnityEngine.GameObject parent) { }
        private UnityEngine.GameObject CreateNewGameObject(System.String name) { }
        private System.Void RenameGameObject(UnityEngine.GameObject obj, System.String name) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000128
    public class ReverseCompare, IComparer
    {
        // Methods
        private System.Int32 Compare(System.Object x, System.Object y) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000129
    public class HEU_GenerateGeoCache
    {
        // Fields
        private System.Int32 <AssetID>k__BackingField;        // 0x10
        public HoudiniEngineUnity.HAPI_GeoInfo _geoInfo;        // 0x14
        public HoudiniEngineUnity.HAPI_PartInfo _partInfo;        // 0x38
        public System.String _partName;        // 0x68
        public System.Int32[] _vertexList;        // 0x70
        public System.Int32[] _faceCounts;        // 0x78
        public System.Int32[] _houdiniMaterialIDs;        // 0x80
        public System.Boolean _singleFaceUnityMaterial;        // 0x88
        public System.Boolean _singleFaceHoudiniMaterial;        // 0x89
        public System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_UnityMaterialInfo> _unityMaterialInfos;        // 0x90
        public HoudiniEngineUnity.HAPI_AttributeInfo _unityMaterialAttrInfo;        // 0x98
        public System.Int32[] _unityMaterialAttrName;        // 0xC0
        public System.Collections.Generic.Dictionary<System.Int32,System.String> _unityMaterialAttrStringsMap;        // 0xC8
        public HoudiniEngineUnity.HAPI_AttributeInfo _substanceMaterialAttrNameInfo;        // 0xD0
        public System.Int32[] _substanceMaterialAttrName;        // 0xF8
        public System.Collections.Generic.Dictionary<System.Int32,System.String> _substanceMaterialAttrStringsMap;        // 0x100
        public HoudiniEngineUnity.HAPI_AttributeInfo _substanceMaterialAttrIndexInfo;        // 0x108
        public System.Int32[] _substanceMaterialAttrIndex;        // 0x130
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> _inUseMaterials;        // 0x138
        public HoudiniEngineUnity.HAPI_AttributeInfo _posAttrInfo;        // 0x140
        public HoudiniEngineUnity.HAPI_AttributeInfo[] _uvsAttrInfo;        // 0x168
        public HoudiniEngineUnity.HAPI_AttributeInfo _normalAttrInfo;        // 0x170
        public HoudiniEngineUnity.HAPI_AttributeInfo _colorAttrInfo;        // 0x198
        public HoudiniEngineUnity.HAPI_AttributeInfo _alphaAttrInfo;        // 0x1C0
        public HoudiniEngineUnity.HAPI_AttributeInfo _tangentAttrInfo;        // 0x1E8
        public System.Single[] _posAttr;        // 0x210
        public System.Single[][] _uvsAttr;        // 0x218
        public System.Single[] _normalAttr;        // 0x220
        public System.Single[] _colorAttr;        // 0x228
        public System.Single[] _alphaAttr;        // 0x230
        public System.Single[] _tangentAttr;        // 0x238
        public System.String[] _groups;        // 0x240
        public System.Boolean _hasGroupGeometry;        // 0x248
        public System.Collections.Generic.Dictionary<System.String,System.Int32[]> _groupSplitVertexIndices;        // 0x250
        public System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Int32>> _groupSplitFaceIndices;        // 0x258
        public System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Int32>> _groupVertexOffsets;        // 0x260
        public System.Int32[] _allCollisionVertexList;        // 0x268
        public System.Int32[] _allCollisionFaceIndices;        // 0x270
        public System.Single _normalCosineThreshold;        // 0x278
        public System.Boolean _hasLODGroups;        // 0x27C
        public System.Single[] _LODTransitionValues;        // 0x280
        public System.Boolean _isMeshReadWrite;        // 0x288
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo> _colliderInfos;        // 0x290
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> _materialCache;        // 0x298
        public System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MaterialData> _materialIDToDataMap;        // 0x2A0
        public System.String _assetCacheFolderPath;        // 0x2A8
        public HoudiniEngineUnity.HEU_MeshIndexFormat _meshIndexFormat;        // 0x2B0

        // Methods
        private System.Int32 get_GeoID() { }
        private System.Int32 get_PartID() { }
        private System.Int32 get_AssetID() { }
        private System.Void set_AssetID(System.Int32 value) { }
        private HoudiniEngineUnity.HEU_GenerateGeoCache GetPopulatedGeoCache(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, System.Int32 geoID, System.Int32 partID, System.Boolean bUseLODGroups, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath) { }
        private System.Void PopulateUnityMaterialData(HoudiniEngineUnity.HEU_SessionBase session) { }
        private System.Int32 GetMaterialKeyFromAttributeIndex(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Int32 attributeIndex, System.String& unityMaterialName, System.String& substanceName, System.Int32& substanceIndex) { }
        private System.Void CreateMaterialInfoEntryFromAttributeIndex(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Int32 materialAttributeIndex) { }
        private System.Boolean PopulateGeometryData(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bUseLODGroups) { }
        private System.Void ParseLODTransitionAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Single[]& LODTransitionValues) { }
        private System.Void UpdateColliders(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, HoudiniEngineUnity.HEU_GeneratedOutputData outputData) { }
        private System.Void UpdateCollider(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, HoudiniEngineUnity.HEU_GeneratedOutputData outputData, HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo colliderInfo) { }
        private System.Void GetFinalMaterialsFromComparingNewWithPrevious(UnityEngine.GameObject gameObject, UnityEngine.Material[] previousMaterials, UnityEngine.Material[] newMaterials, UnityEngine.Material[]& finalMaterials) { }
        private System.Boolean GenerateMeshFromSingleGroup(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GeoGroup GeoGroup, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, HoudiniEngineUnity.HEU_GeneratedOutput generatedOutput, System.Int32 defaultMaterialKey, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bPartInstanced) { }
        private System.Boolean GenerateLODMeshesFromGeoGroups(HoudiniEngineUnity.HEU_SessionBase session, System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoGroup> GeoGroupMeshes, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, HoudiniEngineUnity.HEU_GeneratedOutput generatedOutput, System.Int32 defaultMaterialKey, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bPartInstanced) { }
        private System.Boolean GenerateMeshFromGeoGroup(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GeoGroup GeoGroup, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Int32 defaultMaterialKey, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bPartInstanced, UnityEngine.Mesh& newMesh, UnityEngine.Material[]& newMaterials) { }
        private UnityEngine.Mesh CombineQuadMeshes(System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MeshData> subMeshesMap, System.Collections.Generic.List<System.Int32> subMeshIndices, System.Boolean bGenerateNormals) { }
        private UnityEngine.Mesh CombineMeshes(System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MeshData> subMeshesMap, System.Collections.Generic.List<System.Int32> submeshIndices, System.Boolean bGenerateUVs, System.Boolean bGenerateNormals, HoudiniEngineUnity.HEU_MeshIndexFormat meshIndexFormat) { }
        private UnityEngine.Mesh CreateMeshFromMeshData(HoudiniEngineUnity.HEU_MeshData submesh, System.Boolean bGenerateUVs, System.Boolean bGenerateNormals, HoudiniEngineUnity.HEU_MeshIndexFormat meshIndexFormat) { }
        private System.Void TransferRegularAttributesToVertices(System.Int32[] groupVertexList, System.Int32[] allFaceCounts, System.Collections.Generic.List<System.Int32> groupFaces, System.Collections.Generic.List<System.Int32> groupVertexOffset, HoudiniEngineUnity.HAPI_AttributeInfo& attribInfo, System.Single[] inData, System.Single[]& outData) { }
        private System.Boolean GenerateGeoGroupUsingGeoCacheVertices(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bUseLODGroups, System.Boolean bPartInstanced, System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoGroup>& LODGroupMeshes, System.Int32& defaultMaterialKey) { }
        private System.Boolean GenerateGeoGroupUsingGeoCachePoints(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bUseLODGroups, System.Boolean bPartInstanced, System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoGroup>& LODGroupMeshes, System.Int32& defaultMaterialKey) { }
        private System.Void GetSubmeshIDForFace(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Int32 faceMaterialID, System.Int32 groupFace, System.Int32 vertexFaceIndex, System.Int32[] groupVertexList, System.Int32 defaultMaterialKey, System.Int32& submeshID, System.Int32& singleFaceUnityMaterialKey, System.Int32& singleFaceHoudiniMaterialKey) { }
        private UnityEngine.MeshTopology CalculateGroupMeshTopology(System.Collections.Generic.List<System.Int32> groupFaces, System.Int32[] allFaceCounts) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012D
    public class HEU_GeoGroup, IComparable`1
    {
        // Fields
        public System.String _groupName;        // 0x10
        public System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MeshData> _subMeshesMap;        // 0x18
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_VertexEntry>[] _sharedNormalIndices;        // 0x20

        // Methods
        private System.Int32 CompareTo(HoudiniEngineUnity.HEU_GeoGroup other) { }
        private System.Void SetupNormalIndices(System.Int32 indicesCount) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012E
    public class HEU_VertexEntry
    {
        // Fields
        public System.Int32 _meshKey;        // 0x10
        public System.Int32 _vertexIndex;        // 0x14
        public System.Int32 _normalIndex;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 meshKey, System.Int32 vertexIndex, System.Int32 normalIndex) { }

    }

    // TypeToken: 0x200012F
    public class HEU_GeometryUtility
    {
        // Methods
        private UnityEngine.Vector2[] GeneratePerTriangle(UnityEngine.Mesh meshSrc) { }
        private System.Void GenerateSecondaryUVSet(UnityEngine.Mesh meshsrc) { }
        private System.Void CalculateMeshTangents(UnityEngine.Mesh mesh) { }
        private UnityEngine.Mesh GenerateCubeMeshFromPoints(UnityEngine.Vector3[] points, UnityEngine.Color[] pointsColor, System.Single size) { }
        private System.String GetInstanceOutputName(System.String partName, System.String[] userPrefix, System.Int32 index) { }

    }

    // TypeToken: 0x2000130
    public class HEU_InputData
    {
        // Fields
        public UnityEngine.GameObject _inputObject;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000131
    public class HEU_InputInterface
    {
        // Fields
        public static System.Int32 DEFAULT_PRIORITY;        // 0x0
        protected System.Int32 _priority;        // 0x10

        // Methods
        private System.Int32 get_Priority() { }
        private System.Void .ctor(System.Int32 priority) { }
        private System.Void RegisterInterface() { }
        private System.Boolean IsThisInputObjectSupported(UnityEngine.GameObject inputObject) { }
        private System.Boolean CreateInputNodeWithDataUpload(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 connectNodeID, UnityEngine.GameObject inputObject, System.Int32& inputNodeID) { }

    }

    // TypeToken: 0x2000132
    public class HEU_InputInterfaceMeshSettings
    {
        // Fields
        private System.Boolean _exportColliders;        // 0x10

        // Methods
        private System.Boolean get_ExportColliders() { }
        private System.Void set_ExportColliders(System.Boolean value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000133
    public class HEU_InputInterfaceMesh : HEU_InputInterface
    {
        // Fields
        private HoudiniEngineUnity.HEU_InputInterfaceMeshSettings settings;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void Initialize(HoudiniEngineUnity.HEU_InputInterfaceMeshSettings settings) { }
        private System.Boolean CreateInputNodeWithDataUpload(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 connectNodeID, UnityEngine.GameObject inputObject, System.Int32& inputNodeID) { }
        private System.Boolean IsThisInputObjectSupported(UnityEngine.GameObject inputObject) { }
        private System.Void GetUVsFromMesh(UnityEngine.Mesh mesh, UnityEngine.Vector2[] srcUVs, System.Collections.Generic.List<UnityEngine.Vector3> destUVs, System.Int32 index) { }
        private System.Boolean UploadData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 inputNodeID, HoudiniEngineUnity.HEU_InputData inputData) { }
        private System.Boolean UploadColliderData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 mergeNodeID, HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataMeshes inputData, System.Int32 parentNodeId) { }
        private System.Boolean UploadBoxColliderData(HoudiniEngineUnity.HEU_SessionBase session, UnityEngine.BoxCollider collider, System.Int32 inputIndex, System.Int32 parentNodeID, System.Int32& inputNodeID) { }
        private System.Boolean UploadSphereColliderData(HoudiniEngineUnity.HEU_SessionBase session, UnityEngine.SphereCollider collider, System.Int32 inputIndex, System.Int32 parentNodeID, System.Int32& inputNodeID) { }
        private System.Boolean UploadCapsuleColliderData(HoudiniEngineUnity.HEU_SessionBase session, UnityEngine.CapsuleCollider collider, System.Int32 inputIndex, System.Int32 parentNodeID, System.Int32& inputNodeID) { }
        private System.Boolean UploadMeshColliderData(HoudiniEngineUnity.HEU_SessionBase session, UnityEngine.MeshCollider collider, System.Int32 inputIndex, System.Int32 parentNodeID, System.Int32& inputNodeID) { }
        private System.String GetColliderGroupBaseName(UnityEngine.Collider collider, System.Boolean bIsConvex, System.Boolean bIsSimple, System.Boolean bIsRendered) { }
        private System.Boolean CreateInputNodeForCollider(HoudiniEngineUnity.HEU_SessionBase session, System.Int32& outNodeID, System.Int32 parentNodeId, System.Int32 colliderIndex, System.String colliderName, System.Single[] colliderVertices, System.Int32[] colliderIndices) { }
        private HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataMeshes GenerateMeshDatasFromGameObject(UnityEngine.GameObject inputObject, System.Boolean bExportColliders) { }
        private HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataMesh CreateSingleMeshData(UnityEngine.GameObject meshGameObject, System.Boolean bExportColliders) { }
        private UnityEngine.Mesh GetMeshFromObject(UnityEngine.GameObject meshGameObject) { }

    }

    // TypeToken: 0x2000138
    public class HEU_InputInterfaceTerrain : HEU_InputInterface
    {
        // Methods
        private System.Void .ctor() { }
        private System.Boolean CreateInputNodeWithDataUpload(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 connectNodeID, UnityEngine.GameObject inputObject, System.Int32& inputNodeID) { }
        private System.Boolean SetMaskLayer(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain idt, HoudiniEngineUnity.HAPI_VolumeInfo& baseVolumeInfo) { }
        private System.Boolean IsThisInputObjectSupported(UnityEngine.GameObject inputObject) { }
        private System.Boolean CreateHeightFieldInputNode(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain idt) { }
        private System.Boolean UploadHeightValuesWithTransform(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain idt, HoudiniEngineUnity.HAPI_VolumeInfo& volumeInfo) { }
        private System.Boolean UploadAlphaMaps(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain idt, HoudiniEngineUnity.HAPI_VolumeInfo& baseVolumeInfo, System.Boolean& bMaskSet) { }
        private System.Boolean SetHeightFieldData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 volumeNodeID, System.Int32 partID, System.Single[] heightValues, System.String heightFieldName, HoudiniEngineUnity.HAPI_VolumeInfo& baseVolumeInfo) { }
        private System.Boolean SetTerrainDataAttributesToHeightField(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoNodeID, System.Int32 partID, UnityEngine.TerrainData terrainData) { }
        private System.Boolean SetTerrainLayerAttributesToHeightField(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoNodeID, System.Int32 partID, UnityEngine.TerrainLayer terrainLayer) { }
        private System.Void SetTreePrototypes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoNodeID, System.Int32 partID, UnityEngine.TerrainData terrainData) { }
        private System.Void SetTreeInstances(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoNodeID, System.Int32 partID, UnityEngine.TerrainData terrainData) { }
        private HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain GenerateTerrainDataFromGameObject(UnityEngine.GameObject inputObject) { }

    }

    // TypeToken: 0x200013A
    public class HEU_InputInterfaceTilemapSettings
    {
        // Fields
        public System.Boolean _createGroupsForTiles;        // 0x10
        public System.Boolean _exportUnusedTiles;        // 0x11
        public System.Boolean _applyTileColor;        // 0x12
        public System.Boolean _applyTilemapOrientation;        // 0x13

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013B
    public class HEU_InputInterfaceTilemap : HEU_InputInterface
    {
        // Fields
        private HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings settings;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.Void Initialize(HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings settings) { }
        private System.Boolean CreateInputNodeWithDataUpload(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 connectNodeID, UnityEngine.GameObject inputObject, System.Int32& inputNodeID) { }
        private System.Boolean IsThisInputObjectSupported(UnityEngine.GameObject inputObject) { }
        private System.Boolean UploadData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 inputNodeID, HoudiniEngineUnity.HEU_InputData inputData) { }
        private HoudiniEngineUnity.HEU_InputInterfaceTilemap.HEU_InputDataTilemap GenerateTilemapDataFromGameObject(UnityEngine.GameObject inputObject) { }

    }

    // TypeToken: 0x200013D
    public class HEU_InputMeshUtility
    {
        // Methods
        private System.Boolean SetMeshPointAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, UnityEngine.Vector3[] data, HoudiniEngineUnity.HAPI_PartInfo& partInfo, System.Boolean bConvertToHoudiniCoordinateSystem) { }
        private System.Boolean SetMeshPointAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, System.Single[] data, HoudiniEngineUnity.HAPI_PartInfo& partInfo) { }
        private System.Boolean SetMeshVertexAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, UnityEngine.Vector3[] data, System.Int32[] indices, HoudiniEngineUnity.HAPI_PartInfo& partInfo, System.Boolean bConvertToHoudiniCoordinateSystem) { }
        private System.Boolean SetMeshVertexFloatAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, System.Single[] data, System.Int32[] indices, HoudiniEngineUnity.HAPI_PartInfo& partInfo) { }
        private System.Boolean UploadMeshIntoHoudiniNode(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetNodeID, System.Int32 objectID, System.Int32 geoID, UnityEngine.Mesh& mesh) { }
        private System.Boolean SetMeshPointAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, UnityEngine.Vector3Int[] data, HoudiniEngineUnity.HAPI_PartInfo& partInfo) { }
        private System.Boolean SetMeshPointAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.String[] data, HoudiniEngineUnity.HAPI_PartInfo& partInfo) { }
        private System.Boolean SetMeshDetailAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, UnityEngine.Vector3 data, HoudiniEngineUnity.HAPI_PartInfo& partInfo) { }

    }

    // TypeToken: 0x200013E
    public class HEU_InputUtility
    {
        // Fields
        private static System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputInterface> _inputInterfaces;        // 0x0

        // Methods
        private System.Int32 GetHighestPriority() { }
        private System.Void RegisterInputInterface(HoudiniEngineUnity.HEU_InputInterface inputInterface) { }
        private System.Void UnregisterInputInterface(HoudiniEngineUnity.HEU_InputInterface inputInterface) { }
        private HoudiniEngineUnity.HEU_InputInterface GetInputInterfaceByType(System.Type type) { }
        private HoudiniEngineUnity.HEU_InputInterface GetInputInterface(UnityEngine.GameObject inputObject) { }
        private HoudiniEngineUnity.HEU_InputInterface GetInputInterface(HoudiniEngineUnity.HEU_InputObjectInfo inputObjectInfo) { }
        private System.Boolean CreateInputNodeWithMultiObjects(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, System.Int32& connectMergeID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputObjectInfo>& inputObjects, System.Collections.Generic.List<System.Int32>& inputObjectsConnectedAssetIDs, HoudiniEngineUnity.HEU_InputNode inputNode) { }
        private System.Boolean CreateInputNodeWithMultiAssets(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Int32& connectMergeID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputHDAInfo>& inputAssetInfos, System.Boolean bKeepWorldTransform, System.Int32 mergeParentID) { }
        private System.Boolean UploadInputObjectTransform(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputObjectInfo inputObject, System.Int32 inputNodeID, System.Boolean bKeepWorldTransform) { }
        private System.Void GetChildrenTransforms(UnityEngine.Transform transform, System.Collections.Generic.List<UnityEngine.Matrix4x4>& childTransforms) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200013F
    public class HEU_Logger
    {
        // Methods
        private System.Void Log(System.String text) { }
        private System.Void LogFormat(System.String text, System.Object[] args) { }
        private System.Void LogWarning(System.String text) { }
        private System.Void LogWarningFormat(System.String text, System.Object[] args) { }
        private System.Void LogError(System.String text) { }
        private System.Void LogErrorFormat(System.String text, System.Object[] args) { }
        private System.Void LogError(System.Exception ex) { }
        private System.Void LogAssertion(System.String text) { }
        private System.Void LogAssertionFormat(System.String text, System.Object[] args) { }
        private System.Void LogToCookLogsIfOn(System.String text) { }
        private System.Void LogToCookLogsIfOnFormat(System.String text, System.Object[] args) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000140
    public class HEU_MeshData
    {
        // Fields
        public System.Collections.Generic.List<System.Int32> _indices;        // 0x10
        public System.Collections.Generic.List<UnityEngine.Vector3> _vertices;        // 0x18
        public System.Collections.Generic.List<UnityEngine.Color32> _colors;        // 0x20
        public System.Collections.Generic.List<UnityEngine.Vector3> _normals;        // 0x28
        public System.Collections.Generic.List<UnityEngine.Vector4> _tangents;        // 0x30
        public System.Collections.Generic.List<UnityEngine.Vector4>[] _uvs;        // 0x38
        public System.Collections.Generic.List<UnityEngine.Vector3> _triangleNormals;        // 0x40
        public System.Collections.Generic.Dictionary<System.Int32,System.Int32> _pointIndexToMeshIndexMap;        // 0x48
        public UnityEngine.MeshTopology _meshTopology;        // 0x50

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000141
    public class HEU_MeshIndexFormat
    {
        // Fields
        public UnityEngine.Rendering.IndexFormat _indexFormat;        // 0x10

        // Methods
        private System.Void CalculateIndexFormat(System.Int32 numVertices) { }
        private System.Void SetFormatForMesh(UnityEngine.Mesh mesh) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000142
    public struct HEU_PipelineType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HEU_PipelineType Unsupported;        // 0x0
        public static HoudiniEngineUnity.HEU_PipelineType BiRP;        // 0x0
        public static HoudiniEngineUnity.HEU_PipelineType URP;        // 0x0
        public static HoudiniEngineUnity.HEU_PipelineType HDRP;        // 0x0

    }

    // TypeToken: 0x2000143
    public class HEU_RenderingPipelineDefines
    {
        // Methods
        private System.Void .cctor() { }
        private System.Void UpdateDefines() { }
        private HoudiniEngineUnity.HEU_PipelineType GetPipeline() { }
        private System.Void AddDefine(System.String define) { }
        private System.Void RemoveDefine(System.String define) { }
        private System.Collections.Generic.List<System.String> GetDefines() { }
        private System.Void SetDefines(System.Collections.Generic.List<System.String> definesList) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000144
    public class HEU_SerializableDictionary`2, IDictionary`2, ICollection`1, IEnumerable`1, IEnumerable, ISerializationCallbackReceiver
    {
        // Fields
        private System.Collections.Generic.Dictionary<TKey,TValue> _dictionary;        // 0x0
        private TKey[] _keys;        // 0x0
        private TValue[] _values;        // 0x0

        // Methods
        private TValue get_Item(TKey key) { }
        private System.Void set_Item(TKey key, TValue value) { }
        private System.Collections.Generic.ICollection<TKey> get_Keys() { }
        private System.Collections.Generic.ICollection<TValue> get_Values() { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Void Add(TKey key, TValue value) { }
        private System.Void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        private System.Boolean ContainsKey(TKey key) { }
        private System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex) { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }
        private System.Boolean Remove(TKey key) { }
        private System.Boolean Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }
        private System.Boolean TryGetValue(TKey key, TValue& value) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void OnAfterDeserialize() { }
        private System.Void OnBeforeSerialize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000145
    public class HEU_ShelfToolData
    {
        // Fields
        public System.String _name;        // 0x10
        public HoudiniEngineUnity.HEU_ShelfToolData.ToolType _toolType;        // 0x18
        public System.String _toolTip;        // 0x20
        public System.String _iconPath;        // 0x28
        public System.String _assetPath;        // 0x30
        public System.String _helpURL;        // 0x38
        public System.String[] _targets;        // 0x40
        public System.String _jsonPath;        // 0x48

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000147
    public class HEU_Shelf
    {
        // Fields
        public System.String _shelfName;        // 0x10
        public System.String _shelfPath;        // 0x18
        public System.Boolean _defaultShelf;        // 0x20
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_ShelfToolData> _tools;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000148
    public class HEU_ShelfTools
    {
        // Fields
        private static System.Collections.Generic.List<HoudiniEngineUnity.HEU_Shelf> _shelves;        // 0x0
        private static System.Boolean _shelvesLoaded;        // 0x8
        private static System.Int32 _currentSelectedShelf;        // 0xC
        public static System.String TARGET_ALL;        // 0x0
        public static System.String TARGET_UNITY;        // 0x0

        // Methods
        private System.Boolean AreShelvesLoaded() { }
        private System.Void SetReloadShelves() { }
        private System.Void ClearShelves() { }
        private System.Int32 GetNumShelves() { }
        private System.Int32 GetCurrentShelfIndex() { }
        private System.Void SetCurrentShelf(System.Int32 index) { }
        private HoudiniEngineUnity.HEU_Shelf GetShelf(System.Int32 index) { }
        private HoudiniEngineUnity.HEU_Shelf GetShelf(System.String shelfName) { }
        private System.String GetShelfStorageEntry(System.String shelfName, System.String shelfPath) { }
        private System.Void GetSplitShelfEntry(System.String shelfEntry, System.String& shelfName, System.String& shelfPath) { }
        private System.Void LoadShelves() { }
        private System.Boolean LoadToolsFromDirectory(System.String folderPath, System.Collections.Generic.List<HoudiniEngineUnity.HEU_ShelfToolData>& tools) { }
        private HoudiniEngineUnity.HEU_ShelfToolData LoadToolFromJsonFile(System.String jsonFilePath) { }
        private HoudiniEngineUnity.HEU_ShelfToolData LoadToolFromJsonString(System.String json, System.String jsonFilePath) { }
        private HoudiniEngineUnity.HEU_Shelf AddShelf(System.String shelfName, System.String shelfPath) { }
        private System.Void RemoveShelf(System.Int32 shelfIndex) { }
        private System.Void SaveShelf() { }
        private System.Void ExecuteTool(System.Int32 toolSlot) { }
        private System.Void ExecuteToolGenerator(System.String toolName, System.String toolPath, UnityEngine.Vector3 targetPosition, UnityEngine.Quaternion targetRotation, UnityEngine.Vector3 targetScale) { }
        private System.Boolean IsValidInputMesh(UnityEngine.GameObject gameObject) { }
        private System.Boolean IsValidInputHDA(UnityEngine.GameObject gameObject) { }
        private System.Boolean ShouldUseHDA(UnityEngine.GameObject[] gameObjectList) { }
        private System.Void ExecuteToolNoInput(System.String toolName, System.String toolPath) { }
        private System.Void ExecuteToolOperatorSingle(System.String toolName, System.String toolPath, UnityEngine.GameObject[] inputObjects) { }
        private System.Void ExecuteToolOperatorMultiple(System.String toolName, System.String toolPath, UnityEngine.GameObject[] inputObjects) { }
        private System.Void ExecuteToolBatch(System.String toolName, System.String toolPath, UnityEngine.GameObject[] batchObjects) { }
        private System.String GetToolResourcePath(HoudiniEngineUnity.HEU_ShelfToolData tool, System.String inPath, System.String ext) { }
        private System.String GetToolIconPath(HoudiniEngineUnity.HEU_ShelfToolData tool, System.String inPath) { }
        private System.String GetToolAssetPath(HoudiniEngineUnity.HEU_ShelfToolData tool, System.String inPath) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200014A
    public struct JSONNodeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.JSONNodeType Array;        // 0x0
        public static HoudiniEngineUnity.JSONNodeType Object;        // 0x0
        public static HoudiniEngineUnity.JSONNodeType String;        // 0x0
        public static HoudiniEngineUnity.JSONNodeType Number;        // 0x0
        public static HoudiniEngineUnity.JSONNodeType NullValue;        // 0x0
        public static HoudiniEngineUnity.JSONNodeType Boolean;        // 0x0
        public static HoudiniEngineUnity.JSONNodeType None;        // 0x0
        public static HoudiniEngineUnity.JSONNodeType Custom;        // 0x0

    }

    // TypeToken: 0x200014B
    public struct JSONTextMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.JSONTextMode Compact;        // 0x0
        public static HoudiniEngineUnity.JSONTextMode Indent;        // 0x0

    }

    // TypeToken: 0x200014C
    public class JSONNode
    {
        // Fields
        public static System.Boolean forceASCII;        // 0x0
        public static System.Boolean longAsString;        // 0x1
        private static System.Text.StringBuilder m_EscapeBuilder;        // 0xFFFFFFFF
        public static HoudiniEngineUnity.JSONContainerType VectorContainerType;        // 0x4
        public static HoudiniEngineUnity.JSONContainerType QuaternionContainerType;        // 0x8
        public static HoudiniEngineUnity.JSONContainerType RectContainerType;        // 0xC

        // Methods
        private HoudiniEngineUnity.JSONNodeType get_Tag() { }
        private HoudiniEngineUnity.JSONNode get_Item(System.Int32 aIndex) { }
        private System.Void set_Item(System.Int32 aIndex, HoudiniEngineUnity.JSONNode value) { }
        private HoudiniEngineUnity.JSONNode get_Item(System.String aKey) { }
        private System.Void set_Item(System.String aKey, HoudiniEngineUnity.JSONNode value) { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsNumber() { }
        private System.Boolean get_IsString() { }
        private System.Boolean get_IsBoolean() { }
        private System.Boolean get_IsNull() { }
        private System.Boolean get_IsArray() { }
        private System.Boolean get_IsObject() { }
        private System.Boolean get_Inline() { }
        private System.Void set_Inline(System.Boolean value) { }
        private System.Void Add(System.String aKey, HoudiniEngineUnity.JSONNode aItem) { }
        private System.Void Add(HoudiniEngineUnity.JSONNode aItem) { }
        private HoudiniEngineUnity.JSONNode Remove(System.String aKey) { }
        private HoudiniEngineUnity.JSONNode Remove(System.Int32 aIndex) { }
        private HoudiniEngineUnity.JSONNode Remove(HoudiniEngineUnity.JSONNode aNode) { }
        private System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode> get_Children() { }
        private System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode> get_DeepChildren() { }
        private System.String ToString() { }
        private System.String ToString(System.Int32 aIndent) { }
        private System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode) { }
        private HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator() { }
        private System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode>> get_Linq() { }
        private HoudiniEngineUnity.JSONNode.KeyEnumerator get_Keys() { }
        private HoudiniEngineUnity.JSONNode.ValueEnumerator get_Values() { }
        private System.Double get_AsDouble() { }
        private System.Void set_AsDouble(System.Double value) { }
        private System.Int32 get_AsInt() { }
        private System.Void set_AsInt(System.Int32 value) { }
        private System.Single get_AsFloat() { }
        private System.Void set_AsFloat(System.Single value) { }
        private System.Boolean get_AsBool() { }
        private System.Void set_AsBool(System.Boolean value) { }
        private System.Int64 get_AsLong() { }
        private System.Void set_AsLong(System.Int64 value) { }
        private HoudiniEngineUnity.JSONArray get_AsArray() { }
        private HoudiniEngineUnity.JSONObject get_AsObject() { }
        private HoudiniEngineUnity.JSONNode op_Implicit(System.String s) { }
        private System.String op_Implicit(HoudiniEngineUnity.JSONNode d) { }
        private HoudiniEngineUnity.JSONNode op_Implicit(System.Double n) { }
        private System.Double op_Implicit(HoudiniEngineUnity.JSONNode d) { }
        private HoudiniEngineUnity.JSONNode op_Implicit(System.Single n) { }
        private System.Single op_Implicit(HoudiniEngineUnity.JSONNode d) { }
        private HoudiniEngineUnity.JSONNode op_Implicit(System.Int32 n) { }
        private System.Int32 op_Implicit(HoudiniEngineUnity.JSONNode d) { }
        private HoudiniEngineUnity.JSONNode op_Implicit(System.Int64 n) { }
        private System.Int64 op_Implicit(HoudiniEngineUnity.JSONNode d) { }
        private HoudiniEngineUnity.JSONNode op_Implicit(System.Boolean b) { }
        private System.Boolean op_Implicit(HoudiniEngineUnity.JSONNode d) { }
        private HoudiniEngineUnity.JSONNode op_Implicit(System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode> aKeyValue) { }
        private System.Boolean op_Equality(HoudiniEngineUnity.JSONNode a, System.Object b) { }
        private System.Boolean op_Inequality(HoudiniEngineUnity.JSONNode a, System.Object b) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Text.StringBuilder get_EscapeBuilder() { }
        private System.String Escape(System.String aText) { }
        private HoudiniEngineUnity.JSONNode ParseElement(System.String token, System.Boolean quoted) { }
        private HoudiniEngineUnity.JSONNode Parse(System.String aJSON) { }
        private HoudiniEngineUnity.JSONNode GetContainer(HoudiniEngineUnity.JSONContainerType aType) { }
        private HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Vector2 aVec) { }
        private HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Vector3 aVec) { }
        private HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Vector4 aVec) { }
        private HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Quaternion aRot) { }
        private HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Rect aRect) { }
        private HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.RectOffset aRect) { }
        private UnityEngine.Vector2 op_Implicit(HoudiniEngineUnity.JSONNode aNode) { }
        private UnityEngine.Vector3 op_Implicit(HoudiniEngineUnity.JSONNode aNode) { }
        private UnityEngine.Vector4 op_Implicit(HoudiniEngineUnity.JSONNode aNode) { }
        private UnityEngine.Quaternion op_Implicit(HoudiniEngineUnity.JSONNode aNode) { }
        private UnityEngine.Rect op_Implicit(HoudiniEngineUnity.JSONNode aNode) { }
        private UnityEngine.RectOffset op_Implicit(HoudiniEngineUnity.JSONNode aNode) { }
        private UnityEngine.Vector2 ReadVector2(UnityEngine.Vector2 aDefault) { }
        private UnityEngine.Vector2 ReadVector2(System.String aXName, System.String aYName) { }
        private UnityEngine.Vector2 ReadVector2() { }
        private HoudiniEngineUnity.JSONNode WriteVector2(UnityEngine.Vector2 aVec, System.String aXName, System.String aYName) { }
        private UnityEngine.Vector3 ReadVector3(UnityEngine.Vector3 aDefault) { }
        private UnityEngine.Vector3 ReadVector3(System.String aXName, System.String aYName, System.String aZName) { }
        private UnityEngine.Vector3 ReadVector3() { }
        private HoudiniEngineUnity.JSONNode WriteVector3(UnityEngine.Vector3 aVec, System.String aXName, System.String aYName, System.String aZName) { }
        private UnityEngine.Vector4 ReadVector4(UnityEngine.Vector4 aDefault) { }
        private UnityEngine.Vector4 ReadVector4() { }
        private HoudiniEngineUnity.JSONNode WriteVector4(UnityEngine.Vector4 aVec) { }
        private UnityEngine.Quaternion ReadQuaternion(UnityEngine.Quaternion aDefault) { }
        private UnityEngine.Quaternion ReadQuaternion() { }
        private HoudiniEngineUnity.JSONNode WriteQuaternion(UnityEngine.Quaternion aRot) { }
        private UnityEngine.Rect ReadRect(UnityEngine.Rect aDefault) { }
        private UnityEngine.Rect ReadRect() { }
        private HoudiniEngineUnity.JSONNode WriteRect(UnityEngine.Rect aRect) { }
        private UnityEngine.RectOffset ReadRectOffset(UnityEngine.RectOffset aDefault) { }
        private UnityEngine.RectOffset ReadRectOffset() { }
        private HoudiniEngineUnity.JSONNode WriteRectOffset(UnityEngine.RectOffset aRect) { }
        private UnityEngine.Matrix4x4 ReadMatrix() { }
        private HoudiniEngineUnity.JSONNode WriteMatrix(UnityEngine.Matrix4x4 aMatrix) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000154
    public class JSONArray : JSONNode
    {
        // Fields
        private System.Collections.Generic.List<HoudiniEngineUnity.JSONNode> m_List;        // 0x10
        private System.Boolean inline;        // 0x18

        // Methods
        private System.Boolean get_Inline() { }
        private System.Void set_Inline(System.Boolean value) { }
        private HoudiniEngineUnity.JSONNodeType get_Tag() { }
        private System.Boolean get_IsArray() { }
        private HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator() { }
        private HoudiniEngineUnity.JSONNode get_Item(System.Int32 aIndex) { }
        private System.Void set_Item(System.Int32 aIndex, HoudiniEngineUnity.JSONNode value) { }
        private HoudiniEngineUnity.JSONNode get_Item(System.String aKey) { }
        private System.Void set_Item(System.String aKey, HoudiniEngineUnity.JSONNode value) { }
        private System.Int32 get_Count() { }
        private System.Void Add(System.String aKey, HoudiniEngineUnity.JSONNode aItem) { }
        private HoudiniEngineUnity.JSONNode Remove(System.Int32 aIndex) { }
        private HoudiniEngineUnity.JSONNode Remove(HoudiniEngineUnity.JSONNode aNode) { }
        private System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode> get_Children() { }
        private System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000156
    public class JSONObject : JSONNode
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.JSONNode> m_Dict;        // 0x10
        private System.Boolean inline;        // 0x18

        // Methods
        private System.Boolean get_Inline() { }
        private System.Void set_Inline(System.Boolean value) { }
        private HoudiniEngineUnity.JSONNodeType get_Tag() { }
        private System.Boolean get_IsObject() { }
        private HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator() { }
        private HoudiniEngineUnity.JSONNode get_Item(System.String aKey) { }
        private System.Void set_Item(System.String aKey, HoudiniEngineUnity.JSONNode value) { }
        private HoudiniEngineUnity.JSONNode get_Item(System.Int32 aIndex) { }
        private System.Void set_Item(System.Int32 aIndex, HoudiniEngineUnity.JSONNode value) { }
        private System.Int32 get_Count() { }
        private System.Void Add(System.String aKey, HoudiniEngineUnity.JSONNode aItem) { }
        private HoudiniEngineUnity.JSONNode Remove(System.String aKey) { }
        private HoudiniEngineUnity.JSONNode Remove(System.Int32 aIndex) { }
        private HoudiniEngineUnity.JSONNode Remove(HoudiniEngineUnity.JSONNode aNode) { }
        private System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode> get_Children() { }
        private System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000159
    public class JSONString : JSONNode
    {
        // Fields
        private System.String m_Data;        // 0x10

        // Methods
        private HoudiniEngineUnity.JSONNodeType get_Tag() { }
        private System.Boolean get_IsString() { }
        private HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator() { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Void .ctor(System.String aData) { }
        private System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200015A
    public class JSONNumber : JSONNode
    {
        // Fields
        private System.Double m_Data;        // 0x10

        // Methods
        private HoudiniEngineUnity.JSONNodeType get_Tag() { }
        private System.Boolean get_IsNumber() { }
        private HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator() { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Double get_AsDouble() { }
        private System.Void set_AsDouble(System.Double value) { }
        private System.Int64 get_AsLong() { }
        private System.Void set_AsLong(System.Int64 value) { }
        private System.Void .ctor(System.Double aData) { }
        private System.Void .ctor(System.String aData) { }
        private System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode) { }
        private System.Boolean IsNumeric(System.Object value) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200015B
    public class JSONBool : JSONNode
    {
        // Fields
        private System.Boolean m_Data;        // 0x10

        // Methods
        private HoudiniEngineUnity.JSONNodeType get_Tag() { }
        private System.Boolean get_IsBoolean() { }
        private HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator() { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Boolean get_AsBool() { }
        private System.Void set_AsBool(System.Boolean value) { }
        private System.Void .ctor(System.Boolean aData) { }
        private System.Void .ctor(System.String aData) { }
        private System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200015C
    public class JSONNull : JSONNode
    {
        // Fields
        private static HoudiniEngineUnity.JSONNull m_StaticInstance;        // 0x0
        public static System.Boolean reuseSameInstance;        // 0x8

        // Methods
        private HoudiniEngineUnity.JSONNull CreateOrGet() { }
        private System.Void .ctor() { }
        private HoudiniEngineUnity.JSONNodeType get_Tag() { }
        private System.Boolean get_IsNull() { }
        private HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator() { }
        private System.String get_Value() { }
        private System.Void set_Value(System.String value) { }
        private System.Boolean get_AsBool() { }
        private System.Void set_AsBool(System.Boolean value) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200015D
    public class JSONLazyCreator : JSONNode
    {
        // Fields
        private HoudiniEngineUnity.JSONNode m_Node;        // 0x10
        private System.String m_Key;        // 0x18

        // Methods
        private HoudiniEngineUnity.JSONNodeType get_Tag() { }
        private HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator() { }
        private System.Void .ctor(HoudiniEngineUnity.JSONNode aNode) { }
        private System.Void .ctor(HoudiniEngineUnity.JSONNode aNode, System.String aKey) { }
        private T Set(T aVal) { }
        private HoudiniEngineUnity.JSONNode get_Item(System.Int32 aIndex) { }
        private System.Void set_Item(System.Int32 aIndex, HoudiniEngineUnity.JSONNode value) { }
        private HoudiniEngineUnity.JSONNode get_Item(System.String aKey) { }
        private System.Void set_Item(System.String aKey, HoudiniEngineUnity.JSONNode value) { }
        private System.Void Add(HoudiniEngineUnity.JSONNode aItem) { }
        private System.Void Add(System.String aKey, HoudiniEngineUnity.JSONNode aItem) { }
        private System.Boolean op_Equality(HoudiniEngineUnity.JSONLazyCreator a, System.Object b) { }
        private System.Boolean op_Inequality(HoudiniEngineUnity.JSONLazyCreator a, System.Object b) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Int32 get_AsInt() { }
        private System.Void set_AsInt(System.Int32 value) { }
        private System.Single get_AsFloat() { }
        private System.Void set_AsFloat(System.Single value) { }
        private System.Double get_AsDouble() { }
        private System.Void set_AsDouble(System.Double value) { }
        private System.Int64 get_AsLong() { }
        private System.Void set_AsLong(System.Int64 value) { }
        private System.Boolean get_AsBool() { }
        private System.Void set_AsBool(System.Boolean value) { }
        private HoudiniEngineUnity.JSONArray get_AsArray() { }
        private HoudiniEngineUnity.JSONObject get_AsObject() { }
        private System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode) { }

    }

    // TypeToken: 0x200015E
    public class JSON
    {
        // Methods
        private HoudiniEngineUnity.JSONNode Parse(System.String aJSON) { }

    }

    // TypeToken: 0x200015F
    public struct JSONContainerType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.JSONContainerType Array;        // 0x0
        public static HoudiniEngineUnity.JSONContainerType Object;        // 0x0

    }

    // TypeToken: 0x2000160
    public class HEU_TerrainUtility
    {
        // Methods
        private System.Boolean GenerateTerrainFromVolume(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_VolumeInfo& volumeInfo, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject gameObject, UnityEngine.TerrainData& terrainData, UnityEngine.Vector3& volumePositionOffset, UnityEngine.Terrain& terrain, System.String bakedMaterialPath) { }
        private System.Void SetTerrainMaterial(UnityEngine.Terrain terrain, System.String specifiedMaterialName, System.String bakedMaterialPath) { }
        private System.String GetDefaultTerrainShaderName() { }
        private System.String GetDefaultTerrainMaterialPath() { }
        private System.Single[] GetNormalizedHeightmapFromPartWithMinMax(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32 heightMapWidth, System.Int32 heightMapHeight, System.Single& minHeight, System.Single& maxHeight, System.Single& heightRange, System.Boolean bUseHeightRangeOverride) { }
        private System.Int32[,] GetDetailMapFromPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32& detailResolution) { }
        private System.Boolean GetHeightmapFromPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 xLength, System.Int32 yLength, System.Int32 geoID, System.Int32 partID, System.Single[]& heightValues, System.Single& minHeight, System.Single& maxHeight) { }
        private System.Single[,] ConvertHeightMapHoudiniToUnity(System.Int32 heightMapWidth, System.Int32 heightMapHeight, System.Single[] heightValues) { }
        private System.Single[,,] ConvertHeightFieldToAlphaMap(System.Int32 heightMapWidth, System.Int32 heightMapHeight, System.Collections.Generic.List<System.Single[]> heightFields) { }
        private System.Single[,,] AppendConvertedHeightFieldToAlphaMap(System.Int32 heightMapWidth, System.Int32 heightMapHeight, System.Single[,,] existingAlphaMaps, System.Collections.Generic.List<System.Single[]> heightFields, System.Single[] strengths, System.Collections.Generic.List<System.Int32> alphaMapIndices) { }
        private UnityEngine.Vector3 GetVolumePositionOffset(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.Vector3 volumePosition, System.Single terrainSizeX, System.Single heightMapSize, System.Int32 mapWidth, System.Int32 mapHeight, System.Single minHeight) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_TreePrototypeInfo> GetTreePrototypeInfosFromPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID) { }
        private System.Void PopulateScatterTrees(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32 pointCount, HoudiniEngineUnity.HEU_VolumeScatterTrees& scatterTrees, System.Boolean throwWarningIfNoTileAttribute) { }
        private System.Void ApplyScatterTrees(UnityEngine.TerrainData terrainData, HoudiniEngineUnity.HEU_VolumeScatterTrees scatterTrees, System.Int32 tileIndex) { }
        private System.Void PopulateDetailPrototype(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_DetailPrototype& detailPrototype) { }
        private System.Void PopulateDetailProperties(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_DetailProperties& detailProperties) { }
        private System.Void ApplyDetailLayers(UnityEngine.Terrain terrain, UnityEngine.TerrainData terrainData, HoudiniEngineUnity.HEU_DetailProperties detailProperties, System.Collections.Generic.List<HoudiniEngineUnity.HEU_DetailPrototype> heuDetailPrototypes, System.Collections.Generic.List<System.Int32[,]> convertedDetailMaps) { }
        private System.Int32 GetTerrainLayerIndexByName(System.String layerName, UnityEngine.TerrainLayer[] terrainLayers) { }
        private System.Int32 GetTerrainLayerIndex(UnityEngine.TerrainLayer layer, UnityEngine.TerrainLayer[] terrainLayers) { }
        private System.Boolean VolumeLayerHasAttributes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID) { }
        private HoudiniEngineUnity.HFLayerType GetHeightfieldLayerType(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String volumeName) { }
        private System.Single GetHeightRangeFromHeightfield(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID) { }
        private System.String GetTerrainDataExportPathFromHeightfieldAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID) { }
        private System.Single[] ResampleData(System.Single[] data, System.Int32 oldWidth, System.Int32 oldHeight, System.Int32 newWidth, System.Int32 newHeight) { }
        private System.Boolean GetAttributeTile(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32& outTileAttribute) { }

    }

    // TypeToken: 0x2000161
    public interface IEquivable`1
    {
        // Methods
        private System.Boolean IsEquivalentTo(T other) { }

    }

    // TypeToken: 0x2000162
    public interface IEquivableWrapperClass`1 : IEquivable`1
    {
        // Methods
        private System.Boolean IsNull() { }

    }

    // TypeToken: 0x2000163
    public class HEU_TestHelpers
    {
        // Methods
        private System.Boolean AssertTrueLogEquivalent(T a, T b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3, HoudiniEngineUnity.HEU_TestHelpers.RequireStruct<T> _) { }
        private System.Boolean AssertTrueLogEquivalent(UnityEngine.GameObject a, UnityEngine.GameObject b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        private System.Boolean AssertTrueLogEquivalent(HoudiniEngineUnity.IEquivable<T> a, HoudiniEngineUnity.IEquivable<T> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        private System.Boolean AssertTrueLogEquivalent(HoudiniEngineUnity.IEquivableWrapperClass<T> a, HoudiniEngineUnity.IEquivableWrapperClass<T> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        private System.Boolean AssertTrueLogEquivalent(System.String a, System.String b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        private System.Boolean AssertTrueLogEquivalent(System.Collections.Generic.List<T> a, System.Collections.Generic.List<T> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3, HoudiniEngineUnity.HEU_TestHelpers.RequireStruct<T> _) { }
        private System.Boolean AssertTrueLogEquivalent(System.Collections.Generic.List<T> a, System.Collections.Generic.List<T> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3, HoudiniEngineUnity.HEU_TestHelpers.RequireClass<T> _) { }
        private System.Boolean AssertTrueLogEquivalent(System.Collections.Generic.List<HoudiniEngineUnity.IEquivable<T>> a, System.Collections.Generic.List<HoudiniEngineUnity.IEquivable<T>> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        private System.Boolean AssertTrueLogEquivalent(System.Collections.Generic.List<HoudiniEngineUnity.IEquivableWrapperClass<T>> a, System.Collections.Generic.List<HoudiniEngineUnity.IEquivableWrapperClass<T>> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        private System.Boolean AssertTrueLogEquivalent(T[] a, T[] b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        private System.Boolean AssertTrueLogEquivalent(System.String[] a, System.String[] b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        private System.Boolean AssertTrueLogEquivalent(HoudiniEngineUnity.IEquivable<T>[] a, HoudiniEngineUnity.IEquivable<T>[] b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        private System.Boolean AssertTrueLogEquivalent(HoudiniEngineUnity.IEquivableWrapperClass<T>[] a, HoudiniEngineUnity.IEquivableWrapperClass<T>[] b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        private System.Void PrintTestLogAndSetResult(System.Boolean expression, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3) { }
        private System.Boolean ShouldBeTested(T a, T b, System.Boolean& bResult, System.String header, System.String subject) { }
        private System.Boolean ShouldBeTested(UnityEngine.GameObject a, UnityEngine.GameObject b, System.Boolean& bResult, System.String header, System.String subject) { }
        private System.Boolean ShouldBeTested(HoudiniEngineUnity.IEquivable<T> a, HoudiniEngineUnity.IEquivable<T> b, System.Boolean& bResult, System.String header, System.String subject) { }
        private System.Boolean ShouldBeTested(HoudiniEngineUnity.IEquivableWrapperClass<T> a, HoudiniEngineUnity.IEquivableWrapperClass<T> b, System.Boolean& bResult, System.String header, System.String subject) { }
        private System.Boolean ShouldBeTested(System.Collections.Generic.List<T> a, System.Collections.Generic.List<T> b, System.Boolean& bResult, System.String header, System.String subject) { }
        private System.Boolean ShouldBeTested(T[] a, T[] b, System.Boolean& bResult, System.String header, System.String subject) { }
        private System.Boolean ShouldBeTested(System.String a, System.String b, System.Boolean& bResult, System.String header, System.String subject) { }
        private System.Boolean TestOutputObjectEquivalence(UnityEngine.GameObject a, UnityEngine.GameObject b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000166
    public class Test_HAPI_AssetInfo, IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_AssetInfo self;        // 0x10

        // Methods
        private System.Void .ctor(HoudiniEngineUnity.HAPI_AssetInfo self) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_AssetInfo other) { }

    }

    // TypeToken: 0x2000167
    public class Test_HAPI_AssetInfo_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_HAPI_AssetInfo ToTestObject(HoudiniEngineUnity.HAPI_AssetInfo self) { }

    }

    // TypeToken: 0x2000168
    public class Test_HAPI_NodeInfo, IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_NodeInfo self;        // 0x10

        // Methods
        private System.Void .ctor(HoudiniEngineUnity.HAPI_NodeInfo self) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_NodeInfo other) { }

    }

    // TypeToken: 0x2000169
    public class Test_HAPI_NodeInfo_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_HAPI_NodeInfo ToTestObject(HoudiniEngineUnity.HAPI_NodeInfo self) { }

    }

    // TypeToken: 0x200016A
    public class Test_HAPI_ObjectInfo, IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_ObjectInfo self;        // 0x10

        // Methods
        private System.Void .ctor(HoudiniEngineUnity.HAPI_ObjectInfo self) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_ObjectInfo other) { }

    }

    // TypeToken: 0x200016B
    public class Test_HAPI_ObjectInfo_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_HAPI_ObjectInfo ToTestObject(HoudiniEngineUnity.HAPI_ObjectInfo self) { }

    }

    // TypeToken: 0x200016C
    public class Test_HAPI_Transform, IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_Transform self;        // 0x10

        // Methods
        private System.Void .ctor(HoudiniEngineUnity.HAPI_Transform self) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_Transform other) { }

    }

    // TypeToken: 0x200016D
    public class Test_HAPI_Transform_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_HAPI_Transform ToTestObject(HoudiniEngineUnity.HAPI_Transform self) { }

    }

    // TypeToken: 0x200016E
    public class Test_HAPI_GeoInfo, IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_GeoInfo self;        // 0x10

        // Methods
        private System.Void .ctor(HoudiniEngineUnity.HAPI_GeoInfo self) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_GeoInfo other) { }

    }

    // TypeToken: 0x200016F
    public class Test_HAPI_GeoInfo_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_HAPI_GeoInfo ToTestObject(HoudiniEngineUnity.HAPI_GeoInfo self) { }

    }

    // TypeToken: 0x2000170
    public class Test_HAPI_AttributeInfo, IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_AttributeInfo self;        // 0x10

        // Methods
        private System.Void .ctor(HoudiniEngineUnity.HAPI_AttributeInfo self) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_AttributeInfo other) { }

    }

    // TypeToken: 0x2000171
    public class Test_HAPI_AttributeInfo_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_HAPI_AttributeInfo ToTestObject(HoudiniEngineUnity.HAPI_AttributeInfo self) { }

    }

    // TypeToken: 0x2000172
    public class Test_HAPI_TransformEuler, IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_TransformEuler self;        // 0x10

        // Methods
        private System.Void .ctor(HoudiniEngineUnity.HAPI_TransformEuler self) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_TransformEuler other) { }

    }

    // TypeToken: 0x2000173
    public class Test_HAPI_TransformEuler_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_HAPI_TransformEuler ToTestObject(HoudiniEngineUnity.HAPI_TransformEuler self) { }

    }

    // TypeToken: 0x2000174
    public class Test_HAPI_ParmInfo, IEquivable`1
    {
        // Fields
        public HoudiniEngineUnity.HAPI_ParmInfo self;        // 0x10

        // Methods
        private System.Void .ctor(HoudiniEngineUnity.HAPI_ParmInfo self) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_ParmInfo other) { }

    }

    // TypeToken: 0x2000175
    public class Test_HAPI_ParmInfo_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_HAPI_ParmInfo ToTestObject(HoudiniEngineUnity.HAPI_ParmInfo self) { }

    }

    // TypeToken: 0x2000176
    public class Test_LODGroup, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.LODGroup self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.LODGroup self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_LODGroup other) { }

    }

    // TypeToken: 0x2000177
    public class Test_LODGroup_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_LODGroup ToTestObject(UnityEngine.LODGroup self) { }
        private HoudiniEngineUnity.Test_LODGroup[] ToTestObject(UnityEngine.LODGroup[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_LODGroup> ToTestObject(System.Collections.Generic.List<UnityEngine.LODGroup> self) { }

    }

    // TypeToken: 0x2000179
    public class Test_Transform, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.Transform self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.Transform self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Transform other) { }

    }

    // TypeToken: 0x200017A
    public class Test_Transform_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_Transform ToTestObject(UnityEngine.Transform self) { }
        private HoudiniEngineUnity.Test_Transform[] ToTestObject(UnityEngine.Transform[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_Transform> ToTestObject(System.Collections.Generic.List<UnityEngine.Transform> self) { }

    }

    // TypeToken: 0x200017C
    public class Test_Material, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.Material self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.Material self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Material other) { }

    }

    // TypeToken: 0x200017D
    public class Test_Material_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_Material ToTestObject(UnityEngine.Material self) { }
        private HoudiniEngineUnity.Test_Material[] ToTestObject(UnityEngine.Material[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_Material> ToTestObject(System.Collections.Generic.List<UnityEngine.Material> self) { }

    }

    // TypeToken: 0x200017F
    public class Test_Collider, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.Collider self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.Collider self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Collider other) { }

    }

    // TypeToken: 0x2000180
    public class Test_Collider_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_Collider ToTestObject(UnityEngine.Collider self) { }
        private HoudiniEngineUnity.Test_Collider[] ToTestObject(UnityEngine.Collider[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_Collider> ToTestObject(System.Collections.Generic.List<UnityEngine.Collider> self) { }

    }

    // TypeToken: 0x2000182
    public class Test_BoxCollider, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.BoxCollider self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.BoxCollider self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_BoxCollider other) { }

    }

    // TypeToken: 0x2000183
    public class Test_BoxCollider_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_BoxCollider ToTestObject(UnityEngine.BoxCollider self) { }
        private HoudiniEngineUnity.Test_BoxCollider[] ToTestObject(UnityEngine.BoxCollider[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_BoxCollider> ToTestObject(System.Collections.Generic.List<UnityEngine.BoxCollider> self) { }

    }

    // TypeToken: 0x2000185
    public class Test_SphereCollider, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.SphereCollider self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.SphereCollider self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_SphereCollider other) { }

    }

    // TypeToken: 0x2000186
    public class Test_SphereCollider_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_SphereCollider ToTestObject(UnityEngine.SphereCollider self) { }
        private HoudiniEngineUnity.Test_SphereCollider[] ToTestObject(UnityEngine.SphereCollider[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_SphereCollider> ToTestObject(System.Collections.Generic.List<UnityEngine.SphereCollider> self) { }

    }

    // TypeToken: 0x2000188
    public class Test_CapsuleCollider, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.CapsuleCollider self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.CapsuleCollider self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_CapsuleCollider other) { }

    }

    // TypeToken: 0x2000189
    public class Test_CapsuleCollider_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_CapsuleCollider ToTestObject(UnityEngine.CapsuleCollider self) { }
        private HoudiniEngineUnity.Test_CapsuleCollider[] ToTestObject(UnityEngine.CapsuleCollider[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_CapsuleCollider> ToTestObject(System.Collections.Generic.List<UnityEngine.CapsuleCollider> self) { }

    }

    // TypeToken: 0x200018B
    public class Test_MeshCollider, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.MeshCollider self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.MeshCollider self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_MeshCollider other) { }

    }

    // TypeToken: 0x200018C
    public class Test_MeshCollider_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_MeshCollider ToTestObject(UnityEngine.MeshCollider self) { }
        private HoudiniEngineUnity.Test_MeshCollider[] ToTestObject(UnityEngine.MeshCollider[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_MeshCollider> ToTestObject(System.Collections.Generic.List<UnityEngine.MeshCollider> self) { }

    }

    // TypeToken: 0x200018E
    public class Test_Mesh, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.Mesh self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.Mesh self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Mesh other) { }

    }

    // TypeToken: 0x200018F
    public class Test_Mesh_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_Mesh ToTestObject(UnityEngine.Mesh self) { }
        private HoudiniEngineUnity.Test_Mesh[] ToTestObject(UnityEngine.Mesh[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_Mesh> ToTestObject(System.Collections.Generic.List<UnityEngine.Mesh> self) { }

    }

    // TypeToken: 0x2000191
    public class Test_MeshRenderer, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.MeshRenderer self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.MeshRenderer self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_MeshRenderer other) { }

    }

    // TypeToken: 0x2000192
    public class Test_MeshRenderer_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_MeshRenderer ToTestObject(UnityEngine.MeshRenderer self) { }
        private HoudiniEngineUnity.Test_MeshRenderer[] ToTestObject(UnityEngine.MeshRenderer[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_MeshRenderer> ToTestObject(System.Collections.Generic.List<UnityEngine.MeshRenderer> self) { }

    }

    // TypeToken: 0x2000194
    public class Test_MeshFilter, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.MeshFilter self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.MeshFilter self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_MeshFilter other) { }

    }

    // TypeToken: 0x2000195
    public class Test_MeshFilter_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_MeshFilter ToTestObject(UnityEngine.MeshFilter self) { }
        private HoudiniEngineUnity.Test_MeshFilter[] ToTestObject(UnityEngine.MeshFilter[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_MeshFilter> ToTestObject(System.Collections.Generic.List<UnityEngine.MeshFilter> self) { }

    }

    // TypeToken: 0x2000197
    public class Test_LayerMask, IEquivable`1
    {
        // Fields
        public UnityEngine.LayerMask self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.LayerMask self) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_LayerMask other) { }

    }

    // TypeToken: 0x2000198
    public class Test_LayerMask_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_LayerMask ToTestObject(UnityEngine.LayerMask self) { }

    }

    // TypeToken: 0x2000199
    public class Test_Gradient, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.Gradient self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.Gradient self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Gradient other) { }

    }

    // TypeToken: 0x200019A
    public class Test_Gradient_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_Gradient ToTestObject(UnityEngine.Gradient self) { }
        private HoudiniEngineUnity.Test_Gradient[] ToTestObject(UnityEngine.Gradient[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_Gradient> ToTestObject(System.Collections.Generic.List<UnityEngine.Gradient> self) { }

    }

    // TypeToken: 0x200019C
    public class Test_AnimationCurve, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.AnimationCurve self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.AnimationCurve self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_AnimationCurve other) { }

    }

    // TypeToken: 0x200019D
    public class Test_AnimationCurve_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_AnimationCurve ToTestObject(UnityEngine.AnimationCurve self) { }
        private HoudiniEngineUnity.Test_AnimationCurve[] ToTestObject(UnityEngine.AnimationCurve[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_AnimationCurve> ToTestObject(System.Collections.Generic.List<UnityEngine.AnimationCurve> self) { }

    }

    // TypeToken: 0x200019F
    public class Test_TerrainLayer, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.TerrainLayer self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.TerrainLayer self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_TerrainLayer other) { }

    }

    // TypeToken: 0x20001A0
    public class Test_TerrainLayer_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_TerrainLayer ToTestObject(UnityEngine.TerrainLayer self) { }
        private HoudiniEngineUnity.Test_TerrainLayer[] ToTestObject(UnityEngine.TerrainLayer[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_TerrainLayer> ToTestObject(System.Collections.Generic.List<UnityEngine.TerrainLayer> self) { }

    }

    // TypeToken: 0x20001A2
    public class Test_Texture2D, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.Texture2D self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.Texture2D self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Texture2D other) { }

    }

    // TypeToken: 0x20001A3
    public class Test_Texture2D_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_Texture2D ToTestObject(UnityEngine.Texture2D self) { }
        private HoudiniEngineUnity.Test_Texture2D[] ToTestObject(UnityEngine.Texture2D[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_Texture2D> ToTestObject(System.Collections.Generic.List<UnityEngine.Texture2D> self) { }

    }

    // TypeToken: 0x20001A5
    public class Test_TreeInstance, IEquivable`1
    {
        // Fields
        public UnityEngine.TreeInstance self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.TreeInstance self) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_TreeInstance other) { }

    }

    // TypeToken: 0x20001A6
    public class Test_TreeInstance_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_TreeInstance ToTestObject(UnityEngine.TreeInstance self) { }
        private HoudiniEngineUnity.Test_TreeInstance[] ToTestObject(UnityEngine.TreeInstance[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_TreeInstance> ToTestObject(System.Collections.Generic.List<UnityEngine.TreeInstance> self) { }

    }

    // TypeToken: 0x20001A8
    public class Test_TerrainData, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.TerrainData self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.TerrainData self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_TerrainData other) { }

    }

    // TypeToken: 0x20001A9
    public class Test_TerrainData_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_TerrainData ToTestObject(UnityEngine.TerrainData self) { }
        private HoudiniEngineUnity.Test_TerrainData[] ToTestObject(UnityEngine.TerrainData[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_TerrainData> ToTestObject(System.Collections.Generic.List<UnityEngine.TerrainData> self) { }

    }

    // TypeToken: 0x20001AB
    public class Test_Terrain, IEquivableWrapperClass`1, IEquivable`1
    {
        // Fields
        public UnityEngine.Terrain self;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.Terrain self) { }
        private System.Boolean IsNull() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Terrain other) { }

    }

    // TypeToken: 0x20001AC
    public class Test_Terrain_Extensions
    {
        // Methods
        private HoudiniEngineUnity.Test_Terrain ToTestObject(UnityEngine.Terrain self) { }
        private HoudiniEngineUnity.Test_Terrain[] ToTestObject(UnityEngine.Terrain[] self) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.Test_Terrain> ToTestObject(System.Collections.Generic.List<UnityEngine.Terrain> self) { }

    }

    // TypeToken: 0x20001AE
    public class HEU_ToolsInfo : ScriptableObject, IEquivable`1
    {
        // Fields
        public System.Single _paintBrushSize;        // 0x18
        public System.Single _paintBrushOpacity;        // 0x1C
        public System.Int32[] _paintIntValue;        // 0x20
        public System.Single[] _paintFloatValue;        // 0x28
        public System.String[] _paintStringValue;        // 0x30
        public System.Int32 _lastAttributesGeoID;        // 0x38
        public System.Int32 _lastAttributesPartID;        // 0x3C
        public System.String _lastAttributeNodeName;        // 0x40
        public System.String _lastAttributeName;        // 0x48
        public UnityEngine.Color _brushHandleColor;        // 0x50
        public UnityEngine.Color _affectedAreaPaintColor;        // 0x60
        public System.Boolean _liveUpdate;        // 0x70
        public System.Boolean _isPainting;        // 0x71
        public System.Single _editPointBoxSize;        // 0x74
        public UnityEngine.Color _editPointBoxUnselectedColor;        // 0x78
        public UnityEngine.Color _editPointBoxSelectedColor;        // 0x88
        public System.Boolean _recacheRequired;        // 0x98
        public HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeMode _paintMergeMode;        // 0x9C
        public System.Boolean _showOnlyEditGeometry;        // 0xA0
        public System.Boolean _alwaysCookUpstream;        // 0xA1
        public HoudiniEngineUnity.HEU_ToolsInfo.PaintMeshVisibility _paintMeshVisiblity;        // 0xA4

        // Methods
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ToolsInfo other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B1
    public struct HFLayerType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static HoudiniEngineUnity.HFLayerType DEFAULT;        // 0x0
        public static HoudiniEngineUnity.HFLayerType HEIGHT;        // 0x0
        public static HoudiniEngineUnity.HFLayerType MASK;        // 0x0
        public static HoudiniEngineUnity.HFLayerType DETAIL;        // 0x0

    }

    // TypeToken: 0x20001B2
    public class HEU_VolumeLayer, IEquivable`1
    {
        // Fields
        public System.String _layerName;        // 0x10
        public System.Single _strength;        // 0x18
        public System.Boolean _uiExpanded;        // 0x1C
        public System.Int32 _tile;        // 0x20
        public System.Int32 _xLength;        // 0x24
        public System.Int32 _yLength;        // 0x28
        public System.Boolean _hasLayerAttributes;        // 0x2C
        public UnityEngine.TerrainLayer _terrainLayer;        // 0x30
        public HoudiniEngineUnity.HFLayerType _layerType;        // 0x38
        public HoudiniEngineUnity.HEU_DetailPrototype _detailPrototype;        // 0x40
        private HoudiniEngineUnity.HEU_PartData _part;        // 0x48

        // Methods
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_VolumeLayer other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B3
    public class HEU_VolumeScatterTrees, IEquivable`1
    {
        // Fields
        public System.Collections.Generic.List<HoudiniEngineUnity.HEU_TreePrototypeInfo> _treePrototypInfos;        // 0x10
        public UnityEngine.Color32[] _colors;        // 0x18
        public System.Single[] _heightScales;        // 0x20
        public UnityEngine.Color32[] _lightmapColors;        // 0x28
        public UnityEngine.Vector3[] _positions;        // 0x30
        public System.Int32[] _prototypeIndices;        // 0x38
        public System.Single[] _rotations;        // 0x40
        public System.Single[] _widthScales;        // 0x48
        public System.Int32[] _terrainTiles;        // 0x50

        // Methods
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_VolumeScatterTrees other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B4
    public class HEU_TreePrototypeInfo, IEquivable`1
    {
        // Fields
        public System.String _prefabPath;        // 0x10
        public System.Single _bendfactor;        // 0x18

        // Methods
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_TreePrototypeInfo other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B5
    public class HEU_DetailProperties, IEquivable`1
    {
        // Fields
        public System.Single _detailDistance;        // 0x10
        public System.Single _detailDensity;        // 0x14
        public System.Int32 _detailResolution;        // 0x18
        public System.Int32 _detailResolutionPerPatch;        // 0x1C

        // Methods
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_DetailProperties other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B6
    public class HEU_DetailPrototype, IEquivable`1
    {
        // Fields
        public System.String _prototypePrefab;        // 0x10
        public System.String _prototypeTexture;        // 0x18
        public System.Single _bendFactor;        // 0x20
        public UnityEngine.Color _dryColor;        // 0x24
        public UnityEngine.Color _healthyColor;        // 0x34
        public System.Single _maxHeight;        // 0x44
        public System.Single _maxWidth;        // 0x48
        public System.Single _minHeight;        // 0x4C
        public System.Single _minWidth;        // 0x50
        public System.Single _noiseSpread;        // 0x54
        public System.Int32 _renderMode;        // 0x58

        // Methods
        private System.Void .ctor() { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_DetailPrototype other) { }

    }

    // TypeToken: 0x20001B7
    public class HEU_VolumeCache : ScriptableObject, IHEU_VolumeCache, IHEU_HoudiniAssetSubcomponent, IEquivable`1
    {
        // Fields
        private HoudiniEngineUnity.HEU_GeoNode _ownerNode;        // 0x18
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayer> _layers;        // 0x20
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayer> _updatedLayers;        // 0x28
        private System.Int32 _tileIndex;        // 0x30
        private System.Boolean _isDirty;        // 0x34
        private System.String _geoName;        // 0x38
        private System.String _objName;        // 0x40
        public System.Boolean _uiExpanded;        // 0x48
        private UnityEngine.TerrainData _terrainData;        // 0x50
        private HoudiniEngineUnity.HEU_VolumeScatterTrees _scatterTrees;        // 0x58
        private HoudiniEngineUnity.HEU_DetailProperties _detailProperties;        // 0x60
        private HoudiniEngineUnity.HEU_HoudiniAsset _parentAsset;        // 0x68

        // Methods
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayer> get_Layers() { }
        private System.Int32 get_TileIndex() { }
        private System.String get_ObjectName() { }
        private System.String get_GeoName() { }
        private UnityEngine.TerrainData get_TerrainData() { }
        private HoudiniEngineUnity.HEU_VolumeScatterTrees get_ScatterTrees() { }
        private HoudiniEngineUnity.HEU_DetailProperties get_DetailProperties() { }
        private HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset() { }
        private System.Boolean get_IsDirty() { }
        private System.Void set_IsDirty(System.Boolean value) { }
        private System.Boolean get_UIExpanded() { }
        private System.Void set_UIExpanded(System.Boolean value) { }
        private HoudiniEngineUnity.HEU_SessionBase GetSession() { }
        private System.Void Recook() { }
        private System.Void ResetParameters() { }
        private HoudiniEngineUnity.HEU_VolumeLayer GetLayer(System.String layerName) { }
        private System.Void PopulatePreset(HoudiniEngineUnity.HEU_VolumeCachePreset cachePreset) { }
        private System.Boolean ApplyPreset(HoudiniEngineUnity.HEU_VolumeCachePreset volumeCachePreset) { }
        private System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> UpdateVolumeCachesFromParts(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GeoNode ownerNode, System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> volumeParts, System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> volumeCaches) { }
        private System.Void Initialize(HoudiniEngineUnity.HEU_GeoNode ownerNode, System.Int32 tileIndex) { }
        private System.Void StartUpdateLayers() { }
        private System.Void FinishUpdateLayers() { }
        private System.Void GetPartLayerAttributes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_VolumeLayer layer) { }
        private System.Boolean LoadLayerTextureFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Texture2D& outTexture) { }
        private System.Boolean LoadLayerFloatFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Single& floatValue) { }
        private System.Boolean LoadLayerColorFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Color& colorValue) { }
        private System.Boolean LoadLayerVector2FromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Vector2& vectorValue) { }
        private System.Void UpdateLayerFromPart(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_PartData part) { }
        private System.Void GenerateTerrainWithAlphamaps(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset, System.Boolean bRebuild) { }
        private System.Void LoadLayerPropertiesFromAttributes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.TerrainLayer terrainLayer, System.Boolean bNewTerrainLayer, UnityEngine.Texture2D defaultTexture) { }
        private System.Void PopulateScatterTrees(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32 pointCount, System.Boolean throwWarningIfNoTileAttribute) { }
        private System.Void PopulateDetailPrototype(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_VolumeLayer layer) { }
        private System.Void CopyValuesTo(HoudiniEngineUnity.HEU_VolumeCache destCache) { }
        private System.Void CopyDetailProperties(HoudiniEngineUnity.HEU_DetailProperties srcProp, HoudiniEngineUnity.HEU_DetailProperties destProp) { }
        private System.Void CopyLayer(HoudiniEngineUnity.HEU_VolumeLayer srcLayer, HoudiniEngineUnity.HEU_VolumeLayer destLayer) { }
        private System.Void CopyPrototype(HoudiniEngineUnity.HEU_DetailPrototype srcProto, HoudiniEngineUnity.HEU_DetailPrototype destProto) { }
        private UnityEngine.Texture2D LoadDefaultSplatTexture() { }
        private UnityEngine.Texture2D LoadAssetTexture(System.String path) { }
        private System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_VolumeCache other) { }
        private System.Void .ctor() { }

    }

}

