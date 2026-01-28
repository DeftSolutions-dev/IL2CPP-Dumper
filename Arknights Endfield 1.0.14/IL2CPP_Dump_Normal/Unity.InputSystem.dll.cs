// ========================================================
// Dumped by @desirepro
// Assembly: Unity.InputSystem.dll
// Classes:  647
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class UISupport
    {
        // Methods
        private System.Void Initialize() { }

    }

    // TypeToken: 0x200001B
    public struct ActionFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputAction.ActionFlags WantsInitialStateCheck;        // 0x0

    }

    // TypeToken: 0x200001C
    public struct CallbackContext
    {
        // Fields
        private UnityEngine.InputSystem.InputActionState m_State;        // 0x10
        private System.Int32 m_ActionIndex;        // 0x18

        // Methods
        private System.Int32 get_actionIndex() { }
        private System.Int32 get_bindingIndex() { }
        private System.Int32 get_controlIndex() { }
        private System.Int32 get_interactionIndex() { }
        private UnityEngine.InputSystem.InputActionPhase get_phase() { }
        private System.Boolean get_started() { }
        private System.Boolean get_performed() { }
        private System.Boolean get_canceled() { }
        private UnityEngine.InputSystem.InputAction get_action() { }
        private UnityEngine.InputSystem.InputControl get_control() { }
        private UnityEngine.InputSystem.IInputInteraction get_interaction() { }
        private System.Double get_time() { }
        private System.Double get_startTime() { }
        private System.Double get_duration() { }
        private System.Type get_valueType() { }
        private System.Int32 get_valueSizeInBytes() { }
        private System.Void ReadValue(System.Void* buffer, System.Int32 bufferSize) { }
        private TValue ReadValue() { }
        private System.Boolean ReadValueAsButton() { }
        private System.Object ReadValueAsObject() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200001E
    public struct WriteFileJson
    {
        // Fields
        public System.String name;        // 0x10
        public UnityEngine.InputSystem.InputActionMap.WriteMapJson[] maps;        // 0x18
        public UnityEngine.InputSystem.InputControlScheme.SchemeJson[] controlSchemes;        // 0x20

    }

    // TypeToken: 0x200001F
    public struct WriteFileJsonNoName
    {
        // Fields
        public UnityEngine.InputSystem.InputActionMap.WriteMapJson[] maps;        // 0x10
        public UnityEngine.InputSystem.InputControlScheme.SchemeJson[] controlSchemes;        // 0x18

    }

    // TypeToken: 0x2000020
    public struct ReadFileJson
    {
        // Fields
        public System.String name;        // 0x10
        public UnityEngine.InputSystem.InputActionMap.ReadMapJson[] maps;        // 0x18
        public UnityEngine.InputSystem.InputControlScheme.SchemeJson[] controlSchemes;        // 0x20

        // Methods
        private System.Void ToAsset(UnityEngine.InputSystem.InputActionAsset asset) { }

    }

    // TypeToken: 0x2000025
    public struct Flags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputActionMap.Flags NeedToResolveBindings;        // 0x0
        public static UnityEngine.InputSystem.InputActionMap.Flags BindingResolutionNeedsFullReResolve;        // 0x0
        public static UnityEngine.InputSystem.InputActionMap.Flags ControlsForEachActionInitialized;        // 0x0
        public static UnityEngine.InputSystem.InputActionMap.Flags BindingsForEachActionInitialized;        // 0x0

    }

    // TypeToken: 0x2000026
    public struct DeviceArray
    {
        // Fields
        private System.Boolean m_HaveValue;        // 0x10
        private System.Int32 m_DeviceCount;        // 0x14
        private UnityEngine.InputSystem.InputDevice[] m_DeviceArray;        // 0x18

        // Methods
        private System.Int32 IndexOf(UnityEngine.InputSystem.InputDevice device) { }
        private System.Boolean Remove(UnityEngine.InputSystem.InputDevice device) { }
        private System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> Get() { }
        private System.Boolean Set(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> devices) { }

    }

    // TypeToken: 0x2000027
    public struct BindingOverrideListJson
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.InputSystem.InputActionMap.BindingOverrideJson> bindings;        // 0x10

    }

    // TypeToken: 0x2000028
    public struct BindingOverrideJson
    {
        // Fields
        public System.String action;        // 0x10
        public System.String id;        // 0x18
        public System.String path;        // 0x20
        public System.String interactions;        // 0x28
        public System.String processors;        // 0x30

        // Methods
        private UnityEngine.InputSystem.InputActionMap.BindingOverrideJson FromBinding(UnityEngine.InputSystem.InputBinding binding, System.String actionName) { }
        private UnityEngine.InputSystem.InputActionMap.BindingOverrideJson FromBinding(UnityEngine.InputSystem.InputBinding binding) { }
        private UnityEngine.InputSystem.InputBinding ToBinding(UnityEngine.InputSystem.InputActionMap.BindingOverrideJson bindingOverride) { }

    }

    // TypeToken: 0x2000029
    public struct BindingJson
    {
        // Fields
        public System.String name;        // 0x10
        public System.String id;        // 0x18
        public System.String path;        // 0x20
        public System.String interactions;        // 0x28
        public System.String processors;        // 0x30
        public System.String groups;        // 0x38
        public System.String action;        // 0x40
        public System.Boolean isComposite;        // 0x48
        public System.Boolean isPartOfComposite;        // 0x49

        // Methods
        private UnityEngine.InputSystem.InputBinding ToBinding() { }
        private UnityEngine.InputSystem.InputActionMap.BindingJson FromBinding(UnityEngine.InputSystem.InputBinding& binding) { }

    }

    // TypeToken: 0x200002A
    public struct ReadActionJson
    {
        // Fields
        public System.String name;        // 0x10
        public System.String type;        // 0x18
        public System.String id;        // 0x20
        public System.String expectedControlType;        // 0x28
        public System.String expectedControlLayout;        // 0x30
        public System.String processors;        // 0x38
        public System.String interactions;        // 0x40
        public System.Boolean passThrough;        // 0x48
        public System.Boolean initialStateCheck;        // 0x49
        public UnityEngine.InputSystem.InputActionMap.BindingJson[] bindings;        // 0x50

        // Methods
        private UnityEngine.InputSystem.InputAction ToAction(System.String actionName) { }

    }

    // TypeToken: 0x200002B
    public struct WriteActionJson
    {
        // Fields
        public System.String name;        // 0x10
        public System.String type;        // 0x18
        public System.String id;        // 0x20
        public System.String expectedControlType;        // 0x28
        public System.String processors;        // 0x30
        public System.String interactions;        // 0x38
        public System.Boolean initialStateCheck;        // 0x40

        // Methods
        private UnityEngine.InputSystem.InputActionMap.WriteActionJson FromAction(UnityEngine.InputSystem.InputAction action) { }

    }

    // TypeToken: 0x200002C
    public struct ReadMapJson
    {
        // Fields
        public System.String name;        // 0x10
        public System.String id;        // 0x18
        public UnityEngine.InputSystem.InputActionMap.ReadActionJson[] actions;        // 0x20
        public UnityEngine.InputSystem.InputActionMap.BindingJson[] bindings;        // 0x28

    }

    // TypeToken: 0x200002D
    public struct WriteMapJson
    {
        // Fields
        public System.String name;        // 0x10
        public System.String id;        // 0x18
        public UnityEngine.InputSystem.InputActionMap.WriteActionJson[] actions;        // 0x20
        public UnityEngine.InputSystem.InputActionMap.BindingJson[] bindings;        // 0x28

        // Methods
        private UnityEngine.InputSystem.InputActionMap.WriteMapJson FromMap(UnityEngine.InputSystem.InputActionMap map) { }

    }

    // TypeToken: 0x200002E
    public struct WriteFileJson
    {
        // Fields
        public UnityEngine.InputSystem.InputActionMap.WriteMapJson[] maps;        // 0x10

        // Methods
        private UnityEngine.InputSystem.InputActionMap.WriteFileJson FromMap(UnityEngine.InputSystem.InputActionMap map) { }
        private UnityEngine.InputSystem.InputActionMap.WriteFileJson FromMaps(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionMap> maps) { }

    }

    // TypeToken: 0x200002F
    public struct ReadFileJson
    {
        // Fields
        public UnityEngine.InputSystem.InputActionMap.ReadActionJson[] actions;        // 0x10
        public UnityEngine.InputSystem.InputActionMap.ReadMapJson[] maps;        // 0x18

        // Methods
        private UnityEngine.InputSystem.InputActionMap[] ToMaps() { }

    }

    // TypeToken: 0x2000031
    public struct Parameter
    {
        // Fields
        public System.Object instance;        // 0x10
        public System.Reflection.FieldInfo field;        // 0x18
        public System.Int32 bindingIndex;        // 0x20

    }

    // TypeToken: 0x2000032
    public struct ParameterEnumerable, IEnumerable`1, IEnumerable
    {
        // Fields
        private UnityEngine.InputSystem.InputActionState m_State;        // 0x10
        private UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride m_Parameter;        // 0x18
        private System.Int32 m_MapIndex;        // 0x90

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.InputActionState state, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameter, System.Int32 mapIndex) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterEnumerator GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000033
    public struct ParameterEnumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private UnityEngine.InputSystem.InputActionState m_State;        // 0x10
        private System.Int32 m_MapIndex;        // 0x18
        private System.Int32 m_BindingCurrentIndex;        // 0x1C
        private System.Int32 m_BindingEndIndex;        // 0x20
        private System.Int32 m_InteractionCurrentIndex;        // 0x24
        private System.Int32 m_InteractionEndIndex;        // 0x28
        private System.Int32 m_ProcessorCurrentIndex;        // 0x2C
        private System.Int32 m_ProcessorEndIndex;        // 0x30
        private UnityEngine.InputSystem.InputBinding m_BindingMask;        // 0x38
        private System.Type m_ObjectType;        // 0x90
        private System.String m_ParameterName;        // 0x98
        private System.Boolean m_MayBeInteraction;        // 0xA0
        private System.Boolean m_MayBeProcessor;        // 0xA1
        private System.Boolean m_MayBeComposite;        // 0xA2
        private System.Boolean m_CurrentBindingIsComposite;        // 0xA3
        private System.Object m_CurrentObject;        // 0xA8
        private System.Reflection.FieldInfo m_CurrentParameter;        // 0xB0

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.InputActionState state, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameter, System.Int32 mapIndex) { }
        private System.Boolean MoveToNextBinding() { }
        private System.Boolean MoveToNextInteraction() { }
        private System.Boolean MoveToNextProcessor() { }
        private System.Boolean FindParameter(System.Object instance) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000034
    public struct ParameterOverride
    {
        // Fields
        public System.String objectRegistrationName;        // 0x10
        public System.String parameter;        // 0x18
        public UnityEngine.InputSystem.InputBinding bindingMask;        // 0x20
        public UnityEngine.InputSystem.Utilities.PrimitiveValue value;        // 0x78

        // Methods
        private System.Type get_objectType() { }
        private System.Void .ctor(System.String parameterName, UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.Utilities.PrimitiveValue value) { }
        private System.Void .ctor(System.String objectRegistrationName, System.String parameterName, UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.Utilities.PrimitiveValue value) { }
        private System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> Find(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding& binding, System.String parameterName, System.String objectRegistrationName) { }
        private System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> Find(UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[] overrides, System.Int32 overrideCount, UnityEngine.InputSystem.InputBinding& binding, System.String parameterName, System.String objectRegistrationName) { }
        private System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> PickMoreSpecificOne(System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> first, System.Nullable<UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride> second) { }

    }

    // TypeToken: 0x2000036
    public struct Flags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.Flags Started;        // 0x0
        public static UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.Flags Completed;        // 0x0
        public static UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.Flags Canceled;        // 0x0
        public static UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.Flags OnEventHooked;        // 0x0
        public static UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.Flags OnAfterUpdateHooked;        // 0x0
        public static UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.Flags DontIgnoreNoisyControls;        // 0x0
        public static UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.Flags DontGeneralizePathOfSelectedControl;        // 0x0
        public static UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.Flags AddNewBinding;        // 0x0
        public static UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.Flags SuppressMatchingEvents;        // 0x0

    }

    // TypeToken: 0x2000035
    public class RebindingOperation, IDisposable
    {
        // Fields
        public static System.Single kDefaultMagnitudeThreshold;        // 0x0
        private UnityEngine.InputSystem.InputAction m_ActionToRebind;        // 0x10
        private System.Nullable<UnityEngine.InputSystem.InputBinding> m_BindingMask;        // 0x18
        private System.Type m_ControlType;        // 0x78
        private UnityEngine.InputSystem.Utilities.InternedString m_ExpectedLayout;        // 0x80
        private System.Int32 m_IncludePathCount;        // 0x90
        private System.String[] m_IncludePaths;        // 0x98
        private System.Int32 m_ExcludePathCount;        // 0xA0
        private System.String[] m_ExcludePaths;        // 0xA8
        private System.Int32 m_TargetBindingIndex;        // 0xB0
        private System.String m_BindingGroupForNewBinding;        // 0xB8
        private System.String m_CancelBinding;        // 0xC0
        private System.Single m_MagnitudeThreshold;        // 0xC8
        private System.Single[] m_Scores;        // 0xD0
        private System.Single[] m_Magnitudes;        // 0xD8
        private System.Double m_LastMatchTime;        // 0xE0
        private System.Double m_StartTime;        // 0xE8
        private System.Single m_Timeout;        // 0xF0
        private System.Single m_WaitSecondsAfterMatch;        // 0xF4
        private UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> m_Candidates;        // 0xF8
        private System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> m_OnComplete;        // 0x118
        private System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> m_OnCancel;        // 0x120
        private System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> m_OnPotentialMatch;        // 0x128
        private System.Func<UnityEngine.InputSystem.InputControl,System.String> m_OnGeneratePath;        // 0x130
        private System.Func<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Single> m_OnComputeScore;        // 0x138
        private System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation,System.String> m_OnApplyBinding;        // 0x140
        private System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> m_OnEventDelegate;        // 0x148
        private System.Action m_OnAfterUpdateDelegate;        // 0x150
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Cache m_LayoutCache;        // 0x158
        private System.Text.StringBuilder m_PathBuilder;        // 0x160
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.Flags m_Flags;        // 0x168
        private System.Collections.Generic.Dictionary<UnityEngine.InputSystem.InputControl,System.Single> m_StartingActuations;        // 0x170

        // Methods
        private UnityEngine.InputSystem.InputAction get_action() { }
        private System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }
        private UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> get_candidates() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.Single> get_scores() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.Single> get_magnitudes() { }
        private UnityEngine.InputSystem.InputControl get_selectedControl() { }
        private System.Boolean get_started() { }
        private System.Boolean get_completed() { }
        private System.Boolean get_canceled() { }
        private System.Double get_startTime() { }
        private System.Single get_timeout() { }
        private System.String get_expectedControlType() { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithAction(UnityEngine.InputSystem.InputAction action) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithMatchingEventsBeingSuppressed(System.Boolean value) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithCancelingThrough(System.String binding) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithCancelingThrough(UnityEngine.InputSystem.InputControl control) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithExpectedControlType(System.String layoutName) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithExpectedControlType(System.Type type) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithExpectedControlType() { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithTargetBinding(System.Int32 bindingIndex) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithBindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> bindingMask) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithBindingGroup(System.String group) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithoutGeneralizingPathOfSelectedControl() { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithRebindAddingNewBinding(System.String group) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithMagnitudeHavingToBeGreaterThan(System.Single magnitude) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithoutIgnoringNoisyControls() { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithControlsHavingToMatchPath(System.String path) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithControlsExcluding(System.String path) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithTimeout(System.Single timeInSeconds) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnComplete(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnCancel(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnPotentialMatch(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnGeneratePath(System.Func<UnityEngine.InputSystem.InputControl,System.String> callback) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnComputeScore(System.Func<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Single> callback) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnApplyBinding(System.Action<UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation,System.String> callback) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnMatchWaitForAnother(System.Single seconds) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation Start() { }
        private System.Void Cancel() { }
        private System.Void Complete() { }
        private System.Void AddCandidate(UnityEngine.InputSystem.InputControl control, System.Single score, System.Single magnitude) { }
        private System.Void RemoveCandidate(UnityEngine.InputSystem.InputControl control) { }
        private System.Void Dispose() { }
        private System.Void Finalize() { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation Reset() { }
        private System.Void HookOnEvent() { }
        private System.Void UnhookOnEvent() { }
        private System.Void OnEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device) { }
        private System.Void SortCandidatesByScore() { }
        private System.Boolean HavePathMatch(UnityEngine.InputSystem.InputControl control, System.String[] paths, System.Int32 pathCount) { }
        private System.Void HookOnAfterUpdate() { }
        private System.Void UnhookOnAfterUpdate() { }
        private System.Void OnAfterUpdate() { }
        private System.Void OnComplete() { }
        private System.Void OnCancel() { }
        private System.Void ResetAfterMatchCompleted() { }
        private System.Void ThrowIfRebindInProgress() { }
        private System.String GeneratePathForControl(UnityEngine.InputSystem.InputControl control) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000038
    public class DeferBindingResolutionWrapper, IDisposable
    {
        // Methods
        private System.Void Acquire() { }
        private System.Void Dispose() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003E
    public struct BindingSyntax
    {
        // Fields
        private readonly UnityEngine.InputSystem.InputActionMap m_ActionMap;        // 0x10
        private readonly UnityEngine.InputSystem.InputAction m_Action;        // 0x18
        private readonly System.Int32 m_BindingIndexInMap;        // 0x20

        // Methods
        private System.Boolean get_valid() { }
        private System.Int32 get_bindingIndex() { }
        private UnityEngine.InputSystem.InputBinding get_binding() { }
        private System.Void .ctor(UnityEngine.InputSystem.InputActionMap map, System.Int32 bindingIndexInMap, UnityEngine.InputSystem.InputAction action) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithName(System.String name) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithPath(System.String path) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithGroup(System.String group) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithGroups(System.String groups) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithInteraction(System.String interaction) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithInteractions(System.String interactions) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithInteraction() { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithProcessor(System.String processor) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithProcessors(System.String processors) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax WithProcessor() { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax Triggering(UnityEngine.InputSystem.InputAction action) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax To(UnityEngine.InputSystem.InputBinding binding) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax NextBinding() { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax PreviousBinding() { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax NextPartBinding(System.String partName) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax PreviousPartBinding(System.String partName) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax NextCompositeBinding(System.String compositeName) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax PreviousCompositeBinding(System.String compositeName) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax Iterate(System.Boolean next) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax IterateCompositeBinding(System.Boolean next, System.String compositeName) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax IteratePartBinding(System.Boolean next, System.String partName) { }
        private System.Void Erase() { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax InsertPartBinding(System.String partName, System.String path) { }

    }

    // TypeToken: 0x200003F
    public struct CompositeSyntax
    {
        // Fields
        private readonly UnityEngine.InputSystem.InputAction m_Action;        // 0x10
        private readonly UnityEngine.InputSystem.InputActionMap m_ActionMap;        // 0x18
        private System.Int32 m_BindingIndexInMap;        // 0x20

        // Methods
        private System.Int32 get_bindingIndex() { }
        private System.Void .ctor(UnityEngine.InputSystem.InputActionMap map, UnityEngine.InputSystem.InputAction action, System.Int32 compositeIndex) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.CompositeSyntax With(System.String name, System.String binding, System.String groups, System.String processors) { }

    }

    // TypeToken: 0x2000040
    public struct ControlSchemeSyntax
    {
        // Fields
        private readonly UnityEngine.InputSystem.InputActionAsset m_Asset;        // 0x10
        private readonly System.Int32 m_ControlSchemeIndex;        // 0x18
        private UnityEngine.InputSystem.InputControlScheme m_ControlScheme;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.InputActionAsset asset, System.Int32 index) { }
        private System.Void .ctor(UnityEngine.InputSystem.InputControlScheme controlScheme) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithBindingGroup(System.String bindingGroup) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithRequiredDevice() { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithOptionalDevice() { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithRequiredDevice() { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithOptionalDevice() { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithRequiredDevice(System.String controlPath) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax WithOptionalDevice(System.String controlPath) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithRequiredDevice(System.String controlPath) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax OrWithOptionalDevice(System.String controlPath) { }
        private System.String DeviceTypeToControlPath() { }
        private UnityEngine.InputSystem.InputControlScheme Done() { }
        private System.Void AddDeviceEntry(System.String controlPath, UnityEngine.InputSystem.InputControlScheme.DeviceRequirement.Flags flags) { }

    }

    // TypeToken: 0x2000044
    public struct Flags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputActionState.InteractionState.Flags TimerRunning;        // 0x0

    }

    // TypeToken: 0x2000043
    public struct InteractionState
    {
        // Fields
        private System.UInt16 m_TriggerControlIndex;        // 0x10
        private System.Byte m_Phase;        // 0x12
        private System.Byte m_Flags;        // 0x13
        private System.Single m_TimerDuration;        // 0x14
        private System.Double m_StartTime;        // 0x18
        private System.Double m_TimerStartTime;        // 0x20
        private System.Double m_PerformedTime;        // 0x28
        private System.Single m_TotalTimeoutCompletionTimeDone;        // 0x30
        private System.Single m_TotalTimeoutCompletionTimeRemaining;        // 0x34
        private System.Int64 m_TimerMonitorIndex;        // 0x38

        // Methods
        private System.Int32 get_triggerControlIndex() { }
        private System.Void set_triggerControlIndex(System.Int32 value) { }
        private System.Double get_startTime() { }
        private System.Void set_startTime(System.Double value) { }
        private System.Double get_performedTime() { }
        private System.Void set_performedTime(System.Double value) { }
        private System.Double get_timerStartTime() { }
        private System.Void set_timerStartTime(System.Double value) { }
        private System.Single get_timerDuration() { }
        private System.Void set_timerDuration(System.Single value) { }
        private System.Single get_totalTimeoutCompletionDone() { }
        private System.Void set_totalTimeoutCompletionDone(System.Single value) { }
        private System.Single get_totalTimeoutCompletionTimeRemaining() { }
        private System.Void set_totalTimeoutCompletionTimeRemaining(System.Single value) { }
        private System.Int64 get_timerMonitorIndex() { }
        private System.Void set_timerMonitorIndex(System.Int64 value) { }
        private System.Boolean get_isTimerRunning() { }
        private System.Void set_isTimerRunning(System.Boolean value) { }
        private UnityEngine.InputSystem.InputActionPhase get_phase() { }
        private System.Void set_phase(UnityEngine.InputSystem.InputActionPhase value) { }

    }

    // TypeToken: 0x2000046
    public struct Flags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputActionState.BindingState.Flags ChainsWithNext;        // 0x0
        public static UnityEngine.InputSystem.InputActionState.BindingState.Flags EndOfChain;        // 0x0
        public static UnityEngine.InputSystem.InputActionState.BindingState.Flags Composite;        // 0x0
        public static UnityEngine.InputSystem.InputActionState.BindingState.Flags PartOfComposite;        // 0x0
        public static UnityEngine.InputSystem.InputActionState.BindingState.Flags InitialStateCheckPending;        // 0x0
        public static UnityEngine.InputSystem.InputActionState.BindingState.Flags WantsInitialStateCheck;        // 0x0

    }

    // TypeToken: 0x2000045
    public struct BindingState
    {
        // Fields
        private System.Byte m_ControlCount;        // 0x10
        private System.Byte m_InteractionCount;        // 0x11
        private System.Byte m_ProcessorCount;        // 0x12
        private System.Byte m_MapIndex;        // 0x13
        private System.Byte m_Flags;        // 0x14
        private System.Byte m_PartIndex;        // 0x15
        private System.UInt16 m_ActionIndex;        // 0x16
        private System.UInt16 m_CompositeOrCompositeBindingIndex;        // 0x18
        private System.UInt16 m_ProcessorStartIndex;        // 0x1A
        private System.UInt16 m_InteractionStartIndex;        // 0x1C
        private System.UInt16 m_ControlStartIndex;        // 0x1E
        private System.Double m_PressTime;        // 0x20
        private System.Int32 m_TriggerEventIdForComposite;        // 0x28
        private System.Int32 __padding;        // 0x2C

        // Methods
        private System.Int32 get_controlStartIndex() { }
        private System.Void set_controlStartIndex(System.Int32 value) { }
        private System.Int32 get_controlCount() { }
        private System.Void set_controlCount(System.Int32 value) { }
        private System.Int32 get_interactionStartIndex() { }
        private System.Void set_interactionStartIndex(System.Int32 value) { }
        private System.Int32 get_interactionCount() { }
        private System.Void set_interactionCount(System.Int32 value) { }
        private System.Int32 get_processorStartIndex() { }
        private System.Void set_processorStartIndex(System.Int32 value) { }
        private System.Int32 get_processorCount() { }
        private System.Void set_processorCount(System.Int32 value) { }
        private System.Int32 get_actionIndex() { }
        private System.Void set_actionIndex(System.Int32 value) { }
        private System.Int32 get_mapIndex() { }
        private System.Void set_mapIndex(System.Int32 value) { }
        private System.Int32 get_compositeOrCompositeBindingIndex() { }
        private System.Void set_compositeOrCompositeBindingIndex(System.Int32 value) { }
        private System.Int32 get_triggerEventIdForComposite() { }
        private System.Void set_triggerEventIdForComposite(System.Int32 value) { }
        private System.Double get_pressTime() { }
        private System.Void set_pressTime(System.Double value) { }
        private UnityEngine.InputSystem.InputActionState.BindingState.Flags get_flags() { }
        private System.Void set_flags(UnityEngine.InputSystem.InputActionState.BindingState.Flags value) { }
        private System.Boolean get_chainsWithNext() { }
        private System.Void set_chainsWithNext(System.Boolean value) { }
        private System.Boolean get_isEndOfChain() { }
        private System.Void set_isEndOfChain(System.Boolean value) { }
        private System.Boolean get_isPartOfChain() { }
        private System.Boolean get_isComposite() { }
        private System.Void set_isComposite(System.Boolean value) { }
        private System.Boolean get_isPartOfComposite() { }
        private System.Void set_isPartOfComposite(System.Boolean value) { }
        private System.Boolean get_initialStateCheckPending() { }
        private System.Void set_initialStateCheckPending(System.Boolean value) { }
        private System.Boolean get_wantsInitialStateCheck() { }
        private System.Void set_wantsInitialStateCheck(System.Boolean value) { }
        private System.Int32 get_partIndex() { }
        private System.Void set_partIndex(System.Int32 value) { }

    }

    // TypeToken: 0x2000048
    public struct Flags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputActionState.TriggerState.Flags HaveMagnitude;        // 0x0
        public static UnityEngine.InputSystem.InputActionState.TriggerState.Flags PassThrough;        // 0x0
        public static UnityEngine.InputSystem.InputActionState.TriggerState.Flags MayNeedConflictResolution;        // 0x0
        public static UnityEngine.InputSystem.InputActionState.TriggerState.Flags HasMultipleConcurrentActuations;        // 0x0
        public static UnityEngine.InputSystem.InputActionState.TriggerState.Flags InProcessing;        // 0x0
        public static UnityEngine.InputSystem.InputActionState.TriggerState.Flags Button;        // 0x0
        public static UnityEngine.InputSystem.InputActionState.TriggerState.Flags Pressed;        // 0x0

    }

    // TypeToken: 0x2000047
    public struct TriggerState
    {
        // Fields
        public static System.Int32 kMaxNumMaps;        // 0x0
        public static System.Int32 kMaxNumControls;        // 0x0
        public static System.Int32 kMaxNumBindings;        // 0x0
        private System.Byte m_Phase;        // 0x10
        private System.Byte m_Flags;        // 0x11
        private System.Byte m_MapIndex;        // 0x12
        private System.UInt16 m_ControlIndex;        // 0x14
        private System.Double m_Time;        // 0x18
        private System.Double m_StartTime;        // 0x20
        private System.UInt16 m_BindingIndex;        // 0x28
        private System.UInt16 m_InteractionIndex;        // 0x2A
        private System.Single m_Magnitude;        // 0x2C
        private System.UInt32 m_LastPerformedInUpdate;        // 0x30
        private System.UInt32 m_LastCanceledInUpdate;        // 0x34
        private System.UInt32 m_PressedInUpdate;        // 0x38
        private System.UInt32 m_ReleasedInUpdate;        // 0x3C
        private System.UInt32 m_LastCompletedInUpdate;        // 0x40
        private System.Int32 framePerformed;        // 0x44
        private System.Int32 framePressed;        // 0x48
        private System.Int32 frameReleased;        // 0x4C
        private System.Int32 frameCompleted;        // 0x50

        // Methods
        private UnityEngine.InputSystem.InputActionPhase get_phase() { }
        private System.Void set_phase(UnityEngine.InputSystem.InputActionPhase value) { }
        private System.Boolean get_isDisabled() { }
        private System.Boolean get_isWaiting() { }
        private System.Boolean get_isStarted() { }
        private System.Boolean get_isPerformed() { }
        private System.Boolean get_isCanceled() { }
        private System.Double get_time() { }
        private System.Void set_time(System.Double value) { }
        private System.Double get_startTime() { }
        private System.Void set_startTime(System.Double value) { }
        private System.Single get_magnitude() { }
        private System.Void set_magnitude(System.Single value) { }
        private System.Boolean get_haveMagnitude() { }
        private System.Int32 get_mapIndex() { }
        private System.Void set_mapIndex(System.Int32 value) { }
        private System.Int32 get_controlIndex() { }
        private System.Void set_controlIndex(System.Int32 value) { }
        private System.Int32 get_bindingIndex() { }
        private System.Void set_bindingIndex(System.Int32 value) { }
        private System.Int32 get_interactionIndex() { }
        private System.Void set_interactionIndex(System.Int32 value) { }
        private System.UInt32 get_lastPerformedInUpdate() { }
        private System.Void set_lastPerformedInUpdate(System.UInt32 value) { }
        private System.UInt32 get_lastCompletedInUpdate() { }
        private System.Void set_lastCompletedInUpdate(System.UInt32 value) { }
        private System.UInt32 get_lastCanceledInUpdate() { }
        private System.Void set_lastCanceledInUpdate(System.UInt32 value) { }
        private System.UInt32 get_pressedInUpdate() { }
        private System.Void set_pressedInUpdate(System.UInt32 value) { }
        private System.UInt32 get_releasedInUpdate() { }
        private System.Void set_releasedInUpdate(System.UInt32 value) { }
        private System.Boolean get_isPassThrough() { }
        private System.Void set_isPassThrough(System.Boolean value) { }
        private System.Boolean get_isButton() { }
        private System.Void set_isButton(System.Boolean value) { }
        private System.Boolean get_isPressed() { }
        private System.Void set_isPressed(System.Boolean value) { }
        private System.Boolean get_mayNeedConflictResolution() { }
        private System.Void set_mayNeedConflictResolution(System.Boolean value) { }
        private System.Boolean get_hasMultipleConcurrentActuations() { }
        private System.Void set_hasMultipleConcurrentActuations(System.Boolean value) { }
        private System.Boolean get_inProcessing() { }
        private System.Void set_inProcessing(System.Boolean value) { }
        private UnityEngine.InputSystem.InputActionState.TriggerState.Flags get_flags() { }
        private System.Void set_flags(UnityEngine.InputSystem.InputActionState.TriggerState.Flags value) { }

    }

    // TypeToken: 0x2000049
    public struct ActionMapIndices
    {
        // Fields
        public System.Int32 actionStartIndex;        // 0x10
        public System.Int32 actionCount;        // 0x14
        public System.Int32 controlStartIndex;        // 0x18
        public System.Int32 controlCount;        // 0x1C
        public System.Int32 bindingStartIndex;        // 0x20
        public System.Int32 bindingCount;        // 0x24
        public System.Int32 interactionStartIndex;        // 0x28
        public System.Int32 interactionCount;        // 0x2C
        public System.Int32 processorStartIndex;        // 0x30
        public System.Int32 processorCount;        // 0x34
        public System.Int32 compositeStartIndex;        // 0x38
        public System.Int32 compositeCount;        // 0x3C

    }

    // TypeToken: 0x200004A
    public struct UnmanagedMemory, IDisposable
    {
        // Fields
        public System.Void* basePtr;        // 0x10
        public System.Int32 mapCount;        // 0x18
        public System.Int32 actionCount;        // 0x1C
        public System.Int32 interactionCount;        // 0x20
        public System.Int32 bindingCount;        // 0x24
        public System.Int32 controlCount;        // 0x28
        public System.Int32 compositeCount;        // 0x2C
        public UnityEngine.InputSystem.InputActionState.TriggerState* actionStates;        // 0x30
        public UnityEngine.InputSystem.InputActionState.BindingState* bindingStates;        // 0x38
        public UnityEngine.InputSystem.InputActionState.InteractionState* interactionStates;        // 0x40
        public System.Single* controlMagnitudes;        // 0x48
        public System.Single* compositeMagnitudes;        // 0x50
        public System.Int32* enabledControls;        // 0x58
        public System.UInt16* actionBindingIndicesAndCounts;        // 0x60
        public System.UInt16* actionBindingIndices;        // 0x68
        public System.Int32* controlIndexToBindingIndex;        // 0x70
        public System.UInt16* controlGroupingAndComplexity;        // 0x78
        public System.Boolean controlGroupingInitialized;        // 0x80
        public UnityEngine.InputSystem.InputActionState.ActionMapIndices* mapIndices;        // 0x88

        // Methods
        private System.Boolean get_isAllocated() { }
        private System.Int32 get_sizeInBytes() { }
        private System.Void Allocate(System.Int32 mapCount, System.Int32 actionCount, System.Int32 bindingCount, System.Int32 controlCount, System.Int32 interactionCount, System.Int32 compositeCount) { }
        private System.Void Dispose() { }
        private System.Void CopyDataFrom(UnityEngine.InputSystem.InputActionState.UnmanagedMemory memory) { }
        private UnityEngine.InputSystem.InputActionState.UnmanagedMemory Clone() { }

    }

    // TypeToken: 0x200004B
    public struct GlobalState
    {
        // Fields
        private UnityEngine.InputSystem.Utilities.InlinedArray<System.Runtime.InteropServices.GCHandle> globalList;        // 0x10
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<System.Object,UnityEngine.InputSystem.InputActionChange>> onActionChange;        // 0x28
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<System.Object>> onActionControlsChanged;        // 0x78

    }

    // TypeToken: 0x200004F
    public struct DisplayStringOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputBinding.DisplayStringOptions DontUseShortDisplayNames;        // 0x0
        public static UnityEngine.InputSystem.InputBinding.DisplayStringOptions DontOmitDevice;        // 0x0
        public static UnityEngine.InputSystem.InputBinding.DisplayStringOptions DontIncludeInteractions;        // 0x0
        public static UnityEngine.InputSystem.InputBinding.DisplayStringOptions IgnoreBindingOverrides;        // 0x0

    }

    // TypeToken: 0x2000050
    public struct MatchOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputBinding.MatchOptions EmptyGroupMatchesAny;        // 0x0

    }

    // TypeToken: 0x2000051
    public struct Flags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputBinding.Flags None;        // 0x0
        public static UnityEngine.InputSystem.InputBinding.Flags Composite;        // 0x0
        public static UnityEngine.InputSystem.InputBinding.Flags PartOfComposite;        // 0x0

    }

    // TypeToken: 0x2000057
    public struct PartBinding
    {
        // Fields
        private System.Int32 <part>k__BackingField;        // 0x10
        private UnityEngine.InputSystem.InputControl <control>k__BackingField;        // 0x18

        // Methods
        private System.Int32 get_part() { }
        private System.Void set_part(System.Int32 value) { }
        private UnityEngine.InputSystem.InputControl get_control() { }
        private System.Void set_control(UnityEngine.InputSystem.InputControl value) { }

    }

    // TypeToken: 0x2000058
    public struct DefaultComparer`1, IComparer`1
    {
        // Methods
        private System.Int32 Compare(TValue x, TValue y) { }

    }

    // TypeToken: 0x200005D
    public struct Result
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputControlScheme.MatchResult.Result AllSatisfied;        // 0x0
        public static UnityEngine.InputSystem.InputControlScheme.MatchResult.Result MissingRequired;        // 0x0
        public static UnityEngine.InputSystem.InputControlScheme.MatchResult.Result MissingOptional;        // 0x0

    }

    // TypeToken: 0x200005E
    public struct Match
    {
        // Fields
        private System.Int32 m_RequirementIndex;        // 0x10
        private UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[] m_Requirements;        // 0x18
        private UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> m_Controls;        // 0x20

        // Methods
        private UnityEngine.InputSystem.InputControl get_control() { }
        private UnityEngine.InputSystem.InputDevice get_device() { }
        private System.Int32 get_requirementIndex() { }
        private UnityEngine.InputSystem.InputControlScheme.DeviceRequirement get_requirement() { }
        private System.Boolean get_isOptional() { }

    }

    // TypeToken: 0x200005F
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private System.Int32 m_Index;        // 0x10
        private UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[] m_Requirements;        // 0x18
        private UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> m_Controls;        // 0x20

        // Methods
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private UnityEngine.InputSystem.InputControlScheme.MatchResult.Match get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200005C
    public struct MatchResult, IEnumerable`1, IEnumerable, IDisposable
    {
        // Fields
        private UnityEngine.InputSystem.InputControlScheme.MatchResult.Result m_Result;        // 0x10
        private System.Single m_Score;        // 0x14
        private UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> m_Devices;        // 0x18
        private UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> m_Controls;        // 0x38
        private UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[] m_Requirements;        // 0x58

        // Methods
        private System.Single get_score() { }
        private System.Boolean get_isSuccessfulMatch() { }
        private System.Boolean get_hasMissingRequiredDevices() { }
        private System.Boolean get_hasMissingOptionalDevices() { }
        private UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> get_devices() { }
        private UnityEngine.InputSystem.InputControlScheme.MatchResult.Match get_Item(System.Int32 index) { }
        private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControlScheme.MatchResult.Match> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000061
    public struct Flags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputControlScheme.DeviceRequirement.Flags None;        // 0x0
        public static UnityEngine.InputSystem.InputControlScheme.DeviceRequirement.Flags Optional;        // 0x0
        public static UnityEngine.InputSystem.InputControlScheme.DeviceRequirement.Flags Or;        // 0x0

    }

    // TypeToken: 0x2000060
    public struct DeviceRequirement, IEquatable`1
    {
        // Fields
        private System.String m_ControlPath;        // 0x10
        private UnityEngine.InputSystem.InputControlScheme.DeviceRequirement.Flags m_Flags;        // 0x18

        // Methods
        private System.String get_controlPath() { }
        private System.Void set_controlPath(System.String value) { }
        private System.Boolean get_isOptional() { }
        private System.Void set_isOptional(System.Boolean value) { }
        private System.Boolean get_isAND() { }
        private System.Void set_isAND(System.Boolean value) { }
        private System.Boolean get_isOR() { }
        private System.Void set_isOR(System.Boolean value) { }
        private System.String ToString() { }
        private System.Boolean Equals(UnityEngine.InputSystem.InputControlScheme.DeviceRequirement other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.InputControlScheme.DeviceRequirement left, UnityEngine.InputSystem.InputControlScheme.DeviceRequirement right) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.InputControlScheme.DeviceRequirement left, UnityEngine.InputSystem.InputControlScheme.DeviceRequirement right) { }

    }

    // TypeToken: 0x2000063
    public struct DeviceJson
    {
        // Fields
        public System.String devicePath;        // 0x10
        public System.Boolean isOptional;        // 0x18
        public System.Boolean isOR;        // 0x19

        // Methods
        private UnityEngine.InputSystem.InputControlScheme.DeviceRequirement ToDeviceEntry() { }
        private UnityEngine.InputSystem.InputControlScheme.SchemeJson.DeviceJson From(UnityEngine.InputSystem.InputControlScheme.DeviceRequirement requirement) { }

    }

    // TypeToken: 0x2000062
    public struct SchemeJson
    {
        // Fields
        public System.String name;        // 0x10
        public System.String bindingGroup;        // 0x18
        public UnityEngine.InputSystem.InputControlScheme.SchemeJson.DeviceJson[] devices;        // 0x20

        // Methods
        private UnityEngine.InputSystem.InputControlScheme ToScheme() { }
        private UnityEngine.InputSystem.InputControlScheme.SchemeJson ToJson(UnityEngine.InputSystem.InputControlScheme scheme) { }
        private UnityEngine.InputSystem.InputControlScheme.SchemeJson[] ToJson(UnityEngine.InputSystem.InputControlScheme[] schemes) { }
        private UnityEngine.InputSystem.InputControlScheme[] ToSchemes(UnityEngine.InputSystem.InputControlScheme.SchemeJson[] schemes) { }

    }

    // TypeToken: 0x2000065
    public struct Flags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputInteractionContext.Flags TimerHasExpired;        // 0x0

    }

    // TypeToken: 0x2000067
    public struct StateEventBuffer
    {
        // Fields
        public UnityEngine.InputSystem.LowLevel.StateEvent stateEvent;        // 0x10
        public static System.Int32 kMaxSize;        // 0x0
        public UnityEngine.InputSystem.InputSystem.StateEventBuffer.<data>e__FixedBuffer data;        // 0x29

    }

    // TypeToken: 0x2000069
    public struct DeltaStateEventBuffer
    {
        // Fields
        public UnityEngine.InputSystem.LowLevel.DeltaStateEvent stateEvent;        // 0x10
        public static System.Int32 kMaxSize;        // 0x0
        public UnityEngine.InputSystem.InputSystem.DeltaStateEventBuffer.<data>e__FixedBuffer data;        // 0x2D

    }

    // TypeToken: 0x200006E
    public struct ControlFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputControl.ControlFlags ConfigUpToDate;        // 0x0
        public static UnityEngine.InputSystem.InputControl.ControlFlags IsNoisy;        // 0x0
        public static UnityEngine.InputSystem.InputControl.ControlFlags IsSynthetic;        // 0x0
        public static UnityEngine.InputSystem.InputControl.ControlFlags IsButton;        // 0x0
        public static UnityEngine.InputSystem.InputControl.ControlFlags DontReset;        // 0x0
        public static UnityEngine.InputSystem.InputControl.ControlFlags SetupFinished;        // 0x0
        public static UnityEngine.InputSystem.InputControl.ControlFlags UsesStateFromOtherControl;        // 0x0

    }

    // TypeToken: 0x2000071
    public struct Enumerate
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputControlExtensions.Enumerate IgnoreControlsInDefaultState;        // 0x0
        public static UnityEngine.InputSystem.InputControlExtensions.Enumerate IgnoreControlsInCurrentState;        // 0x0
        public static UnityEngine.InputSystem.InputControlExtensions.Enumerate IncludeSyntheticControls;        // 0x0
        public static UnityEngine.InputSystem.InputControlExtensions.Enumerate IncludeNoisyControls;        // 0x0
        public static UnityEngine.InputSystem.InputControlExtensions.Enumerate IncludeNonLeafControls;        // 0x0

    }

    // TypeToken: 0x2000072
    public struct InputEventControlCollection, IEnumerable`1, IEnumerable
    {
        // Fields
        private UnityEngine.InputSystem.InputDevice m_Device;        // 0x10
        private UnityEngine.InputSystem.LowLevel.InputEventPtr m_EventPtr;        // 0x18
        private UnityEngine.InputSystem.InputControlExtensions.Enumerate m_Flags;        // 0x20
        private System.Single m_MagnitudeThreshold;        // 0x24

        // Methods
        private UnityEngine.InputSystem.LowLevel.InputEventPtr get_eventPtr() { }
        private UnityEngine.InputSystem.InputControlExtensions.InputEventControlEnumerator GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000073
    public struct InputEventControlEnumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private UnityEngine.InputSystem.InputControlExtensions.Enumerate m_Flags;        // 0x10
        private readonly UnityEngine.InputSystem.InputDevice m_Device;        // 0x18
        private readonly System.UInt32[] m_StateOffsetToControlIndex;        // 0x20
        private readonly System.Int32 m_StateOffsetToControlIndexLength;        // 0x28
        private readonly UnityEngine.InputSystem.InputControl[] m_AllControls;        // 0x30
        private System.Byte* m_DefaultState;        // 0x38
        private System.Byte* m_CurrentState;        // 0x40
        private System.Byte* m_NoiseMask;        // 0x48
        private UnityEngine.InputSystem.LowLevel.InputEventPtr m_EventPtr;        // 0x50
        private UnityEngine.InputSystem.InputControl m_CurrentControl;        // 0x58
        private System.Int32 m_CurrentIndexInStateOffsetToControlIndexMap;        // 0x60
        private System.UInt32 m_CurrentControlStateBitOffset;        // 0x64
        private System.Byte* m_EventState;        // 0x68
        private System.UInt32 m_CurrentBitOffset;        // 0x70
        private System.UInt32 m_EndBitOffset;        // 0x74
        private System.Single m_MagnitudeThreshold;        // 0x78

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputControlExtensions.Enumerate flags, System.Single magnitudeThreshold) { }
        private System.Boolean CheckDefault(System.UInt32 numBits) { }
        private System.Boolean CheckCurrent(System.UInt32 numBits) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private System.Void Dispose() { }
        private UnityEngine.InputSystem.InputControl get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }

    }

    // TypeToken: 0x2000074
    public struct ControlBuilder
    {
        // Fields
        private UnityEngine.InputSystem.InputControl <control>k__BackingField;        // 0x10

        // Methods
        private UnityEngine.InputSystem.InputControl get_control() { }
        private System.Void set_control(UnityEngine.InputSystem.InputControl value) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder At(UnityEngine.InputSystem.InputDevice device, System.Int32 index) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithParent(UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithName(System.String name) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithDisplayName(System.String displayName) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithShortDisplayName(System.String shortDisplayName) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithLayout(UnityEngine.InputSystem.Utilities.InternedString layout) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithUsages(System.Int32 startIndex, System.Int32 count) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithAliases(System.Int32 startIndex, System.Int32 count) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithChildren(System.Int32 startIndex, System.Int32 count) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithStateBlock(UnityEngine.InputSystem.LowLevel.InputStateBlock stateBlock) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithDefaultState(UnityEngine.InputSystem.Utilities.PrimitiveValue value) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithMinAndMax(UnityEngine.InputSystem.Utilities.PrimitiveValue min, UnityEngine.InputSystem.Utilities.PrimitiveValue max) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder WithProcessor(TProcessor processor) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder IsNoisy(System.Boolean value) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder IsSynthetic(System.Boolean value) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder DontReset(System.Boolean value) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder IsButton(System.Boolean value) { }
        private System.Void Finish() { }

    }

    // TypeToken: 0x2000075
    public struct DeviceBuilder
    {
        // Fields
        private UnityEngine.InputSystem.InputDevice <device>k__BackingField;        // 0x10

        // Methods
        private UnityEngine.InputSystem.InputDevice get_device() { }
        private System.Void set_device(UnityEngine.InputSystem.InputDevice value) { }
        private UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithName(System.String name) { }
        private UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithDisplayName(System.String displayName) { }
        private UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithShortDisplayName(System.String shortDisplayName) { }
        private UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithLayout(UnityEngine.InputSystem.Utilities.InternedString layout) { }
        private UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithChildren(System.Int32 startIndex, System.Int32 count) { }
        private UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithStateBlock(UnityEngine.InputSystem.LowLevel.InputStateBlock stateBlock) { }
        private UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder IsNoisy(System.Boolean value) { }
        private UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithControlUsage(System.Int32 controlIndex, UnityEngine.InputSystem.Utilities.InternedString usage, UnityEngine.InputSystem.InputControl control) { }
        private UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithControlAlias(System.Int32 controlIndex, UnityEngine.InputSystem.Utilities.InternedString alias) { }
        private UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithStateOffsetToControlIndexMap(System.UInt32[] map) { }
        private UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder WithControlTree(System.Byte[] controlTreeNodes, System.UInt16[] controlTreeIndicies) { }
        private System.Void Finish() { }

    }

    // TypeToken: 0x2000079
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private readonly System.UInt64* m_Indices;        // 0x0
        private readonly System.Int32 m_Count;        // 0x0
        private System.Int32 m_Current;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.InputControlList<TControl> list) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private TControl get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200007B
    public struct HumanReadableStringOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions None;        // 0x0
        public static UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions OmitDevice;        // 0x0
        public static UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions UseShortNames;        // 0x0

    }

    // TypeToken: 0x200007C
    public struct PathComponentType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputControlPath.PathComponentType Name;        // 0x0
        public static UnityEngine.InputSystem.InputControlPath.PathComponentType DisplayName;        // 0x0
        public static UnityEngine.InputSystem.InputControlPath.PathComponentType Usage;        // 0x0
        public static UnityEngine.InputSystem.InputControlPath.PathComponentType Layout;        // 0x0

    }

    // TypeToken: 0x200007D
    public struct ParsedPathComponent
    {
        // Fields
        private UnityEngine.InputSystem.Utilities.Substring m_Layout;        // 0x10
        private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.Substring> m_Usages;        // 0x20
        private UnityEngine.InputSystem.Utilities.Substring m_Name;        // 0x40
        private UnityEngine.InputSystem.Utilities.Substring m_DisplayName;        // 0x50

        // Methods
        private System.String get_layout() { }
        private System.Collections.Generic.IEnumerable<System.String> get_usages() { }
        private System.String get_name() { }
        private System.String get_displayName() { }
        private System.Boolean get_isWildcard() { }
        private System.Boolean get_isDoubleWildcard() { }
        private System.String ToHumanReadableString(System.String parentLayoutName, System.String parentControlPath, System.String& referencedLayoutName, System.String& controlPath, UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions options) { }
        private System.String ToHumanReadableString(UnityEngine.InputSystem.Utilities.Substring substring) { }
        private System.Boolean Matches(UnityEngine.InputSystem.InputControl control) { }
        private System.Boolean ComparePathElementToString(UnityEngine.InputSystem.Utilities.Substring pathElement, System.String element) { }

    }

    // TypeToken: 0x200007F
    public struct PathParser
    {
        // Fields
        private System.String path;        // 0x10
        private System.Int32 length;        // 0x18
        private System.Int32 leftIndexInPath;        // 0x1C
        private System.Int32 rightIndexInPath;        // 0x20
        public UnityEngine.InputSystem.InputControlPath.ParsedPathComponent current;        // 0x28

        // Methods
        private System.Boolean get_isAtEnd() { }
        private System.Void .ctor(System.String path) { }
        private System.Boolean MoveToNextComponent() { }
        private UnityEngine.InputSystem.Utilities.Substring ParseComponentPart(System.Char terminator) { }

    }

    // TypeToken: 0x2000083
    public struct CachingPolicy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputProcessor.CachingPolicy CacheResult;        // 0x0
        public static UnityEngine.InputSystem.InputProcessor.CachingPolicy EvaluateOnEveryRead;        // 0x0

    }

    // TypeToken: 0x2000087
    public struct DeviceFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputDevice.DeviceFlags UpdateBeforeRender;        // 0x0
        public static UnityEngine.InputSystem.InputDevice.DeviceFlags HasStateCallbacks;        // 0x0
        public static UnityEngine.InputSystem.InputDevice.DeviceFlags HasControlsWithDefaultState;        // 0x0
        public static UnityEngine.InputSystem.InputDevice.DeviceFlags HasDontResetControls;        // 0x0
        public static UnityEngine.InputSystem.InputDevice.DeviceFlags HasEventMerger;        // 0x0
        public static UnityEngine.InputSystem.InputDevice.DeviceFlags HasEventPreProcessor;        // 0x0
        public static UnityEngine.InputSystem.InputDevice.DeviceFlags Remote;        // 0x0
        public static UnityEngine.InputSystem.InputDevice.DeviceFlags Native;        // 0x0
        public static UnityEngine.InputSystem.InputDevice.DeviceFlags DisabledInFrontend;        // 0x0
        public static UnityEngine.InputSystem.InputDevice.DeviceFlags DisabledInRuntime;        // 0x0
        public static UnityEngine.InputSystem.InputDevice.DeviceFlags DisabledWhileInBackground;        // 0x0
        public static UnityEngine.InputSystem.InputDevice.DeviceFlags DisabledStateHasBeenQueriedFromRuntime;        // 0x0
        public static UnityEngine.InputSystem.InputDevice.DeviceFlags CanRunInBackground;        // 0x0
        public static UnityEngine.InputSystem.InputDevice.DeviceFlags CanRunInBackgroundHasBeenQueried;        // 0x0

    }

    // TypeToken: 0x2000088
    public struct ControlBitRangeNode
    {
        // Fields
        public System.UInt16 endBitOffset;        // 0x10
        public System.Int16 leftChildIndex;        // 0x12
        public System.UInt16 controlStartIndex;        // 0x14
        public System.Byte controlCount;        // 0x16

        // Methods
        private System.Void .ctor(System.UInt16 endOffset) { }

    }

    // TypeToken: 0x2000096
    public struct MessageType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputRemoting.MessageType Connect;        // 0x0
        public static UnityEngine.InputSystem.InputRemoting.MessageType Disconnect;        // 0x0
        public static UnityEngine.InputSystem.InputRemoting.MessageType NewLayout;        // 0x0
        public static UnityEngine.InputSystem.InputRemoting.MessageType NewDevice;        // 0x0
        public static UnityEngine.InputSystem.InputRemoting.MessageType NewEvents;        // 0x0
        public static UnityEngine.InputSystem.InputRemoting.MessageType RemoveDevice;        // 0x0
        public static UnityEngine.InputSystem.InputRemoting.MessageType RemoveLayout;        // 0x0
        public static UnityEngine.InputSystem.InputRemoting.MessageType ChangeUsages;        // 0x0
        public static UnityEngine.InputSystem.InputRemoting.MessageType StartSending;        // 0x0
        public static UnityEngine.InputSystem.InputRemoting.MessageType StopSending;        // 0x0

    }

    // TypeToken: 0x2000097
    public struct Message
    {
        // Fields
        public System.Int32 participantId;        // 0x10
        public UnityEngine.InputSystem.InputRemoting.MessageType type;        // 0x14
        public System.Byte[] data;        // 0x18

    }

    // TypeToken: 0x2000098
    public struct Flags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputRemoting.Flags Sending;        // 0x0
        public static UnityEngine.InputSystem.InputRemoting.Flags StartSendingOnConnect;        // 0x0

    }

    // TypeToken: 0x2000099
    public struct RemoteSender
    {
        // Fields
        public System.Int32 senderId;        // 0x10
        public UnityEngine.InputSystem.Utilities.InternedString[] layouts;        // 0x18
        public UnityEngine.InputSystem.InputRemoting.RemoteInputDevice[] devices;        // 0x20

    }

    // TypeToken: 0x200009A
    public struct RemoteInputDevice
    {
        // Fields
        public System.Int32 remoteId;        // 0x10
        public System.Int32 localId;        // 0x14
        public UnityEngine.InputSystem.Layouts.InputDeviceDescription description;        // 0x18

    }

    // TypeToken: 0x200009B
    public class Subscriber, IDisposable
    {
        // Fields
        public UnityEngine.InputSystem.InputRemoting owner;        // 0x10
        public System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer;        // 0x18

        // Methods
        private System.Void Dispose() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009C
    public class ConnectMsg
    {
        // Methods
        private System.Void Process(UnityEngine.InputSystem.InputRemoting receiver) { }

    }

    // TypeToken: 0x200009D
    public class StartSendingMsg
    {
        // Methods
        private System.Void Process(UnityEngine.InputSystem.InputRemoting receiver) { }

    }

    // TypeToken: 0x200009E
    public class StopSendingMsg
    {
        // Methods
        private System.Void Process(UnityEngine.InputSystem.InputRemoting receiver) { }

    }

    // TypeToken: 0x200009F
    public class DisconnectMsg
    {
        // Methods
        private System.Void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg) { }

    }

    // TypeToken: 0x20000A1
    public struct Data
    {
        // Fields
        public System.String name;        // 0x10
        public System.String layoutJson;        // 0x18
        public System.Boolean isOverride;        // 0x20

    }

    // TypeToken: 0x20000A0
    public class NewLayoutMsg
    {
        // Methods
        private System.Nullable<UnityEngine.InputSystem.InputRemoting.Message> Create(UnityEngine.InputSystem.InputRemoting sender, System.String layoutName) { }
        private System.Void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg) { }

    }

    // TypeToken: 0x20000A3
    public struct Data
    {
        // Fields
        public System.String name;        // 0x10
        public System.String layout;        // 0x18
        public System.Int32 deviceId;        // 0x20
        public System.String[] usages;        // 0x28
        public UnityEngine.InputSystem.Layouts.InputDeviceDescription description;        // 0x30

    }

    // TypeToken: 0x20000A2
    public class NewDeviceMsg
    {
        // Methods
        private UnityEngine.InputSystem.InputRemoting.Message Create(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg) { }

    }

    // TypeToken: 0x20000A5
    public class NewEventsMsg
    {
        // Methods
        private UnityEngine.InputSystem.InputRemoting.Message CreateResetEvent(UnityEngine.InputSystem.InputDevice device, System.Boolean isHardReset) { }
        private UnityEngine.InputSystem.InputRemoting.Message CreateStateEvent(UnityEngine.InputSystem.InputDevice device) { }
        private UnityEngine.InputSystem.InputRemoting.Message Create(UnityEngine.InputSystem.LowLevel.InputEvent* events, System.Int32 eventCount) { }
        private System.Void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg) { }

    }

    // TypeToken: 0x20000A7
    public struct Data
    {
        // Fields
        public System.Int32 deviceId;        // 0x10
        public System.String[] usages;        // 0x18

    }

    // TypeToken: 0x20000A6
    public class ChangeUsageMsg
    {
        // Methods
        private UnityEngine.InputSystem.InputRemoting.Message Create(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg) { }

    }

    // TypeToken: 0x20000A9
    public class RemoveDeviceMsg
    {
        // Methods
        private UnityEngine.InputSystem.InputRemoting.Message Create(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void Process(UnityEngine.InputSystem.InputRemoting receiver, UnityEngine.InputSystem.InputRemoting.Message msg) { }

    }

    // TypeToken: 0x20000AB
    public class Subscriber, IDisposable
    {
        // Fields
        public UnityEngine.InputSystem.RemoteInputPlayerConnection owner;        // 0x10
        public System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer;        // 0x18

        // Methods
        private System.Void Dispose() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C0
    public struct DeviceDisableScope
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputManager.DeviceDisableScope Everywhere;        // 0x0
        public static UnityEngine.InputSystem.InputManager.DeviceDisableScope InFrontendOnly;        // 0x0
        public static UnityEngine.InputSystem.InputManager.DeviceDisableScope TemporaryWhilePlayerIsInBackground;        // 0x0

    }

    // TypeToken: 0x20000C1
    public struct AvailableDevice
    {
        // Fields
        public UnityEngine.InputSystem.Layouts.InputDeviceDescription description;        // 0x10
        public System.Int32 deviceId;        // 0x48
        public System.Boolean isNative;        // 0x4C
        public System.Boolean isRemoved;        // 0x4D

    }

    // TypeToken: 0x20000C2
    public struct StateChangeMonitorTimeout
    {
        // Fields
        public UnityEngine.InputSystem.InputControl control;        // 0x10
        public System.Double time;        // 0x18
        public UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor;        // 0x20
        public System.Int64 monitorIndex;        // 0x28
        public System.Int32 timerIndex;        // 0x30

    }

    // TypeToken: 0x20000C3
    public struct StateChangeMonitorListener
    {
        // Fields
        public UnityEngine.InputSystem.InputControl control;        // 0x10
        public UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor;        // 0x18
        public System.Int64 monitorIndex;        // 0x20
        public System.UInt32 groupIndex;        // 0x28

    }

    // TypeToken: 0x20000C4
    public struct StateChangeMonitorsForDevice
    {
        // Fields
        public UnityEngine.InputSystem.Utilities.MemoryHelpers.BitRegion[] memoryRegions;        // 0x10
        public UnityEngine.InputSystem.InputManager.StateChangeMonitorListener[] listeners;        // 0x18
        public UnityEngine.InputSystem.DynamicBitfield signalled;        // 0x20
        public System.Boolean needToUpdateOrderingOfMonitors;        // 0x40
        public System.Boolean needToCompactArrays;        // 0x41

        // Methods
        private System.Int32 get_count() { }
        private System.Void Add(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Int64 monitorIndex, System.UInt32 groupIndex) { }
        private System.Void Remove(UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Int64 monitorIndex, System.Boolean deferRemoval) { }
        private System.Void Clear() { }
        private System.Void CompactArrays() { }
        private System.Void RemoveAt(System.Int32 i) { }
        private System.Void SortMonitorsByIndex() { }

    }

    // TypeToken: 0x20000C9
    public struct UpdateMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputSettings.UpdateMode ProcessEventsInDynamicUpdate;        // 0x0
        public static UnityEngine.InputSystem.InputSettings.UpdateMode ProcessEventsInFixedUpdate;        // 0x0
        public static UnityEngine.InputSystem.InputSettings.UpdateMode ProcessEventsManually;        // 0x0

    }

    // TypeToken: 0x20000CA
    public struct ScrollDeltaBehavior
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior UniformAcrossAllPlatforms;        // 0x0
        public static UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior KeepPlatformSpecificInputRange;        // 0x0

    }

    // TypeToken: 0x20000CB
    public struct BackgroundBehavior
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputSettings.BackgroundBehavior ResetAndDisableNonBackgroundDevices;        // 0x0
        public static UnityEngine.InputSystem.InputSettings.BackgroundBehavior ResetAndDisableAllDevices;        // 0x0
        public static UnityEngine.InputSystem.InputSettings.BackgroundBehavior IgnoreFocus;        // 0x0

    }

    // TypeToken: 0x20000CC
    public struct EditorInputBehaviorInPlayMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode PointersAndKeyboardsRespectGameViewFocus;        // 0x0
        public static UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode AllDevicesRespectGameViewFocus;        // 0x0
        public static UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode AllDeviceInputAlwaysGoesToGameView;        // 0x0

    }

    // TypeToken: 0x20000CD
    public struct InputActionPropertyDrawerMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode Compact;        // 0x0
        public static UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode MultilineEffective;        // 0x0
        public static UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode MultilineBoth;        // 0x0

    }

    // TypeToken: 0x20000CF
    public struct PlayerActions
    {
        // Fields
        private UnityEngine.InputSystem.DefaultInputActions m_Wrapper;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.DefaultInputActions wrapper) { }
        private UnityEngine.InputSystem.InputAction get_Move() { }
        private UnityEngine.InputSystem.InputAction get_Look() { }
        private UnityEngine.InputSystem.InputAction get_Fire() { }
        private UnityEngine.InputSystem.InputActionMap Get() { }
        private System.Void Enable() { }
        private System.Void Disable() { }
        private System.Boolean get_enabled() { }
        private UnityEngine.InputSystem.InputActionMap op_Implicit(UnityEngine.InputSystem.DefaultInputActions.PlayerActions set) { }
        private System.Void SetCallbacks(UnityEngine.InputSystem.DefaultInputActions.IPlayerActions instance) { }

    }

    // TypeToken: 0x20000D0
    public struct UIActions
    {
        // Fields
        private UnityEngine.InputSystem.DefaultInputActions m_Wrapper;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.DefaultInputActions wrapper) { }
        private UnityEngine.InputSystem.InputAction get_Navigate() { }
        private UnityEngine.InputSystem.InputAction get_Submit() { }
        private UnityEngine.InputSystem.InputAction get_Cancel() { }
        private UnityEngine.InputSystem.InputAction get_Point() { }
        private UnityEngine.InputSystem.InputAction get_Click() { }
        private UnityEngine.InputSystem.InputAction get_ScrollWheel() { }
        private UnityEngine.InputSystem.InputAction get_MiddleClick() { }
        private UnityEngine.InputSystem.InputAction get_RightClick() { }
        private UnityEngine.InputSystem.InputAction get_TrackedDevicePosition() { }
        private UnityEngine.InputSystem.InputAction get_TrackedDeviceOrientation() { }
        private UnityEngine.InputSystem.InputActionMap Get() { }
        private System.Void Enable() { }
        private System.Void Disable() { }
        private System.Boolean get_enabled() { }
        private UnityEngine.InputSystem.InputActionMap op_Implicit(UnityEngine.InputSystem.DefaultInputActions.UIActions set) { }
        private System.Void SetCallbacks(UnityEngine.InputSystem.DefaultInputActions.IUIActions instance) { }

    }

    // TypeToken: 0x20000D1
    public interface IPlayerActions
    {
        // Methods
        private System.Void OnMove(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnLook(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnFire(UnityEngine.InputSystem.InputAction.CallbackContext context) { }

    }

    // TypeToken: 0x20000D2
    public interface IUIActions
    {
        // Methods
        private System.Void OnNavigate(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnSubmit(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnCancel(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnPoint(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnClick(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnScrollWheel(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnMiddleClick(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnRightClick(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnTrackedDevicePosition(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnTrackedDeviceOrientation(UnityEngine.InputSystem.InputAction.CallbackContext context) { }

    }

    // TypeToken: 0x20000D5
    public class ActionEvent : UnityEvent`1
    {
        // Fields
        private System.String m_ActionId;        // 0x30
        private System.String m_ActionName;        // 0x38

        // Methods
        private System.String get_actionId() { }
        private System.String get_actionName() { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.InputSystem.InputAction action) { }
        private System.Void .ctor(System.Guid actionGUID, System.String name) { }

    }

    // TypeToken: 0x20000D6
    public class DeviceLostEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D7
    public class DeviceRegainedEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D8
    public class ControlsChangedEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DA
    public class PlayerJoinedEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DB
    public class PlayerLeftEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E5
    public struct TrackingType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType RotationAndPosition;        // 0x0
        public static UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType RotationOnly;        // 0x0
        public static UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType PositionOnly;        // 0x0

    }

    // TypeToken: 0x20000E6
    public struct TrackingStates
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingStates None;        // 0x0
        public static UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingStates Position;        // 0x0
        public static UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingStates Rotation;        // 0x0

    }

    // TypeToken: 0x20000E7
    public struct UpdateType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType UpdateAndBeforeRender;        // 0x0
        public static UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType Update;        // 0x0
        public static UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType BeforeRender;        // 0x0

    }

    // TypeToken: 0x20000FE
    public struct DeviceType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceType Gamepad;        // 0x0

    }

    // TypeToken: 0x20000FF
    public struct DeviceSubType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceSubType Unknown;        // 0x0
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceSubType Gamepad;        // 0x0
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceSubType Wheel;        // 0x0
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceSubType ArcadeStick;        // 0x0
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceSubType FlightStick;        // 0x0
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceSubType DancePad;        // 0x0
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceSubType Guitar;        // 0x0
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceSubType GuitarAlternate;        // 0x0
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceSubType DrumKit;        // 0x0
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceSubType GuitarBass;        // 0x0
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceSubType ArcadePad;        // 0x0

    }

    // TypeToken: 0x2000100
    public struct DeviceFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceFlags ForceFeedbackSupported;        // 0x0
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceFlags Wireless;        // 0x0
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceFlags VoiceSupported;        // 0x0
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceFlags PluginModulesSupported;        // 0x0
        public static UnityEngine.InputSystem.XInput.XInputController.DeviceFlags NoNavigation;        // 0x0

    }

    // TypeToken: 0x2000101
    public struct Capabilities
    {
        // Fields
        public UnityEngine.InputSystem.XInput.XInputController.DeviceType type;        // 0x10
        public UnityEngine.InputSystem.XInput.XInputController.DeviceSubType subType;        // 0x14
        public UnityEngine.InputSystem.XInput.XInputController.DeviceFlags flags;        // 0x18

    }

    // TypeToken: 0x2000105
    public struct Button
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.Button DPadUp;        // 0x0
        public static UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.Button DPadDown;        // 0x0
        public static UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.Button DPadLeft;        // 0x0
        public static UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.Button DPadRight;        // 0x0
        public static UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.Button Start;        // 0x0
        public static UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.Button Select;        // 0x0
        public static UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.Button LeftThumbstickPress;        // 0x0
        public static UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.Button RightThumbstickPress;        // 0x0
        public static UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.Button LeftShoulder;        // 0x0
        public static UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.Button RightShoulder;        // 0x0
        public static UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.Button A;        // 0x0
        public static UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.Button B;        // 0x0
        public static UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.Button X;        // 0x0
        public static UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.Button Y;        // 0x0

    }

    // TypeToken: 0x2000107
    public struct ControlSchemeChangeSyntax
    {
        // Fields
        private System.Int32 m_UserIndex;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Users.InputUser.ControlSchemeChangeSyntax AndPairRemainingDevices() { }

    }

    // TypeToken: 0x2000108
    public struct UserFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Users.InputUser.UserFlags BindToAllDevices;        // 0x0
        public static UnityEngine.InputSystem.Users.InputUser.UserFlags UserAccountSelectionInProgress;        // 0x0

    }

    // TypeToken: 0x2000109
    public struct UserData
    {
        // Fields
        public System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> platformUserAccountHandle;        // 0x10
        public System.String platformUserAccountName;        // 0x28
        public System.String platformUserAccountId;        // 0x30
        public System.Int32 deviceCount;        // 0x38
        public System.Int32 deviceStartIndex;        // 0x3C
        public UnityEngine.InputSystem.IInputActionCollection actions;        // 0x40
        public System.Nullable<UnityEngine.InputSystem.InputControlScheme> controlScheme;        // 0x48
        public UnityEngine.InputSystem.InputControlScheme.MatchResult controlSchemeMatch;        // 0x68
        public System.Int32 lostDeviceCount;        // 0xB8
        public System.Int32 lostDeviceStartIndex;        // 0xBC
        public UnityEngine.InputSystem.Users.InputUser.UserFlags flags;        // 0xC0

    }

    // TypeToken: 0x200010A
    public struct CompareDevicesByUserAccount, IComparer`1
    {
        // Fields
        public UnityEngine.InputSystem.Users.InputUserAccountHandle platformUserAccountHandle;        // 0x10

        // Methods
        private System.Int32 Compare(UnityEngine.InputSystem.InputDevice x, UnityEngine.InputSystem.InputDevice y) { }
        private System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> GetUserAccountHandleForDevice(UnityEngine.InputSystem.InputDevice device) { }

    }

    // TypeToken: 0x200010B
    public struct OngoingAccountSelection
    {
        // Fields
        public UnityEngine.InputSystem.InputDevice device;        // 0x10
        public System.UInt32 userId;        // 0x18

    }

    // TypeToken: 0x200010C
    public struct GlobalState
    {
        // Fields
        private System.Int32 pairingStateVersion;        // 0x10
        private System.UInt32 lastUserId;        // 0x14
        private System.Int32 allUserCount;        // 0x18
        private System.Int32 allPairedDeviceCount;        // 0x1C
        private System.Int32 allLostDeviceCount;        // 0x20
        private UnityEngine.InputSystem.Users.InputUser[] allUsers;        // 0x28
        private UnityEngine.InputSystem.Users.InputUser.UserData[] allUserData;        // 0x30
        private UnityEngine.InputSystem.InputDevice[] allPairedDevices;        // 0x38
        private UnityEngine.InputSystem.InputDevice[] allLostDevices;        // 0x40
        private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Users.InputUser.OngoingAccountSelection> ongoingAccountSelections;        // 0x48
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice>> onChange;        // 0x68
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr>> onUnpairedDeviceUsed;        // 0xB8
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean>> onPreFilterUnpairedDeviceUsed;        // 0x108
        private System.Action<System.Object,UnityEngine.InputSystem.InputActionChange> actionChangeDelegate;        // 0x158
        private System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> onDeviceChangeDelegate;        // 0x160
        private System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> onEventDelegate;        // 0x168
        private System.Boolean onActionChangeHooked;        // 0x170
        private System.Boolean onDeviceChangeHooked;        // 0x171
        private System.Boolean onEventHooked;        // 0x172
        private System.Int32 listenForUnpairedDeviceActivity;        // 0x174

    }

    // TypeToken: 0x200011A
    public struct InputActionReferenceState
    {
        // Fields
        public System.Int32 refCount;        // 0x10
        public System.Boolean enabledByInputModule;        // 0x14

    }

    // TypeToken: 0x200011B
    public struct CursorLockBehavior
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehavior OutsideScreen;        // 0x0
        public static UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehavior ScreenCenter;        // 0x0

    }

    // TypeToken: 0x2000120
    public struct ButtonState
    {
        // Fields
        private System.Boolean m_IsPressed;        // 0x10
        private UnityEngine.EventSystems.PointerEventData.FramePressState m_FramePressState;        // 0x14
        private System.Single m_PressTime;        // 0x18
        private UnityEngine.EventSystems.RaycastResult m_PressRaycast;        // 0x20
        private UnityEngine.GameObject m_PressObject;        // 0x68
        private UnityEngine.GameObject m_RawPressObject;        // 0x70
        private UnityEngine.GameObject m_LastPressObject;        // 0x78
        private UnityEngine.GameObject m_DragObject;        // 0x80
        private UnityEngine.Vector2 m_PressPosition;        // 0x88
        private System.Single m_ClickTime;        // 0x90
        private System.Int32 m_ClickCount;        // 0x94
        private System.Boolean m_Dragging;        // 0x98
        private System.Boolean m_ClickedOnSameGameObject;        // 0x99
        private System.Boolean m_IgnoreNextClick;        // 0x9A

        // Methods
        private System.Boolean get_isPressed() { }
        private System.Void set_isPressed(System.Boolean value) { }
        private System.Boolean get_ignoreNextClick() { }
        private System.Void set_ignoreNextClick(System.Boolean value) { }
        private System.Single get_pressTime() { }
        private System.Void set_pressTime(System.Single value) { }
        private System.Boolean get_clickedOnSameGameObject() { }
        private System.Void set_clickedOnSameGameObject(System.Boolean value) { }
        private System.Boolean get_wasPressedThisFrame() { }
        private System.Boolean get_wasReleasedThisFrame() { }
        private System.Void CopyPressStateTo(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void CopyPressStateFrom(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnEndFrame() { }

    }

    // TypeToken: 0x2000122
    public struct RaycastHitData
    {
        // Fields
        private readonly UnityEngine.UI.Graphic <graphic>k__BackingField;        // 0x10
        private readonly UnityEngine.Vector3 <worldHitPosition>k__BackingField;        // 0x18
        private readonly UnityEngine.Vector2 <screenPosition>k__BackingField;        // 0x24
        private readonly System.Single <distance>k__BackingField;        // 0x2C

        // Methods
        private System.Void .ctor(UnityEngine.UI.Graphic graphic, UnityEngine.Vector3 worldHitPosition, UnityEngine.Vector2 screenPosition, System.Single distance) { }
        private UnityEngine.UI.Graphic get_graphic() { }
        private UnityEngine.Vector3 get_worldHitPosition() { }
        private UnityEngine.Vector2 get_screenPosition() { }
        private System.Single get_distance() { }

    }

    // TypeToken: 0x2000125
    public struct CursorMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode SoftwareCursor;        // 0x0
        public static UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode HardwareCursorIfAvailable;        // 0x0

    }

    // TypeToken: 0x2000127
    public struct SwitchInputOnlyReport
    {
        // Fields
        public static System.Int32 kSize;        // 0x0
        public System.Byte buttons0;        // 0x10
        public System.Byte buttons1;        // 0x11
        public System.Byte hat;        // 0x12
        public System.Byte leftX;        // 0x13
        public System.Byte leftY;        // 0x14
        public System.Byte rightX;        // 0x15
        public System.Byte rightY;        // 0x16

        // Methods
        private UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState ToHIDInputReport() { }

    }

    // TypeToken: 0x2000128
    public struct SwitchSimpleInputReport
    {
        // Fields
        public static System.Int32 kSize;        // 0x0
        public static System.Byte ExpectedReportId;        // 0x0
        public System.Byte reportId;        // 0x10
        public System.Byte buttons0;        // 0x11
        public System.Byte buttons1;        // 0x12
        public System.Byte hat;        // 0x13
        public System.UInt16 leftX;        // 0x14
        public System.UInt16 leftY;        // 0x16
        public System.UInt16 rightX;        // 0x18
        public System.UInt16 rightY;        // 0x1A

        // Methods
        private UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState ToHIDInputReport() { }

    }

    // TypeToken: 0x2000129
    public struct SwitchFullInputReport
    {
        // Fields
        public static System.Int32 kSize;        // 0x0
        public static System.Byte ExpectedReportId;        // 0x0
        public System.Byte reportId;        // 0x10
        public System.Byte buttons0;        // 0x13
        public System.Byte buttons1;        // 0x14
        public System.Byte buttons2;        // 0x15
        public System.Byte left0;        // 0x16
        public System.Byte left1;        // 0x17
        public System.Byte left2;        // 0x18
        public System.Byte right0;        // 0x19
        public System.Byte right1;        // 0x1A
        public System.Byte right2;        // 0x1B

        // Methods
        private UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState ToHIDInputReport() { }

    }

    // TypeToken: 0x200012A
    public struct SwitchHIDGenericInputReport
    {
        // Fields
        public System.Byte reportId;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Format() { }

    }

    // TypeToken: 0x200012C
    public struct ReportType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport.ReportType Magic;        // 0x0

    }

    // TypeToken: 0x200012D
    public struct CommandIdType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport.CommandIdType Status;        // 0x0
        public static UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport.CommandIdType Handshake;        // 0x0
        public static UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport.CommandIdType Highspeed;        // 0x0
        public static UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport.CommandIdType ForceUSB;        // 0x0

    }

    // TypeToken: 0x200012B
    public struct SwitchMagicOutputReport
    {
        // Fields
        public static System.Int32 kSize;        // 0x0
        public static System.Byte ExpectedReplyInputReportId;        // 0x0
        public System.Byte reportType;        // 0x10
        public System.Byte commandId;        // 0x11

    }

    // TypeToken: 0x200012E
    public struct SwitchMagicOutputHIDBluetooth, IInputDeviceCommandInfo
    {
        // Fields
        public static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport report;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputHIDBluetooth Create(UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport.CommandIdType type) { }

    }

    // TypeToken: 0x200012F
    public struct SwitchMagicOutputHIDUSB, IInputDeviceCommandInfo
    {
        // Fields
        public static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport report;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputHIDUSB Create(UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport.CommandIdType type) { }

    }

    // TypeToken: 0x2000132
    public struct Button
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button Up;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button Right;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button Down;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button Left;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button West;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button North;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button South;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button East;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button L;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button R;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button StickL;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button StickR;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button ZL;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button ZR;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button Plus;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button Minus;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button Capture;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button Home;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button X;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button B;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button Y;        // 0x0
        public static UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button A;        // 0x0

    }

    // TypeToken: 0x2000135
    public struct OnScreenDeviceInfo
    {
        // Fields
        public UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr;        // 0x10
        public Unity.Collections.NativeArray<System.Byte> buffer;        // 0x18
        public UnityEngine.InputSystem.InputDevice device;        // 0x28
        public UnityEngine.InputSystem.OnScreen.OnScreenControl firstControl;        // 0x30

        // Methods
        private UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo AddControl(UnityEngine.InputSystem.OnScreen.OnScreenControl control) { }
        private UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo RemoveControl(UnityEngine.InputSystem.OnScreen.OnScreenControl control) { }
        private System.Void Destroy() { }

    }

    // TypeToken: 0x2000138
    public struct Behaviour
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviour RelativePositionWithStaticOrigin;        // 0x0
        public static UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviour ExactPositionWithStaticOrigin;        // 0x0
        public static UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviour ExactPositionWithDynamicOrigin;        // 0x0

    }

    // TypeToken: 0x200013A
    public class HIDLayoutBuilder
    {
        // Fields
        public System.String displayName;        // 0x10
        public UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor hidDescriptor;        // 0x18
        public System.String parentLayout;        // 0x48
        public System.Type deviceType;        // 0x50

        // Methods
        private UnityEngine.InputSystem.Layouts.InputControlLayout Build() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013C
    public struct HIDReportType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.HID.HID.HIDReportType Unknown;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDReportType Input;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDReportType Output;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDReportType Feature;        // 0x0

    }

    // TypeToken: 0x200013D
    public struct HIDCollectionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.HID.HID.HIDCollectionType Physical;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDCollectionType Application;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDCollectionType Logical;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDCollectionType Report;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDCollectionType NamedArray;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDCollectionType UsageSwitch;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDCollectionType UsageModifier;        // 0x0

    }

    // TypeToken: 0x200013E
    public struct HIDElementFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.HID.HID.HIDElementFlags Constant;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDElementFlags Variable;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDElementFlags Relative;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDElementFlags Wrap;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDElementFlags NonLinear;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDElementFlags NoPreferred;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDElementFlags NullState;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDElementFlags Volatile;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.HIDElementFlags BufferedBytes;        // 0x0

    }

    // TypeToken: 0x200013F
    public struct HIDElementDescriptor
    {
        // Fields
        public System.Int32 usage;        // 0x10
        public UnityEngine.InputSystem.HID.HID.UsagePage usagePage;        // 0x14
        public System.Int32 unit;        // 0x18
        public System.Int32 unitExponent;        // 0x1C
        public System.Int32 logicalMin;        // 0x20
        public System.Int32 logicalMax;        // 0x24
        public System.Int32 physicalMin;        // 0x28
        public System.Int32 physicalMax;        // 0x2C
        public UnityEngine.InputSystem.HID.HID.HIDReportType reportType;        // 0x30
        public System.Int32 collectionIndex;        // 0x34
        public System.Int32 reportId;        // 0x38
        public System.Int32 reportSizeInBits;        // 0x3C
        public System.Int32 reportOffsetInBits;        // 0x40
        public UnityEngine.InputSystem.HID.HID.HIDElementFlags flags;        // 0x44
        public System.Nullable<System.Int32> usageMin;        // 0x48
        public System.Nullable<System.Int32> usageMax;        // 0x50

        // Methods
        private System.Boolean get_hasNullState() { }
        private System.Boolean get_hasPreferredState() { }
        private System.Boolean get_isArray() { }
        private System.Boolean get_isNonLinear() { }
        private System.Boolean get_isRelative() { }
        private System.Boolean get_isConstant() { }
        private System.Boolean get_isWrapping() { }
        private System.Boolean get_isSigned() { }
        private System.Single get_minFloatValue() { }
        private System.Single get_maxFloatValue() { }
        private System.Boolean Is(UnityEngine.InputSystem.HID.HID.UsagePage usagePage, System.Int32 usage) { }
        private System.String DetermineName() { }
        private System.String DetermineDisplayName() { }
        private System.Boolean IsUsableElement() { }
        private System.String DetermineLayout() { }
        private UnityEngine.InputSystem.Utilities.FourCC DetermineFormat() { }
        private UnityEngine.InputSystem.Utilities.InternedString[] DetermineUsages() { }
        private System.String DetermineParameters() { }
        private System.String DetermineAxisNormalizationParameters() { }
        private System.String DetermineProcessors() { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue DetermineDefaultState() { }
        private System.Void AddChildControls(UnityEngine.InputSystem.HID.HID.HIDElementDescriptor& element, System.String controlName, UnityEngine.InputSystem.Layouts.InputControlLayout.Builder& builder) { }

    }

    // TypeToken: 0x2000140
    public struct HIDCollectionDescriptor
    {
        // Fields
        public UnityEngine.InputSystem.HID.HID.HIDCollectionType type;        // 0x10
        public System.Int32 usage;        // 0x14
        public UnityEngine.InputSystem.HID.HID.UsagePage usagePage;        // 0x18
        public System.Int32 parent;        // 0x1C
        public System.Int32 childCount;        // 0x20
        public System.Int32 firstChild;        // 0x24

    }

    // TypeToken: 0x2000141
    public struct HIDDeviceDescriptor
    {
        // Fields
        public System.Int32 vendorId;        // 0x10
        public System.Int32 productId;        // 0x14
        public System.Int32 usage;        // 0x18
        public UnityEngine.InputSystem.HID.HID.UsagePage usagePage;        // 0x1C
        public System.Int32 inputReportSize;        // 0x20
        public System.Int32 outputReportSize;        // 0x24
        public System.Int32 featureReportSize;        // 0x28
        public UnityEngine.InputSystem.HID.HID.HIDElementDescriptor[] elements;        // 0x30
        public UnityEngine.InputSystem.HID.HID.HIDCollectionDescriptor[] collections;        // 0x38

        // Methods
        private System.String ToJson() { }
        private UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor FromJson(System.String json) { }

    }

    // TypeToken: 0x2000142
    public struct HIDDeviceDescriptorBuilder
    {
        // Fields
        public UnityEngine.InputSystem.HID.HID.UsagePage usagePage;        // 0x10
        public System.Int32 usage;        // 0x14
        private System.Int32 m_CurrentReportId;        // 0x18
        private UnityEngine.InputSystem.HID.HID.HIDReportType m_CurrentReportType;        // 0x1C
        private System.Int32 m_CurrentReportOffsetInBits;        // 0x20
        private System.Collections.Generic.List<UnityEngine.InputSystem.HID.HID.HIDElementDescriptor> m_Elements;        // 0x28
        private System.Collections.Generic.List<UnityEngine.InputSystem.HID.HID.HIDCollectionDescriptor> m_Collections;        // 0x30
        private System.Int32 m_InputReportSize;        // 0x38
        private System.Int32 m_OutputReportSize;        // 0x3C
        private System.Int32 m_FeatureReportSize;        // 0x40

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.HID.HID.UsagePage usagePage, System.Int32 usage) { }
        private System.Void .ctor(UnityEngine.InputSystem.HID.HID.GenericDesktop usage) { }
        private UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder StartReport(UnityEngine.InputSystem.HID.HID.HIDReportType reportType, System.Int32 reportId) { }
        private UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder AddElement(UnityEngine.InputSystem.HID.HID.UsagePage usagePage, System.Int32 usage, System.Int32 sizeInBits) { }
        private UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder AddElement(UnityEngine.InputSystem.HID.HID.GenericDesktop usage, System.Int32 sizeInBits) { }
        private UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder WithPhysicalMinMax(System.Int32 min, System.Int32 max) { }
        private UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptorBuilder WithLogicalMinMax(System.Int32 min, System.Int32 max) { }
        private UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor Finish() { }

    }

    // TypeToken: 0x2000143
    public struct UsagePage
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.HID.HID.UsagePage Undefined;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage GenericDesktop;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage Simulation;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage VRControls;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage SportControls;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage GameControls;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage GenericDeviceControls;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage Keyboard;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage LEDs;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage Button;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage Ordinal;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage Telephony;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage Consumer;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage Digitizer;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage PID;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage Unicode;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage AlphanumericDisplay;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage MedicalInstruments;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage Monitor;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage Power;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage BarCodeScanner;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage MagneticStripeReader;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage Camera;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage Arcade;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.UsagePage VendorDefined;        // 0x0

    }

    // TypeToken: 0x2000144
    public struct GenericDesktop
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Undefined;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Pointer;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Mouse;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Joystick;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Gamepad;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Keyboard;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Keypad;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop MultiAxisController;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop TabletPCControls;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop AssistiveControl;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop X;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Y;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Z;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Rx;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Ry;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Rz;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Slider;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Dial;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Wheel;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop HatSwitch;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop CountedBuffer;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop ByteCount;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop MotionWakeup;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Start;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Select;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Vx;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Vy;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Vz;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Vbrx;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Vbry;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Vbrz;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop Vno;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop FeatureNotification;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop ResolutionMultiplier;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemControl;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemPowerDown;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemSleep;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemWakeUp;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemContextMenu;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemMainMenu;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemAppMenu;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemMenuHelp;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemMenuExit;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemMenuSelect;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemMenuRight;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemMenuLeft;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemMenuUp;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemMenuDown;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemColdRestart;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemWarmRestart;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop DpadUp;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop DpadDown;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop DpadRight;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop DpadLeft;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemDock;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemUndock;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemSetup;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemBreak;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemDebuggerBreak;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop ApplicationBreak;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop ApplicationDebuggerBreak;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemSpeakerMute;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemHibernate;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemDisplayInvert;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemDisplayInternal;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemDisplayExternal;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemDisplayBoth;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemDisplayDual;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemDisplayToggleIntExt;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemDisplaySwapPrimarySecondary;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.GenericDesktop SystemDisplayLCDAutoScale;        // 0x0

    }

    // TypeToken: 0x2000145
    public struct Simulation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.HID.HID.Simulation Undefined;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation FlightSimulationDevice;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation AutomobileSimulationDevice;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation TankSimulationDevice;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation SpaceshipSimulationDevice;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation SubmarineSimulationDevice;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation SailingSimulationDevice;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation MotorcycleSimulationDevice;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation SportsSimulationDevice;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation AirplaneSimulationDevice;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation HelicopterSimulationDevice;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation MagicCarpetSimulationDevice;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation BicylcleSimulationDevice;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation FlightControlStick;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation FlightStick;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation CyclicControl;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation CyclicTrim;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation FlightYoke;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation TrackControl;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation Aileron;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation AileronTrim;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation AntiTorqueControl;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation AutopilotEnable;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation ChaffRelease;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation CollectiveControl;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation DiveBreak;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation ElectronicCountermeasures;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation Elevator;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation ElevatorTrim;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation Rudder;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation Throttle;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation FlightCommunications;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation FlareRelease;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation LandingGear;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation ToeBreak;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation Trigger;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation WeaponsArm;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation WeaponsSelect;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation WingFlaps;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation Accelerator;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation Brake;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation Clutch;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation Shifter;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation Steering;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation TurretDirection;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation BarrelElevation;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation DivePlane;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation Ballast;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation BicycleCrank;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation HandleBars;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation FrontBrake;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Simulation RearBrake;        // 0x0

    }

    // TypeToken: 0x2000146
    public struct Button
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.HID.HID.Button Undefined;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Button Primary;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Button Secondary;        // 0x0
        public static UnityEngine.InputSystem.HID.HID.Button Tertiary;        // 0x0

    }

    // TypeToken: 0x2000149
    public struct HIDReportData
    {
        // Fields
        public System.Int32 reportId;        // 0x10
        public UnityEngine.InputSystem.HID.HID.HIDReportType reportType;        // 0x14
        public System.Int32 currentBitOffset;        // 0x18

        // Methods
        private System.Int32 FindOrAddReport(System.Nullable<System.Int32> reportId, UnityEngine.InputSystem.HID.HID.HIDReportType reportType, System.Collections.Generic.List<UnityEngine.InputSystem.HID.HIDParser.HIDReportData> reports) { }

    }

    // TypeToken: 0x200014A
    public struct HIDItemTypeAndTag
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag Input;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag Output;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag Feature;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag Collection;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag EndCollection;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag UsagePage;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag LogicalMinimum;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag LogicalMaximum;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag PhysicalMinimum;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag PhysicalMaximum;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag UnitExponent;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag Unit;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag ReportSize;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag ReportID;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag ReportCount;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag Push;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag Pop;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag Usage;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag UsageMinimum;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag UsageMaximum;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag DesignatorIndex;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag DesignatorMinimum;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag DesignatorMaximum;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag StringIndex;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag StringMinimum;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag StringMaximum;        // 0x0
        public static UnityEngine.InputSystem.HID.HIDParser.HIDItemTypeAndTag Delimiter;        // 0x0

    }

    // TypeToken: 0x200014B
    public struct HIDItemStateLocal
    {
        // Fields
        public System.Nullable<System.Int32> usage;        // 0x10
        public System.Nullable<System.Int32> usageMinimum;        // 0x18
        public System.Nullable<System.Int32> usageMaximum;        // 0x20
        public System.Nullable<System.Int32> designatorIndex;        // 0x28
        public System.Nullable<System.Int32> designatorMinimum;        // 0x30
        public System.Nullable<System.Int32> designatorMaximum;        // 0x38
        public System.Nullable<System.Int32> stringIndex;        // 0x40
        public System.Nullable<System.Int32> stringMinimum;        // 0x48
        public System.Nullable<System.Int32> stringMaximum;        // 0x50
        public System.Collections.Generic.List<System.Int32> usageList;        // 0x58

        // Methods
        private System.Void Reset(UnityEngine.InputSystem.HID.HIDParser.HIDItemStateLocal& state) { }
        private System.Void SetUsage(System.Int32 value) { }
        private System.Int32 GetUsage(System.Int32 index) { }

    }

    // TypeToken: 0x200014C
    public struct HIDItemStateGlobal
    {
        // Fields
        public System.Nullable<System.Int32> usagePage;        // 0x10
        public System.Nullable<System.Int32> logicalMinimum;        // 0x18
        public System.Nullable<System.Int32> logicalMaximum;        // 0x20
        public System.Nullable<System.Int32> physicalMinimum;        // 0x28
        public System.Nullable<System.Int32> physicalMaximum;        // 0x30
        public System.Nullable<System.Int32> unitExponent;        // 0x38
        public System.Nullable<System.Int32> unit;        // 0x40
        public System.Nullable<System.Int32> reportSize;        // 0x48
        public System.Nullable<System.Int32> reportCount;        // 0x50
        public System.Nullable<System.Int32> reportId;        // 0x58

        // Methods
        private UnityEngine.InputSystem.HID.HID.UsagePage GetUsagePage(System.Int32 index, UnityEngine.InputSystem.HID.HIDParser.HIDItemStateLocal& localItemState) { }
        private System.Int32 GetPhysicalMin() { }
        private System.Int32 GetPhysicalMax() { }

    }

    // TypeToken: 0x200014E
    public struct HIDPageUsage
    {
        // Fields
        public UnityEngine.InputSystem.HID.HID.UsagePage page;        // 0x10
        public System.Int32 usage;        // 0x14

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.HID.HID.UsagePage page, System.Int32 usage) { }
        private System.Void .ctor(UnityEngine.InputSystem.HID.HID.GenericDesktop usage) { }

    }

    // TypeToken: 0x2000152
    public struct GlobalState
    {
        // Fields
        private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Touchscreen> touchscreens;        // 0x10
        private System.Int32 historyLengthPerFinger;        // 0x28
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger>> onFingerDown;        // 0x30
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger>> onFingerMove;        // 0x80
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger>> onFingerUp;        // 0xD0
        private UnityEngine.InputSystem.EnhancedTouch.Touch.FingerAndTouchState playerState;        // 0x120

    }

    // TypeToken: 0x2000153
    public struct FingerAndTouchState
    {
        // Fields
        public UnityEngine.InputSystem.LowLevel.InputUpdateType updateMask;        // 0x10
        public UnityEngine.InputSystem.EnhancedTouch.Finger[] fingers;        // 0x18
        public UnityEngine.InputSystem.EnhancedTouch.Finger[] activeFingers;        // 0x20
        public UnityEngine.InputSystem.EnhancedTouch.Touch[] activeTouches;        // 0x28
        public System.Int32 activeFingerCount;        // 0x30
        public System.Int32 activeTouchCount;        // 0x34
        public System.Int32 totalFingerCount;        // 0x38
        public System.UInt32 lastId;        // 0x3C
        public System.Boolean haveBuiltActiveTouches;        // 0x40
        public System.Boolean haveActiveTouchesNeedingRefreshNextUpdate;        // 0x41
        public UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> activeTouchState;        // 0x48

        // Methods
        private System.Void AddFingers(UnityEngine.InputSystem.Touchscreen screen) { }
        private System.Void RemoveFingers(UnityEngine.InputSystem.Touchscreen screen) { }
        private System.Void Destroy() { }
        private System.Void UpdateActiveFingers() { }
        private System.Void UpdateActiveTouches() { }

    }

    // TypeToken: 0x2000154
    public struct ExtraDataPerTouchState
    {
        // Fields
        public UnityEngine.Vector2 accumulatedDelta;        // 0x10
        public System.UInt32 uniqueId;        // 0x18

    }

    // TypeToken: 0x2000157
    public class Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private readonly UnityEngine.InputSystem.EnhancedTouch.TouchHistory m_Owner;        // 0x10
        private System.Int32 m_Index;        // 0x30

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.EnhancedTouch.TouchHistory owner) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private UnityEngine.InputSystem.EnhancedTouch.Touch get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200015B
    public struct DualSenseHIDGenericInputReport
    {
        // Fields
        public System.Byte reportId;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Format() { }

    }

    // TypeToken: 0x200015C
    public struct DualSenseHIDUSBInputReport
    {
        // Fields
        public static System.Int32 ExpectedReportId;        // 0x0
        public System.Byte reportId;        // 0x10
        public System.Byte leftStickX;        // 0x11
        public System.Byte leftStickY;        // 0x12
        public System.Byte rightStickX;        // 0x13
        public System.Byte rightStickY;        // 0x14
        public System.Byte leftTrigger;        // 0x15
        public System.Byte rightTrigger;        // 0x16
        public System.Byte buttons0;        // 0x18
        public System.Byte buttons1;        // 0x19
        public System.Byte buttons2;        // 0x1A

        // Methods
        private UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDInputReport ToHIDInputReport() { }

    }

    // TypeToken: 0x200015D
    public struct DualSenseHIDBluetoothInputReport
    {
        // Fields
        public static System.Int32 ExpectedReportId;        // 0x0
        public System.Byte reportId;        // 0x10
        public System.Byte leftStickX;        // 0x12
        public System.Byte leftStickY;        // 0x13
        public System.Byte rightStickX;        // 0x14
        public System.Byte rightStickY;        // 0x15
        public System.Byte leftTrigger;        // 0x16
        public System.Byte rightTrigger;        // 0x17
        public System.Byte buttons0;        // 0x19
        public System.Byte buttons1;        // 0x1A
        public System.Byte buttons2;        // 0x1B

        // Methods
        private UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDInputReport ToHIDInputReport() { }

    }

    // TypeToken: 0x200015E
    public struct DualSenseHIDMinimalInputReport
    {
        // Fields
        public static System.Int32 ExpectedSize1;        // 0x0
        public static System.Int32 ExpectedSize2;        // 0x4
        public System.Byte reportId;        // 0x10
        public System.Byte leftStickX;        // 0x11
        public System.Byte leftStickY;        // 0x12
        public System.Byte rightStickX;        // 0x13
        public System.Byte rightStickY;        // 0x14
        public System.Byte buttons0;        // 0x15
        public System.Byte buttons1;        // 0x16
        public System.Byte buttons2;        // 0x17
        public System.Byte leftTrigger;        // 0x18
        public System.Byte rightTrigger;        // 0x19

        // Methods
        private UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDInputReport ToHIDInputReport() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000160
    public struct DualShock4HIDGenericInputReport
    {
        // Fields
        public System.Byte leftStickX;        // 0x10
        public System.Byte leftStickY;        // 0x11
        public System.Byte rightStickX;        // 0x12
        public System.Byte rightStickY;        // 0x13
        public System.Byte buttons0;        // 0x14
        public System.Byte buttons1;        // 0x15
        public System.Byte buttons2;        // 0x16
        public System.Byte leftTrigger;        // 0x17
        public System.Byte rightTrigger;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Format() { }
        private UnityEngine.InputSystem.DualShock.LowLevel.DualShock4HIDInputReport ToHIDInputReport() { }

    }

    // TypeToken: 0x200016D
    public struct Flags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.DualShock.LowLevel.DualShockHIDOutputReport.Flags Rumble;        // 0x0
        public static UnityEngine.InputSystem.DualShock.LowLevel.DualShockHIDOutputReport.Flags Color;        // 0x0

    }

    // TypeToken: 0x2000179
    public struct Result
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.LowLevel.InitiateUserAccountPairingCommand.Result SuccessfullyInitiated;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.InitiateUserAccountPairingCommand.Result ErrorNotSupported;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.InitiateUserAccountPairingCommand.Result ErrorAlreadyInProgress;        // 0x0

    }

    // TypeToken: 0x2000185
    public struct Result
    {
        // Fields
        public System.Int64 value__;        // 0x10
        public static UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand.Result DevicePairedToUserAccount;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand.Result UserAccountSelectionInProgress;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand.Result UserAccountSelectionComplete;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand.Result UserAccountSelectionCanceled;        // 0x0

    }

    // TypeToken: 0x2000199
    public struct Button
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.LowLevel.JoystickState.Button HatSwitchUp;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.JoystickState.Button HatSwitchDown;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.JoystickState.Button HatSwitchLeft;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.JoystickState.Button HatSwitchRight;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.JoystickState.Button Trigger;        // 0x0

    }

    // TypeToken: 0x20001B4
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private UnityEngine.InputSystem.LowLevel.IMECompositionString m_CompositionString;        // 0x10
        private System.Char m_CurrentCharacter;        // 0x94
        private System.Int32 m_CurrentIndex;        // 0x98

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.LowLevel.IMECompositionString compositionString) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private System.Void Dispose() { }
        private System.Char get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }

    }

    // TypeToken: 0x20001B8
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private readonly UnityEngine.InputSystem.LowLevel.InputEvent* m_Buffer;        // 0x10
        private readonly System.Int32 m_EventCount;        // 0x18
        private UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentEvent;        // 0x20
        private System.Int32 m_CurrentIndex;        // 0x28

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputEventBuffer buffer) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private System.Void Dispose() { }
        private UnityEngine.InputSystem.LowLevel.InputEventPtr get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }

    }

    // TypeToken: 0x20001BA
    public class ObserverState
    {
        // Fields
        public UnityEngine.InputSystem.Utilities.InlinedArray<System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr>> observers;        // 0x10
        public System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> onEventDelegate;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void <.ctor>b__2_0(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device) { }

    }

    // TypeToken: 0x20001BB
    public class DisposableObserver, IDisposable
    {
        // Fields
        public System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer;        // 0x10

        // Methods
        private System.Void Dispose() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001BF
    public class Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private UnityEngine.InputSystem.LowLevel.InputEventTrace m_Trace;        // 0x10
        private System.Int32 m_ChangeCounter;        // 0x18
        private UnityEngine.InputSystem.LowLevel.InputEventPtr m_Current;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputEventTrace trace) { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private UnityEngine.InputSystem.LowLevel.InputEventPtr get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }

    }

    // TypeToken: 0x20001C0
    public struct FileFlags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.LowLevel.InputEventTrace.FileFlags FixedUpdate;        // 0x0

    }

    // TypeToken: 0x20001C1
    public class ReplayController, IDisposable
    {
        // Fields
        private System.Boolean <finished>k__BackingField;        // 0x10
        private System.Boolean <paused>k__BackingField;        // 0x11
        private System.Int32 <position>k__BackingField;        // 0x14
        private UnityEngine.InputSystem.LowLevel.InputEventTrace m_EventTrace;        // 0x18
        private UnityEngine.InputSystem.LowLevel.InputEventTrace.Enumerator m_Enumerator;        // 0x20
        private UnityEngine.InputSystem.Utilities.InlinedArray<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> m_DeviceIDMappings;        // 0x28
        private System.Boolean m_CreateNewDevices;        // 0x40
        private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputDevice> m_CreatedDevices;        // 0x48
        private System.Action m_OnFinished;        // 0x60
        private System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_OnEvent;        // 0x68
        private System.Double m_StartTimeAsPerFirstEvent;        // 0x70
        private System.Double m_StartTimeAsPerRuntime;        // 0x78
        private System.Int32 m_AllEventsByTimeIndex;        // 0x80
        private System.Collections.Generic.List<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_AllEventsByTime;        // 0x88

        // Methods
        private UnityEngine.InputSystem.LowLevel.InputEventTrace get_trace() { }
        private System.Boolean get_finished() { }
        private System.Void set_finished(System.Boolean value) { }
        private System.Boolean get_paused() { }
        private System.Void set_paused(System.Boolean value) { }
        private System.Int32 get_position() { }
        private System.Void set_position(System.Int32 value) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputDevice> get_createdDevices() { }
        private System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputEventTrace trace) { }
        private System.Void Dispose() { }
        private UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController WithDeviceMappedFromTo(UnityEngine.InputSystem.InputDevice recordedDevice, UnityEngine.InputSystem.InputDevice playbackDevice) { }
        private UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController WithDeviceMappedFromTo(System.Int32 recordedDeviceId, System.Int32 playbackDeviceId) { }
        private UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController WithAllDevicesMappedToNewInstances() { }
        private UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController OnFinished(System.Action action) { }
        private UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController OnEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> action) { }
        private UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayOneEvent() { }
        private UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController Rewind() { }
        private UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayAllFramesOneByOne() { }
        private UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayAllEvents() { }
        private UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController PlayAllEventsAccordingToTimestamps() { }
        private System.Void OnBeginFrame() { }
        private System.Void Finished() { }
        private System.Void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Boolean MoveNext(System.Boolean skipFrameEvents, UnityEngine.InputSystem.LowLevel.InputEventPtr& eventPtr) { }
        private System.Int32 ApplyDeviceMapping(System.Int32 originalDeviceId) { }

    }

    // TypeToken: 0x20001C4
    public struct DeviceInfo
    {
        // Fields
        private System.Int32 m_DeviceId;        // 0x10
        private System.String m_Layout;        // 0x18
        private UnityEngine.InputSystem.Utilities.FourCC m_StateFormat;        // 0x20
        private System.Int32 m_StateSizeInBytes;        // 0x24
        private System.String m_FullLayoutJson;        // 0x28

        // Methods
        private System.Int32 get_deviceId() { }
        private System.Void set_deviceId(System.Int32 value) { }
        private System.String get_layout() { }
        private System.Void set_layout(System.String value) { }
        private UnityEngine.InputSystem.Utilities.FourCC get_stateFormat() { }
        private System.Void set_stateFormat(UnityEngine.InputSystem.Utilities.FourCC value) { }
        private System.Int32 get_stateSizeInBytes() { }
        private System.Void set_stateSizeInBytes(System.Int32 value) { }

    }

    // TypeToken: 0x20001CF
    public struct UpdateStepCount
    {
        // Fields
        private System.Boolean m_WasUpdated;        // 0x10
        private System.UInt32 <value>k__BackingField;        // 0x14

        // Methods
        private System.UInt32 get_value() { }
        private System.Void set_value(System.UInt32 value) { }
        private System.Void OnBeforeUpdate() { }
        private System.Void OnUpdate() { }

    }

    // TypeToken: 0x20001D0
    public struct SerializedState
    {
        // Fields
        public UnityEngine.InputSystem.LowLevel.InputUpdateType lastUpdateType;        // 0x10
        public UnityEngine.InputSystem.LowLevel.InputUpdate.UpdateStepCount playerUpdateStepCount;        // 0x14

    }

    // TypeToken: 0x20001D9
    public class StateChangeMonitorDelegate, IInputStateChangeMonitor
    {
        // Fields
        public System.Action<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Int64> valueChangeCallback;        // 0x10
        public System.Action<UnityEngine.InputSystem.InputControl,System.Double,System.Int64,System.Int32> timerExpiredCallback;        // 0x18

        // Methods
        private System.Void NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Int64 monitorIndex) { }
        private System.Void NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, System.Double time, System.Int64 monitorIndex, System.Int32 timerIndex) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001DC
    public struct DoubleBuffers
    {
        // Fields
        public System.Void** deviceToBufferMapping;        // 0x10
        public System.Int32 deviceCount;        // 0x18

        // Methods
        private System.Boolean get_valid() { }
        private System.Void SetFrontBuffer(System.Int32 deviceIndex, System.Void* ptr) { }
        private System.Void SetBackBuffer(System.Int32 deviceIndex, System.Void* ptr) { }
        private System.Void* GetFrontBuffer(System.Int32 deviceIndex) { }
        private System.Void* GetBackBuffer(System.Int32 deviceIndex) { }
        private System.Void SwapBuffers(System.Int32 deviceIndex) { }

    }

    // TypeToken: 0x20001DE
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private readonly UnityEngine.InputSystem.LowLevel.InputStateHistory m_History;        // 0x10
        private System.Int32 m_Index;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory history) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.Record get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20001DF
    public struct RecordHeader
    {
        // Fields
        public System.Double time;        // 0x10
        public System.UInt32 version;        // 0x18
        public System.Int32 controlIndex;        // 0x1C
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader.<m_StateWithoutControlIndex>e__FixedBuffer m_StateWithoutControlIndex;        // 0x1C
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader.<m_StateWithControlIndex>e__FixedBuffer m_StateWithControlIndex;        // 0x20
        public static System.Int32 kSizeWithControlIndex;        // 0x0
        public static System.Int32 kSizeWithoutControlIndex;        // 0x0

        // Methods
        private System.Byte* get_statePtrWithControlIndex() { }
        private System.Byte* get_statePtrWithoutControlIndex() { }

    }

    // TypeToken: 0x20001E2
    public struct Record, IEquatable`1
    {
        // Fields
        private readonly UnityEngine.InputSystem.LowLevel.InputStateHistory m_Owner;        // 0x10
        private readonly System.Int32 m_IndexPlusOne;        // 0x18
        private System.UInt32 m_Version;        // 0x1C

        // Methods
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* get_header() { }
        private System.Int32 get_recordIndex() { }
        private System.UInt32 get_version() { }
        private System.Boolean get_valid() { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory get_owner() { }
        private System.Int32 get_index() { }
        private System.Double get_time() { }
        private UnityEngine.InputSystem.InputControl get_control() { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.Record get_next() { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.Record get_previous() { }
        private System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory owner, System.Int32 index, UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* header) { }
        private TValue ReadValue() { }
        private System.Object ReadValueAsObject() { }
        private System.Void* GetUnsafeMemoryPtr() { }
        private System.Void* GetUnsafeMemoryPtrUnchecked() { }
        private System.Void* GetUnsafeExtraMemoryPtr() { }
        private System.Void* GetUnsafeExtraMemoryPtrUnchecked() { }
        private System.Void CopyFrom(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record record) { }
        private System.Void CheckValid() { }
        private System.Boolean Equals(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20001E4
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> m_History;        // 0x0
        private System.Int32 m_Index;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> history) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x20001E5
    public struct Record, IEquatable`1
    {
        // Fields
        private readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> m_Owner;        // 0x0
        private readonly System.Int32 m_IndexPlusOne;        // 0x0
        private System.UInt32 m_Version;        // 0x0

        // Methods
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* get_header() { }
        private System.Int32 get_recordIndex() { }
        private System.Boolean get_valid() { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> get_owner() { }
        private System.Int32 get_index() { }
        private System.Double get_time() { }
        private UnityEngine.InputSystem.InputControl<TValue> get_control() { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> get_next() { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> get_previous() { }
        private System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, System.Int32 index, UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* header) { }
        private System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputStateHistory<TValue> owner, System.Int32 index) { }
        private TValue ReadValue() { }
        private System.Void* GetUnsafeMemoryPtr() { }
        private System.Void* GetUnsafeMemoryPtrUnchecked() { }
        private System.Void* GetUnsafeExtraMemoryPtr() { }
        private System.Void* GetUnsafeExtraMemoryPtrUnchecked() { }
        private System.Void CopyFrom(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> record) { }
        private System.Void CheckValid() { }
        private System.Boolean Equals(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20001E7
    public class Select, IObserver`1
    {
        // Fields
        private UnityEngine.InputSystem.LowLevel.SelectObservable<TSource,TResult> m_Observable;        // 0x0
        private readonly System.IObserver<TResult> m_Observer;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.LowLevel.SelectObservable<TSource,TResult> observable, System.IObserver<TResult> observer) { }
        private System.Void OnCompleted() { }
        private System.Void OnError(System.Exception error) { }
        private System.Void OnNext(TSource evt) { }

    }

    // TypeToken: 0x20001FA
    public struct Flags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags isModifyingExistingControl;        // 0x0
        public static UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags IsNoisy;        // 0x0
        public static UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags IsSynthetic;        // 0x0
        public static UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags IsFirstDefinedInThisLayout;        // 0x0
        public static UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags DontReset;        // 0x0

    }

    // TypeToken: 0x20001F9
    public struct ControlItem
    {
        // Fields
        private UnityEngine.InputSystem.Utilities.InternedString <name>k__BackingField;        // 0x10
        private UnityEngine.InputSystem.Utilities.InternedString <layout>k__BackingField;        // 0x20
        private UnityEngine.InputSystem.Utilities.InternedString <variants>k__BackingField;        // 0x30
        private System.String <useStateFrom>k__BackingField;        // 0x40
        private System.String <displayName>k__BackingField;        // 0x48
        private System.String <shortDisplayName>k__BackingField;        // 0x50
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> <usages>k__BackingField;        // 0x58
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> <aliases>k__BackingField;        // 0x68
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> <parameters>k__BackingField;        // 0x78
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> <processors>k__BackingField;        // 0x88
        private System.UInt32 <offset>k__BackingField;        // 0x98
        private System.UInt32 <bit>k__BackingField;        // 0x9C
        private System.UInt32 <sizeInBits>k__BackingField;        // 0xA0
        private UnityEngine.InputSystem.Utilities.FourCC <format>k__BackingField;        // 0xA4
        private UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags <flags>k__BackingField;        // 0xA8
        private System.Int32 <arraySize>k__BackingField;        // 0xAC
        private UnityEngine.InputSystem.Utilities.PrimitiveValue <defaultState>k__BackingField;        // 0xB0
        private UnityEngine.InputSystem.Utilities.PrimitiveValue <minValue>k__BackingField;        // 0xC0
        private UnityEngine.InputSystem.Utilities.PrimitiveValue <maxValue>k__BackingField;        // 0xD0

        // Methods
        private UnityEngine.InputSystem.Utilities.InternedString get_name() { }
        private System.Void set_name(UnityEngine.InputSystem.Utilities.InternedString value) { }
        private UnityEngine.InputSystem.Utilities.InternedString get_layout() { }
        private System.Void set_layout(UnityEngine.InputSystem.Utilities.InternedString value) { }
        private UnityEngine.InputSystem.Utilities.InternedString get_variants() { }
        private System.Void set_variants(UnityEngine.InputSystem.Utilities.InternedString value) { }
        private System.String get_useStateFrom() { }
        private System.Void set_useStateFrom(System.String value) { }
        private System.String get_displayName() { }
        private System.Void set_displayName(System.String value) { }
        private System.String get_shortDisplayName() { }
        private System.Void set_shortDisplayName(System.String value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_usages() { }
        private System.Void set_usages(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_aliases() { }
        private System.Void set_aliases(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> get_parameters() { }
        private System.Void set_parameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> get_processors() { }
        private System.Void set_processors(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NameAndParameters> value) { }
        private System.UInt32 get_offset() { }
        private System.Void set_offset(System.UInt32 value) { }
        private System.UInt32 get_bit() { }
        private System.Void set_bit(System.UInt32 value) { }
        private System.UInt32 get_sizeInBits() { }
        private System.Void set_sizeInBits(System.UInt32 value) { }
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }
        private System.Void set_format(UnityEngine.InputSystem.Utilities.FourCC value) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags get_flags() { }
        private System.Void set_flags(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags value) { }
        private System.Int32 get_arraySize() { }
        private System.Void set_arraySize(System.Int32 value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue get_defaultState() { }
        private System.Void set_defaultState(UnityEngine.InputSystem.Utilities.PrimitiveValue value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue get_minValue() { }
        private System.Void set_minValue(UnityEngine.InputSystem.Utilities.PrimitiveValue value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue get_maxValue() { }
        private System.Void set_maxValue(UnityEngine.InputSystem.Utilities.PrimitiveValue value) { }
        private System.Boolean get_isModifyingExistingControl() { }
        private System.Void set_isModifyingExistingControl(System.Boolean value) { }
        private System.Boolean get_isNoisy() { }
        private System.Void set_isNoisy(System.Boolean value) { }
        private System.Boolean get_isSynthetic() { }
        private System.Void set_isSynthetic(System.Boolean value) { }
        private System.Boolean get_dontReset() { }
        private System.Void set_dontReset(System.Boolean value) { }
        private System.Boolean get_isFirstDefinedInThisLayout() { }
        private System.Void set_isFirstDefinedInThisLayout(System.Boolean value) { }
        private System.Boolean get_isArray() { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem Merge(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem other) { }

    }

    // TypeToken: 0x20001FC
    public struct ControlBuilder
    {
        // Fields
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder builder;        // 0x10
        private System.Int32 index;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithDisplayName(System.String displayName) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithLayout(System.String layout) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithFormat(UnityEngine.InputSystem.Utilities.FourCC format) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithFormat(System.String format) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithByteOffset(System.UInt32 offset) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithBitOffset(System.UInt32 bit) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder IsSynthetic(System.Boolean value) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder IsNoisy(System.Boolean value) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder DontReset(System.Boolean value) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithSizeInBits(System.UInt32 sizeInBits) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithRange(System.Single minValue, System.Single maxValue) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithUsages(UnityEngine.InputSystem.Utilities.InternedString[] usages) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithUsages(System.Collections.Generic.IEnumerable<System.String> usages) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithUsages(System.String[] usages) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithParameters(System.String parameters) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithProcessors(System.String processors) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithDefaultState(UnityEngine.InputSystem.Utilities.PrimitiveValue value) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder UsingStateFrom(System.String path) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder AsArrayOfControlsWithSize(System.Int32 arraySize) { }

    }

    // TypeToken: 0x20001FB
    public class Builder
    {
        // Fields
        private System.String <name>k__BackingField;        // 0x10
        private System.String <displayName>k__BackingField;        // 0x18
        private System.Type <type>k__BackingField;        // 0x20
        private UnityEngine.InputSystem.Utilities.FourCC <stateFormat>k__BackingField;        // 0x28
        private System.Int32 <stateSizeInBytes>k__BackingField;        // 0x2C
        private System.String m_ExtendsLayout;        // 0x30
        private System.Nullable<System.Boolean> <updateBeforeRender>k__BackingField;        // 0x38
        private System.Int32 m_ControlCount;        // 0x3C
        private UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[] m_Controls;        // 0x40

        // Methods
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.String get_displayName() { }
        private System.Void set_displayName(System.String value) { }
        private System.Type get_type() { }
        private System.Void set_type(System.Type value) { }
        private UnityEngine.InputSystem.Utilities.FourCC get_stateFormat() { }
        private System.Void set_stateFormat(UnityEngine.InputSystem.Utilities.FourCC value) { }
        private System.Int32 get_stateSizeInBytes() { }
        private System.Void set_stateSizeInBytes(System.Int32 value) { }
        private System.String get_extendsLayout() { }
        private System.Void set_extendsLayout(System.String value) { }
        private System.Nullable<System.Boolean> get_updateBeforeRender() { }
        private System.Void set_updateBeforeRender(System.Nullable<System.Boolean> value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> get_controls() { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder AddControl(System.String name) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithName(System.String name) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithDisplayName(System.String displayName) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithType() { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithFormat(UnityEngine.InputSystem.Utilities.FourCC format) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithFormat(System.String format) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithSizeInBytes(System.Int32 sizeInBytes) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Builder Extend(System.String baseLayoutName) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout Build() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001FE
    public struct Flags
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Layouts.InputControlLayout.Flags IsGenericTypeOfDevice;        // 0x0
        public static UnityEngine.InputSystem.Layouts.InputControlLayout.Flags HideInUI;        // 0x0
        public static UnityEngine.InputSystem.Layouts.InputControlLayout.Flags IsOverride;        // 0x0
        public static UnityEngine.InputSystem.Layouts.InputControlLayout.Flags CanRunInBackground;        // 0x0
        public static UnityEngine.InputSystem.Layouts.InputControlLayout.Flags CanRunInBackgroundIsSet;        // 0x0
        public static UnityEngine.InputSystem.Layouts.InputControlLayout.Flags IsNoisy;        // 0x0

    }

    // TypeToken: 0x20001FF
    public struct LayoutJsonNameAndDescriptorOnly
    {
        // Fields
        public System.String name;        // 0x10
        public System.String extend;        // 0x18
        public System.String[] extendMultiple;        // 0x20
        public UnityEngine.InputSystem.Layouts.InputDeviceMatcher.MatcherJson device;        // 0x28

    }

    // TypeToken: 0x2000200
    public struct LayoutJson
    {
        // Fields
        public System.String name;        // 0x10
        public System.String extend;        // 0x18
        public System.String[] extendMultiple;        // 0x20
        public System.String format;        // 0x28
        public System.String beforeRender;        // 0x30
        public System.String runInBackground;        // 0x38
        public System.String[] commonUsages;        // 0x40
        public System.String displayName;        // 0x48
        public System.String description;        // 0x50
        public System.String type;        // 0x58
        public System.String variant;        // 0x60
        public System.Boolean isGenericTypeOfDevice;        // 0x68
        public System.Boolean hideInUI;        // 0x69
        public UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItemJson[] controls;        // 0x70

        // Methods
        private UnityEngine.InputSystem.Layouts.InputControlLayout ToLayout() { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.LayoutJson FromLayout(UnityEngine.InputSystem.Layouts.InputControlLayout layout) { }

    }

    // TypeToken: 0x2000202
    public class ControlItemJson
    {
        // Fields
        public System.String name;        // 0x10
        public System.String layout;        // 0x18
        public System.String variants;        // 0x20
        public System.String usage;        // 0x28
        public System.String alias;        // 0x30
        public System.String useStateFrom;        // 0x38
        public System.UInt32 offset;        // 0x40
        public System.UInt32 bit;        // 0x44
        public System.UInt32 sizeInBits;        // 0x48
        public System.String format;        // 0x50
        public System.Int32 arraySize;        // 0x58
        public System.String[] usages;        // 0x60
        public System.String[] aliases;        // 0x68
        public System.String parameters;        // 0x70
        public System.String processors;        // 0x78
        public System.String displayName;        // 0x80
        public System.String shortDisplayName;        // 0x88
        public System.Boolean noisy;        // 0x90
        public System.Boolean dontReset;        // 0x91
        public System.Boolean synthetic;        // 0x92
        public System.String defaultState;        // 0x98
        public System.String minValue;        // 0xA0
        public System.String maxValue;        // 0xA8

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem ToLayout() { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItemJson[] FromControlItems(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[] items) { }

    }

    // TypeToken: 0x2000205
    public struct LayoutMatcher
    {
        // Fields
        public UnityEngine.InputSystem.Utilities.InternedString layoutName;        // 0x10
        public UnityEngine.InputSystem.Layouts.InputDeviceMatcher deviceMatcher;        // 0x20

    }

    // TypeToken: 0x2000206
    public struct PrecompiledLayout
    {
        // Fields
        public System.Func<UnityEngine.InputSystem.InputDevice> factoryMethod;        // 0x10
        public System.String metadata;        // 0x18

    }

    // TypeToken: 0x2000204
    public struct Collection
    {
        // Fields
        public static System.Single kBaseScoreForNonGeneratedLayouts;        // 0x0
        public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.Type> layoutTypes;        // 0x10
        public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.String> layoutStrings;        // 0x18
        public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout>> layoutBuilders;        // 0x20
        public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString> baseLayoutTable;        // 0x28
        public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Utilities.InternedString[]> layoutOverrides;        // 0x30
        public System.Collections.Generic.HashSet<UnityEngine.InputSystem.Utilities.InternedString> layoutOverrideNames;        // 0x38
        public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout.Collection.PrecompiledLayout> precompiledLayouts;        // 0x40
        public System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.Collection.LayoutMatcher> layoutMatchers;        // 0x48

        // Methods
        private System.Void Allocate() { }
        private UnityEngine.InputSystem.Utilities.InternedString TryFindLayoutForType(System.Type layoutType) { }
        private UnityEngine.InputSystem.Utilities.InternedString TryFindMatchingLayout(UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription) { }
        private System.Boolean HasLayout(UnityEngine.InputSystem.Utilities.InternedString name) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadLayoutInternal(UnityEngine.InputSystem.Utilities.InternedString name) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadLayout(UnityEngine.InputSystem.Utilities.InternedString name, System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout> table) { }
        private UnityEngine.InputSystem.Utilities.InternedString GetBaseLayoutName(UnityEngine.InputSystem.Utilities.InternedString layoutName) { }
        private UnityEngine.InputSystem.Utilities.InternedString GetRootLayoutName(UnityEngine.InputSystem.Utilities.InternedString layoutName) { }
        private System.Boolean ComputeDistanceInInheritanceHierarchy(UnityEngine.InputSystem.Utilities.InternedString firstLayout, UnityEngine.InputSystem.Utilities.InternedString secondLayout, System.Int32& distance) { }
        private UnityEngine.InputSystem.Utilities.InternedString FindLayoutThatIntroducesControl(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Layouts.InputControlLayout.Cache cache) { }
        private System.Type GetControlTypeForLayout(UnityEngine.InputSystem.Utilities.InternedString layoutName) { }
        private System.Boolean ValueTypeIsAssignableFrom(UnityEngine.InputSystem.Utilities.InternedString layoutName, System.Type valueType) { }
        private System.Boolean IsGeneratedLayout(UnityEngine.InputSystem.Utilities.InternedString layout) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> GetBaseLayouts(UnityEngine.InputSystem.Utilities.InternedString layout, System.Boolean includeSelf) { }
        private System.Boolean IsBasedOn(UnityEngine.InputSystem.Utilities.InternedString parentLayout, UnityEngine.InputSystem.Utilities.InternedString childLayout) { }
        private System.Void AddMatcher(UnityEngine.InputSystem.Utilities.InternedString layout, UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher) { }

    }

    // TypeToken: 0x2000208
    public class LayoutNotFoundException : Exception
    {
        // Fields
        private readonly System.String <layout>k__BackingField;        // 0x90

        // Methods
        private System.String get_layout() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name, System.String message) { }
        private System.Void .ctor(System.String name) { }
        private System.Void .ctor(System.String message, System.Exception innerException) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }

    }

    // TypeToken: 0x2000209
    public struct Cache
    {
        // Fields
        public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,UnityEngine.InputSystem.Layouts.InputControlLayout> table;        // 0x10

        // Methods
        private System.Void Clear() { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout FindOrLoadLayout(System.String name, System.Boolean throwIfNotFound) { }

    }

    // TypeToken: 0x200020A
    public struct CacheRefInstance, IDisposable
    {
        // Fields
        public System.Boolean valid;        // 0x10

        // Methods
        private System.Void Dispose() { }

    }

    // TypeToken: 0x200020E
    public struct RefInstance, IDisposable
    {
        // Methods
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000210
    public struct DeviceDescriptionJson
    {
        // Fields
        public System.String interface;        // 0x10
        public System.String type;        // 0x18
        public System.String product;        // 0x20
        public System.String serial;        // 0x28
        public System.String version;        // 0x30
        public System.String manufacturer;        // 0x38
        public System.String capabilities;        // 0x40

    }

    // TypeToken: 0x2000213
    public struct Capability
    {
        // Fields
        public System.String path;        // 0x10
        public System.String value;        // 0x18

    }

    // TypeToken: 0x2000212
    public struct MatcherJson
    {
        // Fields
        public System.String interface;        // 0x10
        public System.String[] interfaces;        // 0x18
        public System.String deviceClass;        // 0x20
        public System.String[] deviceClasses;        // 0x28
        public System.String manufacturer;        // 0x30
        public System.String manufacturerContains;        // 0x38
        public System.String[] manufacturers;        // 0x40
        public System.String product;        // 0x48
        public System.String[] products;        // 0x50
        public System.String version;        // 0x58
        public System.String[] versions;        // 0x60
        public UnityEngine.InputSystem.Layouts.InputDeviceMatcher.MatcherJson.Capability[] capabilities;        // 0x68

        // Methods
        private UnityEngine.InputSystem.Layouts.InputDeviceMatcher.MatcherJson FromMatcher(UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher) { }
        private UnityEngine.InputSystem.Layouts.InputDeviceMatcher ToMatcher() { }

    }

    // TypeToken: 0x2000218
    public struct Clamp
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Controls.AxisControl.Clamp None;        // 0x0
        public static UnityEngine.InputSystem.Controls.AxisControl.Clamp BeforeNormalize;        // 0x0
        public static UnityEngine.InputSystem.Controls.AxisControl.Clamp AfterNormalize;        // 0x0
        public static UnityEngine.InputSystem.Controls.AxisControl.Clamp ToConstantBeforeNormalize;        // 0x0

    }

    // TypeToken: 0x200021C
    public struct WriteMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Controls.DiscreteButtonControl.WriteMode WriteDisabled;        // 0x0
        public static UnityEngine.InputSystem.Controls.DiscreteButtonControl.WriteMode WriteNullAndMaxValue;        // 0x0

    }

    // TypeToken: 0x200021F
    public class DpadAxisControl : AxisControl
    {
        // Fields
        private System.Int32 <component>k__BackingField;        // 0x130

        // Methods
        private System.Int32 get_component() { }
        private System.Void set_component(System.Int32 value) { }
        private System.Void FinishSetup() { }
        private System.Single ReadUnprocessedValueFromState(System.Void* statePtr) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000220
    public struct ButtonBits
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Controls.DpadControl.ButtonBits Up;        // 0x0
        public static UnityEngine.InputSystem.Controls.DpadControl.ButtonBits Down;        // 0x0
        public static UnityEngine.InputSystem.Controls.DpadControl.ButtonBits Left;        // 0x0
        public static UnityEngine.InputSystem.Controls.DpadControl.ButtonBits Right;        // 0x0

    }

    // TypeToken: 0x200022C
    public struct TapPhase
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Interactions.MultiTapInteraction.TapPhase None;        // 0x0
        public static UnityEngine.InputSystem.Interactions.MultiTapInteraction.TapPhase WaitingForNextRelease;        // 0x0
        public static UnityEngine.InputSystem.Interactions.MultiTapInteraction.TapPhase WaitingForNextPress;        // 0x0

    }

    // TypeToken: 0x2000232
    public struct ActionEventPtr
    {
        // Fields
        private UnityEngine.InputSystem.InputActionState m_State;        // 0x10
        private UnityEngine.InputSystem.LowLevel.ActionEvent* m_Ptr;        // 0x18

        // Methods
        private UnityEngine.InputSystem.InputAction get_action() { }
        private UnityEngine.InputSystem.InputActionPhase get_phase() { }
        private UnityEngine.InputSystem.InputControl get_control() { }
        private UnityEngine.InputSystem.IInputInteraction get_interaction() { }
        private System.Double get_time() { }
        private System.Double get_startTime() { }
        private System.Double get_duration() { }
        private System.Int32 get_valueSizeInBytes() { }
        private System.Object ReadValueAsObject() { }
        private System.Void ReadValue(System.Void* buffer, System.Int32 bufferSize) { }
        private TValue ReadValue() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000233
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private readonly UnityEngine.InputSystem.Utilities.InputActionTrace m_Trace;        // 0x10
        private readonly UnityEngine.InputSystem.LowLevel.ActionEvent* m_Buffer;        // 0x18
        private readonly System.Int32 m_EventCount;        // 0x20
        private UnityEngine.InputSystem.LowLevel.ActionEvent* m_CurrentEvent;        // 0x28
        private System.Int32 m_CurrentIndex;        // 0x30

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.Utilities.InputActionTrace trace) { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private System.Void Dispose() { }
        private UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }

    }

    // TypeToken: 0x2000241
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        public UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array;        // 0x0
        public System.Int32 index;        // 0x0

        // Methods
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private TValue get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void Dispose() { }

    }

    // TypeToken: 0x2000245
    public struct JsonValueType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Utilities.JsonParser.JsonValueType None;        // 0x0
        public static UnityEngine.InputSystem.Utilities.JsonParser.JsonValueType Bool;        // 0x0
        public static UnityEngine.InputSystem.Utilities.JsonParser.JsonValueType Real;        // 0x0
        public static UnityEngine.InputSystem.Utilities.JsonParser.JsonValueType Integer;        // 0x0
        public static UnityEngine.InputSystem.Utilities.JsonParser.JsonValueType String;        // 0x0
        public static UnityEngine.InputSystem.Utilities.JsonParser.JsonValueType Array;        // 0x0
        public static UnityEngine.InputSystem.Utilities.JsonParser.JsonValueType Object;        // 0x0
        public static UnityEngine.InputSystem.Utilities.JsonParser.JsonValueType Any;        // 0x0

    }

    // TypeToken: 0x2000246
    public struct JsonString, IEquatable`1
    {
        // Fields
        public UnityEngine.InputSystem.Utilities.Substring text;        // 0x10
        public System.Boolean hasEscapes;        // 0x20

        // Methods
        private System.String ToString() { }
        private System.Boolean Equals(UnityEngine.InputSystem.Utilities.JsonParser.JsonString other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.JsonParser.JsonString left, UnityEngine.InputSystem.Utilities.JsonParser.JsonString right) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.JsonParser.JsonString left, UnityEngine.InputSystem.Utilities.JsonParser.JsonString right) { }
        private UnityEngine.InputSystem.Utilities.JsonParser.JsonString op_Implicit(System.String str) { }

    }

    // TypeToken: 0x2000247
    public struct JsonValue, IEquatable`1
    {
        // Fields
        public UnityEngine.InputSystem.Utilities.JsonParser.JsonValueType type;        // 0x10
        public System.Boolean boolValue;        // 0x14
        public System.Double realValue;        // 0x18
        public System.Int64 integerValue;        // 0x20
        public UnityEngine.InputSystem.Utilities.JsonParser.JsonString stringValue;        // 0x28
        public System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> arrayValue;        // 0x40
        public System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> objectValue;        // 0x48
        public System.Object anyValue;        // 0x50

        // Methods
        private System.Boolean ToBoolean() { }
        private System.Int64 ToInteger() { }
        private System.Double ToDouble() { }
        private System.String ToString() { }
        private UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Boolean val) { }
        private UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Int64 val) { }
        private UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Double val) { }
        private UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.String str) { }
        private UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(UnityEngine.InputSystem.Utilities.JsonParser.JsonString str) { }
        private UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> array) { }
        private UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Utilities.JsonParser.JsonValue> obj) { }
        private UnityEngine.InputSystem.Utilities.JsonParser.JsonValue op_Implicit(System.Enum val) { }
        private System.Boolean Equals(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue other) { }
        private System.Boolean Equals(System.Object obj, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue value) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue left, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue right) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue left, UnityEngine.InputSystem.Utilities.JsonParser.JsonValue right) { }

    }

    // TypeToken: 0x200024A
    public struct BitRegion
    {
        // Fields
        public System.UInt32 bitOffset;        // 0x10
        public System.UInt32 sizeInBits;        // 0x14

        // Methods
        private System.Boolean get_isEmpty() { }
        private System.Void .ctor(System.UInt32 bitOffset, System.UInt32 sizeInBits) { }
        private System.Void .ctor(System.UInt32 byteOffset, System.UInt32 bitOffset, System.UInt32 sizeInBits) { }
        private UnityEngine.InputSystem.Utilities.MemoryHelpers.BitRegion Overlap(UnityEngine.InputSystem.Utilities.MemoryHelpers.BitRegion other) { }

    }

    // TypeToken: 0x2000252
    public class ForDevice, IObserver`1
    {
        // Fields
        private System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_Observer;        // 0x10
        private UnityEngine.InputSystem.InputDevice m_Device;        // 0x18
        private System.Type m_DeviceType;        // 0x20

        // Methods
        private System.Void .ctor(System.Type deviceType, UnityEngine.InputSystem.InputDevice device, System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer) { }
        private System.Void OnCompleted() { }
        private System.Void OnError(System.Exception error) { }
        private System.Void OnNext(UnityEngine.InputSystem.LowLevel.InputEventPtr value) { }

    }

    // TypeToken: 0x2000257
    public class Select, IObserver`1
    {
        // Fields
        private UnityEngine.InputSystem.Utilities.SelectManyObservable<TSource,TResult> m_Observable;        // 0x0
        private readonly System.IObserver<TResult> m_Observer;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.Utilities.SelectManyObservable<TSource,TResult> observable, System.IObserver<TResult> observer) { }
        private System.Void OnCompleted() { }
        private System.Void OnError(System.Exception error) { }
        private System.Void OnNext(TSource evt) { }

    }

    // TypeToken: 0x2000259
    public class Take, IObserver`1
    {
        // Fields
        private System.IObserver<TValue> m_Observer;        // 0x0
        private System.Int32 m_Remaining;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.Utilities.TakeNObservable<TValue> observable, System.IObserver<TValue> observer) { }
        private System.Void OnCompleted() { }
        private System.Void OnError(System.Exception error) { }
        private System.Void OnNext(TValue evt) { }

    }

    // TypeToken: 0x200025B
    public class Where, IObserver`1
    {
        // Fields
        private UnityEngine.InputSystem.Utilities.WhereObservable<TValue> m_Observable;        // 0x0
        private readonly System.IObserver<TValue> m_Observer;        // 0x0

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.Utilities.WhereObservable<TValue> observable, System.IObserver<TValue> observer) { }
        private System.Void OnCompleted() { }
        private System.Void OnError(System.Exception error) { }
        private System.Void OnNext(TValue evt) { }

    }

    // TypeToken: 0x200025D
    public class Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private System.Int32 m_Index;        // 0x0
        private UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> m_List;        // 0x0

        // Methods
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private TValue get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void Dispose() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000261
    public struct Enumerator, IEnumerator`1, IEnumerator, IDisposable
    {
        // Fields
        private readonly TValue[] m_Array;        // 0x0
        private readonly System.Int32 m_IndexStart;        // 0x0
        private readonly System.Int32 m_IndexEnd;        // 0x0
        private System.Int32 m_Index;        // 0x0

        // Methods
        private System.Void .ctor(TValue[] array, System.Int32 index, System.Int32 length) { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Void Reset() { }
        private TValue get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }

    }

    // TypeToken: 0x2000265
    public class TypedRestore : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T& state) { }
        private System.IAsyncResult BeginInvoke(T& state, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(T& state, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200026F
    public struct WhichSideWins
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Composites.AxisComposite.WhichSideWins Neither;        // 0x0
        public static UnityEngine.InputSystem.Composites.AxisComposite.WhichSideWins Positive;        // 0x0
        public static UnityEngine.InputSystem.Composites.AxisComposite.WhichSideWins Negative;        // 0x0

    }

    // TypeToken: 0x2000271
    public struct ModifiersOrder
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Composites.ButtonWithOneModifier.ModifiersOrder Default;        // 0x0
        public static UnityEngine.InputSystem.Composites.ButtonWithOneModifier.ModifiersOrder Ordered;        // 0x0
        public static UnityEngine.InputSystem.Composites.ButtonWithOneModifier.ModifiersOrder Unordered;        // 0x0

    }

    // TypeToken: 0x2000273
    public struct ModifiersOrder
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Composites.ButtonWithTwoModifiers.ModifiersOrder Default;        // 0x0
        public static UnityEngine.InputSystem.Composites.ButtonWithTwoModifiers.ModifiersOrder Ordered;        // 0x0
        public static UnityEngine.InputSystem.Composites.ButtonWithTwoModifiers.ModifiersOrder Unordered;        // 0x0

    }

    // TypeToken: 0x2000275
    public struct ModifiersOrder
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Composites.OneModifierComposite.ModifiersOrder Default;        // 0x0
        public static UnityEngine.InputSystem.Composites.OneModifierComposite.ModifiersOrder Ordered;        // 0x0
        public static UnityEngine.InputSystem.Composites.OneModifierComposite.ModifiersOrder Unordered;        // 0x0

    }

    // TypeToken: 0x2000277
    public struct ModifiersOrder
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Composites.TwoModifiersComposite.ModifiersOrder Default;        // 0x0
        public static UnityEngine.InputSystem.Composites.TwoModifiersComposite.ModifiersOrder Ordered;        // 0x0
        public static UnityEngine.InputSystem.Composites.TwoModifiersComposite.ModifiersOrder Unordered;        // 0x0

    }

    // TypeToken: 0x2000279
    public struct Mode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Composites.Vector2Composite.Mode Analog;        // 0x0
        public static UnityEngine.InputSystem.Composites.Vector2Composite.Mode DigitalNormalized;        // 0x0
        public static UnityEngine.InputSystem.Composites.Vector2Composite.Mode Digital;        // 0x0

    }

    // TypeToken: 0x200027B
    public struct Mode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Composites.Vector3Composite.Mode Analog;        // 0x0
        public static UnityEngine.InputSystem.Composites.Vector3Composite.Mode DigitalNormalized;        // 0x0
        public static UnityEngine.InputSystem.Composites.Vector3Composite.Mode Digital;        // 0x0

    }

    // TypeToken: 0x200027D
    public struct __StaticArrayInitTypeSize=20
    {
    }

    // TypeToken: 0x200027E
    public struct __StaticArrayInitTypeSize=24
    {
    }

    // TypeToken: 0x200027F
    public struct __StaticArrayInitTypeSize=84
    {
    }

    // TypeToken: 0x2000280
    public struct __StaticArrayInitTypeSize=104
    {
    }

    // TypeToken: 0x2000281
    public struct __StaticArrayInitTypeSize=262
    {
    }

    // TypeToken: 0x2000282
    public struct __StaticArrayInitTypeSize=371
    {
    }

    // TypeToken: 0x2000283
    public struct __StaticArrayInitTypeSize=508
    {
    }

    // TypeToken: 0x2000284
    public struct __StaticArrayInitTypeSize=976
    {
    }

    // TypeToken: 0x2000285
    public struct __StaticArrayInitTypeSize=1036
    {
    }

    // TypeToken: 0x2000286
    public struct __StaticArrayInitTypeSize=1799
    {
    }

    // TypeToken: 0x2000287
    public struct __StaticArrayInitTypeSize=3983
    {
    }

namespace Unity.XR.GoogleVr
{

    // TypeToken: 0x2000010
    public class DaydreamHMD : XRHMD
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public class DaydreamController : XRController
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector2Control <touchpad>k__BackingField;        // 0x1B0
        private UnityEngine.InputSystem.Controls.ButtonControl <volumeUp>k__BackingField;        // 0x1B8
        private UnityEngine.InputSystem.Controls.ButtonControl <recentered>k__BackingField;        // 0x1C0
        private UnityEngine.InputSystem.Controls.ButtonControl <volumeDown>k__BackingField;        // 0x1C8
        private UnityEngine.InputSystem.Controls.ButtonControl <recentering>k__BackingField;        // 0x1D0
        private UnityEngine.InputSystem.Controls.ButtonControl <app>k__BackingField;        // 0x1D8
        private UnityEngine.InputSystem.Controls.ButtonControl <home>k__BackingField;        // 0x1E0
        private UnityEngine.InputSystem.Controls.ButtonControl <touchpadClicked>k__BackingField;        // 0x1E8
        private UnityEngine.InputSystem.Controls.ButtonControl <touchpadTouched>k__BackingField;        // 0x1F0
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;        // 0x1F8
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceAcceleration>k__BackingField;        // 0x200

        // Methods
        private UnityEngine.InputSystem.Controls.Vector2Control get_touchpad() { }
        private System.Void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_volumeUp() { }
        private System.Void set_volumeUp(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_recentered() { }
        private System.Void set_recentered(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_volumeDown() { }
        private System.Void set_volumeDown(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_recentering() { }
        private System.Void set_recentering(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_app() { }
        private System.Void set_app(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_home() { }
        private System.Void set_home(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_touchpadClicked() { }
        private System.Void set_touchpadClicked(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_touchpadTouched() { }
        private System.Void set_touchpadTouched(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity() { }
        private System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceAcceleration() { }
        private System.Void set_deviceAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

}

namespace Unity.XR.Oculus.Input
{

    // TypeToken: 0x200000A
    public class OculusHMD : XRHMD
    {
        // Fields
        private UnityEngine.InputSystem.Controls.ButtonControl <userPresence>k__BackingField;        // 0x1E0
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;        // 0x1E8
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceAcceleration>k__BackingField;        // 0x1F0
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularAcceleration>k__BackingField;        // 0x1F8
        private UnityEngine.InputSystem.Controls.Vector3Control <leftEyeAngularVelocity>k__BackingField;        // 0x200
        private UnityEngine.InputSystem.Controls.Vector3Control <leftEyeAcceleration>k__BackingField;        // 0x208
        private UnityEngine.InputSystem.Controls.Vector3Control <leftEyeAngularAcceleration>k__BackingField;        // 0x210
        private UnityEngine.InputSystem.Controls.Vector3Control <rightEyeAngularVelocity>k__BackingField;        // 0x218
        private UnityEngine.InputSystem.Controls.Vector3Control <rightEyeAcceleration>k__BackingField;        // 0x220
        private UnityEngine.InputSystem.Controls.Vector3Control <rightEyeAngularAcceleration>k__BackingField;        // 0x228
        private UnityEngine.InputSystem.Controls.Vector3Control <centerEyeAngularVelocity>k__BackingField;        // 0x230
        private UnityEngine.InputSystem.Controls.Vector3Control <centerEyeAcceleration>k__BackingField;        // 0x238
        private UnityEngine.InputSystem.Controls.Vector3Control <centerEyeAngularAcceleration>k__BackingField;        // 0x240

        // Methods
        private UnityEngine.InputSystem.Controls.ButtonControl get_userPresence() { }
        private System.Void set_userPresence(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity() { }
        private System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceAcceleration() { }
        private System.Void set_deviceAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularAcceleration() { }
        private System.Void set_deviceAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeAngularVelocity() { }
        private System.Void set_leftEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeAcceleration() { }
        private System.Void set_leftEyeAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeAngularAcceleration() { }
        private System.Void set_leftEyeAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeAngularVelocity() { }
        private System.Void set_rightEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeAcceleration() { }
        private System.Void set_rightEyeAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeAngularAcceleration() { }
        private System.Void set_rightEyeAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeAngularVelocity() { }
        private System.Void set_centerEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeAcceleration() { }
        private System.Void set_centerEyeAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeAngularAcceleration() { }
        private System.Void set_centerEyeAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public class OculusTouchController : XRControllerWithRumble
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector2Control <thumbstick>k__BackingField;        // 0x1B0
        private UnityEngine.InputSystem.Controls.AxisControl <trigger>k__BackingField;        // 0x1B8
        private UnityEngine.InputSystem.Controls.AxisControl <grip>k__BackingField;        // 0x1C0
        private UnityEngine.InputSystem.Controls.ButtonControl <primaryButton>k__BackingField;        // 0x1C8
        private UnityEngine.InputSystem.Controls.ButtonControl <secondaryButton>k__BackingField;        // 0x1D0
        private UnityEngine.InputSystem.Controls.ButtonControl <gripPressed>k__BackingField;        // 0x1D8
        private UnityEngine.InputSystem.Controls.ButtonControl <start>k__BackingField;        // 0x1E0
        private UnityEngine.InputSystem.Controls.ButtonControl <thumbstickClicked>k__BackingField;        // 0x1E8
        private UnityEngine.InputSystem.Controls.ButtonControl <primaryTouched>k__BackingField;        // 0x1F0
        private UnityEngine.InputSystem.Controls.ButtonControl <secondaryTouched>k__BackingField;        // 0x1F8
        private UnityEngine.InputSystem.Controls.AxisControl <triggerTouched>k__BackingField;        // 0x200
        private UnityEngine.InputSystem.Controls.ButtonControl <triggerPressed>k__BackingField;        // 0x208
        private UnityEngine.InputSystem.Controls.ButtonControl <thumbstickTouched>k__BackingField;        // 0x210
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;        // 0x218
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;        // 0x220
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceAcceleration>k__BackingField;        // 0x228
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularAcceleration>k__BackingField;        // 0x230

        // Methods
        private UnityEngine.InputSystem.Controls.Vector2Control get_thumbstick() { }
        private System.Void set_thumbstick(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_trigger() { }
        private System.Void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_grip() { }
        private System.Void set_grip(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_primaryButton() { }
        private System.Void set_primaryButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_secondaryButton() { }
        private System.Void set_secondaryButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed() { }
        private System.Void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_start() { }
        private System.Void set_start(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_thumbstickClicked() { }
        private System.Void set_thumbstickClicked(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_primaryTouched() { }
        private System.Void set_primaryTouched(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_secondaryTouched() { }
        private System.Void set_secondaryTouched(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_triggerTouched() { }
        private System.Void set_triggerTouched(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed() { }
        private System.Void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_thumbstickTouched() { }
        private System.Void set_thumbstickTouched(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity() { }
        private System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity() { }
        private System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceAcceleration() { }
        private System.Void set_deviceAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularAcceleration() { }
        private System.Void set_deviceAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000C
    public class OculusTrackingReference : TrackedDevice
    {
        // Fields
        private UnityEngine.InputSystem.Controls.IntegerControl <trackingState>k__BackingField;        // 0x1B0
        private UnityEngine.InputSystem.Controls.ButtonControl <isTracked>k__BackingField;        // 0x1B8

        // Methods
        private UnityEngine.InputSystem.Controls.IntegerControl get_trackingState() { }
        private System.Void set_trackingState(UnityEngine.InputSystem.Controls.IntegerControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_isTracked() { }
        private System.Void set_isTracked(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000D
    public class OculusRemote : InputDevice
    {
        // Fields
        private UnityEngine.InputSystem.Controls.ButtonControl <back>k__BackingField;        // 0x190
        private UnityEngine.InputSystem.Controls.ButtonControl <start>k__BackingField;        // 0x198
        private UnityEngine.InputSystem.Controls.Vector2Control <touchpad>k__BackingField;        // 0x1A0

        // Methods
        private UnityEngine.InputSystem.Controls.ButtonControl get_back() { }
        private System.Void set_back(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_start() { }
        private System.Void set_start(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.Vector2Control get_touchpad() { }
        private System.Void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000E
    public class OculusHMDExtended : OculusHMD
    {
        // Fields
        private UnityEngine.InputSystem.Controls.ButtonControl <back>k__BackingField;        // 0x248
        private UnityEngine.InputSystem.Controls.Vector2Control <touchpad>k__BackingField;        // 0x250

        // Methods
        private UnityEngine.InputSystem.Controls.ButtonControl get_back() { }
        private System.Void set_back(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.Vector2Control get_touchpad() { }
        private System.Void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public class GearVRTrackedController : XRController
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector2Control <touchpad>k__BackingField;        // 0x1B0
        private UnityEngine.InputSystem.Controls.AxisControl <trigger>k__BackingField;        // 0x1B8
        private UnityEngine.InputSystem.Controls.ButtonControl <back>k__BackingField;        // 0x1C0
        private UnityEngine.InputSystem.Controls.ButtonControl <triggerPressed>k__BackingField;        // 0x1C8
        private UnityEngine.InputSystem.Controls.ButtonControl <touchpadClicked>k__BackingField;        // 0x1D0
        private UnityEngine.InputSystem.Controls.ButtonControl <touchpadTouched>k__BackingField;        // 0x1D8
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;        // 0x1E0
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceAcceleration>k__BackingField;        // 0x1E8
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularAcceleration>k__BackingField;        // 0x1F0

        // Methods
        private UnityEngine.InputSystem.Controls.Vector2Control get_touchpad() { }
        private System.Void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_trigger() { }
        private System.Void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_back() { }
        private System.Void set_back(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed() { }
        private System.Void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_touchpadClicked() { }
        private System.Void set_touchpadClicked(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_touchpadTouched() { }
        private System.Void set_touchpadTouched(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity() { }
        private System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceAcceleration() { }
        private System.Void set_deviceAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularAcceleration() { }
        private System.Void set_deviceAngularAcceleration(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

}

namespace Unity.XR.OpenVR
{

    // TypeToken: 0x2000003
    public class OpenVRHMD : XRHMD
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;        // 0x1E0
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;        // 0x1E8
        private UnityEngine.InputSystem.Controls.Vector3Control <leftEyeVelocity>k__BackingField;        // 0x1F0
        private UnityEngine.InputSystem.Controls.Vector3Control <leftEyeAngularVelocity>k__BackingField;        // 0x1F8
        private UnityEngine.InputSystem.Controls.Vector3Control <rightEyeVelocity>k__BackingField;        // 0x200
        private UnityEngine.InputSystem.Controls.Vector3Control <rightEyeAngularVelocity>k__BackingField;        // 0x208
        private UnityEngine.InputSystem.Controls.Vector3Control <centerEyeVelocity>k__BackingField;        // 0x210
        private UnityEngine.InputSystem.Controls.Vector3Control <centerEyeAngularVelocity>k__BackingField;        // 0x218

        // Methods
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity() { }
        private System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity() { }
        private System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeVelocity() { }
        private System.Void set_leftEyeVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_leftEyeAngularVelocity() { }
        private System.Void set_leftEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeVelocity() { }
        private System.Void set_rightEyeVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_rightEyeAngularVelocity() { }
        private System.Void set_rightEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeVelocity() { }
        private System.Void set_centerEyeVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_centerEyeAngularVelocity() { }
        private System.Void set_centerEyeAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class OpenVRControllerWMR : XRController
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;        // 0x1B0
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;        // 0x1B8
        private UnityEngine.InputSystem.Controls.ButtonControl <touchpadClick>k__BackingField;        // 0x1C0
        private UnityEngine.InputSystem.Controls.ButtonControl <touchpadTouch>k__BackingField;        // 0x1C8
        private UnityEngine.InputSystem.Controls.ButtonControl <gripPressed>k__BackingField;        // 0x1D0
        private UnityEngine.InputSystem.Controls.ButtonControl <triggerPressed>k__BackingField;        // 0x1D8
        private UnityEngine.InputSystem.Controls.ButtonControl <menu>k__BackingField;        // 0x1E0
        private UnityEngine.InputSystem.Controls.AxisControl <trigger>k__BackingField;        // 0x1E8
        private UnityEngine.InputSystem.Controls.AxisControl <grip>k__BackingField;        // 0x1F0
        private UnityEngine.InputSystem.Controls.Vector2Control <touchpad>k__BackingField;        // 0x1F8
        private UnityEngine.InputSystem.Controls.Vector2Control <joystick>k__BackingField;        // 0x200

        // Methods
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity() { }
        private System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity() { }
        private System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_touchpadClick() { }
        private System.Void set_touchpadClick(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_touchpadTouch() { }
        private System.Void set_touchpadTouch(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed() { }
        private System.Void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed() { }
        private System.Void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_menu() { }
        private System.Void set_menu(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_trigger() { }
        private System.Void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_grip() { }
        private System.Void set_grip(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.Vector2Control get_touchpad() { }
        private System.Void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private UnityEngine.InputSystem.Controls.Vector2Control get_joystick() { }
        private System.Void set_joystick(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class ViveWand : XRControllerWithRumble
    {
        // Fields
        private UnityEngine.InputSystem.Controls.AxisControl <grip>k__BackingField;        // 0x1B0
        private UnityEngine.InputSystem.Controls.ButtonControl <gripPressed>k__BackingField;        // 0x1B8
        private UnityEngine.InputSystem.Controls.ButtonControl <primary>k__BackingField;        // 0x1C0
        private UnityEngine.InputSystem.Controls.ButtonControl <trackpadPressed>k__BackingField;        // 0x1C8
        private UnityEngine.InputSystem.Controls.ButtonControl <trackpadTouched>k__BackingField;        // 0x1D0
        private UnityEngine.InputSystem.Controls.Vector2Control <trackpad>k__BackingField;        // 0x1D8
        private UnityEngine.InputSystem.Controls.AxisControl <trigger>k__BackingField;        // 0x1E0
        private UnityEngine.InputSystem.Controls.ButtonControl <triggerPressed>k__BackingField;        // 0x1E8
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;        // 0x1F0
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;        // 0x1F8

        // Methods
        private UnityEngine.InputSystem.Controls.AxisControl get_grip() { }
        private System.Void set_grip(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed() { }
        private System.Void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_primary() { }
        private System.Void set_primary(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_trackpadPressed() { }
        private System.Void set_trackpadPressed(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_trackpadTouched() { }
        private System.Void set_trackpadTouched(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.Vector2Control get_trackpad() { }
        private System.Void set_trackpad(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_trigger() { }
        private System.Void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed() { }
        private System.Void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity() { }
        private System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity() { }
        private System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class ViveLighthouse : TrackedDevice
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class ViveTracker : TrackedDevice
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;        // 0x1B0
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;        // 0x1B8

        // Methods
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity() { }
        private System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity() { }
        private System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public class HandedViveTracker : ViveTracker
    {
        // Fields
        private UnityEngine.InputSystem.Controls.AxisControl <grip>k__BackingField;        // 0x1C0
        private UnityEngine.InputSystem.Controls.ButtonControl <gripPressed>k__BackingField;        // 0x1C8
        private UnityEngine.InputSystem.Controls.ButtonControl <primary>k__BackingField;        // 0x1D0
        private UnityEngine.InputSystem.Controls.ButtonControl <trackpadPressed>k__BackingField;        // 0x1D8
        private UnityEngine.InputSystem.Controls.ButtonControl <triggerPressed>k__BackingField;        // 0x1E0

        // Methods
        private UnityEngine.InputSystem.Controls.AxisControl get_grip() { }
        private System.Void set_grip(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed() { }
        private System.Void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_primary() { }
        private System.Void set_primary(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_trackpadPressed() { }
        private System.Void set_trackpadPressed(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed() { }
        private System.Void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class OpenVROculusTouchController : XRControllerWithRumble
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector2Control <thumbstick>k__BackingField;        // 0x1B0
        private UnityEngine.InputSystem.Controls.AxisControl <trigger>k__BackingField;        // 0x1B8
        private UnityEngine.InputSystem.Controls.AxisControl <grip>k__BackingField;        // 0x1C0
        private UnityEngine.InputSystem.Controls.ButtonControl <primaryButton>k__BackingField;        // 0x1C8
        private UnityEngine.InputSystem.Controls.ButtonControl <secondaryButton>k__BackingField;        // 0x1D0
        private UnityEngine.InputSystem.Controls.ButtonControl <gripPressed>k__BackingField;        // 0x1D8
        private UnityEngine.InputSystem.Controls.ButtonControl <triggerPressed>k__BackingField;        // 0x1E0
        private UnityEngine.InputSystem.Controls.ButtonControl <thumbstickClicked>k__BackingField;        // 0x1E8
        private UnityEngine.InputSystem.Controls.ButtonControl <thumbstickTouched>k__BackingField;        // 0x1F0
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;        // 0x1F8
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;        // 0x200

        // Methods
        private UnityEngine.InputSystem.Controls.Vector2Control get_thumbstick() { }
        private System.Void set_thumbstick(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_trigger() { }
        private System.Void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_grip() { }
        private System.Void set_grip(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_primaryButton() { }
        private System.Void set_primaryButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_secondaryButton() { }
        private System.Void set_secondaryButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed() { }
        private System.Void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed() { }
        private System.Void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_thumbstickClicked() { }
        private System.Void set_thumbstickClicked(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_thumbstickTouched() { }
        private System.Void set_thumbstickTouched(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity() { }
        private System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity() { }
        private System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.InputSystem
{

    // TypeToken: 0x2000015
    public interface IInputActionCollection : IEnumerable`1, IEnumerable
    {
        // Methods
        private System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }
        private System.Void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }
        private System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }
        private System.Void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }
        private System.Boolean Contains(UnityEngine.InputSystem.InputAction action) { }
        private System.Void Enable() { }
        private System.Void Disable() { }

    }

    // TypeToken: 0x2000016
    public interface IInputActionCollection2 : IInputActionCollection, IEnumerable`1, IEnumerable
    {
        // Methods
        private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings() { }
        private UnityEngine.InputSystem.InputAction FindAction(System.String actionNameOrId, System.Boolean throwIfNotFound) { }
        private System.Int32 FindBinding(UnityEngine.InputSystem.InputBinding mask, UnityEngine.InputSystem.InputAction& action) { }

    }

    // TypeToken: 0x2000017
    public interface IInputInteraction
    {
        // Methods
        private System.Void Process(UnityEngine.InputSystem.InputInteractionContext& context) { }
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000018
    public interface IInputInteraction`1 : IInputInteraction
    {
    }

    // TypeToken: 0x2000019
    public class InputInteraction
    {
        // Fields
        public static UnityEngine.InputSystem.Utilities.TypeTable s_Interactions;        // 0x0

        // Methods
        private System.Type GetValueType(System.Type interactionType) { }
        private System.String GetDisplayName(System.String interaction) { }
        private System.String GetDisplayName(System.Type interactionType) { }

    }

    // TypeToken: 0x200001A
    public class InputAction, ICloneable, IDisposable
    {
        // Fields
        private static readonly Unity.Profiling.ProfilerMarker k_InputActionEnableProfilerMarker;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker k_InputActionDisableProfilerMarker;        // 0x8
        private System.String m_Name;        // 0x10
        private UnityEngine.InputSystem.InputActionType m_Type;        // 0x18
        private System.String m_ExpectedControlType;        // 0x20
        private System.String m_Id;        // 0x28
        private System.String m_Processors;        // 0x30
        private System.String m_Interactions;        // 0x38
        private UnityEngine.InputSystem.InputBinding[] m_SingletonActionBindings;        // 0x40
        private UnityEngine.InputSystem.InputAction.ActionFlags m_Flags;        // 0x48
        private System.Nullable<UnityEngine.InputSystem.InputBinding> m_BindingMask;        // 0x50
        private System.Int32 m_BindingsStartIndex;        // 0xB0
        private System.Int32 m_BindingsCount;        // 0xB4
        private System.Int32 m_ControlStartIndex;        // 0xB8
        private System.Int32 m_ControlCount;        // 0xBC
        private System.Int32 m_ActionIndexInState;        // 0xC0
        private UnityEngine.InputSystem.InputActionMap m_ActionMap;        // 0xC8
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> m_OnStarted;        // 0xD0
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> m_OnCanceled;        // 0x120
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> m_OnPerformed;        // 0x170

        // Methods
        private System.String get_name() { }
        private UnityEngine.InputSystem.InputActionType get_type() { }
        private System.Guid get_id() { }
        private System.Guid get_idDontGenerate() { }
        private System.String get_expectedControlType() { }
        private System.Void set_expectedControlType(System.String value) { }
        private System.String get_processors() { }
        private System.String get_interactions() { }
        private UnityEngine.InputSystem.InputActionMap get_actionMap() { }
        private System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }
        private System.Void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> get_bindings() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_controls() { }
        private UnityEngine.InputSystem.InputActionPhase get_phase() { }
        private System.Boolean get_inProgress() { }
        private System.Boolean get_enabled() { }
        private System.Void add_started(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }
        private System.Void remove_started(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }
        private System.Void add_canceled(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }
        private System.Void remove_canceled(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }
        private System.Void add_performed(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }
        private System.Void remove_performed(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }
        private System.Boolean get_triggered() { }
        private UnityEngine.InputSystem.InputControl get_activeControl() { }
        private System.Type get_activeValueType() { }
        private System.Boolean get_wantsInitialStateCheck() { }
        private System.Void set_wantsInitialStateCheck(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name, UnityEngine.InputSystem.InputActionType type, System.String binding, System.String interactions, System.String processors, System.String expectedControlType) { }
        private System.Void Dispose() { }
        private System.String ToString() { }
        private System.Void Enable() { }
        private System.Void Disable() { }
        private UnityEngine.InputSystem.InputAction Clone() { }
        private System.Object System.ICloneable.Clone() { }
        private TValue ReadValue() { }
        private System.Object ReadValueAsObject() { }
        private System.Single GetControlMagnitude() { }
        private System.Void Reset() { }
        private System.Boolean IsPressed() { }
        private System.Boolean IsInProgress() { }
        private System.Int32 ExpectedFrame() { }
        private System.Boolean WasPressedThisFrame() { }
        private System.Boolean WasPressedThisDynamicUpdate() { }
        private System.Boolean WasReleasedThisFrame() { }
        private System.Boolean WasReleasedThisDynamicUpdate() { }
        private System.Boolean WasPerformedThisFrame() { }
        private System.Boolean WasPerformedThisDynamicUpdate() { }
        private System.Boolean WasCompletedThisFrame() { }
        private System.Boolean WasCompletedThisDynamicUpdate() { }
        private System.Single GetTimeoutCompletionPercentage() { }
        private System.Boolean get_isSingletonAction() { }
        private UnityEngine.InputSystem.InputActionState.TriggerState get_currentState() { }
        private System.String MakeSureIdIsInPlace() { }
        private System.Void GenerateId() { }
        private UnityEngine.InputSystem.InputActionMap GetOrCreateActionMap() { }
        private System.Void CreateInternalActionMapForSingletonAction() { }
        private System.Void RequestInitialStateCheckOnEnabledAction() { }
        private System.Boolean ActiveControlIsValid(UnityEngine.InputSystem.InputControl control) { }
        private System.Nullable<UnityEngine.InputSystem.InputBinding> FindEffectiveBindingMask() { }
        private System.Int32 BindingIndexOnActionToBindingIndexOnMap(System.Int32 indexOfBindingOnAction) { }
        private System.Int32 BindingIndexOnMapToBindingIndexOnAction(System.Int32 indexOfBindingOnMap) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200001D
    public class InputActionAsset : ScriptableObject, IInputActionCollection2, IInputActionCollection, IEnumerable`1, IEnumerable
    {
        // Fields
        public static System.String Extension;        // 0x0
        private static System.String kDefaultAssetLayoutJson;        // 0x0
        private UnityEngine.InputSystem.InputActionMap[] m_ActionMaps;        // 0x18
        private UnityEngine.InputSystem.InputControlScheme[] m_ControlSchemes;        // 0x20
        private UnityEngine.InputSystem.InputActionState m_SharedStateForAllMaps;        // 0x28
        private System.Nullable<UnityEngine.InputSystem.InputBinding> m_BindingMask;        // 0x30
        private System.Int32 m_ParameterOverridesCount;        // 0x90
        private UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[] m_ParameterOverrides;        // 0x98
        private UnityEngine.InputSystem.InputActionMap.DeviceArray m_Devices;        // 0xA0

        // Methods
        private System.Boolean get_enabled() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputActionMap> get_actionMaps() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings() { }
        private System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }
        private System.Void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }
        private System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }
        private System.Void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }
        private UnityEngine.InputSystem.InputAction get_Item(System.String actionNameOrId) { }
        private System.String ToJson() { }
        private System.Void LoadFromJson(System.String json) { }
        private UnityEngine.InputSystem.InputActionAsset FromJson(System.String json) { }
        private UnityEngine.InputSystem.InputAction FindAction(System.String actionNameOrId, System.Boolean throwIfNotFound) { }
        private System.Int32 FindBinding(UnityEngine.InputSystem.InputBinding mask, UnityEngine.InputSystem.InputAction& action) { }
        private UnityEngine.InputSystem.InputActionMap FindActionMap(System.String nameOrId, System.Boolean throwIfNotFound) { }
        private UnityEngine.InputSystem.InputActionMap FindActionMap(System.Guid id) { }
        private UnityEngine.InputSystem.InputAction FindAction(System.Guid guid) { }
        private System.Int32 FindControlSchemeIndex(System.String name) { }
        private System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlScheme(System.String name) { }
        private System.Boolean IsUsableWithDevice(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void Enable() { }
        private System.Void Disable() { }
        private System.Boolean Contains(UnityEngine.InputSystem.InputAction action) { }
        private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void MarkAsDirty() { }
        private System.Boolean IsEmpty() { }
        private System.Void OnWantToChangeSetup() { }
        private System.Void OnSetupChanged() { }
        private System.Void ReResolveIfNecessary(System.Boolean fullResolve) { }
        private System.Void ResolveBindingsIfNecessary() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000023
    public struct InputActionChange
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputActionChange ActionEnabled;        // 0x0
        public static UnityEngine.InputSystem.InputActionChange ActionDisabled;        // 0x0
        public static UnityEngine.InputSystem.InputActionChange ActionMapEnabled;        // 0x0
        public static UnityEngine.InputSystem.InputActionChange ActionMapDisabled;        // 0x0
        public static UnityEngine.InputSystem.InputActionChange ActionStarted;        // 0x0
        public static UnityEngine.InputSystem.InputActionChange ActionPerformed;        // 0x0
        public static UnityEngine.InputSystem.InputActionChange ActionCanceled;        // 0x0
        public static UnityEngine.InputSystem.InputActionChange BoundControlsAboutToChange;        // 0x0
        public static UnityEngine.InputSystem.InputActionChange BoundControlsChanged;        // 0x0

    }

    // TypeToken: 0x2000024
    public class InputActionMap, ICloneable, ISerializationCallbackReceiver, IInputActionCollection2, IInputActionCollection, IEnumerable`1, IEnumerable, IDisposable
    {
        // Fields
        private static readonly Unity.Profiling.ProfilerMarker k_ResolveBindingsProfilerMarker;        // 0x0
        private System.String m_Name;        // 0x10
        private System.String m_Id;        // 0x18
        private UnityEngine.InputSystem.InputActionAsset m_Asset;        // 0x20
        private UnityEngine.InputSystem.InputAction[] m_Actions;        // 0x28
        private UnityEngine.InputSystem.InputBinding[] m_Bindings;        // 0x30
        private UnityEngine.InputSystem.InputBinding[] m_BindingsForEachAction;        // 0x38
        private UnityEngine.InputSystem.InputControl[] m_ControlsForEachAction;        // 0x40
        private System.Int32 m_EnabledActionsCount;        // 0x48
        private UnityEngine.InputSystem.InputAction m_SingletonAction;        // 0x50
        private System.Int32 m_MapIndexInState;        // 0x58
        private UnityEngine.InputSystem.InputActionState m_State;        // 0x60
        private System.Nullable<UnityEngine.InputSystem.InputBinding> m_BindingMask;        // 0x68
        private UnityEngine.InputSystem.InputActionMap.Flags m_Flags;        // 0xC8
        private System.Int32 m_ParameterOverridesCount;        // 0xCC
        private UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[] m_ParameterOverrides;        // 0xD0
        private UnityEngine.InputSystem.InputActionMap.DeviceArray m_Devices;        // 0xD8
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> m_ActionCallbacks;        // 0xE8
        private System.Collections.Generic.Dictionary<System.String,System.Int32> m_ActionIndexByNameOrId;        // 0x138
        private static System.Int32 s_DeferBindingResolution;        // 0x8
        private static System.Boolean s_NeedToResolveBindings;        // 0xC

        // Methods
        private System.String get_name() { }
        private UnityEngine.InputSystem.InputActionAsset get_asset() { }
        private System.Guid get_id() { }
        private System.Guid get_idDontGenerate() { }
        private System.Boolean get_enabled() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputAction> get_actions() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> get_bindings() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> UnityEngine.InputSystem.IInputActionCollection2.get_bindings() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }
        private System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }
        private System.Void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }
        private System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }
        private System.Void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }
        private UnityEngine.InputSystem.InputAction get_Item(System.String actionNameOrId) { }
        private System.Void add_actionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }
        private System.Void remove_actionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name) { }
        private System.Void Dispose() { }
        private System.Int32 FindActionIndex(System.String nameOrId) { }
        private System.Void SetUpActionLookupTable() { }
        private System.Void ClearActionLookupTable() { }
        private System.Int32 FindActionIndex(System.Guid id) { }
        private UnityEngine.InputSystem.InputAction FindAction(System.String actionNameOrId, System.Boolean throwIfNotFound) { }
        private UnityEngine.InputSystem.InputAction FindAction(System.Guid id) { }
        private System.Boolean IsUsableWithDevice(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void Enable() { }
        private System.Void Disable() { }
        private UnityEngine.InputSystem.InputActionMap Clone() { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean Contains(UnityEngine.InputSystem.InputAction action) { }
        private System.String ToString() { }
        private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Boolean get_needToResolveBindings() { }
        private System.Void set_needToResolveBindings(System.Boolean value) { }
        private System.Boolean get_bindingResolutionNeedsFullReResolve() { }
        private System.Void set_bindingResolutionNeedsFullReResolve(System.Boolean value) { }
        private System.Boolean get_controlsForEachActionInitialized() { }
        private System.Void set_controlsForEachActionInitialized(System.Boolean value) { }
        private System.Boolean get_bindingsForEachActionInitialized() { }
        private System.Void set_bindingsForEachActionInitialized(System.Boolean value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputBinding> GetBindingsForSingleAction(UnityEngine.InputSystem.InputAction action) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> GetControlsForSingleAction(UnityEngine.InputSystem.InputAction action) { }
        private System.Void SetUpPerActionControlAndBindingArrays() { }
        private System.Void OnWantToChangeSetup() { }
        private System.Void OnSetupChanged() { }
        private System.Void OnBindingModified() { }
        private System.Void ClearCachedActionData(System.Boolean onlyControls) { }
        private System.Void GenerateId() { }
        private System.Boolean LazyResolveBindings(System.Boolean fullResolve) { }
        private System.Boolean ResolveBindingsIfNecessary() { }
        private System.Void ResolveBindings() { }
        private System.Int32 FindBinding(UnityEngine.InputSystem.InputBinding mask, UnityEngine.InputSystem.InputAction& action) { }
        private System.Int32 FindBindingRelativeToMap(UnityEngine.InputSystem.InputBinding mask) { }
        private UnityEngine.InputSystem.InputActionMap[] FromJson(System.String json) { }
        private System.String ToJson(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionMap> maps) { }
        private System.String ToJson() { }
        private System.Void OnBeforeSerialize() { }
        private System.Void OnAfterDeserialize() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000030
    public class InputActionRebindingExtensions
    {
        // Fields
        private static UnityEngine.InputSystem.InputActionRebindingExtensions.DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper;        // 0x0

        // Methods
        private System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(UnityEngine.InputSystem.InputAction action, System.String name, UnityEngine.InputSystem.InputBinding bindingMask) { }
        private System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameterOverride) { }
        private System.Nullable<UnityEngine.InputSystem.Utilities.PrimitiveValue> GetParameterValue(UnityEngine.InputSystem.InputAction action, System.String name, System.Int32 bindingIndex) { }
        private System.Nullable<TValue> GetParameterValue(UnityEngine.InputSystem.InputAction action, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, UnityEngine.InputSystem.InputBinding bindingMask) { }
        private System.Void ApplyParameterOverride(UnityEngine.InputSystem.InputAction action, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, UnityEngine.InputSystem.InputBinding bindingMask) { }
        private System.Void ApplyParameterOverride(UnityEngine.InputSystem.InputActionMap actionMap, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, UnityEngine.InputSystem.InputBinding bindingMask) { }
        private System.Void ApplyParameterOverride(UnityEngine.InputSystem.InputActionAsset asset, System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, TValue value, UnityEngine.InputSystem.InputBinding bindingMask) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride ExtractParameterOverride(System.Linq.Expressions.Expression<System.Func<TObject,TValue>> expr, UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.Utilities.PrimitiveValue value) { }
        private System.Void ApplyParameterOverride(UnityEngine.InputSystem.InputActionMap actionMap, System.String name, UnityEngine.InputSystem.Utilities.PrimitiveValue value, UnityEngine.InputSystem.InputBinding bindingMask) { }
        private System.Void ApplyParameterOverride(UnityEngine.InputSystem.InputActionAsset asset, System.String name, UnityEngine.InputSystem.Utilities.PrimitiveValue value, UnityEngine.InputSystem.InputBinding bindingMask) { }
        private System.Void ApplyParameterOverride(UnityEngine.InputSystem.InputAction action, System.String name, UnityEngine.InputSystem.Utilities.PrimitiveValue value, UnityEngine.InputSystem.InputBinding bindingMask) { }
        private System.Void ApplyParameterOverride(UnityEngine.InputSystem.InputAction action, System.String name, UnityEngine.InputSystem.Utilities.PrimitiveValue value, System.Int32 bindingIndex) { }
        private System.Void ApplyParameterOverride(UnityEngine.InputSystem.InputActionState state, System.Int32 mapIndex, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[]& parameterOverrides, System.Int32& parameterOverridesCount, UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameterOverride) { }
        private System.Int32 GetBindingIndex(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding bindingMask) { }
        private System.Int32 GetBindingIndex(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding bindingMask) { }
        private System.Int32 GetBindingIndex(UnityEngine.InputSystem.InputAction action, System.String group, System.String path) { }
        private System.Nullable<UnityEngine.InputSystem.InputBinding> GetBindingForControl(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputControl control) { }
        private System.Int32 GetBindingIndexForControl(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputControl control) { }
        private System.String GetBindingDisplayString(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options, System.String group) { }
        private System.String GetBindingDisplayString(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options) { }
        private System.String GetBindingDisplayString(UnityEngine.InputSystem.InputAction action, System.Int32 bindingIndex, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options) { }
        private System.String GetBindingDisplayString(UnityEngine.InputSystem.InputAction action, System.Int32 bindingIndex, System.String& deviceLayoutName, System.String& controlPath, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options) { }
        private System.Void ApplyBindingOverride(UnityEngine.InputSystem.InputAction action, System.String newPath, System.String group, System.String path) { }
        private System.Void ApplyBindingOverride(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding bindingOverride) { }
        private System.Void ApplyBindingOverride(UnityEngine.InputSystem.InputAction action, System.Int32 bindingIndex, UnityEngine.InputSystem.InputBinding bindingOverride) { }
        private System.Void ApplyBindingOverride(UnityEngine.InputSystem.InputAction action, System.Int32 bindingIndex, System.String path) { }
        private System.Int32 ApplyBindingOverride(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding bindingOverride) { }
        private System.Void ApplyBindingOverride(UnityEngine.InputSystem.InputActionMap actionMap, System.Int32 bindingIndex, UnityEngine.InputSystem.InputBinding bindingOverride) { }
        private System.Void RemoveBindingOverride(UnityEngine.InputSystem.InputAction action, System.Int32 bindingIndex) { }
        private System.Void RemoveBindingOverride(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding bindingMask) { }
        private System.Void RemoveBindingOverride(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding bindingMask) { }
        private System.Void RemoveAllBindingOverrides(UnityEngine.InputSystem.IInputActionCollection2 actions) { }
        private System.Void RemoveAllBindingOverrides(UnityEngine.InputSystem.InputAction action) { }
        private System.Void ApplyBindingOverrides(UnityEngine.InputSystem.InputActionMap actionMap, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> overrides) { }
        private System.Void RemoveBindingOverrides(UnityEngine.InputSystem.InputActionMap actionMap, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> overrides) { }
        private System.Int32 ApplyBindingOverridesOnMatchingControls(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputControl control) { }
        private System.Int32 ApplyBindingOverridesOnMatchingControls(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputControl control) { }
        private System.String SaveBindingOverridesAsJson(UnityEngine.InputSystem.IInputActionCollection2 actions) { }
        private System.String SaveBindingOverridesAsJson(UnityEngine.InputSystem.InputAction action) { }
        private System.Void AddBindingOverrideJsonTo(UnityEngine.InputSystem.IInputActionCollection2 actions, UnityEngine.InputSystem.InputBinding binding, System.Collections.Generic.List<UnityEngine.InputSystem.InputActionMap.BindingOverrideJson> list, UnityEngine.InputSystem.InputAction action) { }
        private System.Void LoadBindingOverridesFromJson(UnityEngine.InputSystem.IInputActionCollection2 actions, System.String json, System.Boolean removeExisting) { }
        private System.Void LoadBindingOverridesFromJson(UnityEngine.InputSystem.InputAction action, System.String json, System.Boolean removeExisting) { }
        private System.Void LoadBindingOverridesFromJsonInternal(UnityEngine.InputSystem.IInputActionCollection2 actions, System.String json) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation PerformInteractiveRebinding(UnityEngine.InputSystem.InputAction action, System.Int32 bindingIndex) { }
        private UnityEngine.InputSystem.InputActionRebindingExtensions.DeferBindingResolutionWrapper DeferBindingResolution() { }

    }

    // TypeToken: 0x200003A
    public struct InputActionPhase
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputActionPhase Disabled;        // 0x0
        public static UnityEngine.InputSystem.InputActionPhase Waiting;        // 0x0
        public static UnityEngine.InputSystem.InputActionPhase Started;        // 0x0
        public static UnityEngine.InputSystem.InputActionPhase Performed;        // 0x0
        public static UnityEngine.InputSystem.InputActionPhase Canceled;        // 0x0

    }

    // TypeToken: 0x200003B
    public struct InputActionProperty, IEquatable`1, IEquatable`1, IEquatable`1
    {
        // Fields
        private System.Boolean m_UseReference;        // 0x10
        private UnityEngine.InputSystem.InputAction m_Action;        // 0x18
        private UnityEngine.InputSystem.InputActionReference m_Reference;        // 0x20

        // Methods
        private UnityEngine.InputSystem.InputAction get_action() { }
        private UnityEngine.InputSystem.InputActionReference get_reference() { }
        private UnityEngine.InputSystem.InputAction get_serializedAction() { }
        private UnityEngine.InputSystem.InputActionReference get_serializedReference() { }
        private System.Void .ctor(UnityEngine.InputSystem.InputAction action) { }
        private System.Void .ctor(UnityEngine.InputSystem.InputActionReference reference) { }
        private System.Boolean Equals(UnityEngine.InputSystem.InputActionProperty other) { }
        private System.Boolean Equals(UnityEngine.InputSystem.InputAction other) { }
        private System.Boolean Equals(UnityEngine.InputSystem.InputActionReference other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.InputActionProperty left, UnityEngine.InputSystem.InputActionProperty right) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.InputActionProperty left, UnityEngine.InputSystem.InputActionProperty right) { }

    }

    // TypeToken: 0x200003C
    public class InputActionReference : ScriptableObject
    {
        // Fields
        private UnityEngine.InputSystem.InputActionAsset m_Asset;        // 0x18
        private System.String m_ActionId;        // 0x20
        private UnityEngine.InputSystem.InputAction m_Action;        // 0x28

        // Methods
        private UnityEngine.InputSystem.InputActionAsset get_asset() { }
        private UnityEngine.InputSystem.InputAction get_action() { }
        private System.Void Set(UnityEngine.InputSystem.InputAction action) { }
        private System.Void Set(UnityEngine.InputSystem.InputActionAsset asset, System.String mapName, System.String actionName) { }
        private System.Void SetInternal(UnityEngine.InputSystem.InputActionAsset asset, UnityEngine.InputSystem.InputAction action) { }
        private System.String ToString() { }
        private System.String GetDisplayName(UnityEngine.InputSystem.InputAction action) { }
        private System.String ToDisplayName() { }
        private UnityEngine.InputSystem.InputAction op_Implicit(UnityEngine.InputSystem.InputActionReference reference) { }
        private UnityEngine.InputSystem.InputActionReference Create(UnityEngine.InputSystem.InputAction action) { }
        private System.Void ResetCachedAction() { }
        private UnityEngine.InputSystem.InputAction ToInputAction() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003D
    public class InputActionSetupExtensions
    {
        // Methods
        private UnityEngine.InputSystem.InputActionMap AddActionMap(UnityEngine.InputSystem.InputActionAsset asset, System.String name) { }
        private System.Void AddActionMap(UnityEngine.InputSystem.InputActionAsset asset, UnityEngine.InputSystem.InputActionMap map) { }
        private System.Void RemoveActionMap(UnityEngine.InputSystem.InputActionAsset asset, UnityEngine.InputSystem.InputActionMap map) { }
        private System.Void RemoveActionMap(UnityEngine.InputSystem.InputActionAsset asset, System.String nameOrId) { }
        private UnityEngine.InputSystem.InputAction AddAction(UnityEngine.InputSystem.InputActionMap map, System.String name, UnityEngine.InputSystem.InputActionType type, System.String binding, System.String interactions, System.String processors, System.String groups, System.String expectedControlLayout) { }
        private System.Void RemoveAction(UnityEngine.InputSystem.InputAction action) { }
        private System.Void RemoveAction(UnityEngine.InputSystem.InputActionAsset asset, System.String nameOrId) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputAction action, System.String path, System.String interactions, System.String processors, System.String groups) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputControl control) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding binding) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputActionMap actionMap, System.String path, System.String interactions, System.String groups, System.String action, System.String processors) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputActionMap actionMap, System.String path, UnityEngine.InputSystem.InputAction action, System.String interactions, System.String groups) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputActionMap actionMap, System.String path, System.Guid action, System.String interactions, System.String groups) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax AddBinding(UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding binding) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.CompositeSyntax AddCompositeBinding(UnityEngine.InputSystem.InputAction action, System.String composite, System.String interactions, System.String processors) { }
        private System.Int32 AddBindingInternal(UnityEngine.InputSystem.InputActionMap map, UnityEngine.InputSystem.InputBinding binding, System.Int32 bindingIndex) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(UnityEngine.InputSystem.InputAction action, System.Int32 index) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(UnityEngine.InputSystem.InputAction action, System.String name) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(UnityEngine.InputSystem.InputActionMap actionMap, System.Int32 index) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithId(UnityEngine.InputSystem.InputAction action, System.String id) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithId(UnityEngine.InputSystem.InputAction action, System.Guid id) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithGroup(UnityEngine.InputSystem.InputAction action, System.String group) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBindingWithPath(UnityEngine.InputSystem.InputAction action, System.String path) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeBinding(UnityEngine.InputSystem.InputAction action, UnityEngine.InputSystem.InputBinding match) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.BindingSyntax ChangeCompositeBinding(UnityEngine.InputSystem.InputAction action, System.String compositeName) { }
        private System.Void Rename(UnityEngine.InputSystem.InputAction action, System.String newName) { }
        private System.Void AddControlScheme(UnityEngine.InputSystem.InputActionAsset asset, UnityEngine.InputSystem.InputControlScheme controlScheme) { }
        private UnityEngine.InputSystem.InputActionSetupExtensions.ControlSchemeSyntax AddControlScheme(UnityEngine.InputSystem.InputActionAsset asset, System.String name) { }
        private System.Void RemoveControlScheme(UnityEngine.InputSystem.InputActionAsset asset, System.String name) { }
        private UnityEngine.InputSystem.InputControlScheme WithBindingGroup(UnityEngine.InputSystem.InputControlScheme scheme, System.String bindingGroup) { }
        private UnityEngine.InputSystem.InputControlScheme WithDevice(UnityEngine.InputSystem.InputControlScheme scheme, System.String controlPath, System.Boolean required) { }
        private UnityEngine.InputSystem.InputControlScheme WithRequiredDevice(UnityEngine.InputSystem.InputControlScheme scheme, System.String controlPath) { }
        private UnityEngine.InputSystem.InputControlScheme WithOptionalDevice(UnityEngine.InputSystem.InputControlScheme scheme, System.String controlPath) { }
        private UnityEngine.InputSystem.InputControlScheme OrWithRequiredDevice(UnityEngine.InputSystem.InputControlScheme scheme, System.String controlPath) { }
        private UnityEngine.InputSystem.InputControlScheme OrWithOptionalDevice(UnityEngine.InputSystem.InputControlScheme scheme, System.String controlPath) { }

    }

    // TypeToken: 0x2000042
    public class InputActionState, IInputStateChangeMonitor, ICloneable, IDisposable
    {
        // Fields
        public static System.Int32 kInvalidIndex;        // 0x0
        public UnityEngine.InputSystem.InputActionMap[] maps;        // 0x10
        public UnityEngine.InputSystem.InputControl[] controls;        // 0x18
        public UnityEngine.InputSystem.IInputInteraction[] interactions;        // 0x20
        public UnityEngine.InputSystem.InputProcessor[] processors;        // 0x28
        public UnityEngine.InputSystem.InputBindingComposite[] composites;        // 0x30
        public System.Int32 totalProcessorCount;        // 0x38
        public UnityEngine.InputSystem.InputActionState.UnmanagedMemory memory;        // 0x40
        private System.Boolean m_OnBeforeUpdateHooked;        // 0xC0
        private System.Boolean m_OnAfterUpdateHooked;        // 0xC1
        private System.Boolean m_InProcessControlStateChange;        // 0xC2
        private UnityEngine.InputSystem.LowLevel.InputEventPtr m_CurrentlyProcessingThisEvent;        // 0xC8
        private System.Action m_OnBeforeUpdateDelegate;        // 0xD0
        private System.Action m_OnAfterUpdateDelegate;        // 0xD8
        private static readonly Unity.Profiling.ProfilerMarker k_InputInitialActionStateCheckMarker;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker k_InputActionResolveConflictMarker;        // 0x8
        private static readonly Unity.Profiling.ProfilerMarker k_InputActionCallbackMarker;        // 0x10
        private static readonly Unity.Profiling.ProfilerMarker k_InputOnActionChangeMarker;        // 0x18
        private static readonly Unity.Profiling.ProfilerMarker k_InputOnDeviceChangeMarker;        // 0x20
        private static UnityEngine.InputSystem.InputActionState.GlobalState s_GlobalState;        // 0x28

        // Methods
        private System.Int32 get_totalCompositeCount() { }
        private System.Int32 get_totalMapCount() { }
        private System.Int32 get_totalActionCount() { }
        private System.Int32 get_totalBindingCount() { }
        private System.Int32 get_totalInteractionCount() { }
        private System.Int32 get_totalControlCount() { }
        private UnityEngine.InputSystem.InputActionState.ActionMapIndices* get_mapIndices() { }
        private UnityEngine.InputSystem.InputActionState.TriggerState* get_actionStates() { }
        private UnityEngine.InputSystem.InputActionState.BindingState* get_bindingStates() { }
        private UnityEngine.InputSystem.InputActionState.InteractionState* get_interactionStates() { }
        private System.Int32* get_controlIndexToBindingIndex() { }
        private System.UInt16* get_controlGroupingAndComplexity() { }
        private System.Single* get_controlMagnitudes() { }
        private System.UInt32* get_enabledControls() { }
        private System.Boolean get_isProcessingControlStateChange() { }
        private System.Void Initialize(UnityEngine.InputSystem.InputBindingResolver resolver) { }
        private System.Void ComputeControlGroupingIfNecessary() { }
        private System.Void ClaimDataFrom(UnityEngine.InputSystem.InputBindingResolver resolver) { }
        private System.Void Finalize() { }
        private System.Void Dispose() { }
        private System.Void Destroy(System.Boolean isFinalizing) { }
        private UnityEngine.InputSystem.InputActionState Clone() { }
        private System.Object System.ICloneable.Clone() { }
        private System.Boolean IsUsingDevice(UnityEngine.InputSystem.InputDevice device) { }
        private System.Boolean CanUseDevice(UnityEngine.InputSystem.InputDevice device) { }
        private System.Boolean HasEnabledActions() { }
        private System.Void FinishBindingCompositeSetups() { }
        private System.Void PrepareForBindingReResolution(System.Boolean needFullResolve, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl>& activeControls, System.Boolean& hasEnabledActions) { }
        private System.Void FinishBindingResolution(System.Boolean hasEnabledActions, UnityEngine.InputSystem.InputActionState.UnmanagedMemory oldMemory, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, System.Boolean isFullResolve) { }
        private System.Void RestoreActionStatesAfterReResolvingBindings(UnityEngine.InputSystem.InputActionState.UnmanagedMemory oldState, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> activeControls, System.Boolean isFullResolve) { }
        private System.Boolean IsActiveControl(System.Int32 bindingIndex, System.Int32 controlIndex) { }
        private System.Int32 FindControlIndexOnBinding(System.Int32 bindingIndex, UnityEngine.InputSystem.InputControl control) { }
        private System.Void ResetActionStatesDrivenBy(UnityEngine.InputSystem.InputDevice device) { }
        private System.Boolean IsActionBoundToControlFromDevice(UnityEngine.InputSystem.InputDevice device, System.Int32 actionIndex) { }
        private System.Void ResetActionState(System.Int32 actionIndex, UnityEngine.InputSystem.InputActionPhase toPhase, System.Boolean hardReset) { }
        private UnityEngine.InputSystem.InputActionState.TriggerState& FetchActionState(UnityEngine.InputSystem.InputAction action) { }
        private UnityEngine.InputSystem.InputActionState.ActionMapIndices FetchMapIndices(UnityEngine.InputSystem.InputActionMap map) { }
        private System.Void EnableAllActions(UnityEngine.InputSystem.InputActionMap map) { }
        private System.Void EnableControls(UnityEngine.InputSystem.InputActionMap map) { }
        private System.Void EnableSingleAction(UnityEngine.InputSystem.InputAction action) { }
        private System.Void EnableControls(UnityEngine.InputSystem.InputAction action) { }
        private System.Void DisableAllActions(UnityEngine.InputSystem.InputActionMap map) { }
        private System.Void DisableControls(UnityEngine.InputSystem.InputActionMap map) { }
        private System.Void DisableSingleAction(UnityEngine.InputSystem.InputAction action) { }
        private System.Void DisableControls(UnityEngine.InputSystem.InputAction action) { }
        private System.Void EnableControls(System.Int32 mapIndex, System.Int32 controlStartIndex, System.Int32 numControls) { }
        private System.Void DisableControls(System.Int32 mapIndex, System.Int32 controlStartIndex, System.Int32 numControls) { }
        private System.Void SetInitialStateCheckPending(System.Int32 actionIndex, System.Boolean value) { }
        private System.Void SetInitialStateCheckPending(UnityEngine.InputSystem.InputActionState.BindingState* bindingStatePtr, System.Boolean value) { }
        private System.Boolean IsControlEnabled(System.Int32 controlIndex) { }
        private System.Void SetControlEnabled(System.Int32 controlIndex, System.Boolean state) { }
        private System.Void HookOnBeforeUpdate() { }
        private System.Void UnhookOnBeforeUpdate() { }
        private System.Void OnBeforeInitialUpdate() { }
        private System.Void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Int64 mapControlAndBindingIndex) { }
        private System.Void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, System.Double time, System.Int64 mapControlAndBindingIndex, System.Int32 interactionIndex) { }
        private System.Int64 ToCombinedMapAndControlAndBindingIndex(System.Int32 mapIndex, System.Int32 controlIndex, System.Int32 bindingIndex) { }
        private System.Void SplitUpMapAndControlAndBindingIndex(System.Int64 mapControlAndBindingIndex, System.Int32& mapIndex, System.Int32& controlIndex, System.Int32& bindingIndex) { }
        private System.Int32 GetComplexityFromMonitorIndex(System.Int64 mapControlAndBindingIndex) { }
        private System.Void ProcessControlStateChange(System.Int32 mapIndex, System.Int32 controlIndex, System.Int32 bindingIndex, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void ProcessButtonState(UnityEngine.InputSystem.InputActionState.TriggerState& trigger, System.Int32 actionIndex, UnityEngine.InputSystem.InputActionState.BindingState* bindingStatePtr) { }
        private System.Boolean ShouldIgnoreInputOnCompositeBinding(UnityEngine.InputSystem.InputActionState.BindingState* binding, UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr) { }
        private System.Boolean IsConflictingInput(UnityEngine.InputSystem.InputActionState.TriggerState& trigger, System.Int32 actionIndex) { }
        private System.UInt16 GetActionBindingStartIndexAndCount(System.Int32 actionIndex, System.UInt16& bindingCount) { }
        private System.Void ProcessDefaultInteraction(UnityEngine.InputSystem.InputActionState.TriggerState& trigger, System.Int32 actionIndex) { }
        private System.Void ProcessInteractions(UnityEngine.InputSystem.InputActionState.TriggerState& trigger, System.Int32 interactionStartIndex, System.Int32 interactionCount) { }
        private System.Void ProcessTimeout(System.Double time, System.Int32 mapIndex, System.Int32 controlIndex, System.Int32 bindingIndex, System.Int32 interactionIndex) { }
        private System.Void SetTotalTimeoutCompletionTime(System.Single seconds, UnityEngine.InputSystem.InputActionState.TriggerState& trigger) { }
        private System.Void StartTimeout(System.Single seconds, UnityEngine.InputSystem.InputActionState.TriggerState& trigger) { }
        private System.Void StopTimeout(System.Int32 interactionIndex) { }
        private System.Void ChangePhaseOfInteraction(UnityEngine.InputSystem.InputActionPhase newPhase, UnityEngine.InputSystem.InputActionState.TriggerState& trigger, UnityEngine.InputSystem.InputActionPhase phaseAfterPerformed, UnityEngine.InputSystem.InputActionPhase phaseAfterCanceled, System.Boolean processNextInteractionOnCancel) { }
        private System.Boolean ChangePhaseOfAction(UnityEngine.InputSystem.InputActionPhase newPhase, UnityEngine.InputSystem.InputActionState.TriggerState& trigger, UnityEngine.InputSystem.InputActionPhase phaseAfterPerformedOrCanceled) { }
        private System.Void ChangePhaseOfActionInternal(System.Int32 actionIndex, UnityEngine.InputSystem.InputActionState.TriggerState* actionState, UnityEngine.InputSystem.InputActionPhase newPhase, UnityEngine.InputSystem.InputActionState.TriggerState& trigger, System.Boolean isDisablingAction) { }
        private System.Void CallActionListeners(System.Int32 actionIndex, UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputActionPhase phase, UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>>& listeners, System.String callbackName) { }
        private System.Object GetActionOrNoneString(UnityEngine.InputSystem.InputActionState.TriggerState& trigger) { }
        private UnityEngine.InputSystem.InputAction GetActionOrNull(System.Int32 bindingIndex) { }
        private UnityEngine.InputSystem.InputAction GetActionOrNull(UnityEngine.InputSystem.InputActionState.TriggerState& trigger) { }
        private UnityEngine.InputSystem.InputControl GetControl(UnityEngine.InputSystem.InputActionState.TriggerState& trigger) { }
        private UnityEngine.InputSystem.IInputInteraction GetInteractionOrNull(UnityEngine.InputSystem.InputActionState.TriggerState& trigger) { }
        private System.Int32 GetBindingIndexInMap(System.Int32 bindingIndex) { }
        private System.Int32 GetBindingIndexInState(System.Int32 mapIndex, System.Int32 bindingIndexInMap) { }
        private UnityEngine.InputSystem.InputActionState.BindingState& GetBindingState(System.Int32 bindingIndex) { }
        private UnityEngine.InputSystem.InputBinding& GetBinding(System.Int32 bindingIndex) { }
        private UnityEngine.InputSystem.InputActionMap GetActionMap(System.Int32 bindingIndex) { }
        private System.Void ResetInteractionStateAndCancelIfNecessary(System.Int32 mapIndex, System.Int32 bindingIndex, System.Int32 interactionIndex, UnityEngine.InputSystem.InputActionPhase phaseAfterCanceled) { }
        private System.Void ResetInteractionState(System.Int32 interactionIndex) { }
        private System.Int32 GetValueSizeInBytes(System.Int32 bindingIndex, System.Int32 controlIndex) { }
        private System.Type GetValueType(System.Int32 bindingIndex, System.Int32 controlIndex) { }
        private System.Boolean IsActuated(UnityEngine.InputSystem.InputActionState.TriggerState& trigger, System.Single threshold) { }
        private System.Void ReadValue(System.Int32 bindingIndex, System.Int32 controlIndex, System.Void* buffer, System.Int32 bufferSize, System.Boolean ignoreComposites) { }
        private TValue ReadValue(System.Int32 bindingIndex, System.Int32 controlIndex, System.Boolean ignoreComposites) { }
        private TValue ApplyProcessors(System.Int32 bindingIndex, TValue value, UnityEngine.InputSystem.InputControl<TValue> controlOfType) { }
        private System.Single EvaluateCompositePartMagnitude(System.Int32 bindingIndex, System.Int32 partNumber) { }
        private System.Double GetCompositePartPressTime(System.Int32 bindingIndex, System.Int32 partNumber) { }
        private TValue ReadCompositePartValue(System.Int32 bindingIndex, System.Int32 partNumber, System.Boolean* buttonValuePtr, System.Int32& controlIndex, TComparer comparer) { }
        private System.Boolean ReadCompositePartValue(System.Int32 bindingIndex, System.Int32 partNumber, System.Void* buffer, System.Int32 bufferSize) { }
        private System.Object ReadCompositePartValueAsObject(System.Int32 bindingIndex, System.Int32 partNumber) { }
        private System.Object ReadValueAsObject(System.Int32 bindingIndex, System.Int32 controlIndex, System.Boolean ignoreComposites) { }
        private System.Boolean ReadValueAsButton(System.Int32 bindingIndex, System.Int32 controlIndex) { }
        private UnityEngine.InputSystem.Utilities.ISavedState SaveAndResetState() { }
        private System.Void AddToGlobalList() { }
        private System.Void RemoveMapFromGlobalList() { }
        private System.Void CompactGlobalList() { }
        private System.Void NotifyListenersOfActionChange(UnityEngine.InputSystem.InputActionChange change) { }
        private System.Void NotifyListenersOfActionChange(UnityEngine.InputSystem.InputActionChange change, System.Object actionOrMapOrAsset) { }
        private System.Void ResetGlobals() { }
        private System.Int32 FindAllEnabledActions(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> result) { }
        private System.Void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change) { }
        private System.Void DeferredResolutionOfBindings() { }
        private System.Void DisableAllActions() { }
        private System.Void DestroyAllActionMapStates() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004D
    public struct InputActionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputActionType Value;        // 0x0
        public static UnityEngine.InputSystem.InputActionType Button;        // 0x0
        public static UnityEngine.InputSystem.InputActionType PassThrough;        // 0x0

    }

    // TypeToken: 0x200004E
    public struct InputBinding, IEquatable`1
    {
        // Fields
        public static System.Char Separator;        // 0x0
        private static System.String kSeparatorString;        // 0x0
        private System.String m_Name;        // 0x10
        private System.String m_Id;        // 0x18
        private System.String m_Path;        // 0x20
        private System.String m_Interactions;        // 0x28
        private System.String m_Processors;        // 0x30
        private System.String m_Groups;        // 0x38
        private System.String m_Action;        // 0x40
        private UnityEngine.InputSystem.InputBinding.Flags m_Flags;        // 0x48
        private System.String m_OverridePath;        // 0x50
        private System.String m_OverrideInteractions;        // 0x58
        private System.String m_OverrideProcessors;        // 0x60

        // Methods
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Guid get_id() { }
        private System.Void set_id(System.Guid value) { }
        private System.String get_path() { }
        private System.Void set_path(System.String value) { }
        private System.String get_overridePath() { }
        private System.Void set_overridePath(System.String value) { }
        private System.String get_interactions() { }
        private System.Void set_interactions(System.String value) { }
        private System.String get_overrideInteractions() { }
        private System.Void set_overrideInteractions(System.String value) { }
        private System.String get_processors() { }
        private System.Void set_processors(System.String value) { }
        private System.String get_overrideProcessors() { }
        private System.Void set_overrideProcessors(System.String value) { }
        private System.String get_groups() { }
        private System.Void set_groups(System.String value) { }
        private System.String get_action() { }
        private System.Void set_action(System.String value) { }
        private System.Boolean get_isComposite() { }
        private System.Void set_isComposite(System.Boolean value) { }
        private System.Boolean get_isPartOfComposite() { }
        private System.Void set_isPartOfComposite(System.Boolean value) { }
        private System.Boolean get_hasOverrides() { }
        private System.Void .ctor(System.String path, System.String action, System.String groups, System.String processors, System.String interactions, System.String name) { }
        private System.String GetNameOfComposite() { }
        private System.Void GenerateId() { }
        private System.Void RemoveOverrides() { }
        private UnityEngine.InputSystem.InputBinding MaskByGroup(System.String group) { }
        private UnityEngine.InputSystem.InputBinding MaskByGroups(System.String[] groups) { }
        private System.String get_effectivePath() { }
        private System.String get_effectiveInteractions() { }
        private System.String get_effectiveProcessors() { }
        private System.Boolean get_isEmpty() { }
        private System.Boolean Equals(UnityEngine.InputSystem.InputBinding other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.InputBinding left, UnityEngine.InputSystem.InputBinding right) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.InputBinding left, UnityEngine.InputSystem.InputBinding right) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.String ToDisplayString(UnityEngine.InputSystem.InputBinding.DisplayStringOptions options, UnityEngine.InputSystem.InputControl control) { }
        private System.String ToDisplayString(System.String& deviceLayoutName, System.String& controlPath, UnityEngine.InputSystem.InputBinding.DisplayStringOptions options, UnityEngine.InputSystem.InputControl control) { }
        private System.Boolean TriggersAction(UnityEngine.InputSystem.InputAction action) { }
        private System.Boolean Matches(UnityEngine.InputSystem.InputBinding binding) { }
        private System.Boolean Matches(UnityEngine.InputSystem.InputBinding& binding, UnityEngine.InputSystem.InputBinding.MatchOptions options) { }

    }

    // TypeToken: 0x2000053
    public class InputBindingComposite
    {
        // Fields
        private static UnityEngine.InputSystem.Utilities.TypeTable s_Composites;        // 0x0

        // Methods
        private System.Type get_valueType() { }
        private System.Int32 get_valueSizeInBytes() { }
        private System.Void ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context, System.Void* buffer, System.Int32 bufferSize) { }
        private System.Object ReadValueAsObject(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Single EvaluateMagnitude(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void FinishSetup(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void CallFinishSetup(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Type GetValueType(System.String composite) { }
        private System.String GetExpectedControlLayoutName(System.String composite, System.String part) { }
        private System.Collections.Generic.IEnumerable<System.String> GetPartNames(System.String composite) { }
        private System.String GetDisplayFormatString(System.String composite) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000055
    public class InputBindingComposite`1 : InputBindingComposite
    {
        // Methods
        private System.Type get_valueType() { }
        private System.Int32 get_valueSizeInBytes() { }
        private TValue ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context, System.Void* buffer, System.Int32 bufferSize) { }
        private System.Object ReadValueAsObject(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000056
    public struct InputBindingCompositeContext
    {
        // Fields
        private UnityEngine.InputSystem.InputActionState m_State;        // 0x10
        private System.Int32 m_BindingIndex;        // 0x18

        // Methods
        private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding> get_controls() { }
        private System.Single EvaluateMagnitude(System.Int32 partNumber) { }
        private TValue ReadValue(System.Int32 partNumber) { }
        private TValue ReadValue(System.Int32 partNumber, UnityEngine.InputSystem.InputControl& sourceControl) { }
        private TValue ReadValue(System.Int32 partNumber, TComparer comparer) { }
        private TValue ReadValue(System.Int32 partNumber, UnityEngine.InputSystem.InputControl& sourceControl, TComparer comparer) { }
        private System.Boolean ReadValueAsButton(System.Int32 partNumber) { }
        private System.Void ReadValue(System.Int32 partNumber, System.Void* buffer, System.Int32 bufferSize) { }
        private System.Object ReadValueAsObject(System.Int32 partNumber) { }
        private System.Double GetPressTime(System.Int32 partNumber) { }

    }

    // TypeToken: 0x200005A
    public struct InputBindingResolver, IDisposable
    {
        // Fields
        public System.Int32 totalProcessorCount;        // 0x10
        public System.Int32 totalCompositeCount;        // 0x14
        public System.Int32 totalInteractionCount;        // 0x18
        public UnityEngine.InputSystem.InputActionMap[] maps;        // 0x20
        public UnityEngine.InputSystem.InputControl[] controls;        // 0x28
        public UnityEngine.InputSystem.InputActionState.UnmanagedMemory memory;        // 0x30
        public UnityEngine.InputSystem.IInputInteraction[] interactions;        // 0xB0
        public UnityEngine.InputSystem.InputProcessor[] processors;        // 0xB8
        public UnityEngine.InputSystem.InputBindingComposite[] composites;        // 0xC0
        public System.Nullable<UnityEngine.InputSystem.InputBinding> bindingMask;        // 0xC8
        private System.Boolean m_IsControlOnlyResolve;        // 0x128
        private System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.NameAndParameters> m_Parameters;        // 0x130

        // Methods
        private System.Int32 get_totalMapCount() { }
        private System.Int32 get_totalActionCount() { }
        private System.Int32 get_totalBindingCount() { }
        private System.Int32 get_totalControlCount() { }
        private System.Void Dispose() { }
        private System.Void StartWithPreviousResolve(UnityEngine.InputSystem.InputActionState state, System.Boolean isFullResolve) { }
        private System.Void AddActionMap(UnityEngine.InputSystem.InputActionMap actionMap) { }
        private System.Int32 InstantiateWithParameters(UnityEngine.InputSystem.Utilities.TypeTable registrations, System.String namesAndParameters, TType[]& array, System.Int32& count, UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding& binding) { }
        private UnityEngine.InputSystem.InputBindingComposite InstantiateBindingComposite(UnityEngine.InputSystem.InputBinding& binding, UnityEngine.InputSystem.InputActionMap actionMap) { }
        private System.Void ApplyParameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> parameters, System.Object instance, UnityEngine.InputSystem.InputActionMap actionMap, UnityEngine.InputSystem.InputBinding& binding, System.String objectRegistrationName, System.String namesAndParameters) { }
        private System.Int32 AssignCompositePartIndex(System.Object composite, System.String name, System.Int32& currentCompositePartCount) { }

    }

    // TypeToken: 0x200005B
    public struct InputControlScheme, IEquatable`1
    {
        // Fields
        private System.String m_Name;        // 0x10
        private System.String m_BindingGroup;        // 0x18
        private UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[] m_DeviceRequirements;        // 0x20

        // Methods
        private System.String get_name() { }
        private System.String get_bindingGroup() { }
        private System.Void set_bindingGroup(System.String value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> get_deviceRequirements() { }
        private System.Void .ctor(System.String name, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> devices, System.String bindingGroup) { }
        private System.Void SetNameAndBindingGroup(System.String name, System.String bindingGroup) { }
        private System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlSchemeForDevices(TDevices devices, TSchemes schemes, UnityEngine.InputSystem.InputDevice mustIncludeDevice, System.Boolean allowUnsuccesfulMatch) { }
        private System.Boolean FindControlSchemeForDevices(TDevices devices, TSchemes schemes, UnityEngine.InputSystem.InputControlScheme& controlScheme, UnityEngine.InputSystem.InputControlScheme.MatchResult& matchResult, UnityEngine.InputSystem.InputDevice mustIncludeDevice, System.Boolean allowUnsuccessfulMatch) { }
        private System.Nullable<UnityEngine.InputSystem.InputControlScheme> FindControlSchemeForDevice(UnityEngine.InputSystem.InputDevice device, TSchemes schemes) { }
        private System.Boolean SupportsDevice(UnityEngine.InputSystem.InputDevice device) { }
        private UnityEngine.InputSystem.InputControlScheme.MatchResult PickDevicesFrom(TDevices devices, UnityEngine.InputSystem.InputDevice favorDevice) { }
        private System.Boolean Equals(UnityEngine.InputSystem.InputControlScheme other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.InputControlScheme left, UnityEngine.InputSystem.InputControlScheme right) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.InputControlScheme left, UnityEngine.InputSystem.InputControlScheme right) { }

    }

    // TypeToken: 0x2000064
    public struct InputInteractionContext
    {
        // Fields
        private UnityEngine.InputSystem.InputActionState m_State;        // 0x10
        private UnityEngine.InputSystem.InputInteractionContext.Flags m_Flags;        // 0x18
        private UnityEngine.InputSystem.InputActionState.TriggerState m_TriggerState;        // 0x20

        // Methods
        private UnityEngine.InputSystem.InputAction get_action() { }
        private UnityEngine.InputSystem.InputControl get_control() { }
        private UnityEngine.InputSystem.InputActionPhase get_phase() { }
        private System.Double get_time() { }
        private System.Double get_startTime() { }
        private System.Boolean get_timerHasExpired() { }
        private System.Void set_timerHasExpired(System.Boolean value) { }
        private System.Boolean get_isWaiting() { }
        private System.Boolean get_isStarted() { }
        private System.Single ComputeMagnitude() { }
        private System.Boolean ControlIsActuated(System.Single threshold) { }
        private System.Void Started() { }
        private System.Void Performed() { }
        private System.Void PerformedAndStayStarted() { }
        private System.Void PerformedAndStayPerformed() { }
        private System.Void Canceled() { }
        private System.Void Waiting() { }
        private System.Void SetTimeout(System.Single seconds) { }
        private System.Void SetTotalTimeoutCompletionTime(System.Single seconds) { }
        private TValue ReadValue() { }
        private System.Int32 get_mapIndex() { }
        private System.Int32 get_controlIndex() { }
        private System.Int32 get_bindingIndex() { }
        private System.Int32 get_interactionIndex() { }

    }

    // TypeToken: 0x2000066
    public class InputSystem
    {
        // Fields
        private static System.String kAssemblyVersion;        // 0x0
        private static System.String kDocUrl;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker k_InputResetMarker;        // 0x0
        private static System.Single scrollWheelDeltaPerTick;        // 0x0
        private static UnityEngine.InputSystem.InputManager s_Manager;        // 0x8
        private static UnityEngine.InputSystem.InputRemoting s_Remote;        // 0x10

        // Methods
        private System.Void add_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }
        private System.Void remove_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }
        private System.Void RegisterLayout(System.Type type, System.String name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }
        private System.Void RegisterLayout(System.String name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }
        private System.Void RegisterLayout(System.String json, System.String name, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }
        private System.Void RegisterLayoutOverride(System.String json, System.String name) { }
        private System.Void RegisterLayoutMatcher(System.String layoutName, UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher) { }
        private System.Void RegisterLayoutMatcher(UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher) { }
        private System.Void RegisterLayoutBuilder(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> buildMethod, System.String name, System.String baseLayout, System.Nullable<UnityEngine.InputSystem.Layouts.InputDeviceMatcher> matches) { }
        private System.Void RegisterPrecompiledLayout(System.String metadata) { }
        private System.Void RemoveLayout(System.String name) { }
        private System.String TryFindMatchingLayout(UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription) { }
        private System.Collections.Generic.IEnumerable<System.String> ListLayouts() { }
        private System.Collections.Generic.IEnumerable<System.String> ListLayoutsBasedOn(System.String baseLayout) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout LoadLayout(System.String name) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout LoadLayout() { }
        private System.String GetNameOfBaseLayout(System.String layoutName) { }
        private System.Boolean IsFirstLayoutBasedOnSecond(System.String firstLayoutName, System.String secondLayoutName) { }
        private System.Void RegisterProcessor(System.Type type, System.String name) { }
        private System.Void RegisterProcessor(System.String name) { }
        private System.Type TryGetProcessor(System.String name) { }
        private System.Collections.Generic.IEnumerable<System.String> ListProcessors() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_disconnectedDevices() { }
        private System.Void add_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }
        private System.Void remove_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }
        private System.Void add_onDeviceCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate value) { }
        private System.Void remove_onDeviceCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate value) { }
        private System.Void add_onFindLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate value) { }
        private System.Void remove_onFindLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate value) { }
        private System.Single get_pollingFrequency() { }
        private System.Void set_pollingFrequency(System.Single value) { }
        private UnityEngine.InputSystem.InputDevice AddDevice(System.String layout, System.String name, System.String variants) { }
        private TDevice AddDevice(System.String name) { }
        private UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription description) { }
        private System.Void AddDevice(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void RemoveDevice(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void FlushDisconnectedDevices() { }
        private UnityEngine.InputSystem.InputDevice GetDevice(System.String nameOrLayout) { }
        private TDevice GetDevice() { }
        private UnityEngine.InputSystem.InputDevice GetDevice(System.Type type) { }
        private TDevice GetDevice(UnityEngine.InputSystem.Utilities.InternedString usage) { }
        private TDevice GetDevice(System.String usage) { }
        private UnityEngine.InputSystem.InputDevice GetDeviceById(System.Int32 deviceId) { }
        private System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> GetUnsupportedDevices() { }
        private System.Int32 GetUnsupportedDevices(System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions) { }
        private System.Void EnableDevice(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void DisableDevice(UnityEngine.InputSystem.InputDevice device, System.Boolean keepSendingEvents) { }
        private System.Boolean TrySyncDevice(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void ResetDevice(UnityEngine.InputSystem.InputDevice device, System.Boolean alsoResetDontResetControls) { }
        private System.Boolean TryResetDevice(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void PauseHaptics() { }
        private System.Void ResumeHaptics() { }
        private System.Void ResetHaptics() { }
        private System.Void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, System.String usage) { }
        private System.Void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage) { }
        private System.Void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, System.String usage) { }
        private System.Void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage) { }
        private System.Void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, System.String usage) { }
        private System.Void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage) { }
        private UnityEngine.InputSystem.InputControl FindControl(System.String path) { }
        private UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl> FindControls(System.String path) { }
        private UnityEngine.InputSystem.InputControlList<TControl> FindControls(System.String path) { }
        private System.Int32 FindControls(System.String path, UnityEngine.InputSystem.InputControlList<TControl>& controls) { }
        private System.Boolean get_isProcessingEvents() { }
        private UnityEngine.InputSystem.LowLevel.InputEventListener get_onEvent() { }
        private System.Void set_onEvent(UnityEngine.InputSystem.LowLevel.InputEventListener value) { }
        private System.IObservable<UnityEngine.InputSystem.InputControl> get_onAnyButtonPress() { }
        private System.Void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void QueueEvent(TEvent& inputEvent) { }
        private System.Void QueueStateEvent(UnityEngine.InputSystem.InputDevice device, TState state, System.Double time) { }
        private System.Void QueueDeltaStateEvent(UnityEngine.InputSystem.InputControl control, TDelta delta, System.Double time) { }
        private System.Void QueueConfigChangeEvent(UnityEngine.InputSystem.InputDevice device, System.Double time) { }
        private System.Void QueueTextEvent(UnityEngine.InputSystem.InputDevice device, System.Char character, System.Double time) { }
        private System.Void Update() { }
        private System.Void Update(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType) { }
        private System.Void add_onBeforeUpdate(System.Action value) { }
        private System.Void remove_onBeforeUpdate(System.Action value) { }
        private System.Void add_onAfterUpdate(System.Action value) { }
        private System.Void remove_onAfterUpdate(System.Action value) { }
        private UnityEngine.InputSystem.InputSettings get_settings() { }
        private System.Void set_settings(UnityEngine.InputSystem.InputSettings value) { }
        private System.Void add_onSettingsChange(System.Action value) { }
        private System.Void remove_onSettingsChange(System.Action value) { }
        private System.Void add_onActionChange(System.Action<System.Object,UnityEngine.InputSystem.InputActionChange> value) { }
        private System.Void remove_onActionChange(System.Action<System.Object,UnityEngine.InputSystem.InputActionChange> value) { }
        private System.Void RegisterInteraction(System.Type type, System.String name) { }
        private System.Void RegisterInteraction(System.String name) { }
        private System.Type TryGetInteraction(System.String name) { }
        private System.Collections.Generic.IEnumerable<System.String> ListInteractions() { }
        private System.Void RegisterBindingComposite(System.Type type, System.String name) { }
        private System.Void RegisterBindingComposite(System.String name) { }
        private System.Type TryGetBindingComposite(System.String name) { }
        private System.Void DisableAllEnabledActions() { }
        private System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> ListEnabledActions() { }
        private System.Int32 ListEnabledActions(System.Collections.Generic.List<UnityEngine.InputSystem.InputAction> actions) { }
        private UnityEngine.InputSystem.InputRemoting get_remoting() { }
        private System.Version get_version() { }
        private System.Boolean get_runInBackground() { }
        private System.Void set_runInBackground(System.Boolean value) { }
        private UnityEngine.InputSystem.LowLevel.InputMetrics get_metrics() { }
        private System.Void .cctor() { }
        private System.Void RunInitializeInPlayer() { }
        private System.Void EnsureInitialized() { }
        private System.Void InitializeInPlayer(UnityEngine.InputSystem.LowLevel.IInputRuntime runtime, UnityEngine.InputSystem.InputSettings settings) { }
        private System.Void RunInitialUpdate() { }
        private System.Void PerformDefaultPluginInitialization() { }

    }

    // TypeToken: 0x200006C
    public class CommonUsages
    {
        // Fields
        public static readonly UnityEngine.InputSystem.Utilities.InternedString Primary2DMotion;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.InternedString Secondary2DMotion;        // 0x10
        public static readonly UnityEngine.InputSystem.Utilities.InternedString PrimaryAction;        // 0x20
        public static readonly UnityEngine.InputSystem.Utilities.InternedString SecondaryAction;        // 0x30
        public static readonly UnityEngine.InputSystem.Utilities.InternedString PrimaryTrigger;        // 0x40
        public static readonly UnityEngine.InputSystem.Utilities.InternedString SecondaryTrigger;        // 0x50
        public static readonly UnityEngine.InputSystem.Utilities.InternedString Modifier;        // 0x60
        public static readonly UnityEngine.InputSystem.Utilities.InternedString Position;        // 0x70
        public static readonly UnityEngine.InputSystem.Utilities.InternedString Orientation;        // 0x80
        public static readonly UnityEngine.InputSystem.Utilities.InternedString Hatswitch;        // 0x90
        public static readonly UnityEngine.InputSystem.Utilities.InternedString Back;        // 0xA0
        public static readonly UnityEngine.InputSystem.Utilities.InternedString Forward;        // 0xB0
        public static readonly UnityEngine.InputSystem.Utilities.InternedString Menu;        // 0xC0
        public static readonly UnityEngine.InputSystem.Utilities.InternedString Submit;        // 0xD0
        public static readonly UnityEngine.InputSystem.Utilities.InternedString Cancel;        // 0xE0
        public static readonly UnityEngine.InputSystem.Utilities.InternedString Horizontal;        // 0xF0
        public static readonly UnityEngine.InputSystem.Utilities.InternedString Vertical;        // 0x100
        public static readonly UnityEngine.InputSystem.Utilities.InternedString Twist;        // 0x110
        public static readonly UnityEngine.InputSystem.Utilities.InternedString Pressure;        // 0x120
        public static readonly UnityEngine.InputSystem.Utilities.InternedString ScrollHorizontal;        // 0x130
        public static readonly UnityEngine.InputSystem.Utilities.InternedString ScrollVertical;        // 0x140
        public static readonly UnityEngine.InputSystem.Utilities.InternedString Point;        // 0x150
        public static readonly UnityEngine.InputSystem.Utilities.InternedString LowFreqMotor;        // 0x160
        public static readonly UnityEngine.InputSystem.Utilities.InternedString HighFreqMotor;        // 0x170
        public static readonly UnityEngine.InputSystem.Utilities.InternedString LeftHand;        // 0x180
        public static readonly UnityEngine.InputSystem.Utilities.InternedString RightHand;        // 0x190
        public static readonly UnityEngine.InputSystem.Utilities.InternedString BatteryStrength;        // 0x1A0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006D
    public class InputControl
    {
        // Fields
        protected internal UnityEngine.InputSystem.LowLevel.InputStateBlock m_StateBlock;        // 0x10
        private UnityEngine.InputSystem.Utilities.InternedString m_Name;        // 0x20
        private System.String m_Path;        // 0x30
        private System.String m_DisplayName;        // 0x38
        private System.String m_DisplayNameFromLayout;        // 0x40
        private System.String m_ShortDisplayName;        // 0x48
        private System.String m_ShortDisplayNameFromLayout;        // 0x50
        private UnityEngine.InputSystem.Utilities.InternedString m_Layout;        // 0x58
        private UnityEngine.InputSystem.Utilities.InternedString m_Variants;        // 0x68
        private UnityEngine.InputSystem.InputDevice m_Device;        // 0x78
        private UnityEngine.InputSystem.InputControl m_Parent;        // 0x80
        private System.Int32 m_UsageCount;        // 0x88
        private System.Int32 m_UsageStartIndex;        // 0x8C
        private System.Int32 m_AliasCount;        // 0x90
        private System.Int32 m_AliasStartIndex;        // 0x94
        private System.Int32 m_ChildCount;        // 0x98
        private System.Int32 m_ChildStartIndex;        // 0x9C
        private UnityEngine.InputSystem.InputControl.ControlFlags m_ControlFlags;        // 0xA0
        private System.Boolean m_CachedValueIsStale;        // 0xA4
        private System.Boolean m_UnprocessedCachedValueIsStale;        // 0xA5
        private UnityEngine.InputSystem.Utilities.PrimitiveValue m_DefaultState;        // 0xA8
        private UnityEngine.InputSystem.Utilities.PrimitiveValue m_MinValue;        // 0xB8
        private UnityEngine.InputSystem.Utilities.PrimitiveValue m_MaxValue;        // 0xC8
        private UnityEngine.InputSystem.Utilities.FourCC m_OptimizedControlDataType;        // 0xD8

        // Methods
        private System.String get_name() { }
        private System.String get_displayName() { }
        private System.Void set_displayName(System.String value) { }
        private System.String get_shortDisplayName() { }
        private System.Void set_shortDisplayName(System.String value) { }
        private System.String get_path() { }
        private System.String get_layout() { }
        private System.String get_variants() { }
        private UnityEngine.InputSystem.InputDevice get_device() { }
        private UnityEngine.InputSystem.InputControl get_parent() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_children() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_usages() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_aliases() { }
        private UnityEngine.InputSystem.LowLevel.InputStateBlock get_stateBlock() { }
        private System.Boolean get_noisy() { }
        private System.Void set_noisy(System.Boolean value) { }
        private System.Boolean get_synthetic() { }
        private System.Void set_synthetic(System.Boolean value) { }
        private UnityEngine.InputSystem.InputControl get_Item(System.String path) { }
        private System.Type get_valueType() { }
        private System.Int32 get_valueSizeInBytes() { }
        private System.Single get_magnitude() { }
        private System.String ToString() { }
        private System.String DebuggerDisplay() { }
        private System.Single EvaluateMagnitude() { }
        private System.Single EvaluateMagnitude(System.Void* statePtr) { }
        private System.Object ReadValueFromBufferAsObject(System.Void* buffer, System.Int32 bufferSize) { }
        private System.Object ReadValueFromStateAsObject(System.Void* statePtr) { }
        private System.Void ReadValueFromStateIntoBuffer(System.Void* statePtr, System.Void* bufferPtr, System.Int32 bufferSize) { }
        private System.Void WriteValueFromBufferIntoState(System.Void* bufferPtr, System.Int32 bufferSize, System.Void* statePtr) { }
        private System.Void WriteValueFromObjectIntoState(System.Object value, System.Void* statePtr) { }
        private System.Boolean CompareValue(System.Void* firstStatePtr, System.Void* secondStatePtr) { }
        private UnityEngine.InputSystem.InputControl TryGetChildControl(System.String path) { }
        private TControl TryGetChildControl(System.String path) { }
        private UnityEngine.InputSystem.InputControl GetChildControl(System.String path) { }
        private TControl GetChildControl(System.String path) { }
        private System.Void .ctor() { }
        private System.Void FinishSetup() { }
        private System.Void RefreshConfigurationIfNeeded() { }
        private System.Void RefreshConfiguration() { }
        private System.Void* get_currentStatePtr() { }
        private System.Void* get_previousFrameStatePtr() { }
        private System.Void* get_defaultStatePtr() { }
        private System.Void* get_noiseMaskPtr() { }
        private System.UInt32 get_stateOffsetRelativeToDeviceRoot() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_optimizedControlDataType() { }
        private UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType() { }
        private System.Void ApplyParameterChanges() { }
        private System.Void SetOptimizedControlDataType() { }
        private System.Void SetOptimizedControlDataTypeRecursively() { }
        private System.Void EnsureOptimizationTypeHasNotChanged() { }
        private System.Boolean get_isSetupFinished() { }
        private System.Void set_isSetupFinished(System.Boolean value) { }
        private System.Boolean get_isButton() { }
        private System.Void set_isButton(System.Boolean value) { }
        private System.Boolean get_isConfigUpToDate() { }
        private System.Void set_isConfigUpToDate(System.Boolean value) { }
        private System.Boolean get_dontReset() { }
        private System.Void set_dontReset(System.Boolean value) { }
        private System.Boolean get_usesStateFromOtherControl() { }
        private System.Void set_usesStateFromOtherControl(System.Boolean value) { }
        private System.Boolean get_hasDefaultState() { }
        private System.Void CallFinishSetupRecursive() { }
        private System.String MakeChildPath(System.String path) { }
        private System.Void BakeOffsetIntoStateBlockRecursive(System.UInt32 offset) { }
        private System.Int32 GetDeviceIndex() { }
        private System.Boolean IsValueConsideredPressed(System.Single value) { }
        private System.Void AddProcessor(System.Object first) { }
        private System.Void MarkAsStale() { }
        private System.Void MarkAsStaleRecursively() { }

    }

    // TypeToken: 0x200006F
    public class InputControl`1 : InputControl
    {
        // Fields
        private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputProcessor<TValue>> m_ProcessorStack;        // 0x0
        private TValue m_CachedValue;        // 0x0
        private TValue m_UnprocessedCachedValue;        // 0x0
        private System.Boolean evaluateProcessorsEveryRead;        // 0x0

        // Methods
        private System.Type get_valueType() { }
        private System.Int32 get_valueSizeInBytes() { }
        private TValue& get_value() { }
        private TValue& get_unprocessedValue() { }
        private TValue ReadValue() { }
        private TValue ReadValueFromPreviousFrame() { }
        private TValue ReadDefaultValue() { }
        private TValue ReadValueFromState(System.Void* statePtr) { }
        private TValue ReadValueFromStateWithCaching(System.Void* statePtr) { }
        private TValue ReadUnprocessedValueFromStateWithCaching(System.Void* statePtr) { }
        private TValue ReadUnprocessedValue() { }
        private TValue ReadUnprocessedValueFromState(System.Void* statePtr) { }
        private System.Object ReadValueFromStateAsObject(System.Void* statePtr) { }
        private System.Void ReadValueFromStateIntoBuffer(System.Void* statePtr, System.Void* bufferPtr, System.Int32 bufferSize) { }
        private System.Void WriteValueFromBufferIntoState(System.Void* bufferPtr, System.Int32 bufferSize, System.Void* statePtr) { }
        private System.Void WriteValueFromObjectIntoState(System.Object value, System.Void* statePtr) { }
        private System.Void WriteValueIntoState(TValue value, System.Void* statePtr) { }
        private System.Object ReadValueFromBufferAsObject(System.Void* buffer, System.Int32 bufferSize) { }
        private System.Boolean CompareValue(TValue& firstValue, TValue& secondValue) { }
        private System.Boolean CompareValue(System.Void* firstStatePtr, System.Void* secondStatePtr) { }
        private TValue ProcessValue(TValue value) { }
        private System.Void ProcessValue(TValue& value) { }
        private TProcessor TryGetProcessor() { }
        private System.Void AddProcessor(System.Object processor) { }
        private System.Void FinishSetup() { }
        private UnityEngine.InputSystem.InputProcessor<TValue>[] get_processors() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000070
    public class InputControlExtensions
    {
        // Methods
        private TControl FindInParentChain(UnityEngine.InputSystem.InputControl control) { }
        private System.Boolean IsPressed(UnityEngine.InputSystem.InputControl control, System.Single buttonPressPoint) { }
        private System.Boolean IsActuated(UnityEngine.InputSystem.InputControl control, System.Single threshold) { }
        private System.Object ReadValueAsObject(UnityEngine.InputSystem.InputControl control) { }
        private System.Void ReadValueIntoBuffer(UnityEngine.InputSystem.InputControl control, System.Void* buffer, System.Int32 bufferSize) { }
        private System.Object ReadDefaultValueAsObject(UnityEngine.InputSystem.InputControl control) { }
        private TValue ReadValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent) { }
        private System.Boolean ReadValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent, TValue& value) { }
        private System.Object ReadValueFromEventAsObject(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent) { }
        private TValue ReadUnprocessedValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Boolean ReadUnprocessedValueFromEvent(UnityEngine.InputSystem.InputControl<TValue> control, UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent, TValue& value) { }
        private System.Void WriteValueFromObjectIntoEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Object value) { }
        private System.Void WriteValueIntoState(UnityEngine.InputSystem.InputControl control, System.Void* statePtr) { }
        private System.Void WriteValueIntoState(UnityEngine.InputSystem.InputControl control, TValue value, System.Void* statePtr) { }
        private System.Void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, System.Void* statePtr) { }
        private System.Void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, System.Void* statePtr) { }
        private System.Void WriteValueIntoState(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, TState& state) { }
        private System.Void WriteValueIntoEvent(UnityEngine.InputSystem.InputControl control, TValue value, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void WriteValueIntoEvent(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void CopyState(UnityEngine.InputSystem.InputDevice device, System.Void* buffer, System.Int32 bufferSizeInBytes) { }
        private System.Void CopyState(UnityEngine.InputSystem.InputDevice device, TState& state) { }
        private System.Boolean CheckStateIsAtDefault(UnityEngine.InputSystem.InputControl control) { }
        private System.Boolean CheckStateIsAtDefault(UnityEngine.InputSystem.InputControl control, System.Void* statePtr, System.Void* maskPtr) { }
        private System.Boolean CheckStateIsAtDefaultIgnoringNoise(UnityEngine.InputSystem.InputControl control) { }
        private System.Boolean CheckStateIsAtDefaultIgnoringNoise(UnityEngine.InputSystem.InputControl control, System.Void* statePtr) { }
        private System.Boolean CompareStateIgnoringNoise(UnityEngine.InputSystem.InputControl control, System.Void* statePtr) { }
        private System.Boolean CompareState(UnityEngine.InputSystem.InputControl control, System.Void* firstStatePtr, System.Void* secondStatePtr, System.Void* maskPtr) { }
        private System.Boolean CompareState(UnityEngine.InputSystem.InputControl control, System.Void* statePtr, System.Void* maskPtr) { }
        private System.Boolean HasValueChangeInState(UnityEngine.InputSystem.InputControl control, System.Void* statePtr) { }
        private System.Boolean HasValueChangeInEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void* GetStatePtrFromStateEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void* GetStatePtrFromStateEventUnchecked(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.Utilities.FourCC eventType) { }
        private System.Boolean ResetToDefaultStateInEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void QueueValueChange(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, System.Double time) { }
        private System.Void AccumulateValueInEvent(UnityEngine.InputSystem.InputControl<System.Single> control, System.Void* currentStatePtr, UnityEngine.InputSystem.LowLevel.InputEventPtr newState) { }
        private System.Void AccumulateValueInEvent(UnityEngine.InputSystem.InputControl<UnityEngine.Vector2> control, System.Void* currentStatePtr, UnityEngine.InputSystem.LowLevel.InputEventPtr newState) { }
        private System.Void FindControlsRecursive(UnityEngine.InputSystem.InputControl parent, System.Collections.Generic.IList<TControl> controls, System.Func<TControl,System.Boolean> predicate) { }
        private System.String BuildPath(UnityEngine.InputSystem.InputControl control, System.String deviceLayout, System.Text.StringBuilder builder) { }
        private UnityEngine.InputSystem.InputControlExtensions.InputEventControlCollection EnumerateControls(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputControlExtensions.Enumerate flags, UnityEngine.InputSystem.InputDevice device, System.Single magnitudeThreshold) { }
        private UnityEngine.InputSystem.InputControlExtensions.InputEventControlCollection EnumerateChangedControls(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device, System.Single magnitudeThreshold) { }
        private System.Boolean HasButtonPress(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Single magnitude, System.Boolean buttonControlsOnly) { }
        private UnityEngine.InputSystem.InputControl GetFirstButtonPressOrNull(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Single magnitude, System.Boolean buttonControlsOnly) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl> GetAllButtonPresses(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Single magnitude, System.Boolean buttonControlsOnly) { }
        private UnityEngine.InputSystem.InputControlExtensions.ControlBuilder Setup(UnityEngine.InputSystem.InputControl control) { }
        private UnityEngine.InputSystem.InputControlExtensions.DeviceBuilder Setup(UnityEngine.InputSystem.InputDevice device, System.Int32 controlCount, System.Int32 usageCount, System.Int32 aliasCount) { }

    }

    // TypeToken: 0x2000077
    public struct InputControlLayoutChange
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputControlLayoutChange Added;        // 0x0
        public static UnityEngine.InputSystem.InputControlLayoutChange Removed;        // 0x0
        public static UnityEngine.InputSystem.InputControlLayoutChange Replaced;        // 0x0

    }

    // TypeToken: 0x2000078
    public struct InputControlList`1, IList`1, ICollection`1, IEnumerable`1, IEnumerable, IReadOnlyList`1, IReadOnlyCollection`1, IDisposable
    {
        // Fields
        private System.Int32 m_Count;        // 0x0
        private Unity.Collections.NativeArray<System.UInt64> m_Indices;        // 0x0
        private readonly Unity.Collections.Allocator m_Allocator;        // 0x0
        private static System.UInt64 kInvalidIndex;        // 0x0

        // Methods
        private System.Int32 get_Count() { }
        private System.Int32 get_Capacity() { }
        private System.Void set_Capacity(System.Int32 value) { }
        private System.Boolean get_IsReadOnly() { }
        private TControl get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, TControl value) { }
        private System.Void .ctor(Unity.Collections.Allocator allocator, System.Int32 initialCapacity) { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<TControl> values, Unity.Collections.Allocator allocator) { }
        private System.Void .ctor(TControl[] values) { }
        private System.Void Resize(System.Int32 size) { }
        private System.Void Add(TControl item) { }
        private System.Void AddSlice(TList list, System.Int32 count, System.Int32 destinationIndex, System.Int32 sourceIndex) { }
        private System.Void AddRange(System.Collections.Generic.IEnumerable<TControl> list, System.Int32 count, System.Int32 destinationIndex) { }
        private System.Boolean Remove(TControl item) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Void CopyTo(TControl[] array, System.Int32 arrayIndex) { }
        private System.Int32 IndexOf(TControl item) { }
        private System.Int32 IndexOf(TControl item, System.Int32 startIndex, System.Int32 count) { }
        private System.Void Insert(System.Int32 index, TControl item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(TControl item) { }
        private System.Boolean Contains(TControl item, System.Int32 startIndex, System.Int32 count) { }
        private System.Void SwapElements(System.Int32 index1, System.Int32 index2) { }
        private System.Void Sort(System.Int32 startIndex, System.Int32 count, TCompare comparer) { }
        private TControl[] ToArray(System.Boolean dispose) { }
        private System.Void AppendTo(TControl[]& array, System.Int32& count) { }
        private System.Void Dispose() { }
        private System.Collections.Generic.IEnumerator<TControl> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.String ToString() { }
        private System.UInt64 ToIndex(TControl control) { }
        private TControl FromIndex(System.UInt64 index) { }

    }

    // TypeToken: 0x200007A
    public class InputControlPath
    {
        // Fields
        public static System.String Wildcard;        // 0x0
        public static System.String DoubleWildcard;        // 0x0
        public static System.Char Separator;        // 0x0
        private static System.Char SeparatorReplacement;        // 0x0

        // Methods
        private System.String CleanSlashes(System.String pathComponent) { }
        private System.String Combine(UnityEngine.InputSystem.InputControl parent, System.String path) { }
        private System.String ToHumanReadableString(System.String path, UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions options, UnityEngine.InputSystem.InputControl control) { }
        private System.String ToHumanReadableString(System.String path, System.String& deviceLayoutName, System.String& controlPath, UnityEngine.InputSystem.InputControlPath.HumanReadableStringOptions options, UnityEngine.InputSystem.InputControl control) { }
        private System.String[] TryGetDeviceUsages(System.String path) { }
        private System.String TryGetDeviceLayout(System.String path) { }
        private System.String TryGetControlLayout(System.String path) { }
        private System.String FindControlLayoutRecursive(UnityEngine.InputSystem.InputControlPath.PathParser& parser, System.String layoutName) { }
        private System.String FindControlLayoutRecursive(UnityEngine.InputSystem.InputControlPath.PathParser& parser, UnityEngine.InputSystem.Layouts.InputControlLayout layout) { }
        private System.Boolean ControlLayoutMatchesPathComponent(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem& controlItem, UnityEngine.InputSystem.InputControlPath.PathParser& parser) { }
        private System.Boolean StringMatches(UnityEngine.InputSystem.Utilities.Substring str, UnityEngine.InputSystem.Utilities.InternedString matchTo) { }
        private UnityEngine.InputSystem.InputControl TryFindControl(UnityEngine.InputSystem.InputControl control, System.String path, System.Int32 indexInPath) { }
        private UnityEngine.InputSystem.InputControl[] TryFindControls(UnityEngine.InputSystem.InputControl control, System.String path, System.Int32 indexInPath) { }
        private System.Int32 TryFindControls(UnityEngine.InputSystem.InputControl control, System.String path, UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputControl>& matches, System.Int32 indexInPath) { }
        private TControl TryFindControl(UnityEngine.InputSystem.InputControl control, System.String path, System.Int32 indexInPath) { }
        private System.Int32 TryFindControls(UnityEngine.InputSystem.InputControl control, System.String path, System.Int32 indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches) { }
        private UnityEngine.InputSystem.InputControl TryFindChild(UnityEngine.InputSystem.InputControl control, System.String path, System.Int32 indexInPath) { }
        private TControl TryFindChild(UnityEngine.InputSystem.InputControl control, System.String path, System.Int32 indexInPath) { }
        private System.Boolean Matches(System.String expected, UnityEngine.InputSystem.InputControl control) { }
        private System.Boolean MatchControlComponent(UnityEngine.InputSystem.InputControlPath.ParsedPathComponent& expectedControlComponent, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem& controlItem, System.Boolean matchAlias) { }
        private System.Boolean MatchesPrefix(System.String expected, UnityEngine.InputSystem.InputControl control) { }
        private System.Boolean MatchesRecursive(UnityEngine.InputSystem.InputControlPath.PathParser& parser, UnityEngine.InputSystem.InputControl currentControl, System.Boolean prefixOnly) { }
        private TControl MatchControlsRecursive(UnityEngine.InputSystem.InputControl control, System.String path, System.Int32 indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches, System.Boolean matchMultiple) { }
        private TControl MatchByUsageAtDeviceRootRecursive(UnityEngine.InputSystem.InputDevice device, System.String path, System.Int32 indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches, System.Boolean matchMultiple) { }
        private TControl MatchChildrenRecursive(UnityEngine.InputSystem.InputControl control, System.String path, System.Int32 indexInPath, UnityEngine.InputSystem.InputControlList<TControl>& matches, System.Boolean matchMultiple) { }
        private System.Boolean MatchPathComponent(System.String component, System.String path, System.Int32& indexInPath, UnityEngine.InputSystem.InputControlPath.PathComponentType componentType, System.Int32 startIndexInComponent) { }
        private System.Boolean PathComponentCanYieldMultipleMatches(System.String path, System.Int32 indexInPath) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControlPath.ParsedPathComponent> Parse(System.String path) { }

    }

    // TypeToken: 0x2000082
    public class InputProcessor
    {
        // Fields
        private static UnityEngine.InputSystem.Utilities.TypeTable s_Processors;        // 0x0

        // Methods
        private System.Object ProcessAsObject(System.Object value, UnityEngine.InputSystem.InputControl control) { }
        private System.Void Process(System.Void* buffer, System.Int32 bufferSize, UnityEngine.InputSystem.InputControl control) { }
        private System.Type GetValueTypeFromType(System.Type processorType) { }
        private UnityEngine.InputSystem.InputProcessor.CachingPolicy get_cachingPolicy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000084
    public class InputProcessor`1 : InputProcessor
    {
        // Methods
        private TValue Process(TValue value, UnityEngine.InputSystem.InputControl control) { }
        private System.Object ProcessAsObject(System.Object value, UnityEngine.InputSystem.InputControl control) { }
        private System.Void Process(System.Void* buffer, System.Int32 bufferSize, UnityEngine.InputSystem.InputControl control) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000085
    public class Gamepad : InputDevice, IDualMotorRumble, IHaptics
    {
        // Fields
        private UnityEngine.InputSystem.Controls.ButtonControl <buttonWest>k__BackingField;        // 0x190
        private UnityEngine.InputSystem.Controls.ButtonControl <buttonNorth>k__BackingField;        // 0x198
        private UnityEngine.InputSystem.Controls.ButtonControl <buttonSouth>k__BackingField;        // 0x1A0
        private UnityEngine.InputSystem.Controls.ButtonControl <buttonEast>k__BackingField;        // 0x1A8
        private UnityEngine.InputSystem.Controls.ButtonControl <leftStickButton>k__BackingField;        // 0x1B0
        private UnityEngine.InputSystem.Controls.ButtonControl <rightStickButton>k__BackingField;        // 0x1B8
        private UnityEngine.InputSystem.Controls.ButtonControl <startButton>k__BackingField;        // 0x1C0
        private UnityEngine.InputSystem.Controls.ButtonControl <selectButton>k__BackingField;        // 0x1C8
        private UnityEngine.InputSystem.Controls.DpadControl <dpad>k__BackingField;        // 0x1D0
        private UnityEngine.InputSystem.Controls.ButtonControl <leftShoulder>k__BackingField;        // 0x1D8
        private UnityEngine.InputSystem.Controls.ButtonControl <rightShoulder>k__BackingField;        // 0x1E0
        private UnityEngine.InputSystem.Controls.StickControl <leftStick>k__BackingField;        // 0x1E8
        private UnityEngine.InputSystem.Controls.StickControl <rightStick>k__BackingField;        // 0x1F0
        private UnityEngine.InputSystem.Controls.ButtonControl <leftTrigger>k__BackingField;        // 0x1F8
        private UnityEngine.InputSystem.Controls.ButtonControl <rightTrigger>k__BackingField;        // 0x200
        private static UnityEngine.InputSystem.Gamepad <current>k__BackingField;        // 0x0
        private UnityEngine.InputSystem.Haptics.DualMotorRumble m_Rumble;        // 0x208
        private static System.Int32 s_GamepadCount;        // 0x8
        private static UnityEngine.InputSystem.Gamepad[] s_Gamepads;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Controls.ButtonControl get_buttonWest() { }
        private System.Void set_buttonWest(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_buttonNorth() { }
        private System.Void set_buttonNorth(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_buttonSouth() { }
        private System.Void set_buttonSouth(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_buttonEast() { }
        private System.Void set_buttonEast(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_leftStickButton() { }
        private System.Void set_leftStickButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_rightStickButton() { }
        private System.Void set_rightStickButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_startButton() { }
        private System.Void set_startButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_selectButton() { }
        private System.Void set_selectButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.DpadControl get_dpad() { }
        private System.Void set_dpad(UnityEngine.InputSystem.Controls.DpadControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_leftShoulder() { }
        private System.Void set_leftShoulder(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_rightShoulder() { }
        private System.Void set_rightShoulder(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.StickControl get_leftStick() { }
        private System.Void set_leftStick(UnityEngine.InputSystem.Controls.StickControl value) { }
        private UnityEngine.InputSystem.Controls.StickControl get_rightStick() { }
        private System.Void set_rightStick(UnityEngine.InputSystem.Controls.StickControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_leftTrigger() { }
        private System.Void set_leftTrigger(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_rightTrigger() { }
        private System.Void set_rightTrigger(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_aButton() { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_bButton() { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_xButton() { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_yButton() { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_triangleButton() { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_squareButton() { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_circleButton() { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_crossButton() { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_Item(UnityEngine.InputSystem.LowLevel.GamepadButton button) { }
        private UnityEngine.InputSystem.Gamepad get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.Gamepad value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Gamepad> get_all() { }
        private System.Void FinishSetup() { }
        private System.Void MakeCurrent() { }
        private System.Void OnAdded() { }
        private System.Void OnRemoved() { }
        private System.Void PauseHaptics() { }
        private System.Void ResumeHaptics() { }
        private System.Void ResetHaptics() { }
        private System.Void SetMotorSpeeds(System.Single lowFrequency, System.Single highFrequency) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000086
    public class InputDevice : InputControl
    {
        // Fields
        public static System.Int32 InvalidDeviceId;        // 0x0
        private static System.Int32 kLocalParticipantId;        // 0x0
        private static System.Int32 kInvalidDeviceIndex;        // 0x0
        private UnityEngine.InputSystem.InputDevice.DeviceFlags m_DeviceFlags;        // 0xE0
        private System.Int32 m_DeviceId;        // 0xE4
        private System.Int32 m_ParticipantId;        // 0xE8
        private System.Int32 m_DeviceIndex;        // 0xEC
        private System.UInt32 m_CurrentProcessedEventBytesOnUpdate;        // 0xF0
        private UnityEngine.InputSystem.Layouts.InputDeviceDescription m_Description;        // 0xF8
        private System.Double m_LastUpdateTimeInternal;        // 0x130
        private System.UInt32 m_CurrentUpdateStepCount;        // 0x138
        private UnityEngine.InputSystem.Utilities.InternedString[] m_AliasesForEachControl;        // 0x140
        private UnityEngine.InputSystem.Utilities.InternedString[] m_UsagesForEachControl;        // 0x148
        private UnityEngine.InputSystem.InputControl[] m_UsageToControl;        // 0x150
        private UnityEngine.InputSystem.InputControl[] m_ChildrenForEachControl;        // 0x158
        private System.Collections.Generic.HashSet<System.Int32> m_UpdatedButtons;        // 0x160
        private System.Collections.Generic.List<UnityEngine.InputSystem.Controls.ButtonControl> m_ButtonControlsCheckingPressState;        // 0x168
        private System.Boolean m_UseCachePathForButtonPresses;        // 0x170
        private System.UInt32[] m_StateOffsetToControlMap;        // 0x178
        private UnityEngine.InputSystem.InputDevice.ControlBitRangeNode[] m_ControlTreeNodes;        // 0x180
        private System.UInt16[] m_ControlTreeIndices;        // 0x188
        private static System.Int32 kControlIndexBits;        // 0x0
        private static System.Int32 kStateOffsetBits;        // 0x0
        private static System.Int32 kStateSizeBits;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Layouts.InputDeviceDescription get_description() { }
        private System.Boolean get_enabled() { }
        private System.Boolean get_canRunInBackground() { }
        private System.Boolean get_canDeviceRunInBackground() { }
        private System.Boolean get_added() { }
        private System.Boolean get_remote() { }
        private System.Boolean get_native() { }
        private System.Boolean get_updateBeforeRender() { }
        private System.Int32 get_deviceId() { }
        private System.Double get_lastUpdateTime() { }
        private System.Boolean get_wasUpdatedThisFrame() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_allControls() { }
        private System.Type get_valueType() { }
        private System.Int32 get_valueSizeInBytes() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_all() { }
        private System.Void .ctor() { }
        private System.Object ReadValueFromBufferAsObject(System.Void* buffer, System.Int32 bufferSize) { }
        private System.Object ReadValueFromStateAsObject(System.Void* statePtr) { }
        private System.Void ReadValueFromStateIntoBuffer(System.Void* statePtr, System.Void* bufferPtr, System.Int32 bufferSize) { }
        private System.Boolean CompareValue(System.Void* firstStatePtr, System.Void* secondStatePtr) { }
        private System.Void NotifyConfigurationChanged() { }
        private System.Void MakeCurrent() { }
        private System.Void OnAdded() { }
        private System.Void OnRemoved() { }
        private System.Void OnConfigurationChanged() { }
        private System.Int64 ExecuteCommand(TCommand& command) { }
        private System.Int64 ExecuteCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommand* commandPtr) { }
        private System.Boolean QueryEnabledStateFromRuntime() { }
        private System.Boolean get_disabledInFrontend() { }
        private System.Void set_disabledInFrontend(System.Boolean value) { }
        private System.Boolean get_disabledInRuntime() { }
        private System.Void set_disabledInRuntime(System.Boolean value) { }
        private System.Boolean get_disabledWhileInBackground() { }
        private System.Void set_disabledWhileInBackground(System.Boolean value) { }
        private System.UInt32 EncodeStateOffsetToControlMapEntry(System.UInt32 controlIndex, System.UInt32 stateOffsetInBits, System.UInt32 stateSizeInBits) { }
        private System.Void DecodeStateOffsetToControlMapEntry(System.UInt32 entry, System.UInt32& controlIndex, System.UInt32& stateOffset, System.UInt32& stateSize) { }
        private System.Boolean get_hasControlsWithDefaultState() { }
        private System.Void set_hasControlsWithDefaultState(System.Boolean value) { }
        private System.Boolean get_hasDontResetControls() { }
        private System.Void set_hasDontResetControls(System.Boolean value) { }
        private System.Boolean get_hasStateCallbacks() { }
        private System.Void set_hasStateCallbacks(System.Boolean value) { }
        private System.Boolean get_hasEventMerger() { }
        private System.Void set_hasEventMerger(System.Boolean value) { }
        private System.Boolean get_hasEventPreProcessor() { }
        private System.Void set_hasEventPreProcessor(System.Boolean value) { }
        private System.Void AddDeviceUsage(UnityEngine.InputSystem.Utilities.InternedString usage) { }
        private System.Void RemoveDeviceUsage(UnityEngine.InputSystem.Utilities.InternedString usage) { }
        private System.Void ClearDeviceUsages() { }
        private System.Boolean RequestSync() { }
        private System.Boolean RequestReset() { }
        private System.Boolean ExecuteEnableCommand() { }
        private System.Boolean ExecuteDisableCommand() { }
        private System.Void NotifyAdded() { }
        private System.Void NotifyRemoved() { }
        private TDevice Build(System.String layoutName, System.String layoutVariants, UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription, System.Boolean noPrecompiledLayouts) { }
        private System.Void WriteChangedControlStates(System.Byte* deviceStateBuffer, System.Void* statePtr, System.UInt32 stateSizeInBytes, System.UInt32 stateOffsetInDevice) { }
        private System.Void WritePartialChangedControlStatesInternal(System.UInt32 stateSizeInBits, System.UInt32 stateOffsetInDeviceInBits, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parentNode, System.UInt32 startOffset) { }
        private System.Void DumpControlBitRangeNode(System.Int32 nodeIndex, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode node, System.UInt32 startOffset, System.UInt32 sizeInBits, System.Collections.Generic.List<System.String> output) { }
        private System.Void DumpControlTree(UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parentNode, System.UInt32 startOffset, System.Collections.Generic.List<System.String> output) { }
        private System.String DumpControlTree() { }
        private System.Void WriteChangedControlStatesInternal(System.Void* statePtr, System.Byte* deviceStatePtr, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parentNode, System.UInt32 startOffset) { }
        private System.Boolean HasDataChangedInRange(System.Byte* deviceStatePtr, System.Void* statePtr, System.UInt32 startOffset, System.UInt32 sizeInBits) { }

    }

    // TypeToken: 0x2000089
    public struct InputDeviceChange
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.InputDeviceChange Added;        // 0x0
        public static UnityEngine.InputSystem.InputDeviceChange Removed;        // 0x0
        public static UnityEngine.InputSystem.InputDeviceChange Disconnected;        // 0x0
        public static UnityEngine.InputSystem.InputDeviceChange Reconnected;        // 0x0
        public static UnityEngine.InputSystem.InputDeviceChange Enabled;        // 0x0
        public static UnityEngine.InputSystem.InputDeviceChange Disabled;        // 0x0
        public static UnityEngine.InputSystem.InputDeviceChange UsageChanged;        // 0x0
        public static UnityEngine.InputSystem.InputDeviceChange ConfigurationChanged;        // 0x0
        public static UnityEngine.InputSystem.InputDeviceChange SoftReset;        // 0x0
        public static UnityEngine.InputSystem.InputDeviceChange HardReset;        // 0x0
        public static UnityEngine.InputSystem.InputDeviceChange Destroyed;        // 0x0

    }

    // TypeToken: 0x200008A
    public class Joystick : InputDevice
    {
        // Fields
        private UnityEngine.InputSystem.Controls.ButtonControl <trigger>k__BackingField;        // 0x190
        private UnityEngine.InputSystem.Controls.StickControl <stick>k__BackingField;        // 0x198
        private UnityEngine.InputSystem.Controls.AxisControl <twist>k__BackingField;        // 0x1A0
        private UnityEngine.InputSystem.Controls.Vector2Control <hatswitch>k__BackingField;        // 0x1A8
        private static UnityEngine.InputSystem.Joystick <current>k__BackingField;        // 0x0
        private static System.Int32 s_JoystickCount;        // 0x8
        private static UnityEngine.InputSystem.Joystick[] s_Joysticks;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Controls.ButtonControl get_trigger() { }
        private System.Void set_trigger(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.StickControl get_stick() { }
        private System.Void set_stick(UnityEngine.InputSystem.Controls.StickControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_twist() { }
        private System.Void set_twist(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.Vector2Control get_hatswitch() { }
        private System.Void set_hatswitch(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private UnityEngine.InputSystem.Joystick get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.Joystick value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Joystick> get_all() { }
        private System.Void FinishSetup() { }
        private System.Void MakeCurrent() { }
        private System.Void OnAdded() { }
        private System.Void OnRemoved() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008B
    public struct Key
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Key None;        // 0x0
        public static UnityEngine.InputSystem.Key Space;        // 0x0
        public static UnityEngine.InputSystem.Key Enter;        // 0x0
        public static UnityEngine.InputSystem.Key Tab;        // 0x0
        public static UnityEngine.InputSystem.Key Backquote;        // 0x0
        public static UnityEngine.InputSystem.Key Quote;        // 0x0
        public static UnityEngine.InputSystem.Key Semicolon;        // 0x0
        public static UnityEngine.InputSystem.Key Comma;        // 0x0
        public static UnityEngine.InputSystem.Key Period;        // 0x0
        public static UnityEngine.InputSystem.Key Slash;        // 0x0
        public static UnityEngine.InputSystem.Key Backslash;        // 0x0
        public static UnityEngine.InputSystem.Key LeftBracket;        // 0x0
        public static UnityEngine.InputSystem.Key RightBracket;        // 0x0
        public static UnityEngine.InputSystem.Key Minus;        // 0x0
        public static UnityEngine.InputSystem.Key Equals;        // 0x0
        public static UnityEngine.InputSystem.Key A;        // 0x0
        public static UnityEngine.InputSystem.Key B;        // 0x0
        public static UnityEngine.InputSystem.Key C;        // 0x0
        public static UnityEngine.InputSystem.Key D;        // 0x0
        public static UnityEngine.InputSystem.Key E;        // 0x0
        public static UnityEngine.InputSystem.Key F;        // 0x0
        public static UnityEngine.InputSystem.Key G;        // 0x0
        public static UnityEngine.InputSystem.Key H;        // 0x0
        public static UnityEngine.InputSystem.Key I;        // 0x0
        public static UnityEngine.InputSystem.Key J;        // 0x0
        public static UnityEngine.InputSystem.Key K;        // 0x0
        public static UnityEngine.InputSystem.Key L;        // 0x0
        public static UnityEngine.InputSystem.Key M;        // 0x0
        public static UnityEngine.InputSystem.Key N;        // 0x0
        public static UnityEngine.InputSystem.Key O;        // 0x0
        public static UnityEngine.InputSystem.Key P;        // 0x0
        public static UnityEngine.InputSystem.Key Q;        // 0x0
        public static UnityEngine.InputSystem.Key R;        // 0x0
        public static UnityEngine.InputSystem.Key S;        // 0x0
        public static UnityEngine.InputSystem.Key T;        // 0x0
        public static UnityEngine.InputSystem.Key U;        // 0x0
        public static UnityEngine.InputSystem.Key V;        // 0x0
        public static UnityEngine.InputSystem.Key W;        // 0x0
        public static UnityEngine.InputSystem.Key X;        // 0x0
        public static UnityEngine.InputSystem.Key Y;        // 0x0
        public static UnityEngine.InputSystem.Key Z;        // 0x0
        public static UnityEngine.InputSystem.Key Digit1;        // 0x0
        public static UnityEngine.InputSystem.Key Digit2;        // 0x0
        public static UnityEngine.InputSystem.Key Digit3;        // 0x0
        public static UnityEngine.InputSystem.Key Digit4;        // 0x0
        public static UnityEngine.InputSystem.Key Digit5;        // 0x0
        public static UnityEngine.InputSystem.Key Digit6;        // 0x0
        public static UnityEngine.InputSystem.Key Digit7;        // 0x0
        public static UnityEngine.InputSystem.Key Digit8;        // 0x0
        public static UnityEngine.InputSystem.Key Digit9;        // 0x0
        public static UnityEngine.InputSystem.Key Digit0;        // 0x0
        public static UnityEngine.InputSystem.Key LeftShift;        // 0x0
        public static UnityEngine.InputSystem.Key RightShift;        // 0x0
        public static UnityEngine.InputSystem.Key LeftAlt;        // 0x0
        public static UnityEngine.InputSystem.Key RightAlt;        // 0x0
        public static UnityEngine.InputSystem.Key AltGr;        // 0x0
        public static UnityEngine.InputSystem.Key LeftCtrl;        // 0x0
        public static UnityEngine.InputSystem.Key RightCtrl;        // 0x0
        public static UnityEngine.InputSystem.Key LeftMeta;        // 0x0
        public static UnityEngine.InputSystem.Key RightMeta;        // 0x0
        public static UnityEngine.InputSystem.Key LeftWindows;        // 0x0
        public static UnityEngine.InputSystem.Key RightWindows;        // 0x0
        public static UnityEngine.InputSystem.Key LeftApple;        // 0x0
        public static UnityEngine.InputSystem.Key RightApple;        // 0x0
        public static UnityEngine.InputSystem.Key LeftCommand;        // 0x0
        public static UnityEngine.InputSystem.Key RightCommand;        // 0x0
        public static UnityEngine.InputSystem.Key ContextMenu;        // 0x0
        public static UnityEngine.InputSystem.Key Escape;        // 0x0
        public static UnityEngine.InputSystem.Key LeftArrow;        // 0x0
        public static UnityEngine.InputSystem.Key RightArrow;        // 0x0
        public static UnityEngine.InputSystem.Key UpArrow;        // 0x0
        public static UnityEngine.InputSystem.Key DownArrow;        // 0x0
        public static UnityEngine.InputSystem.Key Backspace;        // 0x0
        public static UnityEngine.InputSystem.Key PageDown;        // 0x0
        public static UnityEngine.InputSystem.Key PageUp;        // 0x0
        public static UnityEngine.InputSystem.Key Home;        // 0x0
        public static UnityEngine.InputSystem.Key End;        // 0x0
        public static UnityEngine.InputSystem.Key Insert;        // 0x0
        public static UnityEngine.InputSystem.Key Delete;        // 0x0
        public static UnityEngine.InputSystem.Key CapsLock;        // 0x0
        public static UnityEngine.InputSystem.Key NumLock;        // 0x0
        public static UnityEngine.InputSystem.Key PrintScreen;        // 0x0
        public static UnityEngine.InputSystem.Key ScrollLock;        // 0x0
        public static UnityEngine.InputSystem.Key Pause;        // 0x0
        public static UnityEngine.InputSystem.Key NumpadEnter;        // 0x0
        public static UnityEngine.InputSystem.Key NumpadDivide;        // 0x0
        public static UnityEngine.InputSystem.Key NumpadMultiply;        // 0x0
        public static UnityEngine.InputSystem.Key NumpadPlus;        // 0x0
        public static UnityEngine.InputSystem.Key NumpadMinus;        // 0x0
        public static UnityEngine.InputSystem.Key NumpadPeriod;        // 0x0
        public static UnityEngine.InputSystem.Key NumpadEquals;        // 0x0
        public static UnityEngine.InputSystem.Key Numpad0;        // 0x0
        public static UnityEngine.InputSystem.Key Numpad1;        // 0x0
        public static UnityEngine.InputSystem.Key Numpad2;        // 0x0
        public static UnityEngine.InputSystem.Key Numpad3;        // 0x0
        public static UnityEngine.InputSystem.Key Numpad4;        // 0x0
        public static UnityEngine.InputSystem.Key Numpad5;        // 0x0
        public static UnityEngine.InputSystem.Key Numpad6;        // 0x0
        public static UnityEngine.InputSystem.Key Numpad7;        // 0x0
        public static UnityEngine.InputSystem.Key Numpad8;        // 0x0
        public static UnityEngine.InputSystem.Key Numpad9;        // 0x0
        public static UnityEngine.InputSystem.Key F1;        // 0x0
        public static UnityEngine.InputSystem.Key F2;        // 0x0
        public static UnityEngine.InputSystem.Key F3;        // 0x0
        public static UnityEngine.InputSystem.Key F4;        // 0x0
        public static UnityEngine.InputSystem.Key F5;        // 0x0
        public static UnityEngine.InputSystem.Key F6;        // 0x0
        public static UnityEngine.InputSystem.Key F7;        // 0x0
        public static UnityEngine.InputSystem.Key F8;        // 0x0
        public static UnityEngine.InputSystem.Key F9;        // 0x0
        public static UnityEngine.InputSystem.Key F10;        // 0x0
        public static UnityEngine.InputSystem.Key F11;        // 0x0
        public static UnityEngine.InputSystem.Key F12;        // 0x0
        public static UnityEngine.InputSystem.Key OEM1;        // 0x0
        public static UnityEngine.InputSystem.Key OEM2;        // 0x0
        public static UnityEngine.InputSystem.Key OEM3;        // 0x0
        public static UnityEngine.InputSystem.Key OEM4;        // 0x0
        public static UnityEngine.InputSystem.Key OEM5;        // 0x0
        public static UnityEngine.InputSystem.Key IMESelected;        // 0x0
        public static UnityEngine.InputSystem.Key F13;        // 0x0
        public static UnityEngine.InputSystem.Key F14;        // 0x0
        public static UnityEngine.InputSystem.Key F15;        // 0x0
        public static UnityEngine.InputSystem.Key F16;        // 0x0
        public static UnityEngine.InputSystem.Key F17;        // 0x0
        public static UnityEngine.InputSystem.Key F18;        // 0x0
        public static UnityEngine.InputSystem.Key F19;        // 0x0
        public static UnityEngine.InputSystem.Key F20;        // 0x0
        public static UnityEngine.InputSystem.Key F21;        // 0x0
        public static UnityEngine.InputSystem.Key F22;        // 0x0
        public static UnityEngine.InputSystem.Key F23;        // 0x0
        public static UnityEngine.InputSystem.Key F24;        // 0x0

    }

    // TypeToken: 0x200008C
    public class KeyEx
    {
        // Fields
        private static UnityEngine.InputSystem.Key IMESelected;        // 0x0
        private static UnityEngine.InputSystem.Key RemappedIMESelected;        // 0x0

    }

    // TypeToken: 0x200008D
    public class Keyboard : InputDevice, ITextInputReceiver, IEventPreProcessor
    {
        // Fields
        public static System.Int32 KeyCount;        // 0x0
        private static System.Int32 ExtendedKeyCount;        // 0x0
        private UnityEngine.InputSystem.Controls.AnyKeyControl <anyKey>k__BackingField;        // 0x190
        private UnityEngine.InputSystem.Controls.ButtonControl <shiftKey>k__BackingField;        // 0x198
        private UnityEngine.InputSystem.Controls.ButtonControl <ctrlKey>k__BackingField;        // 0x1A0
        private UnityEngine.InputSystem.Controls.ButtonControl <altKey>k__BackingField;        // 0x1A8
        private UnityEngine.InputSystem.Controls.ButtonControl <imeSelected>k__BackingField;        // 0x1B0
        private static UnityEngine.InputSystem.Keyboard <current>k__BackingField;        // 0x0
        private UnityEngine.InputSystem.Utilities.InlinedArray<System.Action<System.Char>> m_TextInputListeners;        // 0x1B8
        private System.String m_KeyboardLayoutName;        // 0x1D0
        private UnityEngine.InputSystem.Controls.KeyControl[] m_Keys;        // 0x1D8
        private UnityEngine.InputSystem.Utilities.InlinedArray<System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString>> m_ImeCompositionListeners;        // 0x1E0

        // Methods
        private System.Void add_onTextInput(System.Action<System.Char> value) { }
        private System.Void remove_onTextInput(System.Action<System.Char> value) { }
        private System.Void add_onIMECompositionChange(System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString> value) { }
        private System.Void remove_onIMECompositionChange(System.Action<UnityEngine.InputSystem.LowLevel.IMECompositionString> value) { }
        private System.Void SetIMEEnabled(System.Boolean enabled) { }
        private System.Void SetIMECursorPosition(UnityEngine.Vector2 position) { }
        private System.String get_keyboardLayout() { }
        private System.Void set_keyboardLayout(System.String value) { }
        private UnityEngine.InputSystem.Controls.AnyKeyControl get_anyKey() { }
        private System.Void set_anyKey(UnityEngine.InputSystem.Controls.AnyKeyControl value) { }
        private UnityEngine.InputSystem.Controls.KeyControl get_spaceKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_enterKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_tabKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_backquoteKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_quoteKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_semicolonKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_commaKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_periodKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_slashKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_backslashKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_leftBracketKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_rightBracketKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_minusKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_equalsKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_aKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_bKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_cKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_dKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_eKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_fKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_gKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_hKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_iKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_jKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_kKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_lKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_mKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_nKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_oKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_pKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_qKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_rKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_sKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_tKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_uKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_vKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_wKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_xKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_yKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_zKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_digit1Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_digit2Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_digit3Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_digit4Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_digit5Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_digit6Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_digit7Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_digit8Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_digit9Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_digit0Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_leftShiftKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_rightShiftKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_leftAltKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_rightAltKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_leftCtrlKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_rightCtrlKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_leftMetaKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_rightMetaKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_leftWindowsKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_rightWindowsKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_leftAppleKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_rightAppleKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_leftCommandKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_rightCommandKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_contextMenuKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_escapeKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_leftArrowKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_rightArrowKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_upArrowKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_downArrowKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_backspaceKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_pageDownKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_pageUpKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_homeKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_endKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_insertKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_deleteKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_capsLockKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_scrollLockKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numLockKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_printScreenKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_pauseKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpadEnterKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpadDivideKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpadMultiplyKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpadMinusKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpadPlusKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpadPeriodKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpadEqualsKey() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpad0Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpad1Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpad2Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpad3Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpad4Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpad5Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpad6Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpad7Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpad8Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_numpad9Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f1Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f2Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f3Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f4Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f5Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f6Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f7Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f8Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f9Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f10Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f11Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f12Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_oem1Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_oem2Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_oem3Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_oem4Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_oem5Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f13Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f14Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f15Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f16Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f17Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f18Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f19Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f20Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f21Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f22Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f23Key() { }
        private UnityEngine.InputSystem.Controls.KeyControl get_f24Key() { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_shiftKey() { }
        private System.Void set_shiftKey(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_ctrlKey() { }
        private System.Void set_ctrlKey(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_altKey() { }
        private System.Void set_altKey(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_imeSelected() { }
        private System.Void set_imeSelected(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.KeyControl get_Item(UnityEngine.InputSystem.Key key) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.KeyControl> get_allKeys() { }
        private UnityEngine.InputSystem.Keyboard get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.Keyboard value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void RefreshConfiguration() { }
        private System.Void OnTextInput(System.Char character) { }
        private UnityEngine.InputSystem.Controls.KeyControl FindKeyOnCurrentKeyboardLayout(System.String displayName) { }
        private System.Void OnIMECompositionChanged(UnityEngine.InputSystem.LowLevel.IMECompositionString compositionString) { }
        private System.Boolean UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr) { }
        private UnityEngine.InputSystem.Controls.KeyControl[] get_keys() { }
        private System.Void set_keys(UnityEngine.InputSystem.Controls.KeyControl[] value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008E
    public class Mouse : Pointer, IInputStateCallbackReceiver
    {
        // Fields
        private UnityEngine.InputSystem.Controls.DeltaControl <scroll>k__BackingField;        // 0x1C0
        private UnityEngine.InputSystem.Controls.ButtonControl <leftButton>k__BackingField;        // 0x1C8
        private UnityEngine.InputSystem.Controls.ButtonControl <middleButton>k__BackingField;        // 0x1D0
        private UnityEngine.InputSystem.Controls.ButtonControl <rightButton>k__BackingField;        // 0x1D8
        private UnityEngine.InputSystem.Controls.ButtonControl <backButton>k__BackingField;        // 0x1E0
        private UnityEngine.InputSystem.Controls.ButtonControl <forwardButton>k__BackingField;        // 0x1E8
        private UnityEngine.InputSystem.Controls.IntegerControl <clickCount>k__BackingField;        // 0x1F0
        private static UnityEngine.InputSystem.Mouse <current>k__BackingField;        // 0x0
        private static UnityEngine.InputSystem.Mouse s_PlatformMouseDevice;        // 0x8

        // Methods
        private UnityEngine.InputSystem.Controls.DeltaControl get_scroll() { }
        private System.Void set_scroll(UnityEngine.InputSystem.Controls.DeltaControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_leftButton() { }
        private System.Void set_leftButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_middleButton() { }
        private System.Void set_middleButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_rightButton() { }
        private System.Void set_rightButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_backButton() { }
        private System.Void set_backButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_forwardButton() { }
        private System.Void set_forwardButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.IntegerControl get_clickCount() { }
        private System.Void set_clickCount(UnityEngine.InputSystem.Controls.IntegerControl value) { }
        private UnityEngine.InputSystem.Mouse get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.Mouse value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnAdded() { }
        private System.Void OnRemoved() { }
        private System.Void WarpCursorPosition(UnityEngine.Vector2 position) { }
        private System.Void FinishSetup() { }
        private System.Void OnNextUpdate() { }
        private System.Void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }
        private System.Void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008F
    public struct PenButton
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.PenButton Tip;        // 0x0
        public static UnityEngine.InputSystem.PenButton Eraser;        // 0x0
        public static UnityEngine.InputSystem.PenButton BarrelFirst;        // 0x0
        public static UnityEngine.InputSystem.PenButton BarrelSecond;        // 0x0
        public static UnityEngine.InputSystem.PenButton InRange;        // 0x0
        public static UnityEngine.InputSystem.PenButton BarrelThird;        // 0x0
        public static UnityEngine.InputSystem.PenButton BarrelFourth;        // 0x0
        public static UnityEngine.InputSystem.PenButton Barrel1;        // 0x0
        public static UnityEngine.InputSystem.PenButton Barrel2;        // 0x0
        public static UnityEngine.InputSystem.PenButton Barrel3;        // 0x0
        public static UnityEngine.InputSystem.PenButton Barrel4;        // 0x0

    }

    // TypeToken: 0x2000090
    public class Pen : Pointer
    {
        // Fields
        private UnityEngine.InputSystem.Controls.ButtonControl <tip>k__BackingField;        // 0x1C0
        private UnityEngine.InputSystem.Controls.ButtonControl <eraser>k__BackingField;        // 0x1C8
        private UnityEngine.InputSystem.Controls.ButtonControl <firstBarrelButton>k__BackingField;        // 0x1D0
        private UnityEngine.InputSystem.Controls.ButtonControl <secondBarrelButton>k__BackingField;        // 0x1D8
        private UnityEngine.InputSystem.Controls.ButtonControl <thirdBarrelButton>k__BackingField;        // 0x1E0
        private UnityEngine.InputSystem.Controls.ButtonControl <fourthBarrelButton>k__BackingField;        // 0x1E8
        private UnityEngine.InputSystem.Controls.ButtonControl <inRange>k__BackingField;        // 0x1F0
        private UnityEngine.InputSystem.Controls.Vector2Control <tilt>k__BackingField;        // 0x1F8
        private UnityEngine.InputSystem.Controls.AxisControl <twist>k__BackingField;        // 0x200
        private static UnityEngine.InputSystem.Pen <current>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.ButtonControl get_tip() { }
        private System.Void set_tip(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_eraser() { }
        private System.Void set_eraser(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_firstBarrelButton() { }
        private System.Void set_firstBarrelButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_secondBarrelButton() { }
        private System.Void set_secondBarrelButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_thirdBarrelButton() { }
        private System.Void set_thirdBarrelButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_fourthBarrelButton() { }
        private System.Void set_fourthBarrelButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_inRange() { }
        private System.Void set_inRange(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.Vector2Control get_tilt() { }
        private System.Void set_tilt(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_twist() { }
        private System.Void set_twist(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Pen get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.Pen value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_Item(UnityEngine.InputSystem.PenButton button) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000091
    public class Pointer : InputDevice, IInputStateCallbackReceiver
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector2Control <position>k__BackingField;        // 0x190
        private UnityEngine.InputSystem.Controls.DeltaControl <delta>k__BackingField;        // 0x198
        private UnityEngine.InputSystem.Controls.Vector2Control <radius>k__BackingField;        // 0x1A0
        private UnityEngine.InputSystem.Controls.AxisControl <pressure>k__BackingField;        // 0x1A8
        private UnityEngine.InputSystem.Controls.ButtonControl <press>k__BackingField;        // 0x1B0
        private UnityEngine.InputSystem.Controls.IntegerControl <displayIndex>k__BackingField;        // 0x1B8
        private static UnityEngine.InputSystem.Pointer <current>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.Vector2Control get_position() { }
        private System.Void set_position(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private UnityEngine.InputSystem.Controls.DeltaControl get_delta() { }
        private System.Void set_delta(UnityEngine.InputSystem.Controls.DeltaControl value) { }
        private UnityEngine.InputSystem.Controls.Vector2Control get_radius() { }
        private System.Void set_radius(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_pressure() { }
        private System.Void set_pressure(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_press() { }
        private System.Void set_press(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.IntegerControl get_displayIndex() { }
        private System.Void set_displayIndex(UnityEngine.InputSystem.Controls.IntegerControl value) { }
        private UnityEngine.InputSystem.Pointer get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.Pointer value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void OnNextUpdate() { }
        private System.Void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }
        private System.Void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Boolean UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.UInt32& offset) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000092
    public class FastKeyboard : Keyboard
    {
        // Fields
        public static System.String metadata;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.InputSystem.Controls.AnyKeyControl Initialize_ctrlKeyboardanyKey(UnityEngine.InputSystem.Utilities.InternedString kAnyKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardescape(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardspace(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardenter(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardtab(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardbackquote(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardquote(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardsemicolon(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardcomma(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardperiod(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardslash(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardbackslash(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftBracket(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightBracket(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardminus(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardequals(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardupArrow(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboarddownArrow(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftArrow(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightArrow(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboarda(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardb(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardc(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardd(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboarde(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardg(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardh(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardi(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardj(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardk(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardl(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardm(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardn(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardo(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardp(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardq(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardr(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboards(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardt(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardu(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardv(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardw(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardx(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardy(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardz(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard1(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard2(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard3(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard4(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard5(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard6(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard7(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard8(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard9(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboard0(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftShift(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightShift(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DiscreteButtonControl Initialize_ctrlKeyboardshift(UnityEngine.InputSystem.Utilities.InternedString kDiscreteButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftAlt(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightAlt(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DiscreteButtonControl Initialize_ctrlKeyboardalt(UnityEngine.InputSystem.Utilities.InternedString kDiscreteButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftCtrl(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightCtrl(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DiscreteButtonControl Initialize_ctrlKeyboardctrl(UnityEngine.InputSystem.Utilities.InternedString kDiscreteButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardleftMeta(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardrightMeta(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardcontextMenu(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardbackspace(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardpageDown(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardpageUp(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardhome(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardend(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardinsert(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboarddelete(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardcapsLock(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumLock(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardprintScreen(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardscrollLock(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardpause(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadEnter(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadDivide(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadMultiply(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadPlus(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadMinus(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadPeriod(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpadEquals(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad1(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad2(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad3(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad4(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad5(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad6(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad7(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad8(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad9(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardnumpad0(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf1(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf2(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf3(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf4(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf5(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf6(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf7(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf8(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf9(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf10(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf11(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf12(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM1(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM2(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM3(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM4(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardOEM5(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf13(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf14(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf15(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf16(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf17(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf18(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf19(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf20(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf21(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf22(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf23(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.KeyControl Initialize_ctrlKeyboardf24(UnityEngine.InputSystem.Utilities.InternedString kKeyLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlKeyboardIMESelected(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }

    }

    // TypeToken: 0x2000093
    public class FastMouse : Mouse, IInputStateCallbackReceiver, IEventMerger
    {
        // Fields
        public static System.String metadata;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlMouseposition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlMousedelta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlMousescroll(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMousepress(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMouseleftButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMouserightButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMousemiddleButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMouseforwardButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlMousebackButton(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousepressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlMouseradius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlMousepointerId(UnityEngine.InputSystem.Utilities.InternedString kDigitalLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlMousedisplayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlMouseclickCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousepositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousepositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousedeltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrolldown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrollx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMousescrolly(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMouseradiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlMouseradiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private System.Void OnNextUpdate() { }
        private System.Void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }
        private System.Void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Boolean MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr) { }
        private System.Boolean UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr) { }

    }

    // TypeToken: 0x2000094
    public class FastTouchscreen : Touchscreen
    {
        // Fields
        public static System.String metadata;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreenprimaryTouch(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenposition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreendelta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenpressure(UnityEngine.InputSystem.Utilities.InternedString kAnalogLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenradius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreenpress(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreendisplayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch0(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch1(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch2(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch3(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch4(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch5(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch6(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch7(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch8(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchControl Initialize_ctrlTouchscreentouch9(UnityEngine.InputSystem.Utilities.InternedString kTouchLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreenprimaryTouchtouchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenprimaryTouchposition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreenprimaryTouchdelta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchpressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenprimaryTouchradius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreenprimaryTouchphase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreenprimaryTouchpress(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreenprimaryTouchtapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreenprimaryTouchindirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreenprimaryTouchtap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreenprimaryTouchstartTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreenprimaryTouchstartPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchpositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchpositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenpositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenpositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreendeltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenradiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreenradiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch0touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch0position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch0delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch0radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch0phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch0press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch0tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch0displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch0indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch0tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch0startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch0startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch0startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch1touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch1position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch1delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch1radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch1phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch1press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch1tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch1displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch1indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch1tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch1startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch1startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch1startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch2touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch2position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch2delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch2radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch2phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch2press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch2tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch2displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch2indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch2tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch2startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch2startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch2startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch3touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch3position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch3delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch3radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch3phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch3press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch3tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch3displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch3indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch3tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch3startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch3startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch3startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch4touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch4position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch4delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch4radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch4phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch4press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch4tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch4displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch4indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch4tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch4startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch4startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch4startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch5touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch5position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch5delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch5radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch5phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch5press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch5tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch5displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch5indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch5tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch5startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch5startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch5startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch6touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch6position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch6delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch6radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch6phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch6press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch6tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch6displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch6indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch6tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch6startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch6startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch6startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch7touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch7position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch7delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch7radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch7phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch7press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch7tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch7displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch7indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch7tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch7startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch7startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch7startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch8touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch8position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch8delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch8radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch8phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch8press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch8tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch8displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch8indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch8tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch8startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch8startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch8startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch9touchId(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch9position(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DeltaControl Initialize_ctrlTouchscreentouch9delta(UnityEngine.InputSystem.Utilities.InternedString kDeltaLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9pressure(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch9radius(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPhaseControl Initialize_ctrlTouchscreentouch9phase(UnityEngine.InputSystem.Utilities.InternedString kTouchPhaseLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.TouchPressControl Initialize_ctrlTouchscreentouch9press(UnityEngine.InputSystem.Utilities.InternedString kTouchPressLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch9tapCount(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.IntegerControl Initialize_ctrlTouchscreentouch9displayIndex(UnityEngine.InputSystem.Utilities.InternedString kIntegerLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch9indirectTouch(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.ButtonControl Initialize_ctrlTouchscreentouch9tap(UnityEngine.InputSystem.Utilities.InternedString kButtonLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.DoubleControl Initialize_ctrlTouchscreentouch9startTime(UnityEngine.InputSystem.Utilities.InternedString kDoubleLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.Vector2Control Initialize_ctrlTouchscreentouch9startPosition(UnityEngine.InputSystem.Utilities.InternedString kVector2Layout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9positionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9positiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltaup(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltadown(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltaleft(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltaright(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltax(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9deltay(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9radiusx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9radiusy(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9startPositionx(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.Controls.AxisControl Initialize_ctrlTouchscreentouch9startPositiony(UnityEngine.InputSystem.Utilities.InternedString kAxisLayout, UnityEngine.InputSystem.InputControl parent) { }

    }

    // TypeToken: 0x2000095
    public class InputRemoting, IObservable`1, IObserver`1
    {
        // Fields
        private UnityEngine.InputSystem.InputRemoting.Flags m_Flags;        // 0x10
        private UnityEngine.InputSystem.InputManager m_LocalManager;        // 0x18
        private UnityEngine.InputSystem.InputRemoting.Subscriber[] m_Subscribers;        // 0x20
        private UnityEngine.InputSystem.InputRemoting.RemoteSender[] m_Senders;        // 0x28

        // Methods
        private System.Boolean get_sending() { }
        private System.Void set_sending(System.Boolean value) { }
        private System.Void .ctor(UnityEngine.InputSystem.InputManager manager, System.Boolean startSendingOnConnect) { }
        private System.Void StartSending() { }
        private System.Void StopSending() { }
        private System.Void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(UnityEngine.InputSystem.InputRemoting.Message msg) { }
        private System.Void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(System.Exception error) { }
        private System.Void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() { }
        private System.IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer) { }
        private System.Void SendInitialMessages() { }
        private System.Void SendAllGeneratedLayouts() { }
        private System.Void SendLayout(System.String layoutName) { }
        private System.Void SendAllDevices() { }
        private System.Void SendDevice(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void SendEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device) { }
        private System.Void SendDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change) { }
        private System.Void SendLayoutChange(System.String layout, UnityEngine.InputSystem.InputControlLayoutChange change) { }
        private System.Void Send(UnityEngine.InputSystem.InputRemoting.Message msg) { }
        private System.Int32 FindOrCreateSenderRecord(System.Int32 senderId) { }
        private UnityEngine.InputSystem.Utilities.InternedString BuildLayoutNamespace(System.Int32 senderId) { }
        private System.Int32 FindLocalDeviceId(System.Int32 remoteDeviceId, System.Int32 senderIndex) { }
        private UnityEngine.InputSystem.InputDevice TryGetDeviceByRemoteId(System.Int32 remoteDeviceId, System.Int32 senderIndex) { }
        private UnityEngine.InputSystem.InputManager get_manager() { }
        private System.Void RemoveRemoteDevices(System.Int32 participantId) { }
        private System.Byte[] SerializeData(TData data) { }
        private TData DeserializeData(System.Byte[] data) { }

    }

    // TypeToken: 0x20000AA
    public class RemoteInputPlayerConnection : ScriptableObject, IObserver`1, IObservable`1
    {
        // Fields
        public static readonly System.Guid kNewDeviceMsg;        // 0x0
        public static readonly System.Guid kNewLayoutMsg;        // 0x10
        public static readonly System.Guid kNewEventsMsg;        // 0x20
        public static readonly System.Guid kRemoveDeviceMsg;        // 0x30
        public static readonly System.Guid kChangeUsagesMsg;        // 0x40
        public static readonly System.Guid kStartSendingMsg;        // 0x50
        public static readonly System.Guid kStopSendingMsg;        // 0x60
        private UnityEngine.Networking.PlayerConnection.IEditorPlayerConnection m_Connection;        // 0x18
        private UnityEngine.InputSystem.RemoteInputPlayerConnection.Subscriber[] m_Subscribers;        // 0x20
        private System.Int32[] m_ConnectedIds;        // 0x28

        // Methods
        private System.Void Bind(UnityEngine.Networking.PlayerConnection.IEditorPlayerConnection connection, System.Boolean isConnected) { }
        private System.IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.InputRemoting.Message> observer) { }
        private System.Void OnConnected(System.Int32 id) { }
        private System.Void OnDisconnected(System.Int32 id) { }
        private System.Void OnNewDevice(UnityEngine.Networking.PlayerConnection.MessageEventArgs args) { }
        private System.Void OnNewLayout(UnityEngine.Networking.PlayerConnection.MessageEventArgs args) { }
        private System.Void OnNewEvents(UnityEngine.Networking.PlayerConnection.MessageEventArgs args) { }
        private System.Void OnRemoveDevice(UnityEngine.Networking.PlayerConnection.MessageEventArgs args) { }
        private System.Void OnChangeUsages(UnityEngine.Networking.PlayerConnection.MessageEventArgs args) { }
        private System.Void OnStartSending(UnityEngine.Networking.PlayerConnection.MessageEventArgs args) { }
        private System.Void OnStopSending(UnityEngine.Networking.PlayerConnection.MessageEventArgs args) { }
        private System.Void SendToSubscribers(UnityEngine.InputSystem.InputRemoting.MessageType type, UnityEngine.Networking.PlayerConnection.MessageEventArgs args) { }
        private System.Void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(UnityEngine.InputSystem.InputRemoting.Message msg) { }
        private System.Void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(System.Exception error) { }
        private System.Void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000AC
    public class Sensor : InputDevice
    {
        // Methods
        private System.Single get_samplingFrequency() { }
        private System.Void set_samplingFrequency(System.Single value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AD
    public class Accelerometer : Sensor
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector3Control <acceleration>k__BackingField;        // 0x190
        private static UnityEngine.InputSystem.Accelerometer <current>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.Vector3Control get_acceleration() { }
        private System.Void set_acceleration(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Accelerometer get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.Accelerometer value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AE
    public class Gyroscope : Sensor
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector3Control <angularVelocity>k__BackingField;        // 0x190
        private static UnityEngine.InputSystem.Gyroscope <current>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.Vector3Control get_angularVelocity() { }
        private System.Void set_angularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Gyroscope get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.Gyroscope value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000AF
    public class GravitySensor : Sensor
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector3Control <gravity>k__BackingField;        // 0x190
        private static UnityEngine.InputSystem.GravitySensor <current>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.Vector3Control get_gravity() { }
        private System.Void set_gravity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.GravitySensor get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.GravitySensor value) { }
        private System.Void FinishSetup() { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B0
    public class AttitudeSensor : Sensor
    {
        // Fields
        private UnityEngine.InputSystem.Controls.QuaternionControl <attitude>k__BackingField;        // 0x190
        private static UnityEngine.InputSystem.AttitudeSensor <current>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.QuaternionControl get_attitude() { }
        private System.Void set_attitude(UnityEngine.InputSystem.Controls.QuaternionControl value) { }
        private UnityEngine.InputSystem.AttitudeSensor get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.AttitudeSensor value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B1
    public class LinearAccelerationSensor : Sensor
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector3Control <acceleration>k__BackingField;        // 0x190
        private static UnityEngine.InputSystem.LinearAccelerationSensor <current>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.Vector3Control get_acceleration() { }
        private System.Void set_acceleration(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.LinearAccelerationSensor get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.LinearAccelerationSensor value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B2
    public class MagneticFieldSensor : Sensor
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector3Control <magneticField>k__BackingField;        // 0x190
        private static UnityEngine.InputSystem.MagneticFieldSensor <current>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.Vector3Control get_magneticField() { }
        private System.Void set_magneticField(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.MagneticFieldSensor get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.MagneticFieldSensor value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B3
    public class LightSensor : Sensor
    {
        // Fields
        private UnityEngine.InputSystem.Controls.AxisControl <lightLevel>k__BackingField;        // 0x190
        private static UnityEngine.InputSystem.LightSensor <current>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.AxisControl get_lightLevel() { }
        private System.Void set_lightLevel(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.LightSensor get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.LightSensor value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B4
    public class PressureSensor : Sensor
    {
        // Fields
        private UnityEngine.InputSystem.Controls.AxisControl <atmosphericPressure>k__BackingField;        // 0x190
        private static UnityEngine.InputSystem.PressureSensor <current>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.AxisControl get_atmosphericPressure() { }
        private System.Void set_atmosphericPressure(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.PressureSensor get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.PressureSensor value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B5
    public class ProximitySensor : Sensor
    {
        // Fields
        private UnityEngine.InputSystem.Controls.AxisControl <distance>k__BackingField;        // 0x190
        private static UnityEngine.InputSystem.ProximitySensor <current>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.AxisControl get_distance() { }
        private System.Void set_distance(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.ProximitySensor get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.ProximitySensor value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B6
    public class HumiditySensor : Sensor
    {
        // Fields
        private UnityEngine.InputSystem.Controls.AxisControl <relativeHumidity>k__BackingField;        // 0x190
        private static UnityEngine.InputSystem.HumiditySensor <current>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.AxisControl get_relativeHumidity() { }
        private System.Void set_relativeHumidity(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.HumiditySensor get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.HumiditySensor value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B7
    public class AmbientTemperatureSensor : Sensor
    {
        // Fields
        private UnityEngine.InputSystem.Controls.AxisControl <ambientTemperature>k__BackingField;        // 0x190
        private static UnityEngine.InputSystem.AmbientTemperatureSensor <current>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.AxisControl get_ambientTemperature() { }
        private System.Void set_ambientTemperature(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.AmbientTemperatureSensor get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.AmbientTemperatureSensor value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B8
    public class StepCounter : Sensor
    {
        // Fields
        private UnityEngine.InputSystem.Controls.IntegerControl <stepCounter>k__BackingField;        // 0x190
        private static UnityEngine.InputSystem.StepCounter <current>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.IntegerControl get_stepCounter() { }
        private System.Void set_stepCounter(UnityEngine.InputSystem.Controls.IntegerControl value) { }
        private UnityEngine.InputSystem.StepCounter get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.StepCounter value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B9
    public class HingeAngle : Sensor
    {
        // Fields
        private UnityEngine.InputSystem.Controls.AxisControl <angle>k__BackingField;        // 0x190
        private static UnityEngine.InputSystem.HingeAngle <current>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.AxisControl get_angle() { }
        private System.Void set_angle(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.HingeAngle get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.HingeAngle value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BA
    public struct TouchPhase
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.TouchPhase None;        // 0x0
        public static UnityEngine.InputSystem.TouchPhase Began;        // 0x0
        public static UnityEngine.InputSystem.TouchPhase Moved;        // 0x0
        public static UnityEngine.InputSystem.TouchPhase Ended;        // 0x0
        public static UnityEngine.InputSystem.TouchPhase Canceled;        // 0x0
        public static UnityEngine.InputSystem.TouchPhase Stationary;        // 0x0

    }

    // TypeToken: 0x20000BB
    public class Touchscreen : Pointer, IInputStateCallbackReceiver, IEventMerger, ICustomDeviceReset
    {
        // Fields
        private UnityEngine.InputSystem.Controls.TouchControl <primaryTouch>k__BackingField;        // 0x1C0
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> <touches>k__BackingField;        // 0x1C8
        private static readonly Unity.Profiling.ProfilerMarker k_TouchscreenUpdateMarker;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker k_TouchAllocateMarker;        // 0x8
        private static UnityEngine.InputSystem.Touchscreen <current>k__BackingField;        // 0x10
        private static System.Single s_TapTime;        // 0x18
        private static System.Single s_TapDelayTime;        // 0x1C
        private static System.Single s_TapRadiusSquared;        // 0x20

        // Methods
        private UnityEngine.InputSystem.Controls.TouchControl get_primaryTouch() { }
        private System.Void set_primaryTouch(UnityEngine.InputSystem.Controls.TouchControl value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> get_touches() { }
        private System.Void set_touches(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Controls.TouchControl> value) { }
        private UnityEngine.InputSystem.Controls.TouchControl[] get_touchControlArray() { }
        private System.Void set_touchControlArray(UnityEngine.InputSystem.Controls.TouchControl[] value) { }
        private UnityEngine.InputSystem.Touchscreen get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.Touchscreen value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void OnNextUpdate() { }
        private System.Void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }
        private System.Void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Boolean UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.UInt32& offset) { }
        private System.Void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset() { }
        private System.Boolean MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr) { }
        private System.Boolean UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr) { }
        private System.Void TriggerTap(UnityEngine.InputSystem.Controls.TouchControl control, UnityEngine.InputSystem.LowLevel.TouchState& state, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000BC
    public class TrackedDevice : InputDevice
    {
        // Fields
        private UnityEngine.InputSystem.Controls.IntegerControl <trackingState>k__BackingField;        // 0x190
        private UnityEngine.InputSystem.Controls.ButtonControl <isTracked>k__BackingField;        // 0x198
        private UnityEngine.InputSystem.Controls.Vector3Control <devicePosition>k__BackingField;        // 0x1A0
        private UnityEngine.InputSystem.Controls.QuaternionControl <deviceRotation>k__BackingField;        // 0x1A8

        // Methods
        private UnityEngine.InputSystem.Controls.IntegerControl get_trackingState() { }
        private System.Void set_trackingState(UnityEngine.InputSystem.Controls.IntegerControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_isTracked() { }
        private System.Void set_isTracked(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_devicePosition() { }
        private System.Void set_devicePosition(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.QuaternionControl get_deviceRotation() { }
        private System.Void set_deviceRotation(UnityEngine.InputSystem.Controls.QuaternionControl value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BD
    public class InputExtensions
    {
        // Methods
        private System.Boolean IsInProgress(UnityEngine.InputSystem.InputActionPhase phase) { }
        private System.Boolean IsEndedOrCanceled(UnityEngine.InputSystem.TouchPhase phase) { }
        private System.Boolean IsActive(UnityEngine.InputSystem.TouchPhase phase) { }
        private System.Boolean IsModifierKey(UnityEngine.InputSystem.Key key) { }
        private System.Boolean IsTextInputKey(UnityEngine.InputSystem.Key key) { }

    }

    // TypeToken: 0x20000BE
    public class InputFeatureNames
    {
        // Fields
        public static System.String kRunPlayerUpdatesInEditMode;        // 0x0
        public static System.String kDisableUnityRemoteSupport;        // 0x0
        public static System.String kUseOptimizedControls;        // 0x0
        public static System.String kUseReadValueCaching;        // 0x0
        public static System.String kParanoidReadValueCachingChecks;        // 0x0

    }

    // TypeToken: 0x20000BF
    public class InputManager
    {
        // Fields
        private static readonly Unity.Profiling.ProfilerMarker k_InputUpdateProfilerMarker;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker k_InputTryFindMatchingControllerMarker;        // 0x8
        private static readonly Unity.Profiling.ProfilerMarker k_InputAddDeviceMarker;        // 0x10
        private static readonly Unity.Profiling.ProfilerMarker k_InputRestoreDevicesAfterReloadMarker;        // 0x18
        private static readonly Unity.Profiling.ProfilerMarker k_InputRegisterCustomTypesMarker;        // 0x20
        private static readonly Unity.Profiling.ProfilerMarker k_InputOnBeforeUpdateMarker;        // 0x28
        private static readonly Unity.Profiling.ProfilerMarker k_InputOnAfterUpdateMarker;        // 0x30
        private static readonly Unity.Profiling.ProfilerMarker k_InputOnSettingsChangeMarker;        // 0x38
        private static readonly Unity.Profiling.ProfilerMarker k_InputOnDeviceSettingsChangeMarker;        // 0x40
        private static readonly Unity.Profiling.ProfilerMarker k_InputOnEventMarker;        // 0x48
        private static readonly Unity.Profiling.ProfilerMarker k_InputOnLayoutChangeMarker;        // 0x50
        private static readonly Unity.Profiling.ProfilerMarker k_InputOnDeviceChangeMarker;        // 0x58
        private static readonly Unity.Profiling.ProfilerMarker k_InputOnActionsChangeMarker;        // 0x60
        private System.Int32 m_LayoutRegistrationVersion;        // 0x10
        private System.Single m_PollingFrequency;        // 0x14
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Collection m_Layouts;        // 0x18
        private UnityEngine.InputSystem.Utilities.TypeTable m_Processors;        // 0x58
        private UnityEngine.InputSystem.Utilities.TypeTable m_Interactions;        // 0x60
        private UnityEngine.InputSystem.Utilities.TypeTable m_Composites;        // 0x68
        private System.Int32 m_DevicesCount;        // 0x70
        private UnityEngine.InputSystem.InputDevice[] m_Devices;        // 0x78
        private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.InputSystem.InputDevice> m_DevicesById;        // 0x80
        private System.Int32 m_AvailableDeviceCount;        // 0x88
        private UnityEngine.InputSystem.InputManager.AvailableDevice[] m_AvailableDevices;        // 0x90
        private System.Int32 m_DisconnectedDevicesCount;        // 0x98
        private UnityEngine.InputSystem.InputDevice[] m_DisconnectedDevices;        // 0xA0
        private UnityEngine.InputSystem.LowLevel.InputUpdateType m_UpdateMask;        // 0xA8
        private UnityEngine.InputSystem.LowLevel.InputUpdateType m_CurrentUpdate;        // 0xAC
        private UnityEngine.InputSystem.LowLevel.InputStateBuffers m_StateBuffers;        // 0xB0
        private UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior m_ScrollDeltaBehavior;        // 0xE8
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange>> m_DeviceChangeListeners;        // 0xF0
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr>> m_DeviceStateChangeListeners;        // 0x140
        private UnityEngine.InputSystem.Utilities.CallbackArray<UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate> m_DeviceFindLayoutCallbacks;        // 0x190
        private UnityEngine.InputSystem.Utilities.CallbackArray<UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate> m_DeviceCommandCallbacks;        // 0x1E0
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange>> m_LayoutChangeListeners;        // 0x230
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice>> m_EventListeners;        // 0x280
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> m_BeforeUpdateListeners;        // 0x2D0
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> m_AfterUpdateListeners;        // 0x320
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action> m_SettingsChangedListeners;        // 0x370
        private System.Boolean m_NativeBeforeUpdateHooked;        // 0x3C0
        private System.Boolean m_HaveDevicesWithStateCallbackReceivers;        // 0x3C1
        private System.Boolean m_HasFocus;        // 0x3C2
        private UnityEngine.InputSystem.LowLevel.InputEventStream m_InputEventStream;        // 0x3C8
        private UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate m_DeviceFindExecuteCommandDelegate;        // 0x440
        private System.Int32 m_DeviceFindExecuteCommandDeviceId;        // 0x448
        private UnityEngine.InputSystem.LowLevel.IInputRuntime m_Runtime;        // 0x450
        private UnityEngine.InputSystem.LowLevel.InputMetrics m_Metrics;        // 0x458
        private UnityEngine.InputSystem.InputSettings m_Settings;        // 0x490
        private System.Boolean m_OptimizedControlsFeatureEnabled;        // 0x498
        private System.Boolean m_ReadValueCachingFeatureEnabled;        // 0x499
        private System.Boolean m_ParanoidReadValueCachingChecksEnabled;        // 0x49A
        private System.Boolean m_ShouldMakeCurrentlyUpdatingDeviceCurrent;        // 0x49B
        private UnityEngine.InputSystem.InputManager.StateChangeMonitorsForDevice[] m_StateChangeMonitors;        // 0x4A0
        private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputManager.StateChangeMonitorTimeout> m_StateChangeMonitorTimeouts;        // 0x4A8

        // Methods
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices() { }
        private UnityEngine.InputSystem.Utilities.TypeTable get_processors() { }
        private UnityEngine.InputSystem.Utilities.TypeTable get_interactions() { }
        private UnityEngine.InputSystem.Utilities.TypeTable get_composites() { }
        private UnityEngine.InputSystem.LowLevel.InputMetrics get_metrics() { }
        private UnityEngine.InputSystem.InputSettings get_settings() { }
        private System.Void set_settings(UnityEngine.InputSystem.InputSettings value) { }
        private UnityEngine.InputSystem.LowLevel.InputUpdateType get_updateMask() { }
        private System.Void set_updateMask(UnityEngine.InputSystem.LowLevel.InputUpdateType value) { }
        private UnityEngine.InputSystem.LowLevel.InputUpdateType get_defaultUpdateType() { }
        private UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior get_scrollDeltaBehavior() { }
        private System.Void set_scrollDeltaBehavior(UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior value) { }
        private System.Single get_pollingFrequency() { }
        private System.Void set_pollingFrequency(System.Single value) { }
        private System.Void add_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }
        private System.Void remove_onDeviceChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> value) { }
        private System.Void add_onDeviceStateChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }
        private System.Void remove_onDeviceStateChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }
        private System.Void add_onDeviceCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate value) { }
        private System.Void remove_onDeviceCommand(UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate value) { }
        private System.Void add_onFindControlLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate value) { }
        private System.Void remove_onFindControlLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate value) { }
        private System.Void add_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }
        private System.Void remove_onLayoutChange(System.Action<System.String,UnityEngine.InputSystem.InputControlLayoutChange> value) { }
        private System.Void add_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> value) { }
        private System.Void remove_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> value) { }
        private System.Void add_onBeforeUpdate(System.Action value) { }
        private System.Void remove_onBeforeUpdate(System.Action value) { }
        private System.Void add_onAfterUpdate(System.Action value) { }
        private System.Void remove_onAfterUpdate(System.Action value) { }
        private System.Void add_onSettingsChange(System.Action value) { }
        private System.Void remove_onSettingsChange(System.Action value) { }
        private System.Boolean get_isProcessingEvents() { }
        private System.Boolean get_gameIsPlaying() { }
        private System.Boolean get_gameHasFocus() { }
        private System.Boolean get_gameShouldGetInputRegardlessOfFocus() { }
        private System.Void RegisterControlLayout(System.String name, System.Type type) { }
        private System.Void RegisterControlLayout(System.String json, System.String name, System.Boolean isOverride) { }
        private System.Void RegisterControlLayoutBuilder(System.Func<UnityEngine.InputSystem.Layouts.InputControlLayout> method, System.String name, System.String baseLayout) { }
        private System.Void PerformLayoutPostRegistration(UnityEngine.InputSystem.Utilities.InternedString layoutName, UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString> baseLayouts, System.Boolean isReplacement, System.Boolean isKnownToBeDeviceLayout, System.Boolean isOverride) { }
        private System.Void RegisterPrecompiledLayout(System.String metadata) { }
        private System.Void RecreateDevicesUsingLayout(UnityEngine.InputSystem.Utilities.InternedString layout, System.Boolean isKnownToBeDeviceLayout) { }
        private System.Boolean IsControlOrChildUsingLayoutRecursive(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Utilities.InternedString layout) { }
        private System.Boolean IsControlUsingLayout(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Utilities.InternedString layout) { }
        private System.Void RegisterControlLayoutMatcher(System.String layoutName, UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher) { }
        private System.Void RegisterControlLayoutMatcher(System.Type type, UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher) { }
        private System.Void RecreateDevicesUsingLayoutWithInferiorMatch(UnityEngine.InputSystem.Layouts.InputDeviceMatcher deviceMatcher) { }
        private System.Void RecreateDevice(UnityEngine.InputSystem.InputDevice oldDevice, UnityEngine.InputSystem.Utilities.InternedString newLayout) { }
        private System.Void AddAvailableDevicesMatchingDescription(UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher, UnityEngine.InputSystem.Utilities.InternedString layout) { }
        private System.Void RemoveControlLayout(System.String name) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadControlLayout(System.Type type) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadControlLayout(UnityEngine.InputSystem.Utilities.InternedString name) { }
        private UnityEngine.InputSystem.Utilities.InternedString TryFindMatchingControlLayout(UnityEngine.InputSystem.Layouts.InputDeviceDescription& deviceDescription, System.Int32 deviceId) { }
        private UnityEngine.InputSystem.Utilities.InternedString FindOrRegisterDeviceLayoutForType(System.Type type) { }
        private System.Boolean IsDeviceLayoutMarkedAsSupportedInSettings(UnityEngine.InputSystem.Utilities.InternedString layoutName) { }
        private System.Collections.Generic.IEnumerable<System.String> ListControlLayouts(System.String basedOn) { }
        private System.Int32 GetControls(System.String path, UnityEngine.InputSystem.InputControlList<TControl>& controls) { }
        private System.Void SetDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage) { }
        private System.Void AddDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage) { }
        private System.Void RemoveDeviceUsage(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Utilities.InternedString usage) { }
        private System.Void NotifyUsageChanged(UnityEngine.InputSystem.InputDevice device) { }
        private UnityEngine.InputSystem.InputDevice AddDevice(System.Type type, System.String name) { }
        private UnityEngine.InputSystem.InputDevice AddDevice(System.String layout, System.String name, UnityEngine.InputSystem.Utilities.InternedString variants) { }
        private UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Utilities.InternedString layout, System.Int32 deviceId, System.String deviceName, UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags, UnityEngine.InputSystem.Utilities.InternedString variants) { }
        private System.Void AddDevice(UnityEngine.InputSystem.InputDevice device) { }
        private UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription description) { }
        private UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription description, System.Boolean throwIfNoLayoutFound, System.String deviceName, System.Int32 deviceId, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags) { }
        private UnityEngine.InputSystem.InputDevice AddDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription description, UnityEngine.InputSystem.Utilities.InternedString layout, System.String deviceName, System.Int32 deviceId, UnityEngine.InputSystem.InputDevice.DeviceFlags deviceFlags) { }
        private System.Void RemoveDevice(UnityEngine.InputSystem.InputDevice device, System.Boolean keepOnListOfAvailableDevices) { }
        private System.Void FlushDisconnectedDevices() { }
        private System.Void ResetDevice(UnityEngine.InputSystem.InputDevice device, System.Boolean alsoResetDontResetControls, System.Nullable<System.Boolean> issueResetCommand) { }
        private UnityEngine.InputSystem.InputDevice TryGetDevice(System.String nameOrLayout) { }
        private UnityEngine.InputSystem.InputDevice GetDevice(System.String nameOrLayout) { }
        private UnityEngine.InputSystem.InputDevice TryGetDevice(System.Type layoutType) { }
        private UnityEngine.InputSystem.InputDevice TryGetDeviceById(System.Int32 id) { }
        private System.Int32 GetUnsupportedDevices(System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputDeviceDescription> descriptions) { }
        private System.Void EnableOrDisableDevice(UnityEngine.InputSystem.InputDevice device, System.Boolean enable, UnityEngine.InputSystem.InputManager.DeviceDisableScope scope) { }
        private System.Void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr) { }
        private System.Void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr) { }
        private System.Void QueueEvent(TEvent& inputEvent) { }
        private System.Void Update() { }
        private System.Void Update(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType) { }
        private System.Void Initialize(UnityEngine.InputSystem.LowLevel.IInputRuntime runtime, UnityEngine.InputSystem.InputSettings settings) { }
        private System.Void Destroy() { }
        private System.Void InitializeData() { }
        private System.Void RegisterCustomTypes(System.Type[] types) { }
        private System.Void RegisterCustomTypes() { }
        private System.Void InstallRuntime(UnityEngine.InputSystem.LowLevel.IInputRuntime runtime) { }
        private System.Void InstallGlobals() { }
        private System.Void UninstallGlobals() { }
        private System.Boolean get_optimizedControlsFeatureEnabled() { }
        private System.Void set_optimizedControlsFeatureEnabled(System.Boolean value) { }
        private System.Boolean get_readValueCachingFeatureEnabled() { }
        private System.Void set_readValueCachingFeatureEnabled(System.Boolean value) { }
        private System.Boolean get_paranoidReadValueCachingChecksEnabled() { }
        private System.Void set_paranoidReadValueCachingChecksEnabled(System.Boolean value) { }
        private System.Void MakeDeviceNameUnique(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void ResetControlPathsRecursive(UnityEngine.InputSystem.InputControl control) { }
        private System.Void AssignUniqueDeviceId(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void ReallocateStateBuffers() { }
        private System.Void InitializeDefaultState(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void InitializeDeviceState(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void OnNativeDeviceDiscovered(System.Int32 deviceId, System.String deviceDescriptor) { }
        private UnityEngine.InputSystem.Utilities.JsonParser.JsonString MakeEscapedJsonString(System.String theString) { }
        private UnityEngine.InputSystem.InputDevice TryMatchDisconnectedDevice(System.String deviceDescriptor) { }
        private System.Void InstallBeforeUpdateHookIfNecessary() { }
        private System.Void RestoreDevicesAfterDomainReloadIfNecessary() { }
        private System.Void WarnAboutDevicesFailingToRecreateAfterDomainReload() { }
        private System.Void OnBeforeUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType) { }
        private System.Void ApplySettings() { }
        private System.Int64 ExecuteGlobalCommand(TCommand& command) { }
        private System.Void AddAvailableDevicesThatAreNowRecognized() { }
        private System.Boolean ShouldRunDeviceInBackground(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void OnFocusChanged(System.Boolean focus) { }
        private System.Boolean ShouldRunUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType) { }
        private System.Void OnUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, UnityEngine.InputSystem.LowLevel.InputEventBuffer& eventBuffer) { }
        private System.Boolean AreMaximumEventBytesPerUpdateExceeded(System.UInt32 totalEventBytesProcessed) { }
        private System.String MakeStringWithEventsProcessedByDevice() { }
        private System.Void ResetCurrentProcessedEventBytesForDevices() { }
        private System.Void CheckAllDevicesOptimizedControlsHaveValidState() { }
        private System.Void InvokeAfterUpdateCallback(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType) { }
        private System.Void DontMakeCurrentlyUpdatingDeviceCurrent() { }
        private System.Boolean UpdateState(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType) { }
        private System.Boolean UpdateState(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, System.Void* statePtr, System.UInt32 stateOffsetInDevice, System.UInt32 stateSize, System.Double internalTime, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void WriteStateChange(UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers buffers, System.Int32 deviceIndex, UnityEngine.InputSystem.LowLevel.InputStateBlock& deviceStateBlock, System.UInt32 stateOffsetInDevice, System.Void* statePtr, System.UInt32 stateSizeInBytes, System.Boolean flippedBuffers) { }
        private System.Boolean FlipBuffersForDeviceIfNecessary(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType) { }
        private System.Void AddStateChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Int64 monitorIndex, System.UInt32 groupIndex) { }
        private System.Void RemoveStateChangeMonitors(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void RemoveStateChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Int64 monitorIndex) { }
        private System.Void AddStateChangeMonitorTimeout(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Double time, System.Int64 monitorIndex, System.Int32 timerIndex) { }
        private System.Void RemoveStateChangeMonitorTimeout(UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Int64 monitorIndex, System.Int32 timerIndex) { }
        private System.Void SortStateChangeMonitorsIfNecessary(System.Int32 deviceIndex) { }
        private System.Void SignalStateChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor) { }
        private System.Void FireStateChangeNotifications() { }
        private System.Boolean ProcessStateChangeMonitors(System.Int32 deviceIndex, System.Void* newStateFromEvent, System.Void* oldStateOfDevice, System.UInt32 newStateSizeInBytes, System.UInt32 newStateOffsetInBytes) { }
        private System.Void FireStateChangeNotifications(System.Int32 deviceIndex, System.Double internalTime, UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr) { }
        private System.Void ProcessStateChangeMonitorTimeouts() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }
        private System.Int64 <TryFindMatchingControlLayout>b__88_0(UnityEngine.InputSystem.LowLevel.InputDeviceCommand& commandRef) { }

    }

    // TypeToken: 0x20000C8
    public class InputSettings : ScriptableObject
    {
        // Fields
        private System.String[] m_SupportedDevices;        // 0x18
        private UnityEngine.InputSystem.InputSettings.UpdateMode m_UpdateMode;        // 0x20
        private UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior m_ScrollDeltaBehavior;        // 0x24
        private System.Int32 m_MaxEventBytesPerUpdate;        // 0x28
        private System.Int32 m_MaxQueuedEventsPerUpdate;        // 0x2C
        private System.Boolean m_CompensateForScreenOrientation;        // 0x30
        private UnityEngine.InputSystem.InputSettings.BackgroundBehavior m_BackgroundBehavior;        // 0x34
        private UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode m_EditorInputBehaviorInPlayMode;        // 0x38
        private UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode m_InputActionPropertyDrawerMode;        // 0x3C
        private System.Single m_DefaultDeadzoneMin;        // 0x40
        private System.Single m_DefaultDeadzoneMax;        // 0x44
        private System.Single m_DefaultButtonPressPoint;        // 0x48
        private System.Single m_ButtonReleaseThreshold;        // 0x4C
        private System.Single m_DefaultTapTime;        // 0x50
        private System.Single m_DefaultSlowTapTime;        // 0x54
        private System.Single m_DefaultHoldTime;        // 0x58
        private System.Single m_TapRadius;        // 0x5C
        private System.Single m_MultiTapDelayTime;        // 0x60
        private System.Boolean m_DisableRedundantEventsMerging;        // 0x64
        private System.Boolean m_ShortcutKeysConsumeInputs;        // 0x65
        private System.Collections.Generic.HashSet<System.String> m_FeatureFlags;        // 0x68
        private static System.Int32 s_OldUnsupportedFixedAndDynamicUpdateSetting;        // 0x0

        // Methods
        private UnityEngine.InputSystem.InputSettings.UpdateMode get_updateMode() { }
        private System.Void set_updateMode(UnityEngine.InputSystem.InputSettings.UpdateMode value) { }
        private UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior get_scrollDeltaBehavior() { }
        private System.Void set_scrollDeltaBehavior(UnityEngine.InputSystem.InputSettings.ScrollDeltaBehavior value) { }
        private System.Boolean get_compensateForScreenOrientation() { }
        private System.Void set_compensateForScreenOrientation(System.Boolean value) { }
        private System.Boolean get_filterNoiseOnCurrent() { }
        private System.Void set_filterNoiseOnCurrent(System.Boolean value) { }
        private System.Single get_defaultDeadzoneMin() { }
        private System.Void set_defaultDeadzoneMin(System.Single value) { }
        private System.Single get_defaultDeadzoneMax() { }
        private System.Void set_defaultDeadzoneMax(System.Single value) { }
        private System.Single get_defaultButtonPressPoint() { }
        private System.Void set_defaultButtonPressPoint(System.Single value) { }
        private System.Single get_buttonReleaseThreshold() { }
        private System.Void set_buttonReleaseThreshold(System.Single value) { }
        private System.Single get_defaultTapTime() { }
        private System.Void set_defaultTapTime(System.Single value) { }
        private System.Single get_defaultSlowTapTime() { }
        private System.Void set_defaultSlowTapTime(System.Single value) { }
        private System.Single get_defaultHoldTime() { }
        private System.Void set_defaultHoldTime(System.Single value) { }
        private System.Single get_tapRadius() { }
        private System.Void set_tapRadius(System.Single value) { }
        private System.Single get_multiTapDelayTime() { }
        private System.Void set_multiTapDelayTime(System.Single value) { }
        private UnityEngine.InputSystem.InputSettings.BackgroundBehavior get_backgroundBehavior() { }
        private System.Void set_backgroundBehavior(UnityEngine.InputSystem.InputSettings.BackgroundBehavior value) { }
        private UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode get_editorInputBehaviorInPlayMode() { }
        private System.Void set_editorInputBehaviorInPlayMode(UnityEngine.InputSystem.InputSettings.EditorInputBehaviorInPlayMode value) { }
        private UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode get_inputActionPropertyDrawerMode() { }
        private System.Void set_inputActionPropertyDrawerMode(UnityEngine.InputSystem.InputSettings.InputActionPropertyDrawerMode value) { }
        private System.Int32 get_maxEventBytesPerUpdate() { }
        private System.Void set_maxEventBytesPerUpdate(System.Int32 value) { }
        private System.Int32 get_maxQueuedEventsPerUpdate() { }
        private System.Void set_maxQueuedEventsPerUpdate(System.Int32 value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.String> get_supportedDevices() { }
        private System.Void set_supportedDevices(UnityEngine.InputSystem.Utilities.ReadOnlyArray<System.String> value) { }
        private System.Boolean get_disableRedundantEventsMerging() { }
        private System.Void set_disableRedundantEventsMerging(System.Boolean value) { }
        private System.Boolean get_shortcutKeysConsumeInput() { }
        private System.Void set_shortcutKeysConsumeInput(System.Boolean value) { }
        private System.Void SetInternalFeatureFlag(System.String featureName, System.Boolean enabled) { }
        private System.Boolean IsFeatureEnabled(System.String featureName) { }
        private System.Void OnChange() { }
        private System.Boolean CompareFloats(System.Single a, System.Single b) { }
        private System.Boolean CompareSets(UnityEngine.InputSystem.Utilities.ReadOnlyArray<T> a, UnityEngine.InputSystem.Utilities.ReadOnlyArray<T> b) { }
        private System.Boolean CompareFeatureFlag(UnityEngine.InputSystem.InputSettings a, UnityEngine.InputSystem.InputSettings b, System.String featureName) { }
        private System.Boolean AreEqual(UnityEngine.InputSystem.InputSettings a, UnityEngine.InputSystem.InputSettings b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CE
    public class DefaultInputActions, IInputActionCollection2, IInputActionCollection, IEnumerable`1, IEnumerable, IDisposable
    {
        // Fields
        private readonly UnityEngine.InputSystem.InputActionAsset <asset>k__BackingField;        // 0x10
        private readonly UnityEngine.InputSystem.InputActionMap m_Player;        // 0x18
        private UnityEngine.InputSystem.DefaultInputActions.IPlayerActions m_PlayerActionsCallbackInterface;        // 0x20
        private readonly UnityEngine.InputSystem.InputAction m_Player_Move;        // 0x28
        private readonly UnityEngine.InputSystem.InputAction m_Player_Look;        // 0x30
        private readonly UnityEngine.InputSystem.InputAction m_Player_Fire;        // 0x38
        private readonly UnityEngine.InputSystem.InputActionMap m_UI;        // 0x40
        private UnityEngine.InputSystem.DefaultInputActions.IUIActions m_UIActionsCallbackInterface;        // 0x48
        private readonly UnityEngine.InputSystem.InputAction m_UI_Navigate;        // 0x50
        private readonly UnityEngine.InputSystem.InputAction m_UI_Submit;        // 0x58
        private readonly UnityEngine.InputSystem.InputAction m_UI_Cancel;        // 0x60
        private readonly UnityEngine.InputSystem.InputAction m_UI_Point;        // 0x68
        private readonly UnityEngine.InputSystem.InputAction m_UI_Click;        // 0x70
        private readonly UnityEngine.InputSystem.InputAction m_UI_ScrollWheel;        // 0x78
        private readonly UnityEngine.InputSystem.InputAction m_UI_MiddleClick;        // 0x80
        private readonly UnityEngine.InputSystem.InputAction m_UI_RightClick;        // 0x88
        private readonly UnityEngine.InputSystem.InputAction m_UI_TrackedDevicePosition;        // 0x90
        private readonly UnityEngine.InputSystem.InputAction m_UI_TrackedDeviceOrientation;        // 0x98
        private System.Int32 m_KeyboardMouseSchemeIndex;        // 0xA0
        private System.Int32 m_GamepadSchemeIndex;        // 0xA4
        private System.Int32 m_TouchSchemeIndex;        // 0xA8
        private System.Int32 m_JoystickSchemeIndex;        // 0xAC
        private System.Int32 m_XRSchemeIndex;        // 0xB0

        // Methods
        private UnityEngine.InputSystem.InputActionAsset get_asset() { }
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask() { }
        private System.Void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value) { }
        private System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices() { }
        private System.Void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes() { }
        private System.Boolean Contains(UnityEngine.InputSystem.InputAction action) { }
        private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void Enable() { }
        private System.Void Disable() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings() { }
        private UnityEngine.InputSystem.InputAction FindAction(System.String actionNameOrId, System.Boolean throwIfNotFound) { }
        private System.Int32 FindBinding(UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.InputAction& action) { }
        private UnityEngine.InputSystem.DefaultInputActions.PlayerActions get_Player() { }
        private UnityEngine.InputSystem.DefaultInputActions.UIActions get_UI() { }
        private UnityEngine.InputSystem.InputControlScheme get_KeyboardMouseScheme() { }
        private UnityEngine.InputSystem.InputControlScheme get_GamepadScheme() { }
        private UnityEngine.InputSystem.InputControlScheme get_TouchScheme() { }
        private UnityEngine.InputSystem.InputControlScheme get_JoystickScheme() { }
        private UnityEngine.InputSystem.InputControlScheme get_XRScheme() { }

    }

    // TypeToken: 0x20000D3
    public class InputValue
    {
        // Fields
        private System.Nullable<UnityEngine.InputSystem.InputAction.CallbackContext> m_Context;        // 0x10

        // Methods
        private System.Object Get() { }
        private TValue Get() { }
        private System.Boolean get_isPressed() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D4
    public class PlayerInput : MonoBehaviour
    {
        // Fields
        public static System.String DeviceLostMessage;        // 0x0
        public static System.String DeviceRegainedMessage;        // 0x0
        public static System.String ControlsChangedMessage;        // 0x0
        private System.Int32 m_AllMapsHashCode;        // 0x18
        private UnityEngine.InputSystem.InputActionAsset m_Actions;        // 0x20
        private UnityEngine.InputSystem.PlayerNotifications m_NotificationBehavior;        // 0x28
        private UnityEngine.InputSystem.UI.InputSystemUIInputModule m_UIInputModule;        // 0x30
        private UnityEngine.InputSystem.PlayerInput.DeviceLostEvent m_DeviceLostEvent;        // 0x38
        private UnityEngine.InputSystem.PlayerInput.DeviceRegainedEvent m_DeviceRegainedEvent;        // 0x40
        private UnityEngine.InputSystem.PlayerInput.ControlsChangedEvent m_ControlsChangedEvent;        // 0x48
        private UnityEngine.InputSystem.PlayerInput.ActionEvent[] m_ActionEvents;        // 0x50
        private System.Boolean m_NeverAutoSwitchControlSchemes;        // 0x58
        private System.String m_DefaultControlScheme;        // 0x60
        private System.String m_DefaultActionMap;        // 0x68
        private System.Int32 m_SplitScreenIndex;        // 0x70
        private UnityEngine.Camera m_Camera;        // 0x78
        private UnityEngine.InputSystem.InputValue m_InputValueObject;        // 0x80
        private UnityEngine.InputSystem.InputActionMap m_CurrentActionMap;        // 0x88
        private System.Int32 m_PlayerIndex;        // 0x90
        private System.Boolean m_InputActive;        // 0x94
        private System.Boolean m_Enabled;        // 0x95
        private System.Boolean m_ActionsInitialized;        // 0x96
        private System.Collections.Generic.Dictionary<System.String,System.String> m_ActionMessageNames;        // 0x98
        private UnityEngine.InputSystem.Users.InputUser m_InputUser;        // 0xA0
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_ActionTriggeredDelegate;        // 0xA8
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_DeviceLostCallbacks;        // 0xB0
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_DeviceRegainedCallbacks;        // 0x100
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_ControlsChangedCallbacks;        // 0x150
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>> m_ActionTriggeredCallbacks;        // 0x1A0
        private System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> m_UnpairedDeviceUsedDelegate;        // 0x1F0
        private System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> m_PreFilterUnpairedDeviceUsedDelegate;        // 0x1F8
        private System.Boolean m_OnUnpairedDeviceUsedHooked;        // 0x200
        private System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> m_DeviceChangeDelegate;        // 0x208
        private System.Boolean m_OnDeviceChangeHooked;        // 0x210
        private static System.Int32 s_AllActivePlayersCount;        // 0x0
        private static UnityEngine.InputSystem.PlayerInput[] s_AllActivePlayers;        // 0x8
        private static System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice> s_UserChangeDelegate;        // 0x10
        private static System.Int32 s_InitPairWithDevicesCount;        // 0x18
        private static UnityEngine.InputSystem.InputDevice[] s_InitPairWithDevices;        // 0x20
        private static System.Int32 s_InitPlayerIndex;        // 0x28
        private static System.Int32 s_InitSplitScreenIndex;        // 0x2C
        private static System.String s_InitControlScheme;        // 0x30
        private static System.Boolean s_DestroyIfDeviceSetupUnsuccessful;        // 0x38

        // Methods
        private System.Boolean get_inputIsActive() { }
        private System.Boolean get_active() { }
        private System.Int32 get_playerIndex() { }
        private System.Int32 get_splitScreenIndex() { }
        private UnityEngine.InputSystem.InputActionAsset get_actions() { }
        private System.Void set_actions(UnityEngine.InputSystem.InputActionAsset value) { }
        private System.String get_currentControlScheme() { }
        private System.String get_defaultControlScheme() { }
        private System.Void set_defaultControlScheme(System.String value) { }
        private System.Boolean get_neverAutoSwitchControlSchemes() { }
        private System.Void set_neverAutoSwitchControlSchemes(System.Boolean value) { }
        private UnityEngine.InputSystem.InputActionMap get_currentActionMap() { }
        private System.Void set_currentActionMap(UnityEngine.InputSystem.InputActionMap value) { }
        private System.String get_defaultActionMap() { }
        private System.Void set_defaultActionMap(System.String value) { }
        private UnityEngine.InputSystem.PlayerNotifications get_notificationBehavior() { }
        private System.Void set_notificationBehavior(UnityEngine.InputSystem.PlayerNotifications value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> get_actionEvents() { }
        private System.Void set_actionEvents(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput.ActionEvent> value) { }
        private UnityEngine.InputSystem.PlayerInput.DeviceLostEvent get_deviceLostEvent() { }
        private UnityEngine.InputSystem.PlayerInput.DeviceRegainedEvent get_deviceRegainedEvent() { }
        private UnityEngine.InputSystem.PlayerInput.ControlsChangedEvent get_controlsChangedEvent() { }
        private System.Void add_onActionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }
        private System.Void remove_onActionTriggered(System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> value) { }
        private System.Void add_onDeviceLost(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }
        private System.Void remove_onDeviceLost(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }
        private System.Void add_onDeviceRegained(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }
        private System.Void remove_onDeviceRegained(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }
        private System.Void add_onControlsChanged(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }
        private System.Void remove_onControlsChanged(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }
        private UnityEngine.Camera get_camera() { }
        private System.Void set_camera(UnityEngine.Camera value) { }
        private UnityEngine.InputSystem.UI.InputSystemUIInputModule get_uiInputModule() { }
        private System.Void set_uiInputModule(UnityEngine.InputSystem.UI.InputSystemUIInputModule value) { }
        private UnityEngine.InputSystem.Users.InputUser get_user() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_devices() { }
        private System.Boolean get_hasMissingRequiredDevices() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.PlayerInput> get_all() { }
        private System.Boolean get_isSinglePlayer() { }
        private TDevice GetDevice() { }
        private System.Void ActivateInput() { }
        private System.Void UpdateDelegates() { }
        private System.Void DeactivateInput() { }
        private System.Void PassivateInput() { }
        private System.Boolean SwitchCurrentControlScheme(UnityEngine.InputSystem.InputDevice[] devices) { }
        private System.Void SwitchCurrentControlScheme(System.String controlScheme, UnityEngine.InputSystem.InputDevice[] devices) { }
        private System.Void SwitchCurrentActionMap(System.String mapNameOrId) { }
        private UnityEngine.InputSystem.PlayerInput GetPlayerByIndex(System.Int32 playerIndex) { }
        private UnityEngine.InputSystem.PlayerInput FindFirstPairedToDevice(UnityEngine.InputSystem.InputDevice device) { }
        private UnityEngine.InputSystem.PlayerInput Instantiate(UnityEngine.GameObject prefab, System.Int32 playerIndex, System.String controlScheme, System.Int32 splitScreenIndex, UnityEngine.InputSystem.InputDevice pairWithDevice) { }
        private UnityEngine.InputSystem.PlayerInput Instantiate(UnityEngine.GameObject prefab, System.Int32 playerIndex, System.String controlScheme, System.Int32 splitScreenIndex, UnityEngine.InputSystem.InputDevice[] pairWithDevices) { }
        private UnityEngine.InputSystem.PlayerInput DoInstantiate(UnityEngine.GameObject prefab) { }
        private System.Void InitializeActions() { }
        private System.Void CopyActionAssetAndApplyBindingOverrides() { }
        private System.Void UninitializeActions() { }
        private System.Void InstallOnActionTriggeredHook() { }
        private System.Void UninstallOnActionTriggeredHook() { }
        private System.Void OnActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void CacheMessageNames() { }
        private System.Void ClearCaches() { }
        private System.Void AssignUserAndDevices() { }
        private System.Boolean HaveBindingForDevice(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void UnassignUserAndDevices() { }
        private System.Boolean TryToActivateControlScheme(UnityEngine.InputSystem.InputControlScheme controlScheme) { }
        private System.Void AssignPlayerIndex() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void StartListeningForUnpairedDeviceActivity() { }
        private System.Void StopListeningForUnpairedDeviceActivity() { }
        private System.Void StartListeningForDeviceChanges() { }
        private System.Void StopListeningForDeviceChanges() { }
        private System.Void OnDisable() { }
        private System.Void DebugLogAction(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void HandleDeviceLost() { }
        private System.Void HandleDeviceRegained() { }
        private System.Void HandleControlsChanged() { }
        private System.Void OnUserChange(UnityEngine.InputSystem.Users.InputUser user, UnityEngine.InputSystem.Users.InputUserChange change, UnityEngine.InputSystem.InputDevice device) { }
        private System.Boolean OnPreFilterUnpairedDeviceUsed(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void OnUnpairedDeviceUsed(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change) { }
        private System.Void SwitchControlSchemeInternal(UnityEngine.InputSystem.InputControlScheme& controlScheme, UnityEngine.InputSystem.InputDevice[] devices) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000D9
    public class PlayerInputManager : MonoBehaviour
    {
        // Fields
        public static System.String PlayerJoinedMessage;        // 0x0
        public static System.String PlayerLeftMessage;        // 0x0
        private static UnityEngine.InputSystem.PlayerInputManager <instance>k__BackingField;        // 0x0
        private UnityEngine.InputSystem.PlayerNotifications m_NotificationBehavior;        // 0x18
        private System.Int32 m_MaxPlayerCount;        // 0x1C
        private System.Boolean m_AllowJoining;        // 0x20
        private UnityEngine.InputSystem.PlayerJoinBehavior m_JoinBehavior;        // 0x24
        private UnityEngine.InputSystem.PlayerInputManager.PlayerJoinedEvent m_PlayerJoinedEvent;        // 0x28
        private UnityEngine.InputSystem.PlayerInputManager.PlayerLeftEvent m_PlayerLeftEvent;        // 0x30
        private UnityEngine.InputSystem.InputActionProperty m_JoinAction;        // 0x38
        private UnityEngine.GameObject m_PlayerPrefab;        // 0x50
        private System.Boolean m_SplitScreen;        // 0x58
        private System.Boolean m_MaintainAspectRatioInSplitScreen;        // 0x59
        private System.Int32 m_FixedNumberOfSplitScreens;        // 0x5C
        private UnityEngine.Rect m_SplitScreenRect;        // 0x60
        private System.Boolean m_JoinActionDelegateHooked;        // 0x70
        private System.Boolean m_UnpairedDeviceUsedDelegateHooked;        // 0x71
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_JoinActionDelegate;        // 0x78
        private System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> m_UnpairedDeviceUsedDelegate;        // 0x80
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_PlayerJoinedCallbacks;        // 0x88
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.PlayerInput>> m_PlayerLeftCallbacks;        // 0xD8

        // Methods
        private System.Boolean get_splitScreen() { }
        private System.Void set_splitScreen(System.Boolean value) { }
        private System.Boolean get_maintainAspectRatioInSplitScreen() { }
        private System.Int32 get_fixedNumberOfSplitScreens() { }
        private UnityEngine.Rect get_splitScreenArea() { }
        private System.Int32 get_playerCount() { }
        private System.Int32 get_maxPlayerCount() { }
        private System.Boolean get_joiningEnabled() { }
        private UnityEngine.InputSystem.PlayerJoinBehavior get_joinBehavior() { }
        private System.Void set_joinBehavior(UnityEngine.InputSystem.PlayerJoinBehavior value) { }
        private UnityEngine.InputSystem.InputActionProperty get_joinAction() { }
        private System.Void set_joinAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.PlayerNotifications get_notificationBehavior() { }
        private System.Void set_notificationBehavior(UnityEngine.InputSystem.PlayerNotifications value) { }
        private UnityEngine.InputSystem.PlayerInputManager.PlayerJoinedEvent get_playerJoinedEvent() { }
        private UnityEngine.InputSystem.PlayerInputManager.PlayerLeftEvent get_playerLeftEvent() { }
        private System.Void add_onPlayerJoined(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }
        private System.Void remove_onPlayerJoined(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }
        private System.Void add_onPlayerLeft(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }
        private System.Void remove_onPlayerLeft(System.Action<UnityEngine.InputSystem.PlayerInput> value) { }
        private UnityEngine.GameObject get_playerPrefab() { }
        private System.Void set_playerPrefab(UnityEngine.GameObject value) { }
        private UnityEngine.InputSystem.PlayerInputManager get_instance() { }
        private System.Void set_instance(UnityEngine.InputSystem.PlayerInputManager value) { }
        private System.Void EnableJoining() { }
        private System.Void DisableJoining() { }
        private System.Void JoinPlayerFromUI() { }
        private System.Void JoinPlayerFromAction(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void JoinPlayerFromActionIfNotAlreadyJoined(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private UnityEngine.InputSystem.PlayerInput JoinPlayer(System.Int32 playerIndex, System.Int32 splitScreenIndex, System.String controlScheme, UnityEngine.InputSystem.InputDevice pairWithDevice) { }
        private UnityEngine.InputSystem.PlayerInput JoinPlayer(System.Int32 playerIndex, System.Int32 splitScreenIndex, System.String controlScheme, UnityEngine.InputSystem.InputDevice[] pairWithDevices) { }
        private System.String[] get_messages() { }
        private System.Boolean CheckIfPlayerCanJoin(System.Int32 playerIndex) { }
        private System.Void OnUnpairedDeviceUsed(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void UpdateSplitScreen() { }
        private System.Boolean IsDeviceUsableWithPlayerActions(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void ValidateInputActionAsset() { }
        private System.Void NotifyPlayerJoined(UnityEngine.InputSystem.PlayerInput player) { }
        private System.Void NotifyPlayerLeft(UnityEngine.InputSystem.PlayerInput player) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DC
    public struct PlayerJoinBehavior
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.PlayerJoinBehavior JoinPlayersWhenButtonIsPressed;        // 0x0
        public static UnityEngine.InputSystem.PlayerJoinBehavior JoinPlayersWhenJoinActionIsTriggered;        // 0x0
        public static UnityEngine.InputSystem.PlayerJoinBehavior JoinPlayersManually;        // 0x0

    }

    // TypeToken: 0x20000DD
    public struct PlayerNotifications
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.PlayerNotifications SendMessages;        // 0x0
        public static UnityEngine.InputSystem.PlayerNotifications BroadcastMessages;        // 0x0
        public static UnityEngine.InputSystem.PlayerNotifications InvokeUnityEvents;        // 0x0
        public static UnityEngine.InputSystem.PlayerNotifications InvokeCSharpEvents;        // 0x0

    }

    // TypeToken: 0x20000DE
    public struct DynamicBitfield
    {
        // Fields
        public UnityEngine.InputSystem.Utilities.InlinedArray<System.UInt64> array;        // 0x10
        public System.Int32 length;        // 0x28

        // Methods
        private System.Void SetLength(System.Int32 newLength) { }
        private System.Void SetBit(System.Int32 bitIndex) { }
        private System.Boolean TestBit(System.Int32 bitIndex) { }
        private System.Void ClearBit(System.Int32 bitIndex) { }
        private System.Boolean AnyBitIsSet() { }
        private System.Int32 BitCountToULongCount(System.Int32 bitCount) { }

    }

}

namespace UnityEngine.InputSystem.Composites
{

    // TypeToken: 0x200026E
    public class AxisComposite : InputBindingComposite`1
    {
        // Fields
        public System.Int32 negative;        // 0x10
        public System.Int32 positive;        // 0x14
        public System.Single minValue;        // 0x18
        public System.Single maxValue;        // 0x1C
        public UnityEngine.InputSystem.Composites.AxisComposite.WhichSideWins whichSideWins;        // 0x20

        // Methods
        private System.Single get_midPoint() { }
        private System.Single ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Single EvaluateMagnitude(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000270
    public class ButtonWithOneModifier : InputBindingComposite`1
    {
        // Fields
        public System.Int32 modifier;        // 0x10
        public System.Int32 button;        // 0x14
        public System.Boolean overrideModifiersNeedToBePressedFirst;        // 0x18
        public UnityEngine.InputSystem.Composites.ButtonWithOneModifier.ModifiersOrder modifiersOrder;        // 0x1C

        // Methods
        private System.Single ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Boolean ModifierIsPressed(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Single EvaluateMagnitude(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void FinishSetup(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000272
    public class ButtonWithTwoModifiers : InputBindingComposite`1
    {
        // Fields
        public System.Int32 modifier1;        // 0x10
        public System.Int32 modifier2;        // 0x14
        public System.Int32 button;        // 0x18
        public System.Boolean overrideModifiersNeedToBePressedFirst;        // 0x1C
        public UnityEngine.InputSystem.Composites.ButtonWithTwoModifiers.ModifiersOrder modifiersOrder;        // 0x20

        // Methods
        private System.Single ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Boolean ModifiersArePressed(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Single EvaluateMagnitude(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void FinishSetup(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000274
    public class OneModifierComposite : InputBindingComposite
    {
        // Fields
        public System.Int32 modifier;        // 0x10
        public System.Int32 binding;        // 0x14
        public System.Boolean overrideModifiersNeedToBePressedFirst;        // 0x18
        public UnityEngine.InputSystem.Composites.OneModifierComposite.ModifiersOrder modifiersOrder;        // 0x1C
        private System.Int32 m_ValueSizeInBytes;        // 0x20
        private System.Type m_ValueType;        // 0x28
        private System.Boolean m_BindingIsButton;        // 0x30

        // Methods
        private System.Type get_valueType() { }
        private System.Int32 get_valueSizeInBytes() { }
        private System.Single EvaluateMagnitude(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context, System.Void* buffer, System.Int32 bufferSize) { }
        private System.Boolean ModifierIsPressed(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void FinishSetup(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Object ReadValueAsObject(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void DetermineValueTypeAndSize(UnityEngine.InputSystem.InputBindingCompositeContext& context, System.Int32 part, System.Type& valueType, System.Int32& valueSizeInBytes, System.Boolean& isButton) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000276
    public class TwoModifiersComposite : InputBindingComposite
    {
        // Fields
        public System.Int32 modifier1;        // 0x10
        public System.Int32 modifier2;        // 0x14
        public System.Int32 binding;        // 0x18
        public System.Boolean overrideModifiersNeedToBePressedFirst;        // 0x1C
        public UnityEngine.InputSystem.Composites.TwoModifiersComposite.ModifiersOrder modifiersOrder;        // 0x20
        private System.Int32 m_ValueSizeInBytes;        // 0x24
        private System.Type m_ValueType;        // 0x28
        private System.Boolean m_BindingIsButton;        // 0x30

        // Methods
        private System.Type get_valueType() { }
        private System.Int32 get_valueSizeInBytes() { }
        private System.Single EvaluateMagnitude(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context, System.Void* buffer, System.Int32 bufferSize) { }
        private System.Boolean ModifiersArePressed(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void FinishSetup(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Object ReadValueAsObject(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000278
    public class Vector2Composite : InputBindingComposite`1
    {
        // Fields
        public System.Int32 up;        // 0x10
        public System.Int32 down;        // 0x14
        public System.Int32 left;        // 0x18
        public System.Int32 right;        // 0x1C
        public System.Boolean normalize;        // 0x20
        public UnityEngine.InputSystem.Composites.Vector2Composite.Mode mode;        // 0x24

        // Methods
        private UnityEngine.Vector2 ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Single EvaluateMagnitude(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200027A
    public class Vector3Composite : InputBindingComposite`1
    {
        // Fields
        public System.Int32 up;        // 0x10
        public System.Int32 down;        // 0x14
        public System.Int32 left;        // 0x18
        public System.Int32 right;        // 0x1C
        public System.Int32 forward;        // 0x20
        public System.Int32 backward;        // 0x24
        public UnityEngine.InputSystem.Composites.Vector3Composite.Mode mode;        // 0x28

        // Methods
        private UnityEngine.Vector3 ReadValue(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Single EvaluateMagnitude(UnityEngine.InputSystem.InputBindingCompositeContext& context) { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.InputSystem.Controls
{

    // TypeToken: 0x2000216
    public class AnyKeyControl : ButtonControl
    {
        // Methods
        private System.Void .ctor() { }
        private System.Single ReadUnprocessedValueFromState(System.Void* statePtr) { }

    }

    // TypeToken: 0x2000217
    public class AxisControl : InputControl`1
    {
        // Fields
        public UnityEngine.InputSystem.Controls.AxisControl.Clamp clamp;        // 0x108
        public System.Single clampMin;        // 0x10C
        public System.Single clampMax;        // 0x110
        public System.Single clampConstant;        // 0x114
        public System.Boolean invert;        // 0x118
        public System.Boolean normalize;        // 0x119
        public System.Single normalizeMin;        // 0x11C
        public System.Single normalizeMax;        // 0x120
        public System.Single normalizeZero;        // 0x124
        public System.Boolean scale;        // 0x128
        public System.Single scaleFactor;        // 0x12C

        // Methods
        private System.Single Preprocess(System.Single value) { }
        private System.Single Unpreprocess(System.Single value) { }
        private System.Void .ctor() { }
        private System.Void FinishSetup() { }
        private System.Single ReadUnprocessedValueFromState(System.Void* statePtr) { }
        private System.Void WriteValueIntoState(System.Single value, System.Void* statePtr) { }
        private System.Boolean CompareValue(System.Void* firstStatePtr, System.Void* secondStatePtr) { }
        private System.Single EvaluateMagnitude(System.Void* statePtr) { }
        private System.Single EvaluateMagnitude(System.Single value) { }
        private UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType() { }

    }

    // TypeToken: 0x2000219
    public class ButtonControl : AxisControl
    {
        // Fields
        private System.Boolean m_NeedsToCheckFramePress;        // 0x130
        private System.UInt32 m_UpdateCountLastPressed;        // 0x134
        private System.UInt32 m_UpdateCountLastReleased;        // 0x138
        private System.Boolean m_LastUpdateWasPress;        // 0x13C
        private System.Boolean <needsToCheckFramePress>k__BackingField;        // 0x13D
        public System.Single pressPoint;        // 0x140
        private static System.Single s_GlobalDefaultButtonPressPoint;        // 0x0
        private static System.Single s_GlobalDefaultButtonReleaseThreshold;        // 0x4
        private static System.Single kMinButtonPressPoint;        // 0x0

        // Methods
        private System.Boolean get_needsToCheckFramePress() { }
        private System.Void set_needsToCheckFramePress(System.Boolean value) { }
        private System.Single get_pressPointOrDefault() { }
        private System.Void .ctor() { }
        private System.Boolean IsValueConsideredPressed(System.Single value) { }
        private System.Boolean get_isPressed() { }
        private System.Void BeginTestingForFramePresses(System.Boolean currentlyPressed, System.Boolean pressedLastFrame) { }
        private System.Boolean get_wasPressedThisFrame() { }
        private System.Boolean get_wasReleasedThisFrame() { }
        private System.Void UpdateWasPressed() { }

    }

    // TypeToken: 0x200021A
    public class DeltaControl : Vector2Control
    {
        // Fields
        private UnityEngine.InputSystem.Controls.AxisControl <up>k__BackingField;        // 0x120
        private UnityEngine.InputSystem.Controls.AxisControl <down>k__BackingField;        // 0x128
        private UnityEngine.InputSystem.Controls.AxisControl <left>k__BackingField;        // 0x130
        private UnityEngine.InputSystem.Controls.AxisControl <right>k__BackingField;        // 0x138

        // Methods
        private UnityEngine.InputSystem.Controls.AxisControl get_up() { }
        private System.Void set_up(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_down() { }
        private System.Void set_down(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_left() { }
        private System.Void set_left(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_right() { }
        private System.Void set_right(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021B
    public class DiscreteButtonControl : ButtonControl
    {
        // Fields
        public System.Int32 minValue;        // 0x148
        public System.Int32 maxValue;        // 0x14C
        public System.Int32 wrapAtValue;        // 0x150
        public System.Int32 nullValue;        // 0x154
        public UnityEngine.InputSystem.Controls.DiscreteButtonControl.WriteMode writeMode;        // 0x158

        // Methods
        private System.Void FinishSetup() { }
        private System.Single ReadUnprocessedValueFromState(System.Void* statePtr) { }
        private System.Void WriteValueIntoState(System.Single value, System.Void* statePtr) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021D
    public class DoubleControl : InputControl`1
    {
        // Methods
        private System.Void .ctor() { }
        private System.Double ReadUnprocessedValueFromState(System.Void* statePtr) { }
        private System.Void WriteValueIntoState(System.Double value, System.Void* statePtr) { }

    }

    // TypeToken: 0x200021E
    public class DpadControl : Vector2Control
    {
        // Fields
        private UnityEngine.InputSystem.Controls.ButtonControl <up>k__BackingField;        // 0x120
        private UnityEngine.InputSystem.Controls.ButtonControl <down>k__BackingField;        // 0x128
        private UnityEngine.InputSystem.Controls.ButtonControl <left>k__BackingField;        // 0x130
        private UnityEngine.InputSystem.Controls.ButtonControl <right>k__BackingField;        // 0x138

        // Methods
        private UnityEngine.InputSystem.Controls.ButtonControl get_up() { }
        private System.Void set_up(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_down() { }
        private System.Void set_down(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_left() { }
        private System.Void set_left(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_right() { }
        private System.Void set_right(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private System.Void .ctor() { }
        private System.Void FinishSetup() { }
        private UnityEngine.Vector2 ReadUnprocessedValueFromState(System.Void* statePtr) { }
        private System.Void WriteValueIntoState(UnityEngine.Vector2 value, System.Void* statePtr) { }
        private UnityEngine.Vector2 MakeDpadVector(System.Boolean up, System.Boolean down, System.Boolean left, System.Boolean right, System.Boolean normalize) { }
        private UnityEngine.Vector2 MakeDpadVector(System.Single up, System.Single down, System.Single left, System.Single right) { }

    }

    // TypeToken: 0x2000221
    public class IntegerControl : InputControl`1
    {
        // Methods
        private System.Void .ctor() { }
        private System.Int32 ReadUnprocessedValueFromState(System.Void* statePtr) { }
        private System.Void WriteValueIntoState(System.Int32 value, System.Void* statePtr) { }
        private UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType() { }

    }

    // TypeToken: 0x2000222
    public class KeyControl : ButtonControl
    {
        // Fields
        private UnityEngine.InputSystem.Key <keyCode>k__BackingField;        // 0x148
        private System.Int32 m_ScanCode;        // 0x14C

        // Methods
        private UnityEngine.InputSystem.Key get_keyCode() { }
        private System.Void set_keyCode(UnityEngine.InputSystem.Key value) { }
        private System.Int32 get_scanCode() { }
        private System.Void RefreshConfiguration() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000223
    public class QuaternionControl : InputControl`1
    {
        // Fields
        private UnityEngine.InputSystem.Controls.AxisControl <x>k__BackingField;        // 0x120
        private UnityEngine.InputSystem.Controls.AxisControl <y>k__BackingField;        // 0x128
        private UnityEngine.InputSystem.Controls.AxisControl <z>k__BackingField;        // 0x130
        private UnityEngine.InputSystem.Controls.AxisControl <w>k__BackingField;        // 0x138

        // Methods
        private UnityEngine.InputSystem.Controls.AxisControl get_x() { }
        private System.Void set_x(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_y() { }
        private System.Void set_y(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_z() { }
        private System.Void set_z(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_w() { }
        private System.Void set_w(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private System.Void .ctor() { }
        private System.Void FinishSetup() { }
        private UnityEngine.Quaternion ReadUnprocessedValueFromState(System.Void* statePtr) { }
        private System.Void WriteValueIntoState(UnityEngine.Quaternion value, System.Void* statePtr) { }
        private UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType() { }

    }

    // TypeToken: 0x2000224
    public class StickControl : Vector2Control
    {
        // Fields
        private UnityEngine.InputSystem.Controls.ButtonControl <up>k__BackingField;        // 0x120
        private UnityEngine.InputSystem.Controls.ButtonControl <down>k__BackingField;        // 0x128
        private UnityEngine.InputSystem.Controls.ButtonControl <left>k__BackingField;        // 0x130
        private UnityEngine.InputSystem.Controls.ButtonControl <right>k__BackingField;        // 0x138

        // Methods
        private UnityEngine.InputSystem.Controls.ButtonControl get_up() { }
        private System.Void set_up(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_down() { }
        private System.Void set_down(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_left() { }
        private System.Void set_left(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_right() { }
        private System.Void set_right(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000225
    public class TouchControl : InputControl`1
    {
        // Fields
        private UnityEngine.InputSystem.Controls.TouchPressControl <press>k__BackingField;        // 0x170
        private UnityEngine.InputSystem.Controls.IntegerControl <displayIndex>k__BackingField;        // 0x178
        private UnityEngine.InputSystem.Controls.IntegerControl <touchId>k__BackingField;        // 0x180
        private UnityEngine.InputSystem.Controls.Vector2Control <position>k__BackingField;        // 0x188
        private UnityEngine.InputSystem.Controls.DeltaControl <delta>k__BackingField;        // 0x190
        private UnityEngine.InputSystem.Controls.AxisControl <pressure>k__BackingField;        // 0x198
        private UnityEngine.InputSystem.Controls.Vector2Control <radius>k__BackingField;        // 0x1A0
        private UnityEngine.InputSystem.Controls.TouchPhaseControl <phase>k__BackingField;        // 0x1A8
        private UnityEngine.InputSystem.Controls.ButtonControl <indirectTouch>k__BackingField;        // 0x1B0
        private UnityEngine.InputSystem.Controls.ButtonControl <tap>k__BackingField;        // 0x1B8
        private UnityEngine.InputSystem.Controls.IntegerControl <tapCount>k__BackingField;        // 0x1C0
        private UnityEngine.InputSystem.Controls.DoubleControl <startTime>k__BackingField;        // 0x1C8
        private UnityEngine.InputSystem.Controls.Vector2Control <startPosition>k__BackingField;        // 0x1D0

        // Methods
        private UnityEngine.InputSystem.Controls.TouchPressControl get_press() { }
        private System.Void set_press(UnityEngine.InputSystem.Controls.TouchPressControl value) { }
        private UnityEngine.InputSystem.Controls.IntegerControl get_displayIndex() { }
        private System.Void set_displayIndex(UnityEngine.InputSystem.Controls.IntegerControl value) { }
        private UnityEngine.InputSystem.Controls.IntegerControl get_touchId() { }
        private System.Void set_touchId(UnityEngine.InputSystem.Controls.IntegerControl value) { }
        private UnityEngine.InputSystem.Controls.Vector2Control get_position() { }
        private System.Void set_position(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private UnityEngine.InputSystem.Controls.DeltaControl get_delta() { }
        private System.Void set_delta(UnityEngine.InputSystem.Controls.DeltaControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_pressure() { }
        private System.Void set_pressure(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.Vector2Control get_radius() { }
        private System.Void set_radius(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private UnityEngine.InputSystem.Controls.TouchPhaseControl get_phase() { }
        private System.Void set_phase(UnityEngine.InputSystem.Controls.TouchPhaseControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_indirectTouch() { }
        private System.Void set_indirectTouch(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_tap() { }
        private System.Void set_tap(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.IntegerControl get_tapCount() { }
        private System.Void set_tapCount(UnityEngine.InputSystem.Controls.IntegerControl value) { }
        private UnityEngine.InputSystem.Controls.DoubleControl get_startTime() { }
        private System.Void set_startTime(UnityEngine.InputSystem.Controls.DoubleControl value) { }
        private UnityEngine.InputSystem.Controls.Vector2Control get_startPosition() { }
        private System.Void set_startPosition(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private System.Boolean get_isInProgress() { }
        private System.Void .ctor() { }
        private System.Void FinishSetup() { }
        private UnityEngine.InputSystem.LowLevel.TouchState ReadUnprocessedValueFromState(System.Void* statePtr) { }
        private System.Void WriteValueIntoState(UnityEngine.InputSystem.LowLevel.TouchState value, System.Void* statePtr) { }

    }

    // TypeToken: 0x2000226
    public class TouchPhaseControl : InputControl`1
    {
        // Methods
        private System.Void .ctor() { }
        private UnityEngine.InputSystem.TouchPhase ReadUnprocessedValueFromState(System.Void* statePtr) { }
        private System.Void WriteValueIntoState(UnityEngine.InputSystem.TouchPhase value, System.Void* statePtr) { }

    }

    // TypeToken: 0x2000227
    public class TouchPressControl : ButtonControl
    {
        // Methods
        private System.Void FinishSetup() { }
        private System.Single ReadUnprocessedValueFromState(System.Void* statePtr) { }
        private System.Void WriteValueIntoState(System.Single value, System.Void* statePtr) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000228
    public class Vector2Control : InputControl`1
    {
        // Fields
        private UnityEngine.InputSystem.Controls.AxisControl <x>k__BackingField;        // 0x110
        private UnityEngine.InputSystem.Controls.AxisControl <y>k__BackingField;        // 0x118

        // Methods
        private UnityEngine.InputSystem.Controls.AxisControl get_x() { }
        private System.Void set_x(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_y() { }
        private System.Void set_y(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private System.Void .ctor() { }
        private System.Void FinishSetup() { }
        private UnityEngine.Vector2 ReadUnprocessedValueFromState(System.Void* statePtr) { }
        private System.Void WriteValueIntoState(UnityEngine.Vector2 value, System.Void* statePtr) { }
        private System.Single EvaluateMagnitude(System.Void* statePtr) { }
        private UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType() { }

    }

    // TypeToken: 0x2000229
    public class Vector3Control : InputControl`1
    {
        // Fields
        private UnityEngine.InputSystem.Controls.AxisControl <x>k__BackingField;        // 0x118
        private UnityEngine.InputSystem.Controls.AxisControl <y>k__BackingField;        // 0x120
        private UnityEngine.InputSystem.Controls.AxisControl <z>k__BackingField;        // 0x128

        // Methods
        private UnityEngine.InputSystem.Controls.AxisControl get_x() { }
        private System.Void set_x(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_y() { }
        private System.Void set_y(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_z() { }
        private System.Void set_z(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private System.Void .ctor() { }
        private System.Void FinishSetup() { }
        private UnityEngine.Vector3 ReadUnprocessedValueFromState(System.Void* statePtr) { }
        private System.Void WriteValueIntoState(UnityEngine.Vector3 value, System.Void* statePtr) { }
        private System.Single EvaluateMagnitude(System.Void* statePtr) { }
        private UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType() { }

    }

}

namespace UnityEngine.InputSystem.DualShock
{

    // TypeToken: 0x2000159
    public class DualShockGamepad : Gamepad, IDualShockHaptics, IDualMotorRumble, IHaptics
    {
        // Fields
        private UnityEngine.InputSystem.Controls.ButtonControl <touchpadButton>k__BackingField;        // 0x210
        private UnityEngine.InputSystem.Controls.ButtonControl <optionsButton>k__BackingField;        // 0x218
        private UnityEngine.InputSystem.Controls.ButtonControl <shareButton>k__BackingField;        // 0x220
        private UnityEngine.InputSystem.Controls.ButtonControl <L1>k__BackingField;        // 0x228
        private UnityEngine.InputSystem.Controls.ButtonControl <R1>k__BackingField;        // 0x230
        private UnityEngine.InputSystem.Controls.ButtonControl <L2>k__BackingField;        // 0x238
        private UnityEngine.InputSystem.Controls.ButtonControl <R2>k__BackingField;        // 0x240
        private UnityEngine.InputSystem.Controls.ButtonControl <L3>k__BackingField;        // 0x248
        private UnityEngine.InputSystem.Controls.ButtonControl <R3>k__BackingField;        // 0x250
        private static UnityEngine.InputSystem.DualShock.DualShockGamepad <current>k__BackingField;        // 0x0
        private UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor <hidDescriptor>k__BackingField;        // 0x258

        // Methods
        private UnityEngine.InputSystem.Controls.ButtonControl get_touchpadButton() { }
        private System.Void set_touchpadButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_optionsButton() { }
        private System.Void set_optionsButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_shareButton() { }
        private System.Void set_shareButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_L1() { }
        private System.Void set_L1(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_R1() { }
        private System.Void set_R1(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_L2() { }
        private System.Void set_L2(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_R2() { }
        private System.Void set_R2(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_L3() { }
        private System.Void set_L3(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_R3() { }
        private System.Void set_R3(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.DualShock.DualShockGamepad get_current() { }
        private System.Void set_current(UnityEngine.InputSystem.DualShock.DualShockGamepad value) { }
        private UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor get_hidDescriptor() { }
        private System.Void set_hidDescriptor(UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor value) { }
        private System.Void MakeCurrent() { }
        private System.Void OnRemoved() { }
        private System.Void FinishSetup() { }
        private System.Void SetLightBarColor(UnityEngine.Color color) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200015A
    public class DualSenseGamepadHID : DualShockGamepad, IEventMerger, IEventPreProcessor, IInputStateCallbackReceiver
    {
        // Fields
        private UnityEngine.InputSystem.Controls.ButtonControl <leftTriggerButton>k__BackingField;        // 0x288
        private UnityEngine.InputSystem.Controls.ButtonControl <rightTriggerButton>k__BackingField;        // 0x290
        private UnityEngine.InputSystem.Controls.ButtonControl <playStationButton>k__BackingField;        // 0x298
        private System.Nullable<System.Single> m_LowFrequencyMotorSpeed;        // 0x2A0
        private System.Nullable<System.Single> m_HighFrequenceyMotorSpeed;        // 0x2A8
        protected System.Nullable<UnityEngine.Color> m_LightBarColor;        // 0x2B0
        private System.Byte outputSequenceId;        // 0x2C4
        private static System.Byte JitterMaskLow;        // 0x0
        private static System.Byte JitterMaskHigh;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.ButtonControl get_leftTriggerButton() { }
        private System.Void set_leftTriggerButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_rightTriggerButton() { }
        private System.Void set_rightTriggerButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_playStationButton() { }
        private System.Void set_playStationButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private System.Void FinishSetup() { }
        private System.Void PauseHaptics() { }
        private System.Void ResetHaptics() { }
        private System.Void ResumeHaptics() { }
        private System.Void SetLightBarColor(UnityEngine.Color color) { }
        private System.Void SetMotorSpeeds(System.Single lowFrequency, System.Single highFrequency) { }
        private System.Boolean SetMotorSpeedsAndLightBarColor(System.Nullable<System.Single> lowFrequency, System.Nullable<System.Single> highFrequency, System.Nullable<UnityEngine.Color> color) { }
        private System.Boolean MergeForward(UnityEngine.InputSystem.DualShock.DualSenseGamepadHID.DualSenseHIDUSBInputReport* currentState, UnityEngine.InputSystem.DualShock.DualSenseGamepadHID.DualSenseHIDUSBInputReport* nextState) { }
        private System.Boolean MergeForward(UnityEngine.InputSystem.DualShock.DualSenseGamepadHID.DualSenseHIDBluetoothInputReport* currentState, UnityEngine.InputSystem.DualShock.DualSenseGamepadHID.DualSenseHIDBluetoothInputReport* nextState) { }
        private System.Boolean MergeForward(UnityEngine.InputSystem.DualShock.DualSenseGamepadHID.DualSenseHIDMinimalInputReport* currentState, UnityEngine.InputSystem.DualShock.DualSenseGamepadHID.DualSenseHIDMinimalInputReport* nextState) { }
        private System.Boolean UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr) { }
        private System.Boolean UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void OnNextUpdate() { }
        private System.Void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Boolean GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.UInt32& offset) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200015F
    public class DualShock4GamepadHID : DualShockGamepad, IEventPreProcessor, IInputStateCallbackReceiver
    {
        // Fields
        private UnityEngine.InputSystem.Controls.ButtonControl <leftTriggerButton>k__BackingField;        // 0x288
        private UnityEngine.InputSystem.Controls.ButtonControl <rightTriggerButton>k__BackingField;        // 0x290
        private UnityEngine.InputSystem.Controls.ButtonControl <playStationButton>k__BackingField;        // 0x298
        private System.Nullable<System.Single> m_LowFrequencyMotorSpeed;        // 0x2A0
        private System.Nullable<System.Single> m_HighFrequenceyMotorSpeed;        // 0x2A8
        private System.Nullable<UnityEngine.Color> m_LightBarColor;        // 0x2B0
        private static System.Byte JitterMaskLow;        // 0x0
        private static System.Byte JitterMaskHigh;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.ButtonControl get_leftTriggerButton() { }
        private System.Void set_leftTriggerButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_rightTriggerButton() { }
        private System.Void set_rightTriggerButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_playStationButton() { }
        private System.Void set_playStationButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private System.Void FinishSetup() { }
        private System.Void PauseHaptics() { }
        private System.Void ResetHaptics() { }
        private System.Void ResumeHaptics() { }
        private System.Void SetLightBarColor(UnityEngine.Color color) { }
        private System.Void SetMotorSpeeds(System.Single lowFrequency, System.Single highFrequency) { }
        private System.Boolean SetMotorSpeedsAndLightBarColor(System.Single lowFrequency, System.Single highFrequency, UnityEngine.Color color) { }
        private System.Boolean UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void OnNextUpdate() { }
        private System.Void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Boolean GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.UInt32& offset) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000161
    public class DualShock3GamepadHID : DualShockGamepad
    {
        // Fields
        private UnityEngine.InputSystem.Controls.ButtonControl <leftTriggerButton>k__BackingField;        // 0x288
        private UnityEngine.InputSystem.Controls.ButtonControl <rightTriggerButton>k__BackingField;        // 0x290
        private UnityEngine.InputSystem.Controls.ButtonControl <playStationButton>k__BackingField;        // 0x298

        // Methods
        private UnityEngine.InputSystem.Controls.ButtonControl get_leftTriggerButton() { }
        private System.Void set_leftTriggerButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_rightTriggerButton() { }
        private System.Void set_rightTriggerButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_playStationButton() { }
        private System.Void set_playStationButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000162
    public class DualShockSupport
    {
        // Methods
        private System.Void Initialize() { }

    }

    // TypeToken: 0x2000163
    public interface IDualShockHaptics : IDualMotorRumble, IHaptics
    {
        // Methods
        private System.Void SetLightBarColor(UnityEngine.Color color) { }

    }

}

namespace UnityEngine.InputSystem.DualShock.LowLevel
{

    // TypeToken: 0x2000164
    public struct DualSenseHIDInputReport, IInputStateTypeInfo
    {
        // Fields
        public static UnityEngine.InputSystem.Utilities.FourCC Format;        // 0x0
        public System.Byte leftStickX;        // 0x10
        public System.Byte leftStickY;        // 0x11
        public System.Byte rightStickX;        // 0x12
        public System.Byte rightStickY;        // 0x13
        public System.Byte leftTrigger;        // 0x14
        public System.Byte rightTrigger;        // 0x15
        public System.Byte buttons0;        // 0x16
        public System.Byte buttons1;        // 0x17
        public System.Byte buttons2;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000165
    public struct DualSenseHIDOutputReportPayload
    {
        // Fields
        public System.Byte enableFlags1;        // 0x10
        public System.Byte enableFlags2;        // 0x11
        public System.Byte highFrequencyMotorSpeed;        // 0x12
        public System.Byte lowFrequencyMotorSpeed;        // 0x13
        public System.Byte redColor;        // 0x3C
        public System.Byte greenColor;        // 0x3D
        public System.Byte blueColor;        // 0x3E

    }

    // TypeToken: 0x2000166
    public struct DualSenseHIDUSBOutputReport, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public System.Byte reportId;        // 0x18
        public UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDOutputReportPayload payload;        // 0x19

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDUSBOutputReport Create(UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDOutputReportPayload payload, System.Int32 outputReportSize) { }

    }

    // TypeToken: 0x2000167
    public struct DualSenseHIDBluetoothOutputReport, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public System.Byte reportId;        // 0x18
        public System.Byte tag1;        // 0x19
        public System.Byte tag2;        // 0x1A
        public UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDOutputReportPayload payload;        // 0x1B
        public System.UInt32 crc32;        // 0x62
        public UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDBluetoothOutputReport.<rawData>e__FixedBuffer rawData;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDBluetoothOutputReport Create(UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDOutputReportPayload payload, System.Byte outputSequenceId, System.Int32 outputReportSize) { }

    }

    // TypeToken: 0x2000169
    public struct DualShock4HIDInputReport, IInputStateTypeInfo
    {
        // Fields
        public static UnityEngine.InputSystem.Utilities.FourCC Format;        // 0x0
        public System.Byte leftStickX;        // 0x10
        public System.Byte leftStickY;        // 0x11
        public System.Byte rightStickX;        // 0x12
        public System.Byte rightStickY;        // 0x13
        public System.Byte buttons1;        // 0x14
        public System.Byte buttons2;        // 0x15
        public System.Byte buttons3;        // 0x16
        public System.Byte leftTrigger;        // 0x17
        public System.Byte rightTrigger;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200016A
    public struct DualShock3HIDInputReport, IInputStateTypeInfo
    {
        // Fields
        private System.UInt16 padding1;        // 0x10
        public System.Byte buttons1;        // 0x12
        public System.Byte buttons2;        // 0x13
        public System.Byte buttons3;        // 0x14
        private System.Byte padding2;        // 0x15
        public System.Byte leftStickX;        // 0x16
        public System.Byte leftStickY;        // 0x17
        public System.Byte rightStickX;        // 0x18
        public System.Byte rightStickY;        // 0x19
        private UnityEngine.InputSystem.DualShock.LowLevel.DualShock3HIDInputReport.<padding3>e__FixedBuffer padding3;        // 0x1A
        public System.Byte leftTrigger;        // 0x22
        public System.Byte rightTrigger;        // 0x23

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }

    }

    // TypeToken: 0x200016C
    public struct DualShockHIDOutputReport, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        private static System.Int32 kReportId;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public System.Byte reportId;        // 0x18
        public System.Byte flags;        // 0x19
        public UnityEngine.InputSystem.DualShock.LowLevel.DualShockHIDOutputReport.<unknown1>e__FixedBuffer unknown1;        // 0x1A
        public System.Byte highFrequencyMotorSpeed;        // 0x1C
        public System.Byte lowFrequencyMotorSpeed;        // 0x1D
        public System.Byte redColor;        // 0x1E
        public System.Byte greenColor;        // 0x1F
        public System.Byte blueColor;        // 0x20
        public UnityEngine.InputSystem.DualShock.LowLevel.DualShockHIDOutputReport.<unknown2>e__FixedBuffer unknown2;        // 0x21

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private System.Void SetMotorSpeeds(System.Single lowFreq, System.Single highFreq) { }
        private System.Void SetColor(UnityEngine.Color color) { }
        private UnityEngine.InputSystem.DualShock.LowLevel.DualShockHIDOutputReport Create(System.Int32 outputReportSize) { }

    }

}

namespace UnityEngine.InputSystem.Editor
{

    // TypeToken: 0x2000170
    public struct SampleFrequencyCalculator
    {
        // Fields
        private System.Double m_LastUpdateTime;        // 0x10
        private System.Int32 m_SampleCount;        // 0x18
        private System.Single <targetFrequency>k__BackingField;        // 0x1C
        private System.Single <frequency>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.Single targetFrequency, System.Double realtimeSinceStartup) { }
        private System.Single get_targetFrequency() { }
        private System.Void set_targetFrequency(System.Single value) { }
        private System.Single get_frequency() { }
        private System.Void set_frequency(System.Single value) { }
        private System.Void ProcessSample(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Boolean Update() { }
        private System.Boolean Update(System.Double realtimeSinceStartup) { }

    }

}

namespace UnityEngine.InputSystem.EnhancedTouch
{

    // TypeToken: 0x200014F
    public class EnhancedTouchSupport
    {
        // Fields
        private static System.Int32 s_Enabled;        // 0x0
        private static UnityEngine.InputSystem.InputSettings.UpdateMode s_UpdateMode;        // 0x4

        // Methods
        private System.Boolean get_enabled() { }
        private System.Void Enable() { }
        private System.Void Disable() { }
        private System.Void Reset() { }
        private System.Void SetUpState() { }
        private System.Void TearDownState() { }
        private System.Void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change) { }
        private System.Void OnSettingsChange() { }
        private System.Void CheckEnabled() { }

    }

    // TypeToken: 0x2000150
    public class Finger
    {
        // Fields
        private readonly UnityEngine.InputSystem.Touchscreen <screen>k__BackingField;        // 0x10
        private readonly System.Int32 <index>k__BackingField;        // 0x18
        private readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> m_StateHistory;        // 0x20

        // Methods
        private UnityEngine.InputSystem.Touchscreen get_screen() { }
        private System.Int32 get_index() { }
        private System.Boolean get_isActive() { }
        private UnityEngine.Vector2 get_screenPosition() { }
        private UnityEngine.InputSystem.EnhancedTouch.Touch get_lastTouch() { }
        private UnityEngine.InputSystem.EnhancedTouch.Touch get_currentTouch() { }
        private UnityEngine.InputSystem.EnhancedTouch.TouchHistory get_touchHistory() { }
        private System.Void .ctor(UnityEngine.InputSystem.Touchscreen screen, System.Int32 index, UnityEngine.InputSystem.LowLevel.InputUpdateType updateMask) { }
        private System.Boolean ShouldRecordTouch(UnityEngine.InputSystem.InputControl control, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void OnTouchRecorded(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record record) { }
        private UnityEngine.InputSystem.EnhancedTouch.Touch FindTouch(System.UInt32 uniqueId) { }
        private UnityEngine.InputSystem.EnhancedTouch.TouchHistory GetTouchHistory(UnityEngine.InputSystem.EnhancedTouch.Touch touch) { }

    }

    // TypeToken: 0x2000151
    public struct Touch, IEquatable`1
    {
        // Fields
        private readonly UnityEngine.InputSystem.EnhancedTouch.Finger m_Finger;        // 0x10
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<UnityEngine.InputSystem.LowLevel.TouchState> m_TouchRecord;        // 0x18
        private static UnityEngine.InputSystem.EnhancedTouch.Touch.GlobalState s_GlobalState;        // 0x0

        // Methods
        private System.Boolean get_valid() { }
        private UnityEngine.InputSystem.EnhancedTouch.Finger get_finger() { }
        private UnityEngine.InputSystem.TouchPhase get_phase() { }
        private System.Boolean get_began() { }
        private System.Boolean get_inProgress() { }
        private System.Boolean get_ended() { }
        private System.Int32 get_touchId() { }
        private System.Single get_pressure() { }
        private UnityEngine.Vector2 get_radius() { }
        private System.Double get_startTime() { }
        private System.Double get_time() { }
        private UnityEngine.InputSystem.Touchscreen get_screen() { }
        private UnityEngine.Vector2 get_screenPosition() { }
        private UnityEngine.Vector2 get_startScreenPosition() { }
        private UnityEngine.Vector2 get_delta() { }
        private System.Int32 get_tapCount() { }
        private System.Boolean get_isTap() { }
        private System.Int32 get_displayIndex() { }
        private System.Boolean get_isInProgress() { }
        private System.UInt32 get_updateStepCount() { }
        private System.UInt32 get_uniqueId() { }
        private UnityEngine.InputSystem.LowLevel.TouchState& get_state() { }
        private UnityEngine.InputSystem.EnhancedTouch.Touch.ExtraDataPerTouchState& get_extraData() { }
        private UnityEngine.InputSystem.EnhancedTouch.TouchHistory get_history() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Touch> get_activeTouches() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Finger> get_fingers() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.EnhancedTouch.Finger> get_activeFingers() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Touchscreen> get_screens() { }
        private System.Void add_onFingerDown(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }
        private System.Void remove_onFingerDown(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }
        private System.Void add_onFingerUp(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }
        private System.Void remove_onFingerUp(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }
        private System.Void add_onFingerMove(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }
        private System.Void remove_onFingerMove(System.Action<UnityEngine.InputSystem.EnhancedTouch.Finger> value) { }
        private System.Int32 get_maxHistoryLengthPerFinger() { }
        private System.Void .ctor(UnityEngine.InputSystem.EnhancedTouch.Finger finger, UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<UnityEngine.InputSystem.LowLevel.TouchState> touchRecord) { }
        private System.String ToString() { }
        private System.Boolean Equals(UnityEngine.InputSystem.EnhancedTouch.Touch other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void AddTouchscreen(UnityEngine.InputSystem.Touchscreen screen) { }
        private System.Void RemoveTouchscreen(UnityEngine.InputSystem.Touchscreen screen) { }
        private System.Void BeginUpdate() { }
        private UnityEngine.InputSystem.EnhancedTouch.Touch.GlobalState CreateGlobalState() { }
        private UnityEngine.InputSystem.Utilities.ISavedState SaveAndResetState() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000156
    public struct TouchHistory, IReadOnlyList`1, IEnumerable`1, IEnumerable, IReadOnlyCollection`1
    {
        // Fields
        private readonly UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> m_History;        // 0x10
        private readonly UnityEngine.InputSystem.EnhancedTouch.Finger m_Finger;        // 0x18
        private readonly System.Int32 m_Count;        // 0x20
        private readonly System.Int32 m_StartIndex;        // 0x24
        private readonly System.UInt32 m_Version;        // 0x28

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.EnhancedTouch.Finger finger, UnityEngine.InputSystem.LowLevel.InputStateHistory<UnityEngine.InputSystem.LowLevel.TouchState> history, System.Int32 startIndex, System.Int32 count) { }
        private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.EnhancedTouch.Touch> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Int32 get_Count() { }
        private UnityEngine.InputSystem.EnhancedTouch.Touch get_Item(System.Int32 index) { }
        private System.Void CheckValid() { }

    }

    // TypeToken: 0x2000158
    public class TouchSimulation : MonoBehaviour, IInputStateChangeMonitor
    {
        // Fields
        private UnityEngine.InputSystem.Touchscreen <simulatedTouchscreen>k__BackingField;        // 0x18
        private System.Int32 m_NumPointers;        // 0x20
        private UnityEngine.InputSystem.Pointer[] m_Pointers;        // 0x28
        private UnityEngine.Vector2[] m_CurrentPositions;        // 0x30
        private System.Int32[] m_CurrentDisplayIndices;        // 0x38
        private UnityEngine.InputSystem.Controls.ButtonControl[] m_Touches;        // 0x40
        private System.Int32[] m_TouchIds;        // 0x48
        private System.Int32 m_LastTouchId;        // 0x50
        private System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.InputDeviceChange> m_OnDeviceChange;        // 0x58
        private System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> m_OnEvent;        // 0x60
        private static UnityEngine.InputSystem.EnhancedTouch.TouchSimulation s_Instance;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Touchscreen get_simulatedTouchscreen() { }
        private System.Void set_simulatedTouchscreen(UnityEngine.InputSystem.Touchscreen value) { }
        private UnityEngine.InputSystem.EnhancedTouch.TouchSimulation get_instance() { }
        private System.Void Enable() { }
        private System.Void Disable() { }
        private System.Void Destroy() { }
        private System.Void AddPointer(UnityEngine.InputSystem.Pointer pointer) { }
        private System.Void RemovePointer(UnityEngine.InputSystem.Pointer pointer) { }
        private System.Void OnEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device) { }
        private System.Void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void UpdateTouch(System.Int32 touchIndex, System.Int32 pointerIndex, UnityEngine.InputSystem.TouchPhase phase, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Int64 monitorIndex) { }
        private System.Void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, System.Double time, System.Int64 monitorIndex, System.Int32 timerIndex) { }
        private System.Void InstallStateChangeMonitors(System.Int32 startIndex) { }
        private System.Void OnSourceControlChangedValue(UnityEngine.InputSystem.InputControl control, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Int64 sourceDeviceAndButtonIndex) { }
        private System.Void UninstallStateChangeMonitors(System.Int32 startIndex) { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.InputSystem.HID
{

    // TypeToken: 0x2000139
    public class HID : InputDevice
    {
        // Fields
        private static System.String kHIDInterface;        // 0x0
        private static System.String kHIDNamespace;        // 0x0
        private System.Boolean m_HaveParsedHIDDescriptor;        // 0x190
        private UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor m_HIDDescriptor;        // 0x198
        private static readonly Unity.Profiling.ProfilerMarker k_HIDParseDescriptorFallback;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_QueryHIDReportDescriptorDeviceCommandType() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_QueryHIDReportDescriptorSizeDeviceCommandType() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_QueryHIDParsedReportDescriptorDeviceCommandType() { }
        private UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor get_hidDescriptor() { }
        private System.String OnFindLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription& description, System.String matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeDeviceCommand) { }
        private UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor ReadHIDDeviceDescriptor(UnityEngine.InputSystem.Layouts.InputDeviceDescription& deviceDescription, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeCommandDelegate) { }
        private System.String UsagePageToString(UnityEngine.InputSystem.HID.HID.UsagePage usagePage) { }
        private System.String UsageToString(UnityEngine.InputSystem.HID.HID.UsagePage usagePage, System.Int32 usage) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000148
    public class HIDParser
    {
        // Methods
        private System.Boolean ParseReportDescriptor(System.Byte[] buffer, UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor& deviceDescriptor) { }
        private System.Boolean ParseReportDescriptor(System.Byte* bufferPtr, System.Int32 bufferLength, UnityEngine.InputSystem.HID.HID.HIDDeviceDescriptor& deviceDescriptor) { }
        private System.Int32 ReadData(System.Int32 itemSize, System.Byte* currentPtr, System.Byte* endPtr) { }

    }

    // TypeToken: 0x200014D
    public class HIDSupport
    {
        // Fields
        private static UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage[] s_SupportedHIDUsages;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> get_supportedHIDUsages() { }
        private System.Void set_supportedHIDUsages(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> value) { }
        private System.Void Initialize() { }

    }

}

namespace UnityEngine.InputSystem.Haptics
{

    // TypeToken: 0x2000171
    public struct DualMotorRumble
    {
        // Fields
        private System.Single <lowFrequencyMotorSpeed>k__BackingField;        // 0x10
        private System.Single <highFrequencyMotorSpeed>k__BackingField;        // 0x14

        // Methods
        private System.Single get_lowFrequencyMotorSpeed() { }
        private System.Void set_lowFrequencyMotorSpeed(System.Single value) { }
        private System.Single get_highFrequencyMotorSpeed() { }
        private System.Void set_highFrequencyMotorSpeed(System.Single value) { }
        private System.Boolean get_isRumbling() { }
        private System.Void PauseHaptics(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void ResumeHaptics(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void ResetHaptics(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void SetMotorSpeeds(UnityEngine.InputSystem.InputDevice device, System.Single lowFrequency, System.Single highFrequency) { }

    }

    // TypeToken: 0x2000172
    public interface IDualMotorRumble : IHaptics
    {
        // Methods
        private System.Void SetMotorSpeeds(System.Single lowFrequency, System.Single highFrequency) { }

    }

    // TypeToken: 0x2000173
    public interface IHaptics
    {
        // Methods
        private System.Void PauseHaptics() { }
        private System.Void ResumeHaptics() { }
        private System.Void ResetHaptics() { }

    }

}

namespace UnityEngine.InputSystem.Interactions
{

    // TypeToken: 0x200022A
    public class HoldInteraction, IInputInteraction
    {
        // Fields
        public System.Single duration;        // 0x10
        public System.Single pressPoint;        // 0x14
        private System.Double m_TimePressed;        // 0x18

        // Methods
        private System.Single get_durationOrDefault() { }
        private System.Single get_pressPointOrDefault() { }
        private System.Void Process(UnityEngine.InputSystem.InputInteractionContext& context) { }
        private System.Void Reset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022B
    public class MultiTapInteraction, IInputInteraction`1, IInputInteraction
    {
        // Fields
        public System.Single tapTime;        // 0x10
        public System.Single tapDelay;        // 0x14
        public System.Int32 tapCount;        // 0x18
        public System.Single pressPoint;        // 0x1C
        private UnityEngine.InputSystem.Interactions.MultiTapInteraction.TapPhase m_CurrentTapPhase;        // 0x20
        private System.Int32 m_CurrentTapCount;        // 0x24
        private System.Double m_CurrentTapStartTime;        // 0x28
        private System.Double m_LastTapReleaseTime;        // 0x30

        // Methods
        private System.Single get_tapTimeOrDefault() { }
        private System.Single get_tapDelayOrDefault() { }
        private System.Single get_pressPointOrDefault() { }
        private System.Single get_releasePointOrDefault() { }
        private System.Void Process(UnityEngine.InputSystem.InputInteractionContext& context) { }
        private System.Void Reset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022D
    public class PressInteraction, IInputInteraction
    {
        // Fields
        public System.Single pressPoint;        // 0x10
        public UnityEngine.InputSystem.Interactions.PressBehavior behavior;        // 0x14
        private System.Boolean m_WaitingForRelease;        // 0x18

        // Methods
        private System.Single get_pressPointOrDefault() { }
        private System.Single get_releasePointOrDefault() { }
        private System.Void Process(UnityEngine.InputSystem.InputInteractionContext& context) { }
        private System.Void Reset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022E
    public struct PressBehavior
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Interactions.PressBehavior PressOnly;        // 0x0
        public static UnityEngine.InputSystem.Interactions.PressBehavior ReleaseOnly;        // 0x0
        public static UnityEngine.InputSystem.Interactions.PressBehavior PressAndRelease;        // 0x0

    }

    // TypeToken: 0x200022F
    public class SlowTapInteraction, IInputInteraction
    {
        // Fields
        public System.Single duration;        // 0x10
        public System.Single pressPoint;        // 0x14
        private System.Double m_SlowTapStartTime;        // 0x18

        // Methods
        private System.Single get_durationOrDefault() { }
        private System.Single get_pressPointOrDefault() { }
        private System.Void Process(UnityEngine.InputSystem.InputInteractionContext& context) { }
        private System.Void Reset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000230
    public class TapInteraction, IInputInteraction
    {
        // Fields
        public System.Single duration;        // 0x10
        public System.Single pressPoint;        // 0x14
        private System.Double m_TapStartTime;        // 0x18

        // Methods
        private System.Single get_durationOrDefault() { }
        private System.Single get_pressPointOrDefault() { }
        private System.Single get_releasePointOrDefault() { }
        private System.Void Process(UnityEngine.InputSystem.InputInteractionContext& context) { }
        private System.Void Reset() { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.InputSystem.Layouts
{

    // TypeToken: 0x20001F6
    public class InputControlAttribute : PropertyAttribute
    {
        // Fields
        private System.String <layout>k__BackingField;        // 0x10
        private System.String <variants>k__BackingField;        // 0x18
        private System.String <name>k__BackingField;        // 0x20
        private System.String <format>k__BackingField;        // 0x28
        private System.String <usage>k__BackingField;        // 0x30
        private System.String[] <usages>k__BackingField;        // 0x38
        private System.String <parameters>k__BackingField;        // 0x40
        private System.String <processors>k__BackingField;        // 0x48
        private System.String <alias>k__BackingField;        // 0x50
        private System.String[] <aliases>k__BackingField;        // 0x58
        private System.String <useStateFrom>k__BackingField;        // 0x60
        private System.UInt32 <bit>k__BackingField;        // 0x68
        private System.UInt32 <offset>k__BackingField;        // 0x6C
        private System.UInt32 <sizeInBits>k__BackingField;        // 0x70
        private System.Int32 <arraySize>k__BackingField;        // 0x74
        private System.String <displayName>k__BackingField;        // 0x78
        private System.String <shortDisplayName>k__BackingField;        // 0x80
        private System.Boolean <noisy>k__BackingField;        // 0x88
        private System.Boolean <synthetic>k__BackingField;        // 0x89
        private System.Boolean <dontReset>k__BackingField;        // 0x8A
        private System.Object <defaultState>k__BackingField;        // 0x90
        private System.Object <minValue>k__BackingField;        // 0x98
        private System.Object <maxValue>k__BackingField;        // 0xA0

        // Methods
        private System.String get_layout() { }
        private System.Void set_layout(System.String value) { }
        private System.String get_variants() { }
        private System.Void set_variants(System.String value) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.String get_format() { }
        private System.Void set_format(System.String value) { }
        private System.String get_usage() { }
        private System.Void set_usage(System.String value) { }
        private System.String[] get_usages() { }
        private System.Void set_usages(System.String[] value) { }
        private System.String get_parameters() { }
        private System.Void set_parameters(System.String value) { }
        private System.String get_processors() { }
        private System.Void set_processors(System.String value) { }
        private System.String get_alias() { }
        private System.Void set_alias(System.String value) { }
        private System.String[] get_aliases() { }
        private System.Void set_aliases(System.String[] value) { }
        private System.String get_useStateFrom() { }
        private System.Void set_useStateFrom(System.String value) { }
        private System.UInt32 get_bit() { }
        private System.Void set_bit(System.UInt32 value) { }
        private System.UInt32 get_offset() { }
        private System.Void set_offset(System.UInt32 value) { }
        private System.UInt32 get_sizeInBits() { }
        private System.Void set_sizeInBits(System.UInt32 value) { }
        private System.Int32 get_arraySize() { }
        private System.Void set_arraySize(System.Int32 value) { }
        private System.String get_displayName() { }
        private System.Void set_displayName(System.String value) { }
        private System.String get_shortDisplayName() { }
        private System.Void set_shortDisplayName(System.String value) { }
        private System.Boolean get_noisy() { }
        private System.Void set_noisy(System.Boolean value) { }
        private System.Boolean get_synthetic() { }
        private System.Void set_synthetic(System.Boolean value) { }
        private System.Boolean get_dontReset() { }
        private System.Void set_dontReset(System.Boolean value) { }
        private System.Object get_defaultState() { }
        private System.Void set_defaultState(System.Object value) { }
        private System.Object get_minValue() { }
        private System.Void set_minValue(System.Object value) { }
        private System.Object get_maxValue() { }
        private System.Void set_maxValue(System.Object value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F7
    public class InputDeviceFindControlLayoutDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.String Invoke(UnityEngine.InputSystem.Layouts.InputDeviceDescription& description, System.String matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeDeviceCommand) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.InputSystem.Layouts.InputDeviceDescription& description, System.String matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeDeviceCommand, System.AsyncCallback callback, System.Object object) { }
        private System.String EndInvoke(UnityEngine.InputSystem.Layouts.InputDeviceDescription& description, System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001F8
    public class InputControlLayout
    {
        // Fields
        private static UnityEngine.InputSystem.Utilities.InternedString s_DefaultVariant;        // 0x0
        public static System.String VariantSeparator;        // 0x0
        private UnityEngine.InputSystem.Utilities.InternedString m_Name;        // 0x10
        private System.Type m_Type;        // 0x20
        private UnityEngine.InputSystem.Utilities.InternedString m_Variants;        // 0x28
        private UnityEngine.InputSystem.Utilities.FourCC m_StateFormat;        // 0x38
        private System.Int32 m_StateSizeInBytes;        // 0x3C
        private System.Nullable<System.Boolean> m_UpdateBeforeRender;        // 0x40
        private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString> m_BaseLayouts;        // 0x48
        private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString> m_AppliedOverrides;        // 0x68
        private UnityEngine.InputSystem.Utilities.InternedString[] m_CommonUsages;        // 0x88
        private UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[] m_Controls;        // 0x90
        private System.String m_DisplayName;        // 0x98
        private System.String m_Description;        // 0xA0
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Flags m_Flags;        // 0xA8
        private static UnityEngine.InputSystem.Layouts.InputControlLayout.Collection s_Layouts;        // 0x10
        private static UnityEngine.InputSystem.Layouts.InputControlLayout.Cache s_CacheInstance;        // 0x50
        private static System.Int32 s_CacheInstanceRef;        // 0x58

        // Methods
        private UnityEngine.InputSystem.Utilities.InternedString get_DefaultVariant() { }
        private UnityEngine.InputSystem.Utilities.InternedString get_name() { }
        private System.String get_displayName() { }
        private System.Type get_type() { }
        private UnityEngine.InputSystem.Utilities.InternedString get_variants() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_stateFormat() { }
        private System.Int32 get_stateSizeInBytes() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_baseLayouts() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_appliedOverrides() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.InternedString> get_commonUsages() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> get_controls() { }
        private System.Boolean get_updateBeforeRender() { }
        private System.Boolean get_isDeviceLayout() { }
        private System.Boolean get_isControlLayout() { }
        private System.Boolean get_isOverride() { }
        private System.Void set_isOverride(System.Boolean value) { }
        private System.Boolean get_isGenericTypeOfDevice() { }
        private System.Void set_isGenericTypeOfDevice(System.Boolean value) { }
        private System.Boolean get_hideInUI() { }
        private System.Void set_hideInUI(System.Boolean value) { }
        private System.Boolean get_isNoisy() { }
        private System.Void set_isNoisy(System.Boolean value) { }
        private System.Nullable<System.Boolean> get_canRunInBackground() { }
        private System.Void set_canRunInBackground(System.Nullable<System.Boolean> value) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem get_Item(System.String path) { }
        private System.Nullable<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> FindControl(UnityEngine.InputSystem.Utilities.InternedString path) { }
        private System.Nullable<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> FindControlIncludingArrayElements(System.String path, System.Int32& arrayIndex) { }
        private System.Type GetValueType() { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout FromType(System.String name, System.Type type) { }
        private System.String ToJson() { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout FromJson(System.String json) { }
        private System.Void .ctor(System.String name, System.Type type) { }
        private System.Void AddControlItems(System.Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, System.String layoutName) { }
        private System.Void AddControlItemsFromFields(System.Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, System.String layoutName) { }
        private System.Void AddControlItemsFromProperties(System.Type type, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, System.String layoutName) { }
        private System.Void AddControlItemsFromMembers(System.Reflection.MemberInfo[] members, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems, System.String layoutName) { }
        private System.Void AddControlItemsFromMember(System.Reflection.MemberInfo member, UnityEngine.InputSystem.Layouts.InputControlAttribute[] attributes, System.Collections.Generic.List<UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem CreateControlItemFromMember(System.Reflection.MemberInfo member, UnityEngine.InputSystem.Layouts.InputControlAttribute attribute) { }
        private System.String InferLayoutFromValueType(System.Type type) { }
        private System.Void MergeLayout(UnityEngine.InputSystem.Layouts.InputControlLayout other) { }
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> CreateLookupTableForControls(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[] controlItems, System.Collections.Generic.List<System.String> variants) { }
        private System.Boolean VariantsMatch(UnityEngine.InputSystem.Utilities.InternedString expected, UnityEngine.InputSystem.Utilities.InternedString actual) { }
        private System.Boolean VariantsMatch(System.String expected, System.String actual) { }
        private System.Void ParseHeaderFieldsFromJson(System.String json, UnityEngine.InputSystem.Utilities.InternedString& name, UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.Utilities.InternedString>& baseLayouts, UnityEngine.InputSystem.Layouts.InputDeviceMatcher& deviceMatcher) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.Cache& get_cache() { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout.CacheRefInstance CacheRef() { }
        private System.Void .cctor() { }
        private System.Boolean <MergeLayout>b__77_0(UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem x) { }

    }

    // TypeToken: 0x200020C
    public class InputControlLayoutAttribute : Attribute
    {
        // Fields
        private System.Type <stateType>k__BackingField;        // 0x10
        private System.String <stateFormat>k__BackingField;        // 0x18
        private System.String[] <commonUsages>k__BackingField;        // 0x20
        private System.String <variants>k__BackingField;        // 0x28
        private System.Boolean <isNoisy>k__BackingField;        // 0x30
        private System.Nullable<System.Boolean> canRunInBackgroundInternal;        // 0x31
        private System.Nullable<System.Boolean> updateBeforeRenderInternal;        // 0x33
        private System.Boolean <isGenericTypeOfDevice>k__BackingField;        // 0x35
        private System.String <displayName>k__BackingField;        // 0x38
        private System.String <description>k__BackingField;        // 0x40
        private System.Boolean <hideInUI>k__BackingField;        // 0x48

        // Methods
        private System.Type get_stateType() { }
        private System.Void set_stateType(System.Type value) { }
        private System.String get_stateFormat() { }
        private System.Void set_stateFormat(System.String value) { }
        private System.String[] get_commonUsages() { }
        private System.Void set_commonUsages(System.String[] value) { }
        private System.String get_variants() { }
        private System.Void set_variants(System.String value) { }
        private System.Boolean get_isNoisy() { }
        private System.Void set_isNoisy(System.Boolean value) { }
        private System.Boolean get_canRunInBackground() { }
        private System.Void set_canRunInBackground(System.Boolean value) { }
        private System.Boolean get_updateBeforeRender() { }
        private System.Void set_updateBeforeRender(System.Boolean value) { }
        private System.Boolean get_isGenericTypeOfDevice() { }
        private System.Void set_isGenericTypeOfDevice(System.Boolean value) { }
        private System.String get_displayName() { }
        private System.Void set_displayName(System.String value) { }
        private System.String get_description() { }
        private System.Void set_description(System.String value) { }
        private System.Boolean get_hideInUI() { }
        private System.Void set_hideInUI(System.Boolean value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200020D
    public struct InputDeviceBuilder, IDisposable
    {
        // Fields
        private UnityEngine.InputSystem.InputDevice m_Device;        // 0x10
        private UnityEngine.InputSystem.Layouts.InputControlLayout.CacheRefInstance m_LayoutCacheRef;        // 0x18
        private System.Collections.Generic.Dictionary<System.String,UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> m_ChildControlOverrides;        // 0x20
        private System.Collections.Generic.List<System.UInt32> m_StateOffsetToControlMap;        // 0x28
        private System.Text.StringBuilder m_StringBuilder;        // 0x30
        private static System.UInt32 kSizeForControlUsingStateFromOtherControl;        // 0x0
        private static UnityEngine.InputSystem.Layouts.InputDeviceBuilder s_Instance;        // 0x0
        private static System.Int32 s_InstanceRef;        // 0x28

        // Methods
        private System.Void Setup(UnityEngine.InputSystem.Utilities.InternedString layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription) { }
        private UnityEngine.InputSystem.InputDevice Finish() { }
        private System.Void Dispose() { }
        private System.Void Reset() { }
        private UnityEngine.InputSystem.InputControl InstantiateLayout(UnityEngine.InputSystem.Utilities.InternedString layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.Utilities.InternedString name, UnityEngine.InputSystem.InputControl parent) { }
        private UnityEngine.InputSystem.InputControl InstantiateLayout(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.Utilities.InternedString name, UnityEngine.InputSystem.InputControl parent) { }
        private System.Void AddChildControls(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.InputControl parent, System.Boolean& haveChildrenUsingStateFromOtherControls) { }
        private UnityEngine.InputSystem.InputControl AddChildControl(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.InputControl parent, System.Boolean& haveChildrenUsingStateFromOtherControls, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, System.Int32 childIndex, System.String nameOverride) { }
        private System.Void InsertChildControlOverride(UnityEngine.InputSystem.InputControl parent, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem& controlItem) { }
        private System.String ChildControlOverridePath(UnityEngine.InputSystem.InputControl parent, UnityEngine.InputSystem.Utilities.InternedString controlName) { }
        private System.Void AddChildControlIfMissing(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variants, UnityEngine.InputSystem.InputControl parent, System.Boolean& haveChildrenUsingStateFromOtherControls, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem& controlItem) { }
        private UnityEngine.InputSystem.InputControl InsertChildControl(UnityEngine.InputSystem.Layouts.InputControlLayout layout, UnityEngine.InputSystem.Utilities.InternedString variant, UnityEngine.InputSystem.InputControl parent, System.Boolean& haveChildrenUsingStateFromOtherControls, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem& controlItem) { }
        private System.Void ApplyUseStateFrom(UnityEngine.InputSystem.InputControl parent, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem& controlItem, UnityEngine.InputSystem.Layouts.InputControlLayout layout) { }
        private System.Void ShiftChildIndicesInHierarchyOneUp(UnityEngine.InputSystem.InputDevice device, System.Int32 startIndex, UnityEngine.InputSystem.InputControl exceptControl) { }
        private System.Void SetDisplayName(UnityEngine.InputSystem.InputControl control, System.String longDisplayNameFromLayout, System.String shortDisplayNameFromLayout, System.Boolean shortName) { }
        private System.Void AddParentDisplayNameRecursive(UnityEngine.InputSystem.InputControl control, System.Text.StringBuilder stringBuilder, System.Boolean shortName) { }
        private System.Void AddProcessors(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem& controlItem, System.String layoutName) { }
        private System.Void SetFormat(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout FindOrLoadLayout(System.String name) { }
        private System.Void ComputeStateLayout(UnityEngine.InputSystem.InputControl control) { }
        private System.Void FinalizeControlHierarchy() { }
        private System.Void FinalizeControlHierarchyRecursive(UnityEngine.InputSystem.InputControl control, System.Int32 controlIndex, UnityEngine.InputSystem.InputControl[] allControls, System.Boolean noisy, System.Boolean dontReset, System.Int32& controlIndiciesNextFreeIndex) { }
        private System.Void InsertControlBitRangeNode(UnityEngine.InputSystem.InputDevice.ControlBitRangeNode& parent, UnityEngine.InputSystem.InputControl control, System.Int32& controlIndiciesNextFreeIndex, System.UInt16 startOffset) { }
        private System.UInt16 GetBestMidPoint(UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, System.UInt16 startOffset) { }
        private System.Void AddControlToNode(UnityEngine.InputSystem.InputControl control, System.Int32& controlIndiciesNextFreeIndex, System.Int32 nodeIndex) { }
        private System.Void AddChildren(UnityEngine.InputSystem.InputDevice.ControlBitRangeNode& parent, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode left, UnityEngine.InputSystem.InputDevice.ControlBitRangeNode right) { }
        private System.UInt16 GetControlIndex(UnityEngine.InputSystem.InputControl control) { }
        private UnityEngine.InputSystem.Layouts.InputDeviceBuilder& get_instance() { }
        private UnityEngine.InputSystem.Layouts.InputDeviceBuilder.RefInstance Ref() { }

    }

    // TypeToken: 0x200020F
    public struct InputDeviceDescription, IEquatable`1
    {
        // Fields
        private System.String m_InterfaceName;        // 0x10
        private System.String m_DeviceClass;        // 0x18
        private System.String m_Manufacturer;        // 0x20
        private System.String m_Product;        // 0x28
        private System.String m_Serial;        // 0x30
        private System.String m_Version;        // 0x38
        private System.String m_Capabilities;        // 0x40

        // Methods
        private System.String get_interfaceName() { }
        private System.Void set_interfaceName(System.String value) { }
        private System.String get_deviceClass() { }
        private System.Void set_deviceClass(System.String value) { }
        private System.String get_manufacturer() { }
        private System.Void set_manufacturer(System.String value) { }
        private System.String get_product() { }
        private System.Void set_product(System.String value) { }
        private System.String get_serial() { }
        private System.Void set_serial(System.String value) { }
        private System.String get_version() { }
        private System.Void set_version(System.String value) { }
        private System.String get_capabilities() { }
        private System.Void set_capabilities(System.String value) { }
        private System.Boolean get_empty() { }
        private System.String ToString() { }
        private System.Boolean Equals(UnityEngine.InputSystem.Layouts.InputDeviceDescription other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.Layouts.InputDeviceDescription left, UnityEngine.InputSystem.Layouts.InputDeviceDescription right) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.Layouts.InputDeviceDescription left, UnityEngine.InputSystem.Layouts.InputDeviceDescription right) { }
        private System.String ToJson() { }
        private UnityEngine.InputSystem.Layouts.InputDeviceDescription FromJson(System.String json) { }
        private System.Boolean ComparePropertyToDeviceDescriptor(System.String propertyName, UnityEngine.InputSystem.Utilities.JsonParser.JsonString propertyValue, System.String deviceDescriptor) { }

    }

    // TypeToken: 0x2000211
    public struct InputDeviceMatcher, IEquatable`1
    {
        // Fields
        private System.Collections.Generic.KeyValuePair<UnityEngine.InputSystem.Utilities.InternedString,System.Object>[] m_Patterns;        // 0x10
        private static readonly UnityEngine.InputSystem.Utilities.InternedString kInterfaceKey;        // 0x0
        private static readonly UnityEngine.InputSystem.Utilities.InternedString kDeviceClassKey;        // 0x10
        private static readonly UnityEngine.InputSystem.Utilities.InternedString kManufacturerKey;        // 0x20
        private static readonly UnityEngine.InputSystem.Utilities.InternedString kManufacturerContainsKey;        // 0x30
        private static readonly UnityEngine.InputSystem.Utilities.InternedString kProductKey;        // 0x40
        private static readonly UnityEngine.InputSystem.Utilities.InternedString kVersionKey;        // 0x50

        // Methods
        private System.Boolean get_empty() { }
        private System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>> get_patterns() { }
        private UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithInterface(System.String pattern, System.Boolean supportRegex) { }
        private UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithDeviceClass(System.String pattern, System.Boolean supportRegex) { }
        private UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithManufacturer(System.String pattern, System.Boolean supportRegex) { }
        private UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithManufacturerContains(System.String noRegExPattern) { }
        private UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithProduct(System.String pattern, System.Boolean supportRegex) { }
        private UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithVersion(System.String pattern, System.Boolean supportRegex) { }
        private UnityEngine.InputSystem.Layouts.InputDeviceMatcher WithCapability(System.String path, TValue value) { }
        private UnityEngine.InputSystem.Layouts.InputDeviceMatcher With(UnityEngine.InputSystem.Utilities.InternedString key, System.Object value, System.Boolean supportRegex) { }
        private System.Single MatchPercentage(UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription) { }
        private System.Boolean MatchSingleProperty(System.Object pattern, System.String value) { }
        private System.Boolean MatchSinglePropertyContains(System.Object pattern, System.String value) { }
        private System.Int32 GetNumPropertiesIn(UnityEngine.InputSystem.Layouts.InputDeviceDescription description) { }
        private UnityEngine.InputSystem.Layouts.InputDeviceMatcher FromDeviceDescription(UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription) { }
        private System.String ToString() { }
        private System.Boolean Equals(UnityEngine.InputSystem.Layouts.InputDeviceMatcher other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.Layouts.InputDeviceMatcher left, UnityEngine.InputSystem.Layouts.InputDeviceMatcher right) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.Layouts.InputDeviceMatcher left, UnityEngine.InputSystem.Layouts.InputDeviceMatcher right) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

}

namespace UnityEngine.InputSystem.LowLevel
{

    // TypeToken: 0x2000174
    public struct DisableDeviceCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.DisableDeviceCommand Create() { }

    }

    // TypeToken: 0x2000175
    public struct EnableDeviceCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.EnableDeviceCommand Create() { }

    }

    // TypeToken: 0x2000176
    public struct EnableIMECompositionCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        private System.Byte m_ImeEnabled;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private System.Boolean get_imeEnabled() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.EnableIMECompositionCommand Create(System.Boolean enabled) { }

    }

    // TypeToken: 0x2000177
    public interface IInputDeviceCommandInfo
    {
        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }

    }

    // TypeToken: 0x2000178
    public struct InitiateUserAccountPairingCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.InitiateUserAccountPairingCommand Create() { }

    }

    // TypeToken: 0x200017A
    public class InputDeviceCommandDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Nullable<System.Int64> Invoke(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputDeviceCommand* command) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputDeviceCommand* command, System.AsyncCallback callback, System.Object object) { }
        private System.Nullable<System.Int64> EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200017B
    public class InputDeviceExecuteCommandDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Int64 Invoke(UnityEngine.InputSystem.LowLevel.InputDeviceCommand& command) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.InputSystem.LowLevel.InputDeviceCommand& command, System.AsyncCallback callback, System.Object object) { }
        private System.Int64 EndInvoke(UnityEngine.InputSystem.LowLevel.InputDeviceCommand& command, System.IAsyncResult result) { }

    }

    // TypeToken: 0x200017C
    public struct InputDeviceCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kBaseCommandSize;        // 0x0
        public static System.Int32 BaseCommandSize;        // 0x0
        public static System.Int64 GenericFailure;        // 0x0
        public static System.Int64 GenericSuccess;        // 0x0
        public UnityEngine.InputSystem.Utilities.FourCC type;        // 0x10
        public System.Int32 sizeInBytes;        // 0x14

        // Methods
        private System.Int32 get_payloadSizeInBytes() { }
        private System.Void* get_payloadPtr() { }
        private System.Void .ctor(UnityEngine.InputSystem.Utilities.FourCC type, System.Int32 sizeInBytes) { }
        private Unity.Collections.NativeArray<System.Byte> AllocateNative(UnityEngine.InputSystem.Utilities.FourCC type, System.Int32 payloadSize) { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }

    }

    // TypeToken: 0x200017D
    public struct QueryCanRunInBackground, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public System.Boolean canRunInBackground;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.QueryCanRunInBackground Create() { }

    }

    // TypeToken: 0x200017E
    public struct QueryDimensionsCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public UnityEngine.Vector2 outDimensions;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.QueryDimensionsCommand Create() { }

    }

    // TypeToken: 0x200017F
    public struct QueryEnabledStateCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public System.Boolean isEnabled;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.QueryEnabledStateCommand Create() { }

    }

    // TypeToken: 0x2000180
    public struct QueryKeyboardLayoutCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kMaxNameLength;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public UnityEngine.InputSystem.LowLevel.QueryKeyboardLayoutCommand.<nameBuffer>e__FixedBuffer nameBuffer;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private System.String ReadLayoutName() { }
        private System.Void WriteLayoutName(System.String name) { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.QueryKeyboardLayoutCommand Create() { }

    }

    // TypeToken: 0x2000182
    public struct QueryKeyNameCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kMaxNameLength;        // 0x0
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public System.Int32 scanOrKeyCode;        // 0x18
        public UnityEngine.InputSystem.LowLevel.QueryKeyNameCommand.<nameBuffer>e__FixedBuffer nameBuffer;        // 0x1C

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private System.String ReadKeyName() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.QueryKeyNameCommand Create(UnityEngine.InputSystem.Key key) { }

    }

    // TypeToken: 0x2000184
    public struct QueryPairedUserAccountCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kMaxNameLength;        // 0x0
        private static System.Int32 kMaxIdLength;        // 0x0
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public System.UInt64 handle;        // 0x18
        private UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand.<nameBuffer>e__FixedBuffer nameBuffer;        // 0x20
        private UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand.<idBuffer>e__FixedBuffer idBuffer;        // 0x220

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private System.String get_id() { }
        private System.Void set_id(System.String value) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.QueryPairedUserAccountCommand Create() { }

    }

    // TypeToken: 0x2000188
    public struct QuerySamplingFrequencyCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public System.Single frequency;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.QuerySamplingFrequencyCommand Create() { }

    }

    // TypeToken: 0x2000189
    public struct QueryUserIdCommand, IInputDeviceCommandInfo
    {
        // Fields
        public static System.Int32 kMaxIdLength;        // 0x0
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public UnityEngine.InputSystem.LowLevel.QueryUserIdCommand.<idBuffer>e__FixedBuffer idBuffer;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private System.String ReadId() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.QueryUserIdCommand Create() { }

    }

    // TypeToken: 0x200018B
    public struct RequestResetCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.RequestResetCommand Create() { }

    }

    // TypeToken: 0x200018C
    public struct RequestSyncCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.RequestSyncCommand Create() { }

    }

    // TypeToken: 0x200018D
    public struct SetIMECursorPositionCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        private UnityEngine.Vector2 m_Position;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.Vector2 get_position() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.SetIMECursorPositionCommand Create(UnityEngine.Vector2 cursorPosition) { }

    }

    // TypeToken: 0x200018E
    public struct SetSamplingFrequencyCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public System.Single frequency;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.SetSamplingFrequencyCommand Create(System.Single frequency) { }

    }

    // TypeToken: 0x200018F
    public struct WarpMousePositionCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public UnityEngine.Vector2 warpPositionInPlayerDisplaySpace;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.WarpMousePositionCommand Create(UnityEngine.Vector2 position) { }

    }

    // TypeToken: 0x2000190
    public struct GamepadState, IInputStateTypeInfo
    {
        // Fields
        private static System.String ButtonSouthShortDisplayName;        // 0x0
        private static System.String ButtonNorthShortDisplayName;        // 0x0
        private static System.String ButtonWestShortDisplayName;        // 0x0
        private static System.String ButtonEastShortDisplayName;        // 0x0
        public System.UInt32 buttons;        // 0x10
        public UnityEngine.Vector2 leftStick;        // 0x14
        public UnityEngine.Vector2 rightStick;        // 0x1C
        public System.Single leftTrigger;        // 0x24
        public System.Single rightTrigger;        // 0x28

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Format() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }
        private System.Void .ctor(UnityEngine.InputSystem.LowLevel.GamepadButton[] buttons) { }
        private UnityEngine.InputSystem.LowLevel.GamepadState WithButton(UnityEngine.InputSystem.LowLevel.GamepadButton button, System.Boolean value) { }

    }

    // TypeToken: 0x2000191
    public struct GamepadButton
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.LowLevel.GamepadButton DpadUp;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton DpadDown;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton DpadLeft;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton DpadRight;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton North;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton East;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton South;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton West;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton LeftStick;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton RightStick;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton LeftShoulder;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton RightShoulder;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton Start;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton Select;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton LeftTrigger;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton RightTrigger;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton X;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton Y;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton A;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton B;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton Cross;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton Square;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton Triangle;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.GamepadButton Circle;        // 0x0

    }

    // TypeToken: 0x2000192
    public struct DualMotorRumbleCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public System.Single lowFrequencyMotorSpeed;        // 0x18
        public System.Single highFrequencyMotorSpeed;        // 0x1C

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.DualMotorRumbleCommand Create(System.Single lowFrequency, System.Single highFrequency) { }

    }

    // TypeToken: 0x2000193
    public interface ICustomDeviceReset
    {
        // Methods
        private System.Void Reset() { }

    }

    // TypeToken: 0x2000194
    public interface IEventMerger
    {
        // Methods
        private System.Boolean MergeForward(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr, UnityEngine.InputSystem.LowLevel.InputEventPtr nextEventPtr) { }

    }

    // TypeToken: 0x2000195
    public interface IEventPreProcessor
    {
        // Methods
        private System.Boolean PreProcessEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr currentEventPtr) { }

    }

    // TypeToken: 0x2000196
    public interface IInputUpdateCallbackReceiver
    {
        // Methods
        private System.Void OnUpdate() { }

    }

    // TypeToken: 0x2000197
    public interface ITextInputReceiver
    {
        // Methods
        private System.Void OnTextInput(System.Char character) { }
        private System.Void OnIMECompositionChanged(UnityEngine.InputSystem.LowLevel.IMECompositionString compositionString) { }

    }

    // TypeToken: 0x2000198
    public struct JoystickState, IInputStateTypeInfo
    {
        // Fields
        public System.Int32 buttons;        // 0x10
        public UnityEngine.Vector2 stick;        // 0x14

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_kFormat() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }

    }

    // TypeToken: 0x200019A
    public struct KeyboardState, IInputStateTypeInfo
    {
        // Fields
        private static System.Int32 kSizeInBits;        // 0x0
        private static System.Int32 kSizeInBytes;        // 0x0
        public UnityEngine.InputSystem.LowLevel.KeyboardState.<keys>e__FixedBuffer keys;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Format() { }
        private System.Void .ctor(UnityEngine.InputSystem.Key[] pressedKeys) { }
        private System.Void .ctor(System.Boolean IMESelected, UnityEngine.InputSystem.Key[] pressedKeys) { }
        private System.Void Set(UnityEngine.InputSystem.Key key, System.Boolean state) { }
        private System.Boolean Get(UnityEngine.InputSystem.Key key) { }
        private System.Void Press(UnityEngine.InputSystem.Key key) { }
        private System.Void Release(UnityEngine.InputSystem.Key key) { }
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }

    }

    // TypeToken: 0x200019C
    public struct MouseState, IInputStateTypeInfo
    {
        // Fields
        public UnityEngine.Vector2 position;        // 0x10
        public UnityEngine.Vector2 delta;        // 0x18
        public UnityEngine.Vector2 scroll;        // 0x20
        public System.UInt16 buttons;        // 0x28
        public System.UInt16 displayIndex;        // 0x2A
        public System.UInt16 clickCount;        // 0x2C

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Format() { }
        private UnityEngine.InputSystem.LowLevel.MouseState WithButton(UnityEngine.InputSystem.LowLevel.MouseButton button, System.Boolean state) { }
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }

    }

    // TypeToken: 0x200019D
    public struct MouseButton
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.LowLevel.MouseButton Left;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.MouseButton Right;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.MouseButton Middle;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.MouseButton Forward;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.MouseButton Back;        // 0x0

    }

    // TypeToken: 0x200019E
    public struct PenState, IInputStateTypeInfo
    {
        // Fields
        public UnityEngine.Vector2 position;        // 0x10
        public UnityEngine.Vector2 delta;        // 0x18
        public UnityEngine.Vector2 tilt;        // 0x20
        public System.Single pressure;        // 0x28
        public System.Single twist;        // 0x2C
        public System.UInt16 buttons;        // 0x30
        private System.UInt16 displayIndex;        // 0x32

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Format() { }
        private UnityEngine.InputSystem.LowLevel.PenState WithButton(UnityEngine.InputSystem.PenButton button, System.Boolean state) { }
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }

    }

    // TypeToken: 0x200019F
    public struct PointerState, IInputStateTypeInfo
    {
        // Fields
        private System.UInt32 pointerId;        // 0x10
        public UnityEngine.Vector2 position;        // 0x14
        public UnityEngine.Vector2 delta;        // 0x1C
        public System.Single pressure;        // 0x24
        public UnityEngine.Vector2 radius;        // 0x28
        public System.UInt16 buttons;        // 0x30
        public System.UInt16 displayIndex;        // 0x32

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_kFormat() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }

    }

    // TypeToken: 0x20001A0
    public struct AccelerometerState, IInputStateTypeInfo
    {
        // Fields
        public UnityEngine.Vector3 acceleration;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_kFormat() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }

    }

    // TypeToken: 0x20001A1
    public struct GyroscopeState, IInputStateTypeInfo
    {
        // Fields
        public UnityEngine.Vector3 angularVelocity;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_kFormat() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }

    }

    // TypeToken: 0x20001A2
    public struct GravityState, IInputStateTypeInfo
    {
        // Fields
        public UnityEngine.Vector3 gravity;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_kFormat() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }

    }

    // TypeToken: 0x20001A3
    public struct AttitudeState, IInputStateTypeInfo
    {
        // Fields
        public UnityEngine.Quaternion attitude;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_kFormat() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }

    }

    // TypeToken: 0x20001A4
    public struct LinearAccelerationState, IInputStateTypeInfo
    {
        // Fields
        public UnityEngine.Vector3 acceleration;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_kFormat() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }

    }

    // TypeToken: 0x20001A5
    public struct TouchFlags
    {
        // Fields
        public System.Byte value__;        // 0x10
        public static UnityEngine.InputSystem.LowLevel.TouchFlags IndirectTouch;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.TouchFlags PrimaryTouch;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.TouchFlags TapPress;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.TouchFlags TapRelease;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.TouchFlags OrphanedPrimaryTouch;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.TouchFlags BeganInSameFrame;        // 0x0

    }

    // TypeToken: 0x20001A6
    public struct TouchState, IInputStateTypeInfo
    {
        // Fields
        private static System.Int32 kSizeInBytes;        // 0x0
        public System.Int32 touchId;        // 0x10
        public UnityEngine.Vector2 position;        // 0x14
        public UnityEngine.Vector2 delta;        // 0x1C
        public System.Single pressure;        // 0x24
        public UnityEngine.Vector2 radius;        // 0x28
        public System.Byte phaseId;        // 0x30
        public System.Byte tapCount;        // 0x31
        public System.Byte displayIndex;        // 0x32
        public System.Byte flags;        // 0x33
        private System.UInt32 updateStepCount;        // 0x34
        public System.Double startTime;        // 0x38
        public UnityEngine.Vector2 startPosition;        // 0x40

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Format() { }
        private UnityEngine.InputSystem.TouchPhase get_phase() { }
        private System.Void set_phase(UnityEngine.InputSystem.TouchPhase value) { }
        private System.Boolean get_isNoneEndedOrCanceled() { }
        private System.Boolean get_isInProgress() { }
        private System.Boolean get_isPrimaryTouch() { }
        private System.Void set_isPrimaryTouch(System.Boolean value) { }
        private System.Boolean get_isOrphanedPrimaryTouch() { }
        private System.Void set_isOrphanedPrimaryTouch(System.Boolean value) { }
        private System.Boolean get_isIndirectTouch() { }
        private System.Void set_isIndirectTouch(System.Boolean value) { }
        private System.Boolean get_isTap() { }
        private System.Void set_isTap(System.Boolean value) { }
        private System.Boolean get_isTapPress() { }
        private System.Void set_isTapPress(System.Boolean value) { }
        private System.Boolean get_isTapRelease() { }
        private System.Void set_isTapRelease(System.Boolean value) { }
        private System.Boolean get_beganInSameFrame() { }
        private System.Void set_beganInSameFrame(System.Boolean value) { }
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20001A7
    public struct TouchscreenState, IInputStateTypeInfo
    {
        // Fields
        public static System.Int32 MaxTouches;        // 0x0
        public UnityEngine.InputSystem.LowLevel.TouchscreenState.<primaryTouchData>e__FixedBuffer primaryTouchData;        // 0x10
        private static System.Int32 kTouchDataOffset;        // 0x0
        public UnityEngine.InputSystem.LowLevel.TouchscreenState.<touchData>e__FixedBuffer touchData;        // 0x48

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Format() { }
        private UnityEngine.InputSystem.LowLevel.TouchState* get_primaryTouch() { }
        private UnityEngine.InputSystem.LowLevel.TouchState* get_touches() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }

    }

    // TypeToken: 0x20001AA
    public struct ActionEvent, IInputEventTypeInfo
    {
        // Fields
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;        // 0x10
        private System.UInt16 m_ControlIndex;        // 0x24
        private System.UInt16 m_BindingIndex;        // 0x26
        private System.UInt16 m_InteractionIndex;        // 0x28
        private System.Byte m_StateIndex;        // 0x2A
        private System.Byte m_Phase;        // 0x2B
        private System.Double m_StartTime;        // 0x2C
        public UnityEngine.InputSystem.LowLevel.ActionEvent.<m_ValueData>e__FixedBuffer m_ValueData;        // 0x34

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private System.Double get_startTime() { }
        private System.Void set_startTime(System.Double value) { }
        private UnityEngine.InputSystem.InputActionPhase get_phase() { }
        private System.Void set_phase(UnityEngine.InputSystem.InputActionPhase value) { }
        private System.Byte* get_valueData() { }
        private System.Int32 get_valueSizeInBytes() { }
        private System.Int32 get_stateIndex() { }
        private System.Void set_stateIndex(System.Int32 value) { }
        private System.Int32 get_controlIndex() { }
        private System.Void set_controlIndex(System.Int32 value) { }
        private System.Int32 get_bindingIndex() { }
        private System.Void set_bindingIndex(System.Int32 value) { }
        private System.Int32 get_interactionIndex() { }
        private System.Void set_interactionIndex(System.Int32 value) { }
        private UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private System.Int32 GetEventSizeWithValueSize(System.Int32 valueSizeInBytes) { }
        private UnityEngine.InputSystem.LowLevel.ActionEvent* From(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr) { }

    }

    // TypeToken: 0x20001AC
    public struct DeltaStateEvent, IInputEventTypeInfo
    {
        // Fields
        public static System.Int32 Type;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;        // 0x10
        public UnityEngine.InputSystem.Utilities.FourCC stateFormat;        // 0x24
        public System.UInt32 stateOffset;        // 0x28
        private UnityEngine.InputSystem.LowLevel.DeltaStateEvent.<stateData>e__FixedBuffer stateData;        // 0x2C

        // Methods
        private System.UInt32 get_deltaStateSizeInBytes() { }
        private System.Void* get_deltaState() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr() { }
        private UnityEngine.InputSystem.LowLevel.DeltaStateEvent* From(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr) { }
        private UnityEngine.InputSystem.LowLevel.DeltaStateEvent* FromUnchecked(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr) { }
        private Unity.Collections.NativeArray<System.Byte> From(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr& eventPtr, Unity.Collections.Allocator allocator) { }

    }

    // TypeToken: 0x20001AE
    public struct DeviceConfigurationEvent, IInputEventTypeInfo
    {
        // Fields
        public static System.Int32 Type;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr() { }
        private UnityEngine.InputSystem.LowLevel.DeviceConfigurationEvent Create(System.Int32 deviceId, System.Double time) { }

    }

    // TypeToken: 0x20001AF
    public struct DeviceRemoveEvent, IInputEventTypeInfo
    {
        // Fields
        public static System.Int32 Type;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr() { }
        private UnityEngine.InputSystem.LowLevel.DeviceRemoveEvent Create(System.Int32 deviceId, System.Double time) { }

    }

    // TypeToken: 0x20001B0
    public struct DeviceResetEvent, IInputEventTypeInfo
    {
        // Fields
        public static System.Int32 Type;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;        // 0x10
        public System.Boolean hardReset;        // 0x18

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.DeviceResetEvent Create(System.Int32 deviceId, System.Boolean hardReset, System.Double time) { }

    }

    // TypeToken: 0x20001B1
    public interface IInputEventTypeInfo
    {
        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }

    }

    // TypeToken: 0x20001B2
    public struct IMECompositionEvent, IInputEventTypeInfo
    {
        // Fields
        private static System.Int32 kIMECharBufferSize;        // 0x0
        public static System.Int32 Type;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;        // 0x10
        public UnityEngine.InputSystem.LowLevel.IMECompositionString compositionString;        // 0x24

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.IMECompositionEvent Create(System.Int32 deviceId, System.String compositionString, System.Double time) { }

    }

    // TypeToken: 0x20001B3
    public struct IMECompositionString, IEnumerable`1, IEnumerable
    {
        // Fields
        private System.Int32 size;        // 0x10
        private UnityEngine.InputSystem.LowLevel.IMECompositionString.<buffer>e__FixedBuffer buffer;        // 0x14

        // Methods
        private System.Int32 get_Count() { }
        private System.Char get_Item(System.Int32 index) { }
        private System.Void .ctor(System.String characters) { }
        private System.String ToString() { }
        private System.Collections.Generic.IEnumerator<System.Char> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x20001B6
    public struct InputEvent
    {
        // Fields
        private static System.UInt32 kHandledMask;        // 0x0
        private static System.UInt32 kIdMask;        // 0x0
        private static System.Int32 kBaseEventSize;        // 0x0
        public static System.Int32 InvalidEventId;        // 0x0
        private static System.Int32 kAlignment;        // 0x0
        private UnityEngineInternal.Input.NativeInputEvent m_Event;        // 0x10

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_type() { }
        private System.Void set_type(UnityEngine.InputSystem.Utilities.FourCC value) { }
        private System.UInt32 get_sizeInBytes() { }
        private System.Void set_sizeInBytes(System.UInt32 value) { }
        private System.Int32 get_eventId() { }
        private System.Void set_eventId(System.Int32 value) { }
        private System.Int32 get_deviceId() { }
        private System.Void set_deviceId(System.Int32 value) { }
        private System.Double get_time() { }
        private System.Void set_time(System.Double value) { }
        private System.Double get_internalTime() { }
        private System.Void set_internalTime(System.Double value) { }
        private System.Void .ctor(UnityEngine.InputSystem.Utilities.FourCC type, System.Int32 sizeInBytes, System.Int32 deviceId, System.Double time) { }
        private System.Boolean get_handled() { }
        private System.Void set_handled(System.Boolean value) { }
        private System.String ToString() { }
        private UnityEngine.InputSystem.LowLevel.InputEvent* GetNextInMemory(UnityEngine.InputSystem.LowLevel.InputEvent* currentPtr) { }
        private UnityEngine.InputSystem.LowLevel.InputEvent* GetNextInMemoryChecked(UnityEngine.InputSystem.LowLevel.InputEvent* currentPtr, UnityEngine.InputSystem.LowLevel.InputEventBuffer& buffer) { }
        private System.Boolean Equals(UnityEngine.InputSystem.LowLevel.InputEvent* first, UnityEngine.InputSystem.LowLevel.InputEvent* second) { }

    }

    // TypeToken: 0x20001B7
    public struct InputEventBuffer, IEnumerable`1, IEnumerable, IDisposable, ICloneable
    {
        // Fields
        public static System.Int64 BufferSizeUnknown;        // 0x0
        private Unity.Collections.NativeArray<System.Byte> m_Buffer;        // 0x10
        private System.Int64 m_SizeInBytes;        // 0x20
        private System.Int32 m_EventCount;        // 0x28
        private System.Boolean m_WeOwnTheBuffer;        // 0x2C

        // Methods
        private System.Int32 get_eventCount() { }
        private System.Int64 get_sizeInBytes() { }
        private System.Int64 get_capacityInBytes() { }
        private Unity.Collections.NativeArray<System.Byte> get_data() { }
        private UnityEngine.InputSystem.LowLevel.InputEventPtr get_bufferPtr() { }
        private System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr, System.Int32 eventCount, System.Int32 sizeInBytes, System.Int32 capacityInBytes) { }
        private System.Void .ctor(Unity.Collections.NativeArray<System.Byte> buffer, System.Int32 eventCount, System.Int32 sizeInBytes, System.Boolean transferNativeArrayOwnership) { }
        private System.Void AppendEvent(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr, System.Int32 capacityIncrementInBytes, Unity.Collections.Allocator allocator) { }
        private UnityEngine.InputSystem.LowLevel.InputEvent* AllocateEvent(System.Int32 sizeInBytes, System.Int32 capacityIncrementInBytes, Unity.Collections.Allocator allocator) { }
        private System.Boolean Contains(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr) { }
        private System.Void Reset() { }
        private System.Void AdvanceToNextEvent(UnityEngine.InputSystem.LowLevel.InputEvent*& currentReadPos, UnityEngine.InputSystem.LowLevel.InputEvent*& currentWritePos, System.Int32& numEventsRetainedInBuffer, System.Int32& numRemainingEvents, System.Boolean leaveEventInBuffer) { }
        private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void Dispose() { }
        private UnityEngine.InputSystem.LowLevel.InputEventBuffer Clone() { }
        private System.Object System.ICloneable.Clone() { }

    }

    // TypeToken: 0x20001B9
    public struct InputEventListener, IObservable`1
    {
        // Fields
        private static UnityEngine.InputSystem.LowLevel.InputEventListener.ObserverState s_ObserverState;        // 0x0

        // Methods
        private UnityEngine.InputSystem.LowLevel.InputEventListener op_Addition(UnityEngine.InputSystem.LowLevel.InputEventListener _, System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> callback) { }
        private UnityEngine.InputSystem.LowLevel.InputEventListener op_Subtraction(UnityEngine.InputSystem.LowLevel.InputEventListener _, System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> callback) { }
        private System.IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer) { }

    }

    // TypeToken: 0x20001BC
    public struct InputEventPtr, IEquatable`1
    {
        // Fields
        private readonly UnityEngine.InputSystem.LowLevel.InputEvent* m_EventPtr;        // 0x10

        // Methods
        private System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr) { }
        private System.Boolean get_valid() { }
        private System.Boolean get_handled() { }
        private System.Void set_handled(System.Boolean value) { }
        private System.Int32 get_id() { }
        private System.Void set_id(System.Int32 value) { }
        private UnityEngine.InputSystem.Utilities.FourCC get_type() { }
        private System.UInt32 get_sizeInBytes() { }
        private System.Int32 get_deviceId() { }
        private System.Void set_deviceId(System.Int32 value) { }
        private System.Double get_time() { }
        private System.Void set_time(System.Double value) { }
        private System.Double get_internalTime() { }
        private System.Void set_internalTime(System.Double value) { }
        private UnityEngine.InputSystem.LowLevel.InputEvent* get_data() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_stateFormat() { }
        private System.UInt32 get_stateSizeInBytes() { }
        private System.UInt32 get_stateOffset() { }
        private System.Boolean IsA() { }
        private UnityEngine.InputSystem.LowLevel.InputEventPtr Next() { }
        private System.String ToString() { }
        private UnityEngine.InputSystem.LowLevel.InputEvent* ToPointer() { }
        private System.Boolean Equals(UnityEngine.InputSystem.LowLevel.InputEventPtr other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.LowLevel.InputEventPtr left, UnityEngine.InputSystem.LowLevel.InputEventPtr right) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.LowLevel.InputEventPtr left, UnityEngine.InputSystem.LowLevel.InputEventPtr right) { }
        private UnityEngine.InputSystem.LowLevel.InputEventPtr op_Implicit(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr) { }
        private UnityEngine.InputSystem.LowLevel.InputEventPtr From(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr) { }
        private UnityEngine.InputSystem.LowLevel.InputEvent* op_Implicit(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private UnityEngine.InputSystem.LowLevel.InputEvent* FromInputEventPtr(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }

    }

    // TypeToken: 0x20001BD
    public struct InputEventStream
    {
        // Fields
        private UnityEngine.InputSystem.LowLevel.InputEventBuffer m_NativeBuffer;        // 0x10
        private UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentNativeEventReadPtr;        // 0x30
        private UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentNativeEventWritePtr;        // 0x38
        private System.Int32 m_RemainingNativeEventCount;        // 0x40
        private readonly System.Int32 m_MaxAppendedEvents;        // 0x44
        private UnityEngine.InputSystem.LowLevel.InputEventBuffer m_AppendBuffer;        // 0x48
        private UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentAppendEventReadPtr;        // 0x68
        private UnityEngine.InputSystem.LowLevel.InputEvent* m_CurrentAppendEventWritePtr;        // 0x70
        private System.Int32 m_RemainingAppendEventCount;        // 0x78
        private System.Int32 m_NumEventsRetainedInBuffer;        // 0x7C
        private System.Boolean m_IsOpen;        // 0x80

        // Methods
        private System.Boolean get_isOpen() { }
        private System.Int32 get_remainingEventCount() { }
        private System.Int32 get_numEventsRetainedInBuffer() { }
        private UnityEngine.InputSystem.LowLevel.InputEvent* get_currentEventPtr() { }
        private System.UInt32 get_numBytesRetainedInBuffer() { }
        private System.Void .ctor(UnityEngine.InputSystem.LowLevel.InputEventBuffer& eventBuffer, System.Int32 maxAppendedEvents) { }
        private System.Void Close(UnityEngine.InputSystem.LowLevel.InputEventBuffer& eventBuffer) { }
        private System.Void CleanUpAfterException() { }
        private System.Void Write(UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr) { }
        private UnityEngine.InputSystem.LowLevel.InputEvent* Advance(System.Boolean leaveEventInBuffer) { }
        private UnityEngine.InputSystem.LowLevel.InputEvent* Peek() { }

    }

    // TypeToken: 0x20001BE
    public class InputEventTrace, IDisposable, IEnumerable`1, IEnumerable
    {
        // Fields
        private static System.Int32 kDefaultBufferSize;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker k_InputEvenTraceMarker;        // 0x0
        private System.Int32 m_ChangeCounter;        // 0x10
        private System.Boolean m_Enabled;        // 0x14
        private System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,System.Boolean> m_OnFilterEvent;        // 0x18
        private System.Int32 m_DeviceId;        // 0x20
        private UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr>> m_EventListeners;        // 0x28
        private System.Int64 m_EventBufferSize;        // 0x78
        private System.Int64 m_MaxEventBufferSize;        // 0x80
        private System.Int64 m_GrowIncrementSize;        // 0x88
        private System.Int64 m_EventCount;        // 0x90
        private System.Int64 m_EventSizeInBytes;        // 0x98
        private System.UInt64 m_EventBufferStorage;        // 0xA0
        private System.UInt64 m_EventBufferHeadStorage;        // 0xA8
        private System.UInt64 m_EventBufferTailStorage;        // 0xB0
        private System.Boolean m_HasWrapped;        // 0xB8
        private System.Boolean m_RecordFrameMarkers;        // 0xB9
        private UnityEngine.InputSystem.LowLevel.InputEventTrace.DeviceInfo[] m_DeviceInfos;        // 0xC0
        private static System.Int32 kFileVersion;        // 0x8

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_FrameMarkerEvent() { }
        private System.Int32 get_deviceId() { }
        private System.Void set_deviceId(System.Int32 value) { }
        private System.Boolean get_enabled() { }
        private System.Boolean get_recordFrameMarkers() { }
        private System.Void set_recordFrameMarkers(System.Boolean value) { }
        private System.Int64 get_eventCount() { }
        private System.Int64 get_totalEventSizeInBytes() { }
        private System.Int64 get_allocatedSizeInBytes() { }
        private System.Int64 get_maxSizeInBytes() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.LowLevel.InputEventTrace.DeviceInfo> get_deviceInfos() { }
        private System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,System.Boolean> get_onFilterEvent() { }
        private System.Void set_onFilterEvent(System.Func<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice,System.Boolean> value) { }
        private System.Void add_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }
        private System.Void remove_onEvent(System.Action<UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }
        private System.Void .ctor(UnityEngine.InputSystem.InputDevice device, System.Int64 bufferSizeInBytes, System.Boolean growBuffer, System.Int64 maxBufferSizeInBytes, System.Int64 growIncrementSizeInBytes) { }
        private System.Void .ctor(System.Int64 bufferSizeInBytes, System.Boolean growBuffer, System.Int64 maxBufferSizeInBytes, System.Int64 growIncrementSizeInBytes) { }
        private System.Void WriteTo(System.String filePath) { }
        private System.Void WriteTo(System.IO.Stream stream) { }
        private System.Void ReadFrom(System.String filePath) { }
        private System.Void ReadFrom(System.IO.Stream stream) { }
        private UnityEngine.InputSystem.LowLevel.InputEventTrace LoadFrom(System.String filePath) { }
        private UnityEngine.InputSystem.LowLevel.InputEventTrace LoadFrom(System.IO.Stream stream) { }
        private UnityEngine.InputSystem.LowLevel.InputEventTrace.ReplayController Replay() { }
        private System.Boolean Resize(System.Int64 newBufferSize, System.Int64 newMaxBufferSize) { }
        private System.Void Clear() { }
        private System.Void Enable() { }
        private System.Void Disable() { }
        private System.Boolean GetNextEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr& current) { }
        private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputEventPtr> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void Dispose() { }
        private System.Byte* get_m_EventBuffer() { }
        private System.Void set_m_EventBuffer(System.Byte* value) { }
        private System.Byte* get_m_EventBufferHead() { }
        private System.Void set_m_EventBufferHead(System.Byte* value) { }
        private System.Byte* get_m_EventBufferTail() { }
        private System.Void set_m_EventBufferTail(System.Byte* value) { }
        private System.Void Allocate() { }
        private System.Void Release() { }
        private System.Void OnBeforeUpdate() { }
        private System.Void OnInputEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr inputEvent, UnityEngine.InputSystem.InputDevice device) { }
        private UnityEngine.InputSystem.Utilities.FourCC get_kFileFormat() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001C5
    public struct StateEvent, IInputEventTypeInfo
    {
        // Fields
        public static System.Int32 Type;        // 0x0
        private static System.Int32 kStateDataSizeToSubtract;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;        // 0x10
        public UnityEngine.InputSystem.Utilities.FourCC stateFormat;        // 0x24
        private UnityEngine.InputSystem.LowLevel.StateEvent.<stateData>e__FixedBuffer stateData;        // 0x28

        // Methods
        private System.UInt32 get_stateSizeInBytes() { }
        private System.Void* get_state() { }
        private UnityEngine.InputSystem.LowLevel.InputEventPtr ToEventPtr() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private TState GetState() { }
        private TState GetState(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr) { }
        private System.Int32 GetEventSizeWithPayload() { }
        private UnityEngine.InputSystem.LowLevel.StateEvent* From(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr) { }
        private UnityEngine.InputSystem.LowLevel.StateEvent* FromUnchecked(UnityEngine.InputSystem.LowLevel.InputEventPtr ptr) { }
        private Unity.Collections.NativeArray<System.Byte> From(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEventPtr& eventPtr, Unity.Collections.Allocator allocator) { }
        private Unity.Collections.NativeArray<System.Byte> FromDefaultStateFor(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEventPtr& eventPtr, Unity.Collections.Allocator allocator) { }
        private Unity.Collections.NativeArray<System.Byte> From(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEventPtr& eventPtr, Unity.Collections.Allocator allocator, System.Boolean useDefaultState) { }

    }

    // TypeToken: 0x20001C7
    public struct TextEvent, IInputEventTypeInfo
    {
        // Fields
        public static System.Int32 Type;        // 0x0
        public UnityEngine.InputSystem.LowLevel.InputEvent baseEvent;        // 0x10
        public System.Int32 character;        // 0x24

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.LowLevel.TextEvent* From(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private UnityEngine.InputSystem.LowLevel.TextEvent Create(System.Int32 deviceId, System.Char character, System.Double time) { }
        private UnityEngine.InputSystem.LowLevel.TextEvent Create(System.Int32 deviceId, System.Int32 character, System.Double time) { }

    }

    // TypeToken: 0x20001C8
    public class InputUpdateDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, UnityEngine.InputSystem.LowLevel.InputEventBuffer& eventBuffer) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, UnityEngine.InputSystem.LowLevel.InputEventBuffer& eventBuffer, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(UnityEngine.InputSystem.LowLevel.InputEventBuffer& eventBuffer, System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001C9
    public interface IInputRuntime
    {
        // Methods
        private System.Int32 AllocateDeviceId() { }
        private System.Void Update(UnityEngine.InputSystem.LowLevel.InputUpdateType type) { }
        private System.Void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEvent* ptr) { }
        private System.Int64 DeviceCommand(System.Int32 deviceId, UnityEngine.InputSystem.LowLevel.InputDeviceCommand* commandPtr) { }
        private UnityEngine.InputSystem.LowLevel.InputUpdateDelegate get_onUpdate() { }
        private System.Void set_onUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateDelegate value) { }
        private System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> get_onBeforeUpdate() { }
        private System.Void set_onBeforeUpdate(System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value) { }
        private System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> get_onShouldRunUpdate() { }
        private System.Void set_onShouldRunUpdate(System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> value) { }
        private System.Action<System.Int32,System.String> get_onDeviceDiscovered() { }
        private System.Void set_onDeviceDiscovered(System.Action<System.Int32,System.String> value) { }
        private System.Action<System.Boolean> get_onPlayerFocusChanged() { }
        private System.Void set_onPlayerFocusChanged(System.Action<System.Boolean> value) { }
        private System.Boolean get_isPlayerFocused() { }
        private System.Action get_onShutdown() { }
        private System.Void set_onShutdown(System.Action value) { }
        private System.Single get_pollingFrequency() { }
        private System.Void set_pollingFrequency(System.Single value) { }
        private System.Double get_currentTime() { }
        private System.Double get_currentTimeForFixedUpdate() { }
        private System.Single get_unscaledGameTime() { }
        private System.Double get_currentTimeOffsetToRealtimeSinceStartup() { }
        private System.Boolean get_runInBackground() { }
        private System.Void set_runInBackground(System.Boolean value) { }
        private UnityEngine.Vector2 get_screenSize() { }
        private UnityEngine.ScreenOrientation get_screenOrientation() { }
        private System.Boolean get_isInBatchMode() { }

    }

    // TypeToken: 0x20001CA
    public class InputRuntime
    {
        // Fields
        public static UnityEngine.InputSystem.LowLevel.IInputRuntime s_Instance;        // 0x0
        public static System.Double s_CurrentTimeOffsetToRealtimeSinceStartup;        // 0x8

    }

    // TypeToken: 0x20001CB
    public class InputRuntimeExtensions
    {
        // Methods
        private System.Int64 DeviceCommand(UnityEngine.InputSystem.LowLevel.IInputRuntime runtime, System.Int32 deviceId, TCommand& command) { }

    }

    // TypeToken: 0x20001CC
    public struct InputMetrics
    {
        // Fields
        private System.Int32 <maxNumDevices>k__BackingField;        // 0x10
        private System.Int32 <currentNumDevices>k__BackingField;        // 0x14
        private System.Int32 <maxStateSizeInBytes>k__BackingField;        // 0x18
        private System.Int32 <currentStateSizeInBytes>k__BackingField;        // 0x1C
        private System.Int32 <currentControlCount>k__BackingField;        // 0x20
        private System.Int32 <currentLayoutCount>k__BackingField;        // 0x24
        private System.Int32 <totalEventBytes>k__BackingField;        // 0x28
        private System.Int32 <totalEventCount>k__BackingField;        // 0x2C
        private System.Int32 <totalUpdateCount>k__BackingField;        // 0x30
        private System.Double <totalEventProcessingTime>k__BackingField;        // 0x38
        private System.Double <totalEventLagTime>k__BackingField;        // 0x40

        // Methods
        private System.Int32 get_maxNumDevices() { }
        private System.Void set_maxNumDevices(System.Int32 value) { }
        private System.Int32 get_currentNumDevices() { }
        private System.Void set_currentNumDevices(System.Int32 value) { }
        private System.Int32 get_maxStateSizeInBytes() { }
        private System.Void set_maxStateSizeInBytes(System.Int32 value) { }
        private System.Int32 get_currentStateSizeInBytes() { }
        private System.Void set_currentStateSizeInBytes(System.Int32 value) { }
        private System.Int32 get_currentControlCount() { }
        private System.Void set_currentControlCount(System.Int32 value) { }
        private System.Int32 get_currentLayoutCount() { }
        private System.Void set_currentLayoutCount(System.Int32 value) { }
        private System.Int32 get_totalEventBytes() { }
        private System.Void set_totalEventBytes(System.Int32 value) { }
        private System.Int32 get_totalEventCount() { }
        private System.Void set_totalEventCount(System.Int32 value) { }
        private System.Int32 get_totalUpdateCount() { }
        private System.Void set_totalUpdateCount(System.Int32 value) { }
        private System.Double get_totalEventProcessingTime() { }
        private System.Void set_totalEventProcessingTime(System.Double value) { }
        private System.Double get_totalEventLagTime() { }
        private System.Void set_totalEventLagTime(System.Double value) { }
        private System.Single get_averageEventBytesPerFrame() { }
        private System.Double get_averageProcessingTimePerEvent() { }
        private System.Double get_averageLagTimePerEvent() { }

    }

    // TypeToken: 0x20001CD
    public struct InputUpdateType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.LowLevel.InputUpdateType None;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.InputUpdateType Dynamic;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.InputUpdateType Fixed;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.InputUpdateType BeforeRender;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.InputUpdateType Editor;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.InputUpdateType Manual;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.InputUpdateType Default;        // 0x0

    }

    // TypeToken: 0x20001CE
    public class InputUpdate
    {
        // Fields
        public static System.UInt32 s_UpdateStepCount;        // 0x0
        public static UnityEngine.InputSystem.LowLevel.InputUpdateType s_LatestUpdateType;        // 0x4
        public static UnityEngine.InputSystem.LowLevel.InputUpdate.UpdateStepCount s_PlayerUpdateStepCount;        // 0x8

        // Methods
        private System.Void OnBeforeUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType type) { }
        private System.Void OnUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType type) { }
        private UnityEngine.InputSystem.LowLevel.InputUpdate.SerializedState Save() { }
        private System.Void Restore(UnityEngine.InputSystem.LowLevel.InputUpdate.SerializedState state) { }
        private UnityEngine.InputSystem.LowLevel.InputUpdateType GetUpdateTypeForPlayer(UnityEngine.InputSystem.LowLevel.InputUpdateType mask) { }
        private System.Boolean IsPlayerUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType) { }

    }

    // TypeToken: 0x20001D1
    public class NativeInputRuntime, IInputRuntime
    {
        // Fields
        public static readonly UnityEngine.InputSystem.LowLevel.NativeInputRuntime instance;        // 0x0
        private System.Boolean m_RunInBackground;        // 0x10
        private System.Action m_ShutdownMethod;        // 0x18
        private UnityEngine.InputSystem.LowLevel.InputUpdateDelegate m_OnUpdate;        // 0x20
        private System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> m_OnBeforeUpdate;        // 0x28
        private System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> m_OnShouldRunUpdate;        // 0x30
        private System.Single m_PollingFrequency;        // 0x38
        private System.Boolean m_DidCallOnShutdown;        // 0x3C
        private System.Action<System.Boolean> m_FocusChangedMethod;        // 0x40

        // Methods
        private System.Int32 AllocateDeviceId() { }
        private System.Void Update(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType) { }
        private System.Void QueueEvent(UnityEngine.InputSystem.LowLevel.InputEvent* ptr) { }
        private System.Int64 DeviceCommand(System.Int32 deviceId, UnityEngine.InputSystem.LowLevel.InputDeviceCommand* commandPtr) { }
        private UnityEngine.InputSystem.LowLevel.InputUpdateDelegate get_onUpdate() { }
        private System.Void set_onUpdate(UnityEngine.InputSystem.LowLevel.InputUpdateDelegate value) { }
        private System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> get_onBeforeUpdate() { }
        private System.Void set_onBeforeUpdate(System.Action<UnityEngine.InputSystem.LowLevel.InputUpdateType> value) { }
        private System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> get_onShouldRunUpdate() { }
        private System.Void set_onShouldRunUpdate(System.Func<UnityEngine.InputSystem.LowLevel.InputUpdateType,System.Boolean> value) { }
        private System.Action<System.Int32,System.String> get_onDeviceDiscovered() { }
        private System.Void set_onDeviceDiscovered(System.Action<System.Int32,System.String> value) { }
        private System.Action get_onShutdown() { }
        private System.Void set_onShutdown(System.Action value) { }
        private System.Action<System.Boolean> get_onPlayerFocusChanged() { }
        private System.Void set_onPlayerFocusChanged(System.Action<System.Boolean> value) { }
        private System.Boolean get_isPlayerFocused() { }
        private System.Single get_pollingFrequency() { }
        private System.Void set_pollingFrequency(System.Single value) { }
        private System.Double get_currentTime() { }
        private System.Double get_currentTimeForFixedUpdate() { }
        private System.Double get_currentTimeOffsetToRealtimeSinceStartup() { }
        private System.Single get_unscaledGameTime() { }
        private System.Boolean get_runInBackground() { }
        private System.Void set_runInBackground(System.Boolean value) { }
        private System.Void OnShutdown() { }
        private System.Boolean OnWantsToShutdown() { }
        private System.Void OnFocusChanged(System.Boolean focus) { }
        private UnityEngine.Vector2 get_screenSize() { }
        private UnityEngine.ScreenOrientation get_screenOrientation() { }
        private System.Boolean get_isInBatchMode() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001D5
    public interface IInputStateCallbackReceiver
    {
        // Methods
        private System.Void OnNextUpdate() { }
        private System.Void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Boolean GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.UInt32& offset) { }

    }

    // TypeToken: 0x20001D6
    public interface IInputStateChangeMonitor
    {
        // Methods
        private System.Void NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Int64 monitorIndex) { }
        private System.Void NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, System.Double time, System.Int64 monitorIndex, System.Int32 timerIndex) { }

    }

    // TypeToken: 0x20001D7
    public interface IInputStateTypeInfo
    {
        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }

    }

    // TypeToken: 0x20001D8
    public class InputState
    {
        // Methods
        private UnityEngine.InputSystem.LowLevel.InputUpdateType get_currentUpdateType() { }
        private System.UInt32 get_updateCount() { }
        private System.Double get_currentTime() { }
        private System.Void add_onChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }
        private System.Void remove_onChange(System.Action<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }
        private System.Void Change(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType) { }
        private System.Void Change(UnityEngine.InputSystem.InputControl control, TState state, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void Change(UnityEngine.InputSystem.InputControl control, TState& state, UnityEngine.InputSystem.LowLevel.InputUpdateType updateType, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Boolean IsIntegerFormat(UnityEngine.InputSystem.Utilities.FourCC format) { }
        private System.Void AddChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Int64 monitorIndex, System.UInt32 groupIndex) { }
        private UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor AddChangeMonitor(UnityEngine.InputSystem.InputControl control, System.Action<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Int64> valueChangeCallback, System.Int32 monitorIndex, System.Action<UnityEngine.InputSystem.InputControl,System.Double,System.Int64,System.Int32> timerExpiredCallback) { }
        private System.Void RemoveChangeMonitor(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Int64 monitorIndex) { }
        private System.Void AddChangeMonitorTimeout(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Double time, System.Int64 monitorIndex, System.Int32 timerIndex) { }
        private System.Void RemoveChangeMonitorTimeout(UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor, System.Int64 monitorIndex, System.Int32 timerIndex) { }

    }

    // TypeToken: 0x20001DA
    public struct InputStateBlock
    {
        // Fields
        public static System.UInt32 InvalidOffset;        // 0x0
        public static System.UInt32 AutomaticOffset;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatInvalid;        // 0x0
        private static System.Int32 kFormatInvalid;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatBit;        // 0x4
        private static System.Int32 kFormatBit;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatSBit;        // 0x8
        private static System.Int32 kFormatSBit;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatInt;        // 0xC
        private static System.Int32 kFormatInt;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatUInt;        // 0x10
        private static System.Int32 kFormatUInt;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatShort;        // 0x14
        private static System.Int32 kFormatShort;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatUShort;        // 0x18
        private static System.Int32 kFormatUShort;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatByte;        // 0x1C
        private static System.Int32 kFormatByte;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatSByte;        // 0x20
        private static System.Int32 kFormatSByte;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatLong;        // 0x24
        private static System.Int32 kFormatLong;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatULong;        // 0x28
        private static System.Int32 kFormatULong;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatFloat;        // 0x2C
        private static System.Int32 kFormatFloat;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatDouble;        // 0x30
        private static System.Int32 kFormatDouble;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatVector2;        // 0x34
        private static System.Int32 kFormatVector2;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatVector3;        // 0x38
        private static System.Int32 kFormatVector3;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatQuaternion;        // 0x3C
        private static System.Int32 kFormatQuaternion;        // 0x0
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatVector2Short;        // 0x40
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatVector3Short;        // 0x44
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatVector2Byte;        // 0x48
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatVector3Byte;        // 0x4C
        public static readonly UnityEngine.InputSystem.Utilities.FourCC FormatPose;        // 0x50
        private static System.Int32 kFormatPose;        // 0x0
        private UnityEngine.InputSystem.Utilities.FourCC <format>k__BackingField;        // 0x10
        private System.UInt32 m_ByteOffset;        // 0x14
        private System.UInt32 <bitOffset>k__BackingField;        // 0x18
        private System.UInt32 <sizeInBits>k__BackingField;        // 0x1C

        // Methods
        private System.Int32 GetSizeOfPrimitiveFormatInBits(UnityEngine.InputSystem.Utilities.FourCC type) { }
        private UnityEngine.InputSystem.Utilities.FourCC GetPrimitiveFormatFromType(System.Type type) { }
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }
        private System.Void set_format(UnityEngine.InputSystem.Utilities.FourCC value) { }
        private System.UInt32 get_byteOffset() { }
        private System.Void set_byteOffset(System.UInt32 value) { }
        private System.UInt32 get_bitOffset() { }
        private System.Void set_bitOffset(System.UInt32 value) { }
        private System.UInt32 get_sizeInBits() { }
        private System.Void set_sizeInBits(System.UInt32 value) { }
        private System.UInt32 get_alignedSizeInBytes() { }
        private System.UInt32 get_effectiveByteOffset() { }
        private System.UInt32 get_effectiveBitOffset() { }
        private System.Int32 ReadInt(System.Void* statePtr) { }
        private System.Void WriteInt(System.Void* statePtr, System.Int32 value) { }
        private System.Single ReadFloat(System.Void* statePtr) { }
        private System.Void WriteFloat(System.Void* statePtr, System.Single value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue FloatToPrimitiveValue(System.Single value) { }
        private System.Double ReadDouble(System.Void* statePtr) { }
        private System.Void WriteDouble(System.Void* statePtr, System.Double value) { }
        private System.Void Write(System.Void* statePtr, UnityEngine.InputSystem.Utilities.PrimitiveValue value) { }
        private System.Void CopyToFrom(System.Void* toStatePtr, System.Void* fromStatePtr) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001DB
    public struct InputStateBuffers
    {
        // Fields
        public System.UInt32 sizePerBuffer;        // 0x10
        public System.UInt32 totalSize;        // 0x14
        public System.Void* defaultStateBuffer;        // 0x18
        public System.Void* noiseMaskBuffer;        // 0x20
        public System.Void* resetMaskBuffer;        // 0x28
        private System.Void* m_AllBuffers;        // 0x30
        private UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers m_PlayerStateBuffers;        // 0x38
        private static System.Void* s_DefaultStateBuffer;        // 0x0
        private static System.Void* s_NoiseMaskBuffer;        // 0x8
        private static System.Void* s_ResetMaskBuffer;        // 0x10
        private static UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers s_CurrentBuffers;        // 0x18

        // Methods
        private UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers GetDoubleBuffersFor(UnityEngine.InputSystem.LowLevel.InputUpdateType updateType) { }
        private System.Void* GetFrontBufferForDevice(System.Int32 deviceIndex) { }
        private System.Void* GetBackBufferForDevice(System.Int32 deviceIndex) { }
        private System.Void SwitchTo(UnityEngine.InputSystem.LowLevel.InputStateBuffers buffers, UnityEngine.InputSystem.LowLevel.InputUpdateType update) { }
        private System.Void AllocateAll(UnityEngine.InputSystem.InputDevice[] devices, System.Int32 deviceCount) { }
        private UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers SetUpDeviceToBufferMappings(System.Int32 deviceCount, System.Byte*& bufferPtr, System.UInt32 sizePerBuffer, System.UInt32 mappingTableSizePerBuffer) { }
        private System.Void FreeAll() { }
        private System.Void MigrateAll(UnityEngine.InputSystem.InputDevice[] devices, System.Int32 deviceCount, UnityEngine.InputSystem.LowLevel.InputStateBuffers oldBuffers) { }
        private System.Void MigrateDoubleBuffer(UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers newBuffer, UnityEngine.InputSystem.InputDevice[] devices, System.Int32 deviceCount, UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers oldBuffer) { }
        private System.Void MigrateSingleBuffer(System.Void* newBuffer, UnityEngine.InputSystem.InputDevice[] devices, System.Int32 deviceCount, System.Void* oldBuffer) { }
        private System.UInt32 ComputeSizeOfSingleStateBuffer(UnityEngine.InputSystem.InputDevice[] devices, System.Int32 deviceCount) { }
        private System.UInt32 NextDeviceOffset(System.UInt32 currentOffset, UnityEngine.InputSystem.InputDevice device) { }

    }

    // TypeToken: 0x20001DD
    public class InputStateHistory, IDisposable, IEnumerable`1, IEnumerable, IInputStateChangeMonitor
    {
        // Fields
        private static System.Int32 kDefaultHistorySize;        // 0x0
        private System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> <onRecordAdded>k__BackingField;        // 0x10
        private System.Func<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> <onShouldRecordStateChange>k__BackingField;        // 0x18
        private UnityEngine.InputSystem.InputControl[] m_Controls;        // 0x20
        private System.Int32 m_ControlCount;        // 0x28
        private Unity.Collections.NativeArray<System.Byte> m_RecordBuffer;        // 0x30
        private System.Int32 m_StateSizeInBytes;        // 0x40
        private System.Int32 m_RecordCount;        // 0x44
        private System.Int32 m_HistoryDepth;        // 0x48
        private System.Int32 m_ExtraMemoryPerRecord;        // 0x4C
        private System.Int32 m_HeadIndex;        // 0x50
        private System.UInt32 m_CurrentVersion;        // 0x54
        private System.Nullable<UnityEngine.InputSystem.LowLevel.InputUpdateType> m_UpdateMask;        // 0x58
        private readonly System.Boolean m_AddNewControls;        // 0x60

        // Methods
        private System.Int32 get_Count() { }
        private System.UInt32 get_version() { }
        private System.Int32 get_historyDepth() { }
        private System.Void set_historyDepth(System.Int32 value) { }
        private System.Int32 get_extraMemoryPerRecord() { }
        private System.Void set_extraMemoryPerRecord(System.Int32 value) { }
        private UnityEngine.InputSystem.LowLevel.InputUpdateType get_updateMask() { }
        private System.Void set_updateMask(UnityEngine.InputSystem.LowLevel.InputUpdateType value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControl> get_controls() { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.Record get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, UnityEngine.InputSystem.LowLevel.InputStateHistory.Record value) { }
        private System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> get_onRecordAdded() { }
        private System.Void set_onRecordAdded(System.Action<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> value) { }
        private System.Func<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> get_onShouldRecordStateChange() { }
        private System.Void set_onShouldRecordStateChange(System.Func<UnityEngine.InputSystem.InputControl,System.Double,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value) { }
        private System.Void .ctor(System.Int32 maxStateSizeInBytes) { }
        private System.Void .ctor(System.String path) { }
        private System.Void .ctor(UnityEngine.InputSystem.InputControl control) { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl> controls) { }
        private System.Void Finalize() { }
        private System.Void Clear() { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.Record AddRecord(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record record) { }
        private System.Void StartRecording() { }
        private System.Void StopRecording() { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.Record RecordStateChange(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.Record RecordStateChange(UnityEngine.InputSystem.InputControl control, System.Void* statePtr, System.Double time) { }
        private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void Dispose() { }
        private System.Void Destroy() { }
        private System.Void Allocate() { }
        private System.Int32 RecordIndexToUserIndex(System.Int32 index) { }
        private System.Int32 UserIndexToRecordIndex(System.Int32 index) { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* GetRecord(System.Int32 index) { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* GetRecordUnchecked(System.Int32 index) { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* AllocateRecord(System.Int32& index) { }
        private TValue ReadValue(UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* data) { }
        private System.Object ReadValueAsObject(UnityEngine.InputSystem.LowLevel.InputStateHistory.RecordHeader* data) { }
        private System.Void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(UnityEngine.InputSystem.InputControl control, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Int64 monitorIndex) { }
        private System.Void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(UnityEngine.InputSystem.InputControl control, System.Double time, System.Int64 monitorIndex, System.Int32 timerIndex) { }
        private System.Int32 get_bytesPerRecord() { }

    }

    // TypeToken: 0x20001E3
    public class InputStateHistory`1 : InputStateHistory, IReadOnlyList`1, IEnumerable`1, IEnumerable, IReadOnlyCollection`1
    {
        // Methods
        private System.Void .ctor(System.Nullable<System.Int32> maxStateSizeInBytes) { }
        private System.Void .ctor(UnityEngine.InputSystem.InputControl<TValue> control) { }
        private System.Void .ctor(System.String path) { }
        private System.Void Finalize() { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> AddRecord(UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> record) { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> RecordStateChange(UnityEngine.InputSystem.InputControl<TValue> control, TValue value, System.Double time) { }
        private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue>> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, UnityEngine.InputSystem.LowLevel.InputStateHistory.Record<TValue> value) { }

    }

    // TypeToken: 0x20001E6
    public class SelectObservable`2, IObservable`1
    {
        // Fields
        private readonly System.IObservable<TSource> m_Source;        // 0x0
        private readonly System.Func<TSource,TResult> m_Filter;        // 0x0

        // Methods
        private System.Void .ctor(System.IObservable<TSource> source, System.Func<TSource,TResult> filter) { }
        private System.IDisposable Subscribe(System.IObserver<TResult> observer) { }

    }

}

namespace UnityEngine.InputSystem.OnScreen
{

    // TypeToken: 0x2000133
    public class OnScreenButton : OnScreenControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
    {
        // Fields
        private System.String m_ControlPath;        // 0x30

        // Methods
        private System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.String get_controlPathInternal() { }
        private System.Void set_controlPathInternal(System.String value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000134
    public class OnScreenControl : MonoBehaviour
    {
        // Fields
        private UnityEngine.InputSystem.InputControl m_Control;        // 0x18
        private UnityEngine.InputSystem.OnScreen.OnScreenControl m_NextControlOnDevice;        // 0x20
        private UnityEngine.InputSystem.LowLevel.InputEventPtr m_InputEventPtr;        // 0x28
        private static System.Int32 s_nbActiveInstances;        // 0x0
        private static UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.OnScreen.OnScreenControl.OnScreenDeviceInfo> s_OnScreenDevices;        // 0x8

        // Methods
        private System.String get_controlPath() { }
        private System.Void set_controlPath(System.String value) { }
        private UnityEngine.InputSystem.InputControl get_control() { }
        private System.String get_controlPathInternal() { }
        private System.Void set_controlPathInternal(System.String value) { }
        private System.Void SetupInputControl() { }
        private System.Void SendValueToControl(TValue value) { }
        private System.Void SentDefaultValueToControl() { }
        private System.Boolean get_HasAnyActive() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.String GetWarningMessage() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000136
    public class UGUIOnScreenControlUtils
    {
        // Methods
        private UnityEngine.RectTransform GetCanvasRectTransform(UnityEngine.Transform transform) { }

    }

    // TypeToken: 0x2000137
    public class OnScreenStick : OnScreenControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
    {
        // Fields
        private static System.String kDynamicOriginClickable;        // 0x0
        private System.Single m_MovementRange;        // 0x30
        private System.Single m_DynamicOriginRange;        // 0x34
        private System.String m_ControlPath;        // 0x38
        private UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviour m_Behaviour;        // 0x40
        private System.Boolean m_UseIsolatedInputActions;        // 0x44
        private UnityEngine.InputSystem.InputAction m_PointerDownAction;        // 0x48
        private UnityEngine.InputSystem.InputAction m_PointerMoveAction;        // 0x50
        private UnityEngine.Vector3 m_StartPos;        // 0x58
        private UnityEngine.Vector2 m_PointerDownPos;        // 0x64
        private System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> m_RaycastResults;        // 0x70
        private UnityEngine.EventSystems.PointerEventData m_PointerEventData;        // 0x78
        private UnityEngine.InputSystem.Controls.TouchControl m_TouchControl;        // 0x80
        private System.Boolean m_IsIsolationActive;        // 0x88

        // Methods
        private System.Void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void Start() { }
        private System.Void OnDestroy() { }
        private System.Void BeginInteraction(UnityEngine.Vector2 pointerPosition, UnityEngine.Camera uiCamera) { }
        private System.Void MoveStick(UnityEngine.Vector2 pointerPosition, UnityEngine.Camera uiCamera) { }
        private System.Void EndInteraction() { }
        private System.Void OnPointerDown(UnityEngine.InputSystem.InputAction.CallbackContext ctx) { }
        private System.Void OnPointerChanged(UnityEngine.InputSystem.InputAction.CallbackContext ctx) { }
        private System.Void OnPointerMove(UnityEngine.InputSystem.InputAction.CallbackContext ctx) { }
        private System.Void OnPointerUp(UnityEngine.InputSystem.InputAction.CallbackContext ctx) { }
        private UnityEngine.Camera GetCameraFromCanvas() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void DrawGizmoCircle(UnityEngine.Vector2 center, System.Single radius) { }
        private System.Void UpdateDynamicOriginClickableArea() { }
        private System.Single get_movementRange() { }
        private System.Void set_movementRange(System.Single value) { }
        private System.Single get_dynamicOriginRange() { }
        private System.Void set_dynamicOriginRange(System.Single value) { }
        private System.Boolean get_useIsolatedInputActions() { }
        private System.Void set_useIsolatedInputActions(System.Boolean value) { }
        private System.String get_controlPathInternal() { }
        private System.Void set_controlPathInternal(System.String value) { }
        private UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviour get_behaviour() { }
        private System.Void set_behaviour(UnityEngine.InputSystem.OnScreen.OnScreenStick.Behaviour value) { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.InputSystem.Processors
{

    // TypeToken: 0x20001E8
    public class AxisDeadzoneProcessor : InputProcessor`1
    {
        // Fields
        public System.Single min;        // 0x10
        public System.Single max;        // 0x14

        // Methods
        private System.Single get_minOrDefault() { }
        private System.Single get_maxOrDefault() { }
        private System.Single Process(System.Single value, UnityEngine.InputSystem.InputControl control) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E9
    public class ClampProcessor : InputProcessor`1
    {
        // Fields
        public System.Single min;        // 0x10
        public System.Single max;        // 0x14

        // Methods
        private System.Single Process(System.Single value, UnityEngine.InputSystem.InputControl control) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001EA
    public class CompensateDirectionProcessor : InputProcessor`1
    {
        // Methods
        private UnityEngine.Vector3 Process(UnityEngine.Vector3 value, UnityEngine.InputSystem.InputControl control) { }
        private System.String ToString() { }
        private UnityEngine.InputSystem.InputProcessor.CachingPolicy get_cachingPolicy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001EB
    public class CompensateRotationProcessor : InputProcessor`1
    {
        // Methods
        private UnityEngine.Quaternion Process(UnityEngine.Quaternion value, UnityEngine.InputSystem.InputControl control) { }
        private System.String ToString() { }
        private UnityEngine.InputSystem.InputProcessor.CachingPolicy get_cachingPolicy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001EC
    public class InvertProcessor : InputProcessor`1
    {
        // Methods
        private System.Single Process(System.Single value, UnityEngine.InputSystem.InputControl control) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001ED
    public class InvertVector2Processor : InputProcessor`1
    {
        // Fields
        public System.Boolean invertX;        // 0x10
        public System.Boolean invertY;        // 0x11

        // Methods
        private UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001EE
    public class InvertVector3Processor : InputProcessor`1
    {
        // Fields
        public System.Boolean invertX;        // 0x10
        public System.Boolean invertY;        // 0x11
        public System.Boolean invertZ;        // 0x12

        // Methods
        private UnityEngine.Vector3 Process(UnityEngine.Vector3 value, UnityEngine.InputSystem.InputControl control) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001EF
    public class NormalizeProcessor : InputProcessor`1
    {
        // Fields
        public System.Single min;        // 0x10
        public System.Single max;        // 0x14
        public System.Single zero;        // 0x18

        // Methods
        private System.Single Process(System.Single value, UnityEngine.InputSystem.InputControl control) { }
        private System.Single Normalize(System.Single value, System.Single min, System.Single max, System.Single zero) { }
        private System.Single Denormalize(System.Single value, System.Single min, System.Single max, System.Single zero) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F0
    public class NormalizeVector2Processor : InputProcessor`1
    {
        // Methods
        private UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F1
    public class NormalizeVector3Processor : InputProcessor`1
    {
        // Methods
        private UnityEngine.Vector3 Process(UnityEngine.Vector3 value, UnityEngine.InputSystem.InputControl control) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F2
    public class ScaleProcessor : InputProcessor`1
    {
        // Fields
        public System.Single factor;        // 0x10

        // Methods
        private System.Single Process(System.Single value, UnityEngine.InputSystem.InputControl control) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F3
    public class ScaleVector2Processor : InputProcessor`1
    {
        // Fields
        public System.Single x;        // 0x10
        public System.Single y;        // 0x14

        // Methods
        private UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F4
    public class ScaleVector3Processor : InputProcessor`1
    {
        // Fields
        public System.Single x;        // 0x10
        public System.Single y;        // 0x14
        public System.Single z;        // 0x18

        // Methods
        private UnityEngine.Vector3 Process(UnityEngine.Vector3 value, UnityEngine.InputSystem.InputControl control) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F5
    public class StickDeadzoneProcessor : InputProcessor`1
    {
        // Fields
        public System.Single min;        // 0x10
        public System.Single max;        // 0x14

        // Methods
        private System.Single get_minOrDefault() { }
        private System.Single get_maxOrDefault() { }
        private UnityEngine.Vector2 Process(UnityEngine.Vector2 value, UnityEngine.InputSystem.InputControl control) { }
        private System.Single GetDeadZoneAdjustedValue(System.Single value) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.InputSystem.Switch
{

    // TypeToken: 0x2000126
    public class SwitchProControllerHID : Gamepad, IInputStateCallbackReceiver, IEventPreProcessor
    {
        // Fields
        private UnityEngine.InputSystem.Controls.ButtonControl <captureButton>k__BackingField;        // 0x210
        private UnityEngine.InputSystem.Controls.ButtonControl <homeButton>k__BackingField;        // 0x218
        private static readonly UnityEngine.InputSystem.Switch.SwitchProControllerHID.SwitchMagicOutputReport.CommandIdType[] s_HandshakeSequence;        // 0x0
        private System.Int32 m_HandshakeStepIndex;        // 0x220
        private System.Double m_HandshakeTimer;        // 0x228
        private static System.Byte JitterMaskLow;        // 0x0
        private static System.Byte JitterMaskHigh;        // 0x0

        // Methods
        private UnityEngine.InputSystem.Controls.ButtonControl get_captureButton() { }
        private System.Void set_captureButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_homeButton() { }
        private System.Void set_homeButton(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private System.Void OnAdded() { }
        private System.Void HandshakeRestart() { }
        private System.Void HandshakeTick() { }
        private System.Void OnNextUpdate() { }
        private System.Void OnStateEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Boolean GetStateOffsetForEvent(UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.UInt32& offset) { }
        private System.Boolean PreProcessEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000130
    public class SwitchSupportHID
    {
        // Methods
        private System.Void Initialize() { }

    }

}

namespace UnityEngine.InputSystem.Switch.LowLevel
{

    // TypeToken: 0x2000131
    public struct SwitchProControllerHIDInputState, IInputStateTypeInfo
    {
        // Fields
        public static UnityEngine.InputSystem.Utilities.FourCC Format;        // 0x0
        public System.Byte leftStickX;        // 0x10
        public System.Byte leftStickY;        // 0x11
        public System.Byte rightStickX;        // 0x12
        public System.Byte rightStickY;        // 0x13
        public System.UInt16 buttons1;        // 0x14
        public System.Byte buttons2;        // 0x16

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }
        private UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState WithButton(UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button button, System.Boolean value) { }
        private System.Void Set(UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button button, System.Boolean state) { }
        private System.Void Press(UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button button) { }
        private System.Void Release(UnityEngine.InputSystem.Switch.LowLevel.SwitchProControllerHIDInputState.Button button) { }
        private System.Void .cctor() { }

    }

}

namespace UnityEngine.InputSystem.UI
{

    // TypeToken: 0x2000112
    public class BaseInputOverride : BaseInput
    {
        // Fields
        private readonly System.String <compositionString>k__BackingField;        // 0x18

        // Methods
        private System.String get_compositionString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000113
    public class ExtendedAxisEventData : AxisEventData, INavigationEventData
    {
        // Fields
        private UnityEngine.InputSystem.InputDevice <device>k__BackingField;        // 0x30

        // Methods
        private UnityEngine.InputSystem.InputDevice get_device() { }
        private System.Void set_device(UnityEngine.InputSystem.InputDevice value) { }
        private System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000114
    public class ExtendedPointerEventData : PointerEventData
    {
        // Fields
        private UnityEngine.InputSystem.InputControl <control>k__BackingField;        // 0x160
        private UnityEngine.InputSystem.InputDevice <device>k__BackingField;        // 0x168
        private System.Int32 <touchId>k__BackingField;        // 0x170
        private UnityEngine.InputSystem.UI.UIPointerType <pointerType>k__BackingField;        // 0x174
        private System.Int32 <uiToolkitPointerId>k__BackingField;        // 0x178
        private UnityEngine.Vector3 <trackedDevicePosition>k__BackingField;        // 0x17C
        private UnityEngine.Quaternion <trackedDeviceOrientation>k__BackingField;        // 0x188

        // Methods
        private System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem) { }
        private UnityEngine.InputSystem.InputControl get_control() { }
        private System.Void set_control(UnityEngine.InputSystem.InputControl value) { }
        private UnityEngine.InputSystem.InputDevice get_device() { }
        private System.Void set_device(UnityEngine.InputSystem.InputDevice value) { }
        private System.Int32 get_touchId() { }
        private System.Void set_touchId(System.Int32 value) { }
        private UnityEngine.InputSystem.UI.UIPointerType get_pointerType() { }
        private System.Void set_pointerType(UnityEngine.InputSystem.UI.UIPointerType value) { }
        private System.Int32 get_uiToolkitPointerId() { }
        private System.Void set_uiToolkitPointerId(System.Int32 value) { }
        private UnityEngine.Vector3 get_trackedDevicePosition() { }
        private System.Void set_trackedDevicePosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_trackedDeviceOrientation() { }
        private System.Void set_trackedDeviceOrientation(UnityEngine.Quaternion value) { }
        private System.String ToString() { }
        private System.Int32 MakePointerIdForTouch(System.Int32 deviceId, System.Int32 touchId) { }
        private System.Int32 TouchIdFromPointerId(System.Int32 pointerId) { }
        private System.Void ReadDeviceState() { }
        private System.Int32 GetPenPointerId(UnityEngine.InputSystem.Pen pen) { }
        private System.Int32 GetTouchPointerId(UnityEngine.InputSystem.Controls.TouchControl touchControl) { }

    }

    // TypeToken: 0x2000115
    public struct UIPointerType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.UI.UIPointerType None;        // 0x0
        public static UnityEngine.InputSystem.UI.UIPointerType MouseOrPen;        // 0x0
        public static UnityEngine.InputSystem.UI.UIPointerType Touch;        // 0x0
        public static UnityEngine.InputSystem.UI.UIPointerType Tracked;        // 0x0

    }

    // TypeToken: 0x2000116
    public struct UIPointerBehavior
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.UI.UIPointerBehavior SingleMouseOrPenButMultiTouchAndTrack;        // 0x0
        public static UnityEngine.InputSystem.UI.UIPointerBehavior SingleUnifiedPointer;        // 0x0
        public static UnityEngine.InputSystem.UI.UIPointerBehavior AllPointersAsIs;        // 0x0

    }

    // TypeToken: 0x2000117
    public class ExtendedSubmitCancelEventData : BaseEventData, INavigationEventData
    {
        // Fields
        private UnityEngine.InputSystem.InputDevice <device>k__BackingField;        // 0x20

        // Methods
        private UnityEngine.InputSystem.InputDevice get_device() { }
        private System.Void set_device(UnityEngine.InputSystem.InputDevice value) { }
        private System.Void .ctor(UnityEngine.EventSystems.EventSystem eventSystem) { }

    }

    // TypeToken: 0x2000118
    public interface INavigationEventData
    {
        // Methods
        private UnityEngine.InputSystem.InputDevice get_device() { }

    }

    // TypeToken: 0x2000119
    public class InputSystemUIInputModule : BaseInputModule
    {
        // Fields
        private static System.Single kClickSpeed;        // 0x0
        private System.Single m_MoveRepeatDelay;        // 0x48
        private System.Single m_MoveRepeatRate;        // 0x4C
        private System.Single m_TrackedDeviceDragThresholdMultiplier;        // 0x50
        private UnityEngine.Transform m_XRTrackingOrigin;        // 0x58
        private static UnityEngine.InputSystem.DefaultInputActions defaultActions;        // 0x0
        private UnityEngine.InputSystem.InputActionAsset m_ActionsAsset;        // 0x60
        private UnityEngine.InputSystem.InputActionReference m_PointAction;        // 0x68
        private UnityEngine.InputSystem.InputActionReference m_MoveAction;        // 0x70
        private UnityEngine.InputSystem.InputActionReference m_SubmitAction;        // 0x78
        private UnityEngine.InputSystem.InputActionReference m_CancelAction;        // 0x80
        private UnityEngine.InputSystem.InputActionReference m_LeftClickAction;        // 0x88
        private UnityEngine.InputSystem.InputActionReference m_MiddleClickAction;        // 0x90
        private UnityEngine.InputSystem.InputActionReference m_RightClickAction;        // 0x98
        private UnityEngine.InputSystem.InputActionReference m_ScrollWheelAction;        // 0xA0
        private UnityEngine.InputSystem.InputActionReference m_TrackedDevicePositionAction;        // 0xA8
        private UnityEngine.InputSystem.InputActionReference m_TrackedDeviceOrientationAction;        // 0xB0
        private System.Boolean m_DeselectOnBackgroundClick;        // 0xB8
        private UnityEngine.InputSystem.UI.UIPointerBehavior m_PointerBehavior;        // 0xBC
        private UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehavior m_CursorLockBehavior;        // 0xC0
        private System.Single m_ScrollDeltaPerTick;        // 0xC4
        private static System.Collections.Generic.Dictionary<UnityEngine.InputSystem.InputAction,UnityEngine.InputSystem.UI.InputSystemUIInputModule.InputActionReferenceState> s_InputActionReferenceCounts;        // 0x8
        private System.Boolean m_ActionsHooked;        // 0xC8
        private System.Boolean m_NeedToPurgeStalePointers;        // 0xC9
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnPointDelegate;        // 0xD0
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnMoveDelegate;        // 0xD8
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnSubmitCancelDelegate;        // 0xE0
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnLeftClickDelegate;        // 0xE8
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnRightClickDelegate;        // 0xF0
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnMiddleClickDelegate;        // 0xF8
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnScrollWheelDelegate;        // 0x100
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnTrackedDevicePositionDelegate;        // 0x108
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_OnTrackedDeviceOrientationDelegate;        // 0x110
        private System.Action<System.Object> m_OnControlsChangedDelegate;        // 0x118
        private System.Int32 m_CurrentPointerId;        // 0x120
        private System.Int32 m_CurrentPointerIndex;        // 0x124
        private UnityEngine.InputSystem.UI.UIPointerType m_CurrentPointerType;        // 0x128
        private UnityEngine.InputSystem.Utilities.InlinedArray<System.Int32> m_PointerIds;        // 0x130
        private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.UI.PointerModel> m_PointerStates;        // 0x140
        private UnityEngine.InputSystem.UI.NavigationModel m_NavigationState;        // 0x358
        private UnityEngine.InputSystem.UI.SubmitCancelModel m_SubmitCancelState;        // 0x380
        private UnityEngine.GameObject m_LocalMultiPlayerRoot;        // 0x390

        // Methods
        private System.Boolean get_deselectOnBackgroundClick() { }
        private System.Void set_deselectOnBackgroundClick(System.Boolean value) { }
        private UnityEngine.InputSystem.UI.UIPointerBehavior get_pointerBehavior() { }
        private System.Void set_pointerBehavior(UnityEngine.InputSystem.UI.UIPointerBehavior value) { }
        private UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehavior get_cursorLockBehavior() { }
        private System.Void set_cursorLockBehavior(UnityEngine.InputSystem.UI.InputSystemUIInputModule.CursorLockBehavior value) { }
        private UnityEngine.GameObject get_localMultiPlayerRoot() { }
        private System.Void set_localMultiPlayerRoot(UnityEngine.GameObject value) { }
        private System.Single get_scrollDeltaPerTick() { }
        private System.Void set_scrollDeltaPerTick(System.Single value) { }
        private System.Void ActivateModule() { }
        private System.Boolean IsPointerOverGameObject(System.Int32 pointerOrTouchId) { }
        private UnityEngine.EventSystems.RaycastResult GetLastRaycastResult(System.Int32 pointerOrTouchId) { }
        private UnityEngine.EventSystems.RaycastResult PerformRaycast(UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData) { }
        private System.Void ProcessPointer(UnityEngine.InputSystem.UI.PointerModel& state) { }
        private System.Boolean PointerShouldIgnoreTransform(UnityEngine.Transform t) { }
        private System.Void ProcessPointerMovement(UnityEngine.InputSystem.UI.PointerModel& pointer, UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData) { }
        private System.Void ProcessPointerMovement(UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData, UnityEngine.GameObject currentPointerTarget) { }
        private System.Void ProcessPointerButton(UnityEngine.InputSystem.UI.PointerModel.ButtonState& button, UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void ProcessPointerButtonDrag(UnityEngine.InputSystem.UI.PointerModel.ButtonState& button, UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData) { }
        private System.Void ProcessPointerScroll(UnityEngine.InputSystem.UI.PointerModel& pointer, UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void ProcessNavigation(UnityEngine.InputSystem.UI.NavigationModel& navigationState) { }
        private System.Boolean IsMoveAllowed(UnityEngine.EventSystems.AxisEventData eventData) { }
        private System.Single get_moveRepeatDelay() { }
        private System.Void set_moveRepeatDelay(System.Single value) { }
        private System.Single get_moveRepeatRate() { }
        private System.Void set_moveRepeatRate(System.Single value) { }
        private System.Boolean get_explictlyIgnoreFocus() { }
        private System.Boolean get_shouldIgnoreFocus() { }
        private System.Single get_repeatRate() { }
        private System.Void set_repeatRate(System.Single value) { }
        private System.Single get_repeatDelay() { }
        private System.Void set_repeatDelay(System.Single value) { }
        private UnityEngine.Transform get_xrTrackingOrigin() { }
        private System.Void set_xrTrackingOrigin(UnityEngine.Transform value) { }
        private System.Single get_trackedDeviceDragThresholdMultiplier() { }
        private System.Void set_trackedDeviceDragThresholdMultiplier(System.Single value) { }
        private System.Void SwapAction(UnityEngine.InputSystem.InputActionReference& property, UnityEngine.InputSystem.InputActionReference newValue, System.Boolean actionsHooked, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> actionCallback) { }
        private UnityEngine.InputSystem.InputActionReference get_point() { }
        private System.Void set_point(UnityEngine.InputSystem.InputActionReference value) { }
        private UnityEngine.InputSystem.InputActionReference get_scrollWheel() { }
        private System.Void set_scrollWheel(UnityEngine.InputSystem.InputActionReference value) { }
        private UnityEngine.InputSystem.InputActionReference get_leftClick() { }
        private System.Void set_leftClick(UnityEngine.InputSystem.InputActionReference value) { }
        private UnityEngine.InputSystem.InputActionReference get_middleClick() { }
        private System.Void set_middleClick(UnityEngine.InputSystem.InputActionReference value) { }
        private UnityEngine.InputSystem.InputActionReference get_rightClick() { }
        private System.Void set_rightClick(UnityEngine.InputSystem.InputActionReference value) { }
        private UnityEngine.InputSystem.InputActionReference get_move() { }
        private System.Void set_move(UnityEngine.InputSystem.InputActionReference value) { }
        private UnityEngine.InputSystem.InputActionReference get_submit() { }
        private System.Void set_submit(UnityEngine.InputSystem.InputActionReference value) { }
        private UnityEngine.InputSystem.InputActionReference get_cancel() { }
        private System.Void set_cancel(UnityEngine.InputSystem.InputActionReference value) { }
        private UnityEngine.InputSystem.InputActionReference get_trackedDeviceOrientation() { }
        private System.Void set_trackedDeviceOrientation(UnityEngine.InputSystem.InputActionReference value) { }
        private UnityEngine.InputSystem.InputActionReference get_trackedDevicePosition() { }
        private System.Void set_trackedDevicePosition(UnityEngine.InputSystem.InputActionReference value) { }
        private System.Void AssignDefaultActions() { }
        private System.Void UnassignActions() { }
        private UnityEngine.InputSystem.InputActionReference get_trackedDeviceSelect() { }
        private System.Void set_trackedDeviceSelect(UnityEngine.InputSystem.InputActionReference value) { }
        private System.Void Awake() { }
        private System.Void OnDestroy() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void ResetPointers() { }
        private System.Boolean HasNoActions() { }
        private System.Void EnableAllActions() { }
        private System.Void DisableAllActions() { }
        private System.Void EnableInputAction(UnityEngine.InputSystem.InputActionReference inputActionReference) { }
        private System.Void TryDisableInputAction(UnityEngine.InputSystem.InputActionReference inputActionReference, System.Boolean isComponentDisabling) { }
        private System.Int32 GetPointerStateIndexFor(System.Int32 pointerOrTouchId) { }
        private UnityEngine.InputSystem.UI.PointerModel& GetPointerStateForIndex(System.Int32 index) { }
        private System.Int32 GetDisplayIndexFor(UnityEngine.InputSystem.InputControl control) { }
        private System.Int32 GetPointerStateIndexFor(UnityEngine.InputSystem.InputAction.CallbackContext& context) { }
        private System.Int32 GetPointerStateIndexFor(UnityEngine.InputSystem.InputControl control, System.Boolean createIfNotExists) { }
        private System.Int32 AllocatePointer(System.Int32 pointerId, System.Int32 displayIndex, System.Int32 touchId, UnityEngine.InputSystem.UI.UIPointerType pointerType, UnityEngine.InputSystem.InputControl control, UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputControl touchControl) { }
        private System.Boolean SendPointerExitEventsAndRemovePointer(System.Int32 index) { }
        private System.Boolean RemovePointerAtIndex(System.Int32 index) { }
        private System.Void PurgeStalePointers() { }
        private System.Boolean HaveControlForDevice(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputActionReference actionReference) { }
        private System.Void OnPointCallback(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Boolean IgnoreNextClick(UnityEngine.InputSystem.InputAction.CallbackContext& context, System.Boolean wasPressed) { }
        private System.Void OnLeftClickCallback(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnRightClickCallback(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnMiddleClickCallback(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Boolean CheckForRemovedDevice(UnityEngine.InputSystem.InputAction.CallbackContext& context) { }
        private System.Void OnScrollCallback(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnMoveCallback(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnSubmitCancelCallback(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnTrackedDeviceOrientationCallback(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnTrackedDevicePositionCallback(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnControlsChanged(System.Object obj) { }
        private System.Void FilterPointerStatesByType() { }
        private System.Void Process() { }
        private System.Int32 ConvertUIToolkitPointerId(UnityEngine.EventSystems.PointerEventData sourcePointerData) { }
        private System.Void HookActions() { }
        private System.Void UnhookActions() { }
        private System.Void SetActionCallbacks(System.Boolean install) { }
        private System.Void SetActionCallback(UnityEngine.InputSystem.InputActionReference actionReference, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, System.Boolean install) { }
        private UnityEngine.InputSystem.InputActionReference UpdateReferenceForNewAsset(UnityEngine.InputSystem.InputActionReference actionReference) { }
        private UnityEngine.InputSystem.InputActionAsset get_actionsAsset() { }
        private System.Void set_actionsAsset(UnityEngine.InputSystem.InputActionAsset value) { }
        private System.Boolean get_sendPointerHoverToParent() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200011C
    public class MultiplayerEventSystem : EventSystem
    {
        // Fields
        private UnityEngine.GameObject m_PlayerRoot;        // 0x50

        // Methods
        private UnityEngine.GameObject get_playerRoot() { }
        private System.Void set_playerRoot(UnityEngine.GameObject value) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void InitializePlayerRoot() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011D
    public struct NavigationModel
    {
        // Fields
        public UnityEngine.Vector2 move;        // 0x10
        public System.Int32 consecutiveMoveCount;        // 0x18
        public UnityEngine.EventSystems.MoveDirection lastMoveDirection;        // 0x1C
        public System.Single lastMoveTime;        // 0x20
        public UnityEngine.EventSystems.AxisEventData eventData;        // 0x28
        public UnityEngine.InputSystem.InputDevice device;        // 0x30

        // Methods
        private System.Void Reset() { }

    }

    // TypeToken: 0x200011E
    public struct SubmitCancelModel
    {
        // Fields
        public UnityEngine.EventSystems.BaseEventData eventData;        // 0x10
        public UnityEngine.InputSystem.InputDevice device;        // 0x18

    }

    // TypeToken: 0x200011F
    public struct PointerModel
    {
        // Fields
        public System.Boolean changedThisFrame;        // 0x10
        public UnityEngine.InputSystem.UI.PointerModel.ButtonState leftButton;        // 0x18
        public UnityEngine.InputSystem.UI.PointerModel.ButtonState rightButton;        // 0xA8
        public UnityEngine.InputSystem.UI.PointerModel.ButtonState middleButton;        // 0x138
        public UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData;        // 0x1C8
        private UnityEngine.Vector2 m_ScreenPosition;        // 0x1D0
        private UnityEngine.Vector2 m_ScrollDelta;        // 0x1D8
        private UnityEngine.Vector3 m_WorldPosition;        // 0x1E0
        private UnityEngine.Quaternion m_WorldOrientation;        // 0x1EC
        private System.Single m_Pressure;        // 0x1FC
        private System.Single m_AzimuthAngle;        // 0x200
        private System.Single m_AltitudeAngle;        // 0x204
        private System.Single m_Twist;        // 0x208
        private UnityEngine.Vector2 m_Radius;        // 0x20C

        // Methods
        private UnityEngine.InputSystem.UI.UIPointerType get_pointerType() { }
        private UnityEngine.Vector2 get_screenPosition() { }
        private System.Void set_screenPosition(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector3 get_worldPosition() { }
        private System.Void set_worldPosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_worldOrientation() { }
        private System.Void set_worldOrientation(UnityEngine.Quaternion value) { }
        private UnityEngine.Vector2 get_scrollDelta() { }
        private System.Void set_scrollDelta(UnityEngine.Vector2 value) { }
        private System.Single get_pressure() { }
        private System.Void set_pressure(System.Single value) { }
        private System.Single get_azimuthAngle() { }
        private System.Void set_azimuthAngle(System.Single value) { }
        private System.Single get_altitudeAngle() { }
        private System.Void set_altitudeAngle(System.Single value) { }
        private System.Single get_twist() { }
        private System.Void set_twist(System.Single value) { }
        private UnityEngine.Vector2 get_radius() { }
        private System.Void set_radius(UnityEngine.Vector2 value) { }
        private System.Void .ctor(UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData) { }
        private System.Void OnFrameFinished() { }
        private System.Void CopyTouchOrPenStateFrom(UnityEngine.EventSystems.PointerEventData eventData) { }

    }

    // TypeToken: 0x2000121
    public class TrackedDeviceRaycaster : BaseRaycaster
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> m_RaycastResultsCache;        // 0x20
        private static UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster> s_Instances;        // 0x0
        private static readonly System.Collections.Generic.List<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> s_SortedGraphics;        // 0x18
        private System.Boolean m_IgnoreReversedGraphics;        // 0x28
        private System.Boolean m_CheckFor2DOcclusion;        // 0x29
        private System.Boolean m_CheckFor3DOcclusion;        // 0x2A
        private System.Single m_MaxDistance;        // 0x2C
        private UnityEngine.LayerMask m_BlockingMask;        // 0x30
        private UnityEngine.Canvas m_Canvas;        // 0x38

        // Methods
        private UnityEngine.Camera get_eventCamera() { }
        private UnityEngine.LayerMask get_blockingMask() { }
        private System.Void set_blockingMask(UnityEngine.LayerMask value) { }
        private System.Boolean get_checkFor3DOcclusion() { }
        private System.Void set_checkFor3DOcclusion(System.Boolean value) { }
        private System.Boolean get_checkFor2DOcclusion() { }
        private System.Void set_checkFor2DOcclusion(System.Boolean value) { }
        private System.Boolean get_ignoreReversedGraphics() { }
        private System.Void set_ignoreReversedGraphics(System.Boolean value) { }
        private System.Single get_maxDistance() { }
        private System.Void set_maxDistance(System.Single value) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }
        private System.Void PerformRaycast(UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList) { }
        private System.Void SortedRaycastGraphics(UnityEngine.Canvas canvas, UnityEngine.Ray ray, System.Collections.Generic.List<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster.RaycastHitData> results) { }
        private System.Boolean RayIntersectsRectTransform(UnityEngine.RectTransform transform, UnityEngine.Ray ray, UnityEngine.Vector3& worldPosition, System.Single& distance) { }
        private UnityEngine.Canvas get_canvas() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000124
    public class VirtualMouseInput : MonoBehaviour
    {
        // Fields
        private UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode m_CursorMode;        // 0x18
        private UnityEngine.UI.Graphic m_CursorGraphic;        // 0x20
        private UnityEngine.RectTransform m_CursorTransform;        // 0x28
        private System.Single m_CursorSpeed;        // 0x30
        private System.Single m_ScrollSpeed;        // 0x34
        private UnityEngine.InputSystem.InputActionProperty m_StickAction;        // 0x38
        private UnityEngine.InputSystem.InputActionProperty m_LeftButtonAction;        // 0x50
        private UnityEngine.InputSystem.InputActionProperty m_MiddleButtonAction;        // 0x68
        private UnityEngine.InputSystem.InputActionProperty m_RightButtonAction;        // 0x80
        private UnityEngine.InputSystem.InputActionProperty m_ForwardButtonAction;        // 0x98
        private UnityEngine.InputSystem.InputActionProperty m_BackButtonAction;        // 0xB0
        private UnityEngine.InputSystem.InputActionProperty m_ScrollWheelAction;        // 0xC8
        private UnityEngine.Canvas m_Canvas;        // 0xE0
        private UnityEngine.InputSystem.Mouse m_VirtualMouse;        // 0xE8
        private UnityEngine.InputSystem.Mouse m_SystemMouse;        // 0xF0
        private System.Action m_AfterInputUpdateDelegate;        // 0xF8
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_ButtonActionTriggeredDelegate;        // 0x100
        private System.Double m_LastTime;        // 0x108
        private UnityEngine.Vector2 m_LastStickValue;        // 0x110

        // Methods
        private UnityEngine.RectTransform get_cursorTransform() { }
        private System.Void set_cursorTransform(UnityEngine.RectTransform value) { }
        private System.Single get_cursorSpeed() { }
        private System.Void set_cursorSpeed(System.Single value) { }
        private UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode get_cursorMode() { }
        private System.Void set_cursorMode(UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode value) { }
        private UnityEngine.UI.Graphic get_cursorGraphic() { }
        private System.Void set_cursorGraphic(UnityEngine.UI.Graphic value) { }
        private System.Single get_scrollSpeed() { }
        private System.Void set_scrollSpeed(System.Single value) { }
        private UnityEngine.InputSystem.Mouse get_virtualMouse() { }
        private UnityEngine.InputSystem.InputActionProperty get_stickAction() { }
        private System.Void set_stickAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_leftButtonAction() { }
        private System.Void set_leftButtonAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_rightButtonAction() { }
        private System.Void set_rightButtonAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_middleButtonAction() { }
        private System.Void set_middleButtonAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_forwardButtonAction() { }
        private System.Void set_forwardButtonAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_backButtonAction() { }
        private System.Void set_backButtonAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_scrollWheelAction() { }
        private System.Void set_scrollWheelAction(UnityEngine.InputSystem.InputActionProperty value) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void TryFindCanvas() { }
        private System.Void TryEnableHardwareCursor() { }
        private System.Void UpdateMotion() { }
        private System.Void OnButtonActionTriggered(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void SetActionCallback(UnityEngine.InputSystem.InputActionProperty field, System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> callback, System.Boolean install) { }
        private System.Void SetAction(UnityEngine.InputSystem.InputActionProperty& field, UnityEngine.InputSystem.InputActionProperty value) { }
        private System.Void OnAfterInputUpdate() { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.InputSystem.Users
{

    // TypeToken: 0x2000106
    public struct InputUser, IEquatable`1
    {
        // Fields
        public static System.UInt32 InvalidId;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker k_InputUserOnChangeMarker;        // 0x0
        private static readonly Unity.Profiling.ProfilerMarker k_InputCheckForUnpairMarker;        // 0x8
        private System.UInt32 m_Id;        // 0x10
        private static UnityEngine.InputSystem.Users.InputUser.GlobalState s_GlobalState;        // 0x10

        // Methods
        private System.Boolean get_valid() { }
        private System.Int32 get_index() { }
        private System.UInt32 get_id() { }
        private System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle> get_platformUserAccountHandle() { }
        private System.String get_platformUserAccountName() { }
        private System.String get_platformUserAccountId() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_pairedDevices() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice> get_lostDevices() { }
        private UnityEngine.InputSystem.IInputActionCollection get_actions() { }
        private System.Nullable<UnityEngine.InputSystem.InputControlScheme> get_controlScheme() { }
        private UnityEngine.InputSystem.InputControlScheme.MatchResult get_controlSchemeMatch() { }
        private System.Boolean get_hasMissingRequiredDevices() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Users.InputUser> get_all() { }
        private System.Void add_onChange(System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice> value) { }
        private System.Void remove_onChange(System.Action<UnityEngine.InputSystem.Users.InputUser,UnityEngine.InputSystem.Users.InputUserChange,UnityEngine.InputSystem.InputDevice> value) { }
        private System.Void add_onUnpairedDeviceUsed(System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }
        private System.Void remove_onUnpairedDeviceUsed(System.Action<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> value) { }
        private System.Void add_onPrefilterUnpairedDeviceActivity(System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value) { }
        private System.Void remove_onPrefilterUnpairedDeviceActivity(System.Func<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,System.Boolean> value) { }
        private System.Int32 get_listenForUnpairedDeviceActivity() { }
        private System.Void set_listenForUnpairedDeviceActivity(System.Int32 value) { }
        private System.String ToString() { }
        private System.Void AssociateActionsWithUser(UnityEngine.InputSystem.IInputActionCollection actions) { }
        private UnityEngine.InputSystem.Users.InputUser.ControlSchemeChangeSyntax ActivateControlScheme(System.String schemeName) { }
        private System.Boolean TryFindControlScheme(System.String schemeName, UnityEngine.InputSystem.InputControlScheme& scheme) { }
        private System.Void FindControlScheme(System.String schemeName, UnityEngine.InputSystem.InputControlScheme& scheme) { }
        private UnityEngine.InputSystem.Users.InputUser.ControlSchemeChangeSyntax ActivateControlScheme(UnityEngine.InputSystem.InputControlScheme scheme) { }
        private System.Void ActivateControlSchemeInternal(System.Int32 userIndex, UnityEngine.InputSystem.InputControlScheme scheme) { }
        private System.Void UnpairDevice(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void UnpairDevices() { }
        private System.Void RemoveLostDevicesForUser(System.Int32 userIndex) { }
        private System.Void UnpairDevicesAndRemoveUser() { }
        private UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> GetUnpairedInputDevices() { }
        private System.Int32 GetUnpairedInputDevices(UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice>& list) { }
        private System.Nullable<UnityEngine.InputSystem.Users.InputUser> FindUserPairedToDevice(UnityEngine.InputSystem.InputDevice device) { }
        private System.Nullable<UnityEngine.InputSystem.Users.InputUser> FindUserByAccount(UnityEngine.InputSystem.Users.InputUserAccountHandle platformUserAccountHandle) { }
        private UnityEngine.InputSystem.Users.InputUser CreateUserWithoutPairedDevices() { }
        private UnityEngine.InputSystem.Users.InputUser PerformPairingWithDevice(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Users.InputUser user, UnityEngine.InputSystem.Users.InputUserPairingOptions options) { }
        private System.Boolean InitiateUserAccountSelection(System.Int32 userIndex, UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.Users.InputUserPairingOptions options) { }
        private System.Boolean Equals(UnityEngine.InputSystem.Users.InputUser other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.Users.InputUser left, UnityEngine.InputSystem.Users.InputUser right) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.Users.InputUser left, UnityEngine.InputSystem.Users.InputUser right) { }
        private System.Int32 AddUser() { }
        private System.Void RemoveUser(System.Int32 userIndex) { }
        private System.Void Notify(System.Int32 userIndex, UnityEngine.InputSystem.Users.InputUserChange change, UnityEngine.InputSystem.InputDevice device) { }
        private System.Int32 TryFindUserIndex(System.UInt32 userId) { }
        private System.Int32 TryFindUserIndex(UnityEngine.InputSystem.Users.InputUserAccountHandle platformHandle) { }
        private System.Int32 TryFindUserIndex(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void AddDeviceToUser(System.Int32 userIndex, UnityEngine.InputSystem.InputDevice device, System.Boolean asLostDevice, System.Boolean dontUpdateControlScheme) { }
        private System.Void RemoveDeviceFromUser(System.Int32 userIndex, UnityEngine.InputSystem.InputDevice device, System.Boolean asLostDevice) { }
        private System.Void UpdateControlSchemeMatch(System.Int32 userIndex, System.Boolean autoPairMissing) { }
        private System.Int64 UpdatePlatformUserAccount(System.Int32 userIndex, UnityEngine.InputSystem.InputDevice device) { }
        private System.Int64 QueryPairedPlatformUserAccount(UnityEngine.InputSystem.InputDevice device, System.Nullable<UnityEngine.InputSystem.Users.InputUserAccountHandle>& platformAccountHandle, System.String& platformAccountName, System.String& platformAccountId) { }
        private System.Boolean InitiateUserAccountSelectionAtPlatformLevel(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void OnActionChange(System.Object obj, UnityEngine.InputSystem.InputActionChange change) { }
        private System.Void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, UnityEngine.InputSystem.InputDeviceChange change) { }
        private System.Int32 FindLostDevice(UnityEngine.InputSystem.InputDevice device, System.Int32 startIndex) { }
        private System.Void OnEvent(UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, UnityEngine.InputSystem.InputDevice device) { }
        private UnityEngine.InputSystem.Utilities.ISavedState SaveAndResetState() { }
        private System.Void HookIntoActionChange() { }
        private System.Void UnhookFromActionChange() { }
        private System.Void HookIntoDeviceChange() { }
        private System.Void UnhookFromDeviceChange() { }
        private System.Void HookIntoEvents() { }
        private System.Void UnhookFromDeviceStateChange() { }
        private System.Void DisposeAndResetGlobalState() { }
        private System.Void ResetGlobals() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200010E
    public struct InputUserAccountHandle, IEquatable`1
    {
        // Fields
        private System.String m_ApiName;        // 0x10
        private System.UInt64 m_Handle;        // 0x18

        // Methods
        private System.String get_apiName() { }
        private System.UInt64 get_handle() { }
        private System.Void .ctor(System.String apiName, System.UInt64 handle) { }
        private System.String ToString() { }
        private System.Boolean Equals(UnityEngine.InputSystem.Users.InputUserAccountHandle other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.Users.InputUserAccountHandle left, UnityEngine.InputSystem.Users.InputUserAccountHandle right) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.Users.InputUserAccountHandle left, UnityEngine.InputSystem.Users.InputUserAccountHandle right) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x200010F
    public struct InputUserChange
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Users.InputUserChange Added;        // 0x0
        public static UnityEngine.InputSystem.Users.InputUserChange Removed;        // 0x0
        public static UnityEngine.InputSystem.Users.InputUserChange DevicePaired;        // 0x0
        public static UnityEngine.InputSystem.Users.InputUserChange DeviceUnpaired;        // 0x0
        public static UnityEngine.InputSystem.Users.InputUserChange DeviceLost;        // 0x0
        public static UnityEngine.InputSystem.Users.InputUserChange DeviceRegained;        // 0x0
        public static UnityEngine.InputSystem.Users.InputUserChange AccountChanged;        // 0x0
        public static UnityEngine.InputSystem.Users.InputUserChange AccountNameChanged;        // 0x0
        public static UnityEngine.InputSystem.Users.InputUserChange AccountSelectionInProgress;        // 0x0
        public static UnityEngine.InputSystem.Users.InputUserChange AccountSelectionCanceled;        // 0x0
        public static UnityEngine.InputSystem.Users.InputUserChange AccountSelectionComplete;        // 0x0
        public static UnityEngine.InputSystem.Users.InputUserChange ControlSchemeChanged;        // 0x0
        public static UnityEngine.InputSystem.Users.InputUserChange ControlsChanged;        // 0x0

    }

    // TypeToken: 0x2000110
    public struct InputUserPairingOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.Users.InputUserPairingOptions None;        // 0x0
        public static UnityEngine.InputSystem.Users.InputUserPairingOptions ForcePlatformUserAccountSelection;        // 0x0
        public static UnityEngine.InputSystem.Users.InputUserPairingOptions ForceNoPlatformUserAccountSelection;        // 0x0
        public static UnityEngine.InputSystem.Users.InputUserPairingOptions UnpairCurrentDevicesFromUser;        // 0x0

    }

    // TypeToken: 0x2000111
    public class InputUserSettings
    {
        // Fields
        private System.String <customBindings>k__BackingField;        // 0x10
        private System.Boolean <invertMouseX>k__BackingField;        // 0x18
        private System.Boolean <invertMouseY>k__BackingField;        // 0x19
        private System.Nullable<System.Single> <mouseSmoothing>k__BackingField;        // 0x1C
        private System.Nullable<System.Single> <mouseSensitivity>k__BackingField;        // 0x24
        private System.Boolean <invertStickX>k__BackingField;        // 0x2C
        private System.Boolean <invertStickY>k__BackingField;        // 0x2D
        private System.Boolean <swapSticks>k__BackingField;        // 0x2E
        private System.Boolean <swapBumpers>k__BackingField;        // 0x2F
        private System.Boolean <swapTriggers>k__BackingField;        // 0x30
        private System.Boolean <swapDpadAndLeftStick>k__BackingField;        // 0x31
        private System.Single <vibrationStrength>k__BackingField;        // 0x34
        private System.String m_CustomBindings;        // 0x38

        // Methods
        private System.String get_customBindings() { }
        private System.Void set_customBindings(System.String value) { }
        private System.Boolean get_invertMouseX() { }
        private System.Void set_invertMouseX(System.Boolean value) { }
        private System.Boolean get_invertMouseY() { }
        private System.Void set_invertMouseY(System.Boolean value) { }
        private System.Nullable<System.Single> get_mouseSmoothing() { }
        private System.Void set_mouseSmoothing(System.Nullable<System.Single> value) { }
        private System.Nullable<System.Single> get_mouseSensitivity() { }
        private System.Void set_mouseSensitivity(System.Nullable<System.Single> value) { }
        private System.Boolean get_invertStickX() { }
        private System.Void set_invertStickX(System.Boolean value) { }
        private System.Boolean get_invertStickY() { }
        private System.Void set_invertStickY(System.Boolean value) { }
        private System.Boolean get_swapSticks() { }
        private System.Void set_swapSticks(System.Boolean value) { }
        private System.Boolean get_swapBumpers() { }
        private System.Void set_swapBumpers(System.Boolean value) { }
        private System.Boolean get_swapTriggers() { }
        private System.Void set_swapTriggers(System.Boolean value) { }
        private System.Boolean get_swapDpadAndLeftStick() { }
        private System.Void set_swapDpadAndLeftStick(System.Boolean value) { }
        private System.Single get_vibrationStrength() { }
        private System.Void set_vibrationStrength(System.Single value) { }
        private System.Void Apply(UnityEngine.InputSystem.IInputActionCollection actions) { }
        private System.Void .ctor() { }

    }

}

namespace UnityEngine.InputSystem.Utilities
{

    // TypeToken: 0x2000231
    public class InputActionTrace, IEnumerable`1, IEnumerable, IDisposable
    {
        // Fields
        private System.Boolean m_SubscribedToAll;        // 0x10
        private System.Boolean m_OnActionChangeHooked;        // 0x11
        private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputAction> m_SubscribedActions;        // 0x18
        private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputActionMap> m_SubscribedActionMaps;        // 0x30
        private UnityEngine.InputSystem.LowLevel.InputEventBuffer m_EventBuffer;        // 0x48
        private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputActionState> m_ActionMapStates;        // 0x68
        private UnityEngine.InputSystem.Utilities.InlinedArray<UnityEngine.InputSystem.InputActionState> m_ActionMapStateClones;        // 0x80
        private System.Action<UnityEngine.InputSystem.InputAction.CallbackContext> m_CallbackDelegate;        // 0x98
        private System.Action<System.Object,UnityEngine.InputSystem.InputActionChange> m_ActionChangeDelegate;        // 0xA0

        // Methods
        private UnityEngine.InputSystem.LowLevel.InputEventBuffer get_buffer() { }
        private System.Int32 get_count() { }
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.InputSystem.InputAction action) { }
        private System.Void .ctor(UnityEngine.InputSystem.InputActionMap actionMap) { }
        private System.Void SubscribeToAll() { }
        private System.Void UnsubscribeFromAll() { }
        private System.Void SubscribeTo(UnityEngine.InputSystem.InputAction action) { }
        private System.Void SubscribeTo(UnityEngine.InputSystem.InputActionMap actionMap) { }
        private System.Void UnsubscribeFrom(UnityEngine.InputSystem.InputAction action) { }
        private System.Void UnsubscribeFrom(UnityEngine.InputSystem.InputActionMap actionMap) { }
        private System.Void RecordAction(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void Clear() { }
        private System.Void Finalize() { }
        private System.String ToString() { }
        private System.Void Dispose() { }
        private System.Void DisposeInternal() { }
        private System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InputActionTrace.ActionEventPtr> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void HookOnActionChange() { }
        private System.Void UnhookOnActionChange() { }
        private System.Void OnActionChange(System.Object actionOrMapOrAsset, UnityEngine.InputSystem.InputActionChange change) { }
        private System.Void CloneActionStateBeforeBindingsChange(UnityEngine.InputSystem.InputActionMap actionMap) { }

    }

    // TypeToken: 0x2000234
    public class ArrayHelpers
    {
        // Methods
        private System.Int32 LengthSafe(TValue[] array) { }
        private System.Void Clear(TValue[] array) { }
        private System.Void Clear(TValue[] array, System.Int32 count) { }
        private System.Void Clear(TValue[] array, System.Int32& count) { }
        private System.Void EnsureCapacity(TValue[]& array, System.Int32 count, System.Int32 capacity, System.Int32 capacityIncrement) { }
        private System.Void DuplicateWithCapacity(TValue[]& array, System.Int32 count, System.Int32 capacity, System.Int32 capacityIncrement) { }
        private System.Boolean Contains(TValue[] array, TValue value) { }
        private System.Boolean ContainsReference(TValue[] array, TValue value) { }
        private System.Boolean ContainsReference(TFirst[] array, System.Int32 count, TSecond value) { }
        private System.Boolean ContainsReference(TFirst[] array, System.Int32 startIndex, System.Int32 count, TSecond value) { }
        private System.Boolean HaveDuplicateReferences(TFirst[] first, System.Int32 index, System.Int32 count) { }
        private System.Boolean HaveEqualElements(TValue[] first, TValue[] second, System.Int32 count) { }
        private System.Int32 IndexOf(TValue[] array, TValue value, System.Int32 startIndex, System.Int32 count) { }
        private System.Int32 IndexOf(TValue[] array, System.Predicate<TValue> predicate) { }
        private System.Int32 IndexOf(TValue[] array, System.Predicate<TValue> predicate, System.Int32 startIndex, System.Int32 count) { }
        private System.Int32 IndexOfReference(TFirst[] array, TSecond value, System.Int32 count) { }
        private System.Int32 IndexOfReference(TFirst[] array, TSecond value, System.Int32 startIndex, System.Int32 count) { }
        private System.Int32 IndexOfValue(TValue[] array, TValue value, System.Int32 startIndex, System.Int32 count) { }
        private System.Void Resize(Unity.Collections.NativeArray<TValue>& array, System.Int32 newSize, Unity.Collections.Allocator allocator) { }
        private System.Int32 Append(TValue[]& array, TValue value) { }
        private System.Int32 Append(TValue[]& array, System.Collections.Generic.IEnumerable<TValue> values) { }
        private System.Int32 AppendToImmutable(TValue[]& array, TValue[] values) { }
        private System.Int32 AppendWithCapacity(TValue[]& array, System.Int32& count, TValue value, System.Int32 capacityIncrement) { }
        private System.Int32 AppendListWithCapacity(TValue[]& array, System.Int32& length, TValues values, System.Int32 capacityIncrement) { }
        private System.Int32 AppendWithCapacity(Unity.Collections.NativeArray<TValue>& array, System.Int32& count, TValue value, System.Int32 capacityIncrement, Unity.Collections.Allocator allocator) { }
        private System.Void InsertAt(TValue[]& array, System.Int32 index, TValue value) { }
        private System.Void InsertAtWithCapacity(TValue[]& array, System.Int32& count, System.Int32 index, TValue value, System.Int32 capacityIncrement) { }
        private System.Void PutAtIfNotSet(TValue[]& array, System.Int32 index, System.Func<TValue> valueFn) { }
        private System.Int32 GrowBy(TValue[]& array, System.Int32 count) { }
        private System.Int32 GrowBy(Unity.Collections.NativeArray<TValue>& array, System.Int32 count, Unity.Collections.Allocator allocator) { }
        private System.Int32 GrowWithCapacity(TValue[]& array, System.Int32& count, System.Int32 growBy, System.Int32 capacityIncrement) { }
        private System.Int32 GrowWithCapacity(Unity.Collections.NativeArray<TValue>& array, System.Int32& count, System.Int32 growBy, System.Int32 capacityIncrement, Unity.Collections.Allocator allocator) { }
        private TValue[] Join(TValue value, TValue[] values) { }
        private TValue[] Merge(TValue[] first, TValue[] second) { }
        private TValue[] Merge(TValue[] first, TValue[] second, System.Collections.Generic.IEqualityComparer<TValue> comparer) { }
        private System.Void EraseAt(TValue[]& array, System.Int32 index) { }
        private System.Void EraseAtWithCapacity(TValue[] array, System.Int32& count, System.Int32 index) { }
        private System.Void EraseAtWithCapacity(Unity.Collections.NativeArray<TValue> array, System.Int32& count, System.Int32 index) { }
        private System.Boolean Erase(TValue[]& array, TValue value) { }
        private System.Void EraseAtByMovingTail(TValue[] array, System.Int32& count, System.Int32 index) { }
        private TValue[] Copy(TValue[] array) { }
        private TValue[] Clone(TValue[] array) { }
        private TNew[] Select(TOld[] array, System.Func<TOld,TNew> converter) { }
        private System.Void Swap(TValue& first, TValue& second) { }
        private System.Void MoveSlice(TValue[] array, System.Int32 sourceIndex, System.Int32 destinationIndex, System.Int32 count) { }
        private System.Void EraseSliceWithCapacity(TValue[]& array, System.Int32& length, System.Int32 index, System.Int32 count) { }
        private System.Void SwapElements(TValue[] array, System.Int32 index1, System.Int32 index2) { }
        private System.Void SwapElements(Unity.Collections.NativeArray<TValue> array, System.Int32 index1, System.Int32 index2) { }

    }

    // TypeToken: 0x2000238
    public struct CallbackArray`1
    {
        // Fields
        private System.Boolean m_CannotMutateCallbacksArray;        // 0x0
        private UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate> m_Callbacks;        // 0x0
        private UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate> m_CallbacksToAdd;        // 0x0
        private UnityEngine.InputSystem.Utilities.InlinedArray<TDelegate> m_CallbacksToRemove;        // 0x0

        // Methods
        private System.Int32 get_length() { }
        private TDelegate get_Item(System.Int32 index) { }
        private System.Void Clear() { }
        private System.Void AddCallback(TDelegate dlg) { }
        private System.Void RemoveCallback(TDelegate dlg) { }
        private System.Void LockForChanges() { }
        private System.Void UnlockForChanges() { }

    }

    // TypeToken: 0x2000239
    public struct Vector2MagnitudeComparer, IComparer`1
    {
        // Methods
        private System.Int32 Compare(UnityEngine.Vector2 x, UnityEngine.Vector2 y) { }

    }

    // TypeToken: 0x200023A
    public struct Vector3MagnitudeComparer, IComparer`1
    {
        // Methods
        private System.Int32 Compare(UnityEngine.Vector3 x, UnityEngine.Vector3 y) { }

    }

    // TypeToken: 0x200023B
    public class CSharpCodeHelpers
    {
        // Methods
        private System.Boolean IsProperIdentifier(System.String name) { }
        private System.Boolean IsEmptyOrProperIdentifier(System.String name) { }
        private System.Boolean IsEmptyOrProperNamespaceName(System.String name) { }
        private System.String MakeIdentifier(System.String name, System.String suffix) { }
        private System.String MakeTypeName(System.String name, System.String suffix) { }

    }

    // TypeToken: 0x200023C
    public class DelegateHelpers
    {
        // Methods
        private System.Void InvokeCallbacksSafe(UnityEngine.InputSystem.Utilities.CallbackArray<System.Action>& callbacks, Unity.Profiling.ProfilerMarker marker, System.String callbackName, System.Object context) { }
        private System.Void InvokeCallbacksSafe(UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<TValue>>& callbacks, TValue argument, System.String callbackName, System.Object context) { }
        private System.Void InvokeCallbacksSafe(UnityEngine.InputSystem.Utilities.CallbackArray<System.Action<TValue1,TValue2>>& callbacks, TValue1 argument1, TValue2 argument2, Unity.Profiling.ProfilerMarker marker, System.String callbackName, System.Object context) { }
        private System.Boolean InvokeCallbacksSafe_AnyCallbackReturnsTrue(UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue1,TValue2,System.Boolean>>& callbacks, TValue1 argument1, TValue2 argument2, System.String callbackName, System.Object context) { }
        private System.Void InvokeCallbacksSafe_AndInvokeReturnedActions(UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue,System.Action>>& callbacks, TValue argument, System.String callbackName, System.Object context) { }
        private System.Boolean InvokeCallbacksSafe_AnyCallbackReturnsObject(UnityEngine.InputSystem.Utilities.CallbackArray<System.Func<TValue,TReturn>>& callbacks, TValue argument, System.String callbackName, System.Object context) { }

    }

    // TypeToken: 0x200023D
    public class DisplayStringFormatAttribute : Attribute
    {
        // Fields
        private System.String <formatString>k__BackingField;        // 0x10

        // Methods
        private System.String get_formatString() { }
        private System.Void set_formatString(System.String value) { }
        private System.Void .ctor(System.String formatString) { }

    }

    // TypeToken: 0x200023E
    public class ExceptionHelpers
    {
        // Methods
        private System.Boolean IsExceptionIndicatingBugInCode(System.Exception exception) { }

    }

    // TypeToken: 0x200023F
    public struct FourCC, IEquatable`1
    {
        // Fields
        private System.Int32 m_Code;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 code) { }
        private System.Void .ctor(System.Char a, System.Char b, System.Char c, System.Char d) { }
        private System.Void .ctor(System.String str) { }
        private System.Int32 op_Implicit(UnityEngine.InputSystem.Utilities.FourCC fourCC) { }
        private UnityEngine.InputSystem.Utilities.FourCC op_Implicit(System.Int32 i) { }
        private System.String ToString() { }
        private System.Boolean Equals(UnityEngine.InputSystem.Utilities.FourCC other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.FourCC left, UnityEngine.InputSystem.Utilities.FourCC right) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.FourCC left, UnityEngine.InputSystem.Utilities.FourCC right) { }
        private UnityEngine.InputSystem.Utilities.FourCC FromInt32(System.Int32 i) { }
        private System.Int32 ToInt32(UnityEngine.InputSystem.Utilities.FourCC fourCC) { }

    }

    // TypeToken: 0x2000240
    public struct InlinedArray`1, IEnumerable`1, IEnumerable
    {
        // Fields
        public System.Int32 length;        // 0x0
        public TValue firstValue;        // 0x0
        public TValue[] additionalValues;        // 0x0

        // Methods
        private System.Int32 get_Capacity() { }
        private System.Void .ctor(TValue value) { }
        private System.Void .ctor(TValue firstValue, TValue[] additionalValues) { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<TValue> values) { }
        private TValue get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, TValue value) { }
        private System.Void Clear() { }
        private System.Void ClearWithCapacity() { }
        private UnityEngine.InputSystem.Utilities.InlinedArray<TValue> Clone() { }
        private System.Void SetLength(System.Int32 size) { }
        private TValue[] ToArray() { }
        private TOther[] ToArray(System.Func<TValue,TOther> mapFunction) { }
        private System.Int32 IndexOf(TValue value) { }
        private System.Int32 Append(TValue value) { }
        private System.Int32 AppendWithCapacity(TValue value, System.Int32 capacityIncrement) { }
        private System.Void AssignWithCapacity(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> values) { }
        private System.Void Append(System.Collections.Generic.IEnumerable<TValue> values) { }
        private System.Void Remove(TValue value) { }
        private System.Void RemoveAtWithCapacity(System.Int32 index) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Void RemoveAtByMovingTailWithCapacity(System.Int32 index) { }
        private System.Boolean RemoveByMovingTailWithCapacity(TValue value) { }
        private System.Boolean Contains(TValue value, System.Collections.Generic.IEqualityComparer<TValue> comparer) { }
        private System.Void Merge(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> other) { }
        private System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000242
    public class InputArrayExtensions
    {
        // Methods
        private System.Int32 IndexOfReference(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value) { }
        private System.Boolean Contains(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value) { }
        private System.Boolean ContainsReference(UnityEngine.InputSystem.Utilities.InlinedArray<TValue> array, TValue value) { }

    }

    // TypeToken: 0x2000243
    public struct InternedString, IEquatable`1, IComparable`1
    {
        // Fields
        private readonly System.String m_StringOriginalCase;        // 0x10
        private readonly System.String m_StringLowerCase;        // 0x18

        // Methods
        private System.Int32 get_length() { }
        private System.Void .ctor(System.String text) { }
        private System.Boolean IsEmpty() { }
        private System.String ToLower() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(UnityEngine.InputSystem.Utilities.InternedString other) { }
        private System.Int32 CompareTo(UnityEngine.InputSystem.Utilities.InternedString other) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.InternedString a, UnityEngine.InputSystem.Utilities.InternedString b) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.InternedString a, UnityEngine.InputSystem.Utilities.InternedString b) { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.InternedString a, System.String b) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.InternedString a, System.String b) { }
        private System.Boolean op_Equality(System.String a, UnityEngine.InputSystem.Utilities.InternedString b) { }
        private System.Boolean op_Inequality(System.String a, UnityEngine.InputSystem.Utilities.InternedString b) { }
        private System.Boolean op_LessThan(UnityEngine.InputSystem.Utilities.InternedString left, UnityEngine.InputSystem.Utilities.InternedString right) { }
        private System.Boolean op_GreaterThan(UnityEngine.InputSystem.Utilities.InternedString left, UnityEngine.InputSystem.Utilities.InternedString right) { }
        private System.String op_Implicit(UnityEngine.InputSystem.Utilities.InternedString str) { }

    }

    // TypeToken: 0x2000244
    public struct JsonParser
    {
        // Fields
        private readonly System.String m_Text;        // 0x10
        private readonly System.Int32 m_Length;        // 0x18
        private System.Int32 m_Position;        // 0x1C
        private System.Boolean m_MatchAnyElementInArray;        // 0x20
        private System.Boolean m_DryRun;        // 0x21

        // Methods
        private System.Void .ctor(System.String json) { }
        private System.Void Reset() { }
        private System.String ToString() { }
        private System.Boolean NavigateToProperty(System.String path) { }
        private System.Boolean CurrentPropertyHasValueEqualTo(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue expectedValue) { }
        private System.Boolean ParseToken(System.Char token) { }
        private System.Boolean ParseValue() { }
        private System.Boolean ParseValue(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue& result) { }
        private System.Boolean ParseStringValue(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue& result) { }
        private System.Boolean ParseArrayValue(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue& result) { }
        private System.Boolean ParseObjectValue(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue& result) { }
        private System.Boolean ParseNumber(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue& result) { }
        private System.Boolean ParseBooleanValue(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue& result) { }
        private System.Boolean ParseNullValue(UnityEngine.InputSystem.Utilities.JsonParser.JsonValue& result) { }
        private System.Boolean SkipToValue() { }
        private System.Boolean SkipString(System.String text) { }
        private System.Void SkipWhitespace() { }
        private System.Boolean get_isAtEnd() { }

    }

    // TypeToken: 0x2000249
    public class MemoryHelpers
    {
        // Methods
        private System.Boolean Compare(System.Void* ptr1, System.Void* ptr2, UnityEngine.InputSystem.Utilities.MemoryHelpers.BitRegion region) { }
        private System.UInt32 ComputeFollowingByteOffset(System.UInt32 byteOffset, System.UInt32 sizeInBits) { }
        private System.Void WriteSingleBit(System.Void* ptr, System.UInt32 bitOffset, System.Boolean value) { }
        private System.Boolean ReadSingleBit(System.Void* ptr, System.UInt32 bitOffset) { }
        private System.Void MemCpyBitRegion(System.Void* destination, System.Void* source, System.UInt32 bitOffset, System.UInt32 bitCount) { }
        private System.Boolean MemCmpBitRegion(System.Void* ptr1, System.Void* ptr2, System.UInt32 bitOffset, System.UInt32 bitCount, System.Void* mask) { }
        private System.Void MemSet(System.Void* destination, System.Int32 numBytes, System.Byte value) { }
        private System.Void MemCpyMasked(System.Void* destination, System.Void* source, System.Int32 numBytes, System.Void* mask) { }
        private System.UInt32 ReadMultipleBitsAsUInt(System.Void* ptr, System.UInt32 bitOffset, System.UInt32 bitCount) { }
        private System.Void WriteUIntAsMultipleBits(System.Void* ptr, System.UInt32 bitOffset, System.UInt32 bitCount, System.UInt32 value) { }
        private System.Int32 ReadTwosComplementMultipleBitsAsInt(System.Void* ptr, System.UInt32 bitOffset, System.UInt32 bitCount) { }
        private System.Void WriteIntAsTwosComplementMultipleBits(System.Void* ptr, System.UInt32 bitOffset, System.UInt32 bitCount, System.Int32 value) { }
        private System.Int32 ReadExcessKMultipleBitsAsInt(System.Void* ptr, System.UInt32 bitOffset, System.UInt32 bitCount) { }
        private System.Void WriteIntAsExcessKMultipleBits(System.Void* ptr, System.UInt32 bitOffset, System.UInt32 bitCount, System.Int32 value) { }
        private System.Single ReadMultipleBitsAsNormalizedUInt(System.Void* ptr, System.UInt32 bitOffset, System.UInt32 bitCount) { }
        private System.Void WriteNormalizedUIntAsMultipleBits(System.Void* ptr, System.UInt32 bitOffset, System.UInt32 bitCount, System.Single value) { }
        private System.Void SetBitsInBuffer(System.Void* buffer, System.Int32 byteOffset, System.Int32 bitOffset, System.Int32 sizeInBits, System.Boolean value) { }
        private System.Void Swap(TValue& a, TValue& b) { }
        private System.UInt32 AlignNatural(System.UInt32 offset, System.UInt32 sizeInBytes) { }

    }

    // TypeToken: 0x200024B
    public class MiscHelpers
    {
        // Methods
        private TValue GetValueOrDefault(System.Collections.Generic.Dictionary<TKey,TValue> dictionary, TKey key) { }
        private System.Collections.Generic.IEnumerable<TValue> EveryNth(System.Collections.Generic.IEnumerable<TValue> enumerable, System.Int32 n, System.Int32 start) { }
        private System.Int32 IndexOf(System.Collections.Generic.IEnumerable<TValue> enumerable, TValue value) { }

    }

    // TypeToken: 0x200024D
    public struct NameAndParameters
    {
        // Fields
        private System.String <name>k__BackingField;        // 0x10
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> <parameters>k__BackingField;        // 0x18

        // Methods
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> get_parameters() { }
        private System.Void set_parameters(UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.Utilities.NamedValue> value) { }
        private System.String ToString() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.NameAndParameters> ParseMultiple(System.String text) { }
        private System.Boolean ParseMultiple(System.String text, System.Collections.Generic.List<UnityEngine.InputSystem.Utilities.NameAndParameters>& list) { }
        private System.String ParseName(System.String text) { }
        private UnityEngine.InputSystem.Utilities.NameAndParameters Parse(System.String text) { }
        private UnityEngine.InputSystem.Utilities.NameAndParameters ParseNameAndParameters(System.String text, System.Int32& index, System.Boolean nameOnly) { }

    }

    // TypeToken: 0x200024F
    public struct NamedValue, IEquatable`1
    {
        // Fields
        public static System.String Separator;        // 0x0
        private System.String <name>k__BackingField;        // 0x10
        private UnityEngine.InputSystem.Utilities.PrimitiveValue <value>k__BackingField;        // 0x18

        // Methods
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue get_value() { }
        private System.Void set_value(UnityEngine.InputSystem.Utilities.PrimitiveValue value) { }
        private System.TypeCode get_type() { }
        private UnityEngine.InputSystem.Utilities.NamedValue ConvertTo(System.TypeCode type) { }
        private UnityEngine.InputSystem.Utilities.NamedValue From(System.String name, TValue value) { }
        private System.String ToString() { }
        private System.Boolean Equals(UnityEngine.InputSystem.Utilities.NamedValue other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.NamedValue left, UnityEngine.InputSystem.Utilities.NamedValue right) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.NamedValue left, UnityEngine.InputSystem.Utilities.NamedValue right) { }
        private UnityEngine.InputSystem.Utilities.NamedValue[] ParseMultiple(System.String parameterString) { }
        private UnityEngine.InputSystem.Utilities.NamedValue Parse(System.String str) { }
        private UnityEngine.InputSystem.Utilities.NamedValue ParseParameter(System.String parameterString, System.Int32& index) { }
        private System.Void ApplyToObject(System.Object instance) { }
        private System.Void ApplyAllToObject(System.Object instance, TParameterList parameters) { }

    }

    // TypeToken: 0x2000250
    public class NumberHelpers
    {
        // Methods
        private System.Int32 AlignToMultipleOf(System.Int32 number, System.Int32 alignment) { }
        private System.Int64 AlignToMultipleOf(System.Int64 number, System.Int64 alignment) { }
        private System.UInt32 AlignToMultipleOf(System.UInt32 number, System.UInt32 alignment) { }
        private System.Boolean Approximately(System.Double a, System.Double b) { }
        private System.Single IntToNormalizedFloat(System.Int32 value, System.Int32 minValue, System.Int32 maxValue) { }
        private System.Int32 NormalizedFloatToInt(System.Single value, System.Int32 intMinValue, System.Int32 intMaxValue) { }
        private System.Single UIntToNormalizedFloat(System.UInt32 value, System.UInt32 minValue, System.UInt32 maxValue) { }
        private System.UInt32 NormalizedFloatToUInt(System.Single value, System.UInt32 uintMinValue, System.UInt32 uintMaxValue) { }
        private System.UInt32 RemapUIntBitsToNormalizeFloatToUIntBits(System.UInt32 value, System.UInt32 inBitSize, System.UInt32 outBitSize) { }

    }

    // TypeToken: 0x2000251
    public class ForDeviceEventObservable, IObservable`1
    {
        // Fields
        private System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_Source;        // 0x10
        private UnityEngine.InputSystem.InputDevice m_Device;        // 0x18
        private System.Type m_DeviceType;        // 0x20

        // Methods
        private System.Void .ctor(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source, System.Type deviceType, UnityEngine.InputSystem.InputDevice device) { }
        private System.IDisposable Subscribe(System.IObserver<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer) { }

    }

    // TypeToken: 0x2000253
    public class Observable
    {
        // Methods
        private System.IObservable<TValue> Where(System.IObservable<TValue> source, System.Func<TValue,System.Boolean> predicate) { }
        private System.IObservable<TResult> Select(System.IObservable<TSource> source, System.Func<TSource,TResult> filter) { }
        private System.IObservable<TResult> SelectMany(System.IObservable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> filter) { }
        private System.IObservable<TValue> Take(System.IObservable<TValue> source, System.Int32 count) { }
        private System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source, UnityEngine.InputSystem.InputDevice device) { }
        private System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> ForDevice(System.IObservable<UnityEngine.InputSystem.LowLevel.InputEventPtr> source) { }
        private System.IDisposable CallOnce(System.IObservable<TValue> source, System.Action<TValue> action) { }
        private System.IDisposable Call(System.IObservable<TValue> source, System.Action<TValue> action) { }

    }

    // TypeToken: 0x2000255
    public class Observer`1, IObserver`1
    {
        // Fields
        private System.Action<TValue> m_OnNext;        // 0x0
        private System.Action m_OnCompleted;        // 0x0

        // Methods
        private System.Void .ctor(System.Action<TValue> onNext, System.Action onCompleted) { }
        private System.Void OnCompleted() { }
        private System.Void OnError(System.Exception error) { }
        private System.Void OnNext(TValue evt) { }

    }

    // TypeToken: 0x2000256
    public class SelectManyObservable`2, IObservable`1
    {
        // Fields
        private readonly System.IObservable<TSource> m_Source;        // 0x0
        private readonly System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> m_Filter;        // 0x0

        // Methods
        private System.Void .ctor(System.IObservable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> filter) { }
        private System.IDisposable Subscribe(System.IObserver<TResult> observer) { }

    }

    // TypeToken: 0x2000258
    public class TakeNObservable`1, IObservable`1
    {
        // Fields
        private System.IObservable<TValue> m_Source;        // 0x0
        private System.Int32 m_Count;        // 0x0

        // Methods
        private System.Void .ctor(System.IObservable<TValue> source, System.Int32 count) { }
        private System.IDisposable Subscribe(System.IObserver<TValue> observer) { }

    }

    // TypeToken: 0x200025A
    public class WhereObservable`1, IObservable`1
    {
        // Fields
        private readonly System.IObservable<TValue> m_Source;        // 0x0
        private readonly System.Func<TValue,System.Boolean> m_Predicate;        // 0x0

        // Methods
        private System.Void .ctor(System.IObservable<TValue> source, System.Func<TValue,System.Boolean> predicate) { }
        private System.IDisposable Subscribe(System.IObserver<TValue> observer) { }

    }

    // TypeToken: 0x200025C
    public struct OneOrMore`2, IReadOnlyList`1, IEnumerable`1, IEnumerable, IReadOnlyCollection`1
    {
        // Fields
        private readonly System.Boolean m_IsSingle;        // 0x0
        private readonly TValue m_Single;        // 0x0
        private readonly TList m_Multiple;        // 0x0

        // Methods
        private System.Int32 get_Count() { }
        private TValue get_Item(System.Int32 index) { }
        private System.Void .ctor(TValue single) { }
        private System.Void .ctor(TList multiple) { }
        private UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> op_Implicit(TValue single) { }
        private UnityEngine.InputSystem.Utilities.OneOrMore<TValue,TList> op_Implicit(TList multiple) { }
        private System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x200025E
    public struct PredictiveParser
    {
        // Fields
        private System.Int32 m_Position;        // 0x10

        // Methods
        private System.Void ExpectSingleChar(System.ReadOnlySpan<System.Char> str, System.Char c) { }
        private System.Int32 ExpectInt(System.ReadOnlySpan<System.Char> str) { }
        private System.ReadOnlySpan<System.Char> ExpectString(System.ReadOnlySpan<System.Char> str) { }
        private System.Boolean AcceptSingleChar(System.ReadOnlySpan<System.Char> str, System.Char c) { }
        private System.Boolean AcceptString(System.ReadOnlySpan<System.Char> input, System.ReadOnlySpan<System.Char>& output) { }
        private System.Void AcceptInt(System.ReadOnlySpan<System.Char> str) { }

    }

    // TypeToken: 0x200025F
    public struct PrimitiveValue, IEquatable`1, IConvertible
    {
        // Fields
        private System.TypeCode m_Type;        // 0x10
        private System.Boolean m_BoolValue;        // 0x14
        private System.Char m_CharValue;        // 0x14
        private System.Byte m_ByteValue;        // 0x14
        private System.SByte m_SByteValue;        // 0x14
        private System.Int16 m_ShortValue;        // 0x14
        private System.UInt16 m_UShortValue;        // 0x14
        private System.Int32 m_IntValue;        // 0x14
        private System.UInt32 m_UIntValue;        // 0x14
        private System.Int64 m_LongValue;        // 0x14
        private System.UInt64 m_ULongValue;        // 0x14
        private System.Single m_FloatValue;        // 0x14
        private System.Double m_DoubleValue;        // 0x14

        // Methods
        private System.Byte* get_valuePtr() { }
        private System.TypeCode get_type() { }
        private System.Boolean get_isEmpty() { }
        private System.Void .ctor(System.Boolean value) { }
        private System.Void .ctor(System.Char value) { }
        private System.Void .ctor(System.Byte value) { }
        private System.Void .ctor(System.SByte value) { }
        private System.Void .ctor(System.Int16 value) { }
        private System.Void .ctor(System.UInt16 value) { }
        private System.Void .ctor(System.Int32 value) { }
        private System.Void .ctor(System.UInt32 value) { }
        private System.Void .ctor(System.Int64 value) { }
        private System.Void .ctor(System.UInt64 value) { }
        private System.Void .ctor(System.Single value) { }
        private System.Void .ctor(System.Double value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue ConvertTo(System.TypeCode type) { }
        private System.Boolean Equals(UnityEngine.InputSystem.Utilities.PrimitiveValue other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.PrimitiveValue left, UnityEngine.InputSystem.Utilities.PrimitiveValue right) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.PrimitiveValue left, UnityEngine.InputSystem.Utilities.PrimitiveValue right) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue FromString(System.String value) { }
        private System.TypeCode GetTypeCode() { }
        private System.Boolean ToBoolean(System.IFormatProvider provider) { }
        private System.Byte ToByte(System.IFormatProvider provider) { }
        private System.Char ToChar(System.IFormatProvider provider) { }
        private System.DateTime ToDateTime(System.IFormatProvider provider) { }
        private System.Decimal ToDecimal(System.IFormatProvider provider) { }
        private System.Double ToDouble(System.IFormatProvider provider) { }
        private System.Int16 ToInt16(System.IFormatProvider provider) { }
        private System.Int32 ToInt32(System.IFormatProvider provider) { }
        private System.Int64 ToInt64(System.IFormatProvider provider) { }
        private System.SByte ToSByte(System.IFormatProvider provider) { }
        private System.Single ToSingle(System.IFormatProvider provider) { }
        private System.String ToString(System.IFormatProvider provider) { }
        private System.Object ToType(System.Type conversionType, System.IFormatProvider provider) { }
        private System.UInt16 ToUInt16(System.IFormatProvider provider) { }
        private System.UInt32 ToUInt32(System.IFormatProvider provider) { }
        private System.UInt64 ToUInt64(System.IFormatProvider provider) { }
        private System.Object ToObject() { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue From(TValue value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue FromObject(System.Object value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.Boolean value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.Char value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.Byte value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.SByte value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.Int16 value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.UInt16 value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.Int32 value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.UInt32 value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.Int64 value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.UInt64 value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.Single value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue op_Implicit(System.Double value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue FromBoolean(System.Boolean value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue FromChar(System.Char value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue FromByte(System.Byte value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue FromSByte(System.SByte value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue FromInt16(System.Int16 value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue FromUInt16(System.UInt16 value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue FromInt32(System.Int32 value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue FromUInt32(System.UInt32 value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue FromInt64(System.Int64 value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue FromUInt64(System.UInt64 value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue FromSingle(System.Single value) { }
        private UnityEngine.InputSystem.Utilities.PrimitiveValue FromDouble(System.Double value) { }

    }

    // TypeToken: 0x2000260
    public struct ReadOnlyArray`1, IReadOnlyList`1, IEnumerable`1, IEnumerable, IReadOnlyCollection`1
    {
        // Fields
        private TValue[] m_Array;        // 0x0
        private System.Int32 m_StartIndex;        // 0x0
        private System.Int32 m_Length;        // 0x0

        // Methods
        private System.Void .ctor(TValue[] array) { }
        private System.Void .ctor(TValue[] array, System.Int32 index, System.Int32 length) { }
        private TValue[] ToArray() { }
        private System.Int32 IndexOf(System.Predicate<TValue> predicate) { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray.Enumerator<TValue> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> op_Implicit(TValue[] array) { }
        private System.Int32 get_Count() { }
        private TValue get_Item(System.Int32 index) { }

    }

    // TypeToken: 0x2000262
    public class ReadOnlyArrayExtensions
    {
        // Methods
        private System.Boolean Contains(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) { }
        private System.Boolean ContainsReference(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) { }
        private System.Int32 IndexOfReference(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array, TValue value) { }
        private System.Boolean HaveEqualReferences(UnityEngine.InputSystem.Utilities.ReadOnlyArray<TValue> array1, System.Collections.Generic.IReadOnlyList<TValue> array2, System.Int32 count) { }

    }

    // TypeToken: 0x2000263
    public interface ISavedState
    {
        // Methods
        private System.Void StaticDisposeCurrentState() { }
        private System.Void RestoreSavedState() { }

    }

    // TypeToken: 0x2000264
    public class SavedStructState`1, ISavedState
    {
        // Fields
        private T m_State;        // 0x0
        private UnityEngine.InputSystem.Utilities.SavedStructState.TypedRestore<T> m_RestoreAction;        // 0x0
        private System.Action m_StaticDisposeCurrentState;        // 0x0

        // Methods
        private System.Void .ctor(T& state, UnityEngine.InputSystem.Utilities.SavedStructState.TypedRestore<T> restoreAction, System.Action staticDisposeCurrentState) { }
        private System.Void StaticDisposeCurrentState() { }
        private System.Void RestoreSavedState() { }

    }

    // TypeToken: 0x2000266
    public class SpriteUtilities
    {
        // Methods
        private UnityEngine.Sprite CreateCircleSprite(System.Int32 radius, UnityEngine.Color32 colour) { }

    }

    // TypeToken: 0x2000267
    public class StringHelpers
    {
        // Methods
        private System.String Escape(System.String str, System.String chars, System.String replacements) { }
        private System.String Unescape(System.String str, System.String chars, System.String replacements) { }
        private System.Boolean Contains(System.String str, System.Char ch) { }
        private System.Boolean Contains(System.String str, System.String text, System.StringComparison comparison) { }
        private System.String GetPlural(System.String str) { }
        private System.String NicifyMemorySize(System.Int64 numBytes) { }
        private System.Boolean FromNicifiedMemorySize(System.String text, System.Int64& result, System.Int64 defaultMultiplier) { }
        private System.Int32 CountOccurrences(System.String str, System.Char ch) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.Substring> Tokenize(System.String str) { }
        private System.Collections.Generic.IEnumerable<System.String> Split(System.String str, System.Func<System.Char,System.Boolean> predicate) { }
        private System.String Join(System.String separator, TValue[] values) { }
        private System.String Join(System.Collections.Generic.IEnumerable<TValue> values, System.String separator) { }
        private System.String MakeUniqueName(System.String baseName, System.Collections.Generic.IEnumerable<TExisting> existingSet, System.Func<TExisting,System.String> getNameFunc) { }
        private System.Boolean CharacterSeparatedListsHaveAtLeastOneCommonElement(System.String firstList, System.String secondList, System.Char separator) { }
        private System.Int32 ParseInt(System.String str, System.Int32 pos) { }
        private System.Boolean WriteStringToBuffer(System.String text, System.IntPtr buffer, System.Int32 bufferSizeInCharacters) { }
        private System.Boolean WriteStringToBuffer(System.String text, System.IntPtr buffer, System.Int32 bufferSizeInCharacters, System.UInt32& offset) { }
        private System.String ReadStringFromBuffer(System.IntPtr buffer, System.Int32 bufferSize) { }
        private System.String ReadStringFromBuffer(System.IntPtr buffer, System.Int32 bufferSize, System.UInt32& offset) { }
        private System.Boolean IsPrintable(System.Char ch) { }
        private System.String WithAllWhitespaceStripped(System.String str) { }
        private System.Boolean InvariantEqualsIgnoreCase(System.String left, System.String right) { }
        private System.String ExpandTemplateString(System.String template, System.Func<System.String,System.String> mapFunc) { }

    }

    // TypeToken: 0x200026A
    public struct Substring, IComparable`1, IEquatable`1
    {
        // Fields
        private readonly System.String m_String;        // 0x10
        private readonly System.Int32 m_Index;        // 0x18
        private readonly System.Int32 m_Length;        // 0x1C

        // Methods
        private System.Boolean get_isEmpty() { }
        private System.Void .ctor(System.String str) { }
        private System.Void .ctor(System.String str, System.Int32 index, System.Int32 length) { }
        private System.Void .ctor(System.String str, System.Int32 index) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(System.String other) { }
        private System.Boolean Equals(UnityEngine.InputSystem.Utilities.Substring other) { }
        private System.Boolean Equals(UnityEngine.InputSystem.Utilities.InternedString other) { }
        private System.Int32 CompareTo(UnityEngine.InputSystem.Utilities.Substring other) { }
        private System.Int32 Compare(UnityEngine.InputSystem.Utilities.Substring left, UnityEngine.InputSystem.Utilities.Substring right, System.StringComparison comparison) { }
        private System.Boolean StartsWith(System.String str) { }
        private System.String Substr(System.Int32 index, System.Int32 length) { }
        private System.String ToString() { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.Substring a, UnityEngine.InputSystem.Utilities.Substring b) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.Substring a, UnityEngine.InputSystem.Utilities.Substring b) { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.Substring a, UnityEngine.InputSystem.Utilities.InternedString b) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.Substring a, UnityEngine.InputSystem.Utilities.InternedString b) { }
        private System.Boolean op_Equality(UnityEngine.InputSystem.Utilities.InternedString a, UnityEngine.InputSystem.Utilities.Substring b) { }
        private System.Boolean op_Inequality(UnityEngine.InputSystem.Utilities.InternedString a, UnityEngine.InputSystem.Utilities.Substring b) { }
        private UnityEngine.InputSystem.Utilities.Substring op_Implicit(System.String s) { }
        private System.Int32 get_length() { }
        private System.Int32 get_index() { }
        private System.Char get_Item(System.Int32 index) { }

    }

    // TypeToken: 0x200026B
    public class TypeHelpers
    {
        // Methods
        private TObject As(System.Object obj) { }
        private System.Boolean IsInt(System.TypeCode type) { }
        private System.Type GetValueType(System.Reflection.MemberInfo member) { }
        private System.String GetNiceTypeName(System.Type type) { }
        private System.Type GetGenericTypeArgumentFromHierarchy(System.Type type, System.Type genericTypeDefinition, System.Int32 argumentIndex) { }

    }

    // TypeToken: 0x200026C
    public struct TypeTable
    {
        // Fields
        public System.Collections.Generic.Dictionary<UnityEngine.InputSystem.Utilities.InternedString,System.Type> table;        // 0x10

        // Methods
        private System.Collections.Generic.IEnumerable<System.String> get_names() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString> get_internedNames() { }
        private System.Void Initialize() { }
        private UnityEngine.InputSystem.Utilities.InternedString FindNameForType(System.Type type) { }
        private System.Void AddTypeRegistration(System.String name, System.Type type) { }
        private System.Type LookupTypeRegistration(System.String name) { }

    }

}

namespace UnityEngine.InputSystem.XInput
{

    // TypeToken: 0x20000FC
    public interface IXboxOneRumble : IDualMotorRumble, IHaptics
    {
        // Methods
        private System.Void SetMotorSpeeds(System.Single lowFrequency, System.Single highFrequency, System.Single leftTrigger, System.Single rightTrigger) { }

    }

    // TypeToken: 0x20000FD
    public class XInputController : Gamepad
    {
        // Fields
        private UnityEngine.InputSystem.Controls.ButtonControl <menu>k__BackingField;        // 0x210
        private UnityEngine.InputSystem.Controls.ButtonControl <view>k__BackingField;        // 0x218
        private System.Boolean m_HaveParsedCapabilities;        // 0x220
        private UnityEngine.InputSystem.XInput.XInputController.DeviceSubType m_SubType;        // 0x224
        private UnityEngine.InputSystem.XInput.XInputController.DeviceFlags m_Flags;        // 0x228

        // Methods
        private UnityEngine.InputSystem.Controls.ButtonControl get_menu() { }
        private System.Void set_menu(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_view() { }
        private System.Void set_view(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.XInput.XInputController.DeviceSubType get_subType() { }
        private UnityEngine.InputSystem.XInput.XInputController.DeviceFlags get_flags() { }
        private System.Void FinishSetup() { }
        private System.Void ParseCapabilities() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000102
    public class XInputControllerWindows : XInputController
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000103
    public class XInputSupport
    {
        // Methods
        private System.Void Initialize() { }

    }

}

namespace UnityEngine.InputSystem.XInput.LowLevel
{

    // TypeToken: 0x2000104
    public struct XInputControllerWindowsState, IInputStateTypeInfo
    {
        // Fields
        public System.UInt16 buttons;        // 0x10
        public System.Byte leftTrigger;        // 0x12
        public System.Byte rightTrigger;        // 0x13
        public System.Int16 leftStickX;        // 0x14
        public System.Int16 leftStickY;        // 0x16
        public System.Int16 rightStickX;        // 0x18
        public System.Int16 rightStickY;        // 0x1A

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }
        private UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState WithButton(UnityEngine.InputSystem.XInput.LowLevel.XInputControllerWindowsState.Button button) { }

    }

}

namespace UnityEngine.InputSystem.XR
{

    // TypeToken: 0x20000DF
    public struct PoseState, IInputStateTypeInfo
    {
        // Fields
        private static System.Int32 kSizeInBytes;        // 0x0
        private static readonly UnityEngine.InputSystem.Utilities.FourCC s_Format;        // 0x0
        public System.Boolean isTracked;        // 0x10
        public UnityEngine.XR.InputTrackingState trackingState;        // 0x14
        public UnityEngine.Vector3 position;        // 0x18
        public UnityEngine.Quaternion rotation;        // 0x24
        public UnityEngine.Vector3 velocity;        // 0x34
        public UnityEngine.Vector3 angularVelocity;        // 0x40

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_format() { }
        private System.Void .ctor(System.Boolean isTracked, UnityEngine.XR.InputTrackingState trackingState, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 velocity, UnityEngine.Vector3 angularVelocity) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E0
    public class PoseControl : InputControl`1
    {
        // Fields
        private UnityEngine.InputSystem.Controls.ButtonControl <isTracked>k__BackingField;        // 0x178
        private UnityEngine.InputSystem.Controls.IntegerControl <trackingState>k__BackingField;        // 0x180
        private UnityEngine.InputSystem.Controls.Vector3Control <position>k__BackingField;        // 0x188
        private UnityEngine.InputSystem.Controls.QuaternionControl <rotation>k__BackingField;        // 0x190
        private UnityEngine.InputSystem.Controls.Vector3Control <velocity>k__BackingField;        // 0x198
        private UnityEngine.InputSystem.Controls.Vector3Control <angularVelocity>k__BackingField;        // 0x1A0

        // Methods
        private UnityEngine.InputSystem.Controls.ButtonControl get_isTracked() { }
        private System.Void set_isTracked(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.IntegerControl get_trackingState() { }
        private System.Void set_trackingState(UnityEngine.InputSystem.Controls.IntegerControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_position() { }
        private System.Void set_position(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.QuaternionControl get_rotation() { }
        private System.Void set_rotation(UnityEngine.InputSystem.Controls.QuaternionControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_velocity() { }
        private System.Void set_velocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_angularVelocity() { }
        private System.Void set_angularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private System.Void .ctor() { }
        private System.Void FinishSetup() { }
        private UnityEngine.InputSystem.XR.PoseState ReadUnprocessedValueFromState(System.Void* statePtr) { }
        private System.Void WriteValueIntoState(UnityEngine.InputSystem.XR.PoseState value, System.Void* statePtr) { }
        private UnityEngine.InputSystem.Utilities.FourCC CalculateOptimizedControlDataType() { }

    }

    // TypeToken: 0x20000E1
    public class XRHMD : TrackedDevice
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector3Control <leftEyePosition>k__BackingField;        // 0x1B0
        private UnityEngine.InputSystem.Controls.QuaternionControl <leftEyeRotation>k__BackingField;        // 0x1B8
        private UnityEngine.InputSystem.Controls.Vector3Control <rightEyePosition>k__BackingField;        // 0x1C0
        private UnityEngine.InputSystem.Controls.QuaternionControl <rightEyeRotation>k__BackingField;        // 0x1C8
        private UnityEngine.InputSystem.Controls.Vector3Control <centerEyePosition>k__BackingField;        // 0x1D0
        private UnityEngine.InputSystem.Controls.QuaternionControl <centerEyeRotation>k__BackingField;        // 0x1D8

        // Methods
        private UnityEngine.InputSystem.Controls.Vector3Control get_leftEyePosition() { }
        private System.Void set_leftEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.QuaternionControl get_leftEyeRotation() { }
        private System.Void set_leftEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_rightEyePosition() { }
        private System.Void set_rightEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.QuaternionControl get_rightEyeRotation() { }
        private System.Void set_rightEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_centerEyePosition() { }
        private System.Void set_centerEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.QuaternionControl get_centerEyeRotation() { }
        private System.Void set_centerEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E2
    public class XRController : TrackedDevice
    {
        // Methods
        private UnityEngine.InputSystem.XR.XRController get_leftHand() { }
        private UnityEngine.InputSystem.XR.XRController get_rightHand() { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E3
    public class XRControllerWithRumble : XRController
    {
        // Methods
        private System.Void SendImpulse(System.Single amplitude, System.Single duration) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E4
    public class TrackedPoseDriver : MonoBehaviour, ISerializationCallbackReceiver
    {
        // Fields
        private UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType m_TrackingType;        // 0x18
        private UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType m_UpdateType;        // 0x1C
        private System.Boolean m_IgnoreTrackingState;        // 0x20
        private UnityEngine.InputSystem.InputActionProperty m_PositionInput;        // 0x28
        private UnityEngine.InputSystem.InputActionProperty m_RotationInput;        // 0x40
        private UnityEngine.InputSystem.InputActionProperty m_TrackingStateInput;        // 0x58
        private UnityEngine.Vector3 m_CurrentPosition;        // 0x70
        private UnityEngine.Quaternion m_CurrentRotation;        // 0x7C
        private UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingStates m_CurrentTrackingState;        // 0x8C
        private System.Boolean m_RotationBound;        // 0x90
        private System.Boolean m_PositionBound;        // 0x91
        private System.Boolean m_TrackingStateBound;        // 0x92
        private System.Boolean m_IsFirstUpdate;        // 0x93
        private UnityEngine.InputSystem.InputAction m_PositionAction;        // 0x98
        private UnityEngine.InputSystem.InputAction m_RotationAction;        // 0xA0

        // Methods
        private UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType get_trackingType() { }
        private System.Void set_trackingType(UnityEngine.InputSystem.XR.TrackedPoseDriver.TrackingType value) { }
        private UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType get_updateType() { }
        private System.Void set_updateType(UnityEngine.InputSystem.XR.TrackedPoseDriver.UpdateType value) { }
        private System.Boolean get_ignoreTrackingState() { }
        private System.Void set_ignoreTrackingState(System.Boolean value) { }
        private UnityEngine.InputSystem.InputActionProperty get_positionInput() { }
        private System.Void set_positionInput(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_rotationInput() { }
        private System.Void set_rotationInput(UnityEngine.InputSystem.InputActionProperty value) { }
        private UnityEngine.InputSystem.InputActionProperty get_trackingStateInput() { }
        private System.Void set_trackingStateInput(UnityEngine.InputSystem.InputActionProperty value) { }
        private System.Void BindActions() { }
        private System.Void UnbindActions() { }
        private System.Void BindPosition() { }
        private System.Void BindRotation() { }
        private System.Void BindTrackingState() { }
        private System.Void RenameAndEnable(UnityEngine.InputSystem.InputAction action, System.String name) { }
        private System.Void UnbindPosition() { }
        private System.Void UnbindRotation() { }
        private System.Void UnbindTrackingState() { }
        private System.Void OnPositionPerformed(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnPositionCanceled(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnRotationPerformed(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnRotationCanceled(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnTrackingStatePerformed(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void OnTrackingStateCanceled(UnityEngine.InputSystem.InputAction.CallbackContext context) { }
        private System.Void Reset() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void UpdateCallback() { }
        private System.Void ReadTrackingState(System.Boolean hasResolvedPositionInputControl, System.Boolean hasResolvedRotationInputControl) { }
        private System.Void OnUpdate() { }
        private System.Void OnBeforeRender() { }
        private System.Void PerformUpdate() { }
        private System.Void SetLocalTransform(UnityEngine.Vector3 newPosition, UnityEngine.Quaternion newRotation) { }
        private System.Boolean HasStereoCamera(UnityEngine.Camera& cameraComponent) { }
        private System.Boolean HasResolvedControl(UnityEngine.InputSystem.InputAction action) { }
        private UnityEngine.InputSystem.InputAction get_positionAction() { }
        private System.Void set_positionAction(UnityEngine.InputSystem.InputAction value) { }
        private UnityEngine.InputSystem.InputAction get_rotationAction() { }
        private System.Void set_rotationAction(UnityEngine.InputSystem.InputAction value) { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E8
    public class XRLayoutBuilder
    {
        // Fields
        private System.String parentLayout;        // 0x10
        private System.String interfaceName;        // 0x18
        private UnityEngine.InputSystem.XR.XRDeviceDescriptor descriptor;        // 0x20
        private static readonly System.String[] poseSubControlNames;        // 0x0
        private static readonly UnityEngine.InputSystem.XR.FeatureType[] poseSubControlTypes;        // 0x8

        // Methods
        private System.UInt32 GetSizeOfFeature(UnityEngine.InputSystem.XR.XRFeatureDescriptor featureDescriptor) { }
        private System.String SanitizeString(System.String original, System.Boolean allowPaths) { }
        private System.String OnFindLayoutForDevice(UnityEngine.InputSystem.Layouts.InputDeviceDescription& description, System.String matchedLayout, UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate executeCommandDelegate) { }
        private System.String ConvertPotentialAliasToName(UnityEngine.InputSystem.Layouts.InputControlLayout layout, System.String nameOrAlias) { }
        private System.Boolean IsSubControl(System.String name) { }
        private System.String GetParentControlName(System.String name) { }
        private System.Boolean IsPoseControl(System.Collections.Generic.List<UnityEngine.InputSystem.XR.XRFeatureDescriptor> features, System.Int32 startIndex) { }
        private UnityEngine.InputSystem.Layouts.InputControlLayout Build() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000EA
    public class XRUtilities
    {
        // Fields
        public static System.String InterfaceMatchAnyVersion;        // 0x0
        public static System.String InterfaceV1;        // 0x0
        public static System.String InterfaceCurrent;        // 0x0

    }

    // TypeToken: 0x20000EB
    public struct FeatureType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static UnityEngine.InputSystem.XR.FeatureType Custom;        // 0x0
        public static UnityEngine.InputSystem.XR.FeatureType Binary;        // 0x0
        public static UnityEngine.InputSystem.XR.FeatureType DiscreteStates;        // 0x0
        public static UnityEngine.InputSystem.XR.FeatureType Axis1D;        // 0x0
        public static UnityEngine.InputSystem.XR.FeatureType Axis2D;        // 0x0
        public static UnityEngine.InputSystem.XR.FeatureType Axis3D;        // 0x0
        public static UnityEngine.InputSystem.XR.FeatureType Rotation;        // 0x0
        public static UnityEngine.InputSystem.XR.FeatureType Hand;        // 0x0
        public static UnityEngine.InputSystem.XR.FeatureType Bone;        // 0x0
        public static UnityEngine.InputSystem.XR.FeatureType Eyes;        // 0x0

    }

    // TypeToken: 0x20000EC
    public struct UsageHint
    {
        // Fields
        public System.String content;        // 0x10

    }

    // TypeToken: 0x20000ED
    public struct XRFeatureDescriptor
    {
        // Fields
        public System.String name;        // 0x10
        public System.Collections.Generic.List<UnityEngine.InputSystem.XR.UsageHint> usageHints;        // 0x18
        public UnityEngine.InputSystem.XR.FeatureType featureType;        // 0x20
        public System.UInt32 customSize;        // 0x24

    }

    // TypeToken: 0x20000EE
    public class XRDeviceDescriptor
    {
        // Fields
        public System.String deviceName;        // 0x10
        public System.String manufacturer;        // 0x18
        public System.String serialNumber;        // 0x20
        public UnityEngine.XR.InputDeviceCharacteristics characteristics;        // 0x28
        public System.Int32 deviceId;        // 0x2C
        public System.Collections.Generic.List<UnityEngine.InputSystem.XR.XRFeatureDescriptor> inputFeatures;        // 0x30

        // Methods
        private System.String ToJson() { }
        private UnityEngine.InputSystem.XR.XRDeviceDescriptor FromJson(System.String json) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EF
    public struct Bone
    {
        // Fields
        public System.UInt32 m_ParentBoneIndex;        // 0x10
        public UnityEngine.Vector3 m_Position;        // 0x14
        public UnityEngine.Quaternion m_Rotation;        // 0x20

        // Methods
        private System.UInt32 get_parentBoneIndex() { }
        private System.Void set_parentBoneIndex(System.UInt32 value) { }
        private UnityEngine.Vector3 get_position() { }
        private System.Void set_position(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_rotation() { }
        private System.Void set_rotation(UnityEngine.Quaternion value) { }

    }

    // TypeToken: 0x20000F0
    public struct Eyes
    {
        // Fields
        public UnityEngine.Vector3 m_LeftEyePosition;        // 0x10
        public UnityEngine.Quaternion m_LeftEyeRotation;        // 0x1C
        public UnityEngine.Vector3 m_RightEyePosition;        // 0x2C
        public UnityEngine.Quaternion m_RightEyeRotation;        // 0x38
        public UnityEngine.Vector3 m_FixationPoint;        // 0x48
        public System.Single m_LeftEyeOpenAmount;        // 0x54
        public System.Single m_RightEyeOpenAmount;        // 0x58

        // Methods
        private UnityEngine.Vector3 get_leftEyePosition() { }
        private System.Void set_leftEyePosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_leftEyeRotation() { }
        private System.Void set_leftEyeRotation(UnityEngine.Quaternion value) { }
        private UnityEngine.Vector3 get_rightEyePosition() { }
        private System.Void set_rightEyePosition(UnityEngine.Vector3 value) { }
        private UnityEngine.Quaternion get_rightEyeRotation() { }
        private System.Void set_rightEyeRotation(UnityEngine.Quaternion value) { }
        private UnityEngine.Vector3 get_fixationPoint() { }
        private System.Void set_fixationPoint(UnityEngine.Vector3 value) { }
        private System.Single get_leftEyeOpenAmount() { }
        private System.Void set_leftEyeOpenAmount(System.Single value) { }
        private System.Single get_rightEyeOpenAmount() { }
        private System.Void set_rightEyeOpenAmount(System.Single value) { }

    }

    // TypeToken: 0x20000F1
    public class BoneControl : InputControl`1
    {
        // Fields
        private UnityEngine.InputSystem.Controls.IntegerControl <parentBoneIndex>k__BackingField;        // 0x140
        private UnityEngine.InputSystem.Controls.Vector3Control <position>k__BackingField;        // 0x148
        private UnityEngine.InputSystem.Controls.QuaternionControl <rotation>k__BackingField;        // 0x150

        // Methods
        private UnityEngine.InputSystem.Controls.IntegerControl get_parentBoneIndex() { }
        private System.Void set_parentBoneIndex(UnityEngine.InputSystem.Controls.IntegerControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_position() { }
        private System.Void set_position(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.QuaternionControl get_rotation() { }
        private System.Void set_rotation(UnityEngine.InputSystem.Controls.QuaternionControl value) { }
        private System.Void FinishSetup() { }
        private UnityEngine.InputSystem.XR.Bone ReadUnprocessedValueFromState(System.Void* statePtr) { }
        private System.Void WriteValueIntoState(UnityEngine.InputSystem.XR.Bone value, System.Void* statePtr) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F2
    public class EyesControl : InputControl`1
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector3Control <leftEyePosition>k__BackingField;        // 0x198
        private UnityEngine.InputSystem.Controls.QuaternionControl <leftEyeRotation>k__BackingField;        // 0x1A0
        private UnityEngine.InputSystem.Controls.Vector3Control <rightEyePosition>k__BackingField;        // 0x1A8
        private UnityEngine.InputSystem.Controls.QuaternionControl <rightEyeRotation>k__BackingField;        // 0x1B0
        private UnityEngine.InputSystem.Controls.Vector3Control <fixationPoint>k__BackingField;        // 0x1B8
        private UnityEngine.InputSystem.Controls.AxisControl <leftEyeOpenAmount>k__BackingField;        // 0x1C0
        private UnityEngine.InputSystem.Controls.AxisControl <rightEyeOpenAmount>k__BackingField;        // 0x1C8

        // Methods
        private UnityEngine.InputSystem.Controls.Vector3Control get_leftEyePosition() { }
        private System.Void set_leftEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.QuaternionControl get_leftEyeRotation() { }
        private System.Void set_leftEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_rightEyePosition() { }
        private System.Void set_rightEyePosition(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.QuaternionControl get_rightEyeRotation() { }
        private System.Void set_rightEyeRotation(UnityEngine.InputSystem.Controls.QuaternionControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_fixationPoint() { }
        private System.Void set_fixationPoint(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_leftEyeOpenAmount() { }
        private System.Void set_leftEyeOpenAmount(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_rightEyeOpenAmount() { }
        private System.Void set_rightEyeOpenAmount(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private System.Void FinishSetup() { }
        private UnityEngine.InputSystem.XR.Eyes ReadUnprocessedValueFromState(System.Void* statePtr) { }
        private System.Void WriteValueIntoState(UnityEngine.InputSystem.XR.Eyes value, System.Void* statePtr) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F3
    public class XRSupport
    {
        // Methods
        private System.Void Initialize() { }

    }

}

namespace UnityEngine.InputSystem.XR.Haptics
{

    // TypeToken: 0x20000F4
    public struct BufferedRumble
    {
        // Fields
        private UnityEngine.InputSystem.XR.Haptics.HapticCapabilities <capabilities>k__BackingField;        // 0x10
        private UnityEngine.InputSystem.InputDevice <device>k__BackingField;        // 0x28

        // Methods
        private UnityEngine.InputSystem.XR.Haptics.HapticCapabilities get_capabilities() { }
        private System.Void set_capabilities(UnityEngine.InputSystem.XR.Haptics.HapticCapabilities value) { }
        private UnityEngine.InputSystem.InputDevice get_device() { }
        private System.Void set_device(UnityEngine.InputSystem.InputDevice value) { }
        private System.Void .ctor(UnityEngine.InputSystem.InputDevice device) { }
        private System.Void EnqueueRumble(System.Byte[] samples) { }

    }

    // TypeToken: 0x20000F5
    public struct HapticState
    {
        // Fields
        private System.UInt32 <samplesQueued>k__BackingField;        // 0x10
        private System.UInt32 <samplesAvailable>k__BackingField;        // 0x14

        // Methods
        private System.Void .ctor(System.UInt32 samplesQueued, System.UInt32 samplesAvailable) { }
        private System.UInt32 get_samplesQueued() { }
        private System.Void set_samplesQueued(System.UInt32 value) { }
        private System.UInt32 get_samplesAvailable() { }
        private System.Void set_samplesAvailable(System.UInt32 value) { }

    }

    // TypeToken: 0x20000F6
    public struct GetCurrentHapticStateCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        private UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public System.UInt32 samplesQueued;        // 0x18
        public System.UInt32 samplesAvailable;        // 0x1C

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.XR.Haptics.HapticState get_currentState() { }
        private UnityEngine.InputSystem.XR.Haptics.GetCurrentHapticStateCommand Create() { }

    }

    // TypeToken: 0x20000F7
    public struct HapticCapabilities
    {
        // Fields
        private readonly System.UInt32 <numChannels>k__BackingField;        // 0x10
        private readonly System.Boolean <supportsImpulse>k__BackingField;        // 0x14
        private readonly System.Boolean <supportsBuffer>k__BackingField;        // 0x15
        private readonly System.UInt32 <frequencyHz>k__BackingField;        // 0x18
        private readonly System.UInt32 <maxBufferSize>k__BackingField;        // 0x1C
        private readonly System.UInt32 <optimalBufferSize>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.UInt32 numChannels, System.Boolean supportsImpulse, System.Boolean supportsBuffer, System.UInt32 frequencyHz, System.UInt32 maxBufferSize, System.UInt32 optimalBufferSize) { }
        private System.Void .ctor(System.UInt32 numChannels, System.UInt32 frequencyHz, System.UInt32 maxBufferSize) { }
        private System.UInt32 get_numChannels() { }
        private System.Boolean get_supportsImpulse() { }
        private System.Boolean get_supportsBuffer() { }
        private System.UInt32 get_frequencyHz() { }
        private System.UInt32 get_maxBufferSize() { }
        private System.UInt32 get_optimalBufferSize() { }

    }

    // TypeToken: 0x20000F8
    public struct GetHapticCapabilitiesCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        private UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        public System.UInt32 numChannels;        // 0x18
        public System.Boolean supportsImpulse;        // 0x1C
        public System.Boolean supportsBuffer;        // 0x1D
        public System.UInt32 frequencyHz;        // 0x20
        public System.UInt32 maxBufferSize;        // 0x24
        public System.UInt32 optimalBufferSize;        // 0x28

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.XR.Haptics.HapticCapabilities get_capabilities() { }
        private UnityEngine.InputSystem.XR.Haptics.GetHapticCapabilitiesCommand Create() { }

    }

    // TypeToken: 0x20000F9
    public struct SendBufferedHapticCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kMaxHapticBufferSize;        // 0x0
        private static System.Int32 kSize;        // 0x0
        private UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        private System.Int32 channel;        // 0x18
        private System.Int32 bufferSize;        // 0x1C
        private UnityEngine.InputSystem.XR.Haptics.SendBufferedHapticCommand.<buffer>e__FixedBuffer buffer;        // 0x20

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.XR.Haptics.SendBufferedHapticCommand Create(System.Byte[] rumbleBuffer) { }

    }

    // TypeToken: 0x20000FB
    public struct SendHapticImpulseCommand, IInputDeviceCommandInfo
    {
        // Fields
        private static System.Int32 kSize;        // 0x0
        private UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand;        // 0x10
        private System.Int32 channel;        // 0x18
        private System.Single amplitude;        // 0x1C
        private System.Single duration;        // 0x20

        // Methods
        private UnityEngine.InputSystem.Utilities.FourCC get_Type() { }
        private UnityEngine.InputSystem.Utilities.FourCC get_typeStatic() { }
        private UnityEngine.InputSystem.XR.Haptics.SendHapticImpulseCommand Create(System.Int32 motorChannel, System.Single motorAmplitude, System.Single motorDuration) { }

    }

}

namespace UnityEngine.XR.WindowsMR.Input
{

    // TypeToken: 0x2000012
    public class WMRHMD : XRHMD
    {
        // Fields
        private UnityEngine.InputSystem.Controls.ButtonControl <userPresence>k__BackingField;        // 0x1E0

        // Methods
        private UnityEngine.InputSystem.Controls.ButtonControl get_userPresence() { }
        private System.Void set_userPresence(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000013
    public class HololensHand : XRController
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;        // 0x1B0
        private UnityEngine.InputSystem.Controls.ButtonControl <airTap>k__BackingField;        // 0x1B8
        private UnityEngine.InputSystem.Controls.AxisControl <sourceLossRisk>k__BackingField;        // 0x1C0
        private UnityEngine.InputSystem.Controls.Vector3Control <sourceLossMitigationDirection>k__BackingField;        // 0x1C8

        // Methods
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity() { }
        private System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_airTap() { }
        private System.Void set_airTap(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_sourceLossRisk() { }
        private System.Void set_sourceLossRisk(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_sourceLossMitigationDirection() { }
        private System.Void set_sourceLossMitigationDirection(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public class WMRSpatialController : XRControllerWithRumble
    {
        // Fields
        private UnityEngine.InputSystem.Controls.Vector2Control <joystick>k__BackingField;        // 0x1B0
        private UnityEngine.InputSystem.Controls.Vector2Control <touchpad>k__BackingField;        // 0x1B8
        private UnityEngine.InputSystem.Controls.AxisControl <grip>k__BackingField;        // 0x1C0
        private UnityEngine.InputSystem.Controls.ButtonControl <gripPressed>k__BackingField;        // 0x1C8
        private UnityEngine.InputSystem.Controls.ButtonControl <menu>k__BackingField;        // 0x1D0
        private UnityEngine.InputSystem.Controls.AxisControl <trigger>k__BackingField;        // 0x1D8
        private UnityEngine.InputSystem.Controls.ButtonControl <triggerPressed>k__BackingField;        // 0x1E0
        private UnityEngine.InputSystem.Controls.ButtonControl <joystickClicked>k__BackingField;        // 0x1E8
        private UnityEngine.InputSystem.Controls.ButtonControl <touchpadClicked>k__BackingField;        // 0x1F0
        private UnityEngine.InputSystem.Controls.ButtonControl <touchpadTouched>k__BackingField;        // 0x1F8
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceVelocity>k__BackingField;        // 0x200
        private UnityEngine.InputSystem.Controls.Vector3Control <deviceAngularVelocity>k__BackingField;        // 0x208
        private UnityEngine.InputSystem.Controls.AxisControl <batteryLevel>k__BackingField;        // 0x210
        private UnityEngine.InputSystem.Controls.AxisControl <sourceLossRisk>k__BackingField;        // 0x218
        private UnityEngine.InputSystem.Controls.Vector3Control <sourceLossMitigationDirection>k__BackingField;        // 0x220
        private UnityEngine.InputSystem.Controls.Vector3Control <pointerPosition>k__BackingField;        // 0x228
        private UnityEngine.InputSystem.Controls.QuaternionControl <pointerRotation>k__BackingField;        // 0x230

        // Methods
        private UnityEngine.InputSystem.Controls.Vector2Control get_joystick() { }
        private System.Void set_joystick(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private UnityEngine.InputSystem.Controls.Vector2Control get_touchpad() { }
        private System.Void set_touchpad(UnityEngine.InputSystem.Controls.Vector2Control value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_grip() { }
        private System.Void set_grip(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_gripPressed() { }
        private System.Void set_gripPressed(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_menu() { }
        private System.Void set_menu(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_trigger() { }
        private System.Void set_trigger(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_triggerPressed() { }
        private System.Void set_triggerPressed(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_joystickClicked() { }
        private System.Void set_joystickClicked(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_touchpadClicked() { }
        private System.Void set_touchpadClicked(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.ButtonControl get_touchpadTouched() { }
        private System.Void set_touchpadTouched(UnityEngine.InputSystem.Controls.ButtonControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceVelocity() { }
        private System.Void set_deviceVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_deviceAngularVelocity() { }
        private System.Void set_deviceAngularVelocity(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_batteryLevel() { }
        private System.Void set_batteryLevel(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.AxisControl get_sourceLossRisk() { }
        private System.Void set_sourceLossRisk(UnityEngine.InputSystem.Controls.AxisControl value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_sourceLossMitigationDirection() { }
        private System.Void set_sourceLossMitigationDirection(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.Vector3Control get_pointerPosition() { }
        private System.Void set_pointerPosition(UnityEngine.InputSystem.Controls.Vector3Control value) { }
        private UnityEngine.InputSystem.Controls.QuaternionControl get_pointerRotation() { }
        private System.Void set_pointerRotation(UnityEngine.InputSystem.Controls.QuaternionControl value) { }
        private System.Void FinishSetup() { }
        private System.Void .ctor() { }

    }

}

