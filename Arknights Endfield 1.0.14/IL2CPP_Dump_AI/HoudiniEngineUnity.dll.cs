// ========================================================
// Dumped by @desirepro
// Assembly: HoudiniEngineUnity.dll
// Classes:  439
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: HEU_BoundingVolume
TYPE:  class
TOKEN: 0x2000003
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  UnityEngine.Collider get_BoundingCollider()
  System.Collections.Generic.List<UnityEngine.GameObject> GetAllIntersectingObjects()
  System.Void .ctor()
END_CLASS

CLASS: HEU_ExampleEvergreenQuery
TYPE:  class
TOKEN: 0x2000004
FIELDS:
METHODS:
  System.Void StartQuery()
  HoudiniEngineUnity.HEU_HoudiniAsset QueryHoudiniAsset(UnityEngine.GameObject rootGO)
  System.Void CookAsset(HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset)
  System.Void ChangeParmsAndCook(HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset)
  System.Void QueryObjects(HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset)
  System.Void QueryGeoParts(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_GeoInfo& geoInfo)
  System.Void QueryPartAttributeByOwner(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HAPI_AttributeOwner owner, System.Int32 count, System.Text.StringBuilder sb)
  System.Void QueryAttributeByStorageType(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.String attrName)
  System.Void QueryAttribute(HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset, System.String objName, System.String geoName, System.Int32 partID, System.String attrName)
  System.Void .ctor()
END_CLASS

CLASS: HEU_ExampleInstanceCustomAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void InstancerCallback()
  System.Void LogArray(System.String name, T[] arr, System.Int32 tupleSize)
  System.Void LogAttr(HoudiniEngineUnity.HEU_OutputAttribute outAttr)
  System.Void .ctor()
END_CLASS

CLASS: HEU_ScriptCallbackExample
TYPE:  class
TOKEN: 0x2000006
EXTENDS: MonoBehaviour
FIELDS:
  public            System.String                   _msg  // 0x18
METHODS:
  System.Void AssetCallbackWithMsg(System.String msg)
  System.Void AssetCallbackNoMsg()
  System.Void .ctor()
END_CLASS

CLASS: OutputMode
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HEU_ScriptMeshInputUVLayoutExample.OutputModeCOPY  // 0x0
  public    static  HEU_ScriptMeshInputUVLayoutExample.OutputModeREPLACE  // 0x0
METHODS:
END_CLASS

CLASS: HEU_ScriptMeshInputUVLayoutExample
TYPE:  class
TOKEN: 0x2000007
FIELDS:
METHODS:
  System.Void ApplyUVLayoutTo(UnityEngine.GameObject[] gameObjects, HEU_ScriptMeshInputUVLayoutExample.OutputMode outputMode, System.String output_name_suffix)
  System.Void .ctor()
END_CLASS

CLASS: HEU_ScriptParameterExample
TYPE:  class
TOKEN: 0x2000009
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.GameObject          _evergreenGameObject  // 0x18
  private           HoudiniEngineUnity.HEU_HoudiniAsset_evergreenAsset  // 0x20
  public            System.Single                   _updateRate  // 0x28
  public            System.Single                   _scale  // 0x2C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HEU_AssetEventReceiverTest
TYPE:  class
TOKEN: 0x200000A
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void ReloadCallback(HoudiniEngineUnity.HEU_ReloadEventData Data)
  System.Void CookedCallback(HoudiniEngineUnity.HEU_CookedEventData Data)
  System.Void BakedCallback(HoudiniEngineUnity.HEU_BakedEventData Data)
  System.Void .ctor()
END_CLASS

CLASS: CurveEditState
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_Curve.CurveEditStateINVALID  // 0x0
  public    static  HoudiniEngineUnity.HEU_Curve.CurveEditStateGENERATED  // 0x0
  public    static  HoudiniEngineUnity.HEU_Curve.CurveEditStateEDITING  // 0x0
  public    static  HoudiniEngineUnity.HEU_Curve.CurveEditStateREQUIRES_GENERATION  // 0x0
METHODS:
END_CLASS

CLASS: Interaction
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_Curve.InteractionVIEW  // 0x0
  public    static  HoudiniEngineUnity.HEU_Curve.InteractionADD  // 0x0
  public    static  HoudiniEngineUnity.HEU_Curve.InteractionEDIT  // 0x0
METHODS:
END_CLASS

CLASS: CurveDrawCollision
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_Curve.CurveDrawCollisionCOLLIDERS  // 0x0
  public    static  HoudiniEngineUnity.HEU_Curve.CurveDrawCollisionLAYERMASK  // 0x0
METHODS:
END_CLASS

CLASS: HEU_AssetType
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetTypeTYPE_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetTypeTYPE_HDA  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetTypeTYPE_CURVE  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetTypeTYPE_INPUT  // 0x0
METHODS:
END_CLASS

CLASS: AssetBuildAction
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildActionNONE  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildActionRELOAD  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildActionCOOK  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildActionINVALID  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildActionSTRIP_HEDATA  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildActionDUPLICATE  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildActionRESET_PARAMS  // 0x0
METHODS:
END_CLASS

CLASS: AssetCookStatus
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatusNONE  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatusCOOKING  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatusPOSTCOOK  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatusLOADING  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatusPOSTLOAD  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatusPRELOAD  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatusSELECT_SUBASSET  // 0x0
METHODS:
END_CLASS

CLASS: AssetCookResult
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResultNONE  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResultSUCCESS  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResultERRORED  // 0x0
METHODS:
END_CLASS

CLASS: UpdateUIDelegate
TYPE:  class
TOKEN: 0x2000034
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: AssetInstantiationMethod
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetInstantiationMethodDEFAULT  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetInstantiationMethodDUPLICATED  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniAsset.AssetInstantiationMethodUNDO  // 0x0
METHODS:
END_CLASS

CLASS: InputNodeType
TYPE:  struct
TOKEN: 0x200003B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_InputNode.InputNodeTypeCONNECTION  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputNode.InputNodeTypeNODE  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputNode.InputNodeTypePARAMETER  // 0x0
METHODS:
END_CLASS

CLASS: InputObjectType
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_InputNode.InputObjectTypeHDA  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputNode.InputObjectTypeUNITY_MESH  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputNode.InputObjectTypeCURVE  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputNode.InputObjectTypeTERRAIN  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputNode.InputObjectTypeBOUNDING_BOX  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputNode.InputObjectTypeTILEMAP  // 0x0
METHODS:
END_CLASS

CLASS: InternalObjectType
TYPE:  struct
TOKEN: 0x200003D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_InputNode.InternalObjectTypeUNKNOWN  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputNode.InternalObjectTypeHDA  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputNode.InternalObjectTypeUNITY_MESH  // 0x0
METHODS:
END_CLASS

CLASS: InputActions
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_InputNode.InputActionsACTION  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputNode.InputActionsDELETE  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputNode.InputActionsINSERT  // 0x0
METHODS:
END_CLASS

CLASS: HEU_InputObjectUICache
TYPE:  class
TOKEN: 0x2000042
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HEU_InputAssetUICache
TYPE:  class
TOKEN: 0x2000043
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: PartOutputType
TYPE:  struct
TOKEN: 0x2000049
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_PartData.PartOutputTypeNONE  // 0x0
  public    static  HoudiniEngineUnity.HEU_PartData.PartOutputTypeMESH  // 0x0
  public    static  HoudiniEngineUnity.HEU_PartData.PartOutputTypeVOLUME  // 0x0
  public    static  HoudiniEngineUnity.HEU_PartData.PartOutputTypeCURVE  // 0x0
  public    static  HoudiniEngineUnity.HEU_PartData.PartOutputTypeINSTANCER  // 0x0
METHODS:
END_CLASS

CLASS: AttributeType
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeTypeUNDEFINED  // 0x0
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeTypeBOOL  // 0x0
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeTypeINT  // 0x0
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeTypeFLOAT  // 0x0
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeTypeSTRING  // 0x0
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeTypeMAX  // 0x0
METHODS:
END_CLASS

CLASS: AttributeState
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeStateINVALID  // 0x0
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeStateSYNCED  // 0x0
  public    static  HoudiniEngineUnity.HEU_AttributeData.AttributeStateLOCAL_DIRTY  // 0x0
METHODS:
END_CLASS

CLASS: SetAttributeValueFunc
TYPE:  class
TOKEN: 0x2000052
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: HEU_ImportAssetOptions
TYPE:  struct
TOKEN: 0x2000057
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptionsDefault  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptionsForceUpdate  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptionsForceSynchronousImport  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptionsImportRecursive  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptionsDontDownloadFromCacheServer  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptionsForceUncompressedImport  // 0x0
METHODS:
END_CLASS

CLASS: RegSAM
TYPE:  struct
TOKEN: 0x200005D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMQueryValue  // 0x0
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMSetValue  // 0x0
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMCreateSubKey  // 0x0
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMEnumerateSubKeys  // 0x0
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMNotify  // 0x0
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMCreateLink  // 0x0
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMWOW64_32Key  // 0x0
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMWOW64_64Key  // 0x0
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMWOW64_Res  // 0x0
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMRead  // 0x0
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMWrite  // 0x0
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMExecute  // 0x0
  public    static  HoudiniEngineUnity.HEU_PlatformWin.RegSAMAllAccess  // 0x0
METHODS:
END_CLASS

CLASS: DataType
TYPE:  struct
TOKEN: 0x2000060
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_PluginStorage.DataTypeBOOL  // 0x0
  public    static  HoudiniEngineUnity.HEU_PluginStorage.DataTypeINT  // 0x0
  public    static  HoudiniEngineUnity.HEU_PluginStorage.DataTypeLONG  // 0x0
  public    static  HoudiniEngineUnity.HEU_PluginStorage.DataTypeFLOAT  // 0x0
  public    static  HoudiniEngineUnity.HEU_PluginStorage.DataTypeSTRING  // 0x0
METHODS:
END_CLASS

CLASS: StoreData
TYPE:  class
TOKEN: 0x2000061
FIELDS:
  public            HoudiniEngineUnity.HEU_PluginStorage.DataType_type  // 0x10
  public            System.String                   _valueStr  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: StoreDataArray`1
TYPE:  class
TOKEN: 0x2000062
FIELDS:
  public            T[]                             _array  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HEU_HandleType
TYPE:  struct
TOKEN: 0x2000064
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_Handle.HEU_HandleTypeXFORM  // 0x0
  public    static  HoudiniEngineUnity.HEU_Handle.HEU_HandleTypeUNSUPPORTED  // 0x0
METHODS:
END_CLASS

CLASS: HEU_HandleParamType
TYPE:  struct
TOKEN: 0x2000066
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_HandleParamBinding.HEU_HandleParamTypeTRANSLATE  // 0x0
  public    static  HoudiniEngineUnity.HEU_HandleParamBinding.HEU_HandleParamTypeROTATE  // 0x0
  public    static  HoudiniEngineUnity.HEU_HandleParamBinding.HEU_HandleParamTypeSCALE  // 0x0
METHODS:
END_CLASS

CLASS: ModifierAction
TYPE:  struct
TOKEN: 0x20000C3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_ParameterModifier.ModifierActionMULTIPARM_INSERT  // 0x0
  public    static  HoudiniEngineUnity.HEU_ParameterModifier.ModifierActionMULTIPARM_REMOVE  // 0x0
  public    static  HoudiniEngineUnity.HEU_ParameterModifier.ModifierActionMULTIPARM_CLEAR  // 0x0
  public    static  HoudiniEngineUnity.HEU_ParameterModifier.ModifierActionSET_FLOAT  // 0x0
  public    static  HoudiniEngineUnity.HEU_ParameterModifier.ModifierActionSET_INT  // 0x0
METHODS:
END_CLASS

CLASS: LinkState
TYPE:  struct
TOKEN: 0x20000CB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_PDGAssetLink.LinkStateINACTIVE  // 0x0
  public    static  HoudiniEngineUnity.HEU_PDGAssetLink.LinkStateLINKING  // 0x0
  public    static  HoudiniEngineUnity.HEU_PDGAssetLink.LinkStateLINKED  // 0x0
  public    static  HoudiniEngineUnity.HEU_PDGAssetLink.LinkStateERROR_NOT_LINKED  // 0x0
METHODS:
END_CLASS

CLASS: UpdateUIDelegate
TYPE:  class
TOKEN: 0x20000CC
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: PDGState
TYPE:  struct
TOKEN: 0x20000D2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_TOPNodeData.PDGStateNONE  // 0x0
  public    static  HoudiniEngineUnity.HEU_TOPNodeData.PDGStateDIRTIED  // 0x0
  public    static  HoudiniEngineUnity.HEU_TOPNodeData.PDGStateDIRTYING  // 0x0
  public    static  HoudiniEngineUnity.HEU_TOPNodeData.PDGStateCOOKING  // 0x0
  public    static  HoudiniEngineUnity.HEU_TOPNodeData.PDGStateCOOK_COMPLETE  // 0x0
  public    static  HoudiniEngineUnity.HEU_TOPNodeData.PDGStateCOOK_FAILED  // 0x0
METHODS:
END_CLASS

CLASS: OnWorkItemLoadResultsDelegate
TYPE:  class
TOKEN: 0x20000D6
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(HoudiniEngineUnity.HEU_SyncedEventData OnSynced)
  System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_SyncedEventData OnSynced, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: EventMessageColor
TYPE:  struct
TOKEN: 0x20000D7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_PDGSession.EventMessageColorDEFAULT  // 0x0
  public    static  HoudiniEngineUnity.HEU_PDGSession.EventMessageColorWARNING  // 0x0
  public    static  HoudiniEngineUnity.HEU_PDGSession.EventMessageColorERROR  // 0x0
METHODS:
END_CLASS

CLASS: Source
TYPE:  struct
TOKEN: 0x20000F2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_MaterialData.SourceDEFAULT  // 0x0
  public    static  HoudiniEngineUnity.HEU_MaterialData.SourceHOUDINI  // 0x0
  public    static  HoudiniEngineUnity.HEU_MaterialData.SourceUNITY  // 0x0
  public    static  HoudiniEngineUnity.HEU_MaterialData.SourceSUBSTANCE  // 0x0
METHODS:
END_CLASS

CLASS: CreateSessionFromTypeDelegate
TYPE:  class
TOKEN: 0x20000FB
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  HoudiniEngineUnity.HEU_SessionBase Invoke(System.Type type)
  System.IAsyncResult BeginInvoke(System.Type type, System.AsyncCallback callback, System.Object object)
  HoudiniEngineUnity.HEU_SessionBase EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Status
TYPE:  struct
TOKEN: 0x20000FE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_SessionSyncData.StatusStopped  // 0x0
  public    static  HoudiniEngineUnity.HEU_SessionSyncData.StatusStarted  // 0x0
  public    static  HoudiniEngineUnity.HEU_SessionSyncData.StatusConnecting  // 0x0
  public    static  HoudiniEngineUnity.HEU_SessionSyncData.StatusInitializing  // 0x0
  public    static  HoudiniEngineUnity.HEU_SessionSyncData.StatusConnected  // 0x0
METHODS:
END_CLASS

CLASS: AssetSyncCallback
TYPE:  class
TOKEN: 0x2000100
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(HoudiniEngineUnity.HEU_AssetSync assetSync)
  System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_AssetSync assetSync, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: TaskStatus
TYPE:  struct
TOKEN: 0x2000107
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_Task.TaskStatusNONE  // 0x0
  public    static  HoudiniEngineUnity.HEU_Task.TaskStatusPENDING_START  // 0x0
  public    static  HoudiniEngineUnity.HEU_Task.TaskStatusSTARTED  // 0x0
  public    static  HoudiniEngineUnity.HEU_Task.TaskStatusREQUIRE_UPDATE  // 0x0
  public    static  HoudiniEngineUnity.HEU_Task.TaskStatusPENDING_COMPLETE  // 0x0
  public    static  HoudiniEngineUnity.HEU_Task.TaskStatusCOMPLETED  // 0x0
  public    static  HoudiniEngineUnity.HEU_Task.TaskStatusUNUSED  // 0x0
METHODS:
END_CLASS

CLASS: TaskResult
TYPE:  struct
TOKEN: 0x2000108
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_Task.TaskResultNONE  // 0x0
  public    static  HoudiniEngineUnity.HEU_Task.TaskResultSUCCESS  // 0x0
  public    static  HoudiniEngineUnity.HEU_Task.TaskResultFAILED  // 0x0
  public    static  HoudiniEngineUnity.HEU_Task.TaskResultKILLED  // 0x0
METHODS:
END_CLASS

CLASS: TaskCallback
TYPE:  class
TOKEN: 0x2000109
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(HoudiniEngineUnity.HEU_Task task)
  System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_Task task, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: BuildType
TYPE:  struct
TOKEN: 0x200010B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_AssetTask.BuildTypeNONE  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetTask.BuildTypeLOAD  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetTask.BuildTypeCOOK  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetTask.BuildTypeRELOAD  // 0x0
METHODS:
END_CLASS

CLASS: LoadType
TYPE:  struct
TOKEN: 0x2000114
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadTypeFILE  // 0x0
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadTypeNODE  // 0x0
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadTypeASSET  // 0x0
METHODS:
END_CLASS

CLASS: LoadStatus
TYPE:  struct
TOKEN: 0x2000116
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatusNONE  // 0x0
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatusSTARTED  // 0x0
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatusSUCCESS  // 0x0
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatusERROR  // 0x0
METHODS:
END_CLASS

CLASS: HEU_LoadData
TYPE:  class
TOKEN: 0x2000115
FIELDS:
  public            System.Int32                    _cookNodeID  // 0x10
  public            HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus_loadStatus  // 0x14
  public            System.Text.StringBuilder       _logStr  // 0x18
  public            HoudiniEngineUnity.HEU_SessionBase_session  // 0x20
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadObject>_loadedObjects  // 0x28
  public            System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_LoadBufferBase>_idBuffersMap  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HEU_LoadObject
TYPE:  class
TOKEN: 0x2000117
FIELDS:
  public            System.Int32                    _objectNodeID  // 0x10
  public            System.Int32                    _displayNodeID  // 0x14
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolume>_terrainBuffers  // 0x18
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferMesh>_meshBuffers  // 0x20
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferInstancer>_instancerBuffers  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HEU_LoadCallbackType
TYPE:  struct
TOKEN: 0x2000118
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallbackTypePRECOOK  // 0x0
  public    static  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallbackTypePOSTCOOK  // 0x0
METHODS:
END_CLASS

CLASS: HEU_LoadCallback
TYPE:  class
TOKEN: 0x2000119
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallbackType callbackType)
  System.IAsyncResult BeginInvoke(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallbackType callbackType, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: HEU_ReplacePrefabOptions
TYPE:  struct
TOKEN: 0x200011D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_EditorUtility.HEU_ReplacePrefabOptionsDefault  // 0x0
  public    static  HoudiniEngineUnity.HEU_EditorUtility.HEU_ReplacePrefabOptionsConnectToPrefab  // 0x0
  public    static  HoudiniEngineUnity.HEU_EditorUtility.HEU_ReplacePrefabOptionsReplaceNameBased  // 0x0
METHODS:
END_CLASS

CLASS: GetArray1ArgDel`1
TYPE:  class
TOKEN: 0x2000123
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.Int32 arg1, T[] data, System.Int32 start, System.Int32 length)
  System.IAsyncResult BeginInvoke(System.Int32 arg1, T[] data, System.Int32 start, System.Int32 length, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GetArray2ArgDel`2
TYPE:  class
TOKEN: 0x2000124
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.Int32 arg1, ARG2 arg2, T[] data, System.Int32 start, System.Int32 length)
  System.IAsyncResult BeginInvoke(System.Int32 arg1, ARG2 arg2, T[] data, System.Int32 start, System.Int32 length, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GetArray3ArgDel`3
TYPE:  class
TOKEN: 0x2000125
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.Int32 arg1, ARG2 arg2, ARG3 arg3, T[] data, System.Int32 start, System.Int32 length)
  System.IAsyncResult BeginInvoke(System.Int32 arg1, ARG2 arg2, ARG3 arg3, T[] data, System.Int32 start, System.Int32 length, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: GetAttributeArrayInputFunc`1
TYPE:  class
TOKEN: 0x2000126
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[] items, System.Int32 start, System.Int32 end)
  System.IAsyncResult BeginInvoke(System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[] items, System.Int32 start, System.Int32 end, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(HoudiniEngineUnity.HAPI_AttributeInfo& info, System.IAsyncResult result)
END_CLASS

CLASS: SetAttributeArrayFunc`1
TYPE:  class
TOKEN: 0x2000127
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, T[] items, System.Int32 start, System.Int32 end)
  System.IAsyncResult BeginInvoke(System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, T[] items, System.Int32 start, System.Int32 end, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.IAsyncResult result)
END_CLASS

CLASS: ColliderType
TYPE:  struct
TOKEN: 0x200012B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderTypeNONE  // 0x0
  public    static  HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderTypeBOX  // 0x0
  public    static  HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderTypeSPHERE  // 0x0
  public    static  HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderTypeMESH  // 0x0
  public    static  HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderTypeSIMPLE_BOX  // 0x0
  public    static  HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderTypeSIMPLE_SPHERE  // 0x0
  public    static  HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderTypeSIMPLE_CAPSULE  // 0x0
METHODS:
END_CLASS

CLASS: HEU_ColliderInfo
TYPE:  class
TOKEN: 0x200012A
FIELDS:
  public            HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo.ColliderType_colliderType  // 0x10
  public            UnityEngine.Vector3             _colliderCenter  // 0x14
  public            UnityEngine.Vector3             _colliderSize  // 0x20
  public            System.Single                   _colliderRadius  // 0x2C
  public            System.Boolean                  _convexCollider  // 0x30
  public            System.String                   _collisionGroupName  // 0x38
  public            UnityEngine.Vector3[]           _collisionVertices  // 0x40
  public            System.Int32[]                  _collisionIndices  // 0x48
  public            UnityEngine.MeshTopology        _meshTopology  // 0x50
  public            System.Boolean                  _isTrigger  // 0x54
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HEU_InputDataMeshes
TYPE:  class
TOKEN: 0x2000134
EXTENDS: HEU_InputData
FIELDS:
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataMesh>_inputMeshes  // 0x18
  public            System.Boolean                  _hasLOD  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HEU_InputColliderType
TYPE:  struct
TOKEN: 0x2000135
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderTypeNONE  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderTypeBOX  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderTypeSPHERE  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderTypeCAPSULE  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderTypeMESH  // 0x0
METHODS:
END_CLASS

CLASS: HEU_InputDataCollider
TYPE:  class
TOKEN: 0x2000136
FIELDS:
  public            UnityEngine.Collider            _collider  // 0x10
  public            HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputColliderType_colliderType  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HEU_InputDataMesh
TYPE:  class
TOKEN: 0x2000137
FIELDS:
  public            UnityEngine.Mesh                _mesh  // 0x10
  public            UnityEngine.Material[]          _materials  // 0x18
  public            System.String                   _meshPath  // 0x20
  public            System.String                   _meshName  // 0x28
  public            System.Int32                    _numVertices  // 0x30
  public            System.Int32                    _numSubMeshes  // 0x34
  public            System.UInt32[]                 _indexStart  // 0x38
  public            System.UInt32[]                 _indexCount  // 0x40
  public            System.Single                   _LODScreenTransition  // 0x48
  public            UnityEngine.Transform           _transform  // 0x50
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataCollider>_colliders  // 0x58
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HEU_InputDataTerrain
TYPE:  class
TOKEN: 0x2000139
EXTENDS: HEU_InputData
FIELDS:
  public            System.String                   _heightFieldName  // 0x18
  public            System.Int32                    _parentNodeID  // 0x20
  public            System.Single                   _voxelSize  // 0x24
  public            UnityEngine.Terrain             _terrain  // 0x28
  public            UnityEngine.TerrainData         _terrainData  // 0x30
  public            System.Int32                    _numPointsX  // 0x38
  public            System.Int32                    _numPointsY  // 0x3C
  public            HoudiniEngineUnity.HAPI_Transform_transform  // 0x40
  public            System.Single                   _heightScale  // 0x68
  public            System.Int32                    _heightfieldNodeID  // 0x6C
  public            System.Int32                    _heightNodeID  // 0x70
  public            System.Int32                    _maskNodeID  // 0x74
  public            System.Int32                    _mergeNodeID  // 0x78
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HEU_InputDataTilemap
TYPE:  class
TOKEN: 0x200013C
EXTENDS: HEU_InputData
FIELDS:
  public            UnityEngine.Tilemaps.Tilemap    _tilemap  // 0x18
  public            UnityEngine.Transform           _transform  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ToolType
TYPE:  struct
TOKEN: 0x2000146
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_ShelfToolData.ToolTypeGENERATOR  // 0x0
  public    static  HoudiniEngineUnity.HEU_ShelfToolData.ToolTypeOPERATOR_SINGLE  // 0x0
  public    static  HoudiniEngineUnity.HEU_ShelfToolData.ToolTypeOPERATOR_MULTI  // 0x0
  public    static  HoudiniEngineUnity.HEU_ShelfToolData.ToolTypeBATCH  // 0x0
METHODS:
END_CLASS

CLASS: Type
TYPE:  struct
TOKEN: 0x200014E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.JSONNode.Enumerator.TypeNone  // 0x0
  public    static  HoudiniEngineUnity.JSONNode.Enumerator.TypeArray  // 0x0
  public    static  HoudiniEngineUnity.JSONNode.Enumerator.TypeObject  // 0x0
METHODS:
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200014D
FIELDS:
  private           HoudiniEngineUnity.JSONNode.Enumerator.Typetype  // 0x10
  private           System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode>m_Object  // 0x18
  private           System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode>m_Array  // 0x40
METHODS:
  System.Boolean get_IsValid()
  System.Void .ctor(System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode> aArrayEnum)
  System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode> aDictEnum)
  System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode> get_Current()
  System.Boolean MoveNext()
END_CLASS

CLASS: ValueEnumerator
TYPE:  struct
TOKEN: 0x200014F
FIELDS:
  private           HoudiniEngineUnity.JSONNode.Enumeratorm_Enumerator  // 0x10
METHODS:
  System.Void .ctor(System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode> aArrayEnum)
  System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode> aDictEnum)
  System.Void .ctor(HoudiniEngineUnity.JSONNode.Enumerator aEnumerator)
  HoudiniEngineUnity.JSONNode get_Current()
  System.Boolean MoveNext()
  HoudiniEngineUnity.JSONNode.ValueEnumerator GetEnumerator()
END_CLASS

CLASS: KeyEnumerator
TYPE:  struct
TOKEN: 0x2000150
FIELDS:
  private           HoudiniEngineUnity.JSONNode.Enumeratorm_Enumerator  // 0x10
METHODS:
  System.Void .ctor(System.Collections.Generic.List.Enumerator<HoudiniEngineUnity.JSONNode> aArrayEnum)
  System.Void .ctor(System.Collections.Generic.Dictionary.Enumerator<System.String,HoudiniEngineUnity.JSONNode> aDictEnum)
  System.Void .ctor(HoudiniEngineUnity.JSONNode.Enumerator aEnumerator)
  System.String get_Current()
  System.Boolean MoveNext()
  HoudiniEngineUnity.JSONNode.KeyEnumerator GetEnumerator()
END_CLASS

CLASS: LinqEnumerator
TYPE:  class
TOKEN: 0x2000151
FIELDS:
  private           HoudiniEngineUnity.JSONNode     m_Node  // 0x10
  private           HoudiniEngineUnity.JSONNode.Enumeratorm_Enumerator  // 0x18
METHODS:
  System.Void .ctor(HoudiniEngineUnity.JSONNode aNode)
  System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode> get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Boolean MoveNext()
  System.Void Dispose()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode>> GetEnumerator()
  System.Void Reset()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: RequireStruct`1
TYPE:  class
TOKEN: 0x2000164
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: RequireClass`1
TYPE:  class
TOKEN: 0x2000165
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: PaintMergeMode
TYPE:  struct
TOKEN: 0x20001AF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeModeREPLACE  // 0x0
  public    static  HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeModeADD  // 0x0
  public    static  HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeModeSUBTRACT  // 0x0
  public    static  HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeModeMULTIPLY  // 0x0
METHODS:
END_CLASS

CLASS: PaintMeshVisibility
TYPE:  struct
TOKEN: 0x20001B0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_ToolsInfo.PaintMeshVisibilityAUTO  // 0x0
  public    static  HoudiniEngineUnity.HEU_ToolsInfo.PaintMeshVisibilitySHOW  // 0x0
  public    static  HoudiniEngineUnity.HEU_ToolsInfo.PaintMeshVisibilityHIDE  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetEventType
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_AssetEventTypeUNKNOWN  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetEventTypeRELOAD  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetEventTypeCOOK  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetEventTypeBAKE_NEW  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetEventTypeBAKE_UPDATE  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetEventData
TYPE:  class
TOKEN: 0x200000C
FIELDS:
  public            HoudiniEngineUnity.HEU_HoudiniAssetAsset  // 0x10
  public            System.Boolean                  CookSuccess  // 0x18
  public            System.Collections.Generic.List<UnityEngine.GameObject>OutputObjects  // 0x20
  public            HoudiniEngineUnity.HEU_AssetEventTypeEventType  // 0x28
METHODS:
  System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean successful, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ReloadEventData
TYPE:  class
TOKEN: 0x200000D
EXTENDS: HEU_AssetEventData
FIELDS:
METHODS:
  System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean successful, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_CookedEventData
TYPE:  class
TOKEN: 0x200000E
EXTENDS: HEU_AssetEventData
FIELDS:
METHODS:
  System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean successful, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_BakedEventData
TYPE:  class
TOKEN: 0x200000F
EXTENDS: HEU_AssetEventData
FIELDS:
  public            System.Boolean                  IsNewBake  // 0x30
METHODS:
  System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean successful, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects, System.Boolean isNewBake)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PreAssetEventData
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  public            HoudiniEngineUnity.HEU_HoudiniAssetAsset  // 0x10
  public            HoudiniEngineUnity.HEU_AssetEventTypeAssetType  // 0x18
METHODS:
  System.Void .ctor(HoudiniEngineUnity.HEU_HoudiniAsset asset, HoudiniEngineUnity.HEU_AssetEventType assetType)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ReloadDataEvent
TYPE:  class
TOKEN: 0x2000011
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_CookedDataEvent
TYPE:  class
TOKEN: 0x2000012
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_BakedDataEvent
TYPE:  class
TOKEN: 0x2000013
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PreAssetEvent
TYPE:  class
TOKEN: 0x2000014
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetPreset
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  public            System.Char[]                   _identifier  // 0x10
  public            System.Int32                    _version  // 0x18
  public            System.String                   _assetOPName  // 0x20
  public            System.Byte[]                   _parameterPreset  // 0x28
  public            System.Collections.Generic.List<System.String>_curveNames  // 0x30
  public            System.Collections.Generic.List<System.Byte[]>_curvePresets  // 0x38
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputPreset>inputPresets  // 0x40
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCachePreset>volumeCachePresets  // 0x48
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputPreset
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  private           HoudiniEngineUnity.HEU_InputNode.InputObjectType_inputObjectType  // 0x10
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputObjectPreset>_inputObjectPresets  // 0x18
  public            System.String                   _inputAssetName  // 0x20
  public            System.Int32                    _inputIndex  // 0x28
  public            System.String                   _inputName  // 0x30
  public            System.Boolean                  _keepWorldTransform  // 0x38
  public            System.Boolean                  _packGeometryBeforeMerging  // 0x39
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputAssetPreset>_inputAssetPresets  // 0x40
METHODS:
  HoudiniEngineUnity.HEU_InputObjectTypeWrapper get_InputObjectType()
  System.Void set_InputObjectType(HoudiniEngineUnity.HEU_InputObjectTypeWrapper value)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputObjectPreset
TYPE:  class
TOKEN: 0x2000017
FIELDS:
  public            System.String                   _gameObjectName  // 0x10
  public            System.Boolean                  _isSceneObject  // 0x18
  public            System.Boolean                  _useTransformOffset  // 0x19
  public            UnityEngine.Vector3             _translateOffset  // 0x1C
  public            UnityEngine.Vector3             _rotateOffset  // 0x28
  public            UnityEngine.Vector3             _scaleOffset  // 0x34
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputAssetPreset
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  public            System.String                   _gameObjectName  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_VolumeLayerPreset
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  public            System.String                   _layerName  // 0x10
  public            System.Single                   _strength  // 0x18
  public            System.Boolean                  _uiExpanded  // 0x1C
  public            System.Int32                    _tile  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_VolumeCachePreset
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  public            System.String                   _objName  // 0x10
  public            System.String                   _geoName  // 0x18
  public            System.Boolean                  _uiExpanded  // 0x20
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayerPreset>_volumeLayersPresets  // 0x28
  public            System.String                   _terrainDataPath  // 0x30
  public            System.Int32                    _tile  // 0x38
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_RecookPreset
TYPE:  class
TOKEN: 0x200001B
FIELDS:
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCachePreset>_volumeCachePresets  // 0x10
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputPreset>_inputPresets  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetPresetUtility
TYPE:  class
TOKEN: 0x200001C
FIELDS:
  public    static  System.Char[]                   PRESET_IDENTIFIER  // 0x0
  public    static  System.Int32                    PRESET_VERSION  // 0x8
METHODS:
  System.Void SaveAssetPresetToFile(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String filePath)
  System.Void LoadPresetFileIntoAssetAndCook(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String filePath)
  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Vector3SerializationSurrogate
TYPE:  class
TOKEN: 0x200001D
FIELDS:
METHODS:
  System.Void System.Runtime.Serialization.ISerializationSurrogate.GetObjectData(System.Object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Object System.Runtime.Serialization.ISerializationSurrogate.SetObjectData(System.Object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Runtime.Serialization.ISurrogateSelector selector)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Vector2SerializationSurrogate
TYPE:  class
TOKEN: 0x200001E
FIELDS:
METHODS:
  System.Void System.Runtime.Serialization.ISerializationSurrogate.GetObjectData(System.Object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Object System.Runtime.Serialization.ISerializationSurrogate.SetObjectData(System.Object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Runtime.Serialization.ISurrogateSelector selector)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetSerializedMetaData
TYPE:  class
TOKEN: 0x200001F
EXTENDS: ScriptableObject
FIELDS:
  private           System.Boolean                  _softDeleted  // 0x18
  private           System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData>>_savedCurveNodeData  // 0x20
  private           System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_InputCurveInfo>_savedInputCurveInfo  // 0x28
METHODS:
  System.Boolean get_SoftDeleted()
  System.Void set_SoftDeleted(System.Boolean value)
  System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData>> get_SavedCurveNodeData()
  System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_InputCurveInfo> get_SavedInputCurveInfo()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_AssetSerializedMetaData other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetUpdater
TYPE:  class
TOKEN: 0x2000020
FIELDS:
METHODS:
  System.Void .cctor()
  System.Void OnBeforeAssemblyReload()
  System.Void Update()
  System.Void AddAssetForUpdate(HoudiniEngineUnity.HEU_HoudiniAsset asset)
  System.Void RemoveAsset(HoudiniEngineUnity.HEU_HoudiniAsset asset)
  System.Void AddNodeSyncForUpdate(HoudiniEngineUnity.HEU_BaseSync nodeSync)
  System.Void RemoveNodeSync(HoudiniEngineUnity.HEU_BaseSync nodeSync)
  System.Void OnPrefabInstanceUpdate(UnityEngine.GameObject instance)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.CurveNodeData
TYPE:  class
TOKEN: 0x2000021
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Vector3             rotation  // 0x1C
  public            UnityEngine.Vector3             scale  // 0x28
  public            System.Int32                    curveCountIndex  // 0x34
METHODS:
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Vector3 position)
  System.Void .ctor(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void .ctor(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale)
  System.Void .ctor(HoudiniEngineUnity.CurveNodeData other)
  UnityEngine.Quaternion GetRotation()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.CurveNodeData other)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputCurveInfo
TYPE:  class
TOKEN: 0x2000022
FIELDS:
  public            HoudiniEngineUnity.HAPI_CurveTypecurveType  // 0x10
  public            System.Int32                    order  // 0x14
  public            System.Boolean                  closed  // 0x18
  public            System.Boolean                  reverse  // 0x19
  public            HoudiniEngineUnity.HAPI_InputCurveMethodinputMethod  // 0x1C
  public            HoudiniEngineUnity.HAPI_InputCurveParameterizationbreakpointParameterization  // 0x20
METHODS:
  HoudiniEngineUnity.HEU_InputCurveInfo CreateFromHAPI_InputCurveInfo(HoudiniEngineUnity.HAPI_InputCurveInfo curveInfo)
  System.String[] GetCurveTypeNames()
  System.String[] GetInputMethodNames()
  System.String[] GetBreakpointParameterizationNames()
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_CurveDataType
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_CurveDataTypeINVALID  // 0x0
  public    static  HoudiniEngineUnity.HEU_CurveDataTypeGEO_COORDS_PARAM  // 0x0
  public    static  HoudiniEngineUnity.HEU_CurveDataTypeHAPI_COORDS_PARAM  // 0x0
  public    static  HoudiniEngineUnity.HEU_CurveDataTypePOSITION_ATTRIBUTE  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Curve
TYPE:  class
TOKEN: 0x2000024
EXTENDS: ScriptableObject
FIELDS:
  private           System.Int32                    _geoID  // 0x18
  private           System.Int32                    _partID  // 0x1C
  private           System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData>_curveNodeData  // 0x20
  private           UnityEngine.Vector3[]           _vertices  // 0x28
  private           System.Boolean                  _isEditable  // 0x30
  private           HoudiniEngineUnity.HEU_Parameters_parameters  // 0x38
  private           System.Boolean                  _bUploadParameterPreset  // 0x40
  private           System.String                   _curveName  // 0x48
  private           UnityEngine.GameObject          _targetGameObject  // 0x50
  private           System.Boolean                  _isGeoCurve  // 0x58
  private           HoudiniEngineUnity.HEU_Curve.CurveEditState_editState  // 0x5C
  public    static  HoudiniEngineUnity.HEU_Curve.InteractionPreferredNextInteractionMode  // 0x0
  private           HoudiniEngineUnity.HEU_HoudiniAsset_parentAsset  // 0x60
  private           System.Boolean                  _bIsInputCurve  // 0x68
  private           System.Boolean                  _bIsPartCurve  // 0x69
  private           System.Boolean                  _cachedCurveInfoValid  // 0x6A
  private           System.Int32[]                  _cachedCurveCounts  // 0x70
  private           System.Int32[]                  _cachedCurveCountSums  // 0x78
  private           HoudiniEngineUnity.HEU_CurveDataType_curveDataType  // 0x80
  private           HoudiniEngineUnity.HEU_InputCurveInfo_inputCurveInfo  // 0x88
METHODS:
  UnityEngine.GameObject get_TargetGameObject()
  System.Void set_TargetGameObject(UnityEngine.GameObject value)
  System.Int32 get_GeoID()
  System.Int32 get_PartID()
  System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> get_CurveNodeData()
  HoudiniEngineUnity.HEU_Parameters get_Parameters()
  System.String get_CurveName()
  System.Boolean get_IsInputCurve()
  System.Boolean get_IsPartCurve()
  HoudiniEngineUnity.HEU_InputCurveInfo get_InputCurveInfo()
  System.Void SetUploadParameterPreset(System.Boolean bValue)
  HoudiniEngineUnity.HEU_Curve.CurveEditState get_EditState()
  HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset()
  HoudiniEngineUnity.HEU_CurveDataType get_CurveDataType()
  HoudiniEngineUnity.HEU_SessionBase GetSession()
  System.Void Recook()
  System.Boolean IsEditable()
  System.Boolean IsGeoCurve()
  System.Void SetCurveName(System.String name)
  System.Void SetCurvePoint(System.Int32 pointIndex, UnityEngine.Vector3 newPosition, System.Boolean bRecookAsset)
  System.Void SetCurvePoint(System.Int32 pointIndex, HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset)
  System.Void SetCurveNodeData(System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> curveNodeData, System.Boolean bRecookAsset)
  UnityEngine.Vector3 GetCurvePoint(System.Int32 pointIndex)
  System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> GetAllPointTransforms()
  System.Collections.Generic.List<UnityEngine.Vector3> GetAllPoints()
  System.Int32 GetNumPoints()
  System.Void InsertCurvePoint(System.Int32 index, UnityEngine.Vector3 position, System.Boolean bRecookAsset)
  System.Void InsertCurvePoint(System.Int32 index, HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset)
  System.Void AddCurvePointToEnd(UnityEngine.Vector3 position, System.Boolean bRecookAsset)
  System.Void AddCurvePointToEnd(HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset)
  System.Void RemoveCurvePoint(System.Int32 pointIndex, System.Boolean bRecookAsset)
  System.Void ClearCurveNodeData(System.Boolean bRecookAsset)
  System.Void ProjectToColliders(UnityEngine.Vector3 rayDirection, System.Single rayDistance, System.Boolean bRecookAsset)
  System.Void SetCurveGeometryVisibility(System.Boolean bVisible, System.Boolean bRecookAsset)
  UnityEngine.Vector3 GetTransformedPoint(System.Int32 pointIndex)
  System.Collections.Generic.List<UnityEngine.Vector3> GetTransformedPoints()
  System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> DuplicateCurveNodeData()
  HoudiniEngineUnity.HEU_Curve CreateSetupCurve(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean isEditable, System.String curveName, System.Int32 geoID, System.Int32 partID, System.Boolean bGeoCurve)
  System.Void UsePreviousCurveData(System.String curveName)
  HoudiniEngineUnity.HEU_CurveDataType GetCurveDataType(HoudiniEngineUnity.HEU_SessionBase session)
  System.Boolean ShouldKeepNode(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void DestroyAllData(System.Boolean bIsRebuild)
  System.Void UploadParameterPreset(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset)
  System.Void ResetCurveParameters(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset)
  System.Void SetCurveParameterPreset(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Byte[] parameterPreset)
  System.Void UpdateCurve(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 partId)
  System.Int32[] GetCurveCounts(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoId, System.Int32 partID)
  System.Void GenerateMesh(UnityEngine.GameObject inGameObject, HoudiniEngineUnity.HEU_SessionBase session)
  System.Void GenerateMeshForSingleObject(UnityEngine.GameObject targetObject, UnityEngine.Vector3[] vertexList)
  System.Void OnPresyncParameters(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset)
  System.Int32 GetOrderForCurveType(System.Int32 requestedOrder, HoudiniEngineUnity.HAPI_CurveType curveType)
  System.Boolean UpdateCurveInputForCurveParts(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset)
  System.Boolean UpdateCurveInputForCustomAttributes(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset)
  System.Void SyncFromParameters(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean bNewCurve)
  System.Void UpdatePoints(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void ProjectToCollidersInternal(HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, UnityEngine.Vector3 rayDirection, System.Single rayDistance)
  System.String GetPointsString(System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> points)
  System.String GetPointsString(System.Collections.Generic.List<UnityEngine.Vector3> points)
  System.Void SetEditState(HoudiniEngineUnity.HEU_Curve.CurveEditState editState)
  UnityEngine.Vector3 GetTransformedPosition(UnityEngine.Vector3 inPosition)
  UnityEngine.Vector3 GetInvertedTransformedPosition(UnityEngine.Vector3 inPosition)
  UnityEngine.Vector3 GetInvertedTransformedDirection(UnityEngine.Vector3 inPosition)
  UnityEngine.Vector3[] GetVertices()
  System.Void SetCurveGeometryVisibilityInternal(System.Boolean bVisible)
  System.Void DownloadPresetData(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void UploadPresetData(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void DownloadAsDefaultPresetData(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void UpdateCachedCurveInfo(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean copyCurveSettings)
  System.Int32 GetCurveCountIndexFromPositionIndex(System.Int32 positionIndex)
  System.Boolean IsMeshCurve(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_Curve other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GeneratedOutput
TYPE:  class
TOKEN: 0x200002C
FIELDS:
  public            HoudiniEngineUnity.HEU_GeneratedOutputData_outputData  // 0x10
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutputData>_childOutputs  // 0x18
  private           System.Boolean                  isInstancer  // 0x20
METHODS:
  System.Boolean get_IsInstancer()
  System.Void set_IsInstancer(System.Boolean value)
  System.Void ResetMaterialOverrides(HoudiniEngineUnity.HEU_GeneratedOutput output)
  System.Void ResetMaterialOverrides(HoudiniEngineUnity.HEU_GeneratedOutputData outputData)
  UnityEngine.Material[] GetGeneratedMaterialsForGameObject(HoudiniEngineUnity.HEU_GeneratedOutput output, UnityEngine.GameObject inGameObject)
  System.Boolean HasLODGroup(HoudiniEngineUnity.HEU_GeneratedOutput output)
  System.Boolean IsOutputUsingMaterial(UnityEngine.Material checkMaterial, HoudiniEngineUnity.HEU_GeneratedOutput output)
  System.Boolean IsOutputDataUsingMaterial(UnityEngine.Material checkMaterial, HoudiniEngineUnity.HEU_GeneratedOutputData outputData)
  System.Void ClearGeneratedMaterialReferences(HoudiniEngineUnity.HEU_GeneratedOutputData generatedOutputData)
  System.Void DestroyAllGeneratedColliders(HoudiniEngineUnity.HEU_GeneratedOutputData outputData)
  System.Void DestroyGeneratedOutput(HoudiniEngineUnity.HEU_GeneratedOutput generatedOutput)
  System.Void DestroyGeneratedOutputChildren(HoudiniEngineUnity.HEU_GeneratedOutput generatedOutput)
  System.Void DestroyGeneratedOutputData(HoudiniEngineUnity.HEU_GeneratedOutputData generatedOutputData, System.Boolean bDontDeletePersistantResources)
  System.Void ClearMaterialsNoLongerUsed(UnityEngine.Material[] materialsToCheck, UnityEngine.Material[] materialsInUse)
  System.Void CopyMaterialOverrides(HoudiniEngineUnity.HEU_GeneratedOutputData sourceOutputData, HoudiniEngineUnity.HEU_GeneratedOutputData destOutputData)
  System.Void WriteOutputToAssetCache(UnityEngine.GameObject parentObject, System.String outputPath, System.Boolean bIsInstancer)
  System.Void BakeGameObjectComponents(UnityEngine.GameObject sourceGO, UnityEngine.GameObject targetGO, System.String assetName, System.String outputPath, System.Boolean bIsInstancer)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_GeneratedOutput other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GeneratedOutputData
TYPE:  class
TOKEN: 0x200002D
FIELDS:
  public            UnityEngine.GameObject          _gameObject  // 0x10
  public            UnityEngine.Material[]          _renderMaterials  // 0x18
  public            System.Collections.Generic.List<UnityEngine.Collider>_colliders  // 0x20
METHODS:
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_GeneratedOutputData other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GeoNode
TYPE:  class
TOKEN: 0x200002E
EXTENDS: ScriptableObject
FIELDS:
  private           HoudiniEngineUnity.HAPI_GeoInfo _geoInfo  // 0x18
  private           System.String                   _geoName  // 0x40
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData>_parts  // 0x48
  private           HoudiniEngineUnity.HEU_ObjectNode_containerObjectNode  // 0x50
  private           HoudiniEngineUnity.HEU_InputNode_inputNode  // 0x58
  private           HoudiniEngineUnity.HEU_Curve    _geoCurve  // 0x60
  private           HoudiniEngineUnity.HEU_VolumeCache_volumeCache  // 0x68
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache>_volumeCaches  // 0x70
METHODS:
  HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset()
  System.Int32 get_GeoID()
  HoudiniEngineUnity.HAPI_GeoInfo get_GeoInfo()
  System.String get_GeoName()
  HoudiniEngineUnity.HAPI_GeoType get_GeoType()
  System.Boolean get_Editable()
  System.Boolean get_Displayable()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> get_Parts()
  HoudiniEngineUnity.HEU_ObjectNode get_ObjectNode()
  HoudiniEngineUnity.HEU_InputNode get_InputNode()
  HoudiniEngineUnity.HEU_Curve get_GeoCurve()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> get_VolumeCaches()
  System.Void .ctor()
  System.Void OnBeforeSerialize()
  System.Void OnAfterDeserialize()
  HoudiniEngineUnity.HEU_SessionBase GetSession()
  System.Void Recook()
  System.Boolean IsVisible()
  System.Boolean IsIntermediate()
  System.Boolean IsIntermediateOrEditable()
  System.Boolean IsGeoInputType()
  System.Boolean IsGeoCurveType()
  System.Void DestroyAllData(System.Boolean bIsRebuild)
  System.Void RemoveAndDestroyPart(HoudiniEngineUnity.HEU_PartData part)
  System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs)
  HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject outputGameObject)
  HoudiniEngineUnity.HEU_PartData GetPartFromPartID(System.Int32 partID)
  System.Void GetCurves(System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> curves, System.Boolean bEditableOnly)
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> GetParts()
  System.Void HideAllGeometry()
  System.Void DisableAllColliders()
  HoudiniEngineUnity.HEU_VolumeCache GetVolumeCacheByTileIndex(System.Int32 tileIndex)
  System.Void Reset()
  System.Void Initialize(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_GeoInfo geoInfo, HoudiniEngineUnity.HEU_ObjectNode containerObjectNode)
  System.Boolean DoesThisRequirePotentialCook()
  System.Void UpdateGeo(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void ProcessUnityScriptAttribute(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void ProcessPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 partID, HoudiniEngineUnity.HAPI_PartInfo& partInfo, HoudiniEngineUnity.HEU_PartData& partData)
  System.Void SetupGameObjectAndTransform(HoudiniEngineUnity.HEU_PartData partData, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset)
  System.Void GetPartsByOutputType(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> meshParts, System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> volumeParts)
  System.Void GeneratePartInstances(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void GenerateAttributesStore(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void ProcessGeoCurve(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void SetupGeoCurveGameObjectAndTransform(HoudiniEngineUnity.HEU_Curve curve)
  System.Void ClearObjectInstances()
  System.Void SetGeoInfo(HoudiniEngineUnity.HAPI_GeoInfo geoInfo)
  System.String GeneratePartFullName(System.String partName)
  System.String GenerateGeoCurveName()
  System.Boolean HasGeoNodeChanged(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void ApplyHAPITransform(HoudiniEngineUnity.HAPI_Transform& hapiTransform)
  System.Void GetDebugInfo(System.Text.StringBuilder sb)
  System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData)
  System.Void GetClonableParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> clonableParts)
  System.Boolean HasAttribInstancer()
  System.Void SetAttributeModifiersOnPartOutputs(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void CalculateVisiblity(System.Boolean bParentVisibility)
  System.Void CalculateColliderState()
  System.Void ProcessVolumeParts(HoudiniEngineUnity.HEU_SessionBase session, System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> volumeParts, System.Boolean bRebuild)
  System.Void DestroyVolumeCache()
  System.String ToString()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_GeoNode other)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HoudiniAsset
TYPE:  class
TOKEN: 0x200002F
EXTENDS: MonoBehaviour
FIELDS:
  private           HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType_assetType  // 0x18
  private           HoudiniEngineUnity.HAPI_AssetInfo_assetInfo  // 0x1C
  private           HoudiniEngineUnity.HAPI_NodeInfo_nodeInfo  // 0x5C
  private           System.String                   _assetName  // 0xA0
  private           System.String                   _assetOpName  // 0xA8
  private           System.String                   _assetHelp  // 0xB0
  private           System.Int32                    _assetID  // 0xB8
  private           System.String                   _assetPath  // 0xC0
  private           System.Boolean                  _loadAssetFromMemory  // 0xC8
  private           System.Boolean                  _alwaysOverwriteOnLoad  // 0xC9
  private           UnityEngine.Object              _assetFileObject  // 0xD0
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectNode>_objectNodes  // 0xD8
  private           UnityEngine.GameObject          _rootGameObject  // 0xE0
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData>_materialCache  // 0xE8
  private           HoudiniEngineUnity.HEU_Parameters_parameters  // 0xF0
  private           UnityEngine.Matrix4x4           _lastSyncedTransformMatrix  // 0xF8
  private           System.Collections.Generic.List<UnityEngine.Matrix4x4>_lastSyncedChildTransformMatrices  // 0x138
  private           System.String                   _assetCacheFolderPath  // 0x140
  private           System.String[]                 _subassetNames  // 0x148
  private           System.Int32                    _selectedSubassetIndex  // 0x150
  private           HoudiniEngineUnity.HEU_AssetPreset_savedAssetPreset  // 0x158
  private           HoudiniEngineUnity.HEU_RecookPreset_recookPreset  // 0x160
  private           System.Int32                    _totalCookCount  // 0x168
  private           HoudiniEngineUnity.HEU_HoudiniAsset.AssetBuildAction_requestBuildAction  // 0x16C
  private           System.Boolean                  _checkParameterChangeForCook  // 0x170
  private           System.Boolean                  _skipCookCheck  // 0x171
  private           System.Boolean                  _uploadParameters  // 0x172
  private           System.Boolean                  _forceUploadInputs  // 0x173
  private           System.Boolean                  _upstreamCookChanged  // 0x174
  private           HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus_cookStatus  // 0x178
  private           HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult_lastCookResult  // 0x17C
  private           System.Boolean                  _isCookingAssetReloaded  // 0x180
  private           System.Boolean                  _bForceUpdate  // 0x181
  private           System.Int64                    _sessionID  // 0x188
  private           System.Boolean                  <WarnedPrefabNotSupported>k__BackingField  // 0x190
  private           System.Boolean                  _uiLocked  // 0x191
  private           System.Boolean                  _showHDAOptions  // 0x192
  private           System.Boolean                  _showGenerateSection  // 0x193
  private           System.Boolean                  _showBakeSection  // 0x194
  private           System.Boolean                  _showEventsSection  // 0x195
  private           System.Boolean                  _showCurvesSection  // 0x196
  private           System.Boolean                  _showInputNodesSection  // 0x197
  private           System.Boolean                  _showToolsSection  // 0x198
  private           System.Boolean                  _showTerrainSection  // 0x199
  private           HoudiniEngineUnity.HEU_InstanceInputUIState_instanceInputUIState  // 0x1A0
  private           HoudiniEngineUnity.HEU_ReloadDataEvent_reloadDataEvent  // 0x1A8
  private           HoudiniEngineUnity.HEU_CookedDataEvent_cookedDataEvent  // 0x1B0
  private           HoudiniEngineUnity.HEU_BakedDataEvent_bakedDataEvent  // 0x1B8
  private           HoudiniEngineUnity.HEU_PreAssetEvent_preAssetEvent  // 0x1C0
  private           HoudiniEngineUnity.HEU_HoudiniAsset.UpdateUIDelegate_refreshUIDelegate  // 0x1C8
  private           HoudiniEngineUnity.HEU_CookedDataEvent_downstreamConnectionCookedEvent  // 0x1D0
  private           System.Boolean                  _generateUVs  // 0x1D8
  private           System.Boolean                  _generateTangents  // 0x1D9
  private           System.Boolean                  _generateNormals  // 0x1DA
  private           System.Boolean                  _pushTransformToHoudini  // 0x1DB
  private           System.Boolean                  _transformChangeTriggersCooks  // 0x1DC
  private           System.Boolean                  _cookingTriggersDownCooks  // 0x1DD
  private           System.Boolean                  _autoCookOnParameterChange  // 0x1DE
  private           System.Boolean                  _ignoreNonDisplayNodes  // 0x1DF
  private           System.Boolean                  _useOutputNodes  // 0x1E0
  private           System.Boolean                  _generateMeshUsingPoints  // 0x1E1
  private           System.Boolean                  _useLODGroups  // 0x1E2
  private           System.Boolean                  _splitGeosByGroup  // 0x1E3
  private           System.Boolean                  _sessionSyncAutoCook  // 0x1E4
  private           System.Boolean                  _bakeUpdateKeepPreviousTransformValues  // 0x1E5
  private           System.Boolean                  _pauseCooking  // 0x1E6
  private           System.Boolean                  _curveEditorEnabled  // 0x1E7
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve>_curves  // 0x1E8
  private           HoudiniEngineUnity.HEU_Curve.CurveDrawCollision_curveDrawCollision  // 0x1F0
  private           System.Collections.Generic.List<UnityEngine.Collider>_curveDrawColliders  // 0x1F8
  private           UnityEngine.LayerMask           _curveDrawLayerMask  // 0x200
  private           System.Single                   _curveProjectMaxDistance  // 0x204
  private           UnityEngine.Vector3             _curveProjectDirection  // 0x208
  private           System.Boolean                  _curveProjectDirectionToView  // 0x214
  private           System.Boolean                  _curveDisableScaleRotation  // 0x215
  private           System.Boolean                  _curveCookOnDrag  // 0x216
  private           System.Boolean                  _curveFrameSelectedNodes  // 0x217
  private           System.Single                   _curveFrameSelectedNodeDistance  // 0x218
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode>_inputNodes  // 0x220
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle>_handles  // 0x228
  private           System.Boolean                  _handlesEnabled  // 0x230
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache>_volumeCaches  // 0x238
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributesStore>_attributeStores  // 0x240
  private           System.Boolean                  _editableNodesToolsEnabled  // 0x248
  private           HoudiniEngineUnity.HEU_ToolsInfo_toolsInfo  // 0x250
  private           HoudiniEngineUnity.HEU_AssetSerializedMetaData_serializedMetaData  // 0x258
  private           System.Boolean                  _pendingAutoCookOnMouseRelease  // 0x260
METHODS:
  System.Boolean get_LoadAssetFromMemory()
  System.Void set_LoadAssetFromMemory(System.Boolean value)
  System.Boolean get_AlwaysOverwriteOnLoad()
  System.Void set_AlwaysOverwriteOnLoad(System.Boolean value)
  System.Boolean get_GenerateUVs()
  System.Void set_GenerateUVs(System.Boolean value)
  System.Boolean get_GenerateTangents()
  System.Void set_GenerateTangents(System.Boolean value)
  System.Boolean get_GenerateNormals()
  System.Void set_GenerateNormals(System.Boolean value)
  System.Boolean get_PushTransformToHoudini()
  System.Void set_PushTransformToHoudini(System.Boolean value)
  System.Boolean get_TransformChangeTriggersCooks()
  System.Void set_TransformChangeTriggersCooks(System.Boolean value)
  System.Boolean get_CookingTriggersDownCooks()
  System.Void set_CookingTriggersDownCooks(System.Boolean value)
  System.Boolean get_AutoCookOnParameterChange()
  System.Void set_AutoCookOnParameterChange(System.Boolean value)
  System.Boolean get_IgnoreNonDisplayNodes()
  System.Void set_IgnoreNonDisplayNodes(System.Boolean value)
  System.Boolean get_UseOutputNodes()
  System.Void set_UseOutputNodes(System.Boolean value)
  System.Boolean get_GenerateMeshUsingPoints()
  System.Void set_GenerateMeshUsingPoints(System.Boolean value)
  System.Boolean get_UseLODGroups()
  System.Void set_UseLODGroups(System.Boolean value)
  System.Boolean get_SplitGeosByGroup()
  System.Void set_SplitGeosByGroup(System.Boolean value)
  System.Boolean get_SessionSyncAutoCook()
  System.Void set_SessionSyncAutoCook(System.Boolean value)
  System.Boolean get_BakeUpdateKeepPreviousTransformValues()
  System.Void set_BakeUpdateKeepPreviousTransformValues(System.Boolean value)
  System.Boolean get_PauseCooking()
  System.Void set_PauseCooking(System.Boolean value)
  System.Boolean get_CurveEditorEnabled()
  System.Void set_CurveEditorEnabled(System.Boolean value)
  HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper get_CurveDrawCollision()
  System.Void set_CurveDrawCollision(HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper value)
  UnityEngine.LayerMask get_CurveDrawLayerMask()
  System.Void set_CurveDrawLayerMask(UnityEngine.LayerMask value)
  System.Single get_CurveProjectMaxDistance()
  System.Void set_CurveProjectMaxDistance(System.Single value)
  UnityEngine.Vector3 get_CurveProjectDirection()
  System.Void set_CurveProjectDirection(UnityEngine.Vector3 value)
  System.Boolean get_CurveProjectDirectionToView()
  System.Void set_CurveProjectDirectionToView(System.Boolean value)
  System.Boolean get_CurveDisableScaleRotation()
  System.Void set_CurveDisableScaleRotation(System.Boolean value)
  System.Boolean get_CurveFrameSelectedNodes()
  System.Void set_CurveFrameSelectedNodes(System.Boolean value)
  System.Single get_CurveFrameSelectedNodeDistance()
  System.Void set_CurveFrameSelectedNodeDistance(System.Single value)
  System.Boolean get_HandlesEnabled()
  System.Void set_HandlesEnabled(System.Boolean value)
  System.Boolean get_EditableNodesToolsEnabled()
  System.Void set_EditableNodesToolsEnabled(System.Boolean value)
  HoudiniEngineUnity.HEU_AssetTypeWrapper get_AssetType()
  HoudiniEngineUnity.HAPI_AssetInfo get_AssetInfo()
  HoudiniEngineUnity.HAPI_NodeInfo get_NodeInfo()
  System.String get_AssetName()
  System.String get_AssetOpName()
  System.String get_AssetHelp()
  System.Int32 get_AssetID()
  System.String get_AssetPath()
  UnityEngine.GameObject get_OwnerGameObject()
  UnityEngine.GameObject get_RootGameObject()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> get_MaterialCache()
  HoudiniEngineUnity.HEU_Parameters get_Parameters()
  System.String get_AssetCacheFolder()
  System.String[] get_SubassetNames()
  System.Int32 get_SelectedSubassetIndex()
  HoudiniEngineUnity.HEU_AssetCookStatusWrapper get_CookStatus()
  HoudiniEngineUnity.HEU_AssetCookResultWrapper get_LastCookResult()
  System.Int64 get_SessionID()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> get_Curves()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> get_InputNodes()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> get_VolumeCaches()
  HoudiniEngineUnity.HEU_ReloadDataEvent get_ReloadDataEvent()
  HoudiniEngineUnity.HEU_CookedDataEvent get_CookedDataEvent()
  HoudiniEngineUnity.HEU_BakedDataEvent get_BakedDataEvent()
  HoudiniEngineUnity.HEU_PreAssetEvent get_PreAssetEvent()
  HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType get_AssetTypeInternal()
  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus GetCookStatus()
  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult GetLastCookResult()
  System.Boolean get_WarnedPrefabNotSupported()
  System.Void set_WarnedPrefabNotSupported(System.Boolean value)
  HoudiniEngineUnity.HEU_InstanceInputUIState get_InstanceInputUIState()
  System.Void set_InstanceInputUIState(HoudiniEngineUnity.HEU_InstanceInputUIState value)
  HoudiniEngineUnity.HEU_HoudiniAsset.UpdateUIDelegate get_RefreshUIDelegate()
  System.Void set_RefreshUIDelegate(HoudiniEngineUnity.HEU_HoudiniAsset.UpdateUIDelegate value)
  HoudiniEngineUnity.HEU_Curve.CurveDrawCollision get_CurveDrawCollisionInternal()
  System.Collections.Generic.List<UnityEngine.Collider> GetCurveDrawColliders()
  UnityEngine.LayerMask GetCurveDrawLayerMask()
  System.Void SetCurveDrawLayerMask(UnityEngine.LayerMask mask)
  System.Boolean get_CurveCookOnDrag()
  System.Void set_CurveCookOnDrag(System.Boolean value)
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> get_Handles()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributesStore> get_AttributeStores()
  HoudiniEngineUnity.HEU_ToolsInfo get_ToolsInfo()
  HoudiniEngineUnity.HEU_AssetSerializedMetaData get_SerializedMetaData()
  System.Boolean get_PendingAutoCookOnMouseRelease()
  System.Void set_PendingAutoCookOnMouseRelease(System.Boolean value)
  System.Boolean RequestCook(System.Boolean bCheckParametersChanged, System.Boolean bAsync, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters)
  System.Boolean RequestReload(System.Boolean bAsync)
  System.Boolean RequestResetParameters(System.Boolean bAsync)
  UnityEngine.GameObject DuplicateAsset(UnityEngine.GameObject newRootGameObject)
  System.Boolean DeleteAllGeneratedData(System.Boolean bIsRebuild)
  UnityEngine.GameObject BakeToNewPrefab(System.String destinationPrefabPath)
  UnityEngine.GameObject BakeToNewStandalone()
  System.Boolean BakeToExistingPrefab(UnityEngine.GameObject bakeTargetGO)
  System.Boolean BakeToExistingStandalone(UnityEngine.GameObject bakeTargetGO)
  System.Boolean IsAssetValid()
  System.Boolean GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  System.Boolean GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs)
  HoudiniEngineUnity.HEU_Curve GetCurve(System.String curveName)
  System.Boolean AddCurveDrawCollider(UnityEngine.Collider newCollider)
  System.Boolean RemoveCurveDrawCollider(UnityEngine.Collider collider)
  System.Boolean ClearCurveDrawColliders()
  HoudiniEngineUnity.HEU_InputNode GetInputNode(System.String inputName)
  HoudiniEngineUnity.HEU_InputNode GetAssetInputNode(System.String inputName)
  HoudiniEngineUnity.HEU_InputNode GetInputNodeByIndex(System.Int32 index)
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> GetNonParameterInputNodes()
  System.Int32 GetVolumeCacheCount()
  HoudiniEngineUnity.HEU_SessionBase GetAssetSession(System.Boolean bCreateIfInvalid)
  HoudiniEngineUnity.HEU_ObjectNode GetObjectNodeByName(System.String objName)
  System.Void GetOutputGeoNodes(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> outputGeoNodes)
  HoudiniEngineUnity.HEU_PartData GetInternalHDAPartWithGameObject(UnityEngine.GameObject outputGameObject)
  System.Void ResetParametersToDefault()
  System.Void HideAllGeometry()
  System.Void DisableAllColliders()
  HoudiniEngineUnity.HEU_MaterialData GetMaterialData(UnityEngine.Material material)
  System.Void ClearMaterialCache()
  System.Void RemoveMaterial(UnityEngine.Material material)
  System.Void ResetMaterialOverrides()
  HoudiniEngineUnity.HEU_AssetPreset GetAssetPreset()
  HoudiniEngineUnity.HEU_PDGAssetLink GetOrCreatePDGAssetLink()
  HoudiniEngineUnity.HEU_HoudiniAssetRoot InstantiateHDA(System.String filePath, System.Boolean bAsync, UnityEngine.Vector3 initialPosition)
  HoudiniEngineUnity.HEU_PartData GetSceneHDAPartWithGameObject(UnityEngine.GameObject outputGameObject)
  HoudiniEngineUnity.HEU_HoudiniAsset GetSceneHDAAssetFromGameObject(UnityEngine.GameObject outputGameObject)
  System.Boolean IsHoudiniAssetOutput(UnityEngine.GameObject go)
  System.Boolean IsHoudiniAssetRoot(UnityEngine.GameObject go)
  System.Void SetupAsset(HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType assetType, System.String filePath, UnityEngine.GameObject rootGameObject, HoudiniEngineUnity.HEU_SessionBase session)
  System.Void CleanUpAndDisable()
  System.Boolean IsAssetSavedInScene()
  System.Void Awake()
  System.Void InvalidateAsset()
  System.Void OnEnable()
  System.Void OnDestroy()
  System.Void AssetUpdate()
  System.Void PostAssetUpdate()
  System.Void RequestBakeInPlace()
  System.Void ClearBuildRequest()
  System.Boolean HasValidAssetPath()
  System.Void ProcessRebuild(System.Boolean bPromptForSubasset, System.Int32 desiredSubassetIndex)
  System.Void InvokeReloadEvent(System.Boolean bCookSuccess, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  System.Boolean StartRebuild(System.Boolean bPromptForSubasset, System.Int32 desiredSubassetIndex)
  System.Boolean FinishRebuild()
  System.Boolean RecookAsync(System.Boolean bCheckParamsChanged, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters, System.Boolean bUploadParameterPreset, System.Boolean bForceUploadInputs, System.Boolean bCookingSessionSync)
  System.Boolean RecookBlocking(System.Boolean bCheckParamsChanged, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters, System.Boolean bUploadParameterPreset, System.Boolean bForceUploadInputs, System.Boolean bCookingSessionSync)
  System.Void DoPostCookWork(HoudiniEngineUnity.HEU_SessionBase session)
  System.Boolean IsValidForInteraction(System.String& errorMessage)
  System.Void OnValidate()
  System.Void ExecutePostCookCallbacks()
  System.Void InvokePostCookEvent(System.Boolean bCookSuccess, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  System.Boolean InternalStartRecook(System.Boolean bCheckParamsChanged, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters, System.Boolean bUploadParameterPreset, System.Boolean bForceUploadInputs, System.Boolean bCookingSessionSync)
  System.Void InternalSetAssetID(System.Int32 assetID)
  System.Void SetCookStatus(HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus status, HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult result)
  System.Void ProcessPoskCook()
  System.Boolean StartHoudiniCookNode(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void ProcessHoudiniCookStatus(System.Boolean bAsync)
  System.Boolean DoesAssetRequireRecook()
  System.Void DeleteSessionDataOnly()
  System.Void CleanUpInputNodes()
  System.Void DeleteAssetCacheData(System.Boolean bRegisterUndo)
  System.Void GenerateParameters(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void DownloadParameterPresetFromHoudini(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void UploadParameterPresetToHoudini(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void UpdateParameterInputsToHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bForceUpdate)
  System.Boolean LoadAssetFileWithSubasset(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bPromptForSubasset, System.Int32 desiredSubassetIndex)
  System.Boolean CreateAndCookAsset(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 subassetIndex, System.Int32& newAssetID, System.Boolean bCookTemplatedGeos)
  System.Void CreateAssetInputs(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void ForceUploadParameters(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void UploadCurvesParameters(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bCheckParamsChanged)
  System.Void UploadAttributeValues(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void SyncDirtyAttributesToHoudini(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void UploadInputNodes(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bForceUpdate, System.Boolean bUpdateAll)
  System.Boolean HasInputNodeTransformChanged()
  System.Void NotifyInputNodesCookFinished()
  System.Boolean CreateObjects(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void UpdateAllObjectNodes(HoudiniEngineUnity.HEU_SessionBase session)
  HoudiniEngineUnity.HEU_ObjectNode CreateObjectNode(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ObjectInfo& objectInfo, HoudiniEngineUnity.HAPI_Transform& objectTranform)
  System.Void GenerateObjectsGeometry(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bRebuild)
  System.Int32 NumAttributeStores()
  HoudiniEngineUnity.HEU_AttributesStore GetAttributeStore(System.String geoName, System.Int32 partID)
  System.Void GenerateAttributesStore(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void GenerateInstances(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void GenerateHandles(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void CleanUpHandles()
  HoudiniEngineUnity.HEU_Handle GetHandleByName(System.String handleName)
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> GetHandles()
  System.Int32 NumHandles()
  HoudiniEngineUnity.HAPI_Transform GetObjectTransform(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 objectID)
  HoudiniEngineUnity.HEU_ObjectNode GetObjectWithID(System.Int32 objId)
  System.Void InvokeBakedEvent(System.Boolean bSuccess, System.Collections.Generic.List<UnityEngine.GameObject> outputObjects, System.Boolean isNewBake)
  UnityEngine.GameObject CloneAssetWithoutHDA(System.String& bakedAssetPath, System.Boolean bWriteMeshesToAssetDatabase, System.Boolean bReconnectPrefabInstances)
  System.Void NotifyUpstreamCooked(HoudiniEngineUnity.HEU_CookedEventData Data)
  System.Void ConnectToUpstream(HoudiniEngineUnity.HEU_HoudiniAsset upstreamAsset)
  System.Void DisconnectFromUpstream(HoudiniEngineUnity.HEU_HoudiniAsset upstreamAsset)
  System.Void AddDownstreamConnection(UnityEngine.Events.UnityAction<HoudiniEngineUnity.HEU_CookedEventData> receiver)
  System.Void RemoveDownstreamConnection(UnityEngine.Events.UnityAction<HoudiniEngineUnity.HEU_CookedEventData> receiver)
  System.Void ClearAllUpstreamConnections()
  System.Void UpdateInputsOnAssetRecreation(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void ReconnectInputsUpstreamNotifications()
  System.Void GetHoudiniTransformAndApply(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void UploadUnityTransform(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bOnlySendIfChangedFromLastSync)
  System.Void UpdateHoudiniMaterials(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void RemoveUnusedMaterials()
  System.Boolean IsAssetValidInHoudini(HoudiniEngineUnity.HEU_SessionBase session)
  System.Boolean HasTransformChangedSinceLastUpdate()
  System.Void GetClonableParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> clonableParts)
  System.Void ClearInvalidCurves()
  System.Int32 GetEditableCurveCount()
  System.Void AddCurve(HoudiniEngineUnity.HEU_Curve curve)
  System.Void RemoveCurve(HoudiniEngineUnity.HEU_Curve curve)
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> GetInputNodes()
  System.Void AddInputNode(HoudiniEngineUnity.HEU_InputNode node)
  System.Void RemoveInputNode(HoudiniEngineUnity.HEU_InputNode node)
  System.Void InputNodeNotifyRemoved(HoudiniEngineUnity.HEU_InputNode node)
  System.Void AddVolumeCache(HoudiniEngineUnity.HEU_VolumeCache cache)
  System.Void RemoveVolumeCache(HoudiniEngineUnity.HEU_VolumeCache cache)
  System.Void AddAttributeStore(HoudiniEngineUnity.HEU_AttributesStore attributeStore)
  System.Void RemoveAttributeStore(HoudiniEngineUnity.HEU_AttributesStore attributeStore)
  System.Void ReorderAttributeStore(System.Int32 oldIndex, System.Int32 newIndex)
  System.Void PopulateObjectInstanceInfos(System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> objInstanceInfos)
  System.Void AddToAssetDBCache(System.String assetObjectFileName, UnityEngine.Object objectToAdd, System.String relativeFolderPath, UnityEngine.Object& targetAssetDBObject)
  System.Void SetCurvesVisibilityInScene(System.Boolean bShow)
  System.String GetValidAssetCacheFolderPath()
  System.Void CalculateVisibility()
  System.Void CalculateColliderState()
  System.Void LoadAssetPresetAndCook(HoudiniEngineUnity.HEU_AssetPreset assetPreset)
  System.Void ApplyRecookPreset()
  System.Boolean ApplyInputPresets(HoudiniEngineUnity.HEU_SessionBase session, System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputPreset> inputPresets, System.Boolean bAddMissingInputsToRecookPreset)
  HoudiniEngineUnity.HEU_VolumeCachePreset GetVolumeCachePreset(System.String objName, System.String geoName, System.Int32 tile)
  System.Void RemoveVolumeCachePreset(HoudiniEngineUnity.HEU_VolumeCachePreset preset)
  System.Boolean ApplyVolumeCachePresets(System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCachePreset> volumeCachePresets)
  System.Void SyncInternalParametersForUndoCompare()
  System.Boolean UpdateSessionSync()
  System.Void UpdateTotalCookCount()
  System.Void ResetAndCopyInstantiatedProperties(HoudiniEngineUnity.HEU_HoudiniAsset newAsset)
  HoudiniEngineUnity.HEU_HoudiniAsset.AssetInstantiationMethod GetInstantiationMethod()
  HoudiniEngineUnity.HEU_HoudiniAsset GetInstantiatedObject()
  System.Void ClearInvalidLists()
  System.Void CopyPropertiesTo(HoudiniEngineUnity.HEU_HoudiniAsset newAsset)
  System.Void SetSoftDeleted()
  System.Void SyncChildTransforms()
  HoudiniEngineUnity.HEU_AssetCookStatusWrapper AssetCookStatus_InternalToWrappper(HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus assetCookStatus)
  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookStatus AssetCookStatus_WrapperToInternal(HoudiniEngineUnity.HEU_AssetCookStatusWrapper assetCookStatus)
  HoudiniEngineUnity.HEU_AssetCookResultWrapper AssetCookResult_InternalToWrapper(HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult assetCookResult)
  HoudiniEngineUnity.HEU_HoudiniAsset.AssetCookResult AssetCookResult_WrapperToInternal(HoudiniEngineUnity.HEU_AssetCookResultWrapper assetCookResult)
  HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper CurveDrawCollision_InternalToWrapper(HoudiniEngineUnity.HEU_Curve.CurveDrawCollision curveDrawCollision)
  HoudiniEngineUnity.HEU_Curve.CurveDrawCollision CurveDrawCollision_WrapperToInternal(HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper curveDrawCollision)
  HoudiniEngineUnity.HEU_AssetTypeWrapper AssetType_InternalToWrapper(HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType assetType)
  HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType AssetType_WrapperToInternal(HoudiniEngineUnity.HEU_AssetTypeWrapper assetType)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_HoudiniAsset asset)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HoudiniAssetRoot
TYPE:  class
TOKEN: 0x2000039
EXTENDS: MonoBehaviour
FIELDS:
  private           HoudiniEngineUnity.HEU_HoudiniAsset_houdiniAsset  // 0x18
  private           System.Collections.Generic.List<UnityEngine.GameObject>_bakeTargets  // 0x20
METHODS:
  HoudiniEngineUnity.HEU_HoudiniAsset get_HoudiniAsset()
  System.Collections.Generic.List<UnityEngine.GameObject> get_BakeTargets()
  System.Void OnDestroy()
  System.Void RemoveHoudiniEngineAssetData()
  System.Void ClearHoudiniEngineReferences()
  System.Void DestroyRootComponent(HoudiniEngineUnity.HEU_HoudiniAssetRoot assetRoot)
  System.Void Reset()
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputNode
TYPE:  class
TOKEN: 0x200003A
EXTENDS: ScriptableObject
FIELDS:
  private           HoudiniEngineUnity.HEU_InputNode.InputNodeType_inputNodeType  // 0x18
  private           HoudiniEngineUnity.HEU_InputNode.InputObjectType_inputObjectType  // 0x1C
  private           HoudiniEngineUnity.HEU_InputNode.InputObjectType_pendingInputObjectType  // 0x20
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputObjectInfo>_inputObjects  // 0x28
  private           System.Collections.Generic.List<System.Int32>_inputObjectsConnectedAssetIDs  // 0x30
  private           UnityEngine.GameObject          _inputAsset  // 0x38
  private           UnityEngine.GameObject          _connectedInputAsset  // 0x40
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputHDAInfo>_inputAssetInfos  // 0x48
  private           System.Int32                    _nodeID  // 0x50
  private           System.Int32                    _inputIndex  // 0x54
  private           System.Boolean                  _requiresCook  // 0x58
  private           System.Boolean                  _requiresUpload  // 0x59
  private           System.String                   _inputName  // 0x60
  private           System.String                   _labelName  // 0x68
  private           System.String                   _paramName  // 0x70
  private           System.Int32                    _connectedNodeID  // 0x78
  private           System.Boolean                  _keepWorldTransform  // 0x7C
  private           System.Boolean                  _packGeometryBeforeMerging  // 0x7D
  private           HoudiniEngineUnity.HEU_HoudiniAsset_parentAsset  // 0x80
  private           HoudiniEngineUnity.HEU_InputInterfaceMeshSettings_meshSettings  // 0x88
  private           HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings_tilemapSettings  // 0x90
  private           System.Boolean                  _usingSelectFromHierarchy  // 0x98
  public            HoudiniEngineUnity.HEU_InputNodeUICache_uiCache  // 0xA0
METHODS:
  HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset()
  System.Boolean get_KeepWorldTransform()
  System.Void set_KeepWorldTransform(System.Boolean value)
  System.Boolean get_PackGeometryBeforeMerging()
  System.Void set_PackGeometryBeforeMerging(System.Boolean value)
  HoudiniEngineUnity.HEU_InputNodeTypeWrapper get_NodeType()
  HoudiniEngineUnity.HEU_InputObjectTypeWrapper get_ObjectType()
  HoudiniEngineUnity.HEU_InputObjectTypeWrapper get_PendingObjectType()
  System.Void set_PendingObjectType(HoudiniEngineUnity.HEU_InputObjectTypeWrapper value)
  System.Int32 get_InputNodeID()
  System.String get_InputName()
  System.String get_LabelName()
  System.String get_ParamName()
  HoudiniEngineUnity.HEU_InputInterfaceMeshSettings get_MeshSettings()
  HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings get_TilemapSettings()
  HoudiniEngineUnity.HEU_InputNode.InputNodeType get_InputType()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputObjectInfo> get_InputObjects()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputHDAInfo> get_InputAssetInfos()
  System.Boolean get_RequiresCook()
  System.Void set_RequiresCook(System.Boolean value)
  System.Boolean get_RequiresUpload()
  System.Void set_RequiresUpload(System.Boolean value)
  HoudiniEngineUnity.HEU_SessionBase GetSession()
  System.Void Recook()
  System.Boolean IsAssetInput()
  System.Int32 NumInputEntries()
  UnityEngine.GameObject GetInputEntryGameObject(System.Int32 index)
  UnityEngine.GameObject[] GetInputEntryGameObjects()
  System.Void SetInputEntry(System.Int32 index, UnityEngine.GameObject newInputGameObject, System.Boolean bRecookAsset)
  System.Void InsertInputEntry(System.Int32 index, UnityEngine.GameObject newInputGameObject, System.Boolean bRecookAsset)
  System.Void AddInputEntryAtEnd(UnityEngine.GameObject newEntryGameObject, System.Boolean bRecookAsset)
  System.Void ResetInputNode(System.Boolean bRecookAsset)
  System.Void ChangeInputType(HoudiniEngineUnity.HEU_InputObjectTypeWrapper newType, System.Boolean bRecookAsset)
  System.Void RemoveInputEntry(System.Int32 index, System.Boolean bRecookAsset)
  System.Void RemoveAllInputEntries(System.Boolean bRecookAsset)
  System.Void SetInputEntryObjectUseTransformOffset(System.Int32 index, System.Boolean value, System.Boolean bRecookAsset)
  System.Void SetInputEntryObjectTransformTranslateOffset(System.Int32 index, UnityEngine.Vector3 translateOffset, System.Boolean bRecookAsset)
  System.Void SetInputEntryObjectTransformRotateOffset(System.Int32 index, UnityEngine.Vector3 rotateOffset, System.Boolean bRecookAsset)
  System.Void SetInputEntryObjectTransformScaleOffset(System.Int32 index, UnityEngine.Vector3 scaleOffset, System.Boolean bRecookAsset)
  System.Boolean AreAnyInputHDAsConnected()
  System.Int32 GetConnectedInputCount()
  System.Int32 GetConnectedNodeID(System.Int32 index)
  System.Void LoadPreset(HoudiniEngineUnity.HEU_InputPreset inputPreset)
  System.Void PopulateInputPreset(HoudiniEngineUnity.HEU_InputPreset inputPreset)
  HoudiniEngineUnity.HEU_InputNode CreateSetupInput(System.Int32 nodeID, System.Int32 inputIndex, System.String inputName, System.String labelName, HoudiniEngineUnity.HEU_InputNode.InputNodeType inputNodeType, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset)
  System.Void SetInputNodeID(System.Int32 nodeID)
  System.Void DestroyAllData(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void ResetInputObjectTransforms()
  System.Void ResetInputNode(HoudiniEngineUnity.HEU_SessionBase session)
  HoudiniEngineUnity.HEU_InputObjectInfo AddInputEntryAtEndMesh(UnityEngine.GameObject newEntryGameObject)
  HoudiniEngineUnity.HEU_InputHDAInfo AddInputEntryAtEndHDA(UnityEngine.GameObject newEntryGameObject)
  System.Void ChangeInputType(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputNode.InputObjectType newType)
  System.Void ResetConnectionForForceUpdate(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void UploadInput(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void UploadHDAInput(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void UploadUnityInput(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void ReconnectToUpstreamAsset()
  HoudiniEngineUnity.HEU_InputObjectInfo CreateInputObjectInfo(UnityEngine.GameObject inputGameObject)
  HoudiniEngineUnity.HEU_InputHDAInfo CreateInputHDAInfo(UnityEngine.GameObject inputGameObject)
  HoudiniEngineUnity.HEU_InputObjectInfo InternalAddInputObjectAtEnd(UnityEngine.GameObject newInputGameObject)
  HoudiniEngineUnity.HEU_InputHDAInfo InternalAddInputHDAAtEnd(UnityEngine.GameObject newInputHDA)
  System.Void DisconnectConnectedMergeNode(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void ClearConnectedInputHDAs()
  System.Void ConnectToMergeObject(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void DisconnectAndDestroyInputs(HoudiniEngineUnity.HEU_SessionBase session)
  System.Boolean UploadObjectMergeTransformType(HoudiniEngineUnity.HEU_SessionBase session)
  System.Boolean UploadObjectMergePackGeometry(HoudiniEngineUnity.HEU_SessionBase session)
  System.Boolean HasInputNodeTransformChanged()
  System.Void UploadInputObjectTransforms(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void UpdateOnAssetRecreation(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void CopyInputValuesTo(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputNode destInputNode)
  System.Void LoadPreset(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputPreset inputPreset)
  System.Boolean FindAddToInputHDA(System.String gameObjectName)
  System.Void NotifyParentRemovedInput()
  System.Void ClearUICache()
  System.Void HandleSelectedObjectsForInputObjects(UnityEngine.GameObject[] selectedObjects)
  System.Void HandleSelectedObjectsForInputHDAs(UnityEngine.GameObject[] selectedObjects)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InputNode other)
  HoudiniEngineUnity.HEU_InputNode.InternalObjectType GetInternalObjectType(HoudiniEngineUnity.HEU_InputNode.InputObjectType type)
  HoudiniEngineUnity.HEU_InputNodeTypeWrapper InputNodeType_InternalToWrapper(HoudiniEngineUnity.HEU_InputNode.InputNodeType inputNodeType)
  HoudiniEngineUnity.HEU_InputNode.InputNodeType InputNodeType_InternalToWrapper(HoudiniEngineUnity.HEU_InputNodeTypeWrapper inputNodeType)
  HoudiniEngineUnity.HEU_InputObjectTypeWrapper InputObjectType_InternalToWrapper(HoudiniEngineUnity.HEU_InputNode.InputObjectType inputType)
  HoudiniEngineUnity.HEU_InputNode.InputObjectType InputObjectType_WrapperToInternal(HoudiniEngineUnity.HEU_InputObjectTypeWrapper inputType)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputObjectInfo
TYPE:  class
TOKEN: 0x200003F
FIELDS:
  public            UnityEngine.GameObject          _gameObject  // 0x10
  public            UnityEngine.Terrain             _terrainReference  // 0x18
  public            HEU_BoundingVolume              _boundingVolumeReference  // 0x20
  public            UnityEngine.Tilemaps.Tilemap    _tilemapReference  // 0x28
  public            UnityEngine.Matrix4x4           _syncdTransform  // 0x30
  public            System.Collections.Generic.List<UnityEngine.Matrix4x4>_syncdChildTransforms  // 0x70
  public            System.Boolean                  _useTransformOffset  // 0x78
  public            UnityEngine.Vector3             _translateOffset  // 0x7C
  public            UnityEngine.Vector3             _rotateOffset  // 0x88
  public            UnityEngine.Vector3             _scaleOffset  // 0x94
  public            System.Type                     _inputInterfaceType  // 0xA0
METHODS:
  System.Void CopyTo(HoudiniEngineUnity.HEU_InputObjectInfo destObject)
  System.Void SetReferencesFromGameObject()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InputObjectInfo other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputHDAInfo
TYPE:  class
TOKEN: 0x2000040
FIELDS:
  public            UnityEngine.GameObject          _pendingGO  // 0x10
  public            UnityEngine.GameObject          _connectedGO  // 0x18
  public            System.Int32                    _connectedInputNodeID  // 0x20
  public            System.Int32                    _connectedMergeNodeID  // 0x24
METHODS:
  System.Void CopyTo(HoudiniEngineUnity.HEU_InputHDAInfo destInfo)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InputHDAInfo other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputNodeUICache
TYPE:  class
TOKEN: 0x2000041
FIELDS:
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNodeUICache.HEU_InputObjectUICache>_inputObjectCache  // 0x10
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNodeUICache.HEU_InputAssetUICache>_inputAssetCache  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InstanceInputUIState
TYPE:  class
TOKEN: 0x2000044
EXTENDS: ScriptableObject
FIELDS:
  public            System.Boolean                  _showInstanceInputs  // 0x18
  public            System.Int32                    _numInputsToShowUI  // 0x1C
  public            System.Int32                    _inputsPageIndexUI  // 0x20
METHODS:
  System.Void CopyTo(HoudiniEngineUnity.HEU_InstanceInputUIState dest)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InstanceInputUIState other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ObjectInstanceInfo
TYPE:  class
TOKEN: 0x2000045
EXTENDS: ScriptableObject
FIELDS:
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_InstancedInput>_instancedInputs  // 0x18
  public            HoudiniEngineUnity.HEU_PartData _partTarget  // 0x20
  public            System.Int32                    _instancedObjectNodeID  // 0x28
  public            System.String                   _instancedObjectPath  // 0x30
  public            System.Collections.Generic.List<UnityEngine.GameObject>_instances  // 0x38
METHODS:
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ObjectInstanceInfo other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InstancedInput
TYPE:  class
TOKEN: 0x2000046
FIELDS:
  public            UnityEngine.GameObject          _instancedGameObject  // 0x10
  public            UnityEngine.Vector3             _rotationOffset  // 0x18
  public            UnityEngine.Vector3             _scaleOffset  // 0x24
METHODS:
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_InstancedInput other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ObjectNode
TYPE:  class
TOKEN: 0x2000047
EXTENDS: ScriptableObject
FIELDS:
  private           System.String                   _objName  // 0x18
  private           HoudiniEngineUnity.HEU_HoudiniAsset_parentAsset  // 0x20
  private           HoudiniEngineUnity.HAPI_ObjectInfo_objectInfo  // 0x28
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode>_geoNodes  // 0x48
  private           HoudiniEngineUnity.HAPI_Transform_objectTransform  // 0x50
  private           System.Collections.Generic.List<System.Int32>_recentlyDestroyedParts  // 0x78
METHODS:
  HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset()
  System.Int32 get_ObjectID()
  System.String get_ObjectName()
  HoudiniEngineUnity.HAPI_ObjectInfo get_ObjectInfo()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> get_GeoNodes()
  HoudiniEngineUnity.HAPI_Transform get_ObjectTransform()
  HoudiniEngineUnity.HEU_SessionBase GetSession()
  System.Void Recook()
  System.Boolean IsInstanced()
  System.Boolean IsVisible()
  System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData)
  System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs)
  HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject outputGameObject)
  HoudiniEngineUnity.HEU_GeoNode GetGeoNode(System.String geoName)
  System.Void GetCurves(System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> curves, System.Boolean bEditableOnly)
  System.Void GetOutputGeoNodes(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> outGeoNodes)
  System.Void HideAllGeometry()
  System.Void DisableAllColliders()
  System.Boolean IsInstancer()
  System.Void .ctor()
  System.Void Reset()
  System.Void SyncWithObjectInfo(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void Initialize(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ObjectInfo objectInfo, HoudiniEngineUnity.HAPI_Transform objectTranform, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean bUseOutputNodes)
  System.Void GatherAllAssetOutputsLegacy(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ObjectInfo objectInfo, System.Boolean bUseOutputNodes, System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode>& geoNodes)
  System.Void DestroyAllData(System.Boolean bIsRebuild)
  HoudiniEngineUnity.HEU_GeoNode CreateGeoNode(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_GeoInfo geoInfo)
  System.Void GetDebugInfo(System.Text.StringBuilder sb)
  System.Void SetObjectInfo(HoudiniEngineUnity.HAPI_ObjectInfo newObjectInfo)
  System.Void UpdateObject(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bForceUpdate)
  System.Void GenerateGeometry(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bRebuild)
  System.Void GeneratePartInstances(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void GenerateAttributesStore(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void ApplyObjectTransformToGeoNodes()
  System.Void GetClonableParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> clonableParts)
  System.Void GenerateObjectInstances(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void ClearObjectInstances(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void PopulateObjectInstanceInfos(System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> objInstanceInfos)
  System.Void ProcessUnityScriptAttributes(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void CalculateVisibility()
  System.Void CalculateColliderState()
  System.String ToString()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ObjectNode other)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PartData
TYPE:  class
TOKEN: 0x2000048
EXTENDS: ScriptableObject
FIELDS:
  private           System.Int32                    _partID  // 0x18
  private           System.String                   _partName  // 0x20
  private           System.Int32                    _objectNodeID  // 0x28
  private           System.Int32                    _geoID  // 0x2C
  private           HoudiniEngineUnity.HAPI_PartType_partType  // 0x30
  private           HoudiniEngineUnity.HEU_GeoNode  _geoNode  // 0x38
  private           System.Boolean                  _isAttribInstancer  // 0x40
  private           System.Boolean                  _isPartInstanced  // 0x41
  private           System.Int32                    _partPointCount  // 0x44
  private           System.Boolean                  _isObjectInstancer  // 0x48
  private           System.Boolean                  _objectInstancesGenerated  // 0x49
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo>_objectInstanceInfos  // 0x50
  private           UnityEngine.Vector3             _terrainOffsetPosition  // 0x58
  private           UnityEngine.Object              _assetDBTerrainData  // 0x68
  private           System.Boolean                  _isPartEditable  // 0x70
  private           HoudiniEngineUnity.HEU_PartData.PartOutputType_partOutputType  // 0x74
  private           HoudiniEngineUnity.HEU_Curve    _curve  // 0x78
  private           HoudiniEngineUnity.HEU_AttributesStore_attributesStore  // 0x80
  private           System.Boolean                  _haveInstancesBeenGenerated  // 0x88
  private           System.Int32                    _meshVertexCount  // 0x8C
  private           HoudiniEngineUnity.HEU_GeneratedOutput_generatedOutput  // 0x90
  private           System.String                   _volumeLayerName  // 0x98
METHODS:
  HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset()
  System.Int32 get_PartID()
  System.String get_PartName()
  System.Int32 get_GeoID()
  HoudiniEngineUnity.HAPI_PartType get_PartType()
  HoudiniEngineUnity.HEU_GeoNode get_ParentGeoNode()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> get_ObjectInstanceInfos()
  HoudiniEngineUnity.HEU_Curve get_Curve()
  System.Int32 get_MeshVertexCount()
  HoudiniEngineUnity.HEU_GeneratedOutput get_GeneratedOutput()
  UnityEngine.GameObject get_OutputGameObject()
  System.Void .ctor()
  HoudiniEngineUnity.HEU_SessionBase GetSession()
  System.Void Recook()
  System.Boolean IsPartInstancer()
  System.Boolean IsAttribInstancer()
  System.Boolean IsInstancerAnyType()
  System.Boolean IsPartInstanced()
  System.Int32 GetPartPointCount()
  System.Boolean IsObjectInstancer()
  System.Boolean IsPartVolume()
  System.Boolean IsPartCurve()
  System.Boolean IsPartMesh()
  System.Boolean IsPartEditable()
  System.Boolean HaveInstancesBeenGenerated()
  System.Void SetGameObjectName(System.String partName)
  System.Void SetGameObject(UnityEngine.GameObject gameObject)
  System.Void SetVolumeLayerName(System.String name)
  System.String GetVolumeLayerName()
  System.Void DestroyAllData(System.Boolean bIsRebuild)
  System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData)
  System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs)
  HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject inGameObject)
  System.Void CalculateVisibility(System.Boolean bParentVisibility, System.Boolean bParentDisplayGeo)
  System.Void ClearInstances()
  HoudiniEngineUnity.HEU_Curve GetCurve(System.Boolean bEditableOnly)
  System.Void SetVisiblity(System.Boolean bVisibility)
  System.Void SetColliderState(System.Boolean bEnabled)
  HoudiniEngineUnity.HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectPath(System.String path)
  HoudiniEngineUnity.HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectID(System.Int32 objNodeID)
  System.Void SetTerrainOffsetPosition(UnityEngine.Vector3 offsetPosition)
  System.Void SetTerrainData(UnityEngine.TerrainData terrainData, System.String exportPathRelative, System.String exportPathUser)
  System.Void Initialize(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 partID, System.Int32 geoID, System.Int32 objectNodeID, HoudiniEngineUnity.HEU_GeoNode geoNode, HoudiniEngineUnity.HAPI_PartInfo& partInfo, HoudiniEngineUnity.HEU_PartData.PartOutputType partOutputType, System.Boolean isEditable, System.Boolean isObjectInstancer, System.Boolean isAttribInstancer)
  System.Void ApplyHAPITransform(HoudiniEngineUnity.HAPI_Transform& hapiTransform)
  System.Void GetDebugInfo(System.Text.StringBuilder sb)
  System.Void GetClonableObjects(System.Collections.Generic.List<UnityEngine.GameObject> clonableObjects)
  System.Void GetClonableParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> clonableParts)
  System.Void SetObjectInstancer(System.Boolean bObjectInstancer)
  System.Void ClearObjectInstanceInfos()
  System.Void ClearInvalidObjectInstanceInfos()
  System.Void ClearGeneratedData()
  System.Void ClearGeneratedMeshOutput()
  System.Void ClearGeneratedVolumeOutput()
  System.Boolean GeneratePartInstances(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void GenerateInstancesFromObjectID(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 objectNodeID, System.String[] instancePrefixes, System.String[] instanceMaterialPaths)
  System.Void GenerateInstancesFromObject(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_ObjectNode sourceObject, System.String[] instancePrefixes, System.String[] instanceMaterialPaths)
  System.Void GenerateInstancesFromObjectIds(HoudiniEngineUnity.HEU_SessionBase session, System.String[] instancePrefixes, System.String[] instanceMaterialPaths)
  System.Void GenerateInstancesFromUnityAssetPathAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.String unityInstanceAttr)
  System.Void CreateNewInstanceFromObject(UnityEngine.GameObject sourceObject, System.Int32 instanceIndex, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HAPI_Transform& hapiTransform, System.Int32 instancedObjectNodeID, System.String instancedObjectPath, UnityEngine.Vector3 rotationOffset, UnityEngine.Vector3 scaleOffset, System.String[] instancePrefixes, System.String[] instanceMaterialPaths, UnityEngine.GameObject collisionSrcGO, System.Boolean copyParentFlags)
  System.Void GenerateAttributesStore(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void CalculateColliderState()
  System.Void CopyGameObjectComponents(HoudiniEngineUnity.HEU_PartData partData, UnityEngine.GameObject sourceGO, UnityEngine.GameObject targetGO, System.String assetName, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bDeleteExistingComponents, System.Boolean bDontDeletePersistantResources, System.Collections.Generic.List<HoudiniEngineUnity.TransformData> lodTransformValues)
  System.Void CopyChildGameObjects(HoudiniEngineUnity.HEU_PartData partData, UnityEngine.GameObject sourceGO, UnityEngine.GameObject targetGO, System.String assetName, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bDeleteExistingComponents, System.Boolean bDontDeletePersistantResources, System.Boolean bKeepPreviousTransformValues)
  UnityEngine.GameObject BakePartToNewGameObject(UnityEngine.Transform parentTransform, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bReconnectPrefabInstances)
  System.Void BakePartToGameObject(HoudiniEngineUnity.HEU_PartData partData, UnityEngine.GameObject srcGO, UnityEngine.GameObject targetGO, System.String assetName, System.Boolean bIsInstancer, System.Boolean bDeleteExistingComponents, System.Boolean bDontDeletePersistantResources, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bReconnectPrefabInstances, System.Boolean bKeepPreviousTransformValues)
  System.Void BakePartToGameObject(UnityEngine.GameObject targetGO, System.Boolean bDeleteExistingComponents, System.Boolean bDontDeletePersistantResources, System.Boolean bWriteMeshesToAssetDatabase, System.String& bakedAssetPath, System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> sourceToTargetMeshMap, System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> sourceToCopiedMaterials, UnityEngine.Object& assetDBObject, System.String assetObjectFileName, System.Boolean bReconnectPrefabInstances, System.Boolean bKeepPreviousTransformValues)
  System.Boolean GenerateMesh(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bUseLODGroups)
  System.Void ProcessCurvePart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 partId)
  System.Void SyncAttributesStore(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, HoudiniEngineUnity.HAPI_PartInfo& partInfo)
  System.Void SetupAttributeGeometry(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void DestroyAttributesStore()
  System.Void PopulateObjectInstanceInfos(System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> objInstanceInfos)
  System.Void SetObjectInstanceInfos(System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> sourceObjectInstanceInfos)
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> GetObjectInstanceInfos()
  HoudiniEngineUnity.HEU_ObjectInstanceInfo CreateObjectInstanceInfo(UnityEngine.GameObject instancedObject, System.Int32 instancedObjectNodeID, System.String instancedObjectPath)
  System.String AppendBakedCloneName(System.String name)
  System.String ToString()
  System.Void DestroyParts(System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> parts, System.Boolean bIsRebuild)
  System.Void DestroyPart(HoudiniEngineUnity.HEU_PartData part, System.Boolean bIsRebuild)
  System.Boolean ComposeUnityInstanceSplitHierarchy(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.Transform parentTransform, System.Int32 numInstances, UnityEngine.Transform[]& instanceToChildTransform)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_PartData other)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AttributeData
TYPE:  class
TOKEN: 0x200004E
FIELDS:
  public            HoudiniEngineUnity.HAPI_AttributeInfo_attributeInfo  // 0x10
  public            System.String                   _name  // 0x38
  public            HoudiniEngineUnity.HEU_AttributeData.AttributeType_attributeType  // 0x40
  public            System.Int32[]                  _intValues  // 0x48
  public            System.Single[]                 _floatValues  // 0x50
  public            System.String[]                 _stringValues  // 0x58
  public            HoudiniEngineUnity.HEU_AttributeData.AttributeState_attributeState  // 0x60
METHODS:
  System.Boolean IsColorAttribute()
  System.Void CopyValuesTo(HoudiniEngineUnity.HEU_AttributeData destAttrData)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_AttributeData other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AttributesStore
TYPE:  class
TOKEN: 0x2000051
EXTENDS: ScriptableObject
FIELDS:
  private           System.Int32                    _geoID  // 0x18
  private           System.Int32                    _partID  // 0x1C
  private           System.String                   _geoName  // 0x20
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributeData>_attributeDatas  // 0x28
  private           System.Boolean                  _hasColorAttribute  // 0x30
  private           UnityEngine.Material            _localMaterial  // 0x38
  private           UnityEngine.Transform           _outputTransform  // 0x40
  private           UnityEngine.Vector3[]           _positionAttributeValues  // 0x48
  private           System.Int32[]                  _vertexIndices  // 0x50
  private           UnityEngine.GameObject          _outputGameObject  // 0x58
  private           UnityEngine.Mesh                _outputMesh  // 0x60
  private           UnityEngine.Material[]          _outputMaterials  // 0x68
  private           UnityEngine.MeshCollider        _outputCollider  // 0x70
  private           UnityEngine.Mesh                _outputColliderMesh  // 0x78
  private           UnityEngine.MeshCollider        _outputMeshCollider  // 0x80
  private           UnityEngine.MeshCollider        _localMeshCollider  // 0x88
  private           System.Boolean                  _outputMeshRendererInitiallyEnabled  // 0x90
  private           System.Boolean                  _outputMeshColliderInitiallyEnabled  // 0x91
METHODS:
  System.Int32 get_GeoID()
  System.Int32 get_PartID()
  System.String get_GeoName()
  System.Boolean HasColorAttribute()
  UnityEngine.Transform get_OutputTransform()
  UnityEngine.Mesh get_OutputMesh()
  System.Void DestroyAllData(HoudiniEngineUnity.HEU_HoudiniAsset asset)
  System.Void SyncAllAttributesFrom(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Int32 geoID, HoudiniEngineUnity.HAPI_PartInfo& partInfo, UnityEngine.GameObject outputGameObject)
  System.Void SetupMeshAndMaterials(HoudiniEngineUnity.HEU_HoudiniAsset asset, HoudiniEngineUnity.HAPI_PartType partType, UnityEngine.GameObject outputGameObject)
  System.Boolean HasDirtyAttributes()
  System.Void SyncDirtyAttributesToHoudini(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void PopulateAttributeData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_AttributeData attributeData, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo)
  System.Void GetAttributesList(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributeData> attributesList, HoudiniEngineUnity.HAPI_AttributeOwner ownerType, System.Int32 attributeCount)
  System.Void UpdateAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_AttributeData attributeData)
  System.Void UpdateAttributeList(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_AttributeData> attributeDataList)
  System.Void RefreshUpstreamInputs(HoudiniEngineUnity.HEU_SessionBase session)
  System.Boolean UploadAttributeViaMeshInput(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID)
  System.Void SetAttributeDataSyncd(HoudiniEngineUnity.HEU_AttributeData attributeData)
  System.Void SetAttributeDataDirty(HoudiniEngineUnity.HEU_AttributeData attributeData)
  HoudiniEngineUnity.HEU_AttributeData CreateAttribute(System.String attributeName, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo)
  HoudiniEngineUnity.HEU_AttributeData GetAttributeData(System.String name)
  HoudiniEngineUnity.HEU_AttributeData GetAttributeData(System.Int32 index)
  System.Collections.Generic.List<System.String> GetAttributeNames()
  System.Void EnablePaintCollider()
  System.Void DisablePaintCollider()
  System.Void ShowPaintMesh()
  System.Void HidePaintMesh()
  System.Boolean HasMeshForPainting()
  UnityEngine.MeshCollider GetPaintMeshCollider()
  System.Void PaintAttribute(HoudiniEngineUnity.HEU_AttributeData attributeData, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 attributeIndex, System.Single paintFactor, HoudiniEngineUnity.HEU_AttributesStore.SetAttributeValueFunc setAttrFunc)
  System.Void SetAttributeEditValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 startIndex, System.Int32[] values)
  System.Void SetAttributeEditValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 startIndex, System.Single[] values)
  System.Void SetAttributeEditValueString(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 startIndex, System.String[] values)
  System.Void ReplaceAttributeValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  System.Void AddAttributeValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  System.Void SubtractAttributeValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  System.Void MultiplyAttributeValueInt(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  System.Void ReplaceAttributeValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  System.Void AddAttributeValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  System.Void SubtractAttributeValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  System.Void MultiplyAttributeValueFloat(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  System.Void SetAttributeValueString(HoudiniEngineUnity.HEU_AttributeData attributeData, System.Int32 targetIndex, HoudiniEngineUnity.HEU_ToolsInfo sourceTools, System.Int32 sourceIndex, System.Single factor)
  System.Void FillAttribute(HoudiniEngineUnity.HEU_AttributeData attributeData, HoudiniEngineUnity.HEU_ToolsInfo sourceTools)
  System.Boolean AreAttributesDirty()
  System.Void GetPositionAttributeValues(UnityEngine.Vector3[]& positionArray)
  System.Void GetVertexIndices(System.Int32[]& indices)
  HoudiniEngineUnity.HEU_AttributesStore.SetAttributeValueFunc GetAttributeSetValueFunction(HoudiniEngineUnity.HEU_AttributeData.AttributeType attrType, HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeMode paintMergeMode)
  System.Void CopyAttributeValuesTo(HoudiniEngineUnity.HEU_AttributesStore destAttrStore)
  System.Boolean IsValidStore(HoudiniEngineUnity.HEU_SessionBase session)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_AttributesStore other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_OutputAttribute
TYPE:  class
TOKEN: 0x2000053
FIELDS:
  public            System.String                   _name  // 0x10
  public            HoudiniEngineUnity.HAPI_AttributeOwner_class  // 0x18
  public            HoudiniEngineUnity.HAPI_StorageType_type  // 0x1C
  public            System.Int32                    _count  // 0x20
  public            System.Int32                    _tupleSize  // 0x24
  public            System.Int32[]                  _intValues  // 0x28
  public            System.Single[]                 _floatValues  // 0x30
  public            System.String[]                 _stringValues  // 0x38
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_OutputAttributeDictionary
TYPE:  class
TOKEN: 0x2000054
EXTENDS: HEU_SerializableDictionary`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_OutputAttributesStore
TYPE:  class
TOKEN: 0x2000055
EXTENDS: MonoBehaviour
FIELDS:
  private           HoudiniEngineUnity.HEU_OutputAttributeDictionary_attributes  // 0x18
METHODS:
  System.Void SetAttribute(HoudiniEngineUnity.HEU_OutputAttribute attribute)
  HoudiniEngineUnity.HEU_OutputAttribute GetAttribute(System.String name)
  System.Void Clear()
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetDatabase
TYPE:  class
TOKEN: 0x2000056
FIELDS:
METHODS:
  System.String GetAssetCachePath()
  System.String GetUnityProjectPath()
  System.String GetAssetRelativePath(System.String inFullPath)
  System.String GetPackagesRelativePath(System.String inFullPath)
  System.String GetValidAssetPath(System.String inPath)
  System.String GetAssetPath(UnityEngine.Object asset)
  System.String GetAssetPathWithSubAssetSupport(UnityEngine.Object asset)
  System.Void GetSubAssetPathFromPath(System.String fullPath, System.String& mainPath, System.String& subPath)
  System.String GetAssetRelativePathStart()
  System.String GetPackagesRelativePathStart()
  System.String GetAssetFullPath(System.String inPath)
  System.Boolean IsPathRelativeToAssets(System.String inPath)
  System.Boolean IsPathRelativeToPackages(System.String inPath)
  System.String GetAssetRootPath(UnityEngine.Object asset)
  System.String GetUniqueAssetPath(System.String path)
  System.String GetAssetOrScenePath(UnityEngine.Object inputObject)
  System.Boolean IsPathInAssetCache(System.String path)
  System.Boolean IsPathInAssetCacheBakedFolder(System.String path)
  System.Boolean IsPathInAssetCacheWorkingFolder(System.String path)
  System.Boolean IsAssetInAssetCacheBakedFolder(UnityEngine.Object asset)
  System.Boolean IsAssetInAssetCacheWorkingFolder(UnityEngine.Object asset)
  System.String CreateAssetCacheFolder(System.String suggestedAssetPath, System.Int32 hash)
  System.Void DeleteAssetCacheFolder(System.String assetCacheFolderPath)
  System.Void DeleteAsset(UnityEngine.Object asset)
  System.Void DeleteAssetAtPath(System.String path)
  System.Void DeleteAssetIfInBakedFolder(UnityEngine.Object asset)
  System.Boolean ContainsAsset(UnityEngine.Object assetObject)
  System.Boolean CopyAsset(System.String path, System.String newPath)
  UnityEngine.Object CopyAndLoadAssetWithRelativePath(UnityEngine.Object srcAsset, System.String copyAssetFolder, System.String relativePath, System.Type type, System.Boolean bOverwriteExisting)
  UnityEngine.Object CopyAndLoadAssetFromAssetCachePath(UnityEngine.Object srcAsset, System.String copyPath, System.Type type, System.Boolean bOverwriteExisting)
  UnityEngine.Object CopyAndLoadAssetAtAnyPath(UnityEngine.Object srcAsset, System.String copyPath, System.Type type, System.Boolean bOverwriteExisting)
  UnityEngine.Object CopyAndLoadAssetAtGivenPath(UnityEngine.Object srcAsset, System.String targetPath, System.Type type)
  UnityEngine.Object CopyUniqueAndLoadAssetAtAnyPath(UnityEngine.Object srcAsset, System.String copyPath, System.Type type)
  System.Void CreateObjectInAssetCacheFolder(UnityEngine.Object objectToCreate, System.String assetCacheRoot, System.String relativeFolderPath, System.String assetFileName, System.Type type, System.Boolean bOverwriteExisting)
  System.Void CreateAsset(UnityEngine.Object asset, System.String path)
  System.Void CreateAddObjectInAssetCacheFolder(System.String assetName, System.String assetObjectFileName, UnityEngine.Object objectToAdd, System.String relativeFolderPath, System.String& exportRootPath, UnityEngine.Object& assetDBObject)
  System.Void AddObjectToAsset(UnityEngine.Object objectToAdd, UnityEngine.Object assetObject)
  System.Void SaveAndRefreshDatabase()
  System.Void SaveAssetDatabase()
  System.Void RefreshAssetDatabase()
  UnityEngine.Object LoadAssetAtPath(System.String assetPath, System.Type type)
  UnityEngine.Object LoadSubAssetAtPath(System.String mainPath, System.String subAssetPath)
  UnityEngine.Object[] LoadAllAssetsAtPath(System.String assetPath)
  UnityEngine.Object[] LoadAllAssetRepresentationsAtPath(System.String assetPath)
  System.Void ImportAsset(System.String assetPath, HoudiniEngineUnity.HEU_AssetDatabase.HEU_ImportAssetOptions heuOptions)
  System.String GetAssetWorkingPath()
  System.String GetAssetBakedPath()
  System.String GetAssetBakedPathWithAssetName(System.String assetName)
  System.String CreateUniqueBakePath(System.String assetName)
  System.Void CreatePathWithFolders(System.String inPath)
  System.String AppendMeshesPathToAssetFolder(System.String inAssetCacheFolder)
  System.String AppendTexturesPathToAssetFolder(System.String inAssetCacheFolder)
  System.String AppendMaterialsPathToAssetFolder(System.String inAssetCacheFolder)
  System.String AppendTerrainPathToAssetFolder(System.String inAssetCacheFolder)
  System.String[] GetAssetSubFolders()
  System.String AppendPrefabPath(System.String inAssetCacheFolder, System.String assetName)
  System.String AppendMeshesAssetFileName(System.String assetName)
  System.Boolean IsSubAsset(UnityEngine.Object obj)
  System.String[] GetAssetPathsFromAssetBundle(System.String assetBundleFileName)
  System.Boolean IsAssetSavedInScene(UnityEngine.GameObject go)
  System.Void SelectAssetAtPath(System.String path)
  System.Void PrintDependencies(UnityEngine.GameObject targetGO)
  System.String GetUniqueAssetPathForUnityAsset(UnityEngine.Object obj)
  System.Boolean IsValidFolderName(System.String name)
  T LoadUnityAssetFromUniqueAssetPath(System.String assetPath)
  T GetBuiltinExtraResource(System.String resourceName)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Defines
TYPE:  class
TOKEN: 0x2000058
FIELDS:
  public    static  System.String                   HEU_PRODUCT_NAME  // 0x0
  public    static  System.String                   HEU_NAME  // 0x0
  public    static  System.String                   HEU_PLUGIN_PATH  // 0x0
  public    static  System.String                   HEU_TEXTURES_PATH  // 0x8
  public    static  System.String                   HEU_BAKED_ASSETS_PATH  // 0x10
  public    static  System.String                   HEU_ENGINE_ASSETS  // 0x18
  public    static  System.String                   HAPI_PATH  // 0x0
  public    static  System.String                   HEU_ENVPATH_PREFIX  // 0x0
  public    static  System.String                   HEU_ENVPATH_KEY  // 0x0
  public    static  System.Int32                    HEU_INVALID_NODE_ID  // 0x0
  public    static  System.String                   HEU_DEFAULT_ASSET_NAME  // 0x0
  public    static  System.String                   HEU_SESSION_PIPENAME  // 0x0
  public    static  System.String                   HEU_SESSION_LOCALHOST  // 0x0
  public    static  System.Int32                    HEU_SESSION_PORT  // 0x0
  public    static  System.Single                   HEU_SESSION_TIMEOUT  // 0x0
  public    static  System.Boolean                  HEU_SESSION_AUTOCLOSE  // 0x0
  public    static  System.Int32                    HAPI_MAX_PAGE_SIZE  // 0x0
  public    static  System.Int32                    HAPI_SEC_BEFORE_PROGRESS_BAR_SHOW  // 0x0
  public    static  System.Int32                    HAPI_MAX_VERTICES_PER_FACE  // 0x0
  public    static  System.Boolean                  HAPI_CURVE_REFINE_TO_LINEAR  // 0x0
  public    static  System.Single                   HAPI_CURVE_LOD  // 0x0
  public    static  System.Single                   HAPI_VOLUME_POSITION_MULT  // 0x0
  public    static  System.Single                   HAPI_VOLUME_SURFACE_MAX_PT_PER_C  // 0x0
  public    static  System.Single                   HAPI_VOLUME_SURFACE_DELTA_MULT  // 0x0
  public    static  System.Single                   HAPI_VOLUME_SURFACE_PT_SIZE_MULT  // 0x0
  public    static  System.String                   DEFAULT_TOP_NODE_FILTER  // 0x0
  public    static  System.String                   DEFAULT_TOP_OUTPUT_FILTER  // 0x0
  public    static  System.String                   HAPI_ATTRIB_ORIENT  // 0x0
  public    static  System.String                   HAPI_ATTRIB_ROTATION  // 0x0
  public    static  System.String                   HAPI_ATTRIB_SCALE  // 0x0
  public    static  System.String                   HAPI_ATTRIB_ALPHA  // 0x0
  public    static  System.String                   HAPI_HANDLE_TRANSFORM  // 0x0
  public    static  System.Int32                    HAPI_MAX_UVS  // 0x0
  public    static  System.String                   HAPI_OBJMERGE_TRANSFORM_PARAM  // 0x0
  public    static  System.String                   HAPI_OBJMERGE_PACK_GEOMETRY  // 0x0
  public    static  System.String                   HAPI_OBJPATH_1_PARAM  // 0x0
  public    static  System.String                   NO_EXISTING_SESSION  // 0x0
  public    static  System.String                   HEU_ERROR_TITLE  // 0x0
  public    static  System.String                   HEU_INSTALL_INFO  // 0x0
  public    static  System.String                   PLUGIN_STORE_KEYS  // 0x0
  public    static  System.String                   PLUGIN_STORE_DATA  // 0x0
  public    static  System.String                   PLUGIN_SESSION_DATA  // 0x0
  public    static  System.String                   PLUGIN_SETTINGS_FILE  // 0x0
  public    static  System.String                   PLUGIN_SESSION_FILE  // 0x0
  public    static  System.String                   COOK_LOGS_FILE  // 0x0
  public    static  System.String                   DEFAULT_COLLISION_GEO  // 0x0
  public    static  System.String                   DEFAULT_RENDERED_COLLISION_GEO  // 0x0
  public    static  System.String                   DEFAULT_RENDERED_CONVEX_COLLISION_GEO  // 0x0
  public    static  System.String                   DEFAULT_CONVEX_COLLISION_GEO  // 0x0
  public    static  System.String                   DEFAULT_SIMPLE_COLLISION_GEO  // 0x0
  public    static  System.String                   DEFAULT_SIMPLE_RENDERED_COLLISION_GEO  // 0x0
  public    static  System.String                   DEFAULT_SIMPLE_RENDERED_CONVEX_COLLISION_GEO  // 0x0
  public    static  System.String                   DEFAULT_COLLISION_TRIGGER  // 0x0
  public    static  System.String                   DEFAULT_UNITY_MATERIAL_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_SUBMATERIAL_NAME_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_SUBMATERIAL_INDEX_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_DIFFUSE_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_MASK_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TEXTURE_NORMAL_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_NORMAL_SCALE_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_METALLIC_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_SMOOTHNESS_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_SPECULAR_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TILE_OFFSET_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TILE_SIZE_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_FILE_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_EXPORT_FILE_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TERRAINLAYER_FILE_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_TERRAINDATA_EXPORT_PATH  // 0x0
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_HEIGHT_RANGE  // 0x0
  public    static  System.String                   DEFAULT_UNITY_HEIGHTFIELD_YPOS  // 0x0
  public    static  System.String                   HEIGHTFIELD_TREEPROTOTYPE  // 0x0
  public    static  System.String                   HEIGHTFIELD_TREEINSTANCE_PROTOTYPEINDEX  // 0x0
  public    static  System.String                   HEIGHTFIELD_TREEINSTANCE_HEIGHTSCALE  // 0x0
  public    static  System.String                   HEIGHTFIELD_TREEINSTANCE_WIDTHSCALE  // 0x0
  public    static  System.String                   HEIGHTFIELD_TREEINSTANCE_LIGHTMAPCOLOR  // 0x0
  public    static  System.String                   HEIGHTFIELD_DETAIL_RESOLUTION_PER_PATCH  // 0x0
  public    static  System.String                   HEIGHTFIELD_UNITY_TILE  // 0x0
  public    static  System.String                   HEIGHTFIELD_DETAIL_DISTANCE  // 0x0
  public    static  System.String                   HEIGHTFIELD_DETAIL_DENSITY  // 0x0
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_PREFAB  // 0x0
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_TEXTURE  // 0x0
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_BENDFACTOR  // 0x0
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_DRYCOLOR  // 0x0
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_HEALTHYCOLOR  // 0x0
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_MAXHEIGHT  // 0x0
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_MAXWIDTH  // 0x0
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_MINHEIGHT  // 0x0
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_MINWIDTH  // 0x0
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_NOISESPREAD  // 0x0
  public    static  System.String                   HEIGHTFIELD_DETAIL_PROTOTYPE_RENDERMODE  // 0x0
  public    static  System.String                   HEIGHTFIELD_LAYER_ATTR_TYPE  // 0x0
  public    static  System.String                   HEIGHTFIELD_LAYER_TYPE_DETAIL  // 0x0
  public    static  System.String                   HAPI_HEIGHTFIELD_TILE_ATTR  // 0x0
  public    static  System.String                   HAPI_HEIGHTFIELD_LAYERNAME_HEIGHT  // 0x0
  public    static  System.String                   HAPI_HEIGHTFIELD_LAYERNAME_MASK  // 0x0
  public    static  System.String                   MAT_OGL_DIFF_ATTR  // 0x0
  public    static  System.String                   MAT_DIFF_ATTR  // 0x0
  public    static  System.String                   MAT_OGL_TEX1_ATTR  // 0x0
  public    static  System.String                   MAT_OGL_TEX1_ATTR_ENABLED  // 0x0
  public    static  System.String                   MAT_BASECOLOR_ATTR  // 0x0
  public    static  System.String                   MAT_BASECOLOR_ATTR_ENABLED  // 0x0
  public    static  System.String                   MAT_MAP_ATTR  // 0x0
  public    static  System.String                   MAT_OGL_NORMAL_ATTR  // 0x0
  public    static  System.String                   MAT_NORMAL_ATTR  // 0x0
  public    static  System.String                   MAT_NORMAL_ATTR_ENABLED  // 0x0
  public    static  System.String                   MAT_OGL_SPEC_ATTR  // 0x0
  public    static  System.String                   MAT_SPEC_ATTR  // 0x0
  public    static  System.String                   MAT_OGL_SPEC_MAP_ATTR  // 0x0
  public    static  System.String                   MAT_OGL_SPEC_MAP_ATTR_ENABLED  // 0x0
  public    static  System.String                   MAT_SPEC_MAP_ATTR  // 0x0
  public    static  System.String                   MAT_SPEC_MAP_ATTR_ENABLED  // 0x0
  public    static  System.String                   MAT_OGL_ROUGH_ATTR  // 0x0
  public    static  System.String                   MAT_ROUGH_ATTR  // 0x0
  public    static  System.String                   MAT_OGL_ROUGH_MAP_ATTR  // 0x0
  public    static  System.String                   MAT_OGL_ROUGH_MAP_ATTR_ENABLED  // 0x0
  public    static  System.String                   MAT_ROUGH_MAP_ATTR  // 0x0
  public    static  System.String                   MAT_ROUGH_MAP_ATTR_ENABLED  // 0x0
  public    static  System.String                   MAT_OGL_METALLIC_ATTR  // 0x0
  public    static  System.String                   MAT_METALLIC_ATTR  // 0x0
  public    static  System.String                   MAT_OGL_METALLIC_MAP_ATTR  // 0x0
  public    static  System.String                   MAT_OGL_METALLIC_MAP_ATTR_ENABLED  // 0x0
  public    static  System.String                   MAT_METALLIC_MAP_ATTR  // 0x0
  public    static  System.String                   MAT_METALLIC_MAP_ATTR_ENABLED  // 0x0
  public    static  System.String                   MAT_OGL_EMISSIVE_ATTR  // 0x0
  public    static  System.String                   MAT_EMISSIVE_ATTR  // 0x0
  public    static  System.String                   MAT_OGL_EMISSIVE_MAP_ATTR  // 0x0
  public    static  System.String                   MAT_OGL_EMISSIVE_MAP_ATTR_ENABLED  // 0x0
  public    static  System.String                   MAT_EMISSIVE_MAP_ATTR  // 0x0
  public    static  System.String                   MAT_EMISSIVE_MAP_ATTR_ENABLED  // 0x0
  public    static  System.String                   MAT_OGL_ALPHA_ATTR  // 0x0
  public    static  System.String                   MAT_ALPHA_ATTR  // 0x0
  public    static  System.String                   MAT_OGL_OPACITY_MAP_ATTR  // 0x0
  public    static  System.String                   MAT_OGL_OPACITY_MAP_ATTR_ENABLED  // 0x0
  public    static  System.String                   MAT_OPACITY_MAP_ATTR  // 0x0
  public    static  System.String                   MAT_OPACITY_MAP_ATTR_ENABLED  // 0x0
  public    static  System.String                   MAT_OGL_TRANSPARENCY_ATTR  // 0x0
  public    static  System.String                   MAT_OGL_TRANSPARENCY_ATTR_ENABLED  // 0x0
  public    static  System.String                   MAT_OGL_OCCLUSION_MAP_ATTR  // 0x0
  public    static  System.String                   MAT_OGL_OCCLUSION_MAP_ATTR_ENABLED  // 0x0
  public    static  System.String                   CURVE_COORDS_PARAM  // 0x0
  public    static  System.String                   CURVE_TYPE_PARAM  // 0x0
  public    static  System.String                   CURVE_METHOD_PARAM  // 0x0
  public    static  System.String                   CURVE_CLOSE_PARAM  // 0x0
  public    static  System.String                   CURVE_REVERSE_PARAM  // 0x0
  public    static  System.String                   HENGINE_STORE_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_TAG_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_SCRIPT_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_INSTANCE_ATTR  // 0x0
  public    static  System.String                   UNITY_USE_INSTANCE_FLAGS_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_INPUT_MESH_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_STATIC_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_LAYER_ATTR  // 0x0
  public    static  System.String                   DEFAULT_UNITY_MESH_READABLE  // 0x0
  public    static  System.String                   DEFAULT_INSTANCE_PREFIX_ATTR  // 0x0
  public    static  System.String                   UNITY_SHADER_COLOR  // 0x0
  public    static  System.String                   UNITY_SHADER_SPEC_COLOR  // 0x0
  public    static  System.String                   UNITY_SHADER_SPEC_MAP  // 0x0
  public    static  System.String                   UNITY_SHADER_METALLIC  // 0x0
  public    static  System.String                   UNITY_SHADER_METALLIC_MAP  // 0x0
  public    static  System.String                   UNITY_SHADER_BUMP_MAP  // 0x0
  public    static  System.String                   UNITY_SHADER_EMISSION_COLOR  // 0x0
  public    static  System.String                   UNITY_SHADER_EMISSION_MAP  // 0x0
  public    static  System.String                   UNITY_SHADER_SMOOTHNESS  // 0x0
  public    static  System.String                   UNITY_SHADER_SMOOTHNESS_MAP  // 0x0
  public    static  System.String                   UNITY_SHADER_SHININESS  // 0x0
  public    static  System.String                   UNITY_SHADER_OCCLUSION  // 0x0
  public    static  System.String                   UNITY_SHADER_OCCLUSION_MAP  // 0x0
  public    static  System.String                   UNITY_SHADER_OPACITY  // 0x0
  public    static  System.String                   UNITY_SHADER_OPACITY_MAP  // 0x0
  public    static  System.String                   UNITY_EDITORONLY_TAG  // 0x0
  public    static  System.String                   UNITY_HDADATA_NAME  // 0x0
  public    static  System.String                   HOUDINI_SHADER_PREFIX  // 0x0
  public    static  System.String                   DEFAULT_STANDARD_SHADER  // 0x0
  public    static  System.String                   DEFAULT_VERTEXCOLOR_SHADER  // 0x0
  public    static  System.String                   DEFAULT_TRANSPARENT_SHADER  // 0x0
  public    static  System.String                   DEFAULT_STANDARD_SHADER_SPECULAR  // 0x0
  public    static  System.String                   DEFAULT_STANDARD_SHADER_SPECULAR_LEGACY  // 0x0
  public    static  System.String                   DEFAULT_VERTEXCOLOR_SHADER_SPECULAR  // 0x0
  public    static  System.String                   DEFAULT_VERTEXCOLOR_SHADER_SPECULAR_LEGACY  // 0x0
  public    static  System.String                   DEFAULT_TRANSPARENT_SHADER_SPECULAR  // 0x0
  public    static  System.String                   DEFAULT_TRANSPARENT_SHADER_SPECULAR_LEGACY  // 0x0
  public    static  System.String                   DEFAULT_CURVE_SHADER  // 0x0
  public    static  System.String                   DEFAULT_TERRAIN_SHADER  // 0x0
  public    static  System.String                   DEFAULT_STANDARD_SHADER_HDRP  // 0x0
  public    static  System.String                   DEFAULT_VERTEXCOLOR_SHADER_HDRP  // 0x0
  public    static  System.String                   DEFAULT_TRANSPARENT_SHADER_HDRP  // 0x0
  public    static  System.String                   DEFAULT_STANDARD_SHADER_HDRP_SPECULAR  // 0x0
  public    static  System.String                   DEFAULT_VERTEXCOLOR_SHADER_HDRP_SPECULAR  // 0x0
  public    static  System.String                   DEFAULT_TRANSPARENT_SHADER_HDRP_SPECULAR  // 0x0
  public    static  System.String                   DEFAULT_CURVE_SHADER_HDRP  // 0x0
  public    static  System.String                   DEFAULT_TERRAIN_SHADER_HDRP  // 0x0
  public    static  System.String                   DEFAULT_STANDARD_SHADER_URP  // 0x0
  public    static  System.String                   DEFAULT_VERTEXCOLOR_SHADER_URP  // 0x0
  public    static  System.String                   DEFAULT_TRANSPARENT_SHADER_URP  // 0x0
  public    static  System.String                   DEFAULT_STANDARD_SHADER_URP_SPECULAR  // 0x0
  public    static  System.String                   DEFAULT_VERTEXCOLOR_SHADER_URP_SPECULAR  // 0x0
  public    static  System.String                   DEFAULT_TRANSPARENT_SHADER_URP_SPECULAR  // 0x0
  public    static  System.String                   DEFAULT_CURVE_SHADER_URP  // 0x0
  public    static  System.String                   DEFAULT_TERRAIN_SHADER_URP  // 0x0
  public    static  System.String                   DEFAULT_UNITY_BUILTIN_RESOURCES  // 0x0
  public    static  System.String                   DEFAULT_TERRAIN_MATERIAL_PATH  // 0x0
  public    static  System.String                   DEFAULT_TERRAIN_MATERIAL_PATH_HDRP  // 0x0
  public    static  System.String                   DEFAULT_TERRAIN_MATERIAL_PATH_URP  // 0x0
  public    static  System.String                   DEFAULT_MATERIAL  // 0x0
  public    static  System.Int32                    DEFAULT_MATERIAL_KEY  // 0x20
  public    static  System.String                   EDITABLE_MATERIAL  // 0x0
  public    static  System.Int32                    EDITABLE_MATERIAL_KEY  // 0x24
  public    static  System.Int32                    HEU_INVALID_MATERIAL  // 0x0
  public    static  System.String                   HEU_ASSET_CACHE_PATH  // 0x0
  public    static  System.String                   HEU_WORKING_PATH  // 0x0
  public    static  System.String                   HEU_BAKED_PATH  // 0x0
  public    static  System.String                   HEU_BAKED_HDA  // 0x0
  public    static  System.String                   HEU_BAKED_CLONE  // 0x0
  public    static  System.String                   HEU_INSTANCE  // 0x0
  public    static  System.String                   HEU_INSTANCE_PATTERN  // 0x0
  public    static  System.String                   HEU_INSTANCE_SPLIT_ATTR  // 0x0
  public    static  System.String                   HEU_DEFAULT_GEO_GROUP_NAME  // 0x0
  public    static  System.String                   HEU_DEFAULT_LOD_NAME  // 0x0
  public    static  System.String                   HEU_UNITY_LOD_TRANSITION_ATTR  // 0x0
  public    static  System.String                   HEU_SUBASSET  // 0x0
  public    static  System.String                   HEU_HENGINE_TOOLS_SHIPPED_FOLDER  // 0x0
  public    static  System.String                   HEU_HENGINE_SHIPPED_SHELF  // 0x0
  public    static  System.String                   HEU_PATH_KEY_PROJECT  // 0x0
  public    static  System.String                   HEU_PATH_KEY_PLUGIN  // 0x0
  public    static  System.String                   HEU_PATH_KEY_HFS  // 0x0
  public    static  System.String                   HEU_PATH_KEY_TOOL  // 0x0
  public    static  System.String                   HEU_USERMSG_NONEDITOR_NOT_SUPPORTED  // 0x0
  public    static  System.String                   HEU_TERRAIN_SPLAT_DEFAULT  // 0x0
  public    static  System.String                   HEU_FOLDER_MESHES  // 0x0
  public    static  System.String                   HEU_FOLDER_MATERIALS  // 0x0
  public    static  System.String                   HEU_FOLDER_TERRAIN  // 0x0
  public    static  System.String                   HEU_FOLDER_TILE  // 0x0
  public    static  System.String                   HEU_FOLDER_TEXTURES  // 0x0
  public    static  System.String                   HEU_EXT_ASSET  // 0x0
  public    static  System.String                   HEU_EXT_MAT  // 0x0
  public    static  System.String                   HEU_EXT_TERRAINDATA  // 0x0
  public    static  System.String                   HEU_EXT_TERRAINLAYER  // 0x0
  public    static  System.String                   HEU_KEY_CTRL  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HAPIUtility
TYPE:  class
TOKEN: 0x2000059
FIELDS:
METHODS:
  System.String GetHoudiniEngineInstallationInfo()
  System.String GetEnvironmentPath()
  System.String GetRealPathFromHFSPath(System.String inPath)
  System.Boolean DoesMappedPathExist(System.String inPath)
  System.Boolean IsHoudiniAssetFile(System.String filePath)
  System.String FindHoudiniAssetFileInPathWithExt(System.String filePath)
  System.Void Log(System.String message)
  System.Void LogWarning(System.String message)
  System.Void LogError(System.String message)
  System.String LocateValidFilePath(UnityEngine.Object inObject)
  System.String LocateValidFilePath(System.String assetName, System.String inFilePath)
  UnityEngine.GameObject InstantiateHDA(System.String filePath, UnityEngine.Vector3 initialPosition, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, System.Boolean bLoadFromMemory, System.Boolean bAlwaysOverwriteOnLoad, UnityEngine.GameObject rootGO)
  System.Boolean LoadHDAFile(HoudiniEngineUnity.HEU_SessionBase session, System.String assetPath, System.Int32& assetLibraryID, System.String[]& assetNames)
  System.Boolean CreateAndCookAssetNode(HoudiniEngineUnity.HEU_SessionBase session, System.String assetName, System.Boolean bCookTemplatedGeos, System.Int32& newAssetID)
  System.Boolean CreateAndCookCurveAsset(HoudiniEngineUnity.HEU_SessionBase session, System.String assetName, System.Boolean bCookTemplatedGeos, System.Int32& newAssetID)
  System.Boolean CreateAndCookInputAsset(HoudiniEngineUnity.HEU_SessionBase session, System.String assetName, System.Boolean bCookTemplatedGeos, System.Int32& newAssetID)
  System.Boolean CookNodeInHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Boolean bCookTemplatedGeos, System.String assetName)
  System.Boolean CookNodeInHoudiniWithOptions(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_CookOptions options, System.String assetName)
  HoudiniEngineUnity.HAPI_CookOptions GetDefaultCookOptions(HoudiniEngineUnity.HEU_SessionBase session)
  System.Boolean ProcessHoudiniCookStatus(HoudiniEngineUnity.HEU_SessionBase session, System.String assetName)
  UnityEngine.GameObject CreateNewAsset(HoudiniEngineUnity.HEU_AssetTypeWrapper assetType, System.String rootName, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, UnityEngine.GameObject rootGO)
  UnityEngine.GameObject CreateNewAsset(HoudiniEngineUnity.HEU_HoudiniAsset.HEU_AssetType assetType, System.String rootName, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, UnityEngine.GameObject rootGO)
  UnityEngine.GameObject CreateNewCurveAsset(System.String name, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, UnityEngine.GameObject rootGO)
  UnityEngine.GameObject CreateNewInputAsset(System.String name, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bBuildAsync, UnityEngine.GameObject rootGO)
  UnityEngine.GameObject LoadGeoWithNewGeoSync(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void DestroyChildren(UnityEngine.Transform inTransform)
  System.Void DestroyGameObject(UnityEngine.GameObject gameObect, System.Boolean bRegisterUndo)
  System.Void DestroyChildrenWithComponent(UnityEngine.GameObject gameObject)
  System.Boolean IsNodeValidInHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID)
  HoudiniEngineUnity.HEU_HoudiniAssetRoot GetAssetInScene(System.Int32 assetID)
  System.Void ApplyWorldTransfromFromHoudiniToUnity(HoudiniEngineUnity.HAPI_Transform& hapiTransform, UnityEngine.Transform unityTransform)
  System.Void ApplyLocalTransfromFromHoudiniToUnity(HoudiniEngineUnity.HAPI_Transform& hapiTransform, UnityEngine.Transform unityTransform)
  System.Void ApplyLocalTransfromFromHoudiniToUnityForInstance(HoudiniEngineUnity.HAPI_Transform& hapiTransform, UnityEngine.Transform unityTransform)
  System.Void ApplyMatrixToLocalTransform(UnityEngine.Matrix4x4& matrix, UnityEngine.Transform transform)
  UnityEngine.Matrix4x4 GetMatrixFromHAPITransform(HoudiniEngineUnity.HAPI_Transform& hapiTransform, System.Boolean bConvertToUnity)
  UnityEngine.Quaternion GetQuaternion(UnityEngine.Matrix4x4& m)
  UnityEngine.Vector3 GetPosition(UnityEngine.Matrix4x4& m)
  System.Void SetMatrixPosition(UnityEngine.Matrix4x4& m, UnityEngine.Vector3& position)
  UnityEngine.Vector3 GetScale(UnityEngine.Matrix4x4& m)
  HoudiniEngineUnity.HAPI_TransformEuler GetHAPITransformFromMatrix(UnityEngine.Matrix4x4& mat)
  HoudiniEngineUnity.HAPI_TransformEuler GetHAPITransform(UnityEngine.Vector3& p, UnityEngine.Vector3& r, UnityEngine.Vector3& s)
  HoudiniEngineUnity.HAPI_Transform GetHAPITransformQuatFromMatrix(UnityEngine.Matrix4x4& mat)
  UnityEngine.Matrix4x4 GetMatrix4x4(UnityEngine.Vector3& p, UnityEngine.Vector3& r, UnityEngine.Vector3& s)
  System.Boolean IsSameTransform(UnityEngine.Matrix4x4& transformMatrix, UnityEngine.Vector3& p, UnityEngine.Vector3& r, UnityEngine.Vector3& s)
  System.Boolean IsEqualTol(System.Single a, System.Single b, System.Single t)
  System.Boolean IsTransformEqual(HoudiniEngineUnity.HAPI_Transform& transA, HoudiniEngineUnity.HAPI_Transform& transB)
  System.Boolean IsViewportEqual(HoudiniEngineUnity.HAPI_Viewport& viewA, HoudiniEngineUnity.HAPI_Viewport& viewB)
  System.Boolean IsSessionSyncEqual(HoudiniEngineUnity.HAPI_SessionSyncInfo& syncA, HoudiniEngineUnity.HAPI_SessionSyncInfo& syncB)
  System.Boolean DoesGeoPartHaveAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeOwner owner, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo)
  System.Void SetAnimationCurveTangentModes(UnityEngine.AnimationCurve animCurve, System.Collections.Generic.List<System.Int32> tangentValues)
  System.Boolean IsSupportedPolygonType(HoudiniEngineUnity.HAPI_PartType partType)
  System.Int32 GetParentNodeID(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID)
  System.Boolean GetObjectInfos(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, HoudiniEngineUnity.HAPI_ObjectInfo[]& objectInfos, HoudiniEngineUnity.HAPI_Transform[]& objectTransforms)
  System.Boolean ContainsSopNodes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeId)
  System.Boolean IsObjNodeFullyVisible(HoudiniEngineUnity.HEU_SessionBase session, System.Collections.Generic.HashSet<System.Int32> allObjectIds, System.Int32 inRootNodeId, System.Int32 inChildNodeId)
  System.Boolean GetOutputIndex(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeId, System.Int32& outputIndex)
  System.Void GatherAllAssetGeoInfos(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_AssetInfo assetInfo, HoudiniEngineUnity.HAPI_ObjectInfo objectInfo, System.Boolean bUseOutputNodes, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_GeoInfo>& outGeoInfos)
  System.Void GatherAllObjectGeoInfos(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetId, System.Boolean bUseOutputNodes, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_GeoInfo>& outGeoInfos)
  System.Void GatherAllAssetOutputs(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeId, System.Boolean bUseOutputNodes, System.Boolean bOutputTemplatedGeos, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_GeoInfo>& outGeoInfos)
  System.String ToHapiVariableName(System.String name)
  System.Void ConvertPositionUnityToHoudini(UnityEngine.Vector3& position)
  System.Void ConvertPositionUnityToHoudini(UnityEngine.Vector3 position, System.Single& outputX, System.Single& outputY, System.Single& outputZ)
  UnityEngine.Vector3 ConvertPositionUnityToHoudini(System.Single inputX, System.Single inputY, System.Single inputZ)
  UnityEngine.Vector3 ConvertPositionUnityToHoudini(UnityEngine.Vector3 inputVec)
  System.Void ConvertPositionUnityToHoudini(System.Single inputX, System.Single inputY, System.Single inputZ, UnityEngine.Vector3& outputVec)
  System.Void ConvertRotationUnityToHoudini(UnityEngine.Quaternion& rotation)
  System.Void ConvertRotationUnityToHoudini(UnityEngine.Quaternion rotation, System.Single& outputX, System.Single& outputY, System.Single& outputZ, System.Single& outputW)
  UnityEngine.Quaternion ConvertRotationUnityToHoudini(System.Single inputX, System.Single inputY, System.Single inputZ, System.Single inputW)
  UnityEngine.Quaternion ConvertRotationUnityToHoudini(UnityEngine.Quaternion inputQuat)
  System.Void ConvertScaleUnityToHoudini(UnityEngine.Vector3& position)
  System.Void ConvertScaleUnityToHoudini(UnityEngine.Vector3 position, System.Single& outputX, System.Single& outputY, System.Single& outputZ)
  UnityEngine.Vector3 ConvertScaleUnityToHoudini(System.Single inputX, System.Single inputY, System.Single inputZ)
  UnityEngine.Vector3 ConvertScaleUnityToHoudini(UnityEngine.Vector3 inputVec)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HoudiniEngineError
TYPE:  class
TOKEN: 0x200005A
EXTENDS: Exception
FIELDS:
  protected         System.String                   _errorMsg  // 0x90
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String errorMsg)
  System.String ToString()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Platform
TYPE:  class
TOKEN: 0x200005B
FIELDS:
  private   static  System.String                   _lastErrorMsg  // 0x0
  private   static  System.String                   _libPath  // 0x8
  private   static  System.Boolean                  _pathSet  // 0x10
METHODS:
  System.String get_LibPath()
  System.Boolean get_IsPathSet()
  System.Void .cctor()
  System.String GetHoudiniEnginePath()
  System.String GetHoudiniEngineDefaultPath()
  System.String GetSavedHoudiniPath()
  System.Void SetHapiClientName()
  System.Void SetHoudiniEnginePath()
  System.String GetAllFoldersInPath(System.String path)
  System.Void GetAllFoldersInPathHelper(System.String inPath, System.Text.StringBuilder pathBuilder)
  System.String[] GetFilesInFolder(System.String folderPath, System.String searchPattern, System.Boolean bRecursive)
  System.String GetFileName(System.String path)
  System.String GetFileNameWithoutExtension(System.String path)
  System.String GetFolderPath(System.String path, System.Boolean bRemoveDirectorySeparatorAtEnd)
  System.Char get_DirectorySeparator()
  System.String get_DirectorySeparatorStr()
  System.String BuildPath(System.String folder1, System.String folder2, System.Object[] args)
  System.String TrimLastDirectorySeparator(System.String inPath)
  System.Boolean DoesPathExist(System.String inPath)
  System.Boolean DoesFileExist(System.String inPath)
  System.Boolean DoesDirectoryExist(System.String inPath)
  System.Boolean CreateDirectory(System.String inPath)
  System.String GetParentDirectory(System.String inPath)
  System.String GetFullPath(System.String inPath)
  System.Boolean IsPathRooted(System.String inPath)
  System.Void WriteBytes(System.String path, System.Byte[] bytes)
  System.Boolean WriteAllText(System.String path, System.String text)
  System.String ReadAllText(System.String path)
  System.String GetEnvironmentValue(System.String key)
  System.String GetHoudiniEngineEnvironmentFilePathFull()
  System.Boolean LoadFileIntoMemory(System.String path, System.Byte[]& buffer)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PlatformWin
TYPE:  class
TOKEN: 0x200005C
FIELDS:
  public    static  System.UIntPtr                  HKEY_LOCAL_MACHINE  // 0x0
  public    static  System.UIntPtr                  HKEY_CURRENT_USER  // 0x8
METHODS:
  System.UInt32 RegOpenKeyEx(System.UIntPtr hKey, System.String lpSubKey, System.UInt32 ulOptions, System.Int32 samDesired, System.Int32& phkResult)
  System.Int32 RegQueryValueEx(System.Int32 hKey, System.String lpValueName, System.Int32 lpReserved, System.UInt32& lpType, System.Text.StringBuilder lpData, System.UInt32& lpcbData)
  System.UInt32 RegCloseKey(System.Int32 hKey)
  System.String GetRegistryKeyValue(System.UIntPtr rootKey, System.String keyName, HoudiniEngineUnity.HEU_PlatformWin.RegSAM is32or64Key, System.String inPropertyName)
  System.String GetRegistryKeyvalue_x86(System.UIntPtr rootKey, System.String keyName, System.String inPropertyName)
  System.String GetRegistryKeyvalue_x64(System.UIntPtr rootKey, System.String keyName, System.String inPropertyName)
  System.String GetApplicationPath(System.String appName)
  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PluginSettings
TYPE:  class
TOKEN: 0x200005E
FIELDS:
  public    static  System.Action<System.Boolean>   s_onEnableRawHoudiniChanged  // 0x0
METHODS:
  System.String get_HoudiniEngineEnvFilePath()
  System.Void set_HoudiniEngineEnvFilePath(System.String value)
  System.Boolean get_EnableRawHoudini()
  System.Void set_EnableRawHoudini(System.Boolean value)
  System.Boolean get_CookingEnabled()
  System.Void set_CookingEnabled(System.Boolean value)
  System.Boolean get_CookingTriggersDownstreamCooks()
  System.Void set_CookingTriggersDownstreamCooks(System.Boolean value)
  System.Boolean get_CookDisabledGameObjects()
  System.Void set_CookDisabledGameObjects(System.Boolean value)
  System.Boolean get_CookTemplatedGeos()
  System.Void set_CookTemplatedGeos(System.Boolean value)
  System.Boolean get_PushUnityTransformToHoudini()
  System.Void set_PushUnityTransformToHoudini(System.Boolean value)
  System.Boolean get_TransformChangeTriggersCooks()
  System.Void set_TransformChangeTriggersCooks(System.Boolean value)
  System.Boolean get_ChildTransformChangeTriggersCooks()
  System.Void set_ChildTransformChangeTriggersCooks(System.Boolean value)
  System.String get_CollisionGroupName()
  System.Void set_CollisionGroupName(System.String value)
  System.String get_RenderedCollisionGroupName()
  System.Void set_RenderedCollisionGroupName(System.String value)
  System.String get_RenderedConvexCollisionGroupName()
  System.Void set_RenderedConvexCollisionGroupName(System.String value)
  System.String get_UnityMaterialAttribName()
  System.Void set_UnityMaterialAttribName(System.String value)
  System.String get_UnitySubMaterialAttribName()
  System.Void set_UnitySubMaterialAttribName(System.String value)
  System.String get_UnitySubMaterialIndexAttribName()
  System.Void set_UnitySubMaterialIndexAttribName(System.String value)
  System.String get_UnityTagAttributeName()
  System.Void set_UnityTagAttributeName(System.String value)
  System.String get_UnityStaticAttributeName()
  System.Void set_UnityStaticAttributeName(System.String value)
  System.String get_UnityScriptAttributeName()
  System.Void set_UnityScriptAttributeName(System.String value)
  System.String get_UnityLayerAttributeName()
  System.Void set_UnityLayerAttributeName(System.String value)
  System.Single get_ImageGamma()
  System.Void set_ImageGamma(System.Single value)
  System.Single get_NormalGenerationThresholdAngle()
  System.Void set_NormalGenerationThresholdAngle(System.Single value)
  System.String get_LastLoadHDAPath()
  System.Void set_LastLoadHDAPath(System.String value)
  System.String get_LastLoadHIPPath()
  System.Void set_LastLoadHIPPath(System.String value)
  System.String get_InstanceAttr()
  System.Void set_InstanceAttr(System.String value)
  System.String get_UnityInstanceAttr()
  System.Void set_UnityInstanceAttr(System.String value)
  System.String get_UnityInputMeshAttr()
  System.Void set_UnityInputMeshAttr(System.String value)
  UnityEngine.Color get_LineColor()
  System.Void set_LineColor(UnityEngine.Color value)
  System.Boolean get_UseHybridCurveEditing()
  System.Void set_UseHybridCurveEditing(System.Boolean value)
  System.String get_EditorOnly_Tag()
  System.Void set_EditorOnly_Tag(System.String value)
  System.String get_HDAData_Name()
  System.Void set_HDAData_Name(System.String value)
  HoudiniEngineUnity.SessionMode get_Session_Mode()
  System.Void set_Session_Mode(HoudiniEngineUnity.SessionMode value)
  System.String get_Session_PipeName()
  System.Void set_Session_PipeName(System.String value)
  System.String get_Session_Localhost()
  System.Void set_Session_Localhost(System.String value)
  System.Int32 get_Session_Port()
  System.Void set_Session_Port(System.Int32 value)
  System.Single get_Session_Timeout()
  System.Void set_Session_Timeout(System.Single value)
  System.Boolean get_Session_AutoClose()
  System.Void set_Session_AutoClose(System.Boolean value)
  System.Boolean get_Curves_ShowInSceneView()
  System.Void set_Curves_ShowInSceneView(System.Boolean value)
  System.String get_AssetCachePath()
  System.Void set_AssetCachePath(System.String value)
  System.Boolean get_UseFullPathNamesForOutput()
  System.Void set_UseFullPathNamesForOutput(System.Boolean value)
  System.Collections.Generic.List<System.String> get_HEngineToolsShelves()
  System.Void set_HEngineToolsShelves(System.Collections.Generic.List<System.String> value)
  System.Int32 get_HEngineShelfSelectedIndex()
  System.Void set_HEngineShelfSelectedIndex(System.Int32 value)
  System.String get_DefaultTerrainMaterial()
  System.Void set_DefaultTerrainMaterial(System.String value)
  System.String get_TerrainSplatTextureDefault()
  System.Void set_TerrainSplatTextureDefault(System.String value)
  System.String get_DefaultStandardShader()
  System.Void set_DefaultStandardShader(System.String value)
  System.String get_DefaultVertexColorShader()
  System.Void set_DefaultVertexColorShader(System.String value)
  System.String get_DefaultTransparentShader()
  System.Void set_DefaultTransparentShader(System.String value)
  System.String get_DefaultCurveShader()
  System.Void set_DefaultCurveShader(System.String value)
  System.Boolean get_SupportHoudiniBoxType()
  System.Void set_SupportHoudiniBoxType(System.Boolean value)
  System.Boolean get_SupportHoudiniSphereType()
  System.Void set_SupportHoudiniSphereType(System.Boolean value)
  System.Boolean get_SetCurrentThreadToInvariantCulture()
  System.Void set_SetCurrentThreadToInvariantCulture(System.Boolean value)
  System.String get_HoudiniDebugLaunchPath()
  System.Void set_HoudiniDebugLaunchPath(System.String value)
  System.String get_LastExportPath()
  System.Void set_LastExportPath(System.String value)
  System.Int32 get_InputSelectionFilterLocation()
  System.Void set_InputSelectionFilterLocation(System.Int32 value)
  System.Int32 get_InputSelectionFilterState()
  System.Void set_InputSelectionFilterState(System.Int32 value)
  System.Boolean get_InputSelectionFilterRoots()
  System.Void set_InputSelectionFilterRoots(System.Boolean value)
  System.String get_InputSelectionFilterName()
  System.Void set_InputSelectionFilterName(System.String value)
  System.Boolean get_CookOptionSplitGeosByGroup()
  System.Void set_CookOptionSplitGeosByGroup(System.Boolean value)
  System.Int32 get_MaxVerticesPerPrimitive()
  System.Void set_MaxVerticesPerPrimitive(System.Int32 value)
  System.String get_HoudiniInstallPath()
  System.Void set_HoudiniInstallPath(System.String value)
  System.String get_LastHoudiniVersion()
  System.Void set_LastHoudiniVersion(System.String value)
  System.Boolean get_SessionSyncAutoCook()
  System.Void set_SessionSyncAutoCook(System.Boolean value)
  System.Boolean get_WriteCookLogs()
  System.Void set_WriteCookLogs(System.Boolean value)
  System.Boolean get_UseHDRColor()
  System.Void set_UseHDRColor(System.Boolean value)
  System.Boolean get_UseSpecularShader()
  System.Void set_UseSpecularShader(System.Boolean value)
  System.Boolean get_UseLegacyShaders()
  System.Void set_UseLegacyShaders(System.Boolean value)
  System.Boolean get_ShortenFolderPaths()
  System.Void set_ShortenFolderPaths(System.Boolean value)
  System.Boolean get_UseLegacyInputCurves()
  System.Void set_UseLegacyInputCurves(System.Boolean value)
  System.Boolean get_CookOnMouseUp()
  System.Void set_CookOnMouseUp(System.Boolean value)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PluginStorage
TYPE:  class
TOKEN: 0x200005F
FIELDS:
  protected         System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_PluginStorage.StoreData>_dataMap  // 0x10
  private           System.Collections.Generic.Dictionary<System.String,System.String>_envPathMap  // 0x18
  protected         System.Boolean                  _requiresSave  // 0x20
  private   static  HoudiniEngineUnity.HEU_PluginStorage_instance  // 0x0
  public    static  System.String                   PluginSettingsLine1  // 0x0
  public    static  System.String                   PluginSettingsLine2  // 0x0
  public    static  System.String                   PluginSettingsVersion  // 0x0
METHODS:
  System.Collections.Generic.Dictionary<System.String,System.String> GetEnvironmentPathMap()
  System.Boolean get_RequiresSave()
  HoudiniEngineUnity.HEU_PluginStorage get_Instance()
  System.Void InstantiateAndLoad()
  System.Void SetCurrentCulture(System.Boolean useInvariant)
  T[] GetJSONArray(System.String jsonArray)
  System.Void Set(System.String key, System.Boolean value)
  System.Void Set(System.String key, System.Int32 value)
  System.Void Set(System.String key, System.Int64 value)
  System.Void Set(System.String key, System.Single value)
  System.Void Set(System.String key, System.String value)
  System.Void Set(System.String key, System.Collections.Generic.List<System.String> values, System.Char delimiter)
  System.Boolean Get(System.String key, System.Boolean& value, System.Boolean defaultValue)
  System.Boolean Get(System.String key, System.Int32& value, System.Int32 defaultValue)
  System.Boolean Get(System.String key, System.Int64& value, System.Int64 defaultValue)
  System.Boolean Get(System.String key, System.Single& value, System.Single defaultValue)
  System.Boolean Get(System.String key, System.String& value, System.String defaultValue)
  System.Boolean Get(System.String key, System.Collections.Generic.List<System.String>& values, System.Char delimiter)
  System.Void MarkDirtyForSave()
  System.Void SaveIfRequired()
  System.String SettingsFilePath()
  System.Boolean SavePluginData(System.String file)
  System.Boolean LoadPluginData(System.String file)
  System.Boolean ReadFromEditorPrefs()
  System.Void ClearPluginData()
  System.Void LoadFromSavedFile()
  System.String SessionFilePath()
  System.Void SaveAllSessionData(System.Collections.Generic.List<HoudiniEngineUnity.HEU_SessionBase> allSessions, System.String path)
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_SessionData> LoadAllSessionData(System.String path)
  System.Void DeleteAllSavedSessionData(System.String file)
  System.Void LoadAssetEnvironmentPaths()
  System.String ConvertRealPathToEnvKeyedPath(System.String inPath)
  System.String ConvertEnvKeyedPathToReal(System.String inPath)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Handle
TYPE:  class
TOKEN: 0x2000063
EXTENDS: ScriptableObject
FIELDS:
  private           System.String                   _handleName  // 0x18
  private           HoudiniEngineUnity.HEU_Handle.HEU_HandleType_handleType  // 0x20
  private           System.Int32                    _handleIndex  // 0x24
  private           HoudiniEngineUnity.HEU_HandleParamBinding_handleParamTranslateBinding  // 0x28
  private           HoudiniEngineUnity.HEU_HandleParamBinding_handleParamRotateBinding  // 0x30
  private           HoudiniEngineUnity.HEU_HandleParamBinding_handleParamScaleBinding  // 0x38
  private           UnityEngine.Vector3             _handlePosition  // 0x40
  private           UnityEngine.Quaternion          _handleRotation  // 0x4C
  private           UnityEngine.Vector3             _handleScale  // 0x5C
  private           HoudiniEngineUnity.HAPI_RSTOrder_rstOrder  // 0x68
  private           HoudiniEngineUnity.HAPI_XYZOrder_xyzOrder  // 0x6C
  private           HoudiniEngineUnity.HAPI_TransformEuler_convertedTransformEuler  // 0x70
METHODS:
  System.String get_HandleName()
  HoudiniEngineUnity.HEU_Handle.HEU_HandleType get_HandleType()
  HoudiniEngineUnity.HAPI_RSTOrder get_RSTOrder()
  HoudiniEngineUnity.HAPI_XYZOrder get_XYZOrder()
  HoudiniEngineUnity.HAPI_TransformEuler get_ConvertedTransformEuler()
  System.Boolean HasTranslateHandle()
  System.Boolean HasRotateHandle()
  System.Boolean HasScaleHandle()
  System.Boolean IsTranslateHandleDisabled()
  System.Boolean IsRotateHandleDisabled()
  System.Boolean IsScaleHandleDisabled()
  HoudiniEngineUnity.HEU_HandleParamBinding GetTranslateBinding()
  HoudiniEngineUnity.HEU_HandleParamBinding GetRotateBinding()
  HoudiniEngineUnity.HEU_HandleParamBinding GetScaleBinding()
  UnityEngine.Vector3 get_HandlePosition()
  UnityEngine.Quaternion get_HandleRotation()
  UnityEngine.Vector3 get_HandleScale()
  System.Boolean SetupHandle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, System.Int32 handleIndex, System.String handleName, HoudiniEngineUnity.HEU_Handle.HEU_HandleType handleType, HoudiniEngineUnity.HAPI_HandleInfo& handleInfo, HoudiniEngineUnity.HEU_Parameters parameters)
  System.Void CleanUp()
  System.Void GenerateTransform(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_Parameters parameters)
  System.Boolean GetUpdatedPosition(HoudiniEngineUnity.HEU_HoudiniAsset asset, UnityEngine.Vector3& inPosition)
  System.Boolean GetUpdatedRotation(HoudiniEngineUnity.HEU_HoudiniAsset asset, UnityEngine.Quaternion& inRotation)
  System.Boolean IsSpecialRSTOrder(HoudiniEngineUnity.HAPI_RSTOrder rstOrder)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_Handle other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HandleParamBinding
TYPE:  class
TOKEN: 0x2000065
FIELDS:
  public            HoudiniEngineUnity.HEU_HandleParamBinding.HEU_HandleParamType_paramType  // 0x10
  public            System.Int32                    _parmID  // 0x14
  public            System.String                   _paramName  // 0x18
  public            System.Boolean                  _bDisabled  // 0x20
  public            System.Boolean[]                _boundChannels  // 0x28
METHODS:
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_HandleParamBinding other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HAPIConstants
TYPE:  class
TOKEN: 0x2000067
FIELDS:
  public    static  System.Int32                    HAPI_POSITION_VECTOR_SIZE  // 0x0
  public    static  System.Int32                    HAPI_SCALE_VECTOR_SIZE  // 0x0
  public    static  System.Int32                    HAPI_SHEAR_VECTOR_SIZE  // 0x0
  public    static  System.Int32                    HAPI_NORMAL_VECTOR_SIZE  // 0x0
  public    static  System.Int32                    HAPI_QUATERNION_VECTOR_SIZE  // 0x0
  public    static  System.Int32                    HAPI_EULER_VECTOR_SIZE  // 0x0
  public    static  System.Int32                    HAPI_UV_VECTOR_SIZE  // 0x0
  public    static  System.Int32                    HAPI_COLOR_VECTOR_SIZE  // 0x0
  public    static  System.Int32                    HAPI_CV_VECTOR_SIZE  // 0x0
  public    static  System.Int32                    HAPI_PRIM_MIN_VERTEX_COUNT  // 0x0
  public    static  System.Int32                    HAPI_PRIM_MAX_VERTEX_COUNT  // 0x0
  public    static  System.Int32                    HAPI_INVALID_PARM_ID  // 0x0
  public    static  System.String                   HAPI_ATTRIB_POSITION  // 0x0
  public    static  System.String                   HAPI_ATTRIB_UV  // 0x0
  public    static  System.String                   HAPI_ATTRIB_UV2  // 0x0
  public    static  System.String                   HAPI_ATTRIB_NORMAL  // 0x0
  public    static  System.String                   HAPI_ATTRIB_TANGENT  // 0x0
  public    static  System.String                   HAPI_ATTRIB_TANGENT2  // 0x0
  public    static  System.String                   HAPI_ATTRIB_COLOR  // 0x0
  public    static  System.String                   HAPI_ATTRIB_NAME  // 0x0
  public    static  System.String                   HAPI_ATTRIB_INSTANCE  // 0x0
  public    static  System.String                   HAPI_ATTRIB_ROT  // 0x0
  public    static  System.String                   HAPI_ATTRIB_SCALE  // 0x0
  public    static  System.String                   HAPI_UNGROUPED_GROUP_NAME  // 0x0
  public    static  System.String                   HAPI_RAW_FORMAT_NAME  // 0x0
  public    static  System.String                   HAPI_PNG_FORMAT_NAME  // 0x0
  public    static  System.String                   HAPI_JPEG_FORMAT_NAME  // 0x0
  public    static  System.String                   HAPI_BMP_FORMAT_NAME  // 0x0
  public    static  System.String                   HAPI_TIFF_FORMAT_NAME  // 0x0
  public    static  System.String                   HAPI_TGA_FORMAT_NAME  // 0x0
  public    static  System.String                   HAPI_DEFAULT_IMAGE_FORMAT_NAME  // 0x0
  public    static  System.String                   HAPI_GLOBAL_NODES_NODE_NAME  // 0x0
  public    static  System.String                   HAPI_ENV_HIP  // 0x0
  public    static  System.String                   HAPI_ENV_JOB  // 0x0
  public    static  System.String                   HAPI_ENV_CLIENT_NAME  // 0x0
  public    static  System.String                   HAPI_CACHE_COP_COOK  // 0x0
  public    static  System.String                   HAPI_CACHE_COP_FLIPBOOK  // 0x0
  public    static  System.String                   HAPI_CACHE_IMAGE  // 0x0
  public    static  System.String                   HAPI_CACHE_OBJ  // 0x0
  public    static  System.String                   HAPI_CACHE_GL_TEXTURE  // 0x0
  public    static  System.String                   HAPI_CACHE_GL_VERTEX  // 0x0
  public    static  System.String                   HAPI_CACHE_SOP  // 0x0
  public    static  System.String                   HAPI_CACHE_VEX  // 0x0
  public    static  System.String                   HAPI_ATTRIB_INPUT_CURVE_COORDS  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_License
TYPE:  struct
TOKEN: 0x2000068
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_License HAPI_LICENSE_NONE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_ENGINE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI  // 0x0
  public    static  HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_FX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_ENGINE_INDIE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_INDIE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_License HAPI_LICENSE_HOUDINI_ENGINE_UNITY_UNREAL  // 0x0
  public    static  HoudiniEngineUnity.HAPI_License HAPI_LICENSE_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_StatusType
TYPE:  struct
TOKEN: 0x2000069
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_StatusTypeHAPI_STATUS_CALL_RESULT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StatusTypeHAPI_STATUS_COOK_RESULT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StatusTypeHAPI_STATUS_COOK_STATE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StatusTypeHAPI_STATUS_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_StatusVerbosity
TYPE:  struct
TOKEN: 0x200006A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_StatusVerbosityHAPI_STATUSVERBOSITY_0  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StatusVerbosityHAPI_STATUSVERBOSITY_1  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StatusVerbosityHAPI_STATUSVERBOSITY_2  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StatusVerbosityHAPI_STATUSVERBOSITY_ALL  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StatusVerbosityHAPI_STATUSVERBOSITY_ERRORS  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StatusVerbosityHAPI_STATUSVERBOSITY_WARNINGS  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StatusVerbosityHAPI_STATUSVERBOSITY_MESSAGES  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_Result
TYPE:  struct
TOKEN: 0x200006B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_SUCCESS  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_FAILURE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_ALREADY_INITIALIZED  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_NOT_INITIALIZED  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_CANT_LOADFILE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_PARM_SET_FAILED  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_INVALID_ARGUMENT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_CANT_LOAD_GEO  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_CANT_GENERATE_PRESET  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_CANT_LOAD_PRESET  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_ASSET_DEF_ALREADY_LOADED  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_NO_LICENSE_FOUND  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_DISALLOWED_NC_LICENSE_FOUND  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_DISALLOWED_NC_ASSET_WITH_C_LICENSE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_DISALLOWED_NC_ASSET_WITH_LC_LICENSE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_DISALLOWED_LC_ASSET_WITH_C_LICENSE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_DISALLOWED_HENGINEINDIE_W_3PARTY_PLUGIN  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_ASSET_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_NODE_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_USER_INTERRUPTED  // 0x0
  public    static  HoudiniEngineUnity.HAPI_Result  HAPI_RESULT_INVALID_SESSION  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ErrorCode
TYPE:  struct
TOKEN: 0x200006C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_ErrorCodeHAPI_ERRORCODE_ASSET_DEF_NOT_FOUND  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ErrorCodeHAPI_ERRORCODE_PYTHON_NODE_ERROR  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_SessionType
TYPE:  struct
TOKEN: 0x200006D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_SessionTypeHAPI_SESSION_INPROCESS  // 0x0
  public    static  HoudiniEngineUnity.HAPI_SessionTypeHAPI_SESSION_THRIFT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_SessionTypeHAPI_SESSION_CUSTOM1  // 0x0
  public    static  HoudiniEngineUnity.HAPI_SessionTypeHAPI_SESSION_CUSTOM2  // 0x0
  public    static  HoudiniEngineUnity.HAPI_SessionTypeHAPI_SESSION_CUSTOM3  // 0x0
  public    static  HoudiniEngineUnity.HAPI_SessionTypeHAPI_SESSION_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_State
TYPE:  struct
TOKEN: 0x200006E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_READY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_READY_WITH_FATAL_ERRORS  // 0x0
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_READY_WITH_COOK_ERRORS  // 0x0
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_STARTING_COOK  // 0x0
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_COOKING  // 0x0
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_STARTING_LOAD  // 0x0
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_LOADING  // 0x0
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_MAX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_State   HAPI_STATE_MAX_READY_STATE  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PackedPrimInstancingMode
TYPE:  struct
TOKEN: 0x200006F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_PackedPrimInstancingModeHAPI_PACKEDPRIM_INSTANCING_MODE_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PackedPrimInstancingModeHAPI_PACKEDPRIM_INSTANCING_MODE_DISABLED  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PackedPrimInstancingModeHAPI_PACKEDPRIM_INSTANCING_MODE_HIERARCHY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PackedPrimInstancingModeHAPI_PACKEDPRIM_INSTANCING_MODE_FLAT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PackedPrimInstancingModeHAPI_PACKEDPRIM_INSTANCING_MODE_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_Permissions
TYPE:  struct
TOKEN: 0x2000070
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_PermissionsHAPI_PERMISSIONS_NON_APPLICABLE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PermissionsHAPI_PERMISSIONS_READ_WRITE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PermissionsHAPI_PERMISSIONS_READ_ONLY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PermissionsHAPI_PERMISSIONS_WRITE_ONLY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PermissionsHAPI_PERMISSIONS_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_RampType
TYPE:  struct
TOKEN: 0x2000071
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_RampTypeHAPI_RAMPTYPE_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_RampTypeHAPI_RAMPTYPE_FLOAT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_RampTypeHAPI_RAMPTYPE_COLOR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_RampTypeHAPI_RAMPTYPE_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ParmType
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_INT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_MULTIPARMLIST  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_TOGGLE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_BUTTON  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_FLOAT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_COLOR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_STRING  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_PATH_FILE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_PATH_FILE_GEO  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_PATH_FILE_IMAGE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_NODE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_FOLDERLIST  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_FOLDERLIST_RADIO  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_FOLDER  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_LABEL  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_SEPARATOR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_PATH_FILE_DIR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_MAX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_INT_START  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_INT_END  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_FLOAT_START  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_FLOAT_END  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_STRING_START  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_STRING_END  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_PATH_START  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_PATH_END  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_NODE_START  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_NODE_END  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_CONTAINER_START  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_CONTAINER_END  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_NONVALUE_START  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ParmTypeHAPI_PARMTYPE_NONVALUE_END  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PrmScriptType
TYPE:  struct
TOKEN: 0x2000073
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_INT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_FLOAT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_ANGLE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_STRING  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_FILE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_DIRECTORY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_IMAGE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_GEOMETRY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_TOGGLE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_BUTTON  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_VECTOR2  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_VECTOR3  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_VECTOR4  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_INTVECTOR2  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_INTVECTOR3  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_INTVECTOR4  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_UV  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_UVW  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_DIR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_COLOR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_COLOR4  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_OPPATH  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_OPLIST  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_OBJECT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_OBJECTLIST  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_RENDER  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_SEPARATOR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_GEOMETRY_DATA  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_KEY_VALUE_DICT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_LABEL  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_RGBAMASK  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_ORDINAL  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_RAMP_FLT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_RAMP_RGB  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_FLOAT_LOG  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_INT_LOG  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_DATA  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_FLOAT_MINMAX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_INT_MINMAX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_INT_STARTEND  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_BUTTONSTRIP  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_ICONSTRIP  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_GROUPRADIO  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_GROUPCOLLAPSIBLE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_GROUPSIMPLE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PrmScriptTypeHAPI_PRM_SCRIPT_TYPE_GROUP  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ChoiceListType
TYPE:  struct
TOKEN: 0x2000074
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_ChoiceListTypeHAPI_CHOICELISTTYPE_NONE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ChoiceListTypeHAPI_CHOICELISTTYPE_NORMAL  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ChoiceListTypeHAPI_CHOICELISTTYPE_MINI  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ChoiceListTypeHAPI_CHOICELISTTYPE_REPLACE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ChoiceListTypeHAPI_CHOICELISTTYPE_TOGGLE  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PresetType
TYPE:  struct
TOKEN: 0x2000075
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_PresetTypeHAPI_PRESETTYPE_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PresetTypeHAPI_PRESETTYPE_BINARY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PresetTypeHAPI_PRESETTYPE_IDX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PresetTypeHAPI_PRESETTYPE_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_NodeType
TYPE:  struct
TOKEN: 0x2000076
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_ANY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_NONE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_OBJ  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_SOP  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_CHOP  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_ROP  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_SHOP  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_COP  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_VOP  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_DOP  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeTypeHAPI_NODETYPE_TOP  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_NodeFlags
TYPE:  struct
TOKEN: 0x2000077
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_ANY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_NONE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_DISPLAY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_RENDER  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_TEMPLATED  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_LOCKED  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_EDITABLE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_BYPASS  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_NETWORK  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_OBJ_GEOMETRY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_OBJ_CAMERA  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_OBJ_LIGHT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_OBJ_SUBNET  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_SOP_CURVE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_SOP_GUIDE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_TOP_NONSCHEDULER  // 0x0
  public    static  HoudiniEngineUnity.HAPI_NodeFlagsHAPI_NODEFLAGS_NON_BYPASS  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_GroupType
TYPE:  struct
TOKEN: 0x2000078
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_GroupTypeHAPI_GROUPTYPE_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_GroupTypeHAPI_GROUPTYPE_POINT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_GroupTypeHAPI_GROUPTYPE_PRIM  // 0x0
  public    static  HoudiniEngineUnity.HAPI_GroupTypeHAPI_GROUPTYPE_EDGE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_GroupTypeHAPI_GROUPTYPE_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_AttributeOwner
TYPE:  struct
TOKEN: 0x2000079
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_AttributeOwnerHAPI_ATTROWNER_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeOwnerHAPI_ATTROWNER_VERTEX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeOwnerHAPI_ATTROWNER_POINT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeOwnerHAPI_ATTROWNER_PRIM  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeOwnerHAPI_ATTROWNER_DETAIL  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeOwnerHAPI_ATTROWNER_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_CurveType
TYPE:  struct
TOKEN: 0x200007A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_CurveTypeHAPI_CURVETYPE_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_CurveTypeHAPI_CURVETYPE_LINEAR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_CurveTypeHAPI_CURVETYPE_NURBS  // 0x0
  public    static  HoudiniEngineUnity.HAPI_CurveTypeHAPI_CURVETYPE_BEZIER  // 0x0
  public    static  HoudiniEngineUnity.HAPI_CurveTypeHAPI_CURVETYPE_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_InputCurveMethod
TYPE:  struct
TOKEN: 0x200007B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_InputCurveMethodHAPI_CURVEMETHOD_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_InputCurveMethodHAPI_CURVEMETHOD_CVS  // 0x0
  public    static  HoudiniEngineUnity.HAPI_InputCurveMethodHAPI_CURVEMETHOD_BREAKPOINTS  // 0x0
  public    static  HoudiniEngineUnity.HAPI_InputCurveMethodHAPI_CURVEMETHOD_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_InputCurveParameterization
TYPE:  struct
TOKEN: 0x200007C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_InputCurveParameterizationHAPI_CURVEPARAMETERIZATION_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_InputCurveParameterizationHAPI_CURVEPARAMETERIZATION_UNIFORM  // 0x0
  public    static  HoudiniEngineUnity.HAPI_InputCurveParameterizationHAPI_CURVEPARAMETERIZATION_CHORD  // 0x0
  public    static  HoudiniEngineUnity.HAPI_InputCurveParameterizationHAPI_CURVEPARAMETERIZATION_CENTRIPETAL  // 0x0
  public    static  HoudiniEngineUnity.HAPI_InputCurveParameterizationHAPI_CURVEPARAMETERIZATION_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_VolumeType
TYPE:  struct
TOKEN: 0x200007D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_VolumeTypeHAPI_VOLUMETYPE_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_VolumeTypeHAPI_VOLUMETYPE_HOUDINI  // 0x0
  public    static  HoudiniEngineUnity.HAPI_VolumeTypeHAPI_VOLUMETYPE_VDB  // 0x0
  public    static  HoudiniEngineUnity.HAPI_VolumeTypeHAPI_VOLUMETYPE_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_VolumeVisualType
TYPE:  struct
TOKEN: 0x200007E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_VolumeVisualTypeHAPI_VOLUMEVISTYPE_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_VolumeVisualTypeHAPI_VOLUMEVISTYPE_SMOKE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_VolumeVisualTypeHAPI_VOLUMEVISTYPE_RAINBOW  // 0x0
  public    static  HoudiniEngineUnity.HAPI_VolumeVisualTypeHAPI_VOLUMEVISTYPE_ISO  // 0x0
  public    static  HoudiniEngineUnity.HAPI_VolumeVisualTypeHAPI_VOLUMEVISTYPE_INVISIBLE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_VolumeVisualTypeHAPI_VOLUMEVISTYPE_HEIGHTFIELD  // 0x0
  public    static  HoudiniEngineUnity.HAPI_VolumeVisualTypeHAPI_VOLUMEVISTYPE_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_StorageType
TYPE:  struct
TOKEN: 0x200007F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INT64  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_FLOAT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_FLOAT64  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_STRING  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_UINT8  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INT8  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INT16  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INT_ARRAY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INT64_ARRAY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_FLOAT_ARRAY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_FLOAT64_ARRAY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_STRING_ARRAY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_UINT8_ARRAY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INT8_ARRAY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_INT16_ARRAY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_StorageTypeHAPI_STORAGETYPE_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_AttributeTypeInfo
TYPE:  struct
TOKEN: 0x2000080
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_NONE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_POINT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_HPOINT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_VECTOR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_NORMAL  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_COLOR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_QUATERNION  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_MATRIX3  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_MATRIX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_ST  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_HIDDEN  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_BOX2  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_BOX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_TEXTURE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_AttributeTypeInfoHAPI_ATTRIBUTE_TYPE_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_GeoType
TYPE:  struct
TOKEN: 0x2000081
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_DEFAULT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_INTERMEDIATE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_INPUT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_CURVE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_GeoType HAPI_GEOTYPE_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PartType
TYPE:  struct
TOKEN: 0x2000082
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_PartTypeHAPI_PARTTYPE_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PartTypeHAPI_PARTTYPE_MESH  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PartTypeHAPI_PARTTYPE_CURVE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PartTypeHAPI_PARTTYPE_VOLUME  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PartTypeHAPI_PARTTYPE_INSTANCER  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PartTypeHAPI_PARTTYPE_BOX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PartTypeHAPI_PARTTYPE_SPHERE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PartTypeHAPI_PARTTYPE_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_InputType
TYPE:  struct
TOKEN: 0x2000083
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_InputTypeHAPI_INPUT_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_InputTypeHAPI_INPUT_TRANSFORM  // 0x0
  public    static  HoudiniEngineUnity.HAPI_InputTypeHAPI_INPUT_GEOMETRY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_InputTypeHAPI_INPUT_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_CurveOrders
TYPE:  struct
TOKEN: 0x2000084
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_CurveOrdersHAPI_CURVE_ORDER_VARYING  // 0x0
  public    static  HoudiniEngineUnity.HAPI_CurveOrdersHAPI_CURVE_ORDER_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_CurveOrdersHAPI_CURVE_ORDER_LINEAR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_CurveOrdersHAPI_CURVE_ORDER_QUADRATIC  // 0x0
  public    static  HoudiniEngineUnity.HAPI_CurveOrdersHAPI_CURVE_ORDER_CUBIC  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_TransformComponent
TYPE:  struct
TOKEN: 0x2000085
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_TX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_TY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_TZ  // 0x0
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_RX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_RY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_RZ  // 0x0
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_QX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_QY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_QZ  // 0x0
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_QW  // 0x0
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_SX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_SY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_TransformComponentHAPI_TRANSFORM_SZ  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_RSTOrder
TYPE:  struct
TOKEN: 0x2000086
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_RSTOrderHAPI_TRS  // 0x0
  public    static  HoudiniEngineUnity.HAPI_RSTOrderHAPI_TSR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_RSTOrderHAPI_RTS  // 0x0
  public    static  HoudiniEngineUnity.HAPI_RSTOrderHAPI_RST  // 0x0
  public    static  HoudiniEngineUnity.HAPI_RSTOrderHAPI_STR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_RSTOrderHAPI_SRT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_RSTOrderHAPI_RSTORDER_DEFAULT  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_XYZOrder
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_XYZOrderHAPI_XYZ  // 0x0
  public    static  HoudiniEngineUnity.HAPI_XYZOrderHAPI_XZY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_XYZOrderHAPI_YXZ  // 0x0
  public    static  HoudiniEngineUnity.HAPI_XYZOrderHAPI_YZX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_XYZOrderHAPI_ZXY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_XYZOrderHAPI_ZYX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_XYZOrderHAPI_XYZORDER_DEFAULT  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ImageDataFormat
TYPE:  struct
TOKEN: 0x2000088
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_ImageDataFormatHAPI_IMAGE_DATA_UNKNOWN  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ImageDataFormatHAPI_IMAGE_DATA_INT8  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ImageDataFormatHAPI_IMAGE_DATA_INT16  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ImageDataFormatHAPI_IMAGE_DATA_INT32  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ImageDataFormatHAPI_IMAGE_DATA_FLOAT16  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ImageDataFormatHAPI_IMAGE_DATA_FLOAT32  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ImageDataFormatHAPI_IMAGE_DATA_MAX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ImageDataFormatHAPI_IMAGE_DATA_DEFAULT  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ImagePacking
TYPE:  struct
TOKEN: 0x2000089
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_UNKNOWN  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_SINGLE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_DUAL  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_RGB  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_BGR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_RGBA  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_ABGR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_MAX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_DEFAULT3  // 0x0
  public    static  HoudiniEngineUnity.HAPI_ImagePackingHAPI_IMAGE_PACKING_DEFAULT4  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_EnvIntType
TYPE:  struct
TOKEN: 0x200008A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_VERSION_HOUDINI_MAJOR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_VERSION_HOUDINI_MINOR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_VERSION_HOUDINI_BUILD  // 0x0
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_VERSION_HOUDINI_PATCH  // 0x0
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_VERSION_HOUDINI_ENGINE_MAJOR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_VERSION_HOUDINI_ENGINE_MINOR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_VERSION_HOUDINI_ENGINE_API  // 0x0
  public    static  HoudiniEngineUnity.HAPI_EnvIntTypeHAPI_ENVINT_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_SessionEnvIntType
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_SessionEnvIntTypeHAPI_SESSIONENVINT_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HAPI_SessionEnvIntTypeHAPI_SESSIONENVINT_LICENSE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_SessionEnvIntTypeHAPI_SESSIONENVINT_MAX  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_CacheProperty
TYPE:  struct
TOKEN: 0x200008C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_CachePropertyHAPI_CACHEPROP_CURRENT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_CachePropertyHAPI_CACHEPROP_HAS_MIN  // 0x0
  public    static  HoudiniEngineUnity.HAPI_CachePropertyHAPI_CACHEPROP_MIN  // 0x0
  public    static  HoudiniEngineUnity.HAPI_CachePropertyHAPI_CACHEPROP_HAS_MAX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_CachePropertyHAPI_CACHEPROP_MAX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_CachePropertyHAPI_CACHEPROP_CULL_LEVEL  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_HeightFieldSampling
TYPE:  struct
TOKEN: 0x200008D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_HeightFieldSamplingHAPI_HEIGHTFIELD_SAMPLING_CENTER  // 0x0
  public    static  HoudiniEngineUnity.HAPI_HeightFieldSamplingHAPI_HEIGHTFIELD_SAMPLING_CORNER  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PDG_State
TYPE:  struct
TOKEN: 0x200008E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_PDG_StateHAPI_PDG_STATE_READY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_StateHAPI_PDG_STATE_COOKING  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_StateHAPI_PDG_STATE_MAX  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_StateHAPI_PDG_STATE_MAX_READY_STATE  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PDG_EventType
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NULL  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_ADD  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_REMOVE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_STATE_CHANGE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_ADD_DEP  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_REMOVE_DEP  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_ADD_PARENT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_REMOVE_PARENT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_CLEAR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_COOK_ERROR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_COOK_WARNING  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_COOK_COMPLETE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_DIRTY_START  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_DIRTY_STOP  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_DIRTY_ALL  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_UI_SELECT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_CREATE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_REMOVE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_RENAME  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_CONNECT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_DISCONNECT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_SET_INT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_SET_FLOAT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_SET_STRING  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_SET_FILE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_SET_PYOBJECT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_SET_GEOMETRY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_MERGE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_RESULT  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_PRIORITY  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_COOK_START  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_ADD_STATIC_ANCESTOR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_WORKITEM_REMOVE_STATIC_ANCESTOR  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_PROGRESS_UPDATE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_BATCH_ITEM_INITIALIZED  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_ALL  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_LOG  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_SCHEDULER_ADDED  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_SCHEDULER_REMOVED  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_SET_SCHEDULER  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_SERVICE_MANAGER_ALL  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_COOKED  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_EVENT_NODE_GENERATED  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_EventTypeHAPI_PDG_CONTEXT_EVENTS  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PDG_WorkItemState
TYPE:  struct
TOKEN: 0x2000090
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_UNDEFINED  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_UNCOOKED  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_WAITING  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_SCHEDULED  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_COOKING  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_COOKED_SUCCESS  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_COOKED_CACHE  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_COOKED_FAIL  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_COOKED_CANCEL  // 0x0
  public    static  HoudiniEngineUnity.HAPI_PDG_WorkItemStateHAPI_PDG_WORKITEM_DIRTY  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HAPIFunctions
TYPE:  class
TOKEN: 0x2000091
FIELDS:
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_Transform
TYPE:  struct
TOKEN: 0x2000092
FIELDS:
  public            System.Single[]                 position  // 0x10
  public            System.Single[]                 rotationQuaternion  // 0x18
  public            System.Single[]                 scale  // 0x20
  public            System.Single[]                 shear  // 0x28
  public            HoudiniEngineUnity.HAPI_RSTOrderrstOrder  // 0x30
METHODS:
  System.Void .ctor(System.Boolean initializeFields)
  System.Void Init()
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_TransformEuler
TYPE:  struct
TOKEN: 0x2000093
FIELDS:
  public            System.Single[]                 position  // 0x10
  public            System.Single[]                 rotationEuler  // 0x18
  public            System.Single[]                 scale  // 0x20
  public            System.Single[]                 shear  // 0x28
  public            HoudiniEngineUnity.HAPI_XYZOrderrotationOrder  // 0x30
  public            HoudiniEngineUnity.HAPI_RSTOrderrstOrder  // 0x34
METHODS:
  System.Void .ctor(System.Boolean initializeFields)
  System.Void Init()
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_Session
TYPE:  struct
TOKEN: 0x2000094
FIELDS:
  public            HoudiniEngineUnity.HAPI_SessionTypetype  // 0x10
  public            System.Int64                    id  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ThriftServerOptions
TYPE:  struct
TOKEN: 0x2000095
FIELDS:
  public            System.Boolean                  autoClose  // 0x10
  public            System.Single                   timeoutMs  // 0x14
  public            HoudiniEngineUnity.HAPI_StatusVerbosityverbosity  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_TimelineOptions
TYPE:  struct
TOKEN: 0x2000096
FIELDS:
  public            System.Single                   fps  // 0x10
  public            System.Single                   startTime  // 0x14
  public            System.Single                   endTime  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_AssetInfo
TYPE:  struct
TOKEN: 0x2000097
FIELDS:
  public            System.Int32                    nodeId  // 0x10
  public            System.Int32                    objectNodeId  // 0x14
  public            System.Boolean                  hasEverCooked  // 0x18
  public            System.Int32                    nameSH  // 0x1C
  public            System.Int32                    labelSH  // 0x20
  public            System.Int32                    filePathSH  // 0x24
  public            System.Int32                    versionSH  // 0x28
  public            System.Int32                    fullOpNameSH  // 0x2C
  public            System.Int32                    helpTextSH  // 0x30
  public            System.Int32                    helpURLSH  // 0x34
  public            System.Int32                    objectCount  // 0x38
  public            System.Int32                    handleCount  // 0x3C
  public            System.Int32                    transformInputCount  // 0x40
  public            System.Int32                    geoInputCount  // 0x44
  public            System.Int32                    geoOutputCount  // 0x48
  public            System.Boolean                  haveObjectsChanged  // 0x4C
  public            System.Boolean                  haveMaterialsChanged  // 0x4D
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_CookOptions
TYPE:  struct
TOKEN: 0x2000098
FIELDS:
  public            System.Boolean                  splitGeosByGroup  // 0x10
  public            System.Int32                    splitGroupSH  // 0x14
  public            System.Boolean                  splitGeosByAttribute  // 0x18
  public            System.Int32                    splitAttrSH  // 0x1C
  public            System.Int32                    maxVerticesPerPrimitive  // 0x20
  public            System.Boolean                  refineCurveToLinear  // 0x24
  public            System.Single                   curveRefineLOD  // 0x28
  public            System.Boolean                  clearErrorsAndWarnings  // 0x2C
  public            System.Boolean                  cookTemplatedGeos  // 0x2D
  public            System.Boolean                  splitPointsByVertexAttributes  // 0x2E
  public            HoudiniEngineUnity.HAPI_PackedPrimInstancingModepackedPrimInstancingMode  // 0x30
  public            System.Boolean                  handleBoxPartTypes  // 0x34
  public            System.Boolean                  handleSpherePartTypes  // 0x35
  public            System.Boolean                  checkPartChanges  // 0x36
  public            System.Boolean                  cacheMeshTopology  // 0x37
  public            System.Boolean                  preferOutputNodes  // 0x38
  public            System.Int32                    extraFlags  // 0x3C
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_NodeInfo
TYPE:  struct
TOKEN: 0x2000099
FIELDS:
  public            System.Int32                    id  // 0x10
  public            System.Int32                    parentId  // 0x14
  public            System.Int32                    nameSH  // 0x18
  public            HoudiniEngineUnity.HAPI_NodeTypetype  // 0x1C
  public            System.Boolean                  isValid  // 0x20
  public            System.Int32                    totalCookCount  // 0x24
  public            System.Int32                    uniqueHoudiniNodeId  // 0x28
  public            System.Int32                    internalNodePathSH  // 0x2C
  public            System.Int32                    parmCount  // 0x30
  public            System.Int32                    parmIntValueCount  // 0x34
  public            System.Int32                    parmFloatValueCount  // 0x38
  public            System.Int32                    parmStringValueCount  // 0x3C
  public            System.Int32                    parmChoiceCount  // 0x40
  public            System.Int32                    childNodeCount  // 0x44
  public            System.Int32                    inputCount  // 0x48
  public            System.Int32                    outputCount  // 0x4C
  public            System.Boolean                  createdPostAssetLoad  // 0x50
  public            System.Boolean                  isTimeDependent  // 0x51
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ParmInfo
TYPE:  struct
TOKEN: 0x200009A
FIELDS:
  public            System.Int32                    id  // 0x10
  public            System.Int32                    parentId  // 0x14
  public            System.Int32                    childIndex  // 0x18
  public            HoudiniEngineUnity.HAPI_ParmTypetype  // 0x1C
  public            HoudiniEngineUnity.HAPI_PrmScriptTypescriptType  // 0x20
  public            System.Int32                    typeInfoSH  // 0x24
  public            HoudiniEngineUnity.HAPI_Permissionspermissions  // 0x28
  public            System.Int32                    tagCount  // 0x2C
  public            System.Int32                    size  // 0x30
  public            HoudiniEngineUnity.HAPI_ChoiceListTypechoiceListType  // 0x34
  public            System.Int32                    choiceCount  // 0x38
  public            System.Int32                    nameSH  // 0x3C
  public            System.Int32                    labelSH  // 0x40
  public            System.Int32                    templateNameSH  // 0x44
  public            System.Int32                    helpSH  // 0x48
  public            System.Boolean                  hasMin  // 0x4C
  public            System.Boolean                  hasMax  // 0x4D
  public            System.Boolean                  hasUIMin  // 0x4E
  public            System.Boolean                  hasUIMax  // 0x4F
  public            System.Single                   min  // 0x50
  public            System.Single                   max  // 0x54
  public            System.Single                   UIMin  // 0x58
  public            System.Single                   UIMax  // 0x5C
  public            System.Boolean                  invisible  // 0x60
  public            System.Boolean                  disabled  // 0x61
  public            System.Boolean                  spare  // 0x62
  public            System.Boolean                  joinNext  // 0x63
  public            System.Boolean                  labelNone  // 0x64
  public            System.Int32                    intValuesIndex  // 0x68
  public            System.Int32                    floatValuesIndex  // 0x6C
  public            System.Int32                    stringValuesIndex  // 0x70
  public            System.Int32                    choiceIndex  // 0x74
  public            HoudiniEngineUnity.HAPI_NodeTypeinputNodeType  // 0x78
  public            HoudiniEngineUnity.HAPI_NodeFlagsinputNodeFlag  // 0x7C
  public            System.Boolean                  isChildOfMultiParm  // 0x80
  public            System.Int32                    instanceNum  // 0x84
  public            System.Int32                    instanceLength  // 0x88
  public            System.Int32                    instanceCount  // 0x8C
  public            System.Int32                    instanceStartOffset  // 0x90
  public            HoudiniEngineUnity.HAPI_RampTyperampType  // 0x94
  public            System.Int32                    visibilityConditionSH  // 0x98
  public            System.Int32                    disabledConditionSH  // 0x9C
  public            System.Boolean                  useMenuItemTokenAsValue  // 0xA0
METHODS:
  System.Boolean isInt()
  System.Boolean isFloat()
  System.Boolean isString()
  System.Boolean isPath()
  System.Boolean isNode()
  System.Boolean isNonValue()
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ParmChoiceInfo
TYPE:  struct
TOKEN: 0x200009B
FIELDS:
  public            System.Int32                    parentParmId  // 0x10
  public            System.Int32                    labelSH  // 0x14
  public            System.Int32                    valueSH  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_HandleInfo
TYPE:  struct
TOKEN: 0x200009C
FIELDS:
  public            System.Int32                    nameSH  // 0x10
  public            System.Int32                    typeNameSH  // 0x14
  public            System.Int32                    bindingsCount  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_HandleBindingInfo
TYPE:  struct
TOKEN: 0x200009D
FIELDS:
  public            System.Int32                    handleParmNameSH  // 0x10
  public            System.Int32                    assetParmNameSH  // 0x14
  public            System.Int32                    assetParmId  // 0x18
  public            System.Int32                    assetParmIndex  // 0x1C
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ObjectInfo
TYPE:  struct
TOKEN: 0x200009E
FIELDS:
  public            System.Int32                    nameSH  // 0x10
  public            System.Int32                    objectInstancePathSH  // 0x14
  public            System.Boolean                  hasTransformChanged  // 0x18
  public            System.Boolean                  haveGeosChanged  // 0x19
  public            System.Boolean                  isVisible  // 0x1A
  public            System.Boolean                  isInstancer  // 0x1B
  public            System.Boolean                  isInstanced  // 0x1C
  public            System.Int32                    geoCount  // 0x20
  public            System.Int32                    nodeId  // 0x24
  public            System.Int32                    objectToInstanceId  // 0x28
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_GeoInfo
TYPE:  struct
TOKEN: 0x200009F
FIELDS:
  public            HoudiniEngineUnity.HAPI_GeoType type  // 0x10
  public            System.Int32                    nameSH  // 0x14
  public            System.Int32                    nodeId  // 0x18
  public            System.Boolean                  isEditable  // 0x1C
  public            System.Boolean                  isTemplated  // 0x1D
  public            System.Boolean                  isDisplayGeo  // 0x1E
  public            System.Boolean                  hasGeoChanged  // 0x1F
  public            System.Boolean                  hasMaterialChanged  // 0x20
  public            System.Int32                    pointGroupCount  // 0x24
  public            System.Int32                    primitiveGroupCount  // 0x28
  public            System.Int32                    edgeGroupCount  // 0x2C
  public            System.Int32                    partCount  // 0x30
METHODS:
  System.Int32 getGroupCountByType(HoudiniEngineUnity.HAPI_GroupType type)
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PartInfo
TYPE:  struct
TOKEN: 0x20000A0
FIELDS:
  public            System.Int32                    id  // 0x10
  public            System.Int32                    nameSH  // 0x14
  public            HoudiniEngineUnity.HAPI_PartTypetype  // 0x18
  public            System.Int32                    faceCount  // 0x1C
  public            System.Int32                    vertexCount  // 0x20
  public            System.Int32                    pointCount  // 0x24
  public            System.Int32[]                  attributeCounts  // 0x28
  public            System.Boolean                  isInstanced  // 0x30
  public            System.Int32                    instancedPartCount  // 0x34
  public            System.Int32                    instanceCount  // 0x38
  public            System.Boolean                  hasChanged  // 0x3C
METHODS:
  System.Int32 getElementCountByAttributeOwner(HoudiniEngineUnity.HAPI_AttributeOwner owner)
  System.Int32 getElementCountByGroupType(HoudiniEngineUnity.HAPI_GroupType type)
  System.Void init()
  System.Int32 get_pointAttributeCount()
  System.Void set_pointAttributeCount(System.Int32 value)
  System.Int32 get_primitiveAttributeCount()
  System.Void set_primitiveAttributeCount(System.Int32 value)
  System.Int32 get_vertexAttributeCount()
  System.Void set_vertexAttributeCount(System.Int32 value)
  System.Int32 get_detailAttributeCount()
  System.Void set_detailAttributeCount(System.Int32 value)
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_AttributeInfo
TYPE:  struct
TOKEN: 0x20000A1
FIELDS:
  public            System.Boolean                  exists  // 0x10
  public            HoudiniEngineUnity.HAPI_AttributeOwnerowner  // 0x14
  public            HoudiniEngineUnity.HAPI_StorageTypestorage  // 0x18
  public            HoudiniEngineUnity.HAPI_AttributeOwneroriginalOwner  // 0x1C
  public            System.Int32                    count  // 0x20
  public            System.Int32                    tupleSize  // 0x24
  public            System.Int64                    totalArrayElements  // 0x28
  public            HoudiniEngineUnity.HAPI_AttributeTypeInfotypeInfo  // 0x30
METHODS:
  System.Void .ctor(System.String ignored)
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_MaterialInfo
TYPE:  struct
TOKEN: 0x20000A2
FIELDS:
  public            System.Int32                    nodeId  // 0x10
  public            System.Boolean                  exists  // 0x14
  public            System.Boolean                  hasChanged  // 0x15
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ImageFileFormat
TYPE:  struct
TOKEN: 0x20000A3
FIELDS:
  public            System.Int32                    nameSH  // 0x10
  public            System.Int32                    descriptionSH  // 0x14
  public            System.Int32                    defaultExtensionSH  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_ImageInfo
TYPE:  struct
TOKEN: 0x20000A4
FIELDS:
  public            System.Int32                    imageFileFormatNameSH  // 0x10
  public            System.Int32                    xRes  // 0x14
  public            System.Int32                    yRes  // 0x18
  public            HoudiniEngineUnity.HAPI_ImageDataFormatdataFormat  // 0x1C
  public            System.Boolean                  interleaved  // 0x20
  public            HoudiniEngineUnity.HAPI_ImagePackingpacking  // 0x24
  public            System.Double                   gamma  // 0x28
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_Keyframe
TYPE:  struct
TOKEN: 0x20000A5
FIELDS:
  public            System.Single                   time  // 0x10
  public            System.Single                   value  // 0x14
  public            System.Single                   inTangent  // 0x18
  public            System.Single                   outTangent  // 0x1C
METHODS:
  System.Void .ctor(System.Single t, System.Single v, System.Single in_tangent, System.Single out_tangent)
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_VolumeInfo
TYPE:  struct
TOKEN: 0x20000A6
FIELDS:
  public            System.Int32                    nameSH  // 0x10
  public            HoudiniEngineUnity.HAPI_VolumeTypetype  // 0x14
  public            System.Int32                    xLength  // 0x18
  public            System.Int32                    yLength  // 0x1C
  public            System.Int32                    zLength  // 0x20
  public            System.Int32                    minX  // 0x24
  public            System.Int32                    minY  // 0x28
  public            System.Int32                    minZ  // 0x2C
  public            System.Int32                    tupleSize  // 0x30
  public            HoudiniEngineUnity.HAPI_StorageTypestorage  // 0x34
  public            System.Int32                    tileSize  // 0x38
  public            HoudiniEngineUnity.HAPI_Transformtransform  // 0x40
  public            System.Boolean                  hasTaper  // 0x68
  public            System.Single                   xTaper  // 0x6C
  public            System.Single                   yTaper  // 0x70
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_VolumeTileInfo
TYPE:  struct
TOKEN: 0x20000A7
FIELDS:
  public            System.Int32                    minX  // 0x10
  public            System.Int32                    minY  // 0x14
  public            System.Int32                    minZ  // 0x18
  public            System.Boolean                  isValid  // 0x1C
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_VolumeVisualInfo
TYPE:  struct
TOKEN: 0x20000A8
FIELDS:
  public            HoudiniEngineUnity.HAPI_VolumeVisualTypetype  // 0x10
  public            System.Single                   iso  // 0x14
  public            System.Single                   density  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_CurveInfo
TYPE:  struct
TOKEN: 0x20000A9
FIELDS:
  public            HoudiniEngineUnity.HAPI_CurveTypecurveType  // 0x10
  public            System.Int32                    curveCount  // 0x14
  public            System.Int32                    vertexCount  // 0x18
  public            System.Int32                    knotCount  // 0x1C
  public            System.Boolean                  isPeriodic  // 0x20
  public            System.Boolean                  isRational  // 0x21
  public            System.Int32                    order  // 0x24
  public            System.Boolean                  hasKnots  // 0x28
  public            System.Boolean                  isClosed  // 0x29
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_InputCurveInfo
TYPE:  struct
TOKEN: 0x20000AA
FIELDS:
  public            HoudiniEngineUnity.HAPI_CurveTypecurveType  // 0x10
  public            System.Int32                    order  // 0x14
  public            System.Boolean                  closed  // 0x18
  public            System.Boolean                  reverse  // 0x19
  public            HoudiniEngineUnity.HAPI_InputCurveMethodinputMethod  // 0x1C
  public            HoudiniEngineUnity.HAPI_InputCurveParameterizationbreakpointParameterization  // 0x20
METHODS:
  System.Void FillData(HoudiniEngineUnity.HEU_InputCurveInfo curveInfo)
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_BoxInfo
TYPE:  struct
TOKEN: 0x20000AB
FIELDS:
  public            System.Single[]                 center  // 0x10
  public            System.Single[]                 size  // 0x18
  public            System.Single[]                 rotation  // 0x20
METHODS:
  System.Void .ctor(System.Boolean initialize_fields)
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_SphereInfo
TYPE:  struct
TOKEN: 0x20000AC
FIELDS:
  public            System.Single[]                 center  // 0x10
  public            System.Single                   radius  // 0x18
METHODS:
  System.Void .ctor(System.Boolean initialize_fields)
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PDG_EventInfo
TYPE:  struct
TOKEN: 0x20000AD
FIELDS:
  public            System.Int32                    nodeId  // 0x10
  public            System.Int32                    workItemId  // 0x14
  public            System.Int32                    dependencyId  // 0x18
  public            System.Int32                    currentState  // 0x1C
  public            System.Int32                    lastState  // 0x20
  public            System.Int32                    eventType  // 0x24
  public            System.Int32                    msgSH  // 0x28
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PDG_WorkItemInfo
TYPE:  struct
TOKEN: 0x20000AE
FIELDS:
  public            System.Int32                    index  // 0x10
  public            System.Int32                    outputFileCount  // 0x14
  public            System.Int32                    nameSH  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_PDG_WorkItemOutputFile
TYPE:  struct
TOKEN: 0x20000AF
FIELDS:
  public            System.Int32                    filePathSH  // 0x10
  public            System.Int32                    tagSH  // 0x14
  public            System.Int64                    hash  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_Viewport
TYPE:  struct
TOKEN: 0x20000B0
FIELDS:
  public            System.Single[]                 position  // 0x10
  public            System.Single[]                 rotationQuaternion  // 0x18
  public            System.Single                   offset  // 0x20
METHODS:
  System.Void .ctor(System.Boolean initializeFields)
  System.Void Init()
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_SessionSyncInfo
TYPE:  struct
TOKEN: 0x20000B1
FIELDS:
  public            System.Boolean                  cookUsingHoudiniTime  // 0x10
  public            System.Boolean                  syncViewport  // 0x11
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HAPI_CompositorOptions
TYPE:  struct
TOKEN: 0x20000B2
FIELDS:
  public            System.Int32                    maximumResolutionX  // 0x10
  public            System.Int32                    maximumResolutionY  // 0x14
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HARCImports
TYPE:  class
TOKEN: 0x20000B3
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HoudiniVersion
TYPE:  class
TOKEN: 0x20000B4
FIELDS:
  public    static  System.Int32                    HOUDINI_MAJOR  // 0x0
  public    static  System.Int32                    HOUDINI_MINOR  // 0x0
  public    static  System.Int32                    HOUDINI_BUILD  // 0x0
  public    static  System.Int32                    HOUDINI_PATCH  // 0x0
  public    static  System.String                   HOUDINI_VERSION_STRING  // 0x0
  public    static  System.Int32                    HOUDINI_ENGINE_MAJOR  // 0x0
  public    static  System.Int32                    HOUDINI_ENGINE_MINOR  // 0x0
  public    static  System.Int32                    HOUDINI_ENGINE_API  // 0x0
  public    static  System.Int32                    UNITY_PLUGIN_VERSION  // 0x0
  public    static  System.String                   HAPI_BIN_PATH  // 0x0
  public    static  System.String                   HAPI_LIBRARY  // 0x0
  public    static  System.String                   HARC_LIBRARY  // 0x0
  public    static  System.String                   SIDEFX_SOFTWARE_REGISTRY  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HTC_APIConstants
TYPE:  class
TOKEN: 0x20000B5
FIELDS:
  public    static  System.String                   HOUDINI_MASTER_SERVER_HOSTNAME  // 0x0
  public    static  System.Int32                    HOUDINI_MASTER_QUERY_FOR_UNITY_PORT  // 0x0
  public    static  System.Int32                    TCP_HEADER_SIZE  // 0x0
  public    static  System.Int32                    MAX_ERROR_INFO_SIZE  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HTC_VERSION
TYPE:  class
TOKEN: 0x20000B6
FIELDS:
  public    static  System.String                   LIBRARY  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HoudiniConstsIdentifier
TYPE:  class
TOKEN: 0x20000B7
FIELDS:
  public    static  System.String                   HOUDINI_VERSION  // 0x0
  public    static  System.String                   PROJECT_TAG  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HTC_APIFunctions
TYPE:  class
TOKEN: 0x20000B8
FIELDS:
METHODS:
  System.Void InitHoudiniTcpClient(System.String address, System.Int32 port, System.Boolean use_ip, System.Text.StringBuilder error_msg)
  System.Void GetHarsInfo(HoudiniEngineUnity.HarsInfo& harsInfo, System.Text.StringBuilder error_msg)
  System.Void UninitializeHoudiniTcpClient(System.Text.StringBuilder error_msg)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HarsInfo
TYPE:  struct
TOKEN: 0x20000B9
FIELDS:
  public            System.String                   hars_address  // 0x10
  public            System.Int32                    port  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.GenericMessage
TYPE:  struct
TOKEN: 0x20000BA
FIELDS:
  public            System.String                   protocol  // 0x10
  public            System.Object                   body  // 0x18
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.Logger
TYPE:  class
TOKEN: 0x20000BB
FIELDS:
METHODS:
  System.Void LogError(System.String msg)
  System.Void LogWarning(System.String msg)
  System.Void LogInfo(System.String msg)
END_CLASS

CLASS: HoudiniEngineUnity.HTC_SessionManager
TYPE:  class
TOKEN: 0x20000BC
FIELDS:
  private           System.Boolean                  disposedValue  // 0x10
  private   static  HoudiniEngineUnity.HTC_SessionManagerinstance_  // 0x0
METHODS:
  System.Void .ctor()
  System.Void Finalize()
  System.Void Dispose(System.Boolean disposing)
  System.Void Dispose()
  System.Boolean GetOrRequestAvailableHARSInfo(System.String& harsAddress, System.Int32& harsPort, System.String& errorInfo)
  System.Void Close()
  HoudiniEngineUnity.HTC_SessionManager get_Instance()
END_CLASS

CLASS: HoudiniEngineUnity.HTC_Utils
TYPE:  class
TOKEN: 0x20000BD
FIELDS:
  private   static readonly System.String                   CurrentUnityProjectPrefix  // 0x0
METHODS:
  System.String GetUnityPathFromSystemPath(System.String systemPath)
  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.HoudiniExtTools
TYPE:  class
TOKEN: 0x20000BE
FIELDS:
  private   static readonly System.String                   LOCAL_IP_ADDRESS  // 0x0
  private   static readonly System.String                   REMOTE_HOUDINI_SMB_PATH_PREFIX  // 0x8
  private   static readonly System.String                   REMOTE_HOUDINI_DEBUG_SMB_PATH_PREFIX  // 0x10
  public    static  System.String                   REMOTE_HOUDINI_HDA_SMB_URL  // 0x0
  public    static  System.String                   REMOTE_HOUDINI_SMB_URL  // 0x0
  public    static  System.String                   LINUX_MOUNT_DIR_PREFIX  // 0x0
  public    static  System.String                   PROJECT_TAG  // 0x0
METHODS:
  System.Int64 GetSessionID(System.Int64 sessionId)
  System.String GetDefaultDirectoryOnTheSMB()
  System.String GetDefaultSessionDirectoryOnTheSMB(System.Int64 sessionId)
  System.String ConvertLocalDirPathToSessionDirPath(System.String localPath, System.Boolean doMd5, System.Int64 sessionId)
  System.String ConvertLocalDebugFilePathToSessionDebugFilePath(System.String localFilePath, System.Int64 sessionId)
  System.String ConvertLocalFilePathToSessionFilePath(System.String localFilePath, System.Int64 sessionId)
  System.Boolean IsLocalPath(System.String path)
  System.String GetMD5WithString(System.String str)
  System.String GetLocalIPv4()
  System.String GetHoudiniSMBUrl()
  System.String GetDefaultCachePath(System.Int64 sessionId)
  System.String GetDefaultHdaPath()
  System.Int64 get_DefaultSessionID()
  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.HoudiniExtBridge
TYPE:  class
TOKEN: 0x20000BF
FIELDS:
METHODS:
  System.Boolean GetParametersFromHDA(System.Byte[] hdaBytes, HoudiniEngineUnity.HEU_Parameters& parameters, System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode>& inputNodes)
  System.Void AddInputNodeToHoudiniAsset(HoudiniEngineUnity.HEU_HoudiniAsset asset, HoudiniEngineUnity.HEU_InputNode node)
  System.Void Clear(HoudiniEngineUnity.HEU_Parameters parameters)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ParameterData
TYPE:  class
TOKEN: 0x20000C0
FIELDS:
  public            System.Int32                    _unityIndex  // 0x10
  public            System.String                   _name  // 0x18
  public            System.String                   _labelName  // 0x20
  public            System.String                   _help  // 0x28
  public            System.Collections.Generic.List<System.Int32>_childParameterIDs  // 0x30
  public            System.Int32                    _choiceValue  // 0x38
  public            System.Int32[]                  _intValues  // 0x40
  public            System.Single[]                 _floatValues  // 0x48
  public            System.String[]                 _stringValues  // 0x50
  public            System.Boolean                  _toggle  // 0x58
  public            UnityEngine.Color               _color  // 0x5C
  public            UnityEngine.Gradient            _gradient  // 0x70
  public            UnityEngine.AnimationCurve      _animCurve  // 0x78
  public            UnityEngine.GUIContent[]        _choiceLabels  // 0x80
  public            System.String[]                 _choiceStringValues  // 0x88
  public            System.Int32[]                  _choiceIntValues  // 0x90
  public            HoudiniEngineUnity.HAPI_ParmInfo_parmInfo  // 0x98
  public            System.Boolean                  _showChildren  // 0x12C
  public            System.String                   _fileTypeInfo  // 0x130
  public            System.Int32                    _folderListChildrenProcessed  // 0x138
  public            System.Int32                    _tabSelectedIndex  // 0x13C
  public            HoudiniEngineUnity.HEU_InputNode_paramInputNode  // 0x140
  public            System.Boolean                  _hasAssetPathTag  // 0x148
METHODS:
  System.Int32 get_ParmID()
  System.Int32 get_ParentID()
  System.Int32 get_ChildIndex()
  System.Int32 get_ParmSize()
  System.Boolean IsInt()
  System.Boolean IsFloat()
  System.Boolean IsString()
  System.Boolean IsPathFile()
  System.Boolean HasMin()
  System.Boolean HasMax()
  System.Boolean HasUIMin()
  System.Boolean HasUIMax()
  System.Int32 get_IntMin()
  System.Int32 get_IntMax()
  System.Int32 get_IntUIMin()
  System.Int32 get_IntUIMax()
  System.Single get_FloatMin()
  System.Single get_FloatMax()
  System.Single get_FloatUIMin()
  System.Single get_FloatUIMax()
  System.Boolean IsContainer()
  System.Boolean IsMultiParam()
  System.Boolean IsRamp()
  System.Boolean IsFloatRamp()
  System.Boolean IsColorRamp()
  System.Boolean IsToggle()
  System.Boolean IsColor()
  System.Boolean IsFolder()
  System.Boolean IsButton()
  UnityEngine.Vector3 ToVector3()
  System.Boolean IsAssetPath()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ParameterData other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ModifierActionWrapper
TYPE:  struct
TOKEN: 0x20000C1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_ModifierActionWrapperMULTIPARM_INSERT  // 0x0
  public    static  HoudiniEngineUnity.HEU_ModifierActionWrapperMULTIPARM_REMOVE  // 0x0
  public    static  HoudiniEngineUnity.HEU_ModifierActionWrapperMULTIPARM_CLEAR  // 0x0
  public    static  HoudiniEngineUnity.HEU_ModifierActionWrapperSET_FLOAT  // 0x0
  public    static  HoudiniEngineUnity.HEU_ModifierActionWrapperSET_INT  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ParameterModifier
TYPE:  class
TOKEN: 0x20000C2
FIELDS:
  private           System.Int32                    _parameterIndex  // 0x10
  private           HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction_action  // 0x14
  private           System.Int32                    _instanceIndex  // 0x18
  private           System.Int32                    _modifierValue  // 0x1C
  private           System.Single                   _floatValue  // 0x20
  private           System.Int32                    _intValue  // 0x24
METHODS:
  System.Int32 get_ParameterIndex()
  System.Void set_ParameterIndex(System.Int32 value)
  HoudiniEngineUnity.HEU_ModifierActionWrapper get_Action()
  System.Void set_Action(HoudiniEngineUnity.HEU_ModifierActionWrapper value)
  System.Int32 get_InstanceIndex()
  System.Void set_InstanceIndex(System.Int32 value)
  System.Int32 get_ModifierValue()
  System.Void set_ModifierValue(System.Int32 value)
  System.Single get_FloatValue()
  System.Void set_FloatValue(System.Single value)
  System.Int32 get_IntValue()
  System.Void set_IntValue(System.Int32 value)
  HoudiniEngineUnity.HEU_ParameterModifier GetNewModifier(HoudiniEngineUnity.HEU_ModifierActionWrapper action, System.Int32 parameterIndex, System.Int32 instanceIndex, System.Int32 modifierValue)
  HoudiniEngineUnity.HEU_ParameterModifier GetNewModifier(HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction action, System.Int32 parameterIndex, System.Int32 instanceIndex, System.Int32 modifierValue)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ParameterModifier other)
  HoudiniEngineUnity.HEU_ModifierActionWrapper ModifierAction_InternalToWrapper(HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction action)
  HoudiniEngineUnity.HEU_ParameterModifier.ModifierAction ModifierAction_WrapperToInternal(HoudiniEngineUnity.HEU_ModifierActionWrapper action)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Parameters
TYPE:  class
TOKEN: 0x20000C4
EXTENDS: ScriptableObject
FIELDS:
  private           System.Int32                    _nodeID  // 0x18
  private           System.String                   _uiLabel  // 0x20
  private           System.Int32[]                  _paramInts  // 0x28
  private           System.Single[]                 _paramFloats  // 0x30
  private           System.String[]                 _paramStrings  // 0x38
  private           HoudiniEngineUnity.HAPI_ParmChoiceInfo[]_paramChoices  // 0x40
  private           System.Collections.Generic.List<System.Int32>_rootParameters  // 0x48
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterData>_parameterList  // 0x50
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterModifier>_parameterModifiers  // 0x58
  private           System.Boolean                  _regenerateParameters  // 0x60
  private           System.Byte[]                   _presetData  // 0x68
  private           System.Byte[]                   _defaultPresetData  // 0x70
  private           System.Boolean                  _validParameters  // 0x78
  private           System.Boolean                  _showParameters  // 0x79
  private           System.Boolean                  _recacheUI  // 0x7A
  private           HoudiniEngineUnity.HEU_HoudiniAsset_parentAsset  // 0x80
METHODS:
  HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset()
  System.Boolean get_ShowParameters()
  System.Void set_ShowParameters(System.Boolean value)
  System.Int32 get_NodeID()
  System.Void set_NodeID(System.Int32 value)
  System.Collections.Generic.List<System.Int32> get_RootParameters()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterModifier> get_ParameterModifiers()
  System.Boolean get_RequiresRegeneration()
  System.Void set_RequiresRegeneration(System.Boolean value)
  System.Byte[] GetPresetData()
  System.Void SetPresetData(System.Byte[] data)
  System.Byte[] GetDefaultPresetData()
  System.Boolean get_RecacheUI()
  System.Void set_RecacheUI(System.Boolean value)
  System.Boolean AreParametersValid()
  HoudiniEngineUnity.HEU_SessionBase GetSession()
  System.Void Recook()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterData> GetParameters()
  HoudiniEngineUnity.HEU_ParameterData GetParameter(System.Int32 listIndex)
  HoudiniEngineUnity.HEU_ParameterData GetParameter(System.String name)
  HoudiniEngineUnity.HEU_ParameterData GetParameterWithParmID(System.Int32 parmID)
  System.Void RemoveParameter(System.Int32 listIndex)
  System.Boolean HaveParametersChanged()
  System.Boolean ResetAllToDefault(System.Boolean bRecookAsset)
  System.Boolean SetFloatParameterValue(System.String parameterName, System.Single value, System.Int32 atIndex, System.Boolean bRecookAsset)
  System.Boolean GetFloatParameterValue(System.String parameterName, System.Single& value, System.Int32 atIndex)
  System.Boolean SetFloatParameterValues(System.String parameterName, System.Single[] values, System.Boolean bRecookAsset)
  System.Boolean GetFloatParameterValues(System.String parameterName, System.Single[]& values)
  System.Boolean SetColorParameterValue(System.String parameterName, UnityEngine.Color value, System.Boolean bRecookAsset)
  System.Boolean GetColorParameterValue(System.String parameterName, UnityEngine.Color& value)
  System.Boolean SetIntParameterValue(System.String parameterName, System.Int32 value, System.Int32 atIndex, System.Boolean bRecookAsset)
  System.Boolean GetIntParameterValue(System.String parameterName, System.Int32& value, System.Int32 atIndex)
  System.Boolean SetIntParameterValues(System.String parameterName, System.Int32[] values, System.Boolean bRecookAsset)
  System.Boolean GetIntParameterValues(System.String parameterName, System.Int32[]& values)
  System.Boolean SetChoiceParameterValue(System.String parameterName, System.Int32 value, System.Boolean bRecookAsset)
  System.Boolean GetChoiceParameterValue(System.String parameterName, System.Int32& value)
  System.Boolean SetBoolParameterValue(System.String parameterName, System.Boolean value, System.Int32 atIndex, System.Boolean bRecookAsset)
  System.Boolean GetBoolParameterValue(System.String parameterName, System.Boolean& value, System.Int32 atIndex)
  System.Boolean SetStringParameterValue(System.String parameterName, System.String value, System.Int32 atIndex, System.Boolean bRecookAsset)
  System.Boolean GetStringParameterValue(System.String parameterName, System.String& value, System.Int32 atIndex)
  System.Boolean SetStringParameterValues(System.String parameterName, System.String[] values, System.Boolean bRecookAsset)
  System.Boolean GetStringParameterValues(System.String parameterName, System.String[]& values)
  System.Boolean SetAssetRefParameterValue(System.String parameterName, UnityEngine.GameObject value, System.Int32 atIndex, System.Boolean bRecookAsset)
  System.Boolean SetAssetRefParameterValues(System.String parameterName, UnityEngine.GameObject[] values, System.Boolean bRecookAsset)
  System.Boolean GetAssetRefParameterValue(System.String parameterName, UnityEngine.GameObject& value, System.Int32 atIndex)
  System.Boolean GetAssetRefParameterValues(System.String parameterName, UnityEngine.GameObject[]& values)
  System.Boolean SetRampParameterNumPoints(System.String parameterName, System.Int32 numPoints, System.Boolean bRecookAsset)
  System.Boolean GetRampParameterNumPoints(System.String parameterName, System.Int32& numPoints)
  System.Boolean SetFloatRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single pointPosition, System.Single pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolationType, System.Boolean bRecookAsset)
  System.Boolean GetFloatRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single& pointPosition, System.Single& pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper& interpolationType)
  System.Boolean SetFloatRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_FloatRampPointWrapper[] rampPoints, System.Boolean bRecookAsset)
  System.Boolean GetFloatRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_FloatRampPointWrapper[]& rampPoints)
  System.Boolean SetColorRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single pointPosition, UnityEngine.Color pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolationType, System.Boolean bRecookAsset)
  System.Boolean GetColorRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single& pointPosition, UnityEngine.Color& pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper& interpolationType)
  System.Boolean SetColorRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_ColorRampPointWrapper[] rampPoints, System.Boolean bRecookAsset)
  System.Boolean GetColorRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_ColorRampPointWrapper[]& rampPoints)
  System.Boolean TriggerButtonParameter(System.String parameterName)
  System.Boolean SetParameterTuples(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterTupleWrapper> parameterTuples, System.Boolean bRecook)
  System.Boolean GetParameterTuples(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterTupleWrapper>& parameterTuples)
  System.Boolean Initialize(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterData> previousParamFolders, System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_InputNode> previousParamInputNodes, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset)
  System.Boolean Initialize4HGTool(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, System.Int32 parentNodeId)
  System.Void SetupRampParameter(HoudiniEngineUnity.HEU_ParameterData rampParameter)
  System.Boolean UploadValuesToHoudini(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean bDoCheck, System.Boolean bForceUploadInputs)
  System.Void InsertInstanceToMultiParm(System.Int32 unityParamIndex, System.Int32 instanceIndex, System.Int32 numInstancesToAdd)
  System.Void RemoveInstancesFromMultiParm(System.Int32 unityParamIndex, System.Int32 instanceIndex, System.Int32 numInstancesToRemove)
  System.Void ClearInstancesFromMultiParm(System.Int32 unityParamIndex)
  System.Boolean HasModifiersPending()
  System.Void ProcessModifiers(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void GetParameterDataForUIRestore(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterData> folderParams, System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_InputNode> inputNodeParams)
  System.Void GetInputNodeConnectionObjects(System.Collections.Generic.List<UnityEngine.GameObject> inputNodeObjects)
  System.Void DownloadPresetData(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void UploadPresetData(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void DownloadAsDefaultPresetData(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void UploadParameterInputs(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Boolean bForceUpdate)
  System.Void UpdateTransformParameters(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_TransformEuler& HAPITransform)
  System.Void SyncParameterFromHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.String parameterName)
  System.Void SyncInternalParametersForUndoCompare(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void CleanUp()
  System.Void ResetAllToDefault(HoudiniEngineUnity.HEU_SessionBase session)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_Parameters other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ParameterUtility
TYPE:  class
TOKEN: 0x20000C7
FIELDS:
METHODS:
  System.Boolean GetToggle(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Boolean& outValue)
  System.Boolean SetToggle(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Boolean setValue)
  System.Boolean GetInt(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32& outValue)
  System.Boolean SetInt(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32 setValue)
  System.Boolean GetFloat(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Single& outValue)
  System.Boolean GetFloats(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Single[]& outValues)
  System.Boolean SetFloat(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Single setValue)
  System.Boolean SetFloats(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Single[] setValues)
  System.Boolean GetString(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.String& outValue)
  System.Boolean SetString(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.String setValue)
  System.Boolean SetChoice(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32 setValue)
  System.Boolean GetChoice(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32& outValue)
  System.Boolean SetInputNode(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, UnityEngine.GameObject obj, System.Int32 index)
  System.Boolean GetInputNode(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, System.Int32 index, UnityEngine.GameObject& obj)
  System.Boolean GetColor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, UnityEngine.Color& getValue)
  System.Boolean SetColor(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.String paramName, UnityEngine.Color setValue)
  System.Int32 GetParameterIndexFromName(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName)
  System.Int32 GetParameterIndexFromNameOrTag(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName)
  System.Int32 FindTextureParamByNameOrTag(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName, System.String useTextureParmName)
  System.Boolean GetParameterFloatValue(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName, System.Single defaultValue, System.Single& returnValue)
  System.Boolean GetParameterColor3Value(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.String parameterName, UnityEngine.Color defaultValue, UnityEngine.Color& outputColor)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PDGCookedDataEvent
TYPE:  class
TOKEN: 0x20000C8
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PDGCookedEventData
TYPE:  class
TOKEN: 0x20000C9
FIELDS:
  public            System.Boolean                  CookSuccess  // 0x10
  public            HoudiniEngineUnity.HEU_TOPNodeDataTopNodeData  // 0x18
METHODS:
  System.Void .ctor(System.Boolean bSuccess, HoudiniEngineUnity.HEU_TOPNodeData bTopNodeData)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PDGAssetLink
TYPE:  class
TOKEN: 0x20000CA
EXTENDS: MonoBehaviour
FIELDS:
  private           HoudiniEngineUnity.HEU_PDGCookedDataEvent_cookedDataEvent  // 0x18
  private           System.String                   _assetPath  // 0x20
  private           UnityEngine.GameObject          _assetGO  // 0x28
  private           System.String                   _assetName  // 0x30
  private           System.Int32                    _assetID  // 0x38
  private           HoudiniEngineUnity.HEU_HoudiniAsset_heu  // 0x40
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNetworkData>_topNetworks  // 0x48
  private           System.String[]                 _topNetworkNames  // 0x50
  private           System.Int32                    _selectedTOPNetwork  // 0x58
  private           HoudiniEngineUnity.HEU_PDGAssetLink.LinkState_linkState  // 0x5C
  private           System.Boolean                  _autoCook  // 0x60
  private           System.Boolean                  _useHEngineData  // 0x61
  public            HoudiniEngineUnity.HEU_PDGAssetLink.UpdateUIDelegate_repaintUIDelegate  // 0x68
  public            HoudiniEngineUnity.HEU_WorkItemTally_workItemTally  // 0x70
  private           UnityEngine.GameObject          _loadRootGameObject  // 0x78
  private           System.String                   _outputCachePathRoot  // 0x80
  private           System.Boolean                  _bUseTOPNodeFilter  // 0x88
  private           System.Boolean                  _bUseTOPOutputFilter  // 0x89
  private           System.String                   _topNodeFilter  // 0x90
  private           System.String                   _topOutputFilter  // 0x98
  private           System.Int32                    _numLoadingResults  // 0xA0
  private           System.Int32                    _numTotalResults  // 0xA4
METHODS:
  System.Boolean get_AutoCook()
  System.Void set_AutoCook(System.Boolean value)
  System.Boolean get_UseHEngineData()
  System.Void set_UseHEngineData(System.Boolean value)
  System.Boolean get_UseTOPNodeFilter()
  System.Void set_UseTOPNodeFilter(System.Boolean value)
  System.Boolean get_UseTOPOutputFilter()
  System.Void set_UseTOPOutputFilter(System.Boolean value)
  System.String get_TopNodeFilter()
  System.Void set_TopNodeFilter(System.String value)
  System.String get_TopOutputFilter()
  System.Void set_TopOutputFilter(System.String value)
  HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset()
  System.String get_AssetPath()
  UnityEngine.GameObject get_AssetGO()
  System.String get_AssetName()
  System.Int32 get_AssetID()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNetworkData> get_TopNetworks()
  System.String[] get_TopNetworkNames()
  System.Int32 get_SelectedTOPNetwork()
  HoudiniEngineUnity.HEU_LinkStateWrapper get_PDGLinkState()
  UnityEngine.GameObject get_LoadRootGameObject()
  System.String get_OutputCachePathRoot()
  HoudiniEngineUnity.HEU_PDGCookedDataEvent get_CookedDataEvent()
  HoudiniEngineUnity.HEU_PDGAssetLink.LinkState get_AssetLinkStateInternal()
  System.Void Setup(HoudiniEngineUnity.HEU_HoudiniAsset hdaAsset)
  System.Void Reset()
  System.Void Refresh()
  System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32,HoudiniEngineUnity.HEU_TOPNodeData>> GetNonHiddenTOPNodes(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork)
  System.Void SelectTOPNetwork(System.Int32 newIndex)
  System.Void SelectTOPNode(HoudiniEngineUnity.HEU_TOPNetworkData network, System.Int32 newIndex)
  HoudiniEngineUnity.HEU_TOPNetworkData GetSelectedTOPNetwork()
  HoudiniEngineUnity.HEU_TOPNodeData GetSelectedTOPNode()
  HoudiniEngineUnity.HEU_TOPNetworkData GetTOPNetwork(System.Int32 index)
  System.Void DirtyTOPNode(HoudiniEngineUnity.HEU_TOPNodeData topNode)
  System.Void CookTOPNode(HoudiniEngineUnity.HEU_TOPNodeData topNode)
  System.Void DirtyAll()
  System.Void CookOutput()
  System.Void PauseCook()
  System.Void CancelCook()
  HoudiniEngineUnity.HEU_SessionBase GetHAPISession()
  HoudiniEngineUnity.HEU_TOPNodeData GetTOPNode(System.Int32 nodeID)
  System.String GetTOPNodeStatus(HoudiniEngineUnity.HEU_TOPNodeData topNode)
  HoudiniEngineUnity.HEU_TOPNetworkData GetTOPNetworkByName(System.String name, System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNetworkData> topNetworks)
  HoudiniEngineUnity.HEU_TOPNodeData GetTOPNodeByName(System.String name, System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNodeData> topNodes)
  System.Void Awake()
  System.Void OnBeforeSerialize()
  System.Void OnAfterDeserialize()
  System.Void HandleInitialLoad()
  System.Void OnDestroy()
  System.Void NotifyAssetCooked(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean bSuccess, System.Collections.Generic.List<UnityEngine.GameObject> generatedOutputs)
  System.Void NotifyAssetCooked(HoudiniEngineUnity.HEU_CookedEventData cookedEventData)
  System.Void NotifyAssetCooked(HoudiniEngineUnity.HEU_ReloadEventData reloadEventData)
  System.Void PopulateFromHDA()
  System.Boolean PopulateTOPNetworks()
  System.Boolean PopulateTOPNodes(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_TOPNetworkData topNetwork, System.Int32[] topNodeIDs, System.Boolean useHEngineData)
  System.Void ClearAllTOPData()
  System.Void ClearTOPNetworkWorkItemResults(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork)
  System.Void ClearTOPNodeWorkItemResults(HoudiniEngineUnity.HEU_TOPNodeData topNode)
  System.Void ClearWorkItemResultByID(HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 workItemID)
  System.Void ClearWorkItemResult(HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HEU_TOPWorkResult result)
  System.Void UpdateTOPNodeResultsVisibility(HoudiniEngineUnity.HEU_TOPNodeData topNode)
  HoudiniEngineUnity.HEU_TOPWorkResult GetWorkResultByID(HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 workItemID)
  System.Void DestroyWorkItemResultData(HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HEU_TOPWorkResult result)
  System.Void LoadResults(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HAPI_PDG_WorkItemInfo workItemInfo, HoudiniEngineUnity.HAPI_PDG_WorkItemOutputFile[] resultInfos, System.Int32 workItemID, System.Action<HoudiniEngineUnity.HEU_TOPNodeData,HoudiniEngineUnity.HEU_SyncedEventData> OnSynced)
  UnityEngine.Transform GetLoadRootTransform()
  System.Void RepaintUI()
  System.Void UpdateWorkItemTally()
  System.Void ResetTOPNetworkWorkItemTally(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork)
  System.Void OnTOPNodeFilterChanged(System.String filter)
  System.Void OnTOPOutputFilterChanged(System.String filter)
  System.Void ParseHEngineData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 topNodeID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, HoudiniEngineUnity.TOPNodeTags& nodeTags)
  System.Void SetupTopNetworkNames(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork)
  System.Void OnSyncComplete(HoudiniEngineUnity.HEU_PDGCookedEventData Data)
  HoudiniEngineUnity.HEU_LinkStateWrapper LinkState_InternalToWrapper(HoudiniEngineUnity.HEU_PDGAssetLink.LinkState linkState)
  HoudiniEngineUnity.HEU_PDGAssetLink.LinkState LinkState_WrapperToInternal(HoudiniEngineUnity.HEU_LinkStateWrapper linkState)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.TOPNodeTags
TYPE:  class
TOKEN: 0x20000CF
FIELDS:
  public            System.Boolean                  _show  // 0x10
  public            System.Boolean                  _autoload  // 0x11
  public            System.Boolean                  _showHEngineData  // 0x12
  public            System.Boolean                  _autoloadHEngineData  // 0x13
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_TOPNetworkData
TYPE:  class
TOKEN: 0x20000D0
FIELDS:
  public            System.Int32                    _nodeID  // 0x10
  public            System.String                   _nodeName  // 0x18
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNodeData>_topNodes  // 0x20
  public            System.String[]                 _topNodeNames  // 0x28
  public            System.Int32                    _selectedTOPIndex  // 0x30
  public            System.String                   _parentName  // 0x38
  public            HoudiniEngineUnity.TOPNodeTags  _tags  // 0x40
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_TOPNodeData
TYPE:  class
TOKEN: 0x20000D1
FIELDS:
  public            System.Int32                    _nodeID  // 0x10
  public            System.String                   _nodeName  // 0x18
  public            System.String                   _parentName  // 0x20
  public            UnityEngine.GameObject          _workResultParentGO  // 0x28
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPWorkResult>_workResults  // 0x30
  public            HoudiniEngineUnity.TOPNodeTags  _tags  // 0x38
  public            System.Boolean                  _showResults  // 0x40
  public            HoudiniEngineUnity.HEU_TOPNodeData.PDGState_pdgState  // 0x44
  public            HoudiniEngineUnity.HEU_WorkItemTally_workItemTally  // 0x48
METHODS:
  System.Void Reset()
  System.Boolean AreAllWorkItemsComplete()
  System.Boolean AnyWorkItemsFailed()
  System.Boolean AnyWorkItemsPending()
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_TOPWorkResult
TYPE:  class
TOKEN: 0x20000D3
FIELDS:
  public            System.Int32                    _workItemIndex  // 0x10
  public            System.Int32                    _workItemID  // 0x14
  public            System.Collections.Generic.List<UnityEngine.GameObject>_generatedGOs  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_WorkItemTally
TYPE:  class
TOKEN: 0x20000D4
FIELDS:
  public            System.Int32                    _totalWorkItems  // 0x10
  public            System.Int32                    _waitingWorkItems  // 0x14
  public            System.Int32                    _scheduledWorkItems  // 0x18
  public            System.Int32                    _cookingWorkItems  // 0x1C
  public            System.Int32                    _cookedWorkItems  // 0x20
  public            System.Int32                    _erroredWorkItems  // 0x24
METHODS:
  System.Void ZeroAll()
  System.Boolean AreAllWorkItemsComplete()
  System.Boolean AnyWorkItemsFailed()
  System.Boolean AnyWorkItemsPending()
  System.String ProgressRatio()
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PDGSession
TYPE:  class
TOKEN: 0x20000D5
FIELDS:
  private   static  HoudiniEngineUnity.HEU_PDGSession_pdgSession  // 0x0
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_PDGAssetLink>_pdgAssets  // 0x10
  public            System.Int32                    _pdgMaxProcessEvents  // 0x18
  public            HoudiniEngineUnity.HAPI_PDG_EventInfo[]_pdgQueryEvents  // 0x20
  public            System.Int32[]                  _pdgContextIDs  // 0x28
  public            System.Boolean                  _errored  // 0x30
  public            System.String                   _errorMsg  // 0x38
  public            HoudiniEngineUnity.HAPI_PDG_State_pdgState  // 0x40
  private           System.Action<HoudiniEngineUnity.HEU_PDGCookedEventData>_cookedDataEvent  // 0x48
  private           System.Boolean                  _pendingCallback  // 0x50
  private           System.Int32                    _numItemsCompleted  // 0x54
  private           System.Int32                    _totalNumItems  // 0x58
  private           System.Boolean                  _callbackSuccess  // 0x5C
  private           System.Text.StringBuilder       _pdgEventMessages  // 0x60
  private           System.String[]                 _eventMessageColorCode  // 0x68
METHODS:
  HoudiniEngineUnity.HEU_PDGSession GetPDGSession()
  System.Void .ctor()
  System.Void AddAsset(HoudiniEngineUnity.HEU_PDGAssetLink asset)
  System.Void RemoveAsset(HoudiniEngineUnity.HEU_PDGAssetLink asset)
  System.Void Update()
  System.Void CleanUp()
  System.Void UpdatePDGContext()
  System.Void ReinitializePDGContext()
  System.Void ProcessPDGEvent(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 contextID, HoudiniEngineUnity.HAPI_PDG_EventInfo& eventInfo)
  System.Void OnWorkItemLoadResults(HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HEU_SyncedEventData OnSynced)
  System.Void CheckCallback(HoudiniEngineUnity.HEU_TOPNodeData topNode)
  System.Boolean GetTOPAssetLinkAndNode(System.Int32 nodeID, HoudiniEngineUnity.HEU_PDGAssetLink& assetLink, HoudiniEngineUnity.HEU_TOPNodeData& topNode)
  System.Void SetTOPNodePDGState(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, HoudiniEngineUnity.HEU_TOPNodeData.PDGState pdgState)
  System.Void NotifyTOPNodePDGStateClear(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode)
  System.Void NotifyTOPNodeTotalWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 inc)
  System.Void NotifyTOPNodeCookedWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode)
  System.Void NotifyTOPNodeErrorWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode)
  System.Void NotifyTOPNodeWaitingWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 inc)
  System.Void NotifyTOPNodeScheduledWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 inc)
  System.Void NotifyTOPNodeCookingWorkItem(HoudiniEngineUnity.HEU_PDGAssetLink assetLink, HoudiniEngineUnity.HEU_TOPNodeData topNode, System.Int32 inc)
  System.Void ResetPDGEventInfo(HoudiniEngineUnity.HAPI_PDG_EventInfo& eventInfo)
  System.Void SetErrorState(System.String msg, System.Boolean bLogIt)
  System.Void ClearErrorState()
  HoudiniEngineUnity.HEU_SessionBase GetHAPIPDGSession(System.Boolean bCreate)
  System.Void CookTOPNetworkOutputNode(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork, System.Action<HoudiniEngineUnity.HEU_PDGCookedEventData> OnCook)
  System.Void PauseCook(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork)
  System.Void CancelCook(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork)
  System.Void ClearWorkItemResult(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 contextID, HoudiniEngineUnity.HAPI_PDG_EventInfo eventInfo, HoudiniEngineUnity.HEU_TOPNodeData topNode)
  System.Boolean DirtyTOPNode(System.Int32 nodeID)
  System.Boolean CookTOPNode(System.Int32 nodeID)
  System.Boolean DirtyAll(System.Int32 nodeID)
  System.Void AddEventMessage(System.String msg)
  System.String GetEventMessages()
  System.Void ClearEventMessages()
  System.Int32[] GetNonBypassedNetworkIds(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetId)
  System.Boolean IsPDGAsset(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetId)
  System.Void ResetCallbackVariables()
  System.Action<HoudiniEngineUnity.HEU_PDGCookedEventData> get_CookedDataEvent()
  System.Void set_CookedDataEvent(System.Action<HoudiniEngineUnity.HEU_PDGCookedEventData> value)
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_Curve
TYPE:  interface
TOKEN: 0x20000D9
FIELDS:
METHODS:
  UnityEngine.GameObject get_TargetGameObject()
  System.Void set_TargetGameObject(UnityEngine.GameObject value)
  System.Int32 get_GeoID()
  System.Int32 get_PartID()
  System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> get_CurveNodeData()
  HoudiniEngineUnity.HEU_Parameters get_Parameters()
  System.String get_CurveName()
  System.Boolean get_IsInputCurve()
  System.Boolean get_IsPartCurve()
  HoudiniEngineUnity.HEU_InputCurveInfo get_InputCurveInfo()
  System.Boolean IsEditable()
  System.Boolean IsGeoCurve()
  System.Void SetCurveName(System.String name)
  System.Void SetCurvePoint(System.Int32 pointIndex, UnityEngine.Vector3 newPosition, System.Boolean bRecookAsset)
  System.Void SetCurvePoint(System.Int32 pointIndex, HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset)
  System.Void SetCurveNodeData(System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> curveNodeData, System.Boolean bRecookAsset)
  UnityEngine.Vector3 GetCurvePoint(System.Int32 pointIndex)
  System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> GetAllPointTransforms()
  System.Collections.Generic.List<UnityEngine.Vector3> GetAllPoints()
  System.Int32 GetNumPoints()
  System.Void InsertCurvePoint(System.Int32 index, UnityEngine.Vector3 position, System.Boolean bRecookAsset)
  System.Void InsertCurvePoint(System.Int32 index, HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset)
  System.Void AddCurvePointToEnd(UnityEngine.Vector3 position, System.Boolean bRecookAsset)
  System.Void AddCurvePointToEnd(HoudiniEngineUnity.CurveNodeData curveData, System.Boolean bRecookAsset)
  System.Void RemoveCurvePoint(System.Int32 pointIndex, System.Boolean bRecookAsset)
  System.Void ClearCurveNodeData(System.Boolean bRecookAsset)
  System.Void ProjectToColliders(UnityEngine.Vector3 rayDirection, System.Single rayDistance, System.Boolean bRecookAsset)
  System.Void SetCurveGeometryVisibility(System.Boolean bVisible, System.Boolean bRecookAsset)
  UnityEngine.Vector3 GetTransformedPoint(System.Int32 pointIndex)
  System.Collections.Generic.List<UnityEngine.Vector3> GetTransformedPoints()
  System.Collections.Generic.List<HoudiniEngineUnity.CurveNodeData> DuplicateCurveNodeData()
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_GeoNode
TYPE:  interface
TOKEN: 0x20000DA
FIELDS:
METHODS:
  System.Int32 get_GeoID()
  HoudiniEngineUnity.HAPI_GeoInfo get_GeoInfo()
  System.String get_GeoName()
  HoudiniEngineUnity.HAPI_GeoType get_GeoType()
  System.Boolean get_Editable()
  System.Boolean get_Displayable()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> get_Parts()
  HoudiniEngineUnity.HEU_ObjectNode get_ObjectNode()
  HoudiniEngineUnity.HEU_InputNode get_InputNode()
  HoudiniEngineUnity.HEU_Curve get_GeoCurve()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> get_VolumeCaches()
  System.Boolean IsVisible()
  System.Boolean IsIntermediate()
  System.Boolean IsIntermediateOrEditable()
  System.Boolean IsGeoInputType()
  System.Boolean IsGeoCurveType()
  System.Void DestroyAllData(System.Boolean bIsRebuild)
  System.Void RemoveAndDestroyPart(HoudiniEngineUnity.HEU_PartData part)
  System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs)
  HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject outputGameObject)
  HoudiniEngineUnity.HEU_PartData GetPartFromPartID(System.Int32 partID)
  System.Void GetCurves(System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> curves, System.Boolean bEditableOnly)
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> GetParts()
  System.Void HideAllGeometry()
  System.Void DisableAllColliders()
  HoudiniEngineUnity.HEU_VolumeCache GetVolumeCacheByTileIndex(System.Int32 tileIndex)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetCookStatusWrapper
TYPE:  struct
TOKEN: 0x20000DB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_AssetCookStatusWrapperNONE  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetCookStatusWrapperCOOKING  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetCookStatusWrapperPOSTCOOK  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetCookStatusWrapperLOADING  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetCookStatusWrapperPOSTLOAD  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetCookStatusWrapperPRELOAD  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetCookStatusWrapperSELECT_SUBASSET  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetCookResultWrapper
TYPE:  struct
TOKEN: 0x20000DC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_AssetCookResultWrapperNONE  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetCookResultWrapperSUCCESS  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetCookResultWrapperERRORED  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper
TYPE:  struct
TOKEN: 0x20000DD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_CurveDrawCollisionWrapperINVALID  // 0x0
  public    static  HoudiniEngineUnity.HEU_CurveDrawCollisionWrapperCOLLIDERS  // 0x0
  public    static  HoudiniEngineUnity.HEU_CurveDrawCollisionWrapperLAYERMASK  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetTypeWrapper
TYPE:  struct
TOKEN: 0x20000DE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_AssetTypeWrapperTYPE_INVALID  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetTypeWrapperTYPE_HDA  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetTypeWrapperTYPE_CURVE  // 0x0
  public    static  HoudiniEngineUnity.HEU_AssetTypeWrapperTYPE_INPUT  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_HoudiniAsset
TYPE:  interface
TOKEN: 0x20000DF
FIELDS:
METHODS:
  System.Boolean get_LoadAssetFromMemory()
  System.Void set_LoadAssetFromMemory(System.Boolean value)
  System.Boolean get_AlwaysOverwriteOnLoad()
  System.Void set_AlwaysOverwriteOnLoad(System.Boolean value)
  System.Boolean get_GenerateUVs()
  System.Void set_GenerateUVs(System.Boolean value)
  System.Boolean get_GenerateTangents()
  System.Void set_GenerateTangents(System.Boolean value)
  System.Boolean get_GenerateNormals()
  System.Void set_GenerateNormals(System.Boolean value)
  System.Boolean get_PushTransformToHoudini()
  System.Void set_PushTransformToHoudini(System.Boolean value)
  System.Boolean get_TransformChangeTriggersCooks()
  System.Void set_TransformChangeTriggersCooks(System.Boolean value)
  System.Boolean get_CookingTriggersDownCooks()
  System.Void set_CookingTriggersDownCooks(System.Boolean value)
  System.Boolean get_AutoCookOnParameterChange()
  System.Void set_AutoCookOnParameterChange(System.Boolean value)
  System.Boolean get_IgnoreNonDisplayNodes()
  System.Void set_IgnoreNonDisplayNodes(System.Boolean value)
  System.Boolean get_UseOutputNodes()
  System.Void set_UseOutputNodes(System.Boolean value)
  System.Boolean get_GenerateMeshUsingPoints()
  System.Void set_GenerateMeshUsingPoints(System.Boolean value)
  System.Boolean get_UseLODGroups()
  System.Void set_UseLODGroups(System.Boolean value)
  System.Boolean get_SplitGeosByGroup()
  System.Void set_SplitGeosByGroup(System.Boolean value)
  System.Boolean get_SessionSyncAutoCook()
  System.Void set_SessionSyncAutoCook(System.Boolean value)
  System.Boolean get_BakeUpdateKeepPreviousTransformValues()
  System.Void set_BakeUpdateKeepPreviousTransformValues(System.Boolean value)
  System.Boolean get_PauseCooking()
  System.Void set_PauseCooking(System.Boolean value)
  System.Boolean get_CurveEditorEnabled()
  System.Void set_CurveEditorEnabled(System.Boolean value)
  HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper get_CurveDrawCollision()
  System.Void set_CurveDrawCollision(HoudiniEngineUnity.HEU_CurveDrawCollisionWrapper value)
  UnityEngine.LayerMask get_CurveDrawLayerMask()
  System.Void set_CurveDrawLayerMask(UnityEngine.LayerMask value)
  System.Single get_CurveProjectMaxDistance()
  System.Void set_CurveProjectMaxDistance(System.Single value)
  UnityEngine.Vector3 get_CurveProjectDirection()
  System.Void set_CurveProjectDirection(UnityEngine.Vector3 value)
  System.Boolean get_CurveProjectDirectionToView()
  System.Void set_CurveProjectDirectionToView(System.Boolean value)
  System.Boolean get_CurveDisableScaleRotation()
  System.Void set_CurveDisableScaleRotation(System.Boolean value)
  System.Boolean get_CurveFrameSelectedNodes()
  System.Void set_CurveFrameSelectedNodes(System.Boolean value)
  System.Single get_CurveFrameSelectedNodeDistance()
  System.Void set_CurveFrameSelectedNodeDistance(System.Single value)
  System.Boolean get_HandlesEnabled()
  System.Void set_HandlesEnabled(System.Boolean value)
  System.Boolean get_EditableNodesToolsEnabled()
  System.Void set_EditableNodesToolsEnabled(System.Boolean value)
  HoudiniEngineUnity.HEU_AssetTypeWrapper get_AssetType()
  HoudiniEngineUnity.HAPI_AssetInfo get_AssetInfo()
  HoudiniEngineUnity.HAPI_NodeInfo get_NodeInfo()
  System.String get_AssetName()
  System.String get_AssetOpName()
  System.String get_AssetHelp()
  System.Int32 get_AssetID()
  System.String get_AssetPath()
  UnityEngine.GameObject get_OwnerGameObject()
  UnityEngine.GameObject get_RootGameObject()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> get_MaterialCache()
  HoudiniEngineUnity.HEU_Parameters get_Parameters()
  System.String get_AssetCacheFolder()
  System.String[] get_SubassetNames()
  System.Int32 get_SelectedSubassetIndex()
  HoudiniEngineUnity.HEU_AssetCookStatusWrapper get_CookStatus()
  HoudiniEngineUnity.HEU_AssetCookResultWrapper get_LastCookResult()
  System.Int64 get_SessionID()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> get_Curves()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> get_InputNodes()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> get_VolumeCaches()
  HoudiniEngineUnity.HEU_ReloadDataEvent get_ReloadDataEvent()
  HoudiniEngineUnity.HEU_CookedDataEvent get_CookedDataEvent()
  HoudiniEngineUnity.HEU_BakedDataEvent get_BakedDataEvent()
  HoudiniEngineUnity.HEU_PreAssetEvent get_PreAssetEvent()
  System.Boolean RequestCook(System.Boolean bCheckParametersChanged, System.Boolean bAsync, System.Boolean bSkipCookCheck, System.Boolean bUploadParameters)
  System.Boolean RequestReload(System.Boolean bAsync)
  System.Boolean RequestResetParameters(System.Boolean bAsync)
  UnityEngine.GameObject DuplicateAsset(UnityEngine.GameObject newRootGameObject)
  System.Boolean DeleteAllGeneratedData(System.Boolean bIsRebuild)
  UnityEngine.GameObject BakeToNewPrefab(System.String destinationPrefabPath)
  UnityEngine.GameObject BakeToNewStandalone()
  System.Boolean BakeToExistingPrefab(UnityEngine.GameObject bakeTargetGO)
  System.Boolean BakeToExistingStandalone(UnityEngine.GameObject bakeTargetGO)
  System.Boolean IsAssetValid()
  System.Boolean GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  System.Boolean GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs)
  HoudiniEngineUnity.HEU_Curve GetCurve(System.String curveName)
  System.Boolean AddCurveDrawCollider(UnityEngine.Collider newCollider)
  System.Boolean RemoveCurveDrawCollider(UnityEngine.Collider collider)
  System.Boolean ClearCurveDrawColliders()
  HoudiniEngineUnity.HEU_InputNode GetInputNode(System.String inputName)
  HoudiniEngineUnity.HEU_InputNode GetAssetInputNode(System.String inputName)
  HoudiniEngineUnity.HEU_InputNode GetInputNodeByIndex(System.Int32 index)
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputNode> GetNonParameterInputNodes()
  System.Int32 GetVolumeCacheCount()
  HoudiniEngineUnity.HEU_SessionBase GetAssetSession(System.Boolean bCreateIfInvalid)
  HoudiniEngineUnity.HEU_ObjectNode GetObjectNodeByName(System.String objName)
  System.Void GetOutputGeoNodes(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> outputGeoNodes)
  HoudiniEngineUnity.HEU_PartData GetInternalHDAPartWithGameObject(UnityEngine.GameObject outputGameObject)
  System.Void ResetParametersToDefault()
  System.Void HideAllGeometry()
  System.Void DisableAllColliders()
  HoudiniEngineUnity.HEU_MaterialData GetMaterialData(UnityEngine.Material material)
  System.Void ClearMaterialCache()
  System.Void RemoveMaterial(UnityEngine.Material material)
  System.Void ResetMaterialOverrides()
  HoudiniEngineUnity.HEU_AssetPreset GetAssetPreset()
  HoudiniEngineUnity.HEU_PDGAssetLink GetOrCreatePDGAssetLink()
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_HoudiniAssetSubcomponent
TYPE:  interface
TOKEN: 0x20000E0
FIELDS:
METHODS:
  HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset()
  HoudiniEngineUnity.HEU_SessionBase GetSession()
  System.Void Recook()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputNodeTypeWrapper
TYPE:  struct
TOKEN: 0x20000E1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_InputNodeTypeWrapperCONNECTION  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputNodeTypeWrapperNODE  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputNodeTypeWrapperPARAMETER  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputObjectTypeWrapper
TYPE:  struct
TOKEN: 0x20000E2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_InputObjectTypeWrapperHDA  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputObjectTypeWrapperUNITY_MESH  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputObjectTypeWrapperCURVE  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputObjectTypeWrapperTERRAIN  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputObjectTypeWrapperBOUNDING_BOX  // 0x0
  public    static  HoudiniEngineUnity.HEU_InputObjectTypeWrapperTILEMAP  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_InputNode
TYPE:  interface
TOKEN: 0x20000E3
FIELDS:
METHODS:
  System.Boolean get_KeepWorldTransform()
  System.Void set_KeepWorldTransform(System.Boolean value)
  System.Boolean get_PackGeometryBeforeMerging()
  System.Void set_PackGeometryBeforeMerging(System.Boolean value)
  HoudiniEngineUnity.HEU_InputNodeTypeWrapper get_NodeType()
  HoudiniEngineUnity.HEU_InputObjectTypeWrapper get_ObjectType()
  HoudiniEngineUnity.HEU_InputObjectTypeWrapper get_PendingObjectType()
  System.Int32 get_InputNodeID()
  System.String get_InputName()
  System.String get_LabelName()
  System.String get_ParamName()
  HoudiniEngineUnity.HEU_InputInterfaceMeshSettings get_MeshSettings()
  HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings get_TilemapSettings()
  System.Boolean IsAssetInput()
  System.Int32 NumInputEntries()
  UnityEngine.GameObject GetInputEntryGameObject(System.Int32 index)
  UnityEngine.GameObject[] GetInputEntryGameObjects()
  System.Void SetInputEntry(System.Int32 index, UnityEngine.GameObject newInputGameObject, System.Boolean bRecookAsset)
  System.Void InsertInputEntry(System.Int32 index, UnityEngine.GameObject newInputGameObject, System.Boolean bRecookAsset)
  System.Void AddInputEntryAtEnd(UnityEngine.GameObject newEntryGameObject, System.Boolean bRecookAsset)
  System.Void ResetInputNode(System.Boolean bRecookAsset)
  System.Void ChangeInputType(HoudiniEngineUnity.HEU_InputObjectTypeWrapper newType, System.Boolean bRecookAsset)
  System.Void RemoveInputEntry(System.Int32 index, System.Boolean bRecookAsset)
  System.Void RemoveAllInputEntries(System.Boolean bRecookAsset)
  System.Void SetInputEntryObjectUseTransformOffset(System.Int32 index, System.Boolean value, System.Boolean bRecookAsset)
  System.Void SetInputEntryObjectTransformTranslateOffset(System.Int32 index, UnityEngine.Vector3 translateOffset, System.Boolean bRecookAsset)
  System.Void SetInputEntryObjectTransformRotateOffset(System.Int32 index, UnityEngine.Vector3 rotateOffset, System.Boolean bRecookAsset)
  System.Void SetInputEntryObjectTransformScaleOffset(System.Int32 index, UnityEngine.Vector3 scaleOffset, System.Boolean bRecookAsset)
  System.Boolean AreAnyInputHDAsConnected()
  System.Int32 GetConnectedInputCount()
  System.Int32 GetConnectedNodeID(System.Int32 index)
  System.Void LoadPreset(HoudiniEngineUnity.HEU_InputPreset inputPreset)
  System.Void PopulateInputPreset(HoudiniEngineUnity.HEU_InputPreset inputPreset)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_MaterialSourceWrapper
TYPE:  struct
TOKEN: 0x20000E4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_MaterialSourceWrapperDEFAULT  // 0x0
  public    static  HoudiniEngineUnity.HEU_MaterialSourceWrapperHOUDINI  // 0x0
  public    static  HoudiniEngineUnity.HEU_MaterialSourceWrapperUNITY  // 0x0
  public    static  HoudiniEngineUnity.HEU_MaterialSourceWrapperSUBSTANCE  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_MaterialData
TYPE:  interface
TOKEN: 0x20000E5
FIELDS:
METHODS:
  UnityEngine.Material get_Material()
  HoudiniEngineUnity.HEU_MaterialSourceWrapper get_MaterialSource()
  System.Int32 get_MaterialKey()
  System.Void set_MaterialKey(System.Int32 value)
  System.Boolean UpdateMaterialFromHoudini(HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String assetCacheFolderPath)
  System.Boolean IsExistingMaterial()
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_ObjectNode
TYPE:  interface
TOKEN: 0x20000E6
FIELDS:
METHODS:
  System.Int32 get_ObjectID()
  System.String get_ObjectName()
  HoudiniEngineUnity.HAPI_ObjectInfo get_ObjectInfo()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> get_GeoNodes()
  HoudiniEngineUnity.HAPI_Transform get_ObjectTransform()
  System.Boolean IsInstanced()
  System.Boolean IsVisible()
  System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData)
  System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs)
  HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject outputGameObject)
  HoudiniEngineUnity.HEU_GeoNode GetGeoNode(System.String geoName)
  System.Void GetCurves(System.Collections.Generic.List<HoudiniEngineUnity.HEU_Curve> curves, System.Boolean bEditableOnly)
  System.Void GetOutputGeoNodes(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoNode> outGeoNodes)
  System.Void HideAllGeometry()
  System.Void DisableAllColliders()
  System.Boolean IsInstancer()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper
TYPE:  struct
TOKEN: 0x20000E7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapperCONSTANT  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapperLINEAR  // 0x0
  public    static  HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapperCATMULL_ROM  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_RampPointWrapper
TYPE:  class
TOKEN: 0x20000E8
FIELDS:
  private           System.Single                   <Position>k__BackingField  // 0x10
  private           HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper<Interpolation>k__BackingField  // 0x14
METHODS:
  System.Single get_Position()
  System.Void set_Position(System.Single value)
  HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper get_Interpolation()
  System.Void set_Interpolation(HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper value)
  System.Void .ctor(System.Single position, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolation)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_FloatRampPointWrapper
TYPE:  class
TOKEN: 0x20000E9
EXTENDS: HEU_RampPointWrapper
FIELDS:
  private           System.Single                   <Value>k__BackingField  // 0x18
METHODS:
  System.Single get_Value()
  System.Void set_Value(System.Single value)
  System.Void .ctor(System.Single position, System.Single value, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolation)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ColorRampPointWrapper
TYPE:  class
TOKEN: 0x20000EA
EXTENDS: HEU_RampPointWrapper
FIELDS:
  private           UnityEngine.Color               <Value>k__BackingField  // 0x18
METHODS:
  UnityEngine.Color get_Value()
  System.Void set_Value(UnityEngine.Color value)
  System.Void .ctor(System.Single position, UnityEngine.Color value, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolation)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ParameterTupleWrapper
TYPE:  class
TOKEN: 0x20000EB
FIELDS:
  private           System.Boolean[]                _boolValues  // 0x10
  private           System.Int32[]                  _intValues  // 0x18
  private           System.Single[]                 _floatValues  // 0x20
  private           System.String[]                 _stringValues  // 0x28
  private           HoudiniEngineUnity.HEU_FloatRampPointWrapper[]_floatRampValues  // 0x30
  private           HoudiniEngineUnity.HEU_ColorRampPointWrapper[]_colorRampValues  // 0x38
METHODS:
  System.Boolean[] get_BoolValues()
  System.Void set_BoolValues(System.Boolean[] value)
  System.Int32[] get_IntValues()
  System.Void set_IntValues(System.Int32[] value)
  System.Single[] get_FloatValues()
  System.Void set_FloatValues(System.Single[] value)
  System.String[] get_StringValues()
  System.Void set_StringValues(System.String[] value)
  HoudiniEngineUnity.HEU_FloatRampPointWrapper[] get_FloatRampValues()
  System.Void set_FloatRampValues(HoudiniEngineUnity.HEU_FloatRampPointWrapper[] value)
  HoudiniEngineUnity.HEU_ColorRampPointWrapper[] get_ColorRampValues()
  System.Void set_ColorRampValues(HoudiniEngineUnity.HEU_ColorRampPointWrapper[] value)
  System.Void .ctor()
  System.Void .ctor(System.Boolean[] boolValues)
  System.Void .ctor(System.Int32[] intValues)
  System.Void .ctor(System.Single[] floatValues)
  System.Void .ctor(System.String[] stringValues)
  System.Void .ctor(HoudiniEngineUnity.HEU_FloatRampPointWrapper[] floatRampValues)
  System.Void .ctor(HoudiniEngineUnity.HEU_ColorRampPointWrapper[] colorRampValues)
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_Parameters
TYPE:  interface
TOKEN: 0x20000EC
FIELDS:
METHODS:
  System.Boolean get_ShowParameters()
  System.Void set_ShowParameters(System.Boolean value)
  System.Int32 get_NodeID()
  System.Collections.Generic.List<System.Int32> get_RootParameters()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterModifier> get_ParameterModifiers()
  System.Boolean AreParametersValid()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_ParameterData> GetParameters()
  HoudiniEngineUnity.HEU_ParameterData GetParameter(System.Int32 listIndex)
  HoudiniEngineUnity.HEU_ParameterData GetParameter(System.String name)
  HoudiniEngineUnity.HEU_ParameterData GetParameterWithParmID(System.Int32 parmID)
  System.Void RemoveParameter(System.Int32 listIndex)
  System.Boolean HaveParametersChanged()
  System.Boolean ResetAllToDefault(System.Boolean bRecookAsset)
  System.Boolean SetFloatParameterValue(System.String parameterName, System.Single value, System.Int32 atIndex, System.Boolean bRecookAsset)
  System.Boolean GetFloatParameterValue(System.String parameterName, System.Single& value, System.Int32 atIndex)
  System.Boolean SetFloatParameterValues(System.String parameterName, System.Single[] values, System.Boolean bRecookAsset)
  System.Boolean GetFloatParameterValues(System.String parameterName, System.Single[]& values)
  System.Boolean SetColorParameterValue(System.String parameterName, UnityEngine.Color value, System.Boolean bRecookAsset)
  System.Boolean GetColorParameterValue(System.String parameterName, UnityEngine.Color& value)
  System.Boolean SetIntParameterValue(System.String parameterName, System.Int32 value, System.Int32 atIndex, System.Boolean bRecookAsset)
  System.Boolean GetIntParameterValue(System.String parameterName, System.Int32& value, System.Int32 atIndex)
  System.Boolean SetIntParameterValues(System.String parameterName, System.Int32[] values, System.Boolean bRecookAsset)
  System.Boolean GetIntParameterValues(System.String parameterName, System.Int32[]& values)
  System.Boolean SetChoiceParameterValue(System.String parameterName, System.Int32 value, System.Boolean bRecookAsset)
  System.Boolean GetChoiceParameterValue(System.String parameterName, System.Int32& value)
  System.Boolean SetBoolParameterValue(System.String parameterName, System.Boolean value, System.Int32 atIndex, System.Boolean bRecookAsset)
  System.Boolean GetBoolParameterValue(System.String parameterName, System.Boolean& value, System.Int32 atIndex)
  System.Boolean SetStringParameterValue(System.String parameterName, System.String value, System.Int32 atIndex, System.Boolean bRecookAsset)
  System.Boolean GetStringParameterValue(System.String parameterName, System.String& value, System.Int32 atIndex)
  System.Boolean SetStringParameterValues(System.String parameterName, System.String[] values, System.Boolean bRecookAsset)
  System.Boolean GetStringParameterValues(System.String parameterName, System.String[]& values)
  System.Boolean SetAssetRefParameterValue(System.String parameterName, UnityEngine.GameObject value, System.Int32 atIndex, System.Boolean bRecookAsset)
  System.Boolean GetAssetRefParameterValue(System.String parameterName, UnityEngine.GameObject& value, System.Int32 atIndex)
  System.Boolean SetAssetRefParameterValues(System.String parameterName, UnityEngine.GameObject[] values, System.Boolean bRecookAsset)
  System.Boolean GetAssetRefParameterValues(System.String parameterName, UnityEngine.GameObject[]& values)
  System.Boolean SetRampParameterNumPoints(System.String parameterName, System.Int32 numPoints, System.Boolean bRecookAsset)
  System.Boolean GetRampParameterNumPoints(System.String parameterName, System.Int32& numPoints)
  System.Boolean SetFloatRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single pointPosition, System.Single pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolationType, System.Boolean bRecookAsset)
  System.Boolean GetFloatRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single& pointPosition, System.Single& pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper& interpolationType)
  System.Boolean SetFloatRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_FloatRampPointWrapper[] rampPoints, System.Boolean bRecookAsset)
  System.Boolean GetFloatRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_FloatRampPointWrapper[]& rampPoints)
  System.Boolean SetColorRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single pointPosition, UnityEngine.Color pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper interpolation, System.Boolean bRecookAsset)
  System.Boolean GetColorRampParameterPointValue(System.String parameterName, System.Int32 pointIndex, System.Single& pointPosition, UnityEngine.Color& pointValue, HoudiniEngineUnity.HEU_HoudiniRampInterpolationTypeWrapper& interpolationType)
  System.Boolean SetColorRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_ColorRampPointWrapper[] rampPoints, System.Boolean bRecookAsset)
  System.Boolean GetColorRampParameterPoints(System.String parameterName, HoudiniEngineUnity.HEU_ColorRampPointWrapper[]& rampPoints)
  System.Boolean TriggerButtonParameter(System.String parameterName)
  System.Boolean SetParameterTuples(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterTupleWrapper> parameterTuples, System.Boolean bRecookAsset)
  System.Boolean GetParameterTuples(System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.HEU_ParameterTupleWrapper>& parameterTuples)
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_PartData
TYPE:  interface
TOKEN: 0x20000ED
FIELDS:
METHODS:
  System.Int32 get_PartID()
  System.String get_PartName()
  System.Int32 get_GeoID()
  HoudiniEngineUnity.HAPI_PartType get_PartType()
  HoudiniEngineUnity.HEU_GeoNode get_ParentGeoNode()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_ObjectInstanceInfo> get_ObjectInstanceInfos()
  HoudiniEngineUnity.HEU_Curve get_Curve()
  System.Int32 get_MeshVertexCount()
  HoudiniEngineUnity.HEU_GeneratedOutput get_GeneratedOutput()
  UnityEngine.GameObject get_OutputGameObject()
  System.Boolean IsPartInstancer()
  System.Boolean IsAttribInstancer()
  System.Boolean IsInstancerAnyType()
  System.Boolean IsPartInstanced()
  System.Int32 GetPartPointCount()
  System.Boolean IsObjectInstancer()
  System.Boolean IsPartVolume()
  System.Boolean IsPartCurve()
  System.Boolean IsPartMesh()
  System.Boolean IsPartEditable()
  System.Boolean HaveInstancesBeenGenerated()
  System.Void SetGameObjectName(System.String partName)
  System.Void SetGameObject(UnityEngine.GameObject gameObject)
  System.Void SetVolumeLayerName(System.String name)
  System.String GetVolumeLayerName()
  System.Void DestroyAllData(System.Boolean bIsRebuild)
  System.Boolean IsUsingMaterial(HoudiniEngineUnity.HEU_MaterialData materialData)
  System.Void GetOutputGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> outputObjects)
  System.Void GetOutput(System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput> outputs)
  HoudiniEngineUnity.HEU_PartData GetHDAPartWithGameObject(UnityEngine.GameObject inGameObject)
  System.Void ClearInstances()
  HoudiniEngineUnity.HEU_Curve GetCurve(System.Boolean bEditableOnly)
  System.Void SetVisiblity(System.Boolean bVisibility)
  System.Void SetColliderState(System.Boolean bEnabled)
  HoudiniEngineUnity.HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectPath(System.String path)
  HoudiniEngineUnity.HEU_ObjectInstanceInfo GetObjectInstanceInfoWithObjectID(System.Int32 objNodeID)
  System.Void SetTerrainOffsetPosition(UnityEngine.Vector3 offsetPosition)
  System.Void SetTerrainData(UnityEngine.TerrainData terrainData, System.String exportPathRelative, System.String exportPathUser)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_LinkStateWrapper
TYPE:  struct
TOKEN: 0x20000EE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_LinkStateWrapperINACTIVE  // 0x0
  public    static  HoudiniEngineUnity.HEU_LinkStateWrapperLINKING  // 0x0
  public    static  HoudiniEngineUnity.HEU_LinkStateWrapperLINKED  // 0x0
  public    static  HoudiniEngineUnity.HEU_LinkStateWrapperERROR_NOT_LINKED  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_PDGAssetLink
TYPE:  interface
TOKEN: 0x20000EF
FIELDS:
METHODS:
  System.Boolean get_AutoCook()
  System.Void set_AutoCook(System.Boolean value)
  System.Boolean get_UseHEngineData()
  System.Void set_UseHEngineData(System.Boolean value)
  System.Boolean get_UseTOPNodeFilter()
  System.Void set_UseTOPNodeFilter(System.Boolean value)
  System.Boolean get_UseTOPOutputFilter()
  System.Void set_UseTOPOutputFilter(System.Boolean value)
  System.String get_TopNodeFilter()
  System.Void set_TopNodeFilter(System.String value)
  System.String get_TopOutputFilter()
  System.Void set_TopOutputFilter(System.String value)
  HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset()
  System.String get_AssetPath()
  UnityEngine.GameObject get_AssetGO()
  System.String get_AssetName()
  System.Int32 get_AssetID()
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_TOPNetworkData> get_TopNetworks()
  System.String[] get_TopNetworkNames()
  System.Int32 get_SelectedTOPNetwork()
  HoudiniEngineUnity.HEU_LinkStateWrapper get_PDGLinkState()
  UnityEngine.GameObject get_LoadRootGameObject()
  System.String get_OutputCachePathRoot()
  System.Void Setup(HoudiniEngineUnity.HEU_HoudiniAsset hdaAsset)
  System.Void Reset()
  System.Void Refresh()
  System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32,HoudiniEngineUnity.HEU_TOPNodeData>> GetNonHiddenTOPNodes(HoudiniEngineUnity.HEU_TOPNetworkData topNetwork)
  System.Void SelectTOPNetwork(System.Int32 newIndex)
  System.Void SelectTOPNode(HoudiniEngineUnity.HEU_TOPNetworkData network, System.Int32 newIndex)
  HoudiniEngineUnity.HEU_TOPNetworkData GetSelectedTOPNetwork()
  HoudiniEngineUnity.HEU_TOPNodeData GetSelectedTOPNode()
  HoudiniEngineUnity.HEU_TOPNetworkData GetTOPNetwork(System.Int32 index)
  System.Void DirtyTOPNode(HoudiniEngineUnity.HEU_TOPNodeData topNode)
  System.Void CookTOPNode(HoudiniEngineUnity.HEU_TOPNodeData topNode)
  System.Void DirtyAll()
  System.Void CookOutput()
  System.Void PauseCook()
  System.Void CancelCook()
  HoudiniEngineUnity.HEU_SessionBase GetHAPISession()
  HoudiniEngineUnity.HEU_TOPNodeData GetTOPNode(System.Int32 nodeID)
  System.String GetTOPNodeStatus(HoudiniEngineUnity.HEU_TOPNodeData topNode)
END_CLASS

CLASS: HoudiniEngineUnity.IHEU_VolumeCache
TYPE:  interface
TOKEN: 0x20000F0
FIELDS:
METHODS:
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayer> get_Layers()
  System.Int32 get_TileIndex()
  System.String get_ObjectName()
  System.String get_GeoName()
  UnityEngine.TerrainData get_TerrainData()
  HoudiniEngineUnity.HEU_VolumeScatterTrees get_ScatterTrees()
  HoudiniEngineUnity.HEU_DetailProperties get_DetailProperties()
  System.Void ResetParameters()
  HoudiniEngineUnity.HEU_VolumeLayer GetLayer(System.String layerName)
  System.Void PopulatePreset(HoudiniEngineUnity.HEU_VolumeCachePreset cachePreset)
  System.Boolean ApplyPreset(HoudiniEngineUnity.HEU_VolumeCachePreset volumeCachePreset)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_MaterialData
TYPE:  class
TOKEN: 0x20000F1
EXTENDS: ScriptableObject
FIELDS:
  private           UnityEngine.Material            _material  // 0x18
  private           HoudiniEngineUnity.HEU_MaterialData.Source_materialSource  // 0x20
  private           System.Int32                    _materialKey  // 0x24
METHODS:
  UnityEngine.Material get_Material()
  HoudiniEngineUnity.HEU_MaterialSourceWrapper get_MaterialSource()
  System.Int32 get_MaterialKey()
  System.Void set_MaterialKey(System.Int32 value)
  System.Boolean UpdateMaterialFromHoudini(HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String assetCacheFolderPath)
  System.Boolean IsExistingMaterial()
  System.Boolean UseLegacyShaders(HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String assetCacheFolderPath, HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_NodeInfo nodeInfo, HoudiniEngineUnity.HAPI_ParmInfo[] parmInfos)
  System.String GetTextureFileNameFromMaterialParam(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo parmInfo)
  System.Boolean IsTransparentMaterial(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters)
  System.Boolean GetMaterialAlpha(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parameters, System.Single defaultValue, System.Single& alpha)
  System.String GetSupportedFileFormat(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ImageInfo& imageInfo)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_MaterialData other)
  HoudiniEngineUnity.HEU_MaterialData.Source MaterialSource_WrapperToInternal(HoudiniEngineUnity.HEU_MaterialSourceWrapper materialSource)
  HoudiniEngineUnity.HEU_MaterialSourceWrapper MaterialSource_WrapperToInternal(HoudiniEngineUnity.HEU_MaterialData.Source materialSource)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_MaterialFactory
TYPE:  class
TOKEN: 0x20000F3
FIELDS:
  public    static  UnityEngine.Material            _defaultStandardMaterial  // 0x0
METHODS:
  UnityEngine.Shader FindShader(System.String shaderName)
  UnityEngine.Shader FindPluginShader(System.String shaderName)
  UnityEngine.Material GetNewMaterialWithShader(System.String assetCacheFolderPath, System.String shaderName, System.String materialName, System.Boolean bWriteToFile)
  UnityEngine.Material CreateNewHoudiniStandardMaterial(System.String assetCacheFolderPath, System.String materialName, System.Boolean bWriteToFile)
  System.Void WriteMaterialToAssetCache(UnityEngine.Material material, System.String assetCacheFolderPath, System.String materialName, System.Boolean bOverwriteExisting)
  System.Boolean DoesMaterialExistInAssetCache(UnityEngine.Material material)
  System.Void DestroyNonAssetMaterial(UnityEngine.Material material, System.Boolean bRegisterUndo)
  System.Void DeleteAssetMaterial(UnityEngine.Material material)
  UnityEngine.Texture2D RenderAndExtractImageToTexture(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.Int32 textureParmID, System.String textureName, System.String assetCacheFolderPath, System.Boolean isNormalMap, System.Boolean invertTexture)
  UnityEngine.Texture2D ExtractHoudiniImageToTexturePNGJPEG(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String imagePlanes)
  UnityEngine.Texture2D ExtractHoudiniImageToTextureRaw(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String imagePlanes)
  UnityEngine.Texture2D ExtractHoudiniImageToTextureFile(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_MaterialInfo materialInfo, System.String imagePlanes, System.String assetCacheFolderPath)
  UnityEngine.Material LoadUnityMaterial(System.String materialPath)
  UnityEngine.Material LoadSubstanceMaterialWithName(System.String materialPath, System.String substanceName)
  UnityEngine.Material LoadSubstanceMaterialWithIndex(System.String materialPath, System.Int32 substanceMaterialIndex)
  System.Int32 GetUnitySubstanceMaterialKey(System.String unityMaterialPath, System.String substanceName, System.Int32 substanceIndex)
  System.Int32 MaterialNameToKey(System.String materialName)
  System.Void EnableGPUInstancing(UnityEngine.Material material)
  System.Boolean MaterialHasGPUInstancingEnabled(UnityEngine.Material material)
  UnityEngine.Material CopyMaterial(UnityEngine.Material material)
  UnityEngine.Material GetDefaultStandardMaterial()
  UnityEngine.Texture2D LoadTexture(System.String path)
  UnityEngine.Texture2D WhiteTexture()
  HoudiniEngineUnity.HEU_MaterialData CreateUnitySubstanceMaterialData(System.Int32 materialKey, System.String materialPath, System.String substanceName, System.Int32 substanceIndex, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath)
  HoudiniEngineUnity.HEU_MaterialData CreateMaterialInCache(System.Int32 materialKey, System.String materialName, HoudiniEngineUnity.HEU_MaterialSourceWrapper sourceType, System.Boolean bWriteToFile, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath)
  HoudiniEngineUnity.HEU_MaterialData CreateMaterialInCache(System.Int32 materialKey, System.String materialName, HoudiniEngineUnity.HEU_MaterialData.Source sourceType, System.Boolean bWriteToFile, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath)
  HoudiniEngineUnity.HEU_MaterialData GetOrCreateDefaultMaterialInCache(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Boolean bWriteToFile, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath)
  HoudiniEngineUnity.HEU_MaterialData GetMaterialDataFromCache(System.Int32 materialKey, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache)
  System.String GenerateDefaultMaterialName(System.Int32 geoID, System.Int32 partID)
  HoudiniEngineUnity.HEU_MaterialData CreateHoudiniMaterialData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, System.Int32 materialID, System.Int32 geoID, System.Int32 partID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath)
  System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MaterialData> GetMaterialDataMapFromCache(System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_UnityMaterialInfo
TYPE:  class
TOKEN: 0x20000F4
FIELDS:
  public            System.String                   _unityMaterialPath  // 0x10
  public            System.String                   _substancePath  // 0x18
  public            System.Int32                    _substanceIndex  // 0x20
METHODS:
  System.Void .ctor(System.String unityMaterialPath, System.String substancePath, System.Int32 substanceIndex)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_SessionBase
TYPE:  class
TOKEN: 0x20000F5
FIELDS:
  protected         HoudiniEngineUnity.HEU_SessionData_sessionData  // 0x10
  private           System.Boolean                  <UserNotifiedSessionInvalid>k__BackingField  // 0x18
  private           System.String                   _sessionErrorMsg  // 0x20
  private           System.Boolean                  <LogErrorOverride>k__BackingField  // 0x28
  private           System.Boolean                  <ThrowErrorOverride>k__BackingField  // 0x29
  private           HoudiniEngineUnity.HAPI_Result  <LastCallResultCode>k__BackingField  // 0x2C
METHODS:
  System.Boolean get_UserNotifiedSessionInvalid()
  System.Void set_UserNotifiedSessionInvalid(System.Boolean value)
  HoudiniEngineUnity.SessionConnectionState get_ConnectionState()
  System.Void set_ConnectionState(HoudiniEngineUnity.SessionConnectionState value)
  HoudiniEngineUnity.SessionMode get_ThisSessionMode()
  System.Void set_ThisSessionMode(HoudiniEngineUnity.SessionMode value)
  System.String GetSessionErrorMsg()
  System.Boolean get_LogErrorOverride()
  System.Void set_LogErrorOverride(System.Boolean value)
  System.Boolean get_ThrowErrorOverride()
  System.Void set_ThrowErrorOverride(System.Boolean value)
  System.Boolean IsSessionSync()
  HoudiniEngineUnity.HAPI_Result get_LastCallResultCode()
  System.Void set_LastCallResultCode(HoudiniEngineUnity.HAPI_Result value)
  HoudiniEngineUnity.HEU_HoudiniAsset GetRegisteredAssetFromID(System.Int32 id)
  System.Boolean IsAssetRegistered(HoudiniEngineUnity.HEU_HoudiniAsset asset)
  System.Void RegisterAsset(HoudiniEngineUnity.HEU_HoudiniAsset asset)
  System.Void UnregisterAsset(System.Int32 id)
  System.Void ReregisterOnAwake(HoudiniEngineUnity.HEU_HoudiniAsset asset)
  System.Void .ctor()
  System.Void SetSessionErrorMsg(System.String msg, System.Boolean bLogError)
  System.Void SetSessionConnectionErrorMsg(System.String introMsg, HoudiniEngineUnity.HAPI_Result result, System.Boolean bIsHARSRunning, System.Boolean bLogError)
  System.Void SetLibraryErrorMsg(System.Boolean bLogError)
  System.Boolean CreateSessionData(System.Boolean bOverwriteExisting, System.Boolean bIsDefaultSession)
  System.Boolean CreateInProcessSession(System.Boolean bIsDefaultSession)
  System.Boolean CreateThriftSocketSession(System.Boolean bIsDefaultSession, System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout, System.Boolean bLogError)
  System.Boolean CreateThriftPipeSession(System.Boolean bIsDefaultSession, System.String pipeName, System.Boolean autoClose, System.Single timeout, System.Boolean bLogError)
  System.Boolean CreateCustomSession(System.Boolean bIsDefaultSession)
  System.Boolean ConnectThriftSocketSession(System.Boolean bIsDefaultSession, System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout, System.Boolean logError, System.Boolean autoInitialize)
  System.Boolean ConnectThriftPipeSession(System.Boolean bIsDefaultSession, System.String pipeName, System.Boolean autoClose, System.Single timeout, System.Boolean logError, System.Boolean autoInitialize)
  System.Boolean CloseSession()
  System.Boolean CheckAndCloseExistingSession()
  System.Void ClearSessionInfo()
  System.Void SetSessionData(HoudiniEngineUnity.HEU_SessionData sessionData)
  HoudiniEngineUnity.HEU_SessionData GetSessionData()
  System.String GetSessionInfo()
  System.Boolean IsSessionValid()
  System.Boolean RestartSession()
  System.String GetLastSessionError()
  System.Boolean CheckVersionMatch()
  System.Boolean InitializeSession(HoudiniEngineUnity.HEU_SessionData sessionData)
  System.Boolean HandleStatusResult(HoudiniEngineUnity.HAPI_Result result, System.String prependMsg, System.Boolean bThrowError, System.Boolean bLogError)
  System.Void SetServerEnvString(System.String name, System.String value)
  System.Boolean GetServerEnvString(System.String name, System.String& value)
  System.Boolean GetServerEnvVarCount(System.Int32& env_count)
  System.Boolean GetCallResult(HoudiniEngineUnity.HAPI_Result& result)
  System.Boolean GetCookResult(HoudiniEngineUnity.HAPI_Result& result)
  System.Boolean GetCookState(HoudiniEngineUnity.HAPI_State& state)
  System.String GetStatusString(HoudiniEngineUnity.HAPI_StatusType statusType, HoudiniEngineUnity.HAPI_StatusVerbosity verbosity)
  System.String ComposeNodeCookResult(System.Int32 nodeId, HoudiniEngineUnity.HAPI_StatusVerbosity verbosity)
  System.Int32 GetEnvInt(HoudiniEngineUnity.HAPI_EnvIntType intType)
  System.Int32 GetSessionEnvInt(HoudiniEngineUnity.HAPI_SessionEnvIntType intType, System.Boolean bLogError)
  System.Boolean GetString(System.Int32 stringHandle, System.String& resultString, System.Int32 bufferLength)
  System.Int32 GetStringBufferLength(System.Int32 stringHandle)
  System.Int32 CheckForSpecificErrors(System.Int32 nodeID, System.Int32 errorsToCheck)
  System.Single GetTime()
  System.Boolean SetTime(System.Single time)
  System.Boolean GetUseHoudiniTime()
  System.Boolean SetUseHoudiniTime(System.Boolean enable)
  System.Boolean LoadAssetLibraryFromFile(System.String assetPath, System.Boolean bAllowOverwrite, System.Int32& libraryID)
  System.Boolean LoadAssetLibraryFromMemory(System.Byte[] buffer, System.Boolean bAllowOverwrite, System.Int32& libraryID)
  System.Boolean CreateNode(System.Int32 parentNodeID, System.String operatorName, System.String nodeLabel, System.Boolean bCookOnCreation, System.Int32& newNodeID)
  System.Void DeleteNode(System.Int32 nodeID)
  System.Boolean CookNode(System.Int32 nodeID, System.Boolean bCookTemplatedGeos, System.Boolean bSplitGeosByGroup)
  System.Boolean CookNodeWithOptions(System.Int32 nodeID, HoudiniEngineUnity.HAPI_CookOptions cookOptions)
  System.Boolean RenameNode(System.Int32 nodeID, System.String newName)
  System.Boolean ConnectNodeInput(System.Int32 nodeID, System.Int32 inputIndex, System.Int32 nodeIDToConnect, System.Int32 outputIndex)
  System.Boolean DisconnectNodeInput(System.Int32 nodeID, System.Int32 inputIndex, System.Boolean bLogError)
  System.Boolean QueryNodeInput(System.Int32 nodeID, System.Int32 inputIndex, System.Int32& connectedNodeID, System.Boolean bLogError)
  System.Boolean GetNodeInputName(System.Int32 nodeID, System.Int32 inputIndex, System.Int32& nodeNameIndex)
  System.Boolean GetAvailableAssetCount(System.Int32 libraryID, System.Int32& assetCount)
  System.Boolean GetAvailableAssets(System.Int32 libraryID, System.Int32[]& assetNames, System.Int32 assetCount)
  System.Boolean GetAssetInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_AssetInfo& assetInfo, System.Boolean bLogError)
  System.Boolean GetNodeInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_NodeInfo& nodeInfo, System.Boolean bLogError)
  System.Boolean GetNodePath(System.Int32 nodeID, System.Int32 relativeNodeID, System.String& path)
  System.Boolean IsNodeValid(System.Int32 nodeID, System.Int32 uniqueNodeID)
  System.Boolean ComposeChildNodeList(System.Int32 parentNodeID, System.Int32 nodeTypeFilter, System.Int32 nodeFlagFilter, System.Boolean bRecursive, System.Int32& count, System.Boolean bLogError)
  System.Boolean GetComposedChildNodeList(System.Int32 parentNodeID, System.Int32[] childNodeIDs, System.Int32 count, System.Boolean bLogError)
  System.Boolean LoadHIPFile(System.String fileName, System.Boolean bCookOnLoad)
  System.Boolean SaveHIPFile(System.String fileName, System.Boolean bLockNodes)
  System.Boolean GetObjectInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_ObjectInfo& objectInfo)
  System.Boolean GetObjectTransform(System.Int32 nodeID, System.Int32 relativeToNodeID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform& hapiTransform)
  System.Boolean SetObjectTransform(System.Int32 nodeID, HoudiniEngineUnity.HAPI_TransformEuler& hapiTransform)
  System.Boolean ComposeObjectList(System.Int32 nodeID, System.Int32& objectCount)
  System.Boolean GetComposedObjectList(System.Int32 nodeID, HoudiniEngineUnity.HAPI_ObjectInfo[] objectInfos, System.Int32 start, System.Int32 length)
  System.Boolean GetComposedObjectTransforms(System.Int32 nodeID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform[] transforms, System.Int32 start, System.Int32 length)
  System.Boolean GetDisplayGeoInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_GeoInfo& geoInfo, System.Boolean bLogError)
  System.Boolean GetOutputGeoCount(System.Int32 nodeID, System.Int32& count, System.Boolean bLogError)
  System.Boolean GetOutputGeoInfos(System.Int32 nodeID, HoudiniEngineUnity.HAPI_GeoInfo[]& geoInfosArray, System.Int32 count, System.Boolean bLogError)
  System.Boolean GetGeoInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_GeoInfo& geoInfo, System.Boolean bLogError)
  System.Boolean GetPartInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_PartInfo& partInfo)
  System.Boolean GetAttributeInfo(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeOwner owner, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo)
  System.Boolean GetAttributeNames(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_AttributeOwner owner, System.String[]& attributeNames, System.Int32 count)
  System.Boolean GetAttributeStringData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Int32[] dataArray, System.Int32 start, System.Int32 length)
  System.Boolean GetAttributeFloatData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Single[] data, System.Int32 start, System.Int32 length)
  System.Boolean GetAttributeFloatArrayData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Single[]& data, System.Int32 dataLength, System.Int32[]& sizesArray, System.Int32 start, System.Int32 sizesLength)
  System.Boolean GetAttributeFloat64Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Double[] data, System.Int32 start, System.Int32 length)
  System.Boolean GetAttributeIntData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Int32[] data, System.Int32 start, System.Int32 length)
  System.Boolean GetAttributeUInt8Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Byte[] data, System.Int32 start, System.Int32 length)
  System.Boolean GetAttributeInt8Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.SByte[] data, System.Int32 start, System.Int32 length)
  System.Boolean GetAttributeInt16Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Int16[] data, System.Int32 start, System.Int32 length)
  System.Boolean GetAttributeInt64Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attributeInfo, System.Int64[] data, System.Int32 start, System.Int32 length)
  System.Boolean GetGroupNames(System.Int32 nodeID, HoudiniEngineUnity.HAPI_GroupType groupType, System.Int32[]& names, System.Int32 count)
  System.Boolean GetGroupMembership(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName, System.Boolean& membershipArrayAllEqual, System.Int32[] membershipArray, System.Int32 start, System.Int32 length)
  System.Boolean GetGroupCountOnPackedInstancePart(System.Int32 nodeID, System.Int32 partID, System.Int32& pointGroupCount, System.Int32& primitiveGroupCount)
  System.Boolean GetGroupNamesOnPackedInstancePart(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.Int32[]& groupNamesArray, System.Int32 groupCount)
  System.Boolean GetGroupMembershipOnPackedInstancePart(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName, System.Boolean& membershipArrayAllEqual, System.Int32[] membershipArray, System.Int32 start, System.Int32 length)
  System.Boolean GetInstancedPartIds(System.Int32 nodeID, System.Int32 partID, System.Int32[] instancedPartsArray, System.Int32 start, System.Int32 length)
  System.Boolean GetInstancerPartTransforms(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform[] transformsArray, System.Int32 start, System.Int32 length)
  System.Boolean GetInstanceTransformsOnPart(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform[] transformsArray, System.Int32 start, System.Int32 length)
  System.Boolean GetInstancedObjectIds(System.Int32 nodeID, System.Int32[] instanced_node_id_array, System.Int32 start, System.Int32 length)
  System.Boolean GetFaceCounts(System.Int32 nodeID, System.Int32 partID, System.Int32[] faceCounts, System.Int32 start, System.Int32 length)
  System.Boolean GetFaceCounts(System.Int32 nodeID, System.Int32 partID, System.Int32[] faceCounts, System.Int32 start, System.Int32 length, System.Boolean bLogError)
  System.Boolean GetVertexList(System.Int32 nodeID, System.Int32 partID, System.Int32[] vertexList, System.Int32 start, System.Int32 length)
  System.Boolean GetBoxInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_BoxInfo& boxInfo)
  System.Boolean GetSphereInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_SphereInfo& sphereInfo)
  System.Boolean GetCurveInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_CurveInfo& curveInfo)
  System.Boolean GetCurveCounts(System.Int32 nodeID, System.Int32 partID, System.Int32[] counts, System.Int32 start, System.Int32 length)
  System.Boolean GetCurveOrders(System.Int32 nodeID, System.Int32 partID, System.Int32[] orders, System.Int32 start, System.Int32 length)
  System.Boolean GetCurveKnots(System.Int32 nodeID, System.Int32 partID, System.Single[] knots, System.Int32 start, System.Int32 length)
  System.Boolean GetInputCurveInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_InputCurveInfo& inputCurveInfo)
  System.Boolean SetPartInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_PartInfo& partInfo)
  System.Boolean SetFaceCount(System.Int32 nodeID, System.Int32 partID, System.Int32[] faceCounts, System.Int32 start, System.Int32 length)
  System.Boolean SetVertexList(System.Int32 nodeID, System.Int32 partID, System.Int32[] vertexList, System.Int32 start, System.Int32 length)
  System.Boolean SetAttributeIntData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Int32[] data, System.Int32 start, System.Int32 length)
  System.Boolean SetAttributeInt8Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.SByte[] data, System.Int32 start, System.Int32 length)
  System.Boolean SetAttributeInt16Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Int16[] data, System.Int32 start, System.Int32 length)
  System.Boolean SetAttributeInt64Data(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Int64[] data, System.Int32 start, System.Int32 length)
  System.Boolean SetAttributeFloatData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Single[] data, System.Int32 start, System.Int32 length)
  System.Boolean SetAttributeFloatArrayData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.Single[] data, System.Int32 dataLength, System.Int32[] sizesArray, System.Int32 start, System.Int32 sizesLength)
  System.Boolean SetAttributeStringData(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, System.String[] data, System.Int32 start, System.Int32 length)
  System.Boolean AddAttribute(System.Int32 nodeID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo)
  System.Boolean AddGroup(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName)
  System.Boolean DeleteGroup(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName)
  System.Boolean SetGroupMembership(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName, System.Int32[] membershipArray, System.Int32 start, System.Int32 length)
  System.Boolean CommitGeo(System.Int32 nodeID)
  System.Boolean RevertGeo(System.Int32 nodeID)
  System.Boolean SetCurveInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_CurveInfo& curveInfo)
  System.Boolean SetCurveCounts(System.Int32 nodeID, System.Int32 partID, System.Int32[] counts, System.Int32 start, System.Int32 length)
  System.Boolean SetCurveOrders(System.Int32 nodeID, System.Int32 partID, System.Int32[] orders, System.Int32 start, System.Int32 length)
  System.Boolean SetCurveKnots(System.Int32 nodeID, System.Int32 partID, System.Single[] knots, System.Int32 start, System.Int32 length)
  System.Boolean SetInputCurveInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_InputCurveInfo& curveInfo)
  System.Boolean SetInputCurvePositions(System.Int32 nodeID, System.Int32 partID, System.Single[] positionsArray, System.Int32 start, System.Int32 length)
  System.Boolean SetInputCurvePositionsRotationsScales(System.Int32 nodeID, System.Int32 partID, System.Single[] positionsArray, System.Int32 start, System.Int32 length, System.Single[] rotationsArray, System.Int32 rotationsStart, System.Int32 rotationsLength, System.Single[] scalesArray, System.Int32 scalesStart, System.Int32 scalesLength)
  System.Boolean GetMaterialOnPart(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_MaterialInfo& materialInfo)
  System.Boolean GetMaterialNodeIDsOnFaces(System.Int32 nodeID, System.Int32 partID, System.Boolean& bSingleFaceMaterial, System.Int32[] materialNodeIDs, System.Int32 faceCount)
  System.Boolean GetMaterialInfo(System.Int32 materialNodeID, HoudiniEngineUnity.HAPI_MaterialInfo& materialInfo, System.Boolean bLogError)
  System.Boolean GetImageInfo(System.Int32 materialNodeID, HoudiniEngineUnity.HAPI_ImageInfo& imageInfo)
  System.Boolean SetImageInfo(System.Int32 materialNodeID, HoudiniEngineUnity.HAPI_ImageInfo& imageInfo)
  System.Boolean RenderTextureToImage(System.Int32 materialNodeID, System.Int32 parmID, System.Boolean bLogError)
  System.Boolean RenderCOPToImage(System.Int32 copNodeID)
  System.Boolean ExtractImageToMemory(System.Int32 nodeID, System.String fileFormat, System.String imagePlanes, System.Byte[]& buffer)
  System.Boolean GetImagePlanes(System.Int32 nodeID, System.Int32[] imagePlanes, System.Int32 numImagePlanes)
  System.Boolean ExtractImageToFile(System.Int32 nodeID, System.String fileFormat, System.String imagePlanes, System.String destinationFolderPath, System.String& destinationFilePath)
  System.Boolean GetParams(System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmInfo[] parmInfos, System.Int32 start, System.Int32 length)
  System.Boolean GetParmTagName(System.Int32 nodeID, System.Int32 parmID, System.Int32 tagIndex, System.Int32& tagName)
  System.Boolean GetParmTagValue(System.Int32 nodeID, System.Int32 parmID, System.String tagName, System.Int32& tagValue)
  System.Boolean ParmHasTag(System.Int32 nodeID, System.Int32 parmID, System.String tagName, System.Boolean& hasTag)
  System.Boolean GetParamIntValues(System.Int32 nodeID, System.Int32[] values, System.Int32 start, System.Int32 length)
  System.Boolean GetParamIntValue(System.Int32 nodeID, System.String parmName, System.Int32 index, System.Int32& value)
  System.Boolean GetParamFloatValues(System.Int32 nodeID, System.Single[] values, System.Int32 start, System.Int32 length)
  System.Boolean GetParamFloatValue(System.Int32 nodeID, System.String parmName, System.Int32 index, System.Single& value)
  System.Boolean GetParamStringValues(System.Int32 nodeID, System.Int32[] values, System.Int32 start, System.Int32 length)
  System.Boolean GetParamStringValue(System.Int32 nodeID, System.String parmName, System.Int32 index, System.Int32& value)
  System.Boolean GetParamNodeValue(System.Int32 nodeID, System.String paramName, System.Int32& nodeValue)
  System.Boolean GetParamChoiceValues(System.Int32 nodeID, HoudiniEngineUnity.HAPI_ParmChoiceInfo[] values, System.Int32 start, System.Int32 length)
  System.Boolean SetParamIntValues(System.Int32 nodeID, System.Int32[]& values, System.Int32 start, System.Int32 length)
  System.Boolean SetParamIntValue(System.Int32 nodeID, System.String paramName, System.Int32 index, System.Int32 value)
  System.Boolean SetParamFloatValues(System.Int32 nodeID, System.Single[]& values, System.Int32 start, System.Int32 length)
  System.Boolean SetParamFloatValue(System.Int32 nodeID, System.String paramName, System.Int32 index, System.Single value)
  System.Boolean SetParamStringValue(System.Int32 nodeID, System.String strValue, System.Int32 parmID, System.Int32 index)
  System.Boolean SetParamStringValue(System.Int32 nodeID, System.String parmName, System.String parmValue, System.Int32 index)
  System.Boolean SetParamNodeValue(System.Int32 nodeID, System.String paramName, System.Int32 nodeValueID)
  System.Boolean InsertMultiparmInstance(System.Int32 nodeID, System.Int32 parmID, System.Int32 instancePosition)
  System.Boolean RemoveMultiParmInstance(System.Int32 nodeID, System.Int32 parmID, System.Int32 instancePosition)
  System.Boolean GetParmWithTag(System.Int32 nodeID, System.String tagName, System.Int32& parmID)
  System.Boolean RevertParmToDefault(System.Int32 nodeID, System.String parm_name, System.Int32 index)
  System.Boolean RevertParmToDefaults(System.Int32 nodeID, System.String parm_name)
  System.Boolean GetParmIDFromName(System.Int32 nodeID, System.String parmName, System.Int32& parmID)
  System.Boolean GetParmStringValue(System.Int32 nodeID, System.String parmName, System.Int32 index, System.Boolean evaluate, System.Int32& value)
  System.Boolean CreateInputNode(System.Int32& nodeID, System.String name)
  System.Boolean CreateInputCurveNode(System.Int32& nodeID, System.String name)
  System.Boolean CreateHeightFieldInput(System.Int32 parentNodeID, System.String name, System.Int32 xSize, System.Int32 ySize, System.Single voxelSize, HoudiniEngineUnity.HAPI_HeightFieldSampling sampling, System.Int32& heightfieldNodeID, System.Int32& heightNodeID, System.Int32& maskNodeID, System.Int32& mergeNodeID)
  System.Boolean CreateHeightfieldInputVolumeNode(System.Int32 parentNodeID, System.Int32& newNodeID, System.String name, System.Int32 xSize, System.Int32 ySize, System.Single voxelSize)
  System.Boolean GetPreset(System.Int32 nodeID, System.Byte[]& presetData)
  System.Boolean SetPreset(System.Int32 nodeID, System.Byte[] presetData)
  System.Boolean GetVolumeInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_VolumeInfo& volumeInfo)
  System.Boolean GetHeightFieldData(System.Int32 nodeID, System.Int32 partID, System.Single[] valuesArray, System.Int32 start, System.Int32 length)
  System.Boolean SetVolumeInfo(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_VolumeInfo& volumeInfo)
  System.Boolean SetVolumeTileFloatData(System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_VolumeTileInfo& tileInfo, System.Single[] valuesArray, System.Int32 length)
  System.Boolean GetVolumeBounds(System.Int32 nodeID, System.Int32 partID, System.Single& x_min, System.Single& y_min, System.Single& z_min, System.Single& x_max, System.Single& y_max, System.Single& z_max, System.Single& x_center, System.Single& y_center, System.Single& z_center)
  System.Boolean SetHeightFieldData(System.Int32 nodeID, System.Int32 partID, System.String name, System.Single[] valuesArray, System.Int32 start, System.Int32 length)
  System.Boolean GetActiveCacheCount(System.Int32& activeCacheCount)
  System.Boolean GetActiveCacheNames(System.Int32[] cacheNamesArray, System.Int32 activeCacheCount)
  System.Boolean GetCacheProperty(System.String cacheName, HoudiniEngineUnity.HAPI_CacheProperty cacheProperty, System.Int32& propertyValue)
  System.Boolean SetCacheProperty(System.String cacheName, HoudiniEngineUnity.HAPI_CacheProperty cacheProperty, System.Int32 propertyValue)
  System.Boolean SaveGeoToFile(System.Int32 nodeID, System.String fileName)
  System.Boolean LoadGeoFromFile(System.Int32 nodeID, System.String file_name)
  System.Boolean SaveNodeToFile(System.Int32 nodeID, System.String fileName)
  System.Boolean LoadNodeFromFile(System.String file_name, System.Int32 parentNodeID, System.String nodeLabel, System.Boolean cook_on_load, System.Int32& newNodeID)
  System.Boolean GetGeoSize(System.Int32 nodeID, System.String format, System.Int32& size)
  System.Boolean GetHandleInfo(System.Int32 nodeID, HoudiniEngineUnity.HAPI_HandleInfo[] handleInfos, System.Int32 start, System.Int32 length)
  System.Boolean GetHandleBindingInfo(System.Int32 nodeID, System.Int32 handleIndex, HoudiniEngineUnity.HAPI_HandleBindingInfo[] handleBindingInfos, System.Int32 start, System.Int32 length)
  System.Boolean ConvertTransform(HoudiniEngineUnity.HAPI_TransformEuler& inTransform, HoudiniEngineUnity.HAPI_RSTOrder RSTOrder, HoudiniEngineUnity.HAPI_XYZOrder ROTOrder, HoudiniEngineUnity.HAPI_TransformEuler& outTransform)
  System.Boolean GetTotalCookCount(System.Int32 nodeID, System.Int32 nodeTypeFilter, System.Int32 nodeFlagFilter, System.Boolean includeChildren, System.Int32& count)
  System.Boolean SetSessionSync(System.Boolean enable)
  System.Boolean GetViewport(HoudiniEngineUnity.HAPI_Viewport& viewport)
  System.Boolean SetViewport(HoudiniEngineUnity.HAPI_Viewport& viewport)
  System.Boolean GetSessionSyncInfo(HoudiniEngineUnity.HAPI_SessionSyncInfo& syncInfo)
  System.Boolean SetSessionSyncInfo(HoudiniEngineUnity.HAPI_SessionSyncInfo& syncInfo)
  System.Boolean SetNodeDisplay(System.Int32 node_id, System.Int32 onOff)
END_CLASS

CLASS: HoudiniEngineUnity.SessionConnectionState
TYPE:  struct
TOKEN: 0x20000F6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.SessionConnectionStateNOT_CONNECTED  // 0x0
  public    static  HoudiniEngineUnity.SessionConnectionStateCONNECTED  // 0x0
  public    static  HoudiniEngineUnity.SessionConnectionStateFAILED_TO_CONNECT  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.SessionMode
TYPE:  struct
TOKEN: 0x20000F7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.SessionMode  Socket  // 0x0
  public    static  HoudiniEngineUnity.SessionMode  Pipe  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_SessionData
TYPE:  class
TOKEN: 0x20000F8
FIELDS:
  public    static  System.Int64                    INVALID_SESSION_ID  // 0x0
  public            HoudiniEngineUnity.HAPI_Session _HAPISession  // 0x10
  private           System.Int32                    _serverProcessID  // 0x20
  private           System.Boolean                  _initialized  // 0x24
  private           System.String                   _pipeName  // 0x28
  private           System.Int32                    _port  // 0x30
  private           System.String                   _sessionClassType  // 0x38
  private           System.Boolean                  _isDefaultSession  // 0x40
  private           HoudiniEngineUnity.HEU_SessionSyncData_sessionSync  // 0x48
  private           HoudiniEngineUnity.SessionConnectionState_connectionState  // 0x50
  private           HoudiniEngineUnity.SessionMode  _sessionMode  // 0x54
METHODS:
  HoudiniEngineUnity.HEU_SessionSyncData GetOrCreateSessionSync()
  HoudiniEngineUnity.HEU_SessionSyncData GetSessionSync()
  System.Void SetSessionSync(HoudiniEngineUnity.HEU_SessionSyncData syncData)
  System.Int64 get_SessionID()
  System.Void set_SessionID(System.Int64 value)
  System.Int32 get_ProcessID()
  System.Void set_ProcessID(System.Int32 value)
  HoudiniEngineUnity.HAPI_SessionType get_SessionType()
  System.Void set_SessionType(HoudiniEngineUnity.HAPI_SessionType value)
  System.Boolean get_IsInitialized()
  System.Void set_IsInitialized(System.Boolean value)
  System.Boolean get_IsValidSessionID()
  System.String get_PipeName()
  System.Void set_PipeName(System.String value)
  System.Int32 get_Port()
  System.Void set_Port(System.Int32 value)
  System.Type get_SessionClassType()
  System.Void set_SessionClassType(System.Type value)
  System.Boolean get_IsDefaultSession()
  System.Void set_IsDefaultSession(System.Boolean value)
  System.Boolean get_IsSessionSync()
  HoudiniEngineUnity.SessionConnectionState get_ThisConnectionMode()
  System.Void set_ThisConnectionMode(HoudiniEngineUnity.SessionConnectionState value)
  HoudiniEngineUnity.SessionMode get_ThisSessionMode()
  System.Void set_ThisSessionMode(HoudiniEngineUnity.SessionMode value)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_SessionHAPI
TYPE:  class
TOKEN: 0x20000F9
EXTENDS: HEU_SessionBase
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_SessionManager
TYPE:  class
TOKEN: 0x20000FA
FIELDS:
  private   static  HoudiniEngineUnity.HEU_SessionBase_defaultSession  // 0x0
  private   static  System.Collections.Generic.Dictionary<System.Int64,HoudiniEngineUnity.HEU_SessionBase>_sessionMap  // 0x8
  public    static  HoudiniEngineUnity.HEU_SessionManager.CreateSessionFromTypeDelegate_createSessionFromTypeDelegate  // 0x10
METHODS:
  HoudiniEngineUnity.HEU_SessionBase CreateSessionObject()
  HoudiniEngineUnity.HEU_SessionBase CreateSessionFromType(System.Type type)
  HoudiniEngineUnity.HEU_SessionBase GetDefaultSession()
  System.Void RegisterSession(System.Int64 sessionID, HoudiniEngineUnity.HEU_SessionBase session)
  System.Void UnregisterSession(System.Int64 sessionID)
  HoudiniEngineUnity.HEU_SessionBase GetSessionWithID(System.Int64 sessionID)
  System.Void SaveAllSessionData()
  System.Void LoadAllSessionData()
  System.Void InternalValidateSceneAssets()
  HoudiniEngineUnity.HEU_SessionBase GetOrCreateDefaultSession(System.Boolean bNotifyUserError)
  System.Boolean CreateInProcessSession()
  System.Boolean CreateThriftSocketSession(System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout, System.Boolean logError)
  System.Boolean CreateThriftPipeSession(System.String pipeName, System.Boolean autoClose, System.Single timeout, System.Boolean logError)
  System.Boolean CreateCustomSession()
  System.Boolean ConnectThriftSocketSession(System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout)
  System.Boolean ConnectThriftPipeSession(System.String pipeName, System.Boolean autoClose, System.Single timeout)
  System.Void RecreateDefaultSessionData()
  System.Boolean ConnectSessionSyncUsingThriftSocket(System.String hostName, System.Int32 serverPort, System.Boolean autoClose, System.Single timeout, System.Boolean logError)
  System.Boolean ConnectSessionSyncUsingThriftPipe(System.String pipeName, System.Boolean autoClose, System.Single timeout, System.Boolean logError)
  System.Boolean InitializeDefaultSession()
  System.Boolean CloseDefaultSession()
  System.Void CloseAllSessions()
  System.Void CheckAndCloseExistingSession()
  HoudiniEngineUnity.HEU_SessionData GetSessionData()
  System.String GetSessionInfo()
  System.Boolean LoadStoredDefaultSession()
  System.Boolean RestartSession()
  System.Boolean ValidatePluginSession(HoudiniEngineUnity.HEU_SessionBase session)
  System.String GetLastSessionError()
  System.Boolean CheckVersionMatch()
  System.Boolean ClearConnectionError()
  System.String GetConnectionError(System.Boolean clear)
  System.Boolean IsHARSProcessRunning(System.Int32 processID)
  System.Boolean LoadSessionFromHIP(System.Boolean bCookNodes, HoudiniEngineUnity.HEU_SessionBase session)
  System.Boolean SaveSessionToHIP(System.Boolean bLockNodes, HoudiniEngineUnity.HEU_SessionBase session)
  System.String GetHoudiniPathOnMacOS(System.String houdiniPath)
  System.Boolean OpenHoudini(System.String args)
  System.Boolean OpenSessionInHoudini(HoudiniEngineUnity.HEU_SessionBase session)
  HoudiniEngineUnity.HAPI_License GetCurrentLicense(System.Boolean bLogError)
  System.String GetString(System.Int32 stringHandle, HoudiniEngineUnity.HEU_SessionBase session)
  System.String[] GetStringValuesFromStringIndices(System.Int32[] strIndices)
  System.String[] GetGroupNames(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.Boolean isInstanced)
  System.Boolean GetGroupMembership(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Int32 partID, HoudiniEngineUnity.HAPI_GroupType groupType, System.String groupName, System.Int32[]& membership, System.Boolean isInstanced)
  System.String GetNodeName(System.Int32 nodeID, HoudiniEngineUnity.HEU_SessionBase session)
  System.Boolean GetNodeInputName(System.Int32 nodeID, System.Int32 inputIndex, System.String& inputName)
  System.Boolean GetComposedChildNodeList(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 parentNodeID, System.Int32 nodeTypeFilter, System.Int32 nodeFlagFilter, System.Boolean bRecursive, System.Int32[]& childNodeIDs, System.Boolean bLogIfError)
  System.Boolean GetComposedObjectListMemorySafe(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_ObjectInfo[] objectInfos, System.Int32 start, System.Int32 length)
  System.Boolean GetComposedObjectTransformsMemorySafe(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HAPI_RSTOrder rstOrder, HoudiniEngineUnity.HAPI_Transform[] transforms, System.Int32 start, System.Int32 length)
  System.String GetUniqueMaterialShopName(System.Int32 assetID, System.Int32 materialID)
  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_SessionPDG
TYPE:  class
TOKEN: 0x20000FC
FIELDS:
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_SessionSyncData
TYPE:  class
TOKEN: 0x20000FD
FIELDS:
  private           System.Int32                    _status  // 0x10
  public            System.Single                   _timeLastUpdate  // 0x14
  public            System.Single                   _timeStartConnection  // 0x18
  public            System.String                   _newNodeName  // 0x20
  public            System.Int32                    _nodeTypeIndex  // 0x28
  public            System.Boolean                  _validForConnection  // 0x2C
  public            HoudiniEngineUnity.HAPI_Viewport_viewportHAPI  // 0x30
  public            HoudiniEngineUnity.HAPI_Viewport_viewportLocal  // 0x48
  public            System.Boolean                  _viewportJustUpdated  // 0x60
  public            HoudiniEngineUnity.HAPI_SessionSyncInfo_syncInfo  // 0x61
METHODS:
  HoudiniEngineUnity.HEU_SessionSyncData.Status get_SyncStatus()
  System.Void set_SyncStatus(HoudiniEngineUnity.HEU_SessionSyncData.Status value)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetSync
TYPE:  class
TOKEN: 0x20000FF
EXTENDS: HEU_BaseSync
FIELDS:
  public            HoudiniEngineUnity.HEU_AssetSync.AssetSyncCallback_onAssetLoaded  // 0x88
  public            System.String                   _assetPath  // 0x90
METHODS:
  System.Void OnEnable()
  System.Void OnDestroy()
  System.Void InitializeAsset(HoudiniEngineUnity.HEU_SessionBase session, System.String assetPath, System.String nodeName, UnityEngine.Transform parent, UnityEngine.Vector3 startPosition)
  HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo CreateThreadedTask()
  System.Void SetLoadCallback(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallback callback)
  System.Void SetupLoadTask(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void OnLoadComplete(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData)
  System.Void Resync()
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_SyncedEventData
TYPE:  class
TOKEN: 0x2000101
FIELDS:
  public            System.Boolean                  CookSuccess  // 0x10
  public            HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadDataTopNodeData  // 0x18
  public            HoudiniEngineUnity.HEU_BaseSync OutputObject  // 0x20
METHODS:
  System.Void .ctor(System.Boolean bSuccess, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData bTopNodeData, HoudiniEngineUnity.HEU_BaseSync bOutputObject)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_BaseSync
TYPE:  class
TOKEN: 0x2000102
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Int32                    _cookNodeID  // 0x18
  public            System.Int64                    _sessionID  // 0x20
  public            System.String                   _nodeName  // 0x28
  public            System.Boolean                  _initialized  // 0x30
  public            System.Boolean                  _syncing  // 0x31
  public            System.Boolean                  _deleteParent  // 0x32
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeneratedOutput>_generatedOutputs  // 0x38
  public            System.String                   _outputCacheDirectory  // 0x40
  public            System.Collections.Generic.List<System.String>_outputCacheFilePaths  // 0x48
  public            HoudiniEngineUnity.HEU_GenerateOptions_generateOptions  // 0x50
  public            System.Text.StringBuilder       _log  // 0x58
  public            System.Text.StringBuilder       _error  // 0x60
  public            System.Boolean                  _sessionSyncAutoCook  // 0x68
  private           System.Action<HoudiniEngineUnity.HEU_SyncedEventData>_onSynced  // 0x70
  protected         HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo_loadTask  // 0x78
  protected         System.Int32                    _totalCookCount  // 0x80
  protected         System.Boolean                  _firstSyncComplete  // 0x84
METHODS:
  System.Void Awake()
  System.Void OnDestroy()
  System.Void DeleteSessionData()
  System.Void DestroyGeneratedData()
  System.Void Initialize()
  HoudiniEngineUnity.HEU_SessionBase GetHoudiniSession(System.Boolean bCreateIfNotFound)
  System.Int32 GetParentNodeID(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void Log(System.String msg)
  System.Void ClearLog()
  System.Void Error(System.String error)
  System.Boolean IsLoaded()
  System.Void StartSync()
  System.Void SetupLoadTask(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void StopSync()
  System.Void Resync()
  System.Void Bake()
  System.Void Unload()
  System.Void Reset()
  System.Void OnLoadComplete(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData)
  System.Void GenerateObjects(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData)
  System.Void GenerateGeometry(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData, System.Int32 objIndex)
  System.Void OnStopped(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData)
  System.Void GenerateTerrain(System.Int32 cookNodeId, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolume> terrainBuffers)
  System.Void GenerateMesh(System.Int32 cookNodeId, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferMesh> meshBuffers)
  System.Void GenerateAllInstancers(System.Int32 cookNodeId, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferInstancer> instancerBuffers, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData)
  System.Void GenerateInstancer(System.Int32 cookNodeId, HoudiniEngineUnity.HEU_LoadBufferInstancer instancerBuffer, System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_LoadBufferBase> idBuffersMap)
  System.Void GenerateInstancesFromNodeIDs(System.Int32 cookNodeId, HoudiniEngineUnity.HEU_LoadBufferInstancer instancerBuffer, System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_LoadBufferBase> idBuffersMap, UnityEngine.Transform instanceRootTransform)
  System.Void GenerateInstancesFromAssetPaths(HoudiniEngineUnity.HEU_LoadBufferInstancer instancerBuffer, UnityEngine.Transform instanceRootTransform)
  System.Void CreateNewInstanceFromObject(UnityEngine.GameObject assetSourceGO, System.Int32 instanceIndex, UnityEngine.Transform parentTransform, HoudiniEngineUnity.HAPI_Transform& hapiTransform, System.String[] instancePrefixes, System.String instanceName, UnityEngine.GameObject collisionSourceGO)
  System.Void ApplyAttributeModifiersOnGameObjectOutput(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partId, UnityEngine.GameObject& go)
  System.Void DestroyOutputs()
  System.Void SetOutputVisiblity(HoudiniEngineUnity.HEU_LoadBufferBase buffer)
  System.String GetOutputCacheDirectory()
  System.Void SetOutputCacheDirectory(System.String directory)
  System.Void AddGeneratedOutputFilePath(System.String path)
  System.Void SyncUpdate()
  System.Action<HoudiniEngineUnity.HEU_SyncedEventData> get_OnSynced()
  System.Void set_OnSynced(System.Action<HoudiniEngineUnity.HEU_SyncedEventData> value)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GenerateOptions
TYPE:  struct
TOKEN: 0x2000103
FIELDS:
  public            System.Boolean                  _generateUVs  // 0x10
  public            System.Boolean                  _generateTangents  // 0x11
  public            System.Boolean                  _generateNormals  // 0x12
  public            System.Boolean                  _useLODGroups  // 0x13
  public            System.Boolean                  _splitPoints  // 0x14
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GeoSync
TYPE:  class
TOKEN: 0x2000104
EXTENDS: HEU_BaseSync
FIELDS:
  public            System.String                   _filePath  // 0x88
METHODS:
  System.Void SetupLoadTask(HoudiniEngineUnity.HEU_SessionBase session)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_NodeSync
TYPE:  class
TOKEN: 0x2000105
EXTENDS: HEU_BaseSync
FIELDS:
  public            System.String                   _nodeSaveFilePath  // 0x88
METHODS:
  System.Void OnEnable()
  System.Void OnDestroy()
  System.Void InitializeFromHoudini(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.String nodeName, System.String filePath)
  System.Void SetupLoadTask(HoudiniEngineUnity.HEU_SessionBase session)
  System.Boolean SaveNodeToFile(System.String filePath)
  System.Void CreateNodeSync(HoudiniEngineUnity.HEU_SessionBase session, System.String opName, System.String nodeNabel)
  System.Void Resync()
  System.Void SyncUpdate()
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Task
TYPE:  class
TOKEN: 0x2000106
FIELDS:
  public            HoudiniEngineUnity.HEU_Task.TaskStatus_status  // 0x10
  public            HoudiniEngineUnity.HEU_Task.TaskResult_result  // 0x14
  private           System.Guid                     _guid  // 0x18
  public            HoudiniEngineUnity.HEU_Task.TaskCallback_taskCompletedDelegate  // 0x28
METHODS:
  System.Guid get_TaskGuid()
  System.Void .ctor()
  System.Void DoTask()
  System.Void UpdateTask()
  System.Void KillTask()
  System.Void CompleteTask(HoudiniEngineUnity.HEU_Task.TaskResult result)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_AssetTask
TYPE:  class
TOKEN: 0x200010A
EXTENDS: HEU_Task
FIELDS:
  public            HoudiniEngineUnity.HEU_AssetTask.BuildType_buildType  // 0x30
  public            HoudiniEngineUnity.HEU_HoudiniAsset_asset  // 0x38
  public            System.String                   _assetPath  // 0x40
  public            UnityEngine.Vector3             _position  // 0x48
  public            System.Boolean                  _buildResult  // 0x54
  public            System.Int64                    _forceSessionID  // 0x58
METHODS:
  HoudiniEngineUnity.HEU_SessionBase GetTaskSession()
  System.Void DoTask()
  System.Void KillTask()
  System.Void CompleteTask(HoudiniEngineUnity.HEU_Task.TaskResult result)
  System.Void CookCompletedCallback(HoudiniEngineUnity.HEU_HoudiniAsset asset, System.Boolean bSuccess, System.Collections.Generic.List<UnityEngine.GameObject> outputs)
  System.Void CookCompletedCallback(HoudiniEngineUnity.HEU_CookedEventData cookedEventData)
  System.Void CookCompletedCallback(HoudiniEngineUnity.HEU_ReloadEventData reloadEventData)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_TaskManager
TYPE:  class
TOKEN: 0x200010C
FIELDS:
  private   static  System.Collections.Generic.List<HoudiniEngineUnity.HEU_Task>_tasks  // 0x0
  private   static  System.Collections.Generic.List<HoudiniEngineUnity.HEU_Task>_pendingAdd  // 0x8
  private   static  System.Collections.Generic.List<HoudiniEngineUnity.HEU_Task>_pendingRemove  // 0x10
METHODS:
  System.Void .cctor()
  System.Void Update()
  HoudiniEngineUnity.HEU_Task GetTask(System.Guid taskGuid)
  System.Void AddTask(HoudiniEngineUnity.HEU_Task task)
  System.Void KillTask(HoudiniEngineUnity.HEU_Task task, System.Boolean bRemove)
  System.Void KillTask(System.Guid taskGuid, System.Boolean bRemove)
  System.Void RemoveTask(HoudiniEngineUnity.HEU_Task task)
  System.Void ExecuteTask(HoudiniEngineUnity.HEU_Task task)
  System.Void CompleteTask(HoudiniEngineUnity.HEU_Task task, HoudiniEngineUnity.HEU_Task.TaskResult result)
  System.Void InternalCompleteTask(HoudiniEngineUnity.HEU_Task task)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_LoadBufferBase
TYPE:  class
TOKEN: 0x200010D
FIELDS:
  public            System.Int32                    _id  // 0x10
  public            System.String                   _name  // 0x18
  public            System.Boolean                  _bInstanced  // 0x20
  public            System.Boolean                  _bInstancer  // 0x21
  public            HoudiniEngineUnity.HEU_GeneratedOutput_generatedOutput  // 0x28
METHODS:
  System.Void InitializeBuffer(System.Int32 id, System.String name, System.Boolean bInstanced, System.Boolean bInstancer)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_LoadBufferMesh
TYPE:  class
TOKEN: 0x200010E
EXTENDS: HEU_LoadBufferBase
FIELDS:
  public            HoudiniEngineUnity.HEU_GenerateGeoCache_geoCache  // 0x30
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoGroup>_LODGroupMeshes  // 0x38
  public            System.Int32                    _defaultMaterialKey  // 0x40
  public            System.Boolean                  _bGenerateUVs  // 0x44
  public            System.Boolean                  _bGenerateTangents  // 0x45
  public            System.Boolean                  _bGenerateNormals  // 0x46
  public            System.Boolean                  _bPartInstanced  // 0x47
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_LoadBufferVolume
TYPE:  class
TOKEN: 0x200010F
EXTENDS: HEU_LoadBufferBase
FIELDS:
  public            System.Int32                    _tileIndex  // 0x30
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolumeLayer>_splatLayers  // 0x38
  public            System.Int32                    _heightMapWidth  // 0x40
  public            System.Int32                    _heightMapHeight  // 0x44
  public            System.Single[,]                _heightMap  // 0x48
  public            System.Single[,,]               _splatMaps  // 0x50
  public            System.Single                   _terrainSizeX  // 0x58
  public            System.Single                   _terrainSizeY  // 0x5C
  public            System.Single                   _heightRange  // 0x60
  public            UnityEngine.Vector3             _position  // 0x64
  public            System.String                   _terrainDataPath  // 0x70
  public            System.String                   _terrainDataExportPath  // 0x78
  public            HoudiniEngineUnity.HEU_VolumeScatterTrees_scatterTrees  // 0x80
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_DetailPrototype>_detailPrototypes  // 0x88
  public            System.Collections.Generic.List<System.Int32[,]>_detailMaps  // 0x90
  public            HoudiniEngineUnity.HEU_DetailProperties_detailProperties  // 0x98
  public            System.String                   _specifiedTerrainMaterialName  // 0xA0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_LoadBufferVolumeLayer
TYPE:  class
TOKEN: 0x2000110
FIELDS:
  public            System.String                   _layerName  // 0x10
  public            System.Int32                    _partID  // 0x18
  public            System.Int32                    _heightMapWidth  // 0x1C
  public            System.Int32                    _heightMapHeight  // 0x20
  public            System.Single                   _strength  // 0x24
  public            System.String                   _diffuseTexturePath  // 0x28
  public            System.String                   _maskTexturePath  // 0x30
  public            System.Single                   _metallic  // 0x38
  public            System.String                   _normalTexturePath  // 0x40
  public            System.Single                   _normalScale  // 0x48
  public            System.Single                   _smoothness  // 0x4C
  public            UnityEngine.Color               _specularColor  // 0x50
  public            UnityEngine.Vector2             _tileSize  // 0x60
  public            UnityEngine.Vector2             _tileOffset  // 0x68
  public            System.Boolean                  _uiExpanded  // 0x70
  public            System.Int32                    _tile  // 0x74
  public            System.Single[]                 _normalizedHeights  // 0x78
  public            System.Single                   _minHeight  // 0x80
  public            System.Single                   _maxHeight  // 0x84
  public            System.Single                   _heightRange  // 0x88
  public            System.Single                   _terrainSizeX  // 0x8C
  public            System.Single                   _terrainSizeY  // 0x90
  public            UnityEngine.Vector3             _position  // 0x94
  public            UnityEngine.Vector3             _minBounds  // 0xA0
  public            UnityEngine.Vector3             _maxBounds  // 0xAC
  public            UnityEngine.Vector3             _center  // 0xB8
  public            System.String                   _layerPath  // 0xC8
  public            System.Boolean                  _hasLayerAttributes  // 0xD0
  public            HoudiniEngineUnity.HFLayerType  _layerType  // 0xD4
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_LoadBufferInstancer
TYPE:  class
TOKEN: 0x2000111
EXTENDS: HEU_LoadBufferBase
FIELDS:
  public            HoudiniEngineUnity.HAPI_Transform[]_instanceTransforms  // 0x30
  public            System.String[]                 _instancePrefixes  // 0x38
  public            System.Int32[]                  _instanceNodeIDs  // 0x40
  public            System.String[]                 _assetPaths  // 0x48
  public            System.String[]                 _collisionAssetPaths  // 0x50
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ThreadedTask
TYPE:  class
TOKEN: 0x2000112
FIELDS:
  private           System.Boolean                  _isComplete  // 0x10
  private           System.Boolean                  _isActive  // 0x11
  private           System.Boolean                  _stopRequested  // 0x12
  private           System.Object                   _lockHandle  // 0x18
  private           System.Threading.Thread         _thread  // 0x20
  private           System.Threading.ThreadPriority _priority  // 0x28
  private           System.Boolean                  _isBackground  // 0x2C
  protected         System.String                   _name  // 0x30
METHODS:
  System.Void Start()
  System.Void Stop()
  System.Void Abort()
  System.Void Reset()
  System.Void Update()
  System.Void DoWork()
  System.Void OnComplete()
  System.Void OnStopped()
  System.Void CleanUp()
  System.Void Run()
  System.String get_TaskName()
  System.Boolean get_IsComplete()
  System.Void set_IsComplete(System.Boolean value)
  System.Boolean get_IsActive()
  System.Void set_IsActive(System.Boolean value)
  System.Boolean get_StopRequested()
  System.Void set_StopRequested(System.Boolean value)
  System.Threading.ThreadPriority get_Priority()
  System.Void set_Priority(System.Threading.ThreadPriority value)
  System.Boolean get_IsBackground()
  System.Void set_IsBackground(System.Boolean value)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo
TYPE:  class
TOKEN: 0x2000113
EXTENDS: HEU_ThreadedTask
FIELDS:
  private           HoudiniEngineUnity.HEU_BaseSync _ownerSync  // 0x38
  private           HoudiniEngineUnity.HEU_SessionBase_session  // 0x40
  private           HoudiniEngineUnity.HEU_GenerateOptions_generateOptions  // 0x48
  protected         System.String                   _assetCachePath  // 0x50
  private           HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadType_loadType  // 0x58
  private           System.String                   _filePath  // 0x60
  private           HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData_loadData  // 0x68
  private           HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallback_loadCallback  // 0x70
METHODS:
  System.Void SetupLoad(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_BaseSync ownerSync, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.LoadType loadType, System.Int32 cookNodeID, System.String name, System.String filePath)
  System.Void SetupLoadNode(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_BaseSync ownerSync, System.Int32 cookNodeID, System.String name)
  System.Void SetupLoadFile(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_BaseSync ownerSync, System.Int32 cookNodeID, System.String filePath)
  System.Void SetupLoadAsset(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_BaseSync ownerSync, System.String assetPath, System.String name)
  System.Void SetLoadCallback(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadCallback loadCallback)
  System.Void DoWork()
  System.Boolean CookNode(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 cookNodeID)
  System.Boolean LoadObjectBuffers(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_ObjectInfo& objectInfo)
  System.Boolean LoadNodeBuffer(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadObject loadObject)
  System.Void BuildBufferIDsMap(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData loadData)
  System.Boolean DoFileLoad()
  System.Boolean DoAssetLoad()
  System.Boolean QueryParts(System.Int32 nodeID, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& meshParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& volumeParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& instancerParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& curveParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo>& scatterInstancerParts)
  System.Void OnComplete()
  System.Void OnStopped()
  System.Void CleanUp()
  System.String CreateLogString(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus status, System.String logStr)
  System.Void AppendLog(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus status, System.String logStr)
  System.Void SetLog(HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadData.LoadStatus status, System.String logStr)
  System.Boolean CreateFileNode(System.Int32& fileNodeID)
  System.Int32 GetCookNodeID()
  System.Int32 GetDisplayNodeID(System.Int32 objNodeID)
  System.Boolean SetFileParm(System.Int32 fileNodeID, System.String filePath)
  System.Void Sleep()
  System.Boolean GenerateTerrainBuffers(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo> volumeParts, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo> scatterInstancerParts, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolume>& volumeBuffers)
  System.Void LoadStringFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.String& strValue)
  System.Void LoadFloatFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Single& floatValue)
  System.Void LoadLayerColorFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Color& colorValue)
  System.Void LoadLayerVector2FromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Vector2& vectorValue)
  System.Boolean GenerateMeshBuffers(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo> meshParts, System.Boolean bSplitPoints, System.Boolean bUseLODGroups, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, HoudiniEngineUnity.HEU_ThreadedTaskLoadGeo.HEU_LoadObject loadObject, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferMesh>& meshBuffers)
  System.Boolean GenerateInstancerBuffers(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 nodeID, System.Collections.Generic.List<HoudiniEngineUnity.HAPI_PartInfo> instancerParts, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferInstancer>& instancerBuffers)
  HoudiniEngineUnity.HEU_LoadBufferInstancer GeneratePartsInstancerBuffer(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String partName, HoudiniEngineUnity.HAPI_PartInfo partInfo)
  HoudiniEngineUnity.HEU_LoadBufferInstancer GeneratePointAttributeInstancerBuffer(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String partName, HoudiniEngineUnity.HAPI_PartInfo partInfo)
  HoudiniEngineUnity.HEU_LoadBufferVolume GetLoadBufferVolumeFromTileIndex(System.Int32 tileIndex, System.Collections.Generic.List<HoudiniEngineUnity.HEU_LoadBufferVolume> buffers)
  System.String GetValidAssetCacheFolderPath(System.String name)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ThreadManager
TYPE:  class
TOKEN: 0x200011A
FIELDS:
  private   static  HoudiniEngineUnity.HEU_ThreadManager_instance  // 0x0
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_ThreadedTask>_tasks  // 0x10
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_ThreadedTask>_pendingAdd  // 0x18
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_ThreadedTask>_pendingRemove  // 0x20
METHODS:
  HoudiniEngineUnity.HEU_ThreadManager get_Instance()
  System.Void CreateInstance()
  System.Void Finalize()
  System.Void Register()
  System.Void Unregister()
  System.Void Update()
  System.Void AddTask(HoudiniEngineUnity.HEU_ThreadedTask task)
  System.Void RemoveTask(HoudiniEngineUnity.HEU_ThreadedTask task)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_CookLogs
TYPE:  class
TOKEN: 0x200011B
FIELDS:
  private   static  HoudiniEngineUnity.HEU_CookLogs _instance  // 0x0
  private           System.Text.StringBuilder       _cookLogs  // 0x10
  private           System.Int32                    _currentCookLogCount  // 0x18
  private   static  System.Int32                    MAX_COOK_LOG_COUNT  // 0x0
  private           System.String                   _lastLogStr  // 0x20
  private           System.Boolean                  _uniqueStrOnly  // 0x28
  public    static  System.Int64                    MaxLogSize  // 0x0
METHODS:
  HoudiniEngineUnity.HEU_CookLogs get_Instance()
  System.String GetCookLogString()
  System.Void AppendCookLog(System.String logStr)
  System.Void ClearCookLog()
  System.String GetCookLogFilePath()
  System.Void DeleteCookingFile()
  System.Void WriteToLogFile(System.String logStr, System.Boolean checkLastLogStr)
  System.Int64 GetFileSizeOfLogFile()
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_EditorUtility
TYPE:  class
TOKEN: 0x200011C
FIELDS:
METHODS:
  System.Void MarkSceneDirty()
  System.Void SelectObject(UnityEngine.GameObject gameObject)
  System.Void SelectObjects(UnityEngine.GameObject[] gameObjects)
  UnityEngine.Vector3 GetSelectedObjectsMeanPosition()
  UnityEngine.Matrix4x4 GetSelectedObjectsMeanTransform()
  UnityEngine.GameObject SaveAsPrefabAsset(System.String path, UnityEngine.GameObject go)
  System.Boolean PrefabIsAddedComponentOverride(UnityEngine.Component comp)
  System.Boolean IsEditorPlaying()
  UnityEngine.GameObject ReplacePrefab(UnityEngine.GameObject go, UnityEngine.Object targetPrefab, HoudiniEngineUnity.HEU_EditorUtility.HEU_ReplacePrefabOptions heuOptions)
  System.Boolean IsPrefabInstance(UnityEngine.GameObject go)
  System.Boolean IsPrefabAsset(UnityEngine.GameObject go)
  System.Boolean IsEditingInPrefabMode(UnityEngine.GameObject obj)
  System.Boolean IsDisconnectedPrefabInstance(UnityEngine.GameObject go)
  UnityEngine.Object GetPrefabAsset(UnityEngine.GameObject go)
  System.String GetPrefabAssetPath(UnityEngine.Object obj)
  System.Void DisconnectPrefabInstance(UnityEngine.GameObject instance)
  UnityEngine.Object InstantiatePrefab(UnityEngine.GameObject prefabOriginal)
  UnityEngine.GameObject InstantiateGameObject(UnityEngine.GameObject sourceGameObject, UnityEngine.Transform parentTransform, System.Boolean instantiateInWorldSpace, System.Boolean bRegisterUndo)
  UnityEngine.Component AddComponent(UnityEngine.GameObject target, System.Boolean bRegisterUndo)
  System.Void UndoRecordObject(UnityEngine.Object objectToUndo, System.String name)
  System.Void UndoCollapseCurrentGroup()
  UnityEngine.Object[] CollectDependencies(UnityEngine.Object obj)
  System.Boolean IsPersistant(UnityEngine.Object obj)
  System.String GetUniqueNameForSibling(UnityEngine.Transform parentTransform, System.String name)
  System.Void DisplayProgressBar(System.String title, System.String info, System.Single progress)
  System.Void ClearProgressBar()
  System.Boolean IsEditorNotInPlayModeAndNotGoingToPlayMode()
  System.Boolean DisplayDialog(System.String title, System.String message, System.String ok, System.String cancel)
  System.Boolean DisplayErrorDialog(System.String title, System.String message, System.String ok, System.String cancel)
  System.Void RevealInFinder(System.String path)
  System.Void SetObjectDirtyForEditorUpdate(UnityEngine.Object obj)
  System.Void SetStatic(UnityEngine.GameObject go, System.Boolean bStatic, System.Boolean bIncludeChildren)
  System.Void SetIsHidden(UnityEngine.GameObject go, System.Boolean isHidden, System.Boolean bIncludeChildren)
  UnityEngine.GameObject[] GetSelectedObjects()
  HoudiniEngineUnity.HEU_HoudiniAssetRoot[] GetSelectedAssetRoots()
  HoudiniEngineUnity.HEU_HoudiniAssetRoot[] GetAllAssetRoots()
  System.Void CookSelected()
  System.Void CookAll()
  System.Void CookAssets(HoudiniEngineUnity.HEU_HoudiniAssetRoot[] rootAssets)
  System.Void RebuildSelected()
  System.Void RebuildAll()
  System.Void RebuildAssets(HoudiniEngineUnity.HEU_HoudiniAssetRoot[] rootAssets)
  System.Void BakeAndReplaceSelectedInScene()
  System.Void BakeAndReplaceAllInScene()
  System.Void BakeAndReplaceAssets(HoudiniEngineUnity.HEU_HoudiniAssetRoot[] rootAssets)
  System.Void ExportSelectedAssetsToGeoFiles()
  System.Void ExportAllAssetsToGeoFiles()
  System.Void ExportAssetsToGeoFiles(HoudiniEngineUnity.HEU_HoudiniAssetRoot[] rootAssets)
  System.String EditorSaveFolderPanel(System.String title, System.String folder, System.String defaultName)
  System.Void QuerySelectedMeshTopology()
  System.String GetObjectParentFolder(UnityEngine.GameObject parentObject, System.Collections.Generic.HashSet<UnityEngine.Material> generatedMaterials)
  System.String GetObjectParentFolderHelper(System.Int32 instanceID)
  System.Void RepaintScene()
  System.Void SetTextureToNormalMap(System.String filename)
  System.Boolean ReleasedMouse()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Extensions
TYPE:  class
TOKEN: 0x200011E
FIELDS:
METHODS:
  System.Collections.Generic.List<R> Map(System.Collections.Generic.IEnumerable<T> self, System.Func<T,R> selector)
  T Reduce(System.Collections.Generic.IEnumerable<T> self, System.Func<T,T,T> func)
  System.Collections.Generic.List<T> Filter(System.Collections.Generic.IEnumerable<T> self, System.Func<T,System.Boolean> predicate)
  System.Boolean IsValidIndex(System.Collections.Generic.List<T> self, System.Int32 index)
  System.Boolean IsEquivalentList(System.Collections.Generic.List<T> self, System.Collections.Generic.List<T> other)
  System.Boolean ApproximatelyEquals(UnityEngine.Quaternion quatA, UnityEngine.Quaternion value)
  System.Collections.Generic.List<U> ConvertList(System.Collections.Generic.List<T> self)
  System.Collections.Generic.List<HoudiniEngineUnity.IEquivable<T>> ConvertListToEquivable(System.Collections.Generic.List<T> self)
  HoudiniEngineUnity.IEquivable<T>[] ConvertArrayToEquivable(T[] self)
  System.Boolean ApproximatelyEquals(System.Single self, System.Single other, System.Single epsilon)
  System.Byte[] AsByteArray(System.String self)
  System.String AsString(System.Byte[] buffer)
  UnityEngine.Vector3 SwapXAndY(UnityEngine.Vector3 self)
  UnityEngine.Vector3 SwapXAndZ(UnityEngine.Vector3 self)
  UnityEngine.Vector3 SwapYAndZ(UnityEngine.Vector3 self)
  UnityEngine.Vector3 DecomposeToPosition(UnityEngine.Matrix4x4 self)
  UnityEngine.Quaternion DecomposeToRotation(UnityEngine.Matrix4x4 self)
  UnityEngine.Vector3 DecomposeToScale(UnityEngine.Matrix4x4 self)
END_CLASS

CLASS: HoudiniEngineUnity.ArrayExtensions
TYPE:  class
TOKEN: 0x200011F
FIELDS:
METHODS:
  System.Void Init(T[] array, T defaultValue)
  System.Void Init(System.Collections.Generic.List<T> array, T defaultValue)
  System.Void CopyToWithResize(T[] srcArray, T[]& destArray)
  System.Boolean IsEquivalentArray(T[] arr, T[] other)
  System.Boolean IsNull(T[] arr)
END_CLASS

CLASS: HoudiniEngineUnity.DictionaryExtensions
TYPE:  class
TOKEN: 0x2000120
FIELDS:
METHODS:
  System.Void AddOrSet(System.Collections.Generic.Dictionary<T,U> dict, T key, U value)
END_CLASS

CLASS: HoudiniEngineUnity.TransformData
TYPE:  struct
TOKEN: 0x2000121
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Quaternion          rotation  // 0x1C
  public            UnityEngine.Vector3             localPosition  // 0x2C
  public            UnityEngine.Vector3             localScale  // 0x38
  public            UnityEngine.Quaternion          localRotation  // 0x44
  public            UnityEngine.Transform           parent  // 0x58
METHODS:
  System.Void .ctor(UnityEngine.Transform other)
  System.Void CopyTo(UnityEngine.Transform other, System.Boolean copyParent)
  System.Void CopyToLocal(UnityEngine.Transform other, System.Boolean copyParent)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GeneralUtility
TYPE:  class
TOKEN: 0x2000122
FIELDS:
METHODS:
  System.Boolean GetArray1Arg(System.Int32 arg1, HoudiniEngineUnity.HEU_GeneralUtility.GetArray1ArgDel<T> func, T[] data, System.Int32 start, System.Int32 count)
  System.Boolean GetArray2Arg(System.Int32 arg1, ARG2 arg2, HoudiniEngineUnity.HEU_GeneralUtility.GetArray2ArgDel<ARG2,T> func, T[] data, System.Int32 start, System.Int32 count)
  System.Boolean GetArray3Arg(System.Int32 arg1, ARG2 arg2, ARG3 arg3, HoudiniEngineUnity.HEU_GeneralUtility.GetArray3ArgDel<ARG3,ARG2,T> func, T[] data, System.Int32 start, System.Int32 count)
  System.Boolean GetArray(System.Int32 arg1, ARG2 arg2, ARG3 arg3, HoudiniEngineUnity.HEU_GeneralUtility.GetArray1ArgDel<T> func1, HoudiniEngineUnity.HEU_GeneralUtility.GetArray2ArgDel<ARG2,T> func2, HoudiniEngineUnity.HEU_GeneralUtility.GetArray3ArgDel<ARG3,ARG2,T> func3, T[] data, System.Int32 start, System.Int32 count, System.Int32 tupleSize)
  System.Boolean SetArray1Arg(System.Int32 arg1, HoudiniEngineUnity.HEU_GeneralUtility.GetArray1ArgDel<T> func, T[] data, System.Int32 start, System.Int32 count)
  System.Boolean SetArray2Arg(System.Int32 arg1, ARG2 arg2, HoudiniEngineUnity.HEU_GeneralUtility.GetArray2ArgDel<ARG2,T> func, T[] data, System.Int32 start, System.Int32 count)
  System.Boolean SetArray(System.Int32 arg1, ARG2 arg2, HoudiniEngineUnity.HEU_GeneralUtility.GetArray1ArgDel<T> func1, HoudiniEngineUnity.HEU_GeneralUtility.GetArray2ArgDel<ARG2,T> func2, T[] data, System.Int32 start, System.Int32 count, System.Int32 tupleSize)
  System.Boolean DoArrayElementsMatch(T[] array1, T[] array2)
  System.Boolean DoArrayElementsMatch(T[] array1, System.Int32 startOffset1, T[] array2, System.Int32 startOffset2, System.Int32 length)
  System.Boolean GetAttributeArray(System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[] items, HoudiniEngineUnity.HEU_GeneralUtility.GetAttributeArrayInputFunc<T> getFunc, System.Int32 count)
  System.Boolean GetAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[]& data, HoudiniEngineUnity.HEU_GeneralUtility.GetAttributeArrayInputFunc<T> getFunc)
  System.Boolean GetAttributeStrict(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HAPI_AttributeOwner attrOwner, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, T[]& data, HoudiniEngineUnity.HEU_GeneralUtility.GetAttributeArrayInputFunc<T> getFunc)
  System.Void GetAttributeStringDataHelper(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& info, System.Int32[]& data)
  System.String[] GetAttributeStringData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo)
  System.String[] GetAttributeDataAsString(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String name, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo)
  System.Boolean SetAttributeArray(System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, T[] items, HoudiniEngineUnity.HEU_GeneralUtility.SetAttributeArrayFunc<T> setFunc, System.Int32 count, System.Int32 start)
  System.Boolean SetAttribute(System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo, T[] items, HoudiniEngineUnity.HEU_GeneralUtility.SetAttributeArrayFunc<T> setFunc)
  System.Boolean CheckAttributeExists(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attribName, HoudiniEngineUnity.HAPI_AttributeOwner attribOwner)
  System.Boolean GetAttributeInfo(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attribName, HoudiniEngineUnity.HAPI_AttributeInfo& attribInfo)
  System.Boolean HasValidInstanceAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attribName)
  System.Void UpdateGeneratedAttributeStore(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject go)
  HoudiniEngineUnity.HEU_OutputAttribute CreateOutputAttributeHelper(System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo)
  HoudiniEngineUnity.HEU_OutputAttribute CreateOutputAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeInfo& attrInfo)
  System.Void CopyWorldTransformValues(UnityEngine.Transform src, UnityEngine.Transform dest)
  System.Void ApplyTransformTo(UnityEngine.Transform src, UnityEngine.Transform target)
  System.Void CopyLocalTransformValues(UnityEngine.Transform src, UnityEngine.Transform dest)
  System.Collections.Generic.List<UnityEngine.GameObject> GetChildGameObjects(UnityEngine.GameObject parentGO)
  System.Collections.Generic.List<UnityEngine.GameObject> GetChildGameObjectsWithNamePattern(UnityEngine.GameObject parentGO, System.String pattern, System.Boolean bExclude)
  System.Collections.Generic.List<UnityEngine.GameObject> GetInstanceChildObjects(UnityEngine.GameObject parentGO)
  System.Collections.Generic.List<UnityEngine.GameObject> GetNonInstanceChildObjects(UnityEngine.GameObject parentGO)
  UnityEngine.GameObject GetGameObjectByName(System.Collections.Generic.List<UnityEngine.GameObject> goList, System.String name)
  UnityEngine.GameObject GetGameObjectByNameInProjectOnly(System.String name)
  System.Boolean IsGameObjectInProject(UnityEngine.GameObject go)
  UnityEngine.GameObject GetGameObjectByNameInScene(System.String name)
  HoudiniEngineUnity.HEU_HoudiniAssetRoot GetHDAByGameObjectNameInScene(System.String name)
  T GetOrCreateComponent(UnityEngine.GameObject gameObject)
  System.Void DestroyGeneratedComponents(UnityEngine.GameObject gameObject)
  System.Void DestroyGeneratedMeshComponents(UnityEngine.GameObject gameObject)
  System.Void DestroyTerrainComponents(UnityEngine.GameObject gameObject)
  System.Void DestroyComponent(UnityEngine.GameObject gameObject)
  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean bAllowDestroyingAssets, System.Boolean bRegisterUndo)
  System.Void DestroyBakedGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> gameObjectsToDestroy)
  System.Void DestroyBakedGameObjectsWithEndName(System.Collections.Generic.List<UnityEngine.GameObject> gameObjectsToDestroy, System.String endName)
  System.Void DestroyLODGroup(UnityEngine.GameObject targetGO, System.Boolean bDontDeletePersistantResources)
  System.Collections.Generic.List<UnityEngine.Transform> GetLODTransforms(UnityEngine.GameObject targetGO)
  System.Void SetLODTransformValues(UnityEngine.GameObject targetGO, System.Collections.Generic.List<HoudiniEngineUnity.TransformData> transformData)
  System.Void DestroyGeneratedMeshMaterialsLODGroups(UnityEngine.GameObject targetGO, System.Boolean bDontDeletePersistantResources)
  System.Void DestroyGeneratedMaterial(UnityEngine.Material material)
  System.Void DestroyMeshCollider(UnityEngine.MeshCollider meshCollider, System.Boolean bDontDeletePersistantResources)
  System.Void SetGameObjectRenderVisiblity(UnityEngine.GameObject gameObject, System.Boolean bVisible)
  System.Void SetGameObjectChildrenRenderVisibility(UnityEngine.GameObject gameObject, System.Boolean bVisible)
  System.Void SetGameObjectColliderState(UnityEngine.GameObject gameObject, System.Boolean bEnabled)
  System.Void SetGameObjectChildrenColliderState(UnityEngine.GameObject gameObject, System.Boolean bVisible)
  System.String ColorToString(UnityEngine.Color c)
  UnityEngine.Color StringToColor(System.String colorString)
  System.Boolean DoesUnityTagExist(System.String tagName)
  System.Void SetLayer(UnityEngine.GameObject rootGO, System.Int32 layer, System.Boolean bIncludeChildren)
  System.Void SetTag(UnityEngine.GameObject rootGO, System.String tag, System.Boolean bIncludeChildren)
  System.Void CopyFlags(UnityEngine.GameObject srcGO, UnityEngine.GameObject dstGO, System.Boolean bIncludeChildren)
  System.Boolean IsMouseWithinSceneView(UnityEngine.Camera camera, UnityEngine.Vector2 mousePosition)
  System.Boolean IsMouseOverRect(UnityEngine.Camera camera, UnityEngine.Vector2 mousePosition, UnityEngine.Rect& rect)
  System.Type GetSystemTypeByName(System.String typeName)
  System.Void AssignUnityTag(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject gameObject)
  System.Void AssignUnityLayer(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject gameObject)
  System.Void MakeStaticIfHasAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject gameObject)
  System.String GetUnityScriptAttributeValue(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID)
  System.String GetAttributeStringValueSingle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeOwner attrOwner)
  System.String GetAttributeStringValueSingleStrict(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeOwner attrOwner)
  System.Boolean GetAttributeFloatSingle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Single& value)
  System.Boolean GetAttributeIntSingle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32& value)
  System.Boolean GetAttributeColorSingle(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Color& value)
  System.Boolean HasAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, HoudiniEngineUnity.HAPI_AttributeOwner attrOwner)
  System.Void AttachScriptWithInvokeFunction(System.String scriptSet, UnityEngine.GameObject gameObject)
  System.Boolean IsInCameraView(UnityEngine.Camera camera, UnityEngine.Vector3 point)
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> FindOrGenerateHandles(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_AssetInfo& assetInfo, System.Int32 assetID, System.String assetName, HoudiniEngineUnity.HEU_Parameters parameters, System.Collections.Generic.List<HoudiniEngineUnity.HEU_Handle> currentHandles)
  System.Void CopyComponents(UnityEngine.GameObject srcGO, UnityEngine.GameObject destGO)
  UnityEngine.Texture LoadTextureFromFile(System.String filePath)
  UnityEngine.Texture2D MakeTexture(System.Int32 width, System.Int32 height, UnityEngine.Color color)
  System.String ReplaceFirstOccurrence(System.String srcStr, System.String searchStr, System.String replaceStr)
  System.Void SetParentWithCleanTransform(UnityEngine.Transform parentTransform, UnityEngine.Transform childTransform)
  System.Void CopyHAPITransform(HoudiniEngineUnity.HAPI_Transform& src, HoudiniEngineUnity.HAPI_Transform& dest)
  System.String GetMaterialAttributeValueFromPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID)
  System.Void ReplaceColliderMeshFromMeshFilter(UnityEngine.GameObject targetGO, UnityEngine.GameObject sourceColliderGO)
  System.Void ReplaceColliderMeshFromMeshCollider(UnityEngine.GameObject targetGO, UnityEngine.GameObject sourceColliderGO)
  System.Single BiLerpf(System.Single p00, System.Single p10, System.Single p01, System.Single p11, System.Single fracX, System.Single fracY)
  System.Single Fractionalf(System.Single value)
  System.String LongestCommonPrefix(System.Collections.Generic.List<System.String> list)
  System.String GetRawOperatorName(System.String assetOpName)
  UnityEngine.GameObject GetPrefabFromPath(System.String path)
  System.Void ComposeNChildren(UnityEngine.GameObject parent, System.Int32 n, System.Collections.Generic.List<UnityEngine.GameObject>& childGameObjects, System.Boolean destroyIfExists)
  System.Void DestroyChildWithName(UnityEngine.Transform parent, System.String name)
  System.Void DestroyAutoGeneratedChildren(UnityEngine.GameObject parent)
  UnityEngine.GameObject CreateNewGameObject(System.String name)
  System.Void RenameGameObject(UnityEngine.GameObject obj, System.String name)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.ReverseCompare
TYPE:  class
TOKEN: 0x2000128
FIELDS:
METHODS:
  System.Int32 Compare(System.Object x, System.Object y)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GenerateGeoCache
TYPE:  class
TOKEN: 0x2000129
FIELDS:
  private           System.Int32                    <AssetID>k__BackingField  // 0x10
  public            HoudiniEngineUnity.HAPI_GeoInfo _geoInfo  // 0x14
  public            HoudiniEngineUnity.HAPI_PartInfo_partInfo  // 0x38
  public            System.String                   _partName  // 0x68
  public            System.Int32[]                  _vertexList  // 0x70
  public            System.Int32[]                  _faceCounts  // 0x78
  public            System.Int32[]                  _houdiniMaterialIDs  // 0x80
  public            System.Boolean                  _singleFaceUnityMaterial  // 0x88
  public            System.Boolean                  _singleFaceHoudiniMaterial  // 0x89
  public            System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_UnityMaterialInfo>_unityMaterialInfos  // 0x90
  public            HoudiniEngineUnity.HAPI_AttributeInfo_unityMaterialAttrInfo  // 0x98
  public            System.Int32[]                  _unityMaterialAttrName  // 0xC0
  public            System.Collections.Generic.Dictionary<System.Int32,System.String>_unityMaterialAttrStringsMap  // 0xC8
  public            HoudiniEngineUnity.HAPI_AttributeInfo_substanceMaterialAttrNameInfo  // 0xD0
  public            System.Int32[]                  _substanceMaterialAttrName  // 0xF8
  public            System.Collections.Generic.Dictionary<System.Int32,System.String>_substanceMaterialAttrStringsMap  // 0x100
  public            HoudiniEngineUnity.HAPI_AttributeInfo_substanceMaterialAttrIndexInfo  // 0x108
  public            System.Int32[]                  _substanceMaterialAttrIndex  // 0x130
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData>_inUseMaterials  // 0x138
  public            HoudiniEngineUnity.HAPI_AttributeInfo_posAttrInfo  // 0x140
  public            HoudiniEngineUnity.HAPI_AttributeInfo[]_uvsAttrInfo  // 0x168
  public            HoudiniEngineUnity.HAPI_AttributeInfo_normalAttrInfo  // 0x170
  public            HoudiniEngineUnity.HAPI_AttributeInfo_colorAttrInfo  // 0x198
  public            HoudiniEngineUnity.HAPI_AttributeInfo_alphaAttrInfo  // 0x1C0
  public            HoudiniEngineUnity.HAPI_AttributeInfo_tangentAttrInfo  // 0x1E8
  public            System.Single[]                 _posAttr  // 0x210
  public            System.Single[][]               _uvsAttr  // 0x218
  public            System.Single[]                 _normalAttr  // 0x220
  public            System.Single[]                 _colorAttr  // 0x228
  public            System.Single[]                 _alphaAttr  // 0x230
  public            System.Single[]                 _tangentAttr  // 0x238
  public            System.String[]                 _groups  // 0x240
  public            System.Boolean                  _hasGroupGeometry  // 0x248
  public            System.Collections.Generic.Dictionary<System.String,System.Int32[]>_groupSplitVertexIndices  // 0x250
  public            System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Int32>>_groupSplitFaceIndices  // 0x258
  public            System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Int32>>_groupVertexOffsets  // 0x260
  public            System.Int32[]                  _allCollisionVertexList  // 0x268
  public            System.Int32[]                  _allCollisionFaceIndices  // 0x270
  public            System.Single                   _normalCosineThreshold  // 0x278
  public            System.Boolean                  _hasLODGroups  // 0x27C
  public            System.Single[]                 _LODTransitionValues  // 0x280
  public            System.Boolean                  _isMeshReadWrite  // 0x288
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo>_colliderInfos  // 0x290
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData>_materialCache  // 0x298
  public            System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MaterialData>_materialIDToDataMap  // 0x2A0
  public            System.String                   _assetCacheFolderPath  // 0x2A8
  public            HoudiniEngineUnity.HEU_MeshIndexFormat_meshIndexFormat  // 0x2B0
METHODS:
  System.Int32 get_GeoID()
  System.Int32 get_PartID()
  System.Int32 get_AssetID()
  System.Void set_AssetID(System.Int32 value)
  HoudiniEngineUnity.HEU_GenerateGeoCache GetPopulatedGeoCache(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, System.Int32 geoID, System.Int32 partID, System.Boolean bUseLODGroups, System.Collections.Generic.List<HoudiniEngineUnity.HEU_MaterialData> materialCache, System.String assetCacheFolderPath)
  System.Void PopulateUnityMaterialData(HoudiniEngineUnity.HEU_SessionBase session)
  System.Int32 GetMaterialKeyFromAttributeIndex(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Int32 attributeIndex, System.String& unityMaterialName, System.String& substanceName, System.Int32& substanceIndex)
  System.Void CreateMaterialInfoEntryFromAttributeIndex(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Int32 materialAttributeIndex)
  System.Boolean PopulateGeometryData(HoudiniEngineUnity.HEU_SessionBase session, System.Boolean bUseLODGroups)
  System.Void ParseLODTransitionAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Single[]& LODTransitionValues)
  System.Void UpdateColliders(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, HoudiniEngineUnity.HEU_GeneratedOutputData outputData)
  System.Void UpdateCollider(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, HoudiniEngineUnity.HEU_GeneratedOutputData outputData, HoudiniEngineUnity.HEU_GenerateGeoCache.HEU_ColliderInfo colliderInfo)
  System.Void GetFinalMaterialsFromComparingNewWithPrevious(UnityEngine.GameObject gameObject, UnityEngine.Material[] previousMaterials, UnityEngine.Material[] newMaterials, UnityEngine.Material[]& finalMaterials)
  System.Boolean GenerateMeshFromSingleGroup(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GeoGroup GeoGroup, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, HoudiniEngineUnity.HEU_GeneratedOutput generatedOutput, System.Int32 defaultMaterialKey, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bPartInstanced)
  System.Boolean GenerateLODMeshesFromGeoGroups(HoudiniEngineUnity.HEU_SessionBase session, System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoGroup> GeoGroupMeshes, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, HoudiniEngineUnity.HEU_GeneratedOutput generatedOutput, System.Int32 defaultMaterialKey, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bPartInstanced)
  System.Boolean GenerateMeshFromGeoGroup(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GeoGroup GeoGroup, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Int32 defaultMaterialKey, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bPartInstanced, UnityEngine.Mesh& newMesh, UnityEngine.Material[]& newMaterials)
  UnityEngine.Mesh CombineQuadMeshes(System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MeshData> subMeshesMap, System.Collections.Generic.List<System.Int32> subMeshIndices, System.Boolean bGenerateNormals)
  UnityEngine.Mesh CombineMeshes(System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MeshData> subMeshesMap, System.Collections.Generic.List<System.Int32> submeshIndices, System.Boolean bGenerateUVs, System.Boolean bGenerateNormals, HoudiniEngineUnity.HEU_MeshIndexFormat meshIndexFormat)
  UnityEngine.Mesh CreateMeshFromMeshData(HoudiniEngineUnity.HEU_MeshData submesh, System.Boolean bGenerateUVs, System.Boolean bGenerateNormals, HoudiniEngineUnity.HEU_MeshIndexFormat meshIndexFormat)
  System.Void TransferRegularAttributesToVertices(System.Int32[] groupVertexList, System.Int32[] allFaceCounts, System.Collections.Generic.List<System.Int32> groupFaces, System.Collections.Generic.List<System.Int32> groupVertexOffset, HoudiniEngineUnity.HAPI_AttributeInfo& attribInfo, System.Single[] inData, System.Single[]& outData)
  System.Boolean GenerateGeoGroupUsingGeoCacheVertices(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bUseLODGroups, System.Boolean bPartInstanced, System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoGroup>& LODGroupMeshes, System.Int32& defaultMaterialKey)
  System.Boolean GenerateGeoGroupUsingGeoCachePoints(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Boolean bGenerateUVs, System.Boolean bGenerateTangents, System.Boolean bGenerateNormals, System.Boolean bUseLODGroups, System.Boolean bPartInstanced, System.Collections.Generic.List<HoudiniEngineUnity.HEU_GeoGroup>& LODGroupMeshes, System.Int32& defaultMaterialKey)
  System.Void GetSubmeshIDForFace(HoudiniEngineUnity.HEU_GenerateGeoCache geoCache, System.Int32 faceMaterialID, System.Int32 groupFace, System.Int32 vertexFaceIndex, System.Int32[] groupVertexList, System.Int32 defaultMaterialKey, System.Int32& submeshID, System.Int32& singleFaceUnityMaterialKey, System.Int32& singleFaceHoudiniMaterialKey)
  UnityEngine.MeshTopology CalculateGroupMeshTopology(System.Collections.Generic.List<System.Int32> groupFaces, System.Int32[] allFaceCounts)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GeoGroup
TYPE:  class
TOKEN: 0x200012D
FIELDS:
  public            System.String                   _groupName  // 0x10
  public            System.Collections.Generic.Dictionary<System.Int32,HoudiniEngineUnity.HEU_MeshData>_subMeshesMap  // 0x18
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_VertexEntry>[]_sharedNormalIndices  // 0x20
METHODS:
  System.Int32 CompareTo(HoudiniEngineUnity.HEU_GeoGroup other)
  System.Void SetupNormalIndices(System.Int32 indicesCount)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_VertexEntry
TYPE:  class
TOKEN: 0x200012E
FIELDS:
  public            System.Int32                    _meshKey  // 0x10
  public            System.Int32                    _vertexIndex  // 0x14
  public            System.Int32                    _normalIndex  // 0x18
METHODS:
  System.Void .ctor(System.Int32 meshKey, System.Int32 vertexIndex, System.Int32 normalIndex)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_GeometryUtility
TYPE:  class
TOKEN: 0x200012F
FIELDS:
METHODS:
  UnityEngine.Vector2[] GeneratePerTriangle(UnityEngine.Mesh meshSrc)
  System.Void GenerateSecondaryUVSet(UnityEngine.Mesh meshsrc)
  System.Void CalculateMeshTangents(UnityEngine.Mesh mesh)
  UnityEngine.Mesh GenerateCubeMeshFromPoints(UnityEngine.Vector3[] points, UnityEngine.Color[] pointsColor, System.Single size)
  System.String GetInstanceOutputName(System.String partName, System.String[] userPrefix, System.Int32 index)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputData
TYPE:  class
TOKEN: 0x2000130
FIELDS:
  public            UnityEngine.GameObject          _inputObject  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputInterface
TYPE:  class
TOKEN: 0x2000131
FIELDS:
  public    static  System.Int32                    DEFAULT_PRIORITY  // 0x0
  protected         System.Int32                    _priority  // 0x10
METHODS:
  System.Int32 get_Priority()
  System.Void .ctor(System.Int32 priority)
  System.Void RegisterInterface()
  System.Boolean IsThisInputObjectSupported(UnityEngine.GameObject inputObject)
  System.Boolean CreateInputNodeWithDataUpload(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 connectNodeID, UnityEngine.GameObject inputObject, System.Int32& inputNodeID)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputInterfaceMeshSettings
TYPE:  class
TOKEN: 0x2000132
FIELDS:
  private           System.Boolean                  _exportColliders  // 0x10
METHODS:
  System.Boolean get_ExportColliders()
  System.Void set_ExportColliders(System.Boolean value)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputInterfaceMesh
TYPE:  class
TOKEN: 0x2000133
EXTENDS: HEU_InputInterface
FIELDS:
  private           HoudiniEngineUnity.HEU_InputInterfaceMeshSettingssettings  // 0x18
METHODS:
  System.Void .ctor()
  System.Void Initialize(HoudiniEngineUnity.HEU_InputInterfaceMeshSettings settings)
  System.Boolean CreateInputNodeWithDataUpload(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 connectNodeID, UnityEngine.GameObject inputObject, System.Int32& inputNodeID)
  System.Boolean IsThisInputObjectSupported(UnityEngine.GameObject inputObject)
  System.Void GetUVsFromMesh(UnityEngine.Mesh mesh, UnityEngine.Vector2[] srcUVs, System.Collections.Generic.List<UnityEngine.Vector3> destUVs, System.Int32 index)
  System.Boolean UploadData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 inputNodeID, HoudiniEngineUnity.HEU_InputData inputData)
  System.Boolean UploadColliderData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 mergeNodeID, HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataMeshes inputData, System.Int32 parentNodeId)
  System.Boolean UploadBoxColliderData(HoudiniEngineUnity.HEU_SessionBase session, UnityEngine.BoxCollider collider, System.Int32 inputIndex, System.Int32 parentNodeID, System.Int32& inputNodeID)
  System.Boolean UploadSphereColliderData(HoudiniEngineUnity.HEU_SessionBase session, UnityEngine.SphereCollider collider, System.Int32 inputIndex, System.Int32 parentNodeID, System.Int32& inputNodeID)
  System.Boolean UploadCapsuleColliderData(HoudiniEngineUnity.HEU_SessionBase session, UnityEngine.CapsuleCollider collider, System.Int32 inputIndex, System.Int32 parentNodeID, System.Int32& inputNodeID)
  System.Boolean UploadMeshColliderData(HoudiniEngineUnity.HEU_SessionBase session, UnityEngine.MeshCollider collider, System.Int32 inputIndex, System.Int32 parentNodeID, System.Int32& inputNodeID)
  System.String GetColliderGroupBaseName(UnityEngine.Collider collider, System.Boolean bIsConvex, System.Boolean bIsSimple, System.Boolean bIsRendered)
  System.Boolean CreateInputNodeForCollider(HoudiniEngineUnity.HEU_SessionBase session, System.Int32& outNodeID, System.Int32 parentNodeId, System.Int32 colliderIndex, System.String colliderName, System.Single[] colliderVertices, System.Int32[] colliderIndices)
  HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataMeshes GenerateMeshDatasFromGameObject(UnityEngine.GameObject inputObject, System.Boolean bExportColliders)
  HoudiniEngineUnity.HEU_InputInterfaceMesh.HEU_InputDataMesh CreateSingleMeshData(UnityEngine.GameObject meshGameObject, System.Boolean bExportColliders)
  UnityEngine.Mesh GetMeshFromObject(UnityEngine.GameObject meshGameObject)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputInterfaceTerrain
TYPE:  class
TOKEN: 0x2000138
EXTENDS: HEU_InputInterface
FIELDS:
METHODS:
  System.Void .ctor()
  System.Boolean CreateInputNodeWithDataUpload(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 connectNodeID, UnityEngine.GameObject inputObject, System.Int32& inputNodeID)
  System.Boolean SetMaskLayer(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain idt, HoudiniEngineUnity.HAPI_VolumeInfo& baseVolumeInfo)
  System.Boolean IsThisInputObjectSupported(UnityEngine.GameObject inputObject)
  System.Boolean CreateHeightFieldInputNode(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain idt)
  System.Boolean UploadHeightValuesWithTransform(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain idt, HoudiniEngineUnity.HAPI_VolumeInfo& volumeInfo)
  System.Boolean UploadAlphaMaps(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain idt, HoudiniEngineUnity.HAPI_VolumeInfo& baseVolumeInfo, System.Boolean& bMaskSet)
  System.Boolean SetHeightFieldData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 volumeNodeID, System.Int32 partID, System.Single[] heightValues, System.String heightFieldName, HoudiniEngineUnity.HAPI_VolumeInfo& baseVolumeInfo)
  System.Boolean SetTerrainDataAttributesToHeightField(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoNodeID, System.Int32 partID, UnityEngine.TerrainData terrainData)
  System.Boolean SetTerrainLayerAttributesToHeightField(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoNodeID, System.Int32 partID, UnityEngine.TerrainLayer terrainLayer)
  System.Void SetTreePrototypes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoNodeID, System.Int32 partID, UnityEngine.TerrainData terrainData)
  System.Void SetTreeInstances(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoNodeID, System.Int32 partID, UnityEngine.TerrainData terrainData)
  HoudiniEngineUnity.HEU_InputInterfaceTerrain.HEU_InputDataTerrain GenerateTerrainDataFromGameObject(UnityEngine.GameObject inputObject)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings
TYPE:  class
TOKEN: 0x200013A
FIELDS:
  public            System.Boolean                  _createGroupsForTiles  // 0x10
  public            System.Boolean                  _exportUnusedTiles  // 0x11
  public            System.Boolean                  _applyTileColor  // 0x12
  public            System.Boolean                  _applyTilemapOrientation  // 0x13
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputInterfaceTilemap
TYPE:  class
TOKEN: 0x200013B
EXTENDS: HEU_InputInterface
FIELDS:
  private           HoudiniEngineUnity.HEU_InputInterfaceTilemapSettingssettings  // 0x18
METHODS:
  System.Void .ctor()
  System.Void Initialize(HoudiniEngineUnity.HEU_InputInterfaceTilemapSettings settings)
  System.Boolean CreateInputNodeWithDataUpload(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 connectNodeID, UnityEngine.GameObject inputObject, System.Int32& inputNodeID)
  System.Boolean IsThisInputObjectSupported(UnityEngine.GameObject inputObject)
  System.Boolean UploadData(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 inputNodeID, HoudiniEngineUnity.HEU_InputData inputData)
  HoudiniEngineUnity.HEU_InputInterfaceTilemap.HEU_InputDataTilemap GenerateTilemapDataFromGameObject(UnityEngine.GameObject inputObject)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputMeshUtility
TYPE:  class
TOKEN: 0x200013D
FIELDS:
METHODS:
  System.Boolean SetMeshPointAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, UnityEngine.Vector3[] data, HoudiniEngineUnity.HAPI_PartInfo& partInfo, System.Boolean bConvertToHoudiniCoordinateSystem)
  System.Boolean SetMeshPointAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, System.Single[] data, HoudiniEngineUnity.HAPI_PartInfo& partInfo)
  System.Boolean SetMeshVertexAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, UnityEngine.Vector3[] data, System.Int32[] indices, HoudiniEngineUnity.HAPI_PartInfo& partInfo, System.Boolean bConvertToHoudiniCoordinateSystem)
  System.Boolean SetMeshVertexFloatAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, System.Single[] data, System.Int32[] indices, HoudiniEngineUnity.HAPI_PartInfo& partInfo)
  System.Boolean UploadMeshIntoHoudiniNode(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetNodeID, System.Int32 objectID, System.Int32 geoID, UnityEngine.Mesh& mesh)
  System.Boolean SetMeshPointAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, UnityEngine.Vector3Int[] data, HoudiniEngineUnity.HAPI_PartInfo& partInfo)
  System.Boolean SetMeshPointAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.String[] data, HoudiniEngineUnity.HAPI_PartInfo& partInfo)
  System.Boolean SetMeshDetailAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Int32 tupleSize, UnityEngine.Vector3 data, HoudiniEngineUnity.HAPI_PartInfo& partInfo)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_InputUtility
TYPE:  class
TOKEN: 0x200013E
FIELDS:
  private   static  System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputInterface>_inputInterfaces  // 0x0
METHODS:
  System.Int32 GetHighestPriority()
  System.Void RegisterInputInterface(HoudiniEngineUnity.HEU_InputInterface inputInterface)
  System.Void UnregisterInputInterface(HoudiniEngineUnity.HEU_InputInterface inputInterface)
  HoudiniEngineUnity.HEU_InputInterface GetInputInterfaceByType(System.Type type)
  HoudiniEngineUnity.HEU_InputInterface GetInputInterface(UnityEngine.GameObject inputObject)
  HoudiniEngineUnity.HEU_InputInterface GetInputInterface(HoudiniEngineUnity.HEU_InputObjectInfo inputObjectInfo)
  System.Boolean CreateInputNodeWithMultiObjects(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 assetID, System.Int32& connectMergeID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputObjectInfo>& inputObjects, System.Collections.Generic.List<System.Int32>& inputObjectsConnectedAssetIDs, HoudiniEngineUnity.HEU_InputNode inputNode)
  System.Boolean CreateInputNodeWithMultiAssets(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset parentAsset, System.Int32& connectMergeID, System.Collections.Generic.List<HoudiniEngineUnity.HEU_InputHDAInfo>& inputAssetInfos, System.Boolean bKeepWorldTransform, System.Int32 mergeParentID)
  System.Boolean UploadInputObjectTransform(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_InputObjectInfo inputObject, System.Int32 inputNodeID, System.Boolean bKeepWorldTransform)
  System.Void GetChildrenTransforms(UnityEngine.Transform transform, System.Collections.Generic.List<UnityEngine.Matrix4x4>& childTransforms)
  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Logger
TYPE:  class
TOKEN: 0x200013F
FIELDS:
METHODS:
  System.Void Log(System.String text)
  System.Void LogFormat(System.String text, System.Object[] args)
  System.Void LogWarning(System.String text)
  System.Void LogWarningFormat(System.String text, System.Object[] args)
  System.Void LogError(System.String text)
  System.Void LogErrorFormat(System.String text, System.Object[] args)
  System.Void LogError(System.Exception ex)
  System.Void LogAssertion(System.String text)
  System.Void LogAssertionFormat(System.String text, System.Object[] args)
  System.Void LogToCookLogsIfOn(System.String text)
  System.Void LogToCookLogsIfOnFormat(System.String text, System.Object[] args)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_MeshData
TYPE:  class
TOKEN: 0x2000140
FIELDS:
  public            System.Collections.Generic.List<System.Int32>_indices  // 0x10
  public            System.Collections.Generic.List<UnityEngine.Vector3>_vertices  // 0x18
  public            System.Collections.Generic.List<UnityEngine.Color32>_colors  // 0x20
  public            System.Collections.Generic.List<UnityEngine.Vector3>_normals  // 0x28
  public            System.Collections.Generic.List<UnityEngine.Vector4>_tangents  // 0x30
  public            System.Collections.Generic.List<UnityEngine.Vector4>[]_uvs  // 0x38
  public            System.Collections.Generic.List<UnityEngine.Vector3>_triangleNormals  // 0x40
  public            System.Collections.Generic.Dictionary<System.Int32,System.Int32>_pointIndexToMeshIndexMap  // 0x48
  public            UnityEngine.MeshTopology        _meshTopology  // 0x50
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_MeshIndexFormat
TYPE:  class
TOKEN: 0x2000141
FIELDS:
  public            UnityEngine.Rendering.IndexFormat_indexFormat  // 0x10
METHODS:
  System.Void CalculateIndexFormat(System.Int32 numVertices)
  System.Void SetFormatForMesh(UnityEngine.Mesh mesh)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_PipelineType
TYPE:  struct
TOKEN: 0x2000142
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HEU_PipelineTypeUnsupported  // 0x0
  public    static  HoudiniEngineUnity.HEU_PipelineTypeBiRP  // 0x0
  public    static  HoudiniEngineUnity.HEU_PipelineTypeURP  // 0x0
  public    static  HoudiniEngineUnity.HEU_PipelineTypeHDRP  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_RenderingPipelineDefines
TYPE:  class
TOKEN: 0x2000143
FIELDS:
METHODS:
  System.Void .cctor()
  System.Void UpdateDefines()
  HoudiniEngineUnity.HEU_PipelineType GetPipeline()
  System.Void AddDefine(System.String define)
  System.Void RemoveDefine(System.String define)
  System.Collections.Generic.List<System.String> GetDefines()
  System.Void SetDefines(System.Collections.Generic.List<System.String> definesList)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_SerializableDictionary`2
TYPE:  class
TOKEN: 0x2000144
FIELDS:
  private           System.Collections.Generic.Dictionary<TKey,TValue>_dictionary  // 0x0
  private           TKey[]                          _keys  // 0x0
  private           TValue[]                        _values  // 0x0
METHODS:
  TValue get_Item(TKey key)
  System.Void set_Item(TKey key, TValue value)
  System.Collections.Generic.ICollection<TKey> get_Keys()
  System.Collections.Generic.ICollection<TValue> get_Values()
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Void Add(TKey key, TValue value)
  System.Void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  System.Void Clear()
  System.Boolean Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  System.Boolean ContainsKey(TKey key)
  System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex)
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator()
  System.Boolean Remove(TKey key)
  System.Boolean Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item)
  System.Boolean TryGetValue(TKey key, TValue& value)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void OnAfterDeserialize()
  System.Void OnBeforeSerialize()
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ShelfToolData
TYPE:  class
TOKEN: 0x2000145
FIELDS:
  public            System.String                   _name  // 0x10
  public            HoudiniEngineUnity.HEU_ShelfToolData.ToolType_toolType  // 0x18
  public            System.String                   _toolTip  // 0x20
  public            System.String                   _iconPath  // 0x28
  public            System.String                   _assetPath  // 0x30
  public            System.String                   _helpURL  // 0x38
  public            System.String[]                 _targets  // 0x40
  public            System.String                   _jsonPath  // 0x48
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_Shelf
TYPE:  class
TOKEN: 0x2000147
FIELDS:
  public            System.String                   _shelfName  // 0x10
  public            System.String                   _shelfPath  // 0x18
  public            System.Boolean                  _defaultShelf  // 0x20
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_ShelfToolData>_tools  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ShelfTools
TYPE:  class
TOKEN: 0x2000148
FIELDS:
  private   static  System.Collections.Generic.List<HoudiniEngineUnity.HEU_Shelf>_shelves  // 0x0
  private   static  System.Boolean                  _shelvesLoaded  // 0x8
  private   static  System.Int32                    _currentSelectedShelf  // 0xC
  public    static  System.String                   TARGET_ALL  // 0x0
  public    static  System.String                   TARGET_UNITY  // 0x0
METHODS:
  System.Boolean AreShelvesLoaded()
  System.Void SetReloadShelves()
  System.Void ClearShelves()
  System.Int32 GetNumShelves()
  System.Int32 GetCurrentShelfIndex()
  System.Void SetCurrentShelf(System.Int32 index)
  HoudiniEngineUnity.HEU_Shelf GetShelf(System.Int32 index)
  HoudiniEngineUnity.HEU_Shelf GetShelf(System.String shelfName)
  System.String GetShelfStorageEntry(System.String shelfName, System.String shelfPath)
  System.Void GetSplitShelfEntry(System.String shelfEntry, System.String& shelfName, System.String& shelfPath)
  System.Void LoadShelves()
  System.Boolean LoadToolsFromDirectory(System.String folderPath, System.Collections.Generic.List<HoudiniEngineUnity.HEU_ShelfToolData>& tools)
  HoudiniEngineUnity.HEU_ShelfToolData LoadToolFromJsonFile(System.String jsonFilePath)
  HoudiniEngineUnity.HEU_ShelfToolData LoadToolFromJsonString(System.String json, System.String jsonFilePath)
  HoudiniEngineUnity.HEU_Shelf AddShelf(System.String shelfName, System.String shelfPath)
  System.Void RemoveShelf(System.Int32 shelfIndex)
  System.Void SaveShelf()
  System.Void ExecuteTool(System.Int32 toolSlot)
  System.Void ExecuteToolGenerator(System.String toolName, System.String toolPath, UnityEngine.Vector3 targetPosition, UnityEngine.Quaternion targetRotation, UnityEngine.Vector3 targetScale)
  System.Boolean IsValidInputMesh(UnityEngine.GameObject gameObject)
  System.Boolean IsValidInputHDA(UnityEngine.GameObject gameObject)
  System.Boolean ShouldUseHDA(UnityEngine.GameObject[] gameObjectList)
  System.Void ExecuteToolNoInput(System.String toolName, System.String toolPath)
  System.Void ExecuteToolOperatorSingle(System.String toolName, System.String toolPath, UnityEngine.GameObject[] inputObjects)
  System.Void ExecuteToolOperatorMultiple(System.String toolName, System.String toolPath, UnityEngine.GameObject[] inputObjects)
  System.Void ExecuteToolBatch(System.String toolName, System.String toolPath, UnityEngine.GameObject[] batchObjects)
  System.String GetToolResourcePath(HoudiniEngineUnity.HEU_ShelfToolData tool, System.String inPath, System.String ext)
  System.String GetToolIconPath(HoudiniEngineUnity.HEU_ShelfToolData tool, System.String inPath)
  System.String GetToolAssetPath(HoudiniEngineUnity.HEU_ShelfToolData tool, System.String inPath)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.JSONNodeType
TYPE:  struct
TOKEN: 0x200014A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.JSONNodeType Array  // 0x0
  public    static  HoudiniEngineUnity.JSONNodeType Object  // 0x0
  public    static  HoudiniEngineUnity.JSONNodeType String  // 0x0
  public    static  HoudiniEngineUnity.JSONNodeType Number  // 0x0
  public    static  HoudiniEngineUnity.JSONNodeType NullValue  // 0x0
  public    static  HoudiniEngineUnity.JSONNodeType Boolean  // 0x0
  public    static  HoudiniEngineUnity.JSONNodeType None  // 0x0
  public    static  HoudiniEngineUnity.JSONNodeType Custom  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.JSONTextMode
TYPE:  struct
TOKEN: 0x200014B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.JSONTextMode Compact  // 0x0
  public    static  HoudiniEngineUnity.JSONTextMode Indent  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.JSONNode
TYPE:  class
TOKEN: 0x200014C
FIELDS:
  public    static  System.Boolean                  forceASCII  // 0x0
  public    static  System.Boolean                  longAsString  // 0x1
  private   static  System.Text.StringBuilder       m_EscapeBuilder  // 0xFFFFFFFF
  public    static  HoudiniEngineUnity.JSONContainerTypeVectorContainerType  // 0x4
  public    static  HoudiniEngineUnity.JSONContainerTypeQuaternionContainerType  // 0x8
  public    static  HoudiniEngineUnity.JSONContainerTypeRectContainerType  // 0xC
METHODS:
  HoudiniEngineUnity.JSONNodeType get_Tag()
  HoudiniEngineUnity.JSONNode get_Item(System.Int32 aIndex)
  System.Void set_Item(System.Int32 aIndex, HoudiniEngineUnity.JSONNode value)
  HoudiniEngineUnity.JSONNode get_Item(System.String aKey)
  System.Void set_Item(System.String aKey, HoudiniEngineUnity.JSONNode value)
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Int32 get_Count()
  System.Boolean get_IsNumber()
  System.Boolean get_IsString()
  System.Boolean get_IsBoolean()
  System.Boolean get_IsNull()
  System.Boolean get_IsArray()
  System.Boolean get_IsObject()
  System.Boolean get_Inline()
  System.Void set_Inline(System.Boolean value)
  System.Void Add(System.String aKey, HoudiniEngineUnity.JSONNode aItem)
  System.Void Add(HoudiniEngineUnity.JSONNode aItem)
  HoudiniEngineUnity.JSONNode Remove(System.String aKey)
  HoudiniEngineUnity.JSONNode Remove(System.Int32 aIndex)
  HoudiniEngineUnity.JSONNode Remove(HoudiniEngineUnity.JSONNode aNode)
  System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode> get_Children()
  System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode> get_DeepChildren()
  System.String ToString()
  System.String ToString(System.Int32 aIndent)
  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode)
  HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator()
  System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode>> get_Linq()
  HoudiniEngineUnity.JSONNode.KeyEnumerator get_Keys()
  HoudiniEngineUnity.JSONNode.ValueEnumerator get_Values()
  System.Double get_AsDouble()
  System.Void set_AsDouble(System.Double value)
  System.Int32 get_AsInt()
  System.Void set_AsInt(System.Int32 value)
  System.Single get_AsFloat()
  System.Void set_AsFloat(System.Single value)
  System.Boolean get_AsBool()
  System.Void set_AsBool(System.Boolean value)
  System.Int64 get_AsLong()
  System.Void set_AsLong(System.Int64 value)
  HoudiniEngineUnity.JSONArray get_AsArray()
  HoudiniEngineUnity.JSONObject get_AsObject()
  HoudiniEngineUnity.JSONNode op_Implicit(System.String s)
  System.String op_Implicit(HoudiniEngineUnity.JSONNode d)
  HoudiniEngineUnity.JSONNode op_Implicit(System.Double n)
  System.Double op_Implicit(HoudiniEngineUnity.JSONNode d)
  HoudiniEngineUnity.JSONNode op_Implicit(System.Single n)
  System.Single op_Implicit(HoudiniEngineUnity.JSONNode d)
  HoudiniEngineUnity.JSONNode op_Implicit(System.Int32 n)
  System.Int32 op_Implicit(HoudiniEngineUnity.JSONNode d)
  HoudiniEngineUnity.JSONNode op_Implicit(System.Int64 n)
  System.Int64 op_Implicit(HoudiniEngineUnity.JSONNode d)
  HoudiniEngineUnity.JSONNode op_Implicit(System.Boolean b)
  System.Boolean op_Implicit(HoudiniEngineUnity.JSONNode d)
  HoudiniEngineUnity.JSONNode op_Implicit(System.Collections.Generic.KeyValuePair<System.String,HoudiniEngineUnity.JSONNode> aKeyValue)
  System.Boolean op_Equality(HoudiniEngineUnity.JSONNode a, System.Object b)
  System.Boolean op_Inequality(HoudiniEngineUnity.JSONNode a, System.Object b)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Text.StringBuilder get_EscapeBuilder()
  System.String Escape(System.String aText)
  HoudiniEngineUnity.JSONNode ParseElement(System.String token, System.Boolean quoted)
  HoudiniEngineUnity.JSONNode Parse(System.String aJSON)
  HoudiniEngineUnity.JSONNode GetContainer(HoudiniEngineUnity.JSONContainerType aType)
  HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Vector2 aVec)
  HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Vector3 aVec)
  HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Vector4 aVec)
  HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Quaternion aRot)
  HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.Rect aRect)
  HoudiniEngineUnity.JSONNode op_Implicit(UnityEngine.RectOffset aRect)
  UnityEngine.Vector2 op_Implicit(HoudiniEngineUnity.JSONNode aNode)
  UnityEngine.Vector3 op_Implicit(HoudiniEngineUnity.JSONNode aNode)
  UnityEngine.Vector4 op_Implicit(HoudiniEngineUnity.JSONNode aNode)
  UnityEngine.Quaternion op_Implicit(HoudiniEngineUnity.JSONNode aNode)
  UnityEngine.Rect op_Implicit(HoudiniEngineUnity.JSONNode aNode)
  UnityEngine.RectOffset op_Implicit(HoudiniEngineUnity.JSONNode aNode)
  UnityEngine.Vector2 ReadVector2(UnityEngine.Vector2 aDefault)
  UnityEngine.Vector2 ReadVector2(System.String aXName, System.String aYName)
  UnityEngine.Vector2 ReadVector2()
  HoudiniEngineUnity.JSONNode WriteVector2(UnityEngine.Vector2 aVec, System.String aXName, System.String aYName)
  UnityEngine.Vector3 ReadVector3(UnityEngine.Vector3 aDefault)
  UnityEngine.Vector3 ReadVector3(System.String aXName, System.String aYName, System.String aZName)
  UnityEngine.Vector3 ReadVector3()
  HoudiniEngineUnity.JSONNode WriteVector3(UnityEngine.Vector3 aVec, System.String aXName, System.String aYName, System.String aZName)
  UnityEngine.Vector4 ReadVector4(UnityEngine.Vector4 aDefault)
  UnityEngine.Vector4 ReadVector4()
  HoudiniEngineUnity.JSONNode WriteVector4(UnityEngine.Vector4 aVec)
  UnityEngine.Quaternion ReadQuaternion(UnityEngine.Quaternion aDefault)
  UnityEngine.Quaternion ReadQuaternion()
  HoudiniEngineUnity.JSONNode WriteQuaternion(UnityEngine.Quaternion aRot)
  UnityEngine.Rect ReadRect(UnityEngine.Rect aDefault)
  UnityEngine.Rect ReadRect()
  HoudiniEngineUnity.JSONNode WriteRect(UnityEngine.Rect aRect)
  UnityEngine.RectOffset ReadRectOffset(UnityEngine.RectOffset aDefault)
  UnityEngine.RectOffset ReadRectOffset()
  HoudiniEngineUnity.JSONNode WriteRectOffset(UnityEngine.RectOffset aRect)
  UnityEngine.Matrix4x4 ReadMatrix()
  HoudiniEngineUnity.JSONNode WriteMatrix(UnityEngine.Matrix4x4 aMatrix)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.JSONArray
TYPE:  class
TOKEN: 0x2000154
EXTENDS: JSONNode
FIELDS:
  private           System.Collections.Generic.List<HoudiniEngineUnity.JSONNode>m_List  // 0x10
  private           System.Boolean                  inline  // 0x18
METHODS:
  System.Boolean get_Inline()
  System.Void set_Inline(System.Boolean value)
  HoudiniEngineUnity.JSONNodeType get_Tag()
  System.Boolean get_IsArray()
  HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator()
  HoudiniEngineUnity.JSONNode get_Item(System.Int32 aIndex)
  System.Void set_Item(System.Int32 aIndex, HoudiniEngineUnity.JSONNode value)
  HoudiniEngineUnity.JSONNode get_Item(System.String aKey)
  System.Void set_Item(System.String aKey, HoudiniEngineUnity.JSONNode value)
  System.Int32 get_Count()
  System.Void Add(System.String aKey, HoudiniEngineUnity.JSONNode aItem)
  HoudiniEngineUnity.JSONNode Remove(System.Int32 aIndex)
  HoudiniEngineUnity.JSONNode Remove(HoudiniEngineUnity.JSONNode aNode)
  System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode> get_Children()
  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.JSONObject
TYPE:  class
TOKEN: 0x2000156
EXTENDS: JSONNode
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,HoudiniEngineUnity.JSONNode>m_Dict  // 0x10
  private           System.Boolean                  inline  // 0x18
METHODS:
  System.Boolean get_Inline()
  System.Void set_Inline(System.Boolean value)
  HoudiniEngineUnity.JSONNodeType get_Tag()
  System.Boolean get_IsObject()
  HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator()
  HoudiniEngineUnity.JSONNode get_Item(System.String aKey)
  System.Void set_Item(System.String aKey, HoudiniEngineUnity.JSONNode value)
  HoudiniEngineUnity.JSONNode get_Item(System.Int32 aIndex)
  System.Void set_Item(System.Int32 aIndex, HoudiniEngineUnity.JSONNode value)
  System.Int32 get_Count()
  System.Void Add(System.String aKey, HoudiniEngineUnity.JSONNode aItem)
  HoudiniEngineUnity.JSONNode Remove(System.String aKey)
  HoudiniEngineUnity.JSONNode Remove(System.Int32 aIndex)
  HoudiniEngineUnity.JSONNode Remove(HoudiniEngineUnity.JSONNode aNode)
  System.Collections.Generic.IEnumerable<HoudiniEngineUnity.JSONNode> get_Children()
  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.JSONString
TYPE:  class
TOKEN: 0x2000159
EXTENDS: JSONNode
FIELDS:
  private           System.String                   m_Data  // 0x10
METHODS:
  HoudiniEngineUnity.JSONNodeType get_Tag()
  System.Boolean get_IsString()
  HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator()
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Void .ctor(System.String aData)
  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: HoudiniEngineUnity.JSONNumber
TYPE:  class
TOKEN: 0x200015A
EXTENDS: JSONNode
FIELDS:
  private           System.Double                   m_Data  // 0x10
METHODS:
  HoudiniEngineUnity.JSONNodeType get_Tag()
  System.Boolean get_IsNumber()
  HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator()
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Double get_AsDouble()
  System.Void set_AsDouble(System.Double value)
  System.Int64 get_AsLong()
  System.Void set_AsLong(System.Int64 value)
  System.Void .ctor(System.Double aData)
  System.Void .ctor(System.String aData)
  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode)
  System.Boolean IsNumeric(System.Object value)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: HoudiniEngineUnity.JSONBool
TYPE:  class
TOKEN: 0x200015B
EXTENDS: JSONNode
FIELDS:
  private           System.Boolean                  m_Data  // 0x10
METHODS:
  HoudiniEngineUnity.JSONNodeType get_Tag()
  System.Boolean get_IsBoolean()
  HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator()
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Boolean get_AsBool()
  System.Void set_AsBool(System.Boolean value)
  System.Void .ctor(System.Boolean aData)
  System.Void .ctor(System.String aData)
  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: HoudiniEngineUnity.JSONNull
TYPE:  class
TOKEN: 0x200015C
EXTENDS: JSONNode
FIELDS:
  private   static  HoudiniEngineUnity.JSONNull     m_StaticInstance  // 0x0
  public    static  System.Boolean                  reuseSameInstance  // 0x8
METHODS:
  HoudiniEngineUnity.JSONNull CreateOrGet()
  System.Void .ctor()
  HoudiniEngineUnity.JSONNodeType get_Tag()
  System.Boolean get_IsNull()
  HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator()
  System.String get_Value()
  System.Void set_Value(System.String value)
  System.Boolean get_AsBool()
  System.Void set_AsBool(System.Boolean value)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode)
  System.Void .cctor()
END_CLASS

CLASS: HoudiniEngineUnity.JSONLazyCreator
TYPE:  class
TOKEN: 0x200015D
EXTENDS: JSONNode
FIELDS:
  private           HoudiniEngineUnity.JSONNode     m_Node  // 0x10
  private           System.String                   m_Key  // 0x18
METHODS:
  HoudiniEngineUnity.JSONNodeType get_Tag()
  HoudiniEngineUnity.JSONNode.Enumerator GetEnumerator()
  System.Void .ctor(HoudiniEngineUnity.JSONNode aNode)
  System.Void .ctor(HoudiniEngineUnity.JSONNode aNode, System.String aKey)
  T Set(T aVal)
  HoudiniEngineUnity.JSONNode get_Item(System.Int32 aIndex)
  System.Void set_Item(System.Int32 aIndex, HoudiniEngineUnity.JSONNode value)
  HoudiniEngineUnity.JSONNode get_Item(System.String aKey)
  System.Void set_Item(System.String aKey, HoudiniEngineUnity.JSONNode value)
  System.Void Add(HoudiniEngineUnity.JSONNode aItem)
  System.Void Add(System.String aKey, HoudiniEngineUnity.JSONNode aItem)
  System.Boolean op_Equality(HoudiniEngineUnity.JSONLazyCreator a, System.Object b)
  System.Boolean op_Inequality(HoudiniEngineUnity.JSONLazyCreator a, System.Object b)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Int32 get_AsInt()
  System.Void set_AsInt(System.Int32 value)
  System.Single get_AsFloat()
  System.Void set_AsFloat(System.Single value)
  System.Double get_AsDouble()
  System.Void set_AsDouble(System.Double value)
  System.Int64 get_AsLong()
  System.Void set_AsLong(System.Int64 value)
  System.Boolean get_AsBool()
  System.Void set_AsBool(System.Boolean value)
  HoudiniEngineUnity.JSONArray get_AsArray()
  HoudiniEngineUnity.JSONObject get_AsObject()
  System.Void WriteToStringBuilder(System.Text.StringBuilder aSB, System.Int32 aIndent, System.Int32 aIndentInc, HoudiniEngineUnity.JSONTextMode aMode)
END_CLASS

CLASS: HoudiniEngineUnity.JSON
TYPE:  class
TOKEN: 0x200015E
FIELDS:
METHODS:
  HoudiniEngineUnity.JSONNode Parse(System.String aJSON)
END_CLASS

CLASS: HoudiniEngineUnity.JSONContainerType
TYPE:  struct
TOKEN: 0x200015F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.JSONContainerTypeArray  // 0x0
  public    static  HoudiniEngineUnity.JSONContainerTypeObject  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_TerrainUtility
TYPE:  class
TOKEN: 0x2000160
FIELDS:
METHODS:
  System.Boolean GenerateTerrainFromVolume(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HAPI_VolumeInfo& volumeInfo, System.Int32 geoID, System.Int32 partID, UnityEngine.GameObject gameObject, UnityEngine.TerrainData& terrainData, UnityEngine.Vector3& volumePositionOffset, UnityEngine.Terrain& terrain, System.String bakedMaterialPath)
  System.Void SetTerrainMaterial(UnityEngine.Terrain terrain, System.String specifiedMaterialName, System.String bakedMaterialPath)
  System.String GetDefaultTerrainShaderName()
  System.String GetDefaultTerrainMaterialPath()
  System.Single[] GetNormalizedHeightmapFromPartWithMinMax(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32 heightMapWidth, System.Int32 heightMapHeight, System.Single& minHeight, System.Single& maxHeight, System.Single& heightRange, System.Boolean bUseHeightRangeOverride)
  System.Int32[,] GetDetailMapFromPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32& detailResolution)
  System.Boolean GetHeightmapFromPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 xLength, System.Int32 yLength, System.Int32 geoID, System.Int32 partID, System.Single[]& heightValues, System.Single& minHeight, System.Single& maxHeight)
  System.Single[,] ConvertHeightMapHoudiniToUnity(System.Int32 heightMapWidth, System.Int32 heightMapHeight, System.Single[] heightValues)
  System.Single[,,] ConvertHeightFieldToAlphaMap(System.Int32 heightMapWidth, System.Int32 heightMapHeight, System.Collections.Generic.List<System.Single[]> heightFields)
  System.Single[,,] AppendConvertedHeightFieldToAlphaMap(System.Int32 heightMapWidth, System.Int32 heightMapHeight, System.Single[,,] existingAlphaMaps, System.Collections.Generic.List<System.Single[]> heightFields, System.Single[] strengths, System.Collections.Generic.List<System.Int32> alphaMapIndices)
  UnityEngine.Vector3 GetVolumePositionOffset(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.Vector3 volumePosition, System.Single terrainSizeX, System.Single heightMapSize, System.Int32 mapWidth, System.Int32 mapHeight, System.Single minHeight)
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_TreePrototypeInfo> GetTreePrototypeInfosFromPart(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID)
  System.Void PopulateScatterTrees(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32 pointCount, HoudiniEngineUnity.HEU_VolumeScatterTrees& scatterTrees, System.Boolean throwWarningIfNoTileAttribute)
  System.Void ApplyScatterTrees(UnityEngine.TerrainData terrainData, HoudiniEngineUnity.HEU_VolumeScatterTrees scatterTrees, System.Int32 tileIndex)
  System.Void PopulateDetailPrototype(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_DetailPrototype& detailPrototype)
  System.Void PopulateDetailProperties(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_DetailProperties& detailProperties)
  System.Void ApplyDetailLayers(UnityEngine.Terrain terrain, UnityEngine.TerrainData terrainData, HoudiniEngineUnity.HEU_DetailProperties detailProperties, System.Collections.Generic.List<HoudiniEngineUnity.HEU_DetailPrototype> heuDetailPrototypes, System.Collections.Generic.List<System.Int32[,]> convertedDetailMaps)
  System.Int32 GetTerrainLayerIndexByName(System.String layerName, UnityEngine.TerrainLayer[] terrainLayers)
  System.Int32 GetTerrainLayerIndex(UnityEngine.TerrainLayer layer, UnityEngine.TerrainLayer[] terrainLayers)
  System.Boolean VolumeLayerHasAttributes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID)
  HoudiniEngineUnity.HFLayerType GetHeightfieldLayerType(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String volumeName)
  System.Single GetHeightRangeFromHeightfield(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID)
  System.String GetTerrainDataExportPathFromHeightfieldAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID)
  System.Single[] ResampleData(System.Single[] data, System.Int32 oldWidth, System.Int32 oldHeight, System.Int32 newWidth, System.Int32 newHeight)
  System.Boolean GetAttributeTile(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32& outTileAttribute)
END_CLASS

CLASS: HoudiniEngineUnity.IEquivable`1
TYPE:  interface
TOKEN: 0x2000161
FIELDS:
METHODS:
  System.Boolean IsEquivalentTo(T other)
END_CLASS

CLASS: HoudiniEngineUnity.IEquivableWrapperClass`1
TYPE:  interface
TOKEN: 0x2000162
FIELDS:
METHODS:
  System.Boolean IsNull()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_TestHelpers
TYPE:  class
TOKEN: 0x2000163
FIELDS:
METHODS:
  System.Boolean AssertTrueLogEquivalent(T a, T b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3, HoudiniEngineUnity.HEU_TestHelpers.RequireStruct<T> _)
  System.Boolean AssertTrueLogEquivalent(UnityEngine.GameObject a, UnityEngine.GameObject b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  System.Boolean AssertTrueLogEquivalent(HoudiniEngineUnity.IEquivable<T> a, HoudiniEngineUnity.IEquivable<T> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  System.Boolean AssertTrueLogEquivalent(HoudiniEngineUnity.IEquivableWrapperClass<T> a, HoudiniEngineUnity.IEquivableWrapperClass<T> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  System.Boolean AssertTrueLogEquivalent(System.String a, System.String b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  System.Boolean AssertTrueLogEquivalent(System.Collections.Generic.List<T> a, System.Collections.Generic.List<T> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3, HoudiniEngineUnity.HEU_TestHelpers.RequireStruct<T> _)
  System.Boolean AssertTrueLogEquivalent(System.Collections.Generic.List<T> a, System.Collections.Generic.List<T> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3, HoudiniEngineUnity.HEU_TestHelpers.RequireClass<T> _)
  System.Boolean AssertTrueLogEquivalent(System.Collections.Generic.List<HoudiniEngineUnity.IEquivable<T>> a, System.Collections.Generic.List<HoudiniEngineUnity.IEquivable<T>> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  System.Boolean AssertTrueLogEquivalent(System.Collections.Generic.List<HoudiniEngineUnity.IEquivableWrapperClass<T>> a, System.Collections.Generic.List<HoudiniEngineUnity.IEquivableWrapperClass<T>> b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  System.Boolean AssertTrueLogEquivalent(T[] a, T[] b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  System.Boolean AssertTrueLogEquivalent(System.String[] a, System.String[] b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  System.Boolean AssertTrueLogEquivalent(HoudiniEngineUnity.IEquivable<T>[] a, HoudiniEngineUnity.IEquivable<T>[] b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  System.Boolean AssertTrueLogEquivalent(HoudiniEngineUnity.IEquivableWrapperClass<T>[] a, HoudiniEngineUnity.IEquivableWrapperClass<T>[] b, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  System.Void PrintTestLogAndSetResult(System.Boolean expression, System.Boolean& result, System.String header, System.String subject, System.String optional1, System.String optional2, System.String optional3)
  System.Boolean ShouldBeTested(T a, T b, System.Boolean& bResult, System.String header, System.String subject)
  System.Boolean ShouldBeTested(UnityEngine.GameObject a, UnityEngine.GameObject b, System.Boolean& bResult, System.String header, System.String subject)
  System.Boolean ShouldBeTested(HoudiniEngineUnity.IEquivable<T> a, HoudiniEngineUnity.IEquivable<T> b, System.Boolean& bResult, System.String header, System.String subject)
  System.Boolean ShouldBeTested(HoudiniEngineUnity.IEquivableWrapperClass<T> a, HoudiniEngineUnity.IEquivableWrapperClass<T> b, System.Boolean& bResult, System.String header, System.String subject)
  System.Boolean ShouldBeTested(System.Collections.Generic.List<T> a, System.Collections.Generic.List<T> b, System.Boolean& bResult, System.String header, System.String subject)
  System.Boolean ShouldBeTested(T[] a, T[] b, System.Boolean& bResult, System.String header, System.String subject)
  System.Boolean ShouldBeTested(System.String a, System.String b, System.Boolean& bResult, System.String header, System.String subject)
  System.Boolean TestOutputObjectEquivalence(UnityEngine.GameObject a, UnityEngine.GameObject b)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_AssetInfo
TYPE:  class
TOKEN: 0x2000166
FIELDS:
  public            HoudiniEngineUnity.HAPI_AssetInfoself  // 0x10
METHODS:
  System.Void .ctor(HoudiniEngineUnity.HAPI_AssetInfo self)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_AssetInfo other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_AssetInfo_Extensions
TYPE:  class
TOKEN: 0x2000167
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_HAPI_AssetInfo ToTestObject(HoudiniEngineUnity.HAPI_AssetInfo self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_NodeInfo
TYPE:  class
TOKEN: 0x2000168
FIELDS:
  public            HoudiniEngineUnity.HAPI_NodeInfoself  // 0x10
METHODS:
  System.Void .ctor(HoudiniEngineUnity.HAPI_NodeInfo self)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_NodeInfo other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_NodeInfo_Extensions
TYPE:  class
TOKEN: 0x2000169
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_HAPI_NodeInfo ToTestObject(HoudiniEngineUnity.HAPI_NodeInfo self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_ObjectInfo
TYPE:  class
TOKEN: 0x200016A
FIELDS:
  public            HoudiniEngineUnity.HAPI_ObjectInfoself  // 0x10
METHODS:
  System.Void .ctor(HoudiniEngineUnity.HAPI_ObjectInfo self)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_ObjectInfo other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_ObjectInfo_Extensions
TYPE:  class
TOKEN: 0x200016B
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_HAPI_ObjectInfo ToTestObject(HoudiniEngineUnity.HAPI_ObjectInfo self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_Transform
TYPE:  class
TOKEN: 0x200016C
FIELDS:
  public            HoudiniEngineUnity.HAPI_Transformself  // 0x10
METHODS:
  System.Void .ctor(HoudiniEngineUnity.HAPI_Transform self)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_Transform other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_Transform_Extensions
TYPE:  class
TOKEN: 0x200016D
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_HAPI_Transform ToTestObject(HoudiniEngineUnity.HAPI_Transform self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_GeoInfo
TYPE:  class
TOKEN: 0x200016E
FIELDS:
  public            HoudiniEngineUnity.HAPI_GeoInfo self  // 0x10
METHODS:
  System.Void .ctor(HoudiniEngineUnity.HAPI_GeoInfo self)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_GeoInfo other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_GeoInfo_Extensions
TYPE:  class
TOKEN: 0x200016F
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_HAPI_GeoInfo ToTestObject(HoudiniEngineUnity.HAPI_GeoInfo self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_AttributeInfo
TYPE:  class
TOKEN: 0x2000170
FIELDS:
  public            HoudiniEngineUnity.HAPI_AttributeInfoself  // 0x10
METHODS:
  System.Void .ctor(HoudiniEngineUnity.HAPI_AttributeInfo self)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_AttributeInfo other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_AttributeInfo_Extensions
TYPE:  class
TOKEN: 0x2000171
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_HAPI_AttributeInfo ToTestObject(HoudiniEngineUnity.HAPI_AttributeInfo self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_TransformEuler
TYPE:  class
TOKEN: 0x2000172
FIELDS:
  public            HoudiniEngineUnity.HAPI_TransformEulerself  // 0x10
METHODS:
  System.Void .ctor(HoudiniEngineUnity.HAPI_TransformEuler self)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_TransformEuler other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_TransformEuler_Extensions
TYPE:  class
TOKEN: 0x2000173
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_HAPI_TransformEuler ToTestObject(HoudiniEngineUnity.HAPI_TransformEuler self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_ParmInfo
TYPE:  class
TOKEN: 0x2000174
FIELDS:
  public            HoudiniEngineUnity.HAPI_ParmInfoself  // 0x10
METHODS:
  System.Void .ctor(HoudiniEngineUnity.HAPI_ParmInfo self)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_HAPI_ParmInfo other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_HAPI_ParmInfo_Extensions
TYPE:  class
TOKEN: 0x2000175
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_HAPI_ParmInfo ToTestObject(HoudiniEngineUnity.HAPI_ParmInfo self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_LODGroup
TYPE:  class
TOKEN: 0x2000176
FIELDS:
  public            UnityEngine.LODGroup            self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.LODGroup self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_LODGroup other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_LODGroup_Extensions
TYPE:  class
TOKEN: 0x2000177
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_LODGroup ToTestObject(UnityEngine.LODGroup self)
  HoudiniEngineUnity.Test_LODGroup[] ToTestObject(UnityEngine.LODGroup[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_LODGroup> ToTestObject(System.Collections.Generic.List<UnityEngine.LODGroup> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Transform
TYPE:  class
TOKEN: 0x2000179
FIELDS:
  public            UnityEngine.Transform           self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.Transform self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Transform other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Transform_Extensions
TYPE:  class
TOKEN: 0x200017A
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_Transform ToTestObject(UnityEngine.Transform self)
  HoudiniEngineUnity.Test_Transform[] ToTestObject(UnityEngine.Transform[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_Transform> ToTestObject(System.Collections.Generic.List<UnityEngine.Transform> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Material
TYPE:  class
TOKEN: 0x200017C
FIELDS:
  public            UnityEngine.Material            self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.Material self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Material other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Material_Extensions
TYPE:  class
TOKEN: 0x200017D
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_Material ToTestObject(UnityEngine.Material self)
  HoudiniEngineUnity.Test_Material[] ToTestObject(UnityEngine.Material[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_Material> ToTestObject(System.Collections.Generic.List<UnityEngine.Material> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Collider
TYPE:  class
TOKEN: 0x200017F
FIELDS:
  public            UnityEngine.Collider            self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.Collider self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Collider other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Collider_Extensions
TYPE:  class
TOKEN: 0x2000180
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_Collider ToTestObject(UnityEngine.Collider self)
  HoudiniEngineUnity.Test_Collider[] ToTestObject(UnityEngine.Collider[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_Collider> ToTestObject(System.Collections.Generic.List<UnityEngine.Collider> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_BoxCollider
TYPE:  class
TOKEN: 0x2000182
FIELDS:
  public            UnityEngine.BoxCollider         self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.BoxCollider self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_BoxCollider other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_BoxCollider_Extensions
TYPE:  class
TOKEN: 0x2000183
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_BoxCollider ToTestObject(UnityEngine.BoxCollider self)
  HoudiniEngineUnity.Test_BoxCollider[] ToTestObject(UnityEngine.BoxCollider[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_BoxCollider> ToTestObject(System.Collections.Generic.List<UnityEngine.BoxCollider> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_SphereCollider
TYPE:  class
TOKEN: 0x2000185
FIELDS:
  public            UnityEngine.SphereCollider      self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.SphereCollider self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_SphereCollider other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_SphereCollider_Extensions
TYPE:  class
TOKEN: 0x2000186
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_SphereCollider ToTestObject(UnityEngine.SphereCollider self)
  HoudiniEngineUnity.Test_SphereCollider[] ToTestObject(UnityEngine.SphereCollider[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_SphereCollider> ToTestObject(System.Collections.Generic.List<UnityEngine.SphereCollider> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_CapsuleCollider
TYPE:  class
TOKEN: 0x2000188
FIELDS:
  public            UnityEngine.CapsuleCollider     self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.CapsuleCollider self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_CapsuleCollider other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_CapsuleCollider_Extensions
TYPE:  class
TOKEN: 0x2000189
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_CapsuleCollider ToTestObject(UnityEngine.CapsuleCollider self)
  HoudiniEngineUnity.Test_CapsuleCollider[] ToTestObject(UnityEngine.CapsuleCollider[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_CapsuleCollider> ToTestObject(System.Collections.Generic.List<UnityEngine.CapsuleCollider> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_MeshCollider
TYPE:  class
TOKEN: 0x200018B
FIELDS:
  public            UnityEngine.MeshCollider        self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.MeshCollider self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_MeshCollider other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_MeshCollider_Extensions
TYPE:  class
TOKEN: 0x200018C
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_MeshCollider ToTestObject(UnityEngine.MeshCollider self)
  HoudiniEngineUnity.Test_MeshCollider[] ToTestObject(UnityEngine.MeshCollider[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_MeshCollider> ToTestObject(System.Collections.Generic.List<UnityEngine.MeshCollider> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Mesh
TYPE:  class
TOKEN: 0x200018E
FIELDS:
  public            UnityEngine.Mesh                self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.Mesh self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Mesh other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Mesh_Extensions
TYPE:  class
TOKEN: 0x200018F
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_Mesh ToTestObject(UnityEngine.Mesh self)
  HoudiniEngineUnity.Test_Mesh[] ToTestObject(UnityEngine.Mesh[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_Mesh> ToTestObject(System.Collections.Generic.List<UnityEngine.Mesh> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_MeshRenderer
TYPE:  class
TOKEN: 0x2000191
FIELDS:
  public            UnityEngine.MeshRenderer        self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.MeshRenderer self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_MeshRenderer other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_MeshRenderer_Extensions
TYPE:  class
TOKEN: 0x2000192
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_MeshRenderer ToTestObject(UnityEngine.MeshRenderer self)
  HoudiniEngineUnity.Test_MeshRenderer[] ToTestObject(UnityEngine.MeshRenderer[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_MeshRenderer> ToTestObject(System.Collections.Generic.List<UnityEngine.MeshRenderer> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_MeshFilter
TYPE:  class
TOKEN: 0x2000194
FIELDS:
  public            UnityEngine.MeshFilter          self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.MeshFilter self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_MeshFilter other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_MeshFilter_Extensions
TYPE:  class
TOKEN: 0x2000195
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_MeshFilter ToTestObject(UnityEngine.MeshFilter self)
  HoudiniEngineUnity.Test_MeshFilter[] ToTestObject(UnityEngine.MeshFilter[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_MeshFilter> ToTestObject(System.Collections.Generic.List<UnityEngine.MeshFilter> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_LayerMask
TYPE:  class
TOKEN: 0x2000197
FIELDS:
  public            UnityEngine.LayerMask           self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.LayerMask self)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_LayerMask other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_LayerMask_Extensions
TYPE:  class
TOKEN: 0x2000198
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_LayerMask ToTestObject(UnityEngine.LayerMask self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Gradient
TYPE:  class
TOKEN: 0x2000199
FIELDS:
  public            UnityEngine.Gradient            self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.Gradient self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Gradient other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Gradient_Extensions
TYPE:  class
TOKEN: 0x200019A
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_Gradient ToTestObject(UnityEngine.Gradient self)
  HoudiniEngineUnity.Test_Gradient[] ToTestObject(UnityEngine.Gradient[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_Gradient> ToTestObject(System.Collections.Generic.List<UnityEngine.Gradient> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_AnimationCurve
TYPE:  class
TOKEN: 0x200019C
FIELDS:
  public            UnityEngine.AnimationCurve      self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.AnimationCurve self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_AnimationCurve other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_AnimationCurve_Extensions
TYPE:  class
TOKEN: 0x200019D
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_AnimationCurve ToTestObject(UnityEngine.AnimationCurve self)
  HoudiniEngineUnity.Test_AnimationCurve[] ToTestObject(UnityEngine.AnimationCurve[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_AnimationCurve> ToTestObject(System.Collections.Generic.List<UnityEngine.AnimationCurve> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_TerrainLayer
TYPE:  class
TOKEN: 0x200019F
FIELDS:
  public            UnityEngine.TerrainLayer        self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.TerrainLayer self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_TerrainLayer other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_TerrainLayer_Extensions
TYPE:  class
TOKEN: 0x20001A0
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_TerrainLayer ToTestObject(UnityEngine.TerrainLayer self)
  HoudiniEngineUnity.Test_TerrainLayer[] ToTestObject(UnityEngine.TerrainLayer[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_TerrainLayer> ToTestObject(System.Collections.Generic.List<UnityEngine.TerrainLayer> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Texture2D
TYPE:  class
TOKEN: 0x20001A2
FIELDS:
  public            UnityEngine.Texture2D           self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.Texture2D self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Texture2D other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Texture2D_Extensions
TYPE:  class
TOKEN: 0x20001A3
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_Texture2D ToTestObject(UnityEngine.Texture2D self)
  HoudiniEngineUnity.Test_Texture2D[] ToTestObject(UnityEngine.Texture2D[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_Texture2D> ToTestObject(System.Collections.Generic.List<UnityEngine.Texture2D> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_TreeInstance
TYPE:  class
TOKEN: 0x20001A5
FIELDS:
  public            UnityEngine.TreeInstance        self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.TreeInstance self)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_TreeInstance other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_TreeInstance_Extensions
TYPE:  class
TOKEN: 0x20001A6
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_TreeInstance ToTestObject(UnityEngine.TreeInstance self)
  HoudiniEngineUnity.Test_TreeInstance[] ToTestObject(UnityEngine.TreeInstance[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_TreeInstance> ToTestObject(System.Collections.Generic.List<UnityEngine.TreeInstance> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_TerrainData
TYPE:  class
TOKEN: 0x20001A8
FIELDS:
  public            UnityEngine.TerrainData         self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.TerrainData self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_TerrainData other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_TerrainData_Extensions
TYPE:  class
TOKEN: 0x20001A9
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_TerrainData ToTestObject(UnityEngine.TerrainData self)
  HoudiniEngineUnity.Test_TerrainData[] ToTestObject(UnityEngine.TerrainData[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_TerrainData> ToTestObject(System.Collections.Generic.List<UnityEngine.TerrainData> self)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Terrain
TYPE:  class
TOKEN: 0x20001AB
FIELDS:
  public            UnityEngine.Terrain             self  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.Terrain self)
  System.Boolean IsNull()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.Test_Terrain other)
END_CLASS

CLASS: HoudiniEngineUnity.Test_Terrain_Extensions
TYPE:  class
TOKEN: 0x20001AC
FIELDS:
METHODS:
  HoudiniEngineUnity.Test_Terrain ToTestObject(UnityEngine.Terrain self)
  HoudiniEngineUnity.Test_Terrain[] ToTestObject(UnityEngine.Terrain[] self)
  System.Collections.Generic.List<HoudiniEngineUnity.Test_Terrain> ToTestObject(System.Collections.Generic.List<UnityEngine.Terrain> self)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ToolsInfo
TYPE:  class
TOKEN: 0x20001AE
EXTENDS: ScriptableObject
FIELDS:
  public            System.Single                   _paintBrushSize  // 0x18
  public            System.Single                   _paintBrushOpacity  // 0x1C
  public            System.Int32[]                  _paintIntValue  // 0x20
  public            System.Single[]                 _paintFloatValue  // 0x28
  public            System.String[]                 _paintStringValue  // 0x30
  public            System.Int32                    _lastAttributesGeoID  // 0x38
  public            System.Int32                    _lastAttributesPartID  // 0x3C
  public            System.String                   _lastAttributeNodeName  // 0x40
  public            System.String                   _lastAttributeName  // 0x48
  public            UnityEngine.Color               _brushHandleColor  // 0x50
  public            UnityEngine.Color               _affectedAreaPaintColor  // 0x60
  public            System.Boolean                  _liveUpdate  // 0x70
  public            System.Boolean                  _isPainting  // 0x71
  public            System.Single                   _editPointBoxSize  // 0x74
  public            UnityEngine.Color               _editPointBoxUnselectedColor  // 0x78
  public            UnityEngine.Color               _editPointBoxSelectedColor  // 0x88
  public            System.Boolean                  _recacheRequired  // 0x98
  public            HoudiniEngineUnity.HEU_ToolsInfo.PaintMergeMode_paintMergeMode  // 0x9C
  public            System.Boolean                  _showOnlyEditGeometry  // 0xA0
  public            System.Boolean                  _alwaysCookUpstream  // 0xA1
  public            HoudiniEngineUnity.HEU_ToolsInfo.PaintMeshVisibility_paintMeshVisiblity  // 0xA4
METHODS:
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_ToolsInfo other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HFLayerType
TYPE:  struct
TOKEN: 0x20001B1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  HoudiniEngineUnity.HFLayerType  DEFAULT  // 0x0
  public    static  HoudiniEngineUnity.HFLayerType  HEIGHT  // 0x0
  public    static  HoudiniEngineUnity.HFLayerType  MASK  // 0x0
  public    static  HoudiniEngineUnity.HFLayerType  DETAIL  // 0x0
METHODS:
END_CLASS

CLASS: HoudiniEngineUnity.HEU_VolumeLayer
TYPE:  class
TOKEN: 0x20001B2
FIELDS:
  public            System.String                   _layerName  // 0x10
  public            System.Single                   _strength  // 0x18
  public            System.Boolean                  _uiExpanded  // 0x1C
  public            System.Int32                    _tile  // 0x20
  public            System.Int32                    _xLength  // 0x24
  public            System.Int32                    _yLength  // 0x28
  public            System.Boolean                  _hasLayerAttributes  // 0x2C
  public            UnityEngine.TerrainLayer        _terrainLayer  // 0x30
  public            HoudiniEngineUnity.HFLayerType  _layerType  // 0x38
  public            HoudiniEngineUnity.HEU_DetailPrototype_detailPrototype  // 0x40
  private           HoudiniEngineUnity.HEU_PartData _part  // 0x48
METHODS:
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_VolumeLayer other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_VolumeScatterTrees
TYPE:  class
TOKEN: 0x20001B3
FIELDS:
  public            System.Collections.Generic.List<HoudiniEngineUnity.HEU_TreePrototypeInfo>_treePrototypInfos  // 0x10
  public            UnityEngine.Color32[]           _colors  // 0x18
  public            System.Single[]                 _heightScales  // 0x20
  public            UnityEngine.Color32[]           _lightmapColors  // 0x28
  public            UnityEngine.Vector3[]           _positions  // 0x30
  public            System.Int32[]                  _prototypeIndices  // 0x38
  public            System.Single[]                 _rotations  // 0x40
  public            System.Single[]                 _widthScales  // 0x48
  public            System.Int32[]                  _terrainTiles  // 0x50
METHODS:
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_VolumeScatterTrees other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_TreePrototypeInfo
TYPE:  class
TOKEN: 0x20001B4
FIELDS:
  public            System.String                   _prefabPath  // 0x10
  public            System.Single                   _bendfactor  // 0x18
METHODS:
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_TreePrototypeInfo other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_DetailProperties
TYPE:  class
TOKEN: 0x20001B5
FIELDS:
  public            System.Single                   _detailDistance  // 0x10
  public            System.Single                   _detailDensity  // 0x14
  public            System.Int32                    _detailResolution  // 0x18
  public            System.Int32                    _detailResolutionPerPatch  // 0x1C
METHODS:
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_DetailProperties other)
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_DetailPrototype
TYPE:  class
TOKEN: 0x20001B6
FIELDS:
  public            System.String                   _prototypePrefab  // 0x10
  public            System.String                   _prototypeTexture  // 0x18
  public            System.Single                   _bendFactor  // 0x20
  public            UnityEngine.Color               _dryColor  // 0x24
  public            UnityEngine.Color               _healthyColor  // 0x34
  public            System.Single                   _maxHeight  // 0x44
  public            System.Single                   _maxWidth  // 0x48
  public            System.Single                   _minHeight  // 0x4C
  public            System.Single                   _minWidth  // 0x50
  public            System.Single                   _noiseSpread  // 0x54
  public            System.Int32                    _renderMode  // 0x58
METHODS:
  System.Void .ctor()
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_DetailPrototype other)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_VolumeCache
TYPE:  class
TOKEN: 0x20001B7
EXTENDS: ScriptableObject
FIELDS:
  private           HoudiniEngineUnity.HEU_GeoNode  _ownerNode  // 0x18
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayer>_layers  // 0x20
  private           System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayer>_updatedLayers  // 0x28
  private           System.Int32                    _tileIndex  // 0x30
  private           System.Boolean                  _isDirty  // 0x34
  private           System.String                   _geoName  // 0x38
  private           System.String                   _objName  // 0x40
  public            System.Boolean                  _uiExpanded  // 0x48
  private           UnityEngine.TerrainData         _terrainData  // 0x50
  private           HoudiniEngineUnity.HEU_VolumeScatterTrees_scatterTrees  // 0x58
  private           HoudiniEngineUnity.HEU_DetailProperties_detailProperties  // 0x60
  private           HoudiniEngineUnity.HEU_HoudiniAsset_parentAsset  // 0x68
METHODS:
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeLayer> get_Layers()
  System.Int32 get_TileIndex()
  System.String get_ObjectName()
  System.String get_GeoName()
  UnityEngine.TerrainData get_TerrainData()
  HoudiniEngineUnity.HEU_VolumeScatterTrees get_ScatterTrees()
  HoudiniEngineUnity.HEU_DetailProperties get_DetailProperties()
  HoudiniEngineUnity.HEU_HoudiniAsset get_ParentAsset()
  System.Boolean get_IsDirty()
  System.Void set_IsDirty(System.Boolean value)
  System.Boolean get_UIExpanded()
  System.Void set_UIExpanded(System.Boolean value)
  HoudiniEngineUnity.HEU_SessionBase GetSession()
  System.Void Recook()
  System.Void ResetParameters()
  HoudiniEngineUnity.HEU_VolumeLayer GetLayer(System.String layerName)
  System.Void PopulatePreset(HoudiniEngineUnity.HEU_VolumeCachePreset cachePreset)
  System.Boolean ApplyPreset(HoudiniEngineUnity.HEU_VolumeCachePreset volumeCachePreset)
  System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> UpdateVolumeCachesFromParts(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_GeoNode ownerNode, System.Collections.Generic.List<HoudiniEngineUnity.HEU_PartData> volumeParts, System.Collections.Generic.List<HoudiniEngineUnity.HEU_VolumeCache> volumeCaches)
  System.Void Initialize(HoudiniEngineUnity.HEU_GeoNode ownerNode, System.Int32 tileIndex)
  System.Void StartUpdateLayers()
  System.Void FinishUpdateLayers()
  System.Void GetPartLayerAttributes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_VolumeLayer layer)
  System.Boolean LoadLayerTextureFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Texture2D& outTexture)
  System.Boolean LoadLayerFloatFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, System.Single& floatValue)
  System.Boolean LoadLayerColorFromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Color& colorValue)
  System.Boolean LoadLayerVector2FromAttribute(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.String attrName, UnityEngine.Vector2& vectorValue)
  System.Void UpdateLayerFromPart(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_PartData part)
  System.Void GenerateTerrainWithAlphamaps(HoudiniEngineUnity.HEU_SessionBase session, HoudiniEngineUnity.HEU_HoudiniAsset houdiniAsset, System.Boolean bRebuild)
  System.Void LoadLayerPropertiesFromAttributes(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, UnityEngine.TerrainLayer terrainLayer, System.Boolean bNewTerrainLayer, UnityEngine.Texture2D defaultTexture)
  System.Void PopulateScatterTrees(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, System.Int32 pointCount, System.Boolean throwWarningIfNoTileAttribute)
  System.Void PopulateDetailPrototype(HoudiniEngineUnity.HEU_SessionBase session, System.Int32 geoID, System.Int32 partID, HoudiniEngineUnity.HEU_VolumeLayer layer)
  System.Void CopyValuesTo(HoudiniEngineUnity.HEU_VolumeCache destCache)
  System.Void CopyDetailProperties(HoudiniEngineUnity.HEU_DetailProperties srcProp, HoudiniEngineUnity.HEU_DetailProperties destProp)
  System.Void CopyLayer(HoudiniEngineUnity.HEU_VolumeLayer srcLayer, HoudiniEngineUnity.HEU_VolumeLayer destLayer)
  System.Void CopyPrototype(HoudiniEngineUnity.HEU_DetailPrototype srcProto, HoudiniEngineUnity.HEU_DetailPrototype destProto)
  UnityEngine.Texture2D LoadDefaultSplatTexture()
  UnityEngine.Texture2D LoadAssetTexture(System.String path)
  System.Boolean IsEquivalentTo(HoudiniEngineUnity.HEU_VolumeCache other)
  System.Void .ctor()
END_CLASS

