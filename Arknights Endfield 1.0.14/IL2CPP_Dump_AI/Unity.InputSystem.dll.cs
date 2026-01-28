// ========================================================
// Dumped by @desirepro
// Assembly: Unity.InputSystem.dll
// Classes:  647
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: UISupport
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.Void Initialize()
END_CLASS

CLASS: ActionFlags
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputAction.ActionFlagsWantsInitialStateCheck  // 0x0
METHODS:
END_CLASS

CLASS: CallbackContext
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  private           UnityEngine.InputSystem.InputActionStatem_State  // 0x10
  private           System.Int32                    m_ActionIndex  // 0x18
METHODS:
  System.Int32 get_actionIndex()
  System.Int32 get_bindingIndex()
  System.Int32 get_controlIndex()
  System.Int32 get_interactionIndex()
  UnityEngine.InputSystem.InputActionPhase get_phase()
  System.Boolean get_started()
  System.Boolean get_performed()
  System.Boolean get_canceled()
  UnityEngine.InputSystem.InputAction get_action()
  UnityEngine.InputSystem.InputControl get_control()
  UnityEngine.InputSystem.IInputInteraction get_interaction()
  System.Double get_time()
  System.Double get_startTime()
  System.Double get_duration()
  System.Type get_valueType()
  System.Int32 get_valueSizeInBytes()
  System.Void ReadValue(System.Void* buffer, System.Int32 bufferSize)
  TValue ReadValue()
  System.Boolean ReadValueAsButton()
  System.Object ReadValueAsObject()
  System.String ToString()
END_CLASS

CLASS: WriteFileJson
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            System.String                   name  // 0x10
  public            UnityEngine.InputSystem.InputActionMap.WriteMapJson[]maps  // 0x18
  public            UnityEngine.InputSystem.InputControlScheme.SchemeJson[]controlSchemes  // 0x20
METHODS:
END_CLASS

CLASS: WriteFileJsonNoName
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            UnityEngine.InputSystem.InputActionMap.WriteMapJson[]maps  // 0x10
  public            UnityEngine.InputSystem.InputControlScheme.SchemeJson[]controlSchemes  // 0x18
METHODS:
END_CLASS

CLASS: ReadFileJson
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            System.String                   name  // 0x10
  public            UnityEngine.InputSystem.InputActionMap.ReadMapJson[]maps  // 0x18
  public            UnityEngine.InputSystem.InputControlScheme.SchemeJson[]controlSchemes  // 0x20
METHODS:
  System.Void ToAsset(UnityEngine.InputSystem.InputActionAsset asset)
END_CLASS

CLASS: Flags
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputActionMap.FlagsNeedToResolveBindings  // 0x0
  public    static  UnityEngine.InputSystem.InputActionMap.FlagsBindingResolutionNeedsFullReResolve  // 0x0
  public    static  UnityEngine.InputSystem.InputActionMap.FlagsControlsForEachActionInitialized  // 0x0
  public    static  UnityEngine.InputSystem.InputActionMap.FlagsBindingsForEachActionInitialized  // 0x0
METHODS:
END_CLASS

CLASS: DeviceArray
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  private           System.Boolean                  m_HaveValue  // 0x10
  private           System.Int32                    m_DeviceCount  // 0x14
  private           UnityEngine.InputSystem.InputDevice[]m_DeviceArray  // 0x18
METHODS:
  System.Int32 IndexOf(UnityEngine.InputSystem.InputDevice device)
  System.Boolean Remove(UnityEngine.InputSystem.InputDevice device)
  System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> Get()
  System.Boolean Set(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> devices)
END_CLASS

CLASS: BindingOverrideListJson
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Collections.Generic.List<UnityEngine.InputSystem.InputActionMap.BindingOverrideJson>bindings  // 0x10
METHODS:
END_CLASS

CLASS: BindingOverrideJson
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  public            System.String                   action  // 0x10
  public            System.String                   id  // 0x18
  public            System.String                   path  // 0x20
  public            System.String                   interactions  // 0x28
  public            System.String                   processors  // 0x30
METHODS:
  UnityEngine.InputSystem.InputActionMap.BindingOverrideJson FromBinding(UnityEngine.InputSystem.InputBinding binding, System.String actionName)
  UnityEngine.InputSystem.InputActionMap.BindingOverrideJson FromBinding(UnityEngine.InputSystem.InputBinding binding)
  UnityEngine.InputSystem.InputBinding ToBinding(UnityEngine.InputSystem.InputActionMap.BindingOverrideJson bindingOverride)
END_CLASS

CLASS: BindingJson
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   id  // 0x18
  public            System.String                   path  // 0x20
  public            System.String                   interactions  // 0x28
  public            System.String                   processors  // 0x30
  public            System.String                   groups  // 0x38
  public            System.String                   action  // 0x40
  public            System.Boolean                  isComposite  // 0x48
  public            System.Boolean                  isPartOfComposite  // 0x49
METHODS:
  UnityEngine.InputSystem.InputBinding ToBinding()
  UnityEngine.InputSystem.InputActionMap.BindingJson FromBinding(UnityEngine.InputSystem.InputBinding& binding)
END_CLASS

CLASS: ReadActionJson
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   type  // 0x18
  public            System.String                   id  // 0x20
  public            System.String                   expectedControlType  // 0x28
  public            System.String                   expectedControlLayout  // 0x30
  public            System.String                   processors  // 0x38
  public            System.String                   interactions  // 0x40
  public            System.Boolean                  passThrough  // 0x48
  public            System.Boolean                  initialStateCheck  // 0x49
  public            UnityEngine.InputSystem.InputActionMap.BindingJson[]bindings  // 0x50
METHODS:
  UnityEngine.InputSystem.InputAction ToAction(System.String actionName)
END_CLASS

CLASS: WriteActionJson
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   type  // 0x18
  public            System.String                   id  // 0x20
  public            System.String                   expectedControlType  // 0x28
  public            System.String                   processors  // 0x30
  public            System.String                   interactions  // 0x38
  public            System.Boolean                  initialStateCheck  // 0x40
METHODS:
  UnityEngine.InputSystem.InputActionMap.WriteActionJson FromAction(UnityEngine.InputSystem.InputAction action)
END_CLASS

CLASS: ReadMapJson
TYPE:  struct
TOKEN: 0x200002C
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   id  // 0x18
  public            UnityEngine.InputSystem.InputActionMap.ReadActionJson[]actions  // 0x20
  public            UnityEngine.InputSystem.InputActionMap.BindingJson[]bindings  // 0x28
METHODS:
END_CLASS

CLASS: WriteMapJson
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   id  // 0x18
  public            UnityEngine.InputSystem.InputActionMap.WriteActionJson[]actions  // 0x20
  public            UnityEngine.InputSystem.InputActionMap.BindingJson[]bindings  // 0x28
METHODS:
  UnityEngine.InputSystem.InputActionMap.WriteMapJson FromMap(UnityEngine.InputSystem.InputActionMap map)
END_CLASS

CLASS: WriteFileJson
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  public            UnityEngine.InputSystem.InputActionMap.WriteMapJson[]maps  // 0x10
METHODS:
  UnityEngine.InputSystem.InputActionMap.WriteFileJson FromMap(UnityEngine.InputSystem.InputActionMap map)
  UnityEngine.InputSystem.InputActionMap.WriteFileJson FromMaps(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionMap> maps)
END_CLASS

CLASS: ReadFileJson
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            UnityEngine.InputSystem.InputActionMap.ReadActionJson[]actions  // 0x10
  public            UnityEngine.InputSystem.InputActionMap.ReadMapJson[]maps  // 0x18
METHODS:
  UnityEngine.InputSystem.InputActionMap[] ToMaps()
END_CLASS

CLASS: Parameter
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.Object                   instance  // 0x10
  public            System.Reflection.FieldInfo     field  // 0x18
  public            System.Int32                    bindingIndex  // 0x20
METHODS:
END_CLASS

CLASS: ParameterEnumerable
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  private           UnityEngine.InputSystem.InputActionStatem_State  // 0x10
  private           UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverridem_Parameter  // 0x18
  private           System.Int32                    m_MapIndex  // 0x90
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.InputActionState state, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameter, System.Int32 mapIndex)
  UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterEnumerator GetEnumerator()
  System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: ParameterEnumerator
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  private           UnityEngine.InputSystem.InputActionStatem_State  // 0x10
  private           System.Int32                    m_MapIndex  // 0x18
  private           System.Int32                    m_BindingCurrentIndex  // 0x1C
  private           System.Int32                    m_BindingEndIndex  // 0x20
  private           System.Int32                    m_InteractionCurrentIndex  // 0x24
  private           System.Int32                    m_InteractionEndIndex  // 0x28
  private           System.Int32                    m_ProcessorCurrentIndex  // 0x2C
  private           System.Int32                    m_ProcessorEndIndex  // 0x30
  private           UnityEngine.InputSystem.InputBindingm_BindingMask  // 0x38
  private           System.Type                     m_ObjectType  // 0x90
  private           System.String                   m_ParameterName  // 0x98
  private           System.Boolean                  m_MayBeInteraction  // 0xA0
  private           System.Boolean                  m_MayBeProcessor  // 0xA1
  private           System.Boolean                  m_MayBeComposite  // 0xA2
  private           System.Boolean                  m_CurrentBindingIsComposite  // 0xA3
  private           System.Object                   m_CurrentObject  // 0xA8
  private           System.Reflection.FieldInfo     m_CurrentParameter  // 0xB0
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.InputActionState state, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameter, System.Int32 mapIndex)
  System.Boolean MoveToNextBinding()
  System.Boolean MoveToNextInteraction()
  System.Boolean MoveToNextProcessor()
  System.Boolean FindParameter(System.Object instance)
  System.Boolean MoveNext()
  System.Void Reset()
  UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void Dispose()
END_CLASS

CLASS: ParameterOverride
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.String                   objectRegistrationName  // 0x10
  public            System.String                   parameter  // 0x18
  public            UnityEngine.InputSystem.InputBindingbindingMask  // 0x20
  public            UnityEngine.InputSystem.Utilities.PrimitiveValuevalue  // 0x78
METHODS:
  System.Type get_objectType()
  System.Void .ctor(System.String parameterName, UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.Utilities.PrimitiveValue value)
  System.Void .ctor(System.String objectRegistrationName, System.String parameterName, UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.Utilities.PrimitiveValue value)
  System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> Find(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding& binding, System.String parameterName, System.String objectRegistrationName)
  System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> Find(UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[] overrides, System.Int32 overrideCount, UnityEngine.InputSystem.InputBinding& binding, System.String parameterName, System.String objectRegistrationName)
  System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> PickMoreSpecificOne(System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> first, System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> second)
END_CLASS

CLASS: Flags
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.FlagsStarted  // 0x0
  public    static  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.FlagsCompleted  // 0x0
  public    static  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.FlagsCanceled  // 0x0
  public    static  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.FlagsOnEventHooked  // 0x0
  public    static  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.FlagsOnAfterUpdateHooked  // 0x0
  public    static  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.FlagsDontIgnoreNoisyControls  // 0x0
  public    static  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.FlagsDontGeneralizePathOfSelectedControl  // 0x0
  public    static  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.FlagsAddNewBinding  // 0x0
  public    static  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.FlagsSuppressMatchingEvents  // 0x0
METHODS:
END_CLASS

CLASS: RebindingOperation
TYPE:  class
TOKEN: 0x2000035
FIELDS:
  public    static  System.Single                   kDefaultMagnitudeThreshold  // 0x0
  private           UnityEngine.InputSystem.InputActionm_ActionToRebind  // 0x10
  private           System.Nullable<UnityEngine.InputSystem.InputBinding>m_BindingMask  // 0x18
  private           System.Type                     m_ControlType  // 0x78
  private           UnityEngine.InputSystem.Utilities.InternedStringm_ExpectedLayout  // 0x80
  private           System.Int32                    m_IncludePathCount  // 0x90
  private           System.String[]                 m_IncludePaths  // 0x98
  private           System.Int32                    m_ExcludePathCount  // 0xA0
  private           System.String[]                 m_ExcludePaths  // 0xA8
  private           System.Int32                    m_TargetBindingIndex  // 0xB0
  private           System.String                   m_BindingGroupForNewBinding  // 0xB8
  private           System.String                   m_CancelBinding  // 0xC0
  private           System.Single                   m_MagnitudeThreshold  // 0xC8
  private           System.Single[]                 m_Scores  // 0xD0
  private           System.Single[]                 m_Magnitudes  // 0xD8
  private           System.Double                   m_LastMatchTime  // 0xE0
  private           System.Double                   m_StartTime  // 0xE8
  private           System.Single                   m_Timeout  // 0xF0
  private           System.Single                   m_WaitSecondsAfterMatch  // 0xF4
  private           UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl>m_Candidates  // 0xF8
  private           System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation>m_OnComplete  // 0x118
  private           System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation>m_OnCancel  // 0x120
  private           System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation>m_OnPotentialMatch  // 0x128
  private           System.Func<UnityEngine.InputSystem.InputControl,System.String>m_OnGeneratePath  // 0x130
  private           System.Func<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Single>m_OnComputeScore  // 0x138
  private           System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation,System.String>m_OnApplyBinding  // 0x140
  private           System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice>m_OnEventDelegate  // 0x148
  private           System.Action                   m_OnAfterUpdateDelegate  // 0x150
  private           UnityEngine.InputSystem.Layouts.InputControlLayout.Cachem_LayoutCache  // 0x158
  private           System.Text.StringBuilder       m_PathBuilder  // 0x160
  private           UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.Flagsm_Flags  // 0x168
  private           System.Collections.Generic.Dictionary<UnityEngine.InputSystem.InputControl,System.Single>m_StartingActuations  // 0x170
METHODS:
  UnityEngine.InputSystem.InputAction get_action()
  System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask()
  UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> get_candidates()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.Single> get_scores()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.Single> get_magnitudes()
  UnityEngine.InputSystem.InputControl get_selectedControl()
  System.Boolean get_started()
  System.Boolean get_completed()
  System.Boolean get_canceled()
  System.Double get_startTime()
  System.Single get_timeout()
  System.String get_expectedControlType()
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithAction(UnityEngine.InputSystem.InputAction action)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithMatchingEventsBeingSuppressed(System.Boolean value)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithCancelingThrough(System.String binding)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithCancelingThrough(UnityEngine.InputSystem.InputControl control)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithExpectedControlType(System.String layoutName)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithExpectedControlType(System.Type type)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithExpectedControlType()
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithTargetBinding(System.Int32 bindingIndex)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithBindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> bindingMask)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithBindingGroup(System.String group)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithoutGeneralizingPathOfSelectedControl()
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithRebindAddingNewBinding(System.String group)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithMagnitudeHavingToBeGreaterThan(System.Single magnitude)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithoutIgnoringNoisyControls()
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithControlsHavingToMatchPath(System.String path)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithControlsExcluding(System.String path)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithTimeout(System.Single timeInSeconds)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnComplete(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnCancel(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnPotentialMatch(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnGeneratePath(System.Func<UnityEngine.InputSystem.InputControl,System.String> callback)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnComputeScore(System.Func<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Single> callback)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnApplyBinding(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation,System.String> callback)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnMatchWaitForAnother(System.Single seconds)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation Start()
  System.Void Cancel()
  System.Void Complete()
  System.Void AddCandidate(UnityEngine.InputSystem.InputControl control, System.Single score, System.Single magnitude)
  System.Void RemoveCandidate(UnityEngine.InputSystem.InputControl control)
  System.Void Dispose()
  System.Void Finalize()
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation Reset()
  System.Void HookOnEvent()
  System.Void UnhookOnEvent()
  System.Void OnEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device)
  System.Void SortCandidatesByScore()
  System.Boolean HavePathMatch(UnityEngine.InputSystem.InputControl control, System.String[] paths, System.Int32 pathCount)
  System.Void HookOnAfterUpdate()
  System.Void UnhookOnAfterUpdate()
  System.Void OnAfterUpdate()
  System.Void OnComplete()
  System.Void OnCancel()
  System.Void ResetAfterMatchCompleted()
  System.Void ThrowIfRebindInProgress()
  System.String GeneratePathForControl(UnityEngine.InputSystem.InputControl control)
  System.Void .ctor()
END_CLASS

CLASS: DeferBindingResolutionWrapper
TYPE:  class
TOKEN: 0x2000038
FIELDS:
METHODS:
  System.Void Acquire()
  System.Void Dispose()
  System.Void .ctor()
END_CLASS

CLASS: BindingSyntax
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  private   readonly UnityEngine.InputSystem.InputActionMapm_ActionMap  // 0x10
  private   readonly UnityEngine.InputSystem.InputActionm_Action  // 0x18
  private   readonly System.Int32                    m_BindingIndexInMap  // 0x20
METHODS:
  System.Boolean get_valid()
  System.Int32 get_bindingIndex()
  UnityEngine.InputSystem.InputBinding get_binding()
  System.Void .ctor(UnityEngine.InputSystem.InputActionMap map, System.Int32 bindingIndexInMap, UnityEngine.InputSystem.InputAction action)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithName(System.String name)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithPath(System.String path)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithGroup(System.String group)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithGroups(System.String groups)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithInteraction(System.String interaction)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithInteractions(System.String interactions)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithInteraction()
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithProcessor(System.String processor)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithProcessors(System.String processors)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithProcessor()
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax Triggering(UnityEngine.InputSystem.InputAction action)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax To(UnityEngine.InputSystem.InputBinding binding)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax NextBinding()
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax PreviousBinding()
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax NextPartBinding(System.String partName)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax PreviousPartBinding(System.String partName)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax NextCompositeBinding(System.String compositeName)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax PreviousCompositeBinding(System.String compositeName)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax Iterate(System.Boolean next)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax IterateCompositeBinding(System.Boolean next, System.String compositeName)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax IteratePartBinding(System.Boolean next, System.String partName)
  System.Void Erase()
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax InsertPartBinding(System.String partName, System.String path)
END_CLASS

CLASS: CompositeSyntax
TYPE:  struct
TOKEN: 0x200003F
FIELDS:
  private   readonly UnityEngine.InputSystem.InputActionm_Action  // 0x10
  private   readonly UnityEngine.InputSystem.InputActionMapm_ActionMap  // 0x18
  private           System.Int32                    m_BindingIndexInMap  // 0x20
METHODS:
  System.Int32 get_bindingIndex()
  System.Void .ctor(UnityEngine.InputSystem.InputActionMap map, UnityEngine.InputSystem.InputAction action, System.Int32 compositeIndex)
  UnityEngine.InputSystem.InputActionSetupExtensions.CompositeSyntax With(System.String name, System.String binding, System.String groups, System.String processors)
END_CLASS

CLASS: ControlSchemeSyntax
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
  private   readonly UnityEngine.InputSystem.InputActionAssetm_Asset  // 0x10
  private   readonly System.Int32                    m_ControlSchemeIndex  // 0x18
  private           UnityEngine.InputSystem.InputControlSchemem_ControlScheme  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.InputActionAsset asset, System.Int32 index)
  System.Void .ctor(UnityEngine.InputSystem.InputControlScheme controlScheme)
  UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithBindingGroup(System.String bindingGroup)
  UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithRequiredDevice()
  UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithOptionalDevice()
  UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithRequiredDevice()
  UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithOptionalDevice()
  UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithRequiredDevice(System.String controlPath)
  UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithOptionalDevice(System.String controlPath)
  UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithRequiredDevice(System.String controlPath)
  UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithOptionalDevice(System.String controlPath)
  System.String DeviceTypeToControlPath()
  UnityEngine.InputSystem.InputControlScheme Done()
  System.Void AddDeviceEntry(System.String controlPath, UnityEngine.InputSystem.InputControlScheme.DeviceRequirement.Flags flags)
END_CLASS

CLASS: Flags
TYPE:  struct
TOKEN: 0x2000044
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputActionState.InteractionState.FlagsTimerRunning  // 0x0
METHODS:
END_CLASS

CLASS: InteractionState
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  private           System.UInt16                   m_TriggerControlIndex  // 0x10
  private           System.Byte                     m_Phase  // 0x12
  private           System.Byte                     m_Flags  // 0x13
  private           System.Single                   m_TimerDuration  // 0x14
  private           System.Double                   m_StartTime  // 0x18
  private           System.Double                   m_TimerStartTime  // 0x20
  private           System.Double                   m_PerformedTime  // 0x28
  private           System.Single                   m_TotalTimeoutCompletionTimeDone  // 0x30
  private           System.Single                   m_TotalTimeoutCompletionTimeRemaining  // 0x34
  private           System.Int64                    m_TimerMonitorIndex  // 0x38
METHODS:
  System.Int32 get_triggerControlIndex()
  System.Void set_triggerControlIndex(System.Int32 value)
  System.Double get_startTime()
  System.Void set_startTime(System.Double value)
  System.Double get_performedTime()
  System.Void set_performedTime(System.Double value)
  System.Double get_timerStartTime()
  System.Void set_timerStartTime(System.Double value)
  System.Single get_timerDuration()
  System.Void set_timerDuration(System.Single value)
  System.Single get_totalTimeoutCompletionDone()
  System.Void set_totalTimeoutCompletionDone(System.Single value)
  System.Single get_totalTimeoutCompletionTimeRemaining()
  System.Void set_totalTimeoutCompletionTimeRemaining(System.Single value)
  System.Int64 get_timerMonitorIndex()
  System.Void set_timerMonitorIndex(System.Int64 value)
  System.Boolean get_isTimerRunning()
  System.Void set_isTimerRunning(System.Boolean value)
  UnityEngine.InputSystem.InputActionPhase get_phase()
  System.Void set_phase(UnityEngine.InputSystem.InputActionPhase value)
END_CLASS

CLASS: Flags
TYPE:  struct
TOKEN: 0x2000046
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputActionState.BindingState.FlagsChainsWithNext  // 0x0
  public    static  UnityEngine.InputSystem.InputActionState.BindingState.FlagsEndOfChain  // 0x0
  public    static  UnityEngine.InputSystem.InputActionState.BindingState.FlagsComposite  // 0x0
  public    static  UnityEngine.InputSystem.InputActionState.BindingState.FlagsPartOfComposite  // 0x0
  public    static  UnityEngine.InputSystem.InputActionState.BindingState.FlagsInitialStateCheckPending  // 0x0
  public    static  UnityEngine.InputSystem.InputActionState.BindingState.FlagsWantsInitialStateCheck  // 0x0
METHODS:
END_CLASS

CLASS: BindingState
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  private           System.Byte                     m_ControlCount  // 0x10
  private           System.Byte                     m_InteractionCount  // 0x11
  private           System.Byte                     m_ProcessorCount  // 0x12
  private           System.Byte                     m_MapIndex  // 0x13
  private           System.Byte                     m_Flags  // 0x14
  private           System.Byte                     m_PartIndex  // 0x15
  private           System.UInt16                   m_ActionIndex  // 0x16
  private           System.UInt16                   m_CompositeOrCompositeBindingIndex  // 0x18
  private           System.UInt16                   m_ProcessorStartIndex  // 0x1A
  private           System.UInt16                   m_InteractionStartIndex  // 0x1C
  private           System.UInt16                   m_ControlStartIndex  // 0x1E
  private           System.Double                   m_PressTime  // 0x20
  private           System.Int32                    m_TriggerEventIdForComposite  // 0x28
  private           System.Int32                    __padding  // 0x2C
METHODS:
  System.Int32 get_controlStartIndex()
  System.Void set_controlStartIndex(System.Int32 value)
  System.Int32 get_controlCount()
  System.Void set_controlCount(System.Int32 value)
  System.Int32 get_interactionStartIndex()
  System.Void set_interactionStartIndex(System.Int32 value)
  System.Int32 get_interactionCount()
  System.Void set_interactionCount(System.Int32 value)
  System.Int32 get_processorStartIndex()
  System.Void set_processorStartIndex(System.Int32 value)
  System.Int32 get_processorCount()
  System.Void set_processorCount(System.Int32 value)
  System.Int32 get_actionIndex()
  System.Void set_actionIndex(System.Int32 value)
  System.Int32 get_mapIndex()
  System.Void set_mapIndex(System.Int32 value)
  System.Int32 get_compositeOrCompositeBindingIndex()
  System.Void set_compositeOrCompositeBindingIndex(System.Int32 value)
  System.Int32 get_triggerEventIdForComposite()
  System.Void set_triggerEventIdForComposite(System.Int32 value)
  System.Double get_pressTime()
  System.Void set_pressTime(System.Double value)
  UnityEngine.InputSystem.InputActionState.BindingState.Flags get_flags()
  System.Void set_flags(UnityEngine.InputSystem.InputActionState.BindingState.Flags value)
  System.Boolean get_chainsWithNext()
  System.Void set_chainsWithNext(System.Boolean value)
  System.Boolean get_isEndOfChain()
  System.Void set_isEndOfChain(System.Boolean value)
  System.Boolean get_isPartOfChain()
  System.Boolean get_isComposite()
  System.Void set_isComposite(System.Boolean value)
  System.Boolean get_isPartOfComposite()
  System.Void set_isPartOfComposite(System.Boolean value)
  System.Boolean get_initialStateCheckPending()
  System.Void set_initialStateCheckPending(System.Boolean value)
  System.Boolean get_wantsInitialStateCheck()
  System.Void set_wantsInitialStateCheck(System.Boolean value)
  System.Int32 get_partIndex()
  System.Void set_partIndex(System.Int32 value)
END_CLASS

CLASS: Flags
TYPE:  struct
TOKEN: 0x2000048
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputActionState.TriggerState.FlagsHaveMagnitude  // 0x0
  public    static  UnityEngine.InputSystem.InputActionState.TriggerState.FlagsPassThrough  // 0x0
  public    static  UnityEngine.InputSystem.InputActionState.TriggerState.FlagsMayNeedConflictResolution  // 0x0
  public    static  UnityEngine.InputSystem.InputActionState.TriggerState.FlagsHasMultipleConcurrentActuations  // 0x0
  public    static  UnityEngine.InputSystem.InputActionState.TriggerState.FlagsInProcessing  // 0x0
  public    static  UnityEngine.InputSystem.InputActionState.TriggerState.FlagsButton  // 0x0
  public    static  UnityEngine.InputSystem.InputActionState.TriggerState.FlagsPressed  // 0x0
METHODS:
END_CLASS

CLASS: TriggerState
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  public    static  System.Int32                    kMaxNumMaps  // 0x0
  public    static  System.Int32                    kMaxNumControls  // 0x0
  public    static  System.Int32                    kMaxNumBindings  // 0x0
  private           System.Byte                     m_Phase  // 0x10
  private           System.Byte                     m_Flags  // 0x11
  private           System.Byte                     m_MapIndex  // 0x12
  private           System.UInt16                   m_ControlIndex  // 0x14
  private           System.Double                   m_Time  // 0x18
  private           System.Double                   m_StartTime  // 0x20
  private           System.UInt16                   m_BindingIndex  // 0x28
  private           System.UInt16                   m_InteractionIndex  // 0x2A
  private           System.Single                   m_Magnitude  // 0x2C
  private           System.UInt32                   m_LastPerformedInUpdate  // 0x30
  private           System.UInt32                   m_LastCanceledInUpdate  // 0x34
  private           System.UInt32                   m_PressedInUpdate  // 0x38
  private           System.UInt32                   m_ReleasedInUpdate  // 0x3C
  private           System.UInt32                   m_LastCompletedInUpdate  // 0x40
  private           System.Int32                    framePerformed  // 0x44
  private           System.Int32                    framePressed  // 0x48
  private           System.Int32                    frameReleased  // 0x4C
  private           System.Int32                    frameCompleted  // 0x50
METHODS:
  UnityEngine.InputSystem.InputActionPhase get_phase()
  System.Void set_phase(UnityEngine.InputSystem.InputActionPhase value)
  System.Boolean get_isDisabled()
  System.Boolean get_isWaiting()
  System.Boolean get_isStarted()
  System.Boolean get_isPerformed()
  System.Boolean get_isCanceled()
  System.Double get_time()
  System.Void set_time(System.Double value)
  System.Double get_startTime()
  System.Void set_startTime(System.Double value)
  System.Single get_magnitude()
  System.Void set_magnitude(System.Single value)
  System.Boolean get_haveMagnitude()
  System.Int32 get_mapIndex()
  System.Void set_mapIndex(System.Int32 value)
  System.Int32 get_controlIndex()
  System.Void set_controlIndex(System.Int32 value)
  System.Int32 get_bindingIndex()
  System.Void set_bindingIndex(System.Int32 value)
  System.Int32 get_interactionIndex()
  System.Void set_interactionIndex(System.Int32 value)
  System.UInt32 get_lastPerformedInUpdate()
  System.Void set_lastPerformedInUpdate(System.UInt32 value)
  System.UInt32 get_lastCompletedInUpdate()
  System.Void set_lastCompletedInUpdate(System.UInt32 value)
  System.UInt32 get_lastCanceledInUpdate()
  System.Void set_lastCanceledInUpdate(System.UInt32 value)
  System.UInt32 get_pressedInUpdate()
  System.Void set_pressedInUpdate(System.UInt32 value)
  System.UInt32 get_releasedInUpdate()
  System.Void set_releasedInUpdate(System.UInt32 value)
  System.Boolean get_isPassThrough()
  System.Void set_isPassThrough(System.Boolean value)
  System.Boolean get_isButton()
  System.Void set_isButton(System.Boolean value)
  System.Boolean get_isPressed()
  System.Void set_isPressed(System.Boolean value)
  System.Boolean get_mayNeedConflictResolution()
  System.Void set_mayNeedConflictResolution(System.Boolean value)
  System.Boolean get_hasMultipleConcurrentActuations()
  System.Void set_hasMultipleConcurrentActuations(System.Boolean value)
  System.Boolean get_inProcessing()
  System.Void set_inProcessing(System.Boolean value)
  UnityEngine.InputSystem.InputActionState.TriggerState.Flags get_flags()
  System.Void set_flags(UnityEngine.InputSystem.InputActionState.TriggerState.Flags value)
END_CLASS

CLASS: ActionMapIndices
TYPE:  struct
TOKEN: 0x2000049
FIELDS:
  public            System.Int32                    actionStartIndex  // 0x10
  public            System.Int32                    actionCount  // 0x14
  public            System.Int32                    controlStartIndex  // 0x18
  public            System.Int32                    controlCount  // 0x1C
  public            System.Int32                    bindingStartIndex  // 0x20
  public            System.Int32                    bindingCount  // 0x24
  public            System.Int32                    interactionStartIndex  // 0x28
  public            System.Int32                    interactionCount  // 0x2C
  public            System.Int32                    processorStartIndex  // 0x30
  public            System.Int32                    processorCount  // 0x34
  public            System.Int32                    compositeStartIndex  // 0x38
  public            System.Int32                    compositeCount  // 0x3C
METHODS:
END_CLASS

CLASS: UnmanagedMemory
TYPE:  struct
TOKEN: 0x200004A
FIELDS:
  public            System.Void*                    basePtr  // 0x10
  public            System.Int32                    mapCount  // 0x18
  public            System.Int32                    actionCount  // 0x1C
  public            System.Int32                    interactionCount  // 0x20
  public            System.Int32                    bindingCount  // 0x24
  public            System.Int32                    controlCount  // 0x28
  public            System.Int32                    compositeCount  // 0x2C
  public            UnityEngine.InputSystem.InputActionState.TriggerState*actionStates  // 0x30
  public            UnityEngine.InputSystem.InputActionState.BindingState*bindingStates  // 0x38
  public            UnityEngine.InputSystem.InputActionState.InteractionState*interactionStates  // 0x40
  public            System.Single*                  controlMagnitudes  // 0x48
  public            System.Single*                  compositeMagnitudes  // 0x50
  public            System.Int32*                   enabledControls  // 0x58
  public            System.UInt16*                  actionBindingIndicesAndCounts  // 0x60
  public            System.UInt16*                  actionBindingIndices  // 0x68
  public            System.Int32*                   controlIndexToBindingIndex  // 0x70
  public            System.UInt16*                  controlGroupingAndComplexity  // 0x78
  public            System.Boolean                  controlGroupingInitialized  // 0x80
  public            UnityEngine.InputSystem.InputActionState.ActionMapIndices*mapIndices  // 0x88
METHODS:
  System.Boolean get_isAllocated()
  System.Int32 get_sizeInBytes()
  System.Void Allocate(System.Int32 mapCount, System.Int32 actionCount, System.Int32 bindingCount, System.Int32 controlCount, System.Int32 interactionCount, System.Int32 compositeCount)
  System.Void Dispose()
  System.Void CopyDataFrom(UnityEngine.InputSystem.InputActionState.UnmanagedMemory memory)
  UnityEngine.InputSystem.InputActionState.UnmanagedMemory Clone()
END_CLASS

CLASS: GlobalState
TYPE:  struct
TOKEN: 0x200004B
FIELDS:
  private           UnityEngine.InputSystem.Utilities.InlinedArray<System.Runtime.InteropServices.GCHandle>globalList  // 0x10
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<System.Object,UnityEngine.InputSystem.InputActionChange>>onActionChange  // 0x28
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<System.Object>>onActionControlsChanged  // 0x78
METHODS:
END_CLASS

CLASS: DisplayStringOptions
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputBinding.DisplayStringOptionsDontUseShortDisplayNames  // 0x0
  public    static  UnityEngine.InputSystem.InputBinding.DisplayStringOptionsDontOmitDevice  // 0x0
  public    static  UnityEngine.InputSystem.InputBinding.DisplayStringOptionsDontIncludeInteractions  // 0x0
  public    static  UnityEngine.InputSystem.InputBinding.DisplayStringOptionsIgnoreBindingOverrides  // 0x0
METHODS:
END_CLASS

CLASS: MatchOptions
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputBinding.MatchOptionsEmptyGroupMatchesAny  // 0x0
METHODS:
END_CLASS

CLASS: Flags
TYPE:  struct
TOKEN: 0x2000051
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputBinding.FlagsNone  // 0x0
  public    static  UnityEngine.InputSystem.InputBinding.FlagsComposite  // 0x0
  public    static  UnityEngine.InputSystem.InputBinding.FlagsPartOfComposite  // 0x0
METHODS:
END_CLASS

CLASS: PartBinding
TYPE:  struct
TOKEN: 0x2000057
FIELDS:
  private           System.Int32                    <part>k__BackingField  // 0x10
  private           UnityEngine.InputSystem.InputControl<control>k__BackingField  // 0x18
METHODS:
  System.Int32 get_part()
  System.Void set_part(System.Int32 value)
  UnityEngine.InputSystem.InputControl get_control()
  System.Void set_control(UnityEngine.InputSystem.InputControl value)
END_CLASS

CLASS: DefaultComparer`1
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
METHODS:
  System.Int32 Compare(TValue x, TValue y)
END_CLASS

CLASS: Result
TYPE:  struct
TOKEN: 0x200005D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputControlScheme.MatchResult.ResultAllSatisfied  // 0x0
  public    static  UnityEngine.InputSystem.InputControlScheme.MatchResult.ResultMissingRequired  // 0x0
  public    static  UnityEngine.InputSystem.InputControlScheme.MatchResult.ResultMissingOptional  // 0x0
METHODS:
END_CLASS

CLASS: Match
TYPE:  struct
TOKEN: 0x200005E
FIELDS:
  private           System.Int32                    m_RequirementIndex  // 0x10
  private           UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[]m_Requirements  // 0x18
  private           UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl>m_Controls  // 0x20
METHODS:
  UnityEngine.InputSystem.InputControl get_control()
  UnityEngine.InputSystem.InputDevice get_device()
  System.Int32 get_requirementIndex()
  UnityEngine.InputSystem.InputControlScheme.DeviceRequirement get_requirement()
  System.Boolean get_isOptional()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200005F
FIELDS:
  private           System.Int32                    m_Index  // 0x10
  private           UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[]m_Requirements  // 0x18
  private           UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl>m_Controls  // 0x20
METHODS:
  System.Boolean MoveNext()
  System.Void Reset()
  UnityEngine.InputSystem.InputControlScheme.MatchResult.Match get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void Dispose()
END_CLASS

CLASS: MatchResult
TYPE:  struct
TOKEN: 0x200005C
FIELDS:
  private           UnityEngine.InputSystem.InputControlScheme.MatchResult.Resultm_Result  // 0x10
  private           System.Single                   m_Score  // 0x14
  private           UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice>m_Devices  // 0x18
  private           UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl>m_Controls  // 0x38
  private           UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[]m_Requirements  // 0x58
METHODS:
  System.Single get_score()
  System.Boolean get_isSuccessfulMatch()
  System.Boolean get_hasMissingRequiredDevices()
  System.Boolean get_hasMissingOptionalDevices()
  UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> get_devices()
  UnityEngine.InputSystem.InputControlScheme.MatchResult.Match get_Item(System.Int32 index)
  System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlScheme.MatchResult.Match> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void Dispose()
END_CLASS

CLASS: Flags
TYPE:  struct
TOKEN: 0x2000061
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputControlScheme.DeviceRequirement.FlagsNone  // 0x0
  public    static  UnityEngine.InputSystem.InputControlScheme.DeviceRequirement.FlagsOptional  // 0x0
  public    static  UnityEngine.InputSystem.InputControlScheme.DeviceRequirement.FlagsOr  // 0x0
METHODS:
END_CLASS

CLASS: DeviceRequirement
TYPE:  struct
TOKEN: 0x2000060
FIELDS:
  private           System.String                   m_ControlPath  // 0x10
  private           UnityEngine.InputSystem.InputControlScheme.DeviceRequirement.Flagsm_Flags  // 0x18
METHODS:
  System.String get_controlPath()
  System.Void set_controlPath(System.String value)
  System.Boolean get_isOptional()
  System.Void set_isOptional(System.Boolean value)
  System.Boolean get_isAND()
  System.Void set_isAND(System.Boolean value)
  System.Boolean get_isOR()
  System.Void set_isOR(System.Boolean value)
  System.String ToString()
  System.Boolean Equals(UnityEngine.InputSystem.InputControlScheme.DeviceRequirement other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.InputSystem.InputControlScheme.DeviceRequirement left, UnityEngine.InputSystem.InputControlScheme.DeviceRequirement right)
  System.Boolean op_Inequality(UnityEngine.InputSystem.InputControlScheme.DeviceRequirement left, UnityEngine.InputSystem.InputControlScheme.DeviceRequirement right)
END_CLASS

CLASS: DeviceJson
TYPE:  struct
TOKEN: 0x2000063
FIELDS:
  public            System.String                   devicePath  // 0x10
  public            System.Boolean                  isOptional  // 0x18
  public            System.Boolean                  isOR  // 0x19
METHODS:
  UnityEngine.InputSystem.InputControlScheme.DeviceRequirement ToDeviceEntry()
  UnityEngine.InputSystem.InputControlScheme.SchemeJson.DeviceJson From(UnityEngine.InputSystem.InputControlScheme.DeviceRequirement requirement)
END_CLASS

CLASS: SchemeJson
TYPE:  struct
TOKEN: 0x2000062
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   bindingGroup  // 0x18
  public            UnityEngine.InputSystem.InputControlScheme.SchemeJson.DeviceJson[]devices  // 0x20
METHODS:
  UnityEngine.InputSystem.InputControlScheme ToScheme()
  UnityEngine.InputSystem.InputControlScheme.SchemeJson ToJson(UnityEngine.InputSystem.InputControlScheme scheme)
  UnityEngine.InputSystem.InputControlScheme.SchemeJson[] ToJson(UnityEngine.InputSystem.InputControlScheme[] schemes)
  UnityEngine.InputSystem.InputControlScheme[] ToSchemes(UnityEngine.InputSystem.InputControlScheme.SchemeJson[] schemes)
END_CLASS

CLASS: Flags
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputInteractionContext.FlagsTimerHasExpired  // 0x0
METHODS:
END_CLASS

CLASS: StateEventBuffer
TYPE:  struct
TOKEN: 0x2000067
FIELDS:
  public            UnityEngine.InputSystem.LowLevel.StateEventstateEvent  // 0x10
  public    static  System.Int32                    kMaxSize  // 0x0
  public            UnityEngine.InputSystem.InputSystem.StateEventBuffer.<data>e__FixedBufferdata  // 0x29
METHODS:
END_CLASS

CLASS: DeltaStateEventBuffer
TYPE:  struct
TOKEN: 0x2000069
FIELDS:
  public            UnityEngine.InputSystem.LowLevel.DeltaStateEventstateEvent  // 0x10
  public    static  System.Int32                    kMaxSize  // 0x0
  public            UnityEngine.InputSystem.InputSystem.DeltaStateEventBuffer.<data>e__FixedBufferdata  // 0x2D
METHODS:
END_CLASS

CLASS: ControlFlags
TYPE:  struct
TOKEN: 0x200006E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputControl.ControlFlagsConfigUpToDate  // 0x0
  public    static  UnityEngine.InputSystem.InputControl.ControlFlagsIsNoisy  // 0x0
  public    static  UnityEngine.InputSystem.InputControl.ControlFlagsIsSynthetic  // 0x0
  public    static  UnityEngine.InputSystem.InputControl.ControlFlagsIsButton  // 0x0
  public    static  UnityEngine.InputSystem.InputControl.ControlFlagsDontReset  // 0x0
  public    static  UnityEngine.InputSystem.InputControl.ControlFlagsSetupFinished  // 0x0
  public    static  UnityEngine.InputSystem.InputControl.ControlFlagsUsesStateFromOtherControl  // 0x0
METHODS:
END_CLASS

CLASS: Enumerate
TYPE:  struct
TOKEN: 0x2000071
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputControlExtensions.EnumerateIgnoreControlsInDefaultState  // 0x0
  public    static  UnityEngine.InputSystem.InputControlExtensions.EnumerateIgnoreControlsInCurrentState  // 0x0
  public    static  UnityEngine.InputSystem.InputControlExtensions.EnumerateIncludeSyntheticControls  // 0x0
  public    static  UnityEngine.InputSystem.InputControlExtensions.EnumerateIncludeNoisyControls  // 0x0
  public    static  UnityEngine.InputSystem.InputControlExtensions.EnumerateIncludeNonLeafControls  // 0x0
METHODS:
END_CLASS

CLASS: InputEventControlCollection
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  private           UnityEngine.InputSystem.InputDevicem_Device  // 0x10
  private           UnityEngine.InputSystem.LowLevel.InputEventPtrm_EventPtr  // 0x18
  private           UnityEngine.InputSystem.InputControlExtensions.Enumeratem_Flags  // 0x20
  private           System.Single                   m_MagnitudeThreshold  // 0x24
METHODS:
  UnityEngine.InputSystem.LowLevel.InputEventPtr get_eventPtr()
  UnityEngine.InputSystem.InputControlExtensions.InputEventControlEnumerator GetEnumerator()
  System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: InputEventControlEnumerator
TYPE:  struct
TOKEN: 0x2000073
FIELDS:
  private           UnityEngine.InputSystem.InputControlExtensions.Enumeratem_Flags  // 0x10
  private   readonly UnityEngine.InputSystem.InputDevicem_Device  // 0x18
  private   readonly System.UInt32[]                 m_StateOffsetToControlIndex  // 0x20
  private   readonly System.Int32                    m_StateOffsetToControlIndexLength  // 0x28
  private   readonly UnityEngine.InputSystem.InputControl[]m_AllControls  // 0x30
  private           System.Byte*                    m_DefaultState  // 0x38
  private           System.Byte*                    m_CurrentState  // 0x40
  private           System.Byte*                    m_NoiseMask  // 0x48
  private           UnityEngine.InputSystem.LowLevel.InputEventPtrm_EventPtr  // 0x50
  private           UnityEngine.InputSystem.InputControlm_CurrentControl  // 0x58
  private           System.Int32                    m_CurrentIndexInStateOffsetToControlIndexMap  // 0x60
  private           System.UInt32                   m_CurrentControlStateBitOffset  // 0x64
  private           System.Byte*                    m_EventState  // 0x68
  private           System.UInt32                   m_CurrentBitOffset  // 0x70
  private           System.UInt32                   m_EndBitOffset  // 0x74
  private           System.Single                   m_MagnitudeThreshold  // 0x78
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputControlExtensions.Enumerate flags, System.Single magnitudeThreshold)
  System.Boolean CheckDefault(System.UInt32 numBits)
  System.Boolean CheckCurrent(System.UInt32 numBits)
  System.Boolean MoveNext()
  System.Void Reset()
  System.Void Dispose()
  UnityEngine.InputSystem.InputControl get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: ControlBuilder
TYPE:  struct
TOKEN: 0x2000074
FIELDS:
  private           UnityEngine.InputSystem.InputControl<control>k__BackingField  // 0x10
METHODS:
  UnityEngine.InputSystem.InputControl get_control()
  System.Void set_control(UnityEngine.InputSystem.InputControl value)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder At(UnityEngine.InputSystem.InputDevice device, System.Int32 index)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithParent(UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithName(System.String name)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithDisplayName(System.String displayName)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithShortDisplayName(System.String shortDisplayName)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithLayout(UnityEngine.InputSystem.Utilities.InternedString layout)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithUsages(System.Int32 startIndex, System.Int32 count)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithAliases(System.Int32 startIndex, System.Int32 count)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithChildren(System.Int32 startIndex, System.Int32 count)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithStateBlock(UnityEngine.InputSystem.LowLevel.InputStateBlock stateBlock)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithDefaultState(UnityEngine.InputSystem.Utilities.PrimitiveValue value)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithMinAndMax(UnityEngine.InputSystem.Utilities.PrimitiveValue min, UnityEngine.InputSystem.Utilities.PrimitiveValue max)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithProcessor(TProcessor processor)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder IsNoisy(System.Boolean value)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder IsSynthetic(System.Boolean value)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder DontReset(System.Boolean value)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder IsButton(System.Boolean value)
  System.Void Finish()
END_CLASS

CLASS: DeviceBuilder
TYPE:  struct
TOKEN: 0x2000075
FIELDS:
  private           UnityEngine.InputSystem.InputDevice<device>k__BackingField  // 0x10
METHODS:
  UnityEngine.InputSystem.InputDevice get_device()
  System.Void set_device(UnityEngine.InputSystem.InputDevice value)
  UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithName(System.String name)
  UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithDisplayName(System.String displayName)
  UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithShortDisplayName(System.String shortDisplayName)
  UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithLayout(UnityEngine.InputSystem.Utilities.InternedString layout)
  UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithChildren(System.Int32 startIndex, System.Int32 count)
  UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithStateBlock(UnityEngine.InputSystem.LowLevel.InputStateBlock stateBlock)
  UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder IsNoisy(System.Boolean value)
  UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithControlUsage(System.Int32 controlIndex, UnityEngine.InputSystem.Utilities.InternedString usage, UnityEngine.InputSystem.InputControl control)
  UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithControlAlias(System.Int32 controlIndex, UnityEngine.InputSystem.Utilities.InternedString alias)
  UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithStateOffsetToControlIndexMap(System.UInt32[] map)
  UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithControlTree(System.Byte[] controlTreeNodes, System.UInt16[] controlTreeIndicies)
  System.Void Finish()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000079
FIELDS:
  private   readonly System.UInt64*                  m_Indices  // 0x0
  private   readonly System.Int32                    m_Count  // 0x0
  private           System.Int32                    m_Current  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.InputControlList<TControl> list)
  System.Boolean MoveNext()
  System.Void Reset()
  TControl get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void Dispose()
END_CLASS

CLASS: HumanReadableStringOptions
TYPE:  struct
TOKEN: 0x200007B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptionsNone  // 0x0
  public    static  UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptionsOmitDevice  // 0x0
  public    static  UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptionsUseShortNames  // 0x0
METHODS:
END_CLASS

CLASS: PathComponentType
TYPE:  struct
TOKEN: 0x200007C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputControlPath.PathComponentTypeName  // 0x0
  public    static  UnityEngine.InputSystem.InputControlPath.PathComponentTypeDisplayName  // 0x0
  public    static  UnityEngine.InputSystem.InputControlPath.PathComponentTypeUsage  // 0x0
  public    static  UnityEngine.InputSystem.InputControlPath.PathComponentTypeLayout  // 0x0
METHODS:
END_CLASS

CLASS: ParsedPathComponent
TYPE:  struct
TOKEN: 0x200007D
FIELDS:
  private           UnityEngine.InputSystem.Utilities.Substringm_Layout  // 0x10
  private           UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.Substring>m_Usages  // 0x20
  private           UnityEngine.InputSystem.Utilities.Substringm_Name  // 0x40
  private           UnityEngine.InputSystem.Utilities.Substringm_DisplayName  // 0x50
METHODS:
  System.String get_layout()
  System.Collections.Generic.IEnumerable<System.String> get_usages()
  System.String get_name()
  System.String get_displayName()
  System.Boolean get_isWildcard()
  System.Boolean get_isDoubleWildcard()
  System.String ToHumanReadableString(System.String parentLayoutName, System.String parentControlPath, System.String& referencedLayoutName, System.String& controlPath, UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions options)
  System.String ToHumanReadableString(UnityEngine.InputSystem.Utilities.Substring substring)
  System.Boolean Matches(UnityEngine.InputSystem.InputControl control)
  System.Boolean ComparePathElementToString(UnityEngine.InputSystem.Utilities.Substring pathElement, System.String element)
END_CLASS

CLASS: PathParser
TYPE:  struct
TOKEN: 0x200007F
FIELDS:
  private           System.String                   path  // 0x10
  private           System.Int32                    length  // 0x18
  private           System.Int32                    leftIndexInPath  // 0x1C
  private           System.Int32                    rightIndexInPath  // 0x20
  public            UnityEngine.InputSystem.InputControlPath.ParsedPathComponentcurrent  // 0x28
METHODS:
  System.Boolean get_isAtEnd()
  System.Void .ctor(System.String path)
  System.Boolean MoveToNextComponent()
  UnityEngine.InputSystem.Utilities.Substring ParseComponentPart(System.Char terminator)
END_CLASS

CLASS: CachingPolicy
TYPE:  struct
TOKEN: 0x2000083
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputProcessor.CachingPolicyCacheResult  // 0x0
  public    static  UnityEngine.InputSystem.InputProcessor.CachingPolicyEvaluateOnEveryRead  // 0x0
METHODS:
END_CLASS

CLASS: DeviceFlags
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputDevice.DeviceFlagsUpdateBeforeRender  // 0x0
  public    static  UnityEngine.InputSystem.InputDevice.DeviceFlagsHasStateCallbacks  // 0x0
  public    static  UnityEngine.InputSystem.InputDevice.DeviceFlagsHasControlsWithDefaultState  // 0x0
  public    static  UnityEngine.InputSystem.InputDevice.DeviceFlagsHasDontResetControls  // 0x0
  public    static  UnityEngine.InputSystem.InputDevice.DeviceFlagsHasEventMerger  // 0x0
  public    static  UnityEngine.InputSystem.InputDevice.DeviceFlagsHasEventPreProcessor  // 0x0
  public    static  UnityEngine.InputSystem.InputDevice.DeviceFlagsRemote  // 0x0
  public    static  UnityEngine.InputSystem.InputDevice.DeviceFlagsNative  // 0x0
  public    static  UnityEngine.InputSystem.InputDevice.DeviceFlagsDisabledInFrontend  // 0x0
  public    static  UnityEngine.InputSystem.InputDevice.DeviceFlagsDisabledInRuntime  // 0x0
  public    static  UnityEngine.InputSystem.InputDevice.DeviceFlagsDisabledWhileInBackground  // 0x0
  public    static  UnityEngine.InputSystem.InputDevice.DeviceFlagsDisabledStateHasBeenQueriedFromRuntime  // 0x0
  public    static  UnityEngine.InputSystem.InputDevice.DeviceFlagsCanRunInBackground  // 0x0
  public    static  UnityEngine.InputSystem.InputDevice.DeviceFlagsCanRunInBackgroundHasBeenQueried  // 0x0
METHODS:
END_CLASS

CLASS: ControlBitRangeNode
TYPE:  struct
TOKEN: 0x2000088
FIELDS:
  public            System.UInt16                   endBitOffset  // 0x10
  public            System.Int16                    leftChildIndex  // 0x12
  public            System.UInt16                   controlStartIndex  // 0x14
  public            System.Byte                     controlCount  // 0x16
METHODS:
  System.Void .ctor(System.UInt16 endOffset)
END_CLASS

CLASS: MessageType
TYPE:  struct
TOKEN: 0x2000096
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputRemoting.MessageTypeConnect  // 0x0
  public    static  UnityEngine.InputSystem.InputRemoting.MessageTypeDisconnect  // 0x0
  public    static  UnityEngine.InputSystem.InputRemoting.MessageTypeNewLayout  // 0x0
  public    static  UnityEngine.InputSystem.InputRemoting.MessageTypeNewDevice  // 0x0
  public    static  UnityEngine.InputSystem.InputRemoting.MessageTypeNewEvents  // 0x0
  public    static  UnityEngine.InputSystem.InputRemoting.MessageTypeRemoveDevice  // 0x0
  public    static  UnityEngine.InputSystem.InputRemoting.MessageTypeRemoveLayout  // 0x0
  public    static  UnityEngine.InputSystem.InputRemoting.MessageTypeChangeUsages  // 0x0
  public    static  UnityEngine.InputSystem.InputRemoting.MessageTypeStartSending  // 0x0
  public    static  UnityEngine.InputSystem.InputRemoting.MessageTypeStopSending  // 0x0
METHODS:
END_CLASS

CLASS: Message
TYPE:  struct
TOKEN: 0x2000097
FIELDS:
  public            System.Int32                    participantId  // 0x10
  public            UnityEngine.InputSystem.InputRemoting.MessageTypetype  // 0x14
  public            System.Byte[]                   data  // 0x18
METHODS:
END_CLASS

CLASS: Flags
TYPE:  struct
TOKEN: 0x2000098
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputRemoting.FlagsSending  // 0x0
  public    static  UnityEngine.InputSystem.InputRemoting.FlagsStartSendingOnConnect  // 0x0
METHODS:
END_CLASS

CLASS: RemoteSender
TYPE:  struct
TOKEN: 0x2000099
FIELDS:
  public            System.Int32                    senderId  // 0x10
  public            UnityEngine.InputSystem.Utilities.InternedString[]layouts  // 0x18
  public            UnityEngine.InputSystem.InputRemoting.RemoteInputDevice[]devices  // 0x20
METHODS:
END_CLASS

CLASS: RemoteInputDevice
TYPE:  struct
TOKEN: 0x200009A
FIELDS:
  public            System.Int32                    remoteId  // 0x10
  public            System.Int32                    localId  // 0x14
  public            UnityEngine.InputSystem.Layouts.InputDeviceDescriptiondescription  // 0x18
METHODS:
END_CLASS

CLASS: Subscriber
TYPE:  class
TOKEN: 0x200009B
FIELDS:
  public            UnityEngine.InputSystem.InputRemotingowner  // 0x10
  public            System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>observer  // 0x18
METHODS:
  System.Void Dispose()
  System.Void .ctor()
END_CLASS

CLASS: ConnectMsg
TYPE:  class
TOKEN: 0x200009C
FIELDS:
METHODS:
  System.Void Process(UnityEngine.InputSystem.InputRemoting receiver)
END_CLASS

CLASS: StartSendingMsg
TYPE:  class
TOKEN: 0x200009D
FIELDS:
METHODS:
  System.Void Process(UnityEngine.InputSystem.InputRemoting receiver)
END_CLASS

CLASS: StopSendingMsg
TYPE:  class
TOKEN: 0x200009E
FIELDS:
METHODS:
  System.Void Process(UnityEngine.InputSystem.InputRemoting receiver)
END_CLASS

CLASS: DisconnectMsg
TYPE:  class
TOKEN: 0x200009F
FIELDS:
METHODS:
  System.Void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg)
END_CLASS

CLASS: Data
TYPE:  struct
TOKEN: 0x20000A1
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   layoutJson  // 0x18
  public            System.Boolean                  isOverride  // 0x20
METHODS:
END_CLASS

CLASS: NewLayoutMsg
TYPE:  class
TOKEN: 0x20000A0
FIELDS:
METHODS:
  System.Nullable<UnityEngine.InputSystem.InputRemoting.Message> Create(UnityEngine.InputSystem.InputRemoting sender, System.String layoutName)
  System.Void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg)
END_CLASS

CLASS: Data
TYPE:  struct
TOKEN: 0x20000A3
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   layout  // 0x18
  public            System.Int32                    deviceId  // 0x20
  public            System.String[]                 usages  // 0x28
  public            UnityEngine.InputSystem.Layouts.InputDeviceDescriptiondescription  // 0x30
METHODS:
END_CLASS

CLASS: NewDeviceMsg
TYPE:  class
TOKEN: 0x20000A2
FIELDS:
METHODS:
  UnityEngine.InputSystem.InputRemoting.Message Create(UnityEngine.InputSystem.InputDevice device)
  System.Void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg)
END_CLASS

CLASS: NewEventsMsg
TYPE:  class
TOKEN: 0x20000A5
FIELDS:
METHODS:
  UnityEngine.InputSystem.InputRemoting.Message CreateResetEvent(UnityEngine.InputSystem.InputDevice device, System.Boolean isHardReset)
  UnityEngine.InputSystem.InputRemoting.Message CreateStateEvent(UnityEngine.InputSystem.InputDevice device)
  UnityEngine.InputSystem.InputRemoting.Message Create(UnityEngine.InputSystem.LowLevel.InputEvent* events, System.Int32 eventCount)
  System.Void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg)
END_CLASS

CLASS: Data
TYPE:  struct
TOKEN: 0x20000A7
FIELDS:
  public            System.Int32                    deviceId  // 0x10
  public            System.String[]                 usages  // 0x18
METHODS:
END_CLASS

CLASS: ChangeUsageMsg
TYPE:  class
TOKEN: 0x20000A6
FIELDS:
METHODS:
  UnityEngine.InputSystem.InputRemoting.Message Create(UnityEngine.InputSystem.InputDevice device)
  System.Void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg)
END_CLASS

CLASS: RemoveDeviceMsg
TYPE:  class
TOKEN: 0x20000A9
FIELDS:
METHODS:
  UnityEngine.InputSystem.InputRemoting.Message Create(UnityEngine.InputSystem.InputDevice device)
  System.Void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg)
END_CLASS

CLASS: Subscriber
TYPE:  class
TOKEN: 0x20000AB
FIELDS:
  public            UnityEngine.InputSystem.RemoteInputPlayerConnectionowner  // 0x10
  public            System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>observer  // 0x18
METHODS:
  System.Void Dispose()
  System.Void .ctor()
END_CLASS

CLASS: DeviceDisableScope
TYPE:  struct
TOKEN: 0x20000C0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputManager.DeviceDisableScopeEverywhere  // 0x0
  public    static  UnityEngine.InputSystem.InputManager.DeviceDisableScopeInFrontendOnly  // 0x0
  public    static  UnityEngine.InputSystem.InputManager.DeviceDisableScopeTemporaryWhilePlayerIsInBackground  // 0x0
METHODS:
END_CLASS

CLASS: AvailableDevice
TYPE:  struct
TOKEN: 0x20000C1
FIELDS:
  public            UnityEngine.InputSystem.Layouts.InputDeviceDescriptiondescription  // 0x10
  public            System.Int32                    deviceId  // 0x48
  public            System.Boolean                  isNative  // 0x4C
  public            System.Boolean                  isRemoved  // 0x4D
METHODS:
END_CLASS

CLASS: StateChangeMonitorTimeout
TYPE:  struct
TOKEN: 0x20000C2
FIELDS:
  public            UnityEngine.InputSystem.InputControlcontrol  // 0x10
  public            System.Double                   time  // 0x18
  public            UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitormonitor  // 0x20
  public            System.Int64                    monitorIndex  // 0x28
  public            System.Int32                    timerIndex  // 0x30
METHODS:
END_CLASS

CLASS: StateChangeMonitorListener
TYPE:  struct
TOKEN: 0x20000C3
FIELDS:
  public            UnityEngine.InputSystem.InputControlcontrol  // 0x10
  public            UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitormonitor  // 0x18
  public            System.Int64                    monitorIndex  // 0x20
  public            System.UInt32                   groupIndex  // 0x28
METHODS:
END_CLASS

CLASS: StateChangeMonitorsForDevice
TYPE:  struct
TOKEN: 0x20000C4
FIELDS:
  public            UnityEngine.InputSystem.Utilities.MemoryHelpers.BitRegion[]memoryRegions  // 0x10
  public            UnityEngine.InputSystem.InputManager.StateChangeMonitorListener[]listeners  // 0x18
  public            UnityEngine.InputSystem.DynamicBitfieldsignalled  // 0x20
  public            System.Boolean                  needToUpdateOrderingOfMonitors  // 0x40
  public            System.Boolean                  needToCompactArrays  // 0x41
METHODS:
  System.Int32 get_count()
  System.Void Add(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Int64 monitorIndex, System.UInt32 groupIndex)
  System.Void Remove(UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Int64 monitorIndex, System.Boolean deferRemoval)
  System.Void Clear()
  System.Void CompactArrays()
  System.Void RemoveAt(System.Int32 i)
  System.Void SortMonitorsByIndex()
END_CLASS

CLASS: UpdateMode
TYPE:  struct
TOKEN: 0x20000C9
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputSettings.UpdateModeProcessEventsInDynamicUpdate  // 0x0
  public    static  UnityEngine.InputSystem.InputSettings.UpdateModeProcessEventsInFixedUpdate  // 0x0
  public    static  UnityEngine.InputSystem.InputSettings.UpdateModeProcessEventsManually  // 0x0
METHODS:
END_CLASS

CLASS: ScrollDeltaBehavior
TYPE:  struct
TOKEN: 0x20000CA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputSettings.ScrollDeltaBehaviorUniformAcrossAllPlatforms  // 0x0
  public    static  UnityEngine.InputSystem.InputSettings.ScrollDeltaBehaviorKeepPlatformSpecificInputRange  // 0x0
METHODS:
END_CLASS

CLASS: BackgroundBehavior
TYPE:  struct
TOKEN: 0x20000CB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputSettings.BackgroundBehaviorResetAndDisableNonBackgroundDevices  // 0x0
  public    static  UnityEngine.InputSystem.InputSettings.BackgroundBehaviorResetAndDisableAllDevices  // 0x0
  public    static  UnityEngine.InputSystem.InputSettings.BackgroundBehaviorIgnoreFocus  // 0x0
METHODS:
END_CLASS

CLASS: EditorInputBehaviorInPlayMode
TYPE:  struct
TOKEN: 0x20000CC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayModePointersAndKeyboardsRespectGameViewFocus  // 0x0
  public    static  UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayModeAllDevicesRespectGameViewFocus  // 0x0
  public    static  UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayModeAllDeviceInputAlwaysGoesToGameView  // 0x0
METHODS:
END_CLASS

CLASS: InputActionPropertyDrawerMode
TYPE:  struct
TOKEN: 0x20000CD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerModeCompact  // 0x0
  public    static  UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerModeMultilineEffective  // 0x0
  public    static  UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerModeMultilineBoth  // 0x0
METHODS:
END_CLASS

CLASS: PlayerActions
TYPE:  struct
TOKEN: 0x20000CF
FIELDS:
  private           UnityEngine.InputSystem.DefaultInputActionsm_Wrapper  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.DefaultInputActions wrapper)
  UnityEngine.InputSystem.InputAction get_Move()
  UnityEngine.InputSystem.InputAction get_Look()
  UnityEngine.InputSystem.InputAction get_Fire()
  UnityEngine.InputSystem.InputActionMap Get()
  System.Void Enable()
  System.Void Disable()
  System.Boolean get_enabled()
  UnityEngine.InputSystem.InputActionMap op_Implicit(UnityEngine.InputSystem.DefaultInputActions.PlayerActions set)
  System.Void SetCallbacks(UnityEngine.InputSystem.DefaultInputActions.IPlayerActions instance)
END_CLASS

CLASS: UIActions
TYPE:  struct
TOKEN: 0x20000D0
FIELDS:
  private           UnityEngine.InputSystem.DefaultInputActionsm_Wrapper  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.DefaultInputActions wrapper)
  UnityEngine.InputSystem.InputAction get_Navigate()
  UnityEngine.InputSystem.InputAction get_Submit()
  UnityEngine.InputSystem.InputAction get_Cancel()
  UnityEngine.InputSystem.InputAction get_Point()
  UnityEngine.InputSystem.InputAction get_Click()
  UnityEngine.InputSystem.InputAction get_ScrollWheel()
  UnityEngine.InputSystem.InputAction get_MiddleClick()
  UnityEngine.InputSystem.InputAction get_RightClick()
  UnityEngine.InputSystem.InputAction get_TrackedDevicePosition()
  UnityEngine.InputSystem.InputAction get_TrackedDeviceOrientation()
  UnityEngine.InputSystem.InputActionMap Get()
  System.Void Enable()
  System.Void Disable()
  System.Boolean get_enabled()
  UnityEngine.InputSystem.InputActionMap op_Implicit(UnityEngine.InputSystem.DefaultInputActions.UIActions set)
  System.Void SetCallbacks(UnityEngine.InputSystem.DefaultInputActions.IUIActions instance)
END_CLASS

CLASS: IPlayerActions
TYPE:  interface
TOKEN: 0x20000D1
FIELDS:
METHODS:
  System.Void OnMove(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnLook(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnFire(UnityEngine.InputSystem.InputAction.CallbackContext context)
END_CLASS

CLASS: IUIActions
TYPE:  interface
TOKEN: 0x20000D2
FIELDS:
METHODS:
  System.Void OnNavigate(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnSubmit(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnCancel(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnPoint(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnClick(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnScrollWheel(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnMiddleClick(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnRightClick(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnTrackedDevicePosition(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnTrackedDeviceOrientation(UnityEngine.InputSystem.InputAction.CallbackContext context)
END_CLASS

CLASS: ActionEvent
TYPE:  class
TOKEN: 0x20000D5
EXTENDS: UnityEvent`1
FIELDS:
  private           System.String                   m_ActionId  // 0x30
  private           System.String                   m_ActionName  // 0x38
METHODS:
  System.String get_actionId()
  System.String get_actionName()
  System.Void .ctor()
  System.Void .ctor(UnityEngine.InputSystem.InputAction action)
  System.Void .ctor(System.Guid actionGUID, System.String name)
END_CLASS

CLASS: DeviceLostEvent
TYPE:  class
TOKEN: 0x20000D6
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: DeviceRegainedEvent
TYPE:  class
TOKEN: 0x20000D7
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ControlsChangedEvent
TYPE:  class
TOKEN: 0x20000D8
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: PlayerJoinedEvent
TYPE:  class
TOKEN: 0x20000DA
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: PlayerLeftEvent
TYPE:  class
TOKEN: 0x20000DB
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: TrackingType
TYPE:  struct
TOKEN: 0x20000E5
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingTypeRotationAndPosition  // 0x0
  public    static  UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingTypeRotationOnly  // 0x0
  public    static  UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingTypePositionOnly  // 0x0
METHODS:
END_CLASS

CLASS: TrackingStates
TYPE:  struct
TOKEN: 0x20000E6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingStatesNone  // 0x0
  public    static  UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingStatesPosition  // 0x0
  public    static  UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingStatesRotation  // 0x0
METHODS:
END_CLASS

CLASS: UpdateType
TYPE:  struct
TOKEN: 0x20000E7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateTypeUpdateAndBeforeRender  // 0x0
  public    static  UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateTypeUpdate  // 0x0
  public    static  UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateTypeBeforeRender  // 0x0
METHODS:
END_CLASS

CLASS: DeviceType
TYPE:  struct
TOKEN: 0x20000FE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceTypeGamepad  // 0x0
METHODS:
END_CLASS

CLASS: DeviceSubType
TYPE:  struct
TOKEN: 0x20000FF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceSubTypeUnknown  // 0x0
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceSubTypeGamepad  // 0x0
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceSubTypeWheel  // 0x0
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceSubTypeArcadeStick  // 0x0
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceSubTypeFlightStick  // 0x0
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceSubTypeDancePad  // 0x0
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceSubTypeGuitar  // 0x0
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceSubTypeGuitarAlternate  // 0x0
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceSubTypeDrumKit  // 0x0
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceSubTypeGuitarBass  // 0x0
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceSubTypeArcadePad  // 0x0
METHODS:
END_CLASS

CLASS: DeviceFlags
TYPE:  struct
TOKEN: 0x2000100
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceFlagsForceFeedbackSupported  // 0x0
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceFlagsWireless  // 0x0
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceFlagsVoiceSupported  // 0x0
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceFlagsPluginModulesSupported  // 0x0
  public    static  UnityEngine.InputSystem.XInput.XInputController.DeviceFlagsNoNavigation  // 0x0
METHODS:
END_CLASS

CLASS: Capabilities
TYPE:  struct
TOKEN: 0x2000101
FIELDS:
  public            UnityEngine.InputSystem.XInput.XInputController.DeviceTypetype  // 0x10
  public            UnityEngine.InputSystem.XInput.XInputController.DeviceSubTypesubType  // 0x14
  public            UnityEngine.InputSystem.XInput.XInputController.DeviceFlagsflags  // 0x18
METHODS:
END_CLASS

CLASS: Button
TYPE:  struct
TOKEN: 0x2000105
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.ButtonDPadUp  // 0x0
  public    static  UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.ButtonDPadDown  // 0x0
  public    static  UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.ButtonDPadLeft  // 0x0
  public    static  UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.ButtonDPadRight  // 0x0
  public    static  UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.ButtonStart  // 0x0
  public    static  UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.ButtonSelect  // 0x0
  public    static  UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.ButtonLeftThumbstickPress  // 0x0
  public    static  UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.ButtonRightThumbstickPress  // 0x0
  public    static  UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.ButtonLeftShoulder  // 0x0
  public    static  UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.ButtonRightShoulder  // 0x0
  public    static  UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.ButtonA  // 0x0
  public    static  UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.ButtonB  // 0x0
  public    static  UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.ButtonX  // 0x0
  public    static  UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.ButtonY  // 0x0
METHODS:
END_CLASS

CLASS: ControlSchemeChangeSyntax
TYPE:  struct
TOKEN: 0x2000107
FIELDS:
  private           System.Int32                    m_UserIndex  // 0x10
METHODS:
  UnityEngine.InputSystem.Users.InputUser.ControlSchemeChangeSyntax AndPairRemainingDevices()
END_CLASS

CLASS: UserFlags
TYPE:  struct
TOKEN: 0x2000108
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Users.InputUser.UserFlagsBindToAllDevices  // 0x0
  public    static  UnityEngine.InputSystem.Users.InputUser.UserFlagsUserAccountSelectionInProgress  // 0x0
METHODS:
END_CLASS

CLASS: UserData
TYPE:  struct
TOKEN: 0x2000109
FIELDS:
  public            System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle>platformUserAccountHandle  // 0x10
  public            System.String                   platformUserAccountName  // 0x28
  public            System.String                   platformUserAccountId  // 0x30
  public            System.Int32                    deviceCount  // 0x38
  public            System.Int32                    deviceStartIndex  // 0x3C
  public            UnityEngine.InputSystem.IInputActionCollectionactions  // 0x40
  public            System.Nullable<UnityEngine.InputSystem.InputControlScheme>controlScheme  // 0x48
  public            UnityEngine.InputSystem.InputControlScheme.MatchResultcontrolSchemeMatch  // 0x68
  public            System.Int32                    lostDeviceCount  // 0xB8
  public            System.Int32                    lostDeviceStartIndex  // 0xBC
  public            UnityEngine.InputSystem.Users.InputUser.UserFlagsflags  // 0xC0
METHODS:
END_CLASS

CLASS: CompareDevicesByUserAccount
TYPE:  struct
TOKEN: 0x200010A
FIELDS:
  public            UnityEngine.InputSystem.Users.InputUserAccountHandleplatformUserAccountHandle  // 0x10
METHODS:
  System.Int32 Compare(UnityEngine.InputSystem.InputDevice x, UnityEngine.InputSystem.InputDevice y)
  System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> GetUserAccountHandleForDevice(UnityEngine.InputSystem.InputDevice device)
END_CLASS

CLASS: OngoingAccountSelection
TYPE:  struct
TOKEN: 0x200010B
FIELDS:
  public            UnityEngine.InputSystem.InputDevicedevice  // 0x10
  public            System.UInt32                   userId  // 0x18
METHODS:
END_CLASS

CLASS: GlobalState
TYPE:  struct
TOKEN: 0x200010C
FIELDS:
  private           System.Int32                    pairingStateVersion  // 0x10
  private           System.UInt32                   lastUserId  // 0x14
  private           System.Int32                    allUserCount  // 0x18
  private           System.Int32                    allPairedDeviceCount  // 0x1C
  private           System.Int32                    allLostDeviceCount  // 0x20
  private           UnityEngine.InputSystem.Users.InputUser[]allUsers  // 0x28
  private           UnityEngine.InputSystem.Users.InputUser.UserData[]allUserData  // 0x30
  private           UnityEngine.InputSystem.InputDevice[]allPairedDevices  // 0x38
  private           UnityEngine.InputSystem.InputDevice[]allLostDevices  // 0x40
  private           UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Users.InputUser.OngoingAccountSelection>ongoingAccountSelections  // 0x48
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice>>onChange  // 0x68
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr>>onUnpairedDeviceUsed  // 0xB8
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean>>onPreFilterUnpairedDeviceUsed  // 0x108
  private           System.Action<System.Object,UnityEngine.InputSystem.InputActionChange>actionChangeDelegate  // 0x158
  private           System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange>onDeviceChangeDelegate  // 0x160
  private           System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice>onEventDelegate  // 0x168
  private           System.Boolean                  onActionChangeHooked  // 0x170
  private           System.Boolean                  onDeviceChangeHooked  // 0x171
  private           System.Boolean                  onEventHooked  // 0x172
  private           System.Int32                    listenForUnpairedDeviceActivity  // 0x174
METHODS:
END_CLASS

CLASS: InputActionReferenceState
TYPE:  struct
TOKEN: 0x200011A
FIELDS:
  public            System.Int32                    refCount  // 0x10
  public            System.Boolean                  enabledByInputModule  // 0x14
METHODS:
END_CLASS

CLASS: CursorLockBehavior
TYPE:  struct
TOKEN: 0x200011B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehaviorOutsideScreen  // 0x0
  public    static  UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehaviorScreenCenter  // 0x0
METHODS:
END_CLASS

CLASS: ButtonState
TYPE:  struct
TOKEN: 0x2000120
FIELDS:
  private           System.Boolean                  m_IsPressed  // 0x10
  private           UnityEngine.EventSystems.PointerEventData.FramePressStatem_FramePressState  // 0x14
  private           System.Single                   m_PressTime  // 0x18
  private           UnityEngine.EventSystems.RaycastResultm_PressRaycast  // 0x20
  private           UnityEngine.GameObject          m_PressObject  // 0x68
  private           UnityEngine.GameObject          m_RawPressObject  // 0x70
  private           UnityEngine.GameObject          m_LastPressObject  // 0x78
  private           UnityEngine.GameObject          m_DragObject  // 0x80
  private           UnityEngine.Vector2             m_PressPosition  // 0x88
  private           System.Single                   m_ClickTime  // 0x90
  private           System.Int32                    m_ClickCount  // 0x94
  private           System.Boolean                  m_Dragging  // 0x98
  private           System.Boolean                  m_ClickedOnSameGameObject  // 0x99
  private           System.Boolean                  m_IgnoreNextClick  // 0x9A
METHODS:
  System.Boolean get_isPressed()
  System.Void set_isPressed(System.Boolean value)
  System.Boolean get_ignoreNextClick()
  System.Void set_ignoreNextClick(System.Boolean value)
  System.Single get_pressTime()
  System.Void set_pressTime(System.Single value)
  System.Boolean get_clickedOnSameGameObject()
  System.Void set_clickedOnSameGameObject(System.Boolean value)
  System.Boolean get_wasPressedThisFrame()
  System.Boolean get_wasReleasedThisFrame()
  System.Void CopyPressStateTo(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void CopyPressStateFrom(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnEndFrame()
END_CLASS

CLASS: RaycastHitData
TYPE:  struct
TOKEN: 0x2000122
FIELDS:
  private   readonly UnityEngine.UI.Graphic          <graphic>k__BackingField  // 0x10
  private   readonly UnityEngine.Vector3             <worldHitPosition>k__BackingField  // 0x18
  private   readonly UnityEngine.Vector2             <screenPosition>k__BackingField  // 0x24
  private   readonly System.Single                   <distance>k__BackingField  // 0x2C
METHODS:
  System.Void .ctor(UnityEngine.UI.Graphic graphic, UnityEngine.Vector3 worldHitPosition, UnityEngine.Vector2 screenPosition, System.Single distance)
  UnityEngine.UI.Graphic get_graphic()
  UnityEngine.Vector3 get_worldHitPosition()
  UnityEngine.Vector2 get_screenPosition()
  System.Single get_distance()
END_CLASS

CLASS: CursorMode
TYPE:  struct
TOKEN: 0x2000125
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.UI.VirtualMouseInput.CursorModeSoftwareCursor  // 0x0
  public    static  UnityEngine.InputSystem.UI.VirtualMouseInput.CursorModeHardwareCursorIfAvailable  // 0x0
METHODS:
END_CLASS

CLASS: SwitchInputOnlyReport
TYPE:  struct
TOKEN: 0x2000127
FIELDS:
  public    static  System.Int32                    kSize  // 0x0
  public            System.Byte                     buttons0  // 0x10
  public            System.Byte                     buttons1  // 0x11
  public            System.Byte                     hat  // 0x12
  public            System.Byte                     leftX  // 0x13
  public            System.Byte                     leftY  // 0x14
  public            System.Byte                     rightX  // 0x15
  public            System.Byte                     rightY  // 0x16
METHODS:
  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState ToHIDInputReport()
END_CLASS

CLASS: SwitchSimpleInputReport
TYPE:  struct
TOKEN: 0x2000128
FIELDS:
  public    static  System.Int32                    kSize  // 0x0
  public    static  System.Byte                     ExpectedReportId  // 0x0
  public            System.Byte                     reportId  // 0x10
  public            System.Byte                     buttons0  // 0x11
  public            System.Byte                     buttons1  // 0x12
  public            System.Byte                     hat  // 0x13
  public            System.UInt16                   leftX  // 0x14
  public            System.UInt16                   leftY  // 0x16
  public            System.UInt16                   rightX  // 0x18
  public            System.UInt16                   rightY  // 0x1A
METHODS:
  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState ToHIDInputReport()
END_CLASS

CLASS: SwitchFullInputReport
TYPE:  struct
TOKEN: 0x2000129
FIELDS:
  public    static  System.Int32                    kSize  // 0x0
  public    static  System.Byte                     ExpectedReportId  // 0x0
  public            System.Byte                     reportId  // 0x10
  public            System.Byte                     buttons0  // 0x13
  public            System.Byte                     buttons1  // 0x14
  public            System.Byte                     buttons2  // 0x15
  public            System.Byte                     left0  // 0x16
  public            System.Byte                     left1  // 0x17
  public            System.Byte                     left2  // 0x18
  public            System.Byte                     right0  // 0x19
  public            System.Byte                     right1  // 0x1A
  public            System.Byte                     right2  // 0x1B
METHODS:
  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState ToHIDInputReport()
END_CLASS

CLASS: SwitchHIDGenericInputReport
TYPE:  struct
TOKEN: 0x200012A
FIELDS:
  public            System.Byte                     reportId  // 0x10
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Format()
END_CLASS

CLASS: ReportType
TYPE:  struct
TOKEN: 0x200012C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport.ReportTypeMagic  // 0x0
METHODS:
END_CLASS

CLASS: CommandIdType
TYPE:  struct
TOKEN: 0x200012D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport.CommandIdTypeStatus  // 0x0
  public    static  UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport.CommandIdTypeHandshake  // 0x0
  public    static  UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport.CommandIdTypeHighspeed  // 0x0
  public    static  UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport.CommandIdTypeForceUSB  // 0x0
METHODS:
END_CLASS

CLASS: SwitchMagicOutputReport
TYPE:  struct
TOKEN: 0x200012B
FIELDS:
  public    static  System.Int32                    kSize  // 0x0
  public    static  System.Byte                     ExpectedReplyInputReportId  // 0x0
  public            System.Byte                     reportType  // 0x10
  public            System.Byte                     commandId  // 0x11
METHODS:
END_CLASS

CLASS: SwitchMagicOutputHIDBluetooth
TYPE:  struct
TOKEN: 0x200012E
FIELDS:
  public    static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReportreport  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputHIDBluetooth Create(UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport.CommandIdType type)
END_CLASS

CLASS: SwitchMagicOutputHIDUSB
TYPE:  struct
TOKEN: 0x200012F
FIELDS:
  public    static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReportreport  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputHIDUSB Create(UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport.CommandIdType type)
END_CLASS

CLASS: Button
TYPE:  struct
TOKEN: 0x2000132
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonUp  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonRight  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonDown  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonLeft  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonWest  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonNorth  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonSouth  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonEast  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonL  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonR  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonStickL  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonStickR  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonZL  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonZR  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonPlus  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonMinus  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonCapture  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonHome  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonX  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonB  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonY  // 0x0
  public    static  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.ButtonA  // 0x0
METHODS:
END_CLASS

CLASS: OnScreenDeviceInfo
TYPE:  struct
TOKEN: 0x2000135
FIELDS:
  public            UnityEngine.InputSystem.LowLevel.InputEventPtreventPtr  // 0x10
  public            Unity.Collections.NativeArray<System.Byte>buffer  // 0x18
  public            UnityEngine.InputSystem.InputDevicedevice  // 0x28
  public            UnityEngine.InputSystem.OnScreen.OnScreenControlfirstControl  // 0x30
METHODS:
  UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo AddControl(UnityEngine.InputSystem.OnScreen.OnScreenControl control)
  UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo RemoveControl(UnityEngine.InputSystem.OnScreen.OnScreenControl control)
  System.Void Destroy()
END_CLASS

CLASS: Behaviour
TYPE:  struct
TOKEN: 0x2000138
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.OnScreen.OnScreenStick.BehaviourRelativePositionWithStaticOrigin  // 0x0
  public    static  UnityEngine.InputSystem.OnScreen.OnScreenStick.BehaviourExactPositionWithStaticOrigin  // 0x0
  public    static  UnityEngine.InputSystem.OnScreen.OnScreenStick.BehaviourExactPositionWithDynamicOrigin  // 0x0
METHODS:
END_CLASS

CLASS: HIDLayoutBuilder
TYPE:  class
TOKEN: 0x200013A
FIELDS:
  public            System.String                   displayName  // 0x10
  public            UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorhidDescriptor  // 0x18
  public            System.String                   parentLayout  // 0x48
  public            System.Type                     deviceType  // 0x50
METHODS:
  UnityEngine.InputSystem.Layouts.InputControlLayout Build()
  System.Void .ctor()
END_CLASS

CLASS: HIDReportType
TYPE:  struct
TOKEN: 0x200013C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.HID.HID.HIDReportTypeUnknown  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDReportTypeInput  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDReportTypeOutput  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDReportTypeFeature  // 0x0
METHODS:
END_CLASS

CLASS: HIDCollectionType
TYPE:  struct
TOKEN: 0x200013D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.HID.HID.HIDCollectionTypePhysical  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDCollectionTypeApplication  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDCollectionTypeLogical  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDCollectionTypeReport  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDCollectionTypeNamedArray  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDCollectionTypeUsageSwitch  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDCollectionTypeUsageModifier  // 0x0
METHODS:
END_CLASS

CLASS: HIDElementFlags
TYPE:  struct
TOKEN: 0x200013E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.HID.HID.HIDElementFlagsConstant  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDElementFlagsVariable  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDElementFlagsRelative  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDElementFlagsWrap  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDElementFlagsNonLinear  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDElementFlagsNoPreferred  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDElementFlagsNullState  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDElementFlagsVolatile  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.HIDElementFlagsBufferedBytes  // 0x0
METHODS:
END_CLASS

CLASS: HIDElementDescriptor
TYPE:  struct
TOKEN: 0x200013F
FIELDS:
  public            System.Int32                    usage  // 0x10
  public            UnityEngine.InputSystem.HID.HID.UsagePageusagePage  // 0x14
  public            System.Int32                    unit  // 0x18
  public            System.Int32                    unitExponent  // 0x1C
  public            System.Int32                    logicalMin  // 0x20
  public            System.Int32                    logicalMax  // 0x24
  public            System.Int32                    physicalMin  // 0x28
  public            System.Int32                    physicalMax  // 0x2C
  public            UnityEngine.InputSystem.HID.HID.HIDReportTypereportType  // 0x30
  public            System.Int32                    collectionIndex  // 0x34
  public            System.Int32                    reportId  // 0x38
  public            System.Int32                    reportSizeInBits  // 0x3C
  public            System.Int32                    reportOffsetInBits  // 0x40
  public            UnityEngine.InputSystem.HID.HID.HIDElementFlagsflags  // 0x44
  public            System.Nullable<System.Int32>   usageMin  // 0x48
  public            System.Nullable<System.Int32>   usageMax  // 0x50
METHODS:
  System.Boolean get_hasNullState()
  System.Boolean get_hasPreferredState()
  System.Boolean get_isArray()
  System.Boolean get_isNonLinear()
  System.Boolean get_isRelative()
  System.Boolean get_isConstant()
  System.Boolean get_isWrapping()
  System.Boolean get_isSigned()
  System.Single get_minFloatValue()
  System.Single get_maxFloatValue()
  System.Boolean Is(UnityEngine.InputSystem.HID.HID.UsagePage usagePage, System.Int32 usage)
  System.String DetermineName()
  System.String DetermineDisplayName()
  System.Boolean IsUsableElement()
  System.String DetermineLayout()
  UnityEngine.InputSystem.Utilities.FourCC DetermineFormat()
  UnityEngine.InputSystem.Utilities.InternedString[] DetermineUsages()
  System.String DetermineParameters()
  System.String DetermineAxisNormalizationParameters()
  System.String DetermineProcessors()
  UnityEngine.InputSystem.Utilities.PrimitiveValue DetermineDefaultState()
  System.Void AddChildControls(UnityEngine.InputSystem.HID.HID.HIDElementDescriptor& element, System.String controlName, UnityEngine.InputSystem.Layouts.InputControlLayout.Builder& builder)
END_CLASS

CLASS: HIDCollectionDescriptor
TYPE:  struct
TOKEN: 0x2000140
FIELDS:
  public            UnityEngine.InputSystem.HID.HID.HIDCollectionTypetype  // 0x10
  public            System.Int32                    usage  // 0x14
  public            UnityEngine.InputSystem.HID.HID.UsagePageusagePage  // 0x18
  public            System.Int32                    parent  // 0x1C
  public            System.Int32                    childCount  // 0x20
  public            System.Int32                    firstChild  // 0x24
METHODS:
END_CLASS

CLASS: HIDDeviceDescriptor
TYPE:  struct
TOKEN: 0x2000141
FIELDS:
  public            System.Int32                    vendorId  // 0x10
  public            System.Int32                    productId  // 0x14
  public            System.Int32                    usage  // 0x18
  public            UnityEngine.InputSystem.HID.HID.UsagePageusagePage  // 0x1C
  public            System.Int32                    inputReportSize  // 0x20
  public            System.Int32                    outputReportSize  // 0x24
  public            System.Int32                    featureReportSize  // 0x28
  public            UnityEngine.InputSystem.HID.HID.HIDElementDescriptor[]elements  // 0x30
  public            UnityEngine.InputSystem.HID.HID.HIDCollectionDescriptor[]collections  // 0x38
METHODS:
  System.String ToJson()
  UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor FromJson(System.String json)
END_CLASS

CLASS: HIDDeviceDescriptorBuilder
TYPE:  struct
TOKEN: 0x2000142
FIELDS:
  public            UnityEngine.InputSystem.HID.HID.UsagePageusagePage  // 0x10
  public            System.Int32                    usage  // 0x14
  private           System.Int32                    m_CurrentReportId  // 0x18
  private           UnityEngine.InputSystem.HID.HID.HIDReportTypem_CurrentReportType  // 0x1C
  private           System.Int32                    m_CurrentReportOffsetInBits  // 0x20
  private           System.Collections.Generic.List<UnityEngine.InputSystem.HID.HID.HIDElementDescriptor>m_Elements  // 0x28
  private           System.Collections.Generic.List<UnityEngine.InputSystem.HID.HID.HIDCollectionDescriptor>m_Collections  // 0x30
  private           System.Int32                    m_InputReportSize  // 0x38
  private           System.Int32                    m_OutputReportSize  // 0x3C
  private           System.Int32                    m_FeatureReportSize  // 0x40
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.HID.HID.UsagePage usagePage, System.Int32 usage)
  System.Void .ctor(UnityEngine.InputSystem.HID.HID.GenericDesktop usage)
  UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder StartReport(UnityEngine.InputSystem.HID.HID.HIDReportType reportType, System.Int32 reportId)
  UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder AddElement(UnityEngine.InputSystem.HID.HID.UsagePage usagePage, System.Int32 usage, System.Int32 sizeInBits)
  UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder AddElement(UnityEngine.InputSystem.HID.HID.GenericDesktop usage, System.Int32 sizeInBits)
  UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder WithPhysicalMinMax(System.Int32 min, System.Int32 max)
  UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder WithLogicalMinMax(System.Int32 min, System.Int32 max)
  UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor Finish()
END_CLASS

CLASS: UsagePage
TYPE:  struct
TOKEN: 0x2000143
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageUndefined  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageGenericDesktop  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageSimulation  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageVRControls  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageSportControls  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageGameControls  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageGenericDeviceControls  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageKeyboard  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageLEDs  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageButton  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageOrdinal  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageTelephony  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageConsumer  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageDigitizer  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePagePID  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageUnicode  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageAlphanumericDisplay  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageMedicalInstruments  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageMonitor  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePagePower  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageBarCodeScanner  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageMagneticStripeReader  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageCamera  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageArcade  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.UsagePageVendorDefined  // 0x0
METHODS:
END_CLASS

CLASS: GenericDesktop
TYPE:  struct
TOKEN: 0x2000144
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopUndefined  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopPointer  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopMouse  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopJoystick  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopGamepad  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopKeyboard  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopKeypad  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopMultiAxisController  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopTabletPCControls  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopAssistiveControl  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopX  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopY  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopZ  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopRx  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopRy  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopRz  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSlider  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopDial  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopWheel  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopHatSwitch  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopCountedBuffer  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopByteCount  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopMotionWakeup  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopStart  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSelect  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopVx  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopVy  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopVz  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopVbrx  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopVbry  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopVbrz  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopVno  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopFeatureNotification  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopResolutionMultiplier  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemControl  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemPowerDown  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemSleep  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemWakeUp  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemContextMenu  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemMainMenu  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemAppMenu  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemMenuHelp  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemMenuExit  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemMenuSelect  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemMenuRight  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemMenuLeft  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemMenuUp  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemMenuDown  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemColdRestart  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemWarmRestart  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopDpadUp  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopDpadDown  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopDpadRight  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopDpadLeft  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemDock  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemUndock  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemSetup  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemBreak  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemDebuggerBreak  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopApplicationBreak  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopApplicationDebuggerBreak  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemSpeakerMute  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemHibernate  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemDisplayInvert  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemDisplayInternal  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemDisplayExternal  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemDisplayBoth  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemDisplayDual  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemDisplayToggleIntExt  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemDisplaySwapPrimarySecondary  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.GenericDesktopSystemDisplayLCDAutoScale  // 0x0
METHODS:
END_CLASS

CLASS: Simulation
TYPE:  struct
TOKEN: 0x2000145
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.HID.HID.SimulationUndefined  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationFlightSimulationDevice  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationAutomobileSimulationDevice  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationTankSimulationDevice  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationSpaceshipSimulationDevice  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationSubmarineSimulationDevice  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationSailingSimulationDevice  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationMotorcycleSimulationDevice  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationSportsSimulationDevice  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationAirplaneSimulationDevice  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationHelicopterSimulationDevice  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationMagicCarpetSimulationDevice  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationBicylcleSimulationDevice  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationFlightControlStick  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationFlightStick  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationCyclicControl  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationCyclicTrim  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationFlightYoke  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationTrackControl  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationAileron  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationAileronTrim  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationAntiTorqueControl  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationAutopilotEnable  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationChaffRelease  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationCollectiveControl  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationDiveBreak  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationElectronicCountermeasures  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationElevator  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationElevatorTrim  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationRudder  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationThrottle  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationFlightCommunications  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationFlareRelease  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationLandingGear  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationToeBreak  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationTrigger  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationWeaponsArm  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationWeaponsSelect  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationWingFlaps  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationAccelerator  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationBrake  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationClutch  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationShifter  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationSteering  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationTurretDirection  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationBarrelElevation  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationDivePlane  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationBallast  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationBicycleCrank  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationHandleBars  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationFrontBrake  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.SimulationRearBrake  // 0x0
METHODS:
END_CLASS

CLASS: Button
TYPE:  struct
TOKEN: 0x2000146
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.HID.HID.ButtonUndefined  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.ButtonPrimary  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.ButtonSecondary  // 0x0
  public    static  UnityEngine.InputSystem.HID.HID.ButtonTertiary  // 0x0
METHODS:
END_CLASS

CLASS: HIDReportData
TYPE:  struct
TOKEN: 0x2000149
FIELDS:
  public            System.Int32                    reportId  // 0x10
  public            UnityEngine.InputSystem.HID.HID.HIDReportTypereportType  // 0x14
  public            System.Int32                    currentBitOffset  // 0x18
METHODS:
  System.Int32 FindOrAddReport(System.Nullable<System.Int32> reportId, UnityEngine.InputSystem.HID.HID.HIDReportType reportType, System.Collections.Generic.List<UnityEngine.InputSystem.HID.HIDParser.HIDReportData> reports)
END_CLASS

CLASS: HIDItemTypeAndTag
TYPE:  struct
TOKEN: 0x200014A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagInput  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagOutput  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagFeature  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagCollection  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagEndCollection  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagUsagePage  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagLogicalMinimum  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagLogicalMaximum  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagPhysicalMinimum  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagPhysicalMaximum  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagUnitExponent  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagUnit  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagReportSize  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagReportID  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagReportCount  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagPush  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagPop  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagUsage  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagUsageMinimum  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagUsageMaximum  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagDesignatorIndex  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagDesignatorMinimum  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagDesignatorMaximum  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagStringIndex  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagStringMinimum  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagStringMaximum  // 0x0
  public    static  UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTagDelimiter  // 0x0
METHODS:
END_CLASS

CLASS: HIDItemStateLocal
TYPE:  struct
TOKEN: 0x200014B
FIELDS:
  public            System.Nullable<System.Int32>   usage  // 0x10
  public            System.Nullable<System.Int32>   usageMinimum  // 0x18
  public            System.Nullable<System.Int32>   usageMaximum  // 0x20
  public            System.Nullable<System.Int32>   designatorIndex  // 0x28
  public            System.Nullable<System.Int32>   designatorMinimum  // 0x30
  public            System.Nullable<System.Int32>   designatorMaximum  // 0x38
  public            System.Nullable<System.Int32>   stringIndex  // 0x40
  public            System.Nullable<System.Int32>   stringMinimum  // 0x48
  public            System.Nullable<System.Int32>   stringMaximum  // 0x50
  public            System.Collections.Generic.List<System.Int32>usageList  // 0x58
METHODS:
  System.Void Reset(UnityEngine.InputSystem.HID.HIDParser.HIDItemStateLocal& state)
  System.Void SetUsage(System.Int32 value)
  System.Int32 GetUsage(System.Int32 index)
END_CLASS

CLASS: HIDItemStateGlobal
TYPE:  struct
TOKEN: 0x200014C
FIELDS:
  public            System.Nullable<System.Int32>   usagePage  // 0x10
  public            System.Nullable<System.Int32>   logicalMinimum  // 0x18
  public            System.Nullable<System.Int32>   logicalMaximum  // 0x20
  public            System.Nullable<System.Int32>   physicalMinimum  // 0x28
  public            System.Nullable<System.Int32>   physicalMaximum  // 0x30
  public            System.Nullable<System.Int32>   unitExponent  // 0x38
  public            System.Nullable<System.Int32>   unit  // 0x40
  public            System.Nullable<System.Int32>   reportSize  // 0x48
  public            System.Nullable<System.Int32>   reportCount  // 0x50
  public            System.Nullable<System.Int32>   reportId  // 0x58
METHODS:
  UnityEngine.InputSystem.HID.HID.UsagePage GetUsagePage(System.Int32 index, UnityEngine.InputSystem.HID.HIDParser.HIDItemStateLocal& localItemState)
  System.Int32 GetPhysicalMin()
  System.Int32 GetPhysicalMax()
END_CLASS

CLASS: HIDPageUsage
TYPE:  struct
TOKEN: 0x200014E
FIELDS:
  public            UnityEngine.InputSystem.HID.HID.UsagePagepage  // 0x10
  public            System.Int32                    usage  // 0x14
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.HID.HID.UsagePage page, System.Int32 usage)
  System.Void .ctor(UnityEngine.InputSystem.HID.HID.GenericDesktop usage)
END_CLASS

CLASS: GlobalState
TYPE:  struct
TOKEN: 0x2000152
FIELDS:
  private           UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Touchscreen>touchscreens  // 0x10
  private           System.Int32                    historyLengthPerFinger  // 0x28
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger>>onFingerDown  // 0x30
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger>>onFingerMove  // 0x80
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger>>onFingerUp  // 0xD0
  private           UnityEngine.InputSystem.EnhancedTouch.Touch.FingerAndTouchStateplayerState  // 0x120
METHODS:
END_CLASS

CLASS: FingerAndTouchState
TYPE:  struct
TOKEN: 0x2000153
FIELDS:
  public            UnityEngine.InputSystem.LowLevel.InputUpdateTypeupdateMask  // 0x10
  public            UnityEngine.InputSystem.EnhancedTouch.Finger[]fingers  // 0x18
  public            UnityEngine.InputSystem.EnhancedTouch.Finger[]activeFingers  // 0x20
  public            UnityEngine.InputSystem.EnhancedTouch.Touch[]activeTouches  // 0x28
  public            System.Int32                    activeFingerCount  // 0x30
  public            System.Int32                    activeTouchCount  // 0x34
  public            System.Int32                    totalFingerCount  // 0x38
  public            System.UInt32                   lastId  // 0x3C
  public            System.Boolean                  haveBuiltActiveTouches  // 0x40
  public            System.Boolean                  haveActiveTouchesNeedingRefreshNextUpdate  // 0x41
  public            UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState>activeTouchState  // 0x48
METHODS:
  System.Void AddFingers(UnityEngine.InputSystem.Touchscreen screen)
  System.Void RemoveFingers(UnityEngine.InputSystem.Touchscreen screen)
  System.Void Destroy()
  System.Void UpdateActiveFingers()
  System.Void UpdateActiveTouches()
END_CLASS

CLASS: ExtraDataPerTouchState
TYPE:  struct
TOKEN: 0x2000154
FIELDS:
  public            UnityEngine.Vector2             accumulatedDelta  // 0x10
  public            System.UInt32                   uniqueId  // 0x18
METHODS:
END_CLASS

CLASS: Enumerator
TYPE:  class
TOKEN: 0x2000157
FIELDS:
  private   readonly UnityEngine.InputSystem.EnhancedTouch.TouchHistorym_Owner  // 0x10
  private           System.Int32                    m_Index  // 0x30
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.EnhancedTouch.TouchHistory owner)
  System.Boolean MoveNext()
  System.Void Reset()
  UnityEngine.InputSystem.EnhancedTouch.Touch get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void Dispose()
END_CLASS

CLASS: DualSenseHIDGenericInputReport
TYPE:  struct
TOKEN: 0x200015B
FIELDS:
  public            System.Byte                     reportId  // 0x10
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Format()
END_CLASS

CLASS: DualSenseHIDUSBInputReport
TYPE:  struct
TOKEN: 0x200015C
FIELDS:
  public    static  System.Int32                    ExpectedReportId  // 0x0
  public            System.Byte                     reportId  // 0x10
  public            System.Byte                     leftStickX  // 0x11
  public            System.Byte                     leftStickY  // 0x12
  public            System.Byte                     rightStickX  // 0x13
  public            System.Byte                     rightStickY  // 0x14
  public            System.Byte                     leftTrigger  // 0x15
  public            System.Byte                     rightTrigger  // 0x16
  public            System.Byte                     buttons0  // 0x18
  public            System.Byte                     buttons1  // 0x19
  public            System.Byte                     buttons2  // 0x1A
METHODS:
  UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDInputReport ToHIDInputReport()
END_CLASS

CLASS: DualSenseHIDBluetoothInputReport
TYPE:  struct
TOKEN: 0x200015D
FIELDS:
  public    static  System.Int32                    ExpectedReportId  // 0x0
  public            System.Byte                     reportId  // 0x10
  public            System.Byte                     leftStickX  // 0x12
  public            System.Byte                     leftStickY  // 0x13
  public            System.Byte                     rightStickX  // 0x14
  public            System.Byte                     rightStickY  // 0x15
  public            System.Byte                     leftTrigger  // 0x16
  public            System.Byte                     rightTrigger  // 0x17
  public            System.Byte                     buttons0  // 0x19
  public            System.Byte                     buttons1  // 0x1A
  public            System.Byte                     buttons2  // 0x1B
METHODS:
  UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDInputReport ToHIDInputReport()
END_CLASS

CLASS: DualSenseHIDMinimalInputReport
TYPE:  struct
TOKEN: 0x200015E
FIELDS:
  public    static  System.Int32                    ExpectedSize1  // 0x0
  public    static  System.Int32                    ExpectedSize2  // 0x4
  public            System.Byte                     reportId  // 0x10
  public            System.Byte                     leftStickX  // 0x11
  public            System.Byte                     leftStickY  // 0x12
  public            System.Byte                     rightStickX  // 0x13
  public            System.Byte                     rightStickY  // 0x14
  public            System.Byte                     buttons0  // 0x15
  public            System.Byte                     buttons1  // 0x16
  public            System.Byte                     buttons2  // 0x17
  public            System.Byte                     leftTrigger  // 0x18
  public            System.Byte                     rightTrigger  // 0x19
METHODS:
  UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDInputReport ToHIDInputReport()
  System.Void .cctor()
END_CLASS

CLASS: DualShock4HIDGenericInputReport
TYPE:  struct
TOKEN: 0x2000160
FIELDS:
  public            System.Byte                     leftStickX  // 0x10
  public            System.Byte                     leftStickY  // 0x11
  public            System.Byte                     rightStickX  // 0x12
  public            System.Byte                     rightStickY  // 0x13
  public            System.Byte                     buttons0  // 0x14
  public            System.Byte                     buttons1  // 0x15
  public            System.Byte                     buttons2  // 0x16
  public            System.Byte                     leftTrigger  // 0x17
  public            System.Byte                     rightTrigger  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Format()
  UnityEngine.InputSystem.DualShock.LowLevel.DualShock4HIDInputReport ToHIDInputReport()
END_CLASS

CLASS: Flags
TYPE:  struct
TOKEN: 0x200016D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.DualShock.LowLevel.DualShockHIDOutputReport.FlagsRumble  // 0x0
  public    static  UnityEngine.InputSystem.DualShock.LowLevel.DualShockHIDOutputReport.FlagsColor  // 0x0
METHODS:
END_CLASS

CLASS: Result
TYPE:  struct
TOKEN: 0x2000179
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.LowLevel.InitiateUserAccountPairingCommand.ResultSuccessfullyInitiated  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.InitiateUserAccountPairingCommand.ResultErrorNotSupported  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.InitiateUserAccountPairingCommand.ResultErrorAlreadyInProgress  // 0x0
METHODS:
END_CLASS

CLASS: Result
TYPE:  struct
TOKEN: 0x2000185
FIELDS:
  public            System.Int64                    value__  // 0x10
  public    static  UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand.ResultDevicePairedToUserAccount  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand.ResultUserAccountSelectionInProgress  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand.ResultUserAccountSelectionComplete  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand.ResultUserAccountSelectionCanceled  // 0x0
METHODS:
END_CLASS

CLASS: Button
TYPE:  struct
TOKEN: 0x2000199
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.LowLevel.JoystickState.ButtonHatSwitchUp  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.JoystickState.ButtonHatSwitchDown  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.JoystickState.ButtonHatSwitchLeft  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.JoystickState.ButtonHatSwitchRight  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.JoystickState.ButtonTrigger  // 0x0
METHODS:
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x20001B4
FIELDS:
  private           UnityEngine.InputSystem.LowLevel.IMECompositionStringm_CompositionString  // 0x10
  private           System.Char                     m_CurrentCharacter  // 0x94
  private           System.Int32                    m_CurrentIndex  // 0x98
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.LowLevel.IMECompositionString compositionString)
  System.Boolean MoveNext()
  System.Void Reset()
  System.Void Dispose()
  System.Char get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x20001B8
FIELDS:
  private   readonly UnityEngine.InputSystem.LowLevel.InputEvent*m_Buffer  // 0x10
  private   readonly System.Int32                    m_EventCount  // 0x18
  private           UnityEngine.InputSystem.LowLevel.InputEvent*m_CurrentEvent  // 0x20
  private           System.Int32                    m_CurrentIndex  // 0x28
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputEventBuffer buffer)
  System.Boolean MoveNext()
  System.Void Reset()
  System.Void Dispose()
  UnityEngine.InputSystem.LowLevel.InputEventPtr get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: ObserverState
TYPE:  class
TOKEN: 0x20001BA
FIELDS:
  public            UnityEngine.InputSystem.Utilities.InlinedArray<System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr>>observers  // 0x10
  public            System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice>onEventDelegate  // 0x28
METHODS:
  System.Void .ctor()
  System.Void <.ctor>b__2_0(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device)
END_CLASS

CLASS: DisposableObserver
TYPE:  class
TOKEN: 0x20001BB
FIELDS:
  public            System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr>observer  // 0x10
METHODS:
  System.Void Dispose()
  System.Void .ctor()
END_CLASS

CLASS: Enumerator
TYPE:  class
TOKEN: 0x20001BF
FIELDS:
  private           UnityEngine.InputSystem.LowLevel.InputEventTracem_Trace  // 0x10
  private           System.Int32                    m_ChangeCounter  // 0x18
  private           UnityEngine.InputSystem.LowLevel.InputEventPtrm_Current  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputEventTrace trace)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  UnityEngine.InputSystem.LowLevel.InputEventPtr get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: FileFlags
TYPE:  struct
TOKEN: 0x20001C0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.LowLevel.InputEventTrace.FileFlagsFixedUpdate  // 0x0
METHODS:
END_CLASS

CLASS: ReplayController
TYPE:  class
TOKEN: 0x20001C1
FIELDS:
  private           System.Boolean                  <finished>k__BackingField  // 0x10
  private           System.Boolean                  <paused>k__BackingField  // 0x11
  private           System.Int32                    <position>k__BackingField  // 0x14
  private           UnityEngine.InputSystem.LowLevel.InputEventTracem_EventTrace  // 0x18
  private           UnityEngine.InputSystem.LowLevel.InputEventTrace.Enumeratorm_Enumerator  // 0x20
  private           UnityEngine.InputSystem.Utilities.InlinedArray<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>>m_DeviceIDMappings  // 0x28
  private           System.Boolean                  m_CreateNewDevices  // 0x40
  private           UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputDevice>m_CreatedDevices  // 0x48
  private           System.Action                   m_OnFinished  // 0x60
  private           System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr>m_OnEvent  // 0x68
  private           System.Double                   m_StartTimeAsPerFirstEvent  // 0x70
  private           System.Double                   m_StartTimeAsPerRuntime  // 0x78
  private           System.Int32                    m_AllEventsByTimeIndex  // 0x80
  private           System.Collections.Generic.List<UnityEngine.InputSystem.LowLevel.InputEventPtr>m_AllEventsByTime  // 0x88
METHODS:
  UnityEngine.InputSystem.LowLevel.InputEventTrace get_trace()
  System.Boolean get_finished()
  System.Void set_finished(System.Boolean value)
  System.Boolean get_paused()
  System.Void set_paused(System.Boolean value)
  System.Int32 get_position()
  System.Void set_position(System.Int32 value)
  System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputDevice> get_createdDevices()
  System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputEventTrace trace)
  System.Void Dispose()
  UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController WithDeviceMappedFromTo(UnityEngine.InputSystem.InputDevice recordedDevice, UnityEngine.InputSystem.InputDevice playbackDevice)
  UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController WithDeviceMappedFromTo(System.Int32 recordedDeviceId, System.Int32 playbackDeviceId)
  UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController WithAllDevicesMappedToNewInstances()
  UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController OnFinished(System.Action action)
  UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController OnEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> action)
  UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayOneEvent()
  UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController Rewind()
  UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayAllFramesOneByOne()
  UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayAllEvents()
  UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayAllEventsAccordingToTimestamps()
  System.Void OnBeginFrame()
  System.Void Finished()
  System.Void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Boolean MoveNext(System.Boolean skipFrameEvents, UnityEngine.InputSystem.LowLevel.InputEventPtr& eventPtr)
  System.Int32 ApplyDeviceMapping(System.Int32 originalDeviceId)
END_CLASS

CLASS: DeviceInfo
TYPE:  struct
TOKEN: 0x20001C4
FIELDS:
  private           System.Int32                    m_DeviceId  // 0x10
  private           System.String                   m_Layout  // 0x18
  private           UnityEngine.InputSystem.Utilities.FourCCm_StateFormat  // 0x20
  private           System.Int32                    m_StateSizeInBytes  // 0x24
  private           System.String                   m_FullLayoutJson  // 0x28
METHODS:
  System.Int32 get_deviceId()
  System.Void set_deviceId(System.Int32 value)
  System.String get_layout()
  System.Void set_layout(System.String value)
  UnityEngine.InputSystem.Utilities.FourCC get_stateFormat()
  System.Void set_stateFormat(UnityEngine.InputSystem.Utilities.FourCC value)
  System.Int32 get_stateSizeInBytes()
  System.Void set_stateSizeInBytes(System.Int32 value)
END_CLASS

CLASS: UpdateStepCount
TYPE:  struct
TOKEN: 0x20001CF
FIELDS:
  private           System.Boolean                  m_WasUpdated  // 0x10
  private           System.UInt32                   <value>k__BackingField  // 0x14
METHODS:
  System.UInt32 get_value()
  System.Void set_value(System.UInt32 value)
  System.Void OnBeforeUpdate()
  System.Void OnUpdate()
END_CLASS

CLASS: SerializedState
TYPE:  struct
TOKEN: 0x20001D0
FIELDS:
  public            UnityEngine.InputSystem.LowLevel.InputUpdateTypelastUpdateType  // 0x10
  public            UnityEngine.InputSystem.LowLevel.InputUpdate.UpdateStepCountplayerUpdateStepCount  // 0x14
METHODS:
END_CLASS

CLASS: StateChangeMonitorDelegate
TYPE:  class
TOKEN: 0x20001D9
FIELDS:
  public            System.Action<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Int64>valueChangeCallback  // 0x10
  public            System.Action<UnityEngine.InputSystem.InputControl,System.Double,System.Int64,System.Int32>timerExpiredCallback  // 0x18
METHODS:
  System.Void NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Int64 monitorIndex)
  System.Void NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, System.Double time, System.Int64 monitorIndex, System.Int32 timerIndex)
  System.Void .ctor()
END_CLASS

CLASS: DoubleBuffers
TYPE:  struct
TOKEN: 0x20001DC
FIELDS:
  public            System.Void**                   deviceToBufferMapping  // 0x10
  public            System.Int32                    deviceCount  // 0x18
METHODS:
  System.Boolean get_valid()
  System.Void SetFrontBuffer(System.Int32 deviceIndex, System.Void* ptr)
  System.Void SetBackBuffer(System.Int32 deviceIndex, System.Void* ptr)
  System.Void* GetFrontBuffer(System.Int32 deviceIndex)
  System.Void* GetBackBuffer(System.Int32 deviceIndex)
  System.Void SwapBuffers(System.Int32 deviceIndex)
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x20001DE
FIELDS:
  private   readonly UnityEngine.InputSystem.LowLevel.InputStateHistorym_History  // 0x10
  private           System.Int32                    m_Index  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory history)
  System.Boolean MoveNext()
  System.Void Reset()
  UnityEngine.InputSystem.LowLevel.InputStateHistory.Record get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void Dispose()
END_CLASS

CLASS: RecordHeader
TYPE:  struct
TOKEN: 0x20001DF
FIELDS:
  public            System.Double                   time  // 0x10
  public            System.UInt32                   version  // 0x18
  public            System.Int32                    controlIndex  // 0x1C
  private           UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader.<m_StateWithoutControlIndex>e__FixedBufferm_StateWithoutControlIndex  // 0x1C
  private           UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader.<m_StateWithControlIndex>e__FixedBufferm_StateWithControlIndex  // 0x20
  public    static  System.Int32                    kSizeWithControlIndex  // 0x0
  public    static  System.Int32                    kSizeWithoutControlIndex  // 0x0
METHODS:
  System.Byte* get_statePtrWithControlIndex()
  System.Byte* get_statePtrWithoutControlIndex()
END_CLASS

CLASS: Record
TYPE:  struct
TOKEN: 0x20001E2
FIELDS:
  private   readonly UnityEngine.InputSystem.LowLevel.InputStateHistorym_Owner  // 0x10
  private   readonly System.Int32                    m_IndexPlusOne  // 0x18
  private           System.UInt32                   m_Version  // 0x1C
METHODS:
  UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* get_header()
  System.Int32 get_recordIndex()
  System.UInt32 get_version()
  System.Boolean get_valid()
  UnityEngine.InputSystem.LowLevel.InputStateHistory get_owner()
  System.Int32 get_index()
  System.Double get_time()
  UnityEngine.InputSystem.InputControl get_control()
  UnityEngine.InputSystem.LowLevel.InputStateHistory.Record get_next()
  UnityEngine.InputSystem.LowLevel.InputStateHistory.Record get_previous()
  System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory owner, System.Int32 index, UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* header)
  TValue ReadValue()
  System.Object ReadValueAsObject()
  System.Void* GetUnsafeMemoryPtr()
  System.Void* GetUnsafeMemoryPtrUnchecked()
  System.Void* GetUnsafeExtraMemoryPtr()
  System.Void* GetUnsafeExtraMemoryPtrUnchecked()
  System.Void CopyFrom(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record record)
  System.Void CheckValid()
  System.Boolean Equals(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x20001E4
FIELDS:
  private   readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>m_History  // 0x0
  private           System.Int32                    m_Index  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> history)
  System.Boolean MoveNext()
  System.Void Reset()
  UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void Dispose()
END_CLASS

CLASS: Record
TYPE:  struct
TOKEN: 0x20001E5
FIELDS:
  private   readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue>m_Owner  // 0x0
  private   readonly System.Int32                    m_IndexPlusOne  // 0x0
  private           System.UInt32                   m_Version  // 0x0
METHODS:
  UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* get_header()
  System.Int32 get_recordIndex()
  System.Boolean get_valid()
  UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> get_owner()
  System.Int32 get_index()
  System.Double get_time()
  UnityEngine.InputSystem.InputControl<TValue> get_control()
  UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> get_next()
  UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> get_previous()
  System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, System.Int32 index, UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* header)
  System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, System.Int32 index)
  TValue ReadValue()
  System.Void* GetUnsafeMemoryPtr()
  System.Void* GetUnsafeMemoryPtrUnchecked()
  System.Void* GetUnsafeExtraMemoryPtr()
  System.Void* GetUnsafeExtraMemoryPtrUnchecked()
  System.Void CopyFrom(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> record)
  System.Void CheckValid()
  System.Boolean Equals(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Select
TYPE:  class
TOKEN: 0x20001E7
FIELDS:
  private           UnityEngine.InputSystem.LowLevel.SelectObservable<TSource,TResult>m_Observable  // 0x0
  private   readonly System.IObserver<TResult>       m_Observer  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.LowLevel.SelectObservable<TSource,TResult> observable, System.IObserver<TResult> observer)
  System.Void OnCompleted()
  System.Void OnError(System.Exception error)
  System.Void OnNext(TSource evt)
END_CLASS

CLASS: Flags
TYPE:  struct
TOKEN: 0x20001FA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.FlagsisModifyingExistingControl  // 0x0
  public    static  UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.FlagsIsNoisy  // 0x0
  public    static  UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.FlagsIsSynthetic  // 0x0
  public    static  UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.FlagsIsFirstDefinedInThisLayout  // 0x0
  public    static  UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.FlagsDontReset  // 0x0
METHODS:
END_CLASS

CLASS: ControlItem
TYPE:  struct
TOKEN: 0x20001F9
FIELDS:
  private           UnityEngine.InputSystem.Utilities.InternedString<name>k__BackingField  // 0x10
  private           UnityEngine.InputSystem.Utilities.InternedString<layout>k__BackingField  // 0x20
  private           UnityEngine.InputSystem.Utilities.InternedString<variants>k__BackingField  // 0x30
  private           System.String                   <useStateFrom>k__BackingField  // 0x40
  private           System.String                   <displayName>k__BackingField  // 0x48
  private           System.String                   <shortDisplayName>k__BackingField  // 0x50
  private           UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString><usages>k__BackingField  // 0x58
  private           UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString><aliases>k__BackingField  // 0x68
  private           UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue><parameters>k__BackingField  // 0x78
  private           UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters><processors>k__BackingField  // 0x88
  private           System.UInt32                   <offset>k__BackingField  // 0x98
  private           System.UInt32                   <bit>k__BackingField  // 0x9C
  private           System.UInt32                   <sizeInBits>k__BackingField  // 0xA0
  private           UnityEngine.InputSystem.Utilities.FourCC<format>k__BackingField  // 0xA4
  private           UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags<flags>k__BackingField  // 0xA8
  private           System.Int32                    <arraySize>k__BackingField  // 0xAC
  private           UnityEngine.InputSystem.Utilities.PrimitiveValue<defaultState>k__BackingField  // 0xB0
  private           UnityEngine.InputSystem.Utilities.PrimitiveValue<minValue>k__BackingField  // 0xC0
  private           UnityEngine.InputSystem.Utilities.PrimitiveValue<maxValue>k__BackingField  // 0xD0
METHODS:
  UnityEngine.InputSystem.Utilities.InternedString get_name()
  System.Void set_name(UnityEngine.InputSystem.Utilities.InternedString value)
  UnityEngine.InputSystem.Utilities.InternedString get_layout()
  System.Void set_layout(UnityEngine.InputSystem.Utilities.InternedString value)
  UnityEngine.InputSystem.Utilities.InternedString get_variants()
  System.Void set_variants(UnityEngine.InputSystem.Utilities.InternedString value)
  System.String get_useStateFrom()
  System.Void set_useStateFrom(System.String value)
  System.String get_displayName()
  System.Void set_displayName(System.String value)
  System.String get_shortDisplayName()
  System.Void set_shortDisplayName(System.String value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_usages()
  System.Void set_usages(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_aliases()
  System.Void set_aliases(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> get_parameters()
  System.Void set_parameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> get_processors()
  System.Void set_processors(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> value)
  System.UInt32 get_offset()
  System.Void set_offset(System.UInt32 value)
  System.UInt32 get_bit()
  System.Void set_bit(System.UInt32 value)
  System.UInt32 get_sizeInBits()
  System.Void set_sizeInBits(System.UInt32 value)
  UnityEngine.InputSystem.Utilities.FourCC get_format()
  System.Void set_format(UnityEngine.InputSystem.Utilities.FourCC value)
  UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags get_flags()
  System.Void set_flags(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags value)
  System.Int32 get_arraySize()
  System.Void set_arraySize(System.Int32 value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue get_defaultState()
  System.Void set_defaultState(UnityEngine.InputSystem.Utilities.PrimitiveValue value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue get_minValue()
  System.Void set_minValue(UnityEngine.InputSystem.Utilities.PrimitiveValue value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue get_maxValue()
  System.Void set_maxValue(UnityEngine.InputSystem.Utilities.PrimitiveValue value)
  System.Boolean get_isModifyingExistingControl()
  System.Void set_isModifyingExistingControl(System.Boolean value)
  System.Boolean get_isNoisy()
  System.Void set_isNoisy(System.Boolean value)
  System.Boolean get_isSynthetic()
  System.Void set_isSynthetic(System.Boolean value)
  System.Boolean get_dontReset()
  System.Void set_dontReset(System.Boolean value)
  System.Boolean get_isFirstDefinedInThisLayout()
  System.Void set_isFirstDefinedInThisLayout(System.Boolean value)
  System.Boolean get_isArray()
  UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem Merge(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem other)
END_CLASS

CLASS: ControlBuilder
TYPE:  struct
TOKEN: 0x20001FC
FIELDS:
  private           UnityEngine.InputSystem.Layouts.InputControlLayout.Builderbuilder  // 0x10
  private           System.Int32                    index  // 0x18
METHODS:
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithDisplayName(System.String displayName)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithLayout(System.String layout)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithFormat(UnityEngine.InputSystem.Utilities.FourCC format)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithFormat(System.String format)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithByteOffset(System.UInt32 offset)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithBitOffset(System.UInt32 bit)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder IsSynthetic(System.Boolean value)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder IsNoisy(System.Boolean value)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder DontReset(System.Boolean value)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithSizeInBits(System.UInt32 sizeInBits)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithRange(System.Single minValue, System.Single maxValue)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithUsages(UnityEngine.InputSystem.Utilities.InternedString[] usages)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithUsages(System.Collections.Generic.IEnumerable<System.String> usages)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithUsages(System.String[] usages)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithParameters(System.String parameters)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithProcessors(System.String processors)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithDefaultState(UnityEngine.InputSystem.Utilities.PrimitiveValue value)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder UsingStateFrom(System.String path)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder AsArrayOfControlsWithSize(System.Int32 arraySize)
END_CLASS

CLASS: Builder
TYPE:  class
TOKEN: 0x20001FB
FIELDS:
  private           System.String                   <name>k__BackingField  // 0x10
  private           System.String                   <displayName>k__BackingField  // 0x18
  private           System.Type                     <type>k__BackingField  // 0x20
  private           UnityEngine.InputSystem.Utilities.FourCC<stateFormat>k__BackingField  // 0x28
  private           System.Int32                    <stateSizeInBytes>k__BackingField  // 0x2C
  private           System.String                   m_ExtendsLayout  // 0x30
  private           System.Nullable<System.Boolean> <updateBeforeRender>k__BackingField  // 0x38
  private           System.Int32                    m_ControlCount  // 0x3C
  private           UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[]m_Controls  // 0x40
METHODS:
  System.String get_name()
  System.Void set_name(System.String value)
  System.String get_displayName()
  System.Void set_displayName(System.String value)
  System.Type get_type()
  System.Void set_type(System.Type value)
  UnityEngine.InputSystem.Utilities.FourCC get_stateFormat()
  System.Void set_stateFormat(UnityEngine.InputSystem.Utilities.FourCC value)
  System.Int32 get_stateSizeInBytes()
  System.Void set_stateSizeInBytes(System.Int32 value)
  System.String get_extendsLayout()
  System.Void set_extendsLayout(System.String value)
  System.Nullable<System.Boolean> get_updateBeforeRender()
  System.Void set_updateBeforeRender(System.Nullable<System.Boolean> value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> get_controls()
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder AddControl(System.String name)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithName(System.String name)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithDisplayName(System.String displayName)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithType()
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithFormat(UnityEngine.InputSystem.Utilities.FourCC format)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithFormat(System.String format)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithSizeInBytes(System.Int32 sizeInBytes)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Builder Extend(System.String baseLayoutName)
  UnityEngine.InputSystem.Layouts.InputControlLayout Build()
  System.Void .ctor()
END_CLASS

CLASS: Flags
TYPE:  struct
TOKEN: 0x20001FE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Layouts.InputControlLayout.FlagsIsGenericTypeOfDevice  // 0x0
  public    static  UnityEngine.InputSystem.Layouts.InputControlLayout.FlagsHideInUI  // 0x0
  public    static  UnityEngine.InputSystem.Layouts.InputControlLayout.FlagsIsOverride  // 0x0
  public    static  UnityEngine.InputSystem.Layouts.InputControlLayout.FlagsCanRunInBackground  // 0x0
  public    static  UnityEngine.InputSystem.Layouts.InputControlLayout.FlagsCanRunInBackgroundIsSet  // 0x0
  public    static  UnityEngine.InputSystem.Layouts.InputControlLayout.FlagsIsNoisy  // 0x0
METHODS:
END_CLASS

CLASS: LayoutJsonNameAndDescriptorOnly
TYPE:  struct
TOKEN: 0x20001FF
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   extend  // 0x18
  public            System.String[]                 extendMultiple  // 0x20
  public            UnityEngine.InputSystem.Layouts.InputDeviceMatcher.MatcherJsondevice  // 0x28
METHODS:
END_CLASS

CLASS: LayoutJson
TYPE:  struct
TOKEN: 0x2000200
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   extend  // 0x18
  public            System.String[]                 extendMultiple  // 0x20
  public            System.String                   format  // 0x28
  public            System.String                   beforeRender  // 0x30
  public            System.String                   runInBackground  // 0x38
  public            System.String[]                 commonUsages  // 0x40
  public            System.String                   displayName  // 0x48
  public            System.String                   description  // 0x50
  public            System.String                   type  // 0x58
  public            System.String                   variant  // 0x60
  public            System.Boolean                  isGenericTypeOfDevice  // 0x68
  public            System.Boolean                  hideInUI  // 0x69
  public            UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItemJson[]controls  // 0x70
METHODS:
  UnityEngine.InputSystem.Layouts.InputControlLayout ToLayout()
  UnityEngine.InputSystem.Layouts.InputControlLayout.LayoutJson FromLayout(UnityEngine.InputSystem.Layouts.InputControlLayout layout)
END_CLASS

CLASS: ControlItemJson
TYPE:  class
TOKEN: 0x2000202
FIELDS:
  public            System.String                   name  // 0x10
  public            System.String                   layout  // 0x18
  public            System.String                   variants  // 0x20
  public            System.String                   usage  // 0x28
  public            System.String                   alias  // 0x30
  public            System.String                   useStateFrom  // 0x38
  public            System.UInt32                   offset  // 0x40
  public            System.UInt32                   bit  // 0x44
  public            System.UInt32                   sizeInBits  // 0x48
  public            System.String                   format  // 0x50
  public            System.Int32                    arraySize  // 0x58
  public            System.String[]                 usages  // 0x60
  public            System.String[]                 aliases  // 0x68
  public            System.String                   parameters  // 0x70
  public            System.String                   processors  // 0x78
  public            System.String                   displayName  // 0x80
  public            System.String                   shortDisplayName  // 0x88
  public            System.Boolean                  noisy  // 0x90
  public            System.Boolean                  dontReset  // 0x91
  public            System.Boolean                  synthetic  // 0x92
  public            System.String                   defaultState  // 0x98
  public            System.String                   minValue  // 0xA0
  public            System.String                   maxValue  // 0xA8
METHODS:
  System.Void .ctor()
  UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem ToLayout()
  UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItemJson[] FromControlItems(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[] items)
END_CLASS

CLASS: LayoutMatcher
TYPE:  struct
TOKEN: 0x2000205
FIELDS:
  public            UnityEngine.InputSystem.Utilities.InternedStringlayoutName  // 0x10
  public            UnityEngine.InputSystem.Layouts.InputDeviceMatcherdeviceMatcher  // 0x20
METHODS:
END_CLASS

CLASS: PrecompiledLayout
TYPE:  struct
TOKEN: 0x2000206
FIELDS:
  public            System.Func<UnityEngine.InputSystem.InputDevice>factoryMethod  // 0x10
  public            System.String                   metadata  // 0x18
METHODS:
END_CLASS

CLASS: Collection
TYPE:  struct
TOKEN: 0x2000204
FIELDS:
  public    static  System.Single                   kBaseScoreForNonGeneratedLayouts  // 0x0
  public            System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.Type>layoutTypes  // 0x10
  public            System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.String>layoutStrings  // 0x18
  public            System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout>>layoutBuilders  // 0x20
  public            System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString>baseLayoutTable  // 0x28
  public            System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString[]>layoutOverrides  // 0x30
  public            System.Collections.Generic.HashSet<UnityEngine.InputSystem.Utilities.InternedString>layoutOverrideNames  // 0x38
  public            System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout.Collection.PrecompiledLayout>precompiledLayouts  // 0x40
  public            System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.Collection.LayoutMatcher>layoutMatchers  // 0x48
METHODS:
  System.Void Allocate()
  UnityEngine.InputSystem.Utilities.InternedString TryFindLayoutForType(System.Type layoutType)
  UnityEngine.InputSystem.Utilities.InternedString TryFindMatchingLayout(UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription)
  System.Boolean HasLayout(UnityEngine.InputSystem.Utilities.InternedString name)
  UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadLayoutInternal(UnityEngine.InputSystem.Utilities.InternedString name)
  UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadLayout(UnityEngine.InputSystem.Utilities.InternedString name, System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout> table)
  UnityEngine.InputSystem.Utilities.InternedString GetBaseLayoutName(UnityEngine.InputSystem.Utilities.InternedString layoutName)
  UnityEngine.InputSystem.Utilities.InternedString GetRootLayoutName(UnityEngine.InputSystem.Utilities.InternedString layoutName)
  System.Boolean ComputeDistanceInInheritanceHierarchy(UnityEngine.InputSystem.Utilities.InternedString firstLayout, UnityEngine.InputSystem.Utilities.InternedString secondLayout, System.Int32& distance)
  UnityEngine.InputSystem.Utilities.InternedString FindLayoutThatIntroducesControl(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Layouts.InputControlLayout.Cache cache)
  System.Type GetControlTypeForLayout(UnityEngine.InputSystem.Utilities.InternedString layoutName)
  System.Boolean ValueTypeIsAssignableFrom(UnityEngine.InputSystem.Utilities.InternedString layoutName, System.Type valueType)
  System.Boolean IsGeneratedLayout(UnityEngine.InputSystem.Utilities.InternedString layout)
  System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> GetBaseLayouts(UnityEngine.InputSystem.Utilities.InternedString layout, System.Boolean includeSelf)
  System.Boolean IsBasedOn(UnityEngine.InputSystem.Utilities.InternedString parentLayout, UnityEngine.InputSystem.Utilities.InternedString childLayout)
  System.Void AddMatcher(UnityEngine.InputSystem.Utilities.InternedString layout, UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher)
END_CLASS

CLASS: LayoutNotFoundException
TYPE:  class
TOKEN: 0x2000208
EXTENDS: Exception
FIELDS:
  private   readonly System.String                   <layout>k__BackingField  // 0x90
METHODS:
  System.String get_layout()
  System.Void .ctor()
  System.Void .ctor(System.String name, System.String message)
  System.Void .ctor(System.String name)
  System.Void .ctor(System.String message, System.Exception innerException)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
END_CLASS

CLASS: Cache
TYPE:  struct
TOKEN: 0x2000209
FIELDS:
  public            System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout>table  // 0x10
METHODS:
  System.Void Clear()
  UnityEngine.InputSystem.Layouts.InputControlLayout FindOrLoadLayout(System.String name, System.Boolean throwIfNotFound)
END_CLASS

CLASS: CacheRefInstance
TYPE:  struct
TOKEN: 0x200020A
FIELDS:
  public            System.Boolean                  valid  // 0x10
METHODS:
  System.Void Dispose()
END_CLASS

CLASS: RefInstance
TYPE:  struct
TOKEN: 0x200020E
FIELDS:
METHODS:
  System.Void Dispose()
END_CLASS

CLASS: DeviceDescriptionJson
TYPE:  struct
TOKEN: 0x2000210
FIELDS:
  public            System.String                   interface  // 0x10
  public            System.String                   type  // 0x18
  public            System.String                   product  // 0x20
  public            System.String                   serial  // 0x28
  public            System.String                   version  // 0x30
  public            System.String                   manufacturer  // 0x38
  public            System.String                   capabilities  // 0x40
METHODS:
END_CLASS

CLASS: Capability
TYPE:  struct
TOKEN: 0x2000213
FIELDS:
  public            System.String                   path  // 0x10
  public            System.String                   value  // 0x18
METHODS:
END_CLASS

CLASS: MatcherJson
TYPE:  struct
TOKEN: 0x2000212
FIELDS:
  public            System.String                   interface  // 0x10
  public            System.String[]                 interfaces  // 0x18
  public            System.String                   deviceClass  // 0x20
  public            System.String[]                 deviceClasses  // 0x28
  public            System.String                   manufacturer  // 0x30
  public            System.String                   manufacturerContains  // 0x38
  public            System.String[]                 manufacturers  // 0x40
  public            System.String                   product  // 0x48
  public            System.String[]                 products  // 0x50
  public            System.String                   version  // 0x58
  public            System.String[]                 versions  // 0x60
  public            UnityEngine.InputSystem.Layouts.InputDeviceMatcher.MatcherJson.Capability[]capabilities  // 0x68
METHODS:
  UnityEngine.InputSystem.Layouts.InputDeviceMatcher.MatcherJson FromMatcher(UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher)
  UnityEngine.InputSystem.Layouts.InputDeviceMatcher ToMatcher()
END_CLASS

CLASS: Clamp
TYPE:  struct
TOKEN: 0x2000218
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Controls.AxisControl.ClampNone  // 0x0
  public    static  UnityEngine.InputSystem.Controls.AxisControl.ClampBeforeNormalize  // 0x0
  public    static  UnityEngine.InputSystem.Controls.AxisControl.ClampAfterNormalize  // 0x0
  public    static  UnityEngine.InputSystem.Controls.AxisControl.ClampToConstantBeforeNormalize  // 0x0
METHODS:
END_CLASS

CLASS: WriteMode
TYPE:  struct
TOKEN: 0x200021C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Controls.DiscreteButtonControl.WriteModeWriteDisabled  // 0x0
  public    static  UnityEngine.InputSystem.Controls.DiscreteButtonControl.WriteModeWriteNullAndMaxValue  // 0x0
METHODS:
END_CLASS

CLASS: DpadAxisControl
TYPE:  class
TOKEN: 0x200021F
EXTENDS: AxisControl
FIELDS:
  private           System.Int32                    <component>k__BackingField  // 0x130
METHODS:
  System.Int32 get_component()
  System.Void set_component(System.Int32 value)
  System.Void FinishSetup()
  System.Single ReadUnprocessedValueFromState(System.Void* statePtr)
  System.Void .ctor()
END_CLASS

CLASS: ButtonBits
TYPE:  struct
TOKEN: 0x2000220
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Controls.DpadControl.ButtonBitsUp  // 0x0
  public    static  UnityEngine.InputSystem.Controls.DpadControl.ButtonBitsDown  // 0x0
  public    static  UnityEngine.InputSystem.Controls.DpadControl.ButtonBitsLeft  // 0x0
  public    static  UnityEngine.InputSystem.Controls.DpadControl.ButtonBitsRight  // 0x0
METHODS:
END_CLASS

CLASS: TapPhase
TYPE:  struct
TOKEN: 0x200022C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Interactions.MultiTapInteraction.TapPhaseNone  // 0x0
  public    static  UnityEngine.InputSystem.Interactions.MultiTapInteraction.TapPhaseWaitingForNextRelease  // 0x0
  public    static  UnityEngine.InputSystem.Interactions.MultiTapInteraction.TapPhaseWaitingForNextPress  // 0x0
METHODS:
END_CLASS

CLASS: ActionEventPtr
TYPE:  struct
TOKEN: 0x2000232
FIELDS:
  private           UnityEngine.InputSystem.InputActionStatem_State  // 0x10
  private           UnityEngine.InputSystem.LowLevel.ActionEvent*m_Ptr  // 0x18
METHODS:
  UnityEngine.InputSystem.InputAction get_action()
  UnityEngine.InputSystem.InputActionPhase get_phase()
  UnityEngine.InputSystem.InputControl get_control()
  UnityEngine.InputSystem.IInputInteraction get_interaction()
  System.Double get_time()
  System.Double get_startTime()
  System.Double get_duration()
  System.Int32 get_valueSizeInBytes()
  System.Object ReadValueAsObject()
  System.Void ReadValue(System.Void* buffer, System.Int32 bufferSize)
  TValue ReadValue()
  System.String ToString()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000233
FIELDS:
  private   readonly UnityEngine.InputSystem.Utilities.InputActionTracem_Trace  // 0x10
  private   readonly UnityEngine.InputSystem.LowLevel.ActionEvent*m_Buffer  // 0x18
  private   readonly System.Int32                    m_EventCount  // 0x20
  private           UnityEngine.InputSystem.LowLevel.ActionEvent*m_CurrentEvent  // 0x28
  private           System.Int32                    m_CurrentIndex  // 0x30
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.Utilities.InputActionTrace trace)
  System.Boolean MoveNext()
  System.Void Reset()
  System.Void Dispose()
  UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000241
FIELDS:
  public            UnityEngine.InputSystem.Utilities.InlinedArray<TValue>array  // 0x0
  public            System.Int32                    index  // 0x0
METHODS:
  System.Boolean MoveNext()
  System.Void Reset()
  TValue get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void Dispose()
END_CLASS

CLASS: JsonValueType
TYPE:  struct
TOKEN: 0x2000245
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Utilities.JsonParser.JsonValueTypeNone  // 0x0
  public    static  UnityEngine.InputSystem.Utilities.JsonParser.JsonValueTypeBool  // 0x0
  public    static  UnityEngine.InputSystem.Utilities.JsonParser.JsonValueTypeReal  // 0x0
  public    static  UnityEngine.InputSystem.Utilities.JsonParser.JsonValueTypeInteger  // 0x0
  public    static  UnityEngine.InputSystem.Utilities.JsonParser.JsonValueTypeString  // 0x0
  public    static  UnityEngine.InputSystem.Utilities.JsonParser.JsonValueTypeArray  // 0x0
  public    static  UnityEngine.InputSystem.Utilities.JsonParser.JsonValueTypeObject  // 0x0
  public    static  UnityEngine.InputSystem.Utilities.JsonParser.JsonValueTypeAny  // 0x0
METHODS:
END_CLASS

CLASS: JsonString
TYPE:  struct
TOKEN: 0x2000246
FIELDS:
  public            UnityEngine.InputSystem.Utilities.Substringtext  // 0x10
  public            System.Boolean                  hasEscapes  // 0x20
METHODS:
  System.String ToString()
  System.Boolean Equals(UnityEngine.InputSystem.Utilities.JsonParser.JsonString other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.JsonParser.JsonString left, UnityEngine.InputSystem.Utilities.JsonParser.JsonString right)
  System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.JsonParser.JsonString left, UnityEngine.InputSystem.Utilities.JsonParser.JsonString right)
  UnityEngine.InputSystem.Utilities.JsonParser.JsonString op_Implicit(System.String str)
END_CLASS

CLASS: JsonValue
TYPE:  struct
TOKEN: 0x2000247
FIELDS:
  public            UnityEngine.InputSystem.Utilities.JsonParser.JsonValueTypetype  // 0x10
  public            System.Boolean                  boolValue  // 0x14
  public            System.Double                   realValue  // 0x18
  public            System.Int64                    integerValue  // 0x20
  public            UnityEngine.InputSystem.Utilities.JsonParser.JsonStringstringValue  // 0x28
  public            System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue>arrayValue  // 0x40
  public            System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Utilities.JsonParser.JsonValue>objectValue  // 0x48
  public            System.Object                   anyValue  // 0x50
METHODS:
  System.Boolean ToBoolean()
  System.Int64 ToInteger()
  System.Double ToDouble()
  System.String ToString()
  UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Boolean val)
  UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Int64 val)
  UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Double val)
  UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.String str)
  UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(UnityEngine.InputSystem.Utilities.JsonParser.JsonString str)
  UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> array)
  UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> obj)
  UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Enum val)
  System.Boolean Equals(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue other)
  System.Boolean Equals(System.Object obj, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue value)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue left, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue right)
  System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue left, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue right)
END_CLASS

CLASS: BitRegion
TYPE:  struct
TOKEN: 0x200024A
FIELDS:
  public            System.UInt32                   bitOffset  // 0x10
  public            System.UInt32                   sizeInBits  // 0x14
METHODS:
  System.Boolean get_isEmpty()
  System.Void .ctor(System.UInt32 bitOffset, System.UInt32 sizeInBits)
  System.Void .ctor(System.UInt32 byteOffset, System.UInt32 bitOffset, System.UInt32 sizeInBits)
  UnityEngine.InputSystem.Utilities.MemoryHelpers.BitRegion Overlap(UnityEngine.InputSystem.Utilities.MemoryHelpers.BitRegion other)
END_CLASS

CLASS: ForDevice
TYPE:  class
TOKEN: 0x2000252
FIELDS:
  private           System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr>m_Observer  // 0x10
  private           UnityEngine.InputSystem.InputDevicem_Device  // 0x18
  private           System.Type                     m_DeviceType  // 0x20
METHODS:
  System.Void .ctor(System.Type deviceType, UnityEngine.InputSystem.InputDevice device, System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer)
  System.Void OnCompleted()
  System.Void OnError(System.Exception error)
  System.Void OnNext(UnityEngine.InputSystem.LowLevel.InputEventPtr value)
END_CLASS

CLASS: Select
TYPE:  class
TOKEN: 0x2000257
FIELDS:
  private           UnityEngine.InputSystem.Utilities.SelectManyObservable<TSource,TResult>m_Observable  // 0x0
  private   readonly System.IObserver<TResult>       m_Observer  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.Utilities.SelectManyObservable<TSource,TResult> observable, System.IObserver<TResult> observer)
  System.Void OnCompleted()
  System.Void OnError(System.Exception error)
  System.Void OnNext(TSource evt)
END_CLASS

CLASS: Take
TYPE:  class
TOKEN: 0x2000259
FIELDS:
  private           System.IObserver<TValue>        m_Observer  // 0x0
  private           System.Int32                    m_Remaining  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.Utilities.TakeNObservable<TValue> observable, System.IObserver<TValue> observer)
  System.Void OnCompleted()
  System.Void OnError(System.Exception error)
  System.Void OnNext(TValue evt)
END_CLASS

CLASS: Where
TYPE:  class
TOKEN: 0x200025B
FIELDS:
  private           UnityEngine.InputSystem.Utilities.WhereObservable<TValue>m_Observable  // 0x0
  private   readonly System.IObserver<TValue>        m_Observer  // 0x0
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.Utilities.WhereObservable<TValue> observable, System.IObserver<TValue> observer)
  System.Void OnCompleted()
  System.Void OnError(System.Exception error)
  System.Void OnNext(TValue evt)
END_CLASS

CLASS: Enumerator
TYPE:  class
TOKEN: 0x200025D
FIELDS:
  private           System.Int32                    m_Index  // 0x0
  private           UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList>m_List  // 0x0
METHODS:
  System.Boolean MoveNext()
  System.Void Reset()
  TValue get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void Dispose()
  System.Void .ctor()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000261
FIELDS:
  private   readonly TValue[]                        m_Array  // 0x0
  private   readonly System.Int32                    m_IndexStart  // 0x0
  private   readonly System.Int32                    m_IndexEnd  // 0x0
  private           System.Int32                    m_Index  // 0x0
METHODS:
  System.Void .ctor(TValue[] array, System.Int32 index, System.Int32 length)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  TValue get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: TypedRestore
TYPE:  class
TOKEN: 0x2000265
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T& state)
  System.IAsyncResult BeginInvoke(T& state, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(T& state, System.IAsyncResult result)
END_CLASS

CLASS: WhichSideWins
TYPE:  struct
TOKEN: 0x200026F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Composites.AxisComposite.WhichSideWinsNeither  // 0x0
  public    static  UnityEngine.InputSystem.Composites.AxisComposite.WhichSideWinsPositive  // 0x0
  public    static  UnityEngine.InputSystem.Composites.AxisComposite.WhichSideWinsNegative  // 0x0
METHODS:
END_CLASS

CLASS: ModifiersOrder
TYPE:  struct
TOKEN: 0x2000271
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Composites.ButtonWithOneModifier.ModifiersOrderDefault  // 0x0
  public    static  UnityEngine.InputSystem.Composites.ButtonWithOneModifier.ModifiersOrderOrdered  // 0x0
  public    static  UnityEngine.InputSystem.Composites.ButtonWithOneModifier.ModifiersOrderUnordered  // 0x0
METHODS:
END_CLASS

CLASS: ModifiersOrder
TYPE:  struct
TOKEN: 0x2000273
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Composites.ButtonWithTwoModifiers.ModifiersOrderDefault  // 0x0
  public    static  UnityEngine.InputSystem.Composites.ButtonWithTwoModifiers.ModifiersOrderOrdered  // 0x0
  public    static  UnityEngine.InputSystem.Composites.ButtonWithTwoModifiers.ModifiersOrderUnordered  // 0x0
METHODS:
END_CLASS

CLASS: ModifiersOrder
TYPE:  struct
TOKEN: 0x2000275
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Composites.OneModifierComposite.ModifiersOrderDefault  // 0x0
  public    static  UnityEngine.InputSystem.Composites.OneModifierComposite.ModifiersOrderOrdered  // 0x0
  public    static  UnityEngine.InputSystem.Composites.OneModifierComposite.ModifiersOrderUnordered  // 0x0
METHODS:
END_CLASS

CLASS: ModifiersOrder
TYPE:  struct
TOKEN: 0x2000277
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Composites.TwoModifiersComposite.ModifiersOrderDefault  // 0x0
  public    static  UnityEngine.InputSystem.Composites.TwoModifiersComposite.ModifiersOrderOrdered  // 0x0
  public    static  UnityEngine.InputSystem.Composites.TwoModifiersComposite.ModifiersOrderUnordered  // 0x0
METHODS:
END_CLASS

CLASS: Mode
TYPE:  struct
TOKEN: 0x2000279
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Composites.Vector2Composite.ModeAnalog  // 0x0
  public    static  UnityEngine.InputSystem.Composites.Vector2Composite.ModeDigitalNormalized  // 0x0
  public    static  UnityEngine.InputSystem.Composites.Vector2Composite.ModeDigital  // 0x0
METHODS:
END_CLASS

CLASS: Mode
TYPE:  struct
TOKEN: 0x200027B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Composites.Vector3Composite.ModeAnalog  // 0x0
  public    static  UnityEngine.InputSystem.Composites.Vector3Composite.ModeDigitalNormalized  // 0x0
  public    static  UnityEngine.InputSystem.Composites.Vector3Composite.ModeDigital  // 0x0
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=20
TYPE:  struct
TOKEN: 0x200027D
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=24
TYPE:  struct
TOKEN: 0x200027E
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=84
TYPE:  struct
TOKEN: 0x200027F
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=104
TYPE:  struct
TOKEN: 0x2000280
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=262
TYPE:  struct
TOKEN: 0x2000281
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=371
TYPE:  struct
TOKEN: 0x2000282
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=508
TYPE:  struct
TOKEN: 0x2000283
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=976
TYPE:  struct
TOKEN: 0x2000284
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=1036
TYPE:  struct
TOKEN: 0x2000285
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=1799
TYPE:  struct
TOKEN: 0x2000286
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=3983
TYPE:  struct
TOKEN: 0x2000287
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.XR.GoogleVr.DaydreamHMD
TYPE:  class
TOKEN: 0x2000010
EXTENDS: XRHMD
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.XR.GoogleVr.DaydreamController
TYPE:  class
TOKEN: 0x2000011
EXTENDS: XRController
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector2Control<touchpad>k__BackingField  // 0x1B0
  private           UnityEngine.InputSystem.Controls.ButtonControl<volumeUp>k__BackingField  // 0x1B8
  private           UnityEngine.InputSystem.Controls.ButtonControl<recentered>k__BackingField  // 0x1C0
  private           UnityEngine.InputSystem.Controls.ButtonControl<volumeDown>k__BackingField  // 0x1C8
  private           UnityEngine.InputSystem.Controls.ButtonControl<recentering>k__BackingField  // 0x1D0
  private           UnityEngine.InputSystem.Controls.ButtonControl<app>k__BackingField  // 0x1D8
  private           UnityEngine.InputSystem.Controls.ButtonControl<home>k__BackingField  // 0x1E0
  private           UnityEngine.InputSystem.Controls.ButtonControl<touchpadClicked>k__BackingField  // 0x1E8
  private           UnityEngine.InputSystem.Controls.ButtonControl<touchpadTouched>k__BackingField  // 0x1F0
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceVelocity>k__BackingField  // 0x1F8
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceAcceleration>k__BackingField  // 0x200
METHODS:
  UnityEngine.InputSystem.Controls.Vector2Control get_touchpad()
  System.Void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value)
  UnityEngine.InputSystem.Controls.ButtonControl get_volumeUp()
  System.Void set_volumeUp(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_recentered()
  System.Void set_recentered(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_volumeDown()
  System.Void set_volumeDown(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_recentering()
  System.Void set_recentering(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_app()
  System.Void set_app(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_home()
  System.Void set_home(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_touchpadClicked()
  System.Void set_touchpadClicked(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_touchpadTouched()
  System.Void set_touchpadTouched(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity()
  System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceAcceleration()
  System.Void set_deviceAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: Unity.XR.Oculus.Input.OculusHMD
TYPE:  class
TOKEN: 0x200000A
EXTENDS: XRHMD
FIELDS:
  private           UnityEngine.InputSystem.Controls.ButtonControl<userPresence>k__BackingField  // 0x1E0
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceAngularVelocity>k__BackingField  // 0x1E8
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceAcceleration>k__BackingField  // 0x1F0
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceAngularAcceleration>k__BackingField  // 0x1F8
  private           UnityEngine.InputSystem.Controls.Vector3Control<leftEyeAngularVelocity>k__BackingField  // 0x200
  private           UnityEngine.InputSystem.Controls.Vector3Control<leftEyeAcceleration>k__BackingField  // 0x208
  private           UnityEngine.InputSystem.Controls.Vector3Control<leftEyeAngularAcceleration>k__BackingField  // 0x210
  private           UnityEngine.InputSystem.Controls.Vector3Control<rightEyeAngularVelocity>k__BackingField  // 0x218
  private           UnityEngine.InputSystem.Controls.Vector3Control<rightEyeAcceleration>k__BackingField  // 0x220
  private           UnityEngine.InputSystem.Controls.Vector3Control<rightEyeAngularAcceleration>k__BackingField  // 0x228
  private           UnityEngine.InputSystem.Controls.Vector3Control<centerEyeAngularVelocity>k__BackingField  // 0x230
  private           UnityEngine.InputSystem.Controls.Vector3Control<centerEyeAcceleration>k__BackingField  // 0x238
  private           UnityEngine.InputSystem.Controls.Vector3Control<centerEyeAngularAcceleration>k__BackingField  // 0x240
METHODS:
  UnityEngine.InputSystem.Controls.ButtonControl get_userPresence()
  System.Void set_userPresence(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity()
  System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceAcceleration()
  System.Void set_deviceAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularAcceleration()
  System.Void set_deviceAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeAngularVelocity()
  System.Void set_leftEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeAcceleration()
  System.Void set_leftEyeAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeAngularAcceleration()
  System.Void set_leftEyeAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeAngularVelocity()
  System.Void set_rightEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeAcceleration()
  System.Void set_rightEyeAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeAngularAcceleration()
  System.Void set_rightEyeAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeAngularVelocity()
  System.Void set_centerEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeAcceleration()
  System.Void set_centerEyeAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeAngularAcceleration()
  System.Void set_centerEyeAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: Unity.XR.Oculus.Input.OculusTouchController
TYPE:  class
TOKEN: 0x200000B
EXTENDS: XRControllerWithRumble
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector2Control<thumbstick>k__BackingField  // 0x1B0
  private           UnityEngine.InputSystem.Controls.AxisControl<trigger>k__BackingField  // 0x1B8
  private           UnityEngine.InputSystem.Controls.AxisControl<grip>k__BackingField  // 0x1C0
  private           UnityEngine.InputSystem.Controls.ButtonControl<primaryButton>k__BackingField  // 0x1C8
  private           UnityEngine.InputSystem.Controls.ButtonControl<secondaryButton>k__BackingField  // 0x1D0
  private           UnityEngine.InputSystem.Controls.ButtonControl<gripPressed>k__BackingField  // 0x1D8
  private           UnityEngine.InputSystem.Controls.ButtonControl<start>k__BackingField  // 0x1E0
  private           UnityEngine.InputSystem.Controls.ButtonControl<thumbstickClicked>k__BackingField  // 0x1E8
  private           UnityEngine.InputSystem.Controls.ButtonControl<primaryTouched>k__BackingField  // 0x1F0
  private           UnityEngine.InputSystem.Controls.ButtonControl<secondaryTouched>k__BackingField  // 0x1F8
  private           UnityEngine.InputSystem.Controls.AxisControl<triggerTouched>k__BackingField  // 0x200
  private           UnityEngine.InputSystem.Controls.ButtonControl<triggerPressed>k__BackingField  // 0x208
  private           UnityEngine.InputSystem.Controls.ButtonControl<thumbstickTouched>k__BackingField  // 0x210
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceVelocity>k__BackingField  // 0x218
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceAngularVelocity>k__BackingField  // 0x220
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceAcceleration>k__BackingField  // 0x228
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceAngularAcceleration>k__BackingField  // 0x230
METHODS:
  UnityEngine.InputSystem.Controls.Vector2Control get_thumbstick()
  System.Void set_thumbstick(UnityEngine.InputSystem.Controls.Vector2Control value)
  UnityEngine.InputSystem.Controls.AxisControl get_trigger()
  System.Void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_grip()
  System.Void set_grip(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_primaryButton()
  System.Void set_primaryButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_secondaryButton()
  System.Void set_secondaryButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed()
  System.Void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_start()
  System.Void set_start(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_thumbstickClicked()
  System.Void set_thumbstickClicked(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_primaryTouched()
  System.Void set_primaryTouched(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_secondaryTouched()
  System.Void set_secondaryTouched(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_triggerTouched()
  System.Void set_triggerTouched(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed()
  System.Void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_thumbstickTouched()
  System.Void set_thumbstickTouched(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity()
  System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity()
  System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceAcceleration()
  System.Void set_deviceAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularAcceleration()
  System.Void set_deviceAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: Unity.XR.Oculus.Input.OculusTrackingReference
TYPE:  class
TOKEN: 0x200000C
EXTENDS: TrackedDevice
FIELDS:
  private           UnityEngine.InputSystem.Controls.IntegerControl<trackingState>k__BackingField  // 0x1B0
  private           UnityEngine.InputSystem.Controls.ButtonControl<isTracked>k__BackingField  // 0x1B8
METHODS:
  UnityEngine.InputSystem.Controls.IntegerControl get_trackingState()
  System.Void set_trackingState(UnityEngine.InputSystem.Controls.IntegerControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_isTracked()
  System.Void set_isTracked(UnityEngine.InputSystem.Controls.ButtonControl value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: Unity.XR.Oculus.Input.OculusRemote
TYPE:  class
TOKEN: 0x200000D
EXTENDS: InputDevice
FIELDS:
  private           UnityEngine.InputSystem.Controls.ButtonControl<back>k__BackingField  // 0x190
  private           UnityEngine.InputSystem.Controls.ButtonControl<start>k__BackingField  // 0x198
  private           UnityEngine.InputSystem.Controls.Vector2Control<touchpad>k__BackingField  // 0x1A0
METHODS:
  UnityEngine.InputSystem.Controls.ButtonControl get_back()
  System.Void set_back(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_start()
  System.Void set_start(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.Vector2Control get_touchpad()
  System.Void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: Unity.XR.Oculus.Input.OculusHMDExtended
TYPE:  class
TOKEN: 0x200000E
EXTENDS: OculusHMD
FIELDS:
  private           UnityEngine.InputSystem.Controls.ButtonControl<back>k__BackingField  // 0x248
  private           UnityEngine.InputSystem.Controls.Vector2Control<touchpad>k__BackingField  // 0x250
METHODS:
  UnityEngine.InputSystem.Controls.ButtonControl get_back()
  System.Void set_back(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.Vector2Control get_touchpad()
  System.Void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: Unity.XR.Oculus.Input.GearVRTrackedController
TYPE:  class
TOKEN: 0x200000F
EXTENDS: XRController
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector2Control<touchpad>k__BackingField  // 0x1B0
  private           UnityEngine.InputSystem.Controls.AxisControl<trigger>k__BackingField  // 0x1B8
  private           UnityEngine.InputSystem.Controls.ButtonControl<back>k__BackingField  // 0x1C0
  private           UnityEngine.InputSystem.Controls.ButtonControl<triggerPressed>k__BackingField  // 0x1C8
  private           UnityEngine.InputSystem.Controls.ButtonControl<touchpadClicked>k__BackingField  // 0x1D0
  private           UnityEngine.InputSystem.Controls.ButtonControl<touchpadTouched>k__BackingField  // 0x1D8
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceAngularVelocity>k__BackingField  // 0x1E0
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceAcceleration>k__BackingField  // 0x1E8
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceAngularAcceleration>k__BackingField  // 0x1F0
METHODS:
  UnityEngine.InputSystem.Controls.Vector2Control get_touchpad()
  System.Void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value)
  UnityEngine.InputSystem.Controls.AxisControl get_trigger()
  System.Void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_back()
  System.Void set_back(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed()
  System.Void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_touchpadClicked()
  System.Void set_touchpadClicked(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_touchpadTouched()
  System.Void set_touchpadTouched(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity()
  System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceAcceleration()
  System.Void set_deviceAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularAcceleration()
  System.Void set_deviceAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: Unity.XR.OpenVR.OpenVRHMD
TYPE:  class
TOKEN: 0x2000003
EXTENDS: XRHMD
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceVelocity>k__BackingField  // 0x1E0
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceAngularVelocity>k__BackingField  // 0x1E8
  private           UnityEngine.InputSystem.Controls.Vector3Control<leftEyeVelocity>k__BackingField  // 0x1F0
  private           UnityEngine.InputSystem.Controls.Vector3Control<leftEyeAngularVelocity>k__BackingField  // 0x1F8
  private           UnityEngine.InputSystem.Controls.Vector3Control<rightEyeVelocity>k__BackingField  // 0x200
  private           UnityEngine.InputSystem.Controls.Vector3Control<rightEyeAngularVelocity>k__BackingField  // 0x208
  private           UnityEngine.InputSystem.Controls.Vector3Control<centerEyeVelocity>k__BackingField  // 0x210
  private           UnityEngine.InputSystem.Controls.Vector3Control<centerEyeAngularVelocity>k__BackingField  // 0x218
METHODS:
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity()
  System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity()
  System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeVelocity()
  System.Void set_leftEyeVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeAngularVelocity()
  System.Void set_leftEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeVelocity()
  System.Void set_rightEyeVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeAngularVelocity()
  System.Void set_rightEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeVelocity()
  System.Void set_centerEyeVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeAngularVelocity()
  System.Void set_centerEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: Unity.XR.OpenVR.OpenVRControllerWMR
TYPE:  class
TOKEN: 0x2000004
EXTENDS: XRController
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceVelocity>k__BackingField  // 0x1B0
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceAngularVelocity>k__BackingField  // 0x1B8
  private           UnityEngine.InputSystem.Controls.ButtonControl<touchpadClick>k__BackingField  // 0x1C0
  private           UnityEngine.InputSystem.Controls.ButtonControl<touchpadTouch>k__BackingField  // 0x1C8
  private           UnityEngine.InputSystem.Controls.ButtonControl<gripPressed>k__BackingField  // 0x1D0
  private           UnityEngine.InputSystem.Controls.ButtonControl<triggerPressed>k__BackingField  // 0x1D8
  private           UnityEngine.InputSystem.Controls.ButtonControl<menu>k__BackingField  // 0x1E0
  private           UnityEngine.InputSystem.Controls.AxisControl<trigger>k__BackingField  // 0x1E8
  private           UnityEngine.InputSystem.Controls.AxisControl<grip>k__BackingField  // 0x1F0
  private           UnityEngine.InputSystem.Controls.Vector2Control<touchpad>k__BackingField  // 0x1F8
  private           UnityEngine.InputSystem.Controls.Vector2Control<joystick>k__BackingField  // 0x200
METHODS:
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity()
  System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity()
  System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.ButtonControl get_touchpadClick()
  System.Void set_touchpadClick(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_touchpadTouch()
  System.Void set_touchpadTouch(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed()
  System.Void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed()
  System.Void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_menu()
  System.Void set_menu(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_trigger()
  System.Void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_grip()
  System.Void set_grip(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.Vector2Control get_touchpad()
  System.Void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value)
  UnityEngine.InputSystem.Controls.Vector2Control get_joystick()
  System.Void set_joystick(UnityEngine.InputSystem.Controls.Vector2Control value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: Unity.XR.OpenVR.ViveWand
TYPE:  class
TOKEN: 0x2000005
EXTENDS: XRControllerWithRumble
FIELDS:
  private           UnityEngine.InputSystem.Controls.AxisControl<grip>k__BackingField  // 0x1B0
  private           UnityEngine.InputSystem.Controls.ButtonControl<gripPressed>k__BackingField  // 0x1B8
  private           UnityEngine.InputSystem.Controls.ButtonControl<primary>k__BackingField  // 0x1C0
  private           UnityEngine.InputSystem.Controls.ButtonControl<trackpadPressed>k__BackingField  // 0x1C8
  private           UnityEngine.InputSystem.Controls.ButtonControl<trackpadTouched>k__BackingField  // 0x1D0
  private           UnityEngine.InputSystem.Controls.Vector2Control<trackpad>k__BackingField  // 0x1D8
  private           UnityEngine.InputSystem.Controls.AxisControl<trigger>k__BackingField  // 0x1E0
  private           UnityEngine.InputSystem.Controls.ButtonControl<triggerPressed>k__BackingField  // 0x1E8
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceVelocity>k__BackingField  // 0x1F0
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceAngularVelocity>k__BackingField  // 0x1F8
METHODS:
  UnityEngine.InputSystem.Controls.AxisControl get_grip()
  System.Void set_grip(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed()
  System.Void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_primary()
  System.Void set_primary(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_trackpadPressed()
  System.Void set_trackpadPressed(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_trackpadTouched()
  System.Void set_trackpadTouched(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.Vector2Control get_trackpad()
  System.Void set_trackpad(UnityEngine.InputSystem.Controls.Vector2Control value)
  UnityEngine.InputSystem.Controls.AxisControl get_trigger()
  System.Void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed()
  System.Void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity()
  System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity()
  System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: Unity.XR.OpenVR.ViveLighthouse
TYPE:  class
TOKEN: 0x2000006
EXTENDS: TrackedDevice
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.XR.OpenVR.ViveTracker
TYPE:  class
TOKEN: 0x2000007
EXTENDS: TrackedDevice
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceVelocity>k__BackingField  // 0x1B0
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceAngularVelocity>k__BackingField  // 0x1B8
METHODS:
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity()
  System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity()
  System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: Unity.XR.OpenVR.HandedViveTracker
TYPE:  class
TOKEN: 0x2000008
EXTENDS: ViveTracker
FIELDS:
  private           UnityEngine.InputSystem.Controls.AxisControl<grip>k__BackingField  // 0x1C0
  private           UnityEngine.InputSystem.Controls.ButtonControl<gripPressed>k__BackingField  // 0x1C8
  private           UnityEngine.InputSystem.Controls.ButtonControl<primary>k__BackingField  // 0x1D0
  private           UnityEngine.InputSystem.Controls.ButtonControl<trackpadPressed>k__BackingField  // 0x1D8
  private           UnityEngine.InputSystem.Controls.ButtonControl<triggerPressed>k__BackingField  // 0x1E0
METHODS:
  UnityEngine.InputSystem.Controls.AxisControl get_grip()
  System.Void set_grip(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed()
  System.Void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_primary()
  System.Void set_primary(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_trackpadPressed()
  System.Void set_trackpadPressed(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed()
  System.Void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: Unity.XR.OpenVR.OpenVROculusTouchController
TYPE:  class
TOKEN: 0x2000009
EXTENDS: XRControllerWithRumble
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector2Control<thumbstick>k__BackingField  // 0x1B0
  private           UnityEngine.InputSystem.Controls.AxisControl<trigger>k__BackingField  // 0x1B8
  private           UnityEngine.InputSystem.Controls.AxisControl<grip>k__BackingField  // 0x1C0
  private           UnityEngine.InputSystem.Controls.ButtonControl<primaryButton>k__BackingField  // 0x1C8
  private           UnityEngine.InputSystem.Controls.ButtonControl<secondaryButton>k__BackingField  // 0x1D0
  private           UnityEngine.InputSystem.Controls.ButtonControl<gripPressed>k__BackingField  // 0x1D8
  private           UnityEngine.InputSystem.Controls.ButtonControl<triggerPressed>k__BackingField  // 0x1E0
  private           UnityEngine.InputSystem.Controls.ButtonControl<thumbstickClicked>k__BackingField  // 0x1E8
  private           UnityEngine.InputSystem.Controls.ButtonControl<thumbstickTouched>k__BackingField  // 0x1F0
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceVelocity>k__BackingField  // 0x1F8
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceAngularVelocity>k__BackingField  // 0x200
METHODS:
  UnityEngine.InputSystem.Controls.Vector2Control get_thumbstick()
  System.Void set_thumbstick(UnityEngine.InputSystem.Controls.Vector2Control value)
  UnityEngine.InputSystem.Controls.AxisControl get_trigger()
  System.Void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_grip()
  System.Void set_grip(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_primaryButton()
  System.Void set_primaryButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_secondaryButton()
  System.Void set_secondaryButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed()
  System.Void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed()
  System.Void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_thumbstickClicked()
  System.Void set_thumbstickClicked(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_thumbstickTouched()
  System.Void set_thumbstickTouched(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity()
  System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity()
  System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.IInputActionCollection
TYPE:  interface
TOKEN: 0x2000015
FIELDS:
METHODS:
  System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask()
  System.Void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value)
  System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices()
  System.Void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes()
  System.Boolean Contains(UnityEngine.InputSystem.InputAction action)
  System.Void Enable()
  System.Void Disable()
END_CLASS

CLASS: UnityEngine.InputSystem.IInputActionCollection2
TYPE:  interface
TOKEN: 0x2000016
FIELDS:
METHODS:
  System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings()
  UnityEngine.InputSystem.InputAction FindAction(System.String actionNameOrId, System.Boolean throwIfNotFound)
  System.Int32 FindBinding(UnityEngine.InputSystem.InputBinding mask, UnityEngine.InputSystem.InputAction& action)
END_CLASS

CLASS: UnityEngine.InputSystem.IInputInteraction
TYPE:  interface
TOKEN: 0x2000017
FIELDS:
METHODS:
  System.Void Process(UnityEngine.InputSystem.InputInteractionContext& context)
  System.Void Reset()
END_CLASS

CLASS: UnityEngine.InputSystem.IInputInteraction`1
TYPE:  interface
TOKEN: 0x2000018
FIELDS:
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.InputInteraction
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  public    static  UnityEngine.InputSystem.Utilities.TypeTables_Interactions  // 0x0
METHODS:
  System.Type GetValueType(System.Type interactionType)
  System.String GetDisplayName(System.String interaction)
  System.String GetDisplayName(System.Type interactionType)
END_CLASS

CLASS: UnityEngine.InputSystem.InputAction
TYPE:  class
TOKEN: 0x200001A
FIELDS:
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputActionEnableProfilerMarker  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputActionDisableProfilerMarker  // 0x8
  private           System.String                   m_Name  // 0x10
  private           UnityEngine.InputSystem.InputActionTypem_Type  // 0x18
  private           System.String                   m_ExpectedControlType  // 0x20
  private           System.String                   m_Id  // 0x28
  private           System.String                   m_Processors  // 0x30
  private           System.String                   m_Interactions  // 0x38
  private           UnityEngine.InputSystem.InputBinding[]m_SingletonActionBindings  // 0x40
  private           UnityEngine.InputSystem.InputAction.ActionFlagsm_Flags  // 0x48
  private           System.Nullable<UnityEngine.InputSystem.InputBinding>m_BindingMask  // 0x50
  private           System.Int32                    m_BindingsStartIndex  // 0xB0
  private           System.Int32                    m_BindingsCount  // 0xB4
  private           System.Int32                    m_ControlStartIndex  // 0xB8
  private           System.Int32                    m_ControlCount  // 0xBC
  private           System.Int32                    m_ActionIndexInState  // 0xC0
  private           UnityEngine.InputSystem.InputActionMapm_ActionMap  // 0xC8
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>>m_OnStarted  // 0xD0
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>>m_OnCanceled  // 0x120
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>>m_OnPerformed  // 0x170
METHODS:
  System.String get_name()
  UnityEngine.InputSystem.InputActionType get_type()
  System.Guid get_id()
  System.Guid get_idDontGenerate()
  System.String get_expectedControlType()
  System.Void set_expectedControlType(System.String value)
  System.String get_processors()
  System.String get_interactions()
  UnityEngine.InputSystem.InputActionMap get_actionMap()
  System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask()
  System.Void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> get_bindings()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_controls()
  UnityEngine.InputSystem.InputActionPhase get_phase()
  System.Boolean get_inProgress()
  System.Boolean get_enabled()
  System.Void add_started(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value)
  System.Void remove_started(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value)
  System.Void add_canceled(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value)
  System.Void remove_canceled(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value)
  System.Void add_performed(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value)
  System.Void remove_performed(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value)
  System.Boolean get_triggered()
  UnityEngine.InputSystem.InputControl get_activeControl()
  System.Type get_activeValueType()
  System.Boolean get_wantsInitialStateCheck()
  System.Void set_wantsInitialStateCheck(System.Boolean value)
  System.Void .ctor()
  System.Void .ctor(System.String name, UnityEngine.InputSystem.InputActionType type, System.String binding, System.String interactions, System.String processors, System.String expectedControlType)
  System.Void Dispose()
  System.String ToString()
  System.Void Enable()
  System.Void Disable()
  UnityEngine.InputSystem.InputAction Clone()
  System.Object System.ICloneable.Clone()
  TValue ReadValue()
  System.Object ReadValueAsObject()
  System.Single GetControlMagnitude()
  System.Void Reset()
  System.Boolean IsPressed()
  System.Boolean IsInProgress()
  System.Int32 ExpectedFrame()
  System.Boolean WasPressedThisFrame()
  System.Boolean WasPressedThisDynamicUpdate()
  System.Boolean WasReleasedThisFrame()
  System.Boolean WasReleasedThisDynamicUpdate()
  System.Boolean WasPerformedThisFrame()
  System.Boolean WasPerformedThisDynamicUpdate()
  System.Boolean WasCompletedThisFrame()
  System.Boolean WasCompletedThisDynamicUpdate()
  System.Single GetTimeoutCompletionPercentage()
  System.Boolean get_isSingletonAction()
  UnityEngine.InputSystem.InputActionState.TriggerState get_currentState()
  System.String MakeSureIdIsInPlace()
  System.Void GenerateId()
  UnityEngine.InputSystem.InputActionMap GetOrCreateActionMap()
  System.Void CreateInternalActionMapForSingletonAction()
  System.Void RequestInitialStateCheckOnEnabledAction()
  System.Boolean ActiveControlIsValid(UnityEngine.InputSystem.InputControl control)
  System.Nullable<UnityEngine.InputSystem.InputBinding> FindEffectiveBindingMask()
  System.Int32 BindingIndexOnActionToBindingIndexOnMap(System.Int32 indexOfBindingOnAction)
  System.Int32 BindingIndexOnMapToBindingIndexOnAction(System.Int32 indexOfBindingOnMap)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.InputActionAsset
TYPE:  class
TOKEN: 0x200001D
EXTENDS: ScriptableObject
FIELDS:
  public    static  System.String                   Extension  // 0x0
  private   static  System.String                   kDefaultAssetLayoutJson  // 0x0
  private           UnityEngine.InputSystem.InputActionMap[]m_ActionMaps  // 0x18
  private           UnityEngine.InputSystem.InputControlScheme[]m_ControlSchemes  // 0x20
  private           UnityEngine.InputSystem.InputActionStatem_SharedStateForAllMaps  // 0x28
  private           System.Nullable<UnityEngine.InputSystem.InputBinding>m_BindingMask  // 0x30
  private           System.Int32                    m_ParameterOverridesCount  // 0x90
  private           UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[]m_ParameterOverrides  // 0x98
  private           UnityEngine.InputSystem.InputActionMap.DeviceArraym_Devices  // 0xA0
METHODS:
  System.Boolean get_enabled()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputActionMap> get_actionMaps()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes()
  System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings()
  System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask()
  System.Void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value)
  System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices()
  System.Void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value)
  UnityEngine.InputSystem.InputAction get_Item(System.String actionNameOrId)
  System.String ToJson()
  System.Void LoadFromJson(System.String json)
  UnityEngine.InputSystem.InputActionAsset FromJson(System.String json)
  UnityEngine.InputSystem.InputAction FindAction(System.String actionNameOrId, System.Boolean throwIfNotFound)
  System.Int32 FindBinding(UnityEngine.InputSystem.InputBinding mask, UnityEngine.InputSystem.InputAction& action)
  UnityEngine.InputSystem.InputActionMap FindActionMap(System.String nameOrId, System.Boolean throwIfNotFound)
  UnityEngine.InputSystem.InputActionMap FindActionMap(System.Guid id)
  UnityEngine.InputSystem.InputAction FindAction(System.Guid guid)
  System.Int32 FindControlSchemeIndex(System.String name)
  System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlScheme(System.String name)
  System.Boolean IsUsableWithDevice(UnityEngine.InputSystem.InputDevice device)
  System.Void Enable()
  System.Void Disable()
  System.Boolean Contains(UnityEngine.InputSystem.InputAction action)
  System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void MarkAsDirty()
  System.Boolean IsEmpty()
  System.Void OnWantToChangeSetup()
  System.Void OnSetupChanged()
  System.Void ReResolveIfNecessary(System.Boolean fullResolve)
  System.Void ResolveBindingsIfNecessary()
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.InputActionChange
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputActionChangeActionEnabled  // 0x0
  public    static  UnityEngine.InputSystem.InputActionChangeActionDisabled  // 0x0
  public    static  UnityEngine.InputSystem.InputActionChangeActionMapEnabled  // 0x0
  public    static  UnityEngine.InputSystem.InputActionChangeActionMapDisabled  // 0x0
  public    static  UnityEngine.InputSystem.InputActionChangeActionStarted  // 0x0
  public    static  UnityEngine.InputSystem.InputActionChangeActionPerformed  // 0x0
  public    static  UnityEngine.InputSystem.InputActionChangeActionCanceled  // 0x0
  public    static  UnityEngine.InputSystem.InputActionChangeBoundControlsAboutToChange  // 0x0
  public    static  UnityEngine.InputSystem.InputActionChangeBoundControlsChanged  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.InputActionMap
TYPE:  class
TOKEN: 0x2000024
FIELDS:
  private   static readonly Unity.Profiling.ProfilerMarker  k_ResolveBindingsProfilerMarker  // 0x0
  private           System.String                   m_Name  // 0x10
  private           System.String                   m_Id  // 0x18
  private           UnityEngine.InputSystem.InputActionAssetm_Asset  // 0x20
  private           UnityEngine.InputSystem.InputAction[]m_Actions  // 0x28
  private           UnityEngine.InputSystem.InputBinding[]m_Bindings  // 0x30
  private           UnityEngine.InputSystem.InputBinding[]m_BindingsForEachAction  // 0x38
  private           UnityEngine.InputSystem.InputControl[]m_ControlsForEachAction  // 0x40
  private           System.Int32                    m_EnabledActionsCount  // 0x48
  private           UnityEngine.InputSystem.InputActionm_SingletonAction  // 0x50
  private           System.Int32                    m_MapIndexInState  // 0x58
  private           UnityEngine.InputSystem.InputActionStatem_State  // 0x60
  private           System.Nullable<UnityEngine.InputSystem.InputBinding>m_BindingMask  // 0x68
  private           UnityEngine.InputSystem.InputActionMap.Flagsm_Flags  // 0xC8
  private           System.Int32                    m_ParameterOverridesCount  // 0xCC
  private           UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[]m_ParameterOverrides  // 0xD0
  private           UnityEngine.InputSystem.InputActionMap.DeviceArraym_Devices  // 0xD8
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>>m_ActionCallbacks  // 0xE8
  private           System.Collections.Generic.Dictionary<System.String,System.Int32>m_ActionIndexByNameOrId  // 0x138
  private   static  System.Int32                    s_DeferBindingResolution  // 0x8
  private   static  System.Boolean                  s_NeedToResolveBindings  // 0xC
METHODS:
  System.String get_name()
  UnityEngine.InputSystem.InputActionAsset get_asset()
  System.Guid get_id()
  System.Guid get_idDontGenerate()
  System.Boolean get_enabled()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputAction> get_actions()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> get_bindings()
  System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> UnityEngine.InputSystem.IInputActionCollection2.get_bindings()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes()
  System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask()
  System.Void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value)
  System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices()
  System.Void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value)
  UnityEngine.InputSystem.InputAction get_Item(System.String actionNameOrId)
  System.Void add_actionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value)
  System.Void remove_actionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value)
  System.Void .ctor()
  System.Void .ctor(System.String name)
  System.Void Dispose()
  System.Int32 FindActionIndex(System.String nameOrId)
  System.Void SetUpActionLookupTable()
  System.Void ClearActionLookupTable()
  System.Int32 FindActionIndex(System.Guid id)
  UnityEngine.InputSystem.InputAction FindAction(System.String actionNameOrId, System.Boolean throwIfNotFound)
  UnityEngine.InputSystem.InputAction FindAction(System.Guid id)
  System.Boolean IsUsableWithDevice(UnityEngine.InputSystem.InputDevice device)
  System.Void Enable()
  System.Void Disable()
  UnityEngine.InputSystem.InputActionMap Clone()
  System.Object System.ICloneable.Clone()
  System.Boolean Contains(UnityEngine.InputSystem.InputAction action)
  System.String ToString()
  System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Boolean get_needToResolveBindings()
  System.Void set_needToResolveBindings(System.Boolean value)
  System.Boolean get_bindingResolutionNeedsFullReResolve()
  System.Void set_bindingResolutionNeedsFullReResolve(System.Boolean value)
  System.Boolean get_controlsForEachActionInitialized()
  System.Void set_controlsForEachActionInitialized(System.Boolean value)
  System.Boolean get_bindingsForEachActionInitialized()
  System.Void set_bindingsForEachActionInitialized(System.Boolean value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> GetBindingsForSingleAction(UnityEngine.InputSystem.InputAction action)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> GetControlsForSingleAction(UnityEngine.InputSystem.InputAction action)
  System.Void SetUpPerActionControlAndBindingArrays()
  System.Void OnWantToChangeSetup()
  System.Void OnSetupChanged()
  System.Void OnBindingModified()
  System.Void ClearCachedActionData(System.Boolean onlyControls)
  System.Void GenerateId()
  System.Boolean LazyResolveBindings(System.Boolean fullResolve)
  System.Boolean ResolveBindingsIfNecessary()
  System.Void ResolveBindings()
  System.Int32 FindBinding(UnityEngine.InputSystem.InputBinding mask, UnityEngine.InputSystem.InputAction& action)
  System.Int32 FindBindingRelativeToMap(UnityEngine.InputSystem.InputBinding mask)
  UnityEngine.InputSystem.InputActionMap[] FromJson(System.String json)
  System.String ToJson(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionMap> maps)
  System.String ToJson()
  System.Void OnBeforeSerialize()
  System.Void OnAfterDeserialize()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.InputActionRebindingExtensions
TYPE:  class
TOKEN: 0x2000030
FIELDS:
  private   static  UnityEngine.InputSystem.InputActionRebindingExtensions.DeferBindingResolutionWrappers_DeferBindingResolutionWrapper  // 0x0
METHODS:
  System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(UnityEngine.InputSystem.InputAction action, System.String name, UnityEngine.InputSystem.InputBinding bindingMask)
  System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameterOverride)
  System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(UnityEngine.InputSystem.InputAction action, System.String name, System.Int32 bindingIndex)
  System.Nullable<TValue> GetParameterValue(UnityEngine.InputSystem.InputAction action, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, UnityEngine.InputSystem.InputBinding bindingMask)
  System.Void ApplyParameterOverride(UnityEngine.InputSystem.InputAction action, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, UnityEngine.InputSystem.InputBinding bindingMask)
  System.Void ApplyParameterOverride(UnityEngine.InputSystem.InputActionMap actionMap, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, UnityEngine.InputSystem.InputBinding bindingMask)
  System.Void ApplyParameterOverride(UnityEngine.InputSystem.InputActionAsset asset, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, UnityEngine.InputSystem.InputBinding bindingMask)
  UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride ExtractParameterOverride(System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.Utilities.PrimitiveValue value)
  System.Void ApplyParameterOverride(UnityEngine.InputSystem.InputActionMap actionMap, System.String name, UnityEngine.InputSystem.Utilities.PrimitiveValue value, UnityEngine.InputSystem.InputBinding bindingMask)
  System.Void ApplyParameterOverride(UnityEngine.InputSystem.InputActionAsset asset, System.String name, UnityEngine.InputSystem.Utilities.PrimitiveValue value, UnityEngine.InputSystem.InputBinding bindingMask)
  System.Void ApplyParameterOverride(UnityEngine.InputSystem.InputAction action, System.String name, UnityEngine.InputSystem.Utilities.PrimitiveValue value, UnityEngine.InputSystem.InputBinding bindingMask)
  System.Void ApplyParameterOverride(UnityEngine.InputSystem.InputAction action, System.String name, UnityEngine.InputSystem.Utilities.PrimitiveValue value, System.Int32 bindingIndex)
  System.Void ApplyParameterOverride(UnityEngine.InputSystem.InputActionState state, System.Int32 mapIndex, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[]& parameterOverrides, System.Int32& parameterOverridesCount, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameterOverride)
  System.Int32 GetBindingIndex(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding bindingMask)
  System.Int32 GetBindingIndex(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding bindingMask)
  System.Int32 GetBindingIndex(UnityEngine.InputSystem.InputAction action, System.String group, System.String path)
  System.Nullable<UnityEngine.InputSystem.InputBinding> GetBindingForControl(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputControl control)
  System.Int32 GetBindingIndexForControl(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputControl control)
  System.String GetBindingDisplayString(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options, System.String group)
  System.String GetBindingDisplayString(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options)
  System.String GetBindingDisplayString(UnityEngine.InputSystem.InputAction action, System.Int32 bindingIndex, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options)
  System.String GetBindingDisplayString(UnityEngine.InputSystem.InputAction action, System.Int32 bindingIndex, System.String& deviceLayoutName, System.String& controlPath, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options)
  System.Void ApplyBindingOverride(UnityEngine.InputSystem.InputAction action, System.String newPath, System.String group, System.String path)
  System.Void ApplyBindingOverride(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding bindingOverride)
  System.Void ApplyBindingOverride(UnityEngine.InputSystem.InputAction action, System.Int32 bindingIndex, UnityEngine.InputSystem.InputBinding bindingOverride)
  System.Void ApplyBindingOverride(UnityEngine.InputSystem.InputAction action, System.Int32 bindingIndex, System.String path)
  System.Int32 ApplyBindingOverride(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding bindingOverride)
  System.Void ApplyBindingOverride(UnityEngine.InputSystem.InputActionMap actionMap, System.Int32 bindingIndex, UnityEngine.InputSystem.InputBinding bindingOverride)
  System.Void RemoveBindingOverride(UnityEngine.InputSystem.InputAction action, System.Int32 bindingIndex)
  System.Void RemoveBindingOverride(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding bindingMask)
  System.Void RemoveBindingOverride(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding bindingMask)
  System.Void RemoveAllBindingOverrides(UnityEngine.InputSystem.IInputActionCollection2 actions)
  System.Void RemoveAllBindingOverrides(UnityEngine.InputSystem.InputAction action)
  System.Void ApplyBindingOverrides(UnityEngine.InputSystem.InputActionMap actionMap, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> overrides)
  System.Void RemoveBindingOverrides(UnityEngine.InputSystem.InputActionMap actionMap, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> overrides)
  System.Int32 ApplyBindingOverridesOnMatchingControls(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputControl control)
  System.Int32 ApplyBindingOverridesOnMatchingControls(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputControl control)
  System.String SaveBindingOverridesAsJson(UnityEngine.InputSystem.IInputActionCollection2 actions)
  System.String SaveBindingOverridesAsJson(UnityEngine.InputSystem.InputAction action)
  System.Void AddBindingOverrideJsonTo(UnityEngine.InputSystem.IInputActionCollection2 actions, UnityEngine.InputSystem.InputBinding binding, System.Collections.Generic.List<UnityEngine.InputSystem.InputActionMap.BindingOverrideJson> list, UnityEngine.InputSystem.InputAction action)
  System.Void LoadBindingOverridesFromJson(UnityEngine.InputSystem.IInputActionCollection2 actions, System.String json, System.Boolean removeExisting)
  System.Void LoadBindingOverridesFromJson(UnityEngine.InputSystem.InputAction action, System.String json, System.Boolean removeExisting)
  System.Void LoadBindingOverridesFromJsonInternal(UnityEngine.InputSystem.IInputActionCollection2 actions, System.String json)
  UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation PerformInteractiveRebinding(UnityEngine.InputSystem.InputAction action, System.Int32 bindingIndex)
  UnityEngine.InputSystem.InputActionRebindingExtensions.DeferBindingResolutionWrapper DeferBindingResolution()
END_CLASS

CLASS: UnityEngine.InputSystem.InputActionPhase
TYPE:  struct
TOKEN: 0x200003A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputActionPhaseDisabled  // 0x0
  public    static  UnityEngine.InputSystem.InputActionPhaseWaiting  // 0x0
  public    static  UnityEngine.InputSystem.InputActionPhaseStarted  // 0x0
  public    static  UnityEngine.InputSystem.InputActionPhasePerformed  // 0x0
  public    static  UnityEngine.InputSystem.InputActionPhaseCanceled  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.InputActionProperty
TYPE:  struct
TOKEN: 0x200003B
FIELDS:
  private           System.Boolean                  m_UseReference  // 0x10
  private           UnityEngine.InputSystem.InputActionm_Action  // 0x18
  private           UnityEngine.InputSystem.InputActionReferencem_Reference  // 0x20
METHODS:
  UnityEngine.InputSystem.InputAction get_action()
  UnityEngine.InputSystem.InputActionReference get_reference()
  UnityEngine.InputSystem.InputAction get_serializedAction()
  UnityEngine.InputSystem.InputActionReference get_serializedReference()
  System.Void .ctor(UnityEngine.InputSystem.InputAction action)
  System.Void .ctor(UnityEngine.InputSystem.InputActionReference reference)
  System.Boolean Equals(UnityEngine.InputSystem.InputActionProperty other)
  System.Boolean Equals(UnityEngine.InputSystem.InputAction other)
  System.Boolean Equals(UnityEngine.InputSystem.InputActionReference other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.InputSystem.InputActionProperty left, UnityEngine.InputSystem.InputActionProperty right)
  System.Boolean op_Inequality(UnityEngine.InputSystem.InputActionProperty left, UnityEngine.InputSystem.InputActionProperty right)
END_CLASS

CLASS: UnityEngine.InputSystem.InputActionReference
TYPE:  class
TOKEN: 0x200003C
EXTENDS: ScriptableObject
FIELDS:
  private           UnityEngine.InputSystem.InputActionAssetm_Asset  // 0x18
  private           System.String                   m_ActionId  // 0x20
  private           UnityEngine.InputSystem.InputActionm_Action  // 0x28
METHODS:
  UnityEngine.InputSystem.InputActionAsset get_asset()
  UnityEngine.InputSystem.InputAction get_action()
  System.Void Set(UnityEngine.InputSystem.InputAction action)
  System.Void Set(UnityEngine.InputSystem.InputActionAsset asset, System.String mapName, System.String actionName)
  System.Void SetInternal(UnityEngine.InputSystem.InputActionAsset asset, UnityEngine.InputSystem.InputAction action)
  System.String ToString()
  System.String GetDisplayName(UnityEngine.InputSystem.InputAction action)
  System.String ToDisplayName()
  UnityEngine.InputSystem.InputAction op_Implicit(UnityEngine.InputSystem.InputActionReference reference)
  UnityEngine.InputSystem.InputActionReference Create(UnityEngine.InputSystem.InputAction action)
  System.Void ResetCachedAction()
  UnityEngine.InputSystem.InputAction ToInputAction()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.InputActionSetupExtensions
TYPE:  class
TOKEN: 0x200003D
FIELDS:
METHODS:
  UnityEngine.InputSystem.InputActionMap AddActionMap(UnityEngine.InputSystem.InputActionAsset asset, System.String name)
  System.Void AddActionMap(UnityEngine.InputSystem.InputActionAsset asset, UnityEngine.InputSystem.InputActionMap map)
  System.Void RemoveActionMap(UnityEngine.InputSystem.InputActionAsset asset, UnityEngine.InputSystem.InputActionMap map)
  System.Void RemoveActionMap(UnityEngine.InputSystem.InputActionAsset asset, System.String nameOrId)
  UnityEngine.InputSystem.InputAction AddAction(UnityEngine.InputSystem.InputActionMap map, System.String name, UnityEngine.InputSystem.InputActionType type, System.String binding, System.String interactions, System.String processors, System.String groups, System.String expectedControlLayout)
  System.Void RemoveAction(UnityEngine.InputSystem.InputAction action)
  System.Void RemoveAction(UnityEngine.InputSystem.InputActionAsset asset, System.String nameOrId)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputAction action, System.String path, System.String interactions, System.String processors, System.String groups)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputControl control)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding binding)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputActionMap actionMap, System.String path, System.String interactions, System.String groups, System.String action, System.String processors)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputActionMap actionMap, System.String path, UnityEngine.InputSystem.InputAction action, System.String interactions, System.String groups)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputActionMap actionMap, System.String path, System.Guid action, System.String interactions, System.String groups)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding binding)
  UnityEngine.InputSystem.InputActionSetupExtensions.CompositeSyntax AddCompositeBinding(UnityEngine.InputSystem.InputAction action, System.String composite, System.String interactions, System.String processors)
  System.Int32 AddBindingInternal(UnityEngine.InputSystem.InputActionMap map, UnityEngine.InputSystem.InputBinding binding, System.Int32 bindingIndex)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(UnityEngine.InputSystem.InputAction action, System.Int32 index)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(UnityEngine.InputSystem.InputAction action, System.String name)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(UnityEngine.InputSystem.InputActionMap actionMap, System.Int32 index)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithId(UnityEngine.InputSystem.InputAction action, System.String id)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithId(UnityEngine.InputSystem.InputAction action, System.Guid id)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithGroup(UnityEngine.InputSystem.InputAction action, System.String group)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithPath(UnityEngine.InputSystem.InputAction action, System.String path)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding match)
  UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeCompositeBinding(UnityEngine.InputSystem.InputAction action, System.String compositeName)
  System.Void Rename(UnityEngine.InputSystem.InputAction action, System.String newName)
  System.Void AddControlScheme(UnityEngine.InputSystem.InputActionAsset asset, UnityEngine.InputSystem.InputControlScheme controlScheme)
  UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax AddControlScheme(UnityEngine.InputSystem.InputActionAsset asset, System.String name)
  System.Void RemoveControlScheme(UnityEngine.InputSystem.InputActionAsset asset, System.String name)
  UnityEngine.InputSystem.InputControlScheme WithBindingGroup(UnityEngine.InputSystem.InputControlScheme scheme, System.String bindingGroup)
  UnityEngine.InputSystem.InputControlScheme WithDevice(UnityEngine.InputSystem.InputControlScheme scheme, System.String controlPath, System.Boolean required)
  UnityEngine.InputSystem.InputControlScheme WithRequiredDevice(UnityEngine.InputSystem.InputControlScheme scheme, System.String controlPath)
  UnityEngine.InputSystem.InputControlScheme WithOptionalDevice(UnityEngine.InputSystem.InputControlScheme scheme, System.String controlPath)
  UnityEngine.InputSystem.InputControlScheme OrWithRequiredDevice(UnityEngine.InputSystem.InputControlScheme scheme, System.String controlPath)
  UnityEngine.InputSystem.InputControlScheme OrWithOptionalDevice(UnityEngine.InputSystem.InputControlScheme scheme, System.String controlPath)
END_CLASS

CLASS: UnityEngine.InputSystem.InputActionState
TYPE:  class
TOKEN: 0x2000042
FIELDS:
  public    static  System.Int32                    kInvalidIndex  // 0x0
  public            UnityEngine.InputSystem.InputActionMap[]maps  // 0x10
  public            UnityEngine.InputSystem.InputControl[]controls  // 0x18
  public            UnityEngine.InputSystem.IInputInteraction[]interactions  // 0x20
  public            UnityEngine.InputSystem.InputProcessor[]processors  // 0x28
  public            UnityEngine.InputSystem.InputBindingComposite[]composites  // 0x30
  public            System.Int32                    totalProcessorCount  // 0x38
  public            UnityEngine.InputSystem.InputActionState.UnmanagedMemorymemory  // 0x40
  private           System.Boolean                  m_OnBeforeUpdateHooked  // 0xC0
  private           System.Boolean                  m_OnAfterUpdateHooked  // 0xC1
  private           System.Boolean                  m_InProcessControlStateChange  // 0xC2
  private           UnityEngine.InputSystem.LowLevel.InputEventPtrm_CurrentlyProcessingThisEvent  // 0xC8
  private           System.Action                   m_OnBeforeUpdateDelegate  // 0xD0
  private           System.Action                   m_OnAfterUpdateDelegate  // 0xD8
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputInitialActionStateCheckMarker  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputActionResolveConflictMarker  // 0x8
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputActionCallbackMarker  // 0x10
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputOnActionChangeMarker  // 0x18
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputOnDeviceChangeMarker  // 0x20
  private   static  UnityEngine.InputSystem.InputActionState.GlobalStates_GlobalState  // 0x28
METHODS:
  System.Int32 get_totalCompositeCount()
  System.Int32 get_totalMapCount()
  System.Int32 get_totalActionCount()
  System.Int32 get_totalBindingCount()
  System.Int32 get_totalInteractionCount()
  System.Int32 get_totalControlCount()
  UnityEngine.InputSystem.InputActionState.ActionMapIndices* get_mapIndices()
  UnityEngine.InputSystem.InputActionState.TriggerState* get_actionStates()
  UnityEngine.InputSystem.InputActionState.BindingState* get_bindingStates()
  UnityEngine.InputSystem.InputActionState.InteractionState* get_interactionStates()
  System.Int32* get_controlIndexToBindingIndex()
  System.UInt16* get_controlGroupingAndComplexity()
  System.Single* get_controlMagnitudes()
  System.UInt32* get_enabledControls()
  System.Boolean get_isProcessingControlStateChange()
  System.Void Initialize(UnityEngine.InputSystem.InputBindingResolver resolver)
  System.Void ComputeControlGroupingIfNecessary()
  System.Void ClaimDataFrom(UnityEngine.InputSystem.InputBindingResolver resolver)
  System.Void Finalize()
  System.Void Dispose()
  System.Void Destroy(System.Boolean isFinalizing)
  UnityEngine.InputSystem.InputActionState Clone()
  System.Object System.ICloneable.Clone()
  System.Boolean IsUsingDevice(UnityEngine.InputSystem.InputDevice device)
  System.Boolean CanUseDevice(UnityEngine.InputSystem.InputDevice device)
  System.Boolean HasEnabledActions()
  System.Void FinishBindingCompositeSetups()
  System.Void PrepareForBindingReResolution(System.Boolean needFullResolve, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl>& activeControls, System.Boolean& hasEnabledActions)
  System.Void FinishBindingResolution(System.Boolean hasEnabledActions, UnityEngine.InputSystem.InputActionState.UnmanagedMemory oldMemory, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, System.Boolean isFullResolve)
  System.Void RestoreActionStatesAfterReResolvingBindings(UnityEngine.InputSystem.InputActionState.UnmanagedMemory oldState, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, System.Boolean isFullResolve)
  System.Boolean IsActiveControl(System.Int32 bindingIndex, System.Int32 controlIndex)
  System.Int32 FindControlIndexOnBinding(System.Int32 bindingIndex, UnityEngine.InputSystem.InputControl control)
  System.Void ResetActionStatesDrivenBy(UnityEngine.InputSystem.InputDevice device)
  System.Boolean IsActionBoundToControlFromDevice(UnityEngine.InputSystem.InputDevice device, System.Int32 actionIndex)
  System.Void ResetActionState(System.Int32 actionIndex, UnityEngine.InputSystem.InputActionPhase toPhase, System.Boolean hardReset)
  UnityEngine.InputSystem.InputActionState.TriggerState& FetchActionState(UnityEngine.InputSystem.InputAction action)
  UnityEngine.InputSystem.InputActionState.ActionMapIndices FetchMapIndices(UnityEngine.InputSystem.InputActionMap map)
  System.Void EnableAllActions(UnityEngine.InputSystem.InputActionMap map)
  System.Void EnableControls(UnityEngine.InputSystem.InputActionMap map)
  System.Void EnableSingleAction(UnityEngine.InputSystem.InputAction action)
  System.Void EnableControls(UnityEngine.InputSystem.InputAction action)
  System.Void DisableAllActions(UnityEngine.InputSystem.InputActionMap map)
  System.Void DisableControls(UnityEngine.InputSystem.InputActionMap map)
  System.Void DisableSingleAction(UnityEngine.InputSystem.InputAction action)
  System.Void DisableControls(UnityEngine.InputSystem.InputAction action)
  System.Void EnableControls(System.Int32 mapIndex, System.Int32 controlStartIndex, System.Int32 numControls)
  System.Void DisableControls(System.Int32 mapIndex, System.Int32 controlStartIndex, System.Int32 numControls)
  System.Void SetInitialStateCheckPending(System.Int32 actionIndex, System.Boolean value)
  System.Void SetInitialStateCheckPending(UnityEngine.InputSystem.InputActionState.BindingState* bindingStatePtr, System.Boolean value)
  System.Boolean IsControlEnabled(System.Int32 controlIndex)
  System.Void SetControlEnabled(System.Int32 controlIndex, System.Boolean state)
  System.Void HookOnBeforeUpdate()
  System.Void UnhookOnBeforeUpdate()
  System.Void OnBeforeInitialUpdate()
  System.Void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Int64 mapControlAndBindingIndex)
  System.Void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, System.Double time, System.Int64 mapControlAndBindingIndex, System.Int32 interactionIndex)
  System.Int64 ToCombinedMapAndControlAndBindingIndex(System.Int32 mapIndex, System.Int32 controlIndex, System.Int32 bindingIndex)
  System.Void SplitUpMapAndControlAndBindingIndex(System.Int64 mapControlAndBindingIndex, System.Int32& mapIndex, System.Int32& controlIndex, System.Int32& bindingIndex)
  System.Int32 GetComplexityFromMonitorIndex(System.Int64 mapControlAndBindingIndex)
  System.Void ProcessControlStateChange(System.Int32 mapIndex, System.Int32 controlIndex, System.Int32 bindingIndex, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void ProcessButtonState(UnityEngine.InputSystem.InputActionState.TriggerState& trigger, System.Int32 actionIndex, UnityEngine.InputSystem.InputActionState.BindingState* bindingStatePtr)
  System.Boolean ShouldIgnoreInputOnCompositeBinding(UnityEngine.InputSystem.InputActionState.BindingState* binding, UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr)
  System.Boolean IsConflictingInput(UnityEngine.InputSystem.InputActionState.TriggerState& trigger, System.Int32 actionIndex)
  System.UInt16 GetActionBindingStartIndexAndCount(System.Int32 actionIndex, System.UInt16& bindingCount)
  System.Void ProcessDefaultInteraction(UnityEngine.InputSystem.InputActionState.TriggerState& trigger, System.Int32 actionIndex)
  System.Void ProcessInteractions(UnityEngine.InputSystem.InputActionState.TriggerState& trigger, System.Int32 interactionStartIndex, System.Int32 interactionCount)
  System.Void ProcessTimeout(System.Double time, System.Int32 mapIndex, System.Int32 controlIndex, System.Int32 bindingIndex, System.Int32 interactionIndex)
  System.Void SetTotalTimeoutCompletionTime(System.Single seconds, UnityEngine.InputSystem.InputActionState.TriggerState& trigger)
  System.Void StartTimeout(System.Single seconds, UnityEngine.InputSystem.InputActionState.TriggerState& trigger)
  System.Void StopTimeout(System.Int32 interactionIndex)
  System.Void ChangePhaseOfInteraction(UnityEngine.InputSystem.InputActionPhase newPhase, UnityEngine.InputSystem.InputActionState.TriggerState& trigger, UnityEngine.InputSystem.InputActionPhase phaseAfterPerformed, UnityEngine.InputSystem.InputActionPhase phaseAfterCanceled, System.Boolean processNextInteractionOnCancel)
  System.Boolean ChangePhaseOfAction(UnityEngine.InputSystem.InputActionPhase newPhase, UnityEngine.InputSystem.InputActionState.TriggerState& trigger, UnityEngine.InputSystem.InputActionPhase phaseAfterPerformedOrCanceled)
  System.Void ChangePhaseOfActionInternal(System.Int32 actionIndex, UnityEngine.InputSystem.InputActionState.TriggerState* actionState, UnityEngine.InputSystem.InputActionPhase newPhase, UnityEngine.InputSystem.InputActionState.TriggerState& trigger, System.Boolean isDisablingAction)
  System.Void CallActionListeners(System.Int32 actionIndex, UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputActionPhase phase, UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>>& listeners, System.String callbackName)
  System.Object GetActionOrNoneString(UnityEngine.InputSystem.InputActionState.TriggerState& trigger)
  UnityEngine.InputSystem.InputAction GetActionOrNull(System.Int32 bindingIndex)
  UnityEngine.InputSystem.InputAction GetActionOrNull(UnityEngine.InputSystem.InputActionState.TriggerState& trigger)
  UnityEngine.InputSystem.InputControl GetControl(UnityEngine.InputSystem.InputActionState.TriggerState& trigger)
  UnityEngine.InputSystem.IInputInteraction GetInteractionOrNull(UnityEngine.InputSystem.InputActionState.TriggerState& trigger)
  System.Int32 GetBindingIndexInMap(System.Int32 bindingIndex)
  System.Int32 GetBindingIndexInState(System.Int32 mapIndex, System.Int32 bindingIndexInMap)
  UnityEngine.InputSystem.InputActionState.BindingState& GetBindingState(System.Int32 bindingIndex)
  UnityEngine.InputSystem.InputBinding& GetBinding(System.Int32 bindingIndex)
  UnityEngine.InputSystem.InputActionMap GetActionMap(System.Int32 bindingIndex)
  System.Void ResetInteractionStateAndCancelIfNecessary(System.Int32 mapIndex, System.Int32 bindingIndex, System.Int32 interactionIndex, UnityEngine.InputSystem.InputActionPhase phaseAfterCanceled)
  System.Void ResetInteractionState(System.Int32 interactionIndex)
  System.Int32 GetValueSizeInBytes(System.Int32 bindingIndex, System.Int32 controlIndex)
  System.Type GetValueType(System.Int32 bindingIndex, System.Int32 controlIndex)
  System.Boolean IsActuated(UnityEngine.InputSystem.InputActionState.TriggerState& trigger, System.Single threshold)
  System.Void ReadValue(System.Int32 bindingIndex, System.Int32 controlIndex, System.Void* buffer, System.Int32 bufferSize, System.Boolean ignoreComposites)
  TValue ReadValue(System.Int32 bindingIndex, System.Int32 controlIndex, System.Boolean ignoreComposites)
  TValue ApplyProcessors(System.Int32 bindingIndex, TValue value, UnityEngine.InputSystem.InputControl<TValue> controlOfType)
  System.Single EvaluateCompositePartMagnitude(System.Int32 bindingIndex, System.Int32 partNumber)
  System.Double GetCompositePartPressTime(System.Int32 bindingIndex, System.Int32 partNumber)
  TValue ReadCompositePartValue(System.Int32 bindingIndex, System.Int32 partNumber, System.Boolean* buttonValuePtr, System.Int32& controlIndex, TComparer comparer)
  System.Boolean ReadCompositePartValue(System.Int32 bindingIndex, System.Int32 partNumber, System.Void* buffer, System.Int32 bufferSize)
  System.Object ReadCompositePartValueAsObject(System.Int32 bindingIndex, System.Int32 partNumber)
  System.Object ReadValueAsObject(System.Int32 bindingIndex, System.Int32 controlIndex, System.Boolean ignoreComposites)
  System.Boolean ReadValueAsButton(System.Int32 bindingIndex, System.Int32 controlIndex)
  UnityEngine.InputSystem.Utilities.ISavedState SaveAndResetState()
  System.Void AddToGlobalList()
  System.Void RemoveMapFromGlobalList()
  System.Void CompactGlobalList()
  System.Void NotifyListenersOfActionChange(UnityEngine.InputSystem.InputActionChange change)
  System.Void NotifyListenersOfActionChange(UnityEngine.InputSystem.InputActionChange change, System.Object actionOrMapOrAsset)
  System.Void ResetGlobals()
  System.Int32 FindAllEnabledActions(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> result)
  System.Void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change)
  System.Void DeferredResolutionOfBindings()
  System.Void DisableAllActions()
  System.Void DestroyAllActionMapStates()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.InputActionType
TYPE:  struct
TOKEN: 0x200004D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputActionTypeValue  // 0x0
  public    static  UnityEngine.InputSystem.InputActionTypeButton  // 0x0
  public    static  UnityEngine.InputSystem.InputActionTypePassThrough  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.InputBinding
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
  public    static  System.Char                     Separator  // 0x0
  private   static  System.String                   kSeparatorString  // 0x0
  private           System.String                   m_Name  // 0x10
  private           System.String                   m_Id  // 0x18
  private           System.String                   m_Path  // 0x20
  private           System.String                   m_Interactions  // 0x28
  private           System.String                   m_Processors  // 0x30
  private           System.String                   m_Groups  // 0x38
  private           System.String                   m_Action  // 0x40
  private           UnityEngine.InputSystem.InputBinding.Flagsm_Flags  // 0x48
  private           System.String                   m_OverridePath  // 0x50
  private           System.String                   m_OverrideInteractions  // 0x58
  private           System.String                   m_OverrideProcessors  // 0x60
METHODS:
  System.String get_name()
  System.Void set_name(System.String value)
  System.Guid get_id()
  System.Void set_id(System.Guid value)
  System.String get_path()
  System.Void set_path(System.String value)
  System.String get_overridePath()
  System.Void set_overridePath(System.String value)
  System.String get_interactions()
  System.Void set_interactions(System.String value)
  System.String get_overrideInteractions()
  System.Void set_overrideInteractions(System.String value)
  System.String get_processors()
  System.Void set_processors(System.String value)
  System.String get_overrideProcessors()
  System.Void set_overrideProcessors(System.String value)
  System.String get_groups()
  System.Void set_groups(System.String value)
  System.String get_action()
  System.Void set_action(System.String value)
  System.Boolean get_isComposite()
  System.Void set_isComposite(System.Boolean value)
  System.Boolean get_isPartOfComposite()
  System.Void set_isPartOfComposite(System.Boolean value)
  System.Boolean get_hasOverrides()
  System.Void .ctor(System.String path, System.String action, System.String groups, System.String processors, System.String interactions, System.String name)
  System.String GetNameOfComposite()
  System.Void GenerateId()
  System.Void RemoveOverrides()
  UnityEngine.InputSystem.InputBinding MaskByGroup(System.String group)
  UnityEngine.InputSystem.InputBinding MaskByGroups(System.String[] groups)
  System.String get_effectivePath()
  System.String get_effectiveInteractions()
  System.String get_effectiveProcessors()
  System.Boolean get_isEmpty()
  System.Boolean Equals(UnityEngine.InputSystem.InputBinding other)
  System.Boolean Equals(System.Object obj)
  System.Boolean op_Equality(UnityEngine.InputSystem.InputBinding left, UnityEngine.InputSystem.InputBinding right)
  System.Boolean op_Inequality(UnityEngine.InputSystem.InputBinding left, UnityEngine.InputSystem.InputBinding right)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToDisplayString(UnityEngine.InputSystem.InputBinding.DisplayStringOptions options, UnityEngine.InputSystem.InputControl control)
  System.String ToDisplayString(System.String& deviceLayoutName, System.String& controlPath, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options, UnityEngine.InputSystem.InputControl control)
  System.Boolean TriggersAction(UnityEngine.InputSystem.InputAction action)
  System.Boolean Matches(UnityEngine.InputSystem.InputBinding binding)
  System.Boolean Matches(UnityEngine.InputSystem.InputBinding& binding, UnityEngine.InputSystem.InputBinding.MatchOptions options)
END_CLASS

CLASS: UnityEngine.InputSystem.InputBindingComposite
TYPE:  class
TOKEN: 0x2000053
FIELDS:
  private   static  UnityEngine.InputSystem.Utilities.TypeTables_Composites  // 0x0
METHODS:
  System.Type get_valueType()
  System.Int32 get_valueSizeInBytes()
  System.Void ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context, System.Void* buffer, System.Int32 bufferSize)
  System.Object ReadValueAsObject(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Single EvaluateMagnitude(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void FinishSetup(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void CallFinishSetup(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Type GetValueType(System.String composite)
  System.String GetExpectedControlLayoutName(System.String composite, System.String part)
  System.Collections.Generic.IEnumerable<System.String> GetPartNames(System.String composite)
  System.String GetDisplayFormatString(System.String composite)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.InputBindingComposite`1
TYPE:  class
TOKEN: 0x2000055
EXTENDS: InputBindingComposite
FIELDS:
METHODS:
  System.Type get_valueType()
  System.Int32 get_valueSizeInBytes()
  TValue ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context, System.Void* buffer, System.Int32 bufferSize)
  System.Object ReadValueAsObject(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.InputBindingCompositeContext
TYPE:  struct
TOKEN: 0x2000056
FIELDS:
  private           UnityEngine.InputSystem.InputActionStatem_State  // 0x10
  private           System.Int32                    m_BindingIndex  // 0x18
METHODS:
  System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding> get_controls()
  System.Single EvaluateMagnitude(System.Int32 partNumber)
  TValue ReadValue(System.Int32 partNumber)
  TValue ReadValue(System.Int32 partNumber, UnityEngine.InputSystem.InputControl& sourceControl)
  TValue ReadValue(System.Int32 partNumber, TComparer comparer)
  TValue ReadValue(System.Int32 partNumber, UnityEngine.InputSystem.InputControl& sourceControl, TComparer comparer)
  System.Boolean ReadValueAsButton(System.Int32 partNumber)
  System.Void ReadValue(System.Int32 partNumber, System.Void* buffer, System.Int32 bufferSize)
  System.Object ReadValueAsObject(System.Int32 partNumber)
  System.Double GetPressTime(System.Int32 partNumber)
END_CLASS

CLASS: UnityEngine.InputSystem.InputBindingResolver
TYPE:  struct
TOKEN: 0x200005A
FIELDS:
  public            System.Int32                    totalProcessorCount  // 0x10
  public            System.Int32                    totalCompositeCount  // 0x14
  public            System.Int32                    totalInteractionCount  // 0x18
  public            UnityEngine.InputSystem.InputActionMap[]maps  // 0x20
  public            UnityEngine.InputSystem.InputControl[]controls  // 0x28
  public            UnityEngine.InputSystem.InputActionState.UnmanagedMemorymemory  // 0x30
  public            UnityEngine.InputSystem.IInputInteraction[]interactions  // 0xB0
  public            UnityEngine.InputSystem.InputProcessor[]processors  // 0xB8
  public            UnityEngine.InputSystem.InputBindingComposite[]composites  // 0xC0
  public            System.Nullable<UnityEngine.InputSystem.InputBinding>bindingMask  // 0xC8
  private           System.Boolean                  m_IsControlOnlyResolve  // 0x128
  private           System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.NameAndParameters>m_Parameters  // 0x130
METHODS:
  System.Int32 get_totalMapCount()
  System.Int32 get_totalActionCount()
  System.Int32 get_totalBindingCount()
  System.Int32 get_totalControlCount()
  System.Void Dispose()
  System.Void StartWithPreviousResolve(UnityEngine.InputSystem.InputActionState state, System.Boolean isFullResolve)
  System.Void AddActionMap(UnityEngine.InputSystem.InputActionMap actionMap)
  System.Int32 InstantiateWithParameters(UnityEngine.InputSystem.Utilities.TypeTable registrations, System.String namesAndParameters, TType[]& array, System.Int32& count, UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding& binding)
  UnityEngine.InputSystem.InputBindingComposite InstantiateBindingComposite(UnityEngine.InputSystem.InputBinding& binding, UnityEngine.InputSystem.InputActionMap actionMap)
  System.Void ApplyParameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> parameters, System.Object instance, UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding& binding, System.String objectRegistrationName, System.String namesAndParameters)
  System.Int32 AssignCompositePartIndex(System.Object composite, System.String name, System.Int32& currentCompositePartCount)
END_CLASS

CLASS: UnityEngine.InputSystem.InputControlScheme
TYPE:  struct
TOKEN: 0x200005B
FIELDS:
  private           System.String                   m_Name  // 0x10
  private           System.String                   m_BindingGroup  // 0x18
  private           UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[]m_DeviceRequirements  // 0x20
METHODS:
  System.String get_name()
  System.String get_bindingGroup()
  System.Void set_bindingGroup(System.String value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> get_deviceRequirements()
  System.Void .ctor(System.String name, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> devices, System.String bindingGroup)
  System.Void SetNameAndBindingGroup(System.String name, System.String bindingGroup)
  System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlSchemeForDevices(TDevices devices, TSchemes schemes, UnityEngine.InputSystem.InputDevice mustIncludeDevice, System.Boolean allowUnsuccesfulMatch)
  System.Boolean FindControlSchemeForDevices(TDevices devices, TSchemes schemes, UnityEngine.InputSystem.InputControlScheme& controlScheme, UnityEngine.InputSystem.InputControlScheme.MatchResult& matchResult, UnityEngine.InputSystem.InputDevice mustIncludeDevice, System.Boolean allowUnsuccessfulMatch)
  System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlSchemeForDevice(UnityEngine.InputSystem.InputDevice device, TSchemes schemes)
  System.Boolean SupportsDevice(UnityEngine.InputSystem.InputDevice device)
  UnityEngine.InputSystem.InputControlScheme.MatchResult PickDevicesFrom(TDevices devices, UnityEngine.InputSystem.InputDevice favorDevice)
  System.Boolean Equals(UnityEngine.InputSystem.InputControlScheme other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Boolean op_Equality(UnityEngine.InputSystem.InputControlScheme left, UnityEngine.InputSystem.InputControlScheme right)
  System.Boolean op_Inequality(UnityEngine.InputSystem.InputControlScheme left, UnityEngine.InputSystem.InputControlScheme right)
END_CLASS

CLASS: UnityEngine.InputSystem.InputInteractionContext
TYPE:  struct
TOKEN: 0x2000064
FIELDS:
  private           UnityEngine.InputSystem.InputActionStatem_State  // 0x10
  private           UnityEngine.InputSystem.InputInteractionContext.Flagsm_Flags  // 0x18
  private           UnityEngine.InputSystem.InputActionState.TriggerStatem_TriggerState  // 0x20
METHODS:
  UnityEngine.InputSystem.InputAction get_action()
  UnityEngine.InputSystem.InputControl get_control()
  UnityEngine.InputSystem.InputActionPhase get_phase()
  System.Double get_time()
  System.Double get_startTime()
  System.Boolean get_timerHasExpired()
  System.Void set_timerHasExpired(System.Boolean value)
  System.Boolean get_isWaiting()
  System.Boolean get_isStarted()
  System.Single ComputeMagnitude()
  System.Boolean ControlIsActuated(System.Single threshold)
  System.Void Started()
  System.Void Performed()
  System.Void PerformedAndStayStarted()
  System.Void PerformedAndStayPerformed()
  System.Void Canceled()
  System.Void Waiting()
  System.Void SetTimeout(System.Single seconds)
  System.Void SetTotalTimeoutCompletionTime(System.Single seconds)
  TValue ReadValue()
  System.Int32 get_mapIndex()
  System.Int32 get_controlIndex()
  System.Int32 get_bindingIndex()
  System.Int32 get_interactionIndex()
END_CLASS

CLASS: UnityEngine.InputSystem.InputSystem
TYPE:  class
TOKEN: 0x2000066
FIELDS:
  private   static  System.String                   kAssemblyVersion  // 0x0
  private   static  System.String                   kDocUrl  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputResetMarker  // 0x0
  private   static  System.Single                   scrollWheelDeltaPerTick  // 0x0
  private   static  UnityEngine.InputSystem.InputManagers_Manager  // 0x8
  private   static  UnityEngine.InputSystem.InputRemotings_Remote  // 0x10
METHODS:
  System.Void add_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value)
  System.Void remove_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value)
  System.Void RegisterLayout(System.Type type, System.String name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches)
  System.Void RegisterLayout(System.String name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches)
  System.Void RegisterLayout(System.String json, System.String name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches)
  System.Void RegisterLayoutOverride(System.String json, System.String name)
  System.Void RegisterLayoutMatcher(System.String layoutName, UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher)
  System.Void RegisterLayoutMatcher(UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher)
  System.Void RegisterLayoutBuilder(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> buildMethod, System.String name, System.String baseLayout, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches)
  System.Void RegisterPrecompiledLayout(System.String metadata)
  System.Void RemoveLayout(System.String name)
  System.String TryFindMatchingLayout(UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription)
  System.Collections.Generic.IEnumerable<System.String> ListLayouts()
  System.Collections.Generic.IEnumerable<System.String> ListLayoutsBasedOn(System.String baseLayout)
  UnityEngine.InputSystem.Layouts.InputControlLayout LoadLayout(System.String name)
  UnityEngine.InputSystem.Layouts.InputControlLayout LoadLayout()
  System.String GetNameOfBaseLayout(System.String layoutName)
  System.Boolean IsFirstLayoutBasedOnSecond(System.String firstLayoutName, System.String secondLayoutName)
  System.Void RegisterProcessor(System.Type type, System.String name)
  System.Void RegisterProcessor(System.String name)
  System.Type TryGetProcessor(System.String name)
  System.Collections.Generic.IEnumerable<System.String> ListProcessors()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_disconnectedDevices()
  System.Void add_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value)
  System.Void remove_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value)
  System.Void add_onDeviceCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate value)
  System.Void remove_onDeviceCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate value)
  System.Void add_onFindLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate value)
  System.Void remove_onFindLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate value)
  System.Single get_pollingFrequency()
  System.Void set_pollingFrequency(System.Single value)
  UnityEngine.InputSystem.InputDevice AddDevice(System.String layout, System.String name, System.String variants)
  TDevice AddDevice(System.String name)
  UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription description)
  System.Void AddDevice(UnityEngine.InputSystem.InputDevice device)
  System.Void RemoveDevice(UnityEngine.InputSystem.InputDevice device)
  System.Void FlushDisconnectedDevices()
  UnityEngine.InputSystem.InputDevice GetDevice(System.String nameOrLayout)
  TDevice GetDevice()
  UnityEngine.InputSystem.InputDevice GetDevice(System.Type type)
  TDevice GetDevice(UnityEngine.InputSystem.Utilities.InternedString usage)
  TDevice GetDevice(System.String usage)
  UnityEngine.InputSystem.InputDevice GetDeviceById(System.Int32 deviceId)
  System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> GetUnsupportedDevices()
  System.Int32 GetUnsupportedDevices(System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions)
  System.Void EnableDevice(UnityEngine.InputSystem.InputDevice device)
  System.Void DisableDevice(UnityEngine.InputSystem.InputDevice device, System.Boolean keepSendingEvents)
  System.Boolean TrySyncDevice(UnityEngine.InputSystem.InputDevice device)
  System.Void ResetDevice(UnityEngine.InputSystem.InputDevice device, System.Boolean alsoResetDontResetControls)
  System.Boolean TryResetDevice(UnityEngine.InputSystem.InputDevice device)
  System.Void PauseHaptics()
  System.Void ResumeHaptics()
  System.Void ResetHaptics()
  System.Void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, System.String usage)
  System.Void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage)
  System.Void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, System.String usage)
  System.Void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage)
  System.Void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, System.String usage)
  System.Void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage)
  UnityEngine.InputSystem.InputControl FindControl(System.String path)
  UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> FindControls(System.String path)
  UnityEngine.InputSystem.InputControlList<TControl> FindControls(System.String path)
  System.Int32 FindControls(System.String path, UnityEngine.InputSystem.InputControlList<TControl>& controls)
  System.Boolean get_isProcessingEvents()
  UnityEngine.InputSystem.LowLevel.InputEventListener get_onEvent()
  System.Void set_onEvent(UnityEngine.InputSystem.LowLevel.InputEventListener value)
  System.IObservable<UnityEngine.InputSystem.InputControl> get_onAnyButtonPress()
  System.Void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void QueueEvent(TEvent& inputEvent)
  System.Void QueueStateEvent(UnityEngine.InputSystem.InputDevice device, TState state, System.Double time)
  System.Void QueueDeltaStateEvent(UnityEngine.InputSystem.InputControl control, TDelta delta, System.Double time)
  System.Void QueueConfigChangeEvent(UnityEngine.InputSystem.InputDevice device, System.Double time)
  System.Void QueueTextEvent(UnityEngine.InputSystem.InputDevice device, System.Char character, System.Double time)
  System.Void Update()
  System.Void Update(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
  System.Void add_onBeforeUpdate(System.Action value)
  System.Void remove_onBeforeUpdate(System.Action value)
  System.Void add_onAfterUpdate(System.Action value)
  System.Void remove_onAfterUpdate(System.Action value)
  UnityEngine.InputSystem.InputSettings get_settings()
  System.Void set_settings(UnityEngine.InputSystem.InputSettings value)
  System.Void add_onSettingsChange(System.Action value)
  System.Void remove_onSettingsChange(System.Action value)
  System.Void add_onActionChange(System.Action<System.Object,UnityEngine.InputSystem.InputActionChange> value)
  System.Void remove_onActionChange(System.Action<System.Object,UnityEngine.InputSystem.InputActionChange> value)
  System.Void RegisterInteraction(System.Type type, System.String name)
  System.Void RegisterInteraction(System.String name)
  System.Type TryGetInteraction(System.String name)
  System.Collections.Generic.IEnumerable<System.String> ListInteractions()
  System.Void RegisterBindingComposite(System.Type type, System.String name)
  System.Void RegisterBindingComposite(System.String name)
  System.Type TryGetBindingComposite(System.String name)
  System.Void DisableAllEnabledActions()
  System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> ListEnabledActions()
  System.Int32 ListEnabledActions(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> actions)
  UnityEngine.InputSystem.InputRemoting get_remoting()
  System.Version get_version()
  System.Boolean get_runInBackground()
  System.Void set_runInBackground(System.Boolean value)
  UnityEngine.InputSystem.LowLevel.InputMetrics get_metrics()
  System.Void .cctor()
  System.Void RunInitializeInPlayer()
  System.Void EnsureInitialized()
  System.Void InitializeInPlayer(UnityEngine.InputSystem.LowLevel.IInputRuntime runtime, UnityEngine.InputSystem.InputSettings settings)
  System.Void RunInitialUpdate()
  System.Void PerformDefaultPluginInitialization()
END_CLASS

CLASS: UnityEngine.InputSystem.CommonUsages
TYPE:  class
TOKEN: 0x200006C
FIELDS:
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringPrimary2DMotion  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringSecondary2DMotion  // 0x10
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringPrimaryAction  // 0x20
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringSecondaryAction  // 0x30
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringPrimaryTrigger  // 0x40
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringSecondaryTrigger  // 0x50
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringModifier  // 0x60
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringPosition  // 0x70
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringOrientation  // 0x80
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringHatswitch  // 0x90
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringBack  // 0xA0
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringForward  // 0xB0
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringMenu  // 0xC0
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringSubmit  // 0xD0
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringCancel  // 0xE0
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringHorizontal  // 0xF0
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringVertical  // 0x100
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringTwist  // 0x110
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringPressure  // 0x120
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringScrollHorizontal  // 0x130
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringScrollVertical  // 0x140
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringPoint  // 0x150
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringLowFreqMotor  // 0x160
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringHighFreqMotor  // 0x170
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringLeftHand  // 0x180
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringRightHand  // 0x190
  public    static readonly UnityEngine.InputSystem.Utilities.InternedStringBatteryStrength  // 0x1A0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.InputControl
TYPE:  class
TOKEN: 0x200006D
FIELDS:
  protected internal        UnityEngine.InputSystem.LowLevel.InputStateBlockm_StateBlock  // 0x10
  private           UnityEngine.InputSystem.Utilities.InternedStringm_Name  // 0x20
  private           System.String                   m_Path  // 0x30
  private           System.String                   m_DisplayName  // 0x38
  private           System.String                   m_DisplayNameFromLayout  // 0x40
  private           System.String                   m_ShortDisplayName  // 0x48
  private           System.String                   m_ShortDisplayNameFromLayout  // 0x50
  private           UnityEngine.InputSystem.Utilities.InternedStringm_Layout  // 0x58
  private           UnityEngine.InputSystem.Utilities.InternedStringm_Variants  // 0x68
  private           UnityEngine.InputSystem.InputDevicem_Device  // 0x78
  private           UnityEngine.InputSystem.InputControlm_Parent  // 0x80
  private           System.Int32                    m_UsageCount  // 0x88
  private           System.Int32                    m_UsageStartIndex  // 0x8C
  private           System.Int32                    m_AliasCount  // 0x90
  private           System.Int32                    m_AliasStartIndex  // 0x94
  private           System.Int32                    m_ChildCount  // 0x98
  private           System.Int32                    m_ChildStartIndex  // 0x9C
  private           UnityEngine.InputSystem.InputControl.ControlFlagsm_ControlFlags  // 0xA0
  private           System.Boolean                  m_CachedValueIsStale  // 0xA4
  private           System.Boolean                  m_UnprocessedCachedValueIsStale  // 0xA5
  private           UnityEngine.InputSystem.Utilities.PrimitiveValuem_DefaultState  // 0xA8
  private           UnityEngine.InputSystem.Utilities.PrimitiveValuem_MinValue  // 0xB8
  private           UnityEngine.InputSystem.Utilities.PrimitiveValuem_MaxValue  // 0xC8
  private           UnityEngine.InputSystem.Utilities.FourCCm_OptimizedControlDataType  // 0xD8
METHODS:
  System.String get_name()
  System.String get_displayName()
  System.Void set_displayName(System.String value)
  System.String get_shortDisplayName()
  System.Void set_shortDisplayName(System.String value)
  System.String get_path()
  System.String get_layout()
  System.String get_variants()
  UnityEngine.InputSystem.InputDevice get_device()
  UnityEngine.InputSystem.InputControl get_parent()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_children()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_usages()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_aliases()
  UnityEngine.InputSystem.LowLevel.InputStateBlock get_stateBlock()
  System.Boolean get_noisy()
  System.Void set_noisy(System.Boolean value)
  System.Boolean get_synthetic()
  System.Void set_synthetic(System.Boolean value)
  UnityEngine.InputSystem.InputControl get_Item(System.String path)
  System.Type get_valueType()
  System.Int32 get_valueSizeInBytes()
  System.Single get_magnitude()
  System.String ToString()
  System.String DebuggerDisplay()
  System.Single EvaluateMagnitude()
  System.Single EvaluateMagnitude(System.Void* statePtr)
  System.Object ReadValueFromBufferAsObject(System.Void* buffer, System.Int32 bufferSize)
  System.Object ReadValueFromStateAsObject(System.Void* statePtr)
  System.Void ReadValueFromStateIntoBuffer(System.Void* statePtr, System.Void* bufferPtr, System.Int32 bufferSize)
  System.Void WriteValueFromBufferIntoState(System.Void* bufferPtr, System.Int32 bufferSize, System.Void* statePtr)
  System.Void WriteValueFromObjectIntoState(System.Object value, System.Void* statePtr)
  System.Boolean CompareValue(System.Void* firstStatePtr, System.Void* secondStatePtr)
  UnityEngine.InputSystem.InputControl TryGetChildControl(System.String path)
  TControl TryGetChildControl(System.String path)
  UnityEngine.InputSystem.InputControl GetChildControl(System.String path)
  TControl GetChildControl(System.String path)
  System.Void .ctor()
  System.Void FinishSetup()
  System.Void RefreshConfigurationIfNeeded()
  System.Void RefreshConfiguration()
  System.Void* get_currentStatePtr()
  System.Void* get_previousFrameStatePtr()
  System.Void* get_defaultStatePtr()
  System.Void* get_noiseMaskPtr()
  System.UInt32 get_stateOffsetRelativeToDeviceRoot()
  UnityEngine.InputSystem.Utilities.FourCC get_optimizedControlDataType()
  UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType()
  System.Void ApplyParameterChanges()
  System.Void SetOptimizedControlDataType()
  System.Void SetOptimizedControlDataTypeRecursively()
  System.Void EnsureOptimizationTypeHasNotChanged()
  System.Boolean get_isSetupFinished()
  System.Void set_isSetupFinished(System.Boolean value)
  System.Boolean get_isButton()
  System.Void set_isButton(System.Boolean value)
  System.Boolean get_isConfigUpToDate()
  System.Void set_isConfigUpToDate(System.Boolean value)
  System.Boolean get_dontReset()
  System.Void set_dontReset(System.Boolean value)
  System.Boolean get_usesStateFromOtherControl()
  System.Void set_usesStateFromOtherControl(System.Boolean value)
  System.Boolean get_hasDefaultState()
  System.Void CallFinishSetupRecursive()
  System.String MakeChildPath(System.String path)
  System.Void BakeOffsetIntoStateBlockRecursive(System.UInt32 offset)
  System.Int32 GetDeviceIndex()
  System.Boolean IsValueConsideredPressed(System.Single value)
  System.Void AddProcessor(System.Object first)
  System.Void MarkAsStale()
  System.Void MarkAsStaleRecursively()
END_CLASS

CLASS: UnityEngine.InputSystem.InputControl`1
TYPE:  class
TOKEN: 0x200006F
EXTENDS: InputControl
FIELDS:
  private           UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputProcessor<TValue>>m_ProcessorStack  // 0x0
  private           TValue                          m_CachedValue  // 0x0
  private           TValue                          m_UnprocessedCachedValue  // 0x0
  private           System.Boolean                  evaluateProcessorsEveryRead  // 0x0
METHODS:
  System.Type get_valueType()
  System.Int32 get_valueSizeInBytes()
  TValue& get_value()
  TValue& get_unprocessedValue()
  TValue ReadValue()
  TValue ReadValueFromPreviousFrame()
  TValue ReadDefaultValue()
  TValue ReadValueFromState(System.Void* statePtr)
  TValue ReadValueFromStateWithCaching(System.Void* statePtr)
  TValue ReadUnprocessedValueFromStateWithCaching(System.Void* statePtr)
  TValue ReadUnprocessedValue()
  TValue ReadUnprocessedValueFromState(System.Void* statePtr)
  System.Object ReadValueFromStateAsObject(System.Void* statePtr)
  System.Void ReadValueFromStateIntoBuffer(System.Void* statePtr, System.Void* bufferPtr, System.Int32 bufferSize)
  System.Void WriteValueFromBufferIntoState(System.Void* bufferPtr, System.Int32 bufferSize, System.Void* statePtr)
  System.Void WriteValueFromObjectIntoState(System.Object value, System.Void* statePtr)
  System.Void WriteValueIntoState(TValue value, System.Void* statePtr)
  System.Object ReadValueFromBufferAsObject(System.Void* buffer, System.Int32 bufferSize)
  System.Boolean CompareValue(TValue& firstValue, TValue& secondValue)
  System.Boolean CompareValue(System.Void* firstStatePtr, System.Void* secondStatePtr)
  TValue ProcessValue(TValue value)
  System.Void ProcessValue(TValue& value)
  TProcessor TryGetProcessor()
  System.Void AddProcessor(System.Object processor)
  System.Void FinishSetup()
  UnityEngine.InputSystem.InputProcessor<TValue>[] get_processors()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.InputControlExtensions
TYPE:  class
TOKEN: 0x2000070
FIELDS:
METHODS:
  TControl FindInParentChain(UnityEngine.InputSystem.InputControl control)
  System.Boolean IsPressed(UnityEngine.InputSystem.InputControl control, System.Single buttonPressPoint)
  System.Boolean IsActuated(UnityEngine.InputSystem.InputControl control, System.Single threshold)
  System.Object ReadValueAsObject(UnityEngine.InputSystem.InputControl control)
  System.Void ReadValueIntoBuffer(UnityEngine.InputSystem.InputControl control, System.Void* buffer, System.Int32 bufferSize)
  System.Object ReadDefaultValueAsObject(UnityEngine.InputSystem.InputControl control)
  TValue ReadValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent)
  System.Boolean ReadValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent, TValue& value)
  System.Object ReadValueFromEventAsObject(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent)
  TValue ReadUnprocessedValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Boolean ReadUnprocessedValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent, TValue& value)
  System.Void WriteValueFromObjectIntoEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Object value)
  System.Void WriteValueIntoState(UnityEngine.InputSystem.InputControl control, System.Void* statePtr)
  System.Void WriteValueIntoState(UnityEngine.InputSystem.InputControl control, TValue value, System.Void* statePtr)
  System.Void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, System.Void* statePtr)
  System.Void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, System.Void* statePtr)
  System.Void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, TState& state)
  System.Void WriteValueIntoEvent(UnityEngine.InputSystem.InputControl control, TValue value, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void WriteValueIntoEvent(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void CopyState(UnityEngine.InputSystem.InputDevice device, System.Void* buffer, System.Int32 bufferSizeInBytes)
  System.Void CopyState(UnityEngine.InputSystem.InputDevice device, TState& state)
  System.Boolean CheckStateIsAtDefault(UnityEngine.InputSystem.InputControl control)
  System.Boolean CheckStateIsAtDefault(UnityEngine.InputSystem.InputControl control, System.Void* statePtr, System.Void* maskPtr)
  System.Boolean CheckStateIsAtDefaultIgnoringNoise(UnityEngine.InputSystem.InputControl control)
  System.Boolean CheckStateIsAtDefaultIgnoringNoise(UnityEngine.InputSystem.InputControl control, System.Void* statePtr)
  System.Boolean CompareStateIgnoringNoise(UnityEngine.InputSystem.InputControl control, System.Void* statePtr)
  System.Boolean CompareState(UnityEngine.InputSystem.InputControl control, System.Void* firstStatePtr, System.Void* secondStatePtr, System.Void* maskPtr)
  System.Boolean CompareState(UnityEngine.InputSystem.InputControl control, System.Void* statePtr, System.Void* maskPtr)
  System.Boolean HasValueChangeInState(UnityEngine.InputSystem.InputControl control, System.Void* statePtr)
  System.Boolean HasValueChangeInEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void* GetStatePtrFromStateEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void* GetStatePtrFromStateEventUnchecked(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.Utilities.FourCC eventType)
  System.Boolean ResetToDefaultStateInEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void QueueValueChange(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, System.Double time)
  System.Void AccumulateValueInEvent(UnityEngine.InputSystem.InputControl<System.Single> control, System.Void* currentStatePtr, UnityEngine.InputSystem.LowLevel.InputEventPtr newState)
  System.Void AccumulateValueInEvent(UnityEngine.InputSystem.InputControl<UnityEngine.Vector2> control, System.Void* currentStatePtr, UnityEngine.InputSystem.LowLevel.InputEventPtr newState)
  System.Void FindControlsRecursive(UnityEngine.InputSystem.InputControl parent, System.Collections.Generic.IList<TControl> controls, System.Func<TControl,System.Boolean> predicate)
  System.String BuildPath(UnityEngine.InputSystem.InputControl control, System.String deviceLayout, System.Text.StringBuilder builder)
  UnityEngine.InputSystem.InputControlExtensions.InputEventControlCollection EnumerateControls(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputControlExtensions.Enumerate flags, UnityEngine.InputSystem.InputDevice device, System.Single magnitudeThreshold)
  UnityEngine.InputSystem.InputControlExtensions.InputEventControlCollection EnumerateChangedControls(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device, System.Single magnitudeThreshold)
  System.Boolean HasButtonPress(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Single magnitude, System.Boolean buttonControlsOnly)
  UnityEngine.InputSystem.InputControl GetFirstButtonPressOrNull(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Single magnitude, System.Boolean buttonControlsOnly)
  System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl> GetAllButtonPresses(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Single magnitude, System.Boolean buttonControlsOnly)
  UnityEngine.InputSystem.InputControlExtensions.ControlBuilder Setup(UnityEngine.InputSystem.InputControl control)
  UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder Setup(UnityEngine.InputSystem.InputDevice device, System.Int32 controlCount, System.Int32 usageCount, System.Int32 aliasCount)
END_CLASS

CLASS: UnityEngine.InputSystem.InputControlLayoutChange
TYPE:  struct
TOKEN: 0x2000077
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputControlLayoutChangeAdded  // 0x0
  public    static  UnityEngine.InputSystem.InputControlLayoutChangeRemoved  // 0x0
  public    static  UnityEngine.InputSystem.InputControlLayoutChangeReplaced  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.InputControlList`1
TYPE:  struct
TOKEN: 0x2000078
FIELDS:
  private           System.Int32                    m_Count  // 0x0
  private           Unity.Collections.NativeArray<System.UInt64>m_Indices  // 0x0
  private   readonly Unity.Collections.Allocator     m_Allocator  // 0x0
  private   static  System.UInt64                   kInvalidIndex  // 0x0
METHODS:
  System.Int32 get_Count()
  System.Int32 get_Capacity()
  System.Void set_Capacity(System.Int32 value)
  System.Boolean get_IsReadOnly()
  TControl get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, TControl value)
  System.Void .ctor(Unity.Collections.Allocator allocator, System.Int32 initialCapacity)
  System.Void .ctor(System.Collections.Generic.IEnumerable<TControl> values, Unity.Collections.Allocator allocator)
  System.Void .ctor(TControl[] values)
  System.Void Resize(System.Int32 size)
  System.Void Add(TControl item)
  System.Void AddSlice(TList list, System.Int32 count, System.Int32 destinationIndex, System.Int32 sourceIndex)
  System.Void AddRange(System.Collections.Generic.IEnumerable<TControl> list, System.Int32 count, System.Int32 destinationIndex)
  System.Boolean Remove(TControl item)
  System.Void RemoveAt(System.Int32 index)
  System.Void CopyTo(TControl[] array, System.Int32 arrayIndex)
  System.Int32 IndexOf(TControl item)
  System.Int32 IndexOf(TControl item, System.Int32 startIndex, System.Int32 count)
  System.Void Insert(System.Int32 index, TControl item)
  System.Void Clear()
  System.Boolean Contains(TControl item)
  System.Boolean Contains(TControl item, System.Int32 startIndex, System.Int32 count)
  System.Void SwapElements(System.Int32 index1, System.Int32 index2)
  System.Void Sort(System.Int32 startIndex, System.Int32 count, TCompare comparer)
  TControl[] ToArray(System.Boolean dispose)
  System.Void AppendTo(TControl[]& array, System.Int32& count)
  System.Void Dispose()
  System.Collections.Generic.IEnumerator<TControl> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.String ToString()
  System.UInt64 ToIndex(TControl control)
  TControl FromIndex(System.UInt64 index)
END_CLASS

CLASS: UnityEngine.InputSystem.InputControlPath
TYPE:  class
TOKEN: 0x200007A
FIELDS:
  public    static  System.String                   Wildcard  // 0x0
  public    static  System.String                   DoubleWildcard  // 0x0
  public    static  System.Char                     Separator  // 0x0
  private   static  System.Char                     SeparatorReplacement  // 0x0
METHODS:
  System.String CleanSlashes(System.String pathComponent)
  System.String Combine(UnityEngine.InputSystem.InputControl parent, System.String path)
  System.String ToHumanReadableString(System.String path, UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions options, UnityEngine.InputSystem.InputControl control)
  System.String ToHumanReadableString(System.String path, System.String& deviceLayoutName, System.String& controlPath, UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions options, UnityEngine.InputSystem.InputControl control)
  System.String[] TryGetDeviceUsages(System.String path)
  System.String TryGetDeviceLayout(System.String path)
  System.String TryGetControlLayout(System.String path)
  System.String FindControlLayoutRecursive(UnityEngine.InputSystem.InputControlPath.PathParser& parser, System.String layoutName)
  System.String FindControlLayoutRecursive(UnityEngine.InputSystem.InputControlPath.PathParser& parser, UnityEngine.InputSystem.Layouts.InputControlLayout layout)
  System.Boolean ControlLayoutMatchesPathComponent(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem& controlItem, UnityEngine.InputSystem.InputControlPath.PathParser& parser)
  System.Boolean StringMatches(UnityEngine.InputSystem.Utilities.Substring str, UnityEngine.InputSystem.Utilities.InternedString matchTo)
  UnityEngine.InputSystem.InputControl TryFindControl(UnityEngine.InputSystem.InputControl control, System.String path, System.Int32 indexInPath)
  UnityEngine.InputSystem.InputControl[] TryFindControls(UnityEngine.InputSystem.InputControl control, System.String path, System.Int32 indexInPath)
  System.Int32 TryFindControls(UnityEngine.InputSystem.InputControl control, System.String path, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl>& matches, System.Int32 indexInPath)
  TControl TryFindControl(UnityEngine.InputSystem.InputControl control, System.String path, System.Int32 indexInPath)
  System.Int32 TryFindControls(UnityEngine.InputSystem.InputControl control, System.String path, System.Int32 indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches)
  UnityEngine.InputSystem.InputControl TryFindChild(UnityEngine.InputSystem.InputControl control, System.String path, System.Int32 indexInPath)
  TControl TryFindChild(UnityEngine.InputSystem.InputControl control, System.String path, System.Int32 indexInPath)
  System.Boolean Matches(System.String expected, UnityEngine.InputSystem.InputControl control)
  System.Boolean MatchControlComponent(UnityEngine.InputSystem.InputControlPath.ParsedPathComponent& expectedControlComponent, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem& controlItem, System.Boolean matchAlias)
  System.Boolean MatchesPrefix(System.String expected, UnityEngine.InputSystem.InputControl control)
  System.Boolean MatchesRecursive(UnityEngine.InputSystem.InputControlPath.PathParser& parser, UnityEngine.InputSystem.InputControl currentControl, System.Boolean prefixOnly)
  TControl MatchControlsRecursive(UnityEngine.InputSystem.InputControl control, System.String path, System.Int32 indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches, System.Boolean matchMultiple)
  TControl MatchByUsageAtDeviceRootRecursive(UnityEngine.InputSystem.InputDevice device, System.String path, System.Int32 indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches, System.Boolean matchMultiple)
  TControl MatchChildrenRecursive(UnityEngine.InputSystem.InputControl control, System.String path, System.Int32 indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches, System.Boolean matchMultiple)
  System.Boolean MatchPathComponent(System.String component, System.String path, System.Int32& indexInPath, UnityEngine.InputSystem.InputControlPath.PathComponentType componentType, System.Int32 startIndexInComponent)
  System.Boolean PathComponentCanYieldMultipleMatches(System.String path, System.Int32 indexInPath)
  System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent> Parse(System.String path)
END_CLASS

CLASS: UnityEngine.InputSystem.InputProcessor
TYPE:  class
TOKEN: 0x2000082
FIELDS:
  private   static  UnityEngine.InputSystem.Utilities.TypeTables_Processors  // 0x0
METHODS:
  System.Object ProcessAsObject(System.Object value, UnityEngine.InputSystem.InputControl control)
  System.Void Process(System.Void* buffer, System.Int32 bufferSize, UnityEngine.InputSystem.InputControl control)
  System.Type GetValueTypeFromType(System.Type processorType)
  UnityEngine.InputSystem.InputProcessor.CachingPolicy get_cachingPolicy()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.InputProcessor`1
TYPE:  class
TOKEN: 0x2000084
EXTENDS: InputProcessor
FIELDS:
METHODS:
  TValue Process(TValue value, UnityEngine.InputSystem.InputControl control)
  System.Object ProcessAsObject(System.Object value, UnityEngine.InputSystem.InputControl control)
  System.Void Process(System.Void* buffer, System.Int32 bufferSize, UnityEngine.InputSystem.InputControl control)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Gamepad
TYPE:  class
TOKEN: 0x2000085
EXTENDS: InputDevice
FIELDS:
  private           UnityEngine.InputSystem.Controls.ButtonControl<buttonWest>k__BackingField  // 0x190
  private           UnityEngine.InputSystem.Controls.ButtonControl<buttonNorth>k__BackingField  // 0x198
  private           UnityEngine.InputSystem.Controls.ButtonControl<buttonSouth>k__BackingField  // 0x1A0
  private           UnityEngine.InputSystem.Controls.ButtonControl<buttonEast>k__BackingField  // 0x1A8
  private           UnityEngine.InputSystem.Controls.ButtonControl<leftStickButton>k__BackingField  // 0x1B0
  private           UnityEngine.InputSystem.Controls.ButtonControl<rightStickButton>k__BackingField  // 0x1B8
  private           UnityEngine.InputSystem.Controls.ButtonControl<startButton>k__BackingField  // 0x1C0
  private           UnityEngine.InputSystem.Controls.ButtonControl<selectButton>k__BackingField  // 0x1C8
  private           UnityEngine.InputSystem.Controls.DpadControl<dpad>k__BackingField  // 0x1D0
  private           UnityEngine.InputSystem.Controls.ButtonControl<leftShoulder>k__BackingField  // 0x1D8
  private           UnityEngine.InputSystem.Controls.ButtonControl<rightShoulder>k__BackingField  // 0x1E0
  private           UnityEngine.InputSystem.Controls.StickControl<leftStick>k__BackingField  // 0x1E8
  private           UnityEngine.InputSystem.Controls.StickControl<rightStick>k__BackingField  // 0x1F0
  private           UnityEngine.InputSystem.Controls.ButtonControl<leftTrigger>k__BackingField  // 0x1F8
  private           UnityEngine.InputSystem.Controls.ButtonControl<rightTrigger>k__BackingField  // 0x200
  private   static  UnityEngine.InputSystem.Gamepad <current>k__BackingField  // 0x0
  private           UnityEngine.InputSystem.Haptics.DualMotorRumblem_Rumble  // 0x208
  private   static  System.Int32                    s_GamepadCount  // 0x8
  private   static  UnityEngine.InputSystem.Gamepad[]s_Gamepads  // 0x10
METHODS:
  UnityEngine.InputSystem.Controls.ButtonControl get_buttonWest()
  System.Void set_buttonWest(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_buttonNorth()
  System.Void set_buttonNorth(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_buttonSouth()
  System.Void set_buttonSouth(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_buttonEast()
  System.Void set_buttonEast(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_leftStickButton()
  System.Void set_leftStickButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_rightStickButton()
  System.Void set_rightStickButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_startButton()
  System.Void set_startButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_selectButton()
  System.Void set_selectButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.DpadControl get_dpad()
  System.Void set_dpad(UnityEngine.InputSystem.Controls.DpadControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_leftShoulder()
  System.Void set_leftShoulder(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_rightShoulder()
  System.Void set_rightShoulder(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.StickControl get_leftStick()
  System.Void set_leftStick(UnityEngine.InputSystem.Controls.StickControl value)
  UnityEngine.InputSystem.Controls.StickControl get_rightStick()
  System.Void set_rightStick(UnityEngine.InputSystem.Controls.StickControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_leftTrigger()
  System.Void set_leftTrigger(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_rightTrigger()
  System.Void set_rightTrigger(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_aButton()
  UnityEngine.InputSystem.Controls.ButtonControl get_bButton()
  UnityEngine.InputSystem.Controls.ButtonControl get_xButton()
  UnityEngine.InputSystem.Controls.ButtonControl get_yButton()
  UnityEngine.InputSystem.Controls.ButtonControl get_triangleButton()
  UnityEngine.InputSystem.Controls.ButtonControl get_squareButton()
  UnityEngine.InputSystem.Controls.ButtonControl get_circleButton()
  UnityEngine.InputSystem.Controls.ButtonControl get_crossButton()
  UnityEngine.InputSystem.Controls.ButtonControl get_Item(UnityEngine.InputSystem.LowLevel.GamepadButton button)
  UnityEngine.InputSystem.Gamepad get_current()
  System.Void set_current(UnityEngine.InputSystem.Gamepad value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Gamepad> get_all()
  System.Void FinishSetup()
  System.Void MakeCurrent()
  System.Void OnAdded()
  System.Void OnRemoved()
  System.Void PauseHaptics()
  System.Void ResumeHaptics()
  System.Void ResetHaptics()
  System.Void SetMotorSpeeds(System.Single lowFrequency, System.Single highFrequency)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.InputDevice
TYPE:  class
TOKEN: 0x2000086
EXTENDS: InputControl
FIELDS:
  public    static  System.Int32                    InvalidDeviceId  // 0x0
  private   static  System.Int32                    kLocalParticipantId  // 0x0
  private   static  System.Int32                    kInvalidDeviceIndex  // 0x0
  private           UnityEngine.InputSystem.InputDevice.DeviceFlagsm_DeviceFlags  // 0xE0
  private           System.Int32                    m_DeviceId  // 0xE4
  private           System.Int32                    m_ParticipantId  // 0xE8
  private           System.Int32                    m_DeviceIndex  // 0xEC
  private           System.UInt32                   m_CurrentProcessedEventBytesOnUpdate  // 0xF0
  private           UnityEngine.InputSystem.Layouts.InputDeviceDescriptionm_Description  // 0xF8
  private           System.Double                   m_LastUpdateTimeInternal  // 0x130
  private           System.UInt32                   m_CurrentUpdateStepCount  // 0x138
  private           UnityEngine.InputSystem.Utilities.InternedString[]m_AliasesForEachControl  // 0x140
  private           UnityEngine.InputSystem.Utilities.InternedString[]m_UsagesForEachControl  // 0x148
  private           UnityEngine.InputSystem.InputControl[]m_UsageToControl  // 0x150
  private           UnityEngine.InputSystem.InputControl[]m_ChildrenForEachControl  // 0x158
  private           System.Collections.Generic.HashSet<System.Int32>m_UpdatedButtons  // 0x160
  private           System.Collections.Generic.List<UnityEngine.InputSystem.Controls.ButtonControl>m_ButtonControlsCheckingPressState  // 0x168
  private           System.Boolean                  m_UseCachePathForButtonPresses  // 0x170
  private           System.UInt32[]                 m_StateOffsetToControlMap  // 0x178
  private           UnityEngine.InputSystem.InputDevice.ControlBitRangeNode[]m_ControlTreeNodes  // 0x180
  private           System.UInt16[]                 m_ControlTreeIndices  // 0x188
  private   static  System.Int32                    kControlIndexBits  // 0x0
  private   static  System.Int32                    kStateOffsetBits  // 0x0
  private   static  System.Int32                    kStateSizeBits  // 0x0
METHODS:
  UnityEngine.InputSystem.Layouts.InputDeviceDescription get_description()
  System.Boolean get_enabled()
  System.Boolean get_canRunInBackground()
  System.Boolean get_canDeviceRunInBackground()
  System.Boolean get_added()
  System.Boolean get_remote()
  System.Boolean get_native()
  System.Boolean get_updateBeforeRender()
  System.Int32 get_deviceId()
  System.Double get_lastUpdateTime()
  System.Boolean get_wasUpdatedThisFrame()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_allControls()
  System.Type get_valueType()
  System.Int32 get_valueSizeInBytes()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_all()
  System.Void .ctor()
  System.Object ReadValueFromBufferAsObject(System.Void* buffer, System.Int32 bufferSize)
  System.Object ReadValueFromStateAsObject(System.Void* statePtr)
  System.Void ReadValueFromStateIntoBuffer(System.Void* statePtr, System.Void* bufferPtr, System.Int32 bufferSize)
  System.Boolean CompareValue(System.Void* firstStatePtr, System.Void* secondStatePtr)
  System.Void NotifyConfigurationChanged()
  System.Void MakeCurrent()
  System.Void OnAdded()
  System.Void OnRemoved()
  System.Void OnConfigurationChanged()
  System.Int64 ExecuteCommand(TCommand& command)
  System.Int64 ExecuteCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommand* commandPtr)
  System.Boolean QueryEnabledStateFromRuntime()
  System.Boolean get_disabledInFrontend()
  System.Void set_disabledInFrontend(System.Boolean value)
  System.Boolean get_disabledInRuntime()
  System.Void set_disabledInRuntime(System.Boolean value)
  System.Boolean get_disabledWhileInBackground()
  System.Void set_disabledWhileInBackground(System.Boolean value)
  System.UInt32 EncodeStateOffsetToControlMapEntry(System.UInt32 controlIndex, System.UInt32 stateOffsetInBits, System.UInt32 stateSizeInBits)
  System.Void DecodeStateOffsetToControlMapEntry(System.UInt32 entry, System.UInt32& controlIndex, System.UInt32& stateOffset, System.UInt32& stateSize)
  System.Boolean get_hasControlsWithDefaultState()
  System.Void set_hasControlsWithDefaultState(System.Boolean value)
  System.Boolean get_hasDontResetControls()
  System.Void set_hasDontResetControls(System.Boolean value)
  System.Boolean get_hasStateCallbacks()
  System.Void set_hasStateCallbacks(System.Boolean value)
  System.Boolean get_hasEventMerger()
  System.Void set_hasEventMerger(System.Boolean value)
  System.Boolean get_hasEventPreProcessor()
  System.Void set_hasEventPreProcessor(System.Boolean value)
  System.Void AddDeviceUsage(UnityEngine.InputSystem.Utilities.InternedString usage)
  System.Void RemoveDeviceUsage(UnityEngine.InputSystem.Utilities.InternedString usage)
  System.Void ClearDeviceUsages()
  System.Boolean RequestSync()
  System.Boolean RequestReset()
  System.Boolean ExecuteEnableCommand()
  System.Boolean ExecuteDisableCommand()
  System.Void NotifyAdded()
  System.Void NotifyRemoved()
  TDevice Build(System.String layoutName, System.String layoutVariants, UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription, System.Boolean noPrecompiledLayouts)
  System.Void WriteChangedControlStates(System.Byte* deviceStateBuffer, System.Void* statePtr, System.UInt32 stateSizeInBytes, System.UInt32 stateOffsetInDevice)
  System.Void WritePartialChangedControlStatesInternal(System.UInt32 stateSizeInBits, System.UInt32 stateOffsetInDeviceInBits, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parentNode, System.UInt32 startOffset)
  System.Void DumpControlBitRangeNode(System.Int32 nodeIndex, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode node, System.UInt32 startOffset, System.UInt32 sizeInBits, System.Collections.Generic.List<System.String> output)
  System.Void DumpControlTree(UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parentNode, System.UInt32 startOffset, System.Collections.Generic.List<System.String> output)
  System.String DumpControlTree()
  System.Void WriteChangedControlStatesInternal(System.Void* statePtr, System.Byte* deviceStatePtr, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parentNode, System.UInt32 startOffset)
  System.Boolean HasDataChangedInRange(System.Byte* deviceStatePtr, System.Void* statePtr, System.UInt32 startOffset, System.UInt32 sizeInBits)
END_CLASS

CLASS: UnityEngine.InputSystem.InputDeviceChange
TYPE:  struct
TOKEN: 0x2000089
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.InputDeviceChangeAdded  // 0x0
  public    static  UnityEngine.InputSystem.InputDeviceChangeRemoved  // 0x0
  public    static  UnityEngine.InputSystem.InputDeviceChangeDisconnected  // 0x0
  public    static  UnityEngine.InputSystem.InputDeviceChangeReconnected  // 0x0
  public    static  UnityEngine.InputSystem.InputDeviceChangeEnabled  // 0x0
  public    static  UnityEngine.InputSystem.InputDeviceChangeDisabled  // 0x0
  public    static  UnityEngine.InputSystem.InputDeviceChangeUsageChanged  // 0x0
  public    static  UnityEngine.InputSystem.InputDeviceChangeConfigurationChanged  // 0x0
  public    static  UnityEngine.InputSystem.InputDeviceChangeSoftReset  // 0x0
  public    static  UnityEngine.InputSystem.InputDeviceChangeHardReset  // 0x0
  public    static  UnityEngine.InputSystem.InputDeviceChangeDestroyed  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.Joystick
TYPE:  class
TOKEN: 0x200008A
EXTENDS: InputDevice
FIELDS:
  private           UnityEngine.InputSystem.Controls.ButtonControl<trigger>k__BackingField  // 0x190
  private           UnityEngine.InputSystem.Controls.StickControl<stick>k__BackingField  // 0x198
  private           UnityEngine.InputSystem.Controls.AxisControl<twist>k__BackingField  // 0x1A0
  private           UnityEngine.InputSystem.Controls.Vector2Control<hatswitch>k__BackingField  // 0x1A8
  private   static  UnityEngine.InputSystem.Joystick<current>k__BackingField  // 0x0
  private   static  System.Int32                    s_JoystickCount  // 0x8
  private   static  UnityEngine.InputSystem.Joystick[]s_Joysticks  // 0x10
METHODS:
  UnityEngine.InputSystem.Controls.ButtonControl get_trigger()
  System.Void set_trigger(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.StickControl get_stick()
  System.Void set_stick(UnityEngine.InputSystem.Controls.StickControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_twist()
  System.Void set_twist(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.Vector2Control get_hatswitch()
  System.Void set_hatswitch(UnityEngine.InputSystem.Controls.Vector2Control value)
  UnityEngine.InputSystem.Joystick get_current()
  System.Void set_current(UnityEngine.InputSystem.Joystick value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Joystick> get_all()
  System.Void FinishSetup()
  System.Void MakeCurrent()
  System.Void OnAdded()
  System.Void OnRemoved()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Key
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Key     None  // 0x0
  public    static  UnityEngine.InputSystem.Key     Space  // 0x0
  public    static  UnityEngine.InputSystem.Key     Enter  // 0x0
  public    static  UnityEngine.InputSystem.Key     Tab  // 0x0
  public    static  UnityEngine.InputSystem.Key     Backquote  // 0x0
  public    static  UnityEngine.InputSystem.Key     Quote  // 0x0
  public    static  UnityEngine.InputSystem.Key     Semicolon  // 0x0
  public    static  UnityEngine.InputSystem.Key     Comma  // 0x0
  public    static  UnityEngine.InputSystem.Key     Period  // 0x0
  public    static  UnityEngine.InputSystem.Key     Slash  // 0x0
  public    static  UnityEngine.InputSystem.Key     Backslash  // 0x0
  public    static  UnityEngine.InputSystem.Key     LeftBracket  // 0x0
  public    static  UnityEngine.InputSystem.Key     RightBracket  // 0x0
  public    static  UnityEngine.InputSystem.Key     Minus  // 0x0
  public    static  UnityEngine.InputSystem.Key     Equals  // 0x0
  public    static  UnityEngine.InputSystem.Key     A  // 0x0
  public    static  UnityEngine.InputSystem.Key     B  // 0x0
  public    static  UnityEngine.InputSystem.Key     C  // 0x0
  public    static  UnityEngine.InputSystem.Key     D  // 0x0
  public    static  UnityEngine.InputSystem.Key     E  // 0x0
  public    static  UnityEngine.InputSystem.Key     F  // 0x0
  public    static  UnityEngine.InputSystem.Key     G  // 0x0
  public    static  UnityEngine.InputSystem.Key     H  // 0x0
  public    static  UnityEngine.InputSystem.Key     I  // 0x0
  public    static  UnityEngine.InputSystem.Key     J  // 0x0
  public    static  UnityEngine.InputSystem.Key     K  // 0x0
  public    static  UnityEngine.InputSystem.Key     L  // 0x0
  public    static  UnityEngine.InputSystem.Key     M  // 0x0
  public    static  UnityEngine.InputSystem.Key     N  // 0x0
  public    static  UnityEngine.InputSystem.Key     O  // 0x0
  public    static  UnityEngine.InputSystem.Key     P  // 0x0
  public    static  UnityEngine.InputSystem.Key     Q  // 0x0
  public    static  UnityEngine.InputSystem.Key     R  // 0x0
  public    static  UnityEngine.InputSystem.Key     S  // 0x0
  public    static  UnityEngine.InputSystem.Key     T  // 0x0
  public    static  UnityEngine.InputSystem.Key     U  // 0x0
  public    static  UnityEngine.InputSystem.Key     V  // 0x0
  public    static  UnityEngine.InputSystem.Key     W  // 0x0
  public    static  UnityEngine.InputSystem.Key     X  // 0x0
  public    static  UnityEngine.InputSystem.Key     Y  // 0x0
  public    static  UnityEngine.InputSystem.Key     Z  // 0x0
  public    static  UnityEngine.InputSystem.Key     Digit1  // 0x0
  public    static  UnityEngine.InputSystem.Key     Digit2  // 0x0
  public    static  UnityEngine.InputSystem.Key     Digit3  // 0x0
  public    static  UnityEngine.InputSystem.Key     Digit4  // 0x0
  public    static  UnityEngine.InputSystem.Key     Digit5  // 0x0
  public    static  UnityEngine.InputSystem.Key     Digit6  // 0x0
  public    static  UnityEngine.InputSystem.Key     Digit7  // 0x0
  public    static  UnityEngine.InputSystem.Key     Digit8  // 0x0
  public    static  UnityEngine.InputSystem.Key     Digit9  // 0x0
  public    static  UnityEngine.InputSystem.Key     Digit0  // 0x0
  public    static  UnityEngine.InputSystem.Key     LeftShift  // 0x0
  public    static  UnityEngine.InputSystem.Key     RightShift  // 0x0
  public    static  UnityEngine.InputSystem.Key     LeftAlt  // 0x0
  public    static  UnityEngine.InputSystem.Key     RightAlt  // 0x0
  public    static  UnityEngine.InputSystem.Key     AltGr  // 0x0
  public    static  UnityEngine.InputSystem.Key     LeftCtrl  // 0x0
  public    static  UnityEngine.InputSystem.Key     RightCtrl  // 0x0
  public    static  UnityEngine.InputSystem.Key     LeftMeta  // 0x0
  public    static  UnityEngine.InputSystem.Key     RightMeta  // 0x0
  public    static  UnityEngine.InputSystem.Key     LeftWindows  // 0x0
  public    static  UnityEngine.InputSystem.Key     RightWindows  // 0x0
  public    static  UnityEngine.InputSystem.Key     LeftApple  // 0x0
  public    static  UnityEngine.InputSystem.Key     RightApple  // 0x0
  public    static  UnityEngine.InputSystem.Key     LeftCommand  // 0x0
  public    static  UnityEngine.InputSystem.Key     RightCommand  // 0x0
  public    static  UnityEngine.InputSystem.Key     ContextMenu  // 0x0
  public    static  UnityEngine.InputSystem.Key     Escape  // 0x0
  public    static  UnityEngine.InputSystem.Key     LeftArrow  // 0x0
  public    static  UnityEngine.InputSystem.Key     RightArrow  // 0x0
  public    static  UnityEngine.InputSystem.Key     UpArrow  // 0x0
  public    static  UnityEngine.InputSystem.Key     DownArrow  // 0x0
  public    static  UnityEngine.InputSystem.Key     Backspace  // 0x0
  public    static  UnityEngine.InputSystem.Key     PageDown  // 0x0
  public    static  UnityEngine.InputSystem.Key     PageUp  // 0x0
  public    static  UnityEngine.InputSystem.Key     Home  // 0x0
  public    static  UnityEngine.InputSystem.Key     End  // 0x0
  public    static  UnityEngine.InputSystem.Key     Insert  // 0x0
  public    static  UnityEngine.InputSystem.Key     Delete  // 0x0
  public    static  UnityEngine.InputSystem.Key     CapsLock  // 0x0
  public    static  UnityEngine.InputSystem.Key     NumLock  // 0x0
  public    static  UnityEngine.InputSystem.Key     PrintScreen  // 0x0
  public    static  UnityEngine.InputSystem.Key     ScrollLock  // 0x0
  public    static  UnityEngine.InputSystem.Key     Pause  // 0x0
  public    static  UnityEngine.InputSystem.Key     NumpadEnter  // 0x0
  public    static  UnityEngine.InputSystem.Key     NumpadDivide  // 0x0
  public    static  UnityEngine.InputSystem.Key     NumpadMultiply  // 0x0
  public    static  UnityEngine.InputSystem.Key     NumpadPlus  // 0x0
  public    static  UnityEngine.InputSystem.Key     NumpadMinus  // 0x0
  public    static  UnityEngine.InputSystem.Key     NumpadPeriod  // 0x0
  public    static  UnityEngine.InputSystem.Key     NumpadEquals  // 0x0
  public    static  UnityEngine.InputSystem.Key     Numpad0  // 0x0
  public    static  UnityEngine.InputSystem.Key     Numpad1  // 0x0
  public    static  UnityEngine.InputSystem.Key     Numpad2  // 0x0
  public    static  UnityEngine.InputSystem.Key     Numpad3  // 0x0
  public    static  UnityEngine.InputSystem.Key     Numpad4  // 0x0
  public    static  UnityEngine.InputSystem.Key     Numpad5  // 0x0
  public    static  UnityEngine.InputSystem.Key     Numpad6  // 0x0
  public    static  UnityEngine.InputSystem.Key     Numpad7  // 0x0
  public    static  UnityEngine.InputSystem.Key     Numpad8  // 0x0
  public    static  UnityEngine.InputSystem.Key     Numpad9  // 0x0
  public    static  UnityEngine.InputSystem.Key     F1  // 0x0
  public    static  UnityEngine.InputSystem.Key     F2  // 0x0
  public    static  UnityEngine.InputSystem.Key     F3  // 0x0
  public    static  UnityEngine.InputSystem.Key     F4  // 0x0
  public    static  UnityEngine.InputSystem.Key     F5  // 0x0
  public    static  UnityEngine.InputSystem.Key     F6  // 0x0
  public    static  UnityEngine.InputSystem.Key     F7  // 0x0
  public    static  UnityEngine.InputSystem.Key     F8  // 0x0
  public    static  UnityEngine.InputSystem.Key     F9  // 0x0
  public    static  UnityEngine.InputSystem.Key     F10  // 0x0
  public    static  UnityEngine.InputSystem.Key     F11  // 0x0
  public    static  UnityEngine.InputSystem.Key     F12  // 0x0
  public    static  UnityEngine.InputSystem.Key     OEM1  // 0x0
  public    static  UnityEngine.InputSystem.Key     OEM2  // 0x0
  public    static  UnityEngine.InputSystem.Key     OEM3  // 0x0
  public    static  UnityEngine.InputSystem.Key     OEM4  // 0x0
  public    static  UnityEngine.InputSystem.Key     OEM5  // 0x0
  public    static  UnityEngine.InputSystem.Key     IMESelected  // 0x0
  public    static  UnityEngine.InputSystem.Key     F13  // 0x0
  public    static  UnityEngine.InputSystem.Key     F14  // 0x0
  public    static  UnityEngine.InputSystem.Key     F15  // 0x0
  public    static  UnityEngine.InputSystem.Key     F16  // 0x0
  public    static  UnityEngine.InputSystem.Key     F17  // 0x0
  public    static  UnityEngine.InputSystem.Key     F18  // 0x0
  public    static  UnityEngine.InputSystem.Key     F19  // 0x0
  public    static  UnityEngine.InputSystem.Key     F20  // 0x0
  public    static  UnityEngine.InputSystem.Key     F21  // 0x0
  public    static  UnityEngine.InputSystem.Key     F22  // 0x0
  public    static  UnityEngine.InputSystem.Key     F23  // 0x0
  public    static  UnityEngine.InputSystem.Key     F24  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.KeyEx
TYPE:  class
TOKEN: 0x200008C
FIELDS:
  private   static  UnityEngine.InputSystem.Key     IMESelected  // 0x0
  private   static  UnityEngine.InputSystem.Key     RemappedIMESelected  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.Keyboard
TYPE:  class
TOKEN: 0x200008D
EXTENDS: InputDevice
FIELDS:
  public    static  System.Int32                    KeyCount  // 0x0
  private   static  System.Int32                    ExtendedKeyCount  // 0x0
  private           UnityEngine.InputSystem.Controls.AnyKeyControl<anyKey>k__BackingField  // 0x190
  private           UnityEngine.InputSystem.Controls.ButtonControl<shiftKey>k__BackingField  // 0x198
  private           UnityEngine.InputSystem.Controls.ButtonControl<ctrlKey>k__BackingField  // 0x1A0
  private           UnityEngine.InputSystem.Controls.ButtonControl<altKey>k__BackingField  // 0x1A8
  private           UnityEngine.InputSystem.Controls.ButtonControl<imeSelected>k__BackingField  // 0x1B0
  private   static  UnityEngine.InputSystem.Keyboard<current>k__BackingField  // 0x0
  private           UnityEngine.InputSystem.Utilities.InlinedArray<System.Action<System.Char>>m_TextInputListeners  // 0x1B8
  private           System.String                   m_KeyboardLayoutName  // 0x1D0
  private           UnityEngine.InputSystem.Controls.KeyControl[]m_Keys  // 0x1D8
  private           UnityEngine.InputSystem.Utilities.InlinedArray<System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString>>m_ImeCompositionListeners  // 0x1E0
METHODS:
  System.Void add_onTextInput(System.Action<System.Char> value)
  System.Void remove_onTextInput(System.Action<System.Char> value)
  System.Void add_onIMECompositionChange(System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString> value)
  System.Void remove_onIMECompositionChange(System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString> value)
  System.Void SetIMEEnabled(System.Boolean enabled)
  System.Void SetIMECursorPosition(UnityEngine.Vector2 position)
  System.String get_keyboardLayout()
  System.Void set_keyboardLayout(System.String value)
  UnityEngine.InputSystem.Controls.AnyKeyControl get_anyKey()
  System.Void set_anyKey(UnityEngine.InputSystem.Controls.AnyKeyControl value)
  UnityEngine.InputSystem.Controls.KeyControl get_spaceKey()
  UnityEngine.InputSystem.Controls.KeyControl get_enterKey()
  UnityEngine.InputSystem.Controls.KeyControl get_tabKey()
  UnityEngine.InputSystem.Controls.KeyControl get_backquoteKey()
  UnityEngine.InputSystem.Controls.KeyControl get_quoteKey()
  UnityEngine.InputSystem.Controls.KeyControl get_semicolonKey()
  UnityEngine.InputSystem.Controls.KeyControl get_commaKey()
  UnityEngine.InputSystem.Controls.KeyControl get_periodKey()
  UnityEngine.InputSystem.Controls.KeyControl get_slashKey()
  UnityEngine.InputSystem.Controls.KeyControl get_backslashKey()
  UnityEngine.InputSystem.Controls.KeyControl get_leftBracketKey()
  UnityEngine.InputSystem.Controls.KeyControl get_rightBracketKey()
  UnityEngine.InputSystem.Controls.KeyControl get_minusKey()
  UnityEngine.InputSystem.Controls.KeyControl get_equalsKey()
  UnityEngine.InputSystem.Controls.KeyControl get_aKey()
  UnityEngine.InputSystem.Controls.KeyControl get_bKey()
  UnityEngine.InputSystem.Controls.KeyControl get_cKey()
  UnityEngine.InputSystem.Controls.KeyControl get_dKey()
  UnityEngine.InputSystem.Controls.KeyControl get_eKey()
  UnityEngine.InputSystem.Controls.KeyControl get_fKey()
  UnityEngine.InputSystem.Controls.KeyControl get_gKey()
  UnityEngine.InputSystem.Controls.KeyControl get_hKey()
  UnityEngine.InputSystem.Controls.KeyControl get_iKey()
  UnityEngine.InputSystem.Controls.KeyControl get_jKey()
  UnityEngine.InputSystem.Controls.KeyControl get_kKey()
  UnityEngine.InputSystem.Controls.KeyControl get_lKey()
  UnityEngine.InputSystem.Controls.KeyControl get_mKey()
  UnityEngine.InputSystem.Controls.KeyControl get_nKey()
  UnityEngine.InputSystem.Controls.KeyControl get_oKey()
  UnityEngine.InputSystem.Controls.KeyControl get_pKey()
  UnityEngine.InputSystem.Controls.KeyControl get_qKey()
  UnityEngine.InputSystem.Controls.KeyControl get_rKey()
  UnityEngine.InputSystem.Controls.KeyControl get_sKey()
  UnityEngine.InputSystem.Controls.KeyControl get_tKey()
  UnityEngine.InputSystem.Controls.KeyControl get_uKey()
  UnityEngine.InputSystem.Controls.KeyControl get_vKey()
  UnityEngine.InputSystem.Controls.KeyControl get_wKey()
  UnityEngine.InputSystem.Controls.KeyControl get_xKey()
  UnityEngine.InputSystem.Controls.KeyControl get_yKey()
  UnityEngine.InputSystem.Controls.KeyControl get_zKey()
  UnityEngine.InputSystem.Controls.KeyControl get_digit1Key()
  UnityEngine.InputSystem.Controls.KeyControl get_digit2Key()
  UnityEngine.InputSystem.Controls.KeyControl get_digit3Key()
  UnityEngine.InputSystem.Controls.KeyControl get_digit4Key()
  UnityEngine.InputSystem.Controls.KeyControl get_digit5Key()
  UnityEngine.InputSystem.Controls.KeyControl get_digit6Key()
  UnityEngine.InputSystem.Controls.KeyControl get_digit7Key()
  UnityEngine.InputSystem.Controls.KeyControl get_digit8Key()
  UnityEngine.InputSystem.Controls.KeyControl get_digit9Key()
  UnityEngine.InputSystem.Controls.KeyControl get_digit0Key()
  UnityEngine.InputSystem.Controls.KeyControl get_leftShiftKey()
  UnityEngine.InputSystem.Controls.KeyControl get_rightShiftKey()
  UnityEngine.InputSystem.Controls.KeyControl get_leftAltKey()
  UnityEngine.InputSystem.Controls.KeyControl get_rightAltKey()
  UnityEngine.InputSystem.Controls.KeyControl get_leftCtrlKey()
  UnityEngine.InputSystem.Controls.KeyControl get_rightCtrlKey()
  UnityEngine.InputSystem.Controls.KeyControl get_leftMetaKey()
  UnityEngine.InputSystem.Controls.KeyControl get_rightMetaKey()
  UnityEngine.InputSystem.Controls.KeyControl get_leftWindowsKey()
  UnityEngine.InputSystem.Controls.KeyControl get_rightWindowsKey()
  UnityEngine.InputSystem.Controls.KeyControl get_leftAppleKey()
  UnityEngine.InputSystem.Controls.KeyControl get_rightAppleKey()
  UnityEngine.InputSystem.Controls.KeyControl get_leftCommandKey()
  UnityEngine.InputSystem.Controls.KeyControl get_rightCommandKey()
  UnityEngine.InputSystem.Controls.KeyControl get_contextMenuKey()
  UnityEngine.InputSystem.Controls.KeyControl get_escapeKey()
  UnityEngine.InputSystem.Controls.KeyControl get_leftArrowKey()
  UnityEngine.InputSystem.Controls.KeyControl get_rightArrowKey()
  UnityEngine.InputSystem.Controls.KeyControl get_upArrowKey()
  UnityEngine.InputSystem.Controls.KeyControl get_downArrowKey()
  UnityEngine.InputSystem.Controls.KeyControl get_backspaceKey()
  UnityEngine.InputSystem.Controls.KeyControl get_pageDownKey()
  UnityEngine.InputSystem.Controls.KeyControl get_pageUpKey()
  UnityEngine.InputSystem.Controls.KeyControl get_homeKey()
  UnityEngine.InputSystem.Controls.KeyControl get_endKey()
  UnityEngine.InputSystem.Controls.KeyControl get_insertKey()
  UnityEngine.InputSystem.Controls.KeyControl get_deleteKey()
  UnityEngine.InputSystem.Controls.KeyControl get_capsLockKey()
  UnityEngine.InputSystem.Controls.KeyControl get_scrollLockKey()
  UnityEngine.InputSystem.Controls.KeyControl get_numLockKey()
  UnityEngine.InputSystem.Controls.KeyControl get_printScreenKey()
  UnityEngine.InputSystem.Controls.KeyControl get_pauseKey()
  UnityEngine.InputSystem.Controls.KeyControl get_numpadEnterKey()
  UnityEngine.InputSystem.Controls.KeyControl get_numpadDivideKey()
  UnityEngine.InputSystem.Controls.KeyControl get_numpadMultiplyKey()
  UnityEngine.InputSystem.Controls.KeyControl get_numpadMinusKey()
  UnityEngine.InputSystem.Controls.KeyControl get_numpadPlusKey()
  UnityEngine.InputSystem.Controls.KeyControl get_numpadPeriodKey()
  UnityEngine.InputSystem.Controls.KeyControl get_numpadEqualsKey()
  UnityEngine.InputSystem.Controls.KeyControl get_numpad0Key()
  UnityEngine.InputSystem.Controls.KeyControl get_numpad1Key()
  UnityEngine.InputSystem.Controls.KeyControl get_numpad2Key()
  UnityEngine.InputSystem.Controls.KeyControl get_numpad3Key()
  UnityEngine.InputSystem.Controls.KeyControl get_numpad4Key()
  UnityEngine.InputSystem.Controls.KeyControl get_numpad5Key()
  UnityEngine.InputSystem.Controls.KeyControl get_numpad6Key()
  UnityEngine.InputSystem.Controls.KeyControl get_numpad7Key()
  UnityEngine.InputSystem.Controls.KeyControl get_numpad8Key()
  UnityEngine.InputSystem.Controls.KeyControl get_numpad9Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f1Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f2Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f3Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f4Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f5Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f6Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f7Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f8Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f9Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f10Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f11Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f12Key()
  UnityEngine.InputSystem.Controls.KeyControl get_oem1Key()
  UnityEngine.InputSystem.Controls.KeyControl get_oem2Key()
  UnityEngine.InputSystem.Controls.KeyControl get_oem3Key()
  UnityEngine.InputSystem.Controls.KeyControl get_oem4Key()
  UnityEngine.InputSystem.Controls.KeyControl get_oem5Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f13Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f14Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f15Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f16Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f17Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f18Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f19Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f20Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f21Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f22Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f23Key()
  UnityEngine.InputSystem.Controls.KeyControl get_f24Key()
  UnityEngine.InputSystem.Controls.ButtonControl get_shiftKey()
  System.Void set_shiftKey(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_ctrlKey()
  System.Void set_ctrlKey(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_altKey()
  System.Void set_altKey(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_imeSelected()
  System.Void set_imeSelected(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.KeyControl get_Item(UnityEngine.InputSystem.Key key)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.KeyControl> get_allKeys()
  UnityEngine.InputSystem.Keyboard get_current()
  System.Void set_current(UnityEngine.InputSystem.Keyboard value)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void RefreshConfiguration()
  System.Void OnTextInput(System.Char character)
  UnityEngine.InputSystem.Controls.KeyControl FindKeyOnCurrentKeyboardLayout(System.String displayName)
  System.Void OnIMECompositionChanged(UnityEngine.InputSystem.LowLevel.IMECompositionString compositionString)
  System.Boolean UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr)
  UnityEngine.InputSystem.Controls.KeyControl[] get_keys()
  System.Void set_keys(UnityEngine.InputSystem.Controls.KeyControl[] value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Mouse
TYPE:  class
TOKEN: 0x200008E
EXTENDS: Pointer
FIELDS:
  private           UnityEngine.InputSystem.Controls.DeltaControl<scroll>k__BackingField  // 0x1C0
  private           UnityEngine.InputSystem.Controls.ButtonControl<leftButton>k__BackingField  // 0x1C8
  private           UnityEngine.InputSystem.Controls.ButtonControl<middleButton>k__BackingField  // 0x1D0
  private           UnityEngine.InputSystem.Controls.ButtonControl<rightButton>k__BackingField  // 0x1D8
  private           UnityEngine.InputSystem.Controls.ButtonControl<backButton>k__BackingField  // 0x1E0
  private           UnityEngine.InputSystem.Controls.ButtonControl<forwardButton>k__BackingField  // 0x1E8
  private           UnityEngine.InputSystem.Controls.IntegerControl<clickCount>k__BackingField  // 0x1F0
  private   static  UnityEngine.InputSystem.Mouse   <current>k__BackingField  // 0x0
  private   static  UnityEngine.InputSystem.Mouse   s_PlatformMouseDevice  // 0x8
METHODS:
  UnityEngine.InputSystem.Controls.DeltaControl get_scroll()
  System.Void set_scroll(UnityEngine.InputSystem.Controls.DeltaControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_leftButton()
  System.Void set_leftButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_middleButton()
  System.Void set_middleButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_rightButton()
  System.Void set_rightButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_backButton()
  System.Void set_backButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_forwardButton()
  System.Void set_forwardButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.IntegerControl get_clickCount()
  System.Void set_clickCount(UnityEngine.InputSystem.Controls.IntegerControl value)
  UnityEngine.InputSystem.Mouse get_current()
  System.Void set_current(UnityEngine.InputSystem.Mouse value)
  System.Void MakeCurrent()
  System.Void OnAdded()
  System.Void OnRemoved()
  System.Void WarpCursorPosition(UnityEngine.Vector2 position)
  System.Void FinishSetup()
  System.Void OnNextUpdate()
  System.Void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate()
  System.Void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.PenButton
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.PenButtonTip  // 0x0
  public    static  UnityEngine.InputSystem.PenButtonEraser  // 0x0
  public    static  UnityEngine.InputSystem.PenButtonBarrelFirst  // 0x0
  public    static  UnityEngine.InputSystem.PenButtonBarrelSecond  // 0x0
  public    static  UnityEngine.InputSystem.PenButtonInRange  // 0x0
  public    static  UnityEngine.InputSystem.PenButtonBarrelThird  // 0x0
  public    static  UnityEngine.InputSystem.PenButtonBarrelFourth  // 0x0
  public    static  UnityEngine.InputSystem.PenButtonBarrel1  // 0x0
  public    static  UnityEngine.InputSystem.PenButtonBarrel2  // 0x0
  public    static  UnityEngine.InputSystem.PenButtonBarrel3  // 0x0
  public    static  UnityEngine.InputSystem.PenButtonBarrel4  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.Pen
TYPE:  class
TOKEN: 0x2000090
EXTENDS: Pointer
FIELDS:
  private           UnityEngine.InputSystem.Controls.ButtonControl<tip>k__BackingField  // 0x1C0
  private           UnityEngine.InputSystem.Controls.ButtonControl<eraser>k__BackingField  // 0x1C8
  private           UnityEngine.InputSystem.Controls.ButtonControl<firstBarrelButton>k__BackingField  // 0x1D0
  private           UnityEngine.InputSystem.Controls.ButtonControl<secondBarrelButton>k__BackingField  // 0x1D8
  private           UnityEngine.InputSystem.Controls.ButtonControl<thirdBarrelButton>k__BackingField  // 0x1E0
  private           UnityEngine.InputSystem.Controls.ButtonControl<fourthBarrelButton>k__BackingField  // 0x1E8
  private           UnityEngine.InputSystem.Controls.ButtonControl<inRange>k__BackingField  // 0x1F0
  private           UnityEngine.InputSystem.Controls.Vector2Control<tilt>k__BackingField  // 0x1F8
  private           UnityEngine.InputSystem.Controls.AxisControl<twist>k__BackingField  // 0x200
  private   static  UnityEngine.InputSystem.Pen     <current>k__BackingField  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.ButtonControl get_tip()
  System.Void set_tip(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_eraser()
  System.Void set_eraser(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_firstBarrelButton()
  System.Void set_firstBarrelButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_secondBarrelButton()
  System.Void set_secondBarrelButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_thirdBarrelButton()
  System.Void set_thirdBarrelButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_fourthBarrelButton()
  System.Void set_fourthBarrelButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_inRange()
  System.Void set_inRange(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.Vector2Control get_tilt()
  System.Void set_tilt(UnityEngine.InputSystem.Controls.Vector2Control value)
  UnityEngine.InputSystem.Controls.AxisControl get_twist()
  System.Void set_twist(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Pen get_current()
  System.Void set_current(UnityEngine.InputSystem.Pen value)
  UnityEngine.InputSystem.Controls.ButtonControl get_Item(UnityEngine.InputSystem.PenButton button)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Pointer
TYPE:  class
TOKEN: 0x2000091
EXTENDS: InputDevice
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector2Control<position>k__BackingField  // 0x190
  private           UnityEngine.InputSystem.Controls.DeltaControl<delta>k__BackingField  // 0x198
  private           UnityEngine.InputSystem.Controls.Vector2Control<radius>k__BackingField  // 0x1A0
  private           UnityEngine.InputSystem.Controls.AxisControl<pressure>k__BackingField  // 0x1A8
  private           UnityEngine.InputSystem.Controls.ButtonControl<press>k__BackingField  // 0x1B0
  private           UnityEngine.InputSystem.Controls.IntegerControl<displayIndex>k__BackingField  // 0x1B8
  private   static  UnityEngine.InputSystem.Pointer <current>k__BackingField  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.Vector2Control get_position()
  System.Void set_position(UnityEngine.InputSystem.Controls.Vector2Control value)
  UnityEngine.InputSystem.Controls.DeltaControl get_delta()
  System.Void set_delta(UnityEngine.InputSystem.Controls.DeltaControl value)
  UnityEngine.InputSystem.Controls.Vector2Control get_radius()
  System.Void set_radius(UnityEngine.InputSystem.Controls.Vector2Control value)
  UnityEngine.InputSystem.Controls.AxisControl get_pressure()
  System.Void set_pressure(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_press()
  System.Void set_press(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.IntegerControl get_displayIndex()
  System.Void set_displayIndex(UnityEngine.InputSystem.Controls.IntegerControl value)
  UnityEngine.InputSystem.Pointer get_current()
  System.Void set_current(UnityEngine.InputSystem.Pointer value)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void OnNextUpdate()
  System.Void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate()
  System.Void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Boolean UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.UInt32& offset)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.FastKeyboard
TYPE:  class
TOKEN: 0x2000092
EXTENDS: Keyboard
FIELDS:
  public    static  System.String                   metadata  // 0x0
METHODS:
  System.Void .ctor()
  UnityEngine.InputSystem.Controls.AnyKeyControl Initialize_ctrlKeyboardanyKey(UnityEngine.InputSystem.Utilities.InternedString kAnyKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardescape(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardspace(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardenter(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardtab(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardbackquote(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardquote(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardsemicolon(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardcomma(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardperiod(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardslash(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardbackslash(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftBracket(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightBracket(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardminus(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardequals(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardupArrow(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboarddownArrow(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftArrow(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightArrow(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboarda(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardb(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardc(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardd(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboarde(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardg(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardh(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardi(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardj(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardk(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardl(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardm(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardn(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardo(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardp(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardq(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardr(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboards(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardt(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardu(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardv(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardw(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardx(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardy(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardz(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard1(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard2(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard3(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard4(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard5(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard6(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard7(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard8(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard9(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard0(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftShift(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightShift(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DiscreteButtonControl Initialize_ctrlKeyboardshift(UnityEngine.InputSystem.Utilities.InternedString kDiscreteButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftAlt(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightAlt(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DiscreteButtonControl Initialize_ctrlKeyboardalt(UnityEngine.InputSystem.Utilities.InternedString kDiscreteButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftCtrl(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightCtrl(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DiscreteButtonControl Initialize_ctrlKeyboardctrl(UnityEngine.InputSystem.Utilities.InternedString kDiscreteButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftMeta(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightMeta(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardcontextMenu(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardbackspace(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardpageDown(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardpageUp(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardhome(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardend(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardinsert(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboarddelete(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardcapsLock(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumLock(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardprintScreen(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardscrollLock(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardpause(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadEnter(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadDivide(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadMultiply(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadPlus(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadMinus(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadPeriod(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadEquals(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad1(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad2(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad3(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad4(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad5(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad6(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad7(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad8(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad9(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad0(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf1(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf2(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf3(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf4(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf5(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf6(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf7(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf8(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf9(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf10(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf11(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf12(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM1(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM2(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM3(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM4(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM5(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf13(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf14(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf15(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf16(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf17(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf18(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf19(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf20(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf21(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf22(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf23(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf24(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlKeyboardIMESelected(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
END_CLASS

CLASS: UnityEngine.InputSystem.FastMouse
TYPE:  class
TOKEN: 0x2000093
EXTENDS: Mouse
FIELDS:
  public    static  System.String                   metadata  // 0x0
METHODS:
  System.Void .ctor()
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlMouseposition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlMousedelta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlMousescroll(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMousepress(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMouseleftButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMouserightButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMousemiddleButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMouseforwardButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMousebackButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousepressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlMouseradius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlMousepointerId(UnityEngine.InputSystem.Utilities.InternedString kDigitalLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlMousedisplayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlMouseclickCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousepositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousepositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrolldown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrolly(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMouseradiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMouseradiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  System.Void OnNextUpdate()
  System.Void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate()
  System.Void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Boolean MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr)
  System.Boolean UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr)
END_CLASS

CLASS: UnityEngine.InputSystem.FastTouchscreen
TYPE:  class
TOKEN: 0x2000094
EXTENDS: Touchscreen
FIELDS:
  public    static  System.String                   metadata  // 0x0
METHODS:
  System.Void .ctor()
  UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreenprimaryTouch(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenposition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreendelta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenpressure(UnityEngine.InputSystem.Utilities.InternedString kAnalogLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenradius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreenpress(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreendisplayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch0(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch1(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch2(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch3(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch4(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch5(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch6(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch7(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch8(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch9(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreenprimaryTouchtouchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenprimaryTouchposition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreenprimaryTouchdelta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchpressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenprimaryTouchradius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreenprimaryTouchphase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreenprimaryTouchpress(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreenprimaryTouchtapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreenprimaryTouchindirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreenprimaryTouchtap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreenprimaryTouchstartTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenprimaryTouchstartPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchpositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchpositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenpositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenpositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenradiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenradiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch0touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch0position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch0delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch0radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch0phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch0press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch0tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch0displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch0indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch0tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch0startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch0startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch1touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch1position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch1delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch1radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch1phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch1press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch1tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch1displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch1indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch1tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch1startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch1startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch2touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch2position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch2delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch2radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch2phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch2press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch2tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch2displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch2indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch2tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch2startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch2startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch3touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch3position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch3delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch3radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch3phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch3press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch3tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch3displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch3indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch3tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch3startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch3startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch4touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch4position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch4delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch4radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch4phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch4press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch4tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch4displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch4indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch4tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch4startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch4startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch5touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch5position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch5delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch5radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch5phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch5press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch5tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch5displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch5indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch5tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch5startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch5startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch6touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch6position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch6delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch6radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch6phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch6press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch6tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch6displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch6indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch6tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch6startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch6startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch7touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch7position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch7delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch7radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch7phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch7press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch7tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch7displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch7indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch7tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch7startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch7startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch8touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch8position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch8delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch8radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch8phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch8press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch8tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch8displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch8indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch8tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch8startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch8startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch9touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch9position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch9delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch9radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch9phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch9press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch9tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch9displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch9indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch9tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch9startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch9startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent)
END_CLASS

CLASS: UnityEngine.InputSystem.InputRemoting
TYPE:  class
TOKEN: 0x2000095
FIELDS:
  private           UnityEngine.InputSystem.InputRemoting.Flagsm_Flags  // 0x10
  private           UnityEngine.InputSystem.InputManagerm_LocalManager  // 0x18
  private           UnityEngine.InputSystem.InputRemoting.Subscriber[]m_Subscribers  // 0x20
  private           UnityEngine.InputSystem.InputRemoting.RemoteSender[]m_Senders  // 0x28
METHODS:
  System.Boolean get_sending()
  System.Void set_sending(System.Boolean value)
  System.Void .ctor(UnityEngine.InputSystem.InputManager manager, System.Boolean startSendingOnConnect)
  System.Void StartSending()
  System.Void StopSending()
  System.Void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(UnityEngine.InputSystem.InputRemoting.Message msg)
  System.Void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(System.Exception error)
  System.Void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted()
  System.IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer)
  System.Void SendInitialMessages()
  System.Void SendAllGeneratedLayouts()
  System.Void SendLayout(System.String layoutName)
  System.Void SendAllDevices()
  System.Void SendDevice(UnityEngine.InputSystem.InputDevice device)
  System.Void SendEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device)
  System.Void SendDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change)
  System.Void SendLayoutChange(System.String layout, UnityEngine.InputSystem.InputControlLayoutChange change)
  System.Void Send(UnityEngine.InputSystem.InputRemoting.Message msg)
  System.Int32 FindOrCreateSenderRecord(System.Int32 senderId)
  UnityEngine.InputSystem.Utilities.InternedString BuildLayoutNamespace(System.Int32 senderId)
  System.Int32 FindLocalDeviceId(System.Int32 remoteDeviceId, System.Int32 senderIndex)
  UnityEngine.InputSystem.InputDevice TryGetDeviceByRemoteId(System.Int32 remoteDeviceId, System.Int32 senderIndex)
  UnityEngine.InputSystem.InputManager get_manager()
  System.Void RemoveRemoteDevices(System.Int32 participantId)
  System.Byte[] SerializeData(TData data)
  TData DeserializeData(System.Byte[] data)
END_CLASS

CLASS: UnityEngine.InputSystem.RemoteInputPlayerConnection
TYPE:  class
TOKEN: 0x20000AA
EXTENDS: ScriptableObject
FIELDS:
  public    static readonly System.Guid                     kNewDeviceMsg  // 0x0
  public    static readonly System.Guid                     kNewLayoutMsg  // 0x10
  public    static readonly System.Guid                     kNewEventsMsg  // 0x20
  public    static readonly System.Guid                     kRemoveDeviceMsg  // 0x30
  public    static readonly System.Guid                     kChangeUsagesMsg  // 0x40
  public    static readonly System.Guid                     kStartSendingMsg  // 0x50
  public    static readonly System.Guid                     kStopSendingMsg  // 0x60
  private           UnityEngine.Networking.PlayerConnection.IEditorPlayerConnectionm_Connection  // 0x18
  private           UnityEngine.InputSystem.RemoteInputPlayerConnection.Subscriber[]m_Subscribers  // 0x20
  private           System.Int32[]                  m_ConnectedIds  // 0x28
METHODS:
  System.Void Bind(UnityEngine.Networking.PlayerConnection.IEditorPlayerConnection connection, System.Boolean isConnected)
  System.IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer)
  System.Void OnConnected(System.Int32 id)
  System.Void OnDisconnected(System.Int32 id)
  System.Void OnNewDevice(UnityEngine.Networking.PlayerConnection.MessageEventArgs args)
  System.Void OnNewLayout(UnityEngine.Networking.PlayerConnection.MessageEventArgs args)
  System.Void OnNewEvents(UnityEngine.Networking.PlayerConnection.MessageEventArgs args)
  System.Void OnRemoveDevice(UnityEngine.Networking.PlayerConnection.MessageEventArgs args)
  System.Void OnChangeUsages(UnityEngine.Networking.PlayerConnection.MessageEventArgs args)
  System.Void OnStartSending(UnityEngine.Networking.PlayerConnection.MessageEventArgs args)
  System.Void OnStopSending(UnityEngine.Networking.PlayerConnection.MessageEventArgs args)
  System.Void SendToSubscribers(UnityEngine.InputSystem.InputRemoting.MessageType type, UnityEngine.Networking.PlayerConnection.MessageEventArgs args)
  System.Void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(UnityEngine.InputSystem.InputRemoting.Message msg)
  System.Void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(System.Exception error)
  System.Void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Sensor
TYPE:  class
TOKEN: 0x20000AC
EXTENDS: InputDevice
FIELDS:
METHODS:
  System.Single get_samplingFrequency()
  System.Void set_samplingFrequency(System.Single value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Accelerometer
TYPE:  class
TOKEN: 0x20000AD
EXTENDS: Sensor
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector3Control<acceleration>k__BackingField  // 0x190
  private   static  UnityEngine.InputSystem.Accelerometer<current>k__BackingField  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.Vector3Control get_acceleration()
  System.Void set_acceleration(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Accelerometer get_current()
  System.Void set_current(UnityEngine.InputSystem.Accelerometer value)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Gyroscope
TYPE:  class
TOKEN: 0x20000AE
EXTENDS: Sensor
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector3Control<angularVelocity>k__BackingField  // 0x190
  private   static  UnityEngine.InputSystem.Gyroscope<current>k__BackingField  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.Vector3Control get_angularVelocity()
  System.Void set_angularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Gyroscope get_current()
  System.Void set_current(UnityEngine.InputSystem.Gyroscope value)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.GravitySensor
TYPE:  class
TOKEN: 0x20000AF
EXTENDS: Sensor
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector3Control<gravity>k__BackingField  // 0x190
  private   static  UnityEngine.InputSystem.GravitySensor<current>k__BackingField  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.Vector3Control get_gravity()
  System.Void set_gravity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.GravitySensor get_current()
  System.Void set_current(UnityEngine.InputSystem.GravitySensor value)
  System.Void FinishSetup()
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.AttitudeSensor
TYPE:  class
TOKEN: 0x20000B0
EXTENDS: Sensor
FIELDS:
  private           UnityEngine.InputSystem.Controls.QuaternionControl<attitude>k__BackingField  // 0x190
  private   static  UnityEngine.InputSystem.AttitudeSensor<current>k__BackingField  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.QuaternionControl get_attitude()
  System.Void set_attitude(UnityEngine.InputSystem.Controls.QuaternionControl value)
  UnityEngine.InputSystem.AttitudeSensor get_current()
  System.Void set_current(UnityEngine.InputSystem.AttitudeSensor value)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.LinearAccelerationSensor
TYPE:  class
TOKEN: 0x20000B1
EXTENDS: Sensor
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector3Control<acceleration>k__BackingField  // 0x190
  private   static  UnityEngine.InputSystem.LinearAccelerationSensor<current>k__BackingField  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.Vector3Control get_acceleration()
  System.Void set_acceleration(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.LinearAccelerationSensor get_current()
  System.Void set_current(UnityEngine.InputSystem.LinearAccelerationSensor value)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.MagneticFieldSensor
TYPE:  class
TOKEN: 0x20000B2
EXTENDS: Sensor
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector3Control<magneticField>k__BackingField  // 0x190
  private   static  UnityEngine.InputSystem.MagneticFieldSensor<current>k__BackingField  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.Vector3Control get_magneticField()
  System.Void set_magneticField(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.MagneticFieldSensor get_current()
  System.Void set_current(UnityEngine.InputSystem.MagneticFieldSensor value)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.LightSensor
TYPE:  class
TOKEN: 0x20000B3
EXTENDS: Sensor
FIELDS:
  private           UnityEngine.InputSystem.Controls.AxisControl<lightLevel>k__BackingField  // 0x190
  private   static  UnityEngine.InputSystem.LightSensor<current>k__BackingField  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.AxisControl get_lightLevel()
  System.Void set_lightLevel(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.LightSensor get_current()
  System.Void set_current(UnityEngine.InputSystem.LightSensor value)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.PressureSensor
TYPE:  class
TOKEN: 0x20000B4
EXTENDS: Sensor
FIELDS:
  private           UnityEngine.InputSystem.Controls.AxisControl<atmosphericPressure>k__BackingField  // 0x190
  private   static  UnityEngine.InputSystem.PressureSensor<current>k__BackingField  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.AxisControl get_atmosphericPressure()
  System.Void set_atmosphericPressure(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.PressureSensor get_current()
  System.Void set_current(UnityEngine.InputSystem.PressureSensor value)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.ProximitySensor
TYPE:  class
TOKEN: 0x20000B5
EXTENDS: Sensor
FIELDS:
  private           UnityEngine.InputSystem.Controls.AxisControl<distance>k__BackingField  // 0x190
  private   static  UnityEngine.InputSystem.ProximitySensor<current>k__BackingField  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.AxisControl get_distance()
  System.Void set_distance(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.ProximitySensor get_current()
  System.Void set_current(UnityEngine.InputSystem.ProximitySensor value)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.HumiditySensor
TYPE:  class
TOKEN: 0x20000B6
EXTENDS: Sensor
FIELDS:
  private           UnityEngine.InputSystem.Controls.AxisControl<relativeHumidity>k__BackingField  // 0x190
  private   static  UnityEngine.InputSystem.HumiditySensor<current>k__BackingField  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.AxisControl get_relativeHumidity()
  System.Void set_relativeHumidity(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.HumiditySensor get_current()
  System.Void set_current(UnityEngine.InputSystem.HumiditySensor value)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.AmbientTemperatureSensor
TYPE:  class
TOKEN: 0x20000B7
EXTENDS: Sensor
FIELDS:
  private           UnityEngine.InputSystem.Controls.AxisControl<ambientTemperature>k__BackingField  // 0x190
  private   static  UnityEngine.InputSystem.AmbientTemperatureSensor<current>k__BackingField  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.AxisControl get_ambientTemperature()
  System.Void set_ambientTemperature(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.AmbientTemperatureSensor get_current()
  System.Void set_current(UnityEngine.InputSystem.AmbientTemperatureSensor value)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.StepCounter
TYPE:  class
TOKEN: 0x20000B8
EXTENDS: Sensor
FIELDS:
  private           UnityEngine.InputSystem.Controls.IntegerControl<stepCounter>k__BackingField  // 0x190
  private   static  UnityEngine.InputSystem.StepCounter<current>k__BackingField  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.IntegerControl get_stepCounter()
  System.Void set_stepCounter(UnityEngine.InputSystem.Controls.IntegerControl value)
  UnityEngine.InputSystem.StepCounter get_current()
  System.Void set_current(UnityEngine.InputSystem.StepCounter value)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.HingeAngle
TYPE:  class
TOKEN: 0x20000B9
EXTENDS: Sensor
FIELDS:
  private           UnityEngine.InputSystem.Controls.AxisControl<angle>k__BackingField  // 0x190
  private   static  UnityEngine.InputSystem.HingeAngle<current>k__BackingField  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.AxisControl get_angle()
  System.Void set_angle(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.HingeAngle get_current()
  System.Void set_current(UnityEngine.InputSystem.HingeAngle value)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.TouchPhase
TYPE:  struct
TOKEN: 0x20000BA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.TouchPhaseNone  // 0x0
  public    static  UnityEngine.InputSystem.TouchPhaseBegan  // 0x0
  public    static  UnityEngine.InputSystem.TouchPhaseMoved  // 0x0
  public    static  UnityEngine.InputSystem.TouchPhaseEnded  // 0x0
  public    static  UnityEngine.InputSystem.TouchPhaseCanceled  // 0x0
  public    static  UnityEngine.InputSystem.TouchPhaseStationary  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.Touchscreen
TYPE:  class
TOKEN: 0x20000BB
EXTENDS: Pointer
FIELDS:
  private           UnityEngine.InputSystem.Controls.TouchControl<primaryTouch>k__BackingField  // 0x1C0
  private           UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl><touches>k__BackingField  // 0x1C8
  private   static readonly Unity.Profiling.ProfilerMarker  k_TouchscreenUpdateMarker  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  k_TouchAllocateMarker  // 0x8
  private   static  UnityEngine.InputSystem.Touchscreen<current>k__BackingField  // 0x10
  private   static  System.Single                   s_TapTime  // 0x18
  private   static  System.Single                   s_TapDelayTime  // 0x1C
  private   static  System.Single                   s_TapRadiusSquared  // 0x20
METHODS:
  UnityEngine.InputSystem.Controls.TouchControl get_primaryTouch()
  System.Void set_primaryTouch(UnityEngine.InputSystem.Controls.TouchControl value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> get_touches()
  System.Void set_touches(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> value)
  UnityEngine.InputSystem.Controls.TouchControl[] get_touchControlArray()
  System.Void set_touchControlArray(UnityEngine.InputSystem.Controls.TouchControl[] value)
  UnityEngine.InputSystem.Touchscreen get_current()
  System.Void set_current(UnityEngine.InputSystem.Touchscreen value)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void OnNextUpdate()
  System.Void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate()
  System.Void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Boolean UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.UInt32& offset)
  System.Void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset()
  System.Boolean MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr)
  System.Boolean UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr)
  System.Void TriggerTap(UnityEngine.InputSystem.Controls.TouchControl control, UnityEngine.InputSystem.LowLevel.TouchState& state, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.TrackedDevice
TYPE:  class
TOKEN: 0x20000BC
EXTENDS: InputDevice
FIELDS:
  private           UnityEngine.InputSystem.Controls.IntegerControl<trackingState>k__BackingField  // 0x190
  private           UnityEngine.InputSystem.Controls.ButtonControl<isTracked>k__BackingField  // 0x198
  private           UnityEngine.InputSystem.Controls.Vector3Control<devicePosition>k__BackingField  // 0x1A0
  private           UnityEngine.InputSystem.Controls.QuaternionControl<deviceRotation>k__BackingField  // 0x1A8
METHODS:
  UnityEngine.InputSystem.Controls.IntegerControl get_trackingState()
  System.Void set_trackingState(UnityEngine.InputSystem.Controls.IntegerControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_isTracked()
  System.Void set_isTracked(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_devicePosition()
  System.Void set_devicePosition(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.QuaternionControl get_deviceRotation()
  System.Void set_deviceRotation(UnityEngine.InputSystem.Controls.QuaternionControl value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.InputExtensions
TYPE:  class
TOKEN: 0x20000BD
FIELDS:
METHODS:
  System.Boolean IsInProgress(UnityEngine.InputSystem.InputActionPhase phase)
  System.Boolean IsEndedOrCanceled(UnityEngine.InputSystem.TouchPhase phase)
  System.Boolean IsActive(UnityEngine.InputSystem.TouchPhase phase)
  System.Boolean IsModifierKey(UnityEngine.InputSystem.Key key)
  System.Boolean IsTextInputKey(UnityEngine.InputSystem.Key key)
END_CLASS

CLASS: UnityEngine.InputSystem.InputFeatureNames
TYPE:  class
TOKEN: 0x20000BE
FIELDS:
  public    static  System.String                   kRunPlayerUpdatesInEditMode  // 0x0
  public    static  System.String                   kDisableUnityRemoteSupport  // 0x0
  public    static  System.String                   kUseOptimizedControls  // 0x0
  public    static  System.String                   kUseReadValueCaching  // 0x0
  public    static  System.String                   kParanoidReadValueCachingChecks  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.InputManager
TYPE:  class
TOKEN: 0x20000BF
FIELDS:
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputUpdateProfilerMarker  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputTryFindMatchingControllerMarker  // 0x8
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputAddDeviceMarker  // 0x10
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputRestoreDevicesAfterReloadMarker  // 0x18
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputRegisterCustomTypesMarker  // 0x20
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputOnBeforeUpdateMarker  // 0x28
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputOnAfterUpdateMarker  // 0x30
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputOnSettingsChangeMarker  // 0x38
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputOnDeviceSettingsChangeMarker  // 0x40
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputOnEventMarker  // 0x48
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputOnLayoutChangeMarker  // 0x50
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputOnDeviceChangeMarker  // 0x58
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputOnActionsChangeMarker  // 0x60
  private           System.Int32                    m_LayoutRegistrationVersion  // 0x10
  private           System.Single                   m_PollingFrequency  // 0x14
  private           UnityEngine.InputSystem.Layouts.InputControlLayout.Collectionm_Layouts  // 0x18
  private           UnityEngine.InputSystem.Utilities.TypeTablem_Processors  // 0x58
  private           UnityEngine.InputSystem.Utilities.TypeTablem_Interactions  // 0x60
  private           UnityEngine.InputSystem.Utilities.TypeTablem_Composites  // 0x68
  private           System.Int32                    m_DevicesCount  // 0x70
  private           UnityEngine.InputSystem.InputDevice[]m_Devices  // 0x78
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.InputSystem.InputDevice>m_DevicesById  // 0x80
  private           System.Int32                    m_AvailableDeviceCount  // 0x88
  private           UnityEngine.InputSystem.InputManager.AvailableDevice[]m_AvailableDevices  // 0x90
  private           System.Int32                    m_DisconnectedDevicesCount  // 0x98
  private           UnityEngine.InputSystem.InputDevice[]m_DisconnectedDevices  // 0xA0
  private           UnityEngine.InputSystem.LowLevel.InputUpdateTypem_UpdateMask  // 0xA8
  private           UnityEngine.InputSystem.LowLevel.InputUpdateTypem_CurrentUpdate  // 0xAC
  private           UnityEngine.InputSystem.LowLevel.InputStateBuffersm_StateBuffers  // 0xB0
  private           UnityEngine.InputSystem.InputSettings.ScrollDeltaBehaviorm_ScrollDeltaBehavior  // 0xE8
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange>>m_DeviceChangeListeners  // 0xF0
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr>>m_DeviceStateChangeListeners  // 0x140
  private           UnityEngine.InputSystem.Utilities.CallbackArray<UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate>m_DeviceFindLayoutCallbacks  // 0x190
  private           UnityEngine.InputSystem.Utilities.CallbackArray<UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate>m_DeviceCommandCallbacks  // 0x1E0
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange>>m_LayoutChangeListeners  // 0x230
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice>>m_EventListeners  // 0x280
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action>m_BeforeUpdateListeners  // 0x2D0
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action>m_AfterUpdateListeners  // 0x320
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action>m_SettingsChangedListeners  // 0x370
  private           System.Boolean                  m_NativeBeforeUpdateHooked  // 0x3C0
  private           System.Boolean                  m_HaveDevicesWithStateCallbackReceivers  // 0x3C1
  private           System.Boolean                  m_HasFocus  // 0x3C2
  private           UnityEngine.InputSystem.LowLevel.InputEventStreamm_InputEventStream  // 0x3C8
  private           UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegatem_DeviceFindExecuteCommandDelegate  // 0x440
  private           System.Int32                    m_DeviceFindExecuteCommandDeviceId  // 0x448
  private           UnityEngine.InputSystem.LowLevel.IInputRuntimem_Runtime  // 0x450
  private           UnityEngine.InputSystem.LowLevel.InputMetricsm_Metrics  // 0x458
  private           UnityEngine.InputSystem.InputSettingsm_Settings  // 0x490
  private           System.Boolean                  m_OptimizedControlsFeatureEnabled  // 0x498
  private           System.Boolean                  m_ReadValueCachingFeatureEnabled  // 0x499
  private           System.Boolean                  m_ParanoidReadValueCachingChecksEnabled  // 0x49A
  private           System.Boolean                  m_ShouldMakeCurrentlyUpdatingDeviceCurrent  // 0x49B
  private           UnityEngine.InputSystem.InputManager.StateChangeMonitorsForDevice[]m_StateChangeMonitors  // 0x4A0
  private           UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputManager.StateChangeMonitorTimeout>m_StateChangeMonitorTimeouts  // 0x4A8
METHODS:
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices()
  UnityEngine.InputSystem.Utilities.TypeTable get_processors()
  UnityEngine.InputSystem.Utilities.TypeTable get_interactions()
  UnityEngine.InputSystem.Utilities.TypeTable get_composites()
  UnityEngine.InputSystem.LowLevel.InputMetrics get_metrics()
  UnityEngine.InputSystem.InputSettings get_settings()
  System.Void set_settings(UnityEngine.InputSystem.InputSettings value)
  UnityEngine.InputSystem.LowLevel.InputUpdateType get_updateMask()
  System.Void set_updateMask(UnityEngine.InputSystem.LowLevel.InputUpdateType value)
  UnityEngine.InputSystem.LowLevel.InputUpdateType get_defaultUpdateType()
  UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior get_scrollDeltaBehavior()
  System.Void set_scrollDeltaBehavior(UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior value)
  System.Single get_pollingFrequency()
  System.Void set_pollingFrequency(System.Single value)
  System.Void add_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value)
  System.Void remove_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value)
  System.Void add_onDeviceStateChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value)
  System.Void remove_onDeviceStateChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value)
  System.Void add_onDeviceCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate value)
  System.Void remove_onDeviceCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate value)
  System.Void add_onFindControlLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate value)
  System.Void remove_onFindControlLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate value)
  System.Void add_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value)
  System.Void remove_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value)
  System.Void add_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> value)
  System.Void remove_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> value)
  System.Void add_onBeforeUpdate(System.Action value)
  System.Void remove_onBeforeUpdate(System.Action value)
  System.Void add_onAfterUpdate(System.Action value)
  System.Void remove_onAfterUpdate(System.Action value)
  System.Void add_onSettingsChange(System.Action value)
  System.Void remove_onSettingsChange(System.Action value)
  System.Boolean get_isProcessingEvents()
  System.Boolean get_gameIsPlaying()
  System.Boolean get_gameHasFocus()
  System.Boolean get_gameShouldGetInputRegardlessOfFocus()
  System.Void RegisterControlLayout(System.String name, System.Type type)
  System.Void RegisterControlLayout(System.String json, System.String name, System.Boolean isOverride)
  System.Void RegisterControlLayoutBuilder(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> method, System.String name, System.String baseLayout)
  System.Void PerformLayoutPostRegistration(UnityEngine.InputSystem.Utilities.InternedString layoutName, UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString> baseLayouts, System.Boolean isReplacement, System.Boolean isKnownToBeDeviceLayout, System.Boolean isOverride)
  System.Void RegisterPrecompiledLayout(System.String metadata)
  System.Void RecreateDevicesUsingLayout(UnityEngine.InputSystem.Utilities.InternedString layout, System.Boolean isKnownToBeDeviceLayout)
  System.Boolean IsControlOrChildUsingLayoutRecursive(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Utilities.InternedString layout)
  System.Boolean IsControlUsingLayout(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Utilities.InternedString layout)
  System.Void RegisterControlLayoutMatcher(System.String layoutName, UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher)
  System.Void RegisterControlLayoutMatcher(System.Type type, UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher)
  System.Void RecreateDevicesUsingLayoutWithInferiorMatch(UnityEngine.InputSystem.Layouts.InputDeviceMatcher deviceMatcher)
  System.Void RecreateDevice(UnityEngine.InputSystem.InputDevice oldDevice, UnityEngine.InputSystem.Utilities.InternedString newLayout)
  System.Void AddAvailableDevicesMatchingDescription(UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher, UnityEngine.InputSystem.Utilities.InternedString layout)
  System.Void RemoveControlLayout(System.String name)
  UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadControlLayout(System.Type type)
  UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadControlLayout(UnityEngine.InputSystem.Utilities.InternedString name)
  UnityEngine.InputSystem.Utilities.InternedString TryFindMatchingControlLayout(UnityEngine.InputSystem.Layouts.InputDeviceDescription& deviceDescription, System.Int32 deviceId)
  UnityEngine.InputSystem.Utilities.InternedString FindOrRegisterDeviceLayoutForType(System.Type type)
  System.Boolean IsDeviceLayoutMarkedAsSupportedInSettings(UnityEngine.InputSystem.Utilities.InternedString layoutName)
  System.Collections.Generic.IEnumerable<System.String> ListControlLayouts(System.String basedOn)
  System.Int32 GetControls(System.String path, UnityEngine.InputSystem.InputControlList<TControl>& controls)
  System.Void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage)
  System.Void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage)
  System.Void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage)
  System.Void NotifyUsageChanged(UnityEngine.InputSystem.InputDevice device)
  UnityEngine.InputSystem.InputDevice AddDevice(System.Type type, System.String name)
  UnityEngine.InputSystem.InputDevice AddDevice(System.String layout, System.String name, UnityEngine.InputSystem.Utilities.InternedString variants)
  UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Utilities.InternedString layout, System.Int32 deviceId, System.String deviceName, UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags, UnityEngine.InputSystem.Utilities.InternedString variants)
  System.Void AddDevice(UnityEngine.InputSystem.InputDevice device)
  UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription description)
  UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription description, System.Boolean throwIfNoLayoutFound, System.String deviceName, System.Int32 deviceId, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags)
  UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription description, UnityEngine.InputSystem.Utilities.InternedString layout, System.String deviceName, System.Int32 deviceId, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags)
  System.Void RemoveDevice(UnityEngine.InputSystem.InputDevice device, System.Boolean keepOnListOfAvailableDevices)
  System.Void FlushDisconnectedDevices()
  System.Void ResetDevice(UnityEngine.InputSystem.InputDevice device, System.Boolean alsoResetDontResetControls, System.Nullable<System.Boolean> issueResetCommand)
  UnityEngine.InputSystem.InputDevice TryGetDevice(System.String nameOrLayout)
  UnityEngine.InputSystem.InputDevice GetDevice(System.String nameOrLayout)
  UnityEngine.InputSystem.InputDevice TryGetDevice(System.Type layoutType)
  UnityEngine.InputSystem.InputDevice TryGetDeviceById(System.Int32 id)
  System.Int32 GetUnsupportedDevices(System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions)
  System.Void EnableOrDisableDevice(UnityEngine.InputSystem.InputDevice device, System.Boolean enable, UnityEngine.InputSystem.InputManager.DeviceDisableScope scope)
  System.Void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr)
  System.Void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr)
  System.Void QueueEvent(TEvent& inputEvent)
  System.Void Update()
  System.Void Update(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
  System.Void Initialize(UnityEngine.InputSystem.LowLevel.IInputRuntime runtime, UnityEngine.InputSystem.InputSettings settings)
  System.Void Destroy()
  System.Void InitializeData()
  System.Void RegisterCustomTypes(System.Type[] types)
  System.Void RegisterCustomTypes()
  System.Void InstallRuntime(UnityEngine.InputSystem.LowLevel.IInputRuntime runtime)
  System.Void InstallGlobals()
  System.Void UninstallGlobals()
  System.Boolean get_optimizedControlsFeatureEnabled()
  System.Void set_optimizedControlsFeatureEnabled(System.Boolean value)
  System.Boolean get_readValueCachingFeatureEnabled()
  System.Void set_readValueCachingFeatureEnabled(System.Boolean value)
  System.Boolean get_paranoidReadValueCachingChecksEnabled()
  System.Void set_paranoidReadValueCachingChecksEnabled(System.Boolean value)
  System.Void MakeDeviceNameUnique(UnityEngine.InputSystem.InputDevice device)
  System.Void ResetControlPathsRecursive(UnityEngine.InputSystem.InputControl control)
  System.Void AssignUniqueDeviceId(UnityEngine.InputSystem.InputDevice device)
  System.Void ReallocateStateBuffers()
  System.Void InitializeDefaultState(UnityEngine.InputSystem.InputDevice device)
  System.Void InitializeDeviceState(UnityEngine.InputSystem.InputDevice device)
  System.Void OnNativeDeviceDiscovered(System.Int32 deviceId, System.String deviceDescriptor)
  UnityEngine.InputSystem.Utilities.JsonParser.JsonString MakeEscapedJsonString(System.String theString)
  UnityEngine.InputSystem.InputDevice TryMatchDisconnectedDevice(System.String deviceDescriptor)
  System.Void InstallBeforeUpdateHookIfNecessary()
  System.Void RestoreDevicesAfterDomainReloadIfNecessary()
  System.Void WarnAboutDevicesFailingToRecreateAfterDomainReload()
  System.Void OnBeforeUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
  System.Void ApplySettings()
  System.Int64 ExecuteGlobalCommand(TCommand& command)
  System.Void AddAvailableDevicesThatAreNowRecognized()
  System.Boolean ShouldRunDeviceInBackground(UnityEngine.InputSystem.InputDevice device)
  System.Void OnFocusChanged(System.Boolean focus)
  System.Boolean ShouldRunUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
  System.Void OnUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, UnityEngine.InputSystem.LowLevel.InputEventBuffer& eventBuffer)
  System.Boolean AreMaximumEventBytesPerUpdateExceeded(System.UInt32 totalEventBytesProcessed)
  System.String MakeStringWithEventsProcessedByDevice()
  System.Void ResetCurrentProcessedEventBytesForDevices()
  System.Void CheckAllDevicesOptimizedControlsHaveValidState()
  System.Void InvokeAfterUpdateCallback(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
  System.Void DontMakeCurrentlyUpdatingDeviceCurrent()
  System.Boolean UpdateState(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
  System.Boolean UpdateState(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, System.Void* statePtr, System.UInt32 stateOffsetInDevice, System.UInt32 stateSize, System.Double internalTime, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void WriteStateChange(UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers buffers, System.Int32 deviceIndex, UnityEngine.InputSystem.LowLevel.InputStateBlock& deviceStateBlock, System.UInt32 stateOffsetInDevice, System.Void* statePtr, System.UInt32 stateSizeInBytes, System.Boolean flippedBuffers)
  System.Boolean FlipBuffersForDeviceIfNecessary(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
  System.Void AddStateChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Int64 monitorIndex, System.UInt32 groupIndex)
  System.Void RemoveStateChangeMonitors(UnityEngine.InputSystem.InputDevice device)
  System.Void RemoveStateChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Int64 monitorIndex)
  System.Void AddStateChangeMonitorTimeout(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Double time, System.Int64 monitorIndex, System.Int32 timerIndex)
  System.Void RemoveStateChangeMonitorTimeout(UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Int64 monitorIndex, System.Int32 timerIndex)
  System.Void SortStateChangeMonitorsIfNecessary(System.Int32 deviceIndex)
  System.Void SignalStateChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor)
  System.Void FireStateChangeNotifications()
  System.Boolean ProcessStateChangeMonitors(System.Int32 deviceIndex, System.Void* newStateFromEvent, System.Void* oldStateOfDevice, System.UInt32 newStateSizeInBytes, System.UInt32 newStateOffsetInBytes)
  System.Void FireStateChangeNotifications(System.Int32 deviceIndex, System.Double internalTime, UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr)
  System.Void ProcessStateChangeMonitorTimeouts()
  System.Void .ctor()
  System.Void .cctor()
  System.Int64 <TryFindMatchingControlLayout>b__88_0(UnityEngine.InputSystem.LowLevel.InputDeviceCommand& commandRef)
END_CLASS

CLASS: UnityEngine.InputSystem.InputSettings
TYPE:  class
TOKEN: 0x20000C8
EXTENDS: ScriptableObject
FIELDS:
  private           System.String[]                 m_SupportedDevices  // 0x18
  private           UnityEngine.InputSystem.InputSettings.UpdateModem_UpdateMode  // 0x20
  private           UnityEngine.InputSystem.InputSettings.ScrollDeltaBehaviorm_ScrollDeltaBehavior  // 0x24
  private           System.Int32                    m_MaxEventBytesPerUpdate  // 0x28
  private           System.Int32                    m_MaxQueuedEventsPerUpdate  // 0x2C
  private           System.Boolean                  m_CompensateForScreenOrientation  // 0x30
  private           UnityEngine.InputSystem.InputSettings.BackgroundBehaviorm_BackgroundBehavior  // 0x34
  private           UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayModem_EditorInputBehaviorInPlayMode  // 0x38
  private           UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerModem_InputActionPropertyDrawerMode  // 0x3C
  private           System.Single                   m_DefaultDeadzoneMin  // 0x40
  private           System.Single                   m_DefaultDeadzoneMax  // 0x44
  private           System.Single                   m_DefaultButtonPressPoint  // 0x48
  private           System.Single                   m_ButtonReleaseThreshold  // 0x4C
  private           System.Single                   m_DefaultTapTime  // 0x50
  private           System.Single                   m_DefaultSlowTapTime  // 0x54
  private           System.Single                   m_DefaultHoldTime  // 0x58
  private           System.Single                   m_TapRadius  // 0x5C
  private           System.Single                   m_MultiTapDelayTime  // 0x60
  private           System.Boolean                  m_DisableRedundantEventsMerging  // 0x64
  private           System.Boolean                  m_ShortcutKeysConsumeInputs  // 0x65
  private           System.Collections.Generic.HashSet<System.String>m_FeatureFlags  // 0x68
  private   static  System.Int32                    s_OldUnsupportedFixedAndDynamicUpdateSetting  // 0x0
METHODS:
  UnityEngine.InputSystem.InputSettings.UpdateMode get_updateMode()
  System.Void set_updateMode(UnityEngine.InputSystem.InputSettings.UpdateMode value)
  UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior get_scrollDeltaBehavior()
  System.Void set_scrollDeltaBehavior(UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior value)
  System.Boolean get_compensateForScreenOrientation()
  System.Void set_compensateForScreenOrientation(System.Boolean value)
  System.Boolean get_filterNoiseOnCurrent()
  System.Void set_filterNoiseOnCurrent(System.Boolean value)
  System.Single get_defaultDeadzoneMin()
  System.Void set_defaultDeadzoneMin(System.Single value)
  System.Single get_defaultDeadzoneMax()
  System.Void set_defaultDeadzoneMax(System.Single value)
  System.Single get_defaultButtonPressPoint()
  System.Void set_defaultButtonPressPoint(System.Single value)
  System.Single get_buttonReleaseThreshold()
  System.Void set_buttonReleaseThreshold(System.Single value)
  System.Single get_defaultTapTime()
  System.Void set_defaultTapTime(System.Single value)
  System.Single get_defaultSlowTapTime()
  System.Void set_defaultSlowTapTime(System.Single value)
  System.Single get_defaultHoldTime()
  System.Void set_defaultHoldTime(System.Single value)
  System.Single get_tapRadius()
  System.Void set_tapRadius(System.Single value)
  System.Single get_multiTapDelayTime()
  System.Void set_multiTapDelayTime(System.Single value)
  UnityEngine.InputSystem.InputSettings.BackgroundBehavior get_backgroundBehavior()
  System.Void set_backgroundBehavior(UnityEngine.InputSystem.InputSettings.BackgroundBehavior value)
  UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode get_editorInputBehaviorInPlayMode()
  System.Void set_editorInputBehaviorInPlayMode(UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode value)
  UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode get_inputActionPropertyDrawerMode()
  System.Void set_inputActionPropertyDrawerMode(UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode value)
  System.Int32 get_maxEventBytesPerUpdate()
  System.Void set_maxEventBytesPerUpdate(System.Int32 value)
  System.Int32 get_maxQueuedEventsPerUpdate()
  System.Void set_maxQueuedEventsPerUpdate(System.Int32 value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.String> get_supportedDevices()
  System.Void set_supportedDevices(UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.String> value)
  System.Boolean get_disableRedundantEventsMerging()
  System.Void set_disableRedundantEventsMerging(System.Boolean value)
  System.Boolean get_shortcutKeysConsumeInput()
  System.Void set_shortcutKeysConsumeInput(System.Boolean value)
  System.Void SetInternalFeatureFlag(System.String featureName, System.Boolean enabled)
  System.Boolean IsFeatureEnabled(System.String featureName)
  System.Void OnChange()
  System.Boolean CompareFloats(System.Single a, System.Single b)
  System.Boolean CompareSets(UnityEngine.InputSystem.Utilities.ReadOnlyArray<T> a, UnityEngine.InputSystem.Utilities.ReadOnlyArray<T> b)
  System.Boolean CompareFeatureFlag(UnityEngine.InputSystem.InputSettings a, UnityEngine.InputSystem.InputSettings b, System.String featureName)
  System.Boolean AreEqual(UnityEngine.InputSystem.InputSettings a, UnityEngine.InputSystem.InputSettings b)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.DefaultInputActions
TYPE:  class
TOKEN: 0x20000CE
FIELDS:
  private   readonly UnityEngine.InputSystem.InputActionAsset<asset>k__BackingField  // 0x10
  private   readonly UnityEngine.InputSystem.InputActionMapm_Player  // 0x18
  private           UnityEngine.InputSystem.DefaultInputActions.IPlayerActionsm_PlayerActionsCallbackInterface  // 0x20
  private   readonly UnityEngine.InputSystem.InputActionm_Player_Move  // 0x28
  private   readonly UnityEngine.InputSystem.InputActionm_Player_Look  // 0x30
  private   readonly UnityEngine.InputSystem.InputActionm_Player_Fire  // 0x38
  private   readonly UnityEngine.InputSystem.InputActionMapm_UI  // 0x40
  private           UnityEngine.InputSystem.DefaultInputActions.IUIActionsm_UIActionsCallbackInterface  // 0x48
  private   readonly UnityEngine.InputSystem.InputActionm_UI_Navigate  // 0x50
  private   readonly UnityEngine.InputSystem.InputActionm_UI_Submit  // 0x58
  private   readonly UnityEngine.InputSystem.InputActionm_UI_Cancel  // 0x60
  private   readonly UnityEngine.InputSystem.InputActionm_UI_Point  // 0x68
  private   readonly UnityEngine.InputSystem.InputActionm_UI_Click  // 0x70
  private   readonly UnityEngine.InputSystem.InputActionm_UI_ScrollWheel  // 0x78
  private   readonly UnityEngine.InputSystem.InputActionm_UI_MiddleClick  // 0x80
  private   readonly UnityEngine.InputSystem.InputActionm_UI_RightClick  // 0x88
  private   readonly UnityEngine.InputSystem.InputActionm_UI_TrackedDevicePosition  // 0x90
  private   readonly UnityEngine.InputSystem.InputActionm_UI_TrackedDeviceOrientation  // 0x98
  private           System.Int32                    m_KeyboardMouseSchemeIndex  // 0xA0
  private           System.Int32                    m_GamepadSchemeIndex  // 0xA4
  private           System.Int32                    m_TouchSchemeIndex  // 0xA8
  private           System.Int32                    m_JoystickSchemeIndex  // 0xAC
  private           System.Int32                    m_XRSchemeIndex  // 0xB0
METHODS:
  UnityEngine.InputSystem.InputActionAsset get_asset()
  System.Void .ctor()
  System.Void Dispose()
  System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask()
  System.Void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value)
  System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices()
  System.Void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes()
  System.Boolean Contains(UnityEngine.InputSystem.InputAction action)
  System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void Enable()
  System.Void Disable()
  System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings()
  UnityEngine.InputSystem.InputAction FindAction(System.String actionNameOrId, System.Boolean throwIfNotFound)
  System.Int32 FindBinding(UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.InputAction& action)
  UnityEngine.InputSystem.DefaultInputActions.PlayerActions get_Player()
  UnityEngine.InputSystem.DefaultInputActions.UIActions get_UI()
  UnityEngine.InputSystem.InputControlScheme get_KeyboardMouseScheme()
  UnityEngine.InputSystem.InputControlScheme get_GamepadScheme()
  UnityEngine.InputSystem.InputControlScheme get_TouchScheme()
  UnityEngine.InputSystem.InputControlScheme get_JoystickScheme()
  UnityEngine.InputSystem.InputControlScheme get_XRScheme()
END_CLASS

CLASS: UnityEngine.InputSystem.InputValue
TYPE:  class
TOKEN: 0x20000D3
FIELDS:
  private           System.Nullable<UnityEngine.InputSystem.InputAction.CallbackContext>m_Context  // 0x10
METHODS:
  System.Object Get()
  TValue Get()
  System.Boolean get_isPressed()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.PlayerInput
TYPE:  class
TOKEN: 0x20000D4
EXTENDS: MonoBehaviour
FIELDS:
  public    static  System.String                   DeviceLostMessage  // 0x0
  public    static  System.String                   DeviceRegainedMessage  // 0x0
  public    static  System.String                   ControlsChangedMessage  // 0x0
  private           System.Int32                    m_AllMapsHashCode  // 0x18
  private           UnityEngine.InputSystem.InputActionAssetm_Actions  // 0x20
  private           UnityEngine.InputSystem.PlayerNotificationsm_NotificationBehavior  // 0x28
  private           UnityEngine.InputSystem.UI.InputSystemUIInputModulem_UIInputModule  // 0x30
  private           UnityEngine.InputSystem.PlayerInput.DeviceLostEventm_DeviceLostEvent  // 0x38
  private           UnityEngine.InputSystem.PlayerInput.DeviceRegainedEventm_DeviceRegainedEvent  // 0x40
  private           UnityEngine.InputSystem.PlayerInput.ControlsChangedEventm_ControlsChangedEvent  // 0x48
  private           UnityEngine.InputSystem.PlayerInput.ActionEvent[]m_ActionEvents  // 0x50
  private           System.Boolean                  m_NeverAutoSwitchControlSchemes  // 0x58
  private           System.String                   m_DefaultControlScheme  // 0x60
  private           System.String                   m_DefaultActionMap  // 0x68
  private           System.Int32                    m_SplitScreenIndex  // 0x70
  private           UnityEngine.Camera              m_Camera  // 0x78
  private           UnityEngine.InputSystem.InputValuem_InputValueObject  // 0x80
  private           UnityEngine.InputSystem.InputActionMapm_CurrentActionMap  // 0x88
  private           System.Int32                    m_PlayerIndex  // 0x90
  private           System.Boolean                  m_InputActive  // 0x94
  private           System.Boolean                  m_Enabled  // 0x95
  private           System.Boolean                  m_ActionsInitialized  // 0x96
  private           System.Collections.Generic.Dictionary<System.String,System.String>m_ActionMessageNames  // 0x98
  private           UnityEngine.InputSystem.Users.InputUserm_InputUser  // 0xA0
  private           System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>m_ActionTriggeredDelegate  // 0xA8
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>>m_DeviceLostCallbacks  // 0xB0
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>>m_DeviceRegainedCallbacks  // 0x100
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>>m_ControlsChangedCallbacks  // 0x150
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>>m_ActionTriggeredCallbacks  // 0x1A0
  private           System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr>m_UnpairedDeviceUsedDelegate  // 0x1F0
  private           System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean>m_PreFilterUnpairedDeviceUsedDelegate  // 0x1F8
  private           System.Boolean                  m_OnUnpairedDeviceUsedHooked  // 0x200
  private           System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange>m_DeviceChangeDelegate  // 0x208
  private           System.Boolean                  m_OnDeviceChangeHooked  // 0x210
  private   static  System.Int32                    s_AllActivePlayersCount  // 0x0
  private   static  UnityEngine.InputSystem.PlayerInput[]s_AllActivePlayers  // 0x8
  private   static  System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice>s_UserChangeDelegate  // 0x10
  private   static  System.Int32                    s_InitPairWithDevicesCount  // 0x18
  private   static  UnityEngine.InputSystem.InputDevice[]s_InitPairWithDevices  // 0x20
  private   static  System.Int32                    s_InitPlayerIndex  // 0x28
  private   static  System.Int32                    s_InitSplitScreenIndex  // 0x2C
  private   static  System.String                   s_InitControlScheme  // 0x30
  private   static  System.Boolean                  s_DestroyIfDeviceSetupUnsuccessful  // 0x38
METHODS:
  System.Boolean get_inputIsActive()
  System.Boolean get_active()
  System.Int32 get_playerIndex()
  System.Int32 get_splitScreenIndex()
  UnityEngine.InputSystem.InputActionAsset get_actions()
  System.Void set_actions(UnityEngine.InputSystem.InputActionAsset value)
  System.String get_currentControlScheme()
  System.String get_defaultControlScheme()
  System.Void set_defaultControlScheme(System.String value)
  System.Boolean get_neverAutoSwitchControlSchemes()
  System.Void set_neverAutoSwitchControlSchemes(System.Boolean value)
  UnityEngine.InputSystem.InputActionMap get_currentActionMap()
  System.Void set_currentActionMap(UnityEngine.InputSystem.InputActionMap value)
  System.String get_defaultActionMap()
  System.Void set_defaultActionMap(System.String value)
  UnityEngine.InputSystem.PlayerNotifications get_notificationBehavior()
  System.Void set_notificationBehavior(UnityEngine.InputSystem.PlayerNotifications value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> get_actionEvents()
  System.Void set_actionEvents(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> value)
  UnityEngine.InputSystem.PlayerInput.DeviceLostEvent get_deviceLostEvent()
  UnityEngine.InputSystem.PlayerInput.DeviceRegainedEvent get_deviceRegainedEvent()
  UnityEngine.InputSystem.PlayerInput.ControlsChangedEvent get_controlsChangedEvent()
  System.Void add_onActionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value)
  System.Void remove_onActionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value)
  System.Void add_onDeviceLost(System.Action<UnityEngine.InputSystem.PlayerInput> value)
  System.Void remove_onDeviceLost(System.Action<UnityEngine.InputSystem.PlayerInput> value)
  System.Void add_onDeviceRegained(System.Action<UnityEngine.InputSystem.PlayerInput> value)
  System.Void remove_onDeviceRegained(System.Action<UnityEngine.InputSystem.PlayerInput> value)
  System.Void add_onControlsChanged(System.Action<UnityEngine.InputSystem.PlayerInput> value)
  System.Void remove_onControlsChanged(System.Action<UnityEngine.InputSystem.PlayerInput> value)
  UnityEngine.Camera get_camera()
  System.Void set_camera(UnityEngine.Camera value)
  UnityEngine.InputSystem.UI.InputSystemUIInputModule get_uiInputModule()
  System.Void set_uiInputModule(UnityEngine.InputSystem.UI.InputSystemUIInputModule value)
  UnityEngine.InputSystem.Users.InputUser get_user()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices()
  System.Boolean get_hasMissingRequiredDevices()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput> get_all()
  System.Boolean get_isSinglePlayer()
  TDevice GetDevice()
  System.Void ActivateInput()
  System.Void UpdateDelegates()
  System.Void DeactivateInput()
  System.Void PassivateInput()
  System.Boolean SwitchCurrentControlScheme(UnityEngine.InputSystem.InputDevice[] devices)
  System.Void SwitchCurrentControlScheme(System.String controlScheme, UnityEngine.InputSystem.InputDevice[] devices)
  System.Void SwitchCurrentActionMap(System.String mapNameOrId)
  UnityEngine.InputSystem.PlayerInput GetPlayerByIndex(System.Int32 playerIndex)
  UnityEngine.InputSystem.PlayerInput FindFirstPairedToDevice(UnityEngine.InputSystem.InputDevice device)
  UnityEngine.InputSystem.PlayerInput Instantiate(UnityEngine.GameObject prefab, System.Int32 playerIndex, System.String controlScheme, System.Int32 splitScreenIndex, UnityEngine.InputSystem.InputDevice pairWithDevice)
  UnityEngine.InputSystem.PlayerInput Instantiate(UnityEngine.GameObject prefab, System.Int32 playerIndex, System.String controlScheme, System.Int32 splitScreenIndex, UnityEngine.InputSystem.InputDevice[] pairWithDevices)
  UnityEngine.InputSystem.PlayerInput DoInstantiate(UnityEngine.GameObject prefab)
  System.Void InitializeActions()
  System.Void CopyActionAssetAndApplyBindingOverrides()
  System.Void UninitializeActions()
  System.Void InstallOnActionTriggeredHook()
  System.Void UninstallOnActionTriggeredHook()
  System.Void OnActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void CacheMessageNames()
  System.Void ClearCaches()
  System.Void AssignUserAndDevices()
  System.Boolean HaveBindingForDevice(UnityEngine.InputSystem.InputDevice device)
  System.Void UnassignUserAndDevices()
  System.Boolean TryToActivateControlScheme(UnityEngine.InputSystem.InputControlScheme controlScheme)
  System.Void AssignPlayerIndex()
  System.Void Awake()
  System.Void OnEnable()
  System.Void StartListeningForUnpairedDeviceActivity()
  System.Void StopListeningForUnpairedDeviceActivity()
  System.Void StartListeningForDeviceChanges()
  System.Void StopListeningForDeviceChanges()
  System.Void OnDisable()
  System.Void DebugLogAction(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void HandleDeviceLost()
  System.Void HandleDeviceRegained()
  System.Void HandleControlsChanged()
  System.Void OnUserChange(UnityEngine.InputSystem.Users.InputUser user, UnityEngine.InputSystem.Users.InputUserChange change, UnityEngine.InputSystem.InputDevice device)
  System.Boolean OnPreFilterUnpairedDeviceUsed(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void OnUnpairedDeviceUsed(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change)
  System.Void SwitchControlSchemeInternal(UnityEngine.InputSystem.InputControlScheme& controlScheme, UnityEngine.InputSystem.InputDevice[] devices)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.PlayerInputManager
TYPE:  class
TOKEN: 0x20000D9
EXTENDS: MonoBehaviour
FIELDS:
  public    static  System.String                   PlayerJoinedMessage  // 0x0
  public    static  System.String                   PlayerLeftMessage  // 0x0
  private   static  UnityEngine.InputSystem.PlayerInputManager<instance>k__BackingField  // 0x0
  private           UnityEngine.InputSystem.PlayerNotificationsm_NotificationBehavior  // 0x18
  private           System.Int32                    m_MaxPlayerCount  // 0x1C
  private           System.Boolean                  m_AllowJoining  // 0x20
  private           UnityEngine.InputSystem.PlayerJoinBehaviorm_JoinBehavior  // 0x24
  private           UnityEngine.InputSystem.PlayerInputManager.PlayerJoinedEventm_PlayerJoinedEvent  // 0x28
  private           UnityEngine.InputSystem.PlayerInputManager.PlayerLeftEventm_PlayerLeftEvent  // 0x30
  private           UnityEngine.InputSystem.InputActionPropertym_JoinAction  // 0x38
  private           UnityEngine.GameObject          m_PlayerPrefab  // 0x50
  private           System.Boolean                  m_SplitScreen  // 0x58
  private           System.Boolean                  m_MaintainAspectRatioInSplitScreen  // 0x59
  private           System.Int32                    m_FixedNumberOfSplitScreens  // 0x5C
  private           UnityEngine.Rect                m_SplitScreenRect  // 0x60
  private           System.Boolean                  m_JoinActionDelegateHooked  // 0x70
  private           System.Boolean                  m_UnpairedDeviceUsedDelegateHooked  // 0x71
  private           System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>m_JoinActionDelegate  // 0x78
  private           System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr>m_UnpairedDeviceUsedDelegate  // 0x80
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>>m_PlayerJoinedCallbacks  // 0x88
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>>m_PlayerLeftCallbacks  // 0xD8
METHODS:
  System.Boolean get_splitScreen()
  System.Void set_splitScreen(System.Boolean value)
  System.Boolean get_maintainAspectRatioInSplitScreen()
  System.Int32 get_fixedNumberOfSplitScreens()
  UnityEngine.Rect get_splitScreenArea()
  System.Int32 get_playerCount()
  System.Int32 get_maxPlayerCount()
  System.Boolean get_joiningEnabled()
  UnityEngine.InputSystem.PlayerJoinBehavior get_joinBehavior()
  System.Void set_joinBehavior(UnityEngine.InputSystem.PlayerJoinBehavior value)
  UnityEngine.InputSystem.InputActionProperty get_joinAction()
  System.Void set_joinAction(UnityEngine.InputSystem.InputActionProperty value)
  UnityEngine.InputSystem.PlayerNotifications get_notificationBehavior()
  System.Void set_notificationBehavior(UnityEngine.InputSystem.PlayerNotifications value)
  UnityEngine.InputSystem.PlayerInputManager.PlayerJoinedEvent get_playerJoinedEvent()
  UnityEngine.InputSystem.PlayerInputManager.PlayerLeftEvent get_playerLeftEvent()
  System.Void add_onPlayerJoined(System.Action<UnityEngine.InputSystem.PlayerInput> value)
  System.Void remove_onPlayerJoined(System.Action<UnityEngine.InputSystem.PlayerInput> value)
  System.Void add_onPlayerLeft(System.Action<UnityEngine.InputSystem.PlayerInput> value)
  System.Void remove_onPlayerLeft(System.Action<UnityEngine.InputSystem.PlayerInput> value)
  UnityEngine.GameObject get_playerPrefab()
  System.Void set_playerPrefab(UnityEngine.GameObject value)
  UnityEngine.InputSystem.PlayerInputManager get_instance()
  System.Void set_instance(UnityEngine.InputSystem.PlayerInputManager value)
  System.Void EnableJoining()
  System.Void DisableJoining()
  System.Void JoinPlayerFromUI()
  System.Void JoinPlayerFromAction(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void JoinPlayerFromActionIfNotAlreadyJoined(UnityEngine.InputSystem.InputAction.CallbackContext context)
  UnityEngine.InputSystem.PlayerInput JoinPlayer(System.Int32 playerIndex, System.Int32 splitScreenIndex, System.String controlScheme, UnityEngine.InputSystem.InputDevice pairWithDevice)
  UnityEngine.InputSystem.PlayerInput JoinPlayer(System.Int32 playerIndex, System.Int32 splitScreenIndex, System.String controlScheme, UnityEngine.InputSystem.InputDevice[] pairWithDevices)
  System.String[] get_messages()
  System.Boolean CheckIfPlayerCanJoin(System.Int32 playerIndex)
  System.Void OnUnpairedDeviceUsed(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void UpdateSplitScreen()
  System.Boolean IsDeviceUsableWithPlayerActions(UnityEngine.InputSystem.InputDevice device)
  System.Void ValidateInputActionAsset()
  System.Void NotifyPlayerJoined(UnityEngine.InputSystem.PlayerInput player)
  System.Void NotifyPlayerLeft(UnityEngine.InputSystem.PlayerInput player)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.PlayerJoinBehavior
TYPE:  struct
TOKEN: 0x20000DC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.PlayerJoinBehaviorJoinPlayersWhenButtonIsPressed  // 0x0
  public    static  UnityEngine.InputSystem.PlayerJoinBehaviorJoinPlayersWhenJoinActionIsTriggered  // 0x0
  public    static  UnityEngine.InputSystem.PlayerJoinBehaviorJoinPlayersManually  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.PlayerNotifications
TYPE:  struct
TOKEN: 0x20000DD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.PlayerNotificationsSendMessages  // 0x0
  public    static  UnityEngine.InputSystem.PlayerNotificationsBroadcastMessages  // 0x0
  public    static  UnityEngine.InputSystem.PlayerNotificationsInvokeUnityEvents  // 0x0
  public    static  UnityEngine.InputSystem.PlayerNotificationsInvokeCSharpEvents  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.DynamicBitfield
TYPE:  struct
TOKEN: 0x20000DE
FIELDS:
  public            UnityEngine.InputSystem.Utilities.InlinedArray<System.UInt64>array  // 0x10
  public            System.Int32                    length  // 0x28
METHODS:
  System.Void SetLength(System.Int32 newLength)
  System.Void SetBit(System.Int32 bitIndex)
  System.Boolean TestBit(System.Int32 bitIndex)
  System.Void ClearBit(System.Int32 bitIndex)
  System.Boolean AnyBitIsSet()
  System.Int32 BitCountToULongCount(System.Int32 bitCount)
END_CLASS

CLASS: UnityEngine.InputSystem.Composites.AxisComposite
TYPE:  class
TOKEN: 0x200026E
EXTENDS: InputBindingComposite`1
FIELDS:
  public            System.Int32                    negative  // 0x10
  public            System.Int32                    positive  // 0x14
  public            System.Single                   minValue  // 0x18
  public            System.Single                   maxValue  // 0x1C
  public            UnityEngine.InputSystem.Composites.AxisComposite.WhichSideWinswhichSideWins  // 0x20
METHODS:
  System.Single get_midPoint()
  System.Single ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Single EvaluateMagnitude(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Composites.ButtonWithOneModifier
TYPE:  class
TOKEN: 0x2000270
EXTENDS: InputBindingComposite`1
FIELDS:
  public            System.Int32                    modifier  // 0x10
  public            System.Int32                    button  // 0x14
  public            System.Boolean                  overrideModifiersNeedToBePressedFirst  // 0x18
  public            UnityEngine.InputSystem.Composites.ButtonWithOneModifier.ModifiersOrdermodifiersOrder  // 0x1C
METHODS:
  System.Single ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Boolean ModifierIsPressed(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Single EvaluateMagnitude(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void FinishSetup(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Composites.ButtonWithTwoModifiers
TYPE:  class
TOKEN: 0x2000272
EXTENDS: InputBindingComposite`1
FIELDS:
  public            System.Int32                    modifier1  // 0x10
  public            System.Int32                    modifier2  // 0x14
  public            System.Int32                    button  // 0x18
  public            System.Boolean                  overrideModifiersNeedToBePressedFirst  // 0x1C
  public            UnityEngine.InputSystem.Composites.ButtonWithTwoModifiers.ModifiersOrdermodifiersOrder  // 0x20
METHODS:
  System.Single ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Boolean ModifiersArePressed(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Single EvaluateMagnitude(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void FinishSetup(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Composites.OneModifierComposite
TYPE:  class
TOKEN: 0x2000274
EXTENDS: InputBindingComposite
FIELDS:
  public            System.Int32                    modifier  // 0x10
  public            System.Int32                    binding  // 0x14
  public            System.Boolean                  overrideModifiersNeedToBePressedFirst  // 0x18
  public            UnityEngine.InputSystem.Composites.OneModifierComposite.ModifiersOrdermodifiersOrder  // 0x1C
  private           System.Int32                    m_ValueSizeInBytes  // 0x20
  private           System.Type                     m_ValueType  // 0x28
  private           System.Boolean                  m_BindingIsButton  // 0x30
METHODS:
  System.Type get_valueType()
  System.Int32 get_valueSizeInBytes()
  System.Single EvaluateMagnitude(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context, System.Void* buffer, System.Int32 bufferSize)
  System.Boolean ModifierIsPressed(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void FinishSetup(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Object ReadValueAsObject(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void DetermineValueTypeAndSize(UnityEngine.InputSystem.InputBindingCompositeContext& context, System.Int32 part, System.Type& valueType, System.Int32& valueSizeInBytes, System.Boolean& isButton)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Composites.TwoModifiersComposite
TYPE:  class
TOKEN: 0x2000276
EXTENDS: InputBindingComposite
FIELDS:
  public            System.Int32                    modifier1  // 0x10
  public            System.Int32                    modifier2  // 0x14
  public            System.Int32                    binding  // 0x18
  public            System.Boolean                  overrideModifiersNeedToBePressedFirst  // 0x1C
  public            UnityEngine.InputSystem.Composites.TwoModifiersComposite.ModifiersOrdermodifiersOrder  // 0x20
  private           System.Int32                    m_ValueSizeInBytes  // 0x24
  private           System.Type                     m_ValueType  // 0x28
  private           System.Boolean                  m_BindingIsButton  // 0x30
METHODS:
  System.Type get_valueType()
  System.Int32 get_valueSizeInBytes()
  System.Single EvaluateMagnitude(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context, System.Void* buffer, System.Int32 bufferSize)
  System.Boolean ModifiersArePressed(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void FinishSetup(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Object ReadValueAsObject(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Composites.Vector2Composite
TYPE:  class
TOKEN: 0x2000278
EXTENDS: InputBindingComposite`1
FIELDS:
  public            System.Int32                    up  // 0x10
  public            System.Int32                    down  // 0x14
  public            System.Int32                    left  // 0x18
  public            System.Int32                    right  // 0x1C
  public            System.Boolean                  normalize  // 0x20
  public            UnityEngine.InputSystem.Composites.Vector2Composite.Modemode  // 0x24
METHODS:
  UnityEngine.Vector2 ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Single EvaluateMagnitude(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Composites.Vector3Composite
TYPE:  class
TOKEN: 0x200027A
EXTENDS: InputBindingComposite`1
FIELDS:
  public            System.Int32                    up  // 0x10
  public            System.Int32                    down  // 0x14
  public            System.Int32                    left  // 0x18
  public            System.Int32                    right  // 0x1C
  public            System.Int32                    forward  // 0x20
  public            System.Int32                    backward  // 0x24
  public            UnityEngine.InputSystem.Composites.Vector3Composite.Modemode  // 0x28
METHODS:
  UnityEngine.Vector3 ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Single EvaluateMagnitude(UnityEngine.InputSystem.InputBindingCompositeContext& context)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Controls.AnyKeyControl
TYPE:  class
TOKEN: 0x2000216
EXTENDS: ButtonControl
FIELDS:
METHODS:
  System.Void .ctor()
  System.Single ReadUnprocessedValueFromState(System.Void* statePtr)
END_CLASS

CLASS: UnityEngine.InputSystem.Controls.AxisControl
TYPE:  class
TOKEN: 0x2000217
EXTENDS: InputControl`1
FIELDS:
  public            UnityEngine.InputSystem.Controls.AxisControl.Clampclamp  // 0x108
  public            System.Single                   clampMin  // 0x10C
  public            System.Single                   clampMax  // 0x110
  public            System.Single                   clampConstant  // 0x114
  public            System.Boolean                  invert  // 0x118
  public            System.Boolean                  normalize  // 0x119
  public            System.Single                   normalizeMin  // 0x11C
  public            System.Single                   normalizeMax  // 0x120
  public            System.Single                   normalizeZero  // 0x124
  public            System.Boolean                  scale  // 0x128
  public            System.Single                   scaleFactor  // 0x12C
METHODS:
  System.Single Preprocess(System.Single value)
  System.Single Unpreprocess(System.Single value)
  System.Void .ctor()
  System.Void FinishSetup()
  System.Single ReadUnprocessedValueFromState(System.Void* statePtr)
  System.Void WriteValueIntoState(System.Single value, System.Void* statePtr)
  System.Boolean CompareValue(System.Void* firstStatePtr, System.Void* secondStatePtr)
  System.Single EvaluateMagnitude(System.Void* statePtr)
  System.Single EvaluateMagnitude(System.Single value)
  UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType()
END_CLASS

CLASS: UnityEngine.InputSystem.Controls.ButtonControl
TYPE:  class
TOKEN: 0x2000219
EXTENDS: AxisControl
FIELDS:
  private           System.Boolean                  m_NeedsToCheckFramePress  // 0x130
  private           System.UInt32                   m_UpdateCountLastPressed  // 0x134
  private           System.UInt32                   m_UpdateCountLastReleased  // 0x138
  private           System.Boolean                  m_LastUpdateWasPress  // 0x13C
  private           System.Boolean                  <needsToCheckFramePress>k__BackingField  // 0x13D
  public            System.Single                   pressPoint  // 0x140
  private   static  System.Single                   s_GlobalDefaultButtonPressPoint  // 0x0
  private   static  System.Single                   s_GlobalDefaultButtonReleaseThreshold  // 0x4
  private   static  System.Single                   kMinButtonPressPoint  // 0x0
METHODS:
  System.Boolean get_needsToCheckFramePress()
  System.Void set_needsToCheckFramePress(System.Boolean value)
  System.Single get_pressPointOrDefault()
  System.Void .ctor()
  System.Boolean IsValueConsideredPressed(System.Single value)
  System.Boolean get_isPressed()
  System.Void BeginTestingForFramePresses(System.Boolean currentlyPressed, System.Boolean pressedLastFrame)
  System.Boolean get_wasPressedThisFrame()
  System.Boolean get_wasReleasedThisFrame()
  System.Void UpdateWasPressed()
END_CLASS

CLASS: UnityEngine.InputSystem.Controls.DeltaControl
TYPE:  class
TOKEN: 0x200021A
EXTENDS: Vector2Control
FIELDS:
  private           UnityEngine.InputSystem.Controls.AxisControl<up>k__BackingField  // 0x120
  private           UnityEngine.InputSystem.Controls.AxisControl<down>k__BackingField  // 0x128
  private           UnityEngine.InputSystem.Controls.AxisControl<left>k__BackingField  // 0x130
  private           UnityEngine.InputSystem.Controls.AxisControl<right>k__BackingField  // 0x138
METHODS:
  UnityEngine.InputSystem.Controls.AxisControl get_up()
  System.Void set_up(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_down()
  System.Void set_down(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_left()
  System.Void set_left(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_right()
  System.Void set_right(UnityEngine.InputSystem.Controls.AxisControl value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Controls.DiscreteButtonControl
TYPE:  class
TOKEN: 0x200021B
EXTENDS: ButtonControl
FIELDS:
  public            System.Int32                    minValue  // 0x148
  public            System.Int32                    maxValue  // 0x14C
  public            System.Int32                    wrapAtValue  // 0x150
  public            System.Int32                    nullValue  // 0x154
  public            UnityEngine.InputSystem.Controls.DiscreteButtonControl.WriteModewriteMode  // 0x158
METHODS:
  System.Void FinishSetup()
  System.Single ReadUnprocessedValueFromState(System.Void* statePtr)
  System.Void WriteValueIntoState(System.Single value, System.Void* statePtr)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Controls.DoubleControl
TYPE:  class
TOKEN: 0x200021D
EXTENDS: InputControl`1
FIELDS:
METHODS:
  System.Void .ctor()
  System.Double ReadUnprocessedValueFromState(System.Void* statePtr)
  System.Void WriteValueIntoState(System.Double value, System.Void* statePtr)
END_CLASS

CLASS: UnityEngine.InputSystem.Controls.DpadControl
TYPE:  class
TOKEN: 0x200021E
EXTENDS: Vector2Control
FIELDS:
  private           UnityEngine.InputSystem.Controls.ButtonControl<up>k__BackingField  // 0x120
  private           UnityEngine.InputSystem.Controls.ButtonControl<down>k__BackingField  // 0x128
  private           UnityEngine.InputSystem.Controls.ButtonControl<left>k__BackingField  // 0x130
  private           UnityEngine.InputSystem.Controls.ButtonControl<right>k__BackingField  // 0x138
METHODS:
  UnityEngine.InputSystem.Controls.ButtonControl get_up()
  System.Void set_up(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_down()
  System.Void set_down(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_left()
  System.Void set_left(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_right()
  System.Void set_right(UnityEngine.InputSystem.Controls.ButtonControl value)
  System.Void .ctor()
  System.Void FinishSetup()
  UnityEngine.Vector2 ReadUnprocessedValueFromState(System.Void* statePtr)
  System.Void WriteValueIntoState(UnityEngine.Vector2 value, System.Void* statePtr)
  UnityEngine.Vector2 MakeDpadVector(System.Boolean up, System.Boolean down, System.Boolean left, System.Boolean right, System.Boolean normalize)
  UnityEngine.Vector2 MakeDpadVector(System.Single up, System.Single down, System.Single left, System.Single right)
END_CLASS

CLASS: UnityEngine.InputSystem.Controls.IntegerControl
TYPE:  class
TOKEN: 0x2000221
EXTENDS: InputControl`1
FIELDS:
METHODS:
  System.Void .ctor()
  System.Int32 ReadUnprocessedValueFromState(System.Void* statePtr)
  System.Void WriteValueIntoState(System.Int32 value, System.Void* statePtr)
  UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType()
END_CLASS

CLASS: UnityEngine.InputSystem.Controls.KeyControl
TYPE:  class
TOKEN: 0x2000222
EXTENDS: ButtonControl
FIELDS:
  private           UnityEngine.InputSystem.Key     <keyCode>k__BackingField  // 0x148
  private           System.Int32                    m_ScanCode  // 0x14C
METHODS:
  UnityEngine.InputSystem.Key get_keyCode()
  System.Void set_keyCode(UnityEngine.InputSystem.Key value)
  System.Int32 get_scanCode()
  System.Void RefreshConfiguration()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Controls.QuaternionControl
TYPE:  class
TOKEN: 0x2000223
EXTENDS: InputControl`1
FIELDS:
  private           UnityEngine.InputSystem.Controls.AxisControl<x>k__BackingField  // 0x120
  private           UnityEngine.InputSystem.Controls.AxisControl<y>k__BackingField  // 0x128
  private           UnityEngine.InputSystem.Controls.AxisControl<z>k__BackingField  // 0x130
  private           UnityEngine.InputSystem.Controls.AxisControl<w>k__BackingField  // 0x138
METHODS:
  UnityEngine.InputSystem.Controls.AxisControl get_x()
  System.Void set_x(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_y()
  System.Void set_y(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_z()
  System.Void set_z(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_w()
  System.Void set_w(UnityEngine.InputSystem.Controls.AxisControl value)
  System.Void .ctor()
  System.Void FinishSetup()
  UnityEngine.Quaternion ReadUnprocessedValueFromState(System.Void* statePtr)
  System.Void WriteValueIntoState(UnityEngine.Quaternion value, System.Void* statePtr)
  UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType()
END_CLASS

CLASS: UnityEngine.InputSystem.Controls.StickControl
TYPE:  class
TOKEN: 0x2000224
EXTENDS: Vector2Control
FIELDS:
  private           UnityEngine.InputSystem.Controls.ButtonControl<up>k__BackingField  // 0x120
  private           UnityEngine.InputSystem.Controls.ButtonControl<down>k__BackingField  // 0x128
  private           UnityEngine.InputSystem.Controls.ButtonControl<left>k__BackingField  // 0x130
  private           UnityEngine.InputSystem.Controls.ButtonControl<right>k__BackingField  // 0x138
METHODS:
  UnityEngine.InputSystem.Controls.ButtonControl get_up()
  System.Void set_up(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_down()
  System.Void set_down(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_left()
  System.Void set_left(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_right()
  System.Void set_right(UnityEngine.InputSystem.Controls.ButtonControl value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Controls.TouchControl
TYPE:  class
TOKEN: 0x2000225
EXTENDS: InputControl`1
FIELDS:
  private           UnityEngine.InputSystem.Controls.TouchPressControl<press>k__BackingField  // 0x170
  private           UnityEngine.InputSystem.Controls.IntegerControl<displayIndex>k__BackingField  // 0x178
  private           UnityEngine.InputSystem.Controls.IntegerControl<touchId>k__BackingField  // 0x180
  private           UnityEngine.InputSystem.Controls.Vector2Control<position>k__BackingField  // 0x188
  private           UnityEngine.InputSystem.Controls.DeltaControl<delta>k__BackingField  // 0x190
  private           UnityEngine.InputSystem.Controls.AxisControl<pressure>k__BackingField  // 0x198
  private           UnityEngine.InputSystem.Controls.Vector2Control<radius>k__BackingField  // 0x1A0
  private           UnityEngine.InputSystem.Controls.TouchPhaseControl<phase>k__BackingField  // 0x1A8
  private           UnityEngine.InputSystem.Controls.ButtonControl<indirectTouch>k__BackingField  // 0x1B0
  private           UnityEngine.InputSystem.Controls.ButtonControl<tap>k__BackingField  // 0x1B8
  private           UnityEngine.InputSystem.Controls.IntegerControl<tapCount>k__BackingField  // 0x1C0
  private           UnityEngine.InputSystem.Controls.DoubleControl<startTime>k__BackingField  // 0x1C8
  private           UnityEngine.InputSystem.Controls.Vector2Control<startPosition>k__BackingField  // 0x1D0
METHODS:
  UnityEngine.InputSystem.Controls.TouchPressControl get_press()
  System.Void set_press(UnityEngine.InputSystem.Controls.TouchPressControl value)
  UnityEngine.InputSystem.Controls.IntegerControl get_displayIndex()
  System.Void set_displayIndex(UnityEngine.InputSystem.Controls.IntegerControl value)
  UnityEngine.InputSystem.Controls.IntegerControl get_touchId()
  System.Void set_touchId(UnityEngine.InputSystem.Controls.IntegerControl value)
  UnityEngine.InputSystem.Controls.Vector2Control get_position()
  System.Void set_position(UnityEngine.InputSystem.Controls.Vector2Control value)
  UnityEngine.InputSystem.Controls.DeltaControl get_delta()
  System.Void set_delta(UnityEngine.InputSystem.Controls.DeltaControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_pressure()
  System.Void set_pressure(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.Vector2Control get_radius()
  System.Void set_radius(UnityEngine.InputSystem.Controls.Vector2Control value)
  UnityEngine.InputSystem.Controls.TouchPhaseControl get_phase()
  System.Void set_phase(UnityEngine.InputSystem.Controls.TouchPhaseControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_indirectTouch()
  System.Void set_indirectTouch(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_tap()
  System.Void set_tap(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.IntegerControl get_tapCount()
  System.Void set_tapCount(UnityEngine.InputSystem.Controls.IntegerControl value)
  UnityEngine.InputSystem.Controls.DoubleControl get_startTime()
  System.Void set_startTime(UnityEngine.InputSystem.Controls.DoubleControl value)
  UnityEngine.InputSystem.Controls.Vector2Control get_startPosition()
  System.Void set_startPosition(UnityEngine.InputSystem.Controls.Vector2Control value)
  System.Boolean get_isInProgress()
  System.Void .ctor()
  System.Void FinishSetup()
  UnityEngine.InputSystem.LowLevel.TouchState ReadUnprocessedValueFromState(System.Void* statePtr)
  System.Void WriteValueIntoState(UnityEngine.InputSystem.LowLevel.TouchState value, System.Void* statePtr)
END_CLASS

CLASS: UnityEngine.InputSystem.Controls.TouchPhaseControl
TYPE:  class
TOKEN: 0x2000226
EXTENDS: InputControl`1
FIELDS:
METHODS:
  System.Void .ctor()
  UnityEngine.InputSystem.TouchPhase ReadUnprocessedValueFromState(System.Void* statePtr)
  System.Void WriteValueIntoState(UnityEngine.InputSystem.TouchPhase value, System.Void* statePtr)
END_CLASS

CLASS: UnityEngine.InputSystem.Controls.TouchPressControl
TYPE:  class
TOKEN: 0x2000227
EXTENDS: ButtonControl
FIELDS:
METHODS:
  System.Void FinishSetup()
  System.Single ReadUnprocessedValueFromState(System.Void* statePtr)
  System.Void WriteValueIntoState(System.Single value, System.Void* statePtr)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Controls.Vector2Control
TYPE:  class
TOKEN: 0x2000228
EXTENDS: InputControl`1
FIELDS:
  private           UnityEngine.InputSystem.Controls.AxisControl<x>k__BackingField  // 0x110
  private           UnityEngine.InputSystem.Controls.AxisControl<y>k__BackingField  // 0x118
METHODS:
  UnityEngine.InputSystem.Controls.AxisControl get_x()
  System.Void set_x(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_y()
  System.Void set_y(UnityEngine.InputSystem.Controls.AxisControl value)
  System.Void .ctor()
  System.Void FinishSetup()
  UnityEngine.Vector2 ReadUnprocessedValueFromState(System.Void* statePtr)
  System.Void WriteValueIntoState(UnityEngine.Vector2 value, System.Void* statePtr)
  System.Single EvaluateMagnitude(System.Void* statePtr)
  UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType()
END_CLASS

CLASS: UnityEngine.InputSystem.Controls.Vector3Control
TYPE:  class
TOKEN: 0x2000229
EXTENDS: InputControl`1
FIELDS:
  private           UnityEngine.InputSystem.Controls.AxisControl<x>k__BackingField  // 0x118
  private           UnityEngine.InputSystem.Controls.AxisControl<y>k__BackingField  // 0x120
  private           UnityEngine.InputSystem.Controls.AxisControl<z>k__BackingField  // 0x128
METHODS:
  UnityEngine.InputSystem.Controls.AxisControl get_x()
  System.Void set_x(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_y()
  System.Void set_y(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_z()
  System.Void set_z(UnityEngine.InputSystem.Controls.AxisControl value)
  System.Void .ctor()
  System.Void FinishSetup()
  UnityEngine.Vector3 ReadUnprocessedValueFromState(System.Void* statePtr)
  System.Void WriteValueIntoState(UnityEngine.Vector3 value, System.Void* statePtr)
  System.Single EvaluateMagnitude(System.Void* statePtr)
  UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType()
END_CLASS

CLASS: UnityEngine.InputSystem.DualShock.DualShockGamepad
TYPE:  class
TOKEN: 0x2000159
EXTENDS: Gamepad
FIELDS:
  private           UnityEngine.InputSystem.Controls.ButtonControl<touchpadButton>k__BackingField  // 0x210
  private           UnityEngine.InputSystem.Controls.ButtonControl<optionsButton>k__BackingField  // 0x218
  private           UnityEngine.InputSystem.Controls.ButtonControl<shareButton>k__BackingField  // 0x220
  private           UnityEngine.InputSystem.Controls.ButtonControl<L1>k__BackingField  // 0x228
  private           UnityEngine.InputSystem.Controls.ButtonControl<R1>k__BackingField  // 0x230
  private           UnityEngine.InputSystem.Controls.ButtonControl<L2>k__BackingField  // 0x238
  private           UnityEngine.InputSystem.Controls.ButtonControl<R2>k__BackingField  // 0x240
  private           UnityEngine.InputSystem.Controls.ButtonControl<L3>k__BackingField  // 0x248
  private           UnityEngine.InputSystem.Controls.ButtonControl<R3>k__BackingField  // 0x250
  private   static  UnityEngine.InputSystem.DualShock.DualShockGamepad<current>k__BackingField  // 0x0
  private           UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor<hidDescriptor>k__BackingField  // 0x258
METHODS:
  UnityEngine.InputSystem.Controls.ButtonControl get_touchpadButton()
  System.Void set_touchpadButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_optionsButton()
  System.Void set_optionsButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_shareButton()
  System.Void set_shareButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_L1()
  System.Void set_L1(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_R1()
  System.Void set_R1(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_L2()
  System.Void set_L2(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_R2()
  System.Void set_R2(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_L3()
  System.Void set_L3(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_R3()
  System.Void set_R3(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.DualShock.DualShockGamepad get_current()
  System.Void set_current(UnityEngine.InputSystem.DualShock.DualShockGamepad value)
  UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor get_hidDescriptor()
  System.Void set_hidDescriptor(UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor value)
  System.Void MakeCurrent()
  System.Void OnRemoved()
  System.Void FinishSetup()
  System.Void SetLightBarColor(UnityEngine.Color color)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.DualShock.DualSenseGamepadHID
TYPE:  class
TOKEN: 0x200015A
EXTENDS: DualShockGamepad
FIELDS:
  private           UnityEngine.InputSystem.Controls.ButtonControl<leftTriggerButton>k__BackingField  // 0x288
  private           UnityEngine.InputSystem.Controls.ButtonControl<rightTriggerButton>k__BackingField  // 0x290
  private           UnityEngine.InputSystem.Controls.ButtonControl<playStationButton>k__BackingField  // 0x298
  private           System.Nullable<System.Single>  m_LowFrequencyMotorSpeed  // 0x2A0
  private           System.Nullable<System.Single>  m_HighFrequenceyMotorSpeed  // 0x2A8
  protected         System.Nullable<UnityEngine.Color>m_LightBarColor  // 0x2B0
  private           System.Byte                     outputSequenceId  // 0x2C4
  private   static  System.Byte                     JitterMaskLow  // 0x0
  private   static  System.Byte                     JitterMaskHigh  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.ButtonControl get_leftTriggerButton()
  System.Void set_leftTriggerButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_rightTriggerButton()
  System.Void set_rightTriggerButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_playStationButton()
  System.Void set_playStationButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  System.Void FinishSetup()
  System.Void PauseHaptics()
  System.Void ResetHaptics()
  System.Void ResumeHaptics()
  System.Void SetLightBarColor(UnityEngine.Color color)
  System.Void SetMotorSpeeds(System.Single lowFrequency, System.Single highFrequency)
  System.Boolean SetMotorSpeedsAndLightBarColor(System.Nullable<System.Single> lowFrequency, System.Nullable<System.Single> highFrequency, System.Nullable<UnityEngine.Color> color)
  System.Boolean MergeForward(UnityEngine.InputSystem.DualShock.DualSenseGamepadHID.DualSenseHIDUSBInputReport* currentState, UnityEngine.InputSystem.DualShock.DualSenseGamepadHID.DualSenseHIDUSBInputReport* nextState)
  System.Boolean MergeForward(UnityEngine.InputSystem.DualShock.DualSenseGamepadHID.DualSenseHIDBluetoothInputReport* currentState, UnityEngine.InputSystem.DualShock.DualSenseGamepadHID.DualSenseHIDBluetoothInputReport* nextState)
  System.Boolean MergeForward(UnityEngine.InputSystem.DualShock.DualSenseGamepadHID.DualSenseHIDMinimalInputReport* currentState, UnityEngine.InputSystem.DualShock.DualSenseGamepadHID.DualSenseHIDMinimalInputReport* nextState)
  System.Boolean UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr)
  System.Boolean UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void OnNextUpdate()
  System.Void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Boolean GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.UInt32& offset)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.DualShock.DualShock4GamepadHID
TYPE:  class
TOKEN: 0x200015F
EXTENDS: DualShockGamepad
FIELDS:
  private           UnityEngine.InputSystem.Controls.ButtonControl<leftTriggerButton>k__BackingField  // 0x288
  private           UnityEngine.InputSystem.Controls.ButtonControl<rightTriggerButton>k__BackingField  // 0x290
  private           UnityEngine.InputSystem.Controls.ButtonControl<playStationButton>k__BackingField  // 0x298
  private           System.Nullable<System.Single>  m_LowFrequencyMotorSpeed  // 0x2A0
  private           System.Nullable<System.Single>  m_HighFrequenceyMotorSpeed  // 0x2A8
  private           System.Nullable<UnityEngine.Color>m_LightBarColor  // 0x2B0
  private   static  System.Byte                     JitterMaskLow  // 0x0
  private   static  System.Byte                     JitterMaskHigh  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.ButtonControl get_leftTriggerButton()
  System.Void set_leftTriggerButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_rightTriggerButton()
  System.Void set_rightTriggerButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_playStationButton()
  System.Void set_playStationButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  System.Void FinishSetup()
  System.Void PauseHaptics()
  System.Void ResetHaptics()
  System.Void ResumeHaptics()
  System.Void SetLightBarColor(UnityEngine.Color color)
  System.Void SetMotorSpeeds(System.Single lowFrequency, System.Single highFrequency)
  System.Boolean SetMotorSpeedsAndLightBarColor(System.Single lowFrequency, System.Single highFrequency, UnityEngine.Color color)
  System.Boolean UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void OnNextUpdate()
  System.Void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Boolean GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.UInt32& offset)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.DualShock.DualShock3GamepadHID
TYPE:  class
TOKEN: 0x2000161
EXTENDS: DualShockGamepad
FIELDS:
  private           UnityEngine.InputSystem.Controls.ButtonControl<leftTriggerButton>k__BackingField  // 0x288
  private           UnityEngine.InputSystem.Controls.ButtonControl<rightTriggerButton>k__BackingField  // 0x290
  private           UnityEngine.InputSystem.Controls.ButtonControl<playStationButton>k__BackingField  // 0x298
METHODS:
  UnityEngine.InputSystem.Controls.ButtonControl get_leftTriggerButton()
  System.Void set_leftTriggerButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_rightTriggerButton()
  System.Void set_rightTriggerButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_playStationButton()
  System.Void set_playStationButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.DualShock.DualShockSupport
TYPE:  class
TOKEN: 0x2000162
FIELDS:
METHODS:
  System.Void Initialize()
END_CLASS

CLASS: UnityEngine.InputSystem.DualShock.IDualShockHaptics
TYPE:  interface
TOKEN: 0x2000163
FIELDS:
METHODS:
  System.Void SetLightBarColor(UnityEngine.Color color)
END_CLASS

CLASS: UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDInputReport
TYPE:  struct
TOKEN: 0x2000164
FIELDS:
  public    static  UnityEngine.InputSystem.Utilities.FourCCFormat  // 0x0
  public            System.Byte                     leftStickX  // 0x10
  public            System.Byte                     leftStickY  // 0x11
  public            System.Byte                     rightStickX  // 0x12
  public            System.Byte                     rightStickY  // 0x13
  public            System.Byte                     leftTrigger  // 0x14
  public            System.Byte                     rightTrigger  // 0x15
  public            System.Byte                     buttons0  // 0x16
  public            System.Byte                     buttons1  // 0x17
  public            System.Byte                     buttons2  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_format()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDOutputReportPayload
TYPE:  struct
TOKEN: 0x2000165
FIELDS:
  public            System.Byte                     enableFlags1  // 0x10
  public            System.Byte                     enableFlags2  // 0x11
  public            System.Byte                     highFrequencyMotorSpeed  // 0x12
  public            System.Byte                     lowFrequencyMotorSpeed  // 0x13
  public            System.Byte                     redColor  // 0x3C
  public            System.Byte                     greenColor  // 0x3D
  public            System.Byte                     blueColor  // 0x3E
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDUSBOutputReport
TYPE:  struct
TOKEN: 0x2000166
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            System.Byte                     reportId  // 0x18
  public            UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDOutputReportPayloadpayload  // 0x19
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDUSBOutputReport Create(UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDOutputReportPayload payload, System.Int32 outputReportSize)
END_CLASS

CLASS: UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDBluetoothOutputReport
TYPE:  struct
TOKEN: 0x2000167
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            System.Byte                     reportId  // 0x18
  public            System.Byte                     tag1  // 0x19
  public            System.Byte                     tag2  // 0x1A
  public            UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDOutputReportPayloadpayload  // 0x1B
  public            System.UInt32                   crc32  // 0x62
  public            UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDBluetoothOutputReport.<rawData>e__FixedBufferrawData  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDBluetoothOutputReport Create(UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDOutputReportPayload payload, System.Byte outputSequenceId, System.Int32 outputReportSize)
END_CLASS

CLASS: UnityEngine.InputSystem.DualShock.LowLevel.DualShock4HIDInputReport
TYPE:  struct
TOKEN: 0x2000169
FIELDS:
  public    static  UnityEngine.InputSystem.Utilities.FourCCFormat  // 0x0
  public            System.Byte                     leftStickX  // 0x10
  public            System.Byte                     leftStickY  // 0x11
  public            System.Byte                     rightStickX  // 0x12
  public            System.Byte                     rightStickY  // 0x13
  public            System.Byte                     buttons1  // 0x14
  public            System.Byte                     buttons2  // 0x15
  public            System.Byte                     buttons3  // 0x16
  public            System.Byte                     leftTrigger  // 0x17
  public            System.Byte                     rightTrigger  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_format()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.DualShock.LowLevel.DualShock3HIDInputReport
TYPE:  struct
TOKEN: 0x200016A
FIELDS:
  private           System.UInt16                   padding1  // 0x10
  public            System.Byte                     buttons1  // 0x12
  public            System.Byte                     buttons2  // 0x13
  public            System.Byte                     buttons3  // 0x14
  private           System.Byte                     padding2  // 0x15
  public            System.Byte                     leftStickX  // 0x16
  public            System.Byte                     leftStickY  // 0x17
  public            System.Byte                     rightStickX  // 0x18
  public            System.Byte                     rightStickY  // 0x19
  private           UnityEngine.InputSystem.DualShock.LowLevel.DualShock3HIDInputReport.<padding3>e__FixedBufferpadding3  // 0x1A
  public            System.Byte                     leftTrigger  // 0x22
  public            System.Byte                     rightTrigger  // 0x23
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_format()
END_CLASS

CLASS: UnityEngine.InputSystem.DualShock.LowLevel.DualShockHIDOutputReport
TYPE:  struct
TOKEN: 0x200016C
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  private   static  System.Int32                    kReportId  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            System.Byte                     reportId  // 0x18
  public            System.Byte                     flags  // 0x19
  public            UnityEngine.InputSystem.DualShock.LowLevel.DualShockHIDOutputReport.<unknown1>e__FixedBufferunknown1  // 0x1A
  public            System.Byte                     highFrequencyMotorSpeed  // 0x1C
  public            System.Byte                     lowFrequencyMotorSpeed  // 0x1D
  public            System.Byte                     redColor  // 0x1E
  public            System.Byte                     greenColor  // 0x1F
  public            System.Byte                     blueColor  // 0x20
  public            UnityEngine.InputSystem.DualShock.LowLevel.DualShockHIDOutputReport.<unknown2>e__FixedBufferunknown2  // 0x21
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  System.Void SetMotorSpeeds(System.Single lowFreq, System.Single highFreq)
  System.Void SetColor(UnityEngine.Color color)
  UnityEngine.InputSystem.DualShock.LowLevel.DualShockHIDOutputReport Create(System.Int32 outputReportSize)
END_CLASS

CLASS: UnityEngine.InputSystem.Editor.SampleFrequencyCalculator
TYPE:  struct
TOKEN: 0x2000170
FIELDS:
  private           System.Double                   m_LastUpdateTime  // 0x10
  private           System.Int32                    m_SampleCount  // 0x18
  private           System.Single                   <targetFrequency>k__BackingField  // 0x1C
  private           System.Single                   <frequency>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.Single targetFrequency, System.Double realtimeSinceStartup)
  System.Single get_targetFrequency()
  System.Void set_targetFrequency(System.Single value)
  System.Single get_frequency()
  System.Void set_frequency(System.Single value)
  System.Void ProcessSample(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Boolean Update()
  System.Boolean Update(System.Double realtimeSinceStartup)
END_CLASS

CLASS: UnityEngine.InputSystem.EnhancedTouch.EnhancedTouchSupport
TYPE:  class
TOKEN: 0x200014F
FIELDS:
  private   static  System.Int32                    s_Enabled  // 0x0
  private   static  UnityEngine.InputSystem.InputSettings.UpdateModes_UpdateMode  // 0x4
METHODS:
  System.Boolean get_enabled()
  System.Void Enable()
  System.Void Disable()
  System.Void Reset()
  System.Void SetUpState()
  System.Void TearDownState()
  System.Void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change)
  System.Void OnSettingsChange()
  System.Void CheckEnabled()
END_CLASS

CLASS: UnityEngine.InputSystem.EnhancedTouch.Finger
TYPE:  class
TOKEN: 0x2000150
FIELDS:
  private   readonly UnityEngine.InputSystem.Touchscreen<screen>k__BackingField  // 0x10
  private   readonly System.Int32                    <index>k__BackingField  // 0x18
  private   readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState>m_StateHistory  // 0x20
METHODS:
  UnityEngine.InputSystem.Touchscreen get_screen()
  System.Int32 get_index()
  System.Boolean get_isActive()
  UnityEngine.Vector2 get_screenPosition()
  UnityEngine.InputSystem.EnhancedTouch.Touch get_lastTouch()
  UnityEngine.InputSystem.EnhancedTouch.Touch get_currentTouch()
  UnityEngine.InputSystem.EnhancedTouch.TouchHistory get_touchHistory()
  System.Void .ctor(UnityEngine.InputSystem.Touchscreen screen, System.Int32 index, UnityEngine.InputSystem.LowLevel.InputUpdateType updateMask)
  System.Boolean ShouldRecordTouch(UnityEngine.InputSystem.InputControl control, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void OnTouchRecorded(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record record)
  UnityEngine.InputSystem.EnhancedTouch.Touch FindTouch(System.UInt32 uniqueId)
  UnityEngine.InputSystem.EnhancedTouch.TouchHistory GetTouchHistory(UnityEngine.InputSystem.EnhancedTouch.Touch touch)
END_CLASS

CLASS: UnityEngine.InputSystem.EnhancedTouch.Touch
TYPE:  struct
TOKEN: 0x2000151
FIELDS:
  private   readonly UnityEngine.InputSystem.EnhancedTouch.Fingerm_Finger  // 0x10
  private           UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<UnityEngine.InputSystem.LowLevel.TouchState>m_TouchRecord  // 0x18
  private   static  UnityEngine.InputSystem.EnhancedTouch.Touch.GlobalStates_GlobalState  // 0x0
METHODS:
  System.Boolean get_valid()
  UnityEngine.InputSystem.EnhancedTouch.Finger get_finger()
  UnityEngine.InputSystem.TouchPhase get_phase()
  System.Boolean get_began()
  System.Boolean get_inProgress()
  System.Boolean get_ended()
  System.Int32 get_touchId()
  System.Single get_pressure()
  UnityEngine.Vector2 get_radius()
  System.Double get_startTime()
  System.Double get_time()
  UnityEngine.InputSystem.Touchscreen get_screen()
  UnityEngine.Vector2 get_screenPosition()
  UnityEngine.Vector2 get_startScreenPosition()
  UnityEngine.Vector2 get_delta()
  System.Int32 get_tapCount()
  System.Boolean get_isTap()
  System.Int32 get_displayIndex()
  System.Boolean get_isInProgress()
  System.UInt32 get_updateStepCount()
  System.UInt32 get_uniqueId()
  UnityEngine.InputSystem.LowLevel.TouchState& get_state()
  UnityEngine.InputSystem.EnhancedTouch.Touch.ExtraDataPerTouchState& get_extraData()
  UnityEngine.InputSystem.EnhancedTouch.TouchHistory get_history()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Touch> get_activeTouches()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Finger> get_fingers()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Finger> get_activeFingers()
  System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Touchscreen> get_screens()
  System.Void add_onFingerDown(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value)
  System.Void remove_onFingerDown(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value)
  System.Void add_onFingerUp(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value)
  System.Void remove_onFingerUp(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value)
  System.Void add_onFingerMove(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value)
  System.Void remove_onFingerMove(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value)
  System.Int32 get_maxHistoryLengthPerFinger()
  System.Void .ctor(UnityEngine.InputSystem.EnhancedTouch.Finger finger, UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<UnityEngine.InputSystem.LowLevel.TouchState> touchRecord)
  System.String ToString()
  System.Boolean Equals(UnityEngine.InputSystem.EnhancedTouch.Touch other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void AddTouchscreen(UnityEngine.InputSystem.Touchscreen screen)
  System.Void RemoveTouchscreen(UnityEngine.InputSystem.Touchscreen screen)
  System.Void BeginUpdate()
  UnityEngine.InputSystem.EnhancedTouch.Touch.GlobalState CreateGlobalState()
  UnityEngine.InputSystem.Utilities.ISavedState SaveAndResetState()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.EnhancedTouch.TouchHistory
TYPE:  struct
TOKEN: 0x2000156
FIELDS:
  private   readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState>m_History  // 0x10
  private   readonly UnityEngine.InputSystem.EnhancedTouch.Fingerm_Finger  // 0x18
  private   readonly System.Int32                    m_Count  // 0x20
  private   readonly System.Int32                    m_StartIndex  // 0x24
  private   readonly System.UInt32                   m_Version  // 0x28
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.EnhancedTouch.Finger finger, UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> history, System.Int32 startIndex, System.Int32 count)
  System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.EnhancedTouch.Touch> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Int32 get_Count()
  UnityEngine.InputSystem.EnhancedTouch.Touch get_Item(System.Int32 index)
  System.Void CheckValid()
END_CLASS

CLASS: UnityEngine.InputSystem.EnhancedTouch.TouchSimulation
TYPE:  class
TOKEN: 0x2000158
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.InputSystem.Touchscreen<simulatedTouchscreen>k__BackingField  // 0x18
  private           System.Int32                    m_NumPointers  // 0x20
  private           UnityEngine.InputSystem.Pointer[]m_Pointers  // 0x28
  private           UnityEngine.Vector2[]           m_CurrentPositions  // 0x30
  private           System.Int32[]                  m_CurrentDisplayIndices  // 0x38
  private           UnityEngine.InputSystem.Controls.ButtonControl[]m_Touches  // 0x40
  private           System.Int32[]                  m_TouchIds  // 0x48
  private           System.Int32                    m_LastTouchId  // 0x50
  private           System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange>m_OnDeviceChange  // 0x58
  private           System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice>m_OnEvent  // 0x60
  private   static  UnityEngine.InputSystem.EnhancedTouch.TouchSimulations_Instance  // 0x0
METHODS:
  UnityEngine.InputSystem.Touchscreen get_simulatedTouchscreen()
  System.Void set_simulatedTouchscreen(UnityEngine.InputSystem.Touchscreen value)
  UnityEngine.InputSystem.EnhancedTouch.TouchSimulation get_instance()
  System.Void Enable()
  System.Void Disable()
  System.Void Destroy()
  System.Void AddPointer(UnityEngine.InputSystem.Pointer pointer)
  System.Void RemovePointer(UnityEngine.InputSystem.Pointer pointer)
  System.Void OnEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device)
  System.Void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void UpdateTouch(System.Int32 touchIndex, System.Int32 pointerIndex, UnityEngine.InputSystem.TouchPhase phase, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Int64 monitorIndex)
  System.Void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, System.Double time, System.Int64 monitorIndex, System.Int32 timerIndex)
  System.Void InstallStateChangeMonitors(System.Int32 startIndex)
  System.Void OnSourceControlChangedValue(UnityEngine.InputSystem.InputControl control, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Int64 sourceDeviceAndButtonIndex)
  System.Void UninstallStateChangeMonitors(System.Int32 startIndex)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.HID.HID
TYPE:  class
TOKEN: 0x2000139
EXTENDS: InputDevice
FIELDS:
  private   static  System.String                   kHIDInterface  // 0x0
  private   static  System.String                   kHIDNamespace  // 0x0
  private           System.Boolean                  m_HaveParsedHIDDescriptor  // 0x190
  private           UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorm_HIDDescriptor  // 0x198
  private   static readonly Unity.Profiling.ProfilerMarker  k_HIDParseDescriptorFallback  // 0x0
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_QueryHIDReportDescriptorDeviceCommandType()
  UnityEngine.InputSystem.Utilities.FourCC get_QueryHIDReportDescriptorSizeDeviceCommandType()
  UnityEngine.InputSystem.Utilities.FourCC get_QueryHIDParsedReportDescriptorDeviceCommandType()
  UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor get_hidDescriptor()
  System.String OnFindLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription& description, System.String matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeDeviceCommand)
  UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor ReadHIDDeviceDescriptor(UnityEngine.InputSystem.Layouts.InputDeviceDescription& deviceDescription, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeCommandDelegate)
  System.String UsagePageToString(UnityEngine.InputSystem.HID.HID.UsagePage usagePage)
  System.String UsageToString(UnityEngine.InputSystem.HID.HID.UsagePage usagePage, System.Int32 usage)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.HID.HIDParser
TYPE:  class
TOKEN: 0x2000148
FIELDS:
METHODS:
  System.Boolean ParseReportDescriptor(System.Byte[] buffer, UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor& deviceDescriptor)
  System.Boolean ParseReportDescriptor(System.Byte* bufferPtr, System.Int32 bufferLength, UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor& deviceDescriptor)
  System.Int32 ReadData(System.Int32 itemSize, System.Byte* currentPtr, System.Byte* endPtr)
END_CLASS

CLASS: UnityEngine.InputSystem.HID.HIDSupport
TYPE:  class
TOKEN: 0x200014D
FIELDS:
  private   static  UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage[]s_SupportedHIDUsages  // 0x0
METHODS:
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> get_supportedHIDUsages()
  System.Void set_supportedHIDUsages(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> value)
  System.Void Initialize()
END_CLASS

CLASS: UnityEngine.InputSystem.Haptics.DualMotorRumble
TYPE:  struct
TOKEN: 0x2000171
FIELDS:
  private           System.Single                   <lowFrequencyMotorSpeed>k__BackingField  // 0x10
  private           System.Single                   <highFrequencyMotorSpeed>k__BackingField  // 0x14
METHODS:
  System.Single get_lowFrequencyMotorSpeed()
  System.Void set_lowFrequencyMotorSpeed(System.Single value)
  System.Single get_highFrequencyMotorSpeed()
  System.Void set_highFrequencyMotorSpeed(System.Single value)
  System.Boolean get_isRumbling()
  System.Void PauseHaptics(UnityEngine.InputSystem.InputDevice device)
  System.Void ResumeHaptics(UnityEngine.InputSystem.InputDevice device)
  System.Void ResetHaptics(UnityEngine.InputSystem.InputDevice device)
  System.Void SetMotorSpeeds(UnityEngine.InputSystem.InputDevice device, System.Single lowFrequency, System.Single highFrequency)
END_CLASS

CLASS: UnityEngine.InputSystem.Haptics.IDualMotorRumble
TYPE:  interface
TOKEN: 0x2000172
FIELDS:
METHODS:
  System.Void SetMotorSpeeds(System.Single lowFrequency, System.Single highFrequency)
END_CLASS

CLASS: UnityEngine.InputSystem.Haptics.IHaptics
TYPE:  interface
TOKEN: 0x2000173
FIELDS:
METHODS:
  System.Void PauseHaptics()
  System.Void ResumeHaptics()
  System.Void ResetHaptics()
END_CLASS

CLASS: UnityEngine.InputSystem.Interactions.HoldInteraction
TYPE:  class
TOKEN: 0x200022A
FIELDS:
  public            System.Single                   duration  // 0x10
  public            System.Single                   pressPoint  // 0x14
  private           System.Double                   m_TimePressed  // 0x18
METHODS:
  System.Single get_durationOrDefault()
  System.Single get_pressPointOrDefault()
  System.Void Process(UnityEngine.InputSystem.InputInteractionContext& context)
  System.Void Reset()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Interactions.MultiTapInteraction
TYPE:  class
TOKEN: 0x200022B
FIELDS:
  public            System.Single                   tapTime  // 0x10
  public            System.Single                   tapDelay  // 0x14
  public            System.Int32                    tapCount  // 0x18
  public            System.Single                   pressPoint  // 0x1C
  private           UnityEngine.InputSystem.Interactions.MultiTapInteraction.TapPhasem_CurrentTapPhase  // 0x20
  private           System.Int32                    m_CurrentTapCount  // 0x24
  private           System.Double                   m_CurrentTapStartTime  // 0x28
  private           System.Double                   m_LastTapReleaseTime  // 0x30
METHODS:
  System.Single get_tapTimeOrDefault()
  System.Single get_tapDelayOrDefault()
  System.Single get_pressPointOrDefault()
  System.Single get_releasePointOrDefault()
  System.Void Process(UnityEngine.InputSystem.InputInteractionContext& context)
  System.Void Reset()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Interactions.PressInteraction
TYPE:  class
TOKEN: 0x200022D
FIELDS:
  public            System.Single                   pressPoint  // 0x10
  public            UnityEngine.InputSystem.Interactions.PressBehaviorbehavior  // 0x14
  private           System.Boolean                  m_WaitingForRelease  // 0x18
METHODS:
  System.Single get_pressPointOrDefault()
  System.Single get_releasePointOrDefault()
  System.Void Process(UnityEngine.InputSystem.InputInteractionContext& context)
  System.Void Reset()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Interactions.PressBehavior
TYPE:  struct
TOKEN: 0x200022E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Interactions.PressBehaviorPressOnly  // 0x0
  public    static  UnityEngine.InputSystem.Interactions.PressBehaviorReleaseOnly  // 0x0
  public    static  UnityEngine.InputSystem.Interactions.PressBehaviorPressAndRelease  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.Interactions.SlowTapInteraction
TYPE:  class
TOKEN: 0x200022F
FIELDS:
  public            System.Single                   duration  // 0x10
  public            System.Single                   pressPoint  // 0x14
  private           System.Double                   m_SlowTapStartTime  // 0x18
METHODS:
  System.Single get_durationOrDefault()
  System.Single get_pressPointOrDefault()
  System.Void Process(UnityEngine.InputSystem.InputInteractionContext& context)
  System.Void Reset()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Interactions.TapInteraction
TYPE:  class
TOKEN: 0x2000230
FIELDS:
  public            System.Single                   duration  // 0x10
  public            System.Single                   pressPoint  // 0x14
  private           System.Double                   m_TapStartTime  // 0x18
METHODS:
  System.Single get_durationOrDefault()
  System.Single get_pressPointOrDefault()
  System.Single get_releasePointOrDefault()
  System.Void Process(UnityEngine.InputSystem.InputInteractionContext& context)
  System.Void Reset()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Layouts.InputControlAttribute
TYPE:  class
TOKEN: 0x20001F6
EXTENDS: PropertyAttribute
FIELDS:
  private           System.String                   <layout>k__BackingField  // 0x10
  private           System.String                   <variants>k__BackingField  // 0x18
  private           System.String                   <name>k__BackingField  // 0x20
  private           System.String                   <format>k__BackingField  // 0x28
  private           System.String                   <usage>k__BackingField  // 0x30
  private           System.String[]                 <usages>k__BackingField  // 0x38
  private           System.String                   <parameters>k__BackingField  // 0x40
  private           System.String                   <processors>k__BackingField  // 0x48
  private           System.String                   <alias>k__BackingField  // 0x50
  private           System.String[]                 <aliases>k__BackingField  // 0x58
  private           System.String                   <useStateFrom>k__BackingField  // 0x60
  private           System.UInt32                   <bit>k__BackingField  // 0x68
  private           System.UInt32                   <offset>k__BackingField  // 0x6C
  private           System.UInt32                   <sizeInBits>k__BackingField  // 0x70
  private           System.Int32                    <arraySize>k__BackingField  // 0x74
  private           System.String                   <displayName>k__BackingField  // 0x78
  private           System.String                   <shortDisplayName>k__BackingField  // 0x80
  private           System.Boolean                  <noisy>k__BackingField  // 0x88
  private           System.Boolean                  <synthetic>k__BackingField  // 0x89
  private           System.Boolean                  <dontReset>k__BackingField  // 0x8A
  private           System.Object                   <defaultState>k__BackingField  // 0x90
  private           System.Object                   <minValue>k__BackingField  // 0x98
  private           System.Object                   <maxValue>k__BackingField  // 0xA0
METHODS:
  System.String get_layout()
  System.Void set_layout(System.String value)
  System.String get_variants()
  System.Void set_variants(System.String value)
  System.String get_name()
  System.Void set_name(System.String value)
  System.String get_format()
  System.Void set_format(System.String value)
  System.String get_usage()
  System.Void set_usage(System.String value)
  System.String[] get_usages()
  System.Void set_usages(System.String[] value)
  System.String get_parameters()
  System.Void set_parameters(System.String value)
  System.String get_processors()
  System.Void set_processors(System.String value)
  System.String get_alias()
  System.Void set_alias(System.String value)
  System.String[] get_aliases()
  System.Void set_aliases(System.String[] value)
  System.String get_useStateFrom()
  System.Void set_useStateFrom(System.String value)
  System.UInt32 get_bit()
  System.Void set_bit(System.UInt32 value)
  System.UInt32 get_offset()
  System.Void set_offset(System.UInt32 value)
  System.UInt32 get_sizeInBits()
  System.Void set_sizeInBits(System.UInt32 value)
  System.Int32 get_arraySize()
  System.Void set_arraySize(System.Int32 value)
  System.String get_displayName()
  System.Void set_displayName(System.String value)
  System.String get_shortDisplayName()
  System.Void set_shortDisplayName(System.String value)
  System.Boolean get_noisy()
  System.Void set_noisy(System.Boolean value)
  System.Boolean get_synthetic()
  System.Void set_synthetic(System.Boolean value)
  System.Boolean get_dontReset()
  System.Void set_dontReset(System.Boolean value)
  System.Object get_defaultState()
  System.Void set_defaultState(System.Object value)
  System.Object get_minValue()
  System.Void set_minValue(System.Object value)
  System.Object get_maxValue()
  System.Void set_maxValue(System.Object value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate
TYPE:  class
TOKEN: 0x20001F7
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.String Invoke(UnityEngine.InputSystem.Layouts.InputDeviceDescription& description, System.String matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeDeviceCommand)
  System.IAsyncResult BeginInvoke(UnityEngine.InputSystem.Layouts.InputDeviceDescription& description, System.String matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeDeviceCommand, System.AsyncCallback callback, System.Object object)
  System.String EndInvoke(UnityEngine.InputSystem.Layouts.InputDeviceDescription& description, System.IAsyncResult result)
END_CLASS

CLASS: UnityEngine.InputSystem.Layouts.InputControlLayout
TYPE:  class
TOKEN: 0x20001F8
FIELDS:
  private   static  UnityEngine.InputSystem.Utilities.InternedStrings_DefaultVariant  // 0x0
  public    static  System.String                   VariantSeparator  // 0x0
  private           UnityEngine.InputSystem.Utilities.InternedStringm_Name  // 0x10
  private           System.Type                     m_Type  // 0x20
  private           UnityEngine.InputSystem.Utilities.InternedStringm_Variants  // 0x28
  private           UnityEngine.InputSystem.Utilities.FourCCm_StateFormat  // 0x38
  private           System.Int32                    m_StateSizeInBytes  // 0x3C
  private           System.Nullable<System.Boolean> m_UpdateBeforeRender  // 0x40
  private           UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString>m_BaseLayouts  // 0x48
  private           UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString>m_AppliedOverrides  // 0x68
  private           UnityEngine.InputSystem.Utilities.InternedString[]m_CommonUsages  // 0x88
  private           UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[]m_Controls  // 0x90
  private           System.String                   m_DisplayName  // 0x98
  private           System.String                   m_Description  // 0xA0
  private           UnityEngine.InputSystem.Layouts.InputControlLayout.Flagsm_Flags  // 0xA8
  private   static  UnityEngine.InputSystem.Layouts.InputControlLayout.Collections_Layouts  // 0x10
  private   static  UnityEngine.InputSystem.Layouts.InputControlLayout.Caches_CacheInstance  // 0x50
  private   static  System.Int32                    s_CacheInstanceRef  // 0x58
METHODS:
  UnityEngine.InputSystem.Utilities.InternedString get_DefaultVariant()
  UnityEngine.InputSystem.Utilities.InternedString get_name()
  System.String get_displayName()
  System.Type get_type()
  UnityEngine.InputSystem.Utilities.InternedString get_variants()
  UnityEngine.InputSystem.Utilities.FourCC get_stateFormat()
  System.Int32 get_stateSizeInBytes()
  System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_baseLayouts()
  System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_appliedOverrides()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_commonUsages()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> get_controls()
  System.Boolean get_updateBeforeRender()
  System.Boolean get_isDeviceLayout()
  System.Boolean get_isControlLayout()
  System.Boolean get_isOverride()
  System.Void set_isOverride(System.Boolean value)
  System.Boolean get_isGenericTypeOfDevice()
  System.Void set_isGenericTypeOfDevice(System.Boolean value)
  System.Boolean get_hideInUI()
  System.Void set_hideInUI(System.Boolean value)
  System.Boolean get_isNoisy()
  System.Void set_isNoisy(System.Boolean value)
  System.Nullable<System.Boolean> get_canRunInBackground()
  System.Void set_canRunInBackground(System.Nullable<System.Boolean> value)
  UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem get_Item(System.String path)
  System.Nullable<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> FindControl(UnityEngine.InputSystem.Utilities.InternedString path)
  System.Nullable<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> FindControlIncludingArrayElements(System.String path, System.Int32& arrayIndex)
  System.Type GetValueType()
  UnityEngine.InputSystem.Layouts.InputControlLayout FromType(System.String name, System.Type type)
  System.String ToJson()
  UnityEngine.InputSystem.Layouts.InputControlLayout FromJson(System.String json)
  System.Void .ctor(System.String name, System.Type type)
  System.Void AddControlItems(System.Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, System.String layoutName)
  System.Void AddControlItemsFromFields(System.Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, System.String layoutName)
  System.Void AddControlItemsFromProperties(System.Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, System.String layoutName)
  System.Void AddControlItemsFromMembers(System.Reflection.MemberInfo[] members, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems, System.String layoutName)
  System.Void AddControlItemsFromMember(System.Reflection.MemberInfo member, UnityEngine.InputSystem.Layouts.InputControlAttribute[] attributes, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems)
  UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem CreateControlItemFromMember(System.Reflection.MemberInfo member, UnityEngine.InputSystem.Layouts.InputControlAttribute attribute)
  System.String InferLayoutFromValueType(System.Type type)
  System.Void MergeLayout(UnityEngine.InputSystem.Layouts.InputControlLayout other)
  System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> CreateLookupTableForControls(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[] controlItems, System.Collections.Generic.List<System.String> variants)
  System.Boolean VariantsMatch(UnityEngine.InputSystem.Utilities.InternedString expected, UnityEngine.InputSystem.Utilities.InternedString actual)
  System.Boolean VariantsMatch(System.String expected, System.String actual)
  System.Void ParseHeaderFieldsFromJson(System.String json, UnityEngine.InputSystem.Utilities.InternedString& name, UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString>& baseLayouts, UnityEngine.InputSystem.Layouts.InputDeviceMatcher& deviceMatcher)
  UnityEngine.InputSystem.Layouts.InputControlLayout.Cache& get_cache()
  UnityEngine.InputSystem.Layouts.InputControlLayout.CacheRefInstance CacheRef()
  System.Void .cctor()
  System.Boolean <MergeLayout>b__77_0(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem x)
END_CLASS

CLASS: UnityEngine.InputSystem.Layouts.InputControlLayoutAttribute
TYPE:  class
TOKEN: 0x200020C
EXTENDS: Attribute
FIELDS:
  private           System.Type                     <stateType>k__BackingField  // 0x10
  private           System.String                   <stateFormat>k__BackingField  // 0x18
  private           System.String[]                 <commonUsages>k__BackingField  // 0x20
  private           System.String                   <variants>k__BackingField  // 0x28
  private           System.Boolean                  <isNoisy>k__BackingField  // 0x30
  private           System.Nullable<System.Boolean> canRunInBackgroundInternal  // 0x31
  private           System.Nullable<System.Boolean> updateBeforeRenderInternal  // 0x33
  private           System.Boolean                  <isGenericTypeOfDevice>k__BackingField  // 0x35
  private           System.String                   <displayName>k__BackingField  // 0x38
  private           System.String                   <description>k__BackingField  // 0x40
  private           System.Boolean                  <hideInUI>k__BackingField  // 0x48
METHODS:
  System.Type get_stateType()
  System.Void set_stateType(System.Type value)
  System.String get_stateFormat()
  System.Void set_stateFormat(System.String value)
  System.String[] get_commonUsages()
  System.Void set_commonUsages(System.String[] value)
  System.String get_variants()
  System.Void set_variants(System.String value)
  System.Boolean get_isNoisy()
  System.Void set_isNoisy(System.Boolean value)
  System.Boolean get_canRunInBackground()
  System.Void set_canRunInBackground(System.Boolean value)
  System.Boolean get_updateBeforeRender()
  System.Void set_updateBeforeRender(System.Boolean value)
  System.Boolean get_isGenericTypeOfDevice()
  System.Void set_isGenericTypeOfDevice(System.Boolean value)
  System.String get_displayName()
  System.Void set_displayName(System.String value)
  System.String get_description()
  System.Void set_description(System.String value)
  System.Boolean get_hideInUI()
  System.Void set_hideInUI(System.Boolean value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Layouts.InputDeviceBuilder
TYPE:  struct
TOKEN: 0x200020D
FIELDS:
  private           UnityEngine.InputSystem.InputDevicem_Device  // 0x10
  private           UnityEngine.InputSystem.Layouts.InputControlLayout.CacheRefInstancem_LayoutCacheRef  // 0x18
  private           System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem>m_ChildControlOverrides  // 0x20
  private           System.Collections.Generic.List<System.UInt32>m_StateOffsetToControlMap  // 0x28
  private           System.Text.StringBuilder       m_StringBuilder  // 0x30
  private   static  System.UInt32                   kSizeForControlUsingStateFromOtherControl  // 0x0
  private   static  UnityEngine.InputSystem.Layouts.InputDeviceBuilders_Instance  // 0x0
  private   static  System.Int32                    s_InstanceRef  // 0x28
METHODS:
  System.Void Setup(UnityEngine.InputSystem.Utilities.InternedString layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription)
  UnityEngine.InputSystem.InputDevice Finish()
  System.Void Dispose()
  System.Void Reset()
  UnityEngine.InputSystem.InputControl InstantiateLayout(UnityEngine.InputSystem.Utilities.InternedString layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.Utilities.InternedString name, UnityEngine.InputSystem.InputControl parent)
  UnityEngine.InputSystem.InputControl InstantiateLayout(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.Utilities.InternedString name, UnityEngine.InputSystem.InputControl parent)
  System.Void AddChildControls(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.InputControl parent, System.Boolean& haveChildrenUsingStateFromOtherControls)
  UnityEngine.InputSystem.InputControl AddChildControl(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.InputControl parent, System.Boolean& haveChildrenUsingStateFromOtherControls, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, System.Int32 childIndex, System.String nameOverride)
  System.Void InsertChildControlOverride(UnityEngine.InputSystem.InputControl parent, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem& controlItem)
  System.String ChildControlOverridePath(UnityEngine.InputSystem.InputControl parent, UnityEngine.InputSystem.Utilities.InternedString controlName)
  System.Void AddChildControlIfMissing(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.InputControl parent, System.Boolean& haveChildrenUsingStateFromOtherControls, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem& controlItem)
  UnityEngine.InputSystem.InputControl InsertChildControl(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variant, UnityEngine.InputSystem.InputControl parent, System.Boolean& haveChildrenUsingStateFromOtherControls, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem& controlItem)
  System.Void ApplyUseStateFrom(UnityEngine.InputSystem.InputControl parent, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem& controlItem, UnityEngine.InputSystem.Layouts.InputControlLayout layout)
  System.Void ShiftChildIndicesInHierarchyOneUp(UnityEngine.InputSystem.InputDevice device, System.Int32 startIndex, UnityEngine.InputSystem.InputControl exceptControl)
  System.Void SetDisplayName(UnityEngine.InputSystem.InputControl control, System.String longDisplayNameFromLayout, System.String shortDisplayNameFromLayout, System.Boolean shortName)
  System.Void AddParentDisplayNameRecursive(UnityEngine.InputSystem.InputControl control, System.Text.StringBuilder stringBuilder, System.Boolean shortName)
  System.Void AddProcessors(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem& controlItem, System.String layoutName)
  System.Void SetFormat(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem)
  UnityEngine.InputSystem.Layouts.InputControlLayout FindOrLoadLayout(System.String name)
  System.Void ComputeStateLayout(UnityEngine.InputSystem.InputControl control)
  System.Void FinalizeControlHierarchy()
  System.Void FinalizeControlHierarchyRecursive(UnityEngine.InputSystem.InputControl control, System.Int32 controlIndex, UnityEngine.InputSystem.InputControl[] allControls, System.Boolean noisy, System.Boolean dontReset, System.Int32& controlIndiciesNextFreeIndex)
  System.Void InsertControlBitRangeNode(UnityEngine.InputSystem.InputDevice.ControlBitRangeNode& parent, UnityEngine.InputSystem.InputControl control, System.Int32& controlIndiciesNextFreeIndex, System.UInt16 startOffset)
  System.UInt16 GetBestMidPoint(UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, System.UInt16 startOffset)
  System.Void AddControlToNode(UnityEngine.InputSystem.InputControl control, System.Int32& controlIndiciesNextFreeIndex, System.Int32 nodeIndex)
  System.Void AddChildren(UnityEngine.InputSystem.InputDevice.ControlBitRangeNode& parent, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode left, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode right)
  System.UInt16 GetControlIndex(UnityEngine.InputSystem.InputControl control)
  UnityEngine.InputSystem.Layouts.InputDeviceBuilder& get_instance()
  UnityEngine.InputSystem.Layouts.InputDeviceBuilder.RefInstance Ref()
END_CLASS

CLASS: UnityEngine.InputSystem.Layouts.InputDeviceDescription
TYPE:  struct
TOKEN: 0x200020F
FIELDS:
  private           System.String                   m_InterfaceName  // 0x10
  private           System.String                   m_DeviceClass  // 0x18
  private           System.String                   m_Manufacturer  // 0x20
  private           System.String                   m_Product  // 0x28
  private           System.String                   m_Serial  // 0x30
  private           System.String                   m_Version  // 0x38
  private           System.String                   m_Capabilities  // 0x40
METHODS:
  System.String get_interfaceName()
  System.Void set_interfaceName(System.String value)
  System.String get_deviceClass()
  System.Void set_deviceClass(System.String value)
  System.String get_manufacturer()
  System.Void set_manufacturer(System.String value)
  System.String get_product()
  System.Void set_product(System.String value)
  System.String get_serial()
  System.Void set_serial(System.String value)
  System.String get_version()
  System.Void set_version(System.String value)
  System.String get_capabilities()
  System.Void set_capabilities(System.String value)
  System.Boolean get_empty()
  System.String ToString()
  System.Boolean Equals(UnityEngine.InputSystem.Layouts.InputDeviceDescription other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.InputSystem.Layouts.InputDeviceDescription left, UnityEngine.InputSystem.Layouts.InputDeviceDescription right)
  System.Boolean op_Inequality(UnityEngine.InputSystem.Layouts.InputDeviceDescription left, UnityEngine.InputSystem.Layouts.InputDeviceDescription right)
  System.String ToJson()
  UnityEngine.InputSystem.Layouts.InputDeviceDescription FromJson(System.String json)
  System.Boolean ComparePropertyToDeviceDescriptor(System.String propertyName, UnityEngine.InputSystem.Utilities.JsonParser.JsonString propertyValue, System.String deviceDescriptor)
END_CLASS

CLASS: UnityEngine.InputSystem.Layouts.InputDeviceMatcher
TYPE:  struct
TOKEN: 0x2000211
FIELDS:
  private           System.Collections.Generic.KeyValuePair<UnityEngine.InputSystem.Utilities.InternedString,System.Object>[]m_Patterns  // 0x10
  private   static readonly UnityEngine.InputSystem.Utilities.InternedStringkInterfaceKey  // 0x0
  private   static readonly UnityEngine.InputSystem.Utilities.InternedStringkDeviceClassKey  // 0x10
  private   static readonly UnityEngine.InputSystem.Utilities.InternedStringkManufacturerKey  // 0x20
  private   static readonly UnityEngine.InputSystem.Utilities.InternedStringkManufacturerContainsKey  // 0x30
  private   static readonly UnityEngine.InputSystem.Utilities.InternedStringkProductKey  // 0x40
  private   static readonly UnityEngine.InputSystem.Utilities.InternedStringkVersionKey  // 0x50
METHODS:
  System.Boolean get_empty()
  System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>> get_patterns()
  UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithInterface(System.String pattern, System.Boolean supportRegex)
  UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithDeviceClass(System.String pattern, System.Boolean supportRegex)
  UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithManufacturer(System.String pattern, System.Boolean supportRegex)
  UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithManufacturerContains(System.String noRegExPattern)
  UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithProduct(System.String pattern, System.Boolean supportRegex)
  UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithVersion(System.String pattern, System.Boolean supportRegex)
  UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithCapability(System.String path, TValue value)
  UnityEngine.InputSystem.Layouts.InputDeviceMatcher With(UnityEngine.InputSystem.Utilities.InternedString key, System.Object value, System.Boolean supportRegex)
  System.Single MatchPercentage(UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription)
  System.Boolean MatchSingleProperty(System.Object pattern, System.String value)
  System.Boolean MatchSinglePropertyContains(System.Object pattern, System.String value)
  System.Int32 GetNumPropertiesIn(UnityEngine.InputSystem.Layouts.InputDeviceDescription description)
  UnityEngine.InputSystem.Layouts.InputDeviceMatcher FromDeviceDescription(UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription)
  System.String ToString()
  System.Boolean Equals(UnityEngine.InputSystem.Layouts.InputDeviceMatcher other)
  System.Boolean Equals(System.Object obj)
  System.Boolean op_Equality(UnityEngine.InputSystem.Layouts.InputDeviceMatcher left, UnityEngine.InputSystem.Layouts.InputDeviceMatcher right)
  System.Boolean op_Inequality(UnityEngine.InputSystem.Layouts.InputDeviceMatcher left, UnityEngine.InputSystem.Layouts.InputDeviceMatcher right)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.DisableDeviceCommand
TYPE:  struct
TOKEN: 0x2000174
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.DisableDeviceCommand Create()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.EnableDeviceCommand
TYPE:  struct
TOKEN: 0x2000175
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.EnableDeviceCommand Create()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.EnableIMECompositionCommand
TYPE:  struct
TOKEN: 0x2000176
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  private           System.Byte                     m_ImeEnabled  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  System.Boolean get_imeEnabled()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.EnableIMECompositionCommand Create(System.Boolean enabled)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.IInputDeviceCommandInfo
TYPE:  interface
TOKEN: 0x2000177
FIELDS:
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InitiateUserAccountPairingCommand
TYPE:  struct
TOKEN: 0x2000178
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.InitiateUserAccountPairingCommand Create()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate
TYPE:  class
TOKEN: 0x200017A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Nullable<System.Int64> Invoke(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputDeviceCommand* command)
  System.IAsyncResult BeginInvoke(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputDeviceCommand* command, System.AsyncCallback callback, System.Object object)
  System.Nullable<System.Int64> EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate
TYPE:  class
TOKEN: 0x200017B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Int64 Invoke(UnityEngine.InputSystem.LowLevel.InputDeviceCommand& command)
  System.IAsyncResult BeginInvoke(UnityEngine.InputSystem.LowLevel.InputDeviceCommand& command, System.AsyncCallback callback, System.Object object)
  System.Int64 EndInvoke(UnityEngine.InputSystem.LowLevel.InputDeviceCommand& command, System.IAsyncResult result)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputDeviceCommand
TYPE:  struct
TOKEN: 0x200017C
FIELDS:
  private   static  System.Int32                    kBaseCommandSize  // 0x0
  public    static  System.Int32                    BaseCommandSize  // 0x0
  public    static  System.Int64                    GenericFailure  // 0x0
  public    static  System.Int64                    GenericSuccess  // 0x0
  public            UnityEngine.InputSystem.Utilities.FourCCtype  // 0x10
  public            System.Int32                    sizeInBytes  // 0x14
METHODS:
  System.Int32 get_payloadSizeInBytes()
  System.Void* get_payloadPtr()
  System.Void .ctor(UnityEngine.InputSystem.Utilities.FourCC type, System.Int32 sizeInBytes)
  Unity.Collections.NativeArray<System.Byte> AllocateNative(UnityEngine.InputSystem.Utilities.FourCC type, System.Int32 payloadSize)
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.QueryCanRunInBackground
TYPE:  struct
TOKEN: 0x200017D
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            System.Boolean                  canRunInBackground  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.QueryCanRunInBackground Create()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.QueryDimensionsCommand
TYPE:  struct
TOKEN: 0x200017E
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            UnityEngine.Vector2             outDimensions  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.QueryDimensionsCommand Create()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.QueryEnabledStateCommand
TYPE:  struct
TOKEN: 0x200017F
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            System.Boolean                  isEnabled  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.QueryEnabledStateCommand Create()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.QueryKeyboardLayoutCommand
TYPE:  struct
TOKEN: 0x2000180
FIELDS:
  private   static  System.Int32                    kMaxNameLength  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            UnityEngine.InputSystem.LowLevel.QueryKeyboardLayoutCommand.<nameBuffer>e__FixedBuffernameBuffer  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  System.String ReadLayoutName()
  System.Void WriteLayoutName(System.String name)
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.QueryKeyboardLayoutCommand Create()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.QueryKeyNameCommand
TYPE:  struct
TOKEN: 0x2000182
FIELDS:
  private   static  System.Int32                    kMaxNameLength  // 0x0
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            System.Int32                    scanOrKeyCode  // 0x18
  public            UnityEngine.InputSystem.LowLevel.QueryKeyNameCommand.<nameBuffer>e__FixedBuffernameBuffer  // 0x1C
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  System.String ReadKeyName()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.QueryKeyNameCommand Create(UnityEngine.InputSystem.Key key)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand
TYPE:  struct
TOKEN: 0x2000184
FIELDS:
  private   static  System.Int32                    kMaxNameLength  // 0x0
  private   static  System.Int32                    kMaxIdLength  // 0x0
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            System.UInt64                   handle  // 0x18
  private           UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand.<nameBuffer>e__FixedBuffernameBuffer  // 0x20
  private           UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand.<idBuffer>e__FixedBufferidBuffer  // 0x220
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  System.String get_id()
  System.Void set_id(System.String value)
  System.String get_name()
  System.Void set_name(System.String value)
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand Create()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.QuerySamplingFrequencyCommand
TYPE:  struct
TOKEN: 0x2000188
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            System.Single                   frequency  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.QuerySamplingFrequencyCommand Create()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.QueryUserIdCommand
TYPE:  struct
TOKEN: 0x2000189
FIELDS:
  public    static  System.Int32                    kMaxIdLength  // 0x0
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            UnityEngine.InputSystem.LowLevel.QueryUserIdCommand.<idBuffer>e__FixedBufferidBuffer  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  System.String ReadId()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.QueryUserIdCommand Create()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.RequestResetCommand
TYPE:  struct
TOKEN: 0x200018B
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.RequestResetCommand Create()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.RequestSyncCommand
TYPE:  struct
TOKEN: 0x200018C
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.RequestSyncCommand Create()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.SetIMECursorPositionCommand
TYPE:  struct
TOKEN: 0x200018D
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  private           UnityEngine.Vector2             m_Position  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.Vector2 get_position()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.SetIMECursorPositionCommand Create(UnityEngine.Vector2 cursorPosition)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.SetSamplingFrequencyCommand
TYPE:  struct
TOKEN: 0x200018E
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            System.Single                   frequency  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.SetSamplingFrequencyCommand Create(System.Single frequency)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.WarpMousePositionCommand
TYPE:  struct
TOKEN: 0x200018F
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            UnityEngine.Vector2             warpPositionInPlayerDisplaySpace  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.WarpMousePositionCommand Create(UnityEngine.Vector2 position)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.GamepadState
TYPE:  struct
TOKEN: 0x2000190
FIELDS:
  private   static  System.String                   ButtonSouthShortDisplayName  // 0x0
  private   static  System.String                   ButtonNorthShortDisplayName  // 0x0
  private   static  System.String                   ButtonWestShortDisplayName  // 0x0
  private   static  System.String                   ButtonEastShortDisplayName  // 0x0
  public            System.UInt32                   buttons  // 0x10
  public            UnityEngine.Vector2             leftStick  // 0x14
  public            UnityEngine.Vector2             rightStick  // 0x1C
  public            System.Single                   leftTrigger  // 0x24
  public            System.Single                   rightTrigger  // 0x28
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Format()
  UnityEngine.InputSystem.Utilities.FourCC get_format()
  System.Void .ctor(UnityEngine.InputSystem.LowLevel.GamepadButton[] buttons)
  UnityEngine.InputSystem.LowLevel.GamepadState WithButton(UnityEngine.InputSystem.LowLevel.GamepadButton button, System.Boolean value)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.GamepadButton
TYPE:  struct
TOKEN: 0x2000191
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonDpadUp  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonDpadDown  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonDpadLeft  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonDpadRight  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonNorth  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonEast  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonSouth  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonWest  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonLeftStick  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonRightStick  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonLeftShoulder  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonRightShoulder  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonStart  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonSelect  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonLeftTrigger  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonRightTrigger  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonX  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonY  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonA  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonB  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonCross  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonSquare  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonTriangle  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.GamepadButtonCircle  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.DualMotorRumbleCommand
TYPE:  struct
TOKEN: 0x2000192
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            System.Single                   lowFrequencyMotorSpeed  // 0x18
  public            System.Single                   highFrequencyMotorSpeed  // 0x1C
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.DualMotorRumbleCommand Create(System.Single lowFrequency, System.Single highFrequency)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.ICustomDeviceReset
TYPE:  interface
TOKEN: 0x2000193
FIELDS:
METHODS:
  System.Void Reset()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.IEventMerger
TYPE:  interface
TOKEN: 0x2000194
FIELDS:
METHODS:
  System.Boolean MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.IEventPreProcessor
TYPE:  interface
TOKEN: 0x2000195
FIELDS:
METHODS:
  System.Boolean PreProcessEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.IInputUpdateCallbackReceiver
TYPE:  interface
TOKEN: 0x2000196
FIELDS:
METHODS:
  System.Void OnUpdate()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.ITextInputReceiver
TYPE:  interface
TOKEN: 0x2000197
FIELDS:
METHODS:
  System.Void OnTextInput(System.Char character)
  System.Void OnIMECompositionChanged(UnityEngine.InputSystem.LowLevel.IMECompositionString compositionString)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.JoystickState
TYPE:  struct
TOKEN: 0x2000198
FIELDS:
  public            System.Int32                    buttons  // 0x10
  public            UnityEngine.Vector2             stick  // 0x14
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_kFormat()
  UnityEngine.InputSystem.Utilities.FourCC get_format()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.KeyboardState
TYPE:  struct
TOKEN: 0x200019A
FIELDS:
  private   static  System.Int32                    kSizeInBits  // 0x0
  private   static  System.Int32                    kSizeInBytes  // 0x0
  public            UnityEngine.InputSystem.LowLevel.KeyboardState.<keys>e__FixedBufferkeys  // 0x10
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Format()
  System.Void .ctor(UnityEngine.InputSystem.Key[] pressedKeys)
  System.Void .ctor(System.Boolean IMESelected, UnityEngine.InputSystem.Key[] pressedKeys)
  System.Void Set(UnityEngine.InputSystem.Key key, System.Boolean state)
  System.Boolean Get(UnityEngine.InputSystem.Key key)
  System.Void Press(UnityEngine.InputSystem.Key key)
  System.Void Release(UnityEngine.InputSystem.Key key)
  UnityEngine.InputSystem.Utilities.FourCC get_format()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.MouseState
TYPE:  struct
TOKEN: 0x200019C
FIELDS:
  public            UnityEngine.Vector2             position  // 0x10
  public            UnityEngine.Vector2             delta  // 0x18
  public            UnityEngine.Vector2             scroll  // 0x20
  public            System.UInt16                   buttons  // 0x28
  public            System.UInt16                   displayIndex  // 0x2A
  public            System.UInt16                   clickCount  // 0x2C
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Format()
  UnityEngine.InputSystem.LowLevel.MouseState WithButton(UnityEngine.InputSystem.LowLevel.MouseButton button, System.Boolean state)
  UnityEngine.InputSystem.Utilities.FourCC get_format()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.MouseButton
TYPE:  struct
TOKEN: 0x200019D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.LowLevel.MouseButtonLeft  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.MouseButtonRight  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.MouseButtonMiddle  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.MouseButtonForward  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.MouseButtonBack  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.PenState
TYPE:  struct
TOKEN: 0x200019E
FIELDS:
  public            UnityEngine.Vector2             position  // 0x10
  public            UnityEngine.Vector2             delta  // 0x18
  public            UnityEngine.Vector2             tilt  // 0x20
  public            System.Single                   pressure  // 0x28
  public            System.Single                   twist  // 0x2C
  public            System.UInt16                   buttons  // 0x30
  private           System.UInt16                   displayIndex  // 0x32
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Format()
  UnityEngine.InputSystem.LowLevel.PenState WithButton(UnityEngine.InputSystem.PenButton button, System.Boolean state)
  UnityEngine.InputSystem.Utilities.FourCC get_format()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.PointerState
TYPE:  struct
TOKEN: 0x200019F
FIELDS:
  private           System.UInt32                   pointerId  // 0x10
  public            UnityEngine.Vector2             position  // 0x14
  public            UnityEngine.Vector2             delta  // 0x1C
  public            System.Single                   pressure  // 0x24
  public            UnityEngine.Vector2             radius  // 0x28
  public            System.UInt16                   buttons  // 0x30
  public            System.UInt16                   displayIndex  // 0x32
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_kFormat()
  UnityEngine.InputSystem.Utilities.FourCC get_format()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.AccelerometerState
TYPE:  struct
TOKEN: 0x20001A0
FIELDS:
  public            UnityEngine.Vector3             acceleration  // 0x10
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_kFormat()
  UnityEngine.InputSystem.Utilities.FourCC get_format()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.GyroscopeState
TYPE:  struct
TOKEN: 0x20001A1
FIELDS:
  public            UnityEngine.Vector3             angularVelocity  // 0x10
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_kFormat()
  UnityEngine.InputSystem.Utilities.FourCC get_format()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.GravityState
TYPE:  struct
TOKEN: 0x20001A2
FIELDS:
  public            UnityEngine.Vector3             gravity  // 0x10
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_kFormat()
  UnityEngine.InputSystem.Utilities.FourCC get_format()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.AttitudeState
TYPE:  struct
TOKEN: 0x20001A3
FIELDS:
  public            UnityEngine.Quaternion          attitude  // 0x10
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_kFormat()
  UnityEngine.InputSystem.Utilities.FourCC get_format()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.LinearAccelerationState
TYPE:  struct
TOKEN: 0x20001A4
FIELDS:
  public            UnityEngine.Vector3             acceleration  // 0x10
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_kFormat()
  UnityEngine.InputSystem.Utilities.FourCC get_format()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.TouchFlags
TYPE:  struct
TOKEN: 0x20001A5
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  UnityEngine.InputSystem.LowLevel.TouchFlagsIndirectTouch  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.TouchFlagsPrimaryTouch  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.TouchFlagsTapPress  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.TouchFlagsTapRelease  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.TouchFlagsOrphanedPrimaryTouch  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.TouchFlagsBeganInSameFrame  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.TouchState
TYPE:  struct
TOKEN: 0x20001A6
FIELDS:
  private   static  System.Int32                    kSizeInBytes  // 0x0
  public            System.Int32                    touchId  // 0x10
  public            UnityEngine.Vector2             position  // 0x14
  public            UnityEngine.Vector2             delta  // 0x1C
  public            System.Single                   pressure  // 0x24
  public            UnityEngine.Vector2             radius  // 0x28
  public            System.Byte                     phaseId  // 0x30
  public            System.Byte                     tapCount  // 0x31
  public            System.Byte                     displayIndex  // 0x32
  public            System.Byte                     flags  // 0x33
  private           System.UInt32                   updateStepCount  // 0x34
  public            System.Double                   startTime  // 0x38
  public            UnityEngine.Vector2             startPosition  // 0x40
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Format()
  UnityEngine.InputSystem.TouchPhase get_phase()
  System.Void set_phase(UnityEngine.InputSystem.TouchPhase value)
  System.Boolean get_isNoneEndedOrCanceled()
  System.Boolean get_isInProgress()
  System.Boolean get_isPrimaryTouch()
  System.Void set_isPrimaryTouch(System.Boolean value)
  System.Boolean get_isOrphanedPrimaryTouch()
  System.Void set_isOrphanedPrimaryTouch(System.Boolean value)
  System.Boolean get_isIndirectTouch()
  System.Void set_isIndirectTouch(System.Boolean value)
  System.Boolean get_isTap()
  System.Void set_isTap(System.Boolean value)
  System.Boolean get_isTapPress()
  System.Void set_isTapPress(System.Boolean value)
  System.Boolean get_isTapRelease()
  System.Void set_isTapRelease(System.Boolean value)
  System.Boolean get_beganInSameFrame()
  System.Void set_beganInSameFrame(System.Boolean value)
  UnityEngine.InputSystem.Utilities.FourCC get_format()
  System.String ToString()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.TouchscreenState
TYPE:  struct
TOKEN: 0x20001A7
FIELDS:
  public    static  System.Int32                    MaxTouches  // 0x0
  public            UnityEngine.InputSystem.LowLevel.TouchscreenState.<primaryTouchData>e__FixedBufferprimaryTouchData  // 0x10
  private   static  System.Int32                    kTouchDataOffset  // 0x0
  public            UnityEngine.InputSystem.LowLevel.TouchscreenState.<touchData>e__FixedBuffertouchData  // 0x48
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Format()
  UnityEngine.InputSystem.LowLevel.TouchState* get_primaryTouch()
  UnityEngine.InputSystem.LowLevel.TouchState* get_touches()
  UnityEngine.InputSystem.Utilities.FourCC get_format()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.ActionEvent
TYPE:  struct
TOKEN: 0x20001AA
FIELDS:
  public            UnityEngine.InputSystem.LowLevel.InputEventbaseEvent  // 0x10
  private           System.UInt16                   m_ControlIndex  // 0x24
  private           System.UInt16                   m_BindingIndex  // 0x26
  private           System.UInt16                   m_InteractionIndex  // 0x28
  private           System.Byte                     m_StateIndex  // 0x2A
  private           System.Byte                     m_Phase  // 0x2B
  private           System.Double                   m_StartTime  // 0x2C
  public            UnityEngine.InputSystem.LowLevel.ActionEvent.<m_ValueData>e__FixedBufferm_ValueData  // 0x34
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  System.Double get_startTime()
  System.Void set_startTime(System.Double value)
  UnityEngine.InputSystem.InputActionPhase get_phase()
  System.Void set_phase(UnityEngine.InputSystem.InputActionPhase value)
  System.Byte* get_valueData()
  System.Int32 get_valueSizeInBytes()
  System.Int32 get_stateIndex()
  System.Void set_stateIndex(System.Int32 value)
  System.Int32 get_controlIndex()
  System.Void set_controlIndex(System.Int32 value)
  System.Int32 get_bindingIndex()
  System.Void set_bindingIndex(System.Int32 value)
  System.Int32 get_interactionIndex()
  System.Void set_interactionIndex(System.Int32 value)
  UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  System.Int32 GetEventSizeWithValueSize(System.Int32 valueSizeInBytes)
  UnityEngine.InputSystem.LowLevel.ActionEvent* From(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.DeltaStateEvent
TYPE:  struct
TOKEN: 0x20001AC
FIELDS:
  public    static  System.Int32                    Type  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputEventbaseEvent  // 0x10
  public            UnityEngine.InputSystem.Utilities.FourCCstateFormat  // 0x24
  public            System.UInt32                   stateOffset  // 0x28
  private           UnityEngine.InputSystem.LowLevel.DeltaStateEvent.<stateData>e__FixedBufferstateData  // 0x2C
METHODS:
  System.UInt32 get_deltaStateSizeInBytes()
  System.Void* get_deltaState()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr()
  UnityEngine.InputSystem.LowLevel.DeltaStateEvent* From(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr)
  UnityEngine.InputSystem.LowLevel.DeltaStateEvent* FromUnchecked(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr)
  Unity.Collections.NativeArray<System.Byte> From(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr& eventPtr, Unity.Collections.Allocator allocator)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.DeviceConfigurationEvent
TYPE:  struct
TOKEN: 0x20001AE
FIELDS:
  public    static  System.Int32                    Type  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputEventbaseEvent  // 0x10
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr()
  UnityEngine.InputSystem.LowLevel.DeviceConfigurationEvent Create(System.Int32 deviceId, System.Double time)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.DeviceRemoveEvent
TYPE:  struct
TOKEN: 0x20001AF
FIELDS:
  public    static  System.Int32                    Type  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputEventbaseEvent  // 0x10
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr()
  UnityEngine.InputSystem.LowLevel.DeviceRemoveEvent Create(System.Int32 deviceId, System.Double time)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.DeviceResetEvent
TYPE:  struct
TOKEN: 0x20001B0
FIELDS:
  public    static  System.Int32                    Type  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputEventbaseEvent  // 0x10
  public            System.Boolean                  hardReset  // 0x18
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.DeviceResetEvent Create(System.Int32 deviceId, System.Boolean hardReset, System.Double time)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
TYPE:  interface
TOKEN: 0x20001B1
FIELDS:
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.IMECompositionEvent
TYPE:  struct
TOKEN: 0x20001B2
FIELDS:
  private   static  System.Int32                    kIMECharBufferSize  // 0x0
  public    static  System.Int32                    Type  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputEventbaseEvent  // 0x10
  public            UnityEngine.InputSystem.LowLevel.IMECompositionStringcompositionString  // 0x24
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.IMECompositionEvent Create(System.Int32 deviceId, System.String compositionString, System.Double time)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.IMECompositionString
TYPE:  struct
TOKEN: 0x20001B3
FIELDS:
  private           System.Int32                    size  // 0x10
  private           UnityEngine.InputSystem.LowLevel.IMECompositionString.<buffer>e__FixedBufferbuffer  // 0x14
METHODS:
  System.Int32 get_Count()
  System.Char get_Item(System.Int32 index)
  System.Void .ctor(System.String characters)
  System.String ToString()
  System.Collections.Generic.IEnumerator<System.Char> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputEvent
TYPE:  struct
TOKEN: 0x20001B6
FIELDS:
  private   static  System.UInt32                   kHandledMask  // 0x0
  private   static  System.UInt32                   kIdMask  // 0x0
  private   static  System.Int32                    kBaseEventSize  // 0x0
  public    static  System.Int32                    InvalidEventId  // 0x0
  private   static  System.Int32                    kAlignment  // 0x0
  private           UnityEngineInternal.Input.NativeInputEventm_Event  // 0x10
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_type()
  System.Void set_type(UnityEngine.InputSystem.Utilities.FourCC value)
  System.UInt32 get_sizeInBytes()
  System.Void set_sizeInBytes(System.UInt32 value)
  System.Int32 get_eventId()
  System.Void set_eventId(System.Int32 value)
  System.Int32 get_deviceId()
  System.Void set_deviceId(System.Int32 value)
  System.Double get_time()
  System.Void set_time(System.Double value)
  System.Double get_internalTime()
  System.Void set_internalTime(System.Double value)
  System.Void .ctor(UnityEngine.InputSystem.Utilities.FourCC type, System.Int32 sizeInBytes, System.Int32 deviceId, System.Double time)
  System.Boolean get_handled()
  System.Void set_handled(System.Boolean value)
  System.String ToString()
  UnityEngine.InputSystem.LowLevel.InputEvent* GetNextInMemory(UnityEngine.InputSystem.LowLevel.InputEvent* currentPtr)
  UnityEngine.InputSystem.LowLevel.InputEvent* GetNextInMemoryChecked(UnityEngine.InputSystem.LowLevel.InputEvent* currentPtr, UnityEngine.InputSystem.LowLevel.InputEventBuffer& buffer)
  System.Boolean Equals(UnityEngine.InputSystem.LowLevel.InputEvent* first, UnityEngine.InputSystem.LowLevel.InputEvent* second)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputEventBuffer
TYPE:  struct
TOKEN: 0x20001B7
FIELDS:
  public    static  System.Int64                    BufferSizeUnknown  // 0x0
  private           Unity.Collections.NativeArray<System.Byte>m_Buffer  // 0x10
  private           System.Int64                    m_SizeInBytes  // 0x20
  private           System.Int32                    m_EventCount  // 0x28
  private           System.Boolean                  m_WeOwnTheBuffer  // 0x2C
METHODS:
  System.Int32 get_eventCount()
  System.Int64 get_sizeInBytes()
  System.Int64 get_capacityInBytes()
  Unity.Collections.NativeArray<System.Byte> get_data()
  UnityEngine.InputSystem.LowLevel.InputEventPtr get_bufferPtr()
  System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr, System.Int32 eventCount, System.Int32 sizeInBytes, System.Int32 capacityInBytes)
  System.Void .ctor(Unity.Collections.NativeArray<System.Byte> buffer, System.Int32 eventCount, System.Int32 sizeInBytes, System.Boolean transferNativeArrayOwnership)
  System.Void AppendEvent(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr, System.Int32 capacityIncrementInBytes, Unity.Collections.Allocator allocator)
  UnityEngine.InputSystem.LowLevel.InputEvent* AllocateEvent(System.Int32 sizeInBytes, System.Int32 capacityIncrementInBytes, Unity.Collections.Allocator allocator)
  System.Boolean Contains(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr)
  System.Void Reset()
  System.Void AdvanceToNextEvent(UnityEngine.InputSystem.LowLevel.InputEvent*& currentReadPos, UnityEngine.InputSystem.LowLevel.InputEvent*& currentWritePos, System.Int32& numEventsRetainedInBuffer, System.Int32& numRemainingEvents, System.Boolean leaveEventInBuffer)
  System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void Dispose()
  UnityEngine.InputSystem.LowLevel.InputEventBuffer Clone()
  System.Object System.ICloneable.Clone()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputEventListener
TYPE:  struct
TOKEN: 0x20001B9
FIELDS:
  private   static  UnityEngine.InputSystem.LowLevel.InputEventListener.ObserverStates_ObserverState  // 0x0
METHODS:
  UnityEngine.InputSystem.LowLevel.InputEventListener op_Addition(UnityEngine.InputSystem.LowLevel.InputEventListener _, System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> callback)
  UnityEngine.InputSystem.LowLevel.InputEventListener op_Subtraction(UnityEngine.InputSystem.LowLevel.InputEventListener _, System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> callback)
  System.IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputEventPtr
TYPE:  struct
TOKEN: 0x20001BC
FIELDS:
  private   readonly UnityEngine.InputSystem.LowLevel.InputEvent*m_EventPtr  // 0x10
METHODS:
  System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr)
  System.Boolean get_valid()
  System.Boolean get_handled()
  System.Void set_handled(System.Boolean value)
  System.Int32 get_id()
  System.Void set_id(System.Int32 value)
  UnityEngine.InputSystem.Utilities.FourCC get_type()
  System.UInt32 get_sizeInBytes()
  System.Int32 get_deviceId()
  System.Void set_deviceId(System.Int32 value)
  System.Double get_time()
  System.Void set_time(System.Double value)
  System.Double get_internalTime()
  System.Void set_internalTime(System.Double value)
  UnityEngine.InputSystem.LowLevel.InputEvent* get_data()
  UnityEngine.InputSystem.Utilities.FourCC get_stateFormat()
  System.UInt32 get_stateSizeInBytes()
  System.UInt32 get_stateOffset()
  System.Boolean IsA()
  UnityEngine.InputSystem.LowLevel.InputEventPtr Next()
  System.String ToString()
  UnityEngine.InputSystem.LowLevel.InputEvent* ToPointer()
  System.Boolean Equals(UnityEngine.InputSystem.LowLevel.InputEventPtr other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.InputSystem.LowLevel.InputEventPtr left, UnityEngine.InputSystem.LowLevel.InputEventPtr right)
  System.Boolean op_Inequality(UnityEngine.InputSystem.LowLevel.InputEventPtr left, UnityEngine.InputSystem.LowLevel.InputEventPtr right)
  UnityEngine.InputSystem.LowLevel.InputEventPtr op_Implicit(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr)
  UnityEngine.InputSystem.LowLevel.InputEventPtr From(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr)
  UnityEngine.InputSystem.LowLevel.InputEvent* op_Implicit(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  UnityEngine.InputSystem.LowLevel.InputEvent* FromInputEventPtr(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputEventStream
TYPE:  struct
TOKEN: 0x20001BD
FIELDS:
  private           UnityEngine.InputSystem.LowLevel.InputEventBufferm_NativeBuffer  // 0x10
  private           UnityEngine.InputSystem.LowLevel.InputEvent*m_CurrentNativeEventReadPtr  // 0x30
  private           UnityEngine.InputSystem.LowLevel.InputEvent*m_CurrentNativeEventWritePtr  // 0x38
  private           System.Int32                    m_RemainingNativeEventCount  // 0x40
  private   readonly System.Int32                    m_MaxAppendedEvents  // 0x44
  private           UnityEngine.InputSystem.LowLevel.InputEventBufferm_AppendBuffer  // 0x48
  private           UnityEngine.InputSystem.LowLevel.InputEvent*m_CurrentAppendEventReadPtr  // 0x68
  private           UnityEngine.InputSystem.LowLevel.InputEvent*m_CurrentAppendEventWritePtr  // 0x70
  private           System.Int32                    m_RemainingAppendEventCount  // 0x78
  private           System.Int32                    m_NumEventsRetainedInBuffer  // 0x7C
  private           System.Boolean                  m_IsOpen  // 0x80
METHODS:
  System.Boolean get_isOpen()
  System.Int32 get_remainingEventCount()
  System.Int32 get_numEventsRetainedInBuffer()
  UnityEngine.InputSystem.LowLevel.InputEvent* get_currentEventPtr()
  System.UInt32 get_numBytesRetainedInBuffer()
  System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputEventBuffer& eventBuffer, System.Int32 maxAppendedEvents)
  System.Void Close(UnityEngine.InputSystem.LowLevel.InputEventBuffer& eventBuffer)
  System.Void CleanUpAfterException()
  System.Void Write(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr)
  UnityEngine.InputSystem.LowLevel.InputEvent* Advance(System.Boolean leaveEventInBuffer)
  UnityEngine.InputSystem.LowLevel.InputEvent* Peek()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputEventTrace
TYPE:  class
TOKEN: 0x20001BE
FIELDS:
  private   static  System.Int32                    kDefaultBufferSize  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputEvenTraceMarker  // 0x0
  private           System.Int32                    m_ChangeCounter  // 0x10
  private           System.Boolean                  m_Enabled  // 0x14
  private           System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,System.Boolean>m_OnFilterEvent  // 0x18
  private           System.Int32                    m_DeviceId  // 0x20
  private           UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr>>m_EventListeners  // 0x28
  private           System.Int64                    m_EventBufferSize  // 0x78
  private           System.Int64                    m_MaxEventBufferSize  // 0x80
  private           System.Int64                    m_GrowIncrementSize  // 0x88
  private           System.Int64                    m_EventCount  // 0x90
  private           System.Int64                    m_EventSizeInBytes  // 0x98
  private           System.UInt64                   m_EventBufferStorage  // 0xA0
  private           System.UInt64                   m_EventBufferHeadStorage  // 0xA8
  private           System.UInt64                   m_EventBufferTailStorage  // 0xB0
  private           System.Boolean                  m_HasWrapped  // 0xB8
  private           System.Boolean                  m_RecordFrameMarkers  // 0xB9
  private           UnityEngine.InputSystem.LowLevel.InputEventTrace.DeviceInfo[]m_DeviceInfos  // 0xC0
  private   static  System.Int32                    kFileVersion  // 0x8
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_FrameMarkerEvent()
  System.Int32 get_deviceId()
  System.Void set_deviceId(System.Int32 value)
  System.Boolean get_enabled()
  System.Boolean get_recordFrameMarkers()
  System.Void set_recordFrameMarkers(System.Boolean value)
  System.Int64 get_eventCount()
  System.Int64 get_totalEventSizeInBytes()
  System.Int64 get_allocatedSizeInBytes()
  System.Int64 get_maxSizeInBytes()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.LowLevel.InputEventTrace.DeviceInfo> get_deviceInfos()
  System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,System.Boolean> get_onFilterEvent()
  System.Void set_onFilterEvent(System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,System.Boolean> value)
  System.Void add_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> value)
  System.Void remove_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> value)
  System.Void .ctor(UnityEngine.InputSystem.InputDevice device, System.Int64 bufferSizeInBytes, System.Boolean growBuffer, System.Int64 maxBufferSizeInBytes, System.Int64 growIncrementSizeInBytes)
  System.Void .ctor(System.Int64 bufferSizeInBytes, System.Boolean growBuffer, System.Int64 maxBufferSizeInBytes, System.Int64 growIncrementSizeInBytes)
  System.Void WriteTo(System.String filePath)
  System.Void WriteTo(System.IO.Stream stream)
  System.Void ReadFrom(System.String filePath)
  System.Void ReadFrom(System.IO.Stream stream)
  UnityEngine.InputSystem.LowLevel.InputEventTrace LoadFrom(System.String filePath)
  UnityEngine.InputSystem.LowLevel.InputEventTrace LoadFrom(System.IO.Stream stream)
  UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController Replay()
  System.Boolean Resize(System.Int64 newBufferSize, System.Int64 newMaxBufferSize)
  System.Void Clear()
  System.Void Enable()
  System.Void Disable()
  System.Boolean GetNextEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr& current)
  System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void Dispose()
  System.Byte* get_m_EventBuffer()
  System.Void set_m_EventBuffer(System.Byte* value)
  System.Byte* get_m_EventBufferHead()
  System.Void set_m_EventBufferHead(System.Byte* value)
  System.Byte* get_m_EventBufferTail()
  System.Void set_m_EventBufferTail(System.Byte* value)
  System.Void Allocate()
  System.Void Release()
  System.Void OnBeforeUpdate()
  System.Void OnInputEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent, UnityEngine.InputSystem.InputDevice device)
  UnityEngine.InputSystem.Utilities.FourCC get_kFileFormat()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.StateEvent
TYPE:  struct
TOKEN: 0x20001C5
FIELDS:
  public    static  System.Int32                    Type  // 0x0
  private   static  System.Int32                    kStateDataSizeToSubtract  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputEventbaseEvent  // 0x10
  public            UnityEngine.InputSystem.Utilities.FourCCstateFormat  // 0x24
  private           UnityEngine.InputSystem.LowLevel.StateEvent.<stateData>e__FixedBufferstateData  // 0x28
METHODS:
  System.UInt32 get_stateSizeInBytes()
  System.Void* get_state()
  UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  TState GetState()
  TState GetState(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr)
  System.Int32 GetEventSizeWithPayload()
  UnityEngine.InputSystem.LowLevel.StateEvent* From(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr)
  UnityEngine.InputSystem.LowLevel.StateEvent* FromUnchecked(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr)
  Unity.Collections.NativeArray<System.Byte> From(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEventPtr& eventPtr, Unity.Collections.Allocator allocator)
  Unity.Collections.NativeArray<System.Byte> FromDefaultStateFor(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEventPtr& eventPtr, Unity.Collections.Allocator allocator)
  Unity.Collections.NativeArray<System.Byte> From(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEventPtr& eventPtr, Unity.Collections.Allocator allocator, System.Boolean useDefaultState)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.TextEvent
TYPE:  struct
TOKEN: 0x20001C7
FIELDS:
  public    static  System.Int32                    Type  // 0x0
  public            UnityEngine.InputSystem.LowLevel.InputEventbaseEvent  // 0x10
  public            System.Int32                    character  // 0x24
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.LowLevel.TextEvent* From(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  UnityEngine.InputSystem.LowLevel.TextEvent Create(System.Int32 deviceId, System.Char character, System.Double time)
  UnityEngine.InputSystem.LowLevel.TextEvent Create(System.Int32 deviceId, System.Int32 character, System.Double time)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputUpdateDelegate
TYPE:  class
TOKEN: 0x20001C8
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, UnityEngine.InputSystem.LowLevel.InputEventBuffer& eventBuffer)
  System.IAsyncResult BeginInvoke(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, UnityEngine.InputSystem.LowLevel.InputEventBuffer& eventBuffer, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(UnityEngine.InputSystem.LowLevel.InputEventBuffer& eventBuffer, System.IAsyncResult result)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.IInputRuntime
TYPE:  interface
TOKEN: 0x20001C9
FIELDS:
METHODS:
  System.Int32 AllocateDeviceId()
  System.Void Update(UnityEngine.InputSystem.LowLevel.InputUpdateType type)
  System.Void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEvent* ptr)
  System.Int64 DeviceCommand(System.Int32 deviceId, UnityEngine.InputSystem.LowLevel.InputDeviceCommand* commandPtr)
  UnityEngine.InputSystem.LowLevel.InputUpdateDelegate get_onUpdate()
  System.Void set_onUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateDelegate value)
  System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> get_onBeforeUpdate()
  System.Void set_onBeforeUpdate(System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value)
  System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> get_onShouldRunUpdate()
  System.Void set_onShouldRunUpdate(System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> value)
  System.Action<System.Int32,System.String> get_onDeviceDiscovered()
  System.Void set_onDeviceDiscovered(System.Action<System.Int32,System.String> value)
  System.Action<System.Boolean> get_onPlayerFocusChanged()
  System.Void set_onPlayerFocusChanged(System.Action<System.Boolean> value)
  System.Boolean get_isPlayerFocused()
  System.Action get_onShutdown()
  System.Void set_onShutdown(System.Action value)
  System.Single get_pollingFrequency()
  System.Void set_pollingFrequency(System.Single value)
  System.Double get_currentTime()
  System.Double get_currentTimeForFixedUpdate()
  System.Single get_unscaledGameTime()
  System.Double get_currentTimeOffsetToRealtimeSinceStartup()
  System.Boolean get_runInBackground()
  System.Void set_runInBackground(System.Boolean value)
  UnityEngine.Vector2 get_screenSize()
  UnityEngine.ScreenOrientation get_screenOrientation()
  System.Boolean get_isInBatchMode()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputRuntime
TYPE:  class
TOKEN: 0x20001CA
FIELDS:
  public    static  UnityEngine.InputSystem.LowLevel.IInputRuntimes_Instance  // 0x0
  public    static  System.Double                   s_CurrentTimeOffsetToRealtimeSinceStartup  // 0x8
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputRuntimeExtensions
TYPE:  class
TOKEN: 0x20001CB
FIELDS:
METHODS:
  System.Int64 DeviceCommand(UnityEngine.InputSystem.LowLevel.IInputRuntime runtime, System.Int32 deviceId, TCommand& command)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputMetrics
TYPE:  struct
TOKEN: 0x20001CC
FIELDS:
  private           System.Int32                    <maxNumDevices>k__BackingField  // 0x10
  private           System.Int32                    <currentNumDevices>k__BackingField  // 0x14
  private           System.Int32                    <maxStateSizeInBytes>k__BackingField  // 0x18
  private           System.Int32                    <currentStateSizeInBytes>k__BackingField  // 0x1C
  private           System.Int32                    <currentControlCount>k__BackingField  // 0x20
  private           System.Int32                    <currentLayoutCount>k__BackingField  // 0x24
  private           System.Int32                    <totalEventBytes>k__BackingField  // 0x28
  private           System.Int32                    <totalEventCount>k__BackingField  // 0x2C
  private           System.Int32                    <totalUpdateCount>k__BackingField  // 0x30
  private           System.Double                   <totalEventProcessingTime>k__BackingField  // 0x38
  private           System.Double                   <totalEventLagTime>k__BackingField  // 0x40
METHODS:
  System.Int32 get_maxNumDevices()
  System.Void set_maxNumDevices(System.Int32 value)
  System.Int32 get_currentNumDevices()
  System.Void set_currentNumDevices(System.Int32 value)
  System.Int32 get_maxStateSizeInBytes()
  System.Void set_maxStateSizeInBytes(System.Int32 value)
  System.Int32 get_currentStateSizeInBytes()
  System.Void set_currentStateSizeInBytes(System.Int32 value)
  System.Int32 get_currentControlCount()
  System.Void set_currentControlCount(System.Int32 value)
  System.Int32 get_currentLayoutCount()
  System.Void set_currentLayoutCount(System.Int32 value)
  System.Int32 get_totalEventBytes()
  System.Void set_totalEventBytes(System.Int32 value)
  System.Int32 get_totalEventCount()
  System.Void set_totalEventCount(System.Int32 value)
  System.Int32 get_totalUpdateCount()
  System.Void set_totalUpdateCount(System.Int32 value)
  System.Double get_totalEventProcessingTime()
  System.Void set_totalEventProcessingTime(System.Double value)
  System.Double get_totalEventLagTime()
  System.Void set_totalEventLagTime(System.Double value)
  System.Single get_averageEventBytesPerFrame()
  System.Double get_averageProcessingTimePerEvent()
  System.Double get_averageLagTimePerEvent()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputUpdateType
TYPE:  struct
TOKEN: 0x20001CD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.LowLevel.InputUpdateTypeNone  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.InputUpdateTypeDynamic  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.InputUpdateTypeFixed  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.InputUpdateTypeBeforeRender  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.InputUpdateTypeEditor  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.InputUpdateTypeManual  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.InputUpdateTypeDefault  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputUpdate
TYPE:  class
TOKEN: 0x20001CE
FIELDS:
  public    static  System.UInt32                   s_UpdateStepCount  // 0x0
  public    static  UnityEngine.InputSystem.LowLevel.InputUpdateTypes_LatestUpdateType  // 0x4
  public    static  UnityEngine.InputSystem.LowLevel.InputUpdate.UpdateStepCounts_PlayerUpdateStepCount  // 0x8
METHODS:
  System.Void OnBeforeUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType type)
  System.Void OnUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType type)
  UnityEngine.InputSystem.LowLevel.InputUpdate.SerializedState Save()
  System.Void Restore(UnityEngine.InputSystem.LowLevel.InputUpdate.SerializedState state)
  UnityEngine.InputSystem.LowLevel.InputUpdateType GetUpdateTypeForPlayer(UnityEngine.InputSystem.LowLevel.InputUpdateType mask)
  System.Boolean IsPlayerUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.NativeInputRuntime
TYPE:  class
TOKEN: 0x20001D1
FIELDS:
  public    static readonly UnityEngine.InputSystem.LowLevel.NativeInputRuntimeinstance  // 0x0
  private           System.Boolean                  m_RunInBackground  // 0x10
  private           System.Action                   m_ShutdownMethod  // 0x18
  private           UnityEngine.InputSystem.LowLevel.InputUpdateDelegatem_OnUpdate  // 0x20
  private           System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType>m_OnBeforeUpdate  // 0x28
  private           System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean>m_OnShouldRunUpdate  // 0x30
  private           System.Single                   m_PollingFrequency  // 0x38
  private           System.Boolean                  m_DidCallOnShutdown  // 0x3C
  private           System.Action<System.Boolean>   m_FocusChangedMethod  // 0x40
METHODS:
  System.Int32 AllocateDeviceId()
  System.Void Update(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
  System.Void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEvent* ptr)
  System.Int64 DeviceCommand(System.Int32 deviceId, UnityEngine.InputSystem.LowLevel.InputDeviceCommand* commandPtr)
  UnityEngine.InputSystem.LowLevel.InputUpdateDelegate get_onUpdate()
  System.Void set_onUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateDelegate value)
  System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> get_onBeforeUpdate()
  System.Void set_onBeforeUpdate(System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value)
  System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> get_onShouldRunUpdate()
  System.Void set_onShouldRunUpdate(System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> value)
  System.Action<System.Int32,System.String> get_onDeviceDiscovered()
  System.Void set_onDeviceDiscovered(System.Action<System.Int32,System.String> value)
  System.Action get_onShutdown()
  System.Void set_onShutdown(System.Action value)
  System.Action<System.Boolean> get_onPlayerFocusChanged()
  System.Void set_onPlayerFocusChanged(System.Action<System.Boolean> value)
  System.Boolean get_isPlayerFocused()
  System.Single get_pollingFrequency()
  System.Void set_pollingFrequency(System.Single value)
  System.Double get_currentTime()
  System.Double get_currentTimeForFixedUpdate()
  System.Double get_currentTimeOffsetToRealtimeSinceStartup()
  System.Single get_unscaledGameTime()
  System.Boolean get_runInBackground()
  System.Void set_runInBackground(System.Boolean value)
  System.Void OnShutdown()
  System.Boolean OnWantsToShutdown()
  System.Void OnFocusChanged(System.Boolean focus)
  UnityEngine.Vector2 get_screenSize()
  UnityEngine.ScreenOrientation get_screenOrientation()
  System.Boolean get_isInBatchMode()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver
TYPE:  interface
TOKEN: 0x20001D5
FIELDS:
METHODS:
  System.Void OnNextUpdate()
  System.Void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Boolean GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.UInt32& offset)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor
TYPE:  interface
TOKEN: 0x20001D6
FIELDS:
METHODS:
  System.Void NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Int64 monitorIndex)
  System.Void NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, System.Double time, System.Int64 monitorIndex, System.Int32 timerIndex)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.IInputStateTypeInfo
TYPE:  interface
TOKEN: 0x20001D7
FIELDS:
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_format()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputState
TYPE:  class
TOKEN: 0x20001D8
FIELDS:
METHODS:
  UnityEngine.InputSystem.LowLevel.InputUpdateType get_currentUpdateType()
  System.UInt32 get_updateCount()
  System.Double get_currentTime()
  System.Void add_onChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value)
  System.Void remove_onChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value)
  System.Void Change(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
  System.Void Change(UnityEngine.InputSystem.InputControl control, TState state, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void Change(UnityEngine.InputSystem.InputControl control, TState& state, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Boolean IsIntegerFormat(UnityEngine.InputSystem.Utilities.FourCC format)
  System.Void AddChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Int64 monitorIndex, System.UInt32 groupIndex)
  UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor AddChangeMonitor(UnityEngine.InputSystem.InputControl control, System.Action<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Int64> valueChangeCallback, System.Int32 monitorIndex, System.Action<UnityEngine.InputSystem.InputControl,System.Double,System.Int64,System.Int32> timerExpiredCallback)
  System.Void RemoveChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Int64 monitorIndex)
  System.Void AddChangeMonitorTimeout(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Double time, System.Int64 monitorIndex, System.Int32 timerIndex)
  System.Void RemoveChangeMonitorTimeout(UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Int64 monitorIndex, System.Int32 timerIndex)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputStateBlock
TYPE:  struct
TOKEN: 0x20001DA
FIELDS:
  public    static  System.UInt32                   InvalidOffset  // 0x0
  public    static  System.UInt32                   AutomaticOffset  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatInvalid  // 0x0
  private   static  System.Int32                    kFormatInvalid  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatBit  // 0x4
  private   static  System.Int32                    kFormatBit  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatSBit  // 0x8
  private   static  System.Int32                    kFormatSBit  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatInt  // 0xC
  private   static  System.Int32                    kFormatInt  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatUInt  // 0x10
  private   static  System.Int32                    kFormatUInt  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatShort  // 0x14
  private   static  System.Int32                    kFormatShort  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatUShort  // 0x18
  private   static  System.Int32                    kFormatUShort  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatByte  // 0x1C
  private   static  System.Int32                    kFormatByte  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatSByte  // 0x20
  private   static  System.Int32                    kFormatSByte  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatLong  // 0x24
  private   static  System.Int32                    kFormatLong  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatULong  // 0x28
  private   static  System.Int32                    kFormatULong  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatFloat  // 0x2C
  private   static  System.Int32                    kFormatFloat  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatDouble  // 0x30
  private   static  System.Int32                    kFormatDouble  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatVector2  // 0x34
  private   static  System.Int32                    kFormatVector2  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatVector3  // 0x38
  private   static  System.Int32                    kFormatVector3  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatQuaternion  // 0x3C
  private   static  System.Int32                    kFormatQuaternion  // 0x0
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatVector2Short  // 0x40
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatVector3Short  // 0x44
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatVector2Byte  // 0x48
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatVector3Byte  // 0x4C
  public    static readonly UnityEngine.InputSystem.Utilities.FourCCFormatPose  // 0x50
  private   static  System.Int32                    kFormatPose  // 0x0
  private           UnityEngine.InputSystem.Utilities.FourCC<format>k__BackingField  // 0x10
  private           System.UInt32                   m_ByteOffset  // 0x14
  private           System.UInt32                   <bitOffset>k__BackingField  // 0x18
  private           System.UInt32                   <sizeInBits>k__BackingField  // 0x1C
METHODS:
  System.Int32 GetSizeOfPrimitiveFormatInBits(UnityEngine.InputSystem.Utilities.FourCC type)
  UnityEngine.InputSystem.Utilities.FourCC GetPrimitiveFormatFromType(System.Type type)
  UnityEngine.InputSystem.Utilities.FourCC get_format()
  System.Void set_format(UnityEngine.InputSystem.Utilities.FourCC value)
  System.UInt32 get_byteOffset()
  System.Void set_byteOffset(System.UInt32 value)
  System.UInt32 get_bitOffset()
  System.Void set_bitOffset(System.UInt32 value)
  System.UInt32 get_sizeInBits()
  System.Void set_sizeInBits(System.UInt32 value)
  System.UInt32 get_alignedSizeInBytes()
  System.UInt32 get_effectiveByteOffset()
  System.UInt32 get_effectiveBitOffset()
  System.Int32 ReadInt(System.Void* statePtr)
  System.Void WriteInt(System.Void* statePtr, System.Int32 value)
  System.Single ReadFloat(System.Void* statePtr)
  System.Void WriteFloat(System.Void* statePtr, System.Single value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue FloatToPrimitiveValue(System.Single value)
  System.Double ReadDouble(System.Void* statePtr)
  System.Void WriteDouble(System.Void* statePtr, System.Double value)
  System.Void Write(System.Void* statePtr, UnityEngine.InputSystem.Utilities.PrimitiveValue value)
  System.Void CopyToFrom(System.Void* toStatePtr, System.Void* fromStatePtr)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputStateBuffers
TYPE:  struct
TOKEN: 0x20001DB
FIELDS:
  public            System.UInt32                   sizePerBuffer  // 0x10
  public            System.UInt32                   totalSize  // 0x14
  public            System.Void*                    defaultStateBuffer  // 0x18
  public            System.Void*                    noiseMaskBuffer  // 0x20
  public            System.Void*                    resetMaskBuffer  // 0x28
  private           System.Void*                    m_AllBuffers  // 0x30
  private           UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffersm_PlayerStateBuffers  // 0x38
  private   static  System.Void*                    s_DefaultStateBuffer  // 0x0
  private   static  System.Void*                    s_NoiseMaskBuffer  // 0x8
  private   static  System.Void*                    s_ResetMaskBuffer  // 0x10
  private   static  UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBufferss_CurrentBuffers  // 0x18
METHODS:
  UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers GetDoubleBuffersFor(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
  System.Void* GetFrontBufferForDevice(System.Int32 deviceIndex)
  System.Void* GetBackBufferForDevice(System.Int32 deviceIndex)
  System.Void SwitchTo(UnityEngine.InputSystem.LowLevel.InputStateBuffers buffers, UnityEngine.InputSystem.LowLevel.InputUpdateType update)
  System.Void AllocateAll(UnityEngine.InputSystem.InputDevice[] devices, System.Int32 deviceCount)
  UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers SetUpDeviceToBufferMappings(System.Int32 deviceCount, System.Byte*& bufferPtr, System.UInt32 sizePerBuffer, System.UInt32 mappingTableSizePerBuffer)
  System.Void FreeAll()
  System.Void MigrateAll(UnityEngine.InputSystem.InputDevice[] devices, System.Int32 deviceCount, UnityEngine.InputSystem.LowLevel.InputStateBuffers oldBuffers)
  System.Void MigrateDoubleBuffer(UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers newBuffer, UnityEngine.InputSystem.InputDevice[] devices, System.Int32 deviceCount, UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers oldBuffer)
  System.Void MigrateSingleBuffer(System.Void* newBuffer, UnityEngine.InputSystem.InputDevice[] devices, System.Int32 deviceCount, System.Void* oldBuffer)
  System.UInt32 ComputeSizeOfSingleStateBuffer(UnityEngine.InputSystem.InputDevice[] devices, System.Int32 deviceCount)
  System.UInt32 NextDeviceOffset(System.UInt32 currentOffset, UnityEngine.InputSystem.InputDevice device)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputStateHistory
TYPE:  class
TOKEN: 0x20001DD
FIELDS:
  private   static  System.Int32                    kDefaultHistorySize  // 0x0
  private           System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record><onRecordAdded>k__BackingField  // 0x10
  private           System.Func<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean><onShouldRecordStateChange>k__BackingField  // 0x18
  private           UnityEngine.InputSystem.InputControl[]m_Controls  // 0x20
  private           System.Int32                    m_ControlCount  // 0x28
  private           Unity.Collections.NativeArray<System.Byte>m_RecordBuffer  // 0x30
  private           System.Int32                    m_StateSizeInBytes  // 0x40
  private           System.Int32                    m_RecordCount  // 0x44
  private           System.Int32                    m_HistoryDepth  // 0x48
  private           System.Int32                    m_ExtraMemoryPerRecord  // 0x4C
  private           System.Int32                    m_HeadIndex  // 0x50
  private           System.UInt32                   m_CurrentVersion  // 0x54
  private           System.Nullable<UnityEngine.InputSystem.LowLevel.InputUpdateType>m_UpdateMask  // 0x58
  private   readonly System.Boolean                  m_AddNewControls  // 0x60
METHODS:
  System.Int32 get_Count()
  System.UInt32 get_version()
  System.Int32 get_historyDepth()
  System.Void set_historyDepth(System.Int32 value)
  System.Int32 get_extraMemoryPerRecord()
  System.Void set_extraMemoryPerRecord(System.Int32 value)
  UnityEngine.InputSystem.LowLevel.InputUpdateType get_updateMask()
  System.Void set_updateMask(UnityEngine.InputSystem.LowLevel.InputUpdateType value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_controls()
  UnityEngine.InputSystem.LowLevel.InputStateHistory.Record get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, UnityEngine.InputSystem.LowLevel.InputStateHistory.Record value)
  System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> get_onRecordAdded()
  System.Void set_onRecordAdded(System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> value)
  System.Func<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> get_onShouldRecordStateChange()
  System.Void set_onShouldRecordStateChange(System.Func<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value)
  System.Void .ctor(System.Int32 maxStateSizeInBytes)
  System.Void .ctor(System.String path)
  System.Void .ctor(UnityEngine.InputSystem.InputControl control)
  System.Void .ctor(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl> controls)
  System.Void Finalize()
  System.Void Clear()
  UnityEngine.InputSystem.LowLevel.InputStateHistory.Record AddRecord(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record record)
  System.Void StartRecording()
  System.Void StopRecording()
  UnityEngine.InputSystem.LowLevel.InputStateHistory.Record RecordStateChange(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  UnityEngine.InputSystem.LowLevel.InputStateHistory.Record RecordStateChange(UnityEngine.InputSystem.InputControl control, System.Void* statePtr, System.Double time)
  System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void Dispose()
  System.Void Destroy()
  System.Void Allocate()
  System.Int32 RecordIndexToUserIndex(System.Int32 index)
  System.Int32 UserIndexToRecordIndex(System.Int32 index)
  UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* GetRecord(System.Int32 index)
  UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* GetRecordUnchecked(System.Int32 index)
  UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* AllocateRecord(System.Int32& index)
  TValue ReadValue(UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* data)
  System.Object ReadValueAsObject(UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* data)
  System.Void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Int64 monitorIndex)
  System.Void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, System.Double time, System.Int64 monitorIndex, System.Int32 timerIndex)
  System.Int32 get_bytesPerRecord()
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.InputStateHistory`1
TYPE:  class
TOKEN: 0x20001E3
EXTENDS: InputStateHistory
FIELDS:
METHODS:
  System.Void .ctor(System.Nullable<System.Int32> maxStateSizeInBytes)
  System.Void .ctor(UnityEngine.InputSystem.InputControl<TValue> control)
  System.Void .ctor(System.String path)
  System.Void Finalize()
  UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> AddRecord(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> record)
  UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> RecordStateChange(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, System.Double time)
  System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> value)
END_CLASS

CLASS: UnityEngine.InputSystem.LowLevel.SelectObservable`2
TYPE:  class
TOKEN: 0x20001E6
FIELDS:
  private   readonly System.IObservable<TSource>     m_Source  // 0x0
  private   readonly System.Func<TSource,TResult>    m_Filter  // 0x0
METHODS:
  System.Void .ctor(System.IObservable<TSource> source, System.Func<TSource,TResult> filter)
  System.IDisposable Subscribe(System.IObserver<TResult> observer)
END_CLASS

CLASS: UnityEngine.InputSystem.OnScreen.OnScreenButton
TYPE:  class
TOKEN: 0x2000133
EXTENDS: OnScreenControl
FIELDS:
  private           System.String                   m_ControlPath  // 0x30
METHODS:
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.String get_controlPathInternal()
  System.Void set_controlPathInternal(System.String value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.OnScreen.OnScreenControl
TYPE:  class
TOKEN: 0x2000134
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.InputSystem.InputControlm_Control  // 0x18
  private           UnityEngine.InputSystem.OnScreen.OnScreenControlm_NextControlOnDevice  // 0x20
  private           UnityEngine.InputSystem.LowLevel.InputEventPtrm_InputEventPtr  // 0x28
  private   static  System.Int32                    s_nbActiveInstances  // 0x0
  private   static  UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo>s_OnScreenDevices  // 0x8
METHODS:
  System.String get_controlPath()
  System.Void set_controlPath(System.String value)
  UnityEngine.InputSystem.InputControl get_control()
  System.String get_controlPathInternal()
  System.Void set_controlPathInternal(System.String value)
  System.Void SetupInputControl()
  System.Void SendValueToControl(TValue value)
  System.Void SentDefaultValueToControl()
  System.Boolean get_HasAnyActive()
  System.Void OnEnable()
  System.Void OnDisable()
  System.String GetWarningMessage()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.OnScreen.UGUIOnScreenControlUtils
TYPE:  class
TOKEN: 0x2000136
FIELDS:
METHODS:
  UnityEngine.RectTransform GetCanvasRectTransform(UnityEngine.Transform transform)
END_CLASS

CLASS: UnityEngine.InputSystem.OnScreen.OnScreenStick
TYPE:  class
TOKEN: 0x2000137
EXTENDS: OnScreenControl
FIELDS:
  private   static  System.String                   kDynamicOriginClickable  // 0x0
  private           System.Single                   m_MovementRange  // 0x30
  private           System.Single                   m_DynamicOriginRange  // 0x34
  private           System.String                   m_ControlPath  // 0x38
  private           UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviourm_Behaviour  // 0x40
  private           System.Boolean                  m_UseIsolatedInputActions  // 0x44
  private           UnityEngine.InputSystem.InputActionm_PointerDownAction  // 0x48
  private           UnityEngine.InputSystem.InputActionm_PointerMoveAction  // 0x50
  private           UnityEngine.Vector3             m_StartPos  // 0x58
  private           UnityEngine.Vector2             m_PointerDownPos  // 0x64
  private           System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>m_RaycastResults  // 0x70
  private           UnityEngine.EventSystems.PointerEventDatam_PointerEventData  // 0x78
  private           UnityEngine.InputSystem.Controls.TouchControlm_TouchControl  // 0x80
  private           System.Boolean                  m_IsIsolationActive  // 0x88
METHODS:
  System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void Start()
  System.Void OnDestroy()
  System.Void BeginInteraction(UnityEngine.Vector2 pointerPosition, UnityEngine.Camera uiCamera)
  System.Void MoveStick(UnityEngine.Vector2 pointerPosition, UnityEngine.Camera uiCamera)
  System.Void EndInteraction()
  System.Void OnPointerDown(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
  System.Void OnPointerChanged(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
  System.Void OnPointerMove(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
  System.Void OnPointerUp(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
  UnityEngine.Camera GetCameraFromCanvas()
  System.Void OnDrawGizmosSelected()
  System.Void DrawGizmoCircle(UnityEngine.Vector2 center, System.Single radius)
  System.Void UpdateDynamicOriginClickableArea()
  System.Single get_movementRange()
  System.Void set_movementRange(System.Single value)
  System.Single get_dynamicOriginRange()
  System.Void set_dynamicOriginRange(System.Single value)
  System.Boolean get_useIsolatedInputActions()
  System.Void set_useIsolatedInputActions(System.Boolean value)
  System.String get_controlPathInternal()
  System.Void set_controlPathInternal(System.String value)
  UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviour get_behaviour()
  System.Void set_behaviour(UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviour value)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Processors.AxisDeadzoneProcessor
TYPE:  class
TOKEN: 0x20001E8
EXTENDS: InputProcessor`1
FIELDS:
  public            System.Single                   min  // 0x10
  public            System.Single                   max  // 0x14
METHODS:
  System.Single get_minOrDefault()
  System.Single get_maxOrDefault()
  System.Single Process(System.Single value, UnityEngine.InputSystem.InputControl control)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Processors.ClampProcessor
TYPE:  class
TOKEN: 0x20001E9
EXTENDS: InputProcessor`1
FIELDS:
  public            System.Single                   min  // 0x10
  public            System.Single                   max  // 0x14
METHODS:
  System.Single Process(System.Single value, UnityEngine.InputSystem.InputControl control)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Processors.CompensateDirectionProcessor
TYPE:  class
TOKEN: 0x20001EA
EXTENDS: InputProcessor`1
FIELDS:
METHODS:
  UnityEngine.Vector3 Process(UnityEngine.Vector3 value, UnityEngine.InputSystem.InputControl control)
  System.String ToString()
  UnityEngine.InputSystem.InputProcessor.CachingPolicy get_cachingPolicy()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Processors.CompensateRotationProcessor
TYPE:  class
TOKEN: 0x20001EB
EXTENDS: InputProcessor`1
FIELDS:
METHODS:
  UnityEngine.Quaternion Process(UnityEngine.Quaternion value, UnityEngine.InputSystem.InputControl control)
  System.String ToString()
  UnityEngine.InputSystem.InputProcessor.CachingPolicy get_cachingPolicy()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Processors.InvertProcessor
TYPE:  class
TOKEN: 0x20001EC
EXTENDS: InputProcessor`1
FIELDS:
METHODS:
  System.Single Process(System.Single value, UnityEngine.InputSystem.InputControl control)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Processors.InvertVector2Processor
TYPE:  class
TOKEN: 0x20001ED
EXTENDS: InputProcessor`1
FIELDS:
  public            System.Boolean                  invertX  // 0x10
  public            System.Boolean                  invertY  // 0x11
METHODS:
  UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Processors.InvertVector3Processor
TYPE:  class
TOKEN: 0x20001EE
EXTENDS: InputProcessor`1
FIELDS:
  public            System.Boolean                  invertX  // 0x10
  public            System.Boolean                  invertY  // 0x11
  public            System.Boolean                  invertZ  // 0x12
METHODS:
  UnityEngine.Vector3 Process(UnityEngine.Vector3 value, UnityEngine.InputSystem.InputControl control)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Processors.NormalizeProcessor
TYPE:  class
TOKEN: 0x20001EF
EXTENDS: InputProcessor`1
FIELDS:
  public            System.Single                   min  // 0x10
  public            System.Single                   max  // 0x14
  public            System.Single                   zero  // 0x18
METHODS:
  System.Single Process(System.Single value, UnityEngine.InputSystem.InputControl control)
  System.Single Normalize(System.Single value, System.Single min, System.Single max, System.Single zero)
  System.Single Denormalize(System.Single value, System.Single min, System.Single max, System.Single zero)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Processors.NormalizeVector2Processor
TYPE:  class
TOKEN: 0x20001F0
EXTENDS: InputProcessor`1
FIELDS:
METHODS:
  UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Processors.NormalizeVector3Processor
TYPE:  class
TOKEN: 0x20001F1
EXTENDS: InputProcessor`1
FIELDS:
METHODS:
  UnityEngine.Vector3 Process(UnityEngine.Vector3 value, UnityEngine.InputSystem.InputControl control)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Processors.ScaleProcessor
TYPE:  class
TOKEN: 0x20001F2
EXTENDS: InputProcessor`1
FIELDS:
  public            System.Single                   factor  // 0x10
METHODS:
  System.Single Process(System.Single value, UnityEngine.InputSystem.InputControl control)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Processors.ScaleVector2Processor
TYPE:  class
TOKEN: 0x20001F3
EXTENDS: InputProcessor`1
FIELDS:
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
METHODS:
  UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Processors.ScaleVector3Processor
TYPE:  class
TOKEN: 0x20001F4
EXTENDS: InputProcessor`1
FIELDS:
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
  public            System.Single                   z  // 0x18
METHODS:
  UnityEngine.Vector3 Process(UnityEngine.Vector3 value, UnityEngine.InputSystem.InputControl control)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Processors.StickDeadzoneProcessor
TYPE:  class
TOKEN: 0x20001F5
EXTENDS: InputProcessor`1
FIELDS:
  public            System.Single                   min  // 0x10
  public            System.Single                   max  // 0x14
METHODS:
  System.Single get_minOrDefault()
  System.Single get_maxOrDefault()
  UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control)
  System.Single GetDeadZoneAdjustedValue(System.Single value)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Switch.SwitchProControllerHID
TYPE:  class
TOKEN: 0x2000126
EXTENDS: Gamepad
FIELDS:
  private           UnityEngine.InputSystem.Controls.ButtonControl<captureButton>k__BackingField  // 0x210
  private           UnityEngine.InputSystem.Controls.ButtonControl<homeButton>k__BackingField  // 0x218
  private   static readonly UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport.CommandIdType[]s_HandshakeSequence  // 0x0
  private           System.Int32                    m_HandshakeStepIndex  // 0x220
  private           System.Double                   m_HandshakeTimer  // 0x228
  private   static  System.Byte                     JitterMaskLow  // 0x0
  private   static  System.Byte                     JitterMaskHigh  // 0x0
METHODS:
  UnityEngine.InputSystem.Controls.ButtonControl get_captureButton()
  System.Void set_captureButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_homeButton()
  System.Void set_homeButton(UnityEngine.InputSystem.Controls.ButtonControl value)
  System.Void OnAdded()
  System.Void HandshakeRestart()
  System.Void HandshakeTick()
  System.Void OnNextUpdate()
  System.Void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Boolean GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.UInt32& offset)
  System.Boolean PreProcessEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Switch.SwitchSupportHID
TYPE:  class
TOKEN: 0x2000130
FIELDS:
METHODS:
  System.Void Initialize()
END_CLASS

CLASS: UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState
TYPE:  struct
TOKEN: 0x2000131
FIELDS:
  public    static  UnityEngine.InputSystem.Utilities.FourCCFormat  // 0x0
  public            System.Byte                     leftStickX  // 0x10
  public            System.Byte                     leftStickY  // 0x11
  public            System.Byte                     rightStickX  // 0x12
  public            System.Byte                     rightStickY  // 0x13
  public            System.UInt16                   buttons1  // 0x14
  public            System.Byte                     buttons2  // 0x16
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_format()
  UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState WithButton(UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button button, System.Boolean value)
  System.Void Set(UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button button, System.Boolean state)
  System.Void Press(UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button button)
  System.Void Release(UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button button)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.UI.BaseInputOverride
TYPE:  class
TOKEN: 0x2000112
EXTENDS: BaseInput
FIELDS:
  private   readonly System.String                   <compositionString>k__BackingField  // 0x18
METHODS:
  System.String get_compositionString()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.UI.ExtendedAxisEventData
TYPE:  class
TOKEN: 0x2000113
EXTENDS: AxisEventData
FIELDS:
  private           UnityEngine.InputSystem.InputDevice<device>k__BackingField  // 0x30
METHODS:
  UnityEngine.InputSystem.InputDevice get_device()
  System.Void set_device(UnityEngine.InputSystem.InputDevice value)
  System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem)
  System.String ToString()
END_CLASS

CLASS: UnityEngine.InputSystem.UI.ExtendedPointerEventData
TYPE:  class
TOKEN: 0x2000114
EXTENDS: PointerEventData
FIELDS:
  private           UnityEngine.InputSystem.InputControl<control>k__BackingField  // 0x160
  private           UnityEngine.InputSystem.InputDevice<device>k__BackingField  // 0x168
  private           System.Int32                    <touchId>k__BackingField  // 0x170
  private           UnityEngine.InputSystem.UI.UIPointerType<pointerType>k__BackingField  // 0x174
  private           System.Int32                    <uiToolkitPointerId>k__BackingField  // 0x178
  private           UnityEngine.Vector3             <trackedDevicePosition>k__BackingField  // 0x17C
  private           UnityEngine.Quaternion          <trackedDeviceOrientation>k__BackingField  // 0x188
METHODS:
  System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem)
  UnityEngine.InputSystem.InputControl get_control()
  System.Void set_control(UnityEngine.InputSystem.InputControl value)
  UnityEngine.InputSystem.InputDevice get_device()
  System.Void set_device(UnityEngine.InputSystem.InputDevice value)
  System.Int32 get_touchId()
  System.Void set_touchId(System.Int32 value)
  UnityEngine.InputSystem.UI.UIPointerType get_pointerType()
  System.Void set_pointerType(UnityEngine.InputSystem.UI.UIPointerType value)
  System.Int32 get_uiToolkitPointerId()
  System.Void set_uiToolkitPointerId(System.Int32 value)
  UnityEngine.Vector3 get_trackedDevicePosition()
  System.Void set_trackedDevicePosition(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_trackedDeviceOrientation()
  System.Void set_trackedDeviceOrientation(UnityEngine.Quaternion value)
  System.String ToString()
  System.Int32 MakePointerIdForTouch(System.Int32 deviceId, System.Int32 touchId)
  System.Int32 TouchIdFromPointerId(System.Int32 pointerId)
  System.Void ReadDeviceState()
  System.Int32 GetPenPointerId(UnityEngine.InputSystem.Pen pen)
  System.Int32 GetTouchPointerId(UnityEngine.InputSystem.Controls.TouchControl touchControl)
END_CLASS

CLASS: UnityEngine.InputSystem.UI.UIPointerType
TYPE:  struct
TOKEN: 0x2000115
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.UI.UIPointerTypeNone  // 0x0
  public    static  UnityEngine.InputSystem.UI.UIPointerTypeMouseOrPen  // 0x0
  public    static  UnityEngine.InputSystem.UI.UIPointerTypeTouch  // 0x0
  public    static  UnityEngine.InputSystem.UI.UIPointerTypeTracked  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.UI.UIPointerBehavior
TYPE:  struct
TOKEN: 0x2000116
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.UI.UIPointerBehaviorSingleMouseOrPenButMultiTouchAndTrack  // 0x0
  public    static  UnityEngine.InputSystem.UI.UIPointerBehaviorSingleUnifiedPointer  // 0x0
  public    static  UnityEngine.InputSystem.UI.UIPointerBehaviorAllPointersAsIs  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.UI.ExtendedSubmitCancelEventData
TYPE:  class
TOKEN: 0x2000117
EXTENDS: BaseEventData
FIELDS:
  private           UnityEngine.InputSystem.InputDevice<device>k__BackingField  // 0x20
METHODS:
  UnityEngine.InputSystem.InputDevice get_device()
  System.Void set_device(UnityEngine.InputSystem.InputDevice value)
  System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem)
END_CLASS

CLASS: UnityEngine.InputSystem.UI.INavigationEventData
TYPE:  interface
TOKEN: 0x2000118
FIELDS:
METHODS:
  UnityEngine.InputSystem.InputDevice get_device()
END_CLASS

CLASS: UnityEngine.InputSystem.UI.InputSystemUIInputModule
TYPE:  class
TOKEN: 0x2000119
EXTENDS: BaseInputModule
FIELDS:
  private   static  System.Single                   kClickSpeed  // 0x0
  private           System.Single                   m_MoveRepeatDelay  // 0x48
  private           System.Single                   m_MoveRepeatRate  // 0x4C
  private           System.Single                   m_TrackedDeviceDragThresholdMultiplier  // 0x50
  private           UnityEngine.Transform           m_XRTrackingOrigin  // 0x58
  private   static  UnityEngine.InputSystem.DefaultInputActionsdefaultActions  // 0x0
  private           UnityEngine.InputSystem.InputActionAssetm_ActionsAsset  // 0x60
  private           UnityEngine.InputSystem.InputActionReferencem_PointAction  // 0x68
  private           UnityEngine.InputSystem.InputActionReferencem_MoveAction  // 0x70
  private           UnityEngine.InputSystem.InputActionReferencem_SubmitAction  // 0x78
  private           UnityEngine.InputSystem.InputActionReferencem_CancelAction  // 0x80
  private           UnityEngine.InputSystem.InputActionReferencem_LeftClickAction  // 0x88
  private           UnityEngine.InputSystem.InputActionReferencem_MiddleClickAction  // 0x90
  private           UnityEngine.InputSystem.InputActionReferencem_RightClickAction  // 0x98
  private           UnityEngine.InputSystem.InputActionReferencem_ScrollWheelAction  // 0xA0
  private           UnityEngine.InputSystem.InputActionReferencem_TrackedDevicePositionAction  // 0xA8
  private           UnityEngine.InputSystem.InputActionReferencem_TrackedDeviceOrientationAction  // 0xB0
  private           System.Boolean                  m_DeselectOnBackgroundClick  // 0xB8
  private           UnityEngine.InputSystem.UI.UIPointerBehaviorm_PointerBehavior  // 0xBC
  private           UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehaviorm_CursorLockBehavior  // 0xC0
  private           System.Single                   m_ScrollDeltaPerTick  // 0xC4
  private   static  System.Collections.Generic.Dictionary<UnityEngine.InputSystem.InputAction,UnityEngine.InputSystem.UI.InputSystemUIInputModule.InputActionReferenceState>s_InputActionReferenceCounts  // 0x8
  private           System.Boolean                  m_ActionsHooked  // 0xC8
  private           System.Boolean                  m_NeedToPurgeStalePointers  // 0xC9
  private           System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>m_OnPointDelegate  // 0xD0
  private           System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>m_OnMoveDelegate  // 0xD8
  private           System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>m_OnSubmitCancelDelegate  // 0xE0
  private           System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>m_OnLeftClickDelegate  // 0xE8
  private           System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>m_OnRightClickDelegate  // 0xF0
  private           System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>m_OnMiddleClickDelegate  // 0xF8
  private           System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>m_OnScrollWheelDelegate  // 0x100
  private           System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>m_OnTrackedDevicePositionDelegate  // 0x108
  private           System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>m_OnTrackedDeviceOrientationDelegate  // 0x110
  private           System.Action<System.Object>    m_OnControlsChangedDelegate  // 0x118
  private           System.Int32                    m_CurrentPointerId  // 0x120
  private           System.Int32                    m_CurrentPointerIndex  // 0x124
  private           UnityEngine.InputSystem.UI.UIPointerTypem_CurrentPointerType  // 0x128
  private           UnityEngine.InputSystem.Utilities.InlinedArray<System.Int32>m_PointerIds  // 0x130
  private           UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.UI.PointerModel>m_PointerStates  // 0x140
  private           UnityEngine.InputSystem.UI.NavigationModelm_NavigationState  // 0x358
  private           UnityEngine.InputSystem.UI.SubmitCancelModelm_SubmitCancelState  // 0x380
  private           UnityEngine.GameObject          m_LocalMultiPlayerRoot  // 0x390
METHODS:
  System.Boolean get_deselectOnBackgroundClick()
  System.Void set_deselectOnBackgroundClick(System.Boolean value)
  UnityEngine.InputSystem.UI.UIPointerBehavior get_pointerBehavior()
  System.Void set_pointerBehavior(UnityEngine.InputSystem.UI.UIPointerBehavior value)
  UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehavior get_cursorLockBehavior()
  System.Void set_cursorLockBehavior(UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehavior value)
  UnityEngine.GameObject get_localMultiPlayerRoot()
  System.Void set_localMultiPlayerRoot(UnityEngine.GameObject value)
  System.Single get_scrollDeltaPerTick()
  System.Void set_scrollDeltaPerTick(System.Single value)
  System.Void ActivateModule()
  System.Boolean IsPointerOverGameObject(System.Int32 pointerOrTouchId)
  UnityEngine.EventSystems.RaycastResult GetLastRaycastResult(System.Int32 pointerOrTouchId)
  UnityEngine.EventSystems.RaycastResult PerformRaycast(UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData)
  System.Void ProcessPointer(UnityEngine.InputSystem.UI.PointerModel& state)
  System.Boolean PointerShouldIgnoreTransform(UnityEngine.Transform t)
  System.Void ProcessPointerMovement(UnityEngine.InputSystem.UI.PointerModel& pointer, UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData)
  System.Void ProcessPointerMovement(UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData, UnityEngine.GameObject currentPointerTarget)
  System.Void ProcessPointerButton(UnityEngine.InputSystem.UI.PointerModel.ButtonState& button, UnityEngine.EventSystems.PointerEventData eventData)
  System.Void ProcessPointerButtonDrag(UnityEngine.InputSystem.UI.PointerModel.ButtonState& button, UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData)
  System.Void ProcessPointerScroll(UnityEngine.InputSystem.UI.PointerModel& pointer, UnityEngine.EventSystems.PointerEventData eventData)
  System.Void ProcessNavigation(UnityEngine.InputSystem.UI.NavigationModel& navigationState)
  System.Boolean IsMoveAllowed(UnityEngine.EventSystems.AxisEventData eventData)
  System.Single get_moveRepeatDelay()
  System.Void set_moveRepeatDelay(System.Single value)
  System.Single get_moveRepeatRate()
  System.Void set_moveRepeatRate(System.Single value)
  System.Boolean get_explictlyIgnoreFocus()
  System.Boolean get_shouldIgnoreFocus()
  System.Single get_repeatRate()
  System.Void set_repeatRate(System.Single value)
  System.Single get_repeatDelay()
  System.Void set_repeatDelay(System.Single value)
  UnityEngine.Transform get_xrTrackingOrigin()
  System.Void set_xrTrackingOrigin(UnityEngine.Transform value)
  System.Single get_trackedDeviceDragThresholdMultiplier()
  System.Void set_trackedDeviceDragThresholdMultiplier(System.Single value)
  System.Void SwapAction(UnityEngine.InputSystem.InputActionReference& property, UnityEngine.InputSystem.InputActionReference newValue, System.Boolean actionsHooked, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> actionCallback)
  UnityEngine.InputSystem.InputActionReference get_point()
  System.Void set_point(UnityEngine.InputSystem.InputActionReference value)
  UnityEngine.InputSystem.InputActionReference get_scrollWheel()
  System.Void set_scrollWheel(UnityEngine.InputSystem.InputActionReference value)
  UnityEngine.InputSystem.InputActionReference get_leftClick()
  System.Void set_leftClick(UnityEngine.InputSystem.InputActionReference value)
  UnityEngine.InputSystem.InputActionReference get_middleClick()
  System.Void set_middleClick(UnityEngine.InputSystem.InputActionReference value)
  UnityEngine.InputSystem.InputActionReference get_rightClick()
  System.Void set_rightClick(UnityEngine.InputSystem.InputActionReference value)
  UnityEngine.InputSystem.InputActionReference get_move()
  System.Void set_move(UnityEngine.InputSystem.InputActionReference value)
  UnityEngine.InputSystem.InputActionReference get_submit()
  System.Void set_submit(UnityEngine.InputSystem.InputActionReference value)
  UnityEngine.InputSystem.InputActionReference get_cancel()
  System.Void set_cancel(UnityEngine.InputSystem.InputActionReference value)
  UnityEngine.InputSystem.InputActionReference get_trackedDeviceOrientation()
  System.Void set_trackedDeviceOrientation(UnityEngine.InputSystem.InputActionReference value)
  UnityEngine.InputSystem.InputActionReference get_trackedDevicePosition()
  System.Void set_trackedDevicePosition(UnityEngine.InputSystem.InputActionReference value)
  System.Void AssignDefaultActions()
  System.Void UnassignActions()
  UnityEngine.InputSystem.InputActionReference get_trackedDeviceSelect()
  System.Void set_trackedDeviceSelect(UnityEngine.InputSystem.InputActionReference value)
  System.Void Awake()
  System.Void OnDestroy()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void ResetPointers()
  System.Boolean HasNoActions()
  System.Void EnableAllActions()
  System.Void DisableAllActions()
  System.Void EnableInputAction(UnityEngine.InputSystem.InputActionReference inputActionReference)
  System.Void TryDisableInputAction(UnityEngine.InputSystem.InputActionReference inputActionReference, System.Boolean isComponentDisabling)
  System.Int32 GetPointerStateIndexFor(System.Int32 pointerOrTouchId)
  UnityEngine.InputSystem.UI.PointerModel& GetPointerStateForIndex(System.Int32 index)
  System.Int32 GetDisplayIndexFor(UnityEngine.InputSystem.InputControl control)
  System.Int32 GetPointerStateIndexFor(UnityEngine.InputSystem.InputAction.CallbackContext& context)
  System.Int32 GetPointerStateIndexFor(UnityEngine.InputSystem.InputControl control, System.Boolean createIfNotExists)
  System.Int32 AllocatePointer(System.Int32 pointerId, System.Int32 displayIndex, System.Int32 touchId, UnityEngine.InputSystem.UI.UIPointerType pointerType, UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputControl touchControl)
  System.Boolean SendPointerExitEventsAndRemovePointer(System.Int32 index)
  System.Boolean RemovePointerAtIndex(System.Int32 index)
  System.Void PurgeStalePointers()
  System.Boolean HaveControlForDevice(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputActionReference actionReference)
  System.Void OnPointCallback(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Boolean IgnoreNextClick(UnityEngine.InputSystem.InputAction.CallbackContext& context, System.Boolean wasPressed)
  System.Void OnLeftClickCallback(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnRightClickCallback(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnMiddleClickCallback(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Boolean CheckForRemovedDevice(UnityEngine.InputSystem.InputAction.CallbackContext& context)
  System.Void OnScrollCallback(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnMoveCallback(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnSubmitCancelCallback(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnTrackedDeviceOrientationCallback(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnTrackedDevicePositionCallback(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnControlsChanged(System.Object obj)
  System.Void FilterPointerStatesByType()
  System.Void Process()
  System.Int32 ConvertUIToolkitPointerId(UnityEngine.EventSystems.PointerEventData sourcePointerData)
  System.Void HookActions()
  System.Void UnhookActions()
  System.Void SetActionCallbacks(System.Boolean install)
  System.Void SetActionCallback(UnityEngine.InputSystem.InputActionReference actionReference, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, System.Boolean install)
  UnityEngine.InputSystem.InputActionReference UpdateReferenceForNewAsset(UnityEngine.InputSystem.InputActionReference actionReference)
  UnityEngine.InputSystem.InputActionAsset get_actionsAsset()
  System.Void set_actionsAsset(UnityEngine.InputSystem.InputActionAsset value)
  System.Boolean get_sendPointerHoverToParent()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.UI.MultiplayerEventSystem
TYPE:  class
TOKEN: 0x200011C
EXTENDS: EventSystem
FIELDS:
  private           UnityEngine.GameObject          m_PlayerRoot  // 0x50
METHODS:
  UnityEngine.GameObject get_playerRoot()
  System.Void set_playerRoot(UnityEngine.GameObject value)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void InitializePlayerRoot()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.UI.NavigationModel
TYPE:  struct
TOKEN: 0x200011D
FIELDS:
  public            UnityEngine.Vector2             move  // 0x10
  public            System.Int32                    consecutiveMoveCount  // 0x18
  public            UnityEngine.EventSystems.MoveDirectionlastMoveDirection  // 0x1C
  public            System.Single                   lastMoveTime  // 0x20
  public            UnityEngine.EventSystems.AxisEventDataeventData  // 0x28
  public            UnityEngine.InputSystem.InputDevicedevice  // 0x30
METHODS:
  System.Void Reset()
END_CLASS

CLASS: UnityEngine.InputSystem.UI.SubmitCancelModel
TYPE:  struct
TOKEN: 0x200011E
FIELDS:
  public            UnityEngine.EventSystems.BaseEventDataeventData  // 0x10
  public            UnityEngine.InputSystem.InputDevicedevice  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.UI.PointerModel
TYPE:  struct
TOKEN: 0x200011F
FIELDS:
  public            System.Boolean                  changedThisFrame  // 0x10
  public            UnityEngine.InputSystem.UI.PointerModel.ButtonStateleftButton  // 0x18
  public            UnityEngine.InputSystem.UI.PointerModel.ButtonStaterightButton  // 0xA8
  public            UnityEngine.InputSystem.UI.PointerModel.ButtonStatemiddleButton  // 0x138
  public            UnityEngine.InputSystem.UI.ExtendedPointerEventDataeventData  // 0x1C8
  private           UnityEngine.Vector2             m_ScreenPosition  // 0x1D0
  private           UnityEngine.Vector2             m_ScrollDelta  // 0x1D8
  private           UnityEngine.Vector3             m_WorldPosition  // 0x1E0
  private           UnityEngine.Quaternion          m_WorldOrientation  // 0x1EC
  private           System.Single                   m_Pressure  // 0x1FC
  private           System.Single                   m_AzimuthAngle  // 0x200
  private           System.Single                   m_AltitudeAngle  // 0x204
  private           System.Single                   m_Twist  // 0x208
  private           UnityEngine.Vector2             m_Radius  // 0x20C
METHODS:
  UnityEngine.InputSystem.UI.UIPointerType get_pointerType()
  UnityEngine.Vector2 get_screenPosition()
  System.Void set_screenPosition(UnityEngine.Vector2 value)
  UnityEngine.Vector3 get_worldPosition()
  System.Void set_worldPosition(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_worldOrientation()
  System.Void set_worldOrientation(UnityEngine.Quaternion value)
  UnityEngine.Vector2 get_scrollDelta()
  System.Void set_scrollDelta(UnityEngine.Vector2 value)
  System.Single get_pressure()
  System.Void set_pressure(System.Single value)
  System.Single get_azimuthAngle()
  System.Void set_azimuthAngle(System.Single value)
  System.Single get_altitudeAngle()
  System.Void set_altitudeAngle(System.Single value)
  System.Single get_twist()
  System.Void set_twist(System.Single value)
  UnityEngine.Vector2 get_radius()
  System.Void set_radius(UnityEngine.Vector2 value)
  System.Void .ctor(UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData)
  System.Void OnFrameFinished()
  System.Void CopyTouchOrPenStateFrom(UnityEngine.EventSystems.PointerEventData eventData)
END_CLASS

CLASS: UnityEngine.InputSystem.UI.TrackedDeviceRaycaster
TYPE:  class
TOKEN: 0x2000121
EXTENDS: BaseRaycaster
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData>m_RaycastResultsCache  // 0x20
  private   static  UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster>s_Instances  // 0x0
  private   static readonly System.Collections.Generic.List<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData>s_SortedGraphics  // 0x18
  private           System.Boolean                  m_IgnoreReversedGraphics  // 0x28
  private           System.Boolean                  m_CheckFor2DOcclusion  // 0x29
  private           System.Boolean                  m_CheckFor3DOcclusion  // 0x2A
  private           System.Single                   m_MaxDistance  // 0x2C
  private           UnityEngine.LayerMask           m_BlockingMask  // 0x30
  private           UnityEngine.Canvas              m_Canvas  // 0x38
METHODS:
  UnityEngine.Camera get_eventCamera()
  UnityEngine.LayerMask get_blockingMask()
  System.Void set_blockingMask(UnityEngine.LayerMask value)
  System.Boolean get_checkFor3DOcclusion()
  System.Void set_checkFor3DOcclusion(System.Boolean value)
  System.Boolean get_checkFor2DOcclusion()
  System.Void set_checkFor2DOcclusion(System.Boolean value)
  System.Boolean get_ignoreReversedGraphics()
  System.Void set_ignoreReversedGraphics(System.Boolean value)
  System.Single get_maxDistance()
  System.Void set_maxDistance(System.Single value)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)
  System.Void PerformRaycast(UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList)
  System.Void SortedRaycastGraphics(UnityEngine.Canvas canvas, UnityEngine.Ray ray, System.Collections.Generic.List<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> results)
  System.Boolean RayIntersectsRectTransform(UnityEngine.RectTransform transform, UnityEngine.Ray ray, UnityEngine.Vector3& worldPosition, System.Single& distance)
  UnityEngine.Canvas get_canvas()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.UI.VirtualMouseInput
TYPE:  class
TOKEN: 0x2000124
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.InputSystem.UI.VirtualMouseInput.CursorModem_CursorMode  // 0x18
  private           UnityEngine.UI.Graphic          m_CursorGraphic  // 0x20
  private           UnityEngine.RectTransform       m_CursorTransform  // 0x28
  private           System.Single                   m_CursorSpeed  // 0x30
  private           System.Single                   m_ScrollSpeed  // 0x34
  private           UnityEngine.InputSystem.InputActionPropertym_StickAction  // 0x38
  private           UnityEngine.InputSystem.InputActionPropertym_LeftButtonAction  // 0x50
  private           UnityEngine.InputSystem.InputActionPropertym_MiddleButtonAction  // 0x68
  private           UnityEngine.InputSystem.InputActionPropertym_RightButtonAction  // 0x80
  private           UnityEngine.InputSystem.InputActionPropertym_ForwardButtonAction  // 0x98
  private           UnityEngine.InputSystem.InputActionPropertym_BackButtonAction  // 0xB0
  private           UnityEngine.InputSystem.InputActionPropertym_ScrollWheelAction  // 0xC8
  private           UnityEngine.Canvas              m_Canvas  // 0xE0
  private           UnityEngine.InputSystem.Mouse   m_VirtualMouse  // 0xE8
  private           UnityEngine.InputSystem.Mouse   m_SystemMouse  // 0xF0
  private           System.Action                   m_AfterInputUpdateDelegate  // 0xF8
  private           System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>m_ButtonActionTriggeredDelegate  // 0x100
  private           System.Double                   m_LastTime  // 0x108
  private           UnityEngine.Vector2             m_LastStickValue  // 0x110
METHODS:
  UnityEngine.RectTransform get_cursorTransform()
  System.Void set_cursorTransform(UnityEngine.RectTransform value)
  System.Single get_cursorSpeed()
  System.Void set_cursorSpeed(System.Single value)
  UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode get_cursorMode()
  System.Void set_cursorMode(UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode value)
  UnityEngine.UI.Graphic get_cursorGraphic()
  System.Void set_cursorGraphic(UnityEngine.UI.Graphic value)
  System.Single get_scrollSpeed()
  System.Void set_scrollSpeed(System.Single value)
  UnityEngine.InputSystem.Mouse get_virtualMouse()
  UnityEngine.InputSystem.InputActionProperty get_stickAction()
  System.Void set_stickAction(UnityEngine.InputSystem.InputActionProperty value)
  UnityEngine.InputSystem.InputActionProperty get_leftButtonAction()
  System.Void set_leftButtonAction(UnityEngine.InputSystem.InputActionProperty value)
  UnityEngine.InputSystem.InputActionProperty get_rightButtonAction()
  System.Void set_rightButtonAction(UnityEngine.InputSystem.InputActionProperty value)
  UnityEngine.InputSystem.InputActionProperty get_middleButtonAction()
  System.Void set_middleButtonAction(UnityEngine.InputSystem.InputActionProperty value)
  UnityEngine.InputSystem.InputActionProperty get_forwardButtonAction()
  System.Void set_forwardButtonAction(UnityEngine.InputSystem.InputActionProperty value)
  UnityEngine.InputSystem.InputActionProperty get_backButtonAction()
  System.Void set_backButtonAction(UnityEngine.InputSystem.InputActionProperty value)
  UnityEngine.InputSystem.InputActionProperty get_scrollWheelAction()
  System.Void set_scrollWheelAction(UnityEngine.InputSystem.InputActionProperty value)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void TryFindCanvas()
  System.Void TryEnableHardwareCursor()
  System.Void UpdateMotion()
  System.Void OnButtonActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void SetActionCallback(UnityEngine.InputSystem.InputActionProperty field, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, System.Boolean install)
  System.Void SetAction(UnityEngine.InputSystem.InputActionProperty& field, UnityEngine.InputSystem.InputActionProperty value)
  System.Void OnAfterInputUpdate()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Users.InputUser
TYPE:  struct
TOKEN: 0x2000106
FIELDS:
  public    static  System.UInt32                   InvalidId  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputUserOnChangeMarker  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  k_InputCheckForUnpairMarker  // 0x8
  private           System.UInt32                   m_Id  // 0x10
  private   static  UnityEngine.InputSystem.Users.InputUser.GlobalStates_GlobalState  // 0x10
METHODS:
  System.Boolean get_valid()
  System.Int32 get_index()
  System.UInt32 get_id()
  System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> get_platformUserAccountHandle()
  System.String get_platformUserAccountName()
  System.String get_platformUserAccountId()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_pairedDevices()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_lostDevices()
  UnityEngine.InputSystem.IInputActionCollection get_actions()
  System.Nullable<UnityEngine.InputSystem.InputControlScheme> get_controlScheme()
  UnityEngine.InputSystem.InputControlScheme.MatchResult get_controlSchemeMatch()
  System.Boolean get_hasMissingRequiredDevices()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Users.InputUser> get_all()
  System.Void add_onChange(System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice> value)
  System.Void remove_onChange(System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice> value)
  System.Void add_onUnpairedDeviceUsed(System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> value)
  System.Void remove_onUnpairedDeviceUsed(System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> value)
  System.Void add_onPrefilterUnpairedDeviceActivity(System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value)
  System.Void remove_onPrefilterUnpairedDeviceActivity(System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value)
  System.Int32 get_listenForUnpairedDeviceActivity()
  System.Void set_listenForUnpairedDeviceActivity(System.Int32 value)
  System.String ToString()
  System.Void AssociateActionsWithUser(UnityEngine.InputSystem.IInputActionCollection actions)
  UnityEngine.InputSystem.Users.InputUser.ControlSchemeChangeSyntax ActivateControlScheme(System.String schemeName)
  System.Boolean TryFindControlScheme(System.String schemeName, UnityEngine.InputSystem.InputControlScheme& scheme)
  System.Void FindControlScheme(System.String schemeName, UnityEngine.InputSystem.InputControlScheme& scheme)
  UnityEngine.InputSystem.Users.InputUser.ControlSchemeChangeSyntax ActivateControlScheme(UnityEngine.InputSystem.InputControlScheme scheme)
  System.Void ActivateControlSchemeInternal(System.Int32 userIndex, UnityEngine.InputSystem.InputControlScheme scheme)
  System.Void UnpairDevice(UnityEngine.InputSystem.InputDevice device)
  System.Void UnpairDevices()
  System.Void RemoveLostDevicesForUser(System.Int32 userIndex)
  System.Void UnpairDevicesAndRemoveUser()
  UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> GetUnpairedInputDevices()
  System.Int32 GetUnpairedInputDevices(UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice>& list)
  System.Nullable<UnityEngine.InputSystem.Users.InputUser> FindUserPairedToDevice(UnityEngine.InputSystem.InputDevice device)
  System.Nullable<UnityEngine.InputSystem.Users.InputUser> FindUserByAccount(UnityEngine.InputSystem.Users.InputUserAccountHandle platformUserAccountHandle)
  UnityEngine.InputSystem.Users.InputUser CreateUserWithoutPairedDevices()
  UnityEngine.InputSystem.Users.InputUser PerformPairingWithDevice(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Users.InputUser user, UnityEngine.InputSystem.Users.InputUserPairingOptions options)
  System.Boolean InitiateUserAccountSelection(System.Int32 userIndex, UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Users.InputUserPairingOptions options)
  System.Boolean Equals(UnityEngine.InputSystem.Users.InputUser other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.InputSystem.Users.InputUser left, UnityEngine.InputSystem.Users.InputUser right)
  System.Boolean op_Inequality(UnityEngine.InputSystem.Users.InputUser left, UnityEngine.InputSystem.Users.InputUser right)
  System.Int32 AddUser()
  System.Void RemoveUser(System.Int32 userIndex)
  System.Void Notify(System.Int32 userIndex, UnityEngine.InputSystem.Users.InputUserChange change, UnityEngine.InputSystem.InputDevice device)
  System.Int32 TryFindUserIndex(System.UInt32 userId)
  System.Int32 TryFindUserIndex(UnityEngine.InputSystem.Users.InputUserAccountHandle platformHandle)
  System.Int32 TryFindUserIndex(UnityEngine.InputSystem.InputDevice device)
  System.Void AddDeviceToUser(System.Int32 userIndex, UnityEngine.InputSystem.InputDevice device, System.Boolean asLostDevice, System.Boolean dontUpdateControlScheme)
  System.Void RemoveDeviceFromUser(System.Int32 userIndex, UnityEngine.InputSystem.InputDevice device, System.Boolean asLostDevice)
  System.Void UpdateControlSchemeMatch(System.Int32 userIndex, System.Boolean autoPairMissing)
  System.Int64 UpdatePlatformUserAccount(System.Int32 userIndex, UnityEngine.InputSystem.InputDevice device)
  System.Int64 QueryPairedPlatformUserAccount(UnityEngine.InputSystem.InputDevice device, System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle>& platformAccountHandle, System.String& platformAccountName, System.String& platformAccountId)
  System.Boolean InitiateUserAccountSelectionAtPlatformLevel(UnityEngine.InputSystem.InputDevice device)
  System.Void OnActionChange(System.Object obj, UnityEngine.InputSystem.InputActionChange change)
  System.Void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change)
  System.Int32 FindLostDevice(UnityEngine.InputSystem.InputDevice device, System.Int32 startIndex)
  System.Void OnEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device)
  UnityEngine.InputSystem.Utilities.ISavedState SaveAndResetState()
  System.Void HookIntoActionChange()
  System.Void UnhookFromActionChange()
  System.Void HookIntoDeviceChange()
  System.Void UnhookFromDeviceChange()
  System.Void HookIntoEvents()
  System.Void UnhookFromDeviceStateChange()
  System.Void DisposeAndResetGlobalState()
  System.Void ResetGlobals()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Users.InputUserAccountHandle
TYPE:  struct
TOKEN: 0x200010E
FIELDS:
  private           System.String                   m_ApiName  // 0x10
  private           System.UInt64                   m_Handle  // 0x18
METHODS:
  System.String get_apiName()
  System.UInt64 get_handle()
  System.Void .ctor(System.String apiName, System.UInt64 handle)
  System.String ToString()
  System.Boolean Equals(UnityEngine.InputSystem.Users.InputUserAccountHandle other)
  System.Boolean Equals(System.Object obj)
  System.Boolean op_Equality(UnityEngine.InputSystem.Users.InputUserAccountHandle left, UnityEngine.InputSystem.Users.InputUserAccountHandle right)
  System.Boolean op_Inequality(UnityEngine.InputSystem.Users.InputUserAccountHandle left, UnityEngine.InputSystem.Users.InputUserAccountHandle right)
  System.Int32 GetHashCode()
END_CLASS

CLASS: UnityEngine.InputSystem.Users.InputUserChange
TYPE:  struct
TOKEN: 0x200010F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Users.InputUserChangeAdded  // 0x0
  public    static  UnityEngine.InputSystem.Users.InputUserChangeRemoved  // 0x0
  public    static  UnityEngine.InputSystem.Users.InputUserChangeDevicePaired  // 0x0
  public    static  UnityEngine.InputSystem.Users.InputUserChangeDeviceUnpaired  // 0x0
  public    static  UnityEngine.InputSystem.Users.InputUserChangeDeviceLost  // 0x0
  public    static  UnityEngine.InputSystem.Users.InputUserChangeDeviceRegained  // 0x0
  public    static  UnityEngine.InputSystem.Users.InputUserChangeAccountChanged  // 0x0
  public    static  UnityEngine.InputSystem.Users.InputUserChangeAccountNameChanged  // 0x0
  public    static  UnityEngine.InputSystem.Users.InputUserChangeAccountSelectionInProgress  // 0x0
  public    static  UnityEngine.InputSystem.Users.InputUserChangeAccountSelectionCanceled  // 0x0
  public    static  UnityEngine.InputSystem.Users.InputUserChangeAccountSelectionComplete  // 0x0
  public    static  UnityEngine.InputSystem.Users.InputUserChangeControlSchemeChanged  // 0x0
  public    static  UnityEngine.InputSystem.Users.InputUserChangeControlsChanged  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.Users.InputUserPairingOptions
TYPE:  struct
TOKEN: 0x2000110
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.Users.InputUserPairingOptionsNone  // 0x0
  public    static  UnityEngine.InputSystem.Users.InputUserPairingOptionsForcePlatformUserAccountSelection  // 0x0
  public    static  UnityEngine.InputSystem.Users.InputUserPairingOptionsForceNoPlatformUserAccountSelection  // 0x0
  public    static  UnityEngine.InputSystem.Users.InputUserPairingOptionsUnpairCurrentDevicesFromUser  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.Users.InputUserSettings
TYPE:  class
TOKEN: 0x2000111
FIELDS:
  private           System.String                   <customBindings>k__BackingField  // 0x10
  private           System.Boolean                  <invertMouseX>k__BackingField  // 0x18
  private           System.Boolean                  <invertMouseY>k__BackingField  // 0x19
  private           System.Nullable<System.Single>  <mouseSmoothing>k__BackingField  // 0x1C
  private           System.Nullable<System.Single>  <mouseSensitivity>k__BackingField  // 0x24
  private           System.Boolean                  <invertStickX>k__BackingField  // 0x2C
  private           System.Boolean                  <invertStickY>k__BackingField  // 0x2D
  private           System.Boolean                  <swapSticks>k__BackingField  // 0x2E
  private           System.Boolean                  <swapBumpers>k__BackingField  // 0x2F
  private           System.Boolean                  <swapTriggers>k__BackingField  // 0x30
  private           System.Boolean                  <swapDpadAndLeftStick>k__BackingField  // 0x31
  private           System.Single                   <vibrationStrength>k__BackingField  // 0x34
  private           System.String                   m_CustomBindings  // 0x38
METHODS:
  System.String get_customBindings()
  System.Void set_customBindings(System.String value)
  System.Boolean get_invertMouseX()
  System.Void set_invertMouseX(System.Boolean value)
  System.Boolean get_invertMouseY()
  System.Void set_invertMouseY(System.Boolean value)
  System.Nullable<System.Single> get_mouseSmoothing()
  System.Void set_mouseSmoothing(System.Nullable<System.Single> value)
  System.Nullable<System.Single> get_mouseSensitivity()
  System.Void set_mouseSensitivity(System.Nullable<System.Single> value)
  System.Boolean get_invertStickX()
  System.Void set_invertStickX(System.Boolean value)
  System.Boolean get_invertStickY()
  System.Void set_invertStickY(System.Boolean value)
  System.Boolean get_swapSticks()
  System.Void set_swapSticks(System.Boolean value)
  System.Boolean get_swapBumpers()
  System.Void set_swapBumpers(System.Boolean value)
  System.Boolean get_swapTriggers()
  System.Void set_swapTriggers(System.Boolean value)
  System.Boolean get_swapDpadAndLeftStick()
  System.Void set_swapDpadAndLeftStick(System.Boolean value)
  System.Single get_vibrationStrength()
  System.Void set_vibrationStrength(System.Single value)
  System.Void Apply(UnityEngine.InputSystem.IInputActionCollection actions)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.InputActionTrace
TYPE:  class
TOKEN: 0x2000231
FIELDS:
  private           System.Boolean                  m_SubscribedToAll  // 0x10
  private           System.Boolean                  m_OnActionChangeHooked  // 0x11
  private           UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputAction>m_SubscribedActions  // 0x18
  private           UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputActionMap>m_SubscribedActionMaps  // 0x30
  private           UnityEngine.InputSystem.LowLevel.InputEventBufferm_EventBuffer  // 0x48
  private           UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputActionState>m_ActionMapStates  // 0x68
  private           UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputActionState>m_ActionMapStateClones  // 0x80
  private           System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>m_CallbackDelegate  // 0x98
  private           System.Action<System.Object,UnityEngine.InputSystem.InputActionChange>m_ActionChangeDelegate  // 0xA0
METHODS:
  UnityEngine.InputSystem.LowLevel.InputEventBuffer get_buffer()
  System.Int32 get_count()
  System.Void .ctor()
  System.Void .ctor(UnityEngine.InputSystem.InputAction action)
  System.Void .ctor(UnityEngine.InputSystem.InputActionMap actionMap)
  System.Void SubscribeToAll()
  System.Void UnsubscribeFromAll()
  System.Void SubscribeTo(UnityEngine.InputSystem.InputAction action)
  System.Void SubscribeTo(UnityEngine.InputSystem.InputActionMap actionMap)
  System.Void UnsubscribeFrom(UnityEngine.InputSystem.InputAction action)
  System.Void UnsubscribeFrom(UnityEngine.InputSystem.InputActionMap actionMap)
  System.Void RecordAction(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void Clear()
  System.Void Finalize()
  System.String ToString()
  System.Void Dispose()
  System.Void DisposeInternal()
  System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void HookOnActionChange()
  System.Void UnhookOnActionChange()
  System.Void OnActionChange(System.Object actionOrMapOrAsset, UnityEngine.InputSystem.InputActionChange change)
  System.Void CloneActionStateBeforeBindingsChange(UnityEngine.InputSystem.InputActionMap actionMap)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.ArrayHelpers
TYPE:  class
TOKEN: 0x2000234
FIELDS:
METHODS:
  System.Int32 LengthSafe(TValue[] array)
  System.Void Clear(TValue[] array)
  System.Void Clear(TValue[] array, System.Int32 count)
  System.Void Clear(TValue[] array, System.Int32& count)
  System.Void EnsureCapacity(TValue[]& array, System.Int32 count, System.Int32 capacity, System.Int32 capacityIncrement)
  System.Void DuplicateWithCapacity(TValue[]& array, System.Int32 count, System.Int32 capacity, System.Int32 capacityIncrement)
  System.Boolean Contains(TValue[] array, TValue value)
  System.Boolean ContainsReference(TValue[] array, TValue value)
  System.Boolean ContainsReference(TFirst[] array, System.Int32 count, TSecond value)
  System.Boolean ContainsReference(TFirst[] array, System.Int32 startIndex, System.Int32 count, TSecond value)
  System.Boolean HaveDuplicateReferences(TFirst[] first, System.Int32 index, System.Int32 count)
  System.Boolean HaveEqualElements(TValue[] first, TValue[] second, System.Int32 count)
  System.Int32 IndexOf(TValue[] array, TValue value, System.Int32 startIndex, System.Int32 count)
  System.Int32 IndexOf(TValue[] array, System.Predicate<TValue> predicate)
  System.Int32 IndexOf(TValue[] array, System.Predicate<TValue> predicate, System.Int32 startIndex, System.Int32 count)
  System.Int32 IndexOfReference(TFirst[] array, TSecond value, System.Int32 count)
  System.Int32 IndexOfReference(TFirst[] array, TSecond value, System.Int32 startIndex, System.Int32 count)
  System.Int32 IndexOfValue(TValue[] array, TValue value, System.Int32 startIndex, System.Int32 count)
  System.Void Resize(Unity.Collections.NativeArray<TValue>& array, System.Int32 newSize, Unity.Collections.Allocator allocator)
  System.Int32 Append(TValue[]& array, TValue value)
  System.Int32 Append(TValue[]& array, System.Collections.Generic.IEnumerable<TValue> values)
  System.Int32 AppendToImmutable(TValue[]& array, TValue[] values)
  System.Int32 AppendWithCapacity(TValue[]& array, System.Int32& count, TValue value, System.Int32 capacityIncrement)
  System.Int32 AppendListWithCapacity(TValue[]& array, System.Int32& length, TValues values, System.Int32 capacityIncrement)
  System.Int32 AppendWithCapacity(Unity.Collections.NativeArray<TValue>& array, System.Int32& count, TValue value, System.Int32 capacityIncrement, Unity.Collections.Allocator allocator)
  System.Void InsertAt(TValue[]& array, System.Int32 index, TValue value)
  System.Void InsertAtWithCapacity(TValue[]& array, System.Int32& count, System.Int32 index, TValue value, System.Int32 capacityIncrement)
  System.Void PutAtIfNotSet(TValue[]& array, System.Int32 index, System.Func<TValue> valueFn)
  System.Int32 GrowBy(TValue[]& array, System.Int32 count)
  System.Int32 GrowBy(Unity.Collections.NativeArray<TValue>& array, System.Int32 count, Unity.Collections.Allocator allocator)
  System.Int32 GrowWithCapacity(TValue[]& array, System.Int32& count, System.Int32 growBy, System.Int32 capacityIncrement)
  System.Int32 GrowWithCapacity(Unity.Collections.NativeArray<TValue>& array, System.Int32& count, System.Int32 growBy, System.Int32 capacityIncrement, Unity.Collections.Allocator allocator)
  TValue[] Join(TValue value, TValue[] values)
  TValue[] Merge(TValue[] first, TValue[] second)
  TValue[] Merge(TValue[] first, TValue[] second, System.Collections.Generic.IEqualityComparer<TValue> comparer)
  System.Void EraseAt(TValue[]& array, System.Int32 index)
  System.Void EraseAtWithCapacity(TValue[] array, System.Int32& count, System.Int32 index)
  System.Void EraseAtWithCapacity(Unity.Collections.NativeArray<TValue> array, System.Int32& count, System.Int32 index)
  System.Boolean Erase(TValue[]& array, TValue value)
  System.Void EraseAtByMovingTail(TValue[] array, System.Int32& count, System.Int32 index)
  TValue[] Copy(TValue[] array)
  TValue[] Clone(TValue[] array)
  TNew[] Select(TOld[] array, System.Func<TOld,TNew> converter)
  System.Void Swap(TValue& first, TValue& second)
  System.Void MoveSlice(TValue[] array, System.Int32 sourceIndex, System.Int32 destinationIndex, System.Int32 count)
  System.Void EraseSliceWithCapacity(TValue[]& array, System.Int32& length, System.Int32 index, System.Int32 count)
  System.Void SwapElements(TValue[] array, System.Int32 index1, System.Int32 index2)
  System.Void SwapElements(Unity.Collections.NativeArray<TValue> array, System.Int32 index1, System.Int32 index2)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.CallbackArray`1
TYPE:  struct
TOKEN: 0x2000238
FIELDS:
  private           System.Boolean                  m_CannotMutateCallbacksArray  // 0x0
  private           UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate>m_Callbacks  // 0x0
  private           UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate>m_CallbacksToAdd  // 0x0
  private           UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate>m_CallbacksToRemove  // 0x0
METHODS:
  System.Int32 get_length()
  TDelegate get_Item(System.Int32 index)
  System.Void Clear()
  System.Void AddCallback(TDelegate dlg)
  System.Void RemoveCallback(TDelegate dlg)
  System.Void LockForChanges()
  System.Void UnlockForChanges()
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.Vector2MagnitudeComparer
TYPE:  struct
TOKEN: 0x2000239
FIELDS:
METHODS:
  System.Int32 Compare(UnityEngine.Vector2 x, UnityEngine.Vector2 y)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.Vector3MagnitudeComparer
TYPE:  struct
TOKEN: 0x200023A
FIELDS:
METHODS:
  System.Int32 Compare(UnityEngine.Vector3 x, UnityEngine.Vector3 y)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.CSharpCodeHelpers
TYPE:  class
TOKEN: 0x200023B
FIELDS:
METHODS:
  System.Boolean IsProperIdentifier(System.String name)
  System.Boolean IsEmptyOrProperIdentifier(System.String name)
  System.Boolean IsEmptyOrProperNamespaceName(System.String name)
  System.String MakeIdentifier(System.String name, System.String suffix)
  System.String MakeTypeName(System.String name, System.String suffix)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.DelegateHelpers
TYPE:  class
TOKEN: 0x200023C
FIELDS:
METHODS:
  System.Void InvokeCallbacksSafe(UnityEngine.InputSystem.Utilities.CallbackArray<System.Action>& callbacks, Unity.Profiling.ProfilerMarker marker, System.String callbackName, System.Object context)
  System.Void InvokeCallbacksSafe(UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<TValue>>& callbacks, TValue argument, System.String callbackName, System.Object context)
  System.Void InvokeCallbacksSafe(UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<TValue1,TValue2>>& callbacks, TValue1 argument1, TValue2 argument2, Unity.Profiling.ProfilerMarker marker, System.String callbackName, System.Object context)
  System.Boolean InvokeCallbacksSafe_AnyCallbackReturnsTrue(UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue1,TValue2,System.Boolean>>& callbacks, TValue1 argument1, TValue2 argument2, System.String callbackName, System.Object context)
  System.Void InvokeCallbacksSafe_AndInvokeReturnedActions(UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue,System.Action>>& callbacks, TValue argument, System.String callbackName, System.Object context)
  System.Boolean InvokeCallbacksSafe_AnyCallbackReturnsObject(UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue,TReturn>>& callbacks, TValue argument, System.String callbackName, System.Object context)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.DisplayStringFormatAttribute
TYPE:  class
TOKEN: 0x200023D
EXTENDS: Attribute
FIELDS:
  private           System.String                   <formatString>k__BackingField  // 0x10
METHODS:
  System.String get_formatString()
  System.Void set_formatString(System.String value)
  System.Void .ctor(System.String formatString)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.ExceptionHelpers
TYPE:  class
TOKEN: 0x200023E
FIELDS:
METHODS:
  System.Boolean IsExceptionIndicatingBugInCode(System.Exception exception)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.FourCC
TYPE:  struct
TOKEN: 0x200023F
FIELDS:
  private           System.Int32                    m_Code  // 0x10
METHODS:
  System.Void .ctor(System.Int32 code)
  System.Void .ctor(System.Char a, System.Char b, System.Char c, System.Char d)
  System.Void .ctor(System.String str)
  System.Int32 op_Implicit(UnityEngine.InputSystem.Utilities.FourCC fourCC)
  UnityEngine.InputSystem.Utilities.FourCC op_Implicit(System.Int32 i)
  System.String ToString()
  System.Boolean Equals(UnityEngine.InputSystem.Utilities.FourCC other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.FourCC left, UnityEngine.InputSystem.Utilities.FourCC right)
  System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.FourCC left, UnityEngine.InputSystem.Utilities.FourCC right)
  UnityEngine.InputSystem.Utilities.FourCC FromInt32(System.Int32 i)
  System.Int32 ToInt32(UnityEngine.InputSystem.Utilities.FourCC fourCC)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.InlinedArray`1
TYPE:  struct
TOKEN: 0x2000240
FIELDS:
  public            System.Int32                    length  // 0x0
  public            TValue                          firstValue  // 0x0
  public            TValue[]                        additionalValues  // 0x0
METHODS:
  System.Int32 get_Capacity()
  System.Void .ctor(TValue value)
  System.Void .ctor(TValue firstValue, TValue[] additionalValues)
  System.Void .ctor(System.Collections.Generic.IEnumerable<TValue> values)
  TValue get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, TValue value)
  System.Void Clear()
  System.Void ClearWithCapacity()
  UnityEngine.InputSystem.Utilities.InlinedArray<TValue> Clone()
  System.Void SetLength(System.Int32 size)
  TValue[] ToArray()
  TOther[] ToArray(System.Func<TValue,TOther> mapFunction)
  System.Int32 IndexOf(TValue value)
  System.Int32 Append(TValue value)
  System.Int32 AppendWithCapacity(TValue value, System.Int32 capacityIncrement)
  System.Void AssignWithCapacity(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> values)
  System.Void Append(System.Collections.Generic.IEnumerable<TValue> values)
  System.Void Remove(TValue value)
  System.Void RemoveAtWithCapacity(System.Int32 index)
  System.Void RemoveAt(System.Int32 index)
  System.Void RemoveAtByMovingTailWithCapacity(System.Int32 index)
  System.Boolean RemoveByMovingTailWithCapacity(TValue value)
  System.Boolean Contains(TValue value, System.Collections.Generic.IEqualityComparer<TValue> comparer)
  System.Void Merge(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> other)
  System.Collections.Generic.IEnumerator<TValue> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.InputArrayExtensions
TYPE:  class
TOKEN: 0x2000242
FIELDS:
METHODS:
  System.Int32 IndexOfReference(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value)
  System.Boolean Contains(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value)
  System.Boolean ContainsReference(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.InternedString
TYPE:  struct
TOKEN: 0x2000243
FIELDS:
  private   readonly System.String                   m_StringOriginalCase  // 0x10
  private   readonly System.String                   m_StringLowerCase  // 0x18
METHODS:
  System.Int32 get_length()
  System.Void .ctor(System.String text)
  System.Boolean IsEmpty()
  System.String ToLower()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(UnityEngine.InputSystem.Utilities.InternedString other)
  System.Int32 CompareTo(UnityEngine.InputSystem.Utilities.InternedString other)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.InternedString a, UnityEngine.InputSystem.Utilities.InternedString b)
  System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.InternedString a, UnityEngine.InputSystem.Utilities.InternedString b)
  System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.InternedString a, System.String b)
  System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.InternedString a, System.String b)
  System.Boolean op_Equality(System.String a, UnityEngine.InputSystem.Utilities.InternedString b)
  System.Boolean op_Inequality(System.String a, UnityEngine.InputSystem.Utilities.InternedString b)
  System.Boolean op_LessThan(UnityEngine.InputSystem.Utilities.InternedString left, UnityEngine.InputSystem.Utilities.InternedString right)
  System.Boolean op_GreaterThan(UnityEngine.InputSystem.Utilities.InternedString left, UnityEngine.InputSystem.Utilities.InternedString right)
  System.String op_Implicit(UnityEngine.InputSystem.Utilities.InternedString str)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.JsonParser
TYPE:  struct
TOKEN: 0x2000244
FIELDS:
  private   readonly System.String                   m_Text  // 0x10
  private   readonly System.Int32                    m_Length  // 0x18
  private           System.Int32                    m_Position  // 0x1C
  private           System.Boolean                  m_MatchAnyElementInArray  // 0x20
  private           System.Boolean                  m_DryRun  // 0x21
METHODS:
  System.Void .ctor(System.String json)
  System.Void Reset()
  System.String ToString()
  System.Boolean NavigateToProperty(System.String path)
  System.Boolean CurrentPropertyHasValueEqualTo(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue expectedValue)
  System.Boolean ParseToken(System.Char token)
  System.Boolean ParseValue()
  System.Boolean ParseValue(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue& result)
  System.Boolean ParseStringValue(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue& result)
  System.Boolean ParseArrayValue(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue& result)
  System.Boolean ParseObjectValue(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue& result)
  System.Boolean ParseNumber(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue& result)
  System.Boolean ParseBooleanValue(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue& result)
  System.Boolean ParseNullValue(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue& result)
  System.Boolean SkipToValue()
  System.Boolean SkipString(System.String text)
  System.Void SkipWhitespace()
  System.Boolean get_isAtEnd()
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.MemoryHelpers
TYPE:  class
TOKEN: 0x2000249
FIELDS:
METHODS:
  System.Boolean Compare(System.Void* ptr1, System.Void* ptr2, UnityEngine.InputSystem.Utilities.MemoryHelpers.BitRegion region)
  System.UInt32 ComputeFollowingByteOffset(System.UInt32 byteOffset, System.UInt32 sizeInBits)
  System.Void WriteSingleBit(System.Void* ptr, System.UInt32 bitOffset, System.Boolean value)
  System.Boolean ReadSingleBit(System.Void* ptr, System.UInt32 bitOffset)
  System.Void MemCpyBitRegion(System.Void* destination, System.Void* source, System.UInt32 bitOffset, System.UInt32 bitCount)
  System.Boolean MemCmpBitRegion(System.Void* ptr1, System.Void* ptr2, System.UInt32 bitOffset, System.UInt32 bitCount, System.Void* mask)
  System.Void MemSet(System.Void* destination, System.Int32 numBytes, System.Byte value)
  System.Void MemCpyMasked(System.Void* destination, System.Void* source, System.Int32 numBytes, System.Void* mask)
  System.UInt32 ReadMultipleBitsAsUInt(System.Void* ptr, System.UInt32 bitOffset, System.UInt32 bitCount)
  System.Void WriteUIntAsMultipleBits(System.Void* ptr, System.UInt32 bitOffset, System.UInt32 bitCount, System.UInt32 value)
  System.Int32 ReadTwosComplementMultipleBitsAsInt(System.Void* ptr, System.UInt32 bitOffset, System.UInt32 bitCount)
  System.Void WriteIntAsTwosComplementMultipleBits(System.Void* ptr, System.UInt32 bitOffset, System.UInt32 bitCount, System.Int32 value)
  System.Int32 ReadExcessKMultipleBitsAsInt(System.Void* ptr, System.UInt32 bitOffset, System.UInt32 bitCount)
  System.Void WriteIntAsExcessKMultipleBits(System.Void* ptr, System.UInt32 bitOffset, System.UInt32 bitCount, System.Int32 value)
  System.Single ReadMultipleBitsAsNormalizedUInt(System.Void* ptr, System.UInt32 bitOffset, System.UInt32 bitCount)
  System.Void WriteNormalizedUIntAsMultipleBits(System.Void* ptr, System.UInt32 bitOffset, System.UInt32 bitCount, System.Single value)
  System.Void SetBitsInBuffer(System.Void* buffer, System.Int32 byteOffset, System.Int32 bitOffset, System.Int32 sizeInBits, System.Boolean value)
  System.Void Swap(TValue& a, TValue& b)
  System.UInt32 AlignNatural(System.UInt32 offset, System.UInt32 sizeInBytes)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.MiscHelpers
TYPE:  class
TOKEN: 0x200024B
FIELDS:
METHODS:
  TValue GetValueOrDefault(System.Collections.Generic.Dictionary<TKey,TValue> dictionary, TKey key)
  System.Collections.Generic.IEnumerable<TValue> EveryNth(System.Collections.Generic.IEnumerable<TValue> enumerable, System.Int32 n, System.Int32 start)
  System.Int32 IndexOf(System.Collections.Generic.IEnumerable<TValue> enumerable, TValue value)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.NameAndParameters
TYPE:  struct
TOKEN: 0x200024D
FIELDS:
  private           System.String                   <name>k__BackingField  // 0x10
  private           UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue><parameters>k__BackingField  // 0x18
METHODS:
  System.String get_name()
  System.Void set_name(System.String value)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> get_parameters()
  System.Void set_parameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> value)
  System.String ToString()
  System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.NameAndParameters> ParseMultiple(System.String text)
  System.Boolean ParseMultiple(System.String text, System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.NameAndParameters>& list)
  System.String ParseName(System.String text)
  UnityEngine.InputSystem.Utilities.NameAndParameters Parse(System.String text)
  UnityEngine.InputSystem.Utilities.NameAndParameters ParseNameAndParameters(System.String text, System.Int32& index, System.Boolean nameOnly)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.NamedValue
TYPE:  struct
TOKEN: 0x200024F
FIELDS:
  public    static  System.String                   Separator  // 0x0
  private           System.String                   <name>k__BackingField  // 0x10
  private           UnityEngine.InputSystem.Utilities.PrimitiveValue<value>k__BackingField  // 0x18
METHODS:
  System.String get_name()
  System.Void set_name(System.String value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue get_value()
  System.Void set_value(UnityEngine.InputSystem.Utilities.PrimitiveValue value)
  System.TypeCode get_type()
  UnityEngine.InputSystem.Utilities.NamedValue ConvertTo(System.TypeCode type)
  UnityEngine.InputSystem.Utilities.NamedValue From(System.String name, TValue value)
  System.String ToString()
  System.Boolean Equals(UnityEngine.InputSystem.Utilities.NamedValue other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.NamedValue left, UnityEngine.InputSystem.Utilities.NamedValue right)
  System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.NamedValue left, UnityEngine.InputSystem.Utilities.NamedValue right)
  UnityEngine.InputSystem.Utilities.NamedValue[] ParseMultiple(System.String parameterString)
  UnityEngine.InputSystem.Utilities.NamedValue Parse(System.String str)
  UnityEngine.InputSystem.Utilities.NamedValue ParseParameter(System.String parameterString, System.Int32& index)
  System.Void ApplyToObject(System.Object instance)
  System.Void ApplyAllToObject(System.Object instance, TParameterList parameters)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.NumberHelpers
TYPE:  class
TOKEN: 0x2000250
FIELDS:
METHODS:
  System.Int32 AlignToMultipleOf(System.Int32 number, System.Int32 alignment)
  System.Int64 AlignToMultipleOf(System.Int64 number, System.Int64 alignment)
  System.UInt32 AlignToMultipleOf(System.UInt32 number, System.UInt32 alignment)
  System.Boolean Approximately(System.Double a, System.Double b)
  System.Single IntToNormalizedFloat(System.Int32 value, System.Int32 minValue, System.Int32 maxValue)
  System.Int32 NormalizedFloatToInt(System.Single value, System.Int32 intMinValue, System.Int32 intMaxValue)
  System.Single UIntToNormalizedFloat(System.UInt32 value, System.UInt32 minValue, System.UInt32 maxValue)
  System.UInt32 NormalizedFloatToUInt(System.Single value, System.UInt32 uintMinValue, System.UInt32 uintMaxValue)
  System.UInt32 RemapUIntBitsToNormalizeFloatToUIntBits(System.UInt32 value, System.UInt32 inBitSize, System.UInt32 outBitSize)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.ForDeviceEventObservable
TYPE:  class
TOKEN: 0x2000251
FIELDS:
  private           System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr>m_Source  // 0x10
  private           UnityEngine.InputSystem.InputDevicem_Device  // 0x18
  private           System.Type                     m_DeviceType  // 0x20
METHODS:
  System.Void .ctor(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source, System.Type deviceType, UnityEngine.InputSystem.InputDevice device)
  System.IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.Observable
TYPE:  class
TOKEN: 0x2000253
FIELDS:
METHODS:
  System.IObservable<TValue> Where(System.IObservable<TValue> source, System.Func<TValue,System.Boolean> predicate)
  System.IObservable<TResult> Select(System.IObservable<TSource> source, System.Func<TSource,TResult> filter)
  System.IObservable<TResult> SelectMany(System.IObservable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> filter)
  System.IObservable<TValue> Take(System.IObservable<TValue> source, System.Int32 count)
  System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source, UnityEngine.InputSystem.InputDevice device)
  System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source)
  System.IDisposable CallOnce(System.IObservable<TValue> source, System.Action<TValue> action)
  System.IDisposable Call(System.IObservable<TValue> source, System.Action<TValue> action)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.Observer`1
TYPE:  class
TOKEN: 0x2000255
FIELDS:
  private           System.Action<TValue>           m_OnNext  // 0x0
  private           System.Action                   m_OnCompleted  // 0x0
METHODS:
  System.Void .ctor(System.Action<TValue> onNext, System.Action onCompleted)
  System.Void OnCompleted()
  System.Void OnError(System.Exception error)
  System.Void OnNext(TValue evt)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.SelectManyObservable`2
TYPE:  class
TOKEN: 0x2000256
FIELDS:
  private   readonly System.IObservable<TSource>     m_Source  // 0x0
  private   readonly System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>>m_Filter  // 0x0
METHODS:
  System.Void .ctor(System.IObservable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> filter)
  System.IDisposable Subscribe(System.IObserver<TResult> observer)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.TakeNObservable`1
TYPE:  class
TOKEN: 0x2000258
FIELDS:
  private           System.IObservable<TValue>      m_Source  // 0x0
  private           System.Int32                    m_Count  // 0x0
METHODS:
  System.Void .ctor(System.IObservable<TValue> source, System.Int32 count)
  System.IDisposable Subscribe(System.IObserver<TValue> observer)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.WhereObservable`1
TYPE:  class
TOKEN: 0x200025A
FIELDS:
  private   readonly System.IObservable<TValue>      m_Source  // 0x0
  private   readonly System.Func<TValue,System.Boolean>m_Predicate  // 0x0
METHODS:
  System.Void .ctor(System.IObservable<TValue> source, System.Func<TValue,System.Boolean> predicate)
  System.IDisposable Subscribe(System.IObserver<TValue> observer)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.OneOrMore`2
TYPE:  struct
TOKEN: 0x200025C
FIELDS:
  private   readonly System.Boolean                  m_IsSingle  // 0x0
  private   readonly TValue                          m_Single  // 0x0
  private   readonly TList                           m_Multiple  // 0x0
METHODS:
  System.Int32 get_Count()
  TValue get_Item(System.Int32 index)
  System.Void .ctor(TValue single)
  System.Void .ctor(TList multiple)
  UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> op_Implicit(TValue single)
  UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> op_Implicit(TList multiple)
  System.Collections.Generic.IEnumerator<TValue> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.PredictiveParser
TYPE:  struct
TOKEN: 0x200025E
FIELDS:
  private           System.Int32                    m_Position  // 0x10
METHODS:
  System.Void ExpectSingleChar(System.ReadOnlySpan<System.Char> str, System.Char c)
  System.Int32 ExpectInt(System.ReadOnlySpan<System.Char> str)
  System.ReadOnlySpan<System.Char> ExpectString(System.ReadOnlySpan<System.Char> str)
  System.Boolean AcceptSingleChar(System.ReadOnlySpan<System.Char> str, System.Char c)
  System.Boolean AcceptString(System.ReadOnlySpan<System.Char> input, System.ReadOnlySpan<System.Char>& output)
  System.Void AcceptInt(System.ReadOnlySpan<System.Char> str)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.PrimitiveValue
TYPE:  struct
TOKEN: 0x200025F
FIELDS:
  private           System.TypeCode                 m_Type  // 0x10
  private           System.Boolean                  m_BoolValue  // 0x14
  private           System.Char                     m_CharValue  // 0x14
  private           System.Byte                     m_ByteValue  // 0x14
  private           System.SByte                    m_SByteValue  // 0x14
  private           System.Int16                    m_ShortValue  // 0x14
  private           System.UInt16                   m_UShortValue  // 0x14
  private           System.Int32                    m_IntValue  // 0x14
  private           System.UInt32                   m_UIntValue  // 0x14
  private           System.Int64                    m_LongValue  // 0x14
  private           System.UInt64                   m_ULongValue  // 0x14
  private           System.Single                   m_FloatValue  // 0x14
  private           System.Double                   m_DoubleValue  // 0x14
METHODS:
  System.Byte* get_valuePtr()
  System.TypeCode get_type()
  System.Boolean get_isEmpty()
  System.Void .ctor(System.Boolean value)
  System.Void .ctor(System.Char value)
  System.Void .ctor(System.Byte value)
  System.Void .ctor(System.SByte value)
  System.Void .ctor(System.Int16 value)
  System.Void .ctor(System.UInt16 value)
  System.Void .ctor(System.Int32 value)
  System.Void .ctor(System.UInt32 value)
  System.Void .ctor(System.Int64 value)
  System.Void .ctor(System.UInt64 value)
  System.Void .ctor(System.Single value)
  System.Void .ctor(System.Double value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue ConvertTo(System.TypeCode type)
  System.Boolean Equals(UnityEngine.InputSystem.Utilities.PrimitiveValue other)
  System.Boolean Equals(System.Object obj)
  System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.PrimitiveValue left, UnityEngine.InputSystem.Utilities.PrimitiveValue right)
  System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.PrimitiveValue left, UnityEngine.InputSystem.Utilities.PrimitiveValue right)
  System.Int32 GetHashCode()
  System.String ToString()
  UnityEngine.InputSystem.Utilities.PrimitiveValue FromString(System.String value)
  System.TypeCode GetTypeCode()
  System.Boolean ToBoolean(System.IFormatProvider provider)
  System.Byte ToByte(System.IFormatProvider provider)
  System.Char ToChar(System.IFormatProvider provider)
  System.DateTime ToDateTime(System.IFormatProvider provider)
  System.Decimal ToDecimal(System.IFormatProvider provider)
  System.Double ToDouble(System.IFormatProvider provider)
  System.Int16 ToInt16(System.IFormatProvider provider)
  System.Int32 ToInt32(System.IFormatProvider provider)
  System.Int64 ToInt64(System.IFormatProvider provider)
  System.SByte ToSByte(System.IFormatProvider provider)
  System.Single ToSingle(System.IFormatProvider provider)
  System.String ToString(System.IFormatProvider provider)
  System.Object ToType(System.Type conversionType, System.IFormatProvider provider)
  System.UInt16 ToUInt16(System.IFormatProvider provider)
  System.UInt32 ToUInt32(System.IFormatProvider provider)
  System.UInt64 ToUInt64(System.IFormatProvider provider)
  System.Object ToObject()
  UnityEngine.InputSystem.Utilities.PrimitiveValue From(TValue value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue FromObject(System.Object value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.Boolean value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.Char value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.Byte value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.SByte value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.Int16 value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.UInt16 value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.Int32 value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.UInt32 value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.Int64 value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.UInt64 value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.Single value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.Double value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue FromBoolean(System.Boolean value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue FromChar(System.Char value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue FromByte(System.Byte value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue FromSByte(System.SByte value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue FromInt16(System.Int16 value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue FromUInt16(System.UInt16 value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue FromInt32(System.Int32 value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue FromUInt32(System.UInt32 value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue FromInt64(System.Int64 value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue FromUInt64(System.UInt64 value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue FromSingle(System.Single value)
  UnityEngine.InputSystem.Utilities.PrimitiveValue FromDouble(System.Double value)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.ReadOnlyArray`1
TYPE:  struct
TOKEN: 0x2000260
FIELDS:
  private           TValue[]                        m_Array  // 0x0
  private           System.Int32                    m_StartIndex  // 0x0
  private           System.Int32                    m_Length  // 0x0
METHODS:
  System.Void .ctor(TValue[] array)
  System.Void .ctor(TValue[] array, System.Int32 index, System.Int32 length)
  TValue[] ToArray()
  System.Int32 IndexOf(System.Predicate<TValue> predicate)
  UnityEngine.InputSystem.Utilities.ReadOnlyArray.Enumerator<TValue> GetEnumerator()
  System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> op_Implicit(TValue[] array)
  System.Int32 get_Count()
  TValue get_Item(System.Int32 index)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.ReadOnlyArrayExtensions
TYPE:  class
TOKEN: 0x2000262
FIELDS:
METHODS:
  System.Boolean Contains(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value)
  System.Boolean ContainsReference(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value)
  System.Int32 IndexOfReference(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value)
  System.Boolean HaveEqualReferences(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array1, System.Collections.Generic.IReadOnlyList<TValue> array2, System.Int32 count)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.ISavedState
TYPE:  interface
TOKEN: 0x2000263
FIELDS:
METHODS:
  System.Void StaticDisposeCurrentState()
  System.Void RestoreSavedState()
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.SavedStructState`1
TYPE:  class
TOKEN: 0x2000264
FIELDS:
  private           T                               m_State  // 0x0
  private           UnityEngine.InputSystem.Utilities.SavedStructState.TypedRestore<T>m_RestoreAction  // 0x0
  private           System.Action                   m_StaticDisposeCurrentState  // 0x0
METHODS:
  System.Void .ctor(T& state, UnityEngine.InputSystem.Utilities.SavedStructState.TypedRestore<T> restoreAction, System.Action staticDisposeCurrentState)
  System.Void StaticDisposeCurrentState()
  System.Void RestoreSavedState()
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.SpriteUtilities
TYPE:  class
TOKEN: 0x2000266
FIELDS:
METHODS:
  UnityEngine.Sprite CreateCircleSprite(System.Int32 radius, UnityEngine.Color32 colour)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.StringHelpers
TYPE:  class
TOKEN: 0x2000267
FIELDS:
METHODS:
  System.String Escape(System.String str, System.String chars, System.String replacements)
  System.String Unescape(System.String str, System.String chars, System.String replacements)
  System.Boolean Contains(System.String str, System.Char ch)
  System.Boolean Contains(System.String str, System.String text, System.StringComparison comparison)
  System.String GetPlural(System.String str)
  System.String NicifyMemorySize(System.Int64 numBytes)
  System.Boolean FromNicifiedMemorySize(System.String text, System.Int64& result, System.Int64 defaultMultiplier)
  System.Int32 CountOccurrences(System.String str, System.Char ch)
  System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.Substring> Tokenize(System.String str)
  System.Collections.Generic.IEnumerable<System.String> Split(System.String str, System.Func<System.Char,System.Boolean> predicate)
  System.String Join(System.String separator, TValue[] values)
  System.String Join(System.Collections.Generic.IEnumerable<TValue> values, System.String separator)
  System.String MakeUniqueName(System.String baseName, System.Collections.Generic.IEnumerable<TExisting> existingSet, System.Func<TExisting,System.String> getNameFunc)
  System.Boolean CharacterSeparatedListsHaveAtLeastOneCommonElement(System.String firstList, System.String secondList, System.Char separator)
  System.Int32 ParseInt(System.String str, System.Int32 pos)
  System.Boolean WriteStringToBuffer(System.String text, System.IntPtr buffer, System.Int32 bufferSizeInCharacters)
  System.Boolean WriteStringToBuffer(System.String text, System.IntPtr buffer, System.Int32 bufferSizeInCharacters, System.UInt32& offset)
  System.String ReadStringFromBuffer(System.IntPtr buffer, System.Int32 bufferSize)
  System.String ReadStringFromBuffer(System.IntPtr buffer, System.Int32 bufferSize, System.UInt32& offset)
  System.Boolean IsPrintable(System.Char ch)
  System.String WithAllWhitespaceStripped(System.String str)
  System.Boolean InvariantEqualsIgnoreCase(System.String left, System.String right)
  System.String ExpandTemplateString(System.String template, System.Func<System.String,System.String> mapFunc)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.Substring
TYPE:  struct
TOKEN: 0x200026A
FIELDS:
  private   readonly System.String                   m_String  // 0x10
  private   readonly System.Int32                    m_Index  // 0x18
  private   readonly System.Int32                    m_Length  // 0x1C
METHODS:
  System.Boolean get_isEmpty()
  System.Void .ctor(System.String str)
  System.Void .ctor(System.String str, System.Int32 index, System.Int32 length)
  System.Void .ctor(System.String str, System.Int32 index)
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(System.String other)
  System.Boolean Equals(UnityEngine.InputSystem.Utilities.Substring other)
  System.Boolean Equals(UnityEngine.InputSystem.Utilities.InternedString other)
  System.Int32 CompareTo(UnityEngine.InputSystem.Utilities.Substring other)
  System.Int32 Compare(UnityEngine.InputSystem.Utilities.Substring left, UnityEngine.InputSystem.Utilities.Substring right, System.StringComparison comparison)
  System.Boolean StartsWith(System.String str)
  System.String Substr(System.Int32 index, System.Int32 length)
  System.String ToString()
  System.Int32 GetHashCode()
  System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.Substring a, UnityEngine.InputSystem.Utilities.Substring b)
  System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.Substring a, UnityEngine.InputSystem.Utilities.Substring b)
  System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.Substring a, UnityEngine.InputSystem.Utilities.InternedString b)
  System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.Substring a, UnityEngine.InputSystem.Utilities.InternedString b)
  System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.InternedString a, UnityEngine.InputSystem.Utilities.Substring b)
  System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.InternedString a, UnityEngine.InputSystem.Utilities.Substring b)
  UnityEngine.InputSystem.Utilities.Substring op_Implicit(System.String s)
  System.Int32 get_length()
  System.Int32 get_index()
  System.Char get_Item(System.Int32 index)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.TypeHelpers
TYPE:  class
TOKEN: 0x200026B
FIELDS:
METHODS:
  TObject As(System.Object obj)
  System.Boolean IsInt(System.TypeCode type)
  System.Type GetValueType(System.Reflection.MemberInfo member)
  System.String GetNiceTypeName(System.Type type)
  System.Type GetGenericTypeArgumentFromHierarchy(System.Type type, System.Type genericTypeDefinition, System.Int32 argumentIndex)
END_CLASS

CLASS: UnityEngine.InputSystem.Utilities.TypeTable
TYPE:  struct
TOKEN: 0x200026C
FIELDS:
  public            System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.Type>table  // 0x10
METHODS:
  System.Collections.Generic.IEnumerable<System.String> get_names()
  System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_internedNames()
  System.Void Initialize()
  UnityEngine.InputSystem.Utilities.InternedString FindNameForType(System.Type type)
  System.Void AddTypeRegistration(System.String name, System.Type type)
  System.Type LookupTypeRegistration(System.String name)
END_CLASS

CLASS: UnityEngine.InputSystem.XInput.IXboxOneRumble
TYPE:  interface
TOKEN: 0x20000FC
FIELDS:
METHODS:
  System.Void SetMotorSpeeds(System.Single lowFrequency, System.Single highFrequency, System.Single leftTrigger, System.Single rightTrigger)
END_CLASS

CLASS: UnityEngine.InputSystem.XInput.XInputController
TYPE:  class
TOKEN: 0x20000FD
EXTENDS: Gamepad
FIELDS:
  private           UnityEngine.InputSystem.Controls.ButtonControl<menu>k__BackingField  // 0x210
  private           UnityEngine.InputSystem.Controls.ButtonControl<view>k__BackingField  // 0x218
  private           System.Boolean                  m_HaveParsedCapabilities  // 0x220
  private           UnityEngine.InputSystem.XInput.XInputController.DeviceSubTypem_SubType  // 0x224
  private           UnityEngine.InputSystem.XInput.XInputController.DeviceFlagsm_Flags  // 0x228
METHODS:
  UnityEngine.InputSystem.Controls.ButtonControl get_menu()
  System.Void set_menu(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_view()
  System.Void set_view(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.XInput.XInputController.DeviceSubType get_subType()
  UnityEngine.InputSystem.XInput.XInputController.DeviceFlags get_flags()
  System.Void FinishSetup()
  System.Void ParseCapabilities()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.XInput.XInputControllerWindows
TYPE:  class
TOKEN: 0x2000102
EXTENDS: XInputController
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.XInput.XInputSupport
TYPE:  class
TOKEN: 0x2000103
FIELDS:
METHODS:
  System.Void Initialize()
END_CLASS

CLASS: UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState
TYPE:  struct
TOKEN: 0x2000104
FIELDS:
  public            System.UInt16                   buttons  // 0x10
  public            System.Byte                     leftTrigger  // 0x12
  public            System.Byte                     rightTrigger  // 0x13
  public            System.Int16                    leftStickX  // 0x14
  public            System.Int16                    leftStickY  // 0x16
  public            System.Int16                    rightStickX  // 0x18
  public            System.Int16                    rightStickY  // 0x1A
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_format()
  UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState WithButton(UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.Button button)
END_CLASS

CLASS: UnityEngine.InputSystem.XR.PoseState
TYPE:  struct
TOKEN: 0x20000DF
FIELDS:
  private   static  System.Int32                    kSizeInBytes  // 0x0
  private   static readonly UnityEngine.InputSystem.Utilities.FourCCs_Format  // 0x0
  public            System.Boolean                  isTracked  // 0x10
  public            UnityEngine.XR.InputTrackingStatetrackingState  // 0x14
  public            UnityEngine.Vector3             position  // 0x18
  public            UnityEngine.Quaternion          rotation  // 0x24
  public            UnityEngine.Vector3             velocity  // 0x34
  public            UnityEngine.Vector3             angularVelocity  // 0x40
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_format()
  System.Void .ctor(System.Boolean isTracked, UnityEngine.XR.InputTrackingState trackingState, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 velocity, UnityEngine.Vector3 angularVelocity)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.XR.PoseControl
TYPE:  class
TOKEN: 0x20000E0
EXTENDS: InputControl`1
FIELDS:
  private           UnityEngine.InputSystem.Controls.ButtonControl<isTracked>k__BackingField  // 0x178
  private           UnityEngine.InputSystem.Controls.IntegerControl<trackingState>k__BackingField  // 0x180
  private           UnityEngine.InputSystem.Controls.Vector3Control<position>k__BackingField  // 0x188
  private           UnityEngine.InputSystem.Controls.QuaternionControl<rotation>k__BackingField  // 0x190
  private           UnityEngine.InputSystem.Controls.Vector3Control<velocity>k__BackingField  // 0x198
  private           UnityEngine.InputSystem.Controls.Vector3Control<angularVelocity>k__BackingField  // 0x1A0
METHODS:
  UnityEngine.InputSystem.Controls.ButtonControl get_isTracked()
  System.Void set_isTracked(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.IntegerControl get_trackingState()
  System.Void set_trackingState(UnityEngine.InputSystem.Controls.IntegerControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_position()
  System.Void set_position(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.QuaternionControl get_rotation()
  System.Void set_rotation(UnityEngine.InputSystem.Controls.QuaternionControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_velocity()
  System.Void set_velocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_angularVelocity()
  System.Void set_angularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  System.Void .ctor()
  System.Void FinishSetup()
  UnityEngine.InputSystem.XR.PoseState ReadUnprocessedValueFromState(System.Void* statePtr)
  System.Void WriteValueIntoState(UnityEngine.InputSystem.XR.PoseState value, System.Void* statePtr)
  UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType()
END_CLASS

CLASS: UnityEngine.InputSystem.XR.XRHMD
TYPE:  class
TOKEN: 0x20000E1
EXTENDS: TrackedDevice
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector3Control<leftEyePosition>k__BackingField  // 0x1B0
  private           UnityEngine.InputSystem.Controls.QuaternionControl<leftEyeRotation>k__BackingField  // 0x1B8
  private           UnityEngine.InputSystem.Controls.Vector3Control<rightEyePosition>k__BackingField  // 0x1C0
  private           UnityEngine.InputSystem.Controls.QuaternionControl<rightEyeRotation>k__BackingField  // 0x1C8
  private           UnityEngine.InputSystem.Controls.Vector3Control<centerEyePosition>k__BackingField  // 0x1D0
  private           UnityEngine.InputSystem.Controls.QuaternionControl<centerEyeRotation>k__BackingField  // 0x1D8
METHODS:
  UnityEngine.InputSystem.Controls.Vector3Control get_leftEyePosition()
  System.Void set_leftEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.QuaternionControl get_leftEyeRotation()
  System.Void set_leftEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_rightEyePosition()
  System.Void set_rightEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.QuaternionControl get_rightEyeRotation()
  System.Void set_rightEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_centerEyePosition()
  System.Void set_centerEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.QuaternionControl get_centerEyeRotation()
  System.Void set_centerEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.XR.XRController
TYPE:  class
TOKEN: 0x20000E2
EXTENDS: TrackedDevice
FIELDS:
METHODS:
  UnityEngine.InputSystem.XR.XRController get_leftHand()
  UnityEngine.InputSystem.XR.XRController get_rightHand()
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.XR.XRControllerWithRumble
TYPE:  class
TOKEN: 0x20000E3
EXTENDS: XRController
FIELDS:
METHODS:
  System.Void SendImpulse(System.Single amplitude, System.Single duration)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.XR.TrackedPoseDriver
TYPE:  class
TOKEN: 0x20000E4
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingTypem_TrackingType  // 0x18
  private           UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateTypem_UpdateType  // 0x1C
  private           System.Boolean                  m_IgnoreTrackingState  // 0x20
  private           UnityEngine.InputSystem.InputActionPropertym_PositionInput  // 0x28
  private           UnityEngine.InputSystem.InputActionPropertym_RotationInput  // 0x40
  private           UnityEngine.InputSystem.InputActionPropertym_TrackingStateInput  // 0x58
  private           UnityEngine.Vector3             m_CurrentPosition  // 0x70
  private           UnityEngine.Quaternion          m_CurrentRotation  // 0x7C
  private           UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingStatesm_CurrentTrackingState  // 0x8C
  private           System.Boolean                  m_RotationBound  // 0x90
  private           System.Boolean                  m_PositionBound  // 0x91
  private           System.Boolean                  m_TrackingStateBound  // 0x92
  private           System.Boolean                  m_IsFirstUpdate  // 0x93
  private           UnityEngine.InputSystem.InputActionm_PositionAction  // 0x98
  private           UnityEngine.InputSystem.InputActionm_RotationAction  // 0xA0
METHODS:
  UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType get_trackingType()
  System.Void set_trackingType(UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType value)
  UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType get_updateType()
  System.Void set_updateType(UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType value)
  System.Boolean get_ignoreTrackingState()
  System.Void set_ignoreTrackingState(System.Boolean value)
  UnityEngine.InputSystem.InputActionProperty get_positionInput()
  System.Void set_positionInput(UnityEngine.InputSystem.InputActionProperty value)
  UnityEngine.InputSystem.InputActionProperty get_rotationInput()
  System.Void set_rotationInput(UnityEngine.InputSystem.InputActionProperty value)
  UnityEngine.InputSystem.InputActionProperty get_trackingStateInput()
  System.Void set_trackingStateInput(UnityEngine.InputSystem.InputActionProperty value)
  System.Void BindActions()
  System.Void UnbindActions()
  System.Void BindPosition()
  System.Void BindRotation()
  System.Void BindTrackingState()
  System.Void RenameAndEnable(UnityEngine.InputSystem.InputAction action, System.String name)
  System.Void UnbindPosition()
  System.Void UnbindRotation()
  System.Void UnbindTrackingState()
  System.Void OnPositionPerformed(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnPositionCanceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnRotationPerformed(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnRotationCanceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnTrackingStatePerformed(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void OnTrackingStateCanceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
  System.Void Reset()
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void UpdateCallback()
  System.Void ReadTrackingState(System.Boolean hasResolvedPositionInputControl, System.Boolean hasResolvedRotationInputControl)
  System.Void OnUpdate()
  System.Void OnBeforeRender()
  System.Void PerformUpdate()
  System.Void SetLocalTransform(UnityEngine.Vector3 newPosition, UnityEngine.Quaternion newRotation)
  System.Boolean HasStereoCamera(UnityEngine.Camera& cameraComponent)
  System.Boolean HasResolvedControl(UnityEngine.InputSystem.InputAction action)
  UnityEngine.InputSystem.InputAction get_positionAction()
  System.Void set_positionAction(UnityEngine.InputSystem.InputAction value)
  UnityEngine.InputSystem.InputAction get_rotationAction()
  System.Void set_rotationAction(UnityEngine.InputSystem.InputAction value)
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.XR.XRLayoutBuilder
TYPE:  class
TOKEN: 0x20000E8
FIELDS:
  private           System.String                   parentLayout  // 0x10
  private           System.String                   interfaceName  // 0x18
  private           UnityEngine.InputSystem.XR.XRDeviceDescriptordescriptor  // 0x20
  private   static readonly System.String[]                 poseSubControlNames  // 0x0
  private   static readonly UnityEngine.InputSystem.XR.FeatureType[]poseSubControlTypes  // 0x8
METHODS:
  System.UInt32 GetSizeOfFeature(UnityEngine.InputSystem.XR.XRFeatureDescriptor featureDescriptor)
  System.String SanitizeString(System.String original, System.Boolean allowPaths)
  System.String OnFindLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription& description, System.String matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeCommandDelegate)
  System.String ConvertPotentialAliasToName(UnityEngine.InputSystem.Layouts.InputControlLayout layout, System.String nameOrAlias)
  System.Boolean IsSubControl(System.String name)
  System.String GetParentControlName(System.String name)
  System.Boolean IsPoseControl(System.Collections.Generic.List<UnityEngine.InputSystem.XR.XRFeatureDescriptor> features, System.Int32 startIndex)
  UnityEngine.InputSystem.Layouts.InputControlLayout Build()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.InputSystem.XR.XRUtilities
TYPE:  class
TOKEN: 0x20000EA
FIELDS:
  public    static  System.String                   InterfaceMatchAnyVersion  // 0x0
  public    static  System.String                   InterfaceV1  // 0x0
  public    static  System.String                   InterfaceCurrent  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.XR.FeatureType
TYPE:  struct
TOKEN: 0x20000EB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.InputSystem.XR.FeatureTypeCustom  // 0x0
  public    static  UnityEngine.InputSystem.XR.FeatureTypeBinary  // 0x0
  public    static  UnityEngine.InputSystem.XR.FeatureTypeDiscreteStates  // 0x0
  public    static  UnityEngine.InputSystem.XR.FeatureTypeAxis1D  // 0x0
  public    static  UnityEngine.InputSystem.XR.FeatureTypeAxis2D  // 0x0
  public    static  UnityEngine.InputSystem.XR.FeatureTypeAxis3D  // 0x0
  public    static  UnityEngine.InputSystem.XR.FeatureTypeRotation  // 0x0
  public    static  UnityEngine.InputSystem.XR.FeatureTypeHand  // 0x0
  public    static  UnityEngine.InputSystem.XR.FeatureTypeBone  // 0x0
  public    static  UnityEngine.InputSystem.XR.FeatureTypeEyes  // 0x0
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.XR.UsageHint
TYPE:  struct
TOKEN: 0x20000EC
FIELDS:
  public            System.String                   content  // 0x10
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.XR.XRFeatureDescriptor
TYPE:  struct
TOKEN: 0x20000ED
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Collections.Generic.List<UnityEngine.InputSystem.XR.UsageHint>usageHints  // 0x18
  public            UnityEngine.InputSystem.XR.FeatureTypefeatureType  // 0x20
  public            System.UInt32                   customSize  // 0x24
METHODS:
END_CLASS

CLASS: UnityEngine.InputSystem.XR.XRDeviceDescriptor
TYPE:  class
TOKEN: 0x20000EE
FIELDS:
  public            System.String                   deviceName  // 0x10
  public            System.String                   manufacturer  // 0x18
  public            System.String                   serialNumber  // 0x20
  public            UnityEngine.XR.InputDeviceCharacteristicscharacteristics  // 0x28
  public            System.Int32                    deviceId  // 0x2C
  public            System.Collections.Generic.List<UnityEngine.InputSystem.XR.XRFeatureDescriptor>inputFeatures  // 0x30
METHODS:
  System.String ToJson()
  UnityEngine.InputSystem.XR.XRDeviceDescriptor FromJson(System.String json)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.XR.Bone
TYPE:  struct
TOKEN: 0x20000EF
FIELDS:
  public            System.UInt32                   m_ParentBoneIndex  // 0x10
  public            UnityEngine.Vector3             m_Position  // 0x14
  public            UnityEngine.Quaternion          m_Rotation  // 0x20
METHODS:
  System.UInt32 get_parentBoneIndex()
  System.Void set_parentBoneIndex(System.UInt32 value)
  UnityEngine.Vector3 get_position()
  System.Void set_position(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_rotation()
  System.Void set_rotation(UnityEngine.Quaternion value)
END_CLASS

CLASS: UnityEngine.InputSystem.XR.Eyes
TYPE:  struct
TOKEN: 0x20000F0
FIELDS:
  public            UnityEngine.Vector3             m_LeftEyePosition  // 0x10
  public            UnityEngine.Quaternion          m_LeftEyeRotation  // 0x1C
  public            UnityEngine.Vector3             m_RightEyePosition  // 0x2C
  public            UnityEngine.Quaternion          m_RightEyeRotation  // 0x38
  public            UnityEngine.Vector3             m_FixationPoint  // 0x48
  public            System.Single                   m_LeftEyeOpenAmount  // 0x54
  public            System.Single                   m_RightEyeOpenAmount  // 0x58
METHODS:
  UnityEngine.Vector3 get_leftEyePosition()
  System.Void set_leftEyePosition(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_leftEyeRotation()
  System.Void set_leftEyeRotation(UnityEngine.Quaternion value)
  UnityEngine.Vector3 get_rightEyePosition()
  System.Void set_rightEyePosition(UnityEngine.Vector3 value)
  UnityEngine.Quaternion get_rightEyeRotation()
  System.Void set_rightEyeRotation(UnityEngine.Quaternion value)
  UnityEngine.Vector3 get_fixationPoint()
  System.Void set_fixationPoint(UnityEngine.Vector3 value)
  System.Single get_leftEyeOpenAmount()
  System.Void set_leftEyeOpenAmount(System.Single value)
  System.Single get_rightEyeOpenAmount()
  System.Void set_rightEyeOpenAmount(System.Single value)
END_CLASS

CLASS: UnityEngine.InputSystem.XR.BoneControl
TYPE:  class
TOKEN: 0x20000F1
EXTENDS: InputControl`1
FIELDS:
  private           UnityEngine.InputSystem.Controls.IntegerControl<parentBoneIndex>k__BackingField  // 0x140
  private           UnityEngine.InputSystem.Controls.Vector3Control<position>k__BackingField  // 0x148
  private           UnityEngine.InputSystem.Controls.QuaternionControl<rotation>k__BackingField  // 0x150
METHODS:
  UnityEngine.InputSystem.Controls.IntegerControl get_parentBoneIndex()
  System.Void set_parentBoneIndex(UnityEngine.InputSystem.Controls.IntegerControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_position()
  System.Void set_position(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.QuaternionControl get_rotation()
  System.Void set_rotation(UnityEngine.InputSystem.Controls.QuaternionControl value)
  System.Void FinishSetup()
  UnityEngine.InputSystem.XR.Bone ReadUnprocessedValueFromState(System.Void* statePtr)
  System.Void WriteValueIntoState(UnityEngine.InputSystem.XR.Bone value, System.Void* statePtr)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.XR.EyesControl
TYPE:  class
TOKEN: 0x20000F2
EXTENDS: InputControl`1
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector3Control<leftEyePosition>k__BackingField  // 0x198
  private           UnityEngine.InputSystem.Controls.QuaternionControl<leftEyeRotation>k__BackingField  // 0x1A0
  private           UnityEngine.InputSystem.Controls.Vector3Control<rightEyePosition>k__BackingField  // 0x1A8
  private           UnityEngine.InputSystem.Controls.QuaternionControl<rightEyeRotation>k__BackingField  // 0x1B0
  private           UnityEngine.InputSystem.Controls.Vector3Control<fixationPoint>k__BackingField  // 0x1B8
  private           UnityEngine.InputSystem.Controls.AxisControl<leftEyeOpenAmount>k__BackingField  // 0x1C0
  private           UnityEngine.InputSystem.Controls.AxisControl<rightEyeOpenAmount>k__BackingField  // 0x1C8
METHODS:
  UnityEngine.InputSystem.Controls.Vector3Control get_leftEyePosition()
  System.Void set_leftEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.QuaternionControl get_leftEyeRotation()
  System.Void set_leftEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_rightEyePosition()
  System.Void set_rightEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.QuaternionControl get_rightEyeRotation()
  System.Void set_rightEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_fixationPoint()
  System.Void set_fixationPoint(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.AxisControl get_leftEyeOpenAmount()
  System.Void set_leftEyeOpenAmount(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_rightEyeOpenAmount()
  System.Void set_rightEyeOpenAmount(UnityEngine.InputSystem.Controls.AxisControl value)
  System.Void FinishSetup()
  UnityEngine.InputSystem.XR.Eyes ReadUnprocessedValueFromState(System.Void* statePtr)
  System.Void WriteValueIntoState(UnityEngine.InputSystem.XR.Eyes value, System.Void* statePtr)
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.InputSystem.XR.XRSupport
TYPE:  class
TOKEN: 0x20000F3
FIELDS:
METHODS:
  System.Void Initialize()
END_CLASS

CLASS: UnityEngine.InputSystem.XR.Haptics.BufferedRumble
TYPE:  struct
TOKEN: 0x20000F4
FIELDS:
  private           UnityEngine.InputSystem.XR.Haptics.HapticCapabilities<capabilities>k__BackingField  // 0x10
  private           UnityEngine.InputSystem.InputDevice<device>k__BackingField  // 0x28
METHODS:
  UnityEngine.InputSystem.XR.Haptics.HapticCapabilities get_capabilities()
  System.Void set_capabilities(UnityEngine.InputSystem.XR.Haptics.HapticCapabilities value)
  UnityEngine.InputSystem.InputDevice get_device()
  System.Void set_device(UnityEngine.InputSystem.InputDevice value)
  System.Void .ctor(UnityEngine.InputSystem.InputDevice device)
  System.Void EnqueueRumble(System.Byte[] samples)
END_CLASS

CLASS: UnityEngine.InputSystem.XR.Haptics.HapticState
TYPE:  struct
TOKEN: 0x20000F5
FIELDS:
  private           System.UInt32                   <samplesQueued>k__BackingField  // 0x10
  private           System.UInt32                   <samplesAvailable>k__BackingField  // 0x14
METHODS:
  System.Void .ctor(System.UInt32 samplesQueued, System.UInt32 samplesAvailable)
  System.UInt32 get_samplesQueued()
  System.Void set_samplesQueued(System.UInt32 value)
  System.UInt32 get_samplesAvailable()
  System.Void set_samplesAvailable(System.UInt32 value)
END_CLASS

CLASS: UnityEngine.InputSystem.XR.Haptics.GetCurrentHapticStateCommand
TYPE:  struct
TOKEN: 0x20000F6
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  private           UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            System.UInt32                   samplesQueued  // 0x18
  public            System.UInt32                   samplesAvailable  // 0x1C
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.XR.Haptics.HapticState get_currentState()
  UnityEngine.InputSystem.XR.Haptics.GetCurrentHapticStateCommand Create()
END_CLASS

CLASS: UnityEngine.InputSystem.XR.Haptics.HapticCapabilities
TYPE:  struct
TOKEN: 0x20000F7
FIELDS:
  private   readonly System.UInt32                   <numChannels>k__BackingField  // 0x10
  private   readonly System.Boolean                  <supportsImpulse>k__BackingField  // 0x14
  private   readonly System.Boolean                  <supportsBuffer>k__BackingField  // 0x15
  private   readonly System.UInt32                   <frequencyHz>k__BackingField  // 0x18
  private   readonly System.UInt32                   <maxBufferSize>k__BackingField  // 0x1C
  private   readonly System.UInt32                   <optimalBufferSize>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.UInt32 numChannels, System.Boolean supportsImpulse, System.Boolean supportsBuffer, System.UInt32 frequencyHz, System.UInt32 maxBufferSize, System.UInt32 optimalBufferSize)
  System.Void .ctor(System.UInt32 numChannels, System.UInt32 frequencyHz, System.UInt32 maxBufferSize)
  System.UInt32 get_numChannels()
  System.Boolean get_supportsImpulse()
  System.Boolean get_supportsBuffer()
  System.UInt32 get_frequencyHz()
  System.UInt32 get_maxBufferSize()
  System.UInt32 get_optimalBufferSize()
END_CLASS

CLASS: UnityEngine.InputSystem.XR.Haptics.GetHapticCapabilitiesCommand
TYPE:  struct
TOKEN: 0x20000F8
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  private           UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  public            System.UInt32                   numChannels  // 0x18
  public            System.Boolean                  supportsImpulse  // 0x1C
  public            System.Boolean                  supportsBuffer  // 0x1D
  public            System.UInt32                   frequencyHz  // 0x20
  public            System.UInt32                   maxBufferSize  // 0x24
  public            System.UInt32                   optimalBufferSize  // 0x28
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.XR.Haptics.HapticCapabilities get_capabilities()
  UnityEngine.InputSystem.XR.Haptics.GetHapticCapabilitiesCommand Create()
END_CLASS

CLASS: UnityEngine.InputSystem.XR.Haptics.SendBufferedHapticCommand
TYPE:  struct
TOKEN: 0x20000F9
FIELDS:
  private   static  System.Int32                    kMaxHapticBufferSize  // 0x0
  private   static  System.Int32                    kSize  // 0x0
  private           UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  private           System.Int32                    channel  // 0x18
  private           System.Int32                    bufferSize  // 0x1C
  private           UnityEngine.InputSystem.XR.Haptics.SendBufferedHapticCommand.<buffer>e__FixedBufferbuffer  // 0x20
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.XR.Haptics.SendBufferedHapticCommand Create(System.Byte[] rumbleBuffer)
END_CLASS

CLASS: UnityEngine.InputSystem.XR.Haptics.SendHapticImpulseCommand
TYPE:  struct
TOKEN: 0x20000FB
FIELDS:
  private   static  System.Int32                    kSize  // 0x0
  private           UnityEngine.InputSystem.LowLevel.InputDeviceCommandbaseCommand  // 0x10
  private           System.Int32                    channel  // 0x18
  private           System.Single                   amplitude  // 0x1C
  private           System.Single                   duration  // 0x20
METHODS:
  UnityEngine.InputSystem.Utilities.FourCC get_Type()
  UnityEngine.InputSystem.Utilities.FourCC get_typeStatic()
  UnityEngine.InputSystem.XR.Haptics.SendHapticImpulseCommand Create(System.Int32 motorChannel, System.Single motorAmplitude, System.Single motorDuration)
END_CLASS

CLASS: UnityEngine.XR.WindowsMR.Input.WMRHMD
TYPE:  class
TOKEN: 0x2000012
EXTENDS: XRHMD
FIELDS:
  private           UnityEngine.InputSystem.Controls.ButtonControl<userPresence>k__BackingField  // 0x1E0
METHODS:
  UnityEngine.InputSystem.Controls.ButtonControl get_userPresence()
  System.Void set_userPresence(UnityEngine.InputSystem.Controls.ButtonControl value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.XR.WindowsMR.Input.HololensHand
TYPE:  class
TOKEN: 0x2000013
EXTENDS: XRController
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceVelocity>k__BackingField  // 0x1B0
  private           UnityEngine.InputSystem.Controls.ButtonControl<airTap>k__BackingField  // 0x1B8
  private           UnityEngine.InputSystem.Controls.AxisControl<sourceLossRisk>k__BackingField  // 0x1C0
  private           UnityEngine.InputSystem.Controls.Vector3Control<sourceLossMitigationDirection>k__BackingField  // 0x1C8
METHODS:
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity()
  System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.ButtonControl get_airTap()
  System.Void set_airTap(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_sourceLossRisk()
  System.Void set_sourceLossRisk(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_sourceLossMitigationDirection()
  System.Void set_sourceLossMitigationDirection(UnityEngine.InputSystem.Controls.Vector3Control value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

CLASS: UnityEngine.XR.WindowsMR.Input.WMRSpatialController
TYPE:  class
TOKEN: 0x2000014
EXTENDS: XRControllerWithRumble
FIELDS:
  private           UnityEngine.InputSystem.Controls.Vector2Control<joystick>k__BackingField  // 0x1B0
  private           UnityEngine.InputSystem.Controls.Vector2Control<touchpad>k__BackingField  // 0x1B8
  private           UnityEngine.InputSystem.Controls.AxisControl<grip>k__BackingField  // 0x1C0
  private           UnityEngine.InputSystem.Controls.ButtonControl<gripPressed>k__BackingField  // 0x1C8
  private           UnityEngine.InputSystem.Controls.ButtonControl<menu>k__BackingField  // 0x1D0
  private           UnityEngine.InputSystem.Controls.AxisControl<trigger>k__BackingField  // 0x1D8
  private           UnityEngine.InputSystem.Controls.ButtonControl<triggerPressed>k__BackingField  // 0x1E0
  private           UnityEngine.InputSystem.Controls.ButtonControl<joystickClicked>k__BackingField  // 0x1E8
  private           UnityEngine.InputSystem.Controls.ButtonControl<touchpadClicked>k__BackingField  // 0x1F0
  private           UnityEngine.InputSystem.Controls.ButtonControl<touchpadTouched>k__BackingField  // 0x1F8
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceVelocity>k__BackingField  // 0x200
  private           UnityEngine.InputSystem.Controls.Vector3Control<deviceAngularVelocity>k__BackingField  // 0x208
  private           UnityEngine.InputSystem.Controls.AxisControl<batteryLevel>k__BackingField  // 0x210
  private           UnityEngine.InputSystem.Controls.AxisControl<sourceLossRisk>k__BackingField  // 0x218
  private           UnityEngine.InputSystem.Controls.Vector3Control<sourceLossMitigationDirection>k__BackingField  // 0x220
  private           UnityEngine.InputSystem.Controls.Vector3Control<pointerPosition>k__BackingField  // 0x228
  private           UnityEngine.InputSystem.Controls.QuaternionControl<pointerRotation>k__BackingField  // 0x230
METHODS:
  UnityEngine.InputSystem.Controls.Vector2Control get_joystick()
  System.Void set_joystick(UnityEngine.InputSystem.Controls.Vector2Control value)
  UnityEngine.InputSystem.Controls.Vector2Control get_touchpad()
  System.Void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value)
  UnityEngine.InputSystem.Controls.AxisControl get_grip()
  System.Void set_grip(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed()
  System.Void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_menu()
  System.Void set_menu(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_trigger()
  System.Void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed()
  System.Void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_joystickClicked()
  System.Void set_joystickClicked(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_touchpadClicked()
  System.Void set_touchpadClicked(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.ButtonControl get_touchpadTouched()
  System.Void set_touchpadTouched(UnityEngine.InputSystem.Controls.ButtonControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity()
  System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity()
  System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.AxisControl get_batteryLevel()
  System.Void set_batteryLevel(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.AxisControl get_sourceLossRisk()
  System.Void set_sourceLossRisk(UnityEngine.InputSystem.Controls.AxisControl value)
  UnityEngine.InputSystem.Controls.Vector3Control get_sourceLossMitigationDirection()
  System.Void set_sourceLossMitigationDirection(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.Vector3Control get_pointerPosition()
  System.Void set_pointerPosition(UnityEngine.InputSystem.Controls.Vector3Control value)
  UnityEngine.InputSystem.Controls.QuaternionControl get_pointerRotation()
  System.Void set_pointerRotation(UnityEngine.InputSystem.Controls.QuaternionControl value)
  System.Void FinishSetup()
  System.Void .ctor()
END_CLASS

