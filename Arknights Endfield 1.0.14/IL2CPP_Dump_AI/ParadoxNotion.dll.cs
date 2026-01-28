// ========================================================
// Dumped by @desirepro
// Assembly: ParadoxNotion.dll
// Classes:  1331
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: SetEnumFlag
TYPE:  class
TOKEN: 0x2000002
EXTENDS: ActionTask
FIELDS:
  public    readonly NodeCanvas.Framework.Internal.BBObjectParameterVariable  // 0x68
  public    readonly NodeCanvas.Framework.Internal.BBObjectParameterFlag  // 0x70
  public    readonly NodeCanvas.Framework.BBParameter<System.Boolean>Clear  // 0x78
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: CheckEnumFlag
TYPE:  class
TOKEN: 0x2000003
EXTENDS: ConditionTask
FIELDS:
  public    readonly NodeCanvas.Framework.Internal.BBObjectParameterVariable  // 0x68
  public    readonly NodeCanvas.Framework.Internal.BBObjectParameterFlag  // 0x70
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: ReturnData
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  private           FlowCanvas.FlowReturn           <returnCall>k__BackingField  // 0x10
  private           System.Type                     <returnType>k__BackingField  // 0x18
METHODS:
  FlowCanvas.FlowReturn get_returnCall()
  System.Void set_returnCall(FlowCanvas.FlowReturn value)
  System.Type get_returnType()
  System.Void set_returnType(System.Type value)
  System.Void .ctor(FlowCanvas.FlowReturn call, System.Type type)
END_CLASS

CLASS: ContextDefinedInputsAttribute
TYPE:  class
TOKEN: 0x2000015
EXTENDS: Attribute
FIELDS:
  public    readonly System.Type[]                   types  // 0x10
METHODS:
  System.Void .ctor(System.Type[] types)
END_CLASS

CLASS: ContextDefinedOutputsAttribute
TYPE:  class
TOKEN: 0x2000016
EXTENDS: Attribute
FIELDS:
  public    readonly System.Type[]                   types  // 0x10
METHODS:
  System.Void .ctor(System.Type[] types)
END_CLASS

CLASS: HasRefreshButtonAttribute
TYPE:  class
TOKEN: 0x2000017
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: GatherPortsCallbackAttribute
TYPE:  class
TOKEN: 0x2000018
EXTENDS: CallbackAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: BindStatus
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  FlowCanvas.Port.BindStatus      Valid  // 0x0
  public    static  FlowCanvas.Port.BindStatus      Missing  // 0x0
  public    static  FlowCanvas.Port.BindStatus      InvalidCast  // 0x0
METHODS:
END_CLASS

CLASS: CustomConverter
TYPE:  class
TOKEN: 0x200002F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  FlowCanvas.ValueHandler<System.Object> Invoke(System.Type sourceType, System.Type targetType, FlowCanvas.ValueHandler<System.Object> func)
  System.IAsyncResult BeginInvoke(System.Type sourceType, System.Type targetType, FlowCanvas.ValueHandler<System.Object> func, System.AsyncCallback callback, System.Object object)
  FlowCanvas.ValueHandler<System.Object> EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: CustomCanConvert
TYPE:  class
TOKEN: 0x2000030
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Nullable<System.Boolean> Invoke(System.Type sourceType, System.Type targetType)
  System.IAsyncResult BeginInvoke(System.Type sourceType, System.Type targetType, System.AsyncCallback callback, System.Object object)
  System.Nullable<System.Boolean> EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: TargetMode
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  public            System.Int32                    value__  // 0x0
  public    static  FlowCanvas.Nodes.RouterEventNode.TargetMode<T>SingleTarget  // 0x0
  public    static  FlowCanvas.Nodes.RouterEventNode.TargetMode<T>MultipleTargets  // 0x0
METHODS:
END_CLASS

CLASS: ButtonKeys
TYPE:  struct
TOKEN: 0x200005E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  FlowCanvas.Nodes.MouseEvents.ButtonKeysLeft  // 0x0
  public    static  FlowCanvas.Nodes.MouseEvents.ButtonKeysRight  // 0x0
  public    static  FlowCanvas.Nodes.MouseEvents.ButtonKeysMiddle  // 0x0
METHODS:
END_CLASS

CLASS: ButtonKeys
TYPE:  struct
TOKEN: 0x2000060
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  FlowCanvas.Nodes.MousePickEvent.ButtonKeysLeft  // 0x0
  public    static  FlowCanvas.Nodes.MousePickEvent.ButtonKeysRight  // 0x0
  public    static  FlowCanvas.Nodes.MousePickEvent.ButtonKeysMiddle  // 0x0
METHODS:
END_CLASS

CLASS: InvocationMode
TYPE:  struct
TOKEN: 0x200018B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  FlowCanvas.Nodes.LatentActionNodeBase.InvocationModeQueueCalls  // 0x0
  public    static  FlowCanvas.Nodes.LatentActionNodeBase.InvocationModeFilterCalls  // 0x0
METHODS:
END_CLASS

CLASS: RoutineData
TYPE:  struct
TOKEN: 0x200018C
FIELDS:
  public            System.Collections.IEnumerator  enumerator  // 0x10
  public            FlowCanvas.Flow                 flow  // 0x18
METHODS:
  System.Void .ctor(System.Collections.IEnumerator enumerator, FlowCanvas.Flow flow)
END_CLASS

CLASS: DelegateEventCallback
TYPE:  class
TOKEN: 0x20001D7
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object[] args)
  System.IAsyncResult BeginInvoke(System.Object[] args, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: UnityEventCallback
TYPE:  class
TOKEN: 0x20001DA
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object[] args)
  System.IAsyncResult BeginInvoke(System.Object[] args, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: AccessMode
TYPE:  struct
TOKEN: 0x20001EE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  FlowCanvas.Nodes.ReflectedFieldNodeWrapper.AccessModeGetField  // 0x0
  public    static  FlowCanvas.Nodes.ReflectedFieldNodeWrapper.AccessModeSetField  // 0x0
METHODS:
END_CLASS

CLASS: DerivedSerializationData
TYPE:  class
TOKEN: 0x2000274
FIELDS:
  public            System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition>inputDefinitions  // 0x10
  public            System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition>outputDefinitions  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: BoolSetModes
TYPE:  struct
TOKEN: 0x20002FB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Tasks.Actions.SetBoolean.BoolSetModesFalse  // 0x0
  public    static  NodeCanvas.Tasks.Actions.SetBoolean.BoolSetModesTrue  // 0x0
  public    static  NodeCanvas.Tasks.Actions.SetBoolean.BoolSetModesToggle  // 0x0
METHODS:
END_CLASS

CLASS: SetActiveMode
TYPE:  struct
TOKEN: 0x2000322
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Tasks.Actions.SetObjectActive.SetActiveModeDeactivate  // 0x0
  public    static  NodeCanvas.Tasks.Actions.SetObjectActive.SetActiveModeActivate  // 0x0
  public    static  NodeCanvas.Tasks.Actions.SetObjectActive.SetActiveModeToggle  // 0x0
METHODS:
END_CLASS

CLASS: SetEnableMode
TYPE:  struct
TOKEN: 0x2000324
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Tasks.Actions.SetObjectEnabled.SetEnableModeDisable  // 0x0
  public    static  NodeCanvas.Tasks.Actions.SetObjectEnabled.SetEnableModeEnable  // 0x0
  public    static  NodeCanvas.Tasks.Actions.SetObjectEnabled.SetEnableModeToggle  // 0x0
METHODS:
END_CLASS

CLASS: SetVisibleMode
TYPE:  struct
TOKEN: 0x2000326
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Tasks.Actions.SetObjectVisibility.SetVisibleModeHide  // 0x0
  public    static  NodeCanvas.Tasks.Actions.SetObjectVisibility.SetVisibleModeShow  // 0x0
  public    static  NodeCanvas.Tasks.Actions.SetObjectVisibility.SetVisibleModeToggle  // 0x0
METHODS:
END_CLASS

CLASS: ButtonKeys
TYPE:  struct
TOKEN: 0x200032B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Tasks.Actions.WaitMousePick.ButtonKeysLeft  // 0x0
  public    static  NodeCanvas.Tasks.Actions.WaitMousePick.ButtonKeysRight  // 0x0
  public    static  NodeCanvas.Tasks.Actions.WaitMousePick.ButtonKeysMiddle  // 0x0
METHODS:
END_CLASS

CLASS: ButtonKeys
TYPE:  struct
TOKEN: 0x200032D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Tasks.Actions.WaitMousePick2D.ButtonKeysLeft  // 0x0
  public    static  NodeCanvas.Tasks.Actions.WaitMousePick2D.ButtonKeysRight  // 0x0
  public    static  NodeCanvas.Tasks.Actions.WaitMousePick2D.ButtonKeysMiddle  // 0x0
METHODS:
END_CLASS

CLASS: TransformMode
TYPE:  struct
TOKEN: 0x200032F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Tasks.Actions.CurveTransformTween.TransformModePosition  // 0x0
  public    static  NodeCanvas.Tasks.Actions.CurveTransformTween.TransformModeRotation  // 0x0
  public    static  NodeCanvas.Tasks.Actions.CurveTransformTween.TransformModeScale  // 0x0
METHODS:
END_CLASS

CLASS: TweenMode
TYPE:  struct
TOKEN: 0x2000330
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Tasks.Actions.CurveTransformTween.TweenModeAbsolute  // 0x0
  public    static  NodeCanvas.Tasks.Actions.CurveTransformTween.TweenModeAdditive  // 0x0
METHODS:
END_CLASS

CLASS: PlayMode
TYPE:  struct
TOKEN: 0x2000331
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Tasks.Actions.CurveTransformTween.PlayModeNormal  // 0x0
  public    static  NodeCanvas.Tasks.Actions.CurveTransformTween.PlayModePingPong  // 0x0
METHODS:
END_CLASS

CLASS: LogMode
TYPE:  struct
TOKEN: 0x2000352
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Tasks.Actions.DebugLogText.LogModeLog  // 0x0
  public    static  NodeCanvas.Tasks.Actions.DebugLogText.LogModeWarning  // 0x0
  public    static  NodeCanvas.Tasks.Actions.DebugLogText.LogModeError  // 0x0
METHODS:
END_CLASS

CLASS: VerboseMode
TYPE:  struct
TOKEN: 0x2000353
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Tasks.Actions.DebugLogText.VerboseModeLogAndDisplayLabel  // 0x0
  public    static  NodeCanvas.Tasks.Actions.DebugLogText.VerboseModeLogOnly  // 0x0
  public    static  NodeCanvas.Tasks.Actions.DebugLogText.VerboseModeDisplayLabelOnly  // 0x0
METHODS:
END_CLASS

CLASS: Control
TYPE:  struct
TOKEN: 0x2000357
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Tasks.Actions.GraphOwnerControl.ControlStartBehaviour  // 0x0
  public    static  NodeCanvas.Tasks.Actions.GraphOwnerControl.ControlStopBehaviour  // 0x0
  public    static  NodeCanvas.Tasks.Actions.GraphOwnerControl.ControlPauseBehaviour  // 0x0
METHODS:
END_CLASS

CLASS: TransitionCallMode
TYPE:  struct
TOKEN: 0x2000367
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.StateMachines.FSM.TransitionCallModeNormal  // 0x0
  public    static  NodeCanvas.StateMachines.FSM.TransitionCallModeStacked  // 0x0
  public    static  NodeCanvas.StateMachines.FSM.TransitionCallModeClean  // 0x0
METHODS:
END_CLASS

CLASS: TransitionEvaluationMode
TYPE:  struct
TOKEN: 0x200036F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.StateMachines.FSMState.TransitionEvaluationModeCheckContinuously  // 0x0
  public    static  NodeCanvas.StateMachines.FSMState.TransitionEvaluationModeCheckAfterStateFinished  // 0x0
  public    static  NodeCanvas.StateMachines.FSMState.TransitionEvaluationModeCheckManually  // 0x0
METHODS:
END_CLASS

CLASS: BTExecutionMode
TYPE:  struct
TOKEN: 0x2000379
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.StateMachines.NestedBTState.BTExecutionModeOnce  // 0x0
  public    static  NodeCanvas.StateMachines.NestedBTState.BTExecutionModeRepeat  // 0x0
METHODS:
END_CLASS

CLASS: BTExitMode
TYPE:  struct
TOKEN: 0x200037A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.StateMachines.NestedBTState.BTExitModeStopAndRestart  // 0x0
  public    static  NodeCanvas.StateMachines.NestedBTState.BTExitModePauseAndResume  // 0x0
METHODS:
END_CLASS

CLASS: FSMExitMode
TYPE:  struct
TOKEN: 0x200037D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.StateMachines.NestedFSMState.FSMExitModeStopAndRestart  // 0x0
  public    static  NodeCanvas.StateMachines.NestedFSMState.FSMExitModePauseAndResume  // 0x0
METHODS:
END_CLASS

CLASS: DerivedSerializationData
TYPE:  class
TOKEN: 0x200038A
FIELDS:
  public            System.Collections.Generic.List<NodeCanvas.DialogueTrees.DialogueTree.ActorParameter>actorParameters  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ActorParameter
TYPE:  class
TOKEN: 0x200038B
FIELDS:
  private           System.String                   _keyName  // 0x10
  private           System.String                   _id  // 0x18
  private           UnityEngine.Object              _actorObject  // 0x20
  private           NodeCanvas.DialogueTrees.IDialogueActor_actor  // 0x28
METHODS:
  System.String get_name()
  System.Void set_name(System.String value)
  System.String get_ID()
  NodeCanvas.DialogueTrees.IDialogueActor get_actor()
  System.Void set_actor(NodeCanvas.DialogueTrees.IDialogueActor value)
  System.Void .ctor()
  System.Void .ctor(System.String name)
  System.Void .ctor(System.String name, NodeCanvas.DialogueTrees.IDialogueActor actor)
  System.String ToString()
END_CLASS

CLASS: Choice
TYPE:  class
TOKEN: 0x20003A1
FIELDS:
  public            System.Boolean                  isUnfolded  // 0x10
  public            NodeCanvas.DialogueTrees.Statementstatement  // 0x18
  public            NodeCanvas.Framework.ConditionTaskcondition  // 0x20
METHODS:
  System.Void .ctor()
  System.Void .ctor(NodeCanvas.DialogueTrees.Statement statement)
END_CLASS

CLASS: Option
TYPE:  class
TOKEN: 0x20003A5
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Single>weight  // 0x10
  public            NodeCanvas.Framework.ConditionTaskcondition  // 0x18
METHODS:
  System.Void .ctor(System.Single weightValue, NodeCanvas.Framework.IBlackboard bbValue)
END_CLASS

CLASS: SubtitleDelays
TYPE:  class
TOKEN: 0x20003AB
FIELDS:
  public            System.Single                   characterDelay  // 0x10
  public            System.Single                   sentenceDelay  // 0x14
  public            System.Single                   commaDelay  // 0x18
  public            System.Single                   finalDelay  // 0x1C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: DerivedSerializationData
TYPE:  class
TOKEN: 0x20003B4
FIELDS:
  public            System.Boolean                  repeat  // 0x10
  public            System.Single                   updateInterval  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParallelPolicy
TYPE:  struct
TOKEN: 0x20003BE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.BehaviourTrees.Parallel.ParallelPolicyFirstFailure  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Parallel.ParallelPolicyFirstSuccess  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Parallel.ParallelPolicyFirstSuccessOrFailure  // 0x0
METHODS:
END_CLASS

CLASS: Desire
TYPE:  class
TOKEN: 0x20003C1
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Boolean                  foldout  // 0x18
  public            System.Collections.Generic.List<NodeCanvas.BehaviourTrees.PrioritySelector.Consideration>considerations  // 0x20
METHODS:
  NodeCanvas.BehaviourTrees.PrioritySelector.Consideration AddConsideration(NodeCanvas.Framework.IBlackboard bb)
  System.Void RemoveConsideration(NodeCanvas.BehaviourTrees.PrioritySelector.Consideration consideration)
  System.Single GetCompoundUtility()
  System.Void .ctor()
END_CLASS

CLASS: Consideration
TYPE:  class
TOKEN: 0x20003C2
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Single>input  // 0x10
  public            NodeCanvas.Framework.BBParameter<UnityEngine.AnimationCurve>function  // 0x18
METHODS:
  System.Single get_utility()
  System.Void .ctor(NodeCanvas.Framework.IBlackboard blackboard)
END_CLASS

CLASS: CaseSelectionMode
TYPE:  struct
TOKEN: 0x20003C8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.BehaviourTrees.Switch.CaseSelectionModeIndexBased  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Switch.CaseSelectionModeEnumBased  // 0x0
METHODS:
END_CLASS

CLASS: OutOfRangeMode
TYPE:  struct
TOKEN: 0x20003C9
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.BehaviourTrees.Switch.OutOfRangeModeReturnFailure  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Switch.OutOfRangeModeLoopIndex  // 0x0
METHODS:
END_CLASS

CLASS: FilterMode
TYPE:  struct
TOKEN: 0x20003CC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.BehaviourTrees.Filter.FilterModeLimitNumberOfTimes  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Filter.FilterModeCoolDown  // 0x0
METHODS:
END_CLASS

CLASS: Policy
TYPE:  struct
TOKEN: 0x20003CD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.BehaviourTrees.Filter.PolicySuccessOrFailure  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Filter.PolicySuccessOnly  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Filter.PolicyFailureOnly  // 0x0
METHODS:
END_CLASS

CLASS: GuardMode
TYPE:  struct
TOKEN: 0x20003D0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.BehaviourTrees.Guard.GuardModeReturnFailure  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Guard.GuardModeWaitUntilReleased  // 0x0
METHODS:
END_CLASS

CLASS: TerminationConditions
TYPE:  struct
TOKEN: 0x20003D4
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.BehaviourTrees.Iterator.TerminationConditionsNone  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Iterator.TerminationConditionsFirstSuccess  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Iterator.TerminationConditionsFirstFailure  // 0x0
METHODS:
END_CLASS

CLASS: MonitorMode
TYPE:  struct
TOKEN: 0x20003D7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.BehaviourTrees.Monitor.MonitorModeFailure  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Monitor.MonitorModeSuccess  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Monitor.MonitorModeAnyStatus  // 0x0
METHODS:
END_CLASS

CLASS: ReturnStatusMode
TYPE:  struct
TOKEN: 0x20003D8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.BehaviourTrees.Monitor.ReturnStatusModeOriginalDecoratedChildStatus  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Monitor.ReturnStatusModeNewDecoratorActionStatus  // 0x0
METHODS:
END_CLASS

CLASS: RemapStatus
TYPE:  struct
TOKEN: 0x20003DB
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.BehaviourTrees.Remapper.RemapStatusFailure  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Remapper.RemapStatusSuccess  // 0x0
METHODS:
END_CLASS

CLASS: RepeaterMode
TYPE:  struct
TOKEN: 0x20003DD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.BehaviourTrees.Repeater.RepeaterModeRepeatTimes  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Repeater.RepeaterModeRepeatUntil  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Repeater.RepeaterModeRepeatForever  // 0x0
METHODS:
END_CLASS

CLASS: RepeatUntilStatus
TYPE:  struct
TOKEN: 0x20003DE
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.BehaviourTrees.Repeater.RepeatUntilStatusFailure  // 0x0
  public    static  NodeCanvas.BehaviourTrees.Repeater.RepeatUntilStatusSuccess  // 0x0
METHODS:
END_CLASS

CLASS: ToggleMode
TYPE:  struct
TOKEN: 0x20003E8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.BehaviourTrees.NodeToggler.ToggleModeEnable  // 0x0
  public    static  NodeCanvas.BehaviourTrees.NodeToggler.ToggleModeDisable  // 0x0
  public    static  NodeCanvas.BehaviourTrees.NodeToggler.ToggleModeToggle  // 0x0
METHODS:
END_CLASS

CLASS: InvokeArguments
TYPE:  class
TOKEN: 0x20003F0
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.Transform sender, UnityEngine.Transform receiver, System.Boolean isGlobal, System.Object[] args)
  System.IAsyncResult BeginInvoke(UnityEngine.Transform sender, UnityEngine.Transform receiver, System.Boolean isGlobal, System.Object[] args, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: UpdateMode
TYPE:  struct
TOKEN: 0x20003F7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Framework.Graph.UpdateModeNormalUpdate  // 0x0
  public    static  NodeCanvas.Framework.Graph.UpdateModeLateUpdate  // 0x0
  public    static  NodeCanvas.Framework.Graph.UpdateModeFixedUpdate  // 0x0
  public    static  NodeCanvas.Framework.Graph.UpdateModeManual  // 0x0
METHODS:
END_CLASS

CLASS: EnableAction
TYPE:  struct
TOKEN: 0x2000406
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Framework.GraphOwner.EnableActionEnableBehaviour  // 0x0
  public    static  NodeCanvas.Framework.GraphOwner.EnableActionDoNothing  // 0x0
METHODS:
END_CLASS

CLASS: DisableAction
TYPE:  struct
TOKEN: 0x2000407
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Framework.GraphOwner.DisableActionDisableBehaviour  // 0x0
  public    static  NodeCanvas.Framework.GraphOwner.DisableActionPauseBehaviour  // 0x0
  public    static  NodeCanvas.Framework.GraphOwner.DisableActionDoNothing  // 0x0
METHODS:
END_CLASS

CLASS: FirstActivation
TYPE:  struct
TOKEN: 0x2000408
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Framework.GraphOwner.FirstActivationOnEnable  // 0x0
  public    static  NodeCanvas.Framework.GraphOwner.FirstActivationOnStart  // 0x0
  public    static  NodeCanvas.Framework.GraphOwner.FirstActivationAsync  // 0x0
METHODS:
END_CLASS

CLASS: SubInfo
TYPE:  class
TOKEN: 0x2000409
FIELDS:
  public            NodeCanvas.Framework.Graph      graph  // 0x10
  public            NodeCanvas.Framework.Graph      originalGraph  // 0x18
  public            NodeCanvas.Framework.Graph      parentGraph  // 0x20
  public            System.String                   name  // 0x28
  public            NodeCanvas.Framework.IGraphAssignableassignable  // 0x30
  public            System.Boolean                  isSuc  // 0x38
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: AutoSortWithChildrenConnections
TYPE:  class
TOKEN: 0x2000420
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ActionsExecutionMode
TYPE:  struct
TOKEN: 0x200042B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Framework.ActionList.ActionsExecutionModeActionsRunInSequence  // 0x0
  public    static  NodeCanvas.Framework.ActionList.ActionsExecutionModeActionsRunInParallel  // 0x0
METHODS:
END_CLASS

CLASS: ConditionsCheckMode
TYPE:  struct
TOKEN: 0x2000430
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Framework.ConditionList.ConditionsCheckModeAllTrueRequired  // 0x0
  public    static  NodeCanvas.Framework.ConditionList.ConditionsCheckModeAnyTrueSuffice  // 0x0
METHODS:
END_CLASS

CLASS: GetFromAgentAttribute
TYPE:  class
TOKEN: 0x2000437
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SingletonMode
TYPE:  struct
TOKEN: 0x2000441
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Framework.GlobalBlackboard.SingletonModeDestroyComponentOnly  // 0x0
  public    static  NodeCanvas.Framework.GlobalBlackboard.SingletonModeDestroyEntireGameObject  // 0x0
METHODS:
END_CLASS

CLASS: Element
TYPE:  class
TOKEN: 0x2000492
FIELDS:
  private           System.Object                   _reference  // 0x10
  private           ParadoxNotion.HierarchyTree.Element_parent  // 0x18
  private           System.Collections.Generic.List<ParadoxNotion.HierarchyTree.Element>_children  // 0x20
METHODS:
  System.Object get_reference()
  ParadoxNotion.HierarchyTree.Element get_parent()
  System.Collections.Generic.IEnumerable<ParadoxNotion.HierarchyTree.Element> get_children()
  System.Void .ctor(System.Object reference)
  ParadoxNotion.HierarchyTree.Element AddChild(ParadoxNotion.HierarchyTree.Element child)
  System.Void RemoveChild(ParadoxNotion.HierarchyTree.Element child)
  ParadoxNotion.HierarchyTree.Element GetRoot()
  ParadoxNotion.HierarchyTree.Element FindReferenceElement(System.Object target)
  T GetFirstParentReferenceOfType()
  System.Collections.Generic.IEnumerable<T> GetAllChildrenReferencesOfType()
END_CLASS

CLASS: MethodType
TYPE:  struct
TOKEN: 0x2000499
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.ReflectionTools.MethodTypeNormal  // 0x0
  public    static  ParadoxNotion.ReflectionTools.MethodTypePropertyAccessor  // 0x0
  public    static  ParadoxNotion.ReflectionTools.MethodTypeEvent  // 0x0
  public    static  ParadoxNotion.ReflectionTools.MethodTypeOperator  // 0x0
METHODS:
END_CLASS

CLASS: CustomConverter
TYPE:  class
TOKEN: 0x20004A0
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Func<System.Object,System.Object> Invoke(System.Type fromType, System.Type toType)
  System.IAsyncResult BeginInvoke(System.Type fromType, System.Type toType, System.AsyncCallback callback, System.Object object)
  System.Func<System.Object,System.Object> EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: EventDelegate
TYPE:  class
TOKEN: 0x20004AE
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(ParadoxNotion.EventData msg)
  System.IAsyncResult BeginInvoke(ParadoxNotion.EventData msg, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: EventDelegate`1
TYPE:  class
TOKEN: 0x20004AF
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(ParadoxNotion.EventData<T> msg)
  System.IAsyncResult BeginInvoke(ParadoxNotion.EventData<T> msg, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: CustomEventDelegate
TYPE:  class
TOKEN: 0x20004B0
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.String name, ParadoxNotion.IEventData data)
  System.IAsyncResult BeginInvoke(System.String name, ParadoxNotion.IEventData data, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: Message
TYPE:  struct
TOKEN: 0x20004B3
FIELDS:
  private           System.WeakReference<System.Object>_contextRef  // 0x10
  public            UnityEngine.LogType             type  // 0x18
  public            System.String                   text  // 0x20
  public            System.String                   tag  // 0x28
METHODS:
  System.Object get_context()
  System.Void set_context(System.Object value)
  System.Boolean IsValid()
END_CLASS

CLASS: LogHandler
TYPE:  class
TOKEN: 0x20004B4
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(ParadoxNotion.Services.Logger.Message message)
  System.IAsyncResult BeginInvoke(ParadoxNotion.Services.Logger.Message message, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: UpdateMode
TYPE:  struct
TOKEN: 0x20004B6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.Services.MonoManager.UpdateModeNormalUpdate  // 0x0
  public    static  ParadoxNotion.Services.MonoManager.UpdateModeLateUpdate  // 0x0
  public    static  ParadoxNotion.Services.MonoManager.UpdateModeFixedUpdate  // 0x0
METHODS:
END_CLASS

CLASS: ObjectReferenceEqualityComparator
TYPE:  class
TOKEN: 0x20004E6
FIELDS:
  public    static readonly System.Collections.Generic.IEqualityComparer<System.Object>Instance  // 0x0
METHODS:
  System.Boolean System.Collections.Generic.IEqualityComparer<System.Object>.Equals(System.Object x, System.Object y)
  System.Int32 System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(System.Object obj)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: ObjectGenerator
TYPE:  class
TOKEN: 0x20004F0
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Object Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  System.Object EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: fsLazyCycleDefinitionWriter
TYPE:  class
TOKEN: 0x20004F6
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Int32,ParadoxNotion.Serialization.FullSerializer.fsData>_pendingDefinitions  // 0x10
  private           System.Collections.Generic.HashSet<System.Int32>_references  // 0x18
METHODS:
  System.Void WriteDefinition(System.Int32 id, ParadoxNotion.Serialization.FullSerializer.fsData data)
  System.Void WriteReference(System.Int32 id, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> dict)
  System.Void Clear()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000006
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
TOKEN: 0x2000007
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000008
EXTENDS: Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.BinderConnection`1
TYPE:  class
TOKEN: 0x2000009
EXTENDS: BinderConnection
FIELDS:
METHODS:
  System.Void Bind()
  System.Void UnBind()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.BinderConnection
TYPE:  class
TOKEN: 0x200000A
EXTENDS: Connection
FIELDS:
  private           System.String                   _sourcePortID  // 0x30
  private           System.String                   _targetPortID  // 0x38
  private           FlowCanvas.Port                 _sourcePort  // 0x40
  private           FlowCanvas.Port                 _targetPort  // 0x48
METHODS:
  System.String get_sourcePortID()
  System.Void set_sourcePortID(System.String value)
  System.String get_targetPortID()
  System.Void set_targetPortID(System.String value)
  FlowCanvas.Port get_sourcePort()
  FlowCanvas.Port get_targetPort()
  System.Type get_bindingType()
  FlowCanvas.BinderConnection Create(FlowCanvas.Port source, FlowCanvas.Port target, System.Boolean recodeUndo, System.Boolean invokeGraphChanged)
  System.Void SetSourcePort(FlowCanvas.Port newSourcePort)
  System.Void SetTargetPort(FlowCanvas.Port newTargetPort)
  System.Void GatherAndValidateSourcePort()
  System.Void GatherAndValidateTargetPort()
  System.Boolean CanBeBound(FlowCanvas.Port source, FlowCanvas.Port target, FlowCanvas.BinderConnection refConnection)
  System.Boolean CanBeBoundVerbosed(FlowCanvas.Port source, FlowCanvas.Port target, FlowCanvas.BinderConnection refConnection, System.String& verbose)
  System.String CanBeBoundVerbosed_Internal(FlowCanvas.Port source, FlowCanvas.Port target, FlowCanvas.BinderConnection refConnection)
  System.Void OnDestroy()
  System.Void OnDestroyAfterConnectionRemoved()
  System.Void Bind()
  System.Void UnBind()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.FlowHandler
TYPE:  class
TOKEN: 0x200000C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(FlowCanvas.Flow f)
  System.IAsyncResult BeginInvoke(FlowCanvas.Flow f, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.ValueHandler`1
TYPE:  class
TOKEN: 0x200000D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  T Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  T EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.ValueHandlerObject
TYPE:  class
TOKEN: 0x200000E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Object Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  System.Object EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.FlowBreak
TYPE:  class
TOKEN: 0x200000F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.FlowReturn
TYPE:  class
TOKEN: 0x2000010
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(System.Object value)
  System.IAsyncResult BeginInvoke(System.Object value, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.Flow
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  private           System.Int32                    <ticks>k__BackingField  // 0x10
  private           System.Collections.Generic.Dictionary<System.String,System.Object>parameters  // 0x18
  private           FlowCanvas.Flow.ReturnData      returnData  // 0x20
  private           FlowCanvas.FlowBreak            breakCall  // 0x30
METHODS:
  System.Int32 get_ticks()
  System.Void set_ticks(System.Int32 value)
  FlowCanvas.Flow get_New()
  System.Void Call(FlowCanvas.FlowOutput port)
  T ReadParameter(System.String name)
  System.Void WriteParameter(System.String name, T value)
  System.Void SetReturnData(FlowCanvas.FlowReturn call, System.Type expectedType)
  System.Void Return(System.Object value, FlowCanvas.FlowNode context)
  System.Void BeginBreakBlock(FlowCanvas.FlowBreak callback)
  System.Void EndBreakBlock()
  System.Void Break(FlowCanvas.FlowNode context)
END_CLASS

CLASS: FlowCanvas.FlowGraph
TYPE:  class
TOKEN: 0x2000013
EXTENDS: Graph
FIELDS:
  private           System.Collections.Generic.List<NodeCanvas.Framework.IUpdatable>updatableNodes  // 0xA0
  private           System.Collections.Generic.List<FlowCanvas.Macros.MacroNodeWrapper>macroWrappers  // 0xA8
  private           System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.IInvokable>functions  // 0xB0
  private           System.Collections.Generic.Dictionary<System.Type,UnityEngine.Component>cachedAgentComponents  // 0xB8
METHODS:
  System.Type get_baseNodeType()
  System.Boolean get_allowBlackboardOverrides()
  System.Boolean get_requiresAgent()
  System.Boolean get_requiresPrimeNode()
  System.Boolean get_isTree()
  System.Boolean get_canAcceptVariableDrops()
  T CallFunction(System.String name, System.Object[] args)
  System.Object CallFunction(System.String name, System.Object[] args)
  System.Void CallFunctionAsync(System.String name, System.Action<System.Object> callback, System.Object[] args)
  UnityEngine.Object GetAgentComponent(System.Type type)
  System.Void OnGraphInitialize()
  System.Void InitSecondPass()
  System.Void OnGraphStarted()
  System.Void OnGraphUpdate()
  System.Void OnGraphStoped()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.FlowNode
TYPE:  class
TOKEN: 0x2000014
EXTENDS: Node
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,System.Object>_inputPortValues  // 0x98
  protected         System.Collections.Generic.Dictionary<System.String,FlowCanvas.Port>inputPorts  // 0xA0
  protected         System.Collections.Generic.Dictionary<System.String,FlowCanvas.Port>outputPorts  // 0xA8
METHODS:
  System.Boolean get_allowDragInContentRect()
  System.Nullable<System.Single> get_overrideNodeWidth()
  System.Int32 get_maxInConnections()
  System.Int32 get_maxOutConnections()
  System.Boolean get_allowAsPrime()
  System.Boolean get_canSelfConnect()
  System.Type get_outConnectionType()
  ParadoxNotion.Alignment2x2 get_commentsAlignment()
  ParadoxNotion.Alignment2x2 get_iconAlignment()
  FlowCanvas.FlowGraph get_flowGraph()
  System.String get_SPACE()
  System.Boolean get_ignoreSelfInstancePortAssignment()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void OnValidate(NodeCanvas.Framework.Graph flowGraph)
  System.Void OnParentConnected(System.Int32 i)
  System.Void OnChildConnected(System.Int32 i)
  System.Void OnParentDisconnected(System.Int32 i)
  System.Void OnChildDisconnected(System.Int32 i)
  System.Void OnPortConnected(FlowCanvas.Port port, FlowCanvas.Port otherPort)
  System.Void OnPortDisconnected(FlowCanvas.Port port, FlowCanvas.Port otherPort)
  System.Void OnPortDisconnectedLate(FlowCanvas.Port port, FlowCanvas.Port otherPort)
  System.Void BindPorts()
  System.Void UnBindPorts()
  FlowCanvas.Port GetInputPort(System.String ID)
  FlowCanvas.Port GetOutputPort(System.String ID)
  System.Collections.Generic.IEnumerable<FlowCanvas.Port> GetAllPorts()
  System.Collections.Generic.IEnumerable<FlowCanvas.FlowOutput> GetOutputFlowPorts()
  System.Collections.Generic.IEnumerable<FlowCanvas.ValueOutput> GetOutputValuePorts()
  System.Collections.Generic.IEnumerable<FlowCanvas.FlowInput> GetInputFlowPorts()
  System.Collections.Generic.IEnumerable<FlowCanvas.ValueInput> GetInputValuePorts()
  FlowCanvas.Port GetFirstInputOfType(System.Type type)
  FlowCanvas.Port GetFirstOutputOfType(System.Type type)
  System.Void AssignSelfInstancePort()
  System.Void GatherPorts()
  System.Void RegisterPorts()
  System.Void ValidateConnections()
  System.Void DeserializeInputPortValues()
  System.Void RefreshEditorPorts()
  FlowCanvas.FlowInput AddFlowInput(System.String name, System.String ID, FlowCanvas.FlowHandler pointer)
  FlowCanvas.FlowInput AddFlowInput(System.String name, FlowCanvas.FlowHandler pointer, System.String ID)
  FlowCanvas.FlowOutput AddFlowOutput(System.String name, System.String ID)
  FlowCanvas.ValueInput<T> AddValueInput(System.String name, System.String ID)
  FlowCanvas.ValueOutput<T> AddValueOutput(System.String name, System.String ID, FlowCanvas.ValueHandler<T> getter)
  FlowCanvas.ValueOutput<T> AddValueOutput(System.String name, FlowCanvas.ValueHandler<T> getter, System.String ID)
  System.Void AddValueInput(System.Type valueType, System.String name, System.String ID)
  FlowCanvas.ValueOutput<T> AddValueOutput(System.String name, System.String ID)
  System.Void AddValueOutput(System.Type valueType, System.String name, System.String ID)
  FlowCanvas.ValueInput AddValueInput(System.String name, System.String ID, System.Type type)
  FlowCanvas.ValueInput AddValueInput(System.String name, System.Type type, System.String ID)
  FlowCanvas.ValueOutput AddValueOutput(System.String name, System.String ID, System.Type type, FlowCanvas.ValueHandlerObject getter)
  FlowCanvas.ValueOutput AddValueOutput(System.String name, System.Type type, FlowCanvas.ValueHandlerObject getter, System.String ID)
  System.Void QualifyPortNameAndID(System.String& name, System.String& ID, System.Collections.IDictionary dict)
  System.Boolean CheckReverseIDEquality(FlowCanvas.Port port, System.String requestedID)
  System.Void TryAddReflectionBasedRegistrationForObject(System.Object instance)
  FlowCanvas.FlowInput TryAddMethodFlowInput(System.Reflection.MethodInfo method, System.Object instance)
  FlowCanvas.FlowOutput TryAddFieldDelegateFlowOutput(System.Reflection.FieldInfo field, System.Object instance)
  FlowCanvas.ValueInput TryAddFieldDelegateValueInput(System.Reflection.FieldInfo field, System.Object instance)
  FlowCanvas.ValueOutput TryAddPropertyValueOutput(System.Reflection.PropertyInfo prop, System.Object instance)
  FlowCanvas.FlowNode ReplaceWith(System.Type t)
  System.Void TryRemovePortIfMissingAndClean(FlowCanvas.Port port)
  System.Type GetNodeWildDefinitionType()
  System.Void TryHandleWildPortConnection(System.Type currentType, System.Type targetType)
  System.Type TryGetNewGenericTypeForWild(System.Type wildType, System.Type currentType, System.Type targetType, System.Type content, System.Type context)
  System.Reflection.MethodInfo TryGetNewGenericMethodForWild(System.Type wildType, System.Type currentType, System.Type targetType, System.Reflection.MethodInfo content)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.FlowNodeNested`1
TYPE:  class
TOKEN: 0x200001F
EXTENDS: FlowNode
FIELDS:
  private           System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter>_variablesMap  // 0x0
  private           T                               <currentInstance>k__BackingField  // 0x0
  private           System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph><instances>k__BackingField  // 0x0
METHODS:
  T get_subGraph()
  System.Void set_subGraph(T value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  T get_currentInstance()
  System.Void set_currentInstance(T value)
  System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> get_instances()
  System.Void set_instances(System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> value)
  System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> get_variablesMap()
  System.Void set_variablesMap(System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> value)
  NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_subGraph()
  System.Void NodeCanvas.Framework.IGraphAssignable.set_subGraph(NodeCanvas.Framework.Graph value)
  NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_currentInstance()
  System.Void NodeCanvas.Framework.IGraphAssignable.set_currentInstance(NodeCanvas.Framework.Graph value)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.FlowScript
TYPE:  class
TOKEN: 0x2000020
EXTENDS: FlowScriptBase
FIELDS:
METHODS:
  System.Boolean get_canDelayDeserializeAndOptimizeClone()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.FlowScriptBase
TYPE:  class
TOKEN: 0x2000021
EXTENDS: FlowGraph
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.FlowScriptController
TYPE:  class
TOKEN: 0x2000022
EXTENDS: GraphOwner`1
FIELDS:
METHODS:
  System.Void CallFunction(System.String name)
  System.Object CallFunction(System.String name, System.Object[] args)
  System.Void CallFunctionAsync(System.String name, System.Action<System.Object> callback, System.Object[] args)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.IEditorMenuCallbackReceiver
TYPE:  interface
TOKEN: 0x2000023
FIELDS:
METHODS:
END_CLASS

CLASS: FlowCanvas.RenderImageEvent
TYPE:  class
TOKEN: 0x2000024
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           fOut  // 0xC8
  private           UnityEngine.RenderTexture       t1  // 0xD0
  private           UnityEngine.RenderTexture       t2  // 0xD8
METHODS:
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture dest)
  System.Void RegisterPorts()
  System.Void .ctor()
  UnityEngine.RenderTexture <RegisterPorts>b__6_0()
  UnityEngine.RenderTexture <RegisterPorts>b__6_1()
END_CLASS

CLASS: FlowCanvas.Port
TYPE:  class
TOKEN: 0x2000025
FIELDS:
  private           System.Boolean                  <prettifyName>k__BackingField  // 0x10
  private           System.Boolean                  <forceNotDraw>k__BackingField  // 0x11
  private           FlowCanvas.FlowNode             <parent>k__BackingField  // 0x18
  private           System.String                   <ID>k__BackingField  // 0x20
  private           System.String                   <name>k__BackingField  // 0x28
  private           System.Int32                    <connections>k__BackingField  // 0x30
  private           FlowCanvas.Port.BindStatus      <bindStatus>k__BackingField  // 0x34
  private           UnityEngine.GUIContent          <displayContent>k__BackingField  // 0x38
METHODS:
  System.Void .ctor()
  System.Boolean get_prettifyName()
  System.Void set_prettifyName(System.Boolean value)
  System.Boolean get_forceNotDraw()
  System.Void set_forceNotDraw(System.Boolean value)
  System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID)
  FlowCanvas.FlowNode get_parent()
  System.Void set_parent(FlowCanvas.FlowNode value)
  System.String get_ID()
  System.Void set_ID(System.String value)
  System.String get_name()
  System.Void set_name(System.String value)
  System.Int32 get_connections()
  System.Void set_connections(System.Int32 value)
  System.Boolean get_isConnected()
  FlowCanvas.Port.BindStatus get_bindStatus()
  System.Void set_bindStatus(FlowCanvas.Port.BindStatus value)
  UnityEngine.GUIContent get_displayContent()
  System.Void set_displayContent(UnityEngine.GUIContent value)
  System.Type get_type()
  FlowCanvas.Port FlagMissing()
  FlowCanvas.Port FlagInvalidCast()
  FlowCanvas.Port FlagValid()
  System.Boolean CanAcceptConnections()
  System.Collections.Generic.IEnumerable<FlowCanvas.BinderConnection> GetPortConnections()
  FlowCanvas.BinderConnection GetFirstInputConnection()
  FlowCanvas.BinderConnection GetFirstOutputConnection()
  System.Boolean IsFlowPort()
  System.Boolean IsValuePort()
  System.Boolean IsInputPort()
  System.Boolean IsOutputPort()
  System.Boolean IsUnityObject()
  System.Boolean IsUnitySceneObject()
  System.Boolean IsDelegate()
  System.Boolean IsEnumerableCollection()
  System.Boolean IsWild()
  System.String ToString()
  System.Boolean <GetPortConnections>b__43_0(FlowCanvas.BinderConnection c)
  System.Boolean <GetPortConnections>b__43_1(FlowCanvas.BinderConnection c)
  System.Boolean <GetFirstInputConnection>b__44_0(FlowCanvas.BinderConnection c)
  System.Boolean <GetFirstOutputConnection>b__45_0(FlowCanvas.BinderConnection c)
END_CLASS

CLASS: FlowCanvas.FlowInput
TYPE:  class
TOKEN: 0x2000027
EXTENDS: Port
FIELDS:
  private           FlowCanvas.FlowHandler          <pointer>k__BackingField  // 0x40
METHODS:
  System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID, FlowCanvas.FlowHandler pointer)
  FlowCanvas.FlowHandler get_pointer()
  System.Void set_pointer(FlowCanvas.FlowHandler value)
  System.Type get_type()
END_CLASS

CLASS: FlowCanvas.FlowOutput
TYPE:  class
TOKEN: 0x2000028
EXTENDS: Port
FIELDS:
  private           FlowCanvas.FlowHandler          pointer  // 0x40
METHODS:
  System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID)
  System.Void add_pointer(FlowCanvas.FlowHandler value)
  System.Void remove_pointer(FlowCanvas.FlowHandler value)
  System.Type get_type()
  System.Void Call(FlowCanvas.Flow f)
  System.Void BindTo(FlowCanvas.FlowInput target)
  System.Void Append(FlowCanvas.FlowHandler callback)
  System.Void UnBind()
END_CLASS

CLASS: FlowCanvas.ValueInput
TYPE:  class
TOKEN: 0x2000029
EXTENDS: Port
FIELDS:
  private           System.Boolean                  <skipSelfInstanceAssignment>k__BackingField  // 0x40
METHODS:
  System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID)
  FlowCanvas.ValueInput<T> CreateInstance(FlowCanvas.FlowNode parent, System.String name, System.String ID)
  FlowCanvas.ValueInput CreateInstance(System.Type t, FlowCanvas.FlowNode parent, System.String name, System.String ID)
  System.Object get_value()
  FlowCanvas.ValueInput SetDefaultAndSerializedValue(System.Object v)
  FlowCanvas.ValueInput SkipSelfInstanceAssignment(System.Boolean skip)
  System.Boolean get_skipSelfInstanceAssignment()
  System.Void set_skipSelfInstanceAssignment(System.Boolean value)
  System.Object get_defaultValue()
  System.Void set_defaultValue(System.Object value)
  System.Object get_serializedValue()
  System.Void set_serializedValue(System.Object value)
  System.Boolean get_isDefaultValue()
  System.Type get_type()
  System.Void BindTo(FlowCanvas.ValueOutput target)
  System.Void UnBind()
  System.Object GetObjectValue()
END_CLASS

CLASS: FlowCanvas.ValueInput`1
TYPE:  class
TOKEN: 0x200002A
EXTENDS: ValueInput
FIELDS:
  private           FlowCanvas.ValueHandler<T>      getter  // 0x0
  private           System.Action<T>                callback  // 0x0
  private           T                               _value  // 0x0
  private           T                               _defaultValue  // 0x0
METHODS:
  System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID)
  System.Void add_getter(FlowCanvas.ValueHandler<T> value)
  System.Void remove_getter(FlowCanvas.ValueHandler<T> value)
  T get_value()
  System.Object get_defaultValue()
  System.Void set_defaultValue(System.Object value)
  System.Object get_serializedValue()
  System.Void set_serializedValue(System.Object value)
  System.Boolean get_isDefaultValue()
  System.Type get_type()
  FlowCanvas.ValueInput<T> SetDefaultAndSerializedValue(T v)
  T GetValue()
  System.Object GetObjectValue()
  System.Void BindTo(FlowCanvas.ValueOutput source)
  System.Void Append(System.Action<T> callback)
  System.Void UnBind()
  T op_Explicit(FlowCanvas.ValueInput<T> port)
END_CLASS

CLASS: FlowCanvas.ValueOutput
TYPE:  class
TOKEN: 0x200002B
EXTENDS: Port
FIELDS:
METHODS:
  System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID)
  FlowCanvas.ValueOutput<T> CreateInstance(FlowCanvas.FlowNode parent, System.String name, System.String ID, FlowCanvas.ValueHandler<T> getter)
  FlowCanvas.ValueOutput CreateInstance(System.Type t, FlowCanvas.FlowNode parent, System.String name, System.String ID, FlowCanvas.ValueHandlerObject getter)
  System.Object GetObjectValue()
END_CLASS

CLASS: FlowCanvas.ValueOutput`1
TYPE:  class
TOKEN: 0x200002C
EXTENDS: ValueOutput
FIELDS:
  private           FlowCanvas.ValueHandler<T>      <getter>k__BackingField  // 0x0
METHODS:
  System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID, FlowCanvas.ValueHandler<T> getter)
  System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID, FlowCanvas.ValueHandlerObject getter)
  System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID)
  FlowCanvas.ValueHandler<T> get_getter()
  System.Void set_getter(FlowCanvas.ValueHandler<T> value)
  System.Object GetObjectValue()
  System.Type get_type()
  T op_Explicit(FlowCanvas.ValueOutput<T> port)
END_CLASS

CLASS: FlowCanvas.TypeConverter
TYPE:  class
TOKEN: 0x200002E
FIELDS:
  private   static  FlowCanvas.TypeConverter.CustomConvertercustomConverter  // 0x0
  private   static  FlowCanvas.TypeConverter.CustomCanConvertcustomCanConvert  // 0x8
METHODS:
  System.Void add_customConverter(FlowCanvas.TypeConverter.CustomConverter value)
  System.Void remove_customConverter(FlowCanvas.TypeConverter.CustomConverter value)
  System.Void add_customCanConvert(FlowCanvas.TypeConverter.CustomCanConvert value)
  System.Void remove_customCanConvert(FlowCanvas.TypeConverter.CustomCanConvert value)
  FlowCanvas.ValueHandler<T> GetConverterFuncFromTo(System.Type sourceType, System.Type targetType, FlowCanvas.ValueHandler<System.Object> func)
  System.Boolean HasConvertion(System.Type sourceType, System.Type targetType)
  T QuickConvert(System.Object obj)
  System.Object QuickConvert(System.Object obj, System.Type type)
END_CLASS

CLASS: FlowCanvas.Wild
TYPE:  class
TOKEN: 0x2000035
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Macros.Macro
TYPE:  class
TOKEN: 0x2000273
EXTENDS: FlowScriptBase
FIELDS:
  public            System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition>inputDefinitions  // 0xC0
  public            System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition>outputDefinitions  // 0xC8
  public            System.Collections.Generic.Dictionary<System.String,FlowCanvas.FlowHandler>entryActionMap  // 0xD0
  public            System.Collections.Generic.Dictionary<System.String,FlowCanvas.FlowHandler>exitActionMap  // 0xD8
  public            System.Collections.Generic.Dictionary<System.String,FlowCanvas.ValueHandlerObject>entryFunctionMap  // 0xE0
  public            System.Collections.Generic.Dictionary<System.String,FlowCanvas.ValueHandlerObject>exitFunctionMap  // 0xE8
  private           FlowCanvas.Macros.MacroInputNode_entry  // 0xF0
  private           FlowCanvas.Macros.MacroOutputNode_exit  // 0xF8
METHODS:
  System.Object OnDerivedDataSerialization()
  System.Void OnDerivedDataDeserialization(System.Object data)
  System.Boolean get_allowBlackboardOverrides()
  System.Boolean get_canDelayDeserializeAndOptimizeClone()
  FlowCanvas.Macros.MacroInputNode get_entry()
  FlowCanvas.Macros.MacroOutputNode get_exit()
  System.Void OnGraphValidate()
  FlowCanvas.Port AddInputDefinition(ParadoxNotion.DynamicParameterDefinition def)
  FlowCanvas.Port AddOutputDefinition(ParadoxNotion.DynamicParameterDefinition def)
  System.Void AddExamplePorts()
  System.Void SetValueInput(System.String name, T value)
  System.Void CallFlowInput(System.String name)
  T GetValueOutput(System.String name)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Macros.MacroInputNode
TYPE:  class
TOKEN: 0x200027A
EXTENDS: FlowNode
FIELDS:
METHODS:
  ParadoxNotion.Alignment2x2 get_iconAlignment()
  FlowCanvas.Macros.Macro get_macro()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Macros.MacroNodeWrapper
TYPE:  class
TOKEN: 0x200027C
EXTENDS: FlowNode
FIELDS:
  private           FlowCanvas.Macros.Macro         _macro  // 0xB0
  private           FlowCanvas.Macros.Macro         _currentInstance  // 0xB8
METHODS:
  System.String get_name()
  System.String get_description()
  FlowCanvas.Macros.Macro get_macro()
  System.Void set_macro(FlowCanvas.Macros.Macro value)
  NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_subGraph()
  System.Void NodeCanvas.Framework.IGraphAssignable.set_subGraph(NodeCanvas.Framework.Graph value)
  NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_currentInstance()
  System.Void NodeCanvas.Framework.IGraphAssignable.set_currentInstance(NodeCanvas.Framework.Graph value)
  System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> NodeCanvas.Framework.IGraphAssignable.get_variablesMap()
  System.Void NodeCanvas.Framework.IGraphAssignable.set_variablesMap(System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> value)
  NodeCanvas.Framework.BBParameter NodeCanvas.Framework.IGraphAssignable.get_subGraphParameter()
  System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> NodeCanvas.Framework.IGraphAssignable.get_instances()
  System.Void NodeCanvas.Framework.IGraphAssignable.set_instances(System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> value)
  System.Void MakeInstance()
  System.Void NodeCanvas.Framework.IUpdatable.Update()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Macros.MacroOutputNode
TYPE:  class
TOKEN: 0x2000280
EXTENDS: FlowNode
FIELDS:
METHODS:
  ParadoxNotion.Alignment2x2 get_iconAlignment()
  FlowCanvas.Macros.Macro get_macro()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExternalImplementedNodeWrapper
TYPE:  class
TOKEN: 0x2000036
EXTENDS: FlowNode
FIELDS:
  private           UnityEngine.Object              _target  // 0xB0
METHODS:
  FlowCanvas.Nodes.IExternalImplementedNode get_target()
  System.Void set_target(FlowCanvas.Nodes.IExternalImplementedNode value)
  System.String get_name()
  System.Type GetRuntimeIconType()
  System.Void RegisterPorts()
  System.Void SetTarget(FlowCanvas.Nodes.IExternalImplementedNode target)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.IDropedReferenceNode
TYPE:  interface
TOKEN: 0x2000037
FIELDS:
METHODS:
  System.Void SetTarget(UnityEngine.Object target)
END_CLASS

CLASS: FlowCanvas.Nodes.IExternalImplementedNode
TYPE:  interface
TOKEN: 0x2000038
FIELDS:
METHODS:
  System.Void RegisterPorts(FlowCanvas.FlowNode parent)
END_CLASS

CLASS: FlowCanvas.Nodes.ApplicationPauseEvent
TYPE:  class
TOKEN: 0x2000039
EXTENDS: EventNode
FIELDS:
  private           FlowCanvas.FlowOutput           pause  // 0xB0
  private           System.Boolean                  isPause  // 0xB8
METHODS:
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void ApplicationPause(System.Boolean isPause)
  System.Void RegisterPorts()
  System.Void .ctor()
  System.Boolean <RegisterPorts>b__5_0()
END_CLASS

CLASS: FlowCanvas.Nodes.ApplicationQuitEvent
TYPE:  class
TOKEN: 0x200003A
EXTENDS: EventNode
FIELDS:
  private           FlowCanvas.FlowOutput           quit  // 0xB0
METHODS:
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void ApplicationQuit()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CSharpAutoCallbackEvent
TYPE:  class
TOKEN: 0x200003B
EXTENDS: EventNode
FIELDS:
  private           ParadoxNotion.Serialization.SerializedEventInfo_event  // 0xB0
  private           FlowCanvas.Nodes.ReflectedDelegateEventreflectedEvent  // 0xB8
  private           FlowCanvas.ValueInput           instancePort  // 0xC0
  private           FlowCanvas.FlowOutput           callback  // 0xC8
  private           System.Object                   instance  // 0xD0
  private           System.Object[]                 args  // 0xD8
METHODS:
  System.Reflection.EventInfo get_eventInfo()
  System.Boolean get_isStaticEvent()
  System.String get_name()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Void SetEvent(System.Reflection.EventInfo info, System.Object instance)
  System.Void RegisterPorts()
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void OnEventRaised(System.Object[] args)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CSharpEventCallback
TYPE:  class
TOKEN: 0x200003D
EXTENDS: EventNode
FIELDS:
  protected         System.Boolean                  _autoHandleRegistration  // 0xB0
  private           ParadoxNotion.Serialization.SerializedTypeInfo_type  // 0xB8
  private           System.Object[]                 argValues  // 0xC0
  private           FlowCanvas.ValueInput           eventInput  // 0xC8
  private           FlowCanvas.FlowOutput           flowCallback  // 0xD0
  private           FlowCanvas.Nodes.ReflectedDelegateEventreflectedEvent  // 0xD8
METHODS:
  System.Type get_type()
  System.Void set_type(System.Type value)
  System.Boolean get_autoHandleRegistration()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void Register(FlowCanvas.Flow f)
  System.Void Unregister(FlowCanvas.Flow f)
  System.Void Callback(System.Object[] args)
  System.Type GetNodeWildDefinitionType()
  System.Void OnPortConnected(FlowCanvas.Port port, FlowCanvas.Port otherPort)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CustomEvent
TYPE:  class
TOKEN: 0x200003F
EXTENDS: RouterEventNode`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>eventName  // 0xC8
  private           FlowCanvas.FlowOutput           onReceived  // 0xD0
  private           NodeCanvas.Framework.GraphOwner sender  // 0xD8
  private           NodeCanvas.Framework.GraphOwner receiver  // 0xE0
METHODS:
  System.String get_name()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void RegisterPorts()
  System.Void OnCustomEvent(System.String eventName, ParadoxNotion.IEventData msg)
  System.Void .ctor()
  NodeCanvas.Framework.GraphOwner <RegisterPorts>b__8_0()
  NodeCanvas.Framework.GraphOwner <RegisterPorts>b__8_1()
END_CLASS

CLASS: FlowCanvas.Nodes.CustomEvent`1
TYPE:  class
TOKEN: 0x2000040
EXTENDS: RouterEventNode`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>eventName  // 0x0
  private           FlowCanvas.FlowOutput           onReceived  // 0x0
  private           NodeCanvas.Framework.GraphOwner sender  // 0x0
  private           NodeCanvas.Framework.GraphOwner receiver  // 0x0
  private           T                               receivedValue  // 0x0
METHODS:
  System.String get_name()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void RegisterPorts()
  System.Void OnCustomEvent(System.String eventName, ParadoxNotion.IEventData msg)
  System.Void .ctor()
  NodeCanvas.Framework.GraphOwner <RegisterPorts>b__9_0()
  NodeCanvas.Framework.GraphOwner <RegisterPorts>b__9_1()
  T <RegisterPorts>b__9_2()
END_CLASS

CLASS: FlowCanvas.Nodes.DelegateCallbackEvent
TYPE:  class
TOKEN: 0x2000041
EXTENDS: EventNode
FIELDS:
  private           ParadoxNotion.Serialization.SerializedTypeInfo_type  // 0xB0
  private           FlowCanvas.Nodes.ReflectedDelegateEventreflectedEvent  // 0xB8
  private           FlowCanvas.ValueOutput          delegatePort  // 0xC0
  private           FlowCanvas.FlowOutput           callbackPort  // 0xC8
  private           System.Object[]                 args  // 0xD0
METHODS:
  System.Type get_delegateType()
  System.Void set_delegateType(System.Type value)
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Void RegisterPorts()
  System.Void Callback(System.Object[] args)
  System.Void OnGraphStoped()
  System.Void OnPortConnected(FlowCanvas.Port port, FlowCanvas.Port otherPort)
  System.Void .ctor()
  System.Object <RegisterPorts>b__9_0()
END_CLASS

CLASS: FlowCanvas.Nodes.GetSharpEvent
TYPE:  class
TOKEN: 0x2000043
EXTENDS: FlowNode
FIELDS:
  private           ParadoxNotion.Serialization.SerializedEventInfo_event  // 0xB0
  private           FlowCanvas.ValueInput           instancePort  // 0xB8
METHODS:
  System.Reflection.EventInfo get_eventInfo()
  System.String get_name()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Void SetEvent(System.Reflection.EventInfo info, System.Object instance)
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.InvokeSignal
TYPE:  class
TOKEN: 0x2000045
EXTENDS: FlowNode
FIELDS:
  public            NodeCanvas.Framework.BBParameter<NodeCanvas.Framework.SignalDefinition>_signalDefinition  // 0xB0
  public            System.Boolean                  global  // 0xB8
  private           FlowCanvas.ValueInput<UnityEngine.Transform>target  // 0xC0
  private           FlowCanvas.ValueInput[]         inputArgs  // 0xC8
METHODS:
  NodeCanvas.Framework.SignalDefinition get_signalDefinition()
  System.Void set_signalDefinition(NodeCanvas.Framework.SignalDefinition value)
  System.String get_name()
  System.Void SetTarget(UnityEngine.Object target)
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SignalCallback
TYPE:  class
TOKEN: 0x2000047
EXTENDS: RouterEventNode`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<NodeCanvas.Framework.SignalDefinition>_signalDefinition  // 0xC8
  private           FlowCanvas.FlowOutput           onReceived  // 0xD0
  private           UnityEngine.Transform           receiver  // 0xD8
  private           UnityEngine.Transform           sender  // 0xE0
  private           System.Object[]                 args  // 0xE8
METHODS:
  NodeCanvas.Framework.SignalDefinition get_signalDefinition()
  System.Void set_signalDefinition(NodeCanvas.Framework.SignalDefinition value)
  System.String get_name()
  System.Void SetTarget(UnityEngine.Object target)
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnPostGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void OnInvoked(UnityEngine.Transform sender, UnityEngine.Transform receiver, System.Boolean isGlobal, System.Object[] args)
  System.Void .ctor()
  UnityEngine.Transform <RegisterPorts>b__15_0()
  UnityEngine.Transform <RegisterPorts>b__15_1()
END_CLASS

CLASS: FlowCanvas.Nodes.UnityEventAutoCallbackEvent
TYPE:  class
TOKEN: 0x2000049
EXTENDS: EventNode
FIELDS:
  private           ParadoxNotion.Serialization.SerializedUnityEventInfo_eventMember  // 0xB0
  private           FlowCanvas.Nodes.ReflectedUnityEventreflectedEvent  // 0xB8
  private           UnityEngine.Events.UnityEventBaseunityEvent  // 0xC0
  private           FlowCanvas.ValueInput           instancePort  // 0xC8
  private           FlowCanvas.FlowOutput           callback  // 0xD0
  private           System.Object[]                 args  // 0xD8
METHODS:
  System.Reflection.MemberInfo get_member()
  System.Boolean get_isStatic()
  System.Type get_eventType()
  System.Reflection.FieldInfo get_field()
  System.Reflection.PropertyInfo get_prop()
  System.String get_name()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Void SetEvent(System.Reflection.MemberInfo newMember, System.Object instance)
  System.Void RegisterPorts()
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void OnEventRaised(System.Object[] args)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.UnityEventCallbackEvent
TYPE:  class
TOKEN: 0x200004B
EXTENDS: EventNode
FIELDS:
  protected         System.Boolean                  _autoHandleRegistration  // 0xB0
  private           ParadoxNotion.Serialization.SerializedTypeInfo_type  // 0xB8
  private           System.Object[]                 argValues  // 0xC0
  private           FlowCanvas.ValueInput           eventInput  // 0xC8
  private           FlowCanvas.FlowOutput           flowCallback  // 0xD0
  private           FlowCanvas.Nodes.ReflectedUnityEventreflectedEvent  // 0xD8
METHODS:
  System.Type get_eventType()
  System.Void set_eventType(System.Type value)
  System.Boolean get_autoHandleRegistration()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void Register(FlowCanvas.Flow f)
  System.Void Unregister(FlowCanvas.Flow f)
  System.Void OnEventRaised(System.Object[] args)
  System.Type GetNodeWildDefinitionType()
  System.Void OnPortConnected(FlowCanvas.Port port, FlowCanvas.Port otherPort)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.EventNode
TYPE:  class
TOKEN: 0x200004D
EXTENDS: FlowNode
FIELDS:
METHODS:
  System.String get_name()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.EventNode`1
TYPE:  class
TOKEN: 0x200004E
EXTENDS: EventNode
FIELDS:
  public            NodeCanvas.Framework.BBParameter<T>target  // 0x0
METHODS:
  System.String get_name()
  System.Void OnPostGraphStarted()
  System.Void ResolveSelf()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.RouterEventNode`1
TYPE:  class
TOKEN: 0x200004F
EXTENDS: EventNode
FIELDS:
  public            FlowCanvas.Nodes.RouterEventNode.TargetMode<T>targetMode  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>target  // 0x0
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>>targets  // 0x0
METHODS:
  System.String get_name()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnPostGraphStarted()
  System.Void OnGraphStoped()
  T ResolveReceiver(UnityEngine.GameObject receiver)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ConstructionEvent
TYPE:  class
TOKEN: 0x2000051
EXTENDS: EventNode
FIELDS:
  private           FlowCanvas.FlowOutput           awake  // 0xB0
  private           System.Boolean                  called  // 0xB8
METHODS:
  System.Void OnPostGraphStarted()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.DisableEvent
TYPE:  class
TOKEN: 0x2000052
EXTENDS: EventNode
FIELDS:
  private           FlowCanvas.FlowOutput           disable  // 0xB0
METHODS:
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.EnableEvent
TYPE:  class
TOKEN: 0x2000053
EXTENDS: EventNode
FIELDS:
  private           FlowCanvas.FlowOutput           enable  // 0xB0
METHODS:
  System.Void OnPostGraphStarted()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.FixedUpdateEvent
TYPE:  class
TOKEN: 0x2000054
EXTENDS: EventNode
FIELDS:
  private           FlowCanvas.FlowOutput           fixedUpdate  // 0xB0
METHODS:
  System.Void RegisterPorts()
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void FixedUpdate()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LateUpdateEvent
TYPE:  class
TOKEN: 0x2000055
EXTENDS: EventNode
FIELDS:
  private           FlowCanvas.FlowOutput           lateUpdate  // 0xB0
METHODS:
  System.Void RegisterPorts()
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void LateUpdate()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.StartEvent
TYPE:  class
TOKEN: 0x2000056
EXTENDS: EventNode
FIELDS:
  private           FlowCanvas.FlowOutput           start  // 0xB0
  private           System.Boolean                  called  // 0xB8
METHODS:
  System.Void OnPostGraphStarted()
  System.Void OnStartCallback()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.UpdateEvent
TYPE:  class
TOKEN: 0x2000057
EXTENDS: EventNode
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Single>updateInterval  // 0xB0
  private           FlowCanvas.FlowOutput           update  // 0xB8
  private           System.Single                   lastUpdatedTime  // 0xC0
METHODS:
  System.Void RegisterPorts()
  System.Void OnGraphStarted()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.InputAxisEvent
TYPE:  class
TOKEN: 0x2000058
EXTENDS: EventNode
FIELDS:
  private           FlowCanvas.FlowOutput           o  // 0xB0
  private           System.Single                   horizontal  // 0xB8
  private           System.Single                   vertical  // 0xBC
  private           System.Boolean                  calledLastFrame  // 0xC0
METHODS:
  System.Void RegisterPorts()
  System.Void Update()
  System.Void .ctor()
  System.Single <RegisterPorts>b__4_0()
  System.Single <RegisterPorts>b__4_1()
END_CLASS

CLASS: FlowCanvas.Nodes.InputButtonEvents
TYPE:  class
TOKEN: 0x2000059
EXTENDS: EventNode
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>buttonName  // 0xB0
  private           FlowCanvas.FlowOutput           down  // 0xB8
  private           FlowCanvas.FlowOutput           up  // 0xC0
  private           FlowCanvas.FlowOutput           pressed  // 0xC8
METHODS:
  System.String get_name()
  System.Void RegisterPorts()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.InputCustomAxisEvent
TYPE:  class
TOKEN: 0x200005A
EXTENDS: EventNode
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<System.String>>axis  // 0xB0
  private           System.Single[]                 axisValues  // 0xB8
  private           System.Boolean                  calledLastFrame  // 0xC0
  private           FlowCanvas.FlowOutput           o  // 0xC8
METHODS:
  System.Void RegisterPorts()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.KeyboardEvents
TYPE:  class
TOKEN: 0x200005C
EXTENDS: EventNode
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.KeyCode>keyCode  // 0xB0
  private           FlowCanvas.FlowOutput           down  // 0xB8
  private           FlowCanvas.FlowOutput           up  // 0xC0
  private           FlowCanvas.FlowOutput           pressed  // 0xC8
METHODS:
  System.String get_name()
  System.Void RegisterPorts()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.MouseEvents
TYPE:  class
TOKEN: 0x200005D
EXTENDS: EventNode
FIELDS:
  public            NodeCanvas.Framework.BBParameter<FlowCanvas.Nodes.MouseEvents.ButtonKeys>buttonKey  // 0xB0
  private           FlowCanvas.FlowOutput           down  // 0xB8
  private           FlowCanvas.FlowOutput           pressed  // 0xC0
  private           FlowCanvas.FlowOutput           up  // 0xC8
METHODS:
  System.String get_name()
  System.Void RegisterPorts()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.MousePickEvent
TYPE:  class
TOKEN: 0x200005F
EXTENDS: EventNode
FIELDS:
  public            NodeCanvas.Framework.BBParameter<FlowCanvas.Nodes.MousePickEvent.ButtonKeys>buttonKey  // 0xB0
  public            NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask>mask  // 0xB8
  private           FlowCanvas.FlowOutput           o  // 0xC0
  private           UnityEngine.RaycastHit          hit  // 0xC8
METHODS:
  System.String get_name()
  System.Void RegisterPorts()
  System.Void Update()
  System.Void .ctor()
  UnityEngine.RaycastHit <RegisterPorts>b__7_0()
END_CLASS

CLASS: FlowCanvas.Nodes.AnimatorEvents
TYPE:  class
TOKEN: 0x2000061
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onAnimatorMove  // 0xC8
  private           FlowCanvas.FlowOutput           onAnimatorIK  // 0xD0
  private           UnityEngine.Animator            receiver  // 0xD8
  private           System.Int32                    layerIndex  // 0xE0
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnAnimatorMove(ParadoxNotion.EventData msg)
  System.Void OnAnimatorIK(ParadoxNotion.EventData<System.Int32> msg)
  System.Void .ctor()
  UnityEngine.Animator <RegisterPorts>b__4_0()
  System.Int32 <RegisterPorts>b__4_1()
END_CLASS

CLASS: FlowCanvas.Nodes.CharacterControllerEvents
TYPE:  class
TOKEN: 0x2000062
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onHit  // 0xC8
  private           UnityEngine.CharacterController receiver  // 0xD0
  private           UnityEngine.ControllerColliderHithitInfo  // 0xD8
  private           FlowCanvas.FlowOutput           onGrounded  // 0xE0
  private           FlowCanvas.FlowOutput           onUnGrounded  // 0xE8
  private           System.Boolean                  wasGrounded  // 0xF0
  private           System.Boolean[]                wasGroundedMulti  // 0xF8
METHODS:
  System.Void OnPostGraphStarted()
  System.Void NodeCanvas.Framework.IUpdatable.Update()
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnControllerColliderHit(ParadoxNotion.EventData<UnityEngine.ControllerColliderHit> msg)
  System.Void .ctor()
  UnityEngine.CharacterController <RegisterPorts>b__9_0()
  UnityEngine.GameObject <RegisterPorts>b__9_1()
  UnityEngine.Vector3 <RegisterPorts>b__9_2()
  UnityEngine.ControllerColliderHit <RegisterPorts>b__9_3()
END_CLASS

CLASS: FlowCanvas.Nodes.Collision2DEvents_Rigidbody
TYPE:  class
TOKEN: 0x2000063
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onEnter  // 0xC8
  private           FlowCanvas.FlowOutput           onStay  // 0xD0
  private           FlowCanvas.FlowOutput           onExit  // 0xD8
  private           UnityEngine.Rigidbody2D         receiver  // 0xE0
  private           UnityEngine.Collision2D         collision  // 0xE8
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnCollisionEnter2D(ParadoxNotion.EventData<UnityEngine.Collision2D> msg)
  System.Void OnCollisionStay2D(ParadoxNotion.EventData<UnityEngine.Collision2D> msg)
  System.Void OnCollisionExit2D(ParadoxNotion.EventData<UnityEngine.Collision2D> msg)
  System.Void .ctor()
  UnityEngine.Rigidbody2D <RegisterPorts>b__5_0()
  UnityEngine.GameObject <RegisterPorts>b__5_1()
  UnityEngine.ContactPoint2D <RegisterPorts>b__5_2()
  UnityEngine.Collision2D <RegisterPorts>b__5_3()
END_CLASS

CLASS: FlowCanvas.Nodes.Collision2DEvents
TYPE:  class
TOKEN: 0x2000064
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onEnter  // 0xC8
  private           FlowCanvas.FlowOutput           onStay  // 0xD0
  private           FlowCanvas.FlowOutput           onExit  // 0xD8
  private           UnityEngine.Collider2D          receiver  // 0xE0
  private           UnityEngine.Collision2D         collision  // 0xE8
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnCollisionEnter2D(ParadoxNotion.EventData<UnityEngine.Collision2D> msg)
  System.Void OnCollisionStay2D(ParadoxNotion.EventData<UnityEngine.Collision2D> msg)
  System.Void OnCollisionExit2D(ParadoxNotion.EventData<UnityEngine.Collision2D> msg)
  System.Void .ctor()
  UnityEngine.Collider2D <RegisterPorts>b__5_0()
  UnityEngine.GameObject <RegisterPorts>b__5_1()
  UnityEngine.ContactPoint2D <RegisterPorts>b__5_2()
  UnityEngine.Collision2D <RegisterPorts>b__5_3()
END_CLASS

CLASS: FlowCanvas.Nodes.CollisionEvents_Rigidbody
TYPE:  class
TOKEN: 0x2000065
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onEnter  // 0xC8
  private           FlowCanvas.FlowOutput           onStay  // 0xD0
  private           FlowCanvas.FlowOutput           onExit  // 0xD8
  private           UnityEngine.Rigidbody           receiver  // 0xE0
  private           UnityEngine.Collision           collision  // 0xE8
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnCollisionEnter(ParadoxNotion.EventData<UnityEngine.Collision> msg)
  System.Void OnCollisionStay(ParadoxNotion.EventData<UnityEngine.Collision> msg)
  System.Void OnCollisionExit(ParadoxNotion.EventData<UnityEngine.Collision> msg)
  System.Void .ctor()
  UnityEngine.Rigidbody <RegisterPorts>b__5_0()
  UnityEngine.GameObject <RegisterPorts>b__5_1()
  UnityEngine.ContactPoint <RegisterPorts>b__5_2()
  UnityEngine.Collision <RegisterPorts>b__5_3()
END_CLASS

CLASS: FlowCanvas.Nodes.CollisionEvents
TYPE:  class
TOKEN: 0x2000066
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onEnter  // 0xC8
  private           FlowCanvas.FlowOutput           onStay  // 0xD0
  private           FlowCanvas.FlowOutput           onExit  // 0xD8
  private           UnityEngine.Collider            receiver  // 0xE0
  private           UnityEngine.Collision           collision  // 0xE8
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnCollisionEnter(ParadoxNotion.EventData<UnityEngine.Collision> msg)
  System.Void OnCollisionStay(ParadoxNotion.EventData<UnityEngine.Collision> msg)
  System.Void OnCollisionExit(ParadoxNotion.EventData<UnityEngine.Collision> msg)
  System.Void .ctor()
  UnityEngine.Collider <RegisterPorts>b__5_0()
  UnityEngine.GameObject <RegisterPorts>b__5_1()
  UnityEngine.ContactPoint <RegisterPorts>b__5_2()
  UnityEngine.Collision <RegisterPorts>b__5_3()
END_CLASS

CLASS: FlowCanvas.Nodes.MouseAgent2DEvents
TYPE:  class
TOKEN: 0x2000067
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onEnter  // 0xC8
  private           FlowCanvas.FlowOutput           onOver  // 0xD0
  private           FlowCanvas.FlowOutput           onExit  // 0xD8
  private           FlowCanvas.FlowOutput           onDown  // 0xE0
  private           FlowCanvas.FlowOutput           onUp  // 0xE8
  private           FlowCanvas.FlowOutput           onDrag  // 0xF0
  private           UnityEngine.Collider2D          receiver  // 0xF8
  private           UnityEngine.RaycastHit2D        hit  // 0x100
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnMouseEnter(ParadoxNotion.EventData msg)
  System.Void OnMouseOver(ParadoxNotion.EventData msg)
  System.Void OnMouseExit(ParadoxNotion.EventData msg)
  System.Void OnMouseDown(ParadoxNotion.EventData msg)
  System.Void OnMouseUp(ParadoxNotion.EventData msg)
  System.Void OnMouseDrag(ParadoxNotion.EventData msg)
  System.Void StoreHit()
  System.Void .ctor()
  UnityEngine.Collider2D <RegisterPorts>b__8_0()
  UnityEngine.RaycastHit2D <RegisterPorts>b__8_1()
END_CLASS

CLASS: FlowCanvas.Nodes.MouseAgentEvents
TYPE:  class
TOKEN: 0x2000068
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onEnter  // 0xC8
  private           FlowCanvas.FlowOutput           onOver  // 0xD0
  private           FlowCanvas.FlowOutput           onExit  // 0xD8
  private           FlowCanvas.FlowOutput           onDown  // 0xE0
  private           FlowCanvas.FlowOutput           onUp  // 0xE8
  private           FlowCanvas.FlowOutput           onDrag  // 0xF0
  private           UnityEngine.Collider            receiver  // 0xF8
  private           UnityEngine.RaycastHit          hit  // 0x100
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnMouseEnter(ParadoxNotion.EventData msg)
  System.Void OnMouseOver(ParadoxNotion.EventData msg)
  System.Void OnMouseExit(ParadoxNotion.EventData msg)
  System.Void OnMouseDown(ParadoxNotion.EventData msg)
  System.Void OnMouseUp(ParadoxNotion.EventData msg)
  System.Void OnMouseDrag(ParadoxNotion.EventData msg)
  System.Void StoreHit()
  System.Void .ctor()
  UnityEngine.Collider <RegisterPorts>b__8_0()
  UnityEngine.RaycastHit <RegisterPorts>b__8_1()
END_CLASS

CLASS: FlowCanvas.Nodes.ObjectStateEvents
TYPE:  class
TOKEN: 0x2000069
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onEnable  // 0xC8
  private           FlowCanvas.FlowOutput           onDisable  // 0xD0
  private           FlowCanvas.FlowOutput           onDestroy  // 0xD8
  private           UnityEngine.GameObject          receiver  // 0xE0
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnEnable(ParadoxNotion.EventData msg)
  System.Void OnDisable(ParadoxNotion.EventData msg)
  System.Void OnDestroy(ParadoxNotion.EventData msg)
  System.Void .ctor()
  UnityEngine.GameObject <RegisterPorts>b__4_0()
END_CLASS

CLASS: FlowCanvas.Nodes.DrawGizmosEvents
TYPE:  class
TOKEN: 0x200006A
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onDrawGizmos  // 0xC8
  private           UnityEngine.GameObject          receiver  // 0xD0
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnDrawGizmos(ParadoxNotion.EventData msg)
  System.Void .ctor()
  UnityEngine.GameObject <RegisterPorts>b__2_0()
END_CLASS

CLASS: FlowCanvas.Nodes.ParticleCollision2DEvents
TYPE:  class
TOKEN: 0x200006B
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onCollision  // 0xC8
  private           UnityEngine.Collider2D          receiver  // 0xD0
  private           UnityEngine.ParticleSystem      particle  // 0xD8
  private           System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent>collisionEvents  // 0xE0
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnParticleCollision(ParadoxNotion.EventData<UnityEngine.GameObject> msg)
  System.Void .ctor()
  UnityEngine.Collider2D <RegisterPorts>b__4_0()
  UnityEngine.ParticleSystem <RegisterPorts>b__4_1()
  UnityEngine.Vector3 <RegisterPorts>b__4_2()
  UnityEngine.Vector3 <RegisterPorts>b__4_3()
  UnityEngine.Vector3 <RegisterPorts>b__4_4()
END_CLASS

CLASS: FlowCanvas.Nodes.ParticleCollisionEvents
TYPE:  class
TOKEN: 0x200006C
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onCollision  // 0xC8
  private           UnityEngine.Collider            receiver  // 0xD0
  private           UnityEngine.ParticleSystem      particle  // 0xD8
  private           System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent>collisionEvents  // 0xE0
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnParticleCollision(ParadoxNotion.EventData<UnityEngine.GameObject> msg)
  System.Void .ctor()
  UnityEngine.Collider <RegisterPorts>b__4_0()
  UnityEngine.ParticleSystem <RegisterPorts>b__4_1()
  UnityEngine.Vector3 <RegisterPorts>b__4_2()
  UnityEngine.Vector3 <RegisterPorts>b__4_3()
  UnityEngine.Vector3 <RegisterPorts>b__4_4()
END_CLASS

CLASS: FlowCanvas.Nodes.TransformEvents
TYPE:  class
TOKEN: 0x200006D
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onParentChanged  // 0xC8
  private           FlowCanvas.FlowOutput           onChildrenChanged  // 0xD0
  private           UnityEngine.Transform           receiver  // 0xD8
  private           UnityEngine.Transform           parent  // 0xE0
  private           System.Collections.Generic.IEnumerable<UnityEngine.Transform>children  // 0xE8
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnTransformParentChanged(ParadoxNotion.EventData msg)
  System.Void OnTransformChildrenChanged(ParadoxNotion.EventData msg)
  System.Void .ctor()
  UnityEngine.Transform <RegisterPorts>b__5_0()
  UnityEngine.Transform <RegisterPorts>b__5_1()
  System.Collections.Generic.IEnumerable<UnityEngine.Transform> <RegisterPorts>b__5_2()
END_CLASS

CLASS: FlowCanvas.Nodes.Trigger2DEvents_Transform
TYPE:  class
TOKEN: 0x200006E
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onEnter  // 0xC8
  private           FlowCanvas.FlowOutput           onStay  // 0xD0
  private           FlowCanvas.FlowOutput           onExit  // 0xD8
  private           UnityEngine.Transform           receiver  // 0xE0
  private           UnityEngine.GameObject          other  // 0xE8
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnTriggerEnter2D(ParadoxNotion.EventData<UnityEngine.Collider2D> msg)
  System.Void OnTriggerStay2D(ParadoxNotion.EventData<UnityEngine.Collider2D> msg)
  System.Void OnTriggerExit2D(ParadoxNotion.EventData<UnityEngine.Collider2D> msg)
  System.Void .ctor()
  UnityEngine.Transform <RegisterPorts>b__5_0()
  UnityEngine.GameObject <RegisterPorts>b__5_1()
END_CLASS

CLASS: FlowCanvas.Nodes.Trigger2DEvents
TYPE:  class
TOKEN: 0x200006F
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onEnter  // 0xC8
  private           FlowCanvas.FlowOutput           onStay  // 0xD0
  private           FlowCanvas.FlowOutput           onExit  // 0xD8
  private           UnityEngine.Collider2D          receiver  // 0xE0
  private           UnityEngine.GameObject          other  // 0xE8
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnTriggerEnter2D(ParadoxNotion.EventData<UnityEngine.Collider2D> msg)
  System.Void OnTriggerStay2D(ParadoxNotion.EventData<UnityEngine.Collider2D> msg)
  System.Void OnTriggerExit2D(ParadoxNotion.EventData<UnityEngine.Collider2D> msg)
  System.Void .ctor()
  UnityEngine.Collider2D <RegisterPorts>b__5_0()
  UnityEngine.GameObject <RegisterPorts>b__5_1()
END_CLASS

CLASS: FlowCanvas.Nodes.TriggerEvents_Transform
TYPE:  class
TOKEN: 0x2000070
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onEnter  // 0xC8
  private           FlowCanvas.FlowOutput           onStay  // 0xD0
  private           FlowCanvas.FlowOutput           onExit  // 0xD8
  private           UnityEngine.Transform           receiver  // 0xE0
  private           UnityEngine.GameObject          other  // 0xE8
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnTriggerEnter(ParadoxNotion.EventData<UnityEngine.Collider> msg)
  System.Void OnTriggerStay(ParadoxNotion.EventData<UnityEngine.Collider> msg)
  System.Void OnTriggerExit(ParadoxNotion.EventData<UnityEngine.Collider> msg)
  System.Void .ctor()
  UnityEngine.Transform <RegisterPorts>b__5_0()
  UnityEngine.GameObject <RegisterPorts>b__5_1()
END_CLASS

CLASS: FlowCanvas.Nodes.TriggerEvents
TYPE:  class
TOKEN: 0x2000071
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onEnter  // 0xC8
  private           FlowCanvas.FlowOutput           onStay  // 0xD0
  private           FlowCanvas.FlowOutput           onExit  // 0xD8
  private           UnityEngine.Collider            receiver  // 0xE0
  private           UnityEngine.GameObject          other  // 0xE8
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnTriggerEnter(ParadoxNotion.EventData<UnityEngine.Collider> msg)
  System.Void OnTriggerStay(ParadoxNotion.EventData<UnityEngine.Collider> msg)
  System.Void OnTriggerExit(ParadoxNotion.EventData<UnityEngine.Collider> msg)
  System.Void .ctor()
  UnityEngine.Collider <RegisterPorts>b__5_0()
  UnityEngine.GameObject <RegisterPorts>b__5_1()
END_CLASS

CLASS: FlowCanvas.Nodes.UIButtonEvent
TYPE:  class
TOKEN: 0x2000072
EXTENDS: EventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           o  // 0xB8
METHODS:
  System.Void OnPostGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void OnClick()
  System.Void .ctor()
  UnityEngine.UI.Button <RegisterPorts>b__3_0()
END_CLASS

CLASS: FlowCanvas.Nodes.UIDropdownEvent
TYPE:  class
TOKEN: 0x2000073
EXTENDS: EventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           o  // 0xB8
  private           System.Int32                    value  // 0xC0
METHODS:
  System.Void OnPostGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void OnValueChanged(System.Int32 value)
  System.Void .ctor()
  UnityEngine.UI.Dropdown <RegisterPorts>b__4_0()
  System.Int32 <RegisterPorts>b__4_1()
END_CLASS

CLASS: FlowCanvas.Nodes.UIInputFieldEvent
TYPE:  class
TOKEN: 0x2000074
EXTENDS: EventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onValueChanged  // 0xB8
  private           FlowCanvas.FlowOutput           onEndEdit  // 0xC0
  private           System.String                   value  // 0xC8
METHODS:
  System.Void OnPostGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void OnValueChanged(System.String value)
  System.Void OnEndEdit(System.String value)
  System.Void .ctor()
  UnityEngine.UI.InputField <RegisterPorts>b__5_0()
  System.String <RegisterPorts>b__5_1()
END_CLASS

CLASS: FlowCanvas.Nodes.UIPointerEvents
TYPE:  class
TOKEN: 0x2000075
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onPointerDown  // 0xC8
  private           FlowCanvas.FlowOutput           onPointerPressed  // 0xD0
  private           FlowCanvas.FlowOutput           onPointerUp  // 0xD8
  private           FlowCanvas.FlowOutput           onPointerEnter  // 0xE0
  private           FlowCanvas.FlowOutput           onPointerExit  // 0xE8
  private           FlowCanvas.FlowOutput           onPointerClick  // 0xF0
  private           FlowCanvas.FlowOutput           onPointerDrag  // 0xF8
  private           FlowCanvas.FlowOutput           onPointerDrop  // 0x100
  private           FlowCanvas.FlowOutput           onPointerScroll  // 0x108
  private           UnityEngine.GameObject          receiver  // 0x110
  private           UnityEngine.EventSystems.PointerEventDataeventData  // 0x118
  private           System.Boolean                  updatePressed  // 0x120
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnPointerDown(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> msg)
  System.Void OnPointerUp(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> msg)
  System.Collections.IEnumerator UpdatePressed()
  System.Void OnPointerEnter(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> msg)
  System.Void OnPointerExit(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> msg)
  System.Void OnPointerClick(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> msg)
  System.Void OnPointerDrag(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> msg)
  System.Void OnPointerDrop(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> msg)
  System.Void OnPointerScroll(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> msg)
  System.Void .ctor()
  UnityEngine.GameObject <RegisterPorts>b__12_0()
  UnityEngine.EventSystems.PointerEventData <RegisterPorts>b__12_1()
END_CLASS

CLASS: FlowCanvas.Nodes.UIScrollbarEvent
TYPE:  class
TOKEN: 0x2000077
EXTENDS: EventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           o  // 0xB8
  private           System.Single                   value  // 0xC0
METHODS:
  System.Void OnPostGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void OnValueChanged(System.Single value)
  System.Void .ctor()
  UnityEngine.UI.Scrollbar <RegisterPorts>b__4_0()
  System.Single <RegisterPorts>b__4_1()
END_CLASS

CLASS: FlowCanvas.Nodes.UISliderEvent
TYPE:  class
TOKEN: 0x2000078
EXTENDS: EventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           o  // 0xB8
  private           System.Single                   value  // 0xC0
METHODS:
  System.Void OnPostGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void OnValueChanged(System.Single value)
  System.Void .ctor()
  UnityEngine.UI.Slider <RegisterPorts>b__4_0()
  System.Single <RegisterPorts>b__4_1()
END_CLASS

CLASS: FlowCanvas.Nodes.UIToggleEvent
TYPE:  class
TOKEN: 0x2000079
EXTENDS: EventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           o  // 0xB8
  private           System.Boolean                  state  // 0xC0
METHODS:
  System.Void OnPostGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void OnValueChanged(System.Boolean state)
  System.Void .ctor()
  UnityEngine.UI.Toggle <RegisterPorts>b__4_0()
  System.Boolean <RegisterPorts>b__4_1()
END_CLASS

CLASS: FlowCanvas.Nodes.VisibilityEvents
TYPE:  class
TOKEN: 0x200007A
EXTENDS: RouterEventNode`1
FIELDS:
  private           FlowCanvas.FlowOutput           onVisible  // 0xC8
  private           FlowCanvas.FlowOutput           onInvisible  // 0xD0
  private           UnityEngine.GameObject          receiver  // 0xD8
METHODS:
  System.Void RegisterPorts()
  System.Void Subscribe(ParadoxNotion.Services.EventRouter router)
  System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router)
  System.Void OnBecameVisible(ParadoxNotion.EventData msg)
  System.Void OnBecameInvisible(ParadoxNotion.EventData msg)
  System.Void .ctor()
  UnityEngine.GameObject <RegisterPorts>b__3_0()
END_CLASS

CLASS: FlowCanvas.Nodes.ConditionalUpdateEvent
TYPE:  class
TOKEN: 0x200007B
EXTENDS: EventNode
FIELDS:
  private           FlowCanvas.FlowOutput           becameTrue  // 0xB0
  private           FlowCanvas.FlowOutput           becameFalse  // 0xB8
  private           FlowCanvas.ValueInput<System.Boolean>condition  // 0xC0
  private           System.Boolean                  lastState  // 0xC8
METHODS:
  System.Void RegisterPorts()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.DebugEvent
TYPE:  class
TOKEN: 0x200007C
EXTENDS: EventNode
FIELDS:
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.OscillatorEvent
TYPE:  class
TOKEN: 0x200007D
EXTENDS: EventNode
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.AnimationCurve>curve  // 0xB0
  private           System.Single                   time  // 0xB8
  private           System.Single                   value  // 0xBC
  private           FlowCanvas.FlowOutput           hi  // 0xC0
  private           FlowCanvas.FlowOutput           low  // 0xC8
METHODS:
  System.Void .ctor()
  System.Void RegisterPorts()
  System.Void OnGraphStarted()
  System.Void Update()
  System.Single <RegisterPorts>b__6_0()
END_CLASS

CLASS: FlowCanvas.Nodes.VariableChangedEvent
TYPE:  class
TOKEN: 0x200007E
EXTENDS: EventNode
FIELDS:
  public            NodeCanvas.Framework.Internal.BBObjectParametertargetVariable  // 0xB0
  private           FlowCanvas.FlowOutput           fOut  // 0xB8
  private           System.Object                   newValue  // 0xC0
METHODS:
  System.String get_name()
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void OnValueChanged(System.Object value)
  System.Void OnVariableRefChange(NodeCanvas.Framework.Variable newVarRef)
  System.Void .ctor()
  System.Object <RegisterPorts>b__7_0()
END_CLASS

CLASS: FlowCanvas.Nodes.Chance
TYPE:  class
TOKEN: 0x200007F
EXTENDS: FlowControlNode
FIELDS:
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Cooldown
TYPE:  class
TOKEN: 0x2000081
EXTENDS: FlowControlNode
FIELDS:
  private           UnityEngine.Coroutine           coroutine  // 0xB0
  private           System.Single                   remaining  // 0xB8
  private           System.Single                   remainingNormalized  // 0xBC
  private           FlowCanvas.FlowOutput           start  // 0xC0
  private           FlowCanvas.FlowOutput           finish  // 0xC8
  private           FlowCanvas.FlowOutput           update  // 0xD0
  private           FlowCanvas.ValueInput<System.Single>time  // 0xD8
METHODS:
  System.String get_name()
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void Begin(FlowCanvas.Flow f)
  System.Void Cancel(FlowCanvas.Flow f)
  System.Collections.IEnumerator CountDown(FlowCanvas.Flow f)
  System.Void .ctor()
  System.Single <RegisterPorts>b__11_0()
  System.Single <RegisterPorts>b__11_1()
END_CLASS

CLASS: FlowCanvas.Nodes.DoOnce
TYPE:  class
TOKEN: 0x2000083
EXTENDS: FlowControlNode
FIELDS:
  private           System.Boolean                  called  // 0xB0
METHODS:
  System.Void OnGraphStarted()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ReadFlowParameter`1
TYPE:  class
TOKEN: 0x2000085
EXTENDS: FlowControlNode
FIELDS:
  private           T                               flowValue  // 0x0
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.WriteFlowParameter`1
TYPE:  class
TOKEN: 0x2000087
EXTENDS: FlowControlNode
FIELDS:
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LatchBool
TYPE:  class
TOKEN: 0x2000089
EXTENDS: FlowControlNode
FIELDS:
  private           System.Boolean                  latched  // 0xB0
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LatchInt
TYPE:  class
TOKEN: 0x200008B
EXTENDS: FlowControlNode
FIELDS:
  private           System.Int32                    _portCount  // 0xB0
  private           System.Int32                    latched  // 0xB4
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ANDMerge
TYPE:  class
TOKEN: 0x200008E
EXTENDS: FlowControlNode
FIELDS:
  private           System.Int32                    _portCount  // 0xB0
  public            System.Single                   maxAwaitTime  // 0xB4
  private           FlowCanvas.FlowOutput           fOut  // 0xB8
  private           System.Single[]                 calls  // 0xC0
  private           System.Int32                    lastFrameCall  // 0xC8
METHODS:
  System.Void OnGraphStarted()
  System.Void RegisterPorts()
  System.Void Reset()
  System.Void Check(System.Int32 index, FlowCanvas.Flow f)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.AwaitAll
TYPE:  class
TOKEN: 0x2000090
EXTENDS: FlowControlNode
FIELDS:
  private           System.Int32                    _portCount  // 0xB0
  public            System.Single                   maxAwaitTime  // 0xB4
  private           FlowCanvas.FlowOutput           fOut  // 0xB8
  private           System.Single[]                 calls  // 0xC0
  private           System.Int32                    lastFrameCall  // 0xC8
METHODS:
  System.Void OnGraphStarted()
  System.Void RegisterPorts()
  System.Void Reset()
  System.Void Check(System.Int32 index, FlowCanvas.Flow f)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ORMerge
TYPE:  class
TOKEN: 0x2000092
EXTENDS: FlowControlNode
FIELDS:
  private           System.Int32                    _portCount  // 0xB0
  private           FlowCanvas.FlowOutput           fOut  // 0xB8
  private           System.Int32                    lastFrameCall  // 0xC0
METHODS:
  System.Void RegisterPorts()
  System.Void Check(System.Int32 index, FlowCanvas.Flow f)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.XORMerge
TYPE:  class
TOKEN: 0x2000094
EXTENDS: FlowControlNode
FIELDS:
  private           System.Int32                    _portCount  // 0xB0
  private           FlowCanvas.FlowOutput           fOut  // 0xB8
  private           System.Int32[]                  calls  // 0xC0
  private           System.Int32                    lastFrameCall  // 0xC8
METHODS:
  System.Void RegisterPorts()
  System.Void Check(System.Int32 index, FlowCanvas.Flow f)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.FlowControlNode
TYPE:  class
TOKEN: 0x2000096
EXTENDS: FlowNode
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Break
TYPE:  class
TOKEN: 0x2000097
EXTENDS: FlowControlNode
FIELDS:
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
  System.Void <RegisterPorts>b__0_0(FlowCanvas.Flow f)
END_CLASS

CLASS: FlowCanvas.Nodes.ForEach
TYPE:  class
TOKEN: 0x2000098
EXTENDS: FlowControlNode
FIELDS:
  private           System.Object                   currentObject  // 0xB0
  private           System.Int32                    currentIndex  // 0xB8
  private           System.Boolean                  broken  // 0xBC
  private           FlowCanvas.ValueInput<System.Collections.IEnumerable>enumerableInput  // 0xC0
METHODS:
  System.Void RegisterPorts()
  System.Type GetNodeWildDefinitionType()
  System.Void OnPortConnected(FlowCanvas.Port port, FlowCanvas.Port otherPort)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ForEach`1
TYPE:  class
TOKEN: 0x200009A
EXTENDS: FlowControlNode
FIELDS:
  private           T                               currentObject  // 0x0
  private           System.Int32                    currentIndex  // 0x0
  private           System.Boolean                  broken  // 0x0
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ForLoop
TYPE:  class
TOKEN: 0x200009C
EXTENDS: FlowControlNode
FIELDS:
  public            System.Boolean                  reverse  // 0xB0
  private           System.Int32                    current  // 0xB4
  private           System.Boolean                  broken  // 0xB8
  private           FlowCanvas.ValueInput<System.Int32>first  // 0xC0
  private           FlowCanvas.ValueInput<System.Int32>last  // 0xC8
  private           FlowCanvas.ValueInput<System.Int32>step  // 0xD0
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Dummy
TYPE:  class
TOKEN: 0x200009E
EXTENDS: FlowControlNode
FIELDS:
METHODS:
  System.String get_name()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Finish
TYPE:  class
TOKEN: 0x20000A0
EXTENDS: FlowControlNode
FIELDS:
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.GoToLabel
TYPE:  class
TOKEN: 0x20000A2
EXTENDS: FlowControlNode
FIELDS:
  public            System.String                   identifier  // 0xB0
  private           FlowCanvas.FlowOutput           <port>k__BackingField  // 0xB8
METHODS:
  FlowCanvas.FlowOutput get_port()
  System.Void set_port(FlowCanvas.FlowOutput value)
  System.String get_name()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.GoToStatement
TYPE:  class
TOKEN: 0x20000A3
EXTENDS: FlowControlNode
FIELDS:
  public            NodeCanvas.Framework.NodeReference<FlowCanvas.Nodes.GoToLabel>_targetLabel  // 0xB0
METHODS:
  NodeCanvas.Framework.INodeReference NodeCanvas.Framework.IHaveNodeReference.get_targetReference()
  FlowCanvas.Nodes.GoToLabel get_target()
  System.String get_name()
  System.Void SetTarget(FlowCanvas.Nodes.GoToLabel newTarget)
  System.Void RegisterPorts()
  System.Void .ctor()
  System.Void <RegisterPorts>b__8_0(FlowCanvas.Flow f)
END_CLASS

CLASS: FlowCanvas.Nodes.Merge
TYPE:  class
TOKEN: 0x20000A4
EXTENDS: FlowControlNode
FIELDS:
  private           System.Int32                    _portCount  // 0xB0
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Split
TYPE:  class
TOKEN: 0x20000A5
EXTENDS: FlowControlNode
FIELDS:
  private           System.Int32                    _portCount  // 0xB0
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.TryCatch
TYPE:  class
TOKEN: 0x20000A7
EXTENDS: FlowControlNode
FIELDS:
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CoroutineState
TYPE:  class
TOKEN: 0x20000A9
EXTENDS: FlowControlNode
FIELDS:
  private           System.Boolean                  active  // 0xB0
  private           UnityEngine.Coroutine           coroutine  // 0xB8
METHODS:
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Collections.IEnumerator DoRepeat(FlowCanvas.FlowOutput fStart, FlowCanvas.FlowOutput fUpdate, FlowCanvas.FlowOutput fFinish, FlowCanvas.Flow f)
  System.Void .ctor()
  System.Void <DoRepeat>b__4_0()
END_CLASS

CLASS: FlowCanvas.Nodes.While
TYPE:  class
TOKEN: 0x20000AC
EXTENDS: FlowControlNode
FIELDS:
  private           UnityEngine.Coroutine           coroutine  // 0xB0
METHODS:
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Collections.IEnumerator DoWhile(FlowCanvas.FlowOutput fUpdate, FlowCanvas.FlowOutput fFinish, FlowCanvas.Flow f, FlowCanvas.ValueInput<System.Boolean> condition)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SelectOnBool`1
TYPE:  class
TOKEN: 0x20000B0
EXTENDS: FlowControlNode
FIELDS:
  private           FlowCanvas.ValueInput<System.Boolean>condition  // 0x0
  private           FlowCanvas.ValueInput<T>        isTrue  // 0x0
  private           FlowCanvas.ValueInput<T>        isFalse  // 0x0
  private           FlowCanvas.ValueOutput<T>       result  // 0x0
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
  T <RegisterPorts>b__4_0()
END_CLASS

CLASS: FlowCanvas.Nodes.SelectOnEnum`1
TYPE:  class
TOKEN: 0x20000B1
EXTENDS: FlowControlNode
FIELDS:
  private           ParadoxNotion.Serialization.SerializedTypeInfo_type  // 0x0
METHODS:
  System.Type get_type()
  System.Void set_type(System.Type value)
  System.Void RegisterPorts()
  System.Type GetNodeWildDefinitionType()
  System.Void OnPortConnected(FlowCanvas.Port port, FlowCanvas.Port otherPort)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SelectOnInt`1
TYPE:  class
TOKEN: 0x20000B3
EXTENDS: FlowControlNode
FIELDS:
  private           System.Int32                    _portCount  // 0x0
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SelectOnString`1
TYPE:  class
TOKEN: 0x20000B5
EXTENDS: FlowControlNode
FIELDS:
  public            System.Collections.Generic.List<System.String>stringCases  // 0x0
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SelectOnTag`1
TYPE:  class
TOKEN: 0x20000B7
EXTENDS: FlowControlNode
FIELDS:
  private           System.String[]                 _tagNames  // 0x0
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Random
TYPE:  class
TOKEN: 0x20000B9
EXTENDS: FlowControlNode
FIELDS:
  private           System.Int32                    _portCount  // 0xB0
  private           System.Int32                    current  // 0xB4
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SwitchBool
TYPE:  class
TOKEN: 0x20000BB
EXTENDS: FlowControlNode
FIELDS:
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SwitchComparison
TYPE:  class
TOKEN: 0x20000BD
EXTENDS: FlowControlNode
FIELDS:
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SwitchEnum
TYPE:  class
TOKEN: 0x20000BF
EXTENDS: FlowControlNode
FIELDS:
  private           ParadoxNotion.Serialization.SerializedTypeInfo_type  // 0xB0
METHODS:
  System.Type get_type()
  System.Void set_type(System.Type value)
  System.Void RegisterPorts()
  System.Type GetNodeWildDefinitionType()
  System.Void OnPortConnected(FlowCanvas.Port port, FlowCanvas.Port otherPort)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SwitchInt
TYPE:  class
TOKEN: 0x20000C1
EXTENDS: FlowControlNode
FIELDS:
  private           System.Int32                    _portCount  // 0xB0
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SwitchIntCustom
TYPE:  class
TOKEN: 0x20000C3
EXTENDS: FlowControlNode
FIELDS:
  public            System.Collections.Generic.List<System.Int32>intCases  // 0xB0
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SwitchProbability
TYPE:  class
TOKEN: 0x20000C5
EXTENDS: FlowControlNode
FIELDS:
  private           System.Int32                    _portCount  // 0xB0
  private           System.Collections.Generic.List<FlowCanvas.ValueInput<System.Single>>probabilityValues  // 0xB8
  private           System.Collections.Generic.List<FlowCanvas.FlowOutput>probabilityOuts  // 0xC0
  private           System.Single[]                 cacheValues  // 0xC8
  private           System.Int32                    current  // 0xD0
METHODS:
  System.Void RegisterPorts()
  System.Void Enter(FlowCanvas.Flow f)
  System.Void .ctor()
  System.Int32 <RegisterPorts>b__5_0()
END_CLASS

CLASS: FlowCanvas.Nodes.SwitchString
TYPE:  class
TOKEN: 0x20000C6
EXTENDS: FlowControlNode
FIELDS:
  public            System.Collections.Generic.List<System.String>comparisonOutputs  // 0xB0
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SwitchTag
TYPE:  class
TOKEN: 0x20000C8
EXTENDS: FlowControlNode
FIELDS:
  private           System.String[]                 _tagNames  // 0xB0
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.FlipFlop
TYPE:  class
TOKEN: 0x20000CA
EXTENDS: FlowControlNode
FIELDS:
  public            System.Boolean                  isFlip  // 0xB0
  private           System.Boolean                  original  // 0xB1
METHODS:
  System.String get_name()
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.MultiToggle
TYPE:  class
TOKEN: 0x20000CC
EXTENDS: FlowControlNode
FIELDS:
  private           System.Int32                    _portCount  // 0xB0
  public            System.Int32                    current  // 0xB4
  private           System.Int32                    original  // 0xB8
METHODS:
  System.String get_name()
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Sequence
TYPE:  class
TOKEN: 0x20000CE
EXTENDS: FlowControlNode
FIELDS:
  private           System.Int32                    _portCount  // 0xB0
  public            System.Int32                    current  // 0xB4
  private           System.Int32                    original  // 0xB8
METHODS:
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.String get_name()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Toggle
TYPE:  class
TOKEN: 0x20000D0
EXTENDS: FlowControlNode
FIELDS:
  public            System.Boolean                  open  // 0xB0
  private           System.Boolean                  original  // 0xB1
METHODS:
  System.String get_name()
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CustomFunctionCall
TYPE:  class
TOKEN: 0x20000D2
EXTENDS: FlowControlNode
FIELDS:
  private           System.String                   _sourceOutputUID  // 0xB0
  private           FlowCanvas.ValueInput[]         portArgs  // 0xB8
  private           System.Object[]                 objectArgs  // 0xC0
  private           FlowCanvas.FlowOutput           fOut  // 0xC8
  private           System.WeakReference<FlowCanvas.Nodes.CustomFunctionEvent>_sourceFunctionRef  // 0xD0
METHODS:
  System.String get_sourceFunctionUID()
  System.Void set_sourceFunctionUID(System.String value)
  FlowCanvas.Nodes.CustomFunctionEvent get_sourceFunction()
  System.String get_name()
  System.String get_description()
  System.Void SetFunction(FlowCanvas.Nodes.CustomFunctionEvent func)
  System.Void RegisterPorts()
  System.Void Invoke(FlowCanvas.Flow f)
  System.Void .ctor()
  System.Boolean <get_sourceFunction>b__9_0(FlowCanvas.Nodes.CustomFunctionEvent i)
END_CLASS

CLASS: FlowCanvas.Nodes.CustomFunctionEvent
TYPE:  class
TOKEN: 0x20000D3
EXTENDS: EventNode
FIELDS:
  public            System.String                   identifier  // 0xB0
  private           System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition>_parameters  // 0xB8
  private           ParadoxNotion.DynamicParameterDefinition_returns  // 0xC0
  private           System.Object[]                 args  // 0xC8
  private           System.Object                   returnValue  // 0xD0
  private           FlowCanvas.FlowOutput           onInvoke  // 0xD8
METHODS:
  System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition> get_parameters()
  System.Void set_parameters(System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition> value)
  ParadoxNotion.DynamicParameterDefinition get_returns()
  System.Void set_returns(ParadoxNotion.DynamicParameterDefinition value)
  System.Type get_returnType()
  System.Type[] get_parameterTypes()
  System.String get_name()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.String NodeCanvas.Framework.IInvokable.GetInvocationID()
  System.Object NodeCanvas.Framework.IInvokable.Invoke(System.Object[] args)
  System.Void NodeCanvas.Framework.IInvokable.InvokeAsync(System.Action<System.Object> callback, System.Object[] args)
  System.Object Invoke(FlowCanvas.Flow f, System.Object[] args)
  System.Void InvokeAsync(FlowCanvas.Flow f, FlowCanvas.FlowHandler flowCallback, System.Object[] args)
  System.Object GetReturnValue()
  System.Void AddParameter(System.Type type)
  System.Void GatherPortsUpdateRefs()
  System.Void .ctor()
  System.Void <Invoke>b__23_0(System.Object o)
  System.Boolean <GatherPortsUpdateRefs>b__27_0(FlowCanvas.Nodes.CustomFunctionCall n)
END_CLASS

CLASS: FlowCanvas.Nodes.Return
TYPE:  class
TOKEN: 0x20000D8
EXTENDS: FlowControlNode
FIELDS:
  public            System.Boolean                  useReturnValue  // 0xB0
  private           FlowCanvas.ValueInput<System.Object>returnPort  // 0xB8
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
  System.Void <RegisterPorts>b__2_0(FlowCanvas.Flow f)
END_CLASS

CLASS: FlowCanvas.Nodes.CallableActionNodeBase
TYPE:  class
TOKEN: 0x20000D9
EXTENDS: SimplexNode
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableActionNode
TYPE:  class
TOKEN: 0x20000DA
EXTENDS: CallableActionNodeBase
FIELDS:
METHODS:
  System.Void Invoke()
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableActionNode`1
TYPE:  class
TOKEN: 0x20000DC
EXTENDS: CallableActionNodeBase
FIELDS:
METHODS:
  System.Void Invoke(T1 a)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableActionNode`2
TYPE:  class
TOKEN: 0x20000DE
EXTENDS: CallableActionNodeBase
FIELDS:
METHODS:
  System.Void Invoke(T1 a, T2 b)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableActionNode`3
TYPE:  class
TOKEN: 0x20000E0
EXTENDS: CallableActionNodeBase
FIELDS:
METHODS:
  System.Void Invoke(T1 a, T2 b, T3 c)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableActionNode`4
TYPE:  class
TOKEN: 0x20000E2
EXTENDS: CallableActionNodeBase
FIELDS:
METHODS:
  System.Void Invoke(T1 a, T2 b, T3 c, T4 d)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableActionNode`5
TYPE:  class
TOKEN: 0x20000E4
EXTENDS: CallableActionNodeBase
FIELDS:
METHODS:
  System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableActionNode`6
TYPE:  class
TOKEN: 0x20000E6
EXTENDS: CallableActionNodeBase
FIELDS:
METHODS:
  System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableActionNode`7
TYPE:  class
TOKEN: 0x20000E8
EXTENDS: CallableActionNodeBase
FIELDS:
METHODS:
  System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableActionNode`8
TYPE:  class
TOKEN: 0x20000EA
EXTENDS: CallableActionNodeBase
FIELDS:
METHODS:
  System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableActionNode`9
TYPE:  class
TOKEN: 0x20000EC
EXTENDS: CallableActionNodeBase
FIELDS:
METHODS:
  System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableActionNode`10
TYPE:  class
TOKEN: 0x20000EE
EXTENDS: CallableActionNodeBase
FIELDS:
METHODS:
  System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableFunctionNodeBase
TYPE:  class
TOKEN: 0x20000F0
EXTENDS: SimplexNode
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableFunctionNode`1
TYPE:  class
TOKEN: 0x20000F1
EXTENDS: CallableFunctionNodeBase
FIELDS:
  private           TResult                         result  // 0x0
METHODS:
  TResult Invoke()
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableFunctionNode`2
TYPE:  class
TOKEN: 0x20000F3
EXTENDS: CallableFunctionNodeBase
FIELDS:
  private           TResult                         result  // 0x0
METHODS:
  TResult Invoke(T1 a)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableFunctionNode`3
TYPE:  class
TOKEN: 0x20000F5
EXTENDS: CallableFunctionNodeBase
FIELDS:
  private           TResult                         result  // 0x0
METHODS:
  TResult Invoke(T1 a, T2 b)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableFunctionNode`4
TYPE:  class
TOKEN: 0x20000F7
EXTENDS: CallableFunctionNodeBase
FIELDS:
  private           TResult                         result  // 0x0
METHODS:
  TResult Invoke(T1 a, T2 b, T3 c)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableFunctionNode`5
TYPE:  class
TOKEN: 0x20000F9
EXTENDS: CallableFunctionNodeBase
FIELDS:
  private           TResult                         result  // 0x0
METHODS:
  TResult Invoke(T1 a, T2 b, T3 c, T4 d)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableFunctionNode`6
TYPE:  class
TOKEN: 0x20000FB
EXTENDS: CallableFunctionNodeBase
FIELDS:
  private           TResult                         result  // 0x0
METHODS:
  TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableFunctionNode`7
TYPE:  class
TOKEN: 0x20000FD
EXTENDS: CallableFunctionNodeBase
FIELDS:
  private           TResult                         result  // 0x0
METHODS:
  TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableFunctionNode`8
TYPE:  class
TOKEN: 0x20000FF
EXTENDS: CallableFunctionNodeBase
FIELDS:
  private           TResult                         result  // 0x0
METHODS:
  TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableFunctionNode`9
TYPE:  class
TOKEN: 0x2000101
EXTENDS: CallableFunctionNodeBase
FIELDS:
  private           TResult                         result  // 0x0
METHODS:
  TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableFunctionNode`10
TYPE:  class
TOKEN: 0x2000103
EXTENDS: CallableFunctionNodeBase
FIELDS:
  private           TResult                         result  // 0x0
METHODS:
  TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CallableFunctionNode`11
TYPE:  class
TOKEN: 0x2000105
EXTENDS: CallableFunctionNodeBase
FIELDS:
  private           TResult                         result  // 0x0
METHODS:
  TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractorNode
TYPE:  class
TOKEN: 0x2000107
EXTENDS: SimplexNode
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Type>_extractors  // 0x0
METHODS:
  System.Type GetExtractorType(System.Type type)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractorNode`3
TYPE:  class
TOKEN: 0x2000109
EXTENDS: ExtractorNode
FIELDS:
  private           T1                              a  // 0x0
  private           T2                              b  // 0x0
METHODS:
  System.Void Invoke(TInstance instance, T1& a, T2& b)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractorNode`4
TYPE:  class
TOKEN: 0x200010B
EXTENDS: ExtractorNode
FIELDS:
  private           T1                              a  // 0x0
  private           T2                              b  // 0x0
  private           T3                              c  // 0x0
METHODS:
  System.Void Invoke(TInstance instance, T1& a, T2& b, T3& c)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractorNode`5
TYPE:  class
TOKEN: 0x200010D
EXTENDS: ExtractorNode
FIELDS:
  private           T1                              a  // 0x0
  private           T2                              b  // 0x0
  private           T3                              c  // 0x0
  private           T4                              d  // 0x0
METHODS:
  System.Void Invoke(TInstance instance, T1& a, T2& b, T3& c, T4& d)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractorNode`6
TYPE:  class
TOKEN: 0x200010F
EXTENDS: ExtractorNode
FIELDS:
  private           T1                              a  // 0x0
  private           T2                              b  // 0x0
  private           T3                              c  // 0x0
  private           T4                              d  // 0x0
  private           T5                              e  // 0x0
METHODS:
  System.Void Invoke(TInstance instance, T1& a, T2& b, T3& c, T4& d, T5& e)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractorNode`7
TYPE:  class
TOKEN: 0x2000111
EXTENDS: ExtractorNode
FIELDS:
  private           T1                              a  // 0x0
  private           T2                              b  // 0x0
  private           T3                              c  // 0x0
  private           T4                              d  // 0x0
  private           T5                              e  // 0x0
  private           T6                              f  // 0x0
METHODS:
  System.Void Invoke(TInstance instance, T1& a, T2& b, T3& c, T4& d, T5& e, T6& f)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.AddDictionaryItem`1
TYPE:  class
TOKEN: 0x2000113
EXTENDS: CallableFunctionNode`4
FIELDS:
METHODS:
  System.Collections.Generic.IDictionary<System.String,T> Invoke(System.Collections.Generic.IDictionary<System.String,T> dict, System.String key, T item)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.GetDictionaryItem`1
TYPE:  class
TOKEN: 0x2000114
EXTENDS: CallableFunctionNode`3
FIELDS:
METHODS:
  T Invoke(System.Collections.Generic.IDictionary<System.String,T> dict, System.String key)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.RemoveDictionaryKey`1
TYPE:  class
TOKEN: 0x2000115
EXTENDS: CallableFunctionNode`3
FIELDS:
METHODS:
  System.Collections.Generic.IDictionary<System.String,T> Invoke(System.Collections.Generic.IDictionary<System.String,T> dict, System.String key)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ClearDictionary
TYPE:  class
TOKEN: 0x2000116
EXTENDS: CallableFunctionNode`2
FIELDS:
METHODS:
  System.Collections.IDictionary Invoke(System.Collections.IDictionary dict)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.TryGetValue`1
TYPE:  class
TOKEN: 0x2000117
EXTENDS: CallableFunctionNode`3
FIELDS:
  private           System.Boolean                  <exists>k__BackingField  // 0x0
METHODS:
  System.Boolean get_exists()
  System.Void set_exists(System.Boolean value)
  T Invoke(System.Collections.Generic.IDictionary<System.String,T> dict, System.String key)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.DictionaryContainsKey`1
TYPE:  class
TOKEN: 0x2000118
EXTENDS: CallableFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Collections.Generic.IDictionary<System.String,T> dict, System.String key)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ClearList
TYPE:  class
TOKEN: 0x2000119
EXTENDS: CallableFunctionNode`2
FIELDS:
METHODS:
  System.Collections.IList Invoke(System.Collections.IList list)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.AddListItem`1
TYPE:  class
TOKEN: 0x200011A
EXTENDS: CallableFunctionNode`3
FIELDS:
METHODS:
  System.Collections.Generic.IList<T> Invoke(System.Collections.Generic.List<T> list, T item)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.InsertListItem`1
TYPE:  class
TOKEN: 0x200011B
EXTENDS: CallableFunctionNode`4
FIELDS:
METHODS:
  System.Collections.Generic.IList<T> Invoke(System.Collections.Generic.List<T> list, System.Int32 index, T item)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.RemoveListItem`1
TYPE:  class
TOKEN: 0x200011C
EXTENDS: CallableFunctionNode`3
FIELDS:
METHODS:
  System.Collections.Generic.IList<T> Invoke(System.Collections.Generic.List<T> list, T item)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.RemoveListItemAt`1
TYPE:  class
TOKEN: 0x200011D
EXTENDS: CallableFunctionNode`3
FIELDS:
METHODS:
  System.Collections.Generic.IList<T> Invoke(System.Collections.Generic.List<T> list, System.Int32 index)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SetListItem`1
TYPE:  class
TOKEN: 0x200011E
EXTENDS: CallableFunctionNode`4
FIELDS:
METHODS:
  System.Collections.Generic.IList<T> Invoke(System.Collections.Generic.IList<T> list, System.Int32 index, T item)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ShuffleList`1
TYPE:  class
TOKEN: 0x200011F
EXTENDS: CallableFunctionNode`2
FIELDS:
METHODS:
  System.Collections.Generic.IList<T> Invoke(System.Collections.Generic.IList<T> list)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.GetListItem`1
TYPE:  class
TOKEN: 0x2000120
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  T Invoke(System.Collections.Generic.IList<T> list, System.Int32 index)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.GetRandomListItem`1
TYPE:  class
TOKEN: 0x2000121
EXTENDS: PureFunctionNode`2
FIELDS:
METHODS:
  T Invoke(System.Collections.Generic.IList<T> list)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.GetLastListItem`1
TYPE:  class
TOKEN: 0x2000122
EXTENDS: PureFunctionNode`2
FIELDS:
METHODS:
  T Invoke(System.Collections.Generic.IList<T> list)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.GetFirstListItem`1
TYPE:  class
TOKEN: 0x2000123
EXTENDS: PureFunctionNode`2
FIELDS:
METHODS:
  T Invoke(System.Collections.Generic.IList<T> list)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.GetListItemIndex
TYPE:  class
TOKEN: 0x2000124
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Int32 Invoke(System.Collections.IList list, System.Object item)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.IsNotNull
TYPE:  class
TOKEN: 0x2000125
EXTENDS: PureFunctionNode`2
FIELDS:
METHODS:
  System.Boolean Invoke(System.Object OBJECT)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.IsOfType
TYPE:  class
TOKEN: 0x2000126
EXTENDS: PureFunctionNode`3
FIELDS:
  private           System.Object                   <OBJECT>k__BackingField  // 0x30
METHODS:
  System.Object get_OBJECT()
  System.Void set_OBJECT(System.Object value)
  System.Boolean Invoke(System.Object OBJECT, System.Type type)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.AnyGreaterThan
TYPE:  class
TOKEN: 0x2000127
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.IComparable a, System.IComparable b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.AnyGreaterEqualThan
TYPE:  class
TOKEN: 0x2000128
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.IComparable a, System.IComparable b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.AnyLessThan
TYPE:  class
TOKEN: 0x2000129
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.IComparable a, System.IComparable b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.AnyLessEqualThan
TYPE:  class
TOKEN: 0x200012A
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.IComparable a, System.IComparable b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.AnyEqual
TYPE:  class
TOKEN: 0x200012B
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Object a, System.Object b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.AnyNotEqual
TYPE:  class
TOKEN: 0x200012C
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Object a, System.Object b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.FloatAdd
TYPE:  class
TOKEN: 0x200012D
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Single Invoke(System.Single a, System.Single b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.FloatSubtract
TYPE:  class
TOKEN: 0x200012E
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Single Invoke(System.Single a, System.Single b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.FloatMultiply
TYPE:  class
TOKEN: 0x200012F
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Single Invoke(System.Single a, System.Single b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.FloatDivide
TYPE:  class
TOKEN: 0x2000130
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Single Invoke(System.Single a, System.Single b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.FloatModulo
TYPE:  class
TOKEN: 0x2000131
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Single Invoke(System.Single value, System.Single mod)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.FloatGreaterThan
TYPE:  class
TOKEN: 0x2000132
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Single a, System.Single b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.FloatGreaterEqualThan
TYPE:  class
TOKEN: 0x2000133
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Single a, System.Single b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.FloatLessThan
TYPE:  class
TOKEN: 0x2000134
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Single a, System.Single b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.FloatLessEqualThan
TYPE:  class
TOKEN: 0x2000135
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Single a, System.Single b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.FloatEqual
TYPE:  class
TOKEN: 0x2000136
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Single a, System.Single b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.FloatNotEqual
TYPE:  class
TOKEN: 0x2000137
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Single a, System.Single b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.FloatInvert
TYPE:  class
TOKEN: 0x2000138
EXTENDS: PureFunctionNode`2
FIELDS:
METHODS:
  System.Single Invoke(System.Single value)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.FloatSnap
TYPE:  class
TOKEN: 0x2000139
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Int32 Invoke(System.Single value, System.Int32 interval)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.IntegerAdd
TYPE:  class
TOKEN: 0x200013A
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Int32 Invoke(System.Int32 a, System.Int32 b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.IntegerSubtract
TYPE:  class
TOKEN: 0x200013B
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Int32 Invoke(System.Int32 a, System.Int32 b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.IntegerMultiply
TYPE:  class
TOKEN: 0x200013C
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Int32 Invoke(System.Int32 a, System.Int32 b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.IntegerDivide
TYPE:  class
TOKEN: 0x200013D
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Int32 Invoke(System.Int32 a, System.Int32 b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.IntegerModulo
TYPE:  class
TOKEN: 0x200013E
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Int32 Invoke(System.Int32 value, System.Int32 mod)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.IntegerGreaterThan
TYPE:  class
TOKEN: 0x200013F
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Int32 a, System.Int32 b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.IntegerGreaterEqualThan
TYPE:  class
TOKEN: 0x2000140
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Int32 a, System.Int32 b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.IntegerLessThan
TYPE:  class
TOKEN: 0x2000141
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Int32 a, System.Int32 b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.IntegerLessEqualThan
TYPE:  class
TOKEN: 0x2000142
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Int32 a, System.Int32 b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.IntegerEqual
TYPE:  class
TOKEN: 0x2000143
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Int32 a, System.Int32 b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.IntegerNotEqual
TYPE:  class
TOKEN: 0x2000144
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Int32 a, System.Int32 b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.IntegerInvert
TYPE:  class
TOKEN: 0x2000145
EXTENDS: PureFunctionNode`2
FIELDS:
METHODS:
  System.Int32 Invoke(System.Int32 value)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.IntegerSnap
TYPE:  class
TOKEN: 0x2000146
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Int32 Invoke(System.Int32 value, System.Int32 interval)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.BooleanEqual
TYPE:  class
TOKEN: 0x2000147
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Boolean a, System.Boolean b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.BooleanNotEqual
TYPE:  class
TOKEN: 0x2000148
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(System.Boolean a, System.Boolean b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.AND
TYPE:  class
TOKEN: 0x2000149
EXTENDS: PureFunctionNode`1
FIELDS:
  private           FlowCanvas.ValueInput<System.Boolean>a  // 0x30
  private           FlowCanvas.ValueInput<System.Boolean>b  // 0x38
METHODS:
  System.Boolean Invoke()
  System.Void OnRegisterExtraPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.OR
TYPE:  class
TOKEN: 0x200014A
EXTENDS: PureFunctionNode`1
FIELDS:
  private           FlowCanvas.ValueInput<System.Boolean>a  // 0x30
  private           FlowCanvas.ValueInput<System.Boolean>b  // 0x38
METHODS:
  System.Boolean Invoke()
  System.Void OnRegisterExtraPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.XOR
TYPE:  class
TOKEN: 0x200014B
EXTENDS: PureFunctionNode`1
FIELDS:
  private           FlowCanvas.ValueInput<System.Boolean>a  // 0x30
  private           FlowCanvas.ValueInput<System.Boolean>b  // 0x38
METHODS:
  System.Boolean Invoke()
  System.Void OnRegisterExtraPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.NOT
TYPE:  class
TOKEN: 0x200014C
EXTENDS: PureFunctionNode`2
FIELDS:
METHODS:
  System.Boolean Invoke(System.Boolean value)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Vector3Equal
TYPE:  class
TOKEN: 0x200014D
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(UnityEngine.Vector3 a, UnityEngine.Vector3 b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Vector3NotEqual
TYPE:  class
TOKEN: 0x200014E
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Boolean Invoke(UnityEngine.Vector3 a, UnityEngine.Vector3 b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Vector3Add
TYPE:  class
TOKEN: 0x200014F
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  UnityEngine.Vector3 Invoke(UnityEngine.Vector3 a, UnityEngine.Vector3 b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Vector3Subtract
TYPE:  class
TOKEN: 0x2000150
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  UnityEngine.Vector3 Invoke(UnityEngine.Vector3 a, UnityEngine.Vector3 b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Vector3Multiply
TYPE:  class
TOKEN: 0x2000151
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  UnityEngine.Vector3 Invoke(UnityEngine.Vector3 a, System.Single b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Vector3Divide
TYPE:  class
TOKEN: 0x2000152
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  UnityEngine.Vector3 Invoke(UnityEngine.Vector3 a, System.Single b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Vector3Invert
TYPE:  class
TOKEN: 0x2000153
EXTENDS: PureFunctionNode`2
FIELDS:
METHODS:
  UnityEngine.Vector3 Invoke(UnityEngine.Vector3 value)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.BitwiseAnd`1
TYPE:  class
TOKEN: 0x2000154
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  T Invoke(T a, T b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.BitwiseOr`1
TYPE:  class
TOKEN: 0x2000155
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  T Invoke(T a, T b)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.BitwiseInvert`1
TYPE:  class
TOKEN: 0x2000156
EXTENDS: PureFunctionNode`2
FIELDS:
METHODS:
  T Invoke(T a)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Wait
TYPE:  class
TOKEN: 0x2000157
EXTENDS: LatentActionNode`1
FIELDS:
  private           System.Single                   <timeLeft>k__BackingField  // 0x68
  private           System.Single                   <normalized>k__BackingField  // 0x6C
METHODS:
  System.Single get_timeLeft()
  System.Void set_timeLeft(System.Single value)
  System.Single get_normalized()
  System.Void set_normalized(System.Single value)
  System.Collections.IEnumerator Invoke(System.Single time)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.WaitForOneFrame
TYPE:  class
TOKEN: 0x2000159
EXTENDS: LatentActionNode
FIELDS:
METHODS:
  System.Boolean get_allowRoutineQueueing()
  System.Collections.IEnumerator Invoke()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.WaitForPhysicsFrame
TYPE:  class
TOKEN: 0x200015B
EXTENDS: LatentActionNode
FIELDS:
METHODS:
  System.Boolean get_allowRoutineQueueing()
  System.Collections.IEnumerator Invoke()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.WaitForEndOfFrame
TYPE:  class
TOKEN: 0x200015D
EXTENDS: LatentActionNode
FIELDS:
METHODS:
  System.Boolean get_allowRoutineQueueing()
  System.Collections.IEnumerator Invoke()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.WaitUntil
TYPE:  class
TOKEN: 0x200015F
EXTENDS: LatentActionNode
FIELDS:
  private           FlowCanvas.ValueInput<System.Boolean>condition  // 0x68
METHODS:
  System.Boolean get_allowRoutineQueueing()
  System.Collections.IEnumerator Invoke()
  System.Void OnRegisterExtraPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.WaitWhile
TYPE:  class
TOKEN: 0x2000161
EXTENDS: LatentActionNode
FIELDS:
  private           FlowCanvas.ValueInput<System.Boolean>condition  // 0x68
METHODS:
  System.Boolean get_allowRoutineQueueing()
  System.Collections.IEnumerator Invoke()
  System.Void OnRegisterExtraPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.DeltaTimed
TYPE:  class
TOKEN: 0x2000163
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  System.Single Invoke(System.Single value, System.Single multiplier)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.DeltaTimedVector3
TYPE:  class
TOKEN: 0x2000164
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  UnityEngine.Vector3 Invoke(UnityEngine.Vector3 value, System.Single multiplier)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Buffer`1
TYPE:  class
TOKEN: 0x2000165
EXTENDS: PureFunctionNode`3
FIELDS:
  private           System.Int32                    lastFrame  // 0x0
  private           System.Collections.Generic.Queue<T>q  // 0x0
METHODS:
  T Invoke(T value, System.Int32 size)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.DampFloat
TYPE:  class
TOKEN: 0x2000166
EXTENDS: PureFunctionNode`4
FIELDS:
METHODS:
  System.Single Invoke(System.Single current, System.Single target, System.Single damp)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.DampVector3
TYPE:  class
TOKEN: 0x2000167
EXTENDS: PureFunctionNode`4
FIELDS:
METHODS:
  UnityEngine.Vector3 Invoke(UnityEngine.Vector3 current, UnityEngine.Vector3 target, System.Single damp)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LerpFloat
TYPE:  class
TOKEN: 0x2000168
EXTENDS: PureFunctionNode`5
FIELDS:
METHODS:
  System.Single Invoke(System.Single a, System.Single b, System.Single t, ParadoxNotion.Animation.EaseType interpolation)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LerpVector3
TYPE:  class
TOKEN: 0x2000169
EXTENDS: PureFunctionNode`5
FIELDS:
METHODS:
  UnityEngine.Vector3 Invoke(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single t, ParadoxNotion.Animation.EaseType interpolation)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LerpQuaternion
TYPE:  class
TOKEN: 0x200016A
EXTENDS: PureFunctionNode`5
FIELDS:
METHODS:
  UnityEngine.Quaternion Invoke(UnityEngine.Quaternion a, UnityEngine.Quaternion b, System.Single t, ParadoxNotion.Animation.EaseType interpolation)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LerpColor
TYPE:  class
TOKEN: 0x200016B
EXTENDS: PureFunctionNode`5
FIELDS:
METHODS:
  UnityEngine.Color Invoke(UnityEngine.Color a, UnityEngine.Color b, System.Single t, ParadoxNotion.Animation.EaseType interpolation)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.TweenFloat
TYPE:  class
TOKEN: 0x200016C
EXTENDS: LatentActionNode`4
FIELDS:
  private           System.Single                   <value>k__BackingField  // 0x68
METHODS:
  System.Single get_value()
  System.Void set_value(System.Single value)
  System.Collections.IEnumerator Invoke(System.Single from, System.Single to, System.Single duration, ParadoxNotion.Animation.EaseType interpolation)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.TweenVector3
TYPE:  class
TOKEN: 0x200016E
EXTENDS: LatentActionNode`4
FIELDS:
  private           UnityEngine.Vector3             <value>k__BackingField  // 0x68
METHODS:
  UnityEngine.Vector3 get_value()
  System.Void set_value(UnityEngine.Vector3 value)
  System.Collections.IEnumerator Invoke(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single duration, ParadoxNotion.Animation.EaseType interpolation)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.TweenQuaternion
TYPE:  class
TOKEN: 0x2000170
EXTENDS: LatentActionNode`4
FIELDS:
  private           UnityEngine.Quaternion          <value>k__BackingField  // 0x68
METHODS:
  UnityEngine.Quaternion get_value()
  System.Void set_value(UnityEngine.Quaternion value)
  System.Collections.IEnumerator Invoke(UnityEngine.Quaternion from, UnityEngine.Quaternion to, System.Single duration, ParadoxNotion.Animation.EaseType interpolation)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.TweenColor
TYPE:  class
TOKEN: 0x2000172
EXTENDS: LatentActionNode`4
FIELDS:
  private           UnityEngine.Color               <value>k__BackingField  // 0x68
METHODS:
  UnityEngine.Color get_value()
  System.Void set_value(UnityEngine.Color value)
  System.Collections.IEnumerator Invoke(UnityEngine.Color from, UnityEngine.Color to, System.Single duration, ParadoxNotion.Animation.EaseType interpolation)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.TweenPosition
TYPE:  class
TOKEN: 0x2000174
EXTENDS: LatentActionNode`5
FIELDS:
METHODS:
  System.Collections.IEnumerator Invoke(UnityEngine.Transform transform, UnityEngine.Vector3 position, System.Single duration, ParadoxNotion.Animation.EaseType interpolation, System.Boolean relative)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.TweenRotation
TYPE:  class
TOKEN: 0x2000176
EXTENDS: LatentActionNode`5
FIELDS:
METHODS:
  System.Collections.IEnumerator Invoke(UnityEngine.Transform transform, UnityEngine.Vector3 rotation, System.Single duration, ParadoxNotion.Animation.EaseType interpolation, System.Boolean relative)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.TweenScale
TYPE:  class
TOKEN: 0x2000178
EXTENDS: LatentActionNode`5
FIELDS:
METHODS:
  System.Collections.IEnumerator Invoke(UnityEngine.Transform transform, UnityEngine.Vector3 scale, System.Single duration, ParadoxNotion.Animation.EaseType interpolation, System.Boolean relative)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.AddComponent`1
TYPE:  class
TOKEN: 0x200017A
EXTENDS: CallableFunctionNode`3
FIELDS:
METHODS:
  T Invoke(UnityEngine.GameObject gameObject, System.Boolean tryGetExisting)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.GetComponent`1
TYPE:  class
TOKEN: 0x200017B
EXTENDS: PureFunctionNode`2
FIELDS:
  private           T                               _component  // 0x0
METHODS:
  T Invoke(UnityEngine.GameObject gameObject)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Instantiate`1
TYPE:  class
TOKEN: 0x200017C
EXTENDS: CallableFunctionNode`5
FIELDS:
METHODS:
  T Invoke(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.NewScriptableObject`1
TYPE:  class
TOKEN: 0x200017D
EXTENDS: CallableFunctionNode`1
FIELDS:
METHODS:
  T Invoke()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.GetChildTransforms
TYPE:  class
TOKEN: 0x200017E
EXTENDS: PureFunctionNode`2
FIELDS:
METHODS:
  System.Collections.Generic.IEnumerable<UnityEngine.Transform> Invoke(UnityEngine.Transform parent)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Cast`1
TYPE:  class
TOKEN: 0x200017F
EXTENDS: PureFunctionNode`2
FIELDS:
METHODS:
  T Invoke(System.Object obj)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Identity`1
TYPE:  class
TOKEN: 0x2000180
EXTENDS: PureFunctionNode`2
FIELDS:
METHODS:
  System.String get_name()
  T Invoke(T value)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Cache`1
TYPE:  class
TOKEN: 0x2000181
EXTENDS: CallableFunctionNode`2
FIELDS:
METHODS:
  T Invoke(T value)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.RemapFloat
TYPE:  class
TOKEN: 0x2000182
EXTENDS: PureFunctionNode`6
FIELDS:
METHODS:
  System.Single Invoke(System.Single current, System.Single iMin, System.Single iMax, System.Single oMin, System.Single oMax)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.RemapVector3
TYPE:  class
TOKEN: 0x2000183
EXTENDS: PureFunctionNode`6
FIELDS:
METHODS:
  UnityEngine.Vector3 Invoke(System.Single current, System.Single iMin, System.Single iMax, UnityEngine.Vector3 oMin, UnityEngine.Vector3 oMax)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LogValue
TYPE:  class
TOKEN: 0x2000184
EXTENDS: CallableActionNode`1
FIELDS:
METHODS:
  System.Void Invoke(System.Object obj)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LogText
TYPE:  class
TOKEN: 0x2000185
EXTENDS: CallableActionNode`1
FIELDS:
METHODS:
  System.Void Invoke(System.String text)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SendEvent
TYPE:  class
TOKEN: 0x2000186
EXTENDS: CallableActionNode`2
FIELDS:
METHODS:
  System.Void Invoke(NodeCanvas.Framework.GraphOwner target, System.String eventName)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SendEvent`1
TYPE:  class
TOKEN: 0x2000187
EXTENDS: CallableActionNode`3
FIELDS:
METHODS:
  System.Void Invoke(NodeCanvas.Framework.GraphOwner target, System.String eventName, T eventValue)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SendGlobalEvent
TYPE:  class
TOKEN: 0x2000188
EXTENDS: CallableActionNode`1
FIELDS:
METHODS:
  System.Void Invoke(System.String eventName)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SendGlobalEvent`1
TYPE:  class
TOKEN: 0x2000189
EXTENDS: CallableActionNode`2
FIELDS:
METHODS:
  System.Void Invoke(System.String eventName, T eventValue)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LatentActionNodeBase
TYPE:  class
TOKEN: 0x200018A
EXTENDS: SimplexNode
FIELDS:
  public            FlowCanvas.Nodes.LatentActionNodeBase.InvocationModeinvocationMode  // 0x30
  private           FlowCanvas.FlowOutput           onStart  // 0x38
  private           FlowCanvas.FlowOutput           onUpdate  // 0x40
  private           FlowCanvas.FlowOutput           onFinish  // 0x48
  private           System.Collections.Generic.Queue<FlowCanvas.Nodes.LatentActionNodeBase.RoutineData>routineQueue  // 0x50
  private           UnityEngine.Coroutine           currentCoroutine  // 0x58
  private           System.Boolean                  graphStoped  // 0x60
METHODS:
  System.String get_name()
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void Begin(System.Collections.IEnumerator enumerator, FlowCanvas.Flow f)
  System.Void BreakAll(System.Boolean callFinish)
  System.Collections.IEnumerator InternalCoroutine(FlowCanvas.Nodes.LatentActionNodeBase.RoutineData data)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node)
  System.Void OnBreak()
  System.Boolean get_allowRoutineQueueing()
  System.Void .ctor()
  System.Void <InternalCoroutine>b__15_0()
  System.Void <OnRegisterPorts>b__16_0(FlowCanvas.Flow f)
  System.Void <OnRegisterPorts>b__16_1(FlowCanvas.Flow f)
END_CLASS

CLASS: FlowCanvas.Nodes.LatentActionNode
TYPE:  class
TOKEN: 0x200018E
EXTENDS: LatentActionNodeBase
FIELDS:
METHODS:
  System.Collections.IEnumerator Invoke()
  System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
  System.Void <OnRegisterDerivedPorts>b__1_0(FlowCanvas.Flow f)
END_CLASS

CLASS: FlowCanvas.Nodes.LatentActionNode`1
TYPE:  class
TOKEN: 0x200018F
EXTENDS: LatentActionNodeBase
FIELDS:
METHODS:
  System.Collections.IEnumerator Invoke(T1 a)
  System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LatentActionNode`2
TYPE:  class
TOKEN: 0x2000191
EXTENDS: LatentActionNodeBase
FIELDS:
METHODS:
  System.Collections.IEnumerator Invoke(T1 a, T2 b)
  System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LatentActionNode`3
TYPE:  class
TOKEN: 0x2000193
EXTENDS: LatentActionNodeBase
FIELDS:
METHODS:
  System.Collections.IEnumerator Invoke(T1 a, T2 b, T3 c)
  System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LatentActionNode`4
TYPE:  class
TOKEN: 0x2000195
EXTENDS: LatentActionNodeBase
FIELDS:
METHODS:
  System.Collections.IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d)
  System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LatentActionNode`5
TYPE:  class
TOKEN: 0x2000197
EXTENDS: LatentActionNodeBase
FIELDS:
METHODS:
  System.Collections.IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e)
  System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LatentActionNode`6
TYPE:  class
TOKEN: 0x2000199
EXTENDS: LatentActionNodeBase
FIELDS:
METHODS:
  System.Collections.IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
  System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LatentActionNode`7
TYPE:  class
TOKEN: 0x200019B
EXTENDS: LatentActionNodeBase
FIELDS:
METHODS:
  System.Collections.IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
  System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LatentActionNode`8
TYPE:  class
TOKEN: 0x200019D
EXTENDS: LatentActionNodeBase
FIELDS:
METHODS:
  System.Collections.IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
  System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LatentActionNode`9
TYPE:  class
TOKEN: 0x200019F
EXTENDS: LatentActionNodeBase
FIELDS:
METHODS:
  System.Collections.IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
  System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.LatentActionNode`10
TYPE:  class
TOKEN: 0x20001A1
EXTENDS: LatentActionNodeBase
FIELDS:
METHODS:
  System.Collections.IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
  System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.PureFunctionNodeBase
TYPE:  class
TOKEN: 0x20001A3
EXTENDS: SimplexNode
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.PureFunctionNode`1
TYPE:  class
TOKEN: 0x20001A4
EXTENDS: PureFunctionNodeBase
FIELDS:
METHODS:
  TResult Invoke()
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
  TResult <OnRegisterPorts>b__1_0()
END_CLASS

CLASS: FlowCanvas.Nodes.PureFunctionNode`2
TYPE:  class
TOKEN: 0x20001A5
EXTENDS: PureFunctionNodeBase
FIELDS:
METHODS:
  TResult Invoke(T1 a)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.PureFunctionNode`3
TYPE:  class
TOKEN: 0x20001A7
EXTENDS: PureFunctionNodeBase
FIELDS:
METHODS:
  TResult Invoke(T1 a, T2 b)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.PureFunctionNode`4
TYPE:  class
TOKEN: 0x20001A9
EXTENDS: PureFunctionNodeBase
FIELDS:
METHODS:
  TResult Invoke(T1 a, T2 b, T3 c)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.PureFunctionNode`5
TYPE:  class
TOKEN: 0x20001AB
EXTENDS: PureFunctionNodeBase
FIELDS:
METHODS:
  TResult Invoke(T1 a, T2 b, T3 c, T4 d)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.PureFunctionNode`6
TYPE:  class
TOKEN: 0x20001AD
EXTENDS: PureFunctionNodeBase
FIELDS:
METHODS:
  TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.PureFunctionNode`7
TYPE:  class
TOKEN: 0x20001AF
EXTENDS: PureFunctionNodeBase
FIELDS:
METHODS:
  TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.PureFunctionNode`8
TYPE:  class
TOKEN: 0x20001B1
EXTENDS: PureFunctionNodeBase
FIELDS:
METHODS:
  TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.PureFunctionNode`9
TYPE:  class
TOKEN: 0x20001B3
EXTENDS: PureFunctionNodeBase
FIELDS:
METHODS:
  TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.PureFunctionNode`10
TYPE:  class
TOKEN: 0x20001B5
EXTENDS: PureFunctionNodeBase
FIELDS:
METHODS:
  TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.PureFunctionNode`11
TYPE:  class
TOKEN: 0x20001B7
EXTENDS: PureFunctionNodeBase
FIELDS:
METHODS:
  TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SimplexNode
TYPE:  class
TOKEN: 0x20001B9
FIELDS:
  private           System.String                   _name  // 0x10
  private           System.String                   _description  // 0x18
  private           FlowCanvas.FlowNode             <parentNode>k__BackingField  // 0x20
  private           System.Reflection.ParameterInfo[]_parameters  // 0x28
METHODS:
  FlowCanvas.FlowNode get_parentNode()
  System.Void set_parentNode(FlowCanvas.FlowNode value)
  System.String get_name()
  System.String get_description()
  System.Reflection.ParameterInfo[] get_parameters()
  System.Void RegisterPorts(FlowCanvas.FlowNode node)
  System.Void SetDefaultParameters(FlowCanvas.FlowNode node)
  System.Void OnRegisterPorts(FlowCanvas.FlowNode node)
  System.Void OnRegisterExtraPorts(FlowCanvas.FlowNode node)
  System.Void OnGraphStarted()
  System.Void OnGraphPaused()
  System.Void OnGraphUnpaused()
  System.Void OnGraphStoped()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SimplexNodeWrapper
TYPE:  class
TOKEN: 0x20001BA
EXTENDS: FlowNode
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SimplexNodeWrapper`1
TYPE:  class
TOKEN: 0x20001BB
EXTENDS: SimplexNodeWrapper
FIELDS:
  private           T                               _simplexNode  // 0x0
METHODS:
  T get_simplexNode()
  System.String get_name()
  System.String get_description()
  System.Type GetNodeWildDefinitionType()
  System.Void OnCreate(NodeCanvas.Framework.Graph assignedGraph)
  System.Void OnGraphStarted()
  System.Void OnGraphPaused()
  System.Void OnGraphUnpaused()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.EventUniversalDelegate
TYPE:  class
TOKEN: 0x20001BC
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.Nodes.EventUniversalDelegate`1
TYPE:  class
TOKEN: 0x20001BD
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1)
  System.IAsyncResult BeginInvoke(T1 arg1, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.Nodes.EventUniversalDelegate`2
TYPE:  class
TOKEN: 0x20001BE
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2)
  System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.Nodes.EventUniversalDelegate`3
TYPE:  class
TOKEN: 0x20001BF
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3)
  System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.Nodes.EventUniversalDelegate`4
TYPE:  class
TOKEN: 0x20001C0
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.Nodes.EventUniversalDelegate`5
TYPE:  class
TOKEN: 0x20001C1
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.Nodes.EventUniversalDelegate`6
TYPE:  class
TOKEN: 0x20001C2
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
  System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.Nodes.EventUniversalDelegate`7
TYPE:  class
TOKEN: 0x20001C3
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
  System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.Nodes.EventUniversalDelegate`8
TYPE:  class
TOKEN: 0x20001C4
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
  System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.Nodes.EventUniversalDelegate`9
TYPE:  class
TOKEN: 0x20001C5
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
  System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.Nodes.EventUniversalDelegate`10
TYPE:  class
TOKEN: 0x20001C6
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
  System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.Nodes.GeneratedKeyAttribute
TYPE:  class
TOKEN: 0x20001C7
EXTENDS: Attribute
FIELDS:
  private           System.String                   memberString  // 0x10
METHODS:
  System.Void .ctor(System.String memberName)
  System.String get_MemberName()
END_CLASS

CLASS: FlowCanvas.Nodes.ParamDef
TYPE:  struct
TOKEN: 0x20001C8
FIELDS:
  public            System.Type                     paramType  // 0x10
  public            System.Type                     arrayType  // 0x18
  public            FlowCanvas.Nodes.ParamMode      paramMode  // 0x20
  public            System.String                   portName  // 0x28
  public            System.String                   portId  // 0x30
  public            System.Boolean                  isParamsArray  // 0x38
  public            System.Reflection.MemberInfo    presentedInfo  // 0x40
METHODS:
END_CLASS

CLASS: FlowCanvas.Nodes.ParametresDef
TYPE:  struct
TOKEN: 0x20001C9
FIELDS:
  public            System.Collections.Generic.List<FlowCanvas.Nodes.ParamDef>paramDefinitions  // 0x10
  public            FlowCanvas.Nodes.ParamDef       instanceDef  // 0x18
  public            FlowCanvas.Nodes.ParamDef       resultDef  // 0x50
METHODS:
END_CLASS

CLASS: FlowCanvas.Nodes.ParamMode
TYPE:  struct
TOKEN: 0x20001CA
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  FlowCanvas.Nodes.ParamMode      Undefined  // 0x0
  public    static  FlowCanvas.Nodes.ParamMode      In  // 0x0
  public    static  FlowCanvas.Nodes.ParamMode      Out  // 0x0
  public    static  FlowCanvas.Nodes.ParamMode      Ref  // 0x0
  public    static  FlowCanvas.Nodes.ParamMode      Instance  // 0x0
  public    static  FlowCanvas.Nodes.ParamMode      Result  // 0x0
METHODS:
END_CLASS

CLASS: FlowCanvas.Nodes.ReflectedNodesHelper
TYPE:  class
TOKEN: 0x20001CB
FIELDS:
  private   static  System.String                   RETURN_VALUE_NAME  // 0x0
METHODS:
  FlowCanvas.Nodes.ParamDef GetGetterDefFromInfo(System.Reflection.MemberInfo info)
  FlowCanvas.Nodes.ParamDef GetDefFromInfo(System.Reflection.ParameterInfo info, System.Boolean last)
  System.Boolean InitParams(System.Type targetType, System.Boolean isStatic, System.Reflection.MemberInfo[] infos, FlowCanvas.Nodes.ParametresDef& parametres)
  System.Boolean InitParams(System.Reflection.ParameterInfo[] prms, System.Type returnType, FlowCanvas.Nodes.ParametresDef& parametres)
  System.Boolean InitParams(System.Reflection.ConstructorInfo constructor, FlowCanvas.Nodes.ParametresDef& parametres)
  System.Boolean InitParams(System.Reflection.MethodInfo method, FlowCanvas.Nodes.ParametresDef& parametres)
  System.Boolean InitParams(System.Reflection.FieldInfo field, FlowCanvas.Nodes.ParametresDef& parametres)
  System.String GetGeneratedKey(System.Reflection.MemberInfo memberInfo)
END_CLASS

CLASS: FlowCanvas.Nodes.UniversalDelegate
TYPE:  class
TOKEN: 0x20001CC
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(FlowCanvas.Nodes.UniversalDelegateParam[] delegateParams)
  System.IAsyncResult BeginInvoke(FlowCanvas.Nodes.UniversalDelegateParam[] delegateParams, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FlowCanvas.Nodes.UniversalDelegateParam
TYPE:  class
TOKEN: 0x20001CD
FIELDS:
  public            FlowCanvas.Nodes.ParamDef       paramDef  // 0x10
  public            System.Boolean                  paramsArrayNeeded  // 0x48
  public            System.Int32                    paramsArrayCount  // 0x4C
  public            FlowCanvas.Nodes.UniversalDelegatereferencedDelegate  // 0x50
  public            FlowCanvas.Nodes.UniversalDelegateParam[]referencedParams  // 0x58
METHODS:
  System.Type GetCurrentType()
  System.Void RegisterAsInput(FlowCanvas.FlowNode node)
  System.Void RegisterAsOutput(FlowCanvas.FlowNode node)
  System.Void RegisterAsOutput(FlowCanvas.FlowNode node, System.Action beforeReturn)
  System.Void RegisterAsOutput(FlowCanvas.FlowNode node, System.Action<FlowCanvas.Nodes.UniversalDelegateParam> beforeReturn)
  System.Void SetFromInput()
  System.Void SetFromValue(System.Object value)
  System.Reflection.FieldInfo get_ValueField()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.UniversalDelegateParam`1
TYPE:  class
TOKEN: 0x20001CE
EXTENDS: UniversalDelegateParam
FIELDS:
  public            T                               value  // 0x0
  private           FlowCanvas.ValueInput<T>        valueInput  // 0x0
  private   static  System.Reflection.FieldInfo     _fieldInfo  // 0x0
METHODS:
  System.Void .ctor()
  System.Type GetCurrentType()
  System.Void RegisterAsInput(FlowCanvas.FlowNode node)
  System.Void RegisterAsOutputInternal(FlowCanvas.FlowNode node, System.Delegate beforeReturn)
  System.Void RegisterAsOutput(FlowCanvas.FlowNode node)
  System.Void RegisterAsOutput(FlowCanvas.FlowNode node, System.Action beforeReturn)
  System.Void RegisterAsOutput(FlowCanvas.FlowNode node, System.Action<FlowCanvas.Nodes.UniversalDelegateParam> beforeReturn)
  System.Void SetFromInput()
  System.Void SetFromValue(System.Object newValue)
  System.Reflection.FieldInfo get_ValueField()
END_CLASS

CLASS: FlowCanvas.Nodes.UniversalDelegateParam`2
TYPE:  class
TOKEN: 0x20001D0
EXTENDS: UniversalDelegateParam`1
FIELDS:
  private           FlowCanvas.ValueInput<TValue>[] valueInputs  // 0x0
METHODS:
  System.Void RegisterAsInput(FlowCanvas.FlowNode node)
  System.Void SetFromInput()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.BaseReflectedConstructorNode
TYPE:  class
TOKEN: 0x20001D1
FIELDS:
  private   static  System.Func<System.Reflection.ConstructorInfo,FlowCanvas.Nodes.BaseReflectedConstructorNode>OnGetAotReflectedConstructorNode  // 0x0
  protected         System.Reflection.ConstructorInfoconstructorInfo  // 0x10
  protected         System.Collections.Generic.List<FlowCanvas.Nodes.ParamDef>paramDefinitions  // 0x18
  protected         FlowCanvas.Nodes.ParamDef       instanceDef  // 0x20
  protected         FlowCanvas.Nodes.ParamDef       resultDef  // 0x58
  protected         FlowCanvas.Nodes.ReflectedMethodRegistrationOptionsoptions  // 0x90
METHODS:
  System.Void add_OnGetAotReflectedConstructorNode(System.Func<System.Reflection.ConstructorInfo,FlowCanvas.Nodes.BaseReflectedConstructorNode> value)
  System.Void remove_OnGetAotReflectedConstructorNode(System.Func<System.Reflection.ConstructorInfo,FlowCanvas.Nodes.BaseReflectedConstructorNode> value)
  FlowCanvas.Nodes.BaseReflectedConstructorNode GetConstructorNode(System.Reflection.ConstructorInfo targetConstructor, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Boolean Init(System.Reflection.ConstructorInfo constructor, FlowCanvas.Nodes.ParametresDef parametres)
  System.Boolean InitInternal(System.Reflection.ConstructorInfo constructor)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.PureReflectionConstructorNode
TYPE:  class
TOKEN: 0x20001D2
EXTENDS: BaseReflectedConstructorNode
FIELDS:
  private           System.Object                   resultObject  // 0x98
  private           System.Object[]                 callParams  // 0xA0
  private           FlowCanvas.ValueInput[]         inputs  // 0xA8
  private           FlowCanvas.ValueInput[]         arrayInputs  // 0xB0
  private           System.Int32                    arrayParamsInput  // 0xB8
  private           System.Type                     arrayParamsType  // 0xC0
METHODS:
  System.Boolean InitInternal(System.Reflection.ConstructorInfo constructor)
  System.Void Call()
  System.Void RegisterOutput(FlowCanvas.FlowNode node, System.Boolean callable, FlowCanvas.Nodes.ParamDef def, System.Int32 idx)
  System.Void RegisterInput(FlowCanvas.FlowNode node, FlowCanvas.Nodes.ParamDef def, System.Int32 idx)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ReflectedDelegateEvent
TYPE:  class
TOKEN: 0x20001D6
FIELDS:
  private           FlowCanvas.Nodes.ReflectedDelegateEvent.DelegateEventCallbackonCallback  // 0x10
  private           System.Delegate                 theDelegate  // 0x18
METHODS:
  System.Void add_onCallback(FlowCanvas.Nodes.ReflectedDelegateEvent.DelegateEventCallback value)
  System.Void remove_onCallback(FlowCanvas.Nodes.ReflectedDelegateEvent.DelegateEventCallback value)
  System.Void .ctor()
  System.Void .ctor(System.Type delegateType)
  System.Void Add(FlowCanvas.Nodes.ReflectedDelegateEvent.DelegateEventCallback callback)
  System.Void Remove(FlowCanvas.Nodes.ReflectedDelegateEvent.DelegateEventCallback callback)
  System.Delegate AsDelegate()
  System.Reflection.MethodInfo GetMethodForDelegateType(System.Type delegateType)
  System.Void Callback0()
  System.Void Callback1(T0 arg0)
  System.Void Callback2(T0 arg0, T1 arg1)
  System.Void Callback3(T0 arg0, T1 arg1, T2 arg2)
  System.Void Callback4(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
  System.Void Callback5(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  System.Void Callback6(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  System.Void Callback7(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
  System.Void Callback8(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
  System.Void Callback9(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
  System.Void Callback10(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
  System.Delegate op_Explicit(FlowCanvas.Nodes.ReflectedDelegateEvent that)
END_CLASS

CLASS: FlowCanvas.Nodes.ReflectedUnityEvent
TYPE:  class
TOKEN: 0x20001D9
FIELDS:
  private           FlowCanvas.Nodes.ReflectedUnityEvent.UnityEventCallback_callback  // 0x10
  private           System.Type                     _eventType  // 0x18
  private           System.Reflection.MethodInfo    _addListenerMethod  // 0x20
  private           System.Reflection.MethodInfo    _removeListenerMethod  // 0x28
  private           System.Reflection.ParameterInfo[]_parameters  // 0x30
  private           System.Reflection.MethodInfo    _callMethod  // 0x38
METHODS:
  System.Void add__callback(FlowCanvas.Nodes.ReflectedUnityEvent.UnityEventCallback value)
  System.Void remove__callback(FlowCanvas.Nodes.ReflectedUnityEvent.UnityEventCallback value)
  System.Reflection.ParameterInfo[] get_parameters()
  System.Type get_eventType()
  System.Void .ctor()
  System.Void .ctor(System.Type eventType)
  System.Void InitForEventType(System.Type eventType)
  System.Void StartListening(UnityEngine.Events.UnityEventBase targetEvent, FlowCanvas.Nodes.ReflectedUnityEvent.UnityEventCallback callback)
  System.Void StopListening(UnityEngine.Events.UnityEventBase targetEvent, FlowCanvas.Nodes.ReflectedUnityEvent.UnityEventCallback callback)
  System.Void CallbackMethod0()
  System.Void CallbackMethod1(T0 arg0)
  System.Void CallbackMethod2(T0 arg0, T1 arg1)
  System.Void CallbackMethod3(T0 arg0, T1 arg1, T2 arg2)
  System.Void CallbackMethod4(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
END_CLASS

CLASS: FlowCanvas.Nodes.SharpEvent
TYPE:  class
TOKEN: 0x20001DC
FIELDS:
  private           System.Object                   <instance>k__BackingField  // 0x10
  private           System.Reflection.EventInfo     <eventInfo>k__BackingField  // 0x18
METHODS:
  System.Object get_instance()
  System.Void set_instance(System.Object value)
  System.Reflection.EventInfo get_eventInfo()
  System.Void set_eventInfo(System.Reflection.EventInfo value)
  FlowCanvas.Nodes.SharpEvent Create(System.Reflection.EventInfo eventInfo)
  System.Void SetInstance(System.Object instance)
  System.Void StartListening(FlowCanvas.Nodes.ReflectedDelegateEvent reflectedEvent, FlowCanvas.Nodes.ReflectedDelegateEvent.DelegateEventCallback callback)
  System.Void StopListening(FlowCanvas.Nodes.ReflectedDelegateEvent reflectedEvent, FlowCanvas.Nodes.ReflectedDelegateEvent.DelegateEventCallback callback)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SharpEvent`1
TYPE:  class
TOKEN: 0x20001DD
EXTENDS: SharpEvent
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.BaseReflectedExtractorNode
TYPE:  class
TOKEN: 0x20001DE
FIELDS:
  private   static  System.Func<System.Type,System.Boolean,System.Reflection.MemberInfo[],FlowCanvas.Nodes.BaseReflectedExtractorNode>OnGetAotExtractorNode  // 0x0
  private           FlowCanvas.Nodes.ParametresDef  <Params>k__BackingField  // 0x10
  private           System.Type                     <TargetType>k__BackingField  // 0x88
METHODS:
  System.Void add_OnGetAotExtractorNode(System.Func<System.Type,System.Boolean,System.Reflection.MemberInfo[],FlowCanvas.Nodes.BaseReflectedExtractorNode> value)
  System.Void remove_OnGetAotExtractorNode(System.Func<System.Type,System.Boolean,System.Reflection.MemberInfo[],FlowCanvas.Nodes.BaseReflectedExtractorNode> value)
  FlowCanvas.Nodes.BaseReflectedExtractorNode GetExtractorNode(System.Type targetType, System.Boolean isStatic, System.Reflection.MemberInfo[] infos)
  FlowCanvas.Nodes.ParametresDef get_Params()
  System.Void set_Params(FlowCanvas.Nodes.ParametresDef value)
  System.Type get_TargetType()
  System.Void set_TargetType(System.Type value)
  System.Boolean Init(FlowCanvas.Nodes.ParametresDef paramsDef, System.Type targetType)
  System.Boolean InitInternal()
  System.Void RegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.PureReflectedExtractorNode
TYPE:  class
TOKEN: 0x20001DF
EXTENDS: BaseReflectedExtractorNode
FIELDS:
  private   static readonly System.Object[]                 EmptyParams  // 0x0
  private           FlowCanvas.ValueInput           instanceInput  // 0x90
METHODS:
  System.Boolean InitInternal()
  FlowCanvas.ValueHandlerObject GetPortHandler(System.Reflection.FieldInfo info)
  FlowCanvas.ValueHandlerObject GetPortHandler(System.Reflection.MethodInfo info)
  System.Void RegisterPorts(FlowCanvas.FlowNode node)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: FlowCanvas.Nodes.BaseReflectedFieldNode
TYPE:  class
TOKEN: 0x20001E2
FIELDS:
  private   static  System.Func<System.Reflection.FieldInfo,FlowCanvas.Nodes.BaseReflectedFieldNode>OnGetAotReflectedFieldNode  // 0x0
  protected         System.Reflection.FieldInfo     fieldInfo  // 0x10
  protected         FlowCanvas.Nodes.ParamDef       instanceDef  // 0x18
  protected         FlowCanvas.Nodes.ParamDef       resultDef  // 0x50
METHODS:
  System.Void add_OnGetAotReflectedFieldNode(System.Func<System.Reflection.FieldInfo,FlowCanvas.Nodes.BaseReflectedFieldNode> value)
  System.Void remove_OnGetAotReflectedFieldNode(System.Func<System.Reflection.FieldInfo,FlowCanvas.Nodes.BaseReflectedFieldNode> value)
  FlowCanvas.Nodes.BaseReflectedFieldNode GetFieldNode(System.Reflection.FieldInfo targetField)
  System.Boolean Init(System.Reflection.FieldInfo field, FlowCanvas.Nodes.ParametresDef parametres)
  System.Boolean InitInternal(System.Reflection.FieldInfo field)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, FlowCanvas.Nodes.ReflectedFieldNodeWrapper.AccessMode accessMode)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.PureReflectedFieldNode
TYPE:  class
TOKEN: 0x20001E3
EXTENDS: BaseReflectedFieldNode
FIELDS:
  private           FlowCanvas.ValueInput           instanceInput  // 0x88
  private           FlowCanvas.ValueInput           valueInput  // 0x90
  private           System.Object                   instanceObject  // 0x98
  private           System.Object                   valueObject  // 0xA0
METHODS:
  System.Boolean InitInternal(System.Reflection.FieldInfo method)
  System.Void SetValue()
  System.Void GetValue()
  System.Void RegisterPorts(FlowCanvas.FlowNode node, FlowCanvas.Nodes.ReflectedFieldNodeWrapper.AccessMode accessMode)
  System.Void .ctor()
  System.Object <RegisterPorts>b__7_0()
  System.Object <RegisterPorts>b__7_1()
END_CLASS

CLASS: FlowCanvas.Nodes.BaseReflectedMethodNode
TYPE:  class
TOKEN: 0x20001E5
FIELDS:
  private   static  System.Func<System.Reflection.MethodInfo,FlowCanvas.Nodes.BaseReflectedMethodNode>OnGetAotReflectedMethodNode  // 0x0
  protected         System.Reflection.MethodInfo    methodInfo  // 0x10
  protected         System.Collections.Generic.List<FlowCanvas.Nodes.ParamDef>paramDefinitions  // 0x18
  protected         FlowCanvas.Nodes.ParamDef       instanceDef  // 0x20
  protected         FlowCanvas.Nodes.ParamDef       resultDef  // 0x58
  protected         FlowCanvas.Nodes.ReflectedMethodRegistrationOptionsoptions  // 0x90
METHODS:
  System.Void add_OnGetAotReflectedMethodNode(System.Func<System.Reflection.MethodInfo,FlowCanvas.Nodes.BaseReflectedMethodNode> value)
  System.Void remove_OnGetAotReflectedMethodNode(System.Func<System.Reflection.MethodInfo,FlowCanvas.Nodes.BaseReflectedMethodNode> value)
  FlowCanvas.Nodes.BaseReflectedMethodNode GetMethodNode(System.Reflection.MethodInfo targetMethod, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Boolean Init(System.Reflection.MethodInfo method, FlowCanvas.Nodes.ParametresDef parametres)
  System.Boolean InitInternal(System.Reflection.MethodInfo method)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.PureReflectedMethodNode
TYPE:  class
TOKEN: 0x20001E6
EXTENDS: BaseReflectedMethodNode
FIELDS:
  private           FlowCanvas.ValueInput           instanceInput  // 0x98
  private           System.Object                   instanceObject  // 0xA0
  private           System.Object                   resultObject  // 0xA8
  private           System.Object[]                 callParams  // 0xB0
  private           FlowCanvas.ValueInput[]         inputs  // 0xB8
  private           FlowCanvas.ValueInput[]         arrayInputs  // 0xC0
  private           System.Int32                    arrayParamsInput  // 0xC8
  private           System.Type                     arrayParamsType  // 0xD0
METHODS:
  System.Boolean InitInternal(System.Reflection.MethodInfo method)
  System.Void Call()
  System.Void RegisterOutput(FlowCanvas.FlowNode node, System.Boolean callable, FlowCanvas.Nodes.ParamDef def, System.Int32 idx)
  System.Void RegisterInput(FlowCanvas.FlowNode node, FlowCanvas.Nodes.ParamDef def, System.Int32 idx)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ReflectedConstructorNodeWrapper
TYPE:  class
TOKEN: 0x20001EA
EXTENDS: ReflectedMethodBaseNodeWrapper
FIELDS:
  private           ParadoxNotion.Serialization.SerializedConstructorInfo_constructor  // 0xB8
  private           FlowCanvas.Nodes.BaseReflectedConstructorNode<reflectedConstructorNode>k__BackingField  // 0xC0
METHODS:
  FlowCanvas.Nodes.BaseReflectedConstructorNode get_reflectedConstructorNode()
  System.Void set_reflectedConstructorNode(FlowCanvas.Nodes.BaseReflectedConstructorNode value)
  System.Reflection.ConstructorInfo get_constructor()
  ParadoxNotion.Serialization.ISerializedMethodBaseInfo get_serializedMethodBase()
  System.String get_name()
  System.Void SetMethodBase(System.Reflection.MethodBase newMethod, System.Object instance)
  System.Void SetConstructor(System.Reflection.ConstructorInfo newConstructor)
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ReflectedExtractorNodeWrapper`1
TYPE:  class
TOKEN: 0x20001EB
EXTENDS: FlowNode
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>_memberInfos  // 0x0
  private   static  System.Collections.Generic.List<System.String>_instanceMemberNames  // 0x0
  private   static  System.Collections.Generic.List<System.String>_staticMemberNames  // 0x0
  private           System.Collections.Generic.List<System.String>_selectedInstanceMembers  // 0x0
  private           FlowCanvas.Nodes.BaseReflectedExtractorNodeextractorNode  // 0x0
METHODS:
  System.Type GetRuntimeIconType()
  System.Void PopulateInfos()
  System.String get_name()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ReflectedFieldNodeWrapper_0
TYPE:  class
TOKEN: 0x20001EC
FIELDS:
  public            System.String                   fieldName  // 0x10
  public            System.Type                     targetType  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ReflectedFieldNodeWrapper
TYPE:  class
TOKEN: 0x20001ED
EXTENDS: FlowNode
FIELDS:
  private           ParadoxNotion.Serialization.SerializedFieldInfo_field  // 0xB0
  private           FlowCanvas.Nodes.ReflectedFieldNodeWrapper.AccessModeaccessMode  // 0xB8
  private           FlowCanvas.Nodes.BaseReflectedFieldNode<reflectedFieldNode>k__BackingField  // 0xC0
METHODS:
  System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<FlowCanvas.Nodes.ReflectedFieldNodeWrapper_0>.Migrate(FlowCanvas.Nodes.ReflectedFieldNodeWrapper_0 model)
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Type GetRuntimeIconType()
  FlowCanvas.Nodes.BaseReflectedFieldNode get_reflectedFieldNode()
  System.Void set_reflectedFieldNode(FlowCanvas.Nodes.BaseReflectedFieldNode value)
  System.Reflection.FieldInfo get_field()
  System.String get_name()
  System.Void SetField(System.Reflection.FieldInfo newField, FlowCanvas.Nodes.ReflectedFieldNodeWrapper.AccessMode mode, System.Object instance)
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ReflectedMethodBaseNodeWrapper
TYPE:  class
TOKEN: 0x20001EF
EXTENDS: FlowNode
FIELDS:
  protected         System.Boolean                  _callable  // 0xB0
  protected         System.Boolean                  _exposeParams  // 0xB1
  protected         System.Int32                    _exposedParamsCount  // 0xB4
METHODS:
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Type GetRuntimeIconType()
  ParadoxNotion.Serialization.ISerializedMethodBaseInfo get_serializedMethodBase()
  System.Reflection.MethodBase get_method()
  System.Boolean get_callable()
  System.Void set_callable(System.Boolean value)
  System.Boolean get_exposeParams()
  System.Void set_exposeParams(System.Boolean value)
  System.Int32 get_exposedParamsCount()
  System.Void set_exposedParamsCount(System.Int32 value)
  System.Void SetMethodBase(System.Reflection.MethodBase newMethod, System.Object instance)
  System.Void SetDefaultParameterValues(System.Reflection.MethodBase newMethod)
  System.Void SetDropInstanceReference(System.Reflection.MethodBase newMethod, System.Object instance)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ReflectedMethodNodeWrapper
TYPE:  class
TOKEN: 0x20001F0
EXTENDS: ReflectedMethodBaseNodeWrapper
FIELDS:
  private           ParadoxNotion.Serialization.SerializedMethodInfo_method  // 0xB8
  private           FlowCanvas.Nodes.BaseReflectedMethodNode<reflectedMethodNode>k__BackingField  // 0xC0
METHODS:
  FlowCanvas.Nodes.BaseReflectedMethodNode get_reflectedMethodNode()
  System.Void set_reflectedMethodNode(FlowCanvas.Nodes.BaseReflectedMethodNode value)
  System.Reflection.MethodInfo get_method()
  ParadoxNotion.Serialization.ISerializedMethodBaseInfo get_serializedMethodBase()
  System.String get_name()
  System.Void SetMethodBase(System.Reflection.MethodBase newMethod, System.Object instance)
  System.Void SetMethod(System.Reflection.MethodInfo newMethod, System.Object instance)
  System.Void OnPortConnected(FlowCanvas.Port port, FlowCanvas.Port otherPort)
  System.Type GetNodeWildDefinitionType()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ReflectedMethodRegistrationOptions
TYPE:  struct
TOKEN: 0x20001F1
FIELDS:
  public            System.Boolean                  callable  // 0x10
  public            System.Boolean                  exposeParams  // 0x11
  public            System.Int32                    exposedParamsCount  // 0x14
METHODS:
END_CLASS

CLASS: FlowCanvas.Nodes.FlowNestedBase`1
TYPE:  class
TOKEN: 0x20001F2
EXTENDS: FlowNodeNested`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<T>_subGraph  // 0x0
  private           FlowCanvas.ValueInput<UnityEngine.Component>targetAgent  // 0x0
  private           FlowCanvas.FlowOutput           onStart  // 0x0
  private           FlowCanvas.FlowOutput           onUpdate  // 0x0
  private           FlowCanvas.FlowOutput           onFinish  // 0x0
  private           System.Boolean                  paused  // 0x0
  private           System.Boolean                  endResult  // 0x0
METHODS:
  T get_subGraph()
  System.Void set_subGraph(T value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  ParadoxNotion.Alignment2x2 get_iconAlignment()
  System.Void FlowCanvas.Nodes.IDropedReferenceNode.SetTarget(UnityEngine.Object target)
  System.Void RegisterPorts()
  System.Void Start(FlowCanvas.Flow f)
  System.Void Stop(FlowCanvas.Flow f)
  System.Void OnStop(FlowCanvas.Flow f)
  System.Void Pause(FlowCanvas.Flow f)
  System.Void Resume(FlowCanvas.Flow f)
  System.Void NodeCanvas.Framework.IUpdatable.Update()
  System.Void .ctor()
  System.Single <RegisterPorts>b__15_0()
  System.Boolean <RegisterPorts>b__15_1()
END_CLASS

CLASS: FlowCanvas.Nodes.FlowNestedFlow
TYPE:  class
TOKEN: 0x20001F4
EXTENDS: FlowNestedBase`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CreateCollection`1
TYPE:  class
TOKEN: 0x20001F5
EXTENDS: FlowNode
FIELDS:
  private           System.Int32                    _portCount  // 0x0
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CreateDictionary`1
TYPE:  class
TOKEN: 0x20001F8
EXTENDS: FlowNode
FIELDS:
  private           System.Int32                    _portCount  // 0x0
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.GetOtherVariable`1
TYPE:  class
TOKEN: 0x20001FC
EXTENDS: FlowNode
FIELDS:
METHODS:
  System.String get_name()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.GetVariable`1
TYPE:  class
TOKEN: 0x20001FE
EXTENDS: ParameterVariableNode
FIELDS:
  public            NodeCanvas.Framework.BBParameter<T>value  // 0x0
METHODS:
  NodeCanvas.Framework.BBParameter get_parameter()
  System.Void RegisterPorts()
  System.Void .ctor()
  T <RegisterPorts>b__3_0()
END_CLASS

CLASS: FlowCanvas.Nodes.RelayValueInputBase
TYPE:  class
TOKEN: 0x20001FF
EXTENDS: FlowNode
FIELDS:
METHODS:
  System.Type get_relayType()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.RelayValueInput`1
TYPE:  class
TOKEN: 0x2000200
EXTENDS: RelayValueInputBase
FIELDS:
  public            System.String                   identifier  // 0x0
  private           FlowCanvas.ValueInput<T>        <port>k__BackingField  // 0x0
  private           System.Boolean                  <cached>k__BackingField  // 0x0
  private           T                               <cachedValue>k__BackingField  // 0x0
METHODS:
  FlowCanvas.ValueInput<T> get_port()
  System.Void set_port(FlowCanvas.ValueInput<T> value)
  System.Boolean get_cached()
  System.Void set_cached(System.Boolean value)
  T get_cachedValue()
  System.Void set_cachedValue(T value)
  System.Type get_relayType()
  System.String get_name()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.RelayValueOutputBase
TYPE:  class
TOKEN: 0x2000202
EXTENDS: FlowNode
FIELDS:
METHODS:
  System.Void SetSource(FlowCanvas.Nodes.RelayValueInputBase source)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.RelayValueOutput`1
TYPE:  class
TOKEN: 0x2000203
EXTENDS: RelayValueOutputBase
FIELDS:
  private           System.String                   _sourceInputUID  // 0x0
  private           System.WeakReference<FlowCanvas.Nodes.RelayValueInputBase>_sourceInputRef  // 0x0
METHODS:
  System.String get_sourceInputUID()
  System.Void set_sourceInputUID(System.String value)
  FlowCanvas.Nodes.RelayValueInput<T> get_sourceInput()
  System.String get_name()
  System.Void SetSource(FlowCanvas.Nodes.RelayValueInputBase source)
  System.Void RegisterPorts()
  System.Void .ctor()
  System.Boolean <get_sourceInput>b__6_0(FlowCanvas.Nodes.RelayValueInput<T> i)
  T <RegisterPorts>b__10_0()
END_CLASS

CLASS: FlowCanvas.Nodes.NullObject
TYPE:  class
TOKEN: 0x2000204
EXTENDS: FlowNode
FIELDS:
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.OwnerVariable
TYPE:  class
TOKEN: 0x2000206
EXTENDS: FlowNode
FIELDS:
METHODS:
  System.String get_name()
  System.Void RegisterPorts()
  System.Void .ctor()
  UnityEngine.GameObject <RegisterPorts>b__2_0()
END_CLASS

CLASS: FlowCanvas.Nodes.ParameterVariableNode
TYPE:  class
TOKEN: 0x2000207
EXTENDS: FlowNode
FIELDS:
METHODS:
  NodeCanvas.Framework.BBParameter get_parameter()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SetOtherVariable`1
TYPE:  class
TOKEN: 0x2000208
EXTENDS: FlowNode
FIELDS:
  public            ParadoxNotion.OperationMethod   operation  // 0x0
  private           FlowCanvas.ValueInput<System.String>varName  // 0x0
METHODS:
  System.String get_name()
  System.Void RegisterPorts()
  System.Void DoSet(NodeCanvas.Framework.Blackboard bb, System.String name, T value)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SetVariable`1
TYPE:  class
TOKEN: 0x200020A
EXTENDS: ParameterVariableNode
FIELDS:
  public            NodeCanvas.Framework.BBParameter<T>targetVariable  // 0x0
  public            ParadoxNotion.OperationMethod   operation  // 0x0
  public            System.Boolean                  perSecond  // 0x0
METHODS:
  NodeCanvas.Framework.BBParameter get_parameter()
  System.String get_name()
  System.Void RegisterPorts()
  System.Void DoSet(T value)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CodeEventBase
TYPE:  class
TOKEN: 0x200020C
EXTENDS: EventNode`1
FIELDS:
  protected         System.String                   eventName  // 0xB8
  protected         System.Type                     targetType  // 0xC0
  protected         UnityEngine.Component           targetComponent  // 0xC8
METHODS:
  System.Reflection.EventInfo get_eventInfo()
  System.Void SetEvent(System.Reflection.EventInfo e, System.Object instace)
  System.Void OnPostGraphStarted()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CodeEvent
TYPE:  class
TOKEN: 0x200020D
EXTENDS: CodeEventBase
FIELDS:
  private           FlowCanvas.FlowOutput           o  // 0xD0
  private           System.Action                   pointer  // 0xD8
METHODS:
  System.Void OnPostGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void Call()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CodeEvent`1
TYPE:  class
TOKEN: 0x200020E
EXTENDS: CodeEventBase
FIELDS:
  private           FlowCanvas.FlowOutput           o  // 0x0
  private           System.Action<T>                pointer  // 0x0
  private           T                               eventValue  // 0x0
METHODS:
  System.Void OnPostGraphStarted()
  System.Void OnGraphStoped()
  System.Void Call(T eventValue)
  System.Void RegisterPorts()
  System.Void .ctor()
  T <RegisterPorts>b__6_0()
END_CLASS

CLASS: FlowCanvas.Nodes.NewGameObject
TYPE:  class
TOKEN: 0x200020F
EXTENDS: CallableFunctionNode`4
FIELDS:
METHODS:
  UnityEngine.GameObject Invoke(System.String name, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.NewVector2
TYPE:  class
TOKEN: 0x2000210
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  UnityEngine.Vector2 Invoke(System.Single x, System.Single y)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.NewVector3
TYPE:  class
TOKEN: 0x2000211
EXTENDS: PureFunctionNode`4
FIELDS:
METHODS:
  UnityEngine.Vector3 Invoke(System.Single x, System.Single y, System.Single z)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.NewVector4
TYPE:  class
TOKEN: 0x2000212
EXTENDS: PureFunctionNode`5
FIELDS:
METHODS:
  UnityEngine.Vector4 Invoke(System.Single x, System.Single y, System.Single z, System.Single w)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.NewQuaternion
TYPE:  class
TOKEN: 0x2000213
EXTENDS: PureFunctionNode`5
FIELDS:
METHODS:
  UnityEngine.Quaternion Invoke(System.Single x, System.Single y, System.Single z, System.Single w)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.NewColor
TYPE:  class
TOKEN: 0x2000214
EXTENDS: PureFunctionNode`5
FIELDS:
METHODS:
  UnityEngine.Color Invoke(System.Single r, System.Single g, System.Single b, System.Single a)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.NewBounds
TYPE:  class
TOKEN: 0x2000215
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  UnityEngine.Bounds Invoke(UnityEngine.Vector3 center, UnityEngine.Vector3 size)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.NewRect
TYPE:  class
TOKEN: 0x2000216
EXTENDS: PureFunctionNode`5
FIELDS:
METHODS:
  UnityEngine.Rect Invoke(System.Single left, System.Single top, System.Single width, System.Single height)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.NewRay
TYPE:  class
TOKEN: 0x2000217
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  UnityEngine.Ray Invoke(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ConvertTo`1
TYPE:  class
TOKEN: 0x2000218
EXTENDS: PureFunctionNode`2
FIELDS:
METHODS:
  T Invoke(System.IConvertible obj)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CastTo`1
TYPE:  class
TOKEN: 0x2000219
EXTENDS: PureFunctionNode`2
FIELDS:
METHODS:
  T Invoke(System.Object obj)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ToArray`1
TYPE:  class
TOKEN: 0x200021A
EXTENDS: PureFunctionNode`2
FIELDS:
METHODS:
  T[] Invoke(System.Collections.Generic.IList<T> list)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ToList`1
TYPE:  class
TOKEN: 0x200021B
EXTENDS: PureFunctionNode`2
FIELDS:
METHODS:
  System.Collections.Generic.List<T> Invoke(System.Collections.Generic.IList<T> list)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CustomObjectWrapper
TYPE:  class
TOKEN: 0x200021C
EXTENDS: FlowNode
FIELDS:
METHODS:
  System.Void SetTarget(UnityEngine.Object target)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.CustomObjectWrapper`1
TYPE:  class
TOKEN: 0x200021D
EXTENDS: CustomObjectWrapper
FIELDS:
  private           T                               _target  // 0x0
METHODS:
  T get_target()
  System.Void set_target(T value)
  System.String get_name()
  System.Void SetTarget(UnityEngine.Object target)
  System.Type GetRuntimeIconType()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractVector2
TYPE:  class
TOKEN: 0x200021E
EXTENDS: ExtractorNode`3
FIELDS:
METHODS:
  System.Void Invoke(UnityEngine.Vector2 vector, System.Single& x, System.Single& y)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractVector3
TYPE:  class
TOKEN: 0x200021F
EXTENDS: ExtractorNode`4
FIELDS:
METHODS:
  System.Void Invoke(UnityEngine.Vector3 vector, System.Single& x, System.Single& y, System.Single& z)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractVector4
TYPE:  class
TOKEN: 0x2000220
EXTENDS: ExtractorNode`5
FIELDS:
METHODS:
  System.Void Invoke(UnityEngine.Vector4 vector, System.Single& x, System.Single& y, System.Single& z, System.Single& w)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractQuaternion
TYPE:  class
TOKEN: 0x2000221
EXTENDS: ExtractorNode`6
FIELDS:
METHODS:
  System.Void Invoke(UnityEngine.Quaternion quaternion, System.Single& x, System.Single& y, System.Single& z, System.Single& w, UnityEngine.Vector3& eulerAngles)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractRect
TYPE:  class
TOKEN: 0x2000222
EXTENDS: ExtractorNode`6
FIELDS:
METHODS:
  System.Void Invoke(UnityEngine.Rect rect, UnityEngine.Vector2& center, System.Single& xMin, System.Single& xMax, System.Single& yMin, System.Single& yMax)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractColor
TYPE:  class
TOKEN: 0x2000223
EXTENDS: ExtractorNode`5
FIELDS:
METHODS:
  System.Void Invoke(UnityEngine.Color color, System.Single& r, System.Single& g, System.Single& b, System.Single& a)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractRaycastHit
TYPE:  class
TOKEN: 0x2000224
EXTENDS: ExtractorNode`5
FIELDS:
METHODS:
  System.Void Invoke(UnityEngine.RaycastHit hit, UnityEngine.GameObject& gameObject, System.Single& distance, UnityEngine.Vector3& normal, UnityEngine.Vector3& point)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractRaycastHit2D
TYPE:  class
TOKEN: 0x2000225
EXTENDS: ExtractorNode`6
FIELDS:
METHODS:
  System.Void Invoke(UnityEngine.RaycastHit2D hit, UnityEngine.GameObject& gameObject, System.Single& distance, System.Single& fraction, UnityEngine.Vector3& normal, UnityEngine.Vector3& point)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractRay
TYPE:  class
TOKEN: 0x2000226
EXTENDS: ExtractorNode`3
FIELDS:
METHODS:
  System.Void Invoke(UnityEngine.Ray ray, UnityEngine.Vector3& origin, UnityEngine.Vector3& direction)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractBounds
TYPE:  class
TOKEN: 0x2000227
EXTENDS: ExtractorNode`6
FIELDS:
METHODS:
  System.Void Invoke(UnityEngine.Bounds bounds, UnityEngine.Vector3& center, UnityEngine.Vector3& extents, UnityEngine.Vector3& max, UnityEngine.Vector3& min, UnityEngine.Vector3& size)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractCollision
TYPE:  class
TOKEN: 0x2000228
EXTENDS: ExtractorNode`5
FIELDS:
METHODS:
  System.Void Invoke(UnityEngine.Collision collision, UnityEngine.ContactPoint[]& contacts, UnityEngine.ContactPoint& firstContact, UnityEngine.GameObject& gameObject, UnityEngine.Vector3& velocity)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractCollision2D
TYPE:  class
TOKEN: 0x2000229
EXTENDS: ExtractorNode`5
FIELDS:
METHODS:
  System.Void Invoke(UnityEngine.Collision2D collision, UnityEngine.ContactPoint2D[]& contacts, UnityEngine.ContactPoint2D& firstContact, UnityEngine.GameObject& gameObject, UnityEngine.Vector2& velocity)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractContactPoint
TYPE:  class
TOKEN: 0x200022A
EXTENDS: ExtractorNode`5
FIELDS:
METHODS:
  System.Void Invoke(UnityEngine.ContactPoint contactPoint, UnityEngine.Vector3& normal, UnityEngine.Vector3& point, UnityEngine.Collider& colliderA, UnityEngine.Collider& colliderB)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractContactPoint2D
TYPE:  class
TOKEN: 0x200022B
EXTENDS: ExtractorNode`5
FIELDS:
METHODS:
  System.Void Invoke(UnityEngine.ContactPoint2D contactPoint, UnityEngine.Vector2& normal, UnityEngine.Vector2& point, UnityEngine.Collider2D& colliderA, UnityEngine.Collider2D& colliderB)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractAnimationCurve
TYPE:  class
TOKEN: 0x200022C
EXTENDS: ExtractorNode`5
FIELDS:
METHODS:
  System.Void Invoke(UnityEngine.AnimationCurve curve, UnityEngine.Keyframe[]& keys, System.Single& length, UnityEngine.WrapMode& postWrapMode, UnityEngine.WrapMode& preWrapMode)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.ExtractKeyFrame
TYPE:  class
TOKEN: 0x200022D
EXTENDS: ExtractorNode`5
FIELDS:
METHODS:
  System.Void Invoke(UnityEngine.Keyframe key, System.Single& inTangent, System.Single& outTangent, System.Single& time, System.Single& value)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.SwitchValue`1
TYPE:  class
TOKEN: 0x200022E
EXTENDS: PureFunctionNode`4
FIELDS:
METHODS:
  T Invoke(System.Boolean condition, T isTrue, T isFalse)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.PickValue`1
TYPE:  class
TOKEN: 0x200022F
EXTENDS: PureFunctionNode`3
FIELDS:
METHODS:
  T Invoke(System.Int32 index, System.Collections.Generic.IList<T> values)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.StaticCodeEventBase
TYPE:  class
TOKEN: 0x2000230
EXTENDS: EventNode
FIELDS:
  protected         System.String                   eventName  // 0xB0
  protected         System.Type                     targetType  // 0xB8
METHODS:
  System.Reflection.EventInfo get_eventInfo()
  System.Void SetEvent(System.Reflection.EventInfo e)
  System.Void OnGraphStarted()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.StaticCodeEvent
TYPE:  class
TOKEN: 0x2000231
EXTENDS: StaticCodeEventBase
FIELDS:
  private           FlowCanvas.FlowOutput           o  // 0xC0
  private           System.Action                   pointer  // 0xC8
METHODS:
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void Call()
  System.Void RegisterPorts()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.StaticCodeEvent`1
TYPE:  class
TOKEN: 0x2000232
EXTENDS: StaticCodeEventBase
FIELDS:
  private           FlowCanvas.FlowOutput           o  // 0x0
  private           System.Action<T>                pointer  // 0x0
  private           T                               eventValue  // 0x0
METHODS:
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void Call(T value)
  System.Void RegisterPorts()
  System.Void .ctor()
  T <RegisterPorts>b__6_0()
END_CLASS

CLASS: FlowCanvas.Nodes.FlowNestedBT
TYPE:  class
TOKEN: 0x2000233
EXTENDS: FlowNestedBase`1
FIELDS:
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
  NodeCanvas.Framework.Status <RegisterPorts>b__0_0()
END_CLASS

CLASS: FlowCanvas.Nodes.FlowNestedFSM
TYPE:  class
TOKEN: 0x2000234
EXTENDS: FlowNestedBase`1
FIELDS:
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
  NodeCanvas.StateMachines.IState <RegisterPorts>b__0_0()
END_CLASS

CLASS: FlowCanvas.Nodes.FlowNestedDT
TYPE:  class
TOKEN: 0x2000235
EXTENDS: FlowNestedBase`1
FIELDS:
METHODS:
  System.Void RegisterPorts()
  System.Void .ctor()
  NodeCanvas.DialogueTrees.IDialogueActor <RegisterPorts>b__0_0()
END_CLASS

CLASS: FlowCanvas.Nodes.TaskAction
TYPE:  class
TOKEN: 0x2000236
EXTENDS: FlowNode
FIELDS:
  private           NodeCanvas.Framework.ActionTask _action  // 0xB0
  private           FlowCanvas.FlowOutput           onFinish  // 0xB8
  private           UnityEngine.Coroutine           coroutine  // 0xC0
METHODS:
  System.String get_name()
  NodeCanvas.Framework.ActionTask get_action()
  System.Void set_action(NodeCanvas.Framework.ActionTask value)
  NodeCanvas.Framework.Task NodeCanvas.Framework.ITaskAssignable.get_task()
  System.Void NodeCanvas.Framework.ITaskAssignable.set_task(NodeCanvas.Framework.Task value)
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void OnGraphPaused()
  System.Void RegisterPorts()
  System.Collections.IEnumerator DoUpdate(FlowCanvas.Flow f)
  System.Void .ctor()
  System.Void <RegisterPorts>b__14_0(FlowCanvas.Flow f)
END_CLASS

CLASS: FlowCanvas.Nodes.TaskCondition
TYPE:  class
TOKEN: 0x2000238
EXTENDS: FlowNode
FIELDS:
  private           NodeCanvas.Framework.ConditionTask_condition  // 0xB0
METHODS:
  System.String get_name()
  NodeCanvas.Framework.ConditionTask get_condition()
  System.Void set_condition(NodeCanvas.Framework.ConditionTask value)
  NodeCanvas.Framework.Task NodeCanvas.Framework.ITaskAssignable.get_task()
  System.Void NodeCanvas.Framework.ITaskAssignable.set_task(NodeCanvas.Framework.Task value)
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void RegisterPorts()
  System.Void .ctor()
  System.Boolean <RegisterPorts>b__11_0()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedFieldNode
TYPE:  class
TOKEN: 0x2000239
FIELDS:
METHODS:
  FlowCanvas.Nodes.Legacy.ReflectedFieldNode Create(System.Reflection.FieldInfo field)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.FieldInfo field, FlowCanvas.Nodes.ReflectedFieldNodeWrapper.AccessMode accessMode)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.PureReflectedFieldNode
TYPE:  class
TOKEN: 0x200023A
EXTENDS: ReflectedFieldNode
FIELDS:
METHODS:
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.FieldInfo field, FlowCanvas.Nodes.ReflectedFieldNodeWrapper.AccessMode accessMode)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedMethodNode
TYPE:  class
TOKEN: 0x200023F
FIELDS:
METHODS:
  System.Void .ctor()
  FlowCanvas.Nodes.Legacy.ReflectedMethodNode Create(System.Reflection.MethodInfo method)
  FlowCanvas.Nodes.Legacy.ReflectedMethodNode TryCreateJit(System.Reflection.MethodInfo method)
  System.String GetName(System.Reflection.MethodInfo method, System.Int32 i)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.PureReflectedMethodNode
TYPE:  class
TOKEN: 0x2000242
EXTENDS: ReflectedMethodNode
FIELDS:
  private           System.Reflection.MethodInfo    method  // 0x10
  private           FlowCanvas.ValueInput           instanceInput  // 0x18
  private           System.Collections.Generic.List<FlowCanvas.ValueInput>inputs  // 0x20
  private           System.Collections.Generic.List<FlowCanvas.ValueInput>paramsInputs  // 0x28
  private           System.Type                     paramsArrayType  // 0x30
  private           System.Object[]                 args  // 0x38
  private           System.Object                   instance  // 0x40
  private           System.Object                   returnValue  // 0x48
METHODS:
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Object CallMethod()
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedActionNode
TYPE:  class
TOKEN: 0x2000246
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.ActionCall        call  // 0x10
METHODS:
  System.Void Call()
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedActionNode`1
TYPE:  class
TOKEN: 0x2000248
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.ActionCall<T1>    call  // 0x0
  private           T1                              instance  // 0x0
METHODS:
  System.Void Call(T1 a)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedActionNode`2
TYPE:  class
TOKEN: 0x200024A
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.ActionCall<T1,T2> call  // 0x0
  private           T1                              instance  // 0x0
METHODS:
  System.Void Call(T1 a, T2 b)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedActionNode`3
TYPE:  class
TOKEN: 0x200024C
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.ActionCall<T1,T2,T3>call  // 0x0
  private           T1                              instance  // 0x0
METHODS:
  System.Void Call(T1 a, T2 b, T3 c)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedActionNode`4
TYPE:  class
TOKEN: 0x200024E
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.ActionCall<T1,T2,T3,T4>call  // 0x0
  private           T1                              instance  // 0x0
METHODS:
  System.Void Call(T1 a, T2 b, T3 c, T4 d)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedActionNode`5
TYPE:  class
TOKEN: 0x2000250
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.ActionCall<T1,T2,T3,T4,T5>call  // 0x0
  private           T1                              instance  // 0x0
METHODS:
  System.Void Call(T1 a, T2 b, T3 c, T4 d, T5 e)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedActionNode`6
TYPE:  class
TOKEN: 0x2000252
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.ActionCall<T1,T2,T3,T4,T5,T6>call  // 0x0
  private           T1                              instance  // 0x0
METHODS:
  System.Void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedActionNode`7
TYPE:  class
TOKEN: 0x2000254
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.ActionCall<T1,T2,T3,T4,T5,T6,T7>call  // 0x0
  private           T1                              instance  // 0x0
METHODS:
  System.Void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedActionNode`8
TYPE:  class
TOKEN: 0x2000256
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.ActionCall<T1,T2,T3,T4,T5,T6,T7,T8>call  // 0x0
  private           T1                              instance  // 0x0
METHODS:
  System.Void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedFunctionNode`1
TYPE:  class
TOKEN: 0x2000258
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.FunctionCall<TResult>call  // 0x0
  private           TResult                         returnValue  // 0x0
METHODS:
  TResult Call()
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedFunctionNode`2
TYPE:  class
TOKEN: 0x200025B
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.FunctionCall<T1,TResult>call  // 0x0
  private           TResult                         returnValue  // 0x0
  private           T1                              instance  // 0x0
METHODS:
  TResult Call(T1 a)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedFunctionNode`3
TYPE:  class
TOKEN: 0x200025E
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.FunctionCall<T1,T2,TResult>call  // 0x0
  private           TResult                         returnValue  // 0x0
  private           T1                              instance  // 0x0
METHODS:
  TResult Call(T1 a, T2 b)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedFunctionNode`4
TYPE:  class
TOKEN: 0x2000261
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.FunctionCall<T1,T2,T3,TResult>call  // 0x0
  private           TResult                         returnValue  // 0x0
  private           T1                              instance  // 0x0
METHODS:
  TResult Call(T1 a, T2 b, T3 c)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedFunctionNode`5
TYPE:  class
TOKEN: 0x2000264
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.FunctionCall<T1,T2,T3,T4,TResult>call  // 0x0
  private           TResult                         returnValue  // 0x0
  private           T1                              instance  // 0x0
METHODS:
  TResult Call(T1 a, T2 b, T3 c, T4 d)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedFunctionNode`6
TYPE:  class
TOKEN: 0x2000267
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.FunctionCall<T1,T2,T3,T4,T5,TResult>call  // 0x0
  private           TResult                         returnValue  // 0x0
  private           T1                              instance  // 0x0
METHODS:
  TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedFunctionNode`7
TYPE:  class
TOKEN: 0x200026A
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.FunctionCall<T1,T2,T3,T4,T5,T6,TResult>call  // 0x0
  private           TResult                         returnValue  // 0x0
  private           T1                              instance  // 0x0
METHODS:
  TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedFunctionNode`8
TYPE:  class
TOKEN: 0x200026D
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.FunctionCall<T1,T2,T3,T4,T5,T6,T7,TResult>call  // 0x0
  private           TResult                         returnValue  // 0x0
  private           T1                              instance  // 0x0
METHODS:
  TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: FlowCanvas.Nodes.Legacy.ReflectedFunctionNode`9
TYPE:  class
TOKEN: 0x2000270
EXTENDS: ReflectedMethodNode
FIELDS:
  private           ParadoxNotion.FunctionCall<T1,T2,T3,T4,T5,T6,T7,T8,TResult>call  // 0x0
  private           TResult                         returnValue  // 0x0
  private           T1                              instance  // 0x0
METHODS:
  TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
  System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options)
  System.Void .ctor()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.AssemblyWrapUtils
TYPE:  class
TOKEN: 0x2000282
FIELDS:
  public    static  System.Boolean                  disableProjectPanelSuffixValidate  // 0x0
  public    static  System.Func<System.Boolean>     autoLockOpenBehaviourTree  // 0x8
  public    static  System.Func<System.Boolean>     autoLockOpenStateMachine  // 0x10
  public    static  System.Func<System.Boolean>     autoLockOpenDialogTree  // 0x18
  public    static  System.Func<System.Boolean>     autoLockOpenSAGraph  // 0x20
  public    static  System.Func<System.Boolean>     autoLockOpenLevelScript  // 0x28
  public    static  System.Func<System.Boolean>     autoLockOpenLevelScriptModule  // 0x30
  public    static  System.Func<System.Boolean>     autoLockOpenInteractiveConfig  // 0x38
  public    static  System.Func<System.Boolean>     autoLockOpenMissionGraph  // 0x40
  public    static  System.Func<System.Boolean>     autoLockOpenGuideGraph  // 0x48
METHODS:
END_CLASS

CLASS: NodeCanvas.ActionListPlayer
TYPE:  class
TOKEN: 0x2000283
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Boolean                  playOnAwake  // 0x18
  private           System.String                   _serializedList  // 0x20
  private           System.Collections.Generic.List<UnityEngine.Object>_objectReferences  // 0x28
  private           NodeCanvas.Framework.Blackboard _blackboard  // 0x30
  private           NodeCanvas.Framework.ActionList _actionList  // 0x38
  private           System.Single                   timeStarted  // 0x40
METHODS:
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  NodeCanvas.Framework.ActionList get_actionList()
  System.Single get_elapsedTime()
  System.Single get_deltaTime()
  UnityEngine.Object NodeCanvas.Framework.ITaskSystem.get_contextObject()
  UnityEngine.Component NodeCanvas.Framework.ITaskSystem.get_agent()
  NodeCanvas.Framework.IBlackboard get_blackboard()
  System.Void set_blackboard(NodeCanvas.Framework.IBlackboard value)
  NodeCanvas.ActionListPlayer Create()
  System.Void Awake()
  System.Void UpdateTasksOwner()
  System.Void NodeCanvas.Framework.ITaskSystem.SendEvent(System.String name, System.Object value, System.Object sender)
  System.Void NodeCanvas.Framework.ITaskSystem.SendEvent(System.String name, T value, System.Object sender)
  System.Void Play()
  System.Void Play(System.Action<NodeCanvas.Framework.Status> OnFinish)
  System.Void Play(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard, System.Action<NodeCanvas.Framework.Status> OnFinish)
  NodeCanvas.Framework.Status Execute()
  NodeCanvas.Framework.Status Execute(UnityEngine.Component agent)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.BehaviourTree
TYPE:  class
TOKEN: 0x20003B3
EXTENDS: Graph
FIELDS:
  public            System.Boolean                  repeat  // 0xA0
  public            System.Single                   updateInterval  // 0xA4
  private   static  System.Action<NodeCanvas.BehaviourTrees.BehaviourTree,NodeCanvas.Framework.Status>onRootStatusChanged  // 0x0
  private           System.Single                   intervalCounter  // 0xA8
  private           NodeCanvas.Framework.Status     _rootStatus  // 0xAC
METHODS:
  System.Object OnDerivedDataSerialization()
  System.Void OnDerivedDataDeserialization(System.Object data)
  System.Void add_onRootStatusChanged(System.Action<NodeCanvas.BehaviourTrees.BehaviourTree,NodeCanvas.Framework.Status> value)
  System.Void remove_onRootStatusChanged(System.Action<NodeCanvas.BehaviourTrees.BehaviourTree,NodeCanvas.Framework.Status> value)
  NodeCanvas.Framework.Status get_rootStatus()
  System.Void set_rootStatus(NodeCanvas.Framework.Status value)
  System.Type get_baseNodeType()
  System.Boolean get_requiresAgent()
  System.Boolean get_requiresPrimeNode()
  System.Boolean get_isTree()
  System.Boolean get_allowBlackboardOverrides()
  System.Boolean get_canAcceptVariableDrops()
  System.Boolean get_canDelayDeserializeAndOptimizeClone()
  System.Void OnGraphStarted()
  System.Void OnGraphUpdate()
  NodeCanvas.Framework.Status Tick(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.BehaviourTreeOwner
TYPE:  class
TOKEN: 0x20003B5
EXTENDS: GraphOwner`1
FIELDS:
METHODS:
  System.Boolean get_repeat()
  System.Void set_repeat(System.Boolean value)
  System.Single get_updateInterval()
  System.Void set_updateInterval(System.Single value)
  NodeCanvas.Framework.Status get_rootStatus()
  NodeCanvas.Framework.Status Tick()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.BTConnection
TYPE:  class
TOKEN: 0x20003B6
EXTENDS: Connection
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.BTNode
TYPE:  class
TOKEN: 0x20003B7
EXTENDS: Node
FIELDS:
METHODS:
  System.Type get_outConnectionType()
  System.Boolean get_allowAsPrime()
  System.Boolean get_canSelfConnect()
  ParadoxNotion.Alignment2x2 get_commentsAlignment()
  ParadoxNotion.Alignment2x2 get_iconAlignment()
  System.Int32 get_maxInConnections()
  System.Int32 get_maxOutConnections()
  T AddChild(System.Int32 childIndex)
  T AddChild()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.BTNodeNested`1
TYPE:  class
TOKEN: 0x20003B8
EXTENDS: BTNode
FIELDS:
  private           System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter>_variablesMap  // 0x0
  private           T                               <currentInstance>k__BackingField  // 0x0
  private           System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph><instances>k__BackingField  // 0x0
METHODS:
  T get_subGraph()
  System.Void set_subGraph(T value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  T get_currentInstance()
  System.Void set_currentInstance(T value)
  System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> get_instances()
  System.Void set_instances(System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> value)
  System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> get_variablesMap()
  System.Void set_variablesMap(System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> value)
  NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_subGraph()
  System.Void NodeCanvas.Framework.IGraphAssignable.set_subGraph(NodeCanvas.Framework.Graph value)
  NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_currentInstance()
  System.Void NodeCanvas.Framework.IGraphAssignable.set_currentInstance(NodeCanvas.Framework.Graph value)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.BTComposite
TYPE:  class
TOKEN: 0x20003B9
EXTENDS: BTNode
FIELDS:
METHODS:
  System.String get_name()
  System.Int32 get_maxOutConnections()
  ParadoxNotion.Alignment2x2 get_commentsAlignment()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.BTDecorator
TYPE:  class
TOKEN: 0x20003BA
EXTENDS: BTNode
FIELDS:
METHODS:
  System.Int32 get_maxOutConnections()
  ParadoxNotion.Alignment2x2 get_commentsAlignment()
  NodeCanvas.Framework.Connection get_decoratedConnection()
  NodeCanvas.Framework.Node get_decoratedNode()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.BinarySelector
TYPE:  class
TOKEN: 0x20003BB
EXTENDS: BTNode
FIELDS:
  public            System.Boolean                  dynamic  // 0x98
  private           NodeCanvas.Framework.ConditionTask_condition  // 0xA0
  private           System.Int32                    succeedIndex  // 0xA8
METHODS:
  System.Int32 get_maxOutConnections()
  ParadoxNotion.Alignment2x2 get_commentsAlignment()
  System.String get_name()
  NodeCanvas.Framework.Task get_task()
  System.Void set_task(NodeCanvas.Framework.Task value)
  NodeCanvas.Framework.ConditionTask get_condition()
  System.Void set_condition(NodeCanvas.Framework.ConditionTask value)
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.FlipSelector
TYPE:  class
TOKEN: 0x20003BC
EXTENDS: BTComposite
FIELDS:
  private           System.Int32                    current  // 0x98
METHODS:
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void SendToBack(System.Int32 i)
  System.Void OnReset()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.Parallel
TYPE:  class
TOKEN: 0x20003BD
EXTENDS: BTComposite
FIELDS:
  public            NodeCanvas.BehaviourTrees.Parallel.ParallelPolicypolicy  // 0x98
  public            System.Boolean                  dynamic  // 0x9C
  private           System.Boolean[]                finishedConnections  // 0xA0
  private           System.Int32                    finishedConnectionsCount  // 0xA8
METHODS:
  System.Void OnGraphStarted()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void ResetRunning()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.PrioritySelector_0
TYPE:  class
TOKEN: 0x20003BF
EXTENDS: BTComposite
FIELDS:
  public            System.Collections.Generic.List<NodeCanvas.Framework.BBParameter<System.Single>>priorities  // 0x98
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.PrioritySelector
TYPE:  class
TOKEN: 0x20003C0
EXTENDS: BTComposite
FIELDS:
  public            System.Collections.Generic.List<NodeCanvas.BehaviourTrees.PrioritySelector.Desire>desires  // 0x98
  private           NodeCanvas.Framework.Connection[]orderedConnections  // 0xA0
  private           System.Int32                    current  // 0xA8
METHODS:
  System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.BehaviourTrees.PrioritySelector_0>.Migrate(NodeCanvas.BehaviourTrees.PrioritySelector_0 model)
  System.Void OnChildConnected(System.Int32 index)
  System.Void OnChildDisconnected(System.Int32 index)
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void .ctor()
  System.Single <OnExecute>b__8_0(NodeCanvas.Framework.Connection c)
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.ProbabilitySelector
TYPE:  class
TOKEN: 0x20003C3
EXTENDS: BTComposite
FIELDS:
  public            System.Collections.Generic.List<NodeCanvas.Framework.BBParameter<System.Single>>childWeights  // 0x98
  public            NodeCanvas.Framework.BBParameter<System.Single>failChance  // 0xA0
  private           System.Boolean[]                indexFailed  // 0xA8
  private           System.Single[]                 tmpWeights  // 0xB0
  private           System.Single                   tmpFailWeight  // 0xB8
  private           System.Single                   tmpTotal  // 0xBC
  private           System.Single                   tmpDice  // 0xC0
METHODS:
  System.Void OnChildConnected(System.Int32 index)
  System.Void OnChildDisconnected(System.Int32 index)
  System.Void OnGraphStarted()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.Selector
TYPE:  class
TOKEN: 0x20003C4
EXTENDS: BTComposite
FIELDS:
  public            System.Boolean                  dynamic  // 0x98
  public            System.Boolean                  random  // 0x99
  private           System.Int32                    lastRunningNodeIndex  // 0x9C
METHODS:
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void OnChildDisconnected(System.Int32 index)
  System.Void OnGraphStarted()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.Sequencer
TYPE:  class
TOKEN: 0x20003C5
EXTENDS: BTComposite
FIELDS:
  public            System.Boolean                  dynamic  // 0x98
  public            System.Boolean                  random  // 0x99
  private           System.Int32                    lastRunningNodeIndex  // 0x9C
METHODS:
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void OnChildDisconnected(System.Int32 index)
  System.Void OnGraphStarted()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.StepIterator
TYPE:  class
TOKEN: 0x20003C6
EXTENDS: BTComposite
FIELDS:
  private           System.Int32                    current  // 0x98
METHODS:
  System.Void OnGraphStarted()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.Switch
TYPE:  class
TOKEN: 0x20003C7
EXTENDS: BTComposite
FIELDS:
  public            System.Boolean                  dynamic  // 0x98
  public            NodeCanvas.BehaviourTrees.Switch.CaseSelectionModeselectionMode  // 0x9C
  public            NodeCanvas.Framework.BBParameter<System.Int32>intCase  // 0xA0
  public            NodeCanvas.BehaviourTrees.Switch.OutOfRangeModeoutOfRangeMode  // 0xA8
  public            NodeCanvas.Framework.Internal.BBObjectParameterenumCase  // 0xB0
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>enumCasePairing  // 0xB8
  private           System.Int32                    current  // 0xC0
  private           System.Int32                    runningIndex  // 0xC4
METHODS:
  System.Void OnGraphStarted()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.ConditionalEvaluator
TYPE:  class
TOKEN: 0x20003CA
EXTENDS: BTDecorator
FIELDS:
  public            System.Boolean                  isDynamic  // 0x98
  public            ParadoxNotion.CompactStatus     conditionFailReturn  // 0x9C
  private           NodeCanvas.Framework.ConditionTask_condition  // 0xA0
  private           System.Boolean                  accessed  // 0xA8
METHODS:
  NodeCanvas.Framework.Task get_task()
  System.Void set_task(NodeCanvas.Framework.Task value)
  NodeCanvas.Framework.ConditionTask get_condition()
  System.Void set_condition(NodeCanvas.Framework.ConditionTask value)
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.Filter
TYPE:  class
TOKEN: 0x20003CB
EXTENDS: BTDecorator
FIELDS:
  public            NodeCanvas.BehaviourTrees.Filter.FilterModefilterMode  // 0x98
  public            NodeCanvas.Framework.BBParameter<System.Int32>maxCount  // 0xA0
  public            NodeCanvas.BehaviourTrees.Filter.Policypolicy  // 0xA8
  public            NodeCanvas.Framework.BBParameter<System.Single>coolDownTime  // 0xB0
  public            System.Boolean                  inactiveWhenLimited  // 0xB8
  private           System.Int32                    executedCount  // 0xBC
  private           System.Single                   currentTime  // 0xC0
  private           System.Single                   targetTime  // 0xC4
METHODS:
  System.Void OnGraphStoped()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnClearNodeData()
  System.Collections.IEnumerator Cooldown()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.Guard
TYPE:  class
TOKEN: 0x20003CF
EXTENDS: BTDecorator
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>token  // 0x98
  public            NodeCanvas.BehaviourTrees.Guard.GuardModeifGuarded  // 0xA0
  private           System.Boolean                  isGuarding  // 0xA4
  private   static readonly System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Collections.Generic.List<NodeCanvas.BehaviourTrees.Guard>>guards  // 0x0
METHODS:
  System.Collections.Generic.List<NodeCanvas.BehaviourTrees.Guard> AgentGuards(UnityEngine.Component agent)
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void SetGuards(UnityEngine.Component guardAgent)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.Interruptor
TYPE:  class
TOKEN: 0x20003D1
EXTENDS: BTDecorator
FIELDS:
  private           NodeCanvas.Framework.ConditionTask_condition  // 0x98
METHODS:
  NodeCanvas.Framework.ConditionTask get_condition()
  System.Void set_condition(NodeCanvas.Framework.ConditionTask value)
  NodeCanvas.Framework.Task get_task()
  System.Void set_task(NodeCanvas.Framework.Task value)
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.Inverter
TYPE:  class
TOKEN: 0x20003D2
EXTENDS: BTDecorator
FIELDS:
METHODS:
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.Iterator
TYPE:  class
TOKEN: 0x20003D3
EXTENDS: BTDecorator
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.IList>targetList  // 0x98
  public            NodeCanvas.Framework.Internal.BBObjectParametercurrent  // 0xA0
  public            NodeCanvas.Framework.BBParameter<System.Int32>storeIndex  // 0xA8
  public            NodeCanvas.BehaviourTrees.Iterator.TerminationConditionsterminationCondition  // 0xB0
  public            NodeCanvas.Framework.BBParameter<System.Int32>maxIteration  // 0xB8
  public            System.Boolean                  resetIndex  // 0xC0
  private           System.Int32                    currentIndex  // 0xC4
METHODS:
  System.Collections.IList get_list()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.Merge
TYPE:  class
TOKEN: 0x20003D5
EXTENDS: BTDecorator
FIELDS:
METHODS:
  System.Int32 get_maxInConnections()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.Monitor
TYPE:  class
TOKEN: 0x20003D6
EXTENDS: BTDecorator
FIELDS:
  public            NodeCanvas.BehaviourTrees.Monitor.MonitorModemonitorMode  // 0x98
  public            NodeCanvas.BehaviourTrees.Monitor.ReturnStatusModereturnMode  // 0x9C
  private           NodeCanvas.Framework.Status     decoratorActionStatus  // 0xA0
  private           NodeCanvas.Framework.ActionTask _action  // 0xA8
METHODS:
  NodeCanvas.Framework.ActionTask get_action()
  System.Void set_action(NodeCanvas.Framework.ActionTask value)
  NodeCanvas.Framework.Task get_task()
  System.Void set_task(NodeCanvas.Framework.Task value)
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.Optional
TYPE:  class
TOKEN: 0x20003D9
EXTENDS: BTDecorator
FIELDS:
METHODS:
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.Remapper
TYPE:  class
TOKEN: 0x20003DA
EXTENDS: BTDecorator
FIELDS:
  public            NodeCanvas.BehaviourTrees.Remapper.RemapStatussuccessRemap  // 0x98
  public            NodeCanvas.BehaviourTrees.Remapper.RemapStatusfailureRemap  // 0x9C
METHODS:
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.Repeater
TYPE:  class
TOKEN: 0x20003DC
EXTENDS: BTDecorator
FIELDS:
  public            NodeCanvas.BehaviourTrees.Repeater.RepeaterModerepeaterMode  // 0x98
  public            NodeCanvas.Framework.BBParameter<System.Int32>repeatTimes  // 0xA0
  public            NodeCanvas.BehaviourTrees.Repeater.RepeatUntilStatusrepeatUntilStatus  // 0xA8
  private           System.Int32                    currentIteration  // 0xAC
METHODS:
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.Setter
TYPE:  class
TOKEN: 0x20003DF
EXTENDS: BTDecorator
FIELDS:
  public            System.Boolean                  revertToOriginal  // 0x98
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>newAgent  // 0xA0
METHODS:
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.Timeout
TYPE:  class
TOKEN: 0x20003E0
EXTENDS: BTDecorator
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Single>timeout  // 0x98
METHODS:
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.WaitUntil
TYPE:  class
TOKEN: 0x20003E1
EXTENDS: BTDecorator
FIELDS:
  private           NodeCanvas.Framework.ConditionTask_condition  // 0x98
  private           System.Boolean                  accessed  // 0xA0
METHODS:
  NodeCanvas.Framework.Task get_task()
  System.Void set_task(NodeCanvas.Framework.Task value)
  NodeCanvas.Framework.ConditionTask get_condition()
  System.Void set_condition(NodeCanvas.Framework.ConditionTask value)
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.ActionNode
TYPE:  class
TOKEN: 0x20003E2
EXTENDS: BTNode
FIELDS:
  private           NodeCanvas.Framework.ActionTask _action  // 0x98
METHODS:
  NodeCanvas.Framework.Task get_task()
  System.Void set_task(NodeCanvas.Framework.Task value)
  NodeCanvas.Framework.ActionTask get_action()
  System.Void set_action(NodeCanvas.Framework.ActionTask value)
  System.String get_name()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void OnGraphPaused()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.ConditionNode
TYPE:  class
TOKEN: 0x20003E3
EXTENDS: BTNode
FIELDS:
  private           NodeCanvas.Framework.ConditionTask_condition  // 0x98
METHODS:
  NodeCanvas.Framework.Task get_task()
  System.Void set_task(NodeCanvas.Framework.Task value)
  NodeCanvas.Framework.ConditionTask get_condition()
  System.Void set_condition(NodeCanvas.Framework.ConditionTask value)
  System.String get_name()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.NestedDT
TYPE:  class
TOKEN: 0x20003E4
EXTENDS: BTNodeNested`1
FIELDS:
  private           NodeCanvas.Framework.BBParameter<NodeCanvas.DialogueTrees.DialogueTree>_nestedDialogueTree  // 0xB0
METHODS:
  NodeCanvas.DialogueTrees.DialogueTree get_subGraph()
  System.Void set_subGraph(NodeCanvas.DialogueTrees.DialogueTree value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnDLGFinished(System.Boolean success)
  System.Void OnReset()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.NestedFSM
TYPE:  class
TOKEN: 0x20003E5
EXTENDS: BTNodeNested`1
FIELDS:
  private           NodeCanvas.Framework.BBParameter<NodeCanvas.StateMachines.FSM>_nestedFSM  // 0xB0
  public            System.String                   successState  // 0xB8
  public            System.String                   failureState  // 0xC0
METHODS:
  NodeCanvas.StateMachines.FSM get_subGraph()
  System.Void set_subGraph(NodeCanvas.StateMachines.FSM value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnFSMFinish(System.Boolean success)
  System.Void OnReset()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.SubTree
TYPE:  class
TOKEN: 0x20003E6
EXTENDS: BTNodeNested`1
FIELDS:
  private           NodeCanvas.Framework.BBParameter<NodeCanvas.BehaviourTrees.BehaviourTree>_subTree  // 0xB0
METHODS:
  NodeCanvas.BehaviourTrees.BehaviourTree get_subGraph()
  System.Void set_subGraph(NodeCanvas.BehaviourTrees.BehaviourTree value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.NodeToggler
TYPE:  class
TOKEN: 0x20003E7
EXTENDS: BTNode
FIELDS:
  public            NodeCanvas.BehaviourTrees.NodeToggler.ToggleModetoggleMode  // 0x98
  public            System.String                   targetNodeTag  // 0xA0
  private           System.Collections.Generic.List<NodeCanvas.Framework.Node>targetNodes  // 0xA8
METHODS:
  System.Void OnGraphStarted()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.RootSwitcher
TYPE:  class
TOKEN: 0x20003E9
EXTENDS: BTNode
FIELDS:
  public            System.String                   targetNodeTag  // 0x98
  private           NodeCanvas.Framework.Node       targetNode  // 0xA0
METHODS:
  System.Void OnGraphStarted()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.BehaviourTrees.BTNestedFlowScript
TYPE:  class
TOKEN: 0x20003EA
EXTENDS: BTNodeNested`1
FIELDS:
  private           NodeCanvas.Framework.BBParameter<FlowCanvas.FlowScript>_flowScript  // 0xB0
METHODS:
  FlowCanvas.FlowScript get_subGraph()
  System.Void set_subGraph(FlowCanvas.FlowScript value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnFlowScriptFinished(System.Boolean success)
  System.Void OnReset()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.DialogueActor
TYPE:  class
TOKEN: 0x2000386
EXTENDS: MonoBehaviour
FIELDS:
  protected         System.String                   _name  // 0x18
  protected         UnityEngine.Texture2D           _portrait  // 0x20
  protected         UnityEngine.Color               _dialogueColor  // 0x28
  protected         UnityEngine.Vector3             _dialogueOffset  // 0x38
  private           UnityEngine.Sprite              _portraitSprite  // 0x48
METHODS:
  System.String get_name()
  UnityEngine.Texture2D get_portrait()
  UnityEngine.Sprite get_portraitSprite()
  UnityEngine.Color get_dialogueColor()
  UnityEngine.Vector3 get_dialoguePosition()
  System.Void .ctor()
  UnityEngine.Transform NodeCanvas.DialogueTrees.IDialogueActor.get_transform()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.SubtitlesRequestInfo
TYPE:  class
TOKEN: 0x2000387
FIELDS:
  public            NodeCanvas.DialogueTrees.IDialogueActoractor  // 0x10
  public            NodeCanvas.DialogueTrees.IStatementstatement  // 0x18
  public            System.Action                   Continue  // 0x20
METHODS:
  System.Void .ctor(NodeCanvas.DialogueTrees.IDialogueActor actor, NodeCanvas.DialogueTrees.IStatement statement, System.Action callback)
END_CLASS

CLASS: NodeCanvas.DialogueTrees.MultipleChoiceRequestInfo
TYPE:  class
TOKEN: 0x2000388
FIELDS:
  public            NodeCanvas.DialogueTrees.IDialogueActoractor  // 0x10
  public            System.Collections.Generic.Dictionary<NodeCanvas.DialogueTrees.IStatement,System.Int32>options  // 0x18
  public            System.Single                   availableTime  // 0x20
  public            System.Boolean                  showLastStatement  // 0x24
  public            System.Action<System.Int32>     SelectOption  // 0x28
METHODS:
  System.Void .ctor(NodeCanvas.DialogueTrees.IDialogueActor actor, System.Collections.Generic.Dictionary<NodeCanvas.DialogueTrees.IStatement,System.Int32> options, System.Single availableTime, System.Boolean showLastStatement, System.Action<System.Int32> callback)
  System.Void .ctor(NodeCanvas.DialogueTrees.IDialogueActor actor, System.Collections.Generic.Dictionary<NodeCanvas.DialogueTrees.IStatement,System.Int32> options, System.Single availableTime, System.Action<System.Int32> callback)
END_CLASS

CLASS: NodeCanvas.DialogueTrees.DialogueTree
TYPE:  class
TOKEN: 0x2000389
EXTENDS: Graph
FIELDS:
  public    static  System.String                   INSTIGATOR_NAME  // 0x0
  public            System.Collections.Generic.List<NodeCanvas.DialogueTrees.DialogueTree.ActorParameter>actorParameters  // 0xA0
  private   static  System.Action<NodeCanvas.DialogueTrees.DialogueTree>OnDialogueStarted  // 0x0
  private   static  System.Action<NodeCanvas.DialogueTrees.DialogueTree>OnDialoguePaused  // 0x8
  private   static  System.Action<NodeCanvas.DialogueTrees.DialogueTree>OnDialogueFinished  // 0x10
  private   static  System.Action<NodeCanvas.DialogueTrees.SubtitlesRequestInfo>OnSubtitlesRequest  // 0x18
  private   static  System.Action<NodeCanvas.DialogueTrees.MultipleChoiceRequestInfo>OnMultipleChoiceRequest  // 0x20
  private   static  NodeCanvas.DialogueTrees.DialogueTree<currentDialogue>k__BackingField  // 0x28
  private   static  NodeCanvas.DialogueTrees.DialogueTree<previousDialogue>k__BackingField  // 0x30
  private           NodeCanvas.DialogueTrees.DTNode <currentNode>k__BackingField  // 0xA8
METHODS:
  System.Object OnDerivedDataSerialization()
  System.Void OnDerivedDataDeserialization(System.Object data)
  System.Void add_OnDialogueStarted(System.Action<NodeCanvas.DialogueTrees.DialogueTree> value)
  System.Void remove_OnDialogueStarted(System.Action<NodeCanvas.DialogueTrees.DialogueTree> value)
  System.Void add_OnDialoguePaused(System.Action<NodeCanvas.DialogueTrees.DialogueTree> value)
  System.Void remove_OnDialoguePaused(System.Action<NodeCanvas.DialogueTrees.DialogueTree> value)
  System.Void add_OnDialogueFinished(System.Action<NodeCanvas.DialogueTrees.DialogueTree> value)
  System.Void remove_OnDialogueFinished(System.Action<NodeCanvas.DialogueTrees.DialogueTree> value)
  System.Void add_OnSubtitlesRequest(System.Action<NodeCanvas.DialogueTrees.SubtitlesRequestInfo> value)
  System.Void remove_OnSubtitlesRequest(System.Action<NodeCanvas.DialogueTrees.SubtitlesRequestInfo> value)
  System.Void add_OnMultipleChoiceRequest(System.Action<NodeCanvas.DialogueTrees.MultipleChoiceRequestInfo> value)
  System.Void remove_OnMultipleChoiceRequest(System.Action<NodeCanvas.DialogueTrees.MultipleChoiceRequestInfo> value)
  NodeCanvas.DialogueTrees.DialogueTree get_currentDialogue()
  System.Void set_currentDialogue(NodeCanvas.DialogueTrees.DialogueTree value)
  NodeCanvas.DialogueTrees.DialogueTree get_previousDialogue()
  System.Void set_previousDialogue(NodeCanvas.DialogueTrees.DialogueTree value)
  NodeCanvas.DialogueTrees.DTNode get_currentNode()
  System.Void set_currentNode(NodeCanvas.DialogueTrees.DTNode value)
  System.Type get_baseNodeType()
  System.Boolean get_requiresAgent()
  System.Boolean get_requiresPrimeNode()
  System.Boolean get_isTree()
  System.Boolean get_allowBlackboardOverrides()
  System.Boolean get_canAcceptVariableDrops()
  System.Boolean get_canDelayDeserializeAndOptimizeClone()
  System.Collections.Generic.List<System.String> get_definedActorParameterNames()
  NodeCanvas.DialogueTrees.DialogueTree.ActorParameter GetParameterByID(System.String id)
  NodeCanvas.DialogueTrees.DialogueTree.ActorParameter GetParameterByName(System.String paramName)
  NodeCanvas.DialogueTrees.IDialogueActor GetActorReferenceByID(System.String id)
  NodeCanvas.DialogueTrees.IDialogueActor GetActorReferenceByName(System.String paramName)
  System.Void SetActorReference(System.String paramName, NodeCanvas.DialogueTrees.IDialogueActor actor)
  System.Void SetActorReferences(System.Collections.Generic.Dictionary<System.String,NodeCanvas.DialogueTrees.IDialogueActor> actors)
  System.Void Continue(System.Int32 index)
  System.Void EnterNode(NodeCanvas.DialogueTrees.DTNode node)
  System.Void RequestSubtitles(NodeCanvas.DialogueTrees.SubtitlesRequestInfo info)
  System.Void RequestMultipleChoices(NodeCanvas.DialogueTrees.MultipleChoiceRequestInfo info)
  System.Void OnGraphStarted()
  System.Void OnGraphUpdate()
  System.Void OnGraphStoped()
  System.Void OnGraphPaused()
  System.Void OnGraphUnpaused()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.DialogueTreeController
TYPE:  class
TOKEN: 0x2000392
EXTENDS: GraphOwner`1
FIELDS:
METHODS:
  System.String NodeCanvas.DialogueTrees.IDialogueActor.get_name()
  UnityEngine.Texture2D NodeCanvas.DialogueTrees.IDialogueActor.get_portrait()
  UnityEngine.Sprite NodeCanvas.DialogueTrees.IDialogueActor.get_portraitSprite()
  UnityEngine.Color NodeCanvas.DialogueTrees.IDialogueActor.get_dialogueColor()
  UnityEngine.Vector3 NodeCanvas.DialogueTrees.IDialogueActor.get_dialoguePosition()
  UnityEngine.Transform NodeCanvas.DialogueTrees.IDialogueActor.get_transform()
  System.Void StartDialogue()
  System.Void StartDialogue(System.Action<System.Boolean> callback)
  System.Void StartDialogue(NodeCanvas.DialogueTrees.IDialogueActor instigator)
  System.Void StartDialogue(NodeCanvas.DialogueTrees.DialogueTree newTree, NodeCanvas.DialogueTrees.IDialogueActor instigator, System.Action<System.Boolean> callback)
  System.Void StartDialogue(NodeCanvas.DialogueTrees.IDialogueActor instigator, System.Action<System.Boolean> callback)
  System.Void PauseDialogue()
  System.Void StopDialogue()
  System.Void SetActorReference(System.String paramName, NodeCanvas.DialogueTrees.IDialogueActor actor)
  System.Void SetActorReferences(System.Collections.Generic.Dictionary<System.String,NodeCanvas.DialogueTrees.IDialogueActor> actors)
  NodeCanvas.DialogueTrees.IDialogueActor GetActorReferenceByName(System.String paramName)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.DTConnection
TYPE:  class
TOKEN: 0x2000393
EXTENDS: Connection
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.DTNode
TYPE:  class
TOKEN: 0x2000394
EXTENDS: Node
FIELDS:
  private           System.String                   _actorName  // 0x98
  private           System.String                   _actorParameterID  // 0xA0
METHODS:
  System.String get_name()
  System.Boolean get_requireActorSelection()
  System.Int32 get_maxInConnections()
  System.Int32 get_maxOutConnections()
  System.Type get_outConnectionType()
  System.Boolean get_allowAsPrime()
  System.Boolean get_canSelfConnect()
  ParadoxNotion.Alignment2x2 get_commentsAlignment()
  ParadoxNotion.Alignment2x2 get_iconAlignment()
  NodeCanvas.DialogueTrees.DialogueTree get_DLGTree()
  System.String get_actorName()
  System.Void set_actorName(System.String value)
  NodeCanvas.DialogueTrees.IDialogueActor get_finalActor()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.DTNodeNested`1
TYPE:  class
TOKEN: 0x2000395
EXTENDS: DTNode
FIELDS:
  private           System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter>_variablesMap  // 0x0
  private           T                               <currentInstance>k__BackingField  // 0x0
  private           System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph><instances>k__BackingField  // 0x0
METHODS:
  T get_subGraph()
  System.Void set_subGraph(T value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  T get_currentInstance()
  System.Void set_currentInstance(T value)
  System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> get_instances()
  System.Void set_instances(System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> value)
  System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> get_variablesMap()
  System.Void set_variablesMap(System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> value)
  NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_subGraph()
  System.Void NodeCanvas.Framework.IGraphAssignable.set_subGraph(NodeCanvas.Framework.Graph value)
  NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_currentInstance()
  System.Void NodeCanvas.Framework.IGraphAssignable.set_currentInstance(NodeCanvas.Framework.Graph value)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.IDialogueActor
TYPE:  interface
TOKEN: 0x2000396
FIELDS:
METHODS:
  System.String get_name()
  UnityEngine.Texture2D get_portrait()
  UnityEngine.Sprite get_portraitSprite()
  UnityEngine.Color get_dialogueColor()
  UnityEngine.Vector3 get_dialoguePosition()
  UnityEngine.Transform get_transform()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.ProxyDialogueActor
TYPE:  class
TOKEN: 0x2000397
FIELDS:
  private           System.String                   _name  // 0x10
  private           UnityEngine.Transform           _transform  // 0x18
METHODS:
  System.String get_name()
  UnityEngine.Texture2D get_portrait()
  UnityEngine.Sprite get_portraitSprite()
  UnityEngine.Color get_dialogueColor()
  UnityEngine.Vector3 get_dialoguePosition()
  UnityEngine.Transform get_transform()
  System.Void .ctor(System.String name, UnityEngine.Transform transform)
END_CLASS

CLASS: NodeCanvas.DialogueTrees.IStatement
TYPE:  interface
TOKEN: 0x2000398
FIELDS:
METHODS:
  System.String get_text()
  UnityEngine.AudioClip get_audio()
  System.String get_meta()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.Statement
TYPE:  class
TOKEN: 0x2000399
FIELDS:
  private           System.String                   _text  // 0x10
  private           UnityEngine.AudioClip           _audio  // 0x18
  private           System.String                   _meta  // 0x20
METHODS:
  System.String get_text()
  System.Void set_text(System.String value)
  UnityEngine.AudioClip get_audio()
  System.Void set_audio(UnityEngine.AudioClip value)
  System.String get_meta()
  System.Void set_meta(System.String value)
  System.Void .ctor()
  System.Void .ctor(System.String text)
  System.Void .ctor(System.String text, UnityEngine.AudioClip audio)
  System.Void .ctor(System.String text, UnityEngine.AudioClip audio, System.String meta)
  NodeCanvas.DialogueTrees.IStatement BlackboardReplace(NodeCanvas.Framework.IBlackboard bb)
  System.String ToString()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.ActionNode
TYPE:  class
TOKEN: 0x200039B
EXTENDS: DTNode
FIELDS:
  private           NodeCanvas.Framework.ActionTask _action  // 0xA8
METHODS:
  NodeCanvas.Framework.ActionTask get_action()
  System.Void set_action(NodeCanvas.Framework.ActionTask value)
  NodeCanvas.Framework.Task get_task()
  System.Void set_task(NodeCanvas.Framework.Task value)
  System.Boolean get_requireActorSelection()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb)
  System.Collections.IEnumerator UpdateAction(UnityEngine.Component actionAgent)
  System.Void OnActionEnd(System.Boolean success)
  System.Void OnReset()
  System.Void OnGraphPaused()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.ConditionNode
TYPE:  class
TOKEN: 0x200039D
EXTENDS: DTNode
FIELDS:
  private           NodeCanvas.Framework.ConditionTask_condition  // 0xA8
METHODS:
  NodeCanvas.Framework.ConditionTask get_condition()
  System.Void set_condition(NodeCanvas.Framework.ConditionTask value)
  NodeCanvas.Framework.Task get_task()
  System.Void set_task(NodeCanvas.Framework.Task value)
  System.Int32 get_maxOutConnections()
  System.Boolean get_requireActorSelection()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.FinishNode
TYPE:  class
TOKEN: 0x200039E
EXTENDS: DTNode
FIELDS:
  public            ParadoxNotion.CompactStatus     finishState  // 0xA8
METHODS:
  System.Int32 get_maxOutConnections()
  System.Boolean get_requireActorSelection()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.Jumper
TYPE:  class
TOKEN: 0x200039F
EXTENDS: DTNode
FIELDS:
  public            NodeCanvas.Framework.NodeReference<NodeCanvas.DialogueTrees.DTNode>_targetNode  // 0xA8
METHODS:
  NodeCanvas.Framework.INodeReference NodeCanvas.Framework.IHaveNodeReference.get_targetReference()
  NodeCanvas.DialogueTrees.DTNode get_target()
  System.Int32 get_maxOutConnections()
  System.Boolean get_requireActorSelection()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.MultipleChoiceNode
TYPE:  class
TOKEN: 0x20003A0
EXTENDS: DTNode
FIELDS:
  public            System.Single                   availableTime  // 0xA8
  public            System.Boolean                  saySelection  // 0xAC
  private           System.Collections.Generic.List<NodeCanvas.DialogueTrees.MultipleChoiceNode.Choice>availableChoices  // 0xB0
METHODS:
  System.Int32 get_maxOutConnections()
  System.Boolean get_requireActorSelection()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb)
  System.Void OnOptionSelected(System.Int32 index)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.MultipleConditionNode
TYPE:  class
TOKEN: 0x20003A3
EXTENDS: DTNode
FIELDS:
  private           System.Collections.Generic.List<NodeCanvas.Framework.ConditionTask>conditions  // 0xA8
METHODS:
  System.Int32 get_maxOutConnections()
  System.Void OnChildConnected(System.Int32 index)
  System.Void OnChildDisconnected(System.Int32 index)
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.ProbabilitySelector
TYPE:  class
TOKEN: 0x20003A4
EXTENDS: DTNode
FIELDS:
  private           System.Collections.Generic.List<NodeCanvas.DialogueTrees.ProbabilitySelector.Option>childOptions  // 0xA8
  private           System.Collections.Generic.List<System.Int32>successIndeces  // 0xB0
METHODS:
  System.Int32 get_maxOutConnections()
  System.Void OnChildConnected(System.Int32 index)
  System.Void OnChildDisconnected(System.Int32 index)
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Single GetTotal()
  System.Void OnReset()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.StatementNode
TYPE:  class
TOKEN: 0x20003A6
EXTENDS: DTNode
FIELDS:
  public            NodeCanvas.DialogueTrees.Statementstatement  // 0xA8
METHODS:
  System.Boolean get_requireActorSelection()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb)
  System.Void OnStatementFinish()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.SubDialogueTree
TYPE:  class
TOKEN: 0x20003A7
EXTENDS: DTNodeNested`1
FIELDS:
  private           NodeCanvas.Framework.BBParameter<NodeCanvas.DialogueTrees.DialogueTree>_subTree  // 0xC0
  private           System.Collections.Generic.Dictionary<System.String,System.String>_actorParametersMap  // 0xC8
METHODS:
  System.Int32 get_maxOutConnections()
  NodeCanvas.DialogueTrees.DialogueTree get_subGraph()
  System.Void set_subGraph(NodeCanvas.DialogueTrees.DialogueTree value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb)
  System.Void OnSubDialogueFinish(System.Boolean success)
  System.Void NodeCanvas.Framework.IUpdatable.Update()
  System.Void TryWriteMappedActorParameters()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.GoToNode
TYPE:  class
TOKEN: 0x20003A8
EXTENDS: DTNode
FIELDS:
  private           NodeCanvas.DialogueTrees.DTNode _targetNode  // 0xA8
METHODS:
  System.Int32 get_maxOutConnections()
  System.Boolean get_requireActorSelection()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.DTNestedFlowScript
TYPE:  class
TOKEN: 0x20003A9
EXTENDS: DTNodeNested`1
FIELDS:
  private           NodeCanvas.Framework.BBParameter<FlowCanvas.FlowScript>_flowScript  // 0xC0
METHODS:
  System.Int32 get_maxOutConnections()
  FlowCanvas.FlowScript get_subGraph()
  System.Void set_subGraph(FlowCanvas.FlowScript value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb)
  System.Void NodeCanvas.Framework.IUpdatable.Update()
  System.Void OnFlowScriptFinish(System.Boolean success)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.DialogueTrees.UI.Examples.DialogueUGUI
TYPE:  class
TOKEN: 0x20003AA
EXTENDS: MonoBehaviour
FIELDS:
  public            System.Boolean                  skipOnInput  // 0x18
  public            System.Boolean                  waitForInput  // 0x19
  public            UnityEngine.RectTransform       subtitlesGroup  // 0x20
  public            UnityEngine.UI.Text             actorSpeech  // 0x28
  public            UnityEngine.UI.Text             actorName  // 0x30
  public            UnityEngine.UI.Image            actorPortrait  // 0x38
  public            UnityEngine.RectTransform       waitInputIndicator  // 0x40
  public            NodeCanvas.DialogueTrees.UI.Examples.DialogueUGUI.SubtitleDelayssubtitleDelays  // 0x48
  public            System.Collections.Generic.List<UnityEngine.AudioClip>typingSounds  // 0x50
  private           UnityEngine.AudioSource         playSource  // 0x58
  public            UnityEngine.RectTransform       optionsGroup  // 0x60
  public            UnityEngine.UI.Button           optionButton  // 0x68
  private           System.Collections.Generic.Dictionary<UnityEngine.UI.Button,System.Int32>cachedButtons  // 0x70
  private           UnityEngine.Vector2             originalSubsPosition  // 0x78
  private           System.Boolean                  isWaitingChoice  // 0x80
  private           UnityEngine.AudioSource         _localSource  // 0x88
METHODS:
  UnityEngine.AudioSource get_localSource()
  System.Boolean get_anyKeyDown()
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Subscribe()
  System.Void UnSubscribe()
  System.Void Hide()
  System.Void OnDialogueStarted(NodeCanvas.DialogueTrees.DialogueTree dlg)
  System.Void OnDialoguePaused(NodeCanvas.DialogueTrees.DialogueTree dlg)
  System.Void OnDialogueFinished(NodeCanvas.DialogueTrees.DialogueTree dlg)
  System.Void OnSubtitlesRequest(NodeCanvas.DialogueTrees.SubtitlesRequestInfo info)
  System.Collections.IEnumerator Internal_OnSubtitlesRequestInfo(NodeCanvas.DialogueTrees.SubtitlesRequestInfo info)
  System.Void PlayTypeSound()
  System.Collections.IEnumerator CheckInput(System.Action Do)
  System.Collections.IEnumerator DelayPrint(System.Single time)
  System.Void OnMultipleChoiceRequest(NodeCanvas.DialogueTrees.MultipleChoiceRequestInfo info)
  System.Collections.IEnumerator CountDown(NodeCanvas.DialogueTrees.MultipleChoiceRequestInfo info)
  System.Void Finalize(NodeCanvas.DialogueTrees.MultipleChoiceRequestInfo info, System.Int32 index)
  System.Void SetMassAlpha(UnityEngine.RectTransform root, System.Single alpha)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.GraphInfoAttribute
TYPE:  class
TOKEN: 0x20003EB
EXTENDS: Attribute
FIELDS:
  public            System.String                   packageName  // 0x10
  public            System.String                   docsURL  // 0x18
  public            System.String                   resourcesURL  // 0x20
  public            System.String                   forumsURL  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.DropReferenceType
TYPE:  class
TOKEN: 0x20003EC
EXTENDS: Attribute
FIELDS:
  public    readonly System.Type                     type  // 0x10
METHODS:
  System.Void .ctor(System.Type type)
END_CLASS

CLASS: NodeCanvas.Framework.BlackboardOnlyAttribute
TYPE:  class
TOKEN: 0x20003ED
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.LogTag
TYPE:  class
TOKEN: 0x20003EE
FIELDS:
  public    static  System.String                   EDITOR  // 0x0
  public    static  System.String                   EVENT  // 0x0
  public    static  System.String                   EXECUTION  // 0x0
  public    static  System.String                   VARIABLE  // 0x0
  public    static  System.String                   BLACKBOARD  // 0x0
  public    static  System.String                   GRAPH  // 0x0
  public    static  System.String                   INIT  // 0x0
  public    static  System.String                   VALIDATION  // 0x0
  public    static  System.String                   SERIALIZATION  // 0x0
METHODS:
END_CLASS

CLASS: NodeCanvas.Framework.SignalDefinition
TYPE:  class
TOKEN: 0x20003EF
EXTENDS: ScriptableObject
FIELDS:
  private           NodeCanvas.Framework.SignalDefinition.InvokeArgumentsonInvoke  // 0x18
  private           System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition>_parameters  // 0x20
METHODS:
  System.Void add_onInvoke(NodeCanvas.Framework.SignalDefinition.InvokeArguments value)
  System.Void remove_onInvoke(NodeCanvas.Framework.SignalDefinition.InvokeArguments value)
  System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition> get_parameters()
  System.Void set_parameters(System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition> value)
  System.Void Invoke(UnityEngine.Transform sender, UnityEngine.Transform receiver, System.Boolean isGlobal, System.Object[] args)
  System.Void AddParameter(System.String name, System.Type type)
  System.Void RemoveParameter(System.String name)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.CanvasGroup
TYPE:  class
TOKEN: 0x20003F2
FIELDS:
  public            System.String                   name  // 0x10
  public            UnityEngine.Rect                rect  // 0x18
  public            UnityEngine.Color               color  // 0x28
  public            System.Boolean                  autoGroup  // 0x38
METHODS:
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Rect rect, System.String name)
END_CLASS

CLASS: NodeCanvas.Framework.Connection
TYPE:  class
TOKEN: 0x20003F3
FIELDS:
  private           NodeCanvas.Framework.Node       _sourceNode  // 0x10
  private           NodeCanvas.Framework.Node       _targetNode  // 0x18
  private           System.String                   _UID  // 0x20
  private           System.Boolean                  _isDisabled  // 0x28
  private           NodeCanvas.Framework.Status     _status  // 0x2C
METHODS:
  System.String get_UID()
  NodeCanvas.Framework.Node get_sourceNode()
  System.Void set_sourceNode(NodeCanvas.Framework.Node value)
  NodeCanvas.Framework.Node get_targetNode()
  System.Void set_targetNode(NodeCanvas.Framework.Node value)
  System.String NodeCanvas.Framework.IGraphElement.get_name()
  System.Boolean get_isActive()
  System.Void set_isActive(System.Boolean value)
  NodeCanvas.Framework.Status get_status()
  System.Void set_status(NodeCanvas.Framework.Status value)
  NodeCanvas.Framework.Graph get_graph()
  System.Boolean get_drawInspector()
  System.Void .ctor()
  NodeCanvas.Framework.Connection Create(NodeCanvas.Framework.Node source, NodeCanvas.Framework.Node target, System.Int32 sourceIndex, System.Int32 targetIndex)
  NodeCanvas.Framework.Connection Duplicate(NodeCanvas.Framework.Node newSource, NodeCanvas.Framework.Node newTarget)
  System.Int32 SetSourceNode(NodeCanvas.Framework.Node newSource, System.Int32 index, System.Boolean recodeUndo)
  System.Int32 SetTargetNode(NodeCanvas.Framework.Node newTarget, System.Int32 index, System.Boolean recodeUndo)
  NodeCanvas.Framework.Status Execute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void Reset(System.Boolean recursively)
  System.Void OnCreate(System.Int32 sourceIndex, System.Int32 targetIndex)
  System.Void OnValidate(System.Int32 sourceIndex, System.Int32 targetIndex)
  System.Void OnDestroy()
  System.Void OnDestroyAfterConnectionRemoved()
  System.String ToString()
END_CLASS

CLASS: NodeCanvas.Framework.ExposedParameter
TYPE:  class
TOKEN: 0x20003F4
FIELDS:
METHODS:
  System.String get_targetVariableID()
  System.Type get_type()
  System.Object get_valueBoxed()
  System.Void set_valueBoxed(System.Object value)
  System.Void Bind(NodeCanvas.Framework.IBlackboard blackboard)
  System.Void UnBind()
  NodeCanvas.Framework.Variable get_varRefBoxed()
  NodeCanvas.Framework.ExposedParameter CreateInstance(NodeCanvas.Framework.Variable target)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.ExposedParameter`1
TYPE:  class
TOKEN: 0x20003F5
EXTENDS: ExposedParameter
FIELDS:
  private           System.String                   _targetVariableID  // 0x0
  private           T                               _value  // 0x0
  private           NodeCanvas.Framework.Variable<T><varRef>k__BackingField  // 0x0
METHODS:
  NodeCanvas.Framework.Variable<T> get_varRef()
  System.Void set_varRef(NodeCanvas.Framework.Variable<T> value)
  System.Void .ctor()
  System.Void .ctor(NodeCanvas.Framework.Variable target)
  System.String get_targetVariableID()
  System.Type get_type()
  System.Object get_valueBoxed()
  System.Void set_valueBoxed(System.Object value)
  NodeCanvas.Framework.Variable get_varRefBoxed()
  T get_value()
  System.Void set_value(T value)
  System.Void Bind(NodeCanvas.Framework.IBlackboard blackboard)
  System.Void UnBind()
  T GetRawValue()
  System.Void SetRawValue(T value)
END_CLASS

CLASS: NodeCanvas.Framework.Graph
TYPE:  class
TOKEN: 0x20003F6
EXTENDS: ScriptableObject
FIELDS:
  private           System.String                   _serializedGraph  // 0x18
  protected         System.Int32                    _serializedGraphStringIndex  // 0x20
  private           System.Collections.Generic.List<UnityEngine.Object>_objectReferences  // 0x28
  private           NodeCanvas.Framework.Internal.GraphSource_graphSource  // 0x30
  private           System.Boolean                  _haltSerialization  // 0x38
  private           System.Boolean                  haltForUndo  // 0x39
  private   static  System.Action<NodeCanvas.Framework.Graph>onGraphSerialized  // 0x0
  public    static  System.Action<NodeCanvas.Framework.Graph>onGraphDeserialized  // 0x8
  private           System.Boolean                  <isDeserialized>k__BackingField  // 0x3A
  private   static  System.Collections.Generic.List<NodeCanvas.Framework.Node>s_nodeBuffer  // 0x10
  private           System.Boolean                  <graphValidateDirty>k__BackingField  // 0x3B
  private           System.Action<System.Boolean>   onFinish  // 0x40
  private   static  System.Collections.Generic.List<NodeCanvas.Framework.Graph>_runningGraphs  // 0x18
  private           System.Boolean                  <hasInitialized>k__BackingField  // 0x48
  private           ParadoxNotion.HierarchyTree.Element<flatMetaGraph>k__BackingField  // 0x50
  private           ParadoxNotion.HierarchyTree.Element<fullMetaGraph>k__BackingField  // 0x58
  private           ParadoxNotion.HierarchyTree.Element<nestedMetaGraph>k__BackingField  // 0x60
  private           NodeCanvas.Framework.Graph      <parentGraph>k__BackingField  // 0x68
  private           System.Single                   <elapsedTime>k__BackingField  // 0x70
  private           System.Single                   <deltaTime>k__BackingField  // 0x74
  private           System.Int32                    <lastUpdateFrame>k__BackingField  // 0x78
  private           System.Boolean                  <isRunning>k__BackingField  // 0x7C
  private           System.Boolean                  <isPaused>k__BackingField  // 0x7D
  private           NodeCanvas.Framework.Graph.UpdateMode<updateMode>k__BackingField  // 0x80
  private           UnityEngine.Component           <agent>k__BackingField  // 0x88
  private           NodeCanvas.Framework.IBlackboard<parentBlackboard>k__BackingField  // 0x90
  private           System.Action                   delayedInitCalls  // 0x98
METHODS:
  System.Void add_onGraphSerialized(System.Action<NodeCanvas.Framework.Graph> value)
  System.Void remove_onGraphSerialized(System.Action<NodeCanvas.Framework.Graph> value)
  System.Boolean get_allowRuntimeSerialization()
  System.Boolean get_dontSerializeBinderConnectionGenericType()
  System.Boolean get_isDeserialized()
  System.Void set_isDeserialized(System.Boolean value)
  System.Boolean get_canDelayDeserializeAndOptimizeClone()
  UnityEngine.Rect DrawCustomBlackboardPanel(UnityEngine.Event e, UnityEngine.Rect canvasRect, UnityEngine.Vector2 canvasMousePos)
  UnityEngine.Rect DrawCustomPanel(UnityEngine.Event e, UnityEngine.Rect canvasRect, UnityEngine.Vector2 canvasMousePos)
  UnityEngine.Rect DrawCustomPanel2(UnityEngine.Event e, UnityEngine.Rect canvasRect, UnityEngine.Vector2 canvasMousePos)
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void TryDeserializeIfNot()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void OnValidate()
  System.Void Reset()
  System.Boolean SelfSerialize(System.Boolean ignoreScene)
  System.Void OnAfterGraphSerialized()
  System.Boolean SelfDeserialize()
  System.String Serialize(System.Collections.Generic.List<UnityEngine.Object> references)
  System.Boolean Deserialize(System.String serializedGraph, System.Collections.Generic.List<UnityEngine.Object> references, System.Boolean validate)
  System.Boolean DeserializeSelf(System.Collections.Generic.List<UnityEngine.Object> references, System.Boolean validate)
  NodeCanvas.Framework.Internal.GraphSource GetGraphSource()
  System.String GetSerializedJsonData()
  System.Int32 GetSerializedJsonDataStringIndex()
  System.Boolean DeserializeFromGraph(NodeCanvas.Framework.Graph other, System.Boolean validate)
  Beyond.DataCompressManager.StringCompressUnsafeString GetSerializedJsonDataUnsafeString()
  System.Void ClearSerializedJsonData()
  System.Collections.Generic.List<UnityEngine.Object> GetSerializedReferencesData()
  NodeCanvas.Framework.Internal.GraphSource GetGraphSourceMetaDataCopy()
  System.Void SetGraphSourceMetaData(NodeCanvas.Framework.Internal.GraphSource source)
  System.String SerializeLocalBlackboard(System.Collections.Generic.List<UnityEngine.Object>& references)
  System.Boolean DeserializeLocalBlackboard(System.String json, System.Collections.Generic.List<UnityEngine.Object> references)
  T Clone(T graph, NodeCanvas.Framework.Graph parentGraph)
  System.Void Validate()
  System.Boolean get_graphValidateDirty()
  System.Void set_graphValidateDirty(System.Boolean value)
  System.Void add_onFinish(System.Action<System.Boolean> value)
  System.Void remove_onFinish(System.Action<System.Boolean> value)
  System.Boolean get_hasInitialized()
  System.Void set_hasInitialized(System.Boolean value)
  ParadoxNotion.HierarchyTree.Element get_flatMetaGraph()
  System.Void set_flatMetaGraph(ParadoxNotion.HierarchyTree.Element value)
  ParadoxNotion.HierarchyTree.Element get_fullMetaGraph()
  System.Void set_fullMetaGraph(ParadoxNotion.HierarchyTree.Element value)
  ParadoxNotion.HierarchyTree.Element get_nestedMetaGraph()
  System.Void set_nestedMetaGraph(ParadoxNotion.HierarchyTree.Element value)
  System.Type get_baseNodeType()
  System.Boolean get_requiresAgent()
  System.Boolean get_requiresPrimeNode()
  System.Boolean get_isTree()
  System.Boolean get_allowBlackboardOverrides()
  System.Boolean get_canAcceptVariableDrops()
  NodeCanvas.Framework.Internal.GraphSource get_graphSource()
  System.Void set_graphSource(NodeCanvas.Framework.Internal.GraphSource value)
  System.String get_category()
  System.Void set_category(System.String value)
  System.String get_comments()
  System.Void set_comments(System.String value)
  UnityEngine.Vector2 get_translation()
  System.Void set_translation(UnityEngine.Vector2 value)
  System.Single get_zoomFactor()
  System.Void set_zoomFactor(System.Single value)
  System.Collections.Generic.List<NodeCanvas.Framework.Node> get_allNodes()
  System.Void set_allNodes(System.Collections.Generic.List<NodeCanvas.Framework.Node> value)
  System.Collections.Generic.List<NodeCanvas.Framework.CanvasGroup> get_canvasGroups()
  System.Void set_canvasGroups(System.Collections.Generic.List<NodeCanvas.Framework.CanvasGroup> value)
  NodeCanvas.Framework.Internal.BlackboardSource get_localBlackboard()
  System.Void set_localBlackboard(NodeCanvas.Framework.Internal.BlackboardSource value)
  System.Collections.Generic.List<NodeCanvas.Framework.BBParameter> get_allParameters()
  System.Collections.Generic.List<NodeCanvas.Framework.Task> get_allTasks()
  System.Collections.Generic.List<NodeCanvas.Framework.Connection> get_allConnections()
  NodeCanvas.Framework.Graph get_rootGraph()
  System.Boolean get_serializationHalted()
  System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Graph> get_runningGraphs()
  NodeCanvas.Framework.Graph get_parentGraph()
  System.Void set_parentGraph(NodeCanvas.Framework.Graph value)
  System.Single get_elapsedTime()
  System.Void set_elapsedTime(System.Single value)
  System.Single get_deltaTime()
  System.Void set_deltaTime(System.Single value)
  System.Int32 get_lastUpdateFrame()
  System.Void set_lastUpdateFrame(System.Int32 value)
  System.Boolean get_didUpdateLastFrame()
  System.Boolean get_isRunning()
  System.Void set_isRunning(System.Boolean value)
  System.Boolean get_isPaused()
  System.Void set_isPaused(System.Boolean value)
  NodeCanvas.Framework.Graph.UpdateMode get_updateMode()
  System.Void set_updateMode(NodeCanvas.Framework.Graph.UpdateMode value)
  NodeCanvas.Framework.Node get_primeNode()
  System.Void set_primeNode(NodeCanvas.Framework.Node value)
  UnityEngine.Component get_agent()
  System.Void set_agent(UnityEngine.Component value)
  NodeCanvas.Framework.IBlackboard get_blackboard()
  NodeCanvas.Framework.IBlackboard get_parentBlackboard()
  System.Void set_parentBlackboard(NodeCanvas.Framework.IBlackboard value)
  UnityEngine.Object NodeCanvas.Framework.ITaskSystem.get_contextObject()
  System.Void UpdateReferencesFromOwner(NodeCanvas.Framework.GraphOwner owner, System.Boolean force)
  System.Void UpdateReferences(UnityEngine.Component newAgent, NodeCanvas.Framework.IBlackboard newParentBlackboard, System.Boolean force)
  System.Void UpdateNodeBBFields()
  System.Void NodeCanvas.Framework.ITaskSystem.UpdateTasksOwner()
  System.Void UpdateNodeIDs(System.Boolean alsoReorderList)
  System.Void OnGraphStructureChange()
  System.Void OnAfterUpdateNodeIDs()
  System.Int32 AssignNodeID(NodeCanvas.Framework.Node node, System.Int32 lastID, NodeCanvas.Framework.Node[]& parsed)
  System.Void add_delayedInitCalls(System.Action value)
  System.Void remove_delayedInitCalls(System.Action value)
  System.Void ThreadSafeInitCall(System.Action call)
  System.Void LoadOverwriteAsync(NodeCanvas.Framework.Internal.GraphLoadData data, System.Action callback)
  System.Void LoadOverwrite(NodeCanvas.Framework.Internal.GraphLoadData data)
  System.Void Initialize(UnityEngine.Component newAgent, NodeCanvas.Framework.IBlackboard newParentBlackboard, System.Boolean preInitializeSubGraphs)
  System.Void PreInitializeSubGraphs()
  System.Void StartGraph(UnityEngine.Component newAgent, NodeCanvas.Framework.IBlackboard newParentBlackboard, NodeCanvas.Framework.Graph.UpdateMode newUpdateMode, System.Action<System.Boolean> callback)
  System.Void ClearGraphData()
  System.Void Stop(System.Boolean success)
  System.Void Pause()
  System.Void Resume()
  System.Void Restart()
  System.Void UpdateGraph()
  System.Void UpdateGraph(System.Single deltaTime)
  System.Object OnDerivedDataSerialization()
  System.Void OnDerivedDataDeserialization(System.Object data)
  System.Void OnGraphInitialize()
  System.Void OnGraphStarted()
  System.Void OnGraphUpdate()
  System.Void OnGraphStoped()
  System.Void OnGraphPaused()
  System.Void OnGraphUnpaused()
  System.Void OnGraphObjectEnable()
  System.Void OnGraphObjectDisable()
  System.Void OnGraphObjectDestroy()
  System.Void OnGraphValidate()
  System.Void SendEvent(System.String name, System.Object value, System.Object sender)
  System.Void SendEvent(System.String name, T value, System.Object sender)
  System.Void SendGlobalEvent(System.String name, System.Object value, System.Object sender)
  System.Void SendGlobalEvent(System.String name, T value, System.Object sender)
  System.Collections.Generic.IEnumerable<NodeCanvas.Framework.BBParameter> GetAllParameters()
  System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Connection> GetAllConnections()
  System.Collections.Generic.IEnumerable<T> GetAllTasksOfType()
  NodeCanvas.Framework.Node GetNodeWithID(System.Int32 searchID)
  System.Collections.Generic.IEnumerable<T> GetAllNodesOfType()
  T GetNodeWithTag(System.String tagName)
  System.Collections.Generic.IEnumerable<T> GetNodesWithTag(System.String tagName)
  System.Collections.Generic.IEnumerable<T> GetAllTagedNodes()
  System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Node> GetRootNodes()
  System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Node> GetLeafNodes()
  System.Collections.Generic.IEnumerable<T> GetAllNestedGraphs(System.Boolean recursive)
  System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Graph> GetAllInstancedNestedGraphs()
  System.Collections.Generic.IEnumerable<NodeCanvas.Framework.BBParameter> GetDefinedParameters()
  System.Void PromoteMissingParametersToVariables(NodeCanvas.Framework.IBlackboard bb)
  NodeCanvas.Framework.Graph GetElementGraph(System.Object obj)
  ParadoxNotion.HierarchyTree.Element GetFlatMetaGraph()
  ParadoxNotion.HierarchyTree.Element GetFullMetaGraph()
  ParadoxNotion.HierarchyTree.Element GetNestedMetaGraph()
  System.Void DigNestedGraphs(NodeCanvas.Framework.Graph currentGraph, ParadoxNotion.HierarchyTree.Element currentElement)
  ParadoxNotion.HierarchyTree.Element GetTreeNodeElement(NodeCanvas.Framework.Node node, System.Boolean recurse, System.Int32& lastID)
  ParadoxNotion.HierarchyTree.Element CollectSubElements(NodeCanvas.Framework.IGraphElement obj)
  NodeCanvas.Framework.IGraphElement GetTaskParentElement(NodeCanvas.Framework.Task targetTask)
  NodeCanvas.Framework.IGraphElement GetParameterParentElement(NodeCanvas.Framework.BBParameter targetParameter)
  System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Task> GetTasksInElement(NodeCanvas.Framework.IGraphElement target)
  System.Collections.Generic.IEnumerable<NodeCanvas.Framework.BBParameter> GetParametersInElement(NodeCanvas.Framework.IGraphElement target)
  T AddNode()
  T AddNode(UnityEngine.Vector2 pos)
  NodeCanvas.Framework.Node AddNode(System.Type nodeType)
  NodeCanvas.Framework.Node AddNode(System.Type nodeType, UnityEngine.Vector2 pos)
  System.Void RemoveNode(NodeCanvas.Framework.Node node, System.Boolean recordUndo, System.Boolean force)
  NodeCanvas.Framework.Connection ConnectNodes(NodeCanvas.Framework.Node sourceNode, NodeCanvas.Framework.Node targetNode, System.Int32 sourceIndex, System.Int32 targetIndex)
  System.Void RemoveConnection(NodeCanvas.Framework.Connection connection, System.Boolean recordUndo, System.Boolean invokeGraphChanged)
  System.Collections.Generic.List<NodeCanvas.Framework.Node> CloneNodes(System.Collections.Generic.List<NodeCanvas.Framework.Node> originalNodes, NodeCanvas.Framework.Graph targetGraph, UnityEngine.Vector2 originPosition)
  System.Void ClearGraph()
  System.Void StartGraph(UnityEngine.Component newAgent, NodeCanvas.Framework.IBlackboard newBlackboard, System.Boolean autoUpdate, System.Action<System.Boolean> callback)
  System.Void ProcessStringCompress(Beyond.StringCompressVisitor visitor)
  System.Boolean CheckStringCompress()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: NodeCanvas.Framework.GraphOwner
TYPE:  class
TOKEN: 0x2000405
EXTENDS: MonoBehaviour
FIELDS:
  protected         System.Boolean                  isLazyLoadTriggered  // 0x18
  private           ParadoxNotion.Serialization.SerializationPair[]_serializedExposedParameters  // 0x20
  private           System.Collections.Generic.List<NodeCanvas.Framework.ExposedParameter><exposedParameters>k__BackingField  // 0x28
  public    static  System.Action<NodeCanvas.Framework.GraphOwner>onOwnerBehaviourStateChange  // 0x0
  private           System.Action                   onMonoBehaviourStart  // 0x30
  private           System.String                   _boundGraphSerialization  // 0x38
  private           System.Collections.Generic.List<UnityEngine.Object>_boundGraphObjectReferences  // 0x40
  private           NodeCanvas.Framework.Internal.GraphSource_boundGraphSource  // 0x48
  private           NodeCanvas.Framework.GraphOwner.FirstActivation_firstActivation  // 0x50
  private           NodeCanvas.Framework.GraphOwner.EnableAction_enableAction  // 0x54
  private           NodeCanvas.Framework.GraphOwner.DisableAction_disableAction  // 0x58
  private           System.Boolean                  _lockBoundGraphPrefabOverrides  // 0x5C
  private           System.Boolean                  _lockBoundGraphFromInstance  // 0x5D
  private           System.Boolean                  _preInitializeSubGraphs  // 0x5E
  private           NodeCanvas.Framework.Graph.UpdateMode_updateMode  // 0x60
  protected         System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph>instances  // 0x68
  private           System.Boolean                  <initialized>k__BackingField  // 0x70
  private           System.Boolean                  <enableCalled>k__BackingField  // 0x71
  private           System.Boolean                  <startCalled>k__BackingField  // 0x72
METHODS:
  System.Collections.Generic.List<NodeCanvas.Framework.ExposedParameter> get_exposedParameters()
  System.Void set_exposedParameters(System.Collections.Generic.List<NodeCanvas.Framework.ExposedParameter> value)
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void OnBeforeSerializeDoExtra()
  System.Void OnAfterDeserializeDoExtra()
  System.Void add_onMonoBehaviourStart(System.Action value)
  System.Void remove_onMonoBehaviourStart(System.Action value)
  NodeCanvas.Framework.Graph get_graph()
  System.Void set_graph(NodeCanvas.Framework.Graph value)
  NodeCanvas.Framework.IBlackboard get_blackboard()
  System.Void set_blackboard(NodeCanvas.Framework.IBlackboard value)
  System.Type get_graphType()
  System.Boolean get_initialized()
  System.Void set_initialized(System.Boolean value)
  System.Boolean get_enableCalled()
  System.Void set_enableCalled(System.Boolean value)
  System.Boolean get_startCalled()
  System.Void set_startCalled(System.Boolean value)
  NodeCanvas.Framework.Internal.GraphSource get_boundGraphSource()
  System.Void set_boundGraphSource(NodeCanvas.Framework.Internal.GraphSource value)
  System.String get_boundGraphSerialization()
  System.Void set_boundGraphSerialization(System.String value)
  System.Collections.Generic.List<UnityEngine.Object> get_boundGraphObjectReferences()
  System.Void set_boundGraphObjectReferences(System.Collections.Generic.List<UnityEngine.Object> value)
  System.Boolean get_lockBoundGraphPrefabOverrides()
  System.Void set_lockBoundGraphPrefabOverrides(System.Boolean value)
  System.Boolean get_lockBoundGraphFromInstance()
  System.Void set_lockBoundGraphFromInstance(System.Boolean value)
  System.Boolean get_preInitializeSubGraphs()
  System.Void set_preInitializeSubGraphs(System.Boolean value)
  NodeCanvas.Framework.GraphOwner.FirstActivation get_firstActivation()
  System.Void set_firstActivation(NodeCanvas.Framework.GraphOwner.FirstActivation value)
  NodeCanvas.Framework.GraphOwner.EnableAction get_enableAction()
  System.Void set_enableAction(NodeCanvas.Framework.GraphOwner.EnableAction value)
  NodeCanvas.Framework.GraphOwner.DisableAction get_disableAction()
  System.Void set_disableAction(NodeCanvas.Framework.GraphOwner.DisableAction value)
  NodeCanvas.Framework.Graph.UpdateMode get_updateMode()
  System.Void set_updateMode(NodeCanvas.Framework.Graph.UpdateMode value)
  System.Boolean get_graphIsBound()
  System.Boolean get_isRunning()
  System.Boolean get_isPaused()
  System.Single get_elapsedTime()
  System.Boolean get_canEditNonPersistantBoundGraph()
  NodeCanvas.Framework.Graph GetInstance(NodeCanvas.Framework.Graph originalGraph)
  NodeCanvas.Framework.Graph MakeRuntimeGraphInstance()
  System.Void StartBehaviour()
  System.Void StartBehaviour(System.Action<System.Boolean> callback)
  System.Void StartBehaviour(NodeCanvas.Framework.Graph.UpdateMode updateMode, System.Action<System.Boolean> callback)
  System.Void PauseBehaviour()
  System.Void StartBehaviourAsync(System.Action callBack)
  System.Void GetInstanceAsync(NodeCanvas.Framework.Graph originalGraph, System.Action<NodeCanvas.Framework.Graph> callBack)
  System.Void CreateSubInstanceAsync(System.Action callBack)
  System.Void StopBehaviour(System.Boolean success)
  System.Void UpdateBehaviour()
  System.Void RestartBehaviour()
  System.Void SendEvent(System.String eventName)
  System.Void SendEvent(System.String eventName, System.Object value, System.Object sender)
  System.Void SendEvent(System.String eventName, T eventValue, System.Object sender)
  T GetExposedParameterValue(System.String name)
  System.Void SetExposedParameterValue(System.String name, T value)
  NodeCanvas.Framework.ExposedParameter MakeNewExposedParameter(System.String name)
  System.Void Awake()
  System.Void Initialize()
  System.Void BindExposedParameters()
  System.Void UnBindExposedParameters()
  System.Void OnEnable()
  System.Void Start()
  System.Void InvokeStartEvent()
  System.Void OnDisable()
  System.Void DestroyInstance()
  System.Void OnDestroy()
  System.Void .ctor()
  System.Void <Initialize>b__108_0()
END_CLASS

CLASS: NodeCanvas.Framework.GraphOwner`1
TYPE:  class
TOKEN: 0x2000411
EXTENDS: GraphOwner
FIELDS:
  private           T                               _graph  // 0x0
  private           UnityEngine.Object              _blackboard  // 0x0
METHODS:
  NodeCanvas.Framework.Graph get_graph()
  System.Void set_graph(NodeCanvas.Framework.Graph value)
  T get_behaviour()
  System.Void set_behaviour(T value)
  NodeCanvas.Framework.IBlackboard get_blackboard()
  System.Void set_blackboard(NodeCanvas.Framework.IBlackboard value)
  System.Type get_graphType()
  System.Void StartBehaviour(T newGraph)
  System.Void StartBehaviour(T newGraph, System.Action<System.Boolean> callback)
  System.Void StartBehaviour(T newGraph, NodeCanvas.Framework.Graph.UpdateMode updateMode, System.Action<System.Boolean> callback)
  System.Void SwitchBehaviour(T newGraph)
  System.Void SwitchBehaviour(T newGraph, System.Action<System.Boolean> callback)
  System.Void SwitchBehaviour(T newGraph, NodeCanvas.Framework.Graph.UpdateMode updateMode, System.Action<System.Boolean> callback)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.IGraphAssignableExtensions
TYPE:  class
TOKEN: 0x2000412
FIELDS:
METHODS:
  NodeCanvas.Framework.Graph CheckInstance(NodeCanvas.Framework.IGraphAssignable assignable)
  System.Boolean TryStartSubGraph(NodeCanvas.Framework.IGraphAssignable assignable, UnityEngine.Component agent, System.Action<System.Boolean> callback)
  System.Boolean TryStopSubGraph(NodeCanvas.Framework.IGraphAssignable assignable)
  System.Boolean TryClearSubGraphData(NodeCanvas.Framework.IGraphAssignable assignable)
  System.Boolean TryPauseSubGraph(NodeCanvas.Framework.IGraphAssignable assignable)
  System.Boolean TryResumeSubGraph(NodeCanvas.Framework.IGraphAssignable assignable)
  System.Boolean TryUpdateSubGraph(NodeCanvas.Framework.IGraphAssignable assignable)
  System.Void TryWriteAndBindMappedVariables(NodeCanvas.Framework.IGraphAssignable assignable)
  System.Void TryReadAndUnbindMappedVariables(NodeCanvas.Framework.IGraphAssignable assignable)
  System.Void ValidateSubGraphAndParameters(NodeCanvas.Framework.IGraphAssignable assignable)
END_CLASS

CLASS: NodeCanvas.Framework.IGraphElement
TYPE:  interface
TOKEN: 0x2000414
FIELDS:
METHODS:
  System.String get_name()
  System.String get_UID()
  NodeCanvas.Framework.Graph get_graph()
  NodeCanvas.Framework.Status get_status()
END_CLASS

CLASS: NodeCanvas.Framework.IUpdatable
TYPE:  interface
TOKEN: 0x2000415
FIELDS:
METHODS:
  System.Void Update()
END_CLASS

CLASS: NodeCanvas.Framework.IInvokable
TYPE:  interface
TOKEN: 0x2000416
FIELDS:
METHODS:
  System.String GetInvocationID()
  System.Object Invoke(System.Object[] args)
  System.Void InvokeAsync(System.Action<System.Object> callback, System.Object[] args)
END_CLASS

CLASS: NodeCanvas.Framework.IGraphAssignable
TYPE:  interface
TOKEN: 0x2000417
FIELDS:
METHODS:
  NodeCanvas.Framework.Graph get_subGraph()
  System.Void set_subGraph(NodeCanvas.Framework.Graph value)
  NodeCanvas.Framework.Graph get_currentInstance()
  System.Void set_currentInstance(NodeCanvas.Framework.Graph value)
  System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> get_instances()
  System.Void set_instances(System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> get_variablesMap()
  System.Void set_variablesMap(System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> value)
END_CLASS

CLASS: NodeCanvas.Framework.IGraphAssignable`1
TYPE:  interface
TOKEN: 0x2000418
FIELDS:
METHODS:
  T get_subGraph()
  System.Void set_subGraph(T value)
  T get_currentInstance()
  System.Void set_currentInstance(T value)
END_CLASS

CLASS: NodeCanvas.Framework.ITaskAssignable
TYPE:  interface
TOKEN: 0x2000419
FIELDS:
METHODS:
  NodeCanvas.Framework.Task get_task()
  System.Void set_task(NodeCanvas.Framework.Task value)
END_CLASS

CLASS: NodeCanvas.Framework.ITaskAssignable`1
TYPE:  interface
TOKEN: 0x200041A
FIELDS:
METHODS:
END_CLASS

CLASS: NodeCanvas.Framework.IHaveNodeReference
TYPE:  interface
TOKEN: 0x200041B
FIELDS:
METHODS:
  NodeCanvas.Framework.INodeReference get_targetReference()
END_CLASS

CLASS: NodeCanvas.Framework.IReflectedWrapper
TYPE:  interface
TOKEN: 0x200041C
FIELDS:
METHODS:
  ParadoxNotion.Serialization.ISerializedReflectedInfo GetSerializedInfo()
END_CLASS

CLASS: NodeCanvas.Framework.ISubTasksContainer
TYPE:  interface
TOKEN: 0x200041D
FIELDS:
METHODS:
  NodeCanvas.Framework.Task[] GetSubTasks()
END_CLASS

CLASS: NodeCanvas.Framework.ISubParametersContainer
TYPE:  interface
TOKEN: 0x200041E
FIELDS:
METHODS:
  NodeCanvas.Framework.BBParameter[] GetSubParameters()
END_CLASS

CLASS: NodeCanvas.Framework.Node
TYPE:  class
TOKEN: 0x200041F
FIELDS:
  public            System.Single                   additionalWidth  // 0x10
  private           System.String                   _UID  // 0x18
  private           System.String                   _name  // 0x20
  private           System.String                   _tag  // 0x28
  private           UnityEngine.Vector2             _position  // 0x30
  private           System.String                   _comment  // 0x38
  private           System.Boolean                  _isBreakpoint  // 0x40
  private           NodeCanvas.Framework.Graph      _graph  // 0x48
  private           System.Int32                    _ID  // 0x50
  private           System.Collections.Generic.List<NodeCanvas.Framework.Connection>_inConnections  // 0x58
  private           System.Collections.Generic.List<NodeCanvas.Framework.Connection>_outConnections  // 0x60
  private           NodeCanvas.Framework.Status     _status  // 0x68
  private           System.String                   _nameCache  // 0x70
  private           System.String                   _descriptionCache  // 0x78
  private           System.Int32                    _priorityCache  // 0x80
  private   readonly System.Boolean                  <allowResizeHorizontal>k__BackingField  // 0x84
  private           System.Boolean                  <canResizeHorizontal>k__BackingField  // 0x85
  private           System.Boolean                  <resizingHorizontal>k__BackingField  // 0x86
  private           System.Boolean                  <isHighlight>k__BackingField  // 0x87
  public            System.Single                   highlightColorFade  // 0x88
  private           System.Single                   <timeStarted>k__BackingField  // 0x8C
  private           System.Boolean                  <isChecked>k__BackingField  // 0x90
  private           System.Boolean                  <breakPointReached>k__BackingField  // 0x91
METHODS:
  System.Nullable<System.Single> get_overrideNodeWidth()
  NodeCanvas.Framework.Graph get_graph()
  System.Void set_graph(NodeCanvas.Framework.Graph value)
  System.Int32 get_ID()
  System.Void set_ID(System.Int32 value)
  System.String get_UID()
  System.String AllocateUID()
  System.Collections.Generic.List<NodeCanvas.Framework.Connection> get_inConnections()
  System.Void set_inConnections(System.Collections.Generic.List<NodeCanvas.Framework.Connection> value)
  System.Collections.Generic.List<NodeCanvas.Framework.Connection> get_outConnections()
  System.Void set_outConnections(System.Collections.Generic.List<NodeCanvas.Framework.Connection> value)
  UnityEngine.Vector2 get_position()
  System.Void set_position(UnityEngine.Vector2 value)
  System.String get_customName()
  System.Void set_customName(System.String value)
  System.String get_tag()
  System.Void set_tag(System.String value)
  System.String get_comments()
  System.Void set_comments(System.String value)
  System.String get_commentForShow()
  System.String get_rawComment()
  System.Boolean get_modifyComment()
  System.String get_modifiedComment()
  System.Boolean get_isBreakpoint()
  System.Void set_isBreakpoint(System.Boolean value)
  System.String get_name()
  System.Void set_name(System.String value)
  System.String get_description()
  System.Int32 get_priority()
  System.Int32 get_maxInConnections()
  System.Int32 get_maxOutConnections()
  System.Type get_outConnectionType()
  System.Boolean get_allowAsPrime()
  System.Boolean get_canSelfConnect()
  ParadoxNotion.Alignment2x2 get_commentsAlignment()
  ParadoxNotion.Alignment2x2 get_iconAlignment()
  System.Boolean get_isBeyondGraph()
  System.Boolean get_drawInspector()
  System.Boolean get_inspectorShowTag()
  System.Boolean get_allowResizeHorizontal()
  System.Boolean get_canResizeHorizontal()
  System.Void set_canResizeHorizontal(System.Boolean value)
  System.Boolean get_resizingHorizontal()
  System.Void set_resizingHorizontal(System.Boolean value)
  System.Boolean get_allowDragInContentRect()
  System.String get_nodeIconKey()
  System.String get_nodeIconKey2()
  System.String get_nodeIconKey3()
  System.Boolean get_isHighlight()
  System.Void set_isHighlight(System.Boolean value)
  System.Boolean get_drawNameTagOrComment()
  NodeCanvas.Framework.Status get_status()
  System.Void set_status(NodeCanvas.Framework.Status value)
  UnityEngine.Component get_graphAgent()
  NodeCanvas.Framework.IBlackboard get_graphBlackboard()
  System.Single get_elapsedTime()
  System.Single get_timeStarted()
  System.Void set_timeStarted(System.Single value)
  System.Boolean get_isChecked()
  System.Void set_isChecked(System.Boolean value)
  System.Boolean get_breakPointReached()
  System.Void set_breakPointReached(System.Boolean value)
  System.Void .ctor()
  NodeCanvas.Framework.Node Create(NodeCanvas.Framework.Graph targetGraph, System.Type nodeType, UnityEngine.Vector2 pos)
  NodeCanvas.Framework.Node Duplicate(NodeCanvas.Framework.Graph targetGraph)
  System.Void Validate(NodeCanvas.Framework.Graph assignedGraph)
  NodeCanvas.Framework.Status Execute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void Reset(System.Boolean recursively)
  System.Collections.IEnumerator YieldBreak(System.Action resume)
  NodeCanvas.Framework.Status Error(System.Object msg)
  NodeCanvas.Framework.Status Fail(System.String msg)
  System.Void Warn(System.String msg)
  System.Void SetStatus(NodeCanvas.Framework.Status status)
  System.Void SendEvent(System.String eventName)
  System.Void SendEvent(System.String eventName, T value)
  System.Boolean IsNewConnectionAllowed(NodeCanvas.Framework.Node sourceNode, NodeCanvas.Framework.Node targetNode, NodeCanvas.Framework.Connection refConnection)
  System.Boolean CanConnectToTarget(NodeCanvas.Framework.Node targetNode)
  System.Boolean CanConnectFromSource(NodeCanvas.Framework.Node sourceNode)
  System.Boolean AreNodesConnected(NodeCanvas.Framework.Node a, NodeCanvas.Framework.Node b)
  UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
  System.Void StopCoroutine(UnityEngine.Coroutine routine)
  System.Void StartParallelTask(System.Action action)
  System.Void StopParallelTask(System.Action action)
  System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Node> GetParentNodes()
  System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Node> GetChildNodes()
  System.Boolean IsChildOf(NodeCanvas.Framework.Node parentNode)
  System.Boolean IsParentOf(NodeCanvas.Framework.Node childNode)
  System.String GetWarningOrError()
  System.String GetHardError()
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void OnReset()
  System.Void OnCreate(NodeCanvas.Framework.Graph assignedGraph)
  System.Void OnDuplicate(NodeCanvas.Framework.Graph assignedGraph)
  System.Void OnValidate(NodeCanvas.Framework.Graph assignedGraph)
  System.Void OnDestroy()
  System.Void OnParentConnected(System.Int32 connectionIndex)
  System.Void OnParentDisconnected(System.Int32 connectionIndex)
  System.Void OnChildConnected(System.Int32 connectionIndex)
  System.Void OnChildDisconnected(System.Int32 connectionIndex)
  System.Void OnChildrenConnectionsSorted(System.Int32[] oldIndeces)
  System.Void OnGraphStarted()
  System.Void OnPostGraphStarted()
  System.Void OnGraphStoped()
  System.Void OnPostGraphStoped()
  System.Void OnGraphPaused()
  System.Void OnGraphUnpaused()
  System.Void OnClearNodeData()
  System.String ToString()
END_CLASS

CLASS: NodeCanvas.Framework.INodeReference
TYPE:  interface
TOKEN: 0x2000426
FIELDS:
METHODS:
  System.Type get_type()
  NodeCanvas.Framework.Node Get(NodeCanvas.Framework.Graph graph)
  System.Void Set(NodeCanvas.Framework.Node target)
END_CLASS

CLASS: NodeCanvas.Framework.NodeReference`1
TYPE:  class
TOKEN: 0x2000427
FIELDS:
  private           System.String                   _targetNodeUID  // 0x0
  private           System.WeakReference<T>         _targetNodeRef  // 0x0
METHODS:
  System.Type NodeCanvas.Framework.INodeReference.get_type()
  NodeCanvas.Framework.Node NodeCanvas.Framework.INodeReference.Get(NodeCanvas.Framework.Graph graph)
  System.Void NodeCanvas.Framework.INodeReference.Set(NodeCanvas.Framework.Node target)
  System.Void .ctor()
  System.Void .ctor(T target)
  T Get(NodeCanvas.Framework.Graph graph)
  System.Void Set(T target)
END_CLASS

CLASS: NodeCanvas.Framework.Status
TYPE:  struct
TOKEN: 0x2000429
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  NodeCanvas.Framework.Status     Failure  // 0x0
  public    static  NodeCanvas.Framework.Status     Success  // 0x0
  public    static  NodeCanvas.Framework.Status     Running  // 0x0
  public    static  NodeCanvas.Framework.Status     Resting  // 0x0
  public    static  NodeCanvas.Framework.Status     Error  // 0x0
  public    static  NodeCanvas.Framework.Status     Optional  // 0x0
METHODS:
END_CLASS

CLASS: NodeCanvas.Framework.ActionList
TYPE:  class
TOKEN: 0x200042A
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.ActionList.ActionsExecutionModeexecutionMode  // 0x68
  public            System.Collections.Generic.List<NodeCanvas.Framework.ActionTask>actions  // 0x70
  private           System.Int32                    currentActionIndex  // 0x78
  private           System.Boolean[]                finishedIndeces  // 0x80
METHODS:
  System.String get_info()
  NodeCanvas.Framework.Task Duplicate(NodeCanvas.Framework.ITaskSystem newOwnerSystem)
  System.String OnInit()
  System.Void OnExecute()
  System.Void OnUpdate()
  System.Void OnStop()
  System.Void OnPause()
  System.Void OnDrawGizmosSelected()
  System.Void AddAction(NodeCanvas.Framework.ActionTask action)
  System.String GetWarningOrError()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.ActionTask`1
TYPE:  class
TOKEN: 0x200042C
EXTENDS: ActionTask
FIELDS:
METHODS:
  System.Type get_agentType()
  T get_agent()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.ActionTask
TYPE:  class
TOKEN: 0x200042D
EXTENDS: Task
FIELDS:
  private           NodeCanvas.Framework.Status     status  // 0x58
  private           System.Single                   timeStarted  // 0x5C
  private           System.Boolean                  latch  // 0x60
  private           System.Boolean                  <isPaused>k__BackingField  // 0x61
METHODS:
  System.Single get_elapsedTime()
  System.Boolean get_isRunning()
  System.Boolean get_isPaused()
  System.Void set_isPaused(System.Boolean value)
  System.Void ExecuteIndependent(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard, System.Action<NodeCanvas.Framework.Status> callback)
  System.Collections.IEnumerator IndependentActionUpdater(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard, System.Action<NodeCanvas.Framework.Status> callback)
  NodeCanvas.Framework.Status ExecuteAction(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  NodeCanvas.Framework.Status Execute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void EndAction()
  System.Void EndAction(System.Boolean success)
  System.Void EndAction(System.Nullable<System.Boolean> success)
  System.Void Pause()
  System.Void OnExecute()
  System.Void OnUpdate()
  System.Void OnStop(System.Boolean interrupted)
  System.Void OnStop()
  System.Void OnPause()
  System.Void OnResume()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.ConditionList
TYPE:  class
TOKEN: 0x200042F
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.ConditionList.ConditionsCheckModecheckMode  // 0x68
  public            System.Collections.Generic.List<NodeCanvas.Framework.ConditionTask>conditions  // 0x70
METHODS:
  System.Boolean get_allTrueRequired()
  System.String get_info()
  NodeCanvas.Framework.Task Duplicate(NodeCanvas.Framework.ITaskSystem newOwnerSystem)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Boolean OnCheck()
  System.Void OnDrawGizmosSelected()
  System.Void AddCondition(NodeCanvas.Framework.ConditionTask condition)
  System.String GetWarningOrError()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.ConditionTask`1
TYPE:  class
TOKEN: 0x2000431
EXTENDS: ConditionTask
FIELDS:
METHODS:
  System.Type get_agentType()
  T get_agent()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.ConditionTask
TYPE:  class
TOKEN: 0x2000432
EXTENDS: Task
FIELDS:
  private           System.Boolean                  _invert  // 0x58
  private           System.Int32                    yieldReturn  // 0x5C
  private           System.Int32                    yields  // 0x60
  private           System.Boolean                  isRuntimeEnabled  // 0x64
METHODS:
  System.Boolean get_invert()
  System.Void set_invert(System.Boolean value)
  System.Void Enable(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb)
  System.Void Disable()
  System.Boolean CheckCondition(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Boolean Check(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Boolean CheckOnce(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void YieldReturn(System.Boolean value, System.Boolean keepValueUntilUsed)
  System.Collections.IEnumerator Flip()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.EventReceiverAttribute
TYPE:  class
TOKEN: 0x2000434
EXTENDS: Attribute
FIELDS:
  public    readonly System.String[]                 eventMessages  // 0x10
METHODS:
  System.Void .ctor(System.String[] args)
END_CLASS

CLASS: NodeCanvas.Framework.ITaskSystem
TYPE:  interface
TOKEN: 0x2000435
FIELDS:
METHODS:
  UnityEngine.Component get_agent()
  NodeCanvas.Framework.IBlackboard get_blackboard()
  UnityEngine.Object get_contextObject()
  System.Single get_elapsedTime()
  System.Single get_deltaTime()
  System.Void UpdateTasksOwner()
  System.Void SendEvent(System.String name, System.Object value, System.Object sender)
  System.Void SendEvent(System.String name, T value, System.Object sender)
END_CLASS

CLASS: NodeCanvas.Framework.Task
TYPE:  class
TOKEN: 0x2000436
FIELDS:
  private           System.Boolean                  _isUserDisabled  // 0x10
  protected internal        NodeCanvas.Framework.Internal.TaskAgentParameter_agentParameter  // 0x18
  private           NodeCanvas.Framework.ITaskSystem_ownerSystem  // 0x20
  private           UnityEngine.Component           _currentAgent  // 0x28
  private           System.String                   _taskName  // 0x30
  private           System.String                   _taskDescription  // 0x38
  private           System.String                   _obsoleteInfo  // 0x40
  private           System.Boolean                  _isRuntimeActive  // 0x48
  private           System.Boolean                  _isInitSuccess  // 0x49
  private           ParadoxNotion.Services.EventRouter_eventRouter  // 0x50
METHODS:
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void .ctor()
  T Create(NodeCanvas.Framework.ITaskSystem newOwnerSystem)
  NodeCanvas.Framework.Task Create(System.Type type, NodeCanvas.Framework.ITaskSystem newOwnerSystem)
  NodeCanvas.Framework.Task Duplicate(NodeCanvas.Framework.ITaskSystem newOwnerSystem)
  System.Void Validate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.Void SetOwnerSystem(NodeCanvas.Framework.ITaskSystem newOwnerSystem)
  NodeCanvas.Framework.ITaskSystem get_ownerSystem()
  System.Void set_ownerSystem(NodeCanvas.Framework.ITaskSystem value)
  UnityEngine.Component get_ownerSystemAgent()
  NodeCanvas.Framework.IBlackboard get_ownerSystemBlackboard()
  System.Single get_ownerSystemElapsedTime()
  System.Boolean get_isUserEnabled()
  System.Void set_isUserEnabled(System.Boolean value)
  System.String get_obsolete()
  System.String get_name()
  System.String get_description()
  System.String get_summaryInfo()
  System.String get_info()
  System.Type get_agentType()
  System.String get_agentInfo()
  System.String get_agentParameterName()
  System.Boolean get_agentIsOverride()
  System.Void set_agentIsOverride(System.Boolean value)
  UnityEngine.Component get_agent()
  NodeCanvas.Framework.IBlackboard get_blackboard()
  ParadoxNotion.Services.EventRouter get_router()
  System.Boolean Set(UnityEngine.Component newAgent, NodeCanvas.Framework.IBlackboard newBB)
  System.Boolean Initialize(UnityEngine.Component newAgent)
  System.Boolean InitializeFieldAttributes(UnityEngine.Component newAgent)
  System.Boolean Error(System.String error, System.String tag)
  UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
  System.Void StopCoroutine(UnityEngine.Coroutine routine)
  System.Void SendEvent(System.String name)
  System.Void SendEvent(System.String name, T value)
  System.String GetWarningOrError()
  System.String OnErrorCheck()
  System.String GetHardError()
  System.String OnInit()
  System.Void OnCreate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.Void OnDrawGizmos()
  System.Void OnDrawGizmosSelected()
  System.Void ClearTaskData()
  System.Void OnClearTaskData()
  System.String ToString()
END_CLASS

CLASS: NodeCanvas.Framework.AssetBlackboard
TYPE:  class
TOKEN: 0x2000438
EXTENDS: ScriptableObject
FIELDS:
  private           System.Action<NodeCanvas.Framework.Variable>onVariableAdded  // 0x18
  private           System.Action<NodeCanvas.Framework.Variable>onVariableRemoved  // 0x20
  private           System.String                   _serializedBlackboard  // 0x28
  private           System.Collections.Generic.List<UnityEngine.Object>_objectReferences  // 0x30
  private           System.String                   _UID  // 0x38
  private           System.String                   _identifier  // 0x40
  private           NodeCanvas.Framework.Internal.BlackboardSource_blackboard  // 0x48
METHODS:
  System.Void add_onVariableAdded(System.Action<NodeCanvas.Framework.Variable> value)
  System.Void remove_onVariableAdded(System.Action<NodeCanvas.Framework.Variable> value)
  System.Void add_onVariableRemoved(System.Action<NodeCanvas.Framework.Variable> value)
  System.Void remove_onVariableRemoved(System.Action<NodeCanvas.Framework.Variable> value)
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void SelfSerialize()
  System.Void SelfDeserialize()
  System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> NodeCanvas.Framework.IBlackboard.get_variables()
  System.Void NodeCanvas.Framework.IBlackboard.set_variables(System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> value)
  UnityEngine.Object NodeCanvas.Framework.IBlackboard.get_unityContextObject()
  NodeCanvas.Framework.IBlackboard NodeCanvas.Framework.IBlackboard.get_parent()
  UnityEngine.Component NodeCanvas.Framework.IBlackboard.get_propertiesBindTarget()
  System.String NodeCanvas.Framework.IBlackboard.get_independantVariablesFieldName()
  System.Void NodeCanvas.Framework.IBlackboard.TryInvokeOnVariableAdded(NodeCanvas.Framework.Variable variable)
  System.Void NodeCanvas.Framework.IBlackboard.TryInvokeOnVariableRemoved(NodeCanvas.Framework.Variable variable)
  System.String get_identifier()
  System.String get_UID()
  System.Void ShowJson()
  System.String ToString()
  System.Void OnValidate()
  System.Void OnEnable()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.BBParameter
TYPE:  class
TOKEN: 0x2000439
FIELDS:
  private           System.String                   _name  // 0x10
  private           System.String                   _targetVariableID  // 0x18
  private           NodeCanvas.Framework.IBlackboard_bb  // 0x20
  private           NodeCanvas.Framework.Variable   _varRef  // 0x28
  private           System.Action<NodeCanvas.Framework.Variable>onVariableReferenceChanged  // 0x30
METHODS:
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void add_onVariableReferenceChanged(System.Action<NodeCanvas.Framework.Variable> value)
  System.Void remove_onVariableReferenceChanged(System.Action<NodeCanvas.Framework.Variable> value)
  System.Void .ctor()
  NodeCanvas.Framework.BBParameter CreateInstance(System.Type t, NodeCanvas.Framework.IBlackboard bb)
  System.Void SetBBFields(System.Object target, NodeCanvas.Framework.IBlackboard bb)
  System.String get_targetVariableID()
  System.Void set_targetVariableID(System.String value)
  NodeCanvas.Framework.Variable get_varRef()
  System.Void set_varRef(NodeCanvas.Framework.Variable value)
  System.String get_name()
  System.Void set_name(System.String value)
  NodeCanvas.Framework.IBlackboard get_bb()
  System.Void set_bb(NodeCanvas.Framework.IBlackboard value)
  System.Boolean get_useBlackboard()
  System.Void set_useBlackboard(System.Boolean value)
  System.Boolean get_isPresumedDynamic()
  System.Boolean get_isNone()
  System.Boolean get_isNull()
  System.Boolean get_isNoneOrNull()
  System.Boolean get_isDefined()
  System.Type get_refType()
  System.Object get_value()
  System.Void set_value(System.Object value)
  System.Type get_varType()
  System.Void SetDefaultValue()
  System.Void Bind(NodeCanvas.Framework.Variable data)
  System.Object GetValueBoxed()
  System.Void SetValueBoxed(System.Object value)
  System.Void SetTargetVariable(NodeCanvas.Framework.IBlackboard targetBB, NodeCanvas.Framework.Variable targetVariable)
  NodeCanvas.Framework.Variable ResolveReference(NodeCanvas.Framework.IBlackboard targetBlackboard, System.Boolean useID)
  NodeCanvas.Framework.Variable PromoteToVariable(NodeCanvas.Framework.IBlackboard targetBB)
  System.String ToString()
END_CLASS

CLASS: NodeCanvas.Framework.BBParameter`1
TYPE:  class
TOKEN: 0x200043B
EXTENDS: BBParameter
FIELDS:
  protected         T                               _value  // 0x0
  private           System.Func<T>                  getter  // 0x0
  private           System.Action<T>                setter  // 0x0
METHODS:
  System.Void add_getter(System.Func<T> value)
  System.Void remove_getter(System.Func<T> value)
  System.Void add_setter(System.Action<T> value)
  System.Void remove_setter(System.Action<T> value)
  T get_value()
  System.Void set_value(T value)
  System.Type get_varType()
  System.Void .ctor()
  System.Void .ctor(T value)
  System.Object GetValueBoxed()
  System.Void SetValueBoxed(System.Object newValue)
  T GetValue()
  System.Void SetValue(T value)
  System.Void SetDefaultValue()
  System.Void Bind(NodeCanvas.Framework.Variable variable)
  System.Boolean BindGetter(NodeCanvas.Framework.Variable variable)
  System.Boolean BindSetter(NodeCanvas.Framework.Variable variable)
  NodeCanvas.Framework.BBParameter<T> op_Implicit(T value)
END_CLASS

CLASS: NodeCanvas.Framework.Blackboard
TYPE:  class
TOKEN: 0x200043F
EXTENDS: MonoBehaviour
FIELDS:
  private           NodeCanvas.Framework.AssetBlackboard_parentBlackboard  // 0x18
  private           System.String                   _serializedBlackboard  // 0x20
  private           System.Collections.Generic.List<UnityEngine.Object>_objectReferences  // 0x28
  private           ParadoxNotion.Serialization.SerializationPair[]_serializedVariables  // 0x30
  private           NodeCanvas.Framework.Internal.BlackboardSource_blackboard  // 0x38
  private           System.Boolean                  haltForUndo  // 0x40
  private           System.String                   _identifier  // 0x48
  private           System.Action<NodeCanvas.Framework.Variable>onVariableAdded  // 0x50
  private           System.Action<NodeCanvas.Framework.Variable>onVariableRemoved  // 0x58
METHODS:
  NodeCanvas.Framework.Internal.BlackboardSource get_blackboard()
  NodeCanvas.Framework.AssetBlackboard get_parentBlackboard()
  System.Void SetParentBlackboard(NodeCanvas.Framework.AssetBlackboard bb)
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void SelfSerialize()
  System.Void SelfDeserialize()
  System.String Serialize(System.Collections.Generic.List<UnityEngine.Object> references, System.Boolean pretyJson)
  System.Boolean Deserialize(System.String json, System.Collections.Generic.List<UnityEngine.Object> references, System.Boolean removeMissingVariables)
  System.Void add_onVariableAdded(System.Action<NodeCanvas.Framework.Variable> value)
  System.Void remove_onVariableAdded(System.Action<NodeCanvas.Framework.Variable> value)
  System.Void add_onVariableRemoved(System.Action<NodeCanvas.Framework.Variable> value)
  System.Void remove_onVariableRemoved(System.Action<NodeCanvas.Framework.Variable> value)
  System.String NodeCanvas.Framework.IBlackboard.get_identifier()
  System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> NodeCanvas.Framework.IBlackboard.get_variables()
  System.Void NodeCanvas.Framework.IBlackboard.set_variables(System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> value)
  UnityEngine.Component NodeCanvas.Framework.IBlackboard.get_propertiesBindTarget()
  UnityEngine.Object NodeCanvas.Framework.IBlackboard.get_unityContextObject()
  NodeCanvas.Framework.IBlackboard NodeCanvas.Framework.IBlackboard.get_parent()
  System.String NodeCanvas.Framework.IBlackboard.get_independantVariablesFieldName()
  System.Void NodeCanvas.Framework.IBlackboard.TryInvokeOnVariableAdded(NodeCanvas.Framework.Variable variable)
  System.Void NodeCanvas.Framework.IBlackboard.TryInvokeOnVariableRemoved(NodeCanvas.Framework.Variable variable)
  System.Void Awake()
  NodeCanvas.Framework.Variable AddVariable(System.String name, System.Type type)
  NodeCanvas.Framework.Variable AddVariable(System.String name, System.Object value)
  NodeCanvas.Framework.Variable RemoveVariable(System.String name)
  NodeCanvas.Framework.Variable GetVariable(System.String name, System.Type ofType)
  NodeCanvas.Framework.Variable GetVariableByID(System.String ID)
  NodeCanvas.Framework.Variable<T> GetVariable(System.String name)
  T GetVariableValue(System.String name)
  NodeCanvas.Framework.Variable SetVariableValue(System.String name, System.Object value)
  T GetValue(System.String name)
  NodeCanvas.Framework.Variable SetValue(System.String name, System.Object value)
  System.Void ShowJson()
  System.String Save()
  System.String Save(System.String saveKey)
  System.Boolean Load()
  System.Boolean Load(System.String saveKey)
  System.Void OnValidate()
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.GlobalBlackboard
TYPE:  class
TOKEN: 0x2000440
EXTENDS: Blackboard
FIELDS:
  private           System.String                   _UID  // 0x60
  private           System.String                   _identifier  // 0x68
  private           NodeCanvas.Framework.GlobalBlackboard.SingletonMode_singletonMode  // 0x70
  private           System.Boolean                  _dontDestroyOnLoad  // 0x74
  private   static  System.Collections.Generic.List<NodeCanvas.Framework.GlobalBlackboard>_allGlobals  // 0x0
METHODS:
  System.String get_identifier()
  System.String get_UID()
  System.String get_name()
  System.Collections.Generic.IEnumerable<NodeCanvas.Framework.GlobalBlackboard> GetAll()
  NodeCanvas.Framework.GlobalBlackboard Create()
  NodeCanvas.Framework.GlobalBlackboard Find(System.String name)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnValidate()
  System.String ToString()
  System.Boolean IsPrefabAsset()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: NodeCanvas.Framework.IBlackboard
TYPE:  interface
TOKEN: 0x2000443
FIELDS:
METHODS:
  System.Void add_onVariableAdded(System.Action<NodeCanvas.Framework.Variable> value)
  System.Void remove_onVariableAdded(System.Action<NodeCanvas.Framework.Variable> value)
  System.Void add_onVariableRemoved(System.Action<NodeCanvas.Framework.Variable> value)
  System.Void remove_onVariableRemoved(System.Action<NodeCanvas.Framework.Variable> value)
  System.String get_identifier()
  NodeCanvas.Framework.IBlackboard get_parent()
  System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> get_variables()
  System.Void set_variables(System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> value)
  UnityEngine.Component get_propertiesBindTarget()
  UnityEngine.Object get_unityContextObject()
  System.String get_independantVariablesFieldName()
  System.Void TryInvokeOnVariableAdded(NodeCanvas.Framework.Variable variable)
  System.Void TryInvokeOnVariableRemoved(NodeCanvas.Framework.Variable variable)
END_CLASS

CLASS: NodeCanvas.Framework.IGlobalBlackboard
TYPE:  interface
TOKEN: 0x2000444
FIELDS:
METHODS:
  System.String get_UID()
END_CLASS

CLASS: NodeCanvas.Framework.IBlackboardExtensions
TYPE:  class
TOKEN: 0x2000445
FIELDS:
METHODS:
  NodeCanvas.Framework.IBlackboard GetRoot(NodeCanvas.Framework.IBlackboard blackboard)
  System.Collections.Generic.IEnumerable<NodeCanvas.Framework.IBlackboard> GetAllParents(NodeCanvas.Framework.IBlackboard blackboard, System.Boolean includeSelf)
  System.Boolean IsPartOf(NodeCanvas.Framework.IBlackboard blackboard, NodeCanvas.Framework.IBlackboard child)
  NodeCanvas.Framework.Variable<T> AddVariable(NodeCanvas.Framework.IBlackboard blackboard, System.String varName, T value)
  NodeCanvas.Framework.Variable<T> AddVariable(NodeCanvas.Framework.IBlackboard blackboard, System.String varName)
  NodeCanvas.Framework.Variable AddVariable(NodeCanvas.Framework.IBlackboard blackboard, System.String varName, System.Object value)
  NodeCanvas.Framework.Variable AddVariable(NodeCanvas.Framework.IBlackboard blackboard, System.String varName, System.Type type)
  NodeCanvas.Framework.Variable RemoveVariable(NodeCanvas.Framework.IBlackboard blackboard, System.String varName)
  T GetVariableValue(NodeCanvas.Framework.IBlackboard blackboard, System.String varName)
  NodeCanvas.Framework.Variable SetVariableValue(NodeCanvas.Framework.IBlackboard blackboard, System.String varName, System.Object value)
  System.Void InitializePropertiesBinding(NodeCanvas.Framework.IBlackboard blackboard, UnityEngine.Component target, System.Boolean callSetter)
  NodeCanvas.Framework.Variable<T> GetVariable(NodeCanvas.Framework.IBlackboard blackboard, System.String varName)
  NodeCanvas.Framework.Variable GetVariable(NodeCanvas.Framework.IBlackboard blackboard, System.String varName, System.Type ofType)
  NodeCanvas.Framework.Variable GetVariableByID(NodeCanvas.Framework.IBlackboard blackboard, System.String ID)
  System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Variable> GetVariables(NodeCanvas.Framework.IBlackboard blackboard, System.Type ofType)
  NodeCanvas.Framework.Variable ChangeVariableType(NodeCanvas.Framework.IBlackboard blackboard, NodeCanvas.Framework.Variable target, System.Type newType)
  System.Void OverwriteFrom(NodeCanvas.Framework.IBlackboard blackboard, NodeCanvas.Framework.IBlackboard sourceBlackboard, System.Boolean removeMissingVariables)
END_CLASS

CLASS: NodeCanvas.Framework.BlackboardHelpers
TYPE:  class
TOKEN: 0x2000448
FIELDS:
  private   static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Type>s_variableTypeCache  // 0x0
METHODS:
  System.Type CreateVariableType(System.Type valueType)
  System.Void .cctor()
END_CLASS

CLASS: NodeCanvas.Framework.Variable
TYPE:  class
TOKEN: 0x200044A
FIELDS:
  private           System.String                   _name  // 0x10
  private           System.String                   _id  // 0x18
  private           System.Boolean                  _isPublic  // 0x20
  private           System.Boolean                  _debugBoundValue  // 0x21
  private           System.Action<System.String>    onNameChanged  // 0x28
  private           System.Action<System.Object>    onValueChanged  // 0x30
  private           System.Action                   onDestroy  // 0x38
METHODS:
  System.Void add_onNameChanged(System.Action<System.String> value)
  System.Void remove_onNameChanged(System.Action<System.String> value)
  System.Void add_onValueChanged(System.Action<System.Object> value)
  System.Void remove_onValueChanged(System.Action<System.Object> value)
  System.Void add_onDestroy(System.Action value)
  System.Void remove_onDestroy(System.Action value)
  System.String get_name()
  System.Void set_name(System.String value)
  System.String get_ID()
  System.Object get_value()
  System.Void set_value(System.Object value)
  System.Boolean get_isExposedPublic()
  System.Void set_isExposedPublic(System.Boolean value)
  System.Boolean get_debugBoundValue()
  System.Void set_debugBoundValue(System.Boolean value)
  System.Boolean get_isPropertyBound()
  System.Boolean get_isDataBound()
  System.Type get_varType()
  System.String get_propertyPath()
  System.Void set_propertyPath(System.String value)
  System.Void BindProperty(System.Reflection.MemberInfo prop, UnityEngine.GameObject target)
  System.Void UnBind()
  System.Void InitializePropertyBinding(UnityEngine.GameObject go, System.Boolean callSetter)
  System.Object GetValueBoxed()
  System.Void SetValueBoxed(System.Object value)
  System.Void ResetDefaultValue()
  System.Void RecordDefaultValue()
  System.Void .ctor()
  System.Void .ctor(System.String name, System.String ID)
  System.Void OnDestroy()
  NodeCanvas.Framework.Variable Duplicate(NodeCanvas.Framework.IBlackboard targetBB)
  System.Boolean HasValueChangeEvent()
  System.Void TryInvokeValueChangeEvent(System.Object value)
  System.Boolean CanConvertTo(System.Type toType)
  System.Func<System.Object> GetGetConverter(System.Type toType)
  System.Boolean CanConvertFrom(System.Type fromType)
  System.Action<System.Object> GetSetConverter(System.Type fromType)
  System.String ToString()
END_CLASS

CLASS: NodeCanvas.Framework.Variable`1
TYPE:  class
TOKEN: 0x200044D
EXTENDS: Variable
FIELDS:
  private           T                               _value  // 0x0
  private           System.String                   _propertyPath  // 0x0
  private           System.Func<T>                  getter  // 0x0
  private           System.Action<T>                setter  // 0x0
  private           T                               m_originalValue  // 0x0
  private           System.Boolean                  m_hasOriginalValue  // 0x0
METHODS:
  System.Void add_getter(System.Func<T> value)
  System.Void remove_getter(System.Func<T> value)
  System.Void add_setter(System.Action<T> value)
  System.Void remove_setter(System.Action<T> value)
  System.Type get_varType()
  System.Boolean get_isDataBound()
  System.String get_propertyPath()
  System.Void set_propertyPath(System.String value)
  T get_value()
  System.Void set_value(T value)
  System.Void .ctor()
  System.Void .ctor(System.String name, System.String ID)
  System.Object GetValueBoxed()
  System.Void SetValueBoxed(System.Object newValue)
  T GetValue()
  System.Void SetValue(T newValue)
  System.Void ResetDefaultValue()
  System.Void RecordDefaultValue()
  System.Void BindProperty(System.Reflection.MemberInfo prop, UnityEngine.GameObject target)
  System.Void BindGetSet(System.Func<T> _get, System.Action<T> _set)
  System.Void UnBind()
  System.Void InitializePropertyBinding(UnityEngine.GameObject go, System.Boolean callSetter)
END_CLASS

CLASS: NodeCanvas.Framework.VariableSeperator
TYPE:  class
TOKEN: 0x2000452
FIELDS:
  private           System.Boolean                  <isEditingName>k__BackingField  // 0x10
METHODS:
  System.Void .ctor()
  System.Boolean get_isEditingName()
  System.Void set_isEditingName(System.Boolean value)
END_CLASS

CLASS: NodeCanvas.Framework.Internal.GraphLoadData
TYPE:  struct
TOKEN: 0x2000453
FIELDS:
  public            NodeCanvas.Framework.Internal.GraphSourcesource  // 0x10
  public            System.String                   json  // 0x18
  public            System.Collections.Generic.List<UnityEngine.Object>references  // 0x20
  public            UnityEngine.Component           agent  // 0x28
  public            NodeCanvas.Framework.IBlackboardparentBlackboard  // 0x30
  public            System.Boolean                  preInitializeSubGraphs  // 0x38
METHODS:
END_CLASS

CLASS: NodeCanvas.Framework.Internal.GraphSource
TYPE:  class
TOKEN: 0x2000454
FIELDS:
  private           System.Collections.Generic.List<NodeCanvas.Framework.Task>m_allTasks  // 0x10
  public            System.Collections.Generic.List<NodeCanvas.Framework.BBParameter>m_allParameters  // 0x18
  public    static  System.Single                   FRAMEWORK_VERSION  // 0x0
  private           System.Single                   _version  // 0x20
  private           System.String                   _category  // 0x28
  private           System.String                   _comments  // 0x30
  private           UnityEngine.Vector2             _translation  // 0x38
  private           System.Single                   _zoomFactor  // 0x40
  private           System.String                   _type  // 0x48
  private           System.Collections.Generic.List<NodeCanvas.Framework.Node>_nodes  // 0x50
  private           System.Collections.Generic.List<NodeCanvas.Framework.Connection>_connections  // 0x58
  private           System.Collections.Generic.List<NodeCanvas.Framework.CanvasGroup>_canvasGroups  // 0x60
  private           NodeCanvas.Framework.Internal.BlackboardSource_localBlackboard  // 0x68
  private           System.Object                   _derivedData  // 0x70
METHODS:
  System.Collections.Generic.List<NodeCanvas.Framework.Task> get_allTasks()
  System.Void set_allTasks(System.Collections.Generic.List<NodeCanvas.Framework.Task> value)
  System.Collections.Generic.List<NodeCanvas.Framework.BBParameter> get_allParameters()
  System.Void set_allParameters(System.Collections.Generic.List<NodeCanvas.Framework.BBParameter> value)
  System.Void ParadoxNotion.Serialization.FullSerializer.ISerializationCollector.OnPush(ParadoxNotion.Serialization.FullSerializer.ISerializationCollector parent)
  System.Void ParadoxNotion.Serialization.FullSerializer.ISerializationCollector.OnCollect(ParadoxNotion.Serialization.FullSerializer.ISerializationCollectable child, System.Int32 depth)
  System.Void ParadoxNotion.Serialization.FullSerializer.ISerializationCollector.OnPop(ParadoxNotion.Serialization.FullSerializer.ISerializationCollector parent)
  System.Single get_version()
  System.Void set_version(System.Single value)
  System.String get_category()
  System.Void set_category(System.String value)
  System.String get_comments()
  System.Void set_comments(System.String value)
  UnityEngine.Vector2 get_translation()
  System.Void set_translation(UnityEngine.Vector2 value)
  System.Single get_zoomFactor()
  System.Void set_zoomFactor(System.Single value)
  System.String get_type()
  System.Void set_type(System.String value)
  System.Collections.Generic.List<NodeCanvas.Framework.Node> get_nodes()
  System.Void set_nodes(System.Collections.Generic.List<NodeCanvas.Framework.Node> value)
  System.Collections.Generic.List<NodeCanvas.Framework.Connection> get_connections()
  System.Void set_connections(System.Collections.Generic.List<NodeCanvas.Framework.Connection> value)
  System.Collections.Generic.List<NodeCanvas.Framework.CanvasGroup> get_canvasGroups()
  System.Void set_canvasGroups(System.Collections.Generic.List<NodeCanvas.Framework.CanvasGroup> value)
  NodeCanvas.Framework.Internal.BlackboardSource get_localBlackboard()
  System.Void set_localBlackboard(NodeCanvas.Framework.Internal.BlackboardSource value)
  System.Object get_derivedData()
  System.Void set_derivedData(System.Object value)
  System.Void .ctor()
  NodeCanvas.Framework.Internal.GraphSource Pack(NodeCanvas.Framework.Graph graph)
  NodeCanvas.Framework.Internal.GraphSource Unpack(NodeCanvas.Framework.Graph graph)
  NodeCanvas.Framework.Internal.GraphSource SetMetaData(NodeCanvas.Framework.Internal.GraphSource source)
  System.Void PurgeRedundantReferences()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.MissingConnection
TYPE:  class
TOKEN: 0x2000455
EXTENDS: Connection
FIELDS:
  private           System.String                   _missingType  // 0x30
  private           System.String                   _recoveryState  // 0x38
METHODS:
  System.String ParadoxNotion.Serialization.IMissingRecoverable.get_missingType()
  System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_missingType(System.String value)
  System.String ParadoxNotion.Serialization.IMissingRecoverable.get_recoveryState()
  System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_recoveryState(System.String value)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.MissingNode
TYPE:  class
TOKEN: 0x2000456
EXTENDS: Node
FIELDS:
  private           System.String                   _missingType  // 0x98
  private           System.String                   _recoveryState  // 0xA0
METHODS:
  System.String ParadoxNotion.Serialization.IMissingRecoverable.get_missingType()
  System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_missingType(System.String value)
  System.String ParadoxNotion.Serialization.IMissingRecoverable.get_recoveryState()
  System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_recoveryState(System.String value)
  System.String get_name()
  System.Type get_outConnectionType()
  System.Int32 get_maxInConnections()
  System.Int32 get_maxOutConnections()
  System.Boolean get_allowAsPrime()
  System.Boolean get_canSelfConnect()
  ParadoxNotion.Alignment2x2 get_commentsAlignment()
  ParadoxNotion.Alignment2x2 get_iconAlignment()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedAction
TYPE:  class
TOKEN: 0x2000457
EXTENDS: ReflectedActionWrapper
FIELDS:
  private           ParadoxNotion.ActionCall        call  // 0x18
METHODS:
  NodeCanvas.Framework.BBParameter[] GetVariables()
  System.Void Init(System.Object instance)
  System.Void Call()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedAction`1
TYPE:  class
TOKEN: 0x2000458
EXTENDS: ReflectedActionWrapper
FIELDS:
  private           ParadoxNotion.ActionCall<T1>    call  // 0x0
  public            NodeCanvas.Framework.BBParameter<T1>p1  // 0x0
METHODS:
  NodeCanvas.Framework.BBParameter[] GetVariables()
  System.Void Init(System.Object instance)
  System.Void Call()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedAction`2
TYPE:  class
TOKEN: 0x2000459
EXTENDS: ReflectedActionWrapper
FIELDS:
  private           ParadoxNotion.ActionCall<T1,T2> call  // 0x0
  public            NodeCanvas.Framework.BBParameter<T1>p1  // 0x0
  public            NodeCanvas.Framework.BBParameter<T2>p2  // 0x0
METHODS:
  NodeCanvas.Framework.BBParameter[] GetVariables()
  System.Void Init(System.Object instance)
  System.Void Call()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedAction`3
TYPE:  class
TOKEN: 0x200045A
EXTENDS: ReflectedActionWrapper
FIELDS:
  private           ParadoxNotion.ActionCall<T1,T2,T3>call  // 0x0
  public            NodeCanvas.Framework.BBParameter<T1>p1  // 0x0
  public            NodeCanvas.Framework.BBParameter<T2>p2  // 0x0
  public            NodeCanvas.Framework.BBParameter<T3>p3  // 0x0
METHODS:
  NodeCanvas.Framework.BBParameter[] GetVariables()
  System.Void Init(System.Object instance)
  System.Void Call()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedAction`4
TYPE:  class
TOKEN: 0x200045B
EXTENDS: ReflectedActionWrapper
FIELDS:
  private           ParadoxNotion.ActionCall<T1,T2,T3,T4>call  // 0x0
  public            NodeCanvas.Framework.BBParameter<T1>p1  // 0x0
  public            NodeCanvas.Framework.BBParameter<T2>p2  // 0x0
  public            NodeCanvas.Framework.BBParameter<T3>p3  // 0x0
  public            NodeCanvas.Framework.BBParameter<T4>p4  // 0x0
METHODS:
  NodeCanvas.Framework.BBParameter[] GetVariables()
  System.Void Init(System.Object instance)
  System.Void Call()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedAction`5
TYPE:  class
TOKEN: 0x200045C
EXTENDS: ReflectedActionWrapper
FIELDS:
  private           ParadoxNotion.ActionCall<T1,T2,T3,T4,T5>call  // 0x0
  public            NodeCanvas.Framework.BBParameter<T1>p1  // 0x0
  public            NodeCanvas.Framework.BBParameter<T2>p2  // 0x0
  public            NodeCanvas.Framework.BBParameter<T3>p3  // 0x0
  public            NodeCanvas.Framework.BBParameter<T4>p4  // 0x0
  public            NodeCanvas.Framework.BBParameter<T5>p5  // 0x0
METHODS:
  NodeCanvas.Framework.BBParameter[] GetVariables()
  System.Void Init(System.Object instance)
  System.Void Call()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedAction`6
TYPE:  class
TOKEN: 0x200045D
EXTENDS: ReflectedActionWrapper
FIELDS:
  private           ParadoxNotion.ActionCall<T1,T2,T3,T4,T5,T6>call  // 0x0
  public            NodeCanvas.Framework.BBParameter<T1>p1  // 0x0
  public            NodeCanvas.Framework.BBParameter<T2>p2  // 0x0
  public            NodeCanvas.Framework.BBParameter<T3>p3  // 0x0
  public            NodeCanvas.Framework.BBParameter<T4>p4  // 0x0
  public            NodeCanvas.Framework.BBParameter<T5>p5  // 0x0
  public            NodeCanvas.Framework.BBParameter<T6>p6  // 0x0
METHODS:
  NodeCanvas.Framework.BBParameter[] GetVariables()
  System.Void Init(System.Object instance)
  System.Void Call()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedFunction`1
TYPE:  class
TOKEN: 0x200045E
EXTENDS: ReflectedFunctionWrapper
FIELDS:
  private           ParadoxNotion.FunctionCall<TResult>call  // 0x0
  public            NodeCanvas.Framework.BBParameter<TResult>result  // 0x0
METHODS:
  NodeCanvas.Framework.BBParameter[] GetVariables()
  System.Void Init(System.Object instance)
  System.Object Call()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedFunction`2
TYPE:  class
TOKEN: 0x200045F
EXTENDS: ReflectedFunctionWrapper
FIELDS:
  private           ParadoxNotion.FunctionCall<T1,TResult>call  // 0x0
  public            NodeCanvas.Framework.BBParameter<T1>p1  // 0x0
  public            NodeCanvas.Framework.BBParameter<TResult>result  // 0x0
METHODS:
  NodeCanvas.Framework.BBParameter[] GetVariables()
  System.Void Init(System.Object instance)
  System.Object Call()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedFunction`3
TYPE:  class
TOKEN: 0x2000460
EXTENDS: ReflectedFunctionWrapper
FIELDS:
  private           ParadoxNotion.FunctionCall<T1,T2,TResult>call  // 0x0
  public            NodeCanvas.Framework.BBParameter<T1>p1  // 0x0
  public            NodeCanvas.Framework.BBParameter<T2>p2  // 0x0
  public            NodeCanvas.Framework.BBParameter<TResult>result  // 0x0
METHODS:
  NodeCanvas.Framework.BBParameter[] GetVariables()
  System.Void Init(System.Object instance)
  System.Object Call()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedFunction`4
TYPE:  class
TOKEN: 0x2000461
EXTENDS: ReflectedFunctionWrapper
FIELDS:
  private           ParadoxNotion.FunctionCall<T1,T2,T3,TResult>call  // 0x0
  public            NodeCanvas.Framework.BBParameter<T1>p1  // 0x0
  public            NodeCanvas.Framework.BBParameter<T2>p2  // 0x0
  public            NodeCanvas.Framework.BBParameter<T3>p3  // 0x0
  public            NodeCanvas.Framework.BBParameter<TResult>result  // 0x0
METHODS:
  NodeCanvas.Framework.BBParameter[] GetVariables()
  System.Void Init(System.Object instance)
  System.Object Call()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedFunction`5
TYPE:  class
TOKEN: 0x2000462
EXTENDS: ReflectedFunctionWrapper
FIELDS:
  private           ParadoxNotion.FunctionCall<T1,T2,T3,T4,TResult>call  // 0x0
  public            NodeCanvas.Framework.BBParameter<T1>p1  // 0x0
  public            NodeCanvas.Framework.BBParameter<T2>p2  // 0x0
  public            NodeCanvas.Framework.BBParameter<T3>p3  // 0x0
  public            NodeCanvas.Framework.BBParameter<T4>p4  // 0x0
  public            NodeCanvas.Framework.BBParameter<TResult>result  // 0x0
METHODS:
  NodeCanvas.Framework.BBParameter[] GetVariables()
  System.Void Init(System.Object instance)
  System.Object Call()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedFunction`6
TYPE:  class
TOKEN: 0x2000463
EXTENDS: ReflectedFunctionWrapper
FIELDS:
  private           ParadoxNotion.FunctionCall<T1,T2,T3,T4,T5,TResult>call  // 0x0
  public            NodeCanvas.Framework.BBParameter<T1>p1  // 0x0
  public            NodeCanvas.Framework.BBParameter<T2>p2  // 0x0
  public            NodeCanvas.Framework.BBParameter<T3>p3  // 0x0
  public            NodeCanvas.Framework.BBParameter<T4>p4  // 0x0
  public            NodeCanvas.Framework.BBParameter<T5>p5  // 0x0
  public            NodeCanvas.Framework.BBParameter<TResult>result  // 0x0
METHODS:
  NodeCanvas.Framework.BBParameter[] GetVariables()
  System.Void Init(System.Object instance)
  System.Object Call()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedFunction`7
TYPE:  class
TOKEN: 0x2000464
EXTENDS: ReflectedFunctionWrapper
FIELDS:
  private           ParadoxNotion.FunctionCall<T1,T2,T3,T4,T5,T6,TResult>call  // 0x0
  public            NodeCanvas.Framework.BBParameter<T1>p1  // 0x0
  public            NodeCanvas.Framework.BBParameter<T2>p2  // 0x0
  public            NodeCanvas.Framework.BBParameter<T3>p3  // 0x0
  public            NodeCanvas.Framework.BBParameter<T4>p4  // 0x0
  public            NodeCanvas.Framework.BBParameter<T5>p5  // 0x0
  public            NodeCanvas.Framework.BBParameter<T6>p6  // 0x0
  public            NodeCanvas.Framework.BBParameter<TResult>result  // 0x0
METHODS:
  NodeCanvas.Framework.BBParameter[] GetVariables()
  System.Void Init(System.Object instance)
  System.Object Call()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedWrapper
TYPE:  class
TOKEN: 0x2000465
FIELDS:
  protected         ParadoxNotion.Serialization.SerializedMethodInfo_targetMethod  // 0x10
METHODS:
  System.Void .ctor()
  NodeCanvas.Framework.Internal.ReflectedWrapper Create(System.Reflection.MethodInfo method, NodeCanvas.Framework.IBlackboard bb)
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Void SetVariablesBB(NodeCanvas.Framework.IBlackboard bb)
  ParadoxNotion.Serialization.SerializedMethodInfo GetSerializedMethod()
  System.Reflection.MethodInfo GetMethod()
  System.Boolean HasChanged()
  System.String AsString()
  System.String ToString()
  NodeCanvas.Framework.BBParameter[] GetVariables()
  System.Void Init(System.Object instance)
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedActionWrapper
TYPE:  class
TOKEN: 0x2000466
EXTENDS: ReflectedWrapper
FIELDS:
METHODS:
  NodeCanvas.Framework.Internal.ReflectedActionWrapper Create(System.Reflection.MethodInfo method, NodeCanvas.Framework.IBlackboard bb)
  System.Void Call()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.ReflectedFunctionWrapper
TYPE:  class
TOKEN: 0x2000467
EXTENDS: ReflectedWrapper
FIELDS:
METHODS:
  NodeCanvas.Framework.Internal.ReflectedFunctionWrapper Create(System.Reflection.MethodInfo method, NodeCanvas.Framework.IBlackboard bb)
  System.Object Call()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.MissingAction
TYPE:  class
TOKEN: 0x2000468
EXTENDS: ActionTask
FIELDS:
  private           System.String                   _missingType  // 0x68
  private           System.String                   _recoveryState  // 0x70
METHODS:
  System.String ParadoxNotion.Serialization.IMissingRecoverable.get_missingType()
  System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_missingType(System.String value)
  System.String ParadoxNotion.Serialization.IMissingRecoverable.get_recoveryState()
  System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_recoveryState(System.String value)
  System.String get_info()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.MissingCondition
TYPE:  class
TOKEN: 0x2000469
EXTENDS: ConditionTask
FIELDS:
  private           System.String                   _missingType  // 0x68
  private           System.String                   _recoveryState  // 0x70
METHODS:
  System.String ParadoxNotion.Serialization.IMissingRecoverable.get_missingType()
  System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_missingType(System.String value)
  System.String ParadoxNotion.Serialization.IMissingRecoverable.get_recoveryState()
  System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_recoveryState(System.String value)
  System.String get_info()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.TaskAgentParameter
TYPE:  class
TOKEN: 0x200046A
EXTENDS: BBParameter`1
FIELDS:
  private           System.Type                     _type  // 0x50
METHODS:
  System.Type get_varType()
  UnityEngine.Object get_value()
  System.Void set_value(UnityEngine.Object value)
  System.Object GetValueBoxed()
  System.Void SetValueBoxed(System.Object newValue)
  System.Void SetType(System.Type newType)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.BBMappingParameter
TYPE:  class
TOKEN: 0x200046B
EXTENDS: BBObjectParameter
FIELDS:
  private           System.String                   _targetSubGraphVariableID  // 0x60
  private           System.Boolean                  _canRead  // 0x68
  private           System.Boolean                  _canWrite  // 0x69
METHODS:
  System.String get_targetSubGraphVariableID()
  System.Boolean get_canRead()
  System.Void set_canRead(System.Boolean value)
  System.Boolean get_canWrite()
  System.Void set_canWrite(System.Boolean value)
  System.Void .ctor()
  System.Void .ctor(NodeCanvas.Framework.Variable subVariable)
END_CLASS

CLASS: NodeCanvas.Framework.Internal.BBObjectParameter
TYPE:  class
TOKEN: 0x200046C
EXTENDS: BBParameter`1
FIELDS:
  private           System.String                   _type  // 0x50
  private           System.Type                     <type>k__BackingField  // 0x58
METHODS:
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Type get_type()
  System.Void set_type(System.Type value)
  System.Type get_varType()
  System.Void .ctor()
  System.Void .ctor(System.Type t)
  System.Void .ctor(NodeCanvas.Framework.BBParameter source)
  System.Void SetType(System.Type t)
END_CLASS

CLASS: NodeCanvas.Framework.Internal.BlackboardSource
TYPE:  class
TOKEN: 0x200046D
FIELDS:
  private           System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable>_variables  // 0x10
  private           System.Action<NodeCanvas.Framework.Variable>onVariableAdded  // 0x18
  private           System.Action<NodeCanvas.Framework.Variable>onVariableRemoved  // 0x20
  private           NodeCanvas.Framework.IBlackboard<parent>k__BackingField  // 0x28
  private           UnityEngine.Object              <unityContextObject>k__BackingField  // 0x30
  private           UnityEngine.Component           <propertiesBindTarget>k__BackingField  // 0x38
METHODS:
  System.Void add_onVariableAdded(System.Action<NodeCanvas.Framework.Variable> value)
  System.Void remove_onVariableAdded(System.Action<NodeCanvas.Framework.Variable> value)
  System.Void add_onVariableRemoved(System.Action<NodeCanvas.Framework.Variable> value)
  System.Void remove_onVariableRemoved(System.Action<NodeCanvas.Framework.Variable> value)
  System.String get_identifier()
  System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> get_variables()
  System.Void set_variables(System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> value)
  NodeCanvas.Framework.IBlackboard get_parent()
  System.Void set_parent(NodeCanvas.Framework.IBlackboard value)
  UnityEngine.Object get_unityContextObject()
  System.Void set_unityContextObject(UnityEngine.Object value)
  UnityEngine.Component get_propertiesBindTarget()
  System.Void set_propertiesBindTarget(UnityEngine.Component value)
  System.String NodeCanvas.Framework.IBlackboard.get_independantVariablesFieldName()
  System.Void NodeCanvas.Framework.IBlackboard.TryInvokeOnVariableAdded(NodeCanvas.Framework.Variable variable)
  System.Void NodeCanvas.Framework.IBlackboard.TryInvokeOnVariableRemoved(NodeCanvas.Framework.Variable variable)
  System.Void .ctor()
  System.String ToString()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.fsBBParameterProcessor
TYPE:  class
TOKEN: 0x200046E
EXTENDS: fsRecoveryProcessor`2
FIELDS:
METHODS:
  System.Void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& data)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.MissingBBParameterType
TYPE:  class
TOKEN: 0x200046F
EXTENDS: BBParameter`1
FIELDS:
  private           System.String                   _missingType  // 0x50
  private           System.String                   _recoveryState  // 0x58
METHODS:
  System.String ParadoxNotion.Serialization.IMissingRecoverable.get_missingType()
  System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_missingType(System.String value)
  System.String ParadoxNotion.Serialization.IMissingRecoverable.get_recoveryState()
  System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_recoveryState(System.String value)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Framework.Internal.MissingVariableType
TYPE:  class
TOKEN: 0x2000470
EXTENDS: Variable`1
FIELDS:
  private           System.String                   _missingType  // 0x70
  private           System.String                   _recoveryState  // 0x78
METHODS:
  System.String get_missingType()
  System.Void set_missingType(System.String value)
  System.String get_recoveryState()
  System.Void set_recoveryState(System.String value)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.FSM
TYPE:  class
TOKEN: 0x2000366
EXTENDS: Graph
FIELDS:
  private           System.Collections.Generic.List<NodeCanvas.Framework.IUpdatable>updatableNodes  // 0xA0
  private           NodeCanvas.StateMachines.IStateCallbackReceiver[]callbackReceivers  // 0xA8
  private           System.Collections.Generic.Stack<NodeCanvas.StateMachines.FSMState>stateStack  // 0xB0
  private           System.Boolean                  enterStartStateFlag  // 0xB8
  private           System.Action<NodeCanvas.StateMachines.IState>onStateEnter  // 0xC0
  private           System.Action<NodeCanvas.StateMachines.IState>onStateUpdate  // 0xC8
  private           System.Action<NodeCanvas.StateMachines.IState>onStateExit  // 0xD0
  private           System.Action<NodeCanvas.StateMachines.IState>onStateTransition  // 0xD8
  private           NodeCanvas.StateMachines.FSMState<currentState>k__BackingField  // 0xE0
  private           NodeCanvas.StateMachines.FSMState<previousState>k__BackingField  // 0xE8
METHODS:
  System.Void add_onStateEnter(System.Action<NodeCanvas.StateMachines.IState> value)
  System.Void remove_onStateEnter(System.Action<NodeCanvas.StateMachines.IState> value)
  System.Void add_onStateUpdate(System.Action<NodeCanvas.StateMachines.IState> value)
  System.Void remove_onStateUpdate(System.Action<NodeCanvas.StateMachines.IState> value)
  System.Void add_onStateExit(System.Action<NodeCanvas.StateMachines.IState> value)
  System.Void remove_onStateExit(System.Action<NodeCanvas.StateMachines.IState> value)
  System.Void add_onStateTransition(System.Action<NodeCanvas.StateMachines.IState> value)
  System.Void remove_onStateTransition(System.Action<NodeCanvas.StateMachines.IState> value)
  NodeCanvas.StateMachines.FSMState get_currentState()
  System.Void set_currentState(NodeCanvas.StateMachines.FSMState value)
  NodeCanvas.StateMachines.FSMState get_previousState()
  System.Void set_previousState(NodeCanvas.StateMachines.FSMState value)
  System.String get_currentStateName()
  System.String get_previousStateName()
  System.Type get_baseNodeType()
  System.Boolean get_requiresAgent()
  System.Boolean get_requiresPrimeNode()
  System.Boolean get_isTree()
  System.Boolean get_allowBlackboardOverrides()
  System.Boolean get_canAcceptVariableDrops()
  System.Boolean get_canDelayDeserializeAndOptimizeClone()
  System.Void OnGraphInitialize()
  System.Void OnGraphStarted()
  System.Void OnGraphUpdate()
  System.Void OnGraphStoped()
  System.Boolean EnterState(NodeCanvas.StateMachines.FSMState newState, NodeCanvas.StateMachines.FSM.TransitionCallMode callMode)
  NodeCanvas.StateMachines.FSMState TriggerState(System.String stateName, NodeCanvas.StateMachines.FSM.TransitionCallMode callMode)
  System.String[] GetStateNames()
  NodeCanvas.StateMachines.FSMState GetStateWithName(System.String name)
  System.Void GatherCallbackReceivers()
  NodeCanvas.StateMachines.FSMState PeekStack()
  System.Void .ctor()
  System.Void <GatherCallbackReceivers>b__51_0(NodeCanvas.StateMachines.IState x)
  System.Void <GatherCallbackReceivers>b__51_1(NodeCanvas.StateMachines.IState x)
  System.Void <GatherCallbackReceivers>b__51_2(NodeCanvas.StateMachines.IState x)
END_CLASS

CLASS: NodeCanvas.StateMachines.FSMConnection
TYPE:  class
TOKEN: 0x200036A
EXTENDS: Connection
FIELDS:
  private           NodeCanvas.StateMachines.FSM.TransitionCallMode_transitionCallMode  // 0x30
  private           NodeCanvas.Framework.ConditionTask_condition  // 0x38
METHODS:
  NodeCanvas.Framework.ConditionTask get_condition()
  System.Void set_condition(NodeCanvas.Framework.ConditionTask value)
  NodeCanvas.Framework.Task get_task()
  System.Void set_task(NodeCanvas.Framework.Task value)
  NodeCanvas.StateMachines.FSM.TransitionCallMode get_transitionCallMode()
  System.Void set_transitionCallMode(NodeCanvas.StateMachines.FSM.TransitionCallMode value)
  System.Void EnableCondition(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard)
  System.Void DisableCondition()
  System.Void PerformTransition()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.FSMNode
TYPE:  class
TOKEN: 0x200036B
EXTENDS: Node
FIELDS:
METHODS:
  System.Boolean get_allowAsPrime()
  System.Boolean get_canSelfConnect()
  System.Int32 get_maxInConnections()
  System.Int32 get_maxOutConnections()
  System.Type get_outConnectionType()
  ParadoxNotion.Alignment2x2 get_commentsAlignment()
  ParadoxNotion.Alignment2x2 get_iconAlignment()
  NodeCanvas.StateMachines.FSM get_FSM()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.FSMNodeNested`1
TYPE:  class
TOKEN: 0x200036C
EXTENDS: FSMNode
FIELDS:
  private           System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter>_variablesMap  // 0x0
  private           T                               <currentInstance>k__BackingField  // 0x0
  private           System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph><instances>k__BackingField  // 0x0
METHODS:
  T get_subGraph()
  System.Void set_subGraph(T value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  T get_currentInstance()
  System.Void set_currentInstance(T value)
  System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> get_instances()
  System.Void set_instances(System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> value)
  System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> get_variablesMap()
  System.Void set_variablesMap(System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> value)
  NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_subGraph()
  System.Void NodeCanvas.Framework.IGraphAssignable.set_subGraph(NodeCanvas.Framework.Graph value)
  NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_currentInstance()
  System.Void NodeCanvas.Framework.IGraphAssignable.set_currentInstance(NodeCanvas.Framework.Graph value)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.FSMOwner
TYPE:  class
TOKEN: 0x200036D
EXTENDS: GraphOwner`1
FIELDS:
METHODS:
  System.String get_currentRootStateName()
  System.String get_previousRootStateName()
  System.String get_currentDeepStateName()
  System.String get_previousDeepStateName()
  NodeCanvas.StateMachines.IState GetCurrentState(System.Boolean includeSubFSMs)
  NodeCanvas.StateMachines.IState GetPreviousState(System.Boolean includeSubFSMs)
  NodeCanvas.StateMachines.IState TriggerState(System.String stateName)
  NodeCanvas.StateMachines.IState TriggerState(System.String stateName, NodeCanvas.StateMachines.FSM.TransitionCallMode callMode)
  System.String[] GetStateNames()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.FSMState
TYPE:  class
TOKEN: 0x200036E
EXTENDS: FSMNode
FIELDS:
  private           NodeCanvas.StateMachines.FSMState.TransitionEvaluationMode_transitionEvaluation  // 0x98
  private           System.Boolean                  _hasInit  // 0x9C
METHODS:
  System.Boolean get_allowAsPrime()
  System.Boolean get_canSelfConnect()
  System.Int32 get_maxInConnections()
  System.Int32 get_maxOutConnections()
  NodeCanvas.StateMachines.FSMState.TransitionEvaluationMode get_transitionEvaluation()
  System.Void set_transitionEvaluation(NodeCanvas.StateMachines.FSMState.TransitionEvaluationMode value)
  NodeCanvas.StateMachines.FSMConnection[] GetTransitions()
  System.Void Finish()
  System.Void Finish(System.Boolean inSuccess)
  System.Void Finish(NodeCanvas.Framework.Status status)
  System.Void OnGraphPaused()
  System.Boolean CanConnectFromSource(NodeCanvas.Framework.Node sourceNode)
  System.Boolean CanConnectToTarget(NodeCanvas.Framework.Node targetNode)
  NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb)
  System.Boolean CheckTransitions()
  System.Void OnReset()
  System.Void OnInit()
  System.Void OnEnter()
  System.Void OnUpdate()
  System.Void OnExit()
  System.Void OnPause()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.FSMStateNested`1
TYPE:  class
TOKEN: 0x2000370
EXTENDS: FSMState
FIELDS:
  private           System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter>_variablesMap  // 0x0
  private           T                               <currentInstance>k__BackingField  // 0x0
  private           System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph><instances>k__BackingField  // 0x0
METHODS:
  T get_subGraph()
  System.Void set_subGraph(T value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  T get_currentInstance()
  System.Void set_currentInstance(T value)
  System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> get_instances()
  System.Void set_instances(System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> value)
  System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> get_variablesMap()
  System.Void set_variablesMap(System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> value)
  NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_subGraph()
  System.Void NodeCanvas.Framework.IGraphAssignable.set_subGraph(NodeCanvas.Framework.Graph value)
  NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_currentInstance()
  System.Void NodeCanvas.Framework.IGraphAssignable.set_currentInstance(NodeCanvas.Framework.Graph value)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.IState
TYPE:  interface
TOKEN: 0x2000371
FIELDS:
METHODS:
  System.String get_name()
  System.String get_tag()
  System.Single get_elapsedTime()
  NodeCanvas.StateMachines.FSM get_FSM()
  NodeCanvas.StateMachines.FSMConnection[] GetTransitions()
  System.Boolean CheckTransitions()
  System.Void Finish(System.Boolean success)
END_CLASS

CLASS: NodeCanvas.StateMachines.IStateCallbackReceiver
TYPE:  interface
TOKEN: 0x2000372
FIELDS:
METHODS:
  System.Void OnStateEnter(NodeCanvas.StateMachines.IState state)
  System.Void OnStateUpdate(NodeCanvas.StateMachines.IState state)
  System.Void OnStateExit(NodeCanvas.StateMachines.IState state)
END_CLASS

CLASS: NodeCanvas.StateMachines.ActionState
TYPE:  class
TOKEN: 0x2000373
EXTENDS: FSMState
FIELDS:
  private           NodeCanvas.Framework.ActionList _actionList  // 0xA0
  private           System.Boolean                  _repeatStateActions  // 0xA8
METHODS:
  NodeCanvas.Framework.Task get_task()
  System.Void set_task(NodeCanvas.Framework.Task value)
  NodeCanvas.Framework.ActionList get_actionList()
  System.Void set_actionList(NodeCanvas.Framework.ActionList value)
  System.Boolean get_repeatStateActions()
  System.Void set_repeatStateActions(System.Boolean value)
  System.Void OnValidate(NodeCanvas.Framework.Graph assignedGraph)
  System.Void OnEnter()
  System.Void OnUpdate()
  System.Void OnExit()
  System.Void OnPause()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.AnyState
TYPE:  class
TOKEN: 0x2000374
EXTENDS: FSMNode
FIELDS:
  public            System.Boolean                  dontRetriggerStates  // 0x98
METHODS:
  System.String get_name()
  System.Int32 get_maxInConnections()
  System.Int32 get_maxOutConnections()
  System.Boolean get_allowAsPrime()
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void NodeCanvas.Framework.IUpdatable.Update()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.ConcurrentSubFSM
TYPE:  class
TOKEN: 0x2000375
EXTENDS: FSMNodeNested`1
FIELDS:
  protected         NodeCanvas.Framework.BBParameter<NodeCanvas.StateMachines.FSM>_subFSM  // 0xB0
METHODS:
  System.String get_name()
  System.Int32 get_maxInConnections()
  System.Int32 get_maxOutConnections()
  System.Boolean get_allowAsPrime()
  NodeCanvas.StateMachines.FSM get_subGraph()
  System.Void set_subGraph(NodeCanvas.StateMachines.FSM value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  System.Void OnGraphStarted()
  System.Void NodeCanvas.Framework.IUpdatable.Update()
  System.Void .ctor()
  System.Void <OnGraphStarted>b__14_0(System.Boolean result)
END_CLASS

CLASS: NodeCanvas.StateMachines.ConcurrentSubTree
TYPE:  class
TOKEN: 0x2000376
EXTENDS: FSMNodeNested`1
FIELDS:
  protected         NodeCanvas.Framework.BBParameter<NodeCanvas.BehaviourTrees.BehaviourTree>_subTree  // 0xB0
METHODS:
  System.String get_name()
  System.Int32 get_maxInConnections()
  System.Int32 get_maxOutConnections()
  System.Boolean get_allowAsPrime()
  NodeCanvas.BehaviourTrees.BehaviourTree get_subGraph()
  System.Void set_subGraph(NodeCanvas.BehaviourTrees.BehaviourTree value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  System.Void OnGraphStarted()
  System.Void NodeCanvas.Framework.IUpdatable.Update()
  System.Void .ctor()
  System.Void <OnGraphStarted>b__14_0(System.Boolean result)
END_CLASS

CLASS: NodeCanvas.StateMachines.EmptyState
TYPE:  class
TOKEN: 0x2000377
EXTENDS: FSMState
FIELDS:
METHODS:
  System.String get_name()
  System.Void OnEnter()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.NestedBTState
TYPE:  class
TOKEN: 0x2000378
EXTENDS: FSMStateNested`1
FIELDS:
  private           NodeCanvas.Framework.BBParameter<NodeCanvas.BehaviourTrees.BehaviourTree>_nestedBT  // 0xB8
  public            NodeCanvas.StateMachines.NestedBTState.BTExitModeexitMode  // 0xC0
  public            NodeCanvas.StateMachines.NestedBTState.BTExecutionModeexecutionMode  // 0xC4
  public            System.String                   successEvent  // 0xC8
  public            System.String                   failureEvent  // 0xD0
METHODS:
  NodeCanvas.BehaviourTrees.BehaviourTree get_subGraph()
  System.Void set_subGraph(NodeCanvas.BehaviourTrees.BehaviourTree value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  System.Void OnEnter()
  System.Void OnUpdate()
  System.Void OnFinish(System.Boolean success)
  System.Void OnExit()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.NestedDTState
TYPE:  class
TOKEN: 0x200037B
EXTENDS: FSMStateNested`1
FIELDS:
  private           NodeCanvas.Framework.BBParameter<NodeCanvas.DialogueTrees.DialogueTree>_nestedDLG  // 0xB8
  public            System.String                   successEvent  // 0xC0
  public            System.String                   failureEvent  // 0xC8
METHODS:
  NodeCanvas.DialogueTrees.DialogueTree get_subGraph()
  System.Void set_subGraph(NodeCanvas.DialogueTrees.DialogueTree value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  System.Void OnEnter()
  System.Void OnUpdate()
  System.Void OnExit()
  System.Void OnDialogueFinished(System.Boolean success)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.NestedFSMState
TYPE:  class
TOKEN: 0x200037C
EXTENDS: FSMStateNested`1
FIELDS:
  private           NodeCanvas.Framework.BBParameter<NodeCanvas.StateMachines.FSM>_nestedFSM  // 0xB8
  public            NodeCanvas.StateMachines.NestedFSMState.FSMExitModeexitMode  // 0xC0
METHODS:
  NodeCanvas.StateMachines.FSM get_subGraph()
  System.Void set_subGraph(NodeCanvas.StateMachines.FSM value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  System.Void OnEnter()
  System.Void OnUpdate()
  System.Void OnExit()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.OnFSMEnter
TYPE:  class
TOKEN: 0x200037E
EXTENDS: FSMNode
FIELDS:
  private           NodeCanvas.Framework.ConditionList_conditionList  // 0x98
  private           NodeCanvas.Framework.ActionList _actionList  // 0xA0
METHODS:
  System.String get_name()
  System.Int32 get_maxInConnections()
  System.Int32 get_maxOutConnections()
  System.Boolean get_allowAsPrime()
  System.Void OnValidate(NodeCanvas.Framework.Graph assignedGraph)
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void NodeCanvas.Framework.IUpdatable.Update()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.OnFSMExit
TYPE:  class
TOKEN: 0x200037F
EXTENDS: FSMNode
FIELDS:
  private           NodeCanvas.Framework.ConditionList_conditionList  // 0x98
  private           NodeCanvas.Framework.ActionList _actionList  // 0xA0
METHODS:
  System.String get_name()
  System.Int32 get_maxInConnections()
  System.Int32 get_maxOutConnections()
  System.Boolean get_allowAsPrime()
  System.Void OnValidate(NodeCanvas.Framework.Graph assignedGraph)
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.OnFSMUpdate
TYPE:  class
TOKEN: 0x2000380
EXTENDS: FSMNode
FIELDS:
  private           NodeCanvas.Framework.ConditionList_conditionList  // 0x98
  private           NodeCanvas.Framework.ActionList _actionList  // 0xA0
METHODS:
  System.String get_name()
  System.Int32 get_maxInConnections()
  System.Int32 get_maxOutConnections()
  System.Boolean get_allowAsPrime()
  System.Void OnValidate(NodeCanvas.Framework.Graph assignedGraph)
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void NodeCanvas.Framework.IUpdatable.Update()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.SuperActionState
TYPE:  class
TOKEN: 0x2000381
EXTENDS: FSMState
FIELDS:
  private           NodeCanvas.Framework.ActionList _onEnterList  // 0xA0
  private           NodeCanvas.Framework.ActionList _onUpdateList  // 0xA8
  private           NodeCanvas.Framework.ActionList _onExitList  // 0xB0
  private           System.Boolean                  enterListFinished  // 0xB8
METHODS:
  System.Void OnValidate(NodeCanvas.Framework.Graph assignedGraph)
  System.Void OnEnter()
  System.Void OnUpdate()
  System.Void OnExit()
  System.Void OnPause()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.ConcurrentState
TYPE:  class
TOKEN: 0x2000382
EXTENDS: FSMNode
FIELDS:
  private           NodeCanvas.Framework.ConditionList_conditionList  // 0x98
  private           NodeCanvas.Framework.ActionList _actionList  // 0xA0
  private           System.Boolean                  _repeatStateActions  // 0xA8
  private           System.Boolean                  done  // 0xA9
METHODS:
  NodeCanvas.Framework.ConditionList get_conditionList()
  System.Void set_conditionList(NodeCanvas.Framework.ConditionList value)
  NodeCanvas.Framework.ActionList get_actionList()
  System.Void set_actionList(NodeCanvas.Framework.ActionList value)
  System.Boolean get_repeatStateActions()
  System.Void set_repeatStateActions(System.Boolean value)
  System.String get_name()
  System.Int32 get_maxInConnections()
  System.Int32 get_maxOutConnections()
  System.Boolean get_allowAsPrime()
  System.Void OnValidate(NodeCanvas.Framework.Graph assignedGraph)
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void OnGraphPaused()
  System.Void NodeCanvas.Framework.IUpdatable.Update()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.EnterExitState
TYPE:  class
TOKEN: 0x2000383
EXTENDS: FSMNode
FIELDS:
  private           NodeCanvas.Framework.ActionList _actionListEnter  // 0x98
  private           NodeCanvas.Framework.ActionList _actionListExit  // 0xA0
METHODS:
  NodeCanvas.Framework.ActionList get_actionListEnter()
  System.Void set_actionListEnter(NodeCanvas.Framework.ActionList value)
  NodeCanvas.Framework.ActionList get_actionListExit()
  System.Void set_actionListExit(NodeCanvas.Framework.ActionList value)
  System.String get_name()
  System.Int32 get_maxInConnections()
  System.Int32 get_maxOutConnections()
  System.Boolean get_allowAsPrime()
  System.Void OnValidate(NodeCanvas.Framework.Graph assignedGraph)
  System.Void OnGraphStarted()
  System.Void OnGraphStoped()
  System.Void NodeCanvas.Framework.IUpdatable.Update()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.StateMachines.ConcurrentSubFlowScript
TYPE:  class
TOKEN: 0x2000384
EXTENDS: FSMNodeNested`1
FIELDS:
  protected         NodeCanvas.Framework.BBParameter<FlowCanvas.FlowScript>_subFlowScript  // 0xB0
METHODS:
  System.String get_name()
  System.Int32 get_maxInConnections()
  System.Int32 get_maxOutConnections()
  System.Boolean get_allowAsPrime()
  FlowCanvas.FlowScript get_subGraph()
  System.Void set_subGraph(FlowCanvas.FlowScript value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  System.Void OnGraphStarted()
  System.Void NodeCanvas.Framework.IUpdatable.Update()
  System.Void .ctor()
  System.Void <OnGraphStarted>b__14_0(System.Boolean result)
END_CLASS

CLASS: NodeCanvas.StateMachines.FlowScriptState
TYPE:  class
TOKEN: 0x2000385
EXTENDS: FSMStateNested`1
FIELDS:
  private           NodeCanvas.Framework.BBParameter<FlowCanvas.FlowScript>_flowScript  // 0xB8
  public            System.String                   successEvent  // 0xC0
  public            System.String                   failureEvent  // 0xC8
METHODS:
  FlowCanvas.FlowScript get_subGraph()
  System.Void set_subGraph(FlowCanvas.FlowScript value)
  NodeCanvas.Framework.BBParameter get_subGraphParameter()
  System.Void OnEnter()
  System.Void OnUpdate()
  System.Void OnFlowScriptFinished(System.Boolean success)
  System.Void OnExit()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.PlayAnimationAdvanced
TYPE:  class
TOKEN: 0x20002D6
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.AnimationClip>animationClip  // 0x68
  public            UnityEngine.WrapMode            animationWrap  // 0x70
  public            UnityEngine.AnimationBlendMode  blendMode  // 0x74
  public            System.Single                   playbackSpeed  // 0x78
  public            System.Single                   crossFadeTime  // 0x7C
  public            ParadoxNotion.PlayDirections    playDirection  // 0x80
  public            NodeCanvas.Framework.BBParameter<System.String>mixTransformName  // 0x88
  public            NodeCanvas.Framework.BBParameter<System.Int32>animationLayer  // 0x90
  public            System.Boolean                  queueAnimation  // 0x98
  public            System.Boolean                  waitActionFinish  // 0x99
  private           System.String                   animationToPlay  // 0xA0
  private           System.Int32                    dir  // 0xA8
  private           UnityEngine.Transform           mixTransform  // 0xB0
METHODS:
  System.String get_info()
  System.String OnInit()
  System.Void OnExecute()
  System.Void OnUpdate()
  UnityEngine.Transform FindTransform(UnityEngine.Transform parent, System.String name)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.PlayAnimationSimple
TYPE:  class
TOKEN: 0x20002D7
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.AnimationClip>animationClip  // 0x68
  public            System.Single                   crossFadeTime  // 0x70
  public            UnityEngine.WrapMode            animationWrap  // 0x74
  public            System.Boolean                  waitActionFinish  // 0x78
  private   static  System.Collections.Generic.Dictionary<UnityEngine.Animation,UnityEngine.AnimationClip>lastPlayedClips  // 0x0
METHODS:
  System.String get_info()
  System.String OnInit()
  System.Void OnExecute()
  System.Void OnUpdate()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.MecanimPlayAnimation
TYPE:  class
TOKEN: 0x20002D8
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Int32>layerIndex  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.String>stateName  // 0x70
  public            System.Single                   transitTime  // 0x78
  public            System.Boolean                  waitUntilFinish  // 0x7C
  private           UnityEngine.AnimatorStateInfo   stateInfo  // 0x80
  private           System.Boolean                  played  // 0xB4
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.MecanimSetBool
TYPE:  class
TOKEN: 0x20002D9
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>parameter  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Int32>parameterHashID  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Boolean>setTo  // 0x78
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.MecanimSetFloat
TYPE:  class
TOKEN: 0x20002DA
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>parameter  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Int32>parameterHashID  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>setTo  // 0x78
  public            System.Single                   transitTime  // 0x80
  private           System.Single                   currentValue  // 0x84
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void OnUpdate()
  System.Single Get()
  System.Void Set(System.Single newValue)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.MecanimSetIK
TYPE:  class
TOKEN: 0x20002DB
EXTENDS: ActionTask`1
FIELDS:
  public            UnityEngine.AvatarIKGoal        IKGoal  // 0x68
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>goal  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>weight  // 0x78
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void OnStop()
  System.Void OnAnimatorIK(ParadoxNotion.EventData<System.Int32> msg)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.MecanimSetInt
TYPE:  class
TOKEN: 0x20002DC
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>parameter  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Int32>parameterHashID  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Int32>setTo  // 0x78
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.MecanimSetLayerWeight
TYPE:  class
TOKEN: 0x20002DD
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Int32>layerIndex  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>layerWeight  // 0x70
  public            System.Single                   transitTime  // 0x78
  private           System.Single                   currentValue  // 0x7C
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.MecanimSetLookAt
TYPE:  class
TOKEN: 0x20002DE
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>targetPosition  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>targetWeight  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void OnStop()
  System.Void OnAnimatorIK(ParadoxNotion.EventData<System.Int32> msg)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.MecanimSetTrigger
TYPE:  class
TOKEN: 0x20002DF
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>parameter  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Int32>parameterHashID  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.LoadScene
TYPE:  class
TOKEN: 0x20002E0
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>sceneName  // 0x68
  public            NodeCanvas.Framework.BBParameter<UnityEngine.SceneManagement.LoadSceneMode>mode  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.PlayAudioAtPosition
TYPE:  class
TOKEN: 0x20002E1
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.AudioClip>audioClip  // 0x68
  public            System.Single                   volume  // 0x70
  public            System.Boolean                  waitActionFinish  // 0x74
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.ComposeVector
TYPE:  class
TOKEN: 0x20002E2
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Single>x  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>y  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>z  // 0x78
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>saveAs  // 0x80
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.DecomposeVector
TYPE:  class
TOKEN: 0x20002E3
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>targetVector  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>x  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>y  // 0x78
  public            NodeCanvas.Framework.BBParameter<System.Single>z  // 0x80
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.AddElementToDictionary`1
TYPE:  class
TOKEN: 0x20002E4
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.Dictionary<System.String,T>>dictionary  // 0x0
  public            NodeCanvas.Framework.BBParameter<System.String>key  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>value  // 0x0
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetDictionaryElement`1
TYPE:  class
TOKEN: 0x20002E5
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.Dictionary<System.String,T>>dictionary  // 0x0
  public            NodeCanvas.Framework.BBParameter<System.String>key  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>saveAs  // 0x0
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.EvaluateCurve
TYPE:  class
TOKEN: 0x20002E6
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.AnimationCurve>curve  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>from  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>to  // 0x78
  public            NodeCanvas.Framework.BBParameter<System.Single>time  // 0x80
  public            NodeCanvas.Framework.BBParameter<System.Single>saveAs  // 0x88
METHODS:
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetSelf
TYPE:  class
TOKEN: 0x20002E7
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveAs  // 0x68
METHODS:
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetOtherBlackboardVariable
TYPE:  class
TOKEN: 0x20002E8
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>targetVariableName  // 0x68
  public            NodeCanvas.Framework.Internal.BBObjectParametersaveAs  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetToString
TYPE:  class
TOKEN: 0x20002E9
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Object>variable  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.String>toString  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.AddElementToList`1
TYPE:  class
TOKEN: 0x20002EA
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>>targetList  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>targetElement  // 0x0
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.ClearList
TYPE:  class
TOKEN: 0x20002EB
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.IList>targetList  // 0x68
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetCloserGameObjectInList
TYPE:  class
TOKEN: 0x20002EC
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>list  // 0x68
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveAs  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetIndexOfElement`1
TYPE:  class
TOKEN: 0x20002ED
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>>targetList  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>targetElement  // 0x0
  public            NodeCanvas.Framework.BBParameter<System.Int32>saveIndexAs  // 0x0
METHODS:
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetListCount
TYPE:  class
TOKEN: 0x20002EE
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.IList>targetList  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Int32>saveAs  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.InsertElementToList`1
TYPE:  class
TOKEN: 0x20002EF
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>>targetList  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>targetElement  // 0x0
  public            NodeCanvas.Framework.BBParameter<System.Int32>targetIndex  // 0x0
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.PickListElement`1
TYPE:  class
TOKEN: 0x20002F0
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>>targetList  // 0x0
  public            NodeCanvas.Framework.BBParameter<System.Int32>index  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>saveAs  // 0x0
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.PickRandomListElement`1
TYPE:  class
TOKEN: 0x20002F1
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>>targetList  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>saveAs  // 0x0
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.RemoveElementFromList`1
TYPE:  class
TOKEN: 0x20002F2
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>>targetList  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>targetElement  // 0x0
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetListElement`1
TYPE:  class
TOKEN: 0x20002F3
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>>targetList  // 0x0
  public            NodeCanvas.Framework.BBParameter<System.Int32>index  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>newValue  // 0x0
METHODS:
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.ShuffleList
TYPE:  class
TOKEN: 0x20002F4
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.IList>targetList  // 0x68
METHODS:
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SortGameObjectListByDistance
TYPE:  class
TOKEN: 0x20002F5
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>targetList  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>saveAs  // 0x70
  public            System.Boolean                  reverse  // 0x78
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
  System.Single <OnExecute>b__5_0(UnityEngine.GameObject go)
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.LoadBlackboard
TYPE:  class
TOKEN: 0x20002F6
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>saveKey  // 0x68
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.NormalizeVector
TYPE:  class
TOKEN: 0x20002F7
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>targetVector  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>multiply  // 0x70
METHODS:
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SampleCurve
TYPE:  class
TOKEN: 0x20002F8
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.AnimationCurve>curve  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>sampleAt  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>saveAs  // 0x78
METHODS:
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SaveBlackboard
TYPE:  class
TOKEN: 0x20002F9
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>saveKey  // 0x68
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetBoolean
TYPE:  class
TOKEN: 0x20002FA
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Boolean>boolVariable  // 0x68
  public            NodeCanvas.Tasks.Actions.SetBoolean.BoolSetModessetTo  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetBooleanRandom
TYPE:  class
TOKEN: 0x20002FC
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Boolean>boolVariable  // 0x68
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetEnum
TYPE:  class
TOKEN: 0x20002FD
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.Internal.BBObjectParametervalueA  // 0x68
  public            NodeCanvas.Framework.Internal.BBObjectParametervalueB  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetFloat
TYPE:  class
TOKEN: 0x20002FE
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Single>valueA  // 0x68
  public            ParadoxNotion.OperationMethod   Operation  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>valueB  // 0x78
  public            System.Boolean                  perSecond  // 0x80
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetFloatRandom
TYPE:  class
TOKEN: 0x20002FF
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Single>minValue  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>maxValue  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>floatVariable  // 0x78
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetInt
TYPE:  class
TOKEN: 0x2000300
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Int32>valueA  // 0x68
  public            ParadoxNotion.OperationMethod   Operation  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Int32>valueB  // 0x78
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetIntRandom
TYPE:  class
TOKEN: 0x2000301
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Int32>minValue  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Int32>maxValue  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Int32>intVariable  // 0x78
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetOtherBlackboardVariable
TYPE:  class
TOKEN: 0x2000302
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>targetVariableName  // 0x68
  public            NodeCanvas.Framework.Internal.BBObjectParameternewValue  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetVariable`1
TYPE:  class
TOKEN: 0x2000303
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<T>valueA  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>valueB  // 0x0
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetVector3
TYPE:  class
TOKEN: 0x2000304
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>valueA  // 0x68
  public            ParadoxNotion.OperationMethod   operation  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>valueB  // 0x78
  public            System.Boolean                  perSecond  // 0x80
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.TriggerBoolean
TYPE:  class
TOKEN: 0x2000305
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Boolean>variable  // 0x68
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Collections.IEnumerator Flip()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.FadeIn
TYPE:  class
TOKEN: 0x2000307
EXTENDS: ActionTask
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.FadeOut
TYPE:  class
TOKEN: 0x2000308
EXTENDS: ActionTask
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.Say
TYPE:  class
TOKEN: 0x2000309
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.DialogueTrees.Statementstatement  // 0x68
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SayRandom
TYPE:  class
TOKEN: 0x200030A
EXTENDS: ActionTask`1
FIELDS:
  public            System.Collections.Generic.List<NodeCanvas.DialogueTrees.Statement>statements  // 0x68
METHODS:
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.StartDialogueTree
TYPE:  class
TOKEN: 0x200030B
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<NodeCanvas.DialogueTrees.DialogueTreeController>dialogueTreeController  // 0x68
  public            System.Boolean                  waitActionFinish  // 0x70
  public            System.Boolean                  isPrefab  // 0x71
  private           NodeCanvas.DialogueTrees.DialogueTreeControllerinstance  // 0x78
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
  System.Void <OnExecute>b__6_0(System.Boolean success)
  System.Void <OnExecute>b__6_1(System.Boolean success)
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.CreateGameObject
TYPE:  class
TOKEN: 0x200030C
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>objectName  // 0x68
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>position  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>rotation  // 0x78
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveAs  // 0x80
METHODS:
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.CreatePrimitive
TYPE:  class
TOKEN: 0x200030D
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>objectName  // 0x68
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>position  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>rotation  // 0x78
  public            NodeCanvas.Framework.BBParameter<UnityEngine.PrimitiveType>type  // 0x80
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveAs  // 0x88
METHODS:
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.DestroyGameObject
TYPE:  class
TOKEN: 0x200030E
EXTENDS: ActionTask`1
FIELDS:
  public            System.Boolean                  immediately  // 0x68
METHODS:
  System.String get_info()
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.FindAllWithLayer
TYPE:  class
TOKEN: 0x200030F
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask>targetLayers  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>saveAs  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.FindAllWithName
TYPE:  class
TOKEN: 0x2000310
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>searchName  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>saveAs  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.FindAllWithTag
TYPE:  class
TOKEN: 0x2000311
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>searchTag  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>saveAs  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.FindChildByName
TYPE:  class
TOKEN: 0x2000312
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>childName  // 0x68
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Transform>saveAs  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.FindClosestWithTag
TYPE:  class
TOKEN: 0x2000313
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>searchTag  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Boolean>ignoreChildren  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveObjectAs  // 0x78
  public            NodeCanvas.Framework.BBParameter<System.Single>saveDistanceAs  // 0x80
METHODS:
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.FindObjectOfType`1
TYPE:  class
TOKEN: 0x2000314
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<T>saveComponentAs  // 0x0
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveGameObjectAs  // 0x0
METHODS:
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.FindObjectsOfType`1
TYPE:  class
TOKEN: 0x2000315
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>saveGameObjects  // 0x0
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>>saveComponents  // 0x0
METHODS:
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.FindWithName
TYPE:  class
TOKEN: 0x2000317
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>gameObjectName  // 0x68
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveAs  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.FindWithTag
TYPE:  class
TOKEN: 0x2000318
EXTENDS: ActionTask
FIELDS:
  public            System.String                   searchTag  // 0x68
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveAs  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetAllChildGameObjects
TYPE:  class
TOKEN: 0x2000319
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>saveAs  // 0x68
  public            System.Boolean                  recursive  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Collections.Generic.List<UnityEngine.Transform> Get(UnityEngine.Transform parent)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetComponent`1
TYPE:  class
TOKEN: 0x200031B
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<T>saveAs  // 0x0
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetDistance
TYPE:  class
TOKEN: 0x200031C
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>target  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>saveAs  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetGameObjectPosition
TYPE:  class
TOKEN: 0x200031D
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>saveAs  // 0x68
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.InstantiateGameObject
TYPE:  class
TOKEN: 0x200031E
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Transform>parent  // 0x68
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>clonePosition  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>cloneRotation  // 0x78
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveCloneAs  // 0x80
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.LookAt
TYPE:  class
TOKEN: 0x200031F
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>lookTarget  // 0x68
  public            System.Boolean                  repeat  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void OnUpdate()
  System.Void DoLook()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.RemoveComponent`1
TYPE:  class
TOKEN: 0x2000320
EXTENDS: ActionTask`1
FIELDS:
  public            System.Boolean                  immediately  // 0x0
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetObjectActive
TYPE:  class
TOKEN: 0x2000321
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Tasks.Actions.SetObjectActive.SetActiveModesetTo  // 0x68
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetObjectEnabled
TYPE:  class
TOKEN: 0x2000323
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Tasks.Actions.SetObjectEnabled.SetEnableModesetTo  // 0x68
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetObjectVisibility
TYPE:  class
TOKEN: 0x2000325
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Tasks.Actions.SetObjectVisibility.SetVisibleModesetTo  // 0x68
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetInputAxis
TYPE:  class
TOKEN: 0x2000327
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>xAxisName  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.String>yAxisName  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.String>zAxisName  // 0x78
  public            NodeCanvas.Framework.BBParameter<System.Single>multiplier  // 0x80
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>saveAs  // 0x88
  public            NodeCanvas.Framework.BBParameter<System.Single>saveXAs  // 0x90
  public            NodeCanvas.Framework.BBParameter<System.Single>saveYAs  // 0x98
  public            NodeCanvas.Framework.BBParameter<System.Single>saveZAs  // 0xA0
  public            System.Boolean                  repeat  // 0xA8
METHODS:
  System.Void OnExecute()
  System.Void OnUpdate()
  System.Void Do()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetMousePosition
TYPE:  class
TOKEN: 0x2000328
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>saveAs  // 0x68
  public            System.Boolean                  repeat  // 0x70
METHODS:
  System.Void OnExecute()
  System.Void OnUpdate()
  System.Void Do()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetMouseScrollDelta
TYPE:  class
TOKEN: 0x2000329
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Single>saveAs  // 0x68
  public            System.Boolean                  repeat  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void OnUpdate()
  System.Void Do()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.WaitMousePick
TYPE:  class
TOKEN: 0x200032A
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Tasks.Actions.WaitMousePick.ButtonKeysbuttonKey  // 0x68
  public            UnityEngine.LayerMask           mask  // 0x6C
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveObjectAs  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>saveDistanceAs  // 0x78
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>savePositionAs  // 0x80
  private           System.Int32                    buttonID  // 0x88
  private           UnityEngine.RaycastHit          hit  // 0x90
METHODS:
  System.String get_info()
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.WaitMousePick2D
TYPE:  class
TOKEN: 0x200032C
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Tasks.Actions.WaitMousePick2D.ButtonKeysbuttonKey  // 0x68
  public            UnityEngine.LayerMask           mask  // 0x6C
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveObjectAs  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>saveDistanceAs  // 0x78
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>savePositionAs  // 0x80
  private           System.Int32                    buttonID  // 0x88
  private           UnityEngine.RaycastHit2D        hit  // 0x8C
METHODS:
  System.String get_info()
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.CurveTransformTween
TYPE:  class
TOKEN: 0x200032E
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Tasks.Actions.CurveTransformTween.TransformModetransformMode  // 0x68
  public            NodeCanvas.Tasks.Actions.CurveTransformTween.TweenModemode  // 0x6C
  public            NodeCanvas.Tasks.Actions.CurveTransformTween.PlayModeplayMode  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>targetPosition  // 0x78
  public            NodeCanvas.Framework.BBParameter<UnityEngine.AnimationCurve>curve  // 0x80
  public            NodeCanvas.Framework.BBParameter<System.Single>time  // 0x88
  private           UnityEngine.Vector3             original  // 0x90
  private           UnityEngine.Vector3             final  // 0x9C
  private           System.Boolean                  ponging  // 0xA8
METHODS:
  System.Void OnExecute()
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.InputMove
TYPE:  class
TOKEN: 0x2000332
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Single>strafe  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>turn  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>forward  // 0x78
  public            NodeCanvas.Framework.BBParameter<System.Single>up  // 0x80
  public            NodeCanvas.Framework.BBParameter<System.Single>moveSpeed  // 0x88
  public            NodeCanvas.Framework.BBParameter<System.Single>rotationSpeed  // 0x90
  public            System.Boolean                  repeat  // 0x98
METHODS:
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.MoveAway
TYPE:  class
TOKEN: 0x2000333
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>target  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>speed  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>stopDistance  // 0x78
  public            System.Boolean                  waitActionFinish  // 0x80
METHODS:
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.MoveTowards
TYPE:  class
TOKEN: 0x2000334
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>target  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>speed  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>stopDistance  // 0x78
  public            System.Boolean                  waitActionFinish  // 0x80
METHODS:
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.RotateAway
TYPE:  class
TOKEN: 0x2000335
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>target  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>speed  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>angleDifference  // 0x78
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>upVector  // 0x80
  public            System.Boolean                  waitActionFinish  // 0x88
METHODS:
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.RotateTowards
TYPE:  class
TOKEN: 0x2000336
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>target  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>speed  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>angleDifference  // 0x78
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>upVector  // 0x80
  public            System.Boolean                  waitActionFinish  // 0x88
METHODS:
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.FindClosestEdge
TYPE:  class
TOKEN: 0x2000337
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>targetPosition  // 0x68
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>saveFoundPosition  // 0x70
  private           UnityEngine.AI.NavMeshHit       hit  // 0x78
METHODS:
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetLinecastInfo
TYPE:  class
TOKEN: 0x2000338
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>target  // 0x68
  public            NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask>layerMask  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveHitGameObjectAs  // 0x78
  public            NodeCanvas.Framework.BBParameter<System.Single>saveDistanceAs  // 0x80
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>savePointAs  // 0x88
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>saveNormalAs  // 0x90
  private           UnityEngine.RaycastHit          hit  // 0x98
METHODS:
  System.Void OnExecute()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetLinecastInfo2D
TYPE:  class
TOKEN: 0x2000339
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>target  // 0x68
  public            UnityEngine.LayerMask           mask  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveHitGameObjectAs  // 0x78
  public            NodeCanvas.Framework.BBParameter<System.Single>saveDistanceAs  // 0x80
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>savePointAs  // 0x88
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>saveNormalAs  // 0x90
  private           UnityEngine.RaycastHit2D        hit  // 0x98
METHODS:
  System.Void OnExecute()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetLinecastInfo2DAll
TYPE:  class
TOKEN: 0x200033A
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>target  // 0x68
  public            UnityEngine.LayerMask           mask  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>saveHitGameObjectsAs  // 0x78
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<System.Single>>saveDistancesAs  // 0x80
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.Vector3>>savePointsAs  // 0x88
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.Vector3>>saveNormalsAs  // 0x90
  private           UnityEngine.RaycastHit2D[]      hits  // 0x98
METHODS:
  System.Void OnExecute()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
  UnityEngine.Vector3 <OnExecute>b__7_2(UnityEngine.RaycastHit2D h)
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetOverlapSphereObjects
TYPE:  class
TOKEN: 0x200033C
EXTENDS: ActionTask`1
FIELDS:
  public            UnityEngine.LayerMask           layerMask  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>radius  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>saveObjectsAs  // 0x78
METHODS:
  System.Void OnExecute()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.ExecuteFunction_Multiplatform
TYPE:  class
TOKEN: 0x200033E
EXTENDS: ActionTask
FIELDS:
  protected         ParadoxNotion.Serialization.SerializedMethodInfomethod  // 0x68
  protected         System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBObjectParameter>parameters  // 0x70
  protected         NodeCanvas.Framework.Internal.BBObjectParameterreturnValue  // 0x78
  private           System.Object[]                 args  // 0x80
  private           System.Boolean                  routineRunning  // 0x88
  private           System.Boolean[]                parameterIsByRef  // 0x90
METHODS:
  System.Reflection.MethodInfo get_targetMethod()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.String OnInit()
  System.Void OnExecute()
  System.Void OnStop()
  System.Collections.IEnumerator InternalCoroutine(System.Collections.IEnumerator routine)
  System.Void SetMethod(System.Reflection.MethodInfo method)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetField_0
TYPE:  class
TOKEN: 0x2000340
FIELDS:
  public            System.Type                     targetType  // 0x10
  public            System.String                   fieldName  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetField
TYPE:  class
TOKEN: 0x2000341
EXTENDS: ActionTask
FIELDS:
  protected         ParadoxNotion.Serialization.SerializedFieldInfofield  // 0x68
  protected         NodeCanvas.Framework.Internal.BBObjectParametersaveAs  // 0x70
METHODS:
  System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Actions.GetField_0>.Migrate(NodeCanvas.Tasks.Actions.GetField_0 model)
  System.Reflection.FieldInfo get_targetField()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.String OnInit()
  System.Void OnExecute()
  System.Void SetTargetField(System.Reflection.FieldInfo newField)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetProperty_Multiplatform
TYPE:  class
TOKEN: 0x2000342
EXTENDS: ActionTask
FIELDS:
  protected         ParadoxNotion.Serialization.SerializedMethodInfomethod  // 0x68
  protected         NodeCanvas.Framework.Internal.BBObjectParameterreturnValue  // 0x70
METHODS:
  System.Reflection.MethodInfo get_targetMethod()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.String OnInit()
  System.Void OnExecute()
  System.Void SetMethod(System.Reflection.MethodInfo method)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.ImplementedAction_Multiplatform
TYPE:  class
TOKEN: 0x2000343
EXTENDS: ActionTask
FIELDS:
  private           ParadoxNotion.Serialization.SerializedMethodInfomethod  // 0x68
  private           System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBObjectParameter>parameters  // 0x70
  private           NodeCanvas.Framework.Status     actionStatus  // 0x78
  private           System.Object[]                 args  // 0x80
METHODS:
  System.Reflection.MethodInfo get_targetMethod()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.String OnInit()
  System.Void OnUpdate()
  System.Void OnStop()
  System.Void SetMethod(System.Reflection.MethodInfo method)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SendMessage
TYPE:  class
TOKEN: 0x2000344
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>methodName  // 0x68
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SendMessage`1
TYPE:  class
TOKEN: 0x2000345
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>methodName  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>argument  // 0x0
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SendMessageToType`1
TYPE:  class
TOKEN: 0x2000346
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>message  // 0x0
  public            NodeCanvas.Framework.BBParameter<System.Object>argument  // 0x0
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetField_0
TYPE:  class
TOKEN: 0x2000347
FIELDS:
  public            System.Type                     targetType  // 0x10
  public            System.String                   fieldName  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetField
TYPE:  class
TOKEN: 0x2000348
EXTENDS: ActionTask
FIELDS:
  protected         ParadoxNotion.Serialization.SerializedFieldInfofield  // 0x68
  protected         NodeCanvas.Framework.Internal.BBObjectParametersetValue  // 0x70
METHODS:
  System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Actions.SetField_0>.Migrate(NodeCanvas.Tasks.Actions.SetField_0 model)
  System.Reflection.FieldInfo get_targetField()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.String OnInit()
  System.Void OnExecute()
  System.Void SetTargetField(System.Reflection.FieldInfo newField)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetProperty_Multiplatform
TYPE:  class
TOKEN: 0x2000349
EXTENDS: ActionTask
FIELDS:
  protected         ParadoxNotion.Serialization.SerializedMethodInfomethod  // 0x68
  protected         NodeCanvas.Framework.Internal.BBObjectParameterparameter  // 0x70
METHODS:
  System.Reflection.MethodInfo get_targetMethod()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.String OnInit()
  System.Void OnExecute()
  System.Void SetMethod(System.Reflection.MethodInfo method)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.ExecuteFunction
TYPE:  class
TOKEN: 0x200034A
EXTENDS: ActionTask
FIELDS:
  protected         NodeCanvas.Framework.Internal.ReflectedWrapperfunctionWrapper  // 0x68
  private           System.Boolean                  routineRunning  // 0x70
METHODS:
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Reflection.MethodInfo get_targetMethod()
  System.Type get_agentType()
  System.String get_info()
  System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.String OnInit()
  System.Void OnExecute()
  System.Void OnStop()
  System.Collections.IEnumerator InternalCoroutine(System.Collections.IEnumerator routine)
  System.Void SetMethod(System.Reflection.MethodInfo method)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GetProperty
TYPE:  class
TOKEN: 0x200034C
EXTENDS: ActionTask
FIELDS:
  protected         NodeCanvas.Framework.Internal.ReflectedFunctionWrapperfunctionWrapper  // 0x68
METHODS:
  System.Reflection.MethodInfo get_targetMethod()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.String OnInit()
  System.Void OnExecute()
  System.Void SetMethod(System.Reflection.MethodInfo method)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.ImplementedAction
TYPE:  class
TOKEN: 0x200034D
EXTENDS: ActionTask
FIELDS:
  protected         NodeCanvas.Framework.Internal.ReflectedFunctionWrapperfunctionWrapper  // 0x68
  private           NodeCanvas.Framework.Status     actionStatus  // 0x70
METHODS:
  System.Reflection.MethodInfo get_targetMethod()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.String OnInit()
  System.Void OnUpdate()
  System.Void OnStop()
  System.Void SetMethod(System.Reflection.MethodInfo method)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SetProperty
TYPE:  class
TOKEN: 0x200034E
EXTENDS: ActionTask
FIELDS:
  protected         NodeCanvas.Framework.Internal.ReflectedActionWrapperfunctionWrapper  // 0x68
METHODS:
  System.Reflection.MethodInfo get_targetMethod()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.String OnInit()
  System.Void OnExecute()
  System.Void SetMethod(System.Reflection.MethodInfo method)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.DebugBeep
TYPE:  class
TOKEN: 0x200034F
EXTENDS: ActionTask
FIELDS:
METHODS:
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.DebugDrawLine
TYPE:  class
TOKEN: 0x2000350
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>from  // 0x68
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>to  // 0x70
  public            UnityEngine.Color               color  // 0x78
  public            System.Single                   timeToShow  // 0x88
METHODS:
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.DebugLogText
TYPE:  class
TOKEN: 0x2000351
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>log  // 0x68
  public            System.Single                   labelYOffset  // 0x70
  public            System.Single                   secondsToRun  // 0x74
  public            NodeCanvas.Tasks.Actions.DebugLogText.VerboseModeverboseMode  // 0x78
  public            NodeCanvas.Tasks.Actions.DebugLogText.LogModelogMode  // 0x7C
  public            ParadoxNotion.CompactStatus     finishStatus  // 0x80
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void OnStop()
  System.Void OnUpdate()
  System.Void OnGUI()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.DebugLogVariable
TYPE:  class
TOKEN: 0x2000354
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Object>log  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.String>prefix  // 0x70
  public            System.Single                   secondsToRun  // 0x78
  public            ParadoxNotion.CompactStatus     finishStatus  // 0x7C
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.ForceFinishGraph
TYPE:  class
TOKEN: 0x2000355
EXTENDS: ActionTask
FIELDS:
  public            ParadoxNotion.CompactStatus     finishStatus  // 0x68
METHODS:
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.GraphOwnerControl
TYPE:  class
TOKEN: 0x2000356
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Tasks.Actions.GraphOwnerControl.Controlcontrol  // 0x68
  public            System.Boolean                  waitActionFinish  // 0x6C
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Collections.IEnumerator YieldDo()
  System.Void Do()
  System.Void OnStop()
  System.Void .ctor()
  System.Void <OnExecute>b__5_0(System.Boolean s)
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.RunForever
TYPE:  class
TOKEN: 0x2000359
EXTENDS: ActionTask
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SendEvent
TYPE:  class
TOKEN: 0x200035A
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>eventName  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>delay  // 0x70
  public            System.Boolean                  sendGlobal  // 0x78
METHODS:
  System.String get_info()
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SendEvent`1
TYPE:  class
TOKEN: 0x200035B
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>eventName  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>eventValue  // 0x0
  public            NodeCanvas.Framework.BBParameter<System.Single>delay  // 0x0
  public            System.Boolean                  sendGlobal  // 0x0
METHODS:
  System.String get_info()
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SendEventToObjects
TYPE:  class
TOKEN: 0x200035C
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>targetObjects  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.String>eventName  // 0x70
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SendEventToObjects`1
TYPE:  class
TOKEN: 0x200035D
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>targetObjects  // 0x0
  public            NodeCanvas.Framework.BBParameter<System.String>eventName  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>eventValue  // 0x0
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.ShoutEvent
TYPE:  class
TOKEN: 0x200035E
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>eventName  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>shoutRange  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>completionTime  // 0x78
  private           NodeCanvas.Framework.GraphOwner[]owners  // 0x80
  private           System.Boolean[]                receivedOwners  // 0x88
  private           System.Single                   traveledDistance  // 0x90
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void OnUpdate()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SwitchBehaviourTree
TYPE:  class
TOKEN: 0x200035F
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<NodeCanvas.BehaviourTrees.BehaviourTree>behaviourTree  // 0x68
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.SwitchFSM
TYPE:  class
TOKEN: 0x2000360
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<NodeCanvas.StateMachines.FSM>fsm  // 0x68
METHODS:
  System.String get_info()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.Wait
TYPE:  class
TOKEN: 0x2000361
EXTENDS: ActionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Single>waitTime  // 0x68
  public            ParadoxNotion.CompactStatus     finishStatus  // 0x70
METHODS:
  System.String get_info()
  System.Void OnUpdate()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.CheckSpeed
TYPE:  class
TOKEN: 0x2000362
EXTENDS: ConditionTask`1
FIELDS:
  public            ParadoxNotion.CompareMethod     checkType  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>value  // 0x70
  public            System.Single                   differenceThreshold  // 0x78
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.ExecuteStaticFunction
TYPE:  class
TOKEN: 0x2000363
EXTENDS: ActionTask
FIELDS:
  protected         NodeCanvas.Framework.Internal.ReflectedWrapperfunctionWrapper  // 0x68
METHODS:
  NodeCanvas.Framework.BBParameter[] NodeCanvas.Framework.ISubParametersContainer.GetSubParameters()
  System.Reflection.MethodInfo get_targetMethod()
  System.String get_info()
  System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.String OnInit()
  System.Void OnExecute()
  System.Void SetMethod(System.Reflection.MethodInfo method)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Actions.ExecuteStaticFunction_Multiplatform
TYPE:  class
TOKEN: 0x2000364
EXTENDS: ActionTask
FIELDS:
  protected         ParadoxNotion.Serialization.SerializedMethodInfomethod  // 0x68
  protected         System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBObjectParameter>parameters  // 0x70
  protected         NodeCanvas.Framework.Internal.BBObjectParameterreturnValue  // 0x78
METHODS:
  System.Reflection.MethodInfo get_targetMethod()
  System.String get_info()
  System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.String OnInit()
  System.Void OnExecute()
  System.Void SetMethod(System.Reflection.MethodInfo method)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.InvokeSignal
TYPE:  class
TOKEN: 0x2000284
EXTENDS: ActionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<NodeCanvas.Framework.SignalDefinition>signalDefinition  // 0x68
  public            System.Boolean                  global  // 0x70
  private           System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Internal.BBObjectParameter>argumentsMap  // 0x78
  private           System.Object[]                 args  // 0x80
METHODS:
  System.String get_info()
  System.String OnInit()
  System.Void OnExecute()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.MecanimCheckBool
TYPE:  class
TOKEN: 0x2000285
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>parameter  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Boolean>value  // 0x70
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.MecanimCheckFloat
TYPE:  class
TOKEN: 0x2000286
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>parameter  // 0x68
  public            ParadoxNotion.CompareMethod     comparison  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>value  // 0x78
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.MecanimCheckInt
TYPE:  class
TOKEN: 0x2000287
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>parameter  // 0x68
  public            ParadoxNotion.CompareMethod     comparison  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Int32>value  // 0x78
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.MecanimIsInTransition
TYPE:  class
TOKEN: 0x2000288
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Int32>layerIndex  // 0x68
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckBoolean
TYPE:  class
TOKEN: 0x2000289
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Boolean>valueA  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Boolean>valueB  // 0x70
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckBooleanTrigger
TYPE:  class
TOKEN: 0x200028A
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Boolean>trigger  // 0x68
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckEnum
TYPE:  class
TOKEN: 0x200028B
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.Internal.BBObjectParametervalueA  // 0x68
  public            NodeCanvas.Framework.Internal.BBObjectParametervalueB  // 0x70
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckFloat
TYPE:  class
TOKEN: 0x200028C
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Single>valueA  // 0x68
  public            ParadoxNotion.CompareMethod     checkType  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>valueB  // 0x78
  public            System.Single                   differenceThreshold  // 0x80
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckInt
TYPE:  class
TOKEN: 0x200028D
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Int32>valueA  // 0x68
  public            ParadoxNotion.CompareMethod     checkType  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Int32>valueB  // 0x78
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckNull
TYPE:  class
TOKEN: 0x200028E
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Object>variable  // 0x68
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckString
TYPE:  class
TOKEN: 0x200028F
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>valueA  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.String>valueB  // 0x70
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckUnityObject
TYPE:  class
TOKEN: 0x2000290
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Object>valueA  // 0x68
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Object>valueB  // 0x70
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckVariable`1
TYPE:  class
TOKEN: 0x2000291
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<T>valueA  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>valueB  // 0x0
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckVectorDistance
TYPE:  class
TOKEN: 0x2000292
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>vectorA  // 0x68
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>vectorB  // 0x70
  public            ParadoxNotion.CompareMethod     comparison  // 0x78
  public            NodeCanvas.Framework.BBParameter<System.Single>distance  // 0x80
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.TryGetValue`1
TYPE:  class
TOKEN: 0x2000293
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.Dictionary<System.String,T>>targetDictionary  // 0x0
  public            NodeCanvas.Framework.BBParameter<System.String>key  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>saveValueAs  // 0x0
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.ListContainsElement`1
TYPE:  class
TOKEN: 0x2000294
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>>targetList  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>checkElement  // 0x0
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.ListIsEmpty
TYPE:  class
TOKEN: 0x2000295
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.IList>targetList  // 0x68
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.BBVariableChanged
TYPE:  class
TOKEN: 0x2000296
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.Internal.BBObjectParametertargetVariable  // 0x68
METHODS:
  System.String get_info()
  System.String OnInit()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Boolean OnCheck()
  System.Void OnValueChanged(System.Object varValue)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.StringContains
TYPE:  class
TOKEN: 0x2000297
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>targetString  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.String>checkString  // 0x70
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CanSeeTarget
TYPE:  class
TOKEN: 0x2000298
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>target  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>maxDistance  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask>layerMask  // 0x78
  public            NodeCanvas.Framework.BBParameter<System.Single>awarnessDistance  // 0x80
  public            NodeCanvas.Framework.BBParameter<System.Single>viewAngle  // 0x88
  public            UnityEngine.Vector3             offset  // 0x90
  private           UnityEngine.RaycastHit          hit  // 0xA0
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CanSeeTarget2D
TYPE:  class
TOKEN: 0x2000299
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>target  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>maxDistance  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask>layerMask  // 0x78
  public            NodeCanvas.Framework.BBParameter<System.Single>awarnessDistance  // 0x80
  public            NodeCanvas.Framework.BBParameter<System.Single>viewAngle  // 0x88
  public            UnityEngine.Vector2             offset  // 0x90
  private           UnityEngine.RaycastHit2D        hit  // 0x98
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CanSeeTargetAny
TYPE:  class
TOKEN: 0x200029A
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>targetObjects  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>maxDistance  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask>layerMask  // 0x78
  public            NodeCanvas.Framework.BBParameter<System.Single>awarnessDistance  // 0x80
  public            NodeCanvas.Framework.BBParameter<System.Single>viewAngle  // 0x88
  public            UnityEngine.Vector3             offset  // 0x90
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>allResults  // 0xA0
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>closerResult  // 0xA8
  private           UnityEngine.RaycastHit          hit  // 0xB0
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
  System.Single <OnCheck>b__11_0(UnityEngine.GameObject x)
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CanSeeTargetAny2D
TYPE:  class
TOKEN: 0x200029B
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>targetObjects  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>maxDistance  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask>layerMask  // 0x78
  public            NodeCanvas.Framework.BBParameter<System.Single>awarnessDistance  // 0x80
  public            NodeCanvas.Framework.BBParameter<System.Single>viewAngle  // 0x88
  public            UnityEngine.Vector2             offset  // 0x90
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>allResults  // 0x98
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>closerResult  // 0xA0
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
  System.Single <OnCheck>b__10_0(UnityEngine.GameObject x)
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckDistanceToGameObject
TYPE:  class
TOKEN: 0x200029C
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>checkTarget  // 0x68
  public            ParadoxNotion.CompareMethod     checkType  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>distance  // 0x78
  public            System.Single                   floatingPoint  // 0x80
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckDistanceToGameObject2D
TYPE:  class
TOKEN: 0x200029D
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>checkTarget  // 0x68
  public            ParadoxNotion.CompareMethod     checkType  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>distance  // 0x78
  public            System.Single                   floatingPoint  // 0x80
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckDistanceToGameObjectAny
TYPE:  class
TOKEN: 0x200029E
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>targetObjects  // 0x68
  public            ParadoxNotion.CompareMethod     checkType  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>distance  // 0x78
  public            System.Single                   floatingPoint  // 0x80
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>allResults  // 0x88
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>closerResult  // 0x90
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
  System.Single <OnCheck>b__8_0(UnityEngine.GameObject x)
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckDistanceToGameObjectAny2D
TYPE:  class
TOKEN: 0x200029F
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>targetObjects  // 0x68
  public            ParadoxNotion.CompareMethod     checkType  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>distance  // 0x78
  public            System.Single                   floatingPoint  // 0x80
  public            NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>>allResults  // 0x88
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>closerResult  // 0x90
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
  System.Single <OnCheck>b__8_0(UnityEngine.GameObject x)
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckLOS
TYPE:  class
TOKEN: 0x20002A0
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>LOSTarget  // 0x68
  public            NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask>layerMask  // 0x70
  public            UnityEngine.Vector3             offset  // 0x78
  public            NodeCanvas.Framework.BBParameter<System.Single>saveDistanceAs  // 0x88
  private           UnityEngine.RaycastHit          hit  // 0x90
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckLOS2D
TYPE:  class
TOKEN: 0x20002A1
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>LOSTarget  // 0x68
  public            NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask>layerMask  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>saveDistanceAs  // 0x78
  protected         UnityEngine.Collider2D          agentCollider  // 0x80
  private           UnityEngine.RaycastHit2D[]      hits  // 0x88
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.HasComponent`1
TYPE:  class
TOKEN: 0x20002A3
EXTENDS: ConditionTask`1
FIELDS:
METHODS:
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.IsActive
TYPE:  class
TOKEN: 0x20002A4
EXTENDS: ConditionTask`1
FIELDS:
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.IsInFront
TYPE:  class
TOKEN: 0x20002A5
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>checkTarget  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>viewAngle  // 0x70
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.IsInFront2D
TYPE:  class
TOKEN: 0x20002A6
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>checkTarget  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>viewAngle  // 0x70
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnDrawGizmosSelected()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.IsWithinLayerMask
TYPE:  class
TOKEN: 0x20002A7
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask>targetLayers  // 0x68
METHODS:
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckButtonInput
TYPE:  class
TOKEN: 0x20002A8
EXTENDS: ConditionTask
FIELDS:
  public            ParadoxNotion.PressTypes        pressType  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.String>buttonName  // 0x70
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckKeyboardInput
TYPE:  class
TOKEN: 0x20002A9
EXTENDS: ConditionTask
FIELDS:
  public            ParadoxNotion.PressTypes        pressType  // 0x68
  public            UnityEngine.KeyCode             key  // 0x6C
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckMousePick
TYPE:  class
TOKEN: 0x20002AA
EXTENDS: ConditionTask
FIELDS:
  public            ParadoxNotion.ButtonKeys        buttonKey  // 0x68
  public            System.Int32                    layer  // 0x6C
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveGoAs  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>saveDistanceAs  // 0x78
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>savePosAs  // 0x80
  private           UnityEngine.RaycastHit          hit  // 0x88
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckMousePick2D
TYPE:  class
TOKEN: 0x20002AB
EXTENDS: ConditionTask
FIELDS:
  public            ParadoxNotion.ButtonKeys        buttonKey  // 0x68
  public            UnityEngine.LayerMask           mask  // 0x6C
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveGoAs  // 0x70
  public            NodeCanvas.Framework.BBParameter<System.Single>saveDistanceAs  // 0x78
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>savePosAs  // 0x80
  private           System.Int32                    buttonID  // 0x88
  private           UnityEngine.RaycastHit2D        hit  // 0x8C
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0
TYPE:  class
TOKEN: 0x20002AC
FIELDS:
  public            System.Type                     targetType  // 0x10
  public            System.String                   eventName  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0`1
TYPE:  class
TOKEN: 0x20002AD
FIELDS:
  public            System.Type                     targetType  // 0x0
  public            System.String                   eventName  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckCSharpEventValue_0`1
TYPE:  class
TOKEN: 0x20002AE
FIELDS:
  public            System.Type                     targetType  // 0x0
  public            System.String                   eventName  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent
TYPE:  class
TOKEN: 0x20002AF
FIELDS:
  public            System.Type                     targetType  // 0x10
  public            System.String                   eventName  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent`1
TYPE:  class
TOKEN: 0x20002B0
FIELDS:
  public            System.Type                     targetType  // 0x0
  public            System.String                   eventName  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckCSharpEvent
TYPE:  class
TOKEN: 0x20002B1
EXTENDS: ConditionTask
FIELDS:
  private           ParadoxNotion.Serialization.SerializedEventInfoeventInfo  // 0x68
  private           System.Delegate                 handler  // 0x70
METHODS:
  System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0>.Migrate(NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0 model)
  System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent>.Migrate(NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent model)
  System.Reflection.EventInfo get_targetEvent()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.String OnInit()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Raised()
  System.Boolean OnCheck()
  System.Void SetTargetEvent(System.Reflection.EventInfo info)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckCSharpEvent`1
TYPE:  class
TOKEN: 0x20002B2
EXTENDS: ConditionTask
FIELDS:
  private           ParadoxNotion.Serialization.SerializedEventInfoeventInfo  // 0x0
  private           NodeCanvas.Framework.BBParameter<T>saveAs  // 0x0
  private           System.Delegate                 handler  // 0x0
METHODS:
  System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0<T>>.Migrate(NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0<T> model)
  System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent<T>>.Migrate(NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent<T> model)
  System.Reflection.EventInfo get_targetEvent()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.String OnInit()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Raised(T eventValue)
  System.Boolean OnCheck()
  System.Void SetTargetEvent(System.Reflection.EventInfo info)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckCSharpEventValue`1
TYPE:  class
TOKEN: 0x20002B3
EXTENDS: ConditionTask
FIELDS:
  private           ParadoxNotion.Serialization.SerializedEventInfoeventInfo  // 0x0
  private           NodeCanvas.Framework.BBParameter<T>checkValue  // 0x0
  private           System.Delegate                 handler  // 0x0
METHODS:
  System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEventValue_0<T>>.Migrate(NodeCanvas.Tasks.Conditions.CheckCSharpEventValue_0<T> model)
  System.Reflection.EventInfo get_targetEvent()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.String OnInit()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Raised(T eventValue)
  System.Boolean OnCheck()
  System.Void SetTargetEvent(System.Reflection.EventInfo info)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckField_0
TYPE:  class
TOKEN: 0x20002B4
FIELDS:
  public            NodeCanvas.Framework.BBParametercheckValue  // 0x10
  public            System.Type                     targetType  // 0x18
  public            System.String                   fieldName  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckField
TYPE:  class
TOKEN: 0x20002B5
EXTENDS: ConditionTask
FIELDS:
  protected         NodeCanvas.Framework.Internal.BBObjectParametercheckValue  // 0x68
  protected         ParadoxNotion.CompareMethod     comparison  // 0x70
  protected         ParadoxNotion.Serialization.SerializedFieldInfofield  // 0x78
METHODS:
  System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckField_0>.Migrate(NodeCanvas.Tasks.Conditions.CheckField_0 model)
  System.Reflection.FieldInfo get_targetField()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.String OnInit()
  System.Boolean OnCheck()
  System.Void SetTargetField(System.Reflection.FieldInfo newField)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckFunction_Multiplatform
TYPE:  class
TOKEN: 0x20002B6
EXTENDS: ConditionTask
FIELDS:
  protected         ParadoxNotion.Serialization.SerializedMethodInfomethod  // 0x68
  protected         System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBObjectParameter>parameters  // 0x70
  protected         ParadoxNotion.CompareMethod     comparison  // 0x78
  protected         NodeCanvas.Framework.Internal.BBObjectParametercheckValue  // 0x80
  private           System.Object[]                 args  // 0x88
  private           System.Boolean[]                parameterIsByRef  // 0x90
METHODS:
  System.Reflection.MethodInfo get_targetMethod()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.String OnInit()
  System.Boolean OnCheck()
  System.Void SetMethod(System.Reflection.MethodInfo method)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckProperty_Multiplatform
TYPE:  class
TOKEN: 0x20002B7
EXTENDS: ConditionTask
FIELDS:
  protected         ParadoxNotion.Serialization.SerializedMethodInfomethod  // 0x68
  protected         NodeCanvas.Framework.Internal.BBObjectParametercheckValue  // 0x70
  protected         ParadoxNotion.CompareMethod     comparison  // 0x78
METHODS:
  System.Reflection.MethodInfo get_targetMethod()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.String OnInit()
  System.Boolean OnCheck()
  System.Void SetMethod(System.Reflection.MethodInfo method)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckUnityEvent_0
TYPE:  class
TOKEN: 0x20002B8
FIELDS:
  public            System.Type                     targetType  // 0x10
  public            System.String                   eventName  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckUnityEvent_0`1
TYPE:  class
TOKEN: 0x20002B9
FIELDS:
  public            System.Type                     targetType  // 0x0
  public            System.String                   eventName  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckUnityEventValue_0`1
TYPE:  class
TOKEN: 0x20002BA
FIELDS:
  public            System.Type                     targetType  // 0x0
  public            System.String                   eventName  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckUnityEvent
TYPE:  class
TOKEN: 0x20002BB
EXTENDS: ConditionTask
FIELDS:
  private           ParadoxNotion.Serialization.SerializedUnityEventInfo_eventInfo  // 0x68
  private           UnityEngine.Events.UnityEvent   unityEvent  // 0x70
METHODS:
  System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEvent_0>.Migrate(NodeCanvas.Tasks.Conditions.CheckUnityEvent_0 model)
  System.Reflection.MemberInfo get_targetMember()
  System.Boolean get_isStatic()
  System.Type get_eventType()
  System.Reflection.FieldInfo get_targetEventField()
  System.Reflection.PropertyInfo get_targetEventProp()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.String OnInit()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Raised()
  System.Boolean OnCheck()
  System.Void SetTargetEvent(System.Reflection.MemberInfo newMember)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckUnityEvent`1
TYPE:  class
TOKEN: 0x20002BC
EXTENDS: ConditionTask
FIELDS:
  private           ParadoxNotion.Serialization.SerializedUnityEventInfo_eventInfo  // 0x0
  private           NodeCanvas.Framework.BBParameter<T>saveAs  // 0x0
  private           UnityEngine.Events.UnityEvent<T>unityEvent  // 0x0
METHODS:
  System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEvent_0<T>>.Migrate(NodeCanvas.Tasks.Conditions.CheckUnityEvent_0<T> model)
  System.Reflection.MemberInfo get_targetMember()
  System.Boolean get_isStatic()
  System.Type get_eventType()
  System.Reflection.FieldInfo get_targetEventField()
  System.Reflection.PropertyInfo get_targetEventProp()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.String OnInit()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Raised(T eventValue)
  System.Boolean OnCheck()
  System.Void SetTargetEvent(System.Reflection.MemberInfo newMember)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckUnityEventValue`1
TYPE:  class
TOKEN: 0x20002BD
EXTENDS: ConditionTask
FIELDS:
  private           ParadoxNotion.Serialization.SerializedUnityEventInfo_eventInfo  // 0x0
  private           NodeCanvas.Framework.BBParameter<T>checkValue  // 0x0
  private           UnityEngine.Events.UnityEvent<T>unityEvent  // 0x0
METHODS:
  System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEventValue_0<T>>.Migrate(NodeCanvas.Tasks.Conditions.CheckUnityEventValue_0<T> model)
  System.Reflection.MemberInfo get_targetMember()
  System.Boolean get_isStatic()
  System.Type get_eventType()
  System.Reflection.FieldInfo get_targetEventField()
  System.Reflection.PropertyInfo get_targetEventProp()
  System.Type get_agentType()
  System.String get_info()
  ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo()
  System.String OnInit()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Raised(T eventValue)
  System.Boolean OnCheck()
  System.Void SetTargetEvent(System.Reflection.MemberInfo newMember)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckFunction
TYPE:  class
TOKEN: 0x20002BE
EXTENDS: ConditionTask
FIELDS:
  protected         NodeCanvas.Framework.Internal.ReflectedFunctionWrapperfunctionWrapper  // 0x68
  protected         NodeCanvas.Framework.BBParametercheckValue  // 0x70
  protected         ParadoxNotion.CompareMethod     comparison  // 0x78
METHODS:
  System.Reflection.MethodInfo get_targetMethod()
  System.Type get_agentType()
  System.String get_info()
  System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.String OnInit()
  System.Boolean OnCheck()
  System.Void SetMethod(System.Reflection.MethodInfo method)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckProperty
TYPE:  class
TOKEN: 0x20002BF
EXTENDS: ConditionTask
FIELDS:
  protected         NodeCanvas.Framework.Internal.ReflectedFunctionWrapperfunctionWrapper  // 0x68
  protected         NodeCanvas.Framework.BBParametercheckValue  // 0x70
  protected         ParadoxNotion.CompareMethod     comparison  // 0x78
METHODS:
  System.Reflection.MethodInfo get_targetMethod()
  System.Type get_agentType()
  System.String get_info()
  System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem)
  System.String OnInit()
  System.Boolean OnCheck()
  System.Void SetMethod(System.Reflection.MethodInfo method)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckCollision_Rigidbody
TYPE:  class
TOKEN: 0x20002C0
EXTENDS: ConditionTask`1
FIELDS:
  public            ParadoxNotion.CollisionTypes    checkType  // 0x68
  public            System.Boolean                  specifiedTagOnly  // 0x6C
  public            System.String                   objectTag  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveGameObjectAs  // 0x78
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>saveContactPoint  // 0x80
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>saveContactNormal  // 0x88
  private           System.Boolean                  stay  // 0x90
METHODS:
  System.String get_info()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Boolean OnCheck()
  System.Void OnCollisionEnter(ParadoxNotion.EventData<UnityEngine.Collision> data)
  System.Void OnCollisionExit(ParadoxNotion.EventData<UnityEngine.Collision> data)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckCollision
TYPE:  class
TOKEN: 0x20002C1
EXTENDS: ConditionTask`1
FIELDS:
  public            ParadoxNotion.CollisionTypes    checkType  // 0x68
  public            System.Boolean                  specifiedTagOnly  // 0x6C
  public            System.String                   objectTag  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveGameObjectAs  // 0x78
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>saveContactPoint  // 0x80
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>saveContactNormal  // 0x88
  private           System.Boolean                  stay  // 0x90
METHODS:
  System.String get_info()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Boolean OnCheck()
  System.Void OnCollisionEnter(ParadoxNotion.EventData<UnityEngine.Collision> data)
  System.Void OnCollisionExit(ParadoxNotion.EventData<UnityEngine.Collision> data)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckCollision2D_Rigidbody
TYPE:  class
TOKEN: 0x20002C2
EXTENDS: ConditionTask`1
FIELDS:
  public            ParadoxNotion.CollisionTypes    checkType  // 0x68
  public            System.Boolean                  specifiedTagOnly  // 0x6C
  public            System.String                   objectTag  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveGameObjectAs  // 0x78
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>saveContactPoint  // 0x80
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>saveContactNormal  // 0x88
  private           System.Boolean                  stay  // 0x90
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnCollisionEnter2D(ParadoxNotion.EventData<UnityEngine.Collision2D> data)
  System.Void OnCollisionExit2D(ParadoxNotion.EventData<UnityEngine.Collision2D> data)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckCollision2D
TYPE:  class
TOKEN: 0x20002C3
EXTENDS: ConditionTask`1
FIELDS:
  public            ParadoxNotion.CollisionTypes    checkType  // 0x68
  public            System.Boolean                  specifiedTagOnly  // 0x6C
  public            System.String                   objectTag  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveGameObjectAs  // 0x78
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>saveContactPoint  // 0x80
  public            NodeCanvas.Framework.BBParameter<UnityEngine.Vector3>saveContactNormal  // 0x88
  private           System.Boolean                  stay  // 0x90
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnCollisionEnter2D(ParadoxNotion.EventData<UnityEngine.Collision2D> data)
  System.Void OnCollisionExit2D(ParadoxNotion.EventData<UnityEngine.Collision2D> data)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckMouse
TYPE:  class
TOKEN: 0x20002C4
EXTENDS: ConditionTask`1
FIELDS:
  public            ParadoxNotion.MouseInteractionTypescheckType  // 0x68
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnMouseEnter(ParadoxNotion.EventData msg)
  System.Void OnMouseExit(ParadoxNotion.EventData msg)
  System.Void OnMouseOver(ParadoxNotion.EventData msg)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckMouse2D
TYPE:  class
TOKEN: 0x20002C5
EXTENDS: ConditionTask`1
FIELDS:
  public            ParadoxNotion.MouseInteractionTypescheckType  // 0x68
METHODS:
  System.String get_info()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Boolean OnCheck()
  System.Void OnMouseEnter(ParadoxNotion.EventData msg)
  System.Void OnMouseExit(ParadoxNotion.EventData msg)
  System.Void OnMouseOver(ParadoxNotion.EventData msg)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckMouseClick
TYPE:  class
TOKEN: 0x20002C6
EXTENDS: ConditionTask`1
FIELDS:
  public            ParadoxNotion.MouseClickEvent   checkType  // 0x68
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnMouseDown(ParadoxNotion.EventData msg)
  System.Void OnMouseUp(ParadoxNotion.EventData msg)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckMouseClick2D
TYPE:  class
TOKEN: 0x20002C7
EXTENDS: ConditionTask`1
FIELDS:
  public            ParadoxNotion.MouseClickEvent   checkType  // 0x68
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnMouseDown(ParadoxNotion.EventData msg)
  System.Void OnMouseUp(ParadoxNotion.EventData msg)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckTrigger_Transform
TYPE:  class
TOKEN: 0x20002C8
EXTENDS: ConditionTask`1
FIELDS:
  public            ParadoxNotion.TriggerTypes      checkType  // 0x68
  public            System.Boolean                  specifiedTagOnly  // 0x6C
  public            System.String                   objectTag  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveGameObjectAs  // 0x78
  private           System.Boolean                  stay  // 0x80
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnTriggerEnter(ParadoxNotion.EventData<UnityEngine.Collider> data)
  System.Void OnTriggerExit(ParadoxNotion.EventData<UnityEngine.Collider> data)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckTrigger
TYPE:  class
TOKEN: 0x20002C9
EXTENDS: ConditionTask`1
FIELDS:
  public            ParadoxNotion.TriggerTypes      checkType  // 0x68
  public            System.Boolean                  specifiedTagOnly  // 0x6C
  public            System.String                   objectTag  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveGameObjectAs  // 0x78
  private           System.Boolean                  stay  // 0x80
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnTriggerEnter(ParadoxNotion.EventData<UnityEngine.Collider> data)
  System.Void OnTriggerExit(ParadoxNotion.EventData<UnityEngine.Collider> data)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckTrigger2D_Transform
TYPE:  class
TOKEN: 0x20002CA
EXTENDS: ConditionTask`1
FIELDS:
  public            ParadoxNotion.TriggerTypes      CheckType  // 0x68
  public            System.Boolean                  specifiedTagOnly  // 0x6C
  public            System.String                   objectTag  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveGameObjectAs  // 0x78
  private           System.Boolean                  stay  // 0x80
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnTriggerEnter2D(ParadoxNotion.EventData<UnityEngine.Collider2D> data)
  System.Void OnTriggerExit2D(ParadoxNotion.EventData<UnityEngine.Collider2D> data)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckTrigger2D
TYPE:  class
TOKEN: 0x20002CB
EXTENDS: ConditionTask`1
FIELDS:
  public            ParadoxNotion.TriggerTypes      CheckType  // 0x68
  public            System.Boolean                  specifiedTagOnly  // 0x6C
  public            System.String                   objectTag  // 0x70
  public            NodeCanvas.Framework.BBParameter<UnityEngine.GameObject>saveGameObjectAs  // 0x78
  private           System.Boolean                  stay  // 0x80
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnTriggerEnter2D(ParadoxNotion.EventData<UnityEngine.Collider2D> data)
  System.Void OnTriggerExit2D(ParadoxNotion.EventData<UnityEngine.Collider2D> data)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.ButtonClicked
TYPE:  class
TOKEN: 0x20002CC
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<UnityEngine.UI.Button>button  // 0x68
METHODS:
  System.String get_info()
  System.String OnInit()
  System.Boolean OnCheck()
  System.Void OnClick()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.InterceptEvent
TYPE:  class
TOKEN: 0x20002CD
EXTENDS: ConditionTask`1
FIELDS:
  public            UnityEngine.EventSystems.EventTriggerTypeeventType  // 0x68
METHODS:
  System.String get_info()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Boolean OnCheck()
  System.Void OnPointerEnter(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> data)
  System.Void OnPointerExit(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> data)
  System.Void OnPointerDown(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> data)
  System.Void OnPointerUp(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> data)
  System.Void OnPointerClick(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> data)
  System.Void OnDrag(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> data)
  System.Void OnDrop(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> eventData)
  System.Void OnScroll(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> data)
  System.Void OnUpdateSelected(ParadoxNotion.EventData<UnityEngine.EventSystems.BaseEventData> eventData)
  System.Void OnSelect(ParadoxNotion.EventData<UnityEngine.EventSystems.BaseEventData> eventData)
  System.Void OnDeselect(ParadoxNotion.EventData<UnityEngine.EventSystems.BaseEventData> eventData)
  System.Void OnMove(ParadoxNotion.EventData<UnityEngine.EventSystems.AxisEventData> eventData)
  System.Void OnSubmit(ParadoxNotion.EventData<UnityEngine.EventSystems.BaseEventData> eventData)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckEvent
TYPE:  class
TOKEN: 0x20002CE
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>eventName  // 0x68
METHODS:
  System.String get_info()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Boolean OnCheck()
  System.Void OnCustomEvent(System.String eventName, ParadoxNotion.IEventData data)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckEvent`1
TYPE:  class
TOKEN: 0x20002CF
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>eventName  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>saveEventValue  // 0x0
METHODS:
  System.String get_info()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Boolean OnCheck()
  System.Void OnCustomEvent(System.String eventName, ParadoxNotion.IEventData data)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckEventValue`1
TYPE:  class
TOKEN: 0x20002D0
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.String>eventName  // 0x0
  public            NodeCanvas.Framework.BBParameter<T>value  // 0x0
METHODS:
  System.String get_info()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Boolean OnCheck()
  System.Void OnCustomEvent(System.String eventName, ParadoxNotion.IEventData msg)
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckSignal
TYPE:  class
TOKEN: 0x20002D1
EXTENDS: ConditionTask`1
FIELDS:
  public            NodeCanvas.Framework.BBParameter<NodeCanvas.Framework.SignalDefinition>signalDefinition  // 0x68
  private           System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Internal.BBObjectParameter>argumentsMap  // 0x70
METHODS:
  System.String get_info()
  System.String OnInit()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnSignalInvoke(UnityEngine.Transform sender, UnityEngine.Transform receiver, System.Boolean isGlobal, System.Object[] args)
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.CheckStateStatus
TYPE:  class
TOKEN: 0x20002D2
EXTENDS: ConditionTask
FIELDS:
  public            ParadoxNotion.CompactStatus     status  // 0x68
METHODS:
  System.String get_info()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.DebugCondition
TYPE:  class
TOKEN: 0x20002D3
EXTENDS: ConditionTask
FIELDS:
METHODS:
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.Probability
TYPE:  class
TOKEN: 0x20002D4
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Single>probability  // 0x68
  public            NodeCanvas.Framework.BBParameter<System.Single>maxValue  // 0x70
  private           System.Boolean                  success  // 0x78
METHODS:
  System.String get_info()
  System.Void OnEnable()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: NodeCanvas.Tasks.Conditions.Timeout
TYPE:  class
TOKEN: 0x20002D5
EXTENDS: ConditionTask
FIELDS:
  public            NodeCanvas.Framework.BBParameter<System.Single>timeout  // 0x68
  private           System.Single                   currentTime  // 0x70
METHODS:
  System.String get_info()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void MoveNext()
  System.Boolean OnCheck()
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.ActionCall
TYPE:  class
TOKEN: 0x2000471
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.ActionCall`1
TYPE:  class
TOKEN: 0x2000472
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 a)
  System.IAsyncResult BeginInvoke(T1 a, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.ActionCall`2
TYPE:  class
TOKEN: 0x2000473
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 a, T2 b)
  System.IAsyncResult BeginInvoke(T1 a, T2 b, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.ActionCall`3
TYPE:  class
TOKEN: 0x2000474
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 a, T2 b, T3 c)
  System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.ActionCall`4
TYPE:  class
TOKEN: 0x2000475
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 a, T2 b, T3 c, T4 d)
  System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.ActionCall`5
TYPE:  class
TOKEN: 0x2000476
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e)
  System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, T5 e, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.ActionCall`6
TYPE:  class
TOKEN: 0x2000477
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
  System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.ActionCall`7
TYPE:  class
TOKEN: 0x2000478
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
  System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.ActionCall`8
TYPE:  class
TOKEN: 0x2000479
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
  System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.FunctionCall`1
TYPE:  class
TOKEN: 0x200047A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  TResult EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.FunctionCall`2
TYPE:  class
TOKEN: 0x200047B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 a)
  System.IAsyncResult BeginInvoke(T1 a, System.AsyncCallback callback, System.Object object)
  TResult EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.FunctionCall`3
TYPE:  class
TOKEN: 0x200047C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 a, T2 b)
  System.IAsyncResult BeginInvoke(T1 a, T2 b, System.AsyncCallback callback, System.Object object)
  TResult EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.FunctionCall`4
TYPE:  class
TOKEN: 0x200047D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 a, T2 b, T3 c)
  System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, System.AsyncCallback callback, System.Object object)
  TResult EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.FunctionCall`5
TYPE:  class
TOKEN: 0x200047E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 a, T2 b, T3 c, T4 d)
  System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, System.AsyncCallback callback, System.Object object)
  TResult EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.FunctionCall`6
TYPE:  class
TOKEN: 0x200047F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e)
  System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, T5 e, System.AsyncCallback callback, System.Object object)
  TResult EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.FunctionCall`7
TYPE:  class
TOKEN: 0x2000480
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
  System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, System.AsyncCallback callback, System.Object object)
  TResult EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.FunctionCall`8
TYPE:  class
TOKEN: 0x2000481
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
  System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, System.AsyncCallback callback, System.Object object)
  TResult EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.FunctionCall`9
TYPE:  class
TOKEN: 0x2000482
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
  System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, System.AsyncCallback callback, System.Object object)
  TResult EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: ParadoxNotion.DynamicParameterDefinition
TYPE:  class
TOKEN: 0x2000483
FIELDS:
  private           System.String                   _ID  // 0x10
  private           System.String                   _name  // 0x18
  private           System.String                   _type  // 0x20
  private           System.Type                     <type>k__BackingField  // 0x28
METHODS:
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.String get_ID()
  System.Void set_ID(System.String value)
  System.String get_name()
  System.Void set_name(System.String value)
  System.Type get_type()
  System.Void set_type(System.Type value)
  System.Void .ctor()
  System.Void .ctor(System.String name, System.Type type)
END_CLASS

CLASS: ParadoxNotion.CompareMethod
TYPE:  struct
TOKEN: 0x2000484
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.CompareMethod     EqualTo  // 0x0
  public    static  ParadoxNotion.CompareMethod     GreaterThan  // 0x0
  public    static  ParadoxNotion.CompareMethod     LessThan  // 0x0
  public    static  ParadoxNotion.CompareMethod     GreaterOrEqualTo  // 0x0
  public    static  ParadoxNotion.CompareMethod     LessOrEqualTo  // 0x0
METHODS:
END_CLASS

CLASS: ParadoxNotion.OperationMethod
TYPE:  struct
TOKEN: 0x2000485
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.OperationMethod   Set  // 0x0
  public    static  ParadoxNotion.OperationMethod   Add  // 0x0
  public    static  ParadoxNotion.OperationMethod   Subtract  // 0x0
  public    static  ParadoxNotion.OperationMethod   Multiply  // 0x0
  public    static  ParadoxNotion.OperationMethod   Divide  // 0x0
METHODS:
END_CLASS

CLASS: ParadoxNotion.ButtonKeys
TYPE:  struct
TOKEN: 0x2000486
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.ButtonKeys        Left  // 0x0
  public    static  ParadoxNotion.ButtonKeys        Right  // 0x0
  public    static  ParadoxNotion.ButtonKeys        Middle  // 0x0
METHODS:
END_CLASS

CLASS: ParadoxNotion.PressTypes
TYPE:  struct
TOKEN: 0x2000487
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.PressTypes        Down  // 0x0
  public    static  ParadoxNotion.PressTypes        Up  // 0x0
  public    static  ParadoxNotion.PressTypes        Pressed  // 0x0
METHODS:
END_CLASS

CLASS: ParadoxNotion.MouseClickEvent
TYPE:  struct
TOKEN: 0x2000488
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.MouseClickEvent   MouseDown  // 0x0
  public    static  ParadoxNotion.MouseClickEvent   MouseUp  // 0x0
METHODS:
END_CLASS

CLASS: ParadoxNotion.TriggerTypes
TYPE:  struct
TOKEN: 0x2000489
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.TriggerTypes      TriggerEnter  // 0x0
  public    static  ParadoxNotion.TriggerTypes      TriggerExit  // 0x0
  public    static  ParadoxNotion.TriggerTypes      TriggerStay  // 0x0
METHODS:
END_CLASS

CLASS: ParadoxNotion.CollisionTypes
TYPE:  struct
TOKEN: 0x200048A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.CollisionTypes    CollisionEnter  // 0x0
  public    static  ParadoxNotion.CollisionTypes    CollisionExit  // 0x0
  public    static  ParadoxNotion.CollisionTypes    CollisionStay  // 0x0
METHODS:
END_CLASS

CLASS: ParadoxNotion.MouseInteractionTypes
TYPE:  struct
TOKEN: 0x200048B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.MouseInteractionTypesMouseEnter  // 0x0
  public    static  ParadoxNotion.MouseInteractionTypesMouseExit  // 0x0
  public    static  ParadoxNotion.MouseInteractionTypesMouseOver  // 0x0
METHODS:
END_CLASS

CLASS: ParadoxNotion.CompactStatus
TYPE:  struct
TOKEN: 0x200048C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.CompactStatus     Failure  // 0x0
  public    static  ParadoxNotion.CompactStatus     Success  // 0x0
METHODS:
END_CLASS

CLASS: ParadoxNotion.PlayDirections
TYPE:  struct
TOKEN: 0x200048D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.PlayDirections    Forward  // 0x0
  public    static  ParadoxNotion.PlayDirections    Backward  // 0x0
  public    static  ParadoxNotion.PlayDirections    Toggle  // 0x0
METHODS:
END_CLASS

CLASS: ParadoxNotion.PlanarDirection
TYPE:  struct
TOKEN: 0x200048E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.PlanarDirection   Horizontal  // 0x0
  public    static  ParadoxNotion.PlanarDirection   Vertical  // 0x0
  public    static  ParadoxNotion.PlanarDirection   Auto  // 0x0
METHODS:
END_CLASS

CLASS: ParadoxNotion.Alignment2x2
TYPE:  struct
TOKEN: 0x200048F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.Alignment2x2      Default  // 0x0
  public    static  ParadoxNotion.Alignment2x2      Left  // 0x0
  public    static  ParadoxNotion.Alignment2x2      Right  // 0x0
  public    static  ParadoxNotion.Alignment2x2      Top  // 0x0
  public    static  ParadoxNotion.Alignment2x2      Bottom  // 0x0
METHODS:
END_CLASS

CLASS: ParadoxNotion.Alignment3x3
TYPE:  struct
TOKEN: 0x2000490
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.Alignment3x3      TopLeft  // 0x0
  public    static  ParadoxNotion.Alignment3x3      TopCenter  // 0x0
  public    static  ParadoxNotion.Alignment3x3      TopRight  // 0x0
  public    static  ParadoxNotion.Alignment3x3      MiddleLeft  // 0x0
  public    static  ParadoxNotion.Alignment3x3      MiddleCenter  // 0x0
  public    static  ParadoxNotion.Alignment3x3      MiddleRight  // 0x0
  public    static  ParadoxNotion.Alignment3x3      BottomLeft  // 0x0
  public    static  ParadoxNotion.Alignment3x3      BottomCenter  // 0x0
  public    static  ParadoxNotion.Alignment3x3      BottomRight  // 0x0
METHODS:
END_CLASS

CLASS: ParadoxNotion.HierarchyTree
TYPE:  class
TOKEN: 0x2000491
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.IEventData
TYPE:  interface
TOKEN: 0x2000494
FIELDS:
METHODS:
  UnityEngine.GameObject get_receiver()
  System.Object get_sender()
  System.Object get_valueBoxed()
END_CLASS

CLASS: ParadoxNotion.EventData
TYPE:  struct
TOKEN: 0x2000495
FIELDS:
  private           UnityEngine.GameObject          <receiver>k__BackingField  // 0x10
  private           System.Object                   <sender>k__BackingField  // 0x18
  private           System.Object                   <value>k__BackingField  // 0x20
METHODS:
  UnityEngine.GameObject get_receiver()
  System.Void set_receiver(UnityEngine.GameObject value)
  System.Object get_sender()
  System.Void set_sender(System.Object value)
  System.Object get_value()
  System.Void set_value(System.Object value)
  System.Object get_valueBoxed()
  System.Void .ctor(System.Object value, UnityEngine.GameObject receiver, System.Object sender)
  System.Void .ctor(UnityEngine.GameObject receiver, System.Object sender)
END_CLASS

CLASS: ParadoxNotion.EventData`1
TYPE:  struct
TOKEN: 0x2000496
FIELDS:
  private           UnityEngine.GameObject          <receiver>k__BackingField  // 0x0
  private           System.Object                   <sender>k__BackingField  // 0x0
  private           T                               <value>k__BackingField  // 0x0
METHODS:
  UnityEngine.GameObject get_receiver()
  System.Void set_receiver(UnityEngine.GameObject value)
  System.Object get_sender()
  System.Void set_sender(System.Object value)
  T get_value()
  System.Void set_value(T value)
  System.Object get_valueBoxed()
  System.Void .ctor(T value, UnityEngine.GameObject receiver, System.Object sender)
END_CLASS

CLASS: ParadoxNotion.OperationTools
TYPE:  class
TOKEN: 0x2000497
FIELDS:
METHODS:
  System.String GetOperationString(ParadoxNotion.OperationMethod om)
  System.Single Operate(System.Single a, System.Single b, ParadoxNotion.OperationMethod om, System.Single delta)
  System.Int32 Operate(System.Int32 a, System.Int32 b, ParadoxNotion.OperationMethod om)
  UnityEngine.Vector3 Operate(UnityEngine.Vector3 a, UnityEngine.Vector3 b, ParadoxNotion.OperationMethod om, System.Single delta)
  System.String GetCompareString(ParadoxNotion.CompareMethod cm)
  System.Boolean Compare(System.Single a, System.Single b, ParadoxNotion.CompareMethod cm, System.Single floatingPoint)
  System.Boolean Compare(System.Int32 a, System.Int32 b, ParadoxNotion.CompareMethod cm)
END_CLASS

CLASS: ParadoxNotion.ReflectionTools
TYPE:  class
TOKEN: 0x2000498
FIELDS:
  public    static  System.Reflection.BindingFlags  FLAGS_ALL  // 0x0
  public    static  System.Reflection.BindingFlags  FLAGS_ALL_DECLARED  // 0x0
  private   static  System.Reflection.Assembly[]    _loadedAssemblies  // 0x0
  private   static  System.Type[]                   _allTypes  // 0x8
  private   static  System.Object[]                 _tempArgs  // 0x10
  private   static  System.Collections.Generic.Dictionary<System.String,System.Type>_typesMap  // 0x18
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Type[]>_subTypesMap  // 0x20
  private   static  System.Collections.Generic.Dictionary<System.Reflection.MethodBase,ParadoxNotion.ReflectionTools.MethodType>_methodSpecialType  // 0x28
  private   static  System.Collections.Generic.Dictionary<System.Type,System.String>_typeFriendlyName  // 0x30
  private   static  System.Collections.Generic.Dictionary<System.Type,System.String>_typeFriendlyNameCompileSafe  // 0x38
  private   static  System.Collections.Generic.Dictionary<System.Reflection.MethodBase,System.String>_methodSignatures  // 0x40
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Reflection.ConstructorInfo[]>_typeConstructors  // 0x48
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Reflection.MethodInfo[]>_typeMethods  // 0x50
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Reflection.FieldInfo[]>_typeFields  // 0x58
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Reflection.PropertyInfo[]>_typeProperties  // 0x60
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Reflection.EventInfo[]>_typeEvents  // 0x68
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Object[]>_typeAttributes  // 0x70
  private   static  System.Collections.Generic.Dictionary<System.Reflection.MemberInfo,System.Object[]>_memberAttributes  // 0x78
  private   static  System.Collections.Generic.Dictionary<System.Reflection.MemberInfo,System.Boolean>_obsoleteCache  // 0x80
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Reflection.MethodInfo[]>_typeExtensions  // 0x88
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Type[]>_genericArgsTypeCache  // 0x90
  private   static  System.Collections.Generic.Dictionary<System.Reflection.MethodInfo,System.Type[]>_genericArgsMathodCache  // 0x98
  public    static readonly System.Collections.Generic.Dictionary<System.String,System.String>op_FriendlyNamesLong  // 0xA0
  public    static readonly System.Collections.Generic.Dictionary<System.String,System.String>op_FriendlyNamesShort  // 0xA8
  public    static readonly System.Collections.Generic.Dictionary<System.String,System.String>op_CSharpAliases  // 0xB0
  public    static  System.String                   METHOD_SPECIAL_NAME_GET  // 0x0
  public    static  System.String                   METHOD_SPECIAL_NAME_SET  // 0x0
  public    static  System.String                   METHOD_SPECIAL_NAME_ADD  // 0x0
  public    static  System.String                   METHOD_SPECIAL_NAME_REMOVE  // 0x0
  public    static  System.String                   METHOD_SPECIAL_NAME_OP  // 0x0
METHODS:
  System.Void .cctor()
  System.Void FlushMem()
  System.Reflection.Assembly[] get_loadedAssemblies()
  System.Type GetType(System.String typeFullName)
  System.Type GetType(System.String typeFullName, System.Type fallbackAssignable)
  System.Type GetType(System.String typeFullName, System.Boolean fallbackNoNamespace, System.Type fallbackAssignable)
  System.Type GetTypeDirect(System.String typeFullName)
  System.Type TryResolveGenericType(System.String typeFullName, System.Boolean fallbackNoNamespace, System.Type fallbackAssignable)
  System.Type TryResolveDeserializeFromAttribute(System.String typeName)
  System.Type TryResolveWithoutNamespace(System.String typeName, System.Type fallbackAssignable)
  System.Type[] GetAllTypes(System.Boolean includeObsolete)
  System.Type[] GetImplementationsOf(System.Type baseType)
  System.Object[] SingleTempArgsArray(System.Object arg)
  ParadoxNotion.ReflectionTools.MethodType GetMethodSpecialType(System.Reflection.MethodBase method)
  System.String FriendlyName(System.Type t, System.Boolean compileSafe)
  System.String FriendlyName(System.Reflection.MemberInfo info)
  System.String FriendlyName(System.Reflection.MethodBase method)
  System.String FriendlyName(System.Reflection.MethodBase method, ParadoxNotion.ReflectionTools.MethodType& specialNameType)
  System.String SignatureName(System.Reflection.MethodBase method)
  System.String FriendlyTypeName(System.String fullName)
  System.Type RTReflectedOrDeclaredType(System.Reflection.MemberInfo member)
  System.Boolean RTIsAssignableFrom(System.Type type, System.Type other)
  System.Boolean RTIsAssignableTo(System.Type type, System.Type other)
  System.Boolean RTIsAbstract(System.Type type)
  System.Boolean RTIsValueType(System.Type type)
  System.Boolean RTIsArray(System.Type type)
  System.Boolean RTIsInterface(System.Type type)
  System.Boolean RTIsSubclassOf(System.Type type, System.Type other)
  System.Boolean RTIsGenericParameter(System.Type type)
  System.Boolean RTIsGenericType(System.Type type)
  System.Reflection.MethodInfo RTGetGetMethod(System.Reflection.PropertyInfo prop)
  System.Reflection.MethodInfo RTGetSetMethod(System.Reflection.PropertyInfo prop)
  System.Reflection.MethodInfo RTGetDelegateMethodInfo(System.Delegate del)
  System.Type RTMakeGenericType(System.Type type, System.Type[] typeArgs)
  System.Type[] RTGetGenericArguments(System.Type type)
  System.Type[] RTGetGenericArguments(System.Reflection.MethodInfo method)
  System.Type[] RTGetEmptyTypes()
  System.Type RTGetElementType(System.Type type)
  System.Boolean RTIsByRef(System.Type type)
  System.Object CreateObject(System.Type type)
  System.Object CreateObjectUninitialized(System.Type type)
  System.Reflection.ConstructorInfo RTGetDefaultConstructor(System.Type type)
  System.Reflection.ConstructorInfo RTGetConstructor(System.Type type, System.Type[] paramTypes)
  System.Boolean MemberResolvedFromDeserializeAttribute(System.Reflection.MemberInfo member, System.String targetName)
  System.Reflection.MethodInfo RTGetMethod(System.Type type, System.String name)
  System.Reflection.MethodInfo RTGetMethod(System.Type type, System.String name, System.Type[] paramTypes, System.Type returnType, System.Type[] genericArgumentTypes)
  System.Reflection.FieldInfo RTGetField(System.Type type, System.String name, System.Boolean includePrivateBase)
  System.Reflection.PropertyInfo RTGetProperty(System.Type type, System.String name)
  System.Reflection.MemberInfo RTGetFieldOrProp(System.Type type, System.String name)
  System.Reflection.EventInfo RTGetEvent(System.Type type, System.String name)
  System.Object RTGetFieldOrPropValue(System.Reflection.MemberInfo member, System.Object instance, System.Int32 index)
  System.Void RTSetFieldOrPropValue(System.Reflection.MemberInfo member, System.Object instance, System.Object value, System.Int32 index)
  System.Reflection.ConstructorInfo[] RTGetConstructors(System.Type type)
  System.Reflection.MethodInfo[] RTGetMethods(System.Type type)
  System.Reflection.FieldInfo[] RTGetFields(System.Type type)
  System.Reflection.PropertyInfo[] RTGetProperties(System.Type type)
  System.Reflection.EventInfo[] RTGetEvents(System.Type type)
  System.Object[] RTGetAllAttributes(System.Type type)
  System.Boolean RTIsDefined(System.Type type, System.Boolean inherited)
  System.Boolean RTIsDefined(System.Type type, System.Type attributeType, System.Boolean inherited)
  T RTGetAttribute(System.Type type, System.Boolean inherited)
  System.Attribute RTGetAttribute(System.Type type, System.Type attributeType, System.Boolean inherited)
  System.Object[] RTGetAllAttributes(System.Reflection.MemberInfo member)
  System.Boolean RTIsDefined(System.Reflection.MemberInfo member, System.Boolean inherited)
  System.Boolean RTIsDefined(System.Reflection.MemberInfo member, System.Type attributeType, System.Boolean inherited)
  T RTGetAttribute(System.Reflection.MemberInfo member, System.Boolean inherited)
  System.Attribute RTGetAttribute(System.Reflection.MemberInfo member, System.Type attributeType, System.Boolean inherited)
  System.Collections.Generic.IEnumerable<T> RTGetAttributesRecursive(System.Type type)
  System.Reflection.ParameterInfo[] RTGetDelegateTypeParameters(System.Type delegateType)
  T RTCreateDelegate(System.Reflection.MethodInfo method, System.Object instance)
  System.Delegate RTCreateDelegate(System.Reflection.MethodInfo method, System.Type type, System.Object instance)
  System.Delegate ConvertDelegate(System.Delegate originalDelegate, System.Type targetDelegateType)
  System.Boolean IsReadOnly(System.Reflection.FieldInfo field)
  System.Boolean IsConstant(System.Reflection.FieldInfo field)
  System.Boolean IsStatic(System.Reflection.EventInfo info)
  System.Boolean IsStatic(System.Reflection.PropertyInfo info)
  System.Boolean IsParams(System.Reflection.ParameterInfo parameter, System.Reflection.ParameterInfo[] parameters)
  System.Boolean IsObsolete(System.Reflection.MemberInfo member, System.Boolean inherited)
  System.Reflection.PropertyInfo GetBaseDefinition(System.Reflection.PropertyInfo propertyInfo)
  System.Reflection.FieldInfo GetBaseDefinition(System.Reflection.FieldInfo fieldInfo)
  System.Reflection.MethodInfo[] GetExtensionMethods(System.Type targetType)
  System.Boolean IsExtensionMethod(System.Reflection.MethodInfo method)
  System.Boolean IsPropertyAccessor(System.Reflection.MethodInfo method)
  System.Boolean IsIndexerProperty(System.Reflection.PropertyInfo property)
  System.Boolean IsAutoProperty(System.Reflection.PropertyInfo property)
  System.Reflection.PropertyInfo GetAccessorProperty(System.Reflection.MethodInfo method)
  System.Boolean IsEnumerableCollection(System.Type type)
  System.Type GetEnumerableElementType(System.Type type)
  System.Type GetSingleGenericArgument(System.Type type)
  System.Type GetFirstGenericParameterConstraintType(System.Type type)
  System.Type GetFirstGenericParameterConstraintType(System.Reflection.MethodInfo method)
  System.Boolean TryMakeGeneric(System.Type def, System.Type argType, System.Type& result)
  System.Boolean TryMakeGeneric(System.Reflection.MethodInfo def, System.Type argType, System.Reflection.MethodInfo& result)
  System.Array Resize(System.Array array, System.Int32 newSize)
  System.Boolean TryConvert(System.Type fromType, System.Type toType, System.Linq.Expressions.UnaryExpression& exp)
  System.Void DigFields(System.Object root, System.Predicate<System.Reflection.FieldInfo> move, System.Action<System.Object> push, System.Action<System.Object> pop)
  System.Func<T,TResult> GetFieldGetter(System.Reflection.FieldInfo info)
  System.Action<T,TValue> GetFieldSetter(System.Reflection.FieldInfo info)
END_CLASS

CLASS: ParadoxNotion.TypeConverter
TYPE:  class
TOKEN: 0x200049F
FIELDS:
  private   static  ParadoxNotion.TypeConverter.CustomConvertercustomConverter  // 0x0
METHODS:
  System.Void add_customConverter(ParadoxNotion.TypeConverter.CustomConverter value)
  System.Void remove_customConverter(ParadoxNotion.TypeConverter.CustomConverter value)
  System.Func<System.Object,System.Object> Get(System.Type fromType, System.Type toType)
  System.Boolean CanConvert(System.Type fromType, System.Type toType)
END_CLASS

CLASS: ParadoxNotion.ColorUtils
TYPE:  class
TOKEN: 0x20004A3
FIELDS:
  private   static  System.Collections.Generic.Dictionary<UnityEngine.Color32,System.String>colorHexCache  // 0x0
  private   static  System.Collections.Generic.Dictionary<System.String,UnityEngine.Color>hexColorCache  // 0x8
  private   static  System.Collections.Generic.Dictionary<System.ValueTuple<System.Int32,System.Int32,UnityEngine.Gradient,System.Single>,UnityEngine.Texture2D>gradientTextureCache  // 0x10
  private   static  System.Collections.Generic.Dictionary<System.ValueTuple<UnityEngine.Color,System.Single,UnityEngine.Color,System.Single>,UnityEngine.Gradient>gradientCache  // 0x18
  private   static  System.Collections.Generic.Dictionary<System.String,UnityEngine.Gradient>menuItemRibbonGradientCache  // 0x20
METHODS:
  UnityEngine.Color WithAlpha(UnityEngine.Color color, System.Single alpha)
  UnityEngine.Color Grey(System.Single value)
  System.String ColorToHex(UnityEngine.Color32 color)
  UnityEngine.Color HexToColor(System.String hex)
  UnityEngine.Texture2D CreateGradientTexture(System.Int32 width, System.Int32 height, UnityEngine.Gradient gradient, System.Single rotateDegree)
  UnityEngine.Gradient CreateGradient(UnityEngine.Color colorLeft, System.Single colorLeftRatio, UnityEngine.Color colorRight, System.Single colorRightRatio)
  UnityEngine.Gradient GetMenuItemRibbonGradientOfNodeFullPath(System.String fullPath)
  System.Void RegisterMenuItemRibbonGradientOfNodeFullPath(System.String fullPath, UnityEngine.Color colorLeft, System.Single colorLeftRatio, UnityEngine.Color colorRight, System.Single colorRightRatio)
  System.Void .cctor()
END_CLASS

CLASS: ParadoxNotion.CurveUtils
TYPE:  class
TOKEN: 0x20004A4
FIELDS:
  private   static  System.Single                   POS_CHECK_RES  // 0x0
  private   static  System.Single                   POS_CHECK_DISTANCE  // 0x0
METHODS:
  UnityEngine.Vector2 GetPosAlongCurve(UnityEngine.Vector2 from, UnityEngine.Vector2 to, UnityEngine.Vector2 fromTangent, UnityEngine.Vector2 toTangent, System.Single t)
  System.Boolean IsPosAlongCurve(UnityEngine.Vector2 from, UnityEngine.Vector2 to, UnityEngine.Vector2 fromTangent, UnityEngine.Vector2 toTangent, UnityEngine.Vector2 targetPosition)
  System.Boolean IsPosAlongCurve(UnityEngine.Vector2 from, UnityEngine.Vector2 to, UnityEngine.Vector2 fromTangent, UnityEngine.Vector2 toTangent, UnityEngine.Vector2 targetPosition, System.Single& norm)
  System.Void ResolveTangents(UnityEngine.Vector2 from, UnityEngine.Vector2 to, System.Single rigidMlt, ParadoxNotion.PlanarDirection direction, UnityEngine.Vector2& fromTangent, UnityEngine.Vector2& toTangent)
  System.Void ResolveTangents(UnityEngine.Vector2 from, UnityEngine.Vector2 to, UnityEngine.Rect fromRect, UnityEngine.Rect toRect, System.Single rigidMlt, ParadoxNotion.PlanarDirection direction, UnityEngine.Vector2& fromTangent, UnityEngine.Vector2& toTangent)
END_CLASS

CLASS: ParadoxNotion.GUIStyleUtils
TYPE:  class
TOKEN: 0x20004A5
FIELDS:
METHODS:
  UnityEngine.GUIStyle Margin(UnityEngine.GUIStyle style, System.Int32 left, System.Int32 right, System.Int32 top, System.Int32 bottom)
  UnityEngine.GUIStyle Padding(UnityEngine.GUIStyle style, System.Int32 left, System.Int32 right, System.Int32 top, System.Int32 bottom)
  UnityEngine.GUIStyle Border(UnityEngine.GUIStyle style, System.Int32 left, System.Int32 right, System.Int32 top, System.Int32 bottom)
  UnityEngine.GUIStyle Overflow(UnityEngine.GUIStyle style, System.Int32 left, System.Int32 right, System.Int32 top, System.Int32 bottom)
  UnityEngine.GUIStyle TextAlignment(UnityEngine.GUIStyle style, UnityEngine.TextAnchor anchor)
  UnityEngine.GUIStyle RichText(UnityEngine.GUIStyle style, System.Boolean rich)
END_CLASS

CLASS: ParadoxNotion.LayerUtils
TYPE:  class
TOKEN: 0x20004A6
FIELDS:
METHODS:
  UnityEngine.LayerMask CreateFromNames(System.String[] layerNames)
  UnityEngine.LayerMask CreateFromNumbers(System.Int32[] layerNumbers)
  UnityEngine.LayerMask LayerNamesToMask(System.String[] layerNames)
  UnityEngine.LayerMask LayerNumbersToMask(System.Int32[] layerNumbers)
  UnityEngine.LayerMask Inverse(UnityEngine.LayerMask mask)
  UnityEngine.LayerMask AddToMask(UnityEngine.LayerMask mask, System.String[] layerNames)
  UnityEngine.LayerMask RemoveFromMask(UnityEngine.LayerMask mask, System.String[] layerNames)
  System.Boolean ContainsAnyLayer(UnityEngine.LayerMask mask, System.String[] layerNames)
  System.Boolean ContainsAllLayers(UnityEngine.LayerMask mask, System.String[] layerNames)
  System.String[] MaskToNames(UnityEngine.LayerMask mask)
  System.String MaskToString(UnityEngine.LayerMask mask)
  System.String MaskToString(UnityEngine.LayerMask mask, System.String delimiter)
END_CLASS

CLASS: ParadoxNotion.ObjectUtils
TYPE:  class
TOKEN: 0x20004A7
FIELDS:
METHODS:
  System.Boolean AnyEquals(System.Object a, System.Object b)
  System.Collections.Generic.List<T> Shuffle(System.Collections.Generic.List<T> list)
  System.Boolean Is(System.Object o, T& result)
  T GetAddComponent(UnityEngine.GameObject gameObject)
  UnityEngine.Component TransformToType(UnityEngine.Component current, System.Type type)
  System.Collections.Generic.IEnumerable<UnityEngine.GameObject> FindGameObjectsWithinLayerMask(UnityEngine.LayerMask mask, UnityEngine.GameObject exclude)
  System.Boolean IsInLayerMask(UnityEngine.GameObject gameObject, UnityEngine.LayerMask mask)
END_CLASS

CLASS: ParadoxNotion.RectUtils
TYPE:  class
TOKEN: 0x20004A9
FIELDS:
METHODS:
  UnityEngine.Rect GetBoundRect(UnityEngine.Rect[] rects)
  UnityEngine.Rect GetBoundRect(UnityEngine.Vector2[] positions)
  System.Boolean Encapsulates(UnityEngine.Rect a, UnityEngine.Rect b)
  UnityEngine.Rect ExpandBy(UnityEngine.Rect rect, System.Single margin)
  UnityEngine.Rect ExpandBy(UnityEngine.Rect rect, System.Single xMargin, System.Single yMargin)
  UnityEngine.Rect ExpandBy(UnityEngine.Rect rect, System.Single left, System.Single top, System.Single right, System.Single bottom)
  UnityEngine.Rect TransformSpace(UnityEngine.Rect rect, UnityEngine.Rect oldContainer, UnityEngine.Rect newContainer)
  UnityEngine.Vector2 TransformSpace(UnityEngine.Vector2 vector, UnityEngine.Rect oldContainer, UnityEngine.Rect newContainer)
END_CLASS

CLASS: ParadoxNotion.StringUtils
TYPE:  class
TOKEN: 0x20004AA
FIELDS:
  public    static  System.String                   SPACE  // 0x0
  public    static  System.String                   ALPHABET  // 0x0
  public    static readonly System.Char[]                   CHAR_SPACE_ARRAY  // 0x0
  private   static  System.Collections.Generic.Dictionary<System.String,System.String>splitCaseCache  // 0x8
METHODS:
  System.String SplitCamelCase(System.String s)
  System.String CapitalizeFirst(System.String s)
  System.String CapLength(System.String s, System.Int32 max)
  System.String GetCapitals(System.String s)
  System.String FormatError(System.String input)
  System.String GetAlphabetLetter(System.Int32 index)
  System.String GetStringWithinOuter(System.String input, System.Char from, System.Char to)
  System.String GetStringWithinInner(System.String input, System.Char from, System.Char to)
  System.String ReplaceWithin(System.String text, System.Char startChar, System.Char endChar, System.Func<System.String,System.String> Process)
  System.Single ScoreSearchMatch(System.String input, System.String leafName, System.String categoryName)
  System.Boolean SearchMatch(System.String input, System.String leafName, System.String categoryName)
  System.String ToStringAdvanced(System.Object o)
  System.Void .cctor()
END_CLASS

CLASS: ParadoxNotion.WeakReferenceList`1
TYPE:  class
TOKEN: 0x20004AB
FIELDS:
  private           System.Collections.Generic.List<System.WeakReference<T>>list  // 0x0
METHODS:
  System.Int32 get_Count()
  System.Void .ctor()
  System.Void .ctor(System.Int32 capacity)
  T get_Item(System.Int32 i)
  System.Void set_Item(System.Int32 i, T value)
  System.Void Add(T item)
  System.Void Remove(T item)
  System.Boolean Contains(T item, System.Int32& index)
  System.Void Clear()
  System.Collections.Generic.List<T> ToReferenceList()
  ParadoxNotion.WeakReferenceList<T> op_Implicit(System.Collections.Generic.List<T> value)
END_CLASS

CLASS: ParadoxNotion.WeakReferenceTable`2
TYPE:  class
TOKEN: 0x20004AC
FIELDS:
  private           System.Collections.Generic.List<System.WeakReference<TKey>>keys  // 0x0
  private           System.Collections.Generic.List<TValue>values  // 0x0
METHODS:
  System.Int32 get_Count()
  System.Void .ctor()
  System.Void Clear()
  System.Void Add(TKey key, TValue value)
  System.Void Remove(TKey key)
  System.Boolean TryGetValueWithRefCheck(TKey key, TValue& value)
  System.Void RemoveMissingReferences()
  System.Void CheckCount()
END_CLASS

CLASS: ParadoxNotion.Animation.EaseType
TYPE:  struct
TOKEN: 0x2000510
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.Animation.EaseTypeLinear  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeQuadraticIn  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeQuadraticOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeQuadraticInOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeQuarticIn  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeQuarticOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeQuarticInOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeQuinticIn  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeQuinticOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeQuinticInOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeCubicIn  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeCubicOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeCubicInOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeExponentialIn  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeExponentialOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeExponentialInOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeCircularIn  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeCircularOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeCircularInOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeSinusoidalIn  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeSinusoidalOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeSinusoidalInOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeElasticIn  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeElasticOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeElasticInOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeBounceIn  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeBounceOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeBounceInOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeBackIn  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeBackOut  // 0x0
  public    static  ParadoxNotion.Animation.EaseTypeBackInOut  // 0x0
METHODS:
END_CLASS

CLASS: ParadoxNotion.Animation.Easing
TYPE:  class
TOKEN: 0x2000511
FIELDS:
METHODS:
  System.Single Ease(ParadoxNotion.Animation.EaseType type, System.Single from, System.Single to, System.Single t)
  UnityEngine.Vector3 Ease(ParadoxNotion.Animation.EaseType type, UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single t)
  UnityEngine.Quaternion Ease(ParadoxNotion.Animation.EaseType type, UnityEngine.Quaternion from, UnityEngine.Quaternion to, System.Single t)
  UnityEngine.Color Ease(ParadoxNotion.Animation.EaseType type, UnityEngine.Color from, UnityEngine.Color to, System.Single t)
  System.Func<System.Single,System.Single> Function(ParadoxNotion.Animation.EaseType type)
  System.Single Linear(System.Single t)
  System.Single QuadraticIn(System.Single t)
  System.Single QuadraticOut(System.Single t)
  System.Single QuadraticInOut(System.Single t)
  System.Single QuarticIn(System.Single t)
  System.Single QuarticOut(System.Single t)
  System.Single QuarticInOut(System.Single t)
  System.Single QuinticIn(System.Single t)
  System.Single QuinticOut(System.Single t)
  System.Single QuinticInOut(System.Single t)
  System.Single CubicIn(System.Single t)
  System.Single CubicOut(System.Single t)
  System.Single CubicInOut(System.Single t)
  System.Single SinusoidalIn(System.Single t)
  System.Single SinusoidalOut(System.Single t)
  System.Single SinusoidalInOut(System.Single t)
  System.Single ExponentialIn(System.Single t)
  System.Single ExponentialOut(System.Single t)
  System.Single ExponentialInOut(System.Single t)
  System.Single CircularIn(System.Single t)
  System.Single CircularOut(System.Single t)
  System.Single CircularInOut(System.Single t)
  System.Single ElasticIn(System.Single t)
  System.Single ElasticOut(System.Single t)
  System.Single ElasticInOut(System.Single t)
  System.Single BounceIn(System.Single t)
  System.Single BounceOut(System.Single t)
  System.Single BounceInOut(System.Single t)
  System.Single BackIn(System.Single t)
  System.Single BackOut(System.Single t)
  System.Single BackInOut(System.Single t)
END_CLASS

CLASS: ParadoxNotion.Design.SpoofAOTAttribute
TYPE:  class
TOKEN: 0x2000512
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Design.CancelSpoofAOTAttribute
TYPE:  class
TOKEN: 0x2000513
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Design.DoNotListAttribute
TYPE:  class
TOKEN: 0x2000514
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Design.ProtectedSingletonAttribute
TYPE:  class
TOKEN: 0x2000515
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Design.ExecutionPriorityAttribute
TYPE:  class
TOKEN: 0x2000516
EXTENDS: Attribute
FIELDS:
  public    readonly System.Int32                    priority  // 0x10
METHODS:
  System.Void .ctor(System.Int32 priority)
END_CLASS

CLASS: ParadoxNotion.Design.ExposeAsDefinitionAttribute
TYPE:  class
TOKEN: 0x2000517
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Design.ExposeFieldAttribute
TYPE:  class
TOKEN: 0x2000518
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Design.NodeCanvasOdinOnlyAttribute
TYPE:  class
TOKEN: 0x2000519
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Design.ListInspectorOptionAttribute
TYPE:  class
TOKEN: 0x200051A
EXTENDS: Attribute
FIELDS:
  public    readonly System.Boolean                  allowAdd  // 0x10
  public    readonly System.Boolean                  allowRemove  // 0x11
  public    readonly System.Boolean                  showFoldout  // 0x12
METHODS:
  System.Void .ctor(System.Boolean allowAdd, System.Boolean allowRemove, System.Boolean alwaysExpanded)
END_CLASS

CLASS: ParadoxNotion.Design.NameAttribute
TYPE:  class
TOKEN: 0x200051B
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   name  // 0x10
  public    readonly System.Int32                    priority  // 0x18
METHODS:
  System.Void .ctor(System.String name, System.Int32 priority)
END_CLASS

CLASS: ParadoxNotion.Design.CategoryAttribute
TYPE:  class
TOKEN: 0x200051C
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   category  // 0x10
METHODS:
  System.Void .ctor(System.String category)
END_CLASS

CLASS: ParadoxNotion.Design.DescriptionAttribute
TYPE:  class
TOKEN: 0x200051D
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   description  // 0x10
METHODS:
  System.Void .ctor(System.String description)
END_CLASS

CLASS: ParadoxNotion.Design.IconAttribute
TYPE:  class
TOKEN: 0x200051E
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   iconName  // 0x10
  public    readonly System.Boolean                  fixedColor  // 0x18
  public    readonly System.String                   runtimeIconTypeCallback  // 0x20
  public    readonly System.Type                     fromType  // 0x28
METHODS:
  System.Void .ctor(System.String iconName, System.Boolean fixedColor, System.String runtimeIconTypeCallback)
  System.Void .ctor(System.Type fromType)
END_CLASS

CLASS: ParadoxNotion.Design.ColorAttribute
TYPE:  class
TOKEN: 0x200051F
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   hexColor  // 0x10
METHODS:
  System.Void .ctor(System.String hexColor)
END_CLASS

CLASS: ParadoxNotion.Design.ColorGradientAttribute
TYPE:  class
TOKEN: 0x2000520
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   hexColorLeft  // 0x10
  public    readonly System.Single                   colorLeftRatio  // 0x18
  public    readonly System.String                   hexColorRight  // 0x20
  public    readonly System.Single                   colorRightRatio  // 0x28
  public    readonly System.Single                   rotateDegree  // 0x2C
METHODS:
  UnityEngine.Color get_colorLeft()
  UnityEngine.Color get_colorRight()
  System.Void .ctor(System.String hexColorLeft, System.Single colorLeftRatio, System.String hexColorRight, System.Single colorRightRatio, System.Single rotateDegree)
END_CLASS

CLASS: ParadoxNotion.Design.NodeMenuItemColorGradientAttribute
TYPE:  class
TOKEN: 0x2000521
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   hexColorLeft  // 0x10
  public    readonly System.Single                   colorLeftRatio  // 0x18
  public    readonly System.String                   hexColorRight  // 0x20
  public    readonly System.Single                   colorRightRatio  // 0x28
  public    readonly System.Single                   rotateDegree  // 0x2C
METHODS:
  UnityEngine.Color get_colorLeft()
  UnityEngine.Color get_colorRight()
  System.Void .ctor(System.String hexColorLeft, System.Single colorLeftRatio, System.String hexColorRight, System.Single colorRightRatio, System.Single rotateDegree)
END_CLASS

CLASS: ParadoxNotion.Design.NodeCategoryMenuItemColorGradientAttribute
TYPE:  class
TOKEN: 0x2000522
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   hexColorLeft  // 0x10
  public    readonly System.Single                   colorLeftRatio  // 0x18
  public    readonly System.String                   hexColorRight  // 0x20
  public    readonly System.Single                   colorRightRatio  // 0x28
  public    readonly System.Single                   rotateDegree  // 0x2C
METHODS:
  UnityEngine.Color get_colorLeft()
  UnityEngine.Color get_colorRight()
  System.Void .ctor(System.String hexColorLeft, System.Single colorLeftRatio, System.String hexColorRight, System.Single colorRightRatio, System.Single rotateDegree)
END_CLASS

CLASS: ParadoxNotion.Design.HideAttribute
TYPE:  class
TOKEN: 0x2000523
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Design.DrawerAttribute
TYPE:  class
TOKEN: 0x2000524
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Int32 get_priority()
  System.Boolean get_isDecorator()
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Design.HeaderAttribute
TYPE:  class
TOKEN: 0x2000525
EXTENDS: DrawerAttribute
FIELDS:
  public    readonly System.String                   title  // 0x10
METHODS:
  System.Boolean get_isDecorator()
  System.Void .ctor(System.String title)
END_CLASS

CLASS: ParadoxNotion.Design.DimIfDefaultAttribute
TYPE:  class
TOKEN: 0x2000526
EXTENDS: DrawerAttribute
FIELDS:
METHODS:
  System.Boolean get_isDecorator()
  System.Int32 get_priority()
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Design.ShowIfAttribute
TYPE:  class
TOKEN: 0x2000527
EXTENDS: DrawerAttribute
FIELDS:
  public    readonly System.String                   fieldName  // 0x10
  public    readonly System.Int32                    checkValue  // 0x18
METHODS:
  System.Boolean get_isDecorator()
  System.Int32 get_priority()
  System.Void .ctor(System.String fieldName, System.Int32 checkValue)
END_CLASS

CLASS: ParadoxNotion.Design.RequiredFieldAttribute
TYPE:  class
TOKEN: 0x2000528
EXTENDS: DrawerAttribute
FIELDS:
METHODS:
  System.Boolean get_isDecorator()
  System.Int32 get_priority()
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Design.ShowButtonAttribute
TYPE:  class
TOKEN: 0x2000529
EXTENDS: DrawerAttribute
FIELDS:
  public    readonly System.String                   buttonTitle  // 0x10
  public    readonly System.String                   methodName  // 0x18
METHODS:
  System.Boolean get_isDecorator()
  System.Int32 get_priority()
  System.Void .ctor(System.String buttonTitle, System.String methodnameCallback)
END_CLASS

CLASS: ParadoxNotion.Design.CallbackAttribute
TYPE:  class
TOKEN: 0x200052A
EXTENDS: DrawerAttribute
FIELDS:
  public    readonly System.String                   methodName  // 0x10
METHODS:
  System.Boolean get_isDecorator()
  System.Int32 get_priority()
  System.Void .ctor(System.String methodName)
END_CLASS

CLASS: ParadoxNotion.Design.MinValueAttribute
TYPE:  class
TOKEN: 0x200052B
EXTENDS: DrawerAttribute
FIELDS:
  public    readonly System.Single                   min  // 0x10
METHODS:
  System.Int32 get_priority()
  System.Void .ctor(System.Single min)
  System.Void .ctor(System.Int32 min)
END_CLASS

CLASS: ParadoxNotion.Design.DelayedFieldAttribute
TYPE:  class
TOKEN: 0x200052C
EXTENDS: DrawerAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Design.LayerFieldAttribute
TYPE:  class
TOKEN: 0x200052D
EXTENDS: DrawerAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Design.TagFieldAttribute
TYPE:  class
TOKEN: 0x200052E
EXTENDS: DrawerAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Design.TextAreaFieldAttribute
TYPE:  class
TOKEN: 0x200052F
EXTENDS: DrawerAttribute
FIELDS:
  public    readonly System.Int32                    numberOfLines  // 0x10
METHODS:
  System.Void .ctor(System.Int32 numberOfLines)
END_CLASS

CLASS: ParadoxNotion.Design.PopupFieldAttribute
TYPE:  class
TOKEN: 0x2000530
EXTENDS: DrawerAttribute
FIELDS:
  public    readonly System.Object[]                 options  // 0x10
METHODS:
  System.Void .ctor(System.Object[] options)
END_CLASS

CLASS: ParadoxNotion.Design.SliderFieldAttribute
TYPE:  class
TOKEN: 0x2000531
EXTENDS: DrawerAttribute
FIELDS:
  public    readonly System.Single                   min  // 0x10
  public    readonly System.Single                   max  // 0x14
METHODS:
  System.Void .ctor(System.Single min, System.Single max)
  System.Void .ctor(System.Int32 min, System.Int32 max)
END_CLASS

CLASS: ParadoxNotion.Design.ForceObjectFieldAttribute
TYPE:  class
TOKEN: 0x2000532
EXTENDS: DrawerAttribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Design.UndoUtility
TYPE:  class
TOKEN: 0x2000533
FIELDS:
  private   static  System.String                   <lastOperationName>k__BackingField  // 0x0
METHODS:
  System.String get_lastOperationName()
  System.Void set_lastOperationName(System.String value)
  System.Void RecordObject(UnityEngine.Object target, System.String name, System.Boolean forceIgnoreScene)
  System.Void RecordObjectComplete(UnityEngine.Object target, System.String name, System.Boolean forceIgnore)
  System.Void SetDirty(UnityEngine.Object target)
  System.Void RecordObject(UnityEngine.Object target, System.String name, System.Action operation)
  System.Void RecordObjectComplete(UnityEngine.Object target, System.String name, System.Action operation)
  System.String GetLastOperationNameOr(System.String operation)
  System.Void CheckUndo(UnityEngine.Object target, System.String name)
  System.Void CheckDirty(UnityEngine.Object target)
END_CLASS

CLASS: ParadoxNotion.Serialization.DeserializeFromAttribute
TYPE:  class
TOKEN: 0x20004C1
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   previousTypeFullName  // 0x10
METHODS:
  System.Void .ctor(System.String previousTypeFullName)
END_CLASS

CLASS: ParadoxNotion.Serialization.fsRecoveryProcessor`2
TYPE:  class
TOKEN: 0x20004C2
EXTENDS: fsObjectProcessor
FIELDS:
  private   static  System.String                   FIELD_NAME_TYPE  // 0x0
  private   static  System.String                   FIELD_NAME_STATE  // 0x0
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Void OnBeforeDeserialize(System.Type storageType, ParadoxNotion.Serialization.FullSerializer.fsData& data)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.fsUnityObjectConverter
TYPE:  class
TOKEN: 0x20004C5
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Boolean RequestCycleSupport(System.Type storageType)
  System.Boolean RequestInheritanceSupport(System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.IMissingRecoverable
TYPE:  interface
TOKEN: 0x20004C6
FIELDS:
METHODS:
  System.String get_missingType()
  System.Void set_missingType(System.String value)
  System.String get_recoveryState()
  System.Void set_recoveryState(System.String value)
END_CLASS

CLASS: ParadoxNotion.Serialization.ISerializedMethodBaseInfo
TYPE:  interface
TOKEN: 0x20004C7
FIELDS:
METHODS:
  System.Reflection.MethodBase GetMethodBase()
  System.Boolean HasChanged()
END_CLASS

CLASS: ParadoxNotion.Serialization.ISerializedReflectedInfo
TYPE:  interface
TOKEN: 0x20004C8
FIELDS:
METHODS:
  System.Reflection.MemberInfo AsMemberInfo()
  System.String AsString()
END_CLASS

CLASS: ParadoxNotion.Serialization.JSONSerializer
TYPE:  class
TOKEN: 0x20004C9
FIELDS:
  public    static  System.Boolean                  enableCache  // 0x0
  private   static  System.Object                   serializerLock  // 0x8
  private   static  ParadoxNotion.Serialization.FullSerializer.fsSerializerserializer  // 0x10
  private   static  System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData>dataCache  // 0x18
METHODS:
  System.Void .cctor()
  System.Void FlushMem()
  System.Void __FlushDataCache()
  System.String Serialize(System.Type type, System.Object instance, System.Collections.Generic.List<UnityEngine.Object> references, System.Boolean pretyJson)
  T Deserialize(System.String json, System.Collections.Generic.List<UnityEngine.Object> references)
  System.Object Deserialize(System.Type type, System.String json, System.Collections.Generic.List<UnityEngine.Object> references)
  T TryDeserializeOverwrite(T instance, System.String json, System.Collections.Generic.List<UnityEngine.Object> references)
  System.Object TryDeserializeOverwrite(System.Object instance, System.String json, System.Collections.Generic.List<UnityEngine.Object> references)
  System.Object Internal_Deserialize(System.Type type, System.String json, System.Collections.Generic.List<UnityEngine.Object> references, System.Object instance)
  System.Void SerializeAndExecuteNoCycles(System.Type type, System.Object instance, System.Action<System.Object,ParadoxNotion.Serialization.FullSerializer.fsData> call)
  System.Void SerializeAndExecuteNoCycles(System.Type type, System.Object instance, System.Action<System.Object> beforeCall, System.Action<System.Object,ParadoxNotion.Serialization.FullSerializer.fsData> afterCall)
  T Clone(T original)
  System.Object Clone(System.Object original)
  System.Void CopySerialized(System.Object source, System.Object target)
  System.Void ShowData(System.String json, System.String fileName)
  System.String PrettifyJson(System.String json)
END_CLASS

CLASS: ParadoxNotion.Serialization.SerializationPair
TYPE:  class
TOKEN: 0x20004CA
FIELDS:
  public            System.String                   _json  // 0x10
  public            System.Collections.Generic.List<UnityEngine.Object>_references  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.SerializedConstructorInfo
TYPE:  class
TOKEN: 0x20004CB
FIELDS:
  private           System.String                   _baseInfo  // 0x10
  private           System.String                   _paramsInfo  // 0x18
  private           System.Reflection.ConstructorInfo_constructor  // 0x20
  private           System.Boolean                  _hasChanged  // 0x28
METHODS:
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void .ctor()
  System.Void .ctor(System.Reflection.ConstructorInfo constructor)
  System.Reflection.MemberInfo AsMemberInfo()
  System.Reflection.MethodBase GetMethodBase()
  System.Boolean HasChanged()
  System.String AsString()
  System.String ToString()
  System.Reflection.ConstructorInfo op_Implicit(ParadoxNotion.Serialization.SerializedConstructorInfo value)
END_CLASS

CLASS: ParadoxNotion.Serialization.SerializedEventInfo
TYPE:  class
TOKEN: 0x20004CE
FIELDS:
  private           System.String                   _baseInfo  // 0x10
  private           System.Reflection.EventInfo     _event  // 0x18
METHODS:
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void .ctor()
  System.Void .ctor(System.Reflection.EventInfo info)
  System.Reflection.MemberInfo AsMemberInfo()
  System.String AsString()
  System.String ToString()
  System.Reflection.EventInfo op_Implicit(ParadoxNotion.Serialization.SerializedEventInfo value)
END_CLASS

CLASS: ParadoxNotion.Serialization.SerializedFieldInfo
TYPE:  class
TOKEN: 0x20004CF
FIELDS:
  private           System.String                   _baseInfo  // 0x10
  private           System.Reflection.FieldInfo     _field  // 0x18
METHODS:
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void .ctor()
  System.Void .ctor(System.Reflection.FieldInfo info)
  System.Reflection.MemberInfo AsMemberInfo()
  System.String AsString()
  System.String ToString()
  System.Reflection.FieldInfo op_Implicit(ParadoxNotion.Serialization.SerializedFieldInfo value)
END_CLASS

CLASS: ParadoxNotion.Serialization.SerializedMethodInfo
TYPE:  class
TOKEN: 0x20004D0
FIELDS:
  private           System.String                   _baseInfo  // 0x10
  private           System.String                   _paramsInfo  // 0x18
  private           System.String                   _genericArgumentsInfo  // 0x20
  private           System.Reflection.MethodInfo    _method  // 0x28
  private           System.Boolean                  _hasChanged  // 0x30
METHODS:
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void .ctor()
  System.Void .ctor(System.Reflection.MethodInfo method)
  System.Reflection.MemberInfo AsMemberInfo()
  System.Reflection.MethodBase GetMethodBase()
  System.Boolean HasChanged()
  System.String AsString()
  System.String ToString()
  System.Reflection.MethodInfo op_Implicit(ParadoxNotion.Serialization.SerializedMethodInfo value)
END_CLASS

CLASS: ParadoxNotion.Serialization.SerializedTypeInfo
TYPE:  class
TOKEN: 0x20004D3
FIELDS:
  private           System.String                   _baseInfo  // 0x10
  private           System.Type                     _type  // 0x18
METHODS:
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void .ctor()
  System.Void .ctor(System.Type info)
  System.Reflection.MemberInfo AsMemberInfo()
  System.String AsString()
  System.String ToString()
  System.Type op_Implicit(ParadoxNotion.Serialization.SerializedTypeInfo value)
END_CLASS

CLASS: ParadoxNotion.Serialization.SerializedUnityEventInfo
TYPE:  class
TOKEN: 0x20004D4
FIELDS:
  private           System.String                   _baseInfo  // 0x10
  private           System.Reflection.MemberInfo    _memberInfo  // 0x18
METHODS:
  System.Boolean get_isStatic()
  System.Type get_memberType()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
  System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
  System.Void .ctor()
  System.Void .ctor(System.Reflection.FieldInfo info)
  System.Void .ctor(System.Reflection.PropertyInfo info)
  System.Void .ctor(System.Reflection.MemberInfo info)
  System.Reflection.MemberInfo AsMemberInfo()
  System.String AsString()
  System.String ToString()
  System.Reflection.FieldInfo op_Implicit(ParadoxNotion.Serialization.SerializedUnityEventInfo value)
  System.Reflection.PropertyInfo op_Implicit(ParadoxNotion.Serialization.SerializedUnityEventInfo value)
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsForwardAttribute
TYPE:  class
TOKEN: 0x20004D5
EXTENDS: Attribute
FIELDS:
  public            System.String                   MemberName  // 0x10
METHODS:
  System.Void .ctor(System.String memberName)
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsWriteOnlyAttribute
TYPE:  class
TOKEN: 0x20004D6
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsReadOnlyAttribute
TYPE:  class
TOKEN: 0x20004D7
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsIgnoreAttribute
TYPE:  class
TOKEN: 0x20004D8
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsIgnoreInBuildAttribute
TYPE:  class
TOKEN: 0x20004D9
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsSerializeAsAttribute
TYPE:  class
TOKEN: 0x20004DA
EXTENDS: Attribute
FIELDS:
  public    readonly System.String                   Name  // 0x10
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String name)
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsMigrateToAttribute
TYPE:  class
TOKEN: 0x20004DB
EXTENDS: Attribute
FIELDS:
  public    readonly System.Type                     targetType  // 0x10
METHODS:
  System.Void .ctor(System.Type targetType)
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsMigrateVersionsAttribute
TYPE:  class
TOKEN: 0x20004DC
EXTENDS: Attribute
FIELDS:
  public    readonly System.Type[]                   previousTypes  // 0x10
METHODS:
  System.Void .ctor(System.Type[] previousTypes)
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsSerializeAsReference
TYPE:  class
TOKEN: 0x20004DD
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsDeserializeOverwrite
TYPE:  class
TOKEN: 0x20004DE
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsUninitialized
TYPE:  class
TOKEN: 0x20004DF
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsAutoInstance
TYPE:  class
TOKEN: 0x20004E0
EXTENDS: Attribute
FIELDS:
  public    readonly System.Boolean                  makeInstance  // 0x10
METHODS:
  System.Void .ctor(System.Boolean makeInstance)
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsObjectAttribute
TYPE:  class
TOKEN: 0x20004E1
EXTENDS: Attribute
FIELDS:
  public            System.Type                     Converter  // 0x10
  public            System.Type                     Processor  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsBaseConverter
TYPE:  class
TOKEN: 0x20004E2
FIELDS:
  public            ParadoxNotion.Serialization.FullSerializer.fsSerializerSerializer  // 0x10
METHODS:
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Boolean RequestCycleSupport(System.Type storageType)
  System.Boolean RequestInheritanceSupport(System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult FailExpectedType(ParadoxNotion.Serialization.FullSerializer.fsData data, ParadoxNotion.Serialization.FullSerializer.fsDataType[] types)
  ParadoxNotion.Serialization.FullSerializer.fsResult CheckType(ParadoxNotion.Serialization.FullSerializer.fsData data, ParadoxNotion.Serialization.FullSerializer.fsDataType type)
  ParadoxNotion.Serialization.FullSerializer.fsResult CheckKey(ParadoxNotion.Serialization.FullSerializer.fsData data, System.String key, ParadoxNotion.Serialization.FullSerializer.fsData& subitem)
  ParadoxNotion.Serialization.FullSerializer.fsResult CheckKey(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, System.String key, ParadoxNotion.Serialization.FullSerializer.fsData& subitem)
  ParadoxNotion.Serialization.FullSerializer.fsResult SerializeMember(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, System.Type overrideConverterType, System.String name, T value)
  ParadoxNotion.Serialization.FullSerializer.fsResult DeserializeMember(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, System.Type overrideConverterType, System.String name, T& value)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsConverter
TYPE:  class
TOKEN: 0x20004E4
EXTENDS: fsBaseConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsCyclicReferenceManager
TYPE:  class
TOKEN: 0x20004E5
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Object,System.Int32>_objectIds  // 0x10
  private           System.Int32                    _nextId  // 0x18
  private           System.Collections.Generic.Dictionary<System.Int32,System.Object>_marked  // 0x20
  private           System.Int32                    _depth  // 0x28
METHODS:
  System.Void .ctor()
  System.Void Clear()
  System.Boolean Enter()
  System.Boolean Exit()
  System.Object GetReferenceObject(System.Int32 id)
  System.Void AddReferenceWithId(System.Int32 id, System.Object reference)
  System.Int32 GetReferenceId(System.Object item)
  System.Boolean IsReference(System.Object item)
  System.Void MarkSerialized(System.Object item)
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsDataType
TYPE:  struct
TOKEN: 0x20004E7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  ParadoxNotion.Serialization.FullSerializer.fsDataTypeArray  // 0x0
  public    static  ParadoxNotion.Serialization.FullSerializer.fsDataTypeObject  // 0x0
  public    static  ParadoxNotion.Serialization.FullSerializer.fsDataTypeDouble  // 0x0
  public    static  ParadoxNotion.Serialization.FullSerializer.fsDataTypeInt64  // 0x0
  public    static  ParadoxNotion.Serialization.FullSerializer.fsDataTypeBoolean  // 0x0
  public    static  ParadoxNotion.Serialization.FullSerializer.fsDataTypeString  // 0x0
  public    static  ParadoxNotion.Serialization.FullSerializer.fsDataTypeNull  // 0x0
METHODS:
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsData
TYPE:  class
TOKEN: 0x20004E8
FIELDS:
  private           System.Object                   _value  // 0x10
  public    static readonly ParadoxNotion.Serialization.FullSerializer.fsDataTrue  // 0x0
  public    static readonly ParadoxNotion.Serialization.FullSerializer.fsDataFalse  // 0x8
  public    static readonly ParadoxNotion.Serialization.FullSerializer.fsDataNull  // 0x10
METHODS:
  ParadoxNotion.Serialization.FullSerializer.fsDataType get_Type()
  System.Void .ctor()
  System.Void .ctor(System.Boolean boolean)
  System.Void .ctor(System.Double f)
  System.Void .ctor(System.Int64 i)
  System.Void .ctor(System.String str)
  System.Void .ctor(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> dict)
  System.Void .ctor(System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsData> list)
  ParadoxNotion.Serialization.FullSerializer.fsData CreateDictionary()
  ParadoxNotion.Serialization.FullSerializer.fsData CreateList()
  ParadoxNotion.Serialization.FullSerializer.fsData CreateList(System.Int32 capacity)
  System.Void BecomeDictionary()
  ParadoxNotion.Serialization.FullSerializer.fsData Clone()
  System.Boolean get_IsNull()
  System.Boolean get_IsDouble()
  System.Boolean get_IsInt64()
  System.Boolean get_IsBool()
  System.Boolean get_IsString()
  System.Boolean get_IsDictionary()
  System.Boolean get_IsList()
  System.Double get_AsDouble()
  System.Int64 get_AsInt64()
  System.Boolean get_AsBool()
  System.String get_AsString()
  System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> get_AsDictionary()
  System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsData> get_AsList()
  T Cast()
  System.String ToString()
  System.Boolean Equals(System.Object obj)
  System.Boolean Equals(ParadoxNotion.Serialization.FullSerializer.fsData other)
  System.Boolean op_Equality(ParadoxNotion.Serialization.FullSerializer.fsData a, ParadoxNotion.Serialization.FullSerializer.fsData b)
  System.Boolean op_Inequality(ParadoxNotion.Serialization.FullSerializer.fsData a, ParadoxNotion.Serialization.FullSerializer.fsData b)
  System.Int32 GetHashCode()
  System.Void .cctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsDirectConverter
TYPE:  class
TOKEN: 0x20004E9
EXTENDS: fsBaseConverter
FIELDS:
METHODS:
  System.Type get_ModelType()
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsDirectConverter`1
TYPE:  class
TOKEN: 0x20004EA
EXTENDS: fsDirectConverter
FIELDS:
METHODS:
  System.Type get_ModelType()
  ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(TModel model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized)
  ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, TModel& model)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsGlobalConfig
TYPE:  class
TOKEN: 0x20004EB
FIELDS:
  public    static  System.Boolean                  SerializeDefaultValues  // 0x0
  public    static  System.Boolean                  IsCaseSensitive  // 0x1
  public    static  System.Type[]                   IgnoreSerializeAttributes  // 0x8
  public    static  System.Type[]                   SerializeAttributes  // 0x10
  public    static  System.String                   CustomDateTimeFormatString  // 0x18
  public    static  System.Boolean                  Serialize64BitIntegerAsString  // 0x20
  public    static  System.Boolean                  SerializeEnumsAsInteger  // 0x21
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsJsonParser
TYPE:  class
TOKEN: 0x20004EC
FIELDS:
  private           System.Int32                    _start  // 0x10
  private           System.String                   _input  // 0x18
  private   readonly System.Text.StringBuilder       _cachedStringBuilder  // 0x20
METHODS:
  ParadoxNotion.Serialization.FullSerializer.fsResult MakeFailure(System.String message)
  System.Boolean TryMoveNext()
  System.Boolean HasValue()
  System.Boolean HasValue(System.Int32 offset)
  System.Char Character()
  System.Char Character(System.Int32 offset)
  System.Void SkipSpace()
  System.Boolean IsHex(System.Char c)
  System.UInt32 ParseSingleChar(System.Char c1, System.UInt32 multipliyer)
  System.UInt32 ParseUnicode(System.Char c1, System.Char c2, System.Char c3, System.Char c4)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryUnescapeChar(System.Char& escaped)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryParseExact(System.String content)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryParseTrue(ParadoxNotion.Serialization.FullSerializer.fsData& data)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryParseFalse(ParadoxNotion.Serialization.FullSerializer.fsData& data)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryParseNull(ParadoxNotion.Serialization.FullSerializer.fsData& data)
  System.Boolean IsSeparator(System.Char c)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryParseNumber(ParadoxNotion.Serialization.FullSerializer.fsData& data)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryParseString(System.String& str)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryParseArray(ParadoxNotion.Serialization.FullSerializer.fsData& arr)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryParseObject(ParadoxNotion.Serialization.FullSerializer.fsData& obj)
  ParadoxNotion.Serialization.FullSerializer.fsResult RunParse(ParadoxNotion.Serialization.FullSerializer.fsData& data)
  ParadoxNotion.Serialization.FullSerializer.fsResult Parse(System.String input, ParadoxNotion.Serialization.FullSerializer.fsData& data)
  ParadoxNotion.Serialization.FullSerializer.fsData Parse(System.String input)
  System.Void .ctor(System.String input)
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsJsonPrinter
TYPE:  class
TOKEN: 0x20004ED
FIELDS:
METHODS:
  System.Void InsertSpacing(System.IO.TextWriter stream, System.Int32 count)
  System.String EscapeString(System.String str)
  System.Void BuildCompressedString(ParadoxNotion.Serialization.FullSerializer.fsData data, System.IO.TextWriter stream)
  System.Void BuildPrettyString(ParadoxNotion.Serialization.FullSerializer.fsData data, System.IO.TextWriter stream, System.Int32 depth)
  System.String ToJson(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Boolean pretty)
  System.Void PrettyJson(ParadoxNotion.Serialization.FullSerializer.fsData data, System.IO.TextWriter outputStream)
  System.String PrettyJson(ParadoxNotion.Serialization.FullSerializer.fsData data)
  System.Void CompressedJson(ParadoxNotion.Serialization.FullSerializer.fsData data, System.IO.StreamWriter outputStream)
  System.String CompressedJson(ParadoxNotion.Serialization.FullSerializer.fsData data)
  System.String ConvertDoubleToString(System.Double d)
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsMetaProperty
TYPE:  class
TOKEN: 0x20004EE
FIELDS:
  private           System.Reflection.FieldInfo     <Field>k__BackingField  // 0x10
  private           System.String                   <JsonName>k__BackingField  // 0x18
  private           System.Boolean                  <ReadOnly>k__BackingField  // 0x20
  private           System.Boolean                  <WriteOnly>k__BackingField  // 0x21
  private           System.Boolean                  <AutoInstance>k__BackingField  // 0x22
  private           System.Boolean                  <AsReference>k__BackingField  // 0x23
METHODS:
  System.Reflection.FieldInfo get_Field()
  System.Void set_Field(System.Reflection.FieldInfo value)
  System.String get_JsonName()
  System.Void set_JsonName(System.String value)
  System.Type get_StorageType()
  System.String get_MemberName()
  System.Boolean get_ReadOnly()
  System.Void set_ReadOnly(System.Boolean value)
  System.Boolean get_WriteOnly()
  System.Void set_WriteOnly(System.Boolean value)
  System.Boolean get_AutoInstance()
  System.Void set_AutoInstance(System.Boolean value)
  System.Boolean get_AsReference()
  System.Void set_AsReference(System.Boolean value)
  System.Void .ctor(System.Reflection.FieldInfo field)
  System.Object Read(System.Object context)
  System.Void Write(System.Object context, System.Object value)
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsMetaType
TYPE:  class
TOKEN: 0x20004EF
FIELDS:
  private   static  System.Collections.Generic.Dictionary<System.Type,ParadoxNotion.Serialization.FullSerializer.fsMetaType>_metaTypes  // 0x0
  private   static  System.Collections.Generic.Dictionary<System.Type,System.Object>_defaultInstances  // 0x8
  private           ParadoxNotion.Serialization.FullSerializer.fsMetaType.ObjectGeneratorgenerator  // 0x10
  private           System.Type                     <reflectedType>k__BackingField  // 0x18
  private           ParadoxNotion.Serialization.FullSerializer.fsMetaProperty[]<Properties>k__BackingField  // 0x20
  private           System.Boolean                  <DeserializeOverwriteRequest>k__BackingField  // 0x28
METHODS:
  ParadoxNotion.Serialization.FullSerializer.fsMetaType Get(System.Type type)
  System.Void FlushMem()
  System.Type get_reflectedType()
  System.Void set_reflectedType(System.Type value)
  ParadoxNotion.Serialization.FullSerializer.fsMetaProperty[] get_Properties()
  System.Void set_Properties(ParadoxNotion.Serialization.FullSerializer.fsMetaProperty[] value)
  System.Boolean get_DeserializeOverwriteRequest()
  System.Void set_DeserializeOverwriteRequest(System.Boolean value)
  System.Void .ctor(System.Type reflectedType)
  System.Void CollectProperties(System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsMetaProperty> properties, System.Type reflectedType)
  System.Boolean CanSerializeField(System.Reflection.FieldInfo field)
  ParadoxNotion.Serialization.FullSerializer.fsMetaType.ObjectGenerator GetGenerator(System.Type reflectedType)
  System.Boolean HasDefaultConstructor(System.Type reflectedType)
  System.Object GetDefaultInstance()
  System.Object CreateInstance()
  System.Void .cctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor
TYPE:  class
TOKEN: 0x20004F3
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Void OnBeforeSerialize(System.Type storageType, System.Object instance)
  System.Void OnAfterSerialize(System.Type storageType, System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& data)
  System.Void OnBeforeDeserialize(System.Type storageType, ParadoxNotion.Serialization.FullSerializer.fsData& data)
  System.Void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& data)
  System.Void OnAfterDeserialize(System.Type storageType, System.Object instance)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsResult
TYPE:  struct
TOKEN: 0x20004F4
FIELDS:
  private   static readonly System.String[]                 EmptyStringArray  // 0x0
  private           System.Boolean                  _success  // 0x10
  private           System.Collections.Generic.List<System.String>_messages  // 0x18
  public    static  ParadoxNotion.Serialization.FullSerializer.fsResultSuccess  // 0x8
METHODS:
  ParadoxNotion.Serialization.FullSerializer.fsResult Warn(System.String warning)
  ParadoxNotion.Serialization.FullSerializer.fsResult Fail(System.String warning)
  System.Void AddMessage(System.String message)
  System.Void AddMessages(ParadoxNotion.Serialization.FullSerializer.fsResult result)
  ParadoxNotion.Serialization.FullSerializer.fsResult Merge(ParadoxNotion.Serialization.FullSerializer.fsResult other)
  ParadoxNotion.Serialization.FullSerializer.fsResult op_Addition(ParadoxNotion.Serialization.FullSerializer.fsResult a, ParadoxNotion.Serialization.FullSerializer.fsResult b)
  System.Boolean get_Failed()
  System.Boolean get_Succeeded()
  System.Boolean get_HasWarnings()
  ParadoxNotion.Serialization.FullSerializer.fsResult AssertSuccess()
  ParadoxNotion.Serialization.FullSerializer.fsResult AssertSuccessWithoutWarnings()
  System.Exception get_AsException()
  System.Collections.Generic.IEnumerable<System.String> get_RawMessages()
  System.String get_FormattedMessages()
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.fsSerializer
TYPE:  class
TOKEN: 0x20004F5
FIELDS:
  public    static  System.String                   KEY_OBJECT_REFERENCE  // 0x0
  public    static  System.String                   KEY_OBJECT_DEFINITION  // 0x0
  public    static  System.String                   KEY_INSTANCE_TYPE  // 0x0
  public    static  System.String                   KEY_VERSION  // 0x0
  public    static  System.String                   KEY_CONTENT  // 0x0
  private           System.Collections.Generic.Dictionary<System.Type,ParadoxNotion.Serialization.FullSerializer.fsBaseConverter>_cachedOverrideConverterInstances  // 0x10
  private           System.Collections.Generic.Dictionary<System.Type,ParadoxNotion.Serialization.FullSerializer.fsBaseConverter>_cachedConverters  // 0x18
  private   readonly System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsConverter>_availableConverters  // 0x20
  private   readonly System.Collections.Generic.Dictionary<System.Type,ParadoxNotion.Serialization.FullSerializer.fsDirectConverter>_availableDirectConverters  // 0x28
  private   readonly System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor>_processors  // 0x30
  private           System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor>>_cachedProcessors  // 0x38
  private           ParadoxNotion.Serialization.FullSerializer.fsCyclicReferenceManager_references  // 0x40
  private           ParadoxNotion.Serialization.FullSerializer.fsSerializer.fsLazyCycleDefinitionWriter_lazyReferenceWriter  // 0x48
  private           System.Collections.Generic.Stack<ParadoxNotion.Serialization.FullSerializer.ISerializationCollector>_collectors  // 0x50
  private           System.Int32                    _collectableDepth  // 0x58
  private           System.Collections.Generic.List<UnityEngine.Object><ReferencesDatabase>k__BackingField  // 0x60
  private           System.Boolean                  <IgnoreSerializeCycleReferences>k__BackingField  // 0x68
  private           System.Action<System.Object>    onBeforeObjectSerialized  // 0x70
  private           System.Action<System.Object,ParadoxNotion.Serialization.FullSerializer.fsData>onAfterObjectSerialized  // 0x78
METHODS:
  System.Boolean IsReservedKeyword(System.String key)
  System.Void RemoveMetaData(ParadoxNotion.Serialization.FullSerializer.fsData& data)
  System.Void EnsureDictionary(ParadoxNotion.Serialization.FullSerializer.fsData& data)
  System.Boolean IsObjectReference(ParadoxNotion.Serialization.FullSerializer.fsData data)
  System.Boolean IsObjectDefinition(ParadoxNotion.Serialization.FullSerializer.fsData data)
  System.Boolean IsVersioned(ParadoxNotion.Serialization.FullSerializer.fsData data)
  System.Boolean IsTypeSpecified(ParadoxNotion.Serialization.FullSerializer.fsData data)
  System.Boolean IsWrappedData(ParadoxNotion.Serialization.FullSerializer.fsData data)
  System.Void Invoke_OnBeforeSerialize(System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor> processors, System.Type storageType, System.Object instance)
  System.Void Invoke_OnAfterSerialize(System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor> processors, System.Type storageType, System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& data)
  System.Void Invoke_OnBeforeDeserialize(System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor> processors, System.Type storageType, ParadoxNotion.Serialization.FullSerializer.fsData& data)
  System.Void Invoke_OnBeforeDeserializeAfterInstanceCreation(System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor> processors, System.Type storageType, System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& data)
  System.Void Invoke_OnAfterDeserialize(System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor> processors, System.Type storageType, System.Object instance)
  System.Collections.Generic.List<UnityEngine.Object> get_ReferencesDatabase()
  System.Void set_ReferencesDatabase(System.Collections.Generic.List<UnityEngine.Object> value)
  System.Boolean get_IgnoreSerializeCycleReferences()
  System.Void set_IgnoreSerializeCycleReferences(System.Boolean value)
  System.Void add_onBeforeObjectSerialized(System.Action<System.Object> value)
  System.Void remove_onBeforeObjectSerialized(System.Action<System.Object> value)
  System.Void add_onAfterObjectSerialized(System.Action<System.Object,ParadoxNotion.Serialization.FullSerializer.fsData> value)
  System.Void remove_onAfterObjectSerialized(System.Action<System.Object,ParadoxNotion.Serialization.FullSerializer.fsData> value)
  System.Void .ctor()
  System.Void PurgeTemporaryData()
  System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor> GetProcessors(System.Type type)
  System.Void AddConverter(ParadoxNotion.Serialization.FullSerializer.fsBaseConverter converter)
  ParadoxNotion.Serialization.FullSerializer.fsBaseConverter GetConverter(System.Type type, System.Type overrideConverterType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Type storageType, System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& data)
  ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Type storageType, System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& data, System.Type overrideConverterType)
  ParadoxNotion.Serialization.FullSerializer.fsResult Internal_Serialize(System.Type storageType, System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& data, System.Type overrideConverterType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType, System.Object& result)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType, System.Object& result, System.Type overrideConverterType)
  ParadoxNotion.Serialization.FullSerializer.fsResult Internal_Deserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType, System.Object& result, System.Type overrideConverterType)
  System.Void TryPush(System.Object o)
  System.Void TryPop(System.Object o)
  System.Void TrySerializeVersioning(System.Object currentInstance, ParadoxNotion.Serialization.FullSerializer.fsData& data)
  System.Void TryDeserializeVersioning(System.Object& currentInstance, ParadoxNotion.Serialization.FullSerializer.fsData& currentData)
  System.Void TryDeserializeMigration(System.Object& currentInstance, ParadoxNotion.Serialization.FullSerializer.fsData& currentData, System.Type previousType, System.Object previousInstance)
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.IMigratable
TYPE:  interface
TOKEN: 0x20004F8
FIELDS:
METHODS:
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.IMigratable`1
TYPE:  interface
TOKEN: 0x20004F9
FIELDS:
METHODS:
  System.Void Migrate(T model)
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.ISerializationCollector
TYPE:  interface
TOKEN: 0x20004FA
FIELDS:
METHODS:
  System.Void OnPush(ParadoxNotion.Serialization.FullSerializer.ISerializationCollector parent)
  System.Void OnCollect(ParadoxNotion.Serialization.FullSerializer.ISerializationCollectable child, System.Int32 depth)
  System.Void OnPop(ParadoxNotion.Serialization.FullSerializer.ISerializationCollector parent)
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.ISerializationCollectable
TYPE:  interface
TOKEN: 0x20004FB
FIELDS:
METHODS:
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.fsArrayConverter
TYPE:  class
TOKEN: 0x20004FC
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Boolean RequestCycleSupport(System.Type storageType)
  System.Boolean RequestInheritanceSupport(System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.fsDictionaryConverter
TYPE:  class
TOKEN: 0x20004FD
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance_, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance_, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.fsEnumConverter
TYPE:  class
TOKEN: 0x20004FE
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Boolean RequestCycleSupport(System.Type storageType)
  System.Boolean RequestInheritanceSupport(System.Type storageType)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Boolean ArrayContains(T[] values, T value)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.fsForwardConverter
TYPE:  class
TOKEN: 0x20004FF
EXTENDS: fsConverter
FIELDS:
  private           System.String                   _memberName  // 0x18
METHODS:
  System.Void .ctor(ParadoxNotion.Serialization.FullSerializer.fsForwardAttribute attribute)
  System.Boolean CanProcess(System.Type type)
  ParadoxNotion.Serialization.FullSerializer.fsResult GetProperty(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsMetaProperty& property)
  ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.fsListConverter
TYPE:  class
TOKEN: 0x2000500
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance_, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance_, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.fsPrimitiveConverter
TYPE:  class
TOKEN: 0x2000501
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Boolean RequestCycleSupport(System.Type storageType)
  System.Boolean RequestInheritanceSupport(System.Type storageType)
  System.Boolean UseBool(System.Type type)
  System.Boolean UseInt64(System.Type type)
  System.Boolean UseDouble(System.Type type)
  System.Boolean UseString(System.Type type)
  ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData storage, System.Object& instance, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.fsReflectedConverter
TYPE:  class
TOKEN: 0x2000502
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.fsTypeConverter
TYPE:  class
TOKEN: 0x2000503
EXTENDS: fsConverter
FIELDS:
METHODS:
  System.Boolean CanProcess(System.Type type)
  System.Boolean RequestCycleSupport(System.Type type)
  System.Boolean RequestInheritanceSupport(System.Type type)
  ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType)
  ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters.AnimationCurve_DirectConverter
TYPE:  class
TOKEN: 0x2000504
EXTENDS: fsDirectConverter`1
FIELDS:
METHODS:
  ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.AnimationCurve model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized)
  ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.AnimationCurve& model)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters.Bounds_DirectConverter
TYPE:  class
TOKEN: 0x2000505
EXTENDS: fsDirectConverter`1
FIELDS:
METHODS:
  ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.Bounds model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized)
  ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.Bounds& model)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters.Gradient_DirectConverter
TYPE:  class
TOKEN: 0x2000506
EXTENDS: fsDirectConverter`1
FIELDS:
METHODS:
  ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.Gradient model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized)
  ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.Gradient& model)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters.GUIStyleState_DirectConverter
TYPE:  class
TOKEN: 0x2000507
EXTENDS: fsDirectConverter`1
FIELDS:
METHODS:
  ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.GUIStyleState model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized)
  ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.GUIStyleState& model)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters.GUIStyle_DirectConverter
TYPE:  class
TOKEN: 0x2000508
EXTENDS: fsDirectConverter`1
FIELDS:
METHODS:
  ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.GUIStyle model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized)
  ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.GUIStyle& model)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters.Keyframe_DirectConverter
TYPE:  class
TOKEN: 0x2000509
EXTENDS: fsDirectConverter`1
FIELDS:
METHODS:
  ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.Keyframe model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized)
  ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.Keyframe& model)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters.LayerMask_DirectConverter
TYPE:  class
TOKEN: 0x200050A
EXTENDS: fsDirectConverter`1
FIELDS:
METHODS:
  ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.LayerMask model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized)
  ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.LayerMask& model)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters.RectOffset_DirectConverter
TYPE:  class
TOKEN: 0x200050B
EXTENDS: fsDirectConverter`1
FIELDS:
METHODS:
  ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.RectOffset model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized)
  ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.RectOffset& model)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters.Rect_DirectConverter
TYPE:  class
TOKEN: 0x200050C
EXTENDS: fsDirectConverter`1
FIELDS:
METHODS:
  ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.Rect model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized)
  ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.Rect& model)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters.Vector2Int_DirectConverter
TYPE:  class
TOKEN: 0x200050D
EXTENDS: fsDirectConverter`1
FIELDS:
METHODS:
  ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.Vector2Int model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized)
  ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.Vector2Int& model)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters.Vector2_DirectConverter
TYPE:  class
TOKEN: 0x200050E
EXTENDS: fsDirectConverter`1
FIELDS:
METHODS:
  ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.Vector2 model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized)
  ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.Vector2& model)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters.Vector3Int_DirectConverter
TYPE:  class
TOKEN: 0x200050F
EXTENDS: fsDirectConverter`1
FIELDS:
METHODS:
  ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.Vector3Int model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized)
  ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.Vector3Int& model)
  System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Services.EventRouter
TYPE:  class
TOKEN: 0x20004AD
EXTENDS: MonoBehaviour
FIELDS:
  private           ParadoxNotion.Services.EventRouterAnimatorMove_routerAnimatorMove  // 0x18
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData>onPointerEnter  // 0x20
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData>onPointerExit  // 0x28
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData>onPointerDown  // 0x30
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData>onPointerUp  // 0x38
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData>onPointerClick  // 0x40
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData>onDrag  // 0x48
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData>onDrop  // 0x50
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData>onScroll  // 0x58
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData>onUpdateSelected  // 0x60
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData>onSelect  // 0x68
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData>onDeselect  // 0x70
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.AxisEventData>onMove  // 0x78
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData>onSubmit  // 0x80
  private           ParadoxNotion.Services.EventRouter.EventDelegateonMouseDown  // 0x88
  private           ParadoxNotion.Services.EventRouter.EventDelegateonMouseDrag  // 0x90
  private           ParadoxNotion.Services.EventRouter.EventDelegateonMouseEnter  // 0x98
  private           ParadoxNotion.Services.EventRouter.EventDelegateonMouseExit  // 0xA0
  private           ParadoxNotion.Services.EventRouter.EventDelegateonMouseOver  // 0xA8
  private           ParadoxNotion.Services.EventRouter.EventDelegateonMouseUp  // 0xB0
  private           ParadoxNotion.Services.EventRouter.EventDelegateonEnable  // 0xB8
  private           ParadoxNotion.Services.EventRouter.EventDelegateonDisable  // 0xC0
  private           ParadoxNotion.Services.EventRouter.EventDelegateonDestroy  // 0xC8
  private           ParadoxNotion.Services.EventRouter.EventDelegateonTransformChildrenChanged  // 0xD0
  private           ParadoxNotion.Services.EventRouter.EventDelegateonTransformParentChanged  // 0xD8
  private           ParadoxNotion.Services.EventRouter.EventDelegate<System.Int32>onAnimatorIK  // 0xE0
  private           ParadoxNotion.Services.EventRouter.EventDelegateonBecameInvisible  // 0xE8
  private           ParadoxNotion.Services.EventRouter.EventDelegateonBecameVisible  // 0xF0
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.ControllerColliderHit>onControllerColliderHit  // 0xF8
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.GameObject>onParticleCollision  // 0x100
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision>onCollisionEnter  // 0x108
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision>onCollisionExit  // 0x110
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision>onCollisionStay  // 0x118
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D>onCollisionEnter2D  // 0x120
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D>onCollisionExit2D  // 0x128
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D>onCollisionStay2D  // 0x130
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider>onTriggerEnter  // 0x138
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider>onTriggerExit  // 0x140
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider>onTriggerStay  // 0x148
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D>onTriggerEnter2D  // 0x150
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D>onTriggerExit2D  // 0x158
  private           ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D>onTriggerStay2D  // 0x160
  private           System.Action<UnityEngine.RenderTexture,UnityEngine.RenderTexture>onRenderImage  // 0x168
  private           ParadoxNotion.Services.EventRouter.EventDelegateonDrawGizmos  // 0x170
  private           ParadoxNotion.Services.EventRouter.CustomEventDelegateonCustomEvent  // 0x178
METHODS:
  System.Void add_onPointerEnter(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value)
  System.Void remove_onPointerEnter(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value)
  System.Void add_onPointerExit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value)
  System.Void remove_onPointerExit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value)
  System.Void add_onPointerDown(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value)
  System.Void remove_onPointerDown(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value)
  System.Void add_onPointerUp(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value)
  System.Void remove_onPointerUp(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value)
  System.Void add_onPointerClick(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value)
  System.Void remove_onPointerClick(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value)
  System.Void add_onDrag(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value)
  System.Void remove_onDrag(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value)
  System.Void add_onDrop(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value)
  System.Void remove_onDrop(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value)
  System.Void add_onScroll(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value)
  System.Void remove_onScroll(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value)
  System.Void add_onUpdateSelected(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> value)
  System.Void remove_onUpdateSelected(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> value)
  System.Void add_onSelect(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> value)
  System.Void remove_onSelect(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> value)
  System.Void add_onDeselect(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> value)
  System.Void remove_onDeselect(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> value)
  System.Void add_onMove(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.AxisEventData> value)
  System.Void remove_onMove(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.AxisEventData> value)
  System.Void add_onSubmit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> value)
  System.Void remove_onSubmit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> value)
  System.Void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void UnityEngine.EventSystems.IDragHandler.OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void UnityEngine.EventSystems.IDropHandler.OnDrop(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void UnityEngine.EventSystems.IScrollHandler.OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void UnityEngine.EventSystems.IUpdateSelectedHandler.OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void UnityEngine.EventSystems.ISelectHandler.OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void UnityEngine.EventSystems.IDeselectHandler.OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void UnityEngine.EventSystems.IMoveHandler.OnMove(UnityEngine.EventSystems.AxisEventData eventData)
  System.Void UnityEngine.EventSystems.ISubmitHandler.OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
  System.Void add_onMouseDown(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void remove_onMouseDown(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void add_onMouseDrag(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void remove_onMouseDrag(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void add_onMouseEnter(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void remove_onMouseEnter(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void add_onMouseExit(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void remove_onMouseExit(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void add_onMouseOver(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void remove_onMouseOver(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void add_onMouseUp(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void remove_onMouseUp(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void OnMouseDown()
  System.Void OnMouseDrag()
  System.Void OnMouseEnter()
  System.Void OnMouseExit()
  System.Void OnMouseOver()
  System.Void OnMouseUp()
  System.Void add_onEnable(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void remove_onEnable(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void add_onDisable(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void remove_onDisable(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void add_onDestroy(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void remove_onDestroy(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void add_onTransformChildrenChanged(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void remove_onTransformChildrenChanged(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void add_onTransformParentChanged(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void remove_onTransformParentChanged(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void OnTransformChildrenChanged()
  System.Void OnTransformParentChanged()
  System.Void add_onAnimatorIK(ParadoxNotion.Services.EventRouter.EventDelegate<System.Int32> value)
  System.Void remove_onAnimatorIK(ParadoxNotion.Services.EventRouter.EventDelegate<System.Int32> value)
  System.Void add_onAnimatorMove(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void remove_onAnimatorMove(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void OnAnimatorIK(System.Int32 layerIndex)
  System.Void add_onBecameInvisible(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void remove_onBecameInvisible(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void add_onBecameVisible(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void remove_onBecameVisible(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void OnBecameInvisible()
  System.Void OnBecameVisible()
  System.Void add_onControllerColliderHit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.ControllerColliderHit> value)
  System.Void remove_onControllerColliderHit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.ControllerColliderHit> value)
  System.Void add_onParticleCollision(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.GameObject> value)
  System.Void remove_onParticleCollision(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.GameObject> value)
  System.Void OnControllerColliderHit(UnityEngine.ControllerColliderHit hit)
  System.Void OnParticleCollision(UnityEngine.GameObject other)
  System.Void add_onCollisionEnter(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision> value)
  System.Void remove_onCollisionEnter(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision> value)
  System.Void add_onCollisionExit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision> value)
  System.Void remove_onCollisionExit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision> value)
  System.Void add_onCollisionStay(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision> value)
  System.Void remove_onCollisionStay(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision> value)
  System.Void OnCollisionEnter(UnityEngine.Collision collisionInfo)
  System.Void OnCollisionExit(UnityEngine.Collision collisionInfo)
  System.Void OnCollisionStay(UnityEngine.Collision collisionInfo)
  System.Void add_onCollisionEnter2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D> value)
  System.Void remove_onCollisionEnter2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D> value)
  System.Void add_onCollisionExit2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D> value)
  System.Void remove_onCollisionExit2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D> value)
  System.Void add_onCollisionStay2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D> value)
  System.Void remove_onCollisionStay2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D> value)
  System.Void OnCollisionEnter2D(UnityEngine.Collision2D collisionInfo)
  System.Void OnCollisionExit2D(UnityEngine.Collision2D collisionInfo)
  System.Void OnCollisionStay2D(UnityEngine.Collision2D collisionInfo)
  System.Void add_onTriggerEnter(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider> value)
  System.Void remove_onTriggerEnter(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider> value)
  System.Void add_onTriggerExit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider> value)
  System.Void remove_onTriggerExit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider> value)
  System.Void add_onTriggerStay(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider> value)
  System.Void remove_onTriggerStay(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider> value)
  System.Void OnTriggerEnter(UnityEngine.Collider other)
  System.Void OnTriggerExit(UnityEngine.Collider other)
  System.Void OnTriggerStay(UnityEngine.Collider other)
  System.Void add_onTriggerEnter2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D> value)
  System.Void remove_onTriggerEnter2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D> value)
  System.Void add_onTriggerExit2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D> value)
  System.Void remove_onTriggerExit2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D> value)
  System.Void add_onTriggerStay2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D> value)
  System.Void remove_onTriggerStay2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D> value)
  System.Void OnTriggerEnter2D(UnityEngine.Collider2D other)
  System.Void OnTriggerExit2D(UnityEngine.Collider2D other)
  System.Void OnTriggerStay2D(UnityEngine.Collider2D other)
  System.Void add_onRenderImage(System.Action<UnityEngine.RenderTexture,UnityEngine.RenderTexture> value)
  System.Void remove_onRenderImage(System.Action<UnityEngine.RenderTexture,UnityEngine.RenderTexture> value)
  System.Void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
  System.Void add_onDrawGizmos(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void remove_onDrawGizmos(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void OnDrawGizmos()
  System.Void add_onCustomEvent(ParadoxNotion.Services.EventRouter.CustomEventDelegate value)
  System.Void remove_onCustomEvent(ParadoxNotion.Services.EventRouter.CustomEventDelegate value)
  System.Void InvokeCustomEvent(System.String name, System.Object value, System.Object sender)
  System.Void InvokeCustomEvent(System.String name, T value, System.Object sender)
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Services.EventRouterAnimatorMove
TYPE:  class
TOKEN: 0x20004B1
EXTENDS: MonoBehaviour
FIELDS:
  private           ParadoxNotion.Services.EventRouter.EventDelegateonAnimatorMove  // 0x18
METHODS:
  System.Void add_onAnimatorMove(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void remove_onAnimatorMove(ParadoxNotion.Services.EventRouter.EventDelegate value)
  System.Void OnAnimatorMove()
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Services.Logger
TYPE:  class
TOKEN: 0x20004B2
FIELDS:
  private   static  System.Collections.Generic.List<ParadoxNotion.Services.Logger.LogHandler>subscribers  // 0x0
METHODS:
  System.Void AddListener(ParadoxNotion.Services.Logger.LogHandler callback)
  System.Void RemoveListener(ParadoxNotion.Services.Logger.LogHandler callback)
  System.Void Log(System.Object message, System.String tag, System.Object context)
  System.Void LogWarning(System.Object message, System.String tag, System.Object context)
  System.Void LogError(System.Object message, System.String tag, System.Object context)
  System.Void LogException(System.Exception exception, System.String tag, System.Object context)
  System.Void Internal_Log(UnityEngine.LogType type, System.Object message, System.String tag, System.Object context)
  System.Void ForwardToUnity(UnityEngine.LogType type, System.Object message, System.String tag, System.Object context)
  System.Void .cctor()
END_CLASS

CLASS: ParadoxNotion.Services.MonoManager
TYPE:  class
TOKEN: 0x20004B5
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Action                   onUpdate  // 0x18
  private           System.Action                   onLateUpdate  // 0x20
  private           System.Action                   onFixedUpdate  // 0x28
  private           System.Action                   onApplicationQuit  // 0x30
  private           System.Action<System.Boolean>   onApplicationPause  // 0x38
  private           System.Action                   onGUI  // 0x40
  private   static  System.Boolean                  isQuiting  // 0x0
  private   static  ParadoxNotion.Services.MonoManager_current  // 0x8
METHODS:
  System.Void add_onUpdate(System.Action value)
  System.Void remove_onUpdate(System.Action value)
  System.Void add_onLateUpdate(System.Action value)
  System.Void remove_onLateUpdate(System.Action value)
  System.Void add_onFixedUpdate(System.Action value)
  System.Void remove_onFixedUpdate(System.Action value)
  System.Void add_onApplicationQuit(System.Action value)
  System.Void remove_onApplicationQuit(System.Action value)
  System.Void add_onApplicationPause(System.Action<System.Boolean> value)
  System.Void remove_onApplicationPause(System.Action<System.Boolean> value)
  System.Void add_onGUI(System.Action value)
  System.Void remove_onGUI(System.Action value)
  ParadoxNotion.Services.MonoManager get_current()
  System.Void Purge()
  System.Void Create()
  System.Void AddUpdateCall(ParadoxNotion.Services.MonoManager.UpdateMode mode, System.Action call)
  System.Void RemoveUpdateCall(ParadoxNotion.Services.MonoManager.UpdateMode mode, System.Action call)
  System.Void Awake()
  System.Void OnApplicationQuit()
  System.Void OnApplicationPause(System.Boolean isPause)
  System.Void Update()
  System.Void LateUpdate()
  System.Void FixedUpdate()
  System.Void .ctor()
END_CLASS

CLASS: ParadoxNotion.Services.Threader
TYPE:  class
TOKEN: 0x20004B7
FIELDS:
  private   static  System.Boolean                  <applicationIsPlaying>k__BackingField  // 0x0
METHODS:
  System.Void .cctor()
  System.Boolean get_applicationIsPlaying()
  System.Void set_applicationIsPlaying(System.Boolean value)
  System.Boolean get_isMainThread()
  System.Void ManuallySyncIsPlaying()
  System.Threading.Thread StartAction(System.Threading.Thread thread, System.Action function, System.Action callback)
  System.Threading.Thread StartAction(System.Threading.Thread thread, System.Action<T1> function, T1 parameter1, System.Action callback)
  System.Threading.Thread StartAction(System.Threading.Thread thread, System.Action<T1,T2> function, T1 parameter1, T2 parameter2, System.Action callback)
  System.Threading.Thread StartAction(System.Threading.Thread thread, System.Action<T1,T2,T3> function, T1 parameter1, T2 parameter2, T3 parameter3, System.Action callback)
  System.Threading.Thread StartFunction(System.Threading.Thread thread, System.Func<TResult> function, System.Action<TResult> callback)
  System.Threading.Thread StartFunction(System.Threading.Thread thread, System.Func<T1,TResult> function, T1 parameter1, System.Action<TResult> callback)
  System.Threading.Thread StartFunction(System.Threading.Thread thread, System.Func<T1,T2,TResult> function, T1 parameter1, T2 parameter2, System.Action<TResult> callback)
  System.Threading.Thread StartFunction(System.Threading.Thread thread, System.Func<T1,T2,T3,TResult> function, T1 parameter1, T2 parameter2, T3 parameter3, System.Action<TResult> callback)
  System.Void Begin(System.Threading.Thread thread, System.Action callback)
  System.Collections.IEnumerator ThreadMonitor(System.Threading.Thread thread, System.Action callback)
END_CLASS

