// ========================================================
// Dumped by @desirepro
// Assembly: UI.Beyond.dll
// Classes:  354
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UIMinSizeAdjust
TYPE:  class
TOKEN: 0x2000002
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.RectTransform       _panelRect  // 0x18
METHODS:
  System.Void Start()
  System.Void _SetTextureScaleByWidth()
  System.Void .ctor()
END_CLASS

CLASS: RichTextInfo
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  public            System.Int32                    index  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: InlineImageInfo
TYPE:  class
TOKEN: 0x200000F
EXTENDS: RichTextInfo
FIELDS:
  public            System.String                   path  // 0x18
  public            System.Single                   width  // 0x20
  public            System.Single                   height  // 0x24
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: RichTextTagType
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIText.RichTextTagTypeImage  // 0x0
  public    static  Beyond.UI.UIText.RichTextTagTypeWidth  // 0x0
  public    static  Beyond.UI.UIText.RichTextTagTypeHeight  // 0x0
  public    static  Beyond.UI.UIText.RichTextTagTypeScale  // 0x0
METHODS:
END_CLASS

CLASS: RichTextStyleSeq
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIText.RichTextStyleSeqNORMAL  // 0x0
  public    static  Beyond.UI.UIText.RichTextStyleSeqDARK_BACKGROUND  // 0x0
  public    static  Beyond.UI.UIText.RichTextStyleSeqLIGHT_BACKGROUND  // 0x0
METHODS:
END_CLASS

CLASS: ParamValueType
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIText.RichTextAnalyzer.ParamValueTypeNone  // 0x0
  public    static  Beyond.UI.UIText.RichTextAnalyzer.ParamValueTypeString  // 0x0
  public    static  Beyond.UI.UIText.RichTextAnalyzer.ParamValueTypeInt  // 0x0
  public    static  Beyond.UI.UIText.RichTextAnalyzer.ParamValueTypeFloat  // 0x0
METHODS:
END_CLASS

CLASS: RichTextTag
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            Beyond.UI.UIText.RichTextTagTyperichTextTagType  // 0x10
  public            Beyond.UI.UIText.RichTextAnalyzer.ParamValueTypeparamValueType  // 0x14
METHODS:
END_CLASS

CLASS: RichTextParam
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            Beyond.UI.UIText.RichTextTagTyperichTextTagType  // 0x10
  public            Beyond.UI.UIText.RichTextAnalyzer.AnyTypeStructvalue  // 0x18
METHODS:
END_CLASS

CLASS: AnyTypeStruct
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  public            System.Int32                    intValue  // 0x10
  public            System.Single                   floatValue  // 0x10
  public            System.String                   stringValue  // 0x10
METHODS:
END_CLASS

CLASS: ProcessRichTextEntryFunc
TYPE:  class
TOKEN: 0x2000017
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Beyond.UI.UIText.RichTextInfo Invoke(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam mainParam, System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> subParams, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder)
  System.IAsyncResult BeginInvoke(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam mainParam, System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> subParams, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder, System.AsyncCallback callback, System.Object object)
  Beyond.UI.UIText.RichTextInfo EndInvoke(Cysharp.Text.Utf16ValueStringBuilder& stringBuilder, System.IAsyncResult result)
END_CLASS

CLASS: RichTextAnalyzer
TYPE:  class
TOKEN: 0x2000012
FIELDS:
  private   static  System.Char                     CUSTOM_RICH_TEXT_LEFT_BRACKET  // 0x0
  private   static  System.Char                     CUSTOM_RICH_TEXT_RIGHT_BRACKET  // 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIText.RichTextAnalyzer.RichTextTag>s_tagToTypeDic  // 0x0
  public    static  System.String                   FONT_SHADOW_OPENING_TAG  // 0x0
  public    static  System.String                   FONT_SHADOW_CLOSING_TAG  // 0x0
  public    static  System.String                   FONT_MAT_OPENING_TAG  // 0x0
  public    static  System.String                   FONT_MAT_CLOSING_TAG  // 0x0
  private   static readonly System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam>s_subParams  // 0x8
METHODS:
  System.String PreAnalyzeRichText(System.String text, System.Boolean needParseActionId)
  System.String AnalyzeRichText(System.String text, Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc processFunc, System.Collections.Generic.List<Beyond.UI.UIText.RichTextInfo>& infos)
  System.Boolean _TryParseRichTextEntry(System.ReadOnlySpan<System.Char> span, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder, Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc processFunc, Beyond.UI.UIText.RichTextInfo& richTextInfo)
  System.Boolean _TryParseParam(System.ReadOnlySpan<System.Char> span, Beyond.UI.UIText.RichTextAnalyzer.RichTextParam& param)
  Beyond.UI.UIText.RichTextInfo ProcessRichTextEntryFallback(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam mainParam, System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> subParams, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder)
  System.Int32 GetCharacterCountWithoutRichText(System.ReadOnlySpan<System.Char> str)
  System.Int32 _GetHashCode(System.ReadOnlySpan<System.Char> str)
  System.Void .cctor()
END_CLASS

CLASS: HyperlinkUITextWrap
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  public            Beyond.UI.UIText                uiText  // 0x10
  public            System.String                   hyperlinkUITextGroupId  // 0x18
  public            System.Int32                    order  // 0x20
  public            System.Boolean                  isDisplayable  // 0x24
METHODS:
  System.Void Clear()
  System.Void .ctor()
END_CLASS

CLASS: HyperlinkUITextGroup
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  public            System.Collections.Generic.HashSet<Beyond.UI.UIText.HyperlinkUITextWrap>wrapSet  // 0x10
  public            System.String                   groupId  // 0x18
  public            System.Int32                    displayableCount  // 0x20
METHODS:
  System.Void Add(Beyond.UI.UIText.HyperlinkUITextWrap wrap)
  System.Void Remove(Beyond.UI.UIText.HyperlinkUITextWrap wrap)
  System.Void ChangeDisplayable(Beyond.UI.UIText.HyperlinkUITextWrap wrap, System.Boolean displayable)
  System.Void _AddDisplayableCount()
  System.Void _SubDisplayableCount()
  System.Void _NotifyDisplayableChanged()
  System.Void .ctor()
END_CLASS

CLASS: HyperlinkUITextManager
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,Beyond.UI.UIText.HyperlinkUITextGroup>m_hyperlinkUITextGroupMap  // 0x10
  private           Beyond.PoolCore.ObjectPool<Beyond.UI.UIText.HyperlinkUITextGroup>m_hyperlinkUITextGroupPool  // 0x18
  private           Beyond.PoolCore.ObjectPool<Beyond.UI.UIText.HyperlinkUITextWrap>m_hyperlinkUITextWrapPool  // 0x20
  private   static  Beyond.UI.UIText.HyperlinkUITextManagers_instance  // 0x0
  private   static readonly System.Collections.Generic.List<Beyond.UI.UIText.HyperlinkUITextWrap>SORT_WRAP_TEMP_LIST  // 0x8
METHODS:
  Beyond.UI.UIText.HyperlinkUITextManager get_instance()
  System.Void AddWrap(Beyond.UI.UIText uiText, System.String groupId, System.Int32 order)
  System.Void RemoveWrap(Beyond.UI.UIText uiText)
  System.Void ChangeWrapGroup(Beyond.UI.UIText.HyperlinkUITextWrap wrap, System.String newGroupId, System.Int32 newOrder)
  System.Void ChangeWrapOrder(Beyond.UI.UIText.HyperlinkUITextWrap wrap, System.Int32 newOrder)
  System.Void UpdateWrapDisplayable(Beyond.UI.UIText uiText)
  System.Boolean IsGroupDisplayable(System.String groupId)
  System.Collections.Generic.List<Beyond.UI.UIText> GetGroupDisplayableUIText(System.String groupId)
  Beyond.UI.UIText.HyperlinkUITextGroup _GetGroup(System.String groupId, System.Boolean autoCreate)
  System.Boolean _IsUITextDisplayable(Beyond.UI.UIText uiText)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: ImageGOInfo
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            UnityEngine.GameObject          go  // 0x10
  public            UnityEngine.RectTransform       rectTransform  // 0x18
  public            UnityEngine.UI.Image            image  // 0x20
METHODS:
END_CLASS

CLASS: AnimationState
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIConst.AnimationStateStop  // 0x0
  public    static  Beyond.UI.UIConst.AnimationStateIn  // 0x0
  public    static  Beyond.UI.UIConst.AnimationStateLoop  // 0x0
  public    static  Beyond.UI.UIConst.AnimationStateOut  // 0x0
  public    static  Beyond.UI.UIConst.AnimationStateInEasing  // 0x0
  public    static  Beyond.UI.UIConst.AnimationStateOthers  // 0x0
METHODS:
END_CLASS

CLASS: CommonUISegment
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIConst.CommonUISegmentInteractiveEntity  // 0x0
  public    static  Beyond.UI.UIConst.CommonUISegmentLevelScriptModule  // 0x0
METHODS:
END_CLASS

CLASS: MeunItemInfo
TYPE:  class
TOKEN: 0x2000029
FIELDS:
  public            Beyond.UI.UIButton              button  // 0x10
  public            Beyond.UI.UIToggle              toggle  // 0x18
  public            System.Boolean                  showIcon  // 0x20
  public            UnityEngine.Sprite              sprite  // 0x28
  public            Beyond.UI.UIText                text  // 0x30
  public            System.String                   textId  // 0x38
  public            System.String                   textIdForToggleOff  // 0x40
  public            System.Int32                    priority  // 0x48
METHODS:
  System.Boolean get_isForceValid()
  System.Boolean IsValid()
  System.String GetText()
  UnityEngine.Sprite GetSprite()
  System.Void Execute()
  System.String GetItemName()
  System.Void .ctor()
END_CLASS

CLASS: OverrideValidState
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.CustomUIStyle.OverrideValidStateNone  // 0x0
  public    static  Beyond.UI.CustomUIStyle.OverrideValidStateForceValid  // 0x0
  public    static  Beyond.UI.CustomUIStyle.OverrideValidStateForceNotValid  // 0x0
METHODS:
END_CLASS

CLASS: State
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.FullScreenSceneBlurMarker.StateOnEnable  // 0x0
  public    static  Beyond.UI.FullScreenSceneBlurMarker.StateOnDisable  // 0x0
  public    static  Beyond.UI.FullScreenSceneBlurMarker.StateOnDestroy  // 0x0
METHODS:
END_CLASS

CLASS: ShapeType
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.NonDrawingGraphic.ShapeTypeRectangle  // 0x0
  public    static  Beyond.UI.NonDrawingGraphic.ShapeTypeCircle  // 0x0
METHODS:
END_CLASS

CLASS: ParallaxConfig
TYPE:  class
TOKEN: 0x2000042
FIELDS:
  public            UnityEngine.RectTransform       target  // 0x10
  public            System.Single                   ratio  // 0x18
  public            UnityEngine.Vector2             oriPosition  // 0x1C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ICustomViewType
TYPE:  interface
TOKEN: 0x2000045
FIELDS:
METHODS:
  System.Int32 get_viewType()
END_CLASS

CLASS: ICustomSpacing
TYPE:  interface
TOKEN: 0x2000046
FIELDS:
METHODS:
  System.Single GetCustomSpacing()
END_CLASS

CLASS: IVirtualView
TYPE:  interface
TOKEN: 0x2000047
FIELDS:
METHODS:
  System.Void AttachView(UnityEngine.GameObject view)
  System.Void DetachView()
  UnityEngine.GameObject GetAttachedView()
  System.Int32 GetViewID()
  UnityEngine.GameObject GetPrefab()
  System.Single GetPreferSize()
END_CLASS

CLASS: VirtualView
TYPE:  class
TOKEN: 0x2000048
FIELDS:
  protected         UnityEngine.GameObject          m_gameObj  // 0x10
METHODS:
  System.Boolean get_isAttached()
  System.Void AttachView(UnityEngine.GameObject gameObj)
  System.Void DetachView()
  UnityEngine.GameObject GetAttachedView()
  System.Int32 GetViewID()
  System.Void OnViewAttached()
  System.Void OnViewDetached()
  UnityEngine.GameObject GetPrefab()
  System.Single GetPreferSize()
  System.Void .ctor()
END_CLASS

CLASS: SimpleAdapter
TYPE:  class
TOKEN: 0x200004A
EXTENDS: UIRecycleLayoutAdapter
FIELDS:
  private           Beyond.UI.UIRecycleLayoutSimpleHolder<TVirtualView>m_holder  // 0x0
  private           System.Collections.Generic.List<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView>m_virtualViews  // 0x0
METHODS:
  System.Void .ctor(Beyond.UI.UIRecycleLayoutSimpleHolder<TVirtualView> holder)
  System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
  System.Void NotifyRebuild()
  System.Void InsertView(System.Int32 index, TVirtualView virtualView)
  System.Void AppendView(TVirtualView virtualView)
  System.Void AddView(TVirtualView virtualView)
  System.Void RemoveView(System.Int32 index)
  System.Void RemoveAllViews(System.Boolean dontRebuild)
  System.Int32 GetCount()
  TVirtualView GetVirtualView(System.Int32 index)
  UnityEngine.GameObject GetView(System.Int32 index)
  System.Void NotifySizeChanged(TVirtualView virtualView)
  System.Void NotifyAllSizeChanged()
  System.Void NotifySizeChanged(System.Int32 index)
  System.Void OnInit()
  System.Void OnDisposed()
END_CLASS

CLASS: Direction
TYPE:  struct
TOKEN: 0x200004D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIRecycleLayoutGroup.DirectionVertical  // 0x0
  public    static  Beyond.UI.UIRecycleLayoutGroup.DirectionHorizontal  // 0x0
METHODS:
END_CLASS

CLASS: AdaptMode
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIRecycleLayoutGroup.AdaptModeNormal  // 0x0
  public    static  Beyond.UI.UIRecycleLayoutGroup.AdaptModeMultiPrefab  // 0x0
METHODS:
END_CLASS

CLASS: IViewHandler
TYPE:  interface
TOKEN: 0x200004F
FIELDS:
METHODS:
  Beyond.UI.UIRecycleLayoutAdapter.IVirtualView GetView(System.Int32 index)
  System.Int32 GetViewCount()
  System.Boolean InsertView(System.Int32 index, Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  System.Boolean AddView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  System.Void NotifyViewSizeChanged(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  System.Void NotifyAllViewSizeChanged()
  System.Void NotifyRebuild()
  System.Boolean RemoveView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  System.Single GetElementPosByIndex(System.Int32 index)
  UnityEngine.Bounds GetElementBoundsByIndex(System.Int32 index)
  Beyond.UI.UIRecycleLayoutGroup.Direction GetDirection()
  System.Single GetSizeOnAxis()
  System.Single GetViewportSizeOnAxis()
  System.Int32 GetElementIndex(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
END_CLASS

CLASS: LayoutMeta
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  public            System.Single                   pos  // 0x10
  public            System.Single                   size  // 0x14
  public            System.Int32                    index  // 0x18
  public            System.Single                   curTotalSize  // 0x1C
METHODS:
END_CLASS

CLASS: ViewPool
TYPE:  class
TOKEN: 0x2000051
FIELDS:
  private           UnityEngine.GameObject          m_prefab  // 0x10
  private           UnityEngine.Transform           m_container  // 0x18
  private           System.Collections.Generic.List<UnityEngine.GameObject>m_activeObjs  // 0x20
  private           System.Collections.Generic.List<UnityEngine.GameObject>m_pooledObjs  // 0x28
  private           System.Int32                    <viewType>k__BackingField  // 0x30
METHODS:
  System.Int32 get_viewType()
  System.Void set_viewType(System.Int32 value)
  System.Void .ctor(System.Int32 viewType, UnityEngine.GameObject prefab, UnityEngine.Transform container)
  UnityEngine.GameObject Alloc(System.Boolean& isNewlyCreated)
  System.Boolean Recycle(UnityEngine.GameObject obj)
  System.Void RecycleAll()
END_CLASS

CLASS: ViewMgr
TYPE:  class
TOKEN: 0x2000052
FIELDS:
  private           Beyond.UI.UIRecycleLayoutGroup  m_closure  // 0x10
  private           Beyond.ListDict<System.Int32,Beyond.UI.UIRecycleLayoutGroup.ViewPool>m_viewPools  // 0x18
  private           System.Collections.Generic.List<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView>m_views  // 0x20
METHODS:
  System.Void .ctor(Beyond.UI.UIRecycleLayoutGroup closure)
  System.Void RebuildAll(Beyond.UI.UIRecycleLayoutAdapter adapter)
  System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> GetViews()
  System.Void DetachView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view, UnityEngine.GameObject curView)
  System.Void AttachView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  Beyond.UI.UIRecycleLayoutAdapter.IVirtualView GetView(System.Int32 index)
  System.Int32 GetViewCount()
  System.Boolean InsertView(System.Int32 index, Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  System.Boolean AddView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  System.Boolean RemoveView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  System.Void NotifyViewSizeChanged(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  System.Void NotifyAllViewSizeChanged()
  System.Void NotifyRebuild()
  System.Single GetElementPosByIndex(System.Int32 index)
  UnityEngine.Bounds GetElementBoundsByIndex(System.Int32 index)
  Beyond.UI.UIRecycleLayoutGroup.Direction GetDirection()
  System.Single GetSizeOnAxis()
  System.Single GetViewportSizeOnAxis()
  System.Int32 GetElementIndex(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  Beyond.UI.UIRecycleLayoutGroup.ViewPool _EnsureViewPool(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  System.Void _NotifyLayoutChanged(System.Int32 fromIndex)
END_CLASS

CLASS: Padding
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  public            System.Int32                    top  // 0x10
  public            System.Int32                    left  // 0x14
  public            System.Int32                    bottom  // 0x18
  public            System.Int32                    right  // 0x1C
METHODS:
END_CLASS

CLASS: EmptyAdapter
TYPE:  class
TOKEN: 0x2000054
EXTENDS: UIRecycleLayoutAdapter
FIELDS:
METHODS:
  System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
  System.Void OnInit()
  System.Void .ctor()
  System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> <>iFixBaseProxy_GenerateViewsForRebuild()
END_CLASS

CLASS: MultiVirtualView
TYPE:  class
TOKEN: 0x2000056
EXTENDS: VirtualView
FIELDS:
  private           Beyond.UI.UIRecycleMultiHolder  m_closure  // 0x18
  public            System.Single                   preferSize  // 0x20
  public            System.String                   prefabKey  // 0x28
METHODS:
  System.Int32 GetIndex()
  System.Void .ctor(System.Single initSize, System.String key, Beyond.UI.UIRecycleMultiHolder closure)
  UnityEngine.GameObject GetPrefab()
  System.Single GetPreferSize()
  System.Void OnViewDetached()
  System.Void OnViewAttached()
END_CLASS

CLASS: Config
TYPE:  class
TOKEN: 0x2000057
FIELDS:
  public            System.String                   key  // 0x10
  public            UnityEngine.GameObject          cellTemplate  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SimpleVirtualView
TYPE:  class
TOKEN: 0x2000059
EXTENDS: VirtualView
FIELDS:
  private           Beyond.UI.UIRecycleSingleHolder m_holder  // 0x18
  public            System.Single                   preferSize  // 0x20
METHODS:
  System.Int32 GetIndex()
  System.Void .ctor(System.Single initSize, Beyond.UI.UIRecycleSingleHolder holder)
  UnityEngine.GameObject GetPrefab()
  System.Single GetPreferSize()
  System.Void OnViewDetached()
  System.Void OnViewAttached()
END_CLASS

CLASS: CellInfo
TYPE:  class
TOKEN: 0x200005C
FIELDS:
  public            System.Int32                    index  // 0x10
  public            UnityEngine.GameObject          obj  // 0x18
  public            Beyond.UI.UIAnimationWrapper    animationWrapper  // 0x20
  public            UnityEngine.Coroutine           cor  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ClipHolder
TYPE:  class
TOKEN: 0x2000061
FIELDS:
  public            UnityEngine.AnimationClip       clip  // 0x10
  public            System.String                   alias  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: AnimationRuntime
TYPE:  class
TOKEN: 0x2000064
FIELDS:
  public            Beyond.UI.UIAnimationTween.Optionsoption  // 0x10
  public            UnityEngine.AnimationState      state  // 0x18
  public            System.Boolean                  isPlaying  // 0x20
METHODS:
  System.Single GetClipLength()
  System.Void .ctor()
END_CLASS

CLASS: FOptions
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
  public            DG.Tweening.Ease                animEase  // 0x10
METHODS:
  Beyond.UI.UIAnimationWrapper.FOptions GetDefault()
END_CLASS

CLASS: CachedSampleClipInfo
TYPE:  struct
TOKEN: 0x2000066
FIELDS:
  public            Beyond.UI.UIAnimationWrapper.AnimationRuntimeruntime  // 0x10
  public            System.Single                   position  // 0x18
  public            System.Boolean                  isDirty  // 0x1C
METHODS:
  System.Void .ctor(System.Boolean isDirty)
END_CLASS

CLASS: Options
TYPE:  struct
TOKEN: 0x200006C
FIELDS:
  public            System.Boolean                  isInverse  // 0x10
  public            System.Single                   startPosition  // 0x14
METHODS:
END_CLASS

CLASS: TweenHandler
TYPE:  class
TOKEN: 0x2000070
FIELDS:
  private           Beyond.UI.UIAnimationSwitchTweenm_closure  // 0x10
  private           System.Boolean                  m_isIn  // 0x18
  private           System.Boolean                  m_pendingClear  // 0x19
  private           DG.Tweening.TweenCallback       m_pendingCallback  // 0x20
  private           System.Boolean                  m_isComplete  // 0x28
METHODS:
  System.Void .ctor(Beyond.UI.UIAnimationSwitchTween closure, System.Boolean isIn)
  System.Boolean IsPlaying()
  System.Void KillIfNecessary()
  Beyond.UI.UISwitchTween.ITweenHandler OnComplete(DG.Tweening.TweenCallback callback)
  Beyond.UI.UISwitchTween.ITweenHandler SetAutoKill(System.Boolean autoKill)
  System.Void _OnComplete()
END_CLASS

CLASS: Builder
TYPE:  struct
TOKEN: 0x2000071
FIELDS:
  public            Beyond.UI.UIAnimationWrapper    animWrapper  // 0x10
  public            System.Boolean                  dontDisableGameObject  // 0x18
METHODS:
  Beyond.UI.UIAnimationSwitchTween Build()
END_CLASS

CLASS: FWorldCanvasParams
TYPE:  struct
TOKEN: 0x2000080
FIELDS:
  public            System.Single                   screenRatio  // 0x10
  public            UnityEngine.Vector2             screenSize  // 0x14
  public            UnityEngine.Vector2             uiRootSize  // 0x1C
  public            UnityEngine.Vector3             uiRootScale  // 0x24
METHODS:
END_CLASS

CLASS: FScreenCanvasParams
TYPE:  struct
TOKEN: 0x2000081
FIELDS:
  public            System.Single                   screenRatio  // 0x10
  public            UnityEngine.Vector2             screenSize  // 0x14
  public            Beyond.UI.CanvasMatchMode       matchMode  // 0x1C
  public            System.Single                   matchWidthOrHeight  // 0x20
METHODS:
END_CLASS

CLASS: CommonParams
TYPE:  struct
TOKEN: 0x2000083
FIELDS:
  public            System.Single                   alpha  // 0x10
  public            System.Single                   duration  // 0x14
  public            System.Boolean                  ignoreTimeScale  // 0x18
  public            UnityEngine.Color               targetColor  // 0x1C
  public            System.Boolean                  useAlpha  // 0x2C
  public            System.Boolean                  useRGB  // 0x2D
  public            System.Boolean                  isStaticColorOpt  // 0x2E
METHODS:
END_CLASS

CLASS: GraphicOpt
TYPE:  class
TOKEN: 0x2000084
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param)
  System.IAsyncResult BeginInvoke(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: DynEle
TYPE:  struct
TOKEN: 0x2000085
FIELDS:
  public            System.String                   groupId  // 0x10
  public            UnityEngine.UI.Graphic          graphic  // 0x18
  public            System.Boolean                  useStaticColor  // 0x20
METHODS:
END_CLASS

CLASS: LayoutType
TYPE:  struct
TOKEN: 0x2000089
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UICustomLayoutElement.LayoutTypeNone  // 0x0
  public    static  Beyond.UI.UICustomLayoutElement.LayoutTypeLeftToRight  // 0x0
METHODS:
END_CLASS

CLASS: LayoutData
TYPE:  class
TOKEN: 0x200008A
FIELDS:
  public            System.Int32                    verNum  // 0x10
  public            System.Single                   scale  // 0x14
  public            System.Single                   alpha  // 0x18
  public            UnityEngine.Vector2             position  // 0x1C
  public            System.Int32                    layoutType  // 0x24
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UpdateMode
TYPE:  struct
TOKEN: 0x200008D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIDialogText.UpdateModeAuto  // 0x0
  public    static  Beyond.UI.UIDialogText.UpdateModeManual  // 0x0
METHODS:
END_CLASS

CLASS: WrapMode
TYPE:  struct
TOKEN: 0x20000A5
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIGridLayoutNaviWrapper.WrapModeNaviGroup  // 0x0
  public    static  Beyond.UI.UIGridLayoutNaviWrapper.WrapModeScrollRect  // 0x0
  public    static  Beyond.UI.UIGridLayoutNaviWrapper.WrapModeScrollList  // 0x0
  public    static  Beyond.UI.UIGridLayoutNaviWrapper.WrapModeLayoutNaviWrapper  // 0x0
METHODS:
END_CLASS

CLASS: Param
TYPE:  class
TOKEN: 0x20000A7
FIELDS:
  public            System.Single                   maxAngle  // 0x10
  public            UnityEngine.AnimationCurve      valueCurve  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: State
TYPE:  struct
TOKEN: 0x20000B0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIInertiaViewPager.StateIDLE  // 0x0
  public    static  Beyond.UI.UIInertiaViewPager.StateDRAGING  // 0x0
  public    static  Beyond.UI.UIInertiaViewPager.StateINERTIA  // 0x0
  public    static  Beyond.UI.UIInertiaViewPager.StateALIGNING  // 0x0
METHODS:
END_CLASS

CLASS: IScrollHandler
TYPE:  interface
TOKEN: 0x20000B1
FIELDS:
METHODS:
  System.Void OnClear()
  System.Single get_velocity()
  System.Boolean get_isDragging()
  System.Single get_scrollProgress()
  System.Void set_scrollProgress(System.Single value)
  System.Void StopMoving()
END_CLASS

CLASS: CustomScrollHandler
TYPE:  class
TOKEN: 0x20000B2
FIELDS:
  private           System.Boolean                  m_isScrolling  // 0x10
  private           Beyond.UI.UIScrollRect          m_scrollRect  // 0x18
METHODS:
  System.Void .ctor(Beyond.UI.UIScrollRect scrollRect)
  System.Void OnClear()
  System.Single get_velocity()
  System.Single get_scrollProgress()
  System.Void set_scrollProgress(System.Single value)
  System.Boolean get_isDragging()
  System.Void StopMoving()
  System.Void _OnScrollBegin(UnityEngine.Vector2 delta)
  System.Void _OnScrollEnd(UnityEngine.Vector2 delta)
END_CLASS

CLASS: EmptyScrollHandler
TYPE:  struct
TOKEN: 0x20000B3
FIELDS:
METHODS:
  System.Single get_velocity()
  System.Boolean get_isDragging()
  System.Single get_scrollProgress()
  System.Void set_scrollProgress(System.Single value)
  System.Void StopMoving()
  System.Void OnClear()
END_CLASS

CLASS: FlingToNext
TYPE:  struct
TOKEN: 0x20000B4
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Single                   minSpd  // 0x14
  public            System.Single                   maxSpd  // 0x18
METHODS:
END_CLASS

CLASS: ScrollOptions
TYPE:  struct
TOKEN: 0x20000B5
FIELDS:
  public            Beyond.UI.UIInertiaViewPager.FlingToNextflingToNext  // 0x10
METHODS:
END_CLASS

CLASS: DragContext
TYPE:  class
TOKEN: 0x20000B6
FIELDS:
  public            System.Single                   startPos  // 0x10
METHODS:
  System.Void BeginDrag(Beyond.UI.UIInertiaViewPager pager)
  Beyond.UI.UIInertiaViewPager.State EndDrag(Beyond.UI.UIInertiaViewPager pager)
  System.Boolean _TryFlingToNext(Beyond.UI.UIInertiaViewPager pager)
  System.Void .ctor()
END_CLASS

CLASS: BlockerDir
TYPE:  struct
TOKEN: 0x20000B7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIInertiaViewPager.BlockerDirUPWARD  // 0x0
  public    static  Beyond.UI.UIInertiaViewPager.BlockerDirDOWNNWARD  // 0x0
  public    static  Beyond.UI.UIInertiaViewPager.BlockerDirBOTH  // 0x0
METHODS:
END_CLASS

CLASS: InertiaBlocker
TYPE:  struct
TOKEN: 0x20000B8
FIELDS:
  public            Beyond.UI.UIInertiaViewPager.BlockerDirdir  // 0x10
  public            System.Int32                    index  // 0x14
METHODS:
  System.Boolean IsDirMatch(System.Single vec)
END_CLASS

CLASS: BlockerManager
TYPE:  class
TOKEN: 0x20000B9
FIELDS:
  private   static  System.Single                   INERTIA_BIAS  // 0x0
  private           System.Collections.Generic.List<Beyond.UI.UIInertiaViewPager.InertiaBlocker>m_inertiaBlockers  // 0x10
  private           System.Single                   m_lastIndex  // 0x18
  private           System.Boolean                  <isInertiaing>k__BackingField  // 0x1C
METHODS:
  System.Boolean get_isInertiaing()
  System.Void set_isInertiaing(System.Boolean value)
  System.Void Init(System.Int32 pageCount, System.Collections.Generic.List<System.Int32> blockFrames)
  System.Void StartInertia(System.Single fromIndex)
  System.Boolean HitInertiaBlock(System.Single curIndex, System.Single& preferTo)
  System.Void .ctor()
END_CLASS

CLASS: Timing
TYPE:  struct
TOKEN: 0x20000BB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIInertiaViewPager.ScrollEffectConfig.TimingHALF_VALUE  // 0x0
  public    static  Beyond.UI.UIInertiaViewPager.ScrollEffectConfig.TimingFULL_VALUE  // 0x0
METHODS:
END_CLASS

CLASS: ScrollEffectConfig
TYPE:  struct
TOKEN: 0x20000BA
FIELDS:
  public            System.Action                   onScrollToItem  // 0x10
  public            System.Action                   onAlignedToItem  // 0x18
  public            System.Single                   minScrollInterval  // 0x20
  public            Beyond.UI.UIInertiaViewPager.ScrollEffectConfig.Timingtiming  // 0x24
METHODS:
  System.Boolean IsEmpty()
END_CLASS

CLASS: ScrollEffectTrigger
TYPE:  class
TOKEN: 0x20000BC
FIELDS:
  private   static  System.Single                   DFT_MIN_INTERVAL  // 0x0
  private           System.Boolean                  m_isValid  // 0x10
  private           Beyond.UI.UIInertiaViewPager.ScrollEffectConfigm_config  // 0x18
  private           System.Int32                    m_lastFocusIndex  // 0x30
  private           System.Single                   m_curTime  // 0x34
  private           System.Single                   m_lastScrollTime  // 0x38
  private           System.Boolean                  m_hasScrolled  // 0x3C
METHODS:
  System.Void .ctor(Beyond.UI.UIInertiaViewPager.ScrollEffectConfig config)
  System.Void NotifyScrolling(System.Single curIndex, System.Single deltaTime)
  System.Void MarkHasScrolled()
  System.Void NotifyAlignFinish()
  System.Void Reset(System.Int32 curIndex)
END_CLASS

CLASS: IAction
TYPE:  interface
TOKEN: 0x20000C1
FIELDS:
METHODS:
  System.Void DoAction()
END_CLASS

CLASS: GetCellSizeMode
TYPE:  struct
TOKEN: 0x20000C6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UINonUnifiedScrollList.GetCellSizeModeByGetCellSizeFunc  // 0x0
  public    static  Beyond.UI.UINonUnifiedScrollList.GetCellSizeModeByLayoutGroup  // 0x0
  public    static  Beyond.UI.UINonUnifiedScrollList.GetCellSizeModeGetAfterCellCreated  // 0x0
METHODS:
END_CLASS

CLASS: Cell
TYPE:  class
TOKEN: 0x20000D0
FIELDS:
  public            UnityEngine.GameObject          gameObject  // 0x10
  public            UnityEngine.RectTransform       rectTransform  // 0x18
  public            UnityEngine.GameObject          realGameObject  // 0x20
METHODS:
  System.Void SetSelect(System.Boolean select)
  System.Void .ctor()
END_CLASS

CLASS: AutoLayoutWhenFewType
TYPE:  struct
TOKEN: 0x20000D4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIScrollList.AutoLayoutWhenFewTypeCenter  // 0x0
  public    static  Beyond.UI.UIScrollList.AutoLayoutWhenFewTypeLeftOrTop  // 0x0
  public    static  Beyond.UI.UIScrollList.AutoLayoutWhenFewTypeRightOrBottom  // 0x0
METHODS:
END_CLASS

CLASS: Cell
TYPE:  class
TOKEN: 0x20000D5
FIELDS:
  public            UnityEngine.GameObject          gameObject  // 0x10
  public            UnityEngine.RectTransform       rectTransform  // 0x18
  public            Beyond.UI.UIAnimationWrapper    animationWrapper  // 0x20
  public            Beyond.UI.IUIFoldoutComp        UIFoldoutComp  // 0x28
  public            System.Boolean                  canCache  // 0x30
  public            UnityEngine.GameObject          realGameObject  // 0x38
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MoveTipsType
TYPE:  struct
TOKEN: 0x20000D6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIScrollList.MoveTipsTypeNone  // 0x0
  public    static  Beyond.UI.UIScrollList.MoveTipsTypeHigher  // 0x0
  public    static  Beyond.UI.UIScrollList.MoveTipsTypeLower  // 0x0
  public    static  Beyond.UI.UIScrollList.MoveTipsTypeBoth  // 0x0
METHODS:
END_CLASS

CLASS: Padding
TYPE:  struct
TOKEN: 0x20000D7
FIELDS:
  public            System.Single                   top  // 0x10
  public            System.Single                   left  // 0x14
  public            System.Single                   right  // 0x18
  public            System.Single                   bottom  // 0x1C
METHODS:
END_CLASS

CLASS: ScrollAlignType
TYPE:  struct
TOKEN: 0x20000D8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIScrollList.ScrollAlignTypeCenter  // 0x0
  public    static  Beyond.UI.UIScrollList.ScrollAlignTypeTop  // 0x0
  public    static  Beyond.UI.UIScrollList.ScrollAlignTypeBottom  // 0x0
METHODS:
END_CLASS

CLASS: IScrollListNaviWrapper
TYPE:  interface
TOKEN: 0x20000D9
FIELDS:
METHODS:
  System.Boolean TryWrapNavigate(UnityEngine.UI.NaviDirection dir)
END_CLASS

CLASS: MoveTipsType
TYPE:  struct
TOKEN: 0x20000DC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIScrollRect.MoveTipsTypeNone  // 0x0
  public    static  Beyond.UI.UIScrollRect.MoveTipsTypeHigher  // 0x0
  public    static  Beyond.UI.UIScrollRect.MoveTipsTypeLower  // 0x0
  public    static  Beyond.UI.UIScrollRect.MoveTipsTypeBoth  // 0x0
METHODS:
END_CLASS

CLASS: ERedDotState
TYPE:  struct
TOKEN: 0x20000DF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotStateDISABLED  // 0x0
  public    static  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotStateNEW  // 0x0
  public    static  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotStateNORMAL  // 0x0
METHODS:
END_CLASS

CLASS: ERedDotDir
TYPE:  struct
TOKEN: 0x20000E0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDirUP  // 0x0
  public    static  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDirRIGHT  // 0x0
  public    static  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDirDOWN  // 0x0
  public    static  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDirLEFT  // 0x0
METHODS:
END_CLASS

CLASS: RedDotInfo
TYPE:  class
TOKEN: 0x20000E1
FIELDS:
  public    readonly UnityEngine.GameObject          redDotRoot  // 0x10
  public    readonly UnityEngine.GameObject          redDotNormal  // 0x18
  public    readonly UnityEngine.GameObject          redDotNew  // 0x20
METHODS:
  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState get_state()
  UnityEngine.Vector2 get_normalPos()
  UnityEngine.Vector2 get_newPos()
  UnityEngine.Rect get_normalRect()
  UnityEngine.Rect get_newRect()
  System.Void .ctor(UnityEngine.GameObject redDotRoot, UnityEngine.GameObject redDotNormal, UnityEngine.GameObject redDotNew)
END_CLASS

CLASS: ScrollMode
TYPE:  struct
TOKEN: 0x20000E3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIScrollText.ScrollModeMesh  // 0x0
  public    static  Beyond.UI.UIScrollText.ScrollModeAnchoredPosition  // 0x0
METHODS:
END_CLASS

CLASS: ScrollState
TYPE:  struct
TOKEN: 0x20000E4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIScrollText.ScrollStateScrolling  // 0x0
  public    static  Beyond.UI.UIScrollText.ScrollStateIdle  // 0x0
  public    static  Beyond.UI.UIScrollText.ScrollStateFadingOut  // 0x0
  public    static  Beyond.UI.UIScrollText.ScrollStateFadingIn  // 0x0
METHODS:
END_CLASS

CLASS: IAlphaHandler
TYPE:  interface
TOKEN: 0x20000E5
FIELDS:
METHODS:
  System.Void HandleAlpha(System.Single alpha)
END_CLASS

CLASS: CanvasGroupHandler
TYPE:  class
TOKEN: 0x20000E6
FIELDS:
  private           UnityEngine.CanvasGroup         m_canvasGroup  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.CanvasGroup canvasGroup)
  System.Void HandleAlpha(System.Single alpha)
END_CLASS

CLASS: IScrollHandler
TYPE:  interface
TOKEN: 0x20000E7
FIELDS:
METHODS:
  System.Void ApplyScroll(System.Single scrollOffset)
  System.Void ResetScroll()
  System.Void UpdateScrollStatus(System.Boolean isScroll)
END_CLASS

CLASS: PositionScrollHandler
TYPE:  class
TOKEN: 0x20000E8
FIELDS:
  private           Beyond.UI.UIScrollText          m_closure  // 0x10
METHODS:
  System.Void .ctor(Beyond.UI.UIScrollText scrollText)
  System.Void ApplyScroll(System.Single scrollOffset)
  System.Void ResetScroll()
  System.Void UpdateScrollStatus(System.Boolean isScroll)
END_CLASS

CLASS: MeshScrollHandler
TYPE:  class
TOKEN: 0x20000E9
FIELDS:
  private           Beyond.UI.UIScrollText          m_closure  // 0x10
METHODS:
  System.Void .ctor(Beyond.UI.UIScrollText uiScrollText)
  System.Void ApplyScroll(System.Single scrollOffset)
  System.Void ResetScroll()
  System.Void UpdateScrollStatus(System.Boolean isScroll)
  System.Void _ApplyScroll(System.Single scrollOffset)
  System.Void _UpdateMeshClipping(TMPro.TMP_TextInfo textInfo)
END_CLASS

CLASS: FocusBlockMessageData
TYPE:  struct
TOKEN: 0x20000EB
FIELDS:
  public            System.Int32                    panelId  // 0x10
  public            System.Boolean                  isGroup  // 0x14
  public            System.Int32                    id  // 0x18
  public            UnityEngine.RectTransform       rectTransform  // 0x20
  public            System.Boolean                  noHighlight  // 0x28
  public            System.Boolean                  useNormalFrame  // 0x29
  public            System.Boolean                  useDarkFrame  // 0x2A
  public            System.Int32                    panelSortingOrder  // 0x2C
METHODS:
END_CLASS

CLASS: StateInfo
TYPE:  class
TOKEN: 0x20000F2
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Collections.Generic.List<UnityEngine.GameObject>activeObjects  // 0x18
METHODS:
  System.String ToString()
  System.Void .ctor()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: SlicedSpriteParams
TYPE:  struct
TOKEN: 0x20000F6
FIELDS:
  public            System.Int32                    slicedEnabled  // 0x10
  public            UnityEngine.Vector2             inner_PosMin  // 0x14
  public            UnityEngine.Vector2             inner_PosMax  // 0x1C
  public            UnityEngine.Vector2             inner_UVMin  // 0x24
  public            UnityEngine.Vector2             inner_UVMax  // 0x2C
METHODS:
  System.Void .ctor(System.Int32 slicedEnabled, UnityEngine.Vector2 inner_PosMin, UnityEngine.Vector2 inner_PosMax, UnityEngine.Vector2 inner_UVMin, UnityEngine.Vector2 inner_UVMax)
END_CLASS

CLASS: UIType
TYPE:  struct
TOKEN: 0x20000F8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UISoftMaskable.UIType Default  // 0x0
  public    static  Beyond.UI.UISoftMaskable.UIType Text  // 0x0
  public    static  Beyond.UI.UISoftMaskable.UIType UIVFX  // 0x0
METHODS:
END_CLASS

CLASS: TestLine
TYPE:  struct
TOKEN: 0x20000F9
FIELDS:
  public            UnityEngine.UIVertex            v0  // 0x10
  public            UnityEngine.UIVertex            v1  // 0x7C
  public            UnityEngine.Vector2             p0  // 0xE8
  public            UnityEngine.Vector2             p1  // 0xF0
  public            UnityEngine.Vector2             t0  // 0xF8
  public            UnityEngine.Vector2             t1  // 0x100
  public            UnityEngine.Vector2             dir  // 0x108
  public            UnityEngine.Vector2             normal  // 0x110
METHODS:
END_CLASS

CLASS: RenderType
TYPE:  struct
TOKEN: 0x20000FB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UISortingOrder.RenderTypeEffect  // 0x0
  public    static  Beyond.UI.UISortingOrder.RenderTypeUI  // 0x0
METHODS:
END_CLASS

CLASS: StateConfig
TYPE:  class
TOKEN: 0x20000FE
FIELDS:
  public            Beyond.UI.UIState.UIStateControllerstateController  // 0x10
  public            System.String                   stateName  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: StyleConfig
TYPE:  class
TOKEN: 0x20000FF
FIELDS:
  public            Beyond.UI.UIStyleInputValidTypeMaskinputValidType  // 0x10
  public            System.Collections.Generic.List<Beyond.UI.UIStyleByState.StateConfig>stateConfigs  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ScrollListLayoutInfo
TYPE:  class
TOKEN: 0x2000108
FIELDS:
  public            UnityEngine.UI.VerticalLayoutGrouplayoutGroup  // 0x10
  public            UnityEngine.RectTransform       layoutRectTransform  // 0x18
  public            UnityEngine.UI.LayoutElement    cell  // 0x20
METHODS:
  System.Single get_cellHeight()
  System.Void .ctor()
END_CLASS

CLASS: MotionLevel
TYPE:  struct
TOKEN: 0x200010F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.MobileMotionManager.MotionLevelNONE  // 0x0
  public    static  Beyond.UI.MobileMotionManager.MotionLevelLOW  // 0x0
  public    static  Beyond.UI.MobileMotionManager.MotionLevelMEDIUM  // 0x0
  public    static  Beyond.UI.MobileMotionManager.MotionLevelHIGH  // 0x0
METHODS:
END_CLASS

CLASS: FontAssetRef
TYPE:  class
TOKEN: 0x2000112
FIELDS:
  public            Beyond.I18n.I18nFontSearchData.FontAssetInfofontAssetInfo  // 0x10
  private           System.Collections.Generic.HashSet<TMPro.TMP_Text>m_refTexts  // 0x18
  private           Beyond.Resource.FAssetProxyHandlem_assetHandle  // 0x20
  private           TMPro.TMP_FontAsset             m_fontAsset  // 0x38
METHODS:
  TMPro.TMP_FontAsset GetFontAsset(TMPro.TMP_Text refText)
  System.Void RemoveRefText(TMPro.TMP_Text refText)
  System.Void Dispose()
  System.Void .ctor()
END_CLASS

CLASS: FLerpByTime
TYPE:  struct
TOKEN: 0x2000114
FIELDS:
  public    static  Beyond.UI.TweenUtils.FLerpByTimeEMPTY  // 0x0
  private           System.Boolean                  <isEmpty>k__BackingField  // 0x10
  private           Beyond.FScaledStopwatch         m_timer  // 0x18
  public            System.Single                   startValue  // 0x30
  public            System.Single                   endValue  // 0x34
  public            System.Single                   duration  // 0x38
METHODS:
  System.Boolean get_isEmpty()
  System.Void set_isEmpty(System.Boolean value)
  System.Void Start(Beyond.ITickOwner timeScaleProvider)
  System.Single GetValue(System.Boolean& isTweenFinished)
  System.Void .cctor()
END_CLASS

CLASS: FOptions
TYPE:  struct
TOKEN: 0x2000118
FIELDS:
  public            TComp                           cellTemplate  // 0x0
  public            UnityEngine.Transform           parent  // 0x0
  public            System.Action<TComp>            onItemCreated  // 0x0
METHODS:
END_CLASS

CLASS: ItemWrapper
TYPE:  class
TOKEN: 0x2000119
FIELDS:
  public            TComp                           comp  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Options
TYPE:  struct
TOKEN: 0x200011E
FIELDS:
  private           System.Action                   <onShown>k__BackingField  // 0x10
  private           System.Action                   <onHiden>k__BackingField  // 0x18
METHODS:
  System.Action get_onShown()
  System.Void set_onShown(System.Action value)
  System.Action get_onHiden()
  System.Void set_onHiden(System.Action value)
END_CLASS

CLASS: TweenContext
TYPE:  struct
TOKEN: 0x200011F
FIELDS:
  public            System.Single                   lastStopPos  // 0x10
METHODS:
  System.Boolean IsInterapted()
  System.Void OnReset()
  System.Void OnTweenStop(Beyond.UI.UISwitchTween.ITweenProgress tweenProgress)
END_CLASS

CLASS: ITweenHandler
TYPE:  interface
TOKEN: 0x2000120
FIELDS:
METHODS:
  Beyond.UI.UISwitchTween.ITweenHandler SetAutoKill(System.Boolean autoKill)
  Beyond.UI.UISwitchTween.ITweenHandler OnComplete(DG.Tweening.TweenCallback callback)
  System.Boolean IsPlaying()
  System.Void KillIfNecessary()
END_CLASS

CLASS: ITweenProgress
TYPE:  interface
TOKEN: 0x2000121
FIELDS:
METHODS:
  System.Single GetCurrPos()
END_CLASS

CLASS: TweenWrapper
TYPE:  class
TOKEN: 0x2000122
FIELDS:
  private           DG.Tweening.Tween               m_tween  // 0x10
METHODS:
  System.Void .ctor(DG.Tweening.Tween tween)
  System.Boolean IsActive()
  System.Boolean IsPlaying()
  System.Void KillIfNecessary()
  Beyond.UI.UISwitchTween.ITweenHandler OnComplete(DG.Tweening.TweenCallback callback)
  Beyond.UI.UISwitchTween.ITweenHandler SetAutoKill(System.Boolean autoKill)
END_CLASS

CLASS: Durations
TYPE:  struct
TOKEN: 0x2000125
FIELDS:
  public            System.Single                   show  // 0x10
  public            System.Single                   showDelay  // 0x14
  public            System.Single                   hide  // 0x18
  public            System.Single                   hideDelay  // 0x1C
METHODS:
  System.Single GetShowDuration(System.Single defaultDuration)
  System.Single GetHideDuration(System.Single defaultDuration)
END_CLASS

CLASS: Builder
TYPE:  struct
TOKEN: 0x2000126
FIELDS:
  public            UnityEngine.CanvasGroup         alphaHandler  // 0x10
  public            System.Boolean                  useTimeScale  // 0x18
  public            System.Boolean                  dontDisableGameObject  // 0x19
  public            System.Boolean                  controlBlockRaycast  // 0x1A
  public            System.Single                   duration  // 0x1C
  public            Beyond.UI.FadeSwitchTween.DurationscomplexDuration  // 0x20
METHODS:
  Beyond.UI.FadeSwitchTween Build()
END_CLASS

CLASS: TweenHandler
TYPE:  class
TOKEN: 0x2000128
FIELDS:
  private           DG.Tweening.Tween               m_alphaTweener  // 0x10
  private           DG.Tweening.Tween               m_posTweener  // 0x18
METHODS:
  System.Void .ctor(DG.Tweening.Tween alpha, DG.Tweening.Tween pos)
  System.Boolean IsPlaying()
  System.Void KillIfNecessary()
  Beyond.UI.UISwitchTween.ITweenHandler OnComplete(DG.Tweening.TweenCallback callback)
  Beyond.UI.UISwitchTween.ITweenHandler SetAutoKill(System.Boolean autoKill)
END_CLASS

CLASS: UIAtlasProcessStatus
TYPE:  struct
TOKEN: 0x200012A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessStatusInvalid  // 0x0
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessStatusInsertWaiting  // 0x0
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessStatusInsertDone  // 0x0
METHODS:
END_CLASS

CLASS: UIAtlasProcessFailureCause
TYPE:  struct
TOKEN: 0x200012B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseNoFailure  // 0x0
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseImageHasNullMainTexture  // 0x0
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseImageHasNullSprite  // 0x0
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseTextureWidthExceedLimit  // 0x0
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseTextureHeightExceedLimit  // 0x0
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseTextureASTCNotSupportedUnderEditor  // 0x0
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureLevelInfo  // 0x0
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseSpriteHasNonQuadMesh  // 0x0
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseSpriteHasAssociatedAlphaSplitTexture  // 0x0
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureLevelWarning  // 0x0
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseAtlasTextureHasNoSpaceLeft  // 0x0
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseSpriteRectHasNoPadding  // 0x0
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureLevelError  // 0x0
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseTextureFormatNotCompatible  // 0x0
  public    static  Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCauseFailureCauseTextureSizeNotAlignedForCopyTexture  // 0x0
METHODS:
END_CLASS

CLASS: UIAtlasHandle
TYPE:  struct
TOKEN: 0x200012C
FIELDS:
  public            Beyond.UI.UIAtlasManager.UIAtlasProcessStatusstatus  // 0x10
  public            Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCausefailureCause  // 0x14
  public            System.Int32                    panelLevel  // 0x18
  public            System.Int32                    atlasIndex  // 0x1C
  public            UnityEngine.RectInt             atlasRect  // 0x20
  public            System.Int32                    textureId  // 0x30
METHODS:
  System.Void .ctor(Beyond.UI.UIAtlasManager.UIAtlasProcessStatus status, Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause failureCause, System.Int32 panelLevel, System.Int32 atlasIndex, UnityEngine.RectInt atlasRect, System.Int32 textureId)
  System.Boolean IsValid()
  Beyond.UI.UIAtlasManager.UIAtlasHandle CreateInvalidHandle(Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause cause)
END_CLASS

CLASS: TextureRefHandle
TYPE:  struct
TOKEN: 0x200012E
FIELDS:
  public            System.Int32                    refCount  // 0x10
  public            UnityEngine.RectInt             rect  // 0x14
METHODS:
  System.Void .ctor(System.Int32 refCount, UnityEngine.RectInt rect)
END_CLASS

CLASS: UIAtlasPage
TYPE:  class
TOKEN: 0x200012D
FIELDS:
  private   readonly UnityEngine.Texture2D           <pageTexture>k__BackingField  // 0x10
  private   readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIAtlasManager.UIAtlasPage.TextureRefHandle><textureRefDict>k__BackingField  // 0x18
  private   readonly HG.Rendering.Runtime.AtlasMaxRect<rectBinPack>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.Int32 panelDepth, System.Int32 index, UnityEngine.Experimental.Rendering.GraphicsFormat atlasFormat)
  System.Int32 get_maxFreeRectWidth()
  System.Int32 get_maxFreeRectHeight()
  UnityEngine.Texture2D get_pageTexture()
  System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIAtlasManager.UIAtlasPage.TextureRefHandle> get_textureRefDict()
  HG.Rendering.Runtime.AtlasMaxRect get_rectBinPack()
  UnityEngine.RectInt InsertRect(System.Int32 width, System.Int32 height)
  System.Void CopyIntoAtlas(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture texture, UnityEngine.RectInt& rect)
  System.Void InsertRects(System.Collections.Generic.List<UnityEngine.RectInt> rects, System.Collections.Generic.List<UnityEngine.RectInt> dst)
  System.Void FreeRect(UnityEngine.RectInt& rect)
  System.Void FreeRects(System.Collections.Generic.List<UnityEngine.RectInt>& rects)
END_CLASS

CLASS: ShaderIDs
TYPE:  class
TOKEN: 0x2000153
FIELDS:
  private   static readonly System.Int32                    CANVAS_OBJECT_TO_WORLD_MATRIX  // 0x0
  private   static readonly System.Int32                    VAT_TEX  // 0x4
  private   static readonly System.Int32                    MAIN_TEX  // 0x8
  private   static readonly System.Int32                    SPRITE_TEX  // 0xC
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: BufferInternalNode
TYPE:  struct
TOKEN: 0x2000156
FIELDS:
  public            Beyond.UI.GPUI.GPUIHandle       handle  // 0x10
  public            System.Int32                    startIndex  // 0x18
  public            System.Int32                    previousLength  // 0x1C
  public            System.Int32                    sortingOrder  // 0x20
METHODS:
END_CLASS

CLASS: CharOffsetData
TYPE:  struct
TOKEN: 0x200015C
FIELDS:
  public            System.Single                   scale  // 0x0
  public            System.Single                   xAdvance  // 0x0
  public            System.Single                   xOffset  // 0x0
  public            System.Single                   yOffset  // 0x0
  public            System.Int32                    prefabIndex  // 0x0
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=24
TYPE:  struct
TOKEN: 0x200015E
FIELDS:
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.UI.UIScrollCellCircleEffect
TYPE:  class
TOKEN: 0x200000B
EXTENDS: TickableUIMono
FIELDS:
  private           UnityEngine.Transform           _target  // 0x68
  private           System.Single                   _radius  // 0x70
  private           UnityEngine.Transform           _effectNode  // 0x78
  private           System.Boolean                  _faceToUICamera  // 0x80
  private           System.Boolean                  _alwaysFaceToCamera  // 0x81
  private           UnityEngine.Vector3             m_lastPosition  // 0x84
  private           Beyond.UI.LuaPanel              m_panel  // 0x90
  private           UnityEngine.Transform           <lookAtCamera>k__BackingField  // 0x98
  private           System.Boolean                  m_left  // 0xA0
METHODS:
  Beyond.TickType get_tickOption()
  Beyond.UI.LuaPanel get_panel()
  UnityEngine.Transform get_lookAtCamera()
  System.Void set_lookAtCamera(UnityEngine.Transform value)
  System.Void _InitState()
  System.Void _UpdatePos()
  System.Void _UpdateLookAtCamera()
  System.Void SetLookAtCamera(UnityEngine.Transform faceCamera, System.Boolean update)
  System.Void OnEnable()
  System.Void Start()
  System.Void Tick(System.Single deltaTime)
  System.Void ForceUpdate()
  System.Void LateTick(System.Single deltaTime)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.Gameplay.UI.UIScrollCellSlantEffect
TYPE:  class
TOKEN: 0x200000C
EXTENDS: TickableUIMono
FIELDS:
  private           System.Single                   _topY  // 0x68
  private           System.Single                   _bottomY  // 0x6C
  private           System.Single                   _leftX  // 0x70
  private           System.Single                   _maxWidth  // 0x74
  private           UnityEngine.AnimationCurve      _curve  // 0x78
  private           UnityEngine.Transform[]         _cells  // 0x80
METHODS:
  Beyond.TickType get_tickOption()
  System.Void Tick(System.Single deltaTime)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.PoolCore.ListPoolInitializer_UI_Beyond
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private   static  System.Boolean                  s_initialized  // 0x0
METHODS:
  System.Void InitializeAtRuntime()
  System.Void Initialize()
END_CLASS

CLASS: Beyond.Scripts.UI.Tools.UIGridLayoutElement
TYPE:  class
TOKEN: 0x200000A
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.UI.GridLayoutGroup  m_gridLayoutGroup  // 0x18
METHODS:
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Single get_minWidth()
  System.Single get_preferredWidth()
  System.Single get_flexibleWidth()
  System.Single get_minHeight()
  System.Single get_preferredHeight()
  System.Single get_flexibleHeight()
  System.Int32 get_layoutPriority()
  System.Single _GetPreferredSize(System.Boolean widthOrHeight)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000006
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000007
EXTENDS: Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000008
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000009
EXTENDS: Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIText
TYPE:  class
TOKEN: 0x200000D
EXTENDS: TextMeshProUGUI
FIELDS:
  public            Beyond.UI.UIText.RichTextStyleSeqrichTextStyleSeq  // 0xBC8
  private           System.Boolean                  m_textHasHyperlink  // 0xBCC
  private   static readonly System.Text.RegularExpressions.RegexRICH_TEXT_REGEX  // 0x0
  private   static readonly System.Text.RegularExpressions.RegexHYPERLINK_TEXT_REGEX  // 0x8
  private   static readonly System.Text.RegularExpressions.RegexPHONETIC_REGEX  // 0x10
  private           System.Boolean                  _loadByCode  // 0xBCD
  private           System.String                   _textId  // 0xBD0
  private           System.Boolean                  _devOnly  // 0xBD8
  private           System.Int32                    _externalStaticWidth  // 0xBDC
  private           System.Int32                    _externalStaticHeight  // 0xBE0
  private           System.Boolean                  m_firstSetByCode  // 0xBE4
  private   static readonly System.Collections.Generic.HashSet<Beyond.GEnums.EnvLang>s_forceLeftAlignLanguage  // 0x18
  private           System.Collections.Generic.List<Beyond.UI.UIText.RichTextInfo>m_richTextInfos  // 0xBE8
  private           Beyond.TickFunction             m_updateFunction  // 0xBF0
  private           Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFuncm_processRichTextEntryFunc  // 0xBF8
  public            UnityEngine.Events.UnityEvent<System.String>onClickLink  // 0xC00
  public            UnityEngine.Events.UnityEvent<System.String,System.Boolean>onHoverLinkChange  // 0xC08
  private           System.Boolean                  m_isPointerInside  // 0xC10
  private           System.String                   m_curHoverLinkId  // 0xC18
  private           System.Collections.Generic.List<System.String>m_linkList  // 0xC20
  private           System.Boolean                  m_linkShrunk  // 0xC28
  private           System.String                   _hyperlinkUITextGroupId  // 0xC30
  private           System.Int32                    _hyperlinkUITextOrder  // 0xC38
  private           Beyond.UI.UIText.HyperlinkUITextWrapm_hyperlinkUITextWrap  // 0xC40
  private           Beyond.UI.LuaPanel              m_panel  // 0xC48
  public            System.Int32                    sourceCNFontId  // 0xC50
  private           TMPro.TMP_FontAsset             m_i18nFontAsset  // 0xC58
  private   static  System.Text.StringBuilder       s_stringBuilder  // 0x20
  private   readonly System.Collections.Generic.Queue<UnityEngine.GameObject>m_inlineImagePool  // 0xC60
  private   readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIText.ImageGOInfo>m_indexToImageGo  // 0xC68
  private   static  System.String                   INLINE_IMAGE_FOLDER_PATH  // 0x0
  private   static  System.String                   KEY_HINT_ICON_COMMON_FOLDER  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.String,Beyond.Resource.FAssetProxyHandle>m_imageCache  // 0xC70
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Boolean>m_delayedActiveChangeImageGOIndexes  // 0xC78
METHODS:
  System.Void SetAndResolveTextStyle(System.String targetText)
  System.String GetPhoneticText(Beyond.GEnums.PhoneticType phoneticType, System.String id)
  System.Void SetPhoneticText(Beyond.GEnums.PhoneticType phoneticType, System.String id)
  System.String _ResolveTextStyle(System.String text, System.Int32 richSeqIndex, System.Boolean& hasLink)
  System.String get_textId()
  System.Void OnEnvLangChanged(Beyond.GEnums.EnvLang lang)
  System.String get_text()
  System.Void set_text(System.String value)
  System.Void _CreateUpdateFunction()
  System.Void _ReleaseUpdateFunction()
  System.Void ClearMesh()
  System.Void RefreshPopulateText()
  UnityEngine.Material LoadMaterial(System.String materialName)
  System.Void OnDestroy()
  System.Void Awake()
  TMPro.TMP_FontAsset GetFontAsset()
  System.Void _GenerateRuntimeText()
  System.Void _ProcessRichTextInfo()
  System.Void _OnPreRenderText(TMPro.TMP_TextInfo textInfo)
  Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc get_processRichTextEntryFunc()
  Beyond.UI.UIText.RichTextInfo _ProcessRichTextEntry(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam mainParam, System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> subParams, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder)
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void Start()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void _UpdateTick(System.Single deltaTime)
  System.Void ShrinkLinkTags()
  System.Boolean TryGetLinkId(UnityEngine.Vector3 position, System.String& linkId)
  System.Boolean TryGetLinkId(System.Int32 linkIndex, System.String& linkId)
  System.Boolean TryGetOriginalLinkId(System.String linkId, System.String& originalLinkId)
  System.Boolean TryGetCharacterStartPosAndHeight(System.Int32 charIndex, UnityEngine.Vector3& worldPos, System.Single& charHeight)
  System.Boolean TryGetCharacterEndPosAndHeight(System.Int32 charIndex, UnityEngine.Vector3& worldPos, System.Single& charHeight)
  System.Void CombineStringWithLanguageSpilt(T1 t1, T2 t2)
  System.Void CombineStringWithLanguageSpilt(System.String t1, System.String t2)
  System.Void SetHyperlinkUITextGroup(System.String groupId, System.Int32 order)
  System.Boolean IsHyperlinkUITextGroupDisplayable(System.String groupId)
  System.Collections.Generic.List<Beyond.UI.UIText> GetGroupDisplayableHyperlinkUIText(System.String groupId)
  Beyond.UI.LuaPanel get_panel()
  System.Void ClearComponent()
  System.Void UpdateI18NFontAsset()
  TMPro.TMP_FontAsset get_m_fontAsset()
  System.Void set_m_fontAsset(TMPro.TMP_FontAsset value)
  UnityEngine.Material get_fontSharedMaterial()
  System.Void set_fontSharedMaterial(UnityEngine.Material value)
  System.Void _RefreshMatTexture()
  System.Void SetSharedMaterial(UnityEngine.Material mat)
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void OnAfterDeserialize()
  TMPro.TMP_SubMeshUI AddSubTextObject(TMPro.TextMeshProUGUI textComponent, TMPro.MaterialReference materialReference)
  System.String LocalStringCombineFormat(System.Int32 count)
  UnityEngine.Sprite GetOrLoadSprite(System.String path)
  System.Void DisposeInlineImageCache()
  System.Void _ClearInlineImage()
  Beyond.UI.UIText.ImageGOInfo _GetImageGoByIndex(System.Int32 index)
  UnityEngine.GameObject _GetOrCreateImageGO()
  System.Void _ReturnImageGO(UnityEngine.GameObject go)
  System.Collections.IEnumerator _DelayedChangeActiveImageGo()
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_set_text(System.String P0)
  System.Void <>iFixBaseProxy_ClearMesh()
  System.Void <>iFixBaseProxy_RefreshPopulateText()
  UnityEngine.Material <>iFixBaseProxy_LoadMaterial(System.String P0)
  System.Void <>iFixBaseProxy_OnDestroy()
  System.Void <>iFixBaseProxy_Awake()
  System.Void <>iFixBaseProxy_Start()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  TMPro.TMP_FontAsset <>iFixBaseProxy_get_m_fontAsset()
  System.Void <>iFixBaseProxy_set_m_fontAsset(TMPro.TMP_FontAsset P0)
  System.Void <>iFixBaseProxy_set_fontSharedMaterial(UnityEngine.Material P0)
  System.Void <>iFixBaseProxy_SetSharedMaterial(UnityEngine.Material P0)
  TMPro.TMP_SubMeshUI <>iFixBaseProxy_AddSubTextObject(TMPro.TextMeshProUGUI P0, TMPro.MaterialReference P1)
END_CLASS

CLASS: Beyond.UI.UIConst
TYPE:  class
TOKEN: 0x200001E
FIELDS:
  public    static  System.Boolean                  IS_PC_OR_CONSOLE  // 0x0
  public    static  System.Single                   PC_REFERENCE_RESOLUTION_SCALE  // 0x0
  public    static  System.Single                   MOBILE_PAD_DEVICE_REFERENCE_RESOLUTION_SCALE  // 0x0
  public    static readonly UnityEngine.Vector3             OUT_OF_SCREEN_POS  // 0x4
  public    static  System.Single                   STANDARD_HORIZONTAL_RESOLUTION  // 0x0
  public    static  System.Single                   STANDARD_VERTICAL_RESOLUTION  // 0x0
  public    static  System.Int32                    INVALID_FINGER_ID  // 0x0
  public    static  System.Single                   STANDARD_RATIO  // 0x10
  public    static  System.Single                   SCREEN_SPACE_CAMERA_PANEL_DISTANCE  // 0x0
  public    static  System.String                   UI_BLUR_MATERIAL  // 0x0
  public    static  System.String                   CS_POPUP_PANEL_PATH  // 0x0
  public    static  System.String                   NAVIGATION_TARGET_CLICK_NO_HINT_ACTION_ID  // 0x0
  public    static  System.String                   NAVIGATION_TARGET_CLICK_ACTION_ID  // 0x0
  public    static  System.String                   UI_SPRITE_CHAR_HEAD_RECTANGLE  // 0x0
  public    static  System.String                   UI_SPRITE_DIALOG_OPTION_ICON  // 0x0
  public    static  System.String                   SLIDER_STICK_SCROLL_HORI_ACTION_ID  // 0x0
METHODS:
  System.Int32 get_STANDARD_HORIZONTAL_RESOLUTION_INT()
  System.Int32 get_STANDARD_VERTICAL_RESOLUTION_INT()
  System.Single get_CUR_STANDARD_HORIZONTAL_RESOLUTION()
  System.Single get_CUR_STANDARD_VERTICAL_RESOLUTION()
  System.Int32 get_dragThreshold()
  System.Single GetResolutionScale()
  System.Boolean IsPadDevice()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UIModelLoader
TYPE:  class
TOKEN: 0x2000021
FIELDS:
  private           System.Collections.Generic.Dictionary<UnityEngine.GameObject,Beyond.Resource.FAssetProxyHandle>m_instance2AssetHandle  // 0x10
  private           System.Int32                    m_requestCounter  // 0x18
  private           System.Collections.Generic.HashSet<System.Int32>m_requestIds  // 0x20
  private           System.Boolean                  m_disposed  // 0x28
  private   static  System.Collections.Generic.List<MagicaCloth.MagicaBoneCloth>s_magicaBoneCloths  // 0x0
METHODS:
  System.Void .ctor()
  UnityEngine.GameObject LoadModel(System.String modelPath, UnityEngine.Transform parent)
  System.Int32 LoadModelAsync(System.String modelPath, UnityEngine.Transform parent, System.Action<UnityEngine.GameObject> callback)
  System.Void Cancel(System.Int32 requestId)
  System.Void UnloadModel(UnityEngine.GameObject modelGo)
  System.Void _Clear()
  System.Void Dispose()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UIUtils
TYPE:  class
TOKEN: 0x2000023
FIELDS:
  private   static  System.Int32                    MAX_SHARED_INT_STRING  // 0x0
  private   static readonly System.String[]                 s_sharedIntStringPool  // 0x0
  private   static  UnityEngine.Vector3[]           s_worldCorners  // 0x8
METHODS:
  System.String GetSharedIntString(System.Int32 value)
  System.Boolean IsScreenPosInRectTransform(UnityEngine.Vector3 screenPos, UnityEngine.RectTransform rectTransform, UnityEngine.Camera uiCamera)
  System.Boolean IsScreenPosInRectTransform(UnityEngine.Vector2 screenPos, UnityEngine.RectTransform rectTransform, UnityEngine.Camera uiCamera)
  UnityEngine.Bounds CalcBoundOfRectTransform(UnityEngine.RectTransform transform, UnityEngine.RectTransform local)
  System.Boolean TryGetTouch(System.Int32 touchId, UnityEngine.InputSystem.EnhancedTouch.Touch& touch)
  System.Void SetAlpha(UnityEngine.UI.Graphic image, System.Single alpha)
  System.Void SetColorWithoutAlpha(UnityEngine.UI.Graphic image, UnityEngine.Color color)
  System.Void ClearUIComponents(UnityEngine.GameObject gameObject)
  UnityEngine.Rect RectTransformToScreenRect(UnityEngine.RectTransform rectTransform, UnityEngine.Camera uiCamera)
  UnityEngine.Vector3 GetNodeScaleOffset(UnityEngine.RectTransform referenceTransform, UnityEngine.RectTransform selfTransform)
  UnityEngine.Color GetColorByString(System.String strColor)
  System.Void SetMaskRatio(UnityEngine.UI.RectMask2D mask, System.Single r)
  System.Single GetCursorTipOffsetX(System.Single defaultOffset)
  System.Single GetCursorTipOffsetInScreen(System.Single defaultOffsetInScreen)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.ActiveSyncHelper
TYPE:  class
TOKEN: 0x2000024
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.GameObject>_objs  // 0x18
  private           System.Boolean                  _isInverse  // 0x20
METHODS:
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Sync()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.Billboard
TYPE:  class
TOKEN: 0x2000025
EXTENDS: TickableUIMono
FIELDS:
  public            UnityEngine.Camera              sceneCamera  // 0x68
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnEnable()
  System.Void Tick(System.Single deltaTime)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.CinemachineGyroscopeEffect
TYPE:  class
TOKEN: 0x2000026
EXTENDS: CinemachineExtension
FIELDS:
  public            System.Single                   offsetX  // 0x28
  public            System.Single                   offsetY  // 0x2C
METHODS:
  System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.CommonItemToastList
TYPE:  class
TOKEN: 0x2000027
EXTENDS: UIScrollList
FIELDS:
METHODS:
  System.Void ScrollToIndex(System.Int32 index, System.Boolean fastMode, Beyond.UI.UIScrollList.ScrollAlignType alignType, System.Boolean graduallyShowInFastMode)
  System.Void AdjustContainerPos(System.Int32 index, System.Boolean fastMode)
  UnityEngine.Vector2 _GetUnConstraintTargetPos(System.Int32 index)
  System.Void .ctor()
  UnityEngine.Vector2 <AdjustContainerPos>b__1_0()
  System.Void <AdjustContainerPos>b__1_1(UnityEngine.Vector2 x)
END_CLASS

CLASS: Beyond.UI.ControllerSideMenuItemList
TYPE:  class
TOKEN: 0x2000028
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Collections.Generic.List<Beyond.UI.ControllerSideMenuItemList.MeunItemInfo>menuItems  // 0x18
  public            UnityEngine.Sprite              icon  // 0x20
  public            System.String                   title  // 0x28
  public            UnityEngine.RectTransform       contentPosTrans  // 0x30
  public            System.Boolean                  isFullScreen  // 0x38
  private   static readonly System.Collections.Generic.HashSet<System.String>s_forceValidItemList  // 0x0
METHODS:
  System.Void ToggleItemForceValid(System.String itemName, System.Boolean forceValid)
  System.Boolean IsItemForceValid(System.String itemName)
  System.Void ClearForceValidItemList()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.CustomNotchAdapt
TYPE:  class
TOKEN: 0x200002A
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Boolean                  isLeft  // 0x18
  public            System.Boolean                  isRight  // 0x19
  public            System.Boolean                  isBottom  // 0x1A
  public            System.Boolean                  isFullHorizontalStretch  // 0x1B
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIStyleInputValidType
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIStyleInputValidType All  // 0x0
  public    static  Beyond.UI.UIStyleInputValidType Keyboard  // 0x0
  public    static  Beyond.UI.UIStyleInputValidType Touch  // 0x0
  public    static  Beyond.UI.UIStyleInputValidType Controller  // 0x0
  public    static  Beyond.UI.UIStyleInputValidType KeyboardAndTouch  // 0x0
  public    static  Beyond.UI.UIStyleInputValidType KeyboardAndController  // 0x0
  public    static  Beyond.UI.UIStyleInputValidType TouchAndController  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UIStyleInputValidTypeMask
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIStyleInputValidTypeMaskKeyboard  // 0x0
  public    static  Beyond.UI.UIStyleInputValidTypeMaskTouch  // 0x0
  public    static  Beyond.UI.UIStyleInputValidTypeMaskController  // 0x0
  public    static  Beyond.UI.UIStyleInputValidTypeMaskAll  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.ActiveType
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.ActiveType            UseGameObjectActive  // 0x0
  public    static  Beyond.UI.ActiveType            UseScale  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.CustomUIStyle
TYPE:  class
TOKEN: 0x200002E
EXTENDS: MonoBehaviour
FIELDS:
  public            Beyond.UI.UIStyleInputValidType inputValidType  // 0x18
  public            Beyond.UI.ActiveType            activeType  // 0x1C
  private           UnityEngine.UI.LayoutElement    _layoutElement  // 0x20
  private           UnityEngine.Animator            _animator  // 0x28
  private           Beyond.UI.CustomUIStyle.OverrideValidStatem_overrideValidState  // 0x30
METHODS:
  Beyond.UI.UIStyleInputValidTypeMask get_inputValidTypeMask()
  System.Void set_inputValidTypeMask(Beyond.UI.UIStyleInputValidTypeMask value)
  Beyond.UI.CustomUIStyle.OverrideValidState get_overrideValidState()
  System.Void set_overrideValidState(Beyond.UI.CustomUIStyle.OverrideValidState value)
  System.Void _OnActiveTypeChanged()
  System.Boolean get_isValid()
  System.Void OnDestroy()
  System.Void OnEnable()
  System.Void Awake()
  System.Void CheckState()
  System.Void ToggleActiveState(System.Boolean isActive)
  System.Boolean IsShowTypeValid(Beyond.UI.UIStyleInputValidType inputValidType)
  System.Boolean IsValidInput(Beyond.UI.UIStyleInputValidTypeMask inputValidTypeMask)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.DeactivateNaviOnEnable
TYPE:  class
TOKEN: 0x2000030
EXTENDS: MonoBehaviour
FIELDS:
  public            System.String                   key  // 0x18
METHODS:
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.DecoLineActiveHelper
TYPE:  class
TOKEN: 0x2000031
EXTENDS: TickableUIMono
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.GameObject>checkTargets  // 0x68
  public            System.Collections.Generic.List<UnityEngine.GameObject>secondCheckTargets  // 0x70
  private           UnityEngine.UI.LayoutElement    _layoutElement  // 0x78
METHODS:
  Beyond.TickType get_tickOption()
  System.Void Reset()
  System.Void OnEnable()
  System.Void LateTick(System.Single deltaTime)
  System.Void Sync()
  System.Boolean _HasActiveTarget(System.Collections.Generic.List<UnityEngine.GameObject> targets)
  System.Void _ToggleVisible(System.Boolean isVisible)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.Empty4Raycast
TYPE:  class
TOKEN: 0x2000032
EXTENDS: MaskableGraphic
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
  System.Void <>iFixBaseProxy_OnPopulateMesh(UnityEngine.UI.VertexHelper P0)
END_CLASS

CLASS: Beyond.UI.FitAspectRatioByFOV
TYPE:  class
TOKEN: 0x2000033
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Single                   referenceAspect  // 0x18
  private           System.Single                   m_referenceVerticalFOV  // 0x1C
  private           Cinemachine.CinemachineVirtualCameram_virtualCamera  // 0x20
  private           System.Single                   m_currentAspect  // 0x28
METHODS:
  System.Void Start()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnScreenSizeChanged(System.Int32 width, System.Int32 height)
  System.Void _AdjustFOV()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.FixRotation
TYPE:  class
TOKEN: 0x2000034
EXTENDS: TickableUIMono
FIELDS:
  public            UnityEngine.Vector3             rotation  // 0x68
METHODS:
  Beyond.TickType get_tickOption()
  System.Void LateTick(System.Single deltaTime)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.FullScreenSceneBlurMarker
TYPE:  class
TOKEN: 0x2000035
EXTENDS: MonoBehaviour
FIELDS:
  private   static  System.Int32                    s_nextId  // 0x0
  public    static  System.Action<System.Int32,Beyond.UI.FullScreenSceneBlurMarker.State,System.Boolean,System.Boolean>s_onFullScreenSceneBlurMarkerStateChanged  // 0x8
  private           System.Int32                    <id>k__BackingField  // 0x18
  public            System.Boolean                  useWhiteBlur  // 0x1C
  public            System.Boolean                  useSceneColorPS  // 0x1D
METHODS:
  System.Int32 _GetNextId()
  System.Int32 get_id()
  System.Void set_id(System.Int32 value)
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.InputBindingGroupNaviDecorator
TYPE:  class
TOKEN: 0x2000037
EXTENDS: Selectable
FIELDS:
  private           Beyond.Input.InputBindingGroupMonoTargetm_inputBindingGroup  // 0x180
  public            UnityEngine.Events.UnityEvent<System.Boolean>onGroupSetAsNaviTarget  // 0x188
METHODS:
  System.Void _SetSelfEnabledStateIfNecessary()
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDestroy()
  System.Void _OnSetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode)
  System.Void ClearComponent()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Awake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDestroy()
  System.Void <>iFixBaseProxy__OnSetAsNaviTarget(System.Boolean P0, System.Boolean P1)
END_CLASS

CLASS: Beyond.UI.IUIClearable
TYPE:  interface
TOKEN: 0x2000038
FIELDS:
METHODS:
  System.Void ClearComponent()
END_CLASS

CLASS: Beyond.UI.LuaPanel
TYPE:  class
TOKEN: 0x2000039
EXTENDS: MonoBehaviour
FIELDS:
  public    static  System.Collections.Generic.Dictionary<System.String,Beyond.UI.LuaPanel>s_openedLuaPanels  // 0x0
  private           System.Boolean                  _isPCOnlyPanel  // 0x18
  private           System.Boolean                  _isControllerPanel  // 0x19
  public            System.Boolean                  inited  // 0x1A
  private           System.Boolean                  _isWorldUI  // 0x1B
  private           UnityEngine.Vector3             _uiRot  // 0x1C
  private           System.Boolean                  _blockWhileAnim  // 0x28
  private           System.Int32                    <panelLevel>k__BackingField  // 0x2C
  public            Beyond.UI.UIAnimationWrapper    animationWrapper  // 0x30
  private           Beyond.Audio.AudioUIUtil.UIAudioType_uiAudioType  // 0x38
  private           UnityEngine.RectTransform       <rectTransform>k__BackingField  // 0x40
  private           UnityEngine.Canvas              <canvas>k__BackingField  // 0x48
  public            System.Collections.Generic.HashSet<Beyond.UI.UISortingOrder>sortingOrderComps  // 0x50
  private           UnityEngine.Camera              <uiCamera>k__BackingField  // 0x58
  private           System.Single                   <planeDistance>k__BackingField  // 0x60
  private           System.Int32                    <panelId>k__BackingField  // 0x64
  private           System.String                   <panelName>k__BackingField  // 0x68
  private           System.Boolean                  m_showRot  // 0x70
  private           Beyond.Input.InputBindingGroupMonoTargetm_inputBindingGroupMonoTarget  // 0x78
  private           UnityEngine.UI.GraphicRaycaster[]m_graphicRaycasters  // 0x80
  private           System.Boolean                  m_started  // 0x88
  private           UnityEngine.Coroutine           m_animationInCoroutine  // 0x90
  private           System.Boolean                  m_waitAutoAnimInFinished  // 0x98
  public            Beyond.DisposedUnityEvent       onAnimationInFinished  // 0xA0
  private           System.Boolean                  m_animationInFinished  // 0xA8
  private           System.Collections.Generic.HashSet<UnityEngine.GameObject>m_animationInWaitTargets  // 0xB0
METHODS:
  System.Int32 get_panelLevel()
  System.Void set_panelLevel(System.Int32 value)
  UnityEngine.RectTransform get_rectTransform()
  System.Void set_rectTransform(UnityEngine.RectTransform value)
  UnityEngine.Canvas get_canvas()
  System.Void set_canvas(UnityEngine.Canvas value)
  UnityEngine.Camera get_uiCamera()
  System.Void set_uiCamera(UnityEngine.Camera value)
  System.Single get_planeDistance()
  System.Void set_planeDistance(System.Single value)
  System.Int32 get_panelId()
  System.Void set_panelId(System.Int32 value)
  System.String get_panelName()
  System.Void set_panelName(System.String value)
  System.Void set_IsWorldUI(System.Boolean value)
  System.Boolean get_IsWorldUI()
  System.Boolean get_isPCOnlyPanel()
  System.Boolean get_isControllerPanel()
  System.Void Awake()
  System.Void _TrySetRot()
  System.Void AddSortingOrderComp(Beyond.UI.UISortingOrder comp)
  System.Void RemoveSortingOrderComp(Beyond.UI.UISortingOrder comp)
  System.Void Start()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Collections.IEnumerator _AutoAnimationInFinish()
  System.Boolean get_animationInFinished()
  System.Void InformAnimationInStart(UnityEngine.GameObject target)
  System.Void InformAnimationInEnd(UnityEngine.GameObject target, System.Boolean forceEnd)
  System.Void _TryCallAnimationInFinished(System.Boolean forceFinished)
  System.Void BlockAllInput()
  System.Void RecoverAllInput()
  System.Void ClearComponent()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.MouseHoverTipsPosHelper
TYPE:  class
TOKEN: 0x200003B
EXTENDS: TickableUIMono
FIELDS:
  private           UnityEngine.RectOffset          _padding  // 0x68
  private           Beyond.UI.LuaPanel              m_panel  // 0x70
  private           UnityEngine.RectTransform       m_rectTransform  // 0x78
METHODS:
  Beyond.TickType get_tickOption()
  Beyond.UI.LuaPanel get_panel()
  System.Void OnAwake()
  System.Void OnEnable()
  System.Void LateTick(System.Single deltaTime)
  System.Void UpdatePosition()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.NaviToThisGroupOnEnable
TYPE:  class
TOKEN: 0x200003C
EXTENDS: MonoBehaviour
FIELDS:
  public            Beyond.UI.UISelectableNaviGroup target  // 0x18
METHODS:
  System.Void Reset()
  System.Void Awake()
  System.Void OnEnable()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.NonDrawingGraphic
TYPE:  class
TOKEN: 0x200003D
EXTENDS: Graphic
FIELDS:
  public            Beyond.UI.NonDrawingGraphic.ShapeTypeshapeType  // 0xB0
METHODS:
  System.Single get_Radius()
  System.Void SetMaterialDirty()
  System.Void SetVerticesDirty()
  System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
  System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
  System.Boolean _IsRaycastLocationValidCircle(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_SetMaterialDirty()
  System.Void <>iFixBaseProxy_SetVerticesDirty()
  System.Void <>iFixBaseProxy_OnPopulateMesh(UnityEngine.UI.VertexHelper P0)
END_CLASS

CLASS: Beyond.UI.NotchAdapter
TYPE:  class
TOKEN: 0x200003F
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.Vector2             selfMarginSize  // 0x18
  public            System.Collections.Generic.List<UnityEngine.RectTransform>leftSideUIList  // 0x20
  public            System.Collections.Generic.List<UnityEngine.RectTransform>rightSideUIList  // 0x28
  public            System.Collections.Generic.List<UnityEngine.RectTransform>bottomSideUIList  // 0x30
  public            System.Collections.Generic.List<UnityEngine.RectTransform>fullHorizontalStretchUIList  // 0x38
  public            System.Boolean                  alwaysFindSideUI  // 0x40
  private           UnityEngine.UI.CanvasScaler     m_canvasScaler  // 0x48
  private           Beyond.UI.UICanvasScaleHelper   m_notchHost  // 0x50
METHODS:
  System.Void Awake()
  System.Void OnDestroy()
  System.Void FindAllSideUI(System.Boolean needClear)
  System.Void ApplyNotch()
  System.Void ApplyNotch(UnityEngine.Vector2 curMarginSize)
  System.Void ClearList()
  System.Void ClearNullRef()
  System.Void UnApplyNotch()
  System.Void ApplyNewNotch()
  System.Void _UpdateMargeSizeFromNotchInfo(System.Boolean forceUpdate)
  System.Void _OnCanvasChanged()
  System.Void _RemoveNullRef(System.Collections.Generic.List<T> list)
  System.Void _TraverseUI(UnityEngine.RectTransform root)
  System.Void _TryAddToSideUI(UnityEngine.RectTransform rect, Beyond.UI.CustomNotchAdapt custom)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.ParallaxHelper
TYPE:  class
TOKEN: 0x2000041
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<Beyond.UI.ParallaxHelper.ParallaxConfig>_configs  // 0x18
  private           System.Single                   _maxOffset  // 0x20
  private           System.Single                   m_curValue  // 0x24
METHODS:
  System.Single get_curValue()
  System.Void set_curValue(System.Single value)
  System.Void InitConfigs()
  System.Void ResetValue()
  System.Void RefreshPos()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.PercentNumberTweener
TYPE:  class
TOKEN: 0x2000043
EXTENDS: TickableUIMono
FIELDS:
  private           Beyond.UI.UIText                _text  // 0x68
  private           System.String                   _format  // 0x70
  private           Beyond.UI.UIImage               _progressImg  // 0x78
  private           System.Int32                    m_cacheValue  // 0x80
METHODS:
  Beyond.TickType get_tickOption()
  System.Void Reset()
  System.Void OnEnable()
  System.Void LateTick(System.Single deltaTime)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIRecycleLayoutAdapter
TYPE:  class
TOKEN: 0x2000044
FIELDS:
  private           Beyond.UI.UIRecycleLayoutGroup.IViewHandler<viewHandler>k__BackingField  // 0x10
METHODS:
  System.Void Init(Beyond.UI.UIRecycleLayoutGroup.IViewHandler handler)
  Beyond.UI.UIRecycleLayoutGroup.IViewHandler get_viewHandler()
  System.Void set_viewHandler(Beyond.UI.UIRecycleLayoutGroup.IViewHandler value)
  System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
  System.Void OnInit()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIRecycleLayoutSimpleHolder`1
TYPE:  class
TOKEN: 0x2000049
EXTENDS: TickableUIMono
FIELDS:
  private           Beyond.UI.UIScrollRect          _scrollRect  // 0x0
  protected         System.Single                   _scrollDuration  // 0x0
  protected         DG.Tweening.Ease                _scrollEase  // 0x0
  protected         System.Boolean                  _enableLoopWrappedNavigation  // 0x0
  private           System.Boolean                  m_isInited  // 0x0
  protected         Beyond.UI.UIRecycleLayoutSimpleHolder.SimpleAdapter<TVirtualView>m_simpleAdapter  // 0x0
  protected         Beyond.UI.UIRecycleLayoutGroup  m_layoutGroup  // 0x0
  public            Beyond.DisposedUnityEvent       doOnceAfterLayout  // 0x0
  private           System.Collections.Generic.List<UnityEngine.UI.Selectable>m_wrapNaviSelectables  // 0x0
  protected         DG.Tweening.Tween               m_scrollTween  // 0x0
METHODS:
  System.Void _InitIfNot()
  System.Void OnAwake()
  System.Void _AfterLayout()
  System.Void _WrapNavigation(UnityEngine.UI.NaviDirection dir)
  System.Void OnAdapterInit()
  System.Void ScrollTo(System.Int32 index, System.Boolean fastMode)
  System.Void ClearScrollTweenIfNeeded()
  System.Void ScrollToInternal(System.Single normalizedPosition, System.Boolean fastMode)
  UnityEngine.GameObject GetView(System.Int32 index)
  System.Void NotifyAllSizeChanged()
  System.Void NotifySizeChanged(System.Int32 index)
  System.Void NotifySizeChanged(TVirtualView virtualView)
  System.Void RemoveView(System.Int32 index)
  System.Void RemoveAllViews()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIRecycleLayoutGroup
TYPE:  class
TOKEN: 0x200004C
EXTENDS: TickableUIMono
FIELDS:
  private           Beyond.UI.UIRecycleLayoutGroup.Direction_direction  // 0x68
  private           UnityEngine.RectTransform       _viewport  // 0x70
  private           UnityEngine.RectTransform       _content  // 0x78
  private           System.Single                   _notCachedBufferSize  // 0x80
  private           System.Int32                    _layoutPriority  // 0x84
  private           Beyond.UI.UIRecycleLayoutGroup.Padding_padding  // 0x88
  private           System.Single                   _spacing  // 0x98
  private           System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIRecycleLayoutGroup.LayoutMeta>m_layoutMetaMap  // 0xA0
  private           Beyond.UI.UIRecycleLayoutAdapterm_adapter  // 0xA8
  private           Beyond.UI.UIRecycleLayoutGroup.ViewMgrm_viewMgr  // 0xB0
  private           System.Single                   <sizeOnAxis>k__BackingField  // 0xB8
  public            Beyond.DisposedUnityEvent       onLayoutUpdated  // 0xC0
METHODS:
  Beyond.TickType get_tickOption()
  Beyond.UI.UIRecycleLayoutAdapter get_adapter()
  Beyond.UI.UIRecycleLayoutGroup.ViewMgr get_viewMgr()
  System.Single get_sizeOnAxis()
  System.Void set_sizeOnAxis(System.Single value)
  System.Single get_spacing()
  Beyond.UI.UIRecycleLayoutGroup.Padding get_padding()
  System.Single get_minWidth()
  System.Single get_minHeight()
  System.Single get_flexibleWidth()
  System.Single get_flexibleHeight()
  System.Int32 get_layoutPriority()
  System.Void CalculateLayoutInputHorizontal()
  System.Void CalculateLayoutInputVertical()
  System.Single get_preferredWidth()
  System.Single get_preferredHeight()
  System.Single get_paddingFront()
  System.Single get_paddingBack()
  System.Void _ApplyLayoutMeta(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view, Beyond.UI.UIRecycleLayoutGroup.LayoutMeta meta)
  UnityEngine.Vector2 _GetVisibleRange(UnityEngine.Bounds viewBound)
  UnityEngine.Bounds _GetElementBoundsFromMeta(Beyond.UI.UIRecycleLayoutGroup.LayoutMeta meta)
  Beyond.UI.UIRecycleLayoutAdapter SetAdapter(Beyond.UI.UIRecycleLayoutAdapter adapter)
  System.Void ClearComponent()
  System.Void LateTick(System.Single deltaTime)
  System.Void OnLateTick()
  System.Void _RebuildAllViews()
  System.Void _UpdateViews(System.Int32 fromIndex)
  System.Boolean _InsertView(System.Int32 index, Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  System.Boolean _RemoveView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  System.Void _UpdateViewsFrom(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  System.Single _GetElementPosByIndex(System.Int32 index)
  UnityEngine.Bounds _GetElementBoundsByIndex(System.Int32 index)
  System.Int32 _GetElementIndex(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view)
  UnityEngine.RectTransform get_content()
  System.Void _RefreshLayout()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIRecycleMultiHolder
TYPE:  class
TOKEN: 0x2000055
EXTENDS: UIRecycleLayoutSimpleHolder`1
FIELDS:
  private           System.Collections.Generic.List<Beyond.UI.UIRecycleMultiHolder.Config>_configs  // 0xA8
  public            Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32>onUpdateCell  // 0xB0
  public            Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32>onDetachCell  // 0xB8
  public            System.Func<System.Int32,System.Single>getCellDefaultSize  // 0xC0
  public            System.Func<System.Int32,System.String>getCellPrefabKey  // 0xC8
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject>m_prefabMap  // 0xD0
METHODS:
  Beyond.UI.UIRecycleMultiHolder.MultiVirtualView GetVirtualView(System.Int32 index)
  System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop)
  System.Void UpdateCount(System.Int32 newCount, System.Int32 fastScrollToIndex)
  System.Void InsertView(System.Int32 index, System.String key, System.Single initSize)
  System.Void AddView(System.String key, System.Single initSize)
  System.Void OnAdapterInit()
  System.Void ClearComponent()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIRecycleSingleHolder
TYPE:  class
TOKEN: 0x2000058
EXTENDS: UIRecycleLayoutSimpleHolder`1
FIELDS:
  private           System.Int32                    m_count  // 0xA8
  public            Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32>onUpdateCell  // 0xB0
  public            Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32>onDetachCell  // 0xB8
  public            System.Func<System.Int32,System.Single>getCellDefaultSize  // 0xC0
  private           UnityEngine.GameObject          _cellTemplate  // 0xC8
METHODS:
  Beyond.UI.UIRecycleSingleHolder.SimpleVirtualView GetVirtualView(System.Int32 index)
  System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop)
  System.Void UpdateCount(System.Int32 newCount, System.Int32 fastScrollToIndex)
  System.Void InsertView(System.Int32 index, System.String key, System.Single initSize)
  System.Void AddView(System.String key, System.Single initSize)
  System.Void OnAdapterInit()
  System.Void ClearComponent()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.SimpleUITextSingleLine
TYPE:  class
TOKEN: 0x200005A
EXTENDS: UIText
FIELDS:
  private   static  Unity.Profiling.ProfilerMarker  s_GenerateTextMarker  // 0x0
  private   static  Unity.Profiling.ProfilerMarker  s_GenerateTextPhaseIMarker  // 0x8
  private   static  Unity.Profiling.ProfilerMarker  s_CharacterLookupMarker  // 0x10
  private   static  Unity.Profiling.ProfilerMarker  s_HandleGPOSFeaturesMarker  // 0x18
  private   static  Unity.Profiling.ProfilerMarker  s_CalculateVerticesPositionMarker  // 0x20
  private   static  Unity.Profiling.ProfilerMarker  s_ComputeTextMetricsMarker  // 0x28
  private   static  Unity.Profiling.ProfilerMarker  s_HandleVisibleCharacterMarker  // 0x30
  private   static  Unity.Profiling.ProfilerMarker  s_HandleVisibleCharacterMarker_1  // 0x38
  private   static  Unity.Profiling.ProfilerMarker  s_HandleVisibleCharacterMarker_2  // 0x40
  private   static  Unity.Profiling.ProfilerMarker  s_HandleVisibleCharacterMarker_3  // 0x48
  private   static  Unity.Profiling.ProfilerMarker  s_HandleVisibleCharacterMarker_4  // 0x50
  private   static  Unity.Profiling.ProfilerMarker  s_HandleWhiteSpacesMarker  // 0x58
  private   static  Unity.Profiling.ProfilerMarker  s_HandleHorizontalLineBreakingMarker  // 0x60
  private   static  Unity.Profiling.ProfilerMarker  s_HandleVerticalLineBreakingMarker  // 0x68
  private   static  Unity.Profiling.ProfilerMarker  s_SaveGlyphVertexDataMarker  // 0x70
  private   static  Unity.Profiling.ProfilerMarker  s_ComputeCharacterAdvanceMarker  // 0x78
  private   static  Unity.Profiling.ProfilerMarker  s_HandleCarriageReturnMarker  // 0x80
  private   static  Unity.Profiling.ProfilerMarker  s_HandleLineTerminationMarker  // 0x88
  private   static  Unity.Profiling.ProfilerMarker  s_SavePageInfoMarker  // 0x90
  private   static  Unity.Profiling.ProfilerMarker  s_SaveProcessingStatesMarker  // 0x98
  private   static  Unity.Profiling.ProfilerMarker  s_GenerateTextPhaseIIMarker  // 0xA0
  private   static  Unity.Profiling.ProfilerMarker  s_GenerateTextPhaseIIIMarker  // 0xA8
  public            System.Boolean                  m_b  // 0xC80
  private           System.Action<TMPro.TMP_TextInfo>OnPreRenderText  // 0xC88
METHODS:
  System.Void GenerateTextMesh()
  System.Void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value)
  System.Void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value)
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_GenerateTextMesh()
END_CLASS

CLASS: Beyond.UI.ToastList
TYPE:  class
TOKEN: 0x200005B
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.GameObject          _cellTemplate  // 0x18
  private           System.Single                   _showDuration  // 0x20
  private           System.Single                   _delay  // 0x24
  private           System.Int32                    _maxShowingCount  // 0x28
  private           System.Boolean                  <inAnimation>k__BackingField  // 0x2C
  public            Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32>onUpdateCell  // 0x30
  public            Beyond.DisposedUnityEvent       onAllToastFinished  // 0x38
  private           System.Int32                    m_totalCount  // 0x40
  private           System.Int32                    m_maxFinishedIndex  // 0x44
  private           System.Int32                    m_maxShowingIndex  // 0x48
  private           System.Int32                    m_waitingCount  // 0x4C
  private           System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.ToastList.CellInfo>m_showingCells  // 0x50
  private           System.Collections.Generic.List<Beyond.UI.ToastList.CellInfo>m_cachedCells  // 0x58
METHODS:
  System.Boolean get_inAnimation()
  System.Void set_inAnimation(System.Boolean value)
  System.Void Awake()
  System.Void OnDisable()
  Beyond.UI.ToastList.CellInfo _GetCell()
  System.Void _CacheCell(Beyond.UI.ToastList.CellInfo cell)
  System.Void AddToast(System.Int32 count, System.Int32 startIndex)
  System.Void _StartBatch(System.Int32 batchCount)
  System.Collections.IEnumerator _ShowCell(System.Int32 delayIndex, Beyond.UI.ToastList.CellInfo cell)
  System.Void _TryShowNewCell()
  System.Void _OnCellFinished(Beyond.UI.ToastList.CellInfo cell)
  System.Void ClearAllToast()
  System.Void ClearComponent()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UI3DScrollList
TYPE:  class
TOKEN: 0x200005E
EXTENDS: UIScrollList
FIELDS:
METHODS:
  System.Void MoveCellTo(Beyond.UI.UIScrollList.Cell cell, System.Int32 index)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_MoveCellTo(Beyond.UI.UIScrollList.Cell P0, System.Int32 P1)
END_CLASS

CLASS: Beyond.UI.UIActionKeyHint
TYPE:  class
TOKEN: 0x200005F
EXTENDS: MonoBehaviour
FIELDS:
  private   static readonly UnityEngine.Color               NORMAL_COLOR  // 0x0
  private   static readonly UnityEngine.Color               HIDE_COLOR  // 0x10
  private   static readonly UnityEngine.Color               DISABLED_COLOR  // 0x20
  private   static  System.Collections.Generic.List<Beyond.UI.UIActionKeyHint>s_keyHintCache  // 0x30
  private   static  System.Boolean                  s_inited  // 0x38
  public    static  System.Boolean                  s_stopCheckBindingEnabledForGuide  // 0x39
  private   static  System.String                   INVALID_KEY_STR  // 0x0
  private           Beyond.Input.IBindingView       m_target  // 0x18
  public            System.String                   actionId  // 0x20
  public            UnityEngine.Component           btnTarget  // 0x28
  public            Beyond.Input.BindingViewActionTypebindingViewActionType  // 0x30
  private           System.Boolean                  _useCustomText  // 0x34
  private           System.Boolean                  _showSecondAction  // 0x35
  private           System.Boolean                  _onlyShowOnLongPress  // 0x36
  private           System.Boolean                  _adaptForceGrayState  // 0x37
  private           UnityEngine.Transform           _content  // 0x38
  private           UnityEngine.CanvasGroup         _contentCanvasGroup  // 0x40
  private           Beyond.UI.UIImage               _icon  // 0x48
  private           Beyond.UI.UIImage               _longPressIcon  // 0x50
  private           UnityEngine.RectTransform       _pressHintNode  // 0x58
  private           Beyond.UI.UIImage               _pressHintProgressImg  // 0x60
  private           Beyond.UI.UIText                _text  // 0x68
  private           Beyond.UI.UIImage               _secondIcon  // 0x70
  private           UnityEngine.RectTransform       _secondNode  // 0x78
  private           Beyond.UI.UIImage               _modifyIcon  // 0x80
  private           UnityEngine.GameObject          _mutexGameObject  // 0x88
  private           System.Boolean                  _changeScaleOnHide  // 0x90
  public            System.Int32                    bindingId  // 0x94
  public            System.Func<System.Boolean>     checkVirtualMouseClickHintFunc  // 0x98
  private           UnityEngine.CanvasGroup         _canvasGroup  // 0xA0
  public            System.Boolean                  autoUpdate  // 0xA8
  private           System.Boolean                  <hintHidden>k__BackingField  // 0xA9
  private           System.Int32                    m_cachedBindingId  // 0xAC
  private           System.Boolean                  m_isLongPressAction  // 0xB0
  private           System.Single                   m_lastPressStartTime  // 0xB4
  private   static  System.Single                   LONG_PRESS_HINT_HIDE_TIME  // 0x0
  private   static  System.Single                   LONG_PRESS_HINT_SHOW_MIN_VALUE  // 0x0
METHODS:
  System.Void _TryInit()
  System.Void _RefreshAllKeyHints()
  System.Void _OnInputLateTickAll()
  System.Void _OnControllerTypeChange(Beyond.DeviceInfo.ControllerType controllerType)
  Beyond.Input.IBindingView get_target()
  System.Boolean get_showCanvasGroup()
  System.Boolean get_hintHidden()
  System.Void set_hintHidden(System.Boolean value)
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void Reset()
  System.Void _OnInputLateTick()
  System.Void UpdateKeyHint()
  System.Void SetActionId(System.String id, System.Boolean forceUpdate)
  System.Void SetKeyHint(System.String actId, Beyond.Input.IBindingView hintTarget, System.Boolean forceUpdate)
  System.Void SetBindingId(System.Int32 bId, System.Boolean forceUpdate)
  System.Void SetBindingId(System.Int32 bId, System.String actId, Beyond.Input.IBindingView hintTarget, System.Boolean forceUpdate)
  System.Void _OnChangeTarget()
  System.Void _OnInputActionKeyUpdated(Beyond.EventData<System.String>& data)
  System.Void SetSecondActionId(System.String id, System.Boolean isPrimary)
  System.Void _SetSecondIcon(Beyond.Input.PlayerActionInfo actionInfo, System.Boolean isPrimary)
  System.Void _CheckInteractable(System.Boolean isInit)
  System.Boolean _IsInputEnabled()
  System.Boolean _IsInputGray()
  System.String GetTextStr()
  System.Void SetText(System.String text)
  System.Boolean GetAndSetActionIcon(Beyond.UI.UIImage iconImage, Beyond.Input.PlayerActionInfo actionInfo, System.Boolean usingController, System.Boolean& isLongPressAction, System.Boolean isPrimary)
  System.Boolean GetAndSetActionModifyIcon(Beyond.Input.PlayerActionInfo actionInfo, System.Boolean usingController, System.Boolean isPrimary)
  System.Boolean _SetKeyCodeSprite(Beyond.UI.UIImage iconImage, System.String iconPath)
  System.Void _CheckVirtualMouseClickHint()
  System.Void _UpdatePressHint()
  System.Void _GetLongPressInfo(System.Single& startTime, System.Single& longPressTime)
  System.String GetActionId()
  Beyond.Input.PlayerActionInfo GetActionInfo()
  System.Void ClearComponent()
  System.Void SetContentState(System.Boolean contentState)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UIAnimationHolder
TYPE:  class
TOKEN: 0x2000060
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<Beyond.UI.UIAnimationHolder.ClipHolder>_clips  // 0x18
METHODS:
  UnityEngine.AnimationClip FindByName(System.String name)
  UnityEngine.AnimationClip FindByNameOrAlias(System.String nameOrAlias)
  UnityEngine.AnimationClip _FindByString(System.String id, System.Boolean useAlias)
  System.Void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> results)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIAnimationLoopSynchronizer
TYPE:  class
TOKEN: 0x2000062
EXTENDS: MonoBehaviour
FIELDS:
  public            System.String                   syncLoopAnimKey  // 0x18
  private   readonly System.Collections.Generic.List<Beyond.UI.UIAnimationWrapper>m_children  // 0x20
METHODS:
  System.Void RegisterChild(Beyond.UI.UIAnimationWrapper child)
  System.Void UnregisterChild(Beyond.UI.UIAnimationWrapper child)
  System.Single GetLoopStartPosition()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIAnimationWrapper
TYPE:  class
TOKEN: 0x2000063
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.AnimationClip       _animationIn  // 0x18
  private           UnityEngine.AnimationClip       _animationInEasing  // 0x20
  private           UnityEngine.AnimationClip       _animationLoop  // 0x28
  private           UnityEngine.AnimationClip       _animationOut  // 0x30
  public            System.Boolean                  autoPlay  // 0x38
  private           System.Boolean                  _onlyOnce  // 0x39
  private           System.Boolean                  _needSyncLoopAnim  // 0x3A
  private           System.String                   _syncLoopAnimKey  // 0x40
  private           Beyond.UI.UIAnimationWrapper.FOptions_options  // 0x48
  private           UnityEngine.Animation           m_animation  // 0x50
  private           System.Collections.Generic.Dictionary<System.String,Beyond.UI.UIAnimationWrapper.AnimationRuntime>m_animPool  // 0x58
  private           Beyond.UI.UIAnimationTween      m_curTween  // 0x60
  private           System.Boolean                  m_isInAutoPlayed  // 0x68
  private           Beyond.UI.UIAnimationLoopSynchronizerm_loopSynchronizer  // 0x70
  private   static readonly System.Collections.Generic.List<Beyond.UI.UIAnimationLoopSynchronizer>s_tempSyncList  // 0x0
  public            System.String                   curStateName  // 0x78
  public            Beyond.UI.UIConst.AnimationStatecurState  // 0x80
  private           System.Single                   m_lastPlayAnimationInStartTime  // 0x84
  private           System.Boolean                  m_started  // 0x88
  private           Beyond.UI.UIAnimationWrapper.CachedSampleClipInfom_cachedSampleClipInfo  // 0x90
  private           System.Boolean                  m_needInformAnimationInEnd  // 0xA0
  private           Beyond.UI.LuaPanel              m_panel  // 0xA8
  private           System.String                   _audioOnOpen  // 0xB0
  private           System.String                   _audioOnClose  // 0xB8
METHODS:
  UnityEngine.AnimationClip get_animationIn()
  UnityEngine.AnimationClip get_animationInEasing()
  UnityEngine.AnimationClip get_animationLoop()
  UnityEngine.AnimationClip get_animationOut()
  System.Void SetOptions(Beyond.UI.UIAnimationWrapper.FOptions options)
  Beyond.UI.UIAnimationTween get_curTween()
  System.Void _InitAnimation()
  System.Void _AnimationInLoopCheck()
  System.Void _AnimationAutomaticallyCheck()
  System.Void Awake()
  System.Boolean IsStarted()
  System.Void PlayOutAnimation(DG.Tweening.TweenCallback callback)
  System.Void SetAnimationOutClip(System.String clipName)
  System.Single GetInClipLength()
  System.Single GetOutClipLength()
  System.Single GetLoopClipLength()
  System.Void PlayLoopAnimation()
  System.Void PlayInAnimation(DG.Tweening.TweenCallback callback, System.Boolean autoPlayLoop)
  System.Void SkipInAnimation()
  System.Void SampleToInAnimationBegin()
  System.Void SampleToInAnimationEnd()
  System.Void SampleToOutAnimationEnd()
  System.Void _OnInAnimationFinished(System.Boolean autoPlayLoop)
  System.Void _OnInEasingAnimationFinished(System.Boolean autoPlayLoop)
  UnityEngine.AnimationState GetClip(System.String aniName)
  System.Single GetClipLength(System.String aniName)
  System.Void _SampleClipAtLength(Beyond.UI.UIAnimationWrapper.AnimationRuntime runtime, System.Single position)
  System.Void SampleClipAtPercent(System.String clipName, System.Single percent, System.Boolean clearTween)
  System.Void SampleClip(System.String clipName, System.Single position, System.Boolean clearTween)
  System.Void ClearTween(System.Boolean executeOnComplete)
  System.Boolean _CheckShouldAutoPlayAnimationIn()
  System.Void Start()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Boolean CheckStopped()
  System.Void Play(UnityEngine.AnimationClip animationClip, DG.Tweening.TweenCallback onComplete, Beyond.UI.UIConst.AnimationState newState, System.Single startPlayTime)
  System.Void Play(System.String stateName, DG.Tweening.TweenCallback onComplete, Beyond.UI.UIConst.AnimationState newState, System.Single startPlayTime)
  System.Void PlayWithTween(UnityEngine.AnimationClip animationClip, DG.Tweening.TweenCallback onComplete, Beyond.UI.UIConst.AnimationState newState, System.Single startPlayTime)
  System.Void PlayWithTween(System.String stateName, DG.Tweening.TweenCallback onComplete, Beyond.UI.UIConst.AnimationState newState, System.Single startPlayTime)
  System.Single GetCurPlayingTime()
  Beyond.UI.LuaPanel get_panel()
  System.Void PlayOpenAudio()
  System.Void PlayCloseAudio()
  System.Void ClearComponent()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UIAnimationTween
TYPE:  class
TOKEN: 0x200006B
FIELDS:
  public    static readonly Beyond.UI.UIAnimationTween.OptionsDEFAULT_OPTION  // 0x0
  private           DG.Tweening.Tween               m_handler  // 0x10
  private           System.Single                   m_tweenValue  // 0x18
  private           UnityEngine.GameObject          m_animTarget  // 0x20
  private           System.Single                   <clipLength>k__BackingField  // 0x28
METHODS:
  DG.Tweening.Tween get_handler()
  System.Single get_tweenValue()
  System.Single get_clipLength()
  System.Void set_clipLength(System.Single value)
  System.Void .ctor(UnityEngine.GameObject target, Beyond.UI.UIAnimationWrapper wrapper, System.String name)
  System.Void .ctor(UnityEngine.GameObject target, Beyond.UI.UIAnimationWrapper wrapper, System.String name, Beyond.UI.UIAnimationTween.Options options)
  System.Single GetValue()
  System.Void _SetValue(Beyond.UI.UIAnimationWrapper wrapper, System.String name, System.Single value)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UIAnimationSwitchTween
TYPE:  class
TOKEN: 0x200006F
EXTENDS: UISwitchTween
FIELDS:
  private           Beyond.UI.UIAnimationWrapper    m_animWrapper  // 0x30
  private           System.Boolean                  m_dontDisableGameObject  // 0x38
METHODS:
  System.Void .ctor(Beyond.UI.UIAnimationWrapper animWrapper)
  Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfHide()
  Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfShow()
  System.Void BeforeShowEffect()
  System.Void AfterHideEffect()
  System.Void ResetToState(System.Boolean isShow)
  System.Void _SetGameObjectActive(System.Boolean isActive)
  System.Void <>iFixBaseProxy_BeforeShowEffect()
  System.Void <>iFixBaseProxy_AfterHideEffect()
  System.Void <>iFixBaseProxy_ResetToState(System.Boolean P0)
END_CLASS

CLASS: Beyond.UI.UIArea
TYPE:  class
TOKEN: 0x2000072
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onPointerEnter  // 0x18
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onPointerExit  // 0x20
  private           System.Boolean                  m_pointerInArea  // 0x28
  public            UnityEngine.GameObject          _highlightNode  // 0x30
METHODS:
  System.Boolean get_pointerInArea()
  System.Void _SetHighlightNodeActive(System.Boolean active)
  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void ClearComponent()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIAutoCloseArea
TYPE:  class
TOKEN: 0x2000073
EXTENDS: TickableUIMono
FIELDS:
  public    static  System.Boolean                  s_stopCheckShouldClose  // 0x0
  public            System.Collections.Generic.List<UnityEngine.RectTransform>fixedSafeAreas  // 0x68
  public            UnityEngine.RectTransform       tmpSafeArea  // 0x70
  public            System.Boolean                  alsoBlockKeyBoardInput  // 0x78
  private           System.Boolean                  _includeInAutoCloseLayer  // 0x79
  private           UnityEngine.Camera              m_fallbackUICamera  // 0x80
  public            UnityEngine.GameObject          toggleObj  // 0x88
  public            Beyond.DisposedUnityEvent       onTriggerAutoClose  // 0x90
  private           System.String                   _closeActionId  // 0x98
  private           System.Boolean                  _enableCloseActionOnController  // 0xA0
  private           Beyond.UI.UIAnimationWrapper    m_animationWrapper  // 0xA8
  private   static  System.Collections.Generic.LinkedList<UnityEngine.GameObject>s_autoCloseLayerList  // 0x8
  private           Beyond.UI.LuaPanel              m_panel  // 0xB0
  private           System.Int32                    <groupId>k__BackingField  // 0xB8
  private           Beyond.Input.IBindingGroupTarget<parentTarget>k__BackingField  // 0xC0
  private           System.Boolean                  m_bindingInit  // 0xC8
METHODS:
  Beyond.TickType get_tickOption()
  System.Boolean get_includeInAutoCloseLayer()
  System.Void set_includeInAutoCloseLayer(System.Boolean value)
  Beyond.UI.LuaPanel get_panel()
  System.Void Start()
  System.Void Reset()
  System.Void LateTick(System.Single deltaTime)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void ChangeEnableCloseActionOnController(System.Boolean enabled)
  System.Void CloseSelf()
  System.Void TryCloseSelf()
  System.Void OpenSelf(System.Boolean executeOnComplete)
  System.Boolean ShouldClose()
  System.Void ClearComponent()
  System.Void _AutoCloseToggleObjWhenOut()
  System.Void AddToAutoCloseLayer(UnityEngine.GameObject go)
  System.Void RemoveFromAutoCloseLayer(UnityEngine.GameObject go)
  System.Boolean IsTopAutoCloseLayer(UnityEngine.GameObject go)
  UnityEngine.Camera _GetUICamera()
  System.Int32 get_groupId()
  System.Void set_groupId(System.Int32 value)
  Beyond.Input.IBindingGroupTarget get_parentTarget()
  System.Void set_parentTarget(Beyond.Input.IBindingGroupTarget value)
  System.Boolean get_groupEnabled()
  System.Void InitBinding()
  System.Void _UpdateState()
  System.Void OnDestroy()
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UIBigLogo
TYPE:  class
TOKEN: 0x2000074
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.GameObject          _rootNode  // 0x18
  public            Beyond.UI.UIImage               _bigLogoImage  // 0x20
  private           UnityEngine.GameObject          _stretchNode  // 0x28
  public            Beyond.UI.UIImage               _stretchImageTop  // 0x30
  public            Beyond.UI.UIImage               _stretchImageBottom  // 0x38
  public            Beyond.UI.UIImage               _bg  // 0x40
  public            Beyond.UI.UIImage               _originalImage  // 0x48
  public            Beyond.UI.UIImage               _backgroundMask  // 0x50
  public            UnityEngine.CanvasGroup         _originalImageMain  // 0x58
METHODS:
  System.Void SetBigLogoEditor(System.String bigLogoPath, System.Boolean useStretchImage, System.Boolean showOnTop, System.Boolean hideBackground, System.Boolean useOriginalImage)
  System.Void ShowBigLogo(System.Boolean useStretchImage, System.Boolean showOnTop, System.Boolean useOriginalImage, System.Single originalImageScale)
  System.Void SetBigLogoMask(UnityEngine.Color maskColor)
  System.Void ClearBigLogoMask()
  System.Void ClearBigLogo(System.Boolean showOnTop)
  System.Void SetAlpha(System.Single alpha, System.Boolean showOnTop)
  System.Void SetMaskAlpha(System.Single alpha)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIBigRectButton
TYPE:  class
TOKEN: 0x2000075
EXTENDS: UIButton
FIELDS:
  private           Beyond.UI.UIBigRectHelper       _bigRectHelper  // 0x2D0
METHODS:
  System.Void _TryThroughEventDataToBigRectTouchPanelRaycast(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> eventFunction)
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnPointerDown(UnityEngine.EventSystems.PointerEventData P0)
  System.Void <>iFixBaseProxy_OnPointerUp(UnityEngine.EventSystems.PointerEventData P0)
END_CLASS

CLASS: Beyond.UI.UIBigRectHelper
TYPE:  class
TOKEN: 0x2000076
EXTENDS: TickableUIMono
FIELDS:
  private           System.Boolean                  m_inited  // 0x68
  private           System.Boolean                  m_openTweenFinished  // 0x69
  private           Beyond.DisposedUnityEvent       m_onOpenTweenFinished  // 0x70
  private           System.Single                   m_zoom  // 0x78
  private           System.Single                   m_zoomValue  // 0x7C
  private           UnityEngine.Vector2             m_oriSize  // 0x80
  private           DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions>m_zoomTween  // 0x88
  private           DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions>m_focusTween  // 0x90
  private           UnityEngine.Vector2             m_anchoredPosOffset  // 0x98
  private           System.Single                   m_horizontalOffset  // 0xA0
  private           System.Single                   m_verticalOffset  // 0xA4
  private           UnityEngine.Vector2             m_lastScale  // 0xA8
  private           UnityEngine.Vector2             m_nodesOffsetWithContainerNode  // 0xB0
  private           Beyond.UI.LuaPanel              m_luaPanel  // 0xB8
  private           UnityEngine.RectTransform       m_rootRectTransform  // 0xC0
  private           System.Single                   m_zoomRangeMin  // 0xC8
  private           System.Boolean                  m_useOverrideMinZoomRange  // 0xCC
  private           System.Single                   m_zoomRangeOverrideMin  // 0xD0
  private           Beyond.UI.UITouchPanel          _touchPanel  // 0xD8
  private           UnityEngine.RectTransform       _containerBigRectTransform  // 0xE0
  private           UnityEngine.RectTransform       _nodes  // 0xE8
  private           System.Single                   _moveSpeed  // 0xF0
  private           System.Single                   _zoomSpeed  // 0xF4
  private           System.Single                   _zoomRangeMax  // 0xF8
  private           System.Boolean                  _needResetPositionAndScale  // 0xFC
  private           System.Boolean                  _needCenterZoomMobile  // 0xFD
  private           System.Collections.Generic.List<System.Single>_zoomThresholds  // 0x100
  private           Beyond.DisposedUnityEvent<System.Int32,System.Boolean>m_zoomEvent  // 0x108
  private           System.Single                   _zoomTweenTime  // 0x110
  private           System.Single                   _moveNodeXOffset  // 0x114
  private           System.Single                   _moveNodeYOffset  // 0x118
  private           System.Single                   _openZoomTweenTime  // 0x11C
  private           UnityEngine.AnimationCurve      _openZoomCurve  // 0x120
  private           System.Single                   _focusNodeTime  // 0x128
  private           UnityEngine.AnimationCurve      _focusNodeCurve  // 0x130
  private           System.Boolean                  _containerEdgeAlignLeft  // 0x138
  private           UnityEngine.RectOffset          _padding  // 0x140
  private           System.Single                   _paddingBottomIncludeControllerHintBar  // 0x148
  private           System.Single                   _controllerContainerHorizontalMoveSpeed  // 0x14C
  private           System.Single                   _controllerContainerVerticalMoveSpeed  // 0x150
  private           System.Single                   _controllerZoomRate  // 0x154
  private           UnityEngine.GameObject          _controllerZoomKeyHint  // 0x158
  private           System.Boolean                  _useFocusRect  // 0x160
  private           System.Boolean                  _useClickKeyHint  // 0x161
  private           UnityEngine.Transform           _raycastRoot  // 0x168
  private           UnityEngine.RectTransform       _controllerFocusRect  // 0x170
  private           System.Single                   _controllerFocusRectHorizontalMoveSpeed  // 0x178
  private           System.Single                   _controllerFocusRectVerticalMoveSpeed  // 0x17C
  private           System.Single                   _controllerFocusLeftBoundPadding  // 0x180
  private           System.Single                   _controllerFocusRightBoundPadding  // 0x184
  private           System.Single                   _controllerFocusBottomBoundPadding  // 0x188
  private           System.Single                   _controllerFocusTopBoundPadding  // 0x18C
  private           UnityEngine.Vector2             m_lastStickValue  // 0x190
  private           UnityEngine.EventSystems.PointerEventDatam_controllerFocusEventData  // 0x198
  private   readonly System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>m_raycastResults  // 0x1A0
  private           UnityEngine.UI.Selectable       m_lastHitSelectable  // 0x1A8
  private           System.Int32                    m_bindingGroupId  // 0x1B0
  private   static  System.String                   CLICK_ACTION_ID  // 0x0
  private   static  System.String                   CLICK_NO_HINT_ACTION_ID  // 0x0
  private   static  System.Single                   DELTA_TIME_TO_STICK_VALUE_RATIO  // 0x0
  private           System.Int32                    <clickBindingId>k__BackingField  // 0x1B4
  private           System.Boolean                  <controllerMoveEnabled>k__BackingField  // 0x1B8
  private           System.Boolean                  <controllerZoomEnabled>k__BackingField  // 0x1B9
  public    readonly Beyond.DisposedUnityEvent       onControllerMoveStart  // 0x1C0
  public    readonly Beyond.DisposedUnityEvent       onControllerMoveStop  // 0x1C8
  public    readonly Beyond.DisposedUnityEvent       onControllerZoom  // 0x1D0
  public    readonly Beyond.DisposedUnityEvent       onControllerFocusEnterSelectable  // 0x1D8
  public    readonly Beyond.DisposedUnityEvent       onControllerFocusExitSelectable  // 0x1E0
METHODS:
  Beyond.TickType get_tickOption()
  Beyond.DisposedUnityEvent get_OnOpenTweenFinished()
  System.Single get_zoomRangeMin()
  Beyond.DisposedUnityEvent<System.Int32,System.Boolean> get_zoomEvent()
  Beyond.UI.UITouchPanel get_touchPanel()
  System.Void OnAwake()
  System.Void Tick(System.Single deltaTime)
  System.Void LateTick(System.Single deltaTime)
  System.Void OnRelease()
  System.Void _OnDrag(UnityEngine.Vector2 value)
  System.Void ManuallyZoom(System.Single value, System.Boolean needTween)
  System.Void _RefreshPivotPosition()
  System.Void _OnZoom(System.Single value, System.Boolean needTween)
  System.Void _SetZoomValueAndScale(System.Single value, System.Boolean needTween)
  System.Void _SetScale(System.Boolean needTween, System.Single zoomTweenTime, UnityEngine.AnimationCurve curve, DG.Tweening.TweenCallback onFinish)
  System.Void _GetContainerRectBounds(UnityEngine.Vector2& leftBottom, UnityEngine.Vector2& rightTop)
  UnityEngine.Vector2 _GetAdjustedPosition(UnityEngine.Vector2 position)
  System.Void _PosAdjust()
  System.Void _RefreshPivotPositionToMousePosition()
  System.Void _RefreshPivotPosition(UnityEngine.Vector3 targetScreenPosition)
  System.Void _UpdatePositionOffsetAfterZoomed()
  System.Void _TryAlignWhenInit()
  System.Void Init()
  System.Void FocusNode(System.Single nodeX, System.Single nodeY, DG.Tweening.TweenCallback onComplete)
  System.Void FocusNode(UnityEngine.RectTransform nodeRect, System.Boolean needTween, DG.Tweening.TweenCallback onComplete)
  System.Void ZoomToFullRect(DG.Tweening.TweenCallback onComplete)
  System.Void ChangePaddingRight(System.Int32 right)
  System.Void SetZoomRangeMax(System.Single maxValue)
  System.Void OverrideZoomRangeMin(System.Single minValue)
  System.Void SyncZoomValue(System.Single zoomValue, System.Boolean needTween)
  System.Void GetZoomRange(System.Single& rangeMin, System.Single& rangeMax)
  System.Single GetCurrentZoomValue()
  System.Void ChangePivotPositionToTarget(UnityEngine.RectTransform target)
  System.Void ResetPivotPositionToScreenCenter()
  System.Void ClearComponent()
  System.Void ClearAllTween()
  System.Int32 get_clickBindingId()
  System.Void set_clickBindingId(System.Int32 value)
  System.Boolean get_controllerMoveEnabled()
  System.Void set_controllerMoveEnabled(System.Boolean value)
  System.Boolean get_controllerZoomEnabled()
  System.Void set_controllerZoomEnabled(System.Boolean value)
  System.Void _InitControllerBindings()
  System.Boolean _GetIsControllerMoveEnabled()
  System.Boolean _GetIsControllerZoomEnabled()
  System.Void _ResetControllerState()
  System.Void _TickRefreshController(System.Single deltaTime)
  System.Void _TickRefreshControllerStickMove(System.Single deltaTime)
  System.Void _RefreshControllerFocusRaycastResults(System.Boolean ignoreTouchPanel, UnityEngine.UI.Selectable& hitSelectable, Beyond.UI.UITouchPanel& hitTouchPanel)
  System.Void _TickCheckControllerFocusRaycastTargets()
  System.Void _OnControllerClick()
  System.Void _TickRefreshControllerStickZoom(System.Single deltaTime)
  System.Void _TickRefreshControllerZoomKeyHint()
  System.Void .ctor()
  System.Void <OnAwake>b__62_0(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void <OnAwake>b__62_1(System.Single zoomValue)
  System.Void <_SetScale>b__71_0()
  System.Void <Init>b__79_0()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.UIBlendImage
TYPE:  class
TOKEN: 0x2000078
EXTENDS: UIImage
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.String,UnityEngine.Material>s_materials  // 0x0
  private           UnityEngine.Material            m_originalMaterial  // 0x218
  private           System.Boolean                  m_initialized  // 0x220
METHODS:
  System.Void SetMaterialKey(System.String key)
  System.Void SetColor(System.String materialId, UnityEngine.Color c)
  System.Void SetTexture(System.String materialId, UnityEngine.Texture t)
  System.Void ClearMaterialCache()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UIBlurMono
TYPE:  class
TOKEN: 0x2000079
EXTENDS: TickableUIMono
FIELDS:
  private           UnityEngine.Canvas              m_canvas  // 0x68
  private           Beyond.UI.LuaPanel              m_panel  // 0x70
  private           System.Int32                    m_sortingOrder  // 0x78
METHODS:
  Beyond.TickType get_tickOption()
  UnityEngine.Canvas get_canvas()
  Beyond.UI.LuaPanel get_panel()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Tick(System.Single deltaTime)
  System.Void UpdateSortingOrder(System.Int32 order)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIBlurRT
TYPE:  class
TOKEN: 0x200007A
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.UI.RawImage         _rawImage  // 0x18
  private           System.Boolean                  _autoUpdate  // 0x20
  private           HG.Rendering.Runtime.RTExtractionType_rtExtractionType  // 0x24
  private           HG.Rendering.Runtime.RTExtractionDuration_rtExtractionDuration  // 0x28
  private           UnityEngine.Rendering.RTHandle  m_rtHandle  // 0x30
  private           System.Boolean                  _needUseSceneColorPS  // 0x38
  private           UnityEngine.Rendering.RTHandle  m_useSceneColorPsRtHandle  // 0x40
  private           System.Boolean                  m_curIsUseSceneColorPS  // 0x48
METHODS:
  UnityEngine.UI.RawImage get_rawImage()
  System.Void Reset()
  System.Void InitRT()
  System.Void Register()
  System.Void UnRegister()
  System.Void UpdateRT()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void _Clear()
  System.Void SetUseSceneColorPS(System.Boolean useSceneColorPS)
  System.Void .ctor()
  System.Void <Register>b__12_0()
END_CLASS

CLASS: Beyond.UI.UIButton
TYPE:  class
TOKEN: 0x200007B
EXTENDS: Selectable
FIELDS:
  private           System.String                   _audioPressStart  // 0x180
  private           System.String                   _audioOnClick  // 0x188
  private           System.String                   _audioRelease  // 0x190
  private           System.String                   _audioLongPress  // 0x198
  private           System.String                   _audioInvalid  // 0x1A0
  private           System.Boolean                  _noAudioWhenAutoTriggerOnClick  // 0x1A8
  private   static  System.Single                   MIN_DRAG_DIST  // 0x0
  private   static  System.Single                   DOUBLE_CLICK_MAX_INTERVAL  // 0x0
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onClick  // 0x1B0
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onDoubleClick  // 0x1B8
  public            System.Boolean                  _ignoreClickOnDrag  // 0x1C0
  public            System.Boolean                  _clickThrough  // 0x1C1
  private           System.Single                   _clickCd  // 0x1C4
  private           Beyond.LangKey                  _invalidClickLangKey  // 0x1C8
  private           System.Single                   m_lastValidClickTime  // 0x1D8
  private           System.Single                   m_lastClickTime  // 0x1DC
  private           System.Boolean                  _useClickAnimation  // 0x1E0
  private           UnityEngine.AnimationCurve      _clickAnimationCurve  // 0x1E8
  private           System.Single                   _clickAnimationDuration  // 0x1F0
  private           UnityEngine.Vector3             m_oriScale  // 0x1F4
  private           UnityEngine.Coroutine           m_clickCor  // 0x200
  private           System.Boolean                  m_scaled  // 0x208
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onLongPress  // 0x210
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onPressStart  // 0x218
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onPressEnd  // 0x220
  private           System.Single                   _longPressTime  // 0x228
  public            System.Boolean                  _ignoreClickOnLongPress  // 0x22C
  public            Beyond.UI.UIImage               longPressImg  // 0x230
  private           System.Single                   _longPressImgShowDelay  // 0x238
  private           System.Single                   _longPressMaxDragDist  // 0x23C
  private           System.Boolean                  m_pressDownWaitClick  // 0x240
  private           UnityEngine.Vector2             <startPressPos>k__BackingField  // 0x244
  private           System.Int32                    <pressTouchId>k__BackingField  // 0x24C
  private           UnityEngine.Coroutine           m_longPressCor  // 0x250
  private           System.Boolean                  m_triggeredLongPress  // 0x258
  public            System.Boolean                  noTextBtn  // 0x259
  private           Beyond.UI.UIText                m_autoFindLabel  // 0x260
  private           Beyond.UI.UIText                _label  // 0x268
  private           System.Int32                    m_groupId  // 0x270
  private           System.Boolean                  m_bindingInit  // 0x274
  private           Beyond.Input.InputBindingGroupMonoTarget<parent>k__BackingField  // 0x278
  private           System.String                   m_customBindingViewLabelText  // 0x280
  public            System.String                   hintTextId  // 0x288
  private   readonly Beyond.DisposedUnityEvent       <bindingViewUpdateEvent>k__BackingField  // 0x290
  private           UnityEngine.RectTransform       _redDotTrans  // 0x298
  private           Beyond.UI.LuaPanel              m_panel  // 0x2A0
  private           System.Int32                    m_hoverBindingGroupId  // 0x2A8
  public            System.String                   clickHintTextId  // 0x2B0
  public            System.String                   longPressHintTextId  // 0x2B8
  private           Beyond.Input.ActionOnSetNaviTarget_actionOnSetNaviTarget  // 0x2C0
  private           System.Boolean                  _useNoHintAction  // 0x2C4
  private           System.Int32                    <hoverConfirmBindingId>k__BackingField  // 0x2C8
METHODS:
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void _NotifyIsHover(System.Boolean isHover)
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void _Press(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void _PlayClickAnimation(System.Boolean reverse)
  System.Collections.IEnumerator _DoClickAnimation()
  UnityEngine.Vector2 get_startPressPos()
  System.Void set_startPressPos(UnityEngine.Vector2 value)
  System.Int32 get_pressTouchId()
  System.Void set_pressTouchId(System.Int32 value)
  System.Single get_longPressTime()
  UnityEngine.Vector2 get_curPressPos()
  System.Boolean get_triggeredLongPress()
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Collections.IEnumerator _OnPress(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void _StopLongPressCor()
  System.Void set_text(System.String value)
  System.String get_text()
  Beyond.UI.UIText get_label()
  System.Void ClearComponent()
  System.Boolean get_groupEnabled()
  System.Int32 get_groupId()
  Beyond.Input.IBindingGroupTarget get_parentTarget()
  Beyond.Input.InputBindingGroupMonoTarget get_parent()
  System.Void set_parent(Beyond.Input.InputBindingGroupMonoTarget value)
  System.Void InitBinding()
  System.Void OnInteractableChanged()
  System.Void _UpdateState()
  System.String get_bindingViewActionId()
  System.String get_customBindingViewLabelText()
  System.Void set_customBindingViewLabelText(System.String value)
  System.String get_bindingViewLabelText()
  System.String get_hintText()
  Beyond.DisposedUnityEvent get_bindingViewUpdateEvent()
  UnityEngine.RectTransform get_redDotTrans()
  System.Boolean get_bindingEnabled()
  Beyond.Input.BindingViewState get_bindingViewState()
  System.String GetBindingViewActionId(Beyond.Input.BindingViewActionType actionType)
  System.Void Beyond.Input.IBindingView.OnInputKeyDown()
  System.Void Beyond.Input.IBindingView.OnInputKeyUp()
  System.Void _OnUpdateKey()
  System.String _GetUIButtonKeyHintActionId(Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> buttonEvent)
  Beyond.UI.LuaPanel get_panel()
  System.Int32 get_hoverBindingGroupId()
  System.Void _RefreshHoverEnableNode(System.Boolean active)
  System.Boolean GetMouseActionHints(System.String& clickHintTextId, System.String& longPressHintTextId)
  System.Void OnNaviTargetEnabledAgain()
  Beyond.Input.ActionOnSetNaviTarget get_actionOnSetNaviTarget()
  System.Void _OnSetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode)
  System.Int32 get_hoverConfirmBindingId()
  System.Void set_hoverConfirmBindingId(System.Int32 value)
  System.Void _InitActionOnSetNaviTarget()
  System.Void _ToggleNaviInputBinding(System.Boolean active)
  System.Void ChangeActionOnSetNaviTarget(Beyond.Input.ActionOnSetNaviTarget action)
  System.Void .ctor()
  System.Boolean Beyond.Input.IBindingView.get_interactable()
  System.Void <InitBinding>b__81_0()
  System.Void <InitBinding>b__81_1()
  System.Void <InitBinding>b__81_2()
  System.Void <InitBinding>b__81_3()
  System.Void <InitBinding>b__81_4()
  System.Void <_InitActionOnSetNaviTarget>b__130_0()
  System.Void <>iFixBaseProxy_OnPointerDown(UnityEngine.EventSystems.PointerEventData P0)
  System.Void <>iFixBaseProxy_OnPointerUp(UnityEngine.EventSystems.PointerEventData P0)
  System.Void <>iFixBaseProxy_Awake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_OnDestroy()
  System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0)
  System.Void <>iFixBaseProxy_OnInteractableChanged()
  System.Void <>iFixBaseProxy__RefreshHoverEnableNode(System.Boolean P0)
  System.Boolean <>iFixBaseProxy_GetMouseActionHints(System.String& P0, System.String& P1)
  System.Void <>iFixBaseProxy_OnNaviTargetEnabledAgain()
  System.Void <>iFixBaseProxy__OnSetAsNaviTarget(System.Boolean P0, System.Boolean P1)
END_CLASS

CLASS: Beyond.UI.CanvasMatchMode
TYPE:  struct
TOKEN: 0x200007E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.CanvasMatchMode       Width  // 0x0
  public    static  Beyond.UI.CanvasMatchMode       Height  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UICanvasScaleHelper
TYPE:  class
TOKEN: 0x200007F
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Boolean                  _useCustomStandardResolution  // 0x18
  private           UnityEngine.Vector2             _customStandardResolution  // 0x1C
  private           System.Single                   _customPCReferenceResolutionScale  // 0x24
  private           System.Collections.Generic.HashSet<UnityEngine.Canvas>m_canvasList  // 0x28
  private           System.Collections.Generic.HashSet<UnityEngine.UI.CanvasScaler>m_canvasScalerList  // 0x30
  private           System.Boolean                  m_isCanvasChanged  // 0x38
  public            System.Boolean                  isSingleCanvas  // 0x39
  public            UnityEngine.Camera              uiCamera  // 0x40
  public            Beyond.DisposedUnityEvent       onScreenSizeChanged  // 0x48
  public            Beyond.DisposedUnityEvent       onCanvasChanged  // 0x50
METHODS:
  System.Single get_standardHorizontalResolution()
  System.Single get_standardVerticalResolution()
  System.Single get_standardResolutionScale()
  System.Collections.Generic.HashSet<UnityEngine.UI.CanvasScaler> get_canvasScalerList()
  System.Void Awake()
  System.Void Start()
  System.Void OnDestroy()
  System.Void UpdateCanvas()
  System.Void OnScreenSizeChanged(System.Int32 width, System.Int32 height)
  System.Void AddCanvas(UnityEngine.Canvas c, UnityEngine.UI.CanvasScaler s)
  System.Void RemoveCanvas(UnityEngine.Canvas c, UnityEngine.UI.CanvasScaler s)
  System.Void _OnInputTypeChanged()
  System.Void _CanvasOnWillRenderCanvases()
  Beyond.UI.UICanvasScaleHelper.FWorldCanvasParams CalcWorldCanvasParams(UnityEngine.Camera camera, UnityEngine.Transform uiRoot, System.Boolean useLocalPos)
  Beyond.UI.UICanvasScaleHelper.FScreenCanvasParams CalcScreenCanvasParams()
  System.Single CalcCurrentScreenRatio(UnityEngine.Vector2& screenSize)
  UnityEngine.Vector2 GetProperCanvasResolution()
  System.Void ForceCanvasUpdate()
  System.Void ClearComponent()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIColorGroup
TYPE:  class
TOKEN: 0x2000082
EXTENDS: NonDrawingGraphic
FIELDS:
  private           UnityEngine.UI.Graphic[]        _colorElements  // 0xB8
  private           UnityEngine.Color               _color  // 0xC0
  private           System.Boolean                  m_isOperating  // 0xD0
  private           System.Collections.Generic.List<Beyond.UI.UIColorGroup.DynEle>m_dynList  // 0xD8
METHODS:
  UnityEngine.Color get_color()
  System.Void set_color(UnityEngine.Color value)
  System.Void AttachGraphic(UnityEngine.UI.Graphic graphic, System.Boolean useStaticColor)
  System.Void AttachGraphicsWithGroup(System.Collections.Generic.List<UnityEngine.UI.Graphic> graphic, System.String groupId)
  System.Void CrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale)
  System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB)
  System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha)
  System.Void _ApplyOptToGraphics(Beyond.UI.UIColorGroup.GraphicOpt opt, Beyond.UI.UIColorGroup.CommonParams param)
  System.Void _CrossFadeAlpha(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param)
  System.Void _CrossFadeColorRGB(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param)
  System.Void _CrossFadeColorAlpha(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param)
  System.Void _SetColor(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_set_color(UnityEngine.Color P0)
  System.Void <>iFixBaseProxy_CrossFadeAlpha(System.Single P0, System.Single P1, System.Boolean P2)
  System.Void <>iFixBaseProxy_CrossFadeColor(UnityEngine.Color P0, System.Single P1, System.Boolean P2, System.Boolean P3, System.Boolean P4)
  System.Void <>iFixBaseProxy_CrossFadeColor(UnityEngine.Color P0, System.Single P1, System.Boolean P2, System.Boolean P3)
END_CLASS

CLASS: Beyond.UI.UIControllerKeyIcon
TYPE:  class
TOKEN: 0x2000086
EXTENDS: MonoBehaviour
FIELDS:
  private           System.String                   _keyIconName  // 0x18
  private           Beyond.UI.UIImage               m_image  // 0x20
  private   static  System.Collections.Generic.List<Beyond.UI.UIControllerKeyIcon>s_iconCache  // 0x0
  private   static  System.Boolean                  s_initialized  // 0x8
METHODS:
  System.Void _TryStaticInit()
  System.Void _OnControllerTypeChange(Beyond.DeviceInfo.ControllerType controllerType)
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void RefreshKeyIcon()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UICustomLayout
TYPE:  class
TOKEN: 0x2000087
EXTENDS: UIBehaviour
FIELDS:
  private           UnityEngine.RectTransform       _dragArea  // 0x18
  public            System.Collections.Generic.List<Beyond.UI.UICustomLayoutHandle>layoutHandles  // 0x20
  private           ZSimpleJSON.JSONArray           m_eventLog  // 0x28
METHODS:
  UnityEngine.RectTransform get_dragArea()
  System.Void Awake()
  System.Boolean IsDirty()
  System.Void ResetToDefault(System.Boolean saveChanges)
  System.Void Save(System.Int32 ratio)
  System.Void _LogEvent(System.Collections.Generic.Dictionary<Beyond.UI.UICustomLayoutElement,Beyond.UI.UICustomLayoutElement.LayoutData> layoutDataMap)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Awake()
END_CLASS

CLASS: Beyond.UI.UICustomLayoutElement
TYPE:  class
TOKEN: 0x2000088
EXTENDS: UIBehaviour
FIELDS:
  private           System.Int32                    _verNum  // 0x18
  private           System.String                   _elementKey  // 0x20
  private           UnityEngine.Transform           _overrideScaleTransform  // 0x28
  private           UnityEngine.CanvasGroup         _overrideCanvasGroup  // 0x30
  private           UnityEngine.RectTransform       _overrideHighlightRect  // 0x38
  public            Beyond.DisposedUnityEvent       onLayoutDataLoaded  // 0x40
  private           Beyond.UI.LuaPanel              m_panel  // 0x48
  private           System.Single                   m_scale  // 0x50
  private           System.Single                   m_alpha  // 0x54
  private           UnityEngine.Vector2             m_position  // 0x58
  private           Beyond.UI.UICustomLayoutElement.LayoutTypem_layoutType  // 0x60
  private           System.Single                   m_defaultScale  // 0x64
  private           System.Single                   m_defaultAlpha  // 0x68
  private           UnityEngine.Vector2             m_defaultPosition  // 0x6C
  private           UnityEngine.RectTransform       m_rectTransform  // 0x78
METHODS:
  System.String get_elementKey()
  UnityEngine.RectTransform get_highlightRect()
  System.Single get_scale()
  System.Void set_scale(System.Single value)
  System.Single get_alpha()
  System.Void set_alpha(System.Single value)
  UnityEngine.Vector2 get_position()
  System.Void set_position(UnityEngine.Vector2 value)
  Beyond.UI.UICustomLayoutElement.LayoutType get_layoutType()
  System.Void set_layoutType(Beyond.UI.UICustomLayoutElement.LayoutType value)
  Beyond.UI.LuaPanel get_panel()
  System.Void Awake()
  System.Void Start()
  System.Void OnDestroy()
  System.Void ResetToDefault()
  System.Void _ApplyPosition()
  System.Void _ApplyAlpha()
  System.Void _ApplyScale()
  System.Void _SetDefaultValues()
  System.String GetElementKeyWithRatio(System.Int32 ratio)
  System.Boolean _CheckElementKeyIsValid()
  System.Boolean SaveData(Beyond.UI.UICustomLayoutElement.LayoutData& layoutData, System.Boolean isResetToDefault, System.Int32 ratio)
  System.Void LoadData()
  System.Void _OnHudLayoutSaved()
  UnityEngine.Vector2 _GetMarginSize()
  System.Void ClearComponent()
  System.Void RefreshAll()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Awake()
  System.Void <>iFixBaseProxy_Start()
  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UICustomLayoutHandle
TYPE:  class
TOKEN: 0x200008B
EXTENDS: UIBehaviour
FIELDS:
  public            Beyond.DisposedUnityEvent       onClick  // 0x18
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onBeginDrag  // 0x20
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onDrag  // 0x28
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onEndDrag  // 0x30
  public            System.String                   hintTextId  // 0x38
  private           Beyond.UI.LuaPanel              m_panel  // 0x40
  private           System.Single                   m_scale  // 0x48
  private           System.Single                   m_alpha  // 0x4C
  private           UnityEngine.Vector2             m_position  // 0x50
  private           Beyond.UI.UICustomLayoutElement.LayoutTypem_layoutType  // 0x58
  private           UnityEngine.Vector2             m_defaultPosition  // 0x5C
  private           System.Boolean                  m_isChanged  // 0x64
  private           System.Boolean                  m_isResetToDefault  // 0x65
  private           UnityEngine.RectTransform       m_rectTransform  // 0x68
  private           UnityEngine.RectTransform       m_parentRectTransform  // 0x70
  private           Beyond.UI.UICustomLayoutElement m_element  // 0x78
  private           Beyond.UI.UICustomLayout        m_layout  // 0x80
  private           UnityEngine.Vector2             m_dragPosMin  // 0x88
  private           UnityEngine.Vector2             m_dragPosMax  // 0x90
  private           UnityEngine.Vector3[]           m_dragAreaCorners  // 0x98
  private           UnityEngine.Vector3[]           m_highlightCorners  // 0xA0
  private           System.Boolean                  m_isPosRangeDirty  // 0xA8
  private           UnityEngine.Vector2             m_dragOffset  // 0xAC
METHODS:
  System.Single get_scale()
  System.Void set_scale(System.Single value)
  System.Single get_alpha()
  System.Void set_alpha(System.Single value)
  UnityEngine.Vector2 get_position()
  System.Void set_position(UnityEngine.Vector2 value)
  Beyond.UI.UICustomLayoutElement.LayoutType get_layoutType()
  System.Void set_layoutType(Beyond.UI.UICustomLayoutElement.LayoutType value)
  Beyond.UI.LuaPanel get_panel()
  Beyond.UI.UICustomLayoutElement get_Element()
  System.Void Awake()
  System.Void OnDestroy()
  System.Void _OnElementDataLoaded()
  System.Void _CalculatePositionRange()
  System.Void _ApplyPosition()
  System.Void _ApplyAlpha()
  System.Void _ApplyScale()
  System.Void _ApplyLayoutType()
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Boolean Save(Beyond.UI.UICustomLayoutElement.LayoutData& layoutData, System.Int32 ratio)
  System.Void ResetToDefault()
  System.Boolean IsDirty()
  System.Void _SetChanged(System.Boolean changed)
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void _OnSystemDisplaySizeChanged()
  System.Void ClearComponent()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Awake()
  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UIDialogText
TYPE:  class
TOKEN: 0x200008C
EXTENDS: TickableUIMono
FIELDS:
  protected         Beyond.UI.UIText                _uiText  // 0x68
  private           System.Single                   _textRevealSpeed  // 0x70
  private           System.Boolean                  _autoPlay  // 0x74
  private           Beyond.UI.UIDialogText.UpdateMode_updateMode  // 0x78
  private           System.Boolean                  _useAutoScroll  // 0x7C
  private           System.Single                   _originalHeight  // 0x80
  private           System.Boolean                  _useAspectRatio  // 0x84
  private           System.Single                   _autoScrollSpeed  // 0x88
  private           System.Single                   _autoWaitTime  // 0x8C
  private           System.Single                   _maxAspectRatio  // 0x90
  private           System.Single                   _minAspectRatio  // 0x94
  private           System.Single                   _maxAspectRatioScrollSpeed  // 0x98
  private           System.Single                   _minAspectRatioScrollSpeed  // 0x9C
  private           System.Single                   _maxAspectRatioWaitTime  // 0xA0
  private           System.Single                   _minAspectRatioWaitTime  // 0xA4
  private           System.Boolean                  m_playing  // 0xA8
  private           System.Int32                    m_revealedCharNum  // 0xAC
  private           System.Int32                    m_totalCharNum  // 0xB0
  private           System.Single                   m_timeToNextCharacter  // 0xB4
  protected         System.String                   m_curText  // 0xB8
  private           System.Boolean                  m_hasScrolled  // 0xC0
  private           System.Single                   m_startTime  // 0xC4
  private           System.Boolean                  m_scrollHasEnd  // 0xC8
  private           System.Boolean                  m_needAutoScroll  // 0xC9
  private           UnityEngine.Vector2             m_targetPos  // 0xCC
  private           UnityEngine.Vector2             m_originalPos  // 0xD4
  private           System.Single                   m_percent  // 0xDC
  private           System.Boolean                  m_locked  // 0xE0
METHODS:
  Beyond.TickType get_tickOption()
  System.Boolean get_useAspectRatio()
  System.Boolean get_notUseAspectRatio()
  System.Boolean get_playing()
  Beyond.UI.UIText get_uiText()
  System.Int32 get_totalCharacterNum()
  System.Void OnAwake()
  System.Void Start()
  System.Void OnDisable()
  System.Void OnEnable()
  System.Void Tick(System.Single deltaTime)
  System.Void OnVisibleCharactersChanged(System.Int32 count)
  System.Single GetScrollSpeed()
  System.Single GetAutoWaitTime()
  System.Void _UpdateTextAuto()
  System.Void _TryAutoScroll()
  System.Void RefreshAutoScrollData()
  System.Void SetText(System.String text)
  System.Void _RefreshPosY()
  System.Void SeekToEnd()
  System.Void RefreshText()
  System.Void Play()
  System.Void ResetPlay()
  System.Void StopPlay()
  System.Void ManualUpdateByPercent(System.Single percent)
  System.Void ManualUpdateByTime(System.Single time)
  System.Single GetDisplayAllCharactersTime()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIDialogTextWithCursor
TYPE:  class
TOKEN: 0x200008E
EXTENDS: UIDialogText
FIELDS:
  private           System.Single                   _textGapTime  // 0xE8
  private           Beyond.UI.UIAnimationWrapper    _cursorAnimation  // 0xF0
  private           UnityEngine.RectTransform       _cursorLoopHide  // 0xF8
  private           UnityEngine.RectTransform       _cursorGroup  // 0x100
  private           Beyond.UI.UIImage               _background  // 0x108
  public            System.Boolean                  isLastTextLine  // 0x110
  private           System.Int32                    m_lastCount  // 0x114
METHODS:
  System.Void ResetPlay()
  System.Void OnVisibleCharactersChanged(System.Int32 count)
  System.Single GetDisplayAllCharactersTime()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_ResetPlay()
  System.Void <>iFixBaseProxy_OnVisibleCharactersChanged(System.Int32 P0)
  System.Single <>iFixBaseProxy_GetDisplayAllCharactersTime()
END_CLASS

CLASS: Beyond.UI.EasyUIOptionData
TYPE:  class
TOKEN: 0x200008F
FIELDS:
  public            System.Int32                    index  // 0x10
  public            System.String                   optionIcon  // 0x18
  public            System.String                   optionText  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIDialogTimelineOptionCell
TYPE:  class
TOKEN: 0x2000090
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.UI.UIImage               _optionIcon  // 0x18
  private           Beyond.UI.UIText                _optionText  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIDialogTimelineText
TYPE:  class
TOKEN: 0x2000091
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.UI.UIDialogText          _dialogText  // 0x18
  private           Beyond.UI.UIText                _actorName  // 0x20
  private           UnityEngine.GameObject          _waitNode  // 0x28
  private           Beyond.UI.UIAnimationWrapper    _radioNode  // 0x30
  private           Beyond.UI.UIImage               _iconImage  // 0x38
  private           Beyond.UI.UIImage               _iconBlueMask  // 0x40
  public            Beyond.UI.UIText                centerText  // 0x48
  private           System.String                   m_currentRadioIcon  // 0x50
  private           UnityEngine.CanvasGroup         m_canvasGroup  // 0x58
METHODS:
  UnityEngine.CanvasGroup get_canvasGroup()
  Beyond.UI.UIDialogText get_dialogText()
  Beyond.UI.UIText get_actorName()
  UnityEngine.GameObject get_waitNode()
  System.Void UpdateAlpha(System.Single alpha)
  System.Void SetRadioIcon(System.Boolean useRadio, System.String radioIcon)
  System.Void _ClearRadioIcon()
  System.Void .ctor()
  System.Void <_ClearRadioIcon>b__19_0()
END_CLASS

CLASS: Beyond.UI.UIDrag
TYPE:  class
TOKEN: 0x2000092
EXTENDS: UIBehaviour
FIELDS:
  private           UnityEngine.RectTransform       _dragArea  // 0x18
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onBeginDrag  // 0x20
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onEndDrag  // 0x28
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onDrag  // 0x30
  private           UnityEngine.RectTransform       m_rectTransform  // 0x38
  private           UnityEngine.RectTransform       m_parentRectTransform  // 0x40
  private           UnityEngine.Vector2             m_dragOffset  // 0x48
  private           UnityEngine.Vector2             m_dragPosMin  // 0x50
  private           UnityEngine.Vector2             m_dragPosMax  // 0x58
  private           UnityEngine.Vector3[]           m_dragAreaCorners  // 0x60
  private           UnityEngine.Canvas              m_canvas  // 0x68
METHODS:
  System.Void Awake()
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void ApplyDragArea()
  System.Void ClearComponent()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Awake()
END_CLASS

CLASS: Beyond.UI.UIDragHandler
TYPE:  class
TOKEN: 0x2000093
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Int32                    _dragThreshold  // 0x18
  private           UnityEngine.Vector2             m_startPressPos  // 0x1C
  private           System.Boolean                  m_isDragThresholdMet  // 0x24
  private           System.Boolean                  m_isDragging  // 0x25
  public            Beyond.UI.UIButton              button  // 0x28
  public            System.Boolean                  ignoreDragOnLongPress  // 0x30
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onBeginDrag  // 0x38
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onDrag  // 0x40
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onEndDrag  // 0x48
METHODS:
  System.Int32 get_dragThreshold()
  System.Void ClearComponent()
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIDragItem
TYPE:  class
TOKEN: 0x2000094
EXTENDS: UIBehaviour
FIELDS:
  public    static  UnityEngine.RectTransform       s_commonDragObjectParent  // 0x0
  private           XLua.LuaTable                   <luaTable>k__BackingField  // 0x18
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onBeginDragEvent  // 0x20
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onDragEvent  // 0x28
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onDragEventWhenCantStartDrag  // 0x30
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onEndDragEvent  // 0x38
  public            UnityEngine.Events.UnityEvent<UnityEngine.GameObject,UnityEngine.GameObject>onUpdateDragObject  // 0x40
  public            System.Boolean                  canStartDrag  // 0x48
  private           System.Boolean                  _endDragOnDisable  // 0x49
  public            System.Boolean                  disableDrag  // 0x4A
  private           System.Boolean                  _isInScrollList  // 0x4B
  private           System.Boolean                  _hideDragObjectInScrollList  // 0x4C
  private           UnityEngine.GameObject          _dragPrefab  // 0x50
  private           UnityEngine.RectTransform       _dragObjectParent  // 0x58
  public            UnityEngine.Vector2             dragPivot  // 0x60
  private           UnityEngine.UI.Image            _draggingHintImage  // 0x68
  private           UnityEngine.CanvasGroup         _draggingHintCanvasGroup  // 0x70
  private           UnityEngine.GameObject          _draggingHintObject  // 0x78
  private           Beyond.UI.LuaPanel              m_panel  // 0x80
  private           UnityEngine.RectTransform       m_rect  // 0x88
  private           Beyond.UI.UIScrollRect          m_scrollRect  // 0x90
  private           System.Boolean                  m_isInScroll  // 0x98
  private           UnityEngine.GameObject          m_curDragObj  // 0xA0
  private           System.Boolean                  m_inDragging  // 0xA8
  private           UnityEngine.Color               m_draggingHintImageOriColor  // 0xAC
  private           UnityEngine.Coroutine           m_dragOnDisableCoroutine  // 0xC0
METHODS:
  XLua.LuaTable get_luaTable()
  System.Void set_luaTable(XLua.LuaTable value)
  System.Boolean get_inDragging()
  Beyond.UI.LuaPanel get_panel()
  UnityEngine.RectTransform get_m_dragParentRect()
  UnityEngine.GameObject get_curDragObj()
  System.Void Awake()
  System.Void Start()
  System.Void OnDisable()
  System.Collections.IEnumerator _ContinueDragOnDisable()
  System.Void OnDestroy()
  System.Void OnEnable()
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void _StopDragView()
  System.Void ClearComponent()
  System.Void ClearEvents()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Awake()
  System.Void <>iFixBaseProxy_Start()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_OnDestroy()
  System.Void <>iFixBaseProxy_OnEnable()
END_CLASS

CLASS: Beyond.UI.UIDropdown
TYPE:  class
TOKEN: 0x2000096
EXTENDS: Selectable
FIELDS:
  public            UnityEngine.Events.UnityEvent<System.Int32>onSelectCell  // 0x180
  public            UnityEngine.Events.UnityEvent<System.Int32,Beyond.UI.UIDropdownOption,System.Boolean>onUpdateCell  // 0x188
  public            UnityEngine.Events.UnityEvent<System.Int32,Beyond.UI.UIDropdown>onUpdateCaption  // 0x190
  public            UnityEngine.Events.UnityEvent<System.Boolean>onToggleOptList  // 0x198
  public            System.Func<System.Int32,System.Int32,System.Boolean>onValidateSelectCell  // 0x1A0
  public            Beyond.UI.UIText                captionText  // 0x1A8
  public            Beyond.UI.UIImage               captionIcon  // 0x1B0
  private           System.Int32                    <selectedIndex>k__BackingField  // 0x1B8
  private           System.Int32                    <optionCount>k__BackingField  // 0x1BC
  private           System.Boolean                  <isListActive>k__BackingField  // 0x1C0
  private           Beyond.UI.UIDropdownOption      _optionTemplate  // 0x1C8
  private           UnityEngine.Transform           _arrowImageTrans  // 0x1D0
  private           UnityEngine.RectTransform       _listContainer  // 0x1D8
  private           System.Single                   _listContainerMaxHeight  // 0x1E0
  private           System.Single                   _animationTime  // 0x1E4
  private           UnityEngine.RectTransform       _selfArea  // 0x1E8
  private           UnityEngine.RectTransform       _maskRect  // 0x1F0
  private           System.Boolean                  _autoCloseOnSelect  // 0x1F8
  private           System.String                   _audioToggleOn  // 0x200
  private           System.String                   _audioToggleOff  // 0x208
  private           System.String                   _audioInvalid  // 0x210
  private           System.String                   _audioNavigation  // 0x218
  private           System.Collections.Generic.List<Beyond.UI.UIDropdownOption>m_options  // 0x220
  private           Beyond.UI.LuaPanel              m_panel  // 0x228
  private           UnityEngine.UI.LayoutGroup      m_content  // 0x230
  private           UnityEngine.Camera              m_fallbackUICamera  // 0x238
  private           Beyond.UI.UIScrollRect          m_listScrollRect  // 0x240
  private           UnityEngine.CanvasGroup         m_listContainerCanvasGroup  // 0x248
  public            System.String                   openDropDownActionId  // 0x250
  private           System.Int32                    m_bindingGroupId  // 0x258
  private           System.Int32                    m_naviBindingGroupId  // 0x25C
  private           Beyond.UI.LuaPanel              m_luaPanel  // 0x260
  private           Beyond.UI.UISelectableNaviGroup m_listNaviGroup  // 0x268
  private           Beyond.Input.IBindingGroupTarget<parentTarget>k__BackingField  // 0x270
METHODS:
  System.Int32 get_selectedIndex()
  System.Void set_selectedIndex(System.Int32 value)
  System.Int32 get_optionCount()
  System.Void set_optionCount(System.Int32 value)
  System.Boolean get_isListActive()
  System.Void set_isListActive(System.Boolean value)
  Beyond.UI.LuaPanel get_panel()
  System.Void Awake()
  System.Void _NotifyIsHover(System.Boolean isHover)
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void Init(UnityEngine.Events.UnityAction<System.Int32,Beyond.UI.UIDropdownOption,System.Boolean> onUpdateCell, UnityEngine.Events.UnityAction<System.Int32> onSelectCell, UnityEngine.Events.UnityAction<System.Int32,Beyond.UI.UIDropdown> onUpdateCaption)
  System.Void ToggleOptions(System.Boolean activeList)
  System.Void _ToggleOptions(System.Boolean activeList, System.Boolean isInit)
  System.Void Update()
  System.Void SetSelected(System.Int32 index, System.Boolean forceUpdate, System.Boolean needNotifySelect, System.Boolean validateSelect)
  System.Void ScrollToSelected()
  System.Void Refresh(System.Int32 count, System.Int32 newSelectedIndex, System.Boolean needNotifySelect)
  System.Void ClearComponent()
  UnityEngine.Camera _GetUICamera()
  System.Int32 get_groupId()
  Beyond.Input.IBindingGroupTarget get_parentTarget()
  System.Void set_parentTarget(Beyond.Input.IBindingGroupTarget value)
  System.Boolean get_groupEnabled()
  System.Void _InitBinding()
  System.Void _ControllerToggle()
  System.Void _ControllerCancel()
  UnityEngine.UI.Selectable _GetDefaultNaviTarget()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Awake()
  System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0)
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UIDropdownOption
TYPE:  class
TOKEN: 0x2000099
EXTENDS: MonoBehaviour
FIELDS:
  public            Beyond.UI.UIButton              button  // 0x18
  public            Beyond.UI.UIText                label  // 0x20
  public            Beyond.UI.UIText                secondLabel  // 0x28
  public            Beyond.UI.UIImage               icon  // 0x30
  public            UnityEngine.GameObject          selectedNode  // 0x38
  public            UnityEngine.GameObject          notSelectedNode  // 0x40
  public            Beyond.UI.UIState.UIStateControllerstateController  // 0x48
  public            UnityEngine.GameObject          stripeNode  // 0x50
  public            System.Boolean                  stripeIsTop  // 0x58
METHODS:
  System.Void SetText(System.String text)
  System.Void SetState(System.String stateName)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.CommonDropHintType
TYPE:  struct
TOKEN: 0x200009A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.CommonDropHintType    None  // 0x0
  public    static  Beyond.UI.CommonDropHintType    Square  // 0x0
  public    static  Beyond.UI.CommonDropHintType    Circle  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UIDropItem
TYPE:  class
TOKEN: 0x200009B
EXTENDS: UIBehaviour
FIELDS:
  private           XLua.LuaTable                   <luaTable>k__BackingField  // 0x18
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onDropEvent  // 0x20
  public            UnityEngine.Events.UnityEvent<System.Boolean>onToggleHighlight  // 0x28
  public            System.Action                   onDestroy  // 0x30
  public            Beyond.UI.CommonDropHintType    commonDropHintType  // 0x38
  private           UnityEngine.GameObject          _highlightHint  // 0x40
  private           System.Boolean                  _scaleWhenHighlight  // 0x48
  private           System.Single                   _scaleWhenActive  // 0x4C
  private           System.Boolean                  _useUIState  // 0x50
  private           Beyond.UI.UIStyleByState.StateConfig_stateConfigNormal  // 0x58
  private           Beyond.UI.UIStyleByState.StateConfig_stateConfigHilight  // 0x60
  private           UnityEngine.UI.Selectable       m_selectable  // 0x68
  private           UnityEngine.RectTransform       m_rectTransform  // 0x70
  private           System.Single                   m_oriScale  // 0x78
  private           System.Boolean                  m_isInHighlight  // 0x7C
METHODS:
  XLua.LuaTable get_luaTable()
  System.Void set_luaTable(XLua.LuaTable value)
  System.Void ClearEvents()
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void ToggleHighlight(System.Boolean active, System.Boolean forceToggle)
  System.Void OnDrop(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void ClearComponent()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Awake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UIElementFollower
TYPE:  class
TOKEN: 0x200009C
EXTENDS: TickableUIMono
FIELDS:
  private           System.Boolean                  _followMouse  // 0x68
  public            System.Boolean                  followFixedPos  // 0x69
  private           UnityEngine.Transform           _targetTransform  // 0x70
  private           UnityEngine.Vector3             _followPosition  // 0x78
  private           System.Boolean                  _changeScale  // 0x84
  private           UnityEngine.AnimationCurve      _scaleCurve  // 0x88
  public            UnityEngine.Vector3             displayOffset  // 0x90
  public            UnityEngine.Vector3             displayUIOffset  // 0x9C
  private   static readonly Unity.Profiling.ProfilerMarker  UPDATE_POSITION_MARKER  // 0x0
  public            Beyond.DisposedUnityEvent       onExitScreen  // 0xA8
  public            Beyond.DisposedUnityEvent       onEnterScreen  // 0xB0
  private           System.Boolean                  <inScreen>k__BackingField  // 0xB8
  private           Beyond.UI.LuaPanel              m_panel  // 0xC0
  private           UnityEngine.RectTransform       m_rectTransform  // 0xC8
METHODS:
  Beyond.TickType get_tickOption()
  UnityEngine.Vector3 get_followPosition()
  System.Void set_followPosition(UnityEngine.Vector3 value)
  UnityEngine.Transform get_targetTransform()
  System.Void set_targetTransform(UnityEngine.Transform value)
  System.Void set_inScreen(System.Boolean value)
  System.Boolean get_inScreen()
  Beyond.UI.LuaPanel get_panel()
  System.Void OnAwake()
  System.Void OnEnable()
  System.Void LateTick(System.Single deltaTime)
  System.Void UpdatePosition()
  System.Void UpdatePosition(UnityEngine.Vector3 worldPos)
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIExtendScrollRect
TYPE:  class
TOKEN: 0x200009D
EXTENDS: MonoBehaviour
FIELDS:
  public            Beyond.UI.UIScrollRect          baseScrollRect  // 0x18
  private           System.Boolean                  _enableDrag  // 0x20
  private           Beyond.UI.UIScrollList          _extendScrollList  // 0x28
METHODS:
  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.IUIFoldoutComp
TYPE:  interface
TOKEN: 0x200009E
FIELDS:
METHODS:
  System.Boolean get_defaultFoldOut()
  System.Void Refresh(System.Int32 index)
  System.Void OnFoldOut(System.Boolean fastMode)
  System.Void OnFoldIn(System.Boolean fastMode)
END_CLASS

CLASS: Beyond.UI.UIFoldoutComponent
TYPE:  class
TOKEN: 0x200009F
EXTENDS: MonoBehaviour
FIELDS:
  protected         UnityEngine.GameObject          _foldContent  // 0x18
  protected         Beyond.UI.UINonUnifiedScrollList_nonUnifiedScrollList  // 0x20
  public            System.Single                   foldInSize  // 0x28
  public            System.Single                   duration  // 0x2C
  public            DG.Tweening.Ease                easeType  // 0x30
  protected         System.Boolean                  m_isFoldOut  // 0x34
  private           DG.Tweening.Tweener             m_tween  // 0x38
  protected         System.Int32                    m_index  // 0x40
METHODS:
  System.Void Refresh(System.Int32 index)
  System.Boolean get_defaultFoldOut()
  System.Void OnFoldOut(System.Boolean fastMode)
  System.Void OnFoldIn(System.Boolean fastMode)
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIGraphicAnimation
TYPE:  class
TOKEN: 0x20000A2
EXTENDS: TickableUIMono
FIELDS:
  private   static  System.Int32                    s_vfxMainTextSTId  // 0x0
  private   static  System.Int32                    s_tintColorAlpha  // 0x4
  private           UnityEngine.UI.MaskableGraphic  _graphic  // 0x68
  private           UnityEngine.Material            _material  // 0x70
  private           System.Single                   _alpha  // 0x78
  private           UnityEngine.Vector2             _scale  // 0x7C
  private           UnityEngine.Material            m_materialInstance  // 0x88
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnAwake()
  System.Void OnRelease()
  System.Void LateTick(System.Single deltaTime)
  System.Void _Init()
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnRelease()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIGridLayoutGroup
TYPE:  class
TOKEN: 0x20000A3
EXTENDS: GridLayoutGroup
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIGridLayoutNaviWrapper
TYPE:  class
TOKEN: 0x20000A4
EXTENDS: UIBehaviour
FIELDS:
  private           UnityEngine.UI.GridLayoutGroup  _gridLayoutGroup  // 0x18
  private           UnityEngine.UI.LayoutGroup      _layoutGroup  // 0x20
  private           Beyond.UI.UIGridLayoutNaviWrapper.WrapMode_wrapMode  // 0x28
  private           Beyond.UI.UIScrollRect          _scrollRect  // 0x30
  private           Beyond.UI.UISelectableNaviGroup _naviGroup  // 0x38
  private           System.Boolean                  _enableCircleWrapNavigation  // 0x40
  private           System.Boolean                  m_isInited  // 0x41
  private           System.Boolean                  m_isVertical  // 0x42
  private           UnityEngine.UI.LayoutGroup      m_layoutGroup  // 0x48
  private           System.Collections.Generic.List<UnityEngine.UI.Selectable>m_wrapNaviSelectables  // 0x50
METHODS:
  System.Void _InitIfNot()
  System.Void Start()
  System.Boolean TryWrapNavigate(UnityEngine.UI.NaviDirection dir)
  System.Void _InitWrapNavigation()
  System.Void _NaviGridLayout(UnityEngine.UI.NaviDirection dir)
  System.Boolean _NaviGridLayoutImpl(UnityEngine.UI.NaviDirection dir, System.Boolean enableCircleWrapNavigation)
  System.Boolean _NaviGridLayoutInit(System.Boolean isBefore, System.Boolean enableCircleWrapNavigation)
  System.Boolean _NaviChildren(System.Int32 curIndex, System.Int32 childCount, System.Boolean isBefore, System.Boolean enableCircleWrapNavigation)
  UnityEngine.UI.Selectable _FindValidSelectable(System.Boolean isBefore)
  System.Void _SetCircleWrapScroll(System.Boolean isBefore)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Start()
END_CLASS

CLASS: Beyond.UI.UIGyroscopeEffect
TYPE:  class
TOKEN: 0x20000A6
EXTENDS: TickableUIMono
FIELDS:
  public            System.Boolean                  enableDetect  // 0x68
  public            System.Single                   mobileGravityScaler  // 0x6C
  public            Beyond.UI.UIGyroscopeEffect.Paramx  // 0x70
  public            Beyond.UI.UIGyroscopeEffect.Paramy  // 0x78
  public            DG.Tweening.Ease                ease  // 0x80
  public            System.Single                   time  // 0x84
  private           Cinemachine.CinemachineVirtualCameram_vcam  // 0x88
  private           Beyond.UI.CinemachineGyroscopeEffectm_vcamGyroscopeEffect  // 0x90
  private           System.Boolean                  m_isVcamMode  // 0x98
  private           System.Single                   m_baseGravityY  // 0x9C
  private           System.Single                   m_baseGravityYAccumulatedTime  // 0xA0
  private           System.Single                   m_lastGravityY  // 0xA4
  public            DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions>handler  // 0xA8
  public            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions>tween  // 0xB0
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnAwake()
  System.Void Tick(System.Single deltaTime)
  System.Void OnRelease()
  System.Void .ctor()
  UnityEngine.Vector3 <Tick>b__18_0()
  System.Void <Tick>b__18_1(UnityEngine.Vector3 value)
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.UIHighlightMask
TYPE:  class
TOKEN: 0x20000A8
EXTENDS: TickableUIMono
FIELDS:
  private           UnityEngine.RectTransform       _up  // 0x68
  private           UnityEngine.RectTransform       _down  // 0x70
  private           UnityEngine.RectTransform       _left  // 0x78
  private           UnityEngine.RectTransform       _right  // 0x80
  private           UnityEngine.RectTransform       m_rect  // 0x88
  private           Beyond.UI.LuaPanel              m_panel  // 0x90
METHODS:
  Beyond.TickType get_tickOption()
  Beyond.UI.LuaPanel get_panel()
  System.Void OnAwake()
  System.Void OnEnable()
  System.Void Tick(System.Single deltaTime)
  System.Void TrySyncRect()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIImage
TYPE:  class
TOKEN: 0x20000A9
EXTENDS: Image
FIELDS:
  private           System.Int32                    _atlasHandleId  // 0x190
  private           Beyond.UI.UIAtlasManager.UIAtlasHandlem_atlasHandle  // 0x194
  private           System.Action                   m_onEnableRuntimeAtlas  // 0x1B8
  private           Beyond.UI.LuaPanel              m_panel  // 0x1C0
  private           System.Boolean                  m_hasBeenEnabled  // 0x1C8
  private           System.String                   m_cachedSpritePath  // 0x1D0
  protected         Beyond.Resource.FAssetProxyHandlem_spriteResHandle  // 0x1D8
  protected         Beyond.Resource.FAssetProxyHandlem_matResHandle  // 0x1EC
  public    static  System.String                   SPRITE_PATH_FORMAT  // 0x0
  public    static  System.String                   SPRITE_ROOT_PATH_FORMAT  // 0x0
  public            System.Boolean                  enableAutoImgUsePathReference  // 0x200
  public            System.Boolean                  imgUsePathReference  // 0x201
  public            System.String                   imgRefPath  // 0x208
  private           System.Boolean                  m_imgIsPathReference  // 0x210
METHODS:
  System.Boolean get_packIntoRuntimeAtlas()
  System.Void set_packIntoRuntimeAtlas(System.Boolean value)
  System.Int32 get_atlasHandleId()
  System.Void set_atlasHandleId(System.Int32 value)
  Beyond.UI.LuaPanel get_panel()
  Beyond.UI.UIAtlasManager.UIAtlasHandle& get_atlasHandle()
  System.Int32 get_panelLevel()
  System.Void RegisterOnEnableRuntimeAtlas(System.Action callBack)
  System.Void UnregisterOnEnableRuntimeAtlas(System.Action callBack)
  System.Void OnEnableRuntimeAtlas()
  System.Void _OnSpriteChanged(UnityEngine.Sprite lastOne)
  System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill)
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void SetNativeSize()
  System.Void SetNativeSizeIgnoreRefScale()
  System.Void LoadSprite(System.String folder, System.String spriteName)
  System.Void LoadSprite(System.String path)
  System.Void LoadSpriteWithOutFormat(System.String path, System.Boolean ignoreEnable)
  System.Void _LoadSprite(System.String path, System.Boolean ignoreEnable)
  System.Void LoadMaterial(System.String path, System.Boolean newInstance)
  System.Void ReleaseSprite()
  System.Void DisposeSpriteHandle()
  UnityEngine.Texture get_mainTexture()
  System.Void _V2AtlasInitialize()
  System.Void .ctor()
  System.Void <>iFixBaseProxy__OnSpriteChanged(UnityEngine.Sprite P0)
  System.Void <>iFixBaseProxy_OnPopulateMesh(UnityEngine.UI.VertexHelper P0)
  System.Void <>iFixBaseProxy_Awake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_OnDestroy()
  System.Void <>iFixBaseProxy_SetNativeSize()
  System.Void <>iFixBaseProxy_ReleaseSprite()
  UnityEngine.Texture <>iFixBaseProxy_get_mainTexture()
END_CLASS

CLASS: Beyond.UI.UIImageBlur
TYPE:  class
TOKEN: 0x20000AA
EXTENDS: TickableUIMono
FIELDS:
  public            System.Single                   scale  // 0x68
  private           UnityEngine.RectTransform       m_rect  // 0x70
  private           System.Single                   m_lastScale  // 0x78
  private           Beyond.UI.UIImage               m_image  // 0x80
  private           UnityEngine.Texture2D           m_srcTex  // 0x88
  private           UnityEngine.RenderTexture       m_tarTex  // 0x90
  private           System.Int32                    m_uiImageBlurTexId  // 0x98
  private           UnityEngine.Rect                m_atlasRect  // 0x9C
  private           System.Action                   m_dynamicCallback  // 0xB0
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnAwake()
  System.Void OnChangeSprite()
  System.Void Tick(System.Single deltaTime)
  System.Void OnDisable()
  System.Void OnRelease()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.UIImageFillAmountOffset
TYPE:  class
TOKEN: 0x20000AB
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.UI.UIImage               m_followImage  // 0x18
  public            System.Single                   fillOffset  // 0x20
  private           System.Single                   m_fillAmount  // 0x24
METHODS:
  System.Single get_fillAmount()
  System.Void set_fillAmount(System.Single value)
  DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOFillAmount(System.Single endValue, System.Single duration)
  System.Void .ctor()
  System.Single <DOFillAmount>b__6_0()
  System.Void <DOFillAmount>b__6_1(System.Single x)
END_CLASS

CLASS: Beyond.UI.UIImageFillFollower
TYPE:  class
TOKEN: 0x20000AC
EXTENDS: TickableUIMono
FIELDS:
  private   static  System.Single                   BACK_FOLLOW_THRESHOLD  // 0x0
  private           Beyond.UI.UIImage               _frontFill  // 0x68
  private           System.Single                   _followSpeed  // 0x70
  private           Beyond.UI.UIImage               m_image  // 0x78
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnAwake()
  System.Void OnEnable()
  System.Void Tick(System.Single deltaTime)
  System.Void RefreshFillAmount()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIImageFillTailFollower
TYPE:  class
TOKEN: 0x20000AD
EXTENDS: TickableUIMono
FIELDS:
  private           Beyond.UI.UIImage               _followImage  // 0x68
  public            System.Single                   followOffset  // 0x70
  private           UnityEngine.RectTransform       m_selfRectTransform  // 0x78
  private           UnityEngine.RectTransform       m_followImageRectTransform  // 0x80
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnAwake()
  System.Void OnEnable()
  System.Void Tick(System.Single deltaTime)
  System.Void RefreshFollower()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIImagePair
TYPE:  class
TOKEN: 0x20000AE
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Collections.Generic.List<Beyond.UI.UIImage>referencedImages  // 0x18
METHODS:
  System.Void LoadSprite(System.String folder, System.String spriteName)
  System.Void LoadSprite(System.String path)
  System.Void set_color(UnityEngine.Color value)
  Beyond.UI.UIImage get_first()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIInertiaViewPager
TYPE:  class
TOKEN: 0x20000AF
EXTENDS: TickableUIMono
FIELDS:
  private           Beyond.UI.UIScrollRect          _scrollRect  // 0x68
  private           System.Single                   _animationDuration  // 0x70
  private           System.Single                   _endScrollSpd  // 0x74
  private           Beyond.UI.UIInertiaViewPager.ScrollEffectConfig.Timing_timing  // 0x78
  private           System.Single                   _minScrollInterval  // 0x7C
  private           System.String                   _audioGear  // 0x80
  private           System.String                   _audioGearLock  // 0x88
  public            System.Boolean                  flingToNextEnable  // 0x90
  public            System.Single                   flingToNextMinSpd  // 0x94
  public            System.Single                   flingToNextMaxSpd  // 0x98
  private           System.Int32                    m_currentPage  // 0x9C
  private           Beyond.UI.UIInertiaViewPager.Statem_state  // 0xA0
  private           Beyond.UI.UIInertiaViewPager.IScrollHandlerm_scrollHandler  // 0xA8
  private           Beyond.UI.UIInertiaViewPager.ScrollEffectTriggerm_effectTrigger  // 0xB0
  private           Beyond.UI.UIInertiaViewPager.BlockerManagerm_blockers  // 0xB8
  private           Beyond.UI.UIInertiaViewPager.DragContextm_dragContext  // 0xC0
  private           System.Int32                    m_fromPage  // 0xC8
  private           System.Int32                    m_toPage  // 0xCC
  private           System.Single                   m_tweenStartTime  // 0xD0
  private           System.Single                   m_tweenStartValue  // 0xD4
  private           System.Single                   m_tweenTargetValue  // 0xD8
  private           System.Boolean                  m_isInited  // 0xDC
  private           System.Int32                    <pageCount>k__BackingField  // 0xE0
  public            Beyond.DisposedUnityEvent<System.Int32>onStateChanged  // 0xE8
METHODS:
  Beyond.TickType get_tickOption()
  System.Void _PlayAudioGear()
  System.Void _PlayAudioGearLock()
  System.Void _InitIfNot()
  System.Boolean get_isUpdating()
  System.Int32 get_pageCount()
  System.Void set_pageCount(System.Int32 value)
  System.Int32 get_currentPage()
  System.Void set_currentPage(System.Int32 value)
  System.Single get_currentScrollIndex()
  System.Void ClearComponent()
  System.Void Tick(System.Single deltaTime)
  System.Void SetPageCount(System.Int32 pageCount, System.Collections.Generic.List<System.Int32> segmentFrames)
  System.Void MoveToPage(System.Int32 pageIndex)
  System.Void OnAwake()
  System.Void OnEnable()
  System.Single _ScrollValue2PageIndex(System.Single value)
  System.Single _PageIndex2ScrollValue(System.Single index)
  System.Int32 _ScrollValueAlignToPage(System.Single value)
  System.Void _SwitchToPage(System.Int32 targetIndex, System.Boolean useTween)
  System.Void _AutoAlign()
  System.Void _OnStateChanged(Beyond.UI.UIInertiaViewPager.State from, Beyond.UI.UIInertiaViewPager.State to)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnEnable()
END_CLASS

CLASS: Beyond.UI.UIInputField
TYPE:  class
TOKEN: 0x20000BD
EXTENDS: TMP_InputField
FIELDS:
  public            System.String                   activeInputActionId  // 0x390
  public            System.String                   deactivateInputActionId  // 0x398
  private           System.Int32                    <activeInputBindingId>k__BackingField  // 0x3A0
  private           System.Int32                    <deactivateInputBindingId>k__BackingField  // 0x3A4
  private           Beyond.UI.LuaPanel              m_panel  // 0x3A8
  public            System.Boolean                  isDebugInputField  // 0x3B0
  private           UnityEngine.Camera              m_fallbackUICamera  // 0x3B8
  private           UnityEngine.GameObject          m_fallbackUIRoot  // 0x3C0
  private           UnityEngine.RectTransform       m_fallbackRectTransform  // 0x3C8
  private           System.Int32                    m_activateBindingGroupId  // 0x3D0
  private           System.Boolean                  m_isNaviFocused  // 0x3D4
  private           Beyond.UI.UIState.UIStateController_uiStateController  // 0x3D8
  private           System.String                   _onFocusStateName  // 0x3E0
  private           System.String                   _onFocusLostStateName  // 0x3E8
  private           System.String                   _audioPressStart  // 0x3F0
  public            UnityEngine.RectTransform       m_keyboardOffsetTarget  // 0x3F8
  public            UnityEngine.RectTransform       m_offsetTargetParent  // 0x400
  public            UnityEngine.RectTransform       m_inputFieldRect  // 0x408
  public            System.Int32                    m_pcDebug  // 0x410
  public            System.Single                   m_keyboardExtraOffsetY  // 0x414
  private           UnityEngine.Vector2             m_baseKeyboardOffsetTarget  // 0x418
  private           UnityEngine.Vector2             m_baseKeyboardLocalPos  // 0x420
  private           System.Single                   m_inputFieldOffsetY  // 0x428
  private           System.Boolean                  m_enableKeyboardOffsetCal  // 0x42C
  private           UnityEngine.Coroutine           m_heightChangeCoroutine  // 0x430
  private           System.Int32                    m_lastHeight  // 0x438
  private           System.Int32                    m_nowHeight  // 0x43C
  public            System.String                   audioOnActive  // 0x440
  private   static  Beyond.UI.UIInputField          s_mFocusedInputField  // 0x0
METHODS:
  System.Int32 get_activeInputBindingId()
  System.Void set_activeInputBindingId(System.Int32 value)
  System.Int32 get_deactivateInputBindingId()
  System.Void set_deactivateInputBindingId(System.Int32 value)
  Beyond.UI.LuaPanel get_panel()
  System.Boolean get_isControllerInputValid()
  System.Void SendOnFocus()
  System.Void SendOnFocusLost()
  System.Void Awake()
  System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void ActivateInputField()
  System.Void DeactivateInputField(System.Boolean clearSelection)
  System.Void OnDestroy()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void _NotifyIsHover(System.Boolean isHover)
  System.Void OnInteractableChanged()
  System.Void _UpdateBindingEnable()
  System.Void ClearComponent()
  UnityEngine.Camera _GetCamera()
  System.Void _VirtualKeyboardOnDestroy()
  System.Void _VirtualKeyboardSelect()
  System.Void _VirtualKeyboardDeselect()
  System.Void _VirtualKeyboardAwake()
  System.Void _UpdateKeyboardOffset(System.Int32 offsetHeight)
  System.Collections.IEnumerator _KeyboardHeightChange(System.Action<System.Int32> onHeightChanged)
  Beyond.UI.UIInputField get_s_focusedInputField()
  System.Void set_s_focusedInputField(Beyond.UI.UIInputField value)
  System.Void .ctor()
  System.Void <Awake>b__27_0()
  System.Void <>iFixBaseProxy_SendOnFocus()
  System.Void <>iFixBaseProxy_SendOnFocusLost()
  System.Void <>iFixBaseProxy_Awake()
  System.Void <>iFixBaseProxy_OnSelect(UnityEngine.EventSystems.BaseEventData P0)
  System.Void <>iFixBaseProxy_OnDeselect(UnityEngine.EventSystems.BaseEventData P0)
  System.Void <>iFixBaseProxy_ActivateInputField()
  System.Void <>iFixBaseProxy_DeactivateInputField(System.Boolean P0)
  System.Void <>iFixBaseProxy_OnDestroy()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0)
  System.Void <>iFixBaseProxy_OnInteractableChanged()
END_CLASS

CLASS: Beyond.UI.UIJoystick
TYPE:  class
TOKEN: 0x20000BF
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.RectTransform       _runBg  // 0x18
  private           UnityEngine.RectTransform       _walkBg  // 0x20
  private           UnityEngine.RectTransform       _thumb  // 0x28
  private           UnityEngine.RectTransform       _directionIndicate  // 0x30
  private           UnityEngine.RectTransform       _walkDirectionIndicate  // 0x38
  private           UnityEngine.RectTransform       _rootCanvas  // 0x40
  private           UnityEngine.RectTransform       _triggerArea  // 0x48
  private           UnityEngine.UI.GraphicRaycaster _raycaster  // 0x50
  private           System.Single                   _walkRation  // 0x58
  private           System.Single                   _autoSprintStartLength  // 0x5C
  private           System.Single                   _autoSprintStopLength  // 0x60
  private           System.Single                   _autoSprintStartAngle  // 0x64
  private           System.Single                   _autoSprintStopAngle  // 0x68
  public            System.Single                   margin  // 0x6C
  public            System.Single                   bgVisibleTimeWhenEnable  // 0x70
  private           System.Single                   m_bgHideTime  // 0x74
  private           System.Boolean                  _isDynamic  // 0x78
  private           Beyond.UI.LuaPanel              m_panel  // 0x80
  private           UnityEngine.Vector2             <jsValue>k__BackingField  // 0x88
  private           Beyond.UI.UITouchPanel          _dynamicArea  // 0x90
  private           System.Boolean                  _dynamicButDontMove  // 0x98
  private           System.Boolean                  _useRewiredPlayerInput  // 0x99
  private           System.String                   _controllerRewiredActionX  // 0xA0
  private           System.String                   _controllerRewiredActionY  // 0xA8
  private           System.String                   _keyboardRewiredActionX  // 0xB0
  private           System.String                   _keyboardRewiredActionY  // 0xB8
  private           System.Boolean                  m_active  // 0xC0
  private           System.Boolean                  m_activatedByTouch  // 0xC1
  public            Beyond.DisposedUnityEvent       onTouchStart  // 0xC8
  public            Beyond.DisposedUnityEvent       onTouchEnd  // 0xD0
  public            Beyond.DisposedUnityEvent       onMoveStart  // 0xD8
  public            Beyond.DisposedUnityEvent<UnityEngine.Vector2>onMove  // 0xE0
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onDrag  // 0xE8
  public            Beyond.DisposedUnityEvent<System.Boolean>onToggleAutoSprint  // 0xF0
  private           UnityEngine.CanvasGroup         m_canvasGroup  // 0xF8
  private           UnityEngine.RectTransform       m_rect  // 0x100
  private           UnityEngine.Vector2             m_oriAnchorMin  // 0x108
  private           UnityEngine.Vector2             m_oriAnchorMax  // 0x110
  private           UnityEngine.Vector2             m_oriAnchorPos  // 0x118
  private           UnityEngine.Vector2             m_oriPivot  // 0x120
  private           System.Boolean                  m_isWalking  // 0x128
  private           System.Boolean                  m_isRunning  // 0x129
  private           System.Boolean                  m_isSprinting  // 0x12A
  private           Beyond.UI.UIAnimationWrapper    m_walkBgAnim  // 0x130
  private           Beyond.UI.UIAnimationWrapper    m_runBgAnim  // 0x138
  private           System.Boolean                  m_isWalkBgVisible  // 0x140
  private           System.Boolean                  m_isRunBgVisible  // 0x141
  private           System.Collections.Generic.List<UnityEngine.InputSystem.UI.ExtendedPointerEventData>m_exPointers  // 0x148
  private           UnityEngine.InputSystem.UI.ExtendedPointerEventDatam_fakePointerEventData  // 0x150
  private           UnityEngine.InputSystem.UI.ExtendedPointerEventDatam_activePointerEventData  // 0x158
  private           Beyond.UI.UICustomLayoutElement m_customLayoutElement  // 0x160
  private           UnityEngine.Vector2             m_lastFrameActiveStickVal  // 0x168
  private           UnityEngine.EventSystems.PointerEventData<curDragEventData>k__BackingField  // 0x170
  private           System.Int32                    m_groupId  // 0x178
  private           System.Boolean                  m_bindingInit  // 0x17C
  private           Beyond.Input.InputBindingGroupMonoTarget<parent>k__BackingField  // 0x180
METHODS:
  Beyond.UI.LuaPanel get_panel()
  System.Boolean get_isDynamic()
  System.Void set_isDynamic(System.Boolean value)
  System.Single get_walkRation()
  System.Void set_walkRation(System.Single value)
  System.Boolean get_active()
  System.Int32 get_activeTouchId()
  UnityEngine.Vector2 get_jsValue()
  System.Void set_jsValue(UnityEngine.Vector2 value)
  System.Single get_m_thumbPosMaxLength()
  UnityEngine.EventSystems.PointerEventData get_curDragEventData()
  System.Void set_curDragEventData(UnityEngine.EventSystems.PointerEventData value)
  System.Void Reset()
  System.Void Awake()
  System.Void OnEnable()
  System.Void Start()
  System.Void OnDestroy()
  System.Void _Tick()
  System.Void OnDisable()
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void CheckShouldActive()
  System.Void _SetVisible(System.Boolean visible)
  System.Void _ChangeDynamic(System.Boolean dynamic, System.Boolean force)
  System.Void _SetRectTransform(System.Boolean toOri)
  System.Void _UpdateWalkBgScale()
  System.Void _Activate(System.Boolean fromTouch, UnityEngine.Vector2 showPos, UnityEngine.Vector2 initJsValue)
  System.Void _UpdateGait()
  System.Void _UpdateIndicator()
  System.Void _UpdateBg()
  System.Void _SetWalkBgVisible(System.Boolean visible, System.Boolean ignoreAnim)
  System.Void _SetRunBgVisible(System.Boolean visible, System.Boolean ignoreAnim)
  System.Void _OnHudLayoutLoaded(Beyond.EventData<System.String>& eventData)
  System.Void ClearComponent()
  System.Boolean get_groupEnabled()
  System.Boolean get_shouldCheckInput()
  System.Int32 get_groupId()
  Beyond.Input.IBindingGroupTarget get_parentTarget()
  Beyond.Input.InputBindingGroupMonoTarget get_parent()
  System.Void set_parent(Beyond.Input.InputBindingGroupMonoTarget value)
  System.Void InitBinding()
  System.Void _UpdateState()
  System.Void .ctor()
  System.Void <Awake>b__74_0(UnityEngine.Vector2 _)
END_CLASS

CLASS: Beyond.UI.UILayoutDimensionListener
TYPE:  class
TOKEN: 0x20000C0
EXTENDS: UIBehaviour
FIELDS:
  private           Beyond.ListSet<Beyond.UI.UILayoutDimensionListener.IAction>m_actionsWhenLayoutReady  // 0x18
  public            Beyond.DisposedUnityEvent       eventOnPostLayout  // 0x20
METHODS:
  System.Void GraphicUpdateComplete()
  System.Void LayoutComplete()
  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  System.Collections.IEnumerator _NextFrameCoroutine()
  System.Void DoOnceOnPostLayout(Beyond.UI.UILayoutDimensionListener.IAction action)
  System.Void OnEnable()
  System.Void OnRectTransformDimensionsChange()
  System.Void OnDestroy()
  System.Void _SetDirty()
  System.Void _InvokePostLayoutCallback()
  System.Void .ctor()
  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnRectTransformDimensionsChange()
  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UILeftSubtitle
TYPE:  class
TOKEN: 0x20000C3
EXTENDS: TickableUIMono
FIELDS:
  private           Beyond.UI.UIDialogTextWithCursor_dialogText1  // 0x68
  private           Beyond.UI.UIDialogTextWithCursor_dialogText2  // 0x70
  private           Beyond.UI.UIDialogTextWithCursor_dialogText3  // 0x78
  private           Beyond.UI.UIDialogTextWithCursor_dialogText4  // 0x80
  private           Beyond.UI.UIAnimationWrapper    _panelAnimation  // 0x88
  private           System.Int32                    m_maxDisplayIndex  // 0x90
  private   readonly System.Collections.Generic.List<Beyond.UI.UIDialogTextWithCursor>m_dialogTextList  // 0x98
  private           System.Boolean                  m_isDisplaying  // 0xA0
  private           System.Single                   m_currTime  // 0xA4
  private           System.Single                   m_textStayTime  // 0xA8
  private           System.Boolean                  m_isAutoPlay  // 0xAC
METHODS:
  Beyond.TickType get_tickOption()
  System.Void Tick(System.Single deltaTime)
  System.Void StartAutoPlay(System.Single textStayTime)
  System.Void SetLeftSubTitle(System.String text1, System.String text2, System.String text3, System.String text4)
  System.Single UpdateByPlayTime(System.Single currTime)
  System.Void Exit()
  System.Void SetVisible(System.Boolean visible)
  System.Void .ctor()
  System.Void <Exit>b__17_0()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIMaterialAnimation
TYPE:  class
TOKEN: 0x20000C4
EXTENDS: TickableUIMono
FIELDS:
  private           UnityEngine.UI.MaskableGraphic  _maskableGraphic  // 0x68
  private           UnityEngine.Material            _material  // 0x70
  private           System.String                   _propertiesName1  // 0x78
  private           System.Single                   _propertiesSet1  // 0x80
  private           System.String                   _propertiesName2  // 0x88
  private           System.Single                   _propertiesSet2  // 0x90
  private           System.String                   _propertiesName3  // 0x98
  private           System.Single                   _propertiesSet3  // 0xA0
  private           System.String                   _propertiesName4  // 0xA8
  private           System.Single                   _propertiesSet4  // 0xB0
  private           System.String                   _propertiesName5  // 0xB8
  private           System.Single                   _propertiesSet5  // 0xC0
  private           System.String                   _propertiesName6  // 0xC8
  private           System.Single                   _propertiesSet6  // 0xD0
  private           System.String                   _propertiesName7  // 0xD8
  private           System.Single                   _propertiesSet7  // 0xE0
  private           System.String                   _propertiesName8  // 0xE8
  private           System.Single                   _propertiesSet8  // 0xF0
  private           System.String                   _propertiesName9  // 0xF8
  private           System.Single                   _propertiesSet9  // 0x100
  private           System.String                   _propertiesName10  // 0x108
  private           System.Single                   _propertiesSet10  // 0x110
  private           System.String                   _propertiesVectorName1  // 0x118
  private           UnityEngine.Vector4             _propertiesVector1  // 0x120
  private           System.String                   _propertiesVectorName2  // 0x130
  private           UnityEngine.Vector4             _propertiesVector2  // 0x138
  private           System.String                   _propertiesVectorName3  // 0x148
  private           UnityEngine.Vector4             _propertiesVector3  // 0x150
  private           System.String                   _propertiesVectorName4  // 0x160
  private           UnityEngine.Vector4             _propertiesVector4  // 0x168
  private           System.String                   _propertiesVectorName5  // 0x178
  private           UnityEngine.Vector4             _propertiesVector5  // 0x180
  private           System.String                   _propertiesColorName1  // 0x190
  private           UnityEngine.Color               _propertiesColor1  // 0x198
  private           System.String                   _propertiesColorName2  // 0x1A8
  private           UnityEngine.Color               _propertiesColor2  // 0x1B0
  private           System.String                   _propertiesColorName3  // 0x1C0
  private           UnityEngine.Color               _propertiesColor3  // 0x1C8
  private           UnityEngine.Material            m_matIns  // 0x1D8
METHODS:
  Beyond.TickType get_tickOption()
  System.Void LateTick(System.Single deltaTime)
  System.Void OnAwake()
  System.Void OnRelease()
  System.Void _TryUpdate()
  System.Void ForceUpdate()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.UINonUnifiedScrollList
TYPE:  class
TOKEN: 0x20000C5
EXTENDS: UIScrollList
FIELDS:
  public            Beyond.UI.UINonUnifiedScrollList.GetCellSizeModegetCellSizeMode  // 0x278
  private           System.Boolean                  _recalculateAfterSizeChange  // 0x27C
  private           System.Boolean                  _forceUpdateCellSizeCache  // 0x27D
  public            System.Func<System.Int32,System.Int32>getSubCellCount  // 0x280
  public            System.Func<System.Int32,System.Single>getCellSize  // 0x288
  public            System.Single                   overrideContainSize  // 0x290
  private           UnityEngine.UI.GridLayoutGroup  m_templateCellGridLayoutGroup  // 0x298
  private           System.Collections.Generic.Dictionary<System.Int32,System.Single>m_cellSizeCache  // 0x2A0
  private           System.Int32                    m_containerTopIndex  // 0x2A8
  private   static  System.Single                   CONTAINER_SIZE_BUFFER  // 0x0
  public            System.Single                   additiveContainerSizeBuffer  // 0x2AC
  private           System.Single                   m_lastScrollStep  // 0x2B0
  private           System.Boolean                  m_isRecalculatingSize  // 0x2B4
  private           System.Boolean                  m_isCalculatingContainerSize  // 0x2B5
  private           System.Int32                    m_averageCount  // 0x2B8
  private           System.Single                   m_averageCellSize  // 0x2BC
  private           System.Boolean                  m_needRecalculateAverage  // 0x2C0
  private           System.Collections.Generic.Dictionary<System.Int32,System.Boolean>m_cellFoldStateDic  // 0x2C8
  private           Beyond.UI.IUIFoldoutComp        m_cellTemplateFoldoutComp  // 0x2D0
METHODS:
  System.Void InitBasicInfo()
  System.Void CalcSomeCountNum()
  System.Single GetLeftLength(System.Boolean checkVertical, System.Int32 checkCount)
  System.Void UpdateCount(System.Int32 newCount)
  System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop, System.Boolean forceRecalculate, System.Boolean onlyUpdateNewCellContent, System.Boolean skipGraduallyShow)
  System.Void UpdateCount(System.Int32 newCount, System.Int32 fastScrollToIndex, System.Boolean forceRecalculate, System.Boolean onlyUpdateNewCellContent, System.Boolean skipGraduallyShow, Beyond.UI.UIScrollList.ScrollAlignType alignType)
  System.Void LateTick(System.Single deltaTime)
  System.Void OnScroll(UnityEngine.Vector2 v)
  UnityEngine.Vector2 GetGridLayoutSize(UnityEngine.UI.GridLayoutGroup grid, System.Int32 count)
  System.Single _GetCellSize(System.Int32 index)
  System.Single GetContainerSize(System.Boolean ignoreAutoLayout)
  System.Single GetCenterIndex()
  UnityEngine.Vector2Int GetShowRange(System.Single bufferSize, System.Boolean ignoreGraduallyShow)
  UnityEngine.Vector2Int GetNotCacheRange()
  System.Void MoveCellTo(Beyond.UI.UIScrollList.Cell cell, System.Int32 index)
  System.Void OnUpdateCell(Beyond.UI.UIScrollList.Cell cell, System.Int32 index)
  System.Single GetTargetPosByIndex(System.Int32 index, Beyond.UI.UIScrollList.ScrollAlignType alignType)
  System.Single _GetCellsSizeTo(System.Int32 index)
  System.Void ScrollTo(System.Int32 index, System.Boolean fastMode, Beyond.UI.UIScrollList.ScrollAlignType alignType)
  System.Void ClearComponent()
  System.Single get_currentStep()
  System.Void set_currentStep(System.Single value)
  System.Void SetStepTo(System.Single step)
  System.Void SetCurrentStep(System.Single currentStep)
  System.Single GetScrollBarSize()
  System.Single GetLastScrollStep()
  System.Void UpdateLastScrollStep()
  System.Single GetNormalizedPosition()
  System.Void SetNormalizedPosition(System.Single normalizedPosition)
  System.Void ToggleByState(System.Int32 index, System.Boolean isFoldOut, System.Boolean fastMode)
  System.Void Toggle(System.Int32 index, System.Boolean fastMode)
  System.Void FoldAll(System.Boolean isFoldOut)
  System.Void NotifyCellSizeChange(System.Int32 index, System.Single size)
  System.Void .ctor()
  System.Void <GetScrollBarSize>g__RecalculateAverageCellSize|43_0()
  System.Void <>iFixBaseProxy_InitBasicInfo()
  System.Void <>iFixBaseProxy_CalcSomeCountNum()
  System.Single <>iFixBaseProxy_GetLeftLength(System.Boolean P0, System.Int32 P1)
  System.Void <>iFixBaseProxy_UpdateCount(System.Int32 P0)
  System.Void <>iFixBaseProxy_UpdateCount(System.Int32 P0, System.Boolean P1, System.Boolean P2, System.Boolean P3, System.Boolean P4)
  System.Void <>iFixBaseProxy_UpdateCount(System.Int32 P0, System.Int32 P1, System.Boolean P2, System.Boolean P3, System.Boolean P4, Beyond.UI.UIScrollList.ScrollAlignType P5)
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  System.Void <>iFixBaseProxy_OnScroll(UnityEngine.Vector2 P0)
  System.Single <>iFixBaseProxy_GetContainerSize(System.Boolean P0)
  System.Single <>iFixBaseProxy_GetCenterIndex()
  UnityEngine.Vector2Int <>iFixBaseProxy_GetShowRange(System.Single P0, System.Boolean P1)
  UnityEngine.Vector2Int <>iFixBaseProxy_GetNotCacheRange()
  System.Void <>iFixBaseProxy_MoveCellTo(Beyond.UI.UIScrollList.Cell P0, System.Int32 P1)
  System.Void <>iFixBaseProxy_OnUpdateCell(Beyond.UI.UIScrollList.Cell P0, System.Int32 P1)
  System.Single <>iFixBaseProxy_GetTargetPosByIndex(System.Int32 P0, Beyond.UI.UIScrollList.ScrollAlignType P1)
  System.Void <>iFixBaseProxy_ScrollTo(System.Int32 P0, System.Boolean P1, Beyond.UI.UIScrollList.ScrollAlignType P2)
  System.Void <>iFixBaseProxy_ClearComponent()
  System.Single <>iFixBaseProxy_get_currentStep()
  System.Void <>iFixBaseProxy_SetStepTo(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UINonUnifiedScrollRect
TYPE:  class
TOKEN: 0x20000C7
EXTENDS: UIScrollRect
FIELDS:
  private           System.Boolean                  m_isInited  // 0x1D8
  private           System.Boolean                  m_isRebuilding  // 0x1D9
  private           Beyond.UI.UINonUnifiedScrollListm_scrollList  // 0x1E0
  private           Beyond.UI.UILayoutDimensionListenerm_dimensionListener  // 0x1E8
METHODS:
  System.Void _InitIfNot()
  System.Void UpdateScrollbars(UnityEngine.Vector2 offset)
  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  System.Void _UpdateNonUnifiedScrollbars()
  System.Void SetHorizontalNormalizedPosition(System.Single value)
  System.Void SetVerticalNormalizedPosition(System.Single value)
  System.Void _OnPostLayout()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_UpdateScrollbars(UnityEngine.Vector2 P0)
  System.Void <>iFixBaseProxy_Rebuild(UnityEngine.UI.CanvasUpdate P0)
  System.Void <>iFixBaseProxy_SetHorizontalNormalizedPosition(System.Single P0)
  System.Void <>iFixBaseProxy_SetVerticalNormalizedPosition(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UINumberScrollTween
TYPE:  class
TOKEN: 0x20000C8
EXTENDS: TickableUIMono
FIELDS:
  public            Beyond.UI.UIText                bindingUIText  // 0x68
  public            System.Single                   tweenDuration  // 0x70
  public            System.Boolean                  useCustomNumberTweenCurve  // 0x74
  public            UnityEngine.AnimationCurve      numberTweenCurve  // 0x78
  private           System.String                   m_tweenToText  // 0x80
  private           System.Single                   m_tweenStartTime  // 0x88
  private           System.Single                   m_curTime  // 0x8C
  private           System.Boolean                  m_inTransition  // 0x90
  private           System.Single                   m_fromNumber  // 0x94
  private           System.Single                   m_toNumber  // 0x98
METHODS:
  Beyond.TickType get_tickOption()
  System.String get_tweenToText()
  System.Void set_tweenToText(System.String value)
  System.String get_text()
  System.Void set_text(System.String value)
  System.Void Start()
  System.Void Tick(System.Single deltaTime)
  System.Void _TweenToTarget(System.String targetText)
  System.Void _CleanupBeforeTween()
  System.Void _HandleNumberScrollTween(System.Single fromNumber, System.Single toNumber, System.Single curTime)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIPCScaleHelper
TYPE:  class
TOKEN: 0x20000C9
EXTENDS: MonoBehaviour
FIELDS:
  public            UnityEngine.Vector3             baseScale  // 0x18
METHODS:
  System.Void OnEnable()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIRawImage
TYPE:  class
TOKEN: 0x20000CA
EXTENDS: RawImage
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIRegionBuildingTexManager
TYPE:  class
TOKEN: 0x20000CB
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Shader              _regionMapShader  // 0x18
  public            UnityEngine.Texture2D           minimapOutlineTex  // 0x20
  private   static  System.Int32                    s_buildingOutlineTex  // 0x0
  private           UnityEngine.Renderer            m_meshRenderer  // 0x28
  private   static  UnityEngine.MaterialPropertyBlocks_materialPropertyBlock  // 0x8
METHODS:
  UnityEngine.MaterialPropertyBlock get_materialPropertyBlock()
  System.Void OnEnable()
  System.Void OnValidate()
  System.Void OnDisable()
  System.Void _UpdateTexture(UnityEngine.Renderer meshRenderer, UnityEngine.Shader minimapTerrainShader, UnityEngine.Texture2D buildingTex)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.UIScaleHolder
TYPE:  class
TOKEN: 0x20000CC
EXTENDS: TickableUIMono
FIELDS:
  private           UnityEngine.RectTransform       m_rectTransform  // 0x68
  private           UnityEngine.RectTransform       m_parentTransform  // 0x70
  private           System.Boolean                  m_holdValid  // 0x78
  private           UnityEngine.Vector3             _extraScale  // 0x7C
  private           System.Boolean                  _onlyHoldOnEnable  // 0x88
  public            UnityEngine.RectTransform       referenceTransform  // 0x90
  public            System.Single                   animationExtraScale  // 0x98
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnAwake()
  System.Void OnEnable()
  System.Void LateTick(System.Single deltaTime)
  System.Boolean _IsValidScale(UnityEngine.Vector3 scale)
  System.Void _HoldScale()
  System.Void SetExtraScale(UnityEngine.Vector3 extraScale)
  UnityEngine.Vector3 GetExtraScale()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIScrollbar
TYPE:  class
TOKEN: 0x20000CD
EXTENDS: Scrollbar
FIELDS:
METHODS:
  System.Void Awake()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Awake()
END_CLASS

CLASS: Beyond.UI.UIScrollbarKeyHint
TYPE:  class
TOKEN: 0x20000CE
EXTENDS: TickableUIMono
FIELDS:
  private           Beyond.UI.UIScrollRect          m_scrollRect  // 0x68
  private           Beyond.UI.UIImage               m_image  // 0x70
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnAwake()
  System.Void Tick(System.Single deltaTime)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIScrollCircle
TYPE:  class
TOKEN: 0x20000CF
EXTENDS: TickableUIMono
FIELDS:
  private           UnityEngine.GameObject          _cellTemplate  // 0x68
  private           System.Int32                    _totalNum  // 0x70
  private           System.Single                   _tweenTime  // 0x74
  private           UnityEngine.RectTransform       m_Viewport  // 0x78
  private           System.Single                   m_Elasticity  // 0x80
  private           System.Single                   _speedFactor  // 0x84
  private           System.Int32                    <count>k__BackingField  // 0x88
  public            UnityEngine.Events.UnityEvent<System.Int32,System.Int32,System.Boolean>onCenterIndexChanged  // 0x90
  public            UnityEngine.Events.UnityEvent<UnityEngine.GameObject,System.Int32>onUpdateCell  // 0x98
  private           UnityEngine.Vector2             m_PointerStartLocalCursor  // 0xA0
  private           UnityEngine.Vector2             m_tmpDragPosition  // 0xA8
  private           System.Boolean                  m_Dragging  // 0xB0
  private           System.Boolean                  m_inited  // 0xB1
  private           System.Single                   m_Velocity  // 0xB4
  private           UnityEngine.Vector2             m_curScreenPos  // 0xB8
  private           UnityEngine.RectTransform       m_ViewRect  // 0xC0
  private           Beyond.UI.LuaPanel              m_panel  // 0xC8
  private           System.Single                   m_radius  // 0xD0
  private           System.Single                   m_cellAngle  // 0xD4
  private           System.Collections.Generic.List<Beyond.UI.UIScrollCircle.Cell>m_showingCells  // 0xD8
  private           System.Single                   m_rangeMax  // 0xE0
  private           System.Single                   m_curAngle  // 0xE4
  private           System.Single                   m_lastAngle  // 0xE8
  private           System.Int32                    m_curCenterIndex  // 0xEC
  private           DG.Tweening.Tween               m_tween  // 0xF0
METHODS:
  Beyond.TickType get_tickOption()
  System.Single get_elasticity()
  System.Void set_elasticity(System.Single value)
  System.Int32 get_count()
  System.Void set_count(System.Int32 value)
  System.Single get_velocity()
  System.Void set_velocity(System.Single value)
  Beyond.UI.LuaPanel get_panel()
  UnityEngine.RectTransform get_viewRect()
  System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Boolean IsActive()
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void _UpdateSpeed()
  System.Boolean _CheckCanMove(System.Single deltaAngle)
  System.Void _TryUpdateCells()
  System.Void _UpdateAuto()
  System.Void OnRelease()
  System.Single _GetDeltaAngle(UnityEngine.Vector2 position)
  System.Void _InitCells()
  System.Void _Init()
  System.Void _OnAwakeInit()
  System.Void _UpdateScrollRange()
  System.Int32 _GetRealIndex(System.Int32 index)
  System.Void _UpdateShowingCells()
  System.Void _UpdateCenterIndex(System.Boolean forceUpdate)
  System.Void _DoScroll(System.Single tmpAngle, System.Boolean direct)
  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing)
  System.Void LayoutComplete()
  System.Void GraphicUpdateComplete()
  System.Boolean IsDestroyed()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Start()
  System.Void OnAwake()
  System.Void LateTick(System.Single deltaTime)
  System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop)
  System.Void ScrollToIndex(System.Int32 index, System.Boolean direct)
  UnityEngine.GameObject Get(System.Int32 index)
  System.Void ClearComponent()
  System.Void .ctor()
  UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
  System.Void <_DoScroll>b__59_0()
  System.Void <>iFixBaseProxy_OnRelease()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIScrollContainerFollower
TYPE:  class
TOKEN: 0x20000D1
EXTENDS: TickableUIMono
FIELDS:
  private           Beyond.UI.UIScrollList          _followTargetList  // 0x68
  private           Beyond.UI.UIScrollRect          _followTargetRect  // 0x70
  private           UnityEngine.RectTransform       m_rectTransform  // 0x78
  private           System.Single                   m_currentSize  // 0x80
  private           System.Boolean                  m_targetSizeChanged  // 0x84
  private           UnityEngine.Vector2             m_currentPos  // 0x88
  private           System.Boolean                  m_targetPosChanged  // 0x90
  private           System.Boolean                  m_setValid  // 0x91
  private           System.Boolean                  m_isFollowContent  // 0x92
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnAwake()
  System.Void LateTick(System.Single deltaTime)
  System.Void _RefreshSizeAndPositionToTargetContainer()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.ScrollDirection
TYPE:  struct
TOKEN: 0x20000D2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.ScrollDirection       Vertical  // 0x0
  public    static  Beyond.UI.ScrollDirection       Horizontal  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UIScrollList
TYPE:  class
TOKEN: 0x20000D3
EXTENDS: TickableUIMono
FIELDS:
  protected         UnityEngine.GameObject          _cellTemplate  // 0x68
  private           Beyond.UI.ScrollDirection       _scrollDirection  // 0x70
  private           System.Boolean                  _expandCellSize  // 0x74
  private           System.Boolean                  _alsoExpandCellSizeInAnotherDirection  // 0x75
  protected         UnityEngine.Vector2             _space  // 0x78
  protected         Beyond.UI.UIScrollList.Padding  _padding  // 0x80
  protected         System.Boolean                  _ignorePaddingWhenScroll  // 0x90
  protected         System.Single                   _notCacheBufferSize  // 0x94
  protected         System.Single                   _extraCacheBufferSize  // 0x98
  public            Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32>onUpdateCell  // 0xA0
  public            Beyond.DisposedUnityEvent       onGraduallyShowFinish  // 0xA8
  public            Beyond.DisposedUnityEvent       onScrollEnd  // 0xB0
  public            Beyond.DisposedUnityEvent<System.Int32>onUpdateCount  // 0xB8
  public            System.Func<System.Int32,System.String>getCellName  // 0xC0
  public    static  Beyond.DisposedUnityEvent<System.String>s_onGraduallyShowFinish  // 0x0
  protected         System.Boolean                  _inverse  // 0xC8
  protected         System.Boolean                  _autoLayoutWhenFew  // 0xC9
  protected         Beyond.UI.UIScrollList.AutoLayoutWhenFewType_autoLayoutWhenFewType  // 0xCC
  protected         System.Boolean                  _autoCenterInOtherDir  // 0xD0
  private           UnityEngine.Transform           _centerNode  // 0xD8
  private           System.Boolean                  _hideRayCastWhenLessThanOnePage  // 0xE0
  private           System.Boolean                  _clampWhenLessThanOnePage  // 0xE1
  private           UnityEngine.UI.ScrollRect.MovementTypem_lastScrollRectMovementType  // 0xE4
  protected         UnityEngine.RectTransform       _container  // 0xE8
  protected         Beyond.UI.UIScrollRect          _scrollRect  // 0xF0
  private           System.Int32                    <count>k__BackingField  // 0xF8
  private           System.Single                   <containerSizeWithoutAutoLayout>k__BackingField  // 0xFC
  protected         UnityEngine.RectTransform       m_rect  // 0x100
  protected         System.Int32                    m_countPerLine  // 0x108
  protected         System.Int32                    m_maxShowingLine  // 0x10C
  protected         System.Int32                    m_maxShowingCellCount  // 0x110
  protected         System.Int32                    m_maxCellCountWhenNoScroll  // 0x114
  protected         System.Single                   m_viewWidth  // 0x118
  protected         System.Single                   m_viewHeight  // 0x11C
  protected         System.Single                   m_cellWidth  // 0x120
  protected         System.Single                   m_cellHeight  // 0x124
  protected         UnityEngine.UI.Graphic          m_graphic  // 0x128
  protected         Beyond.UI.UIScrollList.Padding  m_realPadding  // 0x130
  private           UnityEngine.Vector3[]           m_cellCorners  // 0x140
  protected         System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIScrollList.Cell>m_showingCells  // 0x148
  private           System.Collections.Generic.Stack<Beyond.UI.UIScrollList.Cell>m_cellCache  // 0x150
  private   static  System.String                   CACHED_CELL_GAME_OBJECT_NAME  // 0x0
  public            UnityEngine.Events.UnityEvent   onBeginDrag  // 0x158
  public            UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>onDrag  // 0x160
  public            UnityEngine.Events.UnityEvent   onEndDrag  // 0x168
  private           UnityEngine.GameObject          _moveTipsLeftOrTop  // 0x170
  private           UnityEngine.GameObject          _moveTipsRightOrBottom  // 0x178
  private           System.Single                   m_moveTipsIgnoredRange  // 0x180
  private           System.Boolean                  _useViewEffect  // 0x184
  private           System.Boolean                  _symmetricViewEffect  // 0x185
  private           System.Boolean                  _needDummyParent  // 0x186
  private           UnityEngine.AnimationCurve      _viewEffectAnimation  // 0x188
  private           UnityEngine.Vector2             _effectAnchorPoint  // 0x190
  private           System.Boolean                  _useDefaultScaleEffect  // 0x198
  private           UnityEngine.AnimationCurve      _scaleEffectAnimation  // 0x1A0
  private           System.Boolean                  _useDefaultArcEffect  // 0x1A8
  private           UnityEngine.AnimationCurve      _arcEffectAnimation  // 0x1B0
  public            UnityEngine.Events.UnityEvent<UnityEngine.GameObject,System.Int32,System.Single>onChangeView  // 0x1B8
  protected         System.Single                   _tweenDuration  // 0x1C0
  protected         DG.Tweening.Ease                _tweenEase  // 0x1C4
  protected         System.Single                   _changeStepRatio  // 0x1C8
  protected         DG.Tweening.Tween               m_adjustTween  // 0x1D0
  protected         System.Single                   m_totalLength  // 0x1D8
  protected         System.Single                   m_cellLength  // 0x1DC
  protected         UnityEngine.Vector2             m_centerPos  // 0x1E0
  public            System.Boolean                  enableAutoScroll  // 0x1E8
  private           System.Single                   _startAutoScrollTime  // 0x1EC
  private           System.Single                   _autoScrollSpeed  // 0x1F0
  public            Beyond.UI.UIArea                autoScrollUpArea  // 0x1F8
  public            Beyond.UI.UIArea                autoScrollDownArea  // 0x200
  private           System.Single                   m_curAutoScrollSpd  // 0x208
  private           System.Int32                    m_autoScrollTimerKey  // 0x20C
  private           System.Boolean                  _enableGraduallyShow  // 0x210
  private           System.Single                   _graduallyShowTime  // 0x214
  private           System.Single                   _graduallyShowDelayTime  // 0x218
  protected         System.Boolean                  m_inGraduallyShow  // 0x21C
  private           System.Single                   m_graduallyShowedMaxIndex  // 0x220
  protected         System.Single                   m_curGraduallyCanShowMaxIndex  // 0x224
  private           System.Boolean                  m_needInformAnimationInEnd  // 0x228
  private   static  System.Single                   GRADUALLY_SHOW_UPDATE_MAX_INTERVAL  // 0x0
  public    static  System.Int32                    s_maxGraduallyShowAddCountPerFrame  // 0x8
  private           System.Boolean                  _enableSelectedNavigation  // 0x229
  private           System.Boolean                  _noNavigationKeyHint  // 0x22A
  private           System.Boolean                  _enableNavigationLoop  // 0x22B
  private           System.Boolean                  _customNavigationActionId  // 0x22C
  private           System.String                   _customNavigationPreviousActionId  // 0x230
  private           System.String                   _customNavigationNextActionId  // 0x238
  public            UnityEngine.Events.UnityEvent<UnityEngine.GameObject,System.Int32>onSelectedCell  // 0x240
  public            UnityEngine.Events.UnityEvent<UnityEngine.GameObject,System.Int32,System.Boolean>onCellSelectedChanged  // 0x248
  public            System.Func<System.Int32>       getCurSelectedIndex  // 0x250
  private           System.Int32                    m_curSelectedIndex  // 0x258
  private           System.Int32                    m_bindingGroupId  // 0x25C
  private           System.Int32                    m_naviBindingGroupId  // 0x260
  protected         System.Boolean                  _enableWrapNavigation  // 0x264
  protected         System.Boolean                  _enableCircleWrapNavigation  // 0x265
  private           System.Boolean                  _clearNaviGroupOnUpdateCount  // 0x266
  private           System.Collections.Generic.List<UnityEngine.UI.Selectable>m_wrapNaviSelectables  // 0x268
  private           Beyond.UI.LuaPanel              m_panel  // 0x270
METHODS:
  Beyond.TickType get_tickOption()
  UnityEngine.Vector2 get_space()
  System.Boolean get_autoLayoutWhenFew()
  System.Boolean get_isHorizontal()
  System.Boolean get_isVertical()
  System.Int32 get_count()
  System.Void set_count(System.Int32 value)
  System.Single get_containerSizeWithoutAutoLayout()
  System.Void set_containerSizeWithoutAutoLayout(System.Single value)
  System.Boolean get_isMultiPage()
  System.Int32 get_maxShowingCellCount()
  System.Int32 get_countPerLine()
  System.Single get_cellWidth()
  System.Single get_cellHeight()
  System.Void OnAwake()
  System.Void Tick(System.Single deltaTime)
  System.Void LateTick(System.Single deltaTime)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void TryRecalculateSize()
  System.Void _InGameAwake()
  System.Void _EditorAwake()
  System.Void Init(System.Boolean isPreview)
  System.Void InitConfig()
  System.Void InitBasicInfo()
  System.Void SyncViewSize()
  System.Void CalcSomeCountNum()
  System.Int32 _GetLineCount(System.Boolean calcVertical)
  System.Void OnScroll(UnityEngine.Vector2 v)
  System.Void SetTop(System.Boolean needUpdate)
  System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop, System.Boolean forceRecalculate, System.Boolean onlyUpdateNewCellContent, System.Boolean skipGraduallyShow)
  System.Void UpdateCount(System.Int32 newCount, System.Int32 fastScrollToIndex, System.Boolean forceRecalculate, System.Boolean onlyUpdateNewCellContent, System.Boolean skipGraduallyShow, Beyond.UI.UIScrollList.ScrollAlignType alignType)
  System.Void UpdateCount(System.Int32 newCount)
  System.Void UpdateShowingCells(System.Action<System.Int32,UnityEngine.GameObject> updateFunc)
  System.Single GetLeftLength(System.Boolean checkVertical, System.Int32 checkCount)
  System.Void _SetRealPadding(System.Boolean isVerticalPadding, System.Single firstAddedLength, System.Single secondAddedLength)
  System.Void UpdateContainerSize()
  System.Single GetContainerSize(System.Boolean ignoreAutoLayout)
  System.Void SetContainerSize(System.Single size)
  System.Void ClearShowingCells()
  System.Void UpdateShowingCells(System.Boolean forceUpdateContent, System.Boolean forceClearShowingCells, System.Boolean ignoreListActive)
  System.Void UpdateCell(System.Int32 index, System.Boolean forceUpdateContent, System.Boolean ignoreListActive)
  UnityEngine.Vector2Int GetShowRange(System.Single bufferSize, System.Boolean ignoreGraduallyShow)
  UnityEngine.Vector2Int GetRangeInView()
  UnityEngine.Vector2Int GetNotCacheRange()
  System.Void MoveCellTo(Beyond.UI.UIScrollList.Cell cell, System.Int32 index)
  System.Void SetCellCanCache(System.Int32 index, System.Boolean canCache)
  System.Void OnUpdateCell(Beyond.UI.UIScrollList.Cell cell, System.Int32 index)
  Beyond.UI.UIScrollList.Cell GetCell()
  System.Void CacheShowingCell(System.Int32 index)
  System.Void CacheCell(Beyond.UI.UIScrollList.Cell cell)
  System.Single get_currentStep()
  System.Void set_currentStep(System.Single value)
  System.Void SetStepTo(System.Single step)
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  Beyond.UI.UIScrollList.MoveTipsType get_moveTips()
  System.Void _UpdateMoveTips()
  System.Void UpdateViewEffect()
  UnityEngine.GameObject Get(System.Int32 index)
  Beyond.UI.UIScrollList.Cell GetCell(System.Int32 index)
  System.Int32 GetRealIndex(System.Int32 index)
  System.Void OnRelease()
  System.Void ClearComponent()
  System.Void SetPaddingBottom(System.Single value)
  System.Void SetPaddingTop(System.Single value)
  System.Void SetPaddingRight(System.Single value)
  System.Void SetPaddingLeft(System.Single value)
  System.Void SetPadding(UnityEngine.Rect value)
  Beyond.UI.UIScrollList.Padding GetPadding()
  System.Void GetShowingCellsIndexRange(System.Int32& firstIndex, System.Int32& lastIndex)
  System.Void SetSpace(UnityEngine.Vector2 newSpace)
  System.Void ScrollToIndex(System.Int32 index, System.Boolean fastMode, Beyond.UI.UIScrollList.ScrollAlignType alignType, System.Boolean graduallyShowInFastMode)
  System.Void ScrollTo(System.Int32 index, System.Boolean fastMode, Beyond.UI.UIScrollList.ScrollAlignType alignType)
  System.Void _ScrollToPos(System.Single targetPos, System.Boolean fastMode)
  System.Void TryClearAdjustTween()
  System.Single GetCenterIndex()
  System.Single GetTargetPosByIndex(System.Int32 index, Beyond.UI.UIScrollList.ScrollAlignType alignType)
  System.Void _InitAutoScroll()
  System.Void _OnEnterAutoScrollUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void _OnExitAutoScrollUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void _OnEnterAutoScrollDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void _OnExitAutoScrollDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void _SetAutoScrollSpd(System.Single spd)
  System.Void _UpdateAutoScroll(System.Single deltaTime)
  System.Void RestartGraduallyShow()
  System.Void _StartGraduallyShow()
  System.Void _UpdateGraduallyShow(System.Single deltaTime)
  System.Void SkipGraduallyShow()
  System.Void StopGraduallyShow()
  System.Int32 get_curSelectedIndex()
  System.Void set_curSelectedIndex(System.Int32 value)
  UnityEngine.GameObject get_curSelectedObj()
  System.Boolean get_enableSelectedNavigation()
  System.Int32 get_naviBindingGroupId()
  System.Void _InitNavigation()
  System.Void NavigateSelected(UnityEngine.UI.NaviDirection dir)
  System.Int32 GetNaviOffset(UnityEngine.UI.NaviDirection dir)
  System.Int32 GetNaviNewIndex(System.Int32 oldIndex, UnityEngine.UI.NaviDirection dir)
  System.Void SetSelectedIndex(System.Int32 index, System.Boolean needNotify, System.Boolean forceUpdate, System.Boolean needScroll)
  System.Void ListWrapNavigate(UnityEngine.UI.NaviDirection dir)
  System.Void _InitControllerNavi()
  System.Void _ClearRelatedNaviGroup()
  Beyond.UI.LuaPanel get_panel()
  System.Int32 GetMousePosIndex(UnityEngine.UI.NaviDirection dir)
  System.Int32 ScreenPos2Index(UnityEngine.Vector2 targetScreenPos, UnityEngine.UI.NaviDirection dir)
  System.Void _GetScreenPosLineColumnInfo(UnityEngine.Vector2 targetScreenPos, System.Int32& line, System.Int32& column)
  System.Int32 GetIndexOf(System.Int32 column, System.Int32 line)
  System.Void .ctor()
  System.Void .cctor()
  System.Single <_ScrollToPos>b__158_0()
  System.Void <_ScrollToPos>b__158_1(System.Single x)
  System.Void <_ScrollToPos>b__158_2()
  System.Single <_ScrollToPos>b__158_3()
  System.Void <_ScrollToPos>b__158_4(System.Single y)
  System.Void <_ScrollToPos>b__158_5()
  System.Void <_OnEnterAutoScrollUp>b__171_0()
  System.Void <_OnEnterAutoScrollDown>b__173_0()
  System.Void <_InitNavigation>b__212_0()
  System.Void <_InitNavigation>b__212_1()
  System.Void <_InitNavigation>b__212_2()
  System.Void <_InitNavigation>b__212_3()
  System.Void <_InitNavigation>b__212_4()
  System.Void <_InitNavigation>b__212_5()
  System.Void <_InitNavigation>b__212_6()
  System.Void <_InitNavigation>b__212_7()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.AutoScrollStrategy
TYPE:  struct
TOKEN: 0x20000DA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.AutoScrollStrategy    None  // 0x0
  public    static  Beyond.UI.AutoScrollStrategy    AlignNearbyBound  // 0x0
  public    static  Beyond.UI.AutoScrollStrategy    AlignCenter  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UIScrollRect
TYPE:  class
TOKEN: 0x20000DB
EXTENDS: ScrollRect
FIELDS:
  private           DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions>m_scrollTween  // 0x150
  public            System.Boolean                  inScrollTween  // 0x158
  public            System.Single                   smoothScrollTweenSpd  // 0x15C
  public            DG.Tweening.Ease                smoothScrollTweenEase  // 0x160
  private           System.Boolean                  m_lastUpdateIsDragging  // 0x164
  private           Beyond.UI.LuaPanel              m_panel  // 0x168
  protected         System.Single                   _stickScrollSpeed  // 0x170
  protected         System.Single                   _stickScrollTolerance  // 0x174
  protected         Beyond.UI.UISelectableNaviGroup _naviGroup  // 0x178
  protected         System.Boolean                  _enableWrapNavigation  // 0x180
  protected         Beyond.Input.InputBindingGroupMonoTarget_scrollBindingGroup  // 0x188
  public            System.Boolean                  controllerScrollEnabled  // 0x190
  private           System.Boolean                  m_controllerInited  // 0x191
  private           System.Boolean                  m_navigationWrapped  // 0x192
  protected         Beyond.UI.AutoScrollStrategy    _autoScrollStrategy  // 0x194
  protected         System.Single                   _alignBoundPaddingX  // 0x198
  protected         System.Single                   _alignBoundPaddingY  // 0x19C
  private           UnityEngine.GameObject          _moveTipsLeftOrTop  // 0x1A0
  private           UnityEngine.GameObject          _moveTipsRightOrBottom  // 0x1A8
  private           UnityEngine.Camera              m_fallbackUICamera  // 0x1B0
  private           System.Boolean                  _enableOverScrollEffect  // 0x1B8
  private           System.Single                   _overScrollTriggerValue  // 0x1BC
  private           UnityEngine.GameObject          _overScrollEffectPrevNode  // 0x1C0
  private           UnityEngine.GameObject          _overScrollEffectNextNode  // 0x1C8
  public            Beyond.DisposedUnityEvent<System.Boolean>onOverScrollEffect  // 0x1D0
METHODS:
  UnityEngine.Vector2 get_contentStartPosition()
  System.Void set_contentStartPosition(UnityEngine.Vector2 value)
  System.Void Awake()
  System.Void OnEnable()
  System.Void Update()
  System.Void ScrollTo(UnityEngine.Vector2 position, System.Boolean noTween)
  System.Boolean IsCellViewed(UnityEngine.RectTransform cell)
  System.Void OnDestroy()
  System.Void _CustomSetPosOnScroll(UnityEngine.Vector2 position)
  System.Void UpdateScrollEnableNode()
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void ClearComponent()
  System.Boolean get_dragging()
  System.Void LateUpdate()
  System.Boolean get_controllerStickScrollEnabled()
  Beyond.UI.LuaPanel get_panel()
  Beyond.UI.UISelectableNaviGroup get_naviGroup()
  System.Void _TickRefreshControllerStickScroll()
  System.Void ScrollToNaviTarget(UnityEngine.UI.Selectable target)
  System.Void RectWrapNavigate(UnityEngine.UI.NaviDirection dir)
  System.Void _InitController()
  System.Void WrapNavigation(UnityEngine.Events.UnityAction<UnityEngine.UI.NaviDirection> wrapper)
  System.Void AutoScrollToRectTransform(UnityEngine.RectTransform target, System.Boolean noTween)
  Beyond.UI.UIScrollRect.MoveTipsType get_moveTips()
  System.Void _UpdateMoveTips()
  UnityEngine.Camera _GetUICamera()
  System.Void _CheckOverScrollEffect(UnityEngine.Vector2 value)
  System.Void _CheckOverScrollOnEndDrag(UnityEngine.Vector2 value)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Awake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDestroy()
  System.Void <>iFixBaseProxy__CustomSetPosOnScroll(UnityEngine.Vector2 P0)
  System.Void <>iFixBaseProxy_UpdateScrollEnableNode()
  System.Void <>iFixBaseProxy_OnBeginDrag(UnityEngine.EventSystems.PointerEventData P0)
  System.Void <>iFixBaseProxy_OnDrag(UnityEngine.EventSystems.PointerEventData P0)
  System.Void <>iFixBaseProxy_OnEndDrag(UnityEngine.EventSystems.PointerEventData P0)
  System.Void <>iFixBaseProxy_LateUpdate()
END_CLASS

CLASS: Beyond.UI.UIScrollRectEdgeRedDot
TYPE:  class
TOKEN: 0x20000DE
EXTENDS: TickableUIMono
FIELDS:
  private           Beyond.UI.UIScrollRect          m_uiScrollRect  // 0x68
  private           UnityEngine.RectTransform       m_uiScrollRectTransform  // 0x70
  private           Beyond.UI.UIScrollList          m_uiScrollList  // 0x78
  private           UnityEngine.UI.RectMask2D       m_rectMask2D  // 0x80
  private           System.Collections.Generic.Dictionary<UnityEngine.GameObject,Beyond.UI.UIScrollRectEdgeRedDot.RedDotInfo>m_redDotInfoDict  // 0x88
  private           System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState>m_redDotStateDict  // 0x90
  private           UnityEngine.Vector2Int          m_scrollListShowRange  // 0x98
  public            System.Func<System.Int32,System.Int32>getRedDotStateAt  // 0xA0
  private           Beyond.UI.UIScrollRectEdgeRedDot.ERedDotStatem_upRedDotState  // 0xA8
  private           Beyond.UI.UIScrollRectEdgeRedDot.ERedDotStatem_downRedDotState  // 0xAC
  private           UnityEngine.GameObject          _upNormal  // 0xB0
  private           UnityEngine.GameObject          _upNew  // 0xB8
  private           UnityEngine.GameObject          _downNormal  // 0xC0
  private           UnityEngine.GameObject          _downNew  // 0xC8
  private           UnityEngine.RectTransform       _upParent  // 0xD0
  private           UnityEngine.RectTransform       _downParent  // 0xD8
METHODS:
  Beyond.TickType get_tickOption()
  System.Void OnAwake()
  System.Void OnEnable()
  System.Void OnRelease()
  System.Void Tick(System.Single deltaTime)
  System.Void ResetReferences()
  System.Void ResetRedDotPosition()
  System.Void _UpdateCacheDictForRangeChange(UnityEngine.Vector2Int newRange)
  System.Void _OnScrollListUpdateCount(System.Int32 newCount)
  System.Void RegisterRedDot(UnityEngine.GameObject redDotRoot, UnityEngine.GameObject redDotNormal, UnityEngine.GameObject redDotNew)
  System.Void UnregisterRedDot(UnityEngine.GameObject redDotRoot)
  System.Void RegisterRedDotStatesForScrollList()
  System.Void UpdateRedDotStateInDir()
  System.Void _CalculateRedDotStateInDir(Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState& upState, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState& downState)
  System.Void _UpdateRedDotGameObjects(UnityEngine.GameObject normal, UnityEngine.GameObject newer, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState state)
  System.Boolean IsRedDotInDir(Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState state, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDir dir, Beyond.UI.UIScrollRectEdgeRedDot.RedDotInfo redDotInfo)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnRelease()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIScrollText
TYPE:  class
TOKEN: 0x20000E2
EXTENDS: TickableUIMono
FIELDS:
  private           System.Single                   _speed  // 0x68
  private           System.Single                   _stayTime  // 0x6C
  private           System.Single                   _fadeTime  // 0x70
  private           UnityEngine.CanvasGroup         _canvasGroup  // 0x78
  private           Beyond.UI.UIScrollText.ScrollMode_scrollMode  // 0x80
  private           System.Boolean                  _disableClipping  // 0x84
  private           System.Boolean                  m_isInited  // 0x85
  private           Beyond.UI.UIText                m_tmp  // 0x88
  private           UnityEngine.RectTransform       m_rect  // 0x90
  private           UnityEngine.RectTransform       m_parentRect  // 0x98
  private           Beyond.UI.UIScrollText.IScrollHandlerm_scrollHandler  // 0xA0
  private           Beyond.UI.UIScrollText.IAlphaHandlerm_alphaHandler  // 0xA8
  private           Beyond.UI.UIScrollText.ScrollStatem_state  // 0xB0
  private           System.Single                   m_scrollOffset  // 0xB4
  private           System.Single                   m_currStateTime  // 0xB8
  private           System.Boolean                  m_needScroll  // 0xBC
  private           System.Single                   m_textDiff  // 0xC0
  private           TMPro.TextAlignmentOptions      m_originalAlignment  // 0xC4
METHODS:
  Beyond.TickType get_tickOption()
  System.Void _InitIfNot()
  System.Void ResetTextScroll()
  System.Void _ResetTextScrollInternal(System.Boolean needScroll, System.Single textDiff)
  System.Void OnAwake()
  System.Void LateTick(System.Single deltaTime)
  System.Void _UpdateScrollState(System.Single deltaTime, System.Single textDiff)
  System.Void _ResetTextScroll()
  System.Void _ApplyTextAlignment(System.Boolean isScroll)
  System.Void _ApplyTextScroll(System.Single scrollOffset)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UISelectableNaviGroup
TYPE:  class
TOKEN: 0x20000EA
EXTENDS: SelectableNaviGroup
FIELDS:
  public            System.Collections.Generic.List<Beyond.Input.InputBindingGroupMonoTarget>relatedInputBindingGroups  // 0xA0
  public            System.Func<UnityEngine.UI.Selectable>getDefaultSelectableFunc  // 0xA8
  public            System.Func<System.Boolean>     canFocusFun  // 0xB0
  public            System.String                   focusActionId  // 0xB8
  public            System.String                   stopFocusActionId  // 0xC0
  public            System.Boolean                  hideItemTipsOnUnFocus  // 0xC8
  public            System.Boolean                  useDefaultTargetOnFocus  // 0xC9
  public            System.Boolean                  useFocusHighlight  // 0xCA
  public            System.Boolean                  focusHighlightMask  // 0xCB
  public            System.Boolean                  focusHighlightNormalFrame  // 0xCC
  public            System.Boolean                  focusHighlightDarkFrame  // 0xCD
  public            UnityEngine.RectTransform       focusOverrideHighlightRect  // 0xD0
  public            System.Int32                    focusPanelSortingOrder  // 0xD8
  public            Beyond.UI.UIActionKeyHint       focusActionKeyHint  // 0xE0
  public            Beyond.UI.UIActionKeyHint       stopFocusActionKeyHint  // 0xE8
  public            UnityEngine.Events.UnityEvent<System.Boolean>onIsFocusedChange  // 0xF0
  private           Beyond.UI.LuaPanel              m_luaPanel  // 0xF8
  private           Beyond.Input.InputBindingGroupMonoTargetm_bindingMonoGroup  // 0x100
  private           UnityEngine.RectTransform       m_rectTransform  // 0x108
  private           UnityEngine.UI.Selectable       m_lastFocusNaviTarget  // 0x110
  private           System.String                   m_focusBindingText  // 0x118
  private           System.Int32                    m_focusBindingId  // 0x120
  private           System.Int32                    m_stopFocusBindingId  // 0x124
  private           System.Boolean                  m_focusBindingCreated  // 0x128
  private           System.Boolean                  m_isInFocusHighlight  // 0x129
  private   static  System.Int32                    INVALID_BINDING_ID  // 0x0
METHODS:
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void _OnIsTopLayerChanged()
  System.Void _OnSelectableNaviGroupDisabled()
  System.Void _BeforeSelectableNaviGroupDestroy()
  System.Void _OnSetLayerSelectedTarget(UnityEngine.UI.Selectable value)
  System.Void _OnRemoveFromLayerStack()
  System.Void NaviToThisGroup(System.Boolean forceDefault)
  System.Void _RefreshRelatedBindingGroupsState()
  UnityEngine.UI.Selectable _FindDefaultSelectable()
  System.Void OnDestroy()
  System.Void ClearComponent()
  System.Void TryChangeNaviPartnerOnUp(Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd)
  System.Void TryChangeNaviPartnerOnDown(Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd)
  System.Void TryChangeNaviPartnerOnLeft(Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd)
  System.Void TryChangeNaviPartnerOnRight(Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd)
  System.Void _TryChangeNaviPartner(System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup> list, Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd)
  System.Int32 get_FocusBindingId()
  System.Int32 get_StopFocusBindingId()
  UnityEngine.UI.Selectable get_lastFocusNaviTarget()
  System.Void _InitFocusBinding()
  System.Void _RefreshFocusBindings()
  System.Void RefreshFocusBindings()
  System.Void _OnFocus(System.Boolean onlyStartHighlight)
  System.Void _OnStopFocus(System.Boolean onlyStopHighlight, System.Boolean ignoreTopLayerCheck)
  System.Void _RefreshFocusActionKeyHint()
  System.Void _RefreshStopFocusActionKeyHint()
  System.Void ManuallyFocus(System.Boolean onlyStartHighlight)
  System.Void ManuallyStopFocus(System.Boolean onlyStopHighlight)
  System.Void SetFocusBindingText(System.String bindingText)
  System.Void ClearLastFocusNaviTarget()
  System.Void ManuallyRefreshRelatedBindingGroups()
  System.Void .ctor()
  System.Void <_InitFocusBinding>b__51_0()
  System.Void <_InitFocusBinding>b__51_1()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy__OnIsTopLayerChanged()
  System.Void <>iFixBaseProxy__OnSelectableNaviGroupDisabled()
  System.Void <>iFixBaseProxy__BeforeSelectableNaviGroupDestroy()
  System.Void <>iFixBaseProxy__OnSetLayerSelectedTarget(UnityEngine.UI.Selectable P0)
  System.Void <>iFixBaseProxy__OnRemoveFromLayerStack()
  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UISemiCircleScrollList
TYPE:  class
TOKEN: 0x20000EC
EXTENDS: TickableUIMono
FIELDS:
  public            UnityEngine.RectTransform       content  // 0x68
  private           System.Single                   _innerRadius  // 0x70
  private           System.Single                   _outerRadius  // 0x74
  private           System.Single                   _padding  // 0x78
  private           System.Int32                    _cellCount  // 0x7C
  private           UnityEngine.GameObject          _cellPrefab  // 0x80
  private           System.Single                   _startAngle  // 0x88
  private           System.Boolean                  _reverseDirection  // 0x8C
  private           UnityEngine.RectTransform       m_rectTransform  // 0x90
  public            System.Single                   currentAngleOffset  // 0x98
  private           System.Single                   m_targetAngleOffset  // 0x9C
  private           System.Single                   _hideAngel  // 0xA0
  private           System.Single                   _duration  // 0xA4
  private           System.Collections.Generic.List<UnityEngine.GameObject>m_cells  // 0xA8
  private           System.Boolean                  m_inEndDragAnim  // 0xB0
  private           System.Boolean                  m_inDragging  // 0xB1
  protected         Beyond.Input.InputBindingGroupMonoTarget_scrollBindingGroup  // 0xB8
  protected         System.Single                   _stickScrollTolerance  // 0xC0
  protected         System.Single                   _stickScrollSpeed  // 0xC4
  private           System.Int32                    m_lastClosestCellIndex  // 0xC8
  private           System.Int32                    m_currentCellCount  // 0xCC
  public            Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32>onCellShow  // 0xD0
  public            Beyond.DisposedUnityEvent<System.Int32>onClosestCellChanged  // 0xD8
  public            Beyond.DisposedUnityEvent       onDrag  // 0xE0
  public            Beyond.DisposedUnityEvent       onEndDrag  // 0xE8
  private           UnityEngine.Coroutine           m_dampingCoroutine  // 0xF0
  private           System.String                   _audioHoldStart  // 0xF8
  private           System.String                   _audioHoldEnd  // 0x100
  private           System.String                   _audioAlignment  // 0x108
METHODS:
  Beyond.TickType get_tickOption()
  System.Boolean get_controllerStickScrollEnabled()
  System.Void OnAwake()
  System.Void OnDisable()
  System.Void Tick(System.Single deltaTime)
  System.Void _TickRefreshControllerStickScroll()
  System.Void _InitializeCells()
  System.Void RefreshLayout(System.Int32 newCellCount, System.Int32 targetCellIndex)
  System.Void UpdateLayout()
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void ClearComponent()
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Collections.IEnumerator _ApplyDamping()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UISemiCircleScrollListPair
TYPE:  class
TOKEN: 0x20000EE
EXTENDS: MonoBehaviour
FIELDS:
  public            Beyond.UI.UISemiCircleScrollListm_scrollListMaster  // 0x18
  public            Beyond.UI.UISemiCircleScrollList[]m_scrollLists  // 0x20
  public            Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32>onCellShow  // 0x28
  public            Beyond.DisposedUnityEvent<System.Int32>onClosestCellChanged  // 0x30
METHODS:
  System.Void Awake()
  System.Void _OnCellShow(UnityEngine.GameObject go, System.Int32 index)
  System.Void _OnClosestCellChanged(System.Int32 index)
  System.Void _OnDrag()
  System.Void _OnEndDrag()
  System.Void RefreshLayout(System.Int32 newCellCount, System.Int32 targetCellIndex)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UISequenceImage
TYPE:  class
TOKEN: 0x20000EF
EXTENDS: TickableUIMono
FIELDS:
  public            System.Boolean                  autoPlay  // 0x68
  public            System.Single                   frameRate  // 0x6C
  public            System.Collections.Generic.List<UnityEngine.Sprite>sprites  // 0x70
  private           System.Boolean                  <isPlaying>k__BackingField  // 0x78
  private           Beyond.UI.UIImage               m_image  // 0x80
  private           System.Single                   m_curFrameCount  // 0x88
METHODS:
  Beyond.TickType get_tickOption()
  System.Boolean get_isPlaying()
  System.Void set_isPlaying(System.Boolean value)
  System.Void OnAwake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Tick(System.Single deltaTime)
  System.Void Play()
  System.Void Stop(System.Boolean resetToFirstFrame)
  System.Void SetSprite(System.Int32 index)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UISimpleActiveAnimationHelper
TYPE:  class
TOKEN: 0x20000F0
EXTENDS: TickableUIMono
FIELDS:
  public            System.Boolean                  isActive  // 0x68
  public            System.String                   toActiveAnimationName  // 0x70
  private           UnityEngine.Animation           m_animation  // 0x78
  private           UnityEngine.AnimationState      m_animationState  // 0x80
  private           System.Single                   m_animationTime  // 0x88
  private           System.Single                   m_curAnimationTime  // 0x8C
METHODS:
  Beyond.TickType get_tickOption()
  System.Void Start()
  System.Void OnEnable()
  System.Void Skip()
  System.Void Tick(System.Single deltaTime)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UISimpleStateController
TYPE:  class
TOKEN: 0x20000F1
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<Beyond.UI.UISimpleStateController.StateInfo>_states  // 0x18
  private           System.String                   m_curStateName  // 0x20
METHODS:
  System.String get_curStateName()
  System.Void SetState(System.String stateName)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UISizeFollower
TYPE:  class
TOKEN: 0x20000F3
EXTENDS: TickableUIMono
FIELDS:
  public            UnityEngine.RectTransform       target  // 0x68
  public            UnityEngine.Vector2             addedSize  // 0x70
  public            System.Boolean                  isSumSize  // 0x78
  public            System.Boolean                  followWidth  // 0x79
  public            System.Boolean                  followHeight  // 0x7A
  public            System.Boolean                  regulateAnchoredPosition  // 0x7B
  public            UnityEngine.Vector2             minSize  // 0x7C
  public            UnityEngine.Vector2             maxSize  // 0x84
  private           UnityEngine.RectTransform       m_rectTransform  // 0x90
METHODS:
  Beyond.TickType get_tickOption()
  UnityEngine.RectTransform get_rectTransform()
  System.Void LateTick(System.Single deltaTime)
  System.Void SyncSize()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UISlider
TYPE:  class
TOKEN: 0x20000F4
EXTENDS: Slider
FIELDS:
  public            System.Single                   snapCenterRange  // 0x1E8
  public            System.String                   audioSlide  // 0x1F0
  public            System.String                   audioClickHandle  // 0x1F8
  private           System.Boolean                  m_dragging  // 0x200
  public            UnityEngine.UI.Slider.SliderEventonEndDragSlider  // 0x208
  public            UnityEngine.UI.Slider.SliderEventonClickSlider  // 0x210
  public            UnityEngine.UI.Slider.SliderEventonClickSliderHandle  // 0x218
  public            System.String                   sliderAddActionId  // 0x220
  public            System.String                   sliderReduceActionId  // 0x228
  private   readonly Beyond.DisposedUnityEvent       <bindingViewUpdateEvent>k__BackingField  // 0x230
  private           System.Int32                    m_bindingGroupId  // 0x238
  private           Beyond.Input.IBindingGroupTarget<parentTarget>k__BackingField  // 0x240
  public            System.Boolean                  snapStep  // 0x248
  public            System.Single                   stepValue  // 0x24C
  protected         System.Boolean                  _enableStickScroll  // 0x250
  protected         System.Single                   _stickScrollTolerance  // 0x254
  protected         System.Single                   _stickOverPushThreshold  // 0x258
  protected         System.Int32                    _stickOverPushMultiplier  // 0x25C
  protected         System.Int32                    _stickScrollBatchCount  // 0x260
  private           System.Int32                    m_stickScrollHoriBindingId  // 0x264
METHODS:
  System.Void _TryPostSlideAudioEvent()
  System.Single ClampValue(System.Single input)
  System.Single CustomProcessNormalizedValue(System.Single val)
  System.Void OnValueChanged()
  System.Void OnClickSliderBar()
  System.Void OnClickSliderHandle()
  System.Void _NotifyIsHover(System.Boolean isHover)
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void ClearComponent()
  System.Void OnDestroy()
  System.String get_bindingViewActionId()
  System.String get_bindingViewLabelText()
  Beyond.DisposedUnityEvent get_bindingViewUpdateEvent()
  UnityEngine.RectTransform get_redDotTrans()
  System.Boolean get_bindingEnabled()
  Beyond.Input.BindingViewState get_bindingViewState()
  System.String GetBindingViewActionId(Beyond.Input.BindingViewActionType actionType)
  System.Void Beyond.Input.IBindingView.OnInputKeyDown()
  System.Void Beyond.Input.IBindingView.OnInputKeyUp()
  System.Int32 get_groupId()
  Beyond.Input.IBindingGroupTarget get_parentTarget()
  System.Void set_parentTarget(Beyond.Input.IBindingGroupTarget value)
  System.Boolean get_groupEnabled()
  System.Void _InitBinding()
  System.Void _AddValue()
  System.Void _ReduceValue()
  System.Void _InitStickScroll()
  System.Void _StickScrollHoriValue()
  System.Void _ApplyStickScroll(System.Single deltaConcern)
  System.Void .ctor()
  System.Boolean Beyond.Input.IBindingView.get_interactable()
  System.Single <>iFixBaseProxy_ClampValue(System.Single P0)
  System.Single <>iFixBaseProxy_CustomProcessNormalizedValue(System.Single P0)
  System.Void <>iFixBaseProxy_OnValueChanged()
  System.Void <>iFixBaseProxy_OnClickSliderBar()
  System.Void <>iFixBaseProxy_OnClickSliderHandle()
  System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0)
  System.Void <>iFixBaseProxy_Awake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.UISoftMask
TYPE:  class
TOKEN: 0x20000F5
EXTENDS: TickableUIMono
FIELDS:
  private           UnityEngine.Vector3[]           m_fourCornersArray  // 0x68
  private           UnityEngine.Vector3[]           m_fourCornersArrayWorld  // 0x70
  private           System.Collections.Generic.List<Beyond.UI.UISoftMaskable>m_cacheSoftMaskables  // 0x78
  private   static  System.Collections.Generic.List<UnityEngine.Canvas>s_cacheCanvas  // 0x0
  private   static  UnityEngine.UI.Image            s_image  // 0x8
  private           UnityEngine.Shader              _maskableDefaultShader  // 0x80
  private           UnityEngine.Shader              _maskableTextShader  // 0x88
  private   static  System.Int32                    s_SoftMaskTexId  // 0x10
  private   static  System.Int32                    s_SoftMaskTexSTId  // 0x14
  private   static  System.Int32                    s_WorldToSoftMaskId  // 0x18
  private   static  System.Int32                    s_InnerSoftMaskId  // 0x1C
  private   static  System.Int32                    s_InnerSoftMaskUVId  // 0x20
  private   static  System.Int32                    s_SpriteSlicedFlag  // 0x24
  private           UnityEngine.Texture             m_mainTexture  // 0x90
  private           UnityEngine.Vector4             m_spriteTillingOffset  // 0x98
  private           UnityEngine.Matrix4x4           m_worldToSoftMask  // 0xA8
  private           UnityEngine.Vector4             m_innerSoftMask  // 0xE8
  private           UnityEngine.Vector4             m_innerSoftMaskUV  // 0xF8
  private           Beyond.UI.UISoftMask.SlicedSpriteParamsm_slicedSpriteParams  // 0x108
  private           UnityEngine.Material            m_softMaskDefaultMaterial  // 0x130
  private           System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material>m_softMaskTextMaterials  // 0x138
  private           System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material>m_softMaskUIVFXMaterials  // 0x140
METHODS:
  Beyond.TickType get_tickOption()
  UnityEngine.Material get_softMaskDefaultMaterial()
  UnityEngine.Material GetTextSoftMaskMaterial(UnityEngine.Material baseMaterial)
  UnityEngine.Material GetUIVFXSoftMaskMaterial(UnityEngine.Material baseMaterial)
  UnityEngine.Vector3 GetCornerCanvas(System.Int32 i)
  UnityEngine.Vector3[] GetFourCornnerArrayWorld()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void TailLateTick(System.Single deltaTime)
  System.Void _Clear()
  System.Void _DestroyMaterial(UnityEngine.Material material)
  System.Void _UpdateParam()
  System.Void _UpdateChildren(System.Boolean markVertices, System.Boolean markMaterial)
  System.Void _OnEnableRuntimeAtlas()
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_TailLateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UISoftMaskable
TYPE:  class
TOKEN: 0x20000F7
EXTENDS: TickableUIMono
FIELDS:
  public            System.Boolean                  _clipMeshToSaveOverDraw  // 0x68
  private           System.Collections.Generic.List<UnityEngine.UIVertex>m_cacheVertexSteram  // 0x70
  private           System.Collections.Generic.List<UnityEngine.UIVertex>m_cacheDstVertexSteram  // 0x78
  protected static readonly System.String                   UI_MINIMAP_MIST_KEYWORD  // 0x0
  protected static readonly System.String                   UI_VFX_PARAM  // 0x8
  private           Beyond.UI.UISoftMaskable.TestLine[]m_testLinesCache  // 0x80
  private           UnityEngine.Material            m_softMaskModefiedMat  // 0x88
  private           UnityEngine.UI.Graphic          m_graphic  // 0x90
  private           Beyond.UI.UISoftMask            m_softMask  // 0x98
  private           Beyond.UI.UIText                m_uiText  // 0xA0
  private           Beyond.UI.UISoftMaskable.UIType m_uiType  // 0xA8
METHODS:
  Beyond.TickType get_tickOption()
  UnityEngine.Material get_softMaskModefiedMat()
  UnityEngine.UI.Graphic get_graphic()
  Beyond.UI.UISoftMask get_softMask()
  Beyond.UI.UIText get_uiText()
  UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void LateTick(System.Single deltaTime)
  System.Void MarkGraphicVerticesDirty()
  System.Void MarkGraphicMaterialDirty()
  System.Void ModifyMesh(UnityEngine.Mesh mesh)
  System.Boolean _Equal(System.Single a, System.Single b)
  UnityEngine.Vector2 _ComputeLineCross(UnityEngine.Vector2 line0p0, UnityEngine.Vector2 line0p1, UnityEngine.Vector2 line1p0, UnityEngine.Vector2 line1p1)
  System.Void _ComputePointAtTriangleUV(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 q, System.Single& u, System.Single& v)
  System.Void _ClipTriangleByClampSoftMaskUV(UnityEngine.UIVertex[] vertices, UnityEngine.UIVertex[] resultPoint, System.Boolean& canSkip)
  System.Void _ClipRect()
  System.Void ModifyMesh(UnityEngine.UI.VertexHelper vertHelper)
  System.Void _SetUIVertexUV(UnityEngine.UIVertex& uiVertex, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1, UnityEngine.Vector2 softMaskUV)
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UISortingOrder
TYPE:  class
TOKEN: 0x20000FA
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Int32                    _sortingOrderOffset  // 0x18
  private           Beyond.UI.UISortingOrder.RenderType_renderType  // 0x1C
  private           UnityEngine.Renderer            m_renderer  // 0x20
  private           UnityEngine.Renderer[]          m_childrenRenderers  // 0x28
  private           UnityEngine.Canvas              m_canvas  // 0x30
  private           Beyond.UI.LuaPanel              m_luaPanel  // 0x38
METHODS:
  System.Void OnEnable()
  System.Void _GetRenderer()
  System.Void _GetChildrenRenderers()
  System.Void _GetCanvas()
  System.Void SetOrder(System.Int32 baseOrder)
  System.Void Awake()
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIStepScrollList
TYPE:  class
TOKEN: 0x20000FC
EXTENDS: UIScrollList
FIELDS:
  public            Beyond.DisposedUnityEvent<System.Int32,System.Int32>onCenterIndexChanged  // 0x278
  public            Beyond.DisposedUnityEvent       onScrollOrDragEnd  // 0x280
  public            Beyond.DisposedUnityEvent       onScrollOrDragStart  // 0x288
  protected         System.Single                   _easyDragSpdThreshold  // 0x290
  protected         System.Single                   _easyDragDistPercentThreshold  // 0x294
  private           System.Int32                    m_startDragCenterIndex  // 0x298
  private           System.Int32                    m_centerIndex  // 0x29C
  private           UnityEngine.Vector2             m_scrollStartNormalizedPos  // 0x2A0
METHODS:
  System.Int32 get_centerIndex()
  System.Void Init(System.Boolean isPreview)
  System.Void InitConfig()
  System.Void OnScroll(UnityEngine.Vector2 v)
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void SetTop(System.Boolean needUpdate)
  System.Void UpdateShowingCells(System.Boolean forceUpdateContent, System.Boolean forceClearShowingCells, System.Boolean ignoreListActive)
  System.Void ClearComponent()
  System.Void _OnScrollStart(UnityEngine.Vector2 normalizedPos)
  System.Void _OnScrollEnd(UnityEngine.Vector2 normalizedPos)
  System.Void _TryAutoScroll(System.Boolean isEasyDrag, System.Boolean goNext)
  System.Int32 _GetClampedIndex()
  System.Void OnDisable()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Init(System.Boolean P0)
  System.Void <>iFixBaseProxy_InitConfig()
  System.Void <>iFixBaseProxy_OnScroll(UnityEngine.Vector2 P0)
  System.Void <>iFixBaseProxy_OnBeginDrag(UnityEngine.EventSystems.PointerEventData P0)
  System.Void <>iFixBaseProxy_OnEndDrag(UnityEngine.EventSystems.PointerEventData P0)
  System.Void <>iFixBaseProxy_SetTop(System.Boolean P0)
  System.Void <>iFixBaseProxy_UpdateShowingCells(System.Boolean P0, System.Boolean P1, System.Boolean P2)
  System.Void <>iFixBaseProxy_ClearComponent()
  System.Void <>iFixBaseProxy_OnDisable()
END_CLASS

CLASS: Beyond.UI.UIStyleByState
TYPE:  class
TOKEN: 0x20000FD
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Collections.Generic.List<Beyond.UI.UIStyleByState.StyleConfig>styleConfigs  // 0x18
METHODS:
  System.Void Awake()
  System.Void OnDestroy()
  System.Void UpdateStyle()
  System.Boolean _IsValidStyle(Beyond.UI.UIStyleByState.StyleConfig styleConfig)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UISubtitle
TYPE:  class
TOKEN: 0x2000100
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.UI.UIText                _topText  // 0x18
  private           Beyond.UI.UIText                _bottomText  // 0x20
METHODS:
  System.Void Start()
  System.Void _SetAsDefault()
  System.Void SetSubtitle(System.String subtitle, System.Boolean showOnTop)
  System.Void UpdateAlpha(System.Single alpha, System.Boolean isTop)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UITextPair
TYPE:  class
TOKEN: 0x2000101
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Collections.Generic.List<Beyond.UI.UIText>referencedTexts  // 0x18
METHODS:
  System.String get_text()
  System.Void set_text(System.String value)
  System.Void set_color(UnityEngine.Color value)
  Beyond.UI.UIText get_first()
  System.Void SetAndResolveTextStyle(System.String targetText)
  System.Void SetPhoneticText(Beyond.GEnums.PhoneticType phoneticType, System.String id)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIToggle
TYPE:  class
TOKEN: 0x2000102
EXTENDS: Toggle
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.GameObject>_onObjects  // 0x1A8
  private           System.Collections.Generic.List<UnityEngine.GameObject>_offObjects  // 0x1B0
  private           Beyond.UI.UIState.UIStateController_uiStateController  // 0x1B8
  private           System.String                   _onStateName  // 0x1C0
  private           System.String                   _offStateName  // 0x1C8
  private           System.String                   _onAnimation  // 0x1D0
  private           System.String                   _offAnimation  // 0x1D8
  private           System.String                   _audioToggleOn  // 0x1E0
  private           System.String                   _audioToggleOff  // 0x1E8
  private           System.String                   _audioInvalid  // 0x1F0
  public            System.Boolean                  _ignoreClickOnDrag  // 0x1F8
  private           UnityEngine.Vector2             <startPressPos>k__BackingField  // 0x1FC
  private           Beyond.LangKey                  _invalidClickLangKey  // 0x208
  public            System.Func<System.Boolean,System.Boolean>checkIsValueValid  // 0x218
  private           UnityEngine.Animation           m_animation  // 0x220
  private           System.Int32                    m_groupId  // 0x228
  public            System.String                   toggleActionId  // 0x230
  private           System.Int32                    <toggleBindingId>k__BackingField  // 0x238
  private           System.Boolean                  m_started  // 0x23C
  public            System.String                   clickOnHintTextId  // 0x240
  public            System.String                   clickOffHintTextId  // 0x248
  private           Beyond.Input.ActionOnSetNaviTarget_actionOnSetNaviTarget  // 0x250
  private           System.Boolean                  _useNoHintAction  // 0x254
  public            System.String                   onHintTextId  // 0x258
  public            System.String                   offHintTextId  // 0x260
  private           System.Int32                    <hoverConfirmBindingId>k__BackingField  // 0x268
METHODS:
  UnityEngine.Vector2 get_startPressPos()
  System.Void set_startPressPos(UnityEngine.Vector2 value)
  System.Int32 get_toggleBindingId()
  System.Void set_toggleBindingId(System.Int32 value)
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void _UpdateBindingEnable()
  System.Void OnDestroy()
  System.Void Start()
  System.Void InternalToggle()
  System.Void _InitToggleBinding()
  System.Boolean _OnToggleFail()
  System.Void PlayAudio()
  System.Void OnValueChange()
  System.Void _NotifyIsHover(System.Boolean isHover)
  System.Void _UpdateObjects()
  System.Void _PlayAnimation(System.Boolean skipToEnd)
  System.Void ClearComponent()
  System.Void OnInteractableChanged()
  System.Boolean GetMouseActionHints(System.String& clickHintTextId, System.String& longPressHintTextId)
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void TryInternalToggle()
  System.Int32 get_hoverConfirmBindingId()
  System.Void set_hoverConfirmBindingId(System.Int32 value)
  System.Void OnNaviTargetEnabledAgain()
  System.Void _OnSetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode)
  System.Void _InitActionOnSetNaviTarget()
  System.Void _ToggleNaviInputBinding(System.Boolean active)
  System.Void _TryRefreshToggleBindingText()
  System.Void _TryRefreshHoverConfirmBindingText()
  System.Void _TryRefreshBindingText(System.Int32 bindingId)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Awake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_OnDestroy()
  System.Void <>iFixBaseProxy_Start()
  System.Void <>iFixBaseProxy_InternalToggle()
  System.Void <>iFixBaseProxy_OnValueChange()
  System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0)
  System.Void <>iFixBaseProxy_OnInteractableChanged()
  System.Boolean <>iFixBaseProxy_GetMouseActionHints(System.String& P0, System.String& P1)
  System.Void <>iFixBaseProxy_OnPointerDown(UnityEngine.EventSystems.PointerEventData P0)
  System.Void <>iFixBaseProxy_OnPointerClick(UnityEngine.EventSystems.PointerEventData P0)
  System.Void <>iFixBaseProxy_OnSubmit(UnityEngine.EventSystems.BaseEventData P0)
  System.Void <>iFixBaseProxy_OnNaviTargetEnabledAgain()
  System.Void <>iFixBaseProxy__OnSetAsNaviTarget(System.Boolean P0, System.Boolean P1)
END_CLASS

CLASS: Beyond.UI.UIToggleGroup
TYPE:  class
TOKEN: 0x2000103
EXTENDS: ToggleGroup
FIELDS:
  private           System.String                   _moveToNextActionId  // 0x28
  private           System.String                   _moveToPreviousActionId  // 0x30
  private           System.Boolean                  _inverse  // 0x38
  private           System.Int32                    <moveToNextBindingId>k__BackingField  // 0x3C
  private           System.Int32                    <moveToPreviousBindingId>k__BackingField  // 0x40
METHODS:
  System.Int32 get_moveToNextBindingId()
  System.Void set_moveToNextBindingId(System.Int32 value)
  System.Int32 get_moveToPreviousBindingId()
  System.Void set_moveToPreviousBindingId(System.Int32 value)
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void MoveToNext()
  System.Void MoveToPrevious()
  System.Void _MoveTo(System.Boolean isNext)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Awake()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_OnDestroy()
END_CLASS

CLASS: Beyond.UI.FingerMoveDirection
TYPE:  struct
TOKEN: 0x2000104
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.FingerMoveDirection   None  // 0x0
  public    static  Beyond.UI.FingerMoveDirection   Anisotropy  // 0x0
  public    static  Beyond.UI.FingerMoveDirection   Same  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UITouchPanel
TYPE:  class
TOKEN: 0x2000105
EXTENDS: TickableUIMono
FIELDS:
  private           System.Single                   _gestureZoomSensitivity  // 0x68
  private           System.Single                   _dragThreshold  // 0x6C
  private           System.Single                   _longPressTime  // 0x70
  private           System.Single                   _longPressMaxDist  // 0x74
  private           System.Single                   _mouseZoomSensitivity  // 0x78
  private           System.Single                   _scrollZoomSensitivity  // 0x7C
  private           System.Boolean                  _useGesturePixelSizeAdjustment  // 0x80
  private           System.Single                   _multiClickInterval  // 0x84
  private           System.Int32                    _multiClickPixelOffset  // 0x88
  private           System.Boolean                  _ignoreClickOnLongPress  // 0x8C
  private           System.Boolean                  _clickThrough  // 0x8D
  private           System.Boolean                  _preventPressWhenClickThrough  // 0x8E
  private           System.Boolean                  m_triggeredLongPress  // 0x8F
  private           System.Int32                    m_clickCount  // 0x90
  private           System.Single                   m_lastClickTime  // 0x94
  private           UnityEngine.Vector2             m_lastClickPos  // 0x98
  private           System.Boolean                  m_isPress  // 0xA0
  private           System.Boolean                  m_isInGestureZoom  // 0xA1
  private           System.Boolean                  m_isActionLongPress  // 0xA2
  private           System.Boolean                  m_dragStarted  // 0xA3
  private           UnityEngine.Vector2             m_dragPosition  // 0xA4
  private           UnityEngine.RectTransform       m_rect  // 0xB0
  private           System.Single                   m_deltaX  // 0xB8
  private           System.Single                   m_deltaY  // 0xBC
  private           UnityEngine.Vector2             m_lastFrameTouchPos  // 0xC0
  private           UnityEngine.EventSystems.PointerEventDatam_touch  // 0xC8
  private           System.Int32                    m_touchId  // 0xD0
  private           System.Int32                    m_touchId1  // 0xD4
  private           System.Int32                    m_touchId2  // 0xD8
  private           System.Single                   m_actionLongPressStartTime  // 0xDC
  private           UnityEngine.Vector2             m_actionLongPressStartPos  // 0xE0
  private           System.Single                   m_pixelSizeAdjustment  // 0xE8
  private           UnityEngine.Vector2             m_touch1Pos  // 0xEC
  private           UnityEngine.Vector2             m_touch1LastPos  // 0xF4
  private           UnityEngine.Vector2             m_touch2Pos  // 0xFC
  private           UnityEngine.Vector2             m_touch2LastPos  // 0x104
  private           UnityEngine.Vector3             m_lastMousePos  // 0x10C
  private           System.Boolean                  m_lastFrameIsRightMouseButtonPress  // 0x118
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onClick  // 0x120
  public            Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData>onRightClick  // 0x128
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onPress  // 0x130
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onLongPress  // 0x138
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onDoubleClick  // 0x140
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onRelease  // 0x148
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>onDrag  // 0x150
  public            Beyond.DisposedUnityEvent<UnityEngine.Vector2>onDragBegin  // 0x158
  public            Beyond.DisposedUnityEvent<UnityEngine.Vector2>onDragEnd  // 0x160
  public            Beyond.DisposedUnityEvent<System.Single>onZoom  // 0x168
  public            Beyond.DisposedUnityEvent<UnityEngine.Vector2,Beyond.UI.FingerMoveDirection>onHorizonAndVerticalZoom  // 0x170
  public            Beyond.DisposedUnityEvent       onDragToLeft  // 0x178
  public            Beyond.DisposedUnityEvent       onDragToRight  // 0x180
  public            Beyond.DisposedUnityEvent       onPointerEnter  // 0x188
  public            Beyond.DisposedUnityEvent       onPointerExit  // 0x190
  public            Beyond.DisposedUnityEvent       onDragToUp  // 0x198
  public            Beyond.DisposedUnityEvent       onDragToDown  // 0x1A0
  public            Beyond.DisposedUnityEvent<UnityEngine.Vector2>onRightMouseButtonPress  // 0x1A8
  public            Beyond.DisposedUnityEvent<System.Single>onScroll  // 0x1B0
  private           UnityEngine.Vector2             <curPressPos>k__BackingField  // 0x1B8
  private           System.Boolean                  <isPointerEntered>k__BackingField  // 0x1C0
  public            System.Boolean                  enableZoom  // 0x1C1
  public            Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData>rawOnDrag  // 0x1C8
  private           System.Single                   m_leftMousePressDownTimeWithNoCursor  // 0x1D0
  private           System.Single                   m_rightMousePressDownTimeWithNoCursor  // 0x1D4
  private           System.Int32                    m_groupId  // 0x1D8
  private           System.Boolean                  m_bindingInit  // 0x1DC
  private           Beyond.Input.InputBindingGroupMonoTarget<parent>k__BackingField  // 0x1E0
METHODS:
  Beyond.TickType get_tickOption()
  UnityEngine.Vector2 get_touchPos()
  UnityEngine.Vector2 get_curPressPos()
  System.Void set_curPressPos(UnityEngine.Vector2 value)
  System.Boolean get_isPointerEntered()
  System.Void set_isPointerEntered(System.Boolean value)
  System.Boolean get_isDragging()
  System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void DoEndDrag(UnityEngine.Vector2 dragPos)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void _OnActionPress(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void _OnActionRelease(UnityEngine.EventSystems.PointerEventData eventData)
  System.Boolean _IsSameTouchFromPress(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void ClearTouchInfo()
  System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void SimulateClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void DeActiveTouch(System.Int32 touchId)
  System.Void OnAwake()
  System.Void Tick(System.Single deltaTime)
  System.Void LateTick(System.Single deltaTime)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void OnRelease()
  System.Boolean get_groupEnabled()
  System.Int32 get_groupId()
  Beyond.Input.IBindingGroupTarget get_parentTarget()
  Beyond.Input.InputBindingGroupMonoTarget get_parent()
  System.Void set_parent(Beyond.Input.InputBindingGroupMonoTarget value)
  System.Void InitBinding()
  System.Void _UpdateState()
  System.Void ClearComponent()
  System.Void .ctor()
  System.Void <InitBinding>b__110_0()
  System.Void <InitBinding>b__110_1()
  System.Void <>iFixBaseProxy_OnAwake()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_OnDestroy()
  System.Void <>iFixBaseProxy_OnRelease()
END_CLASS

CLASS: Beyond.UI.UIVFXManager
TYPE:  class
TOKEN: 0x2000106
EXTENDS: TickableUIMono
FIELDS:
  private   static  System.Int32                    s_vfxMainTexSTId  // 0x0
  private           UnityEngine.Vector4             m_spriteTillingOffset  // 0x68
  private           UnityEngine.Material            m_uiDefaultVFXMaterial  // 0x78
  private           System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material>m_UIVfxMaterials  // 0x80
  private           UnityEngine.Shader              m_uiDefaultShader  // 0x88
  private           UnityEngine.UI.Graphic          m_graphic  // 0x90
  private           Beyond.UI.UISoftMaskable        m_softMaskable  // 0x98
METHODS:
  Beyond.TickType get_tickOption()
  UnityEngine.UI.Graphic get_graphic()
  Beyond.UI.UISoftMaskable get_softMaskable()
  System.Void OnEnable()
  System.Void LateTick(System.Single deltaTime)
  System.Void _OnEnableRuntimeAtlas()
  System.Void OnDisable()
  System.Void _Clear()
  System.Void _DestroyMaterial(UnityEngine.Material material)
  System.Void _UpdateParam()
  UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial)
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_LateTick(System.Single P0)
  System.Void <>iFixBaseProxy_OnDisable()
END_CLASS

CLASS: Beyond.UI.UIWorldLevelScrollListAnimCtrl
TYPE:  class
TOKEN: 0x2000107
EXTENDS: MonoBehaviour
FIELDS:
  public            Beyond.UI.UIWorldLevelScrollListAnimCtrl.ScrollListLayoutInfoupLayoutGroup  // 0x18
  public            Beyond.UI.UIWorldLevelScrollListAnimCtrl.ScrollListLayoutInfodownLayoutGroup  // 0x20
  public            Beyond.UI.UIWorldLevelScrollListAnimCtrl.ScrollListLayoutInfomiddleLayoutGroup  // 0x28
  public            UnityEngine.AnimationCurve      speedCurve  // 0x30
  private           System.Collections.IEnumerator  m_enumerator  // 0x38
  private           System.String                   _audioEnd  // 0x40
METHODS:
  System.Void UpdateUpPos(System.Int32 current)
  System.Void UpdateDownPos(System.Int32 current)
  System.Void UpdateMidPos(System.Int32 current)
  System.Void UpdateWorldLevelScrollList(System.Boolean isUp, System.Int32 count)
  System.Void OnDisable()
  System.Collections.IEnumerator _ScrollLayouts(System.Boolean isUp, System.Int32 count)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.VirtualMouseInitPos
TYPE:  class
TOKEN: 0x200010A
EXTENDS: MonoBehaviour
FIELDS:
  private           Beyond.UI.LuaPanel              m_panel  // 0x18
METHODS:
  Beyond.UI.LuaPanel get_panel()
  System.Void OnEnable()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.CSPopupPanel
TYPE:  class
TOKEN: 0x200010B
EXTENDS: MonoBehaviour
FIELDS:
  public    static  System.String                   KEY  // 0x0
  public            Beyond.UI.UIButton              confirmBtn  // 0x18
  public            Beyond.UI.UIButton              cancelBtn  // 0x20
  public            Beyond.UI.UIText                contentTxt  // 0x28
  public            UnityEngine.GameObject          bg1  // 0x30
  public            UnityEngine.GameObject          bg2  // 0x38
  public            UnityEngine.GameObject          warningImg  // 0x40
  public            Beyond.UI.UIScrollRect          scrollRect  // 0x48
  private           System.Action                   m_onConfirm  // 0x50
  private           System.Action                   m_onCancel  // 0x58
  private   static  Beyond.Resource.FAssetProxyHandles_handle  // 0x0
  public            System.Int32                    timeScaleKey  // 0x60
METHODS:
  System.Void Awake()
  System.Void _OnConfirm(UnityEngine.EventSystems.PointerEventData p)
  System.Void _OnCancel(UnityEngine.EventSystems.PointerEventData p)
  System.Void OnDestroy()
  System.Void Show(System.String content, System.Action onConfirm, System.Boolean showCancel, System.Action onCancel, System.String confirmTxt, System.String cancelTxt, System.Boolean showWarning)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.LuaUIRoot
TYPE:  class
TOKEN: 0x200010C
EXTENDS: MonoBehaviour
FIELDS:
  public            Beyond.SerializeReferenceDictionary<System.String,Beyond.UI.LuaUIRootNode>nodeDic  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.LuaUIRootNode
TYPE:  class
TOKEN: 0x200010D
EXTENDS: MonoBehaviour
FIELDS:
  public            System.String                   panelName  // 0x18
  public            System.String                   panelFolder  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.MobileMotionManager
TYPE:  class
TOKEN: 0x200010E
EXTENDS: BaseManager
FIELDS:
  private   static  System.String                   COMMON_MOTION_SHORT  // 0x0
  private   static  System.String                   COMMON_MOTION_OPERATE_SUCCESS  // 0x0
  private   static  System.String                   COMMON_MOTION_OPERATE_FAILURE  // 0x0
  private   static  System.String                   MOTION_LEVEL_LOW  // 0x0
  private   static  System.String                   MOTION_LEVEL_MEDIUM  // 0x0
  private   static  System.String                   MOTION_LEVEL_HIGH  // 0x0
  private           Beyond.UI.MobileMotionManager.MotionLevelm_currMotionLevel  // 0x18
METHODS:
  System.Void OnInit()
  System.Void OnRelease()
  System.UInt32 PostEventCommonShort()
  System.UInt32 PostEventCommonOperateSuccess()
  System.UInt32 PostEventCommonOperateFailure()
  System.UInt32 PostEvent(System.String eventName)
  System.Void _CheckMotionLevelAndPostIfChange()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.I18nFontLoader
TYPE:  class
TOKEN: 0x2000110
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Int32,Beyond.Resource.FAssetProxyHandle>s_id2FontDic  // 0x0
  private   static  System.Collections.Generic.Dictionary<System.String,Beyond.Resource.FAssetProxyHandle>s_name2MaterialDic  // 0x8
  private   static  Beyond.Resource.FAssetProxyHandles_fontSearchDataHandle  // 0x10
METHODS:
  Beyond.I18n.I18nFontSearchData get_fontSearchData()
  UnityEngine.Material GetMaterial(System.String matName)
  TMPro.TMP_FontAsset GetI18nFont(System.Int32 cnFontId)
  System.Int32 GetCNFontId(TMPro.TMP_FontAsset font)
  System.Boolean IsFontDefaultMaterial(UnityEngine.Material mat)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.DynamicFontAssetLoader
TYPE:  class
TOKEN: 0x2000111
FIELDS:
  private           System.Collections.Generic.List<Beyond.UI.DynamicFontAssetLoader.FontAssetRef><fontAssets>k__BackingField  // 0x10
  private   static  System.Collections.Generic.HashSet<System.UInt32>s_notFoundUnicodes  // 0x0
METHODS:
  System.Collections.Generic.List<Beyond.UI.DynamicFontAssetLoader.FontAssetRef> get_fontAssets()
  System.Void set_fontAssets(System.Collections.Generic.List<Beyond.UI.DynamicFontAssetLoader.FontAssetRef> value)
  System.Void .ctor()
  System.Void AddNotFoundUnicode(System.UInt32 unicode, System.Boolean forceLog)
  System.Boolean TryGetFontAsset(TMPro.TMP_Text refText, System.UInt32 unicode, TMPro.TMP_FontAsset& fontAsset)
  System.Void TryRemoveRefText(TMPro.TMP_Text refText)
  System.Void Dispose()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.TweenUtils
TYPE:  class
TOKEN: 0x2000113
FIELDS:
METHODS:
  System.Boolean TickAsCountDown(System.Single& countDown, System.Single timeDelta)
END_CLASS

CLASS: Beyond.UI.UIAnimationLayerMixPlayer
TYPE:  class
TOKEN: 0x2000115
EXTENDS: SingleMixerAssetPlayer`4
FIELDS:
  private           UnityEngine.Animator            m_target  // 0x60
  private           System.String                   m_outputName  // 0x68
METHODS:
  System.Void .ctor(UnityEngine.Animator target, System.String outputName)
  System.Void LockToClip(UnityEngine.AnimationClip clip, System.Single clipPos)
  UnityEngine.Playables.PlayableGraph CreateGraph()
  UnityEngine.Animations.AnimationLayerMixerPlayable CreateMixer(UnityEngine.Playables.PlayableGraph graph, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FMixerOptions<UnityEngine.AnimationClip>& options)
  UnityEngine.Animations.AnimationPlayableOutput CreateOutput(UnityEngine.Playables.PlayableGraph graph)
  UnityEngine.Animations.AnimationClipPlayable CreateSourceFromAsset(UnityEngine.AnimationClip clip, UnityEngine.Playables.PlayableGraph graph, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FPlayableMeta<UnityEngine.AnimationClip>& meta)
END_CLASS

CLASS: Beyond.UI.UIAnimationMixPlayer
TYPE:  class
TOKEN: 0x2000116
EXTENDS: SingleMixerAssetPlayer`4
FIELDS:
  private           UnityEngine.Animator            m_target  // 0x60
  private           System.String                   m_outputName  // 0x68
METHODS:
  System.Void .ctor(UnityEngine.Animator target, System.String outputName)
  System.Void LockToClip(UnityEngine.AnimationClip clip, System.Single clipPos)
  UnityEngine.Playables.PlayableGraph CreateGraph()
  UnityEngine.Animations.AnimationMixerPlayable CreateMixer(UnityEngine.Playables.PlayableGraph graph, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FMixerOptions<UnityEngine.AnimationClip>& options)
  UnityEngine.Animations.AnimationPlayableOutput CreateOutput(UnityEngine.Playables.PlayableGraph graph)
  UnityEngine.Animations.AnimationClipPlayable CreateSourceFromAsset(UnityEngine.AnimationClip clip, UnityEngine.Playables.PlayableGraph graph, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FPlayableMeta<UnityEngine.AnimationClip>& meta)
END_CLASS

CLASS: Beyond.UI.UIListCache`1
TYPE:  class
TOKEN: 0x2000117
FIELDS:
  private           Beyond.UI.UIListCache.FOptions<TComp>m_options  // 0x0
  private           System.Collections.Generic.List<Beyond.UI.UIListCache.ItemWrapper<TComp>>m_items  // 0x0
  private           System.Int32                    m_count  // 0x0
METHODS:
  System.Void .ctor(Beyond.UI.UIListCache.FOptions<TComp> options)
  System.Void Refresh(System.Int32 count, System.Action<TComp,System.Int32> refreshFunc, System.Boolean shouldHide, System.Action<TComp,System.Int32> onDisableFunc)
  TComp GetItem(System.Int32 index)
  Beyond.UI.UIListCache.ItemWrapper<TComp> _CreateNewItem()
END_CLASS

CLASS: Beyond.UI.UILoadImageSprite
TYPE:  class
TOKEN: 0x200011A
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Boolean                  isAsync  // 0x18
  public            System.Boolean                  setNativeSize  // 0x19
  protected         System.String                   m_spritePath  // 0x20
  protected         UnityEngine.UI.Image            m_imageComp  // 0x28
  protected         Beyond.Resource.FAssetProxyHandlem_handle  // 0x30
METHODS:
  System.String get_spritePath()
  System.Void set_spritePath(System.String value)
  System.Void OnDestroy()
  System.Void _LoadSprite(System.String path)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UILoadImageSpriteByName
TYPE:  class
TOKEN: 0x200011C
EXTENDS: UILoadImageSprite
FIELDS:
  private           System.String                   _folderPath  // 0x48
METHODS:
  System.Void set_spriteName(System.String value)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UISwitchTween
TYPE:  class
TOKEN: 0x200011D
FIELDS:
  private           Beyond.UI.UISwitchTween.Options m_options  // 0x10
  private           Beyond.UI.UISwitchTween.ITweenHandlerm_tween  // 0x20
  private           System.Boolean                  m_isInited  // 0x28
  private           System.Boolean                  m_isShowing  // 0x29
  private           Beyond.UI.UISwitchTween.TweenContextm_context  // 0x2C
METHODS:
  Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfShow()
  Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfHide()
  System.Void BeforeShowEffect()
  System.Void BeforeHideEffect()
  System.Void AfterShowEffect()
  System.Void AfterHideEffect()
  System.Void ResetToState(System.Boolean isShow)
  System.Void Show()
  System.Void Hide()
  System.Collections.IEnumerator WaitForTweening()
  System.Void SetOptions(Beyond.UI.UISwitchTween.Options options)
  System.Boolean get_isTweening()
  System.Boolean get_isShow()
  System.Void set_isShow(System.Boolean value)
  System.Void Reset(System.Boolean isShow)
  System.Void Clear()
  System.Void _ClearTweenInternal(System.Boolean isReset)
  Beyond.UI.UISwitchTween.TweenContext GetContext()
  System.Void ClearTween()
  System.Void .ctor()
  System.Void <Show>b__17_0()
  System.Void <Hide>b__18_0()
END_CLASS

CLASS: Beyond.UI.FadeSwitchTween
TYPE:  class
TOKEN: 0x2000124
EXTENDS: UISwitchTween
FIELDS:
  public    static  System.Single                   DEFAULT_TWEEN_DURATION  // 0x0
  private           UnityEngine.CanvasGroup         m_alphaHandler  // 0x30
  private           System.Boolean                  m_ignoreTimeScale  // 0x38
  private           System.Single                   m_activeAlpha  // 0x3C
  private           System.Boolean                  <dontDisableGameObject>k__BackingField  // 0x40
  private           System.Boolean                  <controlBlockRaycast>k__BackingField  // 0x41
  private           Beyond.UI.FadeSwitchTween.Durations<complexDuration>k__BackingField  // 0x44
  private           System.Single                   <duration>k__BackingField  // 0x54
METHODS:
  System.Boolean get_dontDisableGameObject()
  System.Void set_dontDisableGameObject(System.Boolean value)
  System.Boolean get_controlBlockRaycast()
  System.Void set_controlBlockRaycast(System.Boolean value)
  Beyond.UI.FadeSwitchTween.Durations get_complexDuration()
  System.Void set_complexDuration(Beyond.UI.FadeSwitchTween.Durations value)
  System.Void .ctor(UnityEngine.CanvasGroup alphaHandler, System.Boolean ignoreTimeScale)
  System.Void .ctor(UnityEngine.CanvasGroup alphaHandler, System.Single duration, System.Boolean ignoreTimeScale)
  System.Single get_duration()
  System.Void set_duration(System.Single value)
  UnityEngine.CanvasGroup get_alphaHandler()
  System.Single get_activeAlpha()
  System.Void set_activeAlpha(System.Single value)
  Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfHide()
  Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfShow()
  System.Void BeforeShowEffect()
  System.Void AfterHideEffect()
  System.Void ResetToState(System.Boolean isShow)
  System.Void SetObjectActive(UnityEngine.CanvasGroup alphaHandler, System.Boolean isActive)
  System.Void Release()
  System.Void <>iFixBaseProxy_BeforeShowEffect()
  System.Void <>iFixBaseProxy_AfterHideEffect()
  System.Void <>iFixBaseProxy_ResetToState(System.Boolean P0)
END_CLASS

CLASS: Beyond.UI.FadeTranslationSwitchTween
TYPE:  class
TOKEN: 0x2000127
EXTENDS: UISwitchTween
FIELDS:
  private   static  System.Single                   DEFAULT_TWEEN_DURATION  // 0x0
  private           UnityEngine.CanvasGroup         m_alphaHandler  // 0x30
  private           UnityEngine.RectTransform       m_posHandler  // 0x38
  private           UnityEngine.Vector2             m_hidePos  // 0x40
  private           UnityEngine.Vector2             m_showPos  // 0x48
  private           System.Single                   m_duration  // 0x50
  private           System.Single                   m_hideDelay  // 0x54
  private           System.Single                   m_showDelay  // 0x58
METHODS:
  System.Void .ctor(UnityEngine.CanvasGroup alphaHandler, UnityEngine.RectTransform posHandler, UnityEngine.Vector2 hidePos, UnityEngine.Vector2 showPos, System.Single duration, System.Single hideDelay, System.Single showDelay)
  Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfHide()
  Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfShow()
  System.Void BeforeShowEffect()
  System.Void AfterHideEffect()
  System.Void ResetToState(System.Boolean isShow)
  System.Single _GetTargetAlpha(System.Boolean isShow)
  UnityEngine.Vector2 _GetTargetPos(System.Boolean isShow)
  System.Void <>iFixBaseProxy_BeforeShowEffect()
  System.Void <>iFixBaseProxy_AfterHideEffect()
  System.Void <>iFixBaseProxy_ResetToState(System.Boolean P0)
END_CLASS

CLASS: Beyond.UI.UIAtlasManager
TYPE:  class
TOKEN: 0x2000129
EXTENDS: Singleton`1
FIELDS:
  private           Beyond.TickFunction             m_lateTickFunction  // 0x10
  public    static  System.Int32                    ATLAS_PAGE_WIDTH  // 0x0
  public    static  System.Int32                    ATLAS_PAGE_HEIGHT  // 0x0
  public    static  System.Int32                    IMAGE_USING_ATLAS_MAX_SIZE  // 0x0
  public    static  System.Int32                    UI_IMAGE_BLOCK_ALIGNMENT  // 0x0
  public    static  System.Int32                    PANEL_LEVEL_COUNT  // 0x0
  public    static  System.Int32                    MAX_ATLAS_PER_PANEL_LEVEL  // 0x0
  public    static  System.Int32                    PROCESS_COUNT_PER_FRAME  // 0x0
  public    static  UnityEngine.Experimental.Rendering.GraphicsFormatATLAS_PAGE_FORMAT  // 0x0
  private           System.Boolean                  m_enableRuntimeAtlas  // 0x18
  private           System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIImage>m_imageDict  // 0x20
  private           Beyond.UI.UIAtlasManager.UIAtlasPage[,]m_atlasPagePool  // 0x28
  private           System.Collections.Generic.Queue<Beyond.UI.UIImage>m_insertQueue  // 0x30
  private           System.Collections.Generic.Queue<Beyond.UI.UIAtlasManager.UIAtlasHandle>m_freeQueue  // 0x38
  private           UnityEngine.Rendering.CommandBufferm_commandBuffer  // 0x40
  private           UnityEngine.Experimental.Rendering.GraphicsFormatm_atlasPageFormat  // 0x48
  private   static  System.Boolean                  <enableRuntimeAtlasFromScript>k__BackingField  // 0x0
METHODS:
  System.Boolean get_enableRuntimeAtlas()
  System.Boolean get_enableRuntimeAtlasFromScript()
  System.Void set_enableRuntimeAtlasFromScript(System.Boolean value)
  System.Boolean get_releaseImageSpriteAfterInsert()
  System.Void .ctor()
  System.Void OnInit()
  System.Void OnUnInit()
  System.Void Release()
  System.Void _CreateTickFunction()
  System.Void _ClearTickFunction()
  System.Void AddUIImageToManager(Beyond.UI.UIImage image)
  System.Void ReProcessInsertForUIImage(Beyond.UI.UIImage image)
  System.Void RemoveUIImageFromManager(Beyond.UI.UIImage image)
  System.Void AddUIImageToManagerOnInstantiate(Beyond.UI.UIImage image)
  System.Int32 GetAtlasCount()
  System.Void LateTick(System.Single deltaTime)
  System.Void _AddUIImageToManager(Beyond.UI.UIImage image)
  System.Void _ReProcessInsertForUIImage(Beyond.UI.UIImage image)
  System.Void _RemoveUIImageFromManager(Beyond.UI.UIImage image)
  System.Void _AddUIImageToManagerOnInstantiate(Beyond.UI.UIImage image)
  System.Boolean _IsRuntimeAtlasCompatible(Beyond.UI.UIImage image, Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause& failureCause)
  System.Void _ProcessInsertQueue()
  System.Void _ProcessRemoveQueue()
END_CLASS

CLASS: Beyond.UI.WebApplication
TYPE:  class
TOKEN: 0x200012F
FIELDS:
METHODS:
  System.Void Start(System.String url, System.Action onClose)
END_CLASS

CLASS: Beyond.UI.GPUI.ChangeState
TYPE:  struct
TOKEN: 0x2000143
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.GPUI.ChangeState      Stable  // 0x0
  public    static  Beyond.UI.GPUI.ChangeState      New  // 0x0
  public    static  Beyond.UI.GPUI.ChangeState      ChangeSize  // 0x0
  public    static  Beyond.UI.GPUI.ChangeState      ChangeData  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.GPUI.RuntimeNodeInfo
TYPE:  struct
TOKEN: 0x2000144
FIELDS:
  public            Beyond.UI.GPUI.NodeType         nodeType  // 0x10
  public            Beyond.UI.GPUI.SimpleTextAlignmenttextAlignment  // 0x14
  public            System.Int32                    nodeIndex  // 0x18
  public            System.Int32                    childNodeCount  // 0x1C
  public            System.UInt32                   color  // 0x20
  public            UnityEngine.Vector2             position  // 0x24
  public            System.String                   textOverride  // 0x30
  public            System.Boolean                  changed  // 0x38
  public            System.Boolean                  hide  // 0x39
METHODS:
END_CLASS

CLASS: Beyond.UI.GPUI.RuntimeAnimationData
TYPE:  class
TOKEN: 0x2000145
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Single                   duration  // 0x18
  public            System.Collections.Generic.List<Beyond.UI.GPUI.GPUInstanceData>template  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.RuntimePrefabData
TYPE:  class
TOKEN: 0x2000146
FIELDS:
  public            System.Int32                    templateNodeCount  // 0x10
  public            System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeNodeInfo>nodes  // 0x18
  public            System.Collections.Generic.Dictionary<System.String,System.Int32>nodesNameMap  // 0x20
  public            System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeAnimationData>animations  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.GPUPrefabData
TYPE:  struct
TOKEN: 0x2000147
FIELDS:
  public            UnityEngine.Vector4             uv  // 0x10
  public            UnityEngine.Vector4             aniPosScaleMinMax  // 0x20
  public            UnityEngine.Vector4             aniPosAddMinMax  // 0x30
  public            UnityEngine.Vector2             aniURange  // 0x40
  public            System.Single                   aniPosScaleV  // 0x48
  public            System.Single                   aniPosAddV  // 0x4C
  public            System.Single                   aniColorV  // 0x50
  public            System.Single                   aniDurationInv  // 0x54
  public            System.Int32                    materialType  // 0x58
  public            System.UInt32                   materialParam1  // 0x5C
METHODS:
  System.Void .ctor(Beyond.UI.GPUI.NodeSerializeData data)
  System.Void .ctor(UnityEngine.Vector4 uv, UnityEngine.Vector4 scale)
  Beyond.UI.GPUI.GPUPrefabData CreateFontNode(UnityEngine.Vector4 uv, UnityEngine.Vector4 scale, UnityEngine.Vector2 texelSizeInv)
END_CLASS

CLASS: Beyond.UI.GPUI.GPUPrefabDataLite
TYPE:  struct
TOKEN: 0x2000148
FIELDS:
  public            System.Int16                    uvX  // 0x10
  public            System.Int16                    uvY  // 0x12
  public            System.Int16                    uvZ  // 0x14
  public            System.Int16                    uvW  // 0x16
  public            System.UInt16                   aniPosScaleMinX  // 0x18
  public            System.UInt16                   aniPosScaleMinY  // 0x1A
  public            System.UInt16                   aniPosScaleMaxX  // 0x1C
  public            System.UInt16                   aniPosScaleMaxY  // 0x1E
  public            System.UInt16                   aniPosAddMinX  // 0x20
  public            System.UInt16                   aniPosAddMinY  // 0x22
  public            System.UInt16                   aniPosAddMaxX  // 0x24
  public            System.UInt16                   aniPosAddMaxY  // 0x26
  public            System.Int16                    aniURangeX  // 0x28
  public            System.Int16                    aniURangeY  // 0x2A
  public            System.Int16                    aniPosScaleV  // 0x2C
  public            System.Int16                    aniPosAddV  // 0x2E
  public            System.Int16                    aniColorV  // 0x30
  public            System.Int16                    aniDuration  // 0x32
  public            System.UInt16                   materialType  // 0x34
  public            System.UInt16                   materialParam1  // 0x36
  public            System.UInt32                   padding  // 0x38
  public            System.UInt32                   padding2  // 0x3C
METHODS:
  System.Void .ctor(Beyond.UI.GPUI.NodeSerializeData data, UnityEngine.Vector2 texelSizeInv, UnityEngine.Vector2 aniTexelSizeInv)
  System.Void .ctor(UnityEngine.Vector4 uv, UnityEngine.Vector4 scale, UnityEngine.Vector2 texelSizeInv)
  Beyond.UI.GPUI.GPUPrefabDataLite CreateFontNode(UnityEngine.Vector4 uv, UnityEngine.Vector4 scale, UnityEngine.Vector2 texelSizeInv)
END_CLASS

CLASS: Beyond.UI.GPUI.GPUInstanceData
TYPE:  struct
TOKEN: 0x2000149
FIELDS:
  public            System.Single                   animeTime  // 0x10
  public            System.UInt32                   color  // 0x14
  public            UnityEngine.Vector2             pos  // 0x18
  public            System.UInt16                   prefabId  // 0x20
  public            System.UInt16                   parentId  // 0x22
  public            System.UInt16                   grandParentId  // 0x24
  public            System.Byte                     matType  // 0x26
  public            System.Byte                     drawType  // 0x27
  public            System.UInt32                   padding0  // 0x28
  public            System.UInt32                   padding1  // 0x2C
METHODS:
END_CLASS

CLASS: Beyond.UI.GPUI.NodeType
TYPE:  struct
TOKEN: 0x200014A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.GPUI.NodeType         Root  // 0x0
  public    static  Beyond.UI.GPUI.NodeType         Image  // 0x0
  public    static  Beyond.UI.GPUI.NodeType         Text  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.GPUI.SimpleTextAlignment
TYPE:  struct
TOKEN: 0x200014B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.GPUI.SimpleTextAlignmentLeft  // 0x0
  public    static  Beyond.UI.GPUI.SimpleTextAlignmentCenter  // 0x0
  public    static  Beyond.UI.GPUI.SimpleTextAlignmentRight  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.GPUI.NodeSerializeData
TYPE:  class
TOKEN: 0x200014C
FIELDS:
  public            UnityEngine.Vector4             uv  // 0x10
  public            UnityEngine.Vector4             aniPosScaleMinMax  // 0x20
  public            UnityEngine.Vector4             aniPosAddMinMax  // 0x30
  public            UnityEngine.Vector2             aniURange  // 0x40
  public            System.Single                   aniPosScaleV  // 0x48
  public            System.Single                   aniPosAddV  // 0x4C
  public            System.Single                   aniColorV  // 0x50
  public            System.Single                   aniDurationInv  // 0x54
  public            System.Int32                    materialType  // 0x58
  public            System.UInt32                   materialParam1  // 0x5C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.NodeMetadata
TYPE:  class
TOKEN: 0x200014D
FIELDS:
  public            System.String                   nodeName  // 0x10
  public            Beyond.UI.GPUI.NodeType         nodeType  // 0x18
  public            System.String                   nodeTextId  // 0x20
  public            System.String                   nodeText  // 0x28
  public            Beyond.UI.GPUI.SimpleTextAlignmenttextAlignment  // 0x30
  public            System.Single                   nodeTextSize  // 0x34
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.AnimationSerializeData
TYPE:  class
TOKEN: 0x200014E
FIELDS:
  public            System.String                   animationName  // 0x10
  public            System.Single                   animationTime  // 0x18
  public            System.Int32                    totalFrames  // 0x1C
  public            UnityEngine.WrapMode            wrapMode  // 0x20
  public            System.Int32                    renderNodesOffset  // 0x24
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.PrefabSerializeData
TYPE:  class
TOKEN: 0x200014F
FIELDS:
  public            System.String                   prefabName  // 0x10
  public            System.Int32                    nodeCount  // 0x18
  public            System.Boolean                  animationOnly  // 0x1C
  public            System.Collections.Generic.List<Beyond.UI.GPUI.NodeMetadata>nodeMetas  // 0x20
  public            System.Collections.Generic.List<Beyond.UI.GPUI.NodeSerializeData>renderNodes  // 0x28
  public            System.Collections.Generic.List<Beyond.UI.GPUI.AnimationSerializeData>animations  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.PrefabGroupSerializeData
TYPE:  class
TOKEN: 0x2000150
FIELDS:
  public            Beyond.Resource.StringPathHash  spriteTexturePath  // 0x10
  public            Beyond.Resource.StringPathHash  vatTexturePath  // 0x18
  public            System.Collections.Generic.List<Beyond.UI.GPUI.PrefabSerializeData>prefabs  // 0x20
  public            System.Collections.Generic.List<System.String>textIds  // 0x28
  public            System.String                   importantChars  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.GPUIHandle
TYPE:  struct
TOKEN: 0x2000151
FIELDS:
  public            System.Int32                    index  // 0x10
  public            System.Int32                    version  // 0x14
METHODS:
  System.Boolean Equals(Beyond.UI.GPUI.GPUIHandle other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(Beyond.UI.GPUI.GPUIHandle left, Beyond.UI.GPUI.GPUIHandle right)
  System.Boolean op_Inequality(Beyond.UI.GPUI.GPUIHandle left, Beyond.UI.GPUI.GPUIHandle right)
  System.Boolean <>iFixBaseProxy_Equals(System.Object P0)
  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: Beyond.UI.GPUI.GPUISystem
TYPE:  class
TOKEN: 0x2000152
EXTENDS: MaskableGraphic
FIELDS:
  public    static readonly System.String                   CONFIG_JSON_PATH_FORMAT  // 0x0
  public    static readonly System.Int32                    RENDER_GROUP_SIZE  // 0x8
  public    static readonly System.Int32                    RENDER_GROUP_SIZE_GL  // 0xC
  public            System.Collections.Generic.List<UnityEngine.Material>materialTemplates  // 0xE8
  public            System.String                   configGroupName  // 0xF0
  public            System.Int32                    sourceCNFontId  // 0xF8
  private           TMPro.TMP_FontAsset             m_i18NFontAsset  // 0x100
  public            System.Boolean                  noSortingOrder  // 0x108
  private           System.Boolean                  m_liteMode  // 0x109
  private           System.Boolean                  m_inited  // 0x10A
  private           System.Boolean                  m_rendererDisabled  // 0x10B
  private           System.Collections.Generic.List<UnityEngine.Material>m_instancedMaterials  // 0x110
  private           UnityEngine.Texture             m_vatTexture  // 0x118
  private           UnityEngine.Texture             m_spriteTexture  // 0x120
  private           Beyond.Resource.FAssetProxyHandlem_vatTextureHandle  // 0x128
  private           Beyond.Resource.FAssetProxyHandlem_spriteTextureHandle  // 0x13C
  private           System.Single                   m_timeForShader  // 0x150
  private           System.Collections.Generic.Dictionary<System.String,Beyond.UI.GPUI.RuntimePrefabData>m_prefabMap  // 0x158
  private           UnityEngine.Transform           m_targetCanvasTransform  // 0x160
  private           UnityEngine.Matrix4x4           m_canvasObjectToWorldMatrix  // 0x168
  private           System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeInstance>m_instances  // 0x1A8
  private           System.Collections.Generic.Queue<System.Int32>m_recyclePool  // 0x1B0
  private           System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Single,Beyond.UI.GPUI.GPUIHandle>>m_destroyQueue  // 0x1B8
  private           Beyond.UI.GPUI.ITextSystem      m_simpleTextSystem  // 0x1C0
  private           Beyond.UI.GPUI.InstanceBufferManagerm_instanceBufferManager  // 0x1C8
  private           Beyond.UI.GPUI.SimpleBufferManager<Beyond.UI.GPUI.GPUPrefabData>m_prefabBufferManager  // 0x1D0
  private           Beyond.UI.GPUI.SimpleBufferManager<Beyond.UI.GPUI.GPUPrefabDataLite>m_litePrefabBufferManager  // 0x1D8
METHODS:
  TMPro.TMP_FontAsset get_fontAsset()
  System.Void set_fontAsset(TMPro.TMP_FontAsset value)
  System.Boolean CreateInstance(System.String prefabName, UnityEngine.Vector3 initialPosition, Beyond.UI.GPUI.GPUIHandle& handle, System.Int32 sortingOrder)
  System.Boolean DestroyInstance(Beyond.UI.GPUI.GPUIHandle handle)
  System.Boolean IsInstanceValid(Beyond.UI.GPUI.GPUIHandle handle)
  System.Boolean SetRootPosition(Beyond.UI.GPUI.GPUIHandle handle, UnityEngine.Vector3 position)
  System.Boolean SetRootScale(Beyond.UI.GPUI.GPUIHandle handle, UnityEngine.Vector2 scale)
  System.Boolean StartAnimation(Beyond.UI.GPUI.GPUIHandle handle, System.Boolean destroyWhenStopped, System.String animationName, System.Boolean resetDestroy)
  System.Boolean StartAnimation(Beyond.UI.GPUI.GPUIHandle handle, System.Boolean destroyWhenStopped, System.Int32 animationIndex, System.Boolean resetDestroy)
  System.Boolean SetVisibility(Beyond.UI.GPUI.GPUIHandle handle, System.String nodeName, System.Boolean visible)
  System.Boolean SetColor(Beyond.UI.GPUI.GPUIHandle handle, System.String nodeName, UnityEngine.Color color)
  System.Boolean SetText(Beyond.UI.GPUI.GPUIHandle handle, System.String nodeName, System.String text)
  System.Void OnDestroy()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
  System.Void UpdateMaterial()
  System.Void _PreWillRenderCanvases()
  System.Void _Init(System.String jsonPath)
  TMPro.TMP_FontAsset GetFontAsset()
  System.Void _DoLateUpdate()
  System.Void _DoOnDestroy()
  System.Void _RefreshMaterials()
  System.Void _InitMaterials()
  System.Void _CleanMaterials()
  System.Void _RenderNodes()
  System.Void _DestroyAnimatedInstance()
  System.Void _UpdateWorldMat()
  System.Void _PreloadTextInGroupData(Beyond.UI.GPUI.PrefabGroupSerializeData data)
  System.Void _LoadGroupData(Beyond.UI.GPUI.PrefabGroupSerializeData data)
  Beyond.UI.GPUI.RuntimePrefabData _LoadPrefabData(Beyond.UI.GPUI.PrefabSerializeData prefab)
  System.Int32 _LoadPrefabNodeBuffer(Beyond.UI.GPUI.PrefabSerializeData prefab, System.Int32 totalNodeCount)
  System.Boolean _CreateInstance(System.String prefabName, Beyond.UI.GPUI.GPUIHandle& handle, System.Int32 sortingOrder)
  System.Boolean _DestroyInstance(Beyond.UI.GPUI.GPUIHandle handle)
  Beyond.UI.GPUI.GPUIHandle _GetOneHandle()
  System.Boolean _IsHandleInvalid(Beyond.UI.GPUI.GPUIHandle handle)
  System.Void _RecycleOneHandle(Beyond.UI.GPUI.GPUIHandle handle)
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_OnDestroy()
  System.Void <>iFixBaseProxy_OnEnable()
  System.Void <>iFixBaseProxy_OnDisable()
  System.Void <>iFixBaseProxy_OnPopulateMesh(UnityEngine.UI.VertexHelper P0)
  System.Void <>iFixBaseProxy_UpdateMaterial()
END_CLASS

CLASS: Beyond.UI.GPUI.GPUIUtils
TYPE:  class
TOKEN: 0x2000154
FIELDS:
  public    static readonly UnityEngine.Vector3             DEFAULT_NORMAL  // 0x0
  public    static readonly UnityEngine.Vector4             DEFAULT_TANGENT  // 0xC
METHODS:
  UnityEngine.Mesh CreateQuadMesh()
  System.UInt32 ColorToRGBAUint32(UnityEngine.Color color)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.GPUI.InstanceBufferManager
TYPE:  class
TOKEN: 0x2000155
FIELDS:
  private   static readonly Unity.Profiling.ProfilerMarker  MARKER_UPDATE_PERF  // 0x0
  private           Unity.Collections.NativeArray<UnityEngine.CanvasRenderer.InstanceRange>m_gpuGroups  // 0x10
  private           System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeInstance>m_runtimeInstanceView  // 0x20
  private           System.Collections.Generic.List<Beyond.UI.GPUI.InstanceBufferManager.BufferInternalNode>m_bufferInternalNodes  // 0x28
  private           System.Collections.Generic.List<Beyond.UI.GPUI.InstanceBufferManager.BufferInternalNode>m_pendingNodes  // 0x30
  private           System.Collections.Generic.List<Beyond.UI.GPUI.InstanceBufferManager.BufferInternalNode>m_addNodes  // 0x38
  private           System.Collections.Generic.HashSet<Beyond.UI.GPUI.GPUIHandle>m_removeNodes  // 0x40
  private           System.Boolean                  m_hasAnyChanges  // 0x48
  private           System.Boolean                  m_updateBufferOnly  // 0x49
  private           System.Int32                    m_currentStartIndex  // 0x4C
  private           System.Int32                    m_currentLength  // 0x50
  private           System.Int32                    m_capacity  // 0x54
  private           System.Int32                    m_maxCapacity  // 0x58
  private           System.Int32                    m_nodeStride  // 0x5C
  private           System.Int32                    m_gpuGroupCapacity  // 0x60
  private           System.Int32                    m_groupCount  // 0x64
  private           System.Boolean                  m_noSortingOrder  // 0x68
METHODS:
  System.Int32 get_startIndex()
  System.Int32 get_nodeCount()
  System.Int32 get_capacity()
  Unity.Collections.NativeArray<UnityEngine.CanvasRenderer.InstanceRange> get_gpuGroups()
  System.Int32 get_gpuGroupCount()
  System.Void .ctor(System.Int32 initCapacity, System.Int32 maxCapacity, System.Int32 nodeStride, System.Int32 gpuGroupCapacity, System.Boolean noSortingOrder)
  System.Void BindInstanceList(System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeInstance> runtimeInstanceView)
  System.Void MarkNeedUpdate()
  System.Void _FillInstanceQueue(Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData>& oldBuffer, System.Int32& newTotalLength, System.Int32& newTotalLengthWithEmptySlot, System.Int32& fullUpdateIndex)
  System.Void DoUpdate(UnityEngine.CanvasRenderer canvasRenderer)
  System.Void _NewGpuGroup(System.Int32 start, System.Int32 end)
  System.Void Add(Beyond.UI.GPUI.GPUIHandle instance)
  System.Void Remove(Beyond.UI.GPUI.GPUIHandle instance)
  System.Void _AllocBuffer(System.Int32 capacity)
  System.Void Dispose()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.UI.GPUI.RuntimeInstance
TYPE:  class
TOKEN: 0x2000157
FIELDS:
  public    static  System.Int32                    ROOT_NODE_INDEX  // 0x0
  public            System.Int32                    version  // 0x10
  public            Beyond.UI.GPUI.ChangeState      state  // 0x14
  public            System.Int32                    length  // 0x18
  public            System.Int32                    sortingOrder  // 0x1C
  private           Beyond.UI.GPUI.ITextSystem      m_textSystem  // 0x20
  private           Beyond.UI.GPUI.RuntimePrefabDatam_prefab  // 0x28
  private           Beyond.UI.GPUI.RuntimeAnimationDatam_animationData  // 0x30
  private           System.Int32                    m_prefabNodeOffset  // 0x38
  private           Beyond.UI.GPUI.RuntimeNodeInfo[]m_nodeInfo  // 0x40
  private           System.Int32                    m_nodeInfoCount  // 0x48
  private           System.Single                   m_animationDuration  // 0x4C
  private           System.Single                   m_animationTime  // 0x50
  private           UnityEngine.Vector2             m_rootScale  // 0x54
METHODS:
  Beyond.UI.GPUI.RuntimePrefabData get_Prefab()
  System.Single get_AnimationDuration()
  System.Void Create(Beyond.UI.GPUI.RuntimePrefabData prefab, Beyond.UI.GPUI.ITextSystem textSystem)
  System.Void Recycle()
  System.Void DoUpdate(Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData>& buffer, System.Int32 startIndexInBuffer, System.Boolean full)
  System.Void SetRootScale(UnityEngine.Vector2 rootScale)
  System.Void SetPosition(System.Int32 index, UnityEngine.Vector3 position)
  System.Void StartAnimation(System.Single animationTime, System.Int32 animationIndex)
  System.Void SetVisibility(System.Int32 index, System.Boolean visible)
  System.Void SetColor(System.Int32 index, UnityEngine.Color newColor)
  System.Void SetText(System.Int32 index, System.String text)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.SimpleBufferManager`1
TYPE:  class
TOKEN: 0x2000158
FIELDS:
  private           System.Int32                    m_objectSize  // 0x0
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_capacity  // 0x0
  private           System.Boolean                  m_isFrozen  // 0x0
  private           System.Int32                    m_writingRef  // 0x0
  private           UnityEngine.CanvasRenderer      m_canvasRenderer  // 0x0
  private           Unity.Collections.NativeArray<T>m_cpuArray  // 0x0
METHODS:
  Unity.Collections.NativeArray<T> get_cpuArray()
  System.Void .ctor(System.Int32 initCapacity, UnityEngine.CanvasRenderer canvasRenderer)
  System.Void Dispose()
  System.Void Reset()
  System.Void OpenWrite()
  System.Void Freeze()
  System.Boolean Allocate(System.Int32 size, System.Int32& index)
  System.Void _Resize(System.Int32 desiredCapacity)
END_CLASS

CLASS: Beyond.UI.GPUI.CodePoint
TYPE:  class
TOKEN: 0x2000159
FIELDS:
  public    static  System.UInt32                   HIGH_SURROGATE_START  // 0x0
  public    static  System.UInt32                   HIGH_SURROGATE_END  // 0x0
  public    static  System.UInt32                   LOW_SURROGATE_START  // 0x0
  public    static  System.UInt32                   LOW_SURROGATE_END  // 0x0
  public    static  System.UInt32                   UNICODE_PLANE01_START  // 0x0
METHODS:
  System.UInt32 ConvertToUTF32(System.UInt32 highSurrogate, System.UInt32 lowSurrogate)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.GPUI.ITextSystem
TYPE:  interface
TOKEN: 0x200015A
FIELDS:
METHODS:
  System.Void RegisterCharacterToPrefabBuffer(System.String text)
  System.Void UploadBufferIfNeeded()
  System.Int32 GetNodeCount(System.String text)
  System.Void CreateTextNodes(System.String text, Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData> dest, System.Int32 startIndex, System.Int32 capacity, System.Int32 parentId, System.Int32 grandParentId, Beyond.UI.GPUI.SimpleTextAlignment alignment)
  System.Void CreateTextNodes(System.String text, System.Collections.Generic.List<Beyond.UI.GPUI.GPUInstanceData> dest, System.Int32 startIndex, System.Int32 capacity, System.Int32 parentId, System.Int32 grandParentId, Beyond.UI.GPUI.SimpleTextAlignment alignment)
END_CLASS

CLASS: Beyond.UI.GPUI.SimpleTextSystem`1
TYPE:  class
TOKEN: 0x200015B
FIELDS:
  public    static  System.Single                   DEFAULT_WHITESPACE_SPACING  // 0x0
  private           TMPro.TMP_FontAsset             m_fontAsset  // 0x0
  private           UnityEngine.Material            m_tmpMaterial  // 0x0
  private           Beyond.UI.GPUI.SimpleBufferManager<T>m_prefabBufferManager  // 0x0
  private           System.Single                   m_padding  // 0x0
  private           UnityEngine.Vector2             m_texelSizeInv  // 0x0
  private   readonly System.Collections.Generic.List<T>m_dynamicBufferCache  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.UInt32,System.Int32>m_charCodeToIndexMap  // 0x0
  private   readonly System.Collections.Generic.List<Beyond.UI.GPUI.SimpleTextSystem.CharOffsetData<T>>m_tempOffsetCache  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.UInt32,Beyond.UI.GPUI.SimpleTextSystem.CharOffsetData<T>>m_charaOffsetCache  // 0x0
  private   readonly System.Int32                    m_fontBufferCapacity  // 0x0
  private   readonly System.Boolean                  m_liteMode  // 0x0
  private           System.Boolean                  m_isThaiMode  // 0x0
  private           System.Int32                    m_prefabDestIndex  // 0x0
  private           System.Int32                    m_fontBufferCount  // 0x0
  private   readonly System.Func<UnityEngine.Vector4,UnityEngine.Vector4,UnityEngine.Vector2,T>m_creatorFunc  // 0x0
METHODS:
  System.Void .ctor(System.Int32 fontBufferCapacity, System.Func<UnityEngine.Vector4,UnityEngine.Vector4,UnityEngine.Vector2,T> creatorFunc)
  System.Void Init(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material tmpMaterial, Beyond.UI.GPUI.SimpleBufferManager<T> simpleBufferManager, System.Boolean isThaiMode)
  System.Void RegisterCharacterToPrefabBuffer(System.String text)
  System.Int32 GetNodeCount(System.String text)
  System.Void UploadBufferIfNeeded()
  System.Void CreateTextNodes(System.String text, Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData> dest, System.Int32 startIndex, System.Int32 capacity, System.Int32 parentId, System.Int32 grandParentId, Beyond.UI.GPUI.SimpleTextAlignment alignment)
  System.Void CreateTextNodes(System.String text, System.Collections.Generic.List<Beyond.UI.GPUI.GPUInstanceData> dest, System.Int32 startIndex, System.Int32 capacity, System.Int32 parentId, System.Int32 grandParentId, Beyond.UI.GPUI.SimpleTextAlignment alignment)
  System.Void _DoTextAlignAndDynamicBuffer(System.String text, Beyond.UI.GPUI.SimpleTextAlignment alignment, System.Single& currentX)
  System.Void _LoadAllCharacterToPrefabBuffer(System.String text)
  System.Int32 _PutOneCharacterToPrefabBufferDynamic(System.UInt32 c)
  System.Void _UploadBufferIfNeeded()
  System.Void _InitPrefabDataByTMPCharacter(TMPro.TMP_Character character, T& prefabData)
  System.Boolean IsUpVowel(System.Char c)
  System.Boolean IsLowVowel(System.Char c)
  System.Boolean IsToneMark(System.Char c)
  System.Boolean IsAscenderThai(System.Char c)
  System.Boolean IsDescenderThai(System.Char c)
END_CLASS

CLASS: Beyond.UI.UIState.OnValueChangedAttribute
TYPE:  class
TOKEN: 0x2000131
EXTENDS: PropertyAttribute
FIELDS:
  private   readonly System.String                   <actionName>k__BackingField  // 0x10
METHODS:
  System.String get_actionName()
  System.Void .ctor(System.String name)
END_CLASS

CLASS: Beyond.UI.UIState.StateAnimationInfo
TYPE:  class
TOKEN: 0x2000132
FIELDS:
  private           System.Boolean                  <IsFinished>k__BackingField  // 0x10
  private   readonly UnityEngine.AnimationClip       <Clip>k__BackingField  // 0x18
  private   readonly UnityEngine.GameObject          <Target>k__BackingField  // 0x20
  private           System.Single                   <StartTime>k__BackingField  // 0x28
  private   readonly System.Single                   m_duration  // 0x2C
METHODS:
  System.Boolean get_IsFinished()
  System.Void set_IsFinished(System.Boolean value)
  UnityEngine.AnimationClip get_Clip()
  UnityEngine.GameObject get_Target()
  System.Single get_StartTime()
  System.Void set_StartTime(System.Single value)
  System.Void .ctor(UnityEngine.AnimationClip clip, UnityEngine.GameObject target)
  System.Void OnUpdate()
END_CLASS

CLASS: Beyond.UI.UIState.AnimationImpactType
TYPE:  struct
TOKEN: 0x2000133
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.AnimationImpactTypeStartAnimation  // 0x0
  public    static  Beyond.UI.UIState.AnimationImpactTypeStopAnimation  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.StateDescription
TYPE:  class
TOKEN: 0x2000134
FIELDS:
  public            Beyond.UI.UIState.AnimationImpactTypeanimationImpactType  // 0x10
  public            UnityEngine.AnimationClip       animationClip  // 0x18
  public            UnityEngine.GameObject          animationTarget  // 0x20
  public            UnityEngine.Animator            animator  // 0x28
  public            Beyond.UI.UIState.AnimatorImpactTypeanimImpact  // 0x30
  public            System.String                   animParamSetBoolTrue  // 0x38
  public            System.String                   animParamSetBoolFalse  // 0x40
  public            System.String                   animParamSetTrigger  // 0x48
  public            System.String                   animParamResetTrigger  // 0x50
  public            System.String                   animParamSetInteger  // 0x58
  public            System.Int32                    animParamSetIntegerValue  // 0x60
  public            System.String                   animParamSetFloat  // 0x68
  public            System.Int32                    animParamSetFloatValue  // 0x70
  public            Beyond.UI.UIButton              button  // 0x78
  public            System.Boolean                  buttonInteractable  // 0x80
  public            UnityEngine.CanvasGroup         canvasGroup  // 0x88
  public            Beyond.UI.UIState.CanvasGroupImpactTypecanvasGroupImpactType  // 0x90
  public            System.Single                   canvasGroupAlpha  // 0x94
  public            System.Boolean                  canvasGroupInteractable  // 0x98
  public            UnityEngine.Color               canvasGroupColor  // 0x9C
  public            UnityEngine.Behaviour           component  // 0xB0
  public            System.Boolean                  componentIsEnabled  // 0xB8
  public            Beyond.UI.UIState.StateDescriptionTargetTypetargetType  // 0xBC
  public            UnityEngine.GameObject          gameObject  // 0xC0
  public            System.Boolean                  gameObjectIsActive  // 0xC8
  public            UnityEngine.UI.Graphic          graphic  // 0xD0
  public            UnityEngine.Material            graphicMaterial  // 0xD8
  public            UnityEngine.UI.GridLayoutGroup  gridLayoutGroup  // 0xE0
  public            Beyond.UI.UIState.GridLayoutGroupImpactTypegridLayoutGroupImpactType  // 0xE8
  public            UnityEngine.RectOffset          gridLayoutGroupPadding  // 0xF0
  public            UnityEngine.Vector2             gridLayoutGroupSpacing  // 0xF8
  public            UnityEngine.Vector2             gridLayoutGroupCellSize  // 0x100
  public            System.Int32                    gridLayoutConstraintCount  // 0x108
  public            Beyond.UI.UIImage               image  // 0x110
  public            Beyond.UI.UIState.ImageImpactTypeimageImpact  // 0x118
  public            System.Boolean                  imageEnabled  // 0x11C
  public            UnityEngine.Sprite              imageSetSprite  // 0x120
  public            UnityEngine.Color               imageSetColor  // 0x128
  public            System.String                   imageSetMaterialFloatParam  // 0x138
  public            System.Single                   imageSetMaterialFloatValue  // 0x140
  private           UnityEngine.Material            <ImageMaterialClone>k__BackingField  // 0x148
  public            UnityEngine.UI.LayoutElement    layoutElement  // 0x150
  public            Beyond.UI.UIState.LayoutElementImpactTypelayoutElementImpactType  // 0x158
  public            System.Single                   layoutElementPreferredWidth  // 0x15C
  public            System.Single                   layoutElementPreferredHeight  // 0x160
  public            System.Single                   layoutElementMinWidth  // 0x164
  public            System.Single                   layoutElementMinHeight  // 0x168
  public            System.Single                   layoutElementFlexibleWidth  // 0x16C
  public            System.Single                   layoutElementFlexibleHeight  // 0x170
  public            UnityEngine.UI.HorizontalOrVerticalLayoutGrouplayoutGroup  // 0x178
  public            Beyond.UI.UIState.LayoutGroupImpactTypelayoutGroupImpactType  // 0x180
  public            UnityEngine.RectOffset          layoutGroupPadding  // 0x188
  public            System.Single                   layoutGroupSpacing  // 0x190
  public            UnityEngine.TextAnchor          layoutGroupChildAlignment  // 0x194
  public            System.Boolean                  layoutGroupReverseArrangement  // 0x198
  public            UnityEngine.RectTransform       rectTransform  // 0x1A0
  public            Beyond.UI.UIState.RectTransformImpactTyperectTransformImpactType  // 0x1A8
  public            UnityEngine.Vector2             rectTransformPosition  // 0x1AC
  public            UnityEngine.Vector2             rectTransformSize  // 0x1B4
  public            UnityEngine.Vector3             rectTransformRotation  // 0x1BC
  public            UnityEngine.Vector3             rectTransformScale  // 0x1C8
  public            System.Single                   rectTransformWidth  // 0x1D4
  public            System.Single                   rectTransformHeight  // 0x1D8
  public            System.Single                   rectTransformTop  // 0x1DC
  public            System.Single                   rectTransformBottom  // 0x1E0
  public            System.Single                   rectTransformLeft  // 0x1E4
  public            System.Single                   rectTransformRight  // 0x1E8
  public            UnityEngine.Vector2             rectTransformAnchorMin  // 0x1EC
  public            UnityEngine.Vector2             rectTransformAnchorMax  // 0x1F4
  public            UnityEngine.Vector2             rectTransformPivot  // 0x1FC
  public            Beyond.UI.UIScrollList          scrollList  // 0x208
  public            Beyond.UI.UIState.ScrollListImpactTypescrollListImpactType  // 0x210
  public            Beyond.UI.UIScrollList.Padding  scrollListPadding  // 0x214
  public            Beyond.UI.UIState.UIStateControlleruiStateController  // 0x228
  public            System.String                   stateName  // 0x230
  public            Beyond.UI.UIText                text  // 0x238
  public            Beyond.UI.UIState.TextImpactTypetextImpact  // 0x240
  public            UnityEngine.Color               textColor  // 0x244
  public            System.String                   textId  // 0x258
  public            System.Single                   textFontSize  // 0x260
  public            System.Single                   textMaxFontSize  // 0x264
  public            TMPro.HorizontalAlignmentOptionstextHorizontalAlignment  // 0x268
METHODS:
  System.Single ApplyAnimation(Beyond.UI.UIState.StateReference state)
  System.Void ApplyAnimator()
  System.Void ApplyButton()
  System.Void ApplyCanvasGroup()
  System.Void ApplyComponent()
  System.Boolean get_IsEmpty()
  System.String get_ReadableDescription()
  System.String ToString()
  System.Void ApplyGameObject()
  System.Void ApplyGraphic()
  System.Void ApplyGridLayoutGroup()
  System.Void _OnGridLayoutGroupChanged()
  UnityEngine.Material get_ImageMaterialClone()
  System.Void set_ImageMaterialClone(UnityEngine.Material value)
  System.Void ApplyImage()
  System.Void _OnImageChanged()
  System.Void ApplyLayoutElement()
  System.Void _OnLayoutElementChanged()
  System.Void ApplyLayoutGroup()
  System.Void _OnLayoutGroupChanged()
  System.Void ApplyRectTransform()
  System.Void _OnRectTransformChanged()
  System.Void ApplyScrollList()
  System.Void _OnScrollListChanged()
  System.Single ApplyInnerState()
  System.Void ApplyText()
  System.Void _OnTextChanged()
  System.Void .ctor()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.UI.UIState.AnimatorImpactType
TYPE:  struct
TOKEN: 0x2000135
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.AnimatorImpactTypeSetBoolTrue  // 0x0
  public    static  Beyond.UI.UIState.AnimatorImpactTypeSetBoolFalse  // 0x0
  public    static  Beyond.UI.UIState.AnimatorImpactTypeSetTrigger  // 0x0
  public    static  Beyond.UI.UIState.AnimatorImpactTypeResetTrigger  // 0x0
  public    static  Beyond.UI.UIState.AnimatorImpactTypeSetInteger  // 0x0
  public    static  Beyond.UI.UIState.AnimatorImpactTypeSetFloat  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.CanvasGroupImpactType
TYPE:  struct
TOKEN: 0x2000136
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.CanvasGroupImpactTypeSetAlpha  // 0x0
  public    static  Beyond.UI.UIState.CanvasGroupImpactTypeSetInteractable  // 0x0
  public    static  Beyond.UI.UIState.CanvasGroupImpactTypeSetColor  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.StateDescriptionTargetType
TYPE:  struct
TOKEN: 0x2000137
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeGameObject  // 0x0
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeAnimator  // 0x0
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeImage  // 0x0
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeText  // 0x0
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeRectTransform  // 0x0
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeButton  // 0x0
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeCanvasGroup  // 0x0
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeAnimation  // 0x0
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeState  // 0x0
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeLayoutElement  // 0x0
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeComponent  // 0x0
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeGraphic  // 0x0
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeLayoutGroup  // 0x0
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeScrollList  // 0x0
  public    static  Beyond.UI.UIState.StateDescriptionTargetTypeGridLayoutGroup  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.GridLayoutGroupImpactType
TYPE:  struct
TOKEN: 0x2000138
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.GridLayoutGroupImpactTypePadding  // 0x0
  public    static  Beyond.UI.UIState.GridLayoutGroupImpactTypeSpacing  // 0x0
  public    static  Beyond.UI.UIState.GridLayoutGroupImpactTypeCellSize  // 0x0
  public    static  Beyond.UI.UIState.GridLayoutGroupImpactTypeConstraintCount  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.ImageImpactType
TYPE:  struct
TOKEN: 0x2000139
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.ImageImpactTypeSetEnabled  // 0x0
  public    static  Beyond.UI.UIState.ImageImpactTypeSetSprite  // 0x0
  public    static  Beyond.UI.UIState.ImageImpactTypeSetColor  // 0x0
  public    static  Beyond.UI.UIState.ImageImpactTypeSetMaterialFloatValue  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.LayoutElementImpactType
TYPE:  struct
TOKEN: 0x200013A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.LayoutElementImpactTypeLayoutElementPreferredWidth  // 0x0
  public    static  Beyond.UI.UIState.LayoutElementImpactTypeLayoutElementPreferredHeight  // 0x0
  public    static  Beyond.UI.UIState.LayoutElementImpactTypeLayoutElementMinWidth  // 0x0
  public    static  Beyond.UI.UIState.LayoutElementImpactTypeLayoutElementMinHeight  // 0x0
  public    static  Beyond.UI.UIState.LayoutElementImpactTypeLayoutElementFlexibleWidth  // 0x0
  public    static  Beyond.UI.UIState.LayoutElementImpactTypeLayoutElementFlexibleHeight  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.LayoutGroupImpactType
TYPE:  struct
TOKEN: 0x200013B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.LayoutGroupImpactTypePadding  // 0x0
  public    static  Beyond.UI.UIState.LayoutGroupImpactTypeSpacing  // 0x0
  public    static  Beyond.UI.UIState.LayoutGroupImpactTypeChildAlignment  // 0x0
  public    static  Beyond.UI.UIState.LayoutGroupImpactTypeReverseArrangement  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.RectTransformImpactType
TYPE:  struct
TOKEN: 0x200013C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.RectTransformImpactTypeUndefined  // 0x0
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetPosition  // 0x0
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetSize  // 0x0
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetRotation  // 0x0
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetScale  // 0x0
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetWidth  // 0x0
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetHeight  // 0x0
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetTop  // 0x0
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetBottom  // 0x0
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetLeft  // 0x0
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetRight  // 0x0
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetAnchors  // 0x0
  public    static  Beyond.UI.UIState.RectTransformImpactTypeSetPivot  // 0x0
  public    static  Beyond.UI.UIState.RectTransformImpactTypeForceRebuildLayout  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.ScrollListImpactType
TYPE:  struct
TOKEN: 0x200013D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.ScrollListImpactTypePadding  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.TextImpactType
TYPE:  struct
TOKEN: 0x200013E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.UI.UIState.TextImpactTypeSetColor  // 0x0
  public    static  Beyond.UI.UIState.TextImpactTypeSetTextById  // 0x0
  public    static  Beyond.UI.UIState.TextImpactTypeSetFontSize  // 0x0
  public    static  Beyond.UI.UIState.TextImpactTypeSetHorizontalAlignment  // 0x0
  public    static  Beyond.UI.UIState.TextImpactTypeSetMaxFontSize  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.UI.UIState.StateReference
TYPE:  class
TOKEN: 0x200013F
FIELDS:
  public            System.String                   stateName  // 0x10
  public            System.Collections.Generic.List<Beyond.UI.UIState.StateDescription>descriptions  // 0x18
  private           System.Collections.Generic.List<Beyond.UI.UIState.StateAnimationInfo>m_scheduledForPlaying  // 0x20
  private           System.Collections.Generic.List<Beyond.UI.UIState.StateAnimationInfo>m_scheduledForStopping  // 0x28
  private           Beyond.UI.UIState.UIStateControllerm_controller  // 0x30
  private           System.Boolean                  m_isDirty  // 0x38
METHODS:
  System.Void SetController(Beyond.UI.UIState.UIStateController controller)
  System.Void ScheduleForPlaying(Beyond.UI.UIState.StateAnimationInfo stateAnimationInfo)
  System.Void ScheduleForStopping(Beyond.UI.UIState.StateAnimationInfo stateAnimationInfo)
  System.Void HandleScheduledStates()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.UI.UIState.UIStateController
TYPE:  class
TOKEN: 0x2000140
EXTENDS: TickableUIMono
FIELDS:
  public            System.Collections.Generic.List<Beyond.UI.UIState.StateReference>states  // 0x68
  private           System.String                   <currentStateName>k__BackingField  // 0x70
  private   readonly System.Collections.Generic.List<Beyond.UI.UIState.StateAnimationInfo>m_animations  // 0x78
METHODS:
  Beyond.TickType get_tickOption()
  System.String get_currentStateName()
  System.Void set_currentStateName(System.String value)
  System.Void OnStateReferenceDirty()
  System.Single SetState(System.String stateName, System.Boolean forceUpdate)
  System.Single _ApplyState(Beyond.UI.UIState.StateReference state)
  System.Void Tick(System.Single deltaTime)
  System.Void _HandleStateAnimations(Beyond.UI.UIState.StateReference stateReference)
  System.Void Run(Beyond.UI.UIState.StateAnimationInfo newInfo)
  System.Void Stop(Beyond.UI.UIState.StateAnimationInfo newInfo)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Tick(System.Single P0)
END_CLASS

CLASS: Beyond.UI.UIState.UIStateControllerUtils
TYPE:  class
TOKEN: 0x2000142
FIELDS:
  private   static  System.Single                   s_updateFinishTime  // 0x0
METHODS:
  System.Void ForceRebuildLayout(UnityEngine.GameObject gameObject)
  System.Void SetLeft(UnityEngine.RectTransform rt, System.Single left)
  System.Void SetRight(UnityEngine.RectTransform rt, System.Single right)
  System.Void SetTop(UnityEngine.RectTransform rt, System.Single top)
  System.Void SetBottom(UnityEngine.RectTransform rt, System.Single bottom)
  System.String GetName(UnityEngine.Object obj)
  System.Void StartEditorUpdateLoop(System.Single duration)
END_CLASS

CLASS: Cysharp.Text.TextMeshProExtensions
TYPE:  class
TOKEN: 0x2000004
FIELDS:
METHODS:
  System.Void SetText(TMPro.TMP_Text text, T arg0)
  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0)
  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1)
  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2)
  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
  System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
  System.Void SetText(TMPro.TMP_Text text, Cysharp.Text.Utf16ValueStringBuilder stringBuilder)
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x200015F
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.Void __Gen_Wrap_0()
  System.Void __Gen_Wrap_1(System.Object P0)
  System.Single __Gen_Wrap_2(System.Object P0, System.Boolean P1)
  System.Single __Gen_Wrap_3(System.Object P0)
  Beyond.UI.LuaPanel __Gen_Wrap_4(System.Object P0)
  System.Void __Gen_Wrap_5(System.Object P0, System.Object P1, System.Boolean P2)
  System.Void __Gen_Wrap_6(System.Object P0, System.Single P1)
  System.String __Gen_Wrap_7(System.Object P0, System.Int32 P1, System.Boolean& P2)
  System.Boolean __Gen_Wrap_8(System.Object P0, System.Object P1)
  Beyond.UI.UIText.HyperlinkUITextGroup __Gen_Wrap_9(System.Object P0, System.Object P1, System.Boolean P2)
  System.Void __Gen_Wrap_10(System.Object P0, System.Object P1)
  System.String __Gen_Wrap_11(Beyond.GEnums.PhoneticType P0, System.Object P1)
  System.Void __Gen_Wrap_12(System.Object P0, Beyond.GEnums.PhoneticType P1, System.Object P2)
  System.Void __Gen_Wrap_13(Beyond.GEnums.EnvLang P0)
  System.Boolean __Gen_Wrap_14(System.Object P0, System.Object P1, System.String& P2)
  System.Boolean __Gen_Wrap_15(System.Object P0, UnityEngine.Vector3 P1, System.String& P2)
  System.Collections.IEnumerator __Gen_Wrap_16(System.Object P0)
  System.String __Gen_Wrap_17(System.Object P0, System.Boolean P1)
  UnityEngine.Sprite __Gen_Wrap_18(System.Object P0, System.Object P1)
  System.Int32 __Gen_Wrap_19(System.ReadOnlySpan<System.Char> P0)
  Beyond.UI.UIText.RichTextInfo __Gen_Wrap_20(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam P0, System.Object P1, Cysharp.Text.Utf16ValueStringBuilder& P2)
  Beyond.UI.UIText.RichTextInfo __Gen_Wrap_21(System.Object P0, Beyond.UI.UIText.RichTextAnalyzer.RichTextParam P1, System.Object P2, Cysharp.Text.Utf16ValueStringBuilder& P3)
  Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc __Gen_Wrap_22(System.Object P0)
  System.Boolean __Gen_Wrap_23(System.ReadOnlySpan<System.Char> P0, Beyond.UI.UIText.RichTextAnalyzer.RichTextParam& P1)
  System.Boolean __Gen_Wrap_24(System.ReadOnlySpan<System.Char> P0, Cysharp.Text.Utf16ValueStringBuilder& P1, System.Object P2, Beyond.UI.UIText.RichTextInfo& P3)
  System.String __Gen_Wrap_25(System.Object P0, System.Object P1, System.Collections.Generic.List<Beyond.UI.UIText.RichTextInfo>& P2)
  UnityEngine.GameObject __Gen_Wrap_26(System.Object P0)
  Beyond.UI.UIText.ImageGOInfo __Gen_Wrap_27(System.Object P0, System.Int32 P1)
  UnityEngine.Material __Gen_Wrap_28(System.Object P0)
  UnityEngine.Material __Gen_Wrap_29(System.Object P0, System.Object P1)
  Beyond.I18n.I18nFontSearchData __Gen_Wrap_30()
  System.Boolean __Gen_Wrap_31(System.Object P0)
  TMPro.TMP_FontAsset __Gen_Wrap_32(System.Int32 P0)
  TMPro.TMP_FontAsset __Gen_Wrap_33(System.Object P0)
  System.Void __Gen_Wrap_34(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3)
  System.Void __Gen_Wrap_35(System.Object P0, System.Object P1, System.Int32 P2)
  System.Boolean __Gen_Wrap_36(System.Object P0, System.Int32 P1, System.String& P2)
  System.Boolean __Gen_Wrap_37(System.Object P0, System.Int32 P1, UnityEngine.Vector3& P2, System.Single& P3)
  System.Void __Gen_Wrap_38(System.Object P0, System.Object P1, System.Object P2)
  System.Int32 __Gen_Wrap_39(Beyond.UI.UIText.HyperlinkUITextWrap P0, Beyond.UI.UIText.HyperlinkUITextWrap P1)
  System.Collections.Generic.List<Beyond.UI.UIText> __Gen_Wrap_40(System.Object P0, System.Object P1)
  System.Collections.Generic.List<Beyond.UI.UIText> __Gen_Wrap_41(System.Object P0)
  System.Int32 __Gen_Wrap_42(System.Object P0)
  TMPro.TMP_SubMeshUI __Gen_Wrap_43(System.Object P0, System.Object P1, TMPro.MaterialReference P2)
  System.String __Gen_Wrap_44(System.Int32 P0)
  System.Boolean __Gen_Wrap_45()
  System.Single __Gen_Wrap_46()
  UnityEngine.GameObject __Gen_Wrap_47(System.Object P0, System.Object P1, System.Object P2)
  System.Void __Gen_Wrap_48(Beyond.Resource.FAssetProxyUntrackedHandle P0)
  System.Int32 __Gen_Wrap_49(System.Object P0, System.Object P1, System.Object P2, System.Object P3)
  System.Void __Gen_Wrap_50(System.Object P0, System.Int32 P1)
  System.Boolean __Gen_Wrap_51(UnityEngine.Vector3 P0, System.Object P1, System.Object P2)
  System.Boolean __Gen_Wrap_52(UnityEngine.Vector2 P0, System.Object P1, System.Object P2)
  UnityEngine.Bounds __Gen_Wrap_53(System.Object P0, System.Object P1)
  System.Boolean __Gen_Wrap_54(System.Int32 P0, UnityEngine.InputSystem.EnhancedTouch.Touch& P1)
  System.Void __Gen_Wrap_55(System.Object P0, UnityEngine.Color P1)
  UnityEngine.Rect __Gen_Wrap_56(System.Object P0, System.Object P1)
  UnityEngine.Vector3 __Gen_Wrap_57(System.Object P0, System.Object P1)
  UnityEngine.Color __Gen_Wrap_58(System.Object P0)
  System.Single __Gen_Wrap_59(System.Single P0)
  System.Void __Gen_Wrap_60(System.Object P0, System.Object P1, Cinemachine.CinemachineCore.Stage P2, Cinemachine.CameraState& P3, System.Single P4)
  System.Int32 __Gen_Wrap_61(System.Object P0, System.Int32 P1)
  UnityEngine.Vector2 __Gen_Wrap_62(System.Object P0, System.Int32 P1)
  UnityEngine.Vector2 __Gen_Wrap_63()
  System.Void __Gen_Wrap_64(UnityEngine.Vector2 P0)
  System.Void __Gen_Wrap_65(System.Object P0, System.Int32 P1, System.Boolean P2)
  UnityEngine.Vector2Int __Gen_Wrap_66(System.Object P0, System.Single P1, System.Boolean P2)
  UnityEngine.Vector2Int __Gen_Wrap_67(System.Object P0)
  Beyond.UI.UIScrollList.Cell __Gen_Wrap_68(System.Object P0)
  System.Void __Gen_Wrap_69(System.Object P0, System.Boolean P1)
  UnityEngine.AnimationState __Gen_Wrap_70(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_71(System.Object P0, System.Object P1, System.Single P2)
  System.Void __Gen_Wrap_72(System.Object P0, System.Object P1, System.Single P2, System.Boolean P3)
  System.Void __Gen_Wrap_73(System.Object P0, System.Object P1, System.Object P2, Beyond.UI.UIConst.AnimationState P3, System.Single P4)
  System.Void __Gen_Wrap_74(System.Object P0, System.Int32 P1, System.Boolean P2, System.Boolean P3)
  System.Void __Gen_Wrap_75(System.Object P0, System.Boolean P1, System.Boolean P2, System.Boolean P3)
  Beyond.UI.UIScrollList.MoveTipsType __Gen_Wrap_76(System.Object P0)
  System.Void __Gen_Wrap_77(System.Object P0, UnityEngine.Vector2 P1)
  System.Void __Gen_Wrap_78(System.Object P0, System.Int32 P1, System.Boolean P2, Beyond.UI.UIScrollList.ScrollAlignType P3, System.Boolean P4)
  Beyond.UI.UIText __Gen_Wrap_79(System.Object P0)
  System.String __Gen_Wrap_80(System.Object P0)
  UnityEngine.Sprite __Gen_Wrap_81(System.Object P0)
  Beyond.UI.UIStyleInputValidTypeMask __Gen_Wrap_82(System.Object P0)
  System.Void __Gen_Wrap_83(System.Object P0, Beyond.UI.UIStyleInputValidTypeMask P1)
  System.Boolean __Gen_Wrap_84(Beyond.UI.UIStyleInputValidType P0)
  System.Boolean __Gen_Wrap_85(Beyond.UI.UIStyleInputValidTypeMask P0)
  System.Void __Gen_Wrap_86(System.Object P0, System.Int32 P1, System.Int32 P2)
  System.Int32 __Gen_Wrap_87()
  System.Void __Gen_Wrap_88(System.Object P0, System.Boolean P1, System.Boolean P2)
  UnityEngine.UI.Selectable __Gen_Wrap_89(System.Object P0)
  System.Boolean __Gen_Wrap_90(System.Object P0, UnityEngine.Vector2 P1, System.Object P2)
  System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> __Gen_Wrap_91(System.Object P0)
  Beyond.UI.UIRecycleLayoutAdapter __Gen_Wrap_92(System.Object P0)
  Beyond.UI.UIRecycleLayoutGroup.ViewMgr __Gen_Wrap_93(System.Object P0)
  System.Void __Gen_Wrap_94(System.Object P0, System.Object P1, Beyond.UI.UIRecycleLayoutGroup.LayoutMeta P2)
  UnityEngine.Vector2 __Gen_Wrap_95(System.Object P0, UnityEngine.Bounds P1)
  UnityEngine.Bounds __Gen_Wrap_96(System.Object P0, Beyond.UI.UIRecycleLayoutGroup.LayoutMeta P1)
  Beyond.UI.UIRecycleLayoutAdapter __Gen_Wrap_97(System.Object P0, System.Object P1)
  Beyond.UI.UIRecycleLayoutGroup.ViewPool __Gen_Wrap_98(System.Object P0, System.Object P1)
  UnityEngine.GameObject __Gen_Wrap_99(System.Object P0, System.Boolean& P1)
  System.Boolean __Gen_Wrap_100(System.Object P0, System.Int32 P1, System.Object P2)
  Beyond.UI.UIRecycleLayoutAdapter.IVirtualView __Gen_Wrap_101(System.Object P0, System.Int32 P1)
  System.Single __Gen_Wrap_102(System.Object P0, System.Int32 P1)
  UnityEngine.Bounds __Gen_Wrap_103(System.Object P0, System.Int32 P1)
  System.Int32 __Gen_Wrap_104(System.Object P0, System.Object P1)
  Beyond.UI.UIRecycleLayoutGroup.Direction __Gen_Wrap_105(System.Object P0)
  Beyond.UI.UIRecycleMultiHolder.MultiVirtualView __Gen_Wrap_106(System.Object P0, System.Int32 P1)
  System.Void __Gen_Wrap_107(System.Object P0, System.Int32 P1, System.Object P2, System.Single P3)
  Beyond.UI.UIRecycleSingleHolder.SimpleVirtualView __Gen_Wrap_108(System.Object P0, System.Int32 P1)
  Beyond.UI.ToastList.CellInfo __Gen_Wrap_109(System.Object P0)
  System.Collections.IEnumerator __Gen_Wrap_110(System.Object P0, System.Int32 P1, System.Object P2)
  System.Boolean __Gen_Wrap_111(System.Object P0, System.Object P1, System.Object P2)
  System.Boolean __Gen_Wrap_112(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3, System.Boolean& P4, System.Boolean P5)
  Beyond.Input.PlayerActionInfo __Gen_Wrap_113(System.Object P0)
  System.Boolean __Gen_Wrap_114(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3)
  System.Void __Gen_Wrap_115(Beyond.DeviceInfo.ControllerType P0)
  System.Void __Gen_Wrap_116(System.Object P0, Beyond.EventData<System.String>& P1)
  System.Void __Gen_Wrap_117(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3)
  System.Void __Gen_Wrap_118(System.Object P0, System.Int32 P1, System.Object P2, System.Object P3, System.Boolean P4)
  UnityEngine.AnimationClip __Gen_Wrap_119(System.Object P0, System.Object P1, System.Boolean P2)
  UnityEngine.AnimationClip __Gen_Wrap_120(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_121(System.Object P0, Beyond.UI.UIAnimationWrapper.FOptions P1)
  System.Single __Gen_Wrap_122(System.Object P0, System.Object P1)
  Beyond.UI.UIAnimationWrapper.FOptions __Gen_Wrap_123()
  System.Void __Gen_Wrap_124(System.Object P0, System.Object P1, System.Object P2, System.Single P3)
  Beyond.UI.UISwitchTween.ITweenHandler __Gen_Wrap_125(System.Object P0)
  Beyond.UI.UISwitchTween.ITweenHandler __Gen_Wrap_126(System.Object P0, System.Object P1)
  Beyond.UI.UISwitchTween.ITweenHandler __Gen_Wrap_127(System.Object P0, System.Boolean P1)
  Beyond.UI.UIAnimationSwitchTween __Gen_Wrap_128(Beyond.UI.UIAnimationSwitchTween.Builder& P0)
  UnityEngine.Camera __Gen_Wrap_129(System.Object P0)
  System.Void __Gen_Wrap_130(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3, System.Boolean P4, System.Boolean P5)
  System.Void __Gen_Wrap_131(System.Object P0, System.Boolean P1, System.Boolean P2, System.Boolean P3, System.Single P4)
  System.Void __Gen_Wrap_132(System.Object P0, System.Single P1, System.Boolean P2)
  System.Collections.IEnumerator __Gen_Wrap_133(System.Object P0, System.Object P1)
  Beyond.DisposedUnityEvent<System.Int32,System.Boolean> __Gen_Wrap_134(System.Object P0)
  System.Void __Gen_Wrap_135(System.Object P0, UnityEngine.Vector2& P1, UnityEngine.Vector2& P2)
  UnityEngine.Vector2 __Gen_Wrap_136(System.Object P0, UnityEngine.Vector2 P1)
  System.Void __Gen_Wrap_137(UnityEngine.EventSystems.PointerEventData P0)
  System.Void __Gen_Wrap_138(System.Object P0, UnityEngine.Vector3 P1)
  System.Void __Gen_Wrap_139(System.Object P0, System.Boolean P1, System.Single P2, System.Object P3, System.Object P4)
  System.Void __Gen_Wrap_140(System.Single P0)
  System.Void __Gen_Wrap_141(System.Object P0, System.Boolean P1, UnityEngine.UI.Selectable& P2, Beyond.UI.UITouchPanel& P3)
  System.Void __Gen_Wrap_142(System.Object P0, System.Single P1, System.Single P2, System.Object P3)
  System.Void __Gen_Wrap_143(System.Object P0, System.Object P1, System.Boolean P2, System.Object P3)
  System.Void __Gen_Wrap_144(System.Object P0, System.Single& P1, System.Single& P2)
  System.Void __Gen_Wrap_145(System.Object P0, System.Object P1, UnityEngine.Color P2)
  UnityEngine.Canvas __Gen_Wrap_146(System.Object P0)
  System.String __Gen_Wrap_147(System.Object P0, System.Object P1)
  Beyond.Input.BindingViewState __Gen_Wrap_148(System.Object P0)
  System.String __Gen_Wrap_149(System.Object P0, Beyond.Input.BindingViewActionType P1)
  System.Boolean __Gen_Wrap_150(System.Object P0, System.String& P1, System.String& P2)
  System.Void __Gen_Wrap_151(System.Object P0, Beyond.Input.ActionOnSetNaviTarget P1)
  System.Collections.Generic.HashSet<UnityEngine.UI.CanvasScaler> __Gen_Wrap_152(System.Object P0)
  UnityEngine.Vector2 __Gen_Wrap_153(System.Object P0)
  System.Single __Gen_Wrap_154(UnityEngine.Vector2& P0)
  Beyond.UI.UICanvasScaleHelper.FWorldCanvasParams __Gen_Wrap_155(System.Object P0, System.Object P1, System.Boolean P2)
  Beyond.UI.UICanvasScaleHelper.FScreenCanvasParams __Gen_Wrap_156()
  System.Void __Gen_Wrap_157(System.Object P0, Beyond.UI.UIColorGroup.CommonParams P1)
  System.Void __Gen_Wrap_158(System.Object P0, System.Object P1, Beyond.UI.UIColorGroup.CommonParams P2)
  System.Void __Gen_Wrap_159(System.Object P0, System.Single P1, System.Single P2, System.Boolean P3)
  System.Void __Gen_Wrap_160(System.Object P0, UnityEngine.Color P1, System.Single P2, System.Boolean P3, System.Boolean P4, System.Boolean P5)
  System.Void __Gen_Wrap_161(System.Object P0, UnityEngine.Color P1, System.Single P2, System.Boolean P3, System.Boolean P4)
  Beyond.UI.UICustomLayoutElement __Gen_Wrap_162(System.Object P0)
  System.String __Gen_Wrap_163(System.Object P0, System.Int32 P1)
  System.Boolean __Gen_Wrap_164(System.Object P0, Beyond.UI.UICustomLayoutElement.LayoutData& P1, System.Boolean P2, System.Int32 P3)
  System.Boolean __Gen_Wrap_165(System.Object P0, Beyond.UI.UICustomLayoutElement.LayoutData& P1, System.Int32 P2)
  UnityEngine.RectTransform __Gen_Wrap_166(System.Object P0)
  System.Void __Gen_Wrap_167(System.Object P0, Beyond.UI.UICustomLayoutElement.LayoutType P1)
  UnityEngine.CanvasGroup __Gen_Wrap_168(System.Object P0)
  System.Void __Gen_Wrap_169(System.Object P0, System.Boolean P1, System.Object P2)
  System.Void __Gen_Wrap_170(System.Object P0, System.Object P1, System.Object P2, System.Object P3)
  System.Void __Gen_Wrap_171(System.Object P0, System.Int32 P1, System.Boolean P2, System.Boolean P3, System.Boolean P4)
  System.Void __Gen_Wrap_172(System.Object P0, UnityEngine.Vector2 P1, System.Boolean P2)
  System.Void __Gen_Wrap_173(System.Object P0, System.Int32 P1, System.Int32 P2, System.Boolean P3)
  System.Single __Gen_Wrap_174(System.Object P0, System.Boolean P1, System.Int32 P2)
  System.Void __Gen_Wrap_175(System.Object P0, System.Boolean P1, System.Single P2, System.Single P3)
  System.Void __Gen_Wrap_176(System.Object P0, UnityEngine.Rect P1)
  System.Single __Gen_Wrap_177(System.Object P0, System.Object P1, System.Boolean P2)
  System.Void __Gen_Wrap_178(System.Object P0, System.Int32 P1, System.Single P2)
  System.Boolean __Gen_Wrap_179(System.Object P0, System.Boolean P1, System.Boolean P2)
  UnityEngine.UI.Selectable __Gen_Wrap_180(System.Object P0, System.Boolean P1)
  System.Boolean __Gen_Wrap_181(System.Object P0, System.Int32 P1, System.Int32 P2, System.Boolean P3, System.Boolean P4)
  System.Boolean __Gen_Wrap_182(System.Object P0, UnityEngine.UI.NaviDirection P1, System.Boolean P2)
  System.Void __Gen_Wrap_183(System.Object P0, UnityEngine.UI.NaviDirection P1)
  System.Boolean __Gen_Wrap_184(System.Object P0, UnityEngine.UI.NaviDirection P1)
  UnityEngine.Vector3 __Gen_Wrap_185()
  System.Void __Gen_Wrap_186(UnityEngine.Vector3 P0)
  Beyond.UI.UIAtlasManager.UIAtlasHandle __Gen_Wrap_187(Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause P0)
  UnityEngine.Texture __Gen_Wrap_188(System.Object P0)
  DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> __Gen_Wrap_189(System.Object P0, System.Single P1, System.Single P2)
  Beyond.UI.UIImage __Gen_Wrap_190(System.Object P0)
  System.Boolean __Gen_Wrap_191(Beyond.UI.UIInertiaViewPager.ScrollEffectConfig& P0)
  System.Int32 __Gen_Wrap_192(System.Object P0, System.Single P1)
  System.Single __Gen_Wrap_193(System.Object P0, System.Single P1)
  Beyond.UI.UIInertiaViewPager.State __Gen_Wrap_194(System.Object P0, System.Object P1)
  System.Boolean __Gen_Wrap_195(Beyond.UI.UIInertiaViewPager.InertiaBlocker& P0, System.Single P1)
  System.Boolean __Gen_Wrap_196(System.Object P0, System.Single P1, System.Single& P2)
  System.Void __Gen_Wrap_197(System.Object P0, System.Single P1, System.Single P2)
  System.Void __Gen_Wrap_198(System.Object P0, Beyond.UI.UIInertiaViewPager.State P1, Beyond.UI.UIInertiaViewPager.State P2)
  System.Void __Gen_Wrap_199(System.Object P0, System.Int32 P1, System.Object P2)
  System.Void __Gen_Wrap_200(Beyond.UI.UIInertiaViewPager.EmptyScrollHandler& P0)
  System.Void __Gen_Wrap_201(System.Object P0, System.Boolean P1, UnityEngine.Vector2 P2, UnityEngine.Vector2 P3)
  System.Void __Gen_Wrap_202(System.Object P0, UnityEngine.UI.CanvasUpdate P1)
  UnityEngine.Transform __Gen_Wrap_203(System.Object P0)
  System.Void __Gen_Wrap_204(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4)
  System.Int32 __Gen_Wrap_205(System.Object P0, System.Boolean P1)
  System.Single __Gen_Wrap_206(System.Object P0, System.Int32 P1, Beyond.UI.UIScrollList.ScrollAlignType P2)
  System.Void __Gen_Wrap_207(System.Object P0, System.Int32 P1, System.Boolean P2, Beyond.UI.UIScrollList.ScrollAlignType P3)
  System.Void __Gen_Wrap_208(System.Object P0, System.Int32 P1, System.Int32 P2, System.Boolean P3, System.Boolean P4, System.Boolean P5, Beyond.UI.UIScrollList.ScrollAlignType P6)
  System.Void __Gen_Wrap_209(System.Object P0, System.Int32 P1, System.Boolean P2, System.Boolean P3, System.Boolean P4, System.Boolean P5)
  UnityEngine.GameObject __Gen_Wrap_210(System.Object P0, System.Int32 P1)
  Beyond.UI.UIScrollList.Cell __Gen_Wrap_211(System.Object P0, System.Int32 P1)
  System.Int32 __Gen_Wrap_212(System.Object P0, UnityEngine.UI.NaviDirection P1)
  System.Int32 __Gen_Wrap_213(System.Object P0, System.Int32 P1, UnityEngine.UI.NaviDirection P2)
  System.Void __Gen_Wrap_214(System.Object P0, System.Single P1, System.Single P2, System.Single P3)
  System.Boolean __Gen_Wrap_215(System.Object P0, UnityEngine.Vector3 P1)
  UnityEngine.Vector3 __Gen_Wrap_216(System.Object P0)
  System.Single __Gen_Wrap_217(System.Object P0, UnityEngine.Vector2 P1)
  System.Boolean __Gen_Wrap_218(System.Object P0, System.Single P1)
  Beyond.UI.UIScrollList.Padding __Gen_Wrap_219(System.Object P0)
  System.Void __Gen_Wrap_220(System.Object P0, System.Int32& P1, System.Int32& P2)
  System.Int32 __Gen_Wrap_221(System.Object P0, System.Int32 P1, System.Int32 P2)
  System.Int32 __Gen_Wrap_222(System.Object P0, UnityEngine.Vector2 P1, UnityEngine.UI.NaviDirection P2)
  System.Void __Gen_Wrap_223(System.Object P0, UnityEngine.Vector2 P1, System.Int32& P2, System.Int32& P3)
  Beyond.UI.UIScrollRect.MoveTipsType __Gen_Wrap_224(System.Object P0)
  System.Void __Gen_Wrap_225(System.Object P0, System.Object P1, System.Object P2, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState P3)
  System.Void __Gen_Wrap_226(System.Object P0, UnityEngine.Vector2Int P1)
  Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState __Gen_Wrap_227(System.Object P0)
  UnityEngine.Rect __Gen_Wrap_228(System.Object P0)
  System.Boolean __Gen_Wrap_229(System.Object P0, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState P1, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDir P2, System.Object P3)
  System.Void __Gen_Wrap_230(System.Object P0, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState& P1, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState& P2)
  System.Void __Gen_Wrap_231(System.Object P0, System.Boolean P1, System.Single P2)
  UnityEngine.Vector3 __Gen_Wrap_232(System.Object P0, System.Int32 P1)
  UnityEngine.Vector3[] __Gen_Wrap_233(System.Object P0)
  UnityEngine.UI.Graphic __Gen_Wrap_234(System.Object P0)
  Beyond.UI.UISoftMask __Gen_Wrap_235(System.Object P0)
  System.Boolean __Gen_Wrap_236(System.Object P0, System.Single P1, System.Single P2)
  UnityEngine.Vector2 __Gen_Wrap_237(System.Object P0, UnityEngine.Vector2 P1, UnityEngine.Vector2 P2, UnityEngine.Vector2 P3, UnityEngine.Vector2 P4)
  System.Void __Gen_Wrap_238(System.Object P0, UnityEngine.Vector2 P1, UnityEngine.Vector2 P2, UnityEngine.Vector2 P3, UnityEngine.Vector2 P4, System.Single& P5, System.Single& P6)
  System.Void __Gen_Wrap_239(UnityEngine.UIVertex& P0, UnityEngine.Vector2 P1, UnityEngine.Vector2 P2, UnityEngine.Vector2 P3)
  System.Void __Gen_Wrap_240(System.Object P0, System.Object P1, System.Object P2, System.Boolean& P3)
  Beyond.UI.UISoftMaskable __Gen_Wrap_241(System.Object P0)
  System.Collections.IEnumerator __Gen_Wrap_242(System.Object P0, System.Boolean P1, System.Int32 P2)
  System.Void __Gen_Wrap_243(System.Object P0, System.Boolean P1, System.Int32 P2)
  System.Void __Gen_Wrap_244(System.Object P0, System.Object P1, System.Boolean P2, System.Object P3, System.Object P4, System.Object P5, System.Boolean P6)
  System.UInt32 __Gen_Wrap_245(System.Object P0)
  System.Void __Gen_Wrap_246(System.UInt32 P0, System.Boolean P1)
  TMPro.TMP_FontAsset __Gen_Wrap_247(System.Object P0, System.Object P1)
  System.Boolean __Gen_Wrap_248(System.Object P0, System.Object P1, System.UInt32 P2, TMPro.TMP_FontAsset& P3)
  System.Boolean __Gen_Wrap_249(System.Single& P0, System.Single P1)
  System.Void __Gen_Wrap_250(Beyond.UI.TweenUtils.FLerpByTime& P0, System.Object P1)
  System.Single __Gen_Wrap_251(Beyond.UI.TweenUtils.FLerpByTime& P0, System.Boolean& P1)
  UnityEngine.Playables.PlayableGraph __Gen_Wrap_252(System.Object P0)
  UnityEngine.Animations.AnimationLayerMixerPlayable __Gen_Wrap_253(System.Object P0, UnityEngine.Playables.PlayableGraph P1, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FMixerOptions<UnityEngine.AnimationClip>& P2)
  UnityEngine.Animations.AnimationPlayableOutput __Gen_Wrap_254(System.Object P0, UnityEngine.Playables.PlayableGraph P1)
  UnityEngine.Animations.AnimationClipPlayable __Gen_Wrap_255(System.Object P0, System.Object P1, UnityEngine.Playables.PlayableGraph P2, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FPlayableMeta<UnityEngine.AnimationClip>& P3)
  UnityEngine.Animations.AnimationMixerPlayable __Gen_Wrap_256(System.Object P0, UnityEngine.Playables.PlayableGraph P1, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FMixerOptions<UnityEngine.AnimationClip>& P2)
  System.Void __Gen_Wrap_257(System.Boolean P0, Beyond.Resource.FAssetProxyHandle P1)
  System.Void __Gen_Wrap_258(Beyond.UI.UISwitchTween.TweenContext& P0)
  System.Void __Gen_Wrap_259(Beyond.UI.UISwitchTween.TweenContext& P0, System.Object P1)
  System.Void __Gen_Wrap_260(System.Object P0, Beyond.UI.UISwitchTween.Options P1)
  Beyond.UI.UISwitchTween.TweenContext __Gen_Wrap_261(System.Object P0)
  System.Boolean __Gen_Wrap_262(Beyond.UI.UISwitchTween.TweenContext& P0)
  System.Single __Gen_Wrap_263(Beyond.UI.FadeSwitchTween.Durations& P0, System.Single P1)
  Beyond.UI.FadeSwitchTween __Gen_Wrap_264(Beyond.UI.FadeSwitchTween.Builder& P0)
  UnityEngine.Vector2 __Gen_Wrap_265(System.Object P0, System.Boolean P1)
  System.Void __Gen_Wrap_266(System.Object P0, UnityEngine.RectInt& P1)
  System.Boolean __Gen_Wrap_267(System.Object P0, System.Object P1, Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause& P2)
  UnityEngine.RectInt __Gen_Wrap_268(System.Object P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_269(System.Object P0, System.Object P1, System.Object P2, UnityEngine.RectInt& P3)
  System.Boolean __Gen_Wrap_270(Beyond.UI.UIAtlasManager.UIAtlasHandle& P0)
  System.Void __Gen_Wrap_271(System.Object P0, System.Collections.Generic.List<UnityEngine.RectInt>& P1)
  System.Void __Gen_Wrap_272(System.Int32 P0, System.String P1)
  System.Boolean __Gen_Wrap_273(Beyond.UI.UIState.StateAnimationInfo P0)
  Beyond.UI.GPUI.GPUPrefabData __Gen_Wrap_274(UnityEngine.Vector4 P0, UnityEngine.Vector4 P1, UnityEngine.Vector2 P2)
  Beyond.UI.GPUI.GPUPrefabDataLite __Gen_Wrap_275(UnityEngine.Vector4 P0, UnityEngine.Vector4 P1, UnityEngine.Vector2 P2)
  System.Boolean __Gen_Wrap_276(Beyond.UI.GPUI.GPUIHandle& P0, Beyond.UI.GPUI.GPUIHandle P1)
  System.Boolean __Gen_Wrap_277(Beyond.UI.GPUI.GPUIHandle& P0, System.Object P1)
  System.Int32 __Gen_Wrap_278(Beyond.UI.GPUI.GPUIHandle& P0)
  System.Boolean __Gen_Wrap_279(Beyond.UI.GPUI.GPUIHandle P0, Beyond.UI.GPUI.GPUIHandle P1)
  Beyond.UI.GPUI.GPUIHandle __Gen_Wrap_280(System.Object P0)
  System.Void __Gen_Wrap_281(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1)
  System.Boolean __Gen_Wrap_282(System.Object P0, System.Object P1, Beyond.UI.GPUI.GPUIHandle& P2, System.Int32 P3)
  System.Boolean __Gen_Wrap_283(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1)
  System.Void __Gen_Wrap_284(System.Object P0, System.Int32 P1, UnityEngine.Vector3 P2)
  System.Boolean __Gen_Wrap_285(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, UnityEngine.Vector3 P2)
  System.Boolean __Gen_Wrap_286(System.Object P0, System.Object P1, UnityEngine.Vector3 P2, Beyond.UI.GPUI.GPUIHandle& P3, System.Int32 P4)
  System.Boolean __Gen_Wrap_287(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, UnityEngine.Vector2 P2)
  System.Void __Gen_Wrap_288(System.Object P0, System.Single P1, System.Int32 P2)
  System.Boolean __Gen_Wrap_289(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Boolean P2, System.Object P3, System.Boolean P4)
  System.Boolean __Gen_Wrap_290(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Boolean P2, System.Int32 P3, System.Boolean P4)
  System.Boolean __Gen_Wrap_291(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Object P2, System.Boolean P3)
  System.UInt32 __Gen_Wrap_292(UnityEngine.Color P0)
  System.Void __Gen_Wrap_293(System.Object P0, System.Int32 P1, UnityEngine.Color P2)
  System.Boolean __Gen_Wrap_294(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Object P2, UnityEngine.Color P3)
  System.Boolean __Gen_Wrap_295(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Object P2, System.Object P3)
  System.Void __Gen_Wrap_296(System.Object P0, Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData>& P1, System.Int32& P2, System.Int32& P3, System.Int32& P4)
  System.Void __Gen_Wrap_297(System.Object P0, Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData>& P1, System.Int32 P2, System.Boolean P3)
  Unity.Collections.NativeArray<UnityEngine.CanvasRenderer.InstanceRange> __Gen_Wrap_298(System.Object P0)
  System.Int32 __Gen_Wrap_299(System.Object P0, System.Object P1, System.Int32 P2)
  Beyond.UI.GPUI.RuntimePrefabData __Gen_Wrap_300(System.Object P0, System.Object P1)
  UnityEngine.Mesh __Gen_Wrap_301()
  System.UInt32 __Gen_Wrap_302(System.UInt32 P0, System.UInt32 P1)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000160
EXTENDS: AnonymousStorey
FIELDS:
  private           System.Int32                    methodId_0  // 0x40
  private           System.Int32                    methodId_1  // 0x44
  private           System.Int32                    methodId_2  // 0x48
  private           System.Int32                    methodId_3  // 0x4C
  private           System.Int32                    methodId_4  // 0x50
METHODS:
  System.Void System.IDisposable.Dispose()
  System.Boolean MoveNext()
  System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
  System.Void System.Collections.IEnumerator.Reset()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000161
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
TOKEN: 0x2000162
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-PoolCore-ListPoolInitializer_UI_Beyond-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-PoolCore-ListPoolInitializer_UI_Beyond-InitializeAtRuntime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-UI-Tools-UIGridLayoutElement-CalculateLayoutInputHorizontal0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-UI-Tools-UIGridLayoutElement-CalculateLayoutInputVertical0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-UI-Tools-UIGridLayoutElement-_GetPreferredSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_minWidth0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_preferredWidth0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_minHeight0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_preferredHeight0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-_InitState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-_UpdatePos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-_UpdateLookAtCamera0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-SetLookAtCamera0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-ForceUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellCircleEffect-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-UI-UIScrollCellSlantEffect-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_ResolveTextStyle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-_IsUITextDisplayable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-_GetGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextGroup-_NotifyDisplayableChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextGroup-_AddDisplayableCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextGroup-_SubDisplayableCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextGroup-ChangeDisplayable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-UpdateWrapDisplayable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-SetAndResolveTextStyle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-GetPhoneticText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-SetPhoneticText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-OnEnvLangChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-set_text0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_ReleaseUpdateFunction0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-TryGetOriginalLinkId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-TryGetLinkId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_UpdateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_CreateUpdateFunction0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_DelayedChangeActiveImageGo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-ClearMesh0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-RichTextAnalyzer-PreAnalyzeRichText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-GetOrLoadSprite0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-RichTextAnalyzer-GetCharacterCountWithoutRichText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-RichTextAnalyzer-ProcessRichTextEntryFallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_ProcessRichTextEntry0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-get_processRichTextEntryFunc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-RichTextAnalyzer-_GetHashCode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-RichTextAnalyzer-_TryParseParam0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-RichTextAnalyzer-_TryParseRichTextEntry0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-RichTextAnalyzer-AnalyzeRichText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_ReturnImageGO0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_ClearInlineImage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_GetOrCreateImageGO0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_GetImageGoByIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_ProcessRichTextInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-RefreshPopulateText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-I18nFontLoader-GetMaterial0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-LoadMaterial0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextGroup-Remove0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-RemoveWrap0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_OnPreRenderText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-DisposeInlineImageCache0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_GenerateRuntimeText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-I18nFontLoader-get_fontSearchData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-I18nFontLoader-IsFontDefaultMaterial0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-_RefreshMatTexture0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-I18nFontLoader-GetI18nFont0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-GetFontAsset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-OnPointerClick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-OnPointerEnter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-OnPointerExit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextWrap-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextGroup-Add0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-AddWrap0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-ChangeWrapGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-ChangeWrapOrder0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-SetHyperlinkUITextGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-ShrinkLinkTags0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-TryGetLinkId1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-TryGetCharacterStartPosAndHeight0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-TryGetCharacterEndPosAndHeight0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-CombineStringWithLanguageSpilt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-IsGroupDisplayable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-IsHyperlinkUITextGroupDisplayable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-HyperlinkUITextManager-GetGroupDisplayableUIText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-GetGroupDisplayableHyperlinkUIText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-UpdateI18NFontAsset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-get_m_fontAsset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-I18nFontLoader-GetCNFontId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-set_m_fontAsset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-set_fontSharedMaterial0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-SetSharedMaterial0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-OnAfterDeserialize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-AddSubTextObject0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIText-LocalStringCombineFormat0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIConst-IsPadDevice0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIConst-GetResolutionScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIModelLoader-LoadModel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIModelLoader-LoadModelAsync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIModelLoader-Cancel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIModelLoader-UnloadModel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIModelLoader-_Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIModelLoader-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-GetSharedIntString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-IsScreenPosInRectTransform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-IsScreenPosInRectTransform1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-CalcBoundOfRectTransform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-TryGetTouch0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-SetAlpha0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-SetColorWithoutAlpha0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-ClearUIComponents0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-RectTransformToScreenRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-GetNodeScaleOffset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-GetColorByString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-SetMaskRatio0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-GetCursorTipOffsetInScreen0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIUtils-GetCursorTipOffsetX0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ActiveSyncHelper-Sync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ActiveSyncHelper-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ActiveSyncHelper-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ActiveSyncHelper-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-Billboard-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-Billboard-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CinemachineGyroscopeEffect-PostPipelineStageCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetRealIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CommonItemToastList-_GetUnConstraintTargetPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CommonItemToastList-AdjustContainerPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-CacheCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-ClearShowingCells0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetShowRange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetNotCacheRange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-MoveCellTo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnUpdateCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-RecoverAllInput0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-_TryCallAnimationInFinished0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-InformAnimationInEnd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-ClearTween0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationLoopSynchronizer-GetLoopStartPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-_InitAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-GetClip0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-_SampleClipAtLength0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SampleClip0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-InformAnimationInStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-PlayWithTween0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-PlayLoopAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-_OnInEasingAnimationFinished0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-PlayWithTween1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-_OnInAnimationFinished0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-PlayOpenAudio0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-PlayInAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-UpdateCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-UpdateShowingCells0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-get_moveTips0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_UpdateMoveTips0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-UpdateViewEffect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CommonItemToastList-ScrollToIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ControllerSideMenuItemList-ToggleItemForceValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ControllerSideMenuItemList-IsItemForceValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ControllerSideMenuItemList-ClearForceValidItemList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-get_label0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-get_text0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetSprite0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetItemName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-get_inputValidTypeMask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-set_inputValidTypeMask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-_OnActiveTypeChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-IsShowTypeValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-get_isValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-ToggleActiveState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-CheckState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CustomUIStyle-IsValidInput0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DeactivateNaviOnEnable-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DeactivateNaviOnEnable-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DecoLineActiveHelper-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DecoLineActiveHelper-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DecoLineActiveHelper-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DecoLineActiveHelper-_HasActiveTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-Empty4Raycast-OnPopulateMesh0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FitAspectRatioByFOV-_AdjustFOV0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FitAspectRatioByFOV-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FitAspectRatioByFOV-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FitAspectRatioByFOV-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FitAspectRatioByFOV-OnScreenSizeChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FixRotation-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FullScreenSceneBlurMarker-_GetNextId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FullScreenSceneBlurMarker-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FullScreenSceneBlurMarker-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FullScreenSceneBlurMarker-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FullScreenSceneBlurMarker-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-InputBindingGroupNaviDecorator-_SetSelfEnabledStateIfNecessary0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-InputBindingGroupNaviDecorator-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-InputBindingGroupNaviDecorator-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-InputBindingGroupNaviDecorator-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-InputBindingGroupNaviDecorator-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-InputBindingGroupNaviDecorator-_OnSetAsNaviTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-_TrySetRot0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-AddSortingOrderComp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-RemoveSortingOrderComp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-BlockAllInput0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-_AutoAnimationInFinish0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-LuaPanel-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MouseHoverTipsPosHelper-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MouseHoverTipsPosHelper-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MouseHoverTipsPosHelper-UpdatePosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MouseHoverTipsPosHelper-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MouseHoverTipsPosHelper-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NaviToThisGroupOnEnable-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NaviToThisGroupOnEnable-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_FindDefaultSelectable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-NaviToThisGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NaviToThisGroupOnEnable-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NonDrawingGraphic-get_Radius0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NonDrawingGraphic-SetMaterialDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NonDrawingGraphic-SetVerticesDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NonDrawingGraphic-OnPopulateMesh0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NonDrawingGraphic-_IsRaycastLocationValidCircle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NonDrawingGraphic-IsRaycastLocationValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-ClearNullRef0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-ApplyNotch0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-ApplyNewNotch0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-_OnCanvasChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-_UpdateMargeSizeFromNotchInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-ClearList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-_TryAddToSideUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-_TraverseUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-FindAllSideUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-ApplyNotch1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-NotchAdapter-UnApplyNotch0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ParallaxHelper-InitConfigs0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ParallaxHelper-ResetValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ParallaxHelper-RefreshPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PercentNumberTweener-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PercentNumberTweener-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-PercentNumberTweener-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutAdapter-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutAdapter-GenerateViewsForRebuild0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutAdapter-VirtualView-AttachView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutAdapter-VirtualView-DetachView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutAdapter-VirtualView-GetAttachedView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutAdapter-VirtualView-GetViewID0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-get_adapter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-get_viewMgr0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-CalculateLayoutInputHorizontal0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-CalculateLayoutInputVertical0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-get_paddingFront0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-get_paddingBack0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_ApplyLayoutMeta0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_GetVisibleRange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_GetElementBoundsFromMeta0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewPool-RecycleAll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-RebuildAll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViews0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_UpdateViews0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_RebuildAllViews0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-SetAdapter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-_EnsureViewPool0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewPool-Recycle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-DetachView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewPool-Alloc0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-AttachView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-OnLateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_InsertView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_RemoveView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_UpdateViewsFrom0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_GetElementPosByIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_GetElementBoundsByIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_GetElementIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-_RefreshLayout0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViewCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-InsertView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-AddView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-RemoveView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyViewSizeChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyAllViewSizeChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyRebuild0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementPosByIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementBoundsByIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetDirection0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetSizeOnAxis0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViewportSizeOnAxis0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-ViewMgr-_NotifyLayoutChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-EmptyAdapter-GenerateViewsForRebuild0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleLayoutGroup-EmptyAdapter-OnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-GetVirtualView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-UpdateCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-UpdateCount1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-InsertView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-AddView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-OnAdapterInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetPrefab0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetPreferSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-OnViewDetached0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-OnViewAttached0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-GetVirtualView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-UpdateCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-UpdateCount1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-InsertView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-AddView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-OnAdapterInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetPrefab0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetPreferSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-OnViewDetached0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-OnViewAttached0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-SimpleUITextSingleLine-GenerateTextMesh0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-_CacheCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-ClearAllToast0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-_GetCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-PlayCloseAudio0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-PlayOutAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-_TryShowNewCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-GetOutClipLength0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-_OnCellFinished0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-_ShowCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-_StartBatch0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-AddToast0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-ToastList-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UI3DScrollList-MoveCellTo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-DisposeSpriteHandle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-_LoadSprite0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-LoadSpriteWithOutFormat0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_SetKeyCodeSprite0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-GetAndSetActionIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_SetSecondIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-SetSecondActionId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-GetActionId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-GetActionInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-SetContentState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-GetAndSetActionModifyIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-GetTextStr0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_IsInputGray0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_IsInputEnabled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_CheckInteractable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-UpdateKeyHint0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_RefreshAllKeyHints0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_OnControllerTypeChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_OnInputLateTickAll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_TryInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_OnInputActionKeyUpdated0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-_OnChangeTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-SetKeyHint0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-SetActionId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-SetBindingId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-SetBindingId1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIActionKeyHint-SetText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationHolder-_FindByString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationHolder-FindByName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationHolder-FindByNameOrAlias0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationHolder-GetAnimationClips0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationLoopSynchronizer-RegisterChild0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationLoopSynchronizer-UnregisterChild0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SetOptions0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-_AnimationInLoopCheck0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-_AnimationAutomaticallyCheck0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-IsStarted0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SetAnimationOutClip0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-GetInClipLength0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-GetLoopClipLength0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SkipInAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SampleToInAnimationBegin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SampleToInAnimationEnd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SampleToOutAnimationEnd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-AnimationRuntime-GetClipLength0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-GetClipLength0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-SampleClipAtPercent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-_CheckShouldAutoPlayAnimationIn0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-CheckStopped0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-Play0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-Play1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationTween-GetValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-GetCurPlayingTime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationWrapper-FOptions-GetDefault0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationTween-_SetValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-GenerateTweenOfHide0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-GenerateTweenOfShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-_SetGameObjectActive0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-BeforeShowEffect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-AfterHideEffect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-ResetToState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-TweenHandler-IsPlaying0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-TweenHandler-KillIfNecessary0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-TweenHandler-OnComplete0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-TweenHandler-SetAutoKill0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-TweenHandler-_OnComplete0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationSwitchTween-Builder-Build0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIArea-_SetHighlightNodeActive0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIArea-OnPointerEnter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIArea-OnPointerExit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIArea-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIArea-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIArea-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIArea-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-AddToAutoCloseLayer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-RemoveFromAutoCloseLayer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-set_includeInAutoCloseLayer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-_AutoCloseToggleObjWhenOut0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-CloseSelf0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-TryCloseSelf0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-_UpdateState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-InitBinding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-_GetUICamera0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-IsTopAutoCloseLayer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-ShouldClose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-ChangeEnableCloseActionOnController0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-OpenSelf0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAutoCloseArea-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigLogo-SetBigLogoEditor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigLogo-ShowBigLogo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigLogo-SetBigLogoMask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigLogo-ClearBigLogoMask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigLogo-ClearBigLogo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigLogo-SetAlpha0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigLogo-SetMaskAlpha0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_StopLongPressCor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_DoClickAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_PlayClickAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_OnPress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-OnPointerDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectButton-OnPointerDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-OnPointerUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectButton-OnPointerUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectButton-OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectButton-OnBeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectButton-OnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectButton-OnScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-get_zoomEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_GetContainerRectBounds0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_GetAdjustedPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_RefreshPivotPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-ResetPivotPositionToScreenCenter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_RefreshPivotPositionToMousePosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_RefreshPivotPosition1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_UpdatePositionOffsetAfterZoomed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_PosAdjust0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_SetScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_SetZoomValueAndScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_OnZoom0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_RefreshControllerFocusRaycastResults0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_OnControllerClick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_InitControllerBindings0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_GetIsControllerMoveEnabled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_TickRefreshControllerStickMove0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_GetIsControllerZoomEnabled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_TickRefreshControllerStickZoom0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_TickRefreshControllerZoomKeyHint0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_TickRefreshController0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_TickCheckControllerFocusRaycastTargets0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-ManuallyZoom0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_TryAlignWhenInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-_ResetControllerState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-FocusNode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-FocusNode1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-ZoomToFullRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-ChangePaddingRight0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-SetZoomRangeMax0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-OverrideZoomRangeMin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-SyncZoomValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-GetZoomRange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-GetCurrentZoomValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-ChangePivotPositionToTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-ClearAllTween0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBigRectHelper-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlendImage-SetMaterialKey0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlendImage-SetColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlendImage-SetTexture0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlendImage-ClearMaterialCache0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurMono-get_canvas0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurMono-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurMono-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurMono-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurMono-UpdateSortingOrder0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurMono-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-InitRT0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-Register0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-UnRegister0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-UpdateRT0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-_Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIBlurRT-SetUseSceneColorPS0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_UpdateState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_Press0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-OnPointerClick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_OnUpdateKey0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_InitActionOnSetNaviTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-InitBinding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_NotifyIsHover0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-set_text0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-OnInteractableChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_GetUIButtonKeyHintActionId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-get_bindingViewActionId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-set_customBindingViewLabelText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-get_hintText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-get_bindingViewState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-GetBindingViewActionId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-Beyond.Input.IBindingView.OnInputKeyDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-Beyond.Input.IBindingView.OnInputKeyUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_RefreshHoverEnableNode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-GetMouseActionHints0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-OnNaviTargetEnabledAgain0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_ToggleNaviInputBinding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-_OnSetAsNaviTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-ChangeActionOnSetNaviTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIButton-Beyond.Input.IBindingView.get_interactable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-get_standardHorizontalResolution0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-get_standardVerticalResolution0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-get_canvasScalerList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-GetProperCanvasResolution0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-_OnInputTypeChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-_CanvasOnWillRenderCanvases0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-CalcCurrentScreenRatio0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-CalcWorldCanvasParams0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-CalcScreenCanvasParams0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-UpdateCanvas0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-OnScreenSizeChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-AddCanvas0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-RemoveCanvas0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICanvasScaleHelper-ForceCanvasUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-_SetColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-_ApplyOptToGraphics0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-set_color0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-AttachGraphic0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-AttachGraphicsWithGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-_CrossFadeAlpha0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-CrossFadeAlpha0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-_CrossFadeColorRGB0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-CrossFadeColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-_CrossFadeColorAlpha0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIColorGroup-CrossFadeColor1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIControllerKeyIcon-RefreshKeyIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIControllerKeyIcon-_OnControllerTypeChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIControllerKeyIcon-_TryStaticInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIControllerKeyIcon-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIControllerKeyIcon-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIControllerKeyIcon-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayout-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-IsDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayout-IsDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-_SetChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-get_Element0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-_GetMarginSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-_ApplyScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-_ApplyAlpha0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-_ApplyPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-ResetToDefault0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-ResetToDefault0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-_CheckElementKeyIsValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-GetElementKeyWithRatio0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-SaveData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-Save0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayout-_LogEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayout-Save0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayout-ResetToDefault0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-get_highlightRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-_SetDefaultValues0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-LoadData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-_OnHudLayoutSaved0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutElement-RefreshAll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-_ApplyScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-_CalculatePositionRange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-_ApplyPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-set_position0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-set_scale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-_ApplyAlpha0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-set_alpha0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-_ApplyLayoutType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-set_layoutType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-_OnElementDataLoaded0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-_OnSystemDisplaySizeChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-OnBeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-OnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-OnPointerClick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UICustomLayoutHandle-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-get_playing0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-ResetPlay0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-_RefreshPosY0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-RefreshAutoScrollData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-SetText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-Play0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-RefreshText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-OnVisibleCharactersChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-StopPlay0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-GetAutoWaitTime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-GetScrollSpeed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-_TryAutoScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-_UpdateTextAuto0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-SeekToEnd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-ManualUpdateByPercent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-ManualUpdateByTime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogText-GetDisplayAllCharactersTime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogTextWithCursor-ResetPlay0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogTextWithCursor-OnVisibleCharactersChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogTextWithCursor-GetDisplayAllCharactersTime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogTimelineText-get_canvasGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogTimelineText-UpdateAlpha0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-LoadSprite0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogTimelineText-_ClearRadioIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDialogTimelineText-SetRadioIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDrag-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDrag-OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDrag-OnBeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDrag-OnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDrag-ApplyDragArea0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDrag-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragHandler-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragHandler-OnPointerDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragHandler-OnBeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragHandler-OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragHandler-OnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-get_m_dragParentRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-_StopDragView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-OnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-_ContinueDragOnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-ClearEvents0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDragItem-OnBeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-_GetDefaultNaviTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-_ToggleOptions0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_OnFocus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-ManuallyFocus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-_ControllerToggle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_OnStopFocus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-ManuallyStopFocus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-ToggleOptions0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-_ControllerCancel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-_InitBinding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-_NotifyIsHover0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-OnPointerClick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-_GetUICamera0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-Update0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-SetSelected0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-_GetUICamera0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-ScrollTo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-AutoScrollToRectTransform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-ScrollToSelected0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-Refresh0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdown-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdownOption-SetText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateReference-SetController0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-get_IsEmpty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyGameObject0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyGraphic0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateControllerUtils-SetTop0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateControllerUtils-SetBottom0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateControllerUtils-SetLeft0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateControllerUtils-SetRight0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateControllerUtils-ForceRebuildLayout0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyRectTransform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyImage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyCanvasGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyButton0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyAnimator0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyLayoutElement0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyInnerState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateController-OnStateReferenceDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateReference-ScheduleForPlaying0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateControllerUtils-StartEditorUpdateLoop0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateAnimationInfo-OnUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateReference-ScheduleForStopping0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyLayoutGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetLeftLength0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_SetRealPadding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetContainerSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetContainerSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-UpdateContainerSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetPadding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyScrollList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ApplyGridLayoutGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateController-_ApplyState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateController-SetState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropdownOption-SetState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropItem-ClearEvents0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropItem-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropItem-ToggleHighlight0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropItem-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropItem-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropItem-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropItem-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIDropItem-OnDrop0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIElementFollower-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIElementFollower-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIElementFollower-UpdatePosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIElementFollower-UpdatePosition1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIElementFollower-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIElementFollower-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIExtendScrollRect-OnScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnBeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIExtendScrollRect-OnBeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIExtendScrollRect-OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIExtendScrollRect-OnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFoldoutComponent-Refresh0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-NotifyCellSizeChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFoldoutComponent-OnFoldOut0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFoldoutComponent-OnFoldIn0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIFoldoutComponent-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGraphicAnimation-_Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGraphicAnimation-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGraphicAnimation-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGraphicAnimation-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-_InitIfNot0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-_SetCircleWrapScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayoutInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-_FindValidSelectable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-_NaviChildren0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayoutImpl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayout0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-RectWrapNavigate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-WrapNavigation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-_InitWrapNavigation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGridLayoutNaviWrapper-TryWrapNavigate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGyroscopeEffect-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGyroscopeEffect-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIGyroscopeEffect-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHighlightMask-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHighlightMask-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHighlightMask-TrySyncRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHighlightMask-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIHighlightMask-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-RegisterOnEnableRuntimeAtlas0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-UnregisterOnEnableRuntimeAtlas0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-OnEnableRuntimeAtlas0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-get_enableRuntimeAtlas0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-UIAtlasHandle-CreateInvalidHandle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_ReProcessInsertForUIImage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-ReProcessInsertForUIImage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-_OnSpriteChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-OnPopulateMesh0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_AddUIImageToManagerOnInstantiate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-AddUIImageToManagerOnInstantiate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_AddUIImageToManager0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-AddUIImageToManager0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_RemoveUIImageFromManager0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-RemoveUIImageFromManager0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-SetNativeSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-SetNativeSizeIgnoreRefScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-LoadSprite1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-LoadMaterial0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-ReleaseSprite0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-get_mainTexture0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImage-_V2AtlasInitialize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageBlur-OnChangeSprite0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageBlur-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageBlur-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageBlur-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageBlur-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillAmountOffset-set_fillAmount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillAmountOffset-DOFillAmount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillFollower-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillFollower-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillFollower-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillFollower-RefreshFillAmount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillTailFollower-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillTailFollower-RefreshFollower0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillTailFollower-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImageFillTailFollower-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImagePair-LoadSprite0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImagePair-LoadSprite1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImagePair-set_color0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIImagePair-get_first0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_PlayAudioGear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_PlayAudioGearLock0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-ScrollEffectConfig-IsEmpty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_InitIfNot0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-DragContext-BeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_ScrollValueAlignToPage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_ScrollValue2PageIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_PageIndex2ScrollValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_SwitchToPage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-DragContext-_TryFlingToNext0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-DragContext-EndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-BlockerManager-StartInertia0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-InertiaBlocker-IsDirMatch0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-BlockerManager-HitInertiaBlock0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_AutoAlign0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-NotifyScrolling0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-NotifyAlignFinish0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-_OnStateChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-BlockerManager-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-SetPageCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-MoveToPage0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-CustomScrollHandler-_OnScrollBegin0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-CustomScrollHandler-_OnScrollEnd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-CustomScrollHandler-OnClear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_velocity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_scrollProgress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-CustomScrollHandler-set_scrollProgress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-CustomScrollHandler-StopMoving0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-StopMoving0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-OnClear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-MarkHasScrolled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-get_isControllerInputValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-SendOnFocus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-SendOnFocusLost0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_VirtualKeyboardAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_VirtualKeyboardSelect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-OnSelect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_VirtualKeyboardDeselect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-OnDeselect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-set_s_focusedInputField0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-ActivateInputField0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-DeactivateInputField0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_VirtualKeyboardOnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_UpdateBindingEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_NotifyIsHover0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-OnInteractableChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_GetCamera0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_UpdateKeyboardOffset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIInputField-_KeyboardHeightChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_UpdateWalkBgScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-set_walkRation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-get_m_thumbPosMaxLength0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_UpdateState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-InitBinding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_SetRectTransform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_SetVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_UpdateGait0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_UpdateIndicator0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_SetWalkBgVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_SetRunBgVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_UpdateBg0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_Activate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-OnPointerDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-OnBeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-OnPointerUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_ChangeDynamic0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_OnHudLayoutLoaded0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-_Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIJoystick-CheckShouldActive0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-GraphicUpdateComplete0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-LayoutComplete0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-_InvokePostLayoutCallback0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-_NextFrameCoroutine0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-Rebuild0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-DoOnceOnPostLayout0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-_SetDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-OnRectTransformDimensionsChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILayoutDimensionListener-UnityEngine.UI.ICanvasElement.get_transform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILeftSubtitle-UpdateByPlayTime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILeftSubtitle-SetVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILeftSubtitle-Exit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILeftSubtitle-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILeftSubtitle-StartAutoPlay0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILeftSubtitle-SetLeftSubTitle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMaterialAnimation-_TryUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMaterialAnimation-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMaterialAnimation-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMaterialAnimation-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIMaterialAnimation-ForceUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_GetLineCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-CalcSomeCountNum0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SyncViewSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-InitBasicInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-InitBasicInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-CalcSomeCountNum0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetLeftLength0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-InitConfig0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-get_currentStep0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_StartGraduallyShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-StopGraduallyShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SkipGraduallyShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetTargetPosByIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-TryClearAdjustTween0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_ScrollToPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-ScrollTo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-RestartGraduallyShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-ClearLastFocusNaviTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_ClearRelatedNaviGroup0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-UpdateCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-UpdateCount1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-UpdateCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-UpdateCount1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-UpdateCount2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-get_curSelectedIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-set_curSelectedIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-Get0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetCell1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-ScrollToIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetSelectedIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetNaviOffset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetNaviNewIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-NavigateSelected0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_InitNavigation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-TryRecalculateSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-OnScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetGridLayoutSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-_GetCellSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetContainerSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetCenterIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetShowRange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetNotCacheRange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-_GetCellsSizeTo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-MoveCellTo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISizeFollower-get_rectTransform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISizeFollower-SyncSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-OnUpdateCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetTargetPosByIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-ScrollTo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-get_currentStep0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-SetStepTo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-SetCurrentStep0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetScrollBarSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetLastScrollStep0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-UpdateLastScrollStep0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-GetNormalizedPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-SetNormalizedPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-ToggleByState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-Toggle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollList-FoldAll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollRect-_UpdateNonUnifiedScrollbars0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollRect-_OnPostLayout0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollRect-_InitIfNot0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollRect-UpdateScrollbars0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollRect-Rebuild0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollRect-SetHorizontalNormalizedPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINonUnifiedScrollRect-SetVerticalNormalizedPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINumberScrollTween-get_text0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINumberScrollTween-set_text0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINumberScrollTween-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINumberScrollTween-_HandleNumberScrollTween0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINumberScrollTween-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINumberScrollTween-_CleanupBeforeTween0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UINumberScrollTween-_TweenToTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIPCScaleHelper-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRegionBuildingTexManager-_UpdateTexture0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRegionBuildingTexManager-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRegionBuildingTexManager-OnValidate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIRegionBuildingTexManager-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScaleHolder-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScaleHolder-_IsValidScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScaleHolder-_HoldScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScaleHolder-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScaleHolder-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScaleHolder-SetExtraScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScaleHolder-GetExtraScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollbar-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollbarKeyHint-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-get_controllerStickScrollEnabled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollbarKeyHint-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-get_viewRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnInitializePotentialDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-IsActive0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnBeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_GetDeltaAngle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_CheckCanMove0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_UpdateSpeed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_GetRealIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_UpdateShowingCells0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_UpdateCenterIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_TryUpdateCells0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_UpdateAuto0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_InitCells0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_OnAwakeInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_UpdateScrollRange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-_DoScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-Rebuild0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-LayoutComplete0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-GraphicUpdateComplete0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-IsDestroyed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-ScrollToIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-UpdateCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-Get0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-UnityEngine.UI.ICanvasElement.get_transform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollCircle-Cell-SetSelect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollContainerFollower-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollContainerFollower-_RefreshSizeAndPositionToTargetContainer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollContainerFollower-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_SetAutoScrollSpd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_OnEnterAutoScrollUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_OnExitAutoScrollUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_OnEnterAutoScrollDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_OnExitAutoScrollDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_InitAutoScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-ListWrapNavigate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_InitControllerNavi0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_InGameAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_EditorAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_UpdateGraduallyShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetStepTo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_UpdateAutoScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetTop0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-UpdateCount2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-UpdateShowingCells1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetRangeInView0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetCellCanCache0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-CacheShowingCell0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetPaddingBottom0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetPaddingTop0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetPaddingRight0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetPaddingLeft0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetPadding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetShowingCellsIndexRange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-SetSpace0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetCenterIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetIndexOf0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-ScreenPos2Index0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-GetMousePosIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollList-_GetScreenPosLineColumnInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-_CheckOverScrollEffect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-ScrollToNaviTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-_InitController0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-_TickRefreshControllerStickScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-get_moveTips0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-_UpdateMoveTips0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-Update0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-IsCellViewed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-_CustomSetPosOnScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-UpdateScrollEnableNode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-OnBeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-_CheckOverScrollOnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-OnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRect-LateUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-ResetReferences0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-_UpdateRedDotGameObjects0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-RegisterRedDotStatesForScrollList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-_OnScrollListUpdateCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-_UpdateCacheDictForRangeChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_state0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_newPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_normalPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_newRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_normalRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-IsRedDotInDir0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-_CalculateRedDotStateInDir0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-UpdateRedDotStateInDir0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-ResetRedDotPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-RegisterRedDot0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollRectEdgeRedDot-UnregisterRedDot0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-_InitIfNot0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-_ApplyTextAlignment0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-_ResetTextScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-_ResetTextScrollInternal0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-ResetTextScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-_UpdateScrollState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-_ApplyTextScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-CanvasGroupHandler-HandleAlpha0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-PositionScrollHandler-ApplyScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-PositionScrollHandler-ResetScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-PositionScrollHandler-UpdateScrollStatus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-MeshScrollHandler-_UpdateMeshClipping0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-MeshScrollHandler-_ApplyScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-MeshScrollHandler-ApplyScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-MeshScrollHandler-ResetScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIScrollText-MeshScrollHandler-UpdateScrollStatus0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_RefreshFocusBindings0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_InitFocusBinding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_RefreshRelatedBindingGroupsState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_RefreshFocusActionKeyHint0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_RefreshStopFocusActionKeyHint0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_OnIsTopLayerChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_OnSelectableNaviGroupDisabled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_BeforeSelectableNaviGroupDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_OnSetLayerSelectedTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_OnRemoveFromLayerStack0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-_TryChangeNaviPartner0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnLeft0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnRight0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-RefreshFocusBindings0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-SetFocusBindingText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISelectableNaviGroup-ManuallyRefreshRelatedBindingGroups0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-get_controllerStickScrollEnabled0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-_InitializeCells0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-UpdateLayout0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-_ApplyDamping0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-OnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-_TickRefreshControllerStickScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-RefreshLayout0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollList-OnBeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollListPair-_OnCellShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollListPair-_OnClosestCellChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollListPair-_OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollListPair-_OnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollListPair-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISemiCircleScrollListPair-RefreshLayout0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISequenceImage-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISequenceImage-SetSprite0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISequenceImage-Play0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISequenceImage-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISequenceImage-Stop0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISequenceImage-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISequenceImage-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISimpleActiveAnimationHelper-Skip0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISimpleActiveAnimationHelper-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISimpleActiveAnimationHelper-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISimpleActiveAnimationHelper-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISimpleStateController-SetState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISimpleStateController-StateInfo-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISizeFollower-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-_TryPostSlideAudioEvent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-ClampValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-CustomProcessNormalizedValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-OnValueChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-OnClickSliderBar0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-OnClickSliderHandle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-_NotifyIsHover0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-OnBeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-OnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-_ApplyStickScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-_StickScrollHoriValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-_InitStickScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-_AddValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-_ReduceValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-_InitBinding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-get_bindingViewState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-GetBindingViewActionId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-Beyond.Input.IBindingView.OnInputKeyDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-Beyond.Input.IBindingView.OnInputKeyUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISlider-Beyond.Input.IBindingView.get_interactable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-GetTextSoftMaskMaterial0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-GetUIVFXSoftMaskMaterial0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-GetCornerCanvas0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-GetFourCornnerArrayWorld0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-get_graphic0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-MarkGraphicVerticesDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-MarkGraphicMaterialDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-_UpdateChildren0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-_UpdateParam0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-_OnEnableRuntimeAtlas0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-_DestroyMaterial0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-_Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMask-TailLateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-get_softMask0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-get_uiText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-GetModifiedMaterial0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-ModifyMesh0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-_Equal0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-_ComputeLineCross0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-_ComputePointAtTriangleUV0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-_SetUIVertexUV0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-_ClipTriangleByClampSoftMaskUV0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-_ClipRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISoftMaskable-ModifyMesh1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISortingOrder-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISortingOrder-_GetRenderer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISortingOrder-_GetChildrenRenderers0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISortingOrder-_GetCanvas0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISortingOrder-SetOrder0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISortingOrder-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISortingOrder-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-_GetClampedIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-_TryAutoScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-_OnScrollEnd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-_OnScrollStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-InitConfig0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-OnScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-OnBeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-OnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-SetTop0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-UpdateShowingCells0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStepScrollList-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStyleByState-_IsValidStyle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStyleByState-UpdateStyle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStyleByState-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIStyleByState-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISubtitle-_SetAsDefault0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISubtitle-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISubtitle-SetSubtitle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISubtitle-UpdateAlpha0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITextPair-get_text0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITextPair-set_text0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITextPair-set_color0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITextPair-get_first0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITextPair-SetAndResolveTextStyle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITextPair-SetPhoneticText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_OnToggleFail0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-TryInternalToggle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_TryRefreshBindingText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_TryRefreshToggleBindingText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_TryRefreshHoverConfirmBindingText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_InitActionOnSetNaviTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_InitToggleBinding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_UpdateObjects0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_PlayAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_UpdateBindingEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-PlayAudio0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-InternalToggle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnValueChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_NotifyIsHover0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnInteractableChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-GetMouseActionHints0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnPointerDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnPointerClick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnSubmit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-OnNaviTargetEnabledAgain0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_ToggleNaviInputBinding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggle-_OnSetAsNaviTarget0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggleGroup-_MoveTo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggleGroup-MoveToNext0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggleGroup-MoveToPrevious0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggleGroup-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggleGroup-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggleGroup-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIToggleGroup-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-_IsSameTouchFromPress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnBeginDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-DoEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnEndDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnDrag0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-_OnActionPress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnPointerDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-_OnActionRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnPointerUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnPointerClick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnPointerEnter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnPointerExit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-ClearTouchInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnScroll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-SimulateClick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-DeActiveTouch0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-_UpdateState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-InitBinding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnAwake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-ClearComponent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UITouchPanel-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-get_graphic0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-get_softMaskable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-_UpdateParam0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-_OnEnableRuntimeAtlas0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-_DestroyMaterial0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-_Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIVFXManager-GetModifiedMaterial0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWorldLevelScrollListAnimCtrl-ScrollListLayoutInfo-get_cellHeight0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateUpPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateDownPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateMidPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWorldLevelScrollListAnimCtrl-_ScrollLayouts0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateWorldLevelScrollList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIWorldLevelScrollListAnimCtrl-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-VirtualMouseInitPos-get_panel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-VirtualMouseInitPos-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CSPopupPanel-_OnConfirm0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CSPopupPanel-_OnCancel0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CSPopupPanel-Awake0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CSPopupPanel-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-CSPopupPanel-Show0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MobileMotionManager-_CheckMotionLevelAndPostIfChange0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MobileMotionManager-OnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MobileMotionManager-OnRelease0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MobileMotionManager-PostEventCommonShort0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MobileMotionManager-PostEventCommonOperateSuccess0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-MobileMotionManager-PostEventCommonOperateFailure0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DynamicFontAssetLoader-AddNotFoundUnicode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DynamicFontAssetLoader-FontAssetRef-GetFontAsset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DynamicFontAssetLoader-TryGetFontAsset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DynamicFontAssetLoader-FontAssetRef-RemoveRefText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DynamicFontAssetLoader-TryRemoveRefText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DynamicFontAssetLoader-FontAssetRef-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-DynamicFontAssetLoader-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-TweenUtils-TickAsCountDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-TweenUtils-FLerpByTime-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-TweenUtils-FLerpByTime-GetValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationLayerMixPlayer-LockToClip0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationLayerMixPlayer-CreateGraph0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationLayerMixPlayer-CreateMixer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationLayerMixPlayer-CreateOutput0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationLayerMixPlayer-CreateSourceFromAsset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationMixPlayer-LockToClip0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationMixPlayer-CreateGraph0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationMixPlayer-CreateMixer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationMixPlayer-CreateOutput0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAnimationMixPlayer-CreateSourceFromAsset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILoadImageSprite-_LoadSprite0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILoadImageSprite-set_spritePath0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILoadImageSprite-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UILoadImageSpriteByName-set_spriteName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-BeforeShowEffect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-BeforeHideEffect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-AfterShowEffect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-AfterHideEffect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-ResetToState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-TweenContext-OnReset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-TweenContext-OnTweenStop0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-ClearTween0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-_ClearTweenInternal0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-Show0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-Hide0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-WaitForTweening0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-SetOptions0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-Clear0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-GetContext0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-TweenContext-IsInterapted0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-TweenWrapper-IsActive0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-TweenWrapper-IsPlaying0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-TweenWrapper-KillIfNecessary0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-TweenWrapper-OnComplete0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UISwitchTween-TweenWrapper-SetAutoKill0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-set_activeAlpha0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-Durations-GetHideDuration0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-GenerateTweenOfHide0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-Durations-GetShowDuration0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-GenerateTweenOfShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-SetObjectActive0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-BeforeShowEffect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-AfterHideEffect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-ResetToState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-Release0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeSwitchTween-Builder-Build0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-_GetTargetAlpha0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-_GetTargetPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-GenerateTweenOfHide0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-GenerateTweenOfShow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-BeforeShowEffect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-AfterHideEffect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-ResetToState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-TweenHandler-IsPlaying0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-TweenHandler-KillIfNecessary0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-TweenHandler-OnComplete0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-FadeTranslationSwitchTween-TweenHandler-SetAutoKill0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-UIAtlasPage-FreeRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_ProcessRemoveQueue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_IsRuntimeAtlasCompatible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-UIAtlasPage-InsertRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-UIAtlasPage-CopyIntoAtlas0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_ProcessInsertQueue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-LateTick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_CreateTickFunction0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-OnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-_ClearTickFunction0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-OnUnInit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-Release0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-GetAtlasCount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-UIAtlasHandle-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-UIAtlasPage-InsertRects0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIAtlasManager-UIAtlasPage-FreeRects0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-WebApplication-Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateControllerUtils-GetName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-get_ReadableDescription0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-_OnGridLayoutGroupChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-_OnImageChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-_OnLayoutElementChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-_OnLayoutGroupChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-_OnRectTransformChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-_OnScrollListChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateDescription-_OnTextChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateController-Run0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateController-Stop0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-StateReference-HandleScheduledStates0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateController-_HandleStateAnimations0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-UIState-UIStateController-Tick0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUPrefabData-CreateFontNode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUPrefabDataLite-CreateFontNode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUIHandle-Equals0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUIHandle-Equals1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUIHandle-GetHashCode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUIHandle-op_Equality0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUIHandle-op_Inequality0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-GetFontAsset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-get_fontAsset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-set_fontAsset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_GetOneHandle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-Create0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-Add0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_CreateInstance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_IsHandleInvalid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-SetPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-MarkNeedUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-SetRootPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-CreateInstance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-Remove0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-Recycle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_RecycleOneHandle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_DestroyInstance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-DestroyInstance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-IsInstanceValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-SetRootScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-SetRootScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-StartAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-StartAnimation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-StartAnimation1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-SetVisibility0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUIUtils-ColorToRGBAUint320  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-SetColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-SetColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-SetText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-SetText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_CleanMaterials0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_DoOnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_DestroyAnimatedInstance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-_FillInstanceQueue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-_AllocBuffer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-DoUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-DoUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-get_gpuGroups0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_UpdateWorldMat0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_RenderNodes0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_DoLateUpdate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_PreWillRenderCanvases0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_InitMaterials0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_PreloadTextInGroupData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-InstanceBufferManager-BindInstanceList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_LoadPrefabNodeBuffer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_LoadPrefabData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_LoadGroupData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_RefreshMaterials0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-_Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-OnPopulateMesh0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUISystem-UpdateMaterial0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-GPUIUtils-CreateQuadMesh0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-RuntimeInstance-SetVisibility0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-UI-GPUI-CodePoint-ConvertToUTF320  // 0x0
METHODS:
END_CLASS

