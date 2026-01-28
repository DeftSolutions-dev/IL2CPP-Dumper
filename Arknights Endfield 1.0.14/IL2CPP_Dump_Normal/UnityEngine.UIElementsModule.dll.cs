// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UIElementsModule.dll
// Classes:  869
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000009
    public class TextureInfo : LinkedPoolItem`1
    {
        // Fields
        public UnityEngine.UIElements.DynamicAtlasPage page;        // 0x18
        public System.Int32 counter;        // 0x20
        public UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc;        // 0x28
        public UnityEngine.RectInt rect;        // 0x58
        public static readonly UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.DynamicAtlas.TextureInfo> pool;        // 0x0

        // Methods
        private UnityEngine.UIElements.DynamicAtlas.TextureInfo Create() { }
        private System.Void Reset(UnityEngine.UIElements.DynamicAtlas.TextureInfo info) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200000B
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000C
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_PropertyPath;        // 0x70

        // Methods
        private System.Void .ctor() { }
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }

    }

    // TypeToken: 0x200000E
    public struct DragDirection
    {
        // Fields
        public System.Int32 value__;        // 0x0
        public static UnityEngine.UIElements.ClampedDragger.DragDirection<T> None;        // 0x0
        public static UnityEngine.UIElements.ClampedDragger.DragDirection<T> LowToHigh;        // 0x0
        public static UnityEngine.UIElements.ClampedDragger.DragDirection<T> HighToLow;        // 0x0
        public static UnityEngine.UIElements.ClampedDragger.DragDirection<T> Free;        // 0x0

    }

    // TypeToken: 0x2000011
    public class ButtonClickStatus
    {
        // Fields
        public UnityEngine.UIElements.VisualElement m_Target;        // 0x10
        public UnityEngine.Vector3 m_PointerDownPosition;        // 0x18
        public System.Int64 m_LastPointerDownTime;        // 0x28
        public System.Int32 m_ClickCount;        // 0x30

        // Methods
        private System.Void Reset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001B
    public struct UpdateMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.DefaultEventSystem.UpdateMode Always;        // 0x0
        public static UnityEngine.UIElements.DefaultEventSystem.UpdateMode IgnoreIfAppNotFocused;        // 0x0

    }

    // TypeToken: 0x200001C
    public interface IInput
    {
        // Methods
        private System.Boolean GetButtonDown(System.String button) { }
        private System.Single GetAxisRaw(System.String axis) { }
        private System.Int32 get_touchCount() { }
        private UnityEngine.Touch GetTouch(System.Int32 index) { }
        private System.Boolean get_mousePresent() { }

    }

    // TypeToken: 0x200001D
    public class Input, IInput
    {
        // Methods
        private System.Boolean GetButtonDown(System.String button) { }
        private System.Single GetAxisRaw(System.String axis) { }
        private System.Int32 get_touchCount() { }
        private UnityEngine.Touch GetTouch(System.Int32 index) { }
        private System.Boolean get_mousePresent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001E
    public class NoInput, IInput
    {
        // Methods
        private System.Boolean GetButtonDown(System.String button) { }
        private System.Single GetAxisRaw(System.String axis) { }
        private System.Int32 get_touchCount() { }
        private UnityEngine.Touch GetTouch(System.Int32 index) { }
        private System.Boolean get_mousePresent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000025
    public struct Status
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.DropdownMenuAction.Status None;        // 0x0
        public static UnityEngine.UIElements.DropdownMenuAction.Status Normal;        // 0x0
        public static UnityEngine.UIElements.DropdownMenuAction.Status Disabled;        // 0x0
        public static UnityEngine.UIElements.DropdownMenuAction.Status Checked;        // 0x0
        public static UnityEngine.UIElements.DropdownMenuAction.Status Hidden;        // 0x0

    }

    // TypeToken: 0x200002C
    public struct EventRecord
    {
        // Fields
        public UnityEngine.UIElements.EventBase m_Event;        // 0x10
        public UnityEngine.UIElements.IPanel m_Panel;        // 0x18

    }

    // TypeToken: 0x200002D
    public struct DispatchContext
    {
        // Fields
        public System.UInt32 m_GateCount;        // 0x10
        public System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord> m_Queue;        // 0x18

    }

    // TypeToken: 0x2000032
    public struct FocusedElement
    {
        // Fields
        public UnityEngine.UIElements.VisualElement m_SubTreeRoot;        // 0x10
        public UnityEngine.UIElements.Focusable m_FocusedElement;        // 0x18

    }

    // TypeToken: 0x200003A
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003B
    public class UxmlTraits : UxmlTraits
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003C
    public struct GUIGlobals
    {
        // Fields
        public UnityEngine.Matrix4x4 matrix;        // 0x10
        public UnityEngine.Color color;        // 0x50
        public UnityEngine.Color contentColor;        // 0x60
        public UnityEngine.Color backgroundColor;        // 0x70
        public System.Boolean enabled;        // 0x80
        public System.Boolean changed;        // 0x81
        public System.Int32 displayIndex;        // 0x84

    }

    // TypeToken: 0x2000078
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000079
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        protected UnityEngine.UIElements.UxmlStringAttributeDescription m_Name;        // 0x18
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_ViewDataKey;        // 0x20
        protected UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.PickingMode> m_PickingMode;        // 0x28
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Tooltip;        // 0x30
        private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.UsageHints> m_UsageHints;        // 0x38
        private UnityEngine.UIElements.UxmlIntAttributeDescription <focusIndex>k__BackingField;        // 0x40
        private UnityEngine.UIElements.UxmlIntAttributeDescription m_TabIndex;        // 0x48
        private UnityEngine.UIElements.UxmlBoolAttributeDescription <focusable>k__BackingField;        // 0x50
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Class;        // 0x58
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_ContentContainer;        // 0x60
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Style;        // 0x68

        // Methods
        private UnityEngine.UIElements.UxmlIntAttributeDescription get_focusIndex() { }
        private UnityEngine.UIElements.UxmlBoolAttributeDescription get_focusable() { }
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007A
    public struct MeasureMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.VisualElement.MeasureMode Undefined;        // 0x0
        public static UnityEngine.UIElements.VisualElement.MeasureMode Exactly;        // 0x0
        public static UnityEngine.UIElements.VisualElement.MeasureMode AtMost;        // 0x0

    }

    // TypeToken: 0x200007B
    public struct RenderTargetMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.VisualElement.RenderTargetMode None;        // 0x0
        public static UnityEngine.UIElements.VisualElement.RenderTargetMode NoColorConversion;        // 0x0
        public static UnityEngine.UIElements.VisualElement.RenderTargetMode LinearToGamma;        // 0x0
        public static UnityEngine.UIElements.VisualElement.RenderTargetMode GammaToLinear;        // 0x0

    }

    // TypeToken: 0x200007C
    public struct Hierarchy
    {
        // Fields
        private static System.String k_InvalidHierarchyChangeMsg;        // 0x0
        private readonly UnityEngine.UIElements.VisualElement m_Owner;        // 0x10

        // Methods
        private UnityEngine.UIElements.VisualElement get_parent() { }
        private System.Void .ctor(UnityEngine.UIElements.VisualElement element) { }
        private System.Void Add(UnityEngine.UIElements.VisualElement child) { }
        private System.Void Insert(System.Int32 index, UnityEngine.UIElements.VisualElement child) { }
        private System.Void Remove(UnityEngine.UIElements.VisualElement child) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Void Clear() { }
        private System.Void BringToFront(UnityEngine.UIElements.VisualElement child) { }
        private System.Void SendToBack(UnityEngine.UIElements.VisualElement child) { }
        private System.Void PlaceBehind(UnityEngine.UIElements.VisualElement child, UnityEngine.UIElements.VisualElement over) { }
        private System.Void MoveChildElement(UnityEngine.UIElements.VisualElement child, System.Int32 currentIndex, System.Int32 nextIndex) { }
        private System.Int32 get_childCount() { }
        private UnityEngine.UIElements.VisualElement get_Item(System.Int32 key) { }
        private System.Int32 IndexOf(UnityEngine.UIElements.VisualElement element) { }
        private UnityEngine.UIElements.VisualElement ElementAt(System.Int32 index) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children() { }
        private System.Void SetParent(UnityEngine.UIElements.VisualElement value) { }
        private System.Void PutChildAtIndex(UnityEngine.UIElements.VisualElement child, System.Int32 index) { }
        private System.Void RemoveChildAtIndex(System.Int32 index) { }
        private System.Void ReleaseChildList() { }
        private System.Boolean Equals(UnityEngine.UIElements.VisualElement.Hierarchy other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.UIElements.VisualElement.Hierarchy x, UnityEngine.UIElements.VisualElement.Hierarchy y) { }

    }

    // TypeToken: 0x200007D
    public class BaseVisualElementScheduledItem : ScheduledItem, IVisualElementScheduledItem, IVisualElementPanelActivatable
    {
        // Fields
        private UnityEngine.UIElements.VisualElement <element>k__BackingField;        // 0x38
        public System.Boolean isScheduled;        // 0x40
        private UnityEngine.UIElements.VisualElementPanelActivator m_Activator;        // 0x48

        // Methods
        private UnityEngine.UIElements.VisualElement get_element() { }
        private System.Void set_element(UnityEngine.UIElements.VisualElement value) { }
        private System.Boolean get_isActive() { }
        private System.Void .ctor(UnityEngine.UIElements.VisualElement handler) { }
        private UnityEngine.UIElements.IVisualElementScheduledItem StartingIn(System.Int64 delayMs) { }
        private UnityEngine.UIElements.IVisualElementScheduledItem Every(System.Int64 intervalMs) { }
        private System.Void OnItemUnscheduled() { }
        private System.Void Resume() { }
        private System.Void Pause() { }
        private System.Void ExecuteLater(System.Int64 delayMs) { }
        private System.Void OnPanelActivate() { }
        private System.Void OnPanelDeactivate() { }
        private System.Boolean CanBeActivated() { }

    }

    // TypeToken: 0x200007E
    public class VisualElementScheduledItem`1 : BaseVisualElementScheduledItem
    {
        // Fields
        public ActionType updateEvent;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.VisualElement handler, ActionType upEvent) { }

    }

    // TypeToken: 0x200007F
    public class TimerStateScheduledItem : VisualElementScheduledItem`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.UIElements.VisualElement handler, System.Action<UnityEngine.UIElements.TimerState> updateEvent) { }
        private System.Void PerformTimerUpdate(UnityEngine.UIElements.TimerState state) { }

    }

    // TypeToken: 0x2000080
    public class SimpleScheduledItem : VisualElementScheduledItem`1
    {
        // Methods
        private System.Void .ctor(UnityEngine.UIElements.VisualElement handler, System.Action updateEvent) { }
        private System.Void PerformTimerUpdate(UnityEngine.UIElements.TimerState state) { }

    }

    // TypeToken: 0x2000081
    public class CustomStyleAccess, ICustomStyle
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_CustomProperties;        // 0x10
        private System.Single m_DpiScaling;        // 0x18

        // Methods
        private System.Void SetContext(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue> customProperties, System.Single dpiScaling) { }
        private System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Single> property, System.Single& value) { }
        private System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Int32> property, System.Int32& value) { }
        private System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> property, UnityEngine.Color& value) { }
        private System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> property, UnityEngine.Texture2D& value) { }
        private System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> property, UnityEngine.Sprite& value) { }
        private System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> property, UnityEngine.UIElements.VectorImage& value) { }
        private System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.String> property, System.String& value) { }
        private System.Boolean TryGetValue(System.String propertyName, UnityEngine.UIElements.StyleValueType valueType, UnityEngine.UIElements.StyleSheets.StylePropertyValue& customProp) { }
        private System.Void LogCustomPropertyWarning(System.String propertyName, UnityEngine.UIElements.StyleValueType valueType, UnityEngine.UIElements.StyleSheets.StylePropertyValue customProp) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000082
    public class TypeData
    {
        // Fields
        private readonly System.Type <type>k__BackingField;        // 0x10
        private System.String m_FullTypeName;        // 0x18
        private System.String m_TypeName;        // 0x20

        // Methods
        private System.Type get_type() { }
        private System.Void .ctor(System.Type type) { }
        private System.String get_fullTypeName() { }
        private System.String get_typeName() { }

    }

    // TypeToken: 0x2000086
    public struct TransitionState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionState None;        // 0x0
        public static UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionState Running;        // 0x0
        public static UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionState Started;        // 0x0
        public static UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionState Ended;        // 0x0
        public static UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionState Canceled;        // 0x0

    }

    // TypeToken: 0x2000087
    public struct AnimationDataSet`2
    {
        // Fields
        public UnityEngine.UIElements.VisualElement[] elements;        // 0x0
        public UnityEngine.UIElements.StyleSheets.StylePropertyId[] properties;        // 0x0
        public TTimingData[] timing;        // 0x0
        public TStyleData[] style;        // 0x0
        public System.Int32 count;        // 0x0
        private System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair,System.Int32> indices;        // 0x0

        // Methods
        private System.Int32 get_capacity() { }
        private System.Void set_capacity(System.Int32 value) { }
        private System.Void LocalInit() { }
        private UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<TTimingData,TStyleData> Create() { }
        private System.Boolean IndexOf(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, System.Int32& index) { }
        private System.Void Add(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, TTimingData timingData, TStyleData styleData) { }
        private System.Void Remove(System.Int32 cancelledIndex) { }
        private System.Void Replace(System.Int32 index, TTimingData timingData, TStyleData styleData) { }
        private System.Void RemoveAll(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void RemoveAll() { }
        private System.Void GetActivePropertiesForElement(UnityEngine.UIElements.VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outProperties) { }

    }

    // TypeToken: 0x2000089
    public class EqualityComparer, IEqualityComparer`1
    {
        // Methods
        private System.Boolean Equals(UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair x, UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair y) { }
        private System.Int32 GetHashCode(UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair obj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000088
    public struct ElementPropertyPair
    {
        // Fields
        public static readonly System.Collections.Generic.IEqualityComparer<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair> Comparer;        // 0x0
        public readonly UnityEngine.UIElements.VisualElement element;        // 0x10
        public readonly UnityEngine.UIElements.StyleSheets.StylePropertyId property;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId property) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200008A
    public class Values
    {
        // Methods
        private System.Void CancelAllAnimations() { }
        private System.Void CancelAllAnimations(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void CancelAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Void UpdateAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Void GetAllAnimations(UnityEngine.UIElements.VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds) { }
        private System.Void Update(System.Int64 currentTimeMs) { }
        private System.Void UpdateValues() { }
        private System.Void UpdateComputedStyle() { }
        private System.Void UpdateComputedStyle(System.Int32 i) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008C
    public class TransitionEventsFrameState
    {
        // Fields
        private static readonly UnityEngine.Pool.ObjectPool<System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase>> k_EventQueuePool;        // 0x0
        public readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair,UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionState> elementPropertyStateDelta;        // 0x0
        public readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair,System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase>> elementPropertyQueuedEvents;        // 0x0
        public UnityEngine.UIElements.IPanel panel;        // 0x0
        private System.Int32 m_ChangesCount;        // 0x0

        // Methods
        private System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase> GetPooledQueue() { }
        private System.Void RegisterChange() { }
        private System.Void UnregisterChange() { }
        private System.Boolean StateChanged() { }
        private System.Void Clear() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200008E
    public struct TimingData
    {
        // Fields
        public System.Int64 startTimeMs;        // 0x0
        public System.Int32 durationMs;        // 0x0
        public System.Func<System.Single,System.Single> easingCurve;        // 0x0
        public System.Single easedProgress;        // 0x0
        public System.Single reversingShorteningFactor;        // 0x0
        public System.Boolean isStarted;        // 0x0
        public System.Int32 delayMs;        // 0x0

    }

    // TypeToken: 0x200008F
    public struct StyleData
    {
        // Fields
        public T startValue;        // 0x0
        public T endValue;        // 0x0
        public T reversingAdjustedStartValue;        // 0x0
        public T currentValue;        // 0x0

    }

    // TypeToken: 0x2000090
    public struct EmptyData
    {
        // Fields
        public static UnityEngine.UIElements.StylePropertyAnimationSystem.Values.EmptyData<T> Default;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200008B
    public class Values`1 : Values
    {
        // Fields
        private System.Int64 m_CurrentTimeMs;        // 0x0
        private UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TransitionEventsFrameState<T> m_CurrentFrameEventsState;        // 0x0
        private UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TransitionEventsFrameState<T> m_NextFrameEventsState;        // 0x0
        public UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TimingData<T>,UnityEngine.UIElements.StylePropertyAnimationSystem.Values.StyleData<T>> running;        // 0x0
        public UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<UnityEngine.UIElements.StylePropertyAnimationSystem.Values.EmptyData<T>,T> completed;        // 0x0

        // Methods
        private System.Boolean get_isEmpty() { }
        private System.Func<T,T,System.Boolean> get_SameFunc() { }
        private System.Boolean ConvertUnits(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, T& a, T& b) { }
        private System.Void .ctor() { }
        private System.Void SwapFrameStates() { }
        private System.Void QueueEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair epp) { }
        private System.Void ClearEventQueue(UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair epp) { }
        private System.Void QueueTransitionRunEvent(UnityEngine.UIElements.VisualElement ve, System.Int32 runningIndex) { }
        private System.Void QueueTransitionStartEvent(UnityEngine.UIElements.VisualElement ve, System.Int32 runningIndex) { }
        private System.Void QueueTransitionEndEvent(UnityEngine.UIElements.VisualElement ve, System.Int32 runningIndex) { }
        private System.Void QueueTransitionCancelEvent(UnityEngine.UIElements.VisualElement ve, System.Int32 runningIndex, System.Int64 panelElapsedMs) { }
        private System.Void SendTransitionCancelEvent(UnityEngine.UIElements.VisualElement ve, System.Int32 runningIndex, System.Int64 panelElapsedMs) { }
        private System.Void CancelAllAnimations() { }
        private System.Void CancelAllAnimations(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void CancelAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Void UpdateAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Void GetAllAnimations(UnityEngine.UIElements.VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds) { }
        private System.Single ComputeReversingShorteningFactor(System.Int32 oldIndex) { }
        private System.Int32 ComputeReversingDuration(System.Int32 newTransitionDurationMs, System.Single newReversingShorteningFactor) { }
        private System.Int32 ComputeReversingDelay(System.Int32 delayMs, System.Single newReversingShorteningFactor) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, T startValue, T endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve, System.Int64 currentTimeMs) { }
        private System.Void ForceComputedStyleEndValue(System.Int32 runningIndex) { }
        private System.Void Update(System.Int64 currentTimeMs) { }
        private System.Void ProcessEventQueue() { }
        private System.Void UpdateProgress(System.Int64 currentTimeMs) { }

    }

    // TypeToken: 0x2000091
    public class ValuesFloat : Values`1
    {
        // Fields
        private readonly System.Func<System.Single,System.Single,System.Boolean> <SameFunc>k__BackingField;        // 0x88

        // Methods
        private System.Func<System.Single,System.Single,System.Boolean> get_SameFunc() { }
        private System.Boolean IsSame(System.Single a, System.Single b) { }
        private System.Single Lerp(System.Single a, System.Single b, System.Single t) { }
        private System.Void UpdateValues() { }
        private System.Void UpdateComputedStyle() { }
        private System.Void UpdateComputedStyle(System.Int32 i) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000092
    public class ValuesInt : Values`1
    {
        // Fields
        private readonly System.Func<System.Int32,System.Int32,System.Boolean> <SameFunc>k__BackingField;        // 0x88

        // Methods
        private System.Func<System.Int32,System.Int32,System.Boolean> get_SameFunc() { }
        private System.Boolean IsSame(System.Int32 a, System.Int32 b) { }
        private System.Int32 Lerp(System.Int32 a, System.Int32 b, System.Single t) { }
        private System.Void UpdateValues() { }
        private System.Void UpdateComputedStyle() { }
        private System.Void UpdateComputedStyle(System.Int32 i) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000093
    public class ValuesLength : Values`1
    {
        // Fields
        private readonly System.Func<UnityEngine.UIElements.Length,UnityEngine.UIElements.Length,System.Boolean> <SameFunc>k__BackingField;        // 0x88

        // Methods
        private System.Func<UnityEngine.UIElements.Length,UnityEngine.UIElements.Length,System.Boolean> get_SameFunc() { }
        private System.Boolean IsSame(UnityEngine.UIElements.Length a, UnityEngine.UIElements.Length b) { }
        private System.Boolean ConvertUnits(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Length& a, UnityEngine.UIElements.Length& b) { }
        private UnityEngine.UIElements.Length Lerp(UnityEngine.UIElements.Length a, UnityEngine.UIElements.Length b, System.Single t) { }
        private System.Void UpdateValues() { }
        private System.Void UpdateComputedStyle() { }
        private System.Void UpdateComputedStyle(System.Int32 i) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000094
    public class ValuesColor : Values`1
    {
        // Fields
        private readonly System.Func<UnityEngine.Color,UnityEngine.Color,System.Boolean> <SameFunc>k__BackingField;        // 0x88

        // Methods
        private System.Func<UnityEngine.Color,UnityEngine.Color,System.Boolean> get_SameFunc() { }
        private System.Boolean IsSame(UnityEngine.Color c, UnityEngine.Color d) { }
        private UnityEngine.Color Lerp(UnityEngine.Color a, UnityEngine.Color b, System.Single t) { }
        private System.Void UpdateValues() { }
        private System.Void UpdateComputedStyle() { }
        private System.Void UpdateComputedStyle(System.Int32 i) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000095
    public class ValuesDiscrete`1 : Values`1
    {
        // Fields
        private readonly System.Func<T,T,System.Boolean> <SameFunc>k__BackingField;        // 0x0

        // Methods
        private System.Func<T,T,System.Boolean> get_SameFunc() { }
        private System.Boolean IsSame(T a, T b) { }
        private T Lerp(T a, T b, System.Single t) { }
        private System.Void UpdateValues() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000096
    public class ValuesBackground : ValuesDiscrete`1
    {
        // Methods
        private System.Void UpdateComputedStyle() { }
        private System.Void UpdateComputedStyle(System.Int32 i) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000097
    public class ValuesFontDefinition : ValuesDiscrete`1
    {
        // Methods
        private System.Void UpdateComputedStyle() { }
        private System.Void UpdateComputedStyle(System.Int32 i) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000098
    public class ValuesFont : ValuesDiscrete`1
    {
        // Methods
        private System.Void UpdateComputedStyle() { }
        private System.Void UpdateComputedStyle(System.Int32 i) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000099
    public class ValuesTextShadow : Values`1
    {
        // Fields
        private readonly System.Func<UnityEngine.UIElements.TextShadow,UnityEngine.UIElements.TextShadow,System.Boolean> <SameFunc>k__BackingField;        // 0x88

        // Methods
        private System.Func<UnityEngine.UIElements.TextShadow,UnityEngine.UIElements.TextShadow,System.Boolean> get_SameFunc() { }
        private System.Boolean IsSame(UnityEngine.UIElements.TextShadow a, UnityEngine.UIElements.TextShadow b) { }
        private UnityEngine.UIElements.TextShadow Lerp(UnityEngine.UIElements.TextShadow a, UnityEngine.UIElements.TextShadow b, System.Single t) { }
        private System.Void UpdateValues() { }
        private System.Void UpdateComputedStyle() { }
        private System.Void UpdateComputedStyle(System.Int32 i) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009A
    public class ValuesScale : Values`1
    {
        // Fields
        private readonly System.Func<UnityEngine.UIElements.Scale,UnityEngine.UIElements.Scale,System.Boolean> <SameFunc>k__BackingField;        // 0x88

        // Methods
        private System.Func<UnityEngine.UIElements.Scale,UnityEngine.UIElements.Scale,System.Boolean> get_SameFunc() { }
        private System.Boolean IsSame(UnityEngine.UIElements.Scale a, UnityEngine.UIElements.Scale b) { }
        private System.Void UpdateComputedStyle() { }
        private System.Void UpdateComputedStyle(System.Int32 i) { }
        private UnityEngine.UIElements.Scale Lerp(UnityEngine.UIElements.Scale a, UnityEngine.UIElements.Scale b, System.Single t) { }
        private System.Void UpdateValues() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009B
    public class ValuesRotate : Values`1
    {
        // Fields
        private readonly System.Func<UnityEngine.UIElements.Rotate,UnityEngine.UIElements.Rotate,System.Boolean> <SameFunc>k__BackingField;        // 0x88

        // Methods
        private System.Func<UnityEngine.UIElements.Rotate,UnityEngine.UIElements.Rotate,System.Boolean> get_SameFunc() { }
        private System.Boolean IsSame(UnityEngine.UIElements.Rotate a, UnityEngine.UIElements.Rotate b) { }
        private System.Void UpdateComputedStyle() { }
        private System.Void UpdateComputedStyle(System.Int32 i) { }
        private UnityEngine.UIElements.Rotate Lerp(UnityEngine.UIElements.Rotate a, UnityEngine.UIElements.Rotate b, System.Single t) { }
        private System.Void UpdateValues() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009C
    public class ValuesTranslate : Values`1
    {
        // Fields
        private readonly System.Func<UnityEngine.UIElements.Translate,UnityEngine.UIElements.Translate,System.Boolean> <SameFunc>k__BackingField;        // 0x88

        // Methods
        private System.Func<UnityEngine.UIElements.Translate,UnityEngine.UIElements.Translate,System.Boolean> get_SameFunc() { }
        private System.Boolean IsSame(UnityEngine.UIElements.Translate a, UnityEngine.UIElements.Translate b) { }
        private System.Boolean ConvertUnits(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Translate& a, UnityEngine.UIElements.Translate& b) { }
        private System.Void UpdateComputedStyle() { }
        private System.Void UpdateComputedStyle(System.Int32 i) { }
        private UnityEngine.UIElements.Translate Lerp(UnityEngine.UIElements.Translate a, UnityEngine.UIElements.Translate b, System.Single t) { }
        private System.Void UpdateValues() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009D
    public class ValuesTransformOrigin : Values`1
    {
        // Fields
        private readonly System.Func<UnityEngine.UIElements.TransformOrigin,UnityEngine.UIElements.TransformOrigin,System.Boolean> <SameFunc>k__BackingField;        // 0x88

        // Methods
        private System.Func<UnityEngine.UIElements.TransformOrigin,UnityEngine.UIElements.TransformOrigin,System.Boolean> get_SameFunc() { }
        private System.Boolean IsSame(UnityEngine.UIElements.TransformOrigin a, UnityEngine.UIElements.TransformOrigin b) { }
        private System.Boolean ConvertUnits(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TransformOrigin& a, UnityEngine.UIElements.TransformOrigin& b) { }
        private System.Void UpdateComputedStyle() { }
        private System.Void UpdateComputedStyle(System.Int32 i) { }
        private UnityEngine.UIElements.TransformOrigin Lerp(UnityEngine.UIElements.TransformOrigin a, UnityEngine.UIElements.TransformOrigin b, System.Single t) { }
        private System.Void UpdateValues() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A0
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.String get_uxmlName() { }
        private System.String get_uxmlQualifiedName() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A1
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Template;        // 0x78

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A4
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A5
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;        // 0x78
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_EnableRichText;        // 0x80
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_DisplayTooltipWhenElided;        // 0x88

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A9
    public class CreateRuntimePanelDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.UIElements.BaseRuntimePanel Invoke(UnityEngine.ScriptableObject ownerObject) { }

    }

    // TypeToken: 0x20000B1
    public interface IVisualPredicateWrapper
    {
        // Methods
        private System.Boolean Predicate(System.Object e) { }

    }

    // TypeToken: 0x20000B2
    public class IsOfType`1, IVisualPredicateWrapper
    {
        // Fields
        public static UnityEngine.UIElements.UQuery.IsOfType<T> s_Instance;        // 0x0

        // Methods
        private System.Boolean Predicate(System.Object e) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000B3
    public class UQueryMatcher : HierarchyTraversal
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> m_Matchers;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void Traverse(UnityEngine.UIElements.VisualElement element) { }
        private System.Boolean OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element) { }
        private System.Void NoProcessResult(UnityEngine.UIElements.VisualElement e, UnityEngine.UIElements.StyleSheets.MatchResultInfo i) { }
        private System.Void TraverseRecursive(UnityEngine.UIElements.VisualElement element, System.Int32 depth) { }
        private System.Void Run(UnityEngine.UIElements.VisualElement root, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers) { }

    }

    // TypeToken: 0x20000B5
    public class SingleQueryMatcher : UQueryMatcher
    {
        // Fields
        private UnityEngine.UIElements.VisualElement <match>k__BackingField;        // 0x18

        // Methods
        private UnityEngine.UIElements.VisualElement get_match() { }
        private System.Void set_match(UnityEngine.UIElements.VisualElement value) { }
        private System.Void Run(UnityEngine.UIElements.VisualElement root, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers) { }
        private System.Boolean IsInUse() { }
        private UnityEngine.UIElements.UQuery.SingleQueryMatcher CreateNew() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B6
    public class FirstQueryMatcher : SingleQueryMatcher
    {
        // Fields
        public static readonly UnityEngine.UIElements.UQuery.FirstQueryMatcher Instance;        // 0x0

        // Methods
        private System.Boolean OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element) { }
        private UnityEngine.UIElements.UQuery.SingleQueryMatcher CreateNew() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000B8
    public class ListQueryMatcher`1 : UQueryMatcher
    {
        // Fields
        private System.Collections.Generic.List<TElement> <matches>k__BackingField;        // 0x0

        // Methods
        private System.Collections.Generic.List<TElement> get_matches() { }
        private System.Void set_matches(System.Collections.Generic.List<TElement> value) { }
        private System.Boolean OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element) { }
        private System.Void Reset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B9
    public class ActionQueryMatcher : UQueryMatcher
    {
        // Fields
        private System.Action<T> <callBack>k__BackingField;        // 0x0

        // Methods
        private System.Action<T> get_callBack() { }
        private System.Boolean OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BA
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> iterationList;        // 0x0
        private System.Int32 currentIndex;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.UQueryState<T> queryState) { }
        private T get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20000CD
    public struct DefaultFocusOrder
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder ChildOrder;        // 0x0
        public static UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder PositionXY;        // 0x0
        public static UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder PositionYX;        // 0x0

    }

    // TypeToken: 0x20000CE
    public class FocusRingRecord
    {
        // Fields
        public System.Int32 m_AutoIndex;        // 0x10
        public UnityEngine.UIElements.Focusable m_Focusable;        // 0x18
        public System.Boolean m_IsSlot;        // 0x20
        public System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> m_ScopeNavigationOrder;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D8
    public struct State
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater.State Waiting;        // 0x0
        public static UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater.State TrackingAddOrMove;        // 0x0
        public static UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater.State TrackingRemove;        // 0x0

    }

    // TypeToken: 0x20000E1
    public class UpdaterArray
    {
        // Fields
        private UnityEngine.UIElements.IVisualTreeUpdater[] m_VisualTreeUpdaters;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void set_Item(UnityEngine.UIElements.VisualTreeUpdatePhase phase, UnityEngine.UIElements.IVisualTreeUpdater value) { }
        private UnityEngine.UIElements.IVisualTreeUpdater get_Item(UnityEngine.UIElements.VisualTreeUpdatePhase phase) { }
        private UnityEngine.UIElements.IVisualTreeUpdater get_Item(System.Int32 index) { }

    }

    // TypeToken: 0x20000F6
    public struct ContentHeightCacheInfo
    {
        // Fields
        public readonly System.Single sum;        // 0x0
        public readonly System.Int32 count;        // 0x0

        // Methods
        private System.Void .ctor(System.Single sum, System.Int32 count) { }

    }

    // TypeToken: 0x20000F7
    public struct VirtualizationChange
    {
        // Fields
        public System.Int32 value__;        // 0x0
        public static UnityEngine.UIElements.DynamicHeightVirtualizationController.VirtualizationChange<T> None;        // 0x0
        public static UnityEngine.UIElements.DynamicHeightVirtualizationController.VirtualizationChange<T> Resize;        // 0x0
        public static UnityEngine.UIElements.DynamicHeightVirtualizationController.VirtualizationChange<T> Scroll;        // 0x0
        public static UnityEngine.UIElements.DynamicHeightVirtualizationController.VirtualizationChange<T> ForcedScroll;        // 0x0

    }

    // TypeToken: 0x20000F8
    public struct ScrollDirection
    {
        // Fields
        public System.Int32 value__;        // 0x0
        public static UnityEngine.UIElements.DynamicHeightVirtualizationController.ScrollDirection<T> Idle;        // 0x0
        public static UnityEngine.UIElements.DynamicHeightVirtualizationController.ScrollDirection<T> Up;        // 0x0
        public static UnityEngine.UIElements.DynamicHeightVirtualizationController.ScrollDirection<T> Down;        // 0x0

    }

    // TypeToken: 0x2000103
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Label;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Collections.Generic.List<System.String> ParseChoiceList(System.String choicesFromBag) { }

    }

    // TypeToken: 0x2000107
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private readonly UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowFoldoutHeader;        // 0xB0
        private readonly UnityEngine.UIElements.UxmlStringAttributeDescription m_HeaderTitle;        // 0xB8
        private readonly UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowAddRemoveFooter;        // 0xC0
        private readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ListViewReorderMode> m_ReorderMode;        // 0xC8
        private readonly UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowBoundCollectionSize;        // 0xD0

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010A
    public struct SliderKey
    {
        // Fields
        public System.Int32 value__;        // 0x0
        public static UnityEngine.UIElements.BaseSlider.SliderKey<TValueType> None;        // 0x0
        public static UnityEngine.UIElements.BaseSlider.SliderKey<TValueType> Lowest;        // 0x0
        public static UnityEngine.UIElements.BaseSlider.SliderKey<TValueType> LowerPage;        // 0x0
        public static UnityEngine.UIElements.BaseSlider.SliderKey<TValueType> Lower;        // 0x0
        public static UnityEngine.UIElements.BaseSlider.SliderKey<TValueType> Higher;        // 0x0
        public static UnityEngine.UIElements.BaseSlider.SliderKey<TValueType> HigherPage;        // 0x0
        public static UnityEngine.UIElements.BaseSlider.SliderKey<TValueType> Highest;        // 0x0

    }

    // TypeToken: 0x200010C
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private readonly UnityEngine.UIElements.UxmlBoolAttributeDescription m_AutoExpand;        // 0xB0

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000111
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private readonly UnityEngine.UIElements.UxmlIntAttributeDescription m_FixedItemHeight;        // 0x78
        private readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.CollectionVirtualizationMethod> m_VirtualizationMethod;        // 0x80
        private readonly UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowBorder;        // 0x88
        private readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SelectionType> m_SelectionType;        // 0x90
        private readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.AlternatingRowBackground> m_ShowAlternatingRowBackgrounds;        // 0x98
        private readonly UnityEngine.UIElements.UxmlBoolAttributeDescription m_Reorderable;        // 0xA0
        private readonly UnityEngine.UIElements.UxmlBoolAttributeDescription m_HorizontalScrollingEnabled;        // 0xA8

        // Methods
        private System.Void .ctor() { }
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }

    }

    // TypeToken: 0x2000112
    public class Selection
    {
        // Fields
        private readonly System.Collections.Generic.HashSet<System.Int32> m_IndexLookup;        // 0x10
        private readonly System.Collections.Generic.HashSet<System.Int32> m_IdLookup;        // 0x18
        private System.Int32 m_MinIndex;        // 0x20
        private System.Int32 m_MaxIndex;        // 0x24
        private System.Collections.Generic.List<System.Int32> <selectedIds>k__BackingField;        // 0x28
        public readonly System.Collections.Generic.List<System.Int32> indices;        // 0x30
        public readonly System.Collections.Generic.Dictionary<System.Int32,System.Object> items;        // 0x38

        // Methods
        private System.Collections.Generic.List<System.Int32> get_selectedIds() { }
        private System.Void set_selectedIds(System.Collections.Generic.List<System.Int32> value) { }
        private System.Int32 get_indexCount() { }
        private System.Int32 get_idCount() { }
        private System.Int32 get_minIndex() { }
        private System.Int32 get_maxIndex() { }
        private System.Int32 get_capacity() { }
        private System.Void set_capacity(System.Int32 value) { }
        private System.Int32 FirstIndex() { }
        private System.Boolean ContainsIndex(System.Int32 index) { }
        private System.Boolean ContainsId(System.Int32 id) { }
        private System.Void AddId(System.Int32 id) { }
        private System.Void AddIndex(System.Int32 index, System.Object obj) { }
        private System.Boolean TryRemove(System.Int32 index) { }
        private System.Void RemoveId(System.Int32 id) { }
        private System.Void ClearItems() { }
        private System.Void ClearIds() { }
        private System.Void ClearIndices() { }
        private System.Void Clear() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011A
    public class UxmlFactory : UxmlFactory`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011C
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011D
    public class UxmlTraits : UxmlTraits
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011F
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000120
    public class UxmlTraits : UxmlTraits
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000122
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000123
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlIntAttributeDescription m_Index;        // 0x80
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Choices;        // 0x88

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000124
    public class PopupTextElement : TextElement
    {
        // Methods
        private UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000127
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000128
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;        // 0x78
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_Value;        // 0x80

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012B
    public class MenuItem
    {
        // Fields
        public System.String name;        // 0x10
        public UnityEngine.UIElements.VisualElement element;        // 0x18
        public System.Action action;        // 0x20
        public System.Action<System.Object> actionUserData;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012E
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012F
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;        // 0x78

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000132
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000133
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;        // 0x70
        private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.HelpBoxMessageType> m_MessageType;        // 0x78

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000135
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000136
    public class UxmlTraits : UxmlTraits
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013B
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013C
    public class UxmlTraits : UxmlTraits
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013E
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013F
    public class UxmlTraits : UxmlTraits
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000141
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000142
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_MinValue;        // 0x80
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_MaxValue;        // 0x88
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_LowLimit;        // 0x90
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_HighLimit;        // 0x98

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000143
    public struct DragState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.MinMaxSlider.DragState NoThumb;        // 0x0
        public static UnityEngine.UIElements.MinMaxSlider.DragState MinThumb;        // 0x0
        public static UnityEngine.UIElements.MinMaxSlider.DragState MiddleThumb;        // 0x0
        public static UnityEngine.UIElements.MinMaxSlider.DragState MaxThumb;        // 0x0

    }

    // TypeToken: 0x2000145
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000146
    public class UxmlTraits : UxmlTraits
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000148
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_LowValue;        // 0x78
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_HighValue;        // 0x80
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_Value;        // 0x88
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Title;        // 0x90

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014A
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014C
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014D
    public class UxmlTraits : BaseFieldTraits`2
    {
        // Fields
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;        // 0x88

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014F
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000150
    public class UxmlTraits : BaseFieldTraits`2
    {
        // Fields
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Choices;        // 0x88

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000152
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000153
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlLongAttributeDescription m_Delay;        // 0x90
        private UnityEngine.UIElements.UxmlLongAttributeDescription m_Interval;        // 0x98

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000155
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000156
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_LowValue;        // 0x70
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_HighValue;        // 0x78
        private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection> m_Direction;        // 0x80
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_Value;        // 0x88

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200015A
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200015B
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollViewMode> m_ScrollViewMode;        // 0x70
        private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollView.NestedInteractionKind> m_NestedInteractionKind;        // 0x78
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowHorizontal;        // 0x80
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowVertical;        // 0x88
        private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollerVisibility> m_HorizontalScrollerVisibility;        // 0x90
        private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollerVisibility> m_VerticalScrollerVisibility;        // 0x98
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_HorizontalPageSize;        // 0xA0
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_VerticalPageSize;        // 0xA8
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_MouseWheelScrollSize;        // 0xB0
        private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollView.TouchScrollBehavior> m_TouchScrollBehavior;        // 0xB8
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_ScrollDecelerationRate;        // 0xC0
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_Elasticity;        // 0xC8
        private UnityEngine.UIElements.UxmlLongAttributeDescription m_ElasticAnimationIntervalMs;        // 0xD0

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200015C
    public struct TouchScrollBehavior
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.ScrollView.TouchScrollBehavior Unrestricted;        // 0x0
        public static UnityEngine.UIElements.ScrollView.TouchScrollBehavior Elastic;        // 0x0
        public static UnityEngine.UIElements.ScrollView.TouchScrollBehavior Clamped;        // 0x0

    }

    // TypeToken: 0x200015D
    public struct NestedInteractionKind
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.ScrollView.NestedInteractionKind Default;        // 0x0
        public static UnityEngine.UIElements.ScrollView.NestedInteractionKind StopScrolling;        // 0x0
        public static UnityEngine.UIElements.ScrollView.NestedInteractionKind ForwardScrolling;        // 0x0

    }

    // TypeToken: 0x200015E
    public struct TouchScrollingResult
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.ScrollView.TouchScrollingResult Apply;        // 0x0
        public static UnityEngine.UIElements.ScrollView.TouchScrollingResult Forward;        // 0x0
        public static UnityEngine.UIElements.ScrollView.TouchScrollingResult Block;        // 0x0

    }

    // TypeToken: 0x2000160
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000161
    public class UxmlTraits : BaseFieldTraits`2
    {
        // Fields
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_LowValue;        // 0x88
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_HighValue;        // 0x90
        private UnityEngine.UIElements.UxmlFloatAttributeDescription m_PageSize;        // 0x98
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowInputField;        // 0xA0
        private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection> m_Direction;        // 0xA8
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_Inverted;        // 0xB0

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000163
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000164
    public class UxmlTraits : BaseFieldTraits`2
    {
        // Fields
        private UnityEngine.UIElements.UxmlIntAttributeDescription m_LowValue;        // 0x88
        private UnityEngine.UIElements.UxmlIntAttributeDescription m_HighValue;        // 0x90
        private UnityEngine.UIElements.UxmlIntAttributeDescription m_PageSize;        // 0x98
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_ShowInputField;        // 0xA0
        private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection> m_Direction;        // 0xA8
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_Inverted;        // 0xB0

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000167
    public class OnDetectFocusChangeFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x2000168
    public class OnIndexChangeFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x200016A
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200016B
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private static readonly UnityEngine.UIElements.UxmlStringAttributeDescription k_Value;        // 0x0
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_Multiline;        // 0xB8

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200016C
    public class TextInput : TextInputBase
    {
        // Fields
        private System.Boolean m_Multiline;        // 0x420

        // Methods
        private UnityEngine.UIElements.TextField get_parentTextField() { }
        private System.Boolean get_multiline() { }
        private System.Void set_multiline(System.Boolean value) { }
        private System.Void SetTextAlign() { }
        private System.Void set_isPasswordField(System.Boolean value) { }
        private System.String StringToValue(System.String str) { }
        private System.Void SyncTextEngine() { }
        private System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt) { }
        private System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200016F
    public class UxmlTraits : BaseFieldTraits`2
    {
        // Fields
        private UnityEngine.UIElements.UxmlIntAttributeDescription m_MaxLength;        // 0x0
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_Password;        // 0x0
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_MaskCharacter;        // 0x0
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;        // 0x0
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_IsReadOnly;        // 0x0
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_IsDelayed;        // 0x0

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000170
    public class TextInputBase : VisualElement, ITextInputField, IEventHandler, ITextElement
    {
        // Fields
        private System.String m_OriginalText;        // 0x0
        private System.Boolean <isReadOnly>k__BackingField;        // 0x0
        private System.Int32 <maxLength>k__BackingField;        // 0x0
        private System.Char <maskChar>k__BackingField;        // 0x0
        private System.Boolean <isPasswordField>k__BackingField;        // 0x0
        private System.Boolean <doubleClickSelectsWord>k__BackingField;        // 0x0
        private System.Boolean <tripleClickSelectsLine>k__BackingField;        // 0x0
        private System.Boolean <isDelayed>k__BackingField;        // 0x0
        private System.Boolean <isDragging>k__BackingField;        // 0x0
        private System.Boolean m_TouchScreenTextFieldInitialized;        // 0x0
        private UnityEngine.UIElements.IVisualElementScheduledItem m_HardwareKeyboardPoller;        // 0x0
        private UnityEngine.Color m_SelectionColor;        // 0x0
        private UnityEngine.Color m_CursorColor;        // 0x0
        private UnityEngine.UIElements.TextEditorEventHandler <editorEventHandler>k__BackingField;        // 0x0
        private UnityEngine.UIElements.TextEditorEngine <editorEngine>k__BackingField;        // 0x0
        private UnityEngine.UIElements.ITextHandle m_TextHandle;        // 0x0
        private System.String m_Text;        // 0x0

        // Methods
        private System.Void ResetValueAndText() { }
        private System.Void SaveValueAndText() { }
        private System.Void RestoreValueAndText() { }
        private System.Void UpdateText(System.String value) { }
        private TValueType StringToValue(System.String str) { }
        private System.Void UpdateValueFromText() { }
        private System.Boolean UnityEngine.UIElements.ITextInputField.get_isReadOnly() { }
        private System.Boolean get_isReadOnly() { }
        private System.Void set_isReadOnly(System.Boolean value) { }
        private System.Int32 get_maxLength() { }
        private System.Void set_maxLength(System.Int32 value) { }
        private System.Char get_maskChar() { }
        private System.Void set_maskChar(System.Char value) { }
        private System.Boolean get_isPasswordField() { }
        private System.Void set_isPasswordField(System.Boolean value) { }
        private System.Boolean get_doubleClickSelectsWord() { }
        private System.Void set_doubleClickSelectsWord(System.Boolean value) { }
        private System.Boolean get_tripleClickSelectsLine() { }
        private System.Void set_tripleClickSelectsLine(System.Boolean value) { }
        private System.Boolean get_isDelayed() { }
        private System.Void set_isDelayed(System.Boolean value) { }
        private System.Boolean get_isDragging() { }
        private System.Boolean get_touchScreenTextField() { }
        private System.Boolean get_touchScreenTextFieldChanged() { }
        private UnityEngine.Color get_selectionColor() { }
        private UnityEngine.Color get_cursorColor() { }
        private System.Boolean get_hasFocus() { }
        private UnityEngine.UIElements.TextEditorEventHandler get_editorEventHandler() { }
        private System.Void set_editorEventHandler(UnityEngine.UIElements.TextEditorEventHandler value) { }
        private UnityEngine.UIElements.TextEditorEngine get_editorEngine() { }
        private System.Void set_editorEngine(UnityEngine.UIElements.TextEditorEngine value) { }
        private System.String get_text() { }
        private System.Void set_text(System.String value) { }
        private System.Void .ctor() { }
        private System.Void InitTextEditorEventHandler() { }
        private UnityEngine.UIElements.DropdownMenuAction.Status CutActionStatus(UnityEngine.UIElements.DropdownMenuAction a) { }
        private UnityEngine.UIElements.DropdownMenuAction.Status CopyActionStatus(UnityEngine.UIElements.DropdownMenuAction a) { }
        private UnityEngine.UIElements.DropdownMenuAction.Status PasteActionStatus(UnityEngine.UIElements.DropdownMenuAction a) { }
        private System.Void ProcessMenuCommand(System.String command) { }
        private System.Void Cut(UnityEngine.UIElements.DropdownMenuAction a) { }
        private System.Void Copy(UnityEngine.UIElements.DropdownMenuAction a) { }
        private System.Void Paste(UnityEngine.UIElements.DropdownMenuAction a) { }
        private System.Void OnInputCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e) { }
        private System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent attachEvent) { }
        private System.Void SyncTextEngine() { }
        private System.String CullString(System.String s) { }
        private System.Void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc) { }
        private System.Void DrawWithTextSelectionAndCursor(UnityEngine.UIElements.MeshGenerationContext mgc, System.String newText, System.Single pixelsPerPoint) { }
        private System.Boolean AcceptCharacter(System.Char c) { }
        private System.Void BuildContextualMenu(UnityEngine.UIElements.ContextualMenuPopulateEvent evt) { }
        private System.Void OnDetectFocusChange() { }
        private System.Void OnCursorIndexChange() { }
        private UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode) { }
        private System.Void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase evt) { }
        private System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt) { }
        private System.Void ProcessEventAtTarget(UnityEngine.UIElements.EventBase evt) { }
        private System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt) { }
        private System.Boolean UnityEngine.UIElements.ITextInputField.get_hasFocus() { }
        private System.Void UnityEngine.UIElements.ITextInputField.SyncTextEngine() { }
        private System.Boolean UnityEngine.UIElements.ITextInputField.AcceptCharacter(System.Char c) { }
        private System.String UnityEngine.UIElements.ITextInputField.CullString(System.String s) { }
        private System.Void UnityEngine.UIElements.ITextInputField.UpdateText(System.String value) { }
        private UnityEngine.UIElements.TextEditorEngine UnityEngine.UIElements.ITextInputField.get_editorEngine() { }
        private System.Boolean UnityEngine.UIElements.ITextInputField.get_isDelayed() { }
        private System.Void UnityEngine.UIElements.ITextInputField.UpdateValueFromText() { }
        private System.Void DeferGUIStyleRectSync() { }
        private System.Void OnPercentResolved(UnityEngine.UIElements.GeometryChangedEvent evt) { }
        private System.Void SyncGUIStyle(UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> textInput, UnityEngine.GUIStyle style) { }
        private System.Boolean IsLayoutUsingPercent(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void AssignRect(UnityEngine.RectOffset rect, System.Int32 left, System.Int32 top, System.Int32 right, System.Int32 bottom) { }
        private System.Void <ProcessEventAtTarget>b__99_0() { }

    }

    // TypeToken: 0x2000172
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000173
    public class UxmlTraits : BaseFieldTraits`2
    {
        // Fields
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;        // 0x88

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000176
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000177
    public class UxmlTraits : UxmlTraits
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017D
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017E
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlIntAttributeDescription m_FixedPaneIndex;        // 0x70
        private UnityEngine.UIElements.UxmlIntAttributeDescription m_FixedPaneInitialDimension;        // 0x78
        private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.TwoPaneSplitViewOrientation> m_Orientation;        // 0x80

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000183
    public class UxmlObjectFactory`1 : UxmlObjectFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000184
    public class UxmlObjectTraits`1 : UxmlObjectTraits`1
    {
        // Fields
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Name;        // 0x0
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Text;        // 0x0
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_Visible;        // 0x0
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Width;        // 0x0
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_MinWidth;        // 0x0
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_MaxWidth;        // 0x0
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_Stretch;        // 0x0
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_Sortable;        // 0x0
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_Optional;        // 0x0
        private UnityEngine.UIElements.UxmlBoolAttributeDescription m_Resizable;        // 0x0
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_HeaderTemplateId;        // 0x0
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_CellTemplateId;        // 0x0

        // Methods
        private UnityEngine.UIElements.Length ParseLength(System.String str, UnityEngine.UIElements.Length defaultValue) { }
        private System.Void Init(T& obj, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200018C
    public struct StretchMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.Columns.StretchMode Grow;        // 0x0
        public static UnityEngine.UIElements.Columns.StretchMode GrowAndFill;        // 0x0

    }

    // TypeToken: 0x200018D
    public class UxmlObjectFactory`1 : UxmlObjectFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200018E
    public class UxmlObjectTraits`1 : UxmlObjectTraits`1
    {
        // Fields
        private readonly UnityEngine.UIElements.UxmlStringAttributeDescription m_PrimaryColumnName;        // 0x0
        private readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.Columns.StretchMode> m_StretchMode;        // 0x0
        private readonly UnityEngine.UIElements.UxmlBoolAttributeDescription m_Reorderable;        // 0x0
        private readonly UnityEngine.UIElements.UxmlBoolAttributeDescription m_Resizable;        // 0x0
        private readonly UnityEngine.UIElements.UxmlBoolAttributeDescription m_ResizePreview;        // 0x0
        private readonly UnityEngine.UIElements.UxmlObjectListAttributeDescription<UnityEngine.UIElements.Column> m_Columns;        // 0x0

        // Methods
        private System.Void Init(T& obj, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000192
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000193
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private readonly UnityEngine.UIElements.UxmlBoolAttributeDescription m_SortingEnabled;        // 0xD8
        private readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.Columns> m_Columns;        // 0xE0
        private readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.SortColumnDescriptions> m_SortColumnDescriptions;        // 0xE8

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000195
    public class UxmlFactory : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000196
    public class UxmlTraits : UxmlTraits
    {
        // Fields
        private readonly UnityEngine.UIElements.UxmlBoolAttributeDescription m_SortingEnabled;        // 0xB8
        private readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.Columns> m_Columns;        // 0xC0
        private readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.SortColumnDescriptions> m_SortColumnDescriptions;        // 0xC8

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000199
    public class UxmlObjectFactory`1 : UxmlObjectFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200019A
    public class UxmlObjectTraits`1 : UxmlObjectTraits`1
    {
        // Fields
        private readonly UnityEngine.UIElements.UxmlStringAttributeDescription m_ColumnName;        // 0x0
        private readonly UnityEngine.UIElements.UxmlIntAttributeDescription m_ColumnIndex;        // 0x0
        private readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SortDirection> m_SortDescription;        // 0x0

        // Methods
        private System.Void Init(T& obj, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200019C
    public class UxmlObjectFactory`1 : UxmlObjectFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200019D
    public class UxmlObjectTraits`1 : UxmlObjectTraits`1
    {
        // Fields
        private readonly UnityEngine.UIElements.UxmlObjectListAttributeDescription<UnityEngine.UIElements.SortColumnDescription> m_SortColumnDescriptions;        // 0x0

        // Methods
        private System.Void Init(T& obj, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A2
    public struct DragState
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.DragEventsProcessor.DragState None;        // 0x0
        public static UnityEngine.UIElements.DragEventsProcessor.DragState CanStartDrag;        // 0x0
        public static UnityEngine.UIElements.DragEventsProcessor.DragState Dragging;        // 0x0

    }

    // TypeToken: 0x20001B1
    public struct DragPosition, IEquatable`1
    {
        // Fields
        public System.Int32 insertAtIndex;        // 0x10
        public System.Int32 parentId;        // 0x14
        public System.Int32 childIndex;        // 0x18
        public UnityEngine.UIElements.ReusableCollectionItem recycledItem;        // 0x20
        public UnityEngine.UIElements.DragAndDropPosition dropPosition;        // 0x28

        // Methods
        private System.Boolean Equals(UnityEngine.UIElements.ListViewDragger.DragPosition other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x20001B6
    public class DropData
    {
        // Fields
        public System.Int32[] expandedIdsBeforeDrag;        // 0x10
        public System.Int32[] draggedIds;        // 0x18
        public System.Int32 lastItemId;        // 0x20
        public System.Single expandItemBeginTimerMs;        // 0x24
        public UnityEngine.Vector2 expandItemBeginPosition;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B7
    public struct TreeItemState
    {
        // Fields
        public System.Int32 parentId;        // 0x10
        public System.Int32 childIndex;        // 0x14

        // Methods
        private System.Void .ctor(System.Int32 parentId, System.Int32 childIndex) { }

    }

    // TypeToken: 0x20001C8
    public struct EventPropagation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.EventBase.EventPropagation None;        // 0x0
        public static UnityEngine.UIElements.EventBase.EventPropagation Bubbles;        // 0x0
        public static UnityEngine.UIElements.EventBase.EventPropagation TricklesDown;        // 0x0
        public static UnityEngine.UIElements.EventBase.EventPropagation Cancellable;        // 0x0
        public static UnityEngine.UIElements.EventBase.EventPropagation SkipDisabledElements;        // 0x0
        public static UnityEngine.UIElements.EventBase.EventPropagation IgnoreCompositeRoots;        // 0x0

    }

    // TypeToken: 0x20001C9
    public struct LifeCycleStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.EventBase.LifeCycleStatus None;        // 0x0
        public static UnityEngine.UIElements.EventBase.LifeCycleStatus PropagationStopped;        // 0x0
        public static UnityEngine.UIElements.EventBase.LifeCycleStatus ImmediatePropagationStopped;        // 0x0
        public static UnityEngine.UIElements.EventBase.LifeCycleStatus DefaultPrevented;        // 0x0
        public static UnityEngine.UIElements.EventBase.LifeCycleStatus Dispatching;        // 0x0
        public static UnityEngine.UIElements.EventBase.LifeCycleStatus Pooled;        // 0x0
        public static UnityEngine.UIElements.EventBase.LifeCycleStatus IMGUIEventIsValid;        // 0x0
        public static UnityEngine.UIElements.EventBase.LifeCycleStatus StopDispatch;        // 0x0
        public static UnityEngine.UIElements.EventBase.LifeCycleStatus PropagateToIMGUI;        // 0x0
        public static UnityEngine.UIElements.EventBase.LifeCycleStatus Dispatched;        // 0x0
        public static UnityEngine.UIElements.EventBase.LifeCycleStatus Processed;        // 0x0
        public static UnityEngine.UIElements.EventBase.LifeCycleStatus ProcessedByFocusController;        // 0x0

    }

    // TypeToken: 0x20001E7
    public struct EventBehavior
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.MouseCaptureDispatchingStrategy.EventBehavior None;        // 0x0
        public static UnityEngine.UIElements.MouseCaptureDispatchingStrategy.EventBehavior IsCapturable;        // 0x0
        public static UnityEngine.UIElements.MouseCaptureDispatchingStrategy.EventBehavior IsSentExclusivelyToCapturingElement;        // 0x0

    }

    // TypeToken: 0x20001FF
    public struct Direction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.NavigationMoveEvent.Direction None;        // 0x0
        public static UnityEngine.UIElements.NavigationMoveEvent.Direction Left;        // 0x0
        public static UnityEngine.UIElements.NavigationMoveEvent.Direction Up;        // 0x0
        public static UnityEngine.UIElements.NavigationMoveEvent.Direction Right;        // 0x0
        public static UnityEngine.UIElements.NavigationMoveEvent.Direction Down;        // 0x0
        public static UnityEngine.UIElements.NavigationMoveEvent.Direction Next;        // 0x0
        public static UnityEngine.UIElements.NavigationMoveEvent.Direction Previous;        // 0x0

    }

    // TypeToken: 0x2000201
    public struct Direction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.NavigationTabEvent.Direction None;        // 0x0
        public static UnityEngine.UIElements.NavigationTabEvent.Direction Next;        // 0x0
        public static UnityEngine.UIElements.NavigationTabEvent.Direction Previous;        // 0x0

    }

    // TypeToken: 0x2000209
    public struct LocationFlag
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.PointerDeviceState.LocationFlag None;        // 0x0
        public static UnityEngine.UIElements.PointerDeviceState.LocationFlag OutsidePanel;        // 0x0

    }

    // TypeToken: 0x200020A
    public struct PointerLocation
    {
        // Fields
        private UnityEngine.Vector2 <Position>k__BackingField;        // 0x10
        private UnityEngine.UIElements.IPanel <Panel>k__BackingField;        // 0x18
        private UnityEngine.UIElements.PointerDeviceState.LocationFlag <Flags>k__BackingField;        // 0x20

        // Methods
        private UnityEngine.Vector2 get_Position() { }
        private System.Void set_Position(UnityEngine.Vector2 value) { }
        private UnityEngine.UIElements.IPanel get_Panel() { }
        private System.Void set_Panel(UnityEngine.UIElements.IPanel value) { }
        private UnityEngine.UIElements.PointerDeviceState.LocationFlag get_Flags() { }
        private System.Void set_Flags(UnityEngine.UIElements.PointerDeviceState.LocationFlag value) { }
        private System.Void SetLocation(UnityEngine.Vector2 position, UnityEngine.UIElements.IPanel panel) { }

    }

    // TypeToken: 0x200021C
    public struct Type
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.PropagationPaths.Type None;        // 0x0
        public static UnityEngine.UIElements.PropagationPaths.Type TrickleDown;        // 0x0
        public static UnityEngine.UIElements.PropagationPaths.Type BubbleUp;        // 0x0

    }

    // TypeToken: 0x2000220
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.StylePropertyName> m_Enumerator;        // 0x10

        // Methods
        private System.Void .ctor(System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.StylePropertyName> enumerator) { }
        private System.Boolean MoveNext() { }
        private UnityEngine.UIElements.StylePropertyName get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void Reset() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200022E
    public class ChangeDirection : FocusChangeDirection
    {
        // Methods
        private System.Void .ctor(System.Int32 i) { }

    }

    // TypeToken: 0x200022F
    public struct FocusableHierarchyTraversal
    {
        // Fields
        public UnityEngine.UIElements.VisualElement currentFocusable;        // 0x10
        public UnityEngine.Rect validRect;        // 0x18
        public System.Boolean firstPass;        // 0x28
        public UnityEngine.UIElements.NavigateFocusRing.ChangeDirection direction;        // 0x30

        // Methods
        private System.Boolean ValidateHierarchyTraversal(UnityEngine.UIElements.VisualElement v) { }
        private System.Boolean ValidateElement(UnityEngine.UIElements.VisualElement v) { }
        private System.Int32 Order(UnityEngine.UIElements.VisualElement a, UnityEngine.UIElements.VisualElement b) { }
        private System.Int32 StrictOrder(UnityEngine.UIElements.VisualElement a, UnityEngine.UIElements.VisualElement b) { }
        private System.Int32 StrictOrder(UnityEngine.Rect ra, UnityEngine.Rect rb) { }
        private System.Int32 TieBreaker(UnityEngine.Rect ra, UnityEngine.Rect rb) { }
        private UnityEngine.UIElements.VisualElement GetBestOverall(UnityEngine.UIElements.VisualElement candidate, UnityEngine.UIElements.VisualElement bestSoFar) { }

    }

    // TypeToken: 0x2000233
    public class RuntimePanelAccess
    {
        // Fields
        private readonly UnityEngine.UIElements.PanelSettings m_Settings;        // 0x10
        private UnityEngine.UIElements.BaseRuntimePanel m_RuntimePanel;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.PanelSettings settings) { }
        private System.Boolean get_isInitialized() { }
        private UnityEngine.UIElements.BaseRuntimePanel get_panel() { }
        private System.Void DisposePanel() { }
        private System.Void SetTargetTexture() { }
        private System.Void SetSortingPriority() { }
        private System.Void SetTargetDisplay() { }
        private UnityEngine.UIElements.BaseRuntimePanel CreateRelatedRuntimePanel() { }
        private System.Void DisposeRelatedPanel() { }
        private System.Void MarkPotentiallyEmpty() { }

    }

    // TypeToken: 0x2000239
    public class Row
    {
        // Fields
        private static UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.UIRAtlasAllocator.Row> s_Pool;        // 0x0
        private System.Int32 <offsetX>k__BackingField;        // 0x10
        private System.Int32 <offsetY>k__BackingField;        // 0x14
        private System.Int32 <width>k__BackingField;        // 0x18
        private System.Int32 <height>k__BackingField;        // 0x1C
        public System.Int32 Cursor;        // 0x20

        // Methods
        private System.Int32 get_offsetX() { }
        private System.Void set_offsetX(System.Int32 value) { }
        private System.Int32 get_offsetY() { }
        private System.Void set_offsetY(System.Int32 value) { }
        private System.Int32 get_width() { }
        private System.Void set_width(System.Int32 value) { }
        private System.Void set_height(System.Int32 value) { }
        private UnityEngine.UIElements.UIRAtlasAllocator.Row Acquire(System.Int32 offsetX, System.Int32 offsetY, System.Int32 width, System.Int32 height) { }
        private System.Void Release() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200023A
    public class AreaNode
    {
        // Fields
        private static UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.UIRAtlasAllocator.AreaNode> s_Pool;        // 0x0
        public UnityEngine.RectInt rect;        // 0x10
        public UnityEngine.UIElements.UIRAtlasAllocator.AreaNode previous;        // 0x20
        public UnityEngine.UIElements.UIRAtlasAllocator.AreaNode next;        // 0x28

        // Methods
        private UnityEngine.UIElements.UIRAtlasAllocator.AreaNode Acquire(UnityEngine.RectInt rect) { }
        private System.Void Release() { }
        private System.Void RemoveFromChain() { }
        private System.Void AddAfter(UnityEngine.UIElements.UIRAtlasAllocator.AreaNode previous) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000241
    public struct BorderParams
    {
        // Fields
        public UnityEngine.Rect rect;        // 0x10
        public UnityEngine.Color playmodeTintColor;        // 0x20
        public UnityEngine.Color leftColor;        // 0x30
        public UnityEngine.Color topColor;        // 0x40
        public UnityEngine.Color rightColor;        // 0x50
        public UnityEngine.Color bottomColor;        // 0x60
        public System.Single leftWidth;        // 0x70
        public System.Single topWidth;        // 0x74
        public System.Single rightWidth;        // 0x78
        public System.Single bottomWidth;        // 0x7C
        public UnityEngine.Vector2 topLeftRadius;        // 0x80
        public UnityEngine.Vector2 topRightRadius;        // 0x88
        public UnityEngine.Vector2 bottomRightRadius;        // 0x90
        public UnityEngine.Vector2 bottomLeftRadius;        // 0x98
        public UnityEngine.Material material;        // 0xA0
        private UnityEngine.UIElements.ColorPage leftColorPage;        // 0xA8
        private UnityEngine.UIElements.ColorPage topColorPage;        // 0xB0
        private UnityEngine.UIElements.ColorPage rightColorPage;        // 0xB8
        private UnityEngine.UIElements.ColorPage bottomColorPage;        // 0xC0

    }

    // TypeToken: 0x2000242
    public struct RectangleParams
    {
        // Fields
        public UnityEngine.Rect rect;        // 0x10
        public UnityEngine.Rect uv;        // 0x20
        public UnityEngine.Color color;        // 0x30
        public UnityEngine.Texture texture;        // 0x40
        public UnityEngine.Sprite sprite;        // 0x48
        public UnityEngine.UIElements.VectorImage vectorImage;        // 0x50
        public UnityEngine.Material material;        // 0x58
        public UnityEngine.ScaleMode scaleMode;        // 0x60
        public UnityEngine.Color playmodeTintColor;        // 0x64
        public UnityEngine.Vector2 topLeftRadius;        // 0x74
        public UnityEngine.Vector2 topRightRadius;        // 0x7C
        public UnityEngine.Vector2 bottomRightRadius;        // 0x84
        public UnityEngine.Vector2 bottomLeftRadius;        // 0x8C
        public System.Int32 leftSlice;        // 0x94
        public System.Int32 topSlice;        // 0x98
        public System.Int32 rightSlice;        // 0x9C
        public System.Int32 bottomSlice;        // 0xA0
        public System.Single sliceScale;        // 0xA4
        private UnityEngine.Rect spriteGeomRect;        // 0xA8
        public UnityEngine.Vector4 rectInset;        // 0xB8
        private UnityEngine.UIElements.ColorPage colorPage;        // 0xC8
        private UnityEngine.UIElements.MeshGenerationContext.MeshFlags meshFlags;        // 0xD0

        // Methods
        private System.Void AdjustUVsForScaleMode(UnityEngine.Rect rect, UnityEngine.Rect uv, UnityEngine.Texture texture, UnityEngine.ScaleMode scaleMode, UnityEngine.Rect& rectOut, UnityEngine.Rect& uvOut) { }
        private System.Void AdjustSpriteUVsForScaleMode(UnityEngine.Rect containerRect, UnityEngine.Rect srcRect, UnityEngine.Rect spriteGeomRect, UnityEngine.Sprite sprite, UnityEngine.ScaleMode scaleMode, UnityEngine.Rect& rectOut, UnityEngine.Rect& uvOut) { }
        private UnityEngine.Rect RectIntersection(UnityEngine.Rect a, UnityEngine.Rect b) { }
        private UnityEngine.Rect ComputeGeomRect(UnityEngine.Sprite sprite) { }
        private UnityEngine.Rect ComputeUVRect(UnityEngine.Sprite sprite) { }
        private UnityEngine.Rect ApplyPackingRotation(UnityEngine.Rect uv, UnityEngine.SpritePackingRotation rotation) { }
        private UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams MakeTextured(UnityEngine.Rect rect, UnityEngine.Rect uv, UnityEngine.Texture texture, UnityEngine.ScaleMode scaleMode, UnityEngine.UIElements.ContextType panelContext) { }
        private UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams MakeSprite(UnityEngine.Rect containerRect, UnityEngine.Rect subRect, UnityEngine.Sprite sprite, UnityEngine.ScaleMode scaleMode, UnityEngine.UIElements.ContextType panelContext, System.Boolean hasRadius, UnityEngine.Vector4& slices) { }
        private UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams MakeVectorTextured(UnityEngine.Rect rect, UnityEngine.Rect uv, UnityEngine.UIElements.VectorImage vectorImage, UnityEngine.ScaleMode scaleMode, UnityEngine.UIElements.ContextType panelContext) { }
        private System.Boolean HasRadius(System.Single epsilon) { }

    }

    // TypeToken: 0x2000243
    public struct TextParams
    {
        // Fields
        public UnityEngine.Rect rect;        // 0x10
        public System.String text;        // 0x20
        public UnityEngine.Font font;        // 0x28
        public UnityEngine.UIElements.FontDefinition fontDefinition;        // 0x30
        public System.Int32 fontSize;        // 0x40
        public UnityEngine.UIElements.Length letterSpacing;        // 0x44
        public UnityEngine.UIElements.Length wordSpacing;        // 0x4C
        public UnityEngine.UIElements.Length paragraphSpacing;        // 0x54
        public UnityEngine.FontStyle fontStyle;        // 0x5C
        public UnityEngine.Color fontColor;        // 0x60
        public UnityEngine.TextAnchor anchor;        // 0x70
        public System.Boolean wordWrap;        // 0x74
        public System.Single wordWrapWidth;        // 0x78
        public System.Boolean richText;        // 0x7C
        public UnityEngine.Color playmodeTintColor;        // 0x80
        public UnityEngine.UIElements.TextOverflow textOverflow;        // 0x90
        public UnityEngine.UIElements.TextOverflowPosition textOverflowPosition;        // 0x94
        public UnityEngine.UIElements.OverflowInternal overflow;        // 0x98
        public UnityEngine.UIElements.IPanel panel;        // 0xA0

        // Methods
        private System.Int32 GetHashCode() { }
        private UnityEngine.UIElements.MeshGenerationContextUtils.TextParams MakeStyleBased(UnityEngine.UIElements.VisualElement ve, System.String text) { }
        private UnityEngine.UIElements.TextNativeSettings GetTextNativeSettings(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, System.Single scaling) { }

    }

    // TypeToken: 0x2000245
    public struct MeshFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.MeshGenerationContext.MeshFlags None;        // 0x0
        public static UnityEngine.UIElements.MeshGenerationContext.MeshFlags UVisDisplacement;        // 0x0
        public static UnityEngine.UIElements.MeshGenerationContext.MeshFlags SkipDynamicAtlas;        // 0x0

    }

    // TypeToken: 0x2000249
    public struct TextureInfo
    {
        // Fields
        public UnityEngine.Texture texture;        // 0x10
        public System.Boolean dynamic;        // 0x18
        public System.Int32 refCount;        // 0x1C

    }

    // TypeToken: 0x200024D
    public struct Unit
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.Angle.Unit Degree;        // 0x0
        public static UnityEngine.UIElements.Angle.Unit Gradian;        // 0x0
        public static UnityEngine.UIElements.Angle.Unit Radian;        // 0x0
        public static UnityEngine.UIElements.Angle.Unit Turn;        // 0x0
        public static UnityEngine.UIElements.Angle.Unit None;        // 0x0

    }

    // TypeToken: 0x200025A
    public struct InlineRule
    {
        // Fields
        public UnityEngine.UIElements.StyleSheet sheet;        // 0x10
        public UnityEngine.UIElements.StyleRule rule;        // 0x18
        public UnityEngine.UIElements.StyleSheets.StylePropertyId[] propertyIds;        // 0x20

    }

    // TypeToken: 0x200025D
    public struct Unit
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.Length.Unit Pixel;        // 0x0
        public static UnityEngine.UIElements.Length.Unit Percent;        // 0x0
        public static UnityEngine.UIElements.Length.Unit Auto;        // 0x0
        public static UnityEngine.UIElements.Length.Unit None;        // 0x0

    }

    // TypeToken: 0x2000263
    public class RefCounted
    {
        // Fields
        private static System.UInt32 m_NextId;        // 0x0
        private System.Int32 m_RefCount;        // 0x0
        private readonly System.UInt32 m_Id;        // 0x0
        public T value;        // 0x0

        // Methods
        private System.Int32 get_refCount() { }
        private System.Void .ctor() { }
        private System.Void Acquire() { }
        private System.Void Release() { }
        private UnityEngine.UIElements.StyleDataRef.RefCounted<T> Copy() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000280
    public struct PseudoStateData
    {
        // Fields
        public readonly UnityEngine.UIElements.PseudoStates state;        // 0x10
        public readonly System.Boolean negate;        // 0x14

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.PseudoStates state, System.Boolean negate) { }

    }

    // TypeToken: 0x200028A
    public struct ImportStruct
    {
        // Fields
        public UnityEngine.UIElements.StyleSheet styleSheet;        // 0x10
        public System.String[] mediaQueries;        // 0x18

    }

    // TypeToken: 0x2000295
    public struct Result
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StyleVariableResolver.Result Valid;        // 0x0
        public static UnityEngine.UIElements.StyleVariableResolver.Result Invalid;        // 0x0
        public static UnityEngine.UIElements.StyleVariableResolver.Result NotFound;        // 0x0

    }

    // TypeToken: 0x2000296
    public struct ResolveContext
    {
        // Fields
        public UnityEngine.UIElements.StyleSheet sheet;        // 0x10
        public UnityEngine.UIElements.StyleValueHandle[] handles;        // 0x18

    }

    // TypeToken: 0x20002A7
    public struct AttributeOverride
    {
        // Fields
        public System.String m_ElementName;        // 0x10
        public System.String m_AttributeName;        // 0x18
        public System.String m_Value;        // 0x20

    }

    // TypeToken: 0x20002A9
    public struct Use
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.UxmlAttributeDescription.Use None;        // 0x0
        public static UnityEngine.UIElements.UxmlAttributeDescription.Use Optional;        // 0x0
        public static UnityEngine.UIElements.UxmlAttributeDescription.Use Prohibited;        // 0x0
        public static UnityEngine.UIElements.UxmlAttributeDescription.Use Required;        // 0x0

    }

    // TypeToken: 0x20002CC
    public struct UsingEntry
    {
        // Fields
        private static readonly System.Collections.Generic.IComparer<UnityEngine.UIElements.VisualTreeAsset.UsingEntry> comparer;        // 0x0
        public System.String alias;        // 0x10
        public System.String path;        // 0x18
        public UnityEngine.UIElements.VisualTreeAsset asset;        // 0x20

        // Methods
        private System.Void .ctor(System.String alias, System.String path) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002CD
    public class UsingEntryComparer, IComparer`1
    {
        // Methods
        private System.Int32 Compare(UnityEngine.UIElements.VisualTreeAsset.UsingEntry x, UnityEngine.UIElements.VisualTreeAsset.UsingEntry y) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002CE
    public struct SlotDefinition
    {
        // Fields
        public System.String name;        // 0x10
        public System.Int32 insertionPointId;        // 0x18

    }

    // TypeToken: 0x20002CF
    public struct SlotUsageEntry
    {
        // Fields
        public System.String slotName;        // 0x10
        public System.Int32 assetId;        // 0x18

    }

    // TypeToken: 0x20002D0
    public struct UxmlObjectEntry
    {
        // Fields
        public System.Int32 parentId;        // 0x10
        public System.Collections.Generic.List<UnityEngine.UIElements.UxmlObjectAsset> uxmlObjectAssets;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 parentId, System.Collections.Generic.List<UnityEngine.UIElements.UxmlObjectAsset> uxmlObjectAssets) { }

    }

    // TypeToken: 0x20002D1
    public struct AssetEntry
    {
        // Fields
        public System.String path;        // 0x10
        public System.String typeFullName;        // 0x18
        public UnityEngine.Object asset;        // 0x20
        private System.Type m_CachedType;        // 0x28

        // Methods
        private System.Type get_type() { }
        private System.Void .ctor(System.String path, System.Type type, UnityEngine.Object asset) { }

    }

    // TypeToken: 0x20002D8
    public class Area
    {
        // Fields
        public UnityEngine.RectInt rect;        // 0x10
        public UnityEngine.UIElements.UIR.BestFitAllocator allocator;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.RectInt rect) { }

    }

    // TypeToken: 0x20002D9
    public class Row : LinkedPoolItem`1
    {
        // Fields
        public UnityEngine.RectInt rect;        // 0x18
        public UnityEngine.UIElements.UIR.Allocator2D.Area area;        // 0x28
        public UnityEngine.UIElements.UIR.BestFitAllocator allocator;        // 0x30
        public UnityEngine.UIElements.UIR.Alloc alloc;        // 0x38
        public UnityEngine.UIElements.UIR.Allocator2D.Row next;        // 0x50
        public static readonly UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.Allocator2D.Row> pool;        // 0x0

        // Methods
        private UnityEngine.UIElements.UIR.Allocator2D.Row Create() { }
        private System.Void Reset(UnityEngine.UIElements.UIR.Allocator2D.Row row) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002DA
    public struct Alloc2D
    {
        // Fields
        public UnityEngine.RectInt rect;        // 0x10
        public UnityEngine.UIElements.UIR.Allocator2D.Row row;        // 0x20
        public UnityEngine.UIElements.UIR.Alloc alloc;        // 0x28

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.UIR.Allocator2D.Row row, UnityEngine.UIElements.UIR.Alloc alloc, System.Int32 width, System.Int32 height) { }

    }

    // TypeToken: 0x20002DC
    public struct RawTexture
    {
        // Fields
        public UnityEngine.Color32[] rgba;        // 0x10
        public System.Int32 width;        // 0x18
        public System.Int32 height;        // 0x1C

        // Methods
        private System.Void WriteRawInt2Packed(System.Int32 v0, System.Int32 v1, System.Int32 destX, System.Int32 destY) { }
        private System.Void WriteRawFloat4Packed(System.Single f0, System.Single f1, System.Single f2, System.Single f3, System.Int32 destX, System.Int32 destY) { }

    }

    // TypeToken: 0x20002E3
    public class Allocator : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.UIElements.MeshWriteData Invoke(System.UInt32 vertexCount, System.UInt32 indexCount, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData& allocatorData) { }

    }

    // TypeToken: 0x20002E2
    public struct AllocMeshData
    {
        // Fields
        private UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocator alloc;        // 0x10
        private UnityEngine.Texture texture;        // 0x18
        private UnityEngine.UIElements.TextureId svgTexture;        // 0x20
        private UnityEngine.Material material;        // 0x28
        private UnityEngine.UIElements.MeshGenerationContext.MeshFlags flags;        // 0x30
        private UnityEngine.UIElements.UIR.BMPAlloc colorAlloc;        // 0x34

        // Methods
        private UnityEngine.UIElements.MeshWriteData Allocate(System.UInt32 vertexCount, System.UInt32 indexCount) { }

    }

    // TypeToken: 0x20002E4
    public struct ClipCounts
    {
        // Fields
        public System.Int32 firstClippedIndex;        // 0x10
        public System.Int32 firstDegenerateIndex;        // 0x14
        public System.Int32 lastClippedIndex;        // 0x18
        public System.Int32 clippedTriangles;        // 0x1C
        public System.Int32 addedTriangles;        // 0x20
        public System.Int32 degenerateTriangles;        // 0x24

    }

    // TypeToken: 0x20002E5
    public struct VertexClipEdge
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdge None;        // 0x0
        public static UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdge Left;        // 0x0
        public static UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdge Top;        // 0x0
        public static UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdge Right;        // 0x0
        public static UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdge Bottom;        // 0x0

    }

    // TypeToken: 0x20002E8
    public struct DepthOrderedDirtyTracking
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> heads;        // 0x10
        public System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> tails;        // 0x18
        public System.Int32[] minDepths;        // 0x20
        public System.Int32[] maxDepths;        // 0x28
        public System.UInt32 dirtyID;        // 0x30

        // Methods
        private System.Void EnsureFits(System.Int32 maxDepth) { }
        private System.Void RegisterDirty(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderDataDirtyTypes dirtyTypes, UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses dirtyTypeClass) { }
        private System.Void ClearDirty(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderDataDirtyTypes dirtyTypesInverse) { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x20002E9
    public struct RenderChainStaticIndexAllocator
    {
        // Fields
        private static System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChain> renderChains;        // 0x0

        // Methods
        private System.Int32 AllocateIndex(UnityEngine.UIElements.UIR.RenderChain renderChain) { }
        private System.Void FreeIndex(System.Int32 index) { }
        private UnityEngine.UIElements.UIR.RenderChain AccessIndex(System.Int32 index) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002EA
    public struct RenderNodeData
    {
        // Fields
        public UnityEngine.Material standardMaterial;        // 0x10
        public UnityEngine.Material initialMaterial;        // 0x18
        public UnityEngine.MaterialPropertyBlock matPropBlock;        // 0x20
        public UnityEngine.UIElements.UIR.RenderChainCommand firstCommand;        // 0x28
        public UnityEngine.UIElements.UIR.UIRenderDevice device;        // 0x30
        public UnityEngine.Texture vectorAtlas;        // 0x38
        public UnityEngine.Texture shaderInfoAtlas;        // 0x40
        public System.Single dpiScale;        // 0x48
        public Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> transformConstants;        // 0x50
        public Unity.Collections.NativeSlice<UnityEngine.Vector4> clipRectConstants;        // 0x60

    }

    // TypeToken: 0x20002F9
    public struct Edges
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.UIR.Tessellation.Edges None;        // 0x0
        public static UnityEngine.UIElements.UIR.Tessellation.Edges Left;        // 0x0
        public static UnityEngine.UIElements.UIR.Tessellation.Edges Top;        // 0x0
        public static UnityEngine.UIElements.UIR.Tessellation.Edges Right;        // 0x0
        public static UnityEngine.UIElements.UIR.Tessellation.Edges Bottom;        // 0x0
        public static UnityEngine.UIElements.UIR.Tessellation.Edges All;        // 0x0

    }

    // TypeToken: 0x20002FC
    public struct BlitInfo
    {
        // Fields
        public UnityEngine.Texture src;        // 0x10
        public UnityEngine.RectInt srcRect;        // 0x18
        public UnityEngine.Vector2Int dstPos;        // 0x28
        public System.Int32 border;        // 0x30
        public UnityEngine.Color tint;        // 0x34

    }

    // TypeToken: 0x2000308
    public struct Page
    {
        // Fields
        public System.UInt16 x;        // 0x10
        public System.UInt16 y;        // 0x12
        public System.Int32 freeSlots;        // 0x14

    }

    // TypeToken: 0x200030D
    public struct AllocToUpdate
    {
        // Fields
        public System.UInt32 id;        // 0x10
        public System.UInt32 allocTime;        // 0x14
        public UnityEngine.UIElements.UIR.MeshHandle meshHandle;        // 0x18
        public UnityEngine.UIElements.UIR.Alloc permAllocVerts;        // 0x20
        public UnityEngine.UIElements.UIR.Alloc permAllocIndices;        // 0x38
        public UnityEngine.UIElements.UIR.Page permPage;        // 0x50
        public System.Boolean copyBackIndices;        // 0x58

    }

    // TypeToken: 0x200030E
    public struct AllocToFree
    {
        // Fields
        public UnityEngine.UIElements.UIR.Alloc alloc;        // 0x10
        public UnityEngine.UIElements.UIR.Page page;        // 0x28
        public System.Boolean vertices;        // 0x30

    }

    // TypeToken: 0x200030F
    public struct DeviceToFree
    {
        // Fields
        public System.UInt32 handle;        // 0x10
        public UnityEngine.UIElements.UIR.Page page;        // 0x18

        // Methods
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000310
    public struct EvaluationState
    {
        // Fields
        public UnityEngine.MaterialPropertyBlock stateMatProps;        // 0x10
        public UnityEngine.Material defaultMat;        // 0x18
        public UnityEngine.UIElements.UIR.State curState;        // 0x20
        public UnityEngine.UIElements.UIR.Page curPage;        // 0x40
        public System.Boolean mustApplyMaterial;        // 0x48
        public System.Boolean mustApplyCommonBlock;        // 0x49
        public System.Boolean mustApplyStateBlock;        // 0x4A
        public System.Boolean mustApplyStencil;        // 0x4B

    }

    // TypeToken: 0x2000311
    public struct DrawStatistics
    {
        // Fields
        public System.Int32 currentFrameIndex;        // 0x10
        public System.UInt32 totalIndices;        // 0x14
        public System.UInt32 commandCount;        // 0x18
        public System.UInt32 drawCommandCount;        // 0x1C
        public System.UInt32 materialSetCount;        // 0x20
        public System.UInt32 drawRangeCount;        // 0x24
        public System.UInt32 drawRangeCallCount;        // 0x28
        public System.UInt32 immediateDraws;        // 0x2C
        public System.UInt32 stencilRefChanges;        // 0x30

    }

    // TypeToken: 0x2000315
    public class BlockPool : LinkedPool`1
    {
        // Methods
        private UnityEngine.UIElements.UIR.BestFitAllocator.Block CreateBlock() { }
        private System.Void ResetBlock(UnityEngine.UIElements.UIR.BestFitAllocator.Block block) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000316
    public class Block : LinkedPoolItem`1
    {
        // Fields
        public System.UInt32 start;        // 0x18
        public System.UInt32 end;        // 0x1C
        public UnityEngine.UIElements.UIR.BestFitAllocator.Block prev;        // 0x20
        public UnityEngine.UIElements.UIR.BestFitAllocator.Block next;        // 0x28
        public UnityEngine.UIElements.UIR.BestFitAllocator.Block prevAvailable;        // 0x30
        public UnityEngine.UIElements.UIR.BestFitAllocator.Block nextAvailable;        // 0x38
        public System.Boolean allocated;        // 0x40

        // Methods
        private System.UInt32 get_size() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000319
    public class DataSet`1, IDisposable
    {
        // Fields
        private System.Boolean <disposed>k__BackingField;        // 0x0
        public UnityEngine.UIElements.UIR.Utility.GPUBuffer<T> gpuData;        // 0x0
        public Unity.Collections.NativeArray<T> cpuData;        // 0x0
        public Unity.Collections.NativeArray<UnityEngine.UIElements.UIR.GfxUpdateBufferRange> updateRanges;        // 0x0
        public UnityEngine.UIElements.UIR.GPUBufferAllocator allocator;        // 0x0
        private readonly System.UInt32 m_UpdateRangePoolSize;        // 0x0
        private System.UInt32 m_ElemStride;        // 0x0
        private System.UInt32 m_UpdateRangeMin;        // 0x0
        private System.UInt32 m_UpdateRangeMax;        // 0x0
        private System.UInt32 m_UpdateRangesEnqueued;        // 0x0
        private System.UInt32 m_UpdateRangesBatchStart;        // 0x0
        private System.Boolean m_UpdateRangesSaturated;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.UIR.Utility.GPUBufferType bufferType, System.UInt32 totalCount, System.UInt32 maxQueuedFrameCount, System.UInt32 updateRangePoolSize, System.Boolean mockBuffer) { }
        private System.Boolean get_disposed() { }
        private System.Void set_disposed(System.Boolean value) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void RegisterUpdate(System.UInt32 start, System.UInt32 size) { }
        private System.Boolean HasMappedBufferRange() { }
        private System.Void SendUpdates() { }
        private System.Void SendFullRange() { }
        private System.Void SendPartialRanges() { }
        private System.Void ResetUpdateState() { }

    }

    // TypeToken: 0x2000323
    public struct Entry
    {
        // Fields
        public Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices;        // 0x10
        public Unity.Collections.NativeSlice<System.UInt16> indices;        // 0x20
        public UnityEngine.Material material;        // 0x30
        public UnityEngine.Texture custom;        // 0x38
        public UnityEngine.Texture font;        // 0x40
        public System.Single fontTexSDFScale;        // 0x48
        public UnityEngine.UIElements.TextureId texture;        // 0x4C
        public UnityEngine.UIElements.UIR.RenderChainCommand customCommand;        // 0x50
        public UnityEngine.UIElements.UIR.BMPAlloc clipRectID;        // 0x58
        public UnityEngine.UIElements.UIR.VertexFlags addFlags;        // 0x60
        public System.Boolean uvIsDisplacement;        // 0x64
        public System.Boolean isTextEntry;        // 0x65
        public System.Boolean isClipRegisterEntry;        // 0x66
        public System.Int32 stencilRef;        // 0x68
        public System.Int32 maskDepth;        // 0x6C

    }

    // TypeToken: 0x2000324
    public struct ClosingInfo
    {
        // Fields
        public System.Boolean needsClosing;        // 0x10
        public System.Boolean popViewMatrix;        // 0x11
        public System.Boolean popScissorClip;        // 0x12
        public System.Boolean blitAndPopRenderTexture;        // 0x13
        public System.Boolean PopDefaultMaterial;        // 0x14
        public UnityEngine.UIElements.UIR.RenderChainCommand clipUnregisterDrawCommand;        // 0x18
        public Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> clipperRegisterVertices;        // 0x20
        public Unity.Collections.NativeSlice<System.UInt16> clipperRegisterIndices;        // 0x30
        public System.Int32 clipperRegisterIndexOffset;        // 0x40
        public System.Int32 maskStencilRef;        // 0x44

    }

    // TypeToken: 0x2000325
    public struct TempDataAlloc`1, IDisposable
    {
        // Fields
        private System.Int32 maxPoolElemCount;        // 0x0
        private Unity.Collections.NativeArray<T> pool;        // 0x0
        private System.Collections.Generic.List<Unity.Collections.NativeArray<T>> excess;        // 0x0
        private System.UInt32 takenFromPool;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 maxPoolElems) { }
        private System.Void Dispose() { }
        private Unity.Collections.NativeSlice<T> Alloc(System.UInt32 count) { }
        private System.Void SessionDone() { }

    }

    // TypeToken: 0x200032E
    public struct ColumnState
    {
        // Fields
        public System.Int32 index;        // 0x10
        public System.String name;        // 0x18
        public System.Single actualWidth;        // 0x20
        public UnityEngine.UIElements.Length width;        // 0x24
        public System.Boolean visible;        // 0x2C

    }

    // TypeToken: 0x200032D
    public class ViewState
    {
        // Fields
        private System.Boolean m_HasPersistedData;        // 0x10
        private System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> m_SortDescriptions;        // 0x18
        private System.Collections.Generic.List<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ViewState.ColumnState> m_OrderedColumnStates;        // 0x20

        // Methods
        private System.Void Save(UnityEngine.UIElements.Internal.MultiColumnCollectionHeader header) { }
        private System.Void Apply(UnityEngine.UIElements.Internal.MultiColumnCollectionHeader header) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200032F
    public class ColumnData
    {
        // Fields
        private UnityEngine.UIElements.Internal.MultiColumnHeaderColumn <control>k__BackingField;        // 0x10
        private UnityEngine.UIElements.Internal.MultiColumnHeaderColumnResizeHandle <resizeHandle>k__BackingField;        // 0x18

        // Methods
        private UnityEngine.UIElements.Internal.MultiColumnHeaderColumn get_control() { }
        private System.Void set_control(UnityEngine.UIElements.Internal.MultiColumnHeaderColumn value) { }
        private UnityEngine.UIElements.Internal.MultiColumnHeaderColumnResizeHandle get_resizeHandle() { }
        private System.Void set_resizeHandle(UnityEngine.UIElements.Internal.MultiColumnHeaderColumnResizeHandle value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000330
    public struct SortedColumnState
    {
        // Fields
        public UnityEngine.UIElements.SortColumnDescription columnDesc;        // 0x10
        public UnityEngine.UIElements.SortDirection direction;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.SortColumnDescription desc, UnityEngine.UIElements.SortDirection dir) { }

    }

    // TypeToken: 0x200033F
    public struct Unit
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StyleSheets.Dimension.Unit Unitless;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Dimension.Unit Pixel;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Dimension.Unit Percent;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Dimension.Unit Second;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Dimension.Unit Millisecond;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Dimension.Unit Degree;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Dimension.Unit Gradian;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Dimension.Unit Radian;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Dimension.Unit Turn;        // 0x0

    }

    // TypeToken: 0x2000344
    public class GetCursorIdFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int32 Invoke(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle handle) { }

    }

    // TypeToken: 0x2000349
    public struct SheetHandleKey
    {
        // Fields
        public readonly System.Int32 sheetInstanceID;        // 0x10
        public readonly System.Int32 index;        // 0x14

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.StyleSheet sheet, System.Int32 index) { }

    }

    // TypeToken: 0x200034A
    public class SheetHandleKeyComparer, IEqualityComparer`1
    {
        // Methods
        private System.Boolean Equals(UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey x, UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey y) { }
        private System.Int32 GetHashCode(UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey key) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000352
    public struct MatchContext
    {
        // Fields
        public System.Int32 valueIndex;        // 0x10
        public System.Int32 matchedVariableCount;        // 0x14

    }

    // TypeToken: 0x2000365
    public struct __StaticArrayInitTypeSize=108
    {
    }

namespace Microsoft.CodeAnalysis
{

    // TypeToken: 0x2000002
    public class EmbeddedAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000003
    public class IsReadOnlyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.UIElements
{

    // TypeToken: 0x2000004
    public class AlignmentUtils
    {
        // Methods
        private System.Single RoundToPixelGrid(System.Single v, System.Single pixelsPerPoint, System.Single offset) { }
        private System.Single CeilToPixelGrid(System.Single v, System.Single pixelsPerPoint, System.Single offset) { }

    }

    // TypeToken: 0x2000005
    public class AtlasBase
    {
        // Fields
        private UnityEngine.UIElements.TextureRegistry textureRegistry;        // 0x10

        // Methods
        private System.Boolean TryGetAtlas(UnityEngine.UIElements.VisualElement ctx, UnityEngine.Texture2D src, UnityEngine.UIElements.TextureId& atlas, UnityEngine.RectInt& atlasRect) { }
        private System.Void ReturnAtlas(UnityEngine.UIElements.VisualElement ctx, UnityEngine.Texture2D src, UnityEngine.UIElements.TextureId atlas) { }
        private System.Void Reset() { }
        private System.Void OnAssignedToPanel(UnityEngine.UIElements.IPanel panel) { }
        private System.Void OnRemovedFromPanel(UnityEngine.UIElements.IPanel panel) { }
        private System.Void OnUpdateDynamicTextures(UnityEngine.UIElements.IPanel panel) { }
        private System.Void InvokeAssignedToPanel(UnityEngine.UIElements.IPanel panel) { }
        private System.Void InvokeRemovedFromPanel(UnityEngine.UIElements.IPanel panel) { }
        private System.Void InvokeUpdateDynamicTextures(UnityEngine.UIElements.IPanel panel) { }
        private System.Void RepaintTexturedElements(UnityEngine.UIElements.IPanel panel) { }
        private System.Void SetDynamicTexture(UnityEngine.UIElements.TextureId id, UnityEngine.Texture texture) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public struct DynamicAtlasFilters
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.DynamicAtlasFilters None;        // 0x0
        public static UnityEngine.UIElements.DynamicAtlasFilters Readability;        // 0x0
        public static UnityEngine.UIElements.DynamicAtlasFilters Size;        // 0x0
        public static UnityEngine.UIElements.DynamicAtlasFilters Format;        // 0x0
        public static UnityEngine.UIElements.DynamicAtlasFilters ColorSpace;        // 0x0
        public static UnityEngine.UIElements.DynamicAtlasFilters FilterMode;        // 0x0

    }

    // TypeToken: 0x2000007
    public class DynamicAtlasCustomFilter : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(UnityEngine.Texture2D texture, UnityEngine.UIElements.DynamicAtlasFilters& filtersToApply) { }

    }

    // TypeToken: 0x2000008
    public class DynamicAtlas : AtlasBase
    {
        // Fields
        private System.Collections.Generic.Dictionary<UnityEngine.Texture,UnityEngine.UIElements.DynamicAtlas.TextureInfo> m_Database;        // 0x18
        private UnityEngine.UIElements.DynamicAtlasPage m_PointPage;        // 0x20
        private UnityEngine.UIElements.DynamicAtlasPage m_BilinearPage;        // 0x28
        private UnityEngine.ColorSpace m_ColorSpace;        // 0x30
        private System.Collections.Generic.List<UnityEngine.UIElements.IPanel> m_Panels;        // 0x38
        private System.Int32 m_MinAtlasSize;        // 0x40
        private System.Int32 m_MaxAtlasSize;        // 0x44
        private System.Int32 m_MaxSubTextureSize;        // 0x48
        private UnityEngine.UIElements.DynamicAtlasFilters m_ActiveFilters;        // 0x4C
        private UnityEngine.UIElements.DynamicAtlasCustomFilter m_CustomFilter;        // 0x50

        // Methods
        private System.Boolean get_isInitialized() { }
        private System.Void OnAssignedToPanel(UnityEngine.UIElements.IPanel panel) { }
        private System.Void OnRemovedFromPanel(UnityEngine.UIElements.IPanel panel) { }
        private System.Void Reset() { }
        private System.Void InitPages() { }
        private System.Void DestroyPages() { }
        private System.Boolean TryGetAtlas(UnityEngine.UIElements.VisualElement ve, UnityEngine.Texture2D src, UnityEngine.UIElements.TextureId& atlas, UnityEngine.RectInt& atlasRect) { }
        private System.Void ReturnAtlas(UnityEngine.UIElements.VisualElement ve, UnityEngine.Texture2D src, UnityEngine.UIElements.TextureId atlas) { }
        private System.Void OnUpdateDynamicTextures(UnityEngine.UIElements.IPanel panel) { }
        private System.Boolean IsTextureFormatSupported(UnityEngine.TextureFormat format) { }
        private System.Boolean IsTextureValid(UnityEngine.Texture2D texture, UnityEngine.FilterMode atlasFilterMode) { }
        private System.Void set_minAtlasSize(System.Int32 value) { }
        private System.Void set_maxAtlasSize(System.Int32 value) { }
        private UnityEngine.UIElements.DynamicAtlasFilters get_defaultFilters() { }
        private System.Void set_activeFilters(UnityEngine.UIElements.DynamicAtlasFilters value) { }
        private System.Int32 get_maxSubTextureSize() { }
        private System.Void set_maxSubTextureSize(System.Int32 value) { }
        private System.Void set_customFilter(UnityEngine.UIElements.DynamicAtlasCustomFilter value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000A
    public class BindableElement : VisualElement, IBindable
    {
        // Fields
        private UnityEngine.UIElements.IBinding <binding>k__BackingField;        // 0x3C0
        private System.String <bindingPath>k__BackingField;        // 0x3C8

        // Methods
        private UnityEngine.UIElements.IBinding get_binding() { }
        private System.Void set_bindingPath(System.String value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000D
    public class ClampedDragger`1 : Clickable
    {
        // Fields
        private System.Action dragging;        // 0x0
        private System.Action draggingEnded;        // 0x0
        private UnityEngine.UIElements.ClampedDragger.DragDirection<T> <dragDirection>k__BackingField;        // 0x0
        private UnityEngine.UIElements.BaseSlider<T> <slider>k__BackingField;        // 0x0
        private UnityEngine.Vector2 <startMousePosition>k__BackingField;        // 0x0

        // Methods
        private System.Void add_dragging(System.Action value) { }
        private System.Void remove_dragging(System.Action value) { }
        private System.Void add_draggingEnded(System.Action value) { }
        private System.Void remove_draggingEnded(System.Action value) { }
        private UnityEngine.UIElements.ClampedDragger.DragDirection<T> get_dragDirection() { }
        private System.Void set_dragDirection(UnityEngine.UIElements.ClampedDragger.DragDirection<T> value) { }
        private System.Void set_slider(UnityEngine.UIElements.BaseSlider<T> value) { }
        private UnityEngine.Vector2 get_startMousePosition() { }
        private System.Void set_startMousePosition(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_delta() { }
        private System.Void .ctor(UnityEngine.UIElements.BaseSlider<T> slider, System.Action clickHandler, System.Action dragHandler) { }
        private System.Void ProcessDownEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId) { }
        private System.Void ProcessUpEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId) { }
        private System.Void ProcessMoveEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition) { }

    }

    // TypeToken: 0x200000F
    public class Clickable : PointerManipulator
    {
        // Fields
        private System.Action<UnityEngine.UIElements.EventBase> clickedWithEventInfo;        // 0x38
        private System.Action clicked;        // 0x40
        private readonly System.Int64 m_Delay;        // 0x48
        private readonly System.Int64 m_Interval;        // 0x50
        private System.Boolean <active>k__BackingField;        // 0x58
        private UnityEngine.Vector2 <lastMousePosition>k__BackingField;        // 0x5C
        private System.Int32 m_ActivePointerId;        // 0x64
        private System.Boolean m_AcceptClicksIfDisabled;        // 0x68
        private UnityEngine.UIElements.IVisualElementScheduledItem m_Repeater;        // 0x70

        // Methods
        private System.Void add_clickedWithEventInfo(System.Action<UnityEngine.UIElements.EventBase> value) { }
        private System.Void remove_clickedWithEventInfo(System.Action<UnityEngine.UIElements.EventBase> value) { }
        private System.Void add_clicked(System.Action value) { }
        private System.Void remove_clicked(System.Action value) { }
        private System.Boolean get_active() { }
        private System.Void set_active(System.Boolean value) { }
        private UnityEngine.Vector2 get_lastMousePosition() { }
        private System.Void set_lastMousePosition(UnityEngine.Vector2 value) { }
        private System.Boolean get_acceptClicksIfDisabled() { }
        private System.Void set_acceptClicksIfDisabled(System.Boolean value) { }
        private UnityEngine.UIElements.InvokePolicy get_invokePolicy() { }
        private System.Void .ctor(System.Action handler, System.Int64 delay, System.Int64 interval) { }
        private System.Void .ctor(System.Action<UnityEngine.UIElements.EventBase> handler) { }
        private System.Void .ctor(System.Action handler) { }
        private System.Void OnTimer(UnityEngine.UIElements.TimerState timerState) { }
        private System.Boolean IsRepeatable() { }
        private System.Void RegisterCallbacksOnTarget() { }
        private System.Void UnregisterCallbacksFromTarget() { }
        private System.Void OnMouseDown(UnityEngine.UIElements.MouseDownEvent evt) { }
        private System.Void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent evt) { }
        private System.Void OnMouseUp(UnityEngine.UIElements.MouseUpEvent evt) { }
        private System.Void OnMouseCaptureOut(UnityEngine.UIElements.MouseCaptureOutEvent evt) { }
        private System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt) { }
        private System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt) { }
        private System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt) { }
        private System.Void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt) { }
        private System.Void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent evt) { }
        private System.Boolean ContainsPointer(System.Int32 pointerId) { }
        private System.Boolean IsNotMouseEvent(System.Int32 pointerId) { }
        private System.Void Invoke(UnityEngine.UIElements.EventBase evt) { }
        private System.Void SimulateSingleClick(UnityEngine.UIElements.EventBase evt, System.Int32 delayMs) { }
        private System.Void ProcessDownEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId) { }
        private System.Void ProcessMoveEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition) { }
        private System.Void ProcessUpEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId) { }
        private System.Void ProcessCancelEvent(UnityEngine.UIElements.EventBase evt, System.Int32 pointerId) { }
        private System.Void <SimulateSingleClick>b__43_0() { }

    }

    // TypeToken: 0x2000010
    public class ClickDetector
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.ClickDetector.ButtonClickStatus> m_ClickStatus;        // 0x10
        private static System.Int32 <s_DoubleClickTime>k__BackingField;        // 0x0

        // Methods
        private System.Int32 get_s_DoubleClickTime() { }
        private System.Void set_s_DoubleClickTime(System.Int32 value) { }
        private System.Void .ctor() { }
        private System.Void StartClickTracking(UnityEngine.UIElements.EventBase evt) { }
        private System.Void SendClickEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Void CancelClickTracking(UnityEngine.UIElements.EventBase evt) { }
        private System.Void ProcessEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Boolean ContainsPointer(UnityEngine.UIElements.VisualElement element, UnityEngine.Vector2 position) { }
        private System.Void Cleanup(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000012
    public class ContextualMenuManager
    {
        // Fields
        private System.Boolean <displayMenuHandledOSX>k__BackingField;        // 0x10

        // Methods
        private System.Boolean get_displayMenuHandledOSX() { }
        private System.Void set_displayMenuHandledOSX(System.Boolean value) { }
        private System.Void DisplayMenuIfEventMatches(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IEventHandler eventHandler) { }
        private System.Void DisplayMenu(UnityEngine.UIElements.EventBase triggerEvent, UnityEngine.UIElements.IEventHandler target) { }
        private System.Void DoDisplayMenu(UnityEngine.UIElements.DropdownMenu menu, UnityEngine.UIElements.EventBase triggerEvent) { }

    }

    // TypeToken: 0x2000013
    public class ContextualMenuManipulator : MouseManipulator
    {
        // Fields
        private System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent> m_MenuBuilder;        // 0x30

        // Methods
        private System.Void .ctor(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent> menuBuilder) { }
        private System.Void RegisterCallbacksOnTarget() { }
        private System.Void UnregisterCallbacksFromTarget() { }
        private System.Void OnMouseUpDownEvent(UnityEngine.UIElements.IMouseEvent evt) { }
        private System.Void OnMouseDownEventOSX(UnityEngine.UIElements.MouseDownEvent evt) { }
        private System.Void OnMouseUpEventOSX(UnityEngine.UIElements.MouseUpEvent evt) { }
        private System.Void OnKeyUpEvent(UnityEngine.UIElements.KeyUpEvent evt) { }
        private System.Void DoDisplayMenu(UnityEngine.UIElements.EventBase evt) { }
        private System.Void OnContextualMenuEvent(UnityEngine.UIElements.ContextualMenuPopulateEvent evt) { }

    }

    // TypeToken: 0x2000014
    public struct CountingBloomFilter
    {
        // Fields
        private UnityEngine.UIElements.CountingBloomFilter.<m_Counters>e__FixedBuffer m_Counters;        // 0x10

        // Methods
        private System.Void AdjustSlot(System.UInt32 index, System.Boolean increment) { }
        private System.UInt32 Hash1(System.UInt32 hash) { }
        private System.UInt32 Hash2(System.UInt32 hash) { }
        private System.Boolean IsSlotEmpty(System.UInt32 index) { }
        private System.Void InsertHash(System.UInt32 hash) { }
        private System.Void RemoveHash(System.UInt32 hash) { }
        private System.Boolean ContainsHash(System.UInt32 hash) { }

    }

    // TypeToken: 0x2000016
    public class AncestorFilter
    {
        // Fields
        private UnityEngine.UIElements.CountingBloomFilter m_CountingBloomFilter;        // 0x10
        private System.Collections.Generic.Stack<System.Int32> m_HashStack;        // 0x4010

        // Methods
        private System.Void .ctor() { }
        private System.Void AddHash(System.Int32 hash) { }
        private System.Boolean IsCandidate(UnityEngine.UIElements.StyleComplexSelector complexSel) { }
        private System.Void PushElement(UnityEngine.UIElements.VisualElement element) { }
        private System.Void PopElement() { }

    }

    // TypeToken: 0x2000017
    public struct Cursor, IEquatable`1
    {
        // Fields
        private UnityEngine.Texture2D <texture>k__BackingField;        // 0x10
        private UnityEngine.Vector2 <hotspot>k__BackingField;        // 0x18
        private System.Int32 <defaultCursorId>k__BackingField;        // 0x20

        // Methods
        private UnityEngine.Texture2D get_texture() { }
        private System.Void set_texture(UnityEngine.Texture2D value) { }
        private UnityEngine.Vector2 get_hotspot() { }
        private System.Void set_hotspot(UnityEngine.Vector2 value) { }
        private System.Int32 get_defaultCursorId() { }
        private System.Void set_defaultCursorId(System.Int32 value) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.UIElements.Cursor other) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.UIElements.Cursor style1, UnityEngine.UIElements.Cursor style2) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000018
    public interface ICursorManager
    {
        // Methods
        private System.Void SetCursor(UnityEngine.UIElements.Cursor cursor) { }
        private System.Void ResetCursor() { }

    }

    // TypeToken: 0x2000019
    public class CursorManager, ICursorManager
    {
        // Fields
        private System.Boolean <isCursorOverriden>k__BackingField;        // 0x10

        // Methods
        private System.Boolean get_isCursorOverriden() { }
        private System.Void set_isCursorOverriden(System.Boolean value) { }
        private System.Void SetCursor(UnityEngine.UIElements.Cursor cursor) { }
        private System.Void ResetCursor() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001A
    public class DefaultEventSystem
    {
        // Fields
        private static System.Func<System.Boolean> IsEditorRemoteConnected;        // 0x0
        private UnityEngine.UIElements.DefaultEventSystem.IInput m_Input;        // 0x10
        private readonly System.String m_HorizontalAxis;        // 0x18
        private readonly System.String m_VerticalAxis;        // 0x20
        private readonly System.String m_SubmitButton;        // 0x28
        private readonly System.String m_CancelButton;        // 0x30
        private readonly System.Single m_InputActionsPerSecond;        // 0x38
        private readonly System.Single m_RepeatDelay;        // 0x3C
        private System.Boolean m_SendingTouchEvents;        // 0x40
        private UnityEngine.Event m_Event;        // 0x48
        private UnityEngine.UIElements.BaseRuntimePanel m_FocusedPanel;        // 0x50
        private System.Int32 m_ConsecutiveMoveCount;        // 0x58
        private UnityEngine.Vector2 m_LastMoveVector;        // 0x5C
        private System.Single m_PrevActionTime;        // 0x64

        // Methods
        private System.Boolean get_isAppFocused() { }
        private UnityEngine.UIElements.DefaultEventSystem.IInput get_input() { }
        private UnityEngine.UIElements.DefaultEventSystem.IInput GetDefaultInput() { }
        private System.Boolean ShouldIgnoreEventsOnAppNotFocused() { }
        private UnityEngine.UIElements.BaseRuntimePanel get_focusedPanel() { }
        private System.Void set_focusedPanel(UnityEngine.UIElements.BaseRuntimePanel value) { }
        private System.Void Update(UnityEngine.UIElements.DefaultEventSystem.UpdateMode updateMode) { }
        private System.Void SendIMGUIEvents() { }
        private System.Void SendInputEvents() { }
        private System.Void SendFocusBasedEvent(System.Func<TArg,UnityEngine.UIElements.EventBase> evtFactory, TArg arg) { }
        private System.Void SendPositionBasedEvent(UnityEngine.Vector3 mousePosition, UnityEngine.Vector3 delta, System.Int32 pointerId, System.Nullable<System.Int32> targetDisplay, System.Func<UnityEngine.Vector3,UnityEngine.Vector3,TArg,UnityEngine.UIElements.EventBase> evtFactory, TArg arg, System.Boolean deselectIfNoTarget) { }
        private System.Void UpdateFocusedPanel(UnityEngine.UIElements.BaseRuntimePanel runtimePanel) { }
        private UnityEngine.UIElements.EventBase MakeTouchEvent(UnityEngine.Touch touch, UnityEngine.EventModifiers modifiers) { }
        private System.Boolean ProcessTouchEvents() { }
        private UnityEngine.Vector2 GetRawMoveVector() { }
        private System.Boolean ShouldSendMoveFromInput() { }
        private UnityEngine.Vector2 GetLocalScreenPosition(UnityEngine.Event evt, System.Nullable<System.Int32>& targetDisplay) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000020
    public class DisposeHelper
    {
        // Methods
        private System.Void NotifyDisposedUsed(System.IDisposable disposable) { }

    }

    // TypeToken: 0x2000021
    public class DropdownMenuEventInfo
    {
        // Fields
        private readonly UnityEngine.EventModifiers <modifiers>k__BackingField;        // 0x10
        private readonly UnityEngine.Vector2 <mousePosition>k__BackingField;        // 0x14
        private readonly UnityEngine.Vector2 <localMousePosition>k__BackingField;        // 0x1C
        private readonly System.Char <character>k__BackingField;        // 0x24
        private readonly UnityEngine.KeyCode <keyCode>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.EventBase e) { }

    }

    // TypeToken: 0x2000022
    public class DropdownMenuItem
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000023
    public class DropdownMenuSeparator : DropdownMenuItem
    {
        // Fields
        private readonly System.String <subMenuPath>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.String subMenuPath) { }

    }

    // TypeToken: 0x2000024
    public class DropdownMenuAction : DropdownMenuItem
    {
        // Fields
        private readonly System.String <name>k__BackingField;        // 0x10
        private UnityEngine.UIElements.DropdownMenuAction.Status <status>k__BackingField;        // 0x18
        private UnityEngine.UIElements.DropdownMenuEventInfo <eventInfo>k__BackingField;        // 0x20
        private System.Object <userData>k__BackingField;        // 0x28
        private readonly System.Action<UnityEngine.UIElements.DropdownMenuAction> actionCallback;        // 0x30
        private readonly System.Func<UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback;        // 0x38

        // Methods
        private System.Void set_status(UnityEngine.UIElements.DropdownMenuAction.Status value) { }
        private System.Void set_eventInfo(UnityEngine.UIElements.DropdownMenuEventInfo value) { }
        private System.Void set_userData(System.Object value) { }
        private UnityEngine.UIElements.DropdownMenuAction.Status AlwaysEnabled(UnityEngine.UIElements.DropdownMenuAction a) { }
        private UnityEngine.UIElements.DropdownMenuAction.Status AlwaysDisabled(UnityEngine.UIElements.DropdownMenuAction a) { }
        private System.Void .ctor(System.String actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> actionCallback, System.Func<UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback, System.Object userData) { }
        private System.Void UpdateActionStatus(UnityEngine.UIElements.DropdownMenuEventInfo eventInfo) { }

    }

    // TypeToken: 0x2000026
    public class DropdownMenu
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem> m_MenuItems;        // 0x10
        private UnityEngine.UIElements.DropdownMenuEventInfo m_DropdownMenuEventInfo;        // 0x18

        // Methods
        private System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem> MenuItems() { }
        private System.Void AppendAction(System.String actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> action, System.Func<UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback, System.Object userData) { }
        private System.Void AppendAction(System.String actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> action, UnityEngine.UIElements.DropdownMenuAction.Status status) { }
        private System.Void AppendSeparator(System.String subMenuPath) { }
        private System.Void InsertSeparator(System.String subMenuPath, System.Int32 atIndex) { }
        private System.Void PrepareForDisplay(UnityEngine.UIElements.EventBase e) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000028
    public class DropdownUtility
    {
        // Fields
        private static System.Func<UnityEngine.UIElements.IGenericMenu> MakeDropdownFunc;        // 0x0

        // Methods
        private UnityEngine.UIElements.IGenericMenu CreateDropdown() { }

    }

    // TypeToken: 0x2000029
    public struct DispatchMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.DispatchMode Default;        // 0x0
        public static UnityEngine.UIElements.DispatchMode Queued;        // 0x0
        public static UnityEngine.UIElements.DispatchMode Immediate;        // 0x0

    }

    // TypeToken: 0x200002A
    public struct EventDispatcherGate, IDisposable, IEquatable`1
    {
        // Fields
        private readonly UnityEngine.UIElements.EventDispatcher m_Dispatcher;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.EventDispatcher d) { }
        private System.Void Dispose() { }
        private System.Boolean Equals(UnityEngine.UIElements.EventDispatcherGate other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200002B
    public class EventDispatcher
    {
        // Fields
        private UnityEngine.UIElements.ClickDetector m_ClickDetector;        // 0x10
        private System.Collections.Generic.List<UnityEngine.UIElements.IEventDispatchingStrategy> m_DispatchingStrategies;        // 0x18
        private static readonly UnityEngine.UIElements.ObjectPool<System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord>> k_EventQueuePool;        // 0x0
        private System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord> m_Queue;        // 0x20
        private readonly UnityEngine.UIElements.PointerDispatchState <pointerState>k__BackingField;        // 0x28
        private System.UInt32 m_GateCount;        // 0x30
        private System.Collections.Generic.Stack<UnityEngine.UIElements.EventDispatcher.DispatchContext> m_DispatchContexts;        // 0x38
        private static readonly UnityEngine.UIElements.IEventDispatchingStrategy[] s_EditorStrategies;        // 0x8
        private System.Boolean m_Immediate;        // 0x40
        private System.Boolean <processingEvents>k__BackingField;        // 0x41

        // Methods
        private UnityEngine.UIElements.PointerDispatchState get_pointerState() { }
        private UnityEngine.UIElements.EventDispatcher CreateForRuntime(System.Collections.Generic.IList<UnityEngine.UIElements.IEventDispatchingStrategy> strategies) { }
        private System.Void .ctor(System.Collections.Generic.IList<UnityEngine.UIElements.IEventDispatchingStrategy> strategies) { }
        private System.Boolean get_dispatchImmediately() { }
        private System.Void set_processingEvents(System.Boolean value) { }
        private System.Void Dispatch(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.DispatchMode dispatchMode) { }
        private System.Void CloseGate() { }
        private System.Void OpenGate() { }
        private System.Void ProcessEventQueue() { }
        private System.Void ProcessEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel) { }
        private System.Void ApplyDispatchingStrategies(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel, System.Boolean imguiEventIsInitiallyUsed) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002E
    public class Focusable : CallbackEventHandler
    {
        // Fields
        private System.Boolean <focusable>k__BackingField;        // 0x20
        private System.Int32 <tabIndex>k__BackingField;        // 0x24
        private System.Boolean m_DelegatesFocus;        // 0x28
        private System.Boolean m_ExcludeFromFocusRing;        // 0x29

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.UIElements.FocusController get_focusController() { }
        private System.Boolean get_focusable() { }
        private System.Void set_focusable(System.Boolean value) { }
        private System.Int32 get_tabIndex() { }
        private System.Void set_tabIndex(System.Int32 value) { }
        private System.Boolean get_delegatesFocus() { }
        private System.Void set_delegatesFocus(System.Boolean value) { }
        private System.Boolean get_excludeFromFocusRing() { }
        private System.Void set_excludeFromFocusRing(System.Boolean value) { }
        private System.Boolean get_canGrabFocus() { }
        private System.Void Focus() { }
        private System.Void Blur() { }
        private System.Void BlurImmediately() { }
        private UnityEngine.UIElements.Focusable GetFocusDelegate() { }
        private UnityEngine.UIElements.Focusable GetFirstFocusableChild(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt) { }
        private System.Void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase evt) { }
        private System.Void ProcessEvent(UnityEngine.UIElements.EventBase evt) { }

    }

    // TypeToken: 0x200002F
    public class FocusChangeDirection, IDisposable
    {
        // Fields
        private static readonly UnityEngine.UIElements.FocusChangeDirection <unspecified>k__BackingField;        // 0x0
        private static readonly UnityEngine.UIElements.FocusChangeDirection <none>k__BackingField;        // 0x8
        private static readonly UnityEngine.UIElements.FocusChangeDirection <lastValue>k__BackingField;        // 0x10
        private readonly System.Int32 m_Value;        // 0x10

        // Methods
        private UnityEngine.UIElements.FocusChangeDirection get_unspecified() { }
        private UnityEngine.UIElements.FocusChangeDirection get_none() { }
        private UnityEngine.UIElements.FocusChangeDirection get_lastValue() { }
        private System.Void .ctor(System.Int32 value) { }
        private System.Int32 op_Implicit(UnityEngine.UIElements.FocusChangeDirection fcd) { }
        private System.Void System.IDisposable.Dispose() { }
        private System.Void Dispose() { }
        private System.Void ApplyTo(UnityEngine.UIElements.FocusController focusController, UnityEngine.UIElements.Focusable f) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000030
    public interface IFocusRing
    {
        // Methods
        private UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.EventBase e) { }
        private UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.FocusChangeDirection direction) { }

    }

    // TypeToken: 0x2000031
    public class FocusController
    {
        // Fields
        private readonly UnityEngine.UIElements.IFocusRing <focusRing>k__BackingField;        // 0x10
        private System.Collections.Generic.List<UnityEngine.UIElements.FocusController.FocusedElement> m_FocusedElements;        // 0x18
        private UnityEngine.UIElements.Focusable m_LastFocusedElement;        // 0x20
        private UnityEngine.UIElements.Focusable m_LastPendingFocusedElement;        // 0x28
        private System.Int32 m_PendingFocusCount;        // 0x30
        private System.Int32 <imguiKeyboardControl>k__BackingField;        // 0x34

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.IFocusRing focusRing) { }
        private UnityEngine.UIElements.IFocusRing get_focusRing() { }
        private UnityEngine.UIElements.Focusable get_focusedElement() { }
        private System.Boolean IsFocused(UnityEngine.UIElements.Focusable f) { }
        private UnityEngine.UIElements.Focusable GetRetargetedFocusedElement(UnityEngine.UIElements.VisualElement retargetAgainst) { }
        private UnityEngine.UIElements.Focusable GetLeafFocusedElement() { }
        private System.Boolean IsLocalElement(UnityEngine.UIElements.Focusable f) { }
        private System.Boolean IsPendingFocus(UnityEngine.UIElements.Focusable f) { }
        private System.Void SetFocusToLastFocusedElement() { }
        private System.Void BlurLastFocusedElement() { }
        private System.Void DoFocusChange(UnityEngine.UIElements.Focusable f) { }
        private UnityEngine.UIElements.Focusable FocusNextInDirection(UnityEngine.UIElements.FocusChangeDirection direction) { }
        private System.Void AboutToReleaseFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willGiveFocusTo, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.DispatchMode dispatchMode) { }
        private System.Void ReleaseFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willGiveFocusTo, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.DispatchMode dispatchMode) { }
        private System.Void AboutToGrabFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willTakeFocusFrom, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.DispatchMode dispatchMode) { }
        private System.Void GrabFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willTakeFocusFrom, UnityEngine.UIElements.FocusChangeDirection direction, System.Boolean bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode) { }
        private System.Void Blur(UnityEngine.UIElements.Focusable focusable, System.Boolean bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode) { }
        private System.Void SwitchFocus(UnityEngine.UIElements.Focusable newFocusedElement, System.Boolean bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode) { }
        private System.Void SwitchFocus(UnityEngine.UIElements.Focusable newFocusedElement, UnityEngine.UIElements.FocusChangeDirection direction, System.Boolean bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode) { }
        private UnityEngine.UIElements.Focusable SwitchFocusOnEvent(UnityEngine.UIElements.EventBase e) { }
        private System.Void ReevaluateFocus() { }
        private System.Boolean GetFocusableParentForPointerEvent(UnityEngine.UIElements.Focusable target, UnityEngine.UIElements.Focusable& effectiveTarget) { }
        private System.Int32 get_imguiKeyboardControl() { }
        private System.Void set_imguiKeyboardControl(System.Int32 value) { }
        private System.Void SyncIMGUIFocus(System.Int32 imguiKeyboardControlID, UnityEngine.UIElements.Focusable imguiContainerHavingKeyboardControl, System.Boolean forceSwitch) { }

    }

    // TypeToken: 0x2000033
    public class GroupBoxUtility
    {
        // Fields
        private static System.Collections.Generic.Dictionary<UnityEngine.UIElements.IGroupBox,UnityEngine.UIElements.IGroupManager> s_GroupManagers;        // 0x0
        private static System.Collections.Generic.Dictionary<UnityEngine.UIElements.IGroupBoxOption,UnityEngine.UIElements.IGroupManager> s_GroupOptionManagerCache;        // 0x8
        private static readonly System.Type k_GenericGroupBoxType;        // 0x10

        // Methods
        private System.Void RegisterGroupBoxOptionCallbacks(T option) { }
        private System.Void OnOptionSelected(T selectedOption) { }
        private System.Void OnOptionAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt) { }
        private System.Void OnOptionDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt) { }
        private UnityEngine.UIElements.IGroupManager FindOrCreateGroupManager(UnityEngine.UIElements.IGroupBox groupBox) { }
        private System.Void OnGroupBoxDetachedFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt) { }
        private System.Void OnPanelDestroyed(UnityEngine.UIElements.BaseVisualElementPanel panel) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000034
    public interface IGroupBoxOption
    {
        // Methods
        private System.Void SetSelected(System.Boolean selected) { }

    }

    // TypeToken: 0x2000035
    public interface IGroupBox
    {
    }

    // TypeToken: 0x2000036
    public interface IGroupBox`1 : IGroupBox
    {
    }

    // TypeToken: 0x2000037
    public interface IGroupManager
    {
        // Methods
        private System.Void OnOptionSelectionChanged(UnityEngine.UIElements.IGroupBoxOption selectedOption) { }
        private System.Void RegisterOption(UnityEngine.UIElements.IGroupBoxOption option) { }
        private System.Void UnregisterOption(UnityEngine.UIElements.IGroupBoxOption option) { }

    }

    // TypeToken: 0x2000038
    public class DefaultGroupManager, IGroupManager
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.IGroupBoxOption> m_GroupOptions;        // 0x10
        private UnityEngine.UIElements.IGroupBoxOption m_SelectedOption;        // 0x18

        // Methods
        private System.Void OnOptionSelectionChanged(UnityEngine.UIElements.IGroupBoxOption selectedOption) { }
        private System.Void RegisterOption(UnityEngine.UIElements.IGroupBoxOption option) { }
        private System.Void UnregisterOption(UnityEngine.UIElements.IGroupBoxOption option) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000039
    public class IMGUIContainer : VisualElement, IDisposable
    {
        // Fields
        private System.Action m_OnGUIHandler;        // 0x3C0
        private UnityEngine.ObjectGUIState m_ObjectGUIState;        // 0x3C8
        private System.Boolean useOwnerObjectGUIState;        // 0x3D0
        private UnityEngine.Rect <lastWorldClip>k__BackingField;        // 0x3D4
        private System.Boolean m_CullingEnabled;        // 0x3E4
        private System.Boolean m_IsFocusDelegated;        // 0x3E5
        private System.Boolean m_RefreshCachedLayout;        // 0x3E6
        private UnityEngine.GUILayoutUtility.LayoutCache m_Cache;        // 0x3E8
        private UnityEngine.Rect m_CachedClippingRect;        // 0x3F0
        private UnityEngine.Matrix4x4 m_CachedTransform;        // 0x400
        private UnityEngine.UIElements.ContextType <contextType>k__BackingField;        // 0x440
        private System.Boolean lostFocus;        // 0x444
        private System.Boolean receivedFocus;        // 0x445
        private UnityEngine.UIElements.FocusChangeDirection focusChangeDirection;        // 0x448
        private System.Boolean hasFocusableControls;        // 0x450
        private System.Int32 newKeyboardFocusControlID;        // 0x454
        private System.Boolean <focusOnlyIfHasFocusableControls>k__BackingField;        // 0x458
        public static readonly System.String ussClassName;        // 0x0
        private static readonly System.String ussFoldoutChildDepthClassName;        // 0x8
        private static readonly System.Collections.Generic.List<System.String> ussFoldoutChildDepthClassNames;        // 0x10
        private UnityEngine.UIElements.IMGUIContainer.GUIGlobals m_GUIGlobals;        // 0x45C
        private static readonly Unity.Profiling.ProfilerMarker k_OnGUIMarker;        // 0x18
        private static readonly Unity.Profiling.ProfilerMarker k_ImmediateCallbackMarker;        // 0x20
        private static UnityEngine.Event s_DefaultMeasureEvent;        // 0x28
        private static UnityEngine.Event s_MeasureEvent;        // 0x30
        private static UnityEngine.Event s_CurrentEvent;        // 0x38

        // Methods
        private System.Action get_onGUIHandler() { }
        private System.Void set_onGUIHandler(System.Action value) { }
        private UnityEngine.ObjectGUIState get_guiState() { }
        private UnityEngine.Rect get_lastWorldClip() { }
        private System.Void set_lastWorldClip(UnityEngine.Rect value) { }
        private System.Boolean get_cullingEnabled() { }
        private UnityEngine.GUILayoutUtility.LayoutCache get_cache() { }
        private System.Single get_layoutMeasuredWidth() { }
        private System.Single get_layoutMeasuredHeight() { }
        private UnityEngine.UIElements.ContextType get_contextType() { }
        private System.Void set_contextType(UnityEngine.UIElements.ContextType value) { }
        private System.Boolean get_focusOnlyIfHasFocusableControls() { }
        private System.Boolean get_canGrabFocus() { }
        private System.Void .cctor() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Action onGUIHandler) { }
        private System.Void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc) { }
        private System.Void SaveGlobals() { }
        private System.Void RestoreGlobals() { }
        private System.Void DoOnGUI(UnityEngine.Event evt, UnityEngine.Matrix4x4 parentTransform, UnityEngine.Rect clippingRect, System.Boolean isComputingLayout, UnityEngine.Rect layoutSize, System.Action onGUIHandler, System.Boolean canAffectFocus) { }
        private System.Void MarkDirtyLayout() { }
        private System.Void HandleEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Void DoIMGUIRepaint() { }
        private System.Boolean SendEventToIMGUI(UnityEngine.UIElements.EventBase evt, System.Boolean canAffectFocus, System.Boolean verifyBounds) { }
        private System.Boolean SendEventToIMGUIRaw(UnityEngine.UIElements.EventBase evt, System.Boolean canAffectFocus, System.Boolean verifyBounds) { }
        private System.Boolean VerifyBounds(UnityEngine.UIElements.EventBase evt) { }
        private System.Boolean IsContainerCapturingTheMouse() { }
        private System.Boolean IsLocalEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Boolean IsEventInsideLocalWindow(UnityEngine.UIElements.EventBase evt) { }
        private System.Boolean IsDockAreaMouseUp(UnityEngine.UIElements.EventBase evt) { }
        private System.Boolean HandleIMGUIEvent(UnityEngine.Event e, System.Boolean canAffectFocus) { }
        private System.Boolean HandleIMGUIEvent(UnityEngine.Event e, System.Action onGUIHandler, System.Boolean canAffectFocus) { }
        private System.Boolean HandleIMGUIEvent(UnityEngine.Event e, UnityEngine.Matrix4x4 worldTransform, UnityEngine.Rect clippingRect, System.Action onGUIHandler, System.Boolean canAffectFocus) { }
        private System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt) { }
        private System.Void SetFoldoutDepthClass() { }
        private UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode) { }
        private UnityEngine.Rect GetCurrentClipRect() { }
        private System.Void GetCurrentTransformAndClip(UnityEngine.UIElements.IMGUIContainer container, UnityEngine.Event evt, UnityEngine.Matrix4x4& transform, UnityEngine.Rect& clipRect) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposeManaged) { }
        private System.Void <DoOnGUI>b__56_0() { }

    }

    // TypeToken: 0x200003D
    public class ImmediateModeException : Exception
    {
        // Methods
        private System.Void .ctor(System.Exception inner) { }

    }

    // TypeToken: 0x200003E
    public struct SelectionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.SelectionType None;        // 0x0
        public static UnityEngine.UIElements.SelectionType Single;        // 0x0
        public static UnityEngine.UIElements.SelectionType Multiple;        // 0x0

    }

    // TypeToken: 0x200003F
    public interface ISerializableJsonDictionary
    {
        // Methods
        private System.Void Set(System.String key, T value) { }
        private T Get(System.String key) { }
        private System.Void Overwrite(System.Object obj, System.String key) { }
        private System.Boolean ContainsKey(System.String key) { }

    }

    // TypeToken: 0x2000040
    public interface ITransform
    {
        // Methods
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_scale() { }

    }

    // TypeToken: 0x2000041
    public struct KeyboardNavigationOperation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.KeyboardNavigationOperation None;        // 0x0
        public static UnityEngine.UIElements.KeyboardNavigationOperation SelectAll;        // 0x0
        public static UnityEngine.UIElements.KeyboardNavigationOperation Cancel;        // 0x0
        public static UnityEngine.UIElements.KeyboardNavigationOperation Submit;        // 0x0
        public static UnityEngine.UIElements.KeyboardNavigationOperation Previous;        // 0x0
        public static UnityEngine.UIElements.KeyboardNavigationOperation Next;        // 0x0
        public static UnityEngine.UIElements.KeyboardNavigationOperation MoveRight;        // 0x0
        public static UnityEngine.UIElements.KeyboardNavigationOperation MoveLeft;        // 0x0
        public static UnityEngine.UIElements.KeyboardNavigationOperation PageUp;        // 0x0
        public static UnityEngine.UIElements.KeyboardNavigationOperation PageDown;        // 0x0
        public static UnityEngine.UIElements.KeyboardNavigationOperation Begin;        // 0x0
        public static UnityEngine.UIElements.KeyboardNavigationOperation End;        // 0x0

    }

    // TypeToken: 0x2000042
    public class KeyboardNavigationManipulator : Manipulator
    {
        // Fields
        private readonly System.Action<UnityEngine.UIElements.KeyboardNavigationOperation,UnityEngine.UIElements.EventBase> m_Action;        // 0x18

        // Methods
        private System.Void .ctor(System.Action<UnityEngine.UIElements.KeyboardNavigationOperation,UnityEngine.UIElements.EventBase> action) { }
        private System.Void RegisterCallbacksOnTarget() { }
        private System.Void UnregisterCallbacksFromTarget() { }
        private System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt) { }
        private System.Void OnRuntimeKeyDown(UnityEngine.UIElements.KeyDownEvent evt) { }
        private System.Void OnEditorKeyDown(UnityEngine.UIElements.KeyDownEvent evt) { }
        private System.Void OnNavigationCancel(UnityEngine.UIElements.NavigationCancelEvent evt) { }
        private System.Void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent evt) { }
        private System.Void OnNavigationMove(UnityEngine.UIElements.NavigationMoveEvent evt) { }
        private System.Void Invoke(UnityEngine.UIElements.KeyboardNavigationOperation operation, UnityEngine.UIElements.EventBase evt) { }
        private UnityEngine.UIElements.KeyboardNavigationOperation <OnRuntimeKeyDown>g__GetOperation|5_0(UnityEngine.UIElements.KeyboardNavigationManipulator.<>c__DisplayClass5_0& ) { }
        private UnityEngine.UIElements.KeyboardNavigationOperation <OnEditorKeyDown>g__GetOperation|6_0(UnityEngine.UIElements.KeyboardNavigationManipulator.<>c__DisplayClass6_0& ) { }

    }

    // TypeToken: 0x2000045
    public struct ManipulatorActivationFilter, IEquatable`1
    {
        // Fields
        private UnityEngine.UIElements.MouseButton <button>k__BackingField;        // 0x10
        private UnityEngine.EventModifiers <modifiers>k__BackingField;        // 0x14
        private System.Int32 <clickCount>k__BackingField;        // 0x18

        // Methods
        private UnityEngine.UIElements.MouseButton get_button() { }
        private System.Void set_button(UnityEngine.UIElements.MouseButton value) { }
        private UnityEngine.EventModifiers get_modifiers() { }
        private System.Void set_modifiers(UnityEngine.EventModifiers value) { }
        private System.Int32 get_clickCount() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.UIElements.ManipulatorActivationFilter other) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Matches(UnityEngine.UIElements.IMouseEvent e) { }
        private System.Boolean HasModifiers(UnityEngine.UIElements.IMouseEvent e) { }
        private System.Boolean Matches(UnityEngine.UIElements.IPointerEvent e) { }
        private System.Boolean HasModifiers(UnityEngine.UIElements.IPointerEvent e) { }
        private System.Boolean MatchModifiers(System.Boolean alt, System.Boolean ctrl, System.Boolean shift, System.Boolean command) { }

    }

    // TypeToken: 0x2000046
    public interface IManipulator
    {
        // Methods
        private System.Void set_target(UnityEngine.UIElements.VisualElement value) { }

    }

    // TypeToken: 0x2000047
    public class Manipulator, IManipulator
    {
        // Fields
        private UnityEngine.UIElements.VisualElement m_Target;        // 0x10

        // Methods
        private System.Void RegisterCallbacksOnTarget() { }
        private System.Void UnregisterCallbacksFromTarget() { }
        private UnityEngine.UIElements.VisualElement get_target() { }
        private System.Void set_target(UnityEngine.UIElements.VisualElement value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000048
    public struct MouseButton
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.MouseButton LeftMouse;        // 0x0
        public static UnityEngine.UIElements.MouseButton RightMouse;        // 0x0
        public static UnityEngine.UIElements.MouseButton MiddleMouse;        // 0x0

    }

    // TypeToken: 0x2000049
    public class MouseCaptureController
    {
        // Methods
        private System.Boolean HasMouseCapture(UnityEngine.UIElements.IEventHandler handler) { }
        private System.Void CaptureMouse(UnityEngine.UIElements.IEventHandler handler) { }
        private System.Void ReleaseMouse(UnityEngine.UIElements.IEventHandler handler) { }

    }

    // TypeToken: 0x200004A
    public class MouseManipulator : Manipulator
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> <activators>k__BackingField;        // 0x18
        private UnityEngine.UIElements.ManipulatorActivationFilter m_currentActivator;        // 0x20

        // Methods
        private System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> get_activators() { }
        private System.Void set_activators(System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> value) { }
        private System.Void .ctor() { }
        private System.Boolean CanStartManipulation(UnityEngine.UIElements.IMouseEvent e) { }
        private System.Boolean CanStopManipulation(UnityEngine.UIElements.IMouseEvent e) { }

    }

    // TypeToken: 0x200004B
    public class ObjectPool`1
    {
        // Fields
        private readonly System.Collections.Generic.Stack<T> m_Stack;        // 0x0
        private System.Int32 m_MaxSize;        // 0x0

        // Methods
        private System.Int32 get_maxSize() { }
        private System.Void set_maxSize(System.Int32 value) { }
        private System.Void .ctor(System.Int32 maxSize) { }
        private System.Int32 Size() { }
        private T Get() { }
        private System.Void Release(T element) { }

    }

    // TypeToken: 0x200004C
    public struct ContextType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.ContextType Player;        // 0x0
        public static UnityEngine.UIElements.ContextType Editor;        // 0x0

    }

    // TypeToken: 0x200004D
    public struct VersionChangeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.VersionChangeType Bindings;        // 0x0
        public static UnityEngine.UIElements.VersionChangeType ViewData;        // 0x0
        public static UnityEngine.UIElements.VersionChangeType Hierarchy;        // 0x0
        public static UnityEngine.UIElements.VersionChangeType Layout;        // 0x0
        public static UnityEngine.UIElements.VersionChangeType StyleSheet;        // 0x0
        public static UnityEngine.UIElements.VersionChangeType Styles;        // 0x0
        public static UnityEngine.UIElements.VersionChangeType Overflow;        // 0x0
        public static UnityEngine.UIElements.VersionChangeType BorderRadius;        // 0x0
        public static UnityEngine.UIElements.VersionChangeType BorderWidth;        // 0x0
        public static UnityEngine.UIElements.VersionChangeType Transform;        // 0x0
        public static UnityEngine.UIElements.VersionChangeType Size;        // 0x0
        public static UnityEngine.UIElements.VersionChangeType Repaint;        // 0x0
        public static UnityEngine.UIElements.VersionChangeType Opacity;        // 0x0
        public static UnityEngine.UIElements.VersionChangeType Color;        // 0x0
        public static UnityEngine.UIElements.VersionChangeType RenderHints;        // 0x0
        public static UnityEngine.UIElements.VersionChangeType TransitionProperty;        // 0x0

    }

    // TypeToken: 0x200004E
    public struct UsageHints
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.UsageHints None;        // 0x0
        public static UnityEngine.UIElements.UsageHints DynamicTransform;        // 0x0
        public static UnityEngine.UIElements.UsageHints GroupTransform;        // 0x0
        public static UnityEngine.UIElements.UsageHints MaskContainer;        // 0x0
        public static UnityEngine.UIElements.UsageHints DynamicColor;        // 0x0

    }

    // TypeToken: 0x200004F
    public struct RenderHints
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.RenderHints None;        // 0x0
        public static UnityEngine.UIElements.RenderHints GroupTransform;        // 0x0
        public static UnityEngine.UIElements.RenderHints BoneTransform;        // 0x0
        public static UnityEngine.UIElements.RenderHints ClipWithScissors;        // 0x0
        public static UnityEngine.UIElements.RenderHints MaskContainer;        // 0x0
        public static UnityEngine.UIElements.RenderHints DynamicColor;        // 0x0
        public static UnityEngine.UIElements.RenderHints DirtyOffset;        // 0x0
        public static UnityEngine.UIElements.RenderHints DirtyGroupTransform;        // 0x0
        public static UnityEngine.UIElements.RenderHints DirtyBoneTransform;        // 0x0
        public static UnityEngine.UIElements.RenderHints DirtyClipWithScissors;        // 0x0
        public static UnityEngine.UIElements.RenderHints DirtyMaskContainer;        // 0x0
        public static UnityEngine.UIElements.RenderHints DirtyAll;        // 0x0

    }

    // TypeToken: 0x2000050
    public struct PanelClearSettings
    {
        // Fields
        public System.Boolean clearDepthStencil;        // 0x10
        public System.Boolean clearColor;        // 0x11
        public UnityEngine.Color color;        // 0x14

    }

    // TypeToken: 0x2000051
    public class RepaintData
    {
        // Fields
        private UnityEngine.Matrix4x4 <currentOffset>k__BackingField;        // 0x10
        private UnityEngine.Vector2 <mousePosition>k__BackingField;        // 0x50
        private UnityEngine.Rect <currentWorldClip>k__BackingField;        // 0x58
        private UnityEngine.Event <repaintEvent>k__BackingField;        // 0x68

        // Methods
        private UnityEngine.Matrix4x4 get_currentOffset() { }
        private UnityEngine.Rect get_currentWorldClip() { }
        private UnityEngine.Event get_repaintEvent() { }
        private System.Void set_repaintEvent(UnityEngine.Event value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000052
    public class HierarchyEvent : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType changeType) { }

    }

    // TypeToken: 0x2000053
    public interface IPanel : IDisposable
    {
        // Methods
        private UnityEngine.UIElements.VisualElement get_visualTree() { }
        private UnityEngine.UIElements.EventDispatcher get_dispatcher() { }
        private UnityEngine.UIElements.ContextType get_contextType() { }
        private UnityEngine.UIElements.FocusController get_focusController() { }
        private UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 point) { }

    }

    // TypeToken: 0x2000054
    public class BaseVisualElementPanel, IPanel, IDisposable, IGroupBox
    {
        // Fields
        private System.Action<UnityEngine.UIElements.BaseVisualElementPanel> panelDisposed;        // 0x10
        private System.Single m_Scale;        // 0x18
        private UnityEngine.Yoga.YogaConfig yogaConfig;        // 0x20
        private System.Single m_PixelsPerPoint;        // 0x28
        private UnityEngine.UIElements.PanelClearSettings <clearSettings>k__BackingField;        // 0x2C
        private System.Boolean <duringLayoutPhase>k__BackingField;        // 0x40
        private UnityEngine.UIElements.RepaintData <repaintData>k__BackingField;        // 0x48
        private UnityEngine.UIElements.ICursorManager <cursorManager>k__BackingField;        // 0x50
        private UnityEngine.UIElements.ContextualMenuManager <contextualMenuManager>k__BackingField;        // 0x58
        private System.Boolean <disposed>k__BackingField;        // 0x60
        private UnityEngine.UIElements.ElementUnderPointer m_TopElementUnderPointers;        // 0x68
        private System.Action standardShaderChanged;        // 0x70
        private System.Action standardWorldSpaceShaderChanged;        // 0x78
        private System.Action atlasChanged;        // 0x80
        private System.Action<UnityEngine.Material> updateMaterial;        // 0x88
        private UnityEngine.UIElements.HierarchyEvent hierarchyChanged;        // 0x90
        private System.Action<UnityEngine.UIElements.IPanel> beforeUpdate;        // 0x98

        // Methods
        private UnityEngine.EventInterests get_IMGUIEventInterests() { }
        private System.Void set_IMGUIEventInterests(UnityEngine.EventInterests value) { }
        private UnityEngine.ScriptableObject get_ownerObject() { }
        private System.Void set_ownerObject(UnityEngine.ScriptableObject value) { }
        private UnityEngine.UIElements.SavePersistentViewData get_saveViewData() { }
        private UnityEngine.UIElements.GetViewDataDictionary get_getViewDataDictionary() { }
        private System.Int32 get_IMGUIContainersCount() { }
        private System.Void set_IMGUIContainersCount(System.Int32 value) { }
        private UnityEngine.UIElements.FocusController get_focusController() { }
        private System.Void set_focusController(UnityEngine.UIElements.FocusController value) { }
        private UnityEngine.UIElements.IMGUIContainer get_rootIMGUIContainer() { }
        private System.Void add_panelDisposed(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value) { }
        private System.Void remove_panelDisposed(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value) { }
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Repaint(UnityEngine.Event e) { }
        private System.Void ValidateLayout() { }
        private System.Void UpdateAnimations() { }
        private System.Void UpdateBindings() { }
        private System.Void ApplyStyles() { }
        private System.Single get_scale() { }
        private System.Void set_scale(System.Single value) { }
        private System.Void set_pixelsPerPoint(System.Single value) { }
        private System.Single get_scaledPixelsPerPoint() { }
        private UnityEngine.UIElements.PanelClearSettings get_clearSettings() { }
        private System.Void set_clearSettings(UnityEngine.UIElements.PanelClearSettings value) { }
        private System.Boolean get_duringLayoutPhase() { }
        private System.Void set_duringLayoutPhase(System.Boolean value) { }
        private System.UInt32 get_version() { }
        private System.UInt32 get_hierarchyVersion() { }
        private System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ele, UnityEngine.UIElements.VersionChangeType changeTypeFlag) { }
        private UnityEngine.UIElements.RepaintData get_repaintData() { }
        private System.Void set_repaintData(UnityEngine.UIElements.RepaintData value) { }
        private UnityEngine.UIElements.ICursorManager get_cursorManager() { }
        private System.Void set_cursorManager(UnityEngine.UIElements.ICursorManager value) { }
        private UnityEngine.UIElements.ContextualMenuManager get_contextualMenuManager() { }
        private System.Void set_contextualMenuManager(UnityEngine.UIElements.ContextualMenuManager value) { }
        private UnityEngine.UIElements.VisualElement get_visualTree() { }
        private UnityEngine.UIElements.EventDispatcher get_dispatcher() { }
        private System.Void set_dispatcher(UnityEngine.UIElements.EventDispatcher value) { }
        private System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.UIElements.DispatchMode dispatchMode) { }
        private UnityEngine.UIElements.IScheduler get_scheduler() { }
        private UnityEngine.UIElements.IStylePropertyAnimationSystem get_styleAnimationSystem() { }
        private System.Void set_styleAnimationSystem(UnityEngine.UIElements.IStylePropertyAnimationSystem value) { }
        private UnityEngine.UIElements.ContextType get_contextType() { }
        private System.Void set_contextType(UnityEngine.UIElements.ContextType value) { }
        private UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 point) { }
        private UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked) { }
        private System.Boolean get_disposed() { }
        private System.Void set_disposed(System.Boolean value) { }
        private UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase) { }
        private UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(System.Int32 pointerId) { }
        private UnityEngine.UIElements.VisualElement RecomputeTopElementUnderPointer(System.Int32 pointerId, UnityEngine.Vector2 pointerPos, UnityEngine.UIElements.EventBase triggerEvent) { }
        private System.Void ClearCachedElementUnderPointer(System.Int32 pointerId, UnityEngine.UIElements.EventBase triggerEvent) { }
        private System.Void CommitElementUnderPointers() { }
        private UnityEngine.Shader get_standardShader() { }
        private UnityEngine.Shader get_standardWorldSpaceShader() { }
        private System.Void add_standardShaderChanged(System.Action value) { }
        private System.Void remove_standardShaderChanged(System.Action value) { }
        private System.Void add_standardWorldSpaceShaderChanged(System.Action value) { }
        private System.Void remove_standardWorldSpaceShaderChanged(System.Action value) { }
        private System.Void add_atlasChanged(System.Action value) { }
        private System.Void remove_atlasChanged(System.Action value) { }
        private System.Void InvokeAtlasChanged() { }
        private UnityEngine.UIElements.AtlasBase get_atlas() { }
        private System.Void set_atlas(UnityEngine.UIElements.AtlasBase value) { }
        private System.Void InvokeUpdateMaterial(UnityEngine.Material mat) { }
        private System.Void add_hierarchyChanged(UnityEngine.UIElements.HierarchyEvent value) { }
        private System.Void remove_hierarchyChanged(UnityEngine.UIElements.HierarchyEvent value) { }
        private System.Void InvokeHierarchyChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType changeType) { }
        private System.Void InvokeBeforeUpdate() { }
        private System.Void UpdateElementUnderPointers() { }
        private System.Void Update() { }

    }

    // TypeToken: 0x2000055
    public class LoadResourceFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.Object Invoke(System.String pathName, System.Type type, System.Single dpiScaling) { }

    }

    // TypeToken: 0x2000056
    public class TimeMsFunction : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int64 Invoke() { }

    }

    // TypeToken: 0x2000057
    public class GetViewDataDictionary : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private UnityEngine.UIElements.ISerializableJsonDictionary Invoke() { }

    }

    // TypeToken: 0x2000058
    public class SavePersistentViewData : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }

    }

    // TypeToken: 0x2000059
    public class Panel : BaseVisualElementPanel
    {
        // Fields
        private UnityEngine.UIElements.VisualElement m_RootContainer;        // 0xA0
        private UnityEngine.UIElements.VisualTreeUpdater m_VisualTreeUpdater;        // 0xA8
        private UnityEngine.UIElements.IStylePropertyAnimationSystem m_StylePropertyAnimationSystem;        // 0xB0
        private System.String m_PanelName;        // 0xB8
        private System.UInt32 m_Version;        // 0xC0
        private System.UInt32 m_RepaintVersion;        // 0xC4
        private System.UInt32 m_HierarchyVersion;        // 0xC8
        private Unity.Profiling.ProfilerMarker m_MarkerBeforeUpdate;        // 0xD0
        private Unity.Profiling.ProfilerMarker m_MarkerUpdate;        // 0xD8
        private Unity.Profiling.ProfilerMarker m_MarkerLayout;        // 0xE0
        private Unity.Profiling.ProfilerMarker m_MarkerBindings;        // 0xE8
        private Unity.Profiling.ProfilerMarker m_MarkerAnimations;        // 0xF0
        private static Unity.Profiling.ProfilerMarker s_MarkerPickAll;        // 0x0
        private UnityEngine.UIElements.EventDispatcher <dispatcher>k__BackingField;        // 0xF8
        private UnityEngine.UIElements.TimerEventScheduler m_Scheduler;        // 0x100
        private UnityEngine.ScriptableObject <ownerObject>k__BackingField;        // 0x108
        private UnityEngine.UIElements.ContextType <contextType>k__BackingField;        // 0x110
        private UnityEngine.UIElements.SavePersistentViewData <saveViewData>k__BackingField;        // 0x118
        private UnityEngine.UIElements.GetViewDataDictionary <getViewDataDictionary>k__BackingField;        // 0x120
        private UnityEngine.UIElements.FocusController <focusController>k__BackingField;        // 0x128
        private UnityEngine.EventInterests <IMGUIEventInterests>k__BackingField;        // 0x130
        private static UnityEngine.UIElements.LoadResourceFunction <loadResourceFunc>k__BackingField;        // 0x8
        private static UnityEngine.UIElements.TimeMsFunction <TimeSinceStartup>k__BackingField;        // 0x10
        private System.Int32 <IMGUIContainersCount>k__BackingField;        // 0x134
        private UnityEngine.UIElements.IMGUIContainer <rootIMGUIContainer>k__BackingField;        // 0x138
        private UnityEngine.Shader m_StandardShader;        // 0x140
        private UnityEngine.UIElements.AtlasBase m_Atlas;        // 0x148
        private System.Boolean m_ValidatingLayout;        // 0x150
        private static System.Action<UnityEngine.UIElements.Panel> beforeAnyRepaint;        // 0x18

        // Methods
        private UnityEngine.UIElements.VisualElement get_visualTree() { }
        private UnityEngine.UIElements.EventDispatcher get_dispatcher() { }
        private System.Void set_dispatcher(UnityEngine.UIElements.EventDispatcher value) { }
        private UnityEngine.UIElements.TimerEventScheduler get_timerEventScheduler() { }
        private UnityEngine.UIElements.IScheduler get_scheduler() { }
        private UnityEngine.UIElements.IStylePropertyAnimationSystem get_styleAnimationSystem() { }
        private System.Void set_styleAnimationSystem(UnityEngine.UIElements.IStylePropertyAnimationSystem value) { }
        private UnityEngine.ScriptableObject get_ownerObject() { }
        private System.Void set_ownerObject(UnityEngine.ScriptableObject value) { }
        private UnityEngine.UIElements.ContextType get_contextType() { }
        private System.Void set_contextType(UnityEngine.UIElements.ContextType value) { }
        private UnityEngine.UIElements.SavePersistentViewData get_saveViewData() { }
        private UnityEngine.UIElements.GetViewDataDictionary get_getViewDataDictionary() { }
        private UnityEngine.UIElements.FocusController get_focusController() { }
        private System.Void set_focusController(UnityEngine.UIElements.FocusController value) { }
        private UnityEngine.EventInterests get_IMGUIEventInterests() { }
        private System.Void set_IMGUIEventInterests(UnityEngine.EventInterests value) { }
        private UnityEngine.UIElements.LoadResourceFunction get_loadResourceFunc() { }
        private UnityEngine.Object LoadResource(System.String pathName, System.Type type, System.Single dpiScaling) { }
        private System.Void Focus() { }
        private System.Void Blur() { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Void CreateMarkers() { }
        private UnityEngine.UIElements.TimeMsFunction get_TimeSinceStartup() { }
        private System.Int32 get_IMGUIContainersCount() { }
        private System.Void set_IMGUIContainersCount(System.Int32 value) { }
        private UnityEngine.UIElements.IMGUIContainer get_rootIMGUIContainer() { }
        private System.UInt32 get_version() { }
        private System.UInt32 get_hierarchyVersion() { }
        private UnityEngine.Shader get_standardShader() { }
        private UnityEngine.UIElements.AtlasBase get_atlas() { }
        private System.Void set_atlas(UnityEngine.UIElements.AtlasBase value) { }
        private System.Void .ctor(UnityEngine.ScriptableObject ownerObject, UnityEngine.UIElements.ContextType contextType, UnityEngine.UIElements.EventDispatcher dispatcher) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Int64 TimeSinceStartupMs() { }
        private System.Int64 DefaultTimeSinceStartupMs() { }
        private UnityEngine.UIElements.VisualElement PickAll(UnityEngine.UIElements.VisualElement root, UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked) { }
        private UnityEngine.UIElements.VisualElement PerformPick(UnityEngine.UIElements.VisualElement root, UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked) { }
        private UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked) { }
        private UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 point) { }
        private System.Void ValidateLayout() { }
        private System.Void UpdateAnimations() { }
        private System.Void UpdateBindings() { }
        private System.Void ApplyStyles() { }
        private System.Void UpdateForRepaint() { }
        private System.Void Repaint(UnityEngine.Event e) { }
        private System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType) { }
        private UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase) { }
        private System.Void .cctor() { }
        private UnityEngine.Vector2Int <Pick>g__PixelOf|99_0(UnityEngine.Vector2 p) { }

    }

    // TypeToken: 0x200005A
    public class BaseRuntimePanel : Panel
    {
        // Fields
        private UnityEngine.GameObject m_SelectableGameObject;        // 0x158
        private static System.Int32 s_CurrentRuntimePanelCounter;        // 0x0
        private readonly System.Int32 m_RuntimePanelCreationIndex;        // 0x160
        private System.Single m_SortingPriority;        // 0x164
        private System.Action destroyed;        // 0x168
        private UnityEngine.Shader m_StandardWorldSpaceShader;        // 0x170
        private System.Boolean m_DrawToCameras;        // 0x178
        private UnityEngine.RenderTexture targetTexture;        // 0x180
        private UnityEngine.Matrix4x4 panelToWorld;        // 0x188
        private System.Int32 <targetDisplay>k__BackingField;        // 0x1C8
        private static readonly System.Func<UnityEngine.Vector2,UnityEngine.Vector2> DefaultScreenToPanelSpace;        // 0x8
        private System.Func<UnityEngine.Vector2,UnityEngine.Vector2> m_ScreenToPanelSpace;        // 0x1D0

        // Methods
        private UnityEngine.GameObject get_selectableGameObject() { }
        private System.Void set_selectableGameObject(UnityEngine.GameObject value) { }
        private System.Single get_sortingPriority() { }
        private System.Void set_sortingPriority(System.Single value) { }
        private System.Void add_destroyed(System.Action value) { }
        private System.Void remove_destroyed(System.Action value) { }
        private System.Void .ctor(UnityEngine.ScriptableObject ownerObject, UnityEngine.UIElements.EventDispatcher dispatcher) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private UnityEngine.Shader get_standardWorldSpaceShader() { }
        private System.Boolean get_drawToCameras() { }
        private System.Void set_drawToCameras(System.Boolean value) { }
        private System.Int32 get_targetDisplay() { }
        private System.Void set_targetDisplay(System.Int32 value) { }
        private System.Int32 get_screenRenderingWidth() { }
        private System.Int32 get_screenRenderingHeight() { }
        private System.Void Repaint(UnityEngine.Event e) { }
        private System.Func<UnityEngine.Vector2,UnityEngine.Vector2> get_screenToPanelSpace() { }
        private System.Void set_screenToPanelSpace(System.Func<UnityEngine.Vector2,UnityEngine.Vector2> value) { }
        private UnityEngine.Vector2 ScreenToPanel(UnityEngine.Vector2 screen) { }
        private System.Boolean ScreenToPanel(UnityEngine.Vector2 screenPosition, UnityEngine.Vector2 screenDelta, UnityEngine.Vector2& panelPosition, UnityEngine.Vector2& panelDelta, System.Boolean allowOutside) { }
        private System.Void AssignPanelToComponents(UnityEngine.UIElements.BaseRuntimePanel panel) { }
        private System.Void PointerLeavesPanel(System.Int32 pointerId, UnityEngine.Vector2 position) { }
        private System.Void PointerEntersPanel(System.Int32 pointerId, UnityEngine.Vector2 position) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005C
    public interface IRuntimePanelComponent
    {
        // Methods
        private System.Void set_panel(UnityEngine.UIElements.IPanel value) { }

    }

    // TypeToken: 0x200005D
    public class PointerCaptureHelper
    {
        // Methods
        private UnityEngine.UIElements.PointerDispatchState GetStateFor(UnityEngine.UIElements.IEventHandler handler) { }
        private System.Boolean HasPointerCapture(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId) { }
        private System.Void CapturePointer(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId) { }
        private System.Void ReleasePointer(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId) { }
        private UnityEngine.UIElements.IEventHandler GetCapturingElement(UnityEngine.UIElements.IPanel panel, System.Int32 pointerId) { }
        private System.Void ReleasePointer(UnityEngine.UIElements.IPanel panel, System.Int32 pointerId) { }
        private System.Void ActivateCompatibilityMouseEvents(UnityEngine.UIElements.IPanel panel, System.Int32 pointerId) { }
        private System.Void PreventCompatibilityMouseEvents(UnityEngine.UIElements.IPanel panel, System.Int32 pointerId) { }
        private System.Boolean ShouldSendCompatibilityMouseEvents(UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.IPointerEvent evt) { }
        private System.Void ProcessPointerCapture(UnityEngine.UIElements.IPanel panel, System.Int32 pointerId) { }

    }

    // TypeToken: 0x200005E
    public class PointerDispatchState
    {
        // Fields
        private UnityEngine.UIElements.IEventHandler[] m_PendingPointerCapture;        // 0x10
        private UnityEngine.UIElements.IEventHandler[] m_PointerCapture;        // 0x18
        private System.Boolean[] m_ShouldSendCompatibilityMouseEvents;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void Reset() { }
        private UnityEngine.UIElements.IEventHandler GetCapturingElement(System.Int32 pointerId) { }
        private System.Boolean HasPointerCapture(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId) { }
        private System.Void CapturePointer(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId) { }
        private System.Void ReleasePointer(System.Int32 pointerId) { }
        private System.Void ReleasePointer(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId) { }
        private System.Void ProcessPointerCapture(System.Int32 pointerId) { }
        private System.Void ActivateCompatibilityMouseEvents(System.Int32 pointerId) { }
        private System.Void PreventCompatibilityMouseEvents(System.Int32 pointerId) { }
        private System.Boolean ShouldSendCompatibilityMouseEvents(UnityEngine.UIElements.IPointerEvent evt) { }

    }

    // TypeToken: 0x200005F
    public class PointerManipulator : MouseManipulator
    {
        // Fields
        private System.Int32 m_CurrentPointerId;        // 0x30

        // Methods
        private System.Boolean CanStartManipulation(UnityEngine.UIElements.IPointerEvent e) { }
        private System.Boolean CanStopManipulation(UnityEngine.UIElements.IPointerEvent e) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000060
    public class ProjectionUtils
    {
        // Methods
        private UnityEngine.Matrix4x4 Ortho(System.Single left, System.Single right, System.Single bottom, System.Single top, System.Single near, System.Single far) { }

    }

    // TypeToken: 0x2000061
    public struct TimerState, IEquatable`1
    {
        // Fields
        private System.Int64 <start>k__BackingField;        // 0x10
        private System.Int64 <now>k__BackingField;        // 0x18

        // Methods
        private System.Int64 get_start() { }
        private System.Void set_start(System.Int64 value) { }
        private System.Int64 get_now() { }
        private System.Void set_now(System.Int64 value) { }
        private System.Int64 get_deltaTime() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.UIElements.TimerState other) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000062
    public interface IScheduler
    {
        // Methods
        private System.Void Unschedule(UnityEngine.UIElements.ScheduledItem item) { }
        private System.Void Schedule(UnityEngine.UIElements.ScheduledItem item) { }
        private System.Void UpdateScheduledEvents() { }

    }

    // TypeToken: 0x2000063
    public class ScheduledItem
    {
        // Fields
        public System.Func<System.Boolean> timerUpdateStopCondition;        // 0x10
        public static readonly System.Func<System.Boolean> OnceCondition;        // 0x0
        public static readonly System.Func<System.Boolean> ForeverCondition;        // 0x8
        private System.Int64 <startMs>k__BackingField;        // 0x18
        private System.Int64 <delayMs>k__BackingField;        // 0x20
        private System.Int64 <intervalMs>k__BackingField;        // 0x28
        private System.Int64 <endTimeMs>k__BackingField;        // 0x30

        // Methods
        private System.Int64 get_startMs() { }
        private System.Void set_startMs(System.Int64 value) { }
        private System.Int64 get_delayMs() { }
        private System.Void set_delayMs(System.Int64 value) { }
        private System.Int64 get_intervalMs() { }
        private System.Void set_intervalMs(System.Int64 value) { }
        private System.Int64 get_endTimeMs() { }
        private System.Void .ctor() { }
        private System.Void ResetStartTime() { }
        private System.Void PerformTimerUpdate(UnityEngine.UIElements.TimerState state) { }
        private System.Void OnItemUnscheduled() { }
        private System.Boolean ShouldUnschedule() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000065
    public class TimerEventScheduler, IScheduler
    {
        // Fields
        private readonly System.Collections.Generic.List<UnityEngine.UIElements.ScheduledItem> m_ScheduledItems;        // 0x10
        private System.Boolean m_TransactionMode;        // 0x18
        private readonly System.Collections.Generic.List<UnityEngine.UIElements.ScheduledItem> m_ScheduleTransactions;        // 0x20
        private readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.ScheduledItem> m_UnscheduleTransactions;        // 0x28
        private System.Boolean disableThrottling;        // 0x30
        private System.Int32 m_LastUpdatedIndex;        // 0x34

        // Methods
        private System.Void Schedule(UnityEngine.UIElements.ScheduledItem item) { }
        private System.Boolean RemovedScheduledItemAt(System.Int32 index) { }
        private System.Void Unschedule(UnityEngine.UIElements.ScheduledItem item) { }
        private System.Boolean PrivateUnSchedule(UnityEngine.UIElements.ScheduledItem sItem) { }
        private System.Void UpdateScheduledEvents() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000066
    public struct Spacing
    {
        // Fields
        public System.Single left;        // 0x10
        public System.Single top;        // 0x14
        public System.Single right;        // 0x18
        public System.Single bottom;        // 0x1C

        // Methods
        private System.Single get_horizontal() { }
        private System.Single get_vertical() { }
        private System.Void .ctor(System.Single left, System.Single top, System.Single right, System.Single bottom) { }
        private UnityEngine.Rect op_Subtraction(UnityEngine.Rect r, UnityEngine.UIElements.Spacing a) { }

    }

    // TypeToken: 0x2000067
    public struct Position
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.Position Relative;        // 0x0
        public static UnityEngine.UIElements.Position Absolute;        // 0x0

    }

    // TypeToken: 0x2000068
    public struct OverflowInternal
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.OverflowInternal Visible;        // 0x0
        public static UnityEngine.UIElements.OverflowInternal Hidden;        // 0x0
        public static UnityEngine.UIElements.OverflowInternal Scroll;        // 0x0

    }

    // TypeToken: 0x2000069
    public struct OverflowClipBox
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.OverflowClipBox PaddingBox;        // 0x0
        public static UnityEngine.UIElements.OverflowClipBox ContentBox;        // 0x0

    }

    // TypeToken: 0x200006A
    public struct FlexDirection
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.FlexDirection Column;        // 0x0
        public static UnityEngine.UIElements.FlexDirection ColumnReverse;        // 0x0
        public static UnityEngine.UIElements.FlexDirection Row;        // 0x0
        public static UnityEngine.UIElements.FlexDirection RowReverse;        // 0x0

    }

    // TypeToken: 0x200006B
    public struct Wrap
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.Wrap NoWrap;        // 0x0
        public static UnityEngine.UIElements.Wrap Wrap;        // 0x0
        public static UnityEngine.UIElements.Wrap WrapReverse;        // 0x0

    }

    // TypeToken: 0x200006C
    public struct Align
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.Align Auto;        // 0x0
        public static UnityEngine.UIElements.Align FlexStart;        // 0x0
        public static UnityEngine.UIElements.Align Center;        // 0x0
        public static UnityEngine.UIElements.Align FlexEnd;        // 0x0
        public static UnityEngine.UIElements.Align Stretch;        // 0x0

    }

    // TypeToken: 0x200006D
    public struct Justify
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.Justify FlexStart;        // 0x0
        public static UnityEngine.UIElements.Justify Center;        // 0x0
        public static UnityEngine.UIElements.Justify FlexEnd;        // 0x0
        public static UnityEngine.UIElements.Justify SpaceBetween;        // 0x0
        public static UnityEngine.UIElements.Justify SpaceAround;        // 0x0

    }

    // TypeToken: 0x200006E
    public struct TextOverflowPosition
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.TextOverflowPosition End;        // 0x0
        public static UnityEngine.UIElements.TextOverflowPosition Start;        // 0x0
        public static UnityEngine.UIElements.TextOverflowPosition Middle;        // 0x0

    }

    // TypeToken: 0x200006F
    public struct TextOverflow
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.TextOverflow Clip;        // 0x0
        public static UnityEngine.UIElements.TextOverflow Ellipsis;        // 0x0

    }

    // TypeToken: 0x2000070
    public struct TransformOriginOffset
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.TransformOriginOffset Left;        // 0x0
        public static UnityEngine.UIElements.TransformOriginOffset Right;        // 0x0
        public static UnityEngine.UIElements.TransformOriginOffset Top;        // 0x0
        public static UnityEngine.UIElements.TransformOriginOffset Bottom;        // 0x0
        public static UnityEngine.UIElements.TransformOriginOffset Center;        // 0x0

    }

    // TypeToken: 0x2000071
    public struct Visibility
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.Visibility Visible;        // 0x0
        public static UnityEngine.UIElements.Visibility Hidden;        // 0x0

    }

    // TypeToken: 0x2000072
    public struct WhiteSpace
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.WhiteSpace Normal;        // 0x0
        public static UnityEngine.UIElements.WhiteSpace NoWrap;        // 0x0

    }

    // TypeToken: 0x2000073
    public struct DisplayStyle
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.DisplayStyle Flex;        // 0x0
        public static UnityEngine.UIElements.DisplayStyle None;        // 0x0

    }

    // TypeToken: 0x2000074
    public interface IStylePainter
    {
        // Methods
        private System.Void DrawText(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint) { }
        private System.Void DrawRectangle(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams) { }
        private System.Void DrawImmediate(System.Action callback, System.Boolean cullingEnabled) { }

    }

    // TypeToken: 0x2000075
    public struct CursorPositionStylePainterParameters
    {
        // Fields
        public UnityEngine.Rect rect;        // 0x10
        public System.String text;        // 0x20
        public UnityEngine.Font font;        // 0x28
        public System.Int32 fontSize;        // 0x30
        public UnityEngine.FontStyle fontStyle;        // 0x34
        public UnityEngine.TextAnchor anchor;        // 0x38
        public System.Single wordWrapWidth;        // 0x3C
        public System.Boolean richText;        // 0x40
        public System.Int32 cursorIndex;        // 0x44

        // Methods
        private UnityEngine.UIElements.CursorPositionStylePainterParameters GetDefault(UnityEngine.UIElements.VisualElement ve, System.String text) { }
        private UnityEngine.UIElements.TextNativeSettings GetTextNativeSettings(System.Single scaling) { }

    }

    // TypeToken: 0x2000076
    public interface IStylePropertyAnimations
    {
        // Methods
        private System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Single from, System.Single to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 from, System.Int32 to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length from, UnityEngine.UIElements.Length to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color from, UnityEngine.Color to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartEnum(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 from, System.Int32 to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Background from, UnityEngine.UIElements.Background to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.FontDefinition from, UnityEngine.UIElements.FontDefinition to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Font from, UnityEngine.Font to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TextShadow from, UnityEngine.UIElements.TextShadow to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Scale from, UnityEngine.UIElements.Scale to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Translate from, UnityEngine.UIElements.Translate to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Rotate from, UnityEngine.UIElements.Rotate to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TransformOrigin from, UnityEngine.UIElements.TransformOrigin to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Void UpdateAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Void GetAllAnimations(System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds) { }
        private System.Void CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Void CancelAllAnimations() { }
        private System.Int32 get_runningAnimationCount() { }
        private System.Void set_runningAnimationCount(System.Int32 value) { }
        private System.Int32 get_completedAnimationCount() { }
        private System.Void set_completedAnimationCount(System.Int32 value) { }

    }

    // TypeToken: 0x2000077
    public class VisualElement : Focusable, IStylePropertyAnimations, ITransform, ITransitionAnimations, IExperimentalFeatures, IVisualElementScheduler, IResolvedStyle
    {
        // Fields
        private System.Int32 <UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField;        // 0x30
        private System.Int32 <UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField;        // 0x34
        private static System.UInt32 s_NextId;        // 0x0
        private static System.Collections.Generic.List<System.String> s_EmptyClassList;        // 0x8
        private static readonly UnityEngine.PropertyName userDataPropertyKey;        // 0x10
        public static readonly System.String disabledUssClassName;        // 0x18
        private System.String m_Name;        // 0x38
        private System.Collections.Generic.List<System.String> m_ClassList;        // 0x40
        private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.PropertyName,System.Object>> m_PropertyBag;        // 0x48
        private UnityEngine.UIElements.VisualElementFlags m_Flags;        // 0x50
        private System.String m_ViewDataKey;        // 0x58
        private UnityEngine.UIElements.RenderHints m_RenderHints;        // 0x60
        private UnityEngine.Rect lastLayout;        // 0x64
        private UnityEngine.Rect lastPseudoPadding;        // 0x74
        private UnityEngine.UIElements.UIR.RenderChainVEData renderChainData;        // 0x88
        private UnityEngine.Rect m_Layout;        // 0x1E0
        private UnityEngine.Rect m_BoundingBox;        // 0x1F0
        private UnityEngine.Rect m_WorldBoundingBox;        // 0x200
        private UnityEngine.Matrix4x4 m_WorldTransformCache;        // 0x210
        private UnityEngine.Matrix4x4 m_WorldTransformInverseCache;        // 0x250
        private UnityEngine.Rect m_WorldClip;        // 0x290
        private UnityEngine.Rect m_WorldClipMinusGroup;        // 0x2A0
        private System.Boolean m_WorldClipIsInfinite;        // 0x2B0
        private static readonly UnityEngine.Rect s_InfiniteRect;        // 0x20
        private UnityEngine.UIElements.PseudoStates triggerPseudoMask;        // 0x2B4
        private UnityEngine.UIElements.PseudoStates dependencyPseudoMask;        // 0x2B8
        private UnityEngine.UIElements.PseudoStates m_PseudoStates;        // 0x2BC
        private System.Int32 <containedPointerIds>k__BackingField;        // 0x2C0
        private UnityEngine.UIElements.PickingMode <pickingMode>k__BackingField;        // 0x2C4
        private UnityEngine.Yoga.YogaNode <yogaNode>k__BackingField;        // 0x2C8
        private UnityEngine.UIElements.ComputedStyle m_Style;        // 0x2D0
        private UnityEngine.UIElements.StyleVariableContext variableContext;        // 0x328
        private System.Int32 inheritedStylesHash;        // 0x330
        private readonly System.UInt32 controlid;        // 0x334
        private System.Int32 imguiContainerDescendantCount;        // 0x338
        private System.Boolean <enabledSelf>k__BackingField;        // 0x33C
        private UnityEngine.UIElements.LanguageDirection m_LanguageDirection;        // 0x340
        private UnityEngine.UIElements.LanguageDirection m_LocalLanguageDirection;        // 0x344
        private System.Action<UnityEngine.UIElements.MeshGenerationContext> <generateVisualContent>k__BackingField;        // 0x348
        private Unity.Profiling.ProfilerMarker k_GenerateVisualContentMarker;        // 0x350
        private UnityEngine.UIElements.VisualElement.RenderTargetMode m_SubRenderTargetMode;        // 0x358
        private static UnityEngine.Material s_runtimeMaterial;        // 0x30
        private UnityEngine.Material m_defaultMaterial;        // 0x360
        private System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_RunningAnimations;        // 0x368
        private static System.String k_RootVisualContainerName;        // 0x0
        private UnityEngine.UIElements.VisualElement.Hierarchy <hierarchy>k__BackingField;        // 0x370
        private System.Boolean <isRootVisualContainer>k__BackingField;        // 0x378
        private System.Boolean <cacheAsBitmap>k__BackingField;        // 0x379
        private UnityEngine.UIElements.VisualElement m_PhysicalParent;        // 0x380
        private UnityEngine.UIElements.VisualElement m_LogicalParent;        // 0x388
        private static readonly System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> s_EmptyList;        // 0x38
        private System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> m_Children;        // 0x390
        private UnityEngine.UIElements.BaseVisualElementPanel <elementPanel>k__BackingField;        // 0x398
        private UnityEngine.UIElements.VisualTreeAsset m_VisualTreeAssetSource;        // 0x3A0
        private static UnityEngine.UIElements.VisualElement.CustomStyleAccess s_CustomStyleAccess;        // 0x40
        private UnityEngine.UIElements.InlineStyleAccess inlineStyleAccess;        // 0x3A8
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> styleSheetList;        // 0x3B0
        private static readonly System.Text.RegularExpressions.Regex s_InternalStyleSheetPath;        // 0x48
        private static readonly UnityEngine.PropertyName tooltipPropertyKey;        // 0x50
        private static readonly System.Collections.Generic.Dictionary<System.Type,UnityEngine.UIElements.VisualElement.TypeData> s_TypeData;        // 0x58
        private UnityEngine.UIElements.VisualElement.TypeData m_TypeData;        // 0x3B8

        // Methods
        private System.Boolean get_hasRunningAnimations() { }
        private System.Boolean get_hasCompletedAnimations() { }
        private System.Int32 UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount() { }
        private System.Void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(System.Int32 value) { }
        private System.Int32 UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount() { }
        private System.Void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(System.Int32 value) { }
        private UnityEngine.UIElements.IStylePropertyAnimationSystem GetStylePropertyAnimationSystem() { }
        private UnityEngine.UIElements.IStylePropertyAnimations get_styleAnimation() { }
        private System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Single from, System.Single to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 from, System.Int32 to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length from, UnityEngine.UIElements.Length to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color from, UnityEngine.Color to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 from, System.Int32 to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Background from, UnityEngine.UIElements.Background to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.FontDefinition from, UnityEngine.UIElements.FontDefinition to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Font from, UnityEngine.Font to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TextShadow from, UnityEngine.UIElements.TextShadow to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Scale from, UnityEngine.UIElements.Scale to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Translate from, UnityEngine.UIElements.Translate to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Rotate from, UnityEngine.UIElements.Rotate to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TransformOrigin from, UnityEngine.UIElements.TransformOrigin to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations() { }
        private System.Void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds) { }
        private System.Boolean TryConvertLengthUnits(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length& from, UnityEngine.UIElements.Length& to, System.Int32 subPropertyIndex) { }
        private System.Boolean TryConvertTransformOriginUnits(UnityEngine.UIElements.TransformOrigin& from, UnityEngine.UIElements.TransformOrigin& to) { }
        private System.Boolean TryConvertTranslateUnits(UnityEngine.UIElements.Translate& from, UnityEngine.UIElements.Translate& to) { }
        private System.Nullable<System.Single> GetParentSizeForLengthConversion(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 subPropertyIndex) { }
        private System.Boolean get_isCompositeRoot() { }
        private System.Void set_isCompositeRoot(System.Boolean value) { }
        private System.Boolean get_isHierarchyDisplayed() { }
        private System.Void set_isHierarchyDisplayed(System.Boolean value) { }
        private System.String get_viewDataKey() { }
        private System.Void set_viewDataKey(System.String value) { }
        private System.Boolean get_enableViewDataPersistence() { }
        private System.Void set_enableViewDataPersistence(System.Boolean value) { }
        private System.Object get_userData() { }
        private System.Void set_userData(System.Object value) { }
        private System.Boolean get_canGrabFocus() { }
        private UnityEngine.UIElements.FocusController get_focusController() { }
        private UnityEngine.UIElements.UsageHints get_usageHints() { }
        private System.Void set_usageHints(UnityEngine.UIElements.UsageHints value) { }
        private UnityEngine.UIElements.RenderHints get_renderHints() { }
        private System.Void set_renderHints(UnityEngine.UIElements.RenderHints value) { }
        private System.Void MarkRenderHintsClean() { }
        private UnityEngine.UIElements.ITransform get_transform() { }
        private UnityEngine.Vector3 UnityEngine.UIElements.ITransform.get_position() { }
        private System.Void UnityEngine.UIElements.ITransform.set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 UnityEngine.UIElements.ITransform.get_scale() { }
        private System.Boolean get_isLayoutManual() { }
        private System.Void set_isLayoutManual(System.Boolean value) { }
        private System.Single get_scaledPixelsPerPoint() { }
        private UnityEngine.Rect get_layout() { }
        private System.Void set_layout(UnityEngine.Rect value) { }
        private System.Void ClearManualLayout() { }
        private UnityEngine.Rect get_contentRect() { }
        private UnityEngine.Rect get_paddingRect() { }
        private System.Boolean get_isBoundingBoxDirty() { }
        private System.Void set_isBoundingBoxDirty(System.Boolean value) { }
        private System.Boolean get_isWorldBoundingBoxDirty() { }
        private System.Void set_isWorldBoundingBoxDirty(System.Boolean value) { }
        private UnityEngine.Rect get_boundingBox() { }
        private UnityEngine.Rect get_worldBoundingBox() { }
        private UnityEngine.Rect get_boundingBoxInParentSpace() { }
        private System.Void UpdateBoundingBox() { }
        private System.Void UpdateWorldBoundingBox() { }
        private UnityEngine.Rect get_worldBound() { }
        private UnityEngine.Rect get_localBound() { }
        private UnityEngine.Rect get_rect() { }
        private System.Boolean get_isWorldTransformDirty() { }
        private System.Void set_isWorldTransformDirty(System.Boolean value) { }
        private System.Boolean get_isWorldTransformInverseDirty() { }
        private System.Void set_isWorldTransformInverseDirty(System.Boolean value) { }
        private UnityEngine.Matrix4x4 get_worldTransform() { }
        private UnityEngine.Matrix4x4& get_worldTransformRef() { }
        private UnityEngine.Matrix4x4& get_worldTransformInverse() { }
        private System.Void UpdateWorldTransform() { }
        private System.Void UpdateWorldTransformInverse() { }
        private System.Boolean get_isWorldClipDirty() { }
        private System.Void set_isWorldClipDirty(System.Boolean value) { }
        private UnityEngine.Rect get_worldClip() { }
        private UnityEngine.Rect get_worldClipMinusGroup() { }
        private System.Boolean get_worldClipIsInfinite() { }
        private System.Void EnsureWorldTransformAndClipUpToDate() { }
        private System.Void UpdateWorldClip() { }
        private UnityEngine.Rect CombineClipRects(UnityEngine.Rect rect, UnityEngine.Rect parentRect) { }
        private UnityEngine.Rect SubstractBorderPadding(UnityEngine.Rect worldRect) { }
        private UnityEngine.Rect ComputeAAAlignedBound(UnityEngine.Rect position, UnityEngine.Matrix4x4 mat) { }
        private UnityEngine.UIElements.PseudoStates get_pseudoStates() { }
        private System.Void set_pseudoStates(UnityEngine.UIElements.PseudoStates value) { }
        private System.Int32 get_containedPointerIds() { }
        private System.Void set_containedPointerIds(System.Int32 value) { }
        private System.Void UpdateHoverPseudoState() { }
        private UnityEngine.UIElements.PickingMode get_pickingMode() { }
        private System.Void set_pickingMode(UnityEngine.UIElements.PickingMode value) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Collections.Generic.List<System.String> get_classList() { }
        private System.String get_fullTypeName() { }
        private System.String get_typeName() { }
        private UnityEngine.Yoga.YogaNode get_yogaNode() { }
        private System.Void set_yogaNode(UnityEngine.Yoga.YogaNode value) { }
        private UnityEngine.UIElements.ComputedStyle& get_computedStyle() { }
        private System.Boolean get_hasInlineStyle() { }
        private System.Boolean get_styleInitialized() { }
        private System.Void set_styleInitialized(System.Boolean value) { }
        private System.Void ChangeIMGUIContainerCount(System.Int32 delta) { }
        private System.Void .ctor() { }
        private System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt) { }
        private UnityEngine.Rect GetTooltipRect() { }
        private System.Void SetTooltip(UnityEngine.UIElements.TooltipEvent e) { }
        private System.Void Focus() { }
        private System.Void SetPanel(UnityEngine.UIElements.BaseVisualElementPanel p) { }
        private System.Void WillChangePanel(UnityEngine.UIElements.BaseVisualElementPanel destinationPanel) { }
        private System.Void HasChangedPanel(UnityEngine.UIElements.BaseVisualElementPanel prevPanel) { }
        private System.Void SendEvent(UnityEngine.UIElements.EventBase e) { }
        private System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.UIElements.DispatchMode dispatchMode) { }
        private System.Void IncrementVersion(UnityEngine.UIElements.VersionChangeType changeType) { }
        private System.Void InvokeHierarchyChanged(UnityEngine.UIElements.HierarchyChangeType changeType) { }
        private System.Boolean SetEnabledFromHierarchyPrivate(System.Boolean state) { }
        private System.Boolean get_isParentEnabledInHierarchy() { }
        private System.Boolean get_enabledInHierarchy() { }
        private System.Boolean get_enabledSelf() { }
        private System.Void set_enabledSelf(System.Boolean value) { }
        private System.Void SetEnabled(System.Boolean value) { }
        private System.Void PropagateEnabledToChildren(System.Boolean value) { }
        private System.Boolean get_visible() { }
        private System.Void set_visible(System.Boolean value) { }
        private System.Void MarkDirtyRepaint() { }
        private System.Action<UnityEngine.UIElements.MeshGenerationContext> get_generateVisualContent() { }
        private System.Void set_generateVisualContent(System.Action<UnityEngine.UIElements.MeshGenerationContext> value) { }
        private System.Void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc) { }
        private System.Void GetFullHierarchicalViewDataKey(System.Text.StringBuilder key) { }
        private System.String GetFullHierarchicalViewDataKey() { }
        private T GetOrCreateViewData(System.Object existing, System.String key) { }
        private System.Void OverwriteFromViewData(System.Object obj, System.String key) { }
        private System.Void SaveViewData() { }
        private System.Boolean IsViewDataPersitenceSupportedOnChildren(System.Boolean existingState) { }
        private System.Void OnViewDataReady(System.Boolean enablePersistence) { }
        private System.Void OnViewDataReady() { }
        private System.Boolean ContainsPoint(UnityEngine.Vector2 localPoint) { }
        private System.Boolean get_requireMeasureFunction() { }
        private System.Void set_requireMeasureFunction(System.Boolean value) { }
        private System.Void AssignMeasureFunction() { }
        private System.Void RemoveMeasureFunction() { }
        private UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode) { }
        private UnityEngine.Yoga.YogaSize Measure(UnityEngine.Yoga.YogaNode node, System.Single width, UnityEngine.Yoga.YogaMeasureMode widthMode, System.Single height, UnityEngine.Yoga.YogaMeasureMode heightMode) { }
        private System.Void FinalizeLayout() { }
        private System.Void SetInlineRule(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleRule rule) { }
        private System.Void SetComputedStyle(UnityEngine.UIElements.ComputedStyle& newStyle) { }
        private System.String ToString() { }
        private System.Collections.Generic.List<System.String> GetClassesForIteration() { }
        private System.Void AddToClassList(System.String className) { }
        private System.Void RemoveFromClassList(System.String className) { }
        private System.Void EnableInClassList(System.String className, System.Boolean enable) { }
        private System.Boolean ClassListContains(System.String cls) { }
        private System.Object GetProperty(UnityEngine.PropertyName key) { }
        private System.Void SetProperty(UnityEngine.PropertyName key, System.Object value) { }
        private System.Boolean HasProperty(UnityEngine.PropertyName key) { }
        private System.Boolean TryGetPropertyInternal(UnityEngine.PropertyName key, System.Object& value) { }
        private System.Void CheckUserKeyArgument(UnityEngine.PropertyName key) { }
        private System.Void SetPropertyInternal(UnityEngine.PropertyName key, System.Object value) { }
        private System.Void UpdateCursorStyle(System.Int64 eventType) { }
        private UnityEngine.UIElements.VisualElement.RenderTargetMode get_subRenderTargetMode() { }
        private UnityEngine.Material get_defaultMaterial() { }
        private UnityEngine.UIElements.VisualElementAnimationSystem GetAnimationSystem() { }
        private System.Void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim) { }
        private System.Void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim) { }
        private System.Void UnregisterRunningAnimations() { }
        private System.Void RegisterRunningAnimations() { }
        private UnityEngine.UIElements.Experimental.ValueAnimation<T> StartAnimation(UnityEngine.UIElements.Experimental.ValueAnimation<T> anim, System.Func<UnityEngine.UIElements.VisualElement,T> fromValueGetter, T to, System.Int32 durationMs, System.Action<UnityEngine.UIElements.VisualElement,T> onValueChanged) { }
        private System.Void AssignStyleValues(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.Experimental.StyleValues src) { }
        private UnityEngine.UIElements.Experimental.StyleValues ReadCurrentValues(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.Experimental.StyleValues targetValuesToRead) { }
        private UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.UIElements.Experimental.StyleValues to, System.Int32 durationMs) { }
        private UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(System.Func<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.Experimental.StyleValues> fromValueGetter, UnityEngine.UIElements.Experimental.StyleValues to, System.Int32 durationMs) { }
        private UnityEngine.UIElements.IExperimentalFeatures get_experimental() { }
        private UnityEngine.UIElements.Experimental.ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.get_animation() { }
        private UnityEngine.UIElements.VisualElement.Hierarchy get_hierarchy() { }
        private System.Void set_hierarchy(UnityEngine.UIElements.VisualElement.Hierarchy value) { }
        private System.Boolean get_isRootVisualContainer() { }
        private System.Void set_isRootVisualContainer(System.Boolean value) { }
        private System.Boolean get_disableClipping() { }
        private System.Void set_disableClipping(System.Boolean value) { }
        private System.Boolean ShouldClip() { }
        private UnityEngine.UIElements.VisualElement get_parent() { }
        private UnityEngine.UIElements.BaseVisualElementPanel get_elementPanel() { }
        private System.Void set_elementPanel(UnityEngine.UIElements.BaseVisualElementPanel value) { }
        private UnityEngine.UIElements.IPanel get_panel() { }
        private UnityEngine.UIElements.VisualElement get_contentContainer() { }
        private System.Void set_visualTreeAssetSource(UnityEngine.UIElements.VisualTreeAsset value) { }
        private System.Void Add(UnityEngine.UIElements.VisualElement child) { }
        private System.Void Insert(System.Int32 index, UnityEngine.UIElements.VisualElement element) { }
        private System.Void Clear() { }
        private UnityEngine.UIElements.VisualElement ElementAt(System.Int32 index) { }
        private UnityEngine.UIElements.VisualElement get_Item(System.Int32 key) { }
        private System.Int32 get_childCount() { }
        private System.Int32 IndexOf(UnityEngine.UIElements.VisualElement element) { }
        private UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List<System.Int32> childIndexes) { }
        private System.Boolean FindElementInTree(UnityEngine.UIElements.VisualElement element, System.Collections.Generic.List<System.Int32> outChildIndexes) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children() { }
        private System.Void BringToFront() { }
        private System.Void SendToBack() { }
        private System.Void PlaceBehind(UnityEngine.UIElements.VisualElement sibling) { }
        private System.Void RemoveFromHierarchy() { }
        private T GetFirstOfType() { }
        private T GetFirstAncestorOfType() { }
        private System.Boolean Contains(UnityEngine.UIElements.VisualElement child) { }
        private System.Void GatherAllChildren(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements) { }
        private UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement other) { }
        private UnityEngine.UIElements.VisualElement GetRoot() { }
        private UnityEngine.UIElements.VisualElement GetRootVisualContainer() { }
        private UnityEngine.UIElements.VisualElement GetNextElementDepthFirst() { }
        private UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst() { }
        private UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement retargetAgainst) { }
        private UnityEngine.Vector3 get_positionWithLayout() { }
        private System.Void GetPivotedMatrixWithLayout(UnityEngine.Matrix4x4& result) { }
        private System.Boolean get_hasDefaultRotationAndScale() { }
        private System.Single Min(System.Single a, System.Single b, System.Single c, System.Single d) { }
        private System.Single Max(System.Single a, System.Single b, System.Single c, System.Single d) { }
        private System.Void TransformAlignedRectToParentSpace(UnityEngine.Rect& rect) { }
        private UnityEngine.Rect CalculateConservativeRect(UnityEngine.Matrix4x4& matrix, UnityEngine.Rect rect) { }
        private System.Void TransformAlignedRect(UnityEngine.Matrix4x4& matrix, UnityEngine.Rect& rect) { }
        private System.Void OrderMinMaxRect(UnityEngine.Rect& rect) { }
        private UnityEngine.Vector2 MultiplyMatrix44Point2(UnityEngine.Matrix4x4& lhs, UnityEngine.Vector2 point) { }
        private UnityEngine.Vector2 MultiplyVector2(UnityEngine.Matrix4x4& lhs, UnityEngine.Vector2 vector) { }
        private System.Void MultiplyMatrix34(UnityEngine.Matrix4x4& lhs, UnityEngine.Matrix4x4& rhs, UnityEngine.Matrix4x4& res) { }
        private System.Void TranslateMatrix34(UnityEngine.Matrix4x4& lhs, UnityEngine.Vector3 rhs, UnityEngine.Matrix4x4& res) { }
        private System.Void TranslateMatrix34InPlace(UnityEngine.Matrix4x4& lhs, UnityEngine.Vector3 rhs) { }
        private UnityEngine.UIElements.IVisualElementScheduler get_schedule() { }
        private UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action<UnityEngine.UIElements.TimerState> timerUpdateEvent) { }
        private UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action updateEvent) { }
        private UnityEngine.UIElements.IStyle get_style() { }
        private UnityEngine.UIElements.ICustomStyle get_customStyle() { }
        private UnityEngine.UIElements.VisualElementStyleSheetSet get_styleSheets() { }
        private System.Void AddStyleSheetPath(System.String sheetPath) { }
        private UnityEngine.UIElements.StyleFloat ResolveLengthValue(UnityEngine.UIElements.Length length, System.Boolean isRow) { }
        private UnityEngine.Vector3 ResolveTranslate() { }
        private UnityEngine.Vector3 ResolveTransformOrigin() { }
        private UnityEngine.Quaternion ResolveRotation() { }
        private UnityEngine.Vector3 ResolveScale() { }
        private System.String get_tooltip() { }
        private System.Void set_tooltip(System.String value) { }
        private UnityEngine.UIElements.VisualElement.TypeData get_typeData() { }
        private UnityEngine.UIElements.IResolvedStyle get_resolvedStyle() { }
        private UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_backgroundColor() { }
        private UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth() { }
        private UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth() { }
        private UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_borderRightColor() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth() { }
        private UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_borderTopColor() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_bottom() { }
        private UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_color() { }
        private UnityEngine.UIElements.DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }
        private UnityEngine.UIElements.FlexDirection UnityEngine.UIElements.IResolvedStyle.get_flexDirection() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_flexGrow() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_flexShrink() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_height() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_left() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_marginBottom() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_marginLeft() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_marginRight() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_marginTop() { }
        private UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minHeight() { }
        private UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minWidth() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_opacity() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_paddingBottom() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_paddingLeft() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_paddingRight() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_paddingTop() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_right() { }
        private UnityEngine.UIElements.Scale UnityEngine.UIElements.IResolvedStyle.get_scale() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_top() { }
        private UnityEngine.Vector3 UnityEngine.UIElements.IResolvedStyle.get_transformOrigin() { }
        private UnityEngine.Vector3 UnityEngine.UIElements.IResolvedStyle.get_translate() { }
        private UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor() { }
        private System.Int32 UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft() { }
        private System.Int32 UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight() { }
        private UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth() { }
        private UnityEngine.UIElements.Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }
        private UnityEngine.UIElements.WhiteSpace UnityEngine.UIElements.IResolvedStyle.get_whiteSpace() { }
        private System.Single UnityEngine.UIElements.IResolvedStyle.get_width() { }
        private System.Void .cctor() { }
        private UnityEngine.Yoga.YogaSize <AssignMeasureFunction>b__262_0(UnityEngine.Yoga.YogaNode node, System.Single f, UnityEngine.Yoga.YogaMeasureMode mode, System.Single f1, UnityEngine.Yoga.YogaMeasureMode heightMode) { }

    }

    // TypeToken: 0x2000084
    public interface IStylePropertyAnimationSystem
    {
        // Methods
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, System.Single startValue, System.Single endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, System.Int32 startValue, System.Int32 endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Length startValue, UnityEngine.UIElements.Length endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Color startValue, UnityEngine.Color endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Background startValue, UnityEngine.UIElements.Background endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.FontDefinition startValue, UnityEngine.UIElements.FontDefinition endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Font startValue, UnityEngine.Font endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TextShadow startValue, UnityEngine.UIElements.TextShadow endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Scale startValue, UnityEngine.UIElements.Scale endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TransformOrigin startValue, UnityEngine.UIElements.TransformOrigin endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Translate startValue, UnityEngine.UIElements.Translate endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Rotate startValue, UnityEngine.UIElements.Rotate endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Void CancelAllAnimations() { }
        private System.Void CancelAllAnimations(UnityEngine.UIElements.VisualElement owner) { }
        private System.Void CancelAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Void UpdateAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Void GetAllAnimations(UnityEngine.UIElements.VisualElement owner, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds) { }
        private System.Void Update() { }

    }

    // TypeToken: 0x2000085
    public class StylePropertyAnimationSystem, IStylePropertyAnimationSystem
    {
        // Fields
        private System.Int64 m_CurrentTimeMs;        // 0x10
        private UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesFloat m_Floats;        // 0x18
        private UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesInt m_Ints;        // 0x20
        private UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesLength m_Lengths;        // 0x28
        private UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesColor m_Colors;        // 0x30
        private UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesBackground m_Backgrounds;        // 0x38
        private UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesFontDefinition m_FontDefinitions;        // 0x40
        private UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesFont m_Fonts;        // 0x48
        private UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesTextShadow m_TextShadows;        // 0x50
        private UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesScale m_Scale;        // 0x58
        private UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesRotate m_Rotate;        // 0x60
        private UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesTranslate m_Translate;        // 0x68
        private UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesTransformOrigin m_TransformOrigin;        // 0x70
        private readonly System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyAnimationSystem.Values> m_AllValues;        // 0x78
        private readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StylePropertyId,UnityEngine.UIElements.StylePropertyAnimationSystem.Values> m_PropertyToValues;        // 0x80

        // Methods
        private System.Void .ctor() { }
        private T GetOrCreate(T& values) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, T startValue, T endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve, UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T> values) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, System.Single startValue, System.Single endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, System.Int32 startValue, System.Int32 endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Length startValue, UnityEngine.UIElements.Length endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Color startValue, UnityEngine.Color endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Background startValue, UnityEngine.UIElements.Background endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.FontDefinition startValue, UnityEngine.UIElements.FontDefinition endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Font startValue, UnityEngine.Font endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TextShadow startValue, UnityEngine.UIElements.TextShadow endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Scale startValue, UnityEngine.UIElements.Scale endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Rotate startValue, UnityEngine.UIElements.Rotate endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Translate startValue, UnityEngine.UIElements.Translate endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TransformOrigin startValue, UnityEngine.UIElements.TransformOrigin endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Void CancelAllAnimations() { }
        private System.Void CancelAllAnimations(UnityEngine.UIElements.VisualElement owner) { }
        private System.Void CancelAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Void UpdateAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Void GetAllAnimations(UnityEngine.UIElements.VisualElement owner, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds) { }
        private System.Void UpdateTracking(UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T> values) { }
        private System.Int64 CurrentTimeMs() { }
        private System.Void Update() { }

    }

    // TypeToken: 0x200009E
    public struct StylePropertyName, IEquatable`1
    {
        // Fields
        private readonly UnityEngine.UIElements.StyleSheets.StylePropertyId <id>k__BackingField;        // 0x10
        private readonly System.String <name>k__BackingField;        // 0x18

        // Methods
        private UnityEngine.UIElements.StyleSheets.StylePropertyId get_id() { }
        private System.String get_name() { }
        private UnityEngine.UIElements.StyleSheets.StylePropertyId StylePropertyIdFromString(System.String name) { }
        private System.Void .ctor(UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId) { }
        private System.Void .ctor(System.String name) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.StylePropertyName lhs, UnityEngine.UIElements.StylePropertyName rhs) { }
        private System.Boolean op_Inequality(UnityEngine.UIElements.StylePropertyName lhs, UnityEngine.UIElements.StylePropertyName rhs) { }
        private UnityEngine.UIElements.StylePropertyName op_Implicit(System.String name) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object other) { }
        private System.Boolean Equals(UnityEngine.UIElements.StylePropertyName other) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200009F
    public class TemplateContainer : BindableElement
    {
        // Fields
        private System.String <templateId>k__BackingField;        // 0x3D0
        private UnityEngine.UIElements.VisualElement m_ContentContainer;        // 0x3D8
        private UnityEngine.UIElements.VisualTreeAsset m_TemplateSource;        // 0x3E0

        // Methods
        private System.String get_templateId() { }
        private System.Void set_templateId(System.String value) { }
        private System.Void set_templateSource(UnityEngine.UIElements.VisualTreeAsset value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String templateId) { }
        private UnityEngine.UIElements.VisualElement get_contentContainer() { }
        private System.Void SetContentContainer(UnityEngine.UIElements.VisualElement content) { }

    }

    // TypeToken: 0x20000A2
    public interface ITextElement
    {
        // Methods
        private System.String get_text() { }

    }

    // TypeToken: 0x20000A3
    public class TextElement : BindableElement, ITextElement, INotifyValueChanged`1
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        private UnityEngine.UIElements.ITextHandle m_TextHandle;        // 0x3D0
        private static System.Int32 maxTextVertices;        // 0x8
        private System.String m_Text;        // 0x3D8
        private System.Boolean m_EnableRichText;        // 0x3E0
        private System.Boolean m_DisplayTooltipWhenElided;        // 0x3E1
        private System.Boolean <isElided>k__BackingField;        // 0x3E2
        private static readonly System.String k_EllipsisText;        // 0x10
        private System.Boolean m_WasElided;        // 0x3E3
        private System.Boolean m_UpdateTextParams;        // 0x3E4
        private UnityEngine.UIElements.MeshGenerationContextUtils.TextParams m_TextParams;        // 0x3E8
        private System.Int32 m_PreviousTextParamsHashCode;        // 0x480

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.UIElements.ITextHandle get_textHandle() { }
        private System.Void set_textHandle(UnityEngine.UIElements.ITextHandle value) { }
        private System.Void HandleEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e) { }
        private System.String get_text() { }
        private System.Void set_text(System.String value) { }
        private System.Boolean get_enableRichText() { }
        private System.Void set_enableRichText(System.Boolean value) { }
        private System.Boolean get_displayTooltipWhenElided() { }
        private System.Void set_displayTooltipWhenElided(System.Boolean value) { }
        private System.Boolean get_isElided() { }
        private System.Void set_isElided(System.Boolean value) { }
        private System.Void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc) { }
        private System.String ElideText(System.String drawText, System.String ellipsisText, System.Single width, UnityEngine.UIElements.TextOverflowPosition textOverflowPosition) { }
        private System.Void UpdateTooltip() { }
        private System.Void UpdateVisibleText() { }
        private System.Boolean ShouldElide() { }
        private System.Boolean TextLibraryCanElide() { }
        private UnityEngine.Vector2 MeasureTextSize(System.String textToMeasure, System.Single width, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single height, UnityEngine.UIElements.VisualElement.MeasureMode heightMode) { }
        private UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode) { }
        private System.String UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value() { }
        private System.Void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(System.String value) { }
        private System.Void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(System.String newValue) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A6
    public struct TextShadow, IEquatable`1
    {
        // Fields
        public UnityEngine.Vector2 offset;        // 0x10
        public System.Single blurRadius;        // 0x18
        public UnityEngine.Color color;        // 0x1C

        // Methods
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.UIElements.TextShadow other) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.UIElements.TextShadow style1, UnityEngine.UIElements.TextShadow style2) { }
        private System.Boolean op_Inequality(UnityEngine.UIElements.TextShadow style1, UnityEngine.UIElements.TextShadow style2) { }
        private System.String ToString() { }
        private UnityEngine.UIElements.TextShadow LerpUnclamped(UnityEngine.UIElements.TextShadow a, UnityEngine.UIElements.TextShadow b, System.Single t) { }

    }

    // TypeToken: 0x20000A7
    public class UIElementsPackageUtility
    {
        // Fields
        private static readonly System.String EditorResourcesBasePath;        // 0x0
        private static readonly System.Boolean IsUIEPackageLoaded;        // 0x8

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000A8
    public class UIElementsRuntimeUtility
    {
        // Fields
        private static System.Action<UnityEngine.UIElements.BaseRuntimePanel> onCreatePanel;        // 0x0
        private static System.Boolean s_RegisteredPlayerloopCallback;        // 0x8
        private static System.Collections.Generic.List<UnityEngine.UIElements.Panel> s_SortedRuntimePanels;        // 0x10
        private static System.Boolean s_PanelOrderingDirty;        // 0x18
        private static readonly System.String s_RepaintProfilerMarkerName;        // 0x20
        private static readonly Unity.Profiling.ProfilerMarker s_RepaintProfilerMarker;        // 0x28
        private static System.Int32 currentOverlayIndex;        // 0x30
        private static UnityEngine.Object <activeEventSystem>k__BackingField;        // 0x38
        private static UnityEngine.UIElements.DefaultEventSystem s_DefaultEventSystem;        // 0x40
        private static System.Collections.Generic.List<UnityEngine.UIElements.PanelSettings> s_PotentiallyEmptyPanelSettings;        // 0x48

        // Methods
        private System.Void add_onCreatePanel(System.Action<UnityEngine.UIElements.BaseRuntimePanel> value) { }
        private System.Void remove_onCreatePanel(System.Action<UnityEngine.UIElements.BaseRuntimePanel> value) { }
        private System.Void .cctor() { }
        private UnityEngine.UIElements.EventBase CreateEvent(UnityEngine.Event systemEvent) { }
        private UnityEngine.UIElements.BaseRuntimePanel FindOrCreateRuntimePanel(UnityEngine.ScriptableObject ownerObject, UnityEngine.UIElements.UIElementsRuntimeUtility.CreateRuntimePanelDelegate createDelegate) { }
        private System.Void DisposeRuntimePanel(UnityEngine.ScriptableObject ownerObject) { }
        private System.Void RegisterCachedPanelInternal(System.Int32 instanceID, UnityEngine.UIElements.IPanel panel) { }
        private System.Void RemoveCachedPanelInternal(System.Int32 instanceID) { }
        private System.Void RepaintOffscreenPanels() { }
        private System.Void RepaintOverlayPanel(UnityEngine.UIElements.BaseRuntimePanel panel) { }
        private System.Void BeginRenderOverlays(System.Int32 displayIndex) { }
        private System.Void RenderOverlaysBeforePriority(System.Int32 displayIndex, System.Single maxPriority) { }
        private System.Void EndRenderOverlays(System.Int32 displayIndex) { }
        private UnityEngine.Object get_activeEventSystem() { }
        private System.Void set_activeEventSystem(UnityEngine.Object value) { }
        private System.Boolean get_useDefaultEventSystem() { }
        private System.Void RegisterEventSystem(UnityEngine.Object eventSystem) { }
        private System.Void UnregisterEventSystem(UnityEngine.Object eventSystem) { }
        private UnityEngine.UIElements.DefaultEventSystem get_defaultEventSystem() { }
        private System.Void UpdateRuntimePanels() { }
        private System.Void MarkPotentiallyEmpty(UnityEngine.UIElements.PanelSettings settings) { }
        private System.Void RemoveUnusedPanels() { }
        private System.Void RegisterPlayerloopCallback() { }
        private System.Void UnregisterPlayerloopCallback() { }
        private System.Void SetPanelOrderingDirty() { }
        private System.Collections.Generic.List<UnityEngine.UIElements.Panel> GetSortedPlayerPanels() { }
        private System.Void SortPanels() { }
        private UnityEngine.Vector2 MultiDisplayBottomLeftToPanelPosition(UnityEngine.Vector2 position, System.Nullable<System.Int32>& targetDisplay) { }
        private UnityEngine.Vector2 MultiDisplayToLocalScreenPosition(UnityEngine.Vector2 position, System.Nullable<System.Int32>& targetDisplay) { }
        private UnityEngine.Vector2 ScreenBottomLeftToPanelPosition(UnityEngine.Vector2 position, System.Int32 targetDisplay) { }
        private UnityEngine.Vector2 ScreenBottomLeftToPanelDelta(UnityEngine.Vector2 delta) { }

    }

    // TypeToken: 0x20000AB
    public interface IUIElementsUtility
    {
        // Methods
        private System.Boolean TakeCapture() { }
        private System.Boolean ReleaseCapture() { }
        private System.Boolean ProcessEvent(System.Int32 instanceID, System.IntPtr nativeEventPtr, System.Boolean& eventHandled) { }
        private System.Boolean CleanupRoots() { }
        private System.Boolean EndContainerGUIFromException(System.Exception exception) { }
        private System.Boolean MakeCurrentIMGUIContainerDirty() { }

    }

    // TypeToken: 0x20000AC
    public class UIEventRegistration
    {
        // Fields
        private static System.Collections.Generic.List<UnityEngine.UIElements.IUIElementsUtility> s_Utilities;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.Void RegisterUIElementSystem(UnityEngine.UIElements.IUIElementsUtility utility) { }
        private System.Void TakeCapture() { }
        private System.Void ReleaseCapture() { }
        private System.Boolean EndContainerGUIFromException(System.Exception exception) { }
        private System.Boolean ProcessEvent(System.Int32 instanceID, System.IntPtr nativeEventPtr) { }
        private System.Void CleanupRoots() { }
        private System.Void MakeCurrentIMGUIContainerDirty() { }

    }

    // TypeToken: 0x20000AE
    public class UIElementsUtility, IUIElementsUtility
    {
        // Fields
        private static System.Collections.Generic.Stack<UnityEngine.UIElements.IMGUIContainer> s_ContainerStack;        // 0x0
        private static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.Panel> s_UIElementsCache;        // 0x8
        private static UnityEngine.Event s_EventInstance;        // 0x10
        private static UnityEngine.Color editorPlayModeTintColor;        // 0x18
        private static System.Single singleLineHeight;        // 0x28
        private static UnityEngine.UIElements.UIElementsUtility s_Instance;        // 0x30
        private static System.Collections.Generic.List<UnityEngine.UIElements.Panel> s_PanelsIterationList;        // 0x38
        private static readonly System.String s_RepaintProfilerMarkerName;        // 0x40
        private static readonly System.String s_EventProfilerMarkerName;        // 0x48
        private static readonly Unity.Profiling.ProfilerMarker s_RepaintProfilerMarker;        // 0x50
        private static readonly Unity.Profiling.ProfilerMarker s_EventProfilerMarker;        // 0x58

        // Methods
        private System.Void .ctor() { }
        private System.Boolean UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty() { }
        private System.Boolean UnityEngine.UIElements.IUIElementsUtility.TakeCapture() { }
        private System.Boolean UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture() { }
        private System.Boolean UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(System.Int32 instanceID, System.IntPtr nativeEventPtr, System.Boolean& eventHandled) { }
        private System.Boolean UnityEngine.UIElements.IUIElementsUtility.CleanupRoots() { }
        private System.Boolean UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(System.Exception exception) { }
        private System.Void RegisterCachedPanel(System.Int32 instanceID, UnityEngine.UIElements.Panel panel) { }
        private System.Void RemoveCachedPanel(System.Int32 instanceID) { }
        private System.Boolean TryGetPanel(System.Int32 instanceID, UnityEngine.UIElements.Panel& panel) { }
        private System.Void BeginContainerGUI(UnityEngine.GUILayoutUtility.LayoutCache cache, UnityEngine.Event evt, UnityEngine.UIElements.IMGUIContainer container) { }
        private System.Void EndContainerGUI(UnityEngine.Event evt, UnityEngine.Rect layoutSize) { }
        private UnityEngine.UIElements.EventBase CreateEvent(UnityEngine.Event systemEvent) { }
        private UnityEngine.UIElements.EventBase CreateEvent(UnityEngine.Event systemEvent, UnityEngine.EventType eventType) { }
        private System.Boolean DoDispatch(UnityEngine.UIElements.BaseVisualElementPanel panel) { }
        private System.Void GetAllPanels(System.Collections.Generic.List<UnityEngine.UIElements.Panel> panels, UnityEngine.UIElements.ContextType contextType) { }
        private System.Collections.Generic.Dictionary.Enumerator<System.Int32,UnityEngine.UIElements.Panel> GetPanelsIterator() { }
        private System.Single PixelsPerUnitScaleForElement(UnityEngine.UIElements.VisualElement ve, UnityEngine.Sprite sprite) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AF
    public struct RuleMatcher
    {
        // Fields
        public UnityEngine.UIElements.StyleSheet sheet;        // 0x10
        public UnityEngine.UIElements.StyleComplexSelector complexSelector;        // 0x18

        // Methods
        private System.String ToString() { }

    }

    // TypeToken: 0x20000B0
    public class UQuery
    {
    }

    // TypeToken: 0x20000B7
    public struct UQueryState`1, IEnumerable`1, IEnumerable, IEquatable`1
    {
        // Fields
        private static UnityEngine.UIElements.UQueryState.ActionQueryMatcher<T> s_Action;        // 0x0
        private readonly UnityEngine.UIElements.VisualElement m_Element;        // 0x0
        private readonly System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> m_Matchers;        // 0x0
        private static readonly UnityEngine.UIElements.UQueryState.ListQueryMatcher<T,T> s_List;        // 0x0
        private static readonly UnityEngine.UIElements.UQueryState.ListQueryMatcher<T,UnityEngine.UIElements.VisualElement> s_EnumerationList;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.VisualElement element, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers) { }
        private UnityEngine.UIElements.UQueryState<T> RebuildOn(UnityEngine.UIElements.VisualElement element) { }
        private T Single(UnityEngine.UIElements.UQuery.SingleQueryMatcher matcher) { }
        private T First() { }
        private System.Void ToList(System.Collections.Generic.List<T> results) { }
        private UnityEngine.UIElements.UQueryState.Enumerator<T> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Boolean Equals(UnityEngine.UIElements.UQueryState<T> other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000BB
    public struct UQueryBuilder`1, IEquatable`1
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSelector> m_StyleSelectors;        // 0x0
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart> m_Parts;        // 0x0
        private UnityEngine.UIElements.VisualElement m_Element;        // 0x0
        private System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> m_Matchers;        // 0x0
        private UnityEngine.UIElements.StyleSelectorRelationship m_Relationship;        // 0x0
        private System.Int32 pseudoStatesMask;        // 0x0
        private System.Int32 negatedPseudoStatesMask;        // 0x0

        // Methods
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSelector> get_styleSelectors() { }
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart> get_parts() { }
        private System.Void .ctor(UnityEngine.UIElements.VisualElement visualElement) { }
        private UnityEngine.UIElements.UQueryBuilder<T> Class(System.String classname) { }
        private UnityEngine.UIElements.UQueryBuilder<T> Name(System.String id) { }
        private UnityEngine.UIElements.UQueryBuilder<T2> OfType(System.String name, System.String className) { }
        private UnityEngine.UIElements.UQueryBuilder<T> SingleBaseType() { }
        private System.Void AddClass(System.String c) { }
        private System.Void AddName(System.String id) { }
        private System.Void AddType() { }
        private UnityEngine.UIElements.UQueryBuilder<T2> AddRelationship(UnityEngine.UIElements.StyleSelectorRelationship relationship) { }
        private System.Void AddPseudoStatesRuleIfNecessasy() { }
        private System.Void FinishSelector() { }
        private System.Boolean CurrentSelectorEmpty() { }
        private System.Void FinishCurrentSelector() { }
        private UnityEngine.UIElements.UQueryState<T> Build() { }
        private System.Void ToList(System.Collections.Generic.List<T> results) { }
        private System.Boolean Equals(UnityEngine.UIElements.UQueryBuilder<T> other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x20000BC
    public class UQueryExtensions
    {
        // Fields
        private static UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementEmptyQuery;        // 0x0
        private static UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementNameQuery;        // 0x10
        private static UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementClassQuery;        // 0x20
        private static UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementNameAndClassQuery;        // 0x30
        private static UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementTypeQuery;        // 0x40
        private static UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementTypeAndNameQuery;        // 0x50
        private static UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementTypeAndClassQuery;        // 0x60
        private static UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementTypeAndNameAndClassQuery;        // 0x70

        // Methods
        private T Q(UnityEngine.UIElements.VisualElement e, System.String name, System.String className) { }
        private UnityEngine.UIElements.VisualElement Q(UnityEngine.UIElements.VisualElement e, System.String name, System.String className) { }
        private UnityEngine.UIElements.UQueryBuilder<T> Query(UnityEngine.UIElements.VisualElement e, System.String name, System.String className) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000BD
    public struct GradientType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.GradientType Linear;        // 0x0
        public static UnityEngine.UIElements.GradientType Radial;        // 0x0

    }

    // TypeToken: 0x20000BE
    public struct AddressMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.AddressMode Wrap;        // 0x0
        public static UnityEngine.UIElements.AddressMode Clamp;        // 0x0
        public static UnityEngine.UIElements.AddressMode Mirror;        // 0x0

    }

    // TypeToken: 0x20000BF
    public struct VectorImageVertex
    {
        // Fields
        public UnityEngine.Vector3 position;        // 0x10
        public UnityEngine.Color32 tint;        // 0x1C
        public UnityEngine.Vector2 uv;        // 0x20
        public System.UInt32 settingIndex;        // 0x28

    }

    // TypeToken: 0x20000C0
    public struct GradientSettings
    {
        // Fields
        public UnityEngine.UIElements.GradientType gradientType;        // 0x10
        public UnityEngine.UIElements.AddressMode addressMode;        // 0x14
        public UnityEngine.Vector2 radialFocus;        // 0x18
        public UnityEngine.RectInt location;        // 0x20

    }

    // TypeToken: 0x20000C1
    public class VectorImage : ScriptableObject
    {
        // Fields
        private UnityEngine.Texture2D atlas;        // 0x18
        private UnityEngine.UIElements.VectorImageVertex[] vertices;        // 0x20
        private System.UInt16[] indices;        // 0x28
        private UnityEngine.UIElements.GradientSettings[] settings;        // 0x30
        private UnityEngine.Vector2 size;        // 0x38

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C2
    public struct PseudoStates
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.PseudoStates Active;        // 0x0
        public static UnityEngine.UIElements.PseudoStates Hover;        // 0x0
        public static UnityEngine.UIElements.PseudoStates Checked;        // 0x0
        public static UnityEngine.UIElements.PseudoStates Disabled;        // 0x0
        public static UnityEngine.UIElements.PseudoStates Focus;        // 0x0
        public static UnityEngine.UIElements.PseudoStates Root;        // 0x0

    }

    // TypeToken: 0x20000C3
    public struct VisualElementFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.VisualElementFlags WorldTransformDirty;        // 0x0
        public static UnityEngine.UIElements.VisualElementFlags WorldTransformInverseDirty;        // 0x0
        public static UnityEngine.UIElements.VisualElementFlags WorldClipDirty;        // 0x0
        public static UnityEngine.UIElements.VisualElementFlags BoundingBoxDirty;        // 0x0
        public static UnityEngine.UIElements.VisualElementFlags WorldBoundingBoxDirty;        // 0x0
        public static UnityEngine.UIElements.VisualElementFlags LayoutManual;        // 0x0
        public static UnityEngine.UIElements.VisualElementFlags CompositeRoot;        // 0x0
        public static UnityEngine.UIElements.VisualElementFlags RequireMeasureFunction;        // 0x0
        public static UnityEngine.UIElements.VisualElementFlags EnableViewDataPersistence;        // 0x0
        public static UnityEngine.UIElements.VisualElementFlags DisableClipping;        // 0x0
        public static UnityEngine.UIElements.VisualElementFlags NeedsAttachToPanelEvent;        // 0x0
        public static UnityEngine.UIElements.VisualElementFlags HierarchyDisplayed;        // 0x0
        public static UnityEngine.UIElements.VisualElementFlags StyleInitialized;        // 0x0
        public static UnityEngine.UIElements.VisualElementFlags Init;        // 0x0

    }

    // TypeToken: 0x20000C4
    public struct PickingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.PickingMode Position;        // 0x0
        public static UnityEngine.UIElements.PickingMode Ignore;        // 0x0

    }

    // TypeToken: 0x20000C5
    public struct LanguageDirection
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.LanguageDirection Inherit;        // 0x0
        public static UnityEngine.UIElements.LanguageDirection LTR;        // 0x0
        public static UnityEngine.UIElements.LanguageDirection RTL;        // 0x0

    }

    // TypeToken: 0x20000C6
    public class VisualElementListPool
    {
        // Fields
        private static UnityEngine.UIElements.ObjectPool<System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>> pool;        // 0x0

        // Methods
        private System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> Copy(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements) { }
        private System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> Get(System.Int32 initialCapacity) { }
        private System.Void Release(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000C7
    public class ObjectListPool`1
    {
        // Fields
        private static UnityEngine.UIElements.ObjectPool<System.Collections.Generic.List<T>> pool;        // 0x0

        // Methods
        private System.Collections.Generic.List<T> Get() { }
        private System.Void Release(System.Collections.Generic.List<T> elements) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000C8
    public class VisualElementExtensions
    {
        // Methods
        private System.Void StretchToParentSize(UnityEngine.UIElements.VisualElement elem) { }
        private System.Void AddManipulator(UnityEngine.UIElements.VisualElement ele, UnityEngine.UIElements.IManipulator manipulator) { }
        private System.Void RemoveManipulator(UnityEngine.UIElements.VisualElement ele, UnityEngine.UIElements.IManipulator manipulator) { }
        private UnityEngine.Vector2 WorldToLocal(UnityEngine.UIElements.VisualElement ele, UnityEngine.Vector2 p) { }
        private UnityEngine.Vector2 LocalToWorld(UnityEngine.UIElements.VisualElement ele, UnityEngine.Vector2 p) { }
        private UnityEngine.Rect WorldToLocal(UnityEngine.UIElements.VisualElement ele, UnityEngine.Rect r) { }
        private UnityEngine.Vector2 ChangeCoordinatesTo(UnityEngine.UIElements.VisualElement src, UnityEngine.UIElements.VisualElement dest, UnityEngine.Vector2 point) { }

    }

    // TypeToken: 0x20000C9
    public interface IExperimentalFeatures
    {
        // Methods
        private UnityEngine.UIElements.Experimental.ITransitionAnimations get_animation() { }

    }

    // TypeToken: 0x20000CA
    public class VisualElementFocusChangeDirection : FocusChangeDirection
    {
        // Fields
        private static readonly UnityEngine.UIElements.VisualElementFocusChangeDirection s_Left;        // 0x0
        private static readonly UnityEngine.UIElements.VisualElementFocusChangeDirection s_Right;        // 0x8

        // Methods
        private UnityEngine.UIElements.FocusChangeDirection get_left() { }
        private UnityEngine.UIElements.FocusChangeDirection get_right() { }
        private System.Void .ctor(System.Int32 value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000CB
    public class VisualElementFocusChangeTarget : FocusChangeDirection
    {
        // Fields
        private static readonly UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.VisualElementFocusChangeTarget> Pool;        // 0x0
        private UnityEngine.UIElements.Focusable <target>k__BackingField;        // 0x18

        // Methods
        private UnityEngine.UIElements.VisualElementFocusChangeTarget GetPooled(UnityEngine.UIElements.Focusable target) { }
        private System.Void Dispose() { }
        private System.Void ApplyTo(UnityEngine.UIElements.FocusController focusController, UnityEngine.UIElements.Focusable f) { }
        private System.Void .ctor() { }
        private UnityEngine.UIElements.Focusable get_target() { }
        private System.Void set_target(UnityEngine.UIElements.Focusable value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000CC
    public class VisualElementFocusRing, IFocusRing
    {
        // Fields
        private readonly UnityEngine.UIElements.VisualElement root;        // 0x10
        private UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder <defaultFocusOrder>k__BackingField;        // 0x18
        private System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> m_FocusRing;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.VisualElement root, UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder dfo) { }
        private UnityEngine.UIElements.FocusController get_focusController() { }
        private UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder get_defaultFocusOrder() { }
        private System.Void set_defaultFocusOrder(UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder value) { }
        private System.Int32 FocusRingAutoIndexSort(UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord a, UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord b) { }
        private System.Int32 FocusRingSort(UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord a, UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord b) { }
        private System.Void DoUpdate() { }
        private System.Void BuildRingForScopeRecursive(UnityEngine.UIElements.VisualElement ve, System.Int32& scopeIndex, System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> scopeList) { }
        private System.Void SortAndFlattenScopeLists(System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> rootScopeList) { }
        private System.Int32 GetFocusableInternalIndex(UnityEngine.UIElements.Focusable f) { }
        private UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.EventBase e) { }
        private UnityEngine.UIElements.FocusChangeDirection GetKeyDownFocusChangeDirection(UnityEngine.UIElements.EventBase e) { }
        private UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.FocusChangeDirection direction) { }
        private UnityEngine.UIElements.Focusable GetNextFocusableInTree(UnityEngine.UIElements.VisualElement currentFocusable) { }
        private UnityEngine.UIElements.Focusable GetPreviousFocusableInTree(UnityEngine.UIElements.VisualElement currentFocusable) { }

    }

    // TypeToken: 0x20000CF
    public interface IVisualElementScheduledItem
    {
        // Methods
        private System.Boolean get_isActive() { }
        private System.Void Resume() { }
        private System.Void Pause() { }
        private System.Void ExecuteLater(System.Int64 delayMs) { }
        private UnityEngine.UIElements.IVisualElementScheduledItem StartingIn(System.Int64 delayMs) { }
        private UnityEngine.UIElements.IVisualElementScheduledItem Every(System.Int64 intervalMs) { }

    }

    // TypeToken: 0x20000D0
    public interface IVisualElementScheduler
    {
        // Methods
        private UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action<UnityEngine.UIElements.TimerState> timerUpdateEvent) { }
        private UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action updateEvent) { }

    }

    // TypeToken: 0x20000D1
    public interface IVisualElementPanelActivatable
    {
        // Methods
        private UnityEngine.UIElements.VisualElement get_element() { }
        private System.Boolean CanBeActivated() { }
        private System.Void OnPanelActivate() { }
        private System.Void OnPanelDeactivate() { }

    }

    // TypeToken: 0x20000D2
    public class VisualElementPanelActivator
    {
        // Fields
        private UnityEngine.UIElements.IVisualElementPanelActivatable m_Activatable;        // 0x10
        private System.Boolean <isActive>k__BackingField;        // 0x18
        private System.Boolean <isDetaching>k__BackingField;        // 0x19

        // Methods
        private System.Boolean get_isActive() { }
        private System.Void set_isActive(System.Boolean value) { }
        private System.Boolean get_isDetaching() { }
        private System.Void set_isDetaching(System.Boolean value) { }
        private System.Void .ctor(UnityEngine.UIElements.IVisualElementPanelActivatable activatable) { }
        private System.Void SetActive(System.Boolean action) { }
        private System.Void SendActivation() { }
        private System.Void SendDeactivation() { }
        private System.Void OnEnter(UnityEngine.UIElements.AttachToPanelEvent evt) { }
        private System.Void OnLeave(UnityEngine.UIElements.DetachFromPanelEvent evt) { }

    }

    // TypeToken: 0x20000D3
    public struct VisualElementStyleSheetSet, IEquatable`1
    {
        // Fields
        private readonly UnityEngine.UIElements.VisualElement m_Element;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.VisualElement element) { }
        private System.Void Add(UnityEngine.UIElements.StyleSheet styleSheet) { }
        private System.Boolean Remove(UnityEngine.UIElements.StyleSheet styleSheet) { }
        private System.Boolean Equals(UnityEngine.UIElements.VisualElementStyleSheetSet other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x20000D4
    public class VisualElementUtils
    {
        // Fields
        private static readonly System.Collections.Generic.HashSet<System.String> s_usedNames;        // 0x0
        private static readonly System.Type s_FoldoutType;        // 0x8

        // Methods
        private System.String GetUniqueName(System.String nameBase) { }
        private System.Int32 GetFoldoutDepth(UnityEngine.UIElements.VisualElement element) { }
        private System.Int32 GetListAndFoldoutDepth(UnityEngine.UIElements.VisualElement element) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000D5
    public class VisualElementAnimationSystem : BaseVisualTreeUpdater
    {
        // Fields
        private System.Collections.Generic.HashSet<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_Animations;        // 0x20
        private System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_IterationList;        // 0x28
        private System.Boolean m_HasNewAnimations;        // 0x30
        private System.Boolean m_IterationListDirty;        // 0x31
        private static readonly System.String s_Description;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker s_ProfilerMarker;        // 0x8
        private static readonly System.String s_StylePropertyAnimationDescription;        // 0x10
        private static readonly Unity.Profiling.ProfilerMarker s_StylePropertyAnimationProfilerMarker;        // 0x18
        private System.Int64 lastUpdate;        // 0x38

        // Methods
        private Unity.Profiling.ProfilerMarker get_profilerMarker() { }
        private Unity.Profiling.ProfilerMarker get_stylePropertyAnimationProfilerMarker() { }
        private System.Void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim) { }
        private System.Void UnregisterAnimations(System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims) { }
        private System.Void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim) { }
        private System.Void RegisterAnimations(System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims) { }
        private System.Void Update() { }
        private System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000D6
    public struct HierarchyChangeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.HierarchyChangeType Add;        // 0x0
        public static UnityEngine.UIElements.HierarchyChangeType Remove;        // 0x0
        public static UnityEngine.UIElements.HierarchyChangeType Move;        // 0x0

    }

    // TypeToken: 0x20000D7
    public class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater
    {
        // Fields
        private UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater.State m_State;        // 0x20
        private UnityEngine.UIElements.VisualElement m_CurrentChangeElement;        // 0x28
        private UnityEngine.UIElements.VisualElement m_CurrentChangeParent;        // 0x30

        // Methods
        private System.Void OnHierarchyChange(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType type) { }
        private System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType) { }
        private System.Void Update() { }
        private System.Void ProcessNewChange(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void ProcessAddOrMove(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void ProcessRemove(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D9
    public class StyleCache
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Int64,UnityEngine.UIElements.ComputedStyle> s_ComputedStyleCache;        // 0x0
        private static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.StyleVariableContext> s_StyleVariableContextCache;        // 0x8
        private static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.ComputedTransitionProperty[]> s_ComputedTransitionsCache;        // 0x10

        // Methods
        private System.Boolean TryGetValue(System.Int64 hash, UnityEngine.UIElements.ComputedStyle& data) { }
        private System.Void SetValue(System.Int64 hash, UnityEngine.UIElements.ComputedStyle& data) { }
        private System.Boolean TryGetValue(System.Int32 hash, UnityEngine.UIElements.StyleVariableContext& data) { }
        private System.Void SetValue(System.Int32 hash, UnityEngine.UIElements.StyleVariableContext data) { }
        private System.Boolean TryGetValue(System.Int32 hash, UnityEngine.UIElements.ComputedTransitionProperty[]& data) { }
        private System.Void SetValue(System.Int32 hash, UnityEngine.UIElements.ComputedTransitionProperty[] data) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000DA
    public class VisualTreeStyleUpdater : BaseVisualTreeUpdater
    {
        // Fields
        private System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ApplyStyleUpdateList;        // 0x20
        private System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_TransitionPropertyUpdateList;        // 0x28
        private System.Boolean m_IsApplyingStyles;        // 0x30
        private System.UInt32 m_Version;        // 0x34
        private System.UInt32 m_LastVersion;        // 0x38
        private UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal m_StyleContextHierarchyTraversal;        // 0x40
        private static readonly System.String s_Description;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker s_ProfilerMarker;        // 0x8
        private System.Boolean <disposed>k__BackingField;        // 0x48

        // Methods
        private Unity.Profiling.ProfilerMarker get_profilerMarker() { }
        private System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType) { }
        private System.Void Update() { }
        private System.Boolean get_disposed() { }
        private System.Void set_disposed(System.Boolean value) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void ApplyStyles() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000DB
    public class StyleMatchingContext
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> m_StyleSheetStack;        // 0x10
        public UnityEngine.UIElements.StyleVariableContext variableContext;        // 0x18
        public UnityEngine.UIElements.VisualElement currentElement;        // 0x20
        public System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult;        // 0x28
        public UnityEngine.UIElements.AncestorFilter ancestorFilter;        // 0x30

        // Methods
        private System.Int32 get_styleSheetCount() { }
        private System.Void .ctor(System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult) { }
        private System.Void AddStyleSheet(UnityEngine.UIElements.StyleSheet sheet) { }
        private System.Void RemoveStyleSheetRange(System.Int32 index, System.Int32 count) { }
        private UnityEngine.UIElements.StyleSheet GetStyleSheetAt(System.Int32 index) { }

    }

    // TypeToken: 0x20000DC
    public class VisualTreeStyleUpdaterTraversal : HierarchyTraversal
    {
        // Fields
        private UnityEngine.UIElements.StyleVariableContext m_ProcessVarContext;        // 0x10
        private System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_UpdateList;        // 0x18
        private System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ParentList;        // 0x20
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> m_TempMatchResults;        // 0x28
        private System.Single <currentPixelsPerPoint>k__BackingField;        // 0x30
        private UnityEngine.UIElements.StyleMatchingContext m_StyleMatchingContext;        // 0x38
        private UnityEngine.UIElements.StyleSheets.StylePropertyReader m_StylePropertyReader;        // 0x40
        private readonly System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> m_AnimatedProperties;        // 0x48

        // Methods
        private System.Single get_currentPixelsPerPoint() { }
        private System.Void set_currentPixelsPerPoint(System.Single value) { }
        private System.Void PrepareTraversal(System.Single pixelsPerPoint) { }
        private System.Void AddChangedElement(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType) { }
        private System.Void Clear() { }
        private System.Void PropagateToChildren(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void PropagateToParents(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void OnProcessMatchResult(UnityEngine.UIElements.VisualElement current, UnityEngine.UIElements.StyleSheets.MatchResultInfo info) { }
        private System.Void TraverseRecursive(UnityEngine.UIElements.VisualElement element, System.Int32 depth) { }
        private System.Void ProcessTransitions(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.ComputedStyle& oldStyle, UnityEngine.UIElements.ComputedStyle& newStyle) { }
        private System.Void ForceUpdateTransitions(UnityEngine.UIElements.VisualElement element) { }
        private System.Void CancelAnimationsWithNoTransitionProperty(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.ComputedStyle& newStyle) { }
        private System.Boolean ShouldSkipElement(UnityEngine.UIElements.VisualElement element) { }
        private UnityEngine.UIElements.ComputedStyle ProcessMatchedRules(UnityEngine.UIElements.VisualElement element, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchingSelectors) { }
        private System.Void ProcessMatchedVariables(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleRule rule) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DE
    public class VisualTreeTransformClipUpdater : BaseVisualTreeUpdater
    {
        // Fields
        private System.UInt32 m_Version;        // 0x20
        private System.UInt32 m_LastVersion;        // 0x24
        private static readonly System.String s_Description;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker s_ProfilerMarker;        // 0x8

        // Methods
        private Unity.Profiling.ProfilerMarker get_profilerMarker() { }
        private System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType) { }
        private System.Void DirtyHierarchy(UnityEngine.UIElements.VisualElement ve, System.Boolean mustDirtyWorldTransform, System.Boolean mustDirtyWorldClip) { }
        private System.Void DirtyBoundingBoxHierarchy(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void Update() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000DF
    public struct VisualTreeUpdatePhase
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.VisualTreeUpdatePhase ViewData;        // 0x0
        public static UnityEngine.UIElements.VisualTreeUpdatePhase Bindings;        // 0x0
        public static UnityEngine.UIElements.VisualTreeUpdatePhase Animation;        // 0x0
        public static UnityEngine.UIElements.VisualTreeUpdatePhase Styles;        // 0x0
        public static UnityEngine.UIElements.VisualTreeUpdatePhase Layout;        // 0x0
        public static UnityEngine.UIElements.VisualTreeUpdatePhase TransformClip;        // 0x0
        public static UnityEngine.UIElements.VisualTreeUpdatePhase Repaint;        // 0x0
        public static UnityEngine.UIElements.VisualTreeUpdatePhase Count;        // 0x0

    }

    // TypeToken: 0x20000E0
    public class VisualTreeUpdater, IDisposable
    {
        // Fields
        private UnityEngine.UIElements.BaseVisualElementPanel m_Panel;        // 0x10
        private UnityEngine.UIElements.VisualTreeUpdater.UpdaterArray m_UpdaterArray;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.BaseVisualElementPanel panel) { }
        private System.Void Dispose() { }
        private System.Void UpdateVisualTreePhase(UnityEngine.UIElements.VisualTreeUpdatePhase phase) { }
        private System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType) { }
        private System.Void SetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase) { }
        private UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase) { }
        private System.Void SetDefaultUpdaters() { }

    }

    // TypeToken: 0x20000E2
    public interface IVisualTreeUpdater : IDisposable
    {
        // Methods
        private System.Void set_panel(UnityEngine.UIElements.BaseVisualElementPanel value) { }
        private Unity.Profiling.ProfilerMarker get_profilerMarker() { }
        private System.Void Update() { }
        private System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType) { }

    }

    // TypeToken: 0x20000E3
    public class BaseVisualTreeUpdater, IVisualTreeUpdater, IDisposable
    {
        // Fields
        private System.Action<UnityEngine.UIElements.BaseVisualElementPanel> panelChanged;        // 0x10
        private UnityEngine.UIElements.BaseVisualElementPanel m_Panel;        // 0x18

        // Methods
        private System.Void add_panelChanged(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value) { }
        private System.Void remove_panelChanged(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value) { }
        private UnityEngine.UIElements.BaseVisualElementPanel get_panel() { }
        private System.Void set_panel(UnityEngine.UIElements.BaseVisualElementPanel value) { }
        private UnityEngine.UIElements.VisualElement get_visualTree() { }
        private Unity.Profiling.ProfilerMarker get_profilerMarker() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Update() { }
        private System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E4
    public class VisualTreeViewDataUpdater : BaseVisualTreeUpdater
    {
        // Fields
        private System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_UpdateList;        // 0x20
        private System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ParentList;        // 0x28
        private System.UInt32 m_Version;        // 0x30
        private System.UInt32 m_LastVersion;        // 0x34
        private static readonly System.String s_Description;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker s_ProfilerMarker;        // 0x8

        // Methods
        private Unity.Profiling.ProfilerMarker get_profilerMarker() { }
        private System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType) { }
        private System.Void Update() { }
        private System.Void ValidateViewDataOnSubTree(UnityEngine.UIElements.VisualElement ve, System.Boolean enablePersistence) { }
        private System.Void PropagateToParents(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E5
    public interface IBindingRequest
    {
        // Methods
        private System.Void Bind(UnityEngine.UIElements.VisualElement element) { }

    }

    // TypeToken: 0x20000E6
    public class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater
    {
        // Fields
        private static readonly UnityEngine.PropertyName s_BindingRequestObjectVEPropertyName;        // 0x0
        private static readonly UnityEngine.PropertyName s_AdditionalBindingObjectVEPropertyName;        // 0x4
        private static readonly System.String s_Description;        // 0x8
        private static readonly Unity.Profiling.ProfilerMarker s_ProfilerMarker;        // 0x10
        private static readonly Unity.Profiling.ProfilerMarker s_ProfilerBindingRequestsMarker;        // 0x18
        private static Unity.Profiling.ProfilerMarker s_MarkerUpdate;        // 0x20
        private static Unity.Profiling.ProfilerMarker s_MarkerPoll;        // 0x28
        private static System.Boolean <disableBindingsThrottling>k__BackingField;        // 0x30
        private readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ElementsWithBindings;        // 0x38
        private readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ElementsToAdd;        // 0x40
        private readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ElementsToRemove;        // 0x48
        private System.Int64 m_LastUpdateTime;        // 0x50
        private System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ElementsToBind;        // 0x58
        private System.Collections.Generic.Dictionary<System.Object,System.Object> <temporaryObjectCache>k__BackingField;        // 0x60
        private System.Collections.Generic.List<UnityEngine.UIElements.IBinding> updatedBindings;        // 0x68

        // Methods
        private Unity.Profiling.ProfilerMarker get_profilerMarker() { }
        private UnityEngine.UIElements.IBinding GetBindingObjectFromElement(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void StartTracking(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void StopTracking(UnityEngine.UIElements.VisualElement ve) { }
        private System.Collections.Generic.Dictionary<System.Object,System.Object> get_temporaryObjectCache() { }
        private UnityEngine.UIElements.IBinding GetAdditionalBinding(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void StartTrackingRecursive(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void StopTrackingRecursive(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType) { }
        private System.Void OnHierarchyChange(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType type) { }
        private System.Int64 CurrentTime() { }
        private System.Void PerformTrackingOperations() { }
        private System.Void Update() { }
        private System.Void UpdateBindings() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E7
    public class BaseListViewController : CollectionViewController
    {
        // Fields
        private System.Action itemsSourceSizeChanged;        // 0x30
        private System.Action<System.Collections.Generic.IEnumerable<System.Int32>> itemsAdded;        // 0x38
        private System.Action<System.Collections.Generic.IEnumerable<System.Int32>> itemsRemoved;        // 0x40

        // Methods
        private System.Void add_itemsSourceSizeChanged(System.Action value) { }
        private System.Void remove_itemsSourceSizeChanged(System.Action value) { }
        private System.Void add_itemsAdded(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value) { }
        private System.Void remove_itemsAdded(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value) { }
        private System.Void add_itemsRemoved(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value) { }
        private System.Void remove_itemsRemoved(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value) { }
        private UnityEngine.UIElements.BaseListView get_baseListView() { }
        private System.Void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem) { }
        private System.Void PostInitRegistration(UnityEngine.UIElements.ReusableListViewItem listItem) { }
        private System.Void InvokeBindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, System.Int32 index) { }
        private System.Boolean NeedsDragHandle(System.Int32 index) { }
        private System.Void AddItems(System.Int32 itemCount) { }
        private System.Void Move(System.Int32 index, System.Int32 newIndex) { }
        private System.Void RemoveItem(System.Int32 index) { }
        private System.Void RemoveItems(System.Collections.Generic.List<System.Int32> indices) { }
        private System.Void RemoveItems(System.Int32 itemCount) { }
        private System.Void ClearItems() { }
        private System.Void RaiseOnSizeChanged() { }
        private System.Void RaiseItemsAdded(System.Collections.Generic.IEnumerable<System.Int32> indices) { }
        private System.Void RaiseItemsRemoved(System.Collections.Generic.IEnumerable<System.Int32> indices) { }
        private System.Array AddToArray(System.Array source, System.Int32 itemCount) { }
        private System.Array RemoveFromArray(System.Array source, System.Collections.Generic.List<System.Int32> indicesToRemove) { }
        private System.Void Swap(System.Int32 lhs, System.Int32 rhs) { }
        private System.Void EnsureItemSourceCanBeResized() { }
        private System.Void .ctor() { }
        private System.Boolean <AddItems>g__IsGenericList|15_0(System.Type t) { }

    }

    // TypeToken: 0x20000E8
    public class BaseTreeViewController : CollectionViewController
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.TreeItem> m_TreeItems;        // 0x30
        private System.Collections.Generic.List<System.Int32> m_RootIndices;        // 0x38
        private System.Collections.Generic.List<UnityEngine.UIElements.TreeViewItemWrapper> m_ItemWrappers;        // 0x40
        private System.Collections.Generic.HashSet<System.Int32> m_TreeItemIdsWithItemWrappers;        // 0x48
        private System.Collections.Generic.List<UnityEngine.UIElements.TreeViewItemWrapper> m_WrapperInsertionList;        // 0x50
        private static readonly Unity.Profiling.ProfilerMarker K_ExpandItemByIndex;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker k_CreateWrappers;        // 0x8

        // Methods
        private UnityEngine.UIElements.BaseTreeView get_baseTreeView() { }
        private System.Collections.IList get_itemsSource() { }
        private System.Void set_itemsSource(System.Collections.IList value) { }
        private System.Void RebuildTree() { }
        private System.Collections.Generic.IEnumerable<System.Int32> GetRootItemIds() { }
        private System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds) { }
        private System.Int32 GetParentId(System.Int32 id) { }
        private System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(System.Int32 id) { }
        private System.Void Move(System.Int32 id, System.Int32 newParentId, System.Int32 childIndex, System.Boolean rebuildTree) { }
        private System.Void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem) { }
        private System.Void InvokeBindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, System.Int32 index) { }
        private System.Void InvokeDestroyItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem) { }
        private System.Void PostInitRegistration(UnityEngine.UIElements.ReusableTreeViewItem treeItem) { }
        private System.Void OnItemPointerUp(UnityEngine.UIElements.PointerUpEvent evt) { }
        private System.Void OnToggleValueChanged(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt) { }
        private System.Int32 GetIndexForId(System.Int32 id) { }
        private System.Int32 GetIdForIndex(System.Int32 index) { }
        private System.Boolean HasChildren(System.Int32 id) { }
        private System.Boolean Exists(System.Int32 id) { }
        private System.Boolean HasChildrenByIndex(System.Int32 index) { }
        private System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIdsByIndex(System.Int32 index) { }
        private System.Int32 GetChildIndexForId(System.Int32 id) { }
        private System.Int32 GetIndentationDepth(System.Int32 id) { }
        private System.Int32 GetIndentationDepthByIndex(System.Int32 index) { }
        private System.Boolean CanChangeExpandedState(System.Int32 id) { }
        private System.Boolean IsExpanded(System.Int32 id) { }
        private System.Boolean IsExpandedByIndex(System.Int32 index) { }
        private System.Void ExpandItemByIndex(System.Int32 index, System.Boolean expandAllChildren, System.Boolean refresh) { }
        private System.Void ExpandItem(System.Int32 id, System.Boolean expandAllChildren, System.Boolean refresh) { }
        private System.Void CollapseItemByIndex(System.Int32 index, System.Boolean collapseAllChildren) { }
        private System.Void CollapseItem(System.Int32 id, System.Boolean collapseAllChildren) { }
        private System.Void RegenerateWrappers() { }
        private System.Void CreateWrappers(System.Collections.Generic.IEnumerable<System.Int32> treeViewItemIds, System.Int32 depth, System.Collections.Generic.List<UnityEngine.UIElements.TreeViewItemWrapper>& wrappers) { }
        private System.Boolean IsIndexValid(System.Int32 index) { }
        private System.Void RaiseItemParentChanged(System.Int32 id, System.Int32 newParentId) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000EA
    public class CollectionViewController, IDisposable
    {
        // Fields
        private UnityEngine.UIElements.BaseVerticalCollectionView m_View;        // 0x10
        private System.Collections.IList m_ItemsSource;        // 0x18
        private System.Action itemsSourceChanged;        // 0x20
        private System.Action<System.Int32,System.Int32> itemIndexChanged;        // 0x28

        // Methods
        private System.Void add_itemsSourceChanged(System.Action value) { }
        private System.Void remove_itemsSourceChanged(System.Action value) { }
        private System.Void add_itemIndexChanged(System.Action<System.Int32,System.Int32> value) { }
        private System.Void remove_itemIndexChanged(System.Action<System.Int32,System.Int32> value) { }
        private System.Collections.IList get_itemsSource() { }
        private System.Void set_itemsSource(System.Collections.IList value) { }
        private System.Void SetItemsSourceWithoutNotify(System.Collections.IList source) { }
        private UnityEngine.UIElements.BaseVerticalCollectionView get_view() { }
        private System.Void SetView(UnityEngine.UIElements.BaseVerticalCollectionView collectionView) { }
        private System.Void PrepareView() { }
        private System.Void Dispose() { }
        private System.Int32 GetItemsCount() { }
        private System.Int32 GetItemsMinCount() { }
        private System.Int32 GetIndexForId(System.Int32 id) { }
        private System.Int32 GetIdForIndex(System.Int32 index) { }
        private System.Object GetItemForIndex(System.Int32 index) { }
        private System.Void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem) { }
        private System.Void InvokeBindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, System.Int32 index) { }
        private System.Void InvokeUnbindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, System.Int32 index) { }
        private System.Void InvokeDestroyItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem) { }
        private UnityEngine.UIElements.VisualElement MakeItem() { }
        private System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index) { }
        private System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index) { }
        private System.Void DestroyItem(UnityEngine.UIElements.VisualElement element) { }
        private System.Void RaiseItemsSourceChanged() { }
        private System.Void RaiseItemIndexChanged(System.Int32 srcIndex, System.Int32 dstIndex) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EB
    public class DefaultMultiColumnTreeViewController`1 : MultiColumnTreeViewController
    {
        // Fields
        private UnityEngine.UIElements.TreeDataController<T> m_TreeDataController;        // 0x0

        // Methods
        private UnityEngine.UIElements.TreeDataController<T> get_treeDataController() { }
        private System.Void .ctor(UnityEngine.UIElements.Columns columns, UnityEngine.UIElements.SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }
        private System.Collections.IList get_itemsSource() { }
        private System.Void set_itemsSource(System.Collections.IList value) { }
        private System.Void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> items) { }
        private System.Object GetItemForIndex(System.Int32 index) { }
        private System.Int32 GetParentId(System.Int32 id) { }
        private System.Boolean HasChildren(System.Int32 id) { }
        private System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(System.Int32 id) { }
        private System.Void Move(System.Int32 id, System.Int32 newParentId, System.Int32 childIndex, System.Boolean rebuildTree) { }
        private System.Boolean IsChildOf(System.Int32 childId, System.Int32 id) { }
        private System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds) { }

    }

    // TypeToken: 0x20000EC
    public class DefaultTreeViewController`1 : TreeViewController
    {
        // Fields
        private UnityEngine.UIElements.TreeDataController<T> m_TreeDataController;        // 0x0

        // Methods
        private UnityEngine.UIElements.TreeDataController<T> get_treeDataController() { }
        private System.Collections.IList get_itemsSource() { }
        private System.Void set_itemsSource(System.Collections.IList value) { }
        private System.Void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> items) { }
        private System.Object GetItemForIndex(System.Int32 index) { }
        private System.Int32 GetParentId(System.Int32 id) { }
        private System.Boolean HasChildren(System.Int32 id) { }
        private System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(System.Int32 id) { }
        private System.Void Move(System.Int32 id, System.Int32 newParentId, System.Int32 childIndex, System.Boolean rebuildTree) { }
        private System.Boolean IsChildOf(System.Int32 childId, System.Int32 id) { }
        private System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000ED
    public class ListViewController : BaseListViewController
    {
        // Methods
        private UnityEngine.UIElements.ListView get_listView() { }
        private UnityEngine.UIElements.VisualElement MakeItem() { }
        private System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index) { }
        private System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index) { }
        private System.Void DestroyItem(UnityEngine.UIElements.VisualElement element) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EE
    public class MultiColumnListViewController : BaseListViewController
    {
        // Fields
        private UnityEngine.UIElements.MultiColumnController m_ColumnController;        // 0x48

        // Methods
        private UnityEngine.UIElements.MultiColumnController get_columnController() { }
        private UnityEngine.UIElements.Internal.MultiColumnCollectionHeader get_header() { }
        private System.Void .ctor(UnityEngine.UIElements.Columns columns, UnityEngine.UIElements.SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }
        private System.Void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem) { }
        private UnityEngine.UIElements.VisualElement MakeItem() { }
        private System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index) { }
        private System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index) { }
        private System.Void DestroyItem(UnityEngine.UIElements.VisualElement element) { }
        private System.Void PrepareView() { }
        private System.Void Dispose() { }
        private System.Void UpdateReorderClassList() { }

    }

    // TypeToken: 0x20000EF
    public class MultiColumnTreeViewController : BaseTreeViewController
    {
        // Fields
        private UnityEngine.UIElements.MultiColumnController m_ColumnController;        // 0x58

        // Methods
        private UnityEngine.UIElements.MultiColumnController get_columnController() { }
        private UnityEngine.UIElements.Internal.MultiColumnCollectionHeader get_header() { }
        private System.Void .ctor(UnityEngine.UIElements.Columns columns, UnityEngine.UIElements.SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }
        private System.Void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem) { }
        private UnityEngine.UIElements.VisualElement MakeItem() { }
        private System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index) { }
        private System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index) { }
        private System.Void DestroyItem(UnityEngine.UIElements.VisualElement element) { }
        private System.Void PrepareView() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20000F0
    public class TreeDataController`1
    {
        // Fields
        private UnityEngine.UIElements.TreeData<T> m_TreeData;        // 0x0
        private System.Collections.Generic.Stack<System.Collections.Generic.IEnumerator<System.Int32>> m_IteratorStack;        // 0x0

        // Methods
        private System.Void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems) { }
        private T GetDataForId(System.Int32 id) { }
        private System.Int32 GetParentId(System.Int32 id) { }
        private System.Boolean HasChildren(System.Int32 id) { }
        private System.Collections.Generic.IEnumerable<System.Int32> GetItemIds(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> items) { }
        private System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(System.Int32 id) { }
        private System.Void Move(System.Int32 id, System.Int32 newParentId, System.Int32 childIndex) { }
        private System.Boolean IsChildOf(System.Int32 childId, System.Int32 id) { }
        private System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F3
    public class TreeViewController : BaseTreeViewController
    {
        // Methods
        private UnityEngine.UIElements.TreeView get_treeView() { }
        private UnityEngine.UIElements.VisualElement MakeItem() { }
        private System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index) { }
        private System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index) { }
        private System.Void DestroyItem(UnityEngine.UIElements.VisualElement element) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F4
    public class CollectionVirtualizationController
    {
        // Fields
        protected readonly UnityEngine.UIElements.ScrollView m_ScrollView;        // 0x10

        // Methods
        private System.Int32 get_firstVisibleIndex() { }
        private System.Void set_firstVisibleIndex(System.Int32 value) { }
        private System.Int32 get_visibleItemCount() { }
        private System.Void .ctor(UnityEngine.UIElements.ScrollView scrollView) { }
        private System.Void Refresh(System.Boolean rebuild) { }
        private System.Void ScrollToItem(System.Int32 id) { }
        private System.Void Resize(UnityEngine.Vector2 size) { }
        private System.Void OnScroll(UnityEngine.Vector2 offset) { }
        private System.Int32 GetIndexFromPosition(UnityEngine.Vector2 position) { }
        private System.Single GetExpectedItemHeight(System.Int32 index) { }
        private System.Single GetExpectedContentHeight() { }
        private System.Void OnFocus(UnityEngine.UIElements.VisualElement leafTarget) { }
        private System.Void OnBlur(UnityEngine.UIElements.VisualElement willFocus) { }
        private System.Void UpdateBackground() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems() { }
        private System.Void StartDragItem(UnityEngine.UIElements.ReusableCollectionItem item) { }
        private System.Void EndDrag(System.Int32 dropIndex) { }

    }

    // TypeToken: 0x20000F5
    public class DynamicHeightVirtualizationController`1 : VerticalVirtualizationController`1
    {
        // Fields
        private System.Int32 m_HighestCachedIndex;        // 0x0
        private readonly System.Collections.Generic.Dictionary<System.Int32,System.Single> m_ItemHeightCache;        // 0x0
        private readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.DynamicHeightVirtualizationController.ContentHeightCacheInfo<T>> m_ContentHeightCache;        // 0x0
        private readonly System.Collections.Generic.HashSet<System.Int32> m_WaitingCache;        // 0x0
        private System.Int32 m_ForcedFirstVisibleItem;        // 0x0
        private System.Int32 m_ForcedLastVisibleItem;        // 0x0
        private System.Boolean m_StickToBottom;        // 0x0
        private UnityEngine.UIElements.DynamicHeightVirtualizationController.VirtualizationChange<T> m_LastChange;        // 0x0
        private UnityEngine.UIElements.DynamicHeightVirtualizationController.ScrollDirection<T> m_ScrollDirection;        // 0x0
        private UnityEngine.Vector2 m_DelayedScrollOffset;        // 0x0
        private System.Single m_AccumulatedHeight;        // 0x0
        private System.Single m_MinimumItemHeight;        // 0x0
        private System.Action m_FillCallback;        // 0x0
        private System.Action m_ScrollCallback;        // 0x0
        private System.Action m_ScrollResetCallback;        // 0x0
        private System.Action<UnityEngine.UIElements.ReusableCollectionItem> m_GeometryChangedCallback;        // 0x0
        private UnityEngine.UIElements.IVisualElementScheduledItem m_ScheduledItem;        // 0x0
        private UnityEngine.UIElements.IVisualElementScheduledItem m_ScrollScheduledItem;        // 0x0
        private UnityEngine.UIElements.IVisualElementScheduledItem m_ScrollResetScheduledItem;        // 0x0
        private System.Predicate<System.Int32> m_IndexOutOfBoundsPredicate;        // 0x0

        // Methods
        private System.Single get_defaultExpectedHeight() { }
        private System.Single get_contentPadding() { }
        private System.Void set_contentPadding(System.Single value) { }
        private System.Single get_contentHeight() { }
        private System.Void set_contentHeight(System.Single value) { }
        private System.Int32 get_anchoredIndex() { }
        private System.Void set_anchoredIndex(System.Int32 value) { }
        private System.Single get_anchorOffset() { }
        private System.Void set_anchorOffset(System.Single value) { }
        private System.Single get_viewportMaxOffset() { }
        private System.Boolean get_alwaysRebindOnRefresh() { }
        private System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView collectionView) { }
        private System.Void Refresh(System.Boolean rebuild) { }
        private System.Void ScrollToItem(System.Int32 index) { }
        private System.Void Resize(UnityEngine.Vector2 size) { }
        private System.Void OnScroll(UnityEngine.Vector2 scrollOffset) { }
        private System.Void OnScrollUpdate() { }
        private System.Void CycleItems(System.Int32 firstIndex) { }
        private System.Boolean NeedsFill() { }
        private System.Void Fill() { }
        private System.Void UpdateScrollViewContainer(System.Single previousHeight, System.Single newHeight) { }
        private System.Void ApplyScrollViewUpdate(System.Boolean dimensionsOnly) { }
        private System.Void UpdateAnchor() { }
        private System.Void ScheduleFill() { }
        private System.Void ScheduleScroll() { }
        private System.Void ScheduleScrollDirectionReset() { }
        private System.Void ResetScroll() { }
        private System.Int32 GetIndexFromPosition(UnityEngine.Vector2 position) { }
        private System.Single GetExpectedItemHeight(System.Int32 index) { }
        private System.Int32 GetFirstVisibleItem(System.Single offset) { }
        private System.Single GetExpectedContentHeight() { }
        private System.Single GetContentHeightForIndex(System.Int32 lastIndex) { }
        private UnityEngine.UIElements.DynamicHeightVirtualizationController.ContentHeightCacheInfo<T> GetCachedContentHeight(System.Int32 index) { }
        private System.Void RegisterItemHeight(System.Int32 index, System.Single height) { }
        private System.Void UnregisterItemHeight(System.Int32 index) { }
        private System.Void CleanItemHeightCache() { }
        private System.Void OnRecycledItemGeometryChanged(UnityEngine.UIElements.ReusableCollectionItem item) { }
        private System.Boolean UpdateRegisteredHeight(UnityEngine.UIElements.ReusableCollectionItem item) { }
        private T GetOrMakeItemAtIndex(System.Int32 activeItemIndex, System.Int32 scrollViewIndex) { }
        private System.Void ReleaseItem(System.Int32 activeItemsIndex) { }
        private System.Void StartDragItem(UnityEngine.UIElements.ReusableCollectionItem item) { }
        private System.Void EndDrag(System.Int32 dropIndex) { }
        private System.Void HideItem(System.Int32 activeItemsIndex) { }
        private System.Void MarkWaitingForLayout(T item) { }
        private System.Boolean IsIndexOutOfBounds(System.Int32 i) { }

    }

    // TypeToken: 0x20000F9
    public class FixedHeightVirtualizationController`1 : VerticalVirtualizationController`1
    {
        // Methods
        private System.Single get_resolvedItemHeight() { }
        private System.Boolean VisibleItemPredicate(T i) { }
        private System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView collectionView) { }
        private System.Int32 GetIndexFromPosition(UnityEngine.Vector2 position) { }
        private System.Single GetExpectedItemHeight(System.Int32 index) { }
        private System.Single GetExpectedContentHeight() { }
        private System.Void ScrollToItem(System.Int32 index) { }
        private System.Void Resize(UnityEngine.Vector2 size) { }
        private System.Void OnScroll(UnityEngine.Vector2 scrollOffset) { }
        private T GetOrMakeItemAtIndex(System.Int32 activeItemIndex, System.Int32 scrollViewIndex) { }
        private System.Void EndDrag(System.Int32 dropIndex) { }

    }

    // TypeToken: 0x20000FA
    public class ReusableCollectionItem
    {
        // Fields
        private UnityEngine.UIElements.VisualElement <bindableElement>k__BackingField;        // 0x10
        private UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> <animator>k__BackingField;        // 0x18
        private System.Int32 <index>k__BackingField;        // 0x20
        private System.Int32 <id>k__BackingField;        // 0x24
        private System.Boolean <isDragGhost>k__BackingField;        // 0x28
        private System.Action<UnityEngine.UIElements.ReusableCollectionItem> onGeometryChanged;        // 0x30
        protected UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.GeometryChangedEvent> m_GeometryChangedEventCallback;        // 0x38
        private System.Action<UnityEngine.UIElements.ReusableCollectionItem> onDestroy;        // 0x40

        // Methods
        private UnityEngine.UIElements.VisualElement get_rootElement() { }
        private UnityEngine.UIElements.VisualElement get_bindableElement() { }
        private System.Void set_bindableElement(UnityEngine.UIElements.VisualElement value) { }
        private UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> get_animator() { }
        private System.Void set_animator(UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> value) { }
        private System.Int32 get_index() { }
        private System.Void set_index(System.Int32 value) { }
        private System.Int32 get_id() { }
        private System.Void set_id(System.Int32 value) { }
        private System.Boolean get_isDragGhost() { }
        private System.Void set_isDragGhost(System.Boolean value) { }
        private System.Void add_onGeometryChanged(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value) { }
        private System.Void remove_onGeometryChanged(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value) { }
        private System.Void add_onDestroy(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value) { }
        private System.Void remove_onDestroy(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value) { }
        private System.Void .ctor() { }
        private System.Void Init(UnityEngine.UIElements.VisualElement item) { }
        private System.Void PreAttachElement() { }
        private System.Void DetachElement() { }
        private System.Void DestroyElement() { }
        private System.Void SetSelected(System.Boolean selected) { }
        private System.Void SetDragGhost(System.Boolean dragGhost) { }
        private System.Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt) { }

    }

    // TypeToken: 0x20000FB
    public class ReusableListViewItem : ReusableCollectionItem
    {
        // Fields
        private UnityEngine.UIElements.VisualElement m_Container;        // 0x48
        private UnityEngine.UIElements.VisualElement m_DragHandle;        // 0x50
        private UnityEngine.UIElements.VisualElement m_ItemContainer;        // 0x58

        // Methods
        private UnityEngine.UIElements.VisualElement get_rootElement() { }
        private System.Void Init(UnityEngine.UIElements.VisualElement item, System.Boolean usesAnimatedDragger) { }
        private System.Void UpdateHierarchy(UnityEngine.UIElements.VisualElement root, UnityEngine.UIElements.VisualElement item, System.Boolean usesAnimatedDragger) { }
        private System.Void UpdateDragHandle(System.Boolean needsDragHandle) { }
        private System.Void PreAttachElement() { }
        private System.Void DetachElement() { }
        private System.Void SetDragGhost(System.Boolean dragGhost) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FC
    public class ReusableMultiColumnListViewItem : ReusableListViewItem
    {
        // Methods
        private UnityEngine.UIElements.VisualElement get_rootElement() { }
        private System.Void Init(UnityEngine.UIElements.VisualElement item) { }
        private System.Void Init(UnityEngine.UIElements.VisualElement container, UnityEngine.UIElements.Columns columns, System.Boolean usesAnimatedDrag) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FD
    public class ReusableMultiColumnTreeViewItem : ReusableTreeViewItem
    {
        // Methods
        private UnityEngine.UIElements.VisualElement get_rootElement() { }
        private System.Void Init(UnityEngine.UIElements.VisualElement item) { }
        private System.Void Init(UnityEngine.UIElements.VisualElement container, UnityEngine.UIElements.Columns columns) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FE
    public class ReusableTreeViewItem : ReusableCollectionItem
    {
        // Fields
        private UnityEngine.UIElements.Toggle m_Toggle;        // 0x48
        private UnityEngine.UIElements.VisualElement m_Container;        // 0x50
        private UnityEngine.UIElements.VisualElement m_IndentElement;        // 0x58
        private UnityEngine.UIElements.VisualElement m_BindableContainer;        // 0x60
        private UnityEngine.UIElements.VisualElement m_Checkmark;        // 0x68
        private System.Action<UnityEngine.UIElements.PointerUpEvent> onPointerUp;        // 0x70
        private System.Action<UnityEngine.UIElements.ChangeEvent<System.Boolean>> onToggleValueChanged;        // 0x78
        private System.Int32 m_Depth;        // 0x80
        private System.Single m_IndentWidth;        // 0x84
        private UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.PointerUpEvent> m_PointerUpCallback;        // 0x88
        private UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<System.Boolean>> m_ToggleValueChangedCallback;        // 0x90
        private UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.GeometryChangedEvent> m_ToggleGeometryChangedCallback;        // 0x98

        // Methods
        private UnityEngine.UIElements.VisualElement get_rootElement() { }
        private System.Void add_onPointerUp(System.Action<UnityEngine.UIElements.PointerUpEvent> value) { }
        private System.Void remove_onPointerUp(System.Action<UnityEngine.UIElements.PointerUpEvent> value) { }
        private System.Void add_onToggleValueChanged(System.Action<UnityEngine.UIElements.ChangeEvent<System.Boolean>> value) { }
        private System.Void remove_onToggleValueChanged(System.Action<UnityEngine.UIElements.ChangeEvent<System.Boolean>> value) { }
        private System.Void .ctor() { }
        private System.Void Init(UnityEngine.UIElements.VisualElement item) { }
        private System.Void InitExpandHierarchy(UnityEngine.UIElements.VisualElement root, UnityEngine.UIElements.VisualElement item) { }
        private System.Void PreAttachElement() { }
        private System.Void DetachElement() { }
        private System.Void Indent(System.Int32 depth) { }
        private System.Void SetExpandedWithoutNotify(System.Boolean expanded) { }
        private System.Void SetToggleVisibility(System.Boolean visible) { }
        private System.Void OnToggleGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt) { }
        private System.Void UpdateIndentLayout() { }
        private System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt) { }
        private System.Void OnToggleValueChanged(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt) { }

    }

    // TypeToken: 0x20000FF
    public class VerticalVirtualizationController`1 : CollectionVirtualizationController
    {
        // Fields
        private readonly UnityEngine.Pool.ObjectPool<T> m_Pool;        // 0x0
        protected UnityEngine.UIElements.BaseVerticalCollectionView m_CollectionView;        // 0x0
        protected System.Collections.Generic.List<T> m_ActiveItems;        // 0x0
        protected T m_DraggedItem;        // 0x0
        private System.Int32 m_LastFocusedElementIndex;        // 0x0
        private System.Collections.Generic.List<System.Int32> m_LastFocusedElementTreeChildIndexes;        // 0x0
        protected readonly System.Func<T,System.Boolean> m_VisibleItemPredicateDelegate;        // 0x0
        protected System.Collections.Generic.List<T> m_ScrollInsertionList;        // 0x0
        private UnityEngine.UIElements.VisualElement m_EmptyRows;        // 0x0

        // Methods
        private System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems() { }
        private System.Int32 get_itemsCount() { }
        private System.Boolean VisibleItemPredicate(T i) { }
        private T get_firstVisibleItem() { }
        private T get_lastVisibleItem() { }
        private System.Int32 get_visibleItemCount() { }
        private UnityEngine.UIElements.SerializedVirtualizationData get_serializedData() { }
        private System.Int32 get_firstVisibleIndex() { }
        private System.Void set_firstVisibleIndex(System.Int32 value) { }
        private System.Single get_lastHeight() { }
        private System.Boolean get_alwaysRebindOnRefresh() { }
        private System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView collectionView) { }
        private System.Void Refresh(System.Boolean rebuild) { }
        private System.Void Setup(T recycledItem, System.Int32 newIndex) { }
        private System.Void OnFocus(UnityEngine.UIElements.VisualElement leafTarget) { }
        private System.Void OnBlur(UnityEngine.UIElements.VisualElement willFocus) { }
        private System.Void HandleFocus(UnityEngine.UIElements.ReusableCollectionItem recycledItem, System.Int32 previousIndex) { }
        private System.Void UpdateBackground() { }
        private System.Void StartDragItem(UnityEngine.UIElements.ReusableCollectionItem item) { }
        private System.Void EndDrag(System.Int32 dropIndex) { }
        private T GetOrMakeItemAtIndex(System.Int32 activeItemIndex, System.Int32 scrollViewIndex) { }
        private System.Void ReleaseItem(System.Int32 activeItemsIndex) { }
        private System.Void OnDestroyItem(UnityEngine.UIElements.ReusableCollectionItem item) { }
        private System.Int32 GetDraggedIndex() { }

    }

    // TypeToken: 0x2000101
    public class BaseBoolField : BaseField`1
    {
        // Fields
        protected UnityEngine.UIElements.Label m_Label;        // 0x418
        protected readonly UnityEngine.UIElements.VisualElement m_CheckMark;        // 0x420
        private UnityEngine.UIElements.Clickable m_Clickable;        // 0x428
        private System.String m_OriginalText;        // 0x430

        // Methods
        private System.Void .ctor(System.String label) { }
        private System.Void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent evt) { }
        private System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt) { }
        private System.String get_text() { }
        private System.Void set_text(System.String value) { }
        private System.Void InitLabel() { }
        private System.Void SetValueWithoutNotify(System.Boolean newValue) { }
        private System.Void OnClickEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Void ToggleValue() { }
        private System.Void UpdateMixedValueContent() { }

    }

    // TypeToken: 0x2000102
    public class BaseField`1 : BindableElement, INotifyValueChanged`1
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String labelUssClassName;        // 0x0
        public static readonly System.String inputUssClassName;        // 0x0
        public static readonly System.String noLabelVariantUssClassName;        // 0x0
        public static readonly System.String labelDraggerVariantUssClassName;        // 0x0
        public static readonly System.String mixedValueLabelUssClassName;        // 0x0
        public static readonly System.String alignedFieldUssClassName;        // 0x0
        private static readonly System.String inspectorFieldUssClassName;        // 0x0
        protected internal static readonly System.String mixedValueString;        // 0x0
        protected internal static readonly UnityEngine.PropertyName serializedPropertyCopyName;        // 0x0
        private static UnityEngine.UIElements.CustomStyleProperty<System.Single> s_LabelWidthRatioProperty;        // 0x0
        private static UnityEngine.UIElements.CustomStyleProperty<System.Single> s_LabelExtraPaddingProperty;        // 0x0
        private static UnityEngine.UIElements.CustomStyleProperty<System.Single> s_LabelBaseMinWidthProperty;        // 0x0
        private System.Single m_LabelWidthRatio;        // 0x0
        private System.Single m_LabelExtraPadding;        // 0x0
        private System.Single m_LabelBaseMinWidth;        // 0x0
        private UnityEngine.UIElements.VisualElement m_VisualInput;        // 0x0
        private TValueType m_Value;        // 0x0
        private UnityEngine.UIElements.Label <labelElement>k__BackingField;        // 0x0
        private System.Boolean m_ShowMixedValue;        // 0x0
        private UnityEngine.UIElements.Label m_MixedValueLabel;        // 0x0
        private UnityEngine.UIElements.VisualElement m_CachedInspectorElement;        // 0x0
        private System.Int32 m_CachedListAndFoldoutDepth;        // 0x0

        // Methods
        private UnityEngine.UIElements.VisualElement get_visualInput() { }
        private System.Void set_visualInput(UnityEngine.UIElements.VisualElement value) { }
        private TValueType get_rawValue() { }
        private System.Void set_rawValue(TValueType value) { }
        private TValueType get_value() { }
        private System.Void set_value(TValueType value) { }
        private UnityEngine.UIElements.Label get_labelElement() { }
        private System.Void set_labelElement(UnityEngine.UIElements.Label value) { }
        private System.String get_label() { }
        private System.Void set_label(System.String value) { }
        private System.Boolean get_showMixedValue() { }
        private System.Void set_showMixedValue(System.Boolean value) { }
        private UnityEngine.UIElements.Label get_mixedValueLabel() { }
        private System.Void .ctor(System.String label) { }
        private System.Void .ctor(System.String label, UnityEngine.UIElements.VisualElement visualInput) { }
        private System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent e) { }
        private System.Void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent evt) { }
        private System.Void OnInspectorFieldGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e) { }
        private System.Void AlignLabel() { }
        private System.Void UpdateMixedValueContent() { }
        private System.Void SetValueWithoutNotify(TValueType newValue) { }
        private System.Void OnViewDataReady() { }
        private UnityEngine.Rect GetTooltipRect() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000104
    public class BaseFieldTraits`2 : UxmlTraits
    {
        // Fields
        private TValueUxmlAttributeType m_Value;        // 0x0

        // Methods
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000105
    public struct ListViewReorderMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.ListViewReorderMode Simple;        // 0x0
        public static UnityEngine.UIElements.ListViewReorderMode Animated;        // 0x0

    }

    // TypeToken: 0x2000106
    public class BaseListView : BaseVerticalCollectionView
    {
        // Fields
        private static readonly System.String k_SizeFieldLabel;        // 0x0
        private System.Boolean m_ShowBoundCollectionSize;        // 0x4A8
        private System.Boolean m_ShowFoldoutHeader;        // 0x4A9
        private System.String m_HeaderTitle;        // 0x4B0
        private System.Action<System.Collections.Generic.IEnumerable<System.Int32>> itemsAdded;        // 0x4B8
        private System.Action<System.Collections.Generic.IEnumerable<System.Int32>> itemsRemoved;        // 0x4C0
        private System.Action itemsSourceSizeChanged;        // 0x4C8
        private UnityEngine.UIElements.Label m_ListViewLabel;        // 0x4D0
        protected UnityEngine.UIElements.Foldout m_Foldout;        // 0x4D8
        protected UnityEngine.UIElements.TextField m_ArraySizeField;        // 0x4E0
        private System.Boolean m_IsOverMultiEditLimit;        // 0x4E8
        private UnityEngine.UIElements.VisualElement m_Footer;        // 0x4F0
        private UnityEngine.UIElements.Button m_AddButton;        // 0x4F8
        private UnityEngine.UIElements.Button m_RemoveButton;        // 0x500
        private System.Action<System.Collections.Generic.IEnumerable<System.Int32>> m_ItemAddedCallback;        // 0x508
        private System.Action<System.Collections.Generic.IEnumerable<System.Int32>> m_ItemRemovedCallback;        // 0x510
        private System.Action m_ItemsSourceSizeChangedCallback;        // 0x518
        private UnityEngine.UIElements.ListViewReorderMode m_ReorderMode;        // 0x520
        private System.Action reorderModeChanged;        // 0x528
        public static readonly System.String ussClassName;        // 0x8
        public static readonly System.String itemUssClassName;        // 0x10
        public static readonly System.String emptyLabelUssClassName;        // 0x18
        public static readonly System.String overMaxMultiEditLimitClassName;        // 0x20
        public static readonly System.String reorderableUssClassName;        // 0x28
        public static readonly System.String reorderableItemUssClassName;        // 0x30
        public static readonly System.String reorderableItemContainerUssClassName;        // 0x38
        public static readonly System.String reorderableItemHandleUssClassName;        // 0x40
        public static readonly System.String reorderableItemHandleBarUssClassName;        // 0x48
        public static readonly System.String footerUssClassName;        // 0x50
        public static readonly System.String foldoutHeaderUssClassName;        // 0x58
        public static readonly System.String arraySizeFieldUssClassName;        // 0x60
        public static readonly System.String arraySizeFieldWithHeaderUssClassName;        // 0x68
        public static readonly System.String arraySizeFieldWithFooterUssClassName;        // 0x70
        public static readonly System.String listViewWithHeaderUssClassName;        // 0x78
        public static readonly System.String listViewWithFooterUssClassName;        // 0x80
        public static readonly System.String scrollViewWithFooterUssClassName;        // 0x88
        public static readonly System.String footerAddButtonName;        // 0x90
        public static readonly System.String footerRemoveButtonName;        // 0x98
        private System.String m_MaxMultiEditStr;        // 0x530
        private static readonly System.String k_EmptyListStr;        // 0xA0

        // Methods
        private System.Boolean get_showBoundCollectionSize() { }
        private System.Void set_showBoundCollectionSize(System.Boolean value) { }
        private System.Boolean get_showFoldoutHeader() { }
        private System.Void set_showFoldoutHeader(System.Boolean value) { }
        private System.Void SetupArraySizeField() { }
        private System.Void set_headerTitle(System.String value) { }
        private System.Boolean get_showAddRemoveFooter() { }
        private System.Void set_showAddRemoveFooter(System.Boolean value) { }
        private System.Void EnableFooter(System.Boolean enabled) { }
        private System.Void AddItems(System.Int32 itemCount) { }
        private System.Void OnArraySizeFieldChanged(UnityEngine.UIElements.ChangeEvent<System.String> evt) { }
        private System.Void UpdateArraySizeField() { }
        private System.Void UpdateListViewLabel() { }
        private System.Void OnAddClicked() { }
        private System.Void OnRemoveClicked() { }
        private UnityEngine.UIElements.VisualElement get_footer() { }
        private UnityEngine.UIElements.BaseListViewController get_viewController() { }
        private System.Void CreateVirtualizationController() { }
        private System.Void SetViewController(UnityEngine.UIElements.CollectionViewController controller) { }
        private System.Void OnItemAdded(System.Collections.Generic.IEnumerable<System.Int32> indices) { }
        private System.Void OnItemsRemoved(System.Collections.Generic.IEnumerable<System.Int32> indices) { }
        private System.Void OnItemsSourceSizeChanged() { }
        private System.Void add_reorderModeChanged(System.Action value) { }
        private System.Void remove_reorderModeChanged(System.Action value) { }
        private UnityEngine.UIElements.ListViewReorderMode get_reorderMode() { }
        private System.Void set_reorderMode(UnityEngine.UIElements.ListViewReorderMode value) { }
        private UnityEngine.UIElements.ListViewDragger CreateDragger() { }
        private UnityEngine.UIElements.ICollectionDragAndDropController CreateDragAndDropController() { }
        private System.Void .ctor() { }
        private System.Void PostRefresh() { }
        private System.Boolean HandleItemNavigation(System.Boolean moveIn, System.Boolean altPressed) { }
        private System.Void .cctor() { }
        private System.Void <OnAddClicked>b__38_0() { }

    }

    // TypeToken: 0x2000108
    public struct SliderDirection
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.SliderDirection Horizontal;        // 0x0
        public static UnityEngine.UIElements.SliderDirection Vertical;        // 0x0

    }

    // TypeToken: 0x2000109
    public class BaseSlider`1 : BaseField`1
    {
        // Fields
        private UnityEngine.UIElements.VisualElement <dragContainer>k__BackingField;        // 0x0
        private UnityEngine.UIElements.VisualElement <dragElement>k__BackingField;        // 0x0
        private UnityEngine.UIElements.VisualElement <dragBorderElement>k__BackingField;        // 0x0
        private UnityEngine.UIElements.TextField <inputTextField>k__BackingField;        // 0x0
        private TValueType m_LowValue;        // 0x0
        private TValueType m_HighValue;        // 0x0
        private System.Single m_PageSize;        // 0x0
        private System.Boolean m_ShowInputField;        // 0x0
        private System.Boolean <clamped>k__BackingField;        // 0x0
        private UnityEngine.UIElements.ClampedDragger<TValueType> <clampedDragger>k__BackingField;        // 0x0
        private UnityEngine.Rect m_DragElementStartPos;        // 0x0
        private UnityEngine.UIElements.SliderDirection m_Direction;        // 0x0
        private System.Boolean m_Inverted;        // 0x0
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String labelUssClassName;        // 0x0
        public static readonly System.String inputUssClassName;        // 0x0
        public static readonly System.String horizontalVariantUssClassName;        // 0x0
        public static readonly System.String verticalVariantUssClassName;        // 0x0
        public static readonly System.String dragContainerUssClassName;        // 0x0
        public static readonly System.String trackerUssClassName;        // 0x0
        public static readonly System.String draggerUssClassName;        // 0x0
        public static readonly System.String draggerBorderUssClassName;        // 0x0
        public static readonly System.String textFieldClassName;        // 0x0

        // Methods
        private UnityEngine.UIElements.VisualElement get_dragContainer() { }
        private System.Void set_dragContainer(UnityEngine.UIElements.VisualElement value) { }
        private UnityEngine.UIElements.VisualElement get_dragElement() { }
        private System.Void set_dragElement(UnityEngine.UIElements.VisualElement value) { }
        private UnityEngine.UIElements.VisualElement get_dragBorderElement() { }
        private System.Void set_dragBorderElement(UnityEngine.UIElements.VisualElement value) { }
        private UnityEngine.UIElements.TextField get_inputTextField() { }
        private System.Void set_inputTextField(UnityEngine.UIElements.TextField value) { }
        private TValueType get_lowValue() { }
        private System.Void set_lowValue(TValueType value) { }
        private TValueType get_highValue() { }
        private System.Void set_highValue(TValueType value) { }
        private System.Void SetHighValueWithoutNotify(TValueType newHighValue) { }
        private System.Single get_pageSize() { }
        private System.Void set_pageSize(System.Single value) { }
        private System.Boolean get_showInputField() { }
        private System.Void set_showInputField(System.Boolean value) { }
        private System.Boolean get_clamped() { }
        private System.Void set_clamped(System.Boolean value) { }
        private UnityEngine.UIElements.ClampedDragger<TValueType> get_clampedDragger() { }
        private System.Void set_clampedDragger(UnityEngine.UIElements.ClampedDragger<TValueType> value) { }
        private TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound) { }
        private TValueType GetClampedValue(TValueType newValue) { }
        private TValueType get_value() { }
        private System.Void set_value(TValueType value) { }
        private System.Void SetValueWithoutNotify(TValueType newValue) { }
        private UnityEngine.UIElements.SliderDirection get_direction() { }
        private System.Void set_direction(UnityEngine.UIElements.SliderDirection value) { }
        private System.Boolean get_inverted() { }
        private System.Void set_inverted(System.Boolean value) { }
        private System.Void .ctor(System.String label, TValueType start, TValueType end, UnityEngine.UIElements.SliderDirection direction, System.Single pageSize) { }
        private System.Single GetClosestPowerOfTen(System.Single positiveNumber) { }
        private System.Single RoundToMultipleOf(System.Single value, System.Single roundingValue) { }
        private System.Void ClampValue() { }
        private TValueType SliderLerpUnclamped(TValueType a, TValueType b, System.Single interpolant) { }
        private System.Single SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue) { }
        private TValueType ParseStringToValue(System.String stringValue) { }
        private System.Void ComputeValueFromKey(UnityEngine.UIElements.BaseSlider.SliderKey<TValueType> sliderKey, System.Boolean isShift) { }
        private TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, System.Single positionInterpolant) { }
        private System.Void SetSliderValueFromDrag() { }
        private System.Void ComputeValueAndDirectionFromDrag(System.Single sliderLength, System.Single dragElementLength, System.Single dragElementPos) { }
        private System.Void SetSliderValueFromClick() { }
        private System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt) { }
        private System.Void ComputeValueAndDirectionFromClick(System.Single sliderLength, System.Single dragElementLength, System.Single dragElementPos, System.Single dragElementLastPos) { }
        private System.Void AdjustDragElement(System.Single factor) { }
        private System.Void UpdateDragElementPosition(UnityEngine.UIElements.GeometryChangedEvent evt) { }
        private System.Void OnViewDataReady() { }
        private System.Boolean SameValues(System.Single a, System.Single b, System.Single epsilon) { }
        private System.Void UpdateDragElementPosition() { }
        private System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt) { }
        private System.Void UpdateTextFieldVisibility() { }
        private System.Void UpdateTextFieldValue() { }
        private System.Void OnTextFieldFocusOut(UnityEngine.UIElements.FocusOutEvent evt) { }
        private System.Void OnTextFieldValueChange(UnityEngine.UIElements.ChangeEvent<System.String> evt) { }
        private System.Void UpdateMixedValueContent() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200010B
    public class BaseTreeView : BaseVerticalCollectionView
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String itemUssClassName;        // 0x8
        public static readonly System.String itemToggleUssClassName;        // 0x10
        public static readonly System.String itemIndentsContainerUssClassName;        // 0x18
        public static readonly System.String itemIndentUssClassName;        // 0x20
        public static readonly System.String itemContentContainerUssClassName;        // 0x28
        private System.Boolean m_AutoExpand;        // 0x4A8
        private System.Collections.Generic.List<System.Int32> m_ExpandedItemIds;        // 0x4B0

        // Methods
        private System.Collections.IList get_itemsSource() { }
        private UnityEngine.UIElements.BaseTreeViewController get_viewController() { }
        private System.Void CreateVirtualizationController() { }
        private System.Void SetViewController(UnityEngine.UIElements.CollectionViewController controller) { }
        private System.Void OnItemIndexChanged(System.Int32 srcIndex, System.Int32 dstIndex) { }
        private UnityEngine.UIElements.ICollectionDragAndDropController CreateDragAndDropController() { }
        private System.Boolean get_autoExpand() { }
        private System.Void set_autoExpand(System.Boolean value) { }
        private System.Collections.Generic.List<System.Int32> get_expandedItemIds() { }
        private System.Void set_expandedItemIds(System.Collections.Generic.List<System.Int32> value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 itemHeight) { }
        private System.Void OnViewDataReady() { }
        private System.Boolean HandleItemNavigation(System.Boolean moveIn, System.Boolean altPressed) { }
        private System.Void SetSelectionById(System.Int32 id) { }
        private System.Void SetSelectionById(System.Collections.Generic.IEnumerable<System.Int32> ids) { }
        private System.Void SetSelectionInternalById(System.Collections.Generic.IEnumerable<System.Int32> ids, System.Boolean sendNotification) { }
        private System.Int32 GetItemIndex(System.Int32 id, System.Boolean expand) { }
        private System.Boolean IsExpanded(System.Int32 id) { }
        private System.Void CollapseItem(System.Int32 id, System.Boolean collapseAllChildren) { }
        private System.Void ExpandItem(System.Int32 id, System.Boolean expandAllChildren) { }
        private System.Void OnTreeViewPointerUp(UnityEngine.UIElements.PointerUpEvent evt) { }
        private System.Boolean IsExpandedByIndex(System.Int32 index) { }
        private System.Void CollapseItemByIndex(System.Int32 index, System.Boolean collapseAll) { }
        private System.Void ExpandItemByIndex(System.Int32 index, System.Boolean expandAll) { }
        private System.Void .cctor() { }
        private System.Int32 <SetSelectionInternalById>b__47_0(System.Int32 id) { }

    }

    // TypeToken: 0x200010D
    public struct AlternatingRowBackground
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.AlternatingRowBackground None;        // 0x0
        public static UnityEngine.UIElements.AlternatingRowBackground ContentOnly;        // 0x0
        public static UnityEngine.UIElements.AlternatingRowBackground All;        // 0x0

    }

    // TypeToken: 0x200010E
    public struct CollectionVirtualizationMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.CollectionVirtualizationMethod FixedHeight;        // 0x0
        public static UnityEngine.UIElements.CollectionVirtualizationMethod DynamicHeight;        // 0x0

    }

    // TypeToken: 0x200010F
    public class SerializedVirtualizationData
    {
        // Fields
        public UnityEngine.Vector2 scrollOffset;        // 0x10
        public System.Int32 firstVisibleIndex;        // 0x18
        public System.Single contentPadding;        // 0x1C
        public System.Single contentHeight;        // 0x20
        public System.Int32 anchoredItemIndex;        // 0x24
        public System.Single anchorOffset;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000110
    public class BaseVerticalCollectionView : BindableElement, ISerializationCallbackReceiver
    {
        // Fields
        private static readonly Unity.Profiling.ProfilerMarker k_RefreshMarker;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker k_RebuildMarker;        // 0x8
        private System.Action<System.Collections.Generic.IEnumerable<System.Object>> itemsChosen;        // 0x3D0
        private System.Action<System.Collections.Generic.IEnumerable<System.Object>> selectionChanged;        // 0x3D8
        private System.Action<System.Collections.Generic.IEnumerable<System.Int32>> selectedIndicesChanged;        // 0x3E0
        private System.Action<System.Int32,System.Int32> itemIndexChanged;        // 0x3E8
        private System.Action itemsSourceChanged;        // 0x3F0
        private System.Action selectionNotChanged;        // 0x3F8
        private System.Func<UnityEngine.UIElements.CanStartDragArgs,System.Boolean> canStartDrag;        // 0x400
        private System.Func<UnityEngine.UIElements.SetupDragAndDropArgs,UnityEngine.UIElements.StartDragArgs> setupDragAndDrop;        // 0x408
        private System.Func<UnityEngine.UIElements.HandleDragAndDropArgs,UnityEngine.UIElements.DragVisualMode> dragAndDropUpdate;        // 0x410
        private System.Func<UnityEngine.UIElements.HandleDragAndDropArgs,UnityEngine.UIElements.DragVisualMode> handleDrop;        // 0x418
        private UnityEngine.UIElements.SelectionType m_SelectionType;        // 0x420
        private static readonly System.Collections.Generic.List<UnityEngine.UIElements.ReusableCollectionItem> k_EmptyItems;        // 0x10
        private System.Boolean m_HorizontalScrollingEnabled;        // 0x424
        private UnityEngine.UIElements.AlternatingRowBackground m_ShowAlternatingRowBackgrounds;        // 0x428
        private static readonly System.Int32 s_DefaultItemHeight;        // 0x18
        private System.Single m_FixedItemHeight;        // 0x42C
        private System.Boolean m_ItemHeightIsInline;        // 0x430
        private UnityEngine.UIElements.CollectionVirtualizationMethod m_VirtualizationMethod;        // 0x434
        private readonly UnityEngine.UIElements.ScrollView m_ScrollView;        // 0x438
        private UnityEngine.UIElements.CollectionViewController m_ViewController;        // 0x440
        private UnityEngine.UIElements.CollectionVirtualizationController m_VirtualizationController;        // 0x448
        private UnityEngine.UIElements.KeyboardNavigationManipulator m_NavigationManipulator;        // 0x450
        private UnityEngine.UIElements.SerializedVirtualizationData serializedVirtualizationData;        // 0x458
        private readonly System.Collections.Generic.List<System.Int32> m_SelectedIds;        // 0x460
        private readonly UnityEngine.UIElements.BaseVerticalCollectionView.Selection m_Selection;        // 0x468
        private System.Single m_LastHeight;        // 0x470
        private System.Boolean m_IsRangeSelectionDirectionUp;        // 0x474
        private UnityEngine.UIElements.ListViewDragger m_Dragger;        // 0x478
        private static UnityEngine.UIElements.CustomStyleProperty<System.Int32> s_ItemHeightProperty;        // 0x20
        private System.Action<System.Int32,System.Int32> m_ItemIndexChangedCallback;        // 0x480
        private System.Action m_ItemsSourceChangedCallback;        // 0x488
        private UnityEngine.UIElements.IVisualElementScheduledItem m_RebuildScheduled;        // 0x490
        public static readonly System.String ussClassName;        // 0x28
        public static readonly System.String borderUssClassName;        // 0x30
        public static readonly System.String itemUssClassName;        // 0x38
        public static readonly System.String dragHoverBarUssClassName;        // 0x40
        public static readonly System.String dragHoverMarkerUssClassName;        // 0x48
        public static readonly System.String itemDragHoverUssClassName;        // 0x50
        public static readonly System.String itemSelectedVariantUssClassName;        // 0x58
        public static readonly System.String itemAlternativeBackgroundUssClassName;        // 0x60
        public static readonly System.String listScrollViewUssClassName;        // 0x68
        private static readonly System.String backgroundFillUssClassName;        // 0x70
        private UnityEngine.Vector3 m_TouchDownPosition;        // 0x498

        // Methods
        private System.Boolean HasCanStartDrag() { }
        private System.Boolean RaiseCanStartDrag(UnityEngine.UIElements.ReusableCollectionItem item, System.Collections.Generic.IEnumerable<System.Int32> ids) { }
        private UnityEngine.UIElements.StartDragArgs RaiseSetupDragAndDrop(UnityEngine.UIElements.ReusableCollectionItem item, System.Collections.Generic.IEnumerable<System.Int32> ids, UnityEngine.UIElements.StartDragArgs args) { }
        private UnityEngine.UIElements.DragVisualMode RaiseHandleDragAndDrop(UnityEngine.Vector2 pointerPosition, UnityEngine.UIElements.DragAndDropArgs dragAndDropArgs) { }
        private UnityEngine.UIElements.DragVisualMode RaiseDrop(UnityEngine.Vector2 pointerPosition, UnityEngine.UIElements.DragAndDropArgs dragAndDropArgs) { }
        private System.Collections.IList get_itemsSource() { }
        private System.Void set_itemsSource(System.Collections.IList value) { }
        private UnityEngine.UIElements.VisualElement get_contentContainer() { }
        private UnityEngine.UIElements.SelectionType get_selectionType() { }
        private System.Void set_selectionType(UnityEngine.UIElements.SelectionType value) { }
        private System.Collections.Generic.IEnumerable<System.Object> get_selectedItems() { }
        private System.Int32 get_selectedIndex() { }
        private System.Void set_selectedIndex(System.Int32 value) { }
        private System.Collections.Generic.IEnumerable<System.Int32> get_selectedIndices() { }
        private System.Collections.Generic.IEnumerable<System.Int32> get_selectedIds() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems() { }
        private UnityEngine.UIElements.ScrollView get_scrollView() { }
        private UnityEngine.UIElements.ListViewDragger get_dragger() { }
        private UnityEngine.UIElements.CollectionVirtualizationController get_virtualizationController() { }
        private UnityEngine.UIElements.CollectionViewController get_viewController() { }
        private System.Single ResolveItemHeight(System.Single height) { }
        private System.Void set_showBorder(System.Boolean value) { }
        private System.Boolean get_reorderable() { }
        private System.Void set_reorderable(System.Boolean value) { }
        private System.Void set_horizontalScrollingEnabled(System.Boolean value) { }
        private UnityEngine.UIElements.AlternatingRowBackground get_showAlternatingRowBackgrounds() { }
        private System.Void set_showAlternatingRowBackgrounds(UnityEngine.UIElements.AlternatingRowBackground value) { }
        private UnityEngine.UIElements.CollectionVirtualizationMethod get_virtualizationMethod() { }
        private System.Void set_virtualizationMethod(UnityEngine.UIElements.CollectionVirtualizationMethod value) { }
        private System.Single get_fixedItemHeight() { }
        private System.Void set_fixedItemHeight(System.Single value) { }
        private System.Single get_lastHeight() { }
        private System.Void CreateVirtualizationController() { }
        private UnityEngine.UIElements.CollectionVirtualizationController GetOrCreateVirtualizationController() { }
        private System.Void CreateVirtualizationController() { }
        private UnityEngine.UIElements.CollectionViewController GetOrCreateViewController() { }
        private UnityEngine.UIElements.CollectionViewController CreateViewController() { }
        private System.Void SetViewController(UnityEngine.UIElements.CollectionViewController controller) { }
        private UnityEngine.UIElements.ListViewDragger CreateDragger() { }
        private System.Void InitializeDragAndDropController(System.Boolean enableReordering) { }
        private UnityEngine.UIElements.ICollectionDragAndDropController CreateDragAndDropController() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.IList itemsSource, System.Single itemHeight) { }
        private UnityEngine.UIElements.VisualElement GetRootElementForId(System.Int32 id) { }
        private System.Boolean HasValidDataAndBindings() { }
        private System.Void OnItemIndexChanged(System.Int32 srcIndex, System.Int32 dstIndex) { }
        private System.Void OnItemsSourceChanged() { }
        private System.Void RefreshItems() { }
        private System.Void Rebuild() { }
        private System.Void ScheduleRebuild() { }
        private System.Void RefreshSelection() { }
        private System.Void PostRefresh() { }
        private System.Void ScrollToItem(System.Int32 index) { }
        private System.Void ScrollToItemById(System.Int32 id) { }
        private System.Void OnScroll(UnityEngine.Vector2 offset) { }
        private System.Void Resize(UnityEngine.Vector2 size) { }
        private System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt) { }
        private System.Void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt) { }
        private System.Boolean Apply(UnityEngine.UIElements.KeyboardNavigationOperation op, System.Boolean shiftKey, System.Boolean altKey) { }
        private System.Void Apply(UnityEngine.UIElements.KeyboardNavigationOperation op, UnityEngine.UIElements.EventBase sourceEvent) { }
        private System.Boolean HandleItemNavigation(System.Boolean moveIn, System.Boolean altKey) { }
        private System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt) { }
        private System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt) { }
        private System.Void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt) { }
        private System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt) { }
        private System.Void ProcessPointerDown(UnityEngine.UIElements.IPointerEvent evt) { }
        private System.Void ProcessPointerUp(UnityEngine.UIElements.IPointerEvent evt) { }
        private System.Void DoSelect(UnityEngine.Vector2 localPosition, System.Int32 clickCount, System.Boolean actionKey, System.Boolean shiftKey) { }
        private System.Void DoRangeSelection(System.Int32 rangeSelectionFinalIndex) { }
        private System.Void ProcessSingleClick(System.Int32 clickedIndex) { }
        private System.Void SelectAll() { }
        private System.Void AddToSelection(System.Int32 index) { }
        private System.Void AddToSelection(System.Collections.Generic.IList<System.Int32> indexes) { }
        private System.Void AddToSelectionWithoutValidation(System.Int32 index) { }
        private System.Void RemoveFromSelection(System.Int32 index) { }
        private System.Void RemoveFromSelectionWithoutValidation(System.Int32 index) { }
        private System.Void SetSelection(System.Int32 index) { }
        private System.Void SetSelection(System.Collections.Generic.IEnumerable<System.Int32> indices) { }
        private System.Void SetSelectionWithoutNotify(System.Collections.Generic.IEnumerable<System.Int32> indices) { }
        private System.Void SetSelectionInternal(System.Collections.Generic.IEnumerable<System.Int32> indices, System.Boolean sendNotification) { }
        private System.Boolean MatchesExistingSelection(System.Collections.Generic.IEnumerable<System.Int32> indices) { }
        private System.Void NotifyOfSelectionChange() { }
        private System.Void ClearSelection() { }
        private System.Void ClearSelectionWithoutValidation() { }
        private System.Void OnViewDataReady() { }
        private System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt) { }
        private System.Void OnSizeChanged(UnityEngine.UIElements.GeometryChangedEvent evt) { }
        private System.Void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e) { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void .cctor() { }
        private System.Void <.ctor>b__160_0(System.Single v) { }
        private System.Void <RefreshSelection>g__NotifyIfChanged|173_0(UnityEngine.UIElements.BaseVerticalCollectionView.<>c__DisplayClass173_0& ) { }
        private System.Void <Apply>g__HandleSelectionAndScroll|184_0(System.Int32 index, UnityEngine.UIElements.BaseVerticalCollectionView.<>c__DisplayClass184_0& ) { }

    }

    // TypeToken: 0x2000117
    public interface IBindable
    {
        // Methods
        private UnityEngine.UIElements.IBinding get_binding() { }
        private System.Void set_bindingPath(System.String value) { }

    }

    // TypeToken: 0x2000118
    public interface IBinding
    {
        // Methods
        private System.Void PreUpdate() { }
        private System.Void Update() { }
        private System.Void Release() { }

    }

    // TypeToken: 0x2000119
    public class Box : VisualElement
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200011B
    public class Button : TextElement
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        private UnityEngine.UIElements.Clickable m_Clickable;        // 0x488
        private static readonly System.String NonEmptyString;        // 0x8

        // Methods
        private UnityEngine.UIElements.Clickable get_clickable() { }
        private System.Void set_clickable(UnityEngine.UIElements.Clickable value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Action clickEvent) { }
        private System.Void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent evt) { }
        private System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt) { }
        private UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200011E
    public class ButtonStripField : BaseField`1
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.Button> m_Buttons;        // 0x418

        // Methods
        private System.Collections.Generic.List<UnityEngine.UIElements.Button> get_buttons() { }
        private System.Void .ctor() { }
        private System.Void SetValueWithoutNotify(System.Int32 newValue) { }
        private System.Void RefreshButtonsState() { }

    }

    // TypeToken: 0x2000121
    public class DropdownField : BaseField`1
    {
        // Fields
        private System.Collections.Generic.List<System.String> m_Choices;        // 0x418
        private UnityEngine.UIElements.TextElement m_TextElement;        // 0x420
        private UnityEngine.UIElements.VisualElement m_ArrowElement;        // 0x428
        private System.Func<System.String,System.String> m_FormatSelectedValueCallback;        // 0x430
        private System.Func<System.String,System.String> m_FormatListItemCallback;        // 0x438
        private System.Func<UnityEngine.UIElements.IGenericMenu> createMenuCallback;        // 0x440
        private System.Int32 m_Index;        // 0x448
        private static readonly System.String ussClassNameBasePopupField;        // 0x0
        private static readonly System.String textUssClassNameBasePopupField;        // 0x8
        private static readonly System.String arrowUssClassNameBasePopupField;        // 0x10
        private static readonly System.String labelUssClassNameBasePopupField;        // 0x18
        private static readonly System.String inputUssClassNameBasePopupField;        // 0x20
        private static readonly System.String ussClassNamePopupField;        // 0x28
        private static readonly System.String labelUssClassNamePopupField;        // 0x30
        private static readonly System.String inputUssClassNamePopupField;        // 0x38

        // Methods
        private UnityEngine.UIElements.TextElement get_textElement() { }
        private System.String GetValueToDisplay() { }
        private System.String GetListItemToDisplay(System.String value) { }
        private System.Void set_index(System.Int32 value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String label) { }
        private System.Void AddMenuItems(UnityEngine.UIElements.IGenericMenu menu) { }
        private System.Void ChangeValueFromMenu(System.String menuItem) { }
        private System.Void set_choices(System.Collections.Generic.List<System.String> value) { }
        private System.String get_value() { }
        private System.Void set_value(System.String value) { }
        private System.Void SetValueWithoutNotify(System.String newValue) { }
        private System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt) { }
        private System.Void ShowMenu() { }
        private System.Void UpdateMixedValueContent() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000126
    public class Foldout : BindableElement, INotifyValueChanged`1
    {
        // Fields
        private UnityEngine.UIElements.Toggle m_Toggle;        // 0x3D0
        private UnityEngine.UIElements.VisualElement m_Container;        // 0x3D8
        private System.Boolean m_Value;        // 0x3E0
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String toggleUssClassName;        // 0x8
        public static readonly System.String contentUssClassName;        // 0x10
        public static readonly System.String inputUssClassName;        // 0x18
        public static readonly System.String checkmarkUssClassName;        // 0x20
        public static readonly System.String textUssClassName;        // 0x28
        private static readonly System.String ussFoldoutDepthClassName;        // 0x30
        private static readonly System.Int32 ussFoldoutMaxDepth;        // 0x38

        // Methods
        private UnityEngine.UIElements.Toggle get_toggle() { }
        private UnityEngine.UIElements.VisualElement get_contentContainer() { }
        private System.Void set_text(System.String value) { }
        private System.Boolean get_value() { }
        private System.Void set_value(System.Boolean value) { }
        private System.Void SetValueWithoutNotify(System.Boolean newValue) { }
        private System.Void OnViewDataReady() { }
        private System.Void .ctor() { }
        private System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt) { }
        private System.Void .cctor() { }
        private System.Void <.ctor>b__25_0(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt) { }

    }

    // TypeToken: 0x2000129
    public interface IGenericMenu
    {
        // Methods
        private System.Void AddItem(System.String itemName, System.Boolean isChecked, System.Action action) { }
        private System.Void DropDown(UnityEngine.Rect position, UnityEngine.UIElements.VisualElement targetElement, System.Boolean anchored) { }

    }

    // TypeToken: 0x200012A
    public class GenericDropdownMenu, IGenericMenu
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String itemUssClassName;        // 0x8
        public static readonly System.String labelUssClassName;        // 0x10
        public static readonly System.String containerInnerUssClassName;        // 0x18
        public static readonly System.String containerOuterUssClassName;        // 0x20
        public static readonly System.String checkmarkUssClassName;        // 0x28
        public static readonly System.String separatorUssClassName;        // 0x30
        private System.Collections.Generic.List<UnityEngine.UIElements.GenericDropdownMenu.MenuItem> m_Items;        // 0x10
        private UnityEngine.UIElements.VisualElement m_MenuContainer;        // 0x18
        private UnityEngine.UIElements.VisualElement m_OuterContainer;        // 0x20
        private UnityEngine.UIElements.ScrollView m_ScrollView;        // 0x28
        private UnityEngine.UIElements.VisualElement m_PanelRootVisualContainer;        // 0x30
        private UnityEngine.UIElements.VisualElement m_TargetElement;        // 0x38
        private UnityEngine.Rect m_DesiredRect;        // 0x40
        private UnityEngine.UIElements.KeyboardNavigationManipulator m_NavigationManipulator;        // 0x50
        private UnityEngine.Vector2 m_MousePosition;        // 0x58

        // Methods
        private UnityEngine.UIElements.VisualElement get_contentContainer() { }
        private System.Void .ctor() { }
        private System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt) { }
        private System.Void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt) { }
        private System.Void Hide() { }
        private System.Void Apply(UnityEngine.UIElements.KeyboardNavigationOperation op, UnityEngine.UIElements.EventBase sourceEvent) { }
        private System.Boolean Apply(UnityEngine.UIElements.KeyboardNavigationOperation op) { }
        private System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt) { }
        private System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt) { }
        private System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt) { }
        private System.Void OnFocusOut(UnityEngine.UIElements.FocusOutEvent evt) { }
        private System.Void OnParentResized(UnityEngine.UIElements.GeometryChangedEvent evt) { }
        private System.Void UpdateSelection(UnityEngine.UIElements.VisualElement target) { }
        private System.Void ChangeSelectedIndex(System.Int32 newIndex, System.Int32 previousIndex) { }
        private System.Int32 GetSelectedIndex() { }
        private System.Void AddItem(System.String itemName, System.Boolean isChecked, System.Action action) { }
        private System.Void AddSeparator(System.String path) { }
        private UnityEngine.UIElements.GenericDropdownMenu.MenuItem AddItem(System.String itemName, System.Boolean isChecked, System.Boolean isEnabled, System.Object data) { }
        private System.Void DropDown(UnityEngine.Rect position, UnityEngine.UIElements.VisualElement targetElement, System.Boolean anchored) { }
        private System.Void OnTargetElementDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt) { }
        private System.Void OnContainerGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt) { }
        private System.Void EnsureVisibilityInParent() { }
        private System.Void .cctor() { }
        private System.Void <Apply>g__UpdateSelectionDown|27_0(System.Int32 newIndex, UnityEngine.UIElements.GenericDropdownMenu.<>c__DisplayClass27_0& ) { }
        private System.Void <Apply>g__UpdateSelectionUp|27_1(System.Int32 newIndex, UnityEngine.UIElements.GenericDropdownMenu.<>c__DisplayClass27_0& ) { }

    }

    // TypeToken: 0x200012D
    public class GroupBox : BindableElement, IGroupBox
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String labelUssClassName;        // 0x8
        private UnityEngine.UIElements.Label m_TitleLabel;        // 0x3D0

        // Methods
        private System.Void set_text(System.String value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String text) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000130
    public struct HelpBoxMessageType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.HelpBoxMessageType None;        // 0x0
        public static UnityEngine.UIElements.HelpBoxMessageType Info;        // 0x0
        public static UnityEngine.UIElements.HelpBoxMessageType Warning;        // 0x0
        public static UnityEngine.UIElements.HelpBoxMessageType Error;        // 0x0

    }

    // TypeToken: 0x2000131
    public class HelpBox : VisualElement
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String labelUssClassName;        // 0x8
        public static readonly System.String iconUssClassName;        // 0x10
        public static readonly System.String iconInfoUssClassName;        // 0x18
        public static readonly System.String iconwarningUssClassName;        // 0x20
        public static readonly System.String iconErrorUssClassName;        // 0x28
        private UnityEngine.UIElements.HelpBoxMessageType m_HelpBoxMessageType;        // 0x3C0
        private UnityEngine.UIElements.VisualElement m_Icon;        // 0x3C8
        private System.String m_IconClass;        // 0x3D0
        private UnityEngine.UIElements.Label m_Label;        // 0x3D8

        // Methods
        private System.Void set_text(System.String value) { }
        private System.Void set_messageType(UnityEngine.UIElements.HelpBoxMessageType value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String text, UnityEngine.UIElements.HelpBoxMessageType messageType) { }
        private System.String GetIconClass(UnityEngine.UIElements.HelpBoxMessageType messageType) { }
        private System.Void UpdateIcon(UnityEngine.UIElements.HelpBoxMessageType messageType) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000134
    public class Image : VisualElement
    {
        // Fields
        private UnityEngine.ScaleMode m_ScaleMode;        // 0x3C0
        private UnityEngine.Texture m_Image;        // 0x3C8
        private UnityEngine.Sprite m_Sprite;        // 0x3D0
        private UnityEngine.UIElements.VectorImage m_VectorImage;        // 0x3D8
        private UnityEngine.Rect m_UV;        // 0x3E0
        private UnityEngine.Color m_TintColor;        // 0x3F0
        private System.Boolean m_ImageIsInline;        // 0x400
        private System.Boolean m_ScaleModeIsInline;        // 0x401
        private System.Boolean m_TintColorIsInline;        // 0x402
        public static readonly System.String ussClassName;        // 0x0
        private static UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> s_ImageProperty;        // 0x8
        private static UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> s_SpriteProperty;        // 0x10
        private static UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> s_VectorImageProperty;        // 0x18
        private static UnityEngine.UIElements.CustomStyleProperty<System.String> s_ScaleModeProperty;        // 0x20
        private static UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> s_TintColorProperty;        // 0x28

        // Methods
        private UnityEngine.Texture get_image() { }
        private System.Void set_image(UnityEngine.Texture value) { }
        private UnityEngine.Sprite get_sprite() { }
        private System.Void set_sprite(UnityEngine.Sprite value) { }
        private UnityEngine.UIElements.VectorImage get_vectorImage() { }
        private System.Void set_vectorImage(UnityEngine.UIElements.VectorImage value) { }
        private UnityEngine.Rect get_sourceRect() { }
        private UnityEngine.Rect get_uv() { }
        private UnityEngine.ScaleMode get_scaleMode() { }
        private UnityEngine.Color get_tintColor() { }
        private System.Void .ctor() { }
        private UnityEngine.Vector2 GetTextureDisplaySize(UnityEngine.Texture texture) { }
        private UnityEngine.Vector2 GetTextureDisplaySize(UnityEngine.Sprite sprite) { }
        private UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode) { }
        private System.Void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc) { }
        private System.Void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e) { }
        private System.Void SetScaleMode(UnityEngine.ScaleMode mode) { }
        private UnityEngine.Rect GetSourceRect() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000137
    public interface INotifyValueChanged`1
    {
        // Methods
        private T get_value() { }
        private System.Void set_value(T value) { }
        private System.Void SetValueWithoutNotify(T newValue) { }

    }

    // TypeToken: 0x2000138
    public class INotifyValueChangedExtensions
    {
        // Methods
        private System.Boolean RegisterValueChangedCallback(UnityEngine.UIElements.INotifyValueChanged<T> control, UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<T>> callback) { }
        private System.Boolean UnregisterValueChangedCallback(UnityEngine.UIElements.INotifyValueChanged<T> control, UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<T>> callback) { }

    }

    // TypeToken: 0x2000139
    public class KeyboardTextEditorEventHandler : TextEditorEventHandler
    {
        // Fields
        private System.Boolean m_Changed;        // 0x20
        private System.Boolean m_Dragged;        // 0x21
        private System.Boolean m_DragToPosition;        // 0x22
        private System.Boolean m_SelectAllOnMouseUp;        // 0x23
        private System.String m_PreDrawCursorText;        // 0x28
        private System.Boolean m_IsClicking;        // 0x30
        private UnityEngine.Vector2 m_ClickStartPosition;        // 0x34
        private readonly UnityEngine.Event m_ImguiEvent;        // 0x40

        // Methods
        private System.Boolean get_isClicking() { }
        private System.Void set_isClicking(System.Boolean value) { }
        private System.Void .ctor(UnityEngine.UIElements.TextEditorEngine editorEngine, UnityEngine.UIElements.ITextInputField textInputField) { }
        private System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt) { }
        private System.Void OnFocus(UnityEngine.UIElements.FocusEvent _) { }
        private System.Void OnBlur(UnityEngine.UIElements.BlurEvent _) { }
        private System.Void OnMouseDown(UnityEngine.UIElements.MouseDownEvent evt) { }
        private System.Void OnMouseUp(UnityEngine.UIElements.MouseUpEvent evt) { }
        private System.Void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent evt) { }
        private System.Void ProcessDragMove(UnityEngine.UIElements.MouseMoveEvent evt) { }
        private System.Boolean MoveDistanceQualifiesForDrag(UnityEngine.Vector2 start, UnityEngine.Vector2 current) { }
        private System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt) { }
        private System.Void OnValidateCommandEvent(UnityEngine.UIElements.ValidateCommandEvent evt) { }
        private System.Void OnExecuteCommandEvent(UnityEngine.UIElements.ExecuteCommandEvent evt) { }
        private System.Void PreDrawCursor(System.String newText) { }
        private System.Void PostDrawCursor() { }

    }

    // TypeToken: 0x200013A
    public class Label : TextElement
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String text) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200013D
    public class ListView : BaseListView
    {
        // Fields
        private System.Func<UnityEngine.UIElements.VisualElement> m_MakeItem;        // 0x538
        private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> m_BindItem;        // 0x540
        private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> <unbindItem>k__BackingField;        // 0x548
        private System.Action<UnityEngine.UIElements.VisualElement> <destroyItem>k__BackingField;        // 0x550

        // Methods
        private System.Func<UnityEngine.UIElements.VisualElement> get_makeItem() { }
        private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_bindItem() { }
        private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_unbindItem() { }
        private System.Action<UnityEngine.UIElements.VisualElement> get_destroyItem() { }
        private System.Boolean HasValidDataAndBindings() { }
        private UnityEngine.UIElements.CollectionViewController CreateViewController() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000140
    public class MinMaxSlider : BaseField`1
    {
        // Fields
        private UnityEngine.UIElements.VisualElement <dragElement>k__BackingField;        // 0x418
        private UnityEngine.UIElements.VisualElement <dragMinThumb>k__BackingField;        // 0x420
        private UnityEngine.UIElements.VisualElement <dragMaxThumb>k__BackingField;        // 0x428
        private UnityEngine.UIElements.ClampedDragger<System.Single> <clampedDragger>k__BackingField;        // 0x430
        private UnityEngine.Vector2 m_DragElementStartPos;        // 0x438
        private UnityEngine.Vector2 m_ValueStartPos;        // 0x440
        private UnityEngine.Rect m_DragMinThumbRect;        // 0x448
        private UnityEngine.Rect m_DragMaxThumbRect;        // 0x458
        private UnityEngine.UIElements.MinMaxSlider.DragState m_DragState;        // 0x468
        private System.Single m_MinLimit;        // 0x46C
        private System.Single m_MaxLimit;        // 0x470
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String labelUssClassName;        // 0x8
        public static readonly System.String inputUssClassName;        // 0x10
        public static readonly System.String trackerUssClassName;        // 0x18
        public static readonly System.String draggerUssClassName;        // 0x20
        public static readonly System.String minThumbUssClassName;        // 0x28
        public static readonly System.String maxThumbUssClassName;        // 0x30

        // Methods
        private UnityEngine.UIElements.VisualElement get_dragElement() { }
        private System.Void set_dragElement(UnityEngine.UIElements.VisualElement value) { }
        private UnityEngine.UIElements.VisualElement get_dragMinThumb() { }
        private System.Void set_dragMinThumb(UnityEngine.UIElements.VisualElement value) { }
        private UnityEngine.UIElements.VisualElement get_dragMaxThumb() { }
        private System.Void set_dragMaxThumb(UnityEngine.UIElements.VisualElement value) { }
        private UnityEngine.UIElements.ClampedDragger<System.Single> get_clampedDragger() { }
        private System.Void set_clampedDragger(UnityEngine.UIElements.ClampedDragger<System.Single> value) { }
        private System.Single get_minValue() { }
        private System.Void set_minValue(System.Single value) { }
        private System.Single get_maxValue() { }
        private System.Void set_maxValue(System.Single value) { }
        private UnityEngine.Vector2 get_value() { }
        private System.Void set_value(UnityEngine.Vector2 value) { }
        private System.Void SetValueWithoutNotify(UnityEngine.Vector2 newValue) { }
        private System.Single get_lowLimit() { }
        private System.Void set_lowLimit(System.Single value) { }
        private System.Single get_highLimit() { }
        private System.Void set_highLimit(System.Single value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String label, System.Single minValue, System.Single maxValue, System.Single minLimit, System.Single maxLimit) { }
        private UnityEngine.Vector2 ClampValues(UnityEngine.Vector2 valueToClamp) { }
        private System.Void UpdateDragElementPosition(UnityEngine.UIElements.GeometryChangedEvent evt) { }
        private System.Void UpdateDragElementPosition() { }
        private System.Single SliderLerpUnclamped(System.Single a, System.Single b, System.Single interpolant) { }
        private System.Single SliderNormalizeValue(System.Single currentValue, System.Single lowerValue, System.Single higherValue) { }
        private System.Single ComputeValueFromPosition(System.Single positionToConvert) { }
        private System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt) { }
        private System.Void SetSliderValueFromDrag() { }
        private System.Void SetSliderValueFromClick() { }
        private System.Void ComputeValueDragStateNoThumb(System.Single lowLimitPosition, System.Single highLimitPosition, System.Single dragElementPos) { }
        private System.Void ComputeValueFromDraggingThumb(System.Single dragElementStartPos, System.Single dragElementEndPos) { }
        private System.Void UpdateMixedValueContent() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000144
    public class PopupWindow : TextElement
    {
        // Fields
        private UnityEngine.UIElements.VisualElement m_ContentContainer;        // 0x488
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String contentUssClassName;        // 0x8

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.UIElements.VisualElement get_contentContainer() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000147
    public class AbstractProgressBar : BindableElement, INotifyValueChanged`1
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String containerUssClassName;        // 0x8
        public static readonly System.String titleUssClassName;        // 0x10
        public static readonly System.String titleContainerUssClassName;        // 0x18
        public static readonly System.String progressUssClassName;        // 0x20
        public static readonly System.String backgroundUssClassName;        // 0x28
        private readonly UnityEngine.UIElements.VisualElement m_Background;        // 0x3D0
        private readonly UnityEngine.UIElements.VisualElement m_Progress;        // 0x3D8
        private readonly UnityEngine.UIElements.Label m_Title;        // 0x3E0
        private System.Single m_LowValue;        // 0x3E8
        private System.Single m_HighValue;        // 0x3EC
        private System.Single m_Value;        // 0x3F0

        // Methods
        private System.Void set_title(System.String value) { }
        private System.Single get_lowValue() { }
        private System.Void set_lowValue(System.Single value) { }
        private System.Single get_highValue() { }
        private System.Void set_highValue(System.Single value) { }
        private System.Void .ctor() { }
        private System.Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e) { }
        private System.Single get_value() { }
        private System.Void set_value(System.Single value) { }
        private System.Void SetValueWithoutNotify(System.Single newValue) { }
        private System.Void SetProgress(System.Single p) { }
        private System.Single CalculateProgressWidth(System.Single width) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000149
    public class ProgressBar : AbstractProgressBar
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014B
    public class RadioButton : BaseBoolField, IGroupBoxOption
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String labelUssClassName;        // 0x8
        public static readonly System.String inputUssClassName;        // 0x10
        public static readonly System.String checkmarkBackgroundUssClassName;        // 0x18
        public static readonly System.String checkmarkUssClassName;        // 0x20
        public static readonly System.String textUssClassName;        // 0x28
        private UnityEngine.UIElements.VisualElement m_CheckmarkBackground;        // 0x438

        // Methods
        private System.Boolean get_value() { }
        private System.Void set_value(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String label) { }
        private System.Void InitLabel() { }
        private System.Void ToggleValue() { }
        private System.Void SetSelected(System.Boolean selected) { }
        private System.Void SetValueWithoutNotify(System.Boolean newValue) { }
        private System.Void UpdateCheckmark() { }
        private System.Void UpdateMixedValueContent() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200014E
    public class RadioButtonGroup : BaseField`1, IGroupBox
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        private System.Collections.Generic.IEnumerable<System.String> m_Choices;        // 0x418
        private System.Collections.Generic.List<UnityEngine.UIElements.RadioButton> m_RadioButtons;        // 0x420
        private UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<System.Boolean>> m_RadioButtonValueChangedCallback;        // 0x428

        // Methods
        private System.Void set_choices(System.Collections.Generic.IEnumerable<System.String> value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String label, System.Collections.Generic.List<System.String> radioButtonChoices) { }
        private System.Void RadioButtonValueChangedCallback(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt) { }
        private System.Void SetValueWithoutNotify(System.Int32 newValue) { }
        private System.Void UpdateRadioButtons() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000151
    public class RepeatButton : TextElement
    {
        // Fields
        private UnityEngine.UIElements.Clickable m_Clickable;        // 0x488
        public static readonly System.String ussClassName;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Action clickEvent, System.Int64 delay, System.Int64 interval) { }
        private System.Void SetAction(System.Action clickEvent, System.Int64 delay, System.Int64 interval) { }
        private System.Void AddAction(System.Action clickEvent) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000154
    public class Scroller : VisualElement
    {
        // Fields
        private System.Action<System.Single> valueChanged;        // 0x3C0
        private UnityEngine.UIElements.Slider <slider>k__BackingField;        // 0x3C8
        private UnityEngine.UIElements.RepeatButton <lowButton>k__BackingField;        // 0x3D0
        private UnityEngine.UIElements.RepeatButton <highButton>k__BackingField;        // 0x3D8
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String horizontalVariantUssClassName;        // 0x8
        public static readonly System.String verticalVariantUssClassName;        // 0x10
        public static readonly System.String sliderUssClassName;        // 0x18
        public static readonly System.String lowButtonUssClassName;        // 0x20
        public static readonly System.String highButtonUssClassName;        // 0x28

        // Methods
        private System.Void add_valueChanged(System.Action<System.Single> value) { }
        private System.Void remove_valueChanged(System.Action<System.Single> value) { }
        private UnityEngine.UIElements.Slider get_slider() { }
        private System.Void set_slider(UnityEngine.UIElements.Slider value) { }
        private UnityEngine.UIElements.RepeatButton get_lowButton() { }
        private System.Void set_lowButton(UnityEngine.UIElements.RepeatButton value) { }
        private UnityEngine.UIElements.RepeatButton get_highButton() { }
        private System.Void set_highButton(UnityEngine.UIElements.RepeatButton value) { }
        private System.Single get_value() { }
        private System.Void set_value(System.Single value) { }
        private System.Single get_lowValue() { }
        private System.Void set_lowValue(System.Single value) { }
        private System.Single get_highValue() { }
        private System.Void set_highValue(System.Single value) { }
        private System.Void set_direction(UnityEngine.UIElements.SliderDirection value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Single lowValue, System.Single highValue, System.Action<System.Single> valueChanged, UnityEngine.UIElements.SliderDirection direction) { }
        private System.Void Adjust(System.Single factor) { }
        private System.Void OnSliderValueChange(UnityEngine.UIElements.ChangeEvent<System.Single> evt) { }
        private System.Void ScrollPageUp() { }
        private System.Void ScrollPageDown() { }
        private System.Void ScrollPageUp(System.Single factor) { }
        private System.Void ScrollPageDown(System.Single factor) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000157
    public struct ScrollViewMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.ScrollViewMode Vertical;        // 0x0
        public static UnityEngine.UIElements.ScrollViewMode Horizontal;        // 0x0
        public static UnityEngine.UIElements.ScrollViewMode VerticalAndHorizontal;        // 0x0

    }

    // TypeToken: 0x2000158
    public struct ScrollerVisibility
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.ScrollerVisibility Auto;        // 0x0
        public static UnityEngine.UIElements.ScrollerVisibility AlwaysVisible;        // 0x0
        public static UnityEngine.UIElements.ScrollerVisibility Hidden;        // 0x0

    }

    // TypeToken: 0x2000159
    public class ScrollView : VisualElement
    {
        // Fields
        private System.Int32 m_FirstLayoutPass;        // 0x3C0
        private UnityEngine.UIElements.ScrollerVisibility m_HorizontalScrollerVisibility;        // 0x3C4
        private UnityEngine.UIElements.ScrollerVisibility m_VerticalScrollerVisibility;        // 0x3C8
        private UnityEngine.UIElements.VisualElement m_AttachedRootVisualContainer;        // 0x3D0
        private System.Single m_SingleLineHeight;        // 0x3D8
        private System.Boolean m_MouseWheelScrollSizeIsInline;        // 0x3DC
        private System.Single m_HorizontalPageSize;        // 0x3E0
        private System.Single m_VerticalPageSize;        // 0x3E4
        private System.Single m_MouseWheelScrollSize;        // 0x3E8
        private static readonly System.Single k_DefaultScrollDecelerationRate;        // 0x0
        private System.Single m_ScrollDecelerationRate;        // 0x3EC
        private System.Single k_ScaledPixelsPerPointMultiplier;        // 0x3F0
        private System.Single k_TouchScrollInertiaBaseTimeInterval;        // 0x3F4
        private static readonly System.Single k_DefaultElasticity;        // 0x4
        private System.Single m_Elasticity;        // 0x3F8
        private UnityEngine.UIElements.ScrollView.TouchScrollBehavior m_TouchScrollBehavior;        // 0x3FC
        private UnityEngine.UIElements.ScrollView.NestedInteractionKind m_NestedInteractionKind;        // 0x400
        private static readonly System.Int64 k_DefaultElasticAnimationInterval;        // 0x8
        private System.Int64 m_ElasticAnimationIntervalMs;        // 0x408
        private readonly UnityEngine.UIElements.VisualElement <contentViewport>k__BackingField;        // 0x410
        private readonly UnityEngine.UIElements.Scroller <horizontalScroller>k__BackingField;        // 0x418
        private readonly UnityEngine.UIElements.Scroller <verticalScroller>k__BackingField;        // 0x420
        private UnityEngine.UIElements.VisualElement m_ContentContainer;        // 0x428
        private UnityEngine.UIElements.VisualElement m_ContentAndVerticalScrollContainer;        // 0x430
        private System.Single previousVerticalTouchScrollTimeStamp;        // 0x438
        private System.Single previousHorizontalTouchScrollTimeStamp;        // 0x43C
        private System.Single elapsedTimeSinceLastVerticalTouchScroll;        // 0x440
        private System.Single elapsedTimeSinceLastHorizontalTouchScroll;        // 0x444
        public static readonly System.String ussClassName;        // 0x10
        public static readonly System.String viewportUssClassName;        // 0x18
        public static readonly System.String horizontalVariantViewportUssClassName;        // 0x20
        public static readonly System.String verticalVariantViewportUssClassName;        // 0x28
        public static readonly System.String verticalHorizontalVariantViewportUssClassName;        // 0x30
        public static readonly System.String contentAndVerticalScrollUssClassName;        // 0x38
        public static readonly System.String contentUssClassName;        // 0x40
        public static readonly System.String horizontalVariantContentUssClassName;        // 0x48
        public static readonly System.String verticalVariantContentUssClassName;        // 0x50
        public static readonly System.String verticalHorizontalVariantContentUssClassName;        // 0x58
        public static readonly System.String hScrollerUssClassName;        // 0x60
        public static readonly System.String vScrollerUssClassName;        // 0x68
        public static readonly System.String horizontalVariantUssClassName;        // 0x70
        public static readonly System.String verticalVariantUssClassName;        // 0x78
        public static readonly System.String verticalHorizontalVariantUssClassName;        // 0x80
        public static readonly System.String scrollVariantUssClassName;        // 0x88
        private UnityEngine.UIElements.ScrollViewMode m_Mode;        // 0x448
        private UnityEngine.UIElements.IVisualElementScheduledItem m_ScheduledLayoutPassResetItem;        // 0x450
        private UnityEngine.Vector2 m_StartPosition;        // 0x458
        private UnityEngine.Vector2 m_PointerStartPosition;        // 0x460
        private UnityEngine.Vector2 m_Velocity;        // 0x468
        private UnityEngine.Vector2 m_SpringBackVelocity;        // 0x470
        private UnityEngine.Vector2 m_LowBounds;        // 0x478
        private UnityEngine.Vector2 m_HighBounds;        // 0x480
        private System.Single m_LastVelocityLerpTime;        // 0x488
        private System.Boolean m_StartedMoving;        // 0x48C
        private System.Boolean m_TouchPointerMoveAllowed;        // 0x48D
        private System.Boolean m_TouchStoppedVelocity;        // 0x48E
        private UnityEngine.UIElements.VisualElement m_CapturedTarget;        // 0x490
        private UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.PointerMoveEvent> m_CapturedTargetPointerMoveCallback;        // 0x498
        private UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.PointerUpEvent> m_CapturedTargetPointerUpCallback;        // 0x4A0
        private UnityEngine.UIElements.IVisualElementScheduledItem m_PostPointerUpAnimation;        // 0x4A8

        // Methods
        private UnityEngine.UIElements.ScrollerVisibility get_horizontalScrollerVisibility() { }
        private System.Void set_horizontalScrollerVisibility(UnityEngine.UIElements.ScrollerVisibility value) { }
        private UnityEngine.UIElements.ScrollerVisibility get_verticalScrollerVisibility() { }
        private System.Void set_verticalScrollerVisibility(UnityEngine.UIElements.ScrollerVisibility value) { }
        private System.Void set_showHorizontal(System.Boolean value) { }
        private System.Void set_showVertical(System.Boolean value) { }
        private System.Boolean get_needsHorizontal() { }
        private System.Boolean get_needsVertical() { }
        private System.Boolean get_isVerticalScrollDisplayed() { }
        private System.Boolean get_isHorizontalScrollDisplayed() { }
        private UnityEngine.Vector2 get_scrollOffset() { }
        private System.Void set_scrollOffset(UnityEngine.Vector2 value) { }
        private System.Void set_horizontalPageSize(System.Single value) { }
        private System.Void set_verticalPageSize(System.Single value) { }
        private System.Single get_mouseWheelScrollSize() { }
        private System.Void set_mouseWheelScrollSize(System.Single value) { }
        private System.Single get_scrollableWidth() { }
        private System.Single get_scrollableHeight() { }
        private System.Boolean get_hasInertia() { }
        private System.Single get_scrollDecelerationRate() { }
        private System.Void set_scrollDecelerationRate(System.Single value) { }
        private System.Single get_elasticity() { }
        private System.Void set_elasticity(System.Single value) { }
        private UnityEngine.UIElements.ScrollView.TouchScrollBehavior get_touchScrollBehavior() { }
        private System.Void set_touchScrollBehavior(UnityEngine.UIElements.ScrollView.TouchScrollBehavior value) { }
        private UnityEngine.UIElements.ScrollView.NestedInteractionKind get_nestedInteractionKind() { }
        private System.Void set_nestedInteractionKind(UnityEngine.UIElements.ScrollView.NestedInteractionKind value) { }
        private System.Void set_elasticAnimationIntervalMs(System.Int64 value) { }
        private System.Void OnHorizontalScrollDragElementChanged(UnityEngine.UIElements.GeometryChangedEvent evt) { }
        private System.Void OnVerticalScrollDragElementChanged(UnityEngine.UIElements.GeometryChangedEvent evt) { }
        private System.Void UpdateHorizontalSliderPageSize() { }
        private System.Void UpdateVerticalSliderPageSize() { }
        private System.Void UpdateContentViewTransform() { }
        private System.Void ScrollTo(UnityEngine.UIElements.VisualElement child) { }
        private System.Single GetXDeltaOffset(UnityEngine.UIElements.VisualElement child) { }
        private System.Single GetYDeltaOffset(UnityEngine.UIElements.VisualElement child) { }
        private System.Single GetDeltaDistance(System.Single viewMin, System.Single viewMax, System.Single childBoundaryMin, System.Single childBoundaryMax) { }
        private UnityEngine.UIElements.VisualElement get_contentViewport() { }
        private UnityEngine.UIElements.Scroller get_horizontalScroller() { }
        private UnityEngine.UIElements.Scroller get_verticalScroller() { }
        private UnityEngine.UIElements.VisualElement get_contentContainer() { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.UIElements.ScrollViewMode scrollViewMode) { }
        private UnityEngine.UIElements.ScrollViewMode get_mode() { }
        private System.Void set_mode(UnityEngine.UIElements.ScrollViewMode value) { }
        private System.Void SetScrollViewMode(UnityEngine.UIElements.ScrollViewMode mode) { }
        private System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt) { }
        private System.Void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt) { }
        private System.Void OnPointerCapture(UnityEngine.UIElements.PointerCaptureEvent evt) { }
        private System.Void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent evt) { }
        private System.Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt) { }
        private System.Void ScheduleResetLayoutPass() { }
        private System.Void ResetLayoutPass() { }
        private System.Single ComputeElasticOffset(System.Single deltaPointer, System.Single initialScrollOffset, System.Single lowLimit, System.Single hardLowLimit, System.Single highLimit, System.Single hardHighLimit) { }
        private System.Void ComputeInitialSpringBackVelocity() { }
        private System.Void SpringBack() { }
        private System.Void ApplyScrollInertia() { }
        private System.Void PostPointerUpAnimation() { }
        private System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt) { }
        private System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt) { }
        private System.Void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt) { }
        private System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt) { }
        private System.Void InitTouchScrolling(UnityEngine.Vector2 position) { }
        private UnityEngine.UIElements.ScrollView.TouchScrollingResult ComputeTouchScrolling(UnityEngine.Vector2 position) { }
        private System.Boolean ApplyTouchScrolling(UnityEngine.Vector2 newScrollOffset) { }
        private System.Boolean ReleaseScrolling(System.Int32 pointerId, UnityEngine.UIElements.IEventHandler target) { }
        private System.Void ExecuteElasticSpringAnimation() { }
        private System.Void AdjustScrollers() { }
        private System.Void UpdateScrollers(System.Boolean displayHorizontal, System.Boolean displayVertical) { }
        private System.Void OnScrollersGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt) { }
        private System.Void OnScrollWheel(UnityEngine.UIElements.WheelEvent evt) { }
        private System.Void OnRootCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent evt) { }
        private System.Void OnRootPointerUp(UnityEngine.UIElements.PointerUpEvent evt) { }
        private System.Void ReadSingleLineHeight() { }
        private System.Void UpdateElasticBehaviour() { }
        private System.Void .cctor() { }
        private System.Void <.ctor>b__126_0(System.Single value) { }
        private System.Void <.ctor>b__126_1(System.Single value) { }

    }

    // TypeToken: 0x200015F
    public class Slider : BaseSlider`1
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String labelUssClassName;        // 0x8
        public static readonly System.String inputUssClassName;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Single start, System.Single end, UnityEngine.UIElements.SliderDirection direction, System.Single pageSize) { }
        private System.Void .ctor(System.String label, System.Single start, System.Single end, UnityEngine.UIElements.SliderDirection direction, System.Single pageSize) { }
        private System.Single SliderLerpUnclamped(System.Single a, System.Single b, System.Single interpolant) { }
        private System.Single SliderNormalizeValue(System.Single currentValue, System.Single lowerValue, System.Single higherValue) { }
        private System.Single ParseStringToValue(System.String stringValue) { }
        private System.Void ComputeValueFromKey(UnityEngine.UIElements.BaseSlider.SliderKey<System.Single> sliderKey, System.Boolean isShift) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000162
    public class SliderInt : BaseSlider`1
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String labelUssClassName;        // 0x8
        public static readonly System.String inputUssClassName;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String label, System.Int32 start, System.Int32 end, UnityEngine.UIElements.SliderDirection direction, System.Single pageSize) { }
        private System.Single get_pageSize() { }
        private System.Void set_pageSize(System.Single value) { }
        private System.Int32 SliderLerpUnclamped(System.Int32 a, System.Int32 b, System.Single interpolant) { }
        private System.Single SliderNormalizeValue(System.Int32 currentValue, System.Int32 lowerValue, System.Int32 higherValue) { }
        private System.Int32 ParseStringToValue(System.String stringValue) { }
        private System.Void ComputeValueAndDirectionFromClick(System.Single sliderLength, System.Single dragElementLength, System.Single dragElementPos, System.Single dragElementLastPos) { }
        private System.Void ComputeValueFromKey(UnityEngine.UIElements.BaseSlider.SliderKey<System.Int32> sliderKey, System.Boolean isShift) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000165
    public class TextEditorEventHandler
    {
        // Fields
        private UnityEngine.UIElements.TextEditorEngine <editorEngine>k__BackingField;        // 0x10
        private UnityEngine.UIElements.ITextInputField <textInputField>k__BackingField;        // 0x18

        // Methods
        private UnityEngine.UIElements.TextEditorEngine get_editorEngine() { }
        private System.Void set_editorEngine(UnityEngine.UIElements.TextEditorEngine value) { }
        private UnityEngine.UIElements.ITextInputField get_textInputField() { }
        private System.Void set_textInputField(UnityEngine.UIElements.ITextInputField value) { }
        private System.Void .ctor(UnityEngine.UIElements.TextEditorEngine editorEngine, UnityEngine.UIElements.ITextInputField textInputField) { }
        private System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt) { }
        private System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt) { }

    }

    // TypeToken: 0x2000166
    public class TextEditorEngine : TextEditor
    {
        // Fields
        private UnityEngine.UIElements.TextEditorEngine.OnDetectFocusChangeFunction m_DetectFocusChangeFunction;        // 0x90
        private UnityEngine.UIElements.TextEditorEngine.OnIndexChangeFunction m_IndexChangeFunction;        // 0x98

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.TextEditorEngine.OnDetectFocusChangeFunction detectFocusChange, UnityEngine.UIElements.TextEditorEngine.OnIndexChangeFunction indexChangeFunction) { }
        private UnityEngine.Rect get_localPosition() { }
        private System.Void OnDetectFocusChange() { }
        private System.Void OnCursorIndexChange() { }
        private System.Void OnSelectIndexChange() { }

    }

    // TypeToken: 0x2000169
    public class TextField : TextInputBaseField`1
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String labelUssClassName;        // 0x8
        public static readonly System.String inputUssClassName;        // 0x10

        // Methods
        private UnityEngine.UIElements.TextField.TextInput get_textInput() { }
        private System.Void set_multiline(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String label) { }
        private System.Void .ctor(System.String label, System.Int32 maxLength, System.Boolean multiline, System.Boolean isPasswordField, System.Char maskChar) { }
        private System.String get_value() { }
        private System.Void set_value(System.String value) { }
        private System.Void SetValueWithoutNotify(System.String newValue) { }
        private System.Void OnViewDataReady() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200016D
    public interface ITextInputField : IEventHandler, ITextElement
    {
        // Methods
        private System.Boolean get_hasFocus() { }
        private System.Boolean get_doubleClickSelectsWord() { }
        private System.Boolean get_tripleClickSelectsLine() { }
        private System.Boolean get_isReadOnly() { }
        private System.Boolean get_isDelayed() { }
        private System.Boolean get_isPasswordField() { }
        private UnityEngine.UIElements.TextEditorEngine get_editorEngine() { }
        private System.Void SyncTextEngine() { }
        private System.Boolean AcceptCharacter(System.Char c) { }
        private System.String CullString(System.String s) { }
        private System.Void UpdateText(System.String value) { }
        private System.Void UpdateValueFromText() { }

    }

    // TypeToken: 0x200016E
    public class TextInputBaseField`1 : BaseField`1
    {
        // Fields
        private static UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> s_SelectionColorProperty;        // 0x0
        private static UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> s_CursorColorProperty;        // 0x0
        private System.Int32 m_VisualInputTabIndex;        // 0x0
        private UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> m_TextInputBase;        // 0x0
        private UnityEngine.UIElements.ITextHandle <iTextHandle>k__BackingField;        // 0x0
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String labelUssClassName;        // 0x0
        public static readonly System.String inputUssClassName;        // 0x0
        public static readonly System.String singleLineInputUssClassName;        // 0x0
        public static readonly System.String multilineInputUssClassName;        // 0x0
        public static readonly System.String textInputUssName;        // 0x0
        private System.Action<System.Boolean> onIsReadOnlyChanged;        // 0x0

        // Methods
        private UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> get_textInputBase() { }
        private System.Void set_iTextHandle(UnityEngine.UIElements.ITextHandle value) { }
        private System.Void set_text(System.String value) { }
        private System.Void set_isReadOnly(System.Boolean value) { }
        private System.Void set_isPasswordField(System.Boolean value) { }
        private System.Void set_maxLength(System.Int32 value) { }
        private System.Boolean get_isDelayed() { }
        private System.Void set_isDelayed(System.Boolean value) { }
        private System.Void set_maskChar(System.Char value) { }
        private System.Void .ctor(System.String label, System.Int32 maxLength, System.Char maskChar, UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> textInputBase) { }
        private System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent e) { }
        private System.Void OnFieldCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e) { }
        private System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt) { }
        private System.Void UpdateMixedValueContent() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000171
    public class Toggle : BaseBoolField
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String labelUssClassName;        // 0x8
        public static readonly System.String inputUssClassName;        // 0x10
        public static readonly System.String noTextVariantUssClassName;        // 0x18
        public static readonly System.String checkmarkUssClassName;        // 0x20
        public static readonly System.String textUssClassName;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String label) { }
        private System.Void InitLabel() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000174
    public class TouchScreenTextEditorEventHandler : TextEditorEventHandler
    {
        // Fields
        private UnityEngine.UIElements.IVisualElementScheduledItem m_TouchKeyboardPoller;        // 0x20
        private UnityEngine.UIElements.VisualElement m_LastPointerDownTarget;        // 0x28

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.TextEditorEngine editorEngine, UnityEngine.UIElements.ITextInputField textInputField) { }
        private System.Void PollTouchScreenKeyboard() { }
        private System.Void DoPollTouchScreenKeyboard() { }
        private System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt) { }

    }

    // TypeToken: 0x2000175
    public class TreeView : BaseTreeView
    {
        // Fields
        private System.Func<UnityEngine.UIElements.VisualElement> m_MakeItem;        // 0x4B8
        private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> m_BindItem;        // 0x4C0
        private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> <unbindItem>k__BackingField;        // 0x4C8
        private System.Action<UnityEngine.UIElements.VisualElement> <destroyItem>k__BackingField;        // 0x4D0

        // Methods
        private System.Func<UnityEngine.UIElements.VisualElement> get_makeItem() { }
        private System.Void set_makeItem(System.Func<UnityEngine.UIElements.VisualElement> value) { }
        private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_bindItem() { }
        private System.Void set_bindItem(System.Action<UnityEngine.UIElements.VisualElement,System.Int32> value) { }
        private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_unbindItem() { }
        private System.Action<UnityEngine.UIElements.VisualElement> get_destroyItem() { }
        private System.Boolean HasValidDataAndBindings() { }
        private UnityEngine.UIElements.CollectionViewController CreateViewController() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Func<UnityEngine.UIElements.VisualElement> makeItem, System.Action<UnityEngine.UIElements.VisualElement,System.Int32> bindItem) { }

    }

    // TypeToken: 0x2000178
    public struct TreeData`1
    {
        // Fields
        private readonly System.Collections.Generic.IList<System.Int32> m_RootItemIds;        // 0x0
        private readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.TreeViewItemData<T>> m_Tree;        // 0x0
        private readonly System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_ParentIds;        // 0x0
        private readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> m_ChildrenIds;        // 0x0

        // Methods
        private System.Collections.Generic.IEnumerable<System.Int32> get_rootItemIds() { }
        private System.Void .ctor(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems) { }
        private UnityEngine.UIElements.TreeViewItemData<T> GetDataForId(System.Int32 id) { }
        private System.Int32 GetParentId(System.Int32 id) { }
        private System.Void Move(System.Int32 id, System.Int32 newParentId, System.Int32 childIndex) { }
        private System.Boolean HasAncestor(System.Int32 childId, System.Int32 ancestorId) { }
        private System.Void AddItemToParent(UnityEngine.UIElements.TreeViewItemData<T> item, System.Int32 parentId, System.Int32 childIndex) { }
        private System.Void RemoveFromParent(System.Int32 id, System.Int32 parentId) { }
        private System.Void UpdateParentTree(UnityEngine.UIElements.TreeViewItemData<T> current) { }
        private System.Void RefreshTree(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems) { }
        private System.Void BuildTree(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> items, System.Boolean isRoot) { }

    }

    // TypeToken: 0x2000179
    public struct TreeItem
    {
        // Fields
        private readonly System.Int32 <id>k__BackingField;        // 0x10
        private readonly System.Int32 <parentId>k__BackingField;        // 0x14
        private readonly System.Collections.Generic.IEnumerable<System.Int32> <childrenIds>k__BackingField;        // 0x18

        // Methods
        private System.Int32 get_id() { }
        private System.Int32 get_parentId() { }
        private System.Collections.Generic.IEnumerable<System.Int32> get_childrenIds() { }
        private System.Boolean get_hasChildren() { }
        private System.Void .ctor(System.Int32 id, System.Int32 parentId, System.Collections.Generic.IEnumerable<System.Int32> childrenIds) { }

    }

    // TypeToken: 0x200017A
    public struct TreeViewItemWrapper
    {
        // Fields
        public readonly UnityEngine.UIElements.TreeItem item;        // 0x10
        public readonly System.Int32 depth;        // 0x20

        // Methods
        private System.Int32 get_id() { }
        private System.Collections.Generic.IEnumerable<System.Int32> get_childrenIds() { }
        private System.Boolean get_hasChildren() { }
        private System.Void .ctor(UnityEngine.UIElements.TreeItem item, System.Int32 depth) { }

    }

    // TypeToken: 0x200017B
    public struct TreeViewItemData`1
    {
        // Fields
        private readonly System.Int32 <id>k__BackingField;        // 0x0
        private readonly T m_Data;        // 0x0
        private readonly System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> m_Children;        // 0x0

        // Methods
        private System.Int32 get_id() { }
        private T get_data() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> get_children() { }
        private System.Boolean get_hasChildren() { }
        private System.Void InsertChild(UnityEngine.UIElements.TreeViewItemData<T> child, System.Int32 index) { }
        private System.Void RemoveChild(System.Int32 childId) { }
        private System.Int32 GetChildIndex(System.Int32 itemId) { }
        private System.Void ReplaceChild(UnityEngine.UIElements.TreeViewItemData<T> newChild) { }

    }

    // TypeToken: 0x200017C
    public class TwoPaneSplitView : VisualElement
    {
        // Fields
        private static readonly System.String s_UssClassName;        // 0x0
        private static readonly System.String s_ContentContainerClassName;        // 0x8
        private static readonly System.String s_HandleDragLineClassName;        // 0x10
        private static readonly System.String s_HandleDragLineVerticalClassName;        // 0x18
        private static readonly System.String s_HandleDragLineHorizontalClassName;        // 0x20
        private static readonly System.String s_HandleDragLineAnchorClassName;        // 0x28
        private static readonly System.String s_HandleDragLineAnchorVerticalClassName;        // 0x30
        private static readonly System.String s_HandleDragLineAnchorHorizontalClassName;        // 0x38
        private static readonly System.String s_VerticalClassName;        // 0x40
        private static readonly System.String s_HorizontalClassName;        // 0x48
        private UnityEngine.UIElements.VisualElement m_LeftPane;        // 0x3C0
        private UnityEngine.UIElements.VisualElement m_RightPane;        // 0x3C8
        private UnityEngine.UIElements.VisualElement m_FixedPane;        // 0x3D0
        private UnityEngine.UIElements.VisualElement m_FlexedPane;        // 0x3D8
        private System.Single m_FixedPaneDimension;        // 0x3E0
        private UnityEngine.UIElements.VisualElement m_DragLine;        // 0x3E8
        private UnityEngine.UIElements.VisualElement m_DragLineAnchor;        // 0x3F0
        private System.Boolean m_CollapseMode;        // 0x3F8
        private UnityEngine.UIElements.VisualElement m_Content;        // 0x400
        private UnityEngine.UIElements.TwoPaneSplitViewOrientation m_Orientation;        // 0x408
        private System.Int32 m_FixedPaneIndex;        // 0x40C
        private System.Single m_FixedPaneInitialDimension;        // 0x410
        private UnityEngine.UIElements.TwoPaneSplitViewResizer m_Resizer;        // 0x418

        // Methods
        private UnityEngine.UIElements.VisualElement get_fixedPane() { }
        private UnityEngine.UIElements.VisualElement get_flexedPane() { }
        private System.Int32 get_fixedPaneIndex() { }
        private System.Single get_fixedPaneDimension() { }
        private System.Void set_fixedPaneDimension(System.Single value) { }
        private System.Void .ctor() { }
        private System.Void Init(System.Int32 fixedPaneIndex, System.Single fixedPaneInitialDimension, UnityEngine.UIElements.TwoPaneSplitViewOrientation orientation) { }
        private System.Void OnPostDisplaySetup(UnityEngine.UIElements.GeometryChangedEvent evt) { }
        private System.Void PostDisplaySetup() { }
        private System.Void OnSizeChange(UnityEngine.UIElements.GeometryChangedEvent evt) { }
        private System.Void OnSizeChange() { }
        private UnityEngine.UIElements.VisualElement get_contentContainer() { }
        private System.Void OnViewDataReady() { }
        private System.Void SetDragLineOffset(System.Single offset) { }
        private System.Void SetFixedPaneDimension(System.Single dimension) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200017F
    public struct TwoPaneSplitViewOrientation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.TwoPaneSplitViewOrientation Horizontal;        // 0x0
        public static UnityEngine.UIElements.TwoPaneSplitViewOrientation Vertical;        // 0x0

    }

    // TypeToken: 0x2000180
    public class TwoPaneSplitViewResizer : PointerManipulator
    {
        // Fields
        private UnityEngine.Vector3 m_Start;        // 0x38
        protected System.Boolean m_Active;        // 0x44
        private UnityEngine.UIElements.TwoPaneSplitView m_SplitView;        // 0x48
        private System.Int32 m_Direction;        // 0x50
        private UnityEngine.UIElements.TwoPaneSplitViewOrientation m_Orientation;        // 0x54

        // Methods
        private UnityEngine.UIElements.VisualElement get_fixedPane() { }
        private UnityEngine.UIElements.VisualElement get_flexedPane() { }
        private System.Single get_fixedPaneMinDimension() { }
        private System.Single get_flexedPaneMinDimension() { }
        private System.Void .ctor(UnityEngine.UIElements.TwoPaneSplitView splitView, System.Int32 dir, UnityEngine.UIElements.TwoPaneSplitViewOrientation orientation) { }
        private System.Void RegisterCallbacksOnTarget() { }
        private System.Void UnregisterCallbacksFromTarget() { }
        private System.Void ApplyDelta(System.Single delta) { }
        private System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent e) { }
        private System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent e) { }
        private System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent e) { }

    }

    // TypeToken: 0x2000181
    public struct ColumnDataType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.ColumnDataType Name;        // 0x0
        public static UnityEngine.UIElements.ColumnDataType Title;        // 0x0
        public static UnityEngine.UIElements.ColumnDataType Icon;        // 0x0
        public static UnityEngine.UIElements.ColumnDataType Visibility;        // 0x0
        public static UnityEngine.UIElements.ColumnDataType Width;        // 0x0
        public static UnityEngine.UIElements.ColumnDataType MaxWidth;        // 0x0
        public static UnityEngine.UIElements.ColumnDataType MinWidth;        // 0x0
        public static UnityEngine.UIElements.ColumnDataType Stretchable;        // 0x0
        public static UnityEngine.UIElements.ColumnDataType Sortable;        // 0x0
        public static UnityEngine.UIElements.ColumnDataType Optional;        // 0x0
        public static UnityEngine.UIElements.ColumnDataType Resizable;        // 0x0
        public static UnityEngine.UIElements.ColumnDataType HeaderTemplate;        // 0x0
        public static UnityEngine.UIElements.ColumnDataType CellTemplate;        // 0x0

    }

    // TypeToken: 0x2000182
    public class Column
    {
        // Fields
        private static readonly System.String k_InvalidTemplateError;        // 0x0
        private System.String m_Name;        // 0x10
        private System.String m_Title;        // 0x18
        private UnityEngine.UIElements.Background m_Icon;        // 0x20
        private System.Boolean m_Visible;        // 0x40
        private UnityEngine.UIElements.Length m_Width;        // 0x44
        private UnityEngine.UIElements.Length m_MinWidth;        // 0x4C
        private UnityEngine.UIElements.Length m_MaxWidth;        // 0x54
        private System.Single m_DesiredWidth;        // 0x5C
        private System.Boolean m_Stretchable;        // 0x60
        private System.Boolean m_Sortable;        // 0x61
        private System.Boolean m_Optional;        // 0x62
        private System.Boolean m_Resizable;        // 0x63
        private System.Func<UnityEngine.UIElements.VisualElement> m_MakeHeader;        // 0x68
        private System.Action<UnityEngine.UIElements.VisualElement> m_BindHeader;        // 0x70
        private System.Action<UnityEngine.UIElements.VisualElement> m_UnbindHeader;        // 0x78
        private System.Action<UnityEngine.UIElements.VisualElement> m_DestroyHeader;        // 0x80
        private System.Func<UnityEngine.UIElements.VisualElement> m_MakeCell;        // 0x88
        private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> m_BindCell;        // 0x90
        private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> m_UnbindCellItem;        // 0x98
        private System.Action<UnityEngine.UIElements.VisualElement> <destroyCell>k__BackingField;        // 0xA0
        private UnityEngine.UIElements.Columns <collection>k__BackingField;        // 0xA8
        private System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> changed;        // 0xB0
        private System.Action<UnityEngine.UIElements.Column> resized;        // 0xB8

        // Methods
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.String get_title() { }
        private System.Void set_title(System.String value) { }
        private UnityEngine.UIElements.Background get_icon() { }
        private System.Int32 get_index() { }
        private System.Int32 get_displayIndex() { }
        private System.Int32 get_visibleIndex() { }
        private System.Boolean get_visible() { }
        private System.Void set_visible(System.Boolean value) { }
        private UnityEngine.UIElements.Length get_width() { }
        private System.Void set_width(UnityEngine.UIElements.Length value) { }
        private UnityEngine.UIElements.Length get_minWidth() { }
        private System.Void set_minWidth(UnityEngine.UIElements.Length value) { }
        private UnityEngine.UIElements.Length get_maxWidth() { }
        private System.Void set_maxWidth(UnityEngine.UIElements.Length value) { }
        private System.Single get_desiredWidth() { }
        private System.Void set_desiredWidth(System.Single value) { }
        private System.Boolean get_sortable() { }
        private System.Void set_sortable(System.Boolean value) { }
        private System.Boolean get_stretchable() { }
        private System.Void set_stretchable(System.Boolean value) { }
        private System.Boolean get_optional() { }
        private System.Void set_optional(System.Boolean value) { }
        private System.Boolean get_resizable() { }
        private System.Void set_resizable(System.Boolean value) { }
        private System.Func<UnityEngine.UIElements.VisualElement> get_makeHeader() { }
        private System.Void set_makeHeader(System.Func<UnityEngine.UIElements.VisualElement> value) { }
        private System.Action<UnityEngine.UIElements.VisualElement> get_bindHeader() { }
        private System.Action<UnityEngine.UIElements.VisualElement> get_unbindHeader() { }
        private System.Action<UnityEngine.UIElements.VisualElement> get_destroyHeader() { }
        private System.Func<UnityEngine.UIElements.VisualElement> get_makeCell() { }
        private System.Void set_makeCell(System.Func<UnityEngine.UIElements.VisualElement> value) { }
        private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_bindCell() { }
        private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_unbindCell() { }
        private System.Action<UnityEngine.UIElements.VisualElement> get_destroyCell() { }
        private UnityEngine.UIElements.Columns get_collection() { }
        private System.Void set_collection(UnityEngine.UIElements.Columns value) { }
        private System.Void add_changed(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value) { }
        private System.Void remove_changed(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value) { }
        private System.Void add_resized(System.Action<UnityEngine.UIElements.Column> value) { }
        private System.Void remove_resized(System.Action<UnityEngine.UIElements.Column> value) { }
        private System.Void NotifyChange(UnityEngine.UIElements.ColumnDataType type) { }
        private System.Single GetWidth(System.Single layoutWidth) { }
        private System.Single GetMaxWidth(System.Single layoutWidth) { }
        private System.Single GetMinWidth(System.Single layoutWidth) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000187
    public class ColumnLayout
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_StretchableColumns;        // 0x10
        private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_FixedColumns;        // 0x18
        private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_RelativeWidthColumns;        // 0x20
        private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_MixedWidthColumns;        // 0x28
        private UnityEngine.UIElements.Columns m_Columns;        // 0x30
        private System.Single m_ColumnsWidth;        // 0x38
        private System.Boolean m_ColumnsWidthDirty;        // 0x3C
        private System.Single m_MaxColumnsWidth;        // 0x40
        private System.Single m_MinColumnsWidth;        // 0x44
        private System.Boolean m_IsDirty;        // 0x48
        private System.Single m_PreviousWidth;        // 0x4C
        private System.Single m_LayoutWidth;        // 0x50
        private System.Boolean m_DragResizeInPreviewMode;        // 0x54
        private System.Boolean m_DragResizing;        // 0x55
        private System.Single m_DragStartPos;        // 0x58
        private System.Single m_DragLastPos;        // 0x5C
        private System.Single m_DragInitialColumnWidth;        // 0x60
        private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_DragStretchableColumns;        // 0x68
        private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_DragRelativeColumns;        // 0x70
        private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_DragFixedColumns;        // 0x78
        private System.Collections.Generic.Dictionary<UnityEngine.UIElements.Column,System.Single> m_PreviewDesiredWidths;        // 0x80
        private System.Action layoutRequested;        // 0x88

        // Methods
        private UnityEngine.UIElements.Columns get_columns() { }
        private System.Single get_columnsWidth() { }
        private System.Single get_layoutWidth() { }
        private System.Single get_minColumnsWidth() { }
        private System.Single get_maxColumnsWidth() { }
        private System.Boolean get_hasStretchableColumns() { }
        private System.Boolean get_hasRelativeWidthColumns() { }
        private System.Void add_layoutRequested(System.Action value) { }
        private System.Void remove_layoutRequested(System.Action value) { }
        private System.Void .ctor(UnityEngine.UIElements.Columns columns) { }
        private System.Void Dirty() { }
        private System.Void OnColumnAdded(UnityEngine.UIElements.Column column, System.Int32 index) { }
        private System.Void OnColumnRemoved(UnityEngine.UIElements.Column column) { }
        private System.Void OnColumnReordered(UnityEngine.UIElements.Column column, System.Int32 from, System.Int32 to) { }
        private System.Boolean RequiresLayoutUpdate(UnityEngine.UIElements.ColumnDataType type) { }
        private System.Void OnColumnChanged(UnityEngine.UIElements.Column column, UnityEngine.UIElements.ColumnDataType type) { }
        private System.Void OnColumnResized(UnityEngine.UIElements.Column column) { }
        private System.Boolean IsClamped(System.Single value, System.Single min, System.Single max) { }
        private System.Void DoLayout(System.Single width) { }
        private System.Void StretchResizeColumns(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, System.Single& delta, System.Boolean resizeToFit, System.Boolean dragResize) { }
        private System.Void DistributeOverflow(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, System.Single& delta, System.Boolean resizeToFit, System.Boolean dragResize) { }
        private System.Void DistributeExcess(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, System.Single& delta, System.Boolean resizeToFit, System.Boolean dragResize) { }
        private System.Single RecomputeToMaxWidthProportionally(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, System.Single distributedDelta, System.Boolean setDesiredWidthOnly) { }
        private System.Single RecomputeToMinWidthProportionally(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, System.Single distributedDelta, System.Boolean setDesiredWidthOnly) { }
        private System.Single RecomputeToDesiredWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, System.Single distributedDelta, System.Boolean setDesiredWidthOnly, System.Boolean distributeOverflow) { }
        private System.Single RecomputeToDesiredWidth(UnityEngine.UIElements.Column column, System.Single distributedDelta, System.Boolean setDesiredWidthOnly, System.Boolean distributeOverflow) { }
        private System.Single RecomputeToMinWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, System.Single distributedDelta, System.Boolean setDesiredWidthOnly) { }
        private System.Single RecomputeToMaxWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, System.Single distributedDelta, System.Boolean setDesiredWidthOnly) { }
        private System.Void ResizeToFit(System.Single width) { }
        private System.Void ResizeColumn(UnityEngine.UIElements.Column column, System.Single width, System.Boolean setDesiredWidthOnly) { }
        private System.Void BeginDragResize(UnityEngine.UIElements.Column column, System.Single pos, System.Boolean previewMode) { }
        private System.Single GetDesiredPosition(UnityEngine.UIElements.Column column) { }
        private System.Single GetDesiredWidth(UnityEngine.UIElements.Column c) { }
        private System.Void DragResize(UnityEngine.UIElements.Column column, System.Single pos) { }
        private System.Void EndDragResize(UnityEngine.UIElements.Column column, System.Boolean cancelled) { }
        private System.Void UpdateCache() { }
        private System.Void UpdateMinAndMaxColumnsWidth() { }
        private System.Void ClearCache() { }
        private System.Int32 <DoLayout>b__49_0(UnityEngine.UIElements.Column c1, UnityEngine.UIElements.Column c2) { }
        private System.Int32 <DoLayout>b__49_1(UnityEngine.UIElements.Column c1, UnityEngine.UIElements.Column c2) { }
        private System.Int32 <RecomputeToMaxWidthProportionally>b__53_0(UnityEngine.UIElements.Column c1, UnityEngine.UIElements.Column c2) { }
        private System.Int32 <RecomputeToMinWidthProportionally>b__54_0(UnityEngine.UIElements.Column c1, UnityEngine.UIElements.Column c2) { }

    }

    // TypeToken: 0x200018A
    public struct ColumnsDataType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.ColumnsDataType PrimaryColumn;        // 0x0
        public static UnityEngine.UIElements.ColumnsDataType StretchMode;        // 0x0
        public static UnityEngine.UIElements.ColumnsDataType Reorderable;        // 0x0
        public static UnityEngine.UIElements.ColumnsDataType Resizable;        // 0x0
        public static UnityEngine.UIElements.ColumnsDataType ResizePreview;        // 0x0

    }

    // TypeToken: 0x200018B
    public class Columns, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private System.Collections.Generic.IList<UnityEngine.UIElements.Column> m_Columns;        // 0x10
        private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_DisplayColumns;        // 0x18
        private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_VisibleColumns;        // 0x20
        private System.Boolean m_VisibleColumnsDirty;        // 0x28
        private UnityEngine.UIElements.Columns.StretchMode m_StretchMode;        // 0x2C
        private System.Boolean m_Reorderable;        // 0x30
        private System.Boolean m_Resizable;        // 0x31
        private System.Boolean m_ResizePreview;        // 0x32
        private System.String m_PrimaryColumnName;        // 0x38
        private System.Action<UnityEngine.UIElements.ColumnsDataType> changed;        // 0x40
        private System.Action<UnityEngine.UIElements.Column,System.Int32> columnAdded;        // 0x48
        private System.Action<UnityEngine.UIElements.Column> columnRemoved;        // 0x50
        private System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> columnChanged;        // 0x58
        private System.Action<UnityEngine.UIElements.Column> columnResized;        // 0x60
        private System.Action<UnityEngine.UIElements.Column,System.Int32,System.Int32> columnReordered;        // 0x68

        // Methods
        private System.String get_primaryColumnName() { }
        private System.Void set_primaryColumnName(System.String value) { }
        private System.Boolean get_reorderable() { }
        private System.Void set_reorderable(System.Boolean value) { }
        private System.Boolean get_resizable() { }
        private System.Void set_resizable(System.Boolean value) { }
        private System.Boolean get_resizePreview() { }
        private System.Void set_resizePreview(System.Boolean value) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.UIElements.Column> get_displayList() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.UIElements.Column> get_visibleList() { }
        private System.Void add_changed(System.Action<UnityEngine.UIElements.ColumnsDataType> value) { }
        private System.Void remove_changed(System.Action<UnityEngine.UIElements.ColumnsDataType> value) { }
        private UnityEngine.UIElements.Columns.StretchMode get_stretchMode() { }
        private System.Void set_stretchMode(UnityEngine.UIElements.Columns.StretchMode value) { }
        private System.Void add_columnAdded(System.Action<UnityEngine.UIElements.Column,System.Int32> value) { }
        private System.Void remove_columnAdded(System.Action<UnityEngine.UIElements.Column,System.Int32> value) { }
        private System.Void add_columnRemoved(System.Action<UnityEngine.UIElements.Column> value) { }
        private System.Void remove_columnRemoved(System.Action<UnityEngine.UIElements.Column> value) { }
        private System.Void add_columnChanged(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value) { }
        private System.Void remove_columnChanged(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value) { }
        private System.Void add_columnResized(System.Action<UnityEngine.UIElements.Column> value) { }
        private System.Void remove_columnResized(System.Action<UnityEngine.UIElements.Column> value) { }
        private System.Void add_columnReordered(System.Action<UnityEngine.UIElements.Column,System.Int32,System.Int32> value) { }
        private System.Void remove_columnReordered(System.Action<UnityEngine.UIElements.Column,System.Int32,System.Int32> value) { }
        private System.Boolean IsPrimary(UnityEngine.UIElements.Column column) { }
        private System.Collections.Generic.IEnumerator<UnityEngine.UIElements.Column> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void Add(UnityEngine.UIElements.Column item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(UnityEngine.UIElements.Column item) { }
        private System.Boolean Contains(System.String name) { }
        private System.Void CopyTo(UnityEngine.UIElements.Column[] array, System.Int32 arrayIndex) { }
        private System.Boolean Remove(UnityEngine.UIElements.Column column) { }
        private System.Void OnColumnChanged(UnityEngine.UIElements.Column column, UnityEngine.UIElements.ColumnDataType type) { }
        private System.Void OnColumnResized(UnityEngine.UIElements.Column column) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Int32 IndexOf(UnityEngine.UIElements.Column column) { }
        private System.Void Insert(System.Int32 index, UnityEngine.UIElements.Column column) { }
        private UnityEngine.UIElements.Column get_Item(System.Int32 index) { }
        private UnityEngine.UIElements.Column get_Item(System.String name) { }
        private System.Void ReorderDisplay(System.Int32 from, System.Int32 to) { }
        private System.Void InitOrderColumns() { }
        private System.Void DirtyVisibleColumns() { }
        private System.Void UpdateVisibleColumns() { }
        private System.Void NotifyChange(UnityEngine.UIElements.ColumnsDataType type) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000190
    public class MultiColumnController, IDisposable
    {
        // Fields
        private static readonly UnityEngine.PropertyName k_BoundColumnVePropertyName;        // 0x0
        private static readonly UnityEngine.PropertyName bindableElementPropertyName;        // 0x4
        private static readonly System.String baseUssClassName;        // 0x8
        private static readonly System.String k_HeaderContainerViewDataKey;        // 0x10
        public static readonly System.String headerContainerUssClassName;        // 0x18
        public static readonly System.String rowContainerUssClassName;        // 0x20
        public static readonly System.String cellUssClassName;        // 0x28
        public static readonly System.String cellLabelUssClassName;        // 0x30
        private static readonly System.String k_HeaderViewDataKey;        // 0x38
        private System.Action columnSortingChanged;        // 0x10
        private System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> headerContextMenuPopulateEvent;        // 0x18
        private UnityEngine.UIElements.BaseVerticalCollectionView m_View;        // 0x20
        private UnityEngine.UIElements.VisualElement m_HeaderContainer;        // 0x28
        private UnityEngine.UIElements.Internal.MultiColumnCollectionHeader m_MultiColumnHeader;        // 0x30

        // Methods
        private System.Void add_columnSortingChanged(System.Action value) { }
        private System.Void remove_columnSortingChanged(System.Action value) { }
        private System.Void add_headerContextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value) { }
        private System.Void remove_headerContextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value) { }
        private UnityEngine.UIElements.Internal.MultiColumnCollectionHeader get_header() { }
        private System.Void .ctor(UnityEngine.UIElements.Columns columns, UnityEngine.UIElements.SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }
        private System.Void BindCellItem(UnityEngine.UIElements.VisualElement ve, System.Int32 rowIndex, UnityEngine.UIElements.Column column, T item) { }
        private System.Void UnbindCellItem(UnityEngine.UIElements.VisualElement ve, System.Int32 rowIndex, UnityEngine.UIElements.Column column) { }
        private UnityEngine.UIElements.VisualElement DefaultMakeCellItem() { }
        private System.Void DefaultBindCellItem(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.Column column, T item) { }
        private UnityEngine.UIElements.VisualElement MakeItem() { }
        private System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index, T item) { }
        private System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index) { }
        private System.Void DestroyItem(UnityEngine.UIElements.VisualElement element) { }
        private System.Void PrepareView(UnityEngine.UIElements.BaseVerticalCollectionView collectionView) { }
        private System.Void Dispose() { }
        private System.Void OnHorizontalScrollerValueChanged(System.Single v) { }
        private System.Void OnViewportGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt) { }
        private System.Void OnColumnContainerGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt) { }
        private System.Void UpdateContentContainer(UnityEngine.UIElements.BaseVerticalCollectionView collectionView) { }
        private System.Void OnColumnSortingChanged() { }
        private System.Void OnContextMenuPopulateEvent(UnityEngine.UIElements.ContextualMenuPopulateEvent evt, UnityEngine.UIElements.Column column) { }
        private System.Void OnColumnResized(System.Int32 index, System.Single width) { }
        private System.Void OnColumnAdded(UnityEngine.UIElements.Column column, System.Int32 index) { }
        private System.Void OnColumnRemoved(UnityEngine.UIElements.Column column) { }
        private System.Void OnColumnReordered(UnityEngine.UIElements.Column column, System.Int32 from, System.Int32 to) { }
        private System.Void OnColumnsChanged(UnityEngine.UIElements.Column column, UnityEngine.UIElements.ColumnDataType type) { }
        private System.Void OnColumnChanged(UnityEngine.UIElements.ColumnsDataType type) { }
        private System.Void OnViewDataRestored() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000191
    public class MultiColumnListView : BaseListView
    {
        // Fields
        private UnityEngine.UIElements.Columns m_Columns;        // 0x538
        private System.Boolean m_SortingEnabled;        // 0x540
        private UnityEngine.UIElements.SortColumnDescriptions m_SortColumnDescriptions;        // 0x548
        private System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> m_SortedColumns;        // 0x550
        private System.Action columnSortingChanged;        // 0x558
        private System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> headerContextMenuPopulateEvent;        // 0x560

        // Methods
        private UnityEngine.UIElements.MultiColumnListViewController get_viewController() { }
        private UnityEngine.UIElements.Columns get_columns() { }
        private System.Void set_columns(UnityEngine.UIElements.Columns value) { }
        private UnityEngine.UIElements.SortColumnDescriptions get_sortColumnDescriptions() { }
        private System.Void set_sortColumnDescriptions(UnityEngine.UIElements.SortColumnDescriptions value) { }
        private System.Void set_sortingEnabled(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.UIElements.Columns columns) { }
        private UnityEngine.UIElements.CollectionViewController CreateViewController() { }
        private System.Void SetViewController(UnityEngine.UIElements.CollectionViewController controller) { }
        private System.Void CreateVirtualizationController() { }
        private System.Void RaiseColumnSortingChanged() { }
        private System.Void RaiseHeaderContextMenuPopulate(UnityEngine.UIElements.ContextualMenuPopulateEvent evt, UnityEngine.UIElements.Column column) { }

    }

    // TypeToken: 0x2000194
    public class MultiColumnTreeView : BaseTreeView
    {
        // Fields
        private UnityEngine.UIElements.Columns m_Columns;        // 0x4B8
        private System.Boolean m_SortingEnabled;        // 0x4C0
        private UnityEngine.UIElements.SortColumnDescriptions m_SortColumnDescriptions;        // 0x4C8
        private System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> m_SortedColumns;        // 0x4D0
        private System.Action columnSortingChanged;        // 0x4D8
        private System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> headerContextMenuPopulateEvent;        // 0x4E0

        // Methods
        private UnityEngine.UIElements.MultiColumnTreeViewController get_viewController() { }
        private UnityEngine.UIElements.Columns get_columns() { }
        private System.Void set_columns(UnityEngine.UIElements.Columns value) { }
        private UnityEngine.UIElements.SortColumnDescriptions get_sortColumnDescriptions() { }
        private System.Void set_sortColumnDescriptions(UnityEngine.UIElements.SortColumnDescriptions value) { }
        private System.Void set_sortingEnabled(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.UIElements.Columns columns) { }
        private UnityEngine.UIElements.CollectionViewController CreateViewController() { }
        private System.Void SetViewController(UnityEngine.UIElements.CollectionViewController controller) { }
        private System.Void CreateVirtualizationController() { }
        private System.Void RaiseColumnSortingChanged() { }
        private System.Void RaiseHeaderContextMenuPopulate(UnityEngine.UIElements.ContextualMenuPopulateEvent evt, UnityEngine.UIElements.Column column) { }

    }

    // TypeToken: 0x2000197
    public struct SortDirection
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.SortDirection Ascending;        // 0x0
        public static UnityEngine.UIElements.SortDirection Descending;        // 0x0

    }

    // TypeToken: 0x2000198
    public class SortColumnDescription
    {
        // Fields
        private System.Int32 m_ColumnIndex;        // 0x10
        private System.String m_ColumnName;        // 0x18
        private UnityEngine.UIElements.SortDirection m_SortDirection;        // 0x20
        private UnityEngine.UIElements.Column <column>k__BackingField;        // 0x28
        private System.Action<UnityEngine.UIElements.SortColumnDescription> changed;        // 0x30

        // Methods
        private System.String get_columnName() { }
        private System.Void set_columnName(System.String value) { }
        private System.Int32 get_columnIndex() { }
        private System.Void set_columnIndex(System.Int32 value) { }
        private UnityEngine.UIElements.Column get_column() { }
        private System.Void set_column(UnityEngine.UIElements.Column value) { }
        private UnityEngine.UIElements.SortDirection get_direction() { }
        private System.Void set_direction(UnityEngine.UIElements.SortDirection value) { }
        private System.Void add_changed(System.Action<UnityEngine.UIElements.SortColumnDescription> value) { }
        private System.Void remove_changed(System.Action<UnityEngine.UIElements.SortColumnDescription> value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 columnIndex, UnityEngine.UIElements.SortDirection direction) { }
        private System.Void .ctor(System.String columnName, UnityEngine.UIElements.SortDirection direction) { }

    }

    // TypeToken: 0x200019B
    public class SortColumnDescriptions, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly System.Collections.Generic.IList<UnityEngine.UIElements.SortColumnDescription> m_Descriptions;        // 0x10
        private System.Action changed;        // 0x18

        // Methods
        private System.Void add_changed(System.Action value) { }
        private System.Void remove_changed(System.Action value) { }
        private System.Collections.Generic.IEnumerator<UnityEngine.UIElements.SortColumnDescription> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void Add(UnityEngine.UIElements.SortColumnDescription item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(UnityEngine.UIElements.SortColumnDescription item) { }
        private System.Void CopyTo(UnityEngine.UIElements.SortColumnDescription[] array, System.Int32 arrayIndex) { }
        private System.Boolean Remove(UnityEngine.UIElements.SortColumnDescription desc) { }
        private System.Void OnDescriptionChanged(UnityEngine.UIElements.SortColumnDescription desc) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Void Insert(System.Int32 index, UnityEngine.UIElements.SortColumnDescription desc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200019E
    public class BaseReorderableDragAndDropController, ICollectionDragAndDropController, IDragAndDropController`1, IReorderable
    {
        // Fields
        protected readonly UnityEngine.UIElements.BaseVerticalCollectionView m_View;        // 0x10
        protected System.Collections.Generic.List<System.Int32> m_SortedSelectedIds;        // 0x18
        private System.Boolean <enableReordering>k__BackingField;        // 0x20

        // Methods
        private System.Collections.Generic.IEnumerable<System.Int32> GetSortedSelectedIds() { }
        private System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView view) { }
        private System.Boolean get_enableReordering() { }
        private System.Void set_enableReordering(System.Boolean value) { }
        private System.Boolean CanStartDrag(System.Collections.Generic.IEnumerable<System.Int32> itemIndices) { }
        private UnityEngine.UIElements.StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIds, System.Boolean skipText) { }
        private System.Int32 CompareId(System.Int32 id1, System.Int32 id2) { }
        private UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(UnityEngine.UIElements.IListDragAndDropArgs args) { }
        private System.Void OnDrop(UnityEngine.UIElements.IListDragAndDropArgs args) { }
        private System.Void DragCleanup() { }
        private System.Void HandleAutoExpand(UnityEngine.UIElements.ReusableCollectionItem item, UnityEngine.Vector2 pointerPosition) { }

    }

    // TypeToken: 0x200019F
    public class DragAndDropUtility
    {
        // Fields
        private static System.Func<UnityEngine.UIElements.IDragAndDrop> s_MakeDragAndDropClientFunc;        // 0x0
        private static UnityEngine.UIElements.IDragAndDrop s_DragAndDropEditor;        // 0x8
        private static UnityEngine.UIElements.IDragAndDrop s_DragAndDropPlayMode;        // 0x10

        // Methods
        private UnityEngine.UIElements.IDragAndDrop GetDragAndDrop(UnityEngine.UIElements.IPanel panel) { }

    }

    // TypeToken: 0x20001A0
    public class DefaultDragAndDropClient : DragAndDropData, IDragAndDrop
    {
        // Fields
        private readonly System.Collections.Hashtable m_GenericData;        // 0x10
        private UnityEngine.UIElements.Label m_DraggedInfoLabel;        // 0x18
        private UnityEngine.UIElements.DragVisualMode m_VisualMode;        // 0x20
        private System.Collections.Generic.IEnumerable<UnityEngine.Object> m_UnityObjectReferences;        // 0x28

        // Methods
        private System.Object get_source() { }
        private System.Object GetGenericData(System.String key) { }
        private System.Void StartDrag(UnityEngine.UIElements.StartDragArgs args, UnityEngine.Vector3 pointerPosition) { }
        private System.Void UpdateDrag(UnityEngine.Vector3 pointerPosition) { }
        private System.Void AcceptDrag() { }
        private System.Void SetVisualMode(UnityEngine.UIElements.DragVisualMode mode) { }
        private System.Void DragCleanup() { }
        private UnityEngine.UIElements.DragAndDropData get_data() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A1
    public class DragEventsProcessor
    {
        // Fields
        private System.Boolean m_IsRegistered;        // 0x10
        private UnityEngine.UIElements.DragEventsProcessor.DragState m_DragState;        // 0x14
        private UnityEngine.Vector3 m_Start;        // 0x18
        private readonly UnityEngine.UIElements.VisualElement m_Target;        // 0x28

        // Methods
        private System.Boolean get_supportsDragEvents() { }
        private System.Boolean get_useDragEvents() { }
        private UnityEngine.UIElements.IDragAndDrop get_dragAndDrop() { }
        private System.Boolean get_isEditorContext() { }
        private System.Void .ctor(UnityEngine.UIElements.VisualElement target) { }
        private System.Void RegisterCallbacksFromTarget(UnityEngine.UIElements.AttachToPanelEvent evt) { }
        private System.Void RegisterCallbacksFromTarget() { }
        private System.Void UnregisterCallbacksFromTarget(UnityEngine.UIElements.DetachFromPanelEvent evt) { }
        private System.Void UnregisterCallbacksFromTarget(System.Boolean unregisterPanelEvents) { }
        private System.Boolean CanStartDrag(UnityEngine.Vector3 pointerPosition) { }
        private UnityEngine.UIElements.StartDragArgs StartDrag(UnityEngine.Vector3 pointerPosition) { }
        private System.Void UpdateDrag(UnityEngine.Vector3 pointerPosition) { }
        private System.Void OnDrop(UnityEngine.Vector3 pointerPosition) { }
        private System.Void ClearDragAndDropUI(System.Boolean dragCancelled) { }
        private System.Void OnPointerDownEvent(UnityEngine.UIElements.PointerDownEvent evt) { }
        private System.Void OnPointerUpEvent(UnityEngine.UIElements.PointerUpEvent evt) { }
        private System.Void OnPointerLeaveEvent(UnityEngine.UIElements.PointerLeaveEvent evt) { }
        private System.Void OnPointerCancelEvent(UnityEngine.UIElements.PointerCancelEvent evt) { }
        private System.Void OnPointerCapturedOut(UnityEngine.UIElements.PointerCaptureOutEvent evt) { }
        private System.Void OnPointerMoveEvent(UnityEngine.UIElements.PointerMoveEvent evt) { }
        private UnityEngine.UIElements.DragEventsProcessor GetDropTarget(UnityEngine.Vector2 position) { }

    }

    // TypeToken: 0x20001A3
    public interface ICollectionDragAndDropController : IDragAndDropController`1, IReorderable
    {
    }

    // TypeToken: 0x20001A4
    public interface IDragAndDrop
    {
        // Methods
        private System.Void StartDrag(UnityEngine.UIElements.StartDragArgs args, UnityEngine.Vector3 pointerPosition) { }
        private System.Void UpdateDrag(UnityEngine.Vector3 pointerPosition) { }
        private System.Void AcceptDrag() { }
        private System.Void DragCleanup() { }
        private System.Void SetVisualMode(UnityEngine.UIElements.DragVisualMode visualMode) { }
        private UnityEngine.UIElements.DragAndDropData get_data() { }

    }

    // TypeToken: 0x20001A5
    public class DragAndDropData
    {
        // Methods
        private System.Object GetGenericData(System.String key) { }
        private System.Object get_source() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A6
    public interface IDragAndDropController`1
    {
        // Methods
        private System.Boolean CanStartDrag(System.Collections.Generic.IEnumerable<System.Int32> itemIndices) { }
        private UnityEngine.UIElements.StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIndices, System.Boolean skipText) { }
        private UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(TArgs args) { }
        private System.Void OnDrop(TArgs args) { }
        private System.Void DragCleanup() { }
        private System.Void HandleAutoExpand(UnityEngine.UIElements.ReusableCollectionItem item, UnityEngine.Vector2 pointerPosition) { }
        private System.Collections.Generic.IEnumerable<System.Int32> GetSortedSelectedIds() { }

    }

    // TypeToken: 0x20001A7
    public struct DragVisualMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.DragVisualMode None;        // 0x0
        public static UnityEngine.UIElements.DragVisualMode Copy;        // 0x0
        public static UnityEngine.UIElements.DragVisualMode Move;        // 0x0
        public static UnityEngine.UIElements.DragVisualMode Rejected;        // 0x0

    }

    // TypeToken: 0x20001A8
    public struct CanStartDragArgs
    {
        // Fields
        public readonly UnityEngine.UIElements.VisualElement draggedElement;        // 0x10
        public readonly System.Int32 id;        // 0x18
        public readonly System.Collections.Generic.IEnumerable<System.Int32> selectedIds;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.VisualElement draggedElement, System.Int32 id, System.Collections.Generic.IEnumerable<System.Int32> selectedIds) { }

    }

    // TypeToken: 0x20001A9
    public struct SetupDragAndDropArgs
    {
        // Fields
        public readonly UnityEngine.UIElements.VisualElement draggedElement;        // 0x10
        public readonly System.Collections.Generic.IEnumerable<System.Int32> selectedIds;        // 0x18
        public readonly UnityEngine.UIElements.StartDragArgs startDragArgs;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.VisualElement draggedElement, System.Collections.Generic.IEnumerable<System.Int32> selectedIds, UnityEngine.UIElements.StartDragArgs startDragArgs) { }

    }

    // TypeToken: 0x20001AA
    public struct HandleDragAndDropArgs
    {
        // Fields
        private readonly UnityEngine.UIElements.DragAndDropArgs m_DragAndDropArgs;        // 0x10
        private readonly UnityEngine.Vector2 <position>k__BackingField;        // 0x30

        // Methods
        private System.Void .ctor(UnityEngine.Vector2 position, UnityEngine.UIElements.DragAndDropArgs dragAndDropArgs) { }

    }

    // TypeToken: 0x20001AB
    public struct StartDragArgs
    {
        // Fields
        private readonly System.String <title>k__BackingField;        // 0x10
        private readonly UnityEngine.UIElements.DragVisualMode <visualMode>k__BackingField;        // 0x18
        private System.Collections.Hashtable <genericData>k__BackingField;        // 0x20
        private System.Collections.Generic.IEnumerable<UnityEngine.Object> <unityObjectReferences>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor(System.String title, UnityEngine.UIElements.DragVisualMode visualMode) { }
        private System.String get_title() { }
        private UnityEngine.UIElements.DragVisualMode get_visualMode() { }
        private System.Collections.Hashtable get_genericData() { }
        private System.Void set_genericData(System.Collections.Hashtable value) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Object> get_unityObjectReferences() { }
        private System.Void set_unityObjectReferences(System.Collections.Generic.IEnumerable<UnityEngine.Object> value) { }
        private System.Void SetGenericData(System.String key, System.Object data) { }

    }

    // TypeToken: 0x20001AC
    public interface IListDragAndDropArgs
    {
        // Methods
        private System.Int32 get_insertAtIndex() { }
        private System.Int32 get_parentId() { }
        private System.Int32 get_childIndex() { }
        private UnityEngine.UIElements.DragAndDropData get_dragAndDropData() { }
        private UnityEngine.UIElements.DragAndDropPosition get_dragAndDropPosition() { }

    }

    // TypeToken: 0x20001AD
    public struct DragAndDropArgs, IListDragAndDropArgs
    {
        // Fields
        private System.Object <target>k__BackingField;        // 0x10
        private System.Int32 <insertAtIndex>k__BackingField;        // 0x18
        private System.Int32 <parentId>k__BackingField;        // 0x1C
        private System.Int32 <childIndex>k__BackingField;        // 0x20
        private UnityEngine.UIElements.DragAndDropPosition <dragAndDropPosition>k__BackingField;        // 0x24
        private UnityEngine.UIElements.DragAndDropData <dragAndDropData>k__BackingField;        // 0x28

        // Methods
        private System.Void set_target(System.Object value) { }
        private System.Int32 get_insertAtIndex() { }
        private System.Void set_insertAtIndex(System.Int32 value) { }
        private System.Int32 get_parentId() { }
        private System.Void set_parentId(System.Int32 value) { }
        private System.Int32 get_childIndex() { }
        private System.Void set_childIndex(System.Int32 value) { }
        private UnityEngine.UIElements.DragAndDropPosition get_dragAndDropPosition() { }
        private System.Void set_dragAndDropPosition(UnityEngine.UIElements.DragAndDropPosition value) { }
        private UnityEngine.UIElements.DragAndDropData get_dragAndDropData() { }
        private System.Void set_dragAndDropData(UnityEngine.UIElements.DragAndDropData value) { }

    }

    // TypeToken: 0x20001AE
    public struct DragAndDropPosition
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.DragAndDropPosition OverItem;        // 0x0
        public static UnityEngine.UIElements.DragAndDropPosition BetweenItems;        // 0x0
        public static UnityEngine.UIElements.DragAndDropPosition OutsideItems;        // 0x0

    }

    // TypeToken: 0x20001AF
    public interface IReorderable
    {
        // Methods
        private System.Boolean get_enableReordering() { }
        private System.Void set_enableReordering(System.Boolean value) { }

    }

    // TypeToken: 0x20001B0
    public class ListViewDragger : DragEventsProcessor
    {
        // Fields
        private UnityEngine.UIElements.ListViewDragger.DragPosition m_LastDragPosition;        // 0x30
        private UnityEngine.UIElements.VisualElement m_DragHoverBar;        // 0x50
        private UnityEngine.UIElements.VisualElement m_DragHoverItemMarker;        // 0x58
        private UnityEngine.UIElements.VisualElement m_DragHoverSiblingMarker;        // 0x60
        private System.Single m_LeftIndentation;        // 0x68
        private System.Single m_SiblingBottom;        // 0x6C
        private UnityEngine.UIElements.ICollectionDragAndDropController <dragAndDropController>k__BackingField;        // 0x70

        // Methods
        private UnityEngine.UIElements.BaseVerticalCollectionView get_targetView() { }
        private UnityEngine.UIElements.ScrollView get_targetScrollView() { }
        private UnityEngine.UIElements.ICollectionDragAndDropController get_dragAndDropController() { }
        private System.Void set_dragAndDropController(UnityEngine.UIElements.ICollectionDragAndDropController value) { }
        private System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView listView) { }
        private System.Boolean CanStartDrag(UnityEngine.Vector3 pointerPosition) { }
        private UnityEngine.UIElements.StartDragArgs StartDrag(UnityEngine.Vector3 pointerPosition) { }
        private System.Void UpdateDrag(UnityEngine.Vector3 pointerPosition) { }
        private UnityEngine.UIElements.DragVisualMode GetVisualMode(UnityEngine.Vector3 pointerPosition, UnityEngine.UIElements.ListViewDragger.DragPosition& dragPosition) { }
        private System.Void OnDrop(UnityEngine.Vector3 pointerPosition) { }
        private System.Void HandleDragAndScroll(UnityEngine.Vector2 pointerPosition) { }
        private System.Void HandleAutoExpansion(UnityEngine.Vector2 pointerPosition) { }
        private System.Void ApplyDragAndDropUI(UnityEngine.UIElements.ListViewDragger.DragPosition dragPosition) { }
        private System.Boolean TryGetDragPosition(UnityEngine.Vector2 pointerPosition, UnityEngine.UIElements.ListViewDragger.DragPosition& dragPosition) { }
        private System.Void HandleTreePosition(UnityEngine.Vector2 pointerPosition, UnityEngine.UIElements.ListViewDragger.DragPosition& dragPosition) { }
        private System.Void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(UnityEngine.UIElements.ListViewDragger.DragPosition& dragPosition, UnityEngine.Vector2 pointerPosition) { }
        private System.Void GetPreviousAndNextItemsIgnoringDraggedItems(System.Int32 insertAtIndex, System.Int32& previousItemId, System.Int32& nextItemId) { }
        private UnityEngine.UIElements.DragAndDropArgs MakeDragAndDropArgs(UnityEngine.UIElements.ListViewDragger.DragPosition dragPosition) { }
        private System.Single GetHoverBarTopPosition(UnityEngine.UIElements.ReusableCollectionItem item) { }
        private System.Void PlaceHoverBarAtElement(UnityEngine.UIElements.ReusableCollectionItem item) { }
        private System.Void PlaceHoverBarAt(System.Single top, System.Single indentationPadding, System.Single siblingBottom) { }
        private System.Void ClearDragAndDropUI(System.Boolean dragCancelled) { }
        private UnityEngine.UIElements.ReusableCollectionItem GetRecycledItem(UnityEngine.Vector3 pointerPosition) { }
        private System.Void <ApplyDragAndDropUI>g__GeometryChangedCallback|27_0(UnityEngine.UIElements.GeometryChangedEvent e) { }

    }

    // TypeToken: 0x20001B2
    public class ListViewDraggerExtension
    {
        // Methods
        private UnityEngine.UIElements.ReusableCollectionItem GetRecycledItemFromId(UnityEngine.UIElements.BaseVerticalCollectionView listView, System.Int32 id) { }
        private UnityEngine.UIElements.ReusableCollectionItem GetRecycledItemFromIndex(UnityEngine.UIElements.BaseVerticalCollectionView listView, System.Int32 index) { }

    }

    // TypeToken: 0x20001B3
    public class ListViewDraggerAnimated : ListViewDragger
    {
        // Fields
        private System.Int32 m_DragStartIndex;        // 0x78
        private System.Int32 m_CurrentIndex;        // 0x7C
        private System.Single m_SelectionHeight;        // 0x80
        private System.Single m_LocalOffsetOnStart;        // 0x84
        private UnityEngine.Vector3 m_CurrentPointerPosition;        // 0x88
        private UnityEngine.UIElements.ReusableCollectionItem m_Item;        // 0x98
        private UnityEngine.UIElements.ReusableCollectionItem m_OffsetItem;        // 0xA0
        private System.Boolean <isDragging>k__BackingField;        // 0xA8

        // Methods
        private System.Boolean get_isDragging() { }
        private System.Void set_isDragging(System.Boolean value) { }
        private UnityEngine.UIElements.ReusableCollectionItem get_draggedItem() { }
        private System.Boolean get_supportsDragEvents() { }
        private System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView listView) { }
        private UnityEngine.UIElements.StartDragArgs StartDrag(UnityEngine.Vector3 pointerPosition) { }
        private System.Void UpdateDrag(UnityEngine.Vector3 pointerPosition) { }
        private System.Void Animate(UnityEngine.UIElements.ReusableCollectionItem element, System.Single paddingTop) { }
        private System.Void OnDrop(UnityEngine.Vector3 pointerPosition) { }
        private System.Void ClearDragAndDropUI(System.Boolean dragCancelled) { }
        private System.Boolean TryGetDragPosition(UnityEngine.Vector2 pointerPosition, UnityEngine.UIElements.ListViewDragger.DragPosition& dragPosition) { }

    }

    // TypeToken: 0x20001B4
    public class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController
    {
        // Fields
        protected readonly UnityEngine.UIElements.BaseListView m_ListView;        // 0x28

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.BaseListView view) { }
        private UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(UnityEngine.UIElements.IListDragAndDropArgs args) { }
        private System.Void OnDrop(UnityEngine.UIElements.IListDragAndDropArgs args) { }

    }

    // TypeToken: 0x20001B5
    public class TreeViewReorderableDragAndDropController : BaseReorderableDragAndDropController
    {
        // Fields
        protected UnityEngine.UIElements.TreeViewReorderableDragAndDropController.DropData m_DropData;        // 0x28
        protected readonly UnityEngine.UIElements.BaseTreeView m_TreeView;        // 0x30
        private UnityEngine.UIElements.IVisualElementScheduledItem m_ExpandDropItemScheduledItem;        // 0x38
        private System.Action m_ExpandDropItemCallback;        // 0x40

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.BaseTreeView view) { }
        private System.Int32 CompareId(System.Int32 id1, System.Int32 id2) { }
        private UnityEngine.UIElements.StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIds, System.Boolean skipText) { }
        private UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(UnityEngine.UIElements.IListDragAndDropArgs args) { }
        private System.Void OnDrop(UnityEngine.UIElements.IListDragAndDropArgs args) { }
        private System.Void DragCleanup() { }
        private System.Void RestoreExpanded(System.Collections.Generic.List<System.Int32> ids) { }
        private System.Void HandleAutoExpand(UnityEngine.UIElements.ReusableCollectionItem item, UnityEngine.Vector2 pointerPosition) { }
        private System.Void DelayExpandDropItem() { }
        private System.Void ExpandDropItem() { }

    }

    // TypeToken: 0x20001B8
    public interface IPointerCaptureEventInternal
    {
        // Methods
        private System.Int32 get_pointerId() { }

    }

    // TypeToken: 0x20001B9
    public class PointerCaptureEventBase`1 : EventBase`1, IPointerCaptureEventInternal
    {
        // Fields
        private UnityEngine.UIElements.IEventHandler <relatedTarget>k__BackingField;        // 0x0
        private System.Int32 <pointerId>k__BackingField;        // 0x0

        // Methods
        private System.Void set_relatedTarget(UnityEngine.UIElements.IEventHandler value) { }
        private System.Int32 get_pointerId() { }
        private System.Void set_pointerId(System.Int32 value) { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private T GetPooled(UnityEngine.UIElements.IEventHandler target, UnityEngine.UIElements.IEventHandler relatedTarget, System.Int32 pointerId) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001BA
    public class PointerCaptureOutEvent : PointerCaptureEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001BB
    public class PointerCaptureEvent : PointerCaptureEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001BC
    public class MouseCaptureEventBase`1 : PointerCaptureEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001BD
    public class MouseCaptureOutEvent : MouseCaptureEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001BE
    public class MouseCaptureEvent : MouseCaptureEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001BF
    public class ChangeEvent`1 : EventBase`1
    {
        // Fields
        private T <previousValue>k__BackingField;        // 0x0
        private T <newValue>k__BackingField;        // 0x0

        // Methods
        private T get_previousValue() { }
        private System.Void set_previousValue(T value) { }
        private T get_newValue() { }
        private System.Void set_newValue(T value) { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private UnityEngine.UIElements.ChangeEvent<T> GetPooled(T previousValue, T newValue) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C0
    public class CommandEventDispatchingStrategy, IEventDispatchingStrategy
    {
        // Methods
        private System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C1
    public interface ICommandEvent
    {
    }

    // TypeToken: 0x20001C2
    public class CommandEventBase`1 : EventBase`1, ICommandEvent
    {
        // Fields
        private System.String m_CommandName;        // 0x0

        // Methods
        private System.String get_commandName() { }
        private System.Void set_commandName(System.String value) { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private T GetPooled(UnityEngine.Event systemEvent) { }
        private T GetPooled(System.String commandName) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C3
    public class ValidateCommandEvent : CommandEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C4
    public class ExecuteCommandEvent : CommandEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C5
    public class DefaultDispatchingStrategy, IEventDispatchingStrategy
    {
        // Methods
        private System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C6
    public class ElementUnderPointer
    {
        // Fields
        private UnityEngine.UIElements.VisualElement[] m_PendingTopElementUnderPointer;        // 0x10
        private UnityEngine.UIElements.VisualElement[] m_TopElementUnderPointer;        // 0x18
        private UnityEngine.UIElements.IPointerEvent[] m_TriggerPointerEvent;        // 0x20
        private UnityEngine.UIElements.IMouseEvent[] m_TriggerMouseEvent;        // 0x28
        private UnityEngine.Vector2[] m_PickingPointerPositions;        // 0x30
        private System.Boolean[] m_IsPickingPointerTemporaries;        // 0x38

        // Methods
        private UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(System.Int32 pointerId, UnityEngine.Vector2& pickPosition, System.Boolean& isTemporary) { }
        private UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(System.Int32 pointerId) { }
        private System.Void SetElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, System.Int32 pointerId, UnityEngine.Vector2 pointerPos) { }
        private UnityEngine.Vector2 GetEventPointerPosition(UnityEngine.UIElements.EventBase triggerEvent) { }
        private System.Void SetTemporaryElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, System.Int32 pointerId, UnityEngine.UIElements.EventBase triggerEvent) { }
        private System.Void SetElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, System.Int32 pointerId, UnityEngine.UIElements.EventBase triggerEvent) { }
        private System.Void SetElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, System.Int32 pointerId, UnityEngine.UIElements.EventBase triggerEvent, System.Boolean temporary) { }
        private System.Void CommitElementUnderPointers(UnityEngine.UIElements.EventDispatcher dispatcher, UnityEngine.UIElements.ContextType contextType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C7
    public class EventBase, IDisposable
    {
        // Fields
        private static System.Int64 s_LastTypeId;        // 0x0
        private static System.UInt64 s_NextEventId;        // 0x8
        private System.Int64 <timestamp>k__BackingField;        // 0x10
        private System.UInt64 <eventId>k__BackingField;        // 0x18
        private System.UInt64 <triggerEventId>k__BackingField;        // 0x20
        private UnityEngine.UIElements.EventBase.EventPropagation <propagation>k__BackingField;        // 0x28
        private UnityEngine.UIElements.PropagationPaths m_Path;        // 0x30
        private UnityEngine.UIElements.EventBase.LifeCycleStatus <lifeCycleStatus>k__BackingField;        // 0x38
        private UnityEngine.UIElements.IEventHandler <leafTarget>k__BackingField;        // 0x40
        private UnityEngine.UIElements.IEventHandler m_Target;        // 0x48
        private readonly System.Collections.Generic.List<UnityEngine.UIElements.IEventHandler> <skipElements>k__BackingField;        // 0x50
        private UnityEngine.UIElements.PropagationPhase <propagationPhase>k__BackingField;        // 0x58
        private UnityEngine.UIElements.IEventHandler m_CurrentTarget;        // 0x60
        private UnityEngine.Event m_ImguiEvent;        // 0x68
        private UnityEngine.Vector2 <originalMousePosition>k__BackingField;        // 0x70

        // Methods
        private System.Int64 RegisterEventType() { }
        private System.Int64 get_eventTypeId() { }
        private System.Int64 get_timestamp() { }
        private System.Void set_timestamp(System.Int64 value) { }
        private System.UInt64 get_eventId() { }
        private System.Void set_eventId(System.UInt64 value) { }
        private System.Void set_triggerEventId(System.UInt64 value) { }
        private System.Void SetTriggerEventId(System.UInt64 id) { }
        private UnityEngine.UIElements.EventBase.EventPropagation get_propagation() { }
        private System.Void set_propagation(UnityEngine.UIElements.EventBase.EventPropagation value) { }
        private UnityEngine.UIElements.PropagationPaths get_path() { }
        private System.Void set_path(UnityEngine.UIElements.PropagationPaths value) { }
        private UnityEngine.UIElements.EventBase.LifeCycleStatus get_lifeCycleStatus() { }
        private System.Void set_lifeCycleStatus(UnityEngine.UIElements.EventBase.LifeCycleStatus value) { }
        private System.Void PreDispatch() { }
        private System.Void PreDispatch(UnityEngine.UIElements.IPanel panel) { }
        private System.Void PostDispatch() { }
        private System.Void PostDispatch(UnityEngine.UIElements.IPanel panel) { }
        private System.Boolean get_bubbles() { }
        private System.Boolean get_tricklesDown() { }
        private System.Boolean get_skipDisabledElements() { }
        private System.Void set_skipDisabledElements(System.Boolean value) { }
        private System.Boolean get_ignoreCompositeRoots() { }
        private System.Void set_ignoreCompositeRoots(System.Boolean value) { }
        private UnityEngine.UIElements.IEventHandler get_leafTarget() { }
        private System.Void set_leafTarget(UnityEngine.UIElements.IEventHandler value) { }
        private UnityEngine.UIElements.IEventHandler get_target() { }
        private System.Void set_target(UnityEngine.UIElements.IEventHandler value) { }
        private System.Collections.Generic.List<UnityEngine.UIElements.IEventHandler> get_skipElements() { }
        private System.Boolean Skip(UnityEngine.UIElements.IEventHandler h) { }
        private System.Boolean get_isPropagationStopped() { }
        private System.Void set_isPropagationStopped(System.Boolean value) { }
        private System.Void StopPropagation() { }
        private System.Boolean get_isImmediatePropagationStopped() { }
        private System.Void set_isImmediatePropagationStopped(System.Boolean value) { }
        private System.Void StopImmediatePropagation() { }
        private System.Boolean get_isDefaultPrevented() { }
        private System.Void set_isDefaultPrevented(System.Boolean value) { }
        private System.Void PreventDefault() { }
        private UnityEngine.UIElements.PropagationPhase get_propagationPhase() { }
        private System.Void set_propagationPhase(UnityEngine.UIElements.PropagationPhase value) { }
        private UnityEngine.UIElements.IEventHandler get_currentTarget() { }
        private System.Void set_currentTarget(UnityEngine.UIElements.IEventHandler value) { }
        private System.Boolean get_dispatch() { }
        private System.Void set_dispatch(System.Boolean value) { }
        private System.Void MarkReceivedByDispatcher() { }
        private System.Boolean get_dispatched() { }
        private System.Void set_dispatched(System.Boolean value) { }
        private System.Boolean get_processed() { }
        private System.Void set_processed(System.Boolean value) { }
        private System.Boolean get_processedByFocusController() { }
        private System.Void set_processedByFocusController(System.Boolean value) { }
        private System.Boolean get_stopDispatch() { }
        private System.Void set_stopDispatch(System.Boolean value) { }
        private System.Boolean get_propagateToIMGUI() { }
        private System.Void set_propagateToIMGUI(System.Boolean value) { }
        private System.Boolean get_imguiEventIsValid() { }
        private System.Void set_imguiEventIsValid(System.Boolean value) { }
        private UnityEngine.Event get_imguiEvent() { }
        private System.Void set_imguiEvent(UnityEngine.Event value) { }
        private UnityEngine.Vector2 get_originalMousePosition() { }
        private System.Void set_originalMousePosition(UnityEngine.Vector2 value) { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }
        private System.Boolean get_pooled() { }
        private System.Void set_pooled(System.Boolean value) { }
        private System.Void Acquire() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20001CA
    public class EventBase`1 : EventBase
    {
        // Fields
        private static readonly System.Int64 s_TypeId;        // 0x0
        private static readonly UnityEngine.UIElements.ObjectPool<T> s_Pool;        // 0x0
        private System.Int32 m_RefCount;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Int64 TypeId() { }
        private System.Void Init() { }
        private T GetPooled() { }
        private T GetPooled(UnityEngine.UIElements.EventBase e) { }
        private System.Void ReleasePooled(T evt) { }
        private System.Void Acquire() { }
        private System.Void Dispose() { }
        private System.Int64 get_eventTypeId() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001CB
    public class EventCallback`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(TEventType evt) { }

    }

    // TypeToken: 0x20001CC
    public class EventCallbackFunctorBase
    {
        // Fields
        private readonly UnityEngine.UIElements.CallbackPhase <phase>k__BackingField;        // 0x10
        private readonly UnityEngine.UIElements.InvokePolicy <invokePolicy>k__BackingField;        // 0x14

        // Methods
        private UnityEngine.UIElements.CallbackPhase get_phase() { }
        private UnityEngine.UIElements.InvokePolicy get_invokePolicy() { }
        private System.Void .ctor(UnityEngine.UIElements.CallbackPhase phase, UnityEngine.UIElements.InvokePolicy invokePolicy) { }
        private System.Void Invoke(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPhase propagationPhase) { }
        private System.Boolean IsEquivalentTo(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase) { }
        private System.Boolean PhaseMatches(UnityEngine.UIElements.PropagationPhase propagationPhase) { }

    }

    // TypeToken: 0x20001CD
    public class EventCallbackFunctor`1 : EventCallbackFunctorBase
    {
        // Fields
        private readonly UnityEngine.UIElements.EventCallback<TEventType> m_Callback;        // 0x0
        private readonly System.Int64 m_EventTypeId;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.CallbackPhase phase, UnityEngine.UIElements.InvokePolicy invokePolicy) { }
        private System.Void Invoke(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPhase propagationPhase) { }
        private System.Boolean IsEquivalentTo(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase) { }

    }

    // TypeToken: 0x20001CE
    public struct TrickleDown
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.TrickleDown NoTrickleDown;        // 0x0
        public static UnityEngine.UIElements.TrickleDown TrickleDown;        // 0x0

    }

    // TypeToken: 0x20001CF
    public struct CallbackPhase
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.CallbackPhase TargetAndBubbleUp;        // 0x0
        public static UnityEngine.UIElements.CallbackPhase TrickleDownAndTarget;        // 0x0

    }

    // TypeToken: 0x20001D0
    public struct InvokePolicy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.InvokePolicy Default;        // 0x0
        public static UnityEngine.UIElements.InvokePolicy IncludeDisabled;        // 0x0

    }

    // TypeToken: 0x20001D1
    public class EventCallbackListPool
    {
        // Fields
        private readonly System.Collections.Generic.Stack<UnityEngine.UIElements.EventCallbackList> m_Stack;        // 0x10

        // Methods
        private UnityEngine.UIElements.EventCallbackList Get(UnityEngine.UIElements.EventCallbackList initializer) { }
        private System.Void Release(UnityEngine.UIElements.EventCallbackList element) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D2
    public class EventCallbackList
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.EventCallbackFunctorBase> m_List;        // 0x10
        private System.Int32 <trickleDownCallbackCount>k__BackingField;        // 0x18
        private System.Int32 <bubbleUpCallbackCount>k__BackingField;        // 0x1C

        // Methods
        private System.Int32 get_trickleDownCallbackCount() { }
        private System.Void set_trickleDownCallbackCount(System.Int32 value) { }
        private System.Int32 get_bubbleUpCallbackCount() { }
        private System.Void set_bubbleUpCallbackCount(System.Int32 value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.UIElements.EventCallbackList source) { }
        private System.Boolean Contains(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase) { }
        private UnityEngine.UIElements.EventCallbackFunctorBase Find(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase) { }
        private System.Boolean Remove(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase) { }
        private System.Void Add(UnityEngine.UIElements.EventCallbackFunctorBase item) { }
        private System.Void AddRange(UnityEngine.UIElements.EventCallbackList list) { }
        private System.Int32 get_Count() { }
        private UnityEngine.UIElements.EventCallbackFunctorBase get_Item(System.Int32 i) { }
        private System.Void Clear() { }

    }

    // TypeToken: 0x20001D3
    public class EventCallbackRegistry
    {
        // Fields
        private static readonly UnityEngine.UIElements.EventCallbackListPool s_ListPool;        // 0x0
        private UnityEngine.UIElements.EventCallbackList m_Callbacks;        // 0x10
        private UnityEngine.UIElements.EventCallbackList m_TemporaryCallbacks;        // 0x18
        private System.Int32 m_IsInvoking;        // 0x20

        // Methods
        private UnityEngine.UIElements.EventCallbackList GetCallbackList(UnityEngine.UIElements.EventCallbackList initializer) { }
        private System.Void ReleaseCallbackList(UnityEngine.UIElements.EventCallbackList toRelease) { }
        private System.Void .ctor() { }
        private UnityEngine.UIElements.EventCallbackList GetCallbackListForWriting() { }
        private UnityEngine.UIElements.EventCallbackList GetCallbackListForReading() { }
        private System.Boolean UnregisterCallback(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.TrickleDown useTrickleDown) { }
        private System.Void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown, UnityEngine.UIElements.InvokePolicy invokePolicy) { }
        private System.Boolean UnregisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown) { }
        private System.Void InvokeCallbacks(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPhase propagationPhase) { }
        private System.Boolean HasTrickleDownHandlers() { }
        private System.Boolean HasBubbleHandlers() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001D4
    public interface IEventHandler
    {
        // Methods
        private System.Void SendEvent(UnityEngine.UIElements.EventBase e) { }
        private System.Void HandleEvent(UnityEngine.UIElements.EventBase evt) { }

    }

    // TypeToken: 0x20001D5
    public class CallbackEventHandler, IEventHandler
    {
        // Fields
        private System.Boolean isIMGUIContainer;        // 0x10
        private UnityEngine.UIElements.EventCallbackRegistry m_CallbackRegistry;        // 0x18

        // Methods
        private System.Void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown) { }
        private System.Void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.InvokePolicy invokePolicy, UnityEngine.UIElements.TrickleDown useTrickleDown) { }
        private System.Void UnregisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown) { }
        private System.Void SendEvent(UnityEngine.UIElements.EventBase e) { }
        private System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.UIElements.DispatchMode dispatchMode) { }
        private System.Void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase evt) { }
        private System.Void HandleEventAtTargetAndDefaultPhase(UnityEngine.UIElements.EventBase evt) { }
        private System.Void HandleEventAtCurrentTargetAndPhase(UnityEngine.UIElements.EventBase evt) { }
        private System.Void UnityEngine.UIElements.IEventHandler.HandleEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Void HandleEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Boolean HasTrickleDownHandlers() { }
        private System.Boolean HasBubbleUpHandlers() { }
        private System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt) { }
        private System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt) { }
        private System.Void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase evt) { }
        private System.Void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase evt) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D6
    public class FocusEventBase`1 : EventBase`1
    {
        // Fields
        private UnityEngine.UIElements.Focusable <relatedTarget>k__BackingField;        // 0x0
        private UnityEngine.UIElements.FocusChangeDirection <direction>k__BackingField;        // 0x0
        private UnityEngine.UIElements.FocusController <focusController>k__BackingField;        // 0x0
        private System.Boolean <IsFocusDelegated>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.UIElements.Focusable get_relatedTarget() { }
        private System.Void set_relatedTarget(UnityEngine.UIElements.Focusable value) { }
        private UnityEngine.UIElements.FocusChangeDirection get_direction() { }
        private System.Void set_direction(UnityEngine.UIElements.FocusChangeDirection value) { }
        private UnityEngine.UIElements.FocusController get_focusController() { }
        private System.Void set_focusController(UnityEngine.UIElements.FocusController value) { }
        private System.Boolean get_IsFocusDelegated() { }
        private System.Void set_IsFocusDelegated(System.Boolean value) { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private T GetPooled(UnityEngine.UIElements.IEventHandler target, UnityEngine.UIElements.Focusable relatedTarget, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.FocusController focusController, System.Boolean bIsFocusDelegated) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D7
    public class FocusOutEvent : FocusEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D8
    public class BlurEvent : FocusEventBase`1
    {
        // Methods
        private System.Void PreDispatch(UnityEngine.UIElements.IPanel panel) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D9
    public class FocusInEvent : FocusEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001DA
    public class FocusEvent : FocusEventBase`1
    {
        // Methods
        private System.Void PreDispatch(UnityEngine.UIElements.IPanel panel) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001DB
    public struct PropagationPhase
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.PropagationPhase None;        // 0x0
        public static UnityEngine.UIElements.PropagationPhase TrickleDown;        // 0x0
        public static UnityEngine.UIElements.PropagationPhase AtTarget;        // 0x0
        public static UnityEngine.UIElements.PropagationPhase DefaultActionAtTarget;        // 0x0
        public static UnityEngine.UIElements.PropagationPhase BubbleUp;        // 0x0
        public static UnityEngine.UIElements.PropagationPhase DefaultAction;        // 0x0

    }

    // TypeToken: 0x20001DC
    public interface IEventDispatchingStrategy
    {
        // Methods
        private System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel) { }

    }

    // TypeToken: 0x20001DD
    public class EventDispatchUtilities
    {
        // Methods
        private System.Void PropagateEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Void PropagateToIMGUIContainer(UnityEngine.UIElements.VisualElement root, UnityEngine.UIElements.EventBase evt) { }
        private System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel) { }

    }

    // TypeToken: 0x20001DE
    public class IMGUIEventDispatchingStrategy, IEventDispatchingStrategy
    {
        // Methods
        private System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001DF
    public class InputEvent : EventBase`1
    {
        // Fields
        private System.String <previousData>k__BackingField;        // 0x80
        private System.String <newData>k__BackingField;        // 0x88

        // Methods
        private System.Void set_previousData(System.String value) { }
        private System.Void set_newData(System.String value) { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private UnityEngine.UIElements.InputEvent GetPooled(System.String previousData, System.String newData) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E0
    public class KeyboardEventDispatchingStrategy, IEventDispatchingStrategy
    {
        // Methods
        private System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E1
    public interface IKeyboardEvent
    {
        // Methods
        private UnityEngine.EventModifiers get_modifiers() { }
        private System.Char get_character() { }
        private UnityEngine.KeyCode get_keyCode() { }

    }

    // TypeToken: 0x20001E2
    public class KeyboardEventBase`1 : EventBase`1, IKeyboardEvent
    {
        // Fields
        private UnityEngine.EventModifiers <modifiers>k__BackingField;        // 0x0
        private System.Char <character>k__BackingField;        // 0x0
        private UnityEngine.KeyCode <keyCode>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.EventModifiers get_modifiers() { }
        private System.Void set_modifiers(UnityEngine.EventModifiers value) { }
        private System.Char get_character() { }
        private System.Void set_character(System.Char value) { }
        private UnityEngine.KeyCode get_keyCode() { }
        private System.Void set_keyCode(UnityEngine.KeyCode value) { }
        private System.Boolean get_shiftKey() { }
        private System.Boolean get_ctrlKey() { }
        private System.Boolean get_commandKey() { }
        private System.Boolean get_altKey() { }
        private System.Boolean get_actionKey() { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private T GetPooled(System.Char c, UnityEngine.KeyCode keyCode, UnityEngine.EventModifiers modifiers) { }
        private T GetPooled(UnityEngine.Event systemEvent) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E3
    public class KeyDownEvent : KeyboardEventBase`1
    {
        // Methods
        private System.Void GetEquivalentImguiEvent(UnityEngine.Event outImguiEvent) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E4
    public class KeyUpEvent : KeyboardEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E5
    public class GeometryChangedEvent : EventBase`1
    {
        // Fields
        private UnityEngine.Rect <oldRect>k__BackingField;        // 0x80
        private UnityEngine.Rect <newRect>k__BackingField;        // 0x90
        private System.Int32 <layoutPass>k__BackingField;        // 0xA0

        // Methods
        private UnityEngine.UIElements.GeometryChangedEvent GetPooled(UnityEngine.Rect oldRect, UnityEngine.Rect newRect) { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private UnityEngine.Rect get_oldRect() { }
        private System.Void set_oldRect(UnityEngine.Rect value) { }
        private UnityEngine.Rect get_newRect() { }
        private System.Void set_newRect(UnityEngine.Rect value) { }
        private System.Int32 get_layoutPass() { }
        private System.Void set_layoutPass(System.Int32 value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E6
    public class MouseCaptureDispatchingStrategy, IEventDispatchingStrategy
    {
        // Methods
        private System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E8
    public class MouseEventDispatchingStrategy, IEventDispatchingStrategy
    {
        // Methods
        private System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel iPanel) { }
        private System.Boolean SendEventToTarget(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel) { }
        private System.Boolean SendEventToRegularTarget(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel) { }
        private System.Boolean SendEventToIMGUIContainer(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel) { }
        private System.Void SetBestTargetForEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel) { }
        private System.Void UpdateElementUnderMouse(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel, UnityEngine.UIElements.VisualElement& elementUnderMouse) { }
        private System.Boolean IsDone(UnityEngine.UIElements.EventBase evt) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E9
    public interface IMouseEvent
    {
        // Methods
        private UnityEngine.EventModifiers get_modifiers() { }
        private UnityEngine.Vector2 get_mousePosition() { }
        private UnityEngine.Vector2 get_localMousePosition() { }
        private UnityEngine.Vector2 get_mouseDelta() { }
        private System.Int32 get_clickCount() { }
        private System.Int32 get_button() { }
        private System.Int32 get_pressedButtons() { }
        private System.Boolean get_shiftKey() { }
        private System.Boolean get_ctrlKey() { }
        private System.Boolean get_commandKey() { }
        private System.Boolean get_altKey() { }

    }

    // TypeToken: 0x20001EA
    public interface IMouseEventInternal
    {
        // Methods
        private System.Boolean get_triggeredByOS() { }
        private System.Void set_triggeredByOS(System.Boolean value) { }
        private System.Boolean get_recomputeTopElementUnderMouse() { }
        private System.Void set_recomputeTopElementUnderMouse(System.Boolean value) { }
        private UnityEngine.UIElements.IPointerEvent get_sourcePointerEvent() { }
        private System.Void set_sourcePointerEvent(UnityEngine.UIElements.IPointerEvent value) { }

    }

    // TypeToken: 0x20001EB
    public class MouseEventBase`1 : EventBase`1, IMouseEvent, IMouseEventInternal
    {
        // Fields
        private UnityEngine.EventModifiers <modifiers>k__BackingField;        // 0x0
        private UnityEngine.Vector2 <mousePosition>k__BackingField;        // 0x0
        private UnityEngine.Vector2 <localMousePosition>k__BackingField;        // 0x0
        private UnityEngine.Vector2 <mouseDelta>k__BackingField;        // 0x0
        private System.Int32 <clickCount>k__BackingField;        // 0x0
        private System.Int32 <button>k__BackingField;        // 0x0
        private System.Int32 <pressedButtons>k__BackingField;        // 0x0
        private System.Boolean <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField;        // 0x0
        private System.Boolean <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField;        // 0x0
        private UnityEngine.UIElements.IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.EventModifiers get_modifiers() { }
        private System.Void set_modifiers(UnityEngine.EventModifiers value) { }
        private UnityEngine.Vector2 get_mousePosition() { }
        private System.Void set_mousePosition(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_localMousePosition() { }
        private System.Void set_localMousePosition(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_mouseDelta() { }
        private System.Void set_mouseDelta(UnityEngine.Vector2 value) { }
        private System.Int32 get_clickCount() { }
        private System.Void set_clickCount(System.Int32 value) { }
        private System.Int32 get_button() { }
        private System.Void set_button(System.Int32 value) { }
        private System.Int32 get_pressedButtons() { }
        private System.Void set_pressedButtons(System.Int32 value) { }
        private System.Boolean get_shiftKey() { }
        private System.Boolean get_ctrlKey() { }
        private System.Boolean get_commandKey() { }
        private System.Boolean get_altKey() { }
        private System.Boolean UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS() { }
        private System.Void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(System.Boolean value) { }
        private System.Boolean UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse() { }
        private System.Void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(System.Boolean value) { }
        private UnityEngine.UIElements.IPointerEvent UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent() { }
        private System.Void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(UnityEngine.UIElements.IPointerEvent value) { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private UnityEngine.UIElements.IEventHandler get_currentTarget() { }
        private System.Void set_currentTarget(UnityEngine.UIElements.IEventHandler value) { }
        private System.Void PreDispatch(UnityEngine.UIElements.IPanel panel) { }
        private System.Void PostDispatch(UnityEngine.UIElements.IPanel panel) { }
        private T GetPooled(UnityEngine.Event systemEvent) { }
        private T GetPooled(UnityEngine.UIElements.IMouseEvent triggerEvent, UnityEngine.Vector2 mousePosition, System.Boolean recomputeTopElementUnderMouse) { }
        private T GetPooled(UnityEngine.UIElements.IMouseEvent triggerEvent) { }
        private T GetPooled(UnityEngine.UIElements.IPointerEvent pointerEvent) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001EC
    public class MouseDownEvent : MouseEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }
        private UnityEngine.UIElements.MouseDownEvent MakeFromPointerEvent(UnityEngine.UIElements.IPointerEvent pointerEvent) { }
        private UnityEngine.UIElements.MouseDownEvent GetPooled(UnityEngine.UIElements.PointerDownEvent pointerEvent) { }
        private UnityEngine.UIElements.MouseDownEvent GetPooled(UnityEngine.UIElements.PointerMoveEvent pointerEvent) { }

    }

    // TypeToken: 0x20001ED
    public class MouseUpEvent : MouseEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }
        private UnityEngine.UIElements.MouseUpEvent MakeFromPointerEvent(UnityEngine.UIElements.IPointerEvent pointerEvent) { }
        private UnityEngine.UIElements.MouseUpEvent GetPooled(UnityEngine.UIElements.PointerUpEvent pointerEvent) { }
        private UnityEngine.UIElements.MouseUpEvent GetPooled(UnityEngine.UIElements.PointerMoveEvent pointerEvent) { }
        private UnityEngine.UIElements.MouseUpEvent GetPooled(UnityEngine.UIElements.PointerCancelEvent pointerEvent) { }

    }

    // TypeToken: 0x20001EE
    public class MouseMoveEvent : MouseEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }
        private UnityEngine.UIElements.MouseMoveEvent GetPooled(UnityEngine.UIElements.PointerMoveEvent pointerEvent) { }

    }

    // TypeToken: 0x20001EF
    public class ContextClickEvent : MouseEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F0
    public class WheelEvent : MouseEventBase`1
    {
        // Fields
        private UnityEngine.Vector3 <delta>k__BackingField;        // 0xB8

        // Methods
        private UnityEngine.Vector3 get_delta() { }
        private System.Void set_delta(UnityEngine.Vector3 value) { }
        private UnityEngine.UIElements.WheelEvent GetPooled(UnityEngine.Event systemEvent) { }
        private UnityEngine.UIElements.WheelEvent GetPooled(UnityEngine.Vector3 delta, UnityEngine.UIElements.IPointerEvent pointerEvent) { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F1
    public class MouseEnterEvent : MouseEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F2
    public class MouseLeaveEvent : MouseEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F3
    public class MouseEnterWindowEvent : MouseEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }
        private System.Void PostDispatch(UnityEngine.UIElements.IPanel panel) { }

    }

    // TypeToken: 0x20001F4
    public class MouseLeaveWindowEvent : MouseEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }
        private UnityEngine.UIElements.MouseLeaveWindowEvent GetPooled(UnityEngine.Event systemEvent) { }
        private System.Void PostDispatch(UnityEngine.UIElements.IPanel panel) { }

    }

    // TypeToken: 0x20001F5
    public class MouseOverEvent : MouseEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F6
    public class MouseOutEvent : MouseEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F7
    public class ContextualMenuPopulateEvent : MouseEventBase`1
    {
        // Fields
        private UnityEngine.UIElements.DropdownMenu <menu>k__BackingField;        // 0xB8
        private UnityEngine.UIElements.EventBase <triggerEvent>k__BackingField;        // 0xC0
        private UnityEngine.UIElements.ContextualMenuManager m_ContextualMenuManager;        // 0xC8

        // Methods
        private UnityEngine.UIElements.DropdownMenu get_menu() { }
        private System.Void set_menu(UnityEngine.UIElements.DropdownMenu value) { }
        private UnityEngine.UIElements.EventBase get_triggerEvent() { }
        private System.Void set_triggerEvent(UnityEngine.UIElements.EventBase value) { }
        private UnityEngine.UIElements.ContextualMenuPopulateEvent GetPooled(UnityEngine.UIElements.EventBase triggerEvent, UnityEngine.UIElements.DropdownMenu menu, UnityEngine.UIElements.IEventHandler target, UnityEngine.UIElements.ContextualMenuManager menuManager) { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }
        private System.Void PostDispatch(UnityEngine.UIElements.IPanel panel) { }

    }

    // TypeToken: 0x20001F8
    public class MouseEventsHelper
    {
        // Methods
        private System.Void SendEnterLeave(UnityEngine.UIElements.VisualElement previousTopElementUnderMouse, UnityEngine.UIElements.VisualElement currentTopElementUnderMouse, UnityEngine.UIElements.IMouseEvent triggerEvent, UnityEngine.Vector2 mousePosition) { }
        private System.Void SendMouseOverMouseOut(UnityEngine.UIElements.VisualElement previousTopElementUnderMouse, UnityEngine.UIElements.VisualElement currentTopElementUnderMouse, UnityEngine.UIElements.IMouseEvent triggerEvent, UnityEngine.Vector2 mousePosition) { }

    }

    // TypeToken: 0x20001F9
    public class PointerEventsHelper
    {
        // Methods
        private System.Void SendEnterLeave(UnityEngine.UIElements.VisualElement previousTopElementUnderPointer, UnityEngine.UIElements.VisualElement currentTopElementUnderPointer, UnityEngine.UIElements.IPointerEvent triggerEvent, UnityEngine.Vector2 position, System.Int32 pointerId) { }
        private System.Void SendOverOut(UnityEngine.UIElements.VisualElement previousTopElementUnderPointer, UnityEngine.UIElements.VisualElement currentTopElementUnderPointer, UnityEngine.UIElements.IPointerEvent triggerEvent, UnityEngine.Vector2 position, System.Int32 pointerId) { }

    }

    // TypeToken: 0x20001FA
    public class NavigationEventDispatchingStrategy, IEventDispatchingStrategy
    {
        // Methods
        private System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001FB
    public interface INavigationEvent
    {
        // Methods
        private System.Boolean get_shiftKey() { }
        private System.Boolean get_altKey() { }

    }

    // TypeToken: 0x20001FC
    public struct NavigationDeviceType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.NavigationDeviceType Unknown;        // 0x0
        public static UnityEngine.UIElements.NavigationDeviceType Keyboard;        // 0x0
        public static UnityEngine.UIElements.NavigationDeviceType NonKeyboard;        // 0x0

    }

    // TypeToken: 0x20001FD
    public class NavigationEventBase`1 : EventBase`1, INavigationEvent
    {
        // Fields
        private UnityEngine.EventModifiers <modifiers>k__BackingField;        // 0x0
        private UnityEngine.UIElements.NavigationDeviceType <deviceType>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.EventModifiers get_modifiers() { }
        private System.Void set_modifiers(UnityEngine.EventModifiers value) { }
        private System.Boolean get_shiftKey() { }
        private System.Boolean get_altKey() { }
        private System.Void set_deviceType(UnityEngine.UIElements.NavigationDeviceType value) { }
        private System.Void .ctor() { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private T GetPooled(UnityEngine.EventModifiers modifiers) { }
        private T GetPooled(UnityEngine.UIElements.NavigationDeviceType deviceType, UnityEngine.EventModifiers modifiers) { }

    }

    // TypeToken: 0x20001FE
    public class NavigationMoveEvent : NavigationEventBase`1
    {
        // Fields
        private UnityEngine.UIElements.NavigationMoveEvent.Direction <direction>k__BackingField;        // 0x88
        private UnityEngine.Vector2 <move>k__BackingField;        // 0x8C

        // Methods
        private UnityEngine.UIElements.NavigationMoveEvent.Direction DetermineMoveDirection(System.Single x, System.Single y, System.Single deadZone) { }
        private UnityEngine.UIElements.NavigationMoveEvent.Direction get_direction() { }
        private System.Void set_direction(UnityEngine.UIElements.NavigationMoveEvent.Direction value) { }
        private System.Void set_move(UnityEngine.Vector2 value) { }
        private UnityEngine.UIElements.NavigationMoveEvent GetPooled(UnityEngine.Vector2 moveVector, UnityEngine.EventModifiers modifiers) { }
        private System.Void Init() { }
        private System.Void .ctor() { }
        private System.Void LocalInit() { }

    }

    // TypeToken: 0x2000200
    public class NavigationTabEvent : NavigationEventBase`1
    {
        // Fields
        private UnityEngine.UIElements.NavigationTabEvent.Direction <direction>k__BackingField;        // 0x88

        // Methods
        private System.Void set_direction(UnityEngine.UIElements.NavigationTabEvent.Direction value) { }
        private UnityEngine.UIElements.NavigationTabEvent.Direction DetermineMoveDirection(System.Int32 moveValue) { }
        private UnityEngine.UIElements.NavigationTabEvent GetPooled(System.Int32 moveValue) { }
        private System.Void Init() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000202
    public class NavigationCancelEvent : NavigationEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000203
    public class NavigationSubmitEvent : NavigationEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000204
    public class PanelChangedEventBase`1 : EventBase`1
    {
        // Fields
        private UnityEngine.UIElements.IPanel <originPanel>k__BackingField;        // 0x0
        private UnityEngine.UIElements.IPanel <destinationPanel>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.UIElements.IPanel get_originPanel() { }
        private System.Void set_originPanel(UnityEngine.UIElements.IPanel value) { }
        private UnityEngine.UIElements.IPanel get_destinationPanel() { }
        private System.Void set_destinationPanel(UnityEngine.UIElements.IPanel value) { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private T GetPooled(UnityEngine.UIElements.IPanel originPanel, UnityEngine.UIElements.IPanel destinationPanel) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000205
    public class AttachToPanelEvent : PanelChangedEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000206
    public class DetachFromPanelEvent : PanelChangedEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000207
    public class PointerCaptureDispatchingStrategy, IEventDispatchingStrategy
    {
        // Methods
        private System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000208
    public class PointerDeviceState
    {
        // Fields
        private static UnityEngine.UIElements.PointerDeviceState.PointerLocation[] s_PlayerPointerLocations;        // 0x0
        private static System.Int32[] s_PressedButtons;        // 0x8
        private static readonly UnityEngine.UIElements.IPanel[] s_PlayerPanelWithSoftPointerCapture;        // 0x10

        // Methods
        private System.Void RemovePanelData(UnityEngine.UIElements.IPanel panel) { }
        private System.Void SavePointerPosition(System.Int32 pointerId, UnityEngine.Vector2 position, UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.ContextType contextType) { }
        private System.Void PressButton(System.Int32 pointerId, System.Int32 buttonId) { }
        private System.Void ReleaseButton(System.Int32 pointerId, System.Int32 buttonId) { }
        private System.Void ReleaseAllButtons(System.Int32 pointerId) { }
        private UnityEngine.Vector2 GetPointerPosition(System.Int32 pointerId, UnityEngine.UIElements.ContextType contextType) { }
        private UnityEngine.UIElements.IPanel GetPanel(System.Int32 pointerId, UnityEngine.UIElements.ContextType contextType) { }
        private System.Boolean HasFlagFast(UnityEngine.UIElements.PointerDeviceState.LocationFlag flagSet, UnityEngine.UIElements.PointerDeviceState.LocationFlag flag) { }
        private System.Boolean HasLocationFlag(System.Int32 pointerId, UnityEngine.UIElements.ContextType contextType, UnityEngine.UIElements.PointerDeviceState.LocationFlag flag) { }
        private System.Int32 GetPressedButtons(System.Int32 pointerId) { }
        private System.Boolean HasAdditionalPressedButtons(System.Int32 pointerId, System.Int32 exceptButtonId) { }
        private System.Void SetPlayerPanelWithSoftPointerCapture(System.Int32 pointerId, UnityEngine.UIElements.IPanel panel) { }
        private UnityEngine.UIElements.IPanel GetPlayerPanelWithSoftPointerCapture(System.Int32 pointerId) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200020B
    public class PointerEventDispatchingStrategy, IEventDispatchingStrategy
    {
        // Methods
        private System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt) { }
        private System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel) { }
        private System.Void SendEventToTarget(UnityEngine.UIElements.EventBase evt) { }
        private System.Void SetBestTargetForEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel) { }
        private System.Void UpdateElementUnderPointer(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.VisualElement& elementUnderPointer) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200020C
    public class PointerType
    {
        // Fields
        public static readonly System.String mouse;        // 0x0
        public static readonly System.String touch;        // 0x8
        public static readonly System.String pen;        // 0x10
        public static readonly System.String unknown;        // 0x18

        // Methods
        private System.String GetPointerType(System.Int32 pointerId) { }
        private System.Boolean IsDirectManipulationDevice(System.String pointerType) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200020D
    public class PointerId
    {
        // Fields
        public static readonly System.Int32 maxPointers;        // 0x0
        public static readonly System.Int32 invalidPointerId;        // 0x4
        public static readonly System.Int32 mousePointerId;        // 0x8
        public static readonly System.Int32 touchPointerIdBase;        // 0xC
        public static readonly System.Int32 touchPointerCount;        // 0x10
        public static readonly System.Int32 penPointerIdBase;        // 0x14
        public static readonly System.Int32 penPointerCount;        // 0x18
        private static readonly System.Int32[] hoveringPointers;        // 0x20

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200020E
    public interface IPointerEvent
    {
        // Methods
        private System.Int32 get_pointerId() { }
        private System.String get_pointerType() { }
        private System.Boolean get_isPrimary() { }
        private System.Int32 get_button() { }
        private System.Int32 get_pressedButtons() { }
        private UnityEngine.Vector3 get_position() { }
        private UnityEngine.Vector3 get_localPosition() { }
        private UnityEngine.Vector3 get_deltaPosition() { }
        private System.Single get_deltaTime() { }
        private System.Int32 get_clickCount() { }
        private System.Single get_pressure() { }
        private System.Single get_tangentialPressure() { }
        private System.Single get_altitudeAngle() { }
        private System.Single get_azimuthAngle() { }
        private System.Single get_twist() { }
        private UnityEngine.Vector2 get_radius() { }
        private UnityEngine.Vector2 get_radiusVariance() { }
        private UnityEngine.EventModifiers get_modifiers() { }
        private System.Boolean get_shiftKey() { }
        private System.Boolean get_ctrlKey() { }
        private System.Boolean get_commandKey() { }
        private System.Boolean get_altKey() { }
        private System.Boolean get_actionKey() { }

    }

    // TypeToken: 0x200020F
    public interface IPointerEventInternal
    {
        // Methods
        private System.Boolean get_triggeredByOS() { }
        private System.Void set_triggeredByOS(System.Boolean value) { }
        private System.Boolean get_recomputeTopElementUnderPointer() { }
        private System.Void set_recomputeTopElementUnderPointer(System.Boolean value) { }

    }

    // TypeToken: 0x2000210
    public class PointerEventBase`1 : EventBase`1, IPointerEvent, IPointerEventInternal
    {
        // Fields
        private System.Int32 <pointerId>k__BackingField;        // 0x0
        private System.String <pointerType>k__BackingField;        // 0x0
        private System.Boolean <isPrimary>k__BackingField;        // 0x0
        private System.Int32 <button>k__BackingField;        // 0x0
        private System.Int32 <pressedButtons>k__BackingField;        // 0x0
        private UnityEngine.Vector3 <position>k__BackingField;        // 0x0
        private UnityEngine.Vector3 <localPosition>k__BackingField;        // 0x0
        private UnityEngine.Vector3 <deltaPosition>k__BackingField;        // 0x0
        private System.Single <deltaTime>k__BackingField;        // 0x0
        private System.Int32 <clickCount>k__BackingField;        // 0x0
        private System.Single <pressure>k__BackingField;        // 0x0
        private System.Single <tangentialPressure>k__BackingField;        // 0x0
        private System.Single <altitudeAngle>k__BackingField;        // 0x0
        private System.Single <azimuthAngle>k__BackingField;        // 0x0
        private System.Single <twist>k__BackingField;        // 0x0
        private UnityEngine.Vector2 <radius>k__BackingField;        // 0x0
        private UnityEngine.Vector2 <radiusVariance>k__BackingField;        // 0x0
        private UnityEngine.EventModifiers <modifiers>k__BackingField;        // 0x0
        private System.Boolean <UnityEngine.UIElements.IPointerEventInternal.triggeredByOS>k__BackingField;        // 0x0
        private System.Boolean <UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer>k__BackingField;        // 0x0

        // Methods
        private System.Int32 get_pointerId() { }
        private System.Void set_pointerId(System.Int32 value) { }
        private System.String get_pointerType() { }
        private System.Void set_pointerType(System.String value) { }
        private System.Boolean get_isPrimary() { }
        private System.Void set_isPrimary(System.Boolean value) { }
        private System.Int32 get_button() { }
        private System.Void set_button(System.Int32 value) { }
        private System.Int32 get_pressedButtons() { }
        private System.Void set_pressedButtons(System.Int32 value) { }
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_localPosition() { }
        private System.Void set_localPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_deltaPosition() { }
        private System.Void set_deltaPosition(UnityEngine.Vector3 value) { }
        private System.Single get_deltaTime() { }
        private System.Void set_deltaTime(System.Single value) { }
        private System.Int32 get_clickCount() { }
        private System.Void set_clickCount(System.Int32 value) { }
        private System.Single get_pressure() { }
        private System.Void set_pressure(System.Single value) { }
        private System.Single get_tangentialPressure() { }
        private System.Void set_tangentialPressure(System.Single value) { }
        private System.Single get_altitudeAngle() { }
        private System.Void set_altitudeAngle(System.Single value) { }
        private System.Single get_azimuthAngle() { }
        private System.Void set_azimuthAngle(System.Single value) { }
        private System.Single get_twist() { }
        private System.Void set_twist(System.Single value) { }
        private UnityEngine.Vector2 get_radius() { }
        private System.Void set_radius(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_radiusVariance() { }
        private System.Void set_radiusVariance(UnityEngine.Vector2 value) { }
        private UnityEngine.EventModifiers get_modifiers() { }
        private System.Void set_modifiers(UnityEngine.EventModifiers value) { }
        private System.Boolean get_shiftKey() { }
        private System.Boolean get_ctrlKey() { }
        private System.Boolean get_commandKey() { }
        private System.Boolean get_altKey() { }
        private System.Boolean get_actionKey() { }
        private System.Boolean UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS() { }
        private System.Void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(System.Boolean value) { }
        private System.Boolean UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer() { }
        private System.Void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(System.Boolean value) { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private UnityEngine.UIElements.IEventHandler get_currentTarget() { }
        private System.Void set_currentTarget(UnityEngine.UIElements.IEventHandler value) { }
        private System.Boolean IsMouse(UnityEngine.Event systemEvent) { }
        private T GetPooled(UnityEngine.Event systemEvent) { }
        private T GetPooled(UnityEngine.Touch touch, UnityEngine.EventModifiers modifiers) { }
        private T GetPooled(UnityEngine.UIElements.IPointerEvent triggerEvent, UnityEngine.Vector2 position, System.Int32 pointerId) { }
        private T GetPooled(UnityEngine.UIElements.IPointerEvent triggerEvent) { }
        private System.Void PreDispatch(UnityEngine.UIElements.IPanel panel) { }
        private System.Void PostDispatch(UnityEngine.UIElements.IPanel panel) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000211
    public class PointerDownEvent : PointerEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }
        private System.Void PostDispatch(UnityEngine.UIElements.IPanel panel) { }

    }

    // TypeToken: 0x2000212
    public class PointerMoveEvent : PointerEventBase`1
    {
        // Fields
        private System.Boolean <isHandledByDraggable>k__BackingField;        // 0xF8

        // Methods
        private System.Boolean get_isHandledByDraggable() { }
        private System.Void set_isHandledByDraggable(System.Boolean value) { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }
        private System.Void PostDispatch(UnityEngine.UIElements.IPanel panel) { }

    }

    // TypeToken: 0x2000213
    public class PointerStationaryEvent : PointerEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000214
    public class PointerUpEvent : PointerEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }
        private System.Void PostDispatch(UnityEngine.UIElements.IPanel panel) { }

    }

    // TypeToken: 0x2000215
    public class PointerCancelEvent : PointerEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }
        private System.Void PostDispatch(UnityEngine.UIElements.IPanel panel) { }

    }

    // TypeToken: 0x2000216
    public class ClickEvent : PointerEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }
        private UnityEngine.UIElements.ClickEvent GetPooled(UnityEngine.UIElements.PointerUpEvent pointerEvent, System.Int32 clickCount) { }

    }

    // TypeToken: 0x2000217
    public class PointerEnterEvent : PointerEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000218
    public class PointerLeaveEvent : PointerEventBase`1
    {
        // Methods
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000219
    public class PointerOverEvent : PointerEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021A
    public class PointerOutEvent : PointerEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021B
    public class PropagationPaths
    {
        // Fields
        private static readonly UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.PropagationPaths> s_Pool;        // 0x0
        public readonly System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> trickleDownPath;        // 0x10
        public readonly System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> targetElements;        // 0x18
        public readonly System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> bubbleUpPath;        // 0x20
        private static System.Int32 k_DefaultPropagationDepth;        // 0x0
        private static System.Int32 k_DefaultTargetCount;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.UIElements.PropagationPaths Copy(UnityEngine.UIElements.PropagationPaths paths) { }
        private UnityEngine.UIElements.PropagationPaths Build(UnityEngine.UIElements.VisualElement elem, UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPaths.Type pathTypesRequested) { }
        private System.Void Release() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200021D
    public class CustomStyleResolvedEvent : EventBase`1
    {
        // Methods
        private UnityEngine.UIElements.ICustomStyle get_customStyle() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021E
    public class TooltipEvent : EventBase`1
    {
        // Fields
        private System.String <tooltip>k__BackingField;        // 0x80
        private UnityEngine.Rect <rect>k__BackingField;        // 0x88

        // Methods
        private System.Void set_tooltip(System.String value) { }
        private System.Void set_rect(UnityEngine.Rect value) { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021F
    public struct StylePropertyNameCollection, IEnumerable`1, IEnumerable
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> propertiesList;        // 0x10

        // Methods
        private System.Void .ctor(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> list) { }
        private UnityEngine.UIElements.StylePropertyNameCollection.Enumerator GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StylePropertyName> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000221
    public class TransitionEventBase`1 : EventBase`1
    {
        // Fields
        private readonly UnityEngine.UIElements.StylePropertyNameCollection <stylePropertyNames>k__BackingField;        // 0x0
        private System.Double <elapsedTime>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.UIElements.StylePropertyNameCollection get_stylePropertyNames() { }
        private System.Void set_elapsedTime(System.Double value) { }
        private System.Void .ctor() { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private T GetPooled(UnityEngine.UIElements.StylePropertyName stylePropertyName, System.Double elapsedTime) { }

    }

    // TypeToken: 0x2000222
    public class TransitionRunEvent : TransitionEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000223
    public class TransitionStartEvent : TransitionEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000224
    public class TransitionEndEvent : TransitionEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000225
    public class TransitionCancelEvent : TransitionEventBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000226
    public class IMGUIEvent : EventBase`1
    {
        // Methods
        private UnityEngine.UIElements.IMGUIEvent GetPooled(UnityEngine.Event systemEvent) { }
        private System.Void Init() { }
        private System.Void LocalInit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000227
    public struct EventDebuggerLogCall, IDisposable
    {
        // Methods
        private System.Void .ctor(System.Delegate callback, UnityEngine.UIElements.EventBase evt) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000228
    public struct EventDebuggerLogIMGUICall, IDisposable
    {
        // Methods
        private System.Void .ctor(UnityEngine.UIElements.EventBase evt) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000229
    public struct EventDebuggerLogExecuteDefaultAction, IDisposable
    {
        // Methods
        private System.Void .ctor(UnityEngine.UIElements.EventBase evt) { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200022A
    public class EventDebugger
    {
        // Methods
        private System.Void LogPropagationPaths(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPaths paths) { }

    }

    // TypeToken: 0x200022B
    public struct DynamicAtlasFiltersInternal
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.DynamicAtlasFiltersInternal None;        // 0x0
        public static UnityEngine.UIElements.DynamicAtlasFiltersInternal Readability;        // 0x0
        public static UnityEngine.UIElements.DynamicAtlasFiltersInternal Size;        // 0x0
        public static UnityEngine.UIElements.DynamicAtlasFiltersInternal Format;        // 0x0
        public static UnityEngine.UIElements.DynamicAtlasFiltersInternal ColorSpace;        // 0x0
        public static UnityEngine.UIElements.DynamicAtlasFiltersInternal FilterMode;        // 0x0

    }

    // TypeToken: 0x200022C
    public class DynamicAtlasSettings
    {
        // Fields
        private System.Int32 m_MinAtlasSize;        // 0x10
        private System.Int32 m_MaxAtlasSize;        // 0x14
        private System.Int32 m_MaxSubTextureSize;        // 0x18
        private UnityEngine.UIElements.DynamicAtlasFiltersInternal m_ActiveFilters;        // 0x1C
        private UnityEngine.UIElements.DynamicAtlasCustomFilter m_CustomFilter;        // 0x20

        // Methods
        private System.Int32 get_minAtlasSize() { }
        private System.Void set_minAtlasSize(System.Int32 value) { }
        private System.Int32 get_maxAtlasSize() { }
        private System.Void set_maxAtlasSize(System.Int32 value) { }
        private System.Int32 get_maxSubTextureSize() { }
        private System.Void set_maxSubTextureSize(System.Int32 value) { }
        private UnityEngine.UIElements.DynamicAtlasFilters get_activeFilters() { }
        private System.Void set_activeFilters(UnityEngine.UIElements.DynamicAtlasFilters value) { }
        private UnityEngine.UIElements.DynamicAtlasFilters get_defaultFilters() { }
        private UnityEngine.UIElements.DynamicAtlasCustomFilter get_customFilter() { }
        private System.Void set_customFilter(UnityEngine.UIElements.DynamicAtlasCustomFilter value) { }
        private UnityEngine.UIElements.DynamicAtlasSettings get_defaults() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022D
    public class NavigateFocusRing, IFocusRing
    {
        // Fields
        public static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Left;        // 0x0
        public static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Right;        // 0x8
        public static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Up;        // 0x10
        public static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Down;        // 0x18
        public static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Next;        // 0x20
        public static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirection Previous;        // 0x28
        private readonly UnityEngine.UIElements.VisualElement m_Root;        // 0x10
        private readonly UnityEngine.UIElements.VisualElementFocusRing m_Ring;        // 0x18

        // Methods
        private UnityEngine.UIElements.FocusController get_focusController() { }
        private System.Void .ctor(UnityEngine.UIElements.VisualElement root) { }
        private UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.EventBase e) { }
        private UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.FocusChangeDirection direction) { }
        private UnityEngine.UIElements.Focusable GetNextFocusable2D(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.NavigateFocusRing.ChangeDirection direction) { }
        private System.Boolean IsActive(UnityEngine.UIElements.VisualElement v) { }
        private System.Boolean IsNavigable(UnityEngine.UIElements.Focusable focusable) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000230
    public struct PanelScaleMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.PanelScaleMode ConstantPixelSize;        // 0x0
        public static UnityEngine.UIElements.PanelScaleMode ConstantPhysicalSize;        // 0x0
        public static UnityEngine.UIElements.PanelScaleMode ScaleWithScreenSize;        // 0x0

    }

    // TypeToken: 0x2000231
    public struct PanelScreenMatchMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.PanelScreenMatchMode MatchWidthOrHeight;        // 0x0
        public static UnityEngine.UIElements.PanelScreenMatchMode Shrink;        // 0x0
        public static UnityEngine.UIElements.PanelScreenMatchMode Expand;        // 0x0

    }

    // TypeToken: 0x2000232
    public class PanelSettings : ScriptableObject
    {
        // Fields
        private static System.Int32 k_DefaultSortingOrder;        // 0x0
        private static System.Single k_DefaultScaleValue;        // 0x0
        private static System.String k_DefaultStyleSheetPath;        // 0x0
        private UnityEngine.UIElements.ThemeStyleSheet themeUss;        // 0x18
        private UnityEngine.RenderTexture m_TargetTexture;        // 0x20
        private UnityEngine.UIElements.PanelScaleMode m_ScaleMode;        // 0x28
        private System.Single m_Scale;        // 0x2C
        private static System.Single DefaultDpi;        // 0x0
        private System.Single m_ReferenceDpi;        // 0x30
        private System.Single m_FallbackDpi;        // 0x34
        private UnityEngine.Vector2Int m_ReferenceResolution;        // 0x38
        private UnityEngine.UIElements.PanelScreenMatchMode m_ScreenMatchMode;        // 0x40
        private System.Single m_Match;        // 0x44
        private System.Single m_SortingOrder;        // 0x48
        private System.Int32 m_TargetDisplay;        // 0x4C
        private System.Boolean m_ClearDepthStencil;        // 0x50
        private System.Boolean m_ClearColor;        // 0x51
        private UnityEngine.Color m_ColorClearValue;        // 0x54
        private UnityEngine.UIElements.PanelSettings.RuntimePanelAccess m_PanelAccess;        // 0x68
        private UnityEngine.UIElements.UIDocumentList m_AttachedUIDocumentsList;        // 0x70
        private UnityEngine.UIElements.DynamicAtlasSettings m_DynamicAtlasSettings;        // 0x78
        private UnityEngine.Shader m_AtlasBlitShader;        // 0x80
        private UnityEngine.Shader m_RuntimeShader;        // 0x88
        private UnityEngine.Shader m_RuntimeWorldShader;        // 0x90
        public UnityEngine.UIElements.PanelTextSettings textSettings;        // 0x98
        private UnityEngine.Rect m_TargetRect;        // 0xA0
        private System.Single m_ResolvedScale;        // 0xB0
        private UnityEngine.UIElements.StyleSheet m_OldThemeUss;        // 0xB8
        private System.Int32 m_EmptyPanelCounter;        // 0xC0
        private System.Single <ScreenDPI>k__BackingField;        // 0xC4
        private System.Func<UnityEngine.Vector2,UnityEngine.Vector2> m_AssignedScreenToPanel;        // 0xC8

        // Methods
        private UnityEngine.UIElements.ThemeStyleSheet get_themeStyleSheet() { }
        private System.Void set_themeStyleSheet(UnityEngine.UIElements.ThemeStyleSheet value) { }
        private UnityEngine.RenderTexture get_targetTexture() { }
        private System.Void set_targetTexture(UnityEngine.RenderTexture value) { }
        private UnityEngine.UIElements.PanelScaleMode get_scaleMode() { }
        private System.Void set_scaleMode(UnityEngine.UIElements.PanelScaleMode value) { }
        private System.Single get_scale() { }
        private System.Void set_scale(System.Single value) { }
        private System.Single get_referenceDpi() { }
        private System.Void set_referenceDpi(System.Single value) { }
        private System.Single get_fallbackDpi() { }
        private System.Void set_fallbackDpi(System.Single value) { }
        private UnityEngine.Vector2Int get_referenceResolution() { }
        private System.Void set_referenceResolution(UnityEngine.Vector2Int value) { }
        private UnityEngine.UIElements.PanelScreenMatchMode get_screenMatchMode() { }
        private System.Void set_screenMatchMode(UnityEngine.UIElements.PanelScreenMatchMode value) { }
        private System.Single get_match() { }
        private System.Void set_match(System.Single value) { }
        private System.Single get_sortingOrder() { }
        private System.Void set_sortingOrder(System.Single value) { }
        private System.Void ApplySortingOrder() { }
        private System.Int32 get_targetDisplay() { }
        private System.Void set_targetDisplay(System.Int32 value) { }
        private System.Boolean get_clearDepthStencil() { }
        private System.Void set_clearDepthStencil(System.Boolean value) { }
        private System.Single get_depthClearValue() { }
        private System.Boolean get_clearColor() { }
        private System.Void set_clearColor(System.Boolean value) { }
        private UnityEngine.Color get_colorClearValue() { }
        private System.Void set_colorClearValue(UnityEngine.Color value) { }
        private UnityEngine.UIElements.BaseRuntimePanel get_panel() { }
        private UnityEngine.UIElements.VisualElement get_visualTree() { }
        private UnityEngine.UIElements.DynamicAtlasSettings get_dynamicAtlasSettings() { }
        private System.Void set_dynamicAtlasSettings(UnityEngine.UIElements.DynamicAtlasSettings value) { }
        private System.Void .ctor() { }
        private System.Void Reset() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void DisposePanel() { }
        private System.Single get_ScreenDPI() { }
        private System.Void set_ScreenDPI(System.Single value) { }
        private System.Void UpdateScreenDPI() { }
        private System.Void ApplyThemeStyleSheet(UnityEngine.UIElements.VisualElement root) { }
        private System.Void InitializeShaders() { }
        private System.Void ApplyPanelSettings() { }
        private System.Void SetScreenToPanelSpaceFunction(System.Func<UnityEngine.Vector2,UnityEngine.Vector2> screentoPanelSpaceFunction) { }
        private System.Single ResolveScale(UnityEngine.Rect targetRect, System.Single screenDpi) { }
        private UnityEngine.Rect GetDisplayRect() { }
        private System.Void AttachAndInsertUIDocumentToVisualTree(UnityEngine.UIElements.UIDocument uiDocument) { }
        private System.Void DetachUIDocument(UnityEngine.UIElements.UIDocument uiDocument) { }

    }

    // TypeToken: 0x2000234
    public class RuntimeEventDispatcher
    {
        // Methods
        private UnityEngine.UIElements.EventDispatcher Create() { }

    }

    // TypeToken: 0x2000235
    public class RuntimePanel : BaseRuntimePanel
    {
        // Fields
        private static readonly UnityEngine.UIElements.EventDispatcher s_EventDispatcher;        // 0x0
        private readonly UnityEngine.UIElements.PanelSettings m_PanelSettings;        // 0x1D8

        // Methods
        private UnityEngine.UIElements.PanelSettings get_panelSettings() { }
        private UnityEngine.UIElements.RuntimePanel Create(UnityEngine.ScriptableObject ownerObject) { }
        private System.Void .ctor(UnityEngine.ScriptableObject ownerObject) { }
        private System.Void Update() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000236
    public class UIDocumentList
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.UIDocument> m_AttachedUIDocuments;        // 0x10

        // Methods
        private System.Void RemoveFromListAndFromVisualTree(UnityEngine.UIElements.UIDocument uiDocument) { }
        private System.Void AddToListAndToVisualTree(UnityEngine.UIElements.UIDocument uiDocument, UnityEngine.UIElements.VisualElement visualTree, System.Int32 firstInsertIndex) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000237
    public class UIDocument : MonoBehaviour
    {
        // Fields
        private static System.String k_RootStyleClassName;        // 0x0
        private static System.String k_VisualElementNameSuffix;        // 0x0
        private static System.Int32 k_DefaultSortingOrder;        // 0x0
        private static System.Int32 s_CurrentUIDocumentCounter;        // 0x0
        private readonly System.Int32 m_UIDocumentCreationIndex;        // 0x18
        private UnityEngine.UIElements.PanelSettings m_PanelSettings;        // 0x20
        private UnityEngine.UIElements.PanelSettings m_PreviousPanelSettings;        // 0x28
        private UnityEngine.UIElements.UIDocument m_ParentUI;        // 0x30
        private UnityEngine.UIElements.UIDocumentList m_ChildrenContent;        // 0x38
        private System.Collections.Generic.List<UnityEngine.UIElements.UIDocument> m_ChildrenContentCopy;        // 0x40
        private UnityEngine.UIElements.VisualTreeAsset sourceAsset;        // 0x48
        private UnityEngine.UIElements.VisualElement m_RootVisualElement;        // 0x50
        private System.Int32 m_FirstChildInsertIndex;        // 0x58
        private System.Single m_SortingOrder;        // 0x5C

        // Methods
        private UnityEngine.UIElements.PanelSettings get_panelSettings() { }
        private System.Void set_panelSettings(UnityEngine.UIElements.PanelSettings value) { }
        private UnityEngine.UIElements.UIDocument get_parentUI() { }
        private System.Void set_parentUI(UnityEngine.UIElements.UIDocument value) { }
        private UnityEngine.UIElements.VisualTreeAsset get_visualTreeAsset() { }
        private System.Void set_visualTreeAsset(UnityEngine.UIElements.VisualTreeAsset value) { }
        private UnityEngine.UIElements.VisualElement get_rootVisualElement() { }
        private System.Int32 get_firstChildInserIndex() { }
        private System.Single get_sortingOrder() { }
        private System.Void set_sortingOrder(System.Single value) { }
        private System.Void ApplySortingOrder() { }
        private System.Void .ctor() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void SetupFromHierarchy() { }
        private UnityEngine.UIElements.UIDocument FindUIDocumentParent() { }
        private System.Void Reset() { }
        private System.Void AddChildAndInsertContentToVisualTree(UnityEngine.UIElements.UIDocument child) { }
        private System.Void RemoveChild(UnityEngine.UIElements.UIDocument child) { }
        private System.Void RecreateUI() { }
        private System.Void SetupRootClassList() { }
        private System.Void AddRootVisualElementToTree() { }
        private System.Void RemoveFromHierarchy() { }
        private System.Void OnDisable() { }
        private System.Void OnTransformChildrenChanged() { }
        private System.Void OnTransformParentChanged() { }
        private System.Void ReactToHierarchyChanged() { }

    }

    // TypeToken: 0x2000238
    public class UIRAtlasAllocator, IDisposable
    {
        // Fields
        private readonly System.Int32 <maxAtlasSize>k__BackingField;        // 0x10
        private readonly System.Int32 <maxImageWidth>k__BackingField;        // 0x14
        private readonly System.Int32 <maxImageHeight>k__BackingField;        // 0x18
        private System.Int32 <virtualWidth>k__BackingField;        // 0x1C
        private System.Int32 <virtualHeight>k__BackingField;        // 0x20
        private System.Int32 <physicalWidth>k__BackingField;        // 0x24
        private System.Int32 <physicalHeight>k__BackingField;        // 0x28
        private UnityEngine.UIElements.UIRAtlasAllocator.AreaNode m_FirstUnpartitionedArea;        // 0x30
        private UnityEngine.UIElements.UIRAtlasAllocator.Row[] m_OpenRows;        // 0x38
        private System.Int32 m_1SidePadding;        // 0x40
        private System.Int32 m_2SidePadding;        // 0x44
        private static Unity.Profiling.ProfilerMarker s_MarkerTryAllocate;        // 0x0
        private System.Boolean <disposed>k__BackingField;        // 0x48

        // Methods
        private System.Int32 get_maxAtlasSize() { }
        private System.Int32 get_maxImageWidth() { }
        private System.Int32 get_maxImageHeight() { }
        private System.Int32 get_virtualWidth() { }
        private System.Void set_virtualWidth(System.Int32 value) { }
        private System.Int32 get_virtualHeight() { }
        private System.Void set_virtualHeight(System.Int32 value) { }
        private System.Int32 get_physicalWidth() { }
        private System.Void set_physicalWidth(System.Int32 value) { }
        private System.Int32 get_physicalHeight() { }
        private System.Void set_physicalHeight(System.Int32 value) { }
        private System.Boolean get_disposed() { }
        private System.Void set_disposed(System.Boolean value) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Int32 GetLog2OfNextPower(System.Int32 n) { }
        private System.Void .ctor(System.Int32 initialAtlasSize, System.Int32 maxAtlasSize, System.Int32 sidePadding) { }
        private System.Boolean TryAllocate(System.Int32 width, System.Int32 height, UnityEngine.RectInt& location) { }
        private System.Boolean TryPartitionArea(UnityEngine.UIElements.UIRAtlasAllocator.AreaNode areaNode, System.Int32 rowIndex, System.Int32 rowHeight, System.Int32 minWidth) { }
        private System.Void BuildAreas() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200023B
    public class DynamicAtlasPage, IDisposable
    {
        // Fields
        private UnityEngine.UIElements.TextureId <textureId>k__BackingField;        // 0x10
        private UnityEngine.RenderTexture <atlas>k__BackingField;        // 0x18
        private readonly UnityEngine.RenderTextureFormat <format>k__BackingField;        // 0x20
        private readonly UnityEngine.FilterMode <filterMode>k__BackingField;        // 0x24
        private readonly UnityEngine.Vector2Int <minSize>k__BackingField;        // 0x28
        private readonly UnityEngine.Vector2Int <maxSize>k__BackingField;        // 0x30
        private readonly System.Int32 m_1Padding;        // 0x38
        private readonly System.Int32 m_2Padding;        // 0x3C
        private UnityEngine.UIElements.UIR.Allocator2D m_Allocator;        // 0x40
        private UnityEngine.UIElements.UIR.TextureBlitter m_Blitter;        // 0x48
        private UnityEngine.Vector2Int m_CurrentSize;        // 0x50
        private static System.Int32 s_TextureCounter;        // 0x0
        private System.Boolean <disposed>k__BackingField;        // 0x58

        // Methods
        private UnityEngine.UIElements.TextureId get_textureId() { }
        private System.Void set_textureId(UnityEngine.UIElements.TextureId value) { }
        private UnityEngine.RenderTexture get_atlas() { }
        private System.Void set_atlas(UnityEngine.RenderTexture value) { }
        private UnityEngine.RenderTextureFormat get_format() { }
        private UnityEngine.FilterMode get_filterMode() { }
        private System.Void .ctor(UnityEngine.RenderTextureFormat format, UnityEngine.FilterMode filterMode, UnityEngine.Vector2Int minSize, UnityEngine.Vector2Int maxSize) { }
        private System.Boolean get_disposed() { }
        private System.Void set_disposed(System.Boolean value) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Boolean TryAdd(UnityEngine.Texture2D image, UnityEngine.UIElements.UIR.Allocator2D.Alloc2D& alloc, UnityEngine.RectInt& rect) { }
        private System.Void Update(UnityEngine.Texture2D image, UnityEngine.RectInt rect) { }
        private System.Void Remove(UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc) { }
        private System.Void Commit() { }
        private System.Void UpdateAtlasTexture() { }
        private UnityEngine.RenderTexture CreateAtlasTexture() { }

    }

    // TypeToken: 0x200023C
    public class UIRLayoutUpdater : BaseVisualTreeUpdater
    {
        // Fields
        private static readonly System.String s_Description;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker s_ProfilerMarker;        // 0x8
        private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>> changeEventsList;        // 0x20

        // Methods
        private Unity.Profiling.ProfilerMarker get_profilerMarker() { }
        private System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType) { }
        private System.Void Update() { }
        private System.Void UpdateSubTree(UnityEngine.UIElements.VisualElement ve, System.Boolean isDisplayed, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>> changeEvents) { }
        private System.Void DispatchChangeEvents(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>> changeEvents, System.Int32 currentLayoutPass) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200023D
    public struct Vertex
    {
        // Fields
        public static readonly System.Single nearZ;        // 0x0
        public UnityEngine.Vector3 position;        // 0x10
        public UnityEngine.Color32 tint;        // 0x1C
        public UnityEngine.Vector2 uv;        // 0x20
        private UnityEngine.Color32 xformClipPages;        // 0x28
        private UnityEngine.Color32 ids;        // 0x2C
        private UnityEngine.Color32 flags;        // 0x30
        private UnityEngine.Color32 opacityColorPages;        // 0x34
        private UnityEngine.Vector4 circle;        // 0x38
        private System.Single textureId;        // 0x48

    }

    // TypeToken: 0x200023E
    public class MeshWriteData
    {
        // Fields
        private Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> m_Vertices;        // 0x10
        private Unity.Collections.NativeSlice<System.UInt16> m_Indices;        // 0x20
        private UnityEngine.Rect m_UVRegion;        // 0x30
        private System.Int32 currentIndex;        // 0x40
        private System.Int32 currentVertex;        // 0x44

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_vertexCount() { }
        private System.Int32 get_indexCount() { }
        private UnityEngine.Rect get_uvRegion() { }
        private System.Void SetNextVertex(UnityEngine.UIElements.Vertex vertex) { }
        private System.Void SetNextIndex(System.UInt16 index) { }
        private System.Void SetAllVertices(UnityEngine.UIElements.Vertex[] vertices) { }
        private System.Void SetAllIndices(System.UInt16[] indices) { }
        private System.Void Reset(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices) { }
        private System.Void Reset(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices, UnityEngine.Rect uvRegion) { }

    }

    // TypeToken: 0x200023F
    public struct ColorPage
    {
        // Fields
        public System.Boolean isValid;        // 0x10
        public UnityEngine.Color32 pageAndID;        // 0x14

        // Methods
        private UnityEngine.UIElements.ColorPage Init(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.BMPAlloc alloc) { }

    }

    // TypeToken: 0x2000240
    public class MeshGenerationContextUtils
    {
        // Methods
        private System.Void Rectangle(UnityEngine.UIElements.MeshGenerationContext mgc, UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams) { }
        private System.Void Text(UnityEngine.UIElements.MeshGenerationContext mgc, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint) { }
        private UnityEngine.Vector2 ConvertBorderRadiusPercentToPoints(UnityEngine.Vector2 borderRectSize, UnityEngine.UIElements.Length length) { }
        private System.Void GetVisualElementRadii(UnityEngine.UIElements.VisualElement ve, UnityEngine.Vector2& topLeft, UnityEngine.Vector2& bottomLeft, UnityEngine.Vector2& topRight, UnityEngine.Vector2& bottomRight) { }
        private System.Void AdjustBackgroundSizeForBorders(UnityEngine.UIElements.VisualElement visualElement, UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams& rectParams) { }

    }

    // TypeToken: 0x2000244
    public class MeshGenerationContext
    {
        // Fields
        private UnityEngine.UIElements.IStylePainter painter;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.IStylePainter painter) { }

    }

    // TypeToken: 0x2000246
    public class UIRRepaintUpdater : BaseVisualTreeUpdater
    {
        // Fields
        private UnityEngine.UIElements.BaseVisualElementPanel attachedPanel;        // 0x20
        private UnityEngine.UIElements.UIR.RenderChain renderChain;        // 0x28
        private static readonly System.String s_Description;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker s_ProfilerMarker;        // 0x8
        private System.Boolean <drawStats>k__BackingField;        // 0x30
        private System.Boolean <breakBatches>k__BackingField;        // 0x31
        private System.Boolean <disposed>k__BackingField;        // 0x32

        // Methods
        private System.Void .ctor() { }
        private Unity.Profiling.ProfilerMarker get_profilerMarker() { }
        private System.Boolean get_drawStats() { }
        private System.Boolean get_breakBatches() { }
        private System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType) { }
        private System.Void Update() { }
        private UnityEngine.UIElements.UIR.RenderChain CreateRenderChain() { }
        private System.Void .cctor() { }
        private System.Void OnGraphicsResourcesRecreate(System.Boolean recreate) { }
        private System.Void OnPanelChanged(UnityEngine.UIElements.BaseVisualElementPanel obj) { }
        private System.Void AttachToPanel() { }
        private System.Void DetachFromPanel() { }
        private System.Void InitRenderChain() { }
        private System.Void DestroyRenderChain() { }
        private System.Void OnPanelAtlasChanged() { }
        private System.Void OnPanelHierarchyChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType changeType) { }
        private System.Void OnPanelStandardShaderChanged() { }
        private System.Void OnPanelStandardWorldSpaceShaderChanged() { }
        private System.Void ResetAllElementsDataRecursive(UnityEngine.UIElements.VisualElement ve) { }
        private System.Boolean get_disposed() { }
        private System.Void set_disposed(System.Boolean value) { }
        private System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x2000247
    public struct TextureId
    {
        // Fields
        private readonly System.Int32 m_Index;        // 0x10
        public static readonly UnityEngine.UIElements.TextureId invalid;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 index) { }
        private System.Int32 get_index() { }
        private System.Single ConvertToGpu() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.UIElements.TextureId left, UnityEngine.UIElements.TextureId right) { }
        private System.Boolean op_Inequality(UnityEngine.UIElements.TextureId left, UnityEngine.UIElements.TextureId right) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000248
    public class TextureRegistry
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.TextureRegistry.TextureInfo> m_Textures;        // 0x10
        private System.Collections.Generic.Dictionary<UnityEngine.Texture,UnityEngine.UIElements.TextureId> m_TextureToId;        // 0x18
        private System.Collections.Generic.Stack<UnityEngine.UIElements.TextureId> m_FreeIds;        // 0x20
        private static System.Int32 maxTextures;        // 0x0
        private static readonly UnityEngine.UIElements.TextureRegistry <instance>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.UIElements.TextureRegistry get_instance() { }
        private UnityEngine.Texture GetTexture(UnityEngine.UIElements.TextureId id) { }
        private UnityEngine.UIElements.TextureId AllocAndAcquireDynamic() { }
        private System.Void UpdateDynamic(UnityEngine.UIElements.TextureId id, UnityEngine.Texture texture) { }
        private UnityEngine.UIElements.TextureId AllocAndAcquire(UnityEngine.Texture texture, System.Boolean dynamic) { }
        private UnityEngine.UIElements.TextureId Acquire(UnityEngine.Texture tex) { }
        private System.Void Release(UnityEngine.UIElements.TextureId id) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200024A
    public class UIRUtility
    {
        // Fields
        public static readonly System.String k_DefaultShaderName;        // 0x0
        public static readonly System.String k_DefaultWorldSpaceShaderName;        // 0x8

        // Methods
        private System.Boolean ShapeWindingIsClockwise(System.Int32 maskDepth, System.Int32 stencilRef) { }
        private System.Boolean IsRoundRect(UnityEngine.UIElements.VisualElement ve) { }
        private System.Boolean IsVectorImageBackground(UnityEngine.UIElements.VisualElement ve) { }
        private System.Boolean IsElementSelfHidden(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void Destroy(UnityEngine.Object obj) { }
        private System.Int32 GetPrevPow2(System.Int32 n) { }
        private System.Int32 GetNextPow2(System.Int32 n) { }
        private System.Int32 GetNextPow2Exp(System.Int32 n) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200024B
    public struct AngleUnit
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.AngleUnit Degree;        // 0x0
        public static UnityEngine.UIElements.AngleUnit Gradian;        // 0x0
        public static UnityEngine.UIElements.AngleUnit Radian;        // 0x0
        public static UnityEngine.UIElements.AngleUnit Turn;        // 0x0

    }

    // TypeToken: 0x200024C
    public struct Angle, IEquatable`1
    {
        // Fields
        private System.Single m_Value;        // 0x10
        private UnityEngine.UIElements.Angle.Unit m_Unit;        // 0x14

        // Methods
        private UnityEngine.UIElements.Angle None() { }
        private System.Single get_value() { }
        private System.Void .ctor(System.Single value, UnityEngine.UIElements.AngleUnit unit) { }
        private System.Void .ctor(System.Single value, UnityEngine.UIElements.Angle.Unit unit) { }
        private System.Single ToDegrees() { }
        private UnityEngine.UIElements.Angle op_Implicit(System.Single value) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.Angle lhs, UnityEngine.UIElements.Angle rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.Angle other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200024E
    public struct Background, IEquatable`1
    {
        // Fields
        private UnityEngine.Texture2D m_Texture;        // 0x10
        private UnityEngine.Sprite m_Sprite;        // 0x18
        private UnityEngine.RenderTexture m_RenderTexture;        // 0x20
        private UnityEngine.UIElements.VectorImage m_VectorImage;        // 0x28

        // Methods
        private UnityEngine.Texture2D get_texture() { }
        private System.Void set_texture(UnityEngine.Texture2D value) { }
        private UnityEngine.Sprite get_sprite() { }
        private System.Void set_sprite(UnityEngine.Sprite value) { }
        private UnityEngine.RenderTexture get_renderTexture() { }
        private System.Void set_renderTexture(UnityEngine.RenderTexture value) { }
        private UnityEngine.UIElements.VectorImage get_vectorImage() { }
        private System.Void set_vectorImage(UnityEngine.UIElements.VectorImage value) { }
        private UnityEngine.UIElements.Background FromTexture2D(UnityEngine.Texture2D t) { }
        private UnityEngine.UIElements.Background FromRenderTexture(UnityEngine.RenderTexture rt) { }
        private UnityEngine.UIElements.Background FromSprite(UnityEngine.Sprite s) { }
        private UnityEngine.UIElements.Background FromVectorImage(UnityEngine.UIElements.VectorImage vi) { }
        private UnityEngine.UIElements.Background FromObject(System.Object obj) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.Background lhs, UnityEngine.UIElements.Background rhs) { }
        private System.Boolean op_Inequality(UnityEngine.UIElements.Background lhs, UnityEngine.UIElements.Background rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.Background other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200024F
    public struct ComputedStyle
    {
        // Fields
        public UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.InheritedData> inheritedData;        // 0x10
        public UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.LayoutData> layoutData;        // 0x18
        public UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.RareData> rareData;        // 0x20
        public UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.TransformData> transformData;        // 0x28
        public UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.TransitionData> transitionData;        // 0x30
        public UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.VisualData> visualData;        // 0x38
        public UnityEngine.Yoga.YogaNode yogaNode;        // 0x40
        public System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue> customProperties;        // 0x48
        public System.Int64 matchingRulesHash;        // 0x50
        public System.Single dpiScaling;        // 0x58
        public UnityEngine.UIElements.ComputedTransitionProperty[] computedTransitions;        // 0x60

        // Methods
        private System.Int32 get_customPropertiesCount() { }
        private System.Boolean get_hasTransition() { }
        private System.Void FinalizeApply(UnityEngine.UIElements.ComputedStyle& parentStyle) { }
        private System.Void SyncWithLayout(UnityEngine.Yoga.YogaNode targetNode) { }
        private System.Boolean ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& parentStyle) { }
        private System.Boolean ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleKeyword keyword, UnityEngine.UIElements.ComputedStyle& parentStyle) { }
        private System.Void RemoveCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader) { }
        private System.Void ApplyCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader) { }
        private System.Void ApplyAllPropertyInitial() { }
        private System.Void ResetComputedTransitions() { }
        private UnityEngine.UIElements.VersionChangeType CompareChanges(UnityEngine.UIElements.ComputedStyle& x, UnityEngine.UIElements.ComputedStyle& y) { }
        private System.Boolean StartAnimationInlineTranslate(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.ComputedStyle& computedStyle, UnityEngine.UIElements.StyleTranslate translate, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private UnityEngine.UIElements.Align get_alignContent() { }
        private UnityEngine.UIElements.Align get_alignItems() { }
        private UnityEngine.UIElements.Align get_alignSelf() { }
        private UnityEngine.Color get_backgroundColor() { }
        private UnityEngine.UIElements.Background get_backgroundImage() { }
        private UnityEngine.Color get_borderBottomColor() { }
        private UnityEngine.UIElements.Length get_borderBottomLeftRadius() { }
        private UnityEngine.UIElements.Length get_borderBottomRightRadius() { }
        private System.Single get_borderBottomWidth() { }
        private UnityEngine.Color get_borderLeftColor() { }
        private System.Single get_borderLeftWidth() { }
        private UnityEngine.Color get_borderRightColor() { }
        private System.Single get_borderRightWidth() { }
        private UnityEngine.Color get_borderTopColor() { }
        private UnityEngine.UIElements.Length get_borderTopLeftRadius() { }
        private UnityEngine.UIElements.Length get_borderTopRightRadius() { }
        private System.Single get_borderTopWidth() { }
        private UnityEngine.UIElements.Length get_bottom() { }
        private UnityEngine.Color get_color() { }
        private UnityEngine.UIElements.Cursor get_cursor() { }
        private UnityEngine.UIElements.DisplayStyle get_display() { }
        private UnityEngine.UIElements.Length get_flexBasis() { }
        private UnityEngine.UIElements.FlexDirection get_flexDirection() { }
        private System.Single get_flexGrow() { }
        private System.Single get_flexShrink() { }
        private UnityEngine.UIElements.Wrap get_flexWrap() { }
        private UnityEngine.UIElements.Length get_fontSize() { }
        private UnityEngine.UIElements.Length get_height() { }
        private UnityEngine.UIElements.Justify get_justifyContent() { }
        private UnityEngine.UIElements.Length get_left() { }
        private UnityEngine.UIElements.Length get_letterSpacing() { }
        private UnityEngine.UIElements.Length get_marginBottom() { }
        private UnityEngine.UIElements.Length get_marginLeft() { }
        private UnityEngine.UIElements.Length get_marginRight() { }
        private UnityEngine.UIElements.Length get_marginTop() { }
        private UnityEngine.UIElements.Length get_maxHeight() { }
        private UnityEngine.UIElements.Length get_maxWidth() { }
        private UnityEngine.UIElements.Length get_minHeight() { }
        private UnityEngine.UIElements.Length get_minWidth() { }
        private System.Single get_opacity() { }
        private UnityEngine.UIElements.OverflowInternal get_overflow() { }
        private UnityEngine.UIElements.Length get_paddingBottom() { }
        private UnityEngine.UIElements.Length get_paddingLeft() { }
        private UnityEngine.UIElements.Length get_paddingRight() { }
        private UnityEngine.UIElements.Length get_paddingTop() { }
        private UnityEngine.UIElements.Position get_position() { }
        private UnityEngine.UIElements.Length get_right() { }
        private UnityEngine.UIElements.Rotate get_rotate() { }
        private UnityEngine.UIElements.Scale get_scale() { }
        private UnityEngine.UIElements.TextOverflow get_textOverflow() { }
        private UnityEngine.UIElements.TextShadow get_textShadow() { }
        private UnityEngine.UIElements.Length get_top() { }
        private UnityEngine.UIElements.TransformOrigin get_transformOrigin() { }
        private System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDelay() { }
        private System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDuration() { }
        private System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> get_transitionProperty() { }
        private System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> get_transitionTimingFunction() { }
        private UnityEngine.UIElements.Translate get_translate() { }
        private UnityEngine.Color get_unityBackgroundImageTintColor() { }
        private UnityEngine.ScaleMode get_unityBackgroundScaleMode() { }
        private UnityEngine.Font get_unityFont() { }
        private UnityEngine.UIElements.FontDefinition get_unityFontDefinition() { }
        private UnityEngine.FontStyle get_unityFontStyleAndWeight() { }
        private UnityEngine.UIElements.OverflowClipBox get_unityOverflowClipBox() { }
        private UnityEngine.UIElements.Length get_unityParagraphSpacing() { }
        private System.Int32 get_unitySliceBottom() { }
        private System.Int32 get_unitySliceLeft() { }
        private System.Int32 get_unitySliceRight() { }
        private System.Int32 get_unitySliceTop() { }
        private UnityEngine.TextAnchor get_unityTextAlign() { }
        private UnityEngine.Color get_unityTextOutlineColor() { }
        private System.Single get_unityTextOutlineWidth() { }
        private UnityEngine.UIElements.TextOverflowPosition get_unityTextOverflowPosition() { }
        private UnityEngine.UIElements.Visibility get_visibility() { }
        private UnityEngine.UIElements.WhiteSpace get_whiteSpace() { }
        private UnityEngine.UIElements.Length get_width() { }
        private UnityEngine.UIElements.Length get_wordSpacing() { }
        private UnityEngine.UIElements.ComputedStyle Create(UnityEngine.UIElements.ComputedStyle& parentStyle) { }
        private UnityEngine.UIElements.ComputedStyle CreateInitial() { }
        private UnityEngine.UIElements.ComputedStyle Acquire() { }
        private System.Void Release() { }
        private System.Void CopyFrom(UnityEngine.UIElements.ComputedStyle& other) { }
        private System.Void ApplyProperties(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& parentStyle) { }
        private System.Void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue sv, UnityEngine.UIElements.ComputedStyle& parentStyle) { }
        private System.Void ApplyStyleValueManaged(UnityEngine.UIElements.StyleSheets.StyleValueManaged sv, UnityEngine.UIElements.ComputedStyle& parentStyle) { }
        private System.Void ApplyStyleCursor(UnityEngine.UIElements.Cursor cursor) { }
        private System.Void ApplyStyleTextShadow(UnityEngine.UIElements.TextShadow st) { }
        private System.Void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedStyle& other) { }
        private System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length newValue) { }
        private System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Single newValue) { }
        private System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 newValue) { }
        private System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color newValue) { }
        private System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Background newValue) { }
        private System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Font newValue) { }
        private System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.FontDefinition newValue) { }
        private System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TextShadow newValue) { }
        private System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Translate newValue) { }
        private System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TransformOrigin newValue) { }
        private System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Rotate newValue) { }
        private System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Scale newValue) { }
        private System.Boolean StartAnimation(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedStyle& oldStyle, UnityEngine.UIElements.ComputedStyle& newStyle, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartAnimationAllProperty(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.ComputedStyle& oldStyle, UnityEngine.UIElements.ComputedStyle& newStyle, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Boolean StartAnimationInline(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedStyle& computedStyle, UnityEngine.UIElements.StyleSheets.StyleValue sv, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve) { }
        private System.Void ApplyStyleTransformOrigin(UnityEngine.UIElements.TransformOrigin st) { }
        private System.Void ApplyStyleTranslate(UnityEngine.UIElements.Translate translateValue) { }
        private System.Void ApplyStyleRotate(UnityEngine.UIElements.Rotate rotateValue) { }
        private System.Void ApplyStyleScale(UnityEngine.UIElements.Scale scaleValue) { }
        private System.Void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader) { }
        private System.Void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& parentStyle) { }
        private System.Void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedStyle& parentStyle) { }

    }

    // TypeToken: 0x2000250
    public struct ComputedTransitionProperty
    {
        // Fields
        public UnityEngine.UIElements.StyleSheets.StylePropertyId id;        // 0x10
        public System.Int32 durationMs;        // 0x14
        public System.Int32 delayMs;        // 0x18
        public System.Func<System.Single,System.Single> easingCurve;        // 0x20

    }

    // TypeToken: 0x2000251
    public class ComputedTransitionUtils
    {
        // Fields
        private static System.Collections.Generic.List<UnityEngine.UIElements.ComputedTransitionProperty> s_ComputedTransitionsBuffer;        // 0x0

        // Methods
        private System.Void UpdateComputedTransitions(UnityEngine.UIElements.ComputedStyle& computedStyle) { }
        private System.Boolean HasTransitionProperty(UnityEngine.UIElements.ComputedStyle& computedStyle, UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Boolean GetTransitionProperty(UnityEngine.UIElements.ComputedStyle& computedStyle, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedTransitionProperty& result) { }
        private UnityEngine.UIElements.ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(UnityEngine.UIElements.ComputedStyle& computedStyle) { }
        private System.Int32 GetTransitionHashCode(UnityEngine.UIElements.ComputedStyle& cs) { }
        private System.Boolean SameTransitionProperty(UnityEngine.UIElements.ComputedStyle& x, UnityEngine.UIElements.ComputedStyle& y) { }
        private System.Boolean SameTransitionProperty(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> a, System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> b) { }
        private System.Boolean SameTransitionProperty(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> a, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> b) { }
        private System.Void ComputeTransitionPropertyData(UnityEngine.UIElements.ComputedStyle& computedStyle, System.Collections.Generic.List<UnityEngine.UIElements.ComputedTransitionProperty> outData) { }
        private T GetWrappingTransitionData(System.Collections.Generic.List<T> list, System.Int32 i, T defaultValue) { }
        private System.Int32 ConvertTransitionTime(UnityEngine.UIElements.TimeValue time) { }
        private System.Func<System.Single,System.Single> ConvertTransitionFunction(UnityEngine.UIElements.EasingMode mode) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000253
    public struct CustomStyleProperty`1, IEquatable`1
    {
        // Fields
        private System.String <name>k__BackingField;        // 0x0

        // Methods
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Void .ctor(System.String propertyName) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.UIElements.CustomStyleProperty<T> other) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000254
    public interface ICustomStyle
    {
        // Methods
        private System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Single> property, System.Single& value) { }
        private System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Int32> property, System.Int32& value) { }
        private System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> property, UnityEngine.Color& value) { }
        private System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> property, UnityEngine.Texture2D& value) { }
        private System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> property, UnityEngine.Sprite& value) { }
        private System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> property, UnityEngine.UIElements.VectorImage& value) { }
        private System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.String> property, System.String& value) { }

    }

    // TypeToken: 0x2000255
    public struct EasingMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.EasingMode Ease;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseIn;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseOut;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseInOut;        // 0x0
        public static UnityEngine.UIElements.EasingMode Linear;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseInSine;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseOutSine;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseInOutSine;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseInCubic;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseOutCubic;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseInOutCubic;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseInCirc;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseOutCirc;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseInOutCirc;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseInElastic;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseOutElastic;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseInOutElastic;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseInBack;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseOutBack;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseInOutBack;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseInBounce;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseOutBounce;        // 0x0
        public static UnityEngine.UIElements.EasingMode EaseInOutBounce;        // 0x0

    }

    // TypeToken: 0x2000256
    public struct EasingFunction, IEquatable`1
    {
        // Fields
        private UnityEngine.UIElements.EasingMode m_Mode;        // 0x10

        // Methods
        private UnityEngine.UIElements.EasingMode get_mode() { }
        private System.Void .ctor(UnityEngine.UIElements.EasingMode mode) { }
        private UnityEngine.UIElements.EasingFunction op_Implicit(UnityEngine.UIElements.EasingMode easingMode) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.EasingFunction lhs, UnityEngine.UIElements.EasingFunction rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.EasingFunction other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000257
    public struct FontDefinition, IEquatable`1
    {
        // Fields
        private UnityEngine.Font m_Font;        // 0x10
        private UnityEngine.TextCore.Text.FontAsset m_FontAsset;        // 0x18

        // Methods
        private UnityEngine.Font get_font() { }
        private UnityEngine.TextCore.Text.FontAsset get_fontAsset() { }
        private UnityEngine.UIElements.FontDefinition FromFont(UnityEngine.Font f) { }
        private UnityEngine.UIElements.FontDefinition FromSDFFont(UnityEngine.TextCore.Text.FontAsset f) { }
        private UnityEngine.UIElements.FontDefinition FromObject(System.Object obj) { }
        private System.Boolean IsEmpty() { }
        private System.String ToString() { }
        private System.Boolean Equals(UnityEngine.UIElements.FontDefinition other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.UIElements.FontDefinition left, UnityEngine.UIElements.FontDefinition right) { }
        private System.Boolean op_Inequality(UnityEngine.UIElements.FontDefinition left, UnityEngine.UIElements.FontDefinition right) { }

    }

    // TypeToken: 0x2000258
    public class StyleValueCollection
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StyleValue> m_Values;        // 0x10

        // Methods
        private UnityEngine.UIElements.StyleLength GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private UnityEngine.UIElements.StyleFloat GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private UnityEngine.UIElements.StyleInt GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Boolean TryGetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleSheets.StyleValue& value) { }
        private System.Void SetStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000259
    public class InlineStyleAccess : StyleValueCollection, IStyle
    {
        // Fields
        private static UnityEngine.UIElements.StyleSheets.StylePropertyReader s_StylePropertyReader;        // 0x0
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StyleValueManaged> m_ValuesManaged;        // 0x18
        private UnityEngine.UIElements.VisualElement <ve>k__BackingField;        // 0x20
        private System.Boolean m_HasInlineCursor;        // 0x28
        private UnityEngine.UIElements.StyleCursor m_InlineCursor;        // 0x30
        private System.Boolean m_HasInlineTextShadow;        // 0x50
        private UnityEngine.UIElements.StyleTextShadow m_InlineTextShadow;        // 0x54
        private System.Boolean m_HasInlineTransformOrigin;        // 0x74
        private UnityEngine.UIElements.StyleTransformOrigin m_InlineTransformOrigin;        // 0x78
        private System.Boolean m_HasInlineTranslate;        // 0x90
        private UnityEngine.UIElements.StyleTranslate m_InlineTranslateOperation;        // 0x94
        private System.Boolean m_HasInlineRotate;        // 0xB0
        private UnityEngine.UIElements.StyleRotate m_InlineRotateOperation;        // 0xB4
        private System.Boolean m_HasInlineScale;        // 0xD0
        private UnityEngine.UIElements.StyleScale m_InlineScale;        // 0xD4
        private UnityEngine.UIElements.InlineStyleAccess.InlineRule m_InlineRule;        // 0xE8

        // Methods
        private UnityEngine.UIElements.VisualElement get_ve() { }
        private System.Void set_ve(UnityEngine.UIElements.VisualElement value) { }
        private System.Void .ctor(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void Finalize() { }
        private System.Void SetInlineRule(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleRule rule) { }
        private System.Boolean IsValueSet(UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Void ApplyInlineStyles(UnityEngine.UIElements.ComputedStyle& computedStyle) { }
        private UnityEngine.UIElements.StyleCursor UnityEngine.UIElements.IStyle.get_cursor() { }
        private UnityEngine.UIElements.StyleTextShadow UnityEngine.UIElements.IStyle.get_textShadow() { }
        private UnityEngine.UIElements.StyleTransformOrigin UnityEngine.UIElements.IStyle.get_transformOrigin() { }
        private UnityEngine.UIElements.StyleTranslate UnityEngine.UIElements.IStyle.get_translate() { }
        private System.Void UnityEngine.UIElements.IStyle.set_translate(UnityEngine.UIElements.StyleTranslate value) { }
        private UnityEngine.UIElements.StyleRotate UnityEngine.UIElements.IStyle.get_rotate() { }
        private UnityEngine.UIElements.StyleScale UnityEngine.UIElements.IStyle.get_scale() { }
        private System.Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleLength inlineValue) { }
        private System.Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleFloat inlineValue) { }
        private System.Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleColor inlineValue) { }
        private System.Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleEnum<T> inlineValue) { }
        private System.Boolean SetInlineTranslate(UnityEngine.UIElements.StyleTranslate inlineValue) { }
        private System.Void ApplyStyleTranslate(UnityEngine.UIElements.StyleTranslate translate) { }
        private System.Void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue value) { }
        private System.Boolean RemoveInlineStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedStyle& newStyle) { }
        private System.Boolean TryGetInlineCursor(UnityEngine.UIElements.StyleCursor& value) { }
        private System.Boolean TryGetInlineTextShadow(UnityEngine.UIElements.StyleTextShadow& value) { }
        private System.Boolean TryGetInlineTransformOrigin(UnityEngine.UIElements.StyleTransformOrigin& value) { }
        private System.Boolean TryGetInlineTranslate(UnityEngine.UIElements.StyleTranslate& value) { }
        private System.Boolean TryGetInlineRotate(UnityEngine.UIElements.StyleRotate& value) { }
        private System.Boolean TryGetInlineScale(UnityEngine.UIElements.StyleScale& value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_backgroundColor(UnityEngine.UIElements.StyleColor value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_borderBottomColor(UnityEngine.UIElements.StyleColor value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_borderBottomWidth(UnityEngine.UIElements.StyleFloat value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_borderLeftColor(UnityEngine.UIElements.StyleColor value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_borderLeftWidth(UnityEngine.UIElements.StyleFloat value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_borderRightColor(UnityEngine.UIElements.StyleColor value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_borderRightWidth(UnityEngine.UIElements.StyleFloat value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_borderTopColor(UnityEngine.UIElements.StyleColor value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_borderTopWidth(UnityEngine.UIElements.StyleFloat value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_bottom(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_color(UnityEngine.UIElements.StyleColor value) { }
        private UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> UnityEngine.UIElements.IStyle.get_display() { }
        private System.Void UnityEngine.UIElements.IStyle.set_display(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_flexBasis(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_flexDirection(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.FlexDirection> value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_flexGrow(UnityEngine.UIElements.StyleFloat value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_flexShrink(UnityEngine.UIElements.StyleFloat value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_fontSize(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_height(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_left(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_marginBottom(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_marginLeft(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_marginRight(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_marginTop(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_maxHeight(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_maxWidth(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_minWidth(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_opacity(UnityEngine.UIElements.StyleFloat value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_paddingBottom(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_paddingLeft(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_paddingRight(UnityEngine.UIElements.StyleLength value) { }
        private UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.get_paddingTop() { }
        private System.Void UnityEngine.UIElements.IStyle.set_paddingTop(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_position(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Position> value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_right(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_top(UnityEngine.UIElements.StyleLength value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(UnityEngine.UIElements.StyleColor value) { }
        private System.Void UnityEngine.UIElements.IStyle.set_visibility(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Visibility> value) { }
        private UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.get_width() { }
        private System.Void UnityEngine.UIElements.IStyle.set_width(UnityEngine.UIElements.StyleLength value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200025B
    public struct LengthUnit
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.LengthUnit Pixel;        // 0x0
        public static UnityEngine.UIElements.LengthUnit Percent;        // 0x0

    }

    // TypeToken: 0x200025C
    public struct Length, IEquatable`1
    {
        // Fields
        private static System.Single k_MaxValue;        // 0x0
        private System.Single m_Value;        // 0x10
        private UnityEngine.UIElements.Length.Unit m_Unit;        // 0x14

        // Methods
        private UnityEngine.UIElements.Length Percent(System.Single value) { }
        private UnityEngine.UIElements.Length Auto() { }
        private UnityEngine.UIElements.Length None() { }
        private System.Single get_value() { }
        private System.Void set_value(System.Single value) { }
        private UnityEngine.UIElements.LengthUnit get_unit() { }
        private System.Boolean IsAuto() { }
        private System.Boolean IsNone() { }
        private System.Void .ctor(System.Single value) { }
        private System.Void .ctor(System.Single value, UnityEngine.UIElements.LengthUnit unit) { }
        private System.Void .ctor(System.Single value, UnityEngine.UIElements.Length.Unit unit) { }
        private UnityEngine.UIElements.Length op_Implicit(System.Single value) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.Length lhs, UnityEngine.UIElements.Length rhs) { }
        private System.Boolean op_Inequality(UnityEngine.UIElements.Length lhs, UnityEngine.UIElements.Length rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.Length other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200025E
    public struct Rotate, IEquatable`1
    {
        // Fields
        private UnityEngine.UIElements.Angle m_Angle;        // 0x10
        private UnityEngine.Vector3 m_Axis;        // 0x18
        private System.Boolean m_IsNone;        // 0x24

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.Angle angle) { }
        private UnityEngine.UIElements.Rotate Initial() { }
        private UnityEngine.UIElements.Rotate None() { }
        private UnityEngine.UIElements.Angle get_angle() { }
        private System.Void set_angle(UnityEngine.UIElements.Angle value) { }
        private UnityEngine.Vector3 get_axis() { }
        private System.Boolean op_Equality(UnityEngine.UIElements.Rotate lhs, UnityEngine.UIElements.Rotate rhs) { }
        private System.Boolean op_Inequality(UnityEngine.UIElements.Rotate lhs, UnityEngine.UIElements.Rotate rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.Rotate other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private UnityEngine.Quaternion ToQuaternion() { }

    }

    // TypeToken: 0x200025F
    public struct Scale, IEquatable`1
    {
        // Fields
        private UnityEngine.Vector3 m_Scale;        // 0x10
        private System.Boolean m_IsNone;        // 0x1C

        // Methods
        private System.Void .ctor(UnityEngine.Vector3 scale) { }
        private UnityEngine.UIElements.Scale Initial() { }
        private UnityEngine.UIElements.Scale None() { }
        private UnityEngine.Vector3 get_value() { }
        private System.Boolean op_Equality(UnityEngine.UIElements.Scale lhs, UnityEngine.UIElements.Scale rhs) { }
        private System.Boolean op_Inequality(UnityEngine.UIElements.Scale lhs, UnityEngine.UIElements.Scale rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.Scale other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000260
    public struct StyleColor, IStyleValue`1, IEquatable`1
    {
        // Fields
        private UnityEngine.Color m_Value;        // 0x10
        private UnityEngine.UIElements.StyleKeyword m_Keyword;        // 0x20

        // Methods
        private UnityEngine.Color get_value() { }
        private UnityEngine.UIElements.StyleKeyword get_keyword() { }
        private System.Void .ctor(UnityEngine.Color v) { }
        private System.Void .ctor(UnityEngine.Color v, UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.StyleColor lhs, UnityEngine.UIElements.StyleColor rhs) { }
        private UnityEngine.UIElements.StyleColor op_Implicit(UnityEngine.Color v) { }
        private System.Boolean Equals(UnityEngine.UIElements.StyleColor other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000261
    public struct StyleCursor, IStyleValue`1, IEquatable`1
    {
        // Fields
        private UnityEngine.UIElements.Cursor m_Value;        // 0x10
        private UnityEngine.UIElements.StyleKeyword m_Keyword;        // 0x28

        // Methods
        private UnityEngine.UIElements.Cursor get_value() { }
        private UnityEngine.UIElements.StyleKeyword get_keyword() { }
        private System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Void .ctor(UnityEngine.UIElements.Cursor v, UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.StyleCursor lhs, UnityEngine.UIElements.StyleCursor rhs) { }
        private UnityEngine.UIElements.StyleCursor op_Implicit(UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean Equals(UnityEngine.UIElements.StyleCursor other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000262
    public struct StyleDataRef`1, IEquatable`1
    {
        // Fields
        private UnityEngine.UIElements.StyleDataRef.RefCounted<T> m_Ref;        // 0x0

        // Methods
        private UnityEngine.UIElements.StyleDataRef<T> Acquire() { }
        private System.Void Release() { }
        private System.Void CopyFrom(UnityEngine.UIElements.StyleDataRef<T> other) { }
        private T& Read() { }
        private T& Write() { }
        private UnityEngine.UIElements.StyleDataRef<T> Create() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.UIElements.StyleDataRef<T> lhs, UnityEngine.UIElements.StyleDataRef<T> rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.StyleDataRef<T> other) { }
        private System.Boolean Equals(System.Object obj) { }

    }

    // TypeToken: 0x2000264
    public struct StyleEnum`1, IStyleValue`1, IEquatable`1
    {
        // Fields
        private T m_Value;        // 0x0
        private UnityEngine.UIElements.StyleKeyword m_Keyword;        // 0x0

        // Methods
        private T get_value() { }
        private UnityEngine.UIElements.StyleKeyword get_keyword() { }
        private System.Void .ctor(T v) { }
        private System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Void .ctor(T v, UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.StyleEnum<T> lhs, UnityEngine.UIElements.StyleEnum<T> rhs) { }
        private System.Boolean op_Inequality(UnityEngine.UIElements.StyleEnum<T> lhs, UnityEngine.UIElements.StyleEnum<T> rhs) { }
        private UnityEngine.UIElements.StyleEnum<T> op_Implicit(UnityEngine.UIElements.StyleKeyword keyword) { }
        private UnityEngine.UIElements.StyleEnum<T> op_Implicit(T v) { }
        private System.Boolean Equals(UnityEngine.UIElements.StyleEnum<T> other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000265
    public struct StyleFloat, IStyleValue`1, IEquatable`1
    {
        // Fields
        private System.Single m_Value;        // 0x10
        private UnityEngine.UIElements.StyleKeyword m_Keyword;        // 0x14

        // Methods
        private System.Single get_value() { }
        private UnityEngine.UIElements.StyleKeyword get_keyword() { }
        private System.Void .ctor(System.Single v) { }
        private System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Void .ctor(System.Single v, UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.StyleFloat lhs, UnityEngine.UIElements.StyleFloat rhs) { }
        private UnityEngine.UIElements.StyleFloat op_Implicit(UnityEngine.UIElements.StyleKeyword keyword) { }
        private UnityEngine.UIElements.StyleFloat op_Implicit(System.Single v) { }
        private System.Boolean Equals(UnityEngine.UIElements.StyleFloat other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000266
    public struct StyleInt, IStyleValue`1, IEquatable`1
    {
        // Fields
        private System.Int32 m_Value;        // 0x10
        private UnityEngine.UIElements.StyleKeyword m_Keyword;        // 0x14

        // Methods
        private System.Int32 get_value() { }
        private UnityEngine.UIElements.StyleKeyword get_keyword() { }
        private System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Void .ctor(System.Int32 v, UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.StyleInt lhs, UnityEngine.UIElements.StyleInt rhs) { }
        private UnityEngine.UIElements.StyleInt op_Implicit(UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean Equals(UnityEngine.UIElements.StyleInt other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000267
    public struct StyleLength, IStyleValue`1, IEquatable`1
    {
        // Fields
        private UnityEngine.UIElements.Length m_Value;        // 0x10
        private UnityEngine.UIElements.StyleKeyword m_Keyword;        // 0x18

        // Methods
        private UnityEngine.UIElements.Length get_value() { }
        private UnityEngine.UIElements.StyleKeyword get_keyword() { }
        private System.Void .ctor(System.Single v) { }
        private System.Void .ctor(UnityEngine.UIElements.Length v) { }
        private System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Void .ctor(UnityEngine.UIElements.Length v, UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.StyleLength lhs, UnityEngine.UIElements.StyleLength rhs) { }
        private UnityEngine.UIElements.StyleLength op_Implicit(UnityEngine.UIElements.StyleKeyword keyword) { }
        private UnityEngine.UIElements.StyleLength op_Implicit(System.Single v) { }
        private UnityEngine.UIElements.StyleLength op_Implicit(UnityEngine.UIElements.Length v) { }
        private System.Boolean Equals(UnityEngine.UIElements.StyleLength other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000268
    public struct StyleRotate, IStyleValue`1, IEquatable`1
    {
        // Fields
        private UnityEngine.UIElements.Rotate m_Value;        // 0x10
        private UnityEngine.UIElements.StyleKeyword m_Keyword;        // 0x28

        // Methods
        private UnityEngine.UIElements.Rotate get_value() { }
        private UnityEngine.UIElements.StyleKeyword get_keyword() { }
        private System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Void .ctor(UnityEngine.UIElements.Rotate v, UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.StyleRotate lhs, UnityEngine.UIElements.StyleRotate rhs) { }
        private UnityEngine.UIElements.StyleRotate op_Implicit(UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean Equals(UnityEngine.UIElements.StyleRotate other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000269
    public struct StyleScale, IStyleValue`1, IEquatable`1
    {
        // Fields
        private UnityEngine.UIElements.Scale m_Value;        // 0x10
        private UnityEngine.UIElements.StyleKeyword m_Keyword;        // 0x20

        // Methods
        private UnityEngine.UIElements.Scale get_value() { }
        private UnityEngine.UIElements.StyleKeyword get_keyword() { }
        private System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Void .ctor(UnityEngine.UIElements.Scale v, UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.StyleScale lhs, UnityEngine.UIElements.StyleScale rhs) { }
        private UnityEngine.UIElements.StyleScale op_Implicit(UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean Equals(UnityEngine.UIElements.StyleScale other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200026A
    public struct StyleTranslate, IStyleValue`1, IEquatable`1
    {
        // Fields
        private UnityEngine.UIElements.Translate m_Value;        // 0x10
        private UnityEngine.UIElements.StyleKeyword m_Keyword;        // 0x28

        // Methods
        private UnityEngine.UIElements.Translate get_value() { }
        private UnityEngine.UIElements.StyleKeyword get_keyword() { }
        private System.Void .ctor(UnityEngine.UIElements.Translate v) { }
        private System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Void .ctor(UnityEngine.UIElements.Translate v, UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.StyleTranslate lhs, UnityEngine.UIElements.StyleTranslate rhs) { }
        private UnityEngine.UIElements.StyleTranslate op_Implicit(UnityEngine.UIElements.StyleKeyword keyword) { }
        private UnityEngine.UIElements.StyleTranslate op_Implicit(UnityEngine.UIElements.Translate v) { }
        private System.Boolean Equals(UnityEngine.UIElements.StyleTranslate other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200026B
    public struct StyleTextShadow, IStyleValue`1, IEquatable`1
    {
        // Fields
        private UnityEngine.UIElements.StyleKeyword m_Keyword;        // 0x10
        private UnityEngine.UIElements.TextShadow m_Value;        // 0x14

        // Methods
        private UnityEngine.UIElements.TextShadow get_value() { }
        private UnityEngine.UIElements.StyleKeyword get_keyword() { }
        private System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Void .ctor(UnityEngine.UIElements.TextShadow v, UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.StyleTextShadow lhs, UnityEngine.UIElements.StyleTextShadow rhs) { }
        private UnityEngine.UIElements.StyleTextShadow op_Implicit(UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean Equals(UnityEngine.UIElements.StyleTextShadow other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200026C
    public struct StyleTransformOrigin, IStyleValue`1, IEquatable`1
    {
        // Fields
        private UnityEngine.UIElements.TransformOrigin m_Value;        // 0x10
        private UnityEngine.UIElements.StyleKeyword m_Keyword;        // 0x24

        // Methods
        private UnityEngine.UIElements.TransformOrigin get_value() { }
        private UnityEngine.UIElements.StyleKeyword get_keyword() { }
        private System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Void .ctor(UnityEngine.UIElements.TransformOrigin v, UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.StyleTransformOrigin lhs, UnityEngine.UIElements.StyleTransformOrigin rhs) { }
        private UnityEngine.UIElements.StyleTransformOrigin op_Implicit(UnityEngine.UIElements.StyleKeyword keyword) { }
        private System.Boolean Equals(UnityEngine.UIElements.StyleTransformOrigin other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200026D
    public interface IStyleValue`1
    {
        // Methods
        private T get_value() { }
        private UnityEngine.UIElements.StyleKeyword get_keyword() { }

    }

    // TypeToken: 0x200026E
    public struct StyleKeyword
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StyleKeyword Undefined;        // 0x0
        public static UnityEngine.UIElements.StyleKeyword Null;        // 0x0
        public static UnityEngine.UIElements.StyleKeyword Auto;        // 0x0
        public static UnityEngine.UIElements.StyleKeyword None;        // 0x0
        public static UnityEngine.UIElements.StyleKeyword Initial;        // 0x0

    }

    // TypeToken: 0x200026F
    public class StyleValueExtensions
    {
        // Methods
        private System.String DebugString(UnityEngine.UIElements.IStyleValue<T> styleValue) { }
        private UnityEngine.Yoga.YogaValue ToYogaValue(UnityEngine.UIElements.Length length) { }
        private UnityEngine.UIElements.Length ToLength(UnityEngine.UIElements.StyleKeyword keyword) { }
        private UnityEngine.UIElements.Rotate ToRotate(UnityEngine.UIElements.StyleKeyword keyword) { }
        private UnityEngine.UIElements.Scale ToScale(UnityEngine.UIElements.StyleKeyword keyword) { }
        private UnityEngine.UIElements.Translate ToTranslate(UnityEngine.UIElements.StyleKeyword keyword) { }
        private UnityEngine.UIElements.Length ToLength(UnityEngine.UIElements.StyleLength styleLength) { }
        private System.Void CopyFrom(System.Collections.Generic.List<T> list, System.Collections.Generic.List<T> other) { }

    }

    // TypeToken: 0x2000270
    public struct TimeUnit
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.TimeUnit Second;        // 0x0
        public static UnityEngine.UIElements.TimeUnit Millisecond;        // 0x0

    }

    // TypeToken: 0x2000271
    public struct TimeValue, IEquatable`1
    {
        // Fields
        private System.Single m_Value;        // 0x10
        private UnityEngine.UIElements.TimeUnit m_Unit;        // 0x14

        // Methods
        private System.Single get_value() { }
        private UnityEngine.UIElements.TimeUnit get_unit() { }
        private System.Void .ctor(System.Single value) { }
        private System.Void .ctor(System.Single value, UnityEngine.UIElements.TimeUnit unit) { }
        private UnityEngine.UIElements.TimeValue op_Implicit(System.Single value) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.TimeValue lhs, UnityEngine.UIElements.TimeValue rhs) { }
        private System.Boolean op_Inequality(UnityEngine.UIElements.TimeValue lhs, UnityEngine.UIElements.TimeValue rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.TimeValue other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000272
    public struct TransformOrigin, IEquatable`1
    {
        // Fields
        private UnityEngine.UIElements.Length m_X;        // 0x10
        private UnityEngine.UIElements.Length m_Y;        // 0x18
        private System.Single m_Z;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.Length x, UnityEngine.UIElements.Length y, System.Single z) { }
        private UnityEngine.UIElements.TransformOrigin Initial() { }
        private UnityEngine.UIElements.Length get_x() { }
        private System.Void set_x(UnityEngine.UIElements.Length value) { }
        private UnityEngine.UIElements.Length get_y() { }
        private System.Void set_y(UnityEngine.UIElements.Length value) { }
        private System.Single get_z() { }
        private System.Boolean op_Equality(UnityEngine.UIElements.TransformOrigin lhs, UnityEngine.UIElements.TransformOrigin rhs) { }
        private System.Boolean op_Inequality(UnityEngine.UIElements.TransformOrigin lhs, UnityEngine.UIElements.TransformOrigin rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.TransformOrigin other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000273
    public struct Translate, IEquatable`1
    {
        // Fields
        private UnityEngine.UIElements.Length m_X;        // 0x10
        private UnityEngine.UIElements.Length m_Y;        // 0x18
        private System.Single m_Z;        // 0x20
        private System.Boolean m_isNone;        // 0x24

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.Length x, UnityEngine.UIElements.Length y, System.Single z) { }
        private UnityEngine.UIElements.Translate None() { }
        private UnityEngine.UIElements.Length get_x() { }
        private System.Void set_x(UnityEngine.UIElements.Length value) { }
        private UnityEngine.UIElements.Length get_y() { }
        private System.Void set_y(UnityEngine.UIElements.Length value) { }
        private System.Single get_z() { }
        private System.Boolean op_Equality(UnityEngine.UIElements.Translate lhs, UnityEngine.UIElements.Translate rhs) { }
        private System.Boolean op_Inequality(UnityEngine.UIElements.Translate lhs, UnityEngine.UIElements.Translate rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.Translate other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000274
    public interface IResolvedStyle
    {
        // Methods
        private UnityEngine.Color get_backgroundColor() { }
        private UnityEngine.Color get_borderBottomColor() { }
        private System.Single get_borderBottomLeftRadius() { }
        private System.Single get_borderBottomRightRadius() { }
        private System.Single get_borderBottomWidth() { }
        private UnityEngine.Color get_borderLeftColor() { }
        private System.Single get_borderLeftWidth() { }
        private UnityEngine.Color get_borderRightColor() { }
        private System.Single get_borderRightWidth() { }
        private UnityEngine.Color get_borderTopColor() { }
        private System.Single get_borderTopLeftRadius() { }
        private System.Single get_borderTopRightRadius() { }
        private System.Single get_borderTopWidth() { }
        private System.Single get_bottom() { }
        private UnityEngine.Color get_color() { }
        private UnityEngine.UIElements.DisplayStyle get_display() { }
        private UnityEngine.UIElements.FlexDirection get_flexDirection() { }
        private System.Single get_flexGrow() { }
        private System.Single get_flexShrink() { }
        private System.Single get_height() { }
        private System.Single get_left() { }
        private System.Single get_marginBottom() { }
        private System.Single get_marginLeft() { }
        private System.Single get_marginRight() { }
        private System.Single get_marginTop() { }
        private UnityEngine.UIElements.StyleFloat get_minHeight() { }
        private UnityEngine.UIElements.StyleFloat get_minWidth() { }
        private System.Single get_opacity() { }
        private System.Single get_paddingBottom() { }
        private System.Single get_paddingLeft() { }
        private System.Single get_paddingRight() { }
        private System.Single get_paddingTop() { }
        private System.Single get_right() { }
        private UnityEngine.UIElements.Scale get_scale() { }
        private System.Single get_top() { }
        private UnityEngine.Vector3 get_transformOrigin() { }
        private UnityEngine.Vector3 get_translate() { }
        private UnityEngine.Color get_unityBackgroundImageTintColor() { }
        private System.Int32 get_unitySliceLeft() { }
        private System.Int32 get_unitySliceRight() { }
        private UnityEngine.Color get_unityTextOutlineColor() { }
        private System.Single get_unityTextOutlineWidth() { }
        private UnityEngine.UIElements.Visibility get_visibility() { }
        private UnityEngine.UIElements.WhiteSpace get_whiteSpace() { }
        private System.Single get_width() { }

    }

    // TypeToken: 0x2000275
    public interface IStyle
    {
        // Methods
        private System.Void set_backgroundColor(UnityEngine.UIElements.StyleColor value) { }
        private System.Void set_borderBottomColor(UnityEngine.UIElements.StyleColor value) { }
        private System.Void set_borderBottomLeftRadius(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_borderBottomRightRadius(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_borderBottomWidth(UnityEngine.UIElements.StyleFloat value) { }
        private System.Void set_borderLeftColor(UnityEngine.UIElements.StyleColor value) { }
        private System.Void set_borderLeftWidth(UnityEngine.UIElements.StyleFloat value) { }
        private System.Void set_borderRightColor(UnityEngine.UIElements.StyleColor value) { }
        private System.Void set_borderRightWidth(UnityEngine.UIElements.StyleFloat value) { }
        private System.Void set_borderTopColor(UnityEngine.UIElements.StyleColor value) { }
        private System.Void set_borderTopLeftRadius(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_borderTopRightRadius(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_borderTopWidth(UnityEngine.UIElements.StyleFloat value) { }
        private System.Void set_bottom(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_color(UnityEngine.UIElements.StyleColor value) { }
        private UnityEngine.UIElements.StyleCursor get_cursor() { }
        private UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> get_display() { }
        private System.Void set_display(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> value) { }
        private System.Void set_flexBasis(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_flexDirection(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.FlexDirection> value) { }
        private System.Void set_flexGrow(UnityEngine.UIElements.StyleFloat value) { }
        private System.Void set_flexShrink(UnityEngine.UIElements.StyleFloat value) { }
        private System.Void set_fontSize(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_height(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_left(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_marginBottom(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_marginLeft(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_marginRight(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_marginTop(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_maxHeight(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_maxWidth(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_minWidth(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_opacity(UnityEngine.UIElements.StyleFloat value) { }
        private System.Void set_paddingBottom(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_paddingLeft(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_paddingRight(UnityEngine.UIElements.StyleLength value) { }
        private UnityEngine.UIElements.StyleLength get_paddingTop() { }
        private System.Void set_paddingTop(UnityEngine.UIElements.StyleLength value) { }
        private System.Void set_position(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Position> value) { }
        private System.Void set_right(UnityEngine.UIElements.StyleLength value) { }
        private UnityEngine.UIElements.StyleRotate get_rotate() { }
        private UnityEngine.UIElements.StyleScale get_scale() { }
        private UnityEngine.UIElements.StyleTextShadow get_textShadow() { }
        private System.Void set_top(UnityEngine.UIElements.StyleLength value) { }
        private UnityEngine.UIElements.StyleTransformOrigin get_transformOrigin() { }
        private UnityEngine.UIElements.StyleTranslate get_translate() { }
        private System.Void set_translate(UnityEngine.UIElements.StyleTranslate value) { }
        private System.Void set_unityBackgroundImageTintColor(UnityEngine.UIElements.StyleColor value) { }
        private System.Void set_visibility(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Visibility> value) { }
        private UnityEngine.UIElements.StyleLength get_width() { }
        private System.Void set_width(UnityEngine.UIElements.StyleLength value) { }

    }

    // TypeToken: 0x2000276
    public interface IStyleDataGroup`1
    {
        // Methods
        private T Copy() { }
        private System.Void CopyFrom(T& other) { }

    }

    // TypeToken: 0x2000277
    public struct InheritedData, IStyleDataGroup`1, IEquatable`1
    {
        // Fields
        public UnityEngine.Color color;        // 0x10
        public UnityEngine.UIElements.Length fontSize;        // 0x20
        public UnityEngine.UIElements.Length letterSpacing;        // 0x28
        public UnityEngine.UIElements.TextShadow textShadow;        // 0x30
        public UnityEngine.Font unityFont;        // 0x50
        public UnityEngine.UIElements.FontDefinition unityFontDefinition;        // 0x58
        public UnityEngine.FontStyle unityFontStyleAndWeight;        // 0x68
        public UnityEngine.UIElements.Length unityParagraphSpacing;        // 0x6C
        public UnityEngine.TextAnchor unityTextAlign;        // 0x74
        public UnityEngine.Color unityTextOutlineColor;        // 0x78
        public System.Single unityTextOutlineWidth;        // 0x88
        public UnityEngine.UIElements.Visibility visibility;        // 0x8C
        public UnityEngine.UIElements.WhiteSpace whiteSpace;        // 0x90
        public UnityEngine.UIElements.Length wordSpacing;        // 0x94

        // Methods
        private UnityEngine.UIElements.InheritedData Copy() { }
        private System.Void CopyFrom(UnityEngine.UIElements.InheritedData& other) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.InheritedData lhs, UnityEngine.UIElements.InheritedData rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.InheritedData other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000278
    public struct LayoutData, IStyleDataGroup`1, IEquatable`1
    {
        // Fields
        public UnityEngine.UIElements.Align alignContent;        // 0x10
        public UnityEngine.UIElements.Align alignItems;        // 0x14
        public UnityEngine.UIElements.Align alignSelf;        // 0x18
        public System.Single borderBottomWidth;        // 0x1C
        public System.Single borderLeftWidth;        // 0x20
        public System.Single borderRightWidth;        // 0x24
        public System.Single borderTopWidth;        // 0x28
        public UnityEngine.UIElements.Length bottom;        // 0x2C
        public UnityEngine.UIElements.DisplayStyle display;        // 0x34
        public UnityEngine.UIElements.Length flexBasis;        // 0x38
        public UnityEngine.UIElements.FlexDirection flexDirection;        // 0x40
        public System.Single flexGrow;        // 0x44
        public System.Single flexShrink;        // 0x48
        public UnityEngine.UIElements.Wrap flexWrap;        // 0x4C
        public UnityEngine.UIElements.Length height;        // 0x50
        public UnityEngine.UIElements.Justify justifyContent;        // 0x58
        public UnityEngine.UIElements.Length left;        // 0x5C
        public UnityEngine.UIElements.Length marginBottom;        // 0x64
        public UnityEngine.UIElements.Length marginLeft;        // 0x6C
        public UnityEngine.UIElements.Length marginRight;        // 0x74
        public UnityEngine.UIElements.Length marginTop;        // 0x7C
        public UnityEngine.UIElements.Length maxHeight;        // 0x84
        public UnityEngine.UIElements.Length maxWidth;        // 0x8C
        public UnityEngine.UIElements.Length minHeight;        // 0x94
        public UnityEngine.UIElements.Length minWidth;        // 0x9C
        public UnityEngine.UIElements.Length paddingBottom;        // 0xA4
        public UnityEngine.UIElements.Length paddingLeft;        // 0xAC
        public UnityEngine.UIElements.Length paddingRight;        // 0xB4
        public UnityEngine.UIElements.Length paddingTop;        // 0xBC
        public UnityEngine.UIElements.Position position;        // 0xC4
        public UnityEngine.UIElements.Length right;        // 0xC8
        public UnityEngine.UIElements.Length top;        // 0xD0
        public UnityEngine.UIElements.Length width;        // 0xD8

        // Methods
        private UnityEngine.UIElements.LayoutData Copy() { }
        private System.Void CopyFrom(UnityEngine.UIElements.LayoutData& other) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.LayoutData lhs, UnityEngine.UIElements.LayoutData rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.LayoutData other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000279
    public struct RareData, IStyleDataGroup`1, IEquatable`1
    {
        // Fields
        public UnityEngine.UIElements.Cursor cursor;        // 0x10
        public UnityEngine.UIElements.TextOverflow textOverflow;        // 0x28
        public UnityEngine.Color unityBackgroundImageTintColor;        // 0x2C
        public UnityEngine.ScaleMode unityBackgroundScaleMode;        // 0x3C
        public UnityEngine.UIElements.OverflowClipBox unityOverflowClipBox;        // 0x40
        public System.Int32 unitySliceBottom;        // 0x44
        public System.Int32 unitySliceLeft;        // 0x48
        public System.Int32 unitySliceRight;        // 0x4C
        public System.Int32 unitySliceTop;        // 0x50
        public UnityEngine.UIElements.TextOverflowPosition unityTextOverflowPosition;        // 0x54

        // Methods
        private UnityEngine.UIElements.RareData Copy() { }
        private System.Void CopyFrom(UnityEngine.UIElements.RareData& other) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.RareData lhs, UnityEngine.UIElements.RareData rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.RareData other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200027A
    public struct TransformData, IStyleDataGroup`1, IEquatable`1
    {
        // Fields
        public UnityEngine.UIElements.Rotate rotate;        // 0x10
        public UnityEngine.UIElements.Scale scale;        // 0x28
        public UnityEngine.UIElements.TransformOrigin transformOrigin;        // 0x38
        public UnityEngine.UIElements.Translate translate;        // 0x4C

        // Methods
        private UnityEngine.UIElements.TransformData Copy() { }
        private System.Void CopyFrom(UnityEngine.UIElements.TransformData& other) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.TransformData lhs, UnityEngine.UIElements.TransformData rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.TransformData other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200027B
    public struct TransitionData, IStyleDataGroup`1, IEquatable`1
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> transitionDelay;        // 0x10
        public System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> transitionDuration;        // 0x18
        public System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> transitionProperty;        // 0x20
        public System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> transitionTimingFunction;        // 0x28

        // Methods
        private UnityEngine.UIElements.TransitionData Copy() { }
        private System.Void CopyFrom(UnityEngine.UIElements.TransitionData& other) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.TransitionData lhs, UnityEngine.UIElements.TransitionData rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.TransitionData other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200027C
    public struct VisualData, IStyleDataGroup`1, IEquatable`1
    {
        // Fields
        public UnityEngine.Color backgroundColor;        // 0x10
        public UnityEngine.UIElements.Background backgroundImage;        // 0x20
        public UnityEngine.Color borderBottomColor;        // 0x40
        public UnityEngine.UIElements.Length borderBottomLeftRadius;        // 0x50
        public UnityEngine.UIElements.Length borderBottomRightRadius;        // 0x58
        public UnityEngine.Color borderLeftColor;        // 0x60
        public UnityEngine.Color borderRightColor;        // 0x70
        public UnityEngine.Color borderTopColor;        // 0x80
        public UnityEngine.UIElements.Length borderTopLeftRadius;        // 0x90
        public UnityEngine.UIElements.Length borderTopRightRadius;        // 0x98
        public System.Single opacity;        // 0xA0
        public UnityEngine.UIElements.OverflowInternal overflow;        // 0xA4

        // Methods
        private UnityEngine.UIElements.VisualData Copy() { }
        private System.Void CopyFrom(UnityEngine.UIElements.VisualData& other) { }
        private System.Boolean op_Equality(UnityEngine.UIElements.VisualData lhs, UnityEngine.UIElements.VisualData rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.VisualData other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200027D
    public struct Hashes
    {
        // Fields
        public static System.Int32 kSize;        // 0x0
        public UnityEngine.UIElements.Hashes.<hashes>e__FixedBuffer hashes;        // 0x10

    }

    // TypeToken: 0x200027F
    public class StyleComplexSelector, ISerializationCallbackReceiver
    {
        // Fields
        public UnityEngine.UIElements.Hashes ancestorHashes;        // 0x10
        private System.Int32 m_Specificity;        // 0x20
        private UnityEngine.UIElements.StyleRule <rule>k__BackingField;        // 0x28
        private System.Boolean m_isSimple;        // 0x30
        private UnityEngine.UIElements.StyleSelector[] m_Selectors;        // 0x38
        private System.Int32 ruleIndex;        // 0x40
        private UnityEngine.UIElements.StyleComplexSelector nextInTable;        // 0x48
        private System.Int32 orderInStyleSheet;        // 0x50
        private static System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleComplexSelector.PseudoStateData> s_PseudoStates;        // 0x0
        private static System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart> m_HashList;        // 0x8

        // Methods
        private System.Int32 get_specificity() { }
        private UnityEngine.UIElements.StyleRule get_rule() { }
        private System.Void set_rule(UnityEngine.UIElements.StyleRule value) { }
        private System.Boolean get_isSimple() { }
        private UnityEngine.UIElements.StyleSelector[] get_selectors() { }
        private System.Void set_selectors(UnityEngine.UIElements.StyleSelector[] value) { }
        private System.Void OnBeforeSerialize() { }
        private System.Void OnAfterDeserialize() { }
        private System.Void CachePseudoStateMasks() { }
        private System.String ToString() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000282
    public class StyleProperty
    {
        // Fields
        private System.String m_Name;        // 0x10
        private System.Int32 m_Line;        // 0x18
        private UnityEngine.UIElements.StyleValueHandle[] m_Values;        // 0x20
        private System.Boolean isCustomProperty;        // 0x28
        private System.Boolean requireVariableResolve;        // 0x29

        // Methods
        private System.String get_name() { }
        private UnityEngine.UIElements.StyleValueHandle[] get_values() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000283
    public class StyleRule
    {
        // Fields
        private UnityEngine.UIElements.StyleProperty[] m_Properties;        // 0x10
        private System.Int32 line;        // 0x18
        private System.Int32 customPropertiesCount;        // 0x1C

        // Methods
        private UnityEngine.UIElements.StyleProperty[] get_properties() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000284
    public class StyleSelector
    {
        // Fields
        private UnityEngine.UIElements.StyleSelectorPart[] m_Parts;        // 0x10
        private UnityEngine.UIElements.StyleSelectorRelationship m_PreviousRelationship;        // 0x18
        private System.Int32 pseudoStateMask;        // 0x1C
        private System.Int32 negatedPseudoStateMask;        // 0x20

        // Methods
        private UnityEngine.UIElements.StyleSelectorPart[] get_parts() { }
        private System.Void set_parts(UnityEngine.UIElements.StyleSelectorPart[] value) { }
        private UnityEngine.UIElements.StyleSelectorRelationship get_previousRelationship() { }
        private System.Void set_previousRelationship(UnityEngine.UIElements.StyleSelectorRelationship value) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000286
    public struct StyleSelectorPart
    {
        // Fields
        private System.String m_Value;        // 0x10
        private UnityEngine.UIElements.StyleSelectorType m_Type;        // 0x18
        private System.Object tempData;        // 0x20

        // Methods
        private System.String get_value() { }
        private UnityEngine.UIElements.StyleSelectorType get_type() { }
        private System.Void set_type(UnityEngine.UIElements.StyleSelectorType value) { }
        private System.String ToString() { }
        private UnityEngine.UIElements.StyleSelectorPart CreateClass(System.String className) { }
        private UnityEngine.UIElements.StyleSelectorPart CreateId(System.String Id) { }
        private UnityEngine.UIElements.StyleSelectorPart CreatePredicate(System.Object predicate) { }

    }

    // TypeToken: 0x2000287
    public struct StyleSelectorRelationship
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StyleSelectorRelationship None;        // 0x0
        public static UnityEngine.UIElements.StyleSelectorRelationship Child;        // 0x0
        public static UnityEngine.UIElements.StyleSelectorRelationship Descendent;        // 0x0

    }

    // TypeToken: 0x2000288
    public struct StyleSelectorType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StyleSelectorType Unknown;        // 0x0
        public static UnityEngine.UIElements.StyleSelectorType Wildcard;        // 0x0
        public static UnityEngine.UIElements.StyleSelectorType Type;        // 0x0
        public static UnityEngine.UIElements.StyleSelectorType Class;        // 0x0
        public static UnityEngine.UIElements.StyleSelectorType PseudoClass;        // 0x0
        public static UnityEngine.UIElements.StyleSelectorType RecursivePseudoClass;        // 0x0
        public static UnityEngine.UIElements.StyleSelectorType ID;        // 0x0
        public static UnityEngine.UIElements.StyleSelectorType Predicate;        // 0x0

    }

    // TypeToken: 0x2000289
    public class StyleSheet : ScriptableObject
    {
        // Fields
        private System.Boolean m_ImportedWithErrors;        // 0x18
        private System.Boolean m_ImportedWithWarnings;        // 0x19
        private UnityEngine.UIElements.StyleRule[] m_Rules;        // 0x20
        private UnityEngine.UIElements.StyleComplexSelector[] m_ComplexSelectors;        // 0x28
        private System.Single[] floats;        // 0x30
        private UnityEngine.UIElements.StyleSheets.Dimension[] dimensions;        // 0x38
        private UnityEngine.Color[] colors;        // 0x40
        private System.String[] strings;        // 0x48
        private UnityEngine.Object[] assets;        // 0x50
        private UnityEngine.UIElements.StyleSheet.ImportStruct[] imports;        // 0x58
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> m_FlattenedImportedStyleSheets;        // 0x60
        private System.Int32 m_ContentHash;        // 0x68
        private UnityEngine.UIElements.StyleSheets.ScalableImage[] scalableImages;        // 0x70
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleComplexSelector> orderedNameSelectors;        // 0x78
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleComplexSelector> orderedTypeSelectors;        // 0x80
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleComplexSelector> orderedClassSelectors;        // 0x88
        private System.Boolean m_IsDefaultStyleSheet;        // 0x90
        private static System.String kCustomPropertyMarker;        // 0x0

        // Methods
        private System.Boolean get_importedWithErrors() { }
        private System.Void set_importedWithErrors(System.Boolean value) { }
        private System.Boolean get_importedWithWarnings() { }
        private System.Void set_importedWithWarnings(System.Boolean value) { }
        private UnityEngine.UIElements.StyleRule[] get_rules() { }
        private System.Void set_rules(UnityEngine.UIElements.StyleRule[] value) { }
        private UnityEngine.UIElements.StyleComplexSelector[] get_complexSelectors() { }
        private System.Void set_complexSelectors(UnityEngine.UIElements.StyleComplexSelector[] value) { }
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> get_flattenedRecursiveImports() { }
        private System.Int32 get_contentHash() { }
        private System.Void set_contentHash(System.Int32 value) { }
        private System.Boolean get_isDefaultStyleSheet() { }
        private System.Void set_isDefaultStyleSheet(System.Boolean value) { }
        private System.Boolean TryCheckAccess(T[] list, UnityEngine.UIElements.StyleValueType type, UnityEngine.UIElements.StyleValueHandle handle, T& value) { }
        private T CheckAccess(T[] list, UnityEngine.UIElements.StyleValueType type, UnityEngine.UIElements.StyleValueHandle handle) { }
        private System.Void OnEnable() { }
        private System.Void FlattenImportedStyleSheetsRecursive() { }
        private System.Void FlattenImportedStyleSheetsRecursive(UnityEngine.UIElements.StyleSheet sheet) { }
        private System.Void SetupReferences() { }
        private UnityEngine.UIElements.StyleValueKeyword ReadKeyword(UnityEngine.UIElements.StyleValueHandle handle) { }
        private System.Single ReadFloat(UnityEngine.UIElements.StyleValueHandle handle) { }
        private System.Boolean TryReadFloat(UnityEngine.UIElements.StyleValueHandle handle, System.Single& value) { }
        private UnityEngine.UIElements.StyleSheets.Dimension ReadDimension(UnityEngine.UIElements.StyleValueHandle handle) { }
        private System.Boolean TryReadDimension(UnityEngine.UIElements.StyleValueHandle handle, UnityEngine.UIElements.StyleSheets.Dimension& value) { }
        private UnityEngine.Color ReadColor(UnityEngine.UIElements.StyleValueHandle handle) { }
        private System.Boolean TryReadColor(UnityEngine.UIElements.StyleValueHandle handle, UnityEngine.Color& value) { }
        private System.String ReadString(UnityEngine.UIElements.StyleValueHandle handle) { }
        private System.Boolean TryReadString(UnityEngine.UIElements.StyleValueHandle handle, System.String& value) { }
        private System.String ReadEnum(UnityEngine.UIElements.StyleValueHandle handle) { }
        private System.Boolean TryReadEnum(UnityEngine.UIElements.StyleValueHandle handle, System.String& value) { }
        private System.String ReadVariable(UnityEngine.UIElements.StyleValueHandle handle) { }
        private System.Boolean TryReadVariable(UnityEngine.UIElements.StyleValueHandle handle, System.String& value) { }
        private System.String ReadResourcePath(UnityEngine.UIElements.StyleValueHandle handle) { }
        private System.Boolean TryReadResourcePath(UnityEngine.UIElements.StyleValueHandle handle, System.String& value) { }
        private UnityEngine.Object ReadAssetReference(UnityEngine.UIElements.StyleValueHandle handle) { }
        private System.String ReadMissingAssetReferenceUrl(UnityEngine.UIElements.StyleValueHandle handle) { }
        private System.Boolean TryReadAssetReference(UnityEngine.UIElements.StyleValueHandle handle, UnityEngine.Object& value) { }
        private UnityEngine.UIElements.StyleValueFunction ReadFunction(UnityEngine.UIElements.StyleValueHandle handle) { }
        private System.String ReadFunctionName(UnityEngine.UIElements.StyleValueHandle handle) { }
        private UnityEngine.UIElements.StyleSheets.ScalableImage ReadScalableImage(UnityEngine.UIElements.StyleValueHandle handle) { }
        private System.Boolean CustomStartsWith(System.String originalString, System.String pattern) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200028B
    public struct StyleValueFunction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StyleValueFunction Unknown;        // 0x0
        public static UnityEngine.UIElements.StyleValueFunction Var;        // 0x0
        public static UnityEngine.UIElements.StyleValueFunction Env;        // 0x0
        public static UnityEngine.UIElements.StyleValueFunction LinearGradient;        // 0x0

    }

    // TypeToken: 0x200028C
    public class StyleValueFunctionExtension
    {
        // Methods
        private System.String ToUssString(UnityEngine.UIElements.StyleValueFunction svf) { }

    }

    // TypeToken: 0x200028D
    public struct StyleValueHandle
    {
        // Fields
        private UnityEngine.UIElements.StyleValueType m_ValueType;        // 0x10
        private System.Int32 valueIndex;        // 0x14

        // Methods
        private UnityEngine.UIElements.StyleValueType get_valueType() { }
        private System.Void set_valueType(UnityEngine.UIElements.StyleValueType value) { }

    }

    // TypeToken: 0x200028E
    public struct StyleValueKeyword
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StyleValueKeyword Inherit;        // 0x0
        public static UnityEngine.UIElements.StyleValueKeyword Initial;        // 0x0
        public static UnityEngine.UIElements.StyleValueKeyword Auto;        // 0x0
        public static UnityEngine.UIElements.StyleValueKeyword Unset;        // 0x0
        public static UnityEngine.UIElements.StyleValueKeyword True;        // 0x0
        public static UnityEngine.UIElements.StyleValueKeyword False;        // 0x0
        public static UnityEngine.UIElements.StyleValueKeyword None;        // 0x0

    }

    // TypeToken: 0x200028F
    public class StyleValueKeywordExtension
    {
        // Methods
        private System.String ToUssString(UnityEngine.UIElements.StyleValueKeyword svk) { }

    }

    // TypeToken: 0x2000290
    public struct StyleValueType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StyleValueType Invalid;        // 0x0
        public static UnityEngine.UIElements.StyleValueType Keyword;        // 0x0
        public static UnityEngine.UIElements.StyleValueType Float;        // 0x0
        public static UnityEngine.UIElements.StyleValueType Dimension;        // 0x0
        public static UnityEngine.UIElements.StyleValueType Color;        // 0x0
        public static UnityEngine.UIElements.StyleValueType ResourcePath;        // 0x0
        public static UnityEngine.UIElements.StyleValueType AssetReference;        // 0x0
        public static UnityEngine.UIElements.StyleValueType Enum;        // 0x0
        public static UnityEngine.UIElements.StyleValueType Variable;        // 0x0
        public static UnityEngine.UIElements.StyleValueType String;        // 0x0
        public static UnityEngine.UIElements.StyleValueType Function;        // 0x0
        public static UnityEngine.UIElements.StyleValueType CommaSeparator;        // 0x0
        public static UnityEngine.UIElements.StyleValueType ScalableImage;        // 0x0
        public static UnityEngine.UIElements.StyleValueType MissingAssetReference;        // 0x0

    }

    // TypeToken: 0x2000291
    public struct StyleVariable
    {
        // Fields
        public readonly System.String name;        // 0x10
        public readonly UnityEngine.UIElements.StyleSheet sheet;        // 0x18
        public readonly UnityEngine.UIElements.StyleValueHandle[] handles;        // 0x20

        // Methods
        private System.Void .ctor(System.String name, UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000292
    public class StyleVariableContext
    {
        // Fields
        public static readonly UnityEngine.UIElements.StyleVariableContext none;        // 0x0
        private System.Int32 m_VariableHash;        // 0x10
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleVariable> m_Variables;        // 0x18
        private System.Collections.Generic.List<System.Int32> m_SortedHash;        // 0x20
        private System.Collections.Generic.List<System.Int32> m_UnsortedHash;        // 0x28

        // Methods
        private System.Void Add(UnityEngine.UIElements.StyleVariable sv) { }
        private System.Void AddInitialRange(UnityEngine.UIElements.StyleVariableContext other) { }
        private System.Void Clear() { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.UIElements.StyleVariableContext other) { }
        private System.Boolean TryFindVariable(System.String name, UnityEngine.UIElements.StyleVariable& v) { }
        private System.Int32 GetVariableHash() { }
        private System.Void .cctor() { }
        private System.Int32 <Add>g__ComputeOrderSensitiveHash|7_0(System.Int32 index, UnityEngine.UIElements.StyleVariableContext.<>c__DisplayClass7_0& ) { }

    }

    // TypeToken: 0x2000294
    public class StyleVariableResolver
    {
        // Fields
        private static System.Int32 kMaxResolves;        // 0x0
        private static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser s_SyntaxParser;        // 0x0
        private UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher m_Matcher;        // 0x10
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_ResolvedValues;        // 0x18
        private System.Collections.Generic.Stack<System.String> m_ResolvedVarStack;        // 0x20
        private UnityEngine.UIElements.StyleProperty m_Property;        // 0x28
        private System.Collections.Generic.Stack<UnityEngine.UIElements.StyleVariableResolver.ResolveContext> m_ContextStack;        // 0x30
        private UnityEngine.UIElements.StyleVariableResolver.ResolveContext m_CurrentContext;        // 0x38
        private UnityEngine.UIElements.StyleVariableContext <variableContext>k__BackingField;        // 0x48

        // Methods
        private UnityEngine.UIElements.StyleSheet get_currentSheet() { }
        private UnityEngine.UIElements.StyleValueHandle[] get_currentHandles() { }
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> get_resolvedValues() { }
        private UnityEngine.UIElements.StyleVariableContext get_variableContext() { }
        private System.Void set_variableContext(UnityEngine.UIElements.StyleVariableContext value) { }
        private System.Void Init(UnityEngine.UIElements.StyleProperty property, UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles) { }
        private System.Void PushContext(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles) { }
        private System.Void PopContext() { }
        private System.Void AddValue(UnityEngine.UIElements.StyleValueHandle handle) { }
        private System.Boolean ResolveVarFunction(System.Int32& index) { }
        private UnityEngine.UIElements.StyleVariableResolver.Result ResolveVarFunction(System.Int32& index, System.Int32 argc, System.String varName) { }
        private System.Boolean ValidateResolvedValues() { }
        private UnityEngine.UIElements.StyleVariableResolver.Result ResolveVariable(System.String variableName) { }
        private UnityEngine.UIElements.StyleVariableResolver.Result ResolveFallback(System.Int32& index) { }
        private System.Void ParseVarFunction(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles, System.Int32& index, System.Int32& argCount, System.String& variableName) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000297
    public class ThemeStyleSheet : StyleSheet
    {
        // Methods
        private System.Void OnEnable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000298
    public class PanelTextSettings : TextSettings
    {
        // Fields
        private static UnityEngine.UIElements.PanelTextSettings s_DefaultPanelTextSettings;        // 0x0
        private static System.Func<System.String,UnityEngine.Object> EditorGUIUtilityLoad;        // 0x8
        private static System.Func<UnityEngine.SystemLanguage> GetCurrentLanguage;        // 0x10
        private static readonly System.String s_DefaultEditorPanelTextSettingPath;        // 0x18

        // Methods
        private UnityEngine.UIElements.PanelTextSettings get_defaultPanelTextSettings() { }
        private System.Void UpdateLocalizationFontAsset() { }
        private UnityEngine.TextCore.Text.FontAsset GetCachedFontAsset(UnityEngine.Font font) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000299
    public interface ITextHandle
    {
        // Methods
        private UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.CursorPositionStylePainterParameters parms, System.Single scaling) { }
        private System.Single ComputeTextWidth(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling) { }
        private System.Single ComputeTextHeight(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling) { }
        private System.Single GetLineHeight(System.Int32 characterIndex, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, System.Single textScaling, System.Single pixelPerPoint) { }
        private UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single pixelsPerPoint) { }
        private System.Boolean IsLegacy() { }
        private System.Boolean IsElided() { }
        private System.Void set_MeasuredSizes(UnityEngine.Vector2 value) { }
        private System.Void set_RoundedSizes(UnityEngine.Vector2 value) { }

    }

    // TypeToken: 0x200029A
    public struct TextCoreHandle, ITextHandle
    {
        // Fields
        private UnityEngine.Vector2 <MeasuredSizes>k__BackingField;        // 0x10
        private UnityEngine.Vector2 <RoundedSizes>k__BackingField;        // 0x18
        private UnityEngine.Vector2 m_PreferredSize;        // 0x20
        private System.Int32 m_PreviousGenerationSettingsHash;        // 0x28
        private UnityEngine.TextCore.Text.TextGenerationSettings m_CurrentGenerationSettings;        // 0x30
        private static UnityEngine.TextCore.Text.TextGenerationSettings s_LayoutSettings;        // 0x0
        private UnityEngine.TextCore.Text.TextInfo m_TextInfoMesh;        // 0x38
        private static UnityEngine.TextCore.Text.TextInfo s_TextInfoLayout;        // 0x8
        private System.Boolean isDirty;        // 0x40

        // Methods
        private UnityEngine.Vector2 get_MeasuredSizes() { }
        private System.Void set_MeasuredSizes(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_RoundedSizes() { }
        private System.Void set_RoundedSizes(UnityEngine.Vector2 value) { }
        private UnityEngine.UIElements.ITextHandle New() { }
        private UnityEngine.TextCore.Text.TextInfo get_textInfoMesh() { }
        private UnityEngine.TextCore.Text.TextInfo get_textInfoLayout() { }
        private System.Boolean IsLegacy() { }
        private System.Boolean IsDirty(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms) { }
        private UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.CursorPositionStylePainterParameters parms, System.Single scaling) { }
        private System.Single ComputeTextWidth(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling) { }
        private System.Single ComputeTextHeight(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling) { }
        private System.Single GetLineHeight(System.Int32 characterIndex, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, System.Single textScaling, System.Single pixelPerPoint) { }
        private UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single pixelsPerPoint) { }
        private System.Void UpdatePreferredValues(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms) { }
        private UnityEngine.TextCore.Text.TextOverflowMode GetTextOverflowMode(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams) { }
        private System.Void UpdateGenerationSettingsCommon(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams painterParams, UnityEngine.TextCore.Text.TextGenerationSettings settings) { }
        private System.Boolean IsElided() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200029B
    public struct TextNativeHandle, ITextHandle
    {
        // Fields
        private UnityEngine.Vector2 <MeasuredSizes>k__BackingField;        // 0x10
        private UnityEngine.Vector2 <RoundedSizes>k__BackingField;        // 0x18
        private Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> textVertices;        // 0x20
        private System.Int32 m_PreviousTextParamsHash;        // 0x30

        // Methods
        private UnityEngine.Vector2 get_MeasuredSizes() { }
        private System.Void set_MeasuredSizes(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_RoundedSizes() { }
        private System.Void set_RoundedSizes(UnityEngine.Vector2 value) { }
        private UnityEngine.UIElements.ITextHandle New() { }
        private System.Boolean IsLegacy() { }
        private System.Single GetLineHeight(System.Int32 characterIndex, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, System.Single textScaling, System.Single pixelPerPoint) { }
        private UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single pixelsPerPoint) { }
        private Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> GetVertices(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling) { }
        private UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.CursorPositionStylePainterParameters parms, System.Single scaling) { }
        private System.Single ComputeTextWidth(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling) { }
        private System.Single ComputeTextHeight(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling) { }
        private System.Boolean IsElided() { }

    }

    // TypeToken: 0x200029C
    public class TextUtilities
    {
        // Methods
        private System.Single ComputeTextScaling(UnityEngine.Matrix4x4 worldMatrix, System.Single pixelsPerPoint) { }
        private UnityEngine.Vector2 MeasureVisualElementTextSize(UnityEngine.UIElements.VisualElement ve, System.String textToMeasure, System.Single width, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single height, UnityEngine.UIElements.VisualElement.MeasureMode heightMode, UnityEngine.UIElements.ITextHandle textHandle) { }
        private UnityEngine.TextCore.Text.FontAsset GetFontAsset(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParam) { }
        private UnityEngine.TextCore.Text.FontAsset GetFontAsset(UnityEngine.UIElements.VisualElement ve) { }
        private UnityEngine.Font GetFont(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParam) { }
        private UnityEngine.Font GetFont(UnityEngine.UIElements.VisualElement ve) { }
        private System.Boolean IsFontAssigned(UnityEngine.UIElements.VisualElement ve) { }
        private System.Boolean IsFontAssigned(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams) { }
        private UnityEngine.UIElements.PanelTextSettings GetTextSettingsFrom(UnityEngine.UIElements.VisualElement ve) { }
        private UnityEngine.UIElements.PanelTextSettings GetTextSettingsFrom(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParam) { }
        private UnityEngine.UIElements.UIR.TextCoreSettings GetTextCoreSettingsForElement(UnityEngine.UIElements.VisualElement ve) { }

    }

    // TypeToken: 0x200029D
    public interface IUxmlAttributes
    {
        // Methods
        private System.Boolean TryGetAttributeValue(System.String attributeName, System.String& value) { }

    }

    // TypeToken: 0x200029E
    public class UxmlRootElementFactory : UxmlFactory`2
    {
        // Methods
        private System.String get_uxmlName() { }
        private System.String get_uxmlQualifiedName() { }
        private UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200029F
    public class UxmlRootElementTraits : UxmlTraits
    {
        // Fields
        protected UnityEngine.UIElements.UxmlStringAttributeDescription m_Name;        // 0x18
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Class;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002A0
    public class UxmlStyleFactory : UxmlFactory`2
    {
        // Methods
        private System.String get_uxmlName() { }
        private System.String get_uxmlQualifiedName() { }
        private UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002A1
    public class UxmlStyleTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Name;        // 0x18
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Path;        // 0x20
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Src;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002A2
    public class UxmlTemplateFactory : UxmlFactory`2
    {
        // Methods
        private System.String get_uxmlName() { }
        private System.String get_uxmlQualifiedName() { }
        private UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002A3
    public class UxmlTemplateTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Name;        // 0x18
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Path;        // 0x20
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_Src;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002A4
    public class UxmlAttributeOverridesFactory : UxmlFactory`2
    {
        // Methods
        private System.String get_uxmlName() { }
        private System.String get_uxmlQualifiedName() { }
        private UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002A5
    public class UxmlAttributeOverridesTraits : UxmlTraits
    {
        // Fields
        private UnityEngine.UIElements.UxmlStringAttributeDescription m_ElementName;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002A6
    public class TemplateAsset : VisualElementAsset
    {
        // Fields
        private System.String m_TemplateAlias;        // 0x70
        private System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> m_AttributeOverrides;        // 0x78
        private System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotUsageEntry> m_SlotUsages;        // 0x80

        // Methods
        private System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> get_attributeOverrides() { }
        private System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotUsageEntry> get_slotUsages() { }

    }

    // TypeToken: 0x20002A8
    public class UxmlAttributeDescription
    {
        // Fields
        private System.String <name>k__BackingField;        // 0x10
        private System.String[] m_ObsoleteNames;        // 0x18
        private System.String <type>k__BackingField;        // 0x20
        private System.String <typeNamespace>k__BackingField;        // 0x28
        private UnityEngine.UIElements.UxmlAttributeDescription.Use <use>k__BackingField;        // 0x30
        private UnityEngine.UIElements.UxmlTypeRestriction <restriction>k__BackingField;        // 0x38

        // Methods
        private System.Void .ctor() { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Void set_obsoleteNames(System.Collections.Generic.IEnumerable<System.String> value) { }
        private System.Void set_type(System.String value) { }
        private System.Void set_typeNamespace(System.String value) { }
        private System.Void set_use(UnityEngine.UIElements.UxmlAttributeDescription.Use value) { }
        private System.Void set_restriction(UnityEngine.UIElements.UxmlTypeRestriction value) { }
        private System.Boolean TryGetValueFromBagAsString(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.String& value) { }
        private System.Boolean TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.Func<System.String,T,T> converterFunc, T defaultValue, T& value) { }
        private T GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.Func<System.String,T,T> converterFunc, T defaultValue) { }

    }

    // TypeToken: 0x20002AA
    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // Fields
        private T <defaultValue>k__BackingField;        // 0x0

        // Methods
        private T GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private T get_defaultValue() { }
        private System.Void set_defaultValue(T value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002AB
    public class UxmlStringAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // Methods
        private System.Void .ctor() { }
        private System.String GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Boolean TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.String& value) { }

    }

    // TypeToken: 0x20002AD
    public class UxmlFloatAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // Methods
        private System.Void .ctor() { }
        private System.Single GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Single ConvertValueToFloat(System.String v, System.Single defaultValue) { }

    }

    // TypeToken: 0x20002AF
    public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // Methods
        private System.Void .ctor() { }
        private System.Int32 GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Boolean TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.Int32& value) { }
        private System.Int32 ConvertValueToInt(System.String v, System.Int32 defaultValue) { }

    }

    // TypeToken: 0x20002B1
    public class UxmlLongAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // Methods
        private System.Void .ctor() { }
        private System.Int64 GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Int64 ConvertValueToLong(System.String v, System.Int64 defaultValue) { }

    }

    // TypeToken: 0x20002B3
    public class UxmlBoolAttributeDescription : TypedUxmlAttributeDescription`1
    {
        // Methods
        private System.Void .ctor() { }
        private System.Boolean GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Boolean ConvertValueToBool(System.String v, System.Boolean defaultValue) { }

    }

    // TypeToken: 0x20002B5
    public class UxmlEnumAttributeDescription`1 : TypedUxmlAttributeDescription`1
    {
        // Methods
        private System.Void .ctor() { }
        private T GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Boolean TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, T& value) { }
        private U ConvertValueToEnum(System.String v, U defaultValue) { }

    }

    // TypeToken: 0x20002B7
    public class UxmlObjectAttributeDescription`1
    {
        // Fields
        private T <defaultValue>k__BackingField;        // 0x0

        // Methods
        private T get_defaultValue() { }
        private T GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002B8
    public class UxmlObjectListAttributeDescription`1 : UxmlObjectAttributeDescription`1
    {
        // Methods
        private System.Collections.Generic.List<T> GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002B9
    public class UxmlTraits
    {
        // Fields
        private System.Boolean <canHaveAnyAttribute>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void set_canHaveAnyAttribute(System.Boolean value) { }
        private System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }

    }

    // TypeToken: 0x20002BA
    public interface IUxmlFactory
    {
        // Methods
        private System.String get_uxmlQualifiedName() { }
        private System.Boolean AcceptsAttributeBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }

    }

    // TypeToken: 0x20002BB
    public class UxmlFactory`2, IUxmlFactory
    {
        // Fields
        private TTraits m_Traits;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.String get_uxmlName() { }
        private System.String get_uxmlNamespace() { }
        private System.String get_uxmlQualifiedName() { }
        private System.Boolean AcceptsAttributeBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }

    }

    // TypeToken: 0x20002BC
    public class UxmlFactory`1 : UxmlFactory`2
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002BD
    public class BaseUxmlTraits
    {
        // Fields
        private System.Boolean <canHaveAnyAttribute>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void set_canHaveAnyAttribute(System.Boolean value) { }

    }

    // TypeToken: 0x20002BE
    public class UxmlObjectTraits`1 : BaseUxmlTraits
    {
        // Methods
        private System.Void Init(T& obj, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002BF
    public interface IBaseUxmlFactory
    {
        // Methods
        private System.String get_uxmlQualifiedName() { }
        private System.Boolean AcceptsAttributeBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }

    }

    // TypeToken: 0x20002C0
    public interface IBaseUxmlObjectFactory : IBaseUxmlFactory
    {
    }

    // TypeToken: 0x20002C1
    public interface IUxmlObjectFactory`1 : IBaseUxmlObjectFactory, IBaseUxmlFactory
    {
        // Methods
        private T CreateObject(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }

    }

    // TypeToken: 0x20002C2
    public class UxmlObjectFactory`2 : BaseUxmlFactory`2, IUxmlObjectFactory`1, IBaseUxmlObjectFactory, IBaseUxmlFactory
    {
        // Methods
        private TCreatedType CreateObject(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002C3
    public class BaseUxmlFactory`2
    {
        // Fields
        private TTraits m_Traits;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.String get_uxmlQualifiedName() { }
        private System.Boolean AcceptsAttributeBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc) { }

    }

    // TypeToken: 0x20002C4
    public class UxmlAsset, IUxmlAttributes
    {
        // Fields
        private System.String m_FullTypeName;        // 0x10
        private System.Int32 m_Id;        // 0x18
        private System.Int32 m_OrderInDocument;        // 0x1C
        private System.Int32 m_ParentId;        // 0x20
        protected System.Collections.Generic.List<System.String> m_Properties;        // 0x28

        // Methods
        private System.String get_fullTypeName() { }
        private System.Int32 get_id() { }
        private System.Int32 get_orderInDocument() { }
        private System.Int32 get_parentId() { }
        private System.Boolean TryGetAttributeValue(System.String propertyName, System.String& value) { }
        private System.Void SetAttribute(System.String name, System.String value) { }
        private System.Void SetOrAddProperty(System.String propertyName, System.String propertyValue) { }

    }

    // TypeToken: 0x20002C5
    public class UxmlObjectAsset : UxmlAsset
    {
    }

    // TypeToken: 0x20002C6
    public class UxmlObjectFactoryRegistry
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IBaseUxmlObjectFactory>> s_Factories;        // 0x0

        // Methods
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IBaseUxmlObjectFactory>> get_factories() { }
        private System.Void RegisterFactory(UnityEngine.UIElements.IBaseUxmlObjectFactory factory) { }
        private System.Boolean TryGetFactories(System.String fullTypeName, System.Collections.Generic.List<UnityEngine.UIElements.IBaseUxmlObjectFactory>& factoryList) { }
        private System.Void RegisterEngineFactories() { }
        private System.Void RegisterUserFactories() { }

    }

    // TypeToken: 0x20002C7
    public class UxmlTypeRestriction, IEquatable`1
    {
        // Methods
        private System.Boolean Equals(UnityEngine.UIElements.UxmlTypeRestriction other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002C8
    public class UxmlEnumeration : UxmlTypeRestriction
    {
        // Fields
        private System.Collections.Generic.List<System.String> m_Values;        // 0x10

        // Methods
        private System.Collections.Generic.IEnumerable<System.String> get_values() { }
        private System.Void set_values(System.Collections.Generic.IEnumerable<System.String> value) { }
        private System.Boolean Equals(UnityEngine.UIElements.UxmlTypeRestriction other) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002C9
    public class VisualElementAsset : UxmlAsset, ISerializationCallbackReceiver
    {
        // Fields
        private System.String m_Name;        // 0x30
        private System.Int32 m_RuleIndex;        // 0x38
        private System.String m_Text;        // 0x40
        private UnityEngine.UIElements.PickingMode m_PickingMode;        // 0x48
        private System.String[] m_Classes;        // 0x50
        private System.Collections.Generic.List<System.String> m_StylesheetPaths;        // 0x58
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> m_Stylesheets;        // 0x60
        private System.Boolean m_SkipClone;        // 0x68

        // Methods
        private System.Int32 get_ruleIndex() { }
        private System.String[] get_classes() { }
        private System.Collections.Generic.List<System.String> get_stylesheetPaths() { }
        private System.Boolean get_hasStylesheetPaths() { }
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> get_stylesheets() { }
        private System.Boolean get_hasStylesheets() { }
        private System.Boolean get_skipClone() { }
        private System.Void OnBeforeSerialize() { }
        private System.Void OnAfterDeserialize() { }

    }

    // TypeToken: 0x20002CA
    public class VisualElementFactoryRegistry
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>> s_Factories;        // 0x0

        // Methods
        private System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>> get_factories() { }
        private System.Void RegisterFactory(UnityEngine.UIElements.IUxmlFactory factory) { }
        private System.Boolean TryGetValue(System.String fullTypeName, System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>& factoryList) { }
        private System.Void RegisterEngineFactories() { }
        private System.Void RegisterUserFactories() { }

    }

    // TypeToken: 0x20002CB
    public class VisualTreeAsset : ScriptableObject
    {
        // Fields
        private static System.String LinkedVEAInTemplatePropertyName;        // 0x0
        private System.Boolean m_ImportedWithErrors;        // 0x18
        private System.Boolean m_ImportedWithWarnings;        // 0x19
        private static readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> s_TemporarySlotInsertionPoints;        // 0x8
        private System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.UsingEntry> m_Usings;        // 0x20
        private UnityEngine.UIElements.StyleSheet inlineSheet;        // 0x28
        private System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> m_VisualElementAssets;        // 0x30
        private System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> m_TemplateAssets;        // 0x38
        private System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.UxmlObjectEntry> m_UxmlObjectEntries;        // 0x40
        private System.Collections.Generic.List<System.Int32> m_UxmlObjectIds;        // 0x48
        private System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.AssetEntry> m_AssetEntries;        // 0x50
        private System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> m_Slots;        // 0x58
        private System.Int32 m_ContentContainerId;        // 0x60
        private System.Int32 m_ContentHash;        // 0x64

        // Methods
        private System.Boolean get_importedWithErrors() { }
        private System.Void set_importedWithErrors(System.Boolean value) { }
        private System.Boolean get_importedWithWarnings() { }
        private System.Void set_importedWithWarnings(System.Boolean value) { }
        private System.Int32 GetNextChildSerialNumber() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset> get_templateDependencies() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet> get_stylesheets() { }
        private System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> get_visualElementAssets() { }
        private System.Void set_visualElementAssets(System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> value) { }
        private System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> get_templateAssets() { }
        private System.Void set_templateAssets(System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> value) { }
        private System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.UxmlObjectEntry> get_uxmlObjectEntries() { }
        private System.Collections.Generic.List<System.Int32> get_uxmlObjectIds() { }
        private System.Void RegisterUxmlObject(UnityEngine.UIElements.UxmlObjectAsset uxmlObjectAsset) { }
        private System.Collections.Generic.List<T> GetUxmlObjects(UnityEngine.UIElements.IUxmlAttributes asset, UnityEngine.UIElements.CreationContext cc) { }
        private System.Boolean AssetEntryExists(System.String path, System.Type type) { }
        private System.Void RegisterAssetEntry(System.String path, System.Type type, UnityEngine.Object asset) { }
        private T GetAsset(System.String path) { }
        private UnityEngine.UIElements.VisualTreeAsset.UxmlObjectEntry GetUxmlObjectEntry(System.Int32 id) { }
        private UnityEngine.UIElements.IBaseUxmlObjectFactory GetUxmlObjectFactory(UnityEngine.UIElements.UxmlObjectAsset uxmlObjectAsset) { }
        private System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> get_slots() { }
        private System.Void set_slots(System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> value) { }
        private System.Int32 get_contentContainerId() { }
        private System.Void set_contentContainerId(System.Int32 value) { }
        private UnityEngine.UIElements.TemplateContainer Instantiate() { }
        private UnityEngine.UIElements.TemplateContainer Instantiate(System.String bindingPath) { }
        private UnityEngine.UIElements.TemplateContainer CloneTree() { }
        private UnityEngine.UIElements.TemplateContainer CloneTree(System.String bindingPath) { }
        private System.Void CloneTree(UnityEngine.UIElements.VisualElement target) { }
        private System.Void CloneTree(UnityEngine.UIElements.VisualElement target, System.Int32& firstElementIndex, System.Int32& elementAddedCount) { }
        private System.Void CloneTree(UnityEngine.UIElements.VisualElement target, System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> attributeOverrides) { }
        private UnityEngine.UIElements.VisualElement CloneSetupRecursively(UnityEngine.UIElements.VisualElementAsset root, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset>> idToChildren, UnityEngine.UIElements.CreationContext context) { }
        private System.Int32 CompareForOrder(UnityEngine.UIElements.VisualElementAsset a, UnityEngine.UIElements.VisualElementAsset b) { }
        private System.Boolean TryGetSlotInsertionPoint(System.Int32 insertionPointId, System.String& slotName) { }
        private UnityEngine.UIElements.VisualTreeAsset ResolveTemplate(System.String templateName) { }
        private UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.VisualElementAsset asset, UnityEngine.UIElements.CreationContext ctx) { }
        private System.Void AssignClassListFromAssetToElement(UnityEngine.UIElements.VisualElementAsset asset, UnityEngine.UIElements.VisualElement element) { }
        private System.Void AssignStyleSheetFromAssetToElement(UnityEngine.UIElements.VisualElementAsset asset, UnityEngine.UIElements.VisualElement element) { }
        private System.Int32 get_contentHash() { }
        private System.Void set_contentHash(System.Int32 value) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private UnityEngine.UIElements.VisualElement <Create>g__CreateError|65_0(UnityEngine.UIElements.VisualTreeAsset.<>c__DisplayClass65_0& ) { }

    }

    // TypeToken: 0x20002D6
    public struct CreationContext, IEquatable`1
    {
        // Fields
        public static readonly UnityEngine.UIElements.CreationContext Default;        // 0x0
        private UnityEngine.UIElements.VisualElement <target>k__BackingField;        // 0x10
        private UnityEngine.UIElements.VisualTreeAsset <visualTreeAsset>k__BackingField;        // 0x18
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> <slotInsertionPoints>k__BackingField;        // 0x20
        private System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> <attributeOverrides>k__BackingField;        // 0x28

        // Methods
        private UnityEngine.UIElements.VisualElement get_target() { }
        private System.Void set_target(UnityEngine.UIElements.VisualElement value) { }
        private UnityEngine.UIElements.VisualTreeAsset get_visualTreeAsset() { }
        private System.Void set_visualTreeAsset(UnityEngine.UIElements.VisualTreeAsset value) { }
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> get_slotInsertionPoints() { }
        private System.Void set_slotInsertionPoints(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> value) { }
        private System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> get_attributeOverrides() { }
        private System.Void set_attributeOverrides(System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> value) { }
        private System.Void .ctor(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, UnityEngine.UIElements.VisualTreeAsset vta, UnityEngine.UIElements.VisualElement target) { }
        private System.Void .ctor(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> attributeOverrides, UnityEngine.UIElements.VisualTreeAsset vta, UnityEngine.UIElements.VisualElement target) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.UIElements.CreationContext other) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

}

namespace UnityEngine.UIElements.Experimental
{

    // TypeToken: 0x200035E
    public class Easing
    {
        // Methods
        private System.Single Linear(System.Single t) { }
        private System.Single InSine(System.Single t) { }
        private System.Single OutSine(System.Single t) { }
        private System.Single InOutSine(System.Single t) { }
        private System.Single InQuad(System.Single t) { }
        private System.Single OutQuad(System.Single t) { }
        private System.Single InOutQuad(System.Single t) { }
        private System.Single InCubic(System.Single t) { }
        private System.Single OutCubic(System.Single t) { }
        private System.Single InOutCubic(System.Single t) { }
        private System.Single InPower(System.Single t, System.Int32 power) { }
        private System.Single OutPower(System.Single t, System.Int32 power) { }
        private System.Single InOutPower(System.Single t, System.Int32 power) { }
        private System.Single InBounce(System.Single t) { }
        private System.Single OutBounce(System.Single t) { }
        private System.Single InOutBounce(System.Single t) { }
        private System.Single InElastic(System.Single t) { }
        private System.Single OutElastic(System.Single t) { }
        private System.Single InOutElastic(System.Single t) { }
        private System.Single InBack(System.Single t) { }
        private System.Single OutBack(System.Single t) { }
        private System.Single InOutBack(System.Single t) { }
        private System.Single InCirc(System.Single t) { }
        private System.Single OutCirc(System.Single t) { }
        private System.Single InOutCirc(System.Single t) { }

    }

    // TypeToken: 0x200035F
    public struct StyleValues
    {
        // Fields
        private UnityEngine.UIElements.StyleValueCollection m_StyleValues;        // 0x10

        // Methods
        private System.Void set_top(System.Single value) { }
        private System.Void set_left(System.Single value) { }
        private System.Void set_width(System.Single value) { }
        private System.Void set_height(System.Single value) { }
        private System.Void set_right(System.Single value) { }
        private System.Void set_bottom(System.Single value) { }
        private System.Void set_color(UnityEngine.Color value) { }
        private System.Void set_backgroundColor(UnityEngine.Color value) { }
        private System.Void set_unityBackgroundImageTintColor(UnityEngine.Color value) { }
        private System.Void set_borderColor(UnityEngine.Color value) { }
        private System.Void set_marginLeft(System.Single value) { }
        private System.Void set_marginTop(System.Single value) { }
        private System.Void set_marginRight(System.Single value) { }
        private System.Void set_marginBottom(System.Single value) { }
        private System.Void set_paddingLeft(System.Single value) { }
        private System.Single get_paddingTop() { }
        private System.Void set_paddingTop(System.Single value) { }
        private System.Void set_paddingRight(System.Single value) { }
        private System.Void set_paddingBottom(System.Single value) { }
        private System.Void set_borderLeftWidth(System.Single value) { }
        private System.Void set_borderRightWidth(System.Single value) { }
        private System.Void set_borderTopWidth(System.Single value) { }
        private System.Void set_borderBottomWidth(System.Single value) { }
        private System.Void set_borderTopLeftRadius(System.Single value) { }
        private System.Void set_borderTopRightRadius(System.Single value) { }
        private System.Void set_borderBottomLeftRadius(System.Single value) { }
        private System.Void set_borderBottomRightRadius(System.Single value) { }
        private System.Void set_opacity(System.Single value) { }
        private System.Void set_flexGrow(System.Single value) { }
        private System.Void set_flexShrink(System.Single value) { }
        private System.Void SetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Single value) { }
        private System.Void SetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color value) { }
        private UnityEngine.UIElements.StyleValueCollection Values() { }

    }

    // TypeToken: 0x2000360
    public interface ITransitionAnimations
    {
        // Methods
        private UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(UnityEngine.UIElements.Experimental.StyleValues to, System.Int32 durationMs) { }

    }

    // TypeToken: 0x2000361
    public class Lerp
    {
        // Methods
        private System.Single Interpolate(System.Single start, System.Single end, System.Single ratio) { }
        private UnityEngine.Color Interpolate(UnityEngine.Color start, UnityEngine.Color end, System.Single ratio) { }
        private UnityEngine.UIElements.Experimental.StyleValues Interpolate(UnityEngine.UIElements.Experimental.StyleValues start, UnityEngine.UIElements.Experimental.StyleValues end, System.Single ratio) { }

    }

    // TypeToken: 0x2000362
    public interface IValueAnimationUpdate
    {
        // Methods
        private System.Void Tick(System.Int64 currentTimeMs) { }

    }

    // TypeToken: 0x2000363
    public class ValueAnimation`1, IValueAnimationUpdate
    {
        // Fields
        private System.Int64 m_StartTimeMs;        // 0x0
        private System.Int32 m_DurationMs;        // 0x0
        private System.Func<System.Single,System.Single> <easingCurve>k__BackingField;        // 0x0
        private System.Boolean <isRunning>k__BackingField;        // 0x0
        private System.Action <onAnimationCompleted>k__BackingField;        // 0x0
        private System.Boolean <autoRecycle>k__BackingField;        // 0x0
        private System.Boolean <recycled>k__BackingField;        // 0x0
        private static UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.Experimental.ValueAnimation<T>> sObjectPool;        // 0x0
        private UnityEngine.UIElements.VisualElement <owner>k__BackingField;        // 0x0
        private System.Action<UnityEngine.UIElements.VisualElement,T> <valueUpdated>k__BackingField;        // 0x0
        private System.Func<UnityEngine.UIElements.VisualElement,T> <initialValue>k__BackingField;        // 0x0
        private System.Func<T,T,System.Single,T> <interpolator>k__BackingField;        // 0x0
        private T _from;        // 0x0
        private System.Boolean fromValueSet;        // 0x0
        private T <to>k__BackingField;        // 0x0

        // Methods
        private System.Int32 get_durationMs() { }
        private System.Void set_durationMs(System.Int32 value) { }
        private System.Func<System.Single,System.Single> get_easingCurve() { }
        private System.Void set_easingCurve(System.Func<System.Single,System.Single> value) { }
        private System.Boolean get_isRunning() { }
        private System.Void set_isRunning(System.Boolean value) { }
        private System.Action get_onAnimationCompleted() { }
        private System.Void set_onAnimationCompleted(System.Action value) { }
        private System.Boolean get_autoRecycle() { }
        private System.Void set_autoRecycle(System.Boolean value) { }
        private System.Boolean get_recycled() { }
        private System.Void set_recycled(System.Boolean value) { }
        private UnityEngine.UIElements.VisualElement get_owner() { }
        private System.Void set_owner(UnityEngine.UIElements.VisualElement value) { }
        private System.Action<UnityEngine.UIElements.VisualElement,T> get_valueUpdated() { }
        private System.Void set_valueUpdated(System.Action<UnityEngine.UIElements.VisualElement,T> value) { }
        private System.Func<UnityEngine.UIElements.VisualElement,T> get_initialValue() { }
        private System.Void set_initialValue(System.Func<UnityEngine.UIElements.VisualElement,T> value) { }
        private System.Func<T,T,System.Single,T> get_interpolator() { }
        private System.Void set_interpolator(System.Func<T,T,System.Single,T> value) { }
        private T get_from() { }
        private System.Void set_from(T value) { }
        private T get_to() { }
        private System.Void set_to(T value) { }
        private System.Void .ctor() { }
        private System.Void Start() { }
        private System.Void Stop() { }
        private System.Void Recycle() { }
        private System.Void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(System.Int64 currentTimeMs) { }
        private System.Void SetDefaultValues() { }
        private System.Void Unregister() { }
        private System.Void Register() { }
        private System.Void SetOwner(UnityEngine.UIElements.VisualElement e) { }
        private System.Void CheckNotRecycled() { }
        private UnityEngine.UIElements.Experimental.ValueAnimation<T> Create(UnityEngine.UIElements.VisualElement e, System.Func<T,T,System.Single,T> interpolator) { }
        private UnityEngine.UIElements.Experimental.ValueAnimation<T> KeepAlive() { }
        private System.Void .cctor() { }

    }

}

namespace UnityEngine.UIElements.Internal
{

    // TypeToken: 0x2000327
    public class MultiColumnHeaderColumnMovePreview : VisualElement
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000328
    public class MultiColumnHeaderColumnMoveLocationPreview : VisualElement
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String visualUssClassName;        // 0x8

        // Methods
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000329
    public class ColumnMover : PointerManipulator
    {
        // Fields
        private System.Single m_StartPos;        // 0x38
        private System.Single m_LastPos;        // 0x3C
        private System.Boolean m_Active;        // 0x40
        private System.Boolean m_Moving;        // 0x41
        private System.Boolean m_Cancelled;        // 0x42
        private UnityEngine.UIElements.Internal.MultiColumnCollectionHeader m_Header;        // 0x48
        private UnityEngine.UIElements.VisualElement m_PreviewElement;        // 0x50
        private UnityEngine.UIElements.Internal.MultiColumnHeaderColumnMoveLocationPreview m_LocationPreviewElement;        // 0x58
        private UnityEngine.UIElements.Column m_ColumnToMove;        // 0x60
        private System.Single m_ColumnToMovePos;        // 0x68
        private System.Single m_ColumnToMoveWidth;        // 0x6C
        private UnityEngine.UIElements.Column m_DestinationColumn;        // 0x70
        private System.Boolean m_MoveBeforeDestination;        // 0x78
        private UnityEngine.UIElements.ColumnLayout <columnLayout>k__BackingField;        // 0x80
        private System.Action<UnityEngine.UIElements.Internal.ColumnMover> activeChanged;        // 0x88
        private System.Action<UnityEngine.UIElements.Internal.ColumnMover> movingChanged;        // 0x90

        // Methods
        private UnityEngine.UIElements.ColumnLayout get_columnLayout() { }
        private System.Void set_columnLayout(UnityEngine.UIElements.ColumnLayout value) { }
        private System.Boolean get_active() { }
        private System.Void set_active(System.Boolean value) { }
        private System.Boolean get_moving() { }
        private System.Void set_moving(System.Boolean value) { }
        private System.Void add_activeChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value) { }
        private System.Void remove_activeChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value) { }
        private System.Void add_movingChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value) { }
        private System.Void remove_movingChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value) { }
        private System.Void .ctor() { }
        private System.Void RegisterCallbacksOnTarget() { }
        private System.Void UnregisterCallbacksFromTarget() { }
        private System.Void OnMouseDown(UnityEngine.UIElements.MouseDownEvent evt) { }
        private System.Void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent evt) { }
        private System.Void OnMouseUp(UnityEngine.UIElements.MouseUpEvent evt) { }
        private System.Void OnMouseCaptureOut(UnityEngine.UIElements.MouseCaptureOutEvent evt) { }
        private System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt) { }
        private System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt) { }
        private System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt) { }
        private System.Void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt) { }
        private System.Void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent evt) { }
        private System.Boolean IsNotMouseEvent(System.Int32 pointerId) { }
        private System.Void ProcessCancelEvent(UnityEngine.UIElements.EventBase evt, System.Int32 pointerId) { }
        private System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent e) { }
        private System.Void ProcessDownEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId) { }
        private System.Void ProcessMoveEvent(UnityEngine.UIElements.EventBase e, UnityEngine.Vector2 localPosition) { }
        private System.Void ProcessUpEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId) { }
        private System.Void BeginDragMove(System.Single pos) { }
        private System.Void DragMove(System.Single pos) { }
        private System.Void UpdatePreviewPosition() { }
        private System.Void UpdateMoveLocation() { }
        private System.Void EndDragMove(System.Boolean cancelled) { }

    }

    // TypeToken: 0x200032A
    public class MultiColumnHeaderColumnResizePreview : VisualElement
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String visualUssClassName;        // 0x8

        // Methods
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200032B
    public class ColumnResizer : PointerManipulator
    {
        // Fields
        private UnityEngine.Vector2 m_Start;        // 0x38
        protected System.Boolean m_Active;        // 0x40
        private System.Boolean m_Resizing;        // 0x41
        private UnityEngine.UIElements.Internal.MultiColumnCollectionHeader m_Header;        // 0x48
        private UnityEngine.UIElements.Column m_Column;        // 0x50
        private UnityEngine.UIElements.VisualElement m_PreviewElement;        // 0x58
        private UnityEngine.UIElements.ColumnLayout <columnLayout>k__BackingField;        // 0x60
        private System.Boolean <preview>k__BackingField;        // 0x68

        // Methods
        private UnityEngine.UIElements.ColumnLayout get_columnLayout() { }
        private System.Void set_columnLayout(UnityEngine.UIElements.ColumnLayout value) { }
        private System.Boolean get_preview() { }
        private System.Void set_preview(System.Boolean value) { }
        private System.Void .ctor(UnityEngine.UIElements.Column column) { }
        private System.Void RegisterCallbacksOnTarget() { }
        private System.Void UnregisterCallbacksFromTarget() { }
        private System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent e) { }
        private System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent e) { }
        private System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent e) { }
        private System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent e) { }
        private System.Void BeginDragResize(System.Single pos) { }
        private System.Void DragResize(System.Single pos) { }
        private System.Void UpdatePreviewPosition() { }
        private System.Void EndDragResize(System.Single pos, System.Boolean cancelled) { }

    }

    // TypeToken: 0x200032C
    public class MultiColumnCollectionHeader : VisualElement, IDisposable
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String columnContainerUssClassName;        // 0x8
        public static readonly System.String handleContainerUssClassName;        // 0x10
        public static readonly System.String reorderableUssClassName;        // 0x18
        private System.Boolean m_SortingEnabled;        // 0x3C0
        private System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> m_SortedColumns;        // 0x3C8
        private UnityEngine.UIElements.SortColumnDescriptions m_SortDescriptions;        // 0x3D0
        private System.Collections.Generic.List<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.SortedColumnState> m_OldSortedColumnStates;        // 0x3D8
        private System.Boolean m_SortingUpdatesTemporarilyDisabled;        // 0x3E0
        private UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ViewState m_ViewState;        // 0x3E8
        private System.Boolean m_ApplyingViewState;        // 0x3F0
        private System.Boolean m_DoLayoutScheduled;        // 0x3F1
        private readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.Column,UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ColumnData> <columnDataMap>k__BackingField;        // 0x3F8
        private readonly UnityEngine.UIElements.ColumnLayout <columnLayout>k__BackingField;        // 0x400
        private readonly UnityEngine.UIElements.VisualElement <columnContainer>k__BackingField;        // 0x408
        private readonly UnityEngine.UIElements.VisualElement <resizeHandleContainer>k__BackingField;        // 0x410
        private readonly UnityEngine.UIElements.Columns <columns>k__BackingField;        // 0x418
        private System.Action<System.Int32,System.Single> columnResized;        // 0x420
        private System.Action columnSortingChanged;        // 0x428
        private System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> contextMenuPopulateEvent;        // 0x430
        private System.Action viewDataRestored;        // 0x438

        // Methods
        private System.Boolean get_isApplyingViewState() { }
        private System.Collections.Generic.Dictionary<UnityEngine.UIElements.Column,UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ColumnData> get_columnDataMap() { }
        private UnityEngine.UIElements.ColumnLayout get_columnLayout() { }
        private UnityEngine.UIElements.VisualElement get_columnContainer() { }
        private UnityEngine.UIElements.VisualElement get_resizeHandleContainer() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.UIElements.SortColumnDescription> get_sortedColumns() { }
        private UnityEngine.UIElements.SortColumnDescriptions get_sortDescriptions() { }
        private System.Void set_sortDescriptions(UnityEngine.UIElements.SortColumnDescriptions value) { }
        private UnityEngine.UIElements.Columns get_columns() { }
        private System.Boolean get_sortingEnabled() { }
        private System.Void set_sortingEnabled(System.Boolean value) { }
        private System.Void add_columnResized(System.Action<System.Int32,System.Single> value) { }
        private System.Void remove_columnResized(System.Action<System.Int32,System.Single> value) { }
        private System.Void add_columnSortingChanged(System.Action value) { }
        private System.Void remove_columnSortingChanged(System.Action value) { }
        private System.Void add_contextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value) { }
        private System.Void remove_contextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value) { }
        private System.Void add_viewDataRestored(System.Action value) { }
        private System.Void remove_viewDataRestored(System.Action value) { }
        private System.Void .ctor(UnityEngine.UIElements.Columns columns, UnityEngine.UIElements.SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }
        private System.Void ScheduleDoLayout() { }
        private System.Void ResizeToFit() { }
        private System.Void UpdateSortedColumns() { }
        private System.Void UpdateColumnControls() { }
        private System.Void OnColumnAdded(UnityEngine.UIElements.Column column, System.Int32 index) { }
        private System.Void OnColumnAdded(UnityEngine.UIElements.Column column) { }
        private System.Void OnColumnRemoved(UnityEngine.UIElements.Column column) { }
        private System.Void OnColumnChanged(UnityEngine.UIElements.Column column, UnityEngine.UIElements.ColumnDataType type) { }
        private System.Void OnColumnReordered(UnityEngine.UIElements.Column column, System.Int32 from, System.Int32 to) { }
        private System.Void OnColumnResized(UnityEngine.UIElements.Column column) { }
        private System.Void OnContextualMenuManipulator(UnityEngine.UIElements.ContextualMenuPopulateEvent evt) { }
        private System.Void OnMoveManipulatorActivated(UnityEngine.UIElements.Internal.ColumnMover mover) { }
        private System.Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e) { }
        private System.Void DoLayout() { }
        private System.Void OnColumnControlGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt) { }
        private System.Void OnColumnClicked(UnityEngine.UIElements.EventBase evt) { }
        private System.Void UpdateSortColumnDescriptionsOnClick(UnityEngine.UIElements.Column column, UnityEngine.EventModifiers modifiers) { }
        private System.Void ScrollHorizontally(System.Single horizontalOffset) { }
        private System.Void RaiseColumnResized(System.Int32 columnIndex) { }
        private System.Void RaiseColumnSortingChanged() { }
        private System.Void ApplyColumnSorting() { }
        private System.Void UpdateSortingStatus() { }
        private System.Void OnViewDataReady() { }
        private System.Void SaveViewState() { }
        private System.Void Dispose() { }
        private System.Void .cctor() { }
        private System.Void <OnContextualMenuManipulator>b__65_0(UnityEngine.UIElements.DropdownMenuAction a) { }

    }

    // TypeToken: 0x2000333
    public class MultiColumnHeaderColumnSortIndicator : VisualElement
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String arrowUssClassName;        // 0x8
        public static readonly System.String indexLabelUssClassName;        // 0x10
        private UnityEngine.UIElements.Label m_IndexLabel;        // 0x3C0

        // Methods
        private System.Void set_sortOrderLabel(System.String value) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000334
    public class MultiColumnHeaderColumnIcon : Image
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        private System.Boolean <isImageInline>k__BackingField;        // 0x408

        // Methods
        private System.Boolean get_isImageInline() { }
        private System.Void set_isImageInline(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void UpdateClassList() { }
        private System.Void .cctor() { }
        private System.Void <.ctor>b__5_0(UnityEngine.UIElements.CustomStyleResolvedEvent evt) { }

    }

    // TypeToken: 0x2000335
    public class MultiColumnHeaderColumn : VisualElement
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String sortableUssClassName;        // 0x8
        public static readonly System.String sortedAscendingUssClassName;        // 0x10
        public static readonly System.String sortedDescendingUssClassName;        // 0x18
        public static readonly System.String movingUssClassName;        // 0x20
        public static readonly System.String contentContainerUssClassName;        // 0x28
        public static readonly System.String contentUssClassName;        // 0x30
        public static readonly System.String defaultContentUssClassName;        // 0x38
        public static readonly System.String hasIconUssClassName;        // 0x40
        public static readonly System.String hasTitleUssClassName;        // 0x48
        public static readonly System.String titleUssClassName;        // 0x50
        public static readonly System.String iconElementName;        // 0x58
        public static readonly System.String titleElementName;        // 0x60
        private static readonly System.String s_BoundVEPropertyName;        // 0x68
        private static readonly System.String s_BindingCallbackVEPropertyName;        // 0x70
        private static readonly System.String s_UnbindingCallbackVEPropertyName;        // 0x78
        private static readonly System.String s_DestroyCallbackVEPropertyName;        // 0x80
        private UnityEngine.UIElements.VisualElement m_ContentContainer;        // 0x3C0
        private UnityEngine.UIElements.VisualElement m_Content;        // 0x3C8
        private UnityEngine.UIElements.Internal.MultiColumnHeaderColumnSortIndicator m_SortIndicatorContainer;        // 0x3D0
        private UnityEngine.UIElements.IVisualElementScheduledItem m_ScheduledHeaderTemplateUpdate;        // 0x3D8
        private UnityEngine.UIElements.Clickable <clickable>k__BackingField;        // 0x3E0
        private UnityEngine.UIElements.Internal.ColumnMover <mover>k__BackingField;        // 0x3E8
        private UnityEngine.UIElements.Column <column>k__BackingField;        // 0x3F0

        // Methods
        private UnityEngine.UIElements.Clickable get_clickable() { }
        private System.Void set_clickable(UnityEngine.UIElements.Clickable value) { }
        private UnityEngine.UIElements.Internal.ColumnMover get_mover() { }
        private System.Void set_mover(UnityEngine.UIElements.Internal.ColumnMover value) { }
        private System.Void set_sortOrderLabel(System.String value) { }
        private UnityEngine.UIElements.Column get_column() { }
        private System.Void set_column(UnityEngine.UIElements.Column value) { }
        private UnityEngine.UIElements.VisualElement get_content() { }
        private System.Void set_content(UnityEngine.UIElements.VisualElement value) { }
        private System.Boolean get_isContentBound() { }
        private System.Void set_isContentBound(System.Boolean value) { }
        private System.Void .ctor(UnityEngine.UIElements.Column column) { }
        private System.Void InitManipulators() { }
        private System.Void UpdateDataFromColumn() { }
        private System.Void BindHeaderContent() { }
        private System.Void UnbindHeaderContent() { }
        private System.Void DestroyHeaderContent() { }
        private UnityEngine.UIElements.VisualElement CreateDefaultHeaderContent() { }
        private System.Void DefaultBindHeaderContent(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void UpdateHeaderTemplate() { }
        private System.Void UpdateGeometryFromColumn() { }
        private System.Void .cctor() { }
        private System.Void <.ctor>b__45_0(UnityEngine.UIElements.Column c, UnityEngine.UIElements.ColumnDataType role) { }
        private System.Void <.ctor>b__45_1(UnityEngine.UIElements.Column c) { }
        private System.Void <InitManipulators>b__46_0(UnityEngine.UIElements.Internal.ColumnMover mv) { }

    }

    // TypeToken: 0x2000336
    public class MultiColumnHeaderColumnResizeHandle : VisualElement
    {
        // Fields
        public static readonly System.String ussClassName;        // 0x0
        public static readonly System.String dragAreaUssClassName;        // 0x8
        private readonly UnityEngine.UIElements.VisualElement <dragArea>k__BackingField;        // 0x3C0

        // Methods
        private UnityEngine.UIElements.VisualElement get_dragArea() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

namespace UnityEngine.UIElements.StyleSheets
{

    // TypeToken: 0x2000337
    public class HierarchyTraversal
    {
        // Methods
        private System.Void Traverse(UnityEngine.UIElements.VisualElement element) { }
        private System.Void TraverseRecursive(UnityEngine.UIElements.VisualElement element, System.Int32 depth) { }
        private System.Void Recurse(UnityEngine.UIElements.VisualElement element, System.Int32 depth) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000338
    public class StylePropertyUtil
    {
        // Fields
        private static readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.StyleSheets.StylePropertyId> s_AnimatablePropertiesHash;        // 0x0
        private static readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyId> s_NameToId;        // 0x8
        private static readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StylePropertyId,System.String> s_IdToName;        // 0x10
        private static readonly UnityEngine.UIElements.StyleSheets.StylePropertyId[] s_AnimatableProperties;        // 0x18

        // Methods
        private System.Void .cctor() { }
        private System.Boolean IsAnimatable(UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }
        private System.Boolean TryGetEnumIntValue(UnityEngine.UIElements.StyleSheets.StyleEnumType enumType, System.String value, System.Int32& intValue) { }
        private System.Boolean IsMatchingShorthand(UnityEngine.UIElements.StyleSheets.StylePropertyId shorthand, UnityEngine.UIElements.StyleSheets.StylePropertyId id) { }

    }

    // TypeToken: 0x2000339
    public class InitialStyle
    {
        // Fields
        private static UnityEngine.UIElements.ComputedStyle s_InitialStyle;        // 0x0

        // Methods
        private UnityEngine.UIElements.ComputedStyle& Get() { }
        private UnityEngine.UIElements.ComputedStyle Acquire() { }
        private System.Void .cctor() { }
        private UnityEngine.UIElements.Align get_alignContent() { }
        private UnityEngine.UIElements.Align get_alignItems() { }
        private UnityEngine.UIElements.Align get_alignSelf() { }
        private UnityEngine.Color get_backgroundColor() { }
        private UnityEngine.UIElements.Background get_backgroundImage() { }
        private UnityEngine.Color get_borderBottomColor() { }
        private UnityEngine.UIElements.Length get_borderBottomLeftRadius() { }
        private UnityEngine.UIElements.Length get_borderBottomRightRadius() { }
        private System.Single get_borderBottomWidth() { }
        private UnityEngine.Color get_borderLeftColor() { }
        private System.Single get_borderLeftWidth() { }
        private UnityEngine.Color get_borderRightColor() { }
        private System.Single get_borderRightWidth() { }
        private UnityEngine.Color get_borderTopColor() { }
        private UnityEngine.UIElements.Length get_borderTopLeftRadius() { }
        private UnityEngine.UIElements.Length get_borderTopRightRadius() { }
        private System.Single get_borderTopWidth() { }
        private UnityEngine.UIElements.Length get_bottom() { }
        private UnityEngine.Color get_color() { }
        private UnityEngine.UIElements.Cursor get_cursor() { }
        private UnityEngine.UIElements.DisplayStyle get_display() { }
        private UnityEngine.UIElements.Length get_flexBasis() { }
        private UnityEngine.UIElements.FlexDirection get_flexDirection() { }
        private System.Single get_flexGrow() { }
        private System.Single get_flexShrink() { }
        private UnityEngine.UIElements.Wrap get_flexWrap() { }
        private UnityEngine.UIElements.Length get_fontSize() { }
        private UnityEngine.UIElements.Length get_height() { }
        private UnityEngine.UIElements.Justify get_justifyContent() { }
        private UnityEngine.UIElements.Length get_left() { }
        private UnityEngine.UIElements.Length get_letterSpacing() { }
        private UnityEngine.UIElements.Length get_marginBottom() { }
        private UnityEngine.UIElements.Length get_marginLeft() { }
        private UnityEngine.UIElements.Length get_marginRight() { }
        private UnityEngine.UIElements.Length get_marginTop() { }
        private UnityEngine.UIElements.Length get_maxHeight() { }
        private UnityEngine.UIElements.Length get_maxWidth() { }
        private UnityEngine.UIElements.Length get_minHeight() { }
        private UnityEngine.UIElements.Length get_minWidth() { }
        private System.Single get_opacity() { }
        private UnityEngine.UIElements.OverflowInternal get_overflow() { }
        private UnityEngine.UIElements.Length get_paddingBottom() { }
        private UnityEngine.UIElements.Length get_paddingLeft() { }
        private UnityEngine.UIElements.Length get_paddingRight() { }
        private UnityEngine.UIElements.Length get_paddingTop() { }
        private UnityEngine.UIElements.Position get_position() { }
        private UnityEngine.UIElements.Length get_right() { }
        private UnityEngine.UIElements.Rotate get_rotate() { }
        private UnityEngine.UIElements.Scale get_scale() { }
        private UnityEngine.UIElements.TextOverflow get_textOverflow() { }
        private UnityEngine.UIElements.TextShadow get_textShadow() { }
        private UnityEngine.UIElements.Length get_top() { }
        private UnityEngine.UIElements.TransformOrigin get_transformOrigin() { }
        private System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDelay() { }
        private System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDuration() { }
        private System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> get_transitionProperty() { }
        private System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> get_transitionTimingFunction() { }
        private UnityEngine.UIElements.Translate get_translate() { }
        private UnityEngine.Color get_unityBackgroundImageTintColor() { }
        private UnityEngine.ScaleMode get_unityBackgroundScaleMode() { }
        private UnityEngine.Font get_unityFont() { }
        private UnityEngine.UIElements.FontDefinition get_unityFontDefinition() { }
        private UnityEngine.FontStyle get_unityFontStyleAndWeight() { }
        private UnityEngine.UIElements.OverflowClipBox get_unityOverflowClipBox() { }
        private UnityEngine.UIElements.Length get_unityParagraphSpacing() { }
        private System.Int32 get_unitySliceBottom() { }
        private System.Int32 get_unitySliceLeft() { }
        private System.Int32 get_unitySliceRight() { }
        private System.Int32 get_unitySliceTop() { }
        private UnityEngine.TextAnchor get_unityTextAlign() { }
        private UnityEngine.Color get_unityTextOutlineColor() { }
        private System.Single get_unityTextOutlineWidth() { }
        private UnityEngine.UIElements.TextOverflowPosition get_unityTextOverflowPosition() { }
        private UnityEngine.UIElements.Visibility get_visibility() { }
        private UnityEngine.UIElements.WhiteSpace get_whiteSpace() { }
        private UnityEngine.UIElements.Length get_width() { }
        private UnityEngine.UIElements.Length get_wordSpacing() { }

    }

    // TypeToken: 0x200033A
    public class ShorthandApplicator
    {
        // Fields
        private static System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> s_TransitionDelayList;        // 0x0
        private static System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> s_TransitionDurationList;        // 0x8
        private static System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> s_TransitionPropertyList;        // 0x10
        private static System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> s_TransitionTimingFunctionList;        // 0x18

        // Methods
        private System.Void ApplyBorderColor(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle) { }
        private System.Void ApplyBorderRadius(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle) { }
        private System.Void ApplyBorderWidth(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle) { }
        private System.Void ApplyFlex(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle) { }
        private System.Void ApplyMargin(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle) { }
        private System.Void ApplyPadding(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle) { }
        private System.Void ApplyTransition(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle) { }
        private System.Void ApplyUnityTextOutline(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle) { }
        private System.Boolean CompileFlexShorthand(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, System.Single& grow, System.Single& shrink, UnityEngine.UIElements.Length& basis) { }
        private System.Void CompileBorderRadius(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.Length& top, UnityEngine.UIElements.Length& right, UnityEngine.UIElements.Length& bottom, UnityEngine.UIElements.Length& left) { }
        private System.Void CompileBoxArea(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.Length& top, UnityEngine.UIElements.Length& right, UnityEngine.UIElements.Length& bottom, UnityEngine.UIElements.Length& left) { }
        private System.Void CompileBoxArea(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, System.Single& top, System.Single& right, System.Single& bottom, System.Single& left) { }
        private System.Void CompileBoxArea(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.Color& top, UnityEngine.Color& right, UnityEngine.Color& bottom, UnityEngine.Color& left) { }
        private System.Void CompileTextOutline(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.Color& outlineColor, System.Single& outlineWidth) { }
        private System.Void CompileTransition(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>& outDelay, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>& outDuration, System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName>& outProperty, System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction>& outTimingFunction) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200033B
    public class StylePropertyCache
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_PropertySyntaxCache;        // 0x0
        private static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_NonTerminalValues;        // 0x8

        // Methods
        private System.Boolean TryGetSyntax(System.String name, System.String& syntax) { }
        private System.Boolean TryGetNonTerminalValue(System.String name, System.String& syntax) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200033C
    public struct StyleEnumType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType Align;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType DisplayStyle;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType EasingMode;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType FlexDirection;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType FontStyle;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType Justify;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType Overflow;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType OverflowClipBox;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType OverflowInternal;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType Position;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType ScaleMode;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType TextAnchor;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType TextOverflow;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType TextOverflowPosition;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType TransformOriginOffset;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType Visibility;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType WhiteSpace;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StyleEnumType Wrap;        // 0x0

    }

    // TypeToken: 0x200033D
    public struct StylePropertyId
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Unknown;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Custom;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId AlignContent;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId AlignItems;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId AlignSelf;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId All;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BackgroundColor;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BackgroundImage;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BorderBottomColor;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BorderBottomLeftRadius;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BorderBottomRightRadius;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BorderBottomWidth;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BorderColor;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BorderLeftColor;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BorderLeftWidth;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BorderRadius;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BorderRightColor;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BorderRightWidth;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BorderTopColor;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BorderTopLeftRadius;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BorderTopRightRadius;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BorderTopWidth;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId BorderWidth;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Bottom;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Color;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Cursor;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Display;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Flex;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId FlexBasis;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId FlexDirection;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId FlexGrow;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId FlexShrink;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId FlexWrap;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId FontSize;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Height;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId JustifyContent;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Left;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId LetterSpacing;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Margin;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId MarginBottom;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId MarginLeft;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId MarginRight;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId MarginTop;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId MaxHeight;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId MaxWidth;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId MinHeight;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId MinWidth;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Opacity;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Overflow;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Padding;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId PaddingBottom;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId PaddingLeft;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId PaddingRight;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId PaddingTop;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Position;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Right;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Rotate;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Scale;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId TextOverflow;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId TextShadow;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Top;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId TransformOrigin;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Transition;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId TransitionDelay;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId TransitionDuration;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId TransitionProperty;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId TransitionTimingFunction;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Translate;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId UnityBackgroundImageTintColor;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId UnityBackgroundScaleMode;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId UnityFont;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId UnityFontDefinition;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId UnityFontStyleAndWeight;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId UnityOverflowClipBox;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId UnityParagraphSpacing;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId UnitySliceBottom;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId UnitySliceLeft;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId UnitySliceRight;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId UnitySliceTop;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId UnityTextAlign;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId UnityTextOutline;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId UnityTextOutlineColor;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId UnityTextOutlineWidth;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId UnityTextOverflowPosition;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Visibility;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId WhiteSpace;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId Width;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.StylePropertyId WordSpacing;        // 0x0

    }

    // TypeToken: 0x200033E
    public struct Dimension, IEquatable`1
    {
        // Fields
        public UnityEngine.UIElements.StyleSheets.Dimension.Unit unit;        // 0x10
        public System.Single value;        // 0x14

        // Methods
        private System.Void .ctor(System.Single value, UnityEngine.UIElements.StyleSheets.Dimension.Unit unit) { }
        private UnityEngine.UIElements.Length ToLength() { }
        private UnityEngine.UIElements.TimeValue ToTime() { }
        private UnityEngine.UIElements.Angle ToAngle() { }
        private System.Boolean op_Equality(UnityEngine.UIElements.StyleSheets.Dimension lhs, UnityEngine.UIElements.StyleSheets.Dimension rhs) { }
        private System.Boolean Equals(UnityEngine.UIElements.StyleSheets.Dimension other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000340
    public struct ScalableImage
    {
        // Fields
        public UnityEngine.Texture2D normalImage;        // 0x10
        public UnityEngine.Texture2D highResolutionImage;        // 0x18

        // Methods
        private System.String ToString() { }

    }

    // TypeToken: 0x2000341
    public struct StylePropertyValue
    {
        // Fields
        public UnityEngine.UIElements.StyleSheet sheet;        // 0x10
        public UnityEngine.UIElements.StyleValueHandle handle;        // 0x18

    }

    // TypeToken: 0x2000342
    public struct ImageSource
    {
        // Fields
        public UnityEngine.Texture2D texture;        // 0x10
        public UnityEngine.Sprite sprite;        // 0x18
        public UnityEngine.UIElements.VectorImage vectorImage;        // 0x20
        public UnityEngine.RenderTexture renderTexture;        // 0x28

        // Methods
        private System.Boolean IsNull() { }

    }

    // TypeToken: 0x2000343
    public class StylePropertyReader
    {
        // Fields
        private static UnityEngine.UIElements.StyleSheets.StylePropertyReader.GetCursorIdFunction getCursorIdFunc;        // 0x0
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_Values;        // 0x10
        private System.Collections.Generic.List<System.Int32> m_ValueCount;        // 0x18
        private UnityEngine.UIElements.StyleVariableResolver m_Resolver;        // 0x20
        private UnityEngine.UIElements.StyleSheet m_Sheet;        // 0x28
        private UnityEngine.UIElements.StyleProperty[] m_Properties;        // 0x30
        private UnityEngine.UIElements.StyleSheets.StylePropertyId[] m_PropertyIds;        // 0x38
        private System.Int32 m_CurrentValueIndex;        // 0x40
        private System.Int32 m_CurrentPropertyIndex;        // 0x44
        private UnityEngine.UIElements.StyleProperty <property>k__BackingField;        // 0x48
        private UnityEngine.UIElements.StyleSheets.StylePropertyId <propertyId>k__BackingField;        // 0x50
        private System.Int32 <valueCount>k__BackingField;        // 0x54
        private System.Single <dpiScaling>k__BackingField;        // 0x58

        // Methods
        private UnityEngine.UIElements.StyleProperty get_property() { }
        private System.Void set_property(UnityEngine.UIElements.StyleProperty value) { }
        private UnityEngine.UIElements.StyleSheets.StylePropertyId get_propertyId() { }
        private System.Void set_propertyId(UnityEngine.UIElements.StyleSheets.StylePropertyId value) { }
        private System.Int32 get_valueCount() { }
        private System.Void set_valueCount(System.Int32 value) { }
        private System.Single get_dpiScaling() { }
        private System.Void set_dpiScaling(System.Single value) { }
        private System.Void SetContext(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleComplexSelector selector, UnityEngine.UIElements.StyleVariableContext varContext, System.Single dpiScaling) { }
        private System.Void SetInlineContext(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleProperty[] properties, UnityEngine.UIElements.StyleSheets.StylePropertyId[] propertyIds, System.Single dpiScaling) { }
        private UnityEngine.UIElements.StyleSheets.StylePropertyId MoveNextProperty() { }
        private UnityEngine.UIElements.StyleSheets.StylePropertyValue GetValue(System.Int32 index) { }
        private UnityEngine.UIElements.StyleValueType GetValueType(System.Int32 index) { }
        private System.Boolean IsValueType(System.Int32 index, UnityEngine.UIElements.StyleValueType type) { }
        private System.Boolean IsKeyword(System.Int32 index, UnityEngine.UIElements.StyleValueKeyword keyword) { }
        private System.String ReadAsString(System.Int32 index) { }
        private UnityEngine.UIElements.Length ReadLength(System.Int32 index) { }
        private UnityEngine.UIElements.TimeValue ReadTimeValue(System.Int32 index) { }
        private UnityEngine.UIElements.Translate ReadTranslate(System.Int32 index) { }
        private UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(System.Int32 index) { }
        private UnityEngine.UIElements.Rotate ReadRotate(System.Int32 index) { }
        private UnityEngine.UIElements.Scale ReadScale(System.Int32 index) { }
        private System.Single ReadFloat(System.Int32 index) { }
        private System.Int32 ReadInt(System.Int32 index) { }
        private UnityEngine.Color ReadColor(System.Int32 index) { }
        private System.Int32 ReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType enumType, System.Int32 index) { }
        private UnityEngine.UIElements.FontDefinition ReadFontDefinition(System.Int32 index) { }
        private UnityEngine.Font ReadFont(System.Int32 index) { }
        private UnityEngine.UIElements.Background ReadBackground(System.Int32 index) { }
        private UnityEngine.UIElements.Cursor ReadCursor(System.Int32 index) { }
        private UnityEngine.UIElements.TextShadow ReadTextShadow(System.Int32 index) { }
        private System.Void ReadListEasingFunction(System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> list, System.Int32 index) { }
        private System.Void ReadListTimeValue(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> list, System.Int32 index) { }
        private System.Void ReadListStylePropertyName(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> list, System.Int32 index) { }
        private System.Void LoadProperties() { }
        private System.Void SetCurrentProperty() { }
        private UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(System.Int32 valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue zVvalue) { }
        private UnityEngine.UIElements.Length ReadTransformOriginEnum(UnityEngine.UIElements.StyleSheets.StylePropertyValue value, System.Boolean& isVertical, System.Boolean& isHorizontal) { }
        private UnityEngine.UIElements.Translate ReadTranslate(System.Int32 valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue val3) { }
        private UnityEngine.UIElements.Scale ReadScale(System.Int32 valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue val3) { }
        private UnityEngine.UIElements.Rotate ReadRotate(System.Int32 valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue val3, UnityEngine.UIElements.StyleSheets.StylePropertyValue val4) { }
        private System.Int32 ReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType enumType, UnityEngine.UIElements.StyleSheets.StylePropertyValue value) { }
        private UnityEngine.UIElements.Angle ReadAngle(UnityEngine.UIElements.StyleSheets.StylePropertyValue value) { }
        private System.Boolean TryGetImageSourceFromValue(UnityEngine.UIElements.StyleSheets.StylePropertyValue propertyValue, System.Single dpiScaling, UnityEngine.UIElements.StyleSheets.ImageSource& source) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000345
    public struct MatchResultInfo
    {
        // Fields
        public readonly System.Boolean success;        // 0x10
        public readonly UnityEngine.UIElements.PseudoStates triggerPseudoMask;        // 0x14
        public readonly UnityEngine.UIElements.PseudoStates dependencyPseudoMask;        // 0x18

        // Methods
        private System.Void .ctor(System.Boolean success, UnityEngine.UIElements.PseudoStates triggerPseudoMask, UnityEngine.UIElements.PseudoStates dependencyPseudoMask) { }

    }

    // TypeToken: 0x2000346
    public struct SelectorMatchRecord
    {
        // Fields
        public UnityEngine.UIElements.StyleSheet sheet;        // 0x10
        public System.Int32 styleSheetIndexInStack;        // 0x18
        public UnityEngine.UIElements.StyleComplexSelector complexSelector;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.StyleSheet sheet, System.Int32 styleSheetIndexInStack) { }
        private System.Int32 Compare(UnityEngine.UIElements.StyleSheets.SelectorMatchRecord a, UnityEngine.UIElements.StyleSheets.SelectorMatchRecord b) { }

    }

    // TypeToken: 0x2000347
    public class StyleSelectorHelper
    {
        // Methods
        private UnityEngine.UIElements.StyleSheets.MatchResultInfo MatchesSelector(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSelector selector) { }
        private System.Boolean MatchRightToLeft(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleComplexSelector complexSelector, System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult) { }
        private System.Void FastLookup(System.Collections.Generic.IDictionary<System.String,UnityEngine.UIElements.StyleComplexSelector> table, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchedSelectors, UnityEngine.UIElements.StyleMatchingContext context, System.String input, UnityEngine.UIElements.StyleSheets.SelectorMatchRecord& record) { }
        private System.Void FindMatches(UnityEngine.UIElements.StyleMatchingContext context, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchedSelectors, System.Int32 parentSheetIndex) { }

    }

    // TypeToken: 0x2000348
    public class StyleSheetCache
    {
        // Fields
        private static UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKeyComparer s_Comparer;        // 0x0
        private static System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey,UnityEngine.UIElements.StyleSheets.StylePropertyId[]> s_RulePropertyIdsCache;        // 0x8

        // Methods
        private UnityEngine.UIElements.StyleSheets.StylePropertyId[] GetPropertyIds(UnityEngine.UIElements.StyleSheet sheet, System.Int32 ruleIndex) { }
        private UnityEngine.UIElements.StyleSheets.StylePropertyId[] GetPropertyIds(UnityEngine.UIElements.StyleRule rule) { }
        private UnityEngine.UIElements.StyleSheets.StylePropertyId GetPropertyId(UnityEngine.UIElements.StyleRule rule, System.Int32 index) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200034B
    public class StyleSheetColor
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.String,UnityEngine.Color32> s_NameToColor;        // 0x0

        // Methods
        private System.Boolean TryGetColor(System.String name, UnityEngine.Color& color) { }
        private UnityEngine.Color32 HexToColor32(System.UInt32 color) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200034C
    public class StyleSheetExtensions
    {
        // Methods
        private System.String ReadAsString(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle handle) { }
        private System.Boolean IsVarFunction(UnityEngine.UIElements.StyleValueHandle handle) { }

    }

    // TypeToken: 0x200034D
    public struct StyleValue
    {
        // Fields
        public UnityEngine.UIElements.StyleSheets.StylePropertyId id;        // 0x10
        public UnityEngine.UIElements.StyleKeyword keyword;        // 0x14
        public System.Single number;        // 0x18
        public UnityEngine.UIElements.Length length;        // 0x18
        public UnityEngine.Color color;        // 0x18
        public System.Runtime.InteropServices.GCHandle resource;        // 0x18

    }

    // TypeToken: 0x200034E
    public struct StyleValueManaged
    {
        // Fields
        public UnityEngine.UIElements.StyleSheets.StylePropertyId id;        // 0x10
        public UnityEngine.UIElements.StyleKeyword keyword;        // 0x14
        public System.Object value;        // 0x18

    }

    // TypeToken: 0x200034F
    public struct MatchResultErrorCode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StyleSheets.MatchResultErrorCode None;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.MatchResultErrorCode Syntax;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.MatchResultErrorCode EmptyValue;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.MatchResultErrorCode ExpectedEndOfValue;        // 0x0

    }

    // TypeToken: 0x2000350
    public struct MatchResult
    {
        // Fields
        public UnityEngine.UIElements.StyleSheets.MatchResultErrorCode errorCode;        // 0x10
        public System.String errorValue;        // 0x18

        // Methods
        private System.Boolean get_success() { }

    }

    // TypeToken: 0x2000351
    public class BaseStyleMatcher
    {
        // Fields
        protected static readonly System.Text.RegularExpressions.Regex s_CustomIdentRegex;        // 0x0
        private System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.BaseStyleMatcher.MatchContext> m_ContextStack;        // 0x10
        private UnityEngine.UIElements.StyleSheets.BaseStyleMatcher.MatchContext m_CurrentContext;        // 0x18

        // Methods
        private System.Boolean MatchKeyword(System.String keyword) { }
        private System.Boolean MatchNumber() { }
        private System.Boolean MatchInteger() { }
        private System.Boolean MatchLength() { }
        private System.Boolean MatchPercentage() { }
        private System.Boolean MatchColor() { }
        private System.Boolean MatchResource() { }
        private System.Boolean MatchUrl() { }
        private System.Boolean MatchTime() { }
        private System.Boolean MatchAngle() { }
        private System.Boolean MatchCustomIdent() { }
        private System.Int32 get_valueCount() { }
        private System.Boolean get_isCurrentVariable() { }
        private System.Boolean get_isCurrentComma() { }
        private System.Boolean get_hasCurrent() { }
        private System.Int32 get_currentIndex() { }
        private System.Void set_currentIndex(System.Int32 value) { }
        private System.Int32 get_matchedVariableCount() { }
        private System.Void set_matchedVariableCount(System.Int32 value) { }
        private System.Void Initialize() { }
        private System.Void MoveNext() { }
        private System.Void SaveContext() { }
        private System.Void RestoreContext() { }
        private System.Void DropContext() { }
        private System.Boolean Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp) { }
        private System.Boolean MatchExpression(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp) { }
        private System.Boolean MatchExpressionWithMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp) { }
        private System.Boolean MatchGroup(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp) { }
        private System.Boolean MatchCombinator(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp) { }
        private System.Boolean MatchOr(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp) { }
        private System.Boolean MatchOrOr(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp) { }
        private System.Boolean MatchAndAnd(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp) { }
        private System.Int32 MatchMany(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp) { }
        private System.Int32 MatchManyByOrder(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp, System.Int32* matchOrder) { }
        private System.Boolean MatchJuxtaposition(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp) { }
        private System.Boolean MatchDataType(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000353
    public class StylePropertyValueMatcher : BaseStyleMatcher
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_Values;        // 0x20

        // Methods
        private UnityEngine.UIElements.StyleSheets.StylePropertyValue get_current() { }
        private System.Int32 get_valueCount() { }
        private System.Boolean get_isCurrentVariable() { }
        private System.Boolean get_isCurrentComma() { }
        private UnityEngine.UIElements.StyleSheets.MatchResult Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> values) { }
        private System.Boolean MatchKeyword(System.String keyword) { }
        private System.Boolean MatchNumber() { }
        private System.Boolean MatchInteger() { }
        private System.Boolean MatchLength() { }
        private System.Boolean MatchPercentage() { }
        private System.Boolean MatchColor() { }
        private System.Boolean MatchResource() { }
        private System.Boolean MatchUrl() { }
        private System.Boolean MatchTime() { }
        private System.Boolean MatchCustomIdent() { }
        private System.Boolean MatchAngle() { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.UIElements.StyleSheets.Syntax
{

    // TypeToken: 0x2000354
    public class Expression
    {
        // Fields
        public UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType type;        // 0x10
        public UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier multiplier;        // 0x14
        public UnityEngine.UIElements.StyleSheets.Syntax.DataType dataType;        // 0x20
        public UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator combinator;        // 0x24
        public UnityEngine.UIElements.StyleSheets.Syntax.Expression[] subExpressions;        // 0x28
        public System.String keyword;        // 0x30

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType type) { }

    }

    // TypeToken: 0x2000355
    public struct ExpressionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType Unknown;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType Data;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType Keyword;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType Combinator;        // 0x0

    }

    // TypeToken: 0x2000356
    public struct DataType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StyleSheets.Syntax.DataType None;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.DataType Number;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.DataType Integer;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.DataType Length;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.DataType Percentage;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.DataType Color;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.DataType Resource;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.DataType Url;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.DataType Time;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.DataType Angle;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.DataType CustomIdent;        // 0x0

    }

    // TypeToken: 0x2000357
    public struct ExpressionCombinator
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator None;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator Or;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator OrOr;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator AndAnd;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator Juxtaposition;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator Group;        // 0x0

    }

    // TypeToken: 0x2000358
    public struct ExpressionMultiplierType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType None;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType ZeroOrMore;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType OneOrMore;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType ZeroOrOne;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType Ranges;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType OneOrMoreComma;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType GroupAtLeastOne;        // 0x0

    }

    // TypeToken: 0x2000359
    public struct ExpressionMultiplier
    {
        // Fields
        public static System.Int32 Infinity;        // 0x0
        private UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType m_Type;        // 0x10
        public System.Int32 min;        // 0x14
        public System.Int32 max;        // 0x18

        // Methods
        private UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType get_type() { }
        private System.Void set_type(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType value) { }
        private System.Void .ctor(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType type) { }
        private System.Void SetType(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType value) { }

    }

    // TypeToken: 0x200035A
    public class StyleSyntaxParser
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.Syntax.Expression> m_ProcessExpressionList;        // 0x10
        private System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.Syntax.Expression> m_ExpressionStack;        // 0x18
        private System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator> m_CombinatorStack;        // 0x20
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.Syntax.Expression> m_ParsedExpressionCache;        // 0x28

        // Methods
        private UnityEngine.UIElements.StyleSheets.Syntax.Expression Parse(System.String syntax) { }
        private UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseExpression(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer) { }
        private System.Void ProcessCombinatorStack() { }
        private UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseTerm(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer) { }
        private UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator ParseCombinatorType(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer) { }
        private UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseGroup(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer) { }
        private UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseDataType(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer) { }
        private UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseNonTerminalValue(System.String syntax) { }
        private UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseProperty(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer) { }
        private System.Void ParseMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer, UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier& multiplier) { }
        private System.Void ParseRanges(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer, System.Int32& min, System.Int32& max) { }
        private System.Void EatSpace(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer) { }
        private System.Boolean IsExpressionEnd(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken token) { }
        private System.Boolean IsCombinator(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken token) { }
        private System.Boolean IsMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken token) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200035B
    public struct StyleSyntaxTokenType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType Unknown;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType String;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType Number;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType Space;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType SingleBar;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType DoubleBar;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType DoubleAmpersand;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType Comma;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType SingleQuote;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType Asterisk;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType Plus;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType QuestionMark;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType HashMark;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType ExclamationPoint;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType OpenBracket;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType CloseBracket;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType OpenBrace;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType CloseBrace;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType LessThan;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType GreaterThan;        // 0x0
        public static UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType End;        // 0x0

    }

    // TypeToken: 0x200035C
    public struct StyleSyntaxToken
    {
        // Fields
        public UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType type;        // 0x10
        public System.String text;        // 0x18
        public System.Int32 number;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType t) { }
        private System.Void .ctor(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType type, System.String text) { }
        private System.Void .ctor(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType type, System.Int32 number) { }

    }

    // TypeToken: 0x200035D
    public class StyleSyntaxTokenizer
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken> m_Tokens;        // 0x10
        private System.Int32 m_CurrentTokenIndex;        // 0x18

        // Methods
        private UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken get_current() { }
        private UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken MoveNext() { }
        private UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken PeekNext() { }
        private System.Void Tokenize(System.String syntax) { }
        private System.Boolean IsNextCharacter(System.String s, System.Int32 index, System.Char c) { }
        private System.Boolean IsNextLetterOrDash(System.String s, System.Int32 index) { }
        private System.Boolean IsNextNumber(System.String s, System.Int32 index) { }
        private System.Int32 GlobCharacter(System.String s, System.Int32 index, System.Char c) { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.UIElements.UIR
{

    // TypeToken: 0x20002D7
    public class Allocator2D
    {
        // Fields
        private readonly UnityEngine.Vector2Int m_MinSize;        // 0x10
        private readonly UnityEngine.Vector2Int m_MaxSize;        // 0x18
        private readonly UnityEngine.Vector2Int m_MaxAllocSize;        // 0x20
        private readonly System.Int32 m_RowHeightBias;        // 0x28
        private readonly UnityEngine.UIElements.UIR.Allocator2D.Row[] m_Rows;        // 0x30
        private readonly System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> m_Areas;        // 0x38

        // Methods
        private System.Void .ctor(UnityEngine.Vector2Int minSize, UnityEngine.Vector2Int maxSize, System.Int32 rowHeightBias) { }
        private System.Boolean TryAllocate(System.Int32 width, System.Int32 height, UnityEngine.UIElements.UIR.Allocator2D.Alloc2D& alloc2D) { }
        private System.Void Free(UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc2D) { }
        private System.Void BuildAreas(System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> areas, UnityEngine.Vector2Int minSize, UnityEngine.Vector2Int maxSize) { }
        private UnityEngine.Vector2Int ComputeMaxAllocSize(System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> areas, System.Int32 rowHeightBias) { }
        private UnityEngine.UIElements.UIR.Allocator2D.Row[] BuildRowArray(System.Int32 maxRowHeight, System.Int32 rowHeightBias) { }

    }

    // TypeToken: 0x20002DB
    public class GradientSettingsAtlas, IDisposable
    {
        // Fields
        private static Unity.Profiling.ProfilerMarker s_MarkerWrite;        // 0x0
        private static Unity.Profiling.ProfilerMarker s_MarkerCommit;        // 0x8
        private readonly System.Int32 m_Length;        // 0x10
        private readonly System.Int32 m_ElemWidth;        // 0x14
        private UnityEngine.UIElements.UIR.BestFitAllocator m_Allocator;        // 0x18
        private UnityEngine.Texture2D m_Atlas;        // 0x20
        private UnityEngine.UIElements.UIR.GradientSettingsAtlas.RawTexture m_RawAtlas;        // 0x28
        private static System.Int32 s_TextureCounter;        // 0x10
        private System.Boolean <disposed>k__BackingField;        // 0x38
        private System.Boolean <MustCommit>k__BackingField;        // 0x39

        // Methods
        private System.Int32 get_length() { }
        private System.Boolean get_disposed() { }
        private System.Void set_disposed(System.Boolean value) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor(System.Int32 length) { }
        private System.Void Reset() { }
        private UnityEngine.Texture2D get_atlas() { }
        private UnityEngine.UIElements.UIR.Alloc Add(System.Int32 count) { }
        private System.Void Write(UnityEngine.UIElements.UIR.Alloc alloc, UnityEngine.UIElements.GradientSettings[] settings, UnityEngine.UIElements.UIR.GradientRemap remap) { }
        private System.Boolean get_MustCommit() { }
        private System.Void set_MustCommit(System.Boolean value) { }
        private System.Void Commit() { }
        private System.Void PrepareAtlas() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002DD
    public class LinkedPoolItem`1
    {
        // Fields
        private T poolNext;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002DE
    public class LinkedPool`1
    {
        // Fields
        private readonly System.Func<T> m_CreateFunc;        // 0x0
        private readonly System.Action<T> m_ResetAction;        // 0x0
        private readonly System.Int32 m_Limit;        // 0x0
        private T m_PoolFirst;        // 0x0
        private System.Int32 <Count>k__BackingField;        // 0x0

        // Methods
        private System.Void .ctor(System.Func<T> createFunc, System.Action<T> resetAction, System.Int32 limit) { }
        private System.Int32 get_Count() { }
        private System.Void set_Count(System.Int32 value) { }
        private System.Void Clear() { }
        private T Get() { }
        private System.Void Return(T item) { }

    }

    // TypeToken: 0x20002DF
    public class BasicNode`1 : LinkedPoolItem`1
    {
        // Fields
        public UnityEngine.UIElements.UIR.BasicNode<T> next;        // 0x0
        public T data;        // 0x0

        // Methods
        private System.Void AppendTo(UnityEngine.UIElements.UIR.BasicNode<T>& first) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E0
    public class BasicNodePool`1 : LinkedPool`1
    {
        // Methods
        private System.Void Reset(UnityEngine.UIElements.UIR.BasicNode<T> node) { }
        private UnityEngine.UIElements.UIR.BasicNode<T> Create() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E1
    public class MeshBuilder
    {
        // Fields
        private static Unity.Profiling.ProfilerMarker s_VectorGraphics9Slice;        // 0x0
        private static Unity.Profiling.ProfilerMarker s_VectorGraphicsSplitTriangle;        // 0x8
        private static Unity.Profiling.ProfilerMarker s_VectorGraphicsScaleTriangle;        // 0x10
        private static Unity.Profiling.ProfilerMarker s_VectorGraphicsStretch;        // 0x18
        private static readonly System.Int32 s_MaxTextMeshVertices;        // 0x20
        private static readonly System.UInt16[] slicedQuadIndices;        // 0x28
        private static readonly System.Single[] k_TexCoordSlicesX;        // 0x30
        private static readonly System.Single[] k_TexCoordSlicesY;        // 0x38
        private static readonly System.Single[] k_PositionSlicesX;        // 0x40
        private static readonly System.Single[] k_PositionSlicesY;        // 0x48
        private static UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdge[] s_AllClipEdges;        // 0x50

        // Methods
        private System.Void MakeBorder(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams borderParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc) { }
        private System.Void MakeSolidRect(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc) { }
        private System.Void MakeTexturedRect(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, UnityEngine.UIElements.ColorPage colorPage) { }
        private UnityEngine.UIElements.Vertex ConvertTextVertexToUIRVertex(UnityEngine.TextCore.Text.MeshInfo info, System.Int32 index, UnityEngine.Vector2 offset, UnityEngine.UIElements.UIR.VertexFlags flags, System.Boolean isDynamicColor) { }
        private UnityEngine.UIElements.Vertex ConvertTextVertexToUIRVertex(UnityEngine.UIElements.TextVertex textVertex, UnityEngine.Vector2 offset) { }
        private System.Int32 LimitTextVertices(System.Int32 vertexCount, System.Boolean logTruncation) { }
        private System.Void MakeText(UnityEngine.TextCore.Text.MeshInfo meshInfo, UnityEngine.Vector2 offset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, UnityEngine.UIElements.UIR.VertexFlags flags, System.Boolean isDynamicColor) { }
        private System.Void MakeText(Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> uiVertices, UnityEngine.Vector2 offset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc) { }
        private System.Void UpdateText(Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> uiVertices, UnityEngine.Vector2 offset, UnityEngine.Matrix4x4 transform, UnityEngine.Color32 xformClipPages, UnityEngine.Color32 ids, UnityEngine.Color32 flags, UnityEngine.Color32 opacityPageSettingIndex, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices) { }
        private System.Void MakeQuad(UnityEngine.Rect rcPosition, UnityEngine.Rect rcTexCoord, UnityEngine.Color color, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, UnityEngine.UIElements.ColorPage colorPage) { }
        private System.Void MakeSlicedQuad(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams& rectParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc) { }
        private System.Void MakeVectorGraphics(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, System.Int32 settingIndexOffset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, System.Int32& finalVertexCount, System.Int32& finalIndexCount) { }
        private System.Void MakeVectorGraphicsStretchBackground(UnityEngine.UIElements.Vertex[] svgVertices, System.UInt16[] svgIndices, System.Single svgWidth, System.Single svgHeight, UnityEngine.Rect targetRect, UnityEngine.Rect sourceUV, UnityEngine.ScaleMode scaleMode, UnityEngine.Color tint, System.Int32 settingIndexOffset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, System.Int32& finalVertexCount, System.Int32& finalIndexCount) { }
        private System.Void SplitTriangle(UnityEngine.UIElements.Vertex* vertices, System.UInt16* indices, System.Int32& vertexCount, System.Int32 indexToProcess, System.Int32& indexCount, System.Single svgWidth, System.Single svgHeight, UnityEngine.Vector4 sliceLTRB, System.Int32 sliceIndex) { }
        private System.Void ScaleSplittedTriangles(UnityEngine.UIElements.Vertex* vertices, System.Int32 vertexCount, System.Single svgWidth, System.Single svgHeight, UnityEngine.Rect targetRect, UnityEngine.Vector4 sliceLTRB) { }
        private System.Void MakeVectorGraphics9SliceBackground(UnityEngine.UIElements.Vertex[] svgVertices, System.UInt16[] svgIndices, System.Single svgWidth, System.Single svgHeight, UnityEngine.Rect targetRect, UnityEngine.Vector4 sliceLTRB, System.Boolean stretch, UnityEngine.Color tint, System.Int32 settingIndexOffset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc) { }
        private UnityEngine.UIElements.UIR.MeshBuilder.ClipCounts UpperBoundApproximateRectClippingResults(UnityEngine.UIElements.Vertex[] vertices, System.UInt16[] indices, UnityEngine.Vector4 clipRectMinMax) { }
        private System.Void RectClip(UnityEngine.UIElements.Vertex[] vertices, System.UInt16[] indices, UnityEngine.Vector4 clipRectMinMax, UnityEngine.UIElements.MeshWriteData mwd, UnityEngine.UIElements.UIR.MeshBuilder.ClipCounts cc, System.Int32& newVertexCount) { }
        private System.Void RectClipTriangle(UnityEngine.UIElements.Vertex* vt, System.UInt16* it, UnityEngine.Vector4 clipRectMinMax, UnityEngine.UIElements.MeshWriteData mwd, System.UInt16& nextNewVertex) { }
        private UnityEngine.Vector3 GetVertexBaryCentricCoordinates(UnityEngine.UIElements.Vertex* vt, System.Single x, System.Single y) { }
        private UnityEngine.UIElements.Vertex InterpolateVertexInTriangle(UnityEngine.UIElements.Vertex* vt, System.Single x, System.Single y, UnityEngine.Vector3 uvw) { }
        private UnityEngine.UIElements.Vertex InterpolateVertexInTriangleEdge(UnityEngine.UIElements.Vertex* vt, System.Int32 e0, System.Int32 e1, System.Single t) { }
        private System.Single IntersectSegments(System.Single ax, System.Single ay, System.Single bx, System.Single by, System.Single cx, System.Single cy, System.Single dx, System.Single dy) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002E6
    public struct ChainBuilderStats
    {
        // Fields
        public System.UInt32 elementsAdded;        // 0x10
        public System.UInt32 elementsRemoved;        // 0x14
        public System.UInt32 recursiveClipUpdates;        // 0x18
        public System.UInt32 recursiveClipUpdatesExpanded;        // 0x1C
        public System.UInt32 nonRecursiveClipUpdates;        // 0x20
        public System.UInt32 recursiveTransformUpdates;        // 0x24
        public System.UInt32 recursiveTransformUpdatesExpanded;        // 0x28
        public System.UInt32 recursiveOpacityUpdates;        // 0x2C
        public System.UInt32 recursiveOpacityUpdatesExpanded;        // 0x30
        public System.UInt32 colorUpdates;        // 0x34
        public System.UInt32 colorUpdatesExpanded;        // 0x38
        public System.UInt32 recursiveVisualUpdates;        // 0x3C
        public System.UInt32 recursiveVisualUpdatesExpanded;        // 0x40
        public System.UInt32 nonRecursiveVisualUpdates;        // 0x44
        public System.UInt32 dirtyProcessed;        // 0x48
        public System.UInt32 nudgeTransformed;        // 0x4C
        public System.UInt32 boneTransformed;        // 0x50
        public System.UInt32 skipTransformed;        // 0x54
        public System.UInt32 visualUpdateTransformed;        // 0x58
        public System.UInt32 updatedMeshAllocations;        // 0x5C
        public System.UInt32 newMeshAllocations;        // 0x60
        public System.UInt32 groupTransformElementsChanged;        // 0x64
        public System.UInt32 immedateRenderersActive;        // 0x68
        public System.UInt32 textUpdates;        // 0x6C

    }

    // TypeToken: 0x20002E7
    public class RenderChain, IDisposable
    {
        // Fields
        private UnityEngine.UIElements.UIR.RenderChainCommand m_FirstCommand;        // 0x10
        private UnityEngine.UIElements.UIR.RenderChain.DepthOrderedDirtyTracking m_DirtyTracker;        // 0x18
        private UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.RenderChainCommand> m_CommandPool;        // 0x40
        private UnityEngine.UIElements.UIR.BasicNodePool<UnityEngine.UIElements.UIR.TextureEntry> m_TexturePool;        // 0x48
        private System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChain.RenderNodeData> m_RenderNodesData;        // 0x50
        private UnityEngine.Shader m_DefaultShader;        // 0x58
        private UnityEngine.Shader m_DefaultWorldSpaceShader;        // 0x60
        private UnityEngine.Material m_DefaultMat;        // 0x68
        private UnityEngine.Material m_DefaultWorldSpaceMat;        // 0x70
        private System.Boolean m_BlockDirtyRegistration;        // 0x78
        private System.Int32 m_StaticIndex;        // 0x7C
        private System.Int32 m_ActiveRenderNodes;        // 0x80
        private System.Int32 m_CustomMaterialCommands;        // 0x84
        private UnityEngine.UIElements.UIR.ChainBuilderStats m_Stats;        // 0x88
        private System.UInt32 m_StatsElementsAdded;        // 0xE8
        private System.UInt32 m_StatsElementsRemoved;        // 0xEC
        private UnityEngine.UIElements.VisualElement m_FirstTextElement;        // 0xF0
        private UnityEngine.UIElements.UIR.Implementation.UIRTextUpdatePainter m_TextUpdatePainter;        // 0xF8
        private System.Int32 m_TextElementCount;        // 0x100
        private System.Int32 m_DirtyTextStartIndex;        // 0x104
        private System.Int32 m_DirtyTextRemaining;        // 0x108
        private System.Boolean m_FontWasReset;        // 0x10C
        private System.Collections.Generic.Dictionary<UnityEngine.UIElements.VisualElement,UnityEngine.Vector2> m_LastGroupTransformElementScale;        // 0x110
        private UnityEngine.UIElements.TextureRegistry m_TextureRegistry;        // 0x118
        private static Unity.Profiling.ProfilerMarker s_MarkerProcess;        // 0x0
        private static Unity.Profiling.ProfilerMarker s_MarkerClipProcessing;        // 0x8
        private static Unity.Profiling.ProfilerMarker s_MarkerOpacityProcessing;        // 0x10
        private static Unity.Profiling.ProfilerMarker s_MarkerColorsProcessing;        // 0x18
        private static Unity.Profiling.ProfilerMarker s_MarkerTransformProcessing;        // 0x20
        private static Unity.Profiling.ProfilerMarker s_MarkerVisualsProcessing;        // 0x28
        private static Unity.Profiling.ProfilerMarker s_MarkerTextRegen;        // 0x30
        private System.Boolean <disposed>k__BackingField;        // 0x120
        private static System.Action OnPreRender;        // 0x38
        private UnityEngine.UIElements.BaseVisualElementPanel <panel>k__BackingField;        // 0x128
        private UnityEngine.UIElements.UIR.UIRenderDevice <device>k__BackingField;        // 0x130
        private UnityEngine.UIElements.AtlasBase <atlas>k__BackingField;        // 0x138
        private UnityEngine.UIElements.UIR.VectorImageManager <vectorImageManager>k__BackingField;        // 0x140
        private UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator shaderInfoAllocator;        // 0x148
        private UnityEngine.UIElements.UIR.Implementation.UIRStylePainter <painter>k__BackingField;        // 0x218
        private System.Boolean <drawStats>k__BackingField;        // 0x220
        private System.Boolean <drawInCameras>k__BackingField;        // 0x221

        // Methods
        private System.Void .cctor() { }
        private System.Void .ctor(UnityEngine.UIElements.BaseVisualElementPanel panel) { }
        private System.Void Constructor(UnityEngine.UIElements.BaseVisualElementPanel panelObj, UnityEngine.UIElements.UIR.UIRenderDevice deviceObj, UnityEngine.UIElements.AtlasBase atlas, UnityEngine.UIElements.UIR.VectorImageManager vectorImageMan) { }
        private System.Void Destructor() { }
        private System.Boolean get_disposed() { }
        private System.Void set_disposed(System.Boolean value) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void ProcessChanges() { }
        private System.Void Render() { }
        private System.Void ProcessTextRegen(System.Boolean timeSliced) { }
        private System.Void UIEOnChildAdded(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void UIEOnChildrenReordered(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void UIEOnChildRemoving(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void StopTrackingGroupTransformElement(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void UIEOnRenderHintsChanged(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void UIEOnClippingChanged(UnityEngine.UIElements.VisualElement ve, System.Boolean hierarchical) { }
        private System.Void UIEOnOpacityChanged(UnityEngine.UIElements.VisualElement ve, System.Boolean hierarchical) { }
        private System.Void UIEOnColorChanged(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void UIEOnTransformOrSizeChanged(UnityEngine.UIElements.VisualElement ve, System.Boolean transformChanged, System.Boolean clipRectSizeChanged) { }
        private System.Void UIEOnVisualsChanged(UnityEngine.UIElements.VisualElement ve, System.Boolean hierarchical) { }
        private UnityEngine.UIElements.BaseVisualElementPanel get_panel() { }
        private System.Void set_panel(UnityEngine.UIElements.BaseVisualElementPanel value) { }
        private UnityEngine.UIElements.UIR.UIRenderDevice get_device() { }
        private System.Void set_device(UnityEngine.UIElements.UIR.UIRenderDevice value) { }
        private UnityEngine.UIElements.AtlasBase get_atlas() { }
        private System.Void set_atlas(UnityEngine.UIElements.AtlasBase value) { }
        private UnityEngine.UIElements.UIR.VectorImageManager get_vectorImageManager() { }
        private System.Void set_vectorImageManager(UnityEngine.UIElements.UIR.VectorImageManager value) { }
        private UnityEngine.UIElements.UIR.Implementation.UIRStylePainter get_painter() { }
        private System.Void set_painter(UnityEngine.UIElements.UIR.Implementation.UIRStylePainter value) { }
        private System.Boolean get_drawStats() { }
        private System.Void set_drawStats(System.Boolean value) { }
        private System.Boolean get_drawInCameras() { }
        private System.Void set_drawInCameras(System.Boolean value) { }
        private System.Void set_defaultShader(UnityEngine.Shader value) { }
        private System.Void set_defaultWorldSpaceShader(UnityEngine.Shader value) { }
        private UnityEngine.Material GetStandardMaterial() { }
        private UnityEngine.Material GetStandardWorldSpaceMaterial() { }
        private System.Void EnsureFitsDepth(System.Int32 depth) { }
        private System.Void ChildWillBeRemoved(UnityEngine.UIElements.VisualElement ve) { }
        private UnityEngine.UIElements.UIR.RenderChainCommand AllocCommand() { }
        private System.Void FreeCommand(UnityEngine.UIElements.UIR.RenderChainCommand cmd) { }
        private System.Void OnRenderCommandAdded(UnityEngine.UIElements.UIR.RenderChainCommand command) { }
        private System.Void OnRenderCommandsRemoved(UnityEngine.UIElements.UIR.RenderChainCommand firstCommand, UnityEngine.UIElements.UIR.RenderChainCommand lastCommand) { }
        private System.Void AddTextElement(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void RemoveTextElement(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void OnGroupTransformElementChangedTransform(UnityEngine.UIElements.VisualElement ve) { }
        private UnityEngine.UIElements.UIR.RenderChain.RenderNodeData AccessRenderNodeData(System.IntPtr obj) { }
        private System.Void OnRenderNodeExecute(System.IntPtr obj) { }
        private System.Void OnRegisterIntermediateRenderers(UnityEngine.Camera camera) { }
        private System.Void OnRegisterIntermediateRendererMat(UnityEngine.UIElements.BaseRuntimePanel rtp, UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.RenderChain.RenderNodeData& rnd, UnityEngine.Camera camera, System.Int32 sameDistanceSortPriority) { }
        private System.Void RepaintTexturedElements() { }
        private System.Void OnFontReset(UnityEngine.Font font) { }
        private System.Void AppendTexture(UnityEngine.UIElements.VisualElement ve, UnityEngine.Texture src, UnityEngine.UIElements.TextureId id, System.Boolean isAtlas) { }
        private System.Void ResetTextures(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void DrawStats() { }
        private UnityEngine.UIElements.VisualElement GetFirstElementInPanel(UnityEngine.UIElements.VisualElement ve) { }

    }

    // TypeToken: 0x20002EC
    public struct RenderDataDirtyTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.UIR.RenderDataDirtyTypes None;        // 0x0
        public static UnityEngine.UIElements.UIR.RenderDataDirtyTypes Transform;        // 0x0
        public static UnityEngine.UIElements.UIR.RenderDataDirtyTypes ClipRectSize;        // 0x0
        public static UnityEngine.UIElements.UIR.RenderDataDirtyTypes Clipping;        // 0x0
        public static UnityEngine.UIElements.UIR.RenderDataDirtyTypes ClippingHierarchy;        // 0x0
        public static UnityEngine.UIElements.UIR.RenderDataDirtyTypes Visuals;        // 0x0
        public static UnityEngine.UIElements.UIR.RenderDataDirtyTypes VisualsHierarchy;        // 0x0
        public static UnityEngine.UIElements.UIR.RenderDataDirtyTypes Opacity;        // 0x0
        public static UnityEngine.UIElements.UIR.RenderDataDirtyTypes OpacityHierarchy;        // 0x0
        public static UnityEngine.UIElements.UIR.RenderDataDirtyTypes Color;        // 0x0

    }

    // TypeToken: 0x20002ED
    public struct RenderDataDirtyTypeClasses
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses Clipping;        // 0x0
        public static UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses Opacity;        // 0x0
        public static UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses Color;        // 0x0
        public static UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses TransformSize;        // 0x0
        public static UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses Visuals;        // 0x0
        public static UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses Count;        // 0x0

    }

    // TypeToken: 0x20002EE
    public struct RenderChainVEData
    {
        // Fields
        private UnityEngine.UIElements.VisualElement prev;        // 0x10
        private UnityEngine.UIElements.VisualElement next;        // 0x18
        private UnityEngine.UIElements.VisualElement groupTransformAncestor;        // 0x20
        private UnityEngine.UIElements.VisualElement boneTransformAncestor;        // 0x28
        private UnityEngine.UIElements.VisualElement prevDirty;        // 0x30
        private UnityEngine.UIElements.VisualElement nextDirty;        // 0x38
        private System.Int32 hierarchyDepth;        // 0x40
        private UnityEngine.UIElements.UIR.RenderDataDirtyTypes dirtiedValues;        // 0x44
        private System.UInt32 dirtyID;        // 0x48
        private UnityEngine.UIElements.UIR.RenderChainCommand firstCommand;        // 0x50
        private UnityEngine.UIElements.UIR.RenderChainCommand lastCommand;        // 0x58
        private UnityEngine.UIElements.UIR.RenderChainCommand firstClosingCommand;        // 0x60
        private UnityEngine.UIElements.UIR.RenderChainCommand lastClosingCommand;        // 0x68
        private System.Boolean isInChain;        // 0x70
        private System.Boolean isHierarchyHidden;        // 0x71
        private System.Boolean localFlipsWinding;        // 0x72
        private System.Boolean localTransformScaleZero;        // 0x73
        private System.Boolean worldFlipsWinding;        // 0x74
        private UnityEngine.UIElements.UIR.Implementation.ClipMethod clipMethod;        // 0x78
        private System.Int32 childrenStencilRef;        // 0x7C
        private System.Int32 childrenMaskDepth;        // 0x80
        private System.Boolean disableNudging;        // 0x84
        private System.Boolean usesLegacyText;        // 0x85
        private UnityEngine.UIElements.UIR.MeshHandle data;        // 0x88
        private UnityEngine.UIElements.UIR.MeshHandle closingData;        // 0x90
        private UnityEngine.Matrix4x4 verticesSpace;        // 0x98
        private System.Int32 displacementUVStart;        // 0xD8
        private System.Int32 displacementUVEnd;        // 0xDC
        private UnityEngine.UIElements.UIR.BMPAlloc transformID;        // 0xE0
        private UnityEngine.UIElements.UIR.BMPAlloc clipRectID;        // 0xE8
        private UnityEngine.UIElements.UIR.BMPAlloc opacityID;        // 0xF0
        private UnityEngine.UIElements.UIR.BMPAlloc textCoreSettingsID;        // 0xF8
        private UnityEngine.UIElements.UIR.BMPAlloc backgroundColorID;        // 0x100
        private UnityEngine.UIElements.UIR.BMPAlloc borderLeftColorID;        // 0x108
        private UnityEngine.UIElements.UIR.BMPAlloc borderTopColorID;        // 0x110
        private UnityEngine.UIElements.UIR.BMPAlloc borderRightColorID;        // 0x118
        private UnityEngine.UIElements.UIR.BMPAlloc borderBottomColorID;        // 0x120
        private UnityEngine.UIElements.UIR.BMPAlloc tintColorID;        // 0x128
        private System.Single compositeOpacity;        // 0x130
        private UnityEngine.Color backgroundColor;        // 0x134
        private UnityEngine.UIElements.VisualElement prevText;        // 0x148
        private UnityEngine.UIElements.VisualElement nextText;        // 0x150
        private System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChainTextEntry> textEntries;        // 0x158
        private UnityEngine.UIElements.UIR.BasicNode<UnityEngine.UIElements.UIR.TextureEntry> textures;        // 0x160

        // Methods
        private UnityEngine.UIElements.UIR.RenderChainCommand get_lastClosingOrLastCommand() { }
        private System.Boolean AllocatesID(UnityEngine.UIElements.UIR.BMPAlloc alloc) { }
        private System.Boolean InheritsID(UnityEngine.UIElements.UIR.BMPAlloc alloc) { }

    }

    // TypeToken: 0x20002EF
    public struct RenderChainTextEntry
    {
        // Fields
        private UnityEngine.UIElements.UIR.RenderChainCommand command;        // 0x10
        private System.Int32 firstVertex;        // 0x18
        private System.Int32 vertexCount;        // 0x1C

    }

    // TypeToken: 0x20002F0
    public struct TextureEntry
    {
        // Fields
        public UnityEngine.Texture source;        // 0x10
        public UnityEngine.UIElements.TextureId actual;        // 0x18
        public System.Boolean replaced;        // 0x1C

    }

    // TypeToken: 0x20002F1
    public class BaseShaderInfoStorage, IDisposable
    {
        // Fields
        protected static System.Int32 s_TextureCounter;        // 0x0
        private static Unity.Profiling.ProfilerMarker s_MarkerCopyTexture;        // 0x8
        private static Unity.Profiling.ProfilerMarker s_MarkerGetTextureData;        // 0x10
        private static Unity.Profiling.ProfilerMarker s_MarkerUpdateTexture;        // 0x18
        private System.Boolean <disposed>k__BackingField;        // 0x10

        // Methods
        private UnityEngine.Texture2D get_texture() { }
        private System.Boolean AllocateRect(System.Int32 width, System.Int32 height, UnityEngine.RectInt& uvs) { }
        private System.Void SetTexel(System.Int32 x, System.Int32 y, UnityEngine.Color color) { }
        private System.Void UpdateTexture() { }
        private System.Boolean get_disposed() { }
        private System.Void set_disposed(System.Boolean value) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002F2
    public class ShaderInfoStorage`1 : BaseShaderInfoStorage
    {
        // Fields
        private readonly System.Int32 m_InitialSize;        // 0x0
        private readonly System.Int32 m_MaxSize;        // 0x0
        private readonly UnityEngine.TextureFormat m_Format;        // 0x0
        private readonly System.Func<UnityEngine.Color,T> m_Convert;        // 0x0
        private UnityEngine.UIElements.UIRAtlasAllocator m_Allocator;        // 0x0
        private UnityEngine.Texture2D m_Texture;        // 0x0
        private Unity.Collections.NativeArray<T> m_Texels;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.TextureFormat format, System.Func<UnityEngine.Color,T> convert, System.Int32 initialSize, System.Int32 maxSize) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private UnityEngine.Texture2D get_texture() { }
        private System.Boolean AllocateRect(System.Int32 width, System.Int32 height, UnityEngine.RectInt& uvs) { }
        private System.Void SetTexel(System.Int32 x, System.Int32 y, UnityEngine.Color color) { }
        private System.Void UpdateTexture() { }
        private System.Void CreateOrExpandTexture() { }
        private System.Void CpuBlit(Unity.Collections.NativeArray<T> src, System.Int32 srcWidth, System.Int32 srcHeight, Unity.Collections.NativeArray<T> dst, System.Int32 dstWidth, System.Int32 dstHeight) { }

    }

    // TypeToken: 0x20002F3
    public class ShaderInfoStorageRGBA32 : ShaderInfoStorage`1
    {
        // Fields
        private static readonly System.Func<UnityEngine.Color,UnityEngine.Color32> s_Convert;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 initialSize, System.Int32 maxSize) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002F5
    public class ShaderInfoStorageRGBAFloat : ShaderInfoStorage`1
    {
        // Fields
        private static readonly System.Func<UnityEngine.Color,UnityEngine.Color> s_Convert;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 initialSize, System.Int32 maxSize) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002F7
    public class Shaders
    {
        // Fields
        public static readonly System.String k_AtlasBlit;        // 0x0
        public static readonly System.String k_Editor;        // 0x8
        public static readonly System.String k_Runtime;        // 0x10
        public static readonly System.String k_RuntimeWorld;        // 0x18
        public static readonly System.String k_GraphView;        // 0x20

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002F8
    public class Tessellation
    {
        // Fields
        private static System.Single kEpsilon;        // 0x0
        private static System.Single kUnusedArc;        // 0x4
        private static System.UInt16 kSubdivisions;        // 0x8
        private static Unity.Profiling.ProfilerMarker s_MarkerTessellateRect;        // 0x10
        private static Unity.Profiling.ProfilerMarker s_MarkerTessellateBorder;        // 0x18
        private static UnityEngine.UIElements.UIR.Tessellation.Edges[] s_AllEdges;        // 0x20

        // Methods
        private System.Void TessellateRect(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, System.Boolean computeUVs) { }
        private System.Void TessellateQuad(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc) { }
        private System.Void TessellateBorder(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams borderParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc) { }
        private System.Void TessellateRoundedCorners(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams& rectParams, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly) { }
        private System.Void TessellateRoundedBorders(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams& border, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly) { }
        private System.Void TessellateRoundedCorner(UnityEngine.Rect rect, UnityEngine.Color32 color, System.Single posZ, UnityEngine.Vector2 radius, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly) { }
        private System.Void TessellateRoundedBorder(UnityEngine.Rect rect, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, System.Single posZ, UnityEngine.Vector2 radius, System.Single leftWidth, System.Single topWidth, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly) { }
        private UnityEngine.Vector2 IntersectLines(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3) { }
        private System.Int32 LooseCompare(System.Single a, System.Single b) { }
        private System.Void TessellateComplexBorderCorner(UnityEngine.Rect rect, UnityEngine.Vector2 radius, System.Single leftWidth, System.Single topWidth, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly) { }
        private System.Void TessellateQuad(UnityEngine.Rect rect, UnityEngine.Color32 color, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly) { }
        private System.Void TessellateQuad(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdges, UnityEngine.Color32 color, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly) { }
        private System.Int32 EdgesCount(UnityEngine.UIElements.UIR.Tessellation.Edges edges) { }
        private System.Void TessellateQuad(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdges, UnityEngine.Vector2* offsets, UnityEngine.Color32 color, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly) { }
        private System.Void EncodeStraightArc(UnityEngine.UIElements.Vertex& v0, UnityEngine.UIElements.Vertex& v1, UnityEngine.UIElements.Vertex& center, System.Single radius) { }
        private System.Void ExpandTriangle(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3 center, System.Single factor) { }
        private System.Void TessellateQuadSingleEdge(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdge, UnityEngine.Color32 color, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly) { }
        private System.Void TessellateStraightBorder(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdge, System.Single miterOffset, UnityEngine.Color color, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly) { }
        private UnityEngine.Vector4 GetInterpolatedCircle(UnityEngine.Vector2 p, UnityEngine.UIElements.Vertex& v0, UnityEngine.UIElements.Vertex& v1, UnityEngine.UIElements.Vertex& v2) { }
        private System.Void ComputeBarycentricCoordinates(UnityEngine.Vector2 p, UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, System.Single& u, System.Single& v, System.Single& w) { }
        private System.Void TessellateFilledFan(UnityEngine.Vector2 center, UnityEngine.Vector2 radius, UnityEngine.Vector2 miterOffset, System.Single leftWidth, System.Single topWidth, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly) { }
        private System.Void TessellateBorderedFan(UnityEngine.Vector2 center, UnityEngine.Vector2 outerRadius, System.Single leftWidth, System.Single topWidth, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly) { }
        private System.Void MirrorVertices(UnityEngine.Rect rect, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, System.Int32 vertexStart, System.Int32 vertexCount, System.Boolean flipHorizontal) { }
        private System.Void FlipWinding(Unity.Collections.NativeSlice<System.UInt16> indices, System.Int32 indexStart, System.Int32 indexCount) { }
        private System.Void ComputeUVs(UnityEngine.Rect tessellatedRect, UnityEngine.Rect textureRect, UnityEngine.Rect uvRegion, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002FA
    public struct TextCoreSettings, IEquatable`1
    {
        // Fields
        public UnityEngine.Color faceColor;        // 0x10
        public UnityEngine.Color outlineColor;        // 0x20
        public System.Single outlineWidth;        // 0x30
        public UnityEngine.Color underlayColor;        // 0x34
        public UnityEngine.Vector2 underlayOffset;        // 0x44
        public System.Single underlaySoftness;        // 0x4C

        // Methods
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.UIElements.UIR.TextCoreSettings other) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x20002FB
    public class TextureBlitter, IDisposable
    {
        // Fields
        private static readonly System.Int32[] k_TextureIds;        // 0x0
        private static Unity.Profiling.ProfilerMarker s_CommitSampler;        // 0x8
        private UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo[] m_SingleBlit;        // 0x10
        private UnityEngine.Material m_BlitMaterial;        // 0x18
        private UnityEngine.MaterialPropertyBlock m_Properties;        // 0x20
        private UnityEngine.RectInt m_Viewport;        // 0x28
        private UnityEngine.RenderTexture m_PrevRT;        // 0x38
        private System.Collections.Generic.List<UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo> m_PendingBlits;        // 0x40
        private System.Boolean <disposed>k__BackingField;        // 0x48

        // Methods
        private System.Boolean get_disposed() { }
        private System.Void set_disposed(System.Boolean value) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .cctor() { }
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void QueueBlit(UnityEngine.Texture src, UnityEngine.RectInt srcRect, UnityEngine.Vector2Int dstPos, System.Boolean addBorder, UnityEngine.Color tint) { }
        private System.Void BlitOneNow(UnityEngine.RenderTexture dst, UnityEngine.Texture src, UnityEngine.RectInt srcRect, UnityEngine.Vector2Int dstPos, System.Boolean addBorder, UnityEngine.Color tint) { }
        private System.Void Commit(UnityEngine.RenderTexture dst) { }
        private System.Void BeginBlit(UnityEngine.RenderTexture dst) { }
        private System.Void DoBlit(System.Collections.Generic.IList<UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo> blitInfos, System.Int32 startIndex) { }
        private System.Void EndBlit() { }

    }

    // TypeToken: 0x20002FD
    public class TextureSlotManager
    {
        // Fields
        private static readonly System.Int32 k_SlotCount;        // 0x0
        private static readonly System.Int32[] slotIds;        // 0x8
        private static readonly System.Int32 textureTableId;        // 0x10
        private UnityEngine.UIElements.TextureId[] m_Textures;        // 0x10
        private System.Int32[] m_Tickets;        // 0x18
        private System.Int32 m_CurrentTicket;        // 0x20
        private System.Int32 m_FirstUsedTicket;        // 0x24
        private UnityEngine.Vector4[] m_GpuTextures;        // 0x28
        private System.Int32 <FreeSlots>k__BackingField;        // 0x30
        private UnityEngine.UIElements.TextureRegistry textureRegistry;        // 0x38

        // Methods
        private System.Void .cctor() { }
        private System.Void .ctor() { }
        private System.Void Reset() { }
        private System.Void StartNewBatch() { }
        private System.Int32 IndexOf(UnityEngine.UIElements.TextureId id) { }
        private System.Void MarkUsed(System.Int32 slotIndex) { }
        private System.Int32 get_FreeSlots() { }
        private System.Void set_FreeSlots(System.Int32 value) { }
        private System.Int32 FindOldestSlot() { }
        private System.Void Bind(UnityEngine.UIElements.TextureId id, System.Int32 slot, UnityEngine.MaterialPropertyBlock mat) { }

    }

    // TypeToken: 0x20002FE
    public class VectorImageRenderInfoPool : LinkedPool`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000300
    public class VectorImageRenderInfo : LinkedPoolItem`1
    {
        // Fields
        public System.Int32 useCount;        // 0x18
        public UnityEngine.UIElements.UIR.GradientRemap firstGradientRemap;        // 0x20
        public UnityEngine.UIElements.UIR.Alloc gradientSettingsAlloc;        // 0x28

        // Methods
        private System.Void Reset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000301
    public class GradientRemapPool : LinkedPool`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000303
    public class GradientRemap : LinkedPoolItem`1
    {
        // Fields
        public System.Int32 origIndex;        // 0x18
        public System.Int32 destIndex;        // 0x1C
        public UnityEngine.RectInt location;        // 0x20
        public UnityEngine.UIElements.UIR.GradientRemap next;        // 0x30
        public UnityEngine.UIElements.TextureId atlas;        // 0x38

        // Methods
        private System.Void Reset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000304
    public class VectorImageManager, IDisposable
    {
        // Fields
        public static System.Collections.Generic.List<UnityEngine.UIElements.UIR.VectorImageManager> instances;        // 0x0
        private static Unity.Profiling.ProfilerMarker s_MarkerRegister;        // 0x8
        private static Unity.Profiling.ProfilerMarker s_MarkerUnregister;        // 0x10
        private readonly UnityEngine.UIElements.AtlasBase m_Atlas;        // 0x10
        private System.Collections.Generic.Dictionary<UnityEngine.UIElements.VectorImage,UnityEngine.UIElements.UIR.VectorImageRenderInfo> m_Registered;        // 0x18
        private UnityEngine.UIElements.UIR.VectorImageRenderInfoPool m_RenderInfoPool;        // 0x20
        private UnityEngine.UIElements.UIR.GradientRemapPool m_GradientRemapPool;        // 0x28
        private UnityEngine.UIElements.UIR.GradientSettingsAtlas m_GradientSettingsAtlas;        // 0x30
        private System.Boolean m_LoggedExhaustedSettingsAtlas;        // 0x38
        private System.Boolean <disposed>k__BackingField;        // 0x39

        // Methods
        private UnityEngine.Texture2D get_atlas() { }
        private System.Void .ctor(UnityEngine.UIElements.AtlasBase atlas) { }
        private System.Boolean get_disposed() { }
        private System.Void set_disposed(System.Boolean value) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Commit() { }
        private UnityEngine.UIElements.UIR.GradientRemap AddUser(UnityEngine.UIElements.VectorImage vi, UnityEngine.UIElements.VisualElement context) { }
        private UnityEngine.UIElements.UIR.VectorImageRenderInfo Register(UnityEngine.UIElements.VectorImage vi, UnityEngine.UIElements.VisualElement context) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000305
    public struct OwnedState
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.UIElements.UIR.OwnedState Inherited;        // 0x0
        public static UnityEngine.UIElements.UIR.OwnedState Owned;        // 0x0

    }

    // TypeToken: 0x2000306
    public struct BMPAlloc
    {
        // Fields
        public static readonly UnityEngine.UIElements.UIR.BMPAlloc Invalid;        // 0x0
        public System.Int32 page;        // 0x10
        public System.UInt16 pageLine;        // 0x14
        public System.Byte bitIndex;        // 0x16
        public UnityEngine.UIElements.UIR.OwnedState ownedState;        // 0x17

        // Methods
        private System.Boolean Equals(UnityEngine.UIElements.UIR.BMPAlloc other) { }
        private System.Boolean IsValid() { }
        private System.String ToString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000307
    public struct BitmapAllocator32
    {
        // Fields
        private System.Int32 m_PageHeight;        // 0x10
        private System.Collections.Generic.List<UnityEngine.UIElements.UIR.BitmapAllocator32.Page> m_Pages;        // 0x18
        private System.Collections.Generic.List<System.UInt32> m_AllocMap;        // 0x20
        private System.Int32 m_EntryWidth;        // 0x28
        private System.Int32 m_EntryHeight;        // 0x2C

        // Methods
        private System.Void Construct(System.Int32 pageHeight, System.Int32 entryWidth, System.Int32 entryHeight) { }
        private System.Void ForceFirstAlloc(System.UInt16 firstPageX, System.UInt16 firstPageY) { }
        private UnityEngine.UIElements.UIR.BMPAlloc Allocate(UnityEngine.UIElements.UIR.BaseShaderInfoStorage storage) { }
        private System.Void Free(UnityEngine.UIElements.UIR.BMPAlloc alloc) { }
        private System.Int32 get_entryWidth() { }
        private System.Int32 get_entryHeight() { }
        private System.Void GetAllocPageAtlasLocation(System.Int32 page, System.UInt16& x, System.UInt16& y) { }
        private System.Byte CountTrailingZeroes(System.UInt32 val) { }

    }

    // TypeToken: 0x2000309
    public struct UIRVEShaderInfoAllocator
    {
        // Fields
        private UnityEngine.UIElements.UIR.BaseShaderInfoStorage m_Storage;        // 0x10
        private UnityEngine.UIElements.UIR.BitmapAllocator32 m_TransformAllocator;        // 0x18
        private UnityEngine.UIElements.UIR.BitmapAllocator32 m_ClipRectAllocator;        // 0x38
        private UnityEngine.UIElements.UIR.BitmapAllocator32 m_OpacityAllocator;        // 0x58
        private UnityEngine.UIElements.UIR.BitmapAllocator32 m_ColorAllocator;        // 0x78
        private UnityEngine.UIElements.UIR.BitmapAllocator32 m_TextSettingsAllocator;        // 0x98
        private System.Boolean m_StorageReallyCreated;        // 0xB8
        private System.Boolean m_VertexTexturingEnabled;        // 0xB9
        private Unity.Collections.NativeArray<UnityEngine.UIElements.UIR.Transform3x4> m_Transforms;        // 0xC0
        private Unity.Collections.NativeArray<UnityEngine.Vector4> m_ClipRects;        // 0xD0
        private static readonly UnityEngine.Vector2Int identityTransformTexel;        // 0x0
        private static readonly UnityEngine.Vector2Int infiniteClipRectTexel;        // 0x8
        private static readonly UnityEngine.Vector2Int fullOpacityTexel;        // 0x10
        private static readonly UnityEngine.Vector2Int clearColorTexel;        // 0x18
        private static readonly UnityEngine.Vector2Int defaultTextCoreSettingsTexel;        // 0x20
        private static readonly UnityEngine.Matrix4x4 identityTransformValue;        // 0x28
        private static readonly UnityEngine.Vector4 identityTransformRow0Value;        // 0x68
        private static readonly UnityEngine.Vector4 identityTransformRow1Value;        // 0x78
        private static readonly UnityEngine.Vector4 identityTransformRow2Value;        // 0x88
        private static readonly UnityEngine.Vector4 infiniteClipRectValue;        // 0x98
        private static readonly UnityEngine.Vector4 fullOpacityValue;        // 0xA8
        private static readonly UnityEngine.Vector4 clearColorValue;        // 0xB8
        private static readonly UnityEngine.UIElements.UIR.TextCoreSettings defaultTextCoreSettingsValue;        // 0xC8
        public static readonly UnityEngine.UIElements.UIR.BMPAlloc identityTransform;        // 0x108
        public static readonly UnityEngine.UIElements.UIR.BMPAlloc infiniteClipRect;        // 0x110
        public static readonly UnityEngine.UIElements.UIR.BMPAlloc fullOpacity;        // 0x118
        public static readonly UnityEngine.UIElements.UIR.BMPAlloc clearColor;        // 0x120
        public static readonly UnityEngine.UIElements.UIR.BMPAlloc defaultTextCoreSettings;        // 0x128

        // Methods
        private System.Int32 get_pageWidth() { }
        private System.Int32 get_pageHeight() { }
        private UnityEngine.Vector2Int AllocToTexelCoord(UnityEngine.UIElements.UIR.BitmapAllocator32& allocator, UnityEngine.UIElements.UIR.BMPAlloc alloc) { }
        private System.Int32 AllocToConstantBufferIndex(UnityEngine.UIElements.UIR.BMPAlloc alloc) { }
        private System.Boolean AtlasRectMatchesPage(UnityEngine.UIElements.UIR.BitmapAllocator32& allocator, UnityEngine.UIElements.UIR.BMPAlloc defAlloc, UnityEngine.RectInt atlasRect) { }
        private Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> get_transformConstants() { }
        private Unity.Collections.NativeSlice<UnityEngine.Vector4> get_clipRectConstants() { }
        private UnityEngine.Texture get_atlas() { }
        private System.Void Construct() { }
        private System.Void ReallyCreateStorage() { }
        private System.Void Dispose() { }
        private System.Void IssuePendingStorageChanges() { }
        private UnityEngine.UIElements.UIR.BMPAlloc AllocTransform() { }
        private UnityEngine.UIElements.UIR.BMPAlloc AllocClipRect() { }
        private UnityEngine.UIElements.UIR.BMPAlloc AllocOpacity() { }
        private UnityEngine.UIElements.UIR.BMPAlloc AllocColor() { }
        private UnityEngine.UIElements.UIR.BMPAlloc AllocTextCoreSettings(UnityEngine.UIElements.UIR.TextCoreSettings settings) { }
        private System.Void SetTransformValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.Matrix4x4 xform) { }
        private System.Void SetClipRectValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.Vector4 clipRect) { }
        private System.Void SetOpacityValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, System.Single opacity) { }
        private System.Void SetColorValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.Color color, System.Boolean isEditorContext) { }
        private System.Void SetTextCoreSettingValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.UIElements.UIR.TextCoreSettings settings, System.Boolean isEditorContext) { }
        private System.Void FreeTransform(UnityEngine.UIElements.UIR.BMPAlloc alloc) { }
        private System.Void FreeClipRect(UnityEngine.UIElements.UIR.BMPAlloc alloc) { }
        private System.Void FreeOpacity(UnityEngine.UIElements.UIR.BMPAlloc alloc) { }
        private System.Void FreeColor(UnityEngine.UIElements.UIR.BMPAlloc alloc) { }
        private System.Void FreeTextCoreSettings(UnityEngine.UIElements.UIR.BMPAlloc alloc) { }
        private UnityEngine.Color32 TransformAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc) { }
        private UnityEngine.Color32 ClipRectAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc) { }
        private UnityEngine.Color32 OpacityAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc) { }
        private UnityEngine.Color32 ColorAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc) { }
        private UnityEngine.Color32 TextCoreSettingsToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200030A
    public struct Transform3x4
    {
        // Fields
        public UnityEngine.Vector4 v0;        // 0x10
        public UnityEngine.Vector4 v1;        // 0x20
        public UnityEngine.Vector4 v2;        // 0x30

    }

    // TypeToken: 0x200030B
    public class MeshHandle : LinkedPoolItem`1
    {
        // Fields
        private UnityEngine.UIElements.UIR.Alloc allocVerts;        // 0x18
        private UnityEngine.UIElements.UIR.Alloc allocIndices;        // 0x30
        private System.UInt32 triangleCount;        // 0x48
        private UnityEngine.UIElements.UIR.Page allocPage;        // 0x50
        private System.UInt32 allocTime;        // 0x58
        private System.UInt32 updateAllocID;        // 0x5C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200030C
    public class UIRenderDevice, IDisposable
    {
        // Fields
        private readonly System.Boolean m_MockDevice;        // 0x10
        private System.IntPtr m_DefaultStencilState;        // 0x18
        private System.IntPtr m_VertexDecl;        // 0x20
        private UnityEngine.UIElements.UIR.Page m_FirstPage;        // 0x28
        private System.UInt32 m_NextPageVertexCount;        // 0x30
        private System.UInt32 m_LargeMeshVertexCount;        // 0x34
        private System.Single m_IndexToVertexCountRatio;        // 0x38
        private System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToFree>> m_DeferredFrees;        // 0x40
        private System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate>> m_Updates;        // 0x48
        private System.UInt32[] m_Fences;        // 0x50
        private UnityEngine.MaterialPropertyBlock m_StandardMatProps;        // 0x58
        private System.UInt32 m_FrameIndex;        // 0x60
        private System.UInt32 m_NextUpdateID;        // 0x64
        private UnityEngine.UIElements.UIR.UIRenderDevice.DrawStatistics m_DrawStats;        // 0x68
        private readonly UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.MeshHandle> m_MeshHandles;        // 0x90
        private readonly UnityEngine.UIElements.UIR.DrawParams m_DrawParams;        // 0x98
        private readonly UnityEngine.UIElements.UIR.TextureSlotManager m_TextureSlotManager;        // 0xA0
        private static System.Collections.Generic.LinkedList<UnityEngine.UIElements.UIR.UIRenderDevice.DeviceToFree> m_DeviceFreeQueue;        // 0x0
        private static System.Int32 m_ActiveDeviceCount;        // 0x8
        private static System.Boolean m_SubscribedToNotifications;        // 0xC
        private static System.Boolean m_SynchronousFree;        // 0xD
        private static readonly System.Int32 s_FontTexPropID;        // 0x10
        private static readonly System.Int32 s_FontTexSDFScaleID;        // 0x14
        private static readonly System.Int32 s_GradientSettingsTexID;        // 0x18
        private static readonly System.Int32 s_ShaderInfoTexID;        // 0x1C
        private static readonly System.Int32 s_TransformsPropID;        // 0x20
        private static readonly System.Int32 s_ClipRectsPropID;        // 0x24
        private static readonly System.Int32 s_ClipSpaceParamsID;        // 0x28
        private static Unity.Profiling.ProfilerMarker s_MarkerAllocate;        // 0x30
        private static Unity.Profiling.ProfilerMarker s_MarkerFree;        // 0x38
        private static Unity.Profiling.ProfilerMarker s_MarkerAdvanceFrame;        // 0x40
        private static Unity.Profiling.ProfilerMarker s_MarkerFence;        // 0x48
        private static Unity.Profiling.ProfilerMarker s_MarkerBeforeDraw;        // 0x50
        private static System.Nullable<System.Boolean> s_VertexTexturingIsAvailable;        // 0x58
        private static System.Nullable<System.Boolean> s_ShaderModelIs35;        // 0x5A
        private readonly System.UInt32 <maxVerticesPerPage>k__BackingField;        // 0xA8
        private System.Boolean <breakBatches>k__BackingField;        // 0xAC
        private static UnityEngine.Texture2D s_DefaultShaderInfoTexFloat;        // 0x60
        private static UnityEngine.Texture2D s_DefaultShaderInfoTexARGB8;        // 0x68
        private System.Boolean <disposed>k__BackingField;        // 0xAD

        // Methods
        private System.UInt32 get_maxVerticesPerPage() { }
        private System.Boolean get_breakBatches() { }
        private System.Void set_breakBatches(System.Boolean value) { }
        private System.Void .cctor() { }
        private System.Void .ctor(System.UInt32 initialVertexCapacity, System.UInt32 initialIndexCapacity) { }
        private System.Void .ctor(System.UInt32 initialVertexCapacity, System.UInt32 initialIndexCapacity, System.Boolean mockDevice) { }
        private UnityEngine.Texture2D get_defaultShaderInfoTexFloat() { }
        private UnityEngine.Texture2D get_defaultShaderInfoTexARGB8() { }
        private System.Boolean get_vertexTexturingIsAvailable() { }
        private System.Boolean get_shaderModelIs35() { }
        private System.Void InitVertexDeclaration() { }
        private System.Void CompleteCreation() { }
        private System.Boolean get_fullyCreated() { }
        private System.Boolean get_disposed() { }
        private System.Void set_disposed(System.Boolean value) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private UnityEngine.UIElements.UIR.MeshHandle Allocate(System.UInt32 vertexCount, System.UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, System.UInt16& indexOffset) { }
        private System.Void Update(UnityEngine.UIElements.UIR.MeshHandle mesh, System.UInt32 vertexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData) { }
        private System.Void Update(UnityEngine.UIElements.UIR.MeshHandle mesh, System.UInt32 vertexCount, System.UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, System.UInt16& indexOffset) { }
        private System.Void UpdateCopyBackIndices(UnityEngine.UIElements.UIR.MeshHandle mesh, System.Boolean copyBackIndices) { }
        private System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate> ActiveUpdatesForMeshHandle(UnityEngine.UIElements.UIR.MeshHandle mesh) { }
        private System.Boolean TryAllocFromPage(UnityEngine.UIElements.UIR.Page page, System.UInt32 vertexCount, System.UInt32 indexCount, UnityEngine.UIElements.UIR.Alloc& va, UnityEngine.UIElements.UIR.Alloc& ia, System.Boolean shortLived) { }
        private System.Void Allocate(UnityEngine.UIElements.UIR.MeshHandle meshHandle, System.UInt32 vertexCount, System.UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, System.Boolean shortLived) { }
        private System.Void UpdateAfterGPUUsedData(UnityEngine.UIElements.UIR.MeshHandle mesh, System.UInt32 vertexCount, System.UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, System.UInt16& indexOffset, UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate& allocToUpdate, System.Boolean copyBackIndices) { }
        private System.Void Free(UnityEngine.UIElements.UIR.MeshHandle mesh) { }
        private UnityEngine.Vector4 GetClipSpaceParams() { }
        private System.Void OnFrameRenderingBegin() { }
        private Unity.Collections.NativeSlice<T> PtrToSlice(System.Void* p, System.Int32 count) { }
        private System.Void ApplyDrawCommandState(UnityEngine.UIElements.UIR.RenderChainCommand cmd, System.Int32 textureSlot, UnityEngine.Material newMat, System.Boolean newMatDiffers, System.Boolean newFontDiffers, UnityEngine.UIElements.UIR.UIRenderDevice.EvaluationState& st) { }
        private System.Void ApplyBatchState(UnityEngine.UIElements.UIR.UIRenderDevice.EvaluationState& st, System.Boolean allowMaterialChange) { }
        private System.Void EvaluateChain(UnityEngine.UIElements.UIR.RenderChainCommand head, UnityEngine.Material initialMat, UnityEngine.Material defaultMat, UnityEngine.Texture gradientSettings, UnityEngine.Texture shaderInfo, System.Single pixelsPerPoint, Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> transforms, Unity.Collections.NativeSlice<UnityEngine.Vector4> clipRects, UnityEngine.MaterialPropertyBlock stateMatProps, System.Boolean allowMaterialChange, System.Exception& immediateException) { }
        private System.Void UpdateFenceValue() { }
        private System.Void KickRanges(UnityEngine.UIElements.UIR.DrawBufferRange* ranges, System.Int32& rangesReady, System.Int32& rangesStart, System.Int32 rangesCount, UnityEngine.UIElements.UIR.Page curPage) { }
        private System.Void DrawRanges(UnityEngine.UIElements.UIR.Utility.GPUBuffer<I> ib, UnityEngine.UIElements.UIR.Utility.GPUBuffer<T> vb, Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.DrawBufferRange> ranges) { }
        private System.Void WaitOnCpuFence(System.UInt32 fence) { }
        private System.Void AdvanceFrame() { }
        private System.Void PruneUnusedPages() { }
        private System.Void PrepareForGfxDeviceRecreate() { }
        private System.Void WrapUpGfxDeviceRecreate() { }
        private System.Void FlushAllPendingDeviceDisposes() { }
        private UnityEngine.UIElements.UIR.UIRenderDevice.DrawStatistics GatherDrawStatistics() { }
        private System.Void ProcessDeviceFreeQueue() { }
        private System.Void OnEngineUpdateGlobal() { }
        private System.Void OnFlushPendingResources() { }

    }

    // TypeToken: 0x2000313
    public struct Alloc
    {
        // Fields
        public System.UInt32 start;        // 0x10
        public System.UInt32 size;        // 0x14
        private System.Object handle;        // 0x18
        private System.Boolean shortLived;        // 0x20

    }

    // TypeToken: 0x2000314
    public class BestFitAllocator
    {
        // Fields
        private readonly System.UInt32 <totalSize>k__BackingField;        // 0x10
        private UnityEngine.UIElements.UIR.BestFitAllocator.Block m_FirstBlock;        // 0x18
        private UnityEngine.UIElements.UIR.BestFitAllocator.Block m_FirstAvailableBlock;        // 0x20
        private UnityEngine.UIElements.UIR.BestFitAllocator.BlockPool m_BlockPool;        // 0x28
        private System.UInt32 m_HighWatermark;        // 0x30

        // Methods
        private System.Void .ctor(System.UInt32 size) { }
        private System.UInt32 get_totalSize() { }
        private System.UInt32 get_highWatermark() { }
        private UnityEngine.UIElements.UIR.Alloc Allocate(System.UInt32 size) { }
        private System.Void Free(UnityEngine.UIElements.UIR.Alloc alloc) { }
        private UnityEngine.UIElements.UIR.BestFitAllocator.Block CoalesceBlockWithPrevious(UnityEngine.UIElements.UIR.BestFitAllocator.Block block) { }
        private UnityEngine.UIElements.UIR.BestFitAllocator.Block BestFitFindAvailableBlock(System.UInt32 size) { }
        private System.Void SplitBlock(UnityEngine.UIElements.UIR.BestFitAllocator.Block block, System.UInt32 size) { }

    }

    // TypeToken: 0x2000317
    public class GPUBufferAllocator
    {
        // Fields
        private UnityEngine.UIElements.UIR.BestFitAllocator m_Low;        // 0x10
        private UnityEngine.UIElements.UIR.BestFitAllocator m_High;        // 0x18

        // Methods
        private System.Void .ctor(System.UInt32 maxSize) { }
        private UnityEngine.UIElements.UIR.Alloc Allocate(System.UInt32 size, System.Boolean shortLived) { }
        private System.Void Free(UnityEngine.UIElements.UIR.Alloc alloc) { }
        private System.Boolean get_isEmpty() { }
        private System.Boolean HighLowCollide() { }

    }

    // TypeToken: 0x2000318
    public class Page, IDisposable
    {
        // Fields
        private System.Boolean <disposed>k__BackingField;        // 0x10
        public UnityEngine.UIElements.UIR.Page.DataSet<UnityEngine.UIElements.Vertex> vertices;        // 0x18
        public UnityEngine.UIElements.UIR.Page.DataSet<System.UInt16> indices;        // 0x20
        public UnityEngine.UIElements.UIR.Page next;        // 0x28
        public System.Int32 framesEmpty;        // 0x30

        // Methods
        private System.Void .ctor(System.UInt32 vertexMaxCount, System.UInt32 indexMaxCount, System.UInt32 maxQueuedFrameCount, System.Boolean mockPage) { }
        private System.Boolean get_disposed() { }
        private System.Void set_disposed(System.Boolean value) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Boolean get_isEmpty() { }

    }

    // TypeToken: 0x200031A
    public struct VertexFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.UIR.VertexFlags IsSolid;        // 0x0
        public static UnityEngine.UIElements.UIR.VertexFlags IsText;        // 0x0
        public static UnityEngine.UIElements.UIR.VertexFlags IsTextured;        // 0x0
        public static UnityEngine.UIElements.UIR.VertexFlags IsDynamic;        // 0x0
        public static UnityEngine.UIElements.UIR.VertexFlags IsSvgGradients;        // 0x0
        public static UnityEngine.UIElements.UIR.VertexFlags LastType;        // 0x0
        public static UnityEngine.UIElements.UIR.VertexFlags IsGraphViewEdge;        // 0x0

    }

    // TypeToken: 0x200031B
    public struct State
    {
        // Fields
        public UnityEngine.Material material;        // 0x10
        public UnityEngine.Texture font;        // 0x18
        public System.Single fontTexSDFScale;        // 0x20
        public UnityEngine.UIElements.TextureId texture;        // 0x24
        public System.Int32 stencilRef;        // 0x28

    }

    // TypeToken: 0x200031C
    public struct CommandType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.UIR.CommandType Draw;        // 0x0
        public static UnityEngine.UIElements.UIR.CommandType ImmediateCull;        // 0x0
        public static UnityEngine.UIElements.UIR.CommandType Immediate;        // 0x0
        public static UnityEngine.UIElements.UIR.CommandType PushView;        // 0x0
        public static UnityEngine.UIElements.UIR.CommandType PopView;        // 0x0
        public static UnityEngine.UIElements.UIR.CommandType PushScissor;        // 0x0
        public static UnityEngine.UIElements.UIR.CommandType PopScissor;        // 0x0
        public static UnityEngine.UIElements.UIR.CommandType PushRenderTexture;        // 0x0
        public static UnityEngine.UIElements.UIR.CommandType PopRenderTexture;        // 0x0
        public static UnityEngine.UIElements.UIR.CommandType BlitToPreviousRT;        // 0x0
        public static UnityEngine.UIElements.UIR.CommandType PushDefaultMaterial;        // 0x0
        public static UnityEngine.UIElements.UIR.CommandType PopDefaultMaterial;        // 0x0

    }

    // TypeToken: 0x200031D
    public class DrawParams
    {
        // Fields
        private static readonly UnityEngine.Rect k_UnlimitedRect;        // 0x0
        private static readonly UnityEngine.Rect k_FullNormalizedRect;        // 0x10
        private readonly System.Collections.Generic.Stack<UnityEngine.Matrix4x4> view;        // 0x10
        private readonly System.Collections.Generic.Stack<UnityEngine.Rect> scissor;        // 0x18
        private readonly System.Collections.Generic.List<UnityEngine.RenderTexture> renderTexture;        // 0x20
        private readonly System.Collections.Generic.List<UnityEngine.Material> defaultMaterial;        // 0x28

        // Methods
        private System.Void Reset() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200031E
    public class RenderChainCommand : LinkedPoolItem`1
    {
        // Fields
        private UnityEngine.UIElements.VisualElement owner;        // 0x18
        private UnityEngine.UIElements.UIR.RenderChainCommand prev;        // 0x20
        private UnityEngine.UIElements.UIR.RenderChainCommand next;        // 0x28
        private System.Boolean closing;        // 0x30
        private UnityEngine.UIElements.UIR.CommandType type;        // 0x34
        private UnityEngine.UIElements.UIR.State state;        // 0x38
        private UnityEngine.UIElements.UIR.MeshHandle mesh;        // 0x58
        private System.Int32 indexOffset;        // 0x60
        private System.Int32 indexCount;        // 0x64
        private System.Action callback;        // 0x68
        private static readonly System.Int32 k_ID_MainTex;        // 0x0
        private static Unity.Profiling.ProfilerMarker s_ImmediateOverheadMarker;        // 0x8

        // Methods
        private System.Void Reset() { }
        private System.Void ExecuteNonDrawMesh(UnityEngine.UIElements.UIR.DrawParams drawParams, System.Single pixelsPerPoint, System.Exception& immediateException) { }
        private System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture destination, System.Single depth) { }
        private UnityEngine.Rect CombineScissorRects(UnityEngine.Rect r0, UnityEngine.Rect r1) { }
        private UnityEngine.RectInt RectPointsToPixelsAndFlipYAxis(UnityEngine.Rect rect, System.Single pixelsPerPoint) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

}

namespace UnityEngine.UIElements.UIR.Implementation
{

    // TypeToken: 0x200031F
    public class CommandGenerator
    {
        // Fields
        private static readonly Unity.Profiling.ProfilerMarker k_ConvertEntriesToCommandsMarker;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker k_NudgeVerticesMarker;        // 0x8
        private static readonly Unity.Profiling.ProfilerMarker k_ComputeTransformMatrixMarker;        // 0x10
        private static UnityEngine.Material s_blitMaterial_LinearToGamma;        // 0x18
        private static UnityEngine.Material s_blitMaterial_GammaToLinear;        // 0x20
        private static UnityEngine.Material s_blitMaterial_NoChange;        // 0x28
        private static UnityEngine.Shader s_blitShader;        // 0x30

        // Methods
        private System.Void GetVerticesTransformInfo(UnityEngine.UIElements.VisualElement ve, UnityEngine.Matrix4x4& transform) { }
        private System.Void ComputeTransformMatrix(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VisualElement ancestor, UnityEngine.Matrix4x4& result) { }
        private System.Boolean IsParentOrAncestorOf(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VisualElement child) { }
        private UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo PaintElement(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.ChainBuilderStats& stats) { }
        private UnityEngine.Material CreateBlitShader(System.Single colorConversion) { }
        private UnityEngine.Material GetBlitMaterial(UnityEngine.UIElements.VisualElement.RenderTargetMode mode) { }
        private System.Void ClosePaintElement(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo closingInfo, UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.ChainBuilderStats& stats) { }
        private System.Void UpdateOrAllocate(UnityEngine.UIElements.UIR.MeshHandle& data, System.Int32 vertexCount, System.Int32 indexCount, UnityEngine.UIElements.UIR.UIRenderDevice device, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& verts, Unity.Collections.NativeSlice<System.UInt16>& indices, System.UInt16& indexOffset, UnityEngine.UIElements.UIR.ChainBuilderStats& stats) { }
        private System.Void CopyTransformVertsPos(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> source, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> target, UnityEngine.Matrix4x4 mat, UnityEngine.Color32 xformClipPages, UnityEngine.Color32 ids, UnityEngine.Color32 addFlags, UnityEngine.Color32 opacityPage, UnityEngine.Color32 textCoreSettingsPage, System.Boolean isText, System.Single textureId) { }
        private System.Void CopyTransformVertsPosAndVec(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> source, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> target, UnityEngine.Matrix4x4 mat, UnityEngine.Color32 xformClipPages, UnityEngine.Color32 ids, UnityEngine.Color32 addFlags, UnityEngine.Color32 opacityPage, UnityEngine.Color32 textCoreSettingsPage, System.Boolean isText, System.Single textureId) { }
        private System.Void CopyTriangleIndicesFlipWindingOrder(Unity.Collections.NativeSlice<System.UInt16> source, Unity.Collections.NativeSlice<System.UInt16> target, System.Int32 indexOffset) { }
        private System.Void CopyTriangleIndices(Unity.Collections.NativeSlice<System.UInt16> source, Unity.Collections.NativeSlice<System.UInt16> target, System.Int32 indexOffset) { }
        private System.Boolean NudgeVerticesToNewSpace(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.UIRenderDevice device) { }
        private System.Void DoNudgeVertices(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.UIRenderDevice device, UnityEngine.UIElements.UIR.MeshHandle mesh, UnityEngine.Matrix4x4& nudgeTransform) { }
        private UnityEngine.UIElements.UIR.RenderChainCommand InjectMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderChainCommand& cmdPrev, UnityEngine.UIElements.UIR.RenderChainCommand& cmdNext, UnityEngine.UIElements.UIR.MeshHandle mesh, System.Int32 indexCount, System.Int32 indexOffset, UnityEngine.Material material, UnityEngine.UIElements.TextureId texture, UnityEngine.Texture font, System.Int32 stencilRef) { }
        private UnityEngine.UIElements.UIR.RenderChainCommand InjectClosingMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderChainCommand& cmdPrev, UnityEngine.UIElements.UIR.RenderChainCommand& cmdNext, UnityEngine.UIElements.UIR.MeshHandle mesh, System.Int32 indexCount, System.Int32 indexOffset, UnityEngine.Material material, UnityEngine.UIElements.TextureId texture, UnityEngine.Texture font, System.Int32 stencilRef) { }
        private System.Void FindCommandInsertionPoint(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderChainCommand& prev, UnityEngine.UIElements.UIR.RenderChainCommand& next) { }
        private System.Void FindClosingCommandInsertionPoint(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderChainCommand& prev, UnityEngine.UIElements.UIR.RenderChainCommand& next) { }
        private System.Void InjectCommandInBetween(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.RenderChainCommand cmd, UnityEngine.UIElements.UIR.RenderChainCommand& prev, UnityEngine.UIElements.UIR.RenderChainCommand& next) { }
        private System.Void InjectClosingCommandInBetween(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.RenderChainCommand cmd, UnityEngine.UIElements.UIR.RenderChainCommand& prev, UnityEngine.UIElements.UIR.RenderChainCommand& next) { }
        private System.Void ResetCommands(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000320
    public struct ClipMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.UIElements.UIR.Implementation.ClipMethod Undetermined;        // 0x0
        public static UnityEngine.UIElements.UIR.Implementation.ClipMethod NotClipped;        // 0x0
        public static UnityEngine.UIElements.UIR.Implementation.ClipMethod Scissor;        // 0x0
        public static UnityEngine.UIElements.UIR.Implementation.ClipMethod ShaderDiscard;        // 0x0
        public static UnityEngine.UIElements.UIR.Implementation.ClipMethod Stencil;        // 0x0

    }

    // TypeToken: 0x2000321
    public class RenderEvents
    {
        // Fields
        private static readonly System.Single VisibilityTreshold;        // 0x0

        // Methods
        private System.Void ProcessOnClippingChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats) { }
        private System.Void ProcessOnOpacityChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats) { }
        private System.Void ProcessOnColorChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats) { }
        private System.Void ProcessOnTransformOrSizeChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats) { }
        private System.Void ProcessOnVisualsChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats) { }
        private System.Void ProcessRegenText(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.Implementation.UIRTextUpdatePainter painter, UnityEngine.UIElements.UIR.UIRenderDevice device, UnityEngine.UIElements.UIR.ChainBuilderStats& stats) { }
        private UnityEngine.Matrix4x4 GetTransformIDTransformInfo(UnityEngine.UIElements.VisualElement ve) { }
        private UnityEngine.Vector4 GetClipRectIDClipInfo(UnityEngine.UIElements.VisualElement ve) { }
        private System.UInt32 DepthFirstOnChildAdded(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement parent, UnityEngine.UIElements.VisualElement ve, System.Int32 index, System.Boolean resetState) { }
        private System.UInt32 DepthFirstOnChildRemoving(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve) { }
        private System.Void DepthFirstOnClippingChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement parent, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, System.Boolean hierarchical, System.Boolean isRootOfChange, System.Boolean isPendingHierarchicalRepaint, System.Boolean inheritedClipRectIDChanged, System.Boolean inheritedMaskingChanged, UnityEngine.UIElements.UIR.UIRenderDevice device, UnityEngine.UIElements.UIR.ChainBuilderStats& stats) { }
        private System.Void DepthFirstOnOpacityChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, System.Single parentCompositeOpacity, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, System.Boolean hierarchical, UnityEngine.UIElements.UIR.ChainBuilderStats& stats, System.Boolean isDoingFullVertexRegeneration) { }
        private System.Void OnColorChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats) { }
        private System.Void DepthFirstOnTransformOrSizeChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement parent, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.UIRenderDevice device, System.Boolean isAncestorOfChangeSkinned, System.Boolean transformChanged, UnityEngine.UIElements.UIR.ChainBuilderStats& stats) { }
        private System.Void DepthFirstOnVisualsChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, System.Boolean parentHierarchyHidden, System.Boolean hierarchical, UnityEngine.UIElements.UIR.ChainBuilderStats& stats) { }
        private System.Boolean UpdateTextCoreSettings(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve) { }
        private System.Boolean IsElementHierarchyHidden(UnityEngine.UIElements.VisualElement ve) { }
        private UnityEngine.UIElements.VisualElement GetLastDeepestChild(UnityEngine.UIElements.VisualElement ve) { }
        private UnityEngine.UIElements.UIR.Implementation.ClipMethod DetermineSelfClipMethod(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve) { }
        private System.Boolean UpdateLocalFlipsWinding(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void UpdateWorldFlipsWinding(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void UpdateZeroScaling(UnityEngine.UIElements.VisualElement ve) { }
        private System.Boolean NeedsTransformID(UnityEngine.UIElements.VisualElement ve) { }
        private System.Boolean NeedsColorID(UnityEngine.UIElements.VisualElement ve) { }
        private System.Boolean InitColorIDs(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve) { }
        private System.Void SetColorValues(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000322
    public class UIRStylePainter, IStylePainter, IDisposable
    {
        // Fields
        private UnityEngine.UIElements.UIR.RenderChain m_Owner;        // 0x10
        private System.Collections.Generic.List<UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entry> m_Entries;        // 0x18
        private UnityEngine.UIElements.AtlasBase m_Atlas;        // 0x20
        private UnityEngine.UIElements.UIR.VectorImageManager m_VectorImageManager;        // 0x28
        private UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entry m_CurrentEntry;        // 0x30
        private UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo m_ClosingInfo;        // 0x90
        private System.Int32 m_MaskDepth;        // 0xC8
        private System.Int32 m_StencilRef;        // 0xCC
        private UnityEngine.UIElements.UIR.BMPAlloc m_ClipRectID;        // 0xD0
        private System.Int32 m_SVGBackgroundEntryIndex;        // 0xD8
        private UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.TempDataAlloc<UnityEngine.UIElements.Vertex> m_VertsPool;        // 0xE0
        private UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.TempDataAlloc<System.UInt16> m_IndicesPool;        // 0x108
        private System.Collections.Generic.List<UnityEngine.UIElements.MeshWriteData> m_MeshWriteDataPool;        // 0x130
        private System.Int32 m_NextMeshWriteDataPoolItem;        // 0x138
        private UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocator m_AllocRawVertsIndicesDelegate;        // 0x140
        private UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawMeshDelegate;        // 0x148
        private UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawGradientsDelegate;        // 0x150
        private readonly UnityEngine.UIElements.MeshGenerationContext <meshGenerationContext>k__BackingField;        // 0x158
        private UnityEngine.UIElements.VisualElement <currentElement>k__BackingField;        // 0x160
        private System.Int32 <totalVertices>k__BackingField;        // 0x168
        private System.Int32 <totalIndices>k__BackingField;        // 0x16C
        private System.Boolean <disposed>k__BackingField;        // 0x170

        // Methods
        private UnityEngine.UIElements.MeshWriteData GetPooledMeshWriteData() { }
        private UnityEngine.UIElements.MeshWriteData AllocRawVertsIndices(System.UInt32 vertexCount, System.UInt32 indexCount, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData& allocatorData) { }
        private UnityEngine.UIElements.MeshWriteData AllocThroughDrawMesh(System.UInt32 vertexCount, System.UInt32 indexCount, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData& allocatorData) { }
        private UnityEngine.UIElements.MeshWriteData AllocThroughDrawGradients(System.UInt32 vertexCount, System.UInt32 indexCount, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData& allocatorData) { }
        private System.Void .ctor(UnityEngine.UIElements.UIR.RenderChain renderChain) { }
        private UnityEngine.UIElements.MeshGenerationContext get_meshGenerationContext() { }
        private UnityEngine.UIElements.VisualElement get_currentElement() { }
        private System.Void set_currentElement(UnityEngine.UIElements.VisualElement value) { }
        private System.Collections.Generic.List<UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entry> get_entries() { }
        private UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo get_closingInfo() { }
        private System.Int32 get_totalVertices() { }
        private System.Void set_totalVertices(System.Int32 value) { }
        private System.Int32 get_totalIndices() { }
        private System.Void set_totalIndices(System.Int32 value) { }
        private System.Boolean get_disposed() { }
        private System.Void set_disposed(System.Boolean value) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Begin(UnityEngine.UIElements.VisualElement ve) { }
        private System.Void LandClipUnregisterMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChainCommand cmd) { }
        private System.Void LandClipRegisterMesh(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices, System.Int32 indexOffset) { }
        private UnityEngine.UIElements.MeshWriteData AddGradientsEntry(System.Int32 vertexCount, System.Int32 indexCount, UnityEngine.UIElements.TextureId texture, UnityEngine.Material material, UnityEngine.UIElements.MeshGenerationContext.MeshFlags flags) { }
        private UnityEngine.UIElements.MeshWriteData DrawMesh(System.Int32 vertexCount, System.Int32 indexCount, UnityEngine.Texture texture, UnityEngine.Material material, UnityEngine.UIElements.MeshGenerationContext.MeshFlags flags) { }
        private System.Void DrawText(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint) { }
        private System.Void DrawTextNative(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint) { }
        private System.Void DrawTextCore(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint) { }
        private System.Void DrawRectangle(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams) { }
        private System.Void DrawBorder(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams borderParams) { }
        private System.Void DrawImmediate(System.Action callback, System.Boolean cullingEnabled) { }
        private UnityEngine.UIElements.VisualElement get_visualElement() { }
        private System.Void DrawVisualElementBackground() { }
        private System.Void DrawVisualElementBorder() { }
        private System.Void ApplyVisualElementClipping() { }
        private System.UInt16[] AdjustSpriteWinding(UnityEngine.Vector2[] vertices, System.UInt16[] indices) { }
        private System.Void DrawSprite(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams) { }
        private System.Void ApplyInset(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams& rectParams, UnityEngine.Texture tex) { }
        private System.Void DrawVectorImage(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams) { }
        private System.Void Reset() { }
        private System.Void ValidateMeshWriteData() { }
        private System.Void GenerateStencilClipEntryForRoundedRectBackground() { }
        private System.Void GenerateStencilClipEntryForSVGBackground() { }

    }

    // TypeToken: 0x2000326
    public class UIRTextUpdatePainter, IStylePainter, IDisposable
    {
        // Fields
        private UnityEngine.UIElements.VisualElement m_CurrentElement;        // 0x10
        private System.Int32 m_TextEntryIndex;        // 0x18
        private Unity.Collections.NativeArray<UnityEngine.UIElements.Vertex> m_DudVerts;        // 0x20
        private Unity.Collections.NativeArray<System.UInt16> m_DudIndices;        // 0x30
        private Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> m_MeshDataVerts;        // 0x40
        private UnityEngine.Color32 m_XFormClipPages;        // 0x50
        private UnityEngine.Color32 m_IDs;        // 0x54
        private UnityEngine.Color32 m_Flags;        // 0x58
        private UnityEngine.Color32 m_OpacityColorPages;        // 0x5C
        private readonly UnityEngine.UIElements.MeshGenerationContext <meshGenerationContext>k__BackingField;        // 0x60

        // Methods
        private UnityEngine.UIElements.MeshGenerationContext get_meshGenerationContext() { }
        private System.Void .ctor() { }
        private System.Void Begin(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.UIRenderDevice device) { }
        private System.Void End() { }
        private System.Void Dispose() { }
        private System.Void DrawRectangle(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams) { }
        private System.Void DrawImmediate(System.Action callback, System.Boolean cullingEnabled) { }
        private System.Void DrawText(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint) { }

    }

}

