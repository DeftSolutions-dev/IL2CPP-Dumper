// ========================================================
// Dumped by @desirepro
// Assembly: UI.Gameplay.Beyond.dll
// Classes:  178
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UIEquipRotHelper
TYPE:  class
TOKEN: 0x2000002
EXTENDS: TickableUIMono
FIELDS:
  private           UnityEngine.Transform           _rotParent  // 0x68
  private           UnityEngine.Transform           _rotTarget  // 0x70
  private           UnityEngine.Transform           _posTarget  // 0x78
  private           System.Single                   _maxLength  // 0x80
  private           System.Collections.Generic.List<UnityEngine.Transform>_slots  // 0x88
  private           System.Collections.Generic.List<UnityEngine.Transform>_rotRoots  // 0x90
  private           System.Single                   _tweenTime  // 0x98
  private           UnityEngine.Vector3             m_desRot  // 0x9C
  private           UnityEngine.Vector3             m_desZero  // 0xA8
  private           System.Int32                    m_curIndex  // 0xB4
  private           System.Int32                    m_maxNum  // 0xB8
  private           System.Boolean                  <playing>k__BackingField  // 0xBC
METHODS:
  Beyond.TickType get_tickOption()
  System.Void set_playing(System.Boolean value)
  System.Boolean get_playing()
  UnityEngine.Vector3 _ClampRot(UnityEngine.Vector3 rot)
  UnityEngine.Vector3 _GetNearZero(UnityEngine.Vector3 rot)
  System.Void _Init()
  System.Void OnAwake()
  System.Void Tick(System.Single deltaTime)
  System.Void SelectPart(System.Int32 index)
  System.Void OnRelease()
  System.Void .ctor()
  System.Void <SelectPart>b__22_0()
END_CLASS

CLASS: UIWatchPanelCut
TYPE:  class
TOKEN: 0x2000003
EXTENDS: TickableUIMono
FIELDS:
  private           UnityEngine.Vector3             m_watchpanelPos  // 0x68
  private           UnityEngine.Vector3             m_watchpanelDir  // 0x74
  private           UnityEngine.Vector3             m_watchpanelRadius  // 0x80
  public            System.Single                   minimapRadius  // 0x8C
  public            System.Single                   eclosionRange  // 0x90
METHODS:
  Beyond.TickType get_tickOption()
  System.Void Start()
  UnityEngine.Vector3 GetIntersectWithLineAndPlane(UnityEngine.Vector3 point, UnityEngine.Vector3 direct, UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint)
  System.Void Tick(System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: CommonTrackItemState
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.CommonTrackerUpdate.CommonTrackItemStateShow  // 0x0
  public    static  Beyond.UI.CommonTrackerUpdate.CommonTrackItemStateHide  // 0x0
  public    static  Beyond.UI.CommonTrackerUpdate.CommonTrackItemStateShowToHide  // 0x0
METHODS:
END_CLASS

CLASS: CommonTrackerDataState
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.CommonTrackerUpdate.CommonTrackerDataStateActive  // 0x0
  public    static  Beyond.UI.CommonTrackerUpdate.CommonTrackerDataStateInActive  // 0x0
METHODS:
END_CLASS

CLASS: CommonTrackerData
TYPE:  class
TOKEN: 0x2000014
FIELDS:
  public            Beyond.UI.CommonTrackerUpdate.CommonTrackerDataStateactiveState  // 0x10
  public            Beyond.Gameplay.CommonTrackingPointInfoBasetrackData  // 0x18
  public            System.String                   key  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CommonTrackerItem
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  public            Beyond.UI.CommonTrackerUpdate.CommonTrackItemStateshowState  // 0x10
  public            UnityEngine.GameObject          obj  // 0x18
  public            Beyond.UI.CommonTrackerNodeComp commonTrackerNodeComp  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ETemperatureState
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.CoolerUnitTemperatureCircleUI.ETemperatureStateNone  // 0x0
  public    static  Beyond.UI.CoolerUnitTemperatureCircleUI.ETemperatureStateLow  // 0x0
  public    static  Beyond.UI.CoolerUnitTemperatureCircleUI.ETemperatureStateSafe  // 0x0
  public    static  Beyond.UI.CoolerUnitTemperatureCircleUI.ETemperatureStateHigh  // 0x0
  public    static  Beyond.UI.CoolerUnitTemperatureCircleUI.ETemperatureStateFinish  // 0x0
METHODS:
END_CLASS

CLASS: CoolerUnitLangKeys
TYPE:  class
TOKEN: 0x200001D
FIELDS:
  public    static  System.String                   TOO_COLD  // 0x0
  public    static  System.String                   GOOD  // 0x0
  public    static  System.String                   TOO_HOT  // 0x0
  public    static  System.String                   FINISH  // 0x0
METHODS:
END_CLASS

CLASS: TempColorState
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.CoolerUnitTemperatureUI.TempColorStateBlue  // 0x0
  public    static  Beyond.UI.CoolerUnitTemperatureUI.TempColorStateGreen  // 0x0
  public    static  Beyond.UI.CoolerUnitTemperatureUI.TempColorStateRed  // 0x0
METHODS:
END_CLASS

CLASS: CoalitionDetail
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  public            Beyond.UI.DamageTextBase        instance  // 0x10
  public            System.Single                   time  // 0x18
  public            System.Double                   value  // 0x20
METHODS:
END_CLASS

CLASS: CoalitionDetail
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            Beyond.UI.DamageTextBaseV2      instance  // 0x10
  public            System.Single                   time  // 0x18
  public            System.Double                   value  // 0x20
METHODS:
END_CLASS

CLASS: IgnitePrefabOverride
TYPE:  class
TOKEN: 0x2000026
FIELDS:
  public            Beyond.GEnums.EnergyShardType   energyShardType  // 0x10
  public            System.String                   overrideName  // 0x18
  public            System.Boolean                  isCrystBreak  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SpawnPointConfig
TYPE:  class
TOKEN: 0x2000028
FIELDS:
  public            Beyond.Gameplay.Core.ObjectType objectType  // 0x10
  public            System.Boolean                  followTarget  // 0x14
  public            System.Boolean                  useHitPoint  // 0x15
  public            Beyond.Gameplay.MountPoint      targetMountPoint  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SpawnPointConfig
TYPE:  class
TOKEN: 0x200002A
FIELDS:
  public            Beyond.Gameplay.Core.ObjectType objectType  // 0x10
  public            System.Boolean                  followTarget  // 0x14
  public            System.Boolean                  useHitPoint  // 0x15
  public            Beyond.Gameplay.MountPoint      targetMountPoint  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: DamageTextSortingPriority
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.DamageTextBaseV2.DamageTextSortingPriorityLevel0  // 0x0
  public    static  Beyond.UI.DamageTextBaseV2.DamageTextSortingPriorityLevel1  // 0x0
  public    static  Beyond.UI.DamageTextBaseV2.DamageTextSortingPriorityLevel2  // 0x0
METHODS:
END_CLASS

CLASS: DamageTextBaseConfig
TYPE:  class
TOKEN: 0x200002C
FIELDS:
  public            Beyond.UI.DamageTextType        type  // 0x10
  public            System.Single                   showDuration  // 0x14
  public            System.Collections.Generic.List<Beyond.UI.DamageTextBaseV2.SpawnPointConfig>spawnPointConfigs  // 0x18
  public            Beyond.UI.DamageTextBaseV2.DamageTextSortingPrioritysortingPriority  // 0x20
  public            System.String                   prefabName  // 0x28
  public            System.Single                   textNodeAlpha  // 0x30
  public            System.Collections.Generic.List<System.String>textNodeName  // 0x38
  public            System.Collections.Generic.List<System.String>colorNodeName  // 0x40
  public            System.String                   leftAnimation  // 0x48
  public            System.String                   rightAnimation  // 0x50
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: LineData
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  public            Beyond.UI.FacLineCell           start  // 0x10
  public            Beyond.UI.FacLineCell           end  // 0x18
  public            Beyond.UI.FacLineCell           link  // 0x20
METHODS:
END_CLASS

CLASS: ETemperatureState
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.ForgeIronTemperatureCircleUI.ETemperatureStateNone  // 0x0
  public    static  Beyond.UI.ForgeIronTemperatureCircleUI.ETemperatureStateLow  // 0x0
  public    static  Beyond.UI.ForgeIronTemperatureCircleUI.ETemperatureStateSafe  // 0x0
  public    static  Beyond.UI.ForgeIronTemperatureCircleUI.ETemperatureStateHigh  // 0x0
  public    static  Beyond.UI.ForgeIronTemperatureCircleUI.ETemperatureStateFinish  // 0x0
METHODS:
END_CLASS

CLASS: HeadBarType
TYPE:  struct
TOKEN: 0x2000042
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.HeadBarCtrl.HeadBarTypeMob  // 0x0
  public    static  Beyond.UI.HeadBarCtrl.HeadBarTypeElite  // 0x0
  public    static  Beyond.UI.HeadBarCtrl.HeadBarTypeEnemyPart  // 0x0
  public    static  Beyond.UI.HeadBarCtrl.HeadBarTypeCNT  // 0x0
METHODS:
END_CLASS

CLASS: HeadBarRefreshReason
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.HeadBarCtrl.HeadBarRefreshReasonOnCreate  // 0x0
  public    static  Beyond.UI.HeadBarCtrl.HeadBarRefreshReasonOnAddHeadBar  // 0x0
  public    static  Beyond.UI.HeadBarCtrl.HeadBarRefreshReasonOnRemoveHeadBar  // 0x0
  public    static  Beyond.UI.HeadBarCtrl.HeadBarRefreshReasonOnHeadBarShowConfigChanged  // 0x0
  public    static  Beyond.UI.HeadBarCtrl.HeadBarRefreshReasonTakeDamage  // 0x0
  public    static  Beyond.UI.HeadBarCtrl.HeadBarRefreshReasonFullHpOrZeroHp  // 0x0
  public    static  Beyond.UI.HeadBarCtrl.HeadBarRefreshReasonEnemyPartEnableChanged  // 0x0
  public    static  Beyond.UI.HeadBarCtrl.HeadBarRefreshReasonLateUpdate  // 0x0
  public    static  Beyond.UI.HeadBarCtrl.HeadBarRefreshReasonDialog  // 0x0
METHODS:
END_CLASS

CLASS: HpScreenEffectConfig
TYPE:  struct
TOKEN: 0x2000049
FIELDS:
  public            System.Single                   minHpPercent  // 0x10
  public            System.Single                   maxHpPercent  // 0x14
  public            System.String                   effectName  // 0x18
METHODS:
END_CLASS

CLASS: CraneSpritePath
TYPE:  class
TOKEN: 0x2000050
FIELDS:
  public            System.String                   stateSpritePath  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MaskShapeType
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UILevelMapLimitInRect.MaskShapeTypeRectangle  // 0x0
  public    static  Beyond.UI.UILevelMapLimitInRect.MaskShapeTypeCircle  // 0x0
METHODS:
END_CLASS

CLASS: DisappearRectShapeType
TYPE:  struct
TOKEN: 0x2000056
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UILevelMapMissionArea.DisappearRectShapeTypeRectangle  // 0x0
  public    static  Beyond.UI.UILevelMapMissionArea.DisappearRectShapeTypeCircle  // 0x0
METHODS:
END_CLASS

CLASS: SettlementRegionSpritePath
TYPE:  class
TOKEN: 0x200005F
FIELDS:
  public            System.String                   path  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SettlementRegionSpriteData
TYPE:  class
TOKEN: 0x2000060
FIELDS:
  public            Beyond.SerializeFieldDictionary<System.Int32,Beyond.UI.UISettlementRegion.SettlementRegionSpritePath>spriteWithTier  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Arrow
TYPE:  class
TOKEN: 0x2000066
FIELDS:
  public            UnityEngine.GameObject          obj  // 0x10
  public            UnityEngine.RectTransform       rect  // 0x18
  public            Beyond.UI.UIAnimationWrapper    anim  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: PressingMode
TYPE:  struct
TOKEN: 0x2000069
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.SkillButton.PressingModeNone  // 0x0
  public    static  Beyond.UI.SkillButton.PressingModeNormal  // 0x0
  public    static  Beyond.UI.SkillButton.PressingModeUltimate  // 0x0
METHODS:
END_CLASS

CLASS: PressHandler
TYPE:  class
TOKEN: 0x200006A
FIELDS:
  protected         Beyond.UI.SkillButton           m_owner  // 0x10
METHODS:
  Beyond.Gameplay.SkillSetting get_skillSetting()
  System.Void .ctor(Beyond.UI.SkillButton owner)
  System.Boolean get_needUpdate()
  System.Void OnPressStart()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnPressEnd()
  System.Void OnPressCancel()
END_CLASS

CLASS: PressHandlerLongPress
TYPE:  class
TOKEN: 0x200006B
EXTENDS: PressHandler
FIELDS:
  private           Beyond.UI.SkillButton.PressingModem_pressingMode  // 0x18
  private           System.Single                   m_pressingSkillTime  // 0x1C
METHODS:
  System.Boolean get_needUpdate()
  System.Void .ctor(Beyond.UI.SkillButton owner)
  System.Void OnPressStart()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnPressEnd()
  System.Void OnPressCancel()
END_CLASS

CLASS: PressHandlerIndividualUltimate
TYPE:  class
TOKEN: 0x200006C
EXTENDS: PressHandler
FIELDS:
  private           Beyond.UI.SkillButton.PressingModem_pressingMode  // 0x18
  private           System.Single                   m_pressingSkillTime  // 0x1C
METHODS:
  System.Boolean get_needUpdate()
  System.Void .ctor(Beyond.UI.SkillButton owner)
  System.Void OnPressStart()
  System.Void OnUpdate(System.Single deltaTime)
  System.Void OnPressEnd()
  System.Void OnPressCancel()
END_CLASS

CLASS: PressHandlerDrag
TYPE:  class
TOKEN: 0x200006D
EXTENDS: PressHandler
FIELDS:
  private           Beyond.UI.SkillButton.PressingModem_pressingMode  // 0x18
  private           System.Single                   m_pressingSkillTime  // 0x1C
  private           UnityEngine.RectTransform       m_indicatorRoot  // 0x20
  private           System.Single                   m_cancelRadiusSqr  // 0x28
  private           Beyond.UI.UIAnimationWrapper    m_indicatorAnim  // 0x30
  private           System.Boolean                  m_inCancelArea  // 0x38
  private           Beyond.UI.UIText                m_ultimateName  // 0x40
  private           Beyond.UI.UIImage               m_ultimateIcon  // 0x48
METHODS:
  System.Boolean get_needUpdate()
  System.Void .ctor(Beyond.UI.SkillButton owner)
  System.Void OnPressStart()
  System.Void OnUpdate(System.Single deltaTime)
  System.Boolean _InCancelArea()
  System.Void OnPressEnd()
  System.Void OnPressCancel()
END_CLASS

CLASS: BuffNodeType
TYPE:  struct
TOKEN: 0x2000076
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIBuffNode.BuffNodeTypeHeadBarCommon  // 0x0
  public    static  Beyond.UI.UIBuffNode.BuffNodeTypeHeadBarAttached  // 0x0
  public    static  Beyond.UI.UIBuffNode.BuffNodeTypeSquadIconCommon  // 0x0
  public    static  Beyond.UI.UIBuffNode.BuffNodeTypeMainCharHpBarCommon  // 0x0
METHODS:
END_CLASS

CLASS: BuffCellGroup
TYPE:  class
TOKEN: 0x2000077
FIELDS:
  public            Beyond.Gameplay.Core.BuffIconConfig.BuffIconStylebuffIconStyle  // 0x10
  public            Beyond.UI.UIBuffCell            buffCellTemplate  // 0x18
  public            System.Collections.Generic.List<Beyond.UI.UIBuffCell>buffCellPool  // 0x20
  public            Beyond.DynamicFastLookupCollection<System.UInt64,Beyond.UI.UIBuffCell>buffCellDict  // 0x28
  public            Beyond.DynamicFastLookupCollection<System.UInt64,Beyond.UI.UIBuffCell>buffCellWithOutAnim  // 0x30
METHODS:
  Beyond.UI.UIBuffCell CreateBuffCell(UnityEngine.Transform transform)
  System.Void RemoveBuffCell(Beyond.UI.UIBuffCell buffCell)
  System.Void ClearAllBuffCells(Beyond.LuaResourceLoader loader)
  System.Void .ctor()
END_CLASS

CLASS: HpDisplayState
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIHeadBar.HpDisplayStateNormal  // 0x0
  public    static  Beyond.UI.UIHeadBar.HpDisplayStateStay  // 0x0
  public    static  Beyond.UI.UIHeadBar.HpDisplayStateDecrease  // 0x0
METHODS:
END_CLASS

CLASS: HeadLabelType
TYPE:  struct
TOKEN: 0x200008A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIHeadLabel.HeadLabelTypeRoot  // 0x0
  public    static  Beyond.UI.UIHeadLabel.HeadLabelTypeBubble  // 0x0
  public    static  Beyond.UI.UIHeadLabel.HeadLabelTypeText  // 0x0
  public    static  Beyond.UI.UIHeadLabel.HeadLabelTypeIcon  // 0x0
  public    static  Beyond.UI.UIHeadLabel.HeadLabelTypeCount  // 0x0
METHODS:
END_CLASS

CLASS: VisibleSource
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIHeadLabel.VisibleSourceComp  // 0x0
  public    static  Beyond.UI.UIHeadLabel.VisibleSourceSystem  // 0x0
  public    static  Beyond.UI.UIHeadLabel.VisibleSourceFloatingUI  // 0x0
  public    static  Beyond.UI.UIHeadLabel.VisibleSourceCount  // 0x0
METHODS:
END_CLASS

CLASS: HeadLabelRootData
TYPE:  class
TOKEN: 0x200008C
FIELDS:
  public            UnityEngine.Transform           root  // 0x10
  public            Beyond.UI.UIHeadLabel.HeadLabelTypeheadLabelType  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HeadLabelRootVisibleData
TYPE:  class
TOKEN: 0x200008D
FIELDS:
  public            UnityEngine.Vector3             originalPosition  // 0x10
  public            System.Collections.Generic.Dictionary<Beyond.UI.UIHeadLabel.VisibleSource,System.Boolean>visibleSource  // 0x20
METHODS:
  System.Boolean get_realVisible()
  System.Void Init(UnityEngine.Vector3 position)
  System.Void UpdateVisible(Beyond.UI.UIHeadLabel.VisibleSource source, System.Boolean visible)
  System.Void .ctor()
END_CLASS

CLASS: PoiseDisplayState
TYPE:  struct
TOKEN: 0x200009B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIPoiseBar.PoiseDisplayStateNormal  // 0x0
  public    static  Beyond.UI.UIPoiseBar.PoiseDisplayStateStay  // 0x0
  public    static  Beyond.UI.UIPoiseBar.PoiseDisplayStateIncrease  // 0x0
METHODS:
END_CLASS

CLASS: IconGroup
TYPE:  class
TOKEN: 0x200009E
FIELDS:
  public            UnityEngine.GameObject          root  // 0x10
  public            UnityEngine.UI.Image            normal  // 0x18
  public            UnityEngine.UI.Image            error  // 0x20
METHODS:
  System.Void SetActiveIfNecessary(System.Boolean active)
  System.Void Switch(System.Boolean err)
  System.Boolean get_activeSelf()
  System.Void .ctor()
END_CLASS

CLASS: StatusHintGroup
TYPE:  class
TOKEN: 0x200009F
FIELDS:
  public            UnityEngine.GameObject          root  // 0x10
  public            UnityEngine.GameObject          localLinkHint  // 0x18
  public            UnityEngine.GameObject          globalLinkHint  // 0x20
  public            UnityEngine.GameObject          outageHint  // 0x28
  public            UnityEngine.GameObject          distLimitHint  // 0x30
METHODS:
  System.Void Switch(Beyond.Gameplay.Factory.PowerAutoConnectStatus status)
  System.Void .ctor()
END_CLASS

CLASS: TravelPoleStatusSetting
TYPE:  struct
TOKEN: 0x20000A1
FIELDS:
  public            System.Boolean                  showTextInfoBg  // 0x10
  public            UnityEngine.GameObject          textToShow  // 0x18
METHODS:
END_CLASS

CLASS: ERank
TYPE:  struct
TOKEN: 0x20000A3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIRaceModuleRankController.ERankNone  // 0x0
  public    static  Beyond.UI.UIRaceModuleRankController.ERankFirst  // 0x0
  public    static  Beyond.UI.UIRaceModuleRankController.ERankSecond  // 0x0
  public    static  Beyond.UI.UIRaceModuleRankController.ERankThird  // 0x0
  public    static  Beyond.UI.UIRaceModuleRankController.ERankFourth  // 0x0
  public    static  Beyond.UI.UIRaceModuleRankController.ERankFifth  // 0x0
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=12
TYPE:  struct
TOKEN: 0x20000AE
FIELDS:
METHODS:
END_CLASS

CLASS: Beyond.PoolCore.ListPoolInitializer_UI_Gameplay_Beyond
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private   static  System.Boolean                  s_initialized  // 0x0
METHODS:
  System.Void InitializeAtRuntime()
  System.Void Initialize()
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

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000007
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000008
EXTENDS: Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000009
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.AtbCell
TYPE:  class
TOKEN: 0x200000A
EXTENDS: MonoBehaviour
FIELDS:
  public            Beyond.UI.UIImage               fill  // 0x18
  public            Beyond.UI.UIAnimationWrapper    fillLoop  // 0x20
  public            UnityEngine.RectTransform       blinkRect  // 0x28
  public            Beyond.UI.UIAnimationWrapper    recover  // 0x30
  public            Beyond.UI.UIAnimationWrapper    anim  // 0x38
  public            UnityEngine.UI.LayoutElement    layoutElement  // 0x40
  public            System.Single                   recoverInitFillAmount  // 0x48
  public            System.Boolean                  atbRecovering  // 0x4C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.AtbNode
TYPE:  class
TOKEN: 0x200000B
EXTENDS: UIPanelBase
FIELDS:
  public            Beyond.UI.AtbCell               atbCell  // 0x70
  public            UnityEngine.RectTransform       atbGroup  // 0x78
  public            Beyond.UI.UIAnimationWrapper    atbSkillHint  // 0x80
  public            UnityEngine.Color               atbColorFull  // 0x88
  public            UnityEngine.Color               atbColorNotFull  // 0x98
  public            System.Single                   atbFillSpeed  // 0xA8
  public            System.String                   atbHintFillOnEvent  // 0xB0
  private   readonly System.Collections.Generic.List<Beyond.UI.AtbCell>m_atbValueCellList  // 0xB8
  private           System.Boolean                  m_atbShowing  // 0xC0
  private           System.Single                   m_showingAtb  // 0xC4
  private   static  System.Single                   ATB_PRESS_THRESHOLD  // 0x0
METHODS:
  Beyond.TickType get_tickOption()
  Beyond.Gameplay.Core.BattleManager get_battleManager()
  Beyond.Gameplay.SkillSetting get_skillSetting()
  System.Void OnCreate()
  System.Void OnClose()
  System.Void LateTick(System.Single deltaTime)
  System.Void CheckAtbLoopAnim()
  System.Void _RefreshAtbShowing()
  System.Void _OnAtbCellOutAnimCallback()
  System.Void OnInFightChanged(Beyond.EventData<System.Boolean>& eventData)
  System.Void OnGainAtb(Beyond.EventData<System.Single>& eventData)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.BlueprintPreviewHelper
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  private           System.UInt16[][]               m_data  // 0x10
  private           System.Int32                    m_width  // 0x18
  private           System.Int32                    m_height  // 0x1C
METHODS:
  System.Void SetSize(System.Int32 width, System.Int32 height)
  System.Void AddGridValue(System.Int32 x, System.Int32 y, System.Byte value)
  System.Void BatchAddGridValue(System.Int32 xMin, System.Int32 yMin, System.Int32 width, System.Int32 height, System.Byte value)
  System.Byte GetGridValue(System.Int32 x, System.Int32 y, System.Byte& value2)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UICharPassiveBase
TYPE:  class
TOKEN: 0x200000E
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void OnCharPassiveNumChanged(System.Single num)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UICharPassiveCounter
TYPE:  class
TOKEN: 0x200000F
EXTENDS: UICharPassiveBase
FIELDS:
  public            Beyond.UI.UIState.UIStateControllerstateController  // 0x18
  public            UnityEngine.GameObject          countTextRoot  // 0x20
  public            Beyond.UI.UIText                countText  // 0x28
  public            Beyond.UI.UIImage[]             layerImages  // 0x30
  public            System.String                   normalStateName  // 0x38
  public            System.String                   activeStateName  // 0x40
  public            System.Int32                    activeCount  // 0x48
  private           System.Int32                    m_currentCount  // 0x4C
METHODS:
  System.Void OnCharPassiveNumChanged(System.Single num)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.CommonTrackerNodeComp
TYPE:  class
TOKEN: 0x2000010
EXTENDS: MonoBehaviour
FIELDS:
  public            Beyond.UI.UIBlackboxTracker     blackboxTracker  // 0x18
  public            Beyond.UI.UICampfireTracker     campfireTracker  // 0x20
  public            Beyond.UI.UICommonTracker       commonTracker  // 0x28
  public            Beyond.UI.UICommonLevelTracker  commonLevelTracker  // 0x30
  private   static  System.Single                   TOO_FAR_DISTANCE  // 0x0
METHODS:
  System.Void ShowStyleType(Beyond.Gameplay.CommonTrackingPointStyleType styleType, Beyond.Gameplay.CommonTrackingPointInfoBase trackerData)
  System.Void PlayOutAnimation(Beyond.Gameplay.CommonTrackingPointStyleType styleType)
  System.Void UpdatePosition(Beyond.Gameplay.CommonTrackingPointInfoBase trackerData)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.CommonTrackerUpdate
TYPE:  class
TOKEN: 0x2000011
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.RectTransform       rootTransform  // 0x18
  public            UnityEngine.GameObject          templateTrackerGo  // 0x20
  public            UnityEngine.Transform           trackerParentTransform  // 0x28
  private           System.Collections.Generic.List<Beyond.UI.CommonTrackerUpdate.CommonTrackerItem>m_trackerItemCache  // 0x30
  private           System.Collections.Generic.List<Beyond.UI.CommonTrackerUpdate.CommonTrackerData>m_trackerDatas  // 0x38
  private           System.Collections.Generic.List<Beyond.UI.CommonTrackerUpdate.CommonTrackerItem>m_trackerItems  // 0x40
  public    static readonly System.Int32                    PLAY_ANIM_IN_SIGNAL  // 0x0
METHODS:
  System.Boolean get__inFactoryTopView()
  System.Void UpdateCommonTrackers(System.Boolean missionHudOpen, System.Int32 onShowSignal)
  System.Void AllTrackersPlayOutAnimation()
  System.Boolean _InitTrackInfoByIndex(System.Int32 trackerIdx, System.String key, Beyond.Gameplay.CommonTrackingPointInfoBase trackData)
  Beyond.UI.CommonTrackerUpdate.CommonTrackerItem _CreateNewMissionTracker()
  System.Void _DeleteInvalidTracker()
  System.Void _ShowTrackerGo(Beyond.UI.CommonTrackerUpdate.CommonTrackerItem trackerItem, Beyond.Gameplay.CommonTrackingPointInfoBase trackerData)
  System.Void _HideTrackerGo(Beyond.UI.CommonTrackerUpdate.CommonTrackerItem trackerItem)
  System.Int32 _FindTrackIndexByKey(System.String key)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UIBlackboxTracker
TYPE:  class
TOKEN: 0x2000016
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.RectTransform       rectTransform  // 0x18
  public            UnityEngine.RectTransform       arrowRotator  // 0x20
  public            Beyond.UI.UIAnimationWrapper    animationWrapper  // 0x28
  public            Beyond.UI.UIText                distanceTxt  // 0x30
METHODS:
  System.Void UpdatePosition(UnityEngine.Vector2 uiPos, System.Single uiAngle, System.Boolean isOutBound, System.Single distance, System.Boolean needShowDistance)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UICampfireTracker
TYPE:  class
TOKEN: 0x2000017
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.RectTransform       rectTransform  // 0x18
  public            UnityEngine.RectTransform       arrowRotator  // 0x20
  public            Beyond.UI.UIAnimationWrapper    animationWrapper  // 0x28
  public            Beyond.UI.UIImage               image  // 0x30
METHODS:
  System.Void UpdatePosition(UnityEngine.Vector2 uiPos, System.Single uiAngle, System.Boolean isOutBound, System.Single distance, System.Boolean needShowDistance)
  System.Void UpdateImage(Beyond.Gameplay.CommonTrackingPointInfoBase trackerData)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UICommonLevelTracker
TYPE:  class
TOKEN: 0x2000018
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.RectTransform       rectTransform  // 0x18
  public            UnityEngine.RectTransform       arrowRotator  // 0x20
  public            Beyond.UI.UIAnimationWrapper    animationWrapper  // 0x28
  public            Beyond.UI.UIText                distanceTxt  // 0x30
METHODS:
  System.Void UpdatePosition(Beyond.Gameplay.PosValueState posValueState, System.Boolean needShowDistance, UnityEngine.Vector2 uiPos, System.Single uiAngle, System.Boolean isOutBound, System.Single distance, Beyond.Gameplay.CommonTrackMapTier mapTier)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UICommonTracker
TYPE:  class
TOKEN: 0x2000019
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.RectTransform       rectTransform  // 0x18
  public            UnityEngine.RectTransform       arrowRotator  // 0x20
  public            Beyond.UI.UIText                distanceTxt  // 0x28
  public            Beyond.UI.UIAnimationWrapper    animationWrapper  // 0x30
  public            Beyond.UI.UIImage               levelImage  // 0x38
  public            UnityEngine.RectTransform       normalNode  // 0x40
  public            Beyond.UI.UIImage               normalShadowImage  // 0x48
  public            Beyond.UI.UIImage               normalImage  // 0x50
  public            Beyond.UI.UIImage               arrowUpImage  // 0x58
  public            UnityEngine.RectTransform       arrowUpRectTransform  // 0x60
METHODS:
  System.Void UpdateImage(Beyond.Gameplay.CommonTrackingPointInfoBase trackerData)
  System.Void UpdatePosition(Beyond.Gameplay.PosValueState posValueState, System.Boolean needShowDistance, UnityEngine.Vector2 uiPos, System.Single uiAngle, System.Boolean isOutBound, System.Single distance, Beyond.Gameplay.CommonTrackMapTier mapTier)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.CoolerUnitProgressBarUI
TYPE:  class
TOKEN: 0x200001A
EXTENDS: WorldUIController
FIELDS:
  private           Beyond.Gameplay.Core.Entity     m_targetEntity  // 0xC0
  private           Beyond.Gameplay.Core.CoolerUnitComponentm_coolerUnitComponent  // 0xC8
  private           System.Single                   m_displayProgress  // 0xD0
  private   static  System.Single                   LERP_SPEED  // 0x0
  private   static  System.Single                   MAX_STEP  // 0x0
  public            Beyond.UI.UIText                progressDesc  // 0xD8
  public            Beyond.UI.UIText                progressText  // 0xE0
  public            Beyond.UI.UIImage               progressImage  // 0xE8
  public            UnityEngine.Transform           progressUIRoot  // 0xF0
  private           UnityEngine.CanvasGroup         m_canvasGroup  // 0xF8
METHODS:
  Beyond.TickType get_tickOption()
  System.Void Init(Beyond.Gameplay.Core.Entity target, System.String path, System.UInt64 id, System.Int32 typeSegment)
  System.Void SetUIForward()
  System.Void SetPos()
  System.Void TickUI(System.Single deltaTime)
  System.Void _TickCanvasGroup(System.Single deltaTime)
  System.Void _UpdateProgress(System.Single deltaTime)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Init(Beyond.Gameplay.Core.Entity P0, System.String P1, System.UInt64 P2, System.Int32 P3)
  System.Void <>iFixBaseProxy_SetUIForward()
  System.Void <>iFixBaseProxy_SetPos()
  System.Void <>iFixBaseProxy_TickUI(System.Single P0)
END_CLASS

CLASS: Beyond.UI.CoolerUnitTemperatureCircleUI
TYPE:  class
TOKEN: 0x200001B
EXTENDS: WorldUIController
FIELDS:
  private   static  System.String                   AUDIO_EVENT_SUCCEED  // 0x0
  private   static readonly UnityEngine.Color               COLOR_BLUE  // 0x0
  private   static readonly UnityEngine.Color               COLOR_GREEN  // 0x10
  private   static readonly UnityEngine.Color               COLOR_RED  // 0x20
  private           Beyond.Gameplay.Core.Entity     m_targetEntity  // 0xC0
  private           Beyond.Gameplay.Core.CoolerUnitComponentm_coolerUnitComponent  // 0xC8
  public            Beyond.UI.UIImage               bg  // 0xD0
  public            Beyond.UI.UIImage               warningBg  // 0xD8
  public            Beyond.UI.UIText                desc  // 0xE0
  public            UnityEngine.Transform           tempCircleRoot  // 0xE8
  private           UnityEngine.CanvasGroup         m_canvasGroup  // 0xF0
  private           Beyond.LangKey                  m_customDesc  // 0xF8
  private           Beyond.LangKey                  m_highTempDesc  // 0x108
  private           Beyond.LangKey                  m_lowTempDesc  // 0x118
  private           Beyond.LangKey                  m_goodTempDesc  // 0x128
METHODS:
  Beyond.TickType get_tickOption()
  System.Void Init(Beyond.Gameplay.Core.Entity target, System.String path, System.UInt64 id, System.Int32 typeSegment)
  System.Void SetUIForward()
  System.Void SetPos()
  System.Void TickUI(System.Single deltaTime)
  System.Void _TickCanvasGroup(System.Single deltaTime)
  System.Void _UpdateUIState()
  System.Void _SetState(Beyond.UI.CoolerUnitTemperatureCircleUI.ETemperatureState state)
  System.String _GetLangKeyOrDefault(Beyond.LangKey customKey, System.String defaultKey)
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_Init(Beyond.Gameplay.Core.Entity P0, System.String P1, System.UInt64 P2, System.Int32 P3)
  System.Void <>iFixBaseProxy_SetUIForward()
  System.Void <>iFixBaseProxy_SetPos()
  System.Void <>iFixBaseProxy_TickUI(System.Single P0)
END_CLASS

CLASS: Beyond.UI.CoolerUnitTemperatureUI
TYPE:  class
TOKEN: 0x200001E
EXTENDS: WorldUIController
FIELDS:
  private   static readonly System.Single                   MIN_Y_POS  // 0x0
  private   static readonly System.Single                   MAX_HEIGHT  // 0x4
  private   static readonly UnityEngine.Color               COLOR_BLUE  // 0x8
  private   static readonly UnityEngine.Color               COLOR_GREEN  // 0x18
  private   static readonly UnityEngine.Color               COLOR_RED  // 0x28
  private           Beyond.Gameplay.Core.Entity     m_targetEntity  // 0xC0
  private           Beyond.Gameplay.Core.CoolerUnitComponentm_coolerUnitComponent  // 0xC8
  public            System.Single                   greenBarTotalHeight  // 0xD0
  public            System.Single                   initBarPosY  // 0xD4
  public            System.Single                   totalBarPosY  // 0xD8
  public            System.Single                   initHandPosY  // 0xDC
  public            System.Single                   totalHandPosY  // 0xE0
  private           System.Single                   m_greenBarCurHeight  // 0xE4
  public            Beyond.UI.UIImage               progressImage  // 0xE8
  public            UnityEngine.RectTransform       greenBar  // 0xF0
  public            UnityEngine.RectTransform       goodHand  // 0xF8
  public            UnityEngine.Transform           temperatureUI  // 0x100
  private           UnityEngine.CanvasGroup         m_canvasGroup  // 0x108
  private           System.Boolean                  m_initBarSize  // 0x110
  private           System.Boolean                  m_initPosSynced  // 0x111
  private           System.Single                   m_lastMount  // 0x114
  private           Beyond.UI.CoolerUnitTemperatureUI.TempColorStatem_colorState  // 0x118
  private           System.Boolean                  m_colorStateInited  // 0x11C
  private   static  System.Single                   COLOR_EPS  // 0x0
  private   static  System.Single                   SNAP_THRESHOLD  // 0x0
METHODS:
  Beyond.TickType get_tickOption()
  System.Void Init(Beyond.Gameplay.Core.Entity target, System.String path, System.UInt64 id, System.Int32 typeSegment)
  System.Void Clear()
  System.Void SetUIForward()
  System.Void SetPos()
  System.Void TickUI(System.Single deltaTime)
  System.Void _TickCanvasGroup(System.Single deltaTime)
  System.Void NormalizeRange(System.Single& min, System.Single& max)
  System.Void _UpdateUIInfo(System.Single deltaTime)
  System.Void _UpdateUIPos(System.Single deltaTime)
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_Init(Beyond.Gameplay.Core.Entity P0, System.String P1, System.UInt64 P2, System.Int32 P3)
  System.Void <>iFixBaseProxy_Clear()
  System.Void <>iFixBaseProxy_SetUIForward()
  System.Void <>iFixBaseProxy_SetPos()
  System.Void <>iFixBaseProxy_TickUI(System.Single P0)
END_CLASS

CLASS: Beyond.UI.CoolerUnitTotalProgressBarUI
TYPE:  class
TOKEN: 0x2000020
EXTENDS: WorldUIController
FIELDS:
  private           System.Single                   m_displayProgress  // 0xC0
  private           System.Int32                    m_lastDisplayPercent  // 0xC4
  private   static readonly System.String[]                 S_PERCENT_STRING  // 0x0
  public            Beyond.UI.UIText                progressDesc  // 0xC8
  public            Beyond.UI.UIText                progressText  // 0xD0
  public            Beyond.UI.UIImage               progressImage  // 0xD8
  public            UnityEngine.Transform           progressUIRoot  // 0xE0
  private           UnityEngine.CanvasGroup         m_canvasGroup  // 0xE8
  private           Beyond.Gameplay.Core.WaterAbsorbedImpactControllerm_module  // 0xF0
METHODS:
  Beyond.TickType get_tickOption()
  System.String[] _GeneratePercentStrings()
  System.Void Init(Beyond.Gameplay.Core.Entity target, System.String path, System.UInt64 id, System.Int32 typeSegment)
  System.Void _ResetUI()
  System.Void _GetCanvas()
  System.Boolean _TryGetModule(System.UInt64 id)
  System.Void SetUIForward()
  System.Void SetPos()
  System.Void TickUI(System.Single deltaTime)
  System.Void _TickCanvasGroup(System.Single deltaTime)
  System.Void _UpdateProgress(System.Single deltaTime)
  System.Void _SetProgressText(System.Int32 percent)
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_Init(Beyond.Gameplay.Core.Entity P0, System.String P1, System.UInt64 P2, System.Int32 P3)
  System.Void <>iFixBaseProxy_SetUIForward()
  System.Void <>iFixBaseProxy_SetPos()
  System.Void <>iFixBaseProxy_TickUI(System.Single P0)
END_CLASS

CLASS: Beyond.UI.DamageTextType
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.DamageTextType        Level0Normal  // 0x0
  public    static  Beyond.UI.DamageTextType        Level1Normal  // 0x0
  public    static  Beyond.UI.DamageTextType        Level0Critical  // 0x0
  public    static  Beyond.UI.DamageTextType        Level1Critical  // 0x0
  public    static  Beyond.UI.DamageTextType        Level0Block  // 0x0
  public    static  Beyond.UI.DamageTextType        Level1Block  // 0x0
  public    static  Beyond.UI.DamageTextType        EnemyDamage  // 0x0
  public    static  Beyond.UI.DamageTextType        Heal  // 0x0
  public    static  Beyond.UI.DamageTextType        IgniteBuff  // 0x0
  public    static  Beyond.UI.DamageTextType        Airborne  // 0x0
  public    static  Beyond.UI.DamageTextType        Crush  // 0x0
  public    static  Beyond.UI.DamageTextType        KnockDown  // 0x0
  public    static  Beyond.UI.DamageTextType        Fracture  // 0x0
  public    static  Beyond.UI.DamageTextType        Immune  // 0x0
  public    static  Beyond.UI.DamageTextType        CommonFlowText  // 0x0
  public    static  Beyond.UI.DamageTextType        LevelUpText  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.DamageTextCtrl
TYPE:  class
TOKEN: 0x2000022
EXTENDS: UIPanelBase
FIELDS:
  public            UnityEngine.RectTransform       content  // 0x70
  public            UnityEngine.RectTransform       prefabNode  // 0x78
  public            UnityEngine.Vector2             textRandomAreaSize  // 0x80
  public            UnityEngine.Vector2             textMinDist  // 0x88
  public            System.Int32                    textPosMaxRandomTimes  // 0x90
  public            UnityEngine.Color               damageTextColorPhysical  // 0x94
  public            UnityEngine.Color               damageTextColorReal  // 0xA4
  public            UnityEngine.Color               damageTextColorFire  // 0xB4
  public            UnityEngine.Color               damageTextColorPulse  // 0xC4
  public            UnityEngine.Color               damageTextColorCryst  // 0xD4
  public            UnityEngine.Color               damageTextColorNatural  // 0xE4
  public            UnityEngine.Color               damageTextColorEther  // 0xF4
  public            UnityEngine.Vector2             mainChrDmgTxtSpawnOffset  // 0x104
  public            UnityEngine.Vector2             mainChrDmgTxtMoveSpawnOffset  // 0x10C
  public            System.Int32                    mainChrDmgTxtMoveNum  // 0x114
  public            System.Single                   mainChrDmgTxtMoveSpawnWaitTime  // 0x118
  public            UnityEngine.Vector2             guardDmgTxtSpawnOffset  // 0x11C
  public            UnityEngine.Vector2             guardDmgTxtSpawnAreaSize  // 0x124
  public            System.Single                   dmgTxtCoalitionMaxTime  // 0x12C
  public            System.Boolean                  enableGuardDmgTxtOverwrite  // 0x130
  public            UnityEngine.Vector2             physicalInflictionTextOffset  // 0x134
  public            UnityEngine.Vector2             spellInflictionTextOffset  // 0x13C
  private   static readonly System.Collections.Generic.Dictionary<Beyond.UI.DamageTextType,System.Int32>PRE_LOAD_TEXT_COUNTS  // 0x0
  private   static  System.String                   GUARD_OVERWRITE_COALITION_KEY  // 0x0
  private   static  System.String                   CRYST_BREAK_TEXT_ID  // 0x0
  private           System.Boolean                  m_isShow  // 0x144
  private   readonly System.Collections.Generic.Dictionary<Beyond.UI.DamageTextType,Beyond.UI.DamageTextBase>m_textPrefabMap  // 0x148
  private   readonly System.Collections.Generic.List<Beyond.UI.DamageTextBase>m_showingTextInstances  // 0x150
  private   readonly System.Collections.Generic.Dictionary<Beyond.UI.DamageTextType,System.Collections.Generic.Queue<Beyond.UI.DamageTextBase>>m_textPool  // 0x158
  private   readonly System.Collections.Generic.Dictionary<Beyond.UI.DamageTextBase,UnityEngine.Vector3>m_showingTextPos  // 0x160
  private   readonly System.Collections.Generic.Dictionary<Beyond.Gameplay.Core.AbilitySystem,System.Collections.Generic.Dictionary<Beyond.Gameplay.Core.AbilitySystem,System.Collections.Generic.Dictionary<System.String,Beyond.UI.DamageTextCtrl.CoalitionDetail>>>m_entityCoalitionGroupMap  // 0x168
  private   readonly System.Collections.Generic.Dictionary<Beyond.Gameplay.Core.AbilitySystem,System.Collections.Generic.Dictionary<System.Int32,System.Single>>m_entityTextTimeMap  // 0x170
  private   readonly System.Collections.Generic.Dictionary<System.UInt64,Beyond.UI.DamageTextLevelUp>m_charLevelUpTextMap  // 0x178
  private   readonly System.Collections.Generic.List<Beyond.EventData<System.UInt64,System.Int32>>m_charLevelUpTextToShow  // 0x180
  private   readonly System.Collections.Generic.List<Beyond.UI.DamageTextBase>m_toRecycleInTick  // 0x188
METHODS:
  Beyond.TickType get_tickOption()
  UnityEngine.Vector3 get_outOfScreenPos()
  System.Void OnCreate()
  System.Void OnClose()
  System.Void DebugChangeImpl(System.Boolean disableThis)
  System.Void OnShow()
  System.Void OnHide()
  System.Void Tick(System.Single deltaTime)
  System.Void _OnHpChanged(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem.Modifier>& eventData)
  System.Void _OnIgniteBuffText(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,UnityEngine.Vector3,UnityEngine.Vector2,System.String,Beyond.GEnums.EnergyShardType>& eventData)
  System.Void _OnPhysicalInflictionApplied(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,Beyond.Gameplay.Core.AbilitySystemForEnemyPart,Beyond.Gameplay.PhysicalInflictionType>& eventData)
  System.Void _OnImmuneText(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,UnityEngine.Vector3,UnityEngine.Vector2,System.String>& eventData)
  System.Void _OnSquadInFightChanged(Beyond.EventData<System.Boolean>& eventData)
  System.Void _OnCreateFlowText(Beyond.EventData<UnityEngine.Vector3,System.String,UnityEngine.Color>& eventData)
  System.Void _OnCharLevelUp(Beyond.EventData<System.UInt64,System.Int32>& eventData)
  UnityEngine.Vector2 _GetRandomTextOffset(System.Single width, System.Single height)
  System.Boolean _IsTextPosValid(UnityEngine.Vector3 newPos)
  Beyond.UI.DamageTextBase _CreateTextInstance(Beyond.UI.DamageTextType textType)
  Beyond.UI.DamageTextBase _InstantiateTextInstance(Beyond.UI.DamageTextType textType)
  System.Void _RecycleTextInstance(Beyond.UI.DamageTextBase textInstance)
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.DamageTextCtrlV2
TYPE:  class
TOKEN: 0x2000024
EXTENDS: UIPanelBase
FIELDS:
  public            Beyond.UI.GPUI.GPUISystem       gpuiSystem  // 0x70
  public            System.Collections.Generic.List<Beyond.UI.DamageTextBaseV2.DamageTextBaseConfig>damageTextConfigs  // 0x78
  public            System.Collections.Generic.List<Beyond.UI.DamageTextCtrlV2.IgnitePrefabOverride>ignitePrefabConfig  // 0x80
  public            UnityEngine.Vector2             textRandomAreaSize  // 0x88
  public            UnityEngine.Vector2             textMinDist  // 0x90
  public            System.Int32                    textPosMaxRandomTimes  // 0x98
  public            UnityEngine.Color               damageTextColorPhysical  // 0x9C
  public            UnityEngine.Color               damageTextColorReal  // 0xAC
  public            UnityEngine.Color               damageTextColorFire  // 0xBC
  public            UnityEngine.Color               damageTextColorPulse  // 0xCC
  public            UnityEngine.Color               damageTextColorCryst  // 0xDC
  public            UnityEngine.Color               damageTextColorNatural  // 0xEC
  public            UnityEngine.Color               damageTextColorEther  // 0xFC
  public            UnityEngine.Vector2             mainChrDmgTxtSpawnOffset  // 0x10C
  public            UnityEngine.Vector2             mainChrDmgTxtMoveSpawnOffset  // 0x114
  public            System.Int32                    mainChrDmgTxtMoveNum  // 0x11C
  public            System.Single                   mainChrDmgTxtMoveSpawnWaitTime  // 0x120
  public            UnityEngine.Vector2             guardDmgTxtSpawnOffset  // 0x124
  public            UnityEngine.Vector2             guardDmgTxtSpawnAreaSize  // 0x12C
  public            System.Single                   dmgTxtCoalitionMaxTime  // 0x134
  public            System.Boolean                  enableGuardDmgTxtOverwrite  // 0x138
  public            UnityEngine.Vector2             physicalInflictionTextOffset  // 0x13C
  public            UnityEngine.Vector2             spellInflictionTextOffset  // 0x144
  private   static  System.String                   GUARD_OVERWRITE_COALITION_KEY  // 0x0
  private   static  System.String                   CRYST_BREAK_TEXT_ID  // 0x0
  private           System.Boolean                  m_isShow  // 0x14C
  private   readonly System.Collections.Generic.Dictionary<Beyond.UI.DamageTextType,Beyond.UI.DamageTextBaseV2.DamageTextBaseConfig>m_textConfigMap  // 0x150
  private   readonly System.Collections.Generic.List<Beyond.UI.DamageTextBaseV2>m_showingTextInstances  // 0x158
  private   readonly System.Collections.Generic.Queue<Beyond.UI.DamageTextBaseV2>m_textPool  // 0x160
  private   readonly System.Collections.Generic.Dictionary<Beyond.UI.DamageTextBaseV2,UnityEngine.Vector3>m_showingTextPos  // 0x168
  private   readonly System.Collections.Generic.Dictionary<Beyond.Gameplay.Core.AbilitySystem,System.Collections.Generic.Dictionary<Beyond.Gameplay.Core.AbilitySystem,System.Collections.Generic.Dictionary<System.String,Beyond.UI.DamageTextCtrlV2.CoalitionDetail>>>m_entityCoalitionGroupMap  // 0x170
  private   readonly System.Collections.Generic.Dictionary<Beyond.Gameplay.Core.AbilitySystem,System.Collections.Generic.Dictionary<System.Int32,System.Single>>m_entityTextTimeMap  // 0x178
  private   readonly System.Collections.Generic.Dictionary<System.UInt64,Beyond.UI.DamageTextBaseV2>m_charLevelUpTextMap  // 0x180
  private   readonly System.Collections.Generic.List<Beyond.EventData<System.UInt64,System.Int32>>m_charLevelUpTextToShow  // 0x188
  private   readonly System.Collections.Generic.List<Beyond.UI.DamageTextBaseV2>m_toRecycleInTick  // 0x190
METHODS:
  Beyond.TickType get_tickOption()
  UnityEngine.Vector3 get_outOfScreenPos()
  System.Void OnCreate()
  System.Void OnClose()
  System.Void DebugChangeImpl(System.Boolean disableThis)
  System.Void OnShow()
  System.Void OnHide()
  System.Void Tick(System.Single deltaTime)
  System.Void _OnHpChanged(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem.Modifier>& eventData)
  System.Void _OnIgniteBuffText(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,UnityEngine.Vector3,UnityEngine.Vector2,System.String,Beyond.GEnums.EnergyShardType>& eventData)
  System.Void _OnPhysicalInflictionApplied(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,Beyond.Gameplay.Core.AbilitySystemForEnemyPart,Beyond.Gameplay.PhysicalInflictionType>& eventData)
  System.Void _OnImmuneText(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,UnityEngine.Vector3,UnityEngine.Vector2,System.String>& eventData)
  System.Void _OnSquadInFightChanged(Beyond.EventData<System.Boolean>& eventData)
  System.Void _OnCreateFlowText(Beyond.EventData<UnityEngine.Vector3,System.String,UnityEngine.Color>& eventData)
  System.Void _OnCharLevelUp(Beyond.EventData<System.UInt64,System.Int32>& eventData)
  UnityEngine.Vector2 _GetRandomTextOffset(System.Single width, System.Single height)
  System.Boolean _IsTextPosValid(UnityEngine.Vector3 newPos)
  Beyond.UI.DamageTextBaseV2 _CreateTextInstance(Beyond.UI.DamageTextType textType, System.String overrideName)
  System.Void _RecycleTextInstance(Beyond.UI.DamageTextBaseV2 textInstance)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.DamageTextBase
TYPE:  class
TOKEN: 0x2000027
EXTENDS: TickableUIMono
FIELDS:
  public            Beyond.UI.DamageTextType        type  // 0x68
  public            System.Single                   showDuration  // 0x6C
  public            System.Collections.Generic.List<Beyond.UI.DamageTextBase.SpawnPointConfig>spawnPointConfigs  // 0x70
  public            Beyond.UI.UIText                text  // 0x78
  public            UnityEngine.Animation           anim  // 0x80
  private           System.Boolean                  m_isActive  // 0x88
  private           System.Boolean                  m_isFollowingTransform  // 0x89
  private           UnityEngine.Transform           m_followedTransform  // 0x90
  private           UnityEngine.Vector3             m_followedPosition  // 0x98
  private           UnityEngine.Vector2             m_uiOffset  // 0xA4
  public            Beyond.Gameplay.PeriodicTimer   durationTimer  // 0xB0
  protected         Beyond.UnSafeString.UnSafeStringHandlem_textHandle  // 0xB8
METHODS:
  Beyond.TickType get_tickOption()
  System.Boolean get_isFollowingTransform()
  UnityEngine.Vector3 get_worldPosition()
  UnityEngine.Vector2 get_uiOffset()
  System.Void OnAwake()
  System.Void OnRelease()
  System.Void TailLateTick(System.Single deltaTime)
  System.Void SetFollowTarget(Beyond.Gameplay.Core.AbilitySystem target, Beyond.Gameplay.Core.AbilitySystem textTargetWhenTransferred, System.Nullable<UnityEngine.Vector3> hitPoint)
  System.Void SetUIOffset(UnityEngine.Vector2 offset)
  System.Void Clear()
  System.Void SetColor(UnityEngine.Color color)
  System.Void PlayAnimation()
  System.Void _UpdatePosition()
  System.Void SetText(System.String newText)
  System.Void SetText(System.Int32 newValue)
  System.Void SetText(System.String prefix, System.Int32 newValue)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnRelease()
  System.Void <>iFixBaseProxy_TailLateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.DamageTextBaseV2
TYPE:  class
TOKEN: 0x2000029
FIELDS:
  private   static readonly UnityEngine.Vector2             INVALID_POS  // 0x0
  private           System.Boolean                  m_isFollowingTransform  // 0x10
  private           UnityEngine.Transform           m_followedTransform  // 0x18
  private           UnityEngine.Vector3             m_followedPosition  // 0x20
  private           UnityEngine.Vector2             m_uiOffset  // 0x2C
  private           Beyond.UI.GPUI.GPUIHandle       m_uiHandle  // 0x34
  private           Beyond.UI.GPUI.GPUISystem       m_uiSystem  // 0x40
  private           Beyond.UI.DamageTextBaseV2.DamageTextBaseConfigm_config  // 0x48
  private           System.UInt64                   <targetCharInst>k__BackingField  // 0x50
  protected         Beyond.UnSafeString.UnSafeStringHandlem_textHandle  // 0x58
METHODS:
  System.UInt64 get_targetCharInst()
  System.Void set_targetCharInst(System.UInt64 value)
  System.Single get_textNodeAlpha()
  System.Single get_showDuration()
  System.Boolean get_isFollowingTransform()
  System.Boolean get_isActive()
  UnityEngine.Vector3 get_worldPosition()
  UnityEngine.Vector2 get_uiOffset()
  System.Void .ctor(Beyond.UI.GPUI.GPUISystem uiSystem)
  System.Void OnRelease()
  System.Void Assign(Beyond.UI.DamageTextBaseV2.DamageTextBaseConfig config, System.String overrideName)
  System.Void Tick(UnityEngine.Vector2 screenCenter, System.Single scaleFactor)
  System.Void SetFollowTarget(Beyond.Gameplay.Core.AbilitySystem target, Beyond.Gameplay.Core.AbilitySystem textTargetWhenTransferred, System.Nullable<UnityEngine.Vector3> hitPoint)
  System.Void SetUIOffset(UnityEngine.Vector2 offset)
  System.Void Clear()
  System.Void DestroyDisplay()
  System.Void SetColor(UnityEngine.Color color)
  System.Void PlayAnimation(System.Boolean isLeft)
  System.Void _UpdatePosition(UnityEngine.Vector2 screenCenter, System.Single scaleFactor)
  System.Void SetText(System.String newText)
  System.Void SetText(System.Int32 newValue)
  System.Void SetText(System.String prefix, System.Int32 newValue)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.DamageTextBlock
TYPE:  class
TOKEN: 0x200002D
EXTENDS: DamageTextDamageBase
FIELDS:
  public            Beyond.UI.UIImage               blockIcon  // 0xC0
METHODS:
  System.Void SetColor(UnityEngine.Color color)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_SetColor(UnityEngine.Color P0)
END_CLASS

CLASS: Beyond.UI.DamageTextCriticalLevel0
TYPE:  class
TOKEN: 0x200002E
EXTENDS: DamageTextDamageBase
FIELDS:
  public            Beyond.UI.UIText                criticalIcon  // 0xC0
METHODS:
  System.Void SetColor(UnityEngine.Color color)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_SetColor(UnityEngine.Color P0)
END_CLASS

CLASS: Beyond.UI.DamageTextCriticalLevel1
TYPE:  class
TOKEN: 0x200002F
EXTENDS: DamageTextDamageBase
FIELDS:
  public            Beyond.UI.UIText                criticalIcon  // 0xC0
  public            Beyond.UI.UIText                criticalIconShadow  // 0xC8
  public            Beyond.UI.UIImage               bg01  // 0xD0
  public            Beyond.UI.UIImage               bg02  // 0xD8
  private   static  System.String                   ANIM_NAME_CRITICAL_LEFT  // 0x0
  private   static  System.String                   ANIM_NAME_CRITICAL_RIGHT  // 0x0
METHODS:
  System.Void SetColor(UnityEngine.Color color)
  System.Void PlayAnimation(System.Boolean isLeft)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_SetColor(UnityEngine.Color P0)
  System.Void <>iFixBaseProxy_PlayAnimation(System.Boolean P0)
END_CLASS

CLASS: Beyond.UI.DamageTextDamageBase
TYPE:  class
TOKEN: 0x2000030
EXTENDS: DamageTextBase
FIELDS:
METHODS:
  System.Void PlayAnimation(System.Boolean isLeft)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.DamageTextIgniteBuff
TYPE:  class
TOKEN: 0x2000031
EXTENDS: DamageTextBase
FIELDS:
  public            Beyond.UI.UIImage               bg  // 0xC0
  public            Beyond.UI.UIText                textDuplication  // 0xC8
  public            Beyond.UI.UIState.UIStateControllerstateController  // 0xD0
METHODS:
  System.Void OnAwake()
  System.Void OnRelease()
  System.Void SetUIState(Beyond.GEnums.EnergyShardType energyShardType, System.Boolean isCrystBreak)
  System.Void SetTextAndDuplication(System.String newText)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.DamageTextLevelUp
TYPE:  class
TOKEN: 0x2000032
EXTENDS: DamageTextBase
FIELDS:
  private           System.UInt64                   <targetCharInst>k__BackingField  // 0xC0
METHODS:
  System.UInt64 get_targetCharInst()
  System.Void set_targetCharInst(System.UInt64 value)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.DamageTextNormalLevel1
TYPE:  class
TOKEN: 0x2000033
EXTENDS: DamageTextDamageBase
FIELDS:
  private   static  System.String                   ANIM_NAME_NORMAL_LEFT  // 0x0
  private   static  System.String                   ANIM_NAME_NORMAL_RIGHT  // 0x0
METHODS:
  System.Void PlayAnimation(System.Boolean isLeft)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_PlayAnimation(System.Boolean P0)
END_CLASS

CLASS: Beyond.UI.FacLineCell
TYPE:  class
TOKEN: 0x2000034
EXTENDS: MonoBehaviour
FIELDS:
  private   static  System.Single                   HSV_VALUE_RATIO  // 0x0
  private           UnityEngine.RectTransform       _rectTransform  // 0x18
  public            UnityEngine.RectTransform       topAgent  // 0x20
  public            UnityEngine.RectTransform       bottomAgent  // 0x28
  public            Beyond.UI.UIAnimationWrapper    lineAnimationWrapper  // 0x30
  public            Beyond.UI.UIAnimationWrapper    decoAnimationWrapper  // 0x38
  private           System.Collections.Generic.List<Beyond.UI.UIImage>m_imageList  // 0x40
METHODS:
  System.Void Awake()
  System.Void PlayLineAnimation(System.String animationName, DG.Tweening.TweenCallback callback)
  System.Void PlayLineDecoAnimation(System.String animationName, DG.Tweening.TweenCallback callback)
  System.Void ChangeLineColor(UnityEngine.Color color)
  System.Void ChangeLineWidth(System.Single width)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.FacLineDrawer
TYPE:  class
TOKEN: 0x2000036
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.RectTransform       m_rectTransform  // 0x18
  private   readonly System.Collections.Generic.Dictionary<System.UInt32,Beyond.UI.FacLineDrawer.LineData>m_lineCache  // 0x20
  private   readonly System.Collections.Generic.List<UnityEngine.GameObject>m_instantiatedLineCell  // 0x28
  private           System.UInt32                   m_nextLineId  // 0x30
  private   static  System.UInt32                   INVALID_LINE_ID  // 0x0
  public            UnityEngine.RectTransform       startDrawAgent  // 0x38
  public            UnityEngine.RectTransform       endDrawAgent  // 0x40
  public            UnityEngine.GameObject          linkLinePrefab  // 0x48
METHODS:
  System.Void Awake()
  System.Void OnDestroy()
  System.Void _Clear()
  UnityEngine.GameObject _CloneLineObject(UnityEngine.GameObject sourceObject, UnityEngine.Transform locateTransform)
  System.Void _RefreshCopyLineObjectColor(UnityEngine.GameObject lineObject, UnityEngine.Color color)
  System.Void ClearComponent()
  System.UInt32 DrawLine(Beyond.UI.FacLineCell start, Beyond.UI.FacLineCell end)
  System.Void PlayLineAnimation(System.UInt32 lineId, System.String animationName, DG.Tweening.TweenCallback callback)
  System.Void PlayPortLineDecoAnimation(System.UInt32 lineId, System.String animationName, System.Boolean isStart, DG.Tweening.TweenCallback callback)
  System.Void ChangeLineColor(System.UInt32 lineId, UnityEngine.Color color)
  System.Void ClearDrawer()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.FacPipeAnimationSetting
TYPE:  class
TOKEN: 0x2000038
EXTENDS: MonoBehaviour
FIELDS:
  private   static  System.String                   PIPE_ANIMATION_PATH  // 0x0
  public            System.String                   decoInAnimation  // 0x18
  public            System.String                   decoOutAnimation  // 0x20
  public            System.String                   itemAnimation  // 0x28
  public            System.Boolean                  needBoldAnimations  // 0x30
  public            System.String                   boldDecoInAnimation  // 0x38
  public            System.String                   boldDecoOutAnimation  // 0x40
  public            System.String                   boldItemAnimation  // 0x48
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.FacRegionUpgradeEffectController
TYPE:  class
TOKEN: 0x2000039
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.GameObject          _waitUpgradeNode  // 0x18
  private           UnityEngine.GameObject          _upgradedRegionNode  // 0x20
  private           UnityEngine.GameObject          _waitUpgradeSelectNode  // 0x28
METHODS:
  System.Void _RefreshNodeState(UnityEngine.GameObject node, System.Boolean active)
  System.Void SetUpgradeState(System.Boolean isUpgraded)
  System.Void SetSelectState(System.Boolean isSelected)
  System.Void SetVisibleState(System.Boolean isVisible)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIFacTechTreePanel
TYPE:  class
TOKEN: 0x200003A
EXTENDS: UIPanelBase
FIELDS:
  private           System.Boolean                  m_inited  // 0x70
  private           System.Single                   m_zoom  // 0x74
  private           System.Single                   m_zoomValue  // 0x78
  private           UnityEngine.Vector2             m_oriSize  // 0x7C
  private           DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions>m_zoomTween  // 0x88
  private           System.Single                   m_moveLeft  // 0x90
  private           System.Single                   m_oldMoveLeft  // 0x94
  private           System.Single                   m_moveTime  // 0x98
  private           System.Boolean                  m_openTweenFinished  // 0x9C
  private           UnityEngine.Vector2             m_anchoredPosOffset  // 0xA0
  private           System.Single                   m_horizontalOffset  // 0xA8
  private           System.Single                   m_verticalOffset  // 0xAC
  private           UnityEngine.Vector2             m_lastScale  // 0xB0
  private           Beyond.UI.LuaPanel              _techTreeLuaPanel  // 0xB8
  private           Beyond.UI.UITouchPanel          _touchPanel  // 0xC0
  private           UnityEngine.RectTransform       _techTreeRectTransform  // 0xC8
  private           UnityEngine.RectTransform       _techTreePanel  // 0xD0
  private           System.Single                   _titleHight  // 0xD8
  private           System.Single                   _moveSpeed  // 0xDC
  private           System.Single                   _zoomSpeed  // 0xE0
  private           System.Single                   _zoomDefault  // 0xE4
  private           System.Single                   _zoomRangeMin  // 0xE8
  private           System.Single                   _zoomRangeMax  // 0xEC
  private           System.Single                   _showNameScale  // 0xF0
  private           System.Single                   _zoomTweenTime  // 0xF4
  private           System.Single                   _moveNodeXOffset  // 0xF8
  private           System.Single                   _moveNodeYOffset  // 0xFC
  private           System.Single                   _startZoomTweenTime  // 0x100
  private           UnityEngine.AnimationCurve      _openUICurve  // 0x108
  private           System.Single                   _movePosTime  // 0x110
  private           UnityEngine.AnimationCurve      _movePosCurve  // 0x118
  private           System.Single                   _movePanelTime  // 0x120
  private           UnityEngine.AnimationCurve      _movePanelCurve  // 0x128
  private           System.Single                   _unlockNodeTime  // 0x130
  private           UnityEngine.AnimationCurve      _unlockNodeCurve  // 0x138
  private           System.Boolean                  m_controllerInitialized  // 0x140
  private           System.Boolean                  m_isDetailShown  // 0x141
  private           System.Single                   _controllerDragSpeed  // 0x144
  private           System.Single                   _controllerZoomSpeed  // 0x148
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnRelease()
  System.Void Tick(System.Single deltaTime)
  System.Void InitData()
  System.Void _OnDrag(UnityEngine.Vector2 value)
  System.Void _OnZoom(System.Single value, System.Boolean needTween)
  System.Void _SetScale(System.Boolean needTween, System.Single zoomTweenTime, UnityEngine.AnimationCurve curve, DG.Tweening.TweenCallback onFinish)
  System.Void _RefreshAll()
  System.Void _PosAdjust()
  System.Void _RefreshPivotPosition()
  System.Void _UpdatePositionOffsetAfterZoomed()
  System.Void MoveNode(System.Single dis, System.Single nodeX, System.Single nodeY, System.Boolean ignorePos)
  System.Void FocusNode(System.Single nodeX, System.Single nodeY, DG.Tweening.TweenCallback onComplete)
  System.Void OnUnlockTech(System.Single nodeX, System.Single nodeY, DG.Tweening.TweenCallback onComplete)
  System.Void ZoomToFullTechTree(DG.Tweening.TweenCallback onComplete)
  System.Void _OnUnlockMoveNode(System.Single nodeX, System.Single nodeY)
  System.Void _ControllerUpdate()
  System.Void _ControllerZoomUpdate()
  System.Void _ControllerDragUpdate()
  System.Void SetDetailShownState(System.Boolean isShown)
  System.Void .ctor()
  System.Void <InitData>b__39_0(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void <InitData>b__39_1(System.Single zoomValue)
  System.Void <InitData>b__39_2()
  System.Void <>iFixBaseProxy_OnRelease()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.FootBarDashCell
TYPE:  class
TOKEN: 0x200003B
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Boolean                  isHalfCell  // 0x18
  public            Beyond.UI.UIImage               bgImage  // 0x20
  public            UnityEngine.RectTransform       cellTrans  // 0x28
  public            Beyond.UI.UIImage               grayImage  // 0x30
  public            Beyond.UI.UIImage               whiteImage  // 0x38
  public            Beyond.UI.UIAnimationWrapper    animWrapper  // 0x40
  private           System.Int32                    m_index  // 0x48
  private   static  System.Int32                    MAX_DASH_COUNT_IN_RING  // 0x0
  private   static  System.Single                   FILL_AMOUNT_PER_CELL  // 0x0
  private   static  System.Single                   ANGLE_PER_CELL  // 0x0
  private   static  System.Single                   ANGLE_PER_HALF_CELL  // 0x0
  private   static  System.Single                   ANGLE_PER_QUARTER_CELL  // 0x0
METHODS:
  System.Void SetIndex(System.Int32 index)
  System.Void SetDashCount(System.Single dashFillCount)
  System.Void StartPlayNotEnoughAnim()
  System.Void StopPlayNotEnoughAnim()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.ForgeIronProgressBarUI
TYPE:  class
TOKEN: 0x200003C
EXTENDS: WorldUIController
FIELDS:
  public            Beyond.UI.UIText                progressDesc  // 0xC0
  public            Beyond.UI.UIText                progressText  // 0xC8
  public            Beyond.UI.UIImage               progressImage  // 0xD0
  public            UnityEngine.Transform           progressUIRoot  // 0xD8
  private           Beyond.Gameplay.InteractiveLogicForgeIronm_logic  // 0xE0
  private           UnityEngine.CanvasGroup         m_canvasGroup  // 0xE8
METHODS:
  Beyond.TickType get_tickOption()
  System.Void Init(Beyond.Gameplay.Core.Entity target, System.String path, System.UInt64 id, System.Int32 typeSegment)
  System.Void SetPos()
  System.Void SetUIForward()
  System.Void TickUI(System.Single deltaTime)
  System.Void UpdateProgress()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Init(Beyond.Gameplay.Core.Entity P0, System.String P1, System.UInt64 P2, System.Int32 P3)
  System.Void <>iFixBaseProxy_SetPos()
  System.Void <>iFixBaseProxy_SetUIForward()
  System.Void <>iFixBaseProxy_TickUI(System.Single P0)
END_CLASS

CLASS: Beyond.UI.ForgeIronTemperatureCircleUI
TYPE:  class
TOKEN: 0x200003D
EXTENDS: WorldUIController
FIELDS:
  private   static  System.String                   AUDIO_EVENT_SUCCEED  // 0x0
  private   static readonly UnityEngine.Color               COLOR_BLUE  // 0x0
  private   static readonly UnityEngine.Color               COLOR_GREEN  // 0x10
  private   static readonly UnityEngine.Color               COLOR_RED  // 0x20
  public            Beyond.UI.UIImage               bg  // 0xC0
  public            Beyond.UI.UIImage               warningBg  // 0xC8
  public            Beyond.UI.UIText                desc  // 0xD0
  public            UnityEngine.Transform           tempCircleRoot  // 0xD8
  public            System.Int32                    belongRound  // 0xE0
  private           Beyond.Gameplay.InteractiveLogicForgeIronm_logic  // 0xE8
  private           UnityEngine.CanvasGroup         m_canvasGroup  // 0xF0
  private           System.String                   m_customDesc  // 0xF8
  private           System.String                   m_highTempDesc  // 0x100
  private           System.String                   m_lowTempDesc  // 0x108
  private           System.String                   m_goodTempDesc  // 0x110
  private           System.Boolean                  m_hasPlaySuccessAudio  // 0x118
METHODS:
  Beyond.TickType get_tickOption()
  System.Void Init(Beyond.Gameplay.Core.Entity target, System.String path, System.UInt64 id, System.Int32 typeSegment)
  System.Void Clear()
  System.Void SetPos()
  System.Void SetUIForward()
  System.Void TickUI(System.Single deltaTime)
  System.Void UpdateUIState()
  System.Void _SetState(System.Boolean max, System.Boolean low, System.Boolean high, Beyond.UI.ForgeIronTemperatureCircleUI.ETemperatureState state)
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_Init(Beyond.Gameplay.Core.Entity P0, System.String P1, System.UInt64 P2, System.Int32 P3)
  System.Void <>iFixBaseProxy_Clear()
  System.Void <>iFixBaseProxy_SetPos()
  System.Void <>iFixBaseProxy_SetUIForward()
  System.Void <>iFixBaseProxy_TickUI(System.Single P0)
END_CLASS

CLASS: Beyond.UI.ForgeIronTemperatureUI
TYPE:  class
TOKEN: 0x200003F
EXTENDS: WorldUIController
FIELDS:
  private   static readonly UnityEngine.Color               COLOR_BLUE  // 0x0
  private   static readonly UnityEngine.Color               COLOR_GREEN  // 0x10
  private   static readonly UnityEngine.Color               COLOR_RED  // 0x20
  public            System.Single                   greenBarTotalHeight  // 0xC0
  public            System.Single                   initBarPosY  // 0xC4
  public            System.Single                   totalBarPosY  // 0xC8
  public            System.Single                   initHandPosY  // 0xCC
  public            System.Single                   totalHandPosY  // 0xD0
  private           System.Single                   m_greenBarCurHeight  // 0xD4
  public            Beyond.UI.UIImage               progressImage  // 0xD8
  public            UnityEngine.RectTransform       greenBar  // 0xE0
  public            UnityEngine.RectTransform       goodHand  // 0xE8
  public            UnityEngine.Transform           temperatureUI  // 0xF0
  private           Beyond.Gameplay.InteractiveLogicForgeIronm_logic  // 0xF8
  private           UnityEngine.CanvasGroup         m_canvasGroup  // 0x100
  private           System.Boolean                  m_initBarSize  // 0x108
  private           System.Single                   m_lastMount  // 0x10C
METHODS:
  Beyond.TickType get_tickOption()
  System.Void Init(Beyond.Gameplay.Core.Entity target, System.String path, System.UInt64 id, System.Int32 typeSegment)
  System.Void SetPos()
  System.Void SetUIForward()
  System.Void TickUI(System.Single deltaTime)
  System.Void UpdateUIInfo()
  System.Void UpdateUIPos()
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_Init(Beyond.Gameplay.Core.Entity P0, System.String P1, System.UInt64 P2, System.Int32 P3)
  System.Void <>iFixBaseProxy_SetPos()
  System.Void <>iFixBaseProxy_SetUIForward()
  System.Void <>iFixBaseProxy_TickUI(System.Single P0)
END_CLASS

CLASS: Beyond.UI.GuideFakeButton
TYPE:  class
TOKEN: 0x2000040
EXTENDS: Selectable
FIELDS:
  public            Beyond.UI.UIButton              targetButton  // 0x180
  public            Beyond.UI.UIToggle              targetToggle  // 0x188
  public            Beyond.UI.UIDropdown            targetDropdown  // 0x190
  public            System.String                   targetKeyHintActionId  // 0x198
  private           System.String                   m_targetActionId  // 0x1A0
  public            System.Action                   onClick  // 0x1A8
  private           Beyond.Input.InputBindingGroupMonoTargetm_parent  // 0x1B0
METHODS:
  System.Void ForceToggleTargetBinding(System.Boolean active, System.Boolean forDrag)
  System.Void CopyTargetBinding()
  System.Void _OnTriggerPlayerAction(Beyond.EventData<System.String>& actionId)
  System.Void ClearTarget()
  System.Void ClearBinding()
  System.Void Awake()
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void ClearComponent()
  System.Void _ClearOnClick()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Awake()
  System.Void <>iFixBaseProxy_OnPointerDown(UnityEngine.EventSystems.PointerEventData P0)
  System.Void <>iFixBaseProxy_OnPointerUp(UnityEngine.EventSystems.PointerEventData P0)
  System.Void <>iFixBaseProxy_OnPointerEnter(UnityEngine.EventSystems.PointerEventData P0)
  System.Void <>iFixBaseProxy_OnPointerExit(UnityEngine.EventSystems.PointerEventData P0)
END_CLASS

CLASS: Beyond.UI.HeadBarCtrl
TYPE:  class
TOKEN: 0x2000041
EXTENDS: UIPanelBase
FIELDS:
  private           UnityEngine.GameObject          _mobHeadBarPrefab  // 0x70
  private           UnityEngine.GameObject          _eliteHeadBarPrefab  // 0x78
  private           UnityEngine.GameObject          _enemyPartHeadBarPrefab  // 0x80
  private           UnityEngine.GameObject          _levelInfoBarPrefab  // 0x88
  private           UnityEngine.GameObject          _vigilanceBarPrefab  // 0x90
  private           UnityEngine.GameObject          _tacticalItemBarPrefab  // 0x98
  private           System.Single                   _hideHeadBarNotInFightDelay  // 0xA0
  private           System.Int32                    _headBarInvisibleEnemyCount  // 0xA4
  private           System.Single                   _headBarInvisibleHpNoChangeTime  // 0xA8
  private           System.Single                   _headBarInvisibleScreenEdgeRatio  // 0xAC
  private           System.Single                   _headBarInvisibleDistance  // 0xB0
  private   static  System.Single                   TICK_SURROUNDING_INTERVAL  // 0x0
  private   static  System.String                   HEAD_BAR_BROKEN_ANIM  // 0x0
  private   static readonly System.Int32[]                  HEAD_BAR_PREWARM_CNT  // 0x0
  private           UnityEngine.Transform           m_worldObjectRoot  // 0xB8
  private   static  System.Collections.Generic.HashSet<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>>s_abilitySystemsToShowBar  // 0x8
  private   static  System.Collections.Generic.HashSet<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>>s_abilitySystemsToHideBar  // 0x10
  private   static  System.Collections.Generic.HashSet<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>>s_surroundingEnemies  // 0x18
  private           System.Single                   m_lastTickSurrounding  // 0xC0
  private           System.Boolean                  m_inDialog  // 0xC4
  private           System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,Beyond.UI.UIHeadBarFollower>m_headBarDict  // 0xC8
  private           System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,Beyond.UI.UIHeadBarFollower>m_headBarWithOutAnimDict  // 0xD0
  private           System.Collections.Generic.List<Beyond.UI.UIHeadBarFollower>m_mobHeadBarPool  // 0xD8
  private           System.Collections.Generic.List<Beyond.UI.UIHeadBarFollower>m_eliteHeadBarPool  // 0xE0
  private           System.Collections.Generic.List<Beyond.UI.UIHeadBarFollower>m_enemyPartHeadBarPool  // 0xE8
  private           System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,Beyond.Gameplay.Core.AbilitySystem.Modifier>m_nonFullHpAbilitySystems  // 0xF0
  private           System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,System.ValueTuple<Beyond.Gameplay.Core.AbilitySystem.Modifier,Beyond.Gameplay.PeriodicTimer>>m_enemyFirstDamageDict  // 0xF8
  private           System.Collections.Generic.HashSet<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>>m_enabledEnemyPartsByAction  // 0x100
  private           System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,Beyond.UI.UILvInfoBar>m_levelInfoBarDict  // 0x108
  private           System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,Beyond.UI.UILvInfoBar>m_levelInfoBarWithOutAnimDict  // 0x110
  private           System.Collections.Generic.List<Beyond.UI.UILvInfoBar>m_levelInfoBarPool  // 0x118
  private           System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,Beyond.UI.UIVigilanceBar>m_vigilanceBarDict  // 0x120
  private           System.Collections.Generic.List<Beyond.UI.UIVigilanceBar>m_vigilanceBarPool  // 0x128
  private           System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,Beyond.UI.UITacticalItemBar>m_tacticalItemBarDict  // 0x130
  private           System.Collections.Generic.Dictionary<Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>,Beyond.UI.UITacticalItemBar>m_tacticalItemBarWithOutAnimDict  // 0x138
  private           System.Collections.Generic.List<Beyond.UI.UITacticalItemBar>m_tacticalItemBarPool  // 0x140
METHODS:
  Beyond.TickType get_tickOption()
  System.Boolean get_forceHide()
  System.Void OnCreate(UnityEngine.Transform worldObjectRoot)
  System.Void OnClose()
  System.Void OnShow()
  System.Void OnHide()
  System.Void LateTick(System.Single deltaTime)
  System.Void _OnAddHeadBar(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem>& eventData)
  System.Void _OnRemoveHeadBar(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,System.Boolean>& eventData)
  System.Void _OnHeadBarShowConfigChanged()
  System.Void _OnHpChanged(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem.Modifier>& eventData)
  System.Void _OnEnemyPartEnableChanged(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystemForEnemyPart,System.Boolean>& eventData)
  System.Void _RefreshHeadBar(Beyond.UI.HeadBarCtrl.HeadBarRefreshReason reason)
  System.Void _PrewarmHeadBar()
  Beyond.UI.HeadBarCtrl.HeadBarType _GetHeadBarType(Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> abilitySystemPtr)
  System.Void _UpdateHeadBar(System.Single deltaTime)
  System.Void _UpdateLevelInfoBar(System.Single deltaTime)
  System.Void _UpdateVigilanceBar(System.Single deltaTime)
  System.Void _UpdateTacticalItemBar(System.Single deltaTime)
  System.Void _UpdateSurroundingEnemies(System.Single deltaTime)
  T _CreateBar(Beyond.UI.HeadBarCtrl.HeadBarType headBarType)
  System.Void _RecycleBar(T bar)
  System.Collections.Generic.List<T> _GetBarPool(Beyond.UI.HeadBarCtrl.HeadBarType headBarType)
  UnityEngine.GameObject _GetBarPrefab(Beyond.UI.HeadBarCtrl.HeadBarType headBarType)
  System.Void _OnInteractNpc(Beyond.EventData<System.String,Beyond.Gameplay.Core.Entity>& eventData)
  System.Void _OnDialogStart(Beyond.EventData<System.Boolean,Beyond.Gameplay.DialogEnums.DialogType>& eventData)
  System.Void _OnDialogFinish(Beyond.EventData<System.Boolean>& eventData)
  System.Void _SetInDialog(System.Boolean inDialog)
  System.Void .ctor()
  System.Void .cctor()
  System.Boolean <_RefreshHeadBar>g__ToShow|52_0(Beyond.Gameplay.Core.AbilitySystem abilitySystem)
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.HpBarComboNode
TYPE:  class
TOKEN: 0x2000047
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.GameObject          comboCountLayout  // 0x18
  public            Beyond.UI.UIText                comboCountText  // 0x20
  private           Beyond.UI.UIAnimationWrapper    m_animationWrapper  // 0x28
  private           System.Int32                    m_lastCount  // 0x30
  private   static  System.String                   COMMON_COMBO_GLOBAL_BUFF_ID  // 0x0
METHODS:
  System.Void Awake()
  System.Void OnDestroy()
  System.Void _OnGlobalBuffStart(Beyond.EventData<Beyond.Gameplay.Core.GlobalBuff,System.String>& eventData)
  System.Void _OnGlobalBuffFinish(Beyond.EventData<Beyond.Gameplay.Core.GlobalBuff,System.String,Beyond.Gameplay.Core.GlobalBuff.FinishReason>& eventData)
  System.Void _RefreshComboCount(System.Boolean isEarly)
  System.Void _AnimInCallback()
  System.Void _AnimOutCallback()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.MainCharHpBar
TYPE:  class
TOKEN: 0x2000048
EXTENDS: TickableUIMono
FIELDS:
  public            Beyond.UI.UIAnimationWrapper    hpBar  // 0x68
  public            Beyond.UI.UIText                hpText  // 0x70
  public            Beyond.UI.UIImage               hpWhiteFill  // 0x78
  public            UnityEngine.GameObject          blinkAnimObject  // 0x80
  public            System.Single                   hpBlinkPercent  // 0x88
  public            System.Single                   hpChangeColorPercent  // 0x8C
  public            Beyond.UI.UIImage               hpFillHigh  // 0x90
  public            Beyond.UI.UIImage               hpFillLow  // 0x98
  public            UnityEngine.RectTransform       hpVfxNode  // 0xA0
  public            Beyond.UI.UIImage[]             hpVfxImages  // 0xA8
  public            Beyond.SerializeFieldDictionary<Beyond.GEnums.SpellInflictionOnCharType,UnityEngine.Color>hpVfXColors  // 0xB0
  public            System.Collections.Generic.List<Beyond.UI.HpChangeDisplayData>hpChangeConfigList  // 0xB8
  public            System.Collections.Generic.List<Beyond.UI.MainCharHpBar.HpScreenEffectConfig>hpScreenEffectConfigList  // 0xC0
  public            System.Single                   hpScreenEffectCd  // 0xC8
  public            Beyond.UI.UIBuffNode            buffNode  // 0xD0
  public            Beyond.UI.UIImage               buffIcon  // 0xD8
  public            UnityEngine.Transform           leftLayout  // 0xE0
  public            UnityEngine.Transform           charPassiveNode  // 0xE8
  private   static  System.String                   HP_BLINK_ANIM  // 0x0
  private           Beyond.Gameplay.Core.Entity     m_mainChar  // 0xF0
  private           Beyond.UI.HpChangeDisplayData   m_hpChangeConfig  // 0xF8
  private           Beyond.UI.UIHeadBar.HpDisplayStatem_hpDisplayState  // 0x100
  private           System.Nullable<System.Single>  m_targetHpValue  // 0x104
  private   readonly Beyond.Gameplay.PeriodicTimer   m_hpStayTimer  // 0x110
  private           System.Boolean                  m_hpBarShowing  // 0x118
  private           System.Boolean                  m_hpBarShaking  // 0x119
  private           Beyond.UI.UIAnimationWrapper    m_hpVfxAnimWrapper  // 0x120
  private           Beyond.UI.UIHudFadeController   m_hudFadeController  // 0x128
  private   static readonly System.Collections.Generic.HashSet<System.String>s_tempCurPassiveUIPrefabNames  // 0x0
  private   static readonly System.Collections.Generic.List<System.String>s_tempUnusedPassiveUIPrefabNames  // 0x8
  private   readonly System.Collections.Generic.Dictionary<System.String,Beyond.UI.UICharPassiveBase>m_allPassiveBases  // 0x130
  private           Beyond.UI.UICharPassiveBase     m_curPassiveBase  // 0x138
  private           Beyond.UI.UIAnimationWrapper    m_buffIconAnimWrapper  // 0x140
  private           Beyond.UI.UIAnimationWrapper    m_shakeAnimWrapper  // 0x148
  private           Beyond.UI.UIAnimationWrapper    m_hpWhiteAnimWrapper  // 0x150
  private           Beyond.UnSafeString.UnSafeStringHandlem_hpTextHandle  // 0x158
  private   readonly Beyond.LuaResourceLoader        m_loader  // 0x160
  private           System.Single                   m_lastHpScreenEffectTime  // 0x168
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnAwake()
  System.Void OnEnable()
  System.Void OnRelease()
  System.Void _ClearMainChar()
  System.Void LateTick(System.Single deltaTime)
  System.Boolean _CheckHpBarShowing()
  System.Void _SetHpBarShowing(System.Boolean showing, System.Boolean animate)
  System.Void _OnMainCharChange(Beyond.EventData<Beyond.Gameplay.SetLeaderReason,Beyond.Gameplay.Core.Entity,Beyond.Gameplay.Core.Entity>& data)
  System.Void _ProcessOnMainCharChange(Beyond.Gameplay.Core.Entity newMainChar)
  System.Void _OnTeamChanged()
  System.Void _OnHpChange(Beyond.Gameplay.Core.Entity entity, System.Double change)
  System.Void _SetHpFillAmount(System.Single hpPct)
  System.Void _CalculateHpChangeDisplay(Beyond.Gameplay.Core.AbilitySystem target, System.Double deltaValue)
  System.Void _UpdateHpDisplay(System.Single deltaTime)
  System.Void _OnTakeDamage(Beyond.Gameplay.Core.Entity entity, System.Boolean hideMainCharHpScreenEffect)
  System.Void _OnMainCharHpActiveChange()
  System.Void _OnBuffChangeCharHpBarVfx(System.Nullable<Beyond.GEnums.SpellInflictionOnCharType> type)
  System.Void _HpVfxOutAnimCallback()
  System.Void _OnCharPassiveNumChanged(System.Single newNum)
  Beyond.UI.UICharPassiveBase _GetOrCreateCharPassiveBase(System.String prefabName)
  System.Void _OnBuffIconChange(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr, System.Boolean applied, Beyond.Gameplay.Core.Buff.FinishReason finishReason)
  System.Void _OnBuffEnhanceChanged(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr)
  System.Void _BlinkBuffIcon(System.String spritePath)
  System.Void .ctor()
  System.Void .cctor()
  System.Void <_SetHpBarShowing>b__47_0()
  System.Void <_BlinkBuffIcon>b__63_0(UnityEngine.Sprite sprite)
  System.Void <_BlinkBuffIcon>b__63_1()
  System.Void <_BlinkBuffIcon>b__63_2()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnRelease()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.RegionMap3DCfg
TYPE:  class
TOKEN: 0x200004A
FIELDS:
  public            UnityEngine.GameObject          model  // 0x10
  public            UnityEngine.GameObject          ground  // 0x18
  public            Beyond.UI.UIRegionMap3DUICell   ui  // 0x20
  public            UnityEngine.GameObject          glitch  // 0x28
  public            UnityEngine.Vector4             uiRect  // 0x30
  private           System.String                   _ui  // 0x40
  private           System.String                   _model  // 0x48
  private           System.String                   _ground  // 0x50
  private           System.Boolean                  <isLoaded>k__BackingField  // 0x58
METHODS:
  System.Boolean get_isLoaded()
  System.Void set_isLoaded(System.Boolean value)
  System.Void Load(Beyond.UI.RegionMapSetting regionMapSetting)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.RegionMapShowType
TYPE:  struct
TOKEN: 0x200004B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.RegionMapShowType     Map  // 0x0
  public    static  Beyond.UI.RegionMapShowType     Watch  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.RegionMapSetting
TYPE:  class
TOKEN: 0x200004C
EXTENDS: UIPanelBase
FIELDS:
  public    static  System.String                   UI_REGION_MAP_TRACK_ICON  // 0x0
  public            UnityEngine.Transform           uiRoot  // 0x70
  public            UnityEngine.Transform           buildingRoot  // 0x78
  public            UnityEngine.Transform           groundRoot  // 0x80
  private           UnityEngine.Transform           _modelNode  // 0x88
  private           UnityEngine.Transform           _uiNode  // 0x90
  private           UnityEngine.RectTransform       _uiPlayerMark  // 0x98
  private           UnityEngine.Color               _normalModelOuterColor  // 0xA0
  private           UnityEngine.Color               _selectedModelOuterColor  // 0xB0
  private           UnityEngine.Vector3             _moveFinalRotation  // 0xC0
  private           Beyond.SerializeFieldDictionary<System.String,Beyond.UI.RegionMap3DCfg>_cfg  // 0xD0
  private           UnityEngine.Transform           m_currLoadedRegionTransform  // 0xD8
  private           Beyond.UI.RegionMapShowType     m_curShowType  // 0xE0
  private           System.Single                   m_animTimer  // 0xE4
  private           System.Single                   m_animDuration  // 0xE8
  private           System.Boolean                  m_playAnim  // 0xEC
  private   readonly System.Collections.Generic.List<UnityEngine.RectTransform>m_trackIconList  // 0xF0
  private   readonly System.Collections.Generic.Dictionary<UnityEngine.Renderer,UnityEngine.Material[]>m_refreshedMaterials  // 0xF8
  private           UnityEngine.Color               m_normalLevelModelColor  // 0x100
  private   static  System.String                   OUTER_COLOR_PROPERTY_NAME  // 0x0
  private   static  UnityEngine.MaterialPropertyBlocks_materialPropertyBlock  // 0x0
METHODS:
  Beyond.TickType get_tickOption()
  System.Collections.Generic.Dictionary<System.String,Beyond.UI.RegionMap3DCfg> get_cfg()
  System.Void OnDestroy()
  System.Void _InitUI()
  System.Void _InitPlayerIcon()
  System.Void _InitTrackIcon()
  System.Void _InitSelect()
  System.Void _SetMapPos(UnityEngine.RectTransform rect, UnityEngine.Vector3 pos, Beyond.Gameplay.UILevelMapConfigInfo uiLevelMapConfig)
  System.Void _RefreshMaterials()
  System.Void _ClearMaterials()
  System.Void InitData(Beyond.UI.RegionMapShowType shotType, UnityEngine.Transform center, UnityEngine.Transform moveRoot, System.Single watchRadius)
  System.Void MoveToPlayer(UnityEngine.Transform center, UnityEngine.Transform moveRoot)
  UnityEngine.Transform GetNodeTransform(System.String levelId)
  UnityEngine.Vector3 GetNodeMoveTargetLocalPosition(System.String levelId, UnityEngine.Camera uiCamera, UnityEngine.Transform moveRoot)
  Beyond.UI.RegionMap3DCfg GetCfg(System.String levelId)
  System.Boolean IsCircleIntersectingRectangle(UnityEngine.Vector2 circleCenter, System.Single circleRadius, UnityEngine.Rect rectangle)
  System.Void SetLoadedRegionTransform(UnityEngine.Transform regionTransform)
  DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> StartRegionRectTransformMoveRotationTween(System.Single tweenDuration, UnityEngine.AnimationCurve tweenCurve)
  UnityEngine.MaterialPropertyBlock get_m_materialPropertyBlock()
  System.Void SetControllerLevelSelectedState(System.String levelId, System.Boolean isSelected)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UIFacMainRegionConfig
TYPE:  class
TOKEN: 0x200004D
FIELDS:
  public            System.String                   levelId  // 0x10
  public            System.Int32                    panelIndex  // 0x18
  public            System.Collections.Generic.List<UnityEngine.Sprite>levelSprites  // 0x20
  public            System.Collections.Generic.List<UnityEngine.Vector3>levelPositions  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIFacMainRegion
TYPE:  class
TOKEN: 0x200004E
EXTENDS: MonoBehaviour
FIELDS:
  private           System.String                   m_levelId  // 0x18
  private           System.Int32                    m_panelIndex  // 0x20
  private           System.Collections.Generic.List<Beyond.UI.UIFacMainRegionConfig>_configList  // 0x28
  private           UnityEngine.RectTransform       _rectTransform  // 0x30
  private           Beyond.UI.UIImage               _image  // 0x38
METHODS:
  System.Void _OnMainRegionLevelChanged(System.String levelId, System.Int32 panelIndex)
  System.Void _RefreshRegionState()
  System.Void OnDestroy()
  System.Void InitMainRegion(System.String levelId, System.Int32 panelIndex)
  System.Void ClearComponent()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UILevelMapCrane
TYPE:  class
TOKEN: 0x200004F
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.CombineKey               m_eventKey  // 0x18
  private           Beyond.Resource.CachedPathAssetLoaderm_assetLoader  // 0x20
  private   static  System.String                   CRANE_SPRITE_FOLDER  // 0x0
  private   static  System.String                   CRANE_GAME_VAR_KEY  // 0x0
  private           Beyond.SerializeReferenceDictionary<System.Int64,Beyond.UI.UILevelMapCrane.CraneSpritePath>_stateSpriteDict  // 0x28
  private           UnityEngine.RectTransform       _rectTransform  // 0x30
  private           Beyond.UI.UIImage               _image  // 0x38
METHODS:
  System.Void OnDestroy()
  System.Void _RefreshCraneState()
  System.Void _ClearSpriteAsset()
  System.Void _OnCraneStateChanged(Beyond.EventData<System.Int64,System.Int64>& eventData)
  System.Void _BindAll()
  System.Void _UnBindAll()
  System.Void InitCrane()
  System.Void ClearComponent()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UILevelMapGameplayArea
TYPE:  class
TOKEN: 0x2000051
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Boolean                  m_initialized  // 0x18
  private           UnityEngine.RectTransform       _rectTransform  // 0x20
  private           UnityEngine.RectTransform       _circleRectTransform  // 0x28
METHODS:
  System.Void _RefreshGameplayArea(Beyond.Gameplay.GameplayAreaInstRuntimeData areaData)
  System.Void Init(Beyond.Gameplay.GameplayAreaInstRuntimeData areaData)
  System.Void ClearComponent()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UILevelMapLimitInRect
TYPE:  class
TOKEN: 0x2000052
EXTENDS: TickableUIMono
FIELDS:
  private           System.Boolean                  m_needLimitedInRect  // 0x68
  public            UnityEngine.Vector2             originalRectPosition  // 0x6C
  public            UnityEngine.Vector3             originalWorldPosition  // 0x74
  public            System.Boolean                  isLimitedInRect  // 0x80
  public            UnityEngine.Events.UnityEvent<System.Boolean>onIsLimitedInRectChanged  // 0x88
  private           UnityEngine.RectTransform       _rectTransform  // 0x90
  private           UnityEngine.RectTransform       _limitRectTransform  // 0x98
  private           Beyond.UI.UILevelMapLimitInRect.MaskShapeType_maskShapeType  // 0xA0
  private           System.Single                   _circleLimitRadius  // 0xA4
  private           System.Collections.Generic.List<UnityEngine.GameObject>_limitActiveNodes  // 0xA8
  private           System.Collections.Generic.List<UnityEngine.GameObject>_limitInactiveNodes  // 0xB0
  private           System.Collections.Generic.List<UnityEngine.RectTransform>_limitDirectionNodes  // 0xB8
METHODS:
  Beyond.TickType get_tickOption()
  System.Void LateTick(System.Single deltaTime)
  System.Void OnEnable()
  System.Void OnRelease()
  System.Void _LimitInRect()
  System.Void ClearComponent()
  System.Void StartLimitMarkInRect()
  System.Void StopLimitMarkInRect()
  System.Void ForceRefreshLimitState()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.UILevelMapLine
TYPE:  class
TOKEN: 0x2000054
EXTENDS: TickableUIMono
FIELDS:
  private           System.Boolean                  m_initialized  // 0x68
  private           System.Single                   m_basicWidth  // 0x6C
  private           System.Single                   m_basicHeight  // 0x70
  private           System.Single                   m_extraScale  // 0x74
  public            UnityEngine.RectTransform       rectTransform  // 0x78
  public            UnityEngine.RectTransform       referenceTransform  // 0x80
  public            System.Boolean                  onlyHoldOnEnable  // 0x88
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnEnable()
  System.Void _HoldLineSize()
  System.Void LateTick(System.Single deltaTime)
  System.Void Init(System.Single basicLength)
  System.Void ClearComponent()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UILevelMapMissionArea
TYPE:  class
TOKEN: 0x2000055
EXTENDS: TickableUIMono
FIELDS:
  private           UnityEngine.GameObject          m_associatedTrackingMark  // 0x68
  private           System.Boolean                  m_initialized  // 0x70
  private   readonly UnityEngine.Vector3[]           m_disappearWorldCorners  // 0x78
  public            System.Boolean                  needUseCenterPosition  // 0x80
  private           Beyond.UI.LuaPanel              _luaPanel  // 0x88
  private           UnityEngine.RectTransform       _rectTransform  // 0x90
  private           UnityEngine.RectTransform       _circleRectTransform  // 0x98
  private           UnityEngine.CanvasGroup         _canvasGroup  // 0xA0
  private           System.Boolean                  _coexistWithMissionTrack  // 0xA8
  private           UnityEngine.RectTransform       _disappearRect  // 0xB0
  private           Beyond.UI.UILevelMapMissionArea.DisappearRectShapeType_disappearRectShape  // 0xB8
  private           System.Single                   _disappearCircleRadius  // 0xBC
METHODS:
  Beyond.TickType get_tickOption()
  System.Void LateTick(System.Single deltaTime)
  System.Void _RefreshMissionArea(Beyond.Gameplay.MissionTrackingMarkInstRuntimeDate missionMarkInstRuntimeData)
  System.Boolean _IsCircleOutsideDisappearRect()
  System.Void _DisappearIfOutRect()
  System.Void Init(Beyond.Gameplay.MissionTrackingMarkInstRuntimeDate missionMarkInstRuntimeData, UnityEngine.GameObject associatedTrackingMark)
  System.Void ClearComponent()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UILevelMapMisty
TYPE:  class
TOKEN: 0x2000057
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.CombineKey               m_eventKey  // 0x18
  private           System.Boolean                  m_needBind  // 0x1C
  private   static  System.Int64                    INVISIBLE_STATE_VALUE  // 0x0
  private   static  System.String                   MISTY_GAME_VAR_KEY  // 0x0
METHODS:
  System.Void OnDestroy()
  System.Void _RefreshMistyState()
  System.Void _OnMistyStateChanged(Beyond.EventData<System.Int64,System.Int64>& eventData)
  System.Void _BindAll()
  System.Void _UnBindAll()
  System.Void InitMisty()
  System.Boolean IsMistyVisible()
  System.Void ClearComponent()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UILevelMapSwitchBtn
TYPE:  class
TOKEN: 0x2000058
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.UI.UIButton              _button  // 0x18
  private           Beyond.UI.UIText                _text  // 0x20
  private           UnityEngine.GameObject          _mainContent  // 0x28
  private           UnityEngine.RectTransform       _direction  // 0x30
METHODS:
  System.Void InitSwitchButton(System.String targetLevelId, System.Single directionAngle)
  System.Void ClearComponent()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UILevelMapTouchPanelWrapper
TYPE:  class
TOKEN: 0x200005A
EXTENDS: TickableUIMono
FIELDS:
  private           Beyond.UI.UITouchPanel          _touchPanel  // 0x68
  private           System.Single                   _scrollCorrectionCoefficient  // 0x70
  private           UnityEngine.Transform           _raycastRoot  // 0x78
  private           System.Int32                    m_lastTouchCount  // 0x80
  private           UnityEngine.EventSystems.PointerEventDatam_dragPointerEventData  // 0x88
  private           UnityEngine.EventSystems.PointerEventDatam_scrollPointerEventData  // 0x90
  private           System.Boolean                  m_inWrapperDragging  // 0x98
  private           UnityEngine.Vector2             m_lastPointerPos  // 0x9C
  private   readonly System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>m_raycastResults  // 0xA8
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnAwake()
  System.Void Tick(System.Single deltaTime)
  System.Boolean _IsFirstRaycastSelectable(UnityEngine.EventSystems.PointerEventData pointerEventData)
  System.Void _CheckDrag()
  System.Void _CheckScroll()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIRegionMap3DPanel
TYPE:  class
TOKEN: 0x200005B
EXTENDS: UIPanelBase
FIELDS:
  public    static  System.String                   HOVER_ANIM_NAME  // 0x0
  private           Beyond.UI.LuaPanel              _luaPanel  // 0x70
  private           Beyond.UI.UIAnimationWrapper    _panelAnimationWrapper  // 0x78
  private           UnityEngine.Transform           _zoomRoot  // 0x80
  private           UnityEngine.Transform           _moveRoot  // 0x88
  private           System.Single                   _moveDuration  // 0x90
  private           System.Single                   _completeRatio  // 0x94
  private           UnityEngine.AnimationCurve      _moveCurve  // 0x98
  private           UnityEngine.AnimationCurve      _rotationCurve  // 0xA0
  private           System.Single                   _zoomDistance  // 0xA8
  private           UnityEngine.AnimationCurve      _zoomCurve  // 0xB0
  private           Beyond.UI.RegionMapSetting      m_regionMapSetting  // 0xB8
  private           System.String                   m_toLevel  // 0xC0
  private           System.String                   m_toInsId  // 0xC8
  private           DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions>m_moveTween  // 0xD0
  private           DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions>m_rotateTween  // 0xD8
  private           DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions>m_zoomTween  // 0xE0
METHODS:
  Beyond.TickType get_tickOption()
  UnityEngine.Transform _GetNodeTransform(System.String levelId)
  UnityEngine.Vector3 _GetMoveTargetLocalPosition(System.String levelId)
  System.Void _OnDoMoveTween()
  System.Void InitPanel(Beyond.UI.RegionMapSetting regionMapSetting)
  System.Void OnClickLevelBtn(System.String levelId, System.String insId)
  System.Void OnLevelHoverChanged(System.String levelId, System.Boolean isHover)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIRegionMap3DUICell
TYPE:  class
TOKEN: 0x200005C
EXTENDS: UIPanelBase
FIELDS:
  public            Beyond.UI.UIText                showName  // 0x70
  public            UnityEngine.RectTransform       iconRoot  // 0x78
  public            Beyond.UI.UIButton              btn  // 0x80
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIRegionMapTrackIcon
TYPE:  class
TOKEN: 0x200005D
EXTENDS: UIPanelBase
FIELDS:
  private           Beyond.UI.UIImage               _icon  // 0x70
  private           Beyond.UI.UIImage               _track  // 0x78
METHODS:
  System.Void InitData(Beyond.Gameplay.MissionTrackingMarkInstRuntimeDate data)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UISettlementRegion
TYPE:  class
TOKEN: 0x200005E
EXTENDS: MonoBehaviour
FIELDS:
  private           System.String                   m_settlementId  // 0x18
  private           Beyond.UI.UISettlementRegion.SettlementRegionSpriteDatam_settlementSpriteData  // 0x20
  private           System.Boolean                  m_needBind  // 0x28
  private           Beyond.CombineKey               m_bindKey  // 0x2C
  private           Beyond.SerializeFieldDictionary<System.String,Beyond.UI.UISettlementRegion.SettlementRegionSpriteData>_spriteDict  // 0x30
  private           UnityEngine.RectTransform       _rectTransform  // 0x38
  private           Beyond.UI.UIImage               _image  // 0x40
  public    static  System.String                   SETTLEMENT_REGION_SPRITE_FOLDER  // 0x0
METHODS:
  System.Void OnDestroy()
  System.Void _RefreshSpriteWithTier(System.Int32 tier)
  System.Void _RefreshSettlementRegionState()
  System.Void _OnSettlementUnlocked(Beyond.EventData<System.String>& param)
  System.Void _BindAll()
  System.Void _UnBindAll()
  System.Void InitSettlementRegion(System.String settlementId, UnityEngine.Vector3 centerPos)
  System.Boolean GetNeedRefreshSettlementRegionTier()
  System.Void RefreshSettlementRegionWithTier(System.Int32 tier)
  System.Void ClearComponent()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.ChessboardDrop
TYPE:  class
TOKEN: 0x2000061
EXTENDS: UIBehaviour
FIELDS:
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onDropEvent  // 0x18
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onPointerEnterEvent  // 0x20
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onPointerExitEvent  // 0x28
METHODS:
  System.Void OnDrop(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  System.Boolean _CheckEventValid(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void ClearComponent()
  System.Void OnDestroy()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.PuzzleCellDrag
TYPE:  class
TOKEN: 0x2000062
EXTENDS: UIBehaviour
FIELDS:
  private           Beyond.UI.PuzzleDrag            m_parent  // 0x18
  private           System.Boolean                  _needHovering  // 0x20
METHODS:
  System.Void Init(Beyond.UI.PuzzleDrag puzzleDrag)
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.PuzzleControllerHelper
TYPE:  class
TOKEN: 0x2000063
EXTENDS: UIBehaviour
FIELDS:
  private           Beyond.UI.LuaPanel              m_luaPanel  // 0x18
  private           UnityEngine.EventSystems.PointerEventDatam_controllerFocusEventData  // 0x20
  private   readonly System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>m_raycastResults  // 0x28
METHODS:
  System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> get_raycastResults()
  System.Void Awake()
  System.Int32 TryGetPuzzleSlotIndexByPos(UnityEngine.RectTransform gridCell)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Awake()
END_CLASS

CLASS: Beyond.UI.PuzzleDrag
TYPE:  class
TOKEN: 0x2000064
EXTENDS: UIBehaviour
FIELDS:
  private           UnityEngine.CanvasGroup         m_canvasGroup  // 0x18
  private           Beyond.UI.LuaPanel              m_panel  // 0x20
  private           System.Int32                    m_luaIndex  // 0x28
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onBeginDragEvent  // 0x30
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onDragEvent  // 0x38
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onEndDragEvent  // 0x40
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onPointerDownEvent  // 0x48
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onPointerUpEvent  // 0x50
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onPointerClickEvent  // 0x58
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onPointerEnterEvent  // 0x60
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onPointerExitEvent  // 0x68
METHODS:
  Beyond.UI.LuaPanel get_panel()
  System.Int32 get_luaIndex()
  System.Void Awake()
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void ClearComponent()
  System.Void OnDestroy()
  System.Void SetIndex(System.Int32 index)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Awake()
  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.OutOfScreenTargetsCtrl
TYPE:  class
TOKEN: 0x2000065
EXTENDS: UIPanelBase
FIELDS:
  public            System.Single                   ellipseXRadius  // 0x70
  public            System.Single                   ellipseYRadius  // 0x74
  public            UnityEngine.RectTransform       main  // 0x78
  public            UnityEngine.RectTransform       arrowModel  // 0x80
  private   readonly System.Collections.Generic.List<Beyond.UI.OutOfScreenTargetsCtrl.Arrow>m_arrows  // 0x88
  private   readonly System.Collections.Generic.List<Beyond.UI.OutOfScreenTargetsCtrl.Arrow>m_arrowsCache  // 0x90
  private   readonly System.Collections.Generic.List<Beyond.UI.OutOfScreenTargetsCtrl.Arrow>m_arrowsWithOutAnimation  // 0x98
  private   readonly System.Collections.Generic.List<UnityEngine.Vector3>m_targetScrPoses  // 0xA0
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnCreate()
  System.Void OnShow()
  System.Void LateTick(System.Single deltaTime)
  Beyond.UI.OutOfScreenTargetsCtrl.Arrow _CreateOneArrow()
  System.ValueTuple<UnityEngine.Vector2,System.Single> _ScreenPosToUIPos(UnityEngine.Vector3 screenPos)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.SkillButton
TYPE:  class
TOKEN: 0x2000068
EXTENDS: UIPanelBase
FIELDS:
  private   static  System.Single                   HIGHLIGHT_CHECK_INTERVAL  // 0x0
  private   static  System.String                   UI_SPRITE_SKILL_ICON  // 0x0
  private   static  System.String                   UI_SPRITE_KEY_ICON  // 0x0
  public            UnityEngine.CanvasGroup         viewNodeCanvasGroup  // 0x70
  public            Beyond.UI.UIAnimationWrapper    deadNode  // 0x78
  public            UnityEngine.GameObject          emptyNode  // 0x80
  public            System.Single                   deadAlpha  // 0x88
  public            UnityEngine.Color               colorDefault  // 0x8C
  public            UnityEngine.Color               colorRed  // 0x9C
  public            UnityEngine.Color               colorYellow  // 0xAC
  public            UnityEngine.Color               colorBlue  // 0xBC
  public            UnityEngine.Color               colorGreen  // 0xCC
  public            System.Single                   cantCastSkillAlpha  // 0xDC
  public            Beyond.UI.UIButton              normalButton  // 0xE0
  public            Beyond.UI.UIImage               normalIcon  // 0xE8
  public            Beyond.UI.UIImage               normalIconShadow  // 0xF0
  public            Beyond.UI.UIImage               normalColorBg  // 0xF8
  public            Beyond.UI.UIImage               cdMask  // 0x100
  public            Beyond.UI.UIImage               cdBg  // 0x108
  public            Beyond.UI.UIText                cdText  // 0x110
  public            Beyond.UI.UIAnimationWrapper    cdRefresh  // 0x118
  public            UnityEngine.CanvasGroup         normalCanvasGroup  // 0x120
  public            Beyond.UI.UIAnimationWrapper    strengLight  // 0x128
  public            UnityEngine.GameObject          normalMoveEffectsBg  // 0x130
  public            Beyond.UI.UIAnimationWrapper    hint  // 0x138
  public            Beyond.UI.UIAnimationWrapper    normalButtonAnim  // 0x140
  public            UnityEngine.Transform           normalKeyHint  // 0x148
  public            Beyond.UI.UIImage               notRecommendMask  // 0x150
  public            Beyond.UI.UIImage               notRecommendIcon  // 0x158
  public            Beyond.UI.UIImage               normalPressFill  // 0x160
  public            Beyond.UI.UIButton              ultimateButton  // 0x168
  public            Beyond.UI.UIImage               ultimateIcon  // 0x170
  public            Beyond.UI.UIImage               ultimateIconShadow  // 0x178
  public            Beyond.UI.UIImage               ultimateColorBg  // 0x180
  public            Beyond.UI.UIImage               uspRing  // 0x188
  public            Beyond.UI.UIImage               uspRingSmall  // 0x190
  public            Beyond.UI.UIImage               centerImage  // 0x198
  public            Beyond.UI.UIImage               glow01  // 0x1A0
  public            Beyond.UI.UIImage               outRing  // 0x1A8
  public            UnityEngine.CanvasGroup         ultimateCanvasGroup  // 0x1B0
  public            Beyond.UI.UIImage               pressFill  // 0x1B8
  public            Beyond.UI.UIAnimationWrapper    ultimateButtonAnim  // 0x1C0
  public            Beyond.UI.UIImage               ultKeyIcon  // 0x1C8
  public            UnityEngine.Transform           ultKeyHint  // 0x1D0
  public            System.Single                   uspFillSpeed  // 0x1D8
  public            Beyond.UI.UIImage               ultimateFillCompleteImage  // 0x1E0
  public            UnityEngine.GameObject          ultimateBar  // 0x1E8
  public            Beyond.UI.UIImage               ultimateBarFill  // 0x1F0
  public            System.Single                   ultimateBarFillMin  // 0x1F8
  public            System.Single                   ultimateBarFillMax  // 0x1FC
  public            Beyond.UI.UIImage               ultimateCdFill  // 0x200
  public            Beyond.UI.UIImage               ultimateBarFillFrame  // 0x208
  public            Beyond.UI.UIImage               touchPressUspRing  // 0x210
  public            UnityEngine.RectTransform       touchPressIndicator  // 0x218
  private           System.Int32                    m_charIndex  // 0x220
  private           Beyond.DeviceInfo.InputType     m_panelType  // 0x224
  private           Beyond.Gameplay.CharInfo        m_charInfo  // 0x228
  private           Beyond.Gameplay.Core.SkillData  m_ultimateSkillData  // 0x230
  private           Beyond.Gameplay.Core.SkillData  m_normalSkillData  // 0x238
  private           Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>m_charAbilityPtr  // 0x240
  private           Beyond.Gameplay.Core.Skill      m_normalSkill  // 0x250
  private           Beyond.Gameplay.Core.Skill      m_ultimateSkill  // 0x258
  private           System.Boolean                  m_isEmpty  // 0x260
  private           System.Boolean                  m_ultimatePressing  // 0x261
  private           System.Single                   m_ultimatePressingTime  // 0x264
  private           System.Boolean                  m_isDeadState  // 0x268
  private           System.Boolean                  m_normalSkillReady  // 0x269
  private           System.Single                   m_lastHighlightCheckTime  // 0x26C
  private           System.Single                   m_uspTargetFill  // 0x270
  private           UnityEngine.Color               m_normalIconShadowDefaultColor  // 0x274
  private           System.Boolean                  m_showNotRecommendState  // 0x284
  private           Beyond.UI.SkillButton.PressHandlerm_pressHandler  // 0x288
  private           System.Boolean                  m_hasNotRecommendIcon  // 0x290
  private           Beyond.UI.UIAnimationWrapper    m_ultimateBarAnim  // 0x298
  private           Beyond.HudFadeType              m_hudFadeType  // 0x2A0
  private           System.String                   m_actionId  // 0x2A8
  private   static  System.Action<System.Int32>     s_onPressSkillButtonStart  // 0x0
METHODS:
  Beyond.TickType get_tickOption()
  Beyond.Gameplay.SkillSetting get_skillSetting()
  System.Void OnAwake()
  System.Void OnEnable()
  System.Void Close()
  System.Void FirstTimeInit(System.Int32 charIndex, System.Boolean isDefaultPanel, System.Boolean isControllerPanel)
  System.Void RefreshSkillButton()
  System.Boolean _TryGetAliveAbilitySystem(Beyond.Gameplay.Core.AbilitySystem& abilitySys)
  System.Boolean _MustUpdate()
  System.Void PreTick(System.Single deltaTime)
  System.Void _InitSkillData()
  System.Void _UpdateMainUI(System.Single deltaTime)
  System.Void _CheckNormalSkillHighlight()
  System.Void _SetNotRecommendState(System.Boolean active)
  System.Void OnCharacterDie()
  System.Void _RefreshDeadState(System.Boolean anim)
  System.Void _SetUspFillAmount(System.Single fillAmount)
  System.Void _SetPressFillActive(System.Boolean active)
  System.Void _SetPressFillAmount(System.Single fillAmount)
  System.Void OnUspChange(Beyond.Gameplay.Core.Entity entity)
  System.Boolean _CanCastSkill(Beyond.Gameplay.Core.Skill skill)
  System.Void CastSkill(Beyond.Gameplay.Core.Skill skill)
  System.Void OnPressSkillStart(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void _OnOtherPressSkillButtonStart(System.Int32 charIndex)
  System.Void OnPressSkillEnd(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPressCancelled()
  System.Void _CastUltimateSkill()
  System.Void OnPressUltimateSkillStart(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void _PressUltimateSkillUpdate(System.Single deltaTime)
  System.Void OnPressUltimateSkillEnd(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void ToggleControllerSkillIndicator(System.Boolean active)
  System.Void _OnCharPotentialUnlock(Beyond.EventData<System.UInt64,System.UInt32>& eventData)
  System.Void _OnCharNormalSkillChange(Beyond.EventData<System.UInt64,System.String>& eventData)
  System.Void _OnSkillUpgradeSuccess(Beyond.EventData<System.UInt64,System.String,System.Int32>& eventData)
  System.Void _OnSkillButtonActiveConfigChanged()
  System.Void _OnInputActionKeyUpdated(Beyond.EventData<System.String>& eventData)
  System.Void _UpdateLongPressKeyHint()
  System.Void _SetGoActive(System.Boolean active)
  System.Void SetEmpty(System.Boolean isEmpty)
  System.Void ClearBtnClick()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnEnable()
END_CLASS

CLASS: Beyond.UI.SquadIcon
TYPE:  class
TOKEN: 0x200006E
EXTENDS: UIPanelBase
FIELDS:
  private   static  System.String                   UI_CHAR_HEAD_PREFIX  // 0x0
  private   static  System.String                   UI_SPRITE_DIR_CHAR_HEAD  // 0x0
  private   static  System.String                   UI_SPRITE_DIR_ITEM  // 0x0
  private   static  System.Single                   HP_CHANGE_TOLERANCE  // 0x0
  public    static  System.String                   CHAR_PASSIVE_UI_PATH  // 0x0
  public            Beyond.UI.UIButton              button  // 0x70
  public            UnityEngine.CanvasGroup         canvasGroup  // 0x78
  public            Beyond.UI.UIAnimationWrapper    charIconNode  // 0x80
  public            UnityEngine.CanvasGroup         keyHint  // 0x88
  public            UnityEngine.GameObject          viewNode  // 0x90
  public            UnityEngine.GameObject          emptyNode  // 0x98
  public            Beyond.UI.UIAnimationWrapper    viewAnimationWrapper  // 0xA0
  public            Beyond.UI.UIAnimationWrapper    layoutAnimationWrapper  // 0xA8
  public            System.Single                   cantSwitchAlpha  // 0xB0
  public            Beyond.UI.UIImage               characterIcon  // 0xB8
  public            Beyond.UI.UIImage               characterIconDead  // 0xC0
  public            Beyond.UI.UIImage               charCdMask  // 0xC8
  public            Beyond.UI.UIAnimationWrapper    charMainEffectNode  // 0xD0
  public            Beyond.UI.UIAnimationWrapper    charDeadNode  // 0xD8
  public            UnityEngine.GameObject          hpNode  // 0xE0
  public            Beyond.UI.UIAnimationWrapper    hpFlashAnim  // 0xE8
  public            Beyond.UI.UISlider              hpSlider  // 0xF0
  public            System.Single                   hpFlashPercent  // 0xF8
  public            System.Single                   hpRedPercent  // 0xFC
  public            System.Single                   hpShakePercent  // 0x100
  public            Beyond.UI.UIImage               hpFill  // 0x108
  public            Beyond.UI.UIImage               hpRedFill  // 0x110
  public            Beyond.UI.UIAnimationWrapper    hpRecoverAnim  // 0x118
  public            UnityEngine.RectTransform       hpVfxNode  // 0x120
  public            Beyond.UI.UIImage[]             hpVfxImages  // 0x128
  public            Beyond.SerializeFieldDictionary<Beyond.GEnums.SpellInflictionOnCharType,UnityEngine.Color>hpVfXColors  // 0x130
  public            UnityEngine.GameObject          levelNode  // 0x138
  public            Beyond.UI.UIAnimationWrapper    levelUpAnim  // 0x140
  public            Beyond.UI.UIText                animLevelTxt  // 0x148
  public            Beyond.UI.UIText                levelTxt  // 0x150
  public            UnityEngine.RectTransform       comboCdNode  // 0x158
  public            Beyond.UI.UIAnimationWrapper    comboCdBarAnim  // 0x160
  public            Beyond.UI.UIImage               comboCdFill  // 0x168
  public            Beyond.UI.UIAnimationWrapper    comboReadyAnim  // 0x170
  public            Beyond.UI.UIBuffNode            buffNode  // 0x178
  public            UnityEngine.CanvasGroup         tacticalCanvasGroup  // 0x180
  public            UnityEngine.GameObject          tacticalCdNode  // 0x188
  public            UnityEngine.GameObject          tacticalCastBar  // 0x190
  public            UnityEngine.GameObject          tacticalDotNode  // 0x198
  public            UnityEngine.GameObject          tacticalProhibitNode  // 0x1A0
  public            UnityEngine.GameObject          tacticalEmptyNode  // 0x1A8
  public            Beyond.UI.UIImage               tacticalIcon  // 0x1B0
  public            Beyond.UI.UIImage               tacticalCastFill  // 0x1B8
  public            System.Single                   tacticalDeadAlpha  // 0x1C0
  public            System.Single                   tacticalItemUsedUpAlpha  // 0x1C4
  public            UnityEngine.GameObject          fixedIcon  // 0x1C8
  public            UnityEngine.GameObject          trailIcon  // 0x1D0
  public            UnityEngine.GameObject          indieTrailIcon  // 0x1D8
  public            UnityEngine.CanvasGroup         igniteBuffTextNode  // 0x1E0
  public            UnityEngine.Animation           igniteBuffTextAnim  // 0x1E8
  public            Beyond.UI.UIText                igniteBuffText  // 0x1F0
  public            UnityEngine.Color               igniteBuffColorPulse  // 0x1F8
  public            UnityEngine.Color               igniteBuffColorCryst  // 0x208
  public            UnityEngine.Color               igniteBuffColorNatural  // 0x218
  public            UnityEngine.Color               igniteBuffColorFire  // 0x228
  public            UnityEngine.Transform           charPassiveNode  // 0x238
  private           System.Boolean                  <isEmpty>k__BackingField  // 0x240
  private           Beyond.DeviceInfo.InputType     m_panelType  // 0x244
  private           System.Boolean                  m_isMainCharacter  // 0x248
  private           System.Boolean                  m_teamSwitchUnlocked  // 0x249
  private           System.Int32                    m_charIndex  // 0x24C
  private           System.String                   m_charIndexStr  // 0x250
  private           Beyond.Gameplay.CharInfo        m_charInfo  // 0x258
  private           Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>m_charAbilityPtr  // 0x260
  private           System.Collections.Generic.List<Beyond.UI.TacticalDotCell>m_tacticalDots  // 0x270
  private           System.Single                   m_tacticalCastFillMax  // 0x278
  private           System.Int32                    m_lastLevel  // 0x27C
  private           System.Boolean                  m_indicatorShowing  // 0x280
  private           System.Boolean                  m_lastComboCdReady  // 0x281
  private           System.Boolean                  m_comboReadyAnimShowing  // 0x282
  private           System.Boolean                  m_comboIconShowing  // 0x283
  private           Beyond.UI.UIHudFadeController   m_hudFadeController  // 0x288
  private           Beyond.UI.UIAnimationWrapper    m_hpVfxAnimWrapper  // 0x290
  private           System.String                   m_lastCharPassiveName  // 0x298
  private           Beyond.UI.UICharPassiveBase     m_charPassiveBase  // 0x2A0
  private           DG.Tweening.Sequence            m_keyHintFadeSequence  // 0x2A8
  private           System.Boolean                  m_inDeadState  // 0x2B0
  private           Beyond.UI.UIAnimationWrapper    m_tacticalSwitchAnim  // 0x2B8
  private           System.Nullable<System.Boolean> m_tacticalInProgress  // 0x2C0
  private           System.Int32                    m_tacticalItemLastDisplayCount  // 0x2C4
  private           System.Single                   m_comboCdNodeHeight  // 0x2C8
METHODS:
  Beyond.TickType get_tickOption()
  System.Boolean get_isEmpty()
  System.Void set_isEmpty(System.Boolean value)
  System.Void OnAwake()
  System.Void FirstTimeInit(System.Int32 index, System.Boolean isDefaultPanel, System.Boolean isControllerPanel)
  System.Void Close()
  System.Void InitSquadIcon(System.Boolean showFixed, System.Boolean showTrail)
  System.Boolean _MustUpdate()
  System.Void LateTick(System.Single deltaTime)
  System.Boolean _TryGetAliveAbilitySystem(Beyond.Gameplay.Core.AbilitySystem& abilitySys)
  System.Void _UpdateComboSkillIcon(System.Boolean showAnim)
  System.Void SetEmpty(System.Boolean empty)
  System.Void ToggleIndicator(System.Boolean isShow)
  System.Void InformKeyHint()
  System.Void _OnHpChange(Beyond.Gameplay.Core.Entity entity, System.Double change)
  System.Void _SetLevelText()
  System.Void _OnIgniteBuffText(Beyond.EventData<System.UInt64,System.String,Beyond.GEnums.EnergyShardType>& eventData)
  System.Void OnLevelChange()
  System.Void _TryShowLevelUpAnim()
  System.Void SetDeadState(System.Boolean dead)
  System.Void _UpdateIconAlpha()
  System.Boolean CanSwitchToCenter(System.Boolean showTip)
  System.Void OnPressCharIconStart(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnTacticalItemChange()
  System.Void _UpdateTacticalItemStatus()
  System.Void OnTeamSwitchUnlocked()
  System.Void _OnMainCharChange(Beyond.EventData<Beyond.Gameplay.SetLeaderReason,Beyond.Gameplay.Core.Entity,Beyond.Gameplay.Core.Entity>& data)
  System.Void _OnBuffChangeCharHpBarVfx(System.Nullable<Beyond.GEnums.SpellInflictionOnCharType> type)
  System.Void _HpVfxOutAnimCallback()
  System.Void _OnCharPassiveNumChanged(System.Single newNum)
  System.Void .ctor()
  System.Void <_UpdateComboSkillIcon>b__98_0()
  System.Void <_UpdateComboSkillIcon>b__98_1()
  System.Void <_OnHpChange>b__102_0()
  System.Void <_TryShowLevelUpAnim>b__106_0()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.TacticalDotCell
TYPE:  class
TOKEN: 0x200006F
EXTENDS: MonoBehaviour
FIELDS:
  public            Beyond.UI.UIImage               dotBg  // 0x18
  public            Beyond.UI.UIImage               dot  // 0x20
  public            Beyond.UI.UIImage               dotWarning  // 0x28
  private           Beyond.UI.UIAnimationWrapper    _anim  // 0x30
  private           System.Boolean                  _showDotWarning  // 0x38
  private           System.Boolean                  m_markInit  // 0x39
  private           System.Boolean                  m_isDotActive  // 0x3A
METHODS:
  System.Void Init()
  System.Void SetDotActive(System.Boolean isActive, System.Boolean playAnim)
  System.Void SetDotUsedUp(System.Boolean isUsedUp)
  System.Void .ctor()
  System.Void <SetDotActive>b__8_0()
END_CLASS

CLASS: Beyond.UI.UIAbilityTargetFollower
TYPE:  class
TOKEN: 0x2000070
EXTENDS: UIPanelBase
FIELDS:
  public            Beyond.Gameplay.MountPoint      mountPoint  // 0x70
  public            System.Single                   minDistance  // 0x74
  public            System.Single                   maxDistance  // 0x78
  public            UnityEngine.AnimationCurve      scaleCurve  // 0x80
  public            System.Single                   deltaTowardCamera  // 0x88
  public            System.Boolean                  applyHeadBar2DOffset  // 0x8C
  public            System.Boolean                  outOfScreenCorrection  // 0x8D
  public            System.Single                   startCorrectionScreenHeight  // 0x90
  public            System.Single                   endCorrectionScreenHeight  // 0x94
  public            UnityEngine.Canvas              canvas  // 0x98
  public            UnityEngine.CanvasGroup         canvasGroup  // 0xA0
  public            Beyond.UI.UIAnimationWrapper    animationWrapper  // 0xA8
  protected         Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>m_target  // 0xB0
  protected         UnityEngine.Transform           m_followTransform  // 0xC0
  private           UnityEngine.Transform           m_cameraTransform  // 0xC8
  private           UnityEngine.Vector3             m_preDeltaPosition  // 0xD0
  private           System.Single                   m_preDeltaDistance  // 0xDC
  private           System.Boolean                  m_needReassignFollowTransform  // 0xE0
  private           System.Single                   m_deltaTowardCamera  // 0xE4
  private           UnityEngine.Vector3             m_originalScale  // 0xE8
  protected         System.Boolean                  m_distanceVisible  // 0xF4
METHODS:
  Beyond.TickType get_tickOption()
  System.Boolean get_actualVisible()
  System.Nullable<UnityEngine.Vector3> get_followPosition()
  System.Void OnAwake()
  System.Void TailLateTick(System.Single deltaTime)
  System.Void SetTarget(Beyond.Gameplay.Core.AbilitySystem target)
  System.Void Clear()
  System.Void UpdateData(System.Single deltaTime)
  System.Void _TryRefreshFollowTransform()
  System.Void _UpdateSelfTransform()
  System.Void _UpdatePos()
  System.Void _UpdateScale()
  System.Void _SetDistanceVisible(System.Boolean visible)
  System.Void SetActualVisible(System.Boolean visible)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_TailLateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIAttachedBuffCell
TYPE:  class
TOKEN: 0x2000071
EXTENDS: UIBuffCell
FIELDS:
  private           Beyond.UI.UIImage               _buffIconPhantom  // 0x78
  private           Beyond.UI.UIImage               _buffStackRing  // 0x80
  private           System.Collections.Generic.List<Beyond.UI.UIAnimationWrapper>_buffStackRingConsumeAnims  // 0x88
  private           System.Single                   _stackRingFillChangeSpeed  // 0x90
  private           System.Single                   _igniteFillDelay  // 0x94
  private   static  System.String                   BUFF_ANIM_IGNITE  // 0x0
  private           System.Int32                    m_maxStackCount  // 0x98
  private           System.Nullable<System.Single>  m_targetStackRingFillAmount  // 0x9C
  private           Beyond.Gameplay.PeriodicTimer   m_igniteFillDelayTimer  // 0xA8
  private           System.Boolean                  m_isInConsumeAnim  // 0xB0
METHODS:
  System.Void DataInit(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr)
  System.Void UpdateBuffCell()
  System.Void BeforePlayOutAnim()
  System.Void SetBuffIcon(UnityEngine.Sprite sprite)
  System.Void SetStackElementActive(System.Boolean showStackCount)
  System.Void SetStackCount(System.Int32 stackCount, System.Boolean playAnim)
  System.Void OnBuffIgnite()
  System.Void .ctor()
  System.Void <SetStackCount>b__15_0()
  System.Void <>iFixBaseProxy_DataInit(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> P0)
  System.Void <>iFixBaseProxy_UpdateBuffCell()
  System.Void <>iFixBaseProxy_BeforePlayOutAnim()
  System.Void <>iFixBaseProxy_SetBuffIcon(UnityEngine.Sprite P0)
  System.Void <>iFixBaseProxy_SetStackElementActive(System.Boolean P0)
  System.Void <>iFixBaseProxy_SetStackCount(System.Int32 P0, System.Boolean P1)
  System.Void <>iFixBaseProxy_OnBuffIgnite()
END_CLASS

CLASS: Beyond.UI.UIBrokenLine
TYPE:  class
TOKEN: 0x2000072
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Material            m_material  // 0x18
  private   static  System.Int32                    MAX_SET_VALUE_COUNT  // 0x0
  private   static  System.String                   UI_BROKEN_LINE_SHADER_NAME  // 0x0
  private   static  System.String                   Y_VALUE_PROPERTY_NAME_FORMAT  // 0x0
  private   static  System.String                   X_SCALE_PROPERTY_NAME  // 0x0
  private   static  System.String                   LINE_WEIGHT_PROPERTY_NAME  // 0x0
  private           System.Collections.Generic.List<System.Single>m_tmpList  // 0x20
  private           System.Boolean                  m_isInit  // 0x28
  private           System.Single                   _lineWeight  // 0x2C
METHODS:
  System.Void Awake()
  System.Void _Init()
  System.Void OnDestroy()
  System.Void SetYValueByArray(System.Single[] yValue, System.Int32 count)
  System.Void SetYValue(System.Collections.Generic.List<System.Single> yValue, System.Int32 count)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIBuffCell
TYPE:  class
TOKEN: 0x2000073
EXTENDS: MonoBehaviour
FIELDS:
  protected         Beyond.UI.UIImage               _buffIcon  // 0x18
  protected         System.Boolean                  _canShowStackCountText  // 0x20
  protected         UnityEngine.GameObject          _stackCountTextNode  // 0x28
  protected         Beyond.UI.UIText                _buffStackCountText  // 0x30
  protected         Beyond.UI.UIAnimationWrapper    _anim  // 0x38
  protected         UnityEngine.CanvasGroup         _canvasGroup  // 0x40
  protected         System.Boolean                  _canShowWarningBg  // 0x48
  protected         Beyond.UI.UIImage               _warningBg  // 0x50
  protected         Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff>m_buffPtr  // 0x58
  private           System.UInt64                   <nextInstanceId>k__BackingField  // 0x68
  private           System.String                   <curSpritePath>k__BackingField  // 0x70
METHODS:
  System.UInt64 get_nextInstanceId()
  System.Void set_nextInstanceId(System.UInt64 value)
  System.String get_curSpritePath()
  System.Void set_curSpritePath(System.String value)
  Beyond.UI.UIAnimationWrapper get_anim()
  Beyond.Gameplay.Core.BuffData get_buffData()
  System.Int32 get_orderPriority()
  System.UInt64 get_buffInstanceUid()
  System.Void Init(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr, Beyond.LuaResourceLoader loader, System.Action onSpriteLoaded)
  System.Void DataInit(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr)
  System.Void VisualInit(UnityEngine.Sprite sprite)
  System.Void Clear()
  System.Void BeforePlayOutAnim()
  System.Void UpdateBuffCell()
  System.Void SetVisible(System.Boolean visible)
  System.Void SetStackCount(System.Int32 stackCount, System.Boolean playAnim)
  System.Void OnBuffIgnite()
  System.Void SetBuffIcon(UnityEngine.Sprite sprite)
  System.Void SetStackElementActive(System.Boolean isActive)
  System.Void SetWarningState(System.Boolean isWarning)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIBuffNode
TYPE:  class
TOKEN: 0x2000075
EXTENDS: TickableUIMono
FIELDS:
  private           Beyond.SerializeFieldDictionary<Beyond.Gameplay.Core.BuffIconConfig.BuffIconStyle,Beyond.UI.UIBuffCell>_buffStyleCellTemplateDict  // 0x68
  private           Beyond.UI.UIBuffNode.BuffNodeType_buffNodeType  // 0x70
  private           System.Int32                    _maxBuffCellCount  // 0x74
  private           System.Boolean                  m_isFirstInited  // 0x78
  private   readonly Beyond.LuaResourceLoader        m_loader  // 0x80
  private           Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>m_owner  // 0x88
  private   readonly Beyond.DynamicFastLookupCollection<Beyond.Gameplay.Core.BuffIconConfig.BuffIconStyle,Beyond.UI.UIBuffNode.BuffCellGroup>m_buffCellGroupDict  // 0x98
  private   readonly Beyond.DynamicFastLookupCollection<System.String,System.Collections.Generic.List<Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff>>>m_stackBuffsDict  // 0xA0
  private   readonly System.Collections.Generic.List<Beyond.UI.UIBuffCell>m_orderedBuffCellList  // 0xA8
  private   static  System.String                   BUFF_ANIM_STRONG_IN  // 0x0
  private   static  System.String                   BUFF_ANIM_IGNITE_OUT  // 0x0
METHODS:
  Beyond.TickType get_tickOption()
  System.Void _OnFirstInit()
  System.Void OnPreWarm()
  System.Void Init(Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> abilitySystemPtr)
  System.Void Refresh()
  System.Void Clear()
  System.Void Tick(System.Single deltaTime)
  System.Void OnRelease()
  System.Void OnBuffIconChange(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr, System.Boolean applied, Beyond.Gameplay.Core.Buff.FinishReason finishReason)
  System.Void OnBuffIconChange(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr, System.Boolean applied, System.Boolean playAnim, Beyond.Gameplay.Core.Buff.FinishReason finishReason)
  System.Void _AddBuffIcon(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr, Beyond.Gameplay.Core.BuffData buffData, System.Boolean playAnim)
  System.Void _RemoveBuffIcon(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr, Beyond.Gameplay.Core.BuffData buffData, System.Boolean playAnim, Beyond.Gameplay.Core.Buff.FinishReason finishReason)
  System.Void _OnBuffEnhanceChanged(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr)
  System.Void _OnBuffIgnite(Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> buffPtr)
  System.Void _RegisterAbilityBuffEvent(Beyond.Gameplay.Core.AbilitySystem abilitySystem)
  System.Void _UnregisterAbilityBuffEvent(Beyond.Gameplay.Core.AbilitySystem abilitySystem)
  Beyond.Gameplay.Core.BuffIconConfig.BuffIconStyle _GetIconStyle(Beyond.Gameplay.Core.BuffData buffData)
  System.Void _SetBuffCellSiblingInOrder(Beyond.UI.UIBuffCell buffCell)
  System.Void _DealWithBuffCellVisible()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.UICommonScanController
TYPE:  class
TOKEN: 0x200007F
EXTENDS: TickableUIMono
FIELDS:
  private           System.UInt64                   <entityLogicId>k__BackingField  // 0x68
  protected         UnityEngine.Transform           m_camera  // 0x70
  protected         Beyond.ObjectPtr<Beyond.Gameplay.Core.Entity>m_entity  // 0x78
  protected         UnityEngine.Transform           m_followTarget  // 0x88
  public            System.Single                   yOffset  // 0x90
  public    static readonly System.Int32                    STATE_ON  // 0x0
  public    static readonly System.Int32                    STATE_OFF  // 0x4
  public    static  System.Int32                    MAX_HP_RATIO  // 0x0
  public    static  System.Single                   TICK_REFRESH_NEED  // 0x0
  public    static  System.Int32                    DONT_REFRESH  // 0x0
  private           System.Boolean                  m_uiActive  // 0x94
  protected         System.Int64                    m_nextRefreshTime  // 0x98
  protected         System.Single                   m_hpRatio  // 0xA0
  protected         UnityEngine.Vector3             m_fixedPoint  // 0xA4
METHODS:
  Beyond.TickType get_tickOption()
  System.UInt64 get_entityLogicId()
  System.Void set_entityLogicId(System.UInt64 value)
  System.Boolean get_uiActive()
  System.Void set_uiActive(System.Boolean value)
  System.Void SetTarget(Beyond.Gameplay.Core.Entity target, System.Int64 nextRefresh, System.Single hpRatio)
  System.Void _UpdatePos()
  System.Void SetFixPoint(UnityEngine.Vector3 pos, System.UInt64 waterVolume)
  System.Void Tick(System.Single deltaTime)
  System.Void _FaceToCamera()
  System.Void Clear()
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UICountDownBar
TYPE:  class
TOKEN: 0x2000080
EXTENDS: TickableUIMono
FIELDS:
  private           Beyond.UI.UIText                _countDownTxt  // 0x68
  private           System.Single                   m_countDownTime  // 0x70
  private           System.Int32                    m_id  // 0x74
  private           UnityEngine.Transform           m_target  // 0x78
  private           Beyond.Gameplay.Core.CountDownShowAction.Datam_data  // 0x80
  private           UnityEngine.Transform           m_camera  // 0x88
  private           System.Boolean                  m_update  // 0x90
METHODS:
  Beyond.TickType get_tickOption()
  System.Boolean get_update()
  System.Void set_update(System.Boolean value)
  System.Void InitData(System.Int32 id, Beyond.Gameplay.Core.AbilitySystem target, Beyond.Gameplay.Core.CountDownShowAction.Data data)
  System.Void Clear()
  System.Void LateTick(System.Single deltaTime)
  System.Void _UpdateData(System.Single deltaTime)
  System.Void _UpdatePos()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIDoodadMineCoreScanController
TYPE:  class
TOKEN: 0x2000081
EXTENDS: UICommonScanController
FIELDS:
  public            UnityEngine.GameObject          canMineIcon  // 0xB0
  public            Beyond.UI.UIText                formingText  // 0xB8
  public            Beyond.UI.UIText                purityText  // 0xC0
METHODS:
  System.Void SyncConditonInfo(System.Boolean forming, System.String condition)
  System.Void SetPurity(System.Boolean forming, System.String conditionText)
  System.Void UpdateUI(System.Boolean forming, System.String condition)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIDoodadPlantCoreScanController
TYPE:  class
TOKEN: 0x2000082
EXTENDS: UICommonScanController
FIELDS:
  private   static  System.UInt32                   OFF  // 0x0
  private   static  System.UInt32                   DARK  // 0x0
  private   static  System.UInt32                   LIGHT  // 0x0
  private   static  System.UInt32                   GROW  // 0x0
  public            Beyond.UI.UIText                coreNameText  // 0xB0
  public            Beyond.UI.UIText                coreSizeText  // 0xB8
  public            UnityEngine.GameObject          refreshTimeRoot  // 0xC0
  public            Beyond.UI.UIText                refreshTimeText  // 0xC8
  public            System.Collections.Generic.List<UnityEngine.GameObject>flowerDark  // 0xD0
  public            System.Collections.Generic.List<UnityEngine.GameObject>flowerLight  // 0xD8
  public            System.Collections.Generic.List<UnityEngine.GameObject>flowerGrow  // 0xE0
  private           System.Single                   m_tickTimeSum  // 0xE8
METHODS:
  System.Void Tick(System.Single deltaTime)
  System.Void SetCoreInfo(System.String coreName, System.String coreSize)
  System.Void SetRefreshInfo(System.Int64 nextRefreshTime)
  System.Void RefreshTextNow()
  System.Void SetQuantityInfo(System.Int32 current, System.Int32 nextRefresh, System.Int32 maxCount)
  System.Void SetSingle(System.Int32 index, System.UInt32 state)
  System.Void _SyncTimeText()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIDoodadScanController
TYPE:  class
TOKEN: 0x2000083
EXTENDS: UICommonScanController
FIELDS:
  public            Beyond.UI.UIText                timeCom  // 0xB0
  public            UnityEngine.Transform           refreshFull  // 0xB8
  public            UnityEngine.Transform           refreshProgress  // 0xC0
  private           System.Single                   m_tickTimeSum  // 0xC8
METHODS:
  System.Void SyncRefreshInfo(System.Int64 nextRefresh, System.Single hpRatio)
  System.Void Tick(System.Single deltaTime)
  System.Void _RefreshCountDown()
  System.Void UpdateUI(System.Int64 nextRefresh, System.Single hpRatio)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIGeneralTracker
TYPE:  class
TOKEN: 0x2000084
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Transform           _arrowRotator  // 0x18
  private           UnityEngine.RectTransform       m_rect  // 0x20
METHODS:
  UnityEngine.RectTransform get_rect()
  System.Void UpdatePosition(UnityEngine.Vector2 uiPos, System.Single uiAngle, System.Boolean isOutBound)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.HpChangeDisplayData
TYPE:  class
TOKEN: 0x2000085
FIELDS:
  public            System.Int32                    priority  // 0x10
  public            System.Single                   minDamagePercent  // 0x14
  public            System.Single                   maxDamagePercent  // 0x18
  public            System.Single                   stayTime  // 0x1C
  public            System.Single                   decreaseSpeed  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIHeadBar
TYPE:  class
TOKEN: 0x2000086
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Boolean                  _showHpNumber  // 0x18
  private           System.Boolean                  _showHpChangeEffect  // 0x19
  private           System.Collections.Generic.List<Beyond.UI.HpChangeDisplayData>_hpChangeConfig  // 0x20
  private           System.Boolean                  _hidePoiseBarWhenEmpty  // 0x28
  private           System.Boolean                  _showPoiseChangeEffect  // 0x29
  private           System.Collections.Generic.List<Beyond.UI.HpChangeDisplayData>_poiseChangeConfig  // 0x30
  private           System.Boolean                  _highlightWhenWeakLock  // 0x38
  private           System.Single                   _weakLockHighlightScale  // 0x3C
  private           System.Single                   _weakLockScaleTransitionTime  // 0x40
  private           Beyond.UI.UIAnimationWrapper    _barRootAnim  // 0x48
  private           UnityEngine.CanvasGroup         _lvNode  // 0x50
  private           Beyond.UI.UIText                _lvText  // 0x58
  private           UnityEngine.CanvasGroup         _dangerousLvNode  // 0x60
  private           Beyond.UI.UIText                _dangerousLvText  // 0x68
  private           UnityEngine.CanvasGroup         _focusHighlight  // 0x70
  private           System.Collections.Generic.List<Beyond.UI.UIImage>_hpFastFillList  // 0x78
  private           System.Collections.Generic.List<Beyond.UI.UIImage>_hpSlowFillList  // 0x80
  private           UnityEngine.Transform           _hpNumberNode  // 0x88
  private           Beyond.UI.UIText                _curHpText  // 0x90
  private           Beyond.UI.UIText                _maxHpText  // 0x98
  private           UnityEngine.RectTransform       _hpParentRect  // 0xA0
  private           UnityEngine.RectTransform       _hpEffectRect  // 0xA8
  private           UnityEngine.CanvasGroup         _hpEffectCanvasGroup  // 0xB0
  private           Beyond.UI.UIPoiseBar            _poiseBar  // 0xB8
  private           Beyond.UI.UIWeaknessNode        _weaknessBar  // 0xC0
  private           Beyond.UI.UIBuffNode            _attachedBuffNode  // 0xC8
  private           Beyond.UI.UIBuffNode            _normalBuffNode  // 0xD0
  private   readonly Beyond.LuaResourceLoader        m_loader  // 0xD8
  private           Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>m_target  // 0xE0
  private           System.Boolean                  m_hasPoise  // 0xF0
  private           Beyond.UI.HpChangeDisplayData   m_currentHpChangeData  // 0xF8
  private           Beyond.UI.UIHeadBar.HpDisplayStatem_hpDisplayState  // 0x100
  private   readonly Beyond.Gameplay.PeriodicTimer   m_hpStayTimer  // 0x108
  private           System.Nullable<System.Single>  m_targetFillValue  // 0x110
  private           System.Nullable<System.Single>  m_transferToHighlightScaleTime  // 0x118
  private           System.Nullable<System.Single>  m_transferToOriginalScaleTime  // 0x120
  private           UnityEngine.Vector3             m_beforeTransferScale  // 0x128
  public    static  System.Single                   EFFECT_OFFSET  // 0x0
METHODS:
  System.Void OnDestroy()
  System.Void OnPreWarm()
  System.Void SetTarget(Beyond.Gameplay.Core.AbilitySystem target)
  System.Void ShowModifierAfterSetTarget(Beyond.Gameplay.Core.AbilitySystem.Modifier& modifier)
  System.Void Clear()
  System.Void Refresh()
  System.Void _OnHpChange(Beyond.Gameplay.Core.Entity entity, System.Double change)
  System.Void _OnForceSetHp(Beyond.Gameplay.Core.Entity entity)
  System.Void _CalculateHpChangeDisplay(Beyond.Gameplay.Core.AbilitySystem target, System.Double deltaValue)
  System.Void _UpdateHpDisplay(System.Single deltaTime)
  System.Void _OnPoiseChange(Beyond.Gameplay.Core.Entity entity, System.Single change, System.Boolean hideUIEffect)
  System.Void _OnMultiTimeWeaknessActivate(Beyond.Gameplay.Core.Entity entity, System.Boolean active, System.Int32 count)
  System.Void _OnWeaknessCountChanged(Beyond.Gameplay.Core.Entity entity, System.Int32 total, System.Int32 count)
  System.Void _OnMainTargetChanged(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,System.Boolean>& eventData)
  System.Void _UpdateScale(System.Single deltaTime)
  System.Void _SetImageFill(System.Collections.Generic.List<Beyond.UI.UIImage> imageList, System.Single fillValue)
  System.Void UpdateData(System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIHeadBarFollower
TYPE:  class
TOKEN: 0x2000088
EXTENDS: UIAbilityTargetFollower
FIELDS:
  public            Beyond.UI.HeadBarCtrl.HeadBarTypeheadBarType  // 0xF8
  private           System.Boolean                  _haveGuideLine  // 0xFC
  public            Beyond.UI.UIAnimationWrapper    anim  // 0x100
  private           Beyond.UI.UIHeadBar             _headBar  // 0x108
  private           UnityEngine.GameObject          _guideLineNode  // 0x110
  private           UnityEngine.RectTransform       _guideLine  // 0x118
  private           UnityEngine.RectTransform       _followTargetEndPoint  // 0x120
  private           UnityEngine.RectTransform       _headBarEndPoint  // 0x128
  private           System.Boolean                  m_headBarVisible  // 0x130
METHODS:
  System.Boolean get_actualVisible()
  System.Void OnPreWarm()
  System.Void SetTarget(Beyond.Gameplay.Core.AbilitySystem target)
  System.Void ShowModifierAfterSetTarget(Beyond.Gameplay.Core.AbilitySystem.Modifier& modifier)
  System.Void Clear()
  System.Void Refresh()
  System.Void SetHeadBarVisible(System.Boolean visible)
  System.Void UpdateData(System.Single deltaTime)
  System.Void _UpdateGuideLine()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_SetTarget(Beyond.Gameplay.Core.AbilitySystem P0)
  System.Void <>iFixBaseProxy_Clear()
  System.Void <>iFixBaseProxy_UpdateData(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIHeadLabel
TYPE:  class
TOKEN: 0x2000089
EXTENDS: TickableUIMono
FIELDS:
  private           UnityEngine.Transform           _emojiNode  // 0x68
  private           Beyond.Gameplay.Core.FloatingUIFitter_rootDis  // 0x70
  private           Beyond.Gameplay.Core.ObjectType <targetType>k__BackingField  // 0x78
  private           System.UInt64                   <entityLogicId>k__BackingField  // 0x80
  private           System.String                   m_headLabelIcon  // 0x88
  private           System.String                   m_headLabelIconOverwrite  // 0x90
  private           UnityEngine.Vector3             m_originalPosition  // 0x98
  private           System.Boolean                  m_hasBindEvent  // 0xA4
  private           System.Boolean                  m_hasBindTargetEvent  // 0xA5
  private           Beyond.SerializeFieldDictionary<Beyond.UI.UIHeadLabel.HeadLabelType,Beyond.UI.UIHeadLabel.HeadLabelRootData>_subRoots  // 0xA8
  private           System.Collections.Generic.Dictionary<Beyond.UI.UIHeadLabel.HeadLabelType,Beyond.UI.UIHeadLabel.HeadLabelRootVisibleData>m_subRootsVisible  // 0xB0
  private           System.Collections.Generic.Dictionary<UnityEngine.Transform,Beyond.UI.UIHeadLabel.HeadLabelType>m_subRootsReverse  // 0xB8
  private           UnityEngine.Transform           m_camera  // 0xC0
  private           Beyond.ObjectPtr<Beyond.Gameplay.Core.Entity>m_target  // 0xC8
  private           UnityEngine.Transform           m_followTarget  // 0xD8
  private           Beyond.NPC.Avatar.NPCAvatarMountPointInfom_npcMountPointInfo  // 0xE0
  private           System.Boolean                  m_inited  // 0xE8
  private           System.Boolean                  m_visibleDirty  // 0xE9
METHODS:
  Beyond.TickType get_tickOption()
  UnityEngine.Transform get_iconHolder()
  Beyond.Gameplay.Core.ObjectType get_targetType()
  System.Void set_targetType(Beyond.Gameplay.Core.ObjectType value)
  System.UInt64 get_entityLogicId()
  System.Void set_entityLogicId(System.UInt64 value)
  System.Void _OnSubRootsCollectionChanged()
  System.String get_headLabelIcon()
  System.Void set_headLabelIcon(System.String value)
  System.String get_missionHeadLabelIcon()
  System.Void set_missionHeadLabelIcon(System.String value)
  System.Void _TryInitRootData()
  System.Void SetVisibleDirty()
  System.Void _UpdateVisible()
  System.Void SetSubRootVisible(Beyond.UI.UIHeadLabel.HeadLabelType type, Beyond.UI.UIHeadLabel.VisibleSource source, System.Boolean visible, System.Boolean updateNow)
  System.Void SetTarget(Beyond.Gameplay.Core.Entity target)
  System.Void _TryUpdateVisibleCallback()
  System.Void _ClearVisibleCallback()
  System.Void Clear()
  System.Void SetActive(System.Boolean active)
  System.Void ClearEmojis()
  System.Void _UpdateFloatingUIVisibleCallback()
  System.Void _ClearFloatingUIVisibleCallback()
  System.Void _OnMissionTypeIconChanged(Beyond.EventData<System.String>& data)
  System.Void _BindMissionTracking()
  System.Void _UnBindMissionTracking()
  System.Void _BindTargetEvent()
  System.Void _UnBindTargetEvent()
  System.Void _OnNpcVisibleChanged(Beyond.EventData<System.String>& eventData)
  System.Void _UpdatePos()
  System.Void _RefreshVisible(System.Boolean bubbleRoot, System.Boolean textNode, System.Boolean iconHolderNode)
  System.Void _TryUpdateVisible()
  System.Void OnAwake()
  System.Void LateTick(System.Single deltaTime)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnRelease()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.UIHudFadeBase
TYPE:  class
TOKEN: 0x200008F
EXTENDS: MonoBehaviour
FIELDS:
  public            Beyond.UI.UIStyleInputValidType validType  // 0x18
METHODS:
  System.Boolean get_globalNeedShow()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIHudFadeConsoleController
TYPE:  class
TOKEN: 0x2000090
EXTENDS: UIHudFadeBase
FIELDS:
  public            System.String                   key  // 0x20
  public            System.String                   foldState  // 0x28
  private           UnityEngine.Animator            m_animator  // 0x30
  private           System.Boolean                  m_curShowing  // 0x38
  private           DG.Tweening.Sequence            m_fadeSequence  // 0x40
  private           System.Int32                    m_keyHash  // 0x48
  private           System.Int32                    m_foldStateHash  // 0x4C
METHODS:
  System.Void Awake()
  System.Void OnDestroy()
  System.Void OnShow()
  System.Void _CheckNeedShow()
  System.Void _OnFadeHud()
  System.Void _OnInformShow(Beyond.EventData<Beyond.UI.UIStyleInputValidTypeMask>& eventData)
  System.Void InformShow()
  System.Void .ctor()
  System.Void <_CheckNeedShow>b__10_0()
  System.Void <InformShow>b__13_0()
END_CLASS

CLASS: Beyond.UI.UIHudFadeController
TYPE:  class
TOKEN: 0x2000091
EXTENDS: UIHudFadeBase
FIELDS:
  private           UnityEngine.CanvasGroup         m_canvasGroup  // 0x20
  private           System.Boolean                  m_curShowing  // 0x28
  private           DG.Tweening.Sequence            m_fadeSequence  // 0x30
  private   readonly System.Collections.Generic.HashSet<System.String>m_hudPreventFadeState  // 0x38
METHODS:
  System.Boolean get_needShow()
  Beyond.Gameplay.GameplayMiscSetting get_setting()
  System.Void Awake()
  System.Void OnDestroy()
  System.Void _OnFadeHud()
  System.Void _CheckNeedShow()
  System.Void SetLocalNeedShow(System.String state, System.Boolean needShowHud)
  System.Void _OnInformShow(Beyond.EventData<Beyond.UI.UIStyleInputValidTypeMask>& eventData)
  System.Void InformShow()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIHudFadeTouchSkill
TYPE:  class
TOKEN: 0x2000092
EXTENDS: UIHudFadeBase
FIELDS:
  private           Beyond.UI.UIAnimationWrapper    m_animationWrapper  // 0x20
  private           System.Boolean                  m_curShowing  // 0x28
  private           System.Boolean                  m_animInOrLoop  // 0x29
  private           DG.Tweening.Sequence            m_fadeSequence  // 0x30
METHODS:
  System.Void Awake()
  System.Void OnDestroy()
  System.Void OnShow()
  System.Void _CheckNeedShow()
  System.Void _OnFadeHud()
  System.Void _OnInformShow(Beyond.EventData<Beyond.UI.UIStyleInputValidTypeMask>& eventData)
  System.Void InformShow()
  System.Void .ctor()
  System.Void <_CheckNeedShow>b__7_0()
  System.Void <InformShow>b__10_0()
  System.Void <InformShow>b__10_1()
END_CLASS

CLASS: Beyond.UI.UILifeTimeBuffCell
TYPE:  class
TOKEN: 0x2000093
EXTENDS: UIBuffCell
FIELDS:
  private           Beyond.UI.UIImage               _buffLifeTimeBar  // 0x78
METHODS:
  System.Void UpdateBuffCell()
  System.Void SetWarningState(System.Boolean isWarning)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_UpdateBuffCell()
  System.Void <>iFixBaseProxy_SetWarningState(System.Boolean P0)
END_CLASS

CLASS: Beyond.UI.UILiquidPoolScanController
TYPE:  class
TOKEN: 0x2000094
EXTENDS: UICommonScanController
FIELDS:
  public            UnityEngine.GameObject          unLimitGroup  // 0xB0
  public            UnityEngine.GameObject          limitedGroup  // 0xB8
  public            Beyond.UI.UIText                currentAmountText  // 0xC0
  public            Beyond.UI.UIText                maxAmountText  // 0xC8
  public            Beyond.UI.UIText                waterNameText  // 0xD0
  private   static  System.String                   EMPTY_LIQUID  // 0x0
  private           Beyond.LangKey                  m_key  // 0xD8
METHODS:
  System.Void SetWaterInfo(System.UInt64 waterId, System.Int32 x, System.Int32 y, System.Int32 z)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UILockAim
TYPE:  class
TOKEN: 0x2000095
EXTENDS: UIAbilityTargetFollower
FIELDS:
  public            System.Single                   showCancelProgressRatio  // 0xF8
  public            UnityEngine.CanvasGroup         aimGroup  // 0x100
  public            Beyond.UI.UIImage               aimRingImage  // 0x108
  public            Beyond.UI.UIImage               rotateImage  // 0x110
  public            UnityEngine.CanvasGroup         breakingAttackGroup  // 0x118
  private           Beyond.UI.UIAnimationWrapper    m_aimGroupAnimWrapper  // 0x120
METHODS:
  System.Void OnAwake()
  System.Void OnRelease()
  System.Void Start()
  System.Void UpdateData(System.Single deltaTime)
  System.Void _OnLockTargetFromAutoToManual()
  System.Void _RefreshTarget(Beyond.Gameplay.Core.AbilitySystem _)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnRelease()
  System.Void <>iFixBaseProxy_UpdateData(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UILvInfoBar
TYPE:  class
TOKEN: 0x2000096
EXTENDS: UIAbilityTargetFollower
FIELDS:
  public            Beyond.UI.UIAnimationWrapper    anim  // 0xF8
  private           UnityEngine.Transform           _lvNode  // 0x100
  private           Beyond.UI.UIText                _lvText  // 0x108
  private           UnityEngine.Transform           _dangerousLvNode  // 0x110
  private           Beyond.UI.UIText                _dangerousLvText  // 0x118
METHODS:
  System.Void SetTarget(Beyond.Gameplay.Core.AbilitySystem target)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_SetTarget(Beyond.Gameplay.Core.AbilitySystem P0)
END_CLASS

CLASS: Beyond.UI.UIMainCharFootBar
TYPE:  class
TOKEN: 0x2000097
EXTENDS: TickableUIMono
FIELDS:
  public            Beyond.Gameplay.MountPoint      mountPoint  // 0x68
  public            UnityEngine.Vector3             worldOffset  // 0x6C
  public            Beyond.UI.UIAnimationWrapper    dashBar  // 0x78
  public            UnityEngine.Transform           dashBarParent  // 0x80
  public            UnityEngine.Transform           dashBarTransform  // 0x88
  public            UnityEngine.Vector3             dashBarWorldOffset  // 0x90
  public            System.Single                   dashBarScale  // 0x9C
  public            System.Single                   dashBarScaleMobile  // 0xA0
  public            Beyond.UI.FootBarDashCell       dashFillFull  // 0xA8
  public            Beyond.UI.FootBarDashCell       dashFillHalf  // 0xB0
  public            System.Single                   smoothTime  // 0xB8
  private           Beyond.Gameplay.Core.Entity     m_mainChar  // 0xC0
  private           System.Boolean                  m_dashBarNeedShow  // 0xC8
  private           System.Boolean                  m_dashBarShowing  // 0xC9
  private           UnityEngine.Transform           m_target  // 0xD0
  private           UnityEngine.Vector3             m_smoothVelocity  // 0xD8
  private           System.Boolean                  m_notEnoughAnimShowing  // 0xE4
  private           System.Single                   m_curDashCellCount  // 0xE8
  private           System.Single                   m_curDashFillCount  // 0xEC
  private           System.Collections.Generic.List<Beyond.UI.FootBarDashCell>m_dashFillList  // 0xF0
  private   static readonly Unity.Profiling.ProfilerMarker  PROFILER_MARKER_UPDATE  // 0x0
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnAwake()
  System.Void OnEnable()
  System.Void OnRelease()
  System.Void _OnMainCharChange(Beyond.EventData<Beyond.Gameplay.SetLeaderReason,Beyond.Gameplay.Core.Entity,Beyond.Gameplay.Core.Entity>& data)
  System.Void _ProcessOnMainCharChange()
  System.Void LateTick(System.Single deltaTime)
  System.Void _OnDashCountChanged(System.Single curCount)
  System.Void _OnDashFailed()
  System.Void _OnInteractNpc(Beyond.EventData<System.String,Beyond.Gameplay.Core.Entity>& eventData)
  System.Void _OnDialogStart(Beyond.EventData<System.Boolean,Beyond.Gameplay.DialogEnums.DialogType>& eventData)
  System.Void _OnDialogFinish(Beyond.EventData<System.Boolean>& eventData)
  System.Void _SetInDialog(System.Boolean inDialog)
  System.Void _OnOutAnimCallback()
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnRelease()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIMainCharFootBarArc
TYPE:  class
TOKEN: 0x2000098
EXTENDS: TickableUIMono
FIELDS:
  public            Beyond.Gameplay.MountPoint      mountPoint  // 0x68
  public            UnityEngine.Vector3             worldOffset  // 0x6C
  public            Beyond.UI.UIAnimationWrapper    dashBar  // 0x78
  public            Beyond.UI.UIState.UIStateControllerdashBarStateController  // 0x80
  public            UnityEngine.Transform           dashBarParent  // 0x88
  public            UnityEngine.RectTransform       dashBarTransform  // 0x90
  public            Beyond.UI.UIImage               dashFill  // 0x98
  public            Beyond.UI.UIImage               dashFillLow  // 0xA0
  public            Beyond.UI.UIImage               dashFillWhite  // 0xA8
  public            Beyond.UI.UIAnimationWrapper    notEnoughAnim  // 0xB0
  public            UnityEngine.Vector3             dashBarWorldOffset  // 0xB8
  public            System.Single                   dashBarScale  // 0xC4
  public            System.Single                   dashBarScaleMobile  // 0xC8
  public            System.Single                   smoothTime  // 0xCC
  public            System.Int32                    dashCountMin  // 0xD0
  public            System.Int32                    dashCountMax  // 0xD4
  public            System.Single                   fillWhiteHoldTime  // 0xD8
  public            System.Single                   fillWhiteDecreaseSpeed  // 0xDC
  public            UnityEngine.AnimationCurve      scaleCurve  // 0xE0
  public            System.Single                   scaleSmoothTime  // 0xE8
  private           UnityEngine.CanvasGroup         m_canvasGroup  // 0xF0
  private           Beyond.Gameplay.Core.Entity     m_mainChar  // 0xF8
  private           System.Boolean                  m_dashBarNeedShow  // 0x100
  private           System.Boolean                  m_dashBarShowing  // 0x101
  private           UnityEngine.Transform           m_target  // 0x108
  private           UnityEngine.Vector3             m_smoothVelocity  // 0x110
  private           System.Boolean                  m_notEnoughAnimShowing  // 0x11C
  private           System.Single                   m_originalScale  // 0x120
  private           System.Single                   m_dampingScale  // 0x124
  private   readonly Beyond.Gameplay.PeriodicTimer   m_fillWhiteStayTimer  // 0x128
  private   readonly System.Collections.Generic.HashSet<System.String>m_disableState  // 0x130
  private           System.Single                   m_curDashCellCount  // 0x138
  private           System.Single                   m_curDashFillAmount  // 0x13C
  private           Beyond.UI.UIHeadBar.HpDisplayStatem_dashWhiteState  // 0x140
  private           System.Collections.Generic.Dictionary<System.Int32,System.String>m_dashCountStateNames  // 0x148
  private   static readonly Unity.Profiling.ProfilerMarker  PROFILER_MARKER_UPDATE  // 0x0
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnAwake()
  System.Void OnEnable()
  System.Void OnRelease()
  System.Void _OnMainCharChange(Beyond.EventData<Beyond.Gameplay.SetLeaderReason,Beyond.Gameplay.Core.Entity,Beyond.Gameplay.Core.Entity>& data)
  System.Void _ProcessOnMainCharChange()
  System.Void TailLateTick(System.Single deltaTime)
  System.Void _OnDashCountChanged(System.Single curCount)
  System.Void _OnDashFailed()
  System.Void _OnInteractNpc(Beyond.EventData<System.String,Beyond.Gameplay.Core.Entity>& eventData)
  System.Void _OnDialogStart(Beyond.EventData<System.Boolean,Beyond.Gameplay.DialogEnums.DialogType>& eventData)
  System.Void _OnDialogFinish(Beyond.EventData<System.Boolean>& eventData)
  System.Void _OnPlayCutscene(Beyond.EventData<Beyond.Gameplay.Core.CinematicTimelineManagerBase.TimelineHandle>& eventData)
  System.Void _OnFinishCutscene(Beyond.EventData<System.Boolean>& eventData)
  System.Void _OnForbidSystemChanged(Beyond.EventData<Beyond.Gameplay.ForbidType,System.Boolean>& eventData)
  System.Void _SetInDialog(System.Boolean inDialog)
  System.Void SetUIDisable(System.String key, System.Boolean disable)
  System.Void _RefreshDisableState()
  System.Void _OnOutAnimCallback()
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnRelease()
  System.Void <>iFixBaseProxy_TailLateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIPanelBase
TYPE:  class
TOKEN: 0x2000099
EXTENDS: TickableUIMono
FIELDS:
  public    static  System.String                   UI_SPRITE_PATH  // 0x0
  private           Beyond.LuaResourceLoader        m_loader  // 0x68
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnRelease()
  UnityEngine.Sprite LoadSprite(System.String path, System.String name)
  UnityEngine.Sprite LoadSpriteWithOutFormat(System.String path)
  UnityEngine.GameObject LoadGameObject(System.String path)
  System.String GetSpritePath(System.String path, System.String name)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.UIPoiseBar
TYPE:  class
TOKEN: 0x200009A
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.UI.UISlider              _increaseSlider  // 0x18
  private           UnityEngine.CanvasGroup         _increaseCanvasGroup  // 0x20
  private           Beyond.UI.UISlider              _decreaseSlider  // 0x28
  private           UnityEngine.CanvasGroup         _decreaseCanvasGroup  // 0x30
  private           Beyond.UI.UIPoiseKnot           _poiseKnot  // 0x38
  private           UnityEngine.Animation           _poiseBreakAnim  // 0x40
  private           UnityEngine.CanvasGroup         _poiseBreakCanvasGroup  // 0x48
  private           UnityEngine.RectTransform       _poiseParentRect  // 0x50
  private           UnityEngine.RectTransform       _poiseEffectRect  // 0x58
  private           UnityEngine.CanvasGroup         _poiseEffectCanvasGroup  // 0x60
  private           Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem>m_owner  // 0x68
  private           System.Boolean                  m_isInPoiseRecovery  // 0x78
  private           System.Boolean                  m_hidePoiseBarWhenEmpty  // 0x79
  private           System.Boolean                  m_showPoiseChangeEffect  // 0x7A
  private           System.Collections.Generic.List<Beyond.UI.HpChangeDisplayData>m_poiseChangeConfig  // 0x80
  private           Beyond.UI.HpChangeDisplayData   m_currentPoiseChangeData  // 0x88
  private           Beyond.UI.UIPoiseBar.PoiseDisplayStatem_poiseDisplayState  // 0x90
  private   readonly Beyond.Gameplay.PeriodicTimer   m_poiseStayTimer  // 0x98
  private           System.Nullable<System.Single>  m_targetFillValue  // 0xA0
  private           System.Single                   m_slowFillValue  // 0xA8
  private           System.Boolean                  m_enemyPartHide  // 0xAC
  private           System.Collections.Generic.List<Beyond.UI.UIPoiseKnot>m_poiseKnotList  // 0xB0
  private           System.Collections.Generic.List<Beyond.UI.UIPoiseKnot>m_poiseKnotPool  // 0xB8
  private           System.Boolean                  m_isPoiseKnotInited  // 0xC0
  public    static  System.Single                   EFFECT_OFFSET  // 0x0
METHODS:
  Beyond.Gameplay.Core.AbilitySystem get_owner()
  System.Single get_maxPoise()
  System.Single get_realPoise()
  System.Boolean get_hidePoiseBar()
  System.Void Init(Beyond.Gameplay.Core.AbilitySystem owner, System.Boolean hidePoiseBarWhenEmpty, System.Boolean showPoiseChangeEffect, System.Collections.Generic.List<Beyond.UI.HpChangeDisplayData> poiseChangeConfig)
  System.Void Clear()
  System.Void OnPoiseChange(Beyond.Gameplay.Core.Entity entity, System.Single change, System.Boolean hideUIEffect)
  System.Void Refresh()
  System.Void UpdatePoiseBar(System.Single deltaTime)
  System.Void _CalculatePoiseChangeDisplay(System.Double deltaValue)
  System.Void _UpdatePoiseDisplay(System.Single deltaTime)
  System.Void _TryInitPoiseKnot(Beyond.Gameplay.Core.AbilitySystem owner)
  System.Void _ClearPoiseKnot()
  Beyond.UI.UIPoiseKnot _CreatePoiseKnot()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIPoiseKnot
TYPE:  class
TOKEN: 0x200009C
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.CanvasGroup         _canvasGroup  // 0x18
  private           Beyond.UI.UIAnimationWrapper    _animationWrapper  // 0x20
METHODS:
  System.Void SetVisible(System.Boolean visible)
  System.Void KnotBreak()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIPowerPoleAutoConnectTracker
TYPE:  class
TOKEN: 0x200009D
EXTENDS: UIGeneralTracker
FIELDS:
  private           UnityEngine.GameObject          _rootDistance  // 0x28
  private           Beyond.UI.UIText                _textDistance  // 0x30
  private           UnityEngine.Color               _textColorNormal  // 0x38
  private           UnityEngine.Color               _textColorDisable  // 0x48
  private           UnityEngine.Color               _textColorError  // 0x58
  private           UnityEngine.CanvasGroup         _colorScaleControlGroup  // 0x68
  private           System.Single                   _activeScale  // 0x70
  private           Beyond.UI.UIPowerPoleAutoConnectTracker.IconGroup_defaultIcon  // 0x78
  private           Beyond.UI.UIPowerPoleAutoConnectTracker.IconGroup_diffuserIcon  // 0x80
  private           Beyond.UI.UIPowerPoleAutoConnectTracker.IconGroup_hubIcon  // 0x88
  private           Beyond.UI.UIPowerPoleAutoConnectTracker.IconGroup_subhubIcon  // 0x90
  private           Beyond.UI.UIPowerPoleAutoConnectTracker.IconGroup_terminalIcon  // 0x98
  private           Beyond.UI.UIPowerPoleAutoConnectTracker.IconGroup_stationIcon  // 0xA0
  private           Beyond.UI.UIPowerPoleAutoConnectTracker.StatusHintGroup_statusHintGroup  // 0xA8
  private           System.Nullable<Beyond.Gameplay.Factory.PowerAutoConnectStatus>m_currentStatus  // 0xB0
METHODS:
  System.Void UpdateDistance(System.Single distance)
  System.Void _ActualUpdateStatus(Beyond.Gameplay.Factory.PowerAutoConnectStatus status)
  System.Void UpdateStatus(Beyond.Gameplay.Factory.PowerAutoConnectStatus status)
  System.Void _ActualUpdateIcon(Beyond.UI.UIPowerPoleAutoConnectTracker.IconGroup img)
  System.Void UpdateNodeType(System.Int32 nodeType)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIPowerPoleFastTravelTracker
TYPE:  class
TOKEN: 0x20000A0
EXTENDS: UIGeneralTracker
FIELDS:
  private           Beyond.UI.UIText                _textDistance  // 0x28
  private           UnityEngine.Color               _textColorNormal  // 0x30
  private           UnityEngine.Color               _textColorWarning  // 0x40
  private           UnityEngine.Color               _textColorHighlighted  // 0x50
  private           UnityEngine.Color               _textColorDisabled  // 0x60
  private           UnityEngine.GameObject          _parentNormal  // 0x70
  private           Beyond.UI.UIAnimationWrapper    _animationWrapperNormal  // 0x78
  private           UnityEngine.GameObject          _imageNormal  // 0x80
  private           UnityEngine.GameObject          _imageWarning  // 0x88
  private           UnityEngine.GameObject          _imageHighlighted  // 0x90
  private           UnityEngine.GameObject          _imageDisabled  // 0x98
  private           UnityEngine.GameObject          _parentUpgraded  // 0xA0
  private           Beyond.UI.UIAnimationWrapper    _animationWrapperUpgraded  // 0xA8
  private           UnityEngine.GameObject          _imageNormalUpgraded  // 0xB0
  private           UnityEngine.GameObject          _imageWarningUpgraded  // 0xB8
  private           UnityEngine.GameObject          _imageHighlightedUpgraded  // 0xC0
  private           UnityEngine.GameObject          _imageDisabledUpgraded  // 0xC8
  private           UnityEngine.GameObject          _parentDefaultNext  // 0xD0
  private           Beyond.UI.UIAnimationWrapper    _animationWrapperNext  // 0xD8
  private           UnityEngine.GameObject          _imageNormalDefaultNext  // 0xE0
  private           UnityEngine.GameObject          _imageWarningDefaultNext  // 0xE8
  private           UnityEngine.GameObject          _imageHighlightedDefaultNext  // 0xF0
  private           UnityEngine.GameObject          _imageDisabledDefaultNext  // 0xF8
  private           UnityEngine.GameObject          _textInfoBg  // 0x100
  private           Beyond.SerializeFieldDictionary<Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleStatus,Beyond.UI.UIPowerPoleFastTravelTracker.TravelPoleStatusSetting>_statusSettingDict  // 0x108
  private           Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleIconm_iconStatus  // 0x110
  private           Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleStatusm_status  // 0x114
  private           System.Boolean                  m_isHighlighted  // 0x118
  private           System.String                   m_distanceFormatText  // 0x120
METHODS:
  System.Boolean get_isWarning()
  System.Boolean get_isDisabled()
  System.Boolean get_allowToHighlight()
  Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleIcon get_iconStatus()
  System.Void set_iconStatus(Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleIcon value)
  Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleStatus get_status()
  System.Void set_status(Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleStatus value)
  Beyond.UI.UIAnimationWrapper get_animationWrapper()
  UnityEngine.GameObject get_imageNormal()
  UnityEngine.GameObject get_imageWarning()
  UnityEngine.GameObject get_imageDisabled()
  UnityEngine.GameObject get_imageHighlighted()
  System.Void PlayFocus()
  System.Void UpdateIconStatus(Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleIcon value)
  System.Void UpdateStatus(Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleStatus value)
  System.Void UpdateIsHighlighted(System.Boolean value)
  System.Void UpdateDistance(UnityEngine.Vector3 value)
  System.Void _OnStatusChanged()
  System.Void _UpdateIcon()
  System.Void OnEnable()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIRaceModuleRankController
TYPE:  class
TOKEN: 0x20000A2
EXTENDS: TickableUIMono
FIELDS:
  private   readonly Beyond.LuaResourceLoader        m_loader  // 0x68
  public            Beyond.UI.UIImage               image  // 0x70
  public            UnityEngine.Transform           greyNode  // 0x78
  public            UnityEngine.Transform           lightNode  // 0x80
  public            Beyond.UI.UIText                text  // 0x88
  public    static  System.String                   FIRST_ICON  // 0x0
  public    static  System.String                   SECOND_ICON  // 0x0
  public    static  System.String                   THIRD_ICON  // 0x0
  public    static  System.String                   FOURTH_ICON  // 0x0
  public    static  System.String                   FIFTH_ICON  // 0x0
  private           UnityEngine.Sprite              m_sprite1  // 0x90
  private           UnityEngine.Sprite              m_sprite2  // 0x98
  private           UnityEngine.Sprite              m_sprite3  // 0xA0
  private           UnityEngine.Sprite              m_sprite4  // 0xA8
  private           UnityEngine.Sprite              m_sprite5  // 0xB0
  private           Beyond.UI.UIRaceModuleRankController.ERankm_rankEnum  // 0xB8
  private           System.Single                   m_restTime  // 0xBC
  private           System.Boolean                  m_begin  // 0xC0
METHODS:
  Beyond.TickType get_tickOption()
  System.Void _ResetData()
  System.Void OnAwake()
  System.Void OnRelease()
  System.Void _ShowBaseTrans(System.Boolean show)
  System.Void _LoadAllSprite()
  System.Void _UpdateRaceModuleRank(Beyond.EventData<System.Int32,System.Single>& rankData)
  System.Void Tick(System.Single deltaTime)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnRelease()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UITacticalItemBar
TYPE:  class
TOKEN: 0x20000A4
EXTENDS: UIAbilityTargetFollower
FIELDS:
  private           System.Single                   _castFillMin  // 0xF8
  private           System.Single                   _castFillMax  // 0xFC
  public            Beyond.UI.UIAnimationWrapper    anim  // 0x100
  private           Beyond.UI.UIImage               _castFill  // 0x108
  private           Beyond.UI.UIImage               _itemIcon  // 0x110
  private   static  System.String                   UI_SPRITE_ITEM  // 0x0
METHODS:
  System.Void SetTarget(Beyond.Gameplay.Core.AbilitySystem target)
  System.Void UpdateData(System.Single deltaTime)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_SetTarget(Beyond.Gameplay.Core.AbilitySystem P0)
  System.Void <>iFixBaseProxy_UpdateData(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIVideoHelper
TYPE:  class
TOKEN: 0x20000A5
EXTENDS: MonoBehaviour
FIELDS:
  public            CriWare.CriManaMovieControllerForUIcriMovieController  // 0x18
  public            System.String                   videoPath  // 0x20
  public            System.Boolean                  restartOnEnable  // 0x28
  private           Beyond.UI.UIImage               m_image  // 0x30
METHODS:
  System.Void Reset()
  System.Void ResetVideo()
  System.Void Awake()
  System.Void OnEnable()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIVigilanceBar
TYPE:  class
TOKEN: 0x20000A6
EXTENDS: UIAbilityTargetFollower
FIELDS:
  private           Beyond.UI.UIAnimationWrapper    _vigilanceNode  // 0xF8
  private           Beyond.UI.UIImage               _vigilanceFill  // 0x100
  private           UnityEngine.CanvasGroup         _vigilanceDim  // 0x108
  private           UnityEngine.CanvasGroup         _vigilanceLight  // 0x110
  private           System.Boolean                  m_isVigilanceActive  // 0x118
  private           System.Boolean                  m_isVigilanceFull  // 0x119
METHODS:
  System.Void SetTarget(Beyond.Gameplay.Core.AbilitySystem target)
  System.Void Clear()
  System.Void Refresh()
  System.Void UpdateData(System.Single deltaTime)
  System.Void _UpdateVigilanceNode()
  System.Void .ctor()
  System.Void <_UpdateVigilanceNode>b__10_0()
  System.Void <>iFixBaseProxy_SetTarget(Beyond.Gameplay.Core.AbilitySystem P0)
  System.Void <>iFixBaseProxy_Clear()
  System.Void <>iFixBaseProxy_UpdateData(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIWeakLockAim
TYPE:  class
TOKEN: 0x20000A7
EXTENDS: UIAbilityTargetFollower
FIELDS:
  public            UnityEngine.CanvasGroup         aimGroup  // 0xF8
METHODS:
  System.Void OnAwake()
  System.Void Start()
  System.Void OnRelease()
  System.Void _OnMainTargetChanged(Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,System.Boolean>& data)
  System.Void _RefreshTarget()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.UIWeaknessNode
TYPE:  class
TOKEN: 0x20000A8
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.CanvasGroup         weaknessCell  // 0x18
  private   readonly System.Collections.Generic.List<UnityEngine.CanvasGroup>m_weaknessCells  // 0x20
METHODS:
  System.Void Awake()
  System.Void SetTotalCellNum(System.Int32 num)
  System.Void SetCurrentCellNum(System.Int32 num)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIWaterDroneBar
TYPE:  class
TOKEN: 0x20000A9
EXTENDS: TickableUIMono
FIELDS:
  public            Beyond.Gameplay.MountPoint      mountPoint  // 0x68
  public            UnityEngine.Transform           waterDroneBarParent  // 0x70
  public            UnityEngine.Vector3             waterDroneBarLocalOffset  // 0x78
  public            System.Single                   smoothTime  // 0x84
  public            Beyond.UI.UISlider              slider  // 0x88
  private           Beyond.ObjectPtr<Beyond.Gameplay.Core.Entity>m_waterDronePtr  // 0x90
  private           UnityEngine.Transform           _waterDroneTrans  // 0xA0
  private           UnityEngine.Vector3             m_smoothVelocity  // 0xA8
  public            Beyond.UI.UIState.UIStateControllerwaterStateController  // 0xB8
  public            Beyond.UI.UIState.UIStateControllericonStateController  // 0xC0
  private   static readonly Unity.Profiling.ProfilerMarker  PROFILER_MARKER_UPDATE  // 0x0
  public    static  System.Single                   SLIDER_MAX_VALUE  // 0x0
  public            Beyond.UI.UIAnimationWrapper    uiAnimationWrapper  // 0xC8
  private           UnityEngine.Animation           _animation  // 0xD0
  private           UnityEngine.AnimationClip       _switchStateClip  // 0xD8
  private           UnityEngine.AnimationClip       _farLoopClip  // 0xE0
  private           UnityEngine.AnimationClip       _emptyLoopClip  // 0xE8
  private           System.String                   m_switchStateClipName  // 0xF0
  private           System.String                   m_farLoopClipName  // 0xF8
  private           System.String                   m_emptyLoopClipName  // 0x100
  private           System.Single                   _clampedYawAngle  // 0x108
  private           System.Single                   _clampedPitchAngle  // 0x10C
  private           System.Collections.Generic.List<System.String>_hydrantTemplateIds  // 0x110
  private           System.Collections.Generic.List<System.String>_tankTemplateIds  // 0x118
  private           System.Boolean                  m_isInfinityLiquid  // 0x120
  private           System.Boolean                  m_isBagEmpty  // 0x121
  private           System.Boolean                  m_noRemainLiquid  // 0x122
  private           System.Boolean                  m_isBagEmptyAndNoRemainLiquid  // 0x123
  private           System.Int32                    m_stateChangeFrame  // 0x124
  private           System.Boolean                  m_stateDirty  // 0x128
  private           System.Boolean                  m_isPlayingFarLoop  // 0x129
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnAwake()
  System.Void _OnWaterDroneInfinityLiquidChanged(Beyond.EventData<System.Boolean>& data)
  System.Void _OnWaterDroneEmptyChanged(Beyond.EventData<System.Boolean>& data)
  System.Void _OnWaterDroneInteractiveChanged(Beyond.EventData<System.String>& data)
  System.Void _OnWaterDroneSourceTypeChanged(Beyond.EventData<Beyond.Gameplay.WaterDroneSourceType>& data)
  System.Void _OnWaterDroneRelaxChanged(Beyond.EventData<System.Boolean>& data)
  System.Void _OnWaterDroneHydrantStateChanged(Beyond.EventData<Beyond.Gameplay.CustomAbilityComponent.WaterDroneByHydrantState>& data)
  System.Void _OnWaterDroneHydrantStateChanged(Beyond.Gameplay.CustomAbilityComponent.WaterDroneByHydrantState state)
  System.Void OnEnable()
  System.Void OnRelease()
  System.Void _OnWaterDroneChange(Beyond.ObjectPtr<Beyond.Gameplay.Core.Entity> waterDronePtr)
  System.Void _ClearWaterDrone()
  System.Void LateTick(System.Single deltaTime)
  System.Void _UpdateState()
  System.Void _SetIconStateController(System.String stateName)
  System.Void _UpdateSlider()
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnRelease()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.WaterDroneJoystickCtrl
TYPE:  class
TOKEN: 0x20000AA
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.UI.UIJoystick            _joystick  // 0x18
  public            System.Single                   cameraInputScaleX  // 0x20
  public            System.Single                   cameraInputScaleY  // 0x24
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.WorldUIController
TYPE:  class
TOKEN: 0x20000AB
EXTENDS: TickableMono
FIELDS:
  private           System.UInt64                   <entityLogicId>k__BackingField  // 0x68
  protected         UnityEngine.Transform           m_camera  // 0x70
  protected         Beyond.ObjectPtr<Beyond.Gameplay.Core.Entity>m_entity  // 0x78
  protected         UnityEngine.Vector3             m_parentPos  // 0x88
  protected         Beyond.Gameplay.Core.InteractiveLogicControllerm_logicController  // 0x98
  protected         UnityEngine.GameObject          m_postModel  // 0xA0
  protected         Beyond.Gameplay.Core.InteractiveLogicBaseComponentm_logicBaseComponent  // 0xA8
  protected         System.UInt64                   m_id  // 0xB0
  protected         System.Int32                    m_typeSegment  // 0xB8
  protected         System.Boolean                  m_uiActive  // 0xBC
METHODS:
  System.UInt64 get_entityLogicId()
  System.Void set_entityLogicId(System.UInt64 value)
  Beyond.TickType get_tickOption()
  System.Boolean get_uiActive()
  System.Void set_uiActive(System.Boolean value)
  System.Void Init(Beyond.Gameplay.Core.Entity target, System.String path, System.UInt64 id, System.Int32 typeSegment)
  System.Void TryGetNeedComponent()
  System.Void SetPos()
  System.Void SetUIForward()
  System.Void Tick(System.Single deltaTime)
  System.Void TickUI(System.Single deltaTime)
  System.Void Clear()
  System.Void OnRelease()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.Mission.MissionHudBGSizeUpdater
TYPE:  class
TOKEN: 0x20000AC
EXTENDS: TickableUIMono
FIELDS:
  public            UnityEngine.RectTransform       bgTransform  // 0x68
  public            UnityEngine.RectTransform       objectiveList  // 0x70
  public            UnityEngine.RectTransform       objectiveContent  // 0x78
  public            UnityEngine.RectTransform       leftLayoutTransform  // 0x80
  public            UnityEngine.UI.VerticalLayoutGroupleftNodeVerticalLayoutGroup  // 0x88
  public            System.Single                   bgSizeGetterDeltaY  // 0x90
METHODS:
  Beyond.TickType get_tickOption()
  System.Void LateTick(System.Single deltaTime)
  System.Void Tick(System.Single deltaTime)
  System.Void UpdateBgSize()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x20000AF
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.Void __Gen_Wrap_0()
  System.Void __Gen_Wrap_1(System.Object P0)
  System.Void __Gen_Wrap_2(System.Object P0, Beyond.EventData<System.Boolean>& P1)
  System.Void __Gen_Wrap_3(System.Object P0, Beyond.EventData<System.Single>& P1)
  System.Void __Gen_Wrap_4(System.Object P0, System.Single P1)
  System.Void __Gen_Wrap_5(System.Object P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_6(System.Object P0, System.Int32 P1, System.Int32 P2, System.Byte P3)
  System.Void __Gen_Wrap_7(System.Object P0, System.Int32 P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, System.Byte P5)
  System.Byte __Gen_Wrap_8(System.Object P0, System.Int32 P1, System.Int32 P2, System.Byte& P3)
  System.Void __Gen_Wrap_9(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_10(System.Object P0, Beyond.Gameplay.CommonTrackingPointStyleType P1, System.Object P2)
  System.Void __Gen_Wrap_11(System.Object P0, Beyond.Gameplay.CommonTrackingPointStyleType P1)
  System.Void __Gen_Wrap_12(System.Object P0, UnityEngine.Vector2 P1, System.Single P2, System.Boolean P3, System.Single P4, System.Boolean P5)
  System.Void __Gen_Wrap_13(System.Object P0, Beyond.Gameplay.PosValueState P1, System.Boolean P2, UnityEngine.Vector2 P3, System.Single P4, System.Boolean P5, System.Single P6, Beyond.Gameplay.CommonTrackMapTier P7)
  System.Boolean __Gen_Wrap_14(System.Object P0)
  System.Int32 __Gen_Wrap_15(System.Object P0, System.Object P1)
  Beyond.UI.CommonTrackerUpdate.CommonTrackerItem __Gen_Wrap_16(System.Object P0)
  System.Boolean __Gen_Wrap_17(System.Object P0, System.Int32 P1, System.Object P2, System.Object P3)
  System.Void __Gen_Wrap_18(System.Object P0, System.Object P1, System.Object P2)
  System.Void __Gen_Wrap_19(System.Object P0, System.Boolean P1, System.Int32 P2)
  System.Void __Gen_Wrap_20(System.Object P0, System.Object P1, System.Object P2, System.UInt64 P3, System.Int32 P4)
  System.String __Gen_Wrap_21(System.Object P0, Beyond.LangKey P1, System.Object P2)
  System.Void __Gen_Wrap_22(System.Object P0, Beyond.UI.CoolerUnitTemperatureCircleUI.ETemperatureState P1)
  System.Void __Gen_Wrap_23(System.Object P0, System.Boolean P1)
  System.Void __Gen_Wrap_24(System.Object P0, System.Single& P1, System.Single& P2)
  System.String[] __Gen_Wrap_25()
  System.Boolean __Gen_Wrap_26(System.Object P0, System.UInt64 P1)
  System.Void __Gen_Wrap_27(System.Object P0, System.Int32 P1)
  Beyond.UI.DamageTextBase __Gen_Wrap_28(System.Object P0, Beyond.UI.DamageTextType P1)
  System.Void __Gen_Wrap_29(System.Object P0, System.Object P1, System.Int32 P2)
  System.Void __Gen_Wrap_30(System.Object P0, UnityEngine.Color P1)
  System.Void __Gen_Wrap_31(System.Object P0, System.Object P1, System.Object P2, System.Nullable<UnityEngine.Vector3> P3)
  System.Void __Gen_Wrap_32(System.Object P0, UnityEngine.Vector2 P1)
  UnityEngine.Vector3 __Gen_Wrap_33(System.Object P0)
  UnityEngine.Vector2 __Gen_Wrap_34(System.Object P0, System.Single P1, System.Single P2)
  System.Boolean __Gen_Wrap_35(System.Object P0, UnityEngine.Vector3 P1)
  System.Void __Gen_Wrap_36(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem.Modifier>& P1)
  System.Void __Gen_Wrap_37(System.Object P0, Beyond.GEnums.EnergyShardType P1, System.Boolean P2)
  System.Void __Gen_Wrap_38(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,UnityEngine.Vector3,UnityEngine.Vector2,System.String,Beyond.GEnums.EnergyShardType>& P1)
  System.Void __Gen_Wrap_39(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,UnityEngine.Vector3,UnityEngine.Vector2,System.String>& P1)
  System.Void __Gen_Wrap_40(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,Beyond.Gameplay.Core.AbilitySystemForEnemyPart,Beyond.Gameplay.PhysicalInflictionType>& P1)
  System.Void __Gen_Wrap_41(System.Object P0, Beyond.EventData<UnityEngine.Vector3,System.String,UnityEngine.Color>& P1)
  System.Void __Gen_Wrap_42(System.Object P0, Beyond.EventData<System.UInt64,System.Int32>& P1)
  Beyond.UI.DamageTextBaseV2 __Gen_Wrap_43(System.Object P0, Beyond.UI.DamageTextType P1, System.Object P2)
  System.Void __Gen_Wrap_44(System.Object P0, UnityEngine.Vector2 P1, System.Single P2)
  UnityEngine.GameObject __Gen_Wrap_45(System.Object P0, System.Object P1, System.Object P2)
  System.Void __Gen_Wrap_46(System.Object P0, System.Object P1, UnityEngine.Color P2)
  System.UInt32 __Gen_Wrap_47(System.Object P0, System.Object P1, System.Object P2)
  System.Void __Gen_Wrap_48(System.Object P0, System.UInt32 P1, System.Object P2, System.Object P3)
  System.Void __Gen_Wrap_49(System.Object P0, System.UInt32 P1, System.Object P2, System.Boolean P3, System.Object P4)
  System.Void __Gen_Wrap_50(System.Object P0, System.UInt32 P1, UnityEngine.Color P2)
  System.Void __Gen_Wrap_51(System.Object P0, System.Object P1, System.Boolean P2)
  System.Void __Gen_Wrap_52(System.Object P0, System.Boolean P1, System.Single P2, System.Object P3, System.Object P4)
  System.Void __Gen_Wrap_53(System.Object P0, System.Single P1, System.Boolean P2)
  System.Void __Gen_Wrap_54(UnityEngine.EventSystems.PointerEventData P0)
  System.Void __Gen_Wrap_55(System.Single P0)
  System.Void __Gen_Wrap_56(System.Object P0, System.Single P1, System.Single P2, System.Single P3, System.Boolean P4)
  System.Void __Gen_Wrap_57(System.Object P0, System.Single P1, System.Single P2)
  System.Void __Gen_Wrap_58(System.Object P0, System.Single P1, System.Single P2, System.Object P3)
  System.Void __Gen_Wrap_59(System.Object P0, System.Boolean P1, System.Boolean P2, System.Boolean P3, Beyond.UI.ForgeIronTemperatureCircleUI.ETemperatureState P4)
  System.Void __Gen_Wrap_60(System.Object P0, System.Boolean P1, System.Boolean P2)
  System.Void __Gen_Wrap_61(System.Object P0, Beyond.EventData<System.String>& P1)
  Beyond.UI.HeadBarCtrl.HeadBarType __Gen_Wrap_62(Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> P0)
  System.Void __Gen_Wrap_63(System.Object P0, System.Object P1, System.Single P2)
  System.Void __Gen_Wrap_64(System.Object P0, System.Object P1, System.Double P2)
  System.Void __Gen_Wrap_65(System.Object P0, Beyond.Gameplay.Core.AbilitySystem.Modifier& P1)
  System.Void __Gen_Wrap_66(System.Object P0, Beyond.UI.HeadBarCtrl.HeadBarRefreshReason P1)
  System.Void __Gen_Wrap_67(System.Object P0, Beyond.EventData<System.String,Beyond.Gameplay.Core.Entity>& P1)
  System.Void __Gen_Wrap_68(System.Object P0, Beyond.EventData<System.Boolean,Beyond.Gameplay.DialogEnums.DialogType>& P1)
  System.Void __Gen_Wrap_69(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem>& P1)
  System.Void __Gen_Wrap_70(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.AbilitySystem,System.Boolean>& P1)
  System.Void __Gen_Wrap_71(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.AbilitySystemForEnemyPart,System.Boolean>& P1)
  Beyond.Gameplay.Core.BuffIconConfig.BuffIconStyle __Gen_Wrap_72(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_73(System.Object P0, Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> P1)
  System.Void __Gen_Wrap_74(UnityEngine.Sprite P0)
  System.Void __Gen_Wrap_75(System.Object P0, Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> P1, System.Object P2, System.Object P3)
  System.Void __Gen_Wrap_76(System.Object P0, System.Int32 P1, System.Boolean P2)
  Beyond.UI.UIBuffCell __Gen_Wrap_77(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_78(System.Object P0, Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> P1, System.Object P2, System.Boolean P3)
  System.Void __Gen_Wrap_79(System.Object P0, Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> P1, System.Object P2, System.Boolean P3, Beyond.Gameplay.Core.Buff.FinishReason P4)
  System.Void __Gen_Wrap_80(System.Object P0, Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> P1, System.Boolean P2, System.Boolean P3, Beyond.Gameplay.Core.Buff.FinishReason P4)
  System.Nullable<UnityEngine.Vector3> __Gen_Wrap_81(System.Object P0)
  System.Void __Gen_Wrap_82(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.GlobalBuff,System.String>& P1)
  System.Void __Gen_Wrap_83(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.GlobalBuff,System.String,Beyond.Gameplay.Core.GlobalBuff.FinishReason>& P1)
  System.Void __Gen_Wrap_84(System.Object P0, System.Nullable<Beyond.GEnums.SpellInflictionOnCharType> P1)
  System.Void __Gen_Wrap_85(System.Object P0, Beyond.ObjectPtr<Beyond.Gameplay.Core.Buff> P1, System.Boolean P2, Beyond.Gameplay.Core.Buff.FinishReason P3)
  System.Void __Gen_Wrap_86(System.Object P0, Beyond.ObjectPtr<Beyond.Gameplay.Core.AbilitySystem> P1)
  Beyond.UI.UICharPassiveBase __Gen_Wrap_87(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_88(System.Object P0, Beyond.EventData<Beyond.Gameplay.SetLeaderReason,Beyond.Gameplay.Core.Entity,Beyond.Gameplay.Core.Entity>& P1)
  UnityEngine.GameObject __Gen_Wrap_89(System.Object P0, System.Object P1)
  System.Collections.Generic.Dictionary<System.String,Beyond.UI.RegionMap3DCfg> __Gen_Wrap_90(System.Object P0)
  System.String __Gen_Wrap_91(System.Object P0, System.Object P1, System.Object P2)
  UnityEngine.Sprite __Gen_Wrap_92(System.Object P0, System.Object P1, System.Object P2)
  System.Void __Gen_Wrap_93(System.Object P0, System.Object P1, UnityEngine.Vector3 P2, System.Object P3)
  System.Boolean __Gen_Wrap_94(UnityEngine.Vector2 P0, System.Single P1, UnityEngine.Rect P2)
  System.Void __Gen_Wrap_95(System.Object P0, Beyond.UI.RegionMapShowType P1, System.Object P2, System.Object P3, System.Single P4)
  UnityEngine.Transform __Gen_Wrap_96(System.Object P0, System.Object P1)
  UnityEngine.Vector3 __Gen_Wrap_97(System.Object P0, System.Object P1, System.Object P2, System.Object P3)
  Beyond.UI.RegionMap3DCfg __Gen_Wrap_98(System.Object P0, System.Object P1)
  DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> __Gen_Wrap_99(System.Object P0, System.Single P1, System.Object P2)
  System.Void __Gen_Wrap_100(System.Object P0, Beyond.EventData<System.Int64,System.Int64>& P1)
  System.Boolean __Gen_Wrap_101()
  System.Boolean __Gen_Wrap_102(System.Object P0, System.Object P1)
  UnityEngine.Vector3 __Gen_Wrap_103(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_104(System.Object P0, System.Object P1, UnityEngine.Vector3 P2)
  System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> __Gen_Wrap_105(System.Object P0)
  Beyond.UI.LuaPanel __Gen_Wrap_106(System.Object P0)
  Beyond.UI.OutOfScreenTargetsCtrl.Arrow __Gen_Wrap_107(System.Object P0)
  System.ValueTuple<UnityEngine.Vector2,System.Single> __Gen_Wrap_108(System.Object P0, UnityEngine.Vector3 P1)
  System.Void __Gen_Wrap_109(System.Object P0, Beyond.EventData<System.UInt64,System.UInt32>& P1)
  System.Void __Gen_Wrap_110(System.Object P0, Beyond.EventData<System.UInt64,System.String>& P1)
  System.Void __Gen_Wrap_111(System.Object P0, Beyond.EventData<System.UInt64,System.String,System.Int32>& P1)
  UnityEngine.Sprite __Gen_Wrap_112(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_113(System.Object P0, System.Int32 P1, System.Boolean P2, System.Boolean P3)
  System.Boolean __Gen_Wrap_114(System.Object P0, System.Boolean P1)
  System.Void __Gen_Wrap_115(System.Object P0, Beyond.EventData<System.UInt64,System.String,Beyond.GEnums.EnergyShardType>& P1)
  System.Void __Gen_Wrap_116(System.Object P0, System.Object P1, System.Int64 P2, System.Single P3)
  System.Void __Gen_Wrap_117(System.Object P0, UnityEngine.Vector3 P1, System.UInt64 P2)
  System.Void __Gen_Wrap_118(System.Object P0, System.Int32 P1, System.Object P2, System.Object P3)
  System.Void __Gen_Wrap_119(System.Object P0, System.Boolean P1, System.Object P2)
  System.Void __Gen_Wrap_120(System.Object P0, System.Int64 P1)
  System.Void __Gen_Wrap_121(System.Object P0, System.Int32 P1, System.UInt32 P2)
  System.Void __Gen_Wrap_122(System.Object P0, System.Int32 P1, System.Int32 P2, System.Int32 P3)
  System.Void __Gen_Wrap_123(System.Object P0, System.Int64 P1, System.Single P2)
  UnityEngine.RectTransform __Gen_Wrap_124(System.Object P0)
  System.Void __Gen_Wrap_125(System.Object P0, UnityEngine.Vector2 P1, System.Single P2, System.Boolean P3)
  Beyond.UI.UIPoiseKnot __Gen_Wrap_126(System.Object P0)
  System.Void __Gen_Wrap_127(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3, System.Object P4)
  System.Void __Gen_Wrap_128(System.Object P0, System.Double P1)
  System.Void __Gen_Wrap_129(System.Object P0, System.Object P1, System.Single P2, System.Boolean P3)
  System.Void __Gen_Wrap_130(System.Object P0, System.Object P1, System.Boolean P2, System.Int32 P3)
  System.Void __Gen_Wrap_131(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3)
  System.Void __Gen_Wrap_132(System.Object P0, UnityEngine.Vector3 P1)
  System.Void __Gen_Wrap_133(System.Object P0, Beyond.UI.UIHeadLabel.VisibleSource P1, System.Boolean P2)
  System.Void __Gen_Wrap_134(System.Object P0, Beyond.UI.UIHeadLabel.HeadLabelType P1, Beyond.UI.UIHeadLabel.VisibleSource P2, System.Boolean P3, System.Boolean P4)
  System.Void __Gen_Wrap_135(System.Boolean P0)
  System.Void __Gen_Wrap_136(System.Object P0, System.Boolean P1, System.Boolean P2, System.Boolean P3)
  System.Void __Gen_Wrap_137(System.Object P0, Beyond.EventData<Beyond.UI.UIStyleInputValidTypeMask>& P1)
  System.Void __Gen_Wrap_138(System.Object P0, System.UInt64 P1, System.Int32 P2, System.Int32 P3, System.Int32 P4)
  System.Void __Gen_Wrap_139(System.Object P0, Beyond.EventData<Beyond.Gameplay.Core.CinematicTimelineManagerBase.TimelineHandle>& P1)
  System.Void __Gen_Wrap_140(System.Object P0, Beyond.EventData<Beyond.Gameplay.ForbidType,System.Boolean>& P1)
  System.Void __Gen_Wrap_141(System.Object P0, Beyond.Gameplay.Factory.PowerAutoConnectStatus P1)
  UnityEngine.GameObject __Gen_Wrap_142(System.Object P0)
  System.Void __Gen_Wrap_143(System.Object P0, Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleIcon P1)
  Beyond.UI.UIAnimationWrapper __Gen_Wrap_144(System.Object P0)
  System.Void __Gen_Wrap_145(System.Object P0, Beyond.Gameplay.Core.GameMech.TravelPoleBrain.TravelPoleStatus P1)
  System.Void __Gen_Wrap_146(System.Object P0, Beyond.EventData<System.Int32,System.Single>& P1)
  System.Void __Gen_Wrap_147(System.Object P0, Beyond.EventData<Beyond.Gameplay.WaterDroneSourceType>& P1)
  System.Void __Gen_Wrap_148(System.Object P0, Beyond.Gameplay.CustomAbilityComponent.WaterDroneByHydrantState P1)
  System.Void __Gen_Wrap_149(System.Object P0, Beyond.EventData<Beyond.Gameplay.CustomAbilityComponent.WaterDroneByHydrantState>& P1)
  System.Void __Gen_Wrap_150(System.Object P0, Beyond.ObjectPtr<Beyond.Gameplay.Core.Entity> P1)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x20000B0
EXTENDS: AnonymousStorey
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x20000B1
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
TOKEN: 0x20000B2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-PoolCore-ListPoolInitializer_UI_Gameplay_Beyond-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-PoolCore-ListPoolInitializer_UI_Gameplay_Beyond-InitializeAtRuntime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-AtbNode-_OnAtbCellOutAnimCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-AtbNode-CheckAtbLoopAnim0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-AtbNode-_RefreshAtbShowing0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-AtbNode-OnInFightChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-AtbNode-OnGainAtb0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-AtbNode-OnCreate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-AtbNode-OnClose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-AtbNode-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-BlueprintPreviewHelper-SetSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-BlueprintPreviewHelper-AddGridValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-BlueprintPreviewHelper-BatchAddGridValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-BlueprintPreviewHelper-GetGridValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICharPassiveCounter-OnCharPassiveNumChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICampfireTracker-UpdateImage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICommonTracker-UpdateImage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CommonTrackerNodeComp-ShowStyleType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CommonTrackerNodeComp-PlayOutAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlackboxTracker-UpdatePosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICampfireTracker-UpdatePosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICommonLevelTracker-UpdatePosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICommonTracker-UpdatePosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CommonTrackerNodeComp-UpdatePosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CommonTrackerUpdate-get__inFactoryTopView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CommonTrackerUpdate-_FindTrackIndexByKey0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CommonTrackerUpdate-_CreateNewMissionTracker0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CommonTrackerUpdate-_InitTrackInfoByIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CommonTrackerUpdate-_HideTrackerGo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CommonTrackerUpdate-_DeleteInvalidTracker0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CommonTrackerUpdate-_ShowTrackerGo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CommonTrackerUpdate-UpdateCommonTrackers0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CommonTrackerUpdate-AllTrackersPlayOutAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-WorldUIController-TryGetNeedComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-WorldUIController-SetUIForward0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-WorldUIController-SetPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-WorldUIController-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitProgressBarUI-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitProgressBarUI-SetUIForward0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitProgressBarUI-SetPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitProgressBarUI-_TickCanvasGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitProgressBarUI-_UpdateProgress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitProgressBarUI-TickUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureCircleUI-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureCircleUI-SetUIForward0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureCircleUI-SetPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureCircleUI-_TickCanvasGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureCircleUI-_GetLangKeyOrDefault0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureCircleUI-_SetState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureCircleUI-_UpdateUIState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureCircleUI-TickUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-WorldUIController-set_uiActive0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-WorldUIController-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureUI-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureUI-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureUI-SetUIForward0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureUI-SetPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureUI-_TickCanvasGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureUI-NormalizeRange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureUI-_UpdateUIInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureUI-_UpdateUIPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTemperatureUI-TickUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTotalProgressBarUI-_GeneratePercentStrings0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTotalProgressBarUI-_ResetUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTotalProgressBarUI-_GetCanvas0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTotalProgressBarUI-_TryGetModule0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTotalProgressBarUI-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTotalProgressBarUI-SetUIForward0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTotalProgressBarUI-SetPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTotalProgressBarUI-_TickCanvasGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTotalProgressBarUI-_SetProgressText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTotalProgressBarUI-_UpdateProgress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CoolerUnitTotalProgressBarUI-TickUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-_InstantiateTextInstance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBase-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-_RecycleTextInstance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-_CreateTextInstance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBase-SetText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBase-SetText1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBase-SetColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBase-SetFollowTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBase-SetUIOffset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBase-get_worldPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextDamageBase-PlayAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-_GetRandomTextOffset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-_IsTextPosValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBase-PlayAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-_OnHpChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextIgniteBuff-SetUIState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextIgniteBuff-SetTextAndDuplication0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-_OnIgniteBuffText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBase-SetText2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-_OnImmuneText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-_OnPhysicalInflictionApplied0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-_OnSquadInFightChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-_OnCreateFlowText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-_OnCharLevelUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-OnCreate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-OnClose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-DebugChangeImpl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-OnShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-OnHide0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrl-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBaseV2-Assign0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-_CreateTextInstance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBaseV2-SetText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBaseV2-SetText1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBaseV2-SetColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBaseV2-SetFollowTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBaseV2-SetUIOffset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBaseV2-get_worldPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBaseV2-PlayAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-_GetRandomTextOffset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-_IsTextPosValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBaseV2-DestroyDisplay0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-_OnHpChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBaseV2-SetText2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-_OnIgniteBuffText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-_OnImmuneText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-_OnPhysicalInflictionApplied0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-_OnSquadInFightChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-_OnCreateFlowText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBaseV2-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-_RecycleTextInstance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-_OnCharLevelUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-OnCreate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-OnClose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-DebugChangeImpl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-OnShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-OnHide0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBaseV2-_UpdatePosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBaseV2-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCtrlV2-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBase-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBase-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBase-_UpdatePosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBase-TailLateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBaseV2-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextBlock-SetColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCriticalLevel0-SetColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCriticalLevel1-SetColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextCriticalLevel1-PlayAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextIgniteBuff-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextIgniteBuff-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DamageTextNormalLevel1-PlayAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacLineCell-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacLineCell-PlayLineAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacLineCell-PlayLineDecoAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacLineCell-ChangeLineColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacLineCell-ChangeLineWidth0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacLineDrawer-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacLineDrawer-_Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacLineDrawer-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacLineDrawer-_CloneLineObject0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacLineDrawer-_RefreshCopyLineObjectColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacLineDrawer-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacLineDrawer-DrawLine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacLineDrawer-PlayLineAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacLineDrawer-PlayPortLineDecoAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacLineDrawer-ChangeLineColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacLineDrawer-ClearDrawer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacRegionUpgradeEffectController-_RefreshNodeState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacRegionUpgradeEffectController-SetUpgradeState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacRegionUpgradeEffectController-SetSelectState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FacRegionUpgradeEffectController-SetVisibleState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPanelBase-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-_PosAdjust0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-_UpdatePositionOffsetAfterZoomed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-_RefreshPivotPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-_SetScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-_OnZoom0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-_ControllerZoomUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-_ControllerDragUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-_ControllerUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-_OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-_RefreshAll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-InitData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-MoveNode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-_OnUnlockMoveNode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-FocusNode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-OnUnlockTech0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-ZoomToFullTechTree0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacTechTreePanel-SetDetailShownState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FootBarDashCell-SetIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FootBarDashCell-SetDashCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FootBarDashCell-StartPlayNotEnoughAnim0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FootBarDashCell-StopPlayNotEnoughAnim0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronProgressBarUI-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronProgressBarUI-SetPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronProgressBarUI-SetUIForward0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronProgressBarUI-UpdateProgress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronProgressBarUI-TickUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronTemperatureCircleUI-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronTemperatureCircleUI-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronTemperatureCircleUI-SetPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronTemperatureCircleUI-SetUIForward0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronTemperatureCircleUI-_SetState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronTemperatureCircleUI-UpdateUIState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronTemperatureCircleUI-TickUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronTemperatureUI-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronTemperatureUI-SetPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronTemperatureUI-SetUIForward0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronTemperatureUI-UpdateUIInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronTemperatureUI-UpdateUIPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ForgeIronTemperatureUI-TickUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GuideFakeButton-ForceToggleTargetBinding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GuideFakeButton-_OnTriggerPlayerAction0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GuideFakeButton-CopyTargetBinding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GuideFakeButton-ClearBinding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GuideFakeButton-_ClearOnClick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GuideFakeButton-ClearTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GuideFakeButton-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GuideFakeButton-OnPointerDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GuideFakeButton-OnPointerUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GuideFakeButton-OnPointerEnter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GuideFakeButton-OnPointerExit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GuideFakeButton-OnPointerClick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GuideFakeButton-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_SetInDialog0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_GetHeadBarType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAbilityTargetFollower-_TryRefreshFollowTransform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAbilityTargetFollower-_UpdatePos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAbilityTargetFollower-SetActualVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAbilityTargetFollower-_SetDistanceVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAbilityTargetFollower-_UpdateScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAbilityTargetFollower-_UpdateSelfTransform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAbilityTargetFollower-SetTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-_SetImageFill0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-_CalculateHpChangeDisplay0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-_OnHpChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-ShowModifierAfterSetTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBarFollower-ShowModifierAfterSetTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_RefreshHeadBar0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_OnInteractNpc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_OnDialogStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_OnDialogFinish0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_OnAddHeadBar0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_OnRemoveHeadBar0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_OnHeadBarShowConfigChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_OnHpChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_OnEnemyPartEnableChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-_OnFirstInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffCell-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-OnPreWarm0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-OnPreWarm0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBarFollower-OnPreWarm0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_PrewarmHeadBar0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-OnCreate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-OnClose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPoiseBar-Refresh0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-BuffCellGroup-RemoveBuffCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-BuffCellGroup-ClearAllBuffCells0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-_GetIconStyle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffCell-SetBuffIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffCell-SetStackElementActive0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffCell-SetWarningState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffCell-SetVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffCell-VisualInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffCell-DataInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffCell-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffCell-SetStackCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-_DealWithBuffCellVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-_SetBuffCellSiblingInOrder0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-BuffCellGroup-CreateBuffCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-_AddBuffIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffCell-BeforePlayOutAnim0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-_RemoveBuffIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-OnBuffIconChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-Refresh0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-Refresh0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBarFollower-Refresh0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVigilanceBar-Refresh0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-OnShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-OnHide0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_UpdateSurroundingEnemies0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAbilityTargetFollower-get_followPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBarFollower-SetHeadBarVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_UpdateHeadBar0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_UpdateLevelInfoBar0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_UpdateVigilanceBar0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-_UpdateTacticalItemBar0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HeadBarCtrl-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HpBarComboNode-_AnimOutCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HpBarComboNode-_AnimInCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HpBarComboNode-_RefreshComboCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HpBarComboNode-_OnGlobalBuffStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HpBarComboNode-_OnGlobalBuffFinish0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HpBarComboNode-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-HpBarComboNode-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_SetHpFillAmount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_CalculateHpChangeDisplay0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeController-_CheckNeedShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeController-SetLocalNeedShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeController-InformShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_OnHpChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_OnTakeDamage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_HpVfxOutAnimCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_OnBuffChangeCharHpBarVfx0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_OnCharPassiveNumChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_BlinkBuffIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_OnBuffIconChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_OnBuffEnhanceChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-OnBuffIconChange1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-_OnBuffEnhanceChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffCell-OnBuffIgnite0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-_OnBuffIgnite0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-_UnregisterAbilityBuffEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_ClearMainChar0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-_RegisterAbilityBuffEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_GetOrCreateCharPassiveBase0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_ProcessOnMainCharChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_OnMainCharChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_OnTeamChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_OnMainCharHpActiveChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_CheckHpBarShowing0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_SetHpBarShowing0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-_UpdateHpDisplay0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MainCharHpBar-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPanelBase-LoadGameObject0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMap3DCfg-Load0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-get_cfg0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-_ClearMaterials0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPanelBase-GetSpritePath0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPanelBase-LoadSprite0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRegionMapTrackIcon-InitData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-_SetMapPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-_InitTrackIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-_InitUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-_InitPlayerIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-_InitSelect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-_RefreshMaterials0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-MoveToPlayer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-IsCircleIntersectingRectangle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-InitData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-GetNodeTransform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-GetNodeMoveTargetLocalPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-GetCfg0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-SetLoadedRegionTransform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-StartRegionRectTransformMoveRotationTween0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-RegionMapSetting-SetControllerLevelSelectedState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacMainRegion-_RefreshRegionState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacMainRegion-_OnMainRegionLevelChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacMainRegion-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacMainRegion-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFacMainRegion-InitMainRegion0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapCrane-_ClearSpriteAsset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapCrane-_RefreshCraneState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapCrane-_OnCraneStateChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapCrane-_UnBindAll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapCrane-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapCrane-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapCrane-_BindAll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapCrane-InitCrane0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapGameplayArea-_RefreshGameplayArea0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapGameplayArea-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapGameplayArea-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapLimitInRect-_LimitInRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapLimitInRect-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapLimitInRect-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapLimitInRect-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapLimitInRect-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapLimitInRect-StartLimitMarkInRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapLimitInRect-StopLimitMarkInRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapLimitInRect-ForceRefreshLimitState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapLine-_HoldLineSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapLine-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapLine-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapLine-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapLine-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapMissionArea-_IsCircleOutsideDisappearRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapMissionArea-_DisappearIfOutRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapMissionArea-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapMissionArea-_RefreshMissionArea0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapMissionArea-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapMissionArea-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapMisty-IsMistyVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapMisty-_RefreshMistyState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapMisty-_OnMistyStateChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapMisty-_UnBindAll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapMisty-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapMisty-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapMisty-_BindAll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapMisty-InitMisty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapSwitchBtn-InitSwitchButton0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapSwitchBtn-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapTouchPanelWrapper-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapTouchPanelWrapper-_IsFirstRaycastSelectable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapTouchPanelWrapper-_CheckDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapTouchPanelWrapper-_CheckScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILevelMapTouchPanelWrapper-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRegionMap3DPanel-_GetNodeTransform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRegionMap3DPanel-_GetMoveTargetLocalPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRegionMap3DPanel-_OnDoMoveTween0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRegionMap3DPanel-InitPanel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRegionMap3DPanel-OnClickLevelBtn0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRegionMap3DPanel-OnLevelHoverChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISettlementRegion-_RefreshSpriteWithTier0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISettlementRegion-_RefreshSettlementRegionState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISettlementRegion-_OnSettlementUnlocked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISettlementRegion-_UnBindAll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISettlementRegion-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISettlementRegion-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISettlementRegion-_BindAll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISettlementRegion-InitSettlementRegion0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISettlementRegion-GetNeedRefreshSettlementRegionTier0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISettlementRegion-RefreshSettlementRegionWithTier0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ChessboardDrop-_CheckEventValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ChessboardDrop-OnDrop0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ChessboardDrop-OnPointerEnter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ChessboardDrop-OnPointerExit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ChessboardDrop-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ChessboardDrop-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleCellDrag-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleDrag-OnBeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleCellDrag-OnBeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleDrag-OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleCellDrag-OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleDrag-OnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleCellDrag-OnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleDrag-OnPointerDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleCellDrag-OnPointerDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleDrag-OnPointerUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleCellDrag-OnPointerUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleDrag-OnPointerClick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleCellDrag-OnPointerClick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleDrag-OnPointerEnter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleCellDrag-OnPointerEnter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleDrag-OnPointerExit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleCellDrag-OnPointerExit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleControllerHelper-get_raycastResults0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleControllerHelper-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleControllerHelper-TryGetPuzzleSlotIndexByPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleDrag-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleDrag-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleDrag-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleDrag-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PuzzleDrag-SetIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-OutOfScreenTargetsCtrl-OnCreate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-OutOfScreenTargetsCtrl-OnShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-OutOfScreenTargetsCtrl-_CreateOneArrow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-OutOfScreenTargetsCtrl-_ScreenPosToUIPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-OutOfScreenTargetsCtrl-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-OnPressCancelled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-_OnOtherPressSkillButtonStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-OnUspChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-_InitSkillData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-_RefreshDeadState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-_CheckNormalSkillHighlight0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-_UpdateMainUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-_SetPressFillActive0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-_SetGoActive0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-_OnSkillButtonActiveConfigChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-RefreshSkillButton0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-_OnCharPotentialUnlock0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-_OnCharNormalSkillChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-_OnSkillUpgradeSuccess0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPanelBase-LoadSpriteWithOutFormat0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-_UpdateLongPressKeyHint0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-_OnInputActionKeyUpdated0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-Close0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-OnPressSkillStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-OnPressSkillEnd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-OnPressUltimateSkillStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-CastSkill0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-_CastUltimateSkill0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-OnPressUltimateSkillEnd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-FirstTimeInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-OnCharacterDie0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-_SetPressFillAmount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-ToggleControllerSkillIndicator0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-SetEmpty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-ClearBtnClick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-PressHandlerLongPress-OnPressStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-PressHandlerLongPress-OnUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-PressHandlerLongPress-OnPressEnd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-PressHandlerLongPress-OnPressCancel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressEnd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressCancel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-PressHandlerDrag-OnPressStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-PressHandlerDrag-OnUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-PressHandlerDrag-OnPressEnd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SkillButton-PressHandlerDrag-OnPressCancel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-CanSwitchToCenter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-OnPressCharIconStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-_OnMainCharChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-_OnIgniteBuffText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-FirstTimeInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-_OnHpChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-_HpVfxOutAnimCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-_OnBuffChangeCharHpBarVfx0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-_OnCharPassiveNumChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-Close0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-SetDeadState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-_UpdateComboSkillIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-_TryShowLevelUpAnim0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-_SetLevelText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-TacticalDotCell-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-OnTacticalItemChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-InitSquadIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-_MustUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-_UpdateIconAlpha0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-TacticalDotCell-SetDotActive0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-TacticalDotCell-SetDotUsedUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-_UpdateTacticalItemStatus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-SetEmpty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-ToggleIndicator0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-InformKeyHint0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-OnLevelChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SquadIcon-OnTeamSwitchUnlocked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAbilityTargetFollower-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAbilityTargetFollower-UpdateData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAbilityTargetFollower-TailLateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAbilityTargetFollower-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAttachedBuffCell-DataInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffCell-UpdateBuffCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAttachedBuffCell-UpdateBuffCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAttachedBuffCell-BeforePlayOutAnim0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAttachedBuffCell-SetBuffIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAttachedBuffCell-SetStackElementActive0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAttachedBuffCell-SetStackCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAttachedBuffCell-OnBuffIgnite0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBrokenLine-_Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBrokenLine-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBrokenLine-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBrokenLine-SetYValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBrokenLine-SetYValueByArray0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBuffNode-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICommonScanController-set_uiActive0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICommonScanController-_UpdatePos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICommonScanController-SetTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICommonScanController-SetFixPoint0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICommonScanController-_FaceToCamera0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICommonScanController-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICommonScanController-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICountDownBar-set_update0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICountDownBar-_UpdatePos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICountDownBar-_UpdateData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICountDownBar-InitData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICountDownBar-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICountDownBar-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDoodadMineCoreScanController-SetPurity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDoodadMineCoreScanController-SyncConditonInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDoodadMineCoreScanController-UpdateUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDoodadPlantCoreScanController-_SyncTimeText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDoodadPlantCoreScanController-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDoodadPlantCoreScanController-SetCoreInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDoodadPlantCoreScanController-SetRefreshInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDoodadPlantCoreScanController-RefreshTextNow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDoodadPlantCoreScanController-SetSingle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDoodadPlantCoreScanController-SetQuantityInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDoodadScanController-SyncRefreshInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDoodadScanController-_RefreshCountDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDoodadScanController-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDoodadScanController-UpdateUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGeneralTracker-get_rect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGeneralTracker-UpdatePosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPoiseKnot-SetVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPoiseBar-_ClearPoiseKnot0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPoiseBar-_CreatePoiseKnot0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPoiseBar-_TryInitPoiseKnot0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPoiseBar-get_hidePoiseBar0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPoiseBar-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-_OnForceSetHp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPoiseKnot-KnotBreak0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPoiseBar-_CalculatePoiseChangeDisplay0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPoiseBar-OnPoiseChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-_OnPoiseChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWeaknessNode-SetTotalCellNum0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-_OnMultiTimeWeaknessActivate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWeaknessNode-SetCurrentCellNum0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-_OnWeaknessCountChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-_OnMainTargetChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-SetTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPoiseBar-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-_UpdateHpDisplay0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-_UpdateScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPoiseBar-_UpdatePoiseDisplay0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPoiseBar-UpdatePoiseBar0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBar-UpdateData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBarFollower-_UpdateGuideLine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBarFollower-SetTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBarFollower-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadBarFollower-UpdateData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-_OnSubRootsCollectionChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-_TryInitRootData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-SetVisibleDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-get_realVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-_UpdateVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-UpdateVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-SetSubRootVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-_OnNpcVisibleChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-_BindTargetEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-_UpdateFloatingUIVisibleCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-_TryUpdateVisibleCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-_UpdatePos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-_OnMissionTypeIconChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-_BindMissionTracking0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-SetTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-_ClearFloatingUIVisibleCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-_ClearVisibleCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-_RefreshVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-ClearEmojis0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-_UnBindMissionTracking0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-_UnBindTargetEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-SetActive0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-_TryUpdateVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHeadLabel-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeConsoleController-_CheckNeedShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeConsoleController-_OnFadeHud0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeConsoleController-InformShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeConsoleController-_OnInformShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeConsoleController-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeConsoleController-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeConsoleController-OnShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeController-_OnFadeHud0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeController-_OnInformShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeController-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeController-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeTouchSkill-_CheckNeedShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeTouchSkill-_OnFadeHud0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeTouchSkill-InformShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeTouchSkill-_OnInformShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeTouchSkill-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeTouchSkill-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHudFadeTouchSkill-OnShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILifeTimeBuffCell-UpdateBuffCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILifeTimeBuffCell-SetWarningState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILiquidPoolScanController-SetWaterInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILockAim-_RefreshTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILockAim-_OnLockTargetFromAutoToManual0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILockAim-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILockAim-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILockAim-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILockAim-UpdateData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILvInfoBar-SetTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBar-_OnDashFailed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBar-_ProcessOnMainCharChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBar-_OnMainCharChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBar-_SetInDialog0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBar-_OnInteractNpc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBar-_OnDialogStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBar-_OnDialogFinish0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBar-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBar-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBar-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBar-_OnDashCountChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBar-_OnOutAnimCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBar-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-_OnDashFailed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-_ProcessOnMainCharChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-_OnMainCharChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-_RefreshDisableState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-_SetInDialog0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-_OnInteractNpc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-_OnDialogStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-_OnDialogFinish0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-_OnPlayCutscene0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-_OnFinishCutscene0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-_OnForbidSystemChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-_OnDashCountChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-_OnOutAnimCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-TailLateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMainCharFootBarArc-SetUIDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateDistance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleAutoConnectTracker-IconGroup-Switch0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleAutoConnectTracker-StatusHintGroup-Switch0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleAutoConnectTracker-_ActualUpdateStatus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateStatus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleAutoConnectTracker-IconGroup-SetActiveIfNecessary0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleAutoConnectTracker-_ActualUpdateIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateNodeType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleFastTravelTracker-get_isDisabled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleFastTravelTracker-get_imageNormal0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleFastTravelTracker-get_imageWarning0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleFastTravelTracker-get_imageHighlighted0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleFastTravelTracker-get_imageDisabled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleFastTravelTracker-_UpdateIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleFastTravelTracker-set_iconStatus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleFastTravelTracker-get_animationWrapper0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleFastTravelTracker-PlayFocus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIconStatus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleFastTravelTracker-UpdateStatus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIsHighlighted0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleFastTravelTracker-UpdateDistance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleFastTravelTracker-_OnStatusChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPowerPoleFastTravelTracker-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRaceModuleRankController-_ResetData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRaceModuleRankController-_ShowBaseTrans0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRaceModuleRankController-_LoadAllSprite0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRaceModuleRankController-_UpdateRaceModuleRank0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRaceModuleRankController-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRaceModuleRankController-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRaceModuleRankController-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITacticalItemBar-SetTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITacticalItemBar-UpdateData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVideoHelper-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVideoHelper-ResetVideo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVideoHelper-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVideoHelper-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVigilanceBar-SetTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVigilanceBar-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVigilanceBar-_UpdateVigilanceNode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVigilanceBar-UpdateData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWeakLockAim-_RefreshTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWeakLockAim-_OnMainTargetChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWeakLockAim-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWeakLockAim-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWeakLockAim-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWeaknessNode-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWaterDroneBar-_OnWaterDroneInfinityLiquidChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWaterDroneBar-_OnWaterDroneEmptyChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWaterDroneBar-_OnWaterDroneInteractiveChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWaterDroneBar-_OnWaterDroneSourceTypeChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWaterDroneBar-_OnWaterDroneRelaxChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWaterDroneBar-_OnWaterDroneHydrantStateChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWaterDroneBar-_OnWaterDroneHydrantStateChanged1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWaterDroneBar-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWaterDroneBar-_ClearWaterDrone0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWaterDroneBar-_OnWaterDroneChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWaterDroneBar-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWaterDroneBar-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWaterDroneBar-_SetIconStateController0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWaterDroneBar-_UpdateState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWaterDroneBar-_UpdateSlider0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWaterDroneBar-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-WorldUIController-TickUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-WorldUIController-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-WorldUIController-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-Mission-MissionHudBGSizeUpdater-UpdateBgSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-Mission-MissionHudBGSizeUpdater-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-Mission-MissionHudBGSizeUpdater-Tick0  // 0x0
METHODS:
END_CLASS

