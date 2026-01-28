// ========================================================
// Dumped by @desirepro
// Assembly: UI.Beyond.dll
// Classes:  354
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class UIMinSizeAdjust : MonoBehaviour
    {
        // Fields
        private UnityEngine.RectTransform _panelRect;        // 0x18

        // Methods
        private System.Void Start() { }
        private System.Void _SetTextureScaleByWidth() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000E
    public class RichTextInfo
    {
        // Fields
        public System.Int32 index;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public class InlineImageInfo : RichTextInfo
    {
        // Fields
        public System.String path;        // 0x18
        public System.Single width;        // 0x20
        public System.Single height;        // 0x24

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000010
    public struct RichTextTagType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIText.RichTextTagType Image;        // 0x0
        public static Beyond.UI.UIText.RichTextTagType Width;        // 0x0
        public static Beyond.UI.UIText.RichTextTagType Height;        // 0x0
        public static Beyond.UI.UIText.RichTextTagType Scale;        // 0x0

    }

    // TypeToken: 0x2000011
    public struct RichTextStyleSeq
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIText.RichTextStyleSeq NORMAL;        // 0x0
        public static Beyond.UI.UIText.RichTextStyleSeq DARK_BACKGROUND;        // 0x0
        public static Beyond.UI.UIText.RichTextStyleSeq LIGHT_BACKGROUND;        // 0x0

    }

    // TypeToken: 0x2000013
    public struct ParamValueType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIText.RichTextAnalyzer.ParamValueType None;        // 0x0
        public static Beyond.UI.UIText.RichTextAnalyzer.ParamValueType String;        // 0x0
        public static Beyond.UI.UIText.RichTextAnalyzer.ParamValueType Int;        // 0x0
        public static Beyond.UI.UIText.RichTextAnalyzer.ParamValueType Float;        // 0x0

    }

    // TypeToken: 0x2000014
    public struct RichTextTag
    {
        // Fields
        public Beyond.UI.UIText.RichTextTagType richTextTagType;        // 0x10
        public Beyond.UI.UIText.RichTextAnalyzer.ParamValueType paramValueType;        // 0x14

    }

    // TypeToken: 0x2000015
    public struct RichTextParam
    {
        // Fields
        public Beyond.UI.UIText.RichTextTagType richTextTagType;        // 0x10
        public Beyond.UI.UIText.RichTextAnalyzer.AnyTypeStruct value;        // 0x18

    }

    // TypeToken: 0x2000016
    public struct AnyTypeStruct
    {
        // Fields
        public System.Int32 intValue;        // 0x10
        public System.Single floatValue;        // 0x10
        public System.String stringValue;        // 0x10

    }

    // TypeToken: 0x2000017
    public class ProcessRichTextEntryFunc : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private Beyond.UI.UIText.RichTextInfo Invoke(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam mainParam, System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> subParams, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder) { }
        private System.IAsyncResult BeginInvoke(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam mainParam, System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> subParams, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder, System.AsyncCallback callback, System.Object object) { }
        private Beyond.UI.UIText.RichTextInfo EndInvoke(Cysharp.Text.Utf16ValueStringBuilder& stringBuilder, System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000012
    public class RichTextAnalyzer
    {
        // Fields
        private static System.Char CUSTOM_RICH_TEXT_LEFT_BRACKET;        // 0x0
        private static System.Char CUSTOM_RICH_TEXT_RIGHT_BRACKET;        // 0x0
        private static readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIText.RichTextAnalyzer.RichTextTag> s_tagToTypeDic;        // 0x0
        public static System.String FONT_SHADOW_OPENING_TAG;        // 0x0
        public static System.String FONT_SHADOW_CLOSING_TAG;        // 0x0
        public static System.String FONT_MAT_OPENING_TAG;        // 0x0
        public static System.String FONT_MAT_CLOSING_TAG;        // 0x0
        private static readonly System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> s_subParams;        // 0x8

        // Methods
        private System.String PreAnalyzeRichText(System.String text, System.Boolean needParseActionId) { }
        private System.String AnalyzeRichText(System.String text, Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc processFunc, System.Collections.Generic.List<Beyond.UI.UIText.RichTextInfo>& infos) { }
        private System.Boolean _TryParseRichTextEntry(System.ReadOnlySpan<System.Char> span, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder, Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc processFunc, Beyond.UI.UIText.RichTextInfo& richTextInfo) { }
        private System.Boolean _TryParseParam(System.ReadOnlySpan<System.Char> span, Beyond.UI.UIText.RichTextAnalyzer.RichTextParam& param) { }
        private Beyond.UI.UIText.RichTextInfo ProcessRichTextEntryFallback(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam mainParam, System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> subParams, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder) { }
        private System.Int32 GetCharacterCountWithoutRichText(System.ReadOnlySpan<System.Char> str) { }
        private System.Int32 _GetHashCode(System.ReadOnlySpan<System.Char> str) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000018
    public class HyperlinkUITextWrap
    {
        // Fields
        public Beyond.UI.UIText uiText;        // 0x10
        public System.String hyperlinkUITextGroupId;        // 0x18
        public System.Int32 order;        // 0x20
        public System.Boolean isDisplayable;        // 0x24

        // Methods
        private System.Void Clear() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public class HyperlinkUITextGroup
    {
        // Fields
        public System.Collections.Generic.HashSet<Beyond.UI.UIText.HyperlinkUITextWrap> wrapSet;        // 0x10
        public System.String groupId;        // 0x18
        public System.Int32 displayableCount;        // 0x20

        // Methods
        private System.Void Add(Beyond.UI.UIText.HyperlinkUITextWrap wrap) { }
        private System.Void Remove(Beyond.UI.UIText.HyperlinkUITextWrap wrap) { }
        private System.Void ChangeDisplayable(Beyond.UI.UIText.HyperlinkUITextWrap wrap, System.Boolean displayable) { }
        private System.Void _AddDisplayableCount() { }
        private System.Void _SubDisplayableCount() { }
        private System.Void _NotifyDisplayableChanged() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001A
    public class HyperlinkUITextManager
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,Beyond.UI.UIText.HyperlinkUITextGroup> m_hyperlinkUITextGroupMap;        // 0x10
        private Beyond.PoolCore.ObjectPool<Beyond.UI.UIText.HyperlinkUITextGroup> m_hyperlinkUITextGroupPool;        // 0x18
        private Beyond.PoolCore.ObjectPool<Beyond.UI.UIText.HyperlinkUITextWrap> m_hyperlinkUITextWrapPool;        // 0x20
        private static Beyond.UI.UIText.HyperlinkUITextManager s_instance;        // 0x0
        private static readonly System.Collections.Generic.List<Beyond.UI.UIText.HyperlinkUITextWrap> SORT_WRAP_TEMP_LIST;        // 0x8

        // Methods
        private Beyond.UI.UIText.HyperlinkUITextManager get_instance() { }
        private System.Void AddWrap(Beyond.UI.UIText uiText, System.String groupId, System.Int32 order) { }
        private System.Void RemoveWrap(Beyond.UI.UIText uiText) { }
        private System.Void ChangeWrapGroup(Beyond.UI.UIText.HyperlinkUITextWrap wrap, System.String newGroupId, System.Int32 newOrder) { }
        private System.Void ChangeWrapOrder(Beyond.UI.UIText.HyperlinkUITextWrap wrap, System.Int32 newOrder) { }
        private System.Void UpdateWrapDisplayable(Beyond.UI.UIText uiText) { }
        private System.Boolean IsGroupDisplayable(System.String groupId) { }
        private System.Collections.Generic.List<Beyond.UI.UIText> GetGroupDisplayableUIText(System.String groupId) { }
        private Beyond.UI.UIText.HyperlinkUITextGroup _GetGroup(System.String groupId, System.Boolean autoCreate) { }
        private System.Boolean _IsUITextDisplayable(Beyond.UI.UIText uiText) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001C
    public struct ImageGOInfo
    {
        // Fields
        public UnityEngine.GameObject go;        // 0x10
        public UnityEngine.RectTransform rectTransform;        // 0x18
        public UnityEngine.UI.Image image;        // 0x20

    }

    // TypeToken: 0x200001F
    public struct AnimationState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIConst.AnimationState Stop;        // 0x0
        public static Beyond.UI.UIConst.AnimationState In;        // 0x0
        public static Beyond.UI.UIConst.AnimationState Loop;        // 0x0
        public static Beyond.UI.UIConst.AnimationState Out;        // 0x0
        public static Beyond.UI.UIConst.AnimationState InEasing;        // 0x0
        public static Beyond.UI.UIConst.AnimationState Others;        // 0x0

    }

    // TypeToken: 0x2000020
    public struct CommonUISegment
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIConst.CommonUISegment InteractiveEntity;        // 0x0
        public static Beyond.UI.UIConst.CommonUISegment LevelScriptModule;        // 0x0

    }

    // TypeToken: 0x2000029
    public class MeunItemInfo
    {
        // Fields
        public Beyond.UI.UIButton button;        // 0x10
        public Beyond.UI.UIToggle toggle;        // 0x18
        public System.Boolean showIcon;        // 0x20
        public UnityEngine.Sprite sprite;        // 0x28
        public Beyond.UI.UIText text;        // 0x30
        public System.String textId;        // 0x38
        public System.String textIdForToggleOff;        // 0x40
        public System.Int32 priority;        // 0x48

        // Methods
        private System.Boolean get_isForceValid() { }
        private System.Boolean IsValid() { }
        private System.String GetText() { }
        private UnityEngine.Sprite GetSprite() { }
        private System.Void Execute() { }
        private System.String GetItemName() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002F
    public struct OverrideValidState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.CustomUIStyle.OverrideValidState None;        // 0x0
        public static Beyond.UI.CustomUIStyle.OverrideValidState ForceValid;        // 0x0
        public static Beyond.UI.CustomUIStyle.OverrideValidState ForceNotValid;        // 0x0

    }

    // TypeToken: 0x2000036
    public struct State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.FullScreenSceneBlurMarker.State OnEnable;        // 0x0
        public static Beyond.UI.FullScreenSceneBlurMarker.State OnDisable;        // 0x0
        public static Beyond.UI.FullScreenSceneBlurMarker.State OnDestroy;        // 0x0

    }

    // TypeToken: 0x200003E
    public struct ShapeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.NonDrawingGraphic.ShapeType Rectangle;        // 0x0
        public static Beyond.UI.NonDrawingGraphic.ShapeType Circle;        // 0x0

    }

    // TypeToken: 0x2000042
    public class ParallaxConfig
    {
        // Fields
        public UnityEngine.RectTransform target;        // 0x10
        public System.Single ratio;        // 0x18
        public UnityEngine.Vector2 oriPosition;        // 0x1C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000045
    public interface ICustomViewType
    {
        // Methods
        private System.Int32 get_viewType() { }

    }

    // TypeToken: 0x2000046
    public interface ICustomSpacing
    {
        // Methods
        private System.Single GetCustomSpacing() { }

    }

    // TypeToken: 0x2000047
    public interface IVirtualView : IHotfixable
    {
        // Methods
        private System.Void AttachView(UnityEngine.GameObject view) { }
        private System.Void DetachView() { }
        private UnityEngine.GameObject GetAttachedView() { }
        private System.Int32 GetViewID() { }
        private UnityEngine.GameObject GetPrefab() { }
        private System.Single GetPreferSize() { }

    }

    // TypeToken: 0x2000048
    public class VirtualView, IVirtualView, IHotfixable
    {
        // Fields
        protected UnityEngine.GameObject m_gameObj;        // 0x10

        // Methods
        private System.Boolean get_isAttached() { }
        private System.Void AttachView(UnityEngine.GameObject gameObj) { }
        private System.Void DetachView() { }
        private UnityEngine.GameObject GetAttachedView() { }
        private System.Int32 GetViewID() { }
        private System.Void OnViewAttached() { }
        private System.Void OnViewDetached() { }
        private UnityEngine.GameObject GetPrefab() { }
        private System.Single GetPreferSize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004A
    public class SimpleAdapter : UIRecycleLayoutAdapter
    {
        // Fields
        private Beyond.UI.UIRecycleLayoutSimpleHolder<TVirtualView> m_holder;        // 0x0
        private System.Collections.Generic.List<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> m_virtualViews;        // 0x0

        // Methods
        private System.Void .ctor(Beyond.UI.UIRecycleLayoutSimpleHolder<TVirtualView> holder) { }
        private System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild() { }
        private System.Void NotifyRebuild() { }
        private System.Void InsertView(System.Int32 index, TVirtualView virtualView) { }
        private System.Void AppendView(TVirtualView virtualView) { }
        private System.Void AddView(TVirtualView virtualView) { }
        private System.Void RemoveView(System.Int32 index) { }
        private System.Void RemoveAllViews(System.Boolean dontRebuild) { }
        private System.Int32 GetCount() { }
        private TVirtualView GetVirtualView(System.Int32 index) { }
        private UnityEngine.GameObject GetView(System.Int32 index) { }
        private System.Void NotifySizeChanged(TVirtualView virtualView) { }
        private System.Void NotifyAllSizeChanged() { }
        private System.Void NotifySizeChanged(System.Int32 index) { }
        private System.Void OnInit() { }
        private System.Void OnDisposed() { }

    }

    // TypeToken: 0x200004D
    public struct Direction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIRecycleLayoutGroup.Direction Vertical;        // 0x0
        public static Beyond.UI.UIRecycleLayoutGroup.Direction Horizontal;        // 0x0

    }

    // TypeToken: 0x200004E
    public struct AdaptMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIRecycleLayoutGroup.AdaptMode Normal;        // 0x0
        public static Beyond.UI.UIRecycleLayoutGroup.AdaptMode MultiPrefab;        // 0x0

    }

    // TypeToken: 0x200004F
    public interface IViewHandler
    {
        // Methods
        private Beyond.UI.UIRecycleLayoutAdapter.IVirtualView GetView(System.Int32 index) { }
        private System.Int32 GetViewCount() { }
        private System.Boolean InsertView(System.Int32 index, Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        private System.Boolean AddView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        private System.Void NotifyViewSizeChanged(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        private System.Void NotifyAllViewSizeChanged() { }
        private System.Void NotifyRebuild() { }
        private System.Boolean RemoveView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        private System.Single GetElementPosByIndex(System.Int32 index) { }
        private UnityEngine.Bounds GetElementBoundsByIndex(System.Int32 index) { }
        private Beyond.UI.UIRecycleLayoutGroup.Direction GetDirection() { }
        private System.Single GetSizeOnAxis() { }
        private System.Single GetViewportSizeOnAxis() { }
        private System.Int32 GetElementIndex(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }

    }

    // TypeToken: 0x2000050
    public struct LayoutMeta
    {
        // Fields
        public System.Single pos;        // 0x10
        public System.Single size;        // 0x14
        public System.Int32 index;        // 0x18
        public System.Single curTotalSize;        // 0x1C

    }

    // TypeToken: 0x2000051
    public class ViewPool
    {
        // Fields
        private UnityEngine.GameObject m_prefab;        // 0x10
        private UnityEngine.Transform m_container;        // 0x18
        private System.Collections.Generic.List<UnityEngine.GameObject> m_activeObjs;        // 0x20
        private System.Collections.Generic.List<UnityEngine.GameObject> m_pooledObjs;        // 0x28
        private System.Int32 <viewType>k__BackingField;        // 0x30

        // Methods
        private System.Int32 get_viewType() { }
        private System.Void set_viewType(System.Int32 value) { }
        private System.Void .ctor(System.Int32 viewType, UnityEngine.GameObject prefab, UnityEngine.Transform container) { }
        private UnityEngine.GameObject Alloc(System.Boolean& isNewlyCreated) { }
        private System.Boolean Recycle(UnityEngine.GameObject obj) { }
        private System.Void RecycleAll() { }

    }

    // TypeToken: 0x2000052
    public class ViewMgr, IHotfixable, IViewHandler
    {
        // Fields
        private Beyond.UI.UIRecycleLayoutGroup m_closure;        // 0x10
        private Beyond.ListDict<System.Int32,Beyond.UI.UIRecycleLayoutGroup.ViewPool> m_viewPools;        // 0x18
        private System.Collections.Generic.List<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> m_views;        // 0x20

        // Methods
        private System.Void .ctor(Beyond.UI.UIRecycleLayoutGroup closure) { }
        private System.Void RebuildAll(Beyond.UI.UIRecycleLayoutAdapter adapter) { }
        private System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> GetViews() { }
        private System.Void DetachView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view, UnityEngine.GameObject curView) { }
        private System.Void AttachView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        private Beyond.UI.UIRecycleLayoutAdapter.IVirtualView GetView(System.Int32 index) { }
        private System.Int32 GetViewCount() { }
        private System.Boolean InsertView(System.Int32 index, Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        private System.Boolean AddView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        private System.Boolean RemoveView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        private System.Void NotifyViewSizeChanged(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        private System.Void NotifyAllViewSizeChanged() { }
        private System.Void NotifyRebuild() { }
        private System.Single GetElementPosByIndex(System.Int32 index) { }
        private UnityEngine.Bounds GetElementBoundsByIndex(System.Int32 index) { }
        private Beyond.UI.UIRecycleLayoutGroup.Direction GetDirection() { }
        private System.Single GetSizeOnAxis() { }
        private System.Single GetViewportSizeOnAxis() { }
        private System.Int32 GetElementIndex(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        private Beyond.UI.UIRecycleLayoutGroup.ViewPool _EnsureViewPool(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        private System.Void _NotifyLayoutChanged(System.Int32 fromIndex) { }

    }

    // TypeToken: 0x2000053
    public struct Padding
    {
        // Fields
        public System.Int32 top;        // 0x10
        public System.Int32 left;        // 0x14
        public System.Int32 bottom;        // 0x18
        public System.Int32 right;        // 0x1C

    }

    // TypeToken: 0x2000054
    public class EmptyAdapter : UIRecycleLayoutAdapter
    {
        // Methods
        private System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild() { }
        private System.Void OnInit() { }
        private System.Void .ctor() { }
        private System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> <>iFixBaseProxy_GenerateViewsForRebuild() { }

    }

    // TypeToken: 0x2000056
    public class MultiVirtualView : VirtualView
    {
        // Fields
        private Beyond.UI.UIRecycleMultiHolder m_closure;        // 0x18
        public System.Single preferSize;        // 0x20
        public System.String prefabKey;        // 0x28

        // Methods
        private System.Int32 GetIndex() { }
        private System.Void .ctor(System.Single initSize, System.String key, Beyond.UI.UIRecycleMultiHolder closure) { }
        private UnityEngine.GameObject GetPrefab() { }
        private System.Single GetPreferSize() { }
        private System.Void OnViewDetached() { }
        private System.Void OnViewAttached() { }

    }

    // TypeToken: 0x2000057
    public class Config
    {
        // Fields
        public System.String key;        // 0x10
        public UnityEngine.GameObject cellTemplate;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000059
    public class SimpleVirtualView : VirtualView
    {
        // Fields
        private Beyond.UI.UIRecycleSingleHolder m_holder;        // 0x18
        public System.Single preferSize;        // 0x20

        // Methods
        private System.Int32 GetIndex() { }
        private System.Void .ctor(System.Single initSize, Beyond.UI.UIRecycleSingleHolder holder) { }
        private UnityEngine.GameObject GetPrefab() { }
        private System.Single GetPreferSize() { }
        private System.Void OnViewDetached() { }
        private System.Void OnViewAttached() { }

    }

    // TypeToken: 0x200005C
    public class CellInfo
    {
        // Fields
        public System.Int32 index;        // 0x10
        public UnityEngine.GameObject obj;        // 0x18
        public Beyond.UI.UIAnimationWrapper animationWrapper;        // 0x20
        public UnityEngine.Coroutine cor;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000061
    public class ClipHolder
    {
        // Fields
        public UnityEngine.AnimationClip clip;        // 0x10
        public System.String alias;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000064
    public class AnimationRuntime
    {
        // Fields
        public Beyond.UI.UIAnimationTween.Options option;        // 0x10
        public UnityEngine.AnimationState state;        // 0x18
        public System.Boolean isPlaying;        // 0x20

        // Methods
        private System.Single GetClipLength() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000065
    public struct FOptions, ILuaCallCSharp
    {
        // Fields
        public DG.Tweening.Ease animEase;        // 0x10

        // Methods
        private Beyond.UI.UIAnimationWrapper.FOptions GetDefault() { }

    }

    // TypeToken: 0x2000066
    public struct CachedSampleClipInfo
    {
        // Fields
        public Beyond.UI.UIAnimationWrapper.AnimationRuntime runtime;        // 0x10
        public System.Single position;        // 0x18
        public System.Boolean isDirty;        // 0x1C

        // Methods
        private System.Void .ctor(System.Boolean isDirty) { }

    }

    // TypeToken: 0x200006C
    public struct Options
    {
        // Fields
        public System.Boolean isInverse;        // 0x10
        public System.Single startPosition;        // 0x14

    }

    // TypeToken: 0x2000070
    public class TweenHandler, ITweenHandler, IHotfixable
    {
        // Fields
        private Beyond.UI.UIAnimationSwitchTween m_closure;        // 0x10
        private System.Boolean m_isIn;        // 0x18
        private System.Boolean m_pendingClear;        // 0x19
        private DG.Tweening.TweenCallback m_pendingCallback;        // 0x20
        private System.Boolean m_isComplete;        // 0x28

        // Methods
        private System.Void .ctor(Beyond.UI.UIAnimationSwitchTween closure, System.Boolean isIn) { }
        private System.Boolean IsPlaying() { }
        private System.Void KillIfNecessary() { }
        private Beyond.UI.UISwitchTween.ITweenHandler OnComplete(DG.Tweening.TweenCallback callback) { }
        private Beyond.UI.UISwitchTween.ITweenHandler SetAutoKill(System.Boolean autoKill) { }
        private System.Void _OnComplete() { }

    }

    // TypeToken: 0x2000071
    public struct Builder
    {
        // Fields
        public Beyond.UI.UIAnimationWrapper animWrapper;        // 0x10
        public System.Boolean dontDisableGameObject;        // 0x18

        // Methods
        private Beyond.UI.UIAnimationSwitchTween Build() { }

    }

    // TypeToken: 0x2000080
    public struct FWorldCanvasParams
    {
        // Fields
        public System.Single screenRatio;        // 0x10
        public UnityEngine.Vector2 screenSize;        // 0x14
        public UnityEngine.Vector2 uiRootSize;        // 0x1C
        public UnityEngine.Vector3 uiRootScale;        // 0x24

    }

    // TypeToken: 0x2000081
    public struct FScreenCanvasParams
    {
        // Fields
        public System.Single screenRatio;        // 0x10
        public UnityEngine.Vector2 screenSize;        // 0x14
        public Beyond.UI.CanvasMatchMode matchMode;        // 0x1C
        public System.Single matchWidthOrHeight;        // 0x20

    }

    // TypeToken: 0x2000083
    public struct CommonParams
    {
        // Fields
        public System.Single alpha;        // 0x10
        public System.Single duration;        // 0x14
        public System.Boolean ignoreTimeScale;        // 0x18
        public UnityEngine.Color targetColor;        // 0x1C
        public System.Boolean useAlpha;        // 0x2C
        public System.Boolean useRGB;        // 0x2D
        public System.Boolean isStaticColorOpt;        // 0x2E

    }

    // TypeToken: 0x2000084
    public class GraphicOpt : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000085
    public struct DynEle
    {
        // Fields
        public System.String groupId;        // 0x10
        public UnityEngine.UI.Graphic graphic;        // 0x18
        public System.Boolean useStaticColor;        // 0x20

    }

    // TypeToken: 0x2000089
    public struct LayoutType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UICustomLayoutElement.LayoutType None;        // 0x0
        public static Beyond.UI.UICustomLayoutElement.LayoutType LeftToRight;        // 0x0

    }

    // TypeToken: 0x200008A
    public class LayoutData
    {
        // Fields
        public System.Int32 verNum;        // 0x10
        public System.Single scale;        // 0x14
        public System.Single alpha;        // 0x18
        public UnityEngine.Vector2 position;        // 0x1C
        public System.Int32 layoutType;        // 0x24

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008D
    public struct UpdateMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIDialogText.UpdateMode Auto;        // 0x0
        public static Beyond.UI.UIDialogText.UpdateMode Manual;        // 0x0

    }

    // TypeToken: 0x20000A5
    public struct WrapMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIGridLayoutNaviWrapper.WrapMode NaviGroup;        // 0x0
        public static Beyond.UI.UIGridLayoutNaviWrapper.WrapMode ScrollRect;        // 0x0
        public static Beyond.UI.UIGridLayoutNaviWrapper.WrapMode ScrollList;        // 0x0
        public static Beyond.UI.UIGridLayoutNaviWrapper.WrapMode LayoutNaviWrapper;        // 0x0

    }

    // TypeToken: 0x20000A7
    public class Param
    {
        // Fields
        public System.Single maxAngle;        // 0x10
        public UnityEngine.AnimationCurve valueCurve;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B0
    public struct State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIInertiaViewPager.State IDLE;        // 0x0
        public static Beyond.UI.UIInertiaViewPager.State DRAGING;        // 0x0
        public static Beyond.UI.UIInertiaViewPager.State INERTIA;        // 0x0
        public static Beyond.UI.UIInertiaViewPager.State ALIGNING;        // 0x0

    }

    // TypeToken: 0x20000B1
    public interface IScrollHandler : IHotfixable
    {
        // Methods
        private System.Void OnClear() { }
        private System.Single get_velocity() { }
        private System.Boolean get_isDragging() { }
        private System.Single get_scrollProgress() { }
        private System.Void set_scrollProgress(System.Single value) { }
        private System.Void StopMoving() { }

    }

    // TypeToken: 0x20000B2
    public class CustomScrollHandler, IScrollHandler, IHotfixable
    {
        // Fields
        private System.Boolean m_isScrolling;        // 0x10
        private Beyond.UI.UIScrollRect m_scrollRect;        // 0x18

        // Methods
        private System.Void .ctor(Beyond.UI.UIScrollRect scrollRect) { }
        private System.Void OnClear() { }
        private System.Single get_velocity() { }
        private System.Single get_scrollProgress() { }
        private System.Void set_scrollProgress(System.Single value) { }
        private System.Boolean get_isDragging() { }
        private System.Void StopMoving() { }
        private System.Void _OnScrollBegin(UnityEngine.Vector2 delta) { }
        private System.Void _OnScrollEnd(UnityEngine.Vector2 delta) { }

    }

    // TypeToken: 0x20000B3
    public struct EmptyScrollHandler, IScrollHandler, IHotfixable
    {
        // Methods
        private System.Single get_velocity() { }
        private System.Boolean get_isDragging() { }
        private System.Single get_scrollProgress() { }
        private System.Void set_scrollProgress(System.Single value) { }
        private System.Void StopMoving() { }
        private System.Void OnClear() { }

    }

    // TypeToken: 0x20000B4
    public struct FlingToNext
    {
        // Fields
        public System.Boolean enable;        // 0x10
        public System.Single minSpd;        // 0x14
        public System.Single maxSpd;        // 0x18

    }

    // TypeToken: 0x20000B5
    public struct ScrollOptions
    {
        // Fields
        public Beyond.UI.UIInertiaViewPager.FlingToNext flingToNext;        // 0x10

    }

    // TypeToken: 0x20000B6
    public class DragContext
    {
        // Fields
        public System.Single startPos;        // 0x10

        // Methods
        private System.Void BeginDrag(Beyond.UI.UIInertiaViewPager pager) { }
        private Beyond.UI.UIInertiaViewPager.State EndDrag(Beyond.UI.UIInertiaViewPager pager) { }
        private System.Boolean _TryFlingToNext(Beyond.UI.UIInertiaViewPager pager) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B7
    public struct BlockerDir
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIInertiaViewPager.BlockerDir UPWARD;        // 0x0
        public static Beyond.UI.UIInertiaViewPager.BlockerDir DOWNNWARD;        // 0x0
        public static Beyond.UI.UIInertiaViewPager.BlockerDir BOTH;        // 0x0

    }

    // TypeToken: 0x20000B8
    public struct InertiaBlocker, IHotfixable
    {
        // Fields
        public Beyond.UI.UIInertiaViewPager.BlockerDir dir;        // 0x10
        public System.Int32 index;        // 0x14

        // Methods
        private System.Boolean IsDirMatch(System.Single vec) { }

    }

    // TypeToken: 0x20000B9
    public class BlockerManager, IHotfixable
    {
        // Fields
        private static System.Single INERTIA_BIAS;        // 0x0
        private System.Collections.Generic.List<Beyond.UI.UIInertiaViewPager.InertiaBlocker> m_inertiaBlockers;        // 0x10
        private System.Single m_lastIndex;        // 0x18
        private System.Boolean <isInertiaing>k__BackingField;        // 0x1C

        // Methods
        private System.Boolean get_isInertiaing() { }
        private System.Void set_isInertiaing(System.Boolean value) { }
        private System.Void Init(System.Int32 pageCount, System.Collections.Generic.List<System.Int32> blockFrames) { }
        private System.Void StartInertia(System.Single fromIndex) { }
        private System.Boolean HitInertiaBlock(System.Single curIndex, System.Single& preferTo) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BB
    public struct Timing
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIInertiaViewPager.ScrollEffectConfig.Timing HALF_VALUE;        // 0x0
        public static Beyond.UI.UIInertiaViewPager.ScrollEffectConfig.Timing FULL_VALUE;        // 0x0

    }

    // TypeToken: 0x20000BA
    public struct ScrollEffectConfig
    {
        // Fields
        public System.Action onScrollToItem;        // 0x10
        public System.Action onAlignedToItem;        // 0x18
        public System.Single minScrollInterval;        // 0x20
        public Beyond.UI.UIInertiaViewPager.ScrollEffectConfig.Timing timing;        // 0x24

        // Methods
        private System.Boolean IsEmpty() { }

    }

    // TypeToken: 0x20000BC
    public class ScrollEffectTrigger, IHotfixable
    {
        // Fields
        private static System.Single DFT_MIN_INTERVAL;        // 0x0
        private System.Boolean m_isValid;        // 0x10
        private Beyond.UI.UIInertiaViewPager.ScrollEffectConfig m_config;        // 0x18
        private System.Int32 m_lastFocusIndex;        // 0x30
        private System.Single m_curTime;        // 0x34
        private System.Single m_lastScrollTime;        // 0x38
        private System.Boolean m_hasScrolled;        // 0x3C

        // Methods
        private System.Void .ctor(Beyond.UI.UIInertiaViewPager.ScrollEffectConfig config) { }
        private System.Void NotifyScrolling(System.Single curIndex, System.Single deltaTime) { }
        private System.Void MarkHasScrolled() { }
        private System.Void NotifyAlignFinish() { }
        private System.Void Reset(System.Int32 curIndex) { }

    }

    // TypeToken: 0x20000C1
    public interface IAction
    {
        // Methods
        private System.Void DoAction() { }

    }

    // TypeToken: 0x20000C6
    public struct GetCellSizeMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UINonUnifiedScrollList.GetCellSizeMode ByGetCellSizeFunc;        // 0x0
        public static Beyond.UI.UINonUnifiedScrollList.GetCellSizeMode ByLayoutGroup;        // 0x0
        public static Beyond.UI.UINonUnifiedScrollList.GetCellSizeMode GetAfterCellCreated;        // 0x0

    }

    // TypeToken: 0x20000D0
    public class Cell
    {
        // Fields
        public UnityEngine.GameObject gameObject;        // 0x10
        public UnityEngine.RectTransform rectTransform;        // 0x18
        public UnityEngine.GameObject realGameObject;        // 0x20

        // Methods
        private System.Void SetSelect(System.Boolean select) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D4
    public struct AutoLayoutWhenFewType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIScrollList.AutoLayoutWhenFewType Center;        // 0x0
        public static Beyond.UI.UIScrollList.AutoLayoutWhenFewType LeftOrTop;        // 0x0
        public static Beyond.UI.UIScrollList.AutoLayoutWhenFewType RightOrBottom;        // 0x0

    }

    // TypeToken: 0x20000D5
    public class Cell
    {
        // Fields
        public UnityEngine.GameObject gameObject;        // 0x10
        public UnityEngine.RectTransform rectTransform;        // 0x18
        public Beyond.UI.UIAnimationWrapper animationWrapper;        // 0x20
        public Beyond.UI.IUIFoldoutComp UIFoldoutComp;        // 0x28
        public System.Boolean canCache;        // 0x30
        public UnityEngine.GameObject realGameObject;        // 0x38

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D6
    public struct MoveTipsType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIScrollList.MoveTipsType None;        // 0x0
        public static Beyond.UI.UIScrollList.MoveTipsType Higher;        // 0x0
        public static Beyond.UI.UIScrollList.MoveTipsType Lower;        // 0x0
        public static Beyond.UI.UIScrollList.MoveTipsType Both;        // 0x0

    }

    // TypeToken: 0x20000D7
    public struct Padding
    {
        // Fields
        public System.Single top;        // 0x10
        public System.Single left;        // 0x14
        public System.Single right;        // 0x18
        public System.Single bottom;        // 0x1C

    }

    // TypeToken: 0x20000D8
    public struct ScrollAlignType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIScrollList.ScrollAlignType Center;        // 0x0
        public static Beyond.UI.UIScrollList.ScrollAlignType Top;        // 0x0
        public static Beyond.UI.UIScrollList.ScrollAlignType Bottom;        // 0x0

    }

    // TypeToken: 0x20000D9
    public interface IScrollListNaviWrapper
    {
        // Methods
        private System.Boolean TryWrapNavigate(UnityEngine.UI.NaviDirection dir) { }

    }

    // TypeToken: 0x20000DC
    public struct MoveTipsType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIScrollRect.MoveTipsType None;        // 0x0
        public static Beyond.UI.UIScrollRect.MoveTipsType Higher;        // 0x0
        public static Beyond.UI.UIScrollRect.MoveTipsType Lower;        // 0x0
        public static Beyond.UI.UIScrollRect.MoveTipsType Both;        // 0x0

    }

    // TypeToken: 0x20000DF
    public struct ERedDotState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState DISABLED;        // 0x0
        public static Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState NEW;        // 0x0
        public static Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState NORMAL;        // 0x0

    }

    // TypeToken: 0x20000E0
    public struct ERedDotDir
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDir UP;        // 0x0
        public static Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDir RIGHT;        // 0x0
        public static Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDir DOWN;        // 0x0
        public static Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDir LEFT;        // 0x0

    }

    // TypeToken: 0x20000E1
    public class RedDotInfo
    {
        // Fields
        public readonly UnityEngine.GameObject redDotRoot;        // 0x10
        public readonly UnityEngine.GameObject redDotNormal;        // 0x18
        public readonly UnityEngine.GameObject redDotNew;        // 0x20

        // Methods
        private Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState get_state() { }
        private UnityEngine.Vector2 get_normalPos() { }
        private UnityEngine.Vector2 get_newPos() { }
        private UnityEngine.Rect get_normalRect() { }
        private UnityEngine.Rect get_newRect() { }
        private System.Void .ctor(UnityEngine.GameObject redDotRoot, UnityEngine.GameObject redDotNormal, UnityEngine.GameObject redDotNew) { }

    }

    // TypeToken: 0x20000E3
    public struct ScrollMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIScrollText.ScrollMode Mesh;        // 0x0
        public static Beyond.UI.UIScrollText.ScrollMode AnchoredPosition;        // 0x0

    }

    // TypeToken: 0x20000E4
    public struct ScrollState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIScrollText.ScrollState Scrolling;        // 0x0
        public static Beyond.UI.UIScrollText.ScrollState Idle;        // 0x0
        public static Beyond.UI.UIScrollText.ScrollState FadingOut;        // 0x0
        public static Beyond.UI.UIScrollText.ScrollState FadingIn;        // 0x0

    }

    // TypeToken: 0x20000E5
    public interface IAlphaHandler
    {
        // Methods
        private System.Void HandleAlpha(System.Single alpha) { }

    }

    // TypeToken: 0x20000E6
    public class CanvasGroupHandler, IAlphaHandler
    {
        // Fields
        private UnityEngine.CanvasGroup m_canvasGroup;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.CanvasGroup canvasGroup) { }
        private System.Void HandleAlpha(System.Single alpha) { }

    }

    // TypeToken: 0x20000E7
    public interface IScrollHandler
    {
        // Methods
        private System.Void ApplyScroll(System.Single scrollOffset) { }
        private System.Void ResetScroll() { }
        private System.Void UpdateScrollStatus(System.Boolean isScroll) { }

    }

    // TypeToken: 0x20000E8
    public class PositionScrollHandler, IScrollHandler
    {
        // Fields
        private Beyond.UI.UIScrollText m_closure;        // 0x10

        // Methods
        private System.Void .ctor(Beyond.UI.UIScrollText scrollText) { }
        private System.Void ApplyScroll(System.Single scrollOffset) { }
        private System.Void ResetScroll() { }
        private System.Void UpdateScrollStatus(System.Boolean isScroll) { }

    }

    // TypeToken: 0x20000E9
    public class MeshScrollHandler, IScrollHandler
    {
        // Fields
        private Beyond.UI.UIScrollText m_closure;        // 0x10

        // Methods
        private System.Void .ctor(Beyond.UI.UIScrollText uiScrollText) { }
        private System.Void ApplyScroll(System.Single scrollOffset) { }
        private System.Void ResetScroll() { }
        private System.Void UpdateScrollStatus(System.Boolean isScroll) { }
        private System.Void _ApplyScroll(System.Single scrollOffset) { }
        private System.Void _UpdateMeshClipping(TMPro.TMP_TextInfo textInfo) { }

    }

    // TypeToken: 0x20000EB
    public struct FocusBlockMessageData
    {
        // Fields
        public System.Int32 panelId;        // 0x10
        public System.Boolean isGroup;        // 0x14
        public System.Int32 id;        // 0x18
        public UnityEngine.RectTransform rectTransform;        // 0x20
        public System.Boolean noHighlight;        // 0x28
        public System.Boolean useNormalFrame;        // 0x29
        public System.Boolean useDarkFrame;        // 0x2A
        public System.Int32 panelSortingOrder;        // 0x2C

    }

    // TypeToken: 0x20000F2
    public class StateInfo
    {
        // Fields
        public System.String name;        // 0x10
        public System.Collections.Generic.List<UnityEngine.GameObject> activeObjects;        // 0x18

        // Methods
        private System.String ToString() { }
        private System.Void .ctor() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x20000F6
    public struct SlicedSpriteParams
    {
        // Fields
        public System.Int32 slicedEnabled;        // 0x10
        public UnityEngine.Vector2 inner_PosMin;        // 0x14
        public UnityEngine.Vector2 inner_PosMax;        // 0x1C
        public UnityEngine.Vector2 inner_UVMin;        // 0x24
        public UnityEngine.Vector2 inner_UVMax;        // 0x2C

        // Methods
        private System.Void .ctor(System.Int32 slicedEnabled, UnityEngine.Vector2 inner_PosMin, UnityEngine.Vector2 inner_PosMax, UnityEngine.Vector2 inner_UVMin, UnityEngine.Vector2 inner_UVMax) { }

    }

    // TypeToken: 0x20000F8
    public struct UIType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UISoftMaskable.UIType Default;        // 0x0
        public static Beyond.UI.UISoftMaskable.UIType Text;        // 0x0
        public static Beyond.UI.UISoftMaskable.UIType UIVFX;        // 0x0

    }

    // TypeToken: 0x20000F9
    public struct TestLine
    {
        // Fields
        public UnityEngine.UIVertex v0;        // 0x10
        public UnityEngine.UIVertex v1;        // 0x7C
        public UnityEngine.Vector2 p0;        // 0xE8
        public UnityEngine.Vector2 p1;        // 0xF0
        public UnityEngine.Vector2 t0;        // 0xF8
        public UnityEngine.Vector2 t1;        // 0x100
        public UnityEngine.Vector2 dir;        // 0x108
        public UnityEngine.Vector2 normal;        // 0x110

    }

    // TypeToken: 0x20000FB
    public struct RenderType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UISortingOrder.RenderType Effect;        // 0x0
        public static Beyond.UI.UISortingOrder.RenderType UI;        // 0x0

    }

    // TypeToken: 0x20000FE
    public class StateConfig
    {
        // Fields
        public Beyond.UI.UIState.UIStateController stateController;        // 0x10
        public System.String stateName;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FF
    public class StyleConfig
    {
        // Fields
        public Beyond.UI.UIStyleInputValidTypeMask inputValidType;        // 0x10
        public System.Collections.Generic.List<Beyond.UI.UIStyleByState.StateConfig> stateConfigs;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000108
    public class ScrollListLayoutInfo
    {
        // Fields
        public UnityEngine.UI.VerticalLayoutGroup layoutGroup;        // 0x10
        public UnityEngine.RectTransform layoutRectTransform;        // 0x18
        public UnityEngine.UI.LayoutElement cell;        // 0x20

        // Methods
        private System.Single get_cellHeight() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010F
    public struct MotionLevel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.MobileMotionManager.MotionLevel NONE;        // 0x0
        public static Beyond.UI.MobileMotionManager.MotionLevel LOW;        // 0x0
        public static Beyond.UI.MobileMotionManager.MotionLevel MEDIUM;        // 0x0
        public static Beyond.UI.MobileMotionManager.MotionLevel HIGH;        // 0x0

    }

    // TypeToken: 0x2000112
    public class FontAssetRef
    {
        // Fields
        public Beyond.I18n.I18nFontSearchData.FontAssetInfo fontAssetInfo;        // 0x10
        private System.Collections.Generic.HashSet<TMPro.TMP_Text> m_refTexts;        // 0x18
        private Beyond.Resource.FAssetProxyHandle m_assetHandle;        // 0x20
        private TMPro.TMP_FontAsset m_fontAsset;        // 0x38

        // Methods
        private TMPro.TMP_FontAsset GetFontAsset(TMPro.TMP_Text refText) { }
        private System.Void RemoveRefText(TMPro.TMP_Text refText) { }
        private System.Void Dispose() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000114
    public struct FLerpByTime
    {
        // Fields
        public static Beyond.UI.TweenUtils.FLerpByTime EMPTY;        // 0x0
        private System.Boolean <isEmpty>k__BackingField;        // 0x10
        private Beyond.FScaledStopwatch m_timer;        // 0x18
        public System.Single startValue;        // 0x30
        public System.Single endValue;        // 0x34
        public System.Single duration;        // 0x38

        // Methods
        private System.Boolean get_isEmpty() { }
        private System.Void set_isEmpty(System.Boolean value) { }
        private System.Void Start(Beyond.ITickOwner timeScaleProvider) { }
        private System.Single GetValue(System.Boolean& isTweenFinished) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000118
    public struct FOptions
    {
        // Fields
        public TComp cellTemplate;        // 0x0
        public UnityEngine.Transform parent;        // 0x0
        public System.Action<TComp> onItemCreated;        // 0x0

    }

    // TypeToken: 0x2000119
    public class ItemWrapper
    {
        // Fields
        public TComp comp;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011E
    public struct Options
    {
        // Fields
        private System.Action <onShown>k__BackingField;        // 0x10
        private System.Action <onHiden>k__BackingField;        // 0x18

        // Methods
        private System.Action get_onShown() { }
        private System.Void set_onShown(System.Action value) { }
        private System.Action get_onHiden() { }
        private System.Void set_onHiden(System.Action value) { }

    }

    // TypeToken: 0x200011F
    public struct TweenContext
    {
        // Fields
        public System.Single lastStopPos;        // 0x10

        // Methods
        private System.Boolean IsInterapted() { }
        private System.Void OnReset() { }
        private System.Void OnTweenStop(Beyond.UI.UISwitchTween.ITweenProgress tweenProgress) { }

    }

    // TypeToken: 0x2000120
    public interface ITweenHandler : IHotfixable
    {
        // Methods
        private Beyond.UI.UISwitchTween.ITweenHandler SetAutoKill(System.Boolean autoKill) { }
        private Beyond.UI.UISwitchTween.ITweenHandler OnComplete(DG.Tweening.TweenCallback callback) { }
        private System.Boolean IsPlaying() { }
        private System.Void KillIfNecessary() { }

    }

    // TypeToken: 0x2000121
    public interface ITweenProgress : IHotfixable
    {
        // Methods
        private System.Single GetCurrPos() { }

    }

    // TypeToken: 0x2000122
    public class TweenWrapper, ITweenHandler, IHotfixable
    {
        // Fields
        private DG.Tweening.Tween m_tween;        // 0x10

        // Methods
        private System.Void .ctor(DG.Tweening.Tween tween) { }
        private System.Boolean IsActive() { }
        private System.Boolean IsPlaying() { }
        private System.Void KillIfNecessary() { }
        private Beyond.UI.UISwitchTween.ITweenHandler OnComplete(DG.Tweening.TweenCallback callback) { }
        private Beyond.UI.UISwitchTween.ITweenHandler SetAutoKill(System.Boolean autoKill) { }

    }

    // TypeToken: 0x2000125
    public struct Durations
    {
        // Fields
        public System.Single show;        // 0x10
        public System.Single showDelay;        // 0x14
        public System.Single hide;        // 0x18
        public System.Single hideDelay;        // 0x1C

        // Methods
        private System.Single GetShowDuration(System.Single defaultDuration) { }
        private System.Single GetHideDuration(System.Single defaultDuration) { }

    }

    // TypeToken: 0x2000126
    public struct Builder
    {
        // Fields
        public UnityEngine.CanvasGroup alphaHandler;        // 0x10
        public System.Boolean useTimeScale;        // 0x18
        public System.Boolean dontDisableGameObject;        // 0x19
        public System.Boolean controlBlockRaycast;        // 0x1A
        public System.Single duration;        // 0x1C
        public Beyond.UI.FadeSwitchTween.Durations complexDuration;        // 0x20

        // Methods
        private Beyond.UI.FadeSwitchTween Build() { }

    }

    // TypeToken: 0x2000128
    public class TweenHandler, ITweenHandler, IHotfixable
    {
        // Fields
        private DG.Tweening.Tween m_alphaTweener;        // 0x10
        private DG.Tweening.Tween m_posTweener;        // 0x18

        // Methods
        private System.Void .ctor(DG.Tweening.Tween alpha, DG.Tweening.Tween pos) { }
        private System.Boolean IsPlaying() { }
        private System.Void KillIfNecessary() { }
        private Beyond.UI.UISwitchTween.ITweenHandler OnComplete(DG.Tweening.TweenCallback callback) { }
        private Beyond.UI.UISwitchTween.ITweenHandler SetAutoKill(System.Boolean autoKill) { }

    }

    // TypeToken: 0x200012A
    public struct UIAtlasProcessStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessStatus Invalid;        // 0x0
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessStatus InsertWaiting;        // 0x0
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessStatus InsertDone;        // 0x0

    }

    // TypeToken: 0x200012B
    public struct UIAtlasProcessFailureCause
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause NoFailure;        // 0x0
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseImageHasNullMainTexture;        // 0x0
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseImageHasNullSprite;        // 0x0
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseTextureWidthExceedLimit;        // 0x0
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseTextureHeightExceedLimit;        // 0x0
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseTextureASTCNotSupportedUnderEditor;        // 0x0
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureLevelInfo;        // 0x0
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseSpriteHasNonQuadMesh;        // 0x0
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseSpriteHasAssociatedAlphaSplitTexture;        // 0x0
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureLevelWarning;        // 0x0
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseAtlasTextureHasNoSpaceLeft;        // 0x0
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseSpriteRectHasNoPadding;        // 0x0
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureLevelError;        // 0x0
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseTextureFormatNotCompatible;        // 0x0
        public static Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause FailureCauseTextureSizeNotAlignedForCopyTexture;        // 0x0

    }

    // TypeToken: 0x200012C
    public struct UIAtlasHandle
    {
        // Fields
        public Beyond.UI.UIAtlasManager.UIAtlasProcessStatus status;        // 0x10
        public Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause failureCause;        // 0x14
        public System.Int32 panelLevel;        // 0x18
        public System.Int32 atlasIndex;        // 0x1C
        public UnityEngine.RectInt atlasRect;        // 0x20
        public System.Int32 textureId;        // 0x30

        // Methods
        private System.Void .ctor(Beyond.UI.UIAtlasManager.UIAtlasProcessStatus status, Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause failureCause, System.Int32 panelLevel, System.Int32 atlasIndex, UnityEngine.RectInt atlasRect, System.Int32 textureId) { }
        private System.Boolean IsValid() { }
        private Beyond.UI.UIAtlasManager.UIAtlasHandle CreateInvalidHandle(Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause cause) { }

    }

    // TypeToken: 0x200012E
    public struct TextureRefHandle
    {
        // Fields
        public System.Int32 refCount;        // 0x10
        public UnityEngine.RectInt rect;        // 0x14

        // Methods
        private System.Void .ctor(System.Int32 refCount, UnityEngine.RectInt rect) { }

    }

    // TypeToken: 0x200012D
    public class UIAtlasPage
    {
        // Fields
        private readonly UnityEngine.Texture2D <pageTexture>k__BackingField;        // 0x10
        private readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIAtlasManager.UIAtlasPage.TextureRefHandle> <textureRefDict>k__BackingField;        // 0x18
        private readonly HG.Rendering.Runtime.AtlasMaxRect <rectBinPack>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.Int32 panelDepth, System.Int32 index, UnityEngine.Experimental.Rendering.GraphicsFormat atlasFormat) { }
        private System.Int32 get_maxFreeRectWidth() { }
        private System.Int32 get_maxFreeRectHeight() { }
        private UnityEngine.Texture2D get_pageTexture() { }
        private System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIAtlasManager.UIAtlasPage.TextureRefHandle> get_textureRefDict() { }
        private HG.Rendering.Runtime.AtlasMaxRect get_rectBinPack() { }
        private UnityEngine.RectInt InsertRect(System.Int32 width, System.Int32 height) { }
        private System.Void CopyIntoAtlas(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture texture, UnityEngine.RectInt& rect) { }
        private System.Void InsertRects(System.Collections.Generic.List<UnityEngine.RectInt> rects, System.Collections.Generic.List<UnityEngine.RectInt> dst) { }
        private System.Void FreeRect(UnityEngine.RectInt& rect) { }
        private System.Void FreeRects(System.Collections.Generic.List<UnityEngine.RectInt>& rects) { }

    }

    // TypeToken: 0x2000153
    public class ShaderIDs
    {
        // Fields
        private static readonly System.Int32 CANVAS_OBJECT_TO_WORLD_MATRIX;        // 0x0
        private static readonly System.Int32 VAT_TEX;        // 0x4
        private static readonly System.Int32 MAIN_TEX;        // 0x8
        private static readonly System.Int32 SPRITE_TEX;        // 0xC

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000156
    public struct BufferInternalNode
    {
        // Fields
        public Beyond.UI.GPUI.GPUIHandle handle;        // 0x10
        public System.Int32 startIndex;        // 0x18
        public System.Int32 previousLength;        // 0x1C
        public System.Int32 sortingOrder;        // 0x20

    }

    // TypeToken: 0x200015C
    public struct CharOffsetData
    {
        // Fields
        public System.Single scale;        // 0x0
        public System.Single xAdvance;        // 0x0
        public System.Single xOffset;        // 0x0
        public System.Single yOffset;        // 0x0
        public System.Int32 prefabIndex;        // 0x0

    }

    // TypeToken: 0x200015E
    public struct __StaticArrayInitTypeSize=24
    {
    }

namespace Beyond.Gameplay.UI
{

    // TypeToken: 0x200000B
    public class UIScrollCellCircleEffect : TickableUIMono
    {
        // Fields
        private UnityEngine.Transform _target;        // 0x68
        private System.Single _radius;        // 0x70
        private UnityEngine.Transform _effectNode;        // 0x78
        private System.Boolean _faceToUICamera;        // 0x80
        private System.Boolean _alwaysFaceToCamera;        // 0x81
        private UnityEngine.Vector3 m_lastPosition;        // 0x84
        private Beyond.UI.LuaPanel m_panel;        // 0x90
        private UnityEngine.Transform <lookAtCamera>k__BackingField;        // 0x98
        private System.Boolean m_left;        // 0xA0

        // Methods
        private Beyond.TickType get_tickOption() { }
        private Beyond.UI.LuaPanel get_panel() { }
        private UnityEngine.Transform get_lookAtCamera() { }
        private System.Void set_lookAtCamera(UnityEngine.Transform value) { }
        private System.Void _InitState() { }
        private System.Void _UpdatePos() { }
        private System.Void _UpdateLookAtCamera() { }
        private System.Void SetLookAtCamera(UnityEngine.Transform faceCamera, System.Boolean update) { }
        private System.Void OnEnable() { }
        private System.Void Start() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void ForceUpdate() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x200000C
    public class UIScrollCellSlantEffect : TickableUIMono
    {
        // Fields
        private System.Single _topY;        // 0x68
        private System.Single _bottomY;        // 0x6C
        private System.Single _leftX;        // 0x70
        private System.Single _maxWidth;        // 0x74
        private UnityEngine.AnimationCurve _curve;        // 0x78
        private UnityEngine.Transform[] _cells;        // 0x80

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

}

namespace Beyond.PoolCore
{

    // TypeToken: 0x2000005
    public class ListPoolInitializer_UI_Beyond
    {
        // Fields
        private static System.Boolean s_initialized;        // 0x0

        // Methods
        private System.Void InitializeAtRuntime() { }
        private System.Void Initialize() { }

    }

}

namespace Beyond.Scripts.UI.Tools
{

    // TypeToken: 0x200000A
    public class UIGridLayoutElement : MonoBehaviour, ILayoutElement
    {
        // Fields
        private UnityEngine.UI.GridLayoutGroup m_gridLayoutGroup;        // 0x18

        // Methods
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Single get_minWidth() { }
        private System.Single get_preferredWidth() { }
        private System.Single get_flexibleWidth() { }
        private System.Single get_minHeight() { }
        private System.Single get_preferredHeight() { }
        private System.Single get_flexibleHeight() { }
        private System.Int32 get_layoutPriority() { }
        private System.Single _GetPreferredSize(System.Boolean widthOrHeight) { }
        private System.Void .ctor() { }

    }

}

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000006
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class ECSComponentAttribute : Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;        // 0x10
        public System.Boolean isTag;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public class AnimatorBlackboardAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class DataNAttribute : Attribute
    {
        // Fields
        public System.Int32 capacity;        // 0x10
        public System.Int32 tSize;        // 0x14
        public System.Boolean ring;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

}

namespace Beyond.UI
{

    // TypeToken: 0x200000D
    public class UIText : TextMeshProUGUI, IPointerClickHandler, IEventSystemHandler, IUIClearable, ILuaCallCSharp, ISerializationCallbackReceiver, IPointerEnterHandler, IPointerExitHandler
    {
        // Fields
        public Beyond.UI.UIText.RichTextStyleSeq richTextStyleSeq;        // 0xBC8
        private System.Boolean m_textHasHyperlink;        // 0xBCC
        private static readonly System.Text.RegularExpressions.Regex RICH_TEXT_REGEX;        // 0x0
        private static readonly System.Text.RegularExpressions.Regex HYPERLINK_TEXT_REGEX;        // 0x8
        private static readonly System.Text.RegularExpressions.Regex PHONETIC_REGEX;        // 0x10
        private System.Boolean _loadByCode;        // 0xBCD
        private System.String _textId;        // 0xBD0
        private System.Boolean _devOnly;        // 0xBD8
        private System.Int32 _externalStaticWidth;        // 0xBDC
        private System.Int32 _externalStaticHeight;        // 0xBE0
        private System.Boolean m_firstSetByCode;        // 0xBE4
        private static readonly System.Collections.Generic.HashSet<Beyond.GEnums.EnvLang> s_forceLeftAlignLanguage;        // 0x18
        private System.Collections.Generic.List<Beyond.UI.UIText.RichTextInfo> m_richTextInfos;        // 0xBE8
        private Beyond.TickFunction m_updateFunction;        // 0xBF0
        private Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc m_processRichTextEntryFunc;        // 0xBF8
        public UnityEngine.Events.UnityEvent<System.String> onClickLink;        // 0xC00
        public UnityEngine.Events.UnityEvent<System.String,System.Boolean> onHoverLinkChange;        // 0xC08
        private System.Boolean m_isPointerInside;        // 0xC10
        private System.String m_curHoverLinkId;        // 0xC18
        private System.Collections.Generic.List<System.String> m_linkList;        // 0xC20
        private System.Boolean m_linkShrunk;        // 0xC28
        private System.String _hyperlinkUITextGroupId;        // 0xC30
        private System.Int32 _hyperlinkUITextOrder;        // 0xC38
        private Beyond.UI.UIText.HyperlinkUITextWrap m_hyperlinkUITextWrap;        // 0xC40
        private Beyond.UI.LuaPanel m_panel;        // 0xC48
        public System.Int32 sourceCNFontId;        // 0xC50
        private TMPro.TMP_FontAsset m_i18nFontAsset;        // 0xC58
        private static System.Text.StringBuilder s_stringBuilder;        // 0x20
        private readonly System.Collections.Generic.Queue<UnityEngine.GameObject> m_inlineImagePool;        // 0xC60
        private readonly System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIText.ImageGOInfo> m_indexToImageGo;        // 0xC68
        private static System.String INLINE_IMAGE_FOLDER_PATH;        // 0x0
        private static System.String KEY_HINT_ICON_COMMON_FOLDER;        // 0x0
        private readonly System.Collections.Generic.Dictionary<System.String,Beyond.Resource.FAssetProxyHandle> m_imageCache;        // 0xC70
        private readonly System.Collections.Generic.Dictionary<System.Int32,System.Boolean> m_delayedActiveChangeImageGOIndexes;        // 0xC78

        // Methods
        private System.Void SetAndResolveTextStyle(System.String targetText) { }
        private System.String GetPhoneticText(Beyond.GEnums.PhoneticType phoneticType, System.String id) { }
        private System.Void SetPhoneticText(Beyond.GEnums.PhoneticType phoneticType, System.String id) { }
        private System.String _ResolveTextStyle(System.String text, System.Int32 richSeqIndex, System.Boolean& hasLink) { }
        private System.String get_textId() { }
        private System.Void OnEnvLangChanged(Beyond.GEnums.EnvLang lang) { }
        private System.String get_text() { }
        private System.Void set_text(System.String value) { }
        private System.Void _CreateUpdateFunction() { }
        private System.Void _ReleaseUpdateFunction() { }
        private System.Void ClearMesh() { }
        private System.Void RefreshPopulateText() { }
        private UnityEngine.Material LoadMaterial(System.String materialName) { }
        private System.Void OnDestroy() { }
        private System.Void Awake() { }
        private TMPro.TMP_FontAsset GetFontAsset() { }
        private System.Void _GenerateRuntimeText() { }
        private System.Void _ProcessRichTextInfo() { }
        private System.Void _OnPreRenderText(TMPro.TMP_TextInfo textInfo) { }
        private Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc get_processRichTextEntryFunc() { }
        private Beyond.UI.UIText.RichTextInfo _ProcessRichTextEntry(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam mainParam, System.Collections.Generic.List<Beyond.UI.UIText.RichTextAnalyzer.RichTextParam> subParams, Cysharp.Text.Utf16ValueStringBuilder& stringBuilder) { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void _UpdateTick(System.Single deltaTime) { }
        private System.Void ShrinkLinkTags() { }
        private System.Boolean TryGetLinkId(UnityEngine.Vector3 position, System.String& linkId) { }
        private System.Boolean TryGetLinkId(System.Int32 linkIndex, System.String& linkId) { }
        private System.Boolean TryGetOriginalLinkId(System.String linkId, System.String& originalLinkId) { }
        private System.Boolean TryGetCharacterStartPosAndHeight(System.Int32 charIndex, UnityEngine.Vector3& worldPos, System.Single& charHeight) { }
        private System.Boolean TryGetCharacterEndPosAndHeight(System.Int32 charIndex, UnityEngine.Vector3& worldPos, System.Single& charHeight) { }
        private System.Void CombineStringWithLanguageSpilt(T1 t1, T2 t2) { }
        private System.Void CombineStringWithLanguageSpilt(System.String t1, System.String t2) { }
        private System.Void SetHyperlinkUITextGroup(System.String groupId, System.Int32 order) { }
        private System.Boolean IsHyperlinkUITextGroupDisplayable(System.String groupId) { }
        private System.Collections.Generic.List<Beyond.UI.UIText> GetGroupDisplayableHyperlinkUIText(System.String groupId) { }
        private Beyond.UI.LuaPanel get_panel() { }
        private System.Void ClearComponent() { }
        private System.Void UpdateI18NFontAsset() { }
        private TMPro.TMP_FontAsset get_m_fontAsset() { }
        private System.Void set_m_fontAsset(TMPro.TMP_FontAsset value) { }
        private UnityEngine.Material get_fontSharedMaterial() { }
        private System.Void set_fontSharedMaterial(UnityEngine.Material value) { }
        private System.Void _RefreshMatTexture() { }
        private System.Void SetSharedMaterial(UnityEngine.Material mat) { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void OnAfterDeserialize() { }
        private TMPro.TMP_SubMeshUI AddSubTextObject(TMPro.TextMeshProUGUI textComponent, TMPro.MaterialReference materialReference) { }
        private System.String LocalStringCombineFormat(System.Int32 count) { }
        private UnityEngine.Sprite GetOrLoadSprite(System.String path) { }
        private System.Void DisposeInlineImageCache() { }
        private System.Void _ClearInlineImage() { }
        private Beyond.UI.UIText.ImageGOInfo _GetImageGoByIndex(System.Int32 index) { }
        private UnityEngine.GameObject _GetOrCreateImageGO() { }
        private System.Void _ReturnImageGO(UnityEngine.GameObject go) { }
        private System.Collections.IEnumerator _DelayedChangeActiveImageGo() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Void <>iFixBaseProxy_set_text(System.String P0) { }
        private System.Void <>iFixBaseProxy_ClearMesh() { }
        private System.Void <>iFixBaseProxy_RefreshPopulateText() { }
        private UnityEngine.Material <>iFixBaseProxy_LoadMaterial(System.String P0) { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }
        private System.Void <>iFixBaseProxy_Awake() { }
        private System.Void <>iFixBaseProxy_Start() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private TMPro.TMP_FontAsset <>iFixBaseProxy_get_m_fontAsset() { }
        private System.Void <>iFixBaseProxy_set_m_fontAsset(TMPro.TMP_FontAsset P0) { }
        private System.Void <>iFixBaseProxy_set_fontSharedMaterial(UnityEngine.Material P0) { }
        private System.Void <>iFixBaseProxy_SetSharedMaterial(UnityEngine.Material P0) { }
        private TMPro.TMP_SubMeshUI <>iFixBaseProxy_AddSubTextObject(TMPro.TextMeshProUGUI P0, TMPro.MaterialReference P1) { }

    }

    // TypeToken: 0x200001E
    public class UIConst
    {
        // Fields
        public static System.Boolean IS_PC_OR_CONSOLE;        // 0x0
        public static System.Single PC_REFERENCE_RESOLUTION_SCALE;        // 0x0
        public static System.Single MOBILE_PAD_DEVICE_REFERENCE_RESOLUTION_SCALE;        // 0x0
        public static readonly UnityEngine.Vector3 OUT_OF_SCREEN_POS;        // 0x4
        public static System.Single STANDARD_HORIZONTAL_RESOLUTION;        // 0x0
        public static System.Single STANDARD_VERTICAL_RESOLUTION;        // 0x0
        public static System.Int32 INVALID_FINGER_ID;        // 0x0
        public static System.Single STANDARD_RATIO;        // 0x10
        public static System.Single SCREEN_SPACE_CAMERA_PANEL_DISTANCE;        // 0x0
        public static System.String UI_BLUR_MATERIAL;        // 0x0
        public static System.String CS_POPUP_PANEL_PATH;        // 0x0
        public static System.String NAVIGATION_TARGET_CLICK_NO_HINT_ACTION_ID;        // 0x0
        public static System.String NAVIGATION_TARGET_CLICK_ACTION_ID;        // 0x0
        public static System.String UI_SPRITE_CHAR_HEAD_RECTANGLE;        // 0x0
        public static System.String UI_SPRITE_DIALOG_OPTION_ICON;        // 0x0
        public static System.String SLIDER_STICK_SCROLL_HORI_ACTION_ID;        // 0x0

        // Methods
        private System.Int32 get_STANDARD_HORIZONTAL_RESOLUTION_INT() { }
        private System.Int32 get_STANDARD_VERTICAL_RESOLUTION_INT() { }
        private System.Single get_CUR_STANDARD_HORIZONTAL_RESOLUTION() { }
        private System.Single get_CUR_STANDARD_VERTICAL_RESOLUTION() { }
        private System.Int32 get_dragThreshold() { }
        private System.Single GetResolutionScale() { }
        private System.Boolean IsPadDevice() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000021
    public class UIModelLoader, IDisposable
    {
        // Fields
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject,Beyond.Resource.FAssetProxyHandle> m_instance2AssetHandle;        // 0x10
        private System.Int32 m_requestCounter;        // 0x18
        private System.Collections.Generic.HashSet<System.Int32> m_requestIds;        // 0x20
        private System.Boolean m_disposed;        // 0x28
        private static System.Collections.Generic.List<MagicaCloth.MagicaBoneCloth> s_magicaBoneCloths;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.GameObject LoadModel(System.String modelPath, UnityEngine.Transform parent) { }
        private System.Int32 LoadModelAsync(System.String modelPath, UnityEngine.Transform parent, System.Action<UnityEngine.GameObject> callback) { }
        private System.Void Cancel(System.Int32 requestId) { }
        private System.Void UnloadModel(UnityEngine.GameObject modelGo) { }
        private System.Void _Clear() { }
        private System.Void Dispose() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000023
    public class UIUtils
    {
        // Fields
        private static System.Int32 MAX_SHARED_INT_STRING;        // 0x0
        private static readonly System.String[] s_sharedIntStringPool;        // 0x0
        private static UnityEngine.Vector3[] s_worldCorners;        // 0x8

        // Methods
        private System.String GetSharedIntString(System.Int32 value) { }
        private System.Boolean IsScreenPosInRectTransform(UnityEngine.Vector3 screenPos, UnityEngine.RectTransform rectTransform, UnityEngine.Camera uiCamera) { }
        private System.Boolean IsScreenPosInRectTransform(UnityEngine.Vector2 screenPos, UnityEngine.RectTransform rectTransform, UnityEngine.Camera uiCamera) { }
        private UnityEngine.Bounds CalcBoundOfRectTransform(UnityEngine.RectTransform transform, UnityEngine.RectTransform local) { }
        private System.Boolean TryGetTouch(System.Int32 touchId, UnityEngine.InputSystem.EnhancedTouch.Touch& touch) { }
        private System.Void SetAlpha(UnityEngine.UI.Graphic image, System.Single alpha) { }
        private System.Void SetColorWithoutAlpha(UnityEngine.UI.Graphic image, UnityEngine.Color color) { }
        private System.Void ClearUIComponents(UnityEngine.GameObject gameObject) { }
        private UnityEngine.Rect RectTransformToScreenRect(UnityEngine.RectTransform rectTransform, UnityEngine.Camera uiCamera) { }
        private UnityEngine.Vector3 GetNodeScaleOffset(UnityEngine.RectTransform referenceTransform, UnityEngine.RectTransform selfTransform) { }
        private UnityEngine.Color GetColorByString(System.String strColor) { }
        private System.Void SetMaskRatio(UnityEngine.UI.RectMask2D mask, System.Single r) { }
        private System.Single GetCursorTipOffsetX(System.Single defaultOffset) { }
        private System.Single GetCursorTipOffsetInScreen(System.Single defaultOffsetInScreen) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000024
    public class ActiveSyncHelper : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.GameObject> _objs;        // 0x18
        private System.Boolean _isInverse;        // 0x20

        // Methods
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Sync() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000025
    public class Billboard : TickableUIMono
    {
        // Fields
        public UnityEngine.Camera sceneCamera;        // 0x68

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void OnEnable() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x2000026
    public class CinemachineGyroscopeEffect : CinemachineExtension
    {
        // Fields
        public System.Single offsetX;        // 0x28
        public System.Single offsetY;        // 0x2C

        // Methods
        private System.Void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, Cinemachine.CameraState& state, System.Single deltaTime) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000027
    public class CommonItemToastList : UIScrollList
    {
        // Methods
        private System.Void ScrollToIndex(System.Int32 index, System.Boolean fastMode, Beyond.UI.UIScrollList.ScrollAlignType alignType, System.Boolean graduallyShowInFastMode) { }
        private System.Void AdjustContainerPos(System.Int32 index, System.Boolean fastMode) { }
        private UnityEngine.Vector2 _GetUnConstraintTargetPos(System.Int32 index) { }
        private System.Void .ctor() { }
        private UnityEngine.Vector2 <AdjustContainerPos>b__1_0() { }
        private System.Void <AdjustContainerPos>b__1_1(UnityEngine.Vector2 x) { }

    }

    // TypeToken: 0x2000028
    public class ControllerSideMenuItemList : MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<Beyond.UI.ControllerSideMenuItemList.MeunItemInfo> menuItems;        // 0x18
        public UnityEngine.Sprite icon;        // 0x20
        public System.String title;        // 0x28
        public UnityEngine.RectTransform contentPosTrans;        // 0x30
        public System.Boolean isFullScreen;        // 0x38
        private static readonly System.Collections.Generic.HashSet<System.String> s_forceValidItemList;        // 0x0

        // Methods
        private System.Void ToggleItemForceValid(System.String itemName, System.Boolean forceValid) { }
        private System.Boolean IsItemForceValid(System.String itemName) { }
        private System.Void ClearForceValidItemList() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002A
    public class CustomNotchAdapt : MonoBehaviour
    {
        // Fields
        public System.Boolean isLeft;        // 0x18
        public System.Boolean isRight;        // 0x19
        public System.Boolean isBottom;        // 0x1A
        public System.Boolean isFullHorizontalStretch;        // 0x1B

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002B
    public struct UIStyleInputValidType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIStyleInputValidType All;        // 0x0
        public static Beyond.UI.UIStyleInputValidType Keyboard;        // 0x0
        public static Beyond.UI.UIStyleInputValidType Touch;        // 0x0
        public static Beyond.UI.UIStyleInputValidType Controller;        // 0x0
        public static Beyond.UI.UIStyleInputValidType KeyboardAndTouch;        // 0x0
        public static Beyond.UI.UIStyleInputValidType KeyboardAndController;        // 0x0
        public static Beyond.UI.UIStyleInputValidType TouchAndController;        // 0x0

    }

    // TypeToken: 0x200002C
    public struct UIStyleInputValidTypeMask
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIStyleInputValidTypeMask Keyboard;        // 0x0
        public static Beyond.UI.UIStyleInputValidTypeMask Touch;        // 0x0
        public static Beyond.UI.UIStyleInputValidTypeMask Controller;        // 0x0
        public static Beyond.UI.UIStyleInputValidTypeMask All;        // 0x0

    }

    // TypeToken: 0x200002D
    public struct ActiveType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.ActiveType UseGameObjectActive;        // 0x0
        public static Beyond.UI.ActiveType UseScale;        // 0x0

    }

    // TypeToken: 0x200002E
    public class CustomUIStyle : MonoBehaviour
    {
        // Fields
        public Beyond.UI.UIStyleInputValidType inputValidType;        // 0x18
        public Beyond.UI.ActiveType activeType;        // 0x1C
        private UnityEngine.UI.LayoutElement _layoutElement;        // 0x20
        private UnityEngine.Animator _animator;        // 0x28
        private Beyond.UI.CustomUIStyle.OverrideValidState m_overrideValidState;        // 0x30

        // Methods
        private Beyond.UI.UIStyleInputValidTypeMask get_inputValidTypeMask() { }
        private System.Void set_inputValidTypeMask(Beyond.UI.UIStyleInputValidTypeMask value) { }
        private Beyond.UI.CustomUIStyle.OverrideValidState get_overrideValidState() { }
        private System.Void set_overrideValidState(Beyond.UI.CustomUIStyle.OverrideValidState value) { }
        private System.Void _OnActiveTypeChanged() { }
        private System.Boolean get_isValid() { }
        private System.Void OnDestroy() { }
        private System.Void OnEnable() { }
        private System.Void Awake() { }
        private System.Void CheckState() { }
        private System.Void ToggleActiveState(System.Boolean isActive) { }
        private System.Boolean IsShowTypeValid(Beyond.UI.UIStyleInputValidType inputValidType) { }
        private System.Boolean IsValidInput(Beyond.UI.UIStyleInputValidTypeMask inputValidTypeMask) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000030
    public class DeactivateNaviOnEnable : MonoBehaviour
    {
        // Fields
        public System.String key;        // 0x18

        // Methods
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000031
    public class DecoLineActiveHelper : TickableUIMono
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.GameObject> checkTargets;        // 0x68
        public System.Collections.Generic.List<UnityEngine.GameObject> secondCheckTargets;        // 0x70
        private UnityEngine.UI.LayoutElement _layoutElement;        // 0x78

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void Reset() { }
        private System.Void OnEnable() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void Sync() { }
        private System.Boolean _HasActiveTarget(System.Collections.Generic.List<UnityEngine.GameObject> targets) { }
        private System.Void _ToggleVisible(System.Boolean isVisible) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x2000032
    public class Empty4Raycast : MaskableGraphic
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh) { }
        private System.Void <>iFixBaseProxy_OnPopulateMesh(UnityEngine.UI.VertexHelper P0) { }

    }

    // TypeToken: 0x2000033
    public class FitAspectRatioByFOV : MonoBehaviour, IScreenSizeListener
    {
        // Fields
        public System.Single referenceAspect;        // 0x18
        private System.Single m_referenceVerticalFOV;        // 0x1C
        private Cinemachine.CinemachineVirtualCamera m_virtualCamera;        // 0x20
        private System.Single m_currentAspect;        // 0x28

        // Methods
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnScreenSizeChanged(System.Int32 width, System.Int32 height) { }
        private System.Void _AdjustFOV() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000034
    public class FixRotation : TickableUIMono
    {
        // Fields
        public UnityEngine.Vector3 rotation;        // 0x68

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x2000035
    public class FullScreenSceneBlurMarker : MonoBehaviour
    {
        // Fields
        private static System.Int32 s_nextId;        // 0x0
        public static System.Action<System.Int32,Beyond.UI.FullScreenSceneBlurMarker.State,System.Boolean,System.Boolean> s_onFullScreenSceneBlurMarkerStateChanged;        // 0x8
        private System.Int32 <id>k__BackingField;        // 0x18
        public System.Boolean useWhiteBlur;        // 0x1C
        public System.Boolean useSceneColorPS;        // 0x1D

        // Methods
        private System.Int32 _GetNextId() { }
        private System.Int32 get_id() { }
        private System.Void set_id(System.Int32 value) { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000037
    public class InputBindingGroupNaviDecorator : Selectable, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private Beyond.Input.InputBindingGroupMonoTarget m_inputBindingGroup;        // 0x180
        public UnityEngine.Events.UnityEvent<System.Boolean> onGroupSetAsNaviTarget;        // 0x188

        // Methods
        private System.Void _SetSelfEnabledStateIfNecessary() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDestroy() { }
        private System.Void _OnSetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode) { }
        private System.Void ClearComponent() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Awake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }
        private System.Void <>iFixBaseProxy__OnSetAsNaviTarget(System.Boolean P0, System.Boolean P1) { }

    }

    // TypeToken: 0x2000038
    public interface IUIClearable : ILuaCallCSharp
    {
        // Methods
        private System.Void ClearComponent() { }

    }

    // TypeToken: 0x2000039
    public class LuaPanel : MonoBehaviour, IUIClearable, ILuaCallCSharp
    {
        // Fields
        public static System.Collections.Generic.Dictionary<System.String,Beyond.UI.LuaPanel> s_openedLuaPanels;        // 0x0
        private System.Boolean _isPCOnlyPanel;        // 0x18
        private System.Boolean _isControllerPanel;        // 0x19
        public System.Boolean inited;        // 0x1A
        private System.Boolean _isWorldUI;        // 0x1B
        private UnityEngine.Vector3 _uiRot;        // 0x1C
        private System.Boolean _blockWhileAnim;        // 0x28
        private System.Int32 <panelLevel>k__BackingField;        // 0x2C
        public Beyond.UI.UIAnimationWrapper animationWrapper;        // 0x30
        private Beyond.Audio.AudioUIUtil.UIAudioType _uiAudioType;        // 0x38
        private UnityEngine.RectTransform <rectTransform>k__BackingField;        // 0x40
        private UnityEngine.Canvas <canvas>k__BackingField;        // 0x48
        public System.Collections.Generic.HashSet<Beyond.UI.UISortingOrder> sortingOrderComps;        // 0x50
        private UnityEngine.Camera <uiCamera>k__BackingField;        // 0x58
        private System.Single <planeDistance>k__BackingField;        // 0x60
        private System.Int32 <panelId>k__BackingField;        // 0x64
        private System.String <panelName>k__BackingField;        // 0x68
        private System.Boolean m_showRot;        // 0x70
        private Beyond.Input.InputBindingGroupMonoTarget m_inputBindingGroupMonoTarget;        // 0x78
        private UnityEngine.UI.GraphicRaycaster[] m_graphicRaycasters;        // 0x80
        private System.Boolean m_started;        // 0x88
        private UnityEngine.Coroutine m_animationInCoroutine;        // 0x90
        private System.Boolean m_waitAutoAnimInFinished;        // 0x98
        public Beyond.DisposedUnityEvent onAnimationInFinished;        // 0xA0
        private System.Boolean m_animationInFinished;        // 0xA8
        private System.Collections.Generic.HashSet<UnityEngine.GameObject> m_animationInWaitTargets;        // 0xB0

        // Methods
        private System.Int32 get_panelLevel() { }
        private System.Void set_panelLevel(System.Int32 value) { }
        private UnityEngine.RectTransform get_rectTransform() { }
        private System.Void set_rectTransform(UnityEngine.RectTransform value) { }
        private UnityEngine.Canvas get_canvas() { }
        private System.Void set_canvas(UnityEngine.Canvas value) { }
        private UnityEngine.Camera get_uiCamera() { }
        private System.Void set_uiCamera(UnityEngine.Camera value) { }
        private System.Single get_planeDistance() { }
        private System.Void set_planeDistance(System.Single value) { }
        private System.Int32 get_panelId() { }
        private System.Void set_panelId(System.Int32 value) { }
        private System.String get_panelName() { }
        private System.Void set_panelName(System.String value) { }
        private System.Void set_IsWorldUI(System.Boolean value) { }
        private System.Boolean get_IsWorldUI() { }
        private System.Boolean get_isPCOnlyPanel() { }
        private System.Boolean get_isControllerPanel() { }
        private System.Void Awake() { }
        private System.Void _TrySetRot() { }
        private System.Void AddSortingOrderComp(Beyond.UI.UISortingOrder comp) { }
        private System.Void RemoveSortingOrderComp(Beyond.UI.UISortingOrder comp) { }
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Collections.IEnumerator _AutoAnimationInFinish() { }
        private System.Boolean get_animationInFinished() { }
        private System.Void InformAnimationInStart(UnityEngine.GameObject target) { }
        private System.Void InformAnimationInEnd(UnityEngine.GameObject target, System.Boolean forceEnd) { }
        private System.Void _TryCallAnimationInFinished(System.Boolean forceFinished) { }
        private System.Void BlockAllInput() { }
        private System.Void RecoverAllInput() { }
        private System.Void ClearComponent() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200003B
    public class MouseHoverTipsPosHelper : TickableUIMono
    {
        // Fields
        private UnityEngine.RectOffset _padding;        // 0x68
        private Beyond.UI.LuaPanel m_panel;        // 0x70
        private UnityEngine.RectTransform m_rectTransform;        // 0x78

        // Methods
        private Beyond.TickType get_tickOption() { }
        private Beyond.UI.LuaPanel get_panel() { }
        private System.Void OnAwake() { }
        private System.Void OnEnable() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void UpdatePosition() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x200003C
    public class NaviToThisGroupOnEnable : MonoBehaviour
    {
        // Fields
        public Beyond.UI.UISelectableNaviGroup target;        // 0x18

        // Methods
        private System.Void Reset() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003D
    public class NonDrawingGraphic : Graphic, ICanvasRaycastFilter
    {
        // Fields
        public Beyond.UI.NonDrawingGraphic.ShapeType shapeType;        // 0xB0

        // Methods
        private System.Single get_Radius() { }
        private System.Void SetMaterialDirty() { }
        private System.Void SetVerticesDirty() { }
        private System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh) { }
        private System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera) { }
        private System.Boolean _IsRaycastLocationValidCircle(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_SetMaterialDirty() { }
        private System.Void <>iFixBaseProxy_SetVerticesDirty() { }
        private System.Void <>iFixBaseProxy_OnPopulateMesh(UnityEngine.UI.VertexHelper P0) { }

    }

    // TypeToken: 0x200003F
    public class NotchAdapter : MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector2 selfMarginSize;        // 0x18
        public System.Collections.Generic.List<UnityEngine.RectTransform> leftSideUIList;        // 0x20
        public System.Collections.Generic.List<UnityEngine.RectTransform> rightSideUIList;        // 0x28
        public System.Collections.Generic.List<UnityEngine.RectTransform> bottomSideUIList;        // 0x30
        public System.Collections.Generic.List<UnityEngine.RectTransform> fullHorizontalStretchUIList;        // 0x38
        public System.Boolean alwaysFindSideUI;        // 0x40
        private UnityEngine.UI.CanvasScaler m_canvasScaler;        // 0x48
        private Beyond.UI.UICanvasScaleHelper m_notchHost;        // 0x50

        // Methods
        private System.Void Awake() { }
        private System.Void OnDestroy() { }
        private System.Void FindAllSideUI(System.Boolean needClear) { }
        private System.Void ApplyNotch() { }
        private System.Void ApplyNotch(UnityEngine.Vector2 curMarginSize) { }
        private System.Void ClearList() { }
        private System.Void ClearNullRef() { }
        private System.Void UnApplyNotch() { }
        private System.Void ApplyNewNotch() { }
        private System.Void _UpdateMargeSizeFromNotchInfo(System.Boolean forceUpdate) { }
        private System.Void _OnCanvasChanged() { }
        private System.Void _RemoveNullRef(System.Collections.Generic.List<T> list) { }
        private System.Void _TraverseUI(UnityEngine.RectTransform root) { }
        private System.Void _TryAddToSideUI(UnityEngine.RectTransform rect, Beyond.UI.CustomNotchAdapt custom) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000041
    public class ParallaxHelper : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<Beyond.UI.ParallaxHelper.ParallaxConfig> _configs;        // 0x18
        private System.Single _maxOffset;        // 0x20
        private System.Single m_curValue;        // 0x24

        // Methods
        private System.Single get_curValue() { }
        private System.Void set_curValue(System.Single value) { }
        private System.Void InitConfigs() { }
        private System.Void ResetValue() { }
        private System.Void RefreshPos() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000043
    public class PercentNumberTweener : TickableUIMono
    {
        // Fields
        private Beyond.UI.UIText _text;        // 0x68
        private System.String _format;        // 0x70
        private Beyond.UI.UIImage _progressImg;        // 0x78
        private System.Int32 m_cacheValue;        // 0x80

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void Reset() { }
        private System.Void OnEnable() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x2000044
    public class UIRecycleLayoutAdapter
    {
        // Fields
        private Beyond.UI.UIRecycleLayoutGroup.IViewHandler <viewHandler>k__BackingField;        // 0x10

        // Methods
        private System.Void Init(Beyond.UI.UIRecycleLayoutGroup.IViewHandler handler) { }
        private Beyond.UI.UIRecycleLayoutGroup.IViewHandler get_viewHandler() { }
        private System.Void set_viewHandler(Beyond.UI.UIRecycleLayoutGroup.IViewHandler value) { }
        private System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild() { }
        private System.Void OnInit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000049
    public class UIRecycleLayoutSimpleHolder`1 : TickableUIMono
    {
        // Fields
        private Beyond.UI.UIScrollRect _scrollRect;        // 0x0
        protected System.Single _scrollDuration;        // 0x0
        protected DG.Tweening.Ease _scrollEase;        // 0x0
        protected System.Boolean _enableLoopWrappedNavigation;        // 0x0
        private System.Boolean m_isInited;        // 0x0
        protected Beyond.UI.UIRecycleLayoutSimpleHolder.SimpleAdapter<TVirtualView> m_simpleAdapter;        // 0x0
        protected Beyond.UI.UIRecycleLayoutGroup m_layoutGroup;        // 0x0
        public Beyond.DisposedUnityEvent doOnceAfterLayout;        // 0x0
        private System.Collections.Generic.List<UnityEngine.UI.Selectable> m_wrapNaviSelectables;        // 0x0
        protected DG.Tweening.Tween m_scrollTween;        // 0x0

        // Methods
        private System.Void _InitIfNot() { }
        private System.Void OnAwake() { }
        private System.Void _AfterLayout() { }
        private System.Void _WrapNavigation(UnityEngine.UI.NaviDirection dir) { }
        private System.Void OnAdapterInit() { }
        private System.Void ScrollTo(System.Int32 index, System.Boolean fastMode) { }
        private System.Void ClearScrollTweenIfNeeded() { }
        private System.Void ScrollToInternal(System.Single normalizedPosition, System.Boolean fastMode) { }
        private UnityEngine.GameObject GetView(System.Int32 index) { }
        private System.Void NotifyAllSizeChanged() { }
        private System.Void NotifySizeChanged(System.Int32 index) { }
        private System.Void NotifySizeChanged(TVirtualView virtualView) { }
        private System.Void RemoveView(System.Int32 index) { }
        private System.Void RemoveAllViews() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004C
    public class UIRecycleLayoutGroup : TickableUIMono, ILayoutElement, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private Beyond.UI.UIRecycleLayoutGroup.Direction _direction;        // 0x68
        private UnityEngine.RectTransform _viewport;        // 0x70
        private UnityEngine.RectTransform _content;        // 0x78
        private System.Single _notCachedBufferSize;        // 0x80
        private System.Int32 _layoutPriority;        // 0x84
        private Beyond.UI.UIRecycleLayoutGroup.Padding _padding;        // 0x88
        private System.Single _spacing;        // 0x98
        private System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIRecycleLayoutGroup.LayoutMeta> m_layoutMetaMap;        // 0xA0
        private Beyond.UI.UIRecycleLayoutAdapter m_adapter;        // 0xA8
        private Beyond.UI.UIRecycleLayoutGroup.ViewMgr m_viewMgr;        // 0xB0
        private System.Single <sizeOnAxis>k__BackingField;        // 0xB8
        public Beyond.DisposedUnityEvent onLayoutUpdated;        // 0xC0

        // Methods
        private Beyond.TickType get_tickOption() { }
        private Beyond.UI.UIRecycleLayoutAdapter get_adapter() { }
        private Beyond.UI.UIRecycleLayoutGroup.ViewMgr get_viewMgr() { }
        private System.Single get_sizeOnAxis() { }
        private System.Void set_sizeOnAxis(System.Single value) { }
        private System.Single get_spacing() { }
        private Beyond.UI.UIRecycleLayoutGroup.Padding get_padding() { }
        private System.Single get_minWidth() { }
        private System.Single get_minHeight() { }
        private System.Single get_flexibleWidth() { }
        private System.Single get_flexibleHeight() { }
        private System.Int32 get_layoutPriority() { }
        private System.Void CalculateLayoutInputHorizontal() { }
        private System.Void CalculateLayoutInputVertical() { }
        private System.Single get_preferredWidth() { }
        private System.Single get_preferredHeight() { }
        private System.Single get_paddingFront() { }
        private System.Single get_paddingBack() { }
        private System.Void _ApplyLayoutMeta(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view, Beyond.UI.UIRecycleLayoutGroup.LayoutMeta meta) { }
        private UnityEngine.Vector2 _GetVisibleRange(UnityEngine.Bounds viewBound) { }
        private UnityEngine.Bounds _GetElementBoundsFromMeta(Beyond.UI.UIRecycleLayoutGroup.LayoutMeta meta) { }
        private Beyond.UI.UIRecycleLayoutAdapter SetAdapter(Beyond.UI.UIRecycleLayoutAdapter adapter) { }
        private System.Void ClearComponent() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void OnLateTick() { }
        private System.Void _RebuildAllViews() { }
        private System.Void _UpdateViews(System.Int32 fromIndex) { }
        private System.Boolean _InsertView(System.Int32 index, Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        private System.Boolean _RemoveView(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        private System.Void _UpdateViewsFrom(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        private System.Single _GetElementPosByIndex(System.Int32 index) { }
        private UnityEngine.Bounds _GetElementBoundsByIndex(System.Int32 index) { }
        private System.Int32 _GetElementIndex(Beyond.UI.UIRecycleLayoutAdapter.IVirtualView view) { }
        private UnityEngine.RectTransform get_content() { }
        private System.Void _RefreshLayout() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x2000055
    public class UIRecycleMultiHolder : UIRecycleLayoutSimpleHolder`1, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private System.Collections.Generic.List<Beyond.UI.UIRecycleMultiHolder.Config> _configs;        // 0xA8
        public Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32> onUpdateCell;        // 0xB0
        public Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32> onDetachCell;        // 0xB8
        public System.Func<System.Int32,System.Single> getCellDefaultSize;        // 0xC0
        public System.Func<System.Int32,System.String> getCellPrefabKey;        // 0xC8
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject> m_prefabMap;        // 0xD0

        // Methods
        private Beyond.UI.UIRecycleMultiHolder.MultiVirtualView GetVirtualView(System.Int32 index) { }
        private System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop) { }
        private System.Void UpdateCount(System.Int32 newCount, System.Int32 fastScrollToIndex) { }
        private System.Void InsertView(System.Int32 index, System.String key, System.Single initSize) { }
        private System.Void AddView(System.String key, System.Single initSize) { }
        private System.Void OnAdapterInit() { }
        private System.Void ClearComponent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000058
    public class UIRecycleSingleHolder : UIRecycleLayoutSimpleHolder`1, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private System.Int32 m_count;        // 0xA8
        public Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32> onUpdateCell;        // 0xB0
        public Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32> onDetachCell;        // 0xB8
        public System.Func<System.Int32,System.Single> getCellDefaultSize;        // 0xC0
        private UnityEngine.GameObject _cellTemplate;        // 0xC8

        // Methods
        private Beyond.UI.UIRecycleSingleHolder.SimpleVirtualView GetVirtualView(System.Int32 index) { }
        private System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop) { }
        private System.Void UpdateCount(System.Int32 newCount, System.Int32 fastScrollToIndex) { }
        private System.Void InsertView(System.Int32 index, System.String key, System.Single initSize) { }
        private System.Void AddView(System.String key, System.Single initSize) { }
        private System.Void OnAdapterInit() { }
        private System.Void ClearComponent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005A
    public class SimpleUITextSingleLine : UIText
    {
        // Fields
        private static Unity.Profiling.ProfilerMarker s_GenerateTextMarker;        // 0x0
        private static Unity.Profiling.ProfilerMarker s_GenerateTextPhaseIMarker;        // 0x8
        private static Unity.Profiling.ProfilerMarker s_CharacterLookupMarker;        // 0x10
        private static Unity.Profiling.ProfilerMarker s_HandleGPOSFeaturesMarker;        // 0x18
        private static Unity.Profiling.ProfilerMarker s_CalculateVerticesPositionMarker;        // 0x20
        private static Unity.Profiling.ProfilerMarker s_ComputeTextMetricsMarker;        // 0x28
        private static Unity.Profiling.ProfilerMarker s_HandleVisibleCharacterMarker;        // 0x30
        private static Unity.Profiling.ProfilerMarker s_HandleVisibleCharacterMarker_1;        // 0x38
        private static Unity.Profiling.ProfilerMarker s_HandleVisibleCharacterMarker_2;        // 0x40
        private static Unity.Profiling.ProfilerMarker s_HandleVisibleCharacterMarker_3;        // 0x48
        private static Unity.Profiling.ProfilerMarker s_HandleVisibleCharacterMarker_4;        // 0x50
        private static Unity.Profiling.ProfilerMarker s_HandleWhiteSpacesMarker;        // 0x58
        private static Unity.Profiling.ProfilerMarker s_HandleHorizontalLineBreakingMarker;        // 0x60
        private static Unity.Profiling.ProfilerMarker s_HandleVerticalLineBreakingMarker;        // 0x68
        private static Unity.Profiling.ProfilerMarker s_SaveGlyphVertexDataMarker;        // 0x70
        private static Unity.Profiling.ProfilerMarker s_ComputeCharacterAdvanceMarker;        // 0x78
        private static Unity.Profiling.ProfilerMarker s_HandleCarriageReturnMarker;        // 0x80
        private static Unity.Profiling.ProfilerMarker s_HandleLineTerminationMarker;        // 0x88
        private static Unity.Profiling.ProfilerMarker s_SavePageInfoMarker;        // 0x90
        private static Unity.Profiling.ProfilerMarker s_SaveProcessingStatesMarker;        // 0x98
        private static Unity.Profiling.ProfilerMarker s_GenerateTextPhaseIIMarker;        // 0xA0
        private static Unity.Profiling.ProfilerMarker s_GenerateTextPhaseIIIMarker;        // 0xA8
        public System.Boolean m_b;        // 0xC80
        private System.Action<TMPro.TMP_TextInfo> OnPreRenderText;        // 0xC88

        // Methods
        private System.Void GenerateTextMesh() { }
        private System.Void add_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value) { }
        private System.Void remove_OnPreRenderText(System.Action<TMPro.TMP_TextInfo> value) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Void <>iFixBaseProxy_GenerateTextMesh() { }

    }

    // TypeToken: 0x200005B
    public class ToastList : MonoBehaviour, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private UnityEngine.GameObject _cellTemplate;        // 0x18
        private System.Single _showDuration;        // 0x20
        private System.Single _delay;        // 0x24
        private System.Int32 _maxShowingCount;        // 0x28
        private System.Boolean <inAnimation>k__BackingField;        // 0x2C
        public Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32> onUpdateCell;        // 0x30
        public Beyond.DisposedUnityEvent onAllToastFinished;        // 0x38
        private System.Int32 m_totalCount;        // 0x40
        private System.Int32 m_maxFinishedIndex;        // 0x44
        private System.Int32 m_maxShowingIndex;        // 0x48
        private System.Int32 m_waitingCount;        // 0x4C
        private System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.ToastList.CellInfo> m_showingCells;        // 0x50
        private System.Collections.Generic.List<Beyond.UI.ToastList.CellInfo> m_cachedCells;        // 0x58

        // Methods
        private System.Boolean get_inAnimation() { }
        private System.Void set_inAnimation(System.Boolean value) { }
        private System.Void Awake() { }
        private System.Void OnDisable() { }
        private Beyond.UI.ToastList.CellInfo _GetCell() { }
        private System.Void _CacheCell(Beyond.UI.ToastList.CellInfo cell) { }
        private System.Void AddToast(System.Int32 count, System.Int32 startIndex) { }
        private System.Void _StartBatch(System.Int32 batchCount) { }
        private System.Collections.IEnumerator _ShowCell(System.Int32 delayIndex, Beyond.UI.ToastList.CellInfo cell) { }
        private System.Void _TryShowNewCell() { }
        private System.Void _OnCellFinished(Beyond.UI.ToastList.CellInfo cell) { }
        private System.Void ClearAllToast() { }
        private System.Void ClearComponent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005E
    public class UI3DScrollList : UIScrollList
    {
        // Methods
        private System.Void MoveCellTo(Beyond.UI.UIScrollList.Cell cell, System.Int32 index) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_MoveCellTo(Beyond.UI.UIScrollList.Cell P0, System.Int32 P1) { }

    }

    // TypeToken: 0x200005F
    public class UIActionKeyHint : MonoBehaviour, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private static readonly UnityEngine.Color NORMAL_COLOR;        // 0x0
        private static readonly UnityEngine.Color HIDE_COLOR;        // 0x10
        private static readonly UnityEngine.Color DISABLED_COLOR;        // 0x20
        private static System.Collections.Generic.List<Beyond.UI.UIActionKeyHint> s_keyHintCache;        // 0x30
        private static System.Boolean s_inited;        // 0x38
        public static System.Boolean s_stopCheckBindingEnabledForGuide;        // 0x39
        private static System.String INVALID_KEY_STR;        // 0x0
        private Beyond.Input.IBindingView m_target;        // 0x18
        public System.String actionId;        // 0x20
        public UnityEngine.Component btnTarget;        // 0x28
        public Beyond.Input.BindingViewActionType bindingViewActionType;        // 0x30
        private System.Boolean _useCustomText;        // 0x34
        private System.Boolean _showSecondAction;        // 0x35
        private System.Boolean _onlyShowOnLongPress;        // 0x36
        private System.Boolean _adaptForceGrayState;        // 0x37
        private UnityEngine.Transform _content;        // 0x38
        private UnityEngine.CanvasGroup _contentCanvasGroup;        // 0x40
        private Beyond.UI.UIImage _icon;        // 0x48
        private Beyond.UI.UIImage _longPressIcon;        // 0x50
        private UnityEngine.RectTransform _pressHintNode;        // 0x58
        private Beyond.UI.UIImage _pressHintProgressImg;        // 0x60
        private Beyond.UI.UIText _text;        // 0x68
        private Beyond.UI.UIImage _secondIcon;        // 0x70
        private UnityEngine.RectTransform _secondNode;        // 0x78
        private Beyond.UI.UIImage _modifyIcon;        // 0x80
        private UnityEngine.GameObject _mutexGameObject;        // 0x88
        private System.Boolean _changeScaleOnHide;        // 0x90
        public System.Int32 bindingId;        // 0x94
        public System.Func<System.Boolean> checkVirtualMouseClickHintFunc;        // 0x98
        private UnityEngine.CanvasGroup _canvasGroup;        // 0xA0
        public System.Boolean autoUpdate;        // 0xA8
        private System.Boolean <hintHidden>k__BackingField;        // 0xA9
        private System.Int32 m_cachedBindingId;        // 0xAC
        private System.Boolean m_isLongPressAction;        // 0xB0
        private System.Single m_lastPressStartTime;        // 0xB4
        private static System.Single LONG_PRESS_HINT_HIDE_TIME;        // 0x0
        private static System.Single LONG_PRESS_HINT_SHOW_MIN_VALUE;        // 0x0

        // Methods
        private System.Void _TryInit() { }
        private System.Void _RefreshAllKeyHints() { }
        private System.Void _OnInputLateTickAll() { }
        private System.Void _OnControllerTypeChange(Beyond.DeviceInfo.ControllerType controllerType) { }
        private Beyond.Input.IBindingView get_target() { }
        private System.Boolean get_showCanvasGroup() { }
        private System.Boolean get_hintHidden() { }
        private System.Void set_hintHidden(System.Boolean value) { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void Reset() { }
        private System.Void _OnInputLateTick() { }
        private System.Void UpdateKeyHint() { }
        private System.Void SetActionId(System.String id, System.Boolean forceUpdate) { }
        private System.Void SetKeyHint(System.String actId, Beyond.Input.IBindingView hintTarget, System.Boolean forceUpdate) { }
        private System.Void SetBindingId(System.Int32 bId, System.Boolean forceUpdate) { }
        private System.Void SetBindingId(System.Int32 bId, System.String actId, Beyond.Input.IBindingView hintTarget, System.Boolean forceUpdate) { }
        private System.Void _OnChangeTarget() { }
        private System.Void _OnInputActionKeyUpdated(Beyond.EventData<System.String>& data) { }
        private System.Void SetSecondActionId(System.String id, System.Boolean isPrimary) { }
        private System.Void _SetSecondIcon(Beyond.Input.PlayerActionInfo actionInfo, System.Boolean isPrimary) { }
        private System.Void _CheckInteractable(System.Boolean isInit) { }
        private System.Boolean _IsInputEnabled() { }
        private System.Boolean _IsInputGray() { }
        private System.String GetTextStr() { }
        private System.Void SetText(System.String text) { }
        private System.Boolean GetAndSetActionIcon(Beyond.UI.UIImage iconImage, Beyond.Input.PlayerActionInfo actionInfo, System.Boolean usingController, System.Boolean& isLongPressAction, System.Boolean isPrimary) { }
        private System.Boolean GetAndSetActionModifyIcon(Beyond.Input.PlayerActionInfo actionInfo, System.Boolean usingController, System.Boolean isPrimary) { }
        private System.Boolean _SetKeyCodeSprite(Beyond.UI.UIImage iconImage, System.String iconPath) { }
        private System.Void _CheckVirtualMouseClickHint() { }
        private System.Void _UpdatePressHint() { }
        private System.Void _GetLongPressInfo(System.Single& startTime, System.Single& longPressTime) { }
        private System.String GetActionId() { }
        private Beyond.Input.PlayerActionInfo GetActionInfo() { }
        private System.Void ClearComponent() { }
        private System.Void SetContentState(System.Boolean contentState) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000060
    public class UIAnimationHolder : MonoBehaviour, IAnimationClipSource
    {
        // Fields
        private System.Collections.Generic.List<Beyond.UI.UIAnimationHolder.ClipHolder> _clips;        // 0x18

        // Methods
        private UnityEngine.AnimationClip FindByName(System.String name) { }
        private UnityEngine.AnimationClip FindByNameOrAlias(System.String nameOrAlias) { }
        private UnityEngine.AnimationClip _FindByString(System.String id, System.Boolean useAlias) { }
        private System.Void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> results) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000062
    public class UIAnimationLoopSynchronizer : MonoBehaviour
    {
        // Fields
        public System.String syncLoopAnimKey;        // 0x18
        private readonly System.Collections.Generic.List<Beyond.UI.UIAnimationWrapper> m_children;        // 0x20

        // Methods
        private System.Void RegisterChild(Beyond.UI.UIAnimationWrapper child) { }
        private System.Void UnregisterChild(Beyond.UI.UIAnimationWrapper child) { }
        private System.Single GetLoopStartPosition() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000063
    public class UIAnimationWrapper : MonoBehaviour, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private UnityEngine.AnimationClip _animationIn;        // 0x18
        private UnityEngine.AnimationClip _animationInEasing;        // 0x20
        private UnityEngine.AnimationClip _animationLoop;        // 0x28
        private UnityEngine.AnimationClip _animationOut;        // 0x30
        public System.Boolean autoPlay;        // 0x38
        private System.Boolean _onlyOnce;        // 0x39
        private System.Boolean _needSyncLoopAnim;        // 0x3A
        private System.String _syncLoopAnimKey;        // 0x40
        private Beyond.UI.UIAnimationWrapper.FOptions _options;        // 0x48
        private UnityEngine.Animation m_animation;        // 0x50
        private System.Collections.Generic.Dictionary<System.String,Beyond.UI.UIAnimationWrapper.AnimationRuntime> m_animPool;        // 0x58
        private Beyond.UI.UIAnimationTween m_curTween;        // 0x60
        private System.Boolean m_isInAutoPlayed;        // 0x68
        private Beyond.UI.UIAnimationLoopSynchronizer m_loopSynchronizer;        // 0x70
        private static readonly System.Collections.Generic.List<Beyond.UI.UIAnimationLoopSynchronizer> s_tempSyncList;        // 0x0
        public System.String curStateName;        // 0x78
        public Beyond.UI.UIConst.AnimationState curState;        // 0x80
        private System.Single m_lastPlayAnimationInStartTime;        // 0x84
        private System.Boolean m_started;        // 0x88
        private Beyond.UI.UIAnimationWrapper.CachedSampleClipInfo m_cachedSampleClipInfo;        // 0x90
        private System.Boolean m_needInformAnimationInEnd;        // 0xA0
        private Beyond.UI.LuaPanel m_panel;        // 0xA8
        private System.String _audioOnOpen;        // 0xB0
        private System.String _audioOnClose;        // 0xB8

        // Methods
        private UnityEngine.AnimationClip get_animationIn() { }
        private UnityEngine.AnimationClip get_animationInEasing() { }
        private UnityEngine.AnimationClip get_animationLoop() { }
        private UnityEngine.AnimationClip get_animationOut() { }
        private System.Void SetOptions(Beyond.UI.UIAnimationWrapper.FOptions options) { }
        private Beyond.UI.UIAnimationTween get_curTween() { }
        private System.Void _InitAnimation() { }
        private System.Void _AnimationInLoopCheck() { }
        private System.Void _AnimationAutomaticallyCheck() { }
        private System.Void Awake() { }
        private System.Boolean IsStarted() { }
        private System.Void PlayOutAnimation(DG.Tweening.TweenCallback callback) { }
        private System.Void SetAnimationOutClip(System.String clipName) { }
        private System.Single GetInClipLength() { }
        private System.Single GetOutClipLength() { }
        private System.Single GetLoopClipLength() { }
        private System.Void PlayLoopAnimation() { }
        private System.Void PlayInAnimation(DG.Tweening.TweenCallback callback, System.Boolean autoPlayLoop) { }
        private System.Void SkipInAnimation() { }
        private System.Void SampleToInAnimationBegin() { }
        private System.Void SampleToInAnimationEnd() { }
        private System.Void SampleToOutAnimationEnd() { }
        private System.Void _OnInAnimationFinished(System.Boolean autoPlayLoop) { }
        private System.Void _OnInEasingAnimationFinished(System.Boolean autoPlayLoop) { }
        private UnityEngine.AnimationState GetClip(System.String aniName) { }
        private System.Single GetClipLength(System.String aniName) { }
        private System.Void _SampleClipAtLength(Beyond.UI.UIAnimationWrapper.AnimationRuntime runtime, System.Single position) { }
        private System.Void SampleClipAtPercent(System.String clipName, System.Single percent, System.Boolean clearTween) { }
        private System.Void SampleClip(System.String clipName, System.Single position, System.Boolean clearTween) { }
        private System.Void ClearTween(System.Boolean executeOnComplete) { }
        private System.Boolean _CheckShouldAutoPlayAnimationIn() { }
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Boolean CheckStopped() { }
        private System.Void Play(UnityEngine.AnimationClip animationClip, DG.Tweening.TweenCallback onComplete, Beyond.UI.UIConst.AnimationState newState, System.Single startPlayTime) { }
        private System.Void Play(System.String stateName, DG.Tweening.TweenCallback onComplete, Beyond.UI.UIConst.AnimationState newState, System.Single startPlayTime) { }
        private System.Void PlayWithTween(UnityEngine.AnimationClip animationClip, DG.Tweening.TweenCallback onComplete, Beyond.UI.UIConst.AnimationState newState, System.Single startPlayTime) { }
        private System.Void PlayWithTween(System.String stateName, DG.Tweening.TweenCallback onComplete, Beyond.UI.UIConst.AnimationState newState, System.Single startPlayTime) { }
        private System.Single GetCurPlayingTime() { }
        private Beyond.UI.LuaPanel get_panel() { }
        private System.Void PlayOpenAudio() { }
        private System.Void PlayCloseAudio() { }
        private System.Void ClearComponent() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006B
    public class UIAnimationTween
    {
        // Fields
        public static readonly Beyond.UI.UIAnimationTween.Options DEFAULT_OPTION;        // 0x0
        private DG.Tweening.Tween m_handler;        // 0x10
        private System.Single m_tweenValue;        // 0x18
        private UnityEngine.GameObject m_animTarget;        // 0x20
        private System.Single <clipLength>k__BackingField;        // 0x28

        // Methods
        private DG.Tweening.Tween get_handler() { }
        private System.Single get_tweenValue() { }
        private System.Single get_clipLength() { }
        private System.Void set_clipLength(System.Single value) { }
        private System.Void .ctor(UnityEngine.GameObject target, Beyond.UI.UIAnimationWrapper wrapper, System.String name) { }
        private System.Void .ctor(UnityEngine.GameObject target, Beyond.UI.UIAnimationWrapper wrapper, System.String name, Beyond.UI.UIAnimationTween.Options options) { }
        private System.Single GetValue() { }
        private System.Void _SetValue(Beyond.UI.UIAnimationWrapper wrapper, System.String name, System.Single value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006F
    public class UIAnimationSwitchTween : UISwitchTween
    {
        // Fields
        private Beyond.UI.UIAnimationWrapper m_animWrapper;        // 0x30
        private System.Boolean m_dontDisableGameObject;        // 0x38

        // Methods
        private System.Void .ctor(Beyond.UI.UIAnimationWrapper animWrapper) { }
        private Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfHide() { }
        private Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfShow() { }
        private System.Void BeforeShowEffect() { }
        private System.Void AfterHideEffect() { }
        private System.Void ResetToState(System.Boolean isShow) { }
        private System.Void _SetGameObjectActive(System.Boolean isActive) { }
        private System.Void <>iFixBaseProxy_BeforeShowEffect() { }
        private System.Void <>iFixBaseProxy_AfterHideEffect() { }
        private System.Void <>iFixBaseProxy_ResetToState(System.Boolean P0) { }

    }

    // TypeToken: 0x2000072
    public class UIArea : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IUIClearable, ILuaCallCSharp
    {
        // Fields
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onPointerEnter;        // 0x18
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onPointerExit;        // 0x20
        private System.Boolean m_pointerInArea;        // 0x28
        public UnityEngine.GameObject _highlightNode;        // 0x30

        // Methods
        private System.Boolean get_pointerInArea() { }
        private System.Void _SetHighlightNodeActive(System.Boolean active) { }
        private System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void ClearComponent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000073
    public class UIAutoCloseArea : TickableUIMono, IUIClearable, ILuaCallCSharp, IBindingGroupTarget
    {
        // Fields
        public static System.Boolean s_stopCheckShouldClose;        // 0x0
        public System.Collections.Generic.List<UnityEngine.RectTransform> fixedSafeAreas;        // 0x68
        public UnityEngine.RectTransform tmpSafeArea;        // 0x70
        public System.Boolean alsoBlockKeyBoardInput;        // 0x78
        private System.Boolean _includeInAutoCloseLayer;        // 0x79
        private UnityEngine.Camera m_fallbackUICamera;        // 0x80
        public UnityEngine.GameObject toggleObj;        // 0x88
        public Beyond.DisposedUnityEvent onTriggerAutoClose;        // 0x90
        private System.String _closeActionId;        // 0x98
        private System.Boolean _enableCloseActionOnController;        // 0xA0
        private Beyond.UI.UIAnimationWrapper m_animationWrapper;        // 0xA8
        private static System.Collections.Generic.LinkedList<UnityEngine.GameObject> s_autoCloseLayerList;        // 0x8
        private Beyond.UI.LuaPanel m_panel;        // 0xB0
        private System.Int32 <groupId>k__BackingField;        // 0xB8
        private Beyond.Input.IBindingGroupTarget <parentTarget>k__BackingField;        // 0xC0
        private System.Boolean m_bindingInit;        // 0xC8

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Boolean get_includeInAutoCloseLayer() { }
        private System.Void set_includeInAutoCloseLayer(System.Boolean value) { }
        private Beyond.UI.LuaPanel get_panel() { }
        private System.Void Start() { }
        private System.Void Reset() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void ChangeEnableCloseActionOnController(System.Boolean enabled) { }
        private System.Void CloseSelf() { }
        private System.Void TryCloseSelf() { }
        private System.Void OpenSelf(System.Boolean executeOnComplete) { }
        private System.Boolean ShouldClose() { }
        private System.Void ClearComponent() { }
        private System.Void _AutoCloseToggleObjWhenOut() { }
        private System.Void AddToAutoCloseLayer(UnityEngine.GameObject go) { }
        private System.Void RemoveFromAutoCloseLayer(UnityEngine.GameObject go) { }
        private System.Boolean IsTopAutoCloseLayer(UnityEngine.GameObject go) { }
        private UnityEngine.Camera _GetUICamera() { }
        private System.Int32 get_groupId() { }
        private System.Void set_groupId(System.Int32 value) { }
        private Beyond.Input.IBindingGroupTarget get_parentTarget() { }
        private System.Void set_parentTarget(Beyond.Input.IBindingGroupTarget value) { }
        private System.Boolean get_groupEnabled() { }
        private System.Void InitBinding() { }
        private System.Void _UpdateState() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x2000074
    public class UIBigLogo : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _rootNode;        // 0x18
        public Beyond.UI.UIImage _bigLogoImage;        // 0x20
        private UnityEngine.GameObject _stretchNode;        // 0x28
        public Beyond.UI.UIImage _stretchImageTop;        // 0x30
        public Beyond.UI.UIImage _stretchImageBottom;        // 0x38
        public Beyond.UI.UIImage _bg;        // 0x40
        public Beyond.UI.UIImage _originalImage;        // 0x48
        public Beyond.UI.UIImage _backgroundMask;        // 0x50
        public UnityEngine.CanvasGroup _originalImageMain;        // 0x58

        // Methods
        private System.Void SetBigLogoEditor(System.String bigLogoPath, System.Boolean useStretchImage, System.Boolean showOnTop, System.Boolean hideBackground, System.Boolean useOriginalImage) { }
        private System.Void ShowBigLogo(System.Boolean useStretchImage, System.Boolean showOnTop, System.Boolean useOriginalImage, System.Single originalImageScale) { }
        private System.Void SetBigLogoMask(UnityEngine.Color maskColor) { }
        private System.Void ClearBigLogoMask() { }
        private System.Void ClearBigLogo(System.Boolean showOnTop) { }
        private System.Void SetAlpha(System.Single alpha, System.Boolean showOnTop) { }
        private System.Void SetMaskAlpha(System.Single alpha) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000075
    public class UIBigRectButton : UIButton, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IScrollHandler
    {
        // Fields
        private Beyond.UI.UIBigRectHelper _bigRectHelper;        // 0x2D0

        // Methods
        private System.Void _TryThroughEventDataToBigRectTouchPanelRaycast(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> eventFunction) { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnPointerDown(UnityEngine.EventSystems.PointerEventData P0) { }
        private System.Void <>iFixBaseProxy_OnPointerUp(UnityEngine.EventSystems.PointerEventData P0) { }

    }

    // TypeToken: 0x2000076
    public class UIBigRectHelper : TickableUIMono, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private System.Boolean m_inited;        // 0x68
        private System.Boolean m_openTweenFinished;        // 0x69
        private Beyond.DisposedUnityEvent m_onOpenTweenFinished;        // 0x70
        private System.Single m_zoom;        // 0x78
        private System.Single m_zoomValue;        // 0x7C
        private UnityEngine.Vector2 m_oriSize;        // 0x80
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> m_zoomTween;        // 0x88
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> m_focusTween;        // 0x90
        private UnityEngine.Vector2 m_anchoredPosOffset;        // 0x98
        private System.Single m_horizontalOffset;        // 0xA0
        private System.Single m_verticalOffset;        // 0xA4
        private UnityEngine.Vector2 m_lastScale;        // 0xA8
        private UnityEngine.Vector2 m_nodesOffsetWithContainerNode;        // 0xB0
        private Beyond.UI.LuaPanel m_luaPanel;        // 0xB8
        private UnityEngine.RectTransform m_rootRectTransform;        // 0xC0
        private System.Single m_zoomRangeMin;        // 0xC8
        private System.Boolean m_useOverrideMinZoomRange;        // 0xCC
        private System.Single m_zoomRangeOverrideMin;        // 0xD0
        private Beyond.UI.UITouchPanel _touchPanel;        // 0xD8
        private UnityEngine.RectTransform _containerBigRectTransform;        // 0xE0
        private UnityEngine.RectTransform _nodes;        // 0xE8
        private System.Single _moveSpeed;        // 0xF0
        private System.Single _zoomSpeed;        // 0xF4
        private System.Single _zoomRangeMax;        // 0xF8
        private System.Boolean _needResetPositionAndScale;        // 0xFC
        private System.Boolean _needCenterZoomMobile;        // 0xFD
        private System.Collections.Generic.List<System.Single> _zoomThresholds;        // 0x100
        private Beyond.DisposedUnityEvent<System.Int32,System.Boolean> m_zoomEvent;        // 0x108
        private System.Single _zoomTweenTime;        // 0x110
        private System.Single _moveNodeXOffset;        // 0x114
        private System.Single _moveNodeYOffset;        // 0x118
        private System.Single _openZoomTweenTime;        // 0x11C
        private UnityEngine.AnimationCurve _openZoomCurve;        // 0x120
        private System.Single _focusNodeTime;        // 0x128
        private UnityEngine.AnimationCurve _focusNodeCurve;        // 0x130
        private System.Boolean _containerEdgeAlignLeft;        // 0x138
        private UnityEngine.RectOffset _padding;        // 0x140
        private System.Single _paddingBottomIncludeControllerHintBar;        // 0x148
        private System.Single _controllerContainerHorizontalMoveSpeed;        // 0x14C
        private System.Single _controllerContainerVerticalMoveSpeed;        // 0x150
        private System.Single _controllerZoomRate;        // 0x154
        private UnityEngine.GameObject _controllerZoomKeyHint;        // 0x158
        private System.Boolean _useFocusRect;        // 0x160
        private System.Boolean _useClickKeyHint;        // 0x161
        private UnityEngine.Transform _raycastRoot;        // 0x168
        private UnityEngine.RectTransform _controllerFocusRect;        // 0x170
        private System.Single _controllerFocusRectHorizontalMoveSpeed;        // 0x178
        private System.Single _controllerFocusRectVerticalMoveSpeed;        // 0x17C
        private System.Single _controllerFocusLeftBoundPadding;        // 0x180
        private System.Single _controllerFocusRightBoundPadding;        // 0x184
        private System.Single _controllerFocusBottomBoundPadding;        // 0x188
        private System.Single _controllerFocusTopBoundPadding;        // 0x18C
        private UnityEngine.Vector2 m_lastStickValue;        // 0x190
        private UnityEngine.EventSystems.PointerEventData m_controllerFocusEventData;        // 0x198
        private readonly System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> m_raycastResults;        // 0x1A0
        private UnityEngine.UI.Selectable m_lastHitSelectable;        // 0x1A8
        private System.Int32 m_bindingGroupId;        // 0x1B0
        private static System.String CLICK_ACTION_ID;        // 0x0
        private static System.String CLICK_NO_HINT_ACTION_ID;        // 0x0
        private static System.Single DELTA_TIME_TO_STICK_VALUE_RATIO;        // 0x0
        private System.Int32 <clickBindingId>k__BackingField;        // 0x1B4
        private System.Boolean <controllerMoveEnabled>k__BackingField;        // 0x1B8
        private System.Boolean <controllerZoomEnabled>k__BackingField;        // 0x1B9
        public readonly Beyond.DisposedUnityEvent onControllerMoveStart;        // 0x1C0
        public readonly Beyond.DisposedUnityEvent onControllerMoveStop;        // 0x1C8
        public readonly Beyond.DisposedUnityEvent onControllerZoom;        // 0x1D0
        public readonly Beyond.DisposedUnityEvent onControllerFocusEnterSelectable;        // 0x1D8
        public readonly Beyond.DisposedUnityEvent onControllerFocusExitSelectable;        // 0x1E0

        // Methods
        private Beyond.TickType get_tickOption() { }
        private Beyond.DisposedUnityEvent get_OnOpenTweenFinished() { }
        private System.Single get_zoomRangeMin() { }
        private Beyond.DisposedUnityEvent<System.Int32,System.Boolean> get_zoomEvent() { }
        private Beyond.UI.UITouchPanel get_touchPanel() { }
        private System.Void OnAwake() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void OnRelease() { }
        private System.Void _OnDrag(UnityEngine.Vector2 value) { }
        private System.Void ManuallyZoom(System.Single value, System.Boolean needTween) { }
        private System.Void _RefreshPivotPosition() { }
        private System.Void _OnZoom(System.Single value, System.Boolean needTween) { }
        private System.Void _SetZoomValueAndScale(System.Single value, System.Boolean needTween) { }
        private System.Void _SetScale(System.Boolean needTween, System.Single zoomTweenTime, UnityEngine.AnimationCurve curve, DG.Tweening.TweenCallback onFinish) { }
        private System.Void _GetContainerRectBounds(UnityEngine.Vector2& leftBottom, UnityEngine.Vector2& rightTop) { }
        private UnityEngine.Vector2 _GetAdjustedPosition(UnityEngine.Vector2 position) { }
        private System.Void _PosAdjust() { }
        private System.Void _RefreshPivotPositionToMousePosition() { }
        private System.Void _RefreshPivotPosition(UnityEngine.Vector3 targetScreenPosition) { }
        private System.Void _UpdatePositionOffsetAfterZoomed() { }
        private System.Void _TryAlignWhenInit() { }
        private System.Void Init() { }
        private System.Void FocusNode(System.Single nodeX, System.Single nodeY, DG.Tweening.TweenCallback onComplete) { }
        private System.Void FocusNode(UnityEngine.RectTransform nodeRect, System.Boolean needTween, DG.Tweening.TweenCallback onComplete) { }
        private System.Void ZoomToFullRect(DG.Tweening.TweenCallback onComplete) { }
        private System.Void ChangePaddingRight(System.Int32 right) { }
        private System.Void SetZoomRangeMax(System.Single maxValue) { }
        private System.Void OverrideZoomRangeMin(System.Single minValue) { }
        private System.Void SyncZoomValue(System.Single zoomValue, System.Boolean needTween) { }
        private System.Void GetZoomRange(System.Single& rangeMin, System.Single& rangeMax) { }
        private System.Single GetCurrentZoomValue() { }
        private System.Void ChangePivotPositionToTarget(UnityEngine.RectTransform target) { }
        private System.Void ResetPivotPositionToScreenCenter() { }
        private System.Void ClearComponent() { }
        private System.Void ClearAllTween() { }
        private System.Int32 get_clickBindingId() { }
        private System.Void set_clickBindingId(System.Int32 value) { }
        private System.Boolean get_controllerMoveEnabled() { }
        private System.Void set_controllerMoveEnabled(System.Boolean value) { }
        private System.Boolean get_controllerZoomEnabled() { }
        private System.Void set_controllerZoomEnabled(System.Boolean value) { }
        private System.Void _InitControllerBindings() { }
        private System.Boolean _GetIsControllerMoveEnabled() { }
        private System.Boolean _GetIsControllerZoomEnabled() { }
        private System.Void _ResetControllerState() { }
        private System.Void _TickRefreshController(System.Single deltaTime) { }
        private System.Void _TickRefreshControllerStickMove(System.Single deltaTime) { }
        private System.Void _RefreshControllerFocusRaycastResults(System.Boolean ignoreTouchPanel, UnityEngine.UI.Selectable& hitSelectable, Beyond.UI.UITouchPanel& hitTouchPanel) { }
        private System.Void _TickCheckControllerFocusRaycastTargets() { }
        private System.Void _OnControllerClick() { }
        private System.Void _TickRefreshControllerStickZoom(System.Single deltaTime) { }
        private System.Void _TickRefreshControllerZoomKeyHint() { }
        private System.Void .ctor() { }
        private System.Void <OnAwake>b__62_0(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void <OnAwake>b__62_1(System.Single zoomValue) { }
        private System.Void <_SetScale>b__71_0() { }
        private System.Void <Init>b__79_0() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x2000078
    public class UIBlendImage : UIImage
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.String,UnityEngine.Material> s_materials;        // 0x0
        private UnityEngine.Material m_originalMaterial;        // 0x218
        private System.Boolean m_initialized;        // 0x220

        // Methods
        private System.Void SetMaterialKey(System.String key) { }
        private System.Void SetColor(System.String materialId, UnityEngine.Color c) { }
        private System.Void SetTexture(System.String materialId, UnityEngine.Texture t) { }
        private System.Void ClearMaterialCache() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000079
    public class UIBlurMono : TickableUIMono
    {
        // Fields
        private UnityEngine.Canvas m_canvas;        // 0x68
        private Beyond.UI.LuaPanel m_panel;        // 0x70
        private System.Int32 m_sortingOrder;        // 0x78

        // Methods
        private Beyond.TickType get_tickOption() { }
        private UnityEngine.Canvas get_canvas() { }
        private Beyond.UI.LuaPanel get_panel() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void UpdateSortingOrder(System.Int32 order) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x200007A
    public class UIBlurRT : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.RawImage _rawImage;        // 0x18
        private System.Boolean _autoUpdate;        // 0x20
        private HG.Rendering.Runtime.RTExtractionType _rtExtractionType;        // 0x24
        private HG.Rendering.Runtime.RTExtractionDuration _rtExtractionDuration;        // 0x28
        private UnityEngine.Rendering.RTHandle m_rtHandle;        // 0x30
        private System.Boolean _needUseSceneColorPS;        // 0x38
        private UnityEngine.Rendering.RTHandle m_useSceneColorPsRtHandle;        // 0x40
        private System.Boolean m_curIsUseSceneColorPS;        // 0x48

        // Methods
        private UnityEngine.UI.RawImage get_rawImage() { }
        private System.Void Reset() { }
        private System.Void InitRT() { }
        private System.Void Register() { }
        private System.Void UnRegister() { }
        private System.Void UpdateRT() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void _Clear() { }
        private System.Void SetUseSceneColorPS(System.Boolean useSceneColorPS) { }
        private System.Void .ctor() { }
        private System.Void <Register>b__12_0() { }

    }

    // TypeToken: 0x200007B
    public class UIButton : Selectable, IPointerClickHandler, IEventSystemHandler, IBindingGroupTarget, IBindingView, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private System.String _audioPressStart;        // 0x180
        private System.String _audioOnClick;        // 0x188
        private System.String _audioRelease;        // 0x190
        private System.String _audioLongPress;        // 0x198
        private System.String _audioInvalid;        // 0x1A0
        private System.Boolean _noAudioWhenAutoTriggerOnClick;        // 0x1A8
        private static System.Single MIN_DRAG_DIST;        // 0x0
        private static System.Single DOUBLE_CLICK_MAX_INTERVAL;        // 0x0
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onClick;        // 0x1B0
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onDoubleClick;        // 0x1B8
        public System.Boolean _ignoreClickOnDrag;        // 0x1C0
        public System.Boolean _clickThrough;        // 0x1C1
        private System.Single _clickCd;        // 0x1C4
        private Beyond.LangKey _invalidClickLangKey;        // 0x1C8
        private System.Single m_lastValidClickTime;        // 0x1D8
        private System.Single m_lastClickTime;        // 0x1DC
        private System.Boolean _useClickAnimation;        // 0x1E0
        private UnityEngine.AnimationCurve _clickAnimationCurve;        // 0x1E8
        private System.Single _clickAnimationDuration;        // 0x1F0
        private UnityEngine.Vector3 m_oriScale;        // 0x1F4
        private UnityEngine.Coroutine m_clickCor;        // 0x200
        private System.Boolean m_scaled;        // 0x208
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onLongPress;        // 0x210
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onPressStart;        // 0x218
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onPressEnd;        // 0x220
        private System.Single _longPressTime;        // 0x228
        public System.Boolean _ignoreClickOnLongPress;        // 0x22C
        public Beyond.UI.UIImage longPressImg;        // 0x230
        private System.Single _longPressImgShowDelay;        // 0x238
        private System.Single _longPressMaxDragDist;        // 0x23C
        private System.Boolean m_pressDownWaitClick;        // 0x240
        private UnityEngine.Vector2 <startPressPos>k__BackingField;        // 0x244
        private System.Int32 <pressTouchId>k__BackingField;        // 0x24C
        private UnityEngine.Coroutine m_longPressCor;        // 0x250
        private System.Boolean m_triggeredLongPress;        // 0x258
        public System.Boolean noTextBtn;        // 0x259
        private Beyond.UI.UIText m_autoFindLabel;        // 0x260
        private Beyond.UI.UIText _label;        // 0x268
        private System.Int32 m_groupId;        // 0x270
        private System.Boolean m_bindingInit;        // 0x274
        private Beyond.Input.InputBindingGroupMonoTarget <parent>k__BackingField;        // 0x278
        private System.String m_customBindingViewLabelText;        // 0x280
        public System.String hintTextId;        // 0x288
        private readonly Beyond.DisposedUnityEvent <bindingViewUpdateEvent>k__BackingField;        // 0x290
        private UnityEngine.RectTransform _redDotTrans;        // 0x298
        private Beyond.UI.LuaPanel m_panel;        // 0x2A0
        private System.Int32 m_hoverBindingGroupId;        // 0x2A8
        public System.String clickHintTextId;        // 0x2B0
        public System.String longPressHintTextId;        // 0x2B8
        private Beyond.Input.ActionOnSetNaviTarget _actionOnSetNaviTarget;        // 0x2C0
        private System.Boolean _useNoHintAction;        // 0x2C4
        private System.Int32 <hoverConfirmBindingId>k__BackingField;        // 0x2C8

        // Methods
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void _NotifyIsHover(System.Boolean isHover) { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void _Press(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void _PlayClickAnimation(System.Boolean reverse) { }
        private System.Collections.IEnumerator _DoClickAnimation() { }
        private UnityEngine.Vector2 get_startPressPos() { }
        private System.Void set_startPressPos(UnityEngine.Vector2 value) { }
        private System.Int32 get_pressTouchId() { }
        private System.Void set_pressTouchId(System.Int32 value) { }
        private System.Single get_longPressTime() { }
        private UnityEngine.Vector2 get_curPressPos() { }
        private System.Boolean get_triggeredLongPress() { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Collections.IEnumerator _OnPress(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void _StopLongPressCor() { }
        private System.Void set_text(System.String value) { }
        private System.String get_text() { }
        private Beyond.UI.UIText get_label() { }
        private System.Void ClearComponent() { }
        private System.Boolean get_groupEnabled() { }
        private System.Int32 get_groupId() { }
        private Beyond.Input.IBindingGroupTarget get_parentTarget() { }
        private Beyond.Input.InputBindingGroupMonoTarget get_parent() { }
        private System.Void set_parent(Beyond.Input.InputBindingGroupMonoTarget value) { }
        private System.Void InitBinding() { }
        private System.Void OnInteractableChanged() { }
        private System.Void _UpdateState() { }
        private System.String get_bindingViewActionId() { }
        private System.String get_customBindingViewLabelText() { }
        private System.Void set_customBindingViewLabelText(System.String value) { }
        private System.String get_bindingViewLabelText() { }
        private System.String get_hintText() { }
        private Beyond.DisposedUnityEvent get_bindingViewUpdateEvent() { }
        private UnityEngine.RectTransform get_redDotTrans() { }
        private System.Boolean get_bindingEnabled() { }
        private Beyond.Input.BindingViewState get_bindingViewState() { }
        private System.String GetBindingViewActionId(Beyond.Input.BindingViewActionType actionType) { }
        private System.Void Beyond.Input.IBindingView.OnInputKeyDown() { }
        private System.Void Beyond.Input.IBindingView.OnInputKeyUp() { }
        private System.Void _OnUpdateKey() { }
        private System.String _GetUIButtonKeyHintActionId(Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> buttonEvent) { }
        private Beyond.UI.LuaPanel get_panel() { }
        private System.Int32 get_hoverBindingGroupId() { }
        private System.Void _RefreshHoverEnableNode(System.Boolean active) { }
        private System.Boolean GetMouseActionHints(System.String& clickHintTextId, System.String& longPressHintTextId) { }
        private System.Void OnNaviTargetEnabledAgain() { }
        private Beyond.Input.ActionOnSetNaviTarget get_actionOnSetNaviTarget() { }
        private System.Void _OnSetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode) { }
        private System.Int32 get_hoverConfirmBindingId() { }
        private System.Void set_hoverConfirmBindingId(System.Int32 value) { }
        private System.Void _InitActionOnSetNaviTarget() { }
        private System.Void _ToggleNaviInputBinding(System.Boolean active) { }
        private System.Void ChangeActionOnSetNaviTarget(Beyond.Input.ActionOnSetNaviTarget action) { }
        private System.Void .ctor() { }
        private System.Boolean Beyond.Input.IBindingView.get_interactable() { }
        private System.Void <InitBinding>b__81_0() { }
        private System.Void <InitBinding>b__81_1() { }
        private System.Void <InitBinding>b__81_2() { }
        private System.Void <InitBinding>b__81_3() { }
        private System.Void <InitBinding>b__81_4() { }
        private System.Void <_InitActionOnSetNaviTarget>b__130_0() { }
        private System.Void <>iFixBaseProxy_OnPointerDown(UnityEngine.EventSystems.PointerEventData P0) { }
        private System.Void <>iFixBaseProxy_OnPointerUp(UnityEngine.EventSystems.PointerEventData P0) { }
        private System.Void <>iFixBaseProxy_Awake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }
        private System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0) { }
        private System.Void <>iFixBaseProxy_OnInteractableChanged() { }
        private System.Void <>iFixBaseProxy__RefreshHoverEnableNode(System.Boolean P0) { }
        private System.Boolean <>iFixBaseProxy_GetMouseActionHints(System.String& P0, System.String& P1) { }
        private System.Void <>iFixBaseProxy_OnNaviTargetEnabledAgain() { }
        private System.Void <>iFixBaseProxy__OnSetAsNaviTarget(System.Boolean P0, System.Boolean P1) { }

    }

    // TypeToken: 0x200007E
    public struct CanvasMatchMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.CanvasMatchMode Width;        // 0x0
        public static Beyond.UI.CanvasMatchMode Height;        // 0x0

    }

    // TypeToken: 0x200007F
    public class UICanvasScaleHelper : MonoBehaviour, IScreenSizeListener, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private System.Boolean _useCustomStandardResolution;        // 0x18
        private UnityEngine.Vector2 _customStandardResolution;        // 0x1C
        private System.Single _customPCReferenceResolutionScale;        // 0x24
        private System.Collections.Generic.HashSet<UnityEngine.Canvas> m_canvasList;        // 0x28
        private System.Collections.Generic.HashSet<UnityEngine.UI.CanvasScaler> m_canvasScalerList;        // 0x30
        private System.Boolean m_isCanvasChanged;        // 0x38
        public System.Boolean isSingleCanvas;        // 0x39
        public UnityEngine.Camera uiCamera;        // 0x40
        public Beyond.DisposedUnityEvent onScreenSizeChanged;        // 0x48
        public Beyond.DisposedUnityEvent onCanvasChanged;        // 0x50

        // Methods
        private System.Single get_standardHorizontalResolution() { }
        private System.Single get_standardVerticalResolution() { }
        private System.Single get_standardResolutionScale() { }
        private System.Collections.Generic.HashSet<UnityEngine.UI.CanvasScaler> get_canvasScalerList() { }
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Void OnDestroy() { }
        private System.Void UpdateCanvas() { }
        private System.Void OnScreenSizeChanged(System.Int32 width, System.Int32 height) { }
        private System.Void AddCanvas(UnityEngine.Canvas c, UnityEngine.UI.CanvasScaler s) { }
        private System.Void RemoveCanvas(UnityEngine.Canvas c, UnityEngine.UI.CanvasScaler s) { }
        private System.Void _OnInputTypeChanged() { }
        private System.Void _CanvasOnWillRenderCanvases() { }
        private Beyond.UI.UICanvasScaleHelper.FWorldCanvasParams CalcWorldCanvasParams(UnityEngine.Camera camera, UnityEngine.Transform uiRoot, System.Boolean useLocalPos) { }
        private Beyond.UI.UICanvasScaleHelper.FScreenCanvasParams CalcScreenCanvasParams() { }
        private System.Single CalcCurrentScreenRatio(UnityEngine.Vector2& screenSize) { }
        private UnityEngine.Vector2 GetProperCanvasResolution() { }
        private System.Void ForceCanvasUpdate() { }
        private System.Void ClearComponent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000082
    public class UIColorGroup : NonDrawingGraphic
    {
        // Fields
        private UnityEngine.UI.Graphic[] _colorElements;        // 0xB8
        private UnityEngine.Color _color;        // 0xC0
        private System.Boolean m_isOperating;        // 0xD0
        private System.Collections.Generic.List<Beyond.UI.UIColorGroup.DynEle> m_dynList;        // 0xD8

        // Methods
        private UnityEngine.Color get_color() { }
        private System.Void set_color(UnityEngine.Color value) { }
        private System.Void AttachGraphic(UnityEngine.UI.Graphic graphic, System.Boolean useStaticColor) { }
        private System.Void AttachGraphicsWithGroup(System.Collections.Generic.List<UnityEngine.UI.Graphic> graphic, System.String groupId) { }
        private System.Void CrossFadeAlpha(System.Single alpha, System.Single duration, System.Boolean ignoreTimeScale) { }
        private System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha, System.Boolean useRGB) { }
        private System.Void CrossFadeColor(UnityEngine.Color targetColor, System.Single duration, System.Boolean ignoreTimeScale, System.Boolean useAlpha) { }
        private System.Void _ApplyOptToGraphics(Beyond.UI.UIColorGroup.GraphicOpt opt, Beyond.UI.UIColorGroup.CommonParams param) { }
        private System.Void _CrossFadeAlpha(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param) { }
        private System.Void _CrossFadeColorRGB(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param) { }
        private System.Void _CrossFadeColorAlpha(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param) { }
        private System.Void _SetColor(UnityEngine.UI.Graphic graphic, Beyond.UI.UIColorGroup.CommonParams param) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_set_color(UnityEngine.Color P0) { }
        private System.Void <>iFixBaseProxy_CrossFadeAlpha(System.Single P0, System.Single P1, System.Boolean P2) { }
        private System.Void <>iFixBaseProxy_CrossFadeColor(UnityEngine.Color P0, System.Single P1, System.Boolean P2, System.Boolean P3, System.Boolean P4) { }
        private System.Void <>iFixBaseProxy_CrossFadeColor(UnityEngine.Color P0, System.Single P1, System.Boolean P2, System.Boolean P3) { }

    }

    // TypeToken: 0x2000086
    public class UIControllerKeyIcon : MonoBehaviour
    {
        // Fields
        private System.String _keyIconName;        // 0x18
        private Beyond.UI.UIImage m_image;        // 0x20
        private static System.Collections.Generic.List<Beyond.UI.UIControllerKeyIcon> s_iconCache;        // 0x0
        private static System.Boolean s_initialized;        // 0x8

        // Methods
        private System.Void _TryStaticInit() { }
        private System.Void _OnControllerTypeChange(Beyond.DeviceInfo.ControllerType controllerType) { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void RefreshKeyIcon() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000087
    public class UICustomLayout : UIBehaviour
    {
        // Fields
        private UnityEngine.RectTransform _dragArea;        // 0x18
        public System.Collections.Generic.List<Beyond.UI.UICustomLayoutHandle> layoutHandles;        // 0x20
        private ZSimpleJSON.JSONArray m_eventLog;        // 0x28

        // Methods
        private UnityEngine.RectTransform get_dragArea() { }
        private System.Void Awake() { }
        private System.Boolean IsDirty() { }
        private System.Void ResetToDefault(System.Boolean saveChanges) { }
        private System.Void Save(System.Int32 ratio) { }
        private System.Void _LogEvent(System.Collections.Generic.Dictionary<Beyond.UI.UICustomLayoutElement,Beyond.UI.UICustomLayoutElement.LayoutData> layoutDataMap) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Awake() { }

    }

    // TypeToken: 0x2000088
    public class UICustomLayoutElement : UIBehaviour, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private System.Int32 _verNum;        // 0x18
        private System.String _elementKey;        // 0x20
        private UnityEngine.Transform _overrideScaleTransform;        // 0x28
        private UnityEngine.CanvasGroup _overrideCanvasGroup;        // 0x30
        private UnityEngine.RectTransform _overrideHighlightRect;        // 0x38
        public Beyond.DisposedUnityEvent onLayoutDataLoaded;        // 0x40
        private Beyond.UI.LuaPanel m_panel;        // 0x48
        private System.Single m_scale;        // 0x50
        private System.Single m_alpha;        // 0x54
        private UnityEngine.Vector2 m_position;        // 0x58
        private Beyond.UI.UICustomLayoutElement.LayoutType m_layoutType;        // 0x60
        private System.Single m_defaultScale;        // 0x64
        private System.Single m_defaultAlpha;        // 0x68
        private UnityEngine.Vector2 m_defaultPosition;        // 0x6C
        private UnityEngine.RectTransform m_rectTransform;        // 0x78

        // Methods
        private System.String get_elementKey() { }
        private UnityEngine.RectTransform get_highlightRect() { }
        private System.Single get_scale() { }
        private System.Void set_scale(System.Single value) { }
        private System.Single get_alpha() { }
        private System.Void set_alpha(System.Single value) { }
        private UnityEngine.Vector2 get_position() { }
        private System.Void set_position(UnityEngine.Vector2 value) { }
        private Beyond.UI.UICustomLayoutElement.LayoutType get_layoutType() { }
        private System.Void set_layoutType(Beyond.UI.UICustomLayoutElement.LayoutType value) { }
        private Beyond.UI.LuaPanel get_panel() { }
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Void OnDestroy() { }
        private System.Void ResetToDefault() { }
        private System.Void _ApplyPosition() { }
        private System.Void _ApplyAlpha() { }
        private System.Void _ApplyScale() { }
        private System.Void _SetDefaultValues() { }
        private System.String GetElementKeyWithRatio(System.Int32 ratio) { }
        private System.Boolean _CheckElementKeyIsValid() { }
        private System.Boolean SaveData(Beyond.UI.UICustomLayoutElement.LayoutData& layoutData, System.Boolean isResetToDefault, System.Int32 ratio) { }
        private System.Void LoadData() { }
        private System.Void _OnHudLayoutSaved() { }
        private UnityEngine.Vector2 _GetMarginSize() { }
        private System.Void ClearComponent() { }
        private System.Void RefreshAll() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Awake() { }
        private System.Void <>iFixBaseProxy_Start() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x200008B
    public class UICustomLayoutHandle : UIBehaviour, IPointerClickHandler, IEventSystemHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IUIClearable, ILuaCallCSharp
    {
        // Fields
        public Beyond.DisposedUnityEvent onClick;        // 0x18
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onBeginDrag;        // 0x20
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onDrag;        // 0x28
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onEndDrag;        // 0x30
        public System.String hintTextId;        // 0x38
        private Beyond.UI.LuaPanel m_panel;        // 0x40
        private System.Single m_scale;        // 0x48
        private System.Single m_alpha;        // 0x4C
        private UnityEngine.Vector2 m_position;        // 0x50
        private Beyond.UI.UICustomLayoutElement.LayoutType m_layoutType;        // 0x58
        private UnityEngine.Vector2 m_defaultPosition;        // 0x5C
        private System.Boolean m_isChanged;        // 0x64
        private System.Boolean m_isResetToDefault;        // 0x65
        private UnityEngine.RectTransform m_rectTransform;        // 0x68
        private UnityEngine.RectTransform m_parentRectTransform;        // 0x70
        private Beyond.UI.UICustomLayoutElement m_element;        // 0x78
        private Beyond.UI.UICustomLayout m_layout;        // 0x80
        private UnityEngine.Vector2 m_dragPosMin;        // 0x88
        private UnityEngine.Vector2 m_dragPosMax;        // 0x90
        private UnityEngine.Vector3[] m_dragAreaCorners;        // 0x98
        private UnityEngine.Vector3[] m_highlightCorners;        // 0xA0
        private System.Boolean m_isPosRangeDirty;        // 0xA8
        private UnityEngine.Vector2 m_dragOffset;        // 0xAC

        // Methods
        private System.Single get_scale() { }
        private System.Void set_scale(System.Single value) { }
        private System.Single get_alpha() { }
        private System.Void set_alpha(System.Single value) { }
        private UnityEngine.Vector2 get_position() { }
        private System.Void set_position(UnityEngine.Vector2 value) { }
        private Beyond.UI.UICustomLayoutElement.LayoutType get_layoutType() { }
        private System.Void set_layoutType(Beyond.UI.UICustomLayoutElement.LayoutType value) { }
        private Beyond.UI.LuaPanel get_panel() { }
        private Beyond.UI.UICustomLayoutElement get_Element() { }
        private System.Void Awake() { }
        private System.Void OnDestroy() { }
        private System.Void _OnElementDataLoaded() { }
        private System.Void _CalculatePositionRange() { }
        private System.Void _ApplyPosition() { }
        private System.Void _ApplyAlpha() { }
        private System.Void _ApplyScale() { }
        private System.Void _ApplyLayoutType() { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Boolean Save(Beyond.UI.UICustomLayoutElement.LayoutData& layoutData, System.Int32 ratio) { }
        private System.Void ResetToDefault() { }
        private System.Boolean IsDirty() { }
        private System.Void _SetChanged(System.Boolean changed) { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void _OnSystemDisplaySizeChanged() { }
        private System.Void ClearComponent() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Awake() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x200008C
    public class UIDialogText : TickableUIMono
    {
        // Fields
        protected Beyond.UI.UIText _uiText;        // 0x68
        private System.Single _textRevealSpeed;        // 0x70
        private System.Boolean _autoPlay;        // 0x74
        private Beyond.UI.UIDialogText.UpdateMode _updateMode;        // 0x78
        private System.Boolean _useAutoScroll;        // 0x7C
        private System.Single _originalHeight;        // 0x80
        private System.Boolean _useAspectRatio;        // 0x84
        private System.Single _autoScrollSpeed;        // 0x88
        private System.Single _autoWaitTime;        // 0x8C
        private System.Single _maxAspectRatio;        // 0x90
        private System.Single _minAspectRatio;        // 0x94
        private System.Single _maxAspectRatioScrollSpeed;        // 0x98
        private System.Single _minAspectRatioScrollSpeed;        // 0x9C
        private System.Single _maxAspectRatioWaitTime;        // 0xA0
        private System.Single _minAspectRatioWaitTime;        // 0xA4
        private System.Boolean m_playing;        // 0xA8
        private System.Int32 m_revealedCharNum;        // 0xAC
        private System.Int32 m_totalCharNum;        // 0xB0
        private System.Single m_timeToNextCharacter;        // 0xB4
        protected System.String m_curText;        // 0xB8
        private System.Boolean m_hasScrolled;        // 0xC0
        private System.Single m_startTime;        // 0xC4
        private System.Boolean m_scrollHasEnd;        // 0xC8
        private System.Boolean m_needAutoScroll;        // 0xC9
        private UnityEngine.Vector2 m_targetPos;        // 0xCC
        private UnityEngine.Vector2 m_originalPos;        // 0xD4
        private System.Single m_percent;        // 0xDC
        private System.Boolean m_locked;        // 0xE0

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Boolean get_useAspectRatio() { }
        private System.Boolean get_notUseAspectRatio() { }
        private System.Boolean get_playing() { }
        private Beyond.UI.UIText get_uiText() { }
        private System.Int32 get_totalCharacterNum() { }
        private System.Void OnAwake() { }
        private System.Void Start() { }
        private System.Void OnDisable() { }
        private System.Void OnEnable() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void OnVisibleCharactersChanged(System.Int32 count) { }
        private System.Single GetScrollSpeed() { }
        private System.Single GetAutoWaitTime() { }
        private System.Void _UpdateTextAuto() { }
        private System.Void _TryAutoScroll() { }
        private System.Void RefreshAutoScrollData() { }
        private System.Void SetText(System.String text) { }
        private System.Void _RefreshPosY() { }
        private System.Void SeekToEnd() { }
        private System.Void RefreshText() { }
        private System.Void Play() { }
        private System.Void ResetPlay() { }
        private System.Void StopPlay() { }
        private System.Void ManualUpdateByPercent(System.Single percent) { }
        private System.Void ManualUpdateByTime(System.Single time) { }
        private System.Single GetDisplayAllCharactersTime() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x200008E
    public class UIDialogTextWithCursor : UIDialogText
    {
        // Fields
        private System.Single _textGapTime;        // 0xE8
        private Beyond.UI.UIAnimationWrapper _cursorAnimation;        // 0xF0
        private UnityEngine.RectTransform _cursorLoopHide;        // 0xF8
        private UnityEngine.RectTransform _cursorGroup;        // 0x100
        private Beyond.UI.UIImage _background;        // 0x108
        public System.Boolean isLastTextLine;        // 0x110
        private System.Int32 m_lastCount;        // 0x114

        // Methods
        private System.Void ResetPlay() { }
        private System.Void OnVisibleCharactersChanged(System.Int32 count) { }
        private System.Single GetDisplayAllCharactersTime() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_ResetPlay() { }
        private System.Void <>iFixBaseProxy_OnVisibleCharactersChanged(System.Int32 P0) { }
        private System.Single <>iFixBaseProxy_GetDisplayAllCharactersTime() { }

    }

    // TypeToken: 0x200008F
    public class EasyUIOptionData
    {
        // Fields
        public System.Int32 index;        // 0x10
        public System.String optionIcon;        // 0x18
        public System.String optionText;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000090
    public class UIDialogTimelineOptionCell : MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIImage _optionIcon;        // 0x18
        private Beyond.UI.UIText _optionText;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000091
    public class UIDialogTimelineText : MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIDialogText _dialogText;        // 0x18
        private Beyond.UI.UIText _actorName;        // 0x20
        private UnityEngine.GameObject _waitNode;        // 0x28
        private Beyond.UI.UIAnimationWrapper _radioNode;        // 0x30
        private Beyond.UI.UIImage _iconImage;        // 0x38
        private Beyond.UI.UIImage _iconBlueMask;        // 0x40
        public Beyond.UI.UIText centerText;        // 0x48
        private System.String m_currentRadioIcon;        // 0x50
        private UnityEngine.CanvasGroup m_canvasGroup;        // 0x58

        // Methods
        private UnityEngine.CanvasGroup get_canvasGroup() { }
        private Beyond.UI.UIDialogText get_dialogText() { }
        private Beyond.UI.UIText get_actorName() { }
        private UnityEngine.GameObject get_waitNode() { }
        private System.Void UpdateAlpha(System.Single alpha) { }
        private System.Void SetRadioIcon(System.Boolean useRadio, System.String radioIcon) { }
        private System.Void _ClearRadioIcon() { }
        private System.Void .ctor() { }
        private System.Void <_ClearRadioIcon>b__19_0() { }

    }

    // TypeToken: 0x2000092
    public class UIDrag : UIBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private UnityEngine.RectTransform _dragArea;        // 0x18
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onBeginDrag;        // 0x20
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onEndDrag;        // 0x28
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onDrag;        // 0x30
        private UnityEngine.RectTransform m_rectTransform;        // 0x38
        private UnityEngine.RectTransform m_parentRectTransform;        // 0x40
        private UnityEngine.Vector2 m_dragOffset;        // 0x48
        private UnityEngine.Vector2 m_dragPosMin;        // 0x50
        private UnityEngine.Vector2 m_dragPosMax;        // 0x58
        private UnityEngine.Vector3[] m_dragAreaCorners;        // 0x60
        private UnityEngine.Canvas m_canvas;        // 0x68

        // Methods
        private System.Void Awake() { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void ApplyDragArea() { }
        private System.Void ClearComponent() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Awake() { }

    }

    // TypeToken: 0x2000093
    public class UIDragHandler : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private System.Int32 _dragThreshold;        // 0x18
        private UnityEngine.Vector2 m_startPressPos;        // 0x1C
        private System.Boolean m_isDragThresholdMet;        // 0x24
        private System.Boolean m_isDragging;        // 0x25
        public Beyond.UI.UIButton button;        // 0x28
        public System.Boolean ignoreDragOnLongPress;        // 0x30
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onBeginDrag;        // 0x38
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onDrag;        // 0x40
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onEndDrag;        // 0x48

        // Methods
        private System.Int32 get_dragThreshold() { }
        private System.Void ClearComponent() { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000094
    public class UIDragItem : UIBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IUIClearable, ILuaCallCSharp
    {
        // Fields
        public static UnityEngine.RectTransform s_commonDragObjectParent;        // 0x0
        private XLua.LuaTable <luaTable>k__BackingField;        // 0x18
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onBeginDragEvent;        // 0x20
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onDragEvent;        // 0x28
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onDragEventWhenCantStartDrag;        // 0x30
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onEndDragEvent;        // 0x38
        public UnityEngine.Events.UnityEvent<UnityEngine.GameObject,UnityEngine.GameObject> onUpdateDragObject;        // 0x40
        public System.Boolean canStartDrag;        // 0x48
        private System.Boolean _endDragOnDisable;        // 0x49
        public System.Boolean disableDrag;        // 0x4A
        private System.Boolean _isInScrollList;        // 0x4B
        private System.Boolean _hideDragObjectInScrollList;        // 0x4C
        private UnityEngine.GameObject _dragPrefab;        // 0x50
        private UnityEngine.RectTransform _dragObjectParent;        // 0x58
        public UnityEngine.Vector2 dragPivot;        // 0x60
        private UnityEngine.UI.Image _draggingHintImage;        // 0x68
        private UnityEngine.CanvasGroup _draggingHintCanvasGroup;        // 0x70
        private UnityEngine.GameObject _draggingHintObject;        // 0x78
        private Beyond.UI.LuaPanel m_panel;        // 0x80
        private UnityEngine.RectTransform m_rect;        // 0x88
        private Beyond.UI.UIScrollRect m_scrollRect;        // 0x90
        private System.Boolean m_isInScroll;        // 0x98
        private UnityEngine.GameObject m_curDragObj;        // 0xA0
        private System.Boolean m_inDragging;        // 0xA8
        private UnityEngine.Color m_draggingHintImageOriColor;        // 0xAC
        private UnityEngine.Coroutine m_dragOnDisableCoroutine;        // 0xC0

        // Methods
        private XLua.LuaTable get_luaTable() { }
        private System.Void set_luaTable(XLua.LuaTable value) { }
        private System.Boolean get_inDragging() { }
        private Beyond.UI.LuaPanel get_panel() { }
        private UnityEngine.RectTransform get_m_dragParentRect() { }
        private UnityEngine.GameObject get_curDragObj() { }
        private System.Void Awake() { }
        private System.Void Start() { }
        private System.Void OnDisable() { }
        private System.Collections.IEnumerator _ContinueDragOnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void OnEnable() { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void _StopDragView() { }
        private System.Void ClearComponent() { }
        private System.Void ClearEvents() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Awake() { }
        private System.Void <>iFixBaseProxy_Start() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }

    }

    // TypeToken: 0x2000096
    public class UIDropdown : Selectable, IPointerClickHandler, IEventSystemHandler, IUIClearable, ILuaCallCSharp, IBindingGroupTarget
    {
        // Fields
        public UnityEngine.Events.UnityEvent<System.Int32> onSelectCell;        // 0x180
        public UnityEngine.Events.UnityEvent<System.Int32,Beyond.UI.UIDropdownOption,System.Boolean> onUpdateCell;        // 0x188
        public UnityEngine.Events.UnityEvent<System.Int32,Beyond.UI.UIDropdown> onUpdateCaption;        // 0x190
        public UnityEngine.Events.UnityEvent<System.Boolean> onToggleOptList;        // 0x198
        public System.Func<System.Int32,System.Int32,System.Boolean> onValidateSelectCell;        // 0x1A0
        public Beyond.UI.UIText captionText;        // 0x1A8
        public Beyond.UI.UIImage captionIcon;        // 0x1B0
        private System.Int32 <selectedIndex>k__BackingField;        // 0x1B8
        private System.Int32 <optionCount>k__BackingField;        // 0x1BC
        private System.Boolean <isListActive>k__BackingField;        // 0x1C0
        private Beyond.UI.UIDropdownOption _optionTemplate;        // 0x1C8
        private UnityEngine.Transform _arrowImageTrans;        // 0x1D0
        private UnityEngine.RectTransform _listContainer;        // 0x1D8
        private System.Single _listContainerMaxHeight;        // 0x1E0
        private System.Single _animationTime;        // 0x1E4
        private UnityEngine.RectTransform _selfArea;        // 0x1E8
        private UnityEngine.RectTransform _maskRect;        // 0x1F0
        private System.Boolean _autoCloseOnSelect;        // 0x1F8
        private System.String _audioToggleOn;        // 0x200
        private System.String _audioToggleOff;        // 0x208
        private System.String _audioInvalid;        // 0x210
        private System.String _audioNavigation;        // 0x218
        private System.Collections.Generic.List<Beyond.UI.UIDropdownOption> m_options;        // 0x220
        private Beyond.UI.LuaPanel m_panel;        // 0x228
        private UnityEngine.UI.LayoutGroup m_content;        // 0x230
        private UnityEngine.Camera m_fallbackUICamera;        // 0x238
        private Beyond.UI.UIScrollRect m_listScrollRect;        // 0x240
        private UnityEngine.CanvasGroup m_listContainerCanvasGroup;        // 0x248
        public System.String openDropDownActionId;        // 0x250
        private System.Int32 m_bindingGroupId;        // 0x258
        private System.Int32 m_naviBindingGroupId;        // 0x25C
        private Beyond.UI.LuaPanel m_luaPanel;        // 0x260
        private Beyond.UI.UISelectableNaviGroup m_listNaviGroup;        // 0x268
        private Beyond.Input.IBindingGroupTarget <parentTarget>k__BackingField;        // 0x270

        // Methods
        private System.Int32 get_selectedIndex() { }
        private System.Void set_selectedIndex(System.Int32 value) { }
        private System.Int32 get_optionCount() { }
        private System.Void set_optionCount(System.Int32 value) { }
        private System.Boolean get_isListActive() { }
        private System.Void set_isListActive(System.Boolean value) { }
        private Beyond.UI.LuaPanel get_panel() { }
        private System.Void Awake() { }
        private System.Void _NotifyIsHover(System.Boolean isHover) { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void Init(UnityEngine.Events.UnityAction<System.Int32,Beyond.UI.UIDropdownOption,System.Boolean> onUpdateCell, UnityEngine.Events.UnityAction<System.Int32> onSelectCell, UnityEngine.Events.UnityAction<System.Int32,Beyond.UI.UIDropdown> onUpdateCaption) { }
        private System.Void ToggleOptions(System.Boolean activeList) { }
        private System.Void _ToggleOptions(System.Boolean activeList, System.Boolean isInit) { }
        private System.Void Update() { }
        private System.Void SetSelected(System.Int32 index, System.Boolean forceUpdate, System.Boolean needNotifySelect, System.Boolean validateSelect) { }
        private System.Void ScrollToSelected() { }
        private System.Void Refresh(System.Int32 count, System.Int32 newSelectedIndex, System.Boolean needNotifySelect) { }
        private System.Void ClearComponent() { }
        private UnityEngine.Camera _GetUICamera() { }
        private System.Int32 get_groupId() { }
        private Beyond.Input.IBindingGroupTarget get_parentTarget() { }
        private System.Void set_parentTarget(Beyond.Input.IBindingGroupTarget value) { }
        private System.Boolean get_groupEnabled() { }
        private System.Void _InitBinding() { }
        private System.Void _ControllerToggle() { }
        private System.Void _ControllerCancel() { }
        private UnityEngine.UI.Selectable _GetDefaultNaviTarget() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Awake() { }
        private System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0) { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x2000099
    public class UIDropdownOption : MonoBehaviour
    {
        // Fields
        public Beyond.UI.UIButton button;        // 0x18
        public Beyond.UI.UIText label;        // 0x20
        public Beyond.UI.UIText secondLabel;        // 0x28
        public Beyond.UI.UIImage icon;        // 0x30
        public UnityEngine.GameObject selectedNode;        // 0x38
        public UnityEngine.GameObject notSelectedNode;        // 0x40
        public Beyond.UI.UIState.UIStateController stateController;        // 0x48
        public UnityEngine.GameObject stripeNode;        // 0x50
        public System.Boolean stripeIsTop;        // 0x58

        // Methods
        private System.Void SetText(System.String text) { }
        private System.Void SetState(System.String stateName) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009A
    public struct CommonDropHintType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.CommonDropHintType None;        // 0x0
        public static Beyond.UI.CommonDropHintType Square;        // 0x0
        public static Beyond.UI.CommonDropHintType Circle;        // 0x0

    }

    // TypeToken: 0x200009B
    public class UIDropItem : UIBehaviour, IDropHandler, IEventSystemHandler, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private XLua.LuaTable <luaTable>k__BackingField;        // 0x18
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onDropEvent;        // 0x20
        public UnityEngine.Events.UnityEvent<System.Boolean> onToggleHighlight;        // 0x28
        public System.Action onDestroy;        // 0x30
        public Beyond.UI.CommonDropHintType commonDropHintType;        // 0x38
        private UnityEngine.GameObject _highlightHint;        // 0x40
        private System.Boolean _scaleWhenHighlight;        // 0x48
        private System.Single _scaleWhenActive;        // 0x4C
        private System.Boolean _useUIState;        // 0x50
        private Beyond.UI.UIStyleByState.StateConfig _stateConfigNormal;        // 0x58
        private Beyond.UI.UIStyleByState.StateConfig _stateConfigHilight;        // 0x60
        private UnityEngine.UI.Selectable m_selectable;        // 0x68
        private UnityEngine.RectTransform m_rectTransform;        // 0x70
        private System.Single m_oriScale;        // 0x78
        private System.Boolean m_isInHighlight;        // 0x7C

        // Methods
        private XLua.LuaTable get_luaTable() { }
        private System.Void set_luaTable(XLua.LuaTable value) { }
        private System.Void ClearEvents() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void ToggleHighlight(System.Boolean active, System.Boolean forceToggle) { }
        private System.Void OnDrop(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void ClearComponent() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Awake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x200009C
    public class UIElementFollower : TickableUIMono
    {
        // Fields
        private System.Boolean _followMouse;        // 0x68
        public System.Boolean followFixedPos;        // 0x69
        private UnityEngine.Transform _targetTransform;        // 0x70
        private UnityEngine.Vector3 _followPosition;        // 0x78
        private System.Boolean _changeScale;        // 0x84
        private UnityEngine.AnimationCurve _scaleCurve;        // 0x88
        public UnityEngine.Vector3 displayOffset;        // 0x90
        public UnityEngine.Vector3 displayUIOffset;        // 0x9C
        private static readonly Unity.Profiling.ProfilerMarker UPDATE_POSITION_MARKER;        // 0x0
        public Beyond.DisposedUnityEvent onExitScreen;        // 0xA8
        public Beyond.DisposedUnityEvent onEnterScreen;        // 0xB0
        private System.Boolean <inScreen>k__BackingField;        // 0xB8
        private Beyond.UI.LuaPanel m_panel;        // 0xC0
        private UnityEngine.RectTransform m_rectTransform;        // 0xC8

        // Methods
        private Beyond.TickType get_tickOption() { }
        private UnityEngine.Vector3 get_followPosition() { }
        private System.Void set_followPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Transform get_targetTransform() { }
        private System.Void set_targetTransform(UnityEngine.Transform value) { }
        private System.Void set_inScreen(System.Boolean value) { }
        private System.Boolean get_inScreen() { }
        private Beyond.UI.LuaPanel get_panel() { }
        private System.Void OnAwake() { }
        private System.Void OnEnable() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void UpdatePosition() { }
        private System.Void UpdatePosition(UnityEngine.Vector3 worldPos) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x200009D
    public class UIExtendScrollRect : MonoBehaviour, IScrollHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        // Fields
        public Beyond.UI.UIScrollRect baseScrollRect;        // 0x18
        private System.Boolean _enableDrag;        // 0x20
        private Beyond.UI.UIScrollList _extendScrollList;        // 0x28

        // Methods
        private System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009E
    public interface IUIFoldoutComp
    {
        // Methods
        private System.Boolean get_defaultFoldOut() { }
        private System.Void Refresh(System.Int32 index) { }
        private System.Void OnFoldOut(System.Boolean fastMode) { }
        private System.Void OnFoldIn(System.Boolean fastMode) { }

    }

    // TypeToken: 0x200009F
    public class UIFoldoutComponent : MonoBehaviour, IUIFoldoutComp
    {
        // Fields
        protected UnityEngine.GameObject _foldContent;        // 0x18
        protected Beyond.UI.UINonUnifiedScrollList _nonUnifiedScrollList;        // 0x20
        public System.Single foldInSize;        // 0x28
        public System.Single duration;        // 0x2C
        public DG.Tweening.Ease easeType;        // 0x30
        protected System.Boolean m_isFoldOut;        // 0x34
        private DG.Tweening.Tweener m_tween;        // 0x38
        protected System.Int32 m_index;        // 0x40

        // Methods
        private System.Void Refresh(System.Int32 index) { }
        private System.Boolean get_defaultFoldOut() { }
        private System.Void OnFoldOut(System.Boolean fastMode) { }
        private System.Void OnFoldIn(System.Boolean fastMode) { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A2
    public class UIGraphicAnimation : TickableUIMono
    {
        // Fields
        private static System.Int32 s_vfxMainTextSTId;        // 0x0
        private static System.Int32 s_tintColorAlpha;        // 0x4
        private UnityEngine.UI.MaskableGraphic _graphic;        // 0x68
        private UnityEngine.Material _material;        // 0x70
        private System.Single _alpha;        // 0x78
        private UnityEngine.Vector2 _scale;        // 0x7C
        private UnityEngine.Material m_materialInstance;        // 0x88

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void OnAwake() { }
        private System.Void OnRelease() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void _Init() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_OnRelease() { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000A3
    public class UIGridLayoutGroup : GridLayoutGroup
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A4
    public class UIGridLayoutNaviWrapper : UIBehaviour, IScrollListNaviWrapper
    {
        // Fields
        private UnityEngine.UI.GridLayoutGroup _gridLayoutGroup;        // 0x18
        private UnityEngine.UI.LayoutGroup _layoutGroup;        // 0x20
        private Beyond.UI.UIGridLayoutNaviWrapper.WrapMode _wrapMode;        // 0x28
        private Beyond.UI.UIScrollRect _scrollRect;        // 0x30
        private Beyond.UI.UISelectableNaviGroup _naviGroup;        // 0x38
        private System.Boolean _enableCircleWrapNavigation;        // 0x40
        private System.Boolean m_isInited;        // 0x41
        private System.Boolean m_isVertical;        // 0x42
        private UnityEngine.UI.LayoutGroup m_layoutGroup;        // 0x48
        private System.Collections.Generic.List<UnityEngine.UI.Selectable> m_wrapNaviSelectables;        // 0x50

        // Methods
        private System.Void _InitIfNot() { }
        private System.Void Start() { }
        private System.Boolean TryWrapNavigate(UnityEngine.UI.NaviDirection dir) { }
        private System.Void _InitWrapNavigation() { }
        private System.Void _NaviGridLayout(UnityEngine.UI.NaviDirection dir) { }
        private System.Boolean _NaviGridLayoutImpl(UnityEngine.UI.NaviDirection dir, System.Boolean enableCircleWrapNavigation) { }
        private System.Boolean _NaviGridLayoutInit(System.Boolean isBefore, System.Boolean enableCircleWrapNavigation) { }
        private System.Boolean _NaviChildren(System.Int32 curIndex, System.Int32 childCount, System.Boolean isBefore, System.Boolean enableCircleWrapNavigation) { }
        private UnityEngine.UI.Selectable _FindValidSelectable(System.Boolean isBefore) { }
        private System.Void _SetCircleWrapScroll(System.Boolean isBefore) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Start() { }

    }

    // TypeToken: 0x20000A6
    public class UIGyroscopeEffect : TickableUIMono
    {
        // Fields
        public System.Boolean enableDetect;        // 0x68
        public System.Single mobileGravityScaler;        // 0x6C
        public Beyond.UI.UIGyroscopeEffect.Param x;        // 0x70
        public Beyond.UI.UIGyroscopeEffect.Param y;        // 0x78
        public DG.Tweening.Ease ease;        // 0x80
        public System.Single time;        // 0x84
        private Cinemachine.CinemachineVirtualCamera m_vcam;        // 0x88
        private Beyond.UI.CinemachineGyroscopeEffect m_vcamGyroscopeEffect;        // 0x90
        private System.Boolean m_isVcamMode;        // 0x98
        private System.Single m_baseGravityY;        // 0x9C
        private System.Single m_baseGravityYAccumulatedTime;        // 0xA0
        private System.Single m_lastGravityY;        // 0xA4
        public DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion,UnityEngine.Quaternion,DG.Tweening.Plugins.Options.NoOptions> handler;        // 0xA8
        public DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> tween;        // 0xB0

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void OnAwake() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void OnRelease() { }
        private System.Void .ctor() { }
        private UnityEngine.Vector3 <Tick>b__18_0() { }
        private System.Void <Tick>b__18_1(UnityEngine.Vector3 value) { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x20000A8
    public class UIHighlightMask : TickableUIMono
    {
        // Fields
        private UnityEngine.RectTransform _up;        // 0x68
        private UnityEngine.RectTransform _down;        // 0x70
        private UnityEngine.RectTransform _left;        // 0x78
        private UnityEngine.RectTransform _right;        // 0x80
        private UnityEngine.RectTransform m_rect;        // 0x88
        private Beyond.UI.LuaPanel m_panel;        // 0x90

        // Methods
        private Beyond.TickType get_tickOption() { }
        private Beyond.UI.LuaPanel get_panel() { }
        private System.Void OnAwake() { }
        private System.Void OnEnable() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void TrySyncRect() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000A9
    public class UIImage : Image
    {
        // Fields
        private System.Int32 _atlasHandleId;        // 0x190
        private Beyond.UI.UIAtlasManager.UIAtlasHandle m_atlasHandle;        // 0x194
        private System.Action m_onEnableRuntimeAtlas;        // 0x1B8
        private Beyond.UI.LuaPanel m_panel;        // 0x1C0
        private System.Boolean m_hasBeenEnabled;        // 0x1C8
        private System.String m_cachedSpritePath;        // 0x1D0
        protected Beyond.Resource.FAssetProxyHandle m_spriteResHandle;        // 0x1D8
        protected Beyond.Resource.FAssetProxyHandle m_matResHandle;        // 0x1EC
        public static System.String SPRITE_PATH_FORMAT;        // 0x0
        public static System.String SPRITE_ROOT_PATH_FORMAT;        // 0x0
        public System.Boolean enableAutoImgUsePathReference;        // 0x200
        public System.Boolean imgUsePathReference;        // 0x201
        public System.String imgRefPath;        // 0x208
        private System.Boolean m_imgIsPathReference;        // 0x210

        // Methods
        private System.Boolean get_packIntoRuntimeAtlas() { }
        private System.Void set_packIntoRuntimeAtlas(System.Boolean value) { }
        private System.Int32 get_atlasHandleId() { }
        private System.Void set_atlasHandleId(System.Int32 value) { }
        private Beyond.UI.LuaPanel get_panel() { }
        private Beyond.UI.UIAtlasManager.UIAtlasHandle& get_atlasHandle() { }
        private System.Int32 get_panelLevel() { }
        private System.Void RegisterOnEnableRuntimeAtlas(System.Action callBack) { }
        private System.Void UnregisterOnEnableRuntimeAtlas(System.Action callBack) { }
        private System.Void OnEnableRuntimeAtlas() { }
        private System.Void _OnSpriteChanged(UnityEngine.Sprite lastOne) { }
        private System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill) { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void SetNativeSize() { }
        private System.Void SetNativeSizeIgnoreRefScale() { }
        private System.Void LoadSprite(System.String folder, System.String spriteName) { }
        private System.Void LoadSprite(System.String path) { }
        private System.Void LoadSpriteWithOutFormat(System.String path, System.Boolean ignoreEnable) { }
        private System.Void _LoadSprite(System.String path, System.Boolean ignoreEnable) { }
        private System.Void LoadMaterial(System.String path, System.Boolean newInstance) { }
        private System.Void ReleaseSprite() { }
        private System.Void DisposeSpriteHandle() { }
        private UnityEngine.Texture get_mainTexture() { }
        private System.Void _V2AtlasInitialize() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy__OnSpriteChanged(UnityEngine.Sprite P0) { }
        private System.Void <>iFixBaseProxy_OnPopulateMesh(UnityEngine.UI.VertexHelper P0) { }
        private System.Void <>iFixBaseProxy_Awake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }
        private System.Void <>iFixBaseProxy_SetNativeSize() { }
        private System.Void <>iFixBaseProxy_ReleaseSprite() { }
        private UnityEngine.Texture <>iFixBaseProxy_get_mainTexture() { }

    }

    // TypeToken: 0x20000AA
    public class UIImageBlur : TickableUIMono
    {
        // Fields
        public System.Single scale;        // 0x68
        private UnityEngine.RectTransform m_rect;        // 0x70
        private System.Single m_lastScale;        // 0x78
        private Beyond.UI.UIImage m_image;        // 0x80
        private UnityEngine.Texture2D m_srcTex;        // 0x88
        private UnityEngine.RenderTexture m_tarTex;        // 0x90
        private System.Int32 m_uiImageBlurTexId;        // 0x98
        private UnityEngine.Rect m_atlasRect;        // 0x9C
        private System.Action m_dynamicCallback;        // 0xB0

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void OnAwake() { }
        private System.Void OnChangeSprite() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void OnDisable() { }
        private System.Void OnRelease() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x20000AB
    public class UIImageFillAmountOffset : MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIImage m_followImage;        // 0x18
        public System.Single fillOffset;        // 0x20
        private System.Single m_fillAmount;        // 0x24

        // Methods
        private System.Single get_fillAmount() { }
        private System.Void set_fillAmount(System.Single value) { }
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> DOFillAmount(System.Single endValue, System.Single duration) { }
        private System.Void .ctor() { }
        private System.Single <DOFillAmount>b__6_0() { }
        private System.Void <DOFillAmount>b__6_1(System.Single x) { }

    }

    // TypeToken: 0x20000AC
    public class UIImageFillFollower : TickableUIMono
    {
        // Fields
        private static System.Single BACK_FOLLOW_THRESHOLD;        // 0x0
        private Beyond.UI.UIImage _frontFill;        // 0x68
        private System.Single _followSpeed;        // 0x70
        private Beyond.UI.UIImage m_image;        // 0x78

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void OnAwake() { }
        private System.Void OnEnable() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void RefreshFillAmount() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000AD
    public class UIImageFillTailFollower : TickableUIMono
    {
        // Fields
        private Beyond.UI.UIImage _followImage;        // 0x68
        public System.Single followOffset;        // 0x70
        private UnityEngine.RectTransform m_selfRectTransform;        // 0x78
        private UnityEngine.RectTransform m_followImageRectTransform;        // 0x80

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void OnAwake() { }
        private System.Void OnEnable() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void RefreshFollower() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000AE
    public class UIImagePair : MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<Beyond.UI.UIImage> referencedImages;        // 0x18

        // Methods
        private System.Void LoadSprite(System.String folder, System.String spriteName) { }
        private System.Void LoadSprite(System.String path) { }
        private System.Void set_color(UnityEngine.Color value) { }
        private Beyond.UI.UIImage get_first() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AF
    public class UIInertiaViewPager : TickableUIMono, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private Beyond.UI.UIScrollRect _scrollRect;        // 0x68
        private System.Single _animationDuration;        // 0x70
        private System.Single _endScrollSpd;        // 0x74
        private Beyond.UI.UIInertiaViewPager.ScrollEffectConfig.Timing _timing;        // 0x78
        private System.Single _minScrollInterval;        // 0x7C
        private System.String _audioGear;        // 0x80
        private System.String _audioGearLock;        // 0x88
        public System.Boolean flingToNextEnable;        // 0x90
        public System.Single flingToNextMinSpd;        // 0x94
        public System.Single flingToNextMaxSpd;        // 0x98
        private System.Int32 m_currentPage;        // 0x9C
        private Beyond.UI.UIInertiaViewPager.State m_state;        // 0xA0
        private Beyond.UI.UIInertiaViewPager.IScrollHandler m_scrollHandler;        // 0xA8
        private Beyond.UI.UIInertiaViewPager.ScrollEffectTrigger m_effectTrigger;        // 0xB0
        private Beyond.UI.UIInertiaViewPager.BlockerManager m_blockers;        // 0xB8
        private Beyond.UI.UIInertiaViewPager.DragContext m_dragContext;        // 0xC0
        private System.Int32 m_fromPage;        // 0xC8
        private System.Int32 m_toPage;        // 0xCC
        private System.Single m_tweenStartTime;        // 0xD0
        private System.Single m_tweenStartValue;        // 0xD4
        private System.Single m_tweenTargetValue;        // 0xD8
        private System.Boolean m_isInited;        // 0xDC
        private System.Int32 <pageCount>k__BackingField;        // 0xE0
        public Beyond.DisposedUnityEvent<System.Int32> onStateChanged;        // 0xE8

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void _PlayAudioGear() { }
        private System.Void _PlayAudioGearLock() { }
        private System.Void _InitIfNot() { }
        private System.Boolean get_isUpdating() { }
        private System.Int32 get_pageCount() { }
        private System.Void set_pageCount(System.Int32 value) { }
        private System.Int32 get_currentPage() { }
        private System.Void set_currentPage(System.Int32 value) { }
        private System.Single get_currentScrollIndex() { }
        private System.Void ClearComponent() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void SetPageCount(System.Int32 pageCount, System.Collections.Generic.List<System.Int32> segmentFrames) { }
        private System.Void MoveToPage(System.Int32 pageIndex) { }
        private System.Void OnAwake() { }
        private System.Void OnEnable() { }
        private System.Single _ScrollValue2PageIndex(System.Single value) { }
        private System.Single _PageIndex2ScrollValue(System.Single index) { }
        private System.Int32 _ScrollValueAlignToPage(System.Single value) { }
        private System.Void _SwitchToPage(System.Int32 targetIndex, System.Boolean useTween) { }
        private System.Void _AutoAlign() { }
        private System.Void _OnStateChanged(Beyond.UI.UIInertiaViewPager.State from, Beyond.UI.UIInertiaViewPager.State to) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }

    }

    // TypeToken: 0x20000BD
    public class UIInputField : TMP_InputField, IUIClearable, ILuaCallCSharp
    {
        // Fields
        public System.String activeInputActionId;        // 0x390
        public System.String deactivateInputActionId;        // 0x398
        private System.Int32 <activeInputBindingId>k__BackingField;        // 0x3A0
        private System.Int32 <deactivateInputBindingId>k__BackingField;        // 0x3A4
        private Beyond.UI.LuaPanel m_panel;        // 0x3A8
        public System.Boolean isDebugInputField;        // 0x3B0
        private UnityEngine.Camera m_fallbackUICamera;        // 0x3B8
        private UnityEngine.GameObject m_fallbackUIRoot;        // 0x3C0
        private UnityEngine.RectTransform m_fallbackRectTransform;        // 0x3C8
        private System.Int32 m_activateBindingGroupId;        // 0x3D0
        private System.Boolean m_isNaviFocused;        // 0x3D4
        private Beyond.UI.UIState.UIStateController _uiStateController;        // 0x3D8
        private System.String _onFocusStateName;        // 0x3E0
        private System.String _onFocusLostStateName;        // 0x3E8
        private System.String _audioPressStart;        // 0x3F0
        public UnityEngine.RectTransform m_keyboardOffsetTarget;        // 0x3F8
        public UnityEngine.RectTransform m_offsetTargetParent;        // 0x400
        public UnityEngine.RectTransform m_inputFieldRect;        // 0x408
        public System.Int32 m_pcDebug;        // 0x410
        public System.Single m_keyboardExtraOffsetY;        // 0x414
        private UnityEngine.Vector2 m_baseKeyboardOffsetTarget;        // 0x418
        private UnityEngine.Vector2 m_baseKeyboardLocalPos;        // 0x420
        private System.Single m_inputFieldOffsetY;        // 0x428
        private System.Boolean m_enableKeyboardOffsetCal;        // 0x42C
        private UnityEngine.Coroutine m_heightChangeCoroutine;        // 0x430
        private System.Int32 m_lastHeight;        // 0x438
        private System.Int32 m_nowHeight;        // 0x43C
        public System.String audioOnActive;        // 0x440
        private static Beyond.UI.UIInputField s_mFocusedInputField;        // 0x0

        // Methods
        private System.Int32 get_activeInputBindingId() { }
        private System.Void set_activeInputBindingId(System.Int32 value) { }
        private System.Int32 get_deactivateInputBindingId() { }
        private System.Void set_deactivateInputBindingId(System.Int32 value) { }
        private Beyond.UI.LuaPanel get_panel() { }
        private System.Boolean get_isControllerInputValid() { }
        private System.Void SendOnFocus() { }
        private System.Void SendOnFocusLost() { }
        private System.Void Awake() { }
        private System.Void OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void ActivateInputField() { }
        private System.Void DeactivateInputField(System.Boolean clearSelection) { }
        private System.Void OnDestroy() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void _NotifyIsHover(System.Boolean isHover) { }
        private System.Void OnInteractableChanged() { }
        private System.Void _UpdateBindingEnable() { }
        private System.Void ClearComponent() { }
        private UnityEngine.Camera _GetCamera() { }
        private System.Void _VirtualKeyboardOnDestroy() { }
        private System.Void _VirtualKeyboardSelect() { }
        private System.Void _VirtualKeyboardDeselect() { }
        private System.Void _VirtualKeyboardAwake() { }
        private System.Void _UpdateKeyboardOffset(System.Int32 offsetHeight) { }
        private System.Collections.IEnumerator _KeyboardHeightChange(System.Action<System.Int32> onHeightChanged) { }
        private Beyond.UI.UIInputField get_s_focusedInputField() { }
        private System.Void set_s_focusedInputField(Beyond.UI.UIInputField value) { }
        private System.Void .ctor() { }
        private System.Void <Awake>b__27_0() { }
        private System.Void <>iFixBaseProxy_SendOnFocus() { }
        private System.Void <>iFixBaseProxy_SendOnFocusLost() { }
        private System.Void <>iFixBaseProxy_Awake() { }
        private System.Void <>iFixBaseProxy_OnSelect(UnityEngine.EventSystems.BaseEventData P0) { }
        private System.Void <>iFixBaseProxy_OnDeselect(UnityEngine.EventSystems.BaseEventData P0) { }
        private System.Void <>iFixBaseProxy_ActivateInputField() { }
        private System.Void <>iFixBaseProxy_DeactivateInputField(System.Boolean P0) { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0) { }
        private System.Void <>iFixBaseProxy_OnInteractableChanged() { }

    }

    // TypeToken: 0x20000BF
    public class UIJoystick : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IPointerDownHandler, IPointerUpHandler, IUIClearable, ILuaCallCSharp, IBindingGroupTarget
    {
        // Fields
        private UnityEngine.RectTransform _runBg;        // 0x18
        private UnityEngine.RectTransform _walkBg;        // 0x20
        private UnityEngine.RectTransform _thumb;        // 0x28
        private UnityEngine.RectTransform _directionIndicate;        // 0x30
        private UnityEngine.RectTransform _walkDirectionIndicate;        // 0x38
        private UnityEngine.RectTransform _rootCanvas;        // 0x40
        private UnityEngine.RectTransform _triggerArea;        // 0x48
        private UnityEngine.UI.GraphicRaycaster _raycaster;        // 0x50
        private System.Single _walkRation;        // 0x58
        private System.Single _autoSprintStartLength;        // 0x5C
        private System.Single _autoSprintStopLength;        // 0x60
        private System.Single _autoSprintStartAngle;        // 0x64
        private System.Single _autoSprintStopAngle;        // 0x68
        public System.Single margin;        // 0x6C
        public System.Single bgVisibleTimeWhenEnable;        // 0x70
        private System.Single m_bgHideTime;        // 0x74
        private System.Boolean _isDynamic;        // 0x78
        private Beyond.UI.LuaPanel m_panel;        // 0x80
        private UnityEngine.Vector2 <jsValue>k__BackingField;        // 0x88
        private Beyond.UI.UITouchPanel _dynamicArea;        // 0x90
        private System.Boolean _dynamicButDontMove;        // 0x98
        private System.Boolean _useRewiredPlayerInput;        // 0x99
        private System.String _controllerRewiredActionX;        // 0xA0
        private System.String _controllerRewiredActionY;        // 0xA8
        private System.String _keyboardRewiredActionX;        // 0xB0
        private System.String _keyboardRewiredActionY;        // 0xB8
        private System.Boolean m_active;        // 0xC0
        private System.Boolean m_activatedByTouch;        // 0xC1
        public Beyond.DisposedUnityEvent onTouchStart;        // 0xC8
        public Beyond.DisposedUnityEvent onTouchEnd;        // 0xD0
        public Beyond.DisposedUnityEvent onMoveStart;        // 0xD8
        public Beyond.DisposedUnityEvent<UnityEngine.Vector2> onMove;        // 0xE0
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onDrag;        // 0xE8
        public Beyond.DisposedUnityEvent<System.Boolean> onToggleAutoSprint;        // 0xF0
        private UnityEngine.CanvasGroup m_canvasGroup;        // 0xF8
        private UnityEngine.RectTransform m_rect;        // 0x100
        private UnityEngine.Vector2 m_oriAnchorMin;        // 0x108
        private UnityEngine.Vector2 m_oriAnchorMax;        // 0x110
        private UnityEngine.Vector2 m_oriAnchorPos;        // 0x118
        private UnityEngine.Vector2 m_oriPivot;        // 0x120
        private System.Boolean m_isWalking;        // 0x128
        private System.Boolean m_isRunning;        // 0x129
        private System.Boolean m_isSprinting;        // 0x12A
        private Beyond.UI.UIAnimationWrapper m_walkBgAnim;        // 0x130
        private Beyond.UI.UIAnimationWrapper m_runBgAnim;        // 0x138
        private System.Boolean m_isWalkBgVisible;        // 0x140
        private System.Boolean m_isRunBgVisible;        // 0x141
        private System.Collections.Generic.List<UnityEngine.InputSystem.UI.ExtendedPointerEventData> m_exPointers;        // 0x148
        private UnityEngine.InputSystem.UI.ExtendedPointerEventData m_fakePointerEventData;        // 0x150
        private UnityEngine.InputSystem.UI.ExtendedPointerEventData m_activePointerEventData;        // 0x158
        private Beyond.UI.UICustomLayoutElement m_customLayoutElement;        // 0x160
        private UnityEngine.Vector2 m_lastFrameActiveStickVal;        // 0x168
        private UnityEngine.EventSystems.PointerEventData <curDragEventData>k__BackingField;        // 0x170
        private System.Int32 m_groupId;        // 0x178
        private System.Boolean m_bindingInit;        // 0x17C
        private Beyond.Input.InputBindingGroupMonoTarget <parent>k__BackingField;        // 0x180

        // Methods
        private Beyond.UI.LuaPanel get_panel() { }
        private System.Boolean get_isDynamic() { }
        private System.Void set_isDynamic(System.Boolean value) { }
        private System.Single get_walkRation() { }
        private System.Void set_walkRation(System.Single value) { }
        private System.Boolean get_active() { }
        private System.Int32 get_activeTouchId() { }
        private UnityEngine.Vector2 get_jsValue() { }
        private System.Void set_jsValue(UnityEngine.Vector2 value) { }
        private System.Single get_m_thumbPosMaxLength() { }
        private UnityEngine.EventSystems.PointerEventData get_curDragEventData() { }
        private System.Void set_curDragEventData(UnityEngine.EventSystems.PointerEventData value) { }
        private System.Void Reset() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void Start() { }
        private System.Void OnDestroy() { }
        private System.Void _Tick() { }
        private System.Void OnDisable() { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void CheckShouldActive() { }
        private System.Void _SetVisible(System.Boolean visible) { }
        private System.Void _ChangeDynamic(System.Boolean dynamic, System.Boolean force) { }
        private System.Void _SetRectTransform(System.Boolean toOri) { }
        private System.Void _UpdateWalkBgScale() { }
        private System.Void _Activate(System.Boolean fromTouch, UnityEngine.Vector2 showPos, UnityEngine.Vector2 initJsValue) { }
        private System.Void _UpdateGait() { }
        private System.Void _UpdateIndicator() { }
        private System.Void _UpdateBg() { }
        private System.Void _SetWalkBgVisible(System.Boolean visible, System.Boolean ignoreAnim) { }
        private System.Void _SetRunBgVisible(System.Boolean visible, System.Boolean ignoreAnim) { }
        private System.Void _OnHudLayoutLoaded(Beyond.EventData<System.String>& eventData) { }
        private System.Void ClearComponent() { }
        private System.Boolean get_groupEnabled() { }
        private System.Boolean get_shouldCheckInput() { }
        private System.Int32 get_groupId() { }
        private Beyond.Input.IBindingGroupTarget get_parentTarget() { }
        private Beyond.Input.InputBindingGroupMonoTarget get_parent() { }
        private System.Void set_parent(Beyond.Input.InputBindingGroupMonoTarget value) { }
        private System.Void InitBinding() { }
        private System.Void _UpdateState() { }
        private System.Void .ctor() { }
        private System.Void <Awake>b__74_0(UnityEngine.Vector2 _) { }

    }

    // TypeToken: 0x20000C0
    public class UILayoutDimensionListener : UIBehaviour, IHotfixable, ICanvasElement
    {
        // Fields
        private Beyond.ListSet<Beyond.UI.UILayoutDimensionListener.IAction> m_actionsWhenLayoutReady;        // 0x18
        public Beyond.DisposedUnityEvent eventOnPostLayout;        // 0x20

        // Methods
        private System.Void GraphicUpdateComplete() { }
        private System.Void LayoutComplete() { }
        private System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        private System.Collections.IEnumerator _NextFrameCoroutine() { }
        private System.Void DoOnceOnPostLayout(Beyond.UI.UILayoutDimensionListener.IAction action) { }
        private System.Void OnEnable() { }
        private System.Void OnRectTransformDimensionsChange() { }
        private System.Void OnDestroy() { }
        private System.Void _SetDirty() { }
        private System.Void _InvokePostLayoutCallback() { }
        private System.Void .ctor() { }
        private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnRectTransformDimensionsChange() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x20000C3
    public class UILeftSubtitle : TickableUIMono
    {
        // Fields
        private Beyond.UI.UIDialogTextWithCursor _dialogText1;        // 0x68
        private Beyond.UI.UIDialogTextWithCursor _dialogText2;        // 0x70
        private Beyond.UI.UIDialogTextWithCursor _dialogText3;        // 0x78
        private Beyond.UI.UIDialogTextWithCursor _dialogText4;        // 0x80
        private Beyond.UI.UIAnimationWrapper _panelAnimation;        // 0x88
        private System.Int32 m_maxDisplayIndex;        // 0x90
        private readonly System.Collections.Generic.List<Beyond.UI.UIDialogTextWithCursor> m_dialogTextList;        // 0x98
        private System.Boolean m_isDisplaying;        // 0xA0
        private System.Single m_currTime;        // 0xA4
        private System.Single m_textStayTime;        // 0xA8
        private System.Boolean m_isAutoPlay;        // 0xAC

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void StartAutoPlay(System.Single textStayTime) { }
        private System.Void SetLeftSubTitle(System.String text1, System.String text2, System.String text3, System.String text4) { }
        private System.Single UpdateByPlayTime(System.Single currTime) { }
        private System.Void Exit() { }
        private System.Void SetVisible(System.Boolean visible) { }
        private System.Void .ctor() { }
        private System.Void <Exit>b__17_0() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000C4
    public class UIMaterialAnimation : TickableUIMono
    {
        // Fields
        private UnityEngine.UI.MaskableGraphic _maskableGraphic;        // 0x68
        private UnityEngine.Material _material;        // 0x70
        private System.String _propertiesName1;        // 0x78
        private System.Single _propertiesSet1;        // 0x80
        private System.String _propertiesName2;        // 0x88
        private System.Single _propertiesSet2;        // 0x90
        private System.String _propertiesName3;        // 0x98
        private System.Single _propertiesSet3;        // 0xA0
        private System.String _propertiesName4;        // 0xA8
        private System.Single _propertiesSet4;        // 0xB0
        private System.String _propertiesName5;        // 0xB8
        private System.Single _propertiesSet5;        // 0xC0
        private System.String _propertiesName6;        // 0xC8
        private System.Single _propertiesSet6;        // 0xD0
        private System.String _propertiesName7;        // 0xD8
        private System.Single _propertiesSet7;        // 0xE0
        private System.String _propertiesName8;        // 0xE8
        private System.Single _propertiesSet8;        // 0xF0
        private System.String _propertiesName9;        // 0xF8
        private System.Single _propertiesSet9;        // 0x100
        private System.String _propertiesName10;        // 0x108
        private System.Single _propertiesSet10;        // 0x110
        private System.String _propertiesVectorName1;        // 0x118
        private UnityEngine.Vector4 _propertiesVector1;        // 0x120
        private System.String _propertiesVectorName2;        // 0x130
        private UnityEngine.Vector4 _propertiesVector2;        // 0x138
        private System.String _propertiesVectorName3;        // 0x148
        private UnityEngine.Vector4 _propertiesVector3;        // 0x150
        private System.String _propertiesVectorName4;        // 0x160
        private UnityEngine.Vector4 _propertiesVector4;        // 0x168
        private System.String _propertiesVectorName5;        // 0x178
        private UnityEngine.Vector4 _propertiesVector5;        // 0x180
        private System.String _propertiesColorName1;        // 0x190
        private UnityEngine.Color _propertiesColor1;        // 0x198
        private System.String _propertiesColorName2;        // 0x1A8
        private UnityEngine.Color _propertiesColor2;        // 0x1B0
        private System.String _propertiesColorName3;        // 0x1C0
        private UnityEngine.Color _propertiesColor3;        // 0x1C8
        private UnityEngine.Material m_matIns;        // 0x1D8

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void OnAwake() { }
        private System.Void OnRelease() { }
        private System.Void _TryUpdate() { }
        private System.Void ForceUpdate() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x20000C5
    public class UINonUnifiedScrollList : UIScrollList
    {
        // Fields
        public Beyond.UI.UINonUnifiedScrollList.GetCellSizeMode getCellSizeMode;        // 0x278
        private System.Boolean _recalculateAfterSizeChange;        // 0x27C
        private System.Boolean _forceUpdateCellSizeCache;        // 0x27D
        public System.Func<System.Int32,System.Int32> getSubCellCount;        // 0x280
        public System.Func<System.Int32,System.Single> getCellSize;        // 0x288
        public System.Single overrideContainSize;        // 0x290
        private UnityEngine.UI.GridLayoutGroup m_templateCellGridLayoutGroup;        // 0x298
        private System.Collections.Generic.Dictionary<System.Int32,System.Single> m_cellSizeCache;        // 0x2A0
        private System.Int32 m_containerTopIndex;        // 0x2A8
        private static System.Single CONTAINER_SIZE_BUFFER;        // 0x0
        public System.Single additiveContainerSizeBuffer;        // 0x2AC
        private System.Single m_lastScrollStep;        // 0x2B0
        private System.Boolean m_isRecalculatingSize;        // 0x2B4
        private System.Boolean m_isCalculatingContainerSize;        // 0x2B5
        private System.Int32 m_averageCount;        // 0x2B8
        private System.Single m_averageCellSize;        // 0x2BC
        private System.Boolean m_needRecalculateAverage;        // 0x2C0
        private System.Collections.Generic.Dictionary<System.Int32,System.Boolean> m_cellFoldStateDic;        // 0x2C8
        private Beyond.UI.IUIFoldoutComp m_cellTemplateFoldoutComp;        // 0x2D0

        // Methods
        private System.Void InitBasicInfo() { }
        private System.Void CalcSomeCountNum() { }
        private System.Single GetLeftLength(System.Boolean checkVertical, System.Int32 checkCount) { }
        private System.Void UpdateCount(System.Int32 newCount) { }
        private System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop, System.Boolean forceRecalculate, System.Boolean onlyUpdateNewCellContent, System.Boolean skipGraduallyShow) { }
        private System.Void UpdateCount(System.Int32 newCount, System.Int32 fastScrollToIndex, System.Boolean forceRecalculate, System.Boolean onlyUpdateNewCellContent, System.Boolean skipGraduallyShow, Beyond.UI.UIScrollList.ScrollAlignType alignType) { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void OnScroll(UnityEngine.Vector2 v) { }
        private UnityEngine.Vector2 GetGridLayoutSize(UnityEngine.UI.GridLayoutGroup grid, System.Int32 count) { }
        private System.Single _GetCellSize(System.Int32 index) { }
        private System.Single GetContainerSize(System.Boolean ignoreAutoLayout) { }
        private System.Single GetCenterIndex() { }
        private UnityEngine.Vector2Int GetShowRange(System.Single bufferSize, System.Boolean ignoreGraduallyShow) { }
        private UnityEngine.Vector2Int GetNotCacheRange() { }
        private System.Void MoveCellTo(Beyond.UI.UIScrollList.Cell cell, System.Int32 index) { }
        private System.Void OnUpdateCell(Beyond.UI.UIScrollList.Cell cell, System.Int32 index) { }
        private System.Single GetTargetPosByIndex(System.Int32 index, Beyond.UI.UIScrollList.ScrollAlignType alignType) { }
        private System.Single _GetCellsSizeTo(System.Int32 index) { }
        private System.Void ScrollTo(System.Int32 index, System.Boolean fastMode, Beyond.UI.UIScrollList.ScrollAlignType alignType) { }
        private System.Void ClearComponent() { }
        private System.Single get_currentStep() { }
        private System.Void set_currentStep(System.Single value) { }
        private System.Void SetStepTo(System.Single step) { }
        private System.Void SetCurrentStep(System.Single currentStep) { }
        private System.Single GetScrollBarSize() { }
        private System.Single GetLastScrollStep() { }
        private System.Void UpdateLastScrollStep() { }
        private System.Single GetNormalizedPosition() { }
        private System.Void SetNormalizedPosition(System.Single normalizedPosition) { }
        private System.Void ToggleByState(System.Int32 index, System.Boolean isFoldOut, System.Boolean fastMode) { }
        private System.Void Toggle(System.Int32 index, System.Boolean fastMode) { }
        private System.Void FoldAll(System.Boolean isFoldOut) { }
        private System.Void NotifyCellSizeChange(System.Int32 index, System.Single size) { }
        private System.Void .ctor() { }
        private System.Void <GetScrollBarSize>g__RecalculateAverageCellSize|43_0() { }
        private System.Void <>iFixBaseProxy_InitBasicInfo() { }
        private System.Void <>iFixBaseProxy_CalcSomeCountNum() { }
        private System.Single <>iFixBaseProxy_GetLeftLength(System.Boolean P0, System.Int32 P1) { }
        private System.Void <>iFixBaseProxy_UpdateCount(System.Int32 P0) { }
        private System.Void <>iFixBaseProxy_UpdateCount(System.Int32 P0, System.Boolean P1, System.Boolean P2, System.Boolean P3, System.Boolean P4) { }
        private System.Void <>iFixBaseProxy_UpdateCount(System.Int32 P0, System.Int32 P1, System.Boolean P2, System.Boolean P3, System.Boolean P4, Beyond.UI.UIScrollList.ScrollAlignType P5) { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_OnScroll(UnityEngine.Vector2 P0) { }
        private System.Single <>iFixBaseProxy_GetContainerSize(System.Boolean P0) { }
        private System.Single <>iFixBaseProxy_GetCenterIndex() { }
        private UnityEngine.Vector2Int <>iFixBaseProxy_GetShowRange(System.Single P0, System.Boolean P1) { }
        private UnityEngine.Vector2Int <>iFixBaseProxy_GetNotCacheRange() { }
        private System.Void <>iFixBaseProxy_MoveCellTo(Beyond.UI.UIScrollList.Cell P0, System.Int32 P1) { }
        private System.Void <>iFixBaseProxy_OnUpdateCell(Beyond.UI.UIScrollList.Cell P0, System.Int32 P1) { }
        private System.Single <>iFixBaseProxy_GetTargetPosByIndex(System.Int32 P0, Beyond.UI.UIScrollList.ScrollAlignType P1) { }
        private System.Void <>iFixBaseProxy_ScrollTo(System.Int32 P0, System.Boolean P1, Beyond.UI.UIScrollList.ScrollAlignType P2) { }
        private System.Void <>iFixBaseProxy_ClearComponent() { }
        private System.Single <>iFixBaseProxy_get_currentStep() { }
        private System.Void <>iFixBaseProxy_SetStepTo(System.Single P0) { }

    }

    // TypeToken: 0x20000C7
    public class UINonUnifiedScrollRect : UIScrollRect
    {
        // Fields
        private System.Boolean m_isInited;        // 0x1D8
        private System.Boolean m_isRebuilding;        // 0x1D9
        private Beyond.UI.UINonUnifiedScrollList m_scrollList;        // 0x1E0
        private Beyond.UI.UILayoutDimensionListener m_dimensionListener;        // 0x1E8

        // Methods
        private System.Void _InitIfNot() { }
        private System.Void UpdateScrollbars(UnityEngine.Vector2 offset) { }
        private System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        private System.Void _UpdateNonUnifiedScrollbars() { }
        private System.Void SetHorizontalNormalizedPosition(System.Single value) { }
        private System.Void SetVerticalNormalizedPosition(System.Single value) { }
        private System.Void _OnPostLayout() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_UpdateScrollbars(UnityEngine.Vector2 P0) { }
        private System.Void <>iFixBaseProxy_Rebuild(UnityEngine.UI.CanvasUpdate P0) { }
        private System.Void <>iFixBaseProxy_SetHorizontalNormalizedPosition(System.Single P0) { }
        private System.Void <>iFixBaseProxy_SetVerticalNormalizedPosition(System.Single P0) { }

    }

    // TypeToken: 0x20000C8
    public class UINumberScrollTween : TickableUIMono
    {
        // Fields
        public Beyond.UI.UIText bindingUIText;        // 0x68
        public System.Single tweenDuration;        // 0x70
        public System.Boolean useCustomNumberTweenCurve;        // 0x74
        public UnityEngine.AnimationCurve numberTweenCurve;        // 0x78
        private System.String m_tweenToText;        // 0x80
        private System.Single m_tweenStartTime;        // 0x88
        private System.Single m_curTime;        // 0x8C
        private System.Boolean m_inTransition;        // 0x90
        private System.Single m_fromNumber;        // 0x94
        private System.Single m_toNumber;        // 0x98

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.String get_tweenToText() { }
        private System.Void set_tweenToText(System.String value) { }
        private System.String get_text() { }
        private System.Void set_text(System.String value) { }
        private System.Void Start() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void _TweenToTarget(System.String targetText) { }
        private System.Void _CleanupBeforeTween() { }
        private System.Void _HandleNumberScrollTween(System.Single fromNumber, System.Single toNumber, System.Single curTime) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000C9
    public class UIPCScaleHelper : MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector3 baseScale;        // 0x18

        // Methods
        private System.Void OnEnable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CA
    public class UIRawImage : RawImage
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CB
    public class UIRegionBuildingTexManager : MonoBehaviour
    {
        // Fields
        private UnityEngine.Shader _regionMapShader;        // 0x18
        public UnityEngine.Texture2D minimapOutlineTex;        // 0x20
        private static System.Int32 s_buildingOutlineTex;        // 0x0
        private UnityEngine.Renderer m_meshRenderer;        // 0x28
        private static UnityEngine.MaterialPropertyBlock s_materialPropertyBlock;        // 0x8

        // Methods
        private UnityEngine.MaterialPropertyBlock get_materialPropertyBlock() { }
        private System.Void OnEnable() { }
        private System.Void OnValidate() { }
        private System.Void OnDisable() { }
        private System.Void _UpdateTexture(UnityEngine.Renderer meshRenderer, UnityEngine.Shader minimapTerrainShader, UnityEngine.Texture2D buildingTex) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000CC
    public class UIScaleHolder : TickableUIMono
    {
        // Fields
        private UnityEngine.RectTransform m_rectTransform;        // 0x68
        private UnityEngine.RectTransform m_parentTransform;        // 0x70
        private System.Boolean m_holdValid;        // 0x78
        private UnityEngine.Vector3 _extraScale;        // 0x7C
        private System.Boolean _onlyHoldOnEnable;        // 0x88
        public UnityEngine.RectTransform referenceTransform;        // 0x90
        public System.Single animationExtraScale;        // 0x98

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void OnAwake() { }
        private System.Void OnEnable() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Boolean _IsValidScale(UnityEngine.Vector3 scale) { }
        private System.Void _HoldScale() { }
        private System.Void SetExtraScale(UnityEngine.Vector3 extraScale) { }
        private UnityEngine.Vector3 GetExtraScale() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000CD
    public class UIScrollbar : Scrollbar
    {
        // Methods
        private System.Void Awake() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Awake() { }

    }

    // TypeToken: 0x20000CE
    public class UIScrollbarKeyHint : TickableUIMono
    {
        // Fields
        private Beyond.UI.UIScrollRect m_scrollRect;        // 0x68
        private Beyond.UI.UIImage m_image;        // 0x70

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void OnAwake() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000CF
    public class UIScrollCircle : TickableUIMono, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private UnityEngine.GameObject _cellTemplate;        // 0x68
        private System.Int32 _totalNum;        // 0x70
        private System.Single _tweenTime;        // 0x74
        private UnityEngine.RectTransform m_Viewport;        // 0x78
        private System.Single m_Elasticity;        // 0x80
        private System.Single _speedFactor;        // 0x84
        private System.Int32 <count>k__BackingField;        // 0x88
        public UnityEngine.Events.UnityEvent<System.Int32,System.Int32,System.Boolean> onCenterIndexChanged;        // 0x90
        public UnityEngine.Events.UnityEvent<UnityEngine.GameObject,System.Int32> onUpdateCell;        // 0x98
        private UnityEngine.Vector2 m_PointerStartLocalCursor;        // 0xA0
        private UnityEngine.Vector2 m_tmpDragPosition;        // 0xA8
        private System.Boolean m_Dragging;        // 0xB0
        private System.Boolean m_inited;        // 0xB1
        private System.Single m_Velocity;        // 0xB4
        private UnityEngine.Vector2 m_curScreenPos;        // 0xB8
        private UnityEngine.RectTransform m_ViewRect;        // 0xC0
        private Beyond.UI.LuaPanel m_panel;        // 0xC8
        private System.Single m_radius;        // 0xD0
        private System.Single m_cellAngle;        // 0xD4
        private System.Collections.Generic.List<Beyond.UI.UIScrollCircle.Cell> m_showingCells;        // 0xD8
        private System.Single m_rangeMax;        // 0xE0
        private System.Single m_curAngle;        // 0xE4
        private System.Single m_lastAngle;        // 0xE8
        private System.Int32 m_curCenterIndex;        // 0xEC
        private DG.Tweening.Tween m_tween;        // 0xF0

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Single get_elasticity() { }
        private System.Void set_elasticity(System.Single value) { }
        private System.Int32 get_count() { }
        private System.Void set_count(System.Int32 value) { }
        private System.Single get_velocity() { }
        private System.Void set_velocity(System.Single value) { }
        private Beyond.UI.LuaPanel get_panel() { }
        private UnityEngine.RectTransform get_viewRect() { }
        private System.Void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Boolean IsActive() { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void _UpdateSpeed() { }
        private System.Boolean _CheckCanMove(System.Single deltaAngle) { }
        private System.Void _TryUpdateCells() { }
        private System.Void _UpdateAuto() { }
        private System.Void OnRelease() { }
        private System.Single _GetDeltaAngle(UnityEngine.Vector2 position) { }
        private System.Void _InitCells() { }
        private System.Void _Init() { }
        private System.Void _OnAwakeInit() { }
        private System.Void _UpdateScrollRange() { }
        private System.Int32 _GetRealIndex(System.Int32 index) { }
        private System.Void _UpdateShowingCells() { }
        private System.Void _UpdateCenterIndex(System.Boolean forceUpdate) { }
        private System.Void _DoScroll(System.Single tmpAngle, System.Boolean direct) { }
        private System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void Rebuild(UnityEngine.UI.CanvasUpdate executing) { }
        private System.Void LayoutComplete() { }
        private System.Void GraphicUpdateComplete() { }
        private System.Boolean IsDestroyed() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Start() { }
        private System.Void OnAwake() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop) { }
        private System.Void ScrollToIndex(System.Int32 index, System.Boolean direct) { }
        private UnityEngine.GameObject Get(System.Int32 index) { }
        private System.Void ClearComponent() { }
        private System.Void .ctor() { }
        private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform() { }
        private System.Void <_DoScroll>b__59_0() { }
        private System.Void <>iFixBaseProxy_OnRelease() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000D1
    public class UIScrollContainerFollower : TickableUIMono
    {
        // Fields
        private Beyond.UI.UIScrollList _followTargetList;        // 0x68
        private Beyond.UI.UIScrollRect _followTargetRect;        // 0x70
        private UnityEngine.RectTransform m_rectTransform;        // 0x78
        private System.Single m_currentSize;        // 0x80
        private System.Boolean m_targetSizeChanged;        // 0x84
        private UnityEngine.Vector2 m_currentPos;        // 0x88
        private System.Boolean m_targetPosChanged;        // 0x90
        private System.Boolean m_setValid;        // 0x91
        private System.Boolean m_isFollowContent;        // 0x92

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void OnAwake() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void _RefreshSizeAndPositionToTargetContainer() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000D2
    public struct ScrollDirection
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.ScrollDirection Vertical;        // 0x0
        public static Beyond.UI.ScrollDirection Horizontal;        // 0x0

    }

    // TypeToken: 0x20000D3
    public class UIScrollList : TickableUIMono, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IUIClearable, ILuaCallCSharp
    {
        // Fields
        protected UnityEngine.GameObject _cellTemplate;        // 0x68
        private Beyond.UI.ScrollDirection _scrollDirection;        // 0x70
        private System.Boolean _expandCellSize;        // 0x74
        private System.Boolean _alsoExpandCellSizeInAnotherDirection;        // 0x75
        protected UnityEngine.Vector2 _space;        // 0x78
        protected Beyond.UI.UIScrollList.Padding _padding;        // 0x80
        protected System.Boolean _ignorePaddingWhenScroll;        // 0x90
        protected System.Single _notCacheBufferSize;        // 0x94
        protected System.Single _extraCacheBufferSize;        // 0x98
        public Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32> onUpdateCell;        // 0xA0
        public Beyond.DisposedUnityEvent onGraduallyShowFinish;        // 0xA8
        public Beyond.DisposedUnityEvent onScrollEnd;        // 0xB0
        public Beyond.DisposedUnityEvent<System.Int32> onUpdateCount;        // 0xB8
        public System.Func<System.Int32,System.String> getCellName;        // 0xC0
        public static Beyond.DisposedUnityEvent<System.String> s_onGraduallyShowFinish;        // 0x0
        protected System.Boolean _inverse;        // 0xC8
        protected System.Boolean _autoLayoutWhenFew;        // 0xC9
        protected Beyond.UI.UIScrollList.AutoLayoutWhenFewType _autoLayoutWhenFewType;        // 0xCC
        protected System.Boolean _autoCenterInOtherDir;        // 0xD0
        private UnityEngine.Transform _centerNode;        // 0xD8
        private System.Boolean _hideRayCastWhenLessThanOnePage;        // 0xE0
        private System.Boolean _clampWhenLessThanOnePage;        // 0xE1
        private UnityEngine.UI.ScrollRect.MovementType m_lastScrollRectMovementType;        // 0xE4
        protected UnityEngine.RectTransform _container;        // 0xE8
        protected Beyond.UI.UIScrollRect _scrollRect;        // 0xF0
        private System.Int32 <count>k__BackingField;        // 0xF8
        private System.Single <containerSizeWithoutAutoLayout>k__BackingField;        // 0xFC
        protected UnityEngine.RectTransform m_rect;        // 0x100
        protected System.Int32 m_countPerLine;        // 0x108
        protected System.Int32 m_maxShowingLine;        // 0x10C
        protected System.Int32 m_maxShowingCellCount;        // 0x110
        protected System.Int32 m_maxCellCountWhenNoScroll;        // 0x114
        protected System.Single m_viewWidth;        // 0x118
        protected System.Single m_viewHeight;        // 0x11C
        protected System.Single m_cellWidth;        // 0x120
        protected System.Single m_cellHeight;        // 0x124
        protected UnityEngine.UI.Graphic m_graphic;        // 0x128
        protected Beyond.UI.UIScrollList.Padding m_realPadding;        // 0x130
        private UnityEngine.Vector3[] m_cellCorners;        // 0x140
        protected System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIScrollList.Cell> m_showingCells;        // 0x148
        private System.Collections.Generic.Stack<Beyond.UI.UIScrollList.Cell> m_cellCache;        // 0x150
        private static System.String CACHED_CELL_GAME_OBJECT_NAME;        // 0x0
        public UnityEngine.Events.UnityEvent onBeginDrag;        // 0x158
        public UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData> onDrag;        // 0x160
        public UnityEngine.Events.UnityEvent onEndDrag;        // 0x168
        private UnityEngine.GameObject _moveTipsLeftOrTop;        // 0x170
        private UnityEngine.GameObject _moveTipsRightOrBottom;        // 0x178
        private System.Single m_moveTipsIgnoredRange;        // 0x180
        private System.Boolean _useViewEffect;        // 0x184
        private System.Boolean _symmetricViewEffect;        // 0x185
        private System.Boolean _needDummyParent;        // 0x186
        private UnityEngine.AnimationCurve _viewEffectAnimation;        // 0x188
        private UnityEngine.Vector2 _effectAnchorPoint;        // 0x190
        private System.Boolean _useDefaultScaleEffect;        // 0x198
        private UnityEngine.AnimationCurve _scaleEffectAnimation;        // 0x1A0
        private System.Boolean _useDefaultArcEffect;        // 0x1A8
        private UnityEngine.AnimationCurve _arcEffectAnimation;        // 0x1B0
        public UnityEngine.Events.UnityEvent<UnityEngine.GameObject,System.Int32,System.Single> onChangeView;        // 0x1B8
        protected System.Single _tweenDuration;        // 0x1C0
        protected DG.Tweening.Ease _tweenEase;        // 0x1C4
        protected System.Single _changeStepRatio;        // 0x1C8
        protected DG.Tweening.Tween m_adjustTween;        // 0x1D0
        protected System.Single m_totalLength;        // 0x1D8
        protected System.Single m_cellLength;        // 0x1DC
        protected UnityEngine.Vector2 m_centerPos;        // 0x1E0
        public System.Boolean enableAutoScroll;        // 0x1E8
        private System.Single _startAutoScrollTime;        // 0x1EC
        private System.Single _autoScrollSpeed;        // 0x1F0
        public Beyond.UI.UIArea autoScrollUpArea;        // 0x1F8
        public Beyond.UI.UIArea autoScrollDownArea;        // 0x200
        private System.Single m_curAutoScrollSpd;        // 0x208
        private System.Int32 m_autoScrollTimerKey;        // 0x20C
        private System.Boolean _enableGraduallyShow;        // 0x210
        private System.Single _graduallyShowTime;        // 0x214
        private System.Single _graduallyShowDelayTime;        // 0x218
        protected System.Boolean m_inGraduallyShow;        // 0x21C
        private System.Single m_graduallyShowedMaxIndex;        // 0x220
        protected System.Single m_curGraduallyCanShowMaxIndex;        // 0x224
        private System.Boolean m_needInformAnimationInEnd;        // 0x228
        private static System.Single GRADUALLY_SHOW_UPDATE_MAX_INTERVAL;        // 0x0
        public static System.Int32 s_maxGraduallyShowAddCountPerFrame;        // 0x8
        private System.Boolean _enableSelectedNavigation;        // 0x229
        private System.Boolean _noNavigationKeyHint;        // 0x22A
        private System.Boolean _enableNavigationLoop;        // 0x22B
        private System.Boolean _customNavigationActionId;        // 0x22C
        private System.String _customNavigationPreviousActionId;        // 0x230
        private System.String _customNavigationNextActionId;        // 0x238
        public UnityEngine.Events.UnityEvent<UnityEngine.GameObject,System.Int32> onSelectedCell;        // 0x240
        public UnityEngine.Events.UnityEvent<UnityEngine.GameObject,System.Int32,System.Boolean> onCellSelectedChanged;        // 0x248
        public System.Func<System.Int32> getCurSelectedIndex;        // 0x250
        private System.Int32 m_curSelectedIndex;        // 0x258
        private System.Int32 m_bindingGroupId;        // 0x25C
        private System.Int32 m_naviBindingGroupId;        // 0x260
        protected System.Boolean _enableWrapNavigation;        // 0x264
        protected System.Boolean _enableCircleWrapNavigation;        // 0x265
        private System.Boolean _clearNaviGroupOnUpdateCount;        // 0x266
        private System.Collections.Generic.List<UnityEngine.UI.Selectable> m_wrapNaviSelectables;        // 0x268
        private Beyond.UI.LuaPanel m_panel;        // 0x270

        // Methods
        private Beyond.TickType get_tickOption() { }
        private UnityEngine.Vector2 get_space() { }
        private System.Boolean get_autoLayoutWhenFew() { }
        private System.Boolean get_isHorizontal() { }
        private System.Boolean get_isVertical() { }
        private System.Int32 get_count() { }
        private System.Void set_count(System.Int32 value) { }
        private System.Single get_containerSizeWithoutAutoLayout() { }
        private System.Void set_containerSizeWithoutAutoLayout(System.Single value) { }
        private System.Boolean get_isMultiPage() { }
        private System.Int32 get_maxShowingCellCount() { }
        private System.Int32 get_countPerLine() { }
        private System.Single get_cellWidth() { }
        private System.Single get_cellHeight() { }
        private System.Void OnAwake() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void TryRecalculateSize() { }
        private System.Void _InGameAwake() { }
        private System.Void _EditorAwake() { }
        private System.Void Init(System.Boolean isPreview) { }
        private System.Void InitConfig() { }
        private System.Void InitBasicInfo() { }
        private System.Void SyncViewSize() { }
        private System.Void CalcSomeCountNum() { }
        private System.Int32 _GetLineCount(System.Boolean calcVertical) { }
        private System.Void OnScroll(UnityEngine.Vector2 v) { }
        private System.Void SetTop(System.Boolean needUpdate) { }
        private System.Void UpdateCount(System.Int32 newCount, System.Boolean setTop, System.Boolean forceRecalculate, System.Boolean onlyUpdateNewCellContent, System.Boolean skipGraduallyShow) { }
        private System.Void UpdateCount(System.Int32 newCount, System.Int32 fastScrollToIndex, System.Boolean forceRecalculate, System.Boolean onlyUpdateNewCellContent, System.Boolean skipGraduallyShow, Beyond.UI.UIScrollList.ScrollAlignType alignType) { }
        private System.Void UpdateCount(System.Int32 newCount) { }
        private System.Void UpdateShowingCells(System.Action<System.Int32,UnityEngine.GameObject> updateFunc) { }
        private System.Single GetLeftLength(System.Boolean checkVertical, System.Int32 checkCount) { }
        private System.Void _SetRealPadding(System.Boolean isVerticalPadding, System.Single firstAddedLength, System.Single secondAddedLength) { }
        private System.Void UpdateContainerSize() { }
        private System.Single GetContainerSize(System.Boolean ignoreAutoLayout) { }
        private System.Void SetContainerSize(System.Single size) { }
        private System.Void ClearShowingCells() { }
        private System.Void UpdateShowingCells(System.Boolean forceUpdateContent, System.Boolean forceClearShowingCells, System.Boolean ignoreListActive) { }
        private System.Void UpdateCell(System.Int32 index, System.Boolean forceUpdateContent, System.Boolean ignoreListActive) { }
        private UnityEngine.Vector2Int GetShowRange(System.Single bufferSize, System.Boolean ignoreGraduallyShow) { }
        private UnityEngine.Vector2Int GetRangeInView() { }
        private UnityEngine.Vector2Int GetNotCacheRange() { }
        private System.Void MoveCellTo(Beyond.UI.UIScrollList.Cell cell, System.Int32 index) { }
        private System.Void SetCellCanCache(System.Int32 index, System.Boolean canCache) { }
        private System.Void OnUpdateCell(Beyond.UI.UIScrollList.Cell cell, System.Int32 index) { }
        private Beyond.UI.UIScrollList.Cell GetCell() { }
        private System.Void CacheShowingCell(System.Int32 index) { }
        private System.Void CacheCell(Beyond.UI.UIScrollList.Cell cell) { }
        private System.Single get_currentStep() { }
        private System.Void set_currentStep(System.Single value) { }
        private System.Void SetStepTo(System.Single step) { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private Beyond.UI.UIScrollList.MoveTipsType get_moveTips() { }
        private System.Void _UpdateMoveTips() { }
        private System.Void UpdateViewEffect() { }
        private UnityEngine.GameObject Get(System.Int32 index) { }
        private Beyond.UI.UIScrollList.Cell GetCell(System.Int32 index) { }
        private System.Int32 GetRealIndex(System.Int32 index) { }
        private System.Void OnRelease() { }
        private System.Void ClearComponent() { }
        private System.Void SetPaddingBottom(System.Single value) { }
        private System.Void SetPaddingTop(System.Single value) { }
        private System.Void SetPaddingRight(System.Single value) { }
        private System.Void SetPaddingLeft(System.Single value) { }
        private System.Void SetPadding(UnityEngine.Rect value) { }
        private Beyond.UI.UIScrollList.Padding GetPadding() { }
        private System.Void GetShowingCellsIndexRange(System.Int32& firstIndex, System.Int32& lastIndex) { }
        private System.Void SetSpace(UnityEngine.Vector2 newSpace) { }
        private System.Void ScrollToIndex(System.Int32 index, System.Boolean fastMode, Beyond.UI.UIScrollList.ScrollAlignType alignType, System.Boolean graduallyShowInFastMode) { }
        private System.Void ScrollTo(System.Int32 index, System.Boolean fastMode, Beyond.UI.UIScrollList.ScrollAlignType alignType) { }
        private System.Void _ScrollToPos(System.Single targetPos, System.Boolean fastMode) { }
        private System.Void TryClearAdjustTween() { }
        private System.Single GetCenterIndex() { }
        private System.Single GetTargetPosByIndex(System.Int32 index, Beyond.UI.UIScrollList.ScrollAlignType alignType) { }
        private System.Void _InitAutoScroll() { }
        private System.Void _OnEnterAutoScrollUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void _OnExitAutoScrollUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void _OnEnterAutoScrollDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void _OnExitAutoScrollDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void _SetAutoScrollSpd(System.Single spd) { }
        private System.Void _UpdateAutoScroll(System.Single deltaTime) { }
        private System.Void RestartGraduallyShow() { }
        private System.Void _StartGraduallyShow() { }
        private System.Void _UpdateGraduallyShow(System.Single deltaTime) { }
        private System.Void SkipGraduallyShow() { }
        private System.Void StopGraduallyShow() { }
        private System.Int32 get_curSelectedIndex() { }
        private System.Void set_curSelectedIndex(System.Int32 value) { }
        private UnityEngine.GameObject get_curSelectedObj() { }
        private System.Boolean get_enableSelectedNavigation() { }
        private System.Int32 get_naviBindingGroupId() { }
        private System.Void _InitNavigation() { }
        private System.Void NavigateSelected(UnityEngine.UI.NaviDirection dir) { }
        private System.Int32 GetNaviOffset(UnityEngine.UI.NaviDirection dir) { }
        private System.Int32 GetNaviNewIndex(System.Int32 oldIndex, UnityEngine.UI.NaviDirection dir) { }
        private System.Void SetSelectedIndex(System.Int32 index, System.Boolean needNotify, System.Boolean forceUpdate, System.Boolean needScroll) { }
        private System.Void ListWrapNavigate(UnityEngine.UI.NaviDirection dir) { }
        private System.Void _InitControllerNavi() { }
        private System.Void _ClearRelatedNaviGroup() { }
        private Beyond.UI.LuaPanel get_panel() { }
        private System.Int32 GetMousePosIndex(UnityEngine.UI.NaviDirection dir) { }
        private System.Int32 ScreenPos2Index(UnityEngine.Vector2 targetScreenPos, UnityEngine.UI.NaviDirection dir) { }
        private System.Void _GetScreenPosLineColumnInfo(UnityEngine.Vector2 targetScreenPos, System.Int32& line, System.Int32& column) { }
        private System.Int32 GetIndexOf(System.Int32 column, System.Int32 line) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Single <_ScrollToPos>b__158_0() { }
        private System.Void <_ScrollToPos>b__158_1(System.Single x) { }
        private System.Void <_ScrollToPos>b__158_2() { }
        private System.Single <_ScrollToPos>b__158_3() { }
        private System.Void <_ScrollToPos>b__158_4(System.Single y) { }
        private System.Void <_ScrollToPos>b__158_5() { }
        private System.Void <_OnEnterAutoScrollUp>b__171_0() { }
        private System.Void <_OnEnterAutoScrollDown>b__173_0() { }
        private System.Void <_InitNavigation>b__212_0() { }
        private System.Void <_InitNavigation>b__212_1() { }
        private System.Void <_InitNavigation>b__212_2() { }
        private System.Void <_InitNavigation>b__212_3() { }
        private System.Void <_InitNavigation>b__212_4() { }
        private System.Void <_InitNavigation>b__212_5() { }
        private System.Void <_InitNavigation>b__212_6() { }
        private System.Void <_InitNavigation>b__212_7() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x20000DA
    public struct AutoScrollStrategy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.AutoScrollStrategy None;        // 0x0
        public static Beyond.UI.AutoScrollStrategy AlignNearbyBound;        // 0x0
        public static Beyond.UI.AutoScrollStrategy AlignCenter;        // 0x0

    }

    // TypeToken: 0x20000DB
    public class UIScrollRect : ScrollRect, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private DG.Tweening.Core.TweenerCore<UnityEngine.Vector2,UnityEngine.Vector2,DG.Tweening.Plugins.Options.VectorOptions> m_scrollTween;        // 0x150
        public System.Boolean inScrollTween;        // 0x158
        public System.Single smoothScrollTweenSpd;        // 0x15C
        public DG.Tweening.Ease smoothScrollTweenEase;        // 0x160
        private System.Boolean m_lastUpdateIsDragging;        // 0x164
        private Beyond.UI.LuaPanel m_panel;        // 0x168
        protected System.Single _stickScrollSpeed;        // 0x170
        protected System.Single _stickScrollTolerance;        // 0x174
        protected Beyond.UI.UISelectableNaviGroup _naviGroup;        // 0x178
        protected System.Boolean _enableWrapNavigation;        // 0x180
        protected Beyond.Input.InputBindingGroupMonoTarget _scrollBindingGroup;        // 0x188
        public System.Boolean controllerScrollEnabled;        // 0x190
        private System.Boolean m_controllerInited;        // 0x191
        private System.Boolean m_navigationWrapped;        // 0x192
        protected Beyond.UI.AutoScrollStrategy _autoScrollStrategy;        // 0x194
        protected System.Single _alignBoundPaddingX;        // 0x198
        protected System.Single _alignBoundPaddingY;        // 0x19C
        private UnityEngine.GameObject _moveTipsLeftOrTop;        // 0x1A0
        private UnityEngine.GameObject _moveTipsRightOrBottom;        // 0x1A8
        private UnityEngine.Camera m_fallbackUICamera;        // 0x1B0
        private System.Boolean _enableOverScrollEffect;        // 0x1B8
        private System.Single _overScrollTriggerValue;        // 0x1BC
        private UnityEngine.GameObject _overScrollEffectPrevNode;        // 0x1C0
        private UnityEngine.GameObject _overScrollEffectNextNode;        // 0x1C8
        public Beyond.DisposedUnityEvent<System.Boolean> onOverScrollEffect;        // 0x1D0

        // Methods
        private UnityEngine.Vector2 get_contentStartPosition() { }
        private System.Void set_contentStartPosition(UnityEngine.Vector2 value) { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void ScrollTo(UnityEngine.Vector2 position, System.Boolean noTween) { }
        private System.Boolean IsCellViewed(UnityEngine.RectTransform cell) { }
        private System.Void OnDestroy() { }
        private System.Void _CustomSetPosOnScroll(UnityEngine.Vector2 position) { }
        private System.Void UpdateScrollEnableNode() { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void ClearComponent() { }
        private System.Boolean get_dragging() { }
        private System.Void LateUpdate() { }
        private System.Boolean get_controllerStickScrollEnabled() { }
        private Beyond.UI.LuaPanel get_panel() { }
        private Beyond.UI.UISelectableNaviGroup get_naviGroup() { }
        private System.Void _TickRefreshControllerStickScroll() { }
        private System.Void ScrollToNaviTarget(UnityEngine.UI.Selectable target) { }
        private System.Void RectWrapNavigate(UnityEngine.UI.NaviDirection dir) { }
        private System.Void _InitController() { }
        private System.Void WrapNavigation(UnityEngine.Events.UnityAction<UnityEngine.UI.NaviDirection> wrapper) { }
        private System.Void AutoScrollToRectTransform(UnityEngine.RectTransform target, System.Boolean noTween) { }
        private Beyond.UI.UIScrollRect.MoveTipsType get_moveTips() { }
        private System.Void _UpdateMoveTips() { }
        private UnityEngine.Camera _GetUICamera() { }
        private System.Void _CheckOverScrollEffect(UnityEngine.Vector2 value) { }
        private System.Void _CheckOverScrollOnEndDrag(UnityEngine.Vector2 value) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Awake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }
        private System.Void <>iFixBaseProxy__CustomSetPosOnScroll(UnityEngine.Vector2 P0) { }
        private System.Void <>iFixBaseProxy_UpdateScrollEnableNode() { }
        private System.Void <>iFixBaseProxy_OnBeginDrag(UnityEngine.EventSystems.PointerEventData P0) { }
        private System.Void <>iFixBaseProxy_OnDrag(UnityEngine.EventSystems.PointerEventData P0) { }
        private System.Void <>iFixBaseProxy_OnEndDrag(UnityEngine.EventSystems.PointerEventData P0) { }
        private System.Void <>iFixBaseProxy_LateUpdate() { }

    }

    // TypeToken: 0x20000DE
    public class UIScrollRectEdgeRedDot : TickableUIMono
    {
        // Fields
        private Beyond.UI.UIScrollRect m_uiScrollRect;        // 0x68
        private UnityEngine.RectTransform m_uiScrollRectTransform;        // 0x70
        private Beyond.UI.UIScrollList m_uiScrollList;        // 0x78
        private UnityEngine.UI.RectMask2D m_rectMask2D;        // 0x80
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject,Beyond.UI.UIScrollRectEdgeRedDot.RedDotInfo> m_redDotInfoDict;        // 0x88
        private System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState> m_redDotStateDict;        // 0x90
        private UnityEngine.Vector2Int m_scrollListShowRange;        // 0x98
        public System.Func<System.Int32,System.Int32> getRedDotStateAt;        // 0xA0
        private Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState m_upRedDotState;        // 0xA8
        private Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState m_downRedDotState;        // 0xAC
        private UnityEngine.GameObject _upNormal;        // 0xB0
        private UnityEngine.GameObject _upNew;        // 0xB8
        private UnityEngine.GameObject _downNormal;        // 0xC0
        private UnityEngine.GameObject _downNew;        // 0xC8
        private UnityEngine.RectTransform _upParent;        // 0xD0
        private UnityEngine.RectTransform _downParent;        // 0xD8

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void OnAwake() { }
        private System.Void OnEnable() { }
        private System.Void OnRelease() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void ResetReferences() { }
        private System.Void ResetRedDotPosition() { }
        private System.Void _UpdateCacheDictForRangeChange(UnityEngine.Vector2Int newRange) { }
        private System.Void _OnScrollListUpdateCount(System.Int32 newCount) { }
        private System.Void RegisterRedDot(UnityEngine.GameObject redDotRoot, UnityEngine.GameObject redDotNormal, UnityEngine.GameObject redDotNew) { }
        private System.Void UnregisterRedDot(UnityEngine.GameObject redDotRoot) { }
        private System.Void RegisterRedDotStatesForScrollList() { }
        private System.Void UpdateRedDotStateInDir() { }
        private System.Void _CalculateRedDotStateInDir(Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState& upState, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState& downState) { }
        private System.Void _UpdateRedDotGameObjects(UnityEngine.GameObject normal, UnityEngine.GameObject newer, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState state) { }
        private System.Boolean IsRedDotInDir(Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState state, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDir dir, Beyond.UI.UIScrollRectEdgeRedDot.RedDotInfo redDotInfo) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnRelease() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000E2
    public class UIScrollText : TickableUIMono
    {
        // Fields
        private System.Single _speed;        // 0x68
        private System.Single _stayTime;        // 0x6C
        private System.Single _fadeTime;        // 0x70
        private UnityEngine.CanvasGroup _canvasGroup;        // 0x78
        private Beyond.UI.UIScrollText.ScrollMode _scrollMode;        // 0x80
        private System.Boolean _disableClipping;        // 0x84
        private System.Boolean m_isInited;        // 0x85
        private Beyond.UI.UIText m_tmp;        // 0x88
        private UnityEngine.RectTransform m_rect;        // 0x90
        private UnityEngine.RectTransform m_parentRect;        // 0x98
        private Beyond.UI.UIScrollText.IScrollHandler m_scrollHandler;        // 0xA0
        private Beyond.UI.UIScrollText.IAlphaHandler m_alphaHandler;        // 0xA8
        private Beyond.UI.UIScrollText.ScrollState m_state;        // 0xB0
        private System.Single m_scrollOffset;        // 0xB4
        private System.Single m_currStateTime;        // 0xB8
        private System.Boolean m_needScroll;        // 0xBC
        private System.Single m_textDiff;        // 0xC0
        private TMPro.TextAlignmentOptions m_originalAlignment;        // 0xC4

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void _InitIfNot() { }
        private System.Void ResetTextScroll() { }
        private System.Void _ResetTextScrollInternal(System.Boolean needScroll, System.Single textDiff) { }
        private System.Void OnAwake() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void _UpdateScrollState(System.Single deltaTime, System.Single textDiff) { }
        private System.Void _ResetTextScroll() { }
        private System.Void _ApplyTextAlignment(System.Boolean isScroll) { }
        private System.Void _ApplyTextScroll(System.Single scrollOffset) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000EA
    public class UISelectableNaviGroup : SelectableNaviGroup, IUIClearable, ILuaCallCSharp
    {
        // Fields
        public System.Collections.Generic.List<Beyond.Input.InputBindingGroupMonoTarget> relatedInputBindingGroups;        // 0xA0
        public System.Func<UnityEngine.UI.Selectable> getDefaultSelectableFunc;        // 0xA8
        public System.Func<System.Boolean> canFocusFun;        // 0xB0
        public System.String focusActionId;        // 0xB8
        public System.String stopFocusActionId;        // 0xC0
        public System.Boolean hideItemTipsOnUnFocus;        // 0xC8
        public System.Boolean useDefaultTargetOnFocus;        // 0xC9
        public System.Boolean useFocusHighlight;        // 0xCA
        public System.Boolean focusHighlightMask;        // 0xCB
        public System.Boolean focusHighlightNormalFrame;        // 0xCC
        public System.Boolean focusHighlightDarkFrame;        // 0xCD
        public UnityEngine.RectTransform focusOverrideHighlightRect;        // 0xD0
        public System.Int32 focusPanelSortingOrder;        // 0xD8
        public Beyond.UI.UIActionKeyHint focusActionKeyHint;        // 0xE0
        public Beyond.UI.UIActionKeyHint stopFocusActionKeyHint;        // 0xE8
        public UnityEngine.Events.UnityEvent<System.Boolean> onIsFocusedChange;        // 0xF0
        private Beyond.UI.LuaPanel m_luaPanel;        // 0xF8
        private Beyond.Input.InputBindingGroupMonoTarget m_bindingMonoGroup;        // 0x100
        private UnityEngine.RectTransform m_rectTransform;        // 0x108
        private UnityEngine.UI.Selectable m_lastFocusNaviTarget;        // 0x110
        private System.String m_focusBindingText;        // 0x118
        private System.Int32 m_focusBindingId;        // 0x120
        private System.Int32 m_stopFocusBindingId;        // 0x124
        private System.Boolean m_focusBindingCreated;        // 0x128
        private System.Boolean m_isInFocusHighlight;        // 0x129
        private static System.Int32 INVALID_BINDING_ID;        // 0x0

        // Methods
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void _OnIsTopLayerChanged() { }
        private System.Void _OnSelectableNaviGroupDisabled() { }
        private System.Void _BeforeSelectableNaviGroupDestroy() { }
        private System.Void _OnSetLayerSelectedTarget(UnityEngine.UI.Selectable value) { }
        private System.Void _OnRemoveFromLayerStack() { }
        private System.Void NaviToThisGroup(System.Boolean forceDefault) { }
        private System.Void _RefreshRelatedBindingGroupsState() { }
        private UnityEngine.UI.Selectable _FindDefaultSelectable() { }
        private System.Void OnDestroy() { }
        private System.Void ClearComponent() { }
        private System.Void TryChangeNaviPartnerOnUp(Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd) { }
        private System.Void TryChangeNaviPartnerOnDown(Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd) { }
        private System.Void TryChangeNaviPartnerOnLeft(Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd) { }
        private System.Void TryChangeNaviPartnerOnRight(Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd) { }
        private System.Void _TryChangeNaviPartner(System.Collections.Generic.List<UnityEngine.UI.SelectableNaviGroup> list, Beyond.UI.UISelectableNaviGroup partner, System.Boolean isAdd) { }
        private System.Int32 get_FocusBindingId() { }
        private System.Int32 get_StopFocusBindingId() { }
        private UnityEngine.UI.Selectable get_lastFocusNaviTarget() { }
        private System.Void _InitFocusBinding() { }
        private System.Void _RefreshFocusBindings() { }
        private System.Void RefreshFocusBindings() { }
        private System.Void _OnFocus(System.Boolean onlyStartHighlight) { }
        private System.Void _OnStopFocus(System.Boolean onlyStopHighlight, System.Boolean ignoreTopLayerCheck) { }
        private System.Void _RefreshFocusActionKeyHint() { }
        private System.Void _RefreshStopFocusActionKeyHint() { }
        private System.Void ManuallyFocus(System.Boolean onlyStartHighlight) { }
        private System.Void ManuallyStopFocus(System.Boolean onlyStopHighlight) { }
        private System.Void SetFocusBindingText(System.String bindingText) { }
        private System.Void ClearLastFocusNaviTarget() { }
        private System.Void ManuallyRefreshRelatedBindingGroups() { }
        private System.Void .ctor() { }
        private System.Void <_InitFocusBinding>b__51_0() { }
        private System.Void <_InitFocusBinding>b__51_1() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy__OnIsTopLayerChanged() { }
        private System.Void <>iFixBaseProxy__OnSelectableNaviGroupDisabled() { }
        private System.Void <>iFixBaseProxy__BeforeSelectableNaviGroupDestroy() { }
        private System.Void <>iFixBaseProxy__OnSetLayerSelectedTarget(UnityEngine.UI.Selectable P0) { }
        private System.Void <>iFixBaseProxy__OnRemoveFromLayerStack() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x20000EC
    public class UISemiCircleScrollList : TickableUIMono, IDragHandler, IEventSystemHandler, IUIClearable, ILuaCallCSharp, IBeginDragHandler, IEndDragHandler
    {
        // Fields
        public UnityEngine.RectTransform content;        // 0x68
        private System.Single _innerRadius;        // 0x70
        private System.Single _outerRadius;        // 0x74
        private System.Single _padding;        // 0x78
        private System.Int32 _cellCount;        // 0x7C
        private UnityEngine.GameObject _cellPrefab;        // 0x80
        private System.Single _startAngle;        // 0x88
        private System.Boolean _reverseDirection;        // 0x8C
        private UnityEngine.RectTransform m_rectTransform;        // 0x90
        public System.Single currentAngleOffset;        // 0x98
        private System.Single m_targetAngleOffset;        // 0x9C
        private System.Single _hideAngel;        // 0xA0
        private System.Single _duration;        // 0xA4
        private System.Collections.Generic.List<UnityEngine.GameObject> m_cells;        // 0xA8
        private System.Boolean m_inEndDragAnim;        // 0xB0
        private System.Boolean m_inDragging;        // 0xB1
        protected Beyond.Input.InputBindingGroupMonoTarget _scrollBindingGroup;        // 0xB8
        protected System.Single _stickScrollTolerance;        // 0xC0
        protected System.Single _stickScrollSpeed;        // 0xC4
        private System.Int32 m_lastClosestCellIndex;        // 0xC8
        private System.Int32 m_currentCellCount;        // 0xCC
        public Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32> onCellShow;        // 0xD0
        public Beyond.DisposedUnityEvent<System.Int32> onClosestCellChanged;        // 0xD8
        public Beyond.DisposedUnityEvent onDrag;        // 0xE0
        public Beyond.DisposedUnityEvent onEndDrag;        // 0xE8
        private UnityEngine.Coroutine m_dampingCoroutine;        // 0xF0
        private System.String _audioHoldStart;        // 0xF8
        private System.String _audioHoldEnd;        // 0x100
        private System.String _audioAlignment;        // 0x108

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Boolean get_controllerStickScrollEnabled() { }
        private System.Void OnAwake() { }
        private System.Void OnDisable() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void _TickRefreshControllerStickScroll() { }
        private System.Void _InitializeCells() { }
        private System.Void RefreshLayout(System.Int32 newCellCount, System.Int32 targetCellIndex) { }
        private System.Void UpdateLayout() { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void ClearComponent() { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Collections.IEnumerator _ApplyDamping() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000EE
    public class UISemiCircleScrollListPair : MonoBehaviour
    {
        // Fields
        public Beyond.UI.UISemiCircleScrollList m_scrollListMaster;        // 0x18
        public Beyond.UI.UISemiCircleScrollList[] m_scrollLists;        // 0x20
        public Beyond.DisposedUnityEvent<UnityEngine.GameObject,System.Int32> onCellShow;        // 0x28
        public Beyond.DisposedUnityEvent<System.Int32> onClosestCellChanged;        // 0x30

        // Methods
        private System.Void Awake() { }
        private System.Void _OnCellShow(UnityEngine.GameObject go, System.Int32 index) { }
        private System.Void _OnClosestCellChanged(System.Int32 index) { }
        private System.Void _OnDrag() { }
        private System.Void _OnEndDrag() { }
        private System.Void RefreshLayout(System.Int32 newCellCount, System.Int32 targetCellIndex) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EF
    public class UISequenceImage : TickableUIMono
    {
        // Fields
        public System.Boolean autoPlay;        // 0x68
        public System.Single frameRate;        // 0x6C
        public System.Collections.Generic.List<UnityEngine.Sprite> sprites;        // 0x70
        private System.Boolean <isPlaying>k__BackingField;        // 0x78
        private Beyond.UI.UIImage m_image;        // 0x80
        private System.Single m_curFrameCount;        // 0x88

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Boolean get_isPlaying() { }
        private System.Void set_isPlaying(System.Boolean value) { }
        private System.Void OnAwake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void Play() { }
        private System.Void Stop(System.Boolean resetToFirstFrame) { }
        private System.Void SetSprite(System.Int32 index) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000F0
    public class UISimpleActiveAnimationHelper : TickableUIMono
    {
        // Fields
        public System.Boolean isActive;        // 0x68
        public System.String toActiveAnimationName;        // 0x70
        private UnityEngine.Animation m_animation;        // 0x78
        private UnityEngine.AnimationState m_animationState;        // 0x80
        private System.Single m_animationTime;        // 0x88
        private System.Single m_curAnimationTime;        // 0x8C

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.Void Start() { }
        private System.Void OnEnable() { }
        private System.Void Skip() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x20000F1
    public class UISimpleStateController : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<Beyond.UI.UISimpleStateController.StateInfo> _states;        // 0x18
        private System.String m_curStateName;        // 0x20

        // Methods
        private System.String get_curStateName() { }
        private System.Void SetState(System.String stateName) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F3
    public class UISizeFollower : TickableUIMono
    {
        // Fields
        public UnityEngine.RectTransform target;        // 0x68
        public UnityEngine.Vector2 addedSize;        // 0x70
        public System.Boolean isSumSize;        // 0x78
        public System.Boolean followWidth;        // 0x79
        public System.Boolean followHeight;        // 0x7A
        public System.Boolean regulateAnchoredPosition;        // 0x7B
        public UnityEngine.Vector2 minSize;        // 0x7C
        public UnityEngine.Vector2 maxSize;        // 0x84
        private UnityEngine.RectTransform m_rectTransform;        // 0x90

        // Methods
        private Beyond.TickType get_tickOption() { }
        private UnityEngine.RectTransform get_rectTransform() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void SyncSize() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000F4
    public class UISlider : Slider, IUIClearable, ILuaCallCSharp, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IBindingGroupTarget, IBindingView
    {
        // Fields
        public System.Single snapCenterRange;        // 0x1E8
        public System.String audioSlide;        // 0x1F0
        public System.String audioClickHandle;        // 0x1F8
        private System.Boolean m_dragging;        // 0x200
        public UnityEngine.UI.Slider.SliderEvent onEndDragSlider;        // 0x208
        public UnityEngine.UI.Slider.SliderEvent onClickSlider;        // 0x210
        public UnityEngine.UI.Slider.SliderEvent onClickSliderHandle;        // 0x218
        public System.String sliderAddActionId;        // 0x220
        public System.String sliderReduceActionId;        // 0x228
        private readonly Beyond.DisposedUnityEvent <bindingViewUpdateEvent>k__BackingField;        // 0x230
        private System.Int32 m_bindingGroupId;        // 0x238
        private Beyond.Input.IBindingGroupTarget <parentTarget>k__BackingField;        // 0x240
        public System.Boolean snapStep;        // 0x248
        public System.Single stepValue;        // 0x24C
        protected System.Boolean _enableStickScroll;        // 0x250
        protected System.Single _stickScrollTolerance;        // 0x254
        protected System.Single _stickOverPushThreshold;        // 0x258
        protected System.Int32 _stickOverPushMultiplier;        // 0x25C
        protected System.Int32 _stickScrollBatchCount;        // 0x260
        private System.Int32 m_stickScrollHoriBindingId;        // 0x264

        // Methods
        private System.Void _TryPostSlideAudioEvent() { }
        private System.Single ClampValue(System.Single input) { }
        private System.Single CustomProcessNormalizedValue(System.Single val) { }
        private System.Void OnValueChanged() { }
        private System.Void OnClickSliderBar() { }
        private System.Void OnClickSliderHandle() { }
        private System.Void _NotifyIsHover(System.Boolean isHover) { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void ClearComponent() { }
        private System.Void OnDestroy() { }
        private System.String get_bindingViewActionId() { }
        private System.String get_bindingViewLabelText() { }
        private Beyond.DisposedUnityEvent get_bindingViewUpdateEvent() { }
        private UnityEngine.RectTransform get_redDotTrans() { }
        private System.Boolean get_bindingEnabled() { }
        private Beyond.Input.BindingViewState get_bindingViewState() { }
        private System.String GetBindingViewActionId(Beyond.Input.BindingViewActionType actionType) { }
        private System.Void Beyond.Input.IBindingView.OnInputKeyDown() { }
        private System.Void Beyond.Input.IBindingView.OnInputKeyUp() { }
        private System.Int32 get_groupId() { }
        private Beyond.Input.IBindingGroupTarget get_parentTarget() { }
        private System.Void set_parentTarget(Beyond.Input.IBindingGroupTarget value) { }
        private System.Boolean get_groupEnabled() { }
        private System.Void _InitBinding() { }
        private System.Void _AddValue() { }
        private System.Void _ReduceValue() { }
        private System.Void _InitStickScroll() { }
        private System.Void _StickScrollHoriValue() { }
        private System.Void _ApplyStickScroll(System.Single deltaConcern) { }
        private System.Void .ctor() { }
        private System.Boolean Beyond.Input.IBindingView.get_interactable() { }
        private System.Single <>iFixBaseProxy_ClampValue(System.Single P0) { }
        private System.Single <>iFixBaseProxy_CustomProcessNormalizedValue(System.Single P0) { }
        private System.Void <>iFixBaseProxy_OnValueChanged() { }
        private System.Void <>iFixBaseProxy_OnClickSliderBar() { }
        private System.Void <>iFixBaseProxy_OnClickSliderHandle() { }
        private System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0) { }
        private System.Void <>iFixBaseProxy_Awake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x20000F5
    public class UISoftMask : TickableUIMono
    {
        // Fields
        private UnityEngine.Vector3[] m_fourCornersArray;        // 0x68
        private UnityEngine.Vector3[] m_fourCornersArrayWorld;        // 0x70
        private System.Collections.Generic.List<Beyond.UI.UISoftMaskable> m_cacheSoftMaskables;        // 0x78
        private static System.Collections.Generic.List<UnityEngine.Canvas> s_cacheCanvas;        // 0x0
        private static UnityEngine.UI.Image s_image;        // 0x8
        private UnityEngine.Shader _maskableDefaultShader;        // 0x80
        private UnityEngine.Shader _maskableTextShader;        // 0x88
        private static System.Int32 s_SoftMaskTexId;        // 0x10
        private static System.Int32 s_SoftMaskTexSTId;        // 0x14
        private static System.Int32 s_WorldToSoftMaskId;        // 0x18
        private static System.Int32 s_InnerSoftMaskId;        // 0x1C
        private static System.Int32 s_InnerSoftMaskUVId;        // 0x20
        private static System.Int32 s_SpriteSlicedFlag;        // 0x24
        private UnityEngine.Texture m_mainTexture;        // 0x90
        private UnityEngine.Vector4 m_spriteTillingOffset;        // 0x98
        private UnityEngine.Matrix4x4 m_worldToSoftMask;        // 0xA8
        private UnityEngine.Vector4 m_innerSoftMask;        // 0xE8
        private UnityEngine.Vector4 m_innerSoftMaskUV;        // 0xF8
        private Beyond.UI.UISoftMask.SlicedSpriteParams m_slicedSpriteParams;        // 0x108
        private UnityEngine.Material m_softMaskDefaultMaterial;        // 0x130
        private System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> m_softMaskTextMaterials;        // 0x138
        private System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> m_softMaskUIVFXMaterials;        // 0x140

        // Methods
        private Beyond.TickType get_tickOption() { }
        private UnityEngine.Material get_softMaskDefaultMaterial() { }
        private UnityEngine.Material GetTextSoftMaskMaterial(UnityEngine.Material baseMaterial) { }
        private UnityEngine.Material GetUIVFXSoftMaskMaterial(UnityEngine.Material baseMaterial) { }
        private UnityEngine.Vector3 GetCornerCanvas(System.Int32 i) { }
        private UnityEngine.Vector3[] GetFourCornnerArrayWorld() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void TailLateTick(System.Single deltaTime) { }
        private System.Void _Clear() { }
        private System.Void _DestroyMaterial(UnityEngine.Material material) { }
        private System.Void _UpdateParam() { }
        private System.Void _UpdateChildren(System.Boolean markVertices, System.Boolean markMaterial) { }
        private System.Void _OnEnableRuntimeAtlas() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_TailLateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000F7
    public class UISoftMaskable : TickableUIMono, IMaterialModifier, IMeshModifier
    {
        // Fields
        public System.Boolean _clipMeshToSaveOverDraw;        // 0x68
        private System.Collections.Generic.List<UnityEngine.UIVertex> m_cacheVertexSteram;        // 0x70
        private System.Collections.Generic.List<UnityEngine.UIVertex> m_cacheDstVertexSteram;        // 0x78
        protected static readonly System.String UI_MINIMAP_MIST_KEYWORD;        // 0x0
        protected static readonly System.String UI_VFX_PARAM;        // 0x8
        private Beyond.UI.UISoftMaskable.TestLine[] m_testLinesCache;        // 0x80
        private UnityEngine.Material m_softMaskModefiedMat;        // 0x88
        private UnityEngine.UI.Graphic m_graphic;        // 0x90
        private Beyond.UI.UISoftMask m_softMask;        // 0x98
        private Beyond.UI.UIText m_uiText;        // 0xA0
        private Beyond.UI.UISoftMaskable.UIType m_uiType;        // 0xA8

        // Methods
        private Beyond.TickType get_tickOption() { }
        private UnityEngine.Material get_softMaskModefiedMat() { }
        private UnityEngine.UI.Graphic get_graphic() { }
        private Beyond.UI.UISoftMask get_softMask() { }
        private Beyond.UI.UIText get_uiText() { }
        private UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void MarkGraphicVerticesDirty() { }
        private System.Void MarkGraphicMaterialDirty() { }
        private System.Void ModifyMesh(UnityEngine.Mesh mesh) { }
        private System.Boolean _Equal(System.Single a, System.Single b) { }
        private UnityEngine.Vector2 _ComputeLineCross(UnityEngine.Vector2 line0p0, UnityEngine.Vector2 line0p1, UnityEngine.Vector2 line1p0, UnityEngine.Vector2 line1p1) { }
        private System.Void _ComputePointAtTriangleUV(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 q, System.Single& u, System.Single& v) { }
        private System.Void _ClipTriangleByClampSoftMaskUV(UnityEngine.UIVertex[] vertices, UnityEngine.UIVertex[] resultPoint, System.Boolean& canSkip) { }
        private System.Void _ClipRect() { }
        private System.Void ModifyMesh(UnityEngine.UI.VertexHelper vertHelper) { }
        private System.Void _SetUIVertexUV(UnityEngine.UIVertex& uiVertex, UnityEngine.Vector2 uv0, UnityEngine.Vector2 uv1, UnityEngine.Vector2 softMaskUV) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }

    }

    // TypeToken: 0x20000FA
    public class UISortingOrder : MonoBehaviour
    {
        // Fields
        private System.Int32 _sortingOrderOffset;        // 0x18
        private Beyond.UI.UISortingOrder.RenderType _renderType;        // 0x1C
        private UnityEngine.Renderer m_renderer;        // 0x20
        private UnityEngine.Renderer[] m_childrenRenderers;        // 0x28
        private UnityEngine.Canvas m_canvas;        // 0x30
        private Beyond.UI.LuaPanel m_luaPanel;        // 0x38

        // Methods
        private System.Void OnEnable() { }
        private System.Void _GetRenderer() { }
        private System.Void _GetChildrenRenderers() { }
        private System.Void _GetCanvas() { }
        private System.Void SetOrder(System.Int32 baseOrder) { }
        private System.Void Awake() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FC
    public class UIStepScrollList : UIScrollList
    {
        // Fields
        public Beyond.DisposedUnityEvent<System.Int32,System.Int32> onCenterIndexChanged;        // 0x278
        public Beyond.DisposedUnityEvent onScrollOrDragEnd;        // 0x280
        public Beyond.DisposedUnityEvent onScrollOrDragStart;        // 0x288
        protected System.Single _easyDragSpdThreshold;        // 0x290
        protected System.Single _easyDragDistPercentThreshold;        // 0x294
        private System.Int32 m_startDragCenterIndex;        // 0x298
        private System.Int32 m_centerIndex;        // 0x29C
        private UnityEngine.Vector2 m_scrollStartNormalizedPos;        // 0x2A0

        // Methods
        private System.Int32 get_centerIndex() { }
        private System.Void Init(System.Boolean isPreview) { }
        private System.Void InitConfig() { }
        private System.Void OnScroll(UnityEngine.Vector2 v) { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void SetTop(System.Boolean needUpdate) { }
        private System.Void UpdateShowingCells(System.Boolean forceUpdateContent, System.Boolean forceClearShowingCells, System.Boolean ignoreListActive) { }
        private System.Void ClearComponent() { }
        private System.Void _OnScrollStart(UnityEngine.Vector2 normalizedPos) { }
        private System.Void _OnScrollEnd(UnityEngine.Vector2 normalizedPos) { }
        private System.Void _TryAutoScroll(System.Boolean isEasyDrag, System.Boolean goNext) { }
        private System.Int32 _GetClampedIndex() { }
        private System.Void OnDisable() { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Init(System.Boolean P0) { }
        private System.Void <>iFixBaseProxy_InitConfig() { }
        private System.Void <>iFixBaseProxy_OnScroll(UnityEngine.Vector2 P0) { }
        private System.Void <>iFixBaseProxy_OnBeginDrag(UnityEngine.EventSystems.PointerEventData P0) { }
        private System.Void <>iFixBaseProxy_OnEndDrag(UnityEngine.EventSystems.PointerEventData P0) { }
        private System.Void <>iFixBaseProxy_SetTop(System.Boolean P0) { }
        private System.Void <>iFixBaseProxy_UpdateShowingCells(System.Boolean P0, System.Boolean P1, System.Boolean P2) { }
        private System.Void <>iFixBaseProxy_ClearComponent() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }

    }

    // TypeToken: 0x20000FD
    public class UIStyleByState : MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<Beyond.UI.UIStyleByState.StyleConfig> styleConfigs;        // 0x18

        // Methods
        private System.Void Awake() { }
        private System.Void OnDestroy() { }
        private System.Void UpdateStyle() { }
        private System.Boolean _IsValidStyle(Beyond.UI.UIStyleByState.StyleConfig styleConfig) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000100
    public class UISubtitle : MonoBehaviour
    {
        // Fields
        private Beyond.UI.UIText _topText;        // 0x18
        private Beyond.UI.UIText _bottomText;        // 0x20

        // Methods
        private System.Void Start() { }
        private System.Void _SetAsDefault() { }
        private System.Void SetSubtitle(System.String subtitle, System.Boolean showOnTop) { }
        private System.Void UpdateAlpha(System.Single alpha, System.Boolean isTop) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000101
    public class UITextPair : MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<Beyond.UI.UIText> referencedTexts;        // 0x18

        // Methods
        private System.String get_text() { }
        private System.Void set_text(System.String value) { }
        private System.Void set_color(UnityEngine.Color value) { }
        private Beyond.UI.UIText get_first() { }
        private System.Void SetAndResolveTextStyle(System.String targetText) { }
        private System.Void SetPhoneticText(Beyond.GEnums.PhoneticType phoneticType, System.String id) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000102
    public class UIToggle : Toggle, IUIClearable, ILuaCallCSharp
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.GameObject> _onObjects;        // 0x1A8
        private System.Collections.Generic.List<UnityEngine.GameObject> _offObjects;        // 0x1B0
        private Beyond.UI.UIState.UIStateController _uiStateController;        // 0x1B8
        private System.String _onStateName;        // 0x1C0
        private System.String _offStateName;        // 0x1C8
        private System.String _onAnimation;        // 0x1D0
        private System.String _offAnimation;        // 0x1D8
        private System.String _audioToggleOn;        // 0x1E0
        private System.String _audioToggleOff;        // 0x1E8
        private System.String _audioInvalid;        // 0x1F0
        public System.Boolean _ignoreClickOnDrag;        // 0x1F8
        private UnityEngine.Vector2 <startPressPos>k__BackingField;        // 0x1FC
        private Beyond.LangKey _invalidClickLangKey;        // 0x208
        public System.Func<System.Boolean,System.Boolean> checkIsValueValid;        // 0x218
        private UnityEngine.Animation m_animation;        // 0x220
        private System.Int32 m_groupId;        // 0x228
        public System.String toggleActionId;        // 0x230
        private System.Int32 <toggleBindingId>k__BackingField;        // 0x238
        private System.Boolean m_started;        // 0x23C
        public System.String clickOnHintTextId;        // 0x240
        public System.String clickOffHintTextId;        // 0x248
        private Beyond.Input.ActionOnSetNaviTarget _actionOnSetNaviTarget;        // 0x250
        private System.Boolean _useNoHintAction;        // 0x254
        public System.String onHintTextId;        // 0x258
        public System.String offHintTextId;        // 0x260
        private System.Int32 <hoverConfirmBindingId>k__BackingField;        // 0x268

        // Methods
        private UnityEngine.Vector2 get_startPressPos() { }
        private System.Void set_startPressPos(UnityEngine.Vector2 value) { }
        private System.Int32 get_toggleBindingId() { }
        private System.Void set_toggleBindingId(System.Int32 value) { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void _UpdateBindingEnable() { }
        private System.Void OnDestroy() { }
        private System.Void Start() { }
        private System.Void InternalToggle() { }
        private System.Void _InitToggleBinding() { }
        private System.Boolean _OnToggleFail() { }
        private System.Void PlayAudio() { }
        private System.Void OnValueChange() { }
        private System.Void _NotifyIsHover(System.Boolean isHover) { }
        private System.Void _UpdateObjects() { }
        private System.Void _PlayAnimation(System.Boolean skipToEnd) { }
        private System.Void ClearComponent() { }
        private System.Void OnInteractableChanged() { }
        private System.Boolean GetMouseActionHints(System.String& clickHintTextId, System.String& longPressHintTextId) { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void TryInternalToggle() { }
        private System.Int32 get_hoverConfirmBindingId() { }
        private System.Void set_hoverConfirmBindingId(System.Int32 value) { }
        private System.Void OnNaviTargetEnabledAgain() { }
        private System.Void _OnSetAsNaviTarget(System.Boolean isTarget, System.Boolean silentMode) { }
        private System.Void _InitActionOnSetNaviTarget() { }
        private System.Void _ToggleNaviInputBinding(System.Boolean active) { }
        private System.Void _TryRefreshToggleBindingText() { }
        private System.Void _TryRefreshHoverConfirmBindingText() { }
        private System.Void _TryRefreshBindingText(System.Int32 bindingId) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Awake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }
        private System.Void <>iFixBaseProxy_Start() { }
        private System.Void <>iFixBaseProxy_InternalToggle() { }
        private System.Void <>iFixBaseProxy_OnValueChange() { }
        private System.Void <>iFixBaseProxy__NotifyIsHover(System.Boolean P0) { }
        private System.Void <>iFixBaseProxy_OnInteractableChanged() { }
        private System.Boolean <>iFixBaseProxy_GetMouseActionHints(System.String& P0, System.String& P1) { }
        private System.Void <>iFixBaseProxy_OnPointerDown(UnityEngine.EventSystems.PointerEventData P0) { }
        private System.Void <>iFixBaseProxy_OnPointerClick(UnityEngine.EventSystems.PointerEventData P0) { }
        private System.Void <>iFixBaseProxy_OnSubmit(UnityEngine.EventSystems.BaseEventData P0) { }
        private System.Void <>iFixBaseProxy_OnNaviTargetEnabledAgain() { }
        private System.Void <>iFixBaseProxy__OnSetAsNaviTarget(System.Boolean P0, System.Boolean P1) { }

    }

    // TypeToken: 0x2000103
    public class UIToggleGroup : ToggleGroup
    {
        // Fields
        private System.String _moveToNextActionId;        // 0x28
        private System.String _moveToPreviousActionId;        // 0x30
        private System.Boolean _inverse;        // 0x38
        private System.Int32 <moveToNextBindingId>k__BackingField;        // 0x3C
        private System.Int32 <moveToPreviousBindingId>k__BackingField;        // 0x40

        // Methods
        private System.Int32 get_moveToNextBindingId() { }
        private System.Void set_moveToNextBindingId(System.Int32 value) { }
        private System.Int32 get_moveToPreviousBindingId() { }
        private System.Void set_moveToPreviousBindingId(System.Int32 value) { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void MoveToNext() { }
        private System.Void MoveToPrevious() { }
        private System.Void _MoveTo(System.Boolean isNext) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Awake() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }

    }

    // TypeToken: 0x2000104
    public struct FingerMoveDirection
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.FingerMoveDirection None;        // 0x0
        public static Beyond.UI.FingerMoveDirection Anisotropy;        // 0x0
        public static Beyond.UI.FingerMoveDirection Same;        // 0x0

    }

    // TypeToken: 0x2000105
    public class UITouchPanel : TickableUIMono, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler, IScrollHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IUIClearable, ILuaCallCSharp, IBindingGroupTarget
    {
        // Fields
        private System.Single _gestureZoomSensitivity;        // 0x68
        private System.Single _dragThreshold;        // 0x6C
        private System.Single _longPressTime;        // 0x70
        private System.Single _longPressMaxDist;        // 0x74
        private System.Single _mouseZoomSensitivity;        // 0x78
        private System.Single _scrollZoomSensitivity;        // 0x7C
        private System.Boolean _useGesturePixelSizeAdjustment;        // 0x80
        private System.Single _multiClickInterval;        // 0x84
        private System.Int32 _multiClickPixelOffset;        // 0x88
        private System.Boolean _ignoreClickOnLongPress;        // 0x8C
        private System.Boolean _clickThrough;        // 0x8D
        private System.Boolean _preventPressWhenClickThrough;        // 0x8E
        private System.Boolean m_triggeredLongPress;        // 0x8F
        private System.Int32 m_clickCount;        // 0x90
        private System.Single m_lastClickTime;        // 0x94
        private UnityEngine.Vector2 m_lastClickPos;        // 0x98
        private System.Boolean m_isPress;        // 0xA0
        private System.Boolean m_isInGestureZoom;        // 0xA1
        private System.Boolean m_isActionLongPress;        // 0xA2
        private System.Boolean m_dragStarted;        // 0xA3
        private UnityEngine.Vector2 m_dragPosition;        // 0xA4
        private UnityEngine.RectTransform m_rect;        // 0xB0
        private System.Single m_deltaX;        // 0xB8
        private System.Single m_deltaY;        // 0xBC
        private UnityEngine.Vector2 m_lastFrameTouchPos;        // 0xC0
        private UnityEngine.EventSystems.PointerEventData m_touch;        // 0xC8
        private System.Int32 m_touchId;        // 0xD0
        private System.Int32 m_touchId1;        // 0xD4
        private System.Int32 m_touchId2;        // 0xD8
        private System.Single m_actionLongPressStartTime;        // 0xDC
        private UnityEngine.Vector2 m_actionLongPressStartPos;        // 0xE0
        private System.Single m_pixelSizeAdjustment;        // 0xE8
        private UnityEngine.Vector2 m_touch1Pos;        // 0xEC
        private UnityEngine.Vector2 m_touch1LastPos;        // 0xF4
        private UnityEngine.Vector2 m_touch2Pos;        // 0xFC
        private UnityEngine.Vector2 m_touch2LastPos;        // 0x104
        private UnityEngine.Vector3 m_lastMousePos;        // 0x10C
        private System.Boolean m_lastFrameIsRightMouseButtonPress;        // 0x118
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onClick;        // 0x120
        public Beyond.Input.UIEvent<UnityEngine.EventSystems.PointerEventData> onRightClick;        // 0x128
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onPress;        // 0x130
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onLongPress;        // 0x138
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onDoubleClick;        // 0x140
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onRelease;        // 0x148
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> onDrag;        // 0x150
        public Beyond.DisposedUnityEvent<UnityEngine.Vector2> onDragBegin;        // 0x158
        public Beyond.DisposedUnityEvent<UnityEngine.Vector2> onDragEnd;        // 0x160
        public Beyond.DisposedUnityEvent<System.Single> onZoom;        // 0x168
        public Beyond.DisposedUnityEvent<UnityEngine.Vector2,Beyond.UI.FingerMoveDirection> onHorizonAndVerticalZoom;        // 0x170
        public Beyond.DisposedUnityEvent onDragToLeft;        // 0x178
        public Beyond.DisposedUnityEvent onDragToRight;        // 0x180
        public Beyond.DisposedUnityEvent onPointerEnter;        // 0x188
        public Beyond.DisposedUnityEvent onPointerExit;        // 0x190
        public Beyond.DisposedUnityEvent onDragToUp;        // 0x198
        public Beyond.DisposedUnityEvent onDragToDown;        // 0x1A0
        public Beyond.DisposedUnityEvent<UnityEngine.Vector2> onRightMouseButtonPress;        // 0x1A8
        public Beyond.DisposedUnityEvent<System.Single> onScroll;        // 0x1B0
        private UnityEngine.Vector2 <curPressPos>k__BackingField;        // 0x1B8
        private System.Boolean <isPointerEntered>k__BackingField;        // 0x1C0
        public System.Boolean enableZoom;        // 0x1C1
        public Beyond.DisposedUnityEvent<UnityEngine.EventSystems.PointerEventData> rawOnDrag;        // 0x1C8
        private System.Single m_leftMousePressDownTimeWithNoCursor;        // 0x1D0
        private System.Single m_rightMousePressDownTimeWithNoCursor;        // 0x1D4
        private System.Int32 m_groupId;        // 0x1D8
        private System.Boolean m_bindingInit;        // 0x1DC
        private Beyond.Input.InputBindingGroupMonoTarget <parent>k__BackingField;        // 0x1E0

        // Methods
        private Beyond.TickType get_tickOption() { }
        private UnityEngine.Vector2 get_touchPos() { }
        private UnityEngine.Vector2 get_curPressPos() { }
        private System.Void set_curPressPos(UnityEngine.Vector2 value) { }
        private System.Boolean get_isPointerEntered() { }
        private System.Void set_isPointerEntered(System.Boolean value) { }
        private System.Boolean get_isDragging() { }
        private System.Void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void DoEndDrag(UnityEngine.Vector2 dragPos) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void _OnActionPress(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void _OnActionRelease(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Boolean _IsSameTouchFromPress(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void ClearTouchInfo() { }
        private System.Void OnScroll(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void SimulateClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void DeActiveTouch(System.Int32 touchId) { }
        private System.Void OnAwake() { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void OnRelease() { }
        private System.Boolean get_groupEnabled() { }
        private System.Int32 get_groupId() { }
        private Beyond.Input.IBindingGroupTarget get_parentTarget() { }
        private Beyond.Input.InputBindingGroupMonoTarget get_parent() { }
        private System.Void set_parent(Beyond.Input.InputBindingGroupMonoTarget value) { }
        private System.Void InitBinding() { }
        private System.Void _UpdateState() { }
        private System.Void ClearComponent() { }
        private System.Void .ctor() { }
        private System.Void <InitBinding>b__110_0() { }
        private System.Void <InitBinding>b__110_1() { }
        private System.Void <>iFixBaseProxy_OnAwake() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }
        private System.Void <>iFixBaseProxy_OnRelease() { }

    }

    // TypeToken: 0x2000106
    public class UIVFXManager : TickableUIMono, IMaterialModifier
    {
        // Fields
        private static System.Int32 s_vfxMainTexSTId;        // 0x0
        private UnityEngine.Vector4 m_spriteTillingOffset;        // 0x68
        private UnityEngine.Material m_uiDefaultVFXMaterial;        // 0x78
        private System.Collections.Generic.Dictionary<UnityEngine.Material,UnityEngine.Material> m_UIVfxMaterials;        // 0x80
        private UnityEngine.Shader m_uiDefaultShader;        // 0x88
        private UnityEngine.UI.Graphic m_graphic;        // 0x90
        private Beyond.UI.UISoftMaskable m_softMaskable;        // 0x98

        // Methods
        private Beyond.TickType get_tickOption() { }
        private UnityEngine.UI.Graphic get_graphic() { }
        private Beyond.UI.UISoftMaskable get_softMaskable() { }
        private System.Void OnEnable() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void _OnEnableRuntimeAtlas() { }
        private System.Void OnDisable() { }
        private System.Void _Clear() { }
        private System.Void _DestroyMaterial(UnityEngine.Material material) { }
        private System.Void _UpdateParam() { }
        private UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_LateTick(System.Single P0) { }
        private System.Void <>iFixBaseProxy_OnDisable() { }

    }

    // TypeToken: 0x2000107
    public class UIWorldLevelScrollListAnimCtrl : MonoBehaviour
    {
        // Fields
        public Beyond.UI.UIWorldLevelScrollListAnimCtrl.ScrollListLayoutInfo upLayoutGroup;        // 0x18
        public Beyond.UI.UIWorldLevelScrollListAnimCtrl.ScrollListLayoutInfo downLayoutGroup;        // 0x20
        public Beyond.UI.UIWorldLevelScrollListAnimCtrl.ScrollListLayoutInfo middleLayoutGroup;        // 0x28
        public UnityEngine.AnimationCurve speedCurve;        // 0x30
        private System.Collections.IEnumerator m_enumerator;        // 0x38
        private System.String _audioEnd;        // 0x40

        // Methods
        private System.Void UpdateUpPos(System.Int32 current) { }
        private System.Void UpdateDownPos(System.Int32 current) { }
        private System.Void UpdateMidPos(System.Int32 current) { }
        private System.Void UpdateWorldLevelScrollList(System.Boolean isUp, System.Int32 count) { }
        private System.Void OnDisable() { }
        private System.Collections.IEnumerator _ScrollLayouts(System.Boolean isUp, System.Int32 count) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010A
    public class VirtualMouseInitPos : MonoBehaviour
    {
        // Fields
        private Beyond.UI.LuaPanel m_panel;        // 0x18

        // Methods
        private Beyond.UI.LuaPanel get_panel() { }
        private System.Void OnEnable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010B
    public class CSPopupPanel : MonoBehaviour
    {
        // Fields
        public static System.String KEY;        // 0x0
        public Beyond.UI.UIButton confirmBtn;        // 0x18
        public Beyond.UI.UIButton cancelBtn;        // 0x20
        public Beyond.UI.UIText contentTxt;        // 0x28
        public UnityEngine.GameObject bg1;        // 0x30
        public UnityEngine.GameObject bg2;        // 0x38
        public UnityEngine.GameObject warningImg;        // 0x40
        public Beyond.UI.UIScrollRect scrollRect;        // 0x48
        private System.Action m_onConfirm;        // 0x50
        private System.Action m_onCancel;        // 0x58
        private static Beyond.Resource.FAssetProxyHandle s_handle;        // 0x0
        public System.Int32 timeScaleKey;        // 0x60

        // Methods
        private System.Void Awake() { }
        private System.Void _OnConfirm(UnityEngine.EventSystems.PointerEventData p) { }
        private System.Void _OnCancel(UnityEngine.EventSystems.PointerEventData p) { }
        private System.Void OnDestroy() { }
        private System.Void Show(System.String content, System.Action onConfirm, System.Boolean showCancel, System.Action onCancel, System.String confirmTxt, System.String cancelTxt, System.Boolean showWarning) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010C
    public class LuaUIRoot : MonoBehaviour, ILuaCallCSharp
    {
        // Fields
        public Beyond.SerializeReferenceDictionary<System.String,Beyond.UI.LuaUIRootNode> nodeDic;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010D
    public class LuaUIRootNode : MonoBehaviour, ILuaCallCSharp
    {
        // Fields
        public System.String panelName;        // 0x18
        public System.String panelFolder;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010E
    public class MobileMotionManager : BaseManager
    {
        // Fields
        private static System.String COMMON_MOTION_SHORT;        // 0x0
        private static System.String COMMON_MOTION_OPERATE_SUCCESS;        // 0x0
        private static System.String COMMON_MOTION_OPERATE_FAILURE;        // 0x0
        private static System.String MOTION_LEVEL_LOW;        // 0x0
        private static System.String MOTION_LEVEL_MEDIUM;        // 0x0
        private static System.String MOTION_LEVEL_HIGH;        // 0x0
        private Beyond.UI.MobileMotionManager.MotionLevel m_currMotionLevel;        // 0x18

        // Methods
        private System.Void OnInit() { }
        private System.Void OnRelease() { }
        private System.UInt32 PostEventCommonShort() { }
        private System.UInt32 PostEventCommonOperateSuccess() { }
        private System.UInt32 PostEventCommonOperateFailure() { }
        private System.UInt32 PostEvent(System.String eventName) { }
        private System.Void _CheckMotionLevelAndPostIfChange() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000110
    public class I18nFontLoader
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Int32,Beyond.Resource.FAssetProxyHandle> s_id2FontDic;        // 0x0
        private static System.Collections.Generic.Dictionary<System.String,Beyond.Resource.FAssetProxyHandle> s_name2MaterialDic;        // 0x8
        private static Beyond.Resource.FAssetProxyHandle s_fontSearchDataHandle;        // 0x10

        // Methods
        private Beyond.I18n.I18nFontSearchData get_fontSearchData() { }
        private UnityEngine.Material GetMaterial(System.String matName) { }
        private TMPro.TMP_FontAsset GetI18nFont(System.Int32 cnFontId) { }
        private System.Int32 GetCNFontId(TMPro.TMP_FontAsset font) { }
        private System.Boolean IsFontDefaultMaterial(UnityEngine.Material mat) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000111
    public class DynamicFontAssetLoader, IFontAssetLoader
    {
        // Fields
        private System.Collections.Generic.List<Beyond.UI.DynamicFontAssetLoader.FontAssetRef> <fontAssets>k__BackingField;        // 0x10
        private static System.Collections.Generic.HashSet<System.UInt32> s_notFoundUnicodes;        // 0x0

        // Methods
        private System.Collections.Generic.List<Beyond.UI.DynamicFontAssetLoader.FontAssetRef> get_fontAssets() { }
        private System.Void set_fontAssets(System.Collections.Generic.List<Beyond.UI.DynamicFontAssetLoader.FontAssetRef> value) { }
        private System.Void .ctor() { }
        private System.Void AddNotFoundUnicode(System.UInt32 unicode, System.Boolean forceLog) { }
        private System.Boolean TryGetFontAsset(TMPro.TMP_Text refText, System.UInt32 unicode, TMPro.TMP_FontAsset& fontAsset) { }
        private System.Void TryRemoveRefText(TMPro.TMP_Text refText) { }
        private System.Void Dispose() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000113
    public class TweenUtils
    {
        // Methods
        private System.Boolean TickAsCountDown(System.Single& countDown, System.Single timeDelta) { }

    }

    // TypeToken: 0x2000115
    public class UIAnimationLayerMixPlayer : SingleMixerAssetPlayer`4
    {
        // Fields
        private UnityEngine.Animator m_target;        // 0x60
        private System.String m_outputName;        // 0x68

        // Methods
        private System.Void .ctor(UnityEngine.Animator target, System.String outputName) { }
        private System.Void LockToClip(UnityEngine.AnimationClip clip, System.Single clipPos) { }
        private UnityEngine.Playables.PlayableGraph CreateGraph() { }
        private UnityEngine.Animations.AnimationLayerMixerPlayable CreateMixer(UnityEngine.Playables.PlayableGraph graph, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FMixerOptions<UnityEngine.AnimationClip>& options) { }
        private UnityEngine.Animations.AnimationPlayableOutput CreateOutput(UnityEngine.Playables.PlayableGraph graph) { }
        private UnityEngine.Animations.AnimationClipPlayable CreateSourceFromAsset(UnityEngine.AnimationClip clip, UnityEngine.Playables.PlayableGraph graph, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FPlayableMeta<UnityEngine.AnimationClip>& meta) { }

    }

    // TypeToken: 0x2000116
    public class UIAnimationMixPlayer : SingleMixerAssetPlayer`4
    {
        // Fields
        private UnityEngine.Animator m_target;        // 0x60
        private System.String m_outputName;        // 0x68

        // Methods
        private System.Void .ctor(UnityEngine.Animator target, System.String outputName) { }
        private System.Void LockToClip(UnityEngine.AnimationClip clip, System.Single clipPos) { }
        private UnityEngine.Playables.PlayableGraph CreateGraph() { }
        private UnityEngine.Animations.AnimationMixerPlayable CreateMixer(UnityEngine.Playables.PlayableGraph graph, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FMixerOptions<UnityEngine.AnimationClip>& options) { }
        private UnityEngine.Animations.AnimationPlayableOutput CreateOutput(UnityEngine.Playables.PlayableGraph graph) { }
        private UnityEngine.Animations.AnimationClipPlayable CreateSourceFromAsset(UnityEngine.AnimationClip clip, UnityEngine.Playables.PlayableGraph graph, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FPlayableMeta<UnityEngine.AnimationClip>& meta) { }

    }

    // TypeToken: 0x2000117
    public class UIListCache`1
    {
        // Fields
        private Beyond.UI.UIListCache.FOptions<TComp> m_options;        // 0x0
        private System.Collections.Generic.List<Beyond.UI.UIListCache.ItemWrapper<TComp>> m_items;        // 0x0
        private System.Int32 m_count;        // 0x0

        // Methods
        private System.Void .ctor(Beyond.UI.UIListCache.FOptions<TComp> options) { }
        private System.Void Refresh(System.Int32 count, System.Action<TComp,System.Int32> refreshFunc, System.Boolean shouldHide, System.Action<TComp,System.Int32> onDisableFunc) { }
        private TComp GetItem(System.Int32 index) { }
        private Beyond.UI.UIListCache.ItemWrapper<TComp> _CreateNewItem() { }

    }

    // TypeToken: 0x200011A
    public class UILoadImageSprite : MonoBehaviour
    {
        // Fields
        public System.Boolean isAsync;        // 0x18
        public System.Boolean setNativeSize;        // 0x19
        protected System.String m_spritePath;        // 0x20
        protected UnityEngine.UI.Image m_imageComp;        // 0x28
        protected Beyond.Resource.FAssetProxyHandle m_handle;        // 0x30

        // Methods
        private System.String get_spritePath() { }
        private System.Void set_spritePath(System.String value) { }
        private System.Void OnDestroy() { }
        private System.Void _LoadSprite(System.String path) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011C
    public class UILoadImageSpriteByName : UILoadImageSprite
    {
        // Fields
        private System.String _folderPath;        // 0x48

        // Methods
        private System.Void set_spriteName(System.String value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011D
    public class UISwitchTween
    {
        // Fields
        private Beyond.UI.UISwitchTween.Options m_options;        // 0x10
        private Beyond.UI.UISwitchTween.ITweenHandler m_tween;        // 0x20
        private System.Boolean m_isInited;        // 0x28
        private System.Boolean m_isShowing;        // 0x29
        private Beyond.UI.UISwitchTween.TweenContext m_context;        // 0x2C

        // Methods
        private Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfShow() { }
        private Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfHide() { }
        private System.Void BeforeShowEffect() { }
        private System.Void BeforeHideEffect() { }
        private System.Void AfterShowEffect() { }
        private System.Void AfterHideEffect() { }
        private System.Void ResetToState(System.Boolean isShow) { }
        private System.Void Show() { }
        private System.Void Hide() { }
        private System.Collections.IEnumerator WaitForTweening() { }
        private System.Void SetOptions(Beyond.UI.UISwitchTween.Options options) { }
        private System.Boolean get_isTweening() { }
        private System.Boolean get_isShow() { }
        private System.Void set_isShow(System.Boolean value) { }
        private System.Void Reset(System.Boolean isShow) { }
        private System.Void Clear() { }
        private System.Void _ClearTweenInternal(System.Boolean isReset) { }
        private Beyond.UI.UISwitchTween.TweenContext GetContext() { }
        private System.Void ClearTween() { }
        private System.Void .ctor() { }
        private System.Void <Show>b__17_0() { }
        private System.Void <Hide>b__18_0() { }

    }

    // TypeToken: 0x2000124
    public class FadeSwitchTween : UISwitchTween
    {
        // Fields
        public static System.Single DEFAULT_TWEEN_DURATION;        // 0x0
        private UnityEngine.CanvasGroup m_alphaHandler;        // 0x30
        private System.Boolean m_ignoreTimeScale;        // 0x38
        private System.Single m_activeAlpha;        // 0x3C
        private System.Boolean <dontDisableGameObject>k__BackingField;        // 0x40
        private System.Boolean <controlBlockRaycast>k__BackingField;        // 0x41
        private Beyond.UI.FadeSwitchTween.Durations <complexDuration>k__BackingField;        // 0x44
        private System.Single <duration>k__BackingField;        // 0x54

        // Methods
        private System.Boolean get_dontDisableGameObject() { }
        private System.Void set_dontDisableGameObject(System.Boolean value) { }
        private System.Boolean get_controlBlockRaycast() { }
        private System.Void set_controlBlockRaycast(System.Boolean value) { }
        private Beyond.UI.FadeSwitchTween.Durations get_complexDuration() { }
        private System.Void set_complexDuration(Beyond.UI.FadeSwitchTween.Durations value) { }
        private System.Void .ctor(UnityEngine.CanvasGroup alphaHandler, System.Boolean ignoreTimeScale) { }
        private System.Void .ctor(UnityEngine.CanvasGroup alphaHandler, System.Single duration, System.Boolean ignoreTimeScale) { }
        private System.Single get_duration() { }
        private System.Void set_duration(System.Single value) { }
        private UnityEngine.CanvasGroup get_alphaHandler() { }
        private System.Single get_activeAlpha() { }
        private System.Void set_activeAlpha(System.Single value) { }
        private Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfHide() { }
        private Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfShow() { }
        private System.Void BeforeShowEffect() { }
        private System.Void AfterHideEffect() { }
        private System.Void ResetToState(System.Boolean isShow) { }
        private System.Void SetObjectActive(UnityEngine.CanvasGroup alphaHandler, System.Boolean isActive) { }
        private System.Void Release() { }
        private System.Void <>iFixBaseProxy_BeforeShowEffect() { }
        private System.Void <>iFixBaseProxy_AfterHideEffect() { }
        private System.Void <>iFixBaseProxy_ResetToState(System.Boolean P0) { }

    }

    // TypeToken: 0x2000127
    public class FadeTranslationSwitchTween : UISwitchTween
    {
        // Fields
        private static System.Single DEFAULT_TWEEN_DURATION;        // 0x0
        private UnityEngine.CanvasGroup m_alphaHandler;        // 0x30
        private UnityEngine.RectTransform m_posHandler;        // 0x38
        private UnityEngine.Vector2 m_hidePos;        // 0x40
        private UnityEngine.Vector2 m_showPos;        // 0x48
        private System.Single m_duration;        // 0x50
        private System.Single m_hideDelay;        // 0x54
        private System.Single m_showDelay;        // 0x58

        // Methods
        private System.Void .ctor(UnityEngine.CanvasGroup alphaHandler, UnityEngine.RectTransform posHandler, UnityEngine.Vector2 hidePos, UnityEngine.Vector2 showPos, System.Single duration, System.Single hideDelay, System.Single showDelay) { }
        private Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfHide() { }
        private Beyond.UI.UISwitchTween.ITweenHandler GenerateTweenOfShow() { }
        private System.Void BeforeShowEffect() { }
        private System.Void AfterHideEffect() { }
        private System.Void ResetToState(System.Boolean isShow) { }
        private System.Single _GetTargetAlpha(System.Boolean isShow) { }
        private UnityEngine.Vector2 _GetTargetPos(System.Boolean isShow) { }
        private System.Void <>iFixBaseProxy_BeforeShowEffect() { }
        private System.Void <>iFixBaseProxy_AfterHideEffect() { }
        private System.Void <>iFixBaseProxy_ResetToState(System.Boolean P0) { }

    }

    // TypeToken: 0x2000129
    public class UIAtlasManager : Singleton`1
    {
        // Fields
        private Beyond.TickFunction m_lateTickFunction;        // 0x10
        public static System.Int32 ATLAS_PAGE_WIDTH;        // 0x0
        public static System.Int32 ATLAS_PAGE_HEIGHT;        // 0x0
        public static System.Int32 IMAGE_USING_ATLAS_MAX_SIZE;        // 0x0
        public static System.Int32 UI_IMAGE_BLOCK_ALIGNMENT;        // 0x0
        public static System.Int32 PANEL_LEVEL_COUNT;        // 0x0
        public static System.Int32 MAX_ATLAS_PER_PANEL_LEVEL;        // 0x0
        public static System.Int32 PROCESS_COUNT_PER_FRAME;        // 0x0
        public static UnityEngine.Experimental.Rendering.GraphicsFormat ATLAS_PAGE_FORMAT;        // 0x0
        private System.Boolean m_enableRuntimeAtlas;        // 0x18
        private System.Collections.Generic.Dictionary<System.Int32,Beyond.UI.UIImage> m_imageDict;        // 0x20
        private Beyond.UI.UIAtlasManager.UIAtlasPage[,] m_atlasPagePool;        // 0x28
        private System.Collections.Generic.Queue<Beyond.UI.UIImage> m_insertQueue;        // 0x30
        private System.Collections.Generic.Queue<Beyond.UI.UIAtlasManager.UIAtlasHandle> m_freeQueue;        // 0x38
        private UnityEngine.Rendering.CommandBuffer m_commandBuffer;        // 0x40
        private UnityEngine.Experimental.Rendering.GraphicsFormat m_atlasPageFormat;        // 0x48
        private static System.Boolean <enableRuntimeAtlasFromScript>k__BackingField;        // 0x0

        // Methods
        private System.Boolean get_enableRuntimeAtlas() { }
        private System.Boolean get_enableRuntimeAtlasFromScript() { }
        private System.Void set_enableRuntimeAtlasFromScript(System.Boolean value) { }
        private System.Boolean get_releaseImageSpriteAfterInsert() { }
        private System.Void .ctor() { }
        private System.Void OnInit() { }
        private System.Void OnUnInit() { }
        private System.Void Release() { }
        private System.Void _CreateTickFunction() { }
        private System.Void _ClearTickFunction() { }
        private System.Void AddUIImageToManager(Beyond.UI.UIImage image) { }
        private System.Void ReProcessInsertForUIImage(Beyond.UI.UIImage image) { }
        private System.Void RemoveUIImageFromManager(Beyond.UI.UIImage image) { }
        private System.Void AddUIImageToManagerOnInstantiate(Beyond.UI.UIImage image) { }
        private System.Int32 GetAtlasCount() { }
        private System.Void LateTick(System.Single deltaTime) { }
        private System.Void _AddUIImageToManager(Beyond.UI.UIImage image) { }
        private System.Void _ReProcessInsertForUIImage(Beyond.UI.UIImage image) { }
        private System.Void _RemoveUIImageFromManager(Beyond.UI.UIImage image) { }
        private System.Void _AddUIImageToManagerOnInstantiate(Beyond.UI.UIImage image) { }
        private System.Boolean _IsRuntimeAtlasCompatible(Beyond.UI.UIImage image, Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause& failureCause) { }
        private System.Void _ProcessInsertQueue() { }
        private System.Void _ProcessRemoveQueue() { }

    }

    // TypeToken: 0x200012F
    public class WebApplication
    {
        // Methods
        private System.Void Start(System.String url, System.Action onClose) { }

    }

}

namespace Beyond.UI.GPUI
{

    // TypeToken: 0x2000143
    public struct ChangeState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.GPUI.ChangeState Stable;        // 0x0
        public static Beyond.UI.GPUI.ChangeState New;        // 0x0
        public static Beyond.UI.GPUI.ChangeState ChangeSize;        // 0x0
        public static Beyond.UI.GPUI.ChangeState ChangeData;        // 0x0

    }

    // TypeToken: 0x2000144
    public struct RuntimeNodeInfo
    {
        // Fields
        public Beyond.UI.GPUI.NodeType nodeType;        // 0x10
        public Beyond.UI.GPUI.SimpleTextAlignment textAlignment;        // 0x14
        public System.Int32 nodeIndex;        // 0x18
        public System.Int32 childNodeCount;        // 0x1C
        public System.UInt32 color;        // 0x20
        public UnityEngine.Vector2 position;        // 0x24
        public System.String textOverride;        // 0x30
        public System.Boolean changed;        // 0x38
        public System.Boolean hide;        // 0x39

    }

    // TypeToken: 0x2000145
    public class RuntimeAnimationData
    {
        // Fields
        public System.String name;        // 0x10
        public System.Single duration;        // 0x18
        public System.Collections.Generic.List<Beyond.UI.GPUI.GPUInstanceData> template;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000146
    public class RuntimePrefabData
    {
        // Fields
        public System.Int32 templateNodeCount;        // 0x10
        public System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeNodeInfo> nodes;        // 0x18
        public System.Collections.Generic.Dictionary<System.String,System.Int32> nodesNameMap;        // 0x20
        public System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeAnimationData> animations;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000147
    public struct GPUPrefabData
    {
        // Fields
        public UnityEngine.Vector4 uv;        // 0x10
        public UnityEngine.Vector4 aniPosScaleMinMax;        // 0x20
        public UnityEngine.Vector4 aniPosAddMinMax;        // 0x30
        public UnityEngine.Vector2 aniURange;        // 0x40
        public System.Single aniPosScaleV;        // 0x48
        public System.Single aniPosAddV;        // 0x4C
        public System.Single aniColorV;        // 0x50
        public System.Single aniDurationInv;        // 0x54
        public System.Int32 materialType;        // 0x58
        public System.UInt32 materialParam1;        // 0x5C

        // Methods
        private System.Void .ctor(Beyond.UI.GPUI.NodeSerializeData data) { }
        private System.Void .ctor(UnityEngine.Vector4 uv, UnityEngine.Vector4 scale) { }
        private Beyond.UI.GPUI.GPUPrefabData CreateFontNode(UnityEngine.Vector4 uv, UnityEngine.Vector4 scale, UnityEngine.Vector2 texelSizeInv) { }

    }

    // TypeToken: 0x2000148
    public struct GPUPrefabDataLite
    {
        // Fields
        public System.Int16 uvX;        // 0x10
        public System.Int16 uvY;        // 0x12
        public System.Int16 uvZ;        // 0x14
        public System.Int16 uvW;        // 0x16
        public System.UInt16 aniPosScaleMinX;        // 0x18
        public System.UInt16 aniPosScaleMinY;        // 0x1A
        public System.UInt16 aniPosScaleMaxX;        // 0x1C
        public System.UInt16 aniPosScaleMaxY;        // 0x1E
        public System.UInt16 aniPosAddMinX;        // 0x20
        public System.UInt16 aniPosAddMinY;        // 0x22
        public System.UInt16 aniPosAddMaxX;        // 0x24
        public System.UInt16 aniPosAddMaxY;        // 0x26
        public System.Int16 aniURangeX;        // 0x28
        public System.Int16 aniURangeY;        // 0x2A
        public System.Int16 aniPosScaleV;        // 0x2C
        public System.Int16 aniPosAddV;        // 0x2E
        public System.Int16 aniColorV;        // 0x30
        public System.Int16 aniDuration;        // 0x32
        public System.UInt16 materialType;        // 0x34
        public System.UInt16 materialParam1;        // 0x36
        public System.UInt32 padding;        // 0x38
        public System.UInt32 padding2;        // 0x3C

        // Methods
        private System.Void .ctor(Beyond.UI.GPUI.NodeSerializeData data, UnityEngine.Vector2 texelSizeInv, UnityEngine.Vector2 aniTexelSizeInv) { }
        private System.Void .ctor(UnityEngine.Vector4 uv, UnityEngine.Vector4 scale, UnityEngine.Vector2 texelSizeInv) { }
        private Beyond.UI.GPUI.GPUPrefabDataLite CreateFontNode(UnityEngine.Vector4 uv, UnityEngine.Vector4 scale, UnityEngine.Vector2 texelSizeInv) { }

    }

    // TypeToken: 0x2000149
    public struct GPUInstanceData
    {
        // Fields
        public System.Single animeTime;        // 0x10
        public System.UInt32 color;        // 0x14
        public UnityEngine.Vector2 pos;        // 0x18
        public System.UInt16 prefabId;        // 0x20
        public System.UInt16 parentId;        // 0x22
        public System.UInt16 grandParentId;        // 0x24
        public System.Byte matType;        // 0x26
        public System.Byte drawType;        // 0x27
        public System.UInt32 padding0;        // 0x28
        public System.UInt32 padding1;        // 0x2C

    }

    // TypeToken: 0x200014A
    public struct NodeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.GPUI.NodeType Root;        // 0x0
        public static Beyond.UI.GPUI.NodeType Image;        // 0x0
        public static Beyond.UI.GPUI.NodeType Text;        // 0x0

    }

    // TypeToken: 0x200014B
    public struct SimpleTextAlignment
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.GPUI.SimpleTextAlignment Left;        // 0x0
        public static Beyond.UI.GPUI.SimpleTextAlignment Center;        // 0x0
        public static Beyond.UI.GPUI.SimpleTextAlignment Right;        // 0x0

    }

    // TypeToken: 0x200014C
    public class NodeSerializeData
    {
        // Fields
        public UnityEngine.Vector4 uv;        // 0x10
        public UnityEngine.Vector4 aniPosScaleMinMax;        // 0x20
        public UnityEngine.Vector4 aniPosAddMinMax;        // 0x30
        public UnityEngine.Vector2 aniURange;        // 0x40
        public System.Single aniPosScaleV;        // 0x48
        public System.Single aniPosAddV;        // 0x4C
        public System.Single aniColorV;        // 0x50
        public System.Single aniDurationInv;        // 0x54
        public System.Int32 materialType;        // 0x58
        public System.UInt32 materialParam1;        // 0x5C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014D
    public class NodeMetadata
    {
        // Fields
        public System.String nodeName;        // 0x10
        public Beyond.UI.GPUI.NodeType nodeType;        // 0x18
        public System.String nodeTextId;        // 0x20
        public System.String nodeText;        // 0x28
        public Beyond.UI.GPUI.SimpleTextAlignment textAlignment;        // 0x30
        public System.Single nodeTextSize;        // 0x34

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014E
    public class AnimationSerializeData
    {
        // Fields
        public System.String animationName;        // 0x10
        public System.Single animationTime;        // 0x18
        public System.Int32 totalFrames;        // 0x1C
        public UnityEngine.WrapMode wrapMode;        // 0x20
        public System.Int32 renderNodesOffset;        // 0x24

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014F
    public class PrefabSerializeData
    {
        // Fields
        public System.String prefabName;        // 0x10
        public System.Int32 nodeCount;        // 0x18
        public System.Boolean animationOnly;        // 0x1C
        public System.Collections.Generic.List<Beyond.UI.GPUI.NodeMetadata> nodeMetas;        // 0x20
        public System.Collections.Generic.List<Beyond.UI.GPUI.NodeSerializeData> renderNodes;        // 0x28
        public System.Collections.Generic.List<Beyond.UI.GPUI.AnimationSerializeData> animations;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000150
    public class PrefabGroupSerializeData, IMemoryPackSerialize
    {
        // Fields
        public Beyond.Resource.StringPathHash spriteTexturePath;        // 0x10
        public Beyond.Resource.StringPathHash vatTexturePath;        // 0x18
        public System.Collections.Generic.List<Beyond.UI.GPUI.PrefabSerializeData> prefabs;        // 0x20
        public System.Collections.Generic.List<System.String> textIds;        // 0x28
        public System.String importantChars;        // 0x30

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000151
    public struct GPUIHandle, IEquatable`1
    {
        // Fields
        public System.Int32 index;        // 0x10
        public System.Int32 version;        // 0x14

        // Methods
        private System.Boolean Equals(Beyond.UI.GPUI.GPUIHandle other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(Beyond.UI.GPUI.GPUIHandle left, Beyond.UI.GPUI.GPUIHandle right) { }
        private System.Boolean op_Inequality(Beyond.UI.GPUI.GPUIHandle left, Beyond.UI.GPUI.GPUIHandle right) { }
        private System.Boolean <>iFixBaseProxy_Equals(System.Object P0) { }
        private System.Int32 <>iFixBaseProxy_GetHashCode() { }

    }

    // TypeToken: 0x2000152
    public class GPUISystem : MaskableGraphic
    {
        // Fields
        public static readonly System.String CONFIG_JSON_PATH_FORMAT;        // 0x0
        public static readonly System.Int32 RENDER_GROUP_SIZE;        // 0x8
        public static readonly System.Int32 RENDER_GROUP_SIZE_GL;        // 0xC
        public System.Collections.Generic.List<UnityEngine.Material> materialTemplates;        // 0xE8
        public System.String configGroupName;        // 0xF0
        public System.Int32 sourceCNFontId;        // 0xF8
        private TMPro.TMP_FontAsset m_i18NFontAsset;        // 0x100
        public System.Boolean noSortingOrder;        // 0x108
        private System.Boolean m_liteMode;        // 0x109
        private System.Boolean m_inited;        // 0x10A
        private System.Boolean m_rendererDisabled;        // 0x10B
        private System.Collections.Generic.List<UnityEngine.Material> m_instancedMaterials;        // 0x110
        private UnityEngine.Texture m_vatTexture;        // 0x118
        private UnityEngine.Texture m_spriteTexture;        // 0x120
        private Beyond.Resource.FAssetProxyHandle m_vatTextureHandle;        // 0x128
        private Beyond.Resource.FAssetProxyHandle m_spriteTextureHandle;        // 0x13C
        private System.Single m_timeForShader;        // 0x150
        private System.Collections.Generic.Dictionary<System.String,Beyond.UI.GPUI.RuntimePrefabData> m_prefabMap;        // 0x158
        private UnityEngine.Transform m_targetCanvasTransform;        // 0x160
        private UnityEngine.Matrix4x4 m_canvasObjectToWorldMatrix;        // 0x168
        private System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeInstance> m_instances;        // 0x1A8
        private System.Collections.Generic.Queue<System.Int32> m_recyclePool;        // 0x1B0
        private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Single,Beyond.UI.GPUI.GPUIHandle>> m_destroyQueue;        // 0x1B8
        private Beyond.UI.GPUI.ITextSystem m_simpleTextSystem;        // 0x1C0
        private Beyond.UI.GPUI.InstanceBufferManager m_instanceBufferManager;        // 0x1C8
        private Beyond.UI.GPUI.SimpleBufferManager<Beyond.UI.GPUI.GPUPrefabData> m_prefabBufferManager;        // 0x1D0
        private Beyond.UI.GPUI.SimpleBufferManager<Beyond.UI.GPUI.GPUPrefabDataLite> m_litePrefabBufferManager;        // 0x1D8

        // Methods
        private TMPro.TMP_FontAsset get_fontAsset() { }
        private System.Void set_fontAsset(TMPro.TMP_FontAsset value) { }
        private System.Boolean CreateInstance(System.String prefabName, UnityEngine.Vector3 initialPosition, Beyond.UI.GPUI.GPUIHandle& handle, System.Int32 sortingOrder) { }
        private System.Boolean DestroyInstance(Beyond.UI.GPUI.GPUIHandle handle) { }
        private System.Boolean IsInstanceValid(Beyond.UI.GPUI.GPUIHandle handle) { }
        private System.Boolean SetRootPosition(Beyond.UI.GPUI.GPUIHandle handle, UnityEngine.Vector3 position) { }
        private System.Boolean SetRootScale(Beyond.UI.GPUI.GPUIHandle handle, UnityEngine.Vector2 scale) { }
        private System.Boolean StartAnimation(Beyond.UI.GPUI.GPUIHandle handle, System.Boolean destroyWhenStopped, System.String animationName, System.Boolean resetDestroy) { }
        private System.Boolean StartAnimation(Beyond.UI.GPUI.GPUIHandle handle, System.Boolean destroyWhenStopped, System.Int32 animationIndex, System.Boolean resetDestroy) { }
        private System.Boolean SetVisibility(Beyond.UI.GPUI.GPUIHandle handle, System.String nodeName, System.Boolean visible) { }
        private System.Boolean SetColor(Beyond.UI.GPUI.GPUIHandle handle, System.String nodeName, UnityEngine.Color color) { }
        private System.Boolean SetText(Beyond.UI.GPUI.GPUIHandle handle, System.String nodeName, System.String text) { }
        private System.Void OnDestroy() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnPopulateMesh(UnityEngine.UI.VertexHelper vh) { }
        private System.Void UpdateMaterial() { }
        private System.Void _PreWillRenderCanvases() { }
        private System.Void _Init(System.String jsonPath) { }
        private TMPro.TMP_FontAsset GetFontAsset() { }
        private System.Void _DoLateUpdate() { }
        private System.Void _DoOnDestroy() { }
        private System.Void _RefreshMaterials() { }
        private System.Void _InitMaterials() { }
        private System.Void _CleanMaterials() { }
        private System.Void _RenderNodes() { }
        private System.Void _DestroyAnimatedInstance() { }
        private System.Void _UpdateWorldMat() { }
        private System.Void _PreloadTextInGroupData(Beyond.UI.GPUI.PrefabGroupSerializeData data) { }
        private System.Void _LoadGroupData(Beyond.UI.GPUI.PrefabGroupSerializeData data) { }
        private Beyond.UI.GPUI.RuntimePrefabData _LoadPrefabData(Beyond.UI.GPUI.PrefabSerializeData prefab) { }
        private System.Int32 _LoadPrefabNodeBuffer(Beyond.UI.GPUI.PrefabSerializeData prefab, System.Int32 totalNodeCount) { }
        private System.Boolean _CreateInstance(System.String prefabName, Beyond.UI.GPUI.GPUIHandle& handle, System.Int32 sortingOrder) { }
        private System.Boolean _DestroyInstance(Beyond.UI.GPUI.GPUIHandle handle) { }
        private Beyond.UI.GPUI.GPUIHandle _GetOneHandle() { }
        private System.Boolean _IsHandleInvalid(Beyond.UI.GPUI.GPUIHandle handle) { }
        private System.Void _RecycleOneHandle(Beyond.UI.GPUI.GPUIHandle handle) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Void <>iFixBaseProxy_OnDestroy() { }
        private System.Void <>iFixBaseProxy_OnEnable() { }
        private System.Void <>iFixBaseProxy_OnDisable() { }
        private System.Void <>iFixBaseProxy_OnPopulateMesh(UnityEngine.UI.VertexHelper P0) { }
        private System.Void <>iFixBaseProxy_UpdateMaterial() { }

    }

    // TypeToken: 0x2000154
    public class GPUIUtils
    {
        // Fields
        public static readonly UnityEngine.Vector3 DEFAULT_NORMAL;        // 0x0
        public static readonly UnityEngine.Vector4 DEFAULT_TANGENT;        // 0xC

        // Methods
        private UnityEngine.Mesh CreateQuadMesh() { }
        private System.UInt32 ColorToRGBAUint32(UnityEngine.Color color) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000155
    public class InstanceBufferManager, IDisposable
    {
        // Fields
        private static readonly Unity.Profiling.ProfilerMarker MARKER_UPDATE_PERF;        // 0x0
        private Unity.Collections.NativeArray<UnityEngine.CanvasRenderer.InstanceRange> m_gpuGroups;        // 0x10
        private System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeInstance> m_runtimeInstanceView;        // 0x20
        private System.Collections.Generic.List<Beyond.UI.GPUI.InstanceBufferManager.BufferInternalNode> m_bufferInternalNodes;        // 0x28
        private System.Collections.Generic.List<Beyond.UI.GPUI.InstanceBufferManager.BufferInternalNode> m_pendingNodes;        // 0x30
        private System.Collections.Generic.List<Beyond.UI.GPUI.InstanceBufferManager.BufferInternalNode> m_addNodes;        // 0x38
        private System.Collections.Generic.HashSet<Beyond.UI.GPUI.GPUIHandle> m_removeNodes;        // 0x40
        private System.Boolean m_hasAnyChanges;        // 0x48
        private System.Boolean m_updateBufferOnly;        // 0x49
        private System.Int32 m_currentStartIndex;        // 0x4C
        private System.Int32 m_currentLength;        // 0x50
        private System.Int32 m_capacity;        // 0x54
        private System.Int32 m_maxCapacity;        // 0x58
        private System.Int32 m_nodeStride;        // 0x5C
        private System.Int32 m_gpuGroupCapacity;        // 0x60
        private System.Int32 m_groupCount;        // 0x64
        private System.Boolean m_noSortingOrder;        // 0x68

        // Methods
        private System.Int32 get_startIndex() { }
        private System.Int32 get_nodeCount() { }
        private System.Int32 get_capacity() { }
        private Unity.Collections.NativeArray<UnityEngine.CanvasRenderer.InstanceRange> get_gpuGroups() { }
        private System.Int32 get_gpuGroupCount() { }
        private System.Void .ctor(System.Int32 initCapacity, System.Int32 maxCapacity, System.Int32 nodeStride, System.Int32 gpuGroupCapacity, System.Boolean noSortingOrder) { }
        private System.Void BindInstanceList(System.Collections.Generic.List<Beyond.UI.GPUI.RuntimeInstance> runtimeInstanceView) { }
        private System.Void MarkNeedUpdate() { }
        private System.Void _FillInstanceQueue(Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData>& oldBuffer, System.Int32& newTotalLength, System.Int32& newTotalLengthWithEmptySlot, System.Int32& fullUpdateIndex) { }
        private System.Void DoUpdate(UnityEngine.CanvasRenderer canvasRenderer) { }
        private System.Void _NewGpuGroup(System.Int32 start, System.Int32 end) { }
        private System.Void Add(Beyond.UI.GPUI.GPUIHandle instance) { }
        private System.Void Remove(Beyond.UI.GPUI.GPUIHandle instance) { }
        private System.Void _AllocBuffer(System.Int32 capacity) { }
        private System.Void Dispose() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000157
    public class RuntimeInstance
    {
        // Fields
        public static System.Int32 ROOT_NODE_INDEX;        // 0x0
        public System.Int32 version;        // 0x10
        public Beyond.UI.GPUI.ChangeState state;        // 0x14
        public System.Int32 length;        // 0x18
        public System.Int32 sortingOrder;        // 0x1C
        private Beyond.UI.GPUI.ITextSystem m_textSystem;        // 0x20
        private Beyond.UI.GPUI.RuntimePrefabData m_prefab;        // 0x28
        private Beyond.UI.GPUI.RuntimeAnimationData m_animationData;        // 0x30
        private System.Int32 m_prefabNodeOffset;        // 0x38
        private Beyond.UI.GPUI.RuntimeNodeInfo[] m_nodeInfo;        // 0x40
        private System.Int32 m_nodeInfoCount;        // 0x48
        private System.Single m_animationDuration;        // 0x4C
        private System.Single m_animationTime;        // 0x50
        private UnityEngine.Vector2 m_rootScale;        // 0x54

        // Methods
        private Beyond.UI.GPUI.RuntimePrefabData get_Prefab() { }
        private System.Single get_AnimationDuration() { }
        private System.Void Create(Beyond.UI.GPUI.RuntimePrefabData prefab, Beyond.UI.GPUI.ITextSystem textSystem) { }
        private System.Void Recycle() { }
        private System.Void DoUpdate(Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData>& buffer, System.Int32 startIndexInBuffer, System.Boolean full) { }
        private System.Void SetRootScale(UnityEngine.Vector2 rootScale) { }
        private System.Void SetPosition(System.Int32 index, UnityEngine.Vector3 position) { }
        private System.Void StartAnimation(System.Single animationTime, System.Int32 animationIndex) { }
        private System.Void SetVisibility(System.Int32 index, System.Boolean visible) { }
        private System.Void SetColor(System.Int32 index, UnityEngine.Color newColor) { }
        private System.Void SetText(System.Int32 index, System.String text) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000158
    public class SimpleBufferManager`1, IDisposable
    {
        // Fields
        private System.Int32 m_objectSize;        // 0x0
        private System.Int32 m_count;        // 0x0
        private System.Int32 m_capacity;        // 0x0
        private System.Boolean m_isFrozen;        // 0x0
        private System.Int32 m_writingRef;        // 0x0
        private UnityEngine.CanvasRenderer m_canvasRenderer;        // 0x0
        private Unity.Collections.NativeArray<T> m_cpuArray;        // 0x0

        // Methods
        private Unity.Collections.NativeArray<T> get_cpuArray() { }
        private System.Void .ctor(System.Int32 initCapacity, UnityEngine.CanvasRenderer canvasRenderer) { }
        private System.Void Dispose() { }
        private System.Void Reset() { }
        private System.Void OpenWrite() { }
        private System.Void Freeze() { }
        private System.Boolean Allocate(System.Int32 size, System.Int32& index) { }
        private System.Void _Resize(System.Int32 desiredCapacity) { }

    }

    // TypeToken: 0x2000159
    public class CodePoint
    {
        // Fields
        public static System.UInt32 HIGH_SURROGATE_START;        // 0x0
        public static System.UInt32 HIGH_SURROGATE_END;        // 0x0
        public static System.UInt32 LOW_SURROGATE_START;        // 0x0
        public static System.UInt32 LOW_SURROGATE_END;        // 0x0
        public static System.UInt32 UNICODE_PLANE01_START;        // 0x0

        // Methods
        private System.UInt32 ConvertToUTF32(System.UInt32 highSurrogate, System.UInt32 lowSurrogate) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200015A
    public interface ITextSystem
    {
        // Methods
        private System.Void RegisterCharacterToPrefabBuffer(System.String text) { }
        private System.Void UploadBufferIfNeeded() { }
        private System.Int32 GetNodeCount(System.String text) { }
        private System.Void CreateTextNodes(System.String text, Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData> dest, System.Int32 startIndex, System.Int32 capacity, System.Int32 parentId, System.Int32 grandParentId, Beyond.UI.GPUI.SimpleTextAlignment alignment) { }
        private System.Void CreateTextNodes(System.String text, System.Collections.Generic.List<Beyond.UI.GPUI.GPUInstanceData> dest, System.Int32 startIndex, System.Int32 capacity, System.Int32 parentId, System.Int32 grandParentId, Beyond.UI.GPUI.SimpleTextAlignment alignment) { }

    }

    // TypeToken: 0x200015B
    public class SimpleTextSystem`1, ITextSystem
    {
        // Fields
        public static System.Single DEFAULT_WHITESPACE_SPACING;        // 0x0
        private TMPro.TMP_FontAsset m_fontAsset;        // 0x0
        private UnityEngine.Material m_tmpMaterial;        // 0x0
        private Beyond.UI.GPUI.SimpleBufferManager<T> m_prefabBufferManager;        // 0x0
        private System.Single m_padding;        // 0x0
        private UnityEngine.Vector2 m_texelSizeInv;        // 0x0
        private readonly System.Collections.Generic.List<T> m_dynamicBufferCache;        // 0x0
        private readonly System.Collections.Generic.Dictionary<System.UInt32,System.Int32> m_charCodeToIndexMap;        // 0x0
        private readonly System.Collections.Generic.List<Beyond.UI.GPUI.SimpleTextSystem.CharOffsetData<T>> m_tempOffsetCache;        // 0x0
        private readonly System.Collections.Generic.Dictionary<System.UInt32,Beyond.UI.GPUI.SimpleTextSystem.CharOffsetData<T>> m_charaOffsetCache;        // 0x0
        private readonly System.Int32 m_fontBufferCapacity;        // 0x0
        private readonly System.Boolean m_liteMode;        // 0x0
        private System.Boolean m_isThaiMode;        // 0x0
        private System.Int32 m_prefabDestIndex;        // 0x0
        private System.Int32 m_fontBufferCount;        // 0x0
        private readonly System.Func<UnityEngine.Vector4,UnityEngine.Vector4,UnityEngine.Vector2,T> m_creatorFunc;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 fontBufferCapacity, System.Func<UnityEngine.Vector4,UnityEngine.Vector4,UnityEngine.Vector2,T> creatorFunc) { }
        private System.Void Init(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material tmpMaterial, Beyond.UI.GPUI.SimpleBufferManager<T> simpleBufferManager, System.Boolean isThaiMode) { }
        private System.Void RegisterCharacterToPrefabBuffer(System.String text) { }
        private System.Int32 GetNodeCount(System.String text) { }
        private System.Void UploadBufferIfNeeded() { }
        private System.Void CreateTextNodes(System.String text, Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData> dest, System.Int32 startIndex, System.Int32 capacity, System.Int32 parentId, System.Int32 grandParentId, Beyond.UI.GPUI.SimpleTextAlignment alignment) { }
        private System.Void CreateTextNodes(System.String text, System.Collections.Generic.List<Beyond.UI.GPUI.GPUInstanceData> dest, System.Int32 startIndex, System.Int32 capacity, System.Int32 parentId, System.Int32 grandParentId, Beyond.UI.GPUI.SimpleTextAlignment alignment) { }
        private System.Void _DoTextAlignAndDynamicBuffer(System.String text, Beyond.UI.GPUI.SimpleTextAlignment alignment, System.Single& currentX) { }
        private System.Void _LoadAllCharacterToPrefabBuffer(System.String text) { }
        private System.Int32 _PutOneCharacterToPrefabBufferDynamic(System.UInt32 c) { }
        private System.Void _UploadBufferIfNeeded() { }
        private System.Void _InitPrefabDataByTMPCharacter(TMPro.TMP_Character character, T& prefabData) { }
        private System.Boolean IsUpVowel(System.Char c) { }
        private System.Boolean IsLowVowel(System.Char c) { }
        private System.Boolean IsToneMark(System.Char c) { }
        private System.Boolean IsAscenderThai(System.Char c) { }
        private System.Boolean IsDescenderThai(System.Char c) { }

    }

}

namespace Beyond.UI.UIState
{

    // TypeToken: 0x2000131
    public class OnValueChangedAttribute : PropertyAttribute
    {
        // Fields
        private readonly System.String <actionName>k__BackingField;        // 0x10

        // Methods
        private System.String get_actionName() { }
        private System.Void .ctor(System.String name) { }

    }

    // TypeToken: 0x2000132
    public class StateAnimationInfo
    {
        // Fields
        private System.Boolean <IsFinished>k__BackingField;        // 0x10
        private readonly UnityEngine.AnimationClip <Clip>k__BackingField;        // 0x18
        private readonly UnityEngine.GameObject <Target>k__BackingField;        // 0x20
        private System.Single <StartTime>k__BackingField;        // 0x28
        private readonly System.Single m_duration;        // 0x2C

        // Methods
        private System.Boolean get_IsFinished() { }
        private System.Void set_IsFinished(System.Boolean value) { }
        private UnityEngine.AnimationClip get_Clip() { }
        private UnityEngine.GameObject get_Target() { }
        private System.Single get_StartTime() { }
        private System.Void set_StartTime(System.Single value) { }
        private System.Void .ctor(UnityEngine.AnimationClip clip, UnityEngine.GameObject target) { }
        private System.Void OnUpdate() { }

    }

    // TypeToken: 0x2000133
    public struct AnimationImpactType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIState.AnimationImpactType StartAnimation;        // 0x0
        public static Beyond.UI.UIState.AnimationImpactType StopAnimation;        // 0x0

    }

    // TypeToken: 0x2000134
    public class StateDescription
    {
        // Fields
        public Beyond.UI.UIState.AnimationImpactType animationImpactType;        // 0x10
        public UnityEngine.AnimationClip animationClip;        // 0x18
        public UnityEngine.GameObject animationTarget;        // 0x20
        public UnityEngine.Animator animator;        // 0x28
        public Beyond.UI.UIState.AnimatorImpactType animImpact;        // 0x30
        public System.String animParamSetBoolTrue;        // 0x38
        public System.String animParamSetBoolFalse;        // 0x40
        public System.String animParamSetTrigger;        // 0x48
        public System.String animParamResetTrigger;        // 0x50
        public System.String animParamSetInteger;        // 0x58
        public System.Int32 animParamSetIntegerValue;        // 0x60
        public System.String animParamSetFloat;        // 0x68
        public System.Int32 animParamSetFloatValue;        // 0x70
        public Beyond.UI.UIButton button;        // 0x78
        public System.Boolean buttonInteractable;        // 0x80
        public UnityEngine.CanvasGroup canvasGroup;        // 0x88
        public Beyond.UI.UIState.CanvasGroupImpactType canvasGroupImpactType;        // 0x90
        public System.Single canvasGroupAlpha;        // 0x94
        public System.Boolean canvasGroupInteractable;        // 0x98
        public UnityEngine.Color canvasGroupColor;        // 0x9C
        public UnityEngine.Behaviour component;        // 0xB0
        public System.Boolean componentIsEnabled;        // 0xB8
        public Beyond.UI.UIState.StateDescriptionTargetType targetType;        // 0xBC
        public UnityEngine.GameObject gameObject;        // 0xC0
        public System.Boolean gameObjectIsActive;        // 0xC8
        public UnityEngine.UI.Graphic graphic;        // 0xD0
        public UnityEngine.Material graphicMaterial;        // 0xD8
        public UnityEngine.UI.GridLayoutGroup gridLayoutGroup;        // 0xE0
        public Beyond.UI.UIState.GridLayoutGroupImpactType gridLayoutGroupImpactType;        // 0xE8
        public UnityEngine.RectOffset gridLayoutGroupPadding;        // 0xF0
        public UnityEngine.Vector2 gridLayoutGroupSpacing;        // 0xF8
        public UnityEngine.Vector2 gridLayoutGroupCellSize;        // 0x100
        public System.Int32 gridLayoutConstraintCount;        // 0x108
        public Beyond.UI.UIImage image;        // 0x110
        public Beyond.UI.UIState.ImageImpactType imageImpact;        // 0x118
        public System.Boolean imageEnabled;        // 0x11C
        public UnityEngine.Sprite imageSetSprite;        // 0x120
        public UnityEngine.Color imageSetColor;        // 0x128
        public System.String imageSetMaterialFloatParam;        // 0x138
        public System.Single imageSetMaterialFloatValue;        // 0x140
        private UnityEngine.Material <ImageMaterialClone>k__BackingField;        // 0x148
        public UnityEngine.UI.LayoutElement layoutElement;        // 0x150
        public Beyond.UI.UIState.LayoutElementImpactType layoutElementImpactType;        // 0x158
        public System.Single layoutElementPreferredWidth;        // 0x15C
        public System.Single layoutElementPreferredHeight;        // 0x160
        public System.Single layoutElementMinWidth;        // 0x164
        public System.Single layoutElementMinHeight;        // 0x168
        public System.Single layoutElementFlexibleWidth;        // 0x16C
        public System.Single layoutElementFlexibleHeight;        // 0x170
        public UnityEngine.UI.HorizontalOrVerticalLayoutGroup layoutGroup;        // 0x178
        public Beyond.UI.UIState.LayoutGroupImpactType layoutGroupImpactType;        // 0x180
        public UnityEngine.RectOffset layoutGroupPadding;        // 0x188
        public System.Single layoutGroupSpacing;        // 0x190
        public UnityEngine.TextAnchor layoutGroupChildAlignment;        // 0x194
        public System.Boolean layoutGroupReverseArrangement;        // 0x198
        public UnityEngine.RectTransform rectTransform;        // 0x1A0
        public Beyond.UI.UIState.RectTransformImpactType rectTransformImpactType;        // 0x1A8
        public UnityEngine.Vector2 rectTransformPosition;        // 0x1AC
        public UnityEngine.Vector2 rectTransformSize;        // 0x1B4
        public UnityEngine.Vector3 rectTransformRotation;        // 0x1BC
        public UnityEngine.Vector3 rectTransformScale;        // 0x1C8
        public System.Single rectTransformWidth;        // 0x1D4
        public System.Single rectTransformHeight;        // 0x1D8
        public System.Single rectTransformTop;        // 0x1DC
        public System.Single rectTransformBottom;        // 0x1E0
        public System.Single rectTransformLeft;        // 0x1E4
        public System.Single rectTransformRight;        // 0x1E8
        public UnityEngine.Vector2 rectTransformAnchorMin;        // 0x1EC
        public UnityEngine.Vector2 rectTransformAnchorMax;        // 0x1F4
        public UnityEngine.Vector2 rectTransformPivot;        // 0x1FC
        public Beyond.UI.UIScrollList scrollList;        // 0x208
        public Beyond.UI.UIState.ScrollListImpactType scrollListImpactType;        // 0x210
        public Beyond.UI.UIScrollList.Padding scrollListPadding;        // 0x214
        public Beyond.UI.UIState.UIStateController uiStateController;        // 0x228
        public System.String stateName;        // 0x230
        public Beyond.UI.UIText text;        // 0x238
        public Beyond.UI.UIState.TextImpactType textImpact;        // 0x240
        public UnityEngine.Color textColor;        // 0x244
        public System.String textId;        // 0x258
        public System.Single textFontSize;        // 0x260
        public System.Single textMaxFontSize;        // 0x264
        public TMPro.HorizontalAlignmentOptions textHorizontalAlignment;        // 0x268

        // Methods
        private System.Single ApplyAnimation(Beyond.UI.UIState.StateReference state) { }
        private System.Void ApplyAnimator() { }
        private System.Void ApplyButton() { }
        private System.Void ApplyCanvasGroup() { }
        private System.Void ApplyComponent() { }
        private System.Boolean get_IsEmpty() { }
        private System.String get_ReadableDescription() { }
        private System.String ToString() { }
        private System.Void ApplyGameObject() { }
        private System.Void ApplyGraphic() { }
        private System.Void ApplyGridLayoutGroup() { }
        private System.Void _OnGridLayoutGroupChanged() { }
        private UnityEngine.Material get_ImageMaterialClone() { }
        private System.Void set_ImageMaterialClone(UnityEngine.Material value) { }
        private System.Void ApplyImage() { }
        private System.Void _OnImageChanged() { }
        private System.Void ApplyLayoutElement() { }
        private System.Void _OnLayoutElementChanged() { }
        private System.Void ApplyLayoutGroup() { }
        private System.Void _OnLayoutGroupChanged() { }
        private System.Void ApplyRectTransform() { }
        private System.Void _OnRectTransformChanged() { }
        private System.Void ApplyScrollList() { }
        private System.Void _OnScrollListChanged() { }
        private System.Single ApplyInnerState() { }
        private System.Void ApplyText() { }
        private System.Void _OnTextChanged() { }
        private System.Void .ctor() { }
        private System.String <>iFixBaseProxy_ToString() { }

    }

    // TypeToken: 0x2000135
    public struct AnimatorImpactType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIState.AnimatorImpactType SetBoolTrue;        // 0x0
        public static Beyond.UI.UIState.AnimatorImpactType SetBoolFalse;        // 0x0
        public static Beyond.UI.UIState.AnimatorImpactType SetTrigger;        // 0x0
        public static Beyond.UI.UIState.AnimatorImpactType ResetTrigger;        // 0x0
        public static Beyond.UI.UIState.AnimatorImpactType SetInteger;        // 0x0
        public static Beyond.UI.UIState.AnimatorImpactType SetFloat;        // 0x0

    }

    // TypeToken: 0x2000136
    public struct CanvasGroupImpactType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIState.CanvasGroupImpactType SetAlpha;        // 0x0
        public static Beyond.UI.UIState.CanvasGroupImpactType SetInteractable;        // 0x0
        public static Beyond.UI.UIState.CanvasGroupImpactType SetColor;        // 0x0

    }

    // TypeToken: 0x2000137
    public struct StateDescriptionTargetType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIState.StateDescriptionTargetType GameObject;        // 0x0
        public static Beyond.UI.UIState.StateDescriptionTargetType Animator;        // 0x0
        public static Beyond.UI.UIState.StateDescriptionTargetType Image;        // 0x0
        public static Beyond.UI.UIState.StateDescriptionTargetType Text;        // 0x0
        public static Beyond.UI.UIState.StateDescriptionTargetType RectTransform;        // 0x0
        public static Beyond.UI.UIState.StateDescriptionTargetType Button;        // 0x0
        public static Beyond.UI.UIState.StateDescriptionTargetType CanvasGroup;        // 0x0
        public static Beyond.UI.UIState.StateDescriptionTargetType Animation;        // 0x0
        public static Beyond.UI.UIState.StateDescriptionTargetType State;        // 0x0
        public static Beyond.UI.UIState.StateDescriptionTargetType LayoutElement;        // 0x0
        public static Beyond.UI.UIState.StateDescriptionTargetType Component;        // 0x0
        public static Beyond.UI.UIState.StateDescriptionTargetType Graphic;        // 0x0
        public static Beyond.UI.UIState.StateDescriptionTargetType LayoutGroup;        // 0x0
        public static Beyond.UI.UIState.StateDescriptionTargetType ScrollList;        // 0x0
        public static Beyond.UI.UIState.StateDescriptionTargetType GridLayoutGroup;        // 0x0

    }

    // TypeToken: 0x2000138
    public struct GridLayoutGroupImpactType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIState.GridLayoutGroupImpactType Padding;        // 0x0
        public static Beyond.UI.UIState.GridLayoutGroupImpactType Spacing;        // 0x0
        public static Beyond.UI.UIState.GridLayoutGroupImpactType CellSize;        // 0x0
        public static Beyond.UI.UIState.GridLayoutGroupImpactType ConstraintCount;        // 0x0

    }

    // TypeToken: 0x2000139
    public struct ImageImpactType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIState.ImageImpactType SetEnabled;        // 0x0
        public static Beyond.UI.UIState.ImageImpactType SetSprite;        // 0x0
        public static Beyond.UI.UIState.ImageImpactType SetColor;        // 0x0
        public static Beyond.UI.UIState.ImageImpactType SetMaterialFloatValue;        // 0x0

    }

    // TypeToken: 0x200013A
    public struct LayoutElementImpactType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIState.LayoutElementImpactType LayoutElementPreferredWidth;        // 0x0
        public static Beyond.UI.UIState.LayoutElementImpactType LayoutElementPreferredHeight;        // 0x0
        public static Beyond.UI.UIState.LayoutElementImpactType LayoutElementMinWidth;        // 0x0
        public static Beyond.UI.UIState.LayoutElementImpactType LayoutElementMinHeight;        // 0x0
        public static Beyond.UI.UIState.LayoutElementImpactType LayoutElementFlexibleWidth;        // 0x0
        public static Beyond.UI.UIState.LayoutElementImpactType LayoutElementFlexibleHeight;        // 0x0

    }

    // TypeToken: 0x200013B
    public struct LayoutGroupImpactType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIState.LayoutGroupImpactType Padding;        // 0x0
        public static Beyond.UI.UIState.LayoutGroupImpactType Spacing;        // 0x0
        public static Beyond.UI.UIState.LayoutGroupImpactType ChildAlignment;        // 0x0
        public static Beyond.UI.UIState.LayoutGroupImpactType ReverseArrangement;        // 0x0

    }

    // TypeToken: 0x200013C
    public struct RectTransformImpactType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIState.RectTransformImpactType Undefined;        // 0x0
        public static Beyond.UI.UIState.RectTransformImpactType SetPosition;        // 0x0
        public static Beyond.UI.UIState.RectTransformImpactType SetSize;        // 0x0
        public static Beyond.UI.UIState.RectTransformImpactType SetRotation;        // 0x0
        public static Beyond.UI.UIState.RectTransformImpactType SetScale;        // 0x0
        public static Beyond.UI.UIState.RectTransformImpactType SetWidth;        // 0x0
        public static Beyond.UI.UIState.RectTransformImpactType SetHeight;        // 0x0
        public static Beyond.UI.UIState.RectTransformImpactType SetTop;        // 0x0
        public static Beyond.UI.UIState.RectTransformImpactType SetBottom;        // 0x0
        public static Beyond.UI.UIState.RectTransformImpactType SetLeft;        // 0x0
        public static Beyond.UI.UIState.RectTransformImpactType SetRight;        // 0x0
        public static Beyond.UI.UIState.RectTransformImpactType SetAnchors;        // 0x0
        public static Beyond.UI.UIState.RectTransformImpactType SetPivot;        // 0x0
        public static Beyond.UI.UIState.RectTransformImpactType ForceRebuildLayout;        // 0x0

    }

    // TypeToken: 0x200013D
    public struct ScrollListImpactType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIState.ScrollListImpactType Padding;        // 0x0

    }

    // TypeToken: 0x200013E
    public struct TextImpactType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static Beyond.UI.UIState.TextImpactType SetColor;        // 0x0
        public static Beyond.UI.UIState.TextImpactType SetTextById;        // 0x0
        public static Beyond.UI.UIState.TextImpactType SetFontSize;        // 0x0
        public static Beyond.UI.UIState.TextImpactType SetHorizontalAlignment;        // 0x0
        public static Beyond.UI.UIState.TextImpactType SetMaxFontSize;        // 0x0

    }

    // TypeToken: 0x200013F
    public class StateReference
    {
        // Fields
        public System.String stateName;        // 0x10
        public System.Collections.Generic.List<Beyond.UI.UIState.StateDescription> descriptions;        // 0x18
        private System.Collections.Generic.List<Beyond.UI.UIState.StateAnimationInfo> m_scheduledForPlaying;        // 0x20
        private System.Collections.Generic.List<Beyond.UI.UIState.StateAnimationInfo> m_scheduledForStopping;        // 0x28
        private Beyond.UI.UIState.UIStateController m_controller;        // 0x30
        private System.Boolean m_isDirty;        // 0x38

        // Methods
        private System.Void SetController(Beyond.UI.UIState.UIStateController controller) { }
        private System.Void ScheduleForPlaying(Beyond.UI.UIState.StateAnimationInfo stateAnimationInfo) { }
        private System.Void ScheduleForStopping(Beyond.UI.UIState.StateAnimationInfo stateAnimationInfo) { }
        private System.Void HandleScheduledStates() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000140
    public class UIStateController : TickableUIMono
    {
        // Fields
        public System.Collections.Generic.List<Beyond.UI.UIState.StateReference> states;        // 0x68
        private System.String <currentStateName>k__BackingField;        // 0x70
        private readonly System.Collections.Generic.List<Beyond.UI.UIState.StateAnimationInfo> m_animations;        // 0x78

        // Methods
        private Beyond.TickType get_tickOption() { }
        private System.String get_currentStateName() { }
        private System.Void set_currentStateName(System.String value) { }
        private System.Void OnStateReferenceDirty() { }
        private System.Single SetState(System.String stateName, System.Boolean forceUpdate) { }
        private System.Single _ApplyState(Beyond.UI.UIState.StateReference state) { }
        private System.Void Tick(System.Single deltaTime) { }
        private System.Void _HandleStateAnimations(Beyond.UI.UIState.StateReference stateReference) { }
        private System.Void Run(Beyond.UI.UIState.StateAnimationInfo newInfo) { }
        private System.Void Stop(Beyond.UI.UIState.StateAnimationInfo newInfo) { }
        private System.Void .ctor() { }
        private System.Void <>iFixBaseProxy_Tick(System.Single P0) { }

    }

    // TypeToken: 0x2000142
    public class UIStateControllerUtils
    {
        // Fields
        private static System.Single s_updateFinishTime;        // 0x0

        // Methods
        private System.Void ForceRebuildLayout(UnityEngine.GameObject gameObject) { }
        private System.Void SetLeft(UnityEngine.RectTransform rt, System.Single left) { }
        private System.Void SetRight(UnityEngine.RectTransform rt, System.Single right) { }
        private System.Void SetTop(UnityEngine.RectTransform rt, System.Single top) { }
        private System.Void SetBottom(UnityEngine.RectTransform rt, System.Single bottom) { }
        private System.String GetName(UnityEngine.Object obj) { }
        private System.Void StartEditorUpdateLoop(System.Single duration) { }

    }

}

namespace Cysharp.Text
{

    // TypeToken: 0x2000004
    public class TextMeshProExtensions
    {
        // Methods
        private System.Void SetText(TMPro.TMP_Text text, T arg0) { }
        private System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0) { }
        private System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1) { }
        private System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2) { }
        private System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
        private System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        private System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
        private System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
        private System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
        private System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
        private System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
        private System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
        private System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
        private System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
        private System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
        private System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
        private System.Void SetTextFormat(TMPro.TMP_Text text, System.String format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) { }
        private System.Void SetText(TMPro.TMP_Text text, Cysharp.Text.Utf16ValueStringBuilder stringBuilder) { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000003
    public class HGConstantBufferLayoutAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace IFix
{

    // TypeToken: 0x200015F
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj) { }
        private System.Void __Gen_Wrap_0() { }
        private System.Void __Gen_Wrap_1(System.Object P0) { }
        private System.Single __Gen_Wrap_2(System.Object P0, System.Boolean P1) { }
        private System.Single __Gen_Wrap_3(System.Object P0) { }
        private Beyond.UI.LuaPanel __Gen_Wrap_4(System.Object P0) { }
        private System.Void __Gen_Wrap_5(System.Object P0, System.Object P1, System.Boolean P2) { }
        private System.Void __Gen_Wrap_6(System.Object P0, System.Single P1) { }
        private System.String __Gen_Wrap_7(System.Object P0, System.Int32 P1, System.Boolean& P2) { }
        private System.Boolean __Gen_Wrap_8(System.Object P0, System.Object P1) { }
        private Beyond.UI.UIText.HyperlinkUITextGroup __Gen_Wrap_9(System.Object P0, System.Object P1, System.Boolean P2) { }
        private System.Void __Gen_Wrap_10(System.Object P0, System.Object P1) { }
        private System.String __Gen_Wrap_11(Beyond.GEnums.PhoneticType P0, System.Object P1) { }
        private System.Void __Gen_Wrap_12(System.Object P0, Beyond.GEnums.PhoneticType P1, System.Object P2) { }
        private System.Void __Gen_Wrap_13(Beyond.GEnums.EnvLang P0) { }
        private System.Boolean __Gen_Wrap_14(System.Object P0, System.Object P1, System.String& P2) { }
        private System.Boolean __Gen_Wrap_15(System.Object P0, UnityEngine.Vector3 P1, System.String& P2) { }
        private System.Collections.IEnumerator __Gen_Wrap_16(System.Object P0) { }
        private System.String __Gen_Wrap_17(System.Object P0, System.Boolean P1) { }
        private UnityEngine.Sprite __Gen_Wrap_18(System.Object P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_19(System.ReadOnlySpan<System.Char> P0) { }
        private Beyond.UI.UIText.RichTextInfo __Gen_Wrap_20(Beyond.UI.UIText.RichTextAnalyzer.RichTextParam P0, System.Object P1, Cysharp.Text.Utf16ValueStringBuilder& P2) { }
        private Beyond.UI.UIText.RichTextInfo __Gen_Wrap_21(System.Object P0, Beyond.UI.UIText.RichTextAnalyzer.RichTextParam P1, System.Object P2, Cysharp.Text.Utf16ValueStringBuilder& P3) { }
        private Beyond.UI.UIText.RichTextAnalyzer.ProcessRichTextEntryFunc __Gen_Wrap_22(System.Object P0) { }
        private System.Boolean __Gen_Wrap_23(System.ReadOnlySpan<System.Char> P0, Beyond.UI.UIText.RichTextAnalyzer.RichTextParam& P1) { }
        private System.Boolean __Gen_Wrap_24(System.ReadOnlySpan<System.Char> P0, Cysharp.Text.Utf16ValueStringBuilder& P1, System.Object P2, Beyond.UI.UIText.RichTextInfo& P3) { }
        private System.String __Gen_Wrap_25(System.Object P0, System.Object P1, System.Collections.Generic.List<Beyond.UI.UIText.RichTextInfo>& P2) { }
        private UnityEngine.GameObject __Gen_Wrap_26(System.Object P0) { }
        private Beyond.UI.UIText.ImageGOInfo __Gen_Wrap_27(System.Object P0, System.Int32 P1) { }
        private UnityEngine.Material __Gen_Wrap_28(System.Object P0) { }
        private UnityEngine.Material __Gen_Wrap_29(System.Object P0, System.Object P1) { }
        private Beyond.I18n.I18nFontSearchData __Gen_Wrap_30() { }
        private System.Boolean __Gen_Wrap_31(System.Object P0) { }
        private TMPro.TMP_FontAsset __Gen_Wrap_32(System.Int32 P0) { }
        private TMPro.TMP_FontAsset __Gen_Wrap_33(System.Object P0) { }
        private System.Void __Gen_Wrap_34(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3) { }
        private System.Void __Gen_Wrap_35(System.Object P0, System.Object P1, System.Int32 P2) { }
        private System.Boolean __Gen_Wrap_36(System.Object P0, System.Int32 P1, System.String& P2) { }
        private System.Boolean __Gen_Wrap_37(System.Object P0, System.Int32 P1, UnityEngine.Vector3& P2, System.Single& P3) { }
        private System.Void __Gen_Wrap_38(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Int32 __Gen_Wrap_39(Beyond.UI.UIText.HyperlinkUITextWrap P0, Beyond.UI.UIText.HyperlinkUITextWrap P1) { }
        private System.Collections.Generic.List<Beyond.UI.UIText> __Gen_Wrap_40(System.Object P0, System.Object P1) { }
        private System.Collections.Generic.List<Beyond.UI.UIText> __Gen_Wrap_41(System.Object P0) { }
        private System.Int32 __Gen_Wrap_42(System.Object P0) { }
        private TMPro.TMP_SubMeshUI __Gen_Wrap_43(System.Object P0, System.Object P1, TMPro.MaterialReference P2) { }
        private System.String __Gen_Wrap_44(System.Int32 P0) { }
        private System.Boolean __Gen_Wrap_45() { }
        private System.Single __Gen_Wrap_46() { }
        private UnityEngine.GameObject __Gen_Wrap_47(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Void __Gen_Wrap_48(Beyond.Resource.FAssetProxyUntrackedHandle P0) { }
        private System.Int32 __Gen_Wrap_49(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        private System.Void __Gen_Wrap_50(System.Object P0, System.Int32 P1) { }
        private System.Boolean __Gen_Wrap_51(UnityEngine.Vector3 P0, System.Object P1, System.Object P2) { }
        private System.Boolean __Gen_Wrap_52(UnityEngine.Vector2 P0, System.Object P1, System.Object P2) { }
        private UnityEngine.Bounds __Gen_Wrap_53(System.Object P0, System.Object P1) { }
        private System.Boolean __Gen_Wrap_54(System.Int32 P0, UnityEngine.InputSystem.EnhancedTouch.Touch& P1) { }
        private System.Void __Gen_Wrap_55(System.Object P0, UnityEngine.Color P1) { }
        private UnityEngine.Rect __Gen_Wrap_56(System.Object P0, System.Object P1) { }
        private UnityEngine.Vector3 __Gen_Wrap_57(System.Object P0, System.Object P1) { }
        private UnityEngine.Color __Gen_Wrap_58(System.Object P0) { }
        private System.Single __Gen_Wrap_59(System.Single P0) { }
        private System.Void __Gen_Wrap_60(System.Object P0, System.Object P1, Cinemachine.CinemachineCore.Stage P2, Cinemachine.CameraState& P3, System.Single P4) { }
        private System.Int32 __Gen_Wrap_61(System.Object P0, System.Int32 P1) { }
        private UnityEngine.Vector2 __Gen_Wrap_62(System.Object P0, System.Int32 P1) { }
        private UnityEngine.Vector2 __Gen_Wrap_63() { }
        private System.Void __Gen_Wrap_64(UnityEngine.Vector2 P0) { }
        private System.Void __Gen_Wrap_65(System.Object P0, System.Int32 P1, System.Boolean P2) { }
        private UnityEngine.Vector2Int __Gen_Wrap_66(System.Object P0, System.Single P1, System.Boolean P2) { }
        private UnityEngine.Vector2Int __Gen_Wrap_67(System.Object P0) { }
        private Beyond.UI.UIScrollList.Cell __Gen_Wrap_68(System.Object P0) { }
        private System.Void __Gen_Wrap_69(System.Object P0, System.Boolean P1) { }
        private UnityEngine.AnimationState __Gen_Wrap_70(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_71(System.Object P0, System.Object P1, System.Single P2) { }
        private System.Void __Gen_Wrap_72(System.Object P0, System.Object P1, System.Single P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_73(System.Object P0, System.Object P1, System.Object P2, Beyond.UI.UIConst.AnimationState P3, System.Single P4) { }
        private System.Void __Gen_Wrap_74(System.Object P0, System.Int32 P1, System.Boolean P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_75(System.Object P0, System.Boolean P1, System.Boolean P2, System.Boolean P3) { }
        private Beyond.UI.UIScrollList.MoveTipsType __Gen_Wrap_76(System.Object P0) { }
        private System.Void __Gen_Wrap_77(System.Object P0, UnityEngine.Vector2 P1) { }
        private System.Void __Gen_Wrap_78(System.Object P0, System.Int32 P1, System.Boolean P2, Beyond.UI.UIScrollList.ScrollAlignType P3, System.Boolean P4) { }
        private Beyond.UI.UIText __Gen_Wrap_79(System.Object P0) { }
        private System.String __Gen_Wrap_80(System.Object P0) { }
        private UnityEngine.Sprite __Gen_Wrap_81(System.Object P0) { }
        private Beyond.UI.UIStyleInputValidTypeMask __Gen_Wrap_82(System.Object P0) { }
        private System.Void __Gen_Wrap_83(System.Object P0, Beyond.UI.UIStyleInputValidTypeMask P1) { }
        private System.Boolean __Gen_Wrap_84(Beyond.UI.UIStyleInputValidType P0) { }
        private System.Boolean __Gen_Wrap_85(Beyond.UI.UIStyleInputValidTypeMask P0) { }
        private System.Void __Gen_Wrap_86(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        private System.Int32 __Gen_Wrap_87() { }
        private System.Void __Gen_Wrap_88(System.Object P0, System.Boolean P1, System.Boolean P2) { }
        private UnityEngine.UI.Selectable __Gen_Wrap_89(System.Object P0) { }
        private System.Boolean __Gen_Wrap_90(System.Object P0, UnityEngine.Vector2 P1, System.Object P2) { }
        private System.Collections.Generic.IList<Beyond.UI.UIRecycleLayoutAdapter.IVirtualView> __Gen_Wrap_91(System.Object P0) { }
        private Beyond.UI.UIRecycleLayoutAdapter __Gen_Wrap_92(System.Object P0) { }
        private Beyond.UI.UIRecycleLayoutGroup.ViewMgr __Gen_Wrap_93(System.Object P0) { }
        private System.Void __Gen_Wrap_94(System.Object P0, System.Object P1, Beyond.UI.UIRecycleLayoutGroup.LayoutMeta P2) { }
        private UnityEngine.Vector2 __Gen_Wrap_95(System.Object P0, UnityEngine.Bounds P1) { }
        private UnityEngine.Bounds __Gen_Wrap_96(System.Object P0, Beyond.UI.UIRecycleLayoutGroup.LayoutMeta P1) { }
        private Beyond.UI.UIRecycleLayoutAdapter __Gen_Wrap_97(System.Object P0, System.Object P1) { }
        private Beyond.UI.UIRecycleLayoutGroup.ViewPool __Gen_Wrap_98(System.Object P0, System.Object P1) { }
        private UnityEngine.GameObject __Gen_Wrap_99(System.Object P0, System.Boolean& P1) { }
        private System.Boolean __Gen_Wrap_100(System.Object P0, System.Int32 P1, System.Object P2) { }
        private Beyond.UI.UIRecycleLayoutAdapter.IVirtualView __Gen_Wrap_101(System.Object P0, System.Int32 P1) { }
        private System.Single __Gen_Wrap_102(System.Object P0, System.Int32 P1) { }
        private UnityEngine.Bounds __Gen_Wrap_103(System.Object P0, System.Int32 P1) { }
        private System.Int32 __Gen_Wrap_104(System.Object P0, System.Object P1) { }
        private Beyond.UI.UIRecycleLayoutGroup.Direction __Gen_Wrap_105(System.Object P0) { }
        private Beyond.UI.UIRecycleMultiHolder.MultiVirtualView __Gen_Wrap_106(System.Object P0, System.Int32 P1) { }
        private System.Void __Gen_Wrap_107(System.Object P0, System.Int32 P1, System.Object P2, System.Single P3) { }
        private Beyond.UI.UIRecycleSingleHolder.SimpleVirtualView __Gen_Wrap_108(System.Object P0, System.Int32 P1) { }
        private Beyond.UI.ToastList.CellInfo __Gen_Wrap_109(System.Object P0) { }
        private System.Collections.IEnumerator __Gen_Wrap_110(System.Object P0, System.Int32 P1, System.Object P2) { }
        private System.Boolean __Gen_Wrap_111(System.Object P0, System.Object P1, System.Object P2) { }
        private System.Boolean __Gen_Wrap_112(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3, System.Boolean& P4, System.Boolean P5) { }
        private Beyond.Input.PlayerActionInfo __Gen_Wrap_113(System.Object P0) { }
        private System.Boolean __Gen_Wrap_114(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_115(Beyond.DeviceInfo.ControllerType P0) { }
        private System.Void __Gen_Wrap_116(System.Object P0, Beyond.EventData<System.String>& P1) { }
        private System.Void __Gen_Wrap_117(System.Object P0, System.Object P1, System.Object P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_118(System.Object P0, System.Int32 P1, System.Object P2, System.Object P3, System.Boolean P4) { }
        private UnityEngine.AnimationClip __Gen_Wrap_119(System.Object P0, System.Object P1, System.Boolean P2) { }
        private UnityEngine.AnimationClip __Gen_Wrap_120(System.Object P0, System.Object P1) { }
        private System.Void __Gen_Wrap_121(System.Object P0, Beyond.UI.UIAnimationWrapper.FOptions P1) { }
        private System.Single __Gen_Wrap_122(System.Object P0, System.Object P1) { }
        private Beyond.UI.UIAnimationWrapper.FOptions __Gen_Wrap_123() { }
        private System.Void __Gen_Wrap_124(System.Object P0, System.Object P1, System.Object P2, System.Single P3) { }
        private Beyond.UI.UISwitchTween.ITweenHandler __Gen_Wrap_125(System.Object P0) { }
        private Beyond.UI.UISwitchTween.ITweenHandler __Gen_Wrap_126(System.Object P0, System.Object P1) { }
        private Beyond.UI.UISwitchTween.ITweenHandler __Gen_Wrap_127(System.Object P0, System.Boolean P1) { }
        private Beyond.UI.UIAnimationSwitchTween __Gen_Wrap_128(Beyond.UI.UIAnimationSwitchTween.Builder& P0) { }
        private UnityEngine.Camera __Gen_Wrap_129(System.Object P0) { }
        private System.Void __Gen_Wrap_130(System.Object P0, System.Object P1, System.Boolean P2, System.Boolean P3, System.Boolean P4, System.Boolean P5) { }
        private System.Void __Gen_Wrap_131(System.Object P0, System.Boolean P1, System.Boolean P2, System.Boolean P3, System.Single P4) { }
        private System.Void __Gen_Wrap_132(System.Object P0, System.Single P1, System.Boolean P2) { }
        private System.Collections.IEnumerator __Gen_Wrap_133(System.Object P0, System.Object P1) { }
        private Beyond.DisposedUnityEvent<System.Int32,System.Boolean> __Gen_Wrap_134(System.Object P0) { }
        private System.Void __Gen_Wrap_135(System.Object P0, UnityEngine.Vector2& P1, UnityEngine.Vector2& P2) { }
        private UnityEngine.Vector2 __Gen_Wrap_136(System.Object P0, UnityEngine.Vector2 P1) { }
        private System.Void __Gen_Wrap_137(UnityEngine.EventSystems.PointerEventData P0) { }
        private System.Void __Gen_Wrap_138(System.Object P0, UnityEngine.Vector3 P1) { }
        private System.Void __Gen_Wrap_139(System.Object P0, System.Boolean P1, System.Single P2, System.Object P3, System.Object P4) { }
        private System.Void __Gen_Wrap_140(System.Single P0) { }
        private System.Void __Gen_Wrap_141(System.Object P0, System.Boolean P1, UnityEngine.UI.Selectable& P2, Beyond.UI.UITouchPanel& P3) { }
        private System.Void __Gen_Wrap_142(System.Object P0, System.Single P1, System.Single P2, System.Object P3) { }
        private System.Void __Gen_Wrap_143(System.Object P0, System.Object P1, System.Boolean P2, System.Object P3) { }
        private System.Void __Gen_Wrap_144(System.Object P0, System.Single& P1, System.Single& P2) { }
        private System.Void __Gen_Wrap_145(System.Object P0, System.Object P1, UnityEngine.Color P2) { }
        private UnityEngine.Canvas __Gen_Wrap_146(System.Object P0) { }
        private System.String __Gen_Wrap_147(System.Object P0, System.Object P1) { }
        private Beyond.Input.BindingViewState __Gen_Wrap_148(System.Object P0) { }
        private System.String __Gen_Wrap_149(System.Object P0, Beyond.Input.BindingViewActionType P1) { }
        private System.Boolean __Gen_Wrap_150(System.Object P0, System.String& P1, System.String& P2) { }
        private System.Void __Gen_Wrap_151(System.Object P0, Beyond.Input.ActionOnSetNaviTarget P1) { }
        private System.Collections.Generic.HashSet<UnityEngine.UI.CanvasScaler> __Gen_Wrap_152(System.Object P0) { }
        private UnityEngine.Vector2 __Gen_Wrap_153(System.Object P0) { }
        private System.Single __Gen_Wrap_154(UnityEngine.Vector2& P0) { }
        private Beyond.UI.UICanvasScaleHelper.FWorldCanvasParams __Gen_Wrap_155(System.Object P0, System.Object P1, System.Boolean P2) { }
        private Beyond.UI.UICanvasScaleHelper.FScreenCanvasParams __Gen_Wrap_156() { }
        private System.Void __Gen_Wrap_157(System.Object P0, Beyond.UI.UIColorGroup.CommonParams P1) { }
        private System.Void __Gen_Wrap_158(System.Object P0, System.Object P1, Beyond.UI.UIColorGroup.CommonParams P2) { }
        private System.Void __Gen_Wrap_159(System.Object P0, System.Single P1, System.Single P2, System.Boolean P3) { }
        private System.Void __Gen_Wrap_160(System.Object P0, UnityEngine.Color P1, System.Single P2, System.Boolean P3, System.Boolean P4, System.Boolean P5) { }
        private System.Void __Gen_Wrap_161(System.Object P0, UnityEngine.Color P1, System.Single P2, System.Boolean P3, System.Boolean P4) { }
        private Beyond.UI.UICustomLayoutElement __Gen_Wrap_162(System.Object P0) { }
        private System.String __Gen_Wrap_163(System.Object P0, System.Int32 P1) { }
        private System.Boolean __Gen_Wrap_164(System.Object P0, Beyond.UI.UICustomLayoutElement.LayoutData& P1, System.Boolean P2, System.Int32 P3) { }
        private System.Boolean __Gen_Wrap_165(System.Object P0, Beyond.UI.UICustomLayoutElement.LayoutData& P1, System.Int32 P2) { }
        private UnityEngine.RectTransform __Gen_Wrap_166(System.Object P0) { }
        private System.Void __Gen_Wrap_167(System.Object P0, Beyond.UI.UICustomLayoutElement.LayoutType P1) { }
        private UnityEngine.CanvasGroup __Gen_Wrap_168(System.Object P0) { }
        private System.Void __Gen_Wrap_169(System.Object P0, System.Boolean P1, System.Object P2) { }
        private System.Void __Gen_Wrap_170(System.Object P0, System.Object P1, System.Object P2, System.Object P3) { }
        private System.Void __Gen_Wrap_171(System.Object P0, System.Int32 P1, System.Boolean P2, System.Boolean P3, System.Boolean P4) { }
        private System.Void __Gen_Wrap_172(System.Object P0, UnityEngine.Vector2 P1, System.Boolean P2) { }
        private System.Void __Gen_Wrap_173(System.Object P0, System.Int32 P1, System.Int32 P2, System.Boolean P3) { }
        private System.Single __Gen_Wrap_174(System.Object P0, System.Boolean P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_175(System.Object P0, System.Boolean P1, System.Single P2, System.Single P3) { }
        private System.Void __Gen_Wrap_176(System.Object P0, UnityEngine.Rect P1) { }
        private System.Single __Gen_Wrap_177(System.Object P0, System.Object P1, System.Boolean P2) { }
        private System.Void __Gen_Wrap_178(System.Object P0, System.Int32 P1, System.Single P2) { }
        private System.Boolean __Gen_Wrap_179(System.Object P0, System.Boolean P1, System.Boolean P2) { }
        private UnityEngine.UI.Selectable __Gen_Wrap_180(System.Object P0, System.Boolean P1) { }
        private System.Boolean __Gen_Wrap_181(System.Object P0, System.Int32 P1, System.Int32 P2, System.Boolean P3, System.Boolean P4) { }
        private System.Boolean __Gen_Wrap_182(System.Object P0, UnityEngine.UI.NaviDirection P1, System.Boolean P2) { }
        private System.Void __Gen_Wrap_183(System.Object P0, UnityEngine.UI.NaviDirection P1) { }
        private System.Boolean __Gen_Wrap_184(System.Object P0, UnityEngine.UI.NaviDirection P1) { }
        private UnityEngine.Vector3 __Gen_Wrap_185() { }
        private System.Void __Gen_Wrap_186(UnityEngine.Vector3 P0) { }
        private Beyond.UI.UIAtlasManager.UIAtlasHandle __Gen_Wrap_187(Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause P0) { }
        private UnityEngine.Texture __Gen_Wrap_188(System.Object P0) { }
        private DG.Tweening.Core.TweenerCore<System.Single,System.Single,DG.Tweening.Plugins.Options.FloatOptions> __Gen_Wrap_189(System.Object P0, System.Single P1, System.Single P2) { }
        private Beyond.UI.UIImage __Gen_Wrap_190(System.Object P0) { }
        private System.Boolean __Gen_Wrap_191(Beyond.UI.UIInertiaViewPager.ScrollEffectConfig& P0) { }
        private System.Int32 __Gen_Wrap_192(System.Object P0, System.Single P1) { }
        private System.Single __Gen_Wrap_193(System.Object P0, System.Single P1) { }
        private Beyond.UI.UIInertiaViewPager.State __Gen_Wrap_194(System.Object P0, System.Object P1) { }
        private System.Boolean __Gen_Wrap_195(Beyond.UI.UIInertiaViewPager.InertiaBlocker& P0, System.Single P1) { }
        private System.Boolean __Gen_Wrap_196(System.Object P0, System.Single P1, System.Single& P2) { }
        private System.Void __Gen_Wrap_197(System.Object P0, System.Single P1, System.Single P2) { }
        private System.Void __Gen_Wrap_198(System.Object P0, Beyond.UI.UIInertiaViewPager.State P1, Beyond.UI.UIInertiaViewPager.State P2) { }
        private System.Void __Gen_Wrap_199(System.Object P0, System.Int32 P1, System.Object P2) { }
        private System.Void __Gen_Wrap_200(Beyond.UI.UIInertiaViewPager.EmptyScrollHandler& P0) { }
        private System.Void __Gen_Wrap_201(System.Object P0, System.Boolean P1, UnityEngine.Vector2 P2, UnityEngine.Vector2 P3) { }
        private System.Void __Gen_Wrap_202(System.Object P0, UnityEngine.UI.CanvasUpdate P1) { }
        private UnityEngine.Transform __Gen_Wrap_203(System.Object P0) { }
        private System.Void __Gen_Wrap_204(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4) { }
        private System.Int32 __Gen_Wrap_205(System.Object P0, System.Boolean P1) { }
        private System.Single __Gen_Wrap_206(System.Object P0, System.Int32 P1, Beyond.UI.UIScrollList.ScrollAlignType P2) { }
        private System.Void __Gen_Wrap_207(System.Object P0, System.Int32 P1, System.Boolean P2, Beyond.UI.UIScrollList.ScrollAlignType P3) { }
        private System.Void __Gen_Wrap_208(System.Object P0, System.Int32 P1, System.Int32 P2, System.Boolean P3, System.Boolean P4, System.Boolean P5, Beyond.UI.UIScrollList.ScrollAlignType P6) { }
        private System.Void __Gen_Wrap_209(System.Object P0, System.Int32 P1, System.Boolean P2, System.Boolean P3, System.Boolean P4, System.Boolean P5) { }
        private UnityEngine.GameObject __Gen_Wrap_210(System.Object P0, System.Int32 P1) { }
        private Beyond.UI.UIScrollList.Cell __Gen_Wrap_211(System.Object P0, System.Int32 P1) { }
        private System.Int32 __Gen_Wrap_212(System.Object P0, UnityEngine.UI.NaviDirection P1) { }
        private System.Int32 __Gen_Wrap_213(System.Object P0, System.Int32 P1, UnityEngine.UI.NaviDirection P2) { }
        private System.Void __Gen_Wrap_214(System.Object P0, System.Single P1, System.Single P2, System.Single P3) { }
        private System.Boolean __Gen_Wrap_215(System.Object P0, UnityEngine.Vector3 P1) { }
        private UnityEngine.Vector3 __Gen_Wrap_216(System.Object P0) { }
        private System.Single __Gen_Wrap_217(System.Object P0, UnityEngine.Vector2 P1) { }
        private System.Boolean __Gen_Wrap_218(System.Object P0, System.Single P1) { }
        private Beyond.UI.UIScrollList.Padding __Gen_Wrap_219(System.Object P0) { }
        private System.Void __Gen_Wrap_220(System.Object P0, System.Int32& P1, System.Int32& P2) { }
        private System.Int32 __Gen_Wrap_221(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        private System.Int32 __Gen_Wrap_222(System.Object P0, UnityEngine.Vector2 P1, UnityEngine.UI.NaviDirection P2) { }
        private System.Void __Gen_Wrap_223(System.Object P0, UnityEngine.Vector2 P1, System.Int32& P2, System.Int32& P3) { }
        private Beyond.UI.UIScrollRect.MoveTipsType __Gen_Wrap_224(System.Object P0) { }
        private System.Void __Gen_Wrap_225(System.Object P0, System.Object P1, System.Object P2, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState P3) { }
        private System.Void __Gen_Wrap_226(System.Object P0, UnityEngine.Vector2Int P1) { }
        private Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState __Gen_Wrap_227(System.Object P0) { }
        private UnityEngine.Rect __Gen_Wrap_228(System.Object P0) { }
        private System.Boolean __Gen_Wrap_229(System.Object P0, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState P1, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotDir P2, System.Object P3) { }
        private System.Void __Gen_Wrap_230(System.Object P0, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState& P1, Beyond.UI.UIScrollRectEdgeRedDot.ERedDotState& P2) { }
        private System.Void __Gen_Wrap_231(System.Object P0, System.Boolean P1, System.Single P2) { }
        private UnityEngine.Vector3 __Gen_Wrap_232(System.Object P0, System.Int32 P1) { }
        private UnityEngine.Vector3[] __Gen_Wrap_233(System.Object P0) { }
        private UnityEngine.UI.Graphic __Gen_Wrap_234(System.Object P0) { }
        private Beyond.UI.UISoftMask __Gen_Wrap_235(System.Object P0) { }
        private System.Boolean __Gen_Wrap_236(System.Object P0, System.Single P1, System.Single P2) { }
        private UnityEngine.Vector2 __Gen_Wrap_237(System.Object P0, UnityEngine.Vector2 P1, UnityEngine.Vector2 P2, UnityEngine.Vector2 P3, UnityEngine.Vector2 P4) { }
        private System.Void __Gen_Wrap_238(System.Object P0, UnityEngine.Vector2 P1, UnityEngine.Vector2 P2, UnityEngine.Vector2 P3, UnityEngine.Vector2 P4, System.Single& P5, System.Single& P6) { }
        private System.Void __Gen_Wrap_239(UnityEngine.UIVertex& P0, UnityEngine.Vector2 P1, UnityEngine.Vector2 P2, UnityEngine.Vector2 P3) { }
        private System.Void __Gen_Wrap_240(System.Object P0, System.Object P1, System.Object P2, System.Boolean& P3) { }
        private Beyond.UI.UISoftMaskable __Gen_Wrap_241(System.Object P0) { }
        private System.Collections.IEnumerator __Gen_Wrap_242(System.Object P0, System.Boolean P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_243(System.Object P0, System.Boolean P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_244(System.Object P0, System.Object P1, System.Boolean P2, System.Object P3, System.Object P4, System.Object P5, System.Boolean P6) { }
        private System.UInt32 __Gen_Wrap_245(System.Object P0) { }
        private System.Void __Gen_Wrap_246(System.UInt32 P0, System.Boolean P1) { }
        private TMPro.TMP_FontAsset __Gen_Wrap_247(System.Object P0, System.Object P1) { }
        private System.Boolean __Gen_Wrap_248(System.Object P0, System.Object P1, System.UInt32 P2, TMPro.TMP_FontAsset& P3) { }
        private System.Boolean __Gen_Wrap_249(System.Single& P0, System.Single P1) { }
        private System.Void __Gen_Wrap_250(Beyond.UI.TweenUtils.FLerpByTime& P0, System.Object P1) { }
        private System.Single __Gen_Wrap_251(Beyond.UI.TweenUtils.FLerpByTime& P0, System.Boolean& P1) { }
        private UnityEngine.Playables.PlayableGraph __Gen_Wrap_252(System.Object P0) { }
        private UnityEngine.Animations.AnimationLayerMixerPlayable __Gen_Wrap_253(System.Object P0, UnityEngine.Playables.PlayableGraph P1, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FMixerOptions<UnityEngine.AnimationClip>& P2) { }
        private UnityEngine.Animations.AnimationPlayableOutput __Gen_Wrap_254(System.Object P0, UnityEngine.Playables.PlayableGraph P1) { }
        private UnityEngine.Animations.AnimationClipPlayable __Gen_Wrap_255(System.Object P0, System.Object P1, UnityEngine.Playables.PlayableGraph P2, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FPlayableMeta<UnityEngine.AnimationClip>& P3) { }
        private UnityEngine.Animations.AnimationMixerPlayable __Gen_Wrap_256(System.Object P0, UnityEngine.Playables.PlayableGraph P1, Beyond.Playables.GenericShareSingleMixerAssetPlayer.FMixerOptions<UnityEngine.AnimationClip>& P2) { }
        private System.Void __Gen_Wrap_257(System.Boolean P0, Beyond.Resource.FAssetProxyHandle P1) { }
        private System.Void __Gen_Wrap_258(Beyond.UI.UISwitchTween.TweenContext& P0) { }
        private System.Void __Gen_Wrap_259(Beyond.UI.UISwitchTween.TweenContext& P0, System.Object P1) { }
        private System.Void __Gen_Wrap_260(System.Object P0, Beyond.UI.UISwitchTween.Options P1) { }
        private Beyond.UI.UISwitchTween.TweenContext __Gen_Wrap_261(System.Object P0) { }
        private System.Boolean __Gen_Wrap_262(Beyond.UI.UISwitchTween.TweenContext& P0) { }
        private System.Single __Gen_Wrap_263(Beyond.UI.FadeSwitchTween.Durations& P0, System.Single P1) { }
        private Beyond.UI.FadeSwitchTween __Gen_Wrap_264(Beyond.UI.FadeSwitchTween.Builder& P0) { }
        private UnityEngine.Vector2 __Gen_Wrap_265(System.Object P0, System.Boolean P1) { }
        private System.Void __Gen_Wrap_266(System.Object P0, UnityEngine.RectInt& P1) { }
        private System.Boolean __Gen_Wrap_267(System.Object P0, System.Object P1, Beyond.UI.UIAtlasManager.UIAtlasProcessFailureCause& P2) { }
        private UnityEngine.RectInt __Gen_Wrap_268(System.Object P0, System.Int32 P1, System.Int32 P2) { }
        private System.Void __Gen_Wrap_269(System.Object P0, System.Object P1, System.Object P2, UnityEngine.RectInt& P3) { }
        private System.Boolean __Gen_Wrap_270(Beyond.UI.UIAtlasManager.UIAtlasHandle& P0) { }
        private System.Void __Gen_Wrap_271(System.Object P0, System.Collections.Generic.List<UnityEngine.RectInt>& P1) { }
        private System.Void __Gen_Wrap_272(System.Int32 P0, System.String P1) { }
        private System.Boolean __Gen_Wrap_273(Beyond.UI.UIState.StateAnimationInfo P0) { }
        private Beyond.UI.GPUI.GPUPrefabData __Gen_Wrap_274(UnityEngine.Vector4 P0, UnityEngine.Vector4 P1, UnityEngine.Vector2 P2) { }
        private Beyond.UI.GPUI.GPUPrefabDataLite __Gen_Wrap_275(UnityEngine.Vector4 P0, UnityEngine.Vector4 P1, UnityEngine.Vector2 P2) { }
        private System.Boolean __Gen_Wrap_276(Beyond.UI.GPUI.GPUIHandle& P0, Beyond.UI.GPUI.GPUIHandle P1) { }
        private System.Boolean __Gen_Wrap_277(Beyond.UI.GPUI.GPUIHandle& P0, System.Object P1) { }
        private System.Int32 __Gen_Wrap_278(Beyond.UI.GPUI.GPUIHandle& P0) { }
        private System.Boolean __Gen_Wrap_279(Beyond.UI.GPUI.GPUIHandle P0, Beyond.UI.GPUI.GPUIHandle P1) { }
        private Beyond.UI.GPUI.GPUIHandle __Gen_Wrap_280(System.Object P0) { }
        private System.Void __Gen_Wrap_281(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1) { }
        private System.Boolean __Gen_Wrap_282(System.Object P0, System.Object P1, Beyond.UI.GPUI.GPUIHandle& P2, System.Int32 P3) { }
        private System.Boolean __Gen_Wrap_283(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1) { }
        private System.Void __Gen_Wrap_284(System.Object P0, System.Int32 P1, UnityEngine.Vector3 P2) { }
        private System.Boolean __Gen_Wrap_285(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, UnityEngine.Vector3 P2) { }
        private System.Boolean __Gen_Wrap_286(System.Object P0, System.Object P1, UnityEngine.Vector3 P2, Beyond.UI.GPUI.GPUIHandle& P3, System.Int32 P4) { }
        private System.Boolean __Gen_Wrap_287(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, UnityEngine.Vector2 P2) { }
        private System.Void __Gen_Wrap_288(System.Object P0, System.Single P1, System.Int32 P2) { }
        private System.Boolean __Gen_Wrap_289(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Boolean P2, System.Object P3, System.Boolean P4) { }
        private System.Boolean __Gen_Wrap_290(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Boolean P2, System.Int32 P3, System.Boolean P4) { }
        private System.Boolean __Gen_Wrap_291(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Object P2, System.Boolean P3) { }
        private System.UInt32 __Gen_Wrap_292(UnityEngine.Color P0) { }
        private System.Void __Gen_Wrap_293(System.Object P0, System.Int32 P1, UnityEngine.Color P2) { }
        private System.Boolean __Gen_Wrap_294(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Object P2, UnityEngine.Color P3) { }
        private System.Boolean __Gen_Wrap_295(System.Object P0, Beyond.UI.GPUI.GPUIHandle P1, System.Object P2, System.Object P3) { }
        private System.Void __Gen_Wrap_296(System.Object P0, Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData>& P1, System.Int32& P2, System.Int32& P3, System.Int32& P4) { }
        private System.Void __Gen_Wrap_297(System.Object P0, Unity.Collections.NativeArray<Beyond.UI.GPUI.GPUInstanceData>& P1, System.Int32 P2, System.Boolean P3) { }
        private Unity.Collections.NativeArray<UnityEngine.CanvasRenderer.InstanceRange> __Gen_Wrap_298(System.Object P0) { }
        private System.Int32 __Gen_Wrap_299(System.Object P0, System.Object P1, System.Int32 P2) { }
        private Beyond.UI.GPUI.RuntimePrefabData __Gen_Wrap_300(System.Object P0, System.Object P1) { }
        private UnityEngine.Mesh __Gen_Wrap_301() { }
        private System.UInt32 __Gen_Wrap_302(System.UInt32 P0, System.UInt32 P1) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000160
    public class ILFixInterfaceBridge : AnonymousStorey, IDisposable, IEnumerator, IEnumerator`1
    {
        // Fields
        private System.Int32 methodId_0;        // 0x40
        private System.Int32 methodId_1;        // 0x44
        private System.Int32 methodId_2;        // 0x48
        private System.Int32 methodId_3;        // 0x4C
        private System.Int32 methodId_4;        // 0x50

        // Methods
        private System.Void System.IDisposable.Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
        private System.Void System.Collections.IEnumerator.Reset() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine) { }
        private System.Void RefAsyncBuilderStartMethod() { }

    }

    // TypeToken: 0x2000161
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

    // TypeToken: 0x2000162
    public struct IDMAP0
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static IFix.IDMAP0 Beyond-PoolCore-ListPoolInitializer_UI_Beyond-Initialize0;        // 0x0
        public static IFix.IDMAP0 Beyond-PoolCore-ListPoolInitializer_UI_Beyond-InitializeAtRuntime0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-UI-Tools-UIGridLayoutElement-CalculateLayoutInputHorizontal0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-UI-Tools-UIGridLayoutElement-CalculateLayoutInputVertical0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-UI-Tools-UIGridLayoutElement-_GetPreferredSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_minWidth0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_preferredWidth0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_minHeight0;        // 0x0
        public static IFix.IDMAP0 Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_preferredHeight0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-_InitState0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-_UpdatePos0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-_UpdateLookAtCamera0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-SetLookAtCamera0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-ForceUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellCircleEffect-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-Gameplay-UI-UIScrollCellSlantEffect-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-_ResolveTextStyle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-_IsUITextDisplayable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-_GetGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextGroup-_NotifyDisplayableChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextGroup-_AddDisplayableCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextGroup-_SubDisplayableCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextGroup-ChangeDisplayable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-UpdateWrapDisplayable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-SetAndResolveTextStyle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-GetPhoneticText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-SetPhoneticText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-OnEnvLangChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-set_text0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-_ReleaseUpdateFunction0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-TryGetOriginalLinkId0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-TryGetLinkId0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-_UpdateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-_CreateUpdateFunction0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-_DelayedChangeActiveImageGo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-ClearMesh0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-RichTextAnalyzer-PreAnalyzeRichText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-GetOrLoadSprite0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-RichTextAnalyzer-GetCharacterCountWithoutRichText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-RichTextAnalyzer-ProcessRichTextEntryFallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-_ProcessRichTextEntry0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-get_processRichTextEntryFunc0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-RichTextAnalyzer-_GetHashCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-RichTextAnalyzer-_TryParseParam0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-RichTextAnalyzer-_TryParseRichTextEntry0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-RichTextAnalyzer-AnalyzeRichText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-_ReturnImageGO0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-_ClearInlineImage0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-_GetOrCreateImageGO0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-_GetImageGoByIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-_ProcessRichTextInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-RefreshPopulateText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-I18nFontLoader-GetMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-LoadMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextGroup-Remove0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-RemoveWrap0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-_OnPreRenderText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-DisposeInlineImageCache0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-_GenerateRuntimeText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-I18nFontLoader-get_fontSearchData0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-I18nFontLoader-IsFontDefaultMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-_RefreshMatTexture0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-I18nFontLoader-GetI18nFont0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-GetFontAsset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-OnPointerClick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-OnPointerEnter0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-OnPointerExit0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextWrap-Clear0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextGroup-Add0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-AddWrap0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-ChangeWrapGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-ChangeWrapOrder0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-SetHyperlinkUITextGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-ShrinkLinkTags0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-TryGetLinkId1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-TryGetCharacterStartPosAndHeight0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-TryGetCharacterEndPosAndHeight0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-CombineStringWithLanguageSpilt0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-IsGroupDisplayable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-IsHyperlinkUITextGroupDisplayable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-HyperlinkUITextManager-GetGroupDisplayableUIText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-GetGroupDisplayableHyperlinkUIText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-UpdateI18NFontAsset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-get_m_fontAsset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-I18nFontLoader-GetCNFontId0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-set_m_fontAsset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-set_fontSharedMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-SetSharedMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-OnAfterDeserialize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-AddSubTextObject0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIText-LocalStringCombineFormat0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIConst-IsPadDevice0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIConst-GetResolutionScale0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIModelLoader-LoadModel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIModelLoader-LoadModelAsync0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIModelLoader-Cancel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIModelLoader-UnloadModel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIModelLoader-_Clear0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIModelLoader-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIUtils-GetSharedIntString0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIUtils-IsScreenPosInRectTransform0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIUtils-IsScreenPosInRectTransform1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIUtils-CalcBoundOfRectTransform0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIUtils-TryGetTouch0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIUtils-SetAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIUtils-SetColorWithoutAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIUtils-ClearUIComponents0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIUtils-RectTransformToScreenRect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIUtils-GetNodeScaleOffset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIUtils-GetColorByString0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIUtils-SetMaskRatio0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIUtils-GetCursorTipOffsetInScreen0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIUtils-GetCursorTipOffsetX0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ActiveSyncHelper-Sync0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ActiveSyncHelper-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ActiveSyncHelper-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ActiveSyncHelper-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-Billboard-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-Billboard-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CinemachineGyroscopeEffect-PostPipelineStageCallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetRealIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CommonItemToastList-_GetUnConstraintTargetPos0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CommonItemToastList-AdjustContainerPos0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-CacheCell0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-ClearShowingCells0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetShowRange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetNotCacheRange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-MoveCellTo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnUpdateCell0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetCell0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-RecoverAllInput0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-_TryCallAnimationInFinished0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-InformAnimationInEnd0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-ClearTween0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationLoopSynchronizer-GetLoopStartPosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-_InitAnimation0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-GetClip0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-_SampleClipAtLength0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SampleClip0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-InformAnimationInStart0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-PlayWithTween0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-PlayLoopAnimation0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-_OnInEasingAnimationFinished0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-PlayWithTween1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-_OnInAnimationFinished0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-PlayOpenAudio0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-PlayInAnimation0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-UpdateCell0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-UpdateShowingCells0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-get_moveTips0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_UpdateMoveTips0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-UpdateViewEffect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CommonItemToastList-ScrollToIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ControllerSideMenuItemList-ToggleItemForceValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ControllerSideMenuItemList-IsItemForceValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ControllerSideMenuItemList-ClearForceValidItemList0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-IsValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-get_label0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-get_text0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetSprite0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-Execute0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetItemName0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-get_inputValidTypeMask0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-set_inputValidTypeMask0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-_OnActiveTypeChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-IsShowTypeValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-get_isValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-ToggleActiveState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-CheckState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CustomUIStyle-IsValidInput0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-DeactivateNaviOnEnable-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-DeactivateNaviOnEnable-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-DecoLineActiveHelper-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-DecoLineActiveHelper-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-DecoLineActiveHelper-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-DecoLineActiveHelper-_HasActiveTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-Empty4Raycast-OnPopulateMesh0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FitAspectRatioByFOV-_AdjustFOV0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FitAspectRatioByFOV-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FitAspectRatioByFOV-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FitAspectRatioByFOV-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FitAspectRatioByFOV-OnScreenSizeChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FixRotation-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FullScreenSceneBlurMarker-_GetNextId0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FullScreenSceneBlurMarker-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FullScreenSceneBlurMarker-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FullScreenSceneBlurMarker-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FullScreenSceneBlurMarker-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-InputBindingGroupNaviDecorator-_SetSelfEnabledStateIfNecessary0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-InputBindingGroupNaviDecorator-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-InputBindingGroupNaviDecorator-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-InputBindingGroupNaviDecorator-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-InputBindingGroupNaviDecorator-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-InputBindingGroupNaviDecorator-_OnSetAsNaviTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-_TrySetRot0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-AddSortingOrderComp0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-RemoveSortingOrderComp0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-BlockAllInput0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-_AutoAnimationInFinish0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-LuaPanel-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-MouseHoverTipsPosHelper-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-MouseHoverTipsPosHelper-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-MouseHoverTipsPosHelper-UpdatePosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-MouseHoverTipsPosHelper-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-MouseHoverTipsPosHelper-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NaviToThisGroupOnEnable-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NaviToThisGroupOnEnable-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_FindDefaultSelectable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-NaviToThisGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NaviToThisGroupOnEnable-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NonDrawingGraphic-get_Radius0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NonDrawingGraphic-SetMaterialDirty0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NonDrawingGraphic-SetVerticesDirty0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NonDrawingGraphic-OnPopulateMesh0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NonDrawingGraphic-_IsRaycastLocationValidCircle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NonDrawingGraphic-IsRaycastLocationValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-ClearNullRef0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-ApplyNotch0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-ApplyNewNotch0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-_OnCanvasChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-_UpdateMargeSizeFromNotchInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-ClearList0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-_TryAddToSideUI0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-_TraverseUI0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-FindAllSideUI0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-ApplyNotch1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-NotchAdapter-UnApplyNotch0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ParallaxHelper-InitConfigs0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ParallaxHelper-ResetValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ParallaxHelper-RefreshPos0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-PercentNumberTweener-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-PercentNumberTweener-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-PercentNumberTweener-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutAdapter-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutAdapter-GenerateViewsForRebuild0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutAdapter-VirtualView-AttachView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutAdapter-VirtualView-DetachView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutAdapter-VirtualView-GetAttachedView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutAdapter-VirtualView-GetViewID0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-get_adapter0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-get_viewMgr0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-CalculateLayoutInputHorizontal0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-CalculateLayoutInputVertical0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-get_paddingFront0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-get_paddingBack0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_ApplyLayoutMeta0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_GetVisibleRange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_GetElementBoundsFromMeta0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewPool-RecycleAll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-RebuildAll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViews0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_UpdateViews0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_RebuildAllViews0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-SetAdapter0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-_EnsureViewPool0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewPool-Recycle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-DetachView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewPool-Alloc0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-AttachView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-OnLateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_InsertView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_RemoveView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_UpdateViewsFrom0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_GetElementPosByIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_GetElementBoundsByIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_GetElementIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-_RefreshLayout0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViewCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-InsertView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-AddView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-RemoveView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyViewSizeChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyAllViewSizeChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyRebuild0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementPosByIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementBoundsByIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetDirection0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetSizeOnAxis0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViewportSizeOnAxis0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-ViewMgr-_NotifyLayoutChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-EmptyAdapter-GenerateViewsForRebuild0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleLayoutGroup-EmptyAdapter-OnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-GetVirtualView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-UpdateCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-UpdateCount1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-InsertView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-AddView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-OnAdapterInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetPrefab0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetPreferSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-OnViewDetached0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-OnViewAttached0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-GetVirtualView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-UpdateCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-UpdateCount1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-InsertView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-AddView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-OnAdapterInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetPrefab0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetPreferSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-OnViewDetached0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-OnViewAttached0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-SimpleUITextSingleLine-GenerateTextMesh0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ToastList-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ToastList-_CacheCell0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ToastList-ClearAllToast0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ToastList-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ToastList-_GetCell0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-PlayCloseAudio0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-PlayOutAnimation0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ToastList-_TryShowNewCell0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-GetOutClipLength0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ToastList-_OnCellFinished0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ToastList-_ShowCell0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ToastList-_StartBatch0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ToastList-AddToast0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-ToastList-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UI3DScrollList-MoveCellTo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-DisposeSpriteHandle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-_LoadSprite0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-LoadSpriteWithOutFormat0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_SetKeyCodeSprite0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-GetAndSetActionIcon0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_SetSecondIcon0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-SetSecondActionId0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-GetActionId0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-GetActionInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-SetContentState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-GetAndSetActionModifyIcon0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-GetTextStr0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_IsInputGray0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_IsInputEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_CheckInteractable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-UpdateKeyHint0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_RefreshAllKeyHints0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_OnControllerTypeChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_OnInputLateTickAll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_TryInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_OnInputActionKeyUpdated0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-_OnChangeTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-SetKeyHint0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-SetActionId0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-SetBindingId0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-SetBindingId1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIActionKeyHint-SetText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationHolder-_FindByString0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationHolder-FindByName0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationHolder-FindByNameOrAlias0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationHolder-GetAnimationClips0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationLoopSynchronizer-RegisterChild0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationLoopSynchronizer-UnregisterChild0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SetOptions0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-_AnimationInLoopCheck0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-_AnimationAutomaticallyCheck0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-IsStarted0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SetAnimationOutClip0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-GetInClipLength0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-GetLoopClipLength0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SkipInAnimation0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SampleToInAnimationBegin0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SampleToInAnimationEnd0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SampleToOutAnimationEnd0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-AnimationRuntime-GetClipLength0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-GetClipLength0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-SampleClipAtPercent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-_CheckShouldAutoPlayAnimationIn0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-CheckStopped0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-Play0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-Play1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationTween-GetValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-GetCurPlayingTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationWrapper-FOptions-GetDefault0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationTween-_SetValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-GenerateTweenOfHide0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-GenerateTweenOfShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-_SetGameObjectActive0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-BeforeShowEffect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-AfterHideEffect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-ResetToState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-TweenHandler-IsPlaying0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-TweenHandler-KillIfNecessary0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-TweenHandler-OnComplete0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-TweenHandler-SetAutoKill0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-TweenHandler-_OnComplete0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationSwitchTween-Builder-Build0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIArea-_SetHighlightNodeActive0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIArea-OnPointerEnter0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIArea-OnPointerExit0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIArea-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIArea-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIArea-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIArea-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-AddToAutoCloseLayer0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-RemoveFromAutoCloseLayer0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-set_includeInAutoCloseLayer0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-_AutoCloseToggleObjWhenOut0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-CloseSelf0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-TryCloseSelf0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-_UpdateState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-InitBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-_GetUICamera0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-IsTopAutoCloseLayer0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-ShouldClose0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-ChangeEnableCloseActionOnController0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-OpenSelf0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAutoCloseArea-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigLogo-SetBigLogoEditor0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigLogo-ShowBigLogo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigLogo-SetBigLogoMask0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigLogo-ClearBigLogoMask0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigLogo-ClearBigLogo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigLogo-SetAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigLogo-SetMaskAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-_StopLongPressCor0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-_DoClickAnimation0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-_PlayClickAnimation0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-_OnPress0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-OnPointerDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectButton-OnPointerDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-OnPointerUp0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectButton-OnPointerUp0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectButton-OnDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectButton-OnBeginDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectButton-OnEndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectButton-OnScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-get_zoomEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_GetContainerRectBounds0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_GetAdjustedPosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_OnDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_RefreshPivotPosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-ResetPivotPositionToScreenCenter0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_RefreshPivotPositionToMousePosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_RefreshPivotPosition1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_UpdatePositionOffsetAfterZoomed0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_PosAdjust0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_SetScale0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_SetZoomValueAndScale0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_OnZoom0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_RefreshControllerFocusRaycastResults0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_OnControllerClick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_InitControllerBindings0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_GetIsControllerMoveEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_TickRefreshControllerStickMove0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_GetIsControllerZoomEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_TickRefreshControllerStickZoom0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_TickRefreshControllerZoomKeyHint0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_TickRefreshController0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_TickCheckControllerFocusRaycastTargets0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-OnRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-ManuallyZoom0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_TryAlignWhenInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-_ResetControllerState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-FocusNode0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-FocusNode1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-ZoomToFullRect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-ChangePaddingRight0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-SetZoomRangeMax0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-OverrideZoomRangeMin0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-SyncZoomValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-GetZoomRange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-GetCurrentZoomValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-ChangePivotPositionToTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-ClearAllTween0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBigRectHelper-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlendImage-SetMaterialKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlendImage-SetColor0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlendImage-SetTexture0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlendImage-ClearMaterialCache0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlurMono-get_canvas0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlurMono-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlurMono-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlurMono-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlurMono-UpdateSortingOrder0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlurMono-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-InitRT0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-Register0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-UnRegister0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-UpdateRT0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-_Clear0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIBlurRT-SetUseSceneColorPS0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-_UpdateState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-_Press0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-OnPointerClick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-_OnUpdateKey0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-_InitActionOnSetNaviTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-InitBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-_NotifyIsHover0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-set_text0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-OnInteractableChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-_GetUIButtonKeyHintActionId0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-get_bindingViewActionId0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-set_customBindingViewLabelText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-get_hintText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-get_bindingViewState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-GetBindingViewActionId0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-Beyond.Input.IBindingView.OnInputKeyDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-Beyond.Input.IBindingView.OnInputKeyUp0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-_RefreshHoverEnableNode0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-GetMouseActionHints0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-OnNaviTargetEnabledAgain0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-_ToggleNaviInputBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-_OnSetAsNaviTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-ChangeActionOnSetNaviTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIButton-Beyond.Input.IBindingView.get_interactable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-get_standardHorizontalResolution0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-get_standardVerticalResolution0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-get_canvasScalerList0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-GetProperCanvasResolution0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-_OnInputTypeChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-_CanvasOnWillRenderCanvases0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-CalcCurrentScreenRatio0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-CalcWorldCanvasParams0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-CalcScreenCanvasParams0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-UpdateCanvas0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-OnScreenSizeChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-AddCanvas0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-RemoveCanvas0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICanvasScaleHelper-ForceCanvasUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-_SetColor0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-_ApplyOptToGraphics0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-set_color0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-AttachGraphic0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-AttachGraphicsWithGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-_CrossFadeAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-CrossFadeAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-_CrossFadeColorRGB0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-CrossFadeColor0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-_CrossFadeColorAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIColorGroup-CrossFadeColor1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIControllerKeyIcon-RefreshKeyIcon0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIControllerKeyIcon-_OnControllerTypeChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIControllerKeyIcon-_TryStaticInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIControllerKeyIcon-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIControllerKeyIcon-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIControllerKeyIcon-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayout-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-IsDirty0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayout-IsDirty0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-_SetChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-get_Element0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-_GetMarginSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-_ApplyScale0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-_ApplyAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-_ApplyPosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-ResetToDefault0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-ResetToDefault0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-_CheckElementKeyIsValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-GetElementKeyWithRatio0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-SaveData0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-Save0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayout-_LogEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayout-Save0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayout-ResetToDefault0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-get_highlightRect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-_SetDefaultValues0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-LoadData0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-_OnHudLayoutSaved0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutElement-RefreshAll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-_ApplyScale0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-_CalculatePositionRange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-_ApplyPosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-set_position0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-set_scale0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-_ApplyAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-set_alpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-_ApplyLayoutType0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-set_layoutType0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-_OnElementDataLoaded0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-_OnSystemDisplaySizeChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-OnBeginDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-OnDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-OnEndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-OnPointerClick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UICustomLayoutHandle-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-get_playing0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-ResetPlay0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-_RefreshPosY0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-RefreshAutoScrollData0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-SetText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-Play0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-RefreshText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-OnVisibleCharactersChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-StopPlay0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-GetAutoWaitTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-GetScrollSpeed0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-_TryAutoScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-_UpdateTextAuto0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-SeekToEnd0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-ManualUpdateByPercent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-ManualUpdateByTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogText-GetDisplayAllCharactersTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogTextWithCursor-ResetPlay0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogTextWithCursor-OnVisibleCharactersChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogTextWithCursor-GetDisplayAllCharactersTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogTimelineText-get_canvasGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogTimelineText-UpdateAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-LoadSprite0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogTimelineText-_ClearRadioIcon0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDialogTimelineText-SetRadioIcon0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDrag-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDrag-OnDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDrag-OnBeginDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDrag-OnEndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDrag-ApplyDragArea0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDrag-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragHandler-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragHandler-OnPointerDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragHandler-OnBeginDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragHandler-OnDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragHandler-OnEndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-get_m_dragParentRect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-_StopDragView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-OnEndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-OnDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-_ContinueDragOnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-ClearEvents0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDragItem-OnBeginDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-_GetDefaultNaviTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-_ToggleOptions0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_OnFocus0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-ManuallyFocus0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-_ControllerToggle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_OnStopFocus0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-ManuallyStopFocus0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-ToggleOptions0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-_ControllerCancel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-_InitBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-_NotifyIsHover0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-OnPointerClick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-_GetUICamera0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-Update0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-SetSelected0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-_GetUICamera0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-ScrollTo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-AutoScrollToRectTransform0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-ScrollToSelected0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-Refresh0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdown-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdownOption-SetText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateReference-SetController0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-get_IsEmpty0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyGameObject0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyGraphic0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateControllerUtils-SetTop0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateControllerUtils-SetBottom0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateControllerUtils-SetLeft0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateControllerUtils-SetRight0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateControllerUtils-ForceRebuildLayout0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyRectTransform0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyImage0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyCanvasGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyButton0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyAnimator0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyLayoutElement0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyInnerState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateController-OnStateReferenceDirty0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateReference-ScheduleForPlaying0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateControllerUtils-StartEditorUpdateLoop0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateAnimationInfo-OnUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateReference-ScheduleForStopping0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyAnimation0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyLayoutGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetLeftLength0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_SetRealPadding0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetContainerSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetContainerSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-UpdateContainerSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetPadding0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyScrollList0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ApplyGridLayoutGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateController-_ApplyState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateController-SetState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropdownOption-SetState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropItem-ClearEvents0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropItem-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropItem-ToggleHighlight0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropItem-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropItem-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropItem-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropItem-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIDropItem-OnDrop0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIElementFollower-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIElementFollower-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIElementFollower-UpdatePosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIElementFollower-UpdatePosition1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIElementFollower-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIElementFollower-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIExtendScrollRect-OnScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnBeginDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIExtendScrollRect-OnBeginDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIExtendScrollRect-OnDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnEndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIExtendScrollRect-OnEndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIFoldoutComponent-Refresh0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-NotifyCellSizeChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIFoldoutComponent-OnFoldOut0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIFoldoutComponent-OnFoldIn0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIFoldoutComponent-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGraphicAnimation-_Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGraphicAnimation-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGraphicAnimation-OnRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGraphicAnimation-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-_InitIfNot0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-_SetCircleWrapScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayoutInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-_FindValidSelectable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-_NaviChildren0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayoutImpl0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayout0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-RectWrapNavigate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-WrapNavigation0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-_InitWrapNavigation0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGridLayoutNaviWrapper-TryWrapNavigate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGyroscopeEffect-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGyroscopeEffect-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIGyroscopeEffect-OnRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIHighlightMask-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIHighlightMask-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIHighlightMask-TrySyncRect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIHighlightMask-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIHighlightMask-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-RegisterOnEnableRuntimeAtlas0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-UnregisterOnEnableRuntimeAtlas0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-OnEnableRuntimeAtlas0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-get_enableRuntimeAtlas0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-UIAtlasHandle-CreateInvalidHandle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_ReProcessInsertForUIImage0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-ReProcessInsertForUIImage0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-_OnSpriteChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-OnPopulateMesh0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_AddUIImageToManagerOnInstantiate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-AddUIImageToManagerOnInstantiate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_AddUIImageToManager0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-AddUIImageToManager0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_RemoveUIImageFromManager0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-RemoveUIImageFromManager0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-SetNativeSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-SetNativeSizeIgnoreRefScale0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-LoadSprite1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-LoadMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-ReleaseSprite0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-get_mainTexture0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImage-_V2AtlasInitialize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImageBlur-OnChangeSprite0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImageBlur-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImageBlur-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImageBlur-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImageBlur-OnRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImageFillAmountOffset-set_fillAmount0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImageFillAmountOffset-DOFillAmount0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImageFillFollower-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImageFillFollower-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImageFillFollower-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImageFillFollower-RefreshFillAmount0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImageFillTailFollower-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImageFillTailFollower-RefreshFollower0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImageFillTailFollower-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImageFillTailFollower-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImagePair-LoadSprite0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImagePair-LoadSprite1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImagePair-set_color0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIImagePair-get_first0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_PlayAudioGear0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_PlayAudioGearLock0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-ScrollEffectConfig-IsEmpty0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_InitIfNot0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-DragContext-BeginDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_ScrollValueAlignToPage0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_ScrollValue2PageIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_PageIndex2ScrollValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_SwitchToPage0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-DragContext-_TryFlingToNext0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-DragContext-EndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-BlockerManager-StartInertia0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-InertiaBlocker-IsDirMatch0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-BlockerManager-HitInertiaBlock0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_AutoAlign0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-NotifyScrolling0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-NotifyAlignFinish0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-_OnStateChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-BlockerManager-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-SetPageCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-MoveToPage0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-CustomScrollHandler-_OnScrollBegin0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-CustomScrollHandler-_OnScrollEnd0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-CustomScrollHandler-OnClear0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_velocity0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_scrollProgress0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-CustomScrollHandler-set_scrollProgress0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-CustomScrollHandler-StopMoving0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-StopMoving0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-OnClear0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-MarkHasScrolled0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-get_isControllerInputValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-SendOnFocus0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-SendOnFocusLost0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_VirtualKeyboardAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_VirtualKeyboardSelect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-OnSelect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_VirtualKeyboardDeselect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-OnDeselect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-set_s_focusedInputField0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-ActivateInputField0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-DeactivateInputField0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_VirtualKeyboardOnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_UpdateBindingEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_NotifyIsHover0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-OnInteractableChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_GetCamera0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_UpdateKeyboardOffset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIInputField-_KeyboardHeightChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_UpdateWalkBgScale0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-set_walkRation0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-get_m_thumbPosMaxLength0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_UpdateState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-InitBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_SetRectTransform0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_SetVisible0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_UpdateGait0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_UpdateIndicator0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_SetWalkBgVisible0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_SetRunBgVisible0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_UpdateBg0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_Activate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-OnPointerDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-OnBeginDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-OnPointerUp0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-OnDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_ChangeDynamic0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_OnHudLayoutLoaded0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-_Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIJoystick-CheckShouldActive0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-GraphicUpdateComplete0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-LayoutComplete0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-_InvokePostLayoutCallback0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-_NextFrameCoroutine0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-Rebuild0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-DoOnceOnPostLayout0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-_SetDirty0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-OnRectTransformDimensionsChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILayoutDimensionListener-UnityEngine.UI.ICanvasElement.get_transform0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILeftSubtitle-UpdateByPlayTime0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILeftSubtitle-SetVisible0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILeftSubtitle-Exit0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILeftSubtitle-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILeftSubtitle-StartAutoPlay0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILeftSubtitle-SetLeftSubTitle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIMaterialAnimation-_TryUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIMaterialAnimation-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIMaterialAnimation-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIMaterialAnimation-OnRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIMaterialAnimation-ForceUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_GetLineCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-CalcSomeCountNum0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SyncViewSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-InitBasicInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-InitBasicInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-CalcSomeCountNum0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetLeftLength0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-InitConfig0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-get_currentStep0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_StartGraduallyShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-StopGraduallyShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SkipGraduallyShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetTargetPosByIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-TryClearAdjustTween0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_ScrollToPos0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-ScrollTo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-RestartGraduallyShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-ClearLastFocusNaviTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_ClearRelatedNaviGroup0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-UpdateCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-UpdateCount1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-UpdateCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-UpdateCount1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-UpdateCount2;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-get_curSelectedIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-set_curSelectedIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-Get0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetCell1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-ScrollToIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetSelectedIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetNaviOffset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetNaviNewIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-NavigateSelected0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_InitNavigation0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-TryRecalculateSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-OnScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetGridLayoutSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-_GetCellSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetContainerSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetCenterIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetShowRange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetNotCacheRange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-_GetCellsSizeTo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-MoveCellTo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISizeFollower-get_rectTransform0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISizeFollower-SyncSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-OnUpdateCell0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetTargetPosByIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-ScrollTo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-get_currentStep0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-SetStepTo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-SetCurrentStep0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetScrollBarSize0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetLastScrollStep0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-UpdateLastScrollStep0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-GetNormalizedPosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-SetNormalizedPosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-ToggleByState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-Toggle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollList-FoldAll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollRect-_UpdateNonUnifiedScrollbars0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollRect-_OnPostLayout0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollRect-_InitIfNot0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollRect-UpdateScrollbars0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollRect-Rebuild0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollRect-SetHorizontalNormalizedPosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINonUnifiedScrollRect-SetVerticalNormalizedPosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINumberScrollTween-get_text0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINumberScrollTween-set_text0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINumberScrollTween-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINumberScrollTween-_HandleNumberScrollTween0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINumberScrollTween-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINumberScrollTween-_CleanupBeforeTween0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UINumberScrollTween-_TweenToTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIPCScaleHelper-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRegionBuildingTexManager-_UpdateTexture0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRegionBuildingTexManager-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRegionBuildingTexManager-OnValidate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIRegionBuildingTexManager-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScaleHolder-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScaleHolder-_IsValidScale0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScaleHolder-_HoldScale0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScaleHolder-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScaleHolder-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScaleHolder-SetExtraScale0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScaleHolder-GetExtraScale0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollbar-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollbarKeyHint-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-get_controllerStickScrollEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollbarKeyHint-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-get_viewRect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnInitializePotentialDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-IsActive0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnBeginDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnEndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_GetDeltaAngle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_CheckCanMove0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_UpdateSpeed0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_GetRealIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_UpdateShowingCells0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_UpdateCenterIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_TryUpdateCells0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_UpdateAuto0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_InitCells0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_OnAwakeInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_UpdateScrollRange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-_DoScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-Rebuild0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-LayoutComplete0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-GraphicUpdateComplete0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-IsDestroyed0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-ScrollToIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-UpdateCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-Get0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-UnityEngine.UI.ICanvasElement.get_transform0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollCircle-Cell-SetSelect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollContainerFollower-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollContainerFollower-_RefreshSizeAndPositionToTargetContainer0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollContainerFollower-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_SetAutoScrollSpd0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_OnEnterAutoScrollUp0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_OnExitAutoScrollUp0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_OnEnterAutoScrollDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_OnExitAutoScrollDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_InitAutoScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-ListWrapNavigate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_InitControllerNavi0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_InGameAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_EditorAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_UpdateGraduallyShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetStepTo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_UpdateAutoScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetTop0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-UpdateCount2;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-UpdateShowingCells1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetRangeInView0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetCellCanCache0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-CacheShowingCell0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-OnRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetPaddingBottom0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetPaddingTop0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetPaddingRight0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetPaddingLeft0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetPadding0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetShowingCellsIndexRange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-SetSpace0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetCenterIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetIndexOf0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-ScreenPos2Index0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-GetMousePosIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollList-_GetScreenPosLineColumnInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-_CheckOverScrollEffect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-ScrollToNaviTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-_InitController0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-_TickRefreshControllerStickScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-get_moveTips0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-_UpdateMoveTips0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-Update0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-IsCellViewed0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-_CustomSetPosOnScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-UpdateScrollEnableNode0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-OnBeginDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-OnDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-_CheckOverScrollOnEndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-OnEndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRect-LateUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-ResetReferences0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-_UpdateRedDotGameObjects0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-RegisterRedDotStatesForScrollList0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-_OnScrollListUpdateCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-OnRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-_UpdateCacheDictForRangeChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_state0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_newPos0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_normalPos0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_newRect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_normalRect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-IsRedDotInDir0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-_CalculateRedDotStateInDir0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-UpdateRedDotStateInDir0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-ResetRedDotPosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-RegisterRedDot0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollRectEdgeRedDot-UnregisterRedDot0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-_InitIfNot0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-_ApplyTextAlignment0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-_ResetTextScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-_ResetTextScrollInternal0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-ResetTextScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-_UpdateScrollState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-_ApplyTextScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-CanvasGroupHandler-HandleAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-PositionScrollHandler-ApplyScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-PositionScrollHandler-ResetScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-PositionScrollHandler-UpdateScrollStatus0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-MeshScrollHandler-_UpdateMeshClipping0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-MeshScrollHandler-_ApplyScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-MeshScrollHandler-ApplyScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-MeshScrollHandler-ResetScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIScrollText-MeshScrollHandler-UpdateScrollStatus0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_RefreshFocusBindings0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_InitFocusBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_RefreshRelatedBindingGroupsState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_RefreshFocusActionKeyHint0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_RefreshStopFocusActionKeyHint0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_OnIsTopLayerChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_OnSelectableNaviGroupDisabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_BeforeSelectableNaviGroupDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_OnSetLayerSelectedTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_OnRemoveFromLayerStack0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-_TryChangeNaviPartner0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnUp0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnLeft0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnRight0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-RefreshFocusBindings0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-SetFocusBindingText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISelectableNaviGroup-ManuallyRefreshRelatedBindingGroups0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-get_controllerStickScrollEnabled0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-_InitializeCells0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-UpdateLayout0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-_ApplyDamping0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-OnEndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-OnDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-_TickRefreshControllerStickScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-RefreshLayout0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollList-OnBeginDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollListPair-_OnCellShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollListPair-_OnClosestCellChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollListPair-_OnDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollListPair-_OnEndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollListPair-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISemiCircleScrollListPair-RefreshLayout0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISequenceImage-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISequenceImage-SetSprite0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISequenceImage-Play0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISequenceImage-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISequenceImage-Stop0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISequenceImage-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISequenceImage-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISimpleActiveAnimationHelper-Skip0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISimpleActiveAnimationHelper-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISimpleActiveAnimationHelper-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISimpleActiveAnimationHelper-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISimpleStateController-SetState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISimpleStateController-StateInfo-ToString0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISizeFollower-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-_TryPostSlideAudioEvent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-ClampValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-CustomProcessNormalizedValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-OnValueChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-OnClickSliderBar0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-OnClickSliderHandle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-_NotifyIsHover0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-OnBeginDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-OnEndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-_ApplyStickScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-_StickScrollHoriValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-_InitStickScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-_AddValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-_ReduceValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-_InitBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-get_bindingViewState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-GetBindingViewActionId0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-Beyond.Input.IBindingView.OnInputKeyDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-Beyond.Input.IBindingView.OnInputKeyUp0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISlider-Beyond.Input.IBindingView.get_interactable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-GetTextSoftMaskMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-GetUIVFXSoftMaskMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-GetCornerCanvas0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-GetFourCornnerArrayWorld0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-get_graphic0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-MarkGraphicVerticesDirty0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-MarkGraphicMaterialDirty0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-_UpdateChildren0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-_UpdateParam0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-_OnEnableRuntimeAtlas0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-_DestroyMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-_Clear0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMask-TailLateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-get_softMask0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-get_uiText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-GetModifiedMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-ModifyMesh0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-_Equal0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-_ComputeLineCross0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-_ComputePointAtTriangleUV0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-_SetUIVertexUV0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-_ClipTriangleByClampSoftMaskUV0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-_ClipRect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISoftMaskable-ModifyMesh1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISortingOrder-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISortingOrder-_GetRenderer0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISortingOrder-_GetChildrenRenderers0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISortingOrder-_GetCanvas0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISortingOrder-SetOrder0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISortingOrder-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISortingOrder-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-_GetClampedIndex0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-_TryAutoScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-_OnScrollEnd0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-_OnScrollStart0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-InitConfig0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-OnScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-OnBeginDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-OnEndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-SetTop0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-UpdateShowingCells0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStepScrollList-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStyleByState-_IsValidStyle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStyleByState-UpdateStyle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStyleByState-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIStyleByState-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISubtitle-_SetAsDefault0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISubtitle-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISubtitle-SetSubtitle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISubtitle-UpdateAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITextPair-get_text0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITextPair-set_text0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITextPair-set_color0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITextPair-get_first0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITextPair-SetAndResolveTextStyle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITextPair-SetPhoneticText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_OnToggleFail0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-TryInternalToggle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_TryRefreshBindingText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_TryRefreshToggleBindingText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_TryRefreshHoverConfirmBindingText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_InitActionOnSetNaviTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_InitToggleBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_UpdateObjects0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_PlayAnimation0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_UpdateBindingEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-PlayAudio0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-InternalToggle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnValueChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_NotifyIsHover0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnInteractableChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-GetMouseActionHints0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnPointerDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnPointerClick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnSubmit0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-OnNaviTargetEnabledAgain0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_ToggleNaviInputBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggle-_OnSetAsNaviTarget0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggleGroup-_MoveTo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggleGroup-MoveToNext0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggleGroup-MoveToPrevious0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggleGroup-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggleGroup-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggleGroup-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIToggleGroup-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-_IsSameTouchFromPress0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnBeginDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-DoEndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnEndDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnDrag0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-_OnActionPress0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnPointerDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-_OnActionRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnPointerUp0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnPointerClick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnPointerEnter0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnPointerExit0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-ClearTouchInfo0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnScroll0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-SimulateClick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-DeActiveTouch0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-_UpdateState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-InitBinding0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnAwake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-ClearComponent0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UITouchPanel-OnRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-get_graphic0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-get_softMaskable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-_UpdateParam0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-_OnEnableRuntimeAtlas0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-_DestroyMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-_Clear0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIVFXManager-GetModifiedMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIWorldLevelScrollListAnimCtrl-ScrollListLayoutInfo-get_cellHeight0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateUpPos0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateDownPos0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateMidPos0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIWorldLevelScrollListAnimCtrl-_ScrollLayouts0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateWorldLevelScrollList0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIWorldLevelScrollListAnimCtrl-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-VirtualMouseInitPos-get_panel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-VirtualMouseInitPos-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CSPopupPanel-_OnConfirm0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CSPopupPanel-_OnCancel0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CSPopupPanel-Awake0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CSPopupPanel-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-CSPopupPanel-Show0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-MobileMotionManager-_CheckMotionLevelAndPostIfChange0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-MobileMotionManager-OnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-MobileMotionManager-OnRelease0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-MobileMotionManager-PostEventCommonShort0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-MobileMotionManager-PostEventCommonOperateSuccess0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-MobileMotionManager-PostEventCommonOperateFailure0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-DynamicFontAssetLoader-AddNotFoundUnicode0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-DynamicFontAssetLoader-FontAssetRef-GetFontAsset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-DynamicFontAssetLoader-TryGetFontAsset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-DynamicFontAssetLoader-FontAssetRef-RemoveRefText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-DynamicFontAssetLoader-TryRemoveRefText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-DynamicFontAssetLoader-FontAssetRef-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-DynamicFontAssetLoader-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-TweenUtils-TickAsCountDown0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-TweenUtils-FLerpByTime-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-TweenUtils-FLerpByTime-GetValue0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationLayerMixPlayer-LockToClip0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationLayerMixPlayer-CreateGraph0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationLayerMixPlayer-CreateMixer0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationLayerMixPlayer-CreateOutput0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationLayerMixPlayer-CreateSourceFromAsset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationMixPlayer-LockToClip0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationMixPlayer-CreateGraph0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationMixPlayer-CreateMixer0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationMixPlayer-CreateOutput0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAnimationMixPlayer-CreateSourceFromAsset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILoadImageSprite-_LoadSprite0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILoadImageSprite-set_spritePath0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILoadImageSprite-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UILoadImageSpriteByName-set_spriteName0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-BeforeShowEffect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-BeforeHideEffect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-AfterShowEffect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-AfterHideEffect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-ResetToState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-TweenContext-OnReset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-TweenContext-OnTweenStop0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-ClearTween0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-_ClearTweenInternal0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-Show0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-Hide0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-WaitForTweening0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-SetOptions0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-Reset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-Clear0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-GetContext0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-TweenContext-IsInterapted0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-TweenWrapper-IsActive0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-TweenWrapper-IsPlaying0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-TweenWrapper-KillIfNecessary0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-TweenWrapper-OnComplete0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UISwitchTween-TweenWrapper-SetAutoKill0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-set_activeAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-Durations-GetHideDuration0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-GenerateTweenOfHide0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-Durations-GetShowDuration0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-GenerateTweenOfShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-SetObjectActive0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-BeforeShowEffect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-AfterHideEffect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-ResetToState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-Release0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeSwitchTween-Builder-Build0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-_GetTargetAlpha0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-_GetTargetPos0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-GenerateTweenOfHide0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-GenerateTweenOfShow0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-BeforeShowEffect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-AfterHideEffect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-ResetToState0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-TweenHandler-IsPlaying0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-TweenHandler-KillIfNecessary0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-TweenHandler-OnComplete0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-FadeTranslationSwitchTween-TweenHandler-SetAutoKill0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-UIAtlasPage-FreeRect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_ProcessRemoveQueue0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_IsRuntimeAtlasCompatible0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-UIAtlasPage-InsertRect0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-UIAtlasPage-CopyIntoAtlas0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_ProcessInsertQueue0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-LateTick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_CreateTickFunction0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-OnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-_ClearTickFunction0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-OnUnInit0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-Release0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-GetAtlasCount0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-UIAtlasHandle-IsValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-UIAtlasPage-InsertRects0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIAtlasManager-UIAtlasPage-FreeRects0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-WebApplication-Start0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateControllerUtils-GetName0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-get_ReadableDescription0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-ToString0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-_OnGridLayoutGroupChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-_OnImageChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-_OnLayoutElementChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-_OnLayoutGroupChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-_OnRectTransformChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-_OnScrollListChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateDescription-_OnTextChanged0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateController-Run0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateController-Stop0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-StateReference-HandleScheduledStates0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateController-_HandleStateAnimations0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-UIState-UIStateController-Tick0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUPrefabData-CreateFontNode0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUPrefabDataLite-CreateFontNode0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUIHandle-Equals0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUIHandle-Equals1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUIHandle-GetHashCode0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUIHandle-op_Equality0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUIHandle-op_Inequality0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-GetFontAsset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-get_fontAsset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-set_fontAsset0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_GetOneHandle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-Create0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-Add0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_CreateInstance0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_IsHandleInvalid0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-SetPosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-MarkNeedUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-SetRootPosition0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-CreateInstance0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-Remove0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-Recycle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_RecycleOneHandle0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_DestroyInstance0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-DestroyInstance0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-IsInstanceValid0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-SetRootScale0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-SetRootScale0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-StartAnimation0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-StartAnimation0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-StartAnimation1;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-SetVisibility0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUIUtils-ColorToRGBAUint320;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-SetColor0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-SetColor0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-SetText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-SetText0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-Dispose0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_CleanMaterials0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_DoOnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-OnDestroy0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_DestroyAnimatedInstance0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-_FillInstanceQueue0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-_AllocBuffer0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-DoUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-DoUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-get_gpuGroups0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_UpdateWorldMat0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_RenderNodes0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_DoLateUpdate0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_PreWillRenderCanvases0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_InitMaterials0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_PreloadTextInGroupData0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-InstanceBufferManager-BindInstanceList0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_LoadPrefabNodeBuffer0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_LoadPrefabData0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_LoadGroupData0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_RefreshMaterials0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-_Init0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-OnEnable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-OnDisable0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-OnPopulateMesh0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUISystem-UpdateMaterial0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-GPUIUtils-CreateQuadMesh0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-RuntimeInstance-SetVisibility0;        // 0x0
        public static IFix.IDMAP0 Beyond-UI-GPUI-CodePoint-ConvertToUTF320;        // 0x0

    }

}

