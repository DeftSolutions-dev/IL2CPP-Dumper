// ========================================================
// Dumped by @desirepro
// Assembly: UnityEngine.UIElementsModule.dll
// Classes:  869
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: TextureInfo
TYPE:  class
TOKEN: 0x2000009
EXTENDS: LinkedPoolItem`1
FIELDS:
  public            UnityEngine.UIElements.DynamicAtlasPagepage  // 0x18
  public            System.Int32                    counter  // 0x20
  public            UnityEngine.UIElements.UIR.Allocator2D.Alloc2Dalloc  // 0x28
  public            UnityEngine.RectInt             rect  // 0x58
  public    static readonly UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.DynamicAtlas.TextureInfo>pool  // 0x0
METHODS:
  UnityEngine.UIElements.DynamicAtlas.TextureInfo Create()
  System.Void Reset(UnityEngine.UIElements.DynamicAtlas.TextureInfo info)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200000B
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200000C
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_PropertyPath  // 0x70
METHODS:
  System.Void .ctor()
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
END_CLASS

CLASS: DragDirection
TYPE:  struct
TOKEN: 0x200000E
FIELDS:
  public            System.Int32                    value__  // 0x0
  public    static  UnityEngine.UIElements.ClampedDragger.DragDirection<T>None  // 0x0
  public    static  UnityEngine.UIElements.ClampedDragger.DragDirection<T>LowToHigh  // 0x0
  public    static  UnityEngine.UIElements.ClampedDragger.DragDirection<T>HighToLow  // 0x0
  public    static  UnityEngine.UIElements.ClampedDragger.DragDirection<T>Free  // 0x0
METHODS:
END_CLASS

CLASS: ButtonClickStatus
TYPE:  class
TOKEN: 0x2000011
FIELDS:
  public            UnityEngine.UIElements.VisualElementm_Target  // 0x10
  public            UnityEngine.Vector3             m_PointerDownPosition  // 0x18
  public            System.Int64                    m_LastPointerDownTime  // 0x28
  public            System.Int32                    m_ClickCount  // 0x30
METHODS:
  System.Void Reset()
  System.Void .ctor()
END_CLASS

CLASS: UpdateMode
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DefaultEventSystem.UpdateModeAlways  // 0x0
  public    static  UnityEngine.UIElements.DefaultEventSystem.UpdateModeIgnoreIfAppNotFocused  // 0x0
METHODS:
END_CLASS

CLASS: IInput
TYPE:  interface
TOKEN: 0x200001C
FIELDS:
METHODS:
  System.Boolean GetButtonDown(System.String button)
  System.Single GetAxisRaw(System.String axis)
  System.Int32 get_touchCount()
  UnityEngine.Touch GetTouch(System.Int32 index)
  System.Boolean get_mousePresent()
END_CLASS

CLASS: Input
TYPE:  class
TOKEN: 0x200001D
FIELDS:
METHODS:
  System.Boolean GetButtonDown(System.String button)
  System.Single GetAxisRaw(System.String axis)
  System.Int32 get_touchCount()
  UnityEngine.Touch GetTouch(System.Int32 index)
  System.Boolean get_mousePresent()
  System.Void .ctor()
END_CLASS

CLASS: NoInput
TYPE:  class
TOKEN: 0x200001E
FIELDS:
METHODS:
  System.Boolean GetButtonDown(System.String button)
  System.Single GetAxisRaw(System.String axis)
  System.Int32 get_touchCount()
  UnityEngine.Touch GetTouch(System.Int32 index)
  System.Boolean get_mousePresent()
  System.Void .ctor()
END_CLASS

CLASS: Status
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DropdownMenuAction.StatusNone  // 0x0
  public    static  UnityEngine.UIElements.DropdownMenuAction.StatusNormal  // 0x0
  public    static  UnityEngine.UIElements.DropdownMenuAction.StatusDisabled  // 0x0
  public    static  UnityEngine.UIElements.DropdownMenuAction.StatusChecked  // 0x0
  public    static  UnityEngine.UIElements.DropdownMenuAction.StatusHidden  // 0x0
METHODS:
END_CLASS

CLASS: EventRecord
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  public            UnityEngine.UIElements.EventBasem_Event  // 0x10
  public            UnityEngine.UIElements.IPanel   m_Panel  // 0x18
METHODS:
END_CLASS

CLASS: DispatchContext
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.UInt32                   m_GateCount  // 0x10
  public            System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord>m_Queue  // 0x18
METHODS:
END_CLASS

CLASS: FocusedElement
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            UnityEngine.UIElements.VisualElementm_SubTreeRoot  // 0x10
  public            UnityEngine.UIElements.Focusablem_FocusedElement  // 0x18
METHODS:
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200003A
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200003B
EXTENDS: UxmlTraits
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: GUIGlobals
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            UnityEngine.Matrix4x4           matrix  // 0x10
  public            UnityEngine.Color               color  // 0x50
  public            UnityEngine.Color               contentColor  // 0x60
  public            UnityEngine.Color               backgroundColor  // 0x70
  public            System.Boolean                  enabled  // 0x80
  public            System.Boolean                  changed  // 0x81
  public            System.Int32                    displayIndex  // 0x84
METHODS:
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000078
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000079
EXTENDS: UxmlTraits
FIELDS:
  protected         UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Name  // 0x18
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_ViewDataKey  // 0x20
  protected         UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.PickingMode>m_PickingMode  // 0x28
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Tooltip  // 0x30
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.UsageHints>m_UsageHints  // 0x38
  private           UnityEngine.UIElements.UxmlIntAttributeDescription<focusIndex>k__BackingField  // 0x40
  private           UnityEngine.UIElements.UxmlIntAttributeDescriptionm_TabIndex  // 0x48
  private           UnityEngine.UIElements.UxmlBoolAttributeDescription<focusable>k__BackingField  // 0x50
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Class  // 0x58
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_ContentContainer  // 0x60
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Style  // 0x68
METHODS:
  UnityEngine.UIElements.UxmlIntAttributeDescription get_focusIndex()
  UnityEngine.UIElements.UxmlBoolAttributeDescription get_focusable()
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: MeasureMode
TYPE:  struct
TOKEN: 0x200007A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.VisualElement.MeasureModeUndefined  // 0x0
  public    static  UnityEngine.UIElements.VisualElement.MeasureModeExactly  // 0x0
  public    static  UnityEngine.UIElements.VisualElement.MeasureModeAtMost  // 0x0
METHODS:
END_CLASS

CLASS: RenderTargetMode
TYPE:  struct
TOKEN: 0x200007B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.VisualElement.RenderTargetModeNone  // 0x0
  public    static  UnityEngine.UIElements.VisualElement.RenderTargetModeNoColorConversion  // 0x0
  public    static  UnityEngine.UIElements.VisualElement.RenderTargetModeLinearToGamma  // 0x0
  public    static  UnityEngine.UIElements.VisualElement.RenderTargetModeGammaToLinear  // 0x0
METHODS:
END_CLASS

CLASS: Hierarchy
TYPE:  struct
TOKEN: 0x200007C
FIELDS:
  private   static  System.String                   k_InvalidHierarchyChangeMsg  // 0x0
  private   readonly UnityEngine.UIElements.VisualElementm_Owner  // 0x10
METHODS:
  UnityEngine.UIElements.VisualElement get_parent()
  System.Void .ctor(UnityEngine.UIElements.VisualElement element)
  System.Void Add(UnityEngine.UIElements.VisualElement child)
  System.Void Insert(System.Int32 index, UnityEngine.UIElements.VisualElement child)
  System.Void Remove(UnityEngine.UIElements.VisualElement child)
  System.Void RemoveAt(System.Int32 index)
  System.Void Clear()
  System.Void BringToFront(UnityEngine.UIElements.VisualElement child)
  System.Void SendToBack(UnityEngine.UIElements.VisualElement child)
  System.Void PlaceBehind(UnityEngine.UIElements.VisualElement child, UnityEngine.UIElements.VisualElement over)
  System.Void MoveChildElement(UnityEngine.UIElements.VisualElement child, System.Int32 currentIndex, System.Int32 nextIndex)
  System.Int32 get_childCount()
  UnityEngine.UIElements.VisualElement get_Item(System.Int32 key)
  System.Int32 IndexOf(UnityEngine.UIElements.VisualElement element)
  UnityEngine.UIElements.VisualElement ElementAt(System.Int32 index)
  System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children()
  System.Void SetParent(UnityEngine.UIElements.VisualElement value)
  System.Void PutChildAtIndex(UnityEngine.UIElements.VisualElement child, System.Int32 index)
  System.Void RemoveChildAtIndex(System.Int32 index)
  System.Void ReleaseChildList()
  System.Boolean Equals(UnityEngine.UIElements.VisualElement.Hierarchy other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.UIElements.VisualElement.Hierarchy x, UnityEngine.UIElements.VisualElement.Hierarchy y)
END_CLASS

CLASS: BaseVisualElementScheduledItem
TYPE:  class
TOKEN: 0x200007D
EXTENDS: ScheduledItem
FIELDS:
  private           UnityEngine.UIElements.VisualElement<element>k__BackingField  // 0x38
  public            System.Boolean                  isScheduled  // 0x40
  private           UnityEngine.UIElements.VisualElementPanelActivatorm_Activator  // 0x48
METHODS:
  UnityEngine.UIElements.VisualElement get_element()
  System.Void set_element(UnityEngine.UIElements.VisualElement value)
  System.Boolean get_isActive()
  System.Void .ctor(UnityEngine.UIElements.VisualElement handler)
  UnityEngine.UIElements.IVisualElementScheduledItem StartingIn(System.Int64 delayMs)
  UnityEngine.UIElements.IVisualElementScheduledItem Every(System.Int64 intervalMs)
  System.Void OnItemUnscheduled()
  System.Void Resume()
  System.Void Pause()
  System.Void ExecuteLater(System.Int64 delayMs)
  System.Void OnPanelActivate()
  System.Void OnPanelDeactivate()
  System.Boolean CanBeActivated()
END_CLASS

CLASS: VisualElementScheduledItem`1
TYPE:  class
TOKEN: 0x200007E
EXTENDS: BaseVisualElementScheduledItem
FIELDS:
  public            ActionType                      updateEvent  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.UIElements.VisualElement handler, ActionType upEvent)
END_CLASS

CLASS: TimerStateScheduledItem
TYPE:  class
TOKEN: 0x200007F
EXTENDS: VisualElementScheduledItem`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.UIElements.VisualElement handler, System.Action<UnityEngine.UIElements.TimerState> updateEvent)
  System.Void PerformTimerUpdate(UnityEngine.UIElements.TimerState state)
END_CLASS

CLASS: SimpleScheduledItem
TYPE:  class
TOKEN: 0x2000080
EXTENDS: VisualElementScheduledItem`1
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.UIElements.VisualElement handler, System.Action updateEvent)
  System.Void PerformTimerUpdate(UnityEngine.UIElements.TimerState state)
END_CLASS

CLASS: CustomStyleAccess
TYPE:  class
TOKEN: 0x2000081
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue>m_CustomProperties  // 0x10
  private           System.Single                   m_DpiScaling  // 0x18
METHODS:
  System.Void SetContext(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue> customProperties, System.Single dpiScaling)
  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Single> property, System.Single& value)
  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Int32> property, System.Int32& value)
  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> property, UnityEngine.Color& value)
  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> property, UnityEngine.Texture2D& value)
  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> property, UnityEngine.Sprite& value)
  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> property, UnityEngine.UIElements.VectorImage& value)
  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.String> property, System.String& value)
  System.Boolean TryGetValue(System.String propertyName, UnityEngine.UIElements.StyleValueType valueType, UnityEngine.UIElements.StyleSheets.StylePropertyValue& customProp)
  System.Void LogCustomPropertyWarning(System.String propertyName, UnityEngine.UIElements.StyleValueType valueType, UnityEngine.UIElements.StyleSheets.StylePropertyValue customProp)
  System.Void .ctor()
END_CLASS

CLASS: TypeData
TYPE:  class
TOKEN: 0x2000082
FIELDS:
  private   readonly System.Type                     <type>k__BackingField  // 0x10
  private           System.String                   m_FullTypeName  // 0x18
  private           System.String                   m_TypeName  // 0x20
METHODS:
  System.Type get_type()
  System.Void .ctor(System.Type type)
  System.String get_fullTypeName()
  System.String get_typeName()
END_CLASS

CLASS: TransitionState
TYPE:  struct
TOKEN: 0x2000086
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionStateNone  // 0x0
  public    static  UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionStateRunning  // 0x0
  public    static  UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionStateStarted  // 0x0
  public    static  UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionStateEnded  // 0x0
  public    static  UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionStateCanceled  // 0x0
METHODS:
END_CLASS

CLASS: AnimationDataSet`2
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  public            UnityEngine.UIElements.VisualElement[]elements  // 0x0
  public            UnityEngine.UIElements.StyleSheets.StylePropertyId[]properties  // 0x0
  public            TTimingData[]                   timing  // 0x0
  public            TStyleData[]                    style  // 0x0
  public            System.Int32                    count  // 0x0
  private           System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair,System.Int32>indices  // 0x0
METHODS:
  System.Int32 get_capacity()
  System.Void set_capacity(System.Int32 value)
  System.Void LocalInit()
  UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<TTimingData,TStyleData> Create()
  System.Boolean IndexOf(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, System.Int32& index)
  System.Void Add(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, TTimingData timingData, TStyleData styleData)
  System.Void Remove(System.Int32 cancelledIndex)
  System.Void Replace(System.Int32 index, TTimingData timingData, TStyleData styleData)
  System.Void RemoveAll(UnityEngine.UIElements.VisualElement ve)
  System.Void RemoveAll()
  System.Void GetActivePropertiesForElement(UnityEngine.UIElements.VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outProperties)
END_CLASS

CLASS: EqualityComparer
TYPE:  class
TOKEN: 0x2000089
FIELDS:
METHODS:
  System.Boolean Equals(UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair x, UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair y)
  System.Int32 GetHashCode(UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair obj)
  System.Void .ctor()
END_CLASS

CLASS: ElementPropertyPair
TYPE:  struct
TOKEN: 0x2000088
FIELDS:
  public    static readonly System.Collections.Generic.IEqualityComparer<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair>Comparer  // 0x0
  public    readonly UnityEngine.UIElements.VisualElementelement  // 0x10
  public    readonly UnityEngine.UIElements.StyleSheets.StylePropertyIdproperty  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId property)
  System.Void .cctor()
END_CLASS

CLASS: Values
TYPE:  class
TOKEN: 0x200008A
FIELDS:
METHODS:
  System.Void CancelAllAnimations()
  System.Void CancelAllAnimations(UnityEngine.UIElements.VisualElement ve)
  System.Void CancelAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Void UpdateAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Void GetAllAnimations(UnityEngine.UIElements.VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds)
  System.Void Update(System.Int64 currentTimeMs)
  System.Void UpdateValues()
  System.Void UpdateComputedStyle()
  System.Void UpdateComputedStyle(System.Int32 i)
  System.Void .ctor()
END_CLASS

CLASS: TransitionEventsFrameState
TYPE:  class
TOKEN: 0x200008C
FIELDS:
  private   static readonly UnityEngine.Pool.ObjectPool<System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase>>k_EventQueuePool  // 0x0
  public    readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair,UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionState>elementPropertyStateDelta  // 0x0
  public    readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair,System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase>>elementPropertyQueuedEvents  // 0x0
  public            UnityEngine.UIElements.IPanel   panel  // 0x0
  private           System.Int32                    m_ChangesCount  // 0x0
METHODS:
  System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase> GetPooledQueue()
  System.Void RegisterChange()
  System.Void UnregisterChange()
  System.Boolean StateChanged()
  System.Void Clear()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: TimingData
TYPE:  struct
TOKEN: 0x200008E
FIELDS:
  public            System.Int64                    startTimeMs  // 0x0
  public            System.Int32                    durationMs  // 0x0
  public            System.Func<System.Single,System.Single>easingCurve  // 0x0
  public            System.Single                   easedProgress  // 0x0
  public            System.Single                   reversingShorteningFactor  // 0x0
  public            System.Boolean                  isStarted  // 0x0
  public            System.Int32                    delayMs  // 0x0
METHODS:
END_CLASS

CLASS: StyleData
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  public            T                               startValue  // 0x0
  public            T                               endValue  // 0x0
  public            T                               reversingAdjustedStartValue  // 0x0
  public            T                               currentValue  // 0x0
METHODS:
END_CLASS

CLASS: EmptyData
TYPE:  struct
TOKEN: 0x2000090
FIELDS:
  public    static  UnityEngine.UIElements.StylePropertyAnimationSystem.Values.EmptyData<T>Default  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Values`1
TYPE:  class
TOKEN: 0x200008B
EXTENDS: Values
FIELDS:
  private           System.Int64                    m_CurrentTimeMs  // 0x0
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TransitionEventsFrameState<T>m_CurrentFrameEventsState  // 0x0
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TransitionEventsFrameState<T>m_NextFrameEventsState  // 0x0
  public            UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TimingData<T>,UnityEngine.UIElements.StylePropertyAnimationSystem.Values.StyleData<T>>running  // 0x0
  public            UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<UnityEngine.UIElements.StylePropertyAnimationSystem.Values.EmptyData<T>,T>completed  // 0x0
METHODS:
  System.Boolean get_isEmpty()
  System.Func<T,T,System.Boolean> get_SameFunc()
  System.Boolean ConvertUnits(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, T& a, T& b)
  System.Void .ctor()
  System.Void SwapFrameStates()
  System.Void QueueEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair epp)
  System.Void ClearEventQueue(UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair epp)
  System.Void QueueTransitionRunEvent(UnityEngine.UIElements.VisualElement ve, System.Int32 runningIndex)
  System.Void QueueTransitionStartEvent(UnityEngine.UIElements.VisualElement ve, System.Int32 runningIndex)
  System.Void QueueTransitionEndEvent(UnityEngine.UIElements.VisualElement ve, System.Int32 runningIndex)
  System.Void QueueTransitionCancelEvent(UnityEngine.UIElements.VisualElement ve, System.Int32 runningIndex, System.Int64 panelElapsedMs)
  System.Void SendTransitionCancelEvent(UnityEngine.UIElements.VisualElement ve, System.Int32 runningIndex, System.Int64 panelElapsedMs)
  System.Void CancelAllAnimations()
  System.Void CancelAllAnimations(UnityEngine.UIElements.VisualElement ve)
  System.Void CancelAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Void UpdateAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Void GetAllAnimations(UnityEngine.UIElements.VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds)
  System.Single ComputeReversingShorteningFactor(System.Int32 oldIndex)
  System.Int32 ComputeReversingDuration(System.Int32 newTransitionDurationMs, System.Single newReversingShorteningFactor)
  System.Int32 ComputeReversingDelay(System.Int32 delayMs, System.Single newReversingShorteningFactor)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, T startValue, T endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve, System.Int64 currentTimeMs)
  System.Void ForceComputedStyleEndValue(System.Int32 runningIndex)
  System.Void Update(System.Int64 currentTimeMs)
  System.Void ProcessEventQueue()
  System.Void UpdateProgress(System.Int64 currentTimeMs)
END_CLASS

CLASS: ValuesFloat
TYPE:  class
TOKEN: 0x2000091
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<System.Single,System.Single,System.Boolean><SameFunc>k__BackingField  // 0x88
METHODS:
  System.Func<System.Single,System.Single,System.Boolean> get_SameFunc()
  System.Boolean IsSame(System.Single a, System.Single b)
  System.Single Lerp(System.Single a, System.Single b, System.Single t)
  System.Void UpdateValues()
  System.Void UpdateComputedStyle()
  System.Void UpdateComputedStyle(System.Int32 i)
  System.Void .ctor()
END_CLASS

CLASS: ValuesInt
TYPE:  class
TOKEN: 0x2000092
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<System.Int32,System.Int32,System.Boolean><SameFunc>k__BackingField  // 0x88
METHODS:
  System.Func<System.Int32,System.Int32,System.Boolean> get_SameFunc()
  System.Boolean IsSame(System.Int32 a, System.Int32 b)
  System.Int32 Lerp(System.Int32 a, System.Int32 b, System.Single t)
  System.Void UpdateValues()
  System.Void UpdateComputedStyle()
  System.Void UpdateComputedStyle(System.Int32 i)
  System.Void .ctor()
END_CLASS

CLASS: ValuesLength
TYPE:  class
TOKEN: 0x2000093
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<UnityEngine.UIElements.Length,UnityEngine.UIElements.Length,System.Boolean><SameFunc>k__BackingField  // 0x88
METHODS:
  System.Func<UnityEngine.UIElements.Length,UnityEngine.UIElements.Length,System.Boolean> get_SameFunc()
  System.Boolean IsSame(UnityEngine.UIElements.Length a, UnityEngine.UIElements.Length b)
  System.Boolean ConvertUnits(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Length& a, UnityEngine.UIElements.Length& b)
  UnityEngine.UIElements.Length Lerp(UnityEngine.UIElements.Length a, UnityEngine.UIElements.Length b, System.Single t)
  System.Void UpdateValues()
  System.Void UpdateComputedStyle()
  System.Void UpdateComputedStyle(System.Int32 i)
  System.Void .ctor()
END_CLASS

CLASS: ValuesColor
TYPE:  class
TOKEN: 0x2000094
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<UnityEngine.Color,UnityEngine.Color,System.Boolean><SameFunc>k__BackingField  // 0x88
METHODS:
  System.Func<UnityEngine.Color,UnityEngine.Color,System.Boolean> get_SameFunc()
  System.Boolean IsSame(UnityEngine.Color c, UnityEngine.Color d)
  UnityEngine.Color Lerp(UnityEngine.Color a, UnityEngine.Color b, System.Single t)
  System.Void UpdateValues()
  System.Void UpdateComputedStyle()
  System.Void UpdateComputedStyle(System.Int32 i)
  System.Void .ctor()
END_CLASS

CLASS: ValuesDiscrete`1
TYPE:  class
TOKEN: 0x2000095
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<T,T,System.Boolean> <SameFunc>k__BackingField  // 0x0
METHODS:
  System.Func<T,T,System.Boolean> get_SameFunc()
  System.Boolean IsSame(T a, T b)
  T Lerp(T a, T b, System.Single t)
  System.Void UpdateValues()
  System.Void .ctor()
END_CLASS

CLASS: ValuesBackground
TYPE:  class
TOKEN: 0x2000096
EXTENDS: ValuesDiscrete`1
FIELDS:
METHODS:
  System.Void UpdateComputedStyle()
  System.Void UpdateComputedStyle(System.Int32 i)
  System.Void .ctor()
END_CLASS

CLASS: ValuesFontDefinition
TYPE:  class
TOKEN: 0x2000097
EXTENDS: ValuesDiscrete`1
FIELDS:
METHODS:
  System.Void UpdateComputedStyle()
  System.Void UpdateComputedStyle(System.Int32 i)
  System.Void .ctor()
END_CLASS

CLASS: ValuesFont
TYPE:  class
TOKEN: 0x2000098
EXTENDS: ValuesDiscrete`1
FIELDS:
METHODS:
  System.Void UpdateComputedStyle()
  System.Void UpdateComputedStyle(System.Int32 i)
  System.Void .ctor()
END_CLASS

CLASS: ValuesTextShadow
TYPE:  class
TOKEN: 0x2000099
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<UnityEngine.UIElements.TextShadow,UnityEngine.UIElements.TextShadow,System.Boolean><SameFunc>k__BackingField  // 0x88
METHODS:
  System.Func<UnityEngine.UIElements.TextShadow,UnityEngine.UIElements.TextShadow,System.Boolean> get_SameFunc()
  System.Boolean IsSame(UnityEngine.UIElements.TextShadow a, UnityEngine.UIElements.TextShadow b)
  UnityEngine.UIElements.TextShadow Lerp(UnityEngine.UIElements.TextShadow a, UnityEngine.UIElements.TextShadow b, System.Single t)
  System.Void UpdateValues()
  System.Void UpdateComputedStyle()
  System.Void UpdateComputedStyle(System.Int32 i)
  System.Void .ctor()
END_CLASS

CLASS: ValuesScale
TYPE:  class
TOKEN: 0x200009A
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<UnityEngine.UIElements.Scale,UnityEngine.UIElements.Scale,System.Boolean><SameFunc>k__BackingField  // 0x88
METHODS:
  System.Func<UnityEngine.UIElements.Scale,UnityEngine.UIElements.Scale,System.Boolean> get_SameFunc()
  System.Boolean IsSame(UnityEngine.UIElements.Scale a, UnityEngine.UIElements.Scale b)
  System.Void UpdateComputedStyle()
  System.Void UpdateComputedStyle(System.Int32 i)
  UnityEngine.UIElements.Scale Lerp(UnityEngine.UIElements.Scale a, UnityEngine.UIElements.Scale b, System.Single t)
  System.Void UpdateValues()
  System.Void .ctor()
END_CLASS

CLASS: ValuesRotate
TYPE:  class
TOKEN: 0x200009B
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<UnityEngine.UIElements.Rotate,UnityEngine.UIElements.Rotate,System.Boolean><SameFunc>k__BackingField  // 0x88
METHODS:
  System.Func<UnityEngine.UIElements.Rotate,UnityEngine.UIElements.Rotate,System.Boolean> get_SameFunc()
  System.Boolean IsSame(UnityEngine.UIElements.Rotate a, UnityEngine.UIElements.Rotate b)
  System.Void UpdateComputedStyle()
  System.Void UpdateComputedStyle(System.Int32 i)
  UnityEngine.UIElements.Rotate Lerp(UnityEngine.UIElements.Rotate a, UnityEngine.UIElements.Rotate b, System.Single t)
  System.Void UpdateValues()
  System.Void .ctor()
END_CLASS

CLASS: ValuesTranslate
TYPE:  class
TOKEN: 0x200009C
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<UnityEngine.UIElements.Translate,UnityEngine.UIElements.Translate,System.Boolean><SameFunc>k__BackingField  // 0x88
METHODS:
  System.Func<UnityEngine.UIElements.Translate,UnityEngine.UIElements.Translate,System.Boolean> get_SameFunc()
  System.Boolean IsSame(UnityEngine.UIElements.Translate a, UnityEngine.UIElements.Translate b)
  System.Boolean ConvertUnits(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Translate& a, UnityEngine.UIElements.Translate& b)
  System.Void UpdateComputedStyle()
  System.Void UpdateComputedStyle(System.Int32 i)
  UnityEngine.UIElements.Translate Lerp(UnityEngine.UIElements.Translate a, UnityEngine.UIElements.Translate b, System.Single t)
  System.Void UpdateValues()
  System.Void .ctor()
END_CLASS

CLASS: ValuesTransformOrigin
TYPE:  class
TOKEN: 0x200009D
EXTENDS: Values`1
FIELDS:
  private   readonly System.Func<UnityEngine.UIElements.TransformOrigin,UnityEngine.UIElements.TransformOrigin,System.Boolean><SameFunc>k__BackingField  // 0x88
METHODS:
  System.Func<UnityEngine.UIElements.TransformOrigin,UnityEngine.UIElements.TransformOrigin,System.Boolean> get_SameFunc()
  System.Boolean IsSame(UnityEngine.UIElements.TransformOrigin a, UnityEngine.UIElements.TransformOrigin b)
  System.Boolean ConvertUnits(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TransformOrigin& a, UnityEngine.UIElements.TransformOrigin& b)
  System.Void UpdateComputedStyle()
  System.Void UpdateComputedStyle(System.Int32 i)
  UnityEngine.UIElements.TransformOrigin Lerp(UnityEngine.UIElements.TransformOrigin a, UnityEngine.UIElements.TransformOrigin b, System.Single t)
  System.Void UpdateValues()
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x20000A0
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.String get_uxmlName()
  System.String get_uxmlQualifiedName()
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x20000A1
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Template  // 0x78
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x20000A4
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x20000A5
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Text  // 0x78
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_EnableRichText  // 0x80
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_DisplayTooltipWhenElided  // 0x88
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: CreateRuntimePanelDelegate
TYPE:  class
TOKEN: 0x20000A9
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.UIElements.BaseRuntimePanel Invoke(UnityEngine.ScriptableObject ownerObject)
END_CLASS

CLASS: IVisualPredicateWrapper
TYPE:  interface
TOKEN: 0x20000B1
FIELDS:
METHODS:
  System.Boolean Predicate(System.Object e)
END_CLASS

CLASS: IsOfType`1
TYPE:  class
TOKEN: 0x20000B2
FIELDS:
  public    static  UnityEngine.UIElements.UQuery.IsOfType<T>s_Instance  // 0x0
METHODS:
  System.Boolean Predicate(System.Object e)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UQueryMatcher
TYPE:  class
TOKEN: 0x20000B3
EXTENDS: HierarchyTraversal
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher>m_Matchers  // 0x10
METHODS:
  System.Void .ctor()
  System.Void Traverse(UnityEngine.UIElements.VisualElement element)
  System.Boolean OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element)
  System.Void NoProcessResult(UnityEngine.UIElements.VisualElement e, UnityEngine.UIElements.StyleSheets.MatchResultInfo i)
  System.Void TraverseRecursive(UnityEngine.UIElements.VisualElement element, System.Int32 depth)
  System.Void Run(UnityEngine.UIElements.VisualElement root, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers)
END_CLASS

CLASS: SingleQueryMatcher
TYPE:  class
TOKEN: 0x20000B5
EXTENDS: UQueryMatcher
FIELDS:
  private           UnityEngine.UIElements.VisualElement<match>k__BackingField  // 0x18
METHODS:
  UnityEngine.UIElements.VisualElement get_match()
  System.Void set_match(UnityEngine.UIElements.VisualElement value)
  System.Void Run(UnityEngine.UIElements.VisualElement root, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers)
  System.Boolean IsInUse()
  UnityEngine.UIElements.UQuery.SingleQueryMatcher CreateNew()
  System.Void .ctor()
END_CLASS

CLASS: FirstQueryMatcher
TYPE:  class
TOKEN: 0x20000B6
EXTENDS: SingleQueryMatcher
FIELDS:
  public    static readonly UnityEngine.UIElements.UQuery.FirstQueryMatcherInstance  // 0x0
METHODS:
  System.Boolean OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element)
  UnityEngine.UIElements.UQuery.SingleQueryMatcher CreateNew()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: ListQueryMatcher`1
TYPE:  class
TOKEN: 0x20000B8
EXTENDS: UQueryMatcher
FIELDS:
  private           System.Collections.Generic.List<TElement><matches>k__BackingField  // 0x0
METHODS:
  System.Collections.Generic.List<TElement> get_matches()
  System.Void set_matches(System.Collections.Generic.List<TElement> value)
  System.Boolean OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element)
  System.Void Reset()
  System.Void .ctor()
END_CLASS

CLASS: ActionQueryMatcher
TYPE:  class
TOKEN: 0x20000B9
EXTENDS: UQueryMatcher
FIELDS:
  private           System.Action<T>                <callBack>k__BackingField  // 0x0
METHODS:
  System.Action<T> get_callBack()
  System.Boolean OnRuleMatchedElement(UnityEngine.UIElements.RuleMatcher matcher, UnityEngine.UIElements.VisualElement element)
  System.Void .ctor()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x20000BA
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>iterationList  // 0x0
  private           System.Int32                    currentIndex  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.UIElements.UQueryState<T> queryState)
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Boolean MoveNext()
  System.Void Reset()
  System.Void Dispose()
END_CLASS

CLASS: DefaultFocusOrder
TYPE:  struct
TOKEN: 0x20000CD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrderChildOrder  // 0x0
  public    static  UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrderPositionXY  // 0x0
  public    static  UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrderPositionYX  // 0x0
METHODS:
END_CLASS

CLASS: FocusRingRecord
TYPE:  class
TOKEN: 0x20000CE
FIELDS:
  public            System.Int32                    m_AutoIndex  // 0x10
  public            UnityEngine.UIElements.Focusablem_Focusable  // 0x18
  public            System.Boolean                  m_IsSlot  // 0x20
  public            System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord>m_ScopeNavigationOrder  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: State
TYPE:  struct
TOKEN: 0x20000D8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater.StateWaiting  // 0x0
  public    static  UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater.StateTrackingAddOrMove  // 0x0
  public    static  UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater.StateTrackingRemove  // 0x0
METHODS:
END_CLASS

CLASS: UpdaterArray
TYPE:  class
TOKEN: 0x20000E1
FIELDS:
  private           UnityEngine.UIElements.IVisualTreeUpdater[]m_VisualTreeUpdaters  // 0x10
METHODS:
  System.Void .ctor()
  System.Void set_Item(UnityEngine.UIElements.VisualTreeUpdatePhase phase, UnityEngine.UIElements.IVisualTreeUpdater value)
  UnityEngine.UIElements.IVisualTreeUpdater get_Item(UnityEngine.UIElements.VisualTreeUpdatePhase phase)
  UnityEngine.UIElements.IVisualTreeUpdater get_Item(System.Int32 index)
END_CLASS

CLASS: ContentHeightCacheInfo
TYPE:  struct
TOKEN: 0x20000F6
FIELDS:
  public    readonly System.Single                   sum  // 0x0
  public    readonly System.Int32                    count  // 0x0
METHODS:
  System.Void .ctor(System.Single sum, System.Int32 count)
END_CLASS

CLASS: VirtualizationChange
TYPE:  struct
TOKEN: 0x20000F7
FIELDS:
  public            System.Int32                    value__  // 0x0
  public    static  UnityEngine.UIElements.DynamicHeightVirtualizationController.VirtualizationChange<T>None  // 0x0
  public    static  UnityEngine.UIElements.DynamicHeightVirtualizationController.VirtualizationChange<T>Resize  // 0x0
  public    static  UnityEngine.UIElements.DynamicHeightVirtualizationController.VirtualizationChange<T>Scroll  // 0x0
  public    static  UnityEngine.UIElements.DynamicHeightVirtualizationController.VirtualizationChange<T>ForcedScroll  // 0x0
METHODS:
END_CLASS

CLASS: ScrollDirection
TYPE:  struct
TOKEN: 0x20000F8
FIELDS:
  public            System.Int32                    value__  // 0x0
  public    static  UnityEngine.UIElements.DynamicHeightVirtualizationController.ScrollDirection<T>Idle  // 0x0
  public    static  UnityEngine.UIElements.DynamicHeightVirtualizationController.ScrollDirection<T>Up  // 0x0
  public    static  UnityEngine.UIElements.DynamicHeightVirtualizationController.ScrollDirection<T>Down  // 0x0
METHODS:
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000103
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Label  // 0x0
METHODS:
  System.Void .ctor()
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Collections.Generic.List<System.String> ParseChoiceList(System.String choicesFromBag)
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000107
EXTENDS: UxmlTraits
FIELDS:
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ShowFoldoutHeader  // 0xB0
  private   readonly UnityEngine.UIElements.UxmlStringAttributeDescriptionm_HeaderTitle  // 0xB8
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ShowAddRemoveFooter  // 0xC0
  private   readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ListViewReorderMode>m_ReorderMode  // 0xC8
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ShowBoundCollectionSize  // 0xD0
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: SliderKey
TYPE:  struct
TOKEN: 0x200010A
FIELDS:
  public            System.Int32                    value__  // 0x0
  public    static  UnityEngine.UIElements.BaseSlider.SliderKey<TValueType>None  // 0x0
  public    static  UnityEngine.UIElements.BaseSlider.SliderKey<TValueType>Lowest  // 0x0
  public    static  UnityEngine.UIElements.BaseSlider.SliderKey<TValueType>LowerPage  // 0x0
  public    static  UnityEngine.UIElements.BaseSlider.SliderKey<TValueType>Lower  // 0x0
  public    static  UnityEngine.UIElements.BaseSlider.SliderKey<TValueType>Higher  // 0x0
  public    static  UnityEngine.UIElements.BaseSlider.SliderKey<TValueType>HigherPage  // 0x0
  public    static  UnityEngine.UIElements.BaseSlider.SliderKey<TValueType>Highest  // 0x0
METHODS:
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200010C
EXTENDS: UxmlTraits
FIELDS:
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_AutoExpand  // 0xB0
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000111
EXTENDS: UxmlTraits
FIELDS:
  private   readonly UnityEngine.UIElements.UxmlIntAttributeDescriptionm_FixedItemHeight  // 0x78
  private   readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.CollectionVirtualizationMethod>m_VirtualizationMethod  // 0x80
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ShowBorder  // 0x88
  private   readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SelectionType>m_SelectionType  // 0x90
  private   readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.AlternatingRowBackground>m_ShowAlternatingRowBackgrounds  // 0x98
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Reorderable  // 0xA0
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_HorizontalScrollingEnabled  // 0xA8
METHODS:
  System.Void .ctor()
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
END_CLASS

CLASS: Selection
TYPE:  class
TOKEN: 0x2000112
FIELDS:
  private   readonly System.Collections.Generic.HashSet<System.Int32>m_IndexLookup  // 0x10
  private   readonly System.Collections.Generic.HashSet<System.Int32>m_IdLookup  // 0x18
  private           System.Int32                    m_MinIndex  // 0x20
  private           System.Int32                    m_MaxIndex  // 0x24
  private           System.Collections.Generic.List<System.Int32><selectedIds>k__BackingField  // 0x28
  public    readonly System.Collections.Generic.List<System.Int32>indices  // 0x30
  public    readonly System.Collections.Generic.Dictionary<System.Int32,System.Object>items  // 0x38
METHODS:
  System.Collections.Generic.List<System.Int32> get_selectedIds()
  System.Void set_selectedIds(System.Collections.Generic.List<System.Int32> value)
  System.Int32 get_indexCount()
  System.Int32 get_idCount()
  System.Int32 get_minIndex()
  System.Int32 get_maxIndex()
  System.Int32 get_capacity()
  System.Void set_capacity(System.Int32 value)
  System.Int32 FirstIndex()
  System.Boolean ContainsIndex(System.Int32 index)
  System.Boolean ContainsId(System.Int32 id)
  System.Void AddId(System.Int32 id)
  System.Void AddIndex(System.Int32 index, System.Object obj)
  System.Boolean TryRemove(System.Int32 index)
  System.Void RemoveId(System.Int32 id)
  System.Void ClearItems()
  System.Void ClearIds()
  System.Void ClearIndices()
  System.Void Clear()
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200011A
EXTENDS: UxmlFactory`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200011C
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200011D
EXTENDS: UxmlTraits
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200011F
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000120
EXTENDS: UxmlTraits
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000122
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000123
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlIntAttributeDescriptionm_Index  // 0x80
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Choices  // 0x88
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: PopupTextElement
TYPE:  class
TOKEN: 0x2000124
EXTENDS: TextElement
FIELDS:
METHODS:
  UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode)
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000127
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000128
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Text  // 0x78
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Value  // 0x80
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: MenuItem
TYPE:  class
TOKEN: 0x200012B
FIELDS:
  public            System.String                   name  // 0x10
  public            UnityEngine.UIElements.VisualElementelement  // 0x18
  public            System.Action                   action  // 0x20
  public            System.Action<System.Object>    actionUserData  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200012E
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200012F
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Text  // 0x78
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000132
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000133
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Text  // 0x70
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.HelpBoxMessageType>m_MessageType  // 0x78
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000135
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000136
EXTENDS: UxmlTraits
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200013B
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200013C
EXTENDS: UxmlTraits
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200013E
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200013F
EXTENDS: UxmlTraits
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000141
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000142
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_MinValue  // 0x80
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_MaxValue  // 0x88
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_LowLimit  // 0x90
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_HighLimit  // 0x98
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: DragState
TYPE:  struct
TOKEN: 0x2000143
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.MinMaxSlider.DragStateNoThumb  // 0x0
  public    static  UnityEngine.UIElements.MinMaxSlider.DragStateMinThumb  // 0x0
  public    static  UnityEngine.UIElements.MinMaxSlider.DragStateMiddleThumb  // 0x0
  public    static  UnityEngine.UIElements.MinMaxSlider.DragStateMaxThumb  // 0x0
METHODS:
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000145
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000146
EXTENDS: UxmlTraits
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000148
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_LowValue  // 0x78
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_HighValue  // 0x80
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_Value  // 0x88
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Title  // 0x90
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200014A
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200014C
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200014D
EXTENDS: BaseFieldTraits`2
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Text  // 0x88
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200014F
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000150
EXTENDS: BaseFieldTraits`2
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Choices  // 0x88
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000152
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000153
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlLongAttributeDescriptionm_Delay  // 0x90
  private           UnityEngine.UIElements.UxmlLongAttributeDescriptionm_Interval  // 0x98
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000155
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000156
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_LowValue  // 0x70
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_HighValue  // 0x78
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection>m_Direction  // 0x80
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_Value  // 0x88
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200015A
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200015B
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollViewMode>m_ScrollViewMode  // 0x70
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollView.NestedInteractionKind>m_NestedInteractionKind  // 0x78
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ShowHorizontal  // 0x80
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ShowVertical  // 0x88
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollerVisibility>m_HorizontalScrollerVisibility  // 0x90
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollerVisibility>m_VerticalScrollerVisibility  // 0x98
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_HorizontalPageSize  // 0xA0
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_VerticalPageSize  // 0xA8
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_MouseWheelScrollSize  // 0xB0
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollView.TouchScrollBehavior>m_TouchScrollBehavior  // 0xB8
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_ScrollDecelerationRate  // 0xC0
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_Elasticity  // 0xC8
  private           UnityEngine.UIElements.UxmlLongAttributeDescriptionm_ElasticAnimationIntervalMs  // 0xD0
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: TouchScrollBehavior
TYPE:  struct
TOKEN: 0x200015C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ScrollView.TouchScrollBehaviorUnrestricted  // 0x0
  public    static  UnityEngine.UIElements.ScrollView.TouchScrollBehaviorElastic  // 0x0
  public    static  UnityEngine.UIElements.ScrollView.TouchScrollBehaviorClamped  // 0x0
METHODS:
END_CLASS

CLASS: NestedInteractionKind
TYPE:  struct
TOKEN: 0x200015D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ScrollView.NestedInteractionKindDefault  // 0x0
  public    static  UnityEngine.UIElements.ScrollView.NestedInteractionKindStopScrolling  // 0x0
  public    static  UnityEngine.UIElements.ScrollView.NestedInteractionKindForwardScrolling  // 0x0
METHODS:
END_CLASS

CLASS: TouchScrollingResult
TYPE:  struct
TOKEN: 0x200015E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ScrollView.TouchScrollingResultApply  // 0x0
  public    static  UnityEngine.UIElements.ScrollView.TouchScrollingResultForward  // 0x0
  public    static  UnityEngine.UIElements.ScrollView.TouchScrollingResultBlock  // 0x0
METHODS:
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000160
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000161
EXTENDS: BaseFieldTraits`2
FIELDS:
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_LowValue  // 0x88
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_HighValue  // 0x90
  private           UnityEngine.UIElements.UxmlFloatAttributeDescriptionm_PageSize  // 0x98
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ShowInputField  // 0xA0
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection>m_Direction  // 0xA8
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Inverted  // 0xB0
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000163
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000164
EXTENDS: BaseFieldTraits`2
FIELDS:
  private           UnityEngine.UIElements.UxmlIntAttributeDescriptionm_LowValue  // 0x88
  private           UnityEngine.UIElements.UxmlIntAttributeDescriptionm_HighValue  // 0x90
  private           UnityEngine.UIElements.UxmlIntAttributeDescriptionm_PageSize  // 0x98
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ShowInputField  // 0xA0
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection>m_Direction  // 0xA8
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Inverted  // 0xB0
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: OnDetectFocusChangeFunction
TYPE:  class
TOKEN: 0x2000167
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: OnIndexChangeFunction
TYPE:  class
TOKEN: 0x2000168
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200016A
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200016B
EXTENDS: UxmlTraits
FIELDS:
  private   static readonly UnityEngine.UIElements.UxmlStringAttributeDescriptionk_Value  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Multiline  // 0xB8
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: TextInput
TYPE:  class
TOKEN: 0x200016C
EXTENDS: TextInputBase
FIELDS:
  private           System.Boolean                  m_Multiline  // 0x420
METHODS:
  UnityEngine.UIElements.TextField get_parentTextField()
  System.Boolean get_multiline()
  System.Void set_multiline(System.Boolean value)
  System.Void SetTextAlign()
  System.Void set_isPasswordField(System.Boolean value)
  System.String StringToValue(System.String str)
  System.Void SyncTextEngine()
  System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt)
  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200016F
EXTENDS: BaseFieldTraits`2
FIELDS:
  private           UnityEngine.UIElements.UxmlIntAttributeDescriptionm_MaxLength  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Password  // 0x0
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_MaskCharacter  // 0x0
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Text  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_IsReadOnly  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_IsDelayed  // 0x0
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: TextInputBase
TYPE:  class
TOKEN: 0x2000170
EXTENDS: VisualElement
FIELDS:
  private           System.String                   m_OriginalText  // 0x0
  private           System.Boolean                  <isReadOnly>k__BackingField  // 0x0
  private           System.Int32                    <maxLength>k__BackingField  // 0x0
  private           System.Char                     <maskChar>k__BackingField  // 0x0
  private           System.Boolean                  <isPasswordField>k__BackingField  // 0x0
  private           System.Boolean                  <doubleClickSelectsWord>k__BackingField  // 0x0
  private           System.Boolean                  <tripleClickSelectsLine>k__BackingField  // 0x0
  private           System.Boolean                  <isDelayed>k__BackingField  // 0x0
  private           System.Boolean                  <isDragging>k__BackingField  // 0x0
  private           System.Boolean                  m_TouchScreenTextFieldInitialized  // 0x0
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_HardwareKeyboardPoller  // 0x0
  private           UnityEngine.Color               m_SelectionColor  // 0x0
  private           UnityEngine.Color               m_CursorColor  // 0x0
  private           UnityEngine.UIElements.TextEditorEventHandler<editorEventHandler>k__BackingField  // 0x0
  private           UnityEngine.UIElements.TextEditorEngine<editorEngine>k__BackingField  // 0x0
  private           UnityEngine.UIElements.ITextHandlem_TextHandle  // 0x0
  private           System.String                   m_Text  // 0x0
METHODS:
  System.Void ResetValueAndText()
  System.Void SaveValueAndText()
  System.Void RestoreValueAndText()
  System.Void UpdateText(System.String value)
  TValueType StringToValue(System.String str)
  System.Void UpdateValueFromText()
  System.Boolean UnityEngine.UIElements.ITextInputField.get_isReadOnly()
  System.Boolean get_isReadOnly()
  System.Void set_isReadOnly(System.Boolean value)
  System.Int32 get_maxLength()
  System.Void set_maxLength(System.Int32 value)
  System.Char get_maskChar()
  System.Void set_maskChar(System.Char value)
  System.Boolean get_isPasswordField()
  System.Void set_isPasswordField(System.Boolean value)
  System.Boolean get_doubleClickSelectsWord()
  System.Void set_doubleClickSelectsWord(System.Boolean value)
  System.Boolean get_tripleClickSelectsLine()
  System.Void set_tripleClickSelectsLine(System.Boolean value)
  System.Boolean get_isDelayed()
  System.Void set_isDelayed(System.Boolean value)
  System.Boolean get_isDragging()
  System.Boolean get_touchScreenTextField()
  System.Boolean get_touchScreenTextFieldChanged()
  UnityEngine.Color get_selectionColor()
  UnityEngine.Color get_cursorColor()
  System.Boolean get_hasFocus()
  UnityEngine.UIElements.TextEditorEventHandler get_editorEventHandler()
  System.Void set_editorEventHandler(UnityEngine.UIElements.TextEditorEventHandler value)
  UnityEngine.UIElements.TextEditorEngine get_editorEngine()
  System.Void set_editorEngine(UnityEngine.UIElements.TextEditorEngine value)
  System.String get_text()
  System.Void set_text(System.String value)
  System.Void .ctor()
  System.Void InitTextEditorEventHandler()
  UnityEngine.UIElements.DropdownMenuAction.Status CutActionStatus(UnityEngine.UIElements.DropdownMenuAction a)
  UnityEngine.UIElements.DropdownMenuAction.Status CopyActionStatus(UnityEngine.UIElements.DropdownMenuAction a)
  UnityEngine.UIElements.DropdownMenuAction.Status PasteActionStatus(UnityEngine.UIElements.DropdownMenuAction a)
  System.Void ProcessMenuCommand(System.String command)
  System.Void Cut(UnityEngine.UIElements.DropdownMenuAction a)
  System.Void Copy(UnityEngine.UIElements.DropdownMenuAction a)
  System.Void Paste(UnityEngine.UIElements.DropdownMenuAction a)
  System.Void OnInputCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e)
  System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent attachEvent)
  System.Void SyncTextEngine()
  System.String CullString(System.String s)
  System.Void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc)
  System.Void DrawWithTextSelectionAndCursor(UnityEngine.UIElements.MeshGenerationContext mgc, System.String newText, System.Single pixelsPerPoint)
  System.Boolean AcceptCharacter(System.Char c)
  System.Void BuildContextualMenu(UnityEngine.UIElements.ContextualMenuPopulateEvent evt)
  System.Void OnDetectFocusChange()
  System.Void OnCursorIndexChange()
  UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode)
  System.Void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase evt)
  System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt)
  System.Void ProcessEventAtTarget(UnityEngine.UIElements.EventBase evt)
  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  System.Boolean UnityEngine.UIElements.ITextInputField.get_hasFocus()
  System.Void UnityEngine.UIElements.ITextInputField.SyncTextEngine()
  System.Boolean UnityEngine.UIElements.ITextInputField.AcceptCharacter(System.Char c)
  System.String UnityEngine.UIElements.ITextInputField.CullString(System.String s)
  System.Void UnityEngine.UIElements.ITextInputField.UpdateText(System.String value)
  UnityEngine.UIElements.TextEditorEngine UnityEngine.UIElements.ITextInputField.get_editorEngine()
  System.Boolean UnityEngine.UIElements.ITextInputField.get_isDelayed()
  System.Void UnityEngine.UIElements.ITextInputField.UpdateValueFromText()
  System.Void DeferGUIStyleRectSync()
  System.Void OnPercentResolved(UnityEngine.UIElements.GeometryChangedEvent evt)
  System.Void SyncGUIStyle(UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> textInput, UnityEngine.GUIStyle style)
  System.Boolean IsLayoutUsingPercent(UnityEngine.UIElements.VisualElement ve)
  System.Void AssignRect(UnityEngine.RectOffset rect, System.Int32 left, System.Int32 top, System.Int32 right, System.Int32 bottom)
  System.Void <ProcessEventAtTarget>b__99_0()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000172
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000173
EXTENDS: BaseFieldTraits`2
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Text  // 0x88
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000176
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000177
EXTENDS: UxmlTraits
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x200017D
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x200017E
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlIntAttributeDescriptionm_FixedPaneIndex  // 0x70
  private           UnityEngine.UIElements.UxmlIntAttributeDescriptionm_FixedPaneInitialDimension  // 0x78
  private           UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.TwoPaneSplitViewOrientation>m_Orientation  // 0x80
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UxmlObjectFactory`1
TYPE:  class
TOKEN: 0x2000183
EXTENDS: UxmlObjectFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlObjectTraits`1
TYPE:  class
TOKEN: 0x2000184
EXTENDS: UxmlObjectTraits`1
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Name  // 0x0
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Text  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Visible  // 0x0
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Width  // 0x0
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_MinWidth  // 0x0
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_MaxWidth  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Stretch  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Sortable  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Optional  // 0x0
  private           UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Resizable  // 0x0
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_HeaderTemplateId  // 0x0
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_CellTemplateId  // 0x0
METHODS:
  UnityEngine.UIElements.Length ParseLength(System.String str, UnityEngine.UIElements.Length defaultValue)
  System.Void Init(T& obj, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: StretchMode
TYPE:  struct
TOKEN: 0x200018C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.Columns.StretchModeGrow  // 0x0
  public    static  UnityEngine.UIElements.Columns.StretchModeGrowAndFill  // 0x0
METHODS:
END_CLASS

CLASS: UxmlObjectFactory`1
TYPE:  class
TOKEN: 0x200018D
EXTENDS: UxmlObjectFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlObjectTraits`1
TYPE:  class
TOKEN: 0x200018E
EXTENDS: UxmlObjectTraits`1
FIELDS:
  private   readonly UnityEngine.UIElements.UxmlStringAttributeDescriptionm_PrimaryColumnName  // 0x0
  private   readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.Columns.StretchMode>m_StretchMode  // 0x0
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Reorderable  // 0x0
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_Resizable  // 0x0
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_ResizePreview  // 0x0
  private   readonly UnityEngine.UIElements.UxmlObjectListAttributeDescription<UnityEngine.UIElements.Column>m_Columns  // 0x0
METHODS:
  System.Void Init(T& obj, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000192
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000193
EXTENDS: UxmlTraits
FIELDS:
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_SortingEnabled  // 0xD8
  private   readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.Columns>m_Columns  // 0xE0
  private   readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.SortColumnDescriptions>m_SortColumnDescriptions  // 0xE8
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UxmlFactory
TYPE:  class
TOKEN: 0x2000195
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlTraits
TYPE:  class
TOKEN: 0x2000196
EXTENDS: UxmlTraits
FIELDS:
  private   readonly UnityEngine.UIElements.UxmlBoolAttributeDescriptionm_SortingEnabled  // 0xB8
  private   readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.Columns>m_Columns  // 0xC0
  private   readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.SortColumnDescriptions>m_SortColumnDescriptions  // 0xC8
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UxmlObjectFactory`1
TYPE:  class
TOKEN: 0x2000199
EXTENDS: UxmlObjectFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlObjectTraits`1
TYPE:  class
TOKEN: 0x200019A
EXTENDS: UxmlObjectTraits`1
FIELDS:
  private   readonly UnityEngine.UIElements.UxmlStringAttributeDescriptionm_ColumnName  // 0x0
  private   readonly UnityEngine.UIElements.UxmlIntAttributeDescriptionm_ColumnIndex  // 0x0
  private   readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SortDirection>m_SortDescription  // 0x0
METHODS:
  System.Void Init(T& obj, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UxmlObjectFactory`1
TYPE:  class
TOKEN: 0x200019C
EXTENDS: UxmlObjectFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UxmlObjectTraits`1
TYPE:  class
TOKEN: 0x200019D
EXTENDS: UxmlObjectTraits`1
FIELDS:
  private   readonly UnityEngine.UIElements.UxmlObjectListAttributeDescription<UnityEngine.UIElements.SortColumnDescription>m_SortColumnDescriptions  // 0x0
METHODS:
  System.Void Init(T& obj, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: DragState
TYPE:  struct
TOKEN: 0x20001A2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DragEventsProcessor.DragStateNone  // 0x0
  public    static  UnityEngine.UIElements.DragEventsProcessor.DragStateCanStartDrag  // 0x0
  public    static  UnityEngine.UIElements.DragEventsProcessor.DragStateDragging  // 0x0
METHODS:
END_CLASS

CLASS: DragPosition
TYPE:  struct
TOKEN: 0x20001B1
FIELDS:
  public            System.Int32                    insertAtIndex  // 0x10
  public            System.Int32                    parentId  // 0x14
  public            System.Int32                    childIndex  // 0x18
  public            UnityEngine.UIElements.ReusableCollectionItemrecycledItem  // 0x20
  public            UnityEngine.UIElements.DragAndDropPositiondropPosition  // 0x28
METHODS:
  System.Boolean Equals(UnityEngine.UIElements.ListViewDragger.DragPosition other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: DropData
TYPE:  class
TOKEN: 0x20001B6
FIELDS:
  public            System.Int32[]                  expandedIdsBeforeDrag  // 0x10
  public            System.Int32[]                  draggedIds  // 0x18
  public            System.Int32                    lastItemId  // 0x20
  public            System.Single                   expandItemBeginTimerMs  // 0x24
  public            UnityEngine.Vector2             expandItemBeginPosition  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: TreeItemState
TYPE:  struct
TOKEN: 0x20001B7
FIELDS:
  public            System.Int32                    parentId  // 0x10
  public            System.Int32                    childIndex  // 0x14
METHODS:
  System.Void .ctor(System.Int32 parentId, System.Int32 childIndex)
END_CLASS

CLASS: EventPropagation
TYPE:  struct
TOKEN: 0x20001C8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.EventBase.EventPropagationNone  // 0x0
  public    static  UnityEngine.UIElements.EventBase.EventPropagationBubbles  // 0x0
  public    static  UnityEngine.UIElements.EventBase.EventPropagationTricklesDown  // 0x0
  public    static  UnityEngine.UIElements.EventBase.EventPropagationCancellable  // 0x0
  public    static  UnityEngine.UIElements.EventBase.EventPropagationSkipDisabledElements  // 0x0
  public    static  UnityEngine.UIElements.EventBase.EventPropagationIgnoreCompositeRoots  // 0x0
METHODS:
END_CLASS

CLASS: LifeCycleStatus
TYPE:  struct
TOKEN: 0x20001C9
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusNone  // 0x0
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusPropagationStopped  // 0x0
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusImmediatePropagationStopped  // 0x0
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusDefaultPrevented  // 0x0
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusDispatching  // 0x0
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusPooled  // 0x0
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusIMGUIEventIsValid  // 0x0
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusStopDispatch  // 0x0
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusPropagateToIMGUI  // 0x0
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusDispatched  // 0x0
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusProcessed  // 0x0
  public    static  UnityEngine.UIElements.EventBase.LifeCycleStatusProcessedByFocusController  // 0x0
METHODS:
END_CLASS

CLASS: EventBehavior
TYPE:  struct
TOKEN: 0x20001E7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.MouseCaptureDispatchingStrategy.EventBehaviorNone  // 0x0
  public    static  UnityEngine.UIElements.MouseCaptureDispatchingStrategy.EventBehaviorIsCapturable  // 0x0
  public    static  UnityEngine.UIElements.MouseCaptureDispatchingStrategy.EventBehaviorIsSentExclusivelyToCapturingElement  // 0x0
METHODS:
END_CLASS

CLASS: Direction
TYPE:  struct
TOKEN: 0x20001FF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.NavigationMoveEvent.DirectionNone  // 0x0
  public    static  UnityEngine.UIElements.NavigationMoveEvent.DirectionLeft  // 0x0
  public    static  UnityEngine.UIElements.NavigationMoveEvent.DirectionUp  // 0x0
  public    static  UnityEngine.UIElements.NavigationMoveEvent.DirectionRight  // 0x0
  public    static  UnityEngine.UIElements.NavigationMoveEvent.DirectionDown  // 0x0
  public    static  UnityEngine.UIElements.NavigationMoveEvent.DirectionNext  // 0x0
  public    static  UnityEngine.UIElements.NavigationMoveEvent.DirectionPrevious  // 0x0
METHODS:
END_CLASS

CLASS: Direction
TYPE:  struct
TOKEN: 0x2000201
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.NavigationTabEvent.DirectionNone  // 0x0
  public    static  UnityEngine.UIElements.NavigationTabEvent.DirectionNext  // 0x0
  public    static  UnityEngine.UIElements.NavigationTabEvent.DirectionPrevious  // 0x0
METHODS:
END_CLASS

CLASS: LocationFlag
TYPE:  struct
TOKEN: 0x2000209
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.PointerDeviceState.LocationFlagNone  // 0x0
  public    static  UnityEngine.UIElements.PointerDeviceState.LocationFlagOutsidePanel  // 0x0
METHODS:
END_CLASS

CLASS: PointerLocation
TYPE:  struct
TOKEN: 0x200020A
FIELDS:
  private           UnityEngine.Vector2             <Position>k__BackingField  // 0x10
  private           UnityEngine.UIElements.IPanel   <Panel>k__BackingField  // 0x18
  private           UnityEngine.UIElements.PointerDeviceState.LocationFlag<Flags>k__BackingField  // 0x20
METHODS:
  UnityEngine.Vector2 get_Position()
  System.Void set_Position(UnityEngine.Vector2 value)
  UnityEngine.UIElements.IPanel get_Panel()
  System.Void set_Panel(UnityEngine.UIElements.IPanel value)
  UnityEngine.UIElements.PointerDeviceState.LocationFlag get_Flags()
  System.Void set_Flags(UnityEngine.UIElements.PointerDeviceState.LocationFlag value)
  System.Void SetLocation(UnityEngine.Vector2 position, UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: Type
TYPE:  struct
TOKEN: 0x200021C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.PropagationPaths.TypeNone  // 0x0
  public    static  UnityEngine.UIElements.PropagationPaths.TypeTrickleDown  // 0x0
  public    static  UnityEngine.UIElements.PropagationPaths.TypeBubbleUp  // 0x0
METHODS:
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000220
FIELDS:
  private           System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.StylePropertyName>m_Enumerator  // 0x10
METHODS:
  System.Void .ctor(System.Collections.Generic.List.Enumerator<UnityEngine.UIElements.StylePropertyName> enumerator)
  System.Boolean MoveNext()
  UnityEngine.UIElements.StylePropertyName get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void Reset()
  System.Void Dispose()
END_CLASS

CLASS: ChangeDirection
TYPE:  class
TOKEN: 0x200022E
EXTENDS: FocusChangeDirection
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 i)
END_CLASS

CLASS: FocusableHierarchyTraversal
TYPE:  struct
TOKEN: 0x200022F
FIELDS:
  public            UnityEngine.UIElements.VisualElementcurrentFocusable  // 0x10
  public            UnityEngine.Rect                validRect  // 0x18
  public            System.Boolean                  firstPass  // 0x28
  public            UnityEngine.UIElements.NavigateFocusRing.ChangeDirectiondirection  // 0x30
METHODS:
  System.Boolean ValidateHierarchyTraversal(UnityEngine.UIElements.VisualElement v)
  System.Boolean ValidateElement(UnityEngine.UIElements.VisualElement v)
  System.Int32 Order(UnityEngine.UIElements.VisualElement a, UnityEngine.UIElements.VisualElement b)
  System.Int32 StrictOrder(UnityEngine.UIElements.VisualElement a, UnityEngine.UIElements.VisualElement b)
  System.Int32 StrictOrder(UnityEngine.Rect ra, UnityEngine.Rect rb)
  System.Int32 TieBreaker(UnityEngine.Rect ra, UnityEngine.Rect rb)
  UnityEngine.UIElements.VisualElement GetBestOverall(UnityEngine.UIElements.VisualElement candidate, UnityEngine.UIElements.VisualElement bestSoFar)
END_CLASS

CLASS: RuntimePanelAccess
TYPE:  class
TOKEN: 0x2000233
FIELDS:
  private   readonly UnityEngine.UIElements.PanelSettingsm_Settings  // 0x10
  private           UnityEngine.UIElements.BaseRuntimePanelm_RuntimePanel  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.UIElements.PanelSettings settings)
  System.Boolean get_isInitialized()
  UnityEngine.UIElements.BaseRuntimePanel get_panel()
  System.Void DisposePanel()
  System.Void SetTargetTexture()
  System.Void SetSortingPriority()
  System.Void SetTargetDisplay()
  UnityEngine.UIElements.BaseRuntimePanel CreateRelatedRuntimePanel()
  System.Void DisposeRelatedPanel()
  System.Void MarkPotentiallyEmpty()
END_CLASS

CLASS: Row
TYPE:  class
TOKEN: 0x2000239
FIELDS:
  private   static  UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.UIRAtlasAllocator.Row>s_Pool  // 0x0
  private           System.Int32                    <offsetX>k__BackingField  // 0x10
  private           System.Int32                    <offsetY>k__BackingField  // 0x14
  private           System.Int32                    <width>k__BackingField  // 0x18
  private           System.Int32                    <height>k__BackingField  // 0x1C
  public            System.Int32                    Cursor  // 0x20
METHODS:
  System.Int32 get_offsetX()
  System.Void set_offsetX(System.Int32 value)
  System.Int32 get_offsetY()
  System.Void set_offsetY(System.Int32 value)
  System.Int32 get_width()
  System.Void set_width(System.Int32 value)
  System.Void set_height(System.Int32 value)
  UnityEngine.UIElements.UIRAtlasAllocator.Row Acquire(System.Int32 offsetX, System.Int32 offsetY, System.Int32 width, System.Int32 height)
  System.Void Release()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: AreaNode
TYPE:  class
TOKEN: 0x200023A
FIELDS:
  private   static  UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.UIRAtlasAllocator.AreaNode>s_Pool  // 0x0
  public            UnityEngine.RectInt             rect  // 0x10
  public            UnityEngine.UIElements.UIRAtlasAllocator.AreaNodeprevious  // 0x20
  public            UnityEngine.UIElements.UIRAtlasAllocator.AreaNodenext  // 0x28
METHODS:
  UnityEngine.UIElements.UIRAtlasAllocator.AreaNode Acquire(UnityEngine.RectInt rect)
  System.Void Release()
  System.Void RemoveFromChain()
  System.Void AddAfter(UnityEngine.UIElements.UIRAtlasAllocator.AreaNode previous)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: BorderParams
TYPE:  struct
TOKEN: 0x2000241
FIELDS:
  public            UnityEngine.Rect                rect  // 0x10
  public            UnityEngine.Color               playmodeTintColor  // 0x20
  public            UnityEngine.Color               leftColor  // 0x30
  public            UnityEngine.Color               topColor  // 0x40
  public            UnityEngine.Color               rightColor  // 0x50
  public            UnityEngine.Color               bottomColor  // 0x60
  public            System.Single                   leftWidth  // 0x70
  public            System.Single                   topWidth  // 0x74
  public            System.Single                   rightWidth  // 0x78
  public            System.Single                   bottomWidth  // 0x7C
  public            UnityEngine.Vector2             topLeftRadius  // 0x80
  public            UnityEngine.Vector2             topRightRadius  // 0x88
  public            UnityEngine.Vector2             bottomRightRadius  // 0x90
  public            UnityEngine.Vector2             bottomLeftRadius  // 0x98
  public            UnityEngine.Material            material  // 0xA0
  private           UnityEngine.UIElements.ColorPageleftColorPage  // 0xA8
  private           UnityEngine.UIElements.ColorPagetopColorPage  // 0xB0
  private           UnityEngine.UIElements.ColorPagerightColorPage  // 0xB8
  private           UnityEngine.UIElements.ColorPagebottomColorPage  // 0xC0
METHODS:
END_CLASS

CLASS: RectangleParams
TYPE:  struct
TOKEN: 0x2000242
FIELDS:
  public            UnityEngine.Rect                rect  // 0x10
  public            UnityEngine.Rect                uv  // 0x20
  public            UnityEngine.Color               color  // 0x30
  public            UnityEngine.Texture             texture  // 0x40
  public            UnityEngine.Sprite              sprite  // 0x48
  public            UnityEngine.UIElements.VectorImagevectorImage  // 0x50
  public            UnityEngine.Material            material  // 0x58
  public            UnityEngine.ScaleMode           scaleMode  // 0x60
  public            UnityEngine.Color               playmodeTintColor  // 0x64
  public            UnityEngine.Vector2             topLeftRadius  // 0x74
  public            UnityEngine.Vector2             topRightRadius  // 0x7C
  public            UnityEngine.Vector2             bottomRightRadius  // 0x84
  public            UnityEngine.Vector2             bottomLeftRadius  // 0x8C
  public            System.Int32                    leftSlice  // 0x94
  public            System.Int32                    topSlice  // 0x98
  public            System.Int32                    rightSlice  // 0x9C
  public            System.Int32                    bottomSlice  // 0xA0
  public            System.Single                   sliceScale  // 0xA4
  private           UnityEngine.Rect                spriteGeomRect  // 0xA8
  public            UnityEngine.Vector4             rectInset  // 0xB8
  private           UnityEngine.UIElements.ColorPagecolorPage  // 0xC8
  private           UnityEngine.UIElements.MeshGenerationContext.MeshFlagsmeshFlags  // 0xD0
METHODS:
  System.Void AdjustUVsForScaleMode(UnityEngine.Rect rect, UnityEngine.Rect uv, UnityEngine.Texture texture, UnityEngine.ScaleMode scaleMode, UnityEngine.Rect& rectOut, UnityEngine.Rect& uvOut)
  System.Void AdjustSpriteUVsForScaleMode(UnityEngine.Rect containerRect, UnityEngine.Rect srcRect, UnityEngine.Rect spriteGeomRect, UnityEngine.Sprite sprite, UnityEngine.ScaleMode scaleMode, UnityEngine.Rect& rectOut, UnityEngine.Rect& uvOut)
  UnityEngine.Rect RectIntersection(UnityEngine.Rect a, UnityEngine.Rect b)
  UnityEngine.Rect ComputeGeomRect(UnityEngine.Sprite sprite)
  UnityEngine.Rect ComputeUVRect(UnityEngine.Sprite sprite)
  UnityEngine.Rect ApplyPackingRotation(UnityEngine.Rect uv, UnityEngine.SpritePackingRotation rotation)
  UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams MakeTextured(UnityEngine.Rect rect, UnityEngine.Rect uv, UnityEngine.Texture texture, UnityEngine.ScaleMode scaleMode, UnityEngine.UIElements.ContextType panelContext)
  UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams MakeSprite(UnityEngine.Rect containerRect, UnityEngine.Rect subRect, UnityEngine.Sprite sprite, UnityEngine.ScaleMode scaleMode, UnityEngine.UIElements.ContextType panelContext, System.Boolean hasRadius, UnityEngine.Vector4& slices)
  UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams MakeVectorTextured(UnityEngine.Rect rect, UnityEngine.Rect uv, UnityEngine.UIElements.VectorImage vectorImage, UnityEngine.ScaleMode scaleMode, UnityEngine.UIElements.ContextType panelContext)
  System.Boolean HasRadius(System.Single epsilon)
END_CLASS

CLASS: TextParams
TYPE:  struct
TOKEN: 0x2000243
FIELDS:
  public            UnityEngine.Rect                rect  // 0x10
  public            System.String                   text  // 0x20
  public            UnityEngine.Font                font  // 0x28
  public            UnityEngine.UIElements.FontDefinitionfontDefinition  // 0x30
  public            System.Int32                    fontSize  // 0x40
  public            UnityEngine.UIElements.Length   letterSpacing  // 0x44
  public            UnityEngine.UIElements.Length   wordSpacing  // 0x4C
  public            UnityEngine.UIElements.Length   paragraphSpacing  // 0x54
  public            UnityEngine.FontStyle           fontStyle  // 0x5C
  public            UnityEngine.Color               fontColor  // 0x60
  public            UnityEngine.TextAnchor          anchor  // 0x70
  public            System.Boolean                  wordWrap  // 0x74
  public            System.Single                   wordWrapWidth  // 0x78
  public            System.Boolean                  richText  // 0x7C
  public            UnityEngine.Color               playmodeTintColor  // 0x80
  public            UnityEngine.UIElements.TextOverflowtextOverflow  // 0x90
  public            UnityEngine.UIElements.TextOverflowPositiontextOverflowPosition  // 0x94
  public            UnityEngine.UIElements.OverflowInternaloverflow  // 0x98
  public            UnityEngine.UIElements.IPanel   panel  // 0xA0
METHODS:
  System.Int32 GetHashCode()
  UnityEngine.UIElements.MeshGenerationContextUtils.TextParams MakeStyleBased(UnityEngine.UIElements.VisualElement ve, System.String text)
  UnityEngine.UIElements.TextNativeSettings GetTextNativeSettings(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, System.Single scaling)
END_CLASS

CLASS: MeshFlags
TYPE:  struct
TOKEN: 0x2000245
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.MeshGenerationContext.MeshFlagsNone  // 0x0
  public    static  UnityEngine.UIElements.MeshGenerationContext.MeshFlagsUVisDisplacement  // 0x0
  public    static  UnityEngine.UIElements.MeshGenerationContext.MeshFlagsSkipDynamicAtlas  // 0x0
METHODS:
END_CLASS

CLASS: TextureInfo
TYPE:  struct
TOKEN: 0x2000249
FIELDS:
  public            UnityEngine.Texture             texture  // 0x10
  public            System.Boolean                  dynamic  // 0x18
  public            System.Int32                    refCount  // 0x1C
METHODS:
END_CLASS

CLASS: Unit
TYPE:  struct
TOKEN: 0x200024D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.Angle.UnitDegree  // 0x0
  public    static  UnityEngine.UIElements.Angle.UnitGradian  // 0x0
  public    static  UnityEngine.UIElements.Angle.UnitRadian  // 0x0
  public    static  UnityEngine.UIElements.Angle.UnitTurn  // 0x0
  public    static  UnityEngine.UIElements.Angle.UnitNone  // 0x0
METHODS:
END_CLASS

CLASS: InlineRule
TYPE:  struct
TOKEN: 0x200025A
FIELDS:
  public            UnityEngine.UIElements.StyleSheetsheet  // 0x10
  public            UnityEngine.UIElements.StyleRulerule  // 0x18
  public            UnityEngine.UIElements.StyleSheets.StylePropertyId[]propertyIds  // 0x20
METHODS:
END_CLASS

CLASS: Unit
TYPE:  struct
TOKEN: 0x200025D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.Length.UnitPixel  // 0x0
  public    static  UnityEngine.UIElements.Length.UnitPercent  // 0x0
  public    static  UnityEngine.UIElements.Length.UnitAuto  // 0x0
  public    static  UnityEngine.UIElements.Length.UnitNone  // 0x0
METHODS:
END_CLASS

CLASS: RefCounted
TYPE:  class
TOKEN: 0x2000263
FIELDS:
  private   static  System.UInt32                   m_NextId  // 0x0
  private           System.Int32                    m_RefCount  // 0x0
  private   readonly System.UInt32                   m_Id  // 0x0
  public            T                               value  // 0x0
METHODS:
  System.Int32 get_refCount()
  System.Void .ctor()
  System.Void Acquire()
  System.Void Release()
  UnityEngine.UIElements.StyleDataRef.RefCounted<T> Copy()
  System.Void .cctor()
END_CLASS

CLASS: PseudoStateData
TYPE:  struct
TOKEN: 0x2000280
FIELDS:
  public    readonly UnityEngine.UIElements.PseudoStatesstate  // 0x10
  public    readonly System.Boolean                  negate  // 0x14
METHODS:
  System.Void .ctor(UnityEngine.UIElements.PseudoStates state, System.Boolean negate)
END_CLASS

CLASS: ImportStruct
TYPE:  struct
TOKEN: 0x200028A
FIELDS:
  public            UnityEngine.UIElements.StyleSheetstyleSheet  // 0x10
  public            System.String[]                 mediaQueries  // 0x18
METHODS:
END_CLASS

CLASS: Result
TYPE:  struct
TOKEN: 0x2000295
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleVariableResolver.ResultValid  // 0x0
  public    static  UnityEngine.UIElements.StyleVariableResolver.ResultInvalid  // 0x0
  public    static  UnityEngine.UIElements.StyleVariableResolver.ResultNotFound  // 0x0
METHODS:
END_CLASS

CLASS: ResolveContext
TYPE:  struct
TOKEN: 0x2000296
FIELDS:
  public            UnityEngine.UIElements.StyleSheetsheet  // 0x10
  public            UnityEngine.UIElements.StyleValueHandle[]handles  // 0x18
METHODS:
END_CLASS

CLASS: AttributeOverride
TYPE:  struct
TOKEN: 0x20002A7
FIELDS:
  public            System.String                   m_ElementName  // 0x10
  public            System.String                   m_AttributeName  // 0x18
  public            System.String                   m_Value  // 0x20
METHODS:
END_CLASS

CLASS: Use
TYPE:  struct
TOKEN: 0x20002A9
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UxmlAttributeDescription.UseNone  // 0x0
  public    static  UnityEngine.UIElements.UxmlAttributeDescription.UseOptional  // 0x0
  public    static  UnityEngine.UIElements.UxmlAttributeDescription.UseProhibited  // 0x0
  public    static  UnityEngine.UIElements.UxmlAttributeDescription.UseRequired  // 0x0
METHODS:
END_CLASS

CLASS: UsingEntry
TYPE:  struct
TOKEN: 0x20002CC
FIELDS:
  private   static readonly System.Collections.Generic.IComparer<UnityEngine.UIElements.VisualTreeAsset.UsingEntry>comparer  // 0x0
  public            System.String                   alias  // 0x10
  public            System.String                   path  // 0x18
  public            UnityEngine.UIElements.VisualTreeAssetasset  // 0x20
METHODS:
  System.Void .ctor(System.String alias, System.String path)
  System.Void .cctor()
END_CLASS

CLASS: UsingEntryComparer
TYPE:  class
TOKEN: 0x20002CD
FIELDS:
METHODS:
  System.Int32 Compare(UnityEngine.UIElements.VisualTreeAsset.UsingEntry x, UnityEngine.UIElements.VisualTreeAsset.UsingEntry y)
  System.Void .ctor()
END_CLASS

CLASS: SlotDefinition
TYPE:  struct
TOKEN: 0x20002CE
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Int32                    insertionPointId  // 0x18
METHODS:
END_CLASS

CLASS: SlotUsageEntry
TYPE:  struct
TOKEN: 0x20002CF
FIELDS:
  public            System.String                   slotName  // 0x10
  public            System.Int32                    assetId  // 0x18
METHODS:
END_CLASS

CLASS: UxmlObjectEntry
TYPE:  struct
TOKEN: 0x20002D0
FIELDS:
  public            System.Int32                    parentId  // 0x10
  public            System.Collections.Generic.List<UnityEngine.UIElements.UxmlObjectAsset>uxmlObjectAssets  // 0x18
METHODS:
  System.Void .ctor(System.Int32 parentId, System.Collections.Generic.List<UnityEngine.UIElements.UxmlObjectAsset> uxmlObjectAssets)
END_CLASS

CLASS: AssetEntry
TYPE:  struct
TOKEN: 0x20002D1
FIELDS:
  public            System.String                   path  // 0x10
  public            System.String                   typeFullName  // 0x18
  public            UnityEngine.Object              asset  // 0x20
  private           System.Type                     m_CachedType  // 0x28
METHODS:
  System.Type get_type()
  System.Void .ctor(System.String path, System.Type type, UnityEngine.Object asset)
END_CLASS

CLASS: Area
TYPE:  class
TOKEN: 0x20002D8
FIELDS:
  public            UnityEngine.RectInt             rect  // 0x10
  public            UnityEngine.UIElements.UIR.BestFitAllocatorallocator  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.RectInt rect)
END_CLASS

CLASS: Row
TYPE:  class
TOKEN: 0x20002D9
EXTENDS: LinkedPoolItem`1
FIELDS:
  public            UnityEngine.RectInt             rect  // 0x18
  public            UnityEngine.UIElements.UIR.Allocator2D.Areaarea  // 0x28
  public            UnityEngine.UIElements.UIR.BestFitAllocatorallocator  // 0x30
  public            UnityEngine.UIElements.UIR.Allocalloc  // 0x38
  public            UnityEngine.UIElements.UIR.Allocator2D.Rownext  // 0x50
  public    static readonly UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.Allocator2D.Row>pool  // 0x0
METHODS:
  UnityEngine.UIElements.UIR.Allocator2D.Row Create()
  System.Void Reset(UnityEngine.UIElements.UIR.Allocator2D.Row row)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Alloc2D
TYPE:  struct
TOKEN: 0x20002DA
FIELDS:
  public            UnityEngine.RectInt             rect  // 0x10
  public            UnityEngine.UIElements.UIR.Allocator2D.Rowrow  // 0x20
  public            UnityEngine.UIElements.UIR.Allocalloc  // 0x28
METHODS:
  System.Void .ctor(UnityEngine.UIElements.UIR.Allocator2D.Row row, UnityEngine.UIElements.UIR.Alloc alloc, System.Int32 width, System.Int32 height)
END_CLASS

CLASS: RawTexture
TYPE:  struct
TOKEN: 0x20002DC
FIELDS:
  public            UnityEngine.Color32[]           rgba  // 0x10
  public            System.Int32                    width  // 0x18
  public            System.Int32                    height  // 0x1C
METHODS:
  System.Void WriteRawInt2Packed(System.Int32 v0, System.Int32 v1, System.Int32 destX, System.Int32 destY)
  System.Void WriteRawFloat4Packed(System.Single f0, System.Single f1, System.Single f2, System.Single f3, System.Int32 destX, System.Int32 destY)
END_CLASS

CLASS: Allocator
TYPE:  class
TOKEN: 0x20002E3
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.UIElements.MeshWriteData Invoke(System.UInt32 vertexCount, System.UInt32 indexCount, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData& allocatorData)
END_CLASS

CLASS: AllocMeshData
TYPE:  struct
TOKEN: 0x20002E2
FIELDS:
  private           UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocatoralloc  // 0x10
  private           UnityEngine.Texture             texture  // 0x18
  private           UnityEngine.UIElements.TextureIdsvgTexture  // 0x20
  private           UnityEngine.Material            material  // 0x28
  private           UnityEngine.UIElements.MeshGenerationContext.MeshFlagsflags  // 0x30
  private           UnityEngine.UIElements.UIR.BMPAlloccolorAlloc  // 0x34
METHODS:
  UnityEngine.UIElements.MeshWriteData Allocate(System.UInt32 vertexCount, System.UInt32 indexCount)
END_CLASS

CLASS: ClipCounts
TYPE:  struct
TOKEN: 0x20002E4
FIELDS:
  public            System.Int32                    firstClippedIndex  // 0x10
  public            System.Int32                    firstDegenerateIndex  // 0x14
  public            System.Int32                    lastClippedIndex  // 0x18
  public            System.Int32                    clippedTriangles  // 0x1C
  public            System.Int32                    addedTriangles  // 0x20
  public            System.Int32                    degenerateTriangles  // 0x24
METHODS:
END_CLASS

CLASS: VertexClipEdge
TYPE:  struct
TOKEN: 0x20002E5
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdgeNone  // 0x0
  public    static  UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdgeLeft  // 0x0
  public    static  UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdgeTop  // 0x0
  public    static  UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdgeRight  // 0x0
  public    static  UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdgeBottom  // 0x0
METHODS:
END_CLASS

CLASS: DepthOrderedDirtyTracking
TYPE:  struct
TOKEN: 0x20002E8
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>heads  // 0x10
  public            System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>tails  // 0x18
  public            System.Int32[]                  minDepths  // 0x20
  public            System.Int32[]                  maxDepths  // 0x28
  public            System.UInt32                   dirtyID  // 0x30
METHODS:
  System.Void EnsureFits(System.Int32 maxDepth)
  System.Void RegisterDirty(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderDataDirtyTypes dirtyTypes, UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses dirtyTypeClass)
  System.Void ClearDirty(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderDataDirtyTypes dirtyTypesInverse)
  System.Void Reset()
END_CLASS

CLASS: RenderChainStaticIndexAllocator
TYPE:  struct
TOKEN: 0x20002E9
FIELDS:
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChain>renderChains  // 0x0
METHODS:
  System.Int32 AllocateIndex(UnityEngine.UIElements.UIR.RenderChain renderChain)
  System.Void FreeIndex(System.Int32 index)
  UnityEngine.UIElements.UIR.RenderChain AccessIndex(System.Int32 index)
  System.Void .cctor()
END_CLASS

CLASS: RenderNodeData
TYPE:  struct
TOKEN: 0x20002EA
FIELDS:
  public            UnityEngine.Material            standardMaterial  // 0x10
  public            UnityEngine.Material            initialMaterial  // 0x18
  public            UnityEngine.MaterialPropertyBlockmatPropBlock  // 0x20
  public            UnityEngine.UIElements.UIR.RenderChainCommandfirstCommand  // 0x28
  public            UnityEngine.UIElements.UIR.UIRenderDevicedevice  // 0x30
  public            UnityEngine.Texture             vectorAtlas  // 0x38
  public            UnityEngine.Texture             shaderInfoAtlas  // 0x40
  public            System.Single                   dpiScale  // 0x48
  public            Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4>transformConstants  // 0x50
  public            Unity.Collections.NativeSlice<UnityEngine.Vector4>clipRectConstants  // 0x60
METHODS:
END_CLASS

CLASS: Edges
TYPE:  struct
TOKEN: 0x20002F9
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.Tessellation.EdgesNone  // 0x0
  public    static  UnityEngine.UIElements.UIR.Tessellation.EdgesLeft  // 0x0
  public    static  UnityEngine.UIElements.UIR.Tessellation.EdgesTop  // 0x0
  public    static  UnityEngine.UIElements.UIR.Tessellation.EdgesRight  // 0x0
  public    static  UnityEngine.UIElements.UIR.Tessellation.EdgesBottom  // 0x0
  public    static  UnityEngine.UIElements.UIR.Tessellation.EdgesAll  // 0x0
METHODS:
END_CLASS

CLASS: BlitInfo
TYPE:  struct
TOKEN: 0x20002FC
FIELDS:
  public            UnityEngine.Texture             src  // 0x10
  public            UnityEngine.RectInt             srcRect  // 0x18
  public            UnityEngine.Vector2Int          dstPos  // 0x28
  public            System.Int32                    border  // 0x30
  public            UnityEngine.Color               tint  // 0x34
METHODS:
END_CLASS

CLASS: Page
TYPE:  struct
TOKEN: 0x2000308
FIELDS:
  public            System.UInt16                   x  // 0x10
  public            System.UInt16                   y  // 0x12
  public            System.Int32                    freeSlots  // 0x14
METHODS:
END_CLASS

CLASS: AllocToUpdate
TYPE:  struct
TOKEN: 0x200030D
FIELDS:
  public            System.UInt32                   id  // 0x10
  public            System.UInt32                   allocTime  // 0x14
  public            UnityEngine.UIElements.UIR.MeshHandlemeshHandle  // 0x18
  public            UnityEngine.UIElements.UIR.AllocpermAllocVerts  // 0x20
  public            UnityEngine.UIElements.UIR.AllocpermAllocIndices  // 0x38
  public            UnityEngine.UIElements.UIR.Page permPage  // 0x50
  public            System.Boolean                  copyBackIndices  // 0x58
METHODS:
END_CLASS

CLASS: AllocToFree
TYPE:  struct
TOKEN: 0x200030E
FIELDS:
  public            UnityEngine.UIElements.UIR.Allocalloc  // 0x10
  public            UnityEngine.UIElements.UIR.Page page  // 0x28
  public            System.Boolean                  vertices  // 0x30
METHODS:
END_CLASS

CLASS: DeviceToFree
TYPE:  struct
TOKEN: 0x200030F
FIELDS:
  public            System.UInt32                   handle  // 0x10
  public            UnityEngine.UIElements.UIR.Page page  // 0x18
METHODS:
  System.Void Dispose()
END_CLASS

CLASS: EvaluationState
TYPE:  struct
TOKEN: 0x2000310
FIELDS:
  public            UnityEngine.MaterialPropertyBlockstateMatProps  // 0x10
  public            UnityEngine.Material            defaultMat  // 0x18
  public            UnityEngine.UIElements.UIR.StatecurState  // 0x20
  public            UnityEngine.UIElements.UIR.Page curPage  // 0x40
  public            System.Boolean                  mustApplyMaterial  // 0x48
  public            System.Boolean                  mustApplyCommonBlock  // 0x49
  public            System.Boolean                  mustApplyStateBlock  // 0x4A
  public            System.Boolean                  mustApplyStencil  // 0x4B
METHODS:
END_CLASS

CLASS: DrawStatistics
TYPE:  struct
TOKEN: 0x2000311
FIELDS:
  public            System.Int32                    currentFrameIndex  // 0x10
  public            System.UInt32                   totalIndices  // 0x14
  public            System.UInt32                   commandCount  // 0x18
  public            System.UInt32                   drawCommandCount  // 0x1C
  public            System.UInt32                   materialSetCount  // 0x20
  public            System.UInt32                   drawRangeCount  // 0x24
  public            System.UInt32                   drawRangeCallCount  // 0x28
  public            System.UInt32                   immediateDraws  // 0x2C
  public            System.UInt32                   stencilRefChanges  // 0x30
METHODS:
END_CLASS

CLASS: BlockPool
TYPE:  class
TOKEN: 0x2000315
EXTENDS: LinkedPool`1
FIELDS:
METHODS:
  UnityEngine.UIElements.UIR.BestFitAllocator.Block CreateBlock()
  System.Void ResetBlock(UnityEngine.UIElements.UIR.BestFitAllocator.Block block)
  System.Void .ctor()
END_CLASS

CLASS: Block
TYPE:  class
TOKEN: 0x2000316
EXTENDS: LinkedPoolItem`1
FIELDS:
  public            System.UInt32                   start  // 0x18
  public            System.UInt32                   end  // 0x1C
  public            UnityEngine.UIElements.UIR.BestFitAllocator.Blockprev  // 0x20
  public            UnityEngine.UIElements.UIR.BestFitAllocator.Blocknext  // 0x28
  public            UnityEngine.UIElements.UIR.BestFitAllocator.BlockprevAvailable  // 0x30
  public            UnityEngine.UIElements.UIR.BestFitAllocator.BlocknextAvailable  // 0x38
  public            System.Boolean                  allocated  // 0x40
METHODS:
  System.UInt32 get_size()
  System.Void .ctor()
END_CLASS

CLASS: DataSet`1
TYPE:  class
TOKEN: 0x2000319
FIELDS:
  private           System.Boolean                  <disposed>k__BackingField  // 0x0
  public            UnityEngine.UIElements.UIR.Utility.GPUBuffer<T>gpuData  // 0x0
  public            Unity.Collections.NativeArray<T>cpuData  // 0x0
  public            Unity.Collections.NativeArray<UnityEngine.UIElements.UIR.GfxUpdateBufferRange>updateRanges  // 0x0
  public            UnityEngine.UIElements.UIR.GPUBufferAllocatorallocator  // 0x0
  private   readonly System.UInt32                   m_UpdateRangePoolSize  // 0x0
  private           System.UInt32                   m_ElemStride  // 0x0
  private           System.UInt32                   m_UpdateRangeMin  // 0x0
  private           System.UInt32                   m_UpdateRangeMax  // 0x0
  private           System.UInt32                   m_UpdateRangesEnqueued  // 0x0
  private           System.UInt32                   m_UpdateRangesBatchStart  // 0x0
  private           System.Boolean                  m_UpdateRangesSaturated  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.UIElements.UIR.Utility.GPUBufferType bufferType, System.UInt32 totalCount, System.UInt32 maxQueuedFrameCount, System.UInt32 updateRangePoolSize, System.Boolean mockBuffer)
  System.Boolean get_disposed()
  System.Void set_disposed(System.Boolean value)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void RegisterUpdate(System.UInt32 start, System.UInt32 size)
  System.Boolean HasMappedBufferRange()
  System.Void SendUpdates()
  System.Void SendFullRange()
  System.Void SendPartialRanges()
  System.Void ResetUpdateState()
END_CLASS

CLASS: Entry
TYPE:  struct
TOKEN: 0x2000323
FIELDS:
  public            Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>vertices  // 0x10
  public            Unity.Collections.NativeSlice<System.UInt16>indices  // 0x20
  public            UnityEngine.Material            material  // 0x30
  public            UnityEngine.Texture             custom  // 0x38
  public            UnityEngine.Texture             font  // 0x40
  public            System.Single                   fontTexSDFScale  // 0x48
  public            UnityEngine.UIElements.TextureIdtexture  // 0x4C
  public            UnityEngine.UIElements.UIR.RenderChainCommandcustomCommand  // 0x50
  public            UnityEngine.UIElements.UIR.BMPAllocclipRectID  // 0x58
  public            UnityEngine.UIElements.UIR.VertexFlagsaddFlags  // 0x60
  public            System.Boolean                  uvIsDisplacement  // 0x64
  public            System.Boolean                  isTextEntry  // 0x65
  public            System.Boolean                  isClipRegisterEntry  // 0x66
  public            System.Int32                    stencilRef  // 0x68
  public            System.Int32                    maskDepth  // 0x6C
METHODS:
END_CLASS

CLASS: ClosingInfo
TYPE:  struct
TOKEN: 0x2000324
FIELDS:
  public            System.Boolean                  needsClosing  // 0x10
  public            System.Boolean                  popViewMatrix  // 0x11
  public            System.Boolean                  popScissorClip  // 0x12
  public            System.Boolean                  blitAndPopRenderTexture  // 0x13
  public            System.Boolean                  PopDefaultMaterial  // 0x14
  public            UnityEngine.UIElements.UIR.RenderChainCommandclipUnregisterDrawCommand  // 0x18
  public            Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>clipperRegisterVertices  // 0x20
  public            Unity.Collections.NativeSlice<System.UInt16>clipperRegisterIndices  // 0x30
  public            System.Int32                    clipperRegisterIndexOffset  // 0x40
  public            System.Int32                    maskStencilRef  // 0x44
METHODS:
END_CLASS

CLASS: TempDataAlloc`1
TYPE:  struct
TOKEN: 0x2000325
FIELDS:
  private           System.Int32                    maxPoolElemCount  // 0x0
  private           Unity.Collections.NativeArray<T>pool  // 0x0
  private           System.Collections.Generic.List<Unity.Collections.NativeArray<T>>excess  // 0x0
  private           System.UInt32                   takenFromPool  // 0x0
METHODS:
  System.Void .ctor(System.Int32 maxPoolElems)
  System.Void Dispose()
  Unity.Collections.NativeSlice<T> Alloc(System.UInt32 count)
  System.Void SessionDone()
END_CLASS

CLASS: ColumnState
TYPE:  struct
TOKEN: 0x200032E
FIELDS:
  public            System.Int32                    index  // 0x10
  public            System.String                   name  // 0x18
  public            System.Single                   actualWidth  // 0x20
  public            UnityEngine.UIElements.Length   width  // 0x24
  public            System.Boolean                  visible  // 0x2C
METHODS:
END_CLASS

CLASS: ViewState
TYPE:  class
TOKEN: 0x200032D
FIELDS:
  private           System.Boolean                  m_HasPersistedData  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription>m_SortDescriptions  // 0x18
  private           System.Collections.Generic.List<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ViewState.ColumnState>m_OrderedColumnStates  // 0x20
METHODS:
  System.Void Save(UnityEngine.UIElements.Internal.MultiColumnCollectionHeader header)
  System.Void Apply(UnityEngine.UIElements.Internal.MultiColumnCollectionHeader header)
  System.Void .ctor()
END_CLASS

CLASS: ColumnData
TYPE:  class
TOKEN: 0x200032F
FIELDS:
  private           UnityEngine.UIElements.Internal.MultiColumnHeaderColumn<control>k__BackingField  // 0x10
  private           UnityEngine.UIElements.Internal.MultiColumnHeaderColumnResizeHandle<resizeHandle>k__BackingField  // 0x18
METHODS:
  UnityEngine.UIElements.Internal.MultiColumnHeaderColumn get_control()
  System.Void set_control(UnityEngine.UIElements.Internal.MultiColumnHeaderColumn value)
  UnityEngine.UIElements.Internal.MultiColumnHeaderColumnResizeHandle get_resizeHandle()
  System.Void set_resizeHandle(UnityEngine.UIElements.Internal.MultiColumnHeaderColumnResizeHandle value)
  System.Void .ctor()
END_CLASS

CLASS: SortedColumnState
TYPE:  struct
TOKEN: 0x2000330
FIELDS:
  public            UnityEngine.UIElements.SortColumnDescriptioncolumnDesc  // 0x10
  public            UnityEngine.UIElements.SortDirectiondirection  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.UIElements.SortColumnDescription desc, UnityEngine.UIElements.SortDirection dir)
END_CLASS

CLASS: Unit
TYPE:  struct
TOKEN: 0x200033F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitUnitless  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitPixel  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitPercent  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitSecond  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitMillisecond  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitDegree  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitGradian  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitRadian  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Dimension.UnitTurn  // 0x0
METHODS:
END_CLASS

CLASS: GetCursorIdFunction
TYPE:  class
TOKEN: 0x2000344
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int32 Invoke(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle handle)
END_CLASS

CLASS: SheetHandleKey
TYPE:  struct
TOKEN: 0x2000349
FIELDS:
  public    readonly System.Int32                    sheetInstanceID  // 0x10
  public    readonly System.Int32                    index  // 0x14
METHODS:
  System.Void .ctor(UnityEngine.UIElements.StyleSheet sheet, System.Int32 index)
END_CLASS

CLASS: SheetHandleKeyComparer
TYPE:  class
TOKEN: 0x200034A
FIELDS:
METHODS:
  System.Boolean Equals(UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey x, UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey y)
  System.Int32 GetHashCode(UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey key)
  System.Void .ctor()
END_CLASS

CLASS: MatchContext
TYPE:  struct
TOKEN: 0x2000352
FIELDS:
  public            System.Int32                    valueIndex  // 0x10
  public            System.Int32                    matchedVariableCount  // 0x14
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=108
TYPE:  struct
TOKEN: 0x2000365
FIELDS:
METHODS:
END_CLASS

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsReadOnlyAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.AlignmentUtils
TYPE:  class
TOKEN: 0x2000004
FIELDS:
METHODS:
  System.Single RoundToPixelGrid(System.Single v, System.Single pixelsPerPoint, System.Single offset)
  System.Single CeilToPixelGrid(System.Single v, System.Single pixelsPerPoint, System.Single offset)
END_CLASS

CLASS: UnityEngine.UIElements.AtlasBase
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  private           UnityEngine.UIElements.TextureRegistrytextureRegistry  // 0x10
METHODS:
  System.Boolean TryGetAtlas(UnityEngine.UIElements.VisualElement ctx, UnityEngine.Texture2D src, UnityEngine.UIElements.TextureId& atlas, UnityEngine.RectInt& atlasRect)
  System.Void ReturnAtlas(UnityEngine.UIElements.VisualElement ctx, UnityEngine.Texture2D src, UnityEngine.UIElements.TextureId atlas)
  System.Void Reset()
  System.Void OnAssignedToPanel(UnityEngine.UIElements.IPanel panel)
  System.Void OnRemovedFromPanel(UnityEngine.UIElements.IPanel panel)
  System.Void OnUpdateDynamicTextures(UnityEngine.UIElements.IPanel panel)
  System.Void InvokeAssignedToPanel(UnityEngine.UIElements.IPanel panel)
  System.Void InvokeRemovedFromPanel(UnityEngine.UIElements.IPanel panel)
  System.Void InvokeUpdateDynamicTextures(UnityEngine.UIElements.IPanel panel)
  System.Void RepaintTexturedElements(UnityEngine.UIElements.IPanel panel)
  System.Void SetDynamicTexture(UnityEngine.UIElements.TextureId id, UnityEngine.Texture texture)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.DynamicAtlasFilters
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersNone  // 0x0
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersReadability  // 0x0
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersSize  // 0x0
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersFormat  // 0x0
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersColorSpace  // 0x0
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersFilterMode  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.DynamicAtlasCustomFilter
TYPE:  class
TOKEN: 0x2000007
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(UnityEngine.Texture2D texture, UnityEngine.UIElements.DynamicAtlasFilters& filtersToApply)
END_CLASS

CLASS: UnityEngine.UIElements.DynamicAtlas
TYPE:  class
TOKEN: 0x2000008
EXTENDS: AtlasBase
FIELDS:
  private           System.Collections.Generic.Dictionary<UnityEngine.Texture,UnityEngine.UIElements.DynamicAtlas.TextureInfo>m_Database  // 0x18
  private           UnityEngine.UIElements.DynamicAtlasPagem_PointPage  // 0x20
  private           UnityEngine.UIElements.DynamicAtlasPagem_BilinearPage  // 0x28
  private           UnityEngine.ColorSpace          m_ColorSpace  // 0x30
  private           System.Collections.Generic.List<UnityEngine.UIElements.IPanel>m_Panels  // 0x38
  private           System.Int32                    m_MinAtlasSize  // 0x40
  private           System.Int32                    m_MaxAtlasSize  // 0x44
  private           System.Int32                    m_MaxSubTextureSize  // 0x48
  private           UnityEngine.UIElements.DynamicAtlasFiltersm_ActiveFilters  // 0x4C
  private           UnityEngine.UIElements.DynamicAtlasCustomFilterm_CustomFilter  // 0x50
METHODS:
  System.Boolean get_isInitialized()
  System.Void OnAssignedToPanel(UnityEngine.UIElements.IPanel panel)
  System.Void OnRemovedFromPanel(UnityEngine.UIElements.IPanel panel)
  System.Void Reset()
  System.Void InitPages()
  System.Void DestroyPages()
  System.Boolean TryGetAtlas(UnityEngine.UIElements.VisualElement ve, UnityEngine.Texture2D src, UnityEngine.UIElements.TextureId& atlas, UnityEngine.RectInt& atlasRect)
  System.Void ReturnAtlas(UnityEngine.UIElements.VisualElement ve, UnityEngine.Texture2D src, UnityEngine.UIElements.TextureId atlas)
  System.Void OnUpdateDynamicTextures(UnityEngine.UIElements.IPanel panel)
  System.Boolean IsTextureFormatSupported(UnityEngine.TextureFormat format)
  System.Boolean IsTextureValid(UnityEngine.Texture2D texture, UnityEngine.FilterMode atlasFilterMode)
  System.Void set_minAtlasSize(System.Int32 value)
  System.Void set_maxAtlasSize(System.Int32 value)
  UnityEngine.UIElements.DynamicAtlasFilters get_defaultFilters()
  System.Void set_activeFilters(UnityEngine.UIElements.DynamicAtlasFilters value)
  System.Int32 get_maxSubTextureSize()
  System.Void set_maxSubTextureSize(System.Int32 value)
  System.Void set_customFilter(UnityEngine.UIElements.DynamicAtlasCustomFilter value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.BindableElement
TYPE:  class
TOKEN: 0x200000A
EXTENDS: VisualElement
FIELDS:
  private           UnityEngine.UIElements.IBinding <binding>k__BackingField  // 0x3C0
  private           System.String                   <bindingPath>k__BackingField  // 0x3C8
METHODS:
  UnityEngine.UIElements.IBinding get_binding()
  System.Void set_bindingPath(System.String value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ClampedDragger`1
TYPE:  class
TOKEN: 0x200000D
EXTENDS: Clickable
FIELDS:
  private           System.Action                   dragging  // 0x0
  private           System.Action                   draggingEnded  // 0x0
  private           UnityEngine.UIElements.ClampedDragger.DragDirection<T><dragDirection>k__BackingField  // 0x0
  private           UnityEngine.UIElements.BaseSlider<T><slider>k__BackingField  // 0x0
  private           UnityEngine.Vector2             <startMousePosition>k__BackingField  // 0x0
METHODS:
  System.Void add_dragging(System.Action value)
  System.Void remove_dragging(System.Action value)
  System.Void add_draggingEnded(System.Action value)
  System.Void remove_draggingEnded(System.Action value)
  UnityEngine.UIElements.ClampedDragger.DragDirection<T> get_dragDirection()
  System.Void set_dragDirection(UnityEngine.UIElements.ClampedDragger.DragDirection<T> value)
  System.Void set_slider(UnityEngine.UIElements.BaseSlider<T> value)
  UnityEngine.Vector2 get_startMousePosition()
  System.Void set_startMousePosition(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_delta()
  System.Void .ctor(UnityEngine.UIElements.BaseSlider<T> slider, System.Action clickHandler, System.Action dragHandler)
  System.Void ProcessDownEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId)
  System.Void ProcessUpEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId)
  System.Void ProcessMoveEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition)
END_CLASS

CLASS: UnityEngine.UIElements.Clickable
TYPE:  class
TOKEN: 0x200000F
EXTENDS: PointerManipulator
FIELDS:
  private           System.Action<UnityEngine.UIElements.EventBase>clickedWithEventInfo  // 0x38
  private           System.Action                   clicked  // 0x40
  private   readonly System.Int64                    m_Delay  // 0x48
  private   readonly System.Int64                    m_Interval  // 0x50
  private           System.Boolean                  <active>k__BackingField  // 0x58
  private           UnityEngine.Vector2             <lastMousePosition>k__BackingField  // 0x5C
  private           System.Int32                    m_ActivePointerId  // 0x64
  private           System.Boolean                  m_AcceptClicksIfDisabled  // 0x68
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_Repeater  // 0x70
METHODS:
  System.Void add_clickedWithEventInfo(System.Action<UnityEngine.UIElements.EventBase> value)
  System.Void remove_clickedWithEventInfo(System.Action<UnityEngine.UIElements.EventBase> value)
  System.Void add_clicked(System.Action value)
  System.Void remove_clicked(System.Action value)
  System.Boolean get_active()
  System.Void set_active(System.Boolean value)
  UnityEngine.Vector2 get_lastMousePosition()
  System.Void set_lastMousePosition(UnityEngine.Vector2 value)
  System.Boolean get_acceptClicksIfDisabled()
  System.Void set_acceptClicksIfDisabled(System.Boolean value)
  UnityEngine.UIElements.InvokePolicy get_invokePolicy()
  System.Void .ctor(System.Action handler, System.Int64 delay, System.Int64 interval)
  System.Void .ctor(System.Action<UnityEngine.UIElements.EventBase> handler)
  System.Void .ctor(System.Action handler)
  System.Void OnTimer(UnityEngine.UIElements.TimerState timerState)
  System.Boolean IsRepeatable()
  System.Void RegisterCallbacksOnTarget()
  System.Void UnregisterCallbacksFromTarget()
  System.Void OnMouseDown(UnityEngine.UIElements.MouseDownEvent evt)
  System.Void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent evt)
  System.Void OnMouseUp(UnityEngine.UIElements.MouseUpEvent evt)
  System.Void OnMouseCaptureOut(UnityEngine.UIElements.MouseCaptureOutEvent evt)
  System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt)
  System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt)
  System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  System.Void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt)
  System.Void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent evt)
  System.Boolean ContainsPointer(System.Int32 pointerId)
  System.Boolean IsNotMouseEvent(System.Int32 pointerId)
  System.Void Invoke(UnityEngine.UIElements.EventBase evt)
  System.Void SimulateSingleClick(UnityEngine.UIElements.EventBase evt, System.Int32 delayMs)
  System.Void ProcessDownEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId)
  System.Void ProcessMoveEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition)
  System.Void ProcessUpEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId)
  System.Void ProcessCancelEvent(UnityEngine.UIElements.EventBase evt, System.Int32 pointerId)
  System.Void <SimulateSingleClick>b__43_0()
END_CLASS

CLASS: UnityEngine.UIElements.ClickDetector
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.ClickDetector.ButtonClickStatus>m_ClickStatus  // 0x10
  private   static  System.Int32                    <s_DoubleClickTime>k__BackingField  // 0x0
METHODS:
  System.Int32 get_s_DoubleClickTime()
  System.Void set_s_DoubleClickTime(System.Int32 value)
  System.Void .ctor()
  System.Void StartClickTracking(UnityEngine.UIElements.EventBase evt)
  System.Void SendClickEvent(UnityEngine.UIElements.EventBase evt)
  System.Void CancelClickTracking(UnityEngine.UIElements.EventBase evt)
  System.Void ProcessEvent(UnityEngine.UIElements.EventBase evt)
  System.Boolean ContainsPointer(UnityEngine.UIElements.VisualElement element, UnityEngine.Vector2 position)
  System.Void Cleanup(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ContextualMenuManager
TYPE:  class
TOKEN: 0x2000012
FIELDS:
  private           System.Boolean                  <displayMenuHandledOSX>k__BackingField  // 0x10
METHODS:
  System.Boolean get_displayMenuHandledOSX()
  System.Void set_displayMenuHandledOSX(System.Boolean value)
  System.Void DisplayMenuIfEventMatches(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IEventHandler eventHandler)
  System.Void DisplayMenu(UnityEngine.UIElements.EventBase triggerEvent, UnityEngine.UIElements.IEventHandler target)
  System.Void DoDisplayMenu(UnityEngine.UIElements.DropdownMenu menu, UnityEngine.UIElements.EventBase triggerEvent)
END_CLASS

CLASS: UnityEngine.UIElements.ContextualMenuManipulator
TYPE:  class
TOKEN: 0x2000013
EXTENDS: MouseManipulator
FIELDS:
  private           System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent>m_MenuBuilder  // 0x30
METHODS:
  System.Void .ctor(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent> menuBuilder)
  System.Void RegisterCallbacksOnTarget()
  System.Void UnregisterCallbacksFromTarget()
  System.Void OnMouseUpDownEvent(UnityEngine.UIElements.IMouseEvent evt)
  System.Void OnMouseDownEventOSX(UnityEngine.UIElements.MouseDownEvent evt)
  System.Void OnMouseUpEventOSX(UnityEngine.UIElements.MouseUpEvent evt)
  System.Void OnKeyUpEvent(UnityEngine.UIElements.KeyUpEvent evt)
  System.Void DoDisplayMenu(UnityEngine.UIElements.EventBase evt)
  System.Void OnContextualMenuEvent(UnityEngine.UIElements.ContextualMenuPopulateEvent evt)
END_CLASS

CLASS: UnityEngine.UIElements.CountingBloomFilter
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  private           UnityEngine.UIElements.CountingBloomFilter.<m_Counters>e__FixedBufferm_Counters  // 0x10
METHODS:
  System.Void AdjustSlot(System.UInt32 index, System.Boolean increment)
  System.UInt32 Hash1(System.UInt32 hash)
  System.UInt32 Hash2(System.UInt32 hash)
  System.Boolean IsSlotEmpty(System.UInt32 index)
  System.Void InsertHash(System.UInt32 hash)
  System.Void RemoveHash(System.UInt32 hash)
  System.Boolean ContainsHash(System.UInt32 hash)
END_CLASS

CLASS: UnityEngine.UIElements.AncestorFilter
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  private           UnityEngine.UIElements.CountingBloomFilterm_CountingBloomFilter  // 0x10
  private           System.Collections.Generic.Stack<System.Int32>m_HashStack  // 0x4010
METHODS:
  System.Void .ctor()
  System.Void AddHash(System.Int32 hash)
  System.Boolean IsCandidate(UnityEngine.UIElements.StyleComplexSelector complexSel)
  System.Void PushElement(UnityEngine.UIElements.VisualElement element)
  System.Void PopElement()
END_CLASS

CLASS: UnityEngine.UIElements.Cursor
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  private           UnityEngine.Texture2D           <texture>k__BackingField  // 0x10
  private           UnityEngine.Vector2             <hotspot>k__BackingField  // 0x18
  private           System.Int32                    <defaultCursorId>k__BackingField  // 0x20
METHODS:
  UnityEngine.Texture2D get_texture()
  System.Void set_texture(UnityEngine.Texture2D value)
  UnityEngine.Vector2 get_hotspot()
  System.Void set_hotspot(UnityEngine.Vector2 value)
  System.Int32 get_defaultCursorId()
  System.Void set_defaultCursorId(System.Int32 value)
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.UIElements.Cursor other)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.UIElements.Cursor style1, UnityEngine.UIElements.Cursor style2)
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.ICursorManager
TYPE:  interface
TOKEN: 0x2000018
FIELDS:
METHODS:
  System.Void SetCursor(UnityEngine.UIElements.Cursor cursor)
  System.Void ResetCursor()
END_CLASS

CLASS: UnityEngine.UIElements.CursorManager
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  private           System.Boolean                  <isCursorOverriden>k__BackingField  // 0x10
METHODS:
  System.Boolean get_isCursorOverriden()
  System.Void set_isCursorOverriden(System.Boolean value)
  System.Void SetCursor(UnityEngine.UIElements.Cursor cursor)
  System.Void ResetCursor()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.DefaultEventSystem
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  private   static  System.Func<System.Boolean>     IsEditorRemoteConnected  // 0x0
  private           UnityEngine.UIElements.DefaultEventSystem.IInputm_Input  // 0x10
  private   readonly System.String                   m_HorizontalAxis  // 0x18
  private   readonly System.String                   m_VerticalAxis  // 0x20
  private   readonly System.String                   m_SubmitButton  // 0x28
  private   readonly System.String                   m_CancelButton  // 0x30
  private   readonly System.Single                   m_InputActionsPerSecond  // 0x38
  private   readonly System.Single                   m_RepeatDelay  // 0x3C
  private           System.Boolean                  m_SendingTouchEvents  // 0x40
  private           UnityEngine.Event               m_Event  // 0x48
  private           UnityEngine.UIElements.BaseRuntimePanelm_FocusedPanel  // 0x50
  private           System.Int32                    m_ConsecutiveMoveCount  // 0x58
  private           UnityEngine.Vector2             m_LastMoveVector  // 0x5C
  private           System.Single                   m_PrevActionTime  // 0x64
METHODS:
  System.Boolean get_isAppFocused()
  UnityEngine.UIElements.DefaultEventSystem.IInput get_input()
  UnityEngine.UIElements.DefaultEventSystem.IInput GetDefaultInput()
  System.Boolean ShouldIgnoreEventsOnAppNotFocused()
  UnityEngine.UIElements.BaseRuntimePanel get_focusedPanel()
  System.Void set_focusedPanel(UnityEngine.UIElements.BaseRuntimePanel value)
  System.Void Update(UnityEngine.UIElements.DefaultEventSystem.UpdateMode updateMode)
  System.Void SendIMGUIEvents()
  System.Void SendInputEvents()
  System.Void SendFocusBasedEvent(System.Func<TArg,UnityEngine.UIElements.EventBase> evtFactory, TArg arg)
  System.Void SendPositionBasedEvent(UnityEngine.Vector3 mousePosition, UnityEngine.Vector3 delta, System.Int32 pointerId, System.Nullable<System.Int32> targetDisplay, System.Func<UnityEngine.Vector3,UnityEngine.Vector3,TArg,UnityEngine.UIElements.EventBase> evtFactory, TArg arg, System.Boolean deselectIfNoTarget)
  System.Void UpdateFocusedPanel(UnityEngine.UIElements.BaseRuntimePanel runtimePanel)
  UnityEngine.UIElements.EventBase MakeTouchEvent(UnityEngine.Touch touch, UnityEngine.EventModifiers modifiers)
  System.Boolean ProcessTouchEvents()
  UnityEngine.Vector2 GetRawMoveVector()
  System.Boolean ShouldSendMoveFromInput()
  UnityEngine.Vector2 GetLocalScreenPosition(UnityEngine.Event evt, System.Nullable<System.Int32>& targetDisplay)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.DisposeHelper
TYPE:  class
TOKEN: 0x2000020
FIELDS:
METHODS:
  System.Void NotifyDisposedUsed(System.IDisposable disposable)
END_CLASS

CLASS: UnityEngine.UIElements.DropdownMenuEventInfo
TYPE:  class
TOKEN: 0x2000021
FIELDS:
  private   readonly UnityEngine.EventModifiers      <modifiers>k__BackingField  // 0x10
  private   readonly UnityEngine.Vector2             <mousePosition>k__BackingField  // 0x14
  private   readonly UnityEngine.Vector2             <localMousePosition>k__BackingField  // 0x1C
  private   readonly System.Char                     <character>k__BackingField  // 0x24
  private   readonly UnityEngine.KeyCode             <keyCode>k__BackingField  // 0x28
METHODS:
  System.Void .ctor(UnityEngine.UIElements.EventBase e)
END_CLASS

CLASS: UnityEngine.UIElements.DropdownMenuItem
TYPE:  class
TOKEN: 0x2000022
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.DropdownMenuSeparator
TYPE:  class
TOKEN: 0x2000023
EXTENDS: DropdownMenuItem
FIELDS:
  private   readonly System.String                   <subMenuPath>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.String subMenuPath)
END_CLASS

CLASS: UnityEngine.UIElements.DropdownMenuAction
TYPE:  class
TOKEN: 0x2000024
EXTENDS: DropdownMenuItem
FIELDS:
  private   readonly System.String                   <name>k__BackingField  // 0x10
  private           UnityEngine.UIElements.DropdownMenuAction.Status<status>k__BackingField  // 0x18
  private           UnityEngine.UIElements.DropdownMenuEventInfo<eventInfo>k__BackingField  // 0x20
  private           System.Object                   <userData>k__BackingField  // 0x28
  private   readonly System.Action<UnityEngine.UIElements.DropdownMenuAction>actionCallback  // 0x30
  private   readonly System.Func<UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction.Status>actionStatusCallback  // 0x38
METHODS:
  System.Void set_status(UnityEngine.UIElements.DropdownMenuAction.Status value)
  System.Void set_eventInfo(UnityEngine.UIElements.DropdownMenuEventInfo value)
  System.Void set_userData(System.Object value)
  UnityEngine.UIElements.DropdownMenuAction.Status AlwaysEnabled(UnityEngine.UIElements.DropdownMenuAction a)
  UnityEngine.UIElements.DropdownMenuAction.Status AlwaysDisabled(UnityEngine.UIElements.DropdownMenuAction a)
  System.Void .ctor(System.String actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> actionCallback, System.Func<UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback, System.Object userData)
  System.Void UpdateActionStatus(UnityEngine.UIElements.DropdownMenuEventInfo eventInfo)
END_CLASS

CLASS: UnityEngine.UIElements.DropdownMenu
TYPE:  class
TOKEN: 0x2000026
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem>m_MenuItems  // 0x10
  private           UnityEngine.UIElements.DropdownMenuEventInfom_DropdownMenuEventInfo  // 0x18
METHODS:
  System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem> MenuItems()
  System.Void AppendAction(System.String actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> action, System.Func<UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback, System.Object userData)
  System.Void AppendAction(System.String actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> action, UnityEngine.UIElements.DropdownMenuAction.Status status)
  System.Void AppendSeparator(System.String subMenuPath)
  System.Void InsertSeparator(System.String subMenuPath, System.Int32 atIndex)
  System.Void PrepareForDisplay(UnityEngine.UIElements.EventBase e)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.DropdownUtility
TYPE:  class
TOKEN: 0x2000028
FIELDS:
  private   static  System.Func<UnityEngine.UIElements.IGenericMenu>MakeDropdownFunc  // 0x0
METHODS:
  UnityEngine.UIElements.IGenericMenu CreateDropdown()
END_CLASS

CLASS: UnityEngine.UIElements.DispatchMode
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DispatchModeDefault  // 0x0
  public    static  UnityEngine.UIElements.DispatchModeQueued  // 0x0
  public    static  UnityEngine.UIElements.DispatchModeImmediate  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.EventDispatcherGate
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  private   readonly UnityEngine.UIElements.EventDispatcherm_Dispatcher  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.UIElements.EventDispatcher d)
  System.Void Dispose()
  System.Boolean Equals(UnityEngine.UIElements.EventDispatcherGate other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.EventDispatcher
TYPE:  class
TOKEN: 0x200002B
FIELDS:
  private           UnityEngine.UIElements.ClickDetectorm_ClickDetector  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.IEventDispatchingStrategy>m_DispatchingStrategies  // 0x18
  private   static readonly UnityEngine.UIElements.ObjectPool<System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord>>k_EventQueuePool  // 0x0
  private           System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord>m_Queue  // 0x20
  private   readonly UnityEngine.UIElements.PointerDispatchState<pointerState>k__BackingField  // 0x28
  private           System.UInt32                   m_GateCount  // 0x30
  private           System.Collections.Generic.Stack<UnityEngine.UIElements.EventDispatcher.DispatchContext>m_DispatchContexts  // 0x38
  private   static readonly UnityEngine.UIElements.IEventDispatchingStrategy[]s_EditorStrategies  // 0x8
  private           System.Boolean                  m_Immediate  // 0x40
  private           System.Boolean                  <processingEvents>k__BackingField  // 0x41
METHODS:
  UnityEngine.UIElements.PointerDispatchState get_pointerState()
  UnityEngine.UIElements.EventDispatcher CreateForRuntime(System.Collections.Generic.IList<UnityEngine.UIElements.IEventDispatchingStrategy> strategies)
  System.Void .ctor(System.Collections.Generic.IList<UnityEngine.UIElements.IEventDispatchingStrategy> strategies)
  System.Boolean get_dispatchImmediately()
  System.Void set_processingEvents(System.Boolean value)
  System.Void Dispatch(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.DispatchMode dispatchMode)
  System.Void CloseGate()
  System.Void OpenGate()
  System.Void ProcessEventQueue()
  System.Void ProcessEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  System.Void ApplyDispatchingStrategies(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel, System.Boolean imguiEventIsInitiallyUsed)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Focusable
TYPE:  class
TOKEN: 0x200002E
EXTENDS: CallbackEventHandler
FIELDS:
  private           System.Boolean                  <focusable>k__BackingField  // 0x20
  private           System.Int32                    <tabIndex>k__BackingField  // 0x24
  private           System.Boolean                  m_DelegatesFocus  // 0x28
  private           System.Boolean                  m_ExcludeFromFocusRing  // 0x29
METHODS:
  System.Void .ctor()
  UnityEngine.UIElements.FocusController get_focusController()
  System.Boolean get_focusable()
  System.Void set_focusable(System.Boolean value)
  System.Int32 get_tabIndex()
  System.Void set_tabIndex(System.Int32 value)
  System.Boolean get_delegatesFocus()
  System.Void set_delegatesFocus(System.Boolean value)
  System.Boolean get_excludeFromFocusRing()
  System.Void set_excludeFromFocusRing(System.Boolean value)
  System.Boolean get_canGrabFocus()
  System.Void Focus()
  System.Void Blur()
  System.Void BlurImmediately()
  UnityEngine.UIElements.Focusable GetFocusDelegate()
  UnityEngine.UIElements.Focusable GetFirstFocusableChild(UnityEngine.UIElements.VisualElement ve)
  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  System.Void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase evt)
  System.Void ProcessEvent(UnityEngine.UIElements.EventBase evt)
END_CLASS

CLASS: UnityEngine.UIElements.FocusChangeDirection
TYPE:  class
TOKEN: 0x200002F
FIELDS:
  private   static readonly UnityEngine.UIElements.FocusChangeDirection<unspecified>k__BackingField  // 0x0
  private   static readonly UnityEngine.UIElements.FocusChangeDirection<none>k__BackingField  // 0x8
  private   static readonly UnityEngine.UIElements.FocusChangeDirection<lastValue>k__BackingField  // 0x10
  private   readonly System.Int32                    m_Value  // 0x10
METHODS:
  UnityEngine.UIElements.FocusChangeDirection get_unspecified()
  UnityEngine.UIElements.FocusChangeDirection get_none()
  UnityEngine.UIElements.FocusChangeDirection get_lastValue()
  System.Void .ctor(System.Int32 value)
  System.Int32 op_Implicit(UnityEngine.UIElements.FocusChangeDirection fcd)
  System.Void System.IDisposable.Dispose()
  System.Void Dispose()
  System.Void ApplyTo(UnityEngine.UIElements.FocusController focusController, UnityEngine.UIElements.Focusable f)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.IFocusRing
TYPE:  interface
TOKEN: 0x2000030
FIELDS:
METHODS:
  UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.EventBase e)
  UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.FocusChangeDirection direction)
END_CLASS

CLASS: UnityEngine.UIElements.FocusController
TYPE:  class
TOKEN: 0x2000031
FIELDS:
  private   readonly UnityEngine.UIElements.IFocusRing<focusRing>k__BackingField  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.FocusController.FocusedElement>m_FocusedElements  // 0x18
  private           UnityEngine.UIElements.Focusablem_LastFocusedElement  // 0x20
  private           UnityEngine.UIElements.Focusablem_LastPendingFocusedElement  // 0x28
  private           System.Int32                    m_PendingFocusCount  // 0x30
  private           System.Int32                    <imguiKeyboardControl>k__BackingField  // 0x34
METHODS:
  System.Void .ctor(UnityEngine.UIElements.IFocusRing focusRing)
  UnityEngine.UIElements.IFocusRing get_focusRing()
  UnityEngine.UIElements.Focusable get_focusedElement()
  System.Boolean IsFocused(UnityEngine.UIElements.Focusable f)
  UnityEngine.UIElements.Focusable GetRetargetedFocusedElement(UnityEngine.UIElements.VisualElement retargetAgainst)
  UnityEngine.UIElements.Focusable GetLeafFocusedElement()
  System.Boolean IsLocalElement(UnityEngine.UIElements.Focusable f)
  System.Boolean IsPendingFocus(UnityEngine.UIElements.Focusable f)
  System.Void SetFocusToLastFocusedElement()
  System.Void BlurLastFocusedElement()
  System.Void DoFocusChange(UnityEngine.UIElements.Focusable f)
  UnityEngine.UIElements.Focusable FocusNextInDirection(UnityEngine.UIElements.FocusChangeDirection direction)
  System.Void AboutToReleaseFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willGiveFocusTo, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.DispatchMode dispatchMode)
  System.Void ReleaseFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willGiveFocusTo, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.DispatchMode dispatchMode)
  System.Void AboutToGrabFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willTakeFocusFrom, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.DispatchMode dispatchMode)
  System.Void GrabFocus(UnityEngine.UIElements.Focusable focusable, UnityEngine.UIElements.Focusable willTakeFocusFrom, UnityEngine.UIElements.FocusChangeDirection direction, System.Boolean bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode)
  System.Void Blur(UnityEngine.UIElements.Focusable focusable, System.Boolean bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode)
  System.Void SwitchFocus(UnityEngine.UIElements.Focusable newFocusedElement, System.Boolean bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode)
  System.Void SwitchFocus(UnityEngine.UIElements.Focusable newFocusedElement, UnityEngine.UIElements.FocusChangeDirection direction, System.Boolean bIsFocusDelegated, UnityEngine.UIElements.DispatchMode dispatchMode)
  UnityEngine.UIElements.Focusable SwitchFocusOnEvent(UnityEngine.UIElements.EventBase e)
  System.Void ReevaluateFocus()
  System.Boolean GetFocusableParentForPointerEvent(UnityEngine.UIElements.Focusable target, UnityEngine.UIElements.Focusable& effectiveTarget)
  System.Int32 get_imguiKeyboardControl()
  System.Void set_imguiKeyboardControl(System.Int32 value)
  System.Void SyncIMGUIFocus(System.Int32 imguiKeyboardControlID, UnityEngine.UIElements.Focusable imguiContainerHavingKeyboardControl, System.Boolean forceSwitch)
END_CLASS

CLASS: UnityEngine.UIElements.GroupBoxUtility
TYPE:  class
TOKEN: 0x2000033
FIELDS:
  private   static  System.Collections.Generic.Dictionary<UnityEngine.UIElements.IGroupBox,UnityEngine.UIElements.IGroupManager>s_GroupManagers  // 0x0
  private   static  System.Collections.Generic.Dictionary<UnityEngine.UIElements.IGroupBoxOption,UnityEngine.UIElements.IGroupManager>s_GroupOptionManagerCache  // 0x8
  private   static readonly System.Type                     k_GenericGroupBoxType  // 0x10
METHODS:
  System.Void RegisterGroupBoxOptionCallbacks(T option)
  System.Void OnOptionSelected(T selectedOption)
  System.Void OnOptionAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt)
  System.Void OnOptionDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt)
  UnityEngine.UIElements.IGroupManager FindOrCreateGroupManager(UnityEngine.UIElements.IGroupBox groupBox)
  System.Void OnGroupBoxDetachedFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt)
  System.Void OnPanelDestroyed(UnityEngine.UIElements.BaseVisualElementPanel panel)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.IGroupBoxOption
TYPE:  interface
TOKEN: 0x2000034
FIELDS:
METHODS:
  System.Void SetSelected(System.Boolean selected)
END_CLASS

CLASS: UnityEngine.UIElements.IGroupBox
TYPE:  interface
TOKEN: 0x2000035
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IGroupBox`1
TYPE:  interface
TOKEN: 0x2000036
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IGroupManager
TYPE:  interface
TOKEN: 0x2000037
FIELDS:
METHODS:
  System.Void OnOptionSelectionChanged(UnityEngine.UIElements.IGroupBoxOption selectedOption)
  System.Void RegisterOption(UnityEngine.UIElements.IGroupBoxOption option)
  System.Void UnregisterOption(UnityEngine.UIElements.IGroupBoxOption option)
END_CLASS

CLASS: UnityEngine.UIElements.DefaultGroupManager
TYPE:  class
TOKEN: 0x2000038
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.IGroupBoxOption>m_GroupOptions  // 0x10
  private           UnityEngine.UIElements.IGroupBoxOptionm_SelectedOption  // 0x18
METHODS:
  System.Void OnOptionSelectionChanged(UnityEngine.UIElements.IGroupBoxOption selectedOption)
  System.Void RegisterOption(UnityEngine.UIElements.IGroupBoxOption option)
  System.Void UnregisterOption(UnityEngine.UIElements.IGroupBoxOption option)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.IMGUIContainer
TYPE:  class
TOKEN: 0x2000039
EXTENDS: VisualElement
FIELDS:
  private           System.Action                   m_OnGUIHandler  // 0x3C0
  private           UnityEngine.ObjectGUIState      m_ObjectGUIState  // 0x3C8
  private           System.Boolean                  useOwnerObjectGUIState  // 0x3D0
  private           UnityEngine.Rect                <lastWorldClip>k__BackingField  // 0x3D4
  private           System.Boolean                  m_CullingEnabled  // 0x3E4
  private           System.Boolean                  m_IsFocusDelegated  // 0x3E5
  private           System.Boolean                  m_RefreshCachedLayout  // 0x3E6
  private           UnityEngine.GUILayoutUtility.LayoutCachem_Cache  // 0x3E8
  private           UnityEngine.Rect                m_CachedClippingRect  // 0x3F0
  private           UnityEngine.Matrix4x4           m_CachedTransform  // 0x400
  private           UnityEngine.UIElements.ContextType<contextType>k__BackingField  // 0x440
  private           System.Boolean                  lostFocus  // 0x444
  private           System.Boolean                  receivedFocus  // 0x445
  private           UnityEngine.UIElements.FocusChangeDirectionfocusChangeDirection  // 0x448
  private           System.Boolean                  hasFocusableControls  // 0x450
  private           System.Int32                    newKeyboardFocusControlID  // 0x454
  private           System.Boolean                  <focusOnlyIfHasFocusableControls>k__BackingField  // 0x458
  public    static readonly System.String                   ussClassName  // 0x0
  private   static readonly System.String                   ussFoldoutChildDepthClassName  // 0x8
  private   static readonly System.Collections.Generic.List<System.String>ussFoldoutChildDepthClassNames  // 0x10
  private           UnityEngine.UIElements.IMGUIContainer.GUIGlobalsm_GUIGlobals  // 0x45C
  private   static readonly Unity.Profiling.ProfilerMarker  k_OnGUIMarker  // 0x18
  private   static readonly Unity.Profiling.ProfilerMarker  k_ImmediateCallbackMarker  // 0x20
  private   static  UnityEngine.Event               s_DefaultMeasureEvent  // 0x28
  private   static  UnityEngine.Event               s_MeasureEvent  // 0x30
  private   static  UnityEngine.Event               s_CurrentEvent  // 0x38
METHODS:
  System.Action get_onGUIHandler()
  System.Void set_onGUIHandler(System.Action value)
  UnityEngine.ObjectGUIState get_guiState()
  UnityEngine.Rect get_lastWorldClip()
  System.Void set_lastWorldClip(UnityEngine.Rect value)
  System.Boolean get_cullingEnabled()
  UnityEngine.GUILayoutUtility.LayoutCache get_cache()
  System.Single get_layoutMeasuredWidth()
  System.Single get_layoutMeasuredHeight()
  UnityEngine.UIElements.ContextType get_contextType()
  System.Void set_contextType(UnityEngine.UIElements.ContextType value)
  System.Boolean get_focusOnlyIfHasFocusableControls()
  System.Boolean get_canGrabFocus()
  System.Void .cctor()
  System.Void .ctor()
  System.Void .ctor(System.Action onGUIHandler)
  System.Void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc)
  System.Void SaveGlobals()
  System.Void RestoreGlobals()
  System.Void DoOnGUI(UnityEngine.Event evt, UnityEngine.Matrix4x4 parentTransform, UnityEngine.Rect clippingRect, System.Boolean isComputingLayout, UnityEngine.Rect layoutSize, System.Action onGUIHandler, System.Boolean canAffectFocus)
  System.Void MarkDirtyLayout()
  System.Void HandleEvent(UnityEngine.UIElements.EventBase evt)
  System.Void DoIMGUIRepaint()
  System.Boolean SendEventToIMGUI(UnityEngine.UIElements.EventBase evt, System.Boolean canAffectFocus, System.Boolean verifyBounds)
  System.Boolean SendEventToIMGUIRaw(UnityEngine.UIElements.EventBase evt, System.Boolean canAffectFocus, System.Boolean verifyBounds)
  System.Boolean VerifyBounds(UnityEngine.UIElements.EventBase evt)
  System.Boolean IsContainerCapturingTheMouse()
  System.Boolean IsLocalEvent(UnityEngine.UIElements.EventBase evt)
  System.Boolean IsEventInsideLocalWindow(UnityEngine.UIElements.EventBase evt)
  System.Boolean IsDockAreaMouseUp(UnityEngine.UIElements.EventBase evt)
  System.Boolean HandleIMGUIEvent(UnityEngine.Event e, System.Boolean canAffectFocus)
  System.Boolean HandleIMGUIEvent(UnityEngine.Event e, System.Action onGUIHandler, System.Boolean canAffectFocus)
  System.Boolean HandleIMGUIEvent(UnityEngine.Event e, UnityEngine.Matrix4x4 worldTransform, UnityEngine.Rect clippingRect, System.Action onGUIHandler, System.Boolean canAffectFocus)
  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  System.Void SetFoldoutDepthClass()
  UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode)
  UnityEngine.Rect GetCurrentClipRect()
  System.Void GetCurrentTransformAndClip(UnityEngine.UIElements.IMGUIContainer container, UnityEngine.Event evt, UnityEngine.Matrix4x4& transform, UnityEngine.Rect& clipRect)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposeManaged)
  System.Void <DoOnGUI>b__56_0()
END_CLASS

CLASS: UnityEngine.UIElements.ImmediateModeException
TYPE:  class
TOKEN: 0x200003D
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor(System.Exception inner)
END_CLASS

CLASS: UnityEngine.UIElements.SelectionType
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.SelectionTypeNone  // 0x0
  public    static  UnityEngine.UIElements.SelectionTypeSingle  // 0x0
  public    static  UnityEngine.UIElements.SelectionTypeMultiple  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.ISerializableJsonDictionary
TYPE:  interface
TOKEN: 0x200003F
FIELDS:
METHODS:
  System.Void Set(System.String key, T value)
  T Get(System.String key)
  System.Void Overwrite(System.Object obj, System.String key)
  System.Boolean ContainsKey(System.String key)
END_CLASS

CLASS: UnityEngine.UIElements.ITransform
TYPE:  interface
TOKEN: 0x2000040
FIELDS:
METHODS:
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_scale()
END_CLASS

CLASS: UnityEngine.UIElements.KeyboardNavigationOperation
TYPE:  struct
TOKEN: 0x2000041
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationNone  // 0x0
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationSelectAll  // 0x0
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationCancel  // 0x0
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationSubmit  // 0x0
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationPrevious  // 0x0
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationNext  // 0x0
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationMoveRight  // 0x0
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationMoveLeft  // 0x0
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationPageUp  // 0x0
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationPageDown  // 0x0
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationBegin  // 0x0
  public    static  UnityEngine.UIElements.KeyboardNavigationOperationEnd  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.KeyboardNavigationManipulator
TYPE:  class
TOKEN: 0x2000042
EXTENDS: Manipulator
FIELDS:
  private   readonly System.Action<UnityEngine.UIElements.KeyboardNavigationOperation,UnityEngine.UIElements.EventBase>m_Action  // 0x18
METHODS:
  System.Void .ctor(System.Action<UnityEngine.UIElements.KeyboardNavigationOperation,UnityEngine.UIElements.EventBase> action)
  System.Void RegisterCallbacksOnTarget()
  System.Void UnregisterCallbacksFromTarget()
  System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt)
  System.Void OnRuntimeKeyDown(UnityEngine.UIElements.KeyDownEvent evt)
  System.Void OnEditorKeyDown(UnityEngine.UIElements.KeyDownEvent evt)
  System.Void OnNavigationCancel(UnityEngine.UIElements.NavigationCancelEvent evt)
  System.Void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent evt)
  System.Void OnNavigationMove(UnityEngine.UIElements.NavigationMoveEvent evt)
  System.Void Invoke(UnityEngine.UIElements.KeyboardNavigationOperation operation, UnityEngine.UIElements.EventBase evt)
  UnityEngine.UIElements.KeyboardNavigationOperation <OnRuntimeKeyDown>g__GetOperation|5_0(UnityEngine.UIElements.KeyboardNavigationManipulator.<>c__DisplayClass5_0& )
  UnityEngine.UIElements.KeyboardNavigationOperation <OnEditorKeyDown>g__GetOperation|6_0(UnityEngine.UIElements.KeyboardNavigationManipulator.<>c__DisplayClass6_0& )
END_CLASS

CLASS: UnityEngine.UIElements.ManipulatorActivationFilter
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  private           UnityEngine.UIElements.MouseButton<button>k__BackingField  // 0x10
  private           UnityEngine.EventModifiers      <modifiers>k__BackingField  // 0x14
  private           System.Int32                    <clickCount>k__BackingField  // 0x18
METHODS:
  UnityEngine.UIElements.MouseButton get_button()
  System.Void set_button(UnityEngine.UIElements.MouseButton value)
  UnityEngine.EventModifiers get_modifiers()
  System.Void set_modifiers(UnityEngine.EventModifiers value)
  System.Int32 get_clickCount()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.UIElements.ManipulatorActivationFilter other)
  System.Int32 GetHashCode()
  System.Boolean Matches(UnityEngine.UIElements.IMouseEvent e)
  System.Boolean HasModifiers(UnityEngine.UIElements.IMouseEvent e)
  System.Boolean Matches(UnityEngine.UIElements.IPointerEvent e)
  System.Boolean HasModifiers(UnityEngine.UIElements.IPointerEvent e)
  System.Boolean MatchModifiers(System.Boolean alt, System.Boolean ctrl, System.Boolean shift, System.Boolean command)
END_CLASS

CLASS: UnityEngine.UIElements.IManipulator
TYPE:  interface
TOKEN: 0x2000046
FIELDS:
METHODS:
  System.Void set_target(UnityEngine.UIElements.VisualElement value)
END_CLASS

CLASS: UnityEngine.UIElements.Manipulator
TYPE:  class
TOKEN: 0x2000047
FIELDS:
  private           UnityEngine.UIElements.VisualElementm_Target  // 0x10
METHODS:
  System.Void RegisterCallbacksOnTarget()
  System.Void UnregisterCallbacksFromTarget()
  UnityEngine.UIElements.VisualElement get_target()
  System.Void set_target(UnityEngine.UIElements.VisualElement value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseButton
TYPE:  struct
TOKEN: 0x2000048
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.MouseButtonLeftMouse  // 0x0
  public    static  UnityEngine.UIElements.MouseButtonRightMouse  // 0x0
  public    static  UnityEngine.UIElements.MouseButtonMiddleMouse  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.MouseCaptureController
TYPE:  class
TOKEN: 0x2000049
FIELDS:
METHODS:
  System.Boolean HasMouseCapture(UnityEngine.UIElements.IEventHandler handler)
  System.Void CaptureMouse(UnityEngine.UIElements.IEventHandler handler)
  System.Void ReleaseMouse(UnityEngine.UIElements.IEventHandler handler)
END_CLASS

CLASS: UnityEngine.UIElements.MouseManipulator
TYPE:  class
TOKEN: 0x200004A
EXTENDS: Manipulator
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter><activators>k__BackingField  // 0x18
  private           UnityEngine.UIElements.ManipulatorActivationFilterm_currentActivator  // 0x20
METHODS:
  System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> get_activators()
  System.Void set_activators(System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> value)
  System.Void .ctor()
  System.Boolean CanStartManipulation(UnityEngine.UIElements.IMouseEvent e)
  System.Boolean CanStopManipulation(UnityEngine.UIElements.IMouseEvent e)
END_CLASS

CLASS: UnityEngine.UIElements.ObjectPool`1
TYPE:  class
TOKEN: 0x200004B
FIELDS:
  private   readonly System.Collections.Generic.Stack<T>m_Stack  // 0x0
  private           System.Int32                    m_MaxSize  // 0x0
METHODS:
  System.Int32 get_maxSize()
  System.Void set_maxSize(System.Int32 value)
  System.Void .ctor(System.Int32 maxSize)
  System.Int32 Size()
  T Get()
  System.Void Release(T element)
END_CLASS

CLASS: UnityEngine.UIElements.ContextType
TYPE:  struct
TOKEN: 0x200004C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ContextTypePlayer  // 0x0
  public    static  UnityEngine.UIElements.ContextTypeEditor  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.VersionChangeType
TYPE:  struct
TOKEN: 0x200004D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.VersionChangeTypeBindings  // 0x0
  public    static  UnityEngine.UIElements.VersionChangeTypeViewData  // 0x0
  public    static  UnityEngine.UIElements.VersionChangeTypeHierarchy  // 0x0
  public    static  UnityEngine.UIElements.VersionChangeTypeLayout  // 0x0
  public    static  UnityEngine.UIElements.VersionChangeTypeStyleSheet  // 0x0
  public    static  UnityEngine.UIElements.VersionChangeTypeStyles  // 0x0
  public    static  UnityEngine.UIElements.VersionChangeTypeOverflow  // 0x0
  public    static  UnityEngine.UIElements.VersionChangeTypeBorderRadius  // 0x0
  public    static  UnityEngine.UIElements.VersionChangeTypeBorderWidth  // 0x0
  public    static  UnityEngine.UIElements.VersionChangeTypeTransform  // 0x0
  public    static  UnityEngine.UIElements.VersionChangeTypeSize  // 0x0
  public    static  UnityEngine.UIElements.VersionChangeTypeRepaint  // 0x0
  public    static  UnityEngine.UIElements.VersionChangeTypeOpacity  // 0x0
  public    static  UnityEngine.UIElements.VersionChangeTypeColor  // 0x0
  public    static  UnityEngine.UIElements.VersionChangeTypeRenderHints  // 0x0
  public    static  UnityEngine.UIElements.VersionChangeTypeTransitionProperty  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UsageHints
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UsageHintsNone  // 0x0
  public    static  UnityEngine.UIElements.UsageHintsDynamicTransform  // 0x0
  public    static  UnityEngine.UIElements.UsageHintsGroupTransform  // 0x0
  public    static  UnityEngine.UIElements.UsageHintsMaskContainer  // 0x0
  public    static  UnityEngine.UIElements.UsageHintsDynamicColor  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.RenderHints
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.RenderHintsNone  // 0x0
  public    static  UnityEngine.UIElements.RenderHintsGroupTransform  // 0x0
  public    static  UnityEngine.UIElements.RenderHintsBoneTransform  // 0x0
  public    static  UnityEngine.UIElements.RenderHintsClipWithScissors  // 0x0
  public    static  UnityEngine.UIElements.RenderHintsMaskContainer  // 0x0
  public    static  UnityEngine.UIElements.RenderHintsDynamicColor  // 0x0
  public    static  UnityEngine.UIElements.RenderHintsDirtyOffset  // 0x0
  public    static  UnityEngine.UIElements.RenderHintsDirtyGroupTransform  // 0x0
  public    static  UnityEngine.UIElements.RenderHintsDirtyBoneTransform  // 0x0
  public    static  UnityEngine.UIElements.RenderHintsDirtyClipWithScissors  // 0x0
  public    static  UnityEngine.UIElements.RenderHintsDirtyMaskContainer  // 0x0
  public    static  UnityEngine.UIElements.RenderHintsDirtyAll  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.PanelClearSettings
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  public            System.Boolean                  clearDepthStencil  // 0x10
  public            System.Boolean                  clearColor  // 0x11
  public            UnityEngine.Color               color  // 0x14
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.RepaintData
TYPE:  class
TOKEN: 0x2000051
FIELDS:
  private           UnityEngine.Matrix4x4           <currentOffset>k__BackingField  // 0x10
  private           UnityEngine.Vector2             <mousePosition>k__BackingField  // 0x50
  private           UnityEngine.Rect                <currentWorldClip>k__BackingField  // 0x58
  private           UnityEngine.Event               <repaintEvent>k__BackingField  // 0x68
METHODS:
  UnityEngine.Matrix4x4 get_currentOffset()
  UnityEngine.Rect get_currentWorldClip()
  UnityEngine.Event get_repaintEvent()
  System.Void set_repaintEvent(UnityEngine.Event value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.HierarchyEvent
TYPE:  class
TOKEN: 0x2000052
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType changeType)
END_CLASS

CLASS: UnityEngine.UIElements.IPanel
TYPE:  interface
TOKEN: 0x2000053
FIELDS:
METHODS:
  UnityEngine.UIElements.VisualElement get_visualTree()
  UnityEngine.UIElements.EventDispatcher get_dispatcher()
  UnityEngine.UIElements.ContextType get_contextType()
  UnityEngine.UIElements.FocusController get_focusController()
  UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 point)
END_CLASS

CLASS: UnityEngine.UIElements.BaseVisualElementPanel
TYPE:  class
TOKEN: 0x2000054
FIELDS:
  private           System.Action<UnityEngine.UIElements.BaseVisualElementPanel>panelDisposed  // 0x10
  private           System.Single                   m_Scale  // 0x18
  private           UnityEngine.Yoga.YogaConfig     yogaConfig  // 0x20
  private           System.Single                   m_PixelsPerPoint  // 0x28
  private           UnityEngine.UIElements.PanelClearSettings<clearSettings>k__BackingField  // 0x2C
  private           System.Boolean                  <duringLayoutPhase>k__BackingField  // 0x40
  private           UnityEngine.UIElements.RepaintData<repaintData>k__BackingField  // 0x48
  private           UnityEngine.UIElements.ICursorManager<cursorManager>k__BackingField  // 0x50
  private           UnityEngine.UIElements.ContextualMenuManager<contextualMenuManager>k__BackingField  // 0x58
  private           System.Boolean                  <disposed>k__BackingField  // 0x60
  private           UnityEngine.UIElements.ElementUnderPointerm_TopElementUnderPointers  // 0x68
  private           System.Action                   standardShaderChanged  // 0x70
  private           System.Action                   standardWorldSpaceShaderChanged  // 0x78
  private           System.Action                   atlasChanged  // 0x80
  private           System.Action<UnityEngine.Material>updateMaterial  // 0x88
  private           UnityEngine.UIElements.HierarchyEventhierarchyChanged  // 0x90
  private           System.Action<UnityEngine.UIElements.IPanel>beforeUpdate  // 0x98
METHODS:
  UnityEngine.EventInterests get_IMGUIEventInterests()
  System.Void set_IMGUIEventInterests(UnityEngine.EventInterests value)
  UnityEngine.ScriptableObject get_ownerObject()
  System.Void set_ownerObject(UnityEngine.ScriptableObject value)
  UnityEngine.UIElements.SavePersistentViewData get_saveViewData()
  UnityEngine.UIElements.GetViewDataDictionary get_getViewDataDictionary()
  System.Int32 get_IMGUIContainersCount()
  System.Void set_IMGUIContainersCount(System.Int32 value)
  UnityEngine.UIElements.FocusController get_focusController()
  System.Void set_focusController(UnityEngine.UIElements.FocusController value)
  UnityEngine.UIElements.IMGUIContainer get_rootIMGUIContainer()
  System.Void add_panelDisposed(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value)
  System.Void remove_panelDisposed(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value)
  System.Void .ctor()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void Repaint(UnityEngine.Event e)
  System.Void ValidateLayout()
  System.Void UpdateAnimations()
  System.Void UpdateBindings()
  System.Void ApplyStyles()
  System.Single get_scale()
  System.Void set_scale(System.Single value)
  System.Void set_pixelsPerPoint(System.Single value)
  System.Single get_scaledPixelsPerPoint()
  UnityEngine.UIElements.PanelClearSettings get_clearSettings()
  System.Void set_clearSettings(UnityEngine.UIElements.PanelClearSettings value)
  System.Boolean get_duringLayoutPhase()
  System.Void set_duringLayoutPhase(System.Boolean value)
  System.UInt32 get_version()
  System.UInt32 get_hierarchyVersion()
  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ele, UnityEngine.UIElements.VersionChangeType changeTypeFlag)
  UnityEngine.UIElements.RepaintData get_repaintData()
  System.Void set_repaintData(UnityEngine.UIElements.RepaintData value)
  UnityEngine.UIElements.ICursorManager get_cursorManager()
  System.Void set_cursorManager(UnityEngine.UIElements.ICursorManager value)
  UnityEngine.UIElements.ContextualMenuManager get_contextualMenuManager()
  System.Void set_contextualMenuManager(UnityEngine.UIElements.ContextualMenuManager value)
  UnityEngine.UIElements.VisualElement get_visualTree()
  UnityEngine.UIElements.EventDispatcher get_dispatcher()
  System.Void set_dispatcher(UnityEngine.UIElements.EventDispatcher value)
  System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.UIElements.DispatchMode dispatchMode)
  UnityEngine.UIElements.IScheduler get_scheduler()
  UnityEngine.UIElements.IStylePropertyAnimationSystem get_styleAnimationSystem()
  System.Void set_styleAnimationSystem(UnityEngine.UIElements.IStylePropertyAnimationSystem value)
  UnityEngine.UIElements.ContextType get_contextType()
  System.Void set_contextType(UnityEngine.UIElements.ContextType value)
  UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 point)
  UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked)
  System.Boolean get_disposed()
  System.Void set_disposed(System.Boolean value)
  UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase)
  UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(System.Int32 pointerId)
  UnityEngine.UIElements.VisualElement RecomputeTopElementUnderPointer(System.Int32 pointerId, UnityEngine.Vector2 pointerPos, UnityEngine.UIElements.EventBase triggerEvent)
  System.Void ClearCachedElementUnderPointer(System.Int32 pointerId, UnityEngine.UIElements.EventBase triggerEvent)
  System.Void CommitElementUnderPointers()
  UnityEngine.Shader get_standardShader()
  UnityEngine.Shader get_standardWorldSpaceShader()
  System.Void add_standardShaderChanged(System.Action value)
  System.Void remove_standardShaderChanged(System.Action value)
  System.Void add_standardWorldSpaceShaderChanged(System.Action value)
  System.Void remove_standardWorldSpaceShaderChanged(System.Action value)
  System.Void add_atlasChanged(System.Action value)
  System.Void remove_atlasChanged(System.Action value)
  System.Void InvokeAtlasChanged()
  UnityEngine.UIElements.AtlasBase get_atlas()
  System.Void set_atlas(UnityEngine.UIElements.AtlasBase value)
  System.Void InvokeUpdateMaterial(UnityEngine.Material mat)
  System.Void add_hierarchyChanged(UnityEngine.UIElements.HierarchyEvent value)
  System.Void remove_hierarchyChanged(UnityEngine.UIElements.HierarchyEvent value)
  System.Void InvokeHierarchyChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType changeType)
  System.Void InvokeBeforeUpdate()
  System.Void UpdateElementUnderPointers()
  System.Void Update()
END_CLASS

CLASS: UnityEngine.UIElements.LoadResourceFunction
TYPE:  class
TOKEN: 0x2000055
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.Object Invoke(System.String pathName, System.Type type, System.Single dpiScaling)
END_CLASS

CLASS: UnityEngine.UIElements.TimeMsFunction
TYPE:  class
TOKEN: 0x2000056
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int64 Invoke()
END_CLASS

CLASS: UnityEngine.UIElements.GetViewDataDictionary
TYPE:  class
TOKEN: 0x2000057
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  UnityEngine.UIElements.ISerializableJsonDictionary Invoke()
END_CLASS

CLASS: UnityEngine.UIElements.SavePersistentViewData
TYPE:  class
TOKEN: 0x2000058
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
END_CLASS

CLASS: UnityEngine.UIElements.Panel
TYPE:  class
TOKEN: 0x2000059
EXTENDS: BaseVisualElementPanel
FIELDS:
  private           UnityEngine.UIElements.VisualElementm_RootContainer  // 0xA0
  private           UnityEngine.UIElements.VisualTreeUpdaterm_VisualTreeUpdater  // 0xA8
  private           UnityEngine.UIElements.IStylePropertyAnimationSystemm_StylePropertyAnimationSystem  // 0xB0
  private           System.String                   m_PanelName  // 0xB8
  private           System.UInt32                   m_Version  // 0xC0
  private           System.UInt32                   m_RepaintVersion  // 0xC4
  private           System.UInt32                   m_HierarchyVersion  // 0xC8
  private           Unity.Profiling.ProfilerMarker  m_MarkerBeforeUpdate  // 0xD0
  private           Unity.Profiling.ProfilerMarker  m_MarkerUpdate  // 0xD8
  private           Unity.Profiling.ProfilerMarker  m_MarkerLayout  // 0xE0
  private           Unity.Profiling.ProfilerMarker  m_MarkerBindings  // 0xE8
  private           Unity.Profiling.ProfilerMarker  m_MarkerAnimations  // 0xF0
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerPickAll  // 0x0
  private           UnityEngine.UIElements.EventDispatcher<dispatcher>k__BackingField  // 0xF8
  private           UnityEngine.UIElements.TimerEventSchedulerm_Scheduler  // 0x100
  private           UnityEngine.ScriptableObject    <ownerObject>k__BackingField  // 0x108
  private           UnityEngine.UIElements.ContextType<contextType>k__BackingField  // 0x110
  private           UnityEngine.UIElements.SavePersistentViewData<saveViewData>k__BackingField  // 0x118
  private           UnityEngine.UIElements.GetViewDataDictionary<getViewDataDictionary>k__BackingField  // 0x120
  private           UnityEngine.UIElements.FocusController<focusController>k__BackingField  // 0x128
  private           UnityEngine.EventInterests      <IMGUIEventInterests>k__BackingField  // 0x130
  private   static  UnityEngine.UIElements.LoadResourceFunction<loadResourceFunc>k__BackingField  // 0x8
  private   static  UnityEngine.UIElements.TimeMsFunction<TimeSinceStartup>k__BackingField  // 0x10
  private           System.Int32                    <IMGUIContainersCount>k__BackingField  // 0x134
  private           UnityEngine.UIElements.IMGUIContainer<rootIMGUIContainer>k__BackingField  // 0x138
  private           UnityEngine.Shader              m_StandardShader  // 0x140
  private           UnityEngine.UIElements.AtlasBasem_Atlas  // 0x148
  private           System.Boolean                  m_ValidatingLayout  // 0x150
  private   static  System.Action<UnityEngine.UIElements.Panel>beforeAnyRepaint  // 0x18
METHODS:
  UnityEngine.UIElements.VisualElement get_visualTree()
  UnityEngine.UIElements.EventDispatcher get_dispatcher()
  System.Void set_dispatcher(UnityEngine.UIElements.EventDispatcher value)
  UnityEngine.UIElements.TimerEventScheduler get_timerEventScheduler()
  UnityEngine.UIElements.IScheduler get_scheduler()
  UnityEngine.UIElements.IStylePropertyAnimationSystem get_styleAnimationSystem()
  System.Void set_styleAnimationSystem(UnityEngine.UIElements.IStylePropertyAnimationSystem value)
  UnityEngine.ScriptableObject get_ownerObject()
  System.Void set_ownerObject(UnityEngine.ScriptableObject value)
  UnityEngine.UIElements.ContextType get_contextType()
  System.Void set_contextType(UnityEngine.UIElements.ContextType value)
  UnityEngine.UIElements.SavePersistentViewData get_saveViewData()
  UnityEngine.UIElements.GetViewDataDictionary get_getViewDataDictionary()
  UnityEngine.UIElements.FocusController get_focusController()
  System.Void set_focusController(UnityEngine.UIElements.FocusController value)
  UnityEngine.EventInterests get_IMGUIEventInterests()
  System.Void set_IMGUIEventInterests(UnityEngine.EventInterests value)
  UnityEngine.UIElements.LoadResourceFunction get_loadResourceFunc()
  UnityEngine.Object LoadResource(System.String pathName, System.Type type, System.Single dpiScaling)
  System.Void Focus()
  System.Void Blur()
  System.String get_name()
  System.Void set_name(System.String value)
  System.Void CreateMarkers()
  UnityEngine.UIElements.TimeMsFunction get_TimeSinceStartup()
  System.Int32 get_IMGUIContainersCount()
  System.Void set_IMGUIContainersCount(System.Int32 value)
  UnityEngine.UIElements.IMGUIContainer get_rootIMGUIContainer()
  System.UInt32 get_version()
  System.UInt32 get_hierarchyVersion()
  UnityEngine.Shader get_standardShader()
  UnityEngine.UIElements.AtlasBase get_atlas()
  System.Void set_atlas(UnityEngine.UIElements.AtlasBase value)
  System.Void .ctor(UnityEngine.ScriptableObject ownerObject, UnityEngine.UIElements.ContextType contextType, UnityEngine.UIElements.EventDispatcher dispatcher)
  System.Void Dispose(System.Boolean disposing)
  System.Int64 TimeSinceStartupMs()
  System.Int64 DefaultTimeSinceStartupMs()
  UnityEngine.UIElements.VisualElement PickAll(UnityEngine.UIElements.VisualElement root, UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked)
  UnityEngine.UIElements.VisualElement PerformPick(UnityEngine.UIElements.VisualElement root, UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked)
  UnityEngine.UIElements.VisualElement PickAll(UnityEngine.Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked)
  UnityEngine.UIElements.VisualElement Pick(UnityEngine.Vector2 point)
  System.Void ValidateLayout()
  System.Void UpdateAnimations()
  System.Void UpdateBindings()
  System.Void ApplyStyles()
  System.Void UpdateForRepaint()
  System.Void Repaint(UnityEngine.Event e)
  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase)
  System.Void .cctor()
  UnityEngine.Vector2Int <Pick>g__PixelOf|99_0(UnityEngine.Vector2 p)
END_CLASS

CLASS: UnityEngine.UIElements.BaseRuntimePanel
TYPE:  class
TOKEN: 0x200005A
EXTENDS: Panel
FIELDS:
  private           UnityEngine.GameObject          m_SelectableGameObject  // 0x158
  private   static  System.Int32                    s_CurrentRuntimePanelCounter  // 0x0
  private   readonly System.Int32                    m_RuntimePanelCreationIndex  // 0x160
  private           System.Single                   m_SortingPriority  // 0x164
  private           System.Action                   destroyed  // 0x168
  private           UnityEngine.Shader              m_StandardWorldSpaceShader  // 0x170
  private           System.Boolean                  m_DrawToCameras  // 0x178
  private           UnityEngine.RenderTexture       targetTexture  // 0x180
  private           UnityEngine.Matrix4x4           panelToWorld  // 0x188
  private           System.Int32                    <targetDisplay>k__BackingField  // 0x1C8
  private   static readonly System.Func<UnityEngine.Vector2,UnityEngine.Vector2>DefaultScreenToPanelSpace  // 0x8
  private           System.Func<UnityEngine.Vector2,UnityEngine.Vector2>m_ScreenToPanelSpace  // 0x1D0
METHODS:
  UnityEngine.GameObject get_selectableGameObject()
  System.Void set_selectableGameObject(UnityEngine.GameObject value)
  System.Single get_sortingPriority()
  System.Void set_sortingPriority(System.Single value)
  System.Void add_destroyed(System.Action value)
  System.Void remove_destroyed(System.Action value)
  System.Void .ctor(UnityEngine.ScriptableObject ownerObject, UnityEngine.UIElements.EventDispatcher dispatcher)
  System.Void Dispose(System.Boolean disposing)
  UnityEngine.Shader get_standardWorldSpaceShader()
  System.Boolean get_drawToCameras()
  System.Void set_drawToCameras(System.Boolean value)
  System.Int32 get_targetDisplay()
  System.Void set_targetDisplay(System.Int32 value)
  System.Int32 get_screenRenderingWidth()
  System.Int32 get_screenRenderingHeight()
  System.Void Repaint(UnityEngine.Event e)
  System.Func<UnityEngine.Vector2,UnityEngine.Vector2> get_screenToPanelSpace()
  System.Void set_screenToPanelSpace(System.Func<UnityEngine.Vector2,UnityEngine.Vector2> value)
  UnityEngine.Vector2 ScreenToPanel(UnityEngine.Vector2 screen)
  System.Boolean ScreenToPanel(UnityEngine.Vector2 screenPosition, UnityEngine.Vector2 screenDelta, UnityEngine.Vector2& panelPosition, UnityEngine.Vector2& panelDelta, System.Boolean allowOutside)
  System.Void AssignPanelToComponents(UnityEngine.UIElements.BaseRuntimePanel panel)
  System.Void PointerLeavesPanel(System.Int32 pointerId, UnityEngine.Vector2 position)
  System.Void PointerEntersPanel(System.Int32 pointerId, UnityEngine.Vector2 position)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.IRuntimePanelComponent
TYPE:  interface
TOKEN: 0x200005C
FIELDS:
METHODS:
  System.Void set_panel(UnityEngine.UIElements.IPanel value)
END_CLASS

CLASS: UnityEngine.UIElements.PointerCaptureHelper
TYPE:  class
TOKEN: 0x200005D
FIELDS:
METHODS:
  UnityEngine.UIElements.PointerDispatchState GetStateFor(UnityEngine.UIElements.IEventHandler handler)
  System.Boolean HasPointerCapture(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId)
  System.Void CapturePointer(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId)
  System.Void ReleasePointer(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId)
  UnityEngine.UIElements.IEventHandler GetCapturingElement(UnityEngine.UIElements.IPanel panel, System.Int32 pointerId)
  System.Void ReleasePointer(UnityEngine.UIElements.IPanel panel, System.Int32 pointerId)
  System.Void ActivateCompatibilityMouseEvents(UnityEngine.UIElements.IPanel panel, System.Int32 pointerId)
  System.Void PreventCompatibilityMouseEvents(UnityEngine.UIElements.IPanel panel, System.Int32 pointerId)
  System.Boolean ShouldSendCompatibilityMouseEvents(UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.IPointerEvent evt)
  System.Void ProcessPointerCapture(UnityEngine.UIElements.IPanel panel, System.Int32 pointerId)
END_CLASS

CLASS: UnityEngine.UIElements.PointerDispatchState
TYPE:  class
TOKEN: 0x200005E
FIELDS:
  private           UnityEngine.UIElements.IEventHandler[]m_PendingPointerCapture  // 0x10
  private           UnityEngine.UIElements.IEventHandler[]m_PointerCapture  // 0x18
  private           System.Boolean[]                m_ShouldSendCompatibilityMouseEvents  // 0x20
METHODS:
  System.Void .ctor()
  System.Void Reset()
  UnityEngine.UIElements.IEventHandler GetCapturingElement(System.Int32 pointerId)
  System.Boolean HasPointerCapture(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId)
  System.Void CapturePointer(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId)
  System.Void ReleasePointer(System.Int32 pointerId)
  System.Void ReleasePointer(UnityEngine.UIElements.IEventHandler handler, System.Int32 pointerId)
  System.Void ProcessPointerCapture(System.Int32 pointerId)
  System.Void ActivateCompatibilityMouseEvents(System.Int32 pointerId)
  System.Void PreventCompatibilityMouseEvents(System.Int32 pointerId)
  System.Boolean ShouldSendCompatibilityMouseEvents(UnityEngine.UIElements.IPointerEvent evt)
END_CLASS

CLASS: UnityEngine.UIElements.PointerManipulator
TYPE:  class
TOKEN: 0x200005F
EXTENDS: MouseManipulator
FIELDS:
  private           System.Int32                    m_CurrentPointerId  // 0x30
METHODS:
  System.Boolean CanStartManipulation(UnityEngine.UIElements.IPointerEvent e)
  System.Boolean CanStopManipulation(UnityEngine.UIElements.IPointerEvent e)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ProjectionUtils
TYPE:  class
TOKEN: 0x2000060
FIELDS:
METHODS:
  UnityEngine.Matrix4x4 Ortho(System.Single left, System.Single right, System.Single bottom, System.Single top, System.Single near, System.Single far)
END_CLASS

CLASS: UnityEngine.UIElements.TimerState
TYPE:  struct
TOKEN: 0x2000061
FIELDS:
  private           System.Int64                    <start>k__BackingField  // 0x10
  private           System.Int64                    <now>k__BackingField  // 0x18
METHODS:
  System.Int64 get_start()
  System.Void set_start(System.Int64 value)
  System.Int64 get_now()
  System.Void set_now(System.Int64 value)
  System.Int64 get_deltaTime()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.UIElements.TimerState other)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.IScheduler
TYPE:  interface
TOKEN: 0x2000062
FIELDS:
METHODS:
  System.Void Unschedule(UnityEngine.UIElements.ScheduledItem item)
  System.Void Schedule(UnityEngine.UIElements.ScheduledItem item)
  System.Void UpdateScheduledEvents()
END_CLASS

CLASS: UnityEngine.UIElements.ScheduledItem
TYPE:  class
TOKEN: 0x2000063
FIELDS:
  public            System.Func<System.Boolean>     timerUpdateStopCondition  // 0x10
  public    static readonly System.Func<System.Boolean>     OnceCondition  // 0x0
  public    static readonly System.Func<System.Boolean>     ForeverCondition  // 0x8
  private           System.Int64                    <startMs>k__BackingField  // 0x18
  private           System.Int64                    <delayMs>k__BackingField  // 0x20
  private           System.Int64                    <intervalMs>k__BackingField  // 0x28
  private           System.Int64                    <endTimeMs>k__BackingField  // 0x30
METHODS:
  System.Int64 get_startMs()
  System.Void set_startMs(System.Int64 value)
  System.Int64 get_delayMs()
  System.Void set_delayMs(System.Int64 value)
  System.Int64 get_intervalMs()
  System.Void set_intervalMs(System.Int64 value)
  System.Int64 get_endTimeMs()
  System.Void .ctor()
  System.Void ResetStartTime()
  System.Void PerformTimerUpdate(UnityEngine.UIElements.TimerState state)
  System.Void OnItemUnscheduled()
  System.Boolean ShouldUnschedule()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.TimerEventScheduler
TYPE:  class
TOKEN: 0x2000065
FIELDS:
  private   readonly System.Collections.Generic.List<UnityEngine.UIElements.ScheduledItem>m_ScheduledItems  // 0x10
  private           System.Boolean                  m_TransactionMode  // 0x18
  private   readonly System.Collections.Generic.List<UnityEngine.UIElements.ScheduledItem>m_ScheduleTransactions  // 0x20
  private   readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.ScheduledItem>m_UnscheduleTransactions  // 0x28
  private           System.Boolean                  disableThrottling  // 0x30
  private           System.Int32                    m_LastUpdatedIndex  // 0x34
METHODS:
  System.Void Schedule(UnityEngine.UIElements.ScheduledItem item)
  System.Boolean RemovedScheduledItemAt(System.Int32 index)
  System.Void Unschedule(UnityEngine.UIElements.ScheduledItem item)
  System.Boolean PrivateUnSchedule(UnityEngine.UIElements.ScheduledItem sItem)
  System.Void UpdateScheduledEvents()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.Spacing
TYPE:  struct
TOKEN: 0x2000066
FIELDS:
  public            System.Single                   left  // 0x10
  public            System.Single                   top  // 0x14
  public            System.Single                   right  // 0x18
  public            System.Single                   bottom  // 0x1C
METHODS:
  System.Single get_horizontal()
  System.Single get_vertical()
  System.Void .ctor(System.Single left, System.Single top, System.Single right, System.Single bottom)
  UnityEngine.Rect op_Subtraction(UnityEngine.Rect r, UnityEngine.UIElements.Spacing a)
END_CLASS

CLASS: UnityEngine.UIElements.Position
TYPE:  struct
TOKEN: 0x2000067
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.Position Relative  // 0x0
  public    static  UnityEngine.UIElements.Position Absolute  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.OverflowInternal
TYPE:  struct
TOKEN: 0x2000068
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.OverflowInternalVisible  // 0x0
  public    static  UnityEngine.UIElements.OverflowInternalHidden  // 0x0
  public    static  UnityEngine.UIElements.OverflowInternalScroll  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.OverflowClipBox
TYPE:  struct
TOKEN: 0x2000069
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.OverflowClipBoxPaddingBox  // 0x0
  public    static  UnityEngine.UIElements.OverflowClipBoxContentBox  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.FlexDirection
TYPE:  struct
TOKEN: 0x200006A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.FlexDirectionColumn  // 0x0
  public    static  UnityEngine.UIElements.FlexDirectionColumnReverse  // 0x0
  public    static  UnityEngine.UIElements.FlexDirectionRow  // 0x0
  public    static  UnityEngine.UIElements.FlexDirectionRowReverse  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Wrap
TYPE:  struct
TOKEN: 0x200006B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.Wrap     NoWrap  // 0x0
  public    static  UnityEngine.UIElements.Wrap     Wrap  // 0x0
  public    static  UnityEngine.UIElements.Wrap     WrapReverse  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Align
TYPE:  struct
TOKEN: 0x200006C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.Align    Auto  // 0x0
  public    static  UnityEngine.UIElements.Align    FlexStart  // 0x0
  public    static  UnityEngine.UIElements.Align    Center  // 0x0
  public    static  UnityEngine.UIElements.Align    FlexEnd  // 0x0
  public    static  UnityEngine.UIElements.Align    Stretch  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Justify
TYPE:  struct
TOKEN: 0x200006D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.Justify  FlexStart  // 0x0
  public    static  UnityEngine.UIElements.Justify  Center  // 0x0
  public    static  UnityEngine.UIElements.Justify  FlexEnd  // 0x0
  public    static  UnityEngine.UIElements.Justify  SpaceBetween  // 0x0
  public    static  UnityEngine.UIElements.Justify  SpaceAround  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.TextOverflowPosition
TYPE:  struct
TOKEN: 0x200006E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.TextOverflowPositionEnd  // 0x0
  public    static  UnityEngine.UIElements.TextOverflowPositionStart  // 0x0
  public    static  UnityEngine.UIElements.TextOverflowPositionMiddle  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.TextOverflow
TYPE:  struct
TOKEN: 0x200006F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.TextOverflowClip  // 0x0
  public    static  UnityEngine.UIElements.TextOverflowEllipsis  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.TransformOriginOffset
TYPE:  struct
TOKEN: 0x2000070
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.TransformOriginOffsetLeft  // 0x0
  public    static  UnityEngine.UIElements.TransformOriginOffsetRight  // 0x0
  public    static  UnityEngine.UIElements.TransformOriginOffsetTop  // 0x0
  public    static  UnityEngine.UIElements.TransformOriginOffsetBottom  // 0x0
  public    static  UnityEngine.UIElements.TransformOriginOffsetCenter  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Visibility
TYPE:  struct
TOKEN: 0x2000071
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.VisibilityVisible  // 0x0
  public    static  UnityEngine.UIElements.VisibilityHidden  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.WhiteSpace
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.WhiteSpaceNormal  // 0x0
  public    static  UnityEngine.UIElements.WhiteSpaceNoWrap  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.DisplayStyle
TYPE:  struct
TOKEN: 0x2000073
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DisplayStyleFlex  // 0x0
  public    static  UnityEngine.UIElements.DisplayStyleNone  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IStylePainter
TYPE:  interface
TOKEN: 0x2000074
FIELDS:
METHODS:
  System.Void DrawText(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint)
  System.Void DrawRectangle(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams)
  System.Void DrawImmediate(System.Action callback, System.Boolean cullingEnabled)
END_CLASS

CLASS: UnityEngine.UIElements.CursorPositionStylePainterParameters
TYPE:  struct
TOKEN: 0x2000075
FIELDS:
  public            UnityEngine.Rect                rect  // 0x10
  public            System.String                   text  // 0x20
  public            UnityEngine.Font                font  // 0x28
  public            System.Int32                    fontSize  // 0x30
  public            UnityEngine.FontStyle           fontStyle  // 0x34
  public            UnityEngine.TextAnchor          anchor  // 0x38
  public            System.Single                   wordWrapWidth  // 0x3C
  public            System.Boolean                  richText  // 0x40
  public            System.Int32                    cursorIndex  // 0x44
METHODS:
  UnityEngine.UIElements.CursorPositionStylePainterParameters GetDefault(UnityEngine.UIElements.VisualElement ve, System.String text)
  UnityEngine.UIElements.TextNativeSettings GetTextNativeSettings(System.Single scaling)
END_CLASS

CLASS: UnityEngine.UIElements.IStylePropertyAnimations
TYPE:  interface
TOKEN: 0x2000076
FIELDS:
METHODS:
  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Single from, System.Single to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 from, System.Int32 to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length from, UnityEngine.UIElements.Length to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color from, UnityEngine.Color to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartEnum(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 from, System.Int32 to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Background from, UnityEngine.UIElements.Background to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.FontDefinition from, UnityEngine.UIElements.FontDefinition to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Font from, UnityEngine.Font to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TextShadow from, UnityEngine.UIElements.TextShadow to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Scale from, UnityEngine.UIElements.Scale to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Translate from, UnityEngine.UIElements.Translate to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Rotate from, UnityEngine.UIElements.Rotate to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TransformOrigin from, UnityEngine.UIElements.TransformOrigin to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Void UpdateAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Void GetAllAnimations(System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds)
  System.Void CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Void CancelAllAnimations()
  System.Int32 get_runningAnimationCount()
  System.Void set_runningAnimationCount(System.Int32 value)
  System.Int32 get_completedAnimationCount()
  System.Void set_completedAnimationCount(System.Int32 value)
END_CLASS

CLASS: UnityEngine.UIElements.VisualElement
TYPE:  class
TOKEN: 0x2000077
EXTENDS: Focusable
FIELDS:
  private           System.Int32                    <UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField  // 0x30
  private           System.Int32                    <UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField  // 0x34
  private   static  System.UInt32                   s_NextId  // 0x0
  private   static  System.Collections.Generic.List<System.String>s_EmptyClassList  // 0x8
  private   static readonly UnityEngine.PropertyName        userDataPropertyKey  // 0x10
  public    static readonly System.String                   disabledUssClassName  // 0x18
  private           System.String                   m_Name  // 0x38
  private           System.Collections.Generic.List<System.String>m_ClassList  // 0x40
  private           System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.PropertyName,System.Object>>m_PropertyBag  // 0x48
  private           UnityEngine.UIElements.VisualElementFlagsm_Flags  // 0x50
  private           System.String                   m_ViewDataKey  // 0x58
  private           UnityEngine.UIElements.RenderHintsm_RenderHints  // 0x60
  private           UnityEngine.Rect                lastLayout  // 0x64
  private           UnityEngine.Rect                lastPseudoPadding  // 0x74
  private           UnityEngine.UIElements.UIR.RenderChainVEDatarenderChainData  // 0x88
  private           UnityEngine.Rect                m_Layout  // 0x1E0
  private           UnityEngine.Rect                m_BoundingBox  // 0x1F0
  private           UnityEngine.Rect                m_WorldBoundingBox  // 0x200
  private           UnityEngine.Matrix4x4           m_WorldTransformCache  // 0x210
  private           UnityEngine.Matrix4x4           m_WorldTransformInverseCache  // 0x250
  private           UnityEngine.Rect                m_WorldClip  // 0x290
  private           UnityEngine.Rect                m_WorldClipMinusGroup  // 0x2A0
  private           System.Boolean                  m_WorldClipIsInfinite  // 0x2B0
  private   static readonly UnityEngine.Rect                s_InfiniteRect  // 0x20
  private           UnityEngine.UIElements.PseudoStatestriggerPseudoMask  // 0x2B4
  private           UnityEngine.UIElements.PseudoStatesdependencyPseudoMask  // 0x2B8
  private           UnityEngine.UIElements.PseudoStatesm_PseudoStates  // 0x2BC
  private           System.Int32                    <containedPointerIds>k__BackingField  // 0x2C0
  private           UnityEngine.UIElements.PickingMode<pickingMode>k__BackingField  // 0x2C4
  private           UnityEngine.Yoga.YogaNode       <yogaNode>k__BackingField  // 0x2C8
  private           UnityEngine.UIElements.ComputedStylem_Style  // 0x2D0
  private           UnityEngine.UIElements.StyleVariableContextvariableContext  // 0x328
  private           System.Int32                    inheritedStylesHash  // 0x330
  private   readonly System.UInt32                   controlid  // 0x334
  private           System.Int32                    imguiContainerDescendantCount  // 0x338
  private           System.Boolean                  <enabledSelf>k__BackingField  // 0x33C
  private           UnityEngine.UIElements.LanguageDirectionm_LanguageDirection  // 0x340
  private           UnityEngine.UIElements.LanguageDirectionm_LocalLanguageDirection  // 0x344
  private           System.Action<UnityEngine.UIElements.MeshGenerationContext><generateVisualContent>k__BackingField  // 0x348
  private           Unity.Profiling.ProfilerMarker  k_GenerateVisualContentMarker  // 0x350
  private           UnityEngine.UIElements.VisualElement.RenderTargetModem_SubRenderTargetMode  // 0x358
  private   static  UnityEngine.Material            s_runtimeMaterial  // 0x30
  private           UnityEngine.Material            m_defaultMaterial  // 0x360
  private           System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate>m_RunningAnimations  // 0x368
  private   static  System.String                   k_RootVisualContainerName  // 0x0
  private           UnityEngine.UIElements.VisualElement.Hierarchy<hierarchy>k__BackingField  // 0x370
  private           System.Boolean                  <isRootVisualContainer>k__BackingField  // 0x378
  private           System.Boolean                  <cacheAsBitmap>k__BackingField  // 0x379
  private           UnityEngine.UIElements.VisualElementm_PhysicalParent  // 0x380
  private           UnityEngine.UIElements.VisualElementm_LogicalParent  // 0x388
  private   static readonly System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>s_EmptyList  // 0x38
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>m_Children  // 0x390
  private           UnityEngine.UIElements.BaseVisualElementPanel<elementPanel>k__BackingField  // 0x398
  private           UnityEngine.UIElements.VisualTreeAssetm_VisualTreeAssetSource  // 0x3A0
  private   static  UnityEngine.UIElements.VisualElement.CustomStyleAccesss_CustomStyleAccess  // 0x40
  private           UnityEngine.UIElements.InlineStyleAccessinlineStyleAccess  // 0x3A8
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet>styleSheetList  // 0x3B0
  private   static readonly System.Text.RegularExpressions.Regexs_InternalStyleSheetPath  // 0x48
  private   static readonly UnityEngine.PropertyName        tooltipPropertyKey  // 0x50
  private   static readonly System.Collections.Generic.Dictionary<System.Type,UnityEngine.UIElements.VisualElement.TypeData>s_TypeData  // 0x58
  private           UnityEngine.UIElements.VisualElement.TypeDatam_TypeData  // 0x3B8
METHODS:
  System.Boolean get_hasRunningAnimations()
  System.Boolean get_hasCompletedAnimations()
  System.Int32 UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount()
  System.Void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(System.Int32 value)
  System.Int32 UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount()
  System.Void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(System.Int32 value)
  UnityEngine.UIElements.IStylePropertyAnimationSystem GetStylePropertyAnimationSystem()
  UnityEngine.UIElements.IStylePropertyAnimations get_styleAnimation()
  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Single from, System.Single to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 from, System.Int32 to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length from, UnityEngine.UIElements.Length to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color from, UnityEngine.Color to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 from, System.Int32 to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Background from, UnityEngine.UIElements.Background to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.FontDefinition from, UnityEngine.UIElements.FontDefinition to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Font from, UnityEngine.Font to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TextShadow from, UnityEngine.UIElements.TextShadow to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Scale from, UnityEngine.UIElements.Scale to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Translate from, UnityEngine.UIElements.Translate to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Rotate from, UnityEngine.UIElements.Rotate to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TransformOrigin from, UnityEngine.UIElements.TransformOrigin to, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations()
  System.Void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds)
  System.Boolean TryConvertLengthUnits(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length& from, UnityEngine.UIElements.Length& to, System.Int32 subPropertyIndex)
  System.Boolean TryConvertTransformOriginUnits(UnityEngine.UIElements.TransformOrigin& from, UnityEngine.UIElements.TransformOrigin& to)
  System.Boolean TryConvertTranslateUnits(UnityEngine.UIElements.Translate& from, UnityEngine.UIElements.Translate& to)
  System.Nullable<System.Single> GetParentSizeForLengthConversion(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 subPropertyIndex)
  System.Boolean get_isCompositeRoot()
  System.Void set_isCompositeRoot(System.Boolean value)
  System.Boolean get_isHierarchyDisplayed()
  System.Void set_isHierarchyDisplayed(System.Boolean value)
  System.String get_viewDataKey()
  System.Void set_viewDataKey(System.String value)
  System.Boolean get_enableViewDataPersistence()
  System.Void set_enableViewDataPersistence(System.Boolean value)
  System.Object get_userData()
  System.Void set_userData(System.Object value)
  System.Boolean get_canGrabFocus()
  UnityEngine.UIElements.FocusController get_focusController()
  UnityEngine.UIElements.UsageHints get_usageHints()
  System.Void set_usageHints(UnityEngine.UIElements.UsageHints value)
  UnityEngine.UIElements.RenderHints get_renderHints()
  System.Void set_renderHints(UnityEngine.UIElements.RenderHints value)
  System.Void MarkRenderHintsClean()
  UnityEngine.UIElements.ITransform get_transform()
  UnityEngine.Vector3 UnityEngine.UIElements.ITransform.get_position()
  System.Void UnityEngine.UIElements.ITransform.set_position(UnityEngine.Vector3 value)
  UnityEngine.Vector3 UnityEngine.UIElements.ITransform.get_scale()
  System.Boolean get_isLayoutManual()
  System.Void set_isLayoutManual(System.Boolean value)
  System.Single get_scaledPixelsPerPoint()
  UnityEngine.Rect get_layout()
  System.Void set_layout(UnityEngine.Rect value)
  System.Void ClearManualLayout()
  UnityEngine.Rect get_contentRect()
  UnityEngine.Rect get_paddingRect()
  System.Boolean get_isBoundingBoxDirty()
  System.Void set_isBoundingBoxDirty(System.Boolean value)
  System.Boolean get_isWorldBoundingBoxDirty()
  System.Void set_isWorldBoundingBoxDirty(System.Boolean value)
  UnityEngine.Rect get_boundingBox()
  UnityEngine.Rect get_worldBoundingBox()
  UnityEngine.Rect get_boundingBoxInParentSpace()
  System.Void UpdateBoundingBox()
  System.Void UpdateWorldBoundingBox()
  UnityEngine.Rect get_worldBound()
  UnityEngine.Rect get_localBound()
  UnityEngine.Rect get_rect()
  System.Boolean get_isWorldTransformDirty()
  System.Void set_isWorldTransformDirty(System.Boolean value)
  System.Boolean get_isWorldTransformInverseDirty()
  System.Void set_isWorldTransformInverseDirty(System.Boolean value)
  UnityEngine.Matrix4x4 get_worldTransform()
  UnityEngine.Matrix4x4& get_worldTransformRef()
  UnityEngine.Matrix4x4& get_worldTransformInverse()
  System.Void UpdateWorldTransform()
  System.Void UpdateWorldTransformInverse()
  System.Boolean get_isWorldClipDirty()
  System.Void set_isWorldClipDirty(System.Boolean value)
  UnityEngine.Rect get_worldClip()
  UnityEngine.Rect get_worldClipMinusGroup()
  System.Boolean get_worldClipIsInfinite()
  System.Void EnsureWorldTransformAndClipUpToDate()
  System.Void UpdateWorldClip()
  UnityEngine.Rect CombineClipRects(UnityEngine.Rect rect, UnityEngine.Rect parentRect)
  UnityEngine.Rect SubstractBorderPadding(UnityEngine.Rect worldRect)
  UnityEngine.Rect ComputeAAAlignedBound(UnityEngine.Rect position, UnityEngine.Matrix4x4 mat)
  UnityEngine.UIElements.PseudoStates get_pseudoStates()
  System.Void set_pseudoStates(UnityEngine.UIElements.PseudoStates value)
  System.Int32 get_containedPointerIds()
  System.Void set_containedPointerIds(System.Int32 value)
  System.Void UpdateHoverPseudoState()
  UnityEngine.UIElements.PickingMode get_pickingMode()
  System.Void set_pickingMode(UnityEngine.UIElements.PickingMode value)
  System.String get_name()
  System.Void set_name(System.String value)
  System.Collections.Generic.List<System.String> get_classList()
  System.String get_fullTypeName()
  System.String get_typeName()
  UnityEngine.Yoga.YogaNode get_yogaNode()
  System.Void set_yogaNode(UnityEngine.Yoga.YogaNode value)
  UnityEngine.UIElements.ComputedStyle& get_computedStyle()
  System.Boolean get_hasInlineStyle()
  System.Boolean get_styleInitialized()
  System.Void set_styleInitialized(System.Boolean value)
  System.Void ChangeIMGUIContainerCount(System.Int32 delta)
  System.Void .ctor()
  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  UnityEngine.Rect GetTooltipRect()
  System.Void SetTooltip(UnityEngine.UIElements.TooltipEvent e)
  System.Void Focus()
  System.Void SetPanel(UnityEngine.UIElements.BaseVisualElementPanel p)
  System.Void WillChangePanel(UnityEngine.UIElements.BaseVisualElementPanel destinationPanel)
  System.Void HasChangedPanel(UnityEngine.UIElements.BaseVisualElementPanel prevPanel)
  System.Void SendEvent(UnityEngine.UIElements.EventBase e)
  System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.UIElements.DispatchMode dispatchMode)
  System.Void IncrementVersion(UnityEngine.UIElements.VersionChangeType changeType)
  System.Void InvokeHierarchyChanged(UnityEngine.UIElements.HierarchyChangeType changeType)
  System.Boolean SetEnabledFromHierarchyPrivate(System.Boolean state)
  System.Boolean get_isParentEnabledInHierarchy()
  System.Boolean get_enabledInHierarchy()
  System.Boolean get_enabledSelf()
  System.Void set_enabledSelf(System.Boolean value)
  System.Void SetEnabled(System.Boolean value)
  System.Void PropagateEnabledToChildren(System.Boolean value)
  System.Boolean get_visible()
  System.Void set_visible(System.Boolean value)
  System.Void MarkDirtyRepaint()
  System.Action<UnityEngine.UIElements.MeshGenerationContext> get_generateVisualContent()
  System.Void set_generateVisualContent(System.Action<UnityEngine.UIElements.MeshGenerationContext> value)
  System.Void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc)
  System.Void GetFullHierarchicalViewDataKey(System.Text.StringBuilder key)
  System.String GetFullHierarchicalViewDataKey()
  T GetOrCreateViewData(System.Object existing, System.String key)
  System.Void OverwriteFromViewData(System.Object obj, System.String key)
  System.Void SaveViewData()
  System.Boolean IsViewDataPersitenceSupportedOnChildren(System.Boolean existingState)
  System.Void OnViewDataReady(System.Boolean enablePersistence)
  System.Void OnViewDataReady()
  System.Boolean ContainsPoint(UnityEngine.Vector2 localPoint)
  System.Boolean get_requireMeasureFunction()
  System.Void set_requireMeasureFunction(System.Boolean value)
  System.Void AssignMeasureFunction()
  System.Void RemoveMeasureFunction()
  UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode)
  UnityEngine.Yoga.YogaSize Measure(UnityEngine.Yoga.YogaNode node, System.Single width, UnityEngine.Yoga.YogaMeasureMode widthMode, System.Single height, UnityEngine.Yoga.YogaMeasureMode heightMode)
  System.Void FinalizeLayout()
  System.Void SetInlineRule(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleRule rule)
  System.Void SetComputedStyle(UnityEngine.UIElements.ComputedStyle& newStyle)
  System.String ToString()
  System.Collections.Generic.List<System.String> GetClassesForIteration()
  System.Void AddToClassList(System.String className)
  System.Void RemoveFromClassList(System.String className)
  System.Void EnableInClassList(System.String className, System.Boolean enable)
  System.Boolean ClassListContains(System.String cls)
  System.Object GetProperty(UnityEngine.PropertyName key)
  System.Void SetProperty(UnityEngine.PropertyName key, System.Object value)
  System.Boolean HasProperty(UnityEngine.PropertyName key)
  System.Boolean TryGetPropertyInternal(UnityEngine.PropertyName key, System.Object& value)
  System.Void CheckUserKeyArgument(UnityEngine.PropertyName key)
  System.Void SetPropertyInternal(UnityEngine.PropertyName key, System.Object value)
  System.Void UpdateCursorStyle(System.Int64 eventType)
  UnityEngine.UIElements.VisualElement.RenderTargetMode get_subRenderTargetMode()
  UnityEngine.Material get_defaultMaterial()
  UnityEngine.UIElements.VisualElementAnimationSystem GetAnimationSystem()
  System.Void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
  System.Void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
  System.Void UnregisterRunningAnimations()
  System.Void RegisterRunningAnimations()
  UnityEngine.UIElements.Experimental.ValueAnimation<T> StartAnimation(UnityEngine.UIElements.Experimental.ValueAnimation<T> anim, System.Func<UnityEngine.UIElements.VisualElement,T> fromValueGetter, T to, System.Int32 durationMs, System.Action<UnityEngine.UIElements.VisualElement,T> onValueChanged)
  System.Void AssignStyleValues(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.Experimental.StyleValues src)
  UnityEngine.UIElements.Experimental.StyleValues ReadCurrentValues(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.Experimental.StyleValues targetValuesToRead)
  UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.UIElements.Experimental.StyleValues to, System.Int32 durationMs)
  UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(System.Func<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.Experimental.StyleValues> fromValueGetter, UnityEngine.UIElements.Experimental.StyleValues to, System.Int32 durationMs)
  UnityEngine.UIElements.IExperimentalFeatures get_experimental()
  UnityEngine.UIElements.Experimental.ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.get_animation()
  UnityEngine.UIElements.VisualElement.Hierarchy get_hierarchy()
  System.Void set_hierarchy(UnityEngine.UIElements.VisualElement.Hierarchy value)
  System.Boolean get_isRootVisualContainer()
  System.Void set_isRootVisualContainer(System.Boolean value)
  System.Boolean get_disableClipping()
  System.Void set_disableClipping(System.Boolean value)
  System.Boolean ShouldClip()
  UnityEngine.UIElements.VisualElement get_parent()
  UnityEngine.UIElements.BaseVisualElementPanel get_elementPanel()
  System.Void set_elementPanel(UnityEngine.UIElements.BaseVisualElementPanel value)
  UnityEngine.UIElements.IPanel get_panel()
  UnityEngine.UIElements.VisualElement get_contentContainer()
  System.Void set_visualTreeAssetSource(UnityEngine.UIElements.VisualTreeAsset value)
  System.Void Add(UnityEngine.UIElements.VisualElement child)
  System.Void Insert(System.Int32 index, UnityEngine.UIElements.VisualElement element)
  System.Void Clear()
  UnityEngine.UIElements.VisualElement ElementAt(System.Int32 index)
  UnityEngine.UIElements.VisualElement get_Item(System.Int32 key)
  System.Int32 get_childCount()
  System.Int32 IndexOf(UnityEngine.UIElements.VisualElement element)
  UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List<System.Int32> childIndexes)
  System.Boolean FindElementInTree(UnityEngine.UIElements.VisualElement element, System.Collections.Generic.List<System.Int32> outChildIndexes)
  System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children()
  System.Void BringToFront()
  System.Void SendToBack()
  System.Void PlaceBehind(UnityEngine.UIElements.VisualElement sibling)
  System.Void RemoveFromHierarchy()
  T GetFirstOfType()
  T GetFirstAncestorOfType()
  System.Boolean Contains(UnityEngine.UIElements.VisualElement child)
  System.Void GatherAllChildren(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements)
  UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement other)
  UnityEngine.UIElements.VisualElement GetRoot()
  UnityEngine.UIElements.VisualElement GetRootVisualContainer()
  UnityEngine.UIElements.VisualElement GetNextElementDepthFirst()
  UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst()
  UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement retargetAgainst)
  UnityEngine.Vector3 get_positionWithLayout()
  System.Void GetPivotedMatrixWithLayout(UnityEngine.Matrix4x4& result)
  System.Boolean get_hasDefaultRotationAndScale()
  System.Single Min(System.Single a, System.Single b, System.Single c, System.Single d)
  System.Single Max(System.Single a, System.Single b, System.Single c, System.Single d)
  System.Void TransformAlignedRectToParentSpace(UnityEngine.Rect& rect)
  UnityEngine.Rect CalculateConservativeRect(UnityEngine.Matrix4x4& matrix, UnityEngine.Rect rect)
  System.Void TransformAlignedRect(UnityEngine.Matrix4x4& matrix, UnityEngine.Rect& rect)
  System.Void OrderMinMaxRect(UnityEngine.Rect& rect)
  UnityEngine.Vector2 MultiplyMatrix44Point2(UnityEngine.Matrix4x4& lhs, UnityEngine.Vector2 point)
  UnityEngine.Vector2 MultiplyVector2(UnityEngine.Matrix4x4& lhs, UnityEngine.Vector2 vector)
  System.Void MultiplyMatrix34(UnityEngine.Matrix4x4& lhs, UnityEngine.Matrix4x4& rhs, UnityEngine.Matrix4x4& res)
  System.Void TranslateMatrix34(UnityEngine.Matrix4x4& lhs, UnityEngine.Vector3 rhs, UnityEngine.Matrix4x4& res)
  System.Void TranslateMatrix34InPlace(UnityEngine.Matrix4x4& lhs, UnityEngine.Vector3 rhs)
  UnityEngine.UIElements.IVisualElementScheduler get_schedule()
  UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action<UnityEngine.UIElements.TimerState> timerUpdateEvent)
  UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action updateEvent)
  UnityEngine.UIElements.IStyle get_style()
  UnityEngine.UIElements.ICustomStyle get_customStyle()
  UnityEngine.UIElements.VisualElementStyleSheetSet get_styleSheets()
  System.Void AddStyleSheetPath(System.String sheetPath)
  UnityEngine.UIElements.StyleFloat ResolveLengthValue(UnityEngine.UIElements.Length length, System.Boolean isRow)
  UnityEngine.Vector3 ResolveTranslate()
  UnityEngine.Vector3 ResolveTransformOrigin()
  UnityEngine.Quaternion ResolveRotation()
  UnityEngine.Vector3 ResolveScale()
  System.String get_tooltip()
  System.Void set_tooltip(System.String value)
  UnityEngine.UIElements.VisualElement.TypeData get_typeData()
  UnityEngine.UIElements.IResolvedStyle get_resolvedStyle()
  UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_backgroundColor()
  UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth()
  UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth()
  UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_borderRightColor()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth()
  UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_borderTopColor()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_bottom()
  UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_color()
  UnityEngine.UIElements.DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display()
  UnityEngine.UIElements.FlexDirection UnityEngine.UIElements.IResolvedStyle.get_flexDirection()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_flexGrow()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_flexShrink()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_height()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_left()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_marginBottom()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_marginLeft()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_marginRight()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_marginTop()
  UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minHeight()
  UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minWidth()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_opacity()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_paddingBottom()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_paddingLeft()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_paddingRight()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_paddingTop()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_right()
  UnityEngine.UIElements.Scale UnityEngine.UIElements.IResolvedStyle.get_scale()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_top()
  UnityEngine.Vector3 UnityEngine.UIElements.IResolvedStyle.get_transformOrigin()
  UnityEngine.Vector3 UnityEngine.UIElements.IResolvedStyle.get_translate()
  UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor()
  System.Int32 UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft()
  System.Int32 UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight()
  UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth()
  UnityEngine.UIElements.Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility()
  UnityEngine.UIElements.WhiteSpace UnityEngine.UIElements.IResolvedStyle.get_whiteSpace()
  System.Single UnityEngine.UIElements.IResolvedStyle.get_width()
  System.Void .cctor()
  UnityEngine.Yoga.YogaSize <AssignMeasureFunction>b__262_0(UnityEngine.Yoga.YogaNode node, System.Single f, UnityEngine.Yoga.YogaMeasureMode mode, System.Single f1, UnityEngine.Yoga.YogaMeasureMode heightMode)
END_CLASS

CLASS: UnityEngine.UIElements.IStylePropertyAnimationSystem
TYPE:  interface
TOKEN: 0x2000084
FIELDS:
METHODS:
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, System.Single startValue, System.Single endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, System.Int32 startValue, System.Int32 endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Length startValue, UnityEngine.UIElements.Length endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Color startValue, UnityEngine.Color endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Background startValue, UnityEngine.UIElements.Background endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.FontDefinition startValue, UnityEngine.UIElements.FontDefinition endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Font startValue, UnityEngine.Font endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TextShadow startValue, UnityEngine.UIElements.TextShadow endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Scale startValue, UnityEngine.UIElements.Scale endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TransformOrigin startValue, UnityEngine.UIElements.TransformOrigin endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Translate startValue, UnityEngine.UIElements.Translate endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Rotate startValue, UnityEngine.UIElements.Rotate endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Void CancelAllAnimations()
  System.Void CancelAllAnimations(UnityEngine.UIElements.VisualElement owner)
  System.Void CancelAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Void UpdateAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Void GetAllAnimations(UnityEngine.UIElements.VisualElement owner, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds)
  System.Void Update()
END_CLASS

CLASS: UnityEngine.UIElements.StylePropertyAnimationSystem
TYPE:  class
TOKEN: 0x2000085
FIELDS:
  private           System.Int64                    m_CurrentTimeMs  // 0x10
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesFloatm_Floats  // 0x18
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesIntm_Ints  // 0x20
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesLengthm_Lengths  // 0x28
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesColorm_Colors  // 0x30
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesBackgroundm_Backgrounds  // 0x38
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesFontDefinitionm_FontDefinitions  // 0x40
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesFontm_Fonts  // 0x48
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesTextShadowm_TextShadows  // 0x50
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesScalem_Scale  // 0x58
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesRotatem_Rotate  // 0x60
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesTranslatem_Translate  // 0x68
  private           UnityEngine.UIElements.StylePropertyAnimationSystem.ValuesTransformOriginm_TransformOrigin  // 0x70
  private   readonly System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyAnimationSystem.Values>m_AllValues  // 0x78
  private   readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StylePropertyId,UnityEngine.UIElements.StylePropertyAnimationSystem.Values>m_PropertyToValues  // 0x80
METHODS:
  System.Void .ctor()
  T GetOrCreate(T& values)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, T startValue, T endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve, UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T> values)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, System.Single startValue, System.Single endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, System.Int32 startValue, System.Int32 endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Length startValue, UnityEngine.UIElements.Length endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Color startValue, UnityEngine.Color endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Background startValue, UnityEngine.UIElements.Background endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.FontDefinition startValue, UnityEngine.UIElements.FontDefinition endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.Font startValue, UnityEngine.Font endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TextShadow startValue, UnityEngine.UIElements.TextShadow endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Scale startValue, UnityEngine.UIElements.Scale endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Rotate startValue, UnityEngine.UIElements.Rotate endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.Translate startValue, UnityEngine.UIElements.Translate endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartTransition(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId prop, UnityEngine.UIElements.TransformOrigin startValue, UnityEngine.UIElements.TransformOrigin endValue, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Void CancelAllAnimations()
  System.Void CancelAllAnimations(UnityEngine.UIElements.VisualElement owner)
  System.Void CancelAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Void UpdateAnimation(UnityEngine.UIElements.VisualElement owner, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Void GetAllAnimations(UnityEngine.UIElements.VisualElement owner, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds)
  System.Void UpdateTracking(UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T> values)
  System.Int64 CurrentTimeMs()
  System.Void Update()
END_CLASS

CLASS: UnityEngine.UIElements.StylePropertyName
TYPE:  struct
TOKEN: 0x200009E
FIELDS:
  private   readonly UnityEngine.UIElements.StyleSheets.StylePropertyId<id>k__BackingField  // 0x10
  private   readonly System.String                   <name>k__BackingField  // 0x18
METHODS:
  UnityEngine.UIElements.StyleSheets.StylePropertyId get_id()
  System.String get_name()
  UnityEngine.UIElements.StyleSheets.StylePropertyId StylePropertyIdFromString(System.String name)
  System.Void .ctor(UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId)
  System.Void .ctor(System.String name)
  System.Boolean op_Equality(UnityEngine.UIElements.StylePropertyName lhs, UnityEngine.UIElements.StylePropertyName rhs)
  System.Boolean op_Inequality(UnityEngine.UIElements.StylePropertyName lhs, UnityEngine.UIElements.StylePropertyName rhs)
  UnityEngine.UIElements.StylePropertyName op_Implicit(System.String name)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object other)
  System.Boolean Equals(UnityEngine.UIElements.StylePropertyName other)
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.TemplateContainer
TYPE:  class
TOKEN: 0x200009F
EXTENDS: BindableElement
FIELDS:
  private           System.String                   <templateId>k__BackingField  // 0x3D0
  private           UnityEngine.UIElements.VisualElementm_ContentContainer  // 0x3D8
  private           UnityEngine.UIElements.VisualTreeAssetm_TemplateSource  // 0x3E0
METHODS:
  System.String get_templateId()
  System.Void set_templateId(System.String value)
  System.Void set_templateSource(UnityEngine.UIElements.VisualTreeAsset value)
  System.Void .ctor()
  System.Void .ctor(System.String templateId)
  UnityEngine.UIElements.VisualElement get_contentContainer()
  System.Void SetContentContainer(UnityEngine.UIElements.VisualElement content)
END_CLASS

CLASS: UnityEngine.UIElements.ITextElement
TYPE:  interface
TOKEN: 0x20000A2
FIELDS:
METHODS:
  System.String get_text()
END_CLASS

CLASS: UnityEngine.UIElements.TextElement
TYPE:  class
TOKEN: 0x20000A3
EXTENDS: BindableElement
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  private           UnityEngine.UIElements.ITextHandlem_TextHandle  // 0x3D0
  private   static  System.Int32                    maxTextVertices  // 0x8
  private           System.String                   m_Text  // 0x3D8
  private           System.Boolean                  m_EnableRichText  // 0x3E0
  private           System.Boolean                  m_DisplayTooltipWhenElided  // 0x3E1
  private           System.Boolean                  <isElided>k__BackingField  // 0x3E2
  private   static readonly System.String                   k_EllipsisText  // 0x10
  private           System.Boolean                  m_WasElided  // 0x3E3
  private           System.Boolean                  m_UpdateTextParams  // 0x3E4
  private           UnityEngine.UIElements.MeshGenerationContextUtils.TextParamsm_TextParams  // 0x3E8
  private           System.Int32                    m_PreviousTextParamsHashCode  // 0x480
METHODS:
  System.Void .ctor()
  UnityEngine.UIElements.ITextHandle get_textHandle()
  System.Void set_textHandle(UnityEngine.UIElements.ITextHandle value)
  System.Void HandleEvent(UnityEngine.UIElements.EventBase evt)
  System.Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e)
  System.String get_text()
  System.Void set_text(System.String value)
  System.Boolean get_enableRichText()
  System.Void set_enableRichText(System.Boolean value)
  System.Boolean get_displayTooltipWhenElided()
  System.Void set_displayTooltipWhenElided(System.Boolean value)
  System.Boolean get_isElided()
  System.Void set_isElided(System.Boolean value)
  System.Void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc)
  System.String ElideText(System.String drawText, System.String ellipsisText, System.Single width, UnityEngine.UIElements.TextOverflowPosition textOverflowPosition)
  System.Void UpdateTooltip()
  System.Void UpdateVisibleText()
  System.Boolean ShouldElide()
  System.Boolean TextLibraryCanElide()
  UnityEngine.Vector2 MeasureTextSize(System.String textToMeasure, System.Single width, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single height, UnityEngine.UIElements.VisualElement.MeasureMode heightMode)
  UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode)
  System.String UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value()
  System.Void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(System.String value)
  System.Void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(System.String newValue)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.TextShadow
TYPE:  struct
TOKEN: 0x20000A6
FIELDS:
  public            UnityEngine.Vector2             offset  // 0x10
  public            System.Single                   blurRadius  // 0x18
  public            UnityEngine.Color               color  // 0x1C
METHODS:
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.UIElements.TextShadow other)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.UIElements.TextShadow style1, UnityEngine.UIElements.TextShadow style2)
  System.Boolean op_Inequality(UnityEngine.UIElements.TextShadow style1, UnityEngine.UIElements.TextShadow style2)
  System.String ToString()
  UnityEngine.UIElements.TextShadow LerpUnclamped(UnityEngine.UIElements.TextShadow a, UnityEngine.UIElements.TextShadow b, System.Single t)
END_CLASS

CLASS: UnityEngine.UIElements.UIElementsPackageUtility
TYPE:  class
TOKEN: 0x20000A7
FIELDS:
  private   static readonly System.String                   EditorResourcesBasePath  // 0x0
  private   static readonly System.Boolean                  IsUIEPackageLoaded  // 0x8
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIElementsRuntimeUtility
TYPE:  class
TOKEN: 0x20000A8
FIELDS:
  private   static  System.Action<UnityEngine.UIElements.BaseRuntimePanel>onCreatePanel  // 0x0
  private   static  System.Boolean                  s_RegisteredPlayerloopCallback  // 0x8
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.Panel>s_SortedRuntimePanels  // 0x10
  private   static  System.Boolean                  s_PanelOrderingDirty  // 0x18
  private   static readonly System.String                   s_RepaintProfilerMarkerName  // 0x20
  private   static readonly Unity.Profiling.ProfilerMarker  s_RepaintProfilerMarker  // 0x28
  private   static  System.Int32                    currentOverlayIndex  // 0x30
  private   static  UnityEngine.Object              <activeEventSystem>k__BackingField  // 0x38
  private   static  UnityEngine.UIElements.DefaultEventSystems_DefaultEventSystem  // 0x40
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.PanelSettings>s_PotentiallyEmptyPanelSettings  // 0x48
METHODS:
  System.Void add_onCreatePanel(System.Action<UnityEngine.UIElements.BaseRuntimePanel> value)
  System.Void remove_onCreatePanel(System.Action<UnityEngine.UIElements.BaseRuntimePanel> value)
  System.Void .cctor()
  UnityEngine.UIElements.EventBase CreateEvent(UnityEngine.Event systemEvent)
  UnityEngine.UIElements.BaseRuntimePanel FindOrCreateRuntimePanel(UnityEngine.ScriptableObject ownerObject, UnityEngine.UIElements.UIElementsRuntimeUtility.CreateRuntimePanelDelegate createDelegate)
  System.Void DisposeRuntimePanel(UnityEngine.ScriptableObject ownerObject)
  System.Void RegisterCachedPanelInternal(System.Int32 instanceID, UnityEngine.UIElements.IPanel panel)
  System.Void RemoveCachedPanelInternal(System.Int32 instanceID)
  System.Void RepaintOffscreenPanels()
  System.Void RepaintOverlayPanel(UnityEngine.UIElements.BaseRuntimePanel panel)
  System.Void BeginRenderOverlays(System.Int32 displayIndex)
  System.Void RenderOverlaysBeforePriority(System.Int32 displayIndex, System.Single maxPriority)
  System.Void EndRenderOverlays(System.Int32 displayIndex)
  UnityEngine.Object get_activeEventSystem()
  System.Void set_activeEventSystem(UnityEngine.Object value)
  System.Boolean get_useDefaultEventSystem()
  System.Void RegisterEventSystem(UnityEngine.Object eventSystem)
  System.Void UnregisterEventSystem(UnityEngine.Object eventSystem)
  UnityEngine.UIElements.DefaultEventSystem get_defaultEventSystem()
  System.Void UpdateRuntimePanels()
  System.Void MarkPotentiallyEmpty(UnityEngine.UIElements.PanelSettings settings)
  System.Void RemoveUnusedPanels()
  System.Void RegisterPlayerloopCallback()
  System.Void UnregisterPlayerloopCallback()
  System.Void SetPanelOrderingDirty()
  System.Collections.Generic.List<UnityEngine.UIElements.Panel> GetSortedPlayerPanels()
  System.Void SortPanels()
  UnityEngine.Vector2 MultiDisplayBottomLeftToPanelPosition(UnityEngine.Vector2 position, System.Nullable<System.Int32>& targetDisplay)
  UnityEngine.Vector2 MultiDisplayToLocalScreenPosition(UnityEngine.Vector2 position, System.Nullable<System.Int32>& targetDisplay)
  UnityEngine.Vector2 ScreenBottomLeftToPanelPosition(UnityEngine.Vector2 position, System.Int32 targetDisplay)
  UnityEngine.Vector2 ScreenBottomLeftToPanelDelta(UnityEngine.Vector2 delta)
END_CLASS

CLASS: UnityEngine.UIElements.IUIElementsUtility
TYPE:  interface
TOKEN: 0x20000AB
FIELDS:
METHODS:
  System.Boolean TakeCapture()
  System.Boolean ReleaseCapture()
  System.Boolean ProcessEvent(System.Int32 instanceID, System.IntPtr nativeEventPtr, System.Boolean& eventHandled)
  System.Boolean CleanupRoots()
  System.Boolean EndContainerGUIFromException(System.Exception exception)
  System.Boolean MakeCurrentIMGUIContainerDirty()
END_CLASS

CLASS: UnityEngine.UIElements.UIEventRegistration
TYPE:  class
TOKEN: 0x20000AC
FIELDS:
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.IUIElementsUtility>s_Utilities  // 0x0
METHODS:
  System.Void .cctor()
  System.Void RegisterUIElementSystem(UnityEngine.UIElements.IUIElementsUtility utility)
  System.Void TakeCapture()
  System.Void ReleaseCapture()
  System.Boolean EndContainerGUIFromException(System.Exception exception)
  System.Boolean ProcessEvent(System.Int32 instanceID, System.IntPtr nativeEventPtr)
  System.Void CleanupRoots()
  System.Void MakeCurrentIMGUIContainerDirty()
END_CLASS

CLASS: UnityEngine.UIElements.UIElementsUtility
TYPE:  class
TOKEN: 0x20000AE
FIELDS:
  private   static  System.Collections.Generic.Stack<UnityEngine.UIElements.IMGUIContainer>s_ContainerStack  // 0x0
  private   static  System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.Panel>s_UIElementsCache  // 0x8
  private   static  UnityEngine.Event               s_EventInstance  // 0x10
  private   static  UnityEngine.Color               editorPlayModeTintColor  // 0x18
  private   static  System.Single                   singleLineHeight  // 0x28
  private   static  UnityEngine.UIElements.UIElementsUtilitys_Instance  // 0x30
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.Panel>s_PanelsIterationList  // 0x38
  private   static readonly System.String                   s_RepaintProfilerMarkerName  // 0x40
  private   static readonly System.String                   s_EventProfilerMarkerName  // 0x48
  private   static readonly Unity.Profiling.ProfilerMarker  s_RepaintProfilerMarker  // 0x50
  private   static readonly Unity.Profiling.ProfilerMarker  s_EventProfilerMarker  // 0x58
METHODS:
  System.Void .ctor()
  System.Boolean UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty()
  System.Boolean UnityEngine.UIElements.IUIElementsUtility.TakeCapture()
  System.Boolean UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture()
  System.Boolean UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(System.Int32 instanceID, System.IntPtr nativeEventPtr, System.Boolean& eventHandled)
  System.Boolean UnityEngine.UIElements.IUIElementsUtility.CleanupRoots()
  System.Boolean UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(System.Exception exception)
  System.Void RegisterCachedPanel(System.Int32 instanceID, UnityEngine.UIElements.Panel panel)
  System.Void RemoveCachedPanel(System.Int32 instanceID)
  System.Boolean TryGetPanel(System.Int32 instanceID, UnityEngine.UIElements.Panel& panel)
  System.Void BeginContainerGUI(UnityEngine.GUILayoutUtility.LayoutCache cache, UnityEngine.Event evt, UnityEngine.UIElements.IMGUIContainer container)
  System.Void EndContainerGUI(UnityEngine.Event evt, UnityEngine.Rect layoutSize)
  UnityEngine.UIElements.EventBase CreateEvent(UnityEngine.Event systemEvent)
  UnityEngine.UIElements.EventBase CreateEvent(UnityEngine.Event systemEvent, UnityEngine.EventType eventType)
  System.Boolean DoDispatch(UnityEngine.UIElements.BaseVisualElementPanel panel)
  System.Void GetAllPanels(System.Collections.Generic.List<UnityEngine.UIElements.Panel> panels, UnityEngine.UIElements.ContextType contextType)
  System.Collections.Generic.Dictionary.Enumerator<System.Int32,UnityEngine.UIElements.Panel> GetPanelsIterator()
  System.Single PixelsPerUnitScaleForElement(UnityEngine.UIElements.VisualElement ve, UnityEngine.Sprite sprite)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.RuleMatcher
TYPE:  struct
TOKEN: 0x20000AF
FIELDS:
  public            UnityEngine.UIElements.StyleSheetsheet  // 0x10
  public            UnityEngine.UIElements.StyleComplexSelectorcomplexSelector  // 0x18
METHODS:
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.UQuery
TYPE:  class
TOKEN: 0x20000B0
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UQueryState`1
TYPE:  struct
TOKEN: 0x20000B7
FIELDS:
  private   static  UnityEngine.UIElements.UQueryState.ActionQueryMatcher<T>s_Action  // 0x0
  private   readonly UnityEngine.UIElements.VisualElementm_Element  // 0x0
  private   readonly System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher>m_Matchers  // 0x0
  private   static readonly UnityEngine.UIElements.UQueryState.ListQueryMatcher<T,T>s_List  // 0x0
  private   static readonly UnityEngine.UIElements.UQueryState.ListQueryMatcher<T,UnityEngine.UIElements.VisualElement>s_EnumerationList  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.UIElements.VisualElement element, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers)
  UnityEngine.UIElements.UQueryState<T> RebuildOn(UnityEngine.UIElements.VisualElement element)
  T Single(UnityEngine.UIElements.UQuery.SingleQueryMatcher matcher)
  T First()
  System.Void ToList(System.Collections.Generic.List<T> results)
  UnityEngine.UIElements.UQueryState.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Boolean Equals(UnityEngine.UIElements.UQueryState<T> other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UQueryBuilder`1
TYPE:  struct
TOKEN: 0x20000BB
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSelector>m_StyleSelectors  // 0x0
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart>m_Parts  // 0x0
  private           UnityEngine.UIElements.VisualElementm_Element  // 0x0
  private           System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher>m_Matchers  // 0x0
  private           UnityEngine.UIElements.StyleSelectorRelationshipm_Relationship  // 0x0
  private           System.Int32                    pseudoStatesMask  // 0x0
  private           System.Int32                    negatedPseudoStatesMask  // 0x0
METHODS:
  System.Collections.Generic.List<UnityEngine.UIElements.StyleSelector> get_styleSelectors()
  System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart> get_parts()
  System.Void .ctor(UnityEngine.UIElements.VisualElement visualElement)
  UnityEngine.UIElements.UQueryBuilder<T> Class(System.String classname)
  UnityEngine.UIElements.UQueryBuilder<T> Name(System.String id)
  UnityEngine.UIElements.UQueryBuilder<T2> OfType(System.String name, System.String className)
  UnityEngine.UIElements.UQueryBuilder<T> SingleBaseType()
  System.Void AddClass(System.String c)
  System.Void AddName(System.String id)
  System.Void AddType()
  UnityEngine.UIElements.UQueryBuilder<T2> AddRelationship(UnityEngine.UIElements.StyleSelectorRelationship relationship)
  System.Void AddPseudoStatesRuleIfNecessasy()
  System.Void FinishSelector()
  System.Boolean CurrentSelectorEmpty()
  System.Void FinishCurrentSelector()
  UnityEngine.UIElements.UQueryState<T> Build()
  System.Void ToList(System.Collections.Generic.List<T> results)
  System.Boolean Equals(UnityEngine.UIElements.UQueryBuilder<T> other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.UQueryExtensions
TYPE:  class
TOKEN: 0x20000BC
FIELDS:
  private   static  UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement>SingleElementEmptyQuery  // 0x0
  private   static  UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement>SingleElementNameQuery  // 0x10
  private   static  UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement>SingleElementClassQuery  // 0x20
  private   static  UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement>SingleElementNameAndClassQuery  // 0x30
  private   static  UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement>SingleElementTypeQuery  // 0x40
  private   static  UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement>SingleElementTypeAndNameQuery  // 0x50
  private   static  UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement>SingleElementTypeAndClassQuery  // 0x60
  private   static  UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement>SingleElementTypeAndNameAndClassQuery  // 0x70
METHODS:
  T Q(UnityEngine.UIElements.VisualElement e, System.String name, System.String className)
  UnityEngine.UIElements.VisualElement Q(UnityEngine.UIElements.VisualElement e, System.String name, System.String className)
  UnityEngine.UIElements.UQueryBuilder<T> Query(UnityEngine.UIElements.VisualElement e, System.String name, System.String className)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.GradientType
TYPE:  struct
TOKEN: 0x20000BD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.GradientTypeLinear  // 0x0
  public    static  UnityEngine.UIElements.GradientTypeRadial  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.AddressMode
TYPE:  struct
TOKEN: 0x20000BE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.AddressModeWrap  // 0x0
  public    static  UnityEngine.UIElements.AddressModeClamp  // 0x0
  public    static  UnityEngine.UIElements.AddressModeMirror  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.VectorImageVertex
TYPE:  struct
TOKEN: 0x20000BF
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Color32             tint  // 0x1C
  public            UnityEngine.Vector2             uv  // 0x20
  public            System.UInt32                   settingIndex  // 0x28
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.GradientSettings
TYPE:  struct
TOKEN: 0x20000C0
FIELDS:
  public            UnityEngine.UIElements.GradientTypegradientType  // 0x10
  public            UnityEngine.UIElements.AddressModeaddressMode  // 0x14
  public            UnityEngine.Vector2             radialFocus  // 0x18
  public            UnityEngine.RectInt             location  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.VectorImage
TYPE:  class
TOKEN: 0x20000C1
EXTENDS: ScriptableObject
FIELDS:
  private           UnityEngine.Texture2D           atlas  // 0x18
  private           UnityEngine.UIElements.VectorImageVertex[]vertices  // 0x20
  private           System.UInt16[]                 indices  // 0x28
  private           UnityEngine.UIElements.GradientSettings[]settings  // 0x30
  private           UnityEngine.Vector2             size  // 0x38
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PseudoStates
TYPE:  struct
TOKEN: 0x20000C2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.PseudoStatesActive  // 0x0
  public    static  UnityEngine.UIElements.PseudoStatesHover  // 0x0
  public    static  UnityEngine.UIElements.PseudoStatesChecked  // 0x0
  public    static  UnityEngine.UIElements.PseudoStatesDisabled  // 0x0
  public    static  UnityEngine.UIElements.PseudoStatesFocus  // 0x0
  public    static  UnityEngine.UIElements.PseudoStatesRoot  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementFlags
TYPE:  struct
TOKEN: 0x20000C3
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.VisualElementFlagsWorldTransformDirty  // 0x0
  public    static  UnityEngine.UIElements.VisualElementFlagsWorldTransformInverseDirty  // 0x0
  public    static  UnityEngine.UIElements.VisualElementFlagsWorldClipDirty  // 0x0
  public    static  UnityEngine.UIElements.VisualElementFlagsBoundingBoxDirty  // 0x0
  public    static  UnityEngine.UIElements.VisualElementFlagsWorldBoundingBoxDirty  // 0x0
  public    static  UnityEngine.UIElements.VisualElementFlagsLayoutManual  // 0x0
  public    static  UnityEngine.UIElements.VisualElementFlagsCompositeRoot  // 0x0
  public    static  UnityEngine.UIElements.VisualElementFlagsRequireMeasureFunction  // 0x0
  public    static  UnityEngine.UIElements.VisualElementFlagsEnableViewDataPersistence  // 0x0
  public    static  UnityEngine.UIElements.VisualElementFlagsDisableClipping  // 0x0
  public    static  UnityEngine.UIElements.VisualElementFlagsNeedsAttachToPanelEvent  // 0x0
  public    static  UnityEngine.UIElements.VisualElementFlagsHierarchyDisplayed  // 0x0
  public    static  UnityEngine.UIElements.VisualElementFlagsStyleInitialized  // 0x0
  public    static  UnityEngine.UIElements.VisualElementFlagsInit  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.PickingMode
TYPE:  struct
TOKEN: 0x20000C4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.PickingModePosition  // 0x0
  public    static  UnityEngine.UIElements.PickingModeIgnore  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.LanguageDirection
TYPE:  struct
TOKEN: 0x20000C5
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.LanguageDirectionInherit  // 0x0
  public    static  UnityEngine.UIElements.LanguageDirectionLTR  // 0x0
  public    static  UnityEngine.UIElements.LanguageDirectionRTL  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementListPool
TYPE:  class
TOKEN: 0x20000C6
FIELDS:
  private   static  UnityEngine.UIElements.ObjectPool<System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>>pool  // 0x0
METHODS:
  System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> Copy(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements)
  System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> Get(System.Int32 initialCapacity)
  System.Void Release(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ObjectListPool`1
TYPE:  class
TOKEN: 0x20000C7
FIELDS:
  private   static  UnityEngine.UIElements.ObjectPool<System.Collections.Generic.List<T>>pool  // 0x0
METHODS:
  System.Collections.Generic.List<T> Get()
  System.Void Release(System.Collections.Generic.List<T> elements)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementExtensions
TYPE:  class
TOKEN: 0x20000C8
FIELDS:
METHODS:
  System.Void StretchToParentSize(UnityEngine.UIElements.VisualElement elem)
  System.Void AddManipulator(UnityEngine.UIElements.VisualElement ele, UnityEngine.UIElements.IManipulator manipulator)
  System.Void RemoveManipulator(UnityEngine.UIElements.VisualElement ele, UnityEngine.UIElements.IManipulator manipulator)
  UnityEngine.Vector2 WorldToLocal(UnityEngine.UIElements.VisualElement ele, UnityEngine.Vector2 p)
  UnityEngine.Vector2 LocalToWorld(UnityEngine.UIElements.VisualElement ele, UnityEngine.Vector2 p)
  UnityEngine.Rect WorldToLocal(UnityEngine.UIElements.VisualElement ele, UnityEngine.Rect r)
  UnityEngine.Vector2 ChangeCoordinatesTo(UnityEngine.UIElements.VisualElement src, UnityEngine.UIElements.VisualElement dest, UnityEngine.Vector2 point)
END_CLASS

CLASS: UnityEngine.UIElements.IExperimentalFeatures
TYPE:  interface
TOKEN: 0x20000C9
FIELDS:
METHODS:
  UnityEngine.UIElements.Experimental.ITransitionAnimations get_animation()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementFocusChangeDirection
TYPE:  class
TOKEN: 0x20000CA
EXTENDS: FocusChangeDirection
FIELDS:
  private   static readonly UnityEngine.UIElements.VisualElementFocusChangeDirections_Left  // 0x0
  private   static readonly UnityEngine.UIElements.VisualElementFocusChangeDirections_Right  // 0x8
METHODS:
  UnityEngine.UIElements.FocusChangeDirection get_left()
  UnityEngine.UIElements.FocusChangeDirection get_right()
  System.Void .ctor(System.Int32 value)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementFocusChangeTarget
TYPE:  class
TOKEN: 0x20000CB
EXTENDS: FocusChangeDirection
FIELDS:
  private   static readonly UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.VisualElementFocusChangeTarget>Pool  // 0x0
  private           UnityEngine.UIElements.Focusable<target>k__BackingField  // 0x18
METHODS:
  UnityEngine.UIElements.VisualElementFocusChangeTarget GetPooled(UnityEngine.UIElements.Focusable target)
  System.Void Dispose()
  System.Void ApplyTo(UnityEngine.UIElements.FocusController focusController, UnityEngine.UIElements.Focusable f)
  System.Void .ctor()
  UnityEngine.UIElements.Focusable get_target()
  System.Void set_target(UnityEngine.UIElements.Focusable value)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementFocusRing
TYPE:  class
TOKEN: 0x20000CC
FIELDS:
  private   readonly UnityEngine.UIElements.VisualElementroot  // 0x10
  private           UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder<defaultFocusOrder>k__BackingField  // 0x18
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord>m_FocusRing  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.UIElements.VisualElement root, UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder dfo)
  UnityEngine.UIElements.FocusController get_focusController()
  UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder get_defaultFocusOrder()
  System.Void set_defaultFocusOrder(UnityEngine.UIElements.VisualElementFocusRing.DefaultFocusOrder value)
  System.Int32 FocusRingAutoIndexSort(UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord a, UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord b)
  System.Int32 FocusRingSort(UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord a, UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord b)
  System.Void DoUpdate()
  System.Void BuildRingForScopeRecursive(UnityEngine.UIElements.VisualElement ve, System.Int32& scopeIndex, System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> scopeList)
  System.Void SortAndFlattenScopeLists(System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> rootScopeList)
  System.Int32 GetFocusableInternalIndex(UnityEngine.UIElements.Focusable f)
  UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.EventBase e)
  UnityEngine.UIElements.FocusChangeDirection GetKeyDownFocusChangeDirection(UnityEngine.UIElements.EventBase e)
  UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.FocusChangeDirection direction)
  UnityEngine.UIElements.Focusable GetNextFocusableInTree(UnityEngine.UIElements.VisualElement currentFocusable)
  UnityEngine.UIElements.Focusable GetPreviousFocusableInTree(UnityEngine.UIElements.VisualElement currentFocusable)
END_CLASS

CLASS: UnityEngine.UIElements.IVisualElementScheduledItem
TYPE:  interface
TOKEN: 0x20000CF
FIELDS:
METHODS:
  System.Boolean get_isActive()
  System.Void Resume()
  System.Void Pause()
  System.Void ExecuteLater(System.Int64 delayMs)
  UnityEngine.UIElements.IVisualElementScheduledItem StartingIn(System.Int64 delayMs)
  UnityEngine.UIElements.IVisualElementScheduledItem Every(System.Int64 intervalMs)
END_CLASS

CLASS: UnityEngine.UIElements.IVisualElementScheduler
TYPE:  interface
TOKEN: 0x20000D0
FIELDS:
METHODS:
  UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action<UnityEngine.UIElements.TimerState> timerUpdateEvent)
  UnityEngine.UIElements.IVisualElementScheduledItem Execute(System.Action updateEvent)
END_CLASS

CLASS: UnityEngine.UIElements.IVisualElementPanelActivatable
TYPE:  interface
TOKEN: 0x20000D1
FIELDS:
METHODS:
  UnityEngine.UIElements.VisualElement get_element()
  System.Boolean CanBeActivated()
  System.Void OnPanelActivate()
  System.Void OnPanelDeactivate()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementPanelActivator
TYPE:  class
TOKEN: 0x20000D2
FIELDS:
  private           UnityEngine.UIElements.IVisualElementPanelActivatablem_Activatable  // 0x10
  private           System.Boolean                  <isActive>k__BackingField  // 0x18
  private           System.Boolean                  <isDetaching>k__BackingField  // 0x19
METHODS:
  System.Boolean get_isActive()
  System.Void set_isActive(System.Boolean value)
  System.Boolean get_isDetaching()
  System.Void set_isDetaching(System.Boolean value)
  System.Void .ctor(UnityEngine.UIElements.IVisualElementPanelActivatable activatable)
  System.Void SetActive(System.Boolean action)
  System.Void SendActivation()
  System.Void SendDeactivation()
  System.Void OnEnter(UnityEngine.UIElements.AttachToPanelEvent evt)
  System.Void OnLeave(UnityEngine.UIElements.DetachFromPanelEvent evt)
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementStyleSheetSet
TYPE:  struct
TOKEN: 0x20000D3
FIELDS:
  private   readonly UnityEngine.UIElements.VisualElementm_Element  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.UIElements.VisualElement element)
  System.Void Add(UnityEngine.UIElements.StyleSheet styleSheet)
  System.Boolean Remove(UnityEngine.UIElements.StyleSheet styleSheet)
  System.Boolean Equals(UnityEngine.UIElements.VisualElementStyleSheetSet other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementUtils
TYPE:  class
TOKEN: 0x20000D4
FIELDS:
  private   static readonly System.Collections.Generic.HashSet<System.String>s_usedNames  // 0x0
  private   static readonly System.Type                     s_FoldoutType  // 0x8
METHODS:
  System.String GetUniqueName(System.String nameBase)
  System.Int32 GetFoldoutDepth(UnityEngine.UIElements.VisualElement element)
  System.Int32 GetListAndFoldoutDepth(UnityEngine.UIElements.VisualElement element)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementAnimationSystem
TYPE:  class
TOKEN: 0x20000D5
EXTENDS: BaseVisualTreeUpdater
FIELDS:
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.Experimental.IValueAnimationUpdate>m_Animations  // 0x20
  private           System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate>m_IterationList  // 0x28
  private           System.Boolean                  m_HasNewAnimations  // 0x30
  private           System.Boolean                  m_IterationListDirty  // 0x31
  private   static readonly System.String                   s_Description  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  s_ProfilerMarker  // 0x8
  private   static readonly System.String                   s_StylePropertyAnimationDescription  // 0x10
  private   static readonly Unity.Profiling.ProfilerMarker  s_StylePropertyAnimationProfilerMarker  // 0x18
  private           System.Int64                    lastUpdate  // 0x38
METHODS:
  Unity.Profiling.ProfilerMarker get_profilerMarker()
  Unity.Profiling.ProfilerMarker get_stylePropertyAnimationProfilerMarker()
  System.Void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
  System.Void UnregisterAnimations(System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims)
  System.Void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
  System.Void RegisterAnimations(System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims)
  System.Void Update()
  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.HierarchyChangeType
TYPE:  struct
TOKEN: 0x20000D6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.HierarchyChangeTypeAdd  // 0x0
  public    static  UnityEngine.UIElements.HierarchyChangeTypeRemove  // 0x0
  public    static  UnityEngine.UIElements.HierarchyChangeTypeMove  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater
TYPE:  class
TOKEN: 0x20000D7
EXTENDS: BaseVisualTreeUpdater
FIELDS:
  private           UnityEngine.UIElements.BaseVisualTreeHierarchyTrackerUpdater.Statem_State  // 0x20
  private           UnityEngine.UIElements.VisualElementm_CurrentChangeElement  // 0x28
  private           UnityEngine.UIElements.VisualElementm_CurrentChangeParent  // 0x30
METHODS:
  System.Void OnHierarchyChange(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType type)
  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  System.Void Update()
  System.Void ProcessNewChange(UnityEngine.UIElements.VisualElement ve)
  System.Void ProcessAddOrMove(UnityEngine.UIElements.VisualElement ve)
  System.Void ProcessRemove(UnityEngine.UIElements.VisualElement ve)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleCache
TYPE:  class
TOKEN: 0x20000D9
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Int64,UnityEngine.UIElements.ComputedStyle>s_ComputedStyleCache  // 0x0
  private   static  System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.StyleVariableContext>s_StyleVariableContextCache  // 0x8
  private   static  System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.ComputedTransitionProperty[]>s_ComputedTransitionsCache  // 0x10
METHODS:
  System.Boolean TryGetValue(System.Int64 hash, UnityEngine.UIElements.ComputedStyle& data)
  System.Void SetValue(System.Int64 hash, UnityEngine.UIElements.ComputedStyle& data)
  System.Boolean TryGetValue(System.Int32 hash, UnityEngine.UIElements.StyleVariableContext& data)
  System.Void SetValue(System.Int32 hash, UnityEngine.UIElements.StyleVariableContext data)
  System.Boolean TryGetValue(System.Int32 hash, UnityEngine.UIElements.ComputedTransitionProperty[]& data)
  System.Void SetValue(System.Int32 hash, UnityEngine.UIElements.ComputedTransitionProperty[] data)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualTreeStyleUpdater
TYPE:  class
TOKEN: 0x20000DA
EXTENDS: BaseVisualTreeUpdater
FIELDS:
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_ApplyStyleUpdateList  // 0x20
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_TransitionPropertyUpdateList  // 0x28
  private           System.Boolean                  m_IsApplyingStyles  // 0x30
  private           System.UInt32                   m_Version  // 0x34
  private           System.UInt32                   m_LastVersion  // 0x38
  private           UnityEngine.UIElements.VisualTreeStyleUpdaterTraversalm_StyleContextHierarchyTraversal  // 0x40
  private   static readonly System.String                   s_Description  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  s_ProfilerMarker  // 0x8
  private           System.Boolean                  <disposed>k__BackingField  // 0x48
METHODS:
  Unity.Profiling.ProfilerMarker get_profilerMarker()
  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  System.Void Update()
  System.Boolean get_disposed()
  System.Void set_disposed(System.Boolean value)
  System.Void Dispose(System.Boolean disposing)
  System.Void ApplyStyles()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleMatchingContext
TYPE:  class
TOKEN: 0x20000DB
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet>m_StyleSheetStack  // 0x10
  public            UnityEngine.UIElements.StyleVariableContextvariableContext  // 0x18
  public            UnityEngine.UIElements.VisualElementcurrentElement  // 0x20
  public            System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo>processResult  // 0x28
  public            UnityEngine.UIElements.AncestorFilterancestorFilter  // 0x30
METHODS:
  System.Int32 get_styleSheetCount()
  System.Void .ctor(System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult)
  System.Void AddStyleSheet(UnityEngine.UIElements.StyleSheet sheet)
  System.Void RemoveStyleSheetRange(System.Int32 index, System.Int32 count)
  UnityEngine.UIElements.StyleSheet GetStyleSheetAt(System.Int32 index)
END_CLASS

CLASS: UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal
TYPE:  class
TOKEN: 0x20000DC
EXTENDS: HierarchyTraversal
FIELDS:
  private           UnityEngine.UIElements.StyleVariableContextm_ProcessVarContext  // 0x10
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_UpdateList  // 0x18
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_ParentList  // 0x20
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>m_TempMatchResults  // 0x28
  private           System.Single                   <currentPixelsPerPoint>k__BackingField  // 0x30
  private           UnityEngine.UIElements.StyleMatchingContextm_StyleMatchingContext  // 0x38
  private           UnityEngine.UIElements.StyleSheets.StylePropertyReaderm_StylePropertyReader  // 0x40
  private   readonly System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId>m_AnimatedProperties  // 0x48
METHODS:
  System.Single get_currentPixelsPerPoint()
  System.Void set_currentPixelsPerPoint(System.Single value)
  System.Void PrepareTraversal(System.Single pixelsPerPoint)
  System.Void AddChangedElement(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  System.Void Clear()
  System.Void PropagateToChildren(UnityEngine.UIElements.VisualElement ve)
  System.Void PropagateToParents(UnityEngine.UIElements.VisualElement ve)
  System.Void OnProcessMatchResult(UnityEngine.UIElements.VisualElement current, UnityEngine.UIElements.StyleSheets.MatchResultInfo info)
  System.Void TraverseRecursive(UnityEngine.UIElements.VisualElement element, System.Int32 depth)
  System.Void ProcessTransitions(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.ComputedStyle& oldStyle, UnityEngine.UIElements.ComputedStyle& newStyle)
  System.Void ForceUpdateTransitions(UnityEngine.UIElements.VisualElement element)
  System.Void CancelAnimationsWithNoTransitionProperty(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.ComputedStyle& newStyle)
  System.Boolean ShouldSkipElement(UnityEngine.UIElements.VisualElement element)
  UnityEngine.UIElements.ComputedStyle ProcessMatchedRules(UnityEngine.UIElements.VisualElement element, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchingSelectors)
  System.Void ProcessMatchedVariables(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleRule rule)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualTreeTransformClipUpdater
TYPE:  class
TOKEN: 0x20000DE
EXTENDS: BaseVisualTreeUpdater
FIELDS:
  private           System.UInt32                   m_Version  // 0x20
  private           System.UInt32                   m_LastVersion  // 0x24
  private   static readonly System.String                   s_Description  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  s_ProfilerMarker  // 0x8
METHODS:
  Unity.Profiling.ProfilerMarker get_profilerMarker()
  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  System.Void DirtyHierarchy(UnityEngine.UIElements.VisualElement ve, System.Boolean mustDirtyWorldTransform, System.Boolean mustDirtyWorldClip)
  System.Void DirtyBoundingBoxHierarchy(UnityEngine.UIElements.VisualElement ve)
  System.Void Update()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualTreeUpdatePhase
TYPE:  struct
TOKEN: 0x20000DF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.VisualTreeUpdatePhaseViewData  // 0x0
  public    static  UnityEngine.UIElements.VisualTreeUpdatePhaseBindings  // 0x0
  public    static  UnityEngine.UIElements.VisualTreeUpdatePhaseAnimation  // 0x0
  public    static  UnityEngine.UIElements.VisualTreeUpdatePhaseStyles  // 0x0
  public    static  UnityEngine.UIElements.VisualTreeUpdatePhaseLayout  // 0x0
  public    static  UnityEngine.UIElements.VisualTreeUpdatePhaseTransformClip  // 0x0
  public    static  UnityEngine.UIElements.VisualTreeUpdatePhaseRepaint  // 0x0
  public    static  UnityEngine.UIElements.VisualTreeUpdatePhaseCount  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.VisualTreeUpdater
TYPE:  class
TOKEN: 0x20000E0
FIELDS:
  private           UnityEngine.UIElements.BaseVisualElementPanelm_Panel  // 0x10
  private           UnityEngine.UIElements.VisualTreeUpdater.UpdaterArraym_UpdaterArray  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.UIElements.BaseVisualElementPanel panel)
  System.Void Dispose()
  System.Void UpdateVisualTreePhase(UnityEngine.UIElements.VisualTreeUpdatePhase phase)
  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  System.Void SetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase)
  UnityEngine.UIElements.IVisualTreeUpdater GetUpdater(UnityEngine.UIElements.VisualTreeUpdatePhase phase)
  System.Void SetDefaultUpdaters()
END_CLASS

CLASS: UnityEngine.UIElements.IVisualTreeUpdater
TYPE:  interface
TOKEN: 0x20000E2
FIELDS:
METHODS:
  System.Void set_panel(UnityEngine.UIElements.BaseVisualElementPanel value)
  Unity.Profiling.ProfilerMarker get_profilerMarker()
  System.Void Update()
  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
END_CLASS

CLASS: UnityEngine.UIElements.BaseVisualTreeUpdater
TYPE:  class
TOKEN: 0x20000E3
FIELDS:
  private           System.Action<UnityEngine.UIElements.BaseVisualElementPanel>panelChanged  // 0x10
  private           UnityEngine.UIElements.BaseVisualElementPanelm_Panel  // 0x18
METHODS:
  System.Void add_panelChanged(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value)
  System.Void remove_panelChanged(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value)
  UnityEngine.UIElements.BaseVisualElementPanel get_panel()
  System.Void set_panel(UnityEngine.UIElements.BaseVisualElementPanel value)
  UnityEngine.UIElements.VisualElement get_visualTree()
  Unity.Profiling.ProfilerMarker get_profilerMarker()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void Update()
  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualTreeViewDataUpdater
TYPE:  class
TOKEN: 0x20000E4
EXTENDS: BaseVisualTreeUpdater
FIELDS:
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_UpdateList  // 0x20
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_ParentList  // 0x28
  private           System.UInt32                   m_Version  // 0x30
  private           System.UInt32                   m_LastVersion  // 0x34
  private   static readonly System.String                   s_Description  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  s_ProfilerMarker  // 0x8
METHODS:
  Unity.Profiling.ProfilerMarker get_profilerMarker()
  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  System.Void Update()
  System.Void ValidateViewDataOnSubTree(UnityEngine.UIElements.VisualElement ve, System.Boolean enablePersistence)
  System.Void PropagateToParents(UnityEngine.UIElements.VisualElement ve)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.IBindingRequest
TYPE:  interface
TOKEN: 0x20000E5
FIELDS:
METHODS:
  System.Void Bind(UnityEngine.UIElements.VisualElement element)
END_CLASS

CLASS: UnityEngine.UIElements.VisualTreeBindingsUpdater
TYPE:  class
TOKEN: 0x20000E6
EXTENDS: BaseVisualTreeHierarchyTrackerUpdater
FIELDS:
  private   static readonly UnityEngine.PropertyName        s_BindingRequestObjectVEPropertyName  // 0x0
  private   static readonly UnityEngine.PropertyName        s_AdditionalBindingObjectVEPropertyName  // 0x4
  private   static readonly System.String                   s_Description  // 0x8
  private   static readonly Unity.Profiling.ProfilerMarker  s_ProfilerMarker  // 0x10
  private   static readonly Unity.Profiling.ProfilerMarker  s_ProfilerBindingRequestsMarker  // 0x18
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerUpdate  // 0x20
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerPoll  // 0x28
  private   static  System.Boolean                  <disableBindingsThrottling>k__BackingField  // 0x30
  private   readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_ElementsWithBindings  // 0x38
  private   readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_ElementsToAdd  // 0x40
  private   readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_ElementsToRemove  // 0x48
  private           System.Int64                    m_LastUpdateTime  // 0x50
  private           System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement>m_ElementsToBind  // 0x58
  private           System.Collections.Generic.Dictionary<System.Object,System.Object><temporaryObjectCache>k__BackingField  // 0x60
  private           System.Collections.Generic.List<UnityEngine.UIElements.IBinding>updatedBindings  // 0x68
METHODS:
  Unity.Profiling.ProfilerMarker get_profilerMarker()
  UnityEngine.UIElements.IBinding GetBindingObjectFromElement(UnityEngine.UIElements.VisualElement ve)
  System.Void StartTracking(UnityEngine.UIElements.VisualElement ve)
  System.Void StopTracking(UnityEngine.UIElements.VisualElement ve)
  System.Collections.Generic.Dictionary<System.Object,System.Object> get_temporaryObjectCache()
  UnityEngine.UIElements.IBinding GetAdditionalBinding(UnityEngine.UIElements.VisualElement ve)
  System.Void StartTrackingRecursive(UnityEngine.UIElements.VisualElement ve)
  System.Void StopTrackingRecursive(UnityEngine.UIElements.VisualElement ve)
  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  System.Void OnHierarchyChange(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType type)
  System.Int64 CurrentTime()
  System.Void PerformTrackingOperations()
  System.Void Update()
  System.Void UpdateBindings()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.BaseListViewController
TYPE:  class
TOKEN: 0x20000E7
EXTENDS: CollectionViewController
FIELDS:
  private           System.Action                   itemsSourceSizeChanged  // 0x30
  private           System.Action<System.Collections.Generic.IEnumerable<System.Int32>>itemsAdded  // 0x38
  private           System.Action<System.Collections.Generic.IEnumerable<System.Int32>>itemsRemoved  // 0x40
METHODS:
  System.Void add_itemsSourceSizeChanged(System.Action value)
  System.Void remove_itemsSourceSizeChanged(System.Action value)
  System.Void add_itemsAdded(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value)
  System.Void remove_itemsAdded(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value)
  System.Void add_itemsRemoved(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value)
  System.Void remove_itemsRemoved(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value)
  UnityEngine.UIElements.BaseListView get_baseListView()
  System.Void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem)
  System.Void PostInitRegistration(UnityEngine.UIElements.ReusableListViewItem listItem)
  System.Void InvokeBindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, System.Int32 index)
  System.Boolean NeedsDragHandle(System.Int32 index)
  System.Void AddItems(System.Int32 itemCount)
  System.Void Move(System.Int32 index, System.Int32 newIndex)
  System.Void RemoveItem(System.Int32 index)
  System.Void RemoveItems(System.Collections.Generic.List<System.Int32> indices)
  System.Void RemoveItems(System.Int32 itemCount)
  System.Void ClearItems()
  System.Void RaiseOnSizeChanged()
  System.Void RaiseItemsAdded(System.Collections.Generic.IEnumerable<System.Int32> indices)
  System.Void RaiseItemsRemoved(System.Collections.Generic.IEnumerable<System.Int32> indices)
  System.Array AddToArray(System.Array source, System.Int32 itemCount)
  System.Array RemoveFromArray(System.Array source, System.Collections.Generic.List<System.Int32> indicesToRemove)
  System.Void Swap(System.Int32 lhs, System.Int32 rhs)
  System.Void EnsureItemSourceCanBeResized()
  System.Void .ctor()
  System.Boolean <AddItems>g__IsGenericList|15_0(System.Type t)
END_CLASS

CLASS: UnityEngine.UIElements.BaseTreeViewController
TYPE:  class
TOKEN: 0x20000E8
EXTENDS: CollectionViewController
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.TreeItem>m_TreeItems  // 0x30
  private           System.Collections.Generic.List<System.Int32>m_RootIndices  // 0x38
  private           System.Collections.Generic.List<UnityEngine.UIElements.TreeViewItemWrapper>m_ItemWrappers  // 0x40
  private           System.Collections.Generic.HashSet<System.Int32>m_TreeItemIdsWithItemWrappers  // 0x48
  private           System.Collections.Generic.List<UnityEngine.UIElements.TreeViewItemWrapper>m_WrapperInsertionList  // 0x50
  private   static readonly Unity.Profiling.ProfilerMarker  K_ExpandItemByIndex  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  k_CreateWrappers  // 0x8
METHODS:
  UnityEngine.UIElements.BaseTreeView get_baseTreeView()
  System.Collections.IList get_itemsSource()
  System.Void set_itemsSource(System.Collections.IList value)
  System.Void RebuildTree()
  System.Collections.Generic.IEnumerable<System.Int32> GetRootItemIds()
  System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds)
  System.Int32 GetParentId(System.Int32 id)
  System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(System.Int32 id)
  System.Void Move(System.Int32 id, System.Int32 newParentId, System.Int32 childIndex, System.Boolean rebuildTree)
  System.Void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem)
  System.Void InvokeBindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, System.Int32 index)
  System.Void InvokeDestroyItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem)
  System.Void PostInitRegistration(UnityEngine.UIElements.ReusableTreeViewItem treeItem)
  System.Void OnItemPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  System.Void OnToggleValueChanged(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt)
  System.Int32 GetIndexForId(System.Int32 id)
  System.Int32 GetIdForIndex(System.Int32 index)
  System.Boolean HasChildren(System.Int32 id)
  System.Boolean Exists(System.Int32 id)
  System.Boolean HasChildrenByIndex(System.Int32 index)
  System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIdsByIndex(System.Int32 index)
  System.Int32 GetChildIndexForId(System.Int32 id)
  System.Int32 GetIndentationDepth(System.Int32 id)
  System.Int32 GetIndentationDepthByIndex(System.Int32 index)
  System.Boolean CanChangeExpandedState(System.Int32 id)
  System.Boolean IsExpanded(System.Int32 id)
  System.Boolean IsExpandedByIndex(System.Int32 index)
  System.Void ExpandItemByIndex(System.Int32 index, System.Boolean expandAllChildren, System.Boolean refresh)
  System.Void ExpandItem(System.Int32 id, System.Boolean expandAllChildren, System.Boolean refresh)
  System.Void CollapseItemByIndex(System.Int32 index, System.Boolean collapseAllChildren)
  System.Void CollapseItem(System.Int32 id, System.Boolean collapseAllChildren)
  System.Void RegenerateWrappers()
  System.Void CreateWrappers(System.Collections.Generic.IEnumerable<System.Int32> treeViewItemIds, System.Int32 depth, System.Collections.Generic.List<UnityEngine.UIElements.TreeViewItemWrapper>& wrappers)
  System.Boolean IsIndexValid(System.Int32 index)
  System.Void RaiseItemParentChanged(System.Int32 id, System.Int32 newParentId)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.CollectionViewController
TYPE:  class
TOKEN: 0x20000EA
FIELDS:
  private           UnityEngine.UIElements.BaseVerticalCollectionViewm_View  // 0x10
  private           System.Collections.IList        m_ItemsSource  // 0x18
  private           System.Action                   itemsSourceChanged  // 0x20
  private           System.Action<System.Int32,System.Int32>itemIndexChanged  // 0x28
METHODS:
  System.Void add_itemsSourceChanged(System.Action value)
  System.Void remove_itemsSourceChanged(System.Action value)
  System.Void add_itemIndexChanged(System.Action<System.Int32,System.Int32> value)
  System.Void remove_itemIndexChanged(System.Action<System.Int32,System.Int32> value)
  System.Collections.IList get_itemsSource()
  System.Void set_itemsSource(System.Collections.IList value)
  System.Void SetItemsSourceWithoutNotify(System.Collections.IList source)
  UnityEngine.UIElements.BaseVerticalCollectionView get_view()
  System.Void SetView(UnityEngine.UIElements.BaseVerticalCollectionView collectionView)
  System.Void PrepareView()
  System.Void Dispose()
  System.Int32 GetItemsCount()
  System.Int32 GetItemsMinCount()
  System.Int32 GetIndexForId(System.Int32 id)
  System.Int32 GetIdForIndex(System.Int32 index)
  System.Object GetItemForIndex(System.Int32 index)
  System.Void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem)
  System.Void InvokeBindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, System.Int32 index)
  System.Void InvokeUnbindItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem, System.Int32 index)
  System.Void InvokeDestroyItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem)
  UnityEngine.UIElements.VisualElement MakeItem()
  System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  System.Void DestroyItem(UnityEngine.UIElements.VisualElement element)
  System.Void RaiseItemsSourceChanged()
  System.Void RaiseItemIndexChanged(System.Int32 srcIndex, System.Int32 dstIndex)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.DefaultMultiColumnTreeViewController`1
TYPE:  class
TOKEN: 0x20000EB
EXTENDS: MultiColumnTreeViewController
FIELDS:
  private           UnityEngine.UIElements.TreeDataController<T>m_TreeDataController  // 0x0
METHODS:
  UnityEngine.UIElements.TreeDataController<T> get_treeDataController()
  System.Void .ctor(UnityEngine.UIElements.Columns columns, UnityEngine.UIElements.SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns)
  System.Collections.IList get_itemsSource()
  System.Void set_itemsSource(System.Collections.IList value)
  System.Void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> items)
  System.Object GetItemForIndex(System.Int32 index)
  System.Int32 GetParentId(System.Int32 id)
  System.Boolean HasChildren(System.Int32 id)
  System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(System.Int32 id)
  System.Void Move(System.Int32 id, System.Int32 newParentId, System.Int32 childIndex, System.Boolean rebuildTree)
  System.Boolean IsChildOf(System.Int32 childId, System.Int32 id)
  System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds)
END_CLASS

CLASS: UnityEngine.UIElements.DefaultTreeViewController`1
TYPE:  class
TOKEN: 0x20000EC
EXTENDS: TreeViewController
FIELDS:
  private           UnityEngine.UIElements.TreeDataController<T>m_TreeDataController  // 0x0
METHODS:
  UnityEngine.UIElements.TreeDataController<T> get_treeDataController()
  System.Collections.IList get_itemsSource()
  System.Void set_itemsSource(System.Collections.IList value)
  System.Void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> items)
  System.Object GetItemForIndex(System.Int32 index)
  System.Int32 GetParentId(System.Int32 id)
  System.Boolean HasChildren(System.Int32 id)
  System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(System.Int32 id)
  System.Void Move(System.Int32 id, System.Int32 newParentId, System.Int32 childIndex, System.Boolean rebuildTree)
  System.Boolean IsChildOf(System.Int32 childId, System.Int32 id)
  System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ListViewController
TYPE:  class
TOKEN: 0x20000ED
EXTENDS: BaseListViewController
FIELDS:
METHODS:
  UnityEngine.UIElements.ListView get_listView()
  UnityEngine.UIElements.VisualElement MakeItem()
  System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  System.Void DestroyItem(UnityEngine.UIElements.VisualElement element)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MultiColumnListViewController
TYPE:  class
TOKEN: 0x20000EE
EXTENDS: BaseListViewController
FIELDS:
  private           UnityEngine.UIElements.MultiColumnControllerm_ColumnController  // 0x48
METHODS:
  UnityEngine.UIElements.MultiColumnController get_columnController()
  UnityEngine.UIElements.Internal.MultiColumnCollectionHeader get_header()
  System.Void .ctor(UnityEngine.UIElements.Columns columns, UnityEngine.UIElements.SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns)
  System.Void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem)
  UnityEngine.UIElements.VisualElement MakeItem()
  System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  System.Void DestroyItem(UnityEngine.UIElements.VisualElement element)
  System.Void PrepareView()
  System.Void Dispose()
  System.Void UpdateReorderClassList()
END_CLASS

CLASS: UnityEngine.UIElements.MultiColumnTreeViewController
TYPE:  class
TOKEN: 0x20000EF
EXTENDS: BaseTreeViewController
FIELDS:
  private           UnityEngine.UIElements.MultiColumnControllerm_ColumnController  // 0x58
METHODS:
  UnityEngine.UIElements.MultiColumnController get_columnController()
  UnityEngine.UIElements.Internal.MultiColumnCollectionHeader get_header()
  System.Void .ctor(UnityEngine.UIElements.Columns columns, UnityEngine.UIElements.SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns)
  System.Void InvokeMakeItem(UnityEngine.UIElements.ReusableCollectionItem reusableItem)
  UnityEngine.UIElements.VisualElement MakeItem()
  System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  System.Void DestroyItem(UnityEngine.UIElements.VisualElement element)
  System.Void PrepareView()
  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.UIElements.TreeDataController`1
TYPE:  class
TOKEN: 0x20000F0
FIELDS:
  private           UnityEngine.UIElements.TreeData<T>m_TreeData  // 0x0
  private           System.Collections.Generic.Stack<System.Collections.Generic.IEnumerator<System.Int32>>m_IteratorStack  // 0x0
METHODS:
  System.Void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems)
  T GetDataForId(System.Int32 id)
  System.Int32 GetParentId(System.Int32 id)
  System.Boolean HasChildren(System.Int32 id)
  System.Collections.Generic.IEnumerable<System.Int32> GetItemIds(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> items)
  System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(System.Int32 id)
  System.Void Move(System.Int32 id, System.Int32 newParentId, System.Int32 childIndex)
  System.Boolean IsChildOf(System.Int32 childId, System.Int32 id)
  System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.TreeViewController
TYPE:  class
TOKEN: 0x20000F3
EXTENDS: BaseTreeViewController
FIELDS:
METHODS:
  UnityEngine.UIElements.TreeView get_treeView()
  UnityEngine.UIElements.VisualElement MakeItem()
  System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  System.Void DestroyItem(UnityEngine.UIElements.VisualElement element)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.CollectionVirtualizationController
TYPE:  class
TOKEN: 0x20000F4
FIELDS:
  protected readonly UnityEngine.UIElements.ScrollViewm_ScrollView  // 0x10
METHODS:
  System.Int32 get_firstVisibleIndex()
  System.Void set_firstVisibleIndex(System.Int32 value)
  System.Int32 get_visibleItemCount()
  System.Void .ctor(UnityEngine.UIElements.ScrollView scrollView)
  System.Void Refresh(System.Boolean rebuild)
  System.Void ScrollToItem(System.Int32 id)
  System.Void Resize(UnityEngine.Vector2 size)
  System.Void OnScroll(UnityEngine.Vector2 offset)
  System.Int32 GetIndexFromPosition(UnityEngine.Vector2 position)
  System.Single GetExpectedItemHeight(System.Int32 index)
  System.Single GetExpectedContentHeight()
  System.Void OnFocus(UnityEngine.UIElements.VisualElement leafTarget)
  System.Void OnBlur(UnityEngine.UIElements.VisualElement willFocus)
  System.Void UpdateBackground()
  System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems()
  System.Void StartDragItem(UnityEngine.UIElements.ReusableCollectionItem item)
  System.Void EndDrag(System.Int32 dropIndex)
END_CLASS

CLASS: UnityEngine.UIElements.DynamicHeightVirtualizationController`1
TYPE:  class
TOKEN: 0x20000F5
EXTENDS: VerticalVirtualizationController`1
FIELDS:
  private           System.Int32                    m_HighestCachedIndex  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Single>m_ItemHeightCache  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.DynamicHeightVirtualizationController.ContentHeightCacheInfo<T>>m_ContentHeightCache  // 0x0
  private   readonly System.Collections.Generic.HashSet<System.Int32>m_WaitingCache  // 0x0
  private           System.Int32                    m_ForcedFirstVisibleItem  // 0x0
  private           System.Int32                    m_ForcedLastVisibleItem  // 0x0
  private           System.Boolean                  m_StickToBottom  // 0x0
  private           UnityEngine.UIElements.DynamicHeightVirtualizationController.VirtualizationChange<T>m_LastChange  // 0x0
  private           UnityEngine.UIElements.DynamicHeightVirtualizationController.ScrollDirection<T>m_ScrollDirection  // 0x0
  private           UnityEngine.Vector2             m_DelayedScrollOffset  // 0x0
  private           System.Single                   m_AccumulatedHeight  // 0x0
  private           System.Single                   m_MinimumItemHeight  // 0x0
  private           System.Action                   m_FillCallback  // 0x0
  private           System.Action                   m_ScrollCallback  // 0x0
  private           System.Action                   m_ScrollResetCallback  // 0x0
  private           System.Action<UnityEngine.UIElements.ReusableCollectionItem>m_GeometryChangedCallback  // 0x0
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_ScheduledItem  // 0x0
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_ScrollScheduledItem  // 0x0
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_ScrollResetScheduledItem  // 0x0
  private           System.Predicate<System.Int32>  m_IndexOutOfBoundsPredicate  // 0x0
METHODS:
  System.Single get_defaultExpectedHeight()
  System.Single get_contentPadding()
  System.Void set_contentPadding(System.Single value)
  System.Single get_contentHeight()
  System.Void set_contentHeight(System.Single value)
  System.Int32 get_anchoredIndex()
  System.Void set_anchoredIndex(System.Int32 value)
  System.Single get_anchorOffset()
  System.Void set_anchorOffset(System.Single value)
  System.Single get_viewportMaxOffset()
  System.Boolean get_alwaysRebindOnRefresh()
  System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView collectionView)
  System.Void Refresh(System.Boolean rebuild)
  System.Void ScrollToItem(System.Int32 index)
  System.Void Resize(UnityEngine.Vector2 size)
  System.Void OnScroll(UnityEngine.Vector2 scrollOffset)
  System.Void OnScrollUpdate()
  System.Void CycleItems(System.Int32 firstIndex)
  System.Boolean NeedsFill()
  System.Void Fill()
  System.Void UpdateScrollViewContainer(System.Single previousHeight, System.Single newHeight)
  System.Void ApplyScrollViewUpdate(System.Boolean dimensionsOnly)
  System.Void UpdateAnchor()
  System.Void ScheduleFill()
  System.Void ScheduleScroll()
  System.Void ScheduleScrollDirectionReset()
  System.Void ResetScroll()
  System.Int32 GetIndexFromPosition(UnityEngine.Vector2 position)
  System.Single GetExpectedItemHeight(System.Int32 index)
  System.Int32 GetFirstVisibleItem(System.Single offset)
  System.Single GetExpectedContentHeight()
  System.Single GetContentHeightForIndex(System.Int32 lastIndex)
  UnityEngine.UIElements.DynamicHeightVirtualizationController.ContentHeightCacheInfo<T> GetCachedContentHeight(System.Int32 index)
  System.Void RegisterItemHeight(System.Int32 index, System.Single height)
  System.Void UnregisterItemHeight(System.Int32 index)
  System.Void CleanItemHeightCache()
  System.Void OnRecycledItemGeometryChanged(UnityEngine.UIElements.ReusableCollectionItem item)
  System.Boolean UpdateRegisteredHeight(UnityEngine.UIElements.ReusableCollectionItem item)
  T GetOrMakeItemAtIndex(System.Int32 activeItemIndex, System.Int32 scrollViewIndex)
  System.Void ReleaseItem(System.Int32 activeItemsIndex)
  System.Void StartDragItem(UnityEngine.UIElements.ReusableCollectionItem item)
  System.Void EndDrag(System.Int32 dropIndex)
  System.Void HideItem(System.Int32 activeItemsIndex)
  System.Void MarkWaitingForLayout(T item)
  System.Boolean IsIndexOutOfBounds(System.Int32 i)
END_CLASS

CLASS: UnityEngine.UIElements.FixedHeightVirtualizationController`1
TYPE:  class
TOKEN: 0x20000F9
EXTENDS: VerticalVirtualizationController`1
FIELDS:
METHODS:
  System.Single get_resolvedItemHeight()
  System.Boolean VisibleItemPredicate(T i)
  System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView collectionView)
  System.Int32 GetIndexFromPosition(UnityEngine.Vector2 position)
  System.Single GetExpectedItemHeight(System.Int32 index)
  System.Single GetExpectedContentHeight()
  System.Void ScrollToItem(System.Int32 index)
  System.Void Resize(UnityEngine.Vector2 size)
  System.Void OnScroll(UnityEngine.Vector2 scrollOffset)
  T GetOrMakeItemAtIndex(System.Int32 activeItemIndex, System.Int32 scrollViewIndex)
  System.Void EndDrag(System.Int32 dropIndex)
END_CLASS

CLASS: UnityEngine.UIElements.ReusableCollectionItem
TYPE:  class
TOKEN: 0x20000FA
FIELDS:
  private           UnityEngine.UIElements.VisualElement<bindableElement>k__BackingField  // 0x10
  private           UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues><animator>k__BackingField  // 0x18
  private           System.Int32                    <index>k__BackingField  // 0x20
  private           System.Int32                    <id>k__BackingField  // 0x24
  private           System.Boolean                  <isDragGhost>k__BackingField  // 0x28
  private           System.Action<UnityEngine.UIElements.ReusableCollectionItem>onGeometryChanged  // 0x30
  protected         UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.GeometryChangedEvent>m_GeometryChangedEventCallback  // 0x38
  private           System.Action<UnityEngine.UIElements.ReusableCollectionItem>onDestroy  // 0x40
METHODS:
  UnityEngine.UIElements.VisualElement get_rootElement()
  UnityEngine.UIElements.VisualElement get_bindableElement()
  System.Void set_bindableElement(UnityEngine.UIElements.VisualElement value)
  UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> get_animator()
  System.Void set_animator(UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> value)
  System.Int32 get_index()
  System.Void set_index(System.Int32 value)
  System.Int32 get_id()
  System.Void set_id(System.Int32 value)
  System.Boolean get_isDragGhost()
  System.Void set_isDragGhost(System.Boolean value)
  System.Void add_onGeometryChanged(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value)
  System.Void remove_onGeometryChanged(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value)
  System.Void add_onDestroy(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value)
  System.Void remove_onDestroy(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value)
  System.Void .ctor()
  System.Void Init(UnityEngine.UIElements.VisualElement item)
  System.Void PreAttachElement()
  System.Void DetachElement()
  System.Void DestroyElement()
  System.Void SetSelected(System.Boolean selected)
  System.Void SetDragGhost(System.Boolean dragGhost)
  System.Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
END_CLASS

CLASS: UnityEngine.UIElements.ReusableListViewItem
TYPE:  class
TOKEN: 0x20000FB
EXTENDS: ReusableCollectionItem
FIELDS:
  private           UnityEngine.UIElements.VisualElementm_Container  // 0x48
  private           UnityEngine.UIElements.VisualElementm_DragHandle  // 0x50
  private           UnityEngine.UIElements.VisualElementm_ItemContainer  // 0x58
METHODS:
  UnityEngine.UIElements.VisualElement get_rootElement()
  System.Void Init(UnityEngine.UIElements.VisualElement item, System.Boolean usesAnimatedDragger)
  System.Void UpdateHierarchy(UnityEngine.UIElements.VisualElement root, UnityEngine.UIElements.VisualElement item, System.Boolean usesAnimatedDragger)
  System.Void UpdateDragHandle(System.Boolean needsDragHandle)
  System.Void PreAttachElement()
  System.Void DetachElement()
  System.Void SetDragGhost(System.Boolean dragGhost)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ReusableMultiColumnListViewItem
TYPE:  class
TOKEN: 0x20000FC
EXTENDS: ReusableListViewItem
FIELDS:
METHODS:
  UnityEngine.UIElements.VisualElement get_rootElement()
  System.Void Init(UnityEngine.UIElements.VisualElement item)
  System.Void Init(UnityEngine.UIElements.VisualElement container, UnityEngine.UIElements.Columns columns, System.Boolean usesAnimatedDrag)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ReusableMultiColumnTreeViewItem
TYPE:  class
TOKEN: 0x20000FD
EXTENDS: ReusableTreeViewItem
FIELDS:
METHODS:
  UnityEngine.UIElements.VisualElement get_rootElement()
  System.Void Init(UnityEngine.UIElements.VisualElement item)
  System.Void Init(UnityEngine.UIElements.VisualElement container, UnityEngine.UIElements.Columns columns)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ReusableTreeViewItem
TYPE:  class
TOKEN: 0x20000FE
EXTENDS: ReusableCollectionItem
FIELDS:
  private           UnityEngine.UIElements.Toggle   m_Toggle  // 0x48
  private           UnityEngine.UIElements.VisualElementm_Container  // 0x50
  private           UnityEngine.UIElements.VisualElementm_IndentElement  // 0x58
  private           UnityEngine.UIElements.VisualElementm_BindableContainer  // 0x60
  private           UnityEngine.UIElements.VisualElementm_Checkmark  // 0x68
  private           System.Action<UnityEngine.UIElements.PointerUpEvent>onPointerUp  // 0x70
  private           System.Action<UnityEngine.UIElements.ChangeEvent<System.Boolean>>onToggleValueChanged  // 0x78
  private           System.Int32                    m_Depth  // 0x80
  private           System.Single                   m_IndentWidth  // 0x84
  private           UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.PointerUpEvent>m_PointerUpCallback  // 0x88
  private           UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<System.Boolean>>m_ToggleValueChangedCallback  // 0x90
  private           UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.GeometryChangedEvent>m_ToggleGeometryChangedCallback  // 0x98
METHODS:
  UnityEngine.UIElements.VisualElement get_rootElement()
  System.Void add_onPointerUp(System.Action<UnityEngine.UIElements.PointerUpEvent> value)
  System.Void remove_onPointerUp(System.Action<UnityEngine.UIElements.PointerUpEvent> value)
  System.Void add_onToggleValueChanged(System.Action<UnityEngine.UIElements.ChangeEvent<System.Boolean>> value)
  System.Void remove_onToggleValueChanged(System.Action<UnityEngine.UIElements.ChangeEvent<System.Boolean>> value)
  System.Void .ctor()
  System.Void Init(UnityEngine.UIElements.VisualElement item)
  System.Void InitExpandHierarchy(UnityEngine.UIElements.VisualElement root, UnityEngine.UIElements.VisualElement item)
  System.Void PreAttachElement()
  System.Void DetachElement()
  System.Void Indent(System.Int32 depth)
  System.Void SetExpandedWithoutNotify(System.Boolean expanded)
  System.Void SetToggleVisibility(System.Boolean visible)
  System.Void OnToggleGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  System.Void UpdateIndentLayout()
  System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  System.Void OnToggleValueChanged(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt)
END_CLASS

CLASS: UnityEngine.UIElements.VerticalVirtualizationController`1
TYPE:  class
TOKEN: 0x20000FF
EXTENDS: CollectionVirtualizationController
FIELDS:
  private   readonly UnityEngine.Pool.ObjectPool<T>  m_Pool  // 0x0
  protected         UnityEngine.UIElements.BaseVerticalCollectionViewm_CollectionView  // 0x0
  protected         System.Collections.Generic.List<T>m_ActiveItems  // 0x0
  protected         T                               m_DraggedItem  // 0x0
  private           System.Int32                    m_LastFocusedElementIndex  // 0x0
  private           System.Collections.Generic.List<System.Int32>m_LastFocusedElementTreeChildIndexes  // 0x0
  protected readonly System.Func<T,System.Boolean>   m_VisibleItemPredicateDelegate  // 0x0
  protected         System.Collections.Generic.List<T>m_ScrollInsertionList  // 0x0
  private           UnityEngine.UIElements.VisualElementm_EmptyRows  // 0x0
METHODS:
  System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems()
  System.Int32 get_itemsCount()
  System.Boolean VisibleItemPredicate(T i)
  T get_firstVisibleItem()
  T get_lastVisibleItem()
  System.Int32 get_visibleItemCount()
  UnityEngine.UIElements.SerializedVirtualizationData get_serializedData()
  System.Int32 get_firstVisibleIndex()
  System.Void set_firstVisibleIndex(System.Int32 value)
  System.Single get_lastHeight()
  System.Boolean get_alwaysRebindOnRefresh()
  System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView collectionView)
  System.Void Refresh(System.Boolean rebuild)
  System.Void Setup(T recycledItem, System.Int32 newIndex)
  System.Void OnFocus(UnityEngine.UIElements.VisualElement leafTarget)
  System.Void OnBlur(UnityEngine.UIElements.VisualElement willFocus)
  System.Void HandleFocus(UnityEngine.UIElements.ReusableCollectionItem recycledItem, System.Int32 previousIndex)
  System.Void UpdateBackground()
  System.Void StartDragItem(UnityEngine.UIElements.ReusableCollectionItem item)
  System.Void EndDrag(System.Int32 dropIndex)
  T GetOrMakeItemAtIndex(System.Int32 activeItemIndex, System.Int32 scrollViewIndex)
  System.Void ReleaseItem(System.Int32 activeItemsIndex)
  System.Void OnDestroyItem(UnityEngine.UIElements.ReusableCollectionItem item)
  System.Int32 GetDraggedIndex()
END_CLASS

CLASS: UnityEngine.UIElements.BaseBoolField
TYPE:  class
TOKEN: 0x2000101
EXTENDS: BaseField`1
FIELDS:
  protected         UnityEngine.UIElements.Label    m_Label  // 0x418
  protected readonly UnityEngine.UIElements.VisualElementm_CheckMark  // 0x420
  private           UnityEngine.UIElements.Clickablem_Clickable  // 0x428
  private           System.String                   m_OriginalText  // 0x430
METHODS:
  System.Void .ctor(System.String label)
  System.Void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent evt)
  System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt)
  System.String get_text()
  System.Void set_text(System.String value)
  System.Void InitLabel()
  System.Void SetValueWithoutNotify(System.Boolean newValue)
  System.Void OnClickEvent(UnityEngine.UIElements.EventBase evt)
  System.Void ToggleValue()
  System.Void UpdateMixedValueContent()
END_CLASS

CLASS: UnityEngine.UIElements.BaseField`1
TYPE:  class
TOKEN: 0x2000102
EXTENDS: BindableElement
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   labelUssClassName  // 0x0
  public    static readonly System.String                   inputUssClassName  // 0x0
  public    static readonly System.String                   noLabelVariantUssClassName  // 0x0
  public    static readonly System.String                   labelDraggerVariantUssClassName  // 0x0
  public    static readonly System.String                   mixedValueLabelUssClassName  // 0x0
  public    static readonly System.String                   alignedFieldUssClassName  // 0x0
  private   static readonly System.String                   inspectorFieldUssClassName  // 0x0
  protected internalstatic readonly System.String                   mixedValueString  // 0x0
  protected internalstatic readonly UnityEngine.PropertyName        serializedPropertyCopyName  // 0x0
  private   static  UnityEngine.UIElements.CustomStyleProperty<System.Single>s_LabelWidthRatioProperty  // 0x0
  private   static  UnityEngine.UIElements.CustomStyleProperty<System.Single>s_LabelExtraPaddingProperty  // 0x0
  private   static  UnityEngine.UIElements.CustomStyleProperty<System.Single>s_LabelBaseMinWidthProperty  // 0x0
  private           System.Single                   m_LabelWidthRatio  // 0x0
  private           System.Single                   m_LabelExtraPadding  // 0x0
  private           System.Single                   m_LabelBaseMinWidth  // 0x0
  private           UnityEngine.UIElements.VisualElementm_VisualInput  // 0x0
  private           TValueType                      m_Value  // 0x0
  private           UnityEngine.UIElements.Label    <labelElement>k__BackingField  // 0x0
  private           System.Boolean                  m_ShowMixedValue  // 0x0
  private           UnityEngine.UIElements.Label    m_MixedValueLabel  // 0x0
  private           UnityEngine.UIElements.VisualElementm_CachedInspectorElement  // 0x0
  private           System.Int32                    m_CachedListAndFoldoutDepth  // 0x0
METHODS:
  UnityEngine.UIElements.VisualElement get_visualInput()
  System.Void set_visualInput(UnityEngine.UIElements.VisualElement value)
  TValueType get_rawValue()
  System.Void set_rawValue(TValueType value)
  TValueType get_value()
  System.Void set_value(TValueType value)
  UnityEngine.UIElements.Label get_labelElement()
  System.Void set_labelElement(UnityEngine.UIElements.Label value)
  System.String get_label()
  System.Void set_label(System.String value)
  System.Boolean get_showMixedValue()
  System.Void set_showMixedValue(System.Boolean value)
  UnityEngine.UIElements.Label get_mixedValueLabel()
  System.Void .ctor(System.String label)
  System.Void .ctor(System.String label, UnityEngine.UIElements.VisualElement visualInput)
  System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent e)
  System.Void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent evt)
  System.Void OnInspectorFieldGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e)
  System.Void AlignLabel()
  System.Void UpdateMixedValueContent()
  System.Void SetValueWithoutNotify(TValueType newValue)
  System.Void OnViewDataReady()
  UnityEngine.Rect GetTooltipRect()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.BaseFieldTraits`2
TYPE:  class
TOKEN: 0x2000104
EXTENDS: UxmlTraits
FIELDS:
  private           TValueUxmlAttributeType         m_Value  // 0x0
METHODS:
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ListViewReorderMode
TYPE:  struct
TOKEN: 0x2000105
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ListViewReorderModeSimple  // 0x0
  public    static  UnityEngine.UIElements.ListViewReorderModeAnimated  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.BaseListView
TYPE:  class
TOKEN: 0x2000106
EXTENDS: BaseVerticalCollectionView
FIELDS:
  private   static readonly System.String                   k_SizeFieldLabel  // 0x0
  private           System.Boolean                  m_ShowBoundCollectionSize  // 0x4A8
  private           System.Boolean                  m_ShowFoldoutHeader  // 0x4A9
  private           System.String                   m_HeaderTitle  // 0x4B0
  private           System.Action<System.Collections.Generic.IEnumerable<System.Int32>>itemsAdded  // 0x4B8
  private           System.Action<System.Collections.Generic.IEnumerable<System.Int32>>itemsRemoved  // 0x4C0
  private           System.Action                   itemsSourceSizeChanged  // 0x4C8
  private           UnityEngine.UIElements.Label    m_ListViewLabel  // 0x4D0
  protected         UnityEngine.UIElements.Foldout  m_Foldout  // 0x4D8
  protected         UnityEngine.UIElements.TextFieldm_ArraySizeField  // 0x4E0
  private           System.Boolean                  m_IsOverMultiEditLimit  // 0x4E8
  private           UnityEngine.UIElements.VisualElementm_Footer  // 0x4F0
  private           UnityEngine.UIElements.Button   m_AddButton  // 0x4F8
  private           UnityEngine.UIElements.Button   m_RemoveButton  // 0x500
  private           System.Action<System.Collections.Generic.IEnumerable<System.Int32>>m_ItemAddedCallback  // 0x508
  private           System.Action<System.Collections.Generic.IEnumerable<System.Int32>>m_ItemRemovedCallback  // 0x510
  private           System.Action                   m_ItemsSourceSizeChangedCallback  // 0x518
  private           UnityEngine.UIElements.ListViewReorderModem_ReorderMode  // 0x520
  private           System.Action                   reorderModeChanged  // 0x528
  public    static readonly System.String                   ussClassName  // 0x8
  public    static readonly System.String                   itemUssClassName  // 0x10
  public    static readonly System.String                   emptyLabelUssClassName  // 0x18
  public    static readonly System.String                   overMaxMultiEditLimitClassName  // 0x20
  public    static readonly System.String                   reorderableUssClassName  // 0x28
  public    static readonly System.String                   reorderableItemUssClassName  // 0x30
  public    static readonly System.String                   reorderableItemContainerUssClassName  // 0x38
  public    static readonly System.String                   reorderableItemHandleUssClassName  // 0x40
  public    static readonly System.String                   reorderableItemHandleBarUssClassName  // 0x48
  public    static readonly System.String                   footerUssClassName  // 0x50
  public    static readonly System.String                   foldoutHeaderUssClassName  // 0x58
  public    static readonly System.String                   arraySizeFieldUssClassName  // 0x60
  public    static readonly System.String                   arraySizeFieldWithHeaderUssClassName  // 0x68
  public    static readonly System.String                   arraySizeFieldWithFooterUssClassName  // 0x70
  public    static readonly System.String                   listViewWithHeaderUssClassName  // 0x78
  public    static readonly System.String                   listViewWithFooterUssClassName  // 0x80
  public    static readonly System.String                   scrollViewWithFooterUssClassName  // 0x88
  public    static readonly System.String                   footerAddButtonName  // 0x90
  public    static readonly System.String                   footerRemoveButtonName  // 0x98
  private           System.String                   m_MaxMultiEditStr  // 0x530
  private   static readonly System.String                   k_EmptyListStr  // 0xA0
METHODS:
  System.Boolean get_showBoundCollectionSize()
  System.Void set_showBoundCollectionSize(System.Boolean value)
  System.Boolean get_showFoldoutHeader()
  System.Void set_showFoldoutHeader(System.Boolean value)
  System.Void SetupArraySizeField()
  System.Void set_headerTitle(System.String value)
  System.Boolean get_showAddRemoveFooter()
  System.Void set_showAddRemoveFooter(System.Boolean value)
  System.Void EnableFooter(System.Boolean enabled)
  System.Void AddItems(System.Int32 itemCount)
  System.Void OnArraySizeFieldChanged(UnityEngine.UIElements.ChangeEvent<System.String> evt)
  System.Void UpdateArraySizeField()
  System.Void UpdateListViewLabel()
  System.Void OnAddClicked()
  System.Void OnRemoveClicked()
  UnityEngine.UIElements.VisualElement get_footer()
  UnityEngine.UIElements.BaseListViewController get_viewController()
  System.Void CreateVirtualizationController()
  System.Void SetViewController(UnityEngine.UIElements.CollectionViewController controller)
  System.Void OnItemAdded(System.Collections.Generic.IEnumerable<System.Int32> indices)
  System.Void OnItemsRemoved(System.Collections.Generic.IEnumerable<System.Int32> indices)
  System.Void OnItemsSourceSizeChanged()
  System.Void add_reorderModeChanged(System.Action value)
  System.Void remove_reorderModeChanged(System.Action value)
  UnityEngine.UIElements.ListViewReorderMode get_reorderMode()
  System.Void set_reorderMode(UnityEngine.UIElements.ListViewReorderMode value)
  UnityEngine.UIElements.ListViewDragger CreateDragger()
  UnityEngine.UIElements.ICollectionDragAndDropController CreateDragAndDropController()
  System.Void .ctor()
  System.Void PostRefresh()
  System.Boolean HandleItemNavigation(System.Boolean moveIn, System.Boolean altPressed)
  System.Void .cctor()
  System.Void <OnAddClicked>b__38_0()
END_CLASS

CLASS: UnityEngine.UIElements.SliderDirection
TYPE:  struct
TOKEN: 0x2000108
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.SliderDirectionHorizontal  // 0x0
  public    static  UnityEngine.UIElements.SliderDirectionVertical  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.BaseSlider`1
TYPE:  class
TOKEN: 0x2000109
EXTENDS: BaseField`1
FIELDS:
  private           UnityEngine.UIElements.VisualElement<dragContainer>k__BackingField  // 0x0
  private           UnityEngine.UIElements.VisualElement<dragElement>k__BackingField  // 0x0
  private           UnityEngine.UIElements.VisualElement<dragBorderElement>k__BackingField  // 0x0
  private           UnityEngine.UIElements.TextField<inputTextField>k__BackingField  // 0x0
  private           TValueType                      m_LowValue  // 0x0
  private           TValueType                      m_HighValue  // 0x0
  private           System.Single                   m_PageSize  // 0x0
  private           System.Boolean                  m_ShowInputField  // 0x0
  private           System.Boolean                  <clamped>k__BackingField  // 0x0
  private           UnityEngine.UIElements.ClampedDragger<TValueType><clampedDragger>k__BackingField  // 0x0
  private           UnityEngine.Rect                m_DragElementStartPos  // 0x0
  private           UnityEngine.UIElements.SliderDirectionm_Direction  // 0x0
  private           System.Boolean                  m_Inverted  // 0x0
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   labelUssClassName  // 0x0
  public    static readonly System.String                   inputUssClassName  // 0x0
  public    static readonly System.String                   horizontalVariantUssClassName  // 0x0
  public    static readonly System.String                   verticalVariantUssClassName  // 0x0
  public    static readonly System.String                   dragContainerUssClassName  // 0x0
  public    static readonly System.String                   trackerUssClassName  // 0x0
  public    static readonly System.String                   draggerUssClassName  // 0x0
  public    static readonly System.String                   draggerBorderUssClassName  // 0x0
  public    static readonly System.String                   textFieldClassName  // 0x0
METHODS:
  UnityEngine.UIElements.VisualElement get_dragContainer()
  System.Void set_dragContainer(UnityEngine.UIElements.VisualElement value)
  UnityEngine.UIElements.VisualElement get_dragElement()
  System.Void set_dragElement(UnityEngine.UIElements.VisualElement value)
  UnityEngine.UIElements.VisualElement get_dragBorderElement()
  System.Void set_dragBorderElement(UnityEngine.UIElements.VisualElement value)
  UnityEngine.UIElements.TextField get_inputTextField()
  System.Void set_inputTextField(UnityEngine.UIElements.TextField value)
  TValueType get_lowValue()
  System.Void set_lowValue(TValueType value)
  TValueType get_highValue()
  System.Void set_highValue(TValueType value)
  System.Void SetHighValueWithoutNotify(TValueType newHighValue)
  System.Single get_pageSize()
  System.Void set_pageSize(System.Single value)
  System.Boolean get_showInputField()
  System.Void set_showInputField(System.Boolean value)
  System.Boolean get_clamped()
  System.Void set_clamped(System.Boolean value)
  UnityEngine.UIElements.ClampedDragger<TValueType> get_clampedDragger()
  System.Void set_clampedDragger(UnityEngine.UIElements.ClampedDragger<TValueType> value)
  TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound)
  TValueType GetClampedValue(TValueType newValue)
  TValueType get_value()
  System.Void set_value(TValueType value)
  System.Void SetValueWithoutNotify(TValueType newValue)
  UnityEngine.UIElements.SliderDirection get_direction()
  System.Void set_direction(UnityEngine.UIElements.SliderDirection value)
  System.Boolean get_inverted()
  System.Void set_inverted(System.Boolean value)
  System.Void .ctor(System.String label, TValueType start, TValueType end, UnityEngine.UIElements.SliderDirection direction, System.Single pageSize)
  System.Single GetClosestPowerOfTen(System.Single positiveNumber)
  System.Single RoundToMultipleOf(System.Single value, System.Single roundingValue)
  System.Void ClampValue()
  TValueType SliderLerpUnclamped(TValueType a, TValueType b, System.Single interpolant)
  System.Single SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue)
  TValueType ParseStringToValue(System.String stringValue)
  System.Void ComputeValueFromKey(UnityEngine.UIElements.BaseSlider.SliderKey<TValueType> sliderKey, System.Boolean isShift)
  TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, System.Single positionInterpolant)
  System.Void SetSliderValueFromDrag()
  System.Void ComputeValueAndDirectionFromDrag(System.Single sliderLength, System.Single dragElementLength, System.Single dragElementPos)
  System.Void SetSliderValueFromClick()
  System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt)
  System.Void ComputeValueAndDirectionFromClick(System.Single sliderLength, System.Single dragElementLength, System.Single dragElementPos, System.Single dragElementLastPos)
  System.Void AdjustDragElement(System.Single factor)
  System.Void UpdateDragElementPosition(UnityEngine.UIElements.GeometryChangedEvent evt)
  System.Void OnViewDataReady()
  System.Boolean SameValues(System.Single a, System.Single b, System.Single epsilon)
  System.Void UpdateDragElementPosition()
  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  System.Void UpdateTextFieldVisibility()
  System.Void UpdateTextFieldValue()
  System.Void OnTextFieldFocusOut(UnityEngine.UIElements.FocusOutEvent evt)
  System.Void OnTextFieldValueChange(UnityEngine.UIElements.ChangeEvent<System.String> evt)
  System.Void UpdateMixedValueContent()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.BaseTreeView
TYPE:  class
TOKEN: 0x200010B
EXTENDS: BaseVerticalCollectionView
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   itemUssClassName  // 0x8
  public    static readonly System.String                   itemToggleUssClassName  // 0x10
  public    static readonly System.String                   itemIndentsContainerUssClassName  // 0x18
  public    static readonly System.String                   itemIndentUssClassName  // 0x20
  public    static readonly System.String                   itemContentContainerUssClassName  // 0x28
  private           System.Boolean                  m_AutoExpand  // 0x4A8
  private           System.Collections.Generic.List<System.Int32>m_ExpandedItemIds  // 0x4B0
METHODS:
  System.Collections.IList get_itemsSource()
  UnityEngine.UIElements.BaseTreeViewController get_viewController()
  System.Void CreateVirtualizationController()
  System.Void SetViewController(UnityEngine.UIElements.CollectionViewController controller)
  System.Void OnItemIndexChanged(System.Int32 srcIndex, System.Int32 dstIndex)
  UnityEngine.UIElements.ICollectionDragAndDropController CreateDragAndDropController()
  System.Boolean get_autoExpand()
  System.Void set_autoExpand(System.Boolean value)
  System.Collections.Generic.List<System.Int32> get_expandedItemIds()
  System.Void set_expandedItemIds(System.Collections.Generic.List<System.Int32> value)
  System.Void .ctor()
  System.Void .ctor(System.Int32 itemHeight)
  System.Void OnViewDataReady()
  System.Boolean HandleItemNavigation(System.Boolean moveIn, System.Boolean altPressed)
  System.Void SetSelectionById(System.Int32 id)
  System.Void SetSelectionById(System.Collections.Generic.IEnumerable<System.Int32> ids)
  System.Void SetSelectionInternalById(System.Collections.Generic.IEnumerable<System.Int32> ids, System.Boolean sendNotification)
  System.Int32 GetItemIndex(System.Int32 id, System.Boolean expand)
  System.Boolean IsExpanded(System.Int32 id)
  System.Void CollapseItem(System.Int32 id, System.Boolean collapseAllChildren)
  System.Void ExpandItem(System.Int32 id, System.Boolean expandAllChildren)
  System.Void OnTreeViewPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  System.Boolean IsExpandedByIndex(System.Int32 index)
  System.Void CollapseItemByIndex(System.Int32 index, System.Boolean collapseAll)
  System.Void ExpandItemByIndex(System.Int32 index, System.Boolean expandAll)
  System.Void .cctor()
  System.Int32 <SetSelectionInternalById>b__47_0(System.Int32 id)
END_CLASS

CLASS: UnityEngine.UIElements.AlternatingRowBackground
TYPE:  struct
TOKEN: 0x200010D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.AlternatingRowBackgroundNone  // 0x0
  public    static  UnityEngine.UIElements.AlternatingRowBackgroundContentOnly  // 0x0
  public    static  UnityEngine.UIElements.AlternatingRowBackgroundAll  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.CollectionVirtualizationMethod
TYPE:  struct
TOKEN: 0x200010E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.CollectionVirtualizationMethodFixedHeight  // 0x0
  public    static  UnityEngine.UIElements.CollectionVirtualizationMethodDynamicHeight  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.SerializedVirtualizationData
TYPE:  class
TOKEN: 0x200010F
FIELDS:
  public            UnityEngine.Vector2             scrollOffset  // 0x10
  public            System.Int32                    firstVisibleIndex  // 0x18
  public            System.Single                   contentPadding  // 0x1C
  public            System.Single                   contentHeight  // 0x20
  public            System.Int32                    anchoredItemIndex  // 0x24
  public            System.Single                   anchorOffset  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.BaseVerticalCollectionView
TYPE:  class
TOKEN: 0x2000110
EXTENDS: BindableElement
FIELDS:
  private   static readonly Unity.Profiling.ProfilerMarker  k_RefreshMarker  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  k_RebuildMarker  // 0x8
  private           System.Action<System.Collections.Generic.IEnumerable<System.Object>>itemsChosen  // 0x3D0
  private           System.Action<System.Collections.Generic.IEnumerable<System.Object>>selectionChanged  // 0x3D8
  private           System.Action<System.Collections.Generic.IEnumerable<System.Int32>>selectedIndicesChanged  // 0x3E0
  private           System.Action<System.Int32,System.Int32>itemIndexChanged  // 0x3E8
  private           System.Action                   itemsSourceChanged  // 0x3F0
  private           System.Action                   selectionNotChanged  // 0x3F8
  private           System.Func<UnityEngine.UIElements.CanStartDragArgs,System.Boolean>canStartDrag  // 0x400
  private           System.Func<UnityEngine.UIElements.SetupDragAndDropArgs,UnityEngine.UIElements.StartDragArgs>setupDragAndDrop  // 0x408
  private           System.Func<UnityEngine.UIElements.HandleDragAndDropArgs,UnityEngine.UIElements.DragVisualMode>dragAndDropUpdate  // 0x410
  private           System.Func<UnityEngine.UIElements.HandleDragAndDropArgs,UnityEngine.UIElements.DragVisualMode>handleDrop  // 0x418
  private           UnityEngine.UIElements.SelectionTypem_SelectionType  // 0x420
  private   static readonly System.Collections.Generic.List<UnityEngine.UIElements.ReusableCollectionItem>k_EmptyItems  // 0x10
  private           System.Boolean                  m_HorizontalScrollingEnabled  // 0x424
  private           UnityEngine.UIElements.AlternatingRowBackgroundm_ShowAlternatingRowBackgrounds  // 0x428
  private   static readonly System.Int32                    s_DefaultItemHeight  // 0x18
  private           System.Single                   m_FixedItemHeight  // 0x42C
  private           System.Boolean                  m_ItemHeightIsInline  // 0x430
  private           UnityEngine.UIElements.CollectionVirtualizationMethodm_VirtualizationMethod  // 0x434
  private   readonly UnityEngine.UIElements.ScrollViewm_ScrollView  // 0x438
  private           UnityEngine.UIElements.CollectionViewControllerm_ViewController  // 0x440
  private           UnityEngine.UIElements.CollectionVirtualizationControllerm_VirtualizationController  // 0x448
  private           UnityEngine.UIElements.KeyboardNavigationManipulatorm_NavigationManipulator  // 0x450
  private           UnityEngine.UIElements.SerializedVirtualizationDataserializedVirtualizationData  // 0x458
  private   readonly System.Collections.Generic.List<System.Int32>m_SelectedIds  // 0x460
  private   readonly UnityEngine.UIElements.BaseVerticalCollectionView.Selectionm_Selection  // 0x468
  private           System.Single                   m_LastHeight  // 0x470
  private           System.Boolean                  m_IsRangeSelectionDirectionUp  // 0x474
  private           UnityEngine.UIElements.ListViewDraggerm_Dragger  // 0x478
  private   static  UnityEngine.UIElements.CustomStyleProperty<System.Int32>s_ItemHeightProperty  // 0x20
  private           System.Action<System.Int32,System.Int32>m_ItemIndexChangedCallback  // 0x480
  private           System.Action                   m_ItemsSourceChangedCallback  // 0x488
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_RebuildScheduled  // 0x490
  public    static readonly System.String                   ussClassName  // 0x28
  public    static readonly System.String                   borderUssClassName  // 0x30
  public    static readonly System.String                   itemUssClassName  // 0x38
  public    static readonly System.String                   dragHoverBarUssClassName  // 0x40
  public    static readonly System.String                   dragHoverMarkerUssClassName  // 0x48
  public    static readonly System.String                   itemDragHoverUssClassName  // 0x50
  public    static readonly System.String                   itemSelectedVariantUssClassName  // 0x58
  public    static readonly System.String                   itemAlternativeBackgroundUssClassName  // 0x60
  public    static readonly System.String                   listScrollViewUssClassName  // 0x68
  private   static readonly System.String                   backgroundFillUssClassName  // 0x70
  private           UnityEngine.Vector3             m_TouchDownPosition  // 0x498
METHODS:
  System.Boolean HasCanStartDrag()
  System.Boolean RaiseCanStartDrag(UnityEngine.UIElements.ReusableCollectionItem item, System.Collections.Generic.IEnumerable<System.Int32> ids)
  UnityEngine.UIElements.StartDragArgs RaiseSetupDragAndDrop(UnityEngine.UIElements.ReusableCollectionItem item, System.Collections.Generic.IEnumerable<System.Int32> ids, UnityEngine.UIElements.StartDragArgs args)
  UnityEngine.UIElements.DragVisualMode RaiseHandleDragAndDrop(UnityEngine.Vector2 pointerPosition, UnityEngine.UIElements.DragAndDropArgs dragAndDropArgs)
  UnityEngine.UIElements.DragVisualMode RaiseDrop(UnityEngine.Vector2 pointerPosition, UnityEngine.UIElements.DragAndDropArgs dragAndDropArgs)
  System.Collections.IList get_itemsSource()
  System.Void set_itemsSource(System.Collections.IList value)
  UnityEngine.UIElements.VisualElement get_contentContainer()
  UnityEngine.UIElements.SelectionType get_selectionType()
  System.Void set_selectionType(UnityEngine.UIElements.SelectionType value)
  System.Collections.Generic.IEnumerable<System.Object> get_selectedItems()
  System.Int32 get_selectedIndex()
  System.Void set_selectedIndex(System.Int32 value)
  System.Collections.Generic.IEnumerable<System.Int32> get_selectedIndices()
  System.Collections.Generic.IEnumerable<System.Int32> get_selectedIds()
  System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems()
  UnityEngine.UIElements.ScrollView get_scrollView()
  UnityEngine.UIElements.ListViewDragger get_dragger()
  UnityEngine.UIElements.CollectionVirtualizationController get_virtualizationController()
  UnityEngine.UIElements.CollectionViewController get_viewController()
  System.Single ResolveItemHeight(System.Single height)
  System.Void set_showBorder(System.Boolean value)
  System.Boolean get_reorderable()
  System.Void set_reorderable(System.Boolean value)
  System.Void set_horizontalScrollingEnabled(System.Boolean value)
  UnityEngine.UIElements.AlternatingRowBackground get_showAlternatingRowBackgrounds()
  System.Void set_showAlternatingRowBackgrounds(UnityEngine.UIElements.AlternatingRowBackground value)
  UnityEngine.UIElements.CollectionVirtualizationMethod get_virtualizationMethod()
  System.Void set_virtualizationMethod(UnityEngine.UIElements.CollectionVirtualizationMethod value)
  System.Single get_fixedItemHeight()
  System.Void set_fixedItemHeight(System.Single value)
  System.Single get_lastHeight()
  System.Void CreateVirtualizationController()
  UnityEngine.UIElements.CollectionVirtualizationController GetOrCreateVirtualizationController()
  System.Void CreateVirtualizationController()
  UnityEngine.UIElements.CollectionViewController GetOrCreateViewController()
  UnityEngine.UIElements.CollectionViewController CreateViewController()
  System.Void SetViewController(UnityEngine.UIElements.CollectionViewController controller)
  UnityEngine.UIElements.ListViewDragger CreateDragger()
  System.Void InitializeDragAndDropController(System.Boolean enableReordering)
  UnityEngine.UIElements.ICollectionDragAndDropController CreateDragAndDropController()
  System.Void .ctor()
  System.Void .ctor(System.Collections.IList itemsSource, System.Single itemHeight)
  UnityEngine.UIElements.VisualElement GetRootElementForId(System.Int32 id)
  System.Boolean HasValidDataAndBindings()
  System.Void OnItemIndexChanged(System.Int32 srcIndex, System.Int32 dstIndex)
  System.Void OnItemsSourceChanged()
  System.Void RefreshItems()
  System.Void Rebuild()
  System.Void ScheduleRebuild()
  System.Void RefreshSelection()
  System.Void PostRefresh()
  System.Void ScrollToItem(System.Int32 index)
  System.Void ScrollToItemById(System.Int32 id)
  System.Void OnScroll(UnityEngine.Vector2 offset)
  System.Void Resize(UnityEngine.Vector2 size)
  System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt)
  System.Void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt)
  System.Boolean Apply(UnityEngine.UIElements.KeyboardNavigationOperation op, System.Boolean shiftKey, System.Boolean altKey)
  System.Void Apply(UnityEngine.UIElements.KeyboardNavigationOperation op, UnityEngine.UIElements.EventBase sourceEvent)
  System.Boolean HandleItemNavigation(System.Boolean moveIn, System.Boolean altKey)
  System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt)
  System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt)
  System.Void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt)
  System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  System.Void ProcessPointerDown(UnityEngine.UIElements.IPointerEvent evt)
  System.Void ProcessPointerUp(UnityEngine.UIElements.IPointerEvent evt)
  System.Void DoSelect(UnityEngine.Vector2 localPosition, System.Int32 clickCount, System.Boolean actionKey, System.Boolean shiftKey)
  System.Void DoRangeSelection(System.Int32 rangeSelectionFinalIndex)
  System.Void ProcessSingleClick(System.Int32 clickedIndex)
  System.Void SelectAll()
  System.Void AddToSelection(System.Int32 index)
  System.Void AddToSelection(System.Collections.Generic.IList<System.Int32> indexes)
  System.Void AddToSelectionWithoutValidation(System.Int32 index)
  System.Void RemoveFromSelection(System.Int32 index)
  System.Void RemoveFromSelectionWithoutValidation(System.Int32 index)
  System.Void SetSelection(System.Int32 index)
  System.Void SetSelection(System.Collections.Generic.IEnumerable<System.Int32> indices)
  System.Void SetSelectionWithoutNotify(System.Collections.Generic.IEnumerable<System.Int32> indices)
  System.Void SetSelectionInternal(System.Collections.Generic.IEnumerable<System.Int32> indices, System.Boolean sendNotification)
  System.Boolean MatchesExistingSelection(System.Collections.Generic.IEnumerable<System.Int32> indices)
  System.Void NotifyOfSelectionChange()
  System.Void ClearSelection()
  System.Void ClearSelectionWithoutValidation()
  System.Void OnViewDataReady()
  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  System.Void OnSizeChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  System.Void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e)
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void .cctor()
  System.Void <.ctor>b__160_0(System.Single v)
  System.Void <RefreshSelection>g__NotifyIfChanged|173_0(UnityEngine.UIElements.BaseVerticalCollectionView.<>c__DisplayClass173_0& )
  System.Void <Apply>g__HandleSelectionAndScroll|184_0(System.Int32 index, UnityEngine.UIElements.BaseVerticalCollectionView.<>c__DisplayClass184_0& )
END_CLASS

CLASS: UnityEngine.UIElements.IBindable
TYPE:  interface
TOKEN: 0x2000117
FIELDS:
METHODS:
  UnityEngine.UIElements.IBinding get_binding()
  System.Void set_bindingPath(System.String value)
END_CLASS

CLASS: UnityEngine.UIElements.IBinding
TYPE:  interface
TOKEN: 0x2000118
FIELDS:
METHODS:
  System.Void PreUpdate()
  System.Void Update()
  System.Void Release()
END_CLASS

CLASS: UnityEngine.UIElements.Box
TYPE:  class
TOKEN: 0x2000119
EXTENDS: VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Button
TYPE:  class
TOKEN: 0x200011B
EXTENDS: TextElement
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  private           UnityEngine.UIElements.Clickablem_Clickable  // 0x488
  private   static readonly System.String                   NonEmptyString  // 0x8
METHODS:
  UnityEngine.UIElements.Clickable get_clickable()
  System.Void set_clickable(UnityEngine.UIElements.Clickable value)
  System.Void .ctor()
  System.Void .ctor(System.Action clickEvent)
  System.Void OnNavigationSubmit(UnityEngine.UIElements.NavigationSubmitEvent evt)
  System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt)
  UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ButtonStripField
TYPE:  class
TOKEN: 0x200011E
EXTENDS: BaseField`1
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.Button>m_Buttons  // 0x418
METHODS:
  System.Collections.Generic.List<UnityEngine.UIElements.Button> get_buttons()
  System.Void .ctor()
  System.Void SetValueWithoutNotify(System.Int32 newValue)
  System.Void RefreshButtonsState()
END_CLASS

CLASS: UnityEngine.UIElements.DropdownField
TYPE:  class
TOKEN: 0x2000121
EXTENDS: BaseField`1
FIELDS:
  private           System.Collections.Generic.List<System.String>m_Choices  // 0x418
  private           UnityEngine.UIElements.TextElementm_TextElement  // 0x420
  private           UnityEngine.UIElements.VisualElementm_ArrowElement  // 0x428
  private           System.Func<System.String,System.String>m_FormatSelectedValueCallback  // 0x430
  private           System.Func<System.String,System.String>m_FormatListItemCallback  // 0x438
  private           System.Func<UnityEngine.UIElements.IGenericMenu>createMenuCallback  // 0x440
  private           System.Int32                    m_Index  // 0x448
  private   static readonly System.String                   ussClassNameBasePopupField  // 0x0
  private   static readonly System.String                   textUssClassNameBasePopupField  // 0x8
  private   static readonly System.String                   arrowUssClassNameBasePopupField  // 0x10
  private   static readonly System.String                   labelUssClassNameBasePopupField  // 0x18
  private   static readonly System.String                   inputUssClassNameBasePopupField  // 0x20
  private   static readonly System.String                   ussClassNamePopupField  // 0x28
  private   static readonly System.String                   labelUssClassNamePopupField  // 0x30
  private   static readonly System.String                   inputUssClassNamePopupField  // 0x38
METHODS:
  UnityEngine.UIElements.TextElement get_textElement()
  System.String GetValueToDisplay()
  System.String GetListItemToDisplay(System.String value)
  System.Void set_index(System.Int32 value)
  System.Void .ctor()
  System.Void .ctor(System.String label)
  System.Void AddMenuItems(UnityEngine.UIElements.IGenericMenu menu)
  System.Void ChangeValueFromMenu(System.String menuItem)
  System.Void set_choices(System.Collections.Generic.List<System.String> value)
  System.String get_value()
  System.Void set_value(System.String value)
  System.Void SetValueWithoutNotify(System.String newValue)
  System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt)
  System.Void ShowMenu()
  System.Void UpdateMixedValueContent()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Foldout
TYPE:  class
TOKEN: 0x2000126
EXTENDS: BindableElement
FIELDS:
  private           UnityEngine.UIElements.Toggle   m_Toggle  // 0x3D0
  private           UnityEngine.UIElements.VisualElementm_Container  // 0x3D8
  private           System.Boolean                  m_Value  // 0x3E0
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   toggleUssClassName  // 0x8
  public    static readonly System.String                   contentUssClassName  // 0x10
  public    static readonly System.String                   inputUssClassName  // 0x18
  public    static readonly System.String                   checkmarkUssClassName  // 0x20
  public    static readonly System.String                   textUssClassName  // 0x28
  private   static readonly System.String                   ussFoldoutDepthClassName  // 0x30
  private   static readonly System.Int32                    ussFoldoutMaxDepth  // 0x38
METHODS:
  UnityEngine.UIElements.Toggle get_toggle()
  UnityEngine.UIElements.VisualElement get_contentContainer()
  System.Void set_text(System.String value)
  System.Boolean get_value()
  System.Void set_value(System.Boolean value)
  System.Void SetValueWithoutNotify(System.Boolean newValue)
  System.Void OnViewDataReady()
  System.Void .ctor()
  System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt)
  System.Void .cctor()
  System.Void <.ctor>b__25_0(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt)
END_CLASS

CLASS: UnityEngine.UIElements.IGenericMenu
TYPE:  interface
TOKEN: 0x2000129
FIELDS:
METHODS:
  System.Void AddItem(System.String itemName, System.Boolean isChecked, System.Action action)
  System.Void DropDown(UnityEngine.Rect position, UnityEngine.UIElements.VisualElement targetElement, System.Boolean anchored)
END_CLASS

CLASS: UnityEngine.UIElements.GenericDropdownMenu
TYPE:  class
TOKEN: 0x200012A
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   itemUssClassName  // 0x8
  public    static readonly System.String                   labelUssClassName  // 0x10
  public    static readonly System.String                   containerInnerUssClassName  // 0x18
  public    static readonly System.String                   containerOuterUssClassName  // 0x20
  public    static readonly System.String                   checkmarkUssClassName  // 0x28
  public    static readonly System.String                   separatorUssClassName  // 0x30
  private           System.Collections.Generic.List<UnityEngine.UIElements.GenericDropdownMenu.MenuItem>m_Items  // 0x10
  private           UnityEngine.UIElements.VisualElementm_MenuContainer  // 0x18
  private           UnityEngine.UIElements.VisualElementm_OuterContainer  // 0x20
  private           UnityEngine.UIElements.ScrollViewm_ScrollView  // 0x28
  private           UnityEngine.UIElements.VisualElementm_PanelRootVisualContainer  // 0x30
  private           UnityEngine.UIElements.VisualElementm_TargetElement  // 0x38
  private           UnityEngine.Rect                m_DesiredRect  // 0x40
  private           UnityEngine.UIElements.KeyboardNavigationManipulatorm_NavigationManipulator  // 0x50
  private           UnityEngine.Vector2             m_MousePosition  // 0x58
METHODS:
  UnityEngine.UIElements.VisualElement get_contentContainer()
  System.Void .ctor()
  System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt)
  System.Void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt)
  System.Void Hide()
  System.Void Apply(UnityEngine.UIElements.KeyboardNavigationOperation op, UnityEngine.UIElements.EventBase sourceEvent)
  System.Boolean Apply(UnityEngine.UIElements.KeyboardNavigationOperation op)
  System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt)
  System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt)
  System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  System.Void OnFocusOut(UnityEngine.UIElements.FocusOutEvent evt)
  System.Void OnParentResized(UnityEngine.UIElements.GeometryChangedEvent evt)
  System.Void UpdateSelection(UnityEngine.UIElements.VisualElement target)
  System.Void ChangeSelectedIndex(System.Int32 newIndex, System.Int32 previousIndex)
  System.Int32 GetSelectedIndex()
  System.Void AddItem(System.String itemName, System.Boolean isChecked, System.Action action)
  System.Void AddSeparator(System.String path)
  UnityEngine.UIElements.GenericDropdownMenu.MenuItem AddItem(System.String itemName, System.Boolean isChecked, System.Boolean isEnabled, System.Object data)
  System.Void DropDown(UnityEngine.Rect position, UnityEngine.UIElements.VisualElement targetElement, System.Boolean anchored)
  System.Void OnTargetElementDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt)
  System.Void OnContainerGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  System.Void EnsureVisibilityInParent()
  System.Void .cctor()
  System.Void <Apply>g__UpdateSelectionDown|27_0(System.Int32 newIndex, UnityEngine.UIElements.GenericDropdownMenu.<>c__DisplayClass27_0& )
  System.Void <Apply>g__UpdateSelectionUp|27_1(System.Int32 newIndex, UnityEngine.UIElements.GenericDropdownMenu.<>c__DisplayClass27_0& )
END_CLASS

CLASS: UnityEngine.UIElements.GroupBox
TYPE:  class
TOKEN: 0x200012D
EXTENDS: BindableElement
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   labelUssClassName  // 0x8
  private           UnityEngine.UIElements.Label    m_TitleLabel  // 0x3D0
METHODS:
  System.Void set_text(System.String value)
  System.Void .ctor()
  System.Void .ctor(System.String text)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.HelpBoxMessageType
TYPE:  struct
TOKEN: 0x2000130
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.HelpBoxMessageTypeNone  // 0x0
  public    static  UnityEngine.UIElements.HelpBoxMessageTypeInfo  // 0x0
  public    static  UnityEngine.UIElements.HelpBoxMessageTypeWarning  // 0x0
  public    static  UnityEngine.UIElements.HelpBoxMessageTypeError  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.HelpBox
TYPE:  class
TOKEN: 0x2000131
EXTENDS: VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   labelUssClassName  // 0x8
  public    static readonly System.String                   iconUssClassName  // 0x10
  public    static readonly System.String                   iconInfoUssClassName  // 0x18
  public    static readonly System.String                   iconwarningUssClassName  // 0x20
  public    static readonly System.String                   iconErrorUssClassName  // 0x28
  private           UnityEngine.UIElements.HelpBoxMessageTypem_HelpBoxMessageType  // 0x3C0
  private           UnityEngine.UIElements.VisualElementm_Icon  // 0x3C8
  private           System.String                   m_IconClass  // 0x3D0
  private           UnityEngine.UIElements.Label    m_Label  // 0x3D8
METHODS:
  System.Void set_text(System.String value)
  System.Void set_messageType(UnityEngine.UIElements.HelpBoxMessageType value)
  System.Void .ctor()
  System.Void .ctor(System.String text, UnityEngine.UIElements.HelpBoxMessageType messageType)
  System.String GetIconClass(UnityEngine.UIElements.HelpBoxMessageType messageType)
  System.Void UpdateIcon(UnityEngine.UIElements.HelpBoxMessageType messageType)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Image
TYPE:  class
TOKEN: 0x2000134
EXTENDS: VisualElement
FIELDS:
  private           UnityEngine.ScaleMode           m_ScaleMode  // 0x3C0
  private           UnityEngine.Texture             m_Image  // 0x3C8
  private           UnityEngine.Sprite              m_Sprite  // 0x3D0
  private           UnityEngine.UIElements.VectorImagem_VectorImage  // 0x3D8
  private           UnityEngine.Rect                m_UV  // 0x3E0
  private           UnityEngine.Color               m_TintColor  // 0x3F0
  private           System.Boolean                  m_ImageIsInline  // 0x400
  private           System.Boolean                  m_ScaleModeIsInline  // 0x401
  private           System.Boolean                  m_TintColorIsInline  // 0x402
  public    static readonly System.String                   ussClassName  // 0x0
  private   static  UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D>s_ImageProperty  // 0x8
  private   static  UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite>s_SpriteProperty  // 0x10
  private   static  UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage>s_VectorImageProperty  // 0x18
  private   static  UnityEngine.UIElements.CustomStyleProperty<System.String>s_ScaleModeProperty  // 0x20
  private   static  UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color>s_TintColorProperty  // 0x28
METHODS:
  UnityEngine.Texture get_image()
  System.Void set_image(UnityEngine.Texture value)
  UnityEngine.Sprite get_sprite()
  System.Void set_sprite(UnityEngine.Sprite value)
  UnityEngine.UIElements.VectorImage get_vectorImage()
  System.Void set_vectorImage(UnityEngine.UIElements.VectorImage value)
  UnityEngine.Rect get_sourceRect()
  UnityEngine.Rect get_uv()
  UnityEngine.ScaleMode get_scaleMode()
  UnityEngine.Color get_tintColor()
  System.Void .ctor()
  UnityEngine.Vector2 GetTextureDisplaySize(UnityEngine.Texture texture)
  UnityEngine.Vector2 GetTextureDisplaySize(UnityEngine.Sprite sprite)
  UnityEngine.Vector2 DoMeasure(System.Single desiredWidth, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single desiredHeight, UnityEngine.UIElements.VisualElement.MeasureMode heightMode)
  System.Void OnGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext mgc)
  System.Void OnCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e)
  System.Void SetScaleMode(UnityEngine.ScaleMode mode)
  UnityEngine.Rect GetSourceRect()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.INotifyValueChanged`1
TYPE:  interface
TOKEN: 0x2000137
FIELDS:
METHODS:
  T get_value()
  System.Void set_value(T value)
  System.Void SetValueWithoutNotify(T newValue)
END_CLASS

CLASS: UnityEngine.UIElements.INotifyValueChangedExtensions
TYPE:  class
TOKEN: 0x2000138
FIELDS:
METHODS:
  System.Boolean RegisterValueChangedCallback(UnityEngine.UIElements.INotifyValueChanged<T> control, UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<T>> callback)
  System.Boolean UnregisterValueChangedCallback(UnityEngine.UIElements.INotifyValueChanged<T> control, UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<T>> callback)
END_CLASS

CLASS: UnityEngine.UIElements.KeyboardTextEditorEventHandler
TYPE:  class
TOKEN: 0x2000139
EXTENDS: TextEditorEventHandler
FIELDS:
  private           System.Boolean                  m_Changed  // 0x20
  private           System.Boolean                  m_Dragged  // 0x21
  private           System.Boolean                  m_DragToPosition  // 0x22
  private           System.Boolean                  m_SelectAllOnMouseUp  // 0x23
  private           System.String                   m_PreDrawCursorText  // 0x28
  private           System.Boolean                  m_IsClicking  // 0x30
  private           UnityEngine.Vector2             m_ClickStartPosition  // 0x34
  private   readonly UnityEngine.Event               m_ImguiEvent  // 0x40
METHODS:
  System.Boolean get_isClicking()
  System.Void set_isClicking(System.Boolean value)
  System.Void .ctor(UnityEngine.UIElements.TextEditorEngine editorEngine, UnityEngine.UIElements.ITextInputField textInputField)
  System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt)
  System.Void OnFocus(UnityEngine.UIElements.FocusEvent _)
  System.Void OnBlur(UnityEngine.UIElements.BlurEvent _)
  System.Void OnMouseDown(UnityEngine.UIElements.MouseDownEvent evt)
  System.Void OnMouseUp(UnityEngine.UIElements.MouseUpEvent evt)
  System.Void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent evt)
  System.Void ProcessDragMove(UnityEngine.UIElements.MouseMoveEvent evt)
  System.Boolean MoveDistanceQualifiesForDrag(UnityEngine.Vector2 start, UnityEngine.Vector2 current)
  System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent evt)
  System.Void OnValidateCommandEvent(UnityEngine.UIElements.ValidateCommandEvent evt)
  System.Void OnExecuteCommandEvent(UnityEngine.UIElements.ExecuteCommandEvent evt)
  System.Void PreDrawCursor(System.String newText)
  System.Void PostDrawCursor()
END_CLASS

CLASS: UnityEngine.UIElements.Label
TYPE:  class
TOKEN: 0x200013A
EXTENDS: TextElement
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String text)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ListView
TYPE:  class
TOKEN: 0x200013D
EXTENDS: BaseListView
FIELDS:
  private           System.Func<UnityEngine.UIElements.VisualElement>m_MakeItem  // 0x538
  private           System.Action<UnityEngine.UIElements.VisualElement,System.Int32>m_BindItem  // 0x540
  private           System.Action<UnityEngine.UIElements.VisualElement,System.Int32><unbindItem>k__BackingField  // 0x548
  private           System.Action<UnityEngine.UIElements.VisualElement><destroyItem>k__BackingField  // 0x550
METHODS:
  System.Func<UnityEngine.UIElements.VisualElement> get_makeItem()
  System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_bindItem()
  System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_unbindItem()
  System.Action<UnityEngine.UIElements.VisualElement> get_destroyItem()
  System.Boolean HasValidDataAndBindings()
  UnityEngine.UIElements.CollectionViewController CreateViewController()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MinMaxSlider
TYPE:  class
TOKEN: 0x2000140
EXTENDS: BaseField`1
FIELDS:
  private           UnityEngine.UIElements.VisualElement<dragElement>k__BackingField  // 0x418
  private           UnityEngine.UIElements.VisualElement<dragMinThumb>k__BackingField  // 0x420
  private           UnityEngine.UIElements.VisualElement<dragMaxThumb>k__BackingField  // 0x428
  private           UnityEngine.UIElements.ClampedDragger<System.Single><clampedDragger>k__BackingField  // 0x430
  private           UnityEngine.Vector2             m_DragElementStartPos  // 0x438
  private           UnityEngine.Vector2             m_ValueStartPos  // 0x440
  private           UnityEngine.Rect                m_DragMinThumbRect  // 0x448
  private           UnityEngine.Rect                m_DragMaxThumbRect  // 0x458
  private           UnityEngine.UIElements.MinMaxSlider.DragStatem_DragState  // 0x468
  private           System.Single                   m_MinLimit  // 0x46C
  private           System.Single                   m_MaxLimit  // 0x470
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   labelUssClassName  // 0x8
  public    static readonly System.String                   inputUssClassName  // 0x10
  public    static readonly System.String                   trackerUssClassName  // 0x18
  public    static readonly System.String                   draggerUssClassName  // 0x20
  public    static readonly System.String                   minThumbUssClassName  // 0x28
  public    static readonly System.String                   maxThumbUssClassName  // 0x30
METHODS:
  UnityEngine.UIElements.VisualElement get_dragElement()
  System.Void set_dragElement(UnityEngine.UIElements.VisualElement value)
  UnityEngine.UIElements.VisualElement get_dragMinThumb()
  System.Void set_dragMinThumb(UnityEngine.UIElements.VisualElement value)
  UnityEngine.UIElements.VisualElement get_dragMaxThumb()
  System.Void set_dragMaxThumb(UnityEngine.UIElements.VisualElement value)
  UnityEngine.UIElements.ClampedDragger<System.Single> get_clampedDragger()
  System.Void set_clampedDragger(UnityEngine.UIElements.ClampedDragger<System.Single> value)
  System.Single get_minValue()
  System.Void set_minValue(System.Single value)
  System.Single get_maxValue()
  System.Void set_maxValue(System.Single value)
  UnityEngine.Vector2 get_value()
  System.Void set_value(UnityEngine.Vector2 value)
  System.Void SetValueWithoutNotify(UnityEngine.Vector2 newValue)
  System.Single get_lowLimit()
  System.Void set_lowLimit(System.Single value)
  System.Single get_highLimit()
  System.Void set_highLimit(System.Single value)
  System.Void .ctor()
  System.Void .ctor(System.String label, System.Single minValue, System.Single maxValue, System.Single minLimit, System.Single maxLimit)
  UnityEngine.Vector2 ClampValues(UnityEngine.Vector2 valueToClamp)
  System.Void UpdateDragElementPosition(UnityEngine.UIElements.GeometryChangedEvent evt)
  System.Void UpdateDragElementPosition()
  System.Single SliderLerpUnclamped(System.Single a, System.Single b, System.Single interpolant)
  System.Single SliderNormalizeValue(System.Single currentValue, System.Single lowerValue, System.Single higherValue)
  System.Single ComputeValueFromPosition(System.Single positionToConvert)
  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  System.Void SetSliderValueFromDrag()
  System.Void SetSliderValueFromClick()
  System.Void ComputeValueDragStateNoThumb(System.Single lowLimitPosition, System.Single highLimitPosition, System.Single dragElementPos)
  System.Void ComputeValueFromDraggingThumb(System.Single dragElementStartPos, System.Single dragElementEndPos)
  System.Void UpdateMixedValueContent()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.PopupWindow
TYPE:  class
TOKEN: 0x2000144
EXTENDS: TextElement
FIELDS:
  private           UnityEngine.UIElements.VisualElementm_ContentContainer  // 0x488
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   contentUssClassName  // 0x8
METHODS:
  System.Void .ctor()
  UnityEngine.UIElements.VisualElement get_contentContainer()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.AbstractProgressBar
TYPE:  class
TOKEN: 0x2000147
EXTENDS: BindableElement
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   containerUssClassName  // 0x8
  public    static readonly System.String                   titleUssClassName  // 0x10
  public    static readonly System.String                   titleContainerUssClassName  // 0x18
  public    static readonly System.String                   progressUssClassName  // 0x20
  public    static readonly System.String                   backgroundUssClassName  // 0x28
  private   readonly UnityEngine.UIElements.VisualElementm_Background  // 0x3D0
  private   readonly UnityEngine.UIElements.VisualElementm_Progress  // 0x3D8
  private   readonly UnityEngine.UIElements.Label    m_Title  // 0x3E0
  private           System.Single                   m_LowValue  // 0x3E8
  private           System.Single                   m_HighValue  // 0x3EC
  private           System.Single                   m_Value  // 0x3F0
METHODS:
  System.Void set_title(System.String value)
  System.Single get_lowValue()
  System.Void set_lowValue(System.Single value)
  System.Single get_highValue()
  System.Void set_highValue(System.Single value)
  System.Void .ctor()
  System.Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e)
  System.Single get_value()
  System.Void set_value(System.Single value)
  System.Void SetValueWithoutNotify(System.Single newValue)
  System.Void SetProgress(System.Single p)
  System.Single CalculateProgressWidth(System.Single width)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ProgressBar
TYPE:  class
TOKEN: 0x2000149
EXTENDS: AbstractProgressBar
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.RadioButton
TYPE:  class
TOKEN: 0x200014B
EXTENDS: BaseBoolField
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   labelUssClassName  // 0x8
  public    static readonly System.String                   inputUssClassName  // 0x10
  public    static readonly System.String                   checkmarkBackgroundUssClassName  // 0x18
  public    static readonly System.String                   checkmarkUssClassName  // 0x20
  public    static readonly System.String                   textUssClassName  // 0x28
  private           UnityEngine.UIElements.VisualElementm_CheckmarkBackground  // 0x438
METHODS:
  System.Boolean get_value()
  System.Void set_value(System.Boolean value)
  System.Void .ctor()
  System.Void .ctor(System.String label)
  System.Void InitLabel()
  System.Void ToggleValue()
  System.Void SetSelected(System.Boolean selected)
  System.Void SetValueWithoutNotify(System.Boolean newValue)
  System.Void UpdateCheckmark()
  System.Void UpdateMixedValueContent()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.RadioButtonGroup
TYPE:  class
TOKEN: 0x200014E
EXTENDS: BaseField`1
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  private           System.Collections.Generic.IEnumerable<System.String>m_Choices  // 0x418
  private           System.Collections.Generic.List<UnityEngine.UIElements.RadioButton>m_RadioButtons  // 0x420
  private           UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<System.Boolean>>m_RadioButtonValueChangedCallback  // 0x428
METHODS:
  System.Void set_choices(System.Collections.Generic.IEnumerable<System.String> value)
  System.Void .ctor()
  System.Void .ctor(System.String label, System.Collections.Generic.List<System.String> radioButtonChoices)
  System.Void RadioButtonValueChangedCallback(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt)
  System.Void SetValueWithoutNotify(System.Int32 newValue)
  System.Void UpdateRadioButtons()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.RepeatButton
TYPE:  class
TOKEN: 0x2000151
EXTENDS: TextElement
FIELDS:
  private           UnityEngine.UIElements.Clickablem_Clickable  // 0x488
  public    static readonly System.String                   ussClassName  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Action clickEvent, System.Int64 delay, System.Int64 interval)
  System.Void SetAction(System.Action clickEvent, System.Int64 delay, System.Int64 interval)
  System.Void AddAction(System.Action clickEvent)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Scroller
TYPE:  class
TOKEN: 0x2000154
EXTENDS: VisualElement
FIELDS:
  private           System.Action<System.Single>    valueChanged  // 0x3C0
  private           UnityEngine.UIElements.Slider   <slider>k__BackingField  // 0x3C8
  private           UnityEngine.UIElements.RepeatButton<lowButton>k__BackingField  // 0x3D0
  private           UnityEngine.UIElements.RepeatButton<highButton>k__BackingField  // 0x3D8
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   horizontalVariantUssClassName  // 0x8
  public    static readonly System.String                   verticalVariantUssClassName  // 0x10
  public    static readonly System.String                   sliderUssClassName  // 0x18
  public    static readonly System.String                   lowButtonUssClassName  // 0x20
  public    static readonly System.String                   highButtonUssClassName  // 0x28
METHODS:
  System.Void add_valueChanged(System.Action<System.Single> value)
  System.Void remove_valueChanged(System.Action<System.Single> value)
  UnityEngine.UIElements.Slider get_slider()
  System.Void set_slider(UnityEngine.UIElements.Slider value)
  UnityEngine.UIElements.RepeatButton get_lowButton()
  System.Void set_lowButton(UnityEngine.UIElements.RepeatButton value)
  UnityEngine.UIElements.RepeatButton get_highButton()
  System.Void set_highButton(UnityEngine.UIElements.RepeatButton value)
  System.Single get_value()
  System.Void set_value(System.Single value)
  System.Single get_lowValue()
  System.Void set_lowValue(System.Single value)
  System.Single get_highValue()
  System.Void set_highValue(System.Single value)
  System.Void set_direction(UnityEngine.UIElements.SliderDirection value)
  System.Void .ctor()
  System.Void .ctor(System.Single lowValue, System.Single highValue, System.Action<System.Single> valueChanged, UnityEngine.UIElements.SliderDirection direction)
  System.Void Adjust(System.Single factor)
  System.Void OnSliderValueChange(UnityEngine.UIElements.ChangeEvent<System.Single> evt)
  System.Void ScrollPageUp()
  System.Void ScrollPageDown()
  System.Void ScrollPageUp(System.Single factor)
  System.Void ScrollPageDown(System.Single factor)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ScrollViewMode
TYPE:  struct
TOKEN: 0x2000157
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ScrollViewModeVertical  // 0x0
  public    static  UnityEngine.UIElements.ScrollViewModeHorizontal  // 0x0
  public    static  UnityEngine.UIElements.ScrollViewModeVerticalAndHorizontal  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.ScrollerVisibility
TYPE:  struct
TOKEN: 0x2000158
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ScrollerVisibilityAuto  // 0x0
  public    static  UnityEngine.UIElements.ScrollerVisibilityAlwaysVisible  // 0x0
  public    static  UnityEngine.UIElements.ScrollerVisibilityHidden  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.ScrollView
TYPE:  class
TOKEN: 0x2000159
EXTENDS: VisualElement
FIELDS:
  private           System.Int32                    m_FirstLayoutPass  // 0x3C0
  private           UnityEngine.UIElements.ScrollerVisibilitym_HorizontalScrollerVisibility  // 0x3C4
  private           UnityEngine.UIElements.ScrollerVisibilitym_VerticalScrollerVisibility  // 0x3C8
  private           UnityEngine.UIElements.VisualElementm_AttachedRootVisualContainer  // 0x3D0
  private           System.Single                   m_SingleLineHeight  // 0x3D8
  private           System.Boolean                  m_MouseWheelScrollSizeIsInline  // 0x3DC
  private           System.Single                   m_HorizontalPageSize  // 0x3E0
  private           System.Single                   m_VerticalPageSize  // 0x3E4
  private           System.Single                   m_MouseWheelScrollSize  // 0x3E8
  private   static readonly System.Single                   k_DefaultScrollDecelerationRate  // 0x0
  private           System.Single                   m_ScrollDecelerationRate  // 0x3EC
  private           System.Single                   k_ScaledPixelsPerPointMultiplier  // 0x3F0
  private           System.Single                   k_TouchScrollInertiaBaseTimeInterval  // 0x3F4
  private   static readonly System.Single                   k_DefaultElasticity  // 0x4
  private           System.Single                   m_Elasticity  // 0x3F8
  private           UnityEngine.UIElements.ScrollView.TouchScrollBehaviorm_TouchScrollBehavior  // 0x3FC
  private           UnityEngine.UIElements.ScrollView.NestedInteractionKindm_NestedInteractionKind  // 0x400
  private   static readonly System.Int64                    k_DefaultElasticAnimationInterval  // 0x8
  private           System.Int64                    m_ElasticAnimationIntervalMs  // 0x408
  private   readonly UnityEngine.UIElements.VisualElement<contentViewport>k__BackingField  // 0x410
  private   readonly UnityEngine.UIElements.Scroller <horizontalScroller>k__BackingField  // 0x418
  private   readonly UnityEngine.UIElements.Scroller <verticalScroller>k__BackingField  // 0x420
  private           UnityEngine.UIElements.VisualElementm_ContentContainer  // 0x428
  private           UnityEngine.UIElements.VisualElementm_ContentAndVerticalScrollContainer  // 0x430
  private           System.Single                   previousVerticalTouchScrollTimeStamp  // 0x438
  private           System.Single                   previousHorizontalTouchScrollTimeStamp  // 0x43C
  private           System.Single                   elapsedTimeSinceLastVerticalTouchScroll  // 0x440
  private           System.Single                   elapsedTimeSinceLastHorizontalTouchScroll  // 0x444
  public    static readonly System.String                   ussClassName  // 0x10
  public    static readonly System.String                   viewportUssClassName  // 0x18
  public    static readonly System.String                   horizontalVariantViewportUssClassName  // 0x20
  public    static readonly System.String                   verticalVariantViewportUssClassName  // 0x28
  public    static readonly System.String                   verticalHorizontalVariantViewportUssClassName  // 0x30
  public    static readonly System.String                   contentAndVerticalScrollUssClassName  // 0x38
  public    static readonly System.String                   contentUssClassName  // 0x40
  public    static readonly System.String                   horizontalVariantContentUssClassName  // 0x48
  public    static readonly System.String                   verticalVariantContentUssClassName  // 0x50
  public    static readonly System.String                   verticalHorizontalVariantContentUssClassName  // 0x58
  public    static readonly System.String                   hScrollerUssClassName  // 0x60
  public    static readonly System.String                   vScrollerUssClassName  // 0x68
  public    static readonly System.String                   horizontalVariantUssClassName  // 0x70
  public    static readonly System.String                   verticalVariantUssClassName  // 0x78
  public    static readonly System.String                   verticalHorizontalVariantUssClassName  // 0x80
  public    static readonly System.String                   scrollVariantUssClassName  // 0x88
  private           UnityEngine.UIElements.ScrollViewModem_Mode  // 0x448
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_ScheduledLayoutPassResetItem  // 0x450
  private           UnityEngine.Vector2             m_StartPosition  // 0x458
  private           UnityEngine.Vector2             m_PointerStartPosition  // 0x460
  private           UnityEngine.Vector2             m_Velocity  // 0x468
  private           UnityEngine.Vector2             m_SpringBackVelocity  // 0x470
  private           UnityEngine.Vector2             m_LowBounds  // 0x478
  private           UnityEngine.Vector2             m_HighBounds  // 0x480
  private           System.Single                   m_LastVelocityLerpTime  // 0x488
  private           System.Boolean                  m_StartedMoving  // 0x48C
  private           System.Boolean                  m_TouchPointerMoveAllowed  // 0x48D
  private           System.Boolean                  m_TouchStoppedVelocity  // 0x48E
  private           UnityEngine.UIElements.VisualElementm_CapturedTarget  // 0x490
  private           UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.PointerMoveEvent>m_CapturedTargetPointerMoveCallback  // 0x498
  private           UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.PointerUpEvent>m_CapturedTargetPointerUpCallback  // 0x4A0
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_PostPointerUpAnimation  // 0x4A8
METHODS:
  UnityEngine.UIElements.ScrollerVisibility get_horizontalScrollerVisibility()
  System.Void set_horizontalScrollerVisibility(UnityEngine.UIElements.ScrollerVisibility value)
  UnityEngine.UIElements.ScrollerVisibility get_verticalScrollerVisibility()
  System.Void set_verticalScrollerVisibility(UnityEngine.UIElements.ScrollerVisibility value)
  System.Void set_showHorizontal(System.Boolean value)
  System.Void set_showVertical(System.Boolean value)
  System.Boolean get_needsHorizontal()
  System.Boolean get_needsVertical()
  System.Boolean get_isVerticalScrollDisplayed()
  System.Boolean get_isHorizontalScrollDisplayed()
  UnityEngine.Vector2 get_scrollOffset()
  System.Void set_scrollOffset(UnityEngine.Vector2 value)
  System.Void set_horizontalPageSize(System.Single value)
  System.Void set_verticalPageSize(System.Single value)
  System.Single get_mouseWheelScrollSize()
  System.Void set_mouseWheelScrollSize(System.Single value)
  System.Single get_scrollableWidth()
  System.Single get_scrollableHeight()
  System.Boolean get_hasInertia()
  System.Single get_scrollDecelerationRate()
  System.Void set_scrollDecelerationRate(System.Single value)
  System.Single get_elasticity()
  System.Void set_elasticity(System.Single value)
  UnityEngine.UIElements.ScrollView.TouchScrollBehavior get_touchScrollBehavior()
  System.Void set_touchScrollBehavior(UnityEngine.UIElements.ScrollView.TouchScrollBehavior value)
  UnityEngine.UIElements.ScrollView.NestedInteractionKind get_nestedInteractionKind()
  System.Void set_nestedInteractionKind(UnityEngine.UIElements.ScrollView.NestedInteractionKind value)
  System.Void set_elasticAnimationIntervalMs(System.Int64 value)
  System.Void OnHorizontalScrollDragElementChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  System.Void OnVerticalScrollDragElementChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  System.Void UpdateHorizontalSliderPageSize()
  System.Void UpdateVerticalSliderPageSize()
  System.Void UpdateContentViewTransform()
  System.Void ScrollTo(UnityEngine.UIElements.VisualElement child)
  System.Single GetXDeltaOffset(UnityEngine.UIElements.VisualElement child)
  System.Single GetYDeltaOffset(UnityEngine.UIElements.VisualElement child)
  System.Single GetDeltaDistance(System.Single viewMin, System.Single viewMax, System.Single childBoundaryMin, System.Single childBoundaryMax)
  UnityEngine.UIElements.VisualElement get_contentViewport()
  UnityEngine.UIElements.Scroller get_horizontalScroller()
  UnityEngine.UIElements.Scroller get_verticalScroller()
  UnityEngine.UIElements.VisualElement get_contentContainer()
  System.Void .ctor()
  System.Void .ctor(UnityEngine.UIElements.ScrollViewMode scrollViewMode)
  UnityEngine.UIElements.ScrollViewMode get_mode()
  System.Void set_mode(UnityEngine.UIElements.ScrollViewMode value)
  System.Void SetScrollViewMode(UnityEngine.UIElements.ScrollViewMode mode)
  System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent evt)
  System.Void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent evt)
  System.Void OnPointerCapture(UnityEngine.UIElements.PointerCaptureEvent evt)
  System.Void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent evt)
  System.Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  System.Void ScheduleResetLayoutPass()
  System.Void ResetLayoutPass()
  System.Single ComputeElasticOffset(System.Single deltaPointer, System.Single initialScrollOffset, System.Single lowLimit, System.Single hardLowLimit, System.Single highLimit, System.Single hardHighLimit)
  System.Void ComputeInitialSpringBackVelocity()
  System.Void SpringBack()
  System.Void ApplyScrollInertia()
  System.Void PostPointerUpAnimation()
  System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt)
  System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt)
  System.Void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt)
  System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  System.Void InitTouchScrolling(UnityEngine.Vector2 position)
  UnityEngine.UIElements.ScrollView.TouchScrollingResult ComputeTouchScrolling(UnityEngine.Vector2 position)
  System.Boolean ApplyTouchScrolling(UnityEngine.Vector2 newScrollOffset)
  System.Boolean ReleaseScrolling(System.Int32 pointerId, UnityEngine.UIElements.IEventHandler target)
  System.Void ExecuteElasticSpringAnimation()
  System.Void AdjustScrollers()
  System.Void UpdateScrollers(System.Boolean displayHorizontal, System.Boolean displayVertical)
  System.Void OnScrollersGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  System.Void OnScrollWheel(UnityEngine.UIElements.WheelEvent evt)
  System.Void OnRootCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent evt)
  System.Void OnRootPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  System.Void ReadSingleLineHeight()
  System.Void UpdateElasticBehaviour()
  System.Void .cctor()
  System.Void <.ctor>b__126_0(System.Single value)
  System.Void <.ctor>b__126_1(System.Single value)
END_CLASS

CLASS: UnityEngine.UIElements.Slider
TYPE:  class
TOKEN: 0x200015F
EXTENDS: BaseSlider`1
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   labelUssClassName  // 0x8
  public    static readonly System.String                   inputUssClassName  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Single start, System.Single end, UnityEngine.UIElements.SliderDirection direction, System.Single pageSize)
  System.Void .ctor(System.String label, System.Single start, System.Single end, UnityEngine.UIElements.SliderDirection direction, System.Single pageSize)
  System.Single SliderLerpUnclamped(System.Single a, System.Single b, System.Single interpolant)
  System.Single SliderNormalizeValue(System.Single currentValue, System.Single lowerValue, System.Single higherValue)
  System.Single ParseStringToValue(System.String stringValue)
  System.Void ComputeValueFromKey(UnityEngine.UIElements.BaseSlider.SliderKey<System.Single> sliderKey, System.Boolean isShift)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.SliderInt
TYPE:  class
TOKEN: 0x2000162
EXTENDS: BaseSlider`1
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   labelUssClassName  // 0x8
  public    static readonly System.String                   inputUssClassName  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String label, System.Int32 start, System.Int32 end, UnityEngine.UIElements.SliderDirection direction, System.Single pageSize)
  System.Single get_pageSize()
  System.Void set_pageSize(System.Single value)
  System.Int32 SliderLerpUnclamped(System.Int32 a, System.Int32 b, System.Single interpolant)
  System.Single SliderNormalizeValue(System.Int32 currentValue, System.Int32 lowerValue, System.Int32 higherValue)
  System.Int32 ParseStringToValue(System.String stringValue)
  System.Void ComputeValueAndDirectionFromClick(System.Single sliderLength, System.Single dragElementLength, System.Single dragElementPos, System.Single dragElementLastPos)
  System.Void ComputeValueFromKey(UnityEngine.UIElements.BaseSlider.SliderKey<System.Int32> sliderKey, System.Boolean isShift)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.TextEditorEventHandler
TYPE:  class
TOKEN: 0x2000165
FIELDS:
  private           UnityEngine.UIElements.TextEditorEngine<editorEngine>k__BackingField  // 0x10
  private           UnityEngine.UIElements.ITextInputField<textInputField>k__BackingField  // 0x18
METHODS:
  UnityEngine.UIElements.TextEditorEngine get_editorEngine()
  System.Void set_editorEngine(UnityEngine.UIElements.TextEditorEngine value)
  UnityEngine.UIElements.ITextInputField get_textInputField()
  System.Void set_textInputField(UnityEngine.UIElements.ITextInputField value)
  System.Void .ctor(UnityEngine.UIElements.TextEditorEngine editorEngine, UnityEngine.UIElements.ITextInputField textInputField)
  System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt)
  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
END_CLASS

CLASS: UnityEngine.UIElements.TextEditorEngine
TYPE:  class
TOKEN: 0x2000166
EXTENDS: TextEditor
FIELDS:
  private           UnityEngine.UIElements.TextEditorEngine.OnDetectFocusChangeFunctionm_DetectFocusChangeFunction  // 0x90
  private           UnityEngine.UIElements.TextEditorEngine.OnIndexChangeFunctionm_IndexChangeFunction  // 0x98
METHODS:
  System.Void .ctor(UnityEngine.UIElements.TextEditorEngine.OnDetectFocusChangeFunction detectFocusChange, UnityEngine.UIElements.TextEditorEngine.OnIndexChangeFunction indexChangeFunction)
  UnityEngine.Rect get_localPosition()
  System.Void OnDetectFocusChange()
  System.Void OnCursorIndexChange()
  System.Void OnSelectIndexChange()
END_CLASS

CLASS: UnityEngine.UIElements.TextField
TYPE:  class
TOKEN: 0x2000169
EXTENDS: TextInputBaseField`1
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   labelUssClassName  // 0x8
  public    static readonly System.String                   inputUssClassName  // 0x10
METHODS:
  UnityEngine.UIElements.TextField.TextInput get_textInput()
  System.Void set_multiline(System.Boolean value)
  System.Void .ctor()
  System.Void .ctor(System.String label)
  System.Void .ctor(System.String label, System.Int32 maxLength, System.Boolean multiline, System.Boolean isPasswordField, System.Char maskChar)
  System.String get_value()
  System.Void set_value(System.String value)
  System.Void SetValueWithoutNotify(System.String newValue)
  System.Void OnViewDataReady()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ITextInputField
TYPE:  interface
TOKEN: 0x200016D
FIELDS:
METHODS:
  System.Boolean get_hasFocus()
  System.Boolean get_doubleClickSelectsWord()
  System.Boolean get_tripleClickSelectsLine()
  System.Boolean get_isReadOnly()
  System.Boolean get_isDelayed()
  System.Boolean get_isPasswordField()
  UnityEngine.UIElements.TextEditorEngine get_editorEngine()
  System.Void SyncTextEngine()
  System.Boolean AcceptCharacter(System.Char c)
  System.String CullString(System.String s)
  System.Void UpdateText(System.String value)
  System.Void UpdateValueFromText()
END_CLASS

CLASS: UnityEngine.UIElements.TextInputBaseField`1
TYPE:  class
TOKEN: 0x200016E
EXTENDS: BaseField`1
FIELDS:
  private   static  UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color>s_SelectionColorProperty  // 0x0
  private   static  UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color>s_CursorColorProperty  // 0x0
  private           System.Int32                    m_VisualInputTabIndex  // 0x0
  private           UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType>m_TextInputBase  // 0x0
  private           UnityEngine.UIElements.ITextHandle<iTextHandle>k__BackingField  // 0x0
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   labelUssClassName  // 0x0
  public    static readonly System.String                   inputUssClassName  // 0x0
  public    static readonly System.String                   singleLineInputUssClassName  // 0x0
  public    static readonly System.String                   multilineInputUssClassName  // 0x0
  public    static readonly System.String                   textInputUssName  // 0x0
  private           System.Action<System.Boolean>   onIsReadOnlyChanged  // 0x0
METHODS:
  UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> get_textInputBase()
  System.Void set_iTextHandle(UnityEngine.UIElements.ITextHandle value)
  System.Void set_text(System.String value)
  System.Void set_isReadOnly(System.Boolean value)
  System.Void set_isPasswordField(System.Boolean value)
  System.Void set_maxLength(System.Int32 value)
  System.Boolean get_isDelayed()
  System.Void set_isDelayed(System.Boolean value)
  System.Void set_maskChar(System.Char value)
  System.Void .ctor(System.String label, System.Int32 maxLength, System.Char maskChar, UnityEngine.UIElements.TextInputBaseField.TextInputBase<TValueType> textInputBase)
  System.Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent e)
  System.Void OnFieldCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent e)
  System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt)
  System.Void UpdateMixedValueContent()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Toggle
TYPE:  class
TOKEN: 0x2000171
EXTENDS: BaseBoolField
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   labelUssClassName  // 0x8
  public    static readonly System.String                   inputUssClassName  // 0x10
  public    static readonly System.String                   noTextVariantUssClassName  // 0x18
  public    static readonly System.String                   checkmarkUssClassName  // 0x20
  public    static readonly System.String                   textUssClassName  // 0x28
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String label)
  System.Void InitLabel()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.TouchScreenTextEditorEventHandler
TYPE:  class
TOKEN: 0x2000174
EXTENDS: TextEditorEventHandler
FIELDS:
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_TouchKeyboardPoller  // 0x20
  private           UnityEngine.UIElements.VisualElementm_LastPointerDownTarget  // 0x28
METHODS:
  System.Void .ctor(UnityEngine.UIElements.TextEditorEngine editorEngine, UnityEngine.UIElements.ITextInputField textInputField)
  System.Void PollTouchScreenKeyboard()
  System.Void DoPollTouchScreenKeyboard()
  System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt)
END_CLASS

CLASS: UnityEngine.UIElements.TreeView
TYPE:  class
TOKEN: 0x2000175
EXTENDS: BaseTreeView
FIELDS:
  private           System.Func<UnityEngine.UIElements.VisualElement>m_MakeItem  // 0x4B8
  private           System.Action<UnityEngine.UIElements.VisualElement,System.Int32>m_BindItem  // 0x4C0
  private           System.Action<UnityEngine.UIElements.VisualElement,System.Int32><unbindItem>k__BackingField  // 0x4C8
  private           System.Action<UnityEngine.UIElements.VisualElement><destroyItem>k__BackingField  // 0x4D0
METHODS:
  System.Func<UnityEngine.UIElements.VisualElement> get_makeItem()
  System.Void set_makeItem(System.Func<UnityEngine.UIElements.VisualElement> value)
  System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_bindItem()
  System.Void set_bindItem(System.Action<UnityEngine.UIElements.VisualElement,System.Int32> value)
  System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_unbindItem()
  System.Action<UnityEngine.UIElements.VisualElement> get_destroyItem()
  System.Boolean HasValidDataAndBindings()
  UnityEngine.UIElements.CollectionViewController CreateViewController()
  System.Void .ctor()
  System.Void .ctor(System.Func<UnityEngine.UIElements.VisualElement> makeItem, System.Action<UnityEngine.UIElements.VisualElement,System.Int32> bindItem)
END_CLASS

CLASS: UnityEngine.UIElements.TreeData`1
TYPE:  struct
TOKEN: 0x2000178
FIELDS:
  private   readonly System.Collections.Generic.IList<System.Int32>m_RootItemIds  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.TreeViewItemData<T>>m_Tree  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Int32>m_ParentIds  // 0x0
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>>m_ChildrenIds  // 0x0
METHODS:
  System.Collections.Generic.IEnumerable<System.Int32> get_rootItemIds()
  System.Void .ctor(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems)
  UnityEngine.UIElements.TreeViewItemData<T> GetDataForId(System.Int32 id)
  System.Int32 GetParentId(System.Int32 id)
  System.Void Move(System.Int32 id, System.Int32 newParentId, System.Int32 childIndex)
  System.Boolean HasAncestor(System.Int32 childId, System.Int32 ancestorId)
  System.Void AddItemToParent(UnityEngine.UIElements.TreeViewItemData<T> item, System.Int32 parentId, System.Int32 childIndex)
  System.Void RemoveFromParent(System.Int32 id, System.Int32 parentId)
  System.Void UpdateParentTree(UnityEngine.UIElements.TreeViewItemData<T> current)
  System.Void RefreshTree(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems)
  System.Void BuildTree(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> items, System.Boolean isRoot)
END_CLASS

CLASS: UnityEngine.UIElements.TreeItem
TYPE:  struct
TOKEN: 0x2000179
FIELDS:
  private   readonly System.Int32                    <id>k__BackingField  // 0x10
  private   readonly System.Int32                    <parentId>k__BackingField  // 0x14
  private   readonly System.Collections.Generic.IEnumerable<System.Int32><childrenIds>k__BackingField  // 0x18
METHODS:
  System.Int32 get_id()
  System.Int32 get_parentId()
  System.Collections.Generic.IEnumerable<System.Int32> get_childrenIds()
  System.Boolean get_hasChildren()
  System.Void .ctor(System.Int32 id, System.Int32 parentId, System.Collections.Generic.IEnumerable<System.Int32> childrenIds)
END_CLASS

CLASS: UnityEngine.UIElements.TreeViewItemWrapper
TYPE:  struct
TOKEN: 0x200017A
FIELDS:
  public    readonly UnityEngine.UIElements.TreeItem item  // 0x10
  public    readonly System.Int32                    depth  // 0x20
METHODS:
  System.Int32 get_id()
  System.Collections.Generic.IEnumerable<System.Int32> get_childrenIds()
  System.Boolean get_hasChildren()
  System.Void .ctor(UnityEngine.UIElements.TreeItem item, System.Int32 depth)
END_CLASS

CLASS: UnityEngine.UIElements.TreeViewItemData`1
TYPE:  struct
TOKEN: 0x200017B
FIELDS:
  private   readonly System.Int32                    <id>k__BackingField  // 0x0
  private   readonly T                               m_Data  // 0x0
  private   readonly System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>>m_Children  // 0x0
METHODS:
  System.Int32 get_id()
  T get_data()
  System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> get_children()
  System.Boolean get_hasChildren()
  System.Void InsertChild(UnityEngine.UIElements.TreeViewItemData<T> child, System.Int32 index)
  System.Void RemoveChild(System.Int32 childId)
  System.Int32 GetChildIndex(System.Int32 itemId)
  System.Void ReplaceChild(UnityEngine.UIElements.TreeViewItemData<T> newChild)
END_CLASS

CLASS: UnityEngine.UIElements.TwoPaneSplitView
TYPE:  class
TOKEN: 0x200017C
EXTENDS: VisualElement
FIELDS:
  private   static readonly System.String                   s_UssClassName  // 0x0
  private   static readonly System.String                   s_ContentContainerClassName  // 0x8
  private   static readonly System.String                   s_HandleDragLineClassName  // 0x10
  private   static readonly System.String                   s_HandleDragLineVerticalClassName  // 0x18
  private   static readonly System.String                   s_HandleDragLineHorizontalClassName  // 0x20
  private   static readonly System.String                   s_HandleDragLineAnchorClassName  // 0x28
  private   static readonly System.String                   s_HandleDragLineAnchorVerticalClassName  // 0x30
  private   static readonly System.String                   s_HandleDragLineAnchorHorizontalClassName  // 0x38
  private   static readonly System.String                   s_VerticalClassName  // 0x40
  private   static readonly System.String                   s_HorizontalClassName  // 0x48
  private           UnityEngine.UIElements.VisualElementm_LeftPane  // 0x3C0
  private           UnityEngine.UIElements.VisualElementm_RightPane  // 0x3C8
  private           UnityEngine.UIElements.VisualElementm_FixedPane  // 0x3D0
  private           UnityEngine.UIElements.VisualElementm_FlexedPane  // 0x3D8
  private           System.Single                   m_FixedPaneDimension  // 0x3E0
  private           UnityEngine.UIElements.VisualElementm_DragLine  // 0x3E8
  private           UnityEngine.UIElements.VisualElementm_DragLineAnchor  // 0x3F0
  private           System.Boolean                  m_CollapseMode  // 0x3F8
  private           UnityEngine.UIElements.VisualElementm_Content  // 0x400
  private           UnityEngine.UIElements.TwoPaneSplitViewOrientationm_Orientation  // 0x408
  private           System.Int32                    m_FixedPaneIndex  // 0x40C
  private           System.Single                   m_FixedPaneInitialDimension  // 0x410
  private           UnityEngine.UIElements.TwoPaneSplitViewResizerm_Resizer  // 0x418
METHODS:
  UnityEngine.UIElements.VisualElement get_fixedPane()
  UnityEngine.UIElements.VisualElement get_flexedPane()
  System.Int32 get_fixedPaneIndex()
  System.Single get_fixedPaneDimension()
  System.Void set_fixedPaneDimension(System.Single value)
  System.Void .ctor()
  System.Void Init(System.Int32 fixedPaneIndex, System.Single fixedPaneInitialDimension, UnityEngine.UIElements.TwoPaneSplitViewOrientation orientation)
  System.Void OnPostDisplaySetup(UnityEngine.UIElements.GeometryChangedEvent evt)
  System.Void PostDisplaySetup()
  System.Void OnSizeChange(UnityEngine.UIElements.GeometryChangedEvent evt)
  System.Void OnSizeChange()
  UnityEngine.UIElements.VisualElement get_contentContainer()
  System.Void OnViewDataReady()
  System.Void SetDragLineOffset(System.Single offset)
  System.Void SetFixedPaneDimension(System.Single dimension)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.TwoPaneSplitViewOrientation
TYPE:  struct
TOKEN: 0x200017F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.TwoPaneSplitViewOrientationHorizontal  // 0x0
  public    static  UnityEngine.UIElements.TwoPaneSplitViewOrientationVertical  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.TwoPaneSplitViewResizer
TYPE:  class
TOKEN: 0x2000180
EXTENDS: PointerManipulator
FIELDS:
  private           UnityEngine.Vector3             m_Start  // 0x38
  protected         System.Boolean                  m_Active  // 0x44
  private           UnityEngine.UIElements.TwoPaneSplitViewm_SplitView  // 0x48
  private           System.Int32                    m_Direction  // 0x50
  private           UnityEngine.UIElements.TwoPaneSplitViewOrientationm_Orientation  // 0x54
METHODS:
  UnityEngine.UIElements.VisualElement get_fixedPane()
  UnityEngine.UIElements.VisualElement get_flexedPane()
  System.Single get_fixedPaneMinDimension()
  System.Single get_flexedPaneMinDimension()
  System.Void .ctor(UnityEngine.UIElements.TwoPaneSplitView splitView, System.Int32 dir, UnityEngine.UIElements.TwoPaneSplitViewOrientation orientation)
  System.Void RegisterCallbacksOnTarget()
  System.Void UnregisterCallbacksFromTarget()
  System.Void ApplyDelta(System.Single delta)
  System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent e)
  System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent e)
  System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent e)
END_CLASS

CLASS: UnityEngine.UIElements.ColumnDataType
TYPE:  struct
TOKEN: 0x2000181
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ColumnDataTypeName  // 0x0
  public    static  UnityEngine.UIElements.ColumnDataTypeTitle  // 0x0
  public    static  UnityEngine.UIElements.ColumnDataTypeIcon  // 0x0
  public    static  UnityEngine.UIElements.ColumnDataTypeVisibility  // 0x0
  public    static  UnityEngine.UIElements.ColumnDataTypeWidth  // 0x0
  public    static  UnityEngine.UIElements.ColumnDataTypeMaxWidth  // 0x0
  public    static  UnityEngine.UIElements.ColumnDataTypeMinWidth  // 0x0
  public    static  UnityEngine.UIElements.ColumnDataTypeStretchable  // 0x0
  public    static  UnityEngine.UIElements.ColumnDataTypeSortable  // 0x0
  public    static  UnityEngine.UIElements.ColumnDataTypeOptional  // 0x0
  public    static  UnityEngine.UIElements.ColumnDataTypeResizable  // 0x0
  public    static  UnityEngine.UIElements.ColumnDataTypeHeaderTemplate  // 0x0
  public    static  UnityEngine.UIElements.ColumnDataTypeCellTemplate  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Column
TYPE:  class
TOKEN: 0x2000182
FIELDS:
  private   static readonly System.String                   k_InvalidTemplateError  // 0x0
  private           System.String                   m_Name  // 0x10
  private           System.String                   m_Title  // 0x18
  private           UnityEngine.UIElements.Backgroundm_Icon  // 0x20
  private           System.Boolean                  m_Visible  // 0x40
  private           UnityEngine.UIElements.Length   m_Width  // 0x44
  private           UnityEngine.UIElements.Length   m_MinWidth  // 0x4C
  private           UnityEngine.UIElements.Length   m_MaxWidth  // 0x54
  private           System.Single                   m_DesiredWidth  // 0x5C
  private           System.Boolean                  m_Stretchable  // 0x60
  private           System.Boolean                  m_Sortable  // 0x61
  private           System.Boolean                  m_Optional  // 0x62
  private           System.Boolean                  m_Resizable  // 0x63
  private           System.Func<UnityEngine.UIElements.VisualElement>m_MakeHeader  // 0x68
  private           System.Action<UnityEngine.UIElements.VisualElement>m_BindHeader  // 0x70
  private           System.Action<UnityEngine.UIElements.VisualElement>m_UnbindHeader  // 0x78
  private           System.Action<UnityEngine.UIElements.VisualElement>m_DestroyHeader  // 0x80
  private           System.Func<UnityEngine.UIElements.VisualElement>m_MakeCell  // 0x88
  private           System.Action<UnityEngine.UIElements.VisualElement,System.Int32>m_BindCell  // 0x90
  private           System.Action<UnityEngine.UIElements.VisualElement,System.Int32>m_UnbindCellItem  // 0x98
  private           System.Action<UnityEngine.UIElements.VisualElement><destroyCell>k__BackingField  // 0xA0
  private           UnityEngine.UIElements.Columns  <collection>k__BackingField  // 0xA8
  private           System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType>changed  // 0xB0
  private           System.Action<UnityEngine.UIElements.Column>resized  // 0xB8
METHODS:
  System.String get_name()
  System.Void set_name(System.String value)
  System.String get_title()
  System.Void set_title(System.String value)
  UnityEngine.UIElements.Background get_icon()
  System.Int32 get_index()
  System.Int32 get_displayIndex()
  System.Int32 get_visibleIndex()
  System.Boolean get_visible()
  System.Void set_visible(System.Boolean value)
  UnityEngine.UIElements.Length get_width()
  System.Void set_width(UnityEngine.UIElements.Length value)
  UnityEngine.UIElements.Length get_minWidth()
  System.Void set_minWidth(UnityEngine.UIElements.Length value)
  UnityEngine.UIElements.Length get_maxWidth()
  System.Void set_maxWidth(UnityEngine.UIElements.Length value)
  System.Single get_desiredWidth()
  System.Void set_desiredWidth(System.Single value)
  System.Boolean get_sortable()
  System.Void set_sortable(System.Boolean value)
  System.Boolean get_stretchable()
  System.Void set_stretchable(System.Boolean value)
  System.Boolean get_optional()
  System.Void set_optional(System.Boolean value)
  System.Boolean get_resizable()
  System.Void set_resizable(System.Boolean value)
  System.Func<UnityEngine.UIElements.VisualElement> get_makeHeader()
  System.Void set_makeHeader(System.Func<UnityEngine.UIElements.VisualElement> value)
  System.Action<UnityEngine.UIElements.VisualElement> get_bindHeader()
  System.Action<UnityEngine.UIElements.VisualElement> get_unbindHeader()
  System.Action<UnityEngine.UIElements.VisualElement> get_destroyHeader()
  System.Func<UnityEngine.UIElements.VisualElement> get_makeCell()
  System.Void set_makeCell(System.Func<UnityEngine.UIElements.VisualElement> value)
  System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_bindCell()
  System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_unbindCell()
  System.Action<UnityEngine.UIElements.VisualElement> get_destroyCell()
  UnityEngine.UIElements.Columns get_collection()
  System.Void set_collection(UnityEngine.UIElements.Columns value)
  System.Void add_changed(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value)
  System.Void remove_changed(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value)
  System.Void add_resized(System.Action<UnityEngine.UIElements.Column> value)
  System.Void remove_resized(System.Action<UnityEngine.UIElements.Column> value)
  System.Void NotifyChange(UnityEngine.UIElements.ColumnDataType type)
  System.Single GetWidth(System.Single layoutWidth)
  System.Single GetMaxWidth(System.Single layoutWidth)
  System.Single GetMinWidth(System.Single layoutWidth)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ColumnLayout
TYPE:  class
TOKEN: 0x2000187
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_StretchableColumns  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_FixedColumns  // 0x18
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_RelativeWidthColumns  // 0x20
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_MixedWidthColumns  // 0x28
  private           UnityEngine.UIElements.Columns  m_Columns  // 0x30
  private           System.Single                   m_ColumnsWidth  // 0x38
  private           System.Boolean                  m_ColumnsWidthDirty  // 0x3C
  private           System.Single                   m_MaxColumnsWidth  // 0x40
  private           System.Single                   m_MinColumnsWidth  // 0x44
  private           System.Boolean                  m_IsDirty  // 0x48
  private           System.Single                   m_PreviousWidth  // 0x4C
  private           System.Single                   m_LayoutWidth  // 0x50
  private           System.Boolean                  m_DragResizeInPreviewMode  // 0x54
  private           System.Boolean                  m_DragResizing  // 0x55
  private           System.Single                   m_DragStartPos  // 0x58
  private           System.Single                   m_DragLastPos  // 0x5C
  private           System.Single                   m_DragInitialColumnWidth  // 0x60
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_DragStretchableColumns  // 0x68
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_DragRelativeColumns  // 0x70
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_DragFixedColumns  // 0x78
  private           System.Collections.Generic.Dictionary<UnityEngine.UIElements.Column,System.Single>m_PreviewDesiredWidths  // 0x80
  private           System.Action                   layoutRequested  // 0x88
METHODS:
  UnityEngine.UIElements.Columns get_columns()
  System.Single get_columnsWidth()
  System.Single get_layoutWidth()
  System.Single get_minColumnsWidth()
  System.Single get_maxColumnsWidth()
  System.Boolean get_hasStretchableColumns()
  System.Boolean get_hasRelativeWidthColumns()
  System.Void add_layoutRequested(System.Action value)
  System.Void remove_layoutRequested(System.Action value)
  System.Void .ctor(UnityEngine.UIElements.Columns columns)
  System.Void Dirty()
  System.Void OnColumnAdded(UnityEngine.UIElements.Column column, System.Int32 index)
  System.Void OnColumnRemoved(UnityEngine.UIElements.Column column)
  System.Void OnColumnReordered(UnityEngine.UIElements.Column column, System.Int32 from, System.Int32 to)
  System.Boolean RequiresLayoutUpdate(UnityEngine.UIElements.ColumnDataType type)
  System.Void OnColumnChanged(UnityEngine.UIElements.Column column, UnityEngine.UIElements.ColumnDataType type)
  System.Void OnColumnResized(UnityEngine.UIElements.Column column)
  System.Boolean IsClamped(System.Single value, System.Single min, System.Single max)
  System.Void DoLayout(System.Single width)
  System.Void StretchResizeColumns(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, System.Single& delta, System.Boolean resizeToFit, System.Boolean dragResize)
  System.Void DistributeOverflow(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, System.Single& delta, System.Boolean resizeToFit, System.Boolean dragResize)
  System.Void DistributeExcess(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, System.Single& delta, System.Boolean resizeToFit, System.Boolean dragResize)
  System.Single RecomputeToMaxWidthProportionally(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, System.Single distributedDelta, System.Boolean setDesiredWidthOnly)
  System.Single RecomputeToMinWidthProportionally(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, System.Single distributedDelta, System.Boolean setDesiredWidthOnly)
  System.Single RecomputeToDesiredWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, System.Single distributedDelta, System.Boolean setDesiredWidthOnly, System.Boolean distributeOverflow)
  System.Single RecomputeToDesiredWidth(UnityEngine.UIElements.Column column, System.Single distributedDelta, System.Boolean setDesiredWidthOnly, System.Boolean distributeOverflow)
  System.Single RecomputeToMinWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, System.Single distributedDelta, System.Boolean setDesiredWidthOnly)
  System.Single RecomputeToMaxWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, System.Single distributedDelta, System.Boolean setDesiredWidthOnly)
  System.Void ResizeToFit(System.Single width)
  System.Void ResizeColumn(UnityEngine.UIElements.Column column, System.Single width, System.Boolean setDesiredWidthOnly)
  System.Void BeginDragResize(UnityEngine.UIElements.Column column, System.Single pos, System.Boolean previewMode)
  System.Single GetDesiredPosition(UnityEngine.UIElements.Column column)
  System.Single GetDesiredWidth(UnityEngine.UIElements.Column c)
  System.Void DragResize(UnityEngine.UIElements.Column column, System.Single pos)
  System.Void EndDragResize(UnityEngine.UIElements.Column column, System.Boolean cancelled)
  System.Void UpdateCache()
  System.Void UpdateMinAndMaxColumnsWidth()
  System.Void ClearCache()
  System.Int32 <DoLayout>b__49_0(UnityEngine.UIElements.Column c1, UnityEngine.UIElements.Column c2)
  System.Int32 <DoLayout>b__49_1(UnityEngine.UIElements.Column c1, UnityEngine.UIElements.Column c2)
  System.Int32 <RecomputeToMaxWidthProportionally>b__53_0(UnityEngine.UIElements.Column c1, UnityEngine.UIElements.Column c2)
  System.Int32 <RecomputeToMinWidthProportionally>b__54_0(UnityEngine.UIElements.Column c1, UnityEngine.UIElements.Column c2)
END_CLASS

CLASS: UnityEngine.UIElements.ColumnsDataType
TYPE:  struct
TOKEN: 0x200018A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.ColumnsDataTypePrimaryColumn  // 0x0
  public    static  UnityEngine.UIElements.ColumnsDataTypeStretchMode  // 0x0
  public    static  UnityEngine.UIElements.ColumnsDataTypeReorderable  // 0x0
  public    static  UnityEngine.UIElements.ColumnsDataTypeResizable  // 0x0
  public    static  UnityEngine.UIElements.ColumnsDataTypeResizePreview  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Columns
TYPE:  class
TOKEN: 0x200018B
FIELDS:
  private           System.Collections.Generic.IList<UnityEngine.UIElements.Column>m_Columns  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_DisplayColumns  // 0x18
  private           System.Collections.Generic.List<UnityEngine.UIElements.Column>m_VisibleColumns  // 0x20
  private           System.Boolean                  m_VisibleColumnsDirty  // 0x28
  private           UnityEngine.UIElements.Columns.StretchModem_StretchMode  // 0x2C
  private           System.Boolean                  m_Reorderable  // 0x30
  private           System.Boolean                  m_Resizable  // 0x31
  private           System.Boolean                  m_ResizePreview  // 0x32
  private           System.String                   m_PrimaryColumnName  // 0x38
  private           System.Action<UnityEngine.UIElements.ColumnsDataType>changed  // 0x40
  private           System.Action<UnityEngine.UIElements.Column,System.Int32>columnAdded  // 0x48
  private           System.Action<UnityEngine.UIElements.Column>columnRemoved  // 0x50
  private           System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType>columnChanged  // 0x58
  private           System.Action<UnityEngine.UIElements.Column>columnResized  // 0x60
  private           System.Action<UnityEngine.UIElements.Column,System.Int32,System.Int32>columnReordered  // 0x68
METHODS:
  System.String get_primaryColumnName()
  System.Void set_primaryColumnName(System.String value)
  System.Boolean get_reorderable()
  System.Void set_reorderable(System.Boolean value)
  System.Boolean get_resizable()
  System.Void set_resizable(System.Boolean value)
  System.Boolean get_resizePreview()
  System.Void set_resizePreview(System.Boolean value)
  System.Collections.Generic.IEnumerable<UnityEngine.UIElements.Column> get_displayList()
  System.Collections.Generic.IEnumerable<UnityEngine.UIElements.Column> get_visibleList()
  System.Void add_changed(System.Action<UnityEngine.UIElements.ColumnsDataType> value)
  System.Void remove_changed(System.Action<UnityEngine.UIElements.ColumnsDataType> value)
  UnityEngine.UIElements.Columns.StretchMode get_stretchMode()
  System.Void set_stretchMode(UnityEngine.UIElements.Columns.StretchMode value)
  System.Void add_columnAdded(System.Action<UnityEngine.UIElements.Column,System.Int32> value)
  System.Void remove_columnAdded(System.Action<UnityEngine.UIElements.Column,System.Int32> value)
  System.Void add_columnRemoved(System.Action<UnityEngine.UIElements.Column> value)
  System.Void remove_columnRemoved(System.Action<UnityEngine.UIElements.Column> value)
  System.Void add_columnChanged(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value)
  System.Void remove_columnChanged(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value)
  System.Void add_columnResized(System.Action<UnityEngine.UIElements.Column> value)
  System.Void remove_columnResized(System.Action<UnityEngine.UIElements.Column> value)
  System.Void add_columnReordered(System.Action<UnityEngine.UIElements.Column,System.Int32,System.Int32> value)
  System.Void remove_columnReordered(System.Action<UnityEngine.UIElements.Column,System.Int32,System.Int32> value)
  System.Boolean IsPrimary(UnityEngine.UIElements.Column column)
  System.Collections.Generic.IEnumerator<UnityEngine.UIElements.Column> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void Add(UnityEngine.UIElements.Column item)
  System.Void Clear()
  System.Boolean Contains(UnityEngine.UIElements.Column item)
  System.Boolean Contains(System.String name)
  System.Void CopyTo(UnityEngine.UIElements.Column[] array, System.Int32 arrayIndex)
  System.Boolean Remove(UnityEngine.UIElements.Column column)
  System.Void OnColumnChanged(UnityEngine.UIElements.Column column, UnityEngine.UIElements.ColumnDataType type)
  System.Void OnColumnResized(UnityEngine.UIElements.Column column)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Int32 IndexOf(UnityEngine.UIElements.Column column)
  System.Void Insert(System.Int32 index, UnityEngine.UIElements.Column column)
  UnityEngine.UIElements.Column get_Item(System.Int32 index)
  UnityEngine.UIElements.Column get_Item(System.String name)
  System.Void ReorderDisplay(System.Int32 from, System.Int32 to)
  System.Void InitOrderColumns()
  System.Void DirtyVisibleColumns()
  System.Void UpdateVisibleColumns()
  System.Void NotifyChange(UnityEngine.UIElements.ColumnsDataType type)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MultiColumnController
TYPE:  class
TOKEN: 0x2000190
FIELDS:
  private   static readonly UnityEngine.PropertyName        k_BoundColumnVePropertyName  // 0x0
  private   static readonly UnityEngine.PropertyName        bindableElementPropertyName  // 0x4
  private   static readonly System.String                   baseUssClassName  // 0x8
  private   static readonly System.String                   k_HeaderContainerViewDataKey  // 0x10
  public    static readonly System.String                   headerContainerUssClassName  // 0x18
  public    static readonly System.String                   rowContainerUssClassName  // 0x20
  public    static readonly System.String                   cellUssClassName  // 0x28
  public    static readonly System.String                   cellLabelUssClassName  // 0x30
  private   static readonly System.String                   k_HeaderViewDataKey  // 0x38
  private           System.Action                   columnSortingChanged  // 0x10
  private           System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column>headerContextMenuPopulateEvent  // 0x18
  private           UnityEngine.UIElements.BaseVerticalCollectionViewm_View  // 0x20
  private           UnityEngine.UIElements.VisualElementm_HeaderContainer  // 0x28
  private           UnityEngine.UIElements.Internal.MultiColumnCollectionHeaderm_MultiColumnHeader  // 0x30
METHODS:
  System.Void add_columnSortingChanged(System.Action value)
  System.Void remove_columnSortingChanged(System.Action value)
  System.Void add_headerContextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value)
  System.Void remove_headerContextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value)
  UnityEngine.UIElements.Internal.MultiColumnCollectionHeader get_header()
  System.Void .ctor(UnityEngine.UIElements.Columns columns, UnityEngine.UIElements.SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns)
  System.Void BindCellItem(UnityEngine.UIElements.VisualElement ve, System.Int32 rowIndex, UnityEngine.UIElements.Column column, T item)
  System.Void UnbindCellItem(UnityEngine.UIElements.VisualElement ve, System.Int32 rowIndex, UnityEngine.UIElements.Column column)
  UnityEngine.UIElements.VisualElement DefaultMakeCellItem()
  System.Void DefaultBindCellItem(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.Column column, T item)
  UnityEngine.UIElements.VisualElement MakeItem()
  System.Void BindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index, T item)
  System.Void UnbindItem(UnityEngine.UIElements.VisualElement element, System.Int32 index)
  System.Void DestroyItem(UnityEngine.UIElements.VisualElement element)
  System.Void PrepareView(UnityEngine.UIElements.BaseVerticalCollectionView collectionView)
  System.Void Dispose()
  System.Void OnHorizontalScrollerValueChanged(System.Single v)
  System.Void OnViewportGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  System.Void OnColumnContainerGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  System.Void UpdateContentContainer(UnityEngine.UIElements.BaseVerticalCollectionView collectionView)
  System.Void OnColumnSortingChanged()
  System.Void OnContextMenuPopulateEvent(UnityEngine.UIElements.ContextualMenuPopulateEvent evt, UnityEngine.UIElements.Column column)
  System.Void OnColumnResized(System.Int32 index, System.Single width)
  System.Void OnColumnAdded(UnityEngine.UIElements.Column column, System.Int32 index)
  System.Void OnColumnRemoved(UnityEngine.UIElements.Column column)
  System.Void OnColumnReordered(UnityEngine.UIElements.Column column, System.Int32 from, System.Int32 to)
  System.Void OnColumnsChanged(UnityEngine.UIElements.Column column, UnityEngine.UIElements.ColumnDataType type)
  System.Void OnColumnChanged(UnityEngine.UIElements.ColumnsDataType type)
  System.Void OnViewDataRestored()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.MultiColumnListView
TYPE:  class
TOKEN: 0x2000191
EXTENDS: BaseListView
FIELDS:
  private           UnityEngine.UIElements.Columns  m_Columns  // 0x538
  private           System.Boolean                  m_SortingEnabled  // 0x540
  private           UnityEngine.UIElements.SortColumnDescriptionsm_SortColumnDescriptions  // 0x548
  private           System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription>m_SortedColumns  // 0x550
  private           System.Action                   columnSortingChanged  // 0x558
  private           System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column>headerContextMenuPopulateEvent  // 0x560
METHODS:
  UnityEngine.UIElements.MultiColumnListViewController get_viewController()
  UnityEngine.UIElements.Columns get_columns()
  System.Void set_columns(UnityEngine.UIElements.Columns value)
  UnityEngine.UIElements.SortColumnDescriptions get_sortColumnDescriptions()
  System.Void set_sortColumnDescriptions(UnityEngine.UIElements.SortColumnDescriptions value)
  System.Void set_sortingEnabled(System.Boolean value)
  System.Void .ctor()
  System.Void .ctor(UnityEngine.UIElements.Columns columns)
  UnityEngine.UIElements.CollectionViewController CreateViewController()
  System.Void SetViewController(UnityEngine.UIElements.CollectionViewController controller)
  System.Void CreateVirtualizationController()
  System.Void RaiseColumnSortingChanged()
  System.Void RaiseHeaderContextMenuPopulate(UnityEngine.UIElements.ContextualMenuPopulateEvent evt, UnityEngine.UIElements.Column column)
END_CLASS

CLASS: UnityEngine.UIElements.MultiColumnTreeView
TYPE:  class
TOKEN: 0x2000194
EXTENDS: BaseTreeView
FIELDS:
  private           UnityEngine.UIElements.Columns  m_Columns  // 0x4B8
  private           System.Boolean                  m_SortingEnabled  // 0x4C0
  private           UnityEngine.UIElements.SortColumnDescriptionsm_SortColumnDescriptions  // 0x4C8
  private           System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription>m_SortedColumns  // 0x4D0
  private           System.Action                   columnSortingChanged  // 0x4D8
  private           System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column>headerContextMenuPopulateEvent  // 0x4E0
METHODS:
  UnityEngine.UIElements.MultiColumnTreeViewController get_viewController()
  UnityEngine.UIElements.Columns get_columns()
  System.Void set_columns(UnityEngine.UIElements.Columns value)
  UnityEngine.UIElements.SortColumnDescriptions get_sortColumnDescriptions()
  System.Void set_sortColumnDescriptions(UnityEngine.UIElements.SortColumnDescriptions value)
  System.Void set_sortingEnabled(System.Boolean value)
  System.Void .ctor()
  System.Void .ctor(UnityEngine.UIElements.Columns columns)
  UnityEngine.UIElements.CollectionViewController CreateViewController()
  System.Void SetViewController(UnityEngine.UIElements.CollectionViewController controller)
  System.Void CreateVirtualizationController()
  System.Void RaiseColumnSortingChanged()
  System.Void RaiseHeaderContextMenuPopulate(UnityEngine.UIElements.ContextualMenuPopulateEvent evt, UnityEngine.UIElements.Column column)
END_CLASS

CLASS: UnityEngine.UIElements.SortDirection
TYPE:  struct
TOKEN: 0x2000197
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.SortDirectionAscending  // 0x0
  public    static  UnityEngine.UIElements.SortDirectionDescending  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.SortColumnDescription
TYPE:  class
TOKEN: 0x2000198
FIELDS:
  private           System.Int32                    m_ColumnIndex  // 0x10
  private           System.String                   m_ColumnName  // 0x18
  private           UnityEngine.UIElements.SortDirectionm_SortDirection  // 0x20
  private           UnityEngine.UIElements.Column   <column>k__BackingField  // 0x28
  private           System.Action<UnityEngine.UIElements.SortColumnDescription>changed  // 0x30
METHODS:
  System.String get_columnName()
  System.Void set_columnName(System.String value)
  System.Int32 get_columnIndex()
  System.Void set_columnIndex(System.Int32 value)
  UnityEngine.UIElements.Column get_column()
  System.Void set_column(UnityEngine.UIElements.Column value)
  UnityEngine.UIElements.SortDirection get_direction()
  System.Void set_direction(UnityEngine.UIElements.SortDirection value)
  System.Void add_changed(System.Action<UnityEngine.UIElements.SortColumnDescription> value)
  System.Void remove_changed(System.Action<UnityEngine.UIElements.SortColumnDescription> value)
  System.Void .ctor()
  System.Void .ctor(System.Int32 columnIndex, UnityEngine.UIElements.SortDirection direction)
  System.Void .ctor(System.String columnName, UnityEngine.UIElements.SortDirection direction)
END_CLASS

CLASS: UnityEngine.UIElements.SortColumnDescriptions
TYPE:  class
TOKEN: 0x200019B
FIELDS:
  private   readonly System.Collections.Generic.IList<UnityEngine.UIElements.SortColumnDescription>m_Descriptions  // 0x10
  private           System.Action                   changed  // 0x18
METHODS:
  System.Void add_changed(System.Action value)
  System.Void remove_changed(System.Action value)
  System.Collections.Generic.IEnumerator<UnityEngine.UIElements.SortColumnDescription> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void Add(UnityEngine.UIElements.SortColumnDescription item)
  System.Void Clear()
  System.Boolean Contains(UnityEngine.UIElements.SortColumnDescription item)
  System.Void CopyTo(UnityEngine.UIElements.SortColumnDescription[] array, System.Int32 arrayIndex)
  System.Boolean Remove(UnityEngine.UIElements.SortColumnDescription desc)
  System.Void OnDescriptionChanged(UnityEngine.UIElements.SortColumnDescription desc)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Void Insert(System.Int32 index, UnityEngine.UIElements.SortColumnDescription desc)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.BaseReorderableDragAndDropController
TYPE:  class
TOKEN: 0x200019E
FIELDS:
  protected readonly UnityEngine.UIElements.BaseVerticalCollectionViewm_View  // 0x10
  protected         System.Collections.Generic.List<System.Int32>m_SortedSelectedIds  // 0x18
  private           System.Boolean                  <enableReordering>k__BackingField  // 0x20
METHODS:
  System.Collections.Generic.IEnumerable<System.Int32> GetSortedSelectedIds()
  System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView view)
  System.Boolean get_enableReordering()
  System.Void set_enableReordering(System.Boolean value)
  System.Boolean CanStartDrag(System.Collections.Generic.IEnumerable<System.Int32> itemIndices)
  UnityEngine.UIElements.StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIds, System.Boolean skipText)
  System.Int32 CompareId(System.Int32 id1, System.Int32 id2)
  UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(UnityEngine.UIElements.IListDragAndDropArgs args)
  System.Void OnDrop(UnityEngine.UIElements.IListDragAndDropArgs args)
  System.Void DragCleanup()
  System.Void HandleAutoExpand(UnityEngine.UIElements.ReusableCollectionItem item, UnityEngine.Vector2 pointerPosition)
END_CLASS

CLASS: UnityEngine.UIElements.DragAndDropUtility
TYPE:  class
TOKEN: 0x200019F
FIELDS:
  private   static  System.Func<UnityEngine.UIElements.IDragAndDrop>s_MakeDragAndDropClientFunc  // 0x0
  private   static  UnityEngine.UIElements.IDragAndDrops_DragAndDropEditor  // 0x8
  private   static  UnityEngine.UIElements.IDragAndDrops_DragAndDropPlayMode  // 0x10
METHODS:
  UnityEngine.UIElements.IDragAndDrop GetDragAndDrop(UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.DefaultDragAndDropClient
TYPE:  class
TOKEN: 0x20001A0
EXTENDS: DragAndDropData
FIELDS:
  private   readonly System.Collections.Hashtable    m_GenericData  // 0x10
  private           UnityEngine.UIElements.Label    m_DraggedInfoLabel  // 0x18
  private           UnityEngine.UIElements.DragVisualModem_VisualMode  // 0x20
  private           System.Collections.Generic.IEnumerable<UnityEngine.Object>m_UnityObjectReferences  // 0x28
METHODS:
  System.Object get_source()
  System.Object GetGenericData(System.String key)
  System.Void StartDrag(UnityEngine.UIElements.StartDragArgs args, UnityEngine.Vector3 pointerPosition)
  System.Void UpdateDrag(UnityEngine.Vector3 pointerPosition)
  System.Void AcceptDrag()
  System.Void SetVisualMode(UnityEngine.UIElements.DragVisualMode mode)
  System.Void DragCleanup()
  UnityEngine.UIElements.DragAndDropData get_data()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.DragEventsProcessor
TYPE:  class
TOKEN: 0x20001A1
FIELDS:
  private           System.Boolean                  m_IsRegistered  // 0x10
  private           UnityEngine.UIElements.DragEventsProcessor.DragStatem_DragState  // 0x14
  private           UnityEngine.Vector3             m_Start  // 0x18
  private   readonly UnityEngine.UIElements.VisualElementm_Target  // 0x28
METHODS:
  System.Boolean get_supportsDragEvents()
  System.Boolean get_useDragEvents()
  UnityEngine.UIElements.IDragAndDrop get_dragAndDrop()
  System.Boolean get_isEditorContext()
  System.Void .ctor(UnityEngine.UIElements.VisualElement target)
  System.Void RegisterCallbacksFromTarget(UnityEngine.UIElements.AttachToPanelEvent evt)
  System.Void RegisterCallbacksFromTarget()
  System.Void UnregisterCallbacksFromTarget(UnityEngine.UIElements.DetachFromPanelEvent evt)
  System.Void UnregisterCallbacksFromTarget(System.Boolean unregisterPanelEvents)
  System.Boolean CanStartDrag(UnityEngine.Vector3 pointerPosition)
  UnityEngine.UIElements.StartDragArgs StartDrag(UnityEngine.Vector3 pointerPosition)
  System.Void UpdateDrag(UnityEngine.Vector3 pointerPosition)
  System.Void OnDrop(UnityEngine.Vector3 pointerPosition)
  System.Void ClearDragAndDropUI(System.Boolean dragCancelled)
  System.Void OnPointerDownEvent(UnityEngine.UIElements.PointerDownEvent evt)
  System.Void OnPointerUpEvent(UnityEngine.UIElements.PointerUpEvent evt)
  System.Void OnPointerLeaveEvent(UnityEngine.UIElements.PointerLeaveEvent evt)
  System.Void OnPointerCancelEvent(UnityEngine.UIElements.PointerCancelEvent evt)
  System.Void OnPointerCapturedOut(UnityEngine.UIElements.PointerCaptureOutEvent evt)
  System.Void OnPointerMoveEvent(UnityEngine.UIElements.PointerMoveEvent evt)
  UnityEngine.UIElements.DragEventsProcessor GetDropTarget(UnityEngine.Vector2 position)
END_CLASS

CLASS: UnityEngine.UIElements.ICollectionDragAndDropController
TYPE:  interface
TOKEN: 0x20001A3
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IDragAndDrop
TYPE:  interface
TOKEN: 0x20001A4
FIELDS:
METHODS:
  System.Void StartDrag(UnityEngine.UIElements.StartDragArgs args, UnityEngine.Vector3 pointerPosition)
  System.Void UpdateDrag(UnityEngine.Vector3 pointerPosition)
  System.Void AcceptDrag()
  System.Void DragCleanup()
  System.Void SetVisualMode(UnityEngine.UIElements.DragVisualMode visualMode)
  UnityEngine.UIElements.DragAndDropData get_data()
END_CLASS

CLASS: UnityEngine.UIElements.DragAndDropData
TYPE:  class
TOKEN: 0x20001A5
FIELDS:
METHODS:
  System.Object GetGenericData(System.String key)
  System.Object get_source()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.IDragAndDropController`1
TYPE:  interface
TOKEN: 0x20001A6
FIELDS:
METHODS:
  System.Boolean CanStartDrag(System.Collections.Generic.IEnumerable<System.Int32> itemIndices)
  UnityEngine.UIElements.StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIndices, System.Boolean skipText)
  UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(TArgs args)
  System.Void OnDrop(TArgs args)
  System.Void DragCleanup()
  System.Void HandleAutoExpand(UnityEngine.UIElements.ReusableCollectionItem item, UnityEngine.Vector2 pointerPosition)
  System.Collections.Generic.IEnumerable<System.Int32> GetSortedSelectedIds()
END_CLASS

CLASS: UnityEngine.UIElements.DragVisualMode
TYPE:  struct
TOKEN: 0x20001A7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DragVisualModeNone  // 0x0
  public    static  UnityEngine.UIElements.DragVisualModeCopy  // 0x0
  public    static  UnityEngine.UIElements.DragVisualModeMove  // 0x0
  public    static  UnityEngine.UIElements.DragVisualModeRejected  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.CanStartDragArgs
TYPE:  struct
TOKEN: 0x20001A8
FIELDS:
  public    readonly UnityEngine.UIElements.VisualElementdraggedElement  // 0x10
  public    readonly System.Int32                    id  // 0x18
  public    readonly System.Collections.Generic.IEnumerable<System.Int32>selectedIds  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.UIElements.VisualElement draggedElement, System.Int32 id, System.Collections.Generic.IEnumerable<System.Int32> selectedIds)
END_CLASS

CLASS: UnityEngine.UIElements.SetupDragAndDropArgs
TYPE:  struct
TOKEN: 0x20001A9
FIELDS:
  public    readonly UnityEngine.UIElements.VisualElementdraggedElement  // 0x10
  public    readonly System.Collections.Generic.IEnumerable<System.Int32>selectedIds  // 0x18
  public    readonly UnityEngine.UIElements.StartDragArgsstartDragArgs  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.UIElements.VisualElement draggedElement, System.Collections.Generic.IEnumerable<System.Int32> selectedIds, UnityEngine.UIElements.StartDragArgs startDragArgs)
END_CLASS

CLASS: UnityEngine.UIElements.HandleDragAndDropArgs
TYPE:  struct
TOKEN: 0x20001AA
FIELDS:
  private   readonly UnityEngine.UIElements.DragAndDropArgsm_DragAndDropArgs  // 0x10
  private   readonly UnityEngine.Vector2             <position>k__BackingField  // 0x30
METHODS:
  System.Void .ctor(UnityEngine.Vector2 position, UnityEngine.UIElements.DragAndDropArgs dragAndDropArgs)
END_CLASS

CLASS: UnityEngine.UIElements.StartDragArgs
TYPE:  struct
TOKEN: 0x20001AB
FIELDS:
  private   readonly System.String                   <title>k__BackingField  // 0x10
  private   readonly UnityEngine.UIElements.DragVisualMode<visualMode>k__BackingField  // 0x18
  private           System.Collections.Hashtable    <genericData>k__BackingField  // 0x20
  private           System.Collections.Generic.IEnumerable<UnityEngine.Object><unityObjectReferences>k__BackingField  // 0x28
METHODS:
  System.Void .ctor(System.String title, UnityEngine.UIElements.DragVisualMode visualMode)
  System.String get_title()
  UnityEngine.UIElements.DragVisualMode get_visualMode()
  System.Collections.Hashtable get_genericData()
  System.Void set_genericData(System.Collections.Hashtable value)
  System.Collections.Generic.IEnumerable<UnityEngine.Object> get_unityObjectReferences()
  System.Void set_unityObjectReferences(System.Collections.Generic.IEnumerable<UnityEngine.Object> value)
  System.Void SetGenericData(System.String key, System.Object data)
END_CLASS

CLASS: UnityEngine.UIElements.IListDragAndDropArgs
TYPE:  interface
TOKEN: 0x20001AC
FIELDS:
METHODS:
  System.Int32 get_insertAtIndex()
  System.Int32 get_parentId()
  System.Int32 get_childIndex()
  UnityEngine.UIElements.DragAndDropData get_dragAndDropData()
  UnityEngine.UIElements.DragAndDropPosition get_dragAndDropPosition()
END_CLASS

CLASS: UnityEngine.UIElements.DragAndDropArgs
TYPE:  struct
TOKEN: 0x20001AD
FIELDS:
  private           System.Object                   <target>k__BackingField  // 0x10
  private           System.Int32                    <insertAtIndex>k__BackingField  // 0x18
  private           System.Int32                    <parentId>k__BackingField  // 0x1C
  private           System.Int32                    <childIndex>k__BackingField  // 0x20
  private           UnityEngine.UIElements.DragAndDropPosition<dragAndDropPosition>k__BackingField  // 0x24
  private           UnityEngine.UIElements.DragAndDropData<dragAndDropData>k__BackingField  // 0x28
METHODS:
  System.Void set_target(System.Object value)
  System.Int32 get_insertAtIndex()
  System.Void set_insertAtIndex(System.Int32 value)
  System.Int32 get_parentId()
  System.Void set_parentId(System.Int32 value)
  System.Int32 get_childIndex()
  System.Void set_childIndex(System.Int32 value)
  UnityEngine.UIElements.DragAndDropPosition get_dragAndDropPosition()
  System.Void set_dragAndDropPosition(UnityEngine.UIElements.DragAndDropPosition value)
  UnityEngine.UIElements.DragAndDropData get_dragAndDropData()
  System.Void set_dragAndDropData(UnityEngine.UIElements.DragAndDropData value)
END_CLASS

CLASS: UnityEngine.UIElements.DragAndDropPosition
TYPE:  struct
TOKEN: 0x20001AE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DragAndDropPositionOverItem  // 0x0
  public    static  UnityEngine.UIElements.DragAndDropPositionBetweenItems  // 0x0
  public    static  UnityEngine.UIElements.DragAndDropPositionOutsideItems  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IReorderable
TYPE:  interface
TOKEN: 0x20001AF
FIELDS:
METHODS:
  System.Boolean get_enableReordering()
  System.Void set_enableReordering(System.Boolean value)
END_CLASS

CLASS: UnityEngine.UIElements.ListViewDragger
TYPE:  class
TOKEN: 0x20001B0
EXTENDS: DragEventsProcessor
FIELDS:
  private           UnityEngine.UIElements.ListViewDragger.DragPositionm_LastDragPosition  // 0x30
  private           UnityEngine.UIElements.VisualElementm_DragHoverBar  // 0x50
  private           UnityEngine.UIElements.VisualElementm_DragHoverItemMarker  // 0x58
  private           UnityEngine.UIElements.VisualElementm_DragHoverSiblingMarker  // 0x60
  private           System.Single                   m_LeftIndentation  // 0x68
  private           System.Single                   m_SiblingBottom  // 0x6C
  private           UnityEngine.UIElements.ICollectionDragAndDropController<dragAndDropController>k__BackingField  // 0x70
METHODS:
  UnityEngine.UIElements.BaseVerticalCollectionView get_targetView()
  UnityEngine.UIElements.ScrollView get_targetScrollView()
  UnityEngine.UIElements.ICollectionDragAndDropController get_dragAndDropController()
  System.Void set_dragAndDropController(UnityEngine.UIElements.ICollectionDragAndDropController value)
  System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView listView)
  System.Boolean CanStartDrag(UnityEngine.Vector3 pointerPosition)
  UnityEngine.UIElements.StartDragArgs StartDrag(UnityEngine.Vector3 pointerPosition)
  System.Void UpdateDrag(UnityEngine.Vector3 pointerPosition)
  UnityEngine.UIElements.DragVisualMode GetVisualMode(UnityEngine.Vector3 pointerPosition, UnityEngine.UIElements.ListViewDragger.DragPosition& dragPosition)
  System.Void OnDrop(UnityEngine.Vector3 pointerPosition)
  System.Void HandleDragAndScroll(UnityEngine.Vector2 pointerPosition)
  System.Void HandleAutoExpansion(UnityEngine.Vector2 pointerPosition)
  System.Void ApplyDragAndDropUI(UnityEngine.UIElements.ListViewDragger.DragPosition dragPosition)
  System.Boolean TryGetDragPosition(UnityEngine.Vector2 pointerPosition, UnityEngine.UIElements.ListViewDragger.DragPosition& dragPosition)
  System.Void HandleTreePosition(UnityEngine.Vector2 pointerPosition, UnityEngine.UIElements.ListViewDragger.DragPosition& dragPosition)
  System.Void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(UnityEngine.UIElements.ListViewDragger.DragPosition& dragPosition, UnityEngine.Vector2 pointerPosition)
  System.Void GetPreviousAndNextItemsIgnoringDraggedItems(System.Int32 insertAtIndex, System.Int32& previousItemId, System.Int32& nextItemId)
  UnityEngine.UIElements.DragAndDropArgs MakeDragAndDropArgs(UnityEngine.UIElements.ListViewDragger.DragPosition dragPosition)
  System.Single GetHoverBarTopPosition(UnityEngine.UIElements.ReusableCollectionItem item)
  System.Void PlaceHoverBarAtElement(UnityEngine.UIElements.ReusableCollectionItem item)
  System.Void PlaceHoverBarAt(System.Single top, System.Single indentationPadding, System.Single siblingBottom)
  System.Void ClearDragAndDropUI(System.Boolean dragCancelled)
  UnityEngine.UIElements.ReusableCollectionItem GetRecycledItem(UnityEngine.Vector3 pointerPosition)
  System.Void <ApplyDragAndDropUI>g__GeometryChangedCallback|27_0(UnityEngine.UIElements.GeometryChangedEvent e)
END_CLASS

CLASS: UnityEngine.UIElements.ListViewDraggerExtension
TYPE:  class
TOKEN: 0x20001B2
FIELDS:
METHODS:
  UnityEngine.UIElements.ReusableCollectionItem GetRecycledItemFromId(UnityEngine.UIElements.BaseVerticalCollectionView listView, System.Int32 id)
  UnityEngine.UIElements.ReusableCollectionItem GetRecycledItemFromIndex(UnityEngine.UIElements.BaseVerticalCollectionView listView, System.Int32 index)
END_CLASS

CLASS: UnityEngine.UIElements.ListViewDraggerAnimated
TYPE:  class
TOKEN: 0x20001B3
EXTENDS: ListViewDragger
FIELDS:
  private           System.Int32                    m_DragStartIndex  // 0x78
  private           System.Int32                    m_CurrentIndex  // 0x7C
  private           System.Single                   m_SelectionHeight  // 0x80
  private           System.Single                   m_LocalOffsetOnStart  // 0x84
  private           UnityEngine.Vector3             m_CurrentPointerPosition  // 0x88
  private           UnityEngine.UIElements.ReusableCollectionItemm_Item  // 0x98
  private           UnityEngine.UIElements.ReusableCollectionItemm_OffsetItem  // 0xA0
  private           System.Boolean                  <isDragging>k__BackingField  // 0xA8
METHODS:
  System.Boolean get_isDragging()
  System.Void set_isDragging(System.Boolean value)
  UnityEngine.UIElements.ReusableCollectionItem get_draggedItem()
  System.Boolean get_supportsDragEvents()
  System.Void .ctor(UnityEngine.UIElements.BaseVerticalCollectionView listView)
  UnityEngine.UIElements.StartDragArgs StartDrag(UnityEngine.Vector3 pointerPosition)
  System.Void UpdateDrag(UnityEngine.Vector3 pointerPosition)
  System.Void Animate(UnityEngine.UIElements.ReusableCollectionItem element, System.Single paddingTop)
  System.Void OnDrop(UnityEngine.Vector3 pointerPosition)
  System.Void ClearDragAndDropUI(System.Boolean dragCancelled)
  System.Boolean TryGetDragPosition(UnityEngine.Vector2 pointerPosition, UnityEngine.UIElements.ListViewDragger.DragPosition& dragPosition)
END_CLASS

CLASS: UnityEngine.UIElements.ListViewReorderableDragAndDropController
TYPE:  class
TOKEN: 0x20001B4
EXTENDS: BaseReorderableDragAndDropController
FIELDS:
  protected readonly UnityEngine.UIElements.BaseListViewm_ListView  // 0x28
METHODS:
  System.Void .ctor(UnityEngine.UIElements.BaseListView view)
  UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(UnityEngine.UIElements.IListDragAndDropArgs args)
  System.Void OnDrop(UnityEngine.UIElements.IListDragAndDropArgs args)
END_CLASS

CLASS: UnityEngine.UIElements.TreeViewReorderableDragAndDropController
TYPE:  class
TOKEN: 0x20001B5
EXTENDS: BaseReorderableDragAndDropController
FIELDS:
  protected         UnityEngine.UIElements.TreeViewReorderableDragAndDropController.DropDatam_DropData  // 0x28
  protected readonly UnityEngine.UIElements.BaseTreeViewm_TreeView  // 0x30
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_ExpandDropItemScheduledItem  // 0x38
  private           System.Action                   m_ExpandDropItemCallback  // 0x40
METHODS:
  System.Void .ctor(UnityEngine.UIElements.BaseTreeView view)
  System.Int32 CompareId(System.Int32 id1, System.Int32 id2)
  UnityEngine.UIElements.StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIds, System.Boolean skipText)
  UnityEngine.UIElements.DragVisualMode HandleDragAndDrop(UnityEngine.UIElements.IListDragAndDropArgs args)
  System.Void OnDrop(UnityEngine.UIElements.IListDragAndDropArgs args)
  System.Void DragCleanup()
  System.Void RestoreExpanded(System.Collections.Generic.List<System.Int32> ids)
  System.Void HandleAutoExpand(UnityEngine.UIElements.ReusableCollectionItem item, UnityEngine.Vector2 pointerPosition)
  System.Void DelayExpandDropItem()
  System.Void ExpandDropItem()
END_CLASS

CLASS: UnityEngine.UIElements.IPointerCaptureEventInternal
TYPE:  interface
TOKEN: 0x20001B8
FIELDS:
METHODS:
  System.Int32 get_pointerId()
END_CLASS

CLASS: UnityEngine.UIElements.PointerCaptureEventBase`1
TYPE:  class
TOKEN: 0x20001B9
EXTENDS: EventBase`1
FIELDS:
  private           UnityEngine.UIElements.IEventHandler<relatedTarget>k__BackingField  // 0x0
  private           System.Int32                    <pointerId>k__BackingField  // 0x0
METHODS:
  System.Void set_relatedTarget(UnityEngine.UIElements.IEventHandler value)
  System.Int32 get_pointerId()
  System.Void set_pointerId(System.Int32 value)
  System.Void Init()
  System.Void LocalInit()
  T GetPooled(UnityEngine.UIElements.IEventHandler target, UnityEngine.UIElements.IEventHandler relatedTarget, System.Int32 pointerId)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerCaptureOutEvent
TYPE:  class
TOKEN: 0x20001BA
EXTENDS: PointerCaptureEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerCaptureEvent
TYPE:  class
TOKEN: 0x20001BB
EXTENDS: PointerCaptureEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseCaptureEventBase`1
TYPE:  class
TOKEN: 0x20001BC
EXTENDS: PointerCaptureEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseCaptureOutEvent
TYPE:  class
TOKEN: 0x20001BD
EXTENDS: MouseCaptureEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseCaptureEvent
TYPE:  class
TOKEN: 0x20001BE
EXTENDS: MouseCaptureEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ChangeEvent`1
TYPE:  class
TOKEN: 0x20001BF
EXTENDS: EventBase`1
FIELDS:
  private           T                               <previousValue>k__BackingField  // 0x0
  private           T                               <newValue>k__BackingField  // 0x0
METHODS:
  T get_previousValue()
  System.Void set_previousValue(T value)
  T get_newValue()
  System.Void set_newValue(T value)
  System.Void Init()
  System.Void LocalInit()
  UnityEngine.UIElements.ChangeEvent<T> GetPooled(T previousValue, T newValue)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.CommandEventDispatchingStrategy
TYPE:  class
TOKEN: 0x20001C0
FIELDS:
METHODS:
  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ICommandEvent
TYPE:  interface
TOKEN: 0x20001C1
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.CommandEventBase`1
TYPE:  class
TOKEN: 0x20001C2
EXTENDS: EventBase`1
FIELDS:
  private           System.String                   m_CommandName  // 0x0
METHODS:
  System.String get_commandName()
  System.Void set_commandName(System.String value)
  System.Void Init()
  System.Void LocalInit()
  T GetPooled(UnityEngine.Event systemEvent)
  T GetPooled(System.String commandName)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ValidateCommandEvent
TYPE:  class
TOKEN: 0x20001C3
EXTENDS: CommandEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ExecuteCommandEvent
TYPE:  class
TOKEN: 0x20001C4
EXTENDS: CommandEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.DefaultDispatchingStrategy
TYPE:  class
TOKEN: 0x20001C5
FIELDS:
METHODS:
  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ElementUnderPointer
TYPE:  class
TOKEN: 0x20001C6
FIELDS:
  private           UnityEngine.UIElements.VisualElement[]m_PendingTopElementUnderPointer  // 0x10
  private           UnityEngine.UIElements.VisualElement[]m_TopElementUnderPointer  // 0x18
  private           UnityEngine.UIElements.IPointerEvent[]m_TriggerPointerEvent  // 0x20
  private           UnityEngine.UIElements.IMouseEvent[]m_TriggerMouseEvent  // 0x28
  private           UnityEngine.Vector2[]           m_PickingPointerPositions  // 0x30
  private           System.Boolean[]                m_IsPickingPointerTemporaries  // 0x38
METHODS:
  UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(System.Int32 pointerId, UnityEngine.Vector2& pickPosition, System.Boolean& isTemporary)
  UnityEngine.UIElements.VisualElement GetTopElementUnderPointer(System.Int32 pointerId)
  System.Void SetElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, System.Int32 pointerId, UnityEngine.Vector2 pointerPos)
  UnityEngine.Vector2 GetEventPointerPosition(UnityEngine.UIElements.EventBase triggerEvent)
  System.Void SetTemporaryElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, System.Int32 pointerId, UnityEngine.UIElements.EventBase triggerEvent)
  System.Void SetElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, System.Int32 pointerId, UnityEngine.UIElements.EventBase triggerEvent)
  System.Void SetElementUnderPointer(UnityEngine.UIElements.VisualElement newElementUnderPointer, System.Int32 pointerId, UnityEngine.UIElements.EventBase triggerEvent, System.Boolean temporary)
  System.Void CommitElementUnderPointers(UnityEngine.UIElements.EventDispatcher dispatcher, UnityEngine.UIElements.ContextType contextType)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.EventBase
TYPE:  class
TOKEN: 0x20001C7
FIELDS:
  private   static  System.Int64                    s_LastTypeId  // 0x0
  private   static  System.UInt64                   s_NextEventId  // 0x8
  private           System.Int64                    <timestamp>k__BackingField  // 0x10
  private           System.UInt64                   <eventId>k__BackingField  // 0x18
  private           System.UInt64                   <triggerEventId>k__BackingField  // 0x20
  private           UnityEngine.UIElements.EventBase.EventPropagation<propagation>k__BackingField  // 0x28
  private           UnityEngine.UIElements.PropagationPathsm_Path  // 0x30
  private           UnityEngine.UIElements.EventBase.LifeCycleStatus<lifeCycleStatus>k__BackingField  // 0x38
  private           UnityEngine.UIElements.IEventHandler<leafTarget>k__BackingField  // 0x40
  private           UnityEngine.UIElements.IEventHandlerm_Target  // 0x48
  private   readonly System.Collections.Generic.List<UnityEngine.UIElements.IEventHandler><skipElements>k__BackingField  // 0x50
  private           UnityEngine.UIElements.PropagationPhase<propagationPhase>k__BackingField  // 0x58
  private           UnityEngine.UIElements.IEventHandlerm_CurrentTarget  // 0x60
  private           UnityEngine.Event               m_ImguiEvent  // 0x68
  private           UnityEngine.Vector2             <originalMousePosition>k__BackingField  // 0x70
METHODS:
  System.Int64 RegisterEventType()
  System.Int64 get_eventTypeId()
  System.Int64 get_timestamp()
  System.Void set_timestamp(System.Int64 value)
  System.UInt64 get_eventId()
  System.Void set_eventId(System.UInt64 value)
  System.Void set_triggerEventId(System.UInt64 value)
  System.Void SetTriggerEventId(System.UInt64 id)
  UnityEngine.UIElements.EventBase.EventPropagation get_propagation()
  System.Void set_propagation(UnityEngine.UIElements.EventBase.EventPropagation value)
  UnityEngine.UIElements.PropagationPaths get_path()
  System.Void set_path(UnityEngine.UIElements.PropagationPaths value)
  UnityEngine.UIElements.EventBase.LifeCycleStatus get_lifeCycleStatus()
  System.Void set_lifeCycleStatus(UnityEngine.UIElements.EventBase.LifeCycleStatus value)
  System.Void PreDispatch()
  System.Void PreDispatch(UnityEngine.UIElements.IPanel panel)
  System.Void PostDispatch()
  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
  System.Boolean get_bubbles()
  System.Boolean get_tricklesDown()
  System.Boolean get_skipDisabledElements()
  System.Void set_skipDisabledElements(System.Boolean value)
  System.Boolean get_ignoreCompositeRoots()
  System.Void set_ignoreCompositeRoots(System.Boolean value)
  UnityEngine.UIElements.IEventHandler get_leafTarget()
  System.Void set_leafTarget(UnityEngine.UIElements.IEventHandler value)
  UnityEngine.UIElements.IEventHandler get_target()
  System.Void set_target(UnityEngine.UIElements.IEventHandler value)
  System.Collections.Generic.List<UnityEngine.UIElements.IEventHandler> get_skipElements()
  System.Boolean Skip(UnityEngine.UIElements.IEventHandler h)
  System.Boolean get_isPropagationStopped()
  System.Void set_isPropagationStopped(System.Boolean value)
  System.Void StopPropagation()
  System.Boolean get_isImmediatePropagationStopped()
  System.Void set_isImmediatePropagationStopped(System.Boolean value)
  System.Void StopImmediatePropagation()
  System.Boolean get_isDefaultPrevented()
  System.Void set_isDefaultPrevented(System.Boolean value)
  System.Void PreventDefault()
  UnityEngine.UIElements.PropagationPhase get_propagationPhase()
  System.Void set_propagationPhase(UnityEngine.UIElements.PropagationPhase value)
  UnityEngine.UIElements.IEventHandler get_currentTarget()
  System.Void set_currentTarget(UnityEngine.UIElements.IEventHandler value)
  System.Boolean get_dispatch()
  System.Void set_dispatch(System.Boolean value)
  System.Void MarkReceivedByDispatcher()
  System.Boolean get_dispatched()
  System.Void set_dispatched(System.Boolean value)
  System.Boolean get_processed()
  System.Void set_processed(System.Boolean value)
  System.Boolean get_processedByFocusController()
  System.Void set_processedByFocusController(System.Boolean value)
  System.Boolean get_stopDispatch()
  System.Void set_stopDispatch(System.Boolean value)
  System.Boolean get_propagateToIMGUI()
  System.Void set_propagateToIMGUI(System.Boolean value)
  System.Boolean get_imguiEventIsValid()
  System.Void set_imguiEventIsValid(System.Boolean value)
  UnityEngine.Event get_imguiEvent()
  System.Void set_imguiEvent(UnityEngine.Event value)
  UnityEngine.Vector2 get_originalMousePosition()
  System.Void set_originalMousePosition(UnityEngine.Vector2 value)
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
  System.Boolean get_pooled()
  System.Void set_pooled(System.Boolean value)
  System.Void Acquire()
  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.UIElements.EventBase`1
TYPE:  class
TOKEN: 0x20001CA
EXTENDS: EventBase
FIELDS:
  private   static readonly System.Int64                    s_TypeId  // 0x0
  private   static readonly UnityEngine.UIElements.ObjectPool<T>s_Pool  // 0x0
  private           System.Int32                    m_RefCount  // 0x0
METHODS:
  System.Void .ctor()
  System.Int64 TypeId()
  System.Void Init()
  T GetPooled()
  T GetPooled(UnityEngine.UIElements.EventBase e)
  System.Void ReleasePooled(T evt)
  System.Void Acquire()
  System.Void Dispose()
  System.Int64 get_eventTypeId()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.EventCallback`1
TYPE:  class
TOKEN: 0x20001CB
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(TEventType evt)
END_CLASS

CLASS: UnityEngine.UIElements.EventCallbackFunctorBase
TYPE:  class
TOKEN: 0x20001CC
FIELDS:
  private   readonly UnityEngine.UIElements.CallbackPhase<phase>k__BackingField  // 0x10
  private   readonly UnityEngine.UIElements.InvokePolicy<invokePolicy>k__BackingField  // 0x14
METHODS:
  UnityEngine.UIElements.CallbackPhase get_phase()
  UnityEngine.UIElements.InvokePolicy get_invokePolicy()
  System.Void .ctor(UnityEngine.UIElements.CallbackPhase phase, UnityEngine.UIElements.InvokePolicy invokePolicy)
  System.Void Invoke(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPhase propagationPhase)
  System.Boolean IsEquivalentTo(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase)
  System.Boolean PhaseMatches(UnityEngine.UIElements.PropagationPhase propagationPhase)
END_CLASS

CLASS: UnityEngine.UIElements.EventCallbackFunctor`1
TYPE:  class
TOKEN: 0x20001CD
EXTENDS: EventCallbackFunctorBase
FIELDS:
  private   readonly UnityEngine.UIElements.EventCallback<TEventType>m_Callback  // 0x0
  private   readonly System.Int64                    m_EventTypeId  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.CallbackPhase phase, UnityEngine.UIElements.InvokePolicy invokePolicy)
  System.Void Invoke(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPhase propagationPhase)
  System.Boolean IsEquivalentTo(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase)
END_CLASS

CLASS: UnityEngine.UIElements.TrickleDown
TYPE:  struct
TOKEN: 0x20001CE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.TrickleDownNoTrickleDown  // 0x0
  public    static  UnityEngine.UIElements.TrickleDownTrickleDown  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.CallbackPhase
TYPE:  struct
TOKEN: 0x20001CF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.CallbackPhaseTargetAndBubbleUp  // 0x0
  public    static  UnityEngine.UIElements.CallbackPhaseTrickleDownAndTarget  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.InvokePolicy
TYPE:  struct
TOKEN: 0x20001D0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.InvokePolicyDefault  // 0x0
  public    static  UnityEngine.UIElements.InvokePolicyIncludeDisabled  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.EventCallbackListPool
TYPE:  class
TOKEN: 0x20001D1
FIELDS:
  private   readonly System.Collections.Generic.Stack<UnityEngine.UIElements.EventCallbackList>m_Stack  // 0x10
METHODS:
  UnityEngine.UIElements.EventCallbackList Get(UnityEngine.UIElements.EventCallbackList initializer)
  System.Void Release(UnityEngine.UIElements.EventCallbackList element)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.EventCallbackList
TYPE:  class
TOKEN: 0x20001D2
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.EventCallbackFunctorBase>m_List  // 0x10
  private           System.Int32                    <trickleDownCallbackCount>k__BackingField  // 0x18
  private           System.Int32                    <bubbleUpCallbackCount>k__BackingField  // 0x1C
METHODS:
  System.Int32 get_trickleDownCallbackCount()
  System.Void set_trickleDownCallbackCount(System.Int32 value)
  System.Int32 get_bubbleUpCallbackCount()
  System.Void set_bubbleUpCallbackCount(System.Int32 value)
  System.Void .ctor()
  System.Void .ctor(UnityEngine.UIElements.EventCallbackList source)
  System.Boolean Contains(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase)
  UnityEngine.UIElements.EventCallbackFunctorBase Find(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase)
  System.Boolean Remove(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.CallbackPhase phase)
  System.Void Add(UnityEngine.UIElements.EventCallbackFunctorBase item)
  System.Void AddRange(UnityEngine.UIElements.EventCallbackList list)
  System.Int32 get_Count()
  UnityEngine.UIElements.EventCallbackFunctorBase get_Item(System.Int32 i)
  System.Void Clear()
END_CLASS

CLASS: UnityEngine.UIElements.EventCallbackRegistry
TYPE:  class
TOKEN: 0x20001D3
FIELDS:
  private   static readonly UnityEngine.UIElements.EventCallbackListPools_ListPool  // 0x0
  private           UnityEngine.UIElements.EventCallbackListm_Callbacks  // 0x10
  private           UnityEngine.UIElements.EventCallbackListm_TemporaryCallbacks  // 0x18
  private           System.Int32                    m_IsInvoking  // 0x20
METHODS:
  UnityEngine.UIElements.EventCallbackList GetCallbackList(UnityEngine.UIElements.EventCallbackList initializer)
  System.Void ReleaseCallbackList(UnityEngine.UIElements.EventCallbackList toRelease)
  System.Void .ctor()
  UnityEngine.UIElements.EventCallbackList GetCallbackListForWriting()
  UnityEngine.UIElements.EventCallbackList GetCallbackListForReading()
  System.Boolean UnregisterCallback(System.Int64 eventTypeId, System.Delegate callback, UnityEngine.UIElements.TrickleDown useTrickleDown)
  System.Void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown, UnityEngine.UIElements.InvokePolicy invokePolicy)
  System.Boolean UnregisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown)
  System.Void InvokeCallbacks(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPhase propagationPhase)
  System.Boolean HasTrickleDownHandlers()
  System.Boolean HasBubbleHandlers()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.IEventHandler
TYPE:  interface
TOKEN: 0x20001D4
FIELDS:
METHODS:
  System.Void SendEvent(UnityEngine.UIElements.EventBase e)
  System.Void HandleEvent(UnityEngine.UIElements.EventBase evt)
END_CLASS

CLASS: UnityEngine.UIElements.CallbackEventHandler
TYPE:  class
TOKEN: 0x20001D5
FIELDS:
  private           System.Boolean                  isIMGUIContainer  // 0x10
  private           UnityEngine.UIElements.EventCallbackRegistrym_CallbackRegistry  // 0x18
METHODS:
  System.Void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown)
  System.Void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.InvokePolicy invokePolicy, UnityEngine.UIElements.TrickleDown useTrickleDown)
  System.Void UnregisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, UnityEngine.UIElements.TrickleDown useTrickleDown)
  System.Void SendEvent(UnityEngine.UIElements.EventBase e)
  System.Void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.UIElements.DispatchMode dispatchMode)
  System.Void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase evt)
  System.Void HandleEventAtTargetAndDefaultPhase(UnityEngine.UIElements.EventBase evt)
  System.Void HandleEventAtCurrentTargetAndPhase(UnityEngine.UIElements.EventBase evt)
  System.Void UnityEngine.UIElements.IEventHandler.HandleEvent(UnityEngine.UIElements.EventBase evt)
  System.Void HandleEvent(UnityEngine.UIElements.EventBase evt)
  System.Boolean HasTrickleDownHandlers()
  System.Boolean HasBubbleUpHandlers()
  System.Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase evt)
  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt)
  System.Void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase evt)
  System.Void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase evt)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.FocusEventBase`1
TYPE:  class
TOKEN: 0x20001D6
EXTENDS: EventBase`1
FIELDS:
  private           UnityEngine.UIElements.Focusable<relatedTarget>k__BackingField  // 0x0
  private           UnityEngine.UIElements.FocusChangeDirection<direction>k__BackingField  // 0x0
  private           UnityEngine.UIElements.FocusController<focusController>k__BackingField  // 0x0
  private           System.Boolean                  <IsFocusDelegated>k__BackingField  // 0x0
METHODS:
  UnityEngine.UIElements.Focusable get_relatedTarget()
  System.Void set_relatedTarget(UnityEngine.UIElements.Focusable value)
  UnityEngine.UIElements.FocusChangeDirection get_direction()
  System.Void set_direction(UnityEngine.UIElements.FocusChangeDirection value)
  UnityEngine.UIElements.FocusController get_focusController()
  System.Void set_focusController(UnityEngine.UIElements.FocusController value)
  System.Boolean get_IsFocusDelegated()
  System.Void set_IsFocusDelegated(System.Boolean value)
  System.Void Init()
  System.Void LocalInit()
  T GetPooled(UnityEngine.UIElements.IEventHandler target, UnityEngine.UIElements.Focusable relatedTarget, UnityEngine.UIElements.FocusChangeDirection direction, UnityEngine.UIElements.FocusController focusController, System.Boolean bIsFocusDelegated)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.FocusOutEvent
TYPE:  class
TOKEN: 0x20001D7
EXTENDS: FocusEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.BlurEvent
TYPE:  class
TOKEN: 0x20001D8
EXTENDS: FocusEventBase`1
FIELDS:
METHODS:
  System.Void PreDispatch(UnityEngine.UIElements.IPanel panel)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.FocusInEvent
TYPE:  class
TOKEN: 0x20001D9
EXTENDS: FocusEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.FocusEvent
TYPE:  class
TOKEN: 0x20001DA
EXTENDS: FocusEventBase`1
FIELDS:
METHODS:
  System.Void PreDispatch(UnityEngine.UIElements.IPanel panel)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PropagationPhase
TYPE:  struct
TOKEN: 0x20001DB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.PropagationPhaseNone  // 0x0
  public    static  UnityEngine.UIElements.PropagationPhaseTrickleDown  // 0x0
  public    static  UnityEngine.UIElements.PropagationPhaseAtTarget  // 0x0
  public    static  UnityEngine.UIElements.PropagationPhaseDefaultActionAtTarget  // 0x0
  public    static  UnityEngine.UIElements.PropagationPhaseBubbleUp  // 0x0
  public    static  UnityEngine.UIElements.PropagationPhaseDefaultAction  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IEventDispatchingStrategy
TYPE:  interface
TOKEN: 0x20001DC
FIELDS:
METHODS:
  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.EventDispatchUtilities
TYPE:  class
TOKEN: 0x20001DD
FIELDS:
METHODS:
  System.Void PropagateEvent(UnityEngine.UIElements.EventBase evt)
  System.Void PropagateToIMGUIContainer(UnityEngine.UIElements.VisualElement root, UnityEngine.UIElements.EventBase evt)
  System.Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.IMGUIEventDispatchingStrategy
TYPE:  class
TOKEN: 0x20001DE
FIELDS:
METHODS:
  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.InputEvent
TYPE:  class
TOKEN: 0x20001DF
EXTENDS: EventBase`1
FIELDS:
  private           System.String                   <previousData>k__BackingField  // 0x80
  private           System.String                   <newData>k__BackingField  // 0x88
METHODS:
  System.Void set_previousData(System.String value)
  System.Void set_newData(System.String value)
  System.Void Init()
  System.Void LocalInit()
  UnityEngine.UIElements.InputEvent GetPooled(System.String previousData, System.String newData)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.KeyboardEventDispatchingStrategy
TYPE:  class
TOKEN: 0x20001E0
FIELDS:
METHODS:
  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.IKeyboardEvent
TYPE:  interface
TOKEN: 0x20001E1
FIELDS:
METHODS:
  UnityEngine.EventModifiers get_modifiers()
  System.Char get_character()
  UnityEngine.KeyCode get_keyCode()
END_CLASS

CLASS: UnityEngine.UIElements.KeyboardEventBase`1
TYPE:  class
TOKEN: 0x20001E2
EXTENDS: EventBase`1
FIELDS:
  private           UnityEngine.EventModifiers      <modifiers>k__BackingField  // 0x0
  private           System.Char                     <character>k__BackingField  // 0x0
  private           UnityEngine.KeyCode             <keyCode>k__BackingField  // 0x0
METHODS:
  UnityEngine.EventModifiers get_modifiers()
  System.Void set_modifiers(UnityEngine.EventModifiers value)
  System.Char get_character()
  System.Void set_character(System.Char value)
  UnityEngine.KeyCode get_keyCode()
  System.Void set_keyCode(UnityEngine.KeyCode value)
  System.Boolean get_shiftKey()
  System.Boolean get_ctrlKey()
  System.Boolean get_commandKey()
  System.Boolean get_altKey()
  System.Boolean get_actionKey()
  System.Void Init()
  System.Void LocalInit()
  T GetPooled(System.Char c, UnityEngine.KeyCode keyCode, UnityEngine.EventModifiers modifiers)
  T GetPooled(UnityEngine.Event systemEvent)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.KeyDownEvent
TYPE:  class
TOKEN: 0x20001E3
EXTENDS: KeyboardEventBase`1
FIELDS:
METHODS:
  System.Void GetEquivalentImguiEvent(UnityEngine.Event outImguiEvent)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.KeyUpEvent
TYPE:  class
TOKEN: 0x20001E4
EXTENDS: KeyboardEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.GeometryChangedEvent
TYPE:  class
TOKEN: 0x20001E5
EXTENDS: EventBase`1
FIELDS:
  private           UnityEngine.Rect                <oldRect>k__BackingField  // 0x80
  private           UnityEngine.Rect                <newRect>k__BackingField  // 0x90
  private           System.Int32                    <layoutPass>k__BackingField  // 0xA0
METHODS:
  UnityEngine.UIElements.GeometryChangedEvent GetPooled(UnityEngine.Rect oldRect, UnityEngine.Rect newRect)
  System.Void Init()
  System.Void LocalInit()
  UnityEngine.Rect get_oldRect()
  System.Void set_oldRect(UnityEngine.Rect value)
  UnityEngine.Rect get_newRect()
  System.Void set_newRect(UnityEngine.Rect value)
  System.Int32 get_layoutPass()
  System.Void set_layoutPass(System.Int32 value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseCaptureDispatchingStrategy
TYPE:  class
TOKEN: 0x20001E6
FIELDS:
METHODS:
  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseEventDispatchingStrategy
TYPE:  class
TOKEN: 0x20001E8
FIELDS:
METHODS:
  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel iPanel)
  System.Boolean SendEventToTarget(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel)
  System.Boolean SendEventToRegularTarget(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel)
  System.Boolean SendEventToIMGUIContainer(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel)
  System.Void SetBestTargetForEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel)
  System.Void UpdateElementUnderMouse(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.BaseVisualElementPanel panel, UnityEngine.UIElements.VisualElement& elementUnderMouse)
  System.Boolean IsDone(UnityEngine.UIElements.EventBase evt)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.IMouseEvent
TYPE:  interface
TOKEN: 0x20001E9
FIELDS:
METHODS:
  UnityEngine.EventModifiers get_modifiers()
  UnityEngine.Vector2 get_mousePosition()
  UnityEngine.Vector2 get_localMousePosition()
  UnityEngine.Vector2 get_mouseDelta()
  System.Int32 get_clickCount()
  System.Int32 get_button()
  System.Int32 get_pressedButtons()
  System.Boolean get_shiftKey()
  System.Boolean get_ctrlKey()
  System.Boolean get_commandKey()
  System.Boolean get_altKey()
END_CLASS

CLASS: UnityEngine.UIElements.IMouseEventInternal
TYPE:  interface
TOKEN: 0x20001EA
FIELDS:
METHODS:
  System.Boolean get_triggeredByOS()
  System.Void set_triggeredByOS(System.Boolean value)
  System.Boolean get_recomputeTopElementUnderMouse()
  System.Void set_recomputeTopElementUnderMouse(System.Boolean value)
  UnityEngine.UIElements.IPointerEvent get_sourcePointerEvent()
  System.Void set_sourcePointerEvent(UnityEngine.UIElements.IPointerEvent value)
END_CLASS

CLASS: UnityEngine.UIElements.MouseEventBase`1
TYPE:  class
TOKEN: 0x20001EB
EXTENDS: EventBase`1
FIELDS:
  private           UnityEngine.EventModifiers      <modifiers>k__BackingField  // 0x0
  private           UnityEngine.Vector2             <mousePosition>k__BackingField  // 0x0
  private           UnityEngine.Vector2             <localMousePosition>k__BackingField  // 0x0
  private           UnityEngine.Vector2             <mouseDelta>k__BackingField  // 0x0
  private           System.Int32                    <clickCount>k__BackingField  // 0x0
  private           System.Int32                    <button>k__BackingField  // 0x0
  private           System.Int32                    <pressedButtons>k__BackingField  // 0x0
  private           System.Boolean                  <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField  // 0x0
  private           System.Boolean                  <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField  // 0x0
  private           UnityEngine.UIElements.IPointerEvent<UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField  // 0x0
METHODS:
  UnityEngine.EventModifiers get_modifiers()
  System.Void set_modifiers(UnityEngine.EventModifiers value)
  UnityEngine.Vector2 get_mousePosition()
  System.Void set_mousePosition(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_localMousePosition()
  System.Void set_localMousePosition(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_mouseDelta()
  System.Void set_mouseDelta(UnityEngine.Vector2 value)
  System.Int32 get_clickCount()
  System.Void set_clickCount(System.Int32 value)
  System.Int32 get_button()
  System.Void set_button(System.Int32 value)
  System.Int32 get_pressedButtons()
  System.Void set_pressedButtons(System.Int32 value)
  System.Boolean get_shiftKey()
  System.Boolean get_ctrlKey()
  System.Boolean get_commandKey()
  System.Boolean get_altKey()
  System.Boolean UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS()
  System.Void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(System.Boolean value)
  System.Boolean UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse()
  System.Void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(System.Boolean value)
  UnityEngine.UIElements.IPointerEvent UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent()
  System.Void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(UnityEngine.UIElements.IPointerEvent value)
  System.Void Init()
  System.Void LocalInit()
  UnityEngine.UIElements.IEventHandler get_currentTarget()
  System.Void set_currentTarget(UnityEngine.UIElements.IEventHandler value)
  System.Void PreDispatch(UnityEngine.UIElements.IPanel panel)
  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
  T GetPooled(UnityEngine.Event systemEvent)
  T GetPooled(UnityEngine.UIElements.IMouseEvent triggerEvent, UnityEngine.Vector2 mousePosition, System.Boolean recomputeTopElementUnderMouse)
  T GetPooled(UnityEngine.UIElements.IMouseEvent triggerEvent)
  T GetPooled(UnityEngine.UIElements.IPointerEvent pointerEvent)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseDownEvent
TYPE:  class
TOKEN: 0x20001EC
EXTENDS: MouseEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
  UnityEngine.UIElements.MouseDownEvent MakeFromPointerEvent(UnityEngine.UIElements.IPointerEvent pointerEvent)
  UnityEngine.UIElements.MouseDownEvent GetPooled(UnityEngine.UIElements.PointerDownEvent pointerEvent)
  UnityEngine.UIElements.MouseDownEvent GetPooled(UnityEngine.UIElements.PointerMoveEvent pointerEvent)
END_CLASS

CLASS: UnityEngine.UIElements.MouseUpEvent
TYPE:  class
TOKEN: 0x20001ED
EXTENDS: MouseEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
  UnityEngine.UIElements.MouseUpEvent MakeFromPointerEvent(UnityEngine.UIElements.IPointerEvent pointerEvent)
  UnityEngine.UIElements.MouseUpEvent GetPooled(UnityEngine.UIElements.PointerUpEvent pointerEvent)
  UnityEngine.UIElements.MouseUpEvent GetPooled(UnityEngine.UIElements.PointerMoveEvent pointerEvent)
  UnityEngine.UIElements.MouseUpEvent GetPooled(UnityEngine.UIElements.PointerCancelEvent pointerEvent)
END_CLASS

CLASS: UnityEngine.UIElements.MouseMoveEvent
TYPE:  class
TOKEN: 0x20001EE
EXTENDS: MouseEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
  UnityEngine.UIElements.MouseMoveEvent GetPooled(UnityEngine.UIElements.PointerMoveEvent pointerEvent)
END_CLASS

CLASS: UnityEngine.UIElements.ContextClickEvent
TYPE:  class
TOKEN: 0x20001EF
EXTENDS: MouseEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.WheelEvent
TYPE:  class
TOKEN: 0x20001F0
EXTENDS: MouseEventBase`1
FIELDS:
  private           UnityEngine.Vector3             <delta>k__BackingField  // 0xB8
METHODS:
  UnityEngine.Vector3 get_delta()
  System.Void set_delta(UnityEngine.Vector3 value)
  UnityEngine.UIElements.WheelEvent GetPooled(UnityEngine.Event systemEvent)
  UnityEngine.UIElements.WheelEvent GetPooled(UnityEngine.Vector3 delta, UnityEngine.UIElements.IPointerEvent pointerEvent)
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseEnterEvent
TYPE:  class
TOKEN: 0x20001F1
EXTENDS: MouseEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseLeaveEvent
TYPE:  class
TOKEN: 0x20001F2
EXTENDS: MouseEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseEnterWindowEvent
TYPE:  class
TOKEN: 0x20001F3
EXTENDS: MouseEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.MouseLeaveWindowEvent
TYPE:  class
TOKEN: 0x20001F4
EXTENDS: MouseEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
  UnityEngine.UIElements.MouseLeaveWindowEvent GetPooled(UnityEngine.Event systemEvent)
  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.MouseOverEvent
TYPE:  class
TOKEN: 0x20001F5
EXTENDS: MouseEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.MouseOutEvent
TYPE:  class
TOKEN: 0x20001F6
EXTENDS: MouseEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.ContextualMenuPopulateEvent
TYPE:  class
TOKEN: 0x20001F7
EXTENDS: MouseEventBase`1
FIELDS:
  private           UnityEngine.UIElements.DropdownMenu<menu>k__BackingField  // 0xB8
  private           UnityEngine.UIElements.EventBase<triggerEvent>k__BackingField  // 0xC0
  private           UnityEngine.UIElements.ContextualMenuManagerm_ContextualMenuManager  // 0xC8
METHODS:
  UnityEngine.UIElements.DropdownMenu get_menu()
  System.Void set_menu(UnityEngine.UIElements.DropdownMenu value)
  UnityEngine.UIElements.EventBase get_triggerEvent()
  System.Void set_triggerEvent(UnityEngine.UIElements.EventBase value)
  UnityEngine.UIElements.ContextualMenuPopulateEvent GetPooled(UnityEngine.UIElements.EventBase triggerEvent, UnityEngine.UIElements.DropdownMenu menu, UnityEngine.UIElements.IEventHandler target, UnityEngine.UIElements.ContextualMenuManager menuManager)
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.MouseEventsHelper
TYPE:  class
TOKEN: 0x20001F8
FIELDS:
METHODS:
  System.Void SendEnterLeave(UnityEngine.UIElements.VisualElement previousTopElementUnderMouse, UnityEngine.UIElements.VisualElement currentTopElementUnderMouse, UnityEngine.UIElements.IMouseEvent triggerEvent, UnityEngine.Vector2 mousePosition)
  System.Void SendMouseOverMouseOut(UnityEngine.UIElements.VisualElement previousTopElementUnderMouse, UnityEngine.UIElements.VisualElement currentTopElementUnderMouse, UnityEngine.UIElements.IMouseEvent triggerEvent, UnityEngine.Vector2 mousePosition)
END_CLASS

CLASS: UnityEngine.UIElements.PointerEventsHelper
TYPE:  class
TOKEN: 0x20001F9
FIELDS:
METHODS:
  System.Void SendEnterLeave(UnityEngine.UIElements.VisualElement previousTopElementUnderPointer, UnityEngine.UIElements.VisualElement currentTopElementUnderPointer, UnityEngine.UIElements.IPointerEvent triggerEvent, UnityEngine.Vector2 position, System.Int32 pointerId)
  System.Void SendOverOut(UnityEngine.UIElements.VisualElement previousTopElementUnderPointer, UnityEngine.UIElements.VisualElement currentTopElementUnderPointer, UnityEngine.UIElements.IPointerEvent triggerEvent, UnityEngine.Vector2 position, System.Int32 pointerId)
END_CLASS

CLASS: UnityEngine.UIElements.NavigationEventDispatchingStrategy
TYPE:  class
TOKEN: 0x20001FA
FIELDS:
METHODS:
  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.INavigationEvent
TYPE:  interface
TOKEN: 0x20001FB
FIELDS:
METHODS:
  System.Boolean get_shiftKey()
  System.Boolean get_altKey()
END_CLASS

CLASS: UnityEngine.UIElements.NavigationDeviceType
TYPE:  struct
TOKEN: 0x20001FC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.NavigationDeviceTypeUnknown  // 0x0
  public    static  UnityEngine.UIElements.NavigationDeviceTypeKeyboard  // 0x0
  public    static  UnityEngine.UIElements.NavigationDeviceTypeNonKeyboard  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.NavigationEventBase`1
TYPE:  class
TOKEN: 0x20001FD
EXTENDS: EventBase`1
FIELDS:
  private           UnityEngine.EventModifiers      <modifiers>k__BackingField  // 0x0
  private           UnityEngine.UIElements.NavigationDeviceType<deviceType>k__BackingField  // 0x0
METHODS:
  UnityEngine.EventModifiers get_modifiers()
  System.Void set_modifiers(UnityEngine.EventModifiers value)
  System.Boolean get_shiftKey()
  System.Boolean get_altKey()
  System.Void set_deviceType(UnityEngine.UIElements.NavigationDeviceType value)
  System.Void .ctor()
  System.Void Init()
  System.Void LocalInit()
  T GetPooled(UnityEngine.EventModifiers modifiers)
  T GetPooled(UnityEngine.UIElements.NavigationDeviceType deviceType, UnityEngine.EventModifiers modifiers)
END_CLASS

CLASS: UnityEngine.UIElements.NavigationMoveEvent
TYPE:  class
TOKEN: 0x20001FE
EXTENDS: NavigationEventBase`1
FIELDS:
  private           UnityEngine.UIElements.NavigationMoveEvent.Direction<direction>k__BackingField  // 0x88
  private           UnityEngine.Vector2             <move>k__BackingField  // 0x8C
METHODS:
  UnityEngine.UIElements.NavigationMoveEvent.Direction DetermineMoveDirection(System.Single x, System.Single y, System.Single deadZone)
  UnityEngine.UIElements.NavigationMoveEvent.Direction get_direction()
  System.Void set_direction(UnityEngine.UIElements.NavigationMoveEvent.Direction value)
  System.Void set_move(UnityEngine.Vector2 value)
  UnityEngine.UIElements.NavigationMoveEvent GetPooled(UnityEngine.Vector2 moveVector, UnityEngine.EventModifiers modifiers)
  System.Void Init()
  System.Void .ctor()
  System.Void LocalInit()
END_CLASS

CLASS: UnityEngine.UIElements.NavigationTabEvent
TYPE:  class
TOKEN: 0x2000200
EXTENDS: NavigationEventBase`1
FIELDS:
  private           UnityEngine.UIElements.NavigationTabEvent.Direction<direction>k__BackingField  // 0x88
METHODS:
  System.Void set_direction(UnityEngine.UIElements.NavigationTabEvent.Direction value)
  UnityEngine.UIElements.NavigationTabEvent.Direction DetermineMoveDirection(System.Int32 moveValue)
  UnityEngine.UIElements.NavigationTabEvent GetPooled(System.Int32 moveValue)
  System.Void Init()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.NavigationCancelEvent
TYPE:  class
TOKEN: 0x2000202
EXTENDS: NavigationEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.NavigationSubmitEvent
TYPE:  class
TOKEN: 0x2000203
EXTENDS: NavigationEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PanelChangedEventBase`1
TYPE:  class
TOKEN: 0x2000204
EXTENDS: EventBase`1
FIELDS:
  private           UnityEngine.UIElements.IPanel   <originPanel>k__BackingField  // 0x0
  private           UnityEngine.UIElements.IPanel   <destinationPanel>k__BackingField  // 0x0
METHODS:
  UnityEngine.UIElements.IPanel get_originPanel()
  System.Void set_originPanel(UnityEngine.UIElements.IPanel value)
  UnityEngine.UIElements.IPanel get_destinationPanel()
  System.Void set_destinationPanel(UnityEngine.UIElements.IPanel value)
  System.Void Init()
  System.Void LocalInit()
  T GetPooled(UnityEngine.UIElements.IPanel originPanel, UnityEngine.UIElements.IPanel destinationPanel)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.AttachToPanelEvent
TYPE:  class
TOKEN: 0x2000205
EXTENDS: PanelChangedEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.DetachFromPanelEvent
TYPE:  class
TOKEN: 0x2000206
EXTENDS: PanelChangedEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerCaptureDispatchingStrategy
TYPE:  class
TOKEN: 0x2000207
FIELDS:
METHODS:
  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerDeviceState
TYPE:  class
TOKEN: 0x2000208
FIELDS:
  private   static  UnityEngine.UIElements.PointerDeviceState.PointerLocation[]s_PlayerPointerLocations  // 0x0
  private   static  System.Int32[]                  s_PressedButtons  // 0x8
  private   static readonly UnityEngine.UIElements.IPanel[] s_PlayerPanelWithSoftPointerCapture  // 0x10
METHODS:
  System.Void RemovePanelData(UnityEngine.UIElements.IPanel panel)
  System.Void SavePointerPosition(System.Int32 pointerId, UnityEngine.Vector2 position, UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.ContextType contextType)
  System.Void PressButton(System.Int32 pointerId, System.Int32 buttonId)
  System.Void ReleaseButton(System.Int32 pointerId, System.Int32 buttonId)
  System.Void ReleaseAllButtons(System.Int32 pointerId)
  UnityEngine.Vector2 GetPointerPosition(System.Int32 pointerId, UnityEngine.UIElements.ContextType contextType)
  UnityEngine.UIElements.IPanel GetPanel(System.Int32 pointerId, UnityEngine.UIElements.ContextType contextType)
  System.Boolean HasFlagFast(UnityEngine.UIElements.PointerDeviceState.LocationFlag flagSet, UnityEngine.UIElements.PointerDeviceState.LocationFlag flag)
  System.Boolean HasLocationFlag(System.Int32 pointerId, UnityEngine.UIElements.ContextType contextType, UnityEngine.UIElements.PointerDeviceState.LocationFlag flag)
  System.Int32 GetPressedButtons(System.Int32 pointerId)
  System.Boolean HasAdditionalPressedButtons(System.Int32 pointerId, System.Int32 exceptButtonId)
  System.Void SetPlayerPanelWithSoftPointerCapture(System.Int32 pointerId, UnityEngine.UIElements.IPanel panel)
  UnityEngine.UIElements.IPanel GetPlayerPanelWithSoftPointerCapture(System.Int32 pointerId)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerEventDispatchingStrategy
TYPE:  class
TOKEN: 0x200020B
FIELDS:
METHODS:
  System.Boolean CanDispatchEvent(UnityEngine.UIElements.EventBase evt)
  System.Void DispatchEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  System.Void SendEventToTarget(UnityEngine.UIElements.EventBase evt)
  System.Void SetBestTargetForEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel)
  System.Void UpdateElementUnderPointer(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.IPanel panel, UnityEngine.UIElements.VisualElement& elementUnderPointer)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerType
TYPE:  class
TOKEN: 0x200020C
FIELDS:
  public    static readonly System.String                   mouse  // 0x0
  public    static readonly System.String                   touch  // 0x8
  public    static readonly System.String                   pen  // 0x10
  public    static readonly System.String                   unknown  // 0x18
METHODS:
  System.String GetPointerType(System.Int32 pointerId)
  System.Boolean IsDirectManipulationDevice(System.String pointerType)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerId
TYPE:  class
TOKEN: 0x200020D
FIELDS:
  public    static readonly System.Int32                    maxPointers  // 0x0
  public    static readonly System.Int32                    invalidPointerId  // 0x4
  public    static readonly System.Int32                    mousePointerId  // 0x8
  public    static readonly System.Int32                    touchPointerIdBase  // 0xC
  public    static readonly System.Int32                    touchPointerCount  // 0x10
  public    static readonly System.Int32                    penPointerIdBase  // 0x14
  public    static readonly System.Int32                    penPointerCount  // 0x18
  private   static readonly System.Int32[]                  hoveringPointers  // 0x20
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.IPointerEvent
TYPE:  interface
TOKEN: 0x200020E
FIELDS:
METHODS:
  System.Int32 get_pointerId()
  System.String get_pointerType()
  System.Boolean get_isPrimary()
  System.Int32 get_button()
  System.Int32 get_pressedButtons()
  UnityEngine.Vector3 get_position()
  UnityEngine.Vector3 get_localPosition()
  UnityEngine.Vector3 get_deltaPosition()
  System.Single get_deltaTime()
  System.Int32 get_clickCount()
  System.Single get_pressure()
  System.Single get_tangentialPressure()
  System.Single get_altitudeAngle()
  System.Single get_azimuthAngle()
  System.Single get_twist()
  UnityEngine.Vector2 get_radius()
  UnityEngine.Vector2 get_radiusVariance()
  UnityEngine.EventModifiers get_modifiers()
  System.Boolean get_shiftKey()
  System.Boolean get_ctrlKey()
  System.Boolean get_commandKey()
  System.Boolean get_altKey()
  System.Boolean get_actionKey()
END_CLASS

CLASS: UnityEngine.UIElements.IPointerEventInternal
TYPE:  interface
TOKEN: 0x200020F
FIELDS:
METHODS:
  System.Boolean get_triggeredByOS()
  System.Void set_triggeredByOS(System.Boolean value)
  System.Boolean get_recomputeTopElementUnderPointer()
  System.Void set_recomputeTopElementUnderPointer(System.Boolean value)
END_CLASS

CLASS: UnityEngine.UIElements.PointerEventBase`1
TYPE:  class
TOKEN: 0x2000210
EXTENDS: EventBase`1
FIELDS:
  private           System.Int32                    <pointerId>k__BackingField  // 0x0
  private           System.String                   <pointerType>k__BackingField  // 0x0
  private           System.Boolean                  <isPrimary>k__BackingField  // 0x0
  private           System.Int32                    <button>k__BackingField  // 0x0
  private           System.Int32                    <pressedButtons>k__BackingField  // 0x0
  private           UnityEngine.Vector3             <position>k__BackingField  // 0x0
  private           UnityEngine.Vector3             <localPosition>k__BackingField  // 0x0
  private           UnityEngine.Vector3             <deltaPosition>k__BackingField  // 0x0
  private           System.Single                   <deltaTime>k__BackingField  // 0x0
  private           System.Int32                    <clickCount>k__BackingField  // 0x0
  private           System.Single                   <pressure>k__BackingField  // 0x0
  private           System.Single                   <tangentialPressure>k__BackingField  // 0x0
  private           System.Single                   <altitudeAngle>k__BackingField  // 0x0
  private           System.Single                   <azimuthAngle>k__BackingField  // 0x0
  private           System.Single                   <twist>k__BackingField  // 0x0
  private           UnityEngine.Vector2             <radius>k__BackingField  // 0x0
  private           UnityEngine.Vector2             <radiusVariance>k__BackingField  // 0x0
  private           UnityEngine.EventModifiers      <modifiers>k__BackingField  // 0x0
  private           System.Boolean                  <UnityEngine.UIElements.IPointerEventInternal.triggeredByOS>k__BackingField  // 0x0
  private           System.Boolean                  <UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer>k__BackingField  // 0x0
METHODS:
  System.Int32 get_pointerId()
  System.Void set_pointerId(System.Int32 value)
  System.String get_pointerType()
  System.Void set_pointerType(System.String value)
  System.Boolean get_isPrimary()
  System.Void set_isPrimary(System.Boolean value)
  System.Int32 get_button()
  System.Void set_button(System.Int32 value)
  System.Int32 get_pressedButtons()
  System.Void set_pressedButtons(System.Int32 value)
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_localPosition()
  System.Void set_localPosition(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_deltaPosition()
  System.Void set_deltaPosition(UnityEngine.Vector3 value)
  System.Single get_deltaTime()
  System.Void set_deltaTime(System.Single value)
  System.Int32 get_clickCount()
  System.Void set_clickCount(System.Int32 value)
  System.Single get_pressure()
  System.Void set_pressure(System.Single value)
  System.Single get_tangentialPressure()
  System.Void set_tangentialPressure(System.Single value)
  System.Single get_altitudeAngle()
  System.Void set_altitudeAngle(System.Single value)
  System.Single get_azimuthAngle()
  System.Void set_azimuthAngle(System.Single value)
  System.Single get_twist()
  System.Void set_twist(System.Single value)
  UnityEngine.Vector2 get_radius()
  System.Void set_radius(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_radiusVariance()
  System.Void set_radiusVariance(UnityEngine.Vector2 value)
  UnityEngine.EventModifiers get_modifiers()
  System.Void set_modifiers(UnityEngine.EventModifiers value)
  System.Boolean get_shiftKey()
  System.Boolean get_ctrlKey()
  System.Boolean get_commandKey()
  System.Boolean get_altKey()
  System.Boolean get_actionKey()
  System.Boolean UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS()
  System.Void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(System.Boolean value)
  System.Boolean UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer()
  System.Void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(System.Boolean value)
  System.Void Init()
  System.Void LocalInit()
  UnityEngine.UIElements.IEventHandler get_currentTarget()
  System.Void set_currentTarget(UnityEngine.UIElements.IEventHandler value)
  System.Boolean IsMouse(UnityEngine.Event systemEvent)
  T GetPooled(UnityEngine.Event systemEvent)
  T GetPooled(UnityEngine.Touch touch, UnityEngine.EventModifiers modifiers)
  T GetPooled(UnityEngine.UIElements.IPointerEvent triggerEvent, UnityEngine.Vector2 position, System.Int32 pointerId)
  T GetPooled(UnityEngine.UIElements.IPointerEvent triggerEvent)
  System.Void PreDispatch(UnityEngine.UIElements.IPanel panel)
  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerDownEvent
TYPE:  class
TOKEN: 0x2000211
EXTENDS: PointerEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.PointerMoveEvent
TYPE:  class
TOKEN: 0x2000212
EXTENDS: PointerEventBase`1
FIELDS:
  private           System.Boolean                  <isHandledByDraggable>k__BackingField  // 0xF8
METHODS:
  System.Boolean get_isHandledByDraggable()
  System.Void set_isHandledByDraggable(System.Boolean value)
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.PointerStationaryEvent
TYPE:  class
TOKEN: 0x2000213
EXTENDS: PointerEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerUpEvent
TYPE:  class
TOKEN: 0x2000214
EXTENDS: PointerEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.PointerCancelEvent
TYPE:  class
TOKEN: 0x2000215
EXTENDS: PointerEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
  System.Void PostDispatch(UnityEngine.UIElements.IPanel panel)
END_CLASS

CLASS: UnityEngine.UIElements.ClickEvent
TYPE:  class
TOKEN: 0x2000216
EXTENDS: PointerEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
  UnityEngine.UIElements.ClickEvent GetPooled(UnityEngine.UIElements.PointerUpEvent pointerEvent, System.Int32 clickCount)
END_CLASS

CLASS: UnityEngine.UIElements.PointerEnterEvent
TYPE:  class
TOKEN: 0x2000217
EXTENDS: PointerEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerLeaveEvent
TYPE:  class
TOKEN: 0x2000218
EXTENDS: PointerEventBase`1
FIELDS:
METHODS:
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerOverEvent
TYPE:  class
TOKEN: 0x2000219
EXTENDS: PointerEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PointerOutEvent
TYPE:  class
TOKEN: 0x200021A
EXTENDS: PointerEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PropagationPaths
TYPE:  class
TOKEN: 0x200021B
FIELDS:
  private   static readonly UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.PropagationPaths>s_Pool  // 0x0
  public    readonly System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>trickleDownPath  // 0x10
  public    readonly System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>targetElements  // 0x18
  public    readonly System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>bubbleUpPath  // 0x20
  private   static  System.Int32                    k_DefaultPropagationDepth  // 0x0
  private   static  System.Int32                    k_DefaultTargetCount  // 0x0
METHODS:
  System.Void .ctor()
  UnityEngine.UIElements.PropagationPaths Copy(UnityEngine.UIElements.PropagationPaths paths)
  UnityEngine.UIElements.PropagationPaths Build(UnityEngine.UIElements.VisualElement elem, UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPaths.Type pathTypesRequested)
  System.Void Release()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.CustomStyleResolvedEvent
TYPE:  class
TOKEN: 0x200021D
EXTENDS: EventBase`1
FIELDS:
METHODS:
  UnityEngine.UIElements.ICustomStyle get_customStyle()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.TooltipEvent
TYPE:  class
TOKEN: 0x200021E
EXTENDS: EventBase`1
FIELDS:
  private           System.String                   <tooltip>k__BackingField  // 0x80
  private           UnityEngine.Rect                <rect>k__BackingField  // 0x88
METHODS:
  System.Void set_tooltip(System.String value)
  System.Void set_rect(UnityEngine.Rect value)
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StylePropertyNameCollection
TYPE:  struct
TOKEN: 0x200021F
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName>propertiesList  // 0x10
METHODS:
  System.Void .ctor(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> list)
  UnityEngine.UIElements.StylePropertyNameCollection.Enumerator GetEnumerator()
  System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StylePropertyName> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: UnityEngine.UIElements.TransitionEventBase`1
TYPE:  class
TOKEN: 0x2000221
EXTENDS: EventBase`1
FIELDS:
  private   readonly UnityEngine.UIElements.StylePropertyNameCollection<stylePropertyNames>k__BackingField  // 0x0
  private           System.Double                   <elapsedTime>k__BackingField  // 0x0
METHODS:
  UnityEngine.UIElements.StylePropertyNameCollection get_stylePropertyNames()
  System.Void set_elapsedTime(System.Double value)
  System.Void .ctor()
  System.Void Init()
  System.Void LocalInit()
  T GetPooled(UnityEngine.UIElements.StylePropertyName stylePropertyName, System.Double elapsedTime)
END_CLASS

CLASS: UnityEngine.UIElements.TransitionRunEvent
TYPE:  class
TOKEN: 0x2000222
EXTENDS: TransitionEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.TransitionStartEvent
TYPE:  class
TOKEN: 0x2000223
EXTENDS: TransitionEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.TransitionEndEvent
TYPE:  class
TOKEN: 0x2000224
EXTENDS: TransitionEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.TransitionCancelEvent
TYPE:  class
TOKEN: 0x2000225
EXTENDS: TransitionEventBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.IMGUIEvent
TYPE:  class
TOKEN: 0x2000226
EXTENDS: EventBase`1
FIELDS:
METHODS:
  UnityEngine.UIElements.IMGUIEvent GetPooled(UnityEngine.Event systemEvent)
  System.Void Init()
  System.Void LocalInit()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.EventDebuggerLogCall
TYPE:  struct
TOKEN: 0x2000227
FIELDS:
METHODS:
  System.Void .ctor(System.Delegate callback, UnityEngine.UIElements.EventBase evt)
  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.UIElements.EventDebuggerLogIMGUICall
TYPE:  struct
TOKEN: 0x2000228
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.UIElements.EventBase evt)
  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.UIElements.EventDebuggerLogExecuteDefaultAction
TYPE:  struct
TOKEN: 0x2000229
FIELDS:
METHODS:
  System.Void .ctor(UnityEngine.UIElements.EventBase evt)
  System.Void Dispose()
END_CLASS

CLASS: UnityEngine.UIElements.EventDebugger
TYPE:  class
TOKEN: 0x200022A
FIELDS:
METHODS:
  System.Void LogPropagationPaths(UnityEngine.UIElements.EventBase evt, UnityEngine.UIElements.PropagationPaths paths)
END_CLASS

CLASS: UnityEngine.UIElements.DynamicAtlasFiltersInternal
TYPE:  struct
TOKEN: 0x200022B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersInternalNone  // 0x0
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersInternalReadability  // 0x0
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersInternalSize  // 0x0
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersInternalFormat  // 0x0
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersInternalColorSpace  // 0x0
  public    static  UnityEngine.UIElements.DynamicAtlasFiltersInternalFilterMode  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.DynamicAtlasSettings
TYPE:  class
TOKEN: 0x200022C
FIELDS:
  private           System.Int32                    m_MinAtlasSize  // 0x10
  private           System.Int32                    m_MaxAtlasSize  // 0x14
  private           System.Int32                    m_MaxSubTextureSize  // 0x18
  private           UnityEngine.UIElements.DynamicAtlasFiltersInternalm_ActiveFilters  // 0x1C
  private           UnityEngine.UIElements.DynamicAtlasCustomFilterm_CustomFilter  // 0x20
METHODS:
  System.Int32 get_minAtlasSize()
  System.Void set_minAtlasSize(System.Int32 value)
  System.Int32 get_maxAtlasSize()
  System.Void set_maxAtlasSize(System.Int32 value)
  System.Int32 get_maxSubTextureSize()
  System.Void set_maxSubTextureSize(System.Int32 value)
  UnityEngine.UIElements.DynamicAtlasFilters get_activeFilters()
  System.Void set_activeFilters(UnityEngine.UIElements.DynamicAtlasFilters value)
  UnityEngine.UIElements.DynamicAtlasFilters get_defaultFilters()
  UnityEngine.UIElements.DynamicAtlasCustomFilter get_customFilter()
  System.Void set_customFilter(UnityEngine.UIElements.DynamicAtlasCustomFilter value)
  UnityEngine.UIElements.DynamicAtlasSettings get_defaults()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.NavigateFocusRing
TYPE:  class
TOKEN: 0x200022D
FIELDS:
  public    static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirectionLeft  // 0x0
  public    static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirectionRight  // 0x8
  public    static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirectionUp  // 0x10
  public    static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirectionDown  // 0x18
  public    static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirectionNext  // 0x20
  public    static readonly UnityEngine.UIElements.NavigateFocusRing.ChangeDirectionPrevious  // 0x28
  private   readonly UnityEngine.UIElements.VisualElementm_Root  // 0x10
  private   readonly UnityEngine.UIElements.VisualElementFocusRingm_Ring  // 0x18
METHODS:
  UnityEngine.UIElements.FocusController get_focusController()
  System.Void .ctor(UnityEngine.UIElements.VisualElement root)
  UnityEngine.UIElements.FocusChangeDirection GetFocusChangeDirection(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.EventBase e)
  UnityEngine.UIElements.Focusable GetNextFocusable(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.FocusChangeDirection direction)
  UnityEngine.UIElements.Focusable GetNextFocusable2D(UnityEngine.UIElements.Focusable currentFocusable, UnityEngine.UIElements.NavigateFocusRing.ChangeDirection direction)
  System.Boolean IsActive(UnityEngine.UIElements.VisualElement v)
  System.Boolean IsNavigable(UnityEngine.UIElements.Focusable focusable)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.PanelScaleMode
TYPE:  struct
TOKEN: 0x2000230
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.PanelScaleModeConstantPixelSize  // 0x0
  public    static  UnityEngine.UIElements.PanelScaleModeConstantPhysicalSize  // 0x0
  public    static  UnityEngine.UIElements.PanelScaleModeScaleWithScreenSize  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.PanelScreenMatchMode
TYPE:  struct
TOKEN: 0x2000231
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.PanelScreenMatchModeMatchWidthOrHeight  // 0x0
  public    static  UnityEngine.UIElements.PanelScreenMatchModeShrink  // 0x0
  public    static  UnityEngine.UIElements.PanelScreenMatchModeExpand  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.PanelSettings
TYPE:  class
TOKEN: 0x2000232
EXTENDS: ScriptableObject
FIELDS:
  private   static  System.Int32                    k_DefaultSortingOrder  // 0x0
  private   static  System.Single                   k_DefaultScaleValue  // 0x0
  private   static  System.String                   k_DefaultStyleSheetPath  // 0x0
  private           UnityEngine.UIElements.ThemeStyleSheetthemeUss  // 0x18
  private           UnityEngine.RenderTexture       m_TargetTexture  // 0x20
  private           UnityEngine.UIElements.PanelScaleModem_ScaleMode  // 0x28
  private           System.Single                   m_Scale  // 0x2C
  private   static  System.Single                   DefaultDpi  // 0x0
  private           System.Single                   m_ReferenceDpi  // 0x30
  private           System.Single                   m_FallbackDpi  // 0x34
  private           UnityEngine.Vector2Int          m_ReferenceResolution  // 0x38
  private           UnityEngine.UIElements.PanelScreenMatchModem_ScreenMatchMode  // 0x40
  private           System.Single                   m_Match  // 0x44
  private           System.Single                   m_SortingOrder  // 0x48
  private           System.Int32                    m_TargetDisplay  // 0x4C
  private           System.Boolean                  m_ClearDepthStencil  // 0x50
  private           System.Boolean                  m_ClearColor  // 0x51
  private           UnityEngine.Color               m_ColorClearValue  // 0x54
  private           UnityEngine.UIElements.PanelSettings.RuntimePanelAccessm_PanelAccess  // 0x68
  private           UnityEngine.UIElements.UIDocumentListm_AttachedUIDocumentsList  // 0x70
  private           UnityEngine.UIElements.DynamicAtlasSettingsm_DynamicAtlasSettings  // 0x78
  private           UnityEngine.Shader              m_AtlasBlitShader  // 0x80
  private           UnityEngine.Shader              m_RuntimeShader  // 0x88
  private           UnityEngine.Shader              m_RuntimeWorldShader  // 0x90
  public            UnityEngine.UIElements.PanelTextSettingstextSettings  // 0x98
  private           UnityEngine.Rect                m_TargetRect  // 0xA0
  private           System.Single                   m_ResolvedScale  // 0xB0
  private           UnityEngine.UIElements.StyleSheetm_OldThemeUss  // 0xB8
  private           System.Int32                    m_EmptyPanelCounter  // 0xC0
  private           System.Single                   <ScreenDPI>k__BackingField  // 0xC4
  private           System.Func<UnityEngine.Vector2,UnityEngine.Vector2>m_AssignedScreenToPanel  // 0xC8
METHODS:
  UnityEngine.UIElements.ThemeStyleSheet get_themeStyleSheet()
  System.Void set_themeStyleSheet(UnityEngine.UIElements.ThemeStyleSheet value)
  UnityEngine.RenderTexture get_targetTexture()
  System.Void set_targetTexture(UnityEngine.RenderTexture value)
  UnityEngine.UIElements.PanelScaleMode get_scaleMode()
  System.Void set_scaleMode(UnityEngine.UIElements.PanelScaleMode value)
  System.Single get_scale()
  System.Void set_scale(System.Single value)
  System.Single get_referenceDpi()
  System.Void set_referenceDpi(System.Single value)
  System.Single get_fallbackDpi()
  System.Void set_fallbackDpi(System.Single value)
  UnityEngine.Vector2Int get_referenceResolution()
  System.Void set_referenceResolution(UnityEngine.Vector2Int value)
  UnityEngine.UIElements.PanelScreenMatchMode get_screenMatchMode()
  System.Void set_screenMatchMode(UnityEngine.UIElements.PanelScreenMatchMode value)
  System.Single get_match()
  System.Void set_match(System.Single value)
  System.Single get_sortingOrder()
  System.Void set_sortingOrder(System.Single value)
  System.Void ApplySortingOrder()
  System.Int32 get_targetDisplay()
  System.Void set_targetDisplay(System.Int32 value)
  System.Boolean get_clearDepthStencil()
  System.Void set_clearDepthStencil(System.Boolean value)
  System.Single get_depthClearValue()
  System.Boolean get_clearColor()
  System.Void set_clearColor(System.Boolean value)
  UnityEngine.Color get_colorClearValue()
  System.Void set_colorClearValue(UnityEngine.Color value)
  UnityEngine.UIElements.BaseRuntimePanel get_panel()
  UnityEngine.UIElements.VisualElement get_visualTree()
  UnityEngine.UIElements.DynamicAtlasSettings get_dynamicAtlasSettings()
  System.Void set_dynamicAtlasSettings(UnityEngine.UIElements.DynamicAtlasSettings value)
  System.Void .ctor()
  System.Void Reset()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void DisposePanel()
  System.Single get_ScreenDPI()
  System.Void set_ScreenDPI(System.Single value)
  System.Void UpdateScreenDPI()
  System.Void ApplyThemeStyleSheet(UnityEngine.UIElements.VisualElement root)
  System.Void InitializeShaders()
  System.Void ApplyPanelSettings()
  System.Void SetScreenToPanelSpaceFunction(System.Func<UnityEngine.Vector2,UnityEngine.Vector2> screentoPanelSpaceFunction)
  System.Single ResolveScale(UnityEngine.Rect targetRect, System.Single screenDpi)
  UnityEngine.Rect GetDisplayRect()
  System.Void AttachAndInsertUIDocumentToVisualTree(UnityEngine.UIElements.UIDocument uiDocument)
  System.Void DetachUIDocument(UnityEngine.UIElements.UIDocument uiDocument)
END_CLASS

CLASS: UnityEngine.UIElements.RuntimeEventDispatcher
TYPE:  class
TOKEN: 0x2000234
FIELDS:
METHODS:
  UnityEngine.UIElements.EventDispatcher Create()
END_CLASS

CLASS: UnityEngine.UIElements.RuntimePanel
TYPE:  class
TOKEN: 0x2000235
EXTENDS: BaseRuntimePanel
FIELDS:
  private   static readonly UnityEngine.UIElements.EventDispatchers_EventDispatcher  // 0x0
  private   readonly UnityEngine.UIElements.PanelSettingsm_PanelSettings  // 0x1D8
METHODS:
  UnityEngine.UIElements.PanelSettings get_panelSettings()
  UnityEngine.UIElements.RuntimePanel Create(UnityEngine.ScriptableObject ownerObject)
  System.Void .ctor(UnityEngine.ScriptableObject ownerObject)
  System.Void Update()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIDocumentList
TYPE:  class
TOKEN: 0x2000236
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.UIDocument>m_AttachedUIDocuments  // 0x10
METHODS:
  System.Void RemoveFromListAndFromVisualTree(UnityEngine.UIElements.UIDocument uiDocument)
  System.Void AddToListAndToVisualTree(UnityEngine.UIElements.UIDocument uiDocument, UnityEngine.UIElements.VisualElement visualTree, System.Int32 firstInsertIndex)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIDocument
TYPE:  class
TOKEN: 0x2000237
EXTENDS: MonoBehaviour
FIELDS:
  private   static  System.String                   k_RootStyleClassName  // 0x0
  private   static  System.String                   k_VisualElementNameSuffix  // 0x0
  private   static  System.Int32                    k_DefaultSortingOrder  // 0x0
  private   static  System.Int32                    s_CurrentUIDocumentCounter  // 0x0
  private   readonly System.Int32                    m_UIDocumentCreationIndex  // 0x18
  private           UnityEngine.UIElements.PanelSettingsm_PanelSettings  // 0x20
  private           UnityEngine.UIElements.PanelSettingsm_PreviousPanelSettings  // 0x28
  private           UnityEngine.UIElements.UIDocumentm_ParentUI  // 0x30
  private           UnityEngine.UIElements.UIDocumentListm_ChildrenContent  // 0x38
  private           System.Collections.Generic.List<UnityEngine.UIElements.UIDocument>m_ChildrenContentCopy  // 0x40
  private           UnityEngine.UIElements.VisualTreeAssetsourceAsset  // 0x48
  private           UnityEngine.UIElements.VisualElementm_RootVisualElement  // 0x50
  private           System.Int32                    m_FirstChildInsertIndex  // 0x58
  private           System.Single                   m_SortingOrder  // 0x5C
METHODS:
  UnityEngine.UIElements.PanelSettings get_panelSettings()
  System.Void set_panelSettings(UnityEngine.UIElements.PanelSettings value)
  UnityEngine.UIElements.UIDocument get_parentUI()
  System.Void set_parentUI(UnityEngine.UIElements.UIDocument value)
  UnityEngine.UIElements.VisualTreeAsset get_visualTreeAsset()
  System.Void set_visualTreeAsset(UnityEngine.UIElements.VisualTreeAsset value)
  UnityEngine.UIElements.VisualElement get_rootVisualElement()
  System.Int32 get_firstChildInserIndex()
  System.Single get_sortingOrder()
  System.Void set_sortingOrder(System.Single value)
  System.Void ApplySortingOrder()
  System.Void .ctor()
  System.Void Awake()
  System.Void OnEnable()
  System.Void SetupFromHierarchy()
  UnityEngine.UIElements.UIDocument FindUIDocumentParent()
  System.Void Reset()
  System.Void AddChildAndInsertContentToVisualTree(UnityEngine.UIElements.UIDocument child)
  System.Void RemoveChild(UnityEngine.UIElements.UIDocument child)
  System.Void RecreateUI()
  System.Void SetupRootClassList()
  System.Void AddRootVisualElementToTree()
  System.Void RemoveFromHierarchy()
  System.Void OnDisable()
  System.Void OnTransformChildrenChanged()
  System.Void OnTransformParentChanged()
  System.Void ReactToHierarchyChanged()
END_CLASS

CLASS: UnityEngine.UIElements.UIRAtlasAllocator
TYPE:  class
TOKEN: 0x2000238
FIELDS:
  private   readonly System.Int32                    <maxAtlasSize>k__BackingField  // 0x10
  private   readonly System.Int32                    <maxImageWidth>k__BackingField  // 0x14
  private   readonly System.Int32                    <maxImageHeight>k__BackingField  // 0x18
  private           System.Int32                    <virtualWidth>k__BackingField  // 0x1C
  private           System.Int32                    <virtualHeight>k__BackingField  // 0x20
  private           System.Int32                    <physicalWidth>k__BackingField  // 0x24
  private           System.Int32                    <physicalHeight>k__BackingField  // 0x28
  private           UnityEngine.UIElements.UIRAtlasAllocator.AreaNodem_FirstUnpartitionedArea  // 0x30
  private           UnityEngine.UIElements.UIRAtlasAllocator.Row[]m_OpenRows  // 0x38
  private           System.Int32                    m_1SidePadding  // 0x40
  private           System.Int32                    m_2SidePadding  // 0x44
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerTryAllocate  // 0x0
  private           System.Boolean                  <disposed>k__BackingField  // 0x48
METHODS:
  System.Int32 get_maxAtlasSize()
  System.Int32 get_maxImageWidth()
  System.Int32 get_maxImageHeight()
  System.Int32 get_virtualWidth()
  System.Void set_virtualWidth(System.Int32 value)
  System.Int32 get_virtualHeight()
  System.Void set_virtualHeight(System.Int32 value)
  System.Int32 get_physicalWidth()
  System.Void set_physicalWidth(System.Int32 value)
  System.Int32 get_physicalHeight()
  System.Void set_physicalHeight(System.Int32 value)
  System.Boolean get_disposed()
  System.Void set_disposed(System.Boolean value)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Int32 GetLog2OfNextPower(System.Int32 n)
  System.Void .ctor(System.Int32 initialAtlasSize, System.Int32 maxAtlasSize, System.Int32 sidePadding)
  System.Boolean TryAllocate(System.Int32 width, System.Int32 height, UnityEngine.RectInt& location)
  System.Boolean TryPartitionArea(UnityEngine.UIElements.UIRAtlasAllocator.AreaNode areaNode, System.Int32 rowIndex, System.Int32 rowHeight, System.Int32 minWidth)
  System.Void BuildAreas()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.DynamicAtlasPage
TYPE:  class
TOKEN: 0x200023B
FIELDS:
  private           UnityEngine.UIElements.TextureId<textureId>k__BackingField  // 0x10
  private           UnityEngine.RenderTexture       <atlas>k__BackingField  // 0x18
  private   readonly UnityEngine.RenderTextureFormat <format>k__BackingField  // 0x20
  private   readonly UnityEngine.FilterMode          <filterMode>k__BackingField  // 0x24
  private   readonly UnityEngine.Vector2Int          <minSize>k__BackingField  // 0x28
  private   readonly UnityEngine.Vector2Int          <maxSize>k__BackingField  // 0x30
  private   readonly System.Int32                    m_1Padding  // 0x38
  private   readonly System.Int32                    m_2Padding  // 0x3C
  private           UnityEngine.UIElements.UIR.Allocator2Dm_Allocator  // 0x40
  private           UnityEngine.UIElements.UIR.TextureBlitterm_Blitter  // 0x48
  private           UnityEngine.Vector2Int          m_CurrentSize  // 0x50
  private   static  System.Int32                    s_TextureCounter  // 0x0
  private           System.Boolean                  <disposed>k__BackingField  // 0x58
METHODS:
  UnityEngine.UIElements.TextureId get_textureId()
  System.Void set_textureId(UnityEngine.UIElements.TextureId value)
  UnityEngine.RenderTexture get_atlas()
  System.Void set_atlas(UnityEngine.RenderTexture value)
  UnityEngine.RenderTextureFormat get_format()
  UnityEngine.FilterMode get_filterMode()
  System.Void .ctor(UnityEngine.RenderTextureFormat format, UnityEngine.FilterMode filterMode, UnityEngine.Vector2Int minSize, UnityEngine.Vector2Int maxSize)
  System.Boolean get_disposed()
  System.Void set_disposed(System.Boolean value)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Boolean TryAdd(UnityEngine.Texture2D image, UnityEngine.UIElements.UIR.Allocator2D.Alloc2D& alloc, UnityEngine.RectInt& rect)
  System.Void Update(UnityEngine.Texture2D image, UnityEngine.RectInt rect)
  System.Void Remove(UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc)
  System.Void Commit()
  System.Void UpdateAtlasTexture()
  UnityEngine.RenderTexture CreateAtlasTexture()
END_CLASS

CLASS: UnityEngine.UIElements.UIRLayoutUpdater
TYPE:  class
TOKEN: 0x200023C
EXTENDS: BaseVisualTreeUpdater
FIELDS:
  private   static readonly System.String                   s_Description  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  s_ProfilerMarker  // 0x8
  private           System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>>changeEventsList  // 0x20
METHODS:
  Unity.Profiling.ProfilerMarker get_profilerMarker()
  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  System.Void Update()
  System.Void UpdateSubTree(UnityEngine.UIElements.VisualElement ve, System.Boolean isDisplayed, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>> changeEvents)
  System.Void DispatchChangeEvents(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>> changeEvents, System.Int32 currentLayoutPass)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Vertex
TYPE:  struct
TOKEN: 0x200023D
FIELDS:
  public    static readonly System.Single                   nearZ  // 0x0
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Color32             tint  // 0x1C
  public            UnityEngine.Vector2             uv  // 0x20
  private           UnityEngine.Color32             xformClipPages  // 0x28
  private           UnityEngine.Color32             ids  // 0x2C
  private           UnityEngine.Color32             flags  // 0x30
  private           UnityEngine.Color32             opacityColorPages  // 0x34
  private           UnityEngine.Vector4             circle  // 0x38
  private           System.Single                   textureId  // 0x48
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.MeshWriteData
TYPE:  class
TOKEN: 0x200023E
FIELDS:
  private           Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>m_Vertices  // 0x10
  private           Unity.Collections.NativeSlice<System.UInt16>m_Indices  // 0x20
  private           UnityEngine.Rect                m_UVRegion  // 0x30
  private           System.Int32                    currentIndex  // 0x40
  private           System.Int32                    currentVertex  // 0x44
METHODS:
  System.Void .ctor()
  System.Int32 get_vertexCount()
  System.Int32 get_indexCount()
  UnityEngine.Rect get_uvRegion()
  System.Void SetNextVertex(UnityEngine.UIElements.Vertex vertex)
  System.Void SetNextIndex(System.UInt16 index)
  System.Void SetAllVertices(UnityEngine.UIElements.Vertex[] vertices)
  System.Void SetAllIndices(System.UInt16[] indices)
  System.Void Reset(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices)
  System.Void Reset(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices, UnityEngine.Rect uvRegion)
END_CLASS

CLASS: UnityEngine.UIElements.ColorPage
TYPE:  struct
TOKEN: 0x200023F
FIELDS:
  public            System.Boolean                  isValid  // 0x10
  public            UnityEngine.Color32             pageAndID  // 0x14
METHODS:
  UnityEngine.UIElements.ColorPage Init(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.BMPAlloc alloc)
END_CLASS

CLASS: UnityEngine.UIElements.MeshGenerationContextUtils
TYPE:  class
TOKEN: 0x2000240
FIELDS:
METHODS:
  System.Void Rectangle(UnityEngine.UIElements.MeshGenerationContext mgc, UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams)
  System.Void Text(UnityEngine.UIElements.MeshGenerationContext mgc, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint)
  UnityEngine.Vector2 ConvertBorderRadiusPercentToPoints(UnityEngine.Vector2 borderRectSize, UnityEngine.UIElements.Length length)
  System.Void GetVisualElementRadii(UnityEngine.UIElements.VisualElement ve, UnityEngine.Vector2& topLeft, UnityEngine.Vector2& bottomLeft, UnityEngine.Vector2& topRight, UnityEngine.Vector2& bottomRight)
  System.Void AdjustBackgroundSizeForBorders(UnityEngine.UIElements.VisualElement visualElement, UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams& rectParams)
END_CLASS

CLASS: UnityEngine.UIElements.MeshGenerationContext
TYPE:  class
TOKEN: 0x2000244
FIELDS:
  private           UnityEngine.UIElements.IStylePainterpainter  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.UIElements.IStylePainter painter)
END_CLASS

CLASS: UnityEngine.UIElements.UIRRepaintUpdater
TYPE:  class
TOKEN: 0x2000246
EXTENDS: BaseVisualTreeUpdater
FIELDS:
  private           UnityEngine.UIElements.BaseVisualElementPanelattachedPanel  // 0x20
  private           UnityEngine.UIElements.UIR.RenderChainrenderChain  // 0x28
  private   static readonly System.String                   s_Description  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  s_ProfilerMarker  // 0x8
  private           System.Boolean                  <drawStats>k__BackingField  // 0x30
  private           System.Boolean                  <breakBatches>k__BackingField  // 0x31
  private           System.Boolean                  <disposed>k__BackingField  // 0x32
METHODS:
  System.Void .ctor()
  Unity.Profiling.ProfilerMarker get_profilerMarker()
  System.Boolean get_drawStats()
  System.Boolean get_breakBatches()
  System.Void OnVersionChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VersionChangeType versionChangeType)
  System.Void Update()
  UnityEngine.UIElements.UIR.RenderChain CreateRenderChain()
  System.Void .cctor()
  System.Void OnGraphicsResourcesRecreate(System.Boolean recreate)
  System.Void OnPanelChanged(UnityEngine.UIElements.BaseVisualElementPanel obj)
  System.Void AttachToPanel()
  System.Void DetachFromPanel()
  System.Void InitRenderChain()
  System.Void DestroyRenderChain()
  System.Void OnPanelAtlasChanged()
  System.Void OnPanelHierarchyChanged(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.HierarchyChangeType changeType)
  System.Void OnPanelStandardShaderChanged()
  System.Void OnPanelStandardWorldSpaceShaderChanged()
  System.Void ResetAllElementsDataRecursive(UnityEngine.UIElements.VisualElement ve)
  System.Boolean get_disposed()
  System.Void set_disposed(System.Boolean value)
  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: UnityEngine.UIElements.TextureId
TYPE:  struct
TOKEN: 0x2000247
FIELDS:
  private   readonly System.Int32                    m_Index  // 0x10
  public    static readonly UnityEngine.UIElements.TextureIdinvalid  // 0x0
METHODS:
  System.Void .ctor(System.Int32 index)
  System.Int32 get_index()
  System.Single ConvertToGpu()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.UIElements.TextureId left, UnityEngine.UIElements.TextureId right)
  System.Boolean op_Inequality(UnityEngine.UIElements.TextureId left, UnityEngine.UIElements.TextureId right)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.TextureRegistry
TYPE:  class
TOKEN: 0x2000248
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.TextureRegistry.TextureInfo>m_Textures  // 0x10
  private           System.Collections.Generic.Dictionary<UnityEngine.Texture,UnityEngine.UIElements.TextureId>m_TextureToId  // 0x18
  private           System.Collections.Generic.Stack<UnityEngine.UIElements.TextureId>m_FreeIds  // 0x20
  private   static  System.Int32                    maxTextures  // 0x0
  private   static readonly UnityEngine.UIElements.TextureRegistry<instance>k__BackingField  // 0x0
METHODS:
  UnityEngine.UIElements.TextureRegistry get_instance()
  UnityEngine.Texture GetTexture(UnityEngine.UIElements.TextureId id)
  UnityEngine.UIElements.TextureId AllocAndAcquireDynamic()
  System.Void UpdateDynamic(UnityEngine.UIElements.TextureId id, UnityEngine.Texture texture)
  UnityEngine.UIElements.TextureId AllocAndAcquire(UnityEngine.Texture texture, System.Boolean dynamic)
  UnityEngine.UIElements.TextureId Acquire(UnityEngine.Texture tex)
  System.Void Release(UnityEngine.UIElements.TextureId id)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIRUtility
TYPE:  class
TOKEN: 0x200024A
FIELDS:
  public    static readonly System.String                   k_DefaultShaderName  // 0x0
  public    static readonly System.String                   k_DefaultWorldSpaceShaderName  // 0x8
METHODS:
  System.Boolean ShapeWindingIsClockwise(System.Int32 maskDepth, System.Int32 stencilRef)
  System.Boolean IsRoundRect(UnityEngine.UIElements.VisualElement ve)
  System.Boolean IsVectorImageBackground(UnityEngine.UIElements.VisualElement ve)
  System.Boolean IsElementSelfHidden(UnityEngine.UIElements.VisualElement ve)
  System.Void Destroy(UnityEngine.Object obj)
  System.Int32 GetPrevPow2(System.Int32 n)
  System.Int32 GetNextPow2(System.Int32 n)
  System.Int32 GetNextPow2Exp(System.Int32 n)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.AngleUnit
TYPE:  struct
TOKEN: 0x200024B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.AngleUnitDegree  // 0x0
  public    static  UnityEngine.UIElements.AngleUnitGradian  // 0x0
  public    static  UnityEngine.UIElements.AngleUnitRadian  // 0x0
  public    static  UnityEngine.UIElements.AngleUnitTurn  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Angle
TYPE:  struct
TOKEN: 0x200024C
FIELDS:
  private           System.Single                   m_Value  // 0x10
  private           UnityEngine.UIElements.Angle.Unitm_Unit  // 0x14
METHODS:
  UnityEngine.UIElements.Angle None()
  System.Single get_value()
  System.Void .ctor(System.Single value, UnityEngine.UIElements.AngleUnit unit)
  System.Void .ctor(System.Single value, UnityEngine.UIElements.Angle.Unit unit)
  System.Single ToDegrees()
  UnityEngine.UIElements.Angle op_Implicit(System.Single value)
  System.Boolean op_Equality(UnityEngine.UIElements.Angle lhs, UnityEngine.UIElements.Angle rhs)
  System.Boolean Equals(UnityEngine.UIElements.Angle other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.Background
TYPE:  struct
TOKEN: 0x200024E
FIELDS:
  private           UnityEngine.Texture2D           m_Texture  // 0x10
  private           UnityEngine.Sprite              m_Sprite  // 0x18
  private           UnityEngine.RenderTexture       m_RenderTexture  // 0x20
  private           UnityEngine.UIElements.VectorImagem_VectorImage  // 0x28
METHODS:
  UnityEngine.Texture2D get_texture()
  System.Void set_texture(UnityEngine.Texture2D value)
  UnityEngine.Sprite get_sprite()
  System.Void set_sprite(UnityEngine.Sprite value)
  UnityEngine.RenderTexture get_renderTexture()
  System.Void set_renderTexture(UnityEngine.RenderTexture value)
  UnityEngine.UIElements.VectorImage get_vectorImage()
  System.Void set_vectorImage(UnityEngine.UIElements.VectorImage value)
  UnityEngine.UIElements.Background FromTexture2D(UnityEngine.Texture2D t)
  UnityEngine.UIElements.Background FromRenderTexture(UnityEngine.RenderTexture rt)
  UnityEngine.UIElements.Background FromSprite(UnityEngine.Sprite s)
  UnityEngine.UIElements.Background FromVectorImage(UnityEngine.UIElements.VectorImage vi)
  UnityEngine.UIElements.Background FromObject(System.Object obj)
  System.Boolean op_Equality(UnityEngine.UIElements.Background lhs, UnityEngine.UIElements.Background rhs)
  System.Boolean op_Inequality(UnityEngine.UIElements.Background lhs, UnityEngine.UIElements.Background rhs)
  System.Boolean Equals(UnityEngine.UIElements.Background other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.ComputedStyle
TYPE:  struct
TOKEN: 0x200024F
FIELDS:
  public            UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.InheritedData>inheritedData  // 0x10
  public            UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.LayoutData>layoutData  // 0x18
  public            UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.RareData>rareData  // 0x20
  public            UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.TransformData>transformData  // 0x28
  public            UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.TransitionData>transitionData  // 0x30
  public            UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.VisualData>visualData  // 0x38
  public            UnityEngine.Yoga.YogaNode       yogaNode  // 0x40
  public            System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue>customProperties  // 0x48
  public            System.Int64                    matchingRulesHash  // 0x50
  public            System.Single                   dpiScaling  // 0x58
  public            UnityEngine.UIElements.ComputedTransitionProperty[]computedTransitions  // 0x60
METHODS:
  System.Int32 get_customPropertiesCount()
  System.Boolean get_hasTransition()
  System.Void FinalizeApply(UnityEngine.UIElements.ComputedStyle& parentStyle)
  System.Void SyncWithLayout(UnityEngine.Yoga.YogaNode targetNode)
  System.Boolean ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& parentStyle)
  System.Boolean ApplyGlobalKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleKeyword keyword, UnityEngine.UIElements.ComputedStyle& parentStyle)
  System.Void RemoveCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader)
  System.Void ApplyCustomStyleProperty(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader)
  System.Void ApplyAllPropertyInitial()
  System.Void ResetComputedTransitions()
  UnityEngine.UIElements.VersionChangeType CompareChanges(UnityEngine.UIElements.ComputedStyle& x, UnityEngine.UIElements.ComputedStyle& y)
  System.Boolean StartAnimationInlineTranslate(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.ComputedStyle& computedStyle, UnityEngine.UIElements.StyleTranslate translate, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  UnityEngine.UIElements.Align get_alignContent()
  UnityEngine.UIElements.Align get_alignItems()
  UnityEngine.UIElements.Align get_alignSelf()
  UnityEngine.Color get_backgroundColor()
  UnityEngine.UIElements.Background get_backgroundImage()
  UnityEngine.Color get_borderBottomColor()
  UnityEngine.UIElements.Length get_borderBottomLeftRadius()
  UnityEngine.UIElements.Length get_borderBottomRightRadius()
  System.Single get_borderBottomWidth()
  UnityEngine.Color get_borderLeftColor()
  System.Single get_borderLeftWidth()
  UnityEngine.Color get_borderRightColor()
  System.Single get_borderRightWidth()
  UnityEngine.Color get_borderTopColor()
  UnityEngine.UIElements.Length get_borderTopLeftRadius()
  UnityEngine.UIElements.Length get_borderTopRightRadius()
  System.Single get_borderTopWidth()
  UnityEngine.UIElements.Length get_bottom()
  UnityEngine.Color get_color()
  UnityEngine.UIElements.Cursor get_cursor()
  UnityEngine.UIElements.DisplayStyle get_display()
  UnityEngine.UIElements.Length get_flexBasis()
  UnityEngine.UIElements.FlexDirection get_flexDirection()
  System.Single get_flexGrow()
  System.Single get_flexShrink()
  UnityEngine.UIElements.Wrap get_flexWrap()
  UnityEngine.UIElements.Length get_fontSize()
  UnityEngine.UIElements.Length get_height()
  UnityEngine.UIElements.Justify get_justifyContent()
  UnityEngine.UIElements.Length get_left()
  UnityEngine.UIElements.Length get_letterSpacing()
  UnityEngine.UIElements.Length get_marginBottom()
  UnityEngine.UIElements.Length get_marginLeft()
  UnityEngine.UIElements.Length get_marginRight()
  UnityEngine.UIElements.Length get_marginTop()
  UnityEngine.UIElements.Length get_maxHeight()
  UnityEngine.UIElements.Length get_maxWidth()
  UnityEngine.UIElements.Length get_minHeight()
  UnityEngine.UIElements.Length get_minWidth()
  System.Single get_opacity()
  UnityEngine.UIElements.OverflowInternal get_overflow()
  UnityEngine.UIElements.Length get_paddingBottom()
  UnityEngine.UIElements.Length get_paddingLeft()
  UnityEngine.UIElements.Length get_paddingRight()
  UnityEngine.UIElements.Length get_paddingTop()
  UnityEngine.UIElements.Position get_position()
  UnityEngine.UIElements.Length get_right()
  UnityEngine.UIElements.Rotate get_rotate()
  UnityEngine.UIElements.Scale get_scale()
  UnityEngine.UIElements.TextOverflow get_textOverflow()
  UnityEngine.UIElements.TextShadow get_textShadow()
  UnityEngine.UIElements.Length get_top()
  UnityEngine.UIElements.TransformOrigin get_transformOrigin()
  System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDelay()
  System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDuration()
  System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> get_transitionProperty()
  System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> get_transitionTimingFunction()
  UnityEngine.UIElements.Translate get_translate()
  UnityEngine.Color get_unityBackgroundImageTintColor()
  UnityEngine.ScaleMode get_unityBackgroundScaleMode()
  UnityEngine.Font get_unityFont()
  UnityEngine.UIElements.FontDefinition get_unityFontDefinition()
  UnityEngine.FontStyle get_unityFontStyleAndWeight()
  UnityEngine.UIElements.OverflowClipBox get_unityOverflowClipBox()
  UnityEngine.UIElements.Length get_unityParagraphSpacing()
  System.Int32 get_unitySliceBottom()
  System.Int32 get_unitySliceLeft()
  System.Int32 get_unitySliceRight()
  System.Int32 get_unitySliceTop()
  UnityEngine.TextAnchor get_unityTextAlign()
  UnityEngine.Color get_unityTextOutlineColor()
  System.Single get_unityTextOutlineWidth()
  UnityEngine.UIElements.TextOverflowPosition get_unityTextOverflowPosition()
  UnityEngine.UIElements.Visibility get_visibility()
  UnityEngine.UIElements.WhiteSpace get_whiteSpace()
  UnityEngine.UIElements.Length get_width()
  UnityEngine.UIElements.Length get_wordSpacing()
  UnityEngine.UIElements.ComputedStyle Create(UnityEngine.UIElements.ComputedStyle& parentStyle)
  UnityEngine.UIElements.ComputedStyle CreateInitial()
  UnityEngine.UIElements.ComputedStyle Acquire()
  System.Void Release()
  System.Void CopyFrom(UnityEngine.UIElements.ComputedStyle& other)
  System.Void ApplyProperties(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& parentStyle)
  System.Void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue sv, UnityEngine.UIElements.ComputedStyle& parentStyle)
  System.Void ApplyStyleValueManaged(UnityEngine.UIElements.StyleSheets.StyleValueManaged sv, UnityEngine.UIElements.ComputedStyle& parentStyle)
  System.Void ApplyStyleCursor(UnityEngine.UIElements.Cursor cursor)
  System.Void ApplyStyleTextShadow(UnityEngine.UIElements.TextShadow st)
  System.Void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedStyle& other)
  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Length newValue)
  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Single newValue)
  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Int32 newValue)
  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color newValue)
  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Background newValue)
  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Font newValue)
  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.FontDefinition newValue)
  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TextShadow newValue)
  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Translate newValue)
  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.TransformOrigin newValue)
  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Rotate newValue)
  System.Void ApplyPropertyAnimation(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.Scale newValue)
  System.Boolean StartAnimation(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedStyle& oldStyle, UnityEngine.UIElements.ComputedStyle& newStyle, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartAnimationAllProperty(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.ComputedStyle& oldStyle, UnityEngine.UIElements.ComputedStyle& newStyle, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Boolean StartAnimationInline(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedStyle& computedStyle, UnityEngine.UIElements.StyleSheets.StyleValue sv, System.Int32 durationMs, System.Int32 delayMs, System.Func<System.Single,System.Single> easingCurve)
  System.Void ApplyStyleTransformOrigin(UnityEngine.UIElements.TransformOrigin st)
  System.Void ApplyStyleTranslate(UnityEngine.UIElements.Translate translateValue)
  System.Void ApplyStyleRotate(UnityEngine.UIElements.Rotate rotateValue)
  System.Void ApplyStyleScale(UnityEngine.UIElements.Scale scaleValue)
  System.Void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader)
  System.Void ApplyInitialValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& parentStyle)
  System.Void ApplyUnsetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedStyle& parentStyle)
END_CLASS

CLASS: UnityEngine.UIElements.ComputedTransitionProperty
TYPE:  struct
TOKEN: 0x2000250
FIELDS:
  public            UnityEngine.UIElements.StyleSheets.StylePropertyIdid  // 0x10
  public            System.Int32                    durationMs  // 0x14
  public            System.Int32                    delayMs  // 0x18
  public            System.Func<System.Single,System.Single>easingCurve  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.ComputedTransitionUtils
TYPE:  class
TOKEN: 0x2000251
FIELDS:
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.ComputedTransitionProperty>s_ComputedTransitionsBuffer  // 0x0
METHODS:
  System.Void UpdateComputedTransitions(UnityEngine.UIElements.ComputedStyle& computedStyle)
  System.Boolean HasTransitionProperty(UnityEngine.UIElements.ComputedStyle& computedStyle, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Boolean GetTransitionProperty(UnityEngine.UIElements.ComputedStyle& computedStyle, UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedTransitionProperty& result)
  UnityEngine.UIElements.ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(UnityEngine.UIElements.ComputedStyle& computedStyle)
  System.Int32 GetTransitionHashCode(UnityEngine.UIElements.ComputedStyle& cs)
  System.Boolean SameTransitionProperty(UnityEngine.UIElements.ComputedStyle& x, UnityEngine.UIElements.ComputedStyle& y)
  System.Boolean SameTransitionProperty(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> a, System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> b)
  System.Boolean SameTransitionProperty(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> a, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> b)
  System.Void ComputeTransitionPropertyData(UnityEngine.UIElements.ComputedStyle& computedStyle, System.Collections.Generic.List<UnityEngine.UIElements.ComputedTransitionProperty> outData)
  T GetWrappingTransitionData(System.Collections.Generic.List<T> list, System.Int32 i, T defaultValue)
  System.Int32 ConvertTransitionTime(UnityEngine.UIElements.TimeValue time)
  System.Func<System.Single,System.Single> ConvertTransitionFunction(UnityEngine.UIElements.EasingMode mode)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.CustomStyleProperty`1
TYPE:  struct
TOKEN: 0x2000253
FIELDS:
  private           System.String                   <name>k__BackingField  // 0x0
METHODS:
  System.String get_name()
  System.Void set_name(System.String value)
  System.Void .ctor(System.String propertyName)
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.UIElements.CustomStyleProperty<T> other)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.ICustomStyle
TYPE:  interface
TOKEN: 0x2000254
FIELDS:
METHODS:
  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Single> property, System.Single& value)
  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Int32> property, System.Int32& value)
  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> property, UnityEngine.Color& value)
  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> property, UnityEngine.Texture2D& value)
  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> property, UnityEngine.Sprite& value)
  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> property, UnityEngine.UIElements.VectorImage& value)
  System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.String> property, System.String& value)
END_CLASS

CLASS: UnityEngine.UIElements.EasingMode
TYPE:  struct
TOKEN: 0x2000255
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.EasingModeEase  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseIn  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseOut  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseInOut  // 0x0
  public    static  UnityEngine.UIElements.EasingModeLinear  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseInSine  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseOutSine  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseInOutSine  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseInCubic  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseOutCubic  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseInOutCubic  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseInCirc  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseOutCirc  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseInOutCirc  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseInElastic  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseOutElastic  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseInOutElastic  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseInBack  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseOutBack  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseInOutBack  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseInBounce  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseOutBounce  // 0x0
  public    static  UnityEngine.UIElements.EasingModeEaseInOutBounce  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.EasingFunction
TYPE:  struct
TOKEN: 0x2000256
FIELDS:
  private           UnityEngine.UIElements.EasingModem_Mode  // 0x10
METHODS:
  UnityEngine.UIElements.EasingMode get_mode()
  System.Void .ctor(UnityEngine.UIElements.EasingMode mode)
  UnityEngine.UIElements.EasingFunction op_Implicit(UnityEngine.UIElements.EasingMode easingMode)
  System.Boolean op_Equality(UnityEngine.UIElements.EasingFunction lhs, UnityEngine.UIElements.EasingFunction rhs)
  System.Boolean Equals(UnityEngine.UIElements.EasingFunction other)
  System.Boolean Equals(System.Object obj)
  System.String ToString()
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.FontDefinition
TYPE:  struct
TOKEN: 0x2000257
FIELDS:
  private           UnityEngine.Font                m_Font  // 0x10
  private           UnityEngine.TextCore.Text.FontAssetm_FontAsset  // 0x18
METHODS:
  UnityEngine.Font get_font()
  UnityEngine.TextCore.Text.FontAsset get_fontAsset()
  UnityEngine.UIElements.FontDefinition FromFont(UnityEngine.Font f)
  UnityEngine.UIElements.FontDefinition FromSDFFont(UnityEngine.TextCore.Text.FontAsset f)
  UnityEngine.UIElements.FontDefinition FromObject(System.Object obj)
  System.Boolean IsEmpty()
  System.String ToString()
  System.Boolean Equals(UnityEngine.UIElements.FontDefinition other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.UIElements.FontDefinition left, UnityEngine.UIElements.FontDefinition right)
  System.Boolean op_Inequality(UnityEngine.UIElements.FontDefinition left, UnityEngine.UIElements.FontDefinition right)
END_CLASS

CLASS: UnityEngine.UIElements.StyleValueCollection
TYPE:  class
TOKEN: 0x2000258
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StyleValue>m_Values  // 0x10
METHODS:
  UnityEngine.UIElements.StyleLength GetStyleLength(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  UnityEngine.UIElements.StyleFloat GetStyleFloat(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  UnityEngine.UIElements.StyleInt GetStyleInt(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Boolean TryGetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleSheets.StyleValue& value)
  System.Void SetStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.InlineStyleAccess
TYPE:  class
TOKEN: 0x2000259
EXTENDS: StyleValueCollection
FIELDS:
  private   static  UnityEngine.UIElements.StyleSheets.StylePropertyReaders_StylePropertyReader  // 0x0
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StyleValueManaged>m_ValuesManaged  // 0x18
  private           UnityEngine.UIElements.VisualElement<ve>k__BackingField  // 0x20
  private           System.Boolean                  m_HasInlineCursor  // 0x28
  private           UnityEngine.UIElements.StyleCursorm_InlineCursor  // 0x30
  private           System.Boolean                  m_HasInlineTextShadow  // 0x50
  private           UnityEngine.UIElements.StyleTextShadowm_InlineTextShadow  // 0x54
  private           System.Boolean                  m_HasInlineTransformOrigin  // 0x74
  private           UnityEngine.UIElements.StyleTransformOriginm_InlineTransformOrigin  // 0x78
  private           System.Boolean                  m_HasInlineTranslate  // 0x90
  private           UnityEngine.UIElements.StyleTranslatem_InlineTranslateOperation  // 0x94
  private           System.Boolean                  m_HasInlineRotate  // 0xB0
  private           UnityEngine.UIElements.StyleRotatem_InlineRotateOperation  // 0xB4
  private           System.Boolean                  m_HasInlineScale  // 0xD0
  private           UnityEngine.UIElements.StyleScalem_InlineScale  // 0xD4
  private           UnityEngine.UIElements.InlineStyleAccess.InlineRulem_InlineRule  // 0xE8
METHODS:
  UnityEngine.UIElements.VisualElement get_ve()
  System.Void set_ve(UnityEngine.UIElements.VisualElement value)
  System.Void .ctor(UnityEngine.UIElements.VisualElement ve)
  System.Void Finalize()
  System.Void SetInlineRule(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleRule rule)
  System.Boolean IsValueSet(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Void ApplyInlineStyles(UnityEngine.UIElements.ComputedStyle& computedStyle)
  UnityEngine.UIElements.StyleCursor UnityEngine.UIElements.IStyle.get_cursor()
  UnityEngine.UIElements.StyleTextShadow UnityEngine.UIElements.IStyle.get_textShadow()
  UnityEngine.UIElements.StyleTransformOrigin UnityEngine.UIElements.IStyle.get_transformOrigin()
  UnityEngine.UIElements.StyleTranslate UnityEngine.UIElements.IStyle.get_translate()
  System.Void UnityEngine.UIElements.IStyle.set_translate(UnityEngine.UIElements.StyleTranslate value)
  UnityEngine.UIElements.StyleRotate UnityEngine.UIElements.IStyle.get_rotate()
  UnityEngine.UIElements.StyleScale UnityEngine.UIElements.IStyle.get_scale()
  System.Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleLength inlineValue)
  System.Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleFloat inlineValue)
  System.Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleColor inlineValue)
  System.Boolean SetStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.StyleEnum<T> inlineValue)
  System.Boolean SetInlineTranslate(UnityEngine.UIElements.StyleTranslate inlineValue)
  System.Void ApplyStyleTranslate(UnityEngine.UIElements.StyleTranslate translate)
  System.Void ApplyStyleValue(UnityEngine.UIElements.StyleSheets.StyleValue value)
  System.Boolean RemoveInlineStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Void ApplyFromComputedStyle(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.UIElements.ComputedStyle& newStyle)
  System.Boolean TryGetInlineCursor(UnityEngine.UIElements.StyleCursor& value)
  System.Boolean TryGetInlineTextShadow(UnityEngine.UIElements.StyleTextShadow& value)
  System.Boolean TryGetInlineTransformOrigin(UnityEngine.UIElements.StyleTransformOrigin& value)
  System.Boolean TryGetInlineTranslate(UnityEngine.UIElements.StyleTranslate& value)
  System.Boolean TryGetInlineRotate(UnityEngine.UIElements.StyleRotate& value)
  System.Boolean TryGetInlineScale(UnityEngine.UIElements.StyleScale& value)
  System.Void UnityEngine.UIElements.IStyle.set_backgroundColor(UnityEngine.UIElements.StyleColor value)
  System.Void UnityEngine.UIElements.IStyle.set_borderBottomColor(UnityEngine.UIElements.StyleColor value)
  System.Void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_borderBottomWidth(UnityEngine.UIElements.StyleFloat value)
  System.Void UnityEngine.UIElements.IStyle.set_borderLeftColor(UnityEngine.UIElements.StyleColor value)
  System.Void UnityEngine.UIElements.IStyle.set_borderLeftWidth(UnityEngine.UIElements.StyleFloat value)
  System.Void UnityEngine.UIElements.IStyle.set_borderRightColor(UnityEngine.UIElements.StyleColor value)
  System.Void UnityEngine.UIElements.IStyle.set_borderRightWidth(UnityEngine.UIElements.StyleFloat value)
  System.Void UnityEngine.UIElements.IStyle.set_borderTopColor(UnityEngine.UIElements.StyleColor value)
  System.Void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_borderTopWidth(UnityEngine.UIElements.StyleFloat value)
  System.Void UnityEngine.UIElements.IStyle.set_bottom(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_color(UnityEngine.UIElements.StyleColor value)
  UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> UnityEngine.UIElements.IStyle.get_display()
  System.Void UnityEngine.UIElements.IStyle.set_display(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> value)
  System.Void UnityEngine.UIElements.IStyle.set_flexBasis(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_flexDirection(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.FlexDirection> value)
  System.Void UnityEngine.UIElements.IStyle.set_flexGrow(UnityEngine.UIElements.StyleFloat value)
  System.Void UnityEngine.UIElements.IStyle.set_flexShrink(UnityEngine.UIElements.StyleFloat value)
  System.Void UnityEngine.UIElements.IStyle.set_fontSize(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_height(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_left(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_marginBottom(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_marginLeft(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_marginRight(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_marginTop(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_maxHeight(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_maxWidth(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_minWidth(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_opacity(UnityEngine.UIElements.StyleFloat value)
  System.Void UnityEngine.UIElements.IStyle.set_paddingBottom(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_paddingLeft(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_paddingRight(UnityEngine.UIElements.StyleLength value)
  UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.get_paddingTop()
  System.Void UnityEngine.UIElements.IStyle.set_paddingTop(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_position(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Position> value)
  System.Void UnityEngine.UIElements.IStyle.set_right(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_top(UnityEngine.UIElements.StyleLength value)
  System.Void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(UnityEngine.UIElements.StyleColor value)
  System.Void UnityEngine.UIElements.IStyle.set_visibility(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Visibility> value)
  UnityEngine.UIElements.StyleLength UnityEngine.UIElements.IStyle.get_width()
  System.Void UnityEngine.UIElements.IStyle.set_width(UnityEngine.UIElements.StyleLength value)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.LengthUnit
TYPE:  struct
TOKEN: 0x200025B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.LengthUnitPixel  // 0x0
  public    static  UnityEngine.UIElements.LengthUnitPercent  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.Length
TYPE:  struct
TOKEN: 0x200025C
FIELDS:
  private   static  System.Single                   k_MaxValue  // 0x0
  private           System.Single                   m_Value  // 0x10
  private           UnityEngine.UIElements.Length.Unitm_Unit  // 0x14
METHODS:
  UnityEngine.UIElements.Length Percent(System.Single value)
  UnityEngine.UIElements.Length Auto()
  UnityEngine.UIElements.Length None()
  System.Single get_value()
  System.Void set_value(System.Single value)
  UnityEngine.UIElements.LengthUnit get_unit()
  System.Boolean IsAuto()
  System.Boolean IsNone()
  System.Void .ctor(System.Single value)
  System.Void .ctor(System.Single value, UnityEngine.UIElements.LengthUnit unit)
  System.Void .ctor(System.Single value, UnityEngine.UIElements.Length.Unit unit)
  UnityEngine.UIElements.Length op_Implicit(System.Single value)
  System.Boolean op_Equality(UnityEngine.UIElements.Length lhs, UnityEngine.UIElements.Length rhs)
  System.Boolean op_Inequality(UnityEngine.UIElements.Length lhs, UnityEngine.UIElements.Length rhs)
  System.Boolean Equals(UnityEngine.UIElements.Length other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.Rotate
TYPE:  struct
TOKEN: 0x200025E
FIELDS:
  private           UnityEngine.UIElements.Angle    m_Angle  // 0x10
  private           UnityEngine.Vector3             m_Axis  // 0x18
  private           System.Boolean                  m_IsNone  // 0x24
METHODS:
  System.Void .ctor(UnityEngine.UIElements.Angle angle)
  UnityEngine.UIElements.Rotate Initial()
  UnityEngine.UIElements.Rotate None()
  UnityEngine.UIElements.Angle get_angle()
  System.Void set_angle(UnityEngine.UIElements.Angle value)
  UnityEngine.Vector3 get_axis()
  System.Boolean op_Equality(UnityEngine.UIElements.Rotate lhs, UnityEngine.UIElements.Rotate rhs)
  System.Boolean op_Inequality(UnityEngine.UIElements.Rotate lhs, UnityEngine.UIElements.Rotate rhs)
  System.Boolean Equals(UnityEngine.UIElements.Rotate other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
  UnityEngine.Quaternion ToQuaternion()
END_CLASS

CLASS: UnityEngine.UIElements.Scale
TYPE:  struct
TOKEN: 0x200025F
FIELDS:
  private           UnityEngine.Vector3             m_Scale  // 0x10
  private           System.Boolean                  m_IsNone  // 0x1C
METHODS:
  System.Void .ctor(UnityEngine.Vector3 scale)
  UnityEngine.UIElements.Scale Initial()
  UnityEngine.UIElements.Scale None()
  UnityEngine.Vector3 get_value()
  System.Boolean op_Equality(UnityEngine.UIElements.Scale lhs, UnityEngine.UIElements.Scale rhs)
  System.Boolean op_Inequality(UnityEngine.UIElements.Scale lhs, UnityEngine.UIElements.Scale rhs)
  System.Boolean Equals(UnityEngine.UIElements.Scale other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleColor
TYPE:  struct
TOKEN: 0x2000260
FIELDS:
  private           UnityEngine.Color               m_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x20
METHODS:
  UnityEngine.Color get_value()
  UnityEngine.UIElements.StyleKeyword get_keyword()
  System.Void .ctor(UnityEngine.Color v)
  System.Void .ctor(UnityEngine.Color v, UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean op_Equality(UnityEngine.UIElements.StyleColor lhs, UnityEngine.UIElements.StyleColor rhs)
  UnityEngine.UIElements.StyleColor op_Implicit(UnityEngine.Color v)
  System.Boolean Equals(UnityEngine.UIElements.StyleColor other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleCursor
TYPE:  struct
TOKEN: 0x2000261
FIELDS:
  private           UnityEngine.UIElements.Cursor   m_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x28
METHODS:
  UnityEngine.UIElements.Cursor get_value()
  UnityEngine.UIElements.StyleKeyword get_keyword()
  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  System.Void .ctor(UnityEngine.UIElements.Cursor v, UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean op_Equality(UnityEngine.UIElements.StyleCursor lhs, UnityEngine.UIElements.StyleCursor rhs)
  UnityEngine.UIElements.StyleCursor op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean Equals(UnityEngine.UIElements.StyleCursor other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleDataRef`1
TYPE:  struct
TOKEN: 0x2000262
FIELDS:
  private           UnityEngine.UIElements.StyleDataRef.RefCounted<T>m_Ref  // 0x0
METHODS:
  UnityEngine.UIElements.StyleDataRef<T> Acquire()
  System.Void Release()
  System.Void CopyFrom(UnityEngine.UIElements.StyleDataRef<T> other)
  T& Read()
  T& Write()
  UnityEngine.UIElements.StyleDataRef<T> Create()
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.UIElements.StyleDataRef<T> lhs, UnityEngine.UIElements.StyleDataRef<T> rhs)
  System.Boolean Equals(UnityEngine.UIElements.StyleDataRef<T> other)
  System.Boolean Equals(System.Object obj)
END_CLASS

CLASS: UnityEngine.UIElements.StyleEnum`1
TYPE:  struct
TOKEN: 0x2000264
FIELDS:
  private           T                               m_Value  // 0x0
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x0
METHODS:
  T get_value()
  UnityEngine.UIElements.StyleKeyword get_keyword()
  System.Void .ctor(T v)
  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  System.Void .ctor(T v, UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean op_Equality(UnityEngine.UIElements.StyleEnum<T> lhs, UnityEngine.UIElements.StyleEnum<T> rhs)
  System.Boolean op_Inequality(UnityEngine.UIElements.StyleEnum<T> lhs, UnityEngine.UIElements.StyleEnum<T> rhs)
  UnityEngine.UIElements.StyleEnum<T> op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  UnityEngine.UIElements.StyleEnum<T> op_Implicit(T v)
  System.Boolean Equals(UnityEngine.UIElements.StyleEnum<T> other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleFloat
TYPE:  struct
TOKEN: 0x2000265
FIELDS:
  private           System.Single                   m_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x14
METHODS:
  System.Single get_value()
  UnityEngine.UIElements.StyleKeyword get_keyword()
  System.Void .ctor(System.Single v)
  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  System.Void .ctor(System.Single v, UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean op_Equality(UnityEngine.UIElements.StyleFloat lhs, UnityEngine.UIElements.StyleFloat rhs)
  UnityEngine.UIElements.StyleFloat op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  UnityEngine.UIElements.StyleFloat op_Implicit(System.Single v)
  System.Boolean Equals(UnityEngine.UIElements.StyleFloat other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleInt
TYPE:  struct
TOKEN: 0x2000266
FIELDS:
  private           System.Int32                    m_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x14
METHODS:
  System.Int32 get_value()
  UnityEngine.UIElements.StyleKeyword get_keyword()
  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  System.Void .ctor(System.Int32 v, UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean op_Equality(UnityEngine.UIElements.StyleInt lhs, UnityEngine.UIElements.StyleInt rhs)
  UnityEngine.UIElements.StyleInt op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean Equals(UnityEngine.UIElements.StyleInt other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleLength
TYPE:  struct
TOKEN: 0x2000267
FIELDS:
  private           UnityEngine.UIElements.Length   m_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x18
METHODS:
  UnityEngine.UIElements.Length get_value()
  UnityEngine.UIElements.StyleKeyword get_keyword()
  System.Void .ctor(System.Single v)
  System.Void .ctor(UnityEngine.UIElements.Length v)
  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  System.Void .ctor(UnityEngine.UIElements.Length v, UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean op_Equality(UnityEngine.UIElements.StyleLength lhs, UnityEngine.UIElements.StyleLength rhs)
  UnityEngine.UIElements.StyleLength op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  UnityEngine.UIElements.StyleLength op_Implicit(System.Single v)
  UnityEngine.UIElements.StyleLength op_Implicit(UnityEngine.UIElements.Length v)
  System.Boolean Equals(UnityEngine.UIElements.StyleLength other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleRotate
TYPE:  struct
TOKEN: 0x2000268
FIELDS:
  private           UnityEngine.UIElements.Rotate   m_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x28
METHODS:
  UnityEngine.UIElements.Rotate get_value()
  UnityEngine.UIElements.StyleKeyword get_keyword()
  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  System.Void .ctor(UnityEngine.UIElements.Rotate v, UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean op_Equality(UnityEngine.UIElements.StyleRotate lhs, UnityEngine.UIElements.StyleRotate rhs)
  UnityEngine.UIElements.StyleRotate op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean Equals(UnityEngine.UIElements.StyleRotate other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleScale
TYPE:  struct
TOKEN: 0x2000269
FIELDS:
  private           UnityEngine.UIElements.Scale    m_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x20
METHODS:
  UnityEngine.UIElements.Scale get_value()
  UnityEngine.UIElements.StyleKeyword get_keyword()
  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  System.Void .ctor(UnityEngine.UIElements.Scale v, UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean op_Equality(UnityEngine.UIElements.StyleScale lhs, UnityEngine.UIElements.StyleScale rhs)
  UnityEngine.UIElements.StyleScale op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean Equals(UnityEngine.UIElements.StyleScale other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleTranslate
TYPE:  struct
TOKEN: 0x200026A
FIELDS:
  private           UnityEngine.UIElements.Translatem_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x28
METHODS:
  UnityEngine.UIElements.Translate get_value()
  UnityEngine.UIElements.StyleKeyword get_keyword()
  System.Void .ctor(UnityEngine.UIElements.Translate v)
  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  System.Void .ctor(UnityEngine.UIElements.Translate v, UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean op_Equality(UnityEngine.UIElements.StyleTranslate lhs, UnityEngine.UIElements.StyleTranslate rhs)
  UnityEngine.UIElements.StyleTranslate op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  UnityEngine.UIElements.StyleTranslate op_Implicit(UnityEngine.UIElements.Translate v)
  System.Boolean Equals(UnityEngine.UIElements.StyleTranslate other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleTextShadow
TYPE:  struct
TOKEN: 0x200026B
FIELDS:
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x10
  private           UnityEngine.UIElements.TextShadowm_Value  // 0x14
METHODS:
  UnityEngine.UIElements.TextShadow get_value()
  UnityEngine.UIElements.StyleKeyword get_keyword()
  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  System.Void .ctor(UnityEngine.UIElements.TextShadow v, UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean op_Equality(UnityEngine.UIElements.StyleTextShadow lhs, UnityEngine.UIElements.StyleTextShadow rhs)
  UnityEngine.UIElements.StyleTextShadow op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean Equals(UnityEngine.UIElements.StyleTextShadow other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleTransformOrigin
TYPE:  struct
TOKEN: 0x200026C
FIELDS:
  private           UnityEngine.UIElements.TransformOriginm_Value  // 0x10
  private           UnityEngine.UIElements.StyleKeywordm_Keyword  // 0x24
METHODS:
  UnityEngine.UIElements.TransformOrigin get_value()
  UnityEngine.UIElements.StyleKeyword get_keyword()
  System.Void .ctor(UnityEngine.UIElements.StyleKeyword keyword)
  System.Void .ctor(UnityEngine.UIElements.TransformOrigin v, UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean op_Equality(UnityEngine.UIElements.StyleTransformOrigin lhs, UnityEngine.UIElements.StyleTransformOrigin rhs)
  UnityEngine.UIElements.StyleTransformOrigin op_Implicit(UnityEngine.UIElements.StyleKeyword keyword)
  System.Boolean Equals(UnityEngine.UIElements.StyleTransformOrigin other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.IStyleValue`1
TYPE:  interface
TOKEN: 0x200026D
FIELDS:
METHODS:
  T get_value()
  UnityEngine.UIElements.StyleKeyword get_keyword()
END_CLASS

CLASS: UnityEngine.UIElements.StyleKeyword
TYPE:  struct
TOKEN: 0x200026E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleKeywordUndefined  // 0x0
  public    static  UnityEngine.UIElements.StyleKeywordNull  // 0x0
  public    static  UnityEngine.UIElements.StyleKeywordAuto  // 0x0
  public    static  UnityEngine.UIElements.StyleKeywordNone  // 0x0
  public    static  UnityEngine.UIElements.StyleKeywordInitial  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleValueExtensions
TYPE:  class
TOKEN: 0x200026F
FIELDS:
METHODS:
  System.String DebugString(UnityEngine.UIElements.IStyleValue<T> styleValue)
  UnityEngine.Yoga.YogaValue ToYogaValue(UnityEngine.UIElements.Length length)
  UnityEngine.UIElements.Length ToLength(UnityEngine.UIElements.StyleKeyword keyword)
  UnityEngine.UIElements.Rotate ToRotate(UnityEngine.UIElements.StyleKeyword keyword)
  UnityEngine.UIElements.Scale ToScale(UnityEngine.UIElements.StyleKeyword keyword)
  UnityEngine.UIElements.Translate ToTranslate(UnityEngine.UIElements.StyleKeyword keyword)
  UnityEngine.UIElements.Length ToLength(UnityEngine.UIElements.StyleLength styleLength)
  System.Void CopyFrom(System.Collections.Generic.List<T> list, System.Collections.Generic.List<T> other)
END_CLASS

CLASS: UnityEngine.UIElements.TimeUnit
TYPE:  struct
TOKEN: 0x2000270
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.TimeUnit Second  // 0x0
  public    static  UnityEngine.UIElements.TimeUnit Millisecond  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.TimeValue
TYPE:  struct
TOKEN: 0x2000271
FIELDS:
  private           System.Single                   m_Value  // 0x10
  private           UnityEngine.UIElements.TimeUnit m_Unit  // 0x14
METHODS:
  System.Single get_value()
  UnityEngine.UIElements.TimeUnit get_unit()
  System.Void .ctor(System.Single value)
  System.Void .ctor(System.Single value, UnityEngine.UIElements.TimeUnit unit)
  UnityEngine.UIElements.TimeValue op_Implicit(System.Single value)
  System.Boolean op_Equality(UnityEngine.UIElements.TimeValue lhs, UnityEngine.UIElements.TimeValue rhs)
  System.Boolean op_Inequality(UnityEngine.UIElements.TimeValue lhs, UnityEngine.UIElements.TimeValue rhs)
  System.Boolean Equals(UnityEngine.UIElements.TimeValue other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.TransformOrigin
TYPE:  struct
TOKEN: 0x2000272
FIELDS:
  private           UnityEngine.UIElements.Length   m_X  // 0x10
  private           UnityEngine.UIElements.Length   m_Y  // 0x18
  private           System.Single                   m_Z  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.UIElements.Length x, UnityEngine.UIElements.Length y, System.Single z)
  UnityEngine.UIElements.TransformOrigin Initial()
  UnityEngine.UIElements.Length get_x()
  System.Void set_x(UnityEngine.UIElements.Length value)
  UnityEngine.UIElements.Length get_y()
  System.Void set_y(UnityEngine.UIElements.Length value)
  System.Single get_z()
  System.Boolean op_Equality(UnityEngine.UIElements.TransformOrigin lhs, UnityEngine.UIElements.TransformOrigin rhs)
  System.Boolean op_Inequality(UnityEngine.UIElements.TransformOrigin lhs, UnityEngine.UIElements.TransformOrigin rhs)
  System.Boolean Equals(UnityEngine.UIElements.TransformOrigin other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.Translate
TYPE:  struct
TOKEN: 0x2000273
FIELDS:
  private           UnityEngine.UIElements.Length   m_X  // 0x10
  private           UnityEngine.UIElements.Length   m_Y  // 0x18
  private           System.Single                   m_Z  // 0x20
  private           System.Boolean                  m_isNone  // 0x24
METHODS:
  System.Void .ctor(UnityEngine.UIElements.Length x, UnityEngine.UIElements.Length y, System.Single z)
  UnityEngine.UIElements.Translate None()
  UnityEngine.UIElements.Length get_x()
  System.Void set_x(UnityEngine.UIElements.Length value)
  UnityEngine.UIElements.Length get_y()
  System.Void set_y(UnityEngine.UIElements.Length value)
  System.Single get_z()
  System.Boolean op_Equality(UnityEngine.UIElements.Translate lhs, UnityEngine.UIElements.Translate rhs)
  System.Boolean op_Inequality(UnityEngine.UIElements.Translate lhs, UnityEngine.UIElements.Translate rhs)
  System.Boolean Equals(UnityEngine.UIElements.Translate other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.IResolvedStyle
TYPE:  interface
TOKEN: 0x2000274
FIELDS:
METHODS:
  UnityEngine.Color get_backgroundColor()
  UnityEngine.Color get_borderBottomColor()
  System.Single get_borderBottomLeftRadius()
  System.Single get_borderBottomRightRadius()
  System.Single get_borderBottomWidth()
  UnityEngine.Color get_borderLeftColor()
  System.Single get_borderLeftWidth()
  UnityEngine.Color get_borderRightColor()
  System.Single get_borderRightWidth()
  UnityEngine.Color get_borderTopColor()
  System.Single get_borderTopLeftRadius()
  System.Single get_borderTopRightRadius()
  System.Single get_borderTopWidth()
  System.Single get_bottom()
  UnityEngine.Color get_color()
  UnityEngine.UIElements.DisplayStyle get_display()
  UnityEngine.UIElements.FlexDirection get_flexDirection()
  System.Single get_flexGrow()
  System.Single get_flexShrink()
  System.Single get_height()
  System.Single get_left()
  System.Single get_marginBottom()
  System.Single get_marginLeft()
  System.Single get_marginRight()
  System.Single get_marginTop()
  UnityEngine.UIElements.StyleFloat get_minHeight()
  UnityEngine.UIElements.StyleFloat get_minWidth()
  System.Single get_opacity()
  System.Single get_paddingBottom()
  System.Single get_paddingLeft()
  System.Single get_paddingRight()
  System.Single get_paddingTop()
  System.Single get_right()
  UnityEngine.UIElements.Scale get_scale()
  System.Single get_top()
  UnityEngine.Vector3 get_transformOrigin()
  UnityEngine.Vector3 get_translate()
  UnityEngine.Color get_unityBackgroundImageTintColor()
  System.Int32 get_unitySliceLeft()
  System.Int32 get_unitySliceRight()
  UnityEngine.Color get_unityTextOutlineColor()
  System.Single get_unityTextOutlineWidth()
  UnityEngine.UIElements.Visibility get_visibility()
  UnityEngine.UIElements.WhiteSpace get_whiteSpace()
  System.Single get_width()
END_CLASS

CLASS: UnityEngine.UIElements.IStyle
TYPE:  interface
TOKEN: 0x2000275
FIELDS:
METHODS:
  System.Void set_backgroundColor(UnityEngine.UIElements.StyleColor value)
  System.Void set_borderBottomColor(UnityEngine.UIElements.StyleColor value)
  System.Void set_borderBottomLeftRadius(UnityEngine.UIElements.StyleLength value)
  System.Void set_borderBottomRightRadius(UnityEngine.UIElements.StyleLength value)
  System.Void set_borderBottomWidth(UnityEngine.UIElements.StyleFloat value)
  System.Void set_borderLeftColor(UnityEngine.UIElements.StyleColor value)
  System.Void set_borderLeftWidth(UnityEngine.UIElements.StyleFloat value)
  System.Void set_borderRightColor(UnityEngine.UIElements.StyleColor value)
  System.Void set_borderRightWidth(UnityEngine.UIElements.StyleFloat value)
  System.Void set_borderTopColor(UnityEngine.UIElements.StyleColor value)
  System.Void set_borderTopLeftRadius(UnityEngine.UIElements.StyleLength value)
  System.Void set_borderTopRightRadius(UnityEngine.UIElements.StyleLength value)
  System.Void set_borderTopWidth(UnityEngine.UIElements.StyleFloat value)
  System.Void set_bottom(UnityEngine.UIElements.StyleLength value)
  System.Void set_color(UnityEngine.UIElements.StyleColor value)
  UnityEngine.UIElements.StyleCursor get_cursor()
  UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> get_display()
  System.Void set_display(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> value)
  System.Void set_flexBasis(UnityEngine.UIElements.StyleLength value)
  System.Void set_flexDirection(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.FlexDirection> value)
  System.Void set_flexGrow(UnityEngine.UIElements.StyleFloat value)
  System.Void set_flexShrink(UnityEngine.UIElements.StyleFloat value)
  System.Void set_fontSize(UnityEngine.UIElements.StyleLength value)
  System.Void set_height(UnityEngine.UIElements.StyleLength value)
  System.Void set_left(UnityEngine.UIElements.StyleLength value)
  System.Void set_marginBottom(UnityEngine.UIElements.StyleLength value)
  System.Void set_marginLeft(UnityEngine.UIElements.StyleLength value)
  System.Void set_marginRight(UnityEngine.UIElements.StyleLength value)
  System.Void set_marginTop(UnityEngine.UIElements.StyleLength value)
  System.Void set_maxHeight(UnityEngine.UIElements.StyleLength value)
  System.Void set_maxWidth(UnityEngine.UIElements.StyleLength value)
  System.Void set_minWidth(UnityEngine.UIElements.StyleLength value)
  System.Void set_opacity(UnityEngine.UIElements.StyleFloat value)
  System.Void set_paddingBottom(UnityEngine.UIElements.StyleLength value)
  System.Void set_paddingLeft(UnityEngine.UIElements.StyleLength value)
  System.Void set_paddingRight(UnityEngine.UIElements.StyleLength value)
  UnityEngine.UIElements.StyleLength get_paddingTop()
  System.Void set_paddingTop(UnityEngine.UIElements.StyleLength value)
  System.Void set_position(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Position> value)
  System.Void set_right(UnityEngine.UIElements.StyleLength value)
  UnityEngine.UIElements.StyleRotate get_rotate()
  UnityEngine.UIElements.StyleScale get_scale()
  UnityEngine.UIElements.StyleTextShadow get_textShadow()
  System.Void set_top(UnityEngine.UIElements.StyleLength value)
  UnityEngine.UIElements.StyleTransformOrigin get_transformOrigin()
  UnityEngine.UIElements.StyleTranslate get_translate()
  System.Void set_translate(UnityEngine.UIElements.StyleTranslate value)
  System.Void set_unityBackgroundImageTintColor(UnityEngine.UIElements.StyleColor value)
  System.Void set_visibility(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Visibility> value)
  UnityEngine.UIElements.StyleLength get_width()
  System.Void set_width(UnityEngine.UIElements.StyleLength value)
END_CLASS

CLASS: UnityEngine.UIElements.IStyleDataGroup`1
TYPE:  interface
TOKEN: 0x2000276
FIELDS:
METHODS:
  T Copy()
  System.Void CopyFrom(T& other)
END_CLASS

CLASS: UnityEngine.UIElements.InheritedData
TYPE:  struct
TOKEN: 0x2000277
FIELDS:
  public            UnityEngine.Color               color  // 0x10
  public            UnityEngine.UIElements.Length   fontSize  // 0x20
  public            UnityEngine.UIElements.Length   letterSpacing  // 0x28
  public            UnityEngine.UIElements.TextShadowtextShadow  // 0x30
  public            UnityEngine.Font                unityFont  // 0x50
  public            UnityEngine.UIElements.FontDefinitionunityFontDefinition  // 0x58
  public            UnityEngine.FontStyle           unityFontStyleAndWeight  // 0x68
  public            UnityEngine.UIElements.Length   unityParagraphSpacing  // 0x6C
  public            UnityEngine.TextAnchor          unityTextAlign  // 0x74
  public            UnityEngine.Color               unityTextOutlineColor  // 0x78
  public            System.Single                   unityTextOutlineWidth  // 0x88
  public            UnityEngine.UIElements.Visibilityvisibility  // 0x8C
  public            UnityEngine.UIElements.WhiteSpacewhiteSpace  // 0x90
  public            UnityEngine.UIElements.Length   wordSpacing  // 0x94
METHODS:
  UnityEngine.UIElements.InheritedData Copy()
  System.Void CopyFrom(UnityEngine.UIElements.InheritedData& other)
  System.Boolean op_Equality(UnityEngine.UIElements.InheritedData lhs, UnityEngine.UIElements.InheritedData rhs)
  System.Boolean Equals(UnityEngine.UIElements.InheritedData other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.LayoutData
TYPE:  struct
TOKEN: 0x2000278
FIELDS:
  public            UnityEngine.UIElements.Align    alignContent  // 0x10
  public            UnityEngine.UIElements.Align    alignItems  // 0x14
  public            UnityEngine.UIElements.Align    alignSelf  // 0x18
  public            System.Single                   borderBottomWidth  // 0x1C
  public            System.Single                   borderLeftWidth  // 0x20
  public            System.Single                   borderRightWidth  // 0x24
  public            System.Single                   borderTopWidth  // 0x28
  public            UnityEngine.UIElements.Length   bottom  // 0x2C
  public            UnityEngine.UIElements.DisplayStyledisplay  // 0x34
  public            UnityEngine.UIElements.Length   flexBasis  // 0x38
  public            UnityEngine.UIElements.FlexDirectionflexDirection  // 0x40
  public            System.Single                   flexGrow  // 0x44
  public            System.Single                   flexShrink  // 0x48
  public            UnityEngine.UIElements.Wrap     flexWrap  // 0x4C
  public            UnityEngine.UIElements.Length   height  // 0x50
  public            UnityEngine.UIElements.Justify  justifyContent  // 0x58
  public            UnityEngine.UIElements.Length   left  // 0x5C
  public            UnityEngine.UIElements.Length   marginBottom  // 0x64
  public            UnityEngine.UIElements.Length   marginLeft  // 0x6C
  public            UnityEngine.UIElements.Length   marginRight  // 0x74
  public            UnityEngine.UIElements.Length   marginTop  // 0x7C
  public            UnityEngine.UIElements.Length   maxHeight  // 0x84
  public            UnityEngine.UIElements.Length   maxWidth  // 0x8C
  public            UnityEngine.UIElements.Length   minHeight  // 0x94
  public            UnityEngine.UIElements.Length   minWidth  // 0x9C
  public            UnityEngine.UIElements.Length   paddingBottom  // 0xA4
  public            UnityEngine.UIElements.Length   paddingLeft  // 0xAC
  public            UnityEngine.UIElements.Length   paddingRight  // 0xB4
  public            UnityEngine.UIElements.Length   paddingTop  // 0xBC
  public            UnityEngine.UIElements.Position position  // 0xC4
  public            UnityEngine.UIElements.Length   right  // 0xC8
  public            UnityEngine.UIElements.Length   top  // 0xD0
  public            UnityEngine.UIElements.Length   width  // 0xD8
METHODS:
  UnityEngine.UIElements.LayoutData Copy()
  System.Void CopyFrom(UnityEngine.UIElements.LayoutData& other)
  System.Boolean op_Equality(UnityEngine.UIElements.LayoutData lhs, UnityEngine.UIElements.LayoutData rhs)
  System.Boolean Equals(UnityEngine.UIElements.LayoutData other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.RareData
TYPE:  struct
TOKEN: 0x2000279
FIELDS:
  public            UnityEngine.UIElements.Cursor   cursor  // 0x10
  public            UnityEngine.UIElements.TextOverflowtextOverflow  // 0x28
  public            UnityEngine.Color               unityBackgroundImageTintColor  // 0x2C
  public            UnityEngine.ScaleMode           unityBackgroundScaleMode  // 0x3C
  public            UnityEngine.UIElements.OverflowClipBoxunityOverflowClipBox  // 0x40
  public            System.Int32                    unitySliceBottom  // 0x44
  public            System.Int32                    unitySliceLeft  // 0x48
  public            System.Int32                    unitySliceRight  // 0x4C
  public            System.Int32                    unitySliceTop  // 0x50
  public            UnityEngine.UIElements.TextOverflowPositionunityTextOverflowPosition  // 0x54
METHODS:
  UnityEngine.UIElements.RareData Copy()
  System.Void CopyFrom(UnityEngine.UIElements.RareData& other)
  System.Boolean op_Equality(UnityEngine.UIElements.RareData lhs, UnityEngine.UIElements.RareData rhs)
  System.Boolean Equals(UnityEngine.UIElements.RareData other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.TransformData
TYPE:  struct
TOKEN: 0x200027A
FIELDS:
  public            UnityEngine.UIElements.Rotate   rotate  // 0x10
  public            UnityEngine.UIElements.Scale    scale  // 0x28
  public            UnityEngine.UIElements.TransformOrigintransformOrigin  // 0x38
  public            UnityEngine.UIElements.Translatetranslate  // 0x4C
METHODS:
  UnityEngine.UIElements.TransformData Copy()
  System.Void CopyFrom(UnityEngine.UIElements.TransformData& other)
  System.Boolean op_Equality(UnityEngine.UIElements.TransformData lhs, UnityEngine.UIElements.TransformData rhs)
  System.Boolean Equals(UnityEngine.UIElements.TransformData other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.TransitionData
TYPE:  struct
TOKEN: 0x200027B
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>transitionDelay  // 0x10
  public            System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>transitionDuration  // 0x18
  public            System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName>transitionProperty  // 0x20
  public            System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction>transitionTimingFunction  // 0x28
METHODS:
  UnityEngine.UIElements.TransitionData Copy()
  System.Void CopyFrom(UnityEngine.UIElements.TransitionData& other)
  System.Boolean op_Equality(UnityEngine.UIElements.TransitionData lhs, UnityEngine.UIElements.TransitionData rhs)
  System.Boolean Equals(UnityEngine.UIElements.TransitionData other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.VisualData
TYPE:  struct
TOKEN: 0x200027C
FIELDS:
  public            UnityEngine.Color               backgroundColor  // 0x10
  public            UnityEngine.UIElements.BackgroundbackgroundImage  // 0x20
  public            UnityEngine.Color               borderBottomColor  // 0x40
  public            UnityEngine.UIElements.Length   borderBottomLeftRadius  // 0x50
  public            UnityEngine.UIElements.Length   borderBottomRightRadius  // 0x58
  public            UnityEngine.Color               borderLeftColor  // 0x60
  public            UnityEngine.Color               borderRightColor  // 0x70
  public            UnityEngine.Color               borderTopColor  // 0x80
  public            UnityEngine.UIElements.Length   borderTopLeftRadius  // 0x90
  public            UnityEngine.UIElements.Length   borderTopRightRadius  // 0x98
  public            System.Single                   opacity  // 0xA0
  public            UnityEngine.UIElements.OverflowInternaloverflow  // 0xA4
METHODS:
  UnityEngine.UIElements.VisualData Copy()
  System.Void CopyFrom(UnityEngine.UIElements.VisualData& other)
  System.Boolean op_Equality(UnityEngine.UIElements.VisualData lhs, UnityEngine.UIElements.VisualData rhs)
  System.Boolean Equals(UnityEngine.UIElements.VisualData other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.Hashes
TYPE:  struct
TOKEN: 0x200027D
FIELDS:
  public    static  System.Int32                    kSize  // 0x0
  public            UnityEngine.UIElements.Hashes.<hashes>e__FixedBufferhashes  // 0x10
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleComplexSelector
TYPE:  class
TOKEN: 0x200027F
FIELDS:
  public            UnityEngine.UIElements.Hashes   ancestorHashes  // 0x10
  private           System.Int32                    m_Specificity  // 0x20
  private           UnityEngine.UIElements.StyleRule<rule>k__BackingField  // 0x28
  private           System.Boolean                  m_isSimple  // 0x30
  private           UnityEngine.UIElements.StyleSelector[]m_Selectors  // 0x38
  private           System.Int32                    ruleIndex  // 0x40
  private           UnityEngine.UIElements.StyleComplexSelectornextInTable  // 0x48
  private           System.Int32                    orderInStyleSheet  // 0x50
  private   static  System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleComplexSelector.PseudoStateData>s_PseudoStates  // 0x0
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart>m_HashList  // 0x8
METHODS:
  System.Int32 get_specificity()
  UnityEngine.UIElements.StyleRule get_rule()
  System.Void set_rule(UnityEngine.UIElements.StyleRule value)
  System.Boolean get_isSimple()
  UnityEngine.UIElements.StyleSelector[] get_selectors()
  System.Void set_selectors(UnityEngine.UIElements.StyleSelector[] value)
  System.Void OnBeforeSerialize()
  System.Void OnAfterDeserialize()
  System.Void CachePseudoStateMasks()
  System.String ToString()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleProperty
TYPE:  class
TOKEN: 0x2000282
FIELDS:
  private           System.String                   m_Name  // 0x10
  private           System.Int32                    m_Line  // 0x18
  private           UnityEngine.UIElements.StyleValueHandle[]m_Values  // 0x20
  private           System.Boolean                  isCustomProperty  // 0x28
  private           System.Boolean                  requireVariableResolve  // 0x29
METHODS:
  System.String get_name()
  UnityEngine.UIElements.StyleValueHandle[] get_values()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleRule
TYPE:  class
TOKEN: 0x2000283
FIELDS:
  private           UnityEngine.UIElements.StyleProperty[]m_Properties  // 0x10
  private           System.Int32                    line  // 0x18
  private           System.Int32                    customPropertiesCount  // 0x1C
METHODS:
  UnityEngine.UIElements.StyleProperty[] get_properties()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSelector
TYPE:  class
TOKEN: 0x2000284
FIELDS:
  private           UnityEngine.UIElements.StyleSelectorPart[]m_Parts  // 0x10
  private           UnityEngine.UIElements.StyleSelectorRelationshipm_PreviousRelationship  // 0x18
  private           System.Int32                    pseudoStateMask  // 0x1C
  private           System.Int32                    negatedPseudoStateMask  // 0x20
METHODS:
  UnityEngine.UIElements.StyleSelectorPart[] get_parts()
  System.Void set_parts(UnityEngine.UIElements.StyleSelectorPart[] value)
  UnityEngine.UIElements.StyleSelectorRelationship get_previousRelationship()
  System.Void set_previousRelationship(UnityEngine.UIElements.StyleSelectorRelationship value)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSelectorPart
TYPE:  struct
TOKEN: 0x2000286
FIELDS:
  private           System.String                   m_Value  // 0x10
  private           UnityEngine.UIElements.StyleSelectorTypem_Type  // 0x18
  private           System.Object                   tempData  // 0x20
METHODS:
  System.String get_value()
  UnityEngine.UIElements.StyleSelectorType get_type()
  System.Void set_type(UnityEngine.UIElements.StyleSelectorType value)
  System.String ToString()
  UnityEngine.UIElements.StyleSelectorPart CreateClass(System.String className)
  UnityEngine.UIElements.StyleSelectorPart CreateId(System.String Id)
  UnityEngine.UIElements.StyleSelectorPart CreatePredicate(System.Object predicate)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSelectorRelationship
TYPE:  struct
TOKEN: 0x2000287
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSelectorRelationshipNone  // 0x0
  public    static  UnityEngine.UIElements.StyleSelectorRelationshipChild  // 0x0
  public    static  UnityEngine.UIElements.StyleSelectorRelationshipDescendent  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSelectorType
TYPE:  struct
TOKEN: 0x2000288
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSelectorTypeUnknown  // 0x0
  public    static  UnityEngine.UIElements.StyleSelectorTypeWildcard  // 0x0
  public    static  UnityEngine.UIElements.StyleSelectorTypeType  // 0x0
  public    static  UnityEngine.UIElements.StyleSelectorTypeClass  // 0x0
  public    static  UnityEngine.UIElements.StyleSelectorTypePseudoClass  // 0x0
  public    static  UnityEngine.UIElements.StyleSelectorTypeRecursivePseudoClass  // 0x0
  public    static  UnityEngine.UIElements.StyleSelectorTypeID  // 0x0
  public    static  UnityEngine.UIElements.StyleSelectorTypePredicate  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheet
TYPE:  class
TOKEN: 0x2000289
EXTENDS: ScriptableObject
FIELDS:
  private           System.Boolean                  m_ImportedWithErrors  // 0x18
  private           System.Boolean                  m_ImportedWithWarnings  // 0x19
  private           UnityEngine.UIElements.StyleRule[]m_Rules  // 0x20
  private           UnityEngine.UIElements.StyleComplexSelector[]m_ComplexSelectors  // 0x28
  private           System.Single[]                 floats  // 0x30
  private           UnityEngine.UIElements.StyleSheets.Dimension[]dimensions  // 0x38
  private           UnityEngine.Color[]             colors  // 0x40
  private           System.String[]                 strings  // 0x48
  private           UnityEngine.Object[]            assets  // 0x50
  private           UnityEngine.UIElements.StyleSheet.ImportStruct[]imports  // 0x58
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet>m_FlattenedImportedStyleSheets  // 0x60
  private           System.Int32                    m_ContentHash  // 0x68
  private           UnityEngine.UIElements.StyleSheets.ScalableImage[]scalableImages  // 0x70
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleComplexSelector>orderedNameSelectors  // 0x78
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleComplexSelector>orderedTypeSelectors  // 0x80
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleComplexSelector>orderedClassSelectors  // 0x88
  private           System.Boolean                  m_IsDefaultStyleSheet  // 0x90
  private   static  System.String                   kCustomPropertyMarker  // 0x0
METHODS:
  System.Boolean get_importedWithErrors()
  System.Void set_importedWithErrors(System.Boolean value)
  System.Boolean get_importedWithWarnings()
  System.Void set_importedWithWarnings(System.Boolean value)
  UnityEngine.UIElements.StyleRule[] get_rules()
  System.Void set_rules(UnityEngine.UIElements.StyleRule[] value)
  UnityEngine.UIElements.StyleComplexSelector[] get_complexSelectors()
  System.Void set_complexSelectors(UnityEngine.UIElements.StyleComplexSelector[] value)
  System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> get_flattenedRecursiveImports()
  System.Int32 get_contentHash()
  System.Void set_contentHash(System.Int32 value)
  System.Boolean get_isDefaultStyleSheet()
  System.Void set_isDefaultStyleSheet(System.Boolean value)
  System.Boolean TryCheckAccess(T[] list, UnityEngine.UIElements.StyleValueType type, UnityEngine.UIElements.StyleValueHandle handle, T& value)
  T CheckAccess(T[] list, UnityEngine.UIElements.StyleValueType type, UnityEngine.UIElements.StyleValueHandle handle)
  System.Void OnEnable()
  System.Void FlattenImportedStyleSheetsRecursive()
  System.Void FlattenImportedStyleSheetsRecursive(UnityEngine.UIElements.StyleSheet sheet)
  System.Void SetupReferences()
  UnityEngine.UIElements.StyleValueKeyword ReadKeyword(UnityEngine.UIElements.StyleValueHandle handle)
  System.Single ReadFloat(UnityEngine.UIElements.StyleValueHandle handle)
  System.Boolean TryReadFloat(UnityEngine.UIElements.StyleValueHandle handle, System.Single& value)
  UnityEngine.UIElements.StyleSheets.Dimension ReadDimension(UnityEngine.UIElements.StyleValueHandle handle)
  System.Boolean TryReadDimension(UnityEngine.UIElements.StyleValueHandle handle, UnityEngine.UIElements.StyleSheets.Dimension& value)
  UnityEngine.Color ReadColor(UnityEngine.UIElements.StyleValueHandle handle)
  System.Boolean TryReadColor(UnityEngine.UIElements.StyleValueHandle handle, UnityEngine.Color& value)
  System.String ReadString(UnityEngine.UIElements.StyleValueHandle handle)
  System.Boolean TryReadString(UnityEngine.UIElements.StyleValueHandle handle, System.String& value)
  System.String ReadEnum(UnityEngine.UIElements.StyleValueHandle handle)
  System.Boolean TryReadEnum(UnityEngine.UIElements.StyleValueHandle handle, System.String& value)
  System.String ReadVariable(UnityEngine.UIElements.StyleValueHandle handle)
  System.Boolean TryReadVariable(UnityEngine.UIElements.StyleValueHandle handle, System.String& value)
  System.String ReadResourcePath(UnityEngine.UIElements.StyleValueHandle handle)
  System.Boolean TryReadResourcePath(UnityEngine.UIElements.StyleValueHandle handle, System.String& value)
  UnityEngine.Object ReadAssetReference(UnityEngine.UIElements.StyleValueHandle handle)
  System.String ReadMissingAssetReferenceUrl(UnityEngine.UIElements.StyleValueHandle handle)
  System.Boolean TryReadAssetReference(UnityEngine.UIElements.StyleValueHandle handle, UnityEngine.Object& value)
  UnityEngine.UIElements.StyleValueFunction ReadFunction(UnityEngine.UIElements.StyleValueHandle handle)
  System.String ReadFunctionName(UnityEngine.UIElements.StyleValueHandle handle)
  UnityEngine.UIElements.StyleSheets.ScalableImage ReadScalableImage(UnityEngine.UIElements.StyleValueHandle handle)
  System.Boolean CustomStartsWith(System.String originalString, System.String pattern)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleValueFunction
TYPE:  struct
TOKEN: 0x200028B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleValueFunctionUnknown  // 0x0
  public    static  UnityEngine.UIElements.StyleValueFunctionVar  // 0x0
  public    static  UnityEngine.UIElements.StyleValueFunctionEnv  // 0x0
  public    static  UnityEngine.UIElements.StyleValueFunctionLinearGradient  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleValueFunctionExtension
TYPE:  class
TOKEN: 0x200028C
FIELDS:
METHODS:
  System.String ToUssString(UnityEngine.UIElements.StyleValueFunction svf)
END_CLASS

CLASS: UnityEngine.UIElements.StyleValueHandle
TYPE:  struct
TOKEN: 0x200028D
FIELDS:
  private           UnityEngine.UIElements.StyleValueTypem_ValueType  // 0x10
  private           System.Int32                    valueIndex  // 0x14
METHODS:
  UnityEngine.UIElements.StyleValueType get_valueType()
  System.Void set_valueType(UnityEngine.UIElements.StyleValueType value)
END_CLASS

CLASS: UnityEngine.UIElements.StyleValueKeyword
TYPE:  struct
TOKEN: 0x200028E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleValueKeywordInherit  // 0x0
  public    static  UnityEngine.UIElements.StyleValueKeywordInitial  // 0x0
  public    static  UnityEngine.UIElements.StyleValueKeywordAuto  // 0x0
  public    static  UnityEngine.UIElements.StyleValueKeywordUnset  // 0x0
  public    static  UnityEngine.UIElements.StyleValueKeywordTrue  // 0x0
  public    static  UnityEngine.UIElements.StyleValueKeywordFalse  // 0x0
  public    static  UnityEngine.UIElements.StyleValueKeywordNone  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleValueKeywordExtension
TYPE:  class
TOKEN: 0x200028F
FIELDS:
METHODS:
  System.String ToUssString(UnityEngine.UIElements.StyleValueKeyword svk)
END_CLASS

CLASS: UnityEngine.UIElements.StyleValueType
TYPE:  struct
TOKEN: 0x2000290
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleValueTypeInvalid  // 0x0
  public    static  UnityEngine.UIElements.StyleValueTypeKeyword  // 0x0
  public    static  UnityEngine.UIElements.StyleValueTypeFloat  // 0x0
  public    static  UnityEngine.UIElements.StyleValueTypeDimension  // 0x0
  public    static  UnityEngine.UIElements.StyleValueTypeColor  // 0x0
  public    static  UnityEngine.UIElements.StyleValueTypeResourcePath  // 0x0
  public    static  UnityEngine.UIElements.StyleValueTypeAssetReference  // 0x0
  public    static  UnityEngine.UIElements.StyleValueTypeEnum  // 0x0
  public    static  UnityEngine.UIElements.StyleValueTypeVariable  // 0x0
  public    static  UnityEngine.UIElements.StyleValueTypeString  // 0x0
  public    static  UnityEngine.UIElements.StyleValueTypeFunction  // 0x0
  public    static  UnityEngine.UIElements.StyleValueTypeCommaSeparator  // 0x0
  public    static  UnityEngine.UIElements.StyleValueTypeScalableImage  // 0x0
  public    static  UnityEngine.UIElements.StyleValueTypeMissingAssetReference  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleVariable
TYPE:  struct
TOKEN: 0x2000291
FIELDS:
  public    readonly System.String                   name  // 0x10
  public    readonly UnityEngine.UIElements.StyleSheetsheet  // 0x18
  public    readonly UnityEngine.UIElements.StyleValueHandle[]handles  // 0x20
METHODS:
  System.Void .ctor(System.String name, UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.StyleVariableContext
TYPE:  class
TOKEN: 0x2000292
FIELDS:
  public    static readonly UnityEngine.UIElements.StyleVariableContextnone  // 0x0
  private           System.Int32                    m_VariableHash  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleVariable>m_Variables  // 0x18
  private           System.Collections.Generic.List<System.Int32>m_SortedHash  // 0x20
  private           System.Collections.Generic.List<System.Int32>m_UnsortedHash  // 0x28
METHODS:
  System.Void Add(UnityEngine.UIElements.StyleVariable sv)
  System.Void AddInitialRange(UnityEngine.UIElements.StyleVariableContext other)
  System.Void Clear()
  System.Void .ctor()
  System.Void .ctor(UnityEngine.UIElements.StyleVariableContext other)
  System.Boolean TryFindVariable(System.String name, UnityEngine.UIElements.StyleVariable& v)
  System.Int32 GetVariableHash()
  System.Void .cctor()
  System.Int32 <Add>g__ComputeOrderSensitiveHash|7_0(System.Int32 index, UnityEngine.UIElements.StyleVariableContext.<>c__DisplayClass7_0& )
END_CLASS

CLASS: UnityEngine.UIElements.StyleVariableResolver
TYPE:  class
TOKEN: 0x2000294
FIELDS:
  private   static  System.Int32                    kMaxResolves  // 0x0
  private   static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParsers_SyntaxParser  // 0x0
  private           UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcherm_Matcher  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue>m_ResolvedValues  // 0x18
  private           System.Collections.Generic.Stack<System.String>m_ResolvedVarStack  // 0x20
  private           UnityEngine.UIElements.StylePropertym_Property  // 0x28
  private           System.Collections.Generic.Stack<UnityEngine.UIElements.StyleVariableResolver.ResolveContext>m_ContextStack  // 0x30
  private           UnityEngine.UIElements.StyleVariableResolver.ResolveContextm_CurrentContext  // 0x38
  private           UnityEngine.UIElements.StyleVariableContext<variableContext>k__BackingField  // 0x48
METHODS:
  UnityEngine.UIElements.StyleSheet get_currentSheet()
  UnityEngine.UIElements.StyleValueHandle[] get_currentHandles()
  System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> get_resolvedValues()
  UnityEngine.UIElements.StyleVariableContext get_variableContext()
  System.Void set_variableContext(UnityEngine.UIElements.StyleVariableContext value)
  System.Void Init(UnityEngine.UIElements.StyleProperty property, UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles)
  System.Void PushContext(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles)
  System.Void PopContext()
  System.Void AddValue(UnityEngine.UIElements.StyleValueHandle handle)
  System.Boolean ResolveVarFunction(System.Int32& index)
  UnityEngine.UIElements.StyleVariableResolver.Result ResolveVarFunction(System.Int32& index, System.Int32 argc, System.String varName)
  System.Boolean ValidateResolvedValues()
  UnityEngine.UIElements.StyleVariableResolver.Result ResolveVariable(System.String variableName)
  UnityEngine.UIElements.StyleVariableResolver.Result ResolveFallback(System.Int32& index)
  System.Void ParseVarFunction(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle[] handles, System.Int32& index, System.Int32& argCount, System.String& variableName)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ThemeStyleSheet
TYPE:  class
TOKEN: 0x2000297
EXTENDS: StyleSheet
FIELDS:
METHODS:
  System.Void OnEnable()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.PanelTextSettings
TYPE:  class
TOKEN: 0x2000298
EXTENDS: TextSettings
FIELDS:
  private   static  UnityEngine.UIElements.PanelTextSettingss_DefaultPanelTextSettings  // 0x0
  private   static  System.Func<System.String,UnityEngine.Object>EditorGUIUtilityLoad  // 0x8
  private   static  System.Func<UnityEngine.SystemLanguage>GetCurrentLanguage  // 0x10
  private   static readonly System.String                   s_DefaultEditorPanelTextSettingPath  // 0x18
METHODS:
  UnityEngine.UIElements.PanelTextSettings get_defaultPanelTextSettings()
  System.Void UpdateLocalizationFontAsset()
  UnityEngine.TextCore.Text.FontAsset GetCachedFontAsset(UnityEngine.Font font)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.ITextHandle
TYPE:  interface
TOKEN: 0x2000299
FIELDS:
METHODS:
  UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.CursorPositionStylePainterParameters parms, System.Single scaling)
  System.Single ComputeTextWidth(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling)
  System.Single ComputeTextHeight(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling)
  System.Single GetLineHeight(System.Int32 characterIndex, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, System.Single textScaling, System.Single pixelPerPoint)
  UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single pixelsPerPoint)
  System.Boolean IsLegacy()
  System.Boolean IsElided()
  System.Void set_MeasuredSizes(UnityEngine.Vector2 value)
  System.Void set_RoundedSizes(UnityEngine.Vector2 value)
END_CLASS

CLASS: UnityEngine.UIElements.TextCoreHandle
TYPE:  struct
TOKEN: 0x200029A
FIELDS:
  private           UnityEngine.Vector2             <MeasuredSizes>k__BackingField  // 0x10
  private           UnityEngine.Vector2             <RoundedSizes>k__BackingField  // 0x18
  private           UnityEngine.Vector2             m_PreferredSize  // 0x20
  private           System.Int32                    m_PreviousGenerationSettingsHash  // 0x28
  private           UnityEngine.TextCore.Text.TextGenerationSettingsm_CurrentGenerationSettings  // 0x30
  private   static  UnityEngine.TextCore.Text.TextGenerationSettingss_LayoutSettings  // 0x0
  private           UnityEngine.TextCore.Text.TextInfom_TextInfoMesh  // 0x38
  private   static  UnityEngine.TextCore.Text.TextInfos_TextInfoLayout  // 0x8
  private           System.Boolean                  isDirty  // 0x40
METHODS:
  UnityEngine.Vector2 get_MeasuredSizes()
  System.Void set_MeasuredSizes(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_RoundedSizes()
  System.Void set_RoundedSizes(UnityEngine.Vector2 value)
  UnityEngine.UIElements.ITextHandle New()
  UnityEngine.TextCore.Text.TextInfo get_textInfoMesh()
  UnityEngine.TextCore.Text.TextInfo get_textInfoLayout()
  System.Boolean IsLegacy()
  System.Boolean IsDirty(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms)
  UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.CursorPositionStylePainterParameters parms, System.Single scaling)
  System.Single ComputeTextWidth(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling)
  System.Single ComputeTextHeight(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling)
  System.Single GetLineHeight(System.Int32 characterIndex, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, System.Single textScaling, System.Single pixelPerPoint)
  UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single pixelsPerPoint)
  System.Void UpdatePreferredValues(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms)
  UnityEngine.TextCore.Text.TextOverflowMode GetTextOverflowMode(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams)
  System.Void UpdateGenerationSettingsCommon(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams painterParams, UnityEngine.TextCore.Text.TextGenerationSettings settings)
  System.Boolean IsElided()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.TextNativeHandle
TYPE:  struct
TOKEN: 0x200029B
FIELDS:
  private           UnityEngine.Vector2             <MeasuredSizes>k__BackingField  // 0x10
  private           UnityEngine.Vector2             <RoundedSizes>k__BackingField  // 0x18
  private           Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex>textVertices  // 0x20
  private           System.Int32                    m_PreviousTextParamsHash  // 0x30
METHODS:
  UnityEngine.Vector2 get_MeasuredSizes()
  System.Void set_MeasuredSizes(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_RoundedSizes()
  System.Void set_RoundedSizes(UnityEngine.Vector2 value)
  UnityEngine.UIElements.ITextHandle New()
  System.Boolean IsLegacy()
  System.Single GetLineHeight(System.Int32 characterIndex, UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, System.Single textScaling, System.Single pixelPerPoint)
  UnityEngine.TextCore.Text.TextInfo Update(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single pixelsPerPoint)
  Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> GetVertices(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling)
  UnityEngine.Vector2 GetCursorPosition(UnityEngine.UIElements.CursorPositionStylePainterParameters parms, System.Single scaling)
  System.Single ComputeTextWidth(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling)
  System.Single ComputeTextHeight(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams parms, System.Single scaling)
  System.Boolean IsElided()
END_CLASS

CLASS: UnityEngine.UIElements.TextUtilities
TYPE:  class
TOKEN: 0x200029C
FIELDS:
METHODS:
  System.Single ComputeTextScaling(UnityEngine.Matrix4x4 worldMatrix, System.Single pixelsPerPoint)
  UnityEngine.Vector2 MeasureVisualElementTextSize(UnityEngine.UIElements.VisualElement ve, System.String textToMeasure, System.Single width, UnityEngine.UIElements.VisualElement.MeasureMode widthMode, System.Single height, UnityEngine.UIElements.VisualElement.MeasureMode heightMode, UnityEngine.UIElements.ITextHandle textHandle)
  UnityEngine.TextCore.Text.FontAsset GetFontAsset(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParam)
  UnityEngine.TextCore.Text.FontAsset GetFontAsset(UnityEngine.UIElements.VisualElement ve)
  UnityEngine.Font GetFont(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParam)
  UnityEngine.Font GetFont(UnityEngine.UIElements.VisualElement ve)
  System.Boolean IsFontAssigned(UnityEngine.UIElements.VisualElement ve)
  System.Boolean IsFontAssigned(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams)
  UnityEngine.UIElements.PanelTextSettings GetTextSettingsFrom(UnityEngine.UIElements.VisualElement ve)
  UnityEngine.UIElements.PanelTextSettings GetTextSettingsFrom(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParam)
  UnityEngine.UIElements.UIR.TextCoreSettings GetTextCoreSettingsForElement(UnityEngine.UIElements.VisualElement ve)
END_CLASS

CLASS: UnityEngine.UIElements.IUxmlAttributes
TYPE:  interface
TOKEN: 0x200029D
FIELDS:
METHODS:
  System.Boolean TryGetAttributeValue(System.String attributeName, System.String& value)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlRootElementFactory
TYPE:  class
TOKEN: 0x200029E
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.String get_uxmlName()
  System.String get_uxmlQualifiedName()
  UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlRootElementTraits
TYPE:  class
TOKEN: 0x200029F
EXTENDS: UxmlTraits
FIELDS:
  protected         UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Name  // 0x18
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Class  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlStyleFactory
TYPE:  class
TOKEN: 0x20002A0
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.String get_uxmlName()
  System.String get_uxmlQualifiedName()
  UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlStyleTraits
TYPE:  class
TOKEN: 0x20002A1
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Name  // 0x18
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Path  // 0x20
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Src  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlTemplateFactory
TYPE:  class
TOKEN: 0x20002A2
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.String get_uxmlName()
  System.String get_uxmlQualifiedName()
  UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlTemplateTraits
TYPE:  class
TOKEN: 0x20002A3
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Name  // 0x18
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Path  // 0x20
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_Src  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlAttributeOverridesFactory
TYPE:  class
TOKEN: 0x20002A4
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.String get_uxmlName()
  System.String get_uxmlQualifiedName()
  UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlAttributeOverridesTraits
TYPE:  class
TOKEN: 0x20002A5
EXTENDS: UxmlTraits
FIELDS:
  private           UnityEngine.UIElements.UxmlStringAttributeDescriptionm_ElementName  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.TemplateAsset
TYPE:  class
TOKEN: 0x20002A6
EXTENDS: VisualElementAsset
FIELDS:
  private           System.String                   m_TemplateAlias  // 0x70
  private           System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride>m_AttributeOverrides  // 0x78
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotUsageEntry>m_SlotUsages  // 0x80
METHODS:
  System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> get_attributeOverrides()
  System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotUsageEntry> get_slotUsages()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlAttributeDescription
TYPE:  class
TOKEN: 0x20002A8
FIELDS:
  private           System.String                   <name>k__BackingField  // 0x10
  private           System.String[]                 m_ObsoleteNames  // 0x18
  private           System.String                   <type>k__BackingField  // 0x20
  private           System.String                   <typeNamespace>k__BackingField  // 0x28
  private           UnityEngine.UIElements.UxmlAttributeDescription.Use<use>k__BackingField  // 0x30
  private           UnityEngine.UIElements.UxmlTypeRestriction<restriction>k__BackingField  // 0x38
METHODS:
  System.Void .ctor()
  System.String get_name()
  System.Void set_name(System.String value)
  System.Void set_obsoleteNames(System.Collections.Generic.IEnumerable<System.String> value)
  System.Void set_type(System.String value)
  System.Void set_typeNamespace(System.String value)
  System.Void set_use(UnityEngine.UIElements.UxmlAttributeDescription.Use value)
  System.Void set_restriction(UnityEngine.UIElements.UxmlTypeRestriction value)
  System.Boolean TryGetValueFromBagAsString(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.String& value)
  System.Boolean TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.Func<System.String,T,T> converterFunc, T defaultValue, T& value)
  T GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.Func<System.String,T,T> converterFunc, T defaultValue)
END_CLASS

CLASS: UnityEngine.UIElements.TypedUxmlAttributeDescription`1
TYPE:  class
TOKEN: 0x20002AA
EXTENDS: UxmlAttributeDescription
FIELDS:
  private           T                               <defaultValue>k__BackingField  // 0x0
METHODS:
  T GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  T get_defaultValue()
  System.Void set_defaultValue(T value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlStringAttributeDescription
TYPE:  class
TOKEN: 0x20002AB
EXTENDS: TypedUxmlAttributeDescription`1
FIELDS:
METHODS:
  System.Void .ctor()
  System.String GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Boolean TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.String& value)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlFloatAttributeDescription
TYPE:  class
TOKEN: 0x20002AD
EXTENDS: TypedUxmlAttributeDescription`1
FIELDS:
METHODS:
  System.Void .ctor()
  System.Single GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Single ConvertValueToFloat(System.String v, System.Single defaultValue)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlIntAttributeDescription
TYPE:  class
TOKEN: 0x20002AF
EXTENDS: TypedUxmlAttributeDescription`1
FIELDS:
METHODS:
  System.Void .ctor()
  System.Int32 GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Boolean TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, System.Int32& value)
  System.Int32 ConvertValueToInt(System.String v, System.Int32 defaultValue)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlLongAttributeDescription
TYPE:  class
TOKEN: 0x20002B1
EXTENDS: TypedUxmlAttributeDescription`1
FIELDS:
METHODS:
  System.Void .ctor()
  System.Int64 GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Int64 ConvertValueToLong(System.String v, System.Int64 defaultValue)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlBoolAttributeDescription
TYPE:  class
TOKEN: 0x20002B3
EXTENDS: TypedUxmlAttributeDescription`1
FIELDS:
METHODS:
  System.Void .ctor()
  System.Boolean GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Boolean ConvertValueToBool(System.String v, System.Boolean defaultValue)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlEnumAttributeDescription`1
TYPE:  class
TOKEN: 0x20002B5
EXTENDS: TypedUxmlAttributeDescription`1
FIELDS:
METHODS:
  System.Void .ctor()
  T GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Boolean TryGetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc, T& value)
  U ConvertValueToEnum(System.String v, U defaultValue)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlObjectAttributeDescription`1
TYPE:  class
TOKEN: 0x20002B7
FIELDS:
  private           T                               <defaultValue>k__BackingField  // 0x0
METHODS:
  T get_defaultValue()
  T GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlObjectListAttributeDescription`1
TYPE:  class
TOKEN: 0x20002B8
EXTENDS: UxmlObjectAttributeDescription`1
FIELDS:
METHODS:
  System.Collections.Generic.List<T> GetValueFromBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlTraits
TYPE:  class
TOKEN: 0x20002B9
FIELDS:
  private           System.Boolean                  <canHaveAnyAttribute>k__BackingField  // 0x10
METHODS:
  System.Void .ctor()
  System.Void set_canHaveAnyAttribute(System.Boolean value)
  System.Void Init(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
END_CLASS

CLASS: UnityEngine.UIElements.IUxmlFactory
TYPE:  interface
TOKEN: 0x20002BA
FIELDS:
METHODS:
  System.String get_uxmlQualifiedName()
  System.Boolean AcceptsAttributeBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlFactory`2
TYPE:  class
TOKEN: 0x20002BB
FIELDS:
  private           TTraits                         m_Traits  // 0x0
METHODS:
  System.Void .ctor()
  System.String get_uxmlName()
  System.String get_uxmlNamespace()
  System.String get_uxmlQualifiedName()
  System.Boolean AcceptsAttributeBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlFactory`1
TYPE:  class
TOKEN: 0x20002BC
EXTENDS: UxmlFactory`2
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.BaseUxmlTraits
TYPE:  class
TOKEN: 0x20002BD
FIELDS:
  private           System.Boolean                  <canHaveAnyAttribute>k__BackingField  // 0x10
METHODS:
  System.Void .ctor()
  System.Void set_canHaveAnyAttribute(System.Boolean value)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlObjectTraits`1
TYPE:  class
TOKEN: 0x20002BE
EXTENDS: BaseUxmlTraits
FIELDS:
METHODS:
  System.Void Init(T& obj, UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.IBaseUxmlFactory
TYPE:  interface
TOKEN: 0x20002BF
FIELDS:
METHODS:
  System.String get_uxmlQualifiedName()
  System.Boolean AcceptsAttributeBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
END_CLASS

CLASS: UnityEngine.UIElements.IBaseUxmlObjectFactory
TYPE:  interface
TOKEN: 0x20002C0
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.IUxmlObjectFactory`1
TYPE:  interface
TOKEN: 0x20002C1
FIELDS:
METHODS:
  T CreateObject(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlObjectFactory`2
TYPE:  class
TOKEN: 0x20002C2
EXTENDS: BaseUxmlFactory`2
FIELDS:
METHODS:
  TCreatedType CreateObject(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.BaseUxmlFactory`2
TYPE:  class
TOKEN: 0x20002C3
FIELDS:
  private           TTraits                         m_Traits  // 0x0
METHODS:
  System.Void .ctor()
  System.String get_uxmlQualifiedName()
  System.Boolean AcceptsAttributeBag(UnityEngine.UIElements.IUxmlAttributes bag, UnityEngine.UIElements.CreationContext cc)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlAsset
TYPE:  class
TOKEN: 0x20002C4
FIELDS:
  private           System.String                   m_FullTypeName  // 0x10
  private           System.Int32                    m_Id  // 0x18
  private           System.Int32                    m_OrderInDocument  // 0x1C
  private           System.Int32                    m_ParentId  // 0x20
  protected         System.Collections.Generic.List<System.String>m_Properties  // 0x28
METHODS:
  System.String get_fullTypeName()
  System.Int32 get_id()
  System.Int32 get_orderInDocument()
  System.Int32 get_parentId()
  System.Boolean TryGetAttributeValue(System.String propertyName, System.String& value)
  System.Void SetAttribute(System.String name, System.String value)
  System.Void SetOrAddProperty(System.String propertyName, System.String propertyValue)
END_CLASS

CLASS: UnityEngine.UIElements.UxmlObjectAsset
TYPE:  class
TOKEN: 0x20002C5
EXTENDS: UxmlAsset
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UxmlObjectFactoryRegistry
TYPE:  class
TOKEN: 0x20002C6
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IBaseUxmlObjectFactory>>s_Factories  // 0x0
METHODS:
  System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IBaseUxmlObjectFactory>> get_factories()
  System.Void RegisterFactory(UnityEngine.UIElements.IBaseUxmlObjectFactory factory)
  System.Boolean TryGetFactories(System.String fullTypeName, System.Collections.Generic.List<UnityEngine.UIElements.IBaseUxmlObjectFactory>& factoryList)
  System.Void RegisterEngineFactories()
  System.Void RegisterUserFactories()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlTypeRestriction
TYPE:  class
TOKEN: 0x20002C7
FIELDS:
METHODS:
  System.Boolean Equals(UnityEngine.UIElements.UxmlTypeRestriction other)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UxmlEnumeration
TYPE:  class
TOKEN: 0x20002C8
EXTENDS: UxmlTypeRestriction
FIELDS:
  private           System.Collections.Generic.List<System.String>m_Values  // 0x10
METHODS:
  System.Collections.Generic.IEnumerable<System.String> get_values()
  System.Void set_values(System.Collections.Generic.IEnumerable<System.String> value)
  System.Boolean Equals(UnityEngine.UIElements.UxmlTypeRestriction other)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementAsset
TYPE:  class
TOKEN: 0x20002C9
EXTENDS: UxmlAsset
FIELDS:
  private           System.String                   m_Name  // 0x30
  private           System.Int32                    m_RuleIndex  // 0x38
  private           System.String                   m_Text  // 0x40
  private           UnityEngine.UIElements.PickingModem_PickingMode  // 0x48
  private           System.String[]                 m_Classes  // 0x50
  private           System.Collections.Generic.List<System.String>m_StylesheetPaths  // 0x58
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet>m_Stylesheets  // 0x60
  private           System.Boolean                  m_SkipClone  // 0x68
METHODS:
  System.Int32 get_ruleIndex()
  System.String[] get_classes()
  System.Collections.Generic.List<System.String> get_stylesheetPaths()
  System.Boolean get_hasStylesheetPaths()
  System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> get_stylesheets()
  System.Boolean get_hasStylesheets()
  System.Boolean get_skipClone()
  System.Void OnBeforeSerialize()
  System.Void OnAfterDeserialize()
END_CLASS

CLASS: UnityEngine.UIElements.VisualElementFactoryRegistry
TYPE:  class
TOKEN: 0x20002CA
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>>s_Factories  // 0x0
METHODS:
  System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>> get_factories()
  System.Void RegisterFactory(UnityEngine.UIElements.IUxmlFactory factory)
  System.Boolean TryGetValue(System.String fullTypeName, System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>& factoryList)
  System.Void RegisterEngineFactories()
  System.Void RegisterUserFactories()
END_CLASS

CLASS: UnityEngine.UIElements.VisualTreeAsset
TYPE:  class
TOKEN: 0x20002CB
EXTENDS: ScriptableObject
FIELDS:
  private   static  System.String                   LinkedVEAInTemplatePropertyName  // 0x0
  private           System.Boolean                  m_ImportedWithErrors  // 0x18
  private           System.Boolean                  m_ImportedWithWarnings  // 0x19
  private   static readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement>s_TemporarySlotInsertionPoints  // 0x8
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.UsingEntry>m_Usings  // 0x20
  private           UnityEngine.UIElements.StyleSheetinlineSheet  // 0x28
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset>m_VisualElementAssets  // 0x30
  private           System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset>m_TemplateAssets  // 0x38
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.UxmlObjectEntry>m_UxmlObjectEntries  // 0x40
  private           System.Collections.Generic.List<System.Int32>m_UxmlObjectIds  // 0x48
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.AssetEntry>m_AssetEntries  // 0x50
  private           System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition>m_Slots  // 0x58
  private           System.Int32                    m_ContentContainerId  // 0x60
  private           System.Int32                    m_ContentHash  // 0x64
METHODS:
  System.Boolean get_importedWithErrors()
  System.Void set_importedWithErrors(System.Boolean value)
  System.Boolean get_importedWithWarnings()
  System.Void set_importedWithWarnings(System.Boolean value)
  System.Int32 GetNextChildSerialNumber()
  System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset> get_templateDependencies()
  System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet> get_stylesheets()
  System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> get_visualElementAssets()
  System.Void set_visualElementAssets(System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> value)
  System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> get_templateAssets()
  System.Void set_templateAssets(System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> value)
  System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.UxmlObjectEntry> get_uxmlObjectEntries()
  System.Collections.Generic.List<System.Int32> get_uxmlObjectIds()
  System.Void RegisterUxmlObject(UnityEngine.UIElements.UxmlObjectAsset uxmlObjectAsset)
  System.Collections.Generic.List<T> GetUxmlObjects(UnityEngine.UIElements.IUxmlAttributes asset, UnityEngine.UIElements.CreationContext cc)
  System.Boolean AssetEntryExists(System.String path, System.Type type)
  System.Void RegisterAssetEntry(System.String path, System.Type type, UnityEngine.Object asset)
  T GetAsset(System.String path)
  UnityEngine.UIElements.VisualTreeAsset.UxmlObjectEntry GetUxmlObjectEntry(System.Int32 id)
  UnityEngine.UIElements.IBaseUxmlObjectFactory GetUxmlObjectFactory(UnityEngine.UIElements.UxmlObjectAsset uxmlObjectAsset)
  System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> get_slots()
  System.Void set_slots(System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> value)
  System.Int32 get_contentContainerId()
  System.Void set_contentContainerId(System.Int32 value)
  UnityEngine.UIElements.TemplateContainer Instantiate()
  UnityEngine.UIElements.TemplateContainer Instantiate(System.String bindingPath)
  UnityEngine.UIElements.TemplateContainer CloneTree()
  UnityEngine.UIElements.TemplateContainer CloneTree(System.String bindingPath)
  System.Void CloneTree(UnityEngine.UIElements.VisualElement target)
  System.Void CloneTree(UnityEngine.UIElements.VisualElement target, System.Int32& firstElementIndex, System.Int32& elementAddedCount)
  System.Void CloneTree(UnityEngine.UIElements.VisualElement target, System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> attributeOverrides)
  UnityEngine.UIElements.VisualElement CloneSetupRecursively(UnityEngine.UIElements.VisualElementAsset root, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset>> idToChildren, UnityEngine.UIElements.CreationContext context)
  System.Int32 CompareForOrder(UnityEngine.UIElements.VisualElementAsset a, UnityEngine.UIElements.VisualElementAsset b)
  System.Boolean TryGetSlotInsertionPoint(System.Int32 insertionPointId, System.String& slotName)
  UnityEngine.UIElements.VisualTreeAsset ResolveTemplate(System.String templateName)
  UnityEngine.UIElements.VisualElement Create(UnityEngine.UIElements.VisualElementAsset asset, UnityEngine.UIElements.CreationContext ctx)
  System.Void AssignClassListFromAssetToElement(UnityEngine.UIElements.VisualElementAsset asset, UnityEngine.UIElements.VisualElement element)
  System.Void AssignStyleSheetFromAssetToElement(UnityEngine.UIElements.VisualElementAsset asset, UnityEngine.UIElements.VisualElement element)
  System.Int32 get_contentHash()
  System.Void set_contentHash(System.Int32 value)
  System.Void .ctor()
  System.Void .cctor()
  UnityEngine.UIElements.VisualElement <Create>g__CreateError|65_0(UnityEngine.UIElements.VisualTreeAsset.<>c__DisplayClass65_0& )
END_CLASS

CLASS: UnityEngine.UIElements.CreationContext
TYPE:  struct
TOKEN: 0x20002D6
FIELDS:
  public    static readonly UnityEngine.UIElements.CreationContextDefault  // 0x0
  private           UnityEngine.UIElements.VisualElement<target>k__BackingField  // 0x10
  private           UnityEngine.UIElements.VisualTreeAsset<visualTreeAsset>k__BackingField  // 0x18
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement><slotInsertionPoints>k__BackingField  // 0x20
  private           System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride><attributeOverrides>k__BackingField  // 0x28
METHODS:
  UnityEngine.UIElements.VisualElement get_target()
  System.Void set_target(UnityEngine.UIElements.VisualElement value)
  UnityEngine.UIElements.VisualTreeAsset get_visualTreeAsset()
  System.Void set_visualTreeAsset(UnityEngine.UIElements.VisualTreeAsset value)
  System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> get_slotInsertionPoints()
  System.Void set_slotInsertionPoints(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> value)
  System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> get_attributeOverrides()
  System.Void set_attributeOverrides(System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> value)
  System.Void .ctor(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, UnityEngine.UIElements.VisualTreeAsset vta, UnityEngine.UIElements.VisualElement target)
  System.Void .ctor(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> attributeOverrides, UnityEngine.UIElements.VisualTreeAsset vta, UnityEngine.UIElements.VisualElement target)
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.UIElements.CreationContext other)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Experimental.Easing
TYPE:  class
TOKEN: 0x200035E
FIELDS:
METHODS:
  System.Single Linear(System.Single t)
  System.Single InSine(System.Single t)
  System.Single OutSine(System.Single t)
  System.Single InOutSine(System.Single t)
  System.Single InQuad(System.Single t)
  System.Single OutQuad(System.Single t)
  System.Single InOutQuad(System.Single t)
  System.Single InCubic(System.Single t)
  System.Single OutCubic(System.Single t)
  System.Single InOutCubic(System.Single t)
  System.Single InPower(System.Single t, System.Int32 power)
  System.Single OutPower(System.Single t, System.Int32 power)
  System.Single InOutPower(System.Single t, System.Int32 power)
  System.Single InBounce(System.Single t)
  System.Single OutBounce(System.Single t)
  System.Single InOutBounce(System.Single t)
  System.Single InElastic(System.Single t)
  System.Single OutElastic(System.Single t)
  System.Single InOutElastic(System.Single t)
  System.Single InBack(System.Single t)
  System.Single OutBack(System.Single t)
  System.Single InOutBack(System.Single t)
  System.Single InCirc(System.Single t)
  System.Single OutCirc(System.Single t)
  System.Single InOutCirc(System.Single t)
END_CLASS

CLASS: UnityEngine.UIElements.Experimental.StyleValues
TYPE:  struct
TOKEN: 0x200035F
FIELDS:
  private           UnityEngine.UIElements.StyleValueCollectionm_StyleValues  // 0x10
METHODS:
  System.Void set_top(System.Single value)
  System.Void set_left(System.Single value)
  System.Void set_width(System.Single value)
  System.Void set_height(System.Single value)
  System.Void set_right(System.Single value)
  System.Void set_bottom(System.Single value)
  System.Void set_color(UnityEngine.Color value)
  System.Void set_backgroundColor(UnityEngine.Color value)
  System.Void set_unityBackgroundImageTintColor(UnityEngine.Color value)
  System.Void set_borderColor(UnityEngine.Color value)
  System.Void set_marginLeft(System.Single value)
  System.Void set_marginTop(System.Single value)
  System.Void set_marginRight(System.Single value)
  System.Void set_marginBottom(System.Single value)
  System.Void set_paddingLeft(System.Single value)
  System.Single get_paddingTop()
  System.Void set_paddingTop(System.Single value)
  System.Void set_paddingRight(System.Single value)
  System.Void set_paddingBottom(System.Single value)
  System.Void set_borderLeftWidth(System.Single value)
  System.Void set_borderRightWidth(System.Single value)
  System.Void set_borderTopWidth(System.Single value)
  System.Void set_borderBottomWidth(System.Single value)
  System.Void set_borderTopLeftRadius(System.Single value)
  System.Void set_borderTopRightRadius(System.Single value)
  System.Void set_borderBottomLeftRadius(System.Single value)
  System.Void set_borderBottomRightRadius(System.Single value)
  System.Void set_opacity(System.Single value)
  System.Void set_flexGrow(System.Single value)
  System.Void set_flexShrink(System.Single value)
  System.Void SetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, System.Single value)
  System.Void SetValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, UnityEngine.Color value)
  UnityEngine.UIElements.StyleValueCollection Values()
END_CLASS

CLASS: UnityEngine.UIElements.Experimental.ITransitionAnimations
TYPE:  interface
TOKEN: 0x2000360
FIELDS:
METHODS:
  UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(UnityEngine.UIElements.Experimental.StyleValues to, System.Int32 durationMs)
END_CLASS

CLASS: UnityEngine.UIElements.Experimental.Lerp
TYPE:  class
TOKEN: 0x2000361
FIELDS:
METHODS:
  System.Single Interpolate(System.Single start, System.Single end, System.Single ratio)
  UnityEngine.Color Interpolate(UnityEngine.Color start, UnityEngine.Color end, System.Single ratio)
  UnityEngine.UIElements.Experimental.StyleValues Interpolate(UnityEngine.UIElements.Experimental.StyleValues start, UnityEngine.UIElements.Experimental.StyleValues end, System.Single ratio)
END_CLASS

CLASS: UnityEngine.UIElements.Experimental.IValueAnimationUpdate
TYPE:  interface
TOKEN: 0x2000362
FIELDS:
METHODS:
  System.Void Tick(System.Int64 currentTimeMs)
END_CLASS

CLASS: UnityEngine.UIElements.Experimental.ValueAnimation`1
TYPE:  class
TOKEN: 0x2000363
FIELDS:
  private           System.Int64                    m_StartTimeMs  // 0x0
  private           System.Int32                    m_DurationMs  // 0x0
  private           System.Func<System.Single,System.Single><easingCurve>k__BackingField  // 0x0
  private           System.Boolean                  <isRunning>k__BackingField  // 0x0
  private           System.Action                   <onAnimationCompleted>k__BackingField  // 0x0
  private           System.Boolean                  <autoRecycle>k__BackingField  // 0x0
  private           System.Boolean                  <recycled>k__BackingField  // 0x0
  private   static  UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.Experimental.ValueAnimation<T>>sObjectPool  // 0x0
  private           UnityEngine.UIElements.VisualElement<owner>k__BackingField  // 0x0
  private           System.Action<UnityEngine.UIElements.VisualElement,T><valueUpdated>k__BackingField  // 0x0
  private           System.Func<UnityEngine.UIElements.VisualElement,T><initialValue>k__BackingField  // 0x0
  private           System.Func<T,T,System.Single,T><interpolator>k__BackingField  // 0x0
  private           T                               _from  // 0x0
  private           System.Boolean                  fromValueSet  // 0x0
  private           T                               <to>k__BackingField  // 0x0
METHODS:
  System.Int32 get_durationMs()
  System.Void set_durationMs(System.Int32 value)
  System.Func<System.Single,System.Single> get_easingCurve()
  System.Void set_easingCurve(System.Func<System.Single,System.Single> value)
  System.Boolean get_isRunning()
  System.Void set_isRunning(System.Boolean value)
  System.Action get_onAnimationCompleted()
  System.Void set_onAnimationCompleted(System.Action value)
  System.Boolean get_autoRecycle()
  System.Void set_autoRecycle(System.Boolean value)
  System.Boolean get_recycled()
  System.Void set_recycled(System.Boolean value)
  UnityEngine.UIElements.VisualElement get_owner()
  System.Void set_owner(UnityEngine.UIElements.VisualElement value)
  System.Action<UnityEngine.UIElements.VisualElement,T> get_valueUpdated()
  System.Void set_valueUpdated(System.Action<UnityEngine.UIElements.VisualElement,T> value)
  System.Func<UnityEngine.UIElements.VisualElement,T> get_initialValue()
  System.Void set_initialValue(System.Func<UnityEngine.UIElements.VisualElement,T> value)
  System.Func<T,T,System.Single,T> get_interpolator()
  System.Void set_interpolator(System.Func<T,T,System.Single,T> value)
  T get_from()
  System.Void set_from(T value)
  T get_to()
  System.Void set_to(T value)
  System.Void .ctor()
  System.Void Start()
  System.Void Stop()
  System.Void Recycle()
  System.Void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(System.Int64 currentTimeMs)
  System.Void SetDefaultValues()
  System.Void Unregister()
  System.Void Register()
  System.Void SetOwner(UnityEngine.UIElements.VisualElement e)
  System.Void CheckNotRecycled()
  UnityEngine.UIElements.Experimental.ValueAnimation<T> Create(UnityEngine.UIElements.VisualElement e, System.Func<T,T,System.Single,T> interpolator)
  UnityEngine.UIElements.Experimental.ValueAnimation<T> KeepAlive()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Internal.MultiColumnHeaderColumnMovePreview
TYPE:  class
TOKEN: 0x2000327
EXTENDS: VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Internal.MultiColumnHeaderColumnMoveLocationPreview
TYPE:  class
TOKEN: 0x2000328
EXTENDS: VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   visualUssClassName  // 0x8
METHODS:
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Internal.ColumnMover
TYPE:  class
TOKEN: 0x2000329
EXTENDS: PointerManipulator
FIELDS:
  private           System.Single                   m_StartPos  // 0x38
  private           System.Single                   m_LastPos  // 0x3C
  private           System.Boolean                  m_Active  // 0x40
  private           System.Boolean                  m_Moving  // 0x41
  private           System.Boolean                  m_Cancelled  // 0x42
  private           UnityEngine.UIElements.Internal.MultiColumnCollectionHeaderm_Header  // 0x48
  private           UnityEngine.UIElements.VisualElementm_PreviewElement  // 0x50
  private           UnityEngine.UIElements.Internal.MultiColumnHeaderColumnMoveLocationPreviewm_LocationPreviewElement  // 0x58
  private           UnityEngine.UIElements.Column   m_ColumnToMove  // 0x60
  private           System.Single                   m_ColumnToMovePos  // 0x68
  private           System.Single                   m_ColumnToMoveWidth  // 0x6C
  private           UnityEngine.UIElements.Column   m_DestinationColumn  // 0x70
  private           System.Boolean                  m_MoveBeforeDestination  // 0x78
  private           UnityEngine.UIElements.ColumnLayout<columnLayout>k__BackingField  // 0x80
  private           System.Action<UnityEngine.UIElements.Internal.ColumnMover>activeChanged  // 0x88
  private           System.Action<UnityEngine.UIElements.Internal.ColumnMover>movingChanged  // 0x90
METHODS:
  UnityEngine.UIElements.ColumnLayout get_columnLayout()
  System.Void set_columnLayout(UnityEngine.UIElements.ColumnLayout value)
  System.Boolean get_active()
  System.Void set_active(System.Boolean value)
  System.Boolean get_moving()
  System.Void set_moving(System.Boolean value)
  System.Void add_activeChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value)
  System.Void remove_activeChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value)
  System.Void add_movingChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value)
  System.Void remove_movingChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value)
  System.Void .ctor()
  System.Void RegisterCallbacksOnTarget()
  System.Void UnregisterCallbacksFromTarget()
  System.Void OnMouseDown(UnityEngine.UIElements.MouseDownEvent evt)
  System.Void OnMouseMove(UnityEngine.UIElements.MouseMoveEvent evt)
  System.Void OnMouseUp(UnityEngine.UIElements.MouseUpEvent evt)
  System.Void OnMouseCaptureOut(UnityEngine.UIElements.MouseCaptureOutEvent evt)
  System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent evt)
  System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent evt)
  System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent evt)
  System.Void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent evt)
  System.Void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent evt)
  System.Boolean IsNotMouseEvent(System.Int32 pointerId)
  System.Void ProcessCancelEvent(UnityEngine.UIElements.EventBase evt, System.Int32 pointerId)
  System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent e)
  System.Void ProcessDownEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId)
  System.Void ProcessMoveEvent(UnityEngine.UIElements.EventBase e, UnityEngine.Vector2 localPosition)
  System.Void ProcessUpEvent(UnityEngine.UIElements.EventBase evt, UnityEngine.Vector2 localPosition, System.Int32 pointerId)
  System.Void BeginDragMove(System.Single pos)
  System.Void DragMove(System.Single pos)
  System.Void UpdatePreviewPosition()
  System.Void UpdateMoveLocation()
  System.Void EndDragMove(System.Boolean cancelled)
END_CLASS

CLASS: UnityEngine.UIElements.Internal.MultiColumnHeaderColumnResizePreview
TYPE:  class
TOKEN: 0x200032A
EXTENDS: VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   visualUssClassName  // 0x8
METHODS:
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Internal.ColumnResizer
TYPE:  class
TOKEN: 0x200032B
EXTENDS: PointerManipulator
FIELDS:
  private           UnityEngine.Vector2             m_Start  // 0x38
  protected         System.Boolean                  m_Active  // 0x40
  private           System.Boolean                  m_Resizing  // 0x41
  private           UnityEngine.UIElements.Internal.MultiColumnCollectionHeaderm_Header  // 0x48
  private           UnityEngine.UIElements.Column   m_Column  // 0x50
  private           UnityEngine.UIElements.VisualElementm_PreviewElement  // 0x58
  private           UnityEngine.UIElements.ColumnLayout<columnLayout>k__BackingField  // 0x60
  private           System.Boolean                  <preview>k__BackingField  // 0x68
METHODS:
  UnityEngine.UIElements.ColumnLayout get_columnLayout()
  System.Void set_columnLayout(UnityEngine.UIElements.ColumnLayout value)
  System.Boolean get_preview()
  System.Void set_preview(System.Boolean value)
  System.Void .ctor(UnityEngine.UIElements.Column column)
  System.Void RegisterCallbacksOnTarget()
  System.Void UnregisterCallbacksFromTarget()
  System.Void OnKeyDown(UnityEngine.UIElements.KeyDownEvent e)
  System.Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent e)
  System.Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent e)
  System.Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent e)
  System.Void BeginDragResize(System.Single pos)
  System.Void DragResize(System.Single pos)
  System.Void UpdatePreviewPosition()
  System.Void EndDragResize(System.Single pos, System.Boolean cancelled)
END_CLASS

CLASS: UnityEngine.UIElements.Internal.MultiColumnCollectionHeader
TYPE:  class
TOKEN: 0x200032C
EXTENDS: VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   columnContainerUssClassName  // 0x8
  public    static readonly System.String                   handleContainerUssClassName  // 0x10
  public    static readonly System.String                   reorderableUssClassName  // 0x18
  private           System.Boolean                  m_SortingEnabled  // 0x3C0
  private           System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription>m_SortedColumns  // 0x3C8
  private           UnityEngine.UIElements.SortColumnDescriptionsm_SortDescriptions  // 0x3D0
  private           System.Collections.Generic.List<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.SortedColumnState>m_OldSortedColumnStates  // 0x3D8
  private           System.Boolean                  m_SortingUpdatesTemporarilyDisabled  // 0x3E0
  private           UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ViewStatem_ViewState  // 0x3E8
  private           System.Boolean                  m_ApplyingViewState  // 0x3F0
  private           System.Boolean                  m_DoLayoutScheduled  // 0x3F1
  private   readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.Column,UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ColumnData><columnDataMap>k__BackingField  // 0x3F8
  private   readonly UnityEngine.UIElements.ColumnLayout<columnLayout>k__BackingField  // 0x400
  private   readonly UnityEngine.UIElements.VisualElement<columnContainer>k__BackingField  // 0x408
  private   readonly UnityEngine.UIElements.VisualElement<resizeHandleContainer>k__BackingField  // 0x410
  private   readonly UnityEngine.UIElements.Columns  <columns>k__BackingField  // 0x418
  private           System.Action<System.Int32,System.Single>columnResized  // 0x420
  private           System.Action                   columnSortingChanged  // 0x428
  private           System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column>contextMenuPopulateEvent  // 0x430
  private           System.Action                   viewDataRestored  // 0x438
METHODS:
  System.Boolean get_isApplyingViewState()
  System.Collections.Generic.Dictionary<UnityEngine.UIElements.Column,UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ColumnData> get_columnDataMap()
  UnityEngine.UIElements.ColumnLayout get_columnLayout()
  UnityEngine.UIElements.VisualElement get_columnContainer()
  UnityEngine.UIElements.VisualElement get_resizeHandleContainer()
  System.Collections.Generic.IEnumerable<UnityEngine.UIElements.SortColumnDescription> get_sortedColumns()
  UnityEngine.UIElements.SortColumnDescriptions get_sortDescriptions()
  System.Void set_sortDescriptions(UnityEngine.UIElements.SortColumnDescriptions value)
  UnityEngine.UIElements.Columns get_columns()
  System.Boolean get_sortingEnabled()
  System.Void set_sortingEnabled(System.Boolean value)
  System.Void add_columnResized(System.Action<System.Int32,System.Single> value)
  System.Void remove_columnResized(System.Action<System.Int32,System.Single> value)
  System.Void add_columnSortingChanged(System.Action value)
  System.Void remove_columnSortingChanged(System.Action value)
  System.Void add_contextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value)
  System.Void remove_contextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value)
  System.Void add_viewDataRestored(System.Action value)
  System.Void remove_viewDataRestored(System.Action value)
  System.Void .ctor(UnityEngine.UIElements.Columns columns, UnityEngine.UIElements.SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns)
  System.Void ScheduleDoLayout()
  System.Void ResizeToFit()
  System.Void UpdateSortedColumns()
  System.Void UpdateColumnControls()
  System.Void OnColumnAdded(UnityEngine.UIElements.Column column, System.Int32 index)
  System.Void OnColumnAdded(UnityEngine.UIElements.Column column)
  System.Void OnColumnRemoved(UnityEngine.UIElements.Column column)
  System.Void OnColumnChanged(UnityEngine.UIElements.Column column, UnityEngine.UIElements.ColumnDataType type)
  System.Void OnColumnReordered(UnityEngine.UIElements.Column column, System.Int32 from, System.Int32 to)
  System.Void OnColumnResized(UnityEngine.UIElements.Column column)
  System.Void OnContextualMenuManipulator(UnityEngine.UIElements.ContextualMenuPopulateEvent evt)
  System.Void OnMoveManipulatorActivated(UnityEngine.UIElements.Internal.ColumnMover mover)
  System.Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent e)
  System.Void DoLayout()
  System.Void OnColumnControlGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent evt)
  System.Void OnColumnClicked(UnityEngine.UIElements.EventBase evt)
  System.Void UpdateSortColumnDescriptionsOnClick(UnityEngine.UIElements.Column column, UnityEngine.EventModifiers modifiers)
  System.Void ScrollHorizontally(System.Single horizontalOffset)
  System.Void RaiseColumnResized(System.Int32 columnIndex)
  System.Void RaiseColumnSortingChanged()
  System.Void ApplyColumnSorting()
  System.Void UpdateSortingStatus()
  System.Void OnViewDataReady()
  System.Void SaveViewState()
  System.Void Dispose()
  System.Void .cctor()
  System.Void <OnContextualMenuManipulator>b__65_0(UnityEngine.UIElements.DropdownMenuAction a)
END_CLASS

CLASS: UnityEngine.UIElements.Internal.MultiColumnHeaderColumnSortIndicator
TYPE:  class
TOKEN: 0x2000333
EXTENDS: VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   arrowUssClassName  // 0x8
  public    static readonly System.String                   indexLabelUssClassName  // 0x10
  private           UnityEngine.UIElements.Label    m_IndexLabel  // 0x3C0
METHODS:
  System.Void set_sortOrderLabel(System.String value)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.Internal.MultiColumnHeaderColumnIcon
TYPE:  class
TOKEN: 0x2000334
EXTENDS: Image
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  private           System.Boolean                  <isImageInline>k__BackingField  // 0x408
METHODS:
  System.Boolean get_isImageInline()
  System.Void set_isImageInline(System.Boolean value)
  System.Void .ctor()
  System.Void UpdateClassList()
  System.Void .cctor()
  System.Void <.ctor>b__5_0(UnityEngine.UIElements.CustomStyleResolvedEvent evt)
END_CLASS

CLASS: UnityEngine.UIElements.Internal.MultiColumnHeaderColumn
TYPE:  class
TOKEN: 0x2000335
EXTENDS: VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   sortableUssClassName  // 0x8
  public    static readonly System.String                   sortedAscendingUssClassName  // 0x10
  public    static readonly System.String                   sortedDescendingUssClassName  // 0x18
  public    static readonly System.String                   movingUssClassName  // 0x20
  public    static readonly System.String                   contentContainerUssClassName  // 0x28
  public    static readonly System.String                   contentUssClassName  // 0x30
  public    static readonly System.String                   defaultContentUssClassName  // 0x38
  public    static readonly System.String                   hasIconUssClassName  // 0x40
  public    static readonly System.String                   hasTitleUssClassName  // 0x48
  public    static readonly System.String                   titleUssClassName  // 0x50
  public    static readonly System.String                   iconElementName  // 0x58
  public    static readonly System.String                   titleElementName  // 0x60
  private   static readonly System.String                   s_BoundVEPropertyName  // 0x68
  private   static readonly System.String                   s_BindingCallbackVEPropertyName  // 0x70
  private   static readonly System.String                   s_UnbindingCallbackVEPropertyName  // 0x78
  private   static readonly System.String                   s_DestroyCallbackVEPropertyName  // 0x80
  private           UnityEngine.UIElements.VisualElementm_ContentContainer  // 0x3C0
  private           UnityEngine.UIElements.VisualElementm_Content  // 0x3C8
  private           UnityEngine.UIElements.Internal.MultiColumnHeaderColumnSortIndicatorm_SortIndicatorContainer  // 0x3D0
  private           UnityEngine.UIElements.IVisualElementScheduledItemm_ScheduledHeaderTemplateUpdate  // 0x3D8
  private           UnityEngine.UIElements.Clickable<clickable>k__BackingField  // 0x3E0
  private           UnityEngine.UIElements.Internal.ColumnMover<mover>k__BackingField  // 0x3E8
  private           UnityEngine.UIElements.Column   <column>k__BackingField  // 0x3F0
METHODS:
  UnityEngine.UIElements.Clickable get_clickable()
  System.Void set_clickable(UnityEngine.UIElements.Clickable value)
  UnityEngine.UIElements.Internal.ColumnMover get_mover()
  System.Void set_mover(UnityEngine.UIElements.Internal.ColumnMover value)
  System.Void set_sortOrderLabel(System.String value)
  UnityEngine.UIElements.Column get_column()
  System.Void set_column(UnityEngine.UIElements.Column value)
  UnityEngine.UIElements.VisualElement get_content()
  System.Void set_content(UnityEngine.UIElements.VisualElement value)
  System.Boolean get_isContentBound()
  System.Void set_isContentBound(System.Boolean value)
  System.Void .ctor(UnityEngine.UIElements.Column column)
  System.Void InitManipulators()
  System.Void UpdateDataFromColumn()
  System.Void BindHeaderContent()
  System.Void UnbindHeaderContent()
  System.Void DestroyHeaderContent()
  UnityEngine.UIElements.VisualElement CreateDefaultHeaderContent()
  System.Void DefaultBindHeaderContent(UnityEngine.UIElements.VisualElement ve)
  System.Void UpdateHeaderTemplate()
  System.Void UpdateGeometryFromColumn()
  System.Void .cctor()
  System.Void <.ctor>b__45_0(UnityEngine.UIElements.Column c, UnityEngine.UIElements.ColumnDataType role)
  System.Void <.ctor>b__45_1(UnityEngine.UIElements.Column c)
  System.Void <InitManipulators>b__46_0(UnityEngine.UIElements.Internal.ColumnMover mv)
END_CLASS

CLASS: UnityEngine.UIElements.Internal.MultiColumnHeaderColumnResizeHandle
TYPE:  class
TOKEN: 0x2000336
EXTENDS: VisualElement
FIELDS:
  public    static readonly System.String                   ussClassName  // 0x0
  public    static readonly System.String                   dragAreaUssClassName  // 0x8
  private   readonly UnityEngine.UIElements.VisualElement<dragArea>k__BackingField  // 0x3C0
METHODS:
  UnityEngine.UIElements.VisualElement get_dragArea()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.HierarchyTraversal
TYPE:  class
TOKEN: 0x2000337
FIELDS:
METHODS:
  System.Void Traverse(UnityEngine.UIElements.VisualElement element)
  System.Void TraverseRecursive(UnityEngine.UIElements.VisualElement element, System.Int32 depth)
  System.Void Recurse(UnityEngine.UIElements.VisualElement element, System.Int32 depth)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StylePropertyUtil
TYPE:  class
TOKEN: 0x2000338
FIELDS:
  private   static readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.StyleSheets.StylePropertyId>s_AnimatablePropertiesHash  // 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyId>s_NameToId  // 0x8
  private   static readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StylePropertyId,System.String>s_IdToName  // 0x10
  private   static readonly UnityEngine.UIElements.StyleSheets.StylePropertyId[]s_AnimatableProperties  // 0x18
METHODS:
  System.Void .cctor()
  System.Boolean IsAnimatable(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
  System.Boolean TryGetEnumIntValue(UnityEngine.UIElements.StyleSheets.StyleEnumType enumType, System.String value, System.Int32& intValue)
  System.Boolean IsMatchingShorthand(UnityEngine.UIElements.StyleSheets.StylePropertyId shorthand, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.InitialStyle
TYPE:  class
TOKEN: 0x2000339
FIELDS:
  private   static  UnityEngine.UIElements.ComputedStyles_InitialStyle  // 0x0
METHODS:
  UnityEngine.UIElements.ComputedStyle& Get()
  UnityEngine.UIElements.ComputedStyle Acquire()
  System.Void .cctor()
  UnityEngine.UIElements.Align get_alignContent()
  UnityEngine.UIElements.Align get_alignItems()
  UnityEngine.UIElements.Align get_alignSelf()
  UnityEngine.Color get_backgroundColor()
  UnityEngine.UIElements.Background get_backgroundImage()
  UnityEngine.Color get_borderBottomColor()
  UnityEngine.UIElements.Length get_borderBottomLeftRadius()
  UnityEngine.UIElements.Length get_borderBottomRightRadius()
  System.Single get_borderBottomWidth()
  UnityEngine.Color get_borderLeftColor()
  System.Single get_borderLeftWidth()
  UnityEngine.Color get_borderRightColor()
  System.Single get_borderRightWidth()
  UnityEngine.Color get_borderTopColor()
  UnityEngine.UIElements.Length get_borderTopLeftRadius()
  UnityEngine.UIElements.Length get_borderTopRightRadius()
  System.Single get_borderTopWidth()
  UnityEngine.UIElements.Length get_bottom()
  UnityEngine.Color get_color()
  UnityEngine.UIElements.Cursor get_cursor()
  UnityEngine.UIElements.DisplayStyle get_display()
  UnityEngine.UIElements.Length get_flexBasis()
  UnityEngine.UIElements.FlexDirection get_flexDirection()
  System.Single get_flexGrow()
  System.Single get_flexShrink()
  UnityEngine.UIElements.Wrap get_flexWrap()
  UnityEngine.UIElements.Length get_fontSize()
  UnityEngine.UIElements.Length get_height()
  UnityEngine.UIElements.Justify get_justifyContent()
  UnityEngine.UIElements.Length get_left()
  UnityEngine.UIElements.Length get_letterSpacing()
  UnityEngine.UIElements.Length get_marginBottom()
  UnityEngine.UIElements.Length get_marginLeft()
  UnityEngine.UIElements.Length get_marginRight()
  UnityEngine.UIElements.Length get_marginTop()
  UnityEngine.UIElements.Length get_maxHeight()
  UnityEngine.UIElements.Length get_maxWidth()
  UnityEngine.UIElements.Length get_minHeight()
  UnityEngine.UIElements.Length get_minWidth()
  System.Single get_opacity()
  UnityEngine.UIElements.OverflowInternal get_overflow()
  UnityEngine.UIElements.Length get_paddingBottom()
  UnityEngine.UIElements.Length get_paddingLeft()
  UnityEngine.UIElements.Length get_paddingRight()
  UnityEngine.UIElements.Length get_paddingTop()
  UnityEngine.UIElements.Position get_position()
  UnityEngine.UIElements.Length get_right()
  UnityEngine.UIElements.Rotate get_rotate()
  UnityEngine.UIElements.Scale get_scale()
  UnityEngine.UIElements.TextOverflow get_textOverflow()
  UnityEngine.UIElements.TextShadow get_textShadow()
  UnityEngine.UIElements.Length get_top()
  UnityEngine.UIElements.TransformOrigin get_transformOrigin()
  System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDelay()
  System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDuration()
  System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> get_transitionProperty()
  System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> get_transitionTimingFunction()
  UnityEngine.UIElements.Translate get_translate()
  UnityEngine.Color get_unityBackgroundImageTintColor()
  UnityEngine.ScaleMode get_unityBackgroundScaleMode()
  UnityEngine.Font get_unityFont()
  UnityEngine.UIElements.FontDefinition get_unityFontDefinition()
  UnityEngine.FontStyle get_unityFontStyleAndWeight()
  UnityEngine.UIElements.OverflowClipBox get_unityOverflowClipBox()
  UnityEngine.UIElements.Length get_unityParagraphSpacing()
  System.Int32 get_unitySliceBottom()
  System.Int32 get_unitySliceLeft()
  System.Int32 get_unitySliceRight()
  System.Int32 get_unitySliceTop()
  UnityEngine.TextAnchor get_unityTextAlign()
  UnityEngine.Color get_unityTextOutlineColor()
  System.Single get_unityTextOutlineWidth()
  UnityEngine.UIElements.TextOverflowPosition get_unityTextOverflowPosition()
  UnityEngine.UIElements.Visibility get_visibility()
  UnityEngine.UIElements.WhiteSpace get_whiteSpace()
  UnityEngine.UIElements.Length get_width()
  UnityEngine.UIElements.Length get_wordSpacing()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.ShorthandApplicator
TYPE:  class
TOKEN: 0x200033A
FIELDS:
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>s_TransitionDelayList  // 0x0
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>s_TransitionDurationList  // 0x8
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName>s_TransitionPropertyList  // 0x10
  private   static  System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction>s_TransitionTimingFunctionList  // 0x18
METHODS:
  System.Void ApplyBorderColor(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle)
  System.Void ApplyBorderRadius(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle)
  System.Void ApplyBorderWidth(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle)
  System.Void ApplyFlex(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle)
  System.Void ApplyMargin(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle)
  System.Void ApplyPadding(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle)
  System.Void ApplyTransition(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle)
  System.Void ApplyUnityTextOutline(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.ComputedStyle& computedStyle)
  System.Boolean CompileFlexShorthand(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, System.Single& grow, System.Single& shrink, UnityEngine.UIElements.Length& basis)
  System.Void CompileBorderRadius(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.Length& top, UnityEngine.UIElements.Length& right, UnityEngine.UIElements.Length& bottom, UnityEngine.UIElements.Length& left)
  System.Void CompileBoxArea(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.UIElements.Length& top, UnityEngine.UIElements.Length& right, UnityEngine.UIElements.Length& bottom, UnityEngine.UIElements.Length& left)
  System.Void CompileBoxArea(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, System.Single& top, System.Single& right, System.Single& bottom, System.Single& left)
  System.Void CompileBoxArea(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.Color& top, UnityEngine.Color& right, UnityEngine.Color& bottom, UnityEngine.Color& left)
  System.Void CompileTextOutline(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, UnityEngine.Color& outlineColor, System.Single& outlineWidth)
  System.Void CompileTransition(UnityEngine.UIElements.StyleSheets.StylePropertyReader reader, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>& outDelay, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>& outDuration, System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName>& outProperty, System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction>& outTimingFunction)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StylePropertyCache
TYPE:  class
TOKEN: 0x200033B
FIELDS:
  private   static readonly System.Collections.Generic.Dictionary<System.String,System.String>s_PropertySyntaxCache  // 0x0
  private   static readonly System.Collections.Generic.Dictionary<System.String,System.String>s_NonTerminalValues  // 0x8
METHODS:
  System.Boolean TryGetSyntax(System.String name, System.String& syntax)
  System.Boolean TryGetNonTerminalValue(System.String name, System.String& syntax)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StyleEnumType
TYPE:  struct
TOKEN: 0x200033C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeAlign  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeDisplayStyle  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeEasingMode  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeFlexDirection  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeFontStyle  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeJustify  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeOverflow  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeOverflowClipBox  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeOverflowInternal  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypePosition  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeScaleMode  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeTextAnchor  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeTextOverflow  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeTextOverflowPosition  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeTransformOriginOffset  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeVisibility  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeWhiteSpace  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StyleEnumTypeWrap  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StylePropertyId
TYPE:  struct
TOKEN: 0x200033D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnknown  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdCustom  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdAlignContent  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdAlignItems  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdAlignSelf  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdAll  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBackgroundColor  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBackgroundImage  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderBottomColor  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderBottomLeftRadius  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderBottomRightRadius  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderBottomWidth  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderColor  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderLeftColor  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderLeftWidth  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderRadius  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderRightColor  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderRightWidth  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderTopColor  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderTopLeftRadius  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderTopRightRadius  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderTopWidth  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBorderWidth  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdBottom  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdColor  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdCursor  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdDisplay  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdFlex  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdFlexBasis  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdFlexDirection  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdFlexGrow  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdFlexShrink  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdFlexWrap  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdFontSize  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdHeight  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdJustifyContent  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdLeft  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdLetterSpacing  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMargin  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMarginBottom  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMarginLeft  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMarginRight  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMarginTop  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMaxHeight  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMaxWidth  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMinHeight  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdMinWidth  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdOpacity  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdOverflow  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdPadding  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdPaddingBottom  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdPaddingLeft  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdPaddingRight  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdPaddingTop  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdPosition  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdRight  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdRotate  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdScale  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTextOverflow  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTextShadow  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTop  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTransformOrigin  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTransition  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTransitionDelay  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTransitionDuration  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTransitionProperty  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTransitionTimingFunction  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdTranslate  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityBackgroundImageTintColor  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityBackgroundScaleMode  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityFont  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityFontDefinition  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityFontStyleAndWeight  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityOverflowClipBox  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityParagraphSpacing  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnitySliceBottom  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnitySliceLeft  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnitySliceRight  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnitySliceTop  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityTextAlign  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityTextOutline  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityTextOutlineColor  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityTextOutlineWidth  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdUnityTextOverflowPosition  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdVisibility  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdWhiteSpace  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdWidth  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.StylePropertyIdWordSpacing  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Dimension
TYPE:  struct
TOKEN: 0x200033E
FIELDS:
  public            UnityEngine.UIElements.StyleSheets.Dimension.Unitunit  // 0x10
  public            System.Single                   value  // 0x14
METHODS:
  System.Void .ctor(System.Single value, UnityEngine.UIElements.StyleSheets.Dimension.Unit unit)
  UnityEngine.UIElements.Length ToLength()
  UnityEngine.UIElements.TimeValue ToTime()
  UnityEngine.UIElements.Angle ToAngle()
  System.Boolean op_Equality(UnityEngine.UIElements.StyleSheets.Dimension lhs, UnityEngine.UIElements.StyleSheets.Dimension rhs)
  System.Boolean Equals(UnityEngine.UIElements.StyleSheets.Dimension other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.ScalableImage
TYPE:  struct
TOKEN: 0x2000340
FIELDS:
  public            UnityEngine.Texture2D           normalImage  // 0x10
  public            UnityEngine.Texture2D           highResolutionImage  // 0x18
METHODS:
  System.String ToString()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StylePropertyValue
TYPE:  struct
TOKEN: 0x2000341
FIELDS:
  public            UnityEngine.UIElements.StyleSheetsheet  // 0x10
  public            UnityEngine.UIElements.StyleValueHandlehandle  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.ImageSource
TYPE:  struct
TOKEN: 0x2000342
FIELDS:
  public            UnityEngine.Texture2D           texture  // 0x10
  public            UnityEngine.Sprite              sprite  // 0x18
  public            UnityEngine.UIElements.VectorImagevectorImage  // 0x20
  public            UnityEngine.RenderTexture       renderTexture  // 0x28
METHODS:
  System.Boolean IsNull()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StylePropertyReader
TYPE:  class
TOKEN: 0x2000343
FIELDS:
  private   static  UnityEngine.UIElements.StyleSheets.StylePropertyReader.GetCursorIdFunctiongetCursorIdFunc  // 0x0
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue>m_Values  // 0x10
  private           System.Collections.Generic.List<System.Int32>m_ValueCount  // 0x18
  private           UnityEngine.UIElements.StyleVariableResolverm_Resolver  // 0x20
  private           UnityEngine.UIElements.StyleSheetm_Sheet  // 0x28
  private           UnityEngine.UIElements.StyleProperty[]m_Properties  // 0x30
  private           UnityEngine.UIElements.StyleSheets.StylePropertyId[]m_PropertyIds  // 0x38
  private           System.Int32                    m_CurrentValueIndex  // 0x40
  private           System.Int32                    m_CurrentPropertyIndex  // 0x44
  private           UnityEngine.UIElements.StyleProperty<property>k__BackingField  // 0x48
  private           UnityEngine.UIElements.StyleSheets.StylePropertyId<propertyId>k__BackingField  // 0x50
  private           System.Int32                    <valueCount>k__BackingField  // 0x54
  private           System.Single                   <dpiScaling>k__BackingField  // 0x58
METHODS:
  UnityEngine.UIElements.StyleProperty get_property()
  System.Void set_property(UnityEngine.UIElements.StyleProperty value)
  UnityEngine.UIElements.StyleSheets.StylePropertyId get_propertyId()
  System.Void set_propertyId(UnityEngine.UIElements.StyleSheets.StylePropertyId value)
  System.Int32 get_valueCount()
  System.Void set_valueCount(System.Int32 value)
  System.Single get_dpiScaling()
  System.Void set_dpiScaling(System.Single value)
  System.Void SetContext(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleComplexSelector selector, UnityEngine.UIElements.StyleVariableContext varContext, System.Single dpiScaling)
  System.Void SetInlineContext(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleProperty[] properties, UnityEngine.UIElements.StyleSheets.StylePropertyId[] propertyIds, System.Single dpiScaling)
  UnityEngine.UIElements.StyleSheets.StylePropertyId MoveNextProperty()
  UnityEngine.UIElements.StyleSheets.StylePropertyValue GetValue(System.Int32 index)
  UnityEngine.UIElements.StyleValueType GetValueType(System.Int32 index)
  System.Boolean IsValueType(System.Int32 index, UnityEngine.UIElements.StyleValueType type)
  System.Boolean IsKeyword(System.Int32 index, UnityEngine.UIElements.StyleValueKeyword keyword)
  System.String ReadAsString(System.Int32 index)
  UnityEngine.UIElements.Length ReadLength(System.Int32 index)
  UnityEngine.UIElements.TimeValue ReadTimeValue(System.Int32 index)
  UnityEngine.UIElements.Translate ReadTranslate(System.Int32 index)
  UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(System.Int32 index)
  UnityEngine.UIElements.Rotate ReadRotate(System.Int32 index)
  UnityEngine.UIElements.Scale ReadScale(System.Int32 index)
  System.Single ReadFloat(System.Int32 index)
  System.Int32 ReadInt(System.Int32 index)
  UnityEngine.Color ReadColor(System.Int32 index)
  System.Int32 ReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType enumType, System.Int32 index)
  UnityEngine.UIElements.FontDefinition ReadFontDefinition(System.Int32 index)
  UnityEngine.Font ReadFont(System.Int32 index)
  UnityEngine.UIElements.Background ReadBackground(System.Int32 index)
  UnityEngine.UIElements.Cursor ReadCursor(System.Int32 index)
  UnityEngine.UIElements.TextShadow ReadTextShadow(System.Int32 index)
  System.Void ReadListEasingFunction(System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> list, System.Int32 index)
  System.Void ReadListTimeValue(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> list, System.Int32 index)
  System.Void ReadListStylePropertyName(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> list, System.Int32 index)
  System.Void LoadProperties()
  System.Void SetCurrentProperty()
  UnityEngine.UIElements.TransformOrigin ReadTransformOrigin(System.Int32 valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue zVvalue)
  UnityEngine.UIElements.Length ReadTransformOriginEnum(UnityEngine.UIElements.StyleSheets.StylePropertyValue value, System.Boolean& isVertical, System.Boolean& isHorizontal)
  UnityEngine.UIElements.Translate ReadTranslate(System.Int32 valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue val3)
  UnityEngine.UIElements.Scale ReadScale(System.Int32 valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue val3)
  UnityEngine.UIElements.Rotate ReadRotate(System.Int32 valCount, UnityEngine.UIElements.StyleSheets.StylePropertyValue val1, UnityEngine.UIElements.StyleSheets.StylePropertyValue val2, UnityEngine.UIElements.StyleSheets.StylePropertyValue val3, UnityEngine.UIElements.StyleSheets.StylePropertyValue val4)
  System.Int32 ReadEnum(UnityEngine.UIElements.StyleSheets.StyleEnumType enumType, UnityEngine.UIElements.StyleSheets.StylePropertyValue value)
  UnityEngine.UIElements.Angle ReadAngle(UnityEngine.UIElements.StyleSheets.StylePropertyValue value)
  System.Boolean TryGetImageSourceFromValue(UnityEngine.UIElements.StyleSheets.StylePropertyValue propertyValue, System.Single dpiScaling, UnityEngine.UIElements.StyleSheets.ImageSource& source)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.MatchResultInfo
TYPE:  struct
TOKEN: 0x2000345
FIELDS:
  public    readonly System.Boolean                  success  // 0x10
  public    readonly UnityEngine.UIElements.PseudoStatestriggerPseudoMask  // 0x14
  public    readonly UnityEngine.UIElements.PseudoStatesdependencyPseudoMask  // 0x18
METHODS:
  System.Void .ctor(System.Boolean success, UnityEngine.UIElements.PseudoStates triggerPseudoMask, UnityEngine.UIElements.PseudoStates dependencyPseudoMask)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.SelectorMatchRecord
TYPE:  struct
TOKEN: 0x2000346
FIELDS:
  public            UnityEngine.UIElements.StyleSheetsheet  // 0x10
  public            System.Int32                    styleSheetIndexInStack  // 0x18
  public            UnityEngine.UIElements.StyleComplexSelectorcomplexSelector  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.UIElements.StyleSheet sheet, System.Int32 styleSheetIndexInStack)
  System.Int32 Compare(UnityEngine.UIElements.StyleSheets.SelectorMatchRecord a, UnityEngine.UIElements.StyleSheets.SelectorMatchRecord b)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StyleSelectorHelper
TYPE:  class
TOKEN: 0x2000347
FIELDS:
METHODS:
  UnityEngine.UIElements.StyleSheets.MatchResultInfo MatchesSelector(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleSelector selector)
  System.Boolean MatchRightToLeft(UnityEngine.UIElements.VisualElement element, UnityEngine.UIElements.StyleComplexSelector complexSelector, System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult)
  System.Void FastLookup(System.Collections.Generic.IDictionary<System.String,UnityEngine.UIElements.StyleComplexSelector> table, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchedSelectors, UnityEngine.UIElements.StyleMatchingContext context, System.String input, UnityEngine.UIElements.StyleSheets.SelectorMatchRecord& record)
  System.Void FindMatches(UnityEngine.UIElements.StyleMatchingContext context, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchedSelectors, System.Int32 parentSheetIndex)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StyleSheetCache
TYPE:  class
TOKEN: 0x2000348
FIELDS:
  private   static  UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKeyComparers_Comparer  // 0x0
  private   static  System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey,UnityEngine.UIElements.StyleSheets.StylePropertyId[]>s_RulePropertyIdsCache  // 0x8
METHODS:
  UnityEngine.UIElements.StyleSheets.StylePropertyId[] GetPropertyIds(UnityEngine.UIElements.StyleSheet sheet, System.Int32 ruleIndex)
  UnityEngine.UIElements.StyleSheets.StylePropertyId[] GetPropertyIds(UnityEngine.UIElements.StyleRule rule)
  UnityEngine.UIElements.StyleSheets.StylePropertyId GetPropertyId(UnityEngine.UIElements.StyleRule rule, System.Int32 index)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StyleSheetColor
TYPE:  class
TOKEN: 0x200034B
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.String,UnityEngine.Color32>s_NameToColor  // 0x0
METHODS:
  System.Boolean TryGetColor(System.String name, UnityEngine.Color& color)
  UnityEngine.Color32 HexToColor32(System.UInt32 color)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StyleSheetExtensions
TYPE:  class
TOKEN: 0x200034C
FIELDS:
METHODS:
  System.String ReadAsString(UnityEngine.UIElements.StyleSheet sheet, UnityEngine.UIElements.StyleValueHandle handle)
  System.Boolean IsVarFunction(UnityEngine.UIElements.StyleValueHandle handle)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StyleValue
TYPE:  struct
TOKEN: 0x200034D
FIELDS:
  public            UnityEngine.UIElements.StyleSheets.StylePropertyIdid  // 0x10
  public            UnityEngine.UIElements.StyleKeywordkeyword  // 0x14
  public            System.Single                   number  // 0x18
  public            UnityEngine.UIElements.Length   length  // 0x18
  public            UnityEngine.Color               color  // 0x18
  public            System.Runtime.InteropServices.GCHandleresource  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StyleValueManaged
TYPE:  struct
TOKEN: 0x200034E
FIELDS:
  public            UnityEngine.UIElements.StyleSheets.StylePropertyIdid  // 0x10
  public            UnityEngine.UIElements.StyleKeywordkeyword  // 0x14
  public            System.Object                   value  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.MatchResultErrorCode
TYPE:  struct
TOKEN: 0x200034F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.MatchResultErrorCodeNone  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.MatchResultErrorCodeSyntax  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.MatchResultErrorCodeEmptyValue  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.MatchResultErrorCodeExpectedEndOfValue  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.MatchResult
TYPE:  struct
TOKEN: 0x2000350
FIELDS:
  public            UnityEngine.UIElements.StyleSheets.MatchResultErrorCodeerrorCode  // 0x10
  public            System.String                   errorValue  // 0x18
METHODS:
  System.Boolean get_success()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.BaseStyleMatcher
TYPE:  class
TOKEN: 0x2000351
FIELDS:
  protected static readonly System.Text.RegularExpressions.Regexs_CustomIdentRegex  // 0x0
  private           System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.BaseStyleMatcher.MatchContext>m_ContextStack  // 0x10
  private           UnityEngine.UIElements.StyleSheets.BaseStyleMatcher.MatchContextm_CurrentContext  // 0x18
METHODS:
  System.Boolean MatchKeyword(System.String keyword)
  System.Boolean MatchNumber()
  System.Boolean MatchInteger()
  System.Boolean MatchLength()
  System.Boolean MatchPercentage()
  System.Boolean MatchColor()
  System.Boolean MatchResource()
  System.Boolean MatchUrl()
  System.Boolean MatchTime()
  System.Boolean MatchAngle()
  System.Boolean MatchCustomIdent()
  System.Int32 get_valueCount()
  System.Boolean get_isCurrentVariable()
  System.Boolean get_isCurrentComma()
  System.Boolean get_hasCurrent()
  System.Int32 get_currentIndex()
  System.Void set_currentIndex(System.Int32 value)
  System.Int32 get_matchedVariableCount()
  System.Void set_matchedVariableCount(System.Int32 value)
  System.Void Initialize()
  System.Void MoveNext()
  System.Void SaveContext()
  System.Void RestoreContext()
  System.Void DropContext()
  System.Boolean Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  System.Boolean MatchExpression(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  System.Boolean MatchExpressionWithMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  System.Boolean MatchGroup(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  System.Boolean MatchCombinator(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  System.Boolean MatchOr(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  System.Boolean MatchOrOr(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  System.Boolean MatchAndAnd(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  System.Int32 MatchMany(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  System.Int32 MatchManyByOrder(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp, System.Int32* matchOrder)
  System.Boolean MatchJuxtaposition(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  System.Boolean MatchDataType(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher
TYPE:  class
TOKEN: 0x2000353
EXTENDS: BaseStyleMatcher
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue>m_Values  // 0x20
METHODS:
  UnityEngine.UIElements.StyleSheets.StylePropertyValue get_current()
  System.Int32 get_valueCount()
  System.Boolean get_isCurrentVariable()
  System.Boolean get_isCurrentComma()
  UnityEngine.UIElements.StyleSheets.MatchResult Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> values)
  System.Boolean MatchKeyword(System.String keyword)
  System.Boolean MatchNumber()
  System.Boolean MatchInteger()
  System.Boolean MatchLength()
  System.Boolean MatchPercentage()
  System.Boolean MatchColor()
  System.Boolean MatchResource()
  System.Boolean MatchUrl()
  System.Boolean MatchTime()
  System.Boolean MatchCustomIdent()
  System.Boolean MatchAngle()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.Expression
TYPE:  class
TOKEN: 0x2000354
FIELDS:
  public            UnityEngine.UIElements.StyleSheets.Syntax.ExpressionTypetype  // 0x10
  public            UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultipliermultiplier  // 0x14
  public            UnityEngine.UIElements.StyleSheets.Syntax.DataTypedataType  // 0x20
  public            UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinatorcombinator  // 0x24
  public            UnityEngine.UIElements.StyleSheets.Syntax.Expression[]subExpressions  // 0x28
  public            System.String                   keyword  // 0x30
METHODS:
  System.Void .ctor(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType type)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.ExpressionType
TYPE:  struct
TOKEN: 0x2000355
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionTypeUnknown  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionTypeData  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionTypeKeyword  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionTypeCombinator  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.DataType
TYPE:  struct
TOKEN: 0x2000356
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeNone  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeNumber  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeInteger  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeLength  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypePercentage  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeColor  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeResource  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeUrl  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeTime  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeAngle  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.DataTypeCustomIdent  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator
TYPE:  struct
TOKEN: 0x2000357
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinatorNone  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinatorOr  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinatorOrOr  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinatorAndAnd  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinatorJuxtaposition  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinatorGroup  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType
TYPE:  struct
TOKEN: 0x2000358
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierTypeNone  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierTypeZeroOrMore  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierTypeOneOrMore  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierTypeZeroOrOne  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierTypeRanges  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierTypeOneOrMoreComma  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierTypeGroupAtLeastOne  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier
TYPE:  struct
TOKEN: 0x2000359
FIELDS:
  public    static  System.Int32                    Infinity  // 0x0
  private           UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierTypem_Type  // 0x10
  public            System.Int32                    min  // 0x14
  public            System.Int32                    max  // 0x18
METHODS:
  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType get_type()
  System.Void set_type(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType value)
  System.Void .ctor(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType type)
  System.Void SetType(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType value)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser
TYPE:  class
TOKEN: 0x200035A
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.Syntax.Expression>m_ProcessExpressionList  // 0x10
  private           System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.Syntax.Expression>m_ExpressionStack  // 0x18
  private           System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator>m_CombinatorStack  // 0x20
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.Syntax.Expression>m_ParsedExpressionCache  // 0x28
METHODS:
  UnityEngine.UIElements.StyleSheets.Syntax.Expression Parse(System.String syntax)
  UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseExpression(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer)
  System.Void ProcessCombinatorStack()
  UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseTerm(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer)
  UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator ParseCombinatorType(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer)
  UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseGroup(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer)
  UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseDataType(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer)
  UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseNonTerminalValue(System.String syntax)
  UnityEngine.UIElements.StyleSheets.Syntax.Expression ParseProperty(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer)
  System.Void ParseMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer, UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier& multiplier)
  System.Void ParseRanges(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer, System.Int32& min, System.Int32& max)
  System.Void EatSpace(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer tokenizer)
  System.Boolean IsExpressionEnd(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken token)
  System.Boolean IsCombinator(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken token)
  System.Boolean IsMultiplier(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken token)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType
TYPE:  struct
TOKEN: 0x200035B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeUnknown  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeString  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeNumber  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeSpace  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeSingleBar  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeDoubleBar  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeDoubleAmpersand  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeComma  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeSingleQuote  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeAsterisk  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypePlus  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeQuestionMark  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeHashMark  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeExclamationPoint  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeOpenBracket  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeCloseBracket  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeOpenBrace  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeCloseBrace  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeLessThan  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeGreaterThan  // 0x0
  public    static  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypeEnd  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken
TYPE:  struct
TOKEN: 0x200035C
FIELDS:
  public            UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenTypetype  // 0x10
  public            System.String                   text  // 0x18
  public            System.Int32                    number  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType t)
  System.Void .ctor(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType type, System.String text)
  System.Void .ctor(UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenType type, System.Int32 number)
END_CLASS

CLASS: UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer
TYPE:  class
TOKEN: 0x200035D
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken>m_Tokens  // 0x10
  private           System.Int32                    m_CurrentTokenIndex  // 0x18
METHODS:
  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken get_current()
  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken MoveNext()
  UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken PeekNext()
  System.Void Tokenize(System.String syntax)
  System.Boolean IsNextCharacter(System.String s, System.Int32 index, System.Char c)
  System.Boolean IsNextLetterOrDash(System.String s, System.Int32 index)
  System.Boolean IsNextNumber(System.String s, System.Int32 index)
  System.Int32 GlobCharacter(System.String s, System.Int32 index, System.Char c)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Allocator2D
TYPE:  class
TOKEN: 0x20002D7
FIELDS:
  private   readonly UnityEngine.Vector2Int          m_MinSize  // 0x10
  private   readonly UnityEngine.Vector2Int          m_MaxSize  // 0x18
  private   readonly UnityEngine.Vector2Int          m_MaxAllocSize  // 0x20
  private   readonly System.Int32                    m_RowHeightBias  // 0x28
  private   readonly UnityEngine.UIElements.UIR.Allocator2D.Row[]m_Rows  // 0x30
  private   readonly System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area>m_Areas  // 0x38
METHODS:
  System.Void .ctor(UnityEngine.Vector2Int minSize, UnityEngine.Vector2Int maxSize, System.Int32 rowHeightBias)
  System.Boolean TryAllocate(System.Int32 width, System.Int32 height, UnityEngine.UIElements.UIR.Allocator2D.Alloc2D& alloc2D)
  System.Void Free(UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc2D)
  System.Void BuildAreas(System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> areas, UnityEngine.Vector2Int minSize, UnityEngine.Vector2Int maxSize)
  UnityEngine.Vector2Int ComputeMaxAllocSize(System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> areas, System.Int32 rowHeightBias)
  UnityEngine.UIElements.UIR.Allocator2D.Row[] BuildRowArray(System.Int32 maxRowHeight, System.Int32 rowHeightBias)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.GradientSettingsAtlas
TYPE:  class
TOKEN: 0x20002DB
FIELDS:
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerWrite  // 0x0
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerCommit  // 0x8
  private   readonly System.Int32                    m_Length  // 0x10
  private   readonly System.Int32                    m_ElemWidth  // 0x14
  private           UnityEngine.UIElements.UIR.BestFitAllocatorm_Allocator  // 0x18
  private           UnityEngine.Texture2D           m_Atlas  // 0x20
  private           UnityEngine.UIElements.UIR.GradientSettingsAtlas.RawTexturem_RawAtlas  // 0x28
  private   static  System.Int32                    s_TextureCounter  // 0x10
  private           System.Boolean                  <disposed>k__BackingField  // 0x38
  private           System.Boolean                  <MustCommit>k__BackingField  // 0x39
METHODS:
  System.Int32 get_length()
  System.Boolean get_disposed()
  System.Void set_disposed(System.Boolean value)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor(System.Int32 length)
  System.Void Reset()
  UnityEngine.Texture2D get_atlas()
  UnityEngine.UIElements.UIR.Alloc Add(System.Int32 count)
  System.Void Write(UnityEngine.UIElements.UIR.Alloc alloc, UnityEngine.UIElements.GradientSettings[] settings, UnityEngine.UIElements.UIR.GradientRemap remap)
  System.Boolean get_MustCommit()
  System.Void set_MustCommit(System.Boolean value)
  System.Void Commit()
  System.Void PrepareAtlas()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.LinkedPoolItem`1
TYPE:  class
TOKEN: 0x20002DD
FIELDS:
  private           T                               poolNext  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.LinkedPool`1
TYPE:  class
TOKEN: 0x20002DE
FIELDS:
  private   readonly System.Func<T>                  m_CreateFunc  // 0x0
  private   readonly System.Action<T>                m_ResetAction  // 0x0
  private   readonly System.Int32                    m_Limit  // 0x0
  private           T                               m_PoolFirst  // 0x0
  private           System.Int32                    <Count>k__BackingField  // 0x0
METHODS:
  System.Void .ctor(System.Func<T> createFunc, System.Action<T> resetAction, System.Int32 limit)
  System.Int32 get_Count()
  System.Void set_Count(System.Int32 value)
  System.Void Clear()
  T Get()
  System.Void Return(T item)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.BasicNode`1
TYPE:  class
TOKEN: 0x20002DF
EXTENDS: LinkedPoolItem`1
FIELDS:
  public            UnityEngine.UIElements.UIR.BasicNode<T>next  // 0x0
  public            T                               data  // 0x0
METHODS:
  System.Void AppendTo(UnityEngine.UIElements.UIR.BasicNode<T>& first)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.BasicNodePool`1
TYPE:  class
TOKEN: 0x20002E0
EXTENDS: LinkedPool`1
FIELDS:
METHODS:
  System.Void Reset(UnityEngine.UIElements.UIR.BasicNode<T> node)
  UnityEngine.UIElements.UIR.BasicNode<T> Create()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.MeshBuilder
TYPE:  class
TOKEN: 0x20002E1
FIELDS:
  private   static  Unity.Profiling.ProfilerMarker  s_VectorGraphics9Slice  // 0x0
  private   static  Unity.Profiling.ProfilerMarker  s_VectorGraphicsSplitTriangle  // 0x8
  private   static  Unity.Profiling.ProfilerMarker  s_VectorGraphicsScaleTriangle  // 0x10
  private   static  Unity.Profiling.ProfilerMarker  s_VectorGraphicsStretch  // 0x18
  private   static readonly System.Int32                    s_MaxTextMeshVertices  // 0x20
  private   static readonly System.UInt16[]                 slicedQuadIndices  // 0x28
  private   static readonly System.Single[]                 k_TexCoordSlicesX  // 0x30
  private   static readonly System.Single[]                 k_TexCoordSlicesY  // 0x38
  private   static readonly System.Single[]                 k_PositionSlicesX  // 0x40
  private   static readonly System.Single[]                 k_PositionSlicesY  // 0x48
  private   static  UnityEngine.UIElements.UIR.MeshBuilder.VertexClipEdge[]s_AllClipEdges  // 0x50
METHODS:
  System.Void MakeBorder(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams borderParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc)
  System.Void MakeSolidRect(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc)
  System.Void MakeTexturedRect(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, UnityEngine.UIElements.ColorPage colorPage)
  UnityEngine.UIElements.Vertex ConvertTextVertexToUIRVertex(UnityEngine.TextCore.Text.MeshInfo info, System.Int32 index, UnityEngine.Vector2 offset, UnityEngine.UIElements.UIR.VertexFlags flags, System.Boolean isDynamicColor)
  UnityEngine.UIElements.Vertex ConvertTextVertexToUIRVertex(UnityEngine.UIElements.TextVertex textVertex, UnityEngine.Vector2 offset)
  System.Int32 LimitTextVertices(System.Int32 vertexCount, System.Boolean logTruncation)
  System.Void MakeText(UnityEngine.TextCore.Text.MeshInfo meshInfo, UnityEngine.Vector2 offset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, UnityEngine.UIElements.UIR.VertexFlags flags, System.Boolean isDynamicColor)
  System.Void MakeText(Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> uiVertices, UnityEngine.Vector2 offset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc)
  System.Void UpdateText(Unity.Collections.NativeArray<UnityEngine.UIElements.TextVertex> uiVertices, UnityEngine.Vector2 offset, UnityEngine.Matrix4x4 transform, UnityEngine.Color32 xformClipPages, UnityEngine.Color32 ids, UnityEngine.Color32 flags, UnityEngine.Color32 opacityPageSettingIndex, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices)
  System.Void MakeQuad(UnityEngine.Rect rcPosition, UnityEngine.Rect rcTexCoord, UnityEngine.Color color, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, UnityEngine.UIElements.ColorPage colorPage)
  System.Void MakeSlicedQuad(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams& rectParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc)
  System.Void MakeVectorGraphics(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, System.Int32 settingIndexOffset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, System.Int32& finalVertexCount, System.Int32& finalIndexCount)
  System.Void MakeVectorGraphicsStretchBackground(UnityEngine.UIElements.Vertex[] svgVertices, System.UInt16[] svgIndices, System.Single svgWidth, System.Single svgHeight, UnityEngine.Rect targetRect, UnityEngine.Rect sourceUV, UnityEngine.ScaleMode scaleMode, UnityEngine.Color tint, System.Int32 settingIndexOffset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, System.Int32& finalVertexCount, System.Int32& finalIndexCount)
  System.Void SplitTriangle(UnityEngine.UIElements.Vertex* vertices, System.UInt16* indices, System.Int32& vertexCount, System.Int32 indexToProcess, System.Int32& indexCount, System.Single svgWidth, System.Single svgHeight, UnityEngine.Vector4 sliceLTRB, System.Int32 sliceIndex)
  System.Void ScaleSplittedTriangles(UnityEngine.UIElements.Vertex* vertices, System.Int32 vertexCount, System.Single svgWidth, System.Single svgHeight, UnityEngine.Rect targetRect, UnityEngine.Vector4 sliceLTRB)
  System.Void MakeVectorGraphics9SliceBackground(UnityEngine.UIElements.Vertex[] svgVertices, System.UInt16[] svgIndices, System.Single svgWidth, System.Single svgHeight, UnityEngine.Rect targetRect, UnityEngine.Vector4 sliceLTRB, System.Boolean stretch, UnityEngine.Color tint, System.Int32 settingIndexOffset, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc)
  UnityEngine.UIElements.UIR.MeshBuilder.ClipCounts UpperBoundApproximateRectClippingResults(UnityEngine.UIElements.Vertex[] vertices, System.UInt16[] indices, UnityEngine.Vector4 clipRectMinMax)
  System.Void RectClip(UnityEngine.UIElements.Vertex[] vertices, System.UInt16[] indices, UnityEngine.Vector4 clipRectMinMax, UnityEngine.UIElements.MeshWriteData mwd, UnityEngine.UIElements.UIR.MeshBuilder.ClipCounts cc, System.Int32& newVertexCount)
  System.Void RectClipTriangle(UnityEngine.UIElements.Vertex* vt, System.UInt16* it, UnityEngine.Vector4 clipRectMinMax, UnityEngine.UIElements.MeshWriteData mwd, System.UInt16& nextNewVertex)
  UnityEngine.Vector3 GetVertexBaryCentricCoordinates(UnityEngine.UIElements.Vertex* vt, System.Single x, System.Single y)
  UnityEngine.UIElements.Vertex InterpolateVertexInTriangle(UnityEngine.UIElements.Vertex* vt, System.Single x, System.Single y, UnityEngine.Vector3 uvw)
  UnityEngine.UIElements.Vertex InterpolateVertexInTriangleEdge(UnityEngine.UIElements.Vertex* vt, System.Int32 e0, System.Int32 e1, System.Single t)
  System.Single IntersectSegments(System.Single ax, System.Single ay, System.Single bx, System.Single by, System.Single cx, System.Single cy, System.Single dx, System.Single dy)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.ChainBuilderStats
TYPE:  struct
TOKEN: 0x20002E6
FIELDS:
  public            System.UInt32                   elementsAdded  // 0x10
  public            System.UInt32                   elementsRemoved  // 0x14
  public            System.UInt32                   recursiveClipUpdates  // 0x18
  public            System.UInt32                   recursiveClipUpdatesExpanded  // 0x1C
  public            System.UInt32                   nonRecursiveClipUpdates  // 0x20
  public            System.UInt32                   recursiveTransformUpdates  // 0x24
  public            System.UInt32                   recursiveTransformUpdatesExpanded  // 0x28
  public            System.UInt32                   recursiveOpacityUpdates  // 0x2C
  public            System.UInt32                   recursiveOpacityUpdatesExpanded  // 0x30
  public            System.UInt32                   colorUpdates  // 0x34
  public            System.UInt32                   colorUpdatesExpanded  // 0x38
  public            System.UInt32                   recursiveVisualUpdates  // 0x3C
  public            System.UInt32                   recursiveVisualUpdatesExpanded  // 0x40
  public            System.UInt32                   nonRecursiveVisualUpdates  // 0x44
  public            System.UInt32                   dirtyProcessed  // 0x48
  public            System.UInt32                   nudgeTransformed  // 0x4C
  public            System.UInt32                   boneTransformed  // 0x50
  public            System.UInt32                   skipTransformed  // 0x54
  public            System.UInt32                   visualUpdateTransformed  // 0x58
  public            System.UInt32                   updatedMeshAllocations  // 0x5C
  public            System.UInt32                   newMeshAllocations  // 0x60
  public            System.UInt32                   groupTransformElementsChanged  // 0x64
  public            System.UInt32                   immedateRenderersActive  // 0x68
  public            System.UInt32                   textUpdates  // 0x6C
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.RenderChain
TYPE:  class
TOKEN: 0x20002E7
FIELDS:
  private           UnityEngine.UIElements.UIR.RenderChainCommandm_FirstCommand  // 0x10
  private           UnityEngine.UIElements.UIR.RenderChain.DepthOrderedDirtyTrackingm_DirtyTracker  // 0x18
  private           UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.RenderChainCommand>m_CommandPool  // 0x40
  private           UnityEngine.UIElements.UIR.BasicNodePool<UnityEngine.UIElements.UIR.TextureEntry>m_TexturePool  // 0x48
  private           System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChain.RenderNodeData>m_RenderNodesData  // 0x50
  private           UnityEngine.Shader              m_DefaultShader  // 0x58
  private           UnityEngine.Shader              m_DefaultWorldSpaceShader  // 0x60
  private           UnityEngine.Material            m_DefaultMat  // 0x68
  private           UnityEngine.Material            m_DefaultWorldSpaceMat  // 0x70
  private           System.Boolean                  m_BlockDirtyRegistration  // 0x78
  private           System.Int32                    m_StaticIndex  // 0x7C
  private           System.Int32                    m_ActiveRenderNodes  // 0x80
  private           System.Int32                    m_CustomMaterialCommands  // 0x84
  private           UnityEngine.UIElements.UIR.ChainBuilderStatsm_Stats  // 0x88
  private           System.UInt32                   m_StatsElementsAdded  // 0xE8
  private           System.UInt32                   m_StatsElementsRemoved  // 0xEC
  private           UnityEngine.UIElements.VisualElementm_FirstTextElement  // 0xF0
  private           UnityEngine.UIElements.UIR.Implementation.UIRTextUpdatePainterm_TextUpdatePainter  // 0xF8
  private           System.Int32                    m_TextElementCount  // 0x100
  private           System.Int32                    m_DirtyTextStartIndex  // 0x104
  private           System.Int32                    m_DirtyTextRemaining  // 0x108
  private           System.Boolean                  m_FontWasReset  // 0x10C
  private           System.Collections.Generic.Dictionary<UnityEngine.UIElements.VisualElement,UnityEngine.Vector2>m_LastGroupTransformElementScale  // 0x110
  private           UnityEngine.UIElements.TextureRegistrym_TextureRegistry  // 0x118
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerProcess  // 0x0
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerClipProcessing  // 0x8
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerOpacityProcessing  // 0x10
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerColorsProcessing  // 0x18
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerTransformProcessing  // 0x20
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerVisualsProcessing  // 0x28
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerTextRegen  // 0x30
  private           System.Boolean                  <disposed>k__BackingField  // 0x120
  private   static  System.Action                   OnPreRender  // 0x38
  private           UnityEngine.UIElements.BaseVisualElementPanel<panel>k__BackingField  // 0x128
  private           UnityEngine.UIElements.UIR.UIRenderDevice<device>k__BackingField  // 0x130
  private           UnityEngine.UIElements.AtlasBase<atlas>k__BackingField  // 0x138
  private           UnityEngine.UIElements.UIR.VectorImageManager<vectorImageManager>k__BackingField  // 0x140
  private           UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocatorshaderInfoAllocator  // 0x148
  private           UnityEngine.UIElements.UIR.Implementation.UIRStylePainter<painter>k__BackingField  // 0x218
  private           System.Boolean                  <drawStats>k__BackingField  // 0x220
  private           System.Boolean                  <drawInCameras>k__BackingField  // 0x221
METHODS:
  System.Void .cctor()
  System.Void .ctor(UnityEngine.UIElements.BaseVisualElementPanel panel)
  System.Void Constructor(UnityEngine.UIElements.BaseVisualElementPanel panelObj, UnityEngine.UIElements.UIR.UIRenderDevice deviceObj, UnityEngine.UIElements.AtlasBase atlas, UnityEngine.UIElements.UIR.VectorImageManager vectorImageMan)
  System.Void Destructor()
  System.Boolean get_disposed()
  System.Void set_disposed(System.Boolean value)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void ProcessChanges()
  System.Void Render()
  System.Void ProcessTextRegen(System.Boolean timeSliced)
  System.Void UIEOnChildAdded(UnityEngine.UIElements.VisualElement ve)
  System.Void UIEOnChildrenReordered(UnityEngine.UIElements.VisualElement ve)
  System.Void UIEOnChildRemoving(UnityEngine.UIElements.VisualElement ve)
  System.Void StopTrackingGroupTransformElement(UnityEngine.UIElements.VisualElement ve)
  System.Void UIEOnRenderHintsChanged(UnityEngine.UIElements.VisualElement ve)
  System.Void UIEOnClippingChanged(UnityEngine.UIElements.VisualElement ve, System.Boolean hierarchical)
  System.Void UIEOnOpacityChanged(UnityEngine.UIElements.VisualElement ve, System.Boolean hierarchical)
  System.Void UIEOnColorChanged(UnityEngine.UIElements.VisualElement ve)
  System.Void UIEOnTransformOrSizeChanged(UnityEngine.UIElements.VisualElement ve, System.Boolean transformChanged, System.Boolean clipRectSizeChanged)
  System.Void UIEOnVisualsChanged(UnityEngine.UIElements.VisualElement ve, System.Boolean hierarchical)
  UnityEngine.UIElements.BaseVisualElementPanel get_panel()
  System.Void set_panel(UnityEngine.UIElements.BaseVisualElementPanel value)
  UnityEngine.UIElements.UIR.UIRenderDevice get_device()
  System.Void set_device(UnityEngine.UIElements.UIR.UIRenderDevice value)
  UnityEngine.UIElements.AtlasBase get_atlas()
  System.Void set_atlas(UnityEngine.UIElements.AtlasBase value)
  UnityEngine.UIElements.UIR.VectorImageManager get_vectorImageManager()
  System.Void set_vectorImageManager(UnityEngine.UIElements.UIR.VectorImageManager value)
  UnityEngine.UIElements.UIR.Implementation.UIRStylePainter get_painter()
  System.Void set_painter(UnityEngine.UIElements.UIR.Implementation.UIRStylePainter value)
  System.Boolean get_drawStats()
  System.Void set_drawStats(System.Boolean value)
  System.Boolean get_drawInCameras()
  System.Void set_drawInCameras(System.Boolean value)
  System.Void set_defaultShader(UnityEngine.Shader value)
  System.Void set_defaultWorldSpaceShader(UnityEngine.Shader value)
  UnityEngine.Material GetStandardMaterial()
  UnityEngine.Material GetStandardWorldSpaceMaterial()
  System.Void EnsureFitsDepth(System.Int32 depth)
  System.Void ChildWillBeRemoved(UnityEngine.UIElements.VisualElement ve)
  UnityEngine.UIElements.UIR.RenderChainCommand AllocCommand()
  System.Void FreeCommand(UnityEngine.UIElements.UIR.RenderChainCommand cmd)
  System.Void OnRenderCommandAdded(UnityEngine.UIElements.UIR.RenderChainCommand command)
  System.Void OnRenderCommandsRemoved(UnityEngine.UIElements.UIR.RenderChainCommand firstCommand, UnityEngine.UIElements.UIR.RenderChainCommand lastCommand)
  System.Void AddTextElement(UnityEngine.UIElements.VisualElement ve)
  System.Void RemoveTextElement(UnityEngine.UIElements.VisualElement ve)
  System.Void OnGroupTransformElementChangedTransform(UnityEngine.UIElements.VisualElement ve)
  UnityEngine.UIElements.UIR.RenderChain.RenderNodeData AccessRenderNodeData(System.IntPtr obj)
  System.Void OnRenderNodeExecute(System.IntPtr obj)
  System.Void OnRegisterIntermediateRenderers(UnityEngine.Camera camera)
  System.Void OnRegisterIntermediateRendererMat(UnityEngine.UIElements.BaseRuntimePanel rtp, UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.RenderChain.RenderNodeData& rnd, UnityEngine.Camera camera, System.Int32 sameDistanceSortPriority)
  System.Void RepaintTexturedElements()
  System.Void OnFontReset(UnityEngine.Font font)
  System.Void AppendTexture(UnityEngine.UIElements.VisualElement ve, UnityEngine.Texture src, UnityEngine.UIElements.TextureId id, System.Boolean isAtlas)
  System.Void ResetTextures(UnityEngine.UIElements.VisualElement ve)
  System.Void DrawStats()
  UnityEngine.UIElements.VisualElement GetFirstElementInPanel(UnityEngine.UIElements.VisualElement ve)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.RenderDataDirtyTypes
TYPE:  struct
TOKEN: 0x20002EC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesNone  // 0x0
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesTransform  // 0x0
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesClipRectSize  // 0x0
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesClipping  // 0x0
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesClippingHierarchy  // 0x0
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesVisuals  // 0x0
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesVisualsHierarchy  // 0x0
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesOpacity  // 0x0
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesOpacityHierarchy  // 0x0
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypesColor  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.RenderDataDirtyTypeClasses
TYPE:  struct
TOKEN: 0x20002ED
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypeClassesClipping  // 0x0
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypeClassesOpacity  // 0x0
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypeClassesColor  // 0x0
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypeClassesTransformSize  // 0x0
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypeClassesVisuals  // 0x0
  public    static  UnityEngine.UIElements.UIR.RenderDataDirtyTypeClassesCount  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.RenderChainVEData
TYPE:  struct
TOKEN: 0x20002EE
FIELDS:
  private           UnityEngine.UIElements.VisualElementprev  // 0x10
  private           UnityEngine.UIElements.VisualElementnext  // 0x18
  private           UnityEngine.UIElements.VisualElementgroupTransformAncestor  // 0x20
  private           UnityEngine.UIElements.VisualElementboneTransformAncestor  // 0x28
  private           UnityEngine.UIElements.VisualElementprevDirty  // 0x30
  private           UnityEngine.UIElements.VisualElementnextDirty  // 0x38
  private           System.Int32                    hierarchyDepth  // 0x40
  private           UnityEngine.UIElements.UIR.RenderDataDirtyTypesdirtiedValues  // 0x44
  private           System.UInt32                   dirtyID  // 0x48
  private           UnityEngine.UIElements.UIR.RenderChainCommandfirstCommand  // 0x50
  private           UnityEngine.UIElements.UIR.RenderChainCommandlastCommand  // 0x58
  private           UnityEngine.UIElements.UIR.RenderChainCommandfirstClosingCommand  // 0x60
  private           UnityEngine.UIElements.UIR.RenderChainCommandlastClosingCommand  // 0x68
  private           System.Boolean                  isInChain  // 0x70
  private           System.Boolean                  isHierarchyHidden  // 0x71
  private           System.Boolean                  localFlipsWinding  // 0x72
  private           System.Boolean                  localTransformScaleZero  // 0x73
  private           System.Boolean                  worldFlipsWinding  // 0x74
  private           UnityEngine.UIElements.UIR.Implementation.ClipMethodclipMethod  // 0x78
  private           System.Int32                    childrenStencilRef  // 0x7C
  private           System.Int32                    childrenMaskDepth  // 0x80
  private           System.Boolean                  disableNudging  // 0x84
  private           System.Boolean                  usesLegacyText  // 0x85
  private           UnityEngine.UIElements.UIR.MeshHandledata  // 0x88
  private           UnityEngine.UIElements.UIR.MeshHandleclosingData  // 0x90
  private           UnityEngine.Matrix4x4           verticesSpace  // 0x98
  private           System.Int32                    displacementUVStart  // 0xD8
  private           System.Int32                    displacementUVEnd  // 0xDC
  private           UnityEngine.UIElements.UIR.BMPAlloctransformID  // 0xE0
  private           UnityEngine.UIElements.UIR.BMPAllocclipRectID  // 0xE8
  private           UnityEngine.UIElements.UIR.BMPAllocopacityID  // 0xF0
  private           UnityEngine.UIElements.UIR.BMPAlloctextCoreSettingsID  // 0xF8
  private           UnityEngine.UIElements.UIR.BMPAllocbackgroundColorID  // 0x100
  private           UnityEngine.UIElements.UIR.BMPAllocborderLeftColorID  // 0x108
  private           UnityEngine.UIElements.UIR.BMPAllocborderTopColorID  // 0x110
  private           UnityEngine.UIElements.UIR.BMPAllocborderRightColorID  // 0x118
  private           UnityEngine.UIElements.UIR.BMPAllocborderBottomColorID  // 0x120
  private           UnityEngine.UIElements.UIR.BMPAlloctintColorID  // 0x128
  private           System.Single                   compositeOpacity  // 0x130
  private           UnityEngine.Color               backgroundColor  // 0x134
  private           UnityEngine.UIElements.VisualElementprevText  // 0x148
  private           UnityEngine.UIElements.VisualElementnextText  // 0x150
  private           System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChainTextEntry>textEntries  // 0x158
  private           UnityEngine.UIElements.UIR.BasicNode<UnityEngine.UIElements.UIR.TextureEntry>textures  // 0x160
METHODS:
  UnityEngine.UIElements.UIR.RenderChainCommand get_lastClosingOrLastCommand()
  System.Boolean AllocatesID(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  System.Boolean InheritsID(UnityEngine.UIElements.UIR.BMPAlloc alloc)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.RenderChainTextEntry
TYPE:  struct
TOKEN: 0x20002EF
FIELDS:
  private           UnityEngine.UIElements.UIR.RenderChainCommandcommand  // 0x10
  private           System.Int32                    firstVertex  // 0x18
  private           System.Int32                    vertexCount  // 0x1C
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.TextureEntry
TYPE:  struct
TOKEN: 0x20002F0
FIELDS:
  public            UnityEngine.Texture             source  // 0x10
  public            UnityEngine.UIElements.TextureIdactual  // 0x18
  public            System.Boolean                  replaced  // 0x1C
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.BaseShaderInfoStorage
TYPE:  class
TOKEN: 0x20002F1
FIELDS:
  protected static  System.Int32                    s_TextureCounter  // 0x0
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerCopyTexture  // 0x8
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerGetTextureData  // 0x10
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerUpdateTexture  // 0x18
  private           System.Boolean                  <disposed>k__BackingField  // 0x10
METHODS:
  UnityEngine.Texture2D get_texture()
  System.Boolean AllocateRect(System.Int32 width, System.Int32 height, UnityEngine.RectInt& uvs)
  System.Void SetTexel(System.Int32 x, System.Int32 y, UnityEngine.Color color)
  System.Void UpdateTexture()
  System.Boolean get_disposed()
  System.Void set_disposed(System.Boolean value)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.ShaderInfoStorage`1
TYPE:  class
TOKEN: 0x20002F2
EXTENDS: BaseShaderInfoStorage
FIELDS:
  private   readonly System.Int32                    m_InitialSize  // 0x0
  private   readonly System.Int32                    m_MaxSize  // 0x0
  private   readonly UnityEngine.TextureFormat       m_Format  // 0x0
  private   readonly System.Func<UnityEngine.Color,T>m_Convert  // 0x0
  private           UnityEngine.UIElements.UIRAtlasAllocatorm_Allocator  // 0x0
  private           UnityEngine.Texture2D           m_Texture  // 0x0
  private           Unity.Collections.NativeArray<T>m_Texels  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.TextureFormat format, System.Func<UnityEngine.Color,T> convert, System.Int32 initialSize, System.Int32 maxSize)
  System.Void Dispose(System.Boolean disposing)
  UnityEngine.Texture2D get_texture()
  System.Boolean AllocateRect(System.Int32 width, System.Int32 height, UnityEngine.RectInt& uvs)
  System.Void SetTexel(System.Int32 x, System.Int32 y, UnityEngine.Color color)
  System.Void UpdateTexture()
  System.Void CreateOrExpandTexture()
  System.Void CpuBlit(Unity.Collections.NativeArray<T> src, System.Int32 srcWidth, System.Int32 srcHeight, Unity.Collections.NativeArray<T> dst, System.Int32 dstWidth, System.Int32 dstHeight)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.ShaderInfoStorageRGBA32
TYPE:  class
TOKEN: 0x20002F3
EXTENDS: ShaderInfoStorage`1
FIELDS:
  private   static readonly System.Func<UnityEngine.Color,UnityEngine.Color32>s_Convert  // 0x0
METHODS:
  System.Void .ctor(System.Int32 initialSize, System.Int32 maxSize)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.ShaderInfoStorageRGBAFloat
TYPE:  class
TOKEN: 0x20002F5
EXTENDS: ShaderInfoStorage`1
FIELDS:
  private   static readonly System.Func<UnityEngine.Color,UnityEngine.Color>s_Convert  // 0x0
METHODS:
  System.Void .ctor(System.Int32 initialSize, System.Int32 maxSize)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Shaders
TYPE:  class
TOKEN: 0x20002F7
FIELDS:
  public    static readonly System.String                   k_AtlasBlit  // 0x0
  public    static readonly System.String                   k_Editor  // 0x8
  public    static readonly System.String                   k_Runtime  // 0x10
  public    static readonly System.String                   k_RuntimeWorld  // 0x18
  public    static readonly System.String                   k_GraphView  // 0x20
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Tessellation
TYPE:  class
TOKEN: 0x20002F8
FIELDS:
  private   static  System.Single                   kEpsilon  // 0x0
  private   static  System.Single                   kUnusedArc  // 0x4
  private   static  System.UInt16                   kSubdivisions  // 0x8
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerTessellateRect  // 0x10
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerTessellateBorder  // 0x18
  private   static  UnityEngine.UIElements.UIR.Tessellation.Edges[]s_AllEdges  // 0x20
METHODS:
  System.Void TessellateRect(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc, System.Boolean computeUVs)
  System.Void TessellateQuad(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc)
  System.Void TessellateBorder(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams borderParams, System.Single posZ, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData meshAlloc)
  System.Void TessellateRoundedCorners(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams& rectParams, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  System.Void TessellateRoundedBorders(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams& border, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  System.Void TessellateRoundedCorner(UnityEngine.Rect rect, UnityEngine.Color32 color, System.Single posZ, UnityEngine.Vector2 radius, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  System.Void TessellateRoundedBorder(UnityEngine.Rect rect, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, System.Single posZ, UnityEngine.Vector2 radius, System.Single leftWidth, System.Single topWidth, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  UnityEngine.Vector2 IntersectLines(UnityEngine.Vector2 p0, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3)
  System.Int32 LooseCompare(System.Single a, System.Single b)
  System.Void TessellateComplexBorderCorner(UnityEngine.Rect rect, UnityEngine.Vector2 radius, System.Single leftWidth, System.Single topWidth, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  System.Void TessellateQuad(UnityEngine.Rect rect, UnityEngine.Color32 color, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  System.Void TessellateQuad(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdges, UnityEngine.Color32 color, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  System.Int32 EdgesCount(UnityEngine.UIElements.UIR.Tessellation.Edges edges)
  System.Void TessellateQuad(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdges, UnityEngine.Vector2* offsets, UnityEngine.Color32 color, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  System.Void EncodeStraightArc(UnityEngine.UIElements.Vertex& v0, UnityEngine.UIElements.Vertex& v1, UnityEngine.UIElements.Vertex& center, System.Single radius)
  System.Void ExpandTriangle(UnityEngine.Vector3& v0, UnityEngine.Vector3& v1, UnityEngine.Vector3 center, System.Single factor)
  System.Void TessellateQuadSingleEdge(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdge, UnityEngine.Color32 color, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  System.Void TessellateStraightBorder(UnityEngine.Rect rect, UnityEngine.UIElements.UIR.Tessellation.Edges smoothedEdge, System.Single miterOffset, UnityEngine.Color color, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage colorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  UnityEngine.Vector4 GetInterpolatedCircle(UnityEngine.Vector2 p, UnityEngine.UIElements.Vertex& v0, UnityEngine.UIElements.Vertex& v1, UnityEngine.UIElements.Vertex& v2)
  System.Void ComputeBarycentricCoordinates(UnityEngine.Vector2 p, UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, System.Single& u, System.Single& v, System.Single& w)
  System.Void TessellateFilledFan(UnityEngine.Vector2 center, UnityEngine.Vector2 radius, UnityEngine.Vector2 miterOffset, System.Single leftWidth, System.Single topWidth, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  System.Void TessellateBorderedFan(UnityEngine.Vector2 center, UnityEngine.Vector2 outerRadius, System.Single leftWidth, System.Single topWidth, UnityEngine.Color32 leftColor, UnityEngine.Color32 topColor, System.Single posZ, UnityEngine.UIElements.MeshWriteData mesh, UnityEngine.UIElements.ColorPage leftColorPage, UnityEngine.UIElements.ColorPage topColorPage, System.UInt16& vertexCount, System.UInt16& indexCount, System.Boolean countOnly)
  System.Void MirrorVertices(UnityEngine.Rect rect, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, System.Int32 vertexStart, System.Int32 vertexCount, System.Boolean flipHorizontal)
  System.Void FlipWinding(Unity.Collections.NativeSlice<System.UInt16> indices, System.Int32 indexStart, System.Int32 indexCount)
  System.Void ComputeUVs(UnityEngine.Rect tessellatedRect, UnityEngine.Rect textureRect, UnityEngine.Rect uvRegion, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.TextCoreSettings
TYPE:  struct
TOKEN: 0x20002FA
FIELDS:
  public            UnityEngine.Color               faceColor  // 0x10
  public            UnityEngine.Color               outlineColor  // 0x20
  public            System.Single                   outlineWidth  // 0x30
  public            UnityEngine.Color               underlayColor  // 0x34
  public            UnityEngine.Vector2             underlayOffset  // 0x44
  public            System.Single                   underlaySoftness  // 0x4C
METHODS:
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.UIElements.UIR.TextCoreSettings other)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.TextureBlitter
TYPE:  class
TOKEN: 0x20002FB
FIELDS:
  private   static readonly System.Int32[]                  k_TextureIds  // 0x0
  private   static  Unity.Profiling.ProfilerMarker  s_CommitSampler  // 0x8
  private           UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo[]m_SingleBlit  // 0x10
  private           UnityEngine.Material            m_BlitMaterial  // 0x18
  private           UnityEngine.MaterialPropertyBlockm_Properties  // 0x20
  private           UnityEngine.RectInt             m_Viewport  // 0x28
  private           UnityEngine.RenderTexture       m_PrevRT  // 0x38
  private           System.Collections.Generic.List<UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo>m_PendingBlits  // 0x40
  private           System.Boolean                  <disposed>k__BackingField  // 0x48
METHODS:
  System.Boolean get_disposed()
  System.Void set_disposed(System.Boolean value)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void .cctor()
  System.Void .ctor(System.Int32 capacity)
  System.Void QueueBlit(UnityEngine.Texture src, UnityEngine.RectInt srcRect, UnityEngine.Vector2Int dstPos, System.Boolean addBorder, UnityEngine.Color tint)
  System.Void BlitOneNow(UnityEngine.RenderTexture dst, UnityEngine.Texture src, UnityEngine.RectInt srcRect, UnityEngine.Vector2Int dstPos, System.Boolean addBorder, UnityEngine.Color tint)
  System.Void Commit(UnityEngine.RenderTexture dst)
  System.Void BeginBlit(UnityEngine.RenderTexture dst)
  System.Void DoBlit(System.Collections.Generic.IList<UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo> blitInfos, System.Int32 startIndex)
  System.Void EndBlit()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.TextureSlotManager
TYPE:  class
TOKEN: 0x20002FD
FIELDS:
  private   static readonly System.Int32                    k_SlotCount  // 0x0
  private   static readonly System.Int32[]                  slotIds  // 0x8
  private   static readonly System.Int32                    textureTableId  // 0x10
  private           UnityEngine.UIElements.TextureId[]m_Textures  // 0x10
  private           System.Int32[]                  m_Tickets  // 0x18
  private           System.Int32                    m_CurrentTicket  // 0x20
  private           System.Int32                    m_FirstUsedTicket  // 0x24
  private           UnityEngine.Vector4[]           m_GpuTextures  // 0x28
  private           System.Int32                    <FreeSlots>k__BackingField  // 0x30
  private           UnityEngine.UIElements.TextureRegistrytextureRegistry  // 0x38
METHODS:
  System.Void .cctor()
  System.Void .ctor()
  System.Void Reset()
  System.Void StartNewBatch()
  System.Int32 IndexOf(UnityEngine.UIElements.TextureId id)
  System.Void MarkUsed(System.Int32 slotIndex)
  System.Int32 get_FreeSlots()
  System.Void set_FreeSlots(System.Int32 value)
  System.Int32 FindOldestSlot()
  System.Void Bind(UnityEngine.UIElements.TextureId id, System.Int32 slot, UnityEngine.MaterialPropertyBlock mat)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.VectorImageRenderInfoPool
TYPE:  class
TOKEN: 0x20002FE
EXTENDS: LinkedPool`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.VectorImageRenderInfo
TYPE:  class
TOKEN: 0x2000300
EXTENDS: LinkedPoolItem`1
FIELDS:
  public            System.Int32                    useCount  // 0x18
  public            UnityEngine.UIElements.UIR.GradientRemapfirstGradientRemap  // 0x20
  public            UnityEngine.UIElements.UIR.AllocgradientSettingsAlloc  // 0x28
METHODS:
  System.Void Reset()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.GradientRemapPool
TYPE:  class
TOKEN: 0x2000301
EXTENDS: LinkedPool`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.GradientRemap
TYPE:  class
TOKEN: 0x2000303
EXTENDS: LinkedPoolItem`1
FIELDS:
  public            System.Int32                    origIndex  // 0x18
  public            System.Int32                    destIndex  // 0x1C
  public            UnityEngine.RectInt             location  // 0x20
  public            UnityEngine.UIElements.UIR.GradientRemapnext  // 0x30
  public            UnityEngine.UIElements.TextureIdatlas  // 0x38
METHODS:
  System.Void Reset()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.VectorImageManager
TYPE:  class
TOKEN: 0x2000304
FIELDS:
  public    static  System.Collections.Generic.List<UnityEngine.UIElements.UIR.VectorImageManager>instances  // 0x0
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerRegister  // 0x8
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerUnregister  // 0x10
  private   readonly UnityEngine.UIElements.AtlasBasem_Atlas  // 0x10
  private           System.Collections.Generic.Dictionary<UnityEngine.UIElements.VectorImage,UnityEngine.UIElements.UIR.VectorImageRenderInfo>m_Registered  // 0x18
  private           UnityEngine.UIElements.UIR.VectorImageRenderInfoPoolm_RenderInfoPool  // 0x20
  private           UnityEngine.UIElements.UIR.GradientRemapPoolm_GradientRemapPool  // 0x28
  private           UnityEngine.UIElements.UIR.GradientSettingsAtlasm_GradientSettingsAtlas  // 0x30
  private           System.Boolean                  m_LoggedExhaustedSettingsAtlas  // 0x38
  private           System.Boolean                  <disposed>k__BackingField  // 0x39
METHODS:
  UnityEngine.Texture2D get_atlas()
  System.Void .ctor(UnityEngine.UIElements.AtlasBase atlas)
  System.Boolean get_disposed()
  System.Void set_disposed(System.Boolean value)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void Commit()
  UnityEngine.UIElements.UIR.GradientRemap AddUser(UnityEngine.UIElements.VectorImage vi, UnityEngine.UIElements.VisualElement context)
  UnityEngine.UIElements.UIR.VectorImageRenderInfo Register(UnityEngine.UIElements.VectorImage vi, UnityEngine.UIElements.VisualElement context)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.OwnedState
TYPE:  struct
TOKEN: 0x2000305
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.OwnedStateInherited  // 0x0
  public    static  UnityEngine.UIElements.UIR.OwnedStateOwned  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.BMPAlloc
TYPE:  struct
TOKEN: 0x2000306
FIELDS:
  public    static readonly UnityEngine.UIElements.UIR.BMPAllocInvalid  // 0x0
  public            System.Int32                    page  // 0x10
  public            System.UInt16                   pageLine  // 0x14
  public            System.Byte                     bitIndex  // 0x16
  public            UnityEngine.UIElements.UIR.OwnedStateownedState  // 0x17
METHODS:
  System.Boolean Equals(UnityEngine.UIElements.UIR.BMPAlloc other)
  System.Boolean IsValid()
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.BitmapAllocator32
TYPE:  struct
TOKEN: 0x2000307
FIELDS:
  private           System.Int32                    m_PageHeight  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.UIR.BitmapAllocator32.Page>m_Pages  // 0x18
  private           System.Collections.Generic.List<System.UInt32>m_AllocMap  // 0x20
  private           System.Int32                    m_EntryWidth  // 0x28
  private           System.Int32                    m_EntryHeight  // 0x2C
METHODS:
  System.Void Construct(System.Int32 pageHeight, System.Int32 entryWidth, System.Int32 entryHeight)
  System.Void ForceFirstAlloc(System.UInt16 firstPageX, System.UInt16 firstPageY)
  UnityEngine.UIElements.UIR.BMPAlloc Allocate(UnityEngine.UIElements.UIR.BaseShaderInfoStorage storage)
  System.Void Free(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  System.Int32 get_entryWidth()
  System.Int32 get_entryHeight()
  System.Void GetAllocPageAtlasLocation(System.Int32 page, System.UInt16& x, System.UInt16& y)
  System.Byte CountTrailingZeroes(System.UInt32 val)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator
TYPE:  struct
TOKEN: 0x2000309
FIELDS:
  private           UnityEngine.UIElements.UIR.BaseShaderInfoStoragem_Storage  // 0x10
  private           UnityEngine.UIElements.UIR.BitmapAllocator32m_TransformAllocator  // 0x18
  private           UnityEngine.UIElements.UIR.BitmapAllocator32m_ClipRectAllocator  // 0x38
  private           UnityEngine.UIElements.UIR.BitmapAllocator32m_OpacityAllocator  // 0x58
  private           UnityEngine.UIElements.UIR.BitmapAllocator32m_ColorAllocator  // 0x78
  private           UnityEngine.UIElements.UIR.BitmapAllocator32m_TextSettingsAllocator  // 0x98
  private           System.Boolean                  m_StorageReallyCreated  // 0xB8
  private           System.Boolean                  m_VertexTexturingEnabled  // 0xB9
  private           Unity.Collections.NativeArray<UnityEngine.UIElements.UIR.Transform3x4>m_Transforms  // 0xC0
  private           Unity.Collections.NativeArray<UnityEngine.Vector4>m_ClipRects  // 0xD0
  private   static readonly UnityEngine.Vector2Int          identityTransformTexel  // 0x0
  private   static readonly UnityEngine.Vector2Int          infiniteClipRectTexel  // 0x8
  private   static readonly UnityEngine.Vector2Int          fullOpacityTexel  // 0x10
  private   static readonly UnityEngine.Vector2Int          clearColorTexel  // 0x18
  private   static readonly UnityEngine.Vector2Int          defaultTextCoreSettingsTexel  // 0x20
  private   static readonly UnityEngine.Matrix4x4           identityTransformValue  // 0x28
  private   static readonly UnityEngine.Vector4             identityTransformRow0Value  // 0x68
  private   static readonly UnityEngine.Vector4             identityTransformRow1Value  // 0x78
  private   static readonly UnityEngine.Vector4             identityTransformRow2Value  // 0x88
  private   static readonly UnityEngine.Vector4             infiniteClipRectValue  // 0x98
  private   static readonly UnityEngine.Vector4             fullOpacityValue  // 0xA8
  private   static readonly UnityEngine.Vector4             clearColorValue  // 0xB8
  private   static readonly UnityEngine.UIElements.UIR.TextCoreSettingsdefaultTextCoreSettingsValue  // 0xC8
  public    static readonly UnityEngine.UIElements.UIR.BMPAllocidentityTransform  // 0x108
  public    static readonly UnityEngine.UIElements.UIR.BMPAllocinfiniteClipRect  // 0x110
  public    static readonly UnityEngine.UIElements.UIR.BMPAllocfullOpacity  // 0x118
  public    static readonly UnityEngine.UIElements.UIR.BMPAllocclearColor  // 0x120
  public    static readonly UnityEngine.UIElements.UIR.BMPAllocdefaultTextCoreSettings  // 0x128
METHODS:
  System.Int32 get_pageWidth()
  System.Int32 get_pageHeight()
  UnityEngine.Vector2Int AllocToTexelCoord(UnityEngine.UIElements.UIR.BitmapAllocator32& allocator, UnityEngine.UIElements.UIR.BMPAlloc alloc)
  System.Int32 AllocToConstantBufferIndex(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  System.Boolean AtlasRectMatchesPage(UnityEngine.UIElements.UIR.BitmapAllocator32& allocator, UnityEngine.UIElements.UIR.BMPAlloc defAlloc, UnityEngine.RectInt atlasRect)
  Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> get_transformConstants()
  Unity.Collections.NativeSlice<UnityEngine.Vector4> get_clipRectConstants()
  UnityEngine.Texture get_atlas()
  System.Void Construct()
  System.Void ReallyCreateStorage()
  System.Void Dispose()
  System.Void IssuePendingStorageChanges()
  UnityEngine.UIElements.UIR.BMPAlloc AllocTransform()
  UnityEngine.UIElements.UIR.BMPAlloc AllocClipRect()
  UnityEngine.UIElements.UIR.BMPAlloc AllocOpacity()
  UnityEngine.UIElements.UIR.BMPAlloc AllocColor()
  UnityEngine.UIElements.UIR.BMPAlloc AllocTextCoreSettings(UnityEngine.UIElements.UIR.TextCoreSettings settings)
  System.Void SetTransformValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.Matrix4x4 xform)
  System.Void SetClipRectValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.Vector4 clipRect)
  System.Void SetOpacityValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, System.Single opacity)
  System.Void SetColorValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.Color color, System.Boolean isEditorContext)
  System.Void SetTextCoreSettingValue(UnityEngine.UIElements.UIR.BMPAlloc alloc, UnityEngine.UIElements.UIR.TextCoreSettings settings, System.Boolean isEditorContext)
  System.Void FreeTransform(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  System.Void FreeClipRect(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  System.Void FreeOpacity(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  System.Void FreeColor(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  System.Void FreeTextCoreSettings(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  UnityEngine.Color32 TransformAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  UnityEngine.Color32 ClipRectAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  UnityEngine.Color32 OpacityAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  UnityEngine.Color32 ColorAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  UnityEngine.Color32 TextCoreSettingsToVertexData(UnityEngine.UIElements.UIR.BMPAlloc alloc)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Transform3x4
TYPE:  struct
TOKEN: 0x200030A
FIELDS:
  public            UnityEngine.Vector4             v0  // 0x10
  public            UnityEngine.Vector4             v1  // 0x20
  public            UnityEngine.Vector4             v2  // 0x30
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.MeshHandle
TYPE:  class
TOKEN: 0x200030B
EXTENDS: LinkedPoolItem`1
FIELDS:
  private           UnityEngine.UIElements.UIR.AllocallocVerts  // 0x18
  private           UnityEngine.UIElements.UIR.AllocallocIndices  // 0x30
  private           System.UInt32                   triangleCount  // 0x48
  private           UnityEngine.UIElements.UIR.Page allocPage  // 0x50
  private           System.UInt32                   allocTime  // 0x58
  private           System.UInt32                   updateAllocID  // 0x5C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.UIRenderDevice
TYPE:  class
TOKEN: 0x200030C
FIELDS:
  private   readonly System.Boolean                  m_MockDevice  // 0x10
  private           System.IntPtr                   m_DefaultStencilState  // 0x18
  private           System.IntPtr                   m_VertexDecl  // 0x20
  private           UnityEngine.UIElements.UIR.Page m_FirstPage  // 0x28
  private           System.UInt32                   m_NextPageVertexCount  // 0x30
  private           System.UInt32                   m_LargeMeshVertexCount  // 0x34
  private           System.Single                   m_IndexToVertexCountRatio  // 0x38
  private           System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToFree>>m_DeferredFrees  // 0x40
  private           System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate>>m_Updates  // 0x48
  private           System.UInt32[]                 m_Fences  // 0x50
  private           UnityEngine.MaterialPropertyBlockm_StandardMatProps  // 0x58
  private           System.UInt32                   m_FrameIndex  // 0x60
  private           System.UInt32                   m_NextUpdateID  // 0x64
  private           UnityEngine.UIElements.UIR.UIRenderDevice.DrawStatisticsm_DrawStats  // 0x68
  private   readonly UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.MeshHandle>m_MeshHandles  // 0x90
  private   readonly UnityEngine.UIElements.UIR.DrawParamsm_DrawParams  // 0x98
  private   readonly UnityEngine.UIElements.UIR.TextureSlotManagerm_TextureSlotManager  // 0xA0
  private   static  System.Collections.Generic.LinkedList<UnityEngine.UIElements.UIR.UIRenderDevice.DeviceToFree>m_DeviceFreeQueue  // 0x0
  private   static  System.Int32                    m_ActiveDeviceCount  // 0x8
  private   static  System.Boolean                  m_SubscribedToNotifications  // 0xC
  private   static  System.Boolean                  m_SynchronousFree  // 0xD
  private   static readonly System.Int32                    s_FontTexPropID  // 0x10
  private   static readonly System.Int32                    s_FontTexSDFScaleID  // 0x14
  private   static readonly System.Int32                    s_GradientSettingsTexID  // 0x18
  private   static readonly System.Int32                    s_ShaderInfoTexID  // 0x1C
  private   static readonly System.Int32                    s_TransformsPropID  // 0x20
  private   static readonly System.Int32                    s_ClipRectsPropID  // 0x24
  private   static readonly System.Int32                    s_ClipSpaceParamsID  // 0x28
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerAllocate  // 0x30
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerFree  // 0x38
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerAdvanceFrame  // 0x40
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerFence  // 0x48
  private   static  Unity.Profiling.ProfilerMarker  s_MarkerBeforeDraw  // 0x50
  private   static  System.Nullable<System.Boolean> s_VertexTexturingIsAvailable  // 0x58
  private   static  System.Nullable<System.Boolean> s_ShaderModelIs35  // 0x5A
  private   readonly System.UInt32                   <maxVerticesPerPage>k__BackingField  // 0xA8
  private           System.Boolean                  <breakBatches>k__BackingField  // 0xAC
  private   static  UnityEngine.Texture2D           s_DefaultShaderInfoTexFloat  // 0x60
  private   static  UnityEngine.Texture2D           s_DefaultShaderInfoTexARGB8  // 0x68
  private           System.Boolean                  <disposed>k__BackingField  // 0xAD
METHODS:
  System.UInt32 get_maxVerticesPerPage()
  System.Boolean get_breakBatches()
  System.Void set_breakBatches(System.Boolean value)
  System.Void .cctor()
  System.Void .ctor(System.UInt32 initialVertexCapacity, System.UInt32 initialIndexCapacity)
  System.Void .ctor(System.UInt32 initialVertexCapacity, System.UInt32 initialIndexCapacity, System.Boolean mockDevice)
  UnityEngine.Texture2D get_defaultShaderInfoTexFloat()
  UnityEngine.Texture2D get_defaultShaderInfoTexARGB8()
  System.Boolean get_vertexTexturingIsAvailable()
  System.Boolean get_shaderModelIs35()
  System.Void InitVertexDeclaration()
  System.Void CompleteCreation()
  System.Boolean get_fullyCreated()
  System.Boolean get_disposed()
  System.Void set_disposed(System.Boolean value)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  UnityEngine.UIElements.UIR.MeshHandle Allocate(System.UInt32 vertexCount, System.UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, System.UInt16& indexOffset)
  System.Void Update(UnityEngine.UIElements.UIR.MeshHandle mesh, System.UInt32 vertexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData)
  System.Void Update(UnityEngine.UIElements.UIR.MeshHandle mesh, System.UInt32 vertexCount, System.UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, System.UInt16& indexOffset)
  System.Void UpdateCopyBackIndices(UnityEngine.UIElements.UIR.MeshHandle mesh, System.Boolean copyBackIndices)
  System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate> ActiveUpdatesForMeshHandle(UnityEngine.UIElements.UIR.MeshHandle mesh)
  System.Boolean TryAllocFromPage(UnityEngine.UIElements.UIR.Page page, System.UInt32 vertexCount, System.UInt32 indexCount, UnityEngine.UIElements.UIR.Alloc& va, UnityEngine.UIElements.UIR.Alloc& ia, System.Boolean shortLived)
  System.Void Allocate(UnityEngine.UIElements.UIR.MeshHandle meshHandle, System.UInt32 vertexCount, System.UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, System.Boolean shortLived)
  System.Void UpdateAfterGPUUsedData(UnityEngine.UIElements.UIR.MeshHandle mesh, System.UInt32 vertexCount, System.UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, System.UInt16& indexOffset, UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate& allocToUpdate, System.Boolean copyBackIndices)
  System.Void Free(UnityEngine.UIElements.UIR.MeshHandle mesh)
  UnityEngine.Vector4 GetClipSpaceParams()
  System.Void OnFrameRenderingBegin()
  Unity.Collections.NativeSlice<T> PtrToSlice(System.Void* p, System.Int32 count)
  System.Void ApplyDrawCommandState(UnityEngine.UIElements.UIR.RenderChainCommand cmd, System.Int32 textureSlot, UnityEngine.Material newMat, System.Boolean newMatDiffers, System.Boolean newFontDiffers, UnityEngine.UIElements.UIR.UIRenderDevice.EvaluationState& st)
  System.Void ApplyBatchState(UnityEngine.UIElements.UIR.UIRenderDevice.EvaluationState& st, System.Boolean allowMaterialChange)
  System.Void EvaluateChain(UnityEngine.UIElements.UIR.RenderChainCommand head, UnityEngine.Material initialMat, UnityEngine.Material defaultMat, UnityEngine.Texture gradientSettings, UnityEngine.Texture shaderInfo, System.Single pixelsPerPoint, Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> transforms, Unity.Collections.NativeSlice<UnityEngine.Vector4> clipRects, UnityEngine.MaterialPropertyBlock stateMatProps, System.Boolean allowMaterialChange, System.Exception& immediateException)
  System.Void UpdateFenceValue()
  System.Void KickRanges(UnityEngine.UIElements.UIR.DrawBufferRange* ranges, System.Int32& rangesReady, System.Int32& rangesStart, System.Int32 rangesCount, UnityEngine.UIElements.UIR.Page curPage)
  System.Void DrawRanges(UnityEngine.UIElements.UIR.Utility.GPUBuffer<I> ib, UnityEngine.UIElements.UIR.Utility.GPUBuffer<T> vb, Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.DrawBufferRange> ranges)
  System.Void WaitOnCpuFence(System.UInt32 fence)
  System.Void AdvanceFrame()
  System.Void PruneUnusedPages()
  System.Void PrepareForGfxDeviceRecreate()
  System.Void WrapUpGfxDeviceRecreate()
  System.Void FlushAllPendingDeviceDisposes()
  UnityEngine.UIElements.UIR.UIRenderDevice.DrawStatistics GatherDrawStatistics()
  System.Void ProcessDeviceFreeQueue()
  System.Void OnEngineUpdateGlobal()
  System.Void OnFlushPendingResources()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Alloc
TYPE:  struct
TOKEN: 0x2000313
FIELDS:
  public            System.UInt32                   start  // 0x10
  public            System.UInt32                   size  // 0x14
  private           System.Object                   handle  // 0x18
  private           System.Boolean                  shortLived  // 0x20
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.BestFitAllocator
TYPE:  class
TOKEN: 0x2000314
FIELDS:
  private   readonly System.UInt32                   <totalSize>k__BackingField  // 0x10
  private           UnityEngine.UIElements.UIR.BestFitAllocator.Blockm_FirstBlock  // 0x18
  private           UnityEngine.UIElements.UIR.BestFitAllocator.Blockm_FirstAvailableBlock  // 0x20
  private           UnityEngine.UIElements.UIR.BestFitAllocator.BlockPoolm_BlockPool  // 0x28
  private           System.UInt32                   m_HighWatermark  // 0x30
METHODS:
  System.Void .ctor(System.UInt32 size)
  System.UInt32 get_totalSize()
  System.UInt32 get_highWatermark()
  UnityEngine.UIElements.UIR.Alloc Allocate(System.UInt32 size)
  System.Void Free(UnityEngine.UIElements.UIR.Alloc alloc)
  UnityEngine.UIElements.UIR.BestFitAllocator.Block CoalesceBlockWithPrevious(UnityEngine.UIElements.UIR.BestFitAllocator.Block block)
  UnityEngine.UIElements.UIR.BestFitAllocator.Block BestFitFindAvailableBlock(System.UInt32 size)
  System.Void SplitBlock(UnityEngine.UIElements.UIR.BestFitAllocator.Block block, System.UInt32 size)
END_CLASS

CLASS: UnityEngine.UIElements.UIR.GPUBufferAllocator
TYPE:  class
TOKEN: 0x2000317
FIELDS:
  private           UnityEngine.UIElements.UIR.BestFitAllocatorm_Low  // 0x10
  private           UnityEngine.UIElements.UIR.BestFitAllocatorm_High  // 0x18
METHODS:
  System.Void .ctor(System.UInt32 maxSize)
  UnityEngine.UIElements.UIR.Alloc Allocate(System.UInt32 size, System.Boolean shortLived)
  System.Void Free(UnityEngine.UIElements.UIR.Alloc alloc)
  System.Boolean get_isEmpty()
  System.Boolean HighLowCollide()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Page
TYPE:  class
TOKEN: 0x2000318
FIELDS:
  private           System.Boolean                  <disposed>k__BackingField  // 0x10
  public            UnityEngine.UIElements.UIR.Page.DataSet<UnityEngine.UIElements.Vertex>vertices  // 0x18
  public            UnityEngine.UIElements.UIR.Page.DataSet<System.UInt16>indices  // 0x20
  public            UnityEngine.UIElements.UIR.Page next  // 0x28
  public            System.Int32                    framesEmpty  // 0x30
METHODS:
  System.Void .ctor(System.UInt32 vertexMaxCount, System.UInt32 indexMaxCount, System.UInt32 maxQueuedFrameCount, System.Boolean mockPage)
  System.Boolean get_disposed()
  System.Void set_disposed(System.Boolean value)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Boolean get_isEmpty()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.VertexFlags
TYPE:  struct
TOKEN: 0x200031A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.VertexFlagsIsSolid  // 0x0
  public    static  UnityEngine.UIElements.UIR.VertexFlagsIsText  // 0x0
  public    static  UnityEngine.UIElements.UIR.VertexFlagsIsTextured  // 0x0
  public    static  UnityEngine.UIElements.UIR.VertexFlagsIsDynamic  // 0x0
  public    static  UnityEngine.UIElements.UIR.VertexFlagsIsSvgGradients  // 0x0
  public    static  UnityEngine.UIElements.UIR.VertexFlagsLastType  // 0x0
  public    static  UnityEngine.UIElements.UIR.VertexFlagsIsGraphViewEdge  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.State
TYPE:  struct
TOKEN: 0x200031B
FIELDS:
  public            UnityEngine.Material            material  // 0x10
  public            UnityEngine.Texture             font  // 0x18
  public            System.Single                   fontTexSDFScale  // 0x20
  public            UnityEngine.UIElements.TextureIdtexture  // 0x24
  public            System.Int32                    stencilRef  // 0x28
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.CommandType
TYPE:  struct
TOKEN: 0x200031C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.CommandTypeDraw  // 0x0
  public    static  UnityEngine.UIElements.UIR.CommandTypeImmediateCull  // 0x0
  public    static  UnityEngine.UIElements.UIR.CommandTypeImmediate  // 0x0
  public    static  UnityEngine.UIElements.UIR.CommandTypePushView  // 0x0
  public    static  UnityEngine.UIElements.UIR.CommandTypePopView  // 0x0
  public    static  UnityEngine.UIElements.UIR.CommandTypePushScissor  // 0x0
  public    static  UnityEngine.UIElements.UIR.CommandTypePopScissor  // 0x0
  public    static  UnityEngine.UIElements.UIR.CommandTypePushRenderTexture  // 0x0
  public    static  UnityEngine.UIElements.UIR.CommandTypePopRenderTexture  // 0x0
  public    static  UnityEngine.UIElements.UIR.CommandTypeBlitToPreviousRT  // 0x0
  public    static  UnityEngine.UIElements.UIR.CommandTypePushDefaultMaterial  // 0x0
  public    static  UnityEngine.UIElements.UIR.CommandTypePopDefaultMaterial  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.DrawParams
TYPE:  class
TOKEN: 0x200031D
FIELDS:
  private   static readonly UnityEngine.Rect                k_UnlimitedRect  // 0x0
  private   static readonly UnityEngine.Rect                k_FullNormalizedRect  // 0x10
  private   readonly System.Collections.Generic.Stack<UnityEngine.Matrix4x4>view  // 0x10
  private   readonly System.Collections.Generic.Stack<UnityEngine.Rect>scissor  // 0x18
  private   readonly System.Collections.Generic.List<UnityEngine.RenderTexture>renderTexture  // 0x20
  private   readonly System.Collections.Generic.List<UnityEngine.Material>defaultMaterial  // 0x28
METHODS:
  System.Void Reset()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.RenderChainCommand
TYPE:  class
TOKEN: 0x200031E
EXTENDS: LinkedPoolItem`1
FIELDS:
  private           UnityEngine.UIElements.VisualElementowner  // 0x18
  private           UnityEngine.UIElements.UIR.RenderChainCommandprev  // 0x20
  private           UnityEngine.UIElements.UIR.RenderChainCommandnext  // 0x28
  private           System.Boolean                  closing  // 0x30
  private           UnityEngine.UIElements.UIR.CommandTypetype  // 0x34
  private           UnityEngine.UIElements.UIR.Statestate  // 0x38
  private           UnityEngine.UIElements.UIR.MeshHandlemesh  // 0x58
  private           System.Int32                    indexOffset  // 0x60
  private           System.Int32                    indexCount  // 0x64
  private           System.Action                   callback  // 0x68
  private   static readonly System.Int32                    k_ID_MainTex  // 0x0
  private   static  Unity.Profiling.ProfilerMarker  s_ImmediateOverheadMarker  // 0x8
METHODS:
  System.Void Reset()
  System.Void ExecuteNonDrawMesh(UnityEngine.UIElements.UIR.DrawParams drawParams, System.Single pixelsPerPoint, System.Exception& immediateException)
  System.Void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture destination, System.Single depth)
  UnityEngine.Rect CombineScissorRects(UnityEngine.Rect r0, UnityEngine.Rect r1)
  UnityEngine.RectInt RectPointsToPixelsAndFlipYAxis(UnityEngine.Rect rect, System.Single pixelsPerPoint)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Implementation.CommandGenerator
TYPE:  class
TOKEN: 0x200031F
FIELDS:
  private   static readonly Unity.Profiling.ProfilerMarker  k_ConvertEntriesToCommandsMarker  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  k_NudgeVerticesMarker  // 0x8
  private   static readonly Unity.Profiling.ProfilerMarker  k_ComputeTransformMatrixMarker  // 0x10
  private   static  UnityEngine.Material            s_blitMaterial_LinearToGamma  // 0x18
  private   static  UnityEngine.Material            s_blitMaterial_GammaToLinear  // 0x20
  private   static  UnityEngine.Material            s_blitMaterial_NoChange  // 0x28
  private   static  UnityEngine.Shader              s_blitShader  // 0x30
METHODS:
  System.Void GetVerticesTransformInfo(UnityEngine.UIElements.VisualElement ve, UnityEngine.Matrix4x4& transform)
  System.Void ComputeTransformMatrix(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VisualElement ancestor, UnityEngine.Matrix4x4& result)
  System.Boolean IsParentOrAncestorOf(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.VisualElement child)
  UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo PaintElement(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  UnityEngine.Material CreateBlitShader(System.Single colorConversion)
  UnityEngine.Material GetBlitMaterial(UnityEngine.UIElements.VisualElement.RenderTargetMode mode)
  System.Void ClosePaintElement(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo closingInfo, UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  System.Void UpdateOrAllocate(UnityEngine.UIElements.UIR.MeshHandle& data, System.Int32 vertexCount, System.Int32 indexCount, UnityEngine.UIElements.UIR.UIRenderDevice device, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& verts, Unity.Collections.NativeSlice<System.UInt16>& indices, System.UInt16& indexOffset, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  System.Void CopyTransformVertsPos(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> source, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> target, UnityEngine.Matrix4x4 mat, UnityEngine.Color32 xformClipPages, UnityEngine.Color32 ids, UnityEngine.Color32 addFlags, UnityEngine.Color32 opacityPage, UnityEngine.Color32 textCoreSettingsPage, System.Boolean isText, System.Single textureId)
  System.Void CopyTransformVertsPosAndVec(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> source, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> target, UnityEngine.Matrix4x4 mat, UnityEngine.Color32 xformClipPages, UnityEngine.Color32 ids, UnityEngine.Color32 addFlags, UnityEngine.Color32 opacityPage, UnityEngine.Color32 textCoreSettingsPage, System.Boolean isText, System.Single textureId)
  System.Void CopyTriangleIndicesFlipWindingOrder(Unity.Collections.NativeSlice<System.UInt16> source, Unity.Collections.NativeSlice<System.UInt16> target, System.Int32 indexOffset)
  System.Void CopyTriangleIndices(Unity.Collections.NativeSlice<System.UInt16> source, Unity.Collections.NativeSlice<System.UInt16> target, System.Int32 indexOffset)
  System.Boolean NudgeVerticesToNewSpace(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.UIRenderDevice device)
  System.Void DoNudgeVertices(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.UIRenderDevice device, UnityEngine.UIElements.UIR.MeshHandle mesh, UnityEngine.Matrix4x4& nudgeTransform)
  UnityEngine.UIElements.UIR.RenderChainCommand InjectMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderChainCommand& cmdPrev, UnityEngine.UIElements.UIR.RenderChainCommand& cmdNext, UnityEngine.UIElements.UIR.MeshHandle mesh, System.Int32 indexCount, System.Int32 indexOffset, UnityEngine.Material material, UnityEngine.UIElements.TextureId texture, UnityEngine.Texture font, System.Int32 stencilRef)
  UnityEngine.UIElements.UIR.RenderChainCommand InjectClosingMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderChainCommand& cmdPrev, UnityEngine.UIElements.UIR.RenderChainCommand& cmdNext, UnityEngine.UIElements.UIR.MeshHandle mesh, System.Int32 indexCount, System.Int32 indexOffset, UnityEngine.Material material, UnityEngine.UIElements.TextureId texture, UnityEngine.Texture font, System.Int32 stencilRef)
  System.Void FindCommandInsertionPoint(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderChainCommand& prev, UnityEngine.UIElements.UIR.RenderChainCommand& next)
  System.Void FindClosingCommandInsertionPoint(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.RenderChainCommand& prev, UnityEngine.UIElements.UIR.RenderChainCommand& next)
  System.Void InjectCommandInBetween(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.RenderChainCommand cmd, UnityEngine.UIElements.UIR.RenderChainCommand& prev, UnityEngine.UIElements.UIR.RenderChainCommand& next)
  System.Void InjectClosingCommandInBetween(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.RenderChainCommand cmd, UnityEngine.UIElements.UIR.RenderChainCommand& prev, UnityEngine.UIElements.UIR.RenderChainCommand& next)
  System.Void ResetCommands(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Implementation.ClipMethod
TYPE:  struct
TOKEN: 0x2000320
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.UIElements.UIR.Implementation.ClipMethodUndetermined  // 0x0
  public    static  UnityEngine.UIElements.UIR.Implementation.ClipMethodNotClipped  // 0x0
  public    static  UnityEngine.UIElements.UIR.Implementation.ClipMethodScissor  // 0x0
  public    static  UnityEngine.UIElements.UIR.Implementation.ClipMethodShaderDiscard  // 0x0
  public    static  UnityEngine.UIElements.UIR.Implementation.ClipMethodStencil  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Implementation.RenderEvents
TYPE:  class
TOKEN: 0x2000321
FIELDS:
  private   static readonly System.Single                   VisibilityTreshold  // 0x0
METHODS:
  System.Void ProcessOnClippingChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  System.Void ProcessOnOpacityChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  System.Void ProcessOnColorChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  System.Void ProcessOnTransformOrSizeChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  System.Void ProcessOnVisualsChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  System.Void ProcessRegenText(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.Implementation.UIRTextUpdatePainter painter, UnityEngine.UIElements.UIR.UIRenderDevice device, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  UnityEngine.Matrix4x4 GetTransformIDTransformInfo(UnityEngine.UIElements.VisualElement ve)
  UnityEngine.Vector4 GetClipRectIDClipInfo(UnityEngine.UIElements.VisualElement ve)
  System.UInt32 DepthFirstOnChildAdded(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement parent, UnityEngine.UIElements.VisualElement ve, System.Int32 index, System.Boolean resetState)
  System.UInt32 DepthFirstOnChildRemoving(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve)
  System.Void DepthFirstOnClippingChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement parent, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, System.Boolean hierarchical, System.Boolean isRootOfChange, System.Boolean isPendingHierarchicalRepaint, System.Boolean inheritedClipRectIDChanged, System.Boolean inheritedMaskingChanged, UnityEngine.UIElements.UIR.UIRenderDevice device, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  System.Void DepthFirstOnOpacityChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, System.Single parentCompositeOpacity, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, System.Boolean hierarchical, UnityEngine.UIElements.UIR.ChainBuilderStats& stats, System.Boolean isDoingFullVertexRegeneration)
  System.Void OnColorChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  System.Void DepthFirstOnTransformOrSizeChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement parent, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, UnityEngine.UIElements.UIR.UIRenderDevice device, System.Boolean isAncestorOfChangeSkinned, System.Boolean transformChanged, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  System.Void DepthFirstOnVisualsChanged(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve, System.UInt32 dirtyID, System.Boolean parentHierarchyHidden, System.Boolean hierarchical, UnityEngine.UIElements.UIR.ChainBuilderStats& stats)
  System.Boolean UpdateTextCoreSettings(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve)
  System.Boolean IsElementHierarchyHidden(UnityEngine.UIElements.VisualElement ve)
  UnityEngine.UIElements.VisualElement GetLastDeepestChild(UnityEngine.UIElements.VisualElement ve)
  UnityEngine.UIElements.UIR.Implementation.ClipMethod DetermineSelfClipMethod(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve)
  System.Boolean UpdateLocalFlipsWinding(UnityEngine.UIElements.VisualElement ve)
  System.Void UpdateWorldFlipsWinding(UnityEngine.UIElements.VisualElement ve)
  System.Void UpdateZeroScaling(UnityEngine.UIElements.VisualElement ve)
  System.Boolean NeedsTransformID(UnityEngine.UIElements.VisualElement ve)
  System.Boolean NeedsColorID(UnityEngine.UIElements.VisualElement ve)
  System.Boolean InitColorIDs(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve)
  System.Void SetColorValues(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.VisualElement ve)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Implementation.UIRStylePainter
TYPE:  class
TOKEN: 0x2000322
FIELDS:
  private           UnityEngine.UIElements.UIR.RenderChainm_Owner  // 0x10
  private           System.Collections.Generic.List<UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entry>m_Entries  // 0x18
  private           UnityEngine.UIElements.AtlasBasem_Atlas  // 0x20
  private           UnityEngine.UIElements.UIR.VectorImageManagerm_VectorImageManager  // 0x28
  private           UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entrym_CurrentEntry  // 0x30
  private           UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfom_ClosingInfo  // 0x90
  private           System.Int32                    m_MaskDepth  // 0xC8
  private           System.Int32                    m_StencilRef  // 0xCC
  private           UnityEngine.UIElements.UIR.BMPAllocm_ClipRectID  // 0xD0
  private           System.Int32                    m_SVGBackgroundEntryIndex  // 0xD8
  private           UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.TempDataAlloc<UnityEngine.UIElements.Vertex>m_VertsPool  // 0xE0
  private           UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.TempDataAlloc<System.UInt16>m_IndicesPool  // 0x108
  private           System.Collections.Generic.List<UnityEngine.UIElements.MeshWriteData>m_MeshWriteDataPool  // 0x130
  private           System.Int32                    m_NextMeshWriteDataPoolItem  // 0x138
  private           UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocatorm_AllocRawVertsIndicesDelegate  // 0x140
  private           UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocatorm_AllocThroughDrawMeshDelegate  // 0x148
  private           UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData.Allocatorm_AllocThroughDrawGradientsDelegate  // 0x150
  private   readonly UnityEngine.UIElements.MeshGenerationContext<meshGenerationContext>k__BackingField  // 0x158
  private           UnityEngine.UIElements.VisualElement<currentElement>k__BackingField  // 0x160
  private           System.Int32                    <totalVertices>k__BackingField  // 0x168
  private           System.Int32                    <totalIndices>k__BackingField  // 0x16C
  private           System.Boolean                  <disposed>k__BackingField  // 0x170
METHODS:
  UnityEngine.UIElements.MeshWriteData GetPooledMeshWriteData()
  UnityEngine.UIElements.MeshWriteData AllocRawVertsIndices(System.UInt32 vertexCount, System.UInt32 indexCount, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData& allocatorData)
  UnityEngine.UIElements.MeshWriteData AllocThroughDrawMesh(System.UInt32 vertexCount, System.UInt32 indexCount, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData& allocatorData)
  UnityEngine.UIElements.MeshWriteData AllocThroughDrawGradients(System.UInt32 vertexCount, System.UInt32 indexCount, UnityEngine.UIElements.UIR.MeshBuilder.AllocMeshData& allocatorData)
  System.Void .ctor(UnityEngine.UIElements.UIR.RenderChain renderChain)
  UnityEngine.UIElements.MeshGenerationContext get_meshGenerationContext()
  UnityEngine.UIElements.VisualElement get_currentElement()
  System.Void set_currentElement(UnityEngine.UIElements.VisualElement value)
  System.Collections.Generic.List<UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entry> get_entries()
  UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.ClosingInfo get_closingInfo()
  System.Int32 get_totalVertices()
  System.Void set_totalVertices(System.Int32 value)
  System.Int32 get_totalIndices()
  System.Void set_totalIndices(System.Int32 value)
  System.Boolean get_disposed()
  System.Void set_disposed(System.Boolean value)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Void Begin(UnityEngine.UIElements.VisualElement ve)
  System.Void LandClipUnregisterMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChainCommand cmd)
  System.Void LandClipRegisterMesh(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices, System.Int32 indexOffset)
  UnityEngine.UIElements.MeshWriteData AddGradientsEntry(System.Int32 vertexCount, System.Int32 indexCount, UnityEngine.UIElements.TextureId texture, UnityEngine.Material material, UnityEngine.UIElements.MeshGenerationContext.MeshFlags flags)
  UnityEngine.UIElements.MeshWriteData DrawMesh(System.Int32 vertexCount, System.Int32 indexCount, UnityEngine.Texture texture, UnityEngine.Material material, UnityEngine.UIElements.MeshGenerationContext.MeshFlags flags)
  System.Void DrawText(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint)
  System.Void DrawTextNative(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint)
  System.Void DrawTextCore(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint)
  System.Void DrawRectangle(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams)
  System.Void DrawBorder(UnityEngine.UIElements.MeshGenerationContextUtils.BorderParams borderParams)
  System.Void DrawImmediate(System.Action callback, System.Boolean cullingEnabled)
  UnityEngine.UIElements.VisualElement get_visualElement()
  System.Void DrawVisualElementBackground()
  System.Void DrawVisualElementBorder()
  System.Void ApplyVisualElementClipping()
  System.UInt16[] AdjustSpriteWinding(UnityEngine.Vector2[] vertices, System.UInt16[] indices)
  System.Void DrawSprite(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams)
  System.Void ApplyInset(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams& rectParams, UnityEngine.Texture tex)
  System.Void DrawVectorImage(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams)
  System.Void Reset()
  System.Void ValidateMeshWriteData()
  System.Void GenerateStencilClipEntryForRoundedRectBackground()
  System.Void GenerateStencilClipEntryForSVGBackground()
END_CLASS

CLASS: UnityEngine.UIElements.UIR.Implementation.UIRTextUpdatePainter
TYPE:  class
TOKEN: 0x2000326
FIELDS:
  private           UnityEngine.UIElements.VisualElementm_CurrentElement  // 0x10
  private           System.Int32                    m_TextEntryIndex  // 0x18
  private           Unity.Collections.NativeArray<UnityEngine.UIElements.Vertex>m_DudVerts  // 0x20
  private           Unity.Collections.NativeArray<System.UInt16>m_DudIndices  // 0x30
  private           Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>m_MeshDataVerts  // 0x40
  private           UnityEngine.Color32             m_XFormClipPages  // 0x50
  private           UnityEngine.Color32             m_IDs  // 0x54
  private           UnityEngine.Color32             m_Flags  // 0x58
  private           UnityEngine.Color32             m_OpacityColorPages  // 0x5C
  private   readonly UnityEngine.UIElements.MeshGenerationContext<meshGenerationContext>k__BackingField  // 0x60
METHODS:
  UnityEngine.UIElements.MeshGenerationContext get_meshGenerationContext()
  System.Void .ctor()
  System.Void Begin(UnityEngine.UIElements.VisualElement ve, UnityEngine.UIElements.UIR.UIRenderDevice device)
  System.Void End()
  System.Void Dispose()
  System.Void DrawRectangle(UnityEngine.UIElements.MeshGenerationContextUtils.RectangleParams rectParams)
  System.Void DrawImmediate(System.Action callback, System.Boolean cullingEnabled)
  System.Void DrawText(UnityEngine.UIElements.MeshGenerationContextUtils.TextParams textParams, UnityEngine.UIElements.ITextHandle handle, System.Single pixelsPerPoint)
END_CLASS

