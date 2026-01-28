// ========================================================
// Dumped by @desirepro
// Assembly: ParadoxNotion.dll
// Classes:  1331
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class SetEnumFlag : ActionTask
    {
        // Fields
        public readonly NodeCanvas.Framework.Internal.BBObjectParameter Variable;        // 0x68
        public readonly NodeCanvas.Framework.Internal.BBObjectParameter Flag;        // 0x70
        public readonly NodeCanvas.Framework.BBParameter<System.Boolean> Clear;        // 0x78

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000003
    public class CheckEnumFlag : ConditionTask
    {
        // Fields
        public readonly NodeCanvas.Framework.Internal.BBObjectParameter Variable;        // 0x68
        public readonly NodeCanvas.Framework.Internal.BBObjectParameter Flag;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public struct ReturnData
    {
        // Fields
        private FlowCanvas.FlowReturn <returnCall>k__BackingField;        // 0x10
        private System.Type <returnType>k__BackingField;        // 0x18

        // Methods
        private FlowCanvas.FlowReturn get_returnCall() { }
        private System.Void set_returnCall(FlowCanvas.FlowReturn value) { }
        private System.Type get_returnType() { }
        private System.Void set_returnType(System.Type value) { }
        private System.Void .ctor(FlowCanvas.FlowReturn call, System.Type type) { }

    }

    // TypeToken: 0x2000015
    public class ContextDefinedInputsAttribute : Attribute
    {
        // Fields
        public readonly System.Type[] types;        // 0x10

        // Methods
        private System.Void .ctor(System.Type[] types) { }

    }

    // TypeToken: 0x2000016
    public class ContextDefinedOutputsAttribute : Attribute
    {
        // Fields
        public readonly System.Type[] types;        // 0x10

        // Methods
        private System.Void .ctor(System.Type[] types) { }

    }

    // TypeToken: 0x2000017
    public class HasRefreshButtonAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000018
    public class GatherPortsCallbackAttribute : CallbackAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000026
    public struct BindStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static FlowCanvas.Port.BindStatus Valid;        // 0x0
        public static FlowCanvas.Port.BindStatus Missing;        // 0x0
        public static FlowCanvas.Port.BindStatus InvalidCast;        // 0x0

    }

    // TypeToken: 0x200002F
    public class CustomConverter : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private FlowCanvas.ValueHandler<System.Object> Invoke(System.Type sourceType, System.Type targetType, FlowCanvas.ValueHandler<System.Object> func) { }
        private System.IAsyncResult BeginInvoke(System.Type sourceType, System.Type targetType, FlowCanvas.ValueHandler<System.Object> func, System.AsyncCallback callback, System.Object object) { }
        private FlowCanvas.ValueHandler<System.Object> EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000030
    public class CustomCanConvert : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Nullable<System.Boolean> Invoke(System.Type sourceType, System.Type targetType) { }
        private System.IAsyncResult BeginInvoke(System.Type sourceType, System.Type targetType, System.AsyncCallback callback, System.Object object) { }
        private System.Nullable<System.Boolean> EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000050
    public struct TargetMode
    {
        // Fields
        public System.Int32 value__;        // 0x0
        public static FlowCanvas.Nodes.RouterEventNode.TargetMode<T> SingleTarget;        // 0x0
        public static FlowCanvas.Nodes.RouterEventNode.TargetMode<T> MultipleTargets;        // 0x0

    }

    // TypeToken: 0x200005E
    public struct ButtonKeys
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static FlowCanvas.Nodes.MouseEvents.ButtonKeys Left;        // 0x0
        public static FlowCanvas.Nodes.MouseEvents.ButtonKeys Right;        // 0x0
        public static FlowCanvas.Nodes.MouseEvents.ButtonKeys Middle;        // 0x0

    }

    // TypeToken: 0x2000060
    public struct ButtonKeys
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static FlowCanvas.Nodes.MousePickEvent.ButtonKeys Left;        // 0x0
        public static FlowCanvas.Nodes.MousePickEvent.ButtonKeys Right;        // 0x0
        public static FlowCanvas.Nodes.MousePickEvent.ButtonKeys Middle;        // 0x0

    }

    // TypeToken: 0x200018B
    public struct InvocationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static FlowCanvas.Nodes.LatentActionNodeBase.InvocationMode QueueCalls;        // 0x0
        public static FlowCanvas.Nodes.LatentActionNodeBase.InvocationMode FilterCalls;        // 0x0

    }

    // TypeToken: 0x200018C
    public struct RoutineData
    {
        // Fields
        public System.Collections.IEnumerator enumerator;        // 0x10
        public FlowCanvas.Flow flow;        // 0x18

        // Methods
        private System.Void .ctor(System.Collections.IEnumerator enumerator, FlowCanvas.Flow flow) { }

    }

    // TypeToken: 0x20001D7
    public class DelegateEventCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object[] args) { }
        private System.IAsyncResult BeginInvoke(System.Object[] args, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001DA
    public class UnityEventCallback : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object[] args) { }
        private System.IAsyncResult BeginInvoke(System.Object[] args, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001EE
    public struct AccessMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static FlowCanvas.Nodes.ReflectedFieldNodeWrapper.AccessMode GetField;        // 0x0
        public static FlowCanvas.Nodes.ReflectedFieldNodeWrapper.AccessMode SetField;        // 0x0

    }

    // TypeToken: 0x2000274
    public class DerivedSerializationData
    {
        // Fields
        public System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition> inputDefinitions;        // 0x10
        public System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition> outputDefinitions;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002FB
    public struct BoolSetModes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Tasks.Actions.SetBoolean.BoolSetModes False;        // 0x0
        public static NodeCanvas.Tasks.Actions.SetBoolean.BoolSetModes True;        // 0x0
        public static NodeCanvas.Tasks.Actions.SetBoolean.BoolSetModes Toggle;        // 0x0

    }

    // TypeToken: 0x2000322
    public struct SetActiveMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Tasks.Actions.SetObjectActive.SetActiveMode Deactivate;        // 0x0
        public static NodeCanvas.Tasks.Actions.SetObjectActive.SetActiveMode Activate;        // 0x0
        public static NodeCanvas.Tasks.Actions.SetObjectActive.SetActiveMode Toggle;        // 0x0

    }

    // TypeToken: 0x2000324
    public struct SetEnableMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Tasks.Actions.SetObjectEnabled.SetEnableMode Disable;        // 0x0
        public static NodeCanvas.Tasks.Actions.SetObjectEnabled.SetEnableMode Enable;        // 0x0
        public static NodeCanvas.Tasks.Actions.SetObjectEnabled.SetEnableMode Toggle;        // 0x0

    }

    // TypeToken: 0x2000326
    public struct SetVisibleMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Tasks.Actions.SetObjectVisibility.SetVisibleMode Hide;        // 0x0
        public static NodeCanvas.Tasks.Actions.SetObjectVisibility.SetVisibleMode Show;        // 0x0
        public static NodeCanvas.Tasks.Actions.SetObjectVisibility.SetVisibleMode Toggle;        // 0x0

    }

    // TypeToken: 0x200032B
    public struct ButtonKeys
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Tasks.Actions.WaitMousePick.ButtonKeys Left;        // 0x0
        public static NodeCanvas.Tasks.Actions.WaitMousePick.ButtonKeys Right;        // 0x0
        public static NodeCanvas.Tasks.Actions.WaitMousePick.ButtonKeys Middle;        // 0x0

    }

    // TypeToken: 0x200032D
    public struct ButtonKeys
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Tasks.Actions.WaitMousePick2D.ButtonKeys Left;        // 0x0
        public static NodeCanvas.Tasks.Actions.WaitMousePick2D.ButtonKeys Right;        // 0x0
        public static NodeCanvas.Tasks.Actions.WaitMousePick2D.ButtonKeys Middle;        // 0x0

    }

    // TypeToken: 0x200032F
    public struct TransformMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Tasks.Actions.CurveTransformTween.TransformMode Position;        // 0x0
        public static NodeCanvas.Tasks.Actions.CurveTransformTween.TransformMode Rotation;        // 0x0
        public static NodeCanvas.Tasks.Actions.CurveTransformTween.TransformMode Scale;        // 0x0

    }

    // TypeToken: 0x2000330
    public struct TweenMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Tasks.Actions.CurveTransformTween.TweenMode Absolute;        // 0x0
        public static NodeCanvas.Tasks.Actions.CurveTransformTween.TweenMode Additive;        // 0x0

    }

    // TypeToken: 0x2000331
    public struct PlayMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Tasks.Actions.CurveTransformTween.PlayMode Normal;        // 0x0
        public static NodeCanvas.Tasks.Actions.CurveTransformTween.PlayMode PingPong;        // 0x0

    }

    // TypeToken: 0x2000352
    public struct LogMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Tasks.Actions.DebugLogText.LogMode Log;        // 0x0
        public static NodeCanvas.Tasks.Actions.DebugLogText.LogMode Warning;        // 0x0
        public static NodeCanvas.Tasks.Actions.DebugLogText.LogMode Error;        // 0x0

    }

    // TypeToken: 0x2000353
    public struct VerboseMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Tasks.Actions.DebugLogText.VerboseMode LogAndDisplayLabel;        // 0x0
        public static NodeCanvas.Tasks.Actions.DebugLogText.VerboseMode LogOnly;        // 0x0
        public static NodeCanvas.Tasks.Actions.DebugLogText.VerboseMode DisplayLabelOnly;        // 0x0

    }

    // TypeToken: 0x2000357
    public struct Control
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Tasks.Actions.GraphOwnerControl.Control StartBehaviour;        // 0x0
        public static NodeCanvas.Tasks.Actions.GraphOwnerControl.Control StopBehaviour;        // 0x0
        public static NodeCanvas.Tasks.Actions.GraphOwnerControl.Control PauseBehaviour;        // 0x0

    }

    // TypeToken: 0x2000367
    public struct TransitionCallMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.StateMachines.FSM.TransitionCallMode Normal;        // 0x0
        public static NodeCanvas.StateMachines.FSM.TransitionCallMode Stacked;        // 0x0
        public static NodeCanvas.StateMachines.FSM.TransitionCallMode Clean;        // 0x0

    }

    // TypeToken: 0x200036F
    public struct TransitionEvaluationMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.StateMachines.FSMState.TransitionEvaluationMode CheckContinuously;        // 0x0
        public static NodeCanvas.StateMachines.FSMState.TransitionEvaluationMode CheckAfterStateFinished;        // 0x0
        public static NodeCanvas.StateMachines.FSMState.TransitionEvaluationMode CheckManually;        // 0x0

    }

    // TypeToken: 0x2000379
    public struct BTExecutionMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.StateMachines.NestedBTState.BTExecutionMode Once;        // 0x0
        public static NodeCanvas.StateMachines.NestedBTState.BTExecutionMode Repeat;        // 0x0

    }

    // TypeToken: 0x200037A
    public struct BTExitMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.StateMachines.NestedBTState.BTExitMode StopAndRestart;        // 0x0
        public static NodeCanvas.StateMachines.NestedBTState.BTExitMode PauseAndResume;        // 0x0

    }

    // TypeToken: 0x200037D
    public struct FSMExitMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.StateMachines.NestedFSMState.FSMExitMode StopAndRestart;        // 0x0
        public static NodeCanvas.StateMachines.NestedFSMState.FSMExitMode PauseAndResume;        // 0x0

    }

    // TypeToken: 0x200038A
    public class DerivedSerializationData
    {
        // Fields
        public System.Collections.Generic.List<NodeCanvas.DialogueTrees.DialogueTree.ActorParameter> actorParameters;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200038B
    public class ActorParameter
    {
        // Fields
        private System.String _keyName;        // 0x10
        private System.String _id;        // 0x18
        private UnityEngine.Object _actorObject;        // 0x20
        private NodeCanvas.DialogueTrees.IDialogueActor _actor;        // 0x28

        // Methods
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.String get_ID() { }
        private NodeCanvas.DialogueTrees.IDialogueActor get_actor() { }
        private System.Void set_actor(NodeCanvas.DialogueTrees.IDialogueActor value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name) { }
        private System.Void .ctor(System.String name, NodeCanvas.DialogueTrees.IDialogueActor actor) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20003A1
    public class Choice
    {
        // Fields
        public System.Boolean isUnfolded;        // 0x10
        public NodeCanvas.DialogueTrees.Statement statement;        // 0x18
        public NodeCanvas.Framework.ConditionTask condition;        // 0x20

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(NodeCanvas.DialogueTrees.Statement statement) { }

    }

    // TypeToken: 0x20003A5
    public class Option
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Single> weight;        // 0x10
        public NodeCanvas.Framework.ConditionTask condition;        // 0x18

        // Methods
        private System.Void .ctor(System.Single weightValue, NodeCanvas.Framework.IBlackboard bbValue) { }

    }

    // TypeToken: 0x20003AB
    public class SubtitleDelays
    {
        // Fields
        public System.Single characterDelay;        // 0x10
        public System.Single sentenceDelay;        // 0x14
        public System.Single commaDelay;        // 0x18
        public System.Single finalDelay;        // 0x1C

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003B4
    public class DerivedSerializationData
    {
        // Fields
        public System.Boolean repeat;        // 0x10
        public System.Single updateInterval;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003BE
    public struct ParallelPolicy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.BehaviourTrees.Parallel.ParallelPolicy FirstFailure;        // 0x0
        public static NodeCanvas.BehaviourTrees.Parallel.ParallelPolicy FirstSuccess;        // 0x0
        public static NodeCanvas.BehaviourTrees.Parallel.ParallelPolicy FirstSuccessOrFailure;        // 0x0

    }

    // TypeToken: 0x20003C1
    public class Desire
    {
        // Fields
        public System.String name;        // 0x10
        public System.Boolean foldout;        // 0x18
        public System.Collections.Generic.List<NodeCanvas.BehaviourTrees.PrioritySelector.Consideration> considerations;        // 0x20

        // Methods
        private NodeCanvas.BehaviourTrees.PrioritySelector.Consideration AddConsideration(NodeCanvas.Framework.IBlackboard bb) { }
        private System.Void RemoveConsideration(NodeCanvas.BehaviourTrees.PrioritySelector.Consideration consideration) { }
        private System.Single GetCompoundUtility() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003C2
    public class Consideration
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Single> input;        // 0x10
        public NodeCanvas.Framework.BBParameter<UnityEngine.AnimationCurve> function;        // 0x18

        // Methods
        private System.Single get_utility() { }
        private System.Void .ctor(NodeCanvas.Framework.IBlackboard blackboard) { }

    }

    // TypeToken: 0x20003C8
    public struct CaseSelectionMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.BehaviourTrees.Switch.CaseSelectionMode IndexBased;        // 0x0
        public static NodeCanvas.BehaviourTrees.Switch.CaseSelectionMode EnumBased;        // 0x0

    }

    // TypeToken: 0x20003C9
    public struct OutOfRangeMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.BehaviourTrees.Switch.OutOfRangeMode ReturnFailure;        // 0x0
        public static NodeCanvas.BehaviourTrees.Switch.OutOfRangeMode LoopIndex;        // 0x0

    }

    // TypeToken: 0x20003CC
    public struct FilterMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.BehaviourTrees.Filter.FilterMode LimitNumberOfTimes;        // 0x0
        public static NodeCanvas.BehaviourTrees.Filter.FilterMode CoolDown;        // 0x0

    }

    // TypeToken: 0x20003CD
    public struct Policy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.BehaviourTrees.Filter.Policy SuccessOrFailure;        // 0x0
        public static NodeCanvas.BehaviourTrees.Filter.Policy SuccessOnly;        // 0x0
        public static NodeCanvas.BehaviourTrees.Filter.Policy FailureOnly;        // 0x0

    }

    // TypeToken: 0x20003D0
    public struct GuardMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.BehaviourTrees.Guard.GuardMode ReturnFailure;        // 0x0
        public static NodeCanvas.BehaviourTrees.Guard.GuardMode WaitUntilReleased;        // 0x0

    }

    // TypeToken: 0x20003D4
    public struct TerminationConditions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.BehaviourTrees.Iterator.TerminationConditions None;        // 0x0
        public static NodeCanvas.BehaviourTrees.Iterator.TerminationConditions FirstSuccess;        // 0x0
        public static NodeCanvas.BehaviourTrees.Iterator.TerminationConditions FirstFailure;        // 0x0

    }

    // TypeToken: 0x20003D7
    public struct MonitorMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.BehaviourTrees.Monitor.MonitorMode Failure;        // 0x0
        public static NodeCanvas.BehaviourTrees.Monitor.MonitorMode Success;        // 0x0
        public static NodeCanvas.BehaviourTrees.Monitor.MonitorMode AnyStatus;        // 0x0

    }

    // TypeToken: 0x20003D8
    public struct ReturnStatusMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.BehaviourTrees.Monitor.ReturnStatusMode OriginalDecoratedChildStatus;        // 0x0
        public static NodeCanvas.BehaviourTrees.Monitor.ReturnStatusMode NewDecoratorActionStatus;        // 0x0

    }

    // TypeToken: 0x20003DB
    public struct RemapStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.BehaviourTrees.Remapper.RemapStatus Failure;        // 0x0
        public static NodeCanvas.BehaviourTrees.Remapper.RemapStatus Success;        // 0x0

    }

    // TypeToken: 0x20003DD
    public struct RepeaterMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.BehaviourTrees.Repeater.RepeaterMode RepeatTimes;        // 0x0
        public static NodeCanvas.BehaviourTrees.Repeater.RepeaterMode RepeatUntil;        // 0x0
        public static NodeCanvas.BehaviourTrees.Repeater.RepeaterMode RepeatForever;        // 0x0

    }

    // TypeToken: 0x20003DE
    public struct RepeatUntilStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.BehaviourTrees.Repeater.RepeatUntilStatus Failure;        // 0x0
        public static NodeCanvas.BehaviourTrees.Repeater.RepeatUntilStatus Success;        // 0x0

    }

    // TypeToken: 0x20003E8
    public struct ToggleMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.BehaviourTrees.NodeToggler.ToggleMode Enable;        // 0x0
        public static NodeCanvas.BehaviourTrees.NodeToggler.ToggleMode Disable;        // 0x0
        public static NodeCanvas.BehaviourTrees.NodeToggler.ToggleMode Toggle;        // 0x0

    }

    // TypeToken: 0x20003F0
    public class InvokeArguments : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(UnityEngine.Transform sender, UnityEngine.Transform receiver, System.Boolean isGlobal, System.Object[] args) { }
        private System.IAsyncResult BeginInvoke(UnityEngine.Transform sender, UnityEngine.Transform receiver, System.Boolean isGlobal, System.Object[] args, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20003F7
    public struct UpdateMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Framework.Graph.UpdateMode NormalUpdate;        // 0x0
        public static NodeCanvas.Framework.Graph.UpdateMode LateUpdate;        // 0x0
        public static NodeCanvas.Framework.Graph.UpdateMode FixedUpdate;        // 0x0
        public static NodeCanvas.Framework.Graph.UpdateMode Manual;        // 0x0

    }

    // TypeToken: 0x2000406
    public struct EnableAction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Framework.GraphOwner.EnableAction EnableBehaviour;        // 0x0
        public static NodeCanvas.Framework.GraphOwner.EnableAction DoNothing;        // 0x0

    }

    // TypeToken: 0x2000407
    public struct DisableAction
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Framework.GraphOwner.DisableAction DisableBehaviour;        // 0x0
        public static NodeCanvas.Framework.GraphOwner.DisableAction PauseBehaviour;        // 0x0
        public static NodeCanvas.Framework.GraphOwner.DisableAction DoNothing;        // 0x0

    }

    // TypeToken: 0x2000408
    public struct FirstActivation
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Framework.GraphOwner.FirstActivation OnEnable;        // 0x0
        public static NodeCanvas.Framework.GraphOwner.FirstActivation OnStart;        // 0x0
        public static NodeCanvas.Framework.GraphOwner.FirstActivation Async;        // 0x0

    }

    // TypeToken: 0x2000409
    public class SubInfo
    {
        // Fields
        public NodeCanvas.Framework.Graph graph;        // 0x10
        public NodeCanvas.Framework.Graph originalGraph;        // 0x18
        public NodeCanvas.Framework.Graph parentGraph;        // 0x20
        public System.String name;        // 0x28
        public NodeCanvas.Framework.IGraphAssignable assignable;        // 0x30
        public System.Boolean isSuc;        // 0x38

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000420
    public class AutoSortWithChildrenConnections : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200042B
    public struct ActionsExecutionMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Framework.ActionList.ActionsExecutionMode ActionsRunInSequence;        // 0x0
        public static NodeCanvas.Framework.ActionList.ActionsExecutionMode ActionsRunInParallel;        // 0x0

    }

    // TypeToken: 0x2000430
    public struct ConditionsCheckMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Framework.ConditionList.ConditionsCheckMode AllTrueRequired;        // 0x0
        public static NodeCanvas.Framework.ConditionList.ConditionsCheckMode AnyTrueSuffice;        // 0x0

    }

    // TypeToken: 0x2000437
    public class GetFromAgentAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000441
    public struct SingletonMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Framework.GlobalBlackboard.SingletonMode DestroyComponentOnly;        // 0x0
        public static NodeCanvas.Framework.GlobalBlackboard.SingletonMode DestroyEntireGameObject;        // 0x0

    }

    // TypeToken: 0x2000492
    public class Element
    {
        // Fields
        private System.Object _reference;        // 0x10
        private ParadoxNotion.HierarchyTree.Element _parent;        // 0x18
        private System.Collections.Generic.List<ParadoxNotion.HierarchyTree.Element> _children;        // 0x20

        // Methods
        private System.Object get_reference() { }
        private ParadoxNotion.HierarchyTree.Element get_parent() { }
        private System.Collections.Generic.IEnumerable<ParadoxNotion.HierarchyTree.Element> get_children() { }
        private System.Void .ctor(System.Object reference) { }
        private ParadoxNotion.HierarchyTree.Element AddChild(ParadoxNotion.HierarchyTree.Element child) { }
        private System.Void RemoveChild(ParadoxNotion.HierarchyTree.Element child) { }
        private ParadoxNotion.HierarchyTree.Element GetRoot() { }
        private ParadoxNotion.HierarchyTree.Element FindReferenceElement(System.Object target) { }
        private T GetFirstParentReferenceOfType() { }
        private System.Collections.Generic.IEnumerable<T> GetAllChildrenReferencesOfType() { }

    }

    // TypeToken: 0x2000499
    public struct MethodType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.ReflectionTools.MethodType Normal;        // 0x0
        public static ParadoxNotion.ReflectionTools.MethodType PropertyAccessor;        // 0x0
        public static ParadoxNotion.ReflectionTools.MethodType Event;        // 0x0
        public static ParadoxNotion.ReflectionTools.MethodType Operator;        // 0x0

    }

    // TypeToken: 0x20004A0
    public class CustomConverter : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Func<System.Object,System.Object> Invoke(System.Type fromType, System.Type toType) { }
        private System.IAsyncResult BeginInvoke(System.Type fromType, System.Type toType, System.AsyncCallback callback, System.Object object) { }
        private System.Func<System.Object,System.Object> EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20004AE
    public class EventDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(ParadoxNotion.EventData msg) { }
        private System.IAsyncResult BeginInvoke(ParadoxNotion.EventData msg, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20004AF
    public class EventDelegate`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(ParadoxNotion.EventData<T> msg) { }
        private System.IAsyncResult BeginInvoke(ParadoxNotion.EventData<T> msg, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20004B0
    public class CustomEventDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.String name, ParadoxNotion.IEventData data) { }
        private System.IAsyncResult BeginInvoke(System.String name, ParadoxNotion.IEventData data, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20004B3
    public struct Message
    {
        // Fields
        private System.WeakReference<System.Object> _contextRef;        // 0x10
        public UnityEngine.LogType type;        // 0x18
        public System.String text;        // 0x20
        public System.String tag;        // 0x28

        // Methods
        private System.Object get_context() { }
        private System.Void set_context(System.Object value) { }
        private System.Boolean IsValid() { }

    }

    // TypeToken: 0x20004B4
    public class LogHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Boolean Invoke(ParadoxNotion.Services.Logger.Message message) { }
        private System.IAsyncResult BeginInvoke(ParadoxNotion.Services.Logger.Message message, System.AsyncCallback callback, System.Object object) { }
        private System.Boolean EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20004B6
    public struct UpdateMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.Services.MonoManager.UpdateMode NormalUpdate;        // 0x0
        public static ParadoxNotion.Services.MonoManager.UpdateMode LateUpdate;        // 0x0
        public static ParadoxNotion.Services.MonoManager.UpdateMode FixedUpdate;        // 0x0

    }

    // TypeToken: 0x20004E6
    public class ObjectReferenceEqualityComparator, IEqualityComparer`1
    {
        // Fields
        public static readonly System.Collections.Generic.IEqualityComparer<System.Object> Instance;        // 0x0

        // Methods
        private System.Boolean System.Collections.Generic.IEqualityComparer<System.Object>.Equals(System.Object x, System.Object y) { }
        private System.Int32 System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(System.Object obj) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20004F0
    public class ObjectGenerator : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Object Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private System.Object EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20004F6
    public class fsLazyCycleDefinitionWriter
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Int32,ParadoxNotion.Serialization.FullSerializer.fsData> _pendingDefinitions;        // 0x10
        private System.Collections.Generic.HashSet<System.Int32> _references;        // 0x18

        // Methods
        private System.Void WriteDefinition(System.Int32 id, ParadoxNotion.Serialization.FullSerializer.fsData data) { }
        private System.Void WriteReference(System.Int32 id, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> dict) { }
        private System.Void Clear() { }
        private System.Void .ctor() { }

    }

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000005
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class DataNAttribute : Attribute
    {
        // Fields
        public System.Int32 capacity;        // 0x10
        public System.Int32 tSize;        // 0x14
        public System.Boolean ring;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class AnimatorBlackboardAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000008
    public class ECSComponentAttribute : Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;        // 0x10
        public System.Boolean isTag;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

}

namespace FlowCanvas
{

    // TypeToken: 0x2000009
    public class BinderConnection`1 : BinderConnection
    {
        // Methods
        private System.Void Bind() { }
        private System.Void UnBind() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000A
    public class BinderConnection : Connection
    {
        // Fields
        private System.String _sourcePortID;        // 0x30
        private System.String _targetPortID;        // 0x38
        private FlowCanvas.Port _sourcePort;        // 0x40
        private FlowCanvas.Port _targetPort;        // 0x48

        // Methods
        private System.String get_sourcePortID() { }
        private System.Void set_sourcePortID(System.String value) { }
        private System.String get_targetPortID() { }
        private System.Void set_targetPortID(System.String value) { }
        private FlowCanvas.Port get_sourcePort() { }
        private FlowCanvas.Port get_targetPort() { }
        private System.Type get_bindingType() { }
        private FlowCanvas.BinderConnection Create(FlowCanvas.Port source, FlowCanvas.Port target, System.Boolean recodeUndo, System.Boolean invokeGraphChanged) { }
        private System.Void SetSourcePort(FlowCanvas.Port newSourcePort) { }
        private System.Void SetTargetPort(FlowCanvas.Port newTargetPort) { }
        private System.Void GatherAndValidateSourcePort() { }
        private System.Void GatherAndValidateTargetPort() { }
        private System.Boolean CanBeBound(FlowCanvas.Port source, FlowCanvas.Port target, FlowCanvas.BinderConnection refConnection) { }
        private System.Boolean CanBeBoundVerbosed(FlowCanvas.Port source, FlowCanvas.Port target, FlowCanvas.BinderConnection refConnection, System.String& verbose) { }
        private System.String CanBeBoundVerbosed_Internal(FlowCanvas.Port source, FlowCanvas.Port target, FlowCanvas.BinderConnection refConnection) { }
        private System.Void OnDestroy() { }
        private System.Void OnDestroyAfterConnectionRemoved() { }
        private System.Void Bind() { }
        private System.Void UnBind() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000C
    public class FlowHandler : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(FlowCanvas.Flow f) { }
        private System.IAsyncResult BeginInvoke(FlowCanvas.Flow f, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000D
    public class ValueHandler`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private T Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private T EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000E
    public class ValueHandlerObject : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Object Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private System.Object EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200000F
    public class FlowBreak : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000010
    public class FlowReturn : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(System.Object value) { }
        private System.IAsyncResult BeginInvoke(System.Object value, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000011
    public struct Flow
    {
        // Fields
        private System.Int32 <ticks>k__BackingField;        // 0x10
        private System.Collections.Generic.Dictionary<System.String,System.Object> parameters;        // 0x18
        private FlowCanvas.Flow.ReturnData returnData;        // 0x20
        private FlowCanvas.FlowBreak breakCall;        // 0x30

        // Methods
        private System.Int32 get_ticks() { }
        private System.Void set_ticks(System.Int32 value) { }
        private FlowCanvas.Flow get_New() { }
        private System.Void Call(FlowCanvas.FlowOutput port) { }
        private T ReadParameter(System.String name) { }
        private System.Void WriteParameter(System.String name, T value) { }
        private System.Void SetReturnData(FlowCanvas.FlowReturn call, System.Type expectedType) { }
        private System.Void Return(System.Object value, FlowCanvas.FlowNode context) { }
        private System.Void BeginBreakBlock(FlowCanvas.FlowBreak callback) { }
        private System.Void EndBreakBlock() { }
        private System.Void Break(FlowCanvas.FlowNode context) { }

    }

    // TypeToken: 0x2000013
    public class FlowGraph : Graph
    {
        // Fields
        private System.Collections.Generic.List<NodeCanvas.Framework.IUpdatable> updatableNodes;        // 0xA0
        private System.Collections.Generic.List<FlowCanvas.Macros.MacroNodeWrapper> macroWrappers;        // 0xA8
        private System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.IInvokable> functions;        // 0xB0
        private System.Collections.Generic.Dictionary<System.Type,UnityEngine.Component> cachedAgentComponents;        // 0xB8

        // Methods
        private System.Type get_baseNodeType() { }
        private System.Boolean get_allowBlackboardOverrides() { }
        private System.Boolean get_requiresAgent() { }
        private System.Boolean get_requiresPrimeNode() { }
        private System.Boolean get_isTree() { }
        private System.Boolean get_canAcceptVariableDrops() { }
        private T CallFunction(System.String name, System.Object[] args) { }
        private System.Object CallFunction(System.String name, System.Object[] args) { }
        private System.Void CallFunctionAsync(System.String name, System.Action<System.Object> callback, System.Object[] args) { }
        private UnityEngine.Object GetAgentComponent(System.Type type) { }
        private System.Void OnGraphInitialize() { }
        private System.Void InitSecondPass() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphUpdate() { }
        private System.Void OnGraphStoped() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public class FlowNode : Node, ISerializationCallbackReceiver
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,System.Object> _inputPortValues;        // 0x98
        protected System.Collections.Generic.Dictionary<System.String,FlowCanvas.Port> inputPorts;        // 0xA0
        protected System.Collections.Generic.Dictionary<System.String,FlowCanvas.Port> outputPorts;        // 0xA8

        // Methods
        private System.Boolean get_allowDragInContentRect() { }
        private System.Nullable<System.Single> get_overrideNodeWidth() { }
        private System.Int32 get_maxInConnections() { }
        private System.Int32 get_maxOutConnections() { }
        private System.Boolean get_allowAsPrime() { }
        private System.Boolean get_canSelfConnect() { }
        private System.Type get_outConnectionType() { }
        private ParadoxNotion.Alignment2x2 get_commentsAlignment() { }
        private ParadoxNotion.Alignment2x2 get_iconAlignment() { }
        private FlowCanvas.FlowGraph get_flowGraph() { }
        private System.String get_SPACE() { }
        private System.Boolean get_ignoreSelfInstancePortAssignment() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void OnValidate(NodeCanvas.Framework.Graph flowGraph) { }
        private System.Void OnParentConnected(System.Int32 i) { }
        private System.Void OnChildConnected(System.Int32 i) { }
        private System.Void OnParentDisconnected(System.Int32 i) { }
        private System.Void OnChildDisconnected(System.Int32 i) { }
        private System.Void OnPortConnected(FlowCanvas.Port port, FlowCanvas.Port otherPort) { }
        private System.Void OnPortDisconnected(FlowCanvas.Port port, FlowCanvas.Port otherPort) { }
        private System.Void OnPortDisconnectedLate(FlowCanvas.Port port, FlowCanvas.Port otherPort) { }
        private System.Void BindPorts() { }
        private System.Void UnBindPorts() { }
        private FlowCanvas.Port GetInputPort(System.String ID) { }
        private FlowCanvas.Port GetOutputPort(System.String ID) { }
        private System.Collections.Generic.IEnumerable<FlowCanvas.Port> GetAllPorts() { }
        private System.Collections.Generic.IEnumerable<FlowCanvas.FlowOutput> GetOutputFlowPorts() { }
        private System.Collections.Generic.IEnumerable<FlowCanvas.ValueOutput> GetOutputValuePorts() { }
        private System.Collections.Generic.IEnumerable<FlowCanvas.FlowInput> GetInputFlowPorts() { }
        private System.Collections.Generic.IEnumerable<FlowCanvas.ValueInput> GetInputValuePorts() { }
        private FlowCanvas.Port GetFirstInputOfType(System.Type type) { }
        private FlowCanvas.Port GetFirstOutputOfType(System.Type type) { }
        private System.Void AssignSelfInstancePort() { }
        private System.Void GatherPorts() { }
        private System.Void RegisterPorts() { }
        private System.Void ValidateConnections() { }
        private System.Void DeserializeInputPortValues() { }
        private System.Void RefreshEditorPorts() { }
        private FlowCanvas.FlowInput AddFlowInput(System.String name, System.String ID, FlowCanvas.FlowHandler pointer) { }
        private FlowCanvas.FlowInput AddFlowInput(System.String name, FlowCanvas.FlowHandler pointer, System.String ID) { }
        private FlowCanvas.FlowOutput AddFlowOutput(System.String name, System.String ID) { }
        private FlowCanvas.ValueInput<T> AddValueInput(System.String name, System.String ID) { }
        private FlowCanvas.ValueOutput<T> AddValueOutput(System.String name, System.String ID, FlowCanvas.ValueHandler<T> getter) { }
        private FlowCanvas.ValueOutput<T> AddValueOutput(System.String name, FlowCanvas.ValueHandler<T> getter, System.String ID) { }
        private System.Void AddValueInput(System.Type valueType, System.String name, System.String ID) { }
        private FlowCanvas.ValueOutput<T> AddValueOutput(System.String name, System.String ID) { }
        private System.Void AddValueOutput(System.Type valueType, System.String name, System.String ID) { }
        private FlowCanvas.ValueInput AddValueInput(System.String name, System.String ID, System.Type type) { }
        private FlowCanvas.ValueInput AddValueInput(System.String name, System.Type type, System.String ID) { }
        private FlowCanvas.ValueOutput AddValueOutput(System.String name, System.String ID, System.Type type, FlowCanvas.ValueHandlerObject getter) { }
        private FlowCanvas.ValueOutput AddValueOutput(System.String name, System.Type type, FlowCanvas.ValueHandlerObject getter, System.String ID) { }
        private System.Void QualifyPortNameAndID(System.String& name, System.String& ID, System.Collections.IDictionary dict) { }
        private System.Boolean CheckReverseIDEquality(FlowCanvas.Port port, System.String requestedID) { }
        private System.Void TryAddReflectionBasedRegistrationForObject(System.Object instance) { }
        private FlowCanvas.FlowInput TryAddMethodFlowInput(System.Reflection.MethodInfo method, System.Object instance) { }
        private FlowCanvas.FlowOutput TryAddFieldDelegateFlowOutput(System.Reflection.FieldInfo field, System.Object instance) { }
        private FlowCanvas.ValueInput TryAddFieldDelegateValueInput(System.Reflection.FieldInfo field, System.Object instance) { }
        private FlowCanvas.ValueOutput TryAddPropertyValueOutput(System.Reflection.PropertyInfo prop, System.Object instance) { }
        private FlowCanvas.FlowNode ReplaceWith(System.Type t) { }
        private System.Void TryRemovePortIfMissingAndClean(FlowCanvas.Port port) { }
        private System.Type GetNodeWildDefinitionType() { }
        private System.Void TryHandleWildPortConnection(System.Type currentType, System.Type targetType) { }
        private System.Type TryGetNewGenericTypeForWild(System.Type wildType, System.Type currentType, System.Type targetType, System.Type content, System.Type context) { }
        private System.Reflection.MethodInfo TryGetNewGenericMethodForWild(System.Type wildType, System.Type currentType, System.Type targetType, System.Reflection.MethodInfo content) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public class FlowNodeNested`1 : FlowNode, IGraphAssignable`1, IGraphAssignable, IGraphElement
    {
        // Fields
        private System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> _variablesMap;        // 0x0
        private T <currentInstance>k__BackingField;        // 0x0
        private System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> <instances>k__BackingField;        // 0x0

        // Methods
        private T get_subGraph() { }
        private System.Void set_subGraph(T value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private T get_currentInstance() { }
        private System.Void set_currentInstance(T value) { }
        private System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> get_instances() { }
        private System.Void set_instances(System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> value) { }
        private System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> get_variablesMap() { }
        private System.Void set_variablesMap(System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> value) { }
        private NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_subGraph() { }
        private System.Void NodeCanvas.Framework.IGraphAssignable.set_subGraph(NodeCanvas.Framework.Graph value) { }
        private NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_currentInstance() { }
        private System.Void NodeCanvas.Framework.IGraphAssignable.set_currentInstance(NodeCanvas.Framework.Graph value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000020
    public class FlowScript : FlowScriptBase
    {
        // Methods
        private System.Boolean get_canDelayDeserializeAndOptimizeClone() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000021
    public class FlowScriptBase : FlowGraph
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000022
    public class FlowScriptController : GraphOwner`1
    {
        // Methods
        private System.Void CallFunction(System.String name) { }
        private System.Object CallFunction(System.String name, System.Object[] args) { }
        private System.Void CallFunctionAsync(System.String name, System.Action<System.Object> callback, System.Object[] args) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000023
    public interface IEditorMenuCallbackReceiver
    {
    }

    // TypeToken: 0x2000024
    public class RenderImageEvent : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput fOut;        // 0xC8
        private UnityEngine.RenderTexture t1;        // 0xD0
        private UnityEngine.RenderTexture t2;        // 0xD8

        // Methods
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture dest) { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }
        private UnityEngine.RenderTexture <RegisterPorts>b__6_0() { }
        private UnityEngine.RenderTexture <RegisterPorts>b__6_1() { }

    }

    // TypeToken: 0x2000025
    public class Port
    {
        // Fields
        private System.Boolean <prettifyName>k__BackingField;        // 0x10
        private System.Boolean <forceNotDraw>k__BackingField;        // 0x11
        private FlowCanvas.FlowNode <parent>k__BackingField;        // 0x18
        private System.String <ID>k__BackingField;        // 0x20
        private System.String <name>k__BackingField;        // 0x28
        private System.Int32 <connections>k__BackingField;        // 0x30
        private FlowCanvas.Port.BindStatus <bindStatus>k__BackingField;        // 0x34
        private UnityEngine.GUIContent <displayContent>k__BackingField;        // 0x38

        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_prettifyName() { }
        private System.Void set_prettifyName(System.Boolean value) { }
        private System.Boolean get_forceNotDraw() { }
        private System.Void set_forceNotDraw(System.Boolean value) { }
        private System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID) { }
        private FlowCanvas.FlowNode get_parent() { }
        private System.Void set_parent(FlowCanvas.FlowNode value) { }
        private System.String get_ID() { }
        private System.Void set_ID(System.String value) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Int32 get_connections() { }
        private System.Void set_connections(System.Int32 value) { }
        private System.Boolean get_isConnected() { }
        private FlowCanvas.Port.BindStatus get_bindStatus() { }
        private System.Void set_bindStatus(FlowCanvas.Port.BindStatus value) { }
        private UnityEngine.GUIContent get_displayContent() { }
        private System.Void set_displayContent(UnityEngine.GUIContent value) { }
        private System.Type get_type() { }
        private FlowCanvas.Port FlagMissing() { }
        private FlowCanvas.Port FlagInvalidCast() { }
        private FlowCanvas.Port FlagValid() { }
        private System.Boolean CanAcceptConnections() { }
        private System.Collections.Generic.IEnumerable<FlowCanvas.BinderConnection> GetPortConnections() { }
        private FlowCanvas.BinderConnection GetFirstInputConnection() { }
        private FlowCanvas.BinderConnection GetFirstOutputConnection() { }
        private System.Boolean IsFlowPort() { }
        private System.Boolean IsValuePort() { }
        private System.Boolean IsInputPort() { }
        private System.Boolean IsOutputPort() { }
        private System.Boolean IsUnityObject() { }
        private System.Boolean IsUnitySceneObject() { }
        private System.Boolean IsDelegate() { }
        private System.Boolean IsEnumerableCollection() { }
        private System.Boolean IsWild() { }
        private System.String ToString() { }
        private System.Boolean <GetPortConnections>b__43_0(FlowCanvas.BinderConnection c) { }
        private System.Boolean <GetPortConnections>b__43_1(FlowCanvas.BinderConnection c) { }
        private System.Boolean <GetFirstInputConnection>b__44_0(FlowCanvas.BinderConnection c) { }
        private System.Boolean <GetFirstOutputConnection>b__45_0(FlowCanvas.BinderConnection c) { }

    }

    // TypeToken: 0x2000027
    public class FlowInput : Port
    {
        // Fields
        private FlowCanvas.FlowHandler <pointer>k__BackingField;        // 0x40

        // Methods
        private System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID, FlowCanvas.FlowHandler pointer) { }
        private FlowCanvas.FlowHandler get_pointer() { }
        private System.Void set_pointer(FlowCanvas.FlowHandler value) { }
        private System.Type get_type() { }

    }

    // TypeToken: 0x2000028
    public class FlowOutput : Port
    {
        // Fields
        private FlowCanvas.FlowHandler pointer;        // 0x40

        // Methods
        private System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID) { }
        private System.Void add_pointer(FlowCanvas.FlowHandler value) { }
        private System.Void remove_pointer(FlowCanvas.FlowHandler value) { }
        private System.Type get_type() { }
        private System.Void Call(FlowCanvas.Flow f) { }
        private System.Void BindTo(FlowCanvas.FlowInput target) { }
        private System.Void Append(FlowCanvas.FlowHandler callback) { }
        private System.Void UnBind() { }

    }

    // TypeToken: 0x2000029
    public class ValueInput : Port
    {
        // Fields
        private System.Boolean <skipSelfInstanceAssignment>k__BackingField;        // 0x40

        // Methods
        private System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID) { }
        private FlowCanvas.ValueInput<T> CreateInstance(FlowCanvas.FlowNode parent, System.String name, System.String ID) { }
        private FlowCanvas.ValueInput CreateInstance(System.Type t, FlowCanvas.FlowNode parent, System.String name, System.String ID) { }
        private System.Object get_value() { }
        private FlowCanvas.ValueInput SetDefaultAndSerializedValue(System.Object v) { }
        private FlowCanvas.ValueInput SkipSelfInstanceAssignment(System.Boolean skip) { }
        private System.Boolean get_skipSelfInstanceAssignment() { }
        private System.Void set_skipSelfInstanceAssignment(System.Boolean value) { }
        private System.Object get_defaultValue() { }
        private System.Void set_defaultValue(System.Object value) { }
        private System.Object get_serializedValue() { }
        private System.Void set_serializedValue(System.Object value) { }
        private System.Boolean get_isDefaultValue() { }
        private System.Type get_type() { }
        private System.Void BindTo(FlowCanvas.ValueOutput target) { }
        private System.Void UnBind() { }
        private System.Object GetObjectValue() { }

    }

    // TypeToken: 0x200002A
    public class ValueInput`1 : ValueInput
    {
        // Fields
        private FlowCanvas.ValueHandler<T> getter;        // 0x0
        private System.Action<T> callback;        // 0x0
        private T _value;        // 0x0
        private T _defaultValue;        // 0x0

        // Methods
        private System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID) { }
        private System.Void add_getter(FlowCanvas.ValueHandler<T> value) { }
        private System.Void remove_getter(FlowCanvas.ValueHandler<T> value) { }
        private T get_value() { }
        private System.Object get_defaultValue() { }
        private System.Void set_defaultValue(System.Object value) { }
        private System.Object get_serializedValue() { }
        private System.Void set_serializedValue(System.Object value) { }
        private System.Boolean get_isDefaultValue() { }
        private System.Type get_type() { }
        private FlowCanvas.ValueInput<T> SetDefaultAndSerializedValue(T v) { }
        private T GetValue() { }
        private System.Object GetObjectValue() { }
        private System.Void BindTo(FlowCanvas.ValueOutput source) { }
        private System.Void Append(System.Action<T> callback) { }
        private System.Void UnBind() { }
        private T op_Explicit(FlowCanvas.ValueInput<T> port) { }

    }

    // TypeToken: 0x200002B
    public class ValueOutput : Port
    {
        // Methods
        private System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID) { }
        private FlowCanvas.ValueOutput<T> CreateInstance(FlowCanvas.FlowNode parent, System.String name, System.String ID, FlowCanvas.ValueHandler<T> getter) { }
        private FlowCanvas.ValueOutput CreateInstance(System.Type t, FlowCanvas.FlowNode parent, System.String name, System.String ID, FlowCanvas.ValueHandlerObject getter) { }
        private System.Object GetObjectValue() { }

    }

    // TypeToken: 0x200002C
    public class ValueOutput`1 : ValueOutput
    {
        // Fields
        private FlowCanvas.ValueHandler<T> <getter>k__BackingField;        // 0x0

        // Methods
        private System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID, FlowCanvas.ValueHandler<T> getter) { }
        private System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID, FlowCanvas.ValueHandlerObject getter) { }
        private System.Void .ctor(FlowCanvas.FlowNode parent, System.String name, System.String ID) { }
        private FlowCanvas.ValueHandler<T> get_getter() { }
        private System.Void set_getter(FlowCanvas.ValueHandler<T> value) { }
        private System.Object GetObjectValue() { }
        private System.Type get_type() { }
        private T op_Explicit(FlowCanvas.ValueOutput<T> port) { }

    }

    // TypeToken: 0x200002E
    public class TypeConverter
    {
        // Fields
        private static FlowCanvas.TypeConverter.CustomConverter customConverter;        // 0x0
        private static FlowCanvas.TypeConverter.CustomCanConvert customCanConvert;        // 0x8

        // Methods
        private System.Void add_customConverter(FlowCanvas.TypeConverter.CustomConverter value) { }
        private System.Void remove_customConverter(FlowCanvas.TypeConverter.CustomConverter value) { }
        private System.Void add_customCanConvert(FlowCanvas.TypeConverter.CustomCanConvert value) { }
        private System.Void remove_customCanConvert(FlowCanvas.TypeConverter.CustomCanConvert value) { }
        private FlowCanvas.ValueHandler<T> GetConverterFuncFromTo(System.Type sourceType, System.Type targetType, FlowCanvas.ValueHandler<System.Object> func) { }
        private System.Boolean HasConvertion(System.Type sourceType, System.Type targetType) { }
        private T QuickConvert(System.Object obj) { }
        private System.Object QuickConvert(System.Object obj, System.Type type) { }

    }

    // TypeToken: 0x2000035
    public class Wild
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace FlowCanvas.Macros
{

    // TypeToken: 0x2000273
    public class Macro : FlowScriptBase
    {
        // Fields
        public System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition> inputDefinitions;        // 0xC0
        public System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition> outputDefinitions;        // 0xC8
        public System.Collections.Generic.Dictionary<System.String,FlowCanvas.FlowHandler> entryActionMap;        // 0xD0
        public System.Collections.Generic.Dictionary<System.String,FlowCanvas.FlowHandler> exitActionMap;        // 0xD8
        public System.Collections.Generic.Dictionary<System.String,FlowCanvas.ValueHandlerObject> entryFunctionMap;        // 0xE0
        public System.Collections.Generic.Dictionary<System.String,FlowCanvas.ValueHandlerObject> exitFunctionMap;        // 0xE8
        private FlowCanvas.Macros.MacroInputNode _entry;        // 0xF0
        private FlowCanvas.Macros.MacroOutputNode _exit;        // 0xF8

        // Methods
        private System.Object OnDerivedDataSerialization() { }
        private System.Void OnDerivedDataDeserialization(System.Object data) { }
        private System.Boolean get_allowBlackboardOverrides() { }
        private System.Boolean get_canDelayDeserializeAndOptimizeClone() { }
        private FlowCanvas.Macros.MacroInputNode get_entry() { }
        private FlowCanvas.Macros.MacroOutputNode get_exit() { }
        private System.Void OnGraphValidate() { }
        private FlowCanvas.Port AddInputDefinition(ParadoxNotion.DynamicParameterDefinition def) { }
        private FlowCanvas.Port AddOutputDefinition(ParadoxNotion.DynamicParameterDefinition def) { }
        private System.Void AddExamplePorts() { }
        private System.Void SetValueInput(System.String name, T value) { }
        private System.Void CallFlowInput(System.String name) { }
        private T GetValueOutput(System.String name) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200027A
    public class MacroInputNode : FlowNode
    {
        // Methods
        private ParadoxNotion.Alignment2x2 get_iconAlignment() { }
        private FlowCanvas.Macros.Macro get_macro() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200027C
    public class MacroNodeWrapper : FlowNode, IGraphAssignable, IGraphElement, IUpdatable
    {
        // Fields
        private FlowCanvas.Macros.Macro _macro;        // 0xB0
        private FlowCanvas.Macros.Macro _currentInstance;        // 0xB8

        // Methods
        private System.String get_name() { }
        private System.String get_description() { }
        private FlowCanvas.Macros.Macro get_macro() { }
        private System.Void set_macro(FlowCanvas.Macros.Macro value) { }
        private NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_subGraph() { }
        private System.Void NodeCanvas.Framework.IGraphAssignable.set_subGraph(NodeCanvas.Framework.Graph value) { }
        private NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_currentInstance() { }
        private System.Void NodeCanvas.Framework.IGraphAssignable.set_currentInstance(NodeCanvas.Framework.Graph value) { }
        private System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> NodeCanvas.Framework.IGraphAssignable.get_variablesMap() { }
        private System.Void NodeCanvas.Framework.IGraphAssignable.set_variablesMap(System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> value) { }
        private NodeCanvas.Framework.BBParameter NodeCanvas.Framework.IGraphAssignable.get_subGraphParameter() { }
        private System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> NodeCanvas.Framework.IGraphAssignable.get_instances() { }
        private System.Void NodeCanvas.Framework.IGraphAssignable.set_instances(System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> value) { }
        private System.Void MakeInstance() { }
        private System.Void NodeCanvas.Framework.IUpdatable.Update() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000280
    public class MacroOutputNode : FlowNode
    {
        // Methods
        private ParadoxNotion.Alignment2x2 get_iconAlignment() { }
        private FlowCanvas.Macros.Macro get_macro() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

}

namespace FlowCanvas.Nodes
{

    // TypeToken: 0x2000036
    public class ExternalImplementedNodeWrapper : FlowNode
    {
        // Fields
        private UnityEngine.Object _target;        // 0xB0

        // Methods
        private FlowCanvas.Nodes.IExternalImplementedNode get_target() { }
        private System.Void set_target(FlowCanvas.Nodes.IExternalImplementedNode value) { }
        private System.String get_name() { }
        private System.Type GetRuntimeIconType() { }
        private System.Void RegisterPorts() { }
        private System.Void SetTarget(FlowCanvas.Nodes.IExternalImplementedNode target) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000037
    public interface IDropedReferenceNode : IGraphElement
    {
        // Methods
        private System.Void SetTarget(UnityEngine.Object target) { }

    }

    // TypeToken: 0x2000038
    public interface IExternalImplementedNode
    {
        // Methods
        private System.Void RegisterPorts(FlowCanvas.FlowNode parent) { }

    }

    // TypeToken: 0x2000039
    public class ApplicationPauseEvent : EventNode
    {
        // Fields
        private FlowCanvas.FlowOutput pause;        // 0xB0
        private System.Boolean isPause;        // 0xB8

        // Methods
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void ApplicationPause(System.Boolean isPause) { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }
        private System.Boolean <RegisterPorts>b__5_0() { }

    }

    // TypeToken: 0x200003A
    public class ApplicationQuitEvent : EventNode
    {
        // Fields
        private FlowCanvas.FlowOutput quit;        // 0xB0

        // Methods
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void ApplicationQuit() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003B
    public class CSharpAutoCallbackEvent : EventNode, IReflectedWrapper
    {
        // Fields
        private ParadoxNotion.Serialization.SerializedEventInfo _event;        // 0xB0
        private FlowCanvas.Nodes.ReflectedDelegateEvent reflectedEvent;        // 0xB8
        private FlowCanvas.ValueInput instancePort;        // 0xC0
        private FlowCanvas.FlowOutput callback;        // 0xC8
        private System.Object instance;        // 0xD0
        private System.Object[] args;        // 0xD8

        // Methods
        private System.Reflection.EventInfo get_eventInfo() { }
        private System.Boolean get_isStaticEvent() { }
        private System.String get_name() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Void SetEvent(System.Reflection.EventInfo info, System.Object instance) { }
        private System.Void RegisterPorts() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void OnEventRaised(System.Object[] args) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003D
    public class CSharpEventCallback : EventNode, IReflectedWrapper
    {
        // Fields
        protected System.Boolean _autoHandleRegistration;        // 0xB0
        private ParadoxNotion.Serialization.SerializedTypeInfo _type;        // 0xB8
        private System.Object[] argValues;        // 0xC0
        private FlowCanvas.ValueInput eventInput;        // 0xC8
        private FlowCanvas.FlowOutput flowCallback;        // 0xD0
        private FlowCanvas.Nodes.ReflectedDelegateEvent reflectedEvent;        // 0xD8

        // Methods
        private System.Type get_type() { }
        private System.Void set_type(System.Type value) { }
        private System.Boolean get_autoHandleRegistration() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void Register(FlowCanvas.Flow f) { }
        private System.Void Unregister(FlowCanvas.Flow f) { }
        private System.Void Callback(System.Object[] args) { }
        private System.Type GetNodeWildDefinitionType() { }
        private System.Void OnPortConnected(FlowCanvas.Port port, FlowCanvas.Port otherPort) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003F
    public class CustomEvent : RouterEventNode`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> eventName;        // 0xC8
        private FlowCanvas.FlowOutput onReceived;        // 0xD0
        private NodeCanvas.Framework.GraphOwner sender;        // 0xD8
        private NodeCanvas.Framework.GraphOwner receiver;        // 0xE0

        // Methods
        private System.String get_name() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void RegisterPorts() { }
        private System.Void OnCustomEvent(System.String eventName, ParadoxNotion.IEventData msg) { }
        private System.Void .ctor() { }
        private NodeCanvas.Framework.GraphOwner <RegisterPorts>b__8_0() { }
        private NodeCanvas.Framework.GraphOwner <RegisterPorts>b__8_1() { }

    }

    // TypeToken: 0x2000040
    public class CustomEvent`1 : RouterEventNode`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> eventName;        // 0x0
        private FlowCanvas.FlowOutput onReceived;        // 0x0
        private NodeCanvas.Framework.GraphOwner sender;        // 0x0
        private NodeCanvas.Framework.GraphOwner receiver;        // 0x0
        private T receivedValue;        // 0x0

        // Methods
        private System.String get_name() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void RegisterPorts() { }
        private System.Void OnCustomEvent(System.String eventName, ParadoxNotion.IEventData msg) { }
        private System.Void .ctor() { }
        private NodeCanvas.Framework.GraphOwner <RegisterPorts>b__9_0() { }
        private NodeCanvas.Framework.GraphOwner <RegisterPorts>b__9_1() { }
        private T <RegisterPorts>b__9_2() { }

    }

    // TypeToken: 0x2000041
    public class DelegateCallbackEvent : EventNode, IReflectedWrapper
    {
        // Fields
        private ParadoxNotion.Serialization.SerializedTypeInfo _type;        // 0xB0
        private FlowCanvas.Nodes.ReflectedDelegateEvent reflectedEvent;        // 0xB8
        private FlowCanvas.ValueOutput delegatePort;        // 0xC0
        private FlowCanvas.FlowOutput callbackPort;        // 0xC8
        private System.Object[] args;        // 0xD0

        // Methods
        private System.Type get_delegateType() { }
        private System.Void set_delegateType(System.Type value) { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Void RegisterPorts() { }
        private System.Void Callback(System.Object[] args) { }
        private System.Void OnGraphStoped() { }
        private System.Void OnPortConnected(FlowCanvas.Port port, FlowCanvas.Port otherPort) { }
        private System.Void .ctor() { }
        private System.Object <RegisterPorts>b__9_0() { }

    }

    // TypeToken: 0x2000043
    public class GetSharpEvent : FlowNode, IReflectedWrapper
    {
        // Fields
        private ParadoxNotion.Serialization.SerializedEventInfo _event;        // 0xB0
        private FlowCanvas.ValueInput instancePort;        // 0xB8

        // Methods
        private System.Reflection.EventInfo get_eventInfo() { }
        private System.String get_name() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Void SetEvent(System.Reflection.EventInfo info, System.Object instance) { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000045
    public class InvokeSignal : FlowNode, IDropedReferenceNode, IGraphElement
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<NodeCanvas.Framework.SignalDefinition> _signalDefinition;        // 0xB0
        public System.Boolean global;        // 0xB8
        private FlowCanvas.ValueInput<UnityEngine.Transform> target;        // 0xC0
        private FlowCanvas.ValueInput[] inputArgs;        // 0xC8

        // Methods
        private NodeCanvas.Framework.SignalDefinition get_signalDefinition() { }
        private System.Void set_signalDefinition(NodeCanvas.Framework.SignalDefinition value) { }
        private System.String get_name() { }
        private System.Void SetTarget(UnityEngine.Object target) { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000047
    public class SignalCallback : RouterEventNode`1, IDropedReferenceNode, IGraphElement
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<NodeCanvas.Framework.SignalDefinition> _signalDefinition;        // 0xC8
        private FlowCanvas.FlowOutput onReceived;        // 0xD0
        private UnityEngine.Transform receiver;        // 0xD8
        private UnityEngine.Transform sender;        // 0xE0
        private System.Object[] args;        // 0xE8

        // Methods
        private NodeCanvas.Framework.SignalDefinition get_signalDefinition() { }
        private System.Void set_signalDefinition(NodeCanvas.Framework.SignalDefinition value) { }
        private System.String get_name() { }
        private System.Void SetTarget(UnityEngine.Object target) { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnPostGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void OnInvoked(UnityEngine.Transform sender, UnityEngine.Transform receiver, System.Boolean isGlobal, System.Object[] args) { }
        private System.Void .ctor() { }
        private UnityEngine.Transform <RegisterPorts>b__15_0() { }
        private UnityEngine.Transform <RegisterPorts>b__15_1() { }

    }

    // TypeToken: 0x2000049
    public class UnityEventAutoCallbackEvent : EventNode, IReflectedWrapper
    {
        // Fields
        private ParadoxNotion.Serialization.SerializedUnityEventInfo _eventMember;        // 0xB0
        private FlowCanvas.Nodes.ReflectedUnityEvent reflectedEvent;        // 0xB8
        private UnityEngine.Events.UnityEventBase unityEvent;        // 0xC0
        private FlowCanvas.ValueInput instancePort;        // 0xC8
        private FlowCanvas.FlowOutput callback;        // 0xD0
        private System.Object[] args;        // 0xD8

        // Methods
        private System.Reflection.MemberInfo get_member() { }
        private System.Boolean get_isStatic() { }
        private System.Type get_eventType() { }
        private System.Reflection.FieldInfo get_field() { }
        private System.Reflection.PropertyInfo get_prop() { }
        private System.String get_name() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Void SetEvent(System.Reflection.MemberInfo newMember, System.Object instance) { }
        private System.Void RegisterPorts() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void OnEventRaised(System.Object[] args) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004B
    public class UnityEventCallbackEvent : EventNode, IReflectedWrapper
    {
        // Fields
        protected System.Boolean _autoHandleRegistration;        // 0xB0
        private ParadoxNotion.Serialization.SerializedTypeInfo _type;        // 0xB8
        private System.Object[] argValues;        // 0xC0
        private FlowCanvas.ValueInput eventInput;        // 0xC8
        private FlowCanvas.FlowOutput flowCallback;        // 0xD0
        private FlowCanvas.Nodes.ReflectedUnityEvent reflectedEvent;        // 0xD8

        // Methods
        private System.Type get_eventType() { }
        private System.Void set_eventType(System.Type value) { }
        private System.Boolean get_autoHandleRegistration() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void Register(FlowCanvas.Flow f) { }
        private System.Void Unregister(FlowCanvas.Flow f) { }
        private System.Void OnEventRaised(System.Object[] args) { }
        private System.Type GetNodeWildDefinitionType() { }
        private System.Void OnPortConnected(FlowCanvas.Port port, FlowCanvas.Port otherPort) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004D
    public class EventNode : FlowNode
    {
        // Methods
        private System.String get_name() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004E
    public class EventNode`1 : EventNode
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<T> target;        // 0x0

        // Methods
        private System.String get_name() { }
        private System.Void OnPostGraphStarted() { }
        private System.Void ResolveSelf() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004F
    public class RouterEventNode`1 : EventNode
    {
        // Fields
        public FlowCanvas.Nodes.RouterEventNode.TargetMode<T> targetMode;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> target;        // 0x0
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>> targets;        // 0x0

        // Methods
        private System.String get_name() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnPostGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private T ResolveReceiver(UnityEngine.GameObject receiver) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000051
    public class ConstructionEvent : EventNode
    {
        // Fields
        private FlowCanvas.FlowOutput awake;        // 0xB0
        private System.Boolean called;        // 0xB8

        // Methods
        private System.Void OnPostGraphStarted() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000052
    public class DisableEvent : EventNode
    {
        // Fields
        private FlowCanvas.FlowOutput disable;        // 0xB0

        // Methods
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000053
    public class EnableEvent : EventNode
    {
        // Fields
        private FlowCanvas.FlowOutput enable;        // 0xB0

        // Methods
        private System.Void OnPostGraphStarted() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000054
    public class FixedUpdateEvent : EventNode
    {
        // Fields
        private FlowCanvas.FlowOutput fixedUpdate;        // 0xB0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void FixedUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000055
    public class LateUpdateEvent : EventNode
    {
        // Fields
        private FlowCanvas.FlowOutput lateUpdate;        // 0xB0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void LateUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000056
    public class StartEvent : EventNode
    {
        // Fields
        private FlowCanvas.FlowOutput start;        // 0xB0
        private System.Boolean called;        // 0xB8

        // Methods
        private System.Void OnPostGraphStarted() { }
        private System.Void OnStartCallback() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000057
    public class UpdateEvent : EventNode, IUpdatable, IGraphElement
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Single> updateInterval;        // 0xB0
        private FlowCanvas.FlowOutput update;        // 0xB8
        private System.Single lastUpdatedTime;        // 0xC0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void OnGraphStarted() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000058
    public class InputAxisEvent : EventNode, IUpdatable, IGraphElement
    {
        // Fields
        private FlowCanvas.FlowOutput o;        // 0xB0
        private System.Single horizontal;        // 0xB8
        private System.Single vertical;        // 0xBC
        private System.Boolean calledLastFrame;        // 0xC0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Update() { }
        private System.Void .ctor() { }
        private System.Single <RegisterPorts>b__4_0() { }
        private System.Single <RegisterPorts>b__4_1() { }

    }

    // TypeToken: 0x2000059
    public class InputButtonEvents : EventNode, IUpdatable, IGraphElement
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> buttonName;        // 0xB0
        private FlowCanvas.FlowOutput down;        // 0xB8
        private FlowCanvas.FlowOutput up;        // 0xC0
        private FlowCanvas.FlowOutput pressed;        // 0xC8

        // Methods
        private System.String get_name() { }
        private System.Void RegisterPorts() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005A
    public class InputCustomAxisEvent : EventNode, IUpdatable, IGraphElement
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<System.String>> axis;        // 0xB0
        private System.Single[] axisValues;        // 0xB8
        private System.Boolean calledLastFrame;        // 0xC0
        private FlowCanvas.FlowOutput o;        // 0xC8

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005C
    public class KeyboardEvents : EventNode, IUpdatable, IGraphElement
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.KeyCode> keyCode;        // 0xB0
        private FlowCanvas.FlowOutput down;        // 0xB8
        private FlowCanvas.FlowOutput up;        // 0xC0
        private FlowCanvas.FlowOutput pressed;        // 0xC8

        // Methods
        private System.String get_name() { }
        private System.Void RegisterPorts() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005D
    public class MouseEvents : EventNode, IUpdatable, IGraphElement
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<FlowCanvas.Nodes.MouseEvents.ButtonKeys> buttonKey;        // 0xB0
        private FlowCanvas.FlowOutput down;        // 0xB8
        private FlowCanvas.FlowOutput pressed;        // 0xC0
        private FlowCanvas.FlowOutput up;        // 0xC8

        // Methods
        private System.String get_name() { }
        private System.Void RegisterPorts() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200005F
    public class MousePickEvent : EventNode, IUpdatable, IGraphElement
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<FlowCanvas.Nodes.MousePickEvent.ButtonKeys> buttonKey;        // 0xB0
        public NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask> mask;        // 0xB8
        private FlowCanvas.FlowOutput o;        // 0xC0
        private UnityEngine.RaycastHit hit;        // 0xC8

        // Methods
        private System.String get_name() { }
        private System.Void RegisterPorts() { }
        private System.Void Update() { }
        private System.Void .ctor() { }
        private UnityEngine.RaycastHit <RegisterPorts>b__7_0() { }

    }

    // TypeToken: 0x2000061
    public class AnimatorEvents : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onAnimatorMove;        // 0xC8
        private FlowCanvas.FlowOutput onAnimatorIK;        // 0xD0
        private UnityEngine.Animator receiver;        // 0xD8
        private System.Int32 layerIndex;        // 0xE0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnAnimatorMove(ParadoxNotion.EventData msg) { }
        private System.Void OnAnimatorIK(ParadoxNotion.EventData<System.Int32> msg) { }
        private System.Void .ctor() { }
        private UnityEngine.Animator <RegisterPorts>b__4_0() { }
        private System.Int32 <RegisterPorts>b__4_1() { }

    }

    // TypeToken: 0x2000062
    public class CharacterControllerEvents : RouterEventNode`1, IUpdatable, IGraphElement
    {
        // Fields
        private FlowCanvas.FlowOutput onHit;        // 0xC8
        private UnityEngine.CharacterController receiver;        // 0xD0
        private UnityEngine.ControllerColliderHit hitInfo;        // 0xD8
        private FlowCanvas.FlowOutput onGrounded;        // 0xE0
        private FlowCanvas.FlowOutput onUnGrounded;        // 0xE8
        private System.Boolean wasGrounded;        // 0xF0
        private System.Boolean[] wasGroundedMulti;        // 0xF8

        // Methods
        private System.Void OnPostGraphStarted() { }
        private System.Void NodeCanvas.Framework.IUpdatable.Update() { }
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnControllerColliderHit(ParadoxNotion.EventData<UnityEngine.ControllerColliderHit> msg) { }
        private System.Void .ctor() { }
        private UnityEngine.CharacterController <RegisterPorts>b__9_0() { }
        private UnityEngine.GameObject <RegisterPorts>b__9_1() { }
        private UnityEngine.Vector3 <RegisterPorts>b__9_2() { }
        private UnityEngine.ControllerColliderHit <RegisterPorts>b__9_3() { }

    }

    // TypeToken: 0x2000063
    public class Collision2DEvents_Rigidbody : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onEnter;        // 0xC8
        private FlowCanvas.FlowOutput onStay;        // 0xD0
        private FlowCanvas.FlowOutput onExit;        // 0xD8
        private UnityEngine.Rigidbody2D receiver;        // 0xE0
        private UnityEngine.Collision2D collision;        // 0xE8

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnCollisionEnter2D(ParadoxNotion.EventData<UnityEngine.Collision2D> msg) { }
        private System.Void OnCollisionStay2D(ParadoxNotion.EventData<UnityEngine.Collision2D> msg) { }
        private System.Void OnCollisionExit2D(ParadoxNotion.EventData<UnityEngine.Collision2D> msg) { }
        private System.Void .ctor() { }
        private UnityEngine.Rigidbody2D <RegisterPorts>b__5_0() { }
        private UnityEngine.GameObject <RegisterPorts>b__5_1() { }
        private UnityEngine.ContactPoint2D <RegisterPorts>b__5_2() { }
        private UnityEngine.Collision2D <RegisterPorts>b__5_3() { }

    }

    // TypeToken: 0x2000064
    public class Collision2DEvents : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onEnter;        // 0xC8
        private FlowCanvas.FlowOutput onStay;        // 0xD0
        private FlowCanvas.FlowOutput onExit;        // 0xD8
        private UnityEngine.Collider2D receiver;        // 0xE0
        private UnityEngine.Collision2D collision;        // 0xE8

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnCollisionEnter2D(ParadoxNotion.EventData<UnityEngine.Collision2D> msg) { }
        private System.Void OnCollisionStay2D(ParadoxNotion.EventData<UnityEngine.Collision2D> msg) { }
        private System.Void OnCollisionExit2D(ParadoxNotion.EventData<UnityEngine.Collision2D> msg) { }
        private System.Void .ctor() { }
        private UnityEngine.Collider2D <RegisterPorts>b__5_0() { }
        private UnityEngine.GameObject <RegisterPorts>b__5_1() { }
        private UnityEngine.ContactPoint2D <RegisterPorts>b__5_2() { }
        private UnityEngine.Collision2D <RegisterPorts>b__5_3() { }

    }

    // TypeToken: 0x2000065
    public class CollisionEvents_Rigidbody : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onEnter;        // 0xC8
        private FlowCanvas.FlowOutput onStay;        // 0xD0
        private FlowCanvas.FlowOutput onExit;        // 0xD8
        private UnityEngine.Rigidbody receiver;        // 0xE0
        private UnityEngine.Collision collision;        // 0xE8

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnCollisionEnter(ParadoxNotion.EventData<UnityEngine.Collision> msg) { }
        private System.Void OnCollisionStay(ParadoxNotion.EventData<UnityEngine.Collision> msg) { }
        private System.Void OnCollisionExit(ParadoxNotion.EventData<UnityEngine.Collision> msg) { }
        private System.Void .ctor() { }
        private UnityEngine.Rigidbody <RegisterPorts>b__5_0() { }
        private UnityEngine.GameObject <RegisterPorts>b__5_1() { }
        private UnityEngine.ContactPoint <RegisterPorts>b__5_2() { }
        private UnityEngine.Collision <RegisterPorts>b__5_3() { }

    }

    // TypeToken: 0x2000066
    public class CollisionEvents : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onEnter;        // 0xC8
        private FlowCanvas.FlowOutput onStay;        // 0xD0
        private FlowCanvas.FlowOutput onExit;        // 0xD8
        private UnityEngine.Collider receiver;        // 0xE0
        private UnityEngine.Collision collision;        // 0xE8

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnCollisionEnter(ParadoxNotion.EventData<UnityEngine.Collision> msg) { }
        private System.Void OnCollisionStay(ParadoxNotion.EventData<UnityEngine.Collision> msg) { }
        private System.Void OnCollisionExit(ParadoxNotion.EventData<UnityEngine.Collision> msg) { }
        private System.Void .ctor() { }
        private UnityEngine.Collider <RegisterPorts>b__5_0() { }
        private UnityEngine.GameObject <RegisterPorts>b__5_1() { }
        private UnityEngine.ContactPoint <RegisterPorts>b__5_2() { }
        private UnityEngine.Collision <RegisterPorts>b__5_3() { }

    }

    // TypeToken: 0x2000067
    public class MouseAgent2DEvents : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onEnter;        // 0xC8
        private FlowCanvas.FlowOutput onOver;        // 0xD0
        private FlowCanvas.FlowOutput onExit;        // 0xD8
        private FlowCanvas.FlowOutput onDown;        // 0xE0
        private FlowCanvas.FlowOutput onUp;        // 0xE8
        private FlowCanvas.FlowOutput onDrag;        // 0xF0
        private UnityEngine.Collider2D receiver;        // 0xF8
        private UnityEngine.RaycastHit2D hit;        // 0x100

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnMouseEnter(ParadoxNotion.EventData msg) { }
        private System.Void OnMouseOver(ParadoxNotion.EventData msg) { }
        private System.Void OnMouseExit(ParadoxNotion.EventData msg) { }
        private System.Void OnMouseDown(ParadoxNotion.EventData msg) { }
        private System.Void OnMouseUp(ParadoxNotion.EventData msg) { }
        private System.Void OnMouseDrag(ParadoxNotion.EventData msg) { }
        private System.Void StoreHit() { }
        private System.Void .ctor() { }
        private UnityEngine.Collider2D <RegisterPorts>b__8_0() { }
        private UnityEngine.RaycastHit2D <RegisterPorts>b__8_1() { }

    }

    // TypeToken: 0x2000068
    public class MouseAgentEvents : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onEnter;        // 0xC8
        private FlowCanvas.FlowOutput onOver;        // 0xD0
        private FlowCanvas.FlowOutput onExit;        // 0xD8
        private FlowCanvas.FlowOutput onDown;        // 0xE0
        private FlowCanvas.FlowOutput onUp;        // 0xE8
        private FlowCanvas.FlowOutput onDrag;        // 0xF0
        private UnityEngine.Collider receiver;        // 0xF8
        private UnityEngine.RaycastHit hit;        // 0x100

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnMouseEnter(ParadoxNotion.EventData msg) { }
        private System.Void OnMouseOver(ParadoxNotion.EventData msg) { }
        private System.Void OnMouseExit(ParadoxNotion.EventData msg) { }
        private System.Void OnMouseDown(ParadoxNotion.EventData msg) { }
        private System.Void OnMouseUp(ParadoxNotion.EventData msg) { }
        private System.Void OnMouseDrag(ParadoxNotion.EventData msg) { }
        private System.Void StoreHit() { }
        private System.Void .ctor() { }
        private UnityEngine.Collider <RegisterPorts>b__8_0() { }
        private UnityEngine.RaycastHit <RegisterPorts>b__8_1() { }

    }

    // TypeToken: 0x2000069
    public class ObjectStateEvents : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onEnable;        // 0xC8
        private FlowCanvas.FlowOutput onDisable;        // 0xD0
        private FlowCanvas.FlowOutput onDestroy;        // 0xD8
        private UnityEngine.GameObject receiver;        // 0xE0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnEnable(ParadoxNotion.EventData msg) { }
        private System.Void OnDisable(ParadoxNotion.EventData msg) { }
        private System.Void OnDestroy(ParadoxNotion.EventData msg) { }
        private System.Void .ctor() { }
        private UnityEngine.GameObject <RegisterPorts>b__4_0() { }

    }

    // TypeToken: 0x200006A
    public class DrawGizmosEvents : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onDrawGizmos;        // 0xC8
        private UnityEngine.GameObject receiver;        // 0xD0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnDrawGizmos(ParadoxNotion.EventData msg) { }
        private System.Void .ctor() { }
        private UnityEngine.GameObject <RegisterPorts>b__2_0() { }

    }

    // TypeToken: 0x200006B
    public class ParticleCollision2DEvents : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onCollision;        // 0xC8
        private UnityEngine.Collider2D receiver;        // 0xD0
        private UnityEngine.ParticleSystem particle;        // 0xD8
        private System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> collisionEvents;        // 0xE0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnParticleCollision(ParadoxNotion.EventData<UnityEngine.GameObject> msg) { }
        private System.Void .ctor() { }
        private UnityEngine.Collider2D <RegisterPorts>b__4_0() { }
        private UnityEngine.ParticleSystem <RegisterPorts>b__4_1() { }
        private UnityEngine.Vector3 <RegisterPorts>b__4_2() { }
        private UnityEngine.Vector3 <RegisterPorts>b__4_3() { }
        private UnityEngine.Vector3 <RegisterPorts>b__4_4() { }

    }

    // TypeToken: 0x200006C
    public class ParticleCollisionEvents : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onCollision;        // 0xC8
        private UnityEngine.Collider receiver;        // 0xD0
        private UnityEngine.ParticleSystem particle;        // 0xD8
        private System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> collisionEvents;        // 0xE0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnParticleCollision(ParadoxNotion.EventData<UnityEngine.GameObject> msg) { }
        private System.Void .ctor() { }
        private UnityEngine.Collider <RegisterPorts>b__4_0() { }
        private UnityEngine.ParticleSystem <RegisterPorts>b__4_1() { }
        private UnityEngine.Vector3 <RegisterPorts>b__4_2() { }
        private UnityEngine.Vector3 <RegisterPorts>b__4_3() { }
        private UnityEngine.Vector3 <RegisterPorts>b__4_4() { }

    }

    // TypeToken: 0x200006D
    public class TransformEvents : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onParentChanged;        // 0xC8
        private FlowCanvas.FlowOutput onChildrenChanged;        // 0xD0
        private UnityEngine.Transform receiver;        // 0xD8
        private UnityEngine.Transform parent;        // 0xE0
        private System.Collections.Generic.IEnumerable<UnityEngine.Transform> children;        // 0xE8

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnTransformParentChanged(ParadoxNotion.EventData msg) { }
        private System.Void OnTransformChildrenChanged(ParadoxNotion.EventData msg) { }
        private System.Void .ctor() { }
        private UnityEngine.Transform <RegisterPorts>b__5_0() { }
        private UnityEngine.Transform <RegisterPorts>b__5_1() { }
        private System.Collections.Generic.IEnumerable<UnityEngine.Transform> <RegisterPorts>b__5_2() { }

    }

    // TypeToken: 0x200006E
    public class Trigger2DEvents_Transform : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onEnter;        // 0xC8
        private FlowCanvas.FlowOutput onStay;        // 0xD0
        private FlowCanvas.FlowOutput onExit;        // 0xD8
        private UnityEngine.Transform receiver;        // 0xE0
        private UnityEngine.GameObject other;        // 0xE8

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnTriggerEnter2D(ParadoxNotion.EventData<UnityEngine.Collider2D> msg) { }
        private System.Void OnTriggerStay2D(ParadoxNotion.EventData<UnityEngine.Collider2D> msg) { }
        private System.Void OnTriggerExit2D(ParadoxNotion.EventData<UnityEngine.Collider2D> msg) { }
        private System.Void .ctor() { }
        private UnityEngine.Transform <RegisterPorts>b__5_0() { }
        private UnityEngine.GameObject <RegisterPorts>b__5_1() { }

    }

    // TypeToken: 0x200006F
    public class Trigger2DEvents : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onEnter;        // 0xC8
        private FlowCanvas.FlowOutput onStay;        // 0xD0
        private FlowCanvas.FlowOutput onExit;        // 0xD8
        private UnityEngine.Collider2D receiver;        // 0xE0
        private UnityEngine.GameObject other;        // 0xE8

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnTriggerEnter2D(ParadoxNotion.EventData<UnityEngine.Collider2D> msg) { }
        private System.Void OnTriggerStay2D(ParadoxNotion.EventData<UnityEngine.Collider2D> msg) { }
        private System.Void OnTriggerExit2D(ParadoxNotion.EventData<UnityEngine.Collider2D> msg) { }
        private System.Void .ctor() { }
        private UnityEngine.Collider2D <RegisterPorts>b__5_0() { }
        private UnityEngine.GameObject <RegisterPorts>b__5_1() { }

    }

    // TypeToken: 0x2000070
    public class TriggerEvents_Transform : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onEnter;        // 0xC8
        private FlowCanvas.FlowOutput onStay;        // 0xD0
        private FlowCanvas.FlowOutput onExit;        // 0xD8
        private UnityEngine.Transform receiver;        // 0xE0
        private UnityEngine.GameObject other;        // 0xE8

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnTriggerEnter(ParadoxNotion.EventData<UnityEngine.Collider> msg) { }
        private System.Void OnTriggerStay(ParadoxNotion.EventData<UnityEngine.Collider> msg) { }
        private System.Void OnTriggerExit(ParadoxNotion.EventData<UnityEngine.Collider> msg) { }
        private System.Void .ctor() { }
        private UnityEngine.Transform <RegisterPorts>b__5_0() { }
        private UnityEngine.GameObject <RegisterPorts>b__5_1() { }

    }

    // TypeToken: 0x2000071
    public class TriggerEvents : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onEnter;        // 0xC8
        private FlowCanvas.FlowOutput onStay;        // 0xD0
        private FlowCanvas.FlowOutput onExit;        // 0xD8
        private UnityEngine.Collider receiver;        // 0xE0
        private UnityEngine.GameObject other;        // 0xE8

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnTriggerEnter(ParadoxNotion.EventData<UnityEngine.Collider> msg) { }
        private System.Void OnTriggerStay(ParadoxNotion.EventData<UnityEngine.Collider> msg) { }
        private System.Void OnTriggerExit(ParadoxNotion.EventData<UnityEngine.Collider> msg) { }
        private System.Void .ctor() { }
        private UnityEngine.Collider <RegisterPorts>b__5_0() { }
        private UnityEngine.GameObject <RegisterPorts>b__5_1() { }

    }

    // TypeToken: 0x2000072
    public class UIButtonEvent : EventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput o;        // 0xB8

        // Methods
        private System.Void OnPostGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void OnClick() { }
        private System.Void .ctor() { }
        private UnityEngine.UI.Button <RegisterPorts>b__3_0() { }

    }

    // TypeToken: 0x2000073
    public class UIDropdownEvent : EventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput o;        // 0xB8
        private System.Int32 value;        // 0xC0

        // Methods
        private System.Void OnPostGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void OnValueChanged(System.Int32 value) { }
        private System.Void .ctor() { }
        private UnityEngine.UI.Dropdown <RegisterPorts>b__4_0() { }
        private System.Int32 <RegisterPorts>b__4_1() { }

    }

    // TypeToken: 0x2000074
    public class UIInputFieldEvent : EventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onValueChanged;        // 0xB8
        private FlowCanvas.FlowOutput onEndEdit;        // 0xC0
        private System.String value;        // 0xC8

        // Methods
        private System.Void OnPostGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void OnValueChanged(System.String value) { }
        private System.Void OnEndEdit(System.String value) { }
        private System.Void .ctor() { }
        private UnityEngine.UI.InputField <RegisterPorts>b__5_0() { }
        private System.String <RegisterPorts>b__5_1() { }

    }

    // TypeToken: 0x2000075
    public class UIPointerEvents : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onPointerDown;        // 0xC8
        private FlowCanvas.FlowOutput onPointerPressed;        // 0xD0
        private FlowCanvas.FlowOutput onPointerUp;        // 0xD8
        private FlowCanvas.FlowOutput onPointerEnter;        // 0xE0
        private FlowCanvas.FlowOutput onPointerExit;        // 0xE8
        private FlowCanvas.FlowOutput onPointerClick;        // 0xF0
        private FlowCanvas.FlowOutput onPointerDrag;        // 0xF8
        private FlowCanvas.FlowOutput onPointerDrop;        // 0x100
        private FlowCanvas.FlowOutput onPointerScroll;        // 0x108
        private UnityEngine.GameObject receiver;        // 0x110
        private UnityEngine.EventSystems.PointerEventData eventData;        // 0x118
        private System.Boolean updatePressed;        // 0x120

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnPointerDown(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> msg) { }
        private System.Void OnPointerUp(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> msg) { }
        private System.Collections.IEnumerator UpdatePressed() { }
        private System.Void OnPointerEnter(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> msg) { }
        private System.Void OnPointerExit(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> msg) { }
        private System.Void OnPointerClick(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> msg) { }
        private System.Void OnPointerDrag(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> msg) { }
        private System.Void OnPointerDrop(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> msg) { }
        private System.Void OnPointerScroll(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> msg) { }
        private System.Void .ctor() { }
        private UnityEngine.GameObject <RegisterPorts>b__12_0() { }
        private UnityEngine.EventSystems.PointerEventData <RegisterPorts>b__12_1() { }

    }

    // TypeToken: 0x2000077
    public class UIScrollbarEvent : EventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput o;        // 0xB8
        private System.Single value;        // 0xC0

        // Methods
        private System.Void OnPostGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void OnValueChanged(System.Single value) { }
        private System.Void .ctor() { }
        private UnityEngine.UI.Scrollbar <RegisterPorts>b__4_0() { }
        private System.Single <RegisterPorts>b__4_1() { }

    }

    // TypeToken: 0x2000078
    public class UISliderEvent : EventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput o;        // 0xB8
        private System.Single value;        // 0xC0

        // Methods
        private System.Void OnPostGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void OnValueChanged(System.Single value) { }
        private System.Void .ctor() { }
        private UnityEngine.UI.Slider <RegisterPorts>b__4_0() { }
        private System.Single <RegisterPorts>b__4_1() { }

    }

    // TypeToken: 0x2000079
    public class UIToggleEvent : EventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput o;        // 0xB8
        private System.Boolean state;        // 0xC0

        // Methods
        private System.Void OnPostGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void OnValueChanged(System.Boolean state) { }
        private System.Void .ctor() { }
        private UnityEngine.UI.Toggle <RegisterPorts>b__4_0() { }
        private System.Boolean <RegisterPorts>b__4_1() { }

    }

    // TypeToken: 0x200007A
    public class VisibilityEvents : RouterEventNode`1
    {
        // Fields
        private FlowCanvas.FlowOutput onVisible;        // 0xC8
        private FlowCanvas.FlowOutput onInvisible;        // 0xD0
        private UnityEngine.GameObject receiver;        // 0xD8

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Subscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void UnSubscribe(ParadoxNotion.Services.EventRouter router) { }
        private System.Void OnBecameVisible(ParadoxNotion.EventData msg) { }
        private System.Void OnBecameInvisible(ParadoxNotion.EventData msg) { }
        private System.Void .ctor() { }
        private UnityEngine.GameObject <RegisterPorts>b__3_0() { }

    }

    // TypeToken: 0x200007B
    public class ConditionalUpdateEvent : EventNode, IUpdatable, IGraphElement
    {
        // Fields
        private FlowCanvas.FlowOutput becameTrue;        // 0xB0
        private FlowCanvas.FlowOutput becameFalse;        // 0xB8
        private FlowCanvas.ValueInput<System.Boolean> condition;        // 0xC0
        private System.Boolean lastState;        // 0xC8

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007C
    public class DebugEvent : EventNode
    {
        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007D
    public class OscillatorEvent : EventNode, IUpdatable, IGraphElement
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.AnimationCurve> curve;        // 0xB0
        private System.Single time;        // 0xB8
        private System.Single value;        // 0xBC
        private FlowCanvas.FlowOutput hi;        // 0xC0
        private FlowCanvas.FlowOutput low;        // 0xC8

        // Methods
        private System.Void .ctor() { }
        private System.Void RegisterPorts() { }
        private System.Void OnGraphStarted() { }
        private System.Void Update() { }
        private System.Single <RegisterPorts>b__6_0() { }

    }

    // TypeToken: 0x200007E
    public class VariableChangedEvent : EventNode
    {
        // Fields
        public NodeCanvas.Framework.Internal.BBObjectParameter targetVariable;        // 0xB0
        private FlowCanvas.FlowOutput fOut;        // 0xB8
        private System.Object newValue;        // 0xC0

        // Methods
        private System.String get_name() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void OnValueChanged(System.Object value) { }
        private System.Void OnVariableRefChange(NodeCanvas.Framework.Variable newVarRef) { }
        private System.Void .ctor() { }
        private System.Object <RegisterPorts>b__7_0() { }

    }

    // TypeToken: 0x200007F
    public class Chance : FlowControlNode
    {
        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000081
    public class Cooldown : FlowControlNode
    {
        // Fields
        private UnityEngine.Coroutine coroutine;        // 0xB0
        private System.Single remaining;        // 0xB8
        private System.Single remainingNormalized;        // 0xBC
        private FlowCanvas.FlowOutput start;        // 0xC0
        private FlowCanvas.FlowOutput finish;        // 0xC8
        private FlowCanvas.FlowOutput update;        // 0xD0
        private FlowCanvas.ValueInput<System.Single> time;        // 0xD8

        // Methods
        private System.String get_name() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void Begin(FlowCanvas.Flow f) { }
        private System.Void Cancel(FlowCanvas.Flow f) { }
        private System.Collections.IEnumerator CountDown(FlowCanvas.Flow f) { }
        private System.Void .ctor() { }
        private System.Single <RegisterPorts>b__11_0() { }
        private System.Single <RegisterPorts>b__11_1() { }

    }

    // TypeToken: 0x2000083
    public class DoOnce : FlowControlNode
    {
        // Fields
        private System.Boolean called;        // 0xB0

        // Methods
        private System.Void OnGraphStarted() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000085
    public class ReadFlowParameter`1 : FlowControlNode
    {
        // Fields
        private T flowValue;        // 0x0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000087
    public class WriteFlowParameter`1 : FlowControlNode
    {
        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000089
    public class LatchBool : FlowControlNode
    {
        // Fields
        private System.Boolean latched;        // 0xB0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008B
    public class LatchInt : FlowControlNode
    {
        // Fields
        private System.Int32 _portCount;        // 0xB0
        private System.Int32 latched;        // 0xB4

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200008E
    public class ANDMerge : FlowControlNode
    {
        // Fields
        private System.Int32 _portCount;        // 0xB0
        public System.Single maxAwaitTime;        // 0xB4
        private FlowCanvas.FlowOutput fOut;        // 0xB8
        private System.Single[] calls;        // 0xC0
        private System.Int32 lastFrameCall;        // 0xC8

        // Methods
        private System.Void OnGraphStarted() { }
        private System.Void RegisterPorts() { }
        private System.Void Reset() { }
        private System.Void Check(System.Int32 index, FlowCanvas.Flow f) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000090
    public class AwaitAll : FlowControlNode
    {
        // Fields
        private System.Int32 _portCount;        // 0xB0
        public System.Single maxAwaitTime;        // 0xB4
        private FlowCanvas.FlowOutput fOut;        // 0xB8
        private System.Single[] calls;        // 0xC0
        private System.Int32 lastFrameCall;        // 0xC8

        // Methods
        private System.Void OnGraphStarted() { }
        private System.Void RegisterPorts() { }
        private System.Void Reset() { }
        private System.Void Check(System.Int32 index, FlowCanvas.Flow f) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000092
    public class ORMerge : FlowControlNode
    {
        // Fields
        private System.Int32 _portCount;        // 0xB0
        private FlowCanvas.FlowOutput fOut;        // 0xB8
        private System.Int32 lastFrameCall;        // 0xC0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Check(System.Int32 index, FlowCanvas.Flow f) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000094
    public class XORMerge : FlowControlNode
    {
        // Fields
        private System.Int32 _portCount;        // 0xB0
        private FlowCanvas.FlowOutput fOut;        // 0xB8
        private System.Int32[] calls;        // 0xC0
        private System.Int32 lastFrameCall;        // 0xC8

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Check(System.Int32 index, FlowCanvas.Flow f) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000096
    public class FlowControlNode : FlowNode
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000097
    public class Break : FlowControlNode
    {
        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }
        private System.Void <RegisterPorts>b__0_0(FlowCanvas.Flow f) { }

    }

    // TypeToken: 0x2000098
    public class ForEach : FlowControlNode
    {
        // Fields
        private System.Object currentObject;        // 0xB0
        private System.Int32 currentIndex;        // 0xB8
        private System.Boolean broken;        // 0xBC
        private FlowCanvas.ValueInput<System.Collections.IEnumerable> enumerableInput;        // 0xC0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Type GetNodeWildDefinitionType() { }
        private System.Void OnPortConnected(FlowCanvas.Port port, FlowCanvas.Port otherPort) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009A
    public class ForEach`1 : FlowControlNode
    {
        // Fields
        private T currentObject;        // 0x0
        private System.Int32 currentIndex;        // 0x0
        private System.Boolean broken;        // 0x0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009C
    public class ForLoop : FlowControlNode
    {
        // Fields
        public System.Boolean reverse;        // 0xB0
        private System.Int32 current;        // 0xB4
        private System.Boolean broken;        // 0xB8
        private FlowCanvas.ValueInput<System.Int32> first;        // 0xC0
        private FlowCanvas.ValueInput<System.Int32> last;        // 0xC8
        private FlowCanvas.ValueInput<System.Int32> step;        // 0xD0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009E
    public class Dummy : FlowControlNode
    {
        // Methods
        private System.String get_name() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A0
    public class Finish : FlowControlNode
    {
        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A2
    public class GoToLabel : FlowControlNode, IEditorMenuCallbackReceiver
    {
        // Fields
        public System.String identifier;        // 0xB0
        private FlowCanvas.FlowOutput <port>k__BackingField;        // 0xB8

        // Methods
        private FlowCanvas.FlowOutput get_port() { }
        private System.Void set_port(FlowCanvas.FlowOutput value) { }
        private System.String get_name() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A3
    public class GoToStatement : FlowControlNode, IHaveNodeReference, IGraphElement
    {
        // Fields
        public NodeCanvas.Framework.NodeReference<FlowCanvas.Nodes.GoToLabel> _targetLabel;        // 0xB0

        // Methods
        private NodeCanvas.Framework.INodeReference NodeCanvas.Framework.IHaveNodeReference.get_targetReference() { }
        private FlowCanvas.Nodes.GoToLabel get_target() { }
        private System.String get_name() { }
        private System.Void SetTarget(FlowCanvas.Nodes.GoToLabel newTarget) { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }
        private System.Void <RegisterPorts>b__8_0(FlowCanvas.Flow f) { }

    }

    // TypeToken: 0x20000A4
    public class Merge : FlowControlNode
    {
        // Fields
        private System.Int32 _portCount;        // 0xB0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A5
    public class Split : FlowControlNode
    {
        // Fields
        private System.Int32 _portCount;        // 0xB0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A7
    public class TryCatch : FlowControlNode
    {
        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A9
    public class CoroutineState : FlowControlNode
    {
        // Fields
        private System.Boolean active;        // 0xB0
        private UnityEngine.Coroutine coroutine;        // 0xB8

        // Methods
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Collections.IEnumerator DoRepeat(FlowCanvas.FlowOutput fStart, FlowCanvas.FlowOutput fUpdate, FlowCanvas.FlowOutput fFinish, FlowCanvas.Flow f) { }
        private System.Void .ctor() { }
        private System.Void <DoRepeat>b__4_0() { }

    }

    // TypeToken: 0x20000AC
    public class While : FlowControlNode
    {
        // Fields
        private UnityEngine.Coroutine coroutine;        // 0xB0

        // Methods
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Collections.IEnumerator DoWhile(FlowCanvas.FlowOutput fUpdate, FlowCanvas.FlowOutput fFinish, FlowCanvas.Flow f, FlowCanvas.ValueInput<System.Boolean> condition) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B0
    public class SelectOnBool`1 : FlowControlNode
    {
        // Fields
        private FlowCanvas.ValueInput<System.Boolean> condition;        // 0x0
        private FlowCanvas.ValueInput<T> isTrue;        // 0x0
        private FlowCanvas.ValueInput<T> isFalse;        // 0x0
        private FlowCanvas.ValueOutput<T> result;        // 0x0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }
        private T <RegisterPorts>b__4_0() { }

    }

    // TypeToken: 0x20000B1
    public class SelectOnEnum`1 : FlowControlNode
    {
        // Fields
        private ParadoxNotion.Serialization.SerializedTypeInfo _type;        // 0x0

        // Methods
        private System.Type get_type() { }
        private System.Void set_type(System.Type value) { }
        private System.Void RegisterPorts() { }
        private System.Type GetNodeWildDefinitionType() { }
        private System.Void OnPortConnected(FlowCanvas.Port port, FlowCanvas.Port otherPort) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B3
    public class SelectOnInt`1 : FlowControlNode
    {
        // Fields
        private System.Int32 _portCount;        // 0x0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B5
    public class SelectOnString`1 : FlowControlNode
    {
        // Fields
        public System.Collections.Generic.List<System.String> stringCases;        // 0x0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B7
    public class SelectOnTag`1 : FlowControlNode
    {
        // Fields
        private System.String[] _tagNames;        // 0x0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000B9
    public class Random : FlowControlNode
    {
        // Fields
        private System.Int32 _portCount;        // 0xB0
        private System.Int32 current;        // 0xB4

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BB
    public class SwitchBool : FlowControlNode
    {
        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BD
    public class SwitchComparison : FlowControlNode
    {
        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000BF
    public class SwitchEnum : FlowControlNode
    {
        // Fields
        private ParadoxNotion.Serialization.SerializedTypeInfo _type;        // 0xB0

        // Methods
        private System.Type get_type() { }
        private System.Void set_type(System.Type value) { }
        private System.Void RegisterPorts() { }
        private System.Type GetNodeWildDefinitionType() { }
        private System.Void OnPortConnected(FlowCanvas.Port port, FlowCanvas.Port otherPort) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C1
    public class SwitchInt : FlowControlNode
    {
        // Fields
        private System.Int32 _portCount;        // 0xB0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C3
    public class SwitchIntCustom : FlowControlNode
    {
        // Fields
        public System.Collections.Generic.List<System.Int32> intCases;        // 0xB0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C5
    public class SwitchProbability : FlowControlNode
    {
        // Fields
        private System.Int32 _portCount;        // 0xB0
        private System.Collections.Generic.List<FlowCanvas.ValueInput<System.Single>> probabilityValues;        // 0xB8
        private System.Collections.Generic.List<FlowCanvas.FlowOutput> probabilityOuts;        // 0xC0
        private System.Single[] cacheValues;        // 0xC8
        private System.Int32 current;        // 0xD0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void Enter(FlowCanvas.Flow f) { }
        private System.Void .ctor() { }
        private System.Int32 <RegisterPorts>b__5_0() { }

    }

    // TypeToken: 0x20000C6
    public class SwitchString : FlowControlNode
    {
        // Fields
        public System.Collections.Generic.List<System.String> comparisonOutputs;        // 0xB0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C8
    public class SwitchTag : FlowControlNode
    {
        // Fields
        private System.String[] _tagNames;        // 0xB0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CA
    public class FlipFlop : FlowControlNode
    {
        // Fields
        public System.Boolean isFlip;        // 0xB0
        private System.Boolean original;        // 0xB1

        // Methods
        private System.String get_name() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CC
    public class MultiToggle : FlowControlNode
    {
        // Fields
        private System.Int32 _portCount;        // 0xB0
        public System.Int32 current;        // 0xB4
        private System.Int32 original;        // 0xB8

        // Methods
        private System.String get_name() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CE
    public class Sequence : FlowControlNode
    {
        // Fields
        private System.Int32 _portCount;        // 0xB0
        public System.Int32 current;        // 0xB4
        private System.Int32 original;        // 0xB8

        // Methods
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.String get_name() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D0
    public class Toggle : FlowControlNode
    {
        // Fields
        public System.Boolean open;        // 0xB0
        private System.Boolean original;        // 0xB1

        // Methods
        private System.String get_name() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D2
    public class CustomFunctionCall : FlowControlNode
    {
        // Fields
        private System.String _sourceOutputUID;        // 0xB0
        private FlowCanvas.ValueInput[] portArgs;        // 0xB8
        private System.Object[] objectArgs;        // 0xC0
        private FlowCanvas.FlowOutput fOut;        // 0xC8
        private System.WeakReference<FlowCanvas.Nodes.CustomFunctionEvent> _sourceFunctionRef;        // 0xD0

        // Methods
        private System.String get_sourceFunctionUID() { }
        private System.Void set_sourceFunctionUID(System.String value) { }
        private FlowCanvas.Nodes.CustomFunctionEvent get_sourceFunction() { }
        private System.String get_name() { }
        private System.String get_description() { }
        private System.Void SetFunction(FlowCanvas.Nodes.CustomFunctionEvent func) { }
        private System.Void RegisterPorts() { }
        private System.Void Invoke(FlowCanvas.Flow f) { }
        private System.Void .ctor() { }
        private System.Boolean <get_sourceFunction>b__9_0(FlowCanvas.Nodes.CustomFunctionEvent i) { }

    }

    // TypeToken: 0x20000D3
    public class CustomFunctionEvent : EventNode, IInvokable, IGraphElement, IEditorMenuCallbackReceiver
    {
        // Fields
        public System.String identifier;        // 0xB0
        private System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition> _parameters;        // 0xB8
        private ParadoxNotion.DynamicParameterDefinition _returns;        // 0xC0
        private System.Object[] args;        // 0xC8
        private System.Object returnValue;        // 0xD0
        private FlowCanvas.FlowOutput onInvoke;        // 0xD8

        // Methods
        private System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition> get_parameters() { }
        private System.Void set_parameters(System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition> value) { }
        private ParadoxNotion.DynamicParameterDefinition get_returns() { }
        private System.Void set_returns(ParadoxNotion.DynamicParameterDefinition value) { }
        private System.Type get_returnType() { }
        private System.Type[] get_parameterTypes() { }
        private System.String get_name() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.String NodeCanvas.Framework.IInvokable.GetInvocationID() { }
        private System.Object NodeCanvas.Framework.IInvokable.Invoke(System.Object[] args) { }
        private System.Void NodeCanvas.Framework.IInvokable.InvokeAsync(System.Action<System.Object> callback, System.Object[] args) { }
        private System.Object Invoke(FlowCanvas.Flow f, System.Object[] args) { }
        private System.Void InvokeAsync(FlowCanvas.Flow f, FlowCanvas.FlowHandler flowCallback, System.Object[] args) { }
        private System.Object GetReturnValue() { }
        private System.Void AddParameter(System.Type type) { }
        private System.Void GatherPortsUpdateRefs() { }
        private System.Void .ctor() { }
        private System.Void <Invoke>b__23_0(System.Object o) { }
        private System.Boolean <GatherPortsUpdateRefs>b__27_0(FlowCanvas.Nodes.CustomFunctionCall n) { }

    }

    // TypeToken: 0x20000D8
    public class Return : FlowControlNode
    {
        // Fields
        public System.Boolean useReturnValue;        // 0xB0
        private FlowCanvas.ValueInput<System.Object> returnPort;        // 0xB8

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }
        private System.Void <RegisterPorts>b__2_0(FlowCanvas.Flow f) { }

    }

    // TypeToken: 0x20000D9
    public class CallableActionNodeBase : SimplexNode
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DA
    public class CallableActionNode : CallableActionNodeBase
    {
        // Methods
        private System.Void Invoke() { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DC
    public class CallableActionNode`1 : CallableActionNodeBase
    {
        // Methods
        private System.Void Invoke(T1 a) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DE
    public class CallableActionNode`2 : CallableActionNodeBase
    {
        // Methods
        private System.Void Invoke(T1 a, T2 b) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E0
    public class CallableActionNode`3 : CallableActionNodeBase
    {
        // Methods
        private System.Void Invoke(T1 a, T2 b, T3 c) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E2
    public class CallableActionNode`4 : CallableActionNodeBase
    {
        // Methods
        private System.Void Invoke(T1 a, T2 b, T3 c, T4 d) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E4
    public class CallableActionNode`5 : CallableActionNodeBase
    {
        // Methods
        private System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E6
    public class CallableActionNode`6 : CallableActionNodeBase
    {
        // Methods
        private System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E8
    public class CallableActionNode`7 : CallableActionNodeBase
    {
        // Methods
        private System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EA
    public class CallableActionNode`8 : CallableActionNodeBase
    {
        // Methods
        private System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EC
    public class CallableActionNode`9 : CallableActionNodeBase
    {
        // Methods
        private System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EE
    public class CallableActionNode`10 : CallableActionNodeBase
    {
        // Methods
        private System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F0
    public class CallableFunctionNodeBase : SimplexNode
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F1
    public class CallableFunctionNode`1 : CallableFunctionNodeBase
    {
        // Fields
        private TResult result;        // 0x0

        // Methods
        private TResult Invoke() { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F3
    public class CallableFunctionNode`2 : CallableFunctionNodeBase
    {
        // Fields
        private TResult result;        // 0x0

        // Methods
        private TResult Invoke(T1 a) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F5
    public class CallableFunctionNode`3 : CallableFunctionNodeBase
    {
        // Fields
        private TResult result;        // 0x0

        // Methods
        private TResult Invoke(T1 a, T2 b) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F7
    public class CallableFunctionNode`4 : CallableFunctionNodeBase
    {
        // Fields
        private TResult result;        // 0x0

        // Methods
        private TResult Invoke(T1 a, T2 b, T3 c) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F9
    public class CallableFunctionNode`5 : CallableFunctionNodeBase
    {
        // Fields
        private TResult result;        // 0x0

        // Methods
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FB
    public class CallableFunctionNode`6 : CallableFunctionNodeBase
    {
        // Fields
        private TResult result;        // 0x0

        // Methods
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FD
    public class CallableFunctionNode`7 : CallableFunctionNodeBase
    {
        // Fields
        private TResult result;        // 0x0

        // Methods
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000FF
    public class CallableFunctionNode`8 : CallableFunctionNodeBase
    {
        // Fields
        private TResult result;        // 0x0

        // Methods
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000101
    public class CallableFunctionNode`9 : CallableFunctionNodeBase
    {
        // Fields
        private TResult result;        // 0x0

        // Methods
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000103
    public class CallableFunctionNode`10 : CallableFunctionNodeBase
    {
        // Fields
        private TResult result;        // 0x0

        // Methods
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000105
    public class CallableFunctionNode`11 : CallableFunctionNodeBase
    {
        // Fields
        private TResult result;        // 0x0

        // Methods
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000107
    public class ExtractorNode : SimplexNode
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Type,System.Type> _extractors;        // 0x0

        // Methods
        private System.Type GetExtractorType(System.Type type) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000109
    public class ExtractorNode`3 : ExtractorNode
    {
        // Fields
        private T1 a;        // 0x0
        private T2 b;        // 0x0

        // Methods
        private System.Void Invoke(TInstance instance, T1& a, T2& b) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010B
    public class ExtractorNode`4 : ExtractorNode
    {
        // Fields
        private T1 a;        // 0x0
        private T2 b;        // 0x0
        private T3 c;        // 0x0

        // Methods
        private System.Void Invoke(TInstance instance, T1& a, T2& b, T3& c) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010D
    public class ExtractorNode`5 : ExtractorNode
    {
        // Fields
        private T1 a;        // 0x0
        private T2 b;        // 0x0
        private T3 c;        // 0x0
        private T4 d;        // 0x0

        // Methods
        private System.Void Invoke(TInstance instance, T1& a, T2& b, T3& c, T4& d) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010F
    public class ExtractorNode`6 : ExtractorNode
    {
        // Fields
        private T1 a;        // 0x0
        private T2 b;        // 0x0
        private T3 c;        // 0x0
        private T4 d;        // 0x0
        private T5 e;        // 0x0

        // Methods
        private System.Void Invoke(TInstance instance, T1& a, T2& b, T3& c, T4& d, T5& e) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000111
    public class ExtractorNode`7 : ExtractorNode
    {
        // Fields
        private T1 a;        // 0x0
        private T2 b;        // 0x0
        private T3 c;        // 0x0
        private T4 d;        // 0x0
        private T5 e;        // 0x0
        private T6 f;        // 0x0

        // Methods
        private System.Void Invoke(TInstance instance, T1& a, T2& b, T3& c, T4& d, T5& e, T6& f) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000113
    public class AddDictionaryItem`1 : CallableFunctionNode`4
    {
        // Methods
        private System.Collections.Generic.IDictionary<System.String,T> Invoke(System.Collections.Generic.IDictionary<System.String,T> dict, System.String key, T item) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000114
    public class GetDictionaryItem`1 : CallableFunctionNode`3
    {
        // Methods
        private T Invoke(System.Collections.Generic.IDictionary<System.String,T> dict, System.String key) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000115
    public class RemoveDictionaryKey`1 : CallableFunctionNode`3
    {
        // Methods
        private System.Collections.Generic.IDictionary<System.String,T> Invoke(System.Collections.Generic.IDictionary<System.String,T> dict, System.String key) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000116
    public class ClearDictionary : CallableFunctionNode`2
    {
        // Methods
        private System.Collections.IDictionary Invoke(System.Collections.IDictionary dict) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000117
    public class TryGetValue`1 : CallableFunctionNode`3
    {
        // Fields
        private System.Boolean <exists>k__BackingField;        // 0x0

        // Methods
        private System.Boolean get_exists() { }
        private System.Void set_exists(System.Boolean value) { }
        private T Invoke(System.Collections.Generic.IDictionary<System.String,T> dict, System.String key) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000118
    public class DictionaryContainsKey`1 : CallableFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Collections.Generic.IDictionary<System.String,T> dict, System.String key) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000119
    public class ClearList : CallableFunctionNode`2
    {
        // Methods
        private System.Collections.IList Invoke(System.Collections.IList list) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011A
    public class AddListItem`1 : CallableFunctionNode`3
    {
        // Methods
        private System.Collections.Generic.IList<T> Invoke(System.Collections.Generic.List<T> list, T item) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011B
    public class InsertListItem`1 : CallableFunctionNode`4
    {
        // Methods
        private System.Collections.Generic.IList<T> Invoke(System.Collections.Generic.List<T> list, System.Int32 index, T item) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011C
    public class RemoveListItem`1 : CallableFunctionNode`3
    {
        // Methods
        private System.Collections.Generic.IList<T> Invoke(System.Collections.Generic.List<T> list, T item) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011D
    public class RemoveListItemAt`1 : CallableFunctionNode`3
    {
        // Methods
        private System.Collections.Generic.IList<T> Invoke(System.Collections.Generic.List<T> list, System.Int32 index) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011E
    public class SetListItem`1 : CallableFunctionNode`4
    {
        // Methods
        private System.Collections.Generic.IList<T> Invoke(System.Collections.Generic.IList<T> list, System.Int32 index, T item) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011F
    public class ShuffleList`1 : CallableFunctionNode`2
    {
        // Methods
        private System.Collections.Generic.IList<T> Invoke(System.Collections.Generic.IList<T> list) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000120
    public class GetListItem`1 : PureFunctionNode`3
    {
        // Methods
        private T Invoke(System.Collections.Generic.IList<T> list, System.Int32 index) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000121
    public class GetRandomListItem`1 : PureFunctionNode`2
    {
        // Methods
        private T Invoke(System.Collections.Generic.IList<T> list) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000122
    public class GetLastListItem`1 : PureFunctionNode`2
    {
        // Methods
        private T Invoke(System.Collections.Generic.IList<T> list) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000123
    public class GetFirstListItem`1 : PureFunctionNode`2
    {
        // Methods
        private T Invoke(System.Collections.Generic.IList<T> list) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000124
    public class GetListItemIndex : PureFunctionNode`3
    {
        // Methods
        private System.Int32 Invoke(System.Collections.IList list, System.Object item) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000125
    public class IsNotNull : PureFunctionNode`2
    {
        // Methods
        private System.Boolean Invoke(System.Object OBJECT) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000126
    public class IsOfType : PureFunctionNode`3
    {
        // Fields
        private System.Object <OBJECT>k__BackingField;        // 0x30

        // Methods
        private System.Object get_OBJECT() { }
        private System.Void set_OBJECT(System.Object value) { }
        private System.Boolean Invoke(System.Object OBJECT, System.Type type) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000127
    public class AnyGreaterThan : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.IComparable a, System.IComparable b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000128
    public class AnyGreaterEqualThan : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.IComparable a, System.IComparable b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000129
    public class AnyLessThan : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.IComparable a, System.IComparable b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012A
    public class AnyLessEqualThan : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.IComparable a, System.IComparable b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012B
    public class AnyEqual : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Object a, System.Object b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012C
    public class AnyNotEqual : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Object a, System.Object b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012D
    public class FloatAdd : PureFunctionNode`3
    {
        // Methods
        private System.Single Invoke(System.Single a, System.Single b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012E
    public class FloatSubtract : PureFunctionNode`3
    {
        // Methods
        private System.Single Invoke(System.Single a, System.Single b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012F
    public class FloatMultiply : PureFunctionNode`3
    {
        // Methods
        private System.Single Invoke(System.Single a, System.Single b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000130
    public class FloatDivide : PureFunctionNode`3
    {
        // Methods
        private System.Single Invoke(System.Single a, System.Single b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000131
    public class FloatModulo : PureFunctionNode`3
    {
        // Methods
        private System.Single Invoke(System.Single value, System.Single mod) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000132
    public class FloatGreaterThan : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Single a, System.Single b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000133
    public class FloatGreaterEqualThan : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Single a, System.Single b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000134
    public class FloatLessThan : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Single a, System.Single b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000135
    public class FloatLessEqualThan : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Single a, System.Single b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000136
    public class FloatEqual : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Single a, System.Single b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000137
    public class FloatNotEqual : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Single a, System.Single b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000138
    public class FloatInvert : PureFunctionNode`2
    {
        // Methods
        private System.Single Invoke(System.Single value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000139
    public class FloatSnap : PureFunctionNode`3
    {
        // Methods
        private System.Int32 Invoke(System.Single value, System.Int32 interval) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013A
    public class IntegerAdd : PureFunctionNode`3
    {
        // Methods
        private System.Int32 Invoke(System.Int32 a, System.Int32 b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013B
    public class IntegerSubtract : PureFunctionNode`3
    {
        // Methods
        private System.Int32 Invoke(System.Int32 a, System.Int32 b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013C
    public class IntegerMultiply : PureFunctionNode`3
    {
        // Methods
        private System.Int32 Invoke(System.Int32 a, System.Int32 b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013D
    public class IntegerDivide : PureFunctionNode`3
    {
        // Methods
        private System.Int32 Invoke(System.Int32 a, System.Int32 b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013E
    public class IntegerModulo : PureFunctionNode`3
    {
        // Methods
        private System.Int32 Invoke(System.Int32 value, System.Int32 mod) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013F
    public class IntegerGreaterThan : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Int32 a, System.Int32 b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000140
    public class IntegerGreaterEqualThan : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Int32 a, System.Int32 b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000141
    public class IntegerLessThan : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Int32 a, System.Int32 b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000142
    public class IntegerLessEqualThan : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Int32 a, System.Int32 b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000143
    public class IntegerEqual : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Int32 a, System.Int32 b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000144
    public class IntegerNotEqual : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Int32 a, System.Int32 b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000145
    public class IntegerInvert : PureFunctionNode`2
    {
        // Methods
        private System.Int32 Invoke(System.Int32 value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000146
    public class IntegerSnap : PureFunctionNode`3
    {
        // Methods
        private System.Int32 Invoke(System.Int32 value, System.Int32 interval) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000147
    public class BooleanEqual : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Boolean a, System.Boolean b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000148
    public class BooleanNotEqual : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(System.Boolean a, System.Boolean b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000149
    public class AND : PureFunctionNode`1
    {
        // Fields
        private FlowCanvas.ValueInput<System.Boolean> a;        // 0x30
        private FlowCanvas.ValueInput<System.Boolean> b;        // 0x38

        // Methods
        private System.Boolean Invoke() { }
        private System.Void OnRegisterExtraPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014A
    public class OR : PureFunctionNode`1
    {
        // Fields
        private FlowCanvas.ValueInput<System.Boolean> a;        // 0x30
        private FlowCanvas.ValueInput<System.Boolean> b;        // 0x38

        // Methods
        private System.Boolean Invoke() { }
        private System.Void OnRegisterExtraPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014B
    public class XOR : PureFunctionNode`1
    {
        // Fields
        private FlowCanvas.ValueInput<System.Boolean> a;        // 0x30
        private FlowCanvas.ValueInput<System.Boolean> b;        // 0x38

        // Methods
        private System.Boolean Invoke() { }
        private System.Void OnRegisterExtraPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014C
    public class NOT : PureFunctionNode`2
    {
        // Methods
        private System.Boolean Invoke(System.Boolean value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014D
    public class Vector3Equal : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(UnityEngine.Vector3 a, UnityEngine.Vector3 b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014E
    public class Vector3NotEqual : PureFunctionNode`3
    {
        // Methods
        private System.Boolean Invoke(UnityEngine.Vector3 a, UnityEngine.Vector3 b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200014F
    public class Vector3Add : PureFunctionNode`3
    {
        // Methods
        private UnityEngine.Vector3 Invoke(UnityEngine.Vector3 a, UnityEngine.Vector3 b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000150
    public class Vector3Subtract : PureFunctionNode`3
    {
        // Methods
        private UnityEngine.Vector3 Invoke(UnityEngine.Vector3 a, UnityEngine.Vector3 b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000151
    public class Vector3Multiply : PureFunctionNode`3
    {
        // Methods
        private UnityEngine.Vector3 Invoke(UnityEngine.Vector3 a, System.Single b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000152
    public class Vector3Divide : PureFunctionNode`3
    {
        // Methods
        private UnityEngine.Vector3 Invoke(UnityEngine.Vector3 a, System.Single b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000153
    public class Vector3Invert : PureFunctionNode`2
    {
        // Methods
        private UnityEngine.Vector3 Invoke(UnityEngine.Vector3 value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000154
    public class BitwiseAnd`1 : PureFunctionNode`3
    {
        // Methods
        private T Invoke(T a, T b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000155
    public class BitwiseOr`1 : PureFunctionNode`3
    {
        // Methods
        private T Invoke(T a, T b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000156
    public class BitwiseInvert`1 : PureFunctionNode`2
    {
        // Methods
        private T Invoke(T a) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000157
    public class Wait : LatentActionNode`1
    {
        // Fields
        private System.Single <timeLeft>k__BackingField;        // 0x68
        private System.Single <normalized>k__BackingField;        // 0x6C

        // Methods
        private System.Single get_timeLeft() { }
        private System.Void set_timeLeft(System.Single value) { }
        private System.Single get_normalized() { }
        private System.Void set_normalized(System.Single value) { }
        private System.Collections.IEnumerator Invoke(System.Single time) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000159
    public class WaitForOneFrame : LatentActionNode
    {
        // Methods
        private System.Boolean get_allowRoutineQueueing() { }
        private System.Collections.IEnumerator Invoke() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200015B
    public class WaitForPhysicsFrame : LatentActionNode
    {
        // Methods
        private System.Boolean get_allowRoutineQueueing() { }
        private System.Collections.IEnumerator Invoke() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200015D
    public class WaitForEndOfFrame : LatentActionNode
    {
        // Methods
        private System.Boolean get_allowRoutineQueueing() { }
        private System.Collections.IEnumerator Invoke() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200015F
    public class WaitUntil : LatentActionNode
    {
        // Fields
        private FlowCanvas.ValueInput<System.Boolean> condition;        // 0x68

        // Methods
        private System.Boolean get_allowRoutineQueueing() { }
        private System.Collections.IEnumerator Invoke() { }
        private System.Void OnRegisterExtraPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000161
    public class WaitWhile : LatentActionNode
    {
        // Fields
        private FlowCanvas.ValueInput<System.Boolean> condition;        // 0x68

        // Methods
        private System.Boolean get_allowRoutineQueueing() { }
        private System.Collections.IEnumerator Invoke() { }
        private System.Void OnRegisterExtraPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000163
    public class DeltaTimed : PureFunctionNode`3
    {
        // Methods
        private System.Single Invoke(System.Single value, System.Single multiplier) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000164
    public class DeltaTimedVector3 : PureFunctionNode`3
    {
        // Methods
        private UnityEngine.Vector3 Invoke(UnityEngine.Vector3 value, System.Single multiplier) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000165
    public class Buffer`1 : PureFunctionNode`3
    {
        // Fields
        private System.Int32 lastFrame;        // 0x0
        private System.Collections.Generic.Queue<T> q;        // 0x0

        // Methods
        private T Invoke(T value, System.Int32 size) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000166
    public class DampFloat : PureFunctionNode`4
    {
        // Methods
        private System.Single Invoke(System.Single current, System.Single target, System.Single damp) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000167
    public class DampVector3 : PureFunctionNode`4
    {
        // Methods
        private UnityEngine.Vector3 Invoke(UnityEngine.Vector3 current, UnityEngine.Vector3 target, System.Single damp) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000168
    public class LerpFloat : PureFunctionNode`5
    {
        // Methods
        private System.Single Invoke(System.Single a, System.Single b, System.Single t, ParadoxNotion.Animation.EaseType interpolation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000169
    public class LerpVector3 : PureFunctionNode`5
    {
        // Methods
        private UnityEngine.Vector3 Invoke(UnityEngine.Vector3 a, UnityEngine.Vector3 b, System.Single t, ParadoxNotion.Animation.EaseType interpolation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200016A
    public class LerpQuaternion : PureFunctionNode`5
    {
        // Methods
        private UnityEngine.Quaternion Invoke(UnityEngine.Quaternion a, UnityEngine.Quaternion b, System.Single t, ParadoxNotion.Animation.EaseType interpolation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200016B
    public class LerpColor : PureFunctionNode`5
    {
        // Methods
        private UnityEngine.Color Invoke(UnityEngine.Color a, UnityEngine.Color b, System.Single t, ParadoxNotion.Animation.EaseType interpolation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200016C
    public class TweenFloat : LatentActionNode`4
    {
        // Fields
        private System.Single <value>k__BackingField;        // 0x68

        // Methods
        private System.Single get_value() { }
        private System.Void set_value(System.Single value) { }
        private System.Collections.IEnumerator Invoke(System.Single from, System.Single to, System.Single duration, ParadoxNotion.Animation.EaseType interpolation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200016E
    public class TweenVector3 : LatentActionNode`4
    {
        // Fields
        private UnityEngine.Vector3 <value>k__BackingField;        // 0x68

        // Methods
        private UnityEngine.Vector3 get_value() { }
        private System.Void set_value(UnityEngine.Vector3 value) { }
        private System.Collections.IEnumerator Invoke(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single duration, ParadoxNotion.Animation.EaseType interpolation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000170
    public class TweenQuaternion : LatentActionNode`4
    {
        // Fields
        private UnityEngine.Quaternion <value>k__BackingField;        // 0x68

        // Methods
        private UnityEngine.Quaternion get_value() { }
        private System.Void set_value(UnityEngine.Quaternion value) { }
        private System.Collections.IEnumerator Invoke(UnityEngine.Quaternion from, UnityEngine.Quaternion to, System.Single duration, ParadoxNotion.Animation.EaseType interpolation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000172
    public class TweenColor : LatentActionNode`4
    {
        // Fields
        private UnityEngine.Color <value>k__BackingField;        // 0x68

        // Methods
        private UnityEngine.Color get_value() { }
        private System.Void set_value(UnityEngine.Color value) { }
        private System.Collections.IEnumerator Invoke(UnityEngine.Color from, UnityEngine.Color to, System.Single duration, ParadoxNotion.Animation.EaseType interpolation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000174
    public class TweenPosition : LatentActionNode`5
    {
        // Methods
        private System.Collections.IEnumerator Invoke(UnityEngine.Transform transform, UnityEngine.Vector3 position, System.Single duration, ParadoxNotion.Animation.EaseType interpolation, System.Boolean relative) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000176
    public class TweenRotation : LatentActionNode`5
    {
        // Methods
        private System.Collections.IEnumerator Invoke(UnityEngine.Transform transform, UnityEngine.Vector3 rotation, System.Single duration, ParadoxNotion.Animation.EaseType interpolation, System.Boolean relative) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000178
    public class TweenScale : LatentActionNode`5
    {
        // Methods
        private System.Collections.IEnumerator Invoke(UnityEngine.Transform transform, UnityEngine.Vector3 scale, System.Single duration, ParadoxNotion.Animation.EaseType interpolation, System.Boolean relative) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017A
    public class AddComponent`1 : CallableFunctionNode`3
    {
        // Methods
        private T Invoke(UnityEngine.GameObject gameObject, System.Boolean tryGetExisting) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017B
    public class GetComponent`1 : PureFunctionNode`2
    {
        // Fields
        private T _component;        // 0x0

        // Methods
        private T Invoke(UnityEngine.GameObject gameObject) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017C
    public class Instantiate`1 : CallableFunctionNode`5
    {
        // Methods
        private T Invoke(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017D
    public class NewScriptableObject`1 : CallableFunctionNode`1
    {
        // Methods
        private T Invoke() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017E
    public class GetChildTransforms : PureFunctionNode`2
    {
        // Methods
        private System.Collections.Generic.IEnumerable<UnityEngine.Transform> Invoke(UnityEngine.Transform parent) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200017F
    public class Cast`1 : PureFunctionNode`2
    {
        // Methods
        private T Invoke(System.Object obj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000180
    public class Identity`1 : PureFunctionNode`2
    {
        // Methods
        private System.String get_name() { }
        private T Invoke(T value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000181
    public class Cache`1 : CallableFunctionNode`2
    {
        // Methods
        private T Invoke(T value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000182
    public class RemapFloat : PureFunctionNode`6
    {
        // Methods
        private System.Single Invoke(System.Single current, System.Single iMin, System.Single iMax, System.Single oMin, System.Single oMax) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000183
    public class RemapVector3 : PureFunctionNode`6
    {
        // Methods
        private UnityEngine.Vector3 Invoke(System.Single current, System.Single iMin, System.Single iMax, UnityEngine.Vector3 oMin, UnityEngine.Vector3 oMax) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000184
    public class LogValue : CallableActionNode`1
    {
        // Methods
        private System.Void Invoke(System.Object obj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000185
    public class LogText : CallableActionNode`1
    {
        // Methods
        private System.Void Invoke(System.String text) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000186
    public class SendEvent : CallableActionNode`2
    {
        // Methods
        private System.Void Invoke(NodeCanvas.Framework.GraphOwner target, System.String eventName) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000187
    public class SendEvent`1 : CallableActionNode`3
    {
        // Methods
        private System.Void Invoke(NodeCanvas.Framework.GraphOwner target, System.String eventName, T eventValue) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000188
    public class SendGlobalEvent : CallableActionNode`1
    {
        // Methods
        private System.Void Invoke(System.String eventName) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000189
    public class SendGlobalEvent`1 : CallableActionNode`2
    {
        // Methods
        private System.Void Invoke(System.String eventName, T eventValue) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200018A
    public class LatentActionNodeBase : SimplexNode
    {
        // Fields
        public FlowCanvas.Nodes.LatentActionNodeBase.InvocationMode invocationMode;        // 0x30
        private FlowCanvas.FlowOutput onStart;        // 0x38
        private FlowCanvas.FlowOutput onUpdate;        // 0x40
        private FlowCanvas.FlowOutput onFinish;        // 0x48
        private System.Collections.Generic.Queue<FlowCanvas.Nodes.LatentActionNodeBase.RoutineData> routineQueue;        // 0x50
        private UnityEngine.Coroutine currentCoroutine;        // 0x58
        private System.Boolean graphStoped;        // 0x60

        // Methods
        private System.String get_name() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void Begin(System.Collections.IEnumerator enumerator, FlowCanvas.Flow f) { }
        private System.Void BreakAll(System.Boolean callFinish) { }
        private System.Collections.IEnumerator InternalCoroutine(FlowCanvas.Nodes.LatentActionNodeBase.RoutineData data) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node) { }
        private System.Void OnBreak() { }
        private System.Boolean get_allowRoutineQueueing() { }
        private System.Void .ctor() { }
        private System.Void <InternalCoroutine>b__15_0() { }
        private System.Void <OnRegisterPorts>b__16_0(FlowCanvas.Flow f) { }
        private System.Void <OnRegisterPorts>b__16_1(FlowCanvas.Flow f) { }

    }

    // TypeToken: 0x200018E
    public class LatentActionNode : LatentActionNodeBase
    {
        // Methods
        private System.Collections.IEnumerator Invoke() { }
        private System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }
        private System.Void <OnRegisterDerivedPorts>b__1_0(FlowCanvas.Flow f) { }

    }

    // TypeToken: 0x200018F
    public class LatentActionNode`1 : LatentActionNodeBase
    {
        // Methods
        private System.Collections.IEnumerator Invoke(T1 a) { }
        private System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000191
    public class LatentActionNode`2 : LatentActionNodeBase
    {
        // Methods
        private System.Collections.IEnumerator Invoke(T1 a, T2 b) { }
        private System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000193
    public class LatentActionNode`3 : LatentActionNodeBase
    {
        // Methods
        private System.Collections.IEnumerator Invoke(T1 a, T2 b, T3 c) { }
        private System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000195
    public class LatentActionNode`4 : LatentActionNodeBase
    {
        // Methods
        private System.Collections.IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d) { }
        private System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000197
    public class LatentActionNode`5 : LatentActionNodeBase
    {
        // Methods
        private System.Collections.IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e) { }
        private System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000199
    public class LatentActionNode`6 : LatentActionNodeBase
    {
        // Methods
        private System.Collections.IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f) { }
        private System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200019B
    public class LatentActionNode`7 : LatentActionNodeBase
    {
        // Methods
        private System.Collections.IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) { }
        private System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200019D
    public class LatentActionNode`8 : LatentActionNodeBase
    {
        // Methods
        private System.Collections.IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h) { }
        private System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200019F
    public class LatentActionNode`9 : LatentActionNodeBase
    {
        // Methods
        private System.Collections.IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i) { }
        private System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A1
    public class LatentActionNode`10 : LatentActionNodeBase
    {
        // Methods
        private System.Collections.IEnumerator Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j) { }
        private System.Void OnRegisterDerivedPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A3
    public class PureFunctionNodeBase : SimplexNode
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A4
    public class PureFunctionNode`1 : PureFunctionNodeBase
    {
        // Methods
        private TResult Invoke() { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }
        private TResult <OnRegisterPorts>b__1_0() { }

    }

    // TypeToken: 0x20001A5
    public class PureFunctionNode`2 : PureFunctionNodeBase
    {
        // Methods
        private TResult Invoke(T1 a) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A7
    public class PureFunctionNode`3 : PureFunctionNodeBase
    {
        // Methods
        private TResult Invoke(T1 a, T2 b) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A9
    public class PureFunctionNode`4 : PureFunctionNodeBase
    {
        // Methods
        private TResult Invoke(T1 a, T2 b, T3 c) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001AB
    public class PureFunctionNode`5 : PureFunctionNodeBase
    {
        // Methods
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001AD
    public class PureFunctionNode`6 : PureFunctionNodeBase
    {
        // Methods
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001AF
    public class PureFunctionNode`7 : PureFunctionNodeBase
    {
        // Methods
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B1
    public class PureFunctionNode`8 : PureFunctionNodeBase
    {
        // Methods
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B3
    public class PureFunctionNode`9 : PureFunctionNodeBase
    {
        // Methods
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B5
    public class PureFunctionNode`10 : PureFunctionNodeBase
    {
        // Methods
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B7
    public class PureFunctionNode`11 : PureFunctionNodeBase
    {
        // Methods
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001B9
    public class SimplexNode
    {
        // Fields
        private System.String _name;        // 0x10
        private System.String _description;        // 0x18
        private FlowCanvas.FlowNode <parentNode>k__BackingField;        // 0x20
        private System.Reflection.ParameterInfo[] _parameters;        // 0x28

        // Methods
        private FlowCanvas.FlowNode get_parentNode() { }
        private System.Void set_parentNode(FlowCanvas.FlowNode value) { }
        private System.String get_name() { }
        private System.String get_description() { }
        private System.Reflection.ParameterInfo[] get_parameters() { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void SetDefaultParameters(FlowCanvas.FlowNode node) { }
        private System.Void OnRegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void OnRegisterExtraPorts(FlowCanvas.FlowNode node) { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphPaused() { }
        private System.Void OnGraphUnpaused() { }
        private System.Void OnGraphStoped() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001BA
    public class SimplexNodeWrapper : FlowNode
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001BB
    public class SimplexNodeWrapper`1 : SimplexNodeWrapper
    {
        // Fields
        private T _simplexNode;        // 0x0

        // Methods
        private T get_simplexNode() { }
        private System.String get_name() { }
        private System.String get_description() { }
        private System.Type GetNodeWildDefinitionType() { }
        private System.Void OnCreate(NodeCanvas.Framework.Graph assignedGraph) { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphPaused() { }
        private System.Void OnGraphUnpaused() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001BC
    public class EventUniversalDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001BD
    public class EventUniversalDelegate`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1) { }
        private System.IAsyncResult BeginInvoke(T1 arg1, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001BE
    public class EventUniversalDelegate`2 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2) { }
        private System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001BF
    public class EventUniversalDelegate`3 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3) { }
        private System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001C0
    public class EventUniversalDelegate`4 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        private System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001C1
    public class EventUniversalDelegate`5 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
        private System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001C2
    public class EventUniversalDelegate`6 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
        private System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001C3
    public class EventUniversalDelegate`7 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
        private System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001C4
    public class EventUniversalDelegate`8 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
        private System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001C5
    public class EventUniversalDelegate`9 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
        private System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001C6
    public class EventUniversalDelegate`10 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
        private System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001C7
    public class GeneratedKeyAttribute : Attribute
    {
        // Fields
        private System.String memberString;        // 0x10

        // Methods
        private System.Void .ctor(System.String memberName) { }
        private System.String get_MemberName() { }

    }

    // TypeToken: 0x20001C8
    public struct ParamDef
    {
        // Fields
        public System.Type paramType;        // 0x10
        public System.Type arrayType;        // 0x18
        public FlowCanvas.Nodes.ParamMode paramMode;        // 0x20
        public System.String portName;        // 0x28
        public System.String portId;        // 0x30
        public System.Boolean isParamsArray;        // 0x38
        public System.Reflection.MemberInfo presentedInfo;        // 0x40

    }

    // TypeToken: 0x20001C9
    public struct ParametresDef
    {
        // Fields
        public System.Collections.Generic.List<FlowCanvas.Nodes.ParamDef> paramDefinitions;        // 0x10
        public FlowCanvas.Nodes.ParamDef instanceDef;        // 0x18
        public FlowCanvas.Nodes.ParamDef resultDef;        // 0x50

    }

    // TypeToken: 0x20001CA
    public struct ParamMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static FlowCanvas.Nodes.ParamMode Undefined;        // 0x0
        public static FlowCanvas.Nodes.ParamMode In;        // 0x0
        public static FlowCanvas.Nodes.ParamMode Out;        // 0x0
        public static FlowCanvas.Nodes.ParamMode Ref;        // 0x0
        public static FlowCanvas.Nodes.ParamMode Instance;        // 0x0
        public static FlowCanvas.Nodes.ParamMode Result;        // 0x0

    }

    // TypeToken: 0x20001CB
    public class ReflectedNodesHelper
    {
        // Fields
        private static System.String RETURN_VALUE_NAME;        // 0x0

        // Methods
        private FlowCanvas.Nodes.ParamDef GetGetterDefFromInfo(System.Reflection.MemberInfo info) { }
        private FlowCanvas.Nodes.ParamDef GetDefFromInfo(System.Reflection.ParameterInfo info, System.Boolean last) { }
        private System.Boolean InitParams(System.Type targetType, System.Boolean isStatic, System.Reflection.MemberInfo[] infos, FlowCanvas.Nodes.ParametresDef& parametres) { }
        private System.Boolean InitParams(System.Reflection.ParameterInfo[] prms, System.Type returnType, FlowCanvas.Nodes.ParametresDef& parametres) { }
        private System.Boolean InitParams(System.Reflection.ConstructorInfo constructor, FlowCanvas.Nodes.ParametresDef& parametres) { }
        private System.Boolean InitParams(System.Reflection.MethodInfo method, FlowCanvas.Nodes.ParametresDef& parametres) { }
        private System.Boolean InitParams(System.Reflection.FieldInfo field, FlowCanvas.Nodes.ParametresDef& parametres) { }
        private System.String GetGeneratedKey(System.Reflection.MemberInfo memberInfo) { }

    }

    // TypeToken: 0x20001CC
    public class UniversalDelegate : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(FlowCanvas.Nodes.UniversalDelegateParam[] delegateParams) { }
        private System.IAsyncResult BeginInvoke(FlowCanvas.Nodes.UniversalDelegateParam[] delegateParams, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x20001CD
    public class UniversalDelegateParam
    {
        // Fields
        public FlowCanvas.Nodes.ParamDef paramDef;        // 0x10
        public System.Boolean paramsArrayNeeded;        // 0x48
        public System.Int32 paramsArrayCount;        // 0x4C
        public FlowCanvas.Nodes.UniversalDelegate referencedDelegate;        // 0x50
        public FlowCanvas.Nodes.UniversalDelegateParam[] referencedParams;        // 0x58

        // Methods
        private System.Type GetCurrentType() { }
        private System.Void RegisterAsInput(FlowCanvas.FlowNode node) { }
        private System.Void RegisterAsOutput(FlowCanvas.FlowNode node) { }
        private System.Void RegisterAsOutput(FlowCanvas.FlowNode node, System.Action beforeReturn) { }
        private System.Void RegisterAsOutput(FlowCanvas.FlowNode node, System.Action<FlowCanvas.Nodes.UniversalDelegateParam> beforeReturn) { }
        private System.Void SetFromInput() { }
        private System.Void SetFromValue(System.Object value) { }
        private System.Reflection.FieldInfo get_ValueField() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001CE
    public class UniversalDelegateParam`1 : UniversalDelegateParam
    {
        // Fields
        public T value;        // 0x0
        private FlowCanvas.ValueInput<T> valueInput;        // 0x0
        private static System.Reflection.FieldInfo _fieldInfo;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Type GetCurrentType() { }
        private System.Void RegisterAsInput(FlowCanvas.FlowNode node) { }
        private System.Void RegisterAsOutputInternal(FlowCanvas.FlowNode node, System.Delegate beforeReturn) { }
        private System.Void RegisterAsOutput(FlowCanvas.FlowNode node) { }
        private System.Void RegisterAsOutput(FlowCanvas.FlowNode node, System.Action beforeReturn) { }
        private System.Void RegisterAsOutput(FlowCanvas.FlowNode node, System.Action<FlowCanvas.Nodes.UniversalDelegateParam> beforeReturn) { }
        private System.Void SetFromInput() { }
        private System.Void SetFromValue(System.Object newValue) { }
        private System.Reflection.FieldInfo get_ValueField() { }

    }

    // TypeToken: 0x20001D0
    public class UniversalDelegateParam`2 : UniversalDelegateParam`1
    {
        // Fields
        private FlowCanvas.ValueInput<TValue>[] valueInputs;        // 0x0

        // Methods
        private System.Void RegisterAsInput(FlowCanvas.FlowNode node) { }
        private System.Void SetFromInput() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D1
    public class BaseReflectedConstructorNode
    {
        // Fields
        private static System.Func<System.Reflection.ConstructorInfo,FlowCanvas.Nodes.BaseReflectedConstructorNode> OnGetAotReflectedConstructorNode;        // 0x0
        protected System.Reflection.ConstructorInfo constructorInfo;        // 0x10
        protected System.Collections.Generic.List<FlowCanvas.Nodes.ParamDef> paramDefinitions;        // 0x18
        protected FlowCanvas.Nodes.ParamDef instanceDef;        // 0x20
        protected FlowCanvas.Nodes.ParamDef resultDef;        // 0x58
        protected FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options;        // 0x90

        // Methods
        private System.Void add_OnGetAotReflectedConstructorNode(System.Func<System.Reflection.ConstructorInfo,FlowCanvas.Nodes.BaseReflectedConstructorNode> value) { }
        private System.Void remove_OnGetAotReflectedConstructorNode(System.Func<System.Reflection.ConstructorInfo,FlowCanvas.Nodes.BaseReflectedConstructorNode> value) { }
        private FlowCanvas.Nodes.BaseReflectedConstructorNode GetConstructorNode(System.Reflection.ConstructorInfo targetConstructor, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Boolean Init(System.Reflection.ConstructorInfo constructor, FlowCanvas.Nodes.ParametresDef parametres) { }
        private System.Boolean InitInternal(System.Reflection.ConstructorInfo constructor) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D2
    public class PureReflectionConstructorNode : BaseReflectedConstructorNode
    {
        // Fields
        private System.Object resultObject;        // 0x98
        private System.Object[] callParams;        // 0xA0
        private FlowCanvas.ValueInput[] inputs;        // 0xA8
        private FlowCanvas.ValueInput[] arrayInputs;        // 0xB0
        private System.Int32 arrayParamsInput;        // 0xB8
        private System.Type arrayParamsType;        // 0xC0

        // Methods
        private System.Boolean InitInternal(System.Reflection.ConstructorInfo constructor) { }
        private System.Void Call() { }
        private System.Void RegisterOutput(FlowCanvas.FlowNode node, System.Boolean callable, FlowCanvas.Nodes.ParamDef def, System.Int32 idx) { }
        private System.Void RegisterInput(FlowCanvas.FlowNode node, FlowCanvas.Nodes.ParamDef def, System.Int32 idx) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D6
    public class ReflectedDelegateEvent
    {
        // Fields
        private FlowCanvas.Nodes.ReflectedDelegateEvent.DelegateEventCallback onCallback;        // 0x10
        private System.Delegate theDelegate;        // 0x18

        // Methods
        private System.Void add_onCallback(FlowCanvas.Nodes.ReflectedDelegateEvent.DelegateEventCallback value) { }
        private System.Void remove_onCallback(FlowCanvas.Nodes.ReflectedDelegateEvent.DelegateEventCallback value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Type delegateType) { }
        private System.Void Add(FlowCanvas.Nodes.ReflectedDelegateEvent.DelegateEventCallback callback) { }
        private System.Void Remove(FlowCanvas.Nodes.ReflectedDelegateEvent.DelegateEventCallback callback) { }
        private System.Delegate AsDelegate() { }
        private System.Reflection.MethodInfo GetMethodForDelegateType(System.Type delegateType) { }
        private System.Void Callback0() { }
        private System.Void Callback1(T0 arg0) { }
        private System.Void Callback2(T0 arg0, T1 arg1) { }
        private System.Void Callback3(T0 arg0, T1 arg1, T2 arg2) { }
        private System.Void Callback4(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
        private System.Void Callback5(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        private System.Void Callback6(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
        private System.Void Callback7(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
        private System.Void Callback8(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
        private System.Void Callback9(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
        private System.Void Callback10(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
        private System.Delegate op_Explicit(FlowCanvas.Nodes.ReflectedDelegateEvent that) { }

    }

    // TypeToken: 0x20001D9
    public class ReflectedUnityEvent
    {
        // Fields
        private FlowCanvas.Nodes.ReflectedUnityEvent.UnityEventCallback _callback;        // 0x10
        private System.Type _eventType;        // 0x18
        private System.Reflection.MethodInfo _addListenerMethod;        // 0x20
        private System.Reflection.MethodInfo _removeListenerMethod;        // 0x28
        private System.Reflection.ParameterInfo[] _parameters;        // 0x30
        private System.Reflection.MethodInfo _callMethod;        // 0x38

        // Methods
        private System.Void add__callback(FlowCanvas.Nodes.ReflectedUnityEvent.UnityEventCallback value) { }
        private System.Void remove__callback(FlowCanvas.Nodes.ReflectedUnityEvent.UnityEventCallback value) { }
        private System.Reflection.ParameterInfo[] get_parameters() { }
        private System.Type get_eventType() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Type eventType) { }
        private System.Void InitForEventType(System.Type eventType) { }
        private System.Void StartListening(UnityEngine.Events.UnityEventBase targetEvent, FlowCanvas.Nodes.ReflectedUnityEvent.UnityEventCallback callback) { }
        private System.Void StopListening(UnityEngine.Events.UnityEventBase targetEvent, FlowCanvas.Nodes.ReflectedUnityEvent.UnityEventCallback callback) { }
        private System.Void CallbackMethod0() { }
        private System.Void CallbackMethod1(T0 arg0) { }
        private System.Void CallbackMethod2(T0 arg0, T1 arg1) { }
        private System.Void CallbackMethod3(T0 arg0, T1 arg1, T2 arg2) { }
        private System.Void CallbackMethod4(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

    }

    // TypeToken: 0x20001DC
    public class SharpEvent
    {
        // Fields
        private System.Object <instance>k__BackingField;        // 0x10
        private System.Reflection.EventInfo <eventInfo>k__BackingField;        // 0x18

        // Methods
        private System.Object get_instance() { }
        private System.Void set_instance(System.Object value) { }
        private System.Reflection.EventInfo get_eventInfo() { }
        private System.Void set_eventInfo(System.Reflection.EventInfo value) { }
        private FlowCanvas.Nodes.SharpEvent Create(System.Reflection.EventInfo eventInfo) { }
        private System.Void SetInstance(System.Object instance) { }
        private System.Void StartListening(FlowCanvas.Nodes.ReflectedDelegateEvent reflectedEvent, FlowCanvas.Nodes.ReflectedDelegateEvent.DelegateEventCallback callback) { }
        private System.Void StopListening(FlowCanvas.Nodes.ReflectedDelegateEvent reflectedEvent, FlowCanvas.Nodes.ReflectedDelegateEvent.DelegateEventCallback callback) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001DD
    public class SharpEvent`1 : SharpEvent
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001DE
    public class BaseReflectedExtractorNode
    {
        // Fields
        private static System.Func<System.Type,System.Boolean,System.Reflection.MemberInfo[],FlowCanvas.Nodes.BaseReflectedExtractorNode> OnGetAotExtractorNode;        // 0x0
        private FlowCanvas.Nodes.ParametresDef <Params>k__BackingField;        // 0x10
        private System.Type <TargetType>k__BackingField;        // 0x88

        // Methods
        private System.Void add_OnGetAotExtractorNode(System.Func<System.Type,System.Boolean,System.Reflection.MemberInfo[],FlowCanvas.Nodes.BaseReflectedExtractorNode> value) { }
        private System.Void remove_OnGetAotExtractorNode(System.Func<System.Type,System.Boolean,System.Reflection.MemberInfo[],FlowCanvas.Nodes.BaseReflectedExtractorNode> value) { }
        private FlowCanvas.Nodes.BaseReflectedExtractorNode GetExtractorNode(System.Type targetType, System.Boolean isStatic, System.Reflection.MemberInfo[] infos) { }
        private FlowCanvas.Nodes.ParametresDef get_Params() { }
        private System.Void set_Params(FlowCanvas.Nodes.ParametresDef value) { }
        private System.Type get_TargetType() { }
        private System.Void set_TargetType(System.Type value) { }
        private System.Boolean Init(FlowCanvas.Nodes.ParametresDef paramsDef, System.Type targetType) { }
        private System.Boolean InitInternal() { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001DF
    public class PureReflectedExtractorNode : BaseReflectedExtractorNode
    {
        // Fields
        private static readonly System.Object[] EmptyParams;        // 0x0
        private FlowCanvas.ValueInput instanceInput;        // 0x90

        // Methods
        private System.Boolean InitInternal() { }
        private FlowCanvas.ValueHandlerObject GetPortHandler(System.Reflection.FieldInfo info) { }
        private FlowCanvas.ValueHandlerObject GetPortHandler(System.Reflection.MethodInfo info) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001E2
    public class BaseReflectedFieldNode
    {
        // Fields
        private static System.Func<System.Reflection.FieldInfo,FlowCanvas.Nodes.BaseReflectedFieldNode> OnGetAotReflectedFieldNode;        // 0x0
        protected System.Reflection.FieldInfo fieldInfo;        // 0x10
        protected FlowCanvas.Nodes.ParamDef instanceDef;        // 0x18
        protected FlowCanvas.Nodes.ParamDef resultDef;        // 0x50

        // Methods
        private System.Void add_OnGetAotReflectedFieldNode(System.Func<System.Reflection.FieldInfo,FlowCanvas.Nodes.BaseReflectedFieldNode> value) { }
        private System.Void remove_OnGetAotReflectedFieldNode(System.Func<System.Reflection.FieldInfo,FlowCanvas.Nodes.BaseReflectedFieldNode> value) { }
        private FlowCanvas.Nodes.BaseReflectedFieldNode GetFieldNode(System.Reflection.FieldInfo targetField) { }
        private System.Boolean Init(System.Reflection.FieldInfo field, FlowCanvas.Nodes.ParametresDef parametres) { }
        private System.Boolean InitInternal(System.Reflection.FieldInfo field) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, FlowCanvas.Nodes.ReflectedFieldNodeWrapper.AccessMode accessMode) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E3
    public class PureReflectedFieldNode : BaseReflectedFieldNode
    {
        // Fields
        private FlowCanvas.ValueInput instanceInput;        // 0x88
        private FlowCanvas.ValueInput valueInput;        // 0x90
        private System.Object instanceObject;        // 0x98
        private System.Object valueObject;        // 0xA0

        // Methods
        private System.Boolean InitInternal(System.Reflection.FieldInfo method) { }
        private System.Void SetValue() { }
        private System.Void GetValue() { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, FlowCanvas.Nodes.ReflectedFieldNodeWrapper.AccessMode accessMode) { }
        private System.Void .ctor() { }
        private System.Object <RegisterPorts>b__7_0() { }
        private System.Object <RegisterPorts>b__7_1() { }

    }

    // TypeToken: 0x20001E5
    public class BaseReflectedMethodNode
    {
        // Fields
        private static System.Func<System.Reflection.MethodInfo,FlowCanvas.Nodes.BaseReflectedMethodNode> OnGetAotReflectedMethodNode;        // 0x0
        protected System.Reflection.MethodInfo methodInfo;        // 0x10
        protected System.Collections.Generic.List<FlowCanvas.Nodes.ParamDef> paramDefinitions;        // 0x18
        protected FlowCanvas.Nodes.ParamDef instanceDef;        // 0x20
        protected FlowCanvas.Nodes.ParamDef resultDef;        // 0x58
        protected FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options;        // 0x90

        // Methods
        private System.Void add_OnGetAotReflectedMethodNode(System.Func<System.Reflection.MethodInfo,FlowCanvas.Nodes.BaseReflectedMethodNode> value) { }
        private System.Void remove_OnGetAotReflectedMethodNode(System.Func<System.Reflection.MethodInfo,FlowCanvas.Nodes.BaseReflectedMethodNode> value) { }
        private FlowCanvas.Nodes.BaseReflectedMethodNode GetMethodNode(System.Reflection.MethodInfo targetMethod, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Boolean Init(System.Reflection.MethodInfo method, FlowCanvas.Nodes.ParametresDef parametres) { }
        private System.Boolean InitInternal(System.Reflection.MethodInfo method) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E6
    public class PureReflectedMethodNode : BaseReflectedMethodNode
    {
        // Fields
        private FlowCanvas.ValueInput instanceInput;        // 0x98
        private System.Object instanceObject;        // 0xA0
        private System.Object resultObject;        // 0xA8
        private System.Object[] callParams;        // 0xB0
        private FlowCanvas.ValueInput[] inputs;        // 0xB8
        private FlowCanvas.ValueInput[] arrayInputs;        // 0xC0
        private System.Int32 arrayParamsInput;        // 0xC8
        private System.Type arrayParamsType;        // 0xD0

        // Methods
        private System.Boolean InitInternal(System.Reflection.MethodInfo method) { }
        private System.Void Call() { }
        private System.Void RegisterOutput(FlowCanvas.FlowNode node, System.Boolean callable, FlowCanvas.Nodes.ParamDef def, System.Int32 idx) { }
        private System.Void RegisterInput(FlowCanvas.FlowNode node, FlowCanvas.Nodes.ParamDef def, System.Int32 idx) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001EA
    public class ReflectedConstructorNodeWrapper : ReflectedMethodBaseNodeWrapper
    {
        // Fields
        private ParadoxNotion.Serialization.SerializedConstructorInfo _constructor;        // 0xB8
        private FlowCanvas.Nodes.BaseReflectedConstructorNode <reflectedConstructorNode>k__BackingField;        // 0xC0

        // Methods
        private FlowCanvas.Nodes.BaseReflectedConstructorNode get_reflectedConstructorNode() { }
        private System.Void set_reflectedConstructorNode(FlowCanvas.Nodes.BaseReflectedConstructorNode value) { }
        private System.Reflection.ConstructorInfo get_constructor() { }
        private ParadoxNotion.Serialization.ISerializedMethodBaseInfo get_serializedMethodBase() { }
        private System.String get_name() { }
        private System.Void SetMethodBase(System.Reflection.MethodBase newMethod, System.Object instance) { }
        private System.Void SetConstructor(System.Reflection.ConstructorInfo newConstructor) { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001EB
    public class ReflectedExtractorNodeWrapper`1 : FlowNode
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo> _memberInfos;        // 0x0
        private static System.Collections.Generic.List<System.String> _instanceMemberNames;        // 0x0
        private static System.Collections.Generic.List<System.String> _staticMemberNames;        // 0x0
        private System.Collections.Generic.List<System.String> _selectedInstanceMembers;        // 0x0
        private FlowCanvas.Nodes.BaseReflectedExtractorNode extractorNode;        // 0x0

        // Methods
        private System.Type GetRuntimeIconType() { }
        private System.Void PopulateInfos() { }
        private System.String get_name() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001EC
    public class ReflectedFieldNodeWrapper_0
    {
        // Fields
        public System.String fieldName;        // 0x10
        public System.Type targetType;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001ED
    public class ReflectedFieldNodeWrapper : FlowNode, IReflectedWrapper, IMigratable`1, IMigratable
    {
        // Fields
        private ParadoxNotion.Serialization.SerializedFieldInfo _field;        // 0xB0
        private FlowCanvas.Nodes.ReflectedFieldNodeWrapper.AccessMode accessMode;        // 0xB8
        private FlowCanvas.Nodes.BaseReflectedFieldNode <reflectedFieldNode>k__BackingField;        // 0xC0

        // Methods
        private System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<FlowCanvas.Nodes.ReflectedFieldNodeWrapper_0>.Migrate(FlowCanvas.Nodes.ReflectedFieldNodeWrapper_0 model) { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Type GetRuntimeIconType() { }
        private FlowCanvas.Nodes.BaseReflectedFieldNode get_reflectedFieldNode() { }
        private System.Void set_reflectedFieldNode(FlowCanvas.Nodes.BaseReflectedFieldNode value) { }
        private System.Reflection.FieldInfo get_field() { }
        private System.String get_name() { }
        private System.Void SetField(System.Reflection.FieldInfo newField, FlowCanvas.Nodes.ReflectedFieldNodeWrapper.AccessMode mode, System.Object instance) { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001EF
    public class ReflectedMethodBaseNodeWrapper : FlowNode, IReflectedWrapper
    {
        // Fields
        protected System.Boolean _callable;        // 0xB0
        protected System.Boolean _exposeParams;        // 0xB1
        protected System.Int32 _exposedParamsCount;        // 0xB4

        // Methods
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Type GetRuntimeIconType() { }
        private ParadoxNotion.Serialization.ISerializedMethodBaseInfo get_serializedMethodBase() { }
        private System.Reflection.MethodBase get_method() { }
        private System.Boolean get_callable() { }
        private System.Void set_callable(System.Boolean value) { }
        private System.Boolean get_exposeParams() { }
        private System.Void set_exposeParams(System.Boolean value) { }
        private System.Int32 get_exposedParamsCount() { }
        private System.Void set_exposedParamsCount(System.Int32 value) { }
        private System.Void SetMethodBase(System.Reflection.MethodBase newMethod, System.Object instance) { }
        private System.Void SetDefaultParameterValues(System.Reflection.MethodBase newMethod) { }
        private System.Void SetDropInstanceReference(System.Reflection.MethodBase newMethod, System.Object instance) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F0
    public class ReflectedMethodNodeWrapper : ReflectedMethodBaseNodeWrapper
    {
        // Fields
        private ParadoxNotion.Serialization.SerializedMethodInfo _method;        // 0xB8
        private FlowCanvas.Nodes.BaseReflectedMethodNode <reflectedMethodNode>k__BackingField;        // 0xC0

        // Methods
        private FlowCanvas.Nodes.BaseReflectedMethodNode get_reflectedMethodNode() { }
        private System.Void set_reflectedMethodNode(FlowCanvas.Nodes.BaseReflectedMethodNode value) { }
        private System.Reflection.MethodInfo get_method() { }
        private ParadoxNotion.Serialization.ISerializedMethodBaseInfo get_serializedMethodBase() { }
        private System.String get_name() { }
        private System.Void SetMethodBase(System.Reflection.MethodBase newMethod, System.Object instance) { }
        private System.Void SetMethod(System.Reflection.MethodInfo newMethod, System.Object instance) { }
        private System.Void OnPortConnected(FlowCanvas.Port port, FlowCanvas.Port otherPort) { }
        private System.Type GetNodeWildDefinitionType() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F1
    public struct ReflectedMethodRegistrationOptions
    {
        // Fields
        public System.Boolean callable;        // 0x10
        public System.Boolean exposeParams;        // 0x11
        public System.Int32 exposedParamsCount;        // 0x14

    }

    // TypeToken: 0x20001F2
    public class FlowNestedBase`1 : FlowNodeNested`1, IDropedReferenceNode, IGraphElement, IUpdatable
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<T> _subGraph;        // 0x0
        private FlowCanvas.ValueInput<UnityEngine.Component> targetAgent;        // 0x0
        private FlowCanvas.FlowOutput onStart;        // 0x0
        private FlowCanvas.FlowOutput onUpdate;        // 0x0
        private FlowCanvas.FlowOutput onFinish;        // 0x0
        private System.Boolean paused;        // 0x0
        private System.Boolean endResult;        // 0x0

        // Methods
        private T get_subGraph() { }
        private System.Void set_subGraph(T value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private ParadoxNotion.Alignment2x2 get_iconAlignment() { }
        private System.Void FlowCanvas.Nodes.IDropedReferenceNode.SetTarget(UnityEngine.Object target) { }
        private System.Void RegisterPorts() { }
        private System.Void Start(FlowCanvas.Flow f) { }
        private System.Void Stop(FlowCanvas.Flow f) { }
        private System.Void OnStop(FlowCanvas.Flow f) { }
        private System.Void Pause(FlowCanvas.Flow f) { }
        private System.Void Resume(FlowCanvas.Flow f) { }
        private System.Void NodeCanvas.Framework.IUpdatable.Update() { }
        private System.Void .ctor() { }
        private System.Single <RegisterPorts>b__15_0() { }
        private System.Boolean <RegisterPorts>b__15_1() { }

    }

    // TypeToken: 0x20001F4
    public class FlowNestedFlow : FlowNestedBase`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F5
    public class CreateCollection`1 : FlowNode
    {
        // Fields
        private System.Int32 _portCount;        // 0x0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F8
    public class CreateDictionary`1 : FlowNode
    {
        // Fields
        private System.Int32 _portCount;        // 0x0

        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001FC
    public class GetOtherVariable`1 : FlowNode
    {
        // Methods
        private System.String get_name() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001FE
    public class GetVariable`1 : ParameterVariableNode
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<T> value;        // 0x0

        // Methods
        private NodeCanvas.Framework.BBParameter get_parameter() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }
        private T <RegisterPorts>b__3_0() { }

    }

    // TypeToken: 0x20001FF
    public class RelayValueInputBase : FlowNode
    {
        // Methods
        private System.Type get_relayType() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000200
    public class RelayValueInput`1 : RelayValueInputBase, IEditorMenuCallbackReceiver
    {
        // Fields
        public System.String identifier;        // 0x0
        private FlowCanvas.ValueInput<T> <port>k__BackingField;        // 0x0
        private System.Boolean <cached>k__BackingField;        // 0x0
        private T <cachedValue>k__BackingField;        // 0x0

        // Methods
        private FlowCanvas.ValueInput<T> get_port() { }
        private System.Void set_port(FlowCanvas.ValueInput<T> value) { }
        private System.Boolean get_cached() { }
        private System.Void set_cached(System.Boolean value) { }
        private T get_cachedValue() { }
        private System.Void set_cachedValue(T value) { }
        private System.Type get_relayType() { }
        private System.String get_name() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000202
    public class RelayValueOutputBase : FlowNode
    {
        // Methods
        private System.Void SetSource(FlowCanvas.Nodes.RelayValueInputBase source) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000203
    public class RelayValueOutput`1 : RelayValueOutputBase
    {
        // Fields
        private System.String _sourceInputUID;        // 0x0
        private System.WeakReference<FlowCanvas.Nodes.RelayValueInputBase> _sourceInputRef;        // 0x0

        // Methods
        private System.String get_sourceInputUID() { }
        private System.Void set_sourceInputUID(System.String value) { }
        private FlowCanvas.Nodes.RelayValueInput<T> get_sourceInput() { }
        private System.String get_name() { }
        private System.Void SetSource(FlowCanvas.Nodes.RelayValueInputBase source) { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }
        private System.Boolean <get_sourceInput>b__6_0(FlowCanvas.Nodes.RelayValueInput<T> i) { }
        private T <RegisterPorts>b__10_0() { }

    }

    // TypeToken: 0x2000204
    public class NullObject : FlowNode
    {
        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000206
    public class OwnerVariable : FlowNode
    {
        // Methods
        private System.String get_name() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }
        private UnityEngine.GameObject <RegisterPorts>b__2_0() { }

    }

    // TypeToken: 0x2000207
    public class ParameterVariableNode : FlowNode
    {
        // Methods
        private NodeCanvas.Framework.BBParameter get_parameter() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000208
    public class SetOtherVariable`1 : FlowNode
    {
        // Fields
        public ParadoxNotion.OperationMethod operation;        // 0x0
        private FlowCanvas.ValueInput<System.String> varName;        // 0x0

        // Methods
        private System.String get_name() { }
        private System.Void RegisterPorts() { }
        private System.Void DoSet(NodeCanvas.Framework.Blackboard bb, System.String name, T value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200020A
    public class SetVariable`1 : ParameterVariableNode
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<T> targetVariable;        // 0x0
        public ParadoxNotion.OperationMethod operation;        // 0x0
        public System.Boolean perSecond;        // 0x0

        // Methods
        private NodeCanvas.Framework.BBParameter get_parameter() { }
        private System.String get_name() { }
        private System.Void RegisterPorts() { }
        private System.Void DoSet(T value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200020C
    public class CodeEventBase : EventNode`1
    {
        // Fields
        protected System.String eventName;        // 0xB8
        protected System.Type targetType;        // 0xC0
        protected UnityEngine.Component targetComponent;        // 0xC8

        // Methods
        private System.Reflection.EventInfo get_eventInfo() { }
        private System.Void SetEvent(System.Reflection.EventInfo e, System.Object instace) { }
        private System.Void OnPostGraphStarted() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200020D
    public class CodeEvent : CodeEventBase
    {
        // Fields
        private FlowCanvas.FlowOutput o;        // 0xD0
        private System.Action pointer;        // 0xD8

        // Methods
        private System.Void OnPostGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200020E
    public class CodeEvent`1 : CodeEventBase
    {
        // Fields
        private FlowCanvas.FlowOutput o;        // 0x0
        private System.Action<T> pointer;        // 0x0
        private T eventValue;        // 0x0

        // Methods
        private System.Void OnPostGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void Call(T eventValue) { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }
        private T <RegisterPorts>b__6_0() { }

    }

    // TypeToken: 0x200020F
    public class NewGameObject : CallableFunctionNode`4
    {
        // Methods
        private UnityEngine.GameObject Invoke(System.String name, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000210
    public class NewVector2 : PureFunctionNode`3
    {
        // Methods
        private UnityEngine.Vector2 Invoke(System.Single x, System.Single y) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000211
    public class NewVector3 : PureFunctionNode`4
    {
        // Methods
        private UnityEngine.Vector3 Invoke(System.Single x, System.Single y, System.Single z) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000212
    public class NewVector4 : PureFunctionNode`5
    {
        // Methods
        private UnityEngine.Vector4 Invoke(System.Single x, System.Single y, System.Single z, System.Single w) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000213
    public class NewQuaternion : PureFunctionNode`5
    {
        // Methods
        private UnityEngine.Quaternion Invoke(System.Single x, System.Single y, System.Single z, System.Single w) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000214
    public class NewColor : PureFunctionNode`5
    {
        // Methods
        private UnityEngine.Color Invoke(System.Single r, System.Single g, System.Single b, System.Single a) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000215
    public class NewBounds : PureFunctionNode`3
    {
        // Methods
        private UnityEngine.Bounds Invoke(UnityEngine.Vector3 center, UnityEngine.Vector3 size) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000216
    public class NewRect : PureFunctionNode`5
    {
        // Methods
        private UnityEngine.Rect Invoke(System.Single left, System.Single top, System.Single width, System.Single height) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000217
    public class NewRay : PureFunctionNode`3
    {
        // Methods
        private UnityEngine.Ray Invoke(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000218
    public class ConvertTo`1 : PureFunctionNode`2
    {
        // Methods
        private T Invoke(System.IConvertible obj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000219
    public class CastTo`1 : PureFunctionNode`2
    {
        // Methods
        private T Invoke(System.Object obj) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021A
    public class ToArray`1 : PureFunctionNode`2
    {
        // Methods
        private T[] Invoke(System.Collections.Generic.IList<T> list) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021B
    public class ToList`1 : PureFunctionNode`2
    {
        // Methods
        private System.Collections.Generic.List<T> Invoke(System.Collections.Generic.IList<T> list) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021C
    public class CustomObjectWrapper : FlowNode
    {
        // Methods
        private System.Void SetTarget(UnityEngine.Object target) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021D
    public class CustomObjectWrapper`1 : CustomObjectWrapper
    {
        // Fields
        private T _target;        // 0x0

        // Methods
        private T get_target() { }
        private System.Void set_target(T value) { }
        private System.String get_name() { }
        private System.Void SetTarget(UnityEngine.Object target) { }
        private System.Type GetRuntimeIconType() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021E
    public class ExtractVector2 : ExtractorNode`3
    {
        // Methods
        private System.Void Invoke(UnityEngine.Vector2 vector, System.Single& x, System.Single& y) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021F
    public class ExtractVector3 : ExtractorNode`4
    {
        // Methods
        private System.Void Invoke(UnityEngine.Vector3 vector, System.Single& x, System.Single& y, System.Single& z) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000220
    public class ExtractVector4 : ExtractorNode`5
    {
        // Methods
        private System.Void Invoke(UnityEngine.Vector4 vector, System.Single& x, System.Single& y, System.Single& z, System.Single& w) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000221
    public class ExtractQuaternion : ExtractorNode`6
    {
        // Methods
        private System.Void Invoke(UnityEngine.Quaternion quaternion, System.Single& x, System.Single& y, System.Single& z, System.Single& w, UnityEngine.Vector3& eulerAngles) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000222
    public class ExtractRect : ExtractorNode`6
    {
        // Methods
        private System.Void Invoke(UnityEngine.Rect rect, UnityEngine.Vector2& center, System.Single& xMin, System.Single& xMax, System.Single& yMin, System.Single& yMax) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000223
    public class ExtractColor : ExtractorNode`5
    {
        // Methods
        private System.Void Invoke(UnityEngine.Color color, System.Single& r, System.Single& g, System.Single& b, System.Single& a) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000224
    public class ExtractRaycastHit : ExtractorNode`5
    {
        // Methods
        private System.Void Invoke(UnityEngine.RaycastHit hit, UnityEngine.GameObject& gameObject, System.Single& distance, UnityEngine.Vector3& normal, UnityEngine.Vector3& point) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000225
    public class ExtractRaycastHit2D : ExtractorNode`6
    {
        // Methods
        private System.Void Invoke(UnityEngine.RaycastHit2D hit, UnityEngine.GameObject& gameObject, System.Single& distance, System.Single& fraction, UnityEngine.Vector3& normal, UnityEngine.Vector3& point) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000226
    public class ExtractRay : ExtractorNode`3
    {
        // Methods
        private System.Void Invoke(UnityEngine.Ray ray, UnityEngine.Vector3& origin, UnityEngine.Vector3& direction) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000227
    public class ExtractBounds : ExtractorNode`6
    {
        // Methods
        private System.Void Invoke(UnityEngine.Bounds bounds, UnityEngine.Vector3& center, UnityEngine.Vector3& extents, UnityEngine.Vector3& max, UnityEngine.Vector3& min, UnityEngine.Vector3& size) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000228
    public class ExtractCollision : ExtractorNode`5
    {
        // Methods
        private System.Void Invoke(UnityEngine.Collision collision, UnityEngine.ContactPoint[]& contacts, UnityEngine.ContactPoint& firstContact, UnityEngine.GameObject& gameObject, UnityEngine.Vector3& velocity) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000229
    public class ExtractCollision2D : ExtractorNode`5
    {
        // Methods
        private System.Void Invoke(UnityEngine.Collision2D collision, UnityEngine.ContactPoint2D[]& contacts, UnityEngine.ContactPoint2D& firstContact, UnityEngine.GameObject& gameObject, UnityEngine.Vector2& velocity) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022A
    public class ExtractContactPoint : ExtractorNode`5
    {
        // Methods
        private System.Void Invoke(UnityEngine.ContactPoint contactPoint, UnityEngine.Vector3& normal, UnityEngine.Vector3& point, UnityEngine.Collider& colliderA, UnityEngine.Collider& colliderB) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022B
    public class ExtractContactPoint2D : ExtractorNode`5
    {
        // Methods
        private System.Void Invoke(UnityEngine.ContactPoint2D contactPoint, UnityEngine.Vector2& normal, UnityEngine.Vector2& point, UnityEngine.Collider2D& colliderA, UnityEngine.Collider2D& colliderB) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022C
    public class ExtractAnimationCurve : ExtractorNode`5
    {
        // Methods
        private System.Void Invoke(UnityEngine.AnimationCurve curve, UnityEngine.Keyframe[]& keys, System.Single& length, UnityEngine.WrapMode& postWrapMode, UnityEngine.WrapMode& preWrapMode) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022D
    public class ExtractKeyFrame : ExtractorNode`5
    {
        // Methods
        private System.Void Invoke(UnityEngine.Keyframe key, System.Single& inTangent, System.Single& outTangent, System.Single& time, System.Single& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022E
    public class SwitchValue`1 : PureFunctionNode`4
    {
        // Methods
        private T Invoke(System.Boolean condition, T isTrue, T isFalse) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022F
    public class PickValue`1 : PureFunctionNode`3
    {
        // Methods
        private T Invoke(System.Int32 index, System.Collections.Generic.IList<T> values) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000230
    public class StaticCodeEventBase : EventNode
    {
        // Fields
        protected System.String eventName;        // 0xB0
        protected System.Type targetType;        // 0xB8

        // Methods
        private System.Reflection.EventInfo get_eventInfo() { }
        private System.Void SetEvent(System.Reflection.EventInfo e) { }
        private System.Void OnGraphStarted() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000231
    public class StaticCodeEvent : StaticCodeEventBase
    {
        // Fields
        private FlowCanvas.FlowOutput o;        // 0xC0
        private System.Action pointer;        // 0xC8

        // Methods
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void Call() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000232
    public class StaticCodeEvent`1 : StaticCodeEventBase
    {
        // Fields
        private FlowCanvas.FlowOutput o;        // 0x0
        private System.Action<T> pointer;        // 0x0
        private T eventValue;        // 0x0

        // Methods
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void Call(T value) { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }
        private T <RegisterPorts>b__6_0() { }

    }

    // TypeToken: 0x2000233
    public class FlowNestedBT : FlowNestedBase`1
    {
        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }
        private NodeCanvas.Framework.Status <RegisterPorts>b__0_0() { }

    }

    // TypeToken: 0x2000234
    public class FlowNestedFSM : FlowNestedBase`1
    {
        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }
        private NodeCanvas.StateMachines.IState <RegisterPorts>b__0_0() { }

    }

    // TypeToken: 0x2000235
    public class FlowNestedDT : FlowNestedBase`1
    {
        // Methods
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }
        private NodeCanvas.DialogueTrees.IDialogueActor <RegisterPorts>b__0_0() { }

    }

    // TypeToken: 0x2000236
    public class TaskAction : FlowNode, ITaskAssignable`1, ITaskAssignable, IGraphElement
    {
        // Fields
        private NodeCanvas.Framework.ActionTask _action;        // 0xB0
        private FlowCanvas.FlowOutput onFinish;        // 0xB8
        private UnityEngine.Coroutine coroutine;        // 0xC0

        // Methods
        private System.String get_name() { }
        private NodeCanvas.Framework.ActionTask get_action() { }
        private System.Void set_action(NodeCanvas.Framework.ActionTask value) { }
        private NodeCanvas.Framework.Task NodeCanvas.Framework.ITaskAssignable.get_task() { }
        private System.Void NodeCanvas.Framework.ITaskAssignable.set_task(NodeCanvas.Framework.Task value) { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void OnGraphPaused() { }
        private System.Void RegisterPorts() { }
        private System.Collections.IEnumerator DoUpdate(FlowCanvas.Flow f) { }
        private System.Void .ctor() { }
        private System.Void <RegisterPorts>b__14_0(FlowCanvas.Flow f) { }

    }

    // TypeToken: 0x2000238
    public class TaskCondition : FlowNode, ITaskAssignable`1, ITaskAssignable, IGraphElement
    {
        // Fields
        private NodeCanvas.Framework.ConditionTask _condition;        // 0xB0

        // Methods
        private System.String get_name() { }
        private NodeCanvas.Framework.ConditionTask get_condition() { }
        private System.Void set_condition(NodeCanvas.Framework.ConditionTask value) { }
        private NodeCanvas.Framework.Task NodeCanvas.Framework.ITaskAssignable.get_task() { }
        private System.Void NodeCanvas.Framework.ITaskAssignable.set_task(NodeCanvas.Framework.Task value) { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void RegisterPorts() { }
        private System.Void .ctor() { }
        private System.Boolean <RegisterPorts>b__11_0() { }

    }

}

namespace FlowCanvas.Nodes.Legacy
{

    // TypeToken: 0x2000239
    public class ReflectedFieldNode
    {
        // Methods
        private FlowCanvas.Nodes.Legacy.ReflectedFieldNode Create(System.Reflection.FieldInfo field) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.FieldInfo field, FlowCanvas.Nodes.ReflectedFieldNodeWrapper.AccessMode accessMode) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200023A
    public class PureReflectedFieldNode : ReflectedFieldNode
    {
        // Methods
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.FieldInfo field, FlowCanvas.Nodes.ReflectedFieldNodeWrapper.AccessMode accessMode) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200023F
    public class ReflectedMethodNode
    {
        // Methods
        private System.Void .ctor() { }
        private FlowCanvas.Nodes.Legacy.ReflectedMethodNode Create(System.Reflection.MethodInfo method) { }
        private FlowCanvas.Nodes.Legacy.ReflectedMethodNode TryCreateJit(System.Reflection.MethodInfo method) { }
        private System.String GetName(System.Reflection.MethodInfo method, System.Int32 i) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }

    }

    // TypeToken: 0x2000242
    public class PureReflectedMethodNode : ReflectedMethodNode
    {
        // Fields
        private System.Reflection.MethodInfo method;        // 0x10
        private FlowCanvas.ValueInput instanceInput;        // 0x18
        private System.Collections.Generic.List<FlowCanvas.ValueInput> inputs;        // 0x20
        private System.Collections.Generic.List<FlowCanvas.ValueInput> paramsInputs;        // 0x28
        private System.Type paramsArrayType;        // 0x30
        private System.Object[] args;        // 0x38
        private System.Object instance;        // 0x40
        private System.Object returnValue;        // 0x48

        // Methods
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Object CallMethod() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000246
    public class ReflectedActionNode : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.ActionCall call;        // 0x10

        // Methods
        private System.Void Call() { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000248
    public class ReflectedActionNode`1 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.ActionCall<T1> call;        // 0x0
        private T1 instance;        // 0x0

        // Methods
        private System.Void Call(T1 a) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200024A
    public class ReflectedActionNode`2 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.ActionCall<T1,T2> call;        // 0x0
        private T1 instance;        // 0x0

        // Methods
        private System.Void Call(T1 a, T2 b) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200024C
    public class ReflectedActionNode`3 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.ActionCall<T1,T2,T3> call;        // 0x0
        private T1 instance;        // 0x0

        // Methods
        private System.Void Call(T1 a, T2 b, T3 c) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200024E
    public class ReflectedActionNode`4 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.ActionCall<T1,T2,T3,T4> call;        // 0x0
        private T1 instance;        // 0x0

        // Methods
        private System.Void Call(T1 a, T2 b, T3 c, T4 d) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000250
    public class ReflectedActionNode`5 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.ActionCall<T1,T2,T3,T4,T5> call;        // 0x0
        private T1 instance;        // 0x0

        // Methods
        private System.Void Call(T1 a, T2 b, T3 c, T4 d, T5 e) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000252
    public class ReflectedActionNode`6 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.ActionCall<T1,T2,T3,T4,T5,T6> call;        // 0x0
        private T1 instance;        // 0x0

        // Methods
        private System.Void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000254
    public class ReflectedActionNode`7 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.ActionCall<T1,T2,T3,T4,T5,T6,T7> call;        // 0x0
        private T1 instance;        // 0x0

        // Methods
        private System.Void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000256
    public class ReflectedActionNode`8 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.ActionCall<T1,T2,T3,T4,T5,T6,T7,T8> call;        // 0x0
        private T1 instance;        // 0x0

        // Methods
        private System.Void Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000258
    public class ReflectedFunctionNode`1 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.FunctionCall<TResult> call;        // 0x0
        private TResult returnValue;        // 0x0

        // Methods
        private TResult Call() { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200025B
    public class ReflectedFunctionNode`2 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.FunctionCall<T1,TResult> call;        // 0x0
        private TResult returnValue;        // 0x0
        private T1 instance;        // 0x0

        // Methods
        private TResult Call(T1 a) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200025E
    public class ReflectedFunctionNode`3 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.FunctionCall<T1,T2,TResult> call;        // 0x0
        private TResult returnValue;        // 0x0
        private T1 instance;        // 0x0

        // Methods
        private TResult Call(T1 a, T2 b) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000261
    public class ReflectedFunctionNode`4 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.FunctionCall<T1,T2,T3,TResult> call;        // 0x0
        private TResult returnValue;        // 0x0
        private T1 instance;        // 0x0

        // Methods
        private TResult Call(T1 a, T2 b, T3 c) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000264
    public class ReflectedFunctionNode`5 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.FunctionCall<T1,T2,T3,T4,TResult> call;        // 0x0
        private TResult returnValue;        // 0x0
        private T1 instance;        // 0x0

        // Methods
        private TResult Call(T1 a, T2 b, T3 c, T4 d) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000267
    public class ReflectedFunctionNode`6 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.FunctionCall<T1,T2,T3,T4,T5,TResult> call;        // 0x0
        private TResult returnValue;        // 0x0
        private T1 instance;        // 0x0

        // Methods
        private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200026A
    public class ReflectedFunctionNode`7 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.FunctionCall<T1,T2,T3,T4,T5,T6,TResult> call;        // 0x0
        private TResult returnValue;        // 0x0
        private T1 instance;        // 0x0

        // Methods
        private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200026D
    public class ReflectedFunctionNode`8 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.FunctionCall<T1,T2,T3,T4,T5,T6,T7,TResult> call;        // 0x0
        private TResult returnValue;        // 0x0
        private T1 instance;        // 0x0

        // Methods
        private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000270
    public class ReflectedFunctionNode`9 : ReflectedMethodNode
    {
        // Fields
        private ParadoxNotion.FunctionCall<T1,T2,T3,T4,T5,T6,T7,T8,TResult> call;        // 0x0
        private TResult returnValue;        // 0x0
        private T1 instance;        // 0x0

        // Methods
        private TResult Call(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h) { }
        private System.Void RegisterPorts(FlowCanvas.FlowNode node, System.Reflection.MethodInfo method, FlowCanvas.Nodes.ReflectedMethodRegistrationOptions options) { }
        private System.Void .ctor() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000004
    public class HGConstantBufferLayoutAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace NodeCanvas
{

    // TypeToken: 0x2000282
    public class AssemblyWrapUtils
    {
        // Fields
        public static System.Boolean disableProjectPanelSuffixValidate;        // 0x0
        public static System.Func<System.Boolean> autoLockOpenBehaviourTree;        // 0x8
        public static System.Func<System.Boolean> autoLockOpenStateMachine;        // 0x10
        public static System.Func<System.Boolean> autoLockOpenDialogTree;        // 0x18
        public static System.Func<System.Boolean> autoLockOpenSAGraph;        // 0x20
        public static System.Func<System.Boolean> autoLockOpenLevelScript;        // 0x28
        public static System.Func<System.Boolean> autoLockOpenLevelScriptModule;        // 0x30
        public static System.Func<System.Boolean> autoLockOpenInteractiveConfig;        // 0x38
        public static System.Func<System.Boolean> autoLockOpenMissionGraph;        // 0x40
        public static System.Func<System.Boolean> autoLockOpenGuideGraph;        // 0x48

    }

    // TypeToken: 0x2000283
    public class ActionListPlayer : MonoBehaviour, ITaskSystem, ISerializationCallbackReceiver
    {
        // Fields
        public System.Boolean playOnAwake;        // 0x18
        private System.String _serializedList;        // 0x20
        private System.Collections.Generic.List<UnityEngine.Object> _objectReferences;        // 0x28
        private NodeCanvas.Framework.Blackboard _blackboard;        // 0x30
        private NodeCanvas.Framework.ActionList _actionList;        // 0x38
        private System.Single timeStarted;        // 0x40

        // Methods
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private NodeCanvas.Framework.ActionList get_actionList() { }
        private System.Single get_elapsedTime() { }
        private System.Single get_deltaTime() { }
        private UnityEngine.Object NodeCanvas.Framework.ITaskSystem.get_contextObject() { }
        private UnityEngine.Component NodeCanvas.Framework.ITaskSystem.get_agent() { }
        private NodeCanvas.Framework.IBlackboard get_blackboard() { }
        private System.Void set_blackboard(NodeCanvas.Framework.IBlackboard value) { }
        private NodeCanvas.ActionListPlayer Create() { }
        private System.Void Awake() { }
        private System.Void UpdateTasksOwner() { }
        private System.Void NodeCanvas.Framework.ITaskSystem.SendEvent(System.String name, System.Object value, System.Object sender) { }
        private System.Void NodeCanvas.Framework.ITaskSystem.SendEvent(System.String name, T value, System.Object sender) { }
        private System.Void Play() { }
        private System.Void Play(System.Action<NodeCanvas.Framework.Status> OnFinish) { }
        private System.Void Play(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard, System.Action<NodeCanvas.Framework.Status> OnFinish) { }
        private NodeCanvas.Framework.Status Execute() { }
        private NodeCanvas.Framework.Status Execute(UnityEngine.Component agent) { }
        private System.Void .ctor() { }

    }

}

namespace NodeCanvas.BehaviourTrees
{

    // TypeToken: 0x20003B3
    public class BehaviourTree : Graph
    {
        // Fields
        public System.Boolean repeat;        // 0xA0
        public System.Single updateInterval;        // 0xA4
        private static System.Action<NodeCanvas.BehaviourTrees.BehaviourTree,NodeCanvas.Framework.Status> onRootStatusChanged;        // 0x0
        private System.Single intervalCounter;        // 0xA8
        private NodeCanvas.Framework.Status _rootStatus;        // 0xAC

        // Methods
        private System.Object OnDerivedDataSerialization() { }
        private System.Void OnDerivedDataDeserialization(System.Object data) { }
        private System.Void add_onRootStatusChanged(System.Action<NodeCanvas.BehaviourTrees.BehaviourTree,NodeCanvas.Framework.Status> value) { }
        private System.Void remove_onRootStatusChanged(System.Action<NodeCanvas.BehaviourTrees.BehaviourTree,NodeCanvas.Framework.Status> value) { }
        private NodeCanvas.Framework.Status get_rootStatus() { }
        private System.Void set_rootStatus(NodeCanvas.Framework.Status value) { }
        private System.Type get_baseNodeType() { }
        private System.Boolean get_requiresAgent() { }
        private System.Boolean get_requiresPrimeNode() { }
        private System.Boolean get_isTree() { }
        private System.Boolean get_allowBlackboardOverrides() { }
        private System.Boolean get_canAcceptVariableDrops() { }
        private System.Boolean get_canDelayDeserializeAndOptimizeClone() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphUpdate() { }
        private NodeCanvas.Framework.Status Tick(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003B5
    public class BehaviourTreeOwner : GraphOwner`1
    {
        // Methods
        private System.Boolean get_repeat() { }
        private System.Void set_repeat(System.Boolean value) { }
        private System.Single get_updateInterval() { }
        private System.Void set_updateInterval(System.Single value) { }
        private NodeCanvas.Framework.Status get_rootStatus() { }
        private NodeCanvas.Framework.Status Tick() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003B6
    public class BTConnection : Connection
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003B7
    public class BTNode : Node
    {
        // Methods
        private System.Type get_outConnectionType() { }
        private System.Boolean get_allowAsPrime() { }
        private System.Boolean get_canSelfConnect() { }
        private ParadoxNotion.Alignment2x2 get_commentsAlignment() { }
        private ParadoxNotion.Alignment2x2 get_iconAlignment() { }
        private System.Int32 get_maxInConnections() { }
        private System.Int32 get_maxOutConnections() { }
        private T AddChild(System.Int32 childIndex) { }
        private T AddChild() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003B8
    public class BTNodeNested`1 : BTNode, IGraphAssignable`1, IGraphAssignable, IGraphElement
    {
        // Fields
        private System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> _variablesMap;        // 0x0
        private T <currentInstance>k__BackingField;        // 0x0
        private System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> <instances>k__BackingField;        // 0x0

        // Methods
        private T get_subGraph() { }
        private System.Void set_subGraph(T value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private T get_currentInstance() { }
        private System.Void set_currentInstance(T value) { }
        private System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> get_instances() { }
        private System.Void set_instances(System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> value) { }
        private System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> get_variablesMap() { }
        private System.Void set_variablesMap(System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> value) { }
        private NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_subGraph() { }
        private System.Void NodeCanvas.Framework.IGraphAssignable.set_subGraph(NodeCanvas.Framework.Graph value) { }
        private NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_currentInstance() { }
        private System.Void NodeCanvas.Framework.IGraphAssignable.set_currentInstance(NodeCanvas.Framework.Graph value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003B9
    public class BTComposite : BTNode
    {
        // Methods
        private System.String get_name() { }
        private System.Int32 get_maxOutConnections() { }
        private ParadoxNotion.Alignment2x2 get_commentsAlignment() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003BA
    public class BTDecorator : BTNode
    {
        // Methods
        private System.Int32 get_maxOutConnections() { }
        private ParadoxNotion.Alignment2x2 get_commentsAlignment() { }
        private NodeCanvas.Framework.Connection get_decoratedConnection() { }
        private NodeCanvas.Framework.Node get_decoratedNode() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003BB
    public class BinarySelector : BTNode, ITaskAssignable`1, ITaskAssignable, IGraphElement
    {
        // Fields
        public System.Boolean dynamic;        // 0x98
        private NodeCanvas.Framework.ConditionTask _condition;        // 0xA0
        private System.Int32 succeedIndex;        // 0xA8

        // Methods
        private System.Int32 get_maxOutConnections() { }
        private ParadoxNotion.Alignment2x2 get_commentsAlignment() { }
        private System.String get_name() { }
        private NodeCanvas.Framework.Task get_task() { }
        private System.Void set_task(NodeCanvas.Framework.Task value) { }
        private NodeCanvas.Framework.ConditionTask get_condition() { }
        private System.Void set_condition(NodeCanvas.Framework.ConditionTask value) { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003BC
    public class FlipSelector : BTComposite
    {
        // Fields
        private System.Int32 current;        // 0x98

        // Methods
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void SendToBack(System.Int32 i) { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003BD
    public class Parallel : BTComposite
    {
        // Fields
        public NodeCanvas.BehaviourTrees.Parallel.ParallelPolicy policy;        // 0x98
        public System.Boolean dynamic;        // 0x9C
        private System.Boolean[] finishedConnections;        // 0xA0
        private System.Int32 finishedConnectionsCount;        // 0xA8

        // Methods
        private System.Void OnGraphStarted() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void ResetRunning() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003BF
    public class PrioritySelector_0 : BTComposite
    {
        // Fields
        public System.Collections.Generic.List<NodeCanvas.Framework.BBParameter<System.Single>> priorities;        // 0x98

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003C0
    public class PrioritySelector : BTComposite, IMigratable`1, IMigratable
    {
        // Fields
        public System.Collections.Generic.List<NodeCanvas.BehaviourTrees.PrioritySelector.Desire> desires;        // 0x98
        private NodeCanvas.Framework.Connection[] orderedConnections;        // 0xA0
        private System.Int32 current;        // 0xA8

        // Methods
        private System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.BehaviourTrees.PrioritySelector_0>.Migrate(NodeCanvas.BehaviourTrees.PrioritySelector_0 model) { }
        private System.Void OnChildConnected(System.Int32 index) { }
        private System.Void OnChildDisconnected(System.Int32 index) { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }
        private System.Single <OnExecute>b__8_0(NodeCanvas.Framework.Connection c) { }

    }

    // TypeToken: 0x20003C3
    public class ProbabilitySelector : BTComposite
    {
        // Fields
        public System.Collections.Generic.List<NodeCanvas.Framework.BBParameter<System.Single>> childWeights;        // 0x98
        public NodeCanvas.Framework.BBParameter<System.Single> failChance;        // 0xA0
        private System.Boolean[] indexFailed;        // 0xA8
        private System.Single[] tmpWeights;        // 0xB0
        private System.Single tmpFailWeight;        // 0xB8
        private System.Single tmpTotal;        // 0xBC
        private System.Single tmpDice;        // 0xC0

        // Methods
        private System.Void OnChildConnected(System.Int32 index) { }
        private System.Void OnChildDisconnected(System.Int32 index) { }
        private System.Void OnGraphStarted() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003C4
    public class Selector : BTComposite
    {
        // Fields
        public System.Boolean dynamic;        // 0x98
        public System.Boolean random;        // 0x99
        private System.Int32 lastRunningNodeIndex;        // 0x9C

        // Methods
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void OnChildDisconnected(System.Int32 index) { }
        private System.Void OnGraphStarted() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003C5
    public class Sequencer : BTComposite
    {
        // Fields
        public System.Boolean dynamic;        // 0x98
        public System.Boolean random;        // 0x99
        private System.Int32 lastRunningNodeIndex;        // 0x9C

        // Methods
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void OnChildDisconnected(System.Int32 index) { }
        private System.Void OnGraphStarted() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003C6
    public class StepIterator : BTComposite
    {
        // Fields
        private System.Int32 current;        // 0x98

        // Methods
        private System.Void OnGraphStarted() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003C7
    public class Switch : BTComposite
    {
        // Fields
        public System.Boolean dynamic;        // 0x98
        public NodeCanvas.BehaviourTrees.Switch.CaseSelectionMode selectionMode;        // 0x9C
        public NodeCanvas.Framework.BBParameter<System.Int32> intCase;        // 0xA0
        public NodeCanvas.BehaviourTrees.Switch.OutOfRangeMode outOfRangeMode;        // 0xA8
        public NodeCanvas.Framework.Internal.BBObjectParameter enumCase;        // 0xB0
        private System.Collections.Generic.Dictionary<System.Int32,System.Int32> enumCasePairing;        // 0xB8
        private System.Int32 current;        // 0xC0
        private System.Int32 runningIndex;        // 0xC4

        // Methods
        private System.Void OnGraphStarted() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003CA
    public class ConditionalEvaluator : BTDecorator, ITaskAssignable`1, ITaskAssignable, IGraphElement
    {
        // Fields
        public System.Boolean isDynamic;        // 0x98
        public ParadoxNotion.CompactStatus conditionFailReturn;        // 0x9C
        private NodeCanvas.Framework.ConditionTask _condition;        // 0xA0
        private System.Boolean accessed;        // 0xA8

        // Methods
        private NodeCanvas.Framework.Task get_task() { }
        private System.Void set_task(NodeCanvas.Framework.Task value) { }
        private NodeCanvas.Framework.ConditionTask get_condition() { }
        private System.Void set_condition(NodeCanvas.Framework.ConditionTask value) { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003CB
    public class Filter : BTDecorator
    {
        // Fields
        public NodeCanvas.BehaviourTrees.Filter.FilterMode filterMode;        // 0x98
        public NodeCanvas.Framework.BBParameter<System.Int32> maxCount;        // 0xA0
        public NodeCanvas.BehaviourTrees.Filter.Policy policy;        // 0xA8
        public NodeCanvas.Framework.BBParameter<System.Single> coolDownTime;        // 0xB0
        public System.Boolean inactiveWhenLimited;        // 0xB8
        private System.Int32 executedCount;        // 0xBC
        private System.Single currentTime;        // 0xC0
        private System.Single targetTime;        // 0xC4

        // Methods
        private System.Void OnGraphStoped() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnClearNodeData() { }
        private System.Collections.IEnumerator Cooldown() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003CF
    public class Guard : BTDecorator
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> token;        // 0x98
        public NodeCanvas.BehaviourTrees.Guard.GuardMode ifGuarded;        // 0xA0
        private System.Boolean isGuarding;        // 0xA4
        private static readonly System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Collections.Generic.List<NodeCanvas.BehaviourTrees.Guard>> guards;        // 0x0

        // Methods
        private System.Collections.Generic.List<NodeCanvas.BehaviourTrees.Guard> AgentGuards(UnityEngine.Component agent) { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void SetGuards(UnityEngine.Component guardAgent) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20003D1
    public class Interruptor : BTDecorator, ITaskAssignable`1, ITaskAssignable, IGraphElement
    {
        // Fields
        private NodeCanvas.Framework.ConditionTask _condition;        // 0x98

        // Methods
        private NodeCanvas.Framework.ConditionTask get_condition() { }
        private System.Void set_condition(NodeCanvas.Framework.ConditionTask value) { }
        private NodeCanvas.Framework.Task get_task() { }
        private System.Void set_task(NodeCanvas.Framework.Task value) { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003D2
    public class Inverter : BTDecorator
    {
        // Methods
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003D3
    public class Iterator : BTDecorator
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.IList> targetList;        // 0x98
        public NodeCanvas.Framework.Internal.BBObjectParameter current;        // 0xA0
        public NodeCanvas.Framework.BBParameter<System.Int32> storeIndex;        // 0xA8
        public NodeCanvas.BehaviourTrees.Iterator.TerminationConditions terminationCondition;        // 0xB0
        public NodeCanvas.Framework.BBParameter<System.Int32> maxIteration;        // 0xB8
        public System.Boolean resetIndex;        // 0xC0
        private System.Int32 currentIndex;        // 0xC4

        // Methods
        private System.Collections.IList get_list() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003D5
    public class Merge : BTDecorator
    {
        // Methods
        private System.Int32 get_maxInConnections() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003D6
    public class Monitor : BTDecorator, ITaskAssignable`1, ITaskAssignable, IGraphElement
    {
        // Fields
        public NodeCanvas.BehaviourTrees.Monitor.MonitorMode monitorMode;        // 0x98
        public NodeCanvas.BehaviourTrees.Monitor.ReturnStatusMode returnMode;        // 0x9C
        private NodeCanvas.Framework.Status decoratorActionStatus;        // 0xA0
        private NodeCanvas.Framework.ActionTask _action;        // 0xA8

        // Methods
        private NodeCanvas.Framework.ActionTask get_action() { }
        private System.Void set_action(NodeCanvas.Framework.ActionTask value) { }
        private NodeCanvas.Framework.Task get_task() { }
        private System.Void set_task(NodeCanvas.Framework.Task value) { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003D9
    public class Optional : BTDecorator
    {
        // Methods
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003DA
    public class Remapper : BTDecorator
    {
        // Fields
        public NodeCanvas.BehaviourTrees.Remapper.RemapStatus successRemap;        // 0x98
        public NodeCanvas.BehaviourTrees.Remapper.RemapStatus failureRemap;        // 0x9C

        // Methods
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003DC
    public class Repeater : BTDecorator
    {
        // Fields
        public NodeCanvas.BehaviourTrees.Repeater.RepeaterMode repeaterMode;        // 0x98
        public NodeCanvas.Framework.BBParameter<System.Int32> repeatTimes;        // 0xA0
        public NodeCanvas.BehaviourTrees.Repeater.RepeatUntilStatus repeatUntilStatus;        // 0xA8
        private System.Int32 currentIteration;        // 0xAC

        // Methods
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003DF
    public class Setter : BTDecorator
    {
        // Fields
        public System.Boolean revertToOriginal;        // 0x98
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> newAgent;        // 0xA0

        // Methods
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003E0
    public class Timeout : BTDecorator
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Single> timeout;        // 0x98

        // Methods
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003E1
    public class WaitUntil : BTDecorator, ITaskAssignable`1, ITaskAssignable, IGraphElement
    {
        // Fields
        private NodeCanvas.Framework.ConditionTask _condition;        // 0x98
        private System.Boolean accessed;        // 0xA0

        // Methods
        private NodeCanvas.Framework.Task get_task() { }
        private System.Void set_task(NodeCanvas.Framework.Task value) { }
        private NodeCanvas.Framework.ConditionTask get_condition() { }
        private System.Void set_condition(NodeCanvas.Framework.ConditionTask value) { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003E2
    public class ActionNode : BTNode, ITaskAssignable`1, ITaskAssignable, IGraphElement
    {
        // Fields
        private NodeCanvas.Framework.ActionTask _action;        // 0x98

        // Methods
        private NodeCanvas.Framework.Task get_task() { }
        private System.Void set_task(NodeCanvas.Framework.Task value) { }
        private NodeCanvas.Framework.ActionTask get_action() { }
        private System.Void set_action(NodeCanvas.Framework.ActionTask value) { }
        private System.String get_name() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void OnGraphPaused() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003E3
    public class ConditionNode : BTNode, ITaskAssignable`1, ITaskAssignable, IGraphElement
    {
        // Fields
        private NodeCanvas.Framework.ConditionTask _condition;        // 0x98

        // Methods
        private NodeCanvas.Framework.Task get_task() { }
        private System.Void set_task(NodeCanvas.Framework.Task value) { }
        private NodeCanvas.Framework.ConditionTask get_condition() { }
        private System.Void set_condition(NodeCanvas.Framework.ConditionTask value) { }
        private System.String get_name() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003E4
    public class NestedDT : BTNodeNested`1
    {
        // Fields
        private NodeCanvas.Framework.BBParameter<NodeCanvas.DialogueTrees.DialogueTree> _nestedDialogueTree;        // 0xB0

        // Methods
        private NodeCanvas.DialogueTrees.DialogueTree get_subGraph() { }
        private System.Void set_subGraph(NodeCanvas.DialogueTrees.DialogueTree value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnDLGFinished(System.Boolean success) { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003E5
    public class NestedFSM : BTNodeNested`1
    {
        // Fields
        private NodeCanvas.Framework.BBParameter<NodeCanvas.StateMachines.FSM> _nestedFSM;        // 0xB0
        public System.String successState;        // 0xB8
        public System.String failureState;        // 0xC0

        // Methods
        private NodeCanvas.StateMachines.FSM get_subGraph() { }
        private System.Void set_subGraph(NodeCanvas.StateMachines.FSM value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnFSMFinish(System.Boolean success) { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003E6
    public class SubTree : BTNodeNested`1
    {
        // Fields
        private NodeCanvas.Framework.BBParameter<NodeCanvas.BehaviourTrees.BehaviourTree> _subTree;        // 0xB0

        // Methods
        private NodeCanvas.BehaviourTrees.BehaviourTree get_subGraph() { }
        private System.Void set_subGraph(NodeCanvas.BehaviourTrees.BehaviourTree value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003E7
    public class NodeToggler : BTNode
    {
        // Fields
        public NodeCanvas.BehaviourTrees.NodeToggler.ToggleMode toggleMode;        // 0x98
        public System.String targetNodeTag;        // 0xA0
        private System.Collections.Generic.List<NodeCanvas.Framework.Node> targetNodes;        // 0xA8

        // Methods
        private System.Void OnGraphStarted() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003E9
    public class RootSwitcher : BTNode
    {
        // Fields
        public System.String targetNodeTag;        // 0x98
        private NodeCanvas.Framework.Node targetNode;        // 0xA0

        // Methods
        private System.Void OnGraphStarted() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003EA
    public class BTNestedFlowScript : BTNodeNested`1
    {
        // Fields
        private NodeCanvas.Framework.BBParameter<FlowCanvas.FlowScript> _flowScript;        // 0xB0

        // Methods
        private FlowCanvas.FlowScript get_subGraph() { }
        private System.Void set_subGraph(FlowCanvas.FlowScript value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnFlowScriptFinished(System.Boolean success) { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }

    }

}

namespace NodeCanvas.DialogueTrees
{

    // TypeToken: 0x2000386
    public class DialogueActor : MonoBehaviour, IDialogueActor
    {
        // Fields
        protected System.String _name;        // 0x18
        protected UnityEngine.Texture2D _portrait;        // 0x20
        protected UnityEngine.Color _dialogueColor;        // 0x28
        protected UnityEngine.Vector3 _dialogueOffset;        // 0x38
        private UnityEngine.Sprite _portraitSprite;        // 0x48

        // Methods
        private System.String get_name() { }
        private UnityEngine.Texture2D get_portrait() { }
        private UnityEngine.Sprite get_portraitSprite() { }
        private UnityEngine.Color get_dialogueColor() { }
        private UnityEngine.Vector3 get_dialoguePosition() { }
        private System.Void .ctor() { }
        private UnityEngine.Transform NodeCanvas.DialogueTrees.IDialogueActor.get_transform() { }

    }

    // TypeToken: 0x2000387
    public class SubtitlesRequestInfo
    {
        // Fields
        public NodeCanvas.DialogueTrees.IDialogueActor actor;        // 0x10
        public NodeCanvas.DialogueTrees.IStatement statement;        // 0x18
        public System.Action Continue;        // 0x20

        // Methods
        private System.Void .ctor(NodeCanvas.DialogueTrees.IDialogueActor actor, NodeCanvas.DialogueTrees.IStatement statement, System.Action callback) { }

    }

    // TypeToken: 0x2000388
    public class MultipleChoiceRequestInfo
    {
        // Fields
        public NodeCanvas.DialogueTrees.IDialogueActor actor;        // 0x10
        public System.Collections.Generic.Dictionary<NodeCanvas.DialogueTrees.IStatement,System.Int32> options;        // 0x18
        public System.Single availableTime;        // 0x20
        public System.Boolean showLastStatement;        // 0x24
        public System.Action<System.Int32> SelectOption;        // 0x28

        // Methods
        private System.Void .ctor(NodeCanvas.DialogueTrees.IDialogueActor actor, System.Collections.Generic.Dictionary<NodeCanvas.DialogueTrees.IStatement,System.Int32> options, System.Single availableTime, System.Boolean showLastStatement, System.Action<System.Int32> callback) { }
        private System.Void .ctor(NodeCanvas.DialogueTrees.IDialogueActor actor, System.Collections.Generic.Dictionary<NodeCanvas.DialogueTrees.IStatement,System.Int32> options, System.Single availableTime, System.Action<System.Int32> callback) { }

    }

    // TypeToken: 0x2000389
    public class DialogueTree : Graph
    {
        // Fields
        public static System.String INSTIGATOR_NAME;        // 0x0
        public System.Collections.Generic.List<NodeCanvas.DialogueTrees.DialogueTree.ActorParameter> actorParameters;        // 0xA0
        private static System.Action<NodeCanvas.DialogueTrees.DialogueTree> OnDialogueStarted;        // 0x0
        private static System.Action<NodeCanvas.DialogueTrees.DialogueTree> OnDialoguePaused;        // 0x8
        private static System.Action<NodeCanvas.DialogueTrees.DialogueTree> OnDialogueFinished;        // 0x10
        private static System.Action<NodeCanvas.DialogueTrees.SubtitlesRequestInfo> OnSubtitlesRequest;        // 0x18
        private static System.Action<NodeCanvas.DialogueTrees.MultipleChoiceRequestInfo> OnMultipleChoiceRequest;        // 0x20
        private static NodeCanvas.DialogueTrees.DialogueTree <currentDialogue>k__BackingField;        // 0x28
        private static NodeCanvas.DialogueTrees.DialogueTree <previousDialogue>k__BackingField;        // 0x30
        private NodeCanvas.DialogueTrees.DTNode <currentNode>k__BackingField;        // 0xA8

        // Methods
        private System.Object OnDerivedDataSerialization() { }
        private System.Void OnDerivedDataDeserialization(System.Object data) { }
        private System.Void add_OnDialogueStarted(System.Action<NodeCanvas.DialogueTrees.DialogueTree> value) { }
        private System.Void remove_OnDialogueStarted(System.Action<NodeCanvas.DialogueTrees.DialogueTree> value) { }
        private System.Void add_OnDialoguePaused(System.Action<NodeCanvas.DialogueTrees.DialogueTree> value) { }
        private System.Void remove_OnDialoguePaused(System.Action<NodeCanvas.DialogueTrees.DialogueTree> value) { }
        private System.Void add_OnDialogueFinished(System.Action<NodeCanvas.DialogueTrees.DialogueTree> value) { }
        private System.Void remove_OnDialogueFinished(System.Action<NodeCanvas.DialogueTrees.DialogueTree> value) { }
        private System.Void add_OnSubtitlesRequest(System.Action<NodeCanvas.DialogueTrees.SubtitlesRequestInfo> value) { }
        private System.Void remove_OnSubtitlesRequest(System.Action<NodeCanvas.DialogueTrees.SubtitlesRequestInfo> value) { }
        private System.Void add_OnMultipleChoiceRequest(System.Action<NodeCanvas.DialogueTrees.MultipleChoiceRequestInfo> value) { }
        private System.Void remove_OnMultipleChoiceRequest(System.Action<NodeCanvas.DialogueTrees.MultipleChoiceRequestInfo> value) { }
        private NodeCanvas.DialogueTrees.DialogueTree get_currentDialogue() { }
        private System.Void set_currentDialogue(NodeCanvas.DialogueTrees.DialogueTree value) { }
        private NodeCanvas.DialogueTrees.DialogueTree get_previousDialogue() { }
        private System.Void set_previousDialogue(NodeCanvas.DialogueTrees.DialogueTree value) { }
        private NodeCanvas.DialogueTrees.DTNode get_currentNode() { }
        private System.Void set_currentNode(NodeCanvas.DialogueTrees.DTNode value) { }
        private System.Type get_baseNodeType() { }
        private System.Boolean get_requiresAgent() { }
        private System.Boolean get_requiresPrimeNode() { }
        private System.Boolean get_isTree() { }
        private System.Boolean get_allowBlackboardOverrides() { }
        private System.Boolean get_canAcceptVariableDrops() { }
        private System.Boolean get_canDelayDeserializeAndOptimizeClone() { }
        private System.Collections.Generic.List<System.String> get_definedActorParameterNames() { }
        private NodeCanvas.DialogueTrees.DialogueTree.ActorParameter GetParameterByID(System.String id) { }
        private NodeCanvas.DialogueTrees.DialogueTree.ActorParameter GetParameterByName(System.String paramName) { }
        private NodeCanvas.DialogueTrees.IDialogueActor GetActorReferenceByID(System.String id) { }
        private NodeCanvas.DialogueTrees.IDialogueActor GetActorReferenceByName(System.String paramName) { }
        private System.Void SetActorReference(System.String paramName, NodeCanvas.DialogueTrees.IDialogueActor actor) { }
        private System.Void SetActorReferences(System.Collections.Generic.Dictionary<System.String,NodeCanvas.DialogueTrees.IDialogueActor> actors) { }
        private System.Void Continue(System.Int32 index) { }
        private System.Void EnterNode(NodeCanvas.DialogueTrees.DTNode node) { }
        private System.Void RequestSubtitles(NodeCanvas.DialogueTrees.SubtitlesRequestInfo info) { }
        private System.Void RequestMultipleChoices(NodeCanvas.DialogueTrees.MultipleChoiceRequestInfo info) { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphUpdate() { }
        private System.Void OnGraphStoped() { }
        private System.Void OnGraphPaused() { }
        private System.Void OnGraphUnpaused() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000392
    public class DialogueTreeController : GraphOwner`1, IDialogueActor
    {
        // Methods
        private System.String NodeCanvas.DialogueTrees.IDialogueActor.get_name() { }
        private UnityEngine.Texture2D NodeCanvas.DialogueTrees.IDialogueActor.get_portrait() { }
        private UnityEngine.Sprite NodeCanvas.DialogueTrees.IDialogueActor.get_portraitSprite() { }
        private UnityEngine.Color NodeCanvas.DialogueTrees.IDialogueActor.get_dialogueColor() { }
        private UnityEngine.Vector3 NodeCanvas.DialogueTrees.IDialogueActor.get_dialoguePosition() { }
        private UnityEngine.Transform NodeCanvas.DialogueTrees.IDialogueActor.get_transform() { }
        private System.Void StartDialogue() { }
        private System.Void StartDialogue(System.Action<System.Boolean> callback) { }
        private System.Void StartDialogue(NodeCanvas.DialogueTrees.IDialogueActor instigator) { }
        private System.Void StartDialogue(NodeCanvas.DialogueTrees.DialogueTree newTree, NodeCanvas.DialogueTrees.IDialogueActor instigator, System.Action<System.Boolean> callback) { }
        private System.Void StartDialogue(NodeCanvas.DialogueTrees.IDialogueActor instigator, System.Action<System.Boolean> callback) { }
        private System.Void PauseDialogue() { }
        private System.Void StopDialogue() { }
        private System.Void SetActorReference(System.String paramName, NodeCanvas.DialogueTrees.IDialogueActor actor) { }
        private System.Void SetActorReferences(System.Collections.Generic.Dictionary<System.String,NodeCanvas.DialogueTrees.IDialogueActor> actors) { }
        private NodeCanvas.DialogueTrees.IDialogueActor GetActorReferenceByName(System.String paramName) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000393
    public class DTConnection : Connection
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000394
    public class DTNode : Node
    {
        // Fields
        private System.String _actorName;        // 0x98
        private System.String _actorParameterID;        // 0xA0

        // Methods
        private System.String get_name() { }
        private System.Boolean get_requireActorSelection() { }
        private System.Int32 get_maxInConnections() { }
        private System.Int32 get_maxOutConnections() { }
        private System.Type get_outConnectionType() { }
        private System.Boolean get_allowAsPrime() { }
        private System.Boolean get_canSelfConnect() { }
        private ParadoxNotion.Alignment2x2 get_commentsAlignment() { }
        private ParadoxNotion.Alignment2x2 get_iconAlignment() { }
        private NodeCanvas.DialogueTrees.DialogueTree get_DLGTree() { }
        private System.String get_actorName() { }
        private System.Void set_actorName(System.String value) { }
        private NodeCanvas.DialogueTrees.IDialogueActor get_finalActor() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000395
    public class DTNodeNested`1 : DTNode, IGraphAssignable`1, IGraphAssignable, IGraphElement
    {
        // Fields
        private System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> _variablesMap;        // 0x0
        private T <currentInstance>k__BackingField;        // 0x0
        private System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> <instances>k__BackingField;        // 0x0

        // Methods
        private T get_subGraph() { }
        private System.Void set_subGraph(T value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private T get_currentInstance() { }
        private System.Void set_currentInstance(T value) { }
        private System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> get_instances() { }
        private System.Void set_instances(System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> value) { }
        private System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> get_variablesMap() { }
        private System.Void set_variablesMap(System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> value) { }
        private NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_subGraph() { }
        private System.Void NodeCanvas.Framework.IGraphAssignable.set_subGraph(NodeCanvas.Framework.Graph value) { }
        private NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_currentInstance() { }
        private System.Void NodeCanvas.Framework.IGraphAssignable.set_currentInstance(NodeCanvas.Framework.Graph value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000396
    public interface IDialogueActor
    {
        // Methods
        private System.String get_name() { }
        private UnityEngine.Texture2D get_portrait() { }
        private UnityEngine.Sprite get_portraitSprite() { }
        private UnityEngine.Color get_dialogueColor() { }
        private UnityEngine.Vector3 get_dialoguePosition() { }
        private UnityEngine.Transform get_transform() { }

    }

    // TypeToken: 0x2000397
    public class ProxyDialogueActor, IDialogueActor
    {
        // Fields
        private System.String _name;        // 0x10
        private UnityEngine.Transform _transform;        // 0x18

        // Methods
        private System.String get_name() { }
        private UnityEngine.Texture2D get_portrait() { }
        private UnityEngine.Sprite get_portraitSprite() { }
        private UnityEngine.Color get_dialogueColor() { }
        private UnityEngine.Vector3 get_dialoguePosition() { }
        private UnityEngine.Transform get_transform() { }
        private System.Void .ctor(System.String name, UnityEngine.Transform transform) { }

    }

    // TypeToken: 0x2000398
    public interface IStatement
    {
        // Methods
        private System.String get_text() { }
        private UnityEngine.AudioClip get_audio() { }
        private System.String get_meta() { }

    }

    // TypeToken: 0x2000399
    public class Statement, IStatement
    {
        // Fields
        private System.String _text;        // 0x10
        private UnityEngine.AudioClip _audio;        // 0x18
        private System.String _meta;        // 0x20

        // Methods
        private System.String get_text() { }
        private System.Void set_text(System.String value) { }
        private UnityEngine.AudioClip get_audio() { }
        private System.Void set_audio(UnityEngine.AudioClip value) { }
        private System.String get_meta() { }
        private System.Void set_meta(System.String value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String text) { }
        private System.Void .ctor(System.String text, UnityEngine.AudioClip audio) { }
        private System.Void .ctor(System.String text, UnityEngine.AudioClip audio, System.String meta) { }
        private NodeCanvas.DialogueTrees.IStatement BlackboardReplace(NodeCanvas.Framework.IBlackboard bb) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200039B
    public class ActionNode : DTNode, ITaskAssignable`1, ITaskAssignable, IGraphElement
    {
        // Fields
        private NodeCanvas.Framework.ActionTask _action;        // 0xA8

        // Methods
        private NodeCanvas.Framework.ActionTask get_action() { }
        private System.Void set_action(NodeCanvas.Framework.ActionTask value) { }
        private NodeCanvas.Framework.Task get_task() { }
        private System.Void set_task(NodeCanvas.Framework.Task value) { }
        private System.Boolean get_requireActorSelection() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb) { }
        private System.Collections.IEnumerator UpdateAction(UnityEngine.Component actionAgent) { }
        private System.Void OnActionEnd(System.Boolean success) { }
        private System.Void OnReset() { }
        private System.Void OnGraphPaused() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200039D
    public class ConditionNode : DTNode, ITaskAssignable`1, ITaskAssignable, IGraphElement
    {
        // Fields
        private NodeCanvas.Framework.ConditionTask _condition;        // 0xA8

        // Methods
        private NodeCanvas.Framework.ConditionTask get_condition() { }
        private System.Void set_condition(NodeCanvas.Framework.ConditionTask value) { }
        private NodeCanvas.Framework.Task get_task() { }
        private System.Void set_task(NodeCanvas.Framework.Task value) { }
        private System.Int32 get_maxOutConnections() { }
        private System.Boolean get_requireActorSelection() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200039E
    public class FinishNode : DTNode
    {
        // Fields
        public ParadoxNotion.CompactStatus finishState;        // 0xA8

        // Methods
        private System.Int32 get_maxOutConnections() { }
        private System.Boolean get_requireActorSelection() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200039F
    public class Jumper : DTNode, IHaveNodeReference, IGraphElement
    {
        // Fields
        public NodeCanvas.Framework.NodeReference<NodeCanvas.DialogueTrees.DTNode> _targetNode;        // 0xA8

        // Methods
        private NodeCanvas.Framework.INodeReference NodeCanvas.Framework.IHaveNodeReference.get_targetReference() { }
        private NodeCanvas.DialogueTrees.DTNode get_target() { }
        private System.Int32 get_maxOutConnections() { }
        private System.Boolean get_requireActorSelection() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003A0
    public class MultipleChoiceNode : DTNode
    {
        // Fields
        public System.Single availableTime;        // 0xA8
        public System.Boolean saySelection;        // 0xAC
        private System.Collections.Generic.List<NodeCanvas.DialogueTrees.MultipleChoiceNode.Choice> availableChoices;        // 0xB0

        // Methods
        private System.Int32 get_maxOutConnections() { }
        private System.Boolean get_requireActorSelection() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb) { }
        private System.Void OnOptionSelected(System.Int32 index) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003A3
    public class MultipleConditionNode : DTNode
    {
        // Fields
        private System.Collections.Generic.List<NodeCanvas.Framework.ConditionTask> conditions;        // 0xA8

        // Methods
        private System.Int32 get_maxOutConnections() { }
        private System.Void OnChildConnected(System.Int32 index) { }
        private System.Void OnChildDisconnected(System.Int32 index) { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003A4
    public class ProbabilitySelector : DTNode
    {
        // Fields
        private System.Collections.Generic.List<NodeCanvas.DialogueTrees.ProbabilitySelector.Option> childOptions;        // 0xA8
        private System.Collections.Generic.List<System.Int32> successIndeces;        // 0xB0

        // Methods
        private System.Int32 get_maxOutConnections() { }
        private System.Void OnChildConnected(System.Int32 index) { }
        private System.Void OnChildDisconnected(System.Int32 index) { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Single GetTotal() { }
        private System.Void OnReset() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003A6
    public class StatementNode : DTNode
    {
        // Fields
        public NodeCanvas.DialogueTrees.Statement statement;        // 0xA8

        // Methods
        private System.Boolean get_requireActorSelection() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb) { }
        private System.Void OnStatementFinish() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003A7
    public class SubDialogueTree : DTNodeNested`1, IUpdatable, IGraphElement
    {
        // Fields
        private NodeCanvas.Framework.BBParameter<NodeCanvas.DialogueTrees.DialogueTree> _subTree;        // 0xC0
        private System.Collections.Generic.Dictionary<System.String,System.String> _actorParametersMap;        // 0xC8

        // Methods
        private System.Int32 get_maxOutConnections() { }
        private NodeCanvas.DialogueTrees.DialogueTree get_subGraph() { }
        private System.Void set_subGraph(NodeCanvas.DialogueTrees.DialogueTree value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb) { }
        private System.Void OnSubDialogueFinish(System.Boolean success) { }
        private System.Void NodeCanvas.Framework.IUpdatable.Update() { }
        private System.Void TryWriteMappedActorParameters() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003A8
    public class GoToNode : DTNode
    {
        // Fields
        private NodeCanvas.DialogueTrees.DTNode _targetNode;        // 0xA8

        // Methods
        private System.Int32 get_maxOutConnections() { }
        private System.Boolean get_requireActorSelection() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003A9
    public class DTNestedFlowScript : DTNodeNested`1, IUpdatable, IGraphElement
    {
        // Fields
        private NodeCanvas.Framework.BBParameter<FlowCanvas.FlowScript> _flowScript;        // 0xC0

        // Methods
        private System.Int32 get_maxOutConnections() { }
        private FlowCanvas.FlowScript get_subGraph() { }
        private System.Void set_subGraph(FlowCanvas.FlowScript value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb) { }
        private System.Void NodeCanvas.Framework.IUpdatable.Update() { }
        private System.Void OnFlowScriptFinish(System.Boolean success) { }
        private System.Void .ctor() { }

    }

}

namespace NodeCanvas.DialogueTrees.UI.Examples
{

    // TypeToken: 0x20003AA
    public class DialogueUGUI : MonoBehaviour
    {
        // Fields
        public System.Boolean skipOnInput;        // 0x18
        public System.Boolean waitForInput;        // 0x19
        public UnityEngine.RectTransform subtitlesGroup;        // 0x20
        public UnityEngine.UI.Text actorSpeech;        // 0x28
        public UnityEngine.UI.Text actorName;        // 0x30
        public UnityEngine.UI.Image actorPortrait;        // 0x38
        public UnityEngine.RectTransform waitInputIndicator;        // 0x40
        public NodeCanvas.DialogueTrees.UI.Examples.DialogueUGUI.SubtitleDelays subtitleDelays;        // 0x48
        public System.Collections.Generic.List<UnityEngine.AudioClip> typingSounds;        // 0x50
        private UnityEngine.AudioSource playSource;        // 0x58
        public UnityEngine.RectTransform optionsGroup;        // 0x60
        public UnityEngine.UI.Button optionButton;        // 0x68
        private System.Collections.Generic.Dictionary<UnityEngine.UI.Button,System.Int32> cachedButtons;        // 0x70
        private UnityEngine.Vector2 originalSubsPosition;        // 0x78
        private System.Boolean isWaitingChoice;        // 0x80
        private UnityEngine.AudioSource _localSource;        // 0x88

        // Methods
        private UnityEngine.AudioSource get_localSource() { }
        private System.Boolean get_anyKeyDown() { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Subscribe() { }
        private System.Void UnSubscribe() { }
        private System.Void Hide() { }
        private System.Void OnDialogueStarted(NodeCanvas.DialogueTrees.DialogueTree dlg) { }
        private System.Void OnDialoguePaused(NodeCanvas.DialogueTrees.DialogueTree dlg) { }
        private System.Void OnDialogueFinished(NodeCanvas.DialogueTrees.DialogueTree dlg) { }
        private System.Void OnSubtitlesRequest(NodeCanvas.DialogueTrees.SubtitlesRequestInfo info) { }
        private System.Collections.IEnumerator Internal_OnSubtitlesRequestInfo(NodeCanvas.DialogueTrees.SubtitlesRequestInfo info) { }
        private System.Void PlayTypeSound() { }
        private System.Collections.IEnumerator CheckInput(System.Action Do) { }
        private System.Collections.IEnumerator DelayPrint(System.Single time) { }
        private System.Void OnMultipleChoiceRequest(NodeCanvas.DialogueTrees.MultipleChoiceRequestInfo info) { }
        private System.Collections.IEnumerator CountDown(NodeCanvas.DialogueTrees.MultipleChoiceRequestInfo info) { }
        private System.Void Finalize(NodeCanvas.DialogueTrees.MultipleChoiceRequestInfo info, System.Int32 index) { }
        private System.Void SetMassAlpha(UnityEngine.RectTransform root, System.Single alpha) { }
        private System.Void .ctor() { }

    }

}

namespace NodeCanvas.Framework
{

    // TypeToken: 0x20003EB
    public class GraphInfoAttribute : Attribute
    {
        // Fields
        public System.String packageName;        // 0x10
        public System.String docsURL;        // 0x18
        public System.String resourcesURL;        // 0x20
        public System.String forumsURL;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003EC
    public class DropReferenceType : Attribute
    {
        // Fields
        public readonly System.Type type;        // 0x10

        // Methods
        private System.Void .ctor(System.Type type) { }

    }

    // TypeToken: 0x20003ED
    public class BlackboardOnlyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003EE
    public class LogTag
    {
        // Fields
        public static System.String EDITOR;        // 0x0
        public static System.String EVENT;        // 0x0
        public static System.String EXECUTION;        // 0x0
        public static System.String VARIABLE;        // 0x0
        public static System.String BLACKBOARD;        // 0x0
        public static System.String GRAPH;        // 0x0
        public static System.String INIT;        // 0x0
        public static System.String VALIDATION;        // 0x0
        public static System.String SERIALIZATION;        // 0x0

    }

    // TypeToken: 0x20003EF
    public class SignalDefinition : ScriptableObject
    {
        // Fields
        private NodeCanvas.Framework.SignalDefinition.InvokeArguments onInvoke;        // 0x18
        private System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition> _parameters;        // 0x20

        // Methods
        private System.Void add_onInvoke(NodeCanvas.Framework.SignalDefinition.InvokeArguments value) { }
        private System.Void remove_onInvoke(NodeCanvas.Framework.SignalDefinition.InvokeArguments value) { }
        private System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition> get_parameters() { }
        private System.Void set_parameters(System.Collections.Generic.List<ParadoxNotion.DynamicParameterDefinition> value) { }
        private System.Void Invoke(UnityEngine.Transform sender, UnityEngine.Transform receiver, System.Boolean isGlobal, System.Object[] args) { }
        private System.Void AddParameter(System.String name, System.Type type) { }
        private System.Void RemoveParameter(System.String name) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003F2
    public class CanvasGroup
    {
        // Fields
        public System.String name;        // 0x10
        public UnityEngine.Rect rect;        // 0x18
        public UnityEngine.Color color;        // 0x28
        public System.Boolean autoGroup;        // 0x38

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(UnityEngine.Rect rect, System.String name) { }

    }

    // TypeToken: 0x20003F3
    public class Connection, IGraphElement, ISerializationCollectable
    {
        // Fields
        private NodeCanvas.Framework.Node _sourceNode;        // 0x10
        private NodeCanvas.Framework.Node _targetNode;        // 0x18
        private System.String _UID;        // 0x20
        private System.Boolean _isDisabled;        // 0x28
        private NodeCanvas.Framework.Status _status;        // 0x2C

        // Methods
        private System.String get_UID() { }
        private NodeCanvas.Framework.Node get_sourceNode() { }
        private System.Void set_sourceNode(NodeCanvas.Framework.Node value) { }
        private NodeCanvas.Framework.Node get_targetNode() { }
        private System.Void set_targetNode(NodeCanvas.Framework.Node value) { }
        private System.String NodeCanvas.Framework.IGraphElement.get_name() { }
        private System.Boolean get_isActive() { }
        private System.Void set_isActive(System.Boolean value) { }
        private NodeCanvas.Framework.Status get_status() { }
        private System.Void set_status(NodeCanvas.Framework.Status value) { }
        private NodeCanvas.Framework.Graph get_graph() { }
        private System.Boolean get_drawInspector() { }
        private System.Void .ctor() { }
        private NodeCanvas.Framework.Connection Create(NodeCanvas.Framework.Node source, NodeCanvas.Framework.Node target, System.Int32 sourceIndex, System.Int32 targetIndex) { }
        private NodeCanvas.Framework.Connection Duplicate(NodeCanvas.Framework.Node newSource, NodeCanvas.Framework.Node newTarget) { }
        private System.Int32 SetSourceNode(NodeCanvas.Framework.Node newSource, System.Int32 index, System.Boolean recodeUndo) { }
        private System.Int32 SetTargetNode(NodeCanvas.Framework.Node newTarget, System.Int32 index, System.Boolean recodeUndo) { }
        private NodeCanvas.Framework.Status Execute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void Reset(System.Boolean recursively) { }
        private System.Void OnCreate(System.Int32 sourceIndex, System.Int32 targetIndex) { }
        private System.Void OnValidate(System.Int32 sourceIndex, System.Int32 targetIndex) { }
        private System.Void OnDestroy() { }
        private System.Void OnDestroyAfterConnectionRemoved() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20003F4
    public class ExposedParameter
    {
        // Methods
        private System.String get_targetVariableID() { }
        private System.Type get_type() { }
        private System.Object get_valueBoxed() { }
        private System.Void set_valueBoxed(System.Object value) { }
        private System.Void Bind(NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void UnBind() { }
        private NodeCanvas.Framework.Variable get_varRefBoxed() { }
        private NodeCanvas.Framework.ExposedParameter CreateInstance(NodeCanvas.Framework.Variable target) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20003F5
    public class ExposedParameter`1 : ExposedParameter
    {
        // Fields
        private System.String _targetVariableID;        // 0x0
        private T _value;        // 0x0
        private NodeCanvas.Framework.Variable<T> <varRef>k__BackingField;        // 0x0

        // Methods
        private NodeCanvas.Framework.Variable<T> get_varRef() { }
        private System.Void set_varRef(NodeCanvas.Framework.Variable<T> value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(NodeCanvas.Framework.Variable target) { }
        private System.String get_targetVariableID() { }
        private System.Type get_type() { }
        private System.Object get_valueBoxed() { }
        private System.Void set_valueBoxed(System.Object value) { }
        private NodeCanvas.Framework.Variable get_varRefBoxed() { }
        private T get_value() { }
        private System.Void set_value(T value) { }
        private System.Void Bind(NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void UnBind() { }
        private T GetRawValue() { }
        private System.Void SetRawValue(T value) { }

    }

    // TypeToken: 0x20003F6
    public class Graph : ScriptableObject, ITaskSystem, ISerializationCallbackReceiver, IStringCompressProcessor
    {
        // Fields
        private System.String _serializedGraph;        // 0x18
        protected System.Int32 _serializedGraphStringIndex;        // 0x20
        private System.Collections.Generic.List<UnityEngine.Object> _objectReferences;        // 0x28
        private NodeCanvas.Framework.Internal.GraphSource _graphSource;        // 0x30
        private System.Boolean _haltSerialization;        // 0x38
        private System.Boolean haltForUndo;        // 0x39
        private static System.Action<NodeCanvas.Framework.Graph> onGraphSerialized;        // 0x0
        public static System.Action<NodeCanvas.Framework.Graph> onGraphDeserialized;        // 0x8
        private System.Boolean <isDeserialized>k__BackingField;        // 0x3A
        private static System.Collections.Generic.List<NodeCanvas.Framework.Node> s_nodeBuffer;        // 0x10
        private System.Boolean <graphValidateDirty>k__BackingField;        // 0x3B
        private System.Action<System.Boolean> onFinish;        // 0x40
        private static System.Collections.Generic.List<NodeCanvas.Framework.Graph> _runningGraphs;        // 0x18
        private System.Boolean <hasInitialized>k__BackingField;        // 0x48
        private ParadoxNotion.HierarchyTree.Element <flatMetaGraph>k__BackingField;        // 0x50
        private ParadoxNotion.HierarchyTree.Element <fullMetaGraph>k__BackingField;        // 0x58
        private ParadoxNotion.HierarchyTree.Element <nestedMetaGraph>k__BackingField;        // 0x60
        private NodeCanvas.Framework.Graph <parentGraph>k__BackingField;        // 0x68
        private System.Single <elapsedTime>k__BackingField;        // 0x70
        private System.Single <deltaTime>k__BackingField;        // 0x74
        private System.Int32 <lastUpdateFrame>k__BackingField;        // 0x78
        private System.Boolean <isRunning>k__BackingField;        // 0x7C
        private System.Boolean <isPaused>k__BackingField;        // 0x7D
        private NodeCanvas.Framework.Graph.UpdateMode <updateMode>k__BackingField;        // 0x80
        private UnityEngine.Component <agent>k__BackingField;        // 0x88
        private NodeCanvas.Framework.IBlackboard <parentBlackboard>k__BackingField;        // 0x90
        private System.Action delayedInitCalls;        // 0x98

        // Methods
        private System.Void add_onGraphSerialized(System.Action<NodeCanvas.Framework.Graph> value) { }
        private System.Void remove_onGraphSerialized(System.Action<NodeCanvas.Framework.Graph> value) { }
        private System.Boolean get_allowRuntimeSerialization() { }
        private System.Boolean get_dontSerializeBinderConnectionGenericType() { }
        private System.Boolean get_isDeserialized() { }
        private System.Void set_isDeserialized(System.Boolean value) { }
        private System.Boolean get_canDelayDeserializeAndOptimizeClone() { }
        private UnityEngine.Rect DrawCustomBlackboardPanel(UnityEngine.Event e, UnityEngine.Rect canvasRect, UnityEngine.Vector2 canvasMousePos) { }
        private UnityEngine.Rect DrawCustomPanel(UnityEngine.Event e, UnityEngine.Rect canvasRect, UnityEngine.Vector2 canvasMousePos) { }
        private UnityEngine.Rect DrawCustomPanel2(UnityEngine.Event e, UnityEngine.Rect canvasRect, UnityEngine.Vector2 canvasMousePos) { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void TryDeserializeIfNot() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void OnValidate() { }
        private System.Void Reset() { }
        private System.Boolean SelfSerialize(System.Boolean ignoreScene) { }
        private System.Void OnAfterGraphSerialized() { }
        private System.Boolean SelfDeserialize() { }
        private System.String Serialize(System.Collections.Generic.List<UnityEngine.Object> references) { }
        private System.Boolean Deserialize(System.String serializedGraph, System.Collections.Generic.List<UnityEngine.Object> references, System.Boolean validate) { }
        private System.Boolean DeserializeSelf(System.Collections.Generic.List<UnityEngine.Object> references, System.Boolean validate) { }
        private NodeCanvas.Framework.Internal.GraphSource GetGraphSource() { }
        private System.String GetSerializedJsonData() { }
        private System.Int32 GetSerializedJsonDataStringIndex() { }
        private System.Boolean DeserializeFromGraph(NodeCanvas.Framework.Graph other, System.Boolean validate) { }
        private Beyond.DataCompressManager.StringCompressUnsafeString GetSerializedJsonDataUnsafeString() { }
        private System.Void ClearSerializedJsonData() { }
        private System.Collections.Generic.List<UnityEngine.Object> GetSerializedReferencesData() { }
        private NodeCanvas.Framework.Internal.GraphSource GetGraphSourceMetaDataCopy() { }
        private System.Void SetGraphSourceMetaData(NodeCanvas.Framework.Internal.GraphSource source) { }
        private System.String SerializeLocalBlackboard(System.Collections.Generic.List<UnityEngine.Object>& references) { }
        private System.Boolean DeserializeLocalBlackboard(System.String json, System.Collections.Generic.List<UnityEngine.Object> references) { }
        private T Clone(T graph, NodeCanvas.Framework.Graph parentGraph) { }
        private System.Void Validate() { }
        private System.Boolean get_graphValidateDirty() { }
        private System.Void set_graphValidateDirty(System.Boolean value) { }
        private System.Void add_onFinish(System.Action<System.Boolean> value) { }
        private System.Void remove_onFinish(System.Action<System.Boolean> value) { }
        private System.Boolean get_hasInitialized() { }
        private System.Void set_hasInitialized(System.Boolean value) { }
        private ParadoxNotion.HierarchyTree.Element get_flatMetaGraph() { }
        private System.Void set_flatMetaGraph(ParadoxNotion.HierarchyTree.Element value) { }
        private ParadoxNotion.HierarchyTree.Element get_fullMetaGraph() { }
        private System.Void set_fullMetaGraph(ParadoxNotion.HierarchyTree.Element value) { }
        private ParadoxNotion.HierarchyTree.Element get_nestedMetaGraph() { }
        private System.Void set_nestedMetaGraph(ParadoxNotion.HierarchyTree.Element value) { }
        private System.Type get_baseNodeType() { }
        private System.Boolean get_requiresAgent() { }
        private System.Boolean get_requiresPrimeNode() { }
        private System.Boolean get_isTree() { }
        private System.Boolean get_allowBlackboardOverrides() { }
        private System.Boolean get_canAcceptVariableDrops() { }
        private NodeCanvas.Framework.Internal.GraphSource get_graphSource() { }
        private System.Void set_graphSource(NodeCanvas.Framework.Internal.GraphSource value) { }
        private System.String get_category() { }
        private System.Void set_category(System.String value) { }
        private System.String get_comments() { }
        private System.Void set_comments(System.String value) { }
        private UnityEngine.Vector2 get_translation() { }
        private System.Void set_translation(UnityEngine.Vector2 value) { }
        private System.Single get_zoomFactor() { }
        private System.Void set_zoomFactor(System.Single value) { }
        private System.Collections.Generic.List<NodeCanvas.Framework.Node> get_allNodes() { }
        private System.Void set_allNodes(System.Collections.Generic.List<NodeCanvas.Framework.Node> value) { }
        private System.Collections.Generic.List<NodeCanvas.Framework.CanvasGroup> get_canvasGroups() { }
        private System.Void set_canvasGroups(System.Collections.Generic.List<NodeCanvas.Framework.CanvasGroup> value) { }
        private NodeCanvas.Framework.Internal.BlackboardSource get_localBlackboard() { }
        private System.Void set_localBlackboard(NodeCanvas.Framework.Internal.BlackboardSource value) { }
        private System.Collections.Generic.List<NodeCanvas.Framework.BBParameter> get_allParameters() { }
        private System.Collections.Generic.List<NodeCanvas.Framework.Task> get_allTasks() { }
        private System.Collections.Generic.List<NodeCanvas.Framework.Connection> get_allConnections() { }
        private NodeCanvas.Framework.Graph get_rootGraph() { }
        private System.Boolean get_serializationHalted() { }
        private System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Graph> get_runningGraphs() { }
        private NodeCanvas.Framework.Graph get_parentGraph() { }
        private System.Void set_parentGraph(NodeCanvas.Framework.Graph value) { }
        private System.Single get_elapsedTime() { }
        private System.Void set_elapsedTime(System.Single value) { }
        private System.Single get_deltaTime() { }
        private System.Void set_deltaTime(System.Single value) { }
        private System.Int32 get_lastUpdateFrame() { }
        private System.Void set_lastUpdateFrame(System.Int32 value) { }
        private System.Boolean get_didUpdateLastFrame() { }
        private System.Boolean get_isRunning() { }
        private System.Void set_isRunning(System.Boolean value) { }
        private System.Boolean get_isPaused() { }
        private System.Void set_isPaused(System.Boolean value) { }
        private NodeCanvas.Framework.Graph.UpdateMode get_updateMode() { }
        private System.Void set_updateMode(NodeCanvas.Framework.Graph.UpdateMode value) { }
        private NodeCanvas.Framework.Node get_primeNode() { }
        private System.Void set_primeNode(NodeCanvas.Framework.Node value) { }
        private UnityEngine.Component get_agent() { }
        private System.Void set_agent(UnityEngine.Component value) { }
        private NodeCanvas.Framework.IBlackboard get_blackboard() { }
        private NodeCanvas.Framework.IBlackboard get_parentBlackboard() { }
        private System.Void set_parentBlackboard(NodeCanvas.Framework.IBlackboard value) { }
        private UnityEngine.Object NodeCanvas.Framework.ITaskSystem.get_contextObject() { }
        private System.Void UpdateReferencesFromOwner(NodeCanvas.Framework.GraphOwner owner, System.Boolean force) { }
        private System.Void UpdateReferences(UnityEngine.Component newAgent, NodeCanvas.Framework.IBlackboard newParentBlackboard, System.Boolean force) { }
        private System.Void UpdateNodeBBFields() { }
        private System.Void NodeCanvas.Framework.ITaskSystem.UpdateTasksOwner() { }
        private System.Void UpdateNodeIDs(System.Boolean alsoReorderList) { }
        private System.Void OnGraphStructureChange() { }
        private System.Void OnAfterUpdateNodeIDs() { }
        private System.Int32 AssignNodeID(NodeCanvas.Framework.Node node, System.Int32 lastID, NodeCanvas.Framework.Node[]& parsed) { }
        private System.Void add_delayedInitCalls(System.Action value) { }
        private System.Void remove_delayedInitCalls(System.Action value) { }
        private System.Void ThreadSafeInitCall(System.Action call) { }
        private System.Void LoadOverwriteAsync(NodeCanvas.Framework.Internal.GraphLoadData data, System.Action callback) { }
        private System.Void LoadOverwrite(NodeCanvas.Framework.Internal.GraphLoadData data) { }
        private System.Void Initialize(UnityEngine.Component newAgent, NodeCanvas.Framework.IBlackboard newParentBlackboard, System.Boolean preInitializeSubGraphs) { }
        private System.Void PreInitializeSubGraphs() { }
        private System.Void StartGraph(UnityEngine.Component newAgent, NodeCanvas.Framework.IBlackboard newParentBlackboard, NodeCanvas.Framework.Graph.UpdateMode newUpdateMode, System.Action<System.Boolean> callback) { }
        private System.Void ClearGraphData() { }
        private System.Void Stop(System.Boolean success) { }
        private System.Void Pause() { }
        private System.Void Resume() { }
        private System.Void Restart() { }
        private System.Void UpdateGraph() { }
        private System.Void UpdateGraph(System.Single deltaTime) { }
        private System.Object OnDerivedDataSerialization() { }
        private System.Void OnDerivedDataDeserialization(System.Object data) { }
        private System.Void OnGraphInitialize() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphUpdate() { }
        private System.Void OnGraphStoped() { }
        private System.Void OnGraphPaused() { }
        private System.Void OnGraphUnpaused() { }
        private System.Void OnGraphObjectEnable() { }
        private System.Void OnGraphObjectDisable() { }
        private System.Void OnGraphObjectDestroy() { }
        private System.Void OnGraphValidate() { }
        private System.Void SendEvent(System.String name, System.Object value, System.Object sender) { }
        private System.Void SendEvent(System.String name, T value, System.Object sender) { }
        private System.Void SendGlobalEvent(System.String name, System.Object value, System.Object sender) { }
        private System.Void SendGlobalEvent(System.String name, T value, System.Object sender) { }
        private System.Collections.Generic.IEnumerable<NodeCanvas.Framework.BBParameter> GetAllParameters() { }
        private System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Connection> GetAllConnections() { }
        private System.Collections.Generic.IEnumerable<T> GetAllTasksOfType() { }
        private NodeCanvas.Framework.Node GetNodeWithID(System.Int32 searchID) { }
        private System.Collections.Generic.IEnumerable<T> GetAllNodesOfType() { }
        private T GetNodeWithTag(System.String tagName) { }
        private System.Collections.Generic.IEnumerable<T> GetNodesWithTag(System.String tagName) { }
        private System.Collections.Generic.IEnumerable<T> GetAllTagedNodes() { }
        private System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Node> GetRootNodes() { }
        private System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Node> GetLeafNodes() { }
        private System.Collections.Generic.IEnumerable<T> GetAllNestedGraphs(System.Boolean recursive) { }
        private System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Graph> GetAllInstancedNestedGraphs() { }
        private System.Collections.Generic.IEnumerable<NodeCanvas.Framework.BBParameter> GetDefinedParameters() { }
        private System.Void PromoteMissingParametersToVariables(NodeCanvas.Framework.IBlackboard bb) { }
        private NodeCanvas.Framework.Graph GetElementGraph(System.Object obj) { }
        private ParadoxNotion.HierarchyTree.Element GetFlatMetaGraph() { }
        private ParadoxNotion.HierarchyTree.Element GetFullMetaGraph() { }
        private ParadoxNotion.HierarchyTree.Element GetNestedMetaGraph() { }
        private System.Void DigNestedGraphs(NodeCanvas.Framework.Graph currentGraph, ParadoxNotion.HierarchyTree.Element currentElement) { }
        private ParadoxNotion.HierarchyTree.Element GetTreeNodeElement(NodeCanvas.Framework.Node node, System.Boolean recurse, System.Int32& lastID) { }
        private ParadoxNotion.HierarchyTree.Element CollectSubElements(NodeCanvas.Framework.IGraphElement obj) { }
        private NodeCanvas.Framework.IGraphElement GetTaskParentElement(NodeCanvas.Framework.Task targetTask) { }
        private NodeCanvas.Framework.IGraphElement GetParameterParentElement(NodeCanvas.Framework.BBParameter targetParameter) { }
        private System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Task> GetTasksInElement(NodeCanvas.Framework.IGraphElement target) { }
        private System.Collections.Generic.IEnumerable<NodeCanvas.Framework.BBParameter> GetParametersInElement(NodeCanvas.Framework.IGraphElement target) { }
        private T AddNode() { }
        private T AddNode(UnityEngine.Vector2 pos) { }
        private NodeCanvas.Framework.Node AddNode(System.Type nodeType) { }
        private NodeCanvas.Framework.Node AddNode(System.Type nodeType, UnityEngine.Vector2 pos) { }
        private System.Void RemoveNode(NodeCanvas.Framework.Node node, System.Boolean recordUndo, System.Boolean force) { }
        private NodeCanvas.Framework.Connection ConnectNodes(NodeCanvas.Framework.Node sourceNode, NodeCanvas.Framework.Node targetNode, System.Int32 sourceIndex, System.Int32 targetIndex) { }
        private System.Void RemoveConnection(NodeCanvas.Framework.Connection connection, System.Boolean recordUndo, System.Boolean invokeGraphChanged) { }
        private System.Collections.Generic.List<NodeCanvas.Framework.Node> CloneNodes(System.Collections.Generic.List<NodeCanvas.Framework.Node> originalNodes, NodeCanvas.Framework.Graph targetGraph, UnityEngine.Vector2 originPosition) { }
        private System.Void ClearGraph() { }
        private System.Void StartGraph(UnityEngine.Component newAgent, NodeCanvas.Framework.IBlackboard newBlackboard, System.Boolean autoUpdate, System.Action<System.Boolean> callback) { }
        private System.Void ProcessStringCompress(Beyond.StringCompressVisitor visitor) { }
        private System.Boolean CheckStringCompress() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000405
    public class GraphOwner : MonoBehaviour, ISerializationCallbackReceiver
    {
        // Fields
        protected System.Boolean isLazyLoadTriggered;        // 0x18
        private ParadoxNotion.Serialization.SerializationPair[] _serializedExposedParameters;        // 0x20
        private System.Collections.Generic.List<NodeCanvas.Framework.ExposedParameter> <exposedParameters>k__BackingField;        // 0x28
        public static System.Action<NodeCanvas.Framework.GraphOwner> onOwnerBehaviourStateChange;        // 0x0
        private System.Action onMonoBehaviourStart;        // 0x30
        private System.String _boundGraphSerialization;        // 0x38
        private System.Collections.Generic.List<UnityEngine.Object> _boundGraphObjectReferences;        // 0x40
        private NodeCanvas.Framework.Internal.GraphSource _boundGraphSource;        // 0x48
        private NodeCanvas.Framework.GraphOwner.FirstActivation _firstActivation;        // 0x50
        private NodeCanvas.Framework.GraphOwner.EnableAction _enableAction;        // 0x54
        private NodeCanvas.Framework.GraphOwner.DisableAction _disableAction;        // 0x58
        private System.Boolean _lockBoundGraphPrefabOverrides;        // 0x5C
        private System.Boolean _lockBoundGraphFromInstance;        // 0x5D
        private System.Boolean _preInitializeSubGraphs;        // 0x5E
        private NodeCanvas.Framework.Graph.UpdateMode _updateMode;        // 0x60
        protected System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> instances;        // 0x68
        private System.Boolean <initialized>k__BackingField;        // 0x70
        private System.Boolean <enableCalled>k__BackingField;        // 0x71
        private System.Boolean <startCalled>k__BackingField;        // 0x72

        // Methods
        private System.Collections.Generic.List<NodeCanvas.Framework.ExposedParameter> get_exposedParameters() { }
        private System.Void set_exposedParameters(System.Collections.Generic.List<NodeCanvas.Framework.ExposedParameter> value) { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void OnBeforeSerializeDoExtra() { }
        private System.Void OnAfterDeserializeDoExtra() { }
        private System.Void add_onMonoBehaviourStart(System.Action value) { }
        private System.Void remove_onMonoBehaviourStart(System.Action value) { }
        private NodeCanvas.Framework.Graph get_graph() { }
        private System.Void set_graph(NodeCanvas.Framework.Graph value) { }
        private NodeCanvas.Framework.IBlackboard get_blackboard() { }
        private System.Void set_blackboard(NodeCanvas.Framework.IBlackboard value) { }
        private System.Type get_graphType() { }
        private System.Boolean get_initialized() { }
        private System.Void set_initialized(System.Boolean value) { }
        private System.Boolean get_enableCalled() { }
        private System.Void set_enableCalled(System.Boolean value) { }
        private System.Boolean get_startCalled() { }
        private System.Void set_startCalled(System.Boolean value) { }
        private NodeCanvas.Framework.Internal.GraphSource get_boundGraphSource() { }
        private System.Void set_boundGraphSource(NodeCanvas.Framework.Internal.GraphSource value) { }
        private System.String get_boundGraphSerialization() { }
        private System.Void set_boundGraphSerialization(System.String value) { }
        private System.Collections.Generic.List<UnityEngine.Object> get_boundGraphObjectReferences() { }
        private System.Void set_boundGraphObjectReferences(System.Collections.Generic.List<UnityEngine.Object> value) { }
        private System.Boolean get_lockBoundGraphPrefabOverrides() { }
        private System.Void set_lockBoundGraphPrefabOverrides(System.Boolean value) { }
        private System.Boolean get_lockBoundGraphFromInstance() { }
        private System.Void set_lockBoundGraphFromInstance(System.Boolean value) { }
        private System.Boolean get_preInitializeSubGraphs() { }
        private System.Void set_preInitializeSubGraphs(System.Boolean value) { }
        private NodeCanvas.Framework.GraphOwner.FirstActivation get_firstActivation() { }
        private System.Void set_firstActivation(NodeCanvas.Framework.GraphOwner.FirstActivation value) { }
        private NodeCanvas.Framework.GraphOwner.EnableAction get_enableAction() { }
        private System.Void set_enableAction(NodeCanvas.Framework.GraphOwner.EnableAction value) { }
        private NodeCanvas.Framework.GraphOwner.DisableAction get_disableAction() { }
        private System.Void set_disableAction(NodeCanvas.Framework.GraphOwner.DisableAction value) { }
        private NodeCanvas.Framework.Graph.UpdateMode get_updateMode() { }
        private System.Void set_updateMode(NodeCanvas.Framework.Graph.UpdateMode value) { }
        private System.Boolean get_graphIsBound() { }
        private System.Boolean get_isRunning() { }
        private System.Boolean get_isPaused() { }
        private System.Single get_elapsedTime() { }
        private System.Boolean get_canEditNonPersistantBoundGraph() { }
        private NodeCanvas.Framework.Graph GetInstance(NodeCanvas.Framework.Graph originalGraph) { }
        private NodeCanvas.Framework.Graph MakeRuntimeGraphInstance() { }
        private System.Void StartBehaviour() { }
        private System.Void StartBehaviour(System.Action<System.Boolean> callback) { }
        private System.Void StartBehaviour(NodeCanvas.Framework.Graph.UpdateMode updateMode, System.Action<System.Boolean> callback) { }
        private System.Void PauseBehaviour() { }
        private System.Void StartBehaviourAsync(System.Action callBack) { }
        private System.Void GetInstanceAsync(NodeCanvas.Framework.Graph originalGraph, System.Action<NodeCanvas.Framework.Graph> callBack) { }
        private System.Void CreateSubInstanceAsync(System.Action callBack) { }
        private System.Void StopBehaviour(System.Boolean success) { }
        private System.Void UpdateBehaviour() { }
        private System.Void RestartBehaviour() { }
        private System.Void SendEvent(System.String eventName) { }
        private System.Void SendEvent(System.String eventName, System.Object value, System.Object sender) { }
        private System.Void SendEvent(System.String eventName, T eventValue, System.Object sender) { }
        private T GetExposedParameterValue(System.String name) { }
        private System.Void SetExposedParameterValue(System.String name, T value) { }
        private NodeCanvas.Framework.ExposedParameter MakeNewExposedParameter(System.String name) { }
        private System.Void Awake() { }
        private System.Void Initialize() { }
        private System.Void BindExposedParameters() { }
        private System.Void UnBindExposedParameters() { }
        private System.Void OnEnable() { }
        private System.Void Start() { }
        private System.Void InvokeStartEvent() { }
        private System.Void OnDisable() { }
        private System.Void DestroyInstance() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }
        private System.Void <Initialize>b__108_0() { }

    }

    // TypeToken: 0x2000411
    public class GraphOwner`1 : GraphOwner
    {
        // Fields
        private T _graph;        // 0x0
        private UnityEngine.Object _blackboard;        // 0x0

        // Methods
        private NodeCanvas.Framework.Graph get_graph() { }
        private System.Void set_graph(NodeCanvas.Framework.Graph value) { }
        private T get_behaviour() { }
        private System.Void set_behaviour(T value) { }
        private NodeCanvas.Framework.IBlackboard get_blackboard() { }
        private System.Void set_blackboard(NodeCanvas.Framework.IBlackboard value) { }
        private System.Type get_graphType() { }
        private System.Void StartBehaviour(T newGraph) { }
        private System.Void StartBehaviour(T newGraph, System.Action<System.Boolean> callback) { }
        private System.Void StartBehaviour(T newGraph, NodeCanvas.Framework.Graph.UpdateMode updateMode, System.Action<System.Boolean> callback) { }
        private System.Void SwitchBehaviour(T newGraph) { }
        private System.Void SwitchBehaviour(T newGraph, System.Action<System.Boolean> callback) { }
        private System.Void SwitchBehaviour(T newGraph, NodeCanvas.Framework.Graph.UpdateMode updateMode, System.Action<System.Boolean> callback) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000412
    public class IGraphAssignableExtensions
    {
        // Methods
        private NodeCanvas.Framework.Graph CheckInstance(NodeCanvas.Framework.IGraphAssignable assignable) { }
        private System.Boolean TryStartSubGraph(NodeCanvas.Framework.IGraphAssignable assignable, UnityEngine.Component agent, System.Action<System.Boolean> callback) { }
        private System.Boolean TryStopSubGraph(NodeCanvas.Framework.IGraphAssignable assignable) { }
        private System.Boolean TryClearSubGraphData(NodeCanvas.Framework.IGraphAssignable assignable) { }
        private System.Boolean TryPauseSubGraph(NodeCanvas.Framework.IGraphAssignable assignable) { }
        private System.Boolean TryResumeSubGraph(NodeCanvas.Framework.IGraphAssignable assignable) { }
        private System.Boolean TryUpdateSubGraph(NodeCanvas.Framework.IGraphAssignable assignable) { }
        private System.Void TryWriteAndBindMappedVariables(NodeCanvas.Framework.IGraphAssignable assignable) { }
        private System.Void TryReadAndUnbindMappedVariables(NodeCanvas.Framework.IGraphAssignable assignable) { }
        private System.Void ValidateSubGraphAndParameters(NodeCanvas.Framework.IGraphAssignable assignable) { }

    }

    // TypeToken: 0x2000414
    public interface IGraphElement
    {
        // Methods
        private System.String get_name() { }
        private System.String get_UID() { }
        private NodeCanvas.Framework.Graph get_graph() { }
        private NodeCanvas.Framework.Status get_status() { }

    }

    // TypeToken: 0x2000415
    public interface IUpdatable : IGraphElement
    {
        // Methods
        private System.Void Update() { }

    }

    // TypeToken: 0x2000416
    public interface IInvokable : IGraphElement
    {
        // Methods
        private System.String GetInvocationID() { }
        private System.Object Invoke(System.Object[] args) { }
        private System.Void InvokeAsync(System.Action<System.Object> callback, System.Object[] args) { }

    }

    // TypeToken: 0x2000417
    public interface IGraphAssignable : IGraphElement
    {
        // Methods
        private NodeCanvas.Framework.Graph get_subGraph() { }
        private System.Void set_subGraph(NodeCanvas.Framework.Graph value) { }
        private NodeCanvas.Framework.Graph get_currentInstance() { }
        private System.Void set_currentInstance(NodeCanvas.Framework.Graph value) { }
        private System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> get_instances() { }
        private System.Void set_instances(System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> get_variablesMap() { }
        private System.Void set_variablesMap(System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> value) { }

    }

    // TypeToken: 0x2000418
    public interface IGraphAssignable`1 : IGraphAssignable, IGraphElement
    {
        // Methods
        private T get_subGraph() { }
        private System.Void set_subGraph(T value) { }
        private T get_currentInstance() { }
        private System.Void set_currentInstance(T value) { }

    }

    // TypeToken: 0x2000419
    public interface ITaskAssignable : IGraphElement
    {
        // Methods
        private NodeCanvas.Framework.Task get_task() { }
        private System.Void set_task(NodeCanvas.Framework.Task value) { }

    }

    // TypeToken: 0x200041A
    public interface ITaskAssignable`1 : ITaskAssignable, IGraphElement
    {
    }

    // TypeToken: 0x200041B
    public interface IHaveNodeReference : IGraphElement
    {
        // Methods
        private NodeCanvas.Framework.INodeReference get_targetReference() { }

    }

    // TypeToken: 0x200041C
    public interface IReflectedWrapper
    {
        // Methods
        private ParadoxNotion.Serialization.ISerializedReflectedInfo GetSerializedInfo() { }

    }

    // TypeToken: 0x200041D
    public interface ISubTasksContainer
    {
        // Methods
        private NodeCanvas.Framework.Task[] GetSubTasks() { }

    }

    // TypeToken: 0x200041E
    public interface ISubParametersContainer
    {
        // Methods
        private NodeCanvas.Framework.BBParameter[] GetSubParameters() { }

    }

    // TypeToken: 0x200041F
    public class Node, IGraphElement, ISerializationCollectable
    {
        // Fields
        public System.Single additionalWidth;        // 0x10
        private System.String _UID;        // 0x18
        private System.String _name;        // 0x20
        private System.String _tag;        // 0x28
        private UnityEngine.Vector2 _position;        // 0x30
        private System.String _comment;        // 0x38
        private System.Boolean _isBreakpoint;        // 0x40
        private NodeCanvas.Framework.Graph _graph;        // 0x48
        private System.Int32 _ID;        // 0x50
        private System.Collections.Generic.List<NodeCanvas.Framework.Connection> _inConnections;        // 0x58
        private System.Collections.Generic.List<NodeCanvas.Framework.Connection> _outConnections;        // 0x60
        private NodeCanvas.Framework.Status _status;        // 0x68
        private System.String _nameCache;        // 0x70
        private System.String _descriptionCache;        // 0x78
        private System.Int32 _priorityCache;        // 0x80
        private readonly System.Boolean <allowResizeHorizontal>k__BackingField;        // 0x84
        private System.Boolean <canResizeHorizontal>k__BackingField;        // 0x85
        private System.Boolean <resizingHorizontal>k__BackingField;        // 0x86
        private System.Boolean <isHighlight>k__BackingField;        // 0x87
        public System.Single highlightColorFade;        // 0x88
        private System.Single <timeStarted>k__BackingField;        // 0x8C
        private System.Boolean <isChecked>k__BackingField;        // 0x90
        private System.Boolean <breakPointReached>k__BackingField;        // 0x91

        // Methods
        private System.Nullable<System.Single> get_overrideNodeWidth() { }
        private NodeCanvas.Framework.Graph get_graph() { }
        private System.Void set_graph(NodeCanvas.Framework.Graph value) { }
        private System.Int32 get_ID() { }
        private System.Void set_ID(System.Int32 value) { }
        private System.String get_UID() { }
        private System.String AllocateUID() { }
        private System.Collections.Generic.List<NodeCanvas.Framework.Connection> get_inConnections() { }
        private System.Void set_inConnections(System.Collections.Generic.List<NodeCanvas.Framework.Connection> value) { }
        private System.Collections.Generic.List<NodeCanvas.Framework.Connection> get_outConnections() { }
        private System.Void set_outConnections(System.Collections.Generic.List<NodeCanvas.Framework.Connection> value) { }
        private UnityEngine.Vector2 get_position() { }
        private System.Void set_position(UnityEngine.Vector2 value) { }
        private System.String get_customName() { }
        private System.Void set_customName(System.String value) { }
        private System.String get_tag() { }
        private System.Void set_tag(System.String value) { }
        private System.String get_comments() { }
        private System.Void set_comments(System.String value) { }
        private System.String get_commentForShow() { }
        private System.String get_rawComment() { }
        private System.Boolean get_modifyComment() { }
        private System.String get_modifiedComment() { }
        private System.Boolean get_isBreakpoint() { }
        private System.Void set_isBreakpoint(System.Boolean value) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.String get_description() { }
        private System.Int32 get_priority() { }
        private System.Int32 get_maxInConnections() { }
        private System.Int32 get_maxOutConnections() { }
        private System.Type get_outConnectionType() { }
        private System.Boolean get_allowAsPrime() { }
        private System.Boolean get_canSelfConnect() { }
        private ParadoxNotion.Alignment2x2 get_commentsAlignment() { }
        private ParadoxNotion.Alignment2x2 get_iconAlignment() { }
        private System.Boolean get_isBeyondGraph() { }
        private System.Boolean get_drawInspector() { }
        private System.Boolean get_inspectorShowTag() { }
        private System.Boolean get_allowResizeHorizontal() { }
        private System.Boolean get_canResizeHorizontal() { }
        private System.Void set_canResizeHorizontal(System.Boolean value) { }
        private System.Boolean get_resizingHorizontal() { }
        private System.Void set_resizingHorizontal(System.Boolean value) { }
        private System.Boolean get_allowDragInContentRect() { }
        private System.String get_nodeIconKey() { }
        private System.String get_nodeIconKey2() { }
        private System.String get_nodeIconKey3() { }
        private System.Boolean get_isHighlight() { }
        private System.Void set_isHighlight(System.Boolean value) { }
        private System.Boolean get_drawNameTagOrComment() { }
        private NodeCanvas.Framework.Status get_status() { }
        private System.Void set_status(NodeCanvas.Framework.Status value) { }
        private UnityEngine.Component get_graphAgent() { }
        private NodeCanvas.Framework.IBlackboard get_graphBlackboard() { }
        private System.Single get_elapsedTime() { }
        private System.Single get_timeStarted() { }
        private System.Void set_timeStarted(System.Single value) { }
        private System.Boolean get_isChecked() { }
        private System.Void set_isChecked(System.Boolean value) { }
        private System.Boolean get_breakPointReached() { }
        private System.Void set_breakPointReached(System.Boolean value) { }
        private System.Void .ctor() { }
        private NodeCanvas.Framework.Node Create(NodeCanvas.Framework.Graph targetGraph, System.Type nodeType, UnityEngine.Vector2 pos) { }
        private NodeCanvas.Framework.Node Duplicate(NodeCanvas.Framework.Graph targetGraph) { }
        private System.Void Validate(NodeCanvas.Framework.Graph assignedGraph) { }
        private NodeCanvas.Framework.Status Execute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void Reset(System.Boolean recursively) { }
        private System.Collections.IEnumerator YieldBreak(System.Action resume) { }
        private NodeCanvas.Framework.Status Error(System.Object msg) { }
        private NodeCanvas.Framework.Status Fail(System.String msg) { }
        private System.Void Warn(System.String msg) { }
        private System.Void SetStatus(NodeCanvas.Framework.Status status) { }
        private System.Void SendEvent(System.String eventName) { }
        private System.Void SendEvent(System.String eventName, T value) { }
        private System.Boolean IsNewConnectionAllowed(NodeCanvas.Framework.Node sourceNode, NodeCanvas.Framework.Node targetNode, NodeCanvas.Framework.Connection refConnection) { }
        private System.Boolean CanConnectToTarget(NodeCanvas.Framework.Node targetNode) { }
        private System.Boolean CanConnectFromSource(NodeCanvas.Framework.Node sourceNode) { }
        private System.Boolean AreNodesConnected(NodeCanvas.Framework.Node a, NodeCanvas.Framework.Node b) { }
        private UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine) { }
        private System.Void StopCoroutine(UnityEngine.Coroutine routine) { }
        private System.Void StartParallelTask(System.Action action) { }
        private System.Void StopParallelTask(System.Action action) { }
        private System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Node> GetParentNodes() { }
        private System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Node> GetChildNodes() { }
        private System.Boolean IsChildOf(NodeCanvas.Framework.Node parentNode) { }
        private System.Boolean IsParentOf(NodeCanvas.Framework.Node childNode) { }
        private System.String GetWarningOrError() { }
        private System.String GetHardError() { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void OnReset() { }
        private System.Void OnCreate(NodeCanvas.Framework.Graph assignedGraph) { }
        private System.Void OnDuplicate(NodeCanvas.Framework.Graph assignedGraph) { }
        private System.Void OnValidate(NodeCanvas.Framework.Graph assignedGraph) { }
        private System.Void OnDestroy() { }
        private System.Void OnParentConnected(System.Int32 connectionIndex) { }
        private System.Void OnParentDisconnected(System.Int32 connectionIndex) { }
        private System.Void OnChildConnected(System.Int32 connectionIndex) { }
        private System.Void OnChildDisconnected(System.Int32 connectionIndex) { }
        private System.Void OnChildrenConnectionsSorted(System.Int32[] oldIndeces) { }
        private System.Void OnGraphStarted() { }
        private System.Void OnPostGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void OnPostGraphStoped() { }
        private System.Void OnGraphPaused() { }
        private System.Void OnGraphUnpaused() { }
        private System.Void OnClearNodeData() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000426
    public interface INodeReference
    {
        // Methods
        private System.Type get_type() { }
        private NodeCanvas.Framework.Node Get(NodeCanvas.Framework.Graph graph) { }
        private System.Void Set(NodeCanvas.Framework.Node target) { }

    }

    // TypeToken: 0x2000427
    public class NodeReference`1, INodeReference
    {
        // Fields
        private System.String _targetNodeUID;        // 0x0
        private System.WeakReference<T> _targetNodeRef;        // 0x0

        // Methods
        private System.Type NodeCanvas.Framework.INodeReference.get_type() { }
        private NodeCanvas.Framework.Node NodeCanvas.Framework.INodeReference.Get(NodeCanvas.Framework.Graph graph) { }
        private System.Void NodeCanvas.Framework.INodeReference.Set(NodeCanvas.Framework.Node target) { }
        private System.Void .ctor() { }
        private System.Void .ctor(T target) { }
        private T Get(NodeCanvas.Framework.Graph graph) { }
        private System.Void Set(T target) { }

    }

    // TypeToken: 0x2000429
    public struct Status
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static NodeCanvas.Framework.Status Failure;        // 0x0
        public static NodeCanvas.Framework.Status Success;        // 0x0
        public static NodeCanvas.Framework.Status Running;        // 0x0
        public static NodeCanvas.Framework.Status Resting;        // 0x0
        public static NodeCanvas.Framework.Status Error;        // 0x0
        public static NodeCanvas.Framework.Status Optional;        // 0x0

    }

    // TypeToken: 0x200042A
    public class ActionList : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.ActionList.ActionsExecutionMode executionMode;        // 0x68
        public System.Collections.Generic.List<NodeCanvas.Framework.ActionTask> actions;        // 0x70
        private System.Int32 currentActionIndex;        // 0x78
        private System.Boolean[] finishedIndeces;        // 0x80

        // Methods
        private System.String get_info() { }
        private NodeCanvas.Framework.Task Duplicate(NodeCanvas.Framework.ITaskSystem newOwnerSystem) { }
        private System.String OnInit() { }
        private System.Void OnExecute() { }
        private System.Void OnUpdate() { }
        private System.Void OnStop() { }
        private System.Void OnPause() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void AddAction(NodeCanvas.Framework.ActionTask action) { }
        private System.String GetWarningOrError() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200042C
    public class ActionTask`1 : ActionTask
    {
        // Methods
        private System.Type get_agentType() { }
        private T get_agent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200042D
    public class ActionTask : Task
    {
        // Fields
        private NodeCanvas.Framework.Status status;        // 0x58
        private System.Single timeStarted;        // 0x5C
        private System.Boolean latch;        // 0x60
        private System.Boolean <isPaused>k__BackingField;        // 0x61

        // Methods
        private System.Single get_elapsedTime() { }
        private System.Boolean get_isRunning() { }
        private System.Boolean get_isPaused() { }
        private System.Void set_isPaused(System.Boolean value) { }
        private System.Void ExecuteIndependent(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard, System.Action<NodeCanvas.Framework.Status> callback) { }
        private System.Collections.IEnumerator IndependentActionUpdater(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard, System.Action<NodeCanvas.Framework.Status> callback) { }
        private NodeCanvas.Framework.Status ExecuteAction(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private NodeCanvas.Framework.Status Execute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void EndAction() { }
        private System.Void EndAction(System.Boolean success) { }
        private System.Void EndAction(System.Nullable<System.Boolean> success) { }
        private System.Void Pause() { }
        private System.Void OnExecute() { }
        private System.Void OnUpdate() { }
        private System.Void OnStop(System.Boolean interrupted) { }
        private System.Void OnStop() { }
        private System.Void OnPause() { }
        private System.Void OnResume() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200042F
    public class ConditionList : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.ConditionList.ConditionsCheckMode checkMode;        // 0x68
        public System.Collections.Generic.List<NodeCanvas.Framework.ConditionTask> conditions;        // 0x70

        // Methods
        private System.Boolean get_allTrueRequired() { }
        private System.String get_info() { }
        private NodeCanvas.Framework.Task Duplicate(NodeCanvas.Framework.ITaskSystem newOwnerSystem) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Boolean OnCheck() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void AddCondition(NodeCanvas.Framework.ConditionTask condition) { }
        private System.String GetWarningOrError() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000431
    public class ConditionTask`1 : ConditionTask
    {
        // Methods
        private System.Type get_agentType() { }
        private T get_agent() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000432
    public class ConditionTask : Task
    {
        // Fields
        private System.Boolean _invert;        // 0x58
        private System.Int32 yieldReturn;        // 0x5C
        private System.Int32 yields;        // 0x60
        private System.Boolean isRuntimeEnabled;        // 0x64

        // Methods
        private System.Boolean get_invert() { }
        private System.Void set_invert(System.Boolean value) { }
        private System.Void Enable(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb) { }
        private System.Void Disable() { }
        private System.Boolean CheckCondition(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Boolean Check(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Boolean CheckOnce(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void YieldReturn(System.Boolean value, System.Boolean keepValueUntilUsed) { }
        private System.Collections.IEnumerator Flip() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000434
    public class EventReceiverAttribute : Attribute
    {
        // Fields
        public readonly System.String[] eventMessages;        // 0x10

        // Methods
        private System.Void .ctor(System.String[] args) { }

    }

    // TypeToken: 0x2000435
    public interface ITaskSystem
    {
        // Methods
        private UnityEngine.Component get_agent() { }
        private NodeCanvas.Framework.IBlackboard get_blackboard() { }
        private UnityEngine.Object get_contextObject() { }
        private System.Single get_elapsedTime() { }
        private System.Single get_deltaTime() { }
        private System.Void UpdateTasksOwner() { }
        private System.Void SendEvent(System.String name, System.Object value, System.Object sender) { }
        private System.Void SendEvent(System.String name, T value, System.Object sender) { }

    }

    // TypeToken: 0x2000436
    public class Task, ISerializationCollectable, ISerializationCallbackReceiver
    {
        // Fields
        private System.Boolean _isUserDisabled;        // 0x10
        protected internal NodeCanvas.Framework.Internal.TaskAgentParameter _agentParameter;        // 0x18
        private NodeCanvas.Framework.ITaskSystem _ownerSystem;        // 0x20
        private UnityEngine.Component _currentAgent;        // 0x28
        private System.String _taskName;        // 0x30
        private System.String _taskDescription;        // 0x38
        private System.String _obsoleteInfo;        // 0x40
        private System.Boolean _isRuntimeActive;        // 0x48
        private System.Boolean _isInitSuccess;        // 0x49
        private ParadoxNotion.Services.EventRouter _eventRouter;        // 0x50

        // Methods
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void .ctor() { }
        private T Create(NodeCanvas.Framework.ITaskSystem newOwnerSystem) { }
        private NodeCanvas.Framework.Task Create(System.Type type, NodeCanvas.Framework.ITaskSystem newOwnerSystem) { }
        private NodeCanvas.Framework.Task Duplicate(NodeCanvas.Framework.ITaskSystem newOwnerSystem) { }
        private System.Void Validate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.Void SetOwnerSystem(NodeCanvas.Framework.ITaskSystem newOwnerSystem) { }
        private NodeCanvas.Framework.ITaskSystem get_ownerSystem() { }
        private System.Void set_ownerSystem(NodeCanvas.Framework.ITaskSystem value) { }
        private UnityEngine.Component get_ownerSystemAgent() { }
        private NodeCanvas.Framework.IBlackboard get_ownerSystemBlackboard() { }
        private System.Single get_ownerSystemElapsedTime() { }
        private System.Boolean get_isUserEnabled() { }
        private System.Void set_isUserEnabled(System.Boolean value) { }
        private System.String get_obsolete() { }
        private System.String get_name() { }
        private System.String get_description() { }
        private System.String get_summaryInfo() { }
        private System.String get_info() { }
        private System.Type get_agentType() { }
        private System.String get_agentInfo() { }
        private System.String get_agentParameterName() { }
        private System.Boolean get_agentIsOverride() { }
        private System.Void set_agentIsOverride(System.Boolean value) { }
        private UnityEngine.Component get_agent() { }
        private NodeCanvas.Framework.IBlackboard get_blackboard() { }
        private ParadoxNotion.Services.EventRouter get_router() { }
        private System.Boolean Set(UnityEngine.Component newAgent, NodeCanvas.Framework.IBlackboard newBB) { }
        private System.Boolean Initialize(UnityEngine.Component newAgent) { }
        private System.Boolean InitializeFieldAttributes(UnityEngine.Component newAgent) { }
        private System.Boolean Error(System.String error, System.String tag) { }
        private UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine) { }
        private System.Void StopCoroutine(UnityEngine.Coroutine routine) { }
        private System.Void SendEvent(System.String name) { }
        private System.Void SendEvent(System.String name, T value) { }
        private System.String GetWarningOrError() { }
        private System.String OnErrorCheck() { }
        private System.String GetHardError() { }
        private System.String OnInit() { }
        private System.Void OnCreate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.Void OnDrawGizmos() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void ClearTaskData() { }
        private System.Void OnClearTaskData() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000438
    public class AssetBlackboard : ScriptableObject, ISerializationCallbackReceiver, IGlobalBlackboard, IBlackboard
    {
        // Fields
        private System.Action<NodeCanvas.Framework.Variable> onVariableAdded;        // 0x18
        private System.Action<NodeCanvas.Framework.Variable> onVariableRemoved;        // 0x20
        private System.String _serializedBlackboard;        // 0x28
        private System.Collections.Generic.List<UnityEngine.Object> _objectReferences;        // 0x30
        private System.String _UID;        // 0x38
        private System.String _identifier;        // 0x40
        private NodeCanvas.Framework.Internal.BlackboardSource _blackboard;        // 0x48

        // Methods
        private System.Void add_onVariableAdded(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.Void remove_onVariableAdded(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.Void add_onVariableRemoved(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.Void remove_onVariableRemoved(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void SelfSerialize() { }
        private System.Void SelfDeserialize() { }
        private System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> NodeCanvas.Framework.IBlackboard.get_variables() { }
        private System.Void NodeCanvas.Framework.IBlackboard.set_variables(System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> value) { }
        private UnityEngine.Object NodeCanvas.Framework.IBlackboard.get_unityContextObject() { }
        private NodeCanvas.Framework.IBlackboard NodeCanvas.Framework.IBlackboard.get_parent() { }
        private UnityEngine.Component NodeCanvas.Framework.IBlackboard.get_propertiesBindTarget() { }
        private System.String NodeCanvas.Framework.IBlackboard.get_independantVariablesFieldName() { }
        private System.Void NodeCanvas.Framework.IBlackboard.TryInvokeOnVariableAdded(NodeCanvas.Framework.Variable variable) { }
        private System.Void NodeCanvas.Framework.IBlackboard.TryInvokeOnVariableRemoved(NodeCanvas.Framework.Variable variable) { }
        private System.String get_identifier() { }
        private System.String get_UID() { }
        private System.Void ShowJson() { }
        private System.String ToString() { }
        private System.Void OnValidate() { }
        private System.Void OnEnable() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000439
    public class BBParameter, ISerializationCollectable, ISerializationCallbackReceiver
    {
        // Fields
        private System.String _name;        // 0x10
        private System.String _targetVariableID;        // 0x18
        private NodeCanvas.Framework.IBlackboard _bb;        // 0x20
        private NodeCanvas.Framework.Variable _varRef;        // 0x28
        private System.Action<NodeCanvas.Framework.Variable> onVariableReferenceChanged;        // 0x30

        // Methods
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void add_onVariableReferenceChanged(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.Void remove_onVariableReferenceChanged(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.Void .ctor() { }
        private NodeCanvas.Framework.BBParameter CreateInstance(System.Type t, NodeCanvas.Framework.IBlackboard bb) { }
        private System.Void SetBBFields(System.Object target, NodeCanvas.Framework.IBlackboard bb) { }
        private System.String get_targetVariableID() { }
        private System.Void set_targetVariableID(System.String value) { }
        private NodeCanvas.Framework.Variable get_varRef() { }
        private System.Void set_varRef(NodeCanvas.Framework.Variable value) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private NodeCanvas.Framework.IBlackboard get_bb() { }
        private System.Void set_bb(NodeCanvas.Framework.IBlackboard value) { }
        private System.Boolean get_useBlackboard() { }
        private System.Void set_useBlackboard(System.Boolean value) { }
        private System.Boolean get_isPresumedDynamic() { }
        private System.Boolean get_isNone() { }
        private System.Boolean get_isNull() { }
        private System.Boolean get_isNoneOrNull() { }
        private System.Boolean get_isDefined() { }
        private System.Type get_refType() { }
        private System.Object get_value() { }
        private System.Void set_value(System.Object value) { }
        private System.Type get_varType() { }
        private System.Void SetDefaultValue() { }
        private System.Void Bind(NodeCanvas.Framework.Variable data) { }
        private System.Object GetValueBoxed() { }
        private System.Void SetValueBoxed(System.Object value) { }
        private System.Void SetTargetVariable(NodeCanvas.Framework.IBlackboard targetBB, NodeCanvas.Framework.Variable targetVariable) { }
        private NodeCanvas.Framework.Variable ResolveReference(NodeCanvas.Framework.IBlackboard targetBlackboard, System.Boolean useID) { }
        private NodeCanvas.Framework.Variable PromoteToVariable(NodeCanvas.Framework.IBlackboard targetBB) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200043B
    public class BBParameter`1 : BBParameter
    {
        // Fields
        protected T _value;        // 0x0
        private System.Func<T> getter;        // 0x0
        private System.Action<T> setter;        // 0x0

        // Methods
        private System.Void add_getter(System.Func<T> value) { }
        private System.Void remove_getter(System.Func<T> value) { }
        private System.Void add_setter(System.Action<T> value) { }
        private System.Void remove_setter(System.Action<T> value) { }
        private T get_value() { }
        private System.Void set_value(T value) { }
        private System.Type get_varType() { }
        private System.Void .ctor() { }
        private System.Void .ctor(T value) { }
        private System.Object GetValueBoxed() { }
        private System.Void SetValueBoxed(System.Object newValue) { }
        private T GetValue() { }
        private System.Void SetValue(T value) { }
        private System.Void SetDefaultValue() { }
        private System.Void Bind(NodeCanvas.Framework.Variable variable) { }
        private System.Boolean BindGetter(NodeCanvas.Framework.Variable variable) { }
        private System.Boolean BindSetter(NodeCanvas.Framework.Variable variable) { }
        private NodeCanvas.Framework.BBParameter<T> op_Implicit(T value) { }

    }

    // TypeToken: 0x200043F
    public class Blackboard : MonoBehaviour, ISerializationCallbackReceiver, IBlackboard
    {
        // Fields
        private NodeCanvas.Framework.AssetBlackboard _parentBlackboard;        // 0x18
        private System.String _serializedBlackboard;        // 0x20
        private System.Collections.Generic.List<UnityEngine.Object> _objectReferences;        // 0x28
        private ParadoxNotion.Serialization.SerializationPair[] _serializedVariables;        // 0x30
        private NodeCanvas.Framework.Internal.BlackboardSource _blackboard;        // 0x38
        private System.Boolean haltForUndo;        // 0x40
        private System.String _identifier;        // 0x48
        private System.Action<NodeCanvas.Framework.Variable> onVariableAdded;        // 0x50
        private System.Action<NodeCanvas.Framework.Variable> onVariableRemoved;        // 0x58

        // Methods
        private NodeCanvas.Framework.Internal.BlackboardSource get_blackboard() { }
        private NodeCanvas.Framework.AssetBlackboard get_parentBlackboard() { }
        private System.Void SetParentBlackboard(NodeCanvas.Framework.AssetBlackboard bb) { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void SelfSerialize() { }
        private System.Void SelfDeserialize() { }
        private System.String Serialize(System.Collections.Generic.List<UnityEngine.Object> references, System.Boolean pretyJson) { }
        private System.Boolean Deserialize(System.String json, System.Collections.Generic.List<UnityEngine.Object> references, System.Boolean removeMissingVariables) { }
        private System.Void add_onVariableAdded(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.Void remove_onVariableAdded(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.Void add_onVariableRemoved(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.Void remove_onVariableRemoved(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.String NodeCanvas.Framework.IBlackboard.get_identifier() { }
        private System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> NodeCanvas.Framework.IBlackboard.get_variables() { }
        private System.Void NodeCanvas.Framework.IBlackboard.set_variables(System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> value) { }
        private UnityEngine.Component NodeCanvas.Framework.IBlackboard.get_propertiesBindTarget() { }
        private UnityEngine.Object NodeCanvas.Framework.IBlackboard.get_unityContextObject() { }
        private NodeCanvas.Framework.IBlackboard NodeCanvas.Framework.IBlackboard.get_parent() { }
        private System.String NodeCanvas.Framework.IBlackboard.get_independantVariablesFieldName() { }
        private System.Void NodeCanvas.Framework.IBlackboard.TryInvokeOnVariableAdded(NodeCanvas.Framework.Variable variable) { }
        private System.Void NodeCanvas.Framework.IBlackboard.TryInvokeOnVariableRemoved(NodeCanvas.Framework.Variable variable) { }
        private System.Void Awake() { }
        private NodeCanvas.Framework.Variable AddVariable(System.String name, System.Type type) { }
        private NodeCanvas.Framework.Variable AddVariable(System.String name, System.Object value) { }
        private NodeCanvas.Framework.Variable RemoveVariable(System.String name) { }
        private NodeCanvas.Framework.Variable GetVariable(System.String name, System.Type ofType) { }
        private NodeCanvas.Framework.Variable GetVariableByID(System.String ID) { }
        private NodeCanvas.Framework.Variable<T> GetVariable(System.String name) { }
        private T GetVariableValue(System.String name) { }
        private NodeCanvas.Framework.Variable SetVariableValue(System.String name, System.Object value) { }
        private T GetValue(System.String name) { }
        private NodeCanvas.Framework.Variable SetValue(System.String name, System.Object value) { }
        private System.Void ShowJson() { }
        private System.String Save() { }
        private System.String Save(System.String saveKey) { }
        private System.Boolean Load() { }
        private System.Boolean Load(System.String saveKey) { }
        private System.Void OnValidate() { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000440
    public class GlobalBlackboard : Blackboard, IGlobalBlackboard, IBlackboard
    {
        // Fields
        private System.String _UID;        // 0x60
        private System.String _identifier;        // 0x68
        private NodeCanvas.Framework.GlobalBlackboard.SingletonMode _singletonMode;        // 0x70
        private System.Boolean _dontDestroyOnLoad;        // 0x74
        private static System.Collections.Generic.List<NodeCanvas.Framework.GlobalBlackboard> _allGlobals;        // 0x0

        // Methods
        private System.String get_identifier() { }
        private System.String get_UID() { }
        private System.String get_name() { }
        private System.Collections.Generic.IEnumerable<NodeCanvas.Framework.GlobalBlackboard> GetAll() { }
        private NodeCanvas.Framework.GlobalBlackboard Create() { }
        private NodeCanvas.Framework.GlobalBlackboard Find(System.String name) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnValidate() { }
        private System.String ToString() { }
        private System.Boolean IsPrefabAsset() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000443
    public interface IBlackboard
    {
        // Methods
        private System.Void add_onVariableAdded(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.Void remove_onVariableAdded(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.Void add_onVariableRemoved(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.Void remove_onVariableRemoved(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.String get_identifier() { }
        private NodeCanvas.Framework.IBlackboard get_parent() { }
        private System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> get_variables() { }
        private System.Void set_variables(System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> value) { }
        private UnityEngine.Component get_propertiesBindTarget() { }
        private UnityEngine.Object get_unityContextObject() { }
        private System.String get_independantVariablesFieldName() { }
        private System.Void TryInvokeOnVariableAdded(NodeCanvas.Framework.Variable variable) { }
        private System.Void TryInvokeOnVariableRemoved(NodeCanvas.Framework.Variable variable) { }

    }

    // TypeToken: 0x2000444
    public interface IGlobalBlackboard : IBlackboard
    {
        // Methods
        private System.String get_UID() { }

    }

    // TypeToken: 0x2000445
    public class IBlackboardExtensions
    {
        // Methods
        private NodeCanvas.Framework.IBlackboard GetRoot(NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Collections.Generic.IEnumerable<NodeCanvas.Framework.IBlackboard> GetAllParents(NodeCanvas.Framework.IBlackboard blackboard, System.Boolean includeSelf) { }
        private System.Boolean IsPartOf(NodeCanvas.Framework.IBlackboard blackboard, NodeCanvas.Framework.IBlackboard child) { }
        private NodeCanvas.Framework.Variable<T> AddVariable(NodeCanvas.Framework.IBlackboard blackboard, System.String varName, T value) { }
        private NodeCanvas.Framework.Variable<T> AddVariable(NodeCanvas.Framework.IBlackboard blackboard, System.String varName) { }
        private NodeCanvas.Framework.Variable AddVariable(NodeCanvas.Framework.IBlackboard blackboard, System.String varName, System.Object value) { }
        private NodeCanvas.Framework.Variable AddVariable(NodeCanvas.Framework.IBlackboard blackboard, System.String varName, System.Type type) { }
        private NodeCanvas.Framework.Variable RemoveVariable(NodeCanvas.Framework.IBlackboard blackboard, System.String varName) { }
        private T GetVariableValue(NodeCanvas.Framework.IBlackboard blackboard, System.String varName) { }
        private NodeCanvas.Framework.Variable SetVariableValue(NodeCanvas.Framework.IBlackboard blackboard, System.String varName, System.Object value) { }
        private System.Void InitializePropertiesBinding(NodeCanvas.Framework.IBlackboard blackboard, UnityEngine.Component target, System.Boolean callSetter) { }
        private NodeCanvas.Framework.Variable<T> GetVariable(NodeCanvas.Framework.IBlackboard blackboard, System.String varName) { }
        private NodeCanvas.Framework.Variable GetVariable(NodeCanvas.Framework.IBlackboard blackboard, System.String varName, System.Type ofType) { }
        private NodeCanvas.Framework.Variable GetVariableByID(NodeCanvas.Framework.IBlackboard blackboard, System.String ID) { }
        private System.Collections.Generic.IEnumerable<NodeCanvas.Framework.Variable> GetVariables(NodeCanvas.Framework.IBlackboard blackboard, System.Type ofType) { }
        private NodeCanvas.Framework.Variable ChangeVariableType(NodeCanvas.Framework.IBlackboard blackboard, NodeCanvas.Framework.Variable target, System.Type newType) { }
        private System.Void OverwriteFrom(NodeCanvas.Framework.IBlackboard blackboard, NodeCanvas.Framework.IBlackboard sourceBlackboard, System.Boolean removeMissingVariables) { }

    }

    // TypeToken: 0x2000448
    public class BlackboardHelpers
    {
        // Fields
        private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Type> s_variableTypeCache;        // 0x0

        // Methods
        private System.Type CreateVariableType(System.Type valueType) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200044A
    public class Variable
    {
        // Fields
        private System.String _name;        // 0x10
        private System.String _id;        // 0x18
        private System.Boolean _isPublic;        // 0x20
        private System.Boolean _debugBoundValue;        // 0x21
        private System.Action<System.String> onNameChanged;        // 0x28
        private System.Action<System.Object> onValueChanged;        // 0x30
        private System.Action onDestroy;        // 0x38

        // Methods
        private System.Void add_onNameChanged(System.Action<System.String> value) { }
        private System.Void remove_onNameChanged(System.Action<System.String> value) { }
        private System.Void add_onValueChanged(System.Action<System.Object> value) { }
        private System.Void remove_onValueChanged(System.Action<System.Object> value) { }
        private System.Void add_onDestroy(System.Action value) { }
        private System.Void remove_onDestroy(System.Action value) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.String get_ID() { }
        private System.Object get_value() { }
        private System.Void set_value(System.Object value) { }
        private System.Boolean get_isExposedPublic() { }
        private System.Void set_isExposedPublic(System.Boolean value) { }
        private System.Boolean get_debugBoundValue() { }
        private System.Void set_debugBoundValue(System.Boolean value) { }
        private System.Boolean get_isPropertyBound() { }
        private System.Boolean get_isDataBound() { }
        private System.Type get_varType() { }
        private System.String get_propertyPath() { }
        private System.Void set_propertyPath(System.String value) { }
        private System.Void BindProperty(System.Reflection.MemberInfo prop, UnityEngine.GameObject target) { }
        private System.Void UnBind() { }
        private System.Void InitializePropertyBinding(UnityEngine.GameObject go, System.Boolean callSetter) { }
        private System.Object GetValueBoxed() { }
        private System.Void SetValueBoxed(System.Object value) { }
        private System.Void ResetDefaultValue() { }
        private System.Void RecordDefaultValue() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name, System.String ID) { }
        private System.Void OnDestroy() { }
        private NodeCanvas.Framework.Variable Duplicate(NodeCanvas.Framework.IBlackboard targetBB) { }
        private System.Boolean HasValueChangeEvent() { }
        private System.Void TryInvokeValueChangeEvent(System.Object value) { }
        private System.Boolean CanConvertTo(System.Type toType) { }
        private System.Func<System.Object> GetGetConverter(System.Type toType) { }
        private System.Boolean CanConvertFrom(System.Type fromType) { }
        private System.Action<System.Object> GetSetConverter(System.Type fromType) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200044D
    public class Variable`1 : Variable
    {
        // Fields
        private T _value;        // 0x0
        private System.String _propertyPath;        // 0x0
        private System.Func<T> getter;        // 0x0
        private System.Action<T> setter;        // 0x0
        private T m_originalValue;        // 0x0
        private System.Boolean m_hasOriginalValue;        // 0x0

        // Methods
        private System.Void add_getter(System.Func<T> value) { }
        private System.Void remove_getter(System.Func<T> value) { }
        private System.Void add_setter(System.Action<T> value) { }
        private System.Void remove_setter(System.Action<T> value) { }
        private System.Type get_varType() { }
        private System.Boolean get_isDataBound() { }
        private System.String get_propertyPath() { }
        private System.Void set_propertyPath(System.String value) { }
        private T get_value() { }
        private System.Void set_value(T value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name, System.String ID) { }
        private System.Object GetValueBoxed() { }
        private System.Void SetValueBoxed(System.Object newValue) { }
        private T GetValue() { }
        private System.Void SetValue(T newValue) { }
        private System.Void ResetDefaultValue() { }
        private System.Void RecordDefaultValue() { }
        private System.Void BindProperty(System.Reflection.MemberInfo prop, UnityEngine.GameObject target) { }
        private System.Void BindGetSet(System.Func<T> _get, System.Action<T> _set) { }
        private System.Void UnBind() { }
        private System.Void InitializePropertyBinding(UnityEngine.GameObject go, System.Boolean callSetter) { }

    }

    // TypeToken: 0x2000452
    public class VariableSeperator
    {
        // Fields
        private System.Boolean <isEditingName>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Boolean get_isEditingName() { }
        private System.Void set_isEditingName(System.Boolean value) { }

    }

}

namespace NodeCanvas.Framework.Internal
{

    // TypeToken: 0x2000453
    public struct GraphLoadData
    {
        // Fields
        public NodeCanvas.Framework.Internal.GraphSource source;        // 0x10
        public System.String json;        // 0x18
        public System.Collections.Generic.List<UnityEngine.Object> references;        // 0x20
        public UnityEngine.Component agent;        // 0x28
        public NodeCanvas.Framework.IBlackboard parentBlackboard;        // 0x30
        public System.Boolean preInitializeSubGraphs;        // 0x38

    }

    // TypeToken: 0x2000454
    public class GraphSource, ISerializationCollector, ISerializationCollectable
    {
        // Fields
        private System.Collections.Generic.List<NodeCanvas.Framework.Task> m_allTasks;        // 0x10
        public System.Collections.Generic.List<NodeCanvas.Framework.BBParameter> m_allParameters;        // 0x18
        public static System.Single FRAMEWORK_VERSION;        // 0x0
        private System.Single _version;        // 0x20
        private System.String _category;        // 0x28
        private System.String _comments;        // 0x30
        private UnityEngine.Vector2 _translation;        // 0x38
        private System.Single _zoomFactor;        // 0x40
        private System.String _type;        // 0x48
        private System.Collections.Generic.List<NodeCanvas.Framework.Node> _nodes;        // 0x50
        private System.Collections.Generic.List<NodeCanvas.Framework.Connection> _connections;        // 0x58
        private System.Collections.Generic.List<NodeCanvas.Framework.CanvasGroup> _canvasGroups;        // 0x60
        private NodeCanvas.Framework.Internal.BlackboardSource _localBlackboard;        // 0x68
        private System.Object _derivedData;        // 0x70

        // Methods
        private System.Collections.Generic.List<NodeCanvas.Framework.Task> get_allTasks() { }
        private System.Void set_allTasks(System.Collections.Generic.List<NodeCanvas.Framework.Task> value) { }
        private System.Collections.Generic.List<NodeCanvas.Framework.BBParameter> get_allParameters() { }
        private System.Void set_allParameters(System.Collections.Generic.List<NodeCanvas.Framework.BBParameter> value) { }
        private System.Void ParadoxNotion.Serialization.FullSerializer.ISerializationCollector.OnPush(ParadoxNotion.Serialization.FullSerializer.ISerializationCollector parent) { }
        private System.Void ParadoxNotion.Serialization.FullSerializer.ISerializationCollector.OnCollect(ParadoxNotion.Serialization.FullSerializer.ISerializationCollectable child, System.Int32 depth) { }
        private System.Void ParadoxNotion.Serialization.FullSerializer.ISerializationCollector.OnPop(ParadoxNotion.Serialization.FullSerializer.ISerializationCollector parent) { }
        private System.Single get_version() { }
        private System.Void set_version(System.Single value) { }
        private System.String get_category() { }
        private System.Void set_category(System.String value) { }
        private System.String get_comments() { }
        private System.Void set_comments(System.String value) { }
        private UnityEngine.Vector2 get_translation() { }
        private System.Void set_translation(UnityEngine.Vector2 value) { }
        private System.Single get_zoomFactor() { }
        private System.Void set_zoomFactor(System.Single value) { }
        private System.String get_type() { }
        private System.Void set_type(System.String value) { }
        private System.Collections.Generic.List<NodeCanvas.Framework.Node> get_nodes() { }
        private System.Void set_nodes(System.Collections.Generic.List<NodeCanvas.Framework.Node> value) { }
        private System.Collections.Generic.List<NodeCanvas.Framework.Connection> get_connections() { }
        private System.Void set_connections(System.Collections.Generic.List<NodeCanvas.Framework.Connection> value) { }
        private System.Collections.Generic.List<NodeCanvas.Framework.CanvasGroup> get_canvasGroups() { }
        private System.Void set_canvasGroups(System.Collections.Generic.List<NodeCanvas.Framework.CanvasGroup> value) { }
        private NodeCanvas.Framework.Internal.BlackboardSource get_localBlackboard() { }
        private System.Void set_localBlackboard(NodeCanvas.Framework.Internal.BlackboardSource value) { }
        private System.Object get_derivedData() { }
        private System.Void set_derivedData(System.Object value) { }
        private System.Void .ctor() { }
        private NodeCanvas.Framework.Internal.GraphSource Pack(NodeCanvas.Framework.Graph graph) { }
        private NodeCanvas.Framework.Internal.GraphSource Unpack(NodeCanvas.Framework.Graph graph) { }
        private NodeCanvas.Framework.Internal.GraphSource SetMetaData(NodeCanvas.Framework.Internal.GraphSource source) { }
        private System.Void PurgeRedundantReferences() { }

    }

    // TypeToken: 0x2000455
    public class MissingConnection : Connection, IMissingRecoverable
    {
        // Fields
        private System.String _missingType;        // 0x30
        private System.String _recoveryState;        // 0x38

        // Methods
        private System.String ParadoxNotion.Serialization.IMissingRecoverable.get_missingType() { }
        private System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_missingType(System.String value) { }
        private System.String ParadoxNotion.Serialization.IMissingRecoverable.get_recoveryState() { }
        private System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_recoveryState(System.String value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000456
    public class MissingNode : Node, IMissingRecoverable
    {
        // Fields
        private System.String _missingType;        // 0x98
        private System.String _recoveryState;        // 0xA0

        // Methods
        private System.String ParadoxNotion.Serialization.IMissingRecoverable.get_missingType() { }
        private System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_missingType(System.String value) { }
        private System.String ParadoxNotion.Serialization.IMissingRecoverable.get_recoveryState() { }
        private System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_recoveryState(System.String value) { }
        private System.String get_name() { }
        private System.Type get_outConnectionType() { }
        private System.Int32 get_maxInConnections() { }
        private System.Int32 get_maxOutConnections() { }
        private System.Boolean get_allowAsPrime() { }
        private System.Boolean get_canSelfConnect() { }
        private ParadoxNotion.Alignment2x2 get_commentsAlignment() { }
        private ParadoxNotion.Alignment2x2 get_iconAlignment() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000457
    public class ReflectedAction : ReflectedActionWrapper
    {
        // Fields
        private ParadoxNotion.ActionCall call;        // 0x18

        // Methods
        private NodeCanvas.Framework.BBParameter[] GetVariables() { }
        private System.Void Init(System.Object instance) { }
        private System.Void Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000458
    public class ReflectedAction`1 : ReflectedActionWrapper
    {
        // Fields
        private ParadoxNotion.ActionCall<T1> call;        // 0x0
        public NodeCanvas.Framework.BBParameter<T1> p1;        // 0x0

        // Methods
        private NodeCanvas.Framework.BBParameter[] GetVariables() { }
        private System.Void Init(System.Object instance) { }
        private System.Void Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000459
    public class ReflectedAction`2 : ReflectedActionWrapper
    {
        // Fields
        private ParadoxNotion.ActionCall<T1,T2> call;        // 0x0
        public NodeCanvas.Framework.BBParameter<T1> p1;        // 0x0
        public NodeCanvas.Framework.BBParameter<T2> p2;        // 0x0

        // Methods
        private NodeCanvas.Framework.BBParameter[] GetVariables() { }
        private System.Void Init(System.Object instance) { }
        private System.Void Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200045A
    public class ReflectedAction`3 : ReflectedActionWrapper
    {
        // Fields
        private ParadoxNotion.ActionCall<T1,T2,T3> call;        // 0x0
        public NodeCanvas.Framework.BBParameter<T1> p1;        // 0x0
        public NodeCanvas.Framework.BBParameter<T2> p2;        // 0x0
        public NodeCanvas.Framework.BBParameter<T3> p3;        // 0x0

        // Methods
        private NodeCanvas.Framework.BBParameter[] GetVariables() { }
        private System.Void Init(System.Object instance) { }
        private System.Void Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200045B
    public class ReflectedAction`4 : ReflectedActionWrapper
    {
        // Fields
        private ParadoxNotion.ActionCall<T1,T2,T3,T4> call;        // 0x0
        public NodeCanvas.Framework.BBParameter<T1> p1;        // 0x0
        public NodeCanvas.Framework.BBParameter<T2> p2;        // 0x0
        public NodeCanvas.Framework.BBParameter<T3> p3;        // 0x0
        public NodeCanvas.Framework.BBParameter<T4> p4;        // 0x0

        // Methods
        private NodeCanvas.Framework.BBParameter[] GetVariables() { }
        private System.Void Init(System.Object instance) { }
        private System.Void Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200045C
    public class ReflectedAction`5 : ReflectedActionWrapper
    {
        // Fields
        private ParadoxNotion.ActionCall<T1,T2,T3,T4,T5> call;        // 0x0
        public NodeCanvas.Framework.BBParameter<T1> p1;        // 0x0
        public NodeCanvas.Framework.BBParameter<T2> p2;        // 0x0
        public NodeCanvas.Framework.BBParameter<T3> p3;        // 0x0
        public NodeCanvas.Framework.BBParameter<T4> p4;        // 0x0
        public NodeCanvas.Framework.BBParameter<T5> p5;        // 0x0

        // Methods
        private NodeCanvas.Framework.BBParameter[] GetVariables() { }
        private System.Void Init(System.Object instance) { }
        private System.Void Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200045D
    public class ReflectedAction`6 : ReflectedActionWrapper
    {
        // Fields
        private ParadoxNotion.ActionCall<T1,T2,T3,T4,T5,T6> call;        // 0x0
        public NodeCanvas.Framework.BBParameter<T1> p1;        // 0x0
        public NodeCanvas.Framework.BBParameter<T2> p2;        // 0x0
        public NodeCanvas.Framework.BBParameter<T3> p3;        // 0x0
        public NodeCanvas.Framework.BBParameter<T4> p4;        // 0x0
        public NodeCanvas.Framework.BBParameter<T5> p5;        // 0x0
        public NodeCanvas.Framework.BBParameter<T6> p6;        // 0x0

        // Methods
        private NodeCanvas.Framework.BBParameter[] GetVariables() { }
        private System.Void Init(System.Object instance) { }
        private System.Void Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200045E
    public class ReflectedFunction`1 : ReflectedFunctionWrapper
    {
        // Fields
        private ParadoxNotion.FunctionCall<TResult> call;        // 0x0
        public NodeCanvas.Framework.BBParameter<TResult> result;        // 0x0

        // Methods
        private NodeCanvas.Framework.BBParameter[] GetVariables() { }
        private System.Void Init(System.Object instance) { }
        private System.Object Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200045F
    public class ReflectedFunction`2 : ReflectedFunctionWrapper
    {
        // Fields
        private ParadoxNotion.FunctionCall<T1,TResult> call;        // 0x0
        public NodeCanvas.Framework.BBParameter<T1> p1;        // 0x0
        public NodeCanvas.Framework.BBParameter<TResult> result;        // 0x0

        // Methods
        private NodeCanvas.Framework.BBParameter[] GetVariables() { }
        private System.Void Init(System.Object instance) { }
        private System.Object Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000460
    public class ReflectedFunction`3 : ReflectedFunctionWrapper
    {
        // Fields
        private ParadoxNotion.FunctionCall<T1,T2,TResult> call;        // 0x0
        public NodeCanvas.Framework.BBParameter<T1> p1;        // 0x0
        public NodeCanvas.Framework.BBParameter<T2> p2;        // 0x0
        public NodeCanvas.Framework.BBParameter<TResult> result;        // 0x0

        // Methods
        private NodeCanvas.Framework.BBParameter[] GetVariables() { }
        private System.Void Init(System.Object instance) { }
        private System.Object Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000461
    public class ReflectedFunction`4 : ReflectedFunctionWrapper
    {
        // Fields
        private ParadoxNotion.FunctionCall<T1,T2,T3,TResult> call;        // 0x0
        public NodeCanvas.Framework.BBParameter<T1> p1;        // 0x0
        public NodeCanvas.Framework.BBParameter<T2> p2;        // 0x0
        public NodeCanvas.Framework.BBParameter<T3> p3;        // 0x0
        public NodeCanvas.Framework.BBParameter<TResult> result;        // 0x0

        // Methods
        private NodeCanvas.Framework.BBParameter[] GetVariables() { }
        private System.Void Init(System.Object instance) { }
        private System.Object Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000462
    public class ReflectedFunction`5 : ReflectedFunctionWrapper
    {
        // Fields
        private ParadoxNotion.FunctionCall<T1,T2,T3,T4,TResult> call;        // 0x0
        public NodeCanvas.Framework.BBParameter<T1> p1;        // 0x0
        public NodeCanvas.Framework.BBParameter<T2> p2;        // 0x0
        public NodeCanvas.Framework.BBParameter<T3> p3;        // 0x0
        public NodeCanvas.Framework.BBParameter<T4> p4;        // 0x0
        public NodeCanvas.Framework.BBParameter<TResult> result;        // 0x0

        // Methods
        private NodeCanvas.Framework.BBParameter[] GetVariables() { }
        private System.Void Init(System.Object instance) { }
        private System.Object Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000463
    public class ReflectedFunction`6 : ReflectedFunctionWrapper
    {
        // Fields
        private ParadoxNotion.FunctionCall<T1,T2,T3,T4,T5,TResult> call;        // 0x0
        public NodeCanvas.Framework.BBParameter<T1> p1;        // 0x0
        public NodeCanvas.Framework.BBParameter<T2> p2;        // 0x0
        public NodeCanvas.Framework.BBParameter<T3> p3;        // 0x0
        public NodeCanvas.Framework.BBParameter<T4> p4;        // 0x0
        public NodeCanvas.Framework.BBParameter<T5> p5;        // 0x0
        public NodeCanvas.Framework.BBParameter<TResult> result;        // 0x0

        // Methods
        private NodeCanvas.Framework.BBParameter[] GetVariables() { }
        private System.Void Init(System.Object instance) { }
        private System.Object Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000464
    public class ReflectedFunction`7 : ReflectedFunctionWrapper
    {
        // Fields
        private ParadoxNotion.FunctionCall<T1,T2,T3,T4,T5,T6,TResult> call;        // 0x0
        public NodeCanvas.Framework.BBParameter<T1> p1;        // 0x0
        public NodeCanvas.Framework.BBParameter<T2> p2;        // 0x0
        public NodeCanvas.Framework.BBParameter<T3> p3;        // 0x0
        public NodeCanvas.Framework.BBParameter<T4> p4;        // 0x0
        public NodeCanvas.Framework.BBParameter<T5> p5;        // 0x0
        public NodeCanvas.Framework.BBParameter<T6> p6;        // 0x0
        public NodeCanvas.Framework.BBParameter<TResult> result;        // 0x0

        // Methods
        private NodeCanvas.Framework.BBParameter[] GetVariables() { }
        private System.Void Init(System.Object instance) { }
        private System.Object Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000465
    public class ReflectedWrapper, IReflectedWrapper
    {
        // Fields
        protected ParadoxNotion.Serialization.SerializedMethodInfo _targetMethod;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private NodeCanvas.Framework.Internal.ReflectedWrapper Create(System.Reflection.MethodInfo method, NodeCanvas.Framework.IBlackboard bb) { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Void SetVariablesBB(NodeCanvas.Framework.IBlackboard bb) { }
        private ParadoxNotion.Serialization.SerializedMethodInfo GetSerializedMethod() { }
        private System.Reflection.MethodInfo GetMethod() { }
        private System.Boolean HasChanged() { }
        private System.String AsString() { }
        private System.String ToString() { }
        private NodeCanvas.Framework.BBParameter[] GetVariables() { }
        private System.Void Init(System.Object instance) { }

    }

    // TypeToken: 0x2000466
    public class ReflectedActionWrapper : ReflectedWrapper
    {
        // Methods
        private NodeCanvas.Framework.Internal.ReflectedActionWrapper Create(System.Reflection.MethodInfo method, NodeCanvas.Framework.IBlackboard bb) { }
        private System.Void Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000467
    public class ReflectedFunctionWrapper : ReflectedWrapper
    {
        // Methods
        private NodeCanvas.Framework.Internal.ReflectedFunctionWrapper Create(System.Reflection.MethodInfo method, NodeCanvas.Framework.IBlackboard bb) { }
        private System.Object Call() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000468
    public class MissingAction : ActionTask, IMissingRecoverable
    {
        // Fields
        private System.String _missingType;        // 0x68
        private System.String _recoveryState;        // 0x70

        // Methods
        private System.String ParadoxNotion.Serialization.IMissingRecoverable.get_missingType() { }
        private System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_missingType(System.String value) { }
        private System.String ParadoxNotion.Serialization.IMissingRecoverable.get_recoveryState() { }
        private System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_recoveryState(System.String value) { }
        private System.String get_info() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000469
    public class MissingCondition : ConditionTask, IMissingRecoverable
    {
        // Fields
        private System.String _missingType;        // 0x68
        private System.String _recoveryState;        // 0x70

        // Methods
        private System.String ParadoxNotion.Serialization.IMissingRecoverable.get_missingType() { }
        private System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_missingType(System.String value) { }
        private System.String ParadoxNotion.Serialization.IMissingRecoverable.get_recoveryState() { }
        private System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_recoveryState(System.String value) { }
        private System.String get_info() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200046A
    public class TaskAgentParameter : BBParameter`1
    {
        // Fields
        private System.Type _type;        // 0x50

        // Methods
        private System.Type get_varType() { }
        private UnityEngine.Object get_value() { }
        private System.Void set_value(UnityEngine.Object value) { }
        private System.Object GetValueBoxed() { }
        private System.Void SetValueBoxed(System.Object newValue) { }
        private System.Void SetType(System.Type newType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200046B
    public class BBMappingParameter : BBObjectParameter
    {
        // Fields
        private System.String _targetSubGraphVariableID;        // 0x60
        private System.Boolean _canRead;        // 0x68
        private System.Boolean _canWrite;        // 0x69

        // Methods
        private System.String get_targetSubGraphVariableID() { }
        private System.Boolean get_canRead() { }
        private System.Void set_canRead(System.Boolean value) { }
        private System.Boolean get_canWrite() { }
        private System.Void set_canWrite(System.Boolean value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(NodeCanvas.Framework.Variable subVariable) { }

    }

    // TypeToken: 0x200046C
    public class BBObjectParameter : BBParameter`1, ISerializationCallbackReceiver
    {
        // Fields
        private System.String _type;        // 0x50
        private System.Type <type>k__BackingField;        // 0x58

        // Methods
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Type get_type() { }
        private System.Void set_type(System.Type value) { }
        private System.Type get_varType() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Type t) { }
        private System.Void .ctor(NodeCanvas.Framework.BBParameter source) { }
        private System.Void SetType(System.Type t) { }

    }

    // TypeToken: 0x200046D
    public class BlackboardSource, IBlackboard
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> _variables;        // 0x10
        private System.Action<NodeCanvas.Framework.Variable> onVariableAdded;        // 0x18
        private System.Action<NodeCanvas.Framework.Variable> onVariableRemoved;        // 0x20
        private NodeCanvas.Framework.IBlackboard <parent>k__BackingField;        // 0x28
        private UnityEngine.Object <unityContextObject>k__BackingField;        // 0x30
        private UnityEngine.Component <propertiesBindTarget>k__BackingField;        // 0x38

        // Methods
        private System.Void add_onVariableAdded(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.Void remove_onVariableAdded(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.Void add_onVariableRemoved(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.Void remove_onVariableRemoved(System.Action<NodeCanvas.Framework.Variable> value) { }
        private System.String get_identifier() { }
        private System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> get_variables() { }
        private System.Void set_variables(System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Variable> value) { }
        private NodeCanvas.Framework.IBlackboard get_parent() { }
        private System.Void set_parent(NodeCanvas.Framework.IBlackboard value) { }
        private UnityEngine.Object get_unityContextObject() { }
        private System.Void set_unityContextObject(UnityEngine.Object value) { }
        private UnityEngine.Component get_propertiesBindTarget() { }
        private System.Void set_propertiesBindTarget(UnityEngine.Component value) { }
        private System.String NodeCanvas.Framework.IBlackboard.get_independantVariablesFieldName() { }
        private System.Void NodeCanvas.Framework.IBlackboard.TryInvokeOnVariableAdded(NodeCanvas.Framework.Variable variable) { }
        private System.Void NodeCanvas.Framework.IBlackboard.TryInvokeOnVariableRemoved(NodeCanvas.Framework.Variable variable) { }
        private System.Void .ctor() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200046E
    public class fsBBParameterProcessor : fsRecoveryProcessor`2
    {
        // Methods
        private System.Void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200046F
    public class MissingBBParameterType : BBParameter`1, IMissingRecoverable
    {
        // Fields
        private System.String _missingType;        // 0x50
        private System.String _recoveryState;        // 0x58

        // Methods
        private System.String ParadoxNotion.Serialization.IMissingRecoverable.get_missingType() { }
        private System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_missingType(System.String value) { }
        private System.String ParadoxNotion.Serialization.IMissingRecoverable.get_recoveryState() { }
        private System.Void ParadoxNotion.Serialization.IMissingRecoverable.set_recoveryState(System.String value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000470
    public class MissingVariableType : Variable`1, IMissingRecoverable
    {
        // Fields
        private System.String _missingType;        // 0x70
        private System.String _recoveryState;        // 0x78

        // Methods
        private System.String get_missingType() { }
        private System.Void set_missingType(System.String value) { }
        private System.String get_recoveryState() { }
        private System.Void set_recoveryState(System.String value) { }
        private System.Void .ctor() { }

    }

}

namespace NodeCanvas.StateMachines
{

    // TypeToken: 0x2000366
    public class FSM : Graph
    {
        // Fields
        private System.Collections.Generic.List<NodeCanvas.Framework.IUpdatable> updatableNodes;        // 0xA0
        private NodeCanvas.StateMachines.IStateCallbackReceiver[] callbackReceivers;        // 0xA8
        private System.Collections.Generic.Stack<NodeCanvas.StateMachines.FSMState> stateStack;        // 0xB0
        private System.Boolean enterStartStateFlag;        // 0xB8
        private System.Action<NodeCanvas.StateMachines.IState> onStateEnter;        // 0xC0
        private System.Action<NodeCanvas.StateMachines.IState> onStateUpdate;        // 0xC8
        private System.Action<NodeCanvas.StateMachines.IState> onStateExit;        // 0xD0
        private System.Action<NodeCanvas.StateMachines.IState> onStateTransition;        // 0xD8
        private NodeCanvas.StateMachines.FSMState <currentState>k__BackingField;        // 0xE0
        private NodeCanvas.StateMachines.FSMState <previousState>k__BackingField;        // 0xE8

        // Methods
        private System.Void add_onStateEnter(System.Action<NodeCanvas.StateMachines.IState> value) { }
        private System.Void remove_onStateEnter(System.Action<NodeCanvas.StateMachines.IState> value) { }
        private System.Void add_onStateUpdate(System.Action<NodeCanvas.StateMachines.IState> value) { }
        private System.Void remove_onStateUpdate(System.Action<NodeCanvas.StateMachines.IState> value) { }
        private System.Void add_onStateExit(System.Action<NodeCanvas.StateMachines.IState> value) { }
        private System.Void remove_onStateExit(System.Action<NodeCanvas.StateMachines.IState> value) { }
        private System.Void add_onStateTransition(System.Action<NodeCanvas.StateMachines.IState> value) { }
        private System.Void remove_onStateTransition(System.Action<NodeCanvas.StateMachines.IState> value) { }
        private NodeCanvas.StateMachines.FSMState get_currentState() { }
        private System.Void set_currentState(NodeCanvas.StateMachines.FSMState value) { }
        private NodeCanvas.StateMachines.FSMState get_previousState() { }
        private System.Void set_previousState(NodeCanvas.StateMachines.FSMState value) { }
        private System.String get_currentStateName() { }
        private System.String get_previousStateName() { }
        private System.Type get_baseNodeType() { }
        private System.Boolean get_requiresAgent() { }
        private System.Boolean get_requiresPrimeNode() { }
        private System.Boolean get_isTree() { }
        private System.Boolean get_allowBlackboardOverrides() { }
        private System.Boolean get_canAcceptVariableDrops() { }
        private System.Boolean get_canDelayDeserializeAndOptimizeClone() { }
        private System.Void OnGraphInitialize() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphUpdate() { }
        private System.Void OnGraphStoped() { }
        private System.Boolean EnterState(NodeCanvas.StateMachines.FSMState newState, NodeCanvas.StateMachines.FSM.TransitionCallMode callMode) { }
        private NodeCanvas.StateMachines.FSMState TriggerState(System.String stateName, NodeCanvas.StateMachines.FSM.TransitionCallMode callMode) { }
        private System.String[] GetStateNames() { }
        private NodeCanvas.StateMachines.FSMState GetStateWithName(System.String name) { }
        private System.Void GatherCallbackReceivers() { }
        private NodeCanvas.StateMachines.FSMState PeekStack() { }
        private System.Void .ctor() { }
        private System.Void <GatherCallbackReceivers>b__51_0(NodeCanvas.StateMachines.IState x) { }
        private System.Void <GatherCallbackReceivers>b__51_1(NodeCanvas.StateMachines.IState x) { }
        private System.Void <GatherCallbackReceivers>b__51_2(NodeCanvas.StateMachines.IState x) { }

    }

    // TypeToken: 0x200036A
    public class FSMConnection : Connection, ITaskAssignable`1, ITaskAssignable, IGraphElement
    {
        // Fields
        private NodeCanvas.StateMachines.FSM.TransitionCallMode _transitionCallMode;        // 0x30
        private NodeCanvas.Framework.ConditionTask _condition;        // 0x38

        // Methods
        private NodeCanvas.Framework.ConditionTask get_condition() { }
        private System.Void set_condition(NodeCanvas.Framework.ConditionTask value) { }
        private NodeCanvas.Framework.Task get_task() { }
        private System.Void set_task(NodeCanvas.Framework.Task value) { }
        private NodeCanvas.StateMachines.FSM.TransitionCallMode get_transitionCallMode() { }
        private System.Void set_transitionCallMode(NodeCanvas.StateMachines.FSM.TransitionCallMode value) { }
        private System.Void EnableCondition(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard blackboard) { }
        private System.Void DisableCondition() { }
        private System.Void PerformTransition() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200036B
    public class FSMNode : Node
    {
        // Methods
        private System.Boolean get_allowAsPrime() { }
        private System.Boolean get_canSelfConnect() { }
        private System.Int32 get_maxInConnections() { }
        private System.Int32 get_maxOutConnections() { }
        private System.Type get_outConnectionType() { }
        private ParadoxNotion.Alignment2x2 get_commentsAlignment() { }
        private ParadoxNotion.Alignment2x2 get_iconAlignment() { }
        private NodeCanvas.StateMachines.FSM get_FSM() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200036C
    public class FSMNodeNested`1 : FSMNode, IGraphAssignable`1, IGraphAssignable, IGraphElement
    {
        // Fields
        private System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> _variablesMap;        // 0x0
        private T <currentInstance>k__BackingField;        // 0x0
        private System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> <instances>k__BackingField;        // 0x0

        // Methods
        private T get_subGraph() { }
        private System.Void set_subGraph(T value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private T get_currentInstance() { }
        private System.Void set_currentInstance(T value) { }
        private System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> get_instances() { }
        private System.Void set_instances(System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> value) { }
        private System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> get_variablesMap() { }
        private System.Void set_variablesMap(System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> value) { }
        private NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_subGraph() { }
        private System.Void NodeCanvas.Framework.IGraphAssignable.set_subGraph(NodeCanvas.Framework.Graph value) { }
        private NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_currentInstance() { }
        private System.Void NodeCanvas.Framework.IGraphAssignable.set_currentInstance(NodeCanvas.Framework.Graph value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200036D
    public class FSMOwner : GraphOwner`1
    {
        // Methods
        private System.String get_currentRootStateName() { }
        private System.String get_previousRootStateName() { }
        private System.String get_currentDeepStateName() { }
        private System.String get_previousDeepStateName() { }
        private NodeCanvas.StateMachines.IState GetCurrentState(System.Boolean includeSubFSMs) { }
        private NodeCanvas.StateMachines.IState GetPreviousState(System.Boolean includeSubFSMs) { }
        private NodeCanvas.StateMachines.IState TriggerState(System.String stateName) { }
        private NodeCanvas.StateMachines.IState TriggerState(System.String stateName, NodeCanvas.StateMachines.FSM.TransitionCallMode callMode) { }
        private System.String[] GetStateNames() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200036E
    public class FSMState : FSMNode, IState
    {
        // Fields
        private NodeCanvas.StateMachines.FSMState.TransitionEvaluationMode _transitionEvaluation;        // 0x98
        private System.Boolean _hasInit;        // 0x9C

        // Methods
        private System.Boolean get_allowAsPrime() { }
        private System.Boolean get_canSelfConnect() { }
        private System.Int32 get_maxInConnections() { }
        private System.Int32 get_maxOutConnections() { }
        private NodeCanvas.StateMachines.FSMState.TransitionEvaluationMode get_transitionEvaluation() { }
        private System.Void set_transitionEvaluation(NodeCanvas.StateMachines.FSMState.TransitionEvaluationMode value) { }
        private NodeCanvas.StateMachines.FSMConnection[] GetTransitions() { }
        private System.Void Finish() { }
        private System.Void Finish(System.Boolean inSuccess) { }
        private System.Void Finish(NodeCanvas.Framework.Status status) { }
        private System.Void OnGraphPaused() { }
        private System.Boolean CanConnectFromSource(NodeCanvas.Framework.Node sourceNode) { }
        private System.Boolean CanConnectToTarget(NodeCanvas.Framework.Node targetNode) { }
        private NodeCanvas.Framework.Status OnExecute(UnityEngine.Component agent, NodeCanvas.Framework.IBlackboard bb) { }
        private System.Boolean CheckTransitions() { }
        private System.Void OnReset() { }
        private System.Void OnInit() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate() { }
        private System.Void OnExit() { }
        private System.Void OnPause() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000370
    public class FSMStateNested`1 : FSMState, IGraphAssignable`1, IGraphAssignable, IGraphElement
    {
        // Fields
        private System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> _variablesMap;        // 0x0
        private T <currentInstance>k__BackingField;        // 0x0
        private System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> <instances>k__BackingField;        // 0x0

        // Methods
        private T get_subGraph() { }
        private System.Void set_subGraph(T value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private T get_currentInstance() { }
        private System.Void set_currentInstance(T value) { }
        private System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> get_instances() { }
        private System.Void set_instances(System.Collections.Generic.Dictionary<NodeCanvas.Framework.Graph,NodeCanvas.Framework.Graph> value) { }
        private System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> get_variablesMap() { }
        private System.Void set_variablesMap(System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBMappingParameter> value) { }
        private NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_subGraph() { }
        private System.Void NodeCanvas.Framework.IGraphAssignable.set_subGraph(NodeCanvas.Framework.Graph value) { }
        private NodeCanvas.Framework.Graph NodeCanvas.Framework.IGraphAssignable.get_currentInstance() { }
        private System.Void NodeCanvas.Framework.IGraphAssignable.set_currentInstance(NodeCanvas.Framework.Graph value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000371
    public interface IState
    {
        // Methods
        private System.String get_name() { }
        private System.String get_tag() { }
        private System.Single get_elapsedTime() { }
        private NodeCanvas.StateMachines.FSM get_FSM() { }
        private NodeCanvas.StateMachines.FSMConnection[] GetTransitions() { }
        private System.Boolean CheckTransitions() { }
        private System.Void Finish(System.Boolean success) { }

    }

    // TypeToken: 0x2000372
    public interface IStateCallbackReceiver
    {
        // Methods
        private System.Void OnStateEnter(NodeCanvas.StateMachines.IState state) { }
        private System.Void OnStateUpdate(NodeCanvas.StateMachines.IState state) { }
        private System.Void OnStateExit(NodeCanvas.StateMachines.IState state) { }

    }

    // TypeToken: 0x2000373
    public class ActionState : FSMState, ITaskAssignable, IGraphElement
    {
        // Fields
        private NodeCanvas.Framework.ActionList _actionList;        // 0xA0
        private System.Boolean _repeatStateActions;        // 0xA8

        // Methods
        private NodeCanvas.Framework.Task get_task() { }
        private System.Void set_task(NodeCanvas.Framework.Task value) { }
        private NodeCanvas.Framework.ActionList get_actionList() { }
        private System.Void set_actionList(NodeCanvas.Framework.ActionList value) { }
        private System.Boolean get_repeatStateActions() { }
        private System.Void set_repeatStateActions(System.Boolean value) { }
        private System.Void OnValidate(NodeCanvas.Framework.Graph assignedGraph) { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate() { }
        private System.Void OnExit() { }
        private System.Void OnPause() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000374
    public class AnyState : FSMNode, IUpdatable, IGraphElement
    {
        // Fields
        public System.Boolean dontRetriggerStates;        // 0x98

        // Methods
        private System.String get_name() { }
        private System.Int32 get_maxInConnections() { }
        private System.Int32 get_maxOutConnections() { }
        private System.Boolean get_allowAsPrime() { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void NodeCanvas.Framework.IUpdatable.Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000375
    public class ConcurrentSubFSM : FSMNodeNested`1, IUpdatable, IGraphElement
    {
        // Fields
        protected NodeCanvas.Framework.BBParameter<NodeCanvas.StateMachines.FSM> _subFSM;        // 0xB0

        // Methods
        private System.String get_name() { }
        private System.Int32 get_maxInConnections() { }
        private System.Int32 get_maxOutConnections() { }
        private System.Boolean get_allowAsPrime() { }
        private NodeCanvas.StateMachines.FSM get_subGraph() { }
        private System.Void set_subGraph(NodeCanvas.StateMachines.FSM value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private System.Void OnGraphStarted() { }
        private System.Void NodeCanvas.Framework.IUpdatable.Update() { }
        private System.Void .ctor() { }
        private System.Void <OnGraphStarted>b__14_0(System.Boolean result) { }

    }

    // TypeToken: 0x2000376
    public class ConcurrentSubTree : FSMNodeNested`1, IUpdatable, IGraphElement
    {
        // Fields
        protected NodeCanvas.Framework.BBParameter<NodeCanvas.BehaviourTrees.BehaviourTree> _subTree;        // 0xB0

        // Methods
        private System.String get_name() { }
        private System.Int32 get_maxInConnections() { }
        private System.Int32 get_maxOutConnections() { }
        private System.Boolean get_allowAsPrime() { }
        private NodeCanvas.BehaviourTrees.BehaviourTree get_subGraph() { }
        private System.Void set_subGraph(NodeCanvas.BehaviourTrees.BehaviourTree value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private System.Void OnGraphStarted() { }
        private System.Void NodeCanvas.Framework.IUpdatable.Update() { }
        private System.Void .ctor() { }
        private System.Void <OnGraphStarted>b__14_0(System.Boolean result) { }

    }

    // TypeToken: 0x2000377
    public class EmptyState : FSMState
    {
        // Methods
        private System.String get_name() { }
        private System.Void OnEnter() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000378
    public class NestedBTState : FSMStateNested`1
    {
        // Fields
        private NodeCanvas.Framework.BBParameter<NodeCanvas.BehaviourTrees.BehaviourTree> _nestedBT;        // 0xB8
        public NodeCanvas.StateMachines.NestedBTState.BTExitMode exitMode;        // 0xC0
        public NodeCanvas.StateMachines.NestedBTState.BTExecutionMode executionMode;        // 0xC4
        public System.String successEvent;        // 0xC8
        public System.String failureEvent;        // 0xD0

        // Methods
        private NodeCanvas.BehaviourTrees.BehaviourTree get_subGraph() { }
        private System.Void set_subGraph(NodeCanvas.BehaviourTrees.BehaviourTree value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate() { }
        private System.Void OnFinish(System.Boolean success) { }
        private System.Void OnExit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200037B
    public class NestedDTState : FSMStateNested`1
    {
        // Fields
        private NodeCanvas.Framework.BBParameter<NodeCanvas.DialogueTrees.DialogueTree> _nestedDLG;        // 0xB8
        public System.String successEvent;        // 0xC0
        public System.String failureEvent;        // 0xC8

        // Methods
        private NodeCanvas.DialogueTrees.DialogueTree get_subGraph() { }
        private System.Void set_subGraph(NodeCanvas.DialogueTrees.DialogueTree value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate() { }
        private System.Void OnExit() { }
        private System.Void OnDialogueFinished(System.Boolean success) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200037C
    public class NestedFSMState : FSMStateNested`1
    {
        // Fields
        private NodeCanvas.Framework.BBParameter<NodeCanvas.StateMachines.FSM> _nestedFSM;        // 0xB8
        public NodeCanvas.StateMachines.NestedFSMState.FSMExitMode exitMode;        // 0xC0

        // Methods
        private NodeCanvas.StateMachines.FSM get_subGraph() { }
        private System.Void set_subGraph(NodeCanvas.StateMachines.FSM value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate() { }
        private System.Void OnExit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200037E
    public class OnFSMEnter : FSMNode, IUpdatable, IGraphElement
    {
        // Fields
        private NodeCanvas.Framework.ConditionList _conditionList;        // 0x98
        private NodeCanvas.Framework.ActionList _actionList;        // 0xA0

        // Methods
        private System.String get_name() { }
        private System.Int32 get_maxInConnections() { }
        private System.Int32 get_maxOutConnections() { }
        private System.Boolean get_allowAsPrime() { }
        private System.Void OnValidate(NodeCanvas.Framework.Graph assignedGraph) { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void NodeCanvas.Framework.IUpdatable.Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200037F
    public class OnFSMExit : FSMNode
    {
        // Fields
        private NodeCanvas.Framework.ConditionList _conditionList;        // 0x98
        private NodeCanvas.Framework.ActionList _actionList;        // 0xA0

        // Methods
        private System.String get_name() { }
        private System.Int32 get_maxInConnections() { }
        private System.Int32 get_maxOutConnections() { }
        private System.Boolean get_allowAsPrime() { }
        private System.Void OnValidate(NodeCanvas.Framework.Graph assignedGraph) { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000380
    public class OnFSMUpdate : FSMNode, IUpdatable, IGraphElement
    {
        // Fields
        private NodeCanvas.Framework.ConditionList _conditionList;        // 0x98
        private NodeCanvas.Framework.ActionList _actionList;        // 0xA0

        // Methods
        private System.String get_name() { }
        private System.Int32 get_maxInConnections() { }
        private System.Int32 get_maxOutConnections() { }
        private System.Boolean get_allowAsPrime() { }
        private System.Void OnValidate(NodeCanvas.Framework.Graph assignedGraph) { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void NodeCanvas.Framework.IUpdatable.Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000381
    public class SuperActionState : FSMState
    {
        // Fields
        private NodeCanvas.Framework.ActionList _onEnterList;        // 0xA0
        private NodeCanvas.Framework.ActionList _onUpdateList;        // 0xA8
        private NodeCanvas.Framework.ActionList _onExitList;        // 0xB0
        private System.Boolean enterListFinished;        // 0xB8

        // Methods
        private System.Void OnValidate(NodeCanvas.Framework.Graph assignedGraph) { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate() { }
        private System.Void OnExit() { }
        private System.Void OnPause() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000382
    public class ConcurrentState : FSMNode, IUpdatable, IGraphElement
    {
        // Fields
        private NodeCanvas.Framework.ConditionList _conditionList;        // 0x98
        private NodeCanvas.Framework.ActionList _actionList;        // 0xA0
        private System.Boolean _repeatStateActions;        // 0xA8
        private System.Boolean done;        // 0xA9

        // Methods
        private NodeCanvas.Framework.ConditionList get_conditionList() { }
        private System.Void set_conditionList(NodeCanvas.Framework.ConditionList value) { }
        private NodeCanvas.Framework.ActionList get_actionList() { }
        private System.Void set_actionList(NodeCanvas.Framework.ActionList value) { }
        private System.Boolean get_repeatStateActions() { }
        private System.Void set_repeatStateActions(System.Boolean value) { }
        private System.String get_name() { }
        private System.Int32 get_maxInConnections() { }
        private System.Int32 get_maxOutConnections() { }
        private System.Boolean get_allowAsPrime() { }
        private System.Void OnValidate(NodeCanvas.Framework.Graph assignedGraph) { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void OnGraphPaused() { }
        private System.Void NodeCanvas.Framework.IUpdatable.Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000383
    public class EnterExitState : FSMNode, IUpdatable, IGraphElement
    {
        // Fields
        private NodeCanvas.Framework.ActionList _actionListEnter;        // 0x98
        private NodeCanvas.Framework.ActionList _actionListExit;        // 0xA0

        // Methods
        private NodeCanvas.Framework.ActionList get_actionListEnter() { }
        private System.Void set_actionListEnter(NodeCanvas.Framework.ActionList value) { }
        private NodeCanvas.Framework.ActionList get_actionListExit() { }
        private System.Void set_actionListExit(NodeCanvas.Framework.ActionList value) { }
        private System.String get_name() { }
        private System.Int32 get_maxInConnections() { }
        private System.Int32 get_maxOutConnections() { }
        private System.Boolean get_allowAsPrime() { }
        private System.Void OnValidate(NodeCanvas.Framework.Graph assignedGraph) { }
        private System.Void OnGraphStarted() { }
        private System.Void OnGraphStoped() { }
        private System.Void NodeCanvas.Framework.IUpdatable.Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000384
    public class ConcurrentSubFlowScript : FSMNodeNested`1, IUpdatable, IGraphElement
    {
        // Fields
        protected NodeCanvas.Framework.BBParameter<FlowCanvas.FlowScript> _subFlowScript;        // 0xB0

        // Methods
        private System.String get_name() { }
        private System.Int32 get_maxInConnections() { }
        private System.Int32 get_maxOutConnections() { }
        private System.Boolean get_allowAsPrime() { }
        private FlowCanvas.FlowScript get_subGraph() { }
        private System.Void set_subGraph(FlowCanvas.FlowScript value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private System.Void OnGraphStarted() { }
        private System.Void NodeCanvas.Framework.IUpdatable.Update() { }
        private System.Void .ctor() { }
        private System.Void <OnGraphStarted>b__14_0(System.Boolean result) { }

    }

    // TypeToken: 0x2000385
    public class FlowScriptState : FSMStateNested`1
    {
        // Fields
        private NodeCanvas.Framework.BBParameter<FlowCanvas.FlowScript> _flowScript;        // 0xB8
        public System.String successEvent;        // 0xC0
        public System.String failureEvent;        // 0xC8

        // Methods
        private FlowCanvas.FlowScript get_subGraph() { }
        private System.Void set_subGraph(FlowCanvas.FlowScript value) { }
        private NodeCanvas.Framework.BBParameter get_subGraphParameter() { }
        private System.Void OnEnter() { }
        private System.Void OnUpdate() { }
        private System.Void OnFlowScriptFinished(System.Boolean success) { }
        private System.Void OnExit() { }
        private System.Void .ctor() { }

    }

}

namespace NodeCanvas.Tasks.Actions
{

    // TypeToken: 0x20002D6
    public class PlayAnimationAdvanced : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.AnimationClip> animationClip;        // 0x68
        public UnityEngine.WrapMode animationWrap;        // 0x70
        public UnityEngine.AnimationBlendMode blendMode;        // 0x74
        public System.Single playbackSpeed;        // 0x78
        public System.Single crossFadeTime;        // 0x7C
        public ParadoxNotion.PlayDirections playDirection;        // 0x80
        public NodeCanvas.Framework.BBParameter<System.String> mixTransformName;        // 0x88
        public NodeCanvas.Framework.BBParameter<System.Int32> animationLayer;        // 0x90
        public System.Boolean queueAnimation;        // 0x98
        public System.Boolean waitActionFinish;        // 0x99
        private System.String animationToPlay;        // 0xA0
        private System.Int32 dir;        // 0xA8
        private UnityEngine.Transform mixTransform;        // 0xB0

        // Methods
        private System.String get_info() { }
        private System.String OnInit() { }
        private System.Void OnExecute() { }
        private System.Void OnUpdate() { }
        private UnityEngine.Transform FindTransform(UnityEngine.Transform parent, System.String name) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002D7
    public class PlayAnimationSimple : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.AnimationClip> animationClip;        // 0x68
        public System.Single crossFadeTime;        // 0x70
        public UnityEngine.WrapMode animationWrap;        // 0x74
        public System.Boolean waitActionFinish;        // 0x78
        private static System.Collections.Generic.Dictionary<UnityEngine.Animation,UnityEngine.AnimationClip> lastPlayedClips;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.String OnInit() { }
        private System.Void OnExecute() { }
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20002D8
    public class MecanimPlayAnimation : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Int32> layerIndex;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.String> stateName;        // 0x70
        public System.Single transitTime;        // 0x78
        public System.Boolean waitUntilFinish;        // 0x7C
        private UnityEngine.AnimatorStateInfo stateInfo;        // 0x80
        private System.Boolean played;        // 0xB4

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002D9
    public class MecanimSetBool : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> parameter;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Int32> parameterHashID;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Boolean> setTo;        // 0x78

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002DA
    public class MecanimSetFloat : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> parameter;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Int32> parameterHashID;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> setTo;        // 0x78
        public System.Single transitTime;        // 0x80
        private System.Single currentValue;        // 0x84

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void OnUpdate() { }
        private System.Single Get() { }
        private System.Void Set(System.Single newValue) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002DB
    public class MecanimSetIK : ActionTask`1
    {
        // Fields
        public UnityEngine.AvatarIKGoal IKGoal;        // 0x68
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> goal;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> weight;        // 0x78

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void OnStop() { }
        private System.Void OnAnimatorIK(ParadoxNotion.EventData<System.Int32> msg) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002DC
    public class MecanimSetInt : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> parameter;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Int32> parameterHashID;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Int32> setTo;        // 0x78

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002DD
    public class MecanimSetLayerWeight : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Int32> layerIndex;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> layerWeight;        // 0x70
        public System.Single transitTime;        // 0x78
        private System.Single currentValue;        // 0x7C

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002DE
    public class MecanimSetLookAt : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> targetPosition;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> targetWeight;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void OnStop() { }
        private System.Void OnAnimatorIK(ParadoxNotion.EventData<System.Int32> msg) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002DF
    public class MecanimSetTrigger : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> parameter;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Int32> parameterHashID;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E0
    public class LoadScene : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> sceneName;        // 0x68
        public NodeCanvas.Framework.BBParameter<UnityEngine.SceneManagement.LoadSceneMode> mode;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E1
    public class PlayAudioAtPosition : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.AudioClip> audioClip;        // 0x68
        public System.Single volume;        // 0x70
        public System.Boolean waitActionFinish;        // 0x74

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E2
    public class ComposeVector : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Single> x;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> y;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> z;        // 0x78
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> saveAs;        // 0x80

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E3
    public class DecomposeVector : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> targetVector;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> x;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> y;        // 0x78
        public NodeCanvas.Framework.BBParameter<System.Single> z;        // 0x80

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E4
    public class AddElementToDictionary`1 : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.Dictionary<System.String,T>> dictionary;        // 0x0
        public NodeCanvas.Framework.BBParameter<System.String> key;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> value;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E5
    public class GetDictionaryElement`1 : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.Dictionary<System.String,T>> dictionary;        // 0x0
        public NodeCanvas.Framework.BBParameter<System.String> key;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> saveAs;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E6
    public class EvaluateCurve : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.AnimationCurve> curve;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> from;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> to;        // 0x78
        public NodeCanvas.Framework.BBParameter<System.Single> time;        // 0x80
        public NodeCanvas.Framework.BBParameter<System.Single> saveAs;        // 0x88

        // Methods
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E7
    public class GetSelf : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveAs;        // 0x68

        // Methods
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E8
    public class GetOtherBlackboardVariable : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> targetVariableName;        // 0x68
        public NodeCanvas.Framework.Internal.BBObjectParameter saveAs;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002E9
    public class GetToString : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Object> variable;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.String> toString;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002EA
    public class AddElementToList`1 : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>> targetList;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> targetElement;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002EB
    public class ClearList : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.IList> targetList;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002EC
    public class GetCloserGameObjectInList : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> list;        // 0x68
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveAs;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002ED
    public class GetIndexOfElement`1 : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>> targetList;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> targetElement;        // 0x0
        public NodeCanvas.Framework.BBParameter<System.Int32> saveIndexAs;        // 0x0

        // Methods
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002EE
    public class GetListCount : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.IList> targetList;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Int32> saveAs;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002EF
    public class InsertElementToList`1 : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>> targetList;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> targetElement;        // 0x0
        public NodeCanvas.Framework.BBParameter<System.Int32> targetIndex;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002F0
    public class PickListElement`1 : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>> targetList;        // 0x0
        public NodeCanvas.Framework.BBParameter<System.Int32> index;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> saveAs;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002F1
    public class PickRandomListElement`1 : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>> targetList;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> saveAs;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002F2
    public class RemoveElementFromList`1 : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>> targetList;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> targetElement;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002F3
    public class SetListElement`1 : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>> targetList;        // 0x0
        public NodeCanvas.Framework.BBParameter<System.Int32> index;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> newValue;        // 0x0

        // Methods
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002F4
    public class ShuffleList : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.IList> targetList;        // 0x68

        // Methods
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002F5
    public class SortGameObjectListByDistance : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> targetList;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> saveAs;        // 0x70
        public System.Boolean reverse;        // 0x78

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }
        private System.Single <OnExecute>b__5_0(UnityEngine.GameObject go) { }

    }

    // TypeToken: 0x20002F6
    public class LoadBlackboard : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> saveKey;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002F7
    public class NormalizeVector : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> targetVector;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> multiply;        // 0x70

        // Methods
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002F8
    public class SampleCurve : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.AnimationCurve> curve;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> sampleAt;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> saveAs;        // 0x78

        // Methods
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002F9
    public class SaveBlackboard : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> saveKey;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002FA
    public class SetBoolean : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Boolean> boolVariable;        // 0x68
        public NodeCanvas.Tasks.Actions.SetBoolean.BoolSetModes setTo;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002FC
    public class SetBooleanRandom : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Boolean> boolVariable;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002FD
    public class SetEnum : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.Internal.BBObjectParameter valueA;        // 0x68
        public NodeCanvas.Framework.Internal.BBObjectParameter valueB;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002FE
    public class SetFloat : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Single> valueA;        // 0x68
        public ParadoxNotion.OperationMethod Operation;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> valueB;        // 0x78
        public System.Boolean perSecond;        // 0x80

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002FF
    public class SetFloatRandom : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Single> minValue;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> maxValue;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> floatVariable;        // 0x78

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000300
    public class SetInt : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Int32> valueA;        // 0x68
        public ParadoxNotion.OperationMethod Operation;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Int32> valueB;        // 0x78

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000301
    public class SetIntRandom : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Int32> minValue;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Int32> maxValue;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Int32> intVariable;        // 0x78

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000302
    public class SetOtherBlackboardVariable : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> targetVariableName;        // 0x68
        public NodeCanvas.Framework.Internal.BBObjectParameter newValue;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000303
    public class SetVariable`1 : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<T> valueA;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> valueB;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000304
    public class SetVector3 : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> valueA;        // 0x68
        public ParadoxNotion.OperationMethod operation;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> valueB;        // 0x78
        public System.Boolean perSecond;        // 0x80

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000305
    public class TriggerBoolean : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Boolean> variable;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Collections.IEnumerator Flip() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000307
    public class FadeIn : ActionTask
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000308
    public class FadeOut : ActionTask
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000309
    public class Say : ActionTask`1
    {
        // Fields
        public NodeCanvas.DialogueTrees.Statement statement;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200030A
    public class SayRandom : ActionTask`1
    {
        // Fields
        public System.Collections.Generic.List<NodeCanvas.DialogueTrees.Statement> statements;        // 0x68

        // Methods
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200030B
    public class StartDialogueTree : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<NodeCanvas.DialogueTrees.DialogueTreeController> dialogueTreeController;        // 0x68
        public System.Boolean waitActionFinish;        // 0x70
        public System.Boolean isPrefab;        // 0x71
        private NodeCanvas.DialogueTrees.DialogueTreeController instance;        // 0x78

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }
        private System.Void <OnExecute>b__6_0(System.Boolean success) { }
        private System.Void <OnExecute>b__6_1(System.Boolean success) { }

    }

    // TypeToken: 0x200030C
    public class CreateGameObject : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> objectName;        // 0x68
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> position;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> rotation;        // 0x78
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveAs;        // 0x80

        // Methods
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200030D
    public class CreatePrimitive : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> objectName;        // 0x68
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> position;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> rotation;        // 0x78
        public NodeCanvas.Framework.BBParameter<UnityEngine.PrimitiveType> type;        // 0x80
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveAs;        // 0x88

        // Methods
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200030E
    public class DestroyGameObject : ActionTask`1
    {
        // Fields
        public System.Boolean immediately;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200030F
    public class FindAllWithLayer : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask> targetLayers;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> saveAs;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000310
    public class FindAllWithName : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> searchName;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> saveAs;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000311
    public class FindAllWithTag : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> searchTag;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> saveAs;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000312
    public class FindChildByName : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> childName;        // 0x68
        public NodeCanvas.Framework.BBParameter<UnityEngine.Transform> saveAs;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000313
    public class FindClosestWithTag : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> searchTag;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Boolean> ignoreChildren;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveObjectAs;        // 0x78
        public NodeCanvas.Framework.BBParameter<System.Single> saveDistanceAs;        // 0x80

        // Methods
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000314
    public class FindObjectOfType`1 : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<T> saveComponentAs;        // 0x0
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveGameObjectAs;        // 0x0

        // Methods
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000315
    public class FindObjectsOfType`1 : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> saveGameObjects;        // 0x0
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>> saveComponents;        // 0x0

        // Methods
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000317
    public class FindWithName : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> gameObjectName;        // 0x68
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveAs;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000318
    public class FindWithTag : ActionTask
    {
        // Fields
        public System.String searchTag;        // 0x68
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveAs;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000319
    public class GetAllChildGameObjects : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> saveAs;        // 0x68
        public System.Boolean recursive;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Collections.Generic.List<UnityEngine.Transform> Get(UnityEngine.Transform parent) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200031B
    public class GetComponent`1 : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<T> saveAs;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200031C
    public class GetDistance : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> target;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> saveAs;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200031D
    public class GetGameObjectPosition : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> saveAs;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200031E
    public class InstantiateGameObject : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.Transform> parent;        // 0x68
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> clonePosition;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> cloneRotation;        // 0x78
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveCloneAs;        // 0x80

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200031F
    public class LookAt : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> lookTarget;        // 0x68
        public System.Boolean repeat;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void OnUpdate() { }
        private System.Void DoLook() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000320
    public class RemoveComponent`1 : ActionTask`1
    {
        // Fields
        public System.Boolean immediately;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000321
    public class SetObjectActive : ActionTask`1
    {
        // Fields
        public NodeCanvas.Tasks.Actions.SetObjectActive.SetActiveMode setTo;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000323
    public class SetObjectEnabled : ActionTask`1
    {
        // Fields
        public NodeCanvas.Tasks.Actions.SetObjectEnabled.SetEnableMode setTo;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000325
    public class SetObjectVisibility : ActionTask`1
    {
        // Fields
        public NodeCanvas.Tasks.Actions.SetObjectVisibility.SetVisibleMode setTo;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000327
    public class GetInputAxis : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> xAxisName;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.String> yAxisName;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.String> zAxisName;        // 0x78
        public NodeCanvas.Framework.BBParameter<System.Single> multiplier;        // 0x80
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> saveAs;        // 0x88
        public NodeCanvas.Framework.BBParameter<System.Single> saveXAs;        // 0x90
        public NodeCanvas.Framework.BBParameter<System.Single> saveYAs;        // 0x98
        public NodeCanvas.Framework.BBParameter<System.Single> saveZAs;        // 0xA0
        public System.Boolean repeat;        // 0xA8

        // Methods
        private System.Void OnExecute() { }
        private System.Void OnUpdate() { }
        private System.Void Do() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000328
    public class GetMousePosition : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> saveAs;        // 0x68
        public System.Boolean repeat;        // 0x70

        // Methods
        private System.Void OnExecute() { }
        private System.Void OnUpdate() { }
        private System.Void Do() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000329
    public class GetMouseScrollDelta : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Single> saveAs;        // 0x68
        public System.Boolean repeat;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void OnUpdate() { }
        private System.Void Do() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200032A
    public class WaitMousePick : ActionTask
    {
        // Fields
        public NodeCanvas.Tasks.Actions.WaitMousePick.ButtonKeys buttonKey;        // 0x68
        public UnityEngine.LayerMask mask;        // 0x6C
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveObjectAs;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> saveDistanceAs;        // 0x78
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> savePositionAs;        // 0x80
        private System.Int32 buttonID;        // 0x88
        private UnityEngine.RaycastHit hit;        // 0x90

        // Methods
        private System.String get_info() { }
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200032C
    public class WaitMousePick2D : ActionTask
    {
        // Fields
        public NodeCanvas.Tasks.Actions.WaitMousePick2D.ButtonKeys buttonKey;        // 0x68
        public UnityEngine.LayerMask mask;        // 0x6C
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveObjectAs;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> saveDistanceAs;        // 0x78
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> savePositionAs;        // 0x80
        private System.Int32 buttonID;        // 0x88
        private UnityEngine.RaycastHit2D hit;        // 0x8C

        // Methods
        private System.String get_info() { }
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200032E
    public class CurveTransformTween : ActionTask`1
    {
        // Fields
        public NodeCanvas.Tasks.Actions.CurveTransformTween.TransformMode transformMode;        // 0x68
        public NodeCanvas.Tasks.Actions.CurveTransformTween.TweenMode mode;        // 0x6C
        public NodeCanvas.Tasks.Actions.CurveTransformTween.PlayMode playMode;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> targetPosition;        // 0x78
        public NodeCanvas.Framework.BBParameter<UnityEngine.AnimationCurve> curve;        // 0x80
        public NodeCanvas.Framework.BBParameter<System.Single> time;        // 0x88
        private UnityEngine.Vector3 original;        // 0x90
        private UnityEngine.Vector3 final;        // 0x9C
        private System.Boolean ponging;        // 0xA8

        // Methods
        private System.Void OnExecute() { }
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000332
    public class InputMove : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Single> strafe;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> turn;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> forward;        // 0x78
        public NodeCanvas.Framework.BBParameter<System.Single> up;        // 0x80
        public NodeCanvas.Framework.BBParameter<System.Single> moveSpeed;        // 0x88
        public NodeCanvas.Framework.BBParameter<System.Single> rotationSpeed;        // 0x90
        public System.Boolean repeat;        // 0x98

        // Methods
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000333
    public class MoveAway : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> target;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> speed;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> stopDistance;        // 0x78
        public System.Boolean waitActionFinish;        // 0x80

        // Methods
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000334
    public class MoveTowards : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> target;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> speed;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> stopDistance;        // 0x78
        public System.Boolean waitActionFinish;        // 0x80

        // Methods
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000335
    public class RotateAway : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> target;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> speed;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> angleDifference;        // 0x78
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> upVector;        // 0x80
        public System.Boolean waitActionFinish;        // 0x88

        // Methods
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000336
    public class RotateTowards : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> target;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> speed;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> angleDifference;        // 0x78
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> upVector;        // 0x80
        public System.Boolean waitActionFinish;        // 0x88

        // Methods
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000337
    public class FindClosestEdge : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> targetPosition;        // 0x68
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> saveFoundPosition;        // 0x70
        private UnityEngine.AI.NavMeshHit hit;        // 0x78

        // Methods
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000338
    public class GetLinecastInfo : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> target;        // 0x68
        public NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask> layerMask;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveHitGameObjectAs;        // 0x78
        public NodeCanvas.Framework.BBParameter<System.Single> saveDistanceAs;        // 0x80
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> savePointAs;        // 0x88
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> saveNormalAs;        // 0x90
        private UnityEngine.RaycastHit hit;        // 0x98

        // Methods
        private System.Void OnExecute() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000339
    public class GetLinecastInfo2D : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> target;        // 0x68
        public UnityEngine.LayerMask mask;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveHitGameObjectAs;        // 0x78
        public NodeCanvas.Framework.BBParameter<System.Single> saveDistanceAs;        // 0x80
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> savePointAs;        // 0x88
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> saveNormalAs;        // 0x90
        private UnityEngine.RaycastHit2D hit;        // 0x98

        // Methods
        private System.Void OnExecute() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200033A
    public class GetLinecastInfo2DAll : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> target;        // 0x68
        public UnityEngine.LayerMask mask;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> saveHitGameObjectsAs;        // 0x78
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<System.Single>> saveDistancesAs;        // 0x80
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.Vector3>> savePointsAs;        // 0x88
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.Vector3>> saveNormalsAs;        // 0x90
        private UnityEngine.RaycastHit2D[] hits;        // 0x98

        // Methods
        private System.Void OnExecute() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }
        private UnityEngine.Vector3 <OnExecute>b__7_2(UnityEngine.RaycastHit2D h) { }

    }

    // TypeToken: 0x200033C
    public class GetOverlapSphereObjects : ActionTask`1
    {
        // Fields
        public UnityEngine.LayerMask layerMask;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> radius;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> saveObjectsAs;        // 0x78

        // Methods
        private System.Void OnExecute() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200033E
    public class ExecuteFunction_Multiplatform : ActionTask, IReflectedWrapper
    {
        // Fields
        protected ParadoxNotion.Serialization.SerializedMethodInfo method;        // 0x68
        protected System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBObjectParameter> parameters;        // 0x70
        protected NodeCanvas.Framework.Internal.BBObjectParameter returnValue;        // 0x78
        private System.Object[] args;        // 0x80
        private System.Boolean routineRunning;        // 0x88
        private System.Boolean[] parameterIsByRef;        // 0x90

        // Methods
        private System.Reflection.MethodInfo get_targetMethod() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.String OnInit() { }
        private System.Void OnExecute() { }
        private System.Void OnStop() { }
        private System.Collections.IEnumerator InternalCoroutine(System.Collections.IEnumerator routine) { }
        private System.Void SetMethod(System.Reflection.MethodInfo method) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000340
    public class GetField_0
    {
        // Fields
        public System.Type targetType;        // 0x10
        public System.String fieldName;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000341
    public class GetField : ActionTask, IReflectedWrapper, IMigratable`1, IMigratable
    {
        // Fields
        protected ParadoxNotion.Serialization.SerializedFieldInfo field;        // 0x68
        protected NodeCanvas.Framework.Internal.BBObjectParameter saveAs;        // 0x70

        // Methods
        private System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Actions.GetField_0>.Migrate(NodeCanvas.Tasks.Actions.GetField_0 model) { }
        private System.Reflection.FieldInfo get_targetField() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.String OnInit() { }
        private System.Void OnExecute() { }
        private System.Void SetTargetField(System.Reflection.FieldInfo newField) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000342
    public class GetProperty_Multiplatform : ActionTask, IReflectedWrapper
    {
        // Fields
        protected ParadoxNotion.Serialization.SerializedMethodInfo method;        // 0x68
        protected NodeCanvas.Framework.Internal.BBObjectParameter returnValue;        // 0x70

        // Methods
        private System.Reflection.MethodInfo get_targetMethod() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.String OnInit() { }
        private System.Void OnExecute() { }
        private System.Void SetMethod(System.Reflection.MethodInfo method) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000343
    public class ImplementedAction_Multiplatform : ActionTask, IReflectedWrapper
    {
        // Fields
        private ParadoxNotion.Serialization.SerializedMethodInfo method;        // 0x68
        private System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBObjectParameter> parameters;        // 0x70
        private NodeCanvas.Framework.Status actionStatus;        // 0x78
        private System.Object[] args;        // 0x80

        // Methods
        private System.Reflection.MethodInfo get_targetMethod() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.String OnInit() { }
        private System.Void OnUpdate() { }
        private System.Void OnStop() { }
        private System.Void SetMethod(System.Reflection.MethodInfo method) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000344
    public class SendMessage : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> methodName;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000345
    public class SendMessage`1 : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> methodName;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> argument;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000346
    public class SendMessageToType`1 : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> message;        // 0x0
        public NodeCanvas.Framework.BBParameter<System.Object> argument;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000347
    public class SetField_0
    {
        // Fields
        public System.Type targetType;        // 0x10
        public System.String fieldName;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000348
    public class SetField : ActionTask, IReflectedWrapper, IMigratable`1, IMigratable
    {
        // Fields
        protected ParadoxNotion.Serialization.SerializedFieldInfo field;        // 0x68
        protected NodeCanvas.Framework.Internal.BBObjectParameter setValue;        // 0x70

        // Methods
        private System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Actions.SetField_0>.Migrate(NodeCanvas.Tasks.Actions.SetField_0 model) { }
        private System.Reflection.FieldInfo get_targetField() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.String OnInit() { }
        private System.Void OnExecute() { }
        private System.Void SetTargetField(System.Reflection.FieldInfo newField) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000349
    public class SetProperty_Multiplatform : ActionTask, IReflectedWrapper
    {
        // Fields
        protected ParadoxNotion.Serialization.SerializedMethodInfo method;        // 0x68
        protected NodeCanvas.Framework.Internal.BBObjectParameter parameter;        // 0x70

        // Methods
        private System.Reflection.MethodInfo get_targetMethod() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.String OnInit() { }
        private System.Void OnExecute() { }
        private System.Void SetMethod(System.Reflection.MethodInfo method) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200034A
    public class ExecuteFunction : ActionTask, IReflectedWrapper
    {
        // Fields
        protected NodeCanvas.Framework.Internal.ReflectedWrapper functionWrapper;        // 0x68
        private System.Boolean routineRunning;        // 0x70

        // Methods
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Reflection.MethodInfo get_targetMethod() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.String OnInit() { }
        private System.Void OnExecute() { }
        private System.Void OnStop() { }
        private System.Collections.IEnumerator InternalCoroutine(System.Collections.IEnumerator routine) { }
        private System.Void SetMethod(System.Reflection.MethodInfo method) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200034C
    public class GetProperty : ActionTask, IReflectedWrapper
    {
        // Fields
        protected NodeCanvas.Framework.Internal.ReflectedFunctionWrapper functionWrapper;        // 0x68

        // Methods
        private System.Reflection.MethodInfo get_targetMethod() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.String OnInit() { }
        private System.Void OnExecute() { }
        private System.Void SetMethod(System.Reflection.MethodInfo method) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200034D
    public class ImplementedAction : ActionTask, IReflectedWrapper
    {
        // Fields
        protected NodeCanvas.Framework.Internal.ReflectedFunctionWrapper functionWrapper;        // 0x68
        private NodeCanvas.Framework.Status actionStatus;        // 0x70

        // Methods
        private System.Reflection.MethodInfo get_targetMethod() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.String OnInit() { }
        private System.Void OnUpdate() { }
        private System.Void OnStop() { }
        private System.Void SetMethod(System.Reflection.MethodInfo method) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200034E
    public class SetProperty : ActionTask, IReflectedWrapper
    {
        // Fields
        protected NodeCanvas.Framework.Internal.ReflectedActionWrapper functionWrapper;        // 0x68

        // Methods
        private System.Reflection.MethodInfo get_targetMethod() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.String OnInit() { }
        private System.Void OnExecute() { }
        private System.Void SetMethod(System.Reflection.MethodInfo method) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200034F
    public class DebugBeep : ActionTask
    {
        // Methods
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000350
    public class DebugDrawLine : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> from;        // 0x68
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> to;        // 0x70
        public UnityEngine.Color color;        // 0x78
        public System.Single timeToShow;        // 0x88

        // Methods
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000351
    public class DebugLogText : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> log;        // 0x68
        public System.Single labelYOffset;        // 0x70
        public System.Single secondsToRun;        // 0x74
        public NodeCanvas.Tasks.Actions.DebugLogText.VerboseMode verboseMode;        // 0x78
        public NodeCanvas.Tasks.Actions.DebugLogText.LogMode logMode;        // 0x7C
        public ParadoxNotion.CompactStatus finishStatus;        // 0x80

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void OnStop() { }
        private System.Void OnUpdate() { }
        private System.Void OnGUI() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000354
    public class DebugLogVariable : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Object> log;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.String> prefix;        // 0x70
        public System.Single secondsToRun;        // 0x78
        public ParadoxNotion.CompactStatus finishStatus;        // 0x7C

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000355
    public class ForceFinishGraph : ActionTask
    {
        // Fields
        public ParadoxNotion.CompactStatus finishStatus;        // 0x68

        // Methods
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000356
    public class GraphOwnerControl : ActionTask`1
    {
        // Fields
        public NodeCanvas.Tasks.Actions.GraphOwnerControl.Control control;        // 0x68
        public System.Boolean waitActionFinish;        // 0x6C

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Collections.IEnumerator YieldDo() { }
        private System.Void Do() { }
        private System.Void OnStop() { }
        private System.Void .ctor() { }
        private System.Void <OnExecute>b__5_0(System.Boolean s) { }

    }

    // TypeToken: 0x2000359
    public class RunForever : ActionTask
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200035A
    public class SendEvent : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> eventName;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> delay;        // 0x70
        public System.Boolean sendGlobal;        // 0x78

        // Methods
        private System.String get_info() { }
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200035B
    public class SendEvent`1 : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> eventName;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> eventValue;        // 0x0
        public NodeCanvas.Framework.BBParameter<System.Single> delay;        // 0x0
        public System.Boolean sendGlobal;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200035C
    public class SendEventToObjects : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> targetObjects;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.String> eventName;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200035D
    public class SendEventToObjects`1 : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> targetObjects;        // 0x0
        public NodeCanvas.Framework.BBParameter<System.String> eventName;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> eventValue;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200035E
    public class ShoutEvent : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> eventName;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> shoutRange;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> completionTime;        // 0x78
        private NodeCanvas.Framework.GraphOwner[] owners;        // 0x80
        private System.Boolean[] receivedOwners;        // 0x88
        private System.Single traveledDistance;        // 0x90

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void OnUpdate() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200035F
    public class SwitchBehaviourTree : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<NodeCanvas.BehaviourTrees.BehaviourTree> behaviourTree;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000360
    public class SwitchFSM : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<NodeCanvas.StateMachines.FSM> fsm;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000361
    public class Wait : ActionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Single> waitTime;        // 0x68
        public ParadoxNotion.CompactStatus finishStatus;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000362
    public class CheckSpeed : ConditionTask`1
    {
        // Fields
        public ParadoxNotion.CompareMethod checkType;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> value;        // 0x70
        public System.Single differenceThreshold;        // 0x78

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000363
    public class ExecuteStaticFunction : ActionTask, ISubParametersContainer
    {
        // Fields
        protected NodeCanvas.Framework.Internal.ReflectedWrapper functionWrapper;        // 0x68

        // Methods
        private NodeCanvas.Framework.BBParameter[] NodeCanvas.Framework.ISubParametersContainer.GetSubParameters() { }
        private System.Reflection.MethodInfo get_targetMethod() { }
        private System.String get_info() { }
        private System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.String OnInit() { }
        private System.Void OnExecute() { }
        private System.Void SetMethod(System.Reflection.MethodInfo method) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000364
    public class ExecuteStaticFunction_Multiplatform : ActionTask
    {
        // Fields
        protected ParadoxNotion.Serialization.SerializedMethodInfo method;        // 0x68
        protected System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBObjectParameter> parameters;        // 0x70
        protected NodeCanvas.Framework.Internal.BBObjectParameter returnValue;        // 0x78

        // Methods
        private System.Reflection.MethodInfo get_targetMethod() { }
        private System.String get_info() { }
        private System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.String OnInit() { }
        private System.Void OnExecute() { }
        private System.Void SetMethod(System.Reflection.MethodInfo method) { }
        private System.Void .ctor() { }

    }

}

namespace NodeCanvas.Tasks.Conditions
{

    // TypeToken: 0x2000284
    public class InvokeSignal : ActionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<NodeCanvas.Framework.SignalDefinition> signalDefinition;        // 0x68
        public System.Boolean global;        // 0x70
        private System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Internal.BBObjectParameter> argumentsMap;        // 0x78
        private System.Object[] args;        // 0x80

        // Methods
        private System.String get_info() { }
        private System.String OnInit() { }
        private System.Void OnExecute() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000285
    public class MecanimCheckBool : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> parameter;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Boolean> value;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000286
    public class MecanimCheckFloat : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> parameter;        // 0x68
        public ParadoxNotion.CompareMethod comparison;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> value;        // 0x78

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000287
    public class MecanimCheckInt : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> parameter;        // 0x68
        public ParadoxNotion.CompareMethod comparison;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Int32> value;        // 0x78

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000288
    public class MecanimIsInTransition : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Int32> layerIndex;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000289
    public class CheckBoolean : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Boolean> valueA;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Boolean> valueB;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200028A
    public class CheckBooleanTrigger : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Boolean> trigger;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200028B
    public class CheckEnum : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.Internal.BBObjectParameter valueA;        // 0x68
        public NodeCanvas.Framework.Internal.BBObjectParameter valueB;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200028C
    public class CheckFloat : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Single> valueA;        // 0x68
        public ParadoxNotion.CompareMethod checkType;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> valueB;        // 0x78
        public System.Single differenceThreshold;        // 0x80

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200028D
    public class CheckInt : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Int32> valueA;        // 0x68
        public ParadoxNotion.CompareMethod checkType;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Int32> valueB;        // 0x78

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200028E
    public class CheckNull : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Object> variable;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200028F
    public class CheckString : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> valueA;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.String> valueB;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000290
    public class CheckUnityObject : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.Object> valueA;        // 0x68
        public NodeCanvas.Framework.BBParameter<UnityEngine.Object> valueB;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000291
    public class CheckVariable`1 : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<T> valueA;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> valueB;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000292
    public class CheckVectorDistance : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> vectorA;        // 0x68
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> vectorB;        // 0x70
        public ParadoxNotion.CompareMethod comparison;        // 0x78
        public NodeCanvas.Framework.BBParameter<System.Single> distance;        // 0x80

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000293
    public class TryGetValue`1 : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.Dictionary<System.String,T>> targetDictionary;        // 0x0
        public NodeCanvas.Framework.BBParameter<System.String> key;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> saveValueAs;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000294
    public class ListContainsElement`1 : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<T>> targetList;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> checkElement;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000295
    public class ListIsEmpty : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.IList> targetList;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000296
    public class BBVariableChanged : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.Internal.BBObjectParameter targetVariable;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.String OnInit() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Boolean OnCheck() { }
        private System.Void OnValueChanged(System.Object varValue) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000297
    public class StringContains : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> targetString;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.String> checkString;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000298
    public class CanSeeTarget : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> target;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> maxDistance;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask> layerMask;        // 0x78
        public NodeCanvas.Framework.BBParameter<System.Single> awarnessDistance;        // 0x80
        public NodeCanvas.Framework.BBParameter<System.Single> viewAngle;        // 0x88
        public UnityEngine.Vector3 offset;        // 0x90
        private UnityEngine.RaycastHit hit;        // 0xA0

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000299
    public class CanSeeTarget2D : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> target;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> maxDistance;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask> layerMask;        // 0x78
        public NodeCanvas.Framework.BBParameter<System.Single> awarnessDistance;        // 0x80
        public NodeCanvas.Framework.BBParameter<System.Single> viewAngle;        // 0x88
        public UnityEngine.Vector2 offset;        // 0x90
        private UnityEngine.RaycastHit2D hit;        // 0x98

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200029A
    public class CanSeeTargetAny : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> targetObjects;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> maxDistance;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask> layerMask;        // 0x78
        public NodeCanvas.Framework.BBParameter<System.Single> awarnessDistance;        // 0x80
        public NodeCanvas.Framework.BBParameter<System.Single> viewAngle;        // 0x88
        public UnityEngine.Vector3 offset;        // 0x90
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> allResults;        // 0xA0
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> closerResult;        // 0xA8
        private UnityEngine.RaycastHit hit;        // 0xB0

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }
        private System.Single <OnCheck>b__11_0(UnityEngine.GameObject x) { }

    }

    // TypeToken: 0x200029B
    public class CanSeeTargetAny2D : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> targetObjects;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> maxDistance;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask> layerMask;        // 0x78
        public NodeCanvas.Framework.BBParameter<System.Single> awarnessDistance;        // 0x80
        public NodeCanvas.Framework.BBParameter<System.Single> viewAngle;        // 0x88
        public UnityEngine.Vector2 offset;        // 0x90
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> allResults;        // 0x98
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> closerResult;        // 0xA0

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }
        private System.Single <OnCheck>b__10_0(UnityEngine.GameObject x) { }

    }

    // TypeToken: 0x200029C
    public class CheckDistanceToGameObject : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> checkTarget;        // 0x68
        public ParadoxNotion.CompareMethod checkType;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> distance;        // 0x78
        public System.Single floatingPoint;        // 0x80

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200029D
    public class CheckDistanceToGameObject2D : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> checkTarget;        // 0x68
        public ParadoxNotion.CompareMethod checkType;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> distance;        // 0x78
        public System.Single floatingPoint;        // 0x80

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200029E
    public class CheckDistanceToGameObjectAny : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> targetObjects;        // 0x68
        public ParadoxNotion.CompareMethod checkType;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> distance;        // 0x78
        public System.Single floatingPoint;        // 0x80
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> allResults;        // 0x88
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> closerResult;        // 0x90

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }
        private System.Single <OnCheck>b__8_0(UnityEngine.GameObject x) { }

    }

    // TypeToken: 0x200029F
    public class CheckDistanceToGameObjectAny2D : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> targetObjects;        // 0x68
        public ParadoxNotion.CompareMethod checkType;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> distance;        // 0x78
        public System.Single floatingPoint;        // 0x80
        public NodeCanvas.Framework.BBParameter<System.Collections.Generic.List<UnityEngine.GameObject>> allResults;        // 0x88
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> closerResult;        // 0x90

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }
        private System.Single <OnCheck>b__8_0(UnityEngine.GameObject x) { }

    }

    // TypeToken: 0x20002A0
    public class CheckLOS : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> LOSTarget;        // 0x68
        public NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask> layerMask;        // 0x70
        public UnityEngine.Vector3 offset;        // 0x78
        public NodeCanvas.Framework.BBParameter<System.Single> saveDistanceAs;        // 0x88
        private UnityEngine.RaycastHit hit;        // 0x90

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002A1
    public class CheckLOS2D : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> LOSTarget;        // 0x68
        public NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask> layerMask;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> saveDistanceAs;        // 0x78
        protected UnityEngine.Collider2D agentCollider;        // 0x80
        private UnityEngine.RaycastHit2D[] hits;        // 0x88

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002A3
    public class HasComponent`1 : ConditionTask`1
    {
        // Methods
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002A4
    public class IsActive : ConditionTask`1
    {
        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002A5
    public class IsInFront : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> checkTarget;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> viewAngle;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002A6
    public class IsInFront2D : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> checkTarget;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> viewAngle;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnDrawGizmosSelected() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002A7
    public class IsWithinLayerMask : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.LayerMask> targetLayers;        // 0x68

        // Methods
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002A8
    public class CheckButtonInput : ConditionTask
    {
        // Fields
        public ParadoxNotion.PressTypes pressType;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.String> buttonName;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002A9
    public class CheckKeyboardInput : ConditionTask
    {
        // Fields
        public ParadoxNotion.PressTypes pressType;        // 0x68
        public UnityEngine.KeyCode key;        // 0x6C

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002AA
    public class CheckMousePick : ConditionTask
    {
        // Fields
        public ParadoxNotion.ButtonKeys buttonKey;        // 0x68
        public System.Int32 layer;        // 0x6C
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveGoAs;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> saveDistanceAs;        // 0x78
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> savePosAs;        // 0x80
        private UnityEngine.RaycastHit hit;        // 0x88

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002AB
    public class CheckMousePick2D : ConditionTask
    {
        // Fields
        public ParadoxNotion.ButtonKeys buttonKey;        // 0x68
        public UnityEngine.LayerMask mask;        // 0x6C
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveGoAs;        // 0x70
        public NodeCanvas.Framework.BBParameter<System.Single> saveDistanceAs;        // 0x78
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> savePosAs;        // 0x80
        private System.Int32 buttonID;        // 0x88
        private UnityEngine.RaycastHit2D hit;        // 0x8C

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002AC
    public class CheckCSharpEvent_0
    {
        // Fields
        public System.Type targetType;        // 0x10
        public System.String eventName;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002AD
    public class CheckCSharpEvent_0`1
    {
        // Fields
        public System.Type targetType;        // 0x0
        public System.String eventName;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002AE
    public class CheckCSharpEventValue_0`1
    {
        // Fields
        public System.Type targetType;        // 0x0
        public System.String eventName;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002AF
    public class CheckStaticCSharpEvent
    {
        // Fields
        public System.Type targetType;        // 0x10
        public System.String eventName;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002B0
    public class CheckStaticCSharpEvent`1
    {
        // Fields
        public System.Type targetType;        // 0x0
        public System.String eventName;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002B1
    public class CheckCSharpEvent : ConditionTask, IReflectedWrapper, IMigratable`1, IMigratable, IMigratable`1
    {
        // Fields
        private ParadoxNotion.Serialization.SerializedEventInfo eventInfo;        // 0x68
        private System.Delegate handler;        // 0x70

        // Methods
        private System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0>.Migrate(NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0 model) { }
        private System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent>.Migrate(NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent model) { }
        private System.Reflection.EventInfo get_targetEvent() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.String OnInit() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Raised() { }
        private System.Boolean OnCheck() { }
        private System.Void SetTargetEvent(System.Reflection.EventInfo info) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002B2
    public class CheckCSharpEvent`1 : ConditionTask, IReflectedWrapper, IMigratable`1, IMigratable, IMigratable`1
    {
        // Fields
        private ParadoxNotion.Serialization.SerializedEventInfo eventInfo;        // 0x0
        private NodeCanvas.Framework.BBParameter<T> saveAs;        // 0x0
        private System.Delegate handler;        // 0x0

        // Methods
        private System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0<T>>.Migrate(NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0<T> model) { }
        private System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent<T>>.Migrate(NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent<T> model) { }
        private System.Reflection.EventInfo get_targetEvent() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.String OnInit() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Raised(T eventValue) { }
        private System.Boolean OnCheck() { }
        private System.Void SetTargetEvent(System.Reflection.EventInfo info) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002B3
    public class CheckCSharpEventValue`1 : ConditionTask, IReflectedWrapper, IMigratable`1, IMigratable
    {
        // Fields
        private ParadoxNotion.Serialization.SerializedEventInfo eventInfo;        // 0x0
        private NodeCanvas.Framework.BBParameter<T> checkValue;        // 0x0
        private System.Delegate handler;        // 0x0

        // Methods
        private System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEventValue_0<T>>.Migrate(NodeCanvas.Tasks.Conditions.CheckCSharpEventValue_0<T> model) { }
        private System.Reflection.EventInfo get_targetEvent() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.String OnInit() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Raised(T eventValue) { }
        private System.Boolean OnCheck() { }
        private System.Void SetTargetEvent(System.Reflection.EventInfo info) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002B4
    public class CheckField_0
    {
        // Fields
        public NodeCanvas.Framework.BBParameter checkValue;        // 0x10
        public System.Type targetType;        // 0x18
        public System.String fieldName;        // 0x20

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002B5
    public class CheckField : ConditionTask, IReflectedWrapper, IMigratable`1, IMigratable
    {
        // Fields
        protected NodeCanvas.Framework.Internal.BBObjectParameter checkValue;        // 0x68
        protected ParadoxNotion.CompareMethod comparison;        // 0x70
        protected ParadoxNotion.Serialization.SerializedFieldInfo field;        // 0x78

        // Methods
        private System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckField_0>.Migrate(NodeCanvas.Tasks.Conditions.CheckField_0 model) { }
        private System.Reflection.FieldInfo get_targetField() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.String OnInit() { }
        private System.Boolean OnCheck() { }
        private System.Void SetTargetField(System.Reflection.FieldInfo newField) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002B6
    public class CheckFunction_Multiplatform : ConditionTask, IReflectedWrapper
    {
        // Fields
        protected ParadoxNotion.Serialization.SerializedMethodInfo method;        // 0x68
        protected System.Collections.Generic.List<NodeCanvas.Framework.Internal.BBObjectParameter> parameters;        // 0x70
        protected ParadoxNotion.CompareMethod comparison;        // 0x78
        protected NodeCanvas.Framework.Internal.BBObjectParameter checkValue;        // 0x80
        private System.Object[] args;        // 0x88
        private System.Boolean[] parameterIsByRef;        // 0x90

        // Methods
        private System.Reflection.MethodInfo get_targetMethod() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.String OnInit() { }
        private System.Boolean OnCheck() { }
        private System.Void SetMethod(System.Reflection.MethodInfo method) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002B7
    public class CheckProperty_Multiplatform : ConditionTask, IReflectedWrapper
    {
        // Fields
        protected ParadoxNotion.Serialization.SerializedMethodInfo method;        // 0x68
        protected NodeCanvas.Framework.Internal.BBObjectParameter checkValue;        // 0x70
        protected ParadoxNotion.CompareMethod comparison;        // 0x78

        // Methods
        private System.Reflection.MethodInfo get_targetMethod() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.String OnInit() { }
        private System.Boolean OnCheck() { }
        private System.Void SetMethod(System.Reflection.MethodInfo method) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002B8
    public class CheckUnityEvent_0
    {
        // Fields
        public System.Type targetType;        // 0x10
        public System.String eventName;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002B9
    public class CheckUnityEvent_0`1
    {
        // Fields
        public System.Type targetType;        // 0x0
        public System.String eventName;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002BA
    public class CheckUnityEventValue_0`1
    {
        // Fields
        public System.Type targetType;        // 0x0
        public System.String eventName;        // 0x0

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002BB
    public class CheckUnityEvent : ConditionTask, IReflectedWrapper, IMigratable`1, IMigratable
    {
        // Fields
        private ParadoxNotion.Serialization.SerializedUnityEventInfo _eventInfo;        // 0x68
        private UnityEngine.Events.UnityEvent unityEvent;        // 0x70

        // Methods
        private System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEvent_0>.Migrate(NodeCanvas.Tasks.Conditions.CheckUnityEvent_0 model) { }
        private System.Reflection.MemberInfo get_targetMember() { }
        private System.Boolean get_isStatic() { }
        private System.Type get_eventType() { }
        private System.Reflection.FieldInfo get_targetEventField() { }
        private System.Reflection.PropertyInfo get_targetEventProp() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.String OnInit() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Raised() { }
        private System.Boolean OnCheck() { }
        private System.Void SetTargetEvent(System.Reflection.MemberInfo newMember) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002BC
    public class CheckUnityEvent`1 : ConditionTask, IReflectedWrapper, IMigratable`1, IMigratable
    {
        // Fields
        private ParadoxNotion.Serialization.SerializedUnityEventInfo _eventInfo;        // 0x0
        private NodeCanvas.Framework.BBParameter<T> saveAs;        // 0x0
        private UnityEngine.Events.UnityEvent<T> unityEvent;        // 0x0

        // Methods
        private System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEvent_0<T>>.Migrate(NodeCanvas.Tasks.Conditions.CheckUnityEvent_0<T> model) { }
        private System.Reflection.MemberInfo get_targetMember() { }
        private System.Boolean get_isStatic() { }
        private System.Type get_eventType() { }
        private System.Reflection.FieldInfo get_targetEventField() { }
        private System.Reflection.PropertyInfo get_targetEventProp() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.String OnInit() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Raised(T eventValue) { }
        private System.Boolean OnCheck() { }
        private System.Void SetTargetEvent(System.Reflection.MemberInfo newMember) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002BD
    public class CheckUnityEventValue`1 : ConditionTask, IReflectedWrapper, IMigratable`1, IMigratable
    {
        // Fields
        private ParadoxNotion.Serialization.SerializedUnityEventInfo _eventInfo;        // 0x0
        private NodeCanvas.Framework.BBParameter<T> checkValue;        // 0x0
        private UnityEngine.Events.UnityEvent<T> unityEvent;        // 0x0

        // Methods
        private System.Void ParadoxNotion.Serialization.FullSerializer.IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEventValue_0<T>>.Migrate(NodeCanvas.Tasks.Conditions.CheckUnityEventValue_0<T> model) { }
        private System.Reflection.MemberInfo get_targetMember() { }
        private System.Boolean get_isStatic() { }
        private System.Type get_eventType() { }
        private System.Reflection.FieldInfo get_targetEventField() { }
        private System.Reflection.PropertyInfo get_targetEventProp() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private ParadoxNotion.Serialization.ISerializedReflectedInfo NodeCanvas.Framework.IReflectedWrapper.GetSerializedInfo() { }
        private System.String OnInit() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Raised(T eventValue) { }
        private System.Boolean OnCheck() { }
        private System.Void SetTargetEvent(System.Reflection.MemberInfo newMember) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002BE
    public class CheckFunction : ConditionTask
    {
        // Fields
        protected NodeCanvas.Framework.Internal.ReflectedFunctionWrapper functionWrapper;        // 0x68
        protected NodeCanvas.Framework.BBParameter checkValue;        // 0x70
        protected ParadoxNotion.CompareMethod comparison;        // 0x78

        // Methods
        private System.Reflection.MethodInfo get_targetMethod() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.String OnInit() { }
        private System.Boolean OnCheck() { }
        private System.Void SetMethod(System.Reflection.MethodInfo method) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002BF
    public class CheckProperty : ConditionTask
    {
        // Fields
        protected NodeCanvas.Framework.Internal.ReflectedFunctionWrapper functionWrapper;        // 0x68
        protected NodeCanvas.Framework.BBParameter checkValue;        // 0x70
        protected ParadoxNotion.CompareMethod comparison;        // 0x78

        // Methods
        private System.Reflection.MethodInfo get_targetMethod() { }
        private System.Type get_agentType() { }
        private System.String get_info() { }
        private System.Void OnValidate(NodeCanvas.Framework.ITaskSystem ownerSystem) { }
        private System.String OnInit() { }
        private System.Boolean OnCheck() { }
        private System.Void SetMethod(System.Reflection.MethodInfo method) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002C0
    public class CheckCollision_Rigidbody : ConditionTask`1
    {
        // Fields
        public ParadoxNotion.CollisionTypes checkType;        // 0x68
        public System.Boolean specifiedTagOnly;        // 0x6C
        public System.String objectTag;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveGameObjectAs;        // 0x78
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> saveContactPoint;        // 0x80
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> saveContactNormal;        // 0x88
        private System.Boolean stay;        // 0x90

        // Methods
        private System.String get_info() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Boolean OnCheck() { }
        private System.Void OnCollisionEnter(ParadoxNotion.EventData<UnityEngine.Collision> data) { }
        private System.Void OnCollisionExit(ParadoxNotion.EventData<UnityEngine.Collision> data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002C1
    public class CheckCollision : ConditionTask`1
    {
        // Fields
        public ParadoxNotion.CollisionTypes checkType;        // 0x68
        public System.Boolean specifiedTagOnly;        // 0x6C
        public System.String objectTag;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveGameObjectAs;        // 0x78
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> saveContactPoint;        // 0x80
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> saveContactNormal;        // 0x88
        private System.Boolean stay;        // 0x90

        // Methods
        private System.String get_info() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Boolean OnCheck() { }
        private System.Void OnCollisionEnter(ParadoxNotion.EventData<UnityEngine.Collision> data) { }
        private System.Void OnCollisionExit(ParadoxNotion.EventData<UnityEngine.Collision> data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002C2
    public class CheckCollision2D_Rigidbody : ConditionTask`1
    {
        // Fields
        public ParadoxNotion.CollisionTypes checkType;        // 0x68
        public System.Boolean specifiedTagOnly;        // 0x6C
        public System.String objectTag;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveGameObjectAs;        // 0x78
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> saveContactPoint;        // 0x80
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> saveContactNormal;        // 0x88
        private System.Boolean stay;        // 0x90

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnCollisionEnter2D(ParadoxNotion.EventData<UnityEngine.Collision2D> data) { }
        private System.Void OnCollisionExit2D(ParadoxNotion.EventData<UnityEngine.Collision2D> data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002C3
    public class CheckCollision2D : ConditionTask`1
    {
        // Fields
        public ParadoxNotion.CollisionTypes checkType;        // 0x68
        public System.Boolean specifiedTagOnly;        // 0x6C
        public System.String objectTag;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveGameObjectAs;        // 0x78
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> saveContactPoint;        // 0x80
        public NodeCanvas.Framework.BBParameter<UnityEngine.Vector3> saveContactNormal;        // 0x88
        private System.Boolean stay;        // 0x90

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnCollisionEnter2D(ParadoxNotion.EventData<UnityEngine.Collision2D> data) { }
        private System.Void OnCollisionExit2D(ParadoxNotion.EventData<UnityEngine.Collision2D> data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002C4
    public class CheckMouse : ConditionTask`1
    {
        // Fields
        public ParadoxNotion.MouseInteractionTypes checkType;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnMouseEnter(ParadoxNotion.EventData msg) { }
        private System.Void OnMouseExit(ParadoxNotion.EventData msg) { }
        private System.Void OnMouseOver(ParadoxNotion.EventData msg) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002C5
    public class CheckMouse2D : ConditionTask`1
    {
        // Fields
        public ParadoxNotion.MouseInteractionTypes checkType;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Boolean OnCheck() { }
        private System.Void OnMouseEnter(ParadoxNotion.EventData msg) { }
        private System.Void OnMouseExit(ParadoxNotion.EventData msg) { }
        private System.Void OnMouseOver(ParadoxNotion.EventData msg) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002C6
    public class CheckMouseClick : ConditionTask`1
    {
        // Fields
        public ParadoxNotion.MouseClickEvent checkType;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnMouseDown(ParadoxNotion.EventData msg) { }
        private System.Void OnMouseUp(ParadoxNotion.EventData msg) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002C7
    public class CheckMouseClick2D : ConditionTask`1
    {
        // Fields
        public ParadoxNotion.MouseClickEvent checkType;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnMouseDown(ParadoxNotion.EventData msg) { }
        private System.Void OnMouseUp(ParadoxNotion.EventData msg) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002C8
    public class CheckTrigger_Transform : ConditionTask`1
    {
        // Fields
        public ParadoxNotion.TriggerTypes checkType;        // 0x68
        public System.Boolean specifiedTagOnly;        // 0x6C
        public System.String objectTag;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveGameObjectAs;        // 0x78
        private System.Boolean stay;        // 0x80

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnTriggerEnter(ParadoxNotion.EventData<UnityEngine.Collider> data) { }
        private System.Void OnTriggerExit(ParadoxNotion.EventData<UnityEngine.Collider> data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002C9
    public class CheckTrigger : ConditionTask`1
    {
        // Fields
        public ParadoxNotion.TriggerTypes checkType;        // 0x68
        public System.Boolean specifiedTagOnly;        // 0x6C
        public System.String objectTag;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveGameObjectAs;        // 0x78
        private System.Boolean stay;        // 0x80

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnTriggerEnter(ParadoxNotion.EventData<UnityEngine.Collider> data) { }
        private System.Void OnTriggerExit(ParadoxNotion.EventData<UnityEngine.Collider> data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002CA
    public class CheckTrigger2D_Transform : ConditionTask`1
    {
        // Fields
        public ParadoxNotion.TriggerTypes CheckType;        // 0x68
        public System.Boolean specifiedTagOnly;        // 0x6C
        public System.String objectTag;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveGameObjectAs;        // 0x78
        private System.Boolean stay;        // 0x80

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnTriggerEnter2D(ParadoxNotion.EventData<UnityEngine.Collider2D> data) { }
        private System.Void OnTriggerExit2D(ParadoxNotion.EventData<UnityEngine.Collider2D> data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002CB
    public class CheckTrigger2D : ConditionTask`1
    {
        // Fields
        public ParadoxNotion.TriggerTypes CheckType;        // 0x68
        public System.Boolean specifiedTagOnly;        // 0x6C
        public System.String objectTag;        // 0x70
        public NodeCanvas.Framework.BBParameter<UnityEngine.GameObject> saveGameObjectAs;        // 0x78
        private System.Boolean stay;        // 0x80

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnTriggerEnter2D(ParadoxNotion.EventData<UnityEngine.Collider2D> data) { }
        private System.Void OnTriggerExit2D(ParadoxNotion.EventData<UnityEngine.Collider2D> data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002CC
    public class ButtonClicked : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<UnityEngine.UI.Button> button;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.String OnInit() { }
        private System.Boolean OnCheck() { }
        private System.Void OnClick() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002CD
    public class InterceptEvent : ConditionTask`1
    {
        // Fields
        public UnityEngine.EventSystems.EventTriggerType eventType;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Boolean OnCheck() { }
        private System.Void OnPointerEnter(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> data) { }
        private System.Void OnPointerExit(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> data) { }
        private System.Void OnPointerDown(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> data) { }
        private System.Void OnPointerUp(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> data) { }
        private System.Void OnPointerClick(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> data) { }
        private System.Void OnDrag(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> data) { }
        private System.Void OnDrop(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> eventData) { }
        private System.Void OnScroll(ParadoxNotion.EventData<UnityEngine.EventSystems.PointerEventData> data) { }
        private System.Void OnUpdateSelected(ParadoxNotion.EventData<UnityEngine.EventSystems.BaseEventData> eventData) { }
        private System.Void OnSelect(ParadoxNotion.EventData<UnityEngine.EventSystems.BaseEventData> eventData) { }
        private System.Void OnDeselect(ParadoxNotion.EventData<UnityEngine.EventSystems.BaseEventData> eventData) { }
        private System.Void OnMove(ParadoxNotion.EventData<UnityEngine.EventSystems.AxisEventData> eventData) { }
        private System.Void OnSubmit(ParadoxNotion.EventData<UnityEngine.EventSystems.BaseEventData> eventData) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002CE
    public class CheckEvent : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> eventName;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Boolean OnCheck() { }
        private System.Void OnCustomEvent(System.String eventName, ParadoxNotion.IEventData data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002CF
    public class CheckEvent`1 : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> eventName;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> saveEventValue;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Boolean OnCheck() { }
        private System.Void OnCustomEvent(System.String eventName, ParadoxNotion.IEventData data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002D0
    public class CheckEventValue`1 : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.String> eventName;        // 0x0
        public NodeCanvas.Framework.BBParameter<T> value;        // 0x0

        // Methods
        private System.String get_info() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Boolean OnCheck() { }
        private System.Void OnCustomEvent(System.String eventName, ParadoxNotion.IEventData msg) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002D1
    public class CheckSignal : ConditionTask`1
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<NodeCanvas.Framework.SignalDefinition> signalDefinition;        // 0x68
        private System.Collections.Generic.Dictionary<System.String,NodeCanvas.Framework.Internal.BBObjectParameter> argumentsMap;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.String OnInit() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnSignalInvoke(UnityEngine.Transform sender, UnityEngine.Transform receiver, System.Boolean isGlobal, System.Object[] args) { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002D2
    public class CheckStateStatus : ConditionTask
    {
        // Fields
        public ParadoxNotion.CompactStatus status;        // 0x68

        // Methods
        private System.String get_info() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002D3
    public class DebugCondition : ConditionTask
    {
        // Methods
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002D4
    public class Probability : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Single> probability;        // 0x68
        public NodeCanvas.Framework.BBParameter<System.Single> maxValue;        // 0x70
        private System.Boolean success;        // 0x78

        // Methods
        private System.String get_info() { }
        private System.Void OnEnable() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20002D5
    public class Timeout : ConditionTask
    {
        // Fields
        public NodeCanvas.Framework.BBParameter<System.Single> timeout;        // 0x68
        private System.Single currentTime;        // 0x70

        // Methods
        private System.String get_info() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void MoveNext() { }
        private System.Boolean OnCheck() { }
        private System.Void .ctor() { }

    }

}

namespace ParadoxNotion
{

    // TypeToken: 0x2000471
    public class ActionCall : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000472
    public class ActionCall`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 a) { }
        private System.IAsyncResult BeginInvoke(T1 a, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000473
    public class ActionCall`2 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 a, T2 b) { }
        private System.IAsyncResult BeginInvoke(T1 a, T2 b, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000474
    public class ActionCall`3 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 a, T2 b, T3 c) { }
        private System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000475
    public class ActionCall`4 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 a, T2 b, T3 c, T4 d) { }
        private System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000476
    public class ActionCall`5 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e) { }
        private System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, T5 e, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000477
    public class ActionCall`6 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f) { }
        private System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000478
    public class ActionCall`7 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) { }
        private System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000479
    public class ActionCall`8 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h) { }
        private System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, System.AsyncCallback callback, System.Object object) { }
        private System.Void EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200047A
    public class FunctionCall`1 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke() { }
        private System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object) { }
        private TResult EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200047B
    public class FunctionCall`2 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 a) { }
        private System.IAsyncResult BeginInvoke(T1 a, System.AsyncCallback callback, System.Object object) { }
        private TResult EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200047C
    public class FunctionCall`3 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 a, T2 b) { }
        private System.IAsyncResult BeginInvoke(T1 a, T2 b, System.AsyncCallback callback, System.Object object) { }
        private TResult EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200047D
    public class FunctionCall`4 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 a, T2 b, T3 c) { }
        private System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, System.AsyncCallback callback, System.Object object) { }
        private TResult EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200047E
    public class FunctionCall`5 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d) { }
        private System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, System.AsyncCallback callback, System.Object object) { }
        private TResult EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x200047F
    public class FunctionCall`6 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e) { }
        private System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, T5 e, System.AsyncCallback callback, System.Object object) { }
        private TResult EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000480
    public class FunctionCall`7 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f) { }
        private System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, System.AsyncCallback callback, System.Object object) { }
        private TResult EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000481
    public class FunctionCall`8 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g) { }
        private System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, System.AsyncCallback callback, System.Object object) { }
        private TResult EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000482
    public class FunctionCall`9 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h) { }
        private System.IAsyncResult BeginInvoke(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, System.AsyncCallback callback, System.Object object) { }
        private TResult EndInvoke(System.IAsyncResult result) { }

    }

    // TypeToken: 0x2000483
    public class DynamicParameterDefinition, ISerializationCallbackReceiver
    {
        // Fields
        private System.String _ID;        // 0x10
        private System.String _name;        // 0x18
        private System.String _type;        // 0x20
        private System.Type <type>k__BackingField;        // 0x28

        // Methods
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.String get_ID() { }
        private System.Void set_ID(System.String value) { }
        private System.String get_name() { }
        private System.Void set_name(System.String value) { }
        private System.Type get_type() { }
        private System.Void set_type(System.Type value) { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name, System.Type type) { }

    }

    // TypeToken: 0x2000484
    public struct CompareMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.CompareMethod EqualTo;        // 0x0
        public static ParadoxNotion.CompareMethod GreaterThan;        // 0x0
        public static ParadoxNotion.CompareMethod LessThan;        // 0x0
        public static ParadoxNotion.CompareMethod GreaterOrEqualTo;        // 0x0
        public static ParadoxNotion.CompareMethod LessOrEqualTo;        // 0x0

    }

    // TypeToken: 0x2000485
    public struct OperationMethod
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.OperationMethod Set;        // 0x0
        public static ParadoxNotion.OperationMethod Add;        // 0x0
        public static ParadoxNotion.OperationMethod Subtract;        // 0x0
        public static ParadoxNotion.OperationMethod Multiply;        // 0x0
        public static ParadoxNotion.OperationMethod Divide;        // 0x0

    }

    // TypeToken: 0x2000486
    public struct ButtonKeys
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.ButtonKeys Left;        // 0x0
        public static ParadoxNotion.ButtonKeys Right;        // 0x0
        public static ParadoxNotion.ButtonKeys Middle;        // 0x0

    }

    // TypeToken: 0x2000487
    public struct PressTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.PressTypes Down;        // 0x0
        public static ParadoxNotion.PressTypes Up;        // 0x0
        public static ParadoxNotion.PressTypes Pressed;        // 0x0

    }

    // TypeToken: 0x2000488
    public struct MouseClickEvent
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.MouseClickEvent MouseDown;        // 0x0
        public static ParadoxNotion.MouseClickEvent MouseUp;        // 0x0

    }

    // TypeToken: 0x2000489
    public struct TriggerTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.TriggerTypes TriggerEnter;        // 0x0
        public static ParadoxNotion.TriggerTypes TriggerExit;        // 0x0
        public static ParadoxNotion.TriggerTypes TriggerStay;        // 0x0

    }

    // TypeToken: 0x200048A
    public struct CollisionTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.CollisionTypes CollisionEnter;        // 0x0
        public static ParadoxNotion.CollisionTypes CollisionExit;        // 0x0
        public static ParadoxNotion.CollisionTypes CollisionStay;        // 0x0

    }

    // TypeToken: 0x200048B
    public struct MouseInteractionTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.MouseInteractionTypes MouseEnter;        // 0x0
        public static ParadoxNotion.MouseInteractionTypes MouseExit;        // 0x0
        public static ParadoxNotion.MouseInteractionTypes MouseOver;        // 0x0

    }

    // TypeToken: 0x200048C
    public struct CompactStatus
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.CompactStatus Failure;        // 0x0
        public static ParadoxNotion.CompactStatus Success;        // 0x0

    }

    // TypeToken: 0x200048D
    public struct PlayDirections
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.PlayDirections Forward;        // 0x0
        public static ParadoxNotion.PlayDirections Backward;        // 0x0
        public static ParadoxNotion.PlayDirections Toggle;        // 0x0

    }

    // TypeToken: 0x200048E
    public struct PlanarDirection
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.PlanarDirection Horizontal;        // 0x0
        public static ParadoxNotion.PlanarDirection Vertical;        // 0x0
        public static ParadoxNotion.PlanarDirection Auto;        // 0x0

    }

    // TypeToken: 0x200048F
    public struct Alignment2x2
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.Alignment2x2 Default;        // 0x0
        public static ParadoxNotion.Alignment2x2 Left;        // 0x0
        public static ParadoxNotion.Alignment2x2 Right;        // 0x0
        public static ParadoxNotion.Alignment2x2 Top;        // 0x0
        public static ParadoxNotion.Alignment2x2 Bottom;        // 0x0

    }

    // TypeToken: 0x2000490
    public struct Alignment3x3
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.Alignment3x3 TopLeft;        // 0x0
        public static ParadoxNotion.Alignment3x3 TopCenter;        // 0x0
        public static ParadoxNotion.Alignment3x3 TopRight;        // 0x0
        public static ParadoxNotion.Alignment3x3 MiddleLeft;        // 0x0
        public static ParadoxNotion.Alignment3x3 MiddleCenter;        // 0x0
        public static ParadoxNotion.Alignment3x3 MiddleRight;        // 0x0
        public static ParadoxNotion.Alignment3x3 BottomLeft;        // 0x0
        public static ParadoxNotion.Alignment3x3 BottomCenter;        // 0x0
        public static ParadoxNotion.Alignment3x3 BottomRight;        // 0x0

    }

    // TypeToken: 0x2000491
    public class HierarchyTree
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000494
    public interface IEventData
    {
        // Methods
        private UnityEngine.GameObject get_receiver() { }
        private System.Object get_sender() { }
        private System.Object get_valueBoxed() { }

    }

    // TypeToken: 0x2000495
    public struct EventData, IEventData
    {
        // Fields
        private UnityEngine.GameObject <receiver>k__BackingField;        // 0x10
        private System.Object <sender>k__BackingField;        // 0x18
        private System.Object <value>k__BackingField;        // 0x20

        // Methods
        private UnityEngine.GameObject get_receiver() { }
        private System.Void set_receiver(UnityEngine.GameObject value) { }
        private System.Object get_sender() { }
        private System.Void set_sender(System.Object value) { }
        private System.Object get_value() { }
        private System.Void set_value(System.Object value) { }
        private System.Object get_valueBoxed() { }
        private System.Void .ctor(System.Object value, UnityEngine.GameObject receiver, System.Object sender) { }
        private System.Void .ctor(UnityEngine.GameObject receiver, System.Object sender) { }

    }

    // TypeToken: 0x2000496
    public struct EventData`1, IEventData
    {
        // Fields
        private UnityEngine.GameObject <receiver>k__BackingField;        // 0x0
        private System.Object <sender>k__BackingField;        // 0x0
        private T <value>k__BackingField;        // 0x0

        // Methods
        private UnityEngine.GameObject get_receiver() { }
        private System.Void set_receiver(UnityEngine.GameObject value) { }
        private System.Object get_sender() { }
        private System.Void set_sender(System.Object value) { }
        private T get_value() { }
        private System.Void set_value(T value) { }
        private System.Object get_valueBoxed() { }
        private System.Void .ctor(T value, UnityEngine.GameObject receiver, System.Object sender) { }

    }

    // TypeToken: 0x2000497
    public class OperationTools
    {
        // Methods
        private System.String GetOperationString(ParadoxNotion.OperationMethod om) { }
        private System.Single Operate(System.Single a, System.Single b, ParadoxNotion.OperationMethod om, System.Single delta) { }
        private System.Int32 Operate(System.Int32 a, System.Int32 b, ParadoxNotion.OperationMethod om) { }
        private UnityEngine.Vector3 Operate(UnityEngine.Vector3 a, UnityEngine.Vector3 b, ParadoxNotion.OperationMethod om, System.Single delta) { }
        private System.String GetCompareString(ParadoxNotion.CompareMethod cm) { }
        private System.Boolean Compare(System.Single a, System.Single b, ParadoxNotion.CompareMethod cm, System.Single floatingPoint) { }
        private System.Boolean Compare(System.Int32 a, System.Int32 b, ParadoxNotion.CompareMethod cm) { }

    }

    // TypeToken: 0x2000498
    public class ReflectionTools
    {
        // Fields
        public static System.Reflection.BindingFlags FLAGS_ALL;        // 0x0
        public static System.Reflection.BindingFlags FLAGS_ALL_DECLARED;        // 0x0
        private static System.Reflection.Assembly[] _loadedAssemblies;        // 0x0
        private static System.Type[] _allTypes;        // 0x8
        private static System.Object[] _tempArgs;        // 0x10
        private static System.Collections.Generic.Dictionary<System.String,System.Type> _typesMap;        // 0x18
        private static System.Collections.Generic.Dictionary<System.Type,System.Type[]> _subTypesMap;        // 0x20
        private static System.Collections.Generic.Dictionary<System.Reflection.MethodBase,ParadoxNotion.ReflectionTools.MethodType> _methodSpecialType;        // 0x28
        private static System.Collections.Generic.Dictionary<System.Type,System.String> _typeFriendlyName;        // 0x30
        private static System.Collections.Generic.Dictionary<System.Type,System.String> _typeFriendlyNameCompileSafe;        // 0x38
        private static System.Collections.Generic.Dictionary<System.Reflection.MethodBase,System.String> _methodSignatures;        // 0x40
        private static System.Collections.Generic.Dictionary<System.Type,System.Reflection.ConstructorInfo[]> _typeConstructors;        // 0x48
        private static System.Collections.Generic.Dictionary<System.Type,System.Reflection.MethodInfo[]> _typeMethods;        // 0x50
        private static System.Collections.Generic.Dictionary<System.Type,System.Reflection.FieldInfo[]> _typeFields;        // 0x58
        private static System.Collections.Generic.Dictionary<System.Type,System.Reflection.PropertyInfo[]> _typeProperties;        // 0x60
        private static System.Collections.Generic.Dictionary<System.Type,System.Reflection.EventInfo[]> _typeEvents;        // 0x68
        private static System.Collections.Generic.Dictionary<System.Type,System.Object[]> _typeAttributes;        // 0x70
        private static System.Collections.Generic.Dictionary<System.Reflection.MemberInfo,System.Object[]> _memberAttributes;        // 0x78
        private static System.Collections.Generic.Dictionary<System.Reflection.MemberInfo,System.Boolean> _obsoleteCache;        // 0x80
        private static System.Collections.Generic.Dictionary<System.Type,System.Reflection.MethodInfo[]> _typeExtensions;        // 0x88
        private static System.Collections.Generic.Dictionary<System.Type,System.Type[]> _genericArgsTypeCache;        // 0x90
        private static System.Collections.Generic.Dictionary<System.Reflection.MethodInfo,System.Type[]> _genericArgsMathodCache;        // 0x98
        public static readonly System.Collections.Generic.Dictionary<System.String,System.String> op_FriendlyNamesLong;        // 0xA0
        public static readonly System.Collections.Generic.Dictionary<System.String,System.String> op_FriendlyNamesShort;        // 0xA8
        public static readonly System.Collections.Generic.Dictionary<System.String,System.String> op_CSharpAliases;        // 0xB0
        public static System.String METHOD_SPECIAL_NAME_GET;        // 0x0
        public static System.String METHOD_SPECIAL_NAME_SET;        // 0x0
        public static System.String METHOD_SPECIAL_NAME_ADD;        // 0x0
        public static System.String METHOD_SPECIAL_NAME_REMOVE;        // 0x0
        public static System.String METHOD_SPECIAL_NAME_OP;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.Void FlushMem() { }
        private System.Reflection.Assembly[] get_loadedAssemblies() { }
        private System.Type GetType(System.String typeFullName) { }
        private System.Type GetType(System.String typeFullName, System.Type fallbackAssignable) { }
        private System.Type GetType(System.String typeFullName, System.Boolean fallbackNoNamespace, System.Type fallbackAssignable) { }
        private System.Type GetTypeDirect(System.String typeFullName) { }
        private System.Type TryResolveGenericType(System.String typeFullName, System.Boolean fallbackNoNamespace, System.Type fallbackAssignable) { }
        private System.Type TryResolveDeserializeFromAttribute(System.String typeName) { }
        private System.Type TryResolveWithoutNamespace(System.String typeName, System.Type fallbackAssignable) { }
        private System.Type[] GetAllTypes(System.Boolean includeObsolete) { }
        private System.Type[] GetImplementationsOf(System.Type baseType) { }
        private System.Object[] SingleTempArgsArray(System.Object arg) { }
        private ParadoxNotion.ReflectionTools.MethodType GetMethodSpecialType(System.Reflection.MethodBase method) { }
        private System.String FriendlyName(System.Type t, System.Boolean compileSafe) { }
        private System.String FriendlyName(System.Reflection.MemberInfo info) { }
        private System.String FriendlyName(System.Reflection.MethodBase method) { }
        private System.String FriendlyName(System.Reflection.MethodBase method, ParadoxNotion.ReflectionTools.MethodType& specialNameType) { }
        private System.String SignatureName(System.Reflection.MethodBase method) { }
        private System.String FriendlyTypeName(System.String fullName) { }
        private System.Type RTReflectedOrDeclaredType(System.Reflection.MemberInfo member) { }
        private System.Boolean RTIsAssignableFrom(System.Type type, System.Type other) { }
        private System.Boolean RTIsAssignableTo(System.Type type, System.Type other) { }
        private System.Boolean RTIsAbstract(System.Type type) { }
        private System.Boolean RTIsValueType(System.Type type) { }
        private System.Boolean RTIsArray(System.Type type) { }
        private System.Boolean RTIsInterface(System.Type type) { }
        private System.Boolean RTIsSubclassOf(System.Type type, System.Type other) { }
        private System.Boolean RTIsGenericParameter(System.Type type) { }
        private System.Boolean RTIsGenericType(System.Type type) { }
        private System.Reflection.MethodInfo RTGetGetMethod(System.Reflection.PropertyInfo prop) { }
        private System.Reflection.MethodInfo RTGetSetMethod(System.Reflection.PropertyInfo prop) { }
        private System.Reflection.MethodInfo RTGetDelegateMethodInfo(System.Delegate del) { }
        private System.Type RTMakeGenericType(System.Type type, System.Type[] typeArgs) { }
        private System.Type[] RTGetGenericArguments(System.Type type) { }
        private System.Type[] RTGetGenericArguments(System.Reflection.MethodInfo method) { }
        private System.Type[] RTGetEmptyTypes() { }
        private System.Type RTGetElementType(System.Type type) { }
        private System.Boolean RTIsByRef(System.Type type) { }
        private System.Object CreateObject(System.Type type) { }
        private System.Object CreateObjectUninitialized(System.Type type) { }
        private System.Reflection.ConstructorInfo RTGetDefaultConstructor(System.Type type) { }
        private System.Reflection.ConstructorInfo RTGetConstructor(System.Type type, System.Type[] paramTypes) { }
        private System.Boolean MemberResolvedFromDeserializeAttribute(System.Reflection.MemberInfo member, System.String targetName) { }
        private System.Reflection.MethodInfo RTGetMethod(System.Type type, System.String name) { }
        private System.Reflection.MethodInfo RTGetMethod(System.Type type, System.String name, System.Type[] paramTypes, System.Type returnType, System.Type[] genericArgumentTypes) { }
        private System.Reflection.FieldInfo RTGetField(System.Type type, System.String name, System.Boolean includePrivateBase) { }
        private System.Reflection.PropertyInfo RTGetProperty(System.Type type, System.String name) { }
        private System.Reflection.MemberInfo RTGetFieldOrProp(System.Type type, System.String name) { }
        private System.Reflection.EventInfo RTGetEvent(System.Type type, System.String name) { }
        private System.Object RTGetFieldOrPropValue(System.Reflection.MemberInfo member, System.Object instance, System.Int32 index) { }
        private System.Void RTSetFieldOrPropValue(System.Reflection.MemberInfo member, System.Object instance, System.Object value, System.Int32 index) { }
        private System.Reflection.ConstructorInfo[] RTGetConstructors(System.Type type) { }
        private System.Reflection.MethodInfo[] RTGetMethods(System.Type type) { }
        private System.Reflection.FieldInfo[] RTGetFields(System.Type type) { }
        private System.Reflection.PropertyInfo[] RTGetProperties(System.Type type) { }
        private System.Reflection.EventInfo[] RTGetEvents(System.Type type) { }
        private System.Object[] RTGetAllAttributes(System.Type type) { }
        private System.Boolean RTIsDefined(System.Type type, System.Boolean inherited) { }
        private System.Boolean RTIsDefined(System.Type type, System.Type attributeType, System.Boolean inherited) { }
        private T RTGetAttribute(System.Type type, System.Boolean inherited) { }
        private System.Attribute RTGetAttribute(System.Type type, System.Type attributeType, System.Boolean inherited) { }
        private System.Object[] RTGetAllAttributes(System.Reflection.MemberInfo member) { }
        private System.Boolean RTIsDefined(System.Reflection.MemberInfo member, System.Boolean inherited) { }
        private System.Boolean RTIsDefined(System.Reflection.MemberInfo member, System.Type attributeType, System.Boolean inherited) { }
        private T RTGetAttribute(System.Reflection.MemberInfo member, System.Boolean inherited) { }
        private System.Attribute RTGetAttribute(System.Reflection.MemberInfo member, System.Type attributeType, System.Boolean inherited) { }
        private System.Collections.Generic.IEnumerable<T> RTGetAttributesRecursive(System.Type type) { }
        private System.Reflection.ParameterInfo[] RTGetDelegateTypeParameters(System.Type delegateType) { }
        private T RTCreateDelegate(System.Reflection.MethodInfo method, System.Object instance) { }
        private System.Delegate RTCreateDelegate(System.Reflection.MethodInfo method, System.Type type, System.Object instance) { }
        private System.Delegate ConvertDelegate(System.Delegate originalDelegate, System.Type targetDelegateType) { }
        private System.Boolean IsReadOnly(System.Reflection.FieldInfo field) { }
        private System.Boolean IsConstant(System.Reflection.FieldInfo field) { }
        private System.Boolean IsStatic(System.Reflection.EventInfo info) { }
        private System.Boolean IsStatic(System.Reflection.PropertyInfo info) { }
        private System.Boolean IsParams(System.Reflection.ParameterInfo parameter, System.Reflection.ParameterInfo[] parameters) { }
        private System.Boolean IsObsolete(System.Reflection.MemberInfo member, System.Boolean inherited) { }
        private System.Reflection.PropertyInfo GetBaseDefinition(System.Reflection.PropertyInfo propertyInfo) { }
        private System.Reflection.FieldInfo GetBaseDefinition(System.Reflection.FieldInfo fieldInfo) { }
        private System.Reflection.MethodInfo[] GetExtensionMethods(System.Type targetType) { }
        private System.Boolean IsExtensionMethod(System.Reflection.MethodInfo method) { }
        private System.Boolean IsPropertyAccessor(System.Reflection.MethodInfo method) { }
        private System.Boolean IsIndexerProperty(System.Reflection.PropertyInfo property) { }
        private System.Boolean IsAutoProperty(System.Reflection.PropertyInfo property) { }
        private System.Reflection.PropertyInfo GetAccessorProperty(System.Reflection.MethodInfo method) { }
        private System.Boolean IsEnumerableCollection(System.Type type) { }
        private System.Type GetEnumerableElementType(System.Type type) { }
        private System.Type GetSingleGenericArgument(System.Type type) { }
        private System.Type GetFirstGenericParameterConstraintType(System.Type type) { }
        private System.Type GetFirstGenericParameterConstraintType(System.Reflection.MethodInfo method) { }
        private System.Boolean TryMakeGeneric(System.Type def, System.Type argType, System.Type& result) { }
        private System.Boolean TryMakeGeneric(System.Reflection.MethodInfo def, System.Type argType, System.Reflection.MethodInfo& result) { }
        private System.Array Resize(System.Array array, System.Int32 newSize) { }
        private System.Boolean TryConvert(System.Type fromType, System.Type toType, System.Linq.Expressions.UnaryExpression& exp) { }
        private System.Void DigFields(System.Object root, System.Predicate<System.Reflection.FieldInfo> move, System.Action<System.Object> push, System.Action<System.Object> pop) { }
        private System.Func<T,TResult> GetFieldGetter(System.Reflection.FieldInfo info) { }
        private System.Action<T,TValue> GetFieldSetter(System.Reflection.FieldInfo info) { }

    }

    // TypeToken: 0x200049F
    public class TypeConverter
    {
        // Fields
        private static ParadoxNotion.TypeConverter.CustomConverter customConverter;        // 0x0

        // Methods
        private System.Void add_customConverter(ParadoxNotion.TypeConverter.CustomConverter value) { }
        private System.Void remove_customConverter(ParadoxNotion.TypeConverter.CustomConverter value) { }
        private System.Func<System.Object,System.Object> Get(System.Type fromType, System.Type toType) { }
        private System.Boolean CanConvert(System.Type fromType, System.Type toType) { }

    }

    // TypeToken: 0x20004A3
    public class ColorUtils
    {
        // Fields
        private static System.Collections.Generic.Dictionary<UnityEngine.Color32,System.String> colorHexCache;        // 0x0
        private static System.Collections.Generic.Dictionary<System.String,UnityEngine.Color> hexColorCache;        // 0x8
        private static System.Collections.Generic.Dictionary<System.ValueTuple<System.Int32,System.Int32,UnityEngine.Gradient,System.Single>,UnityEngine.Texture2D> gradientTextureCache;        // 0x10
        private static System.Collections.Generic.Dictionary<System.ValueTuple<UnityEngine.Color,System.Single,UnityEngine.Color,System.Single>,UnityEngine.Gradient> gradientCache;        // 0x18
        private static System.Collections.Generic.Dictionary<System.String,UnityEngine.Gradient> menuItemRibbonGradientCache;        // 0x20

        // Methods
        private UnityEngine.Color WithAlpha(UnityEngine.Color color, System.Single alpha) { }
        private UnityEngine.Color Grey(System.Single value) { }
        private System.String ColorToHex(UnityEngine.Color32 color) { }
        private UnityEngine.Color HexToColor(System.String hex) { }
        private UnityEngine.Texture2D CreateGradientTexture(System.Int32 width, System.Int32 height, UnityEngine.Gradient gradient, System.Single rotateDegree) { }
        private UnityEngine.Gradient CreateGradient(UnityEngine.Color colorLeft, System.Single colorLeftRatio, UnityEngine.Color colorRight, System.Single colorRightRatio) { }
        private UnityEngine.Gradient GetMenuItemRibbonGradientOfNodeFullPath(System.String fullPath) { }
        private System.Void RegisterMenuItemRibbonGradientOfNodeFullPath(System.String fullPath, UnityEngine.Color colorLeft, System.Single colorLeftRatio, UnityEngine.Color colorRight, System.Single colorRightRatio) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20004A4
    public class CurveUtils
    {
        // Fields
        private static System.Single POS_CHECK_RES;        // 0x0
        private static System.Single POS_CHECK_DISTANCE;        // 0x0

        // Methods
        private UnityEngine.Vector2 GetPosAlongCurve(UnityEngine.Vector2 from, UnityEngine.Vector2 to, UnityEngine.Vector2 fromTangent, UnityEngine.Vector2 toTangent, System.Single t) { }
        private System.Boolean IsPosAlongCurve(UnityEngine.Vector2 from, UnityEngine.Vector2 to, UnityEngine.Vector2 fromTangent, UnityEngine.Vector2 toTangent, UnityEngine.Vector2 targetPosition) { }
        private System.Boolean IsPosAlongCurve(UnityEngine.Vector2 from, UnityEngine.Vector2 to, UnityEngine.Vector2 fromTangent, UnityEngine.Vector2 toTangent, UnityEngine.Vector2 targetPosition, System.Single& norm) { }
        private System.Void ResolveTangents(UnityEngine.Vector2 from, UnityEngine.Vector2 to, System.Single rigidMlt, ParadoxNotion.PlanarDirection direction, UnityEngine.Vector2& fromTangent, UnityEngine.Vector2& toTangent) { }
        private System.Void ResolveTangents(UnityEngine.Vector2 from, UnityEngine.Vector2 to, UnityEngine.Rect fromRect, UnityEngine.Rect toRect, System.Single rigidMlt, ParadoxNotion.PlanarDirection direction, UnityEngine.Vector2& fromTangent, UnityEngine.Vector2& toTangent) { }

    }

    // TypeToken: 0x20004A5
    public class GUIStyleUtils
    {
        // Methods
        private UnityEngine.GUIStyle Margin(UnityEngine.GUIStyle style, System.Int32 left, System.Int32 right, System.Int32 top, System.Int32 bottom) { }
        private UnityEngine.GUIStyle Padding(UnityEngine.GUIStyle style, System.Int32 left, System.Int32 right, System.Int32 top, System.Int32 bottom) { }
        private UnityEngine.GUIStyle Border(UnityEngine.GUIStyle style, System.Int32 left, System.Int32 right, System.Int32 top, System.Int32 bottom) { }
        private UnityEngine.GUIStyle Overflow(UnityEngine.GUIStyle style, System.Int32 left, System.Int32 right, System.Int32 top, System.Int32 bottom) { }
        private UnityEngine.GUIStyle TextAlignment(UnityEngine.GUIStyle style, UnityEngine.TextAnchor anchor) { }
        private UnityEngine.GUIStyle RichText(UnityEngine.GUIStyle style, System.Boolean rich) { }

    }

    // TypeToken: 0x20004A6
    public class LayerUtils
    {
        // Methods
        private UnityEngine.LayerMask CreateFromNames(System.String[] layerNames) { }
        private UnityEngine.LayerMask CreateFromNumbers(System.Int32[] layerNumbers) { }
        private UnityEngine.LayerMask LayerNamesToMask(System.String[] layerNames) { }
        private UnityEngine.LayerMask LayerNumbersToMask(System.Int32[] layerNumbers) { }
        private UnityEngine.LayerMask Inverse(UnityEngine.LayerMask mask) { }
        private UnityEngine.LayerMask AddToMask(UnityEngine.LayerMask mask, System.String[] layerNames) { }
        private UnityEngine.LayerMask RemoveFromMask(UnityEngine.LayerMask mask, System.String[] layerNames) { }
        private System.Boolean ContainsAnyLayer(UnityEngine.LayerMask mask, System.String[] layerNames) { }
        private System.Boolean ContainsAllLayers(UnityEngine.LayerMask mask, System.String[] layerNames) { }
        private System.String[] MaskToNames(UnityEngine.LayerMask mask) { }
        private System.String MaskToString(UnityEngine.LayerMask mask) { }
        private System.String MaskToString(UnityEngine.LayerMask mask, System.String delimiter) { }

    }

    // TypeToken: 0x20004A7
    public class ObjectUtils
    {
        // Methods
        private System.Boolean AnyEquals(System.Object a, System.Object b) { }
        private System.Collections.Generic.List<T> Shuffle(System.Collections.Generic.List<T> list) { }
        private System.Boolean Is(System.Object o, T& result) { }
        private T GetAddComponent(UnityEngine.GameObject gameObject) { }
        private UnityEngine.Component TransformToType(UnityEngine.Component current, System.Type type) { }
        private System.Collections.Generic.IEnumerable<UnityEngine.GameObject> FindGameObjectsWithinLayerMask(UnityEngine.LayerMask mask, UnityEngine.GameObject exclude) { }
        private System.Boolean IsInLayerMask(UnityEngine.GameObject gameObject, UnityEngine.LayerMask mask) { }

    }

    // TypeToken: 0x20004A9
    public class RectUtils
    {
        // Methods
        private UnityEngine.Rect GetBoundRect(UnityEngine.Rect[] rects) { }
        private UnityEngine.Rect GetBoundRect(UnityEngine.Vector2[] positions) { }
        private System.Boolean Encapsulates(UnityEngine.Rect a, UnityEngine.Rect b) { }
        private UnityEngine.Rect ExpandBy(UnityEngine.Rect rect, System.Single margin) { }
        private UnityEngine.Rect ExpandBy(UnityEngine.Rect rect, System.Single xMargin, System.Single yMargin) { }
        private UnityEngine.Rect ExpandBy(UnityEngine.Rect rect, System.Single left, System.Single top, System.Single right, System.Single bottom) { }
        private UnityEngine.Rect TransformSpace(UnityEngine.Rect rect, UnityEngine.Rect oldContainer, UnityEngine.Rect newContainer) { }
        private UnityEngine.Vector2 TransformSpace(UnityEngine.Vector2 vector, UnityEngine.Rect oldContainer, UnityEngine.Rect newContainer) { }

    }

    // TypeToken: 0x20004AA
    public class StringUtils
    {
        // Fields
        public static System.String SPACE;        // 0x0
        public static System.String ALPHABET;        // 0x0
        public static readonly System.Char[] CHAR_SPACE_ARRAY;        // 0x0
        private static System.Collections.Generic.Dictionary<System.String,System.String> splitCaseCache;        // 0x8

        // Methods
        private System.String SplitCamelCase(System.String s) { }
        private System.String CapitalizeFirst(System.String s) { }
        private System.String CapLength(System.String s, System.Int32 max) { }
        private System.String GetCapitals(System.String s) { }
        private System.String FormatError(System.String input) { }
        private System.String GetAlphabetLetter(System.Int32 index) { }
        private System.String GetStringWithinOuter(System.String input, System.Char from, System.Char to) { }
        private System.String GetStringWithinInner(System.String input, System.Char from, System.Char to) { }
        private System.String ReplaceWithin(System.String text, System.Char startChar, System.Char endChar, System.Func<System.String,System.String> Process) { }
        private System.Single ScoreSearchMatch(System.String input, System.String leafName, System.String categoryName) { }
        private System.Boolean SearchMatch(System.String input, System.String leafName, System.String categoryName) { }
        private System.String ToStringAdvanced(System.Object o) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20004AB
    public class WeakReferenceList`1
    {
        // Fields
        private System.Collections.Generic.List<System.WeakReference<T>> list;        // 0x0

        // Methods
        private System.Int32 get_Count() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 capacity) { }
        private T get_Item(System.Int32 i) { }
        private System.Void set_Item(System.Int32 i, T value) { }
        private System.Void Add(T item) { }
        private System.Void Remove(T item) { }
        private System.Boolean Contains(T item, System.Int32& index) { }
        private System.Void Clear() { }
        private System.Collections.Generic.List<T> ToReferenceList() { }
        private ParadoxNotion.WeakReferenceList<T> op_Implicit(System.Collections.Generic.List<T> value) { }

    }

    // TypeToken: 0x20004AC
    public class WeakReferenceTable`2
    {
        // Fields
        private System.Collections.Generic.List<System.WeakReference<TKey>> keys;        // 0x0
        private System.Collections.Generic.List<TValue> values;        // 0x0

        // Methods
        private System.Int32 get_Count() { }
        private System.Void .ctor() { }
        private System.Void Clear() { }
        private System.Void Add(TKey key, TValue value) { }
        private System.Void Remove(TKey key) { }
        private System.Boolean TryGetValueWithRefCheck(TKey key, TValue& value) { }
        private System.Void RemoveMissingReferences() { }
        private System.Void CheckCount() { }

    }

}

namespace ParadoxNotion.Animation
{

    // TypeToken: 0x2000510
    public struct EaseType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.Animation.EaseType Linear;        // 0x0
        public static ParadoxNotion.Animation.EaseType QuadraticIn;        // 0x0
        public static ParadoxNotion.Animation.EaseType QuadraticOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType QuadraticInOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType QuarticIn;        // 0x0
        public static ParadoxNotion.Animation.EaseType QuarticOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType QuarticInOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType QuinticIn;        // 0x0
        public static ParadoxNotion.Animation.EaseType QuinticOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType QuinticInOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType CubicIn;        // 0x0
        public static ParadoxNotion.Animation.EaseType CubicOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType CubicInOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType ExponentialIn;        // 0x0
        public static ParadoxNotion.Animation.EaseType ExponentialOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType ExponentialInOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType CircularIn;        // 0x0
        public static ParadoxNotion.Animation.EaseType CircularOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType CircularInOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType SinusoidalIn;        // 0x0
        public static ParadoxNotion.Animation.EaseType SinusoidalOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType SinusoidalInOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType ElasticIn;        // 0x0
        public static ParadoxNotion.Animation.EaseType ElasticOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType ElasticInOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType BounceIn;        // 0x0
        public static ParadoxNotion.Animation.EaseType BounceOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType BounceInOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType BackIn;        // 0x0
        public static ParadoxNotion.Animation.EaseType BackOut;        // 0x0
        public static ParadoxNotion.Animation.EaseType BackInOut;        // 0x0

    }

    // TypeToken: 0x2000511
    public class Easing
    {
        // Methods
        private System.Single Ease(ParadoxNotion.Animation.EaseType type, System.Single from, System.Single to, System.Single t) { }
        private UnityEngine.Vector3 Ease(ParadoxNotion.Animation.EaseType type, UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single t) { }
        private UnityEngine.Quaternion Ease(ParadoxNotion.Animation.EaseType type, UnityEngine.Quaternion from, UnityEngine.Quaternion to, System.Single t) { }
        private UnityEngine.Color Ease(ParadoxNotion.Animation.EaseType type, UnityEngine.Color from, UnityEngine.Color to, System.Single t) { }
        private System.Func<System.Single,System.Single> Function(ParadoxNotion.Animation.EaseType type) { }
        private System.Single Linear(System.Single t) { }
        private System.Single QuadraticIn(System.Single t) { }
        private System.Single QuadraticOut(System.Single t) { }
        private System.Single QuadraticInOut(System.Single t) { }
        private System.Single QuarticIn(System.Single t) { }
        private System.Single QuarticOut(System.Single t) { }
        private System.Single QuarticInOut(System.Single t) { }
        private System.Single QuinticIn(System.Single t) { }
        private System.Single QuinticOut(System.Single t) { }
        private System.Single QuinticInOut(System.Single t) { }
        private System.Single CubicIn(System.Single t) { }
        private System.Single CubicOut(System.Single t) { }
        private System.Single CubicInOut(System.Single t) { }
        private System.Single SinusoidalIn(System.Single t) { }
        private System.Single SinusoidalOut(System.Single t) { }
        private System.Single SinusoidalInOut(System.Single t) { }
        private System.Single ExponentialIn(System.Single t) { }
        private System.Single ExponentialOut(System.Single t) { }
        private System.Single ExponentialInOut(System.Single t) { }
        private System.Single CircularIn(System.Single t) { }
        private System.Single CircularOut(System.Single t) { }
        private System.Single CircularInOut(System.Single t) { }
        private System.Single ElasticIn(System.Single t) { }
        private System.Single ElasticOut(System.Single t) { }
        private System.Single ElasticInOut(System.Single t) { }
        private System.Single BounceIn(System.Single t) { }
        private System.Single BounceOut(System.Single t) { }
        private System.Single BounceInOut(System.Single t) { }
        private System.Single BackIn(System.Single t) { }
        private System.Single BackOut(System.Single t) { }
        private System.Single BackInOut(System.Single t) { }

    }

}

namespace ParadoxNotion.Design
{

    // TypeToken: 0x2000512
    public class SpoofAOTAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000513
    public class CancelSpoofAOTAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000514
    public class DoNotListAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000515
    public class ProtectedSingletonAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000516
    public class ExecutionPriorityAttribute : Attribute
    {
        // Fields
        public readonly System.Int32 priority;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 priority) { }

    }

    // TypeToken: 0x2000517
    public class ExposeAsDefinitionAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000518
    public class ExposeFieldAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000519
    public class NodeCanvasOdinOnlyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200051A
    public class ListInspectorOptionAttribute : Attribute
    {
        // Fields
        public readonly System.Boolean allowAdd;        // 0x10
        public readonly System.Boolean allowRemove;        // 0x11
        public readonly System.Boolean showFoldout;        // 0x12

        // Methods
        private System.Void .ctor(System.Boolean allowAdd, System.Boolean allowRemove, System.Boolean alwaysExpanded) { }

    }

    // TypeToken: 0x200051B
    public class NameAttribute : Attribute
    {
        // Fields
        public readonly System.String name;        // 0x10
        public readonly System.Int32 priority;        // 0x18

        // Methods
        private System.Void .ctor(System.String name, System.Int32 priority) { }

    }

    // TypeToken: 0x200051C
    public class CategoryAttribute : Attribute
    {
        // Fields
        public readonly System.String category;        // 0x10

        // Methods
        private System.Void .ctor(System.String category) { }

    }

    // TypeToken: 0x200051D
    public class DescriptionAttribute : Attribute
    {
        // Fields
        public readonly System.String description;        // 0x10

        // Methods
        private System.Void .ctor(System.String description) { }

    }

    // TypeToken: 0x200051E
    public class IconAttribute : Attribute
    {
        // Fields
        public readonly System.String iconName;        // 0x10
        public readonly System.Boolean fixedColor;        // 0x18
        public readonly System.String runtimeIconTypeCallback;        // 0x20
        public readonly System.Type fromType;        // 0x28

        // Methods
        private System.Void .ctor(System.String iconName, System.Boolean fixedColor, System.String runtimeIconTypeCallback) { }
        private System.Void .ctor(System.Type fromType) { }

    }

    // TypeToken: 0x200051F
    public class ColorAttribute : Attribute
    {
        // Fields
        public readonly System.String hexColor;        // 0x10

        // Methods
        private System.Void .ctor(System.String hexColor) { }

    }

    // TypeToken: 0x2000520
    public class ColorGradientAttribute : Attribute
    {
        // Fields
        public readonly System.String hexColorLeft;        // 0x10
        public readonly System.Single colorLeftRatio;        // 0x18
        public readonly System.String hexColorRight;        // 0x20
        public readonly System.Single colorRightRatio;        // 0x28
        public readonly System.Single rotateDegree;        // 0x2C

        // Methods
        private UnityEngine.Color get_colorLeft() { }
        private UnityEngine.Color get_colorRight() { }
        private System.Void .ctor(System.String hexColorLeft, System.Single colorLeftRatio, System.String hexColorRight, System.Single colorRightRatio, System.Single rotateDegree) { }

    }

    // TypeToken: 0x2000521
    public class NodeMenuItemColorGradientAttribute : Attribute
    {
        // Fields
        public readonly System.String hexColorLeft;        // 0x10
        public readonly System.Single colorLeftRatio;        // 0x18
        public readonly System.String hexColorRight;        // 0x20
        public readonly System.Single colorRightRatio;        // 0x28
        public readonly System.Single rotateDegree;        // 0x2C

        // Methods
        private UnityEngine.Color get_colorLeft() { }
        private UnityEngine.Color get_colorRight() { }
        private System.Void .ctor(System.String hexColorLeft, System.Single colorLeftRatio, System.String hexColorRight, System.Single colorRightRatio, System.Single rotateDegree) { }

    }

    // TypeToken: 0x2000522
    public class NodeCategoryMenuItemColorGradientAttribute : Attribute
    {
        // Fields
        public readonly System.String hexColorLeft;        // 0x10
        public readonly System.Single colorLeftRatio;        // 0x18
        public readonly System.String hexColorRight;        // 0x20
        public readonly System.Single colorRightRatio;        // 0x28
        public readonly System.Single rotateDegree;        // 0x2C

        // Methods
        private UnityEngine.Color get_colorLeft() { }
        private UnityEngine.Color get_colorRight() { }
        private System.Void .ctor(System.String hexColorLeft, System.Single colorLeftRatio, System.String hexColorRight, System.Single colorRightRatio, System.Single rotateDegree) { }

    }

    // TypeToken: 0x2000523
    public class HideAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000524
    public class DrawerAttribute : Attribute
    {
        // Methods
        private System.Int32 get_priority() { }
        private System.Boolean get_isDecorator() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000525
    public class HeaderAttribute : DrawerAttribute
    {
        // Fields
        public readonly System.String title;        // 0x10

        // Methods
        private System.Boolean get_isDecorator() { }
        private System.Void .ctor(System.String title) { }

    }

    // TypeToken: 0x2000526
    public class DimIfDefaultAttribute : DrawerAttribute
    {
        // Methods
        private System.Boolean get_isDecorator() { }
        private System.Int32 get_priority() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000527
    public class ShowIfAttribute : DrawerAttribute
    {
        // Fields
        public readonly System.String fieldName;        // 0x10
        public readonly System.Int32 checkValue;        // 0x18

        // Methods
        private System.Boolean get_isDecorator() { }
        private System.Int32 get_priority() { }
        private System.Void .ctor(System.String fieldName, System.Int32 checkValue) { }

    }

    // TypeToken: 0x2000528
    public class RequiredFieldAttribute : DrawerAttribute
    {
        // Methods
        private System.Boolean get_isDecorator() { }
        private System.Int32 get_priority() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000529
    public class ShowButtonAttribute : DrawerAttribute
    {
        // Fields
        public readonly System.String buttonTitle;        // 0x10
        public readonly System.String methodName;        // 0x18

        // Methods
        private System.Boolean get_isDecorator() { }
        private System.Int32 get_priority() { }
        private System.Void .ctor(System.String buttonTitle, System.String methodnameCallback) { }

    }

    // TypeToken: 0x200052A
    public class CallbackAttribute : DrawerAttribute
    {
        // Fields
        public readonly System.String methodName;        // 0x10

        // Methods
        private System.Boolean get_isDecorator() { }
        private System.Int32 get_priority() { }
        private System.Void .ctor(System.String methodName) { }

    }

    // TypeToken: 0x200052B
    public class MinValueAttribute : DrawerAttribute
    {
        // Fields
        public readonly System.Single min;        // 0x10

        // Methods
        private System.Int32 get_priority() { }
        private System.Void .ctor(System.Single min) { }
        private System.Void .ctor(System.Int32 min) { }

    }

    // TypeToken: 0x200052C
    public class DelayedFieldAttribute : DrawerAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200052D
    public class LayerFieldAttribute : DrawerAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200052E
    public class TagFieldAttribute : DrawerAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200052F
    public class TextAreaFieldAttribute : DrawerAttribute
    {
        // Fields
        public readonly System.Int32 numberOfLines;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 numberOfLines) { }

    }

    // TypeToken: 0x2000530
    public class PopupFieldAttribute : DrawerAttribute
    {
        // Fields
        public readonly System.Object[] options;        // 0x10

        // Methods
        private System.Void .ctor(System.Object[] options) { }

    }

    // TypeToken: 0x2000531
    public class SliderFieldAttribute : DrawerAttribute
    {
        // Fields
        public readonly System.Single min;        // 0x10
        public readonly System.Single max;        // 0x14

        // Methods
        private System.Void .ctor(System.Single min, System.Single max) { }
        private System.Void .ctor(System.Int32 min, System.Int32 max) { }

    }

    // TypeToken: 0x2000532
    public class ForceObjectFieldAttribute : DrawerAttribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000533
    public class UndoUtility
    {
        // Fields
        private static System.String <lastOperationName>k__BackingField;        // 0x0

        // Methods
        private System.String get_lastOperationName() { }
        private System.Void set_lastOperationName(System.String value) { }
        private System.Void RecordObject(UnityEngine.Object target, System.String name, System.Boolean forceIgnoreScene) { }
        private System.Void RecordObjectComplete(UnityEngine.Object target, System.String name, System.Boolean forceIgnore) { }
        private System.Void SetDirty(UnityEngine.Object target) { }
        private System.Void RecordObject(UnityEngine.Object target, System.String name, System.Action operation) { }
        private System.Void RecordObjectComplete(UnityEngine.Object target, System.String name, System.Action operation) { }
        private System.String GetLastOperationNameOr(System.String operation) { }
        private System.Void CheckUndo(UnityEngine.Object target, System.String name) { }
        private System.Void CheckDirty(UnityEngine.Object target) { }

    }

}

namespace ParadoxNotion.Serialization
{

    // TypeToken: 0x20004C1
    public class DeserializeFromAttribute : Attribute
    {
        // Fields
        public readonly System.String previousTypeFullName;        // 0x10

        // Methods
        private System.Void .ctor(System.String previousTypeFullName) { }

    }

    // TypeToken: 0x20004C2
    public class fsRecoveryProcessor`2 : fsObjectProcessor
    {
        // Fields
        private static System.String FIELD_NAME_TYPE;        // 0x0
        private static System.String FIELD_NAME_STATE;        // 0x0

        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Void OnBeforeDeserialize(System.Type storageType, ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004C5
    public class fsUnityObjectConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Boolean RequestCycleSupport(System.Type storageType) { }
        private System.Boolean RequestInheritanceSupport(System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004C6
    public interface IMissingRecoverable
    {
        // Methods
        private System.String get_missingType() { }
        private System.Void set_missingType(System.String value) { }
        private System.String get_recoveryState() { }
        private System.Void set_recoveryState(System.String value) { }

    }

    // TypeToken: 0x20004C7
    public interface ISerializedMethodBaseInfo : ISerializedReflectedInfo, ISerializationCallbackReceiver
    {
        // Methods
        private System.Reflection.MethodBase GetMethodBase() { }
        private System.Boolean HasChanged() { }

    }

    // TypeToken: 0x20004C8
    public interface ISerializedReflectedInfo : ISerializationCallbackReceiver
    {
        // Methods
        private System.Reflection.MemberInfo AsMemberInfo() { }
        private System.String AsString() { }

    }

    // TypeToken: 0x20004C9
    public class JSONSerializer
    {
        // Fields
        public static System.Boolean enableCache;        // 0x0
        private static System.Object serializerLock;        // 0x8
        private static ParadoxNotion.Serialization.FullSerializer.fsSerializer serializer;        // 0x10
        private static System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> dataCache;        // 0x18

        // Methods
        private System.Void .cctor() { }
        private System.Void FlushMem() { }
        private System.Void __FlushDataCache() { }
        private System.String Serialize(System.Type type, System.Object instance, System.Collections.Generic.List<UnityEngine.Object> references, System.Boolean pretyJson) { }
        private T Deserialize(System.String json, System.Collections.Generic.List<UnityEngine.Object> references) { }
        private System.Object Deserialize(System.Type type, System.String json, System.Collections.Generic.List<UnityEngine.Object> references) { }
        private T TryDeserializeOverwrite(T instance, System.String json, System.Collections.Generic.List<UnityEngine.Object> references) { }
        private System.Object TryDeserializeOverwrite(System.Object instance, System.String json, System.Collections.Generic.List<UnityEngine.Object> references) { }
        private System.Object Internal_Deserialize(System.Type type, System.String json, System.Collections.Generic.List<UnityEngine.Object> references, System.Object instance) { }
        private System.Void SerializeAndExecuteNoCycles(System.Type type, System.Object instance, System.Action<System.Object,ParadoxNotion.Serialization.FullSerializer.fsData> call) { }
        private System.Void SerializeAndExecuteNoCycles(System.Type type, System.Object instance, System.Action<System.Object> beforeCall, System.Action<System.Object,ParadoxNotion.Serialization.FullSerializer.fsData> afterCall) { }
        private T Clone(T original) { }
        private System.Object Clone(System.Object original) { }
        private System.Void CopySerialized(System.Object source, System.Object target) { }
        private System.Void ShowData(System.String json, System.String fileName) { }
        private System.String PrettifyJson(System.String json) { }

    }

    // TypeToken: 0x20004CA
    public class SerializationPair
    {
        // Fields
        public System.String _json;        // 0x10
        public System.Collections.Generic.List<UnityEngine.Object> _references;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004CB
    public class SerializedConstructorInfo, ISerializedMethodBaseInfo, ISerializedReflectedInfo, ISerializationCallbackReceiver
    {
        // Fields
        private System.String _baseInfo;        // 0x10
        private System.String _paramsInfo;        // 0x18
        private System.Reflection.ConstructorInfo _constructor;        // 0x20
        private System.Boolean _hasChanged;        // 0x28

        // Methods
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Reflection.ConstructorInfo constructor) { }
        private System.Reflection.MemberInfo AsMemberInfo() { }
        private System.Reflection.MethodBase GetMethodBase() { }
        private System.Boolean HasChanged() { }
        private System.String AsString() { }
        private System.String ToString() { }
        private System.Reflection.ConstructorInfo op_Implicit(ParadoxNotion.Serialization.SerializedConstructorInfo value) { }

    }

    // TypeToken: 0x20004CE
    public class SerializedEventInfo, ISerializedReflectedInfo, ISerializationCallbackReceiver
    {
        // Fields
        private System.String _baseInfo;        // 0x10
        private System.Reflection.EventInfo _event;        // 0x18

        // Methods
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Reflection.EventInfo info) { }
        private System.Reflection.MemberInfo AsMemberInfo() { }
        private System.String AsString() { }
        private System.String ToString() { }
        private System.Reflection.EventInfo op_Implicit(ParadoxNotion.Serialization.SerializedEventInfo value) { }

    }

    // TypeToken: 0x20004CF
    public class SerializedFieldInfo, ISerializedReflectedInfo, ISerializationCallbackReceiver
    {
        // Fields
        private System.String _baseInfo;        // 0x10
        private System.Reflection.FieldInfo _field;        // 0x18

        // Methods
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Reflection.FieldInfo info) { }
        private System.Reflection.MemberInfo AsMemberInfo() { }
        private System.String AsString() { }
        private System.String ToString() { }
        private System.Reflection.FieldInfo op_Implicit(ParadoxNotion.Serialization.SerializedFieldInfo value) { }

    }

    // TypeToken: 0x20004D0
    public class SerializedMethodInfo, ISerializedMethodBaseInfo, ISerializedReflectedInfo, ISerializationCallbackReceiver
    {
        // Fields
        private System.String _baseInfo;        // 0x10
        private System.String _paramsInfo;        // 0x18
        private System.String _genericArgumentsInfo;        // 0x20
        private System.Reflection.MethodInfo _method;        // 0x28
        private System.Boolean _hasChanged;        // 0x30

        // Methods
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Reflection.MethodInfo method) { }
        private System.Reflection.MemberInfo AsMemberInfo() { }
        private System.Reflection.MethodBase GetMethodBase() { }
        private System.Boolean HasChanged() { }
        private System.String AsString() { }
        private System.String ToString() { }
        private System.Reflection.MethodInfo op_Implicit(ParadoxNotion.Serialization.SerializedMethodInfo value) { }

    }

    // TypeToken: 0x20004D3
    public class SerializedTypeInfo, ISerializedReflectedInfo, ISerializationCallbackReceiver
    {
        // Fields
        private System.String _baseInfo;        // 0x10
        private System.Type _type;        // 0x18

        // Methods
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Type info) { }
        private System.Reflection.MemberInfo AsMemberInfo() { }
        private System.String AsString() { }
        private System.String ToString() { }
        private System.Type op_Implicit(ParadoxNotion.Serialization.SerializedTypeInfo value) { }

    }

    // TypeToken: 0x20004D4
    public class SerializedUnityEventInfo, ISerializedReflectedInfo, ISerializationCallbackReceiver
    {
        // Fields
        private System.String _baseInfo;        // 0x10
        private System.Reflection.MemberInfo _memberInfo;        // 0x18

        // Methods
        private System.Boolean get_isStatic() { }
        private System.Type get_memberType() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }
        private System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Reflection.FieldInfo info) { }
        private System.Void .ctor(System.Reflection.PropertyInfo info) { }
        private System.Void .ctor(System.Reflection.MemberInfo info) { }
        private System.Reflection.MemberInfo AsMemberInfo() { }
        private System.String AsString() { }
        private System.String ToString() { }
        private System.Reflection.FieldInfo op_Implicit(ParadoxNotion.Serialization.SerializedUnityEventInfo value) { }
        private System.Reflection.PropertyInfo op_Implicit(ParadoxNotion.Serialization.SerializedUnityEventInfo value) { }

    }

}

namespace ParadoxNotion.Serialization.FullSerializer
{

    // TypeToken: 0x20004D5
    public class fsForwardAttribute : Attribute
    {
        // Fields
        public System.String MemberName;        // 0x10

        // Methods
        private System.Void .ctor(System.String memberName) { }

    }

    // TypeToken: 0x20004D6
    public class fsWriteOnlyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004D7
    public class fsReadOnlyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004D8
    public class fsIgnoreAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004D9
    public class fsIgnoreInBuildAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004DA
    public class fsSerializeAsAttribute : Attribute
    {
        // Fields
        public readonly System.String Name;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String name) { }

    }

    // TypeToken: 0x20004DB
    public class fsMigrateToAttribute : Attribute
    {
        // Fields
        public readonly System.Type targetType;        // 0x10

        // Methods
        private System.Void .ctor(System.Type targetType) { }

    }

    // TypeToken: 0x20004DC
    public class fsMigrateVersionsAttribute : Attribute
    {
        // Fields
        public readonly System.Type[] previousTypes;        // 0x10

        // Methods
        private System.Void .ctor(System.Type[] previousTypes) { }

    }

    // TypeToken: 0x20004DD
    public class fsSerializeAsReference : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004DE
    public class fsDeserializeOverwrite : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004DF
    public class fsUninitialized : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004E0
    public class fsAutoInstance : Attribute
    {
        // Fields
        public readonly System.Boolean makeInstance;        // 0x10

        // Methods
        private System.Void .ctor(System.Boolean makeInstance) { }

    }

    // TypeToken: 0x20004E1
    public class fsObjectAttribute : Attribute
    {
        // Fields
        public System.Type Converter;        // 0x10
        public System.Type Processor;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004E2
    public class fsBaseConverter
    {
        // Fields
        public ParadoxNotion.Serialization.FullSerializer.fsSerializer Serializer;        // 0x10

        // Methods
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Boolean RequestCycleSupport(System.Type storageType) { }
        private System.Boolean RequestInheritanceSupport(System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult FailExpectedType(ParadoxNotion.Serialization.FullSerializer.fsData data, ParadoxNotion.Serialization.FullSerializer.fsDataType[] types) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult CheckType(ParadoxNotion.Serialization.FullSerializer.fsData data, ParadoxNotion.Serialization.FullSerializer.fsDataType type) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult CheckKey(ParadoxNotion.Serialization.FullSerializer.fsData data, System.String key, ParadoxNotion.Serialization.FullSerializer.fsData& subitem) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult CheckKey(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, System.String key, ParadoxNotion.Serialization.FullSerializer.fsData& subitem) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult SerializeMember(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, System.Type overrideConverterType, System.String name, T value) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult DeserializeMember(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, System.Type overrideConverterType, System.String name, T& value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004E4
    public class fsConverter : fsBaseConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004E5
    public class fsCyclicReferenceManager
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Object,System.Int32> _objectIds;        // 0x10
        private System.Int32 _nextId;        // 0x18
        private System.Collections.Generic.Dictionary<System.Int32,System.Object> _marked;        // 0x20
        private System.Int32 _depth;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void Clear() { }
        private System.Boolean Enter() { }
        private System.Boolean Exit() { }
        private System.Object GetReferenceObject(System.Int32 id) { }
        private System.Void AddReferenceWithId(System.Int32 id, System.Object reference) { }
        private System.Int32 GetReferenceId(System.Object item) { }
        private System.Boolean IsReference(System.Object item) { }
        private System.Void MarkSerialized(System.Object item) { }

    }

    // TypeToken: 0x20004E7
    public struct fsDataType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static ParadoxNotion.Serialization.FullSerializer.fsDataType Array;        // 0x0
        public static ParadoxNotion.Serialization.FullSerializer.fsDataType Object;        // 0x0
        public static ParadoxNotion.Serialization.FullSerializer.fsDataType Double;        // 0x0
        public static ParadoxNotion.Serialization.FullSerializer.fsDataType Int64;        // 0x0
        public static ParadoxNotion.Serialization.FullSerializer.fsDataType Boolean;        // 0x0
        public static ParadoxNotion.Serialization.FullSerializer.fsDataType String;        // 0x0
        public static ParadoxNotion.Serialization.FullSerializer.fsDataType Null;        // 0x0

    }

    // TypeToken: 0x20004E8
    public class fsData
    {
        // Fields
        private System.Object _value;        // 0x10
        public static readonly ParadoxNotion.Serialization.FullSerializer.fsData True;        // 0x0
        public static readonly ParadoxNotion.Serialization.FullSerializer.fsData False;        // 0x8
        public static readonly ParadoxNotion.Serialization.FullSerializer.fsData Null;        // 0x10

        // Methods
        private ParadoxNotion.Serialization.FullSerializer.fsDataType get_Type() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Boolean boolean) { }
        private System.Void .ctor(System.Double f) { }
        private System.Void .ctor(System.Int64 i) { }
        private System.Void .ctor(System.String str) { }
        private System.Void .ctor(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> dict) { }
        private System.Void .ctor(System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsData> list) { }
        private ParadoxNotion.Serialization.FullSerializer.fsData CreateDictionary() { }
        private ParadoxNotion.Serialization.FullSerializer.fsData CreateList() { }
        private ParadoxNotion.Serialization.FullSerializer.fsData CreateList(System.Int32 capacity) { }
        private System.Void BecomeDictionary() { }
        private ParadoxNotion.Serialization.FullSerializer.fsData Clone() { }
        private System.Boolean get_IsNull() { }
        private System.Boolean get_IsDouble() { }
        private System.Boolean get_IsInt64() { }
        private System.Boolean get_IsBool() { }
        private System.Boolean get_IsString() { }
        private System.Boolean get_IsDictionary() { }
        private System.Boolean get_IsList() { }
        private System.Double get_AsDouble() { }
        private System.Int64 get_AsInt64() { }
        private System.Boolean get_AsBool() { }
        private System.String get_AsString() { }
        private System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> get_AsDictionary() { }
        private System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsData> get_AsList() { }
        private T Cast() { }
        private System.String ToString() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Boolean Equals(ParadoxNotion.Serialization.FullSerializer.fsData other) { }
        private System.Boolean op_Equality(ParadoxNotion.Serialization.FullSerializer.fsData a, ParadoxNotion.Serialization.FullSerializer.fsData b) { }
        private System.Boolean op_Inequality(ParadoxNotion.Serialization.FullSerializer.fsData a, ParadoxNotion.Serialization.FullSerializer.fsData b) { }
        private System.Int32 GetHashCode() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20004E9
    public class fsDirectConverter : fsBaseConverter
    {
        // Methods
        private System.Type get_ModelType() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004EA
    public class fsDirectConverter`1 : fsDirectConverter
    {
        // Methods
        private System.Type get_ModelType() { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(TModel model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, TModel& model) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004EB
    public class fsGlobalConfig
    {
        // Fields
        public static System.Boolean SerializeDefaultValues;        // 0x0
        public static System.Boolean IsCaseSensitive;        // 0x1
        public static System.Type[] IgnoreSerializeAttributes;        // 0x8
        public static System.Type[] SerializeAttributes;        // 0x10
        public static System.String CustomDateTimeFormatString;        // 0x18
        public static System.Boolean Serialize64BitIntegerAsString;        // 0x20
        public static System.Boolean SerializeEnumsAsInteger;        // 0x21

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20004EC
    public class fsJsonParser
    {
        // Fields
        private System.Int32 _start;        // 0x10
        private System.String _input;        // 0x18
        private readonly System.Text.StringBuilder _cachedStringBuilder;        // 0x20

        // Methods
        private ParadoxNotion.Serialization.FullSerializer.fsResult MakeFailure(System.String message) { }
        private System.Boolean TryMoveNext() { }
        private System.Boolean HasValue() { }
        private System.Boolean HasValue(System.Int32 offset) { }
        private System.Char Character() { }
        private System.Char Character(System.Int32 offset) { }
        private System.Void SkipSpace() { }
        private System.Boolean IsHex(System.Char c) { }
        private System.UInt32 ParseSingleChar(System.Char c1, System.UInt32 multipliyer) { }
        private System.UInt32 ParseUnicode(System.Char c1, System.Char c2, System.Char c3, System.Char c4) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryUnescapeChar(System.Char& escaped) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryParseExact(System.String content) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryParseTrue(ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryParseFalse(ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryParseNull(ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private System.Boolean IsSeparator(System.Char c) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryParseNumber(ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryParseString(System.String& str) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryParseArray(ParadoxNotion.Serialization.FullSerializer.fsData& arr) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryParseObject(ParadoxNotion.Serialization.FullSerializer.fsData& obj) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult RunParse(ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult Parse(System.String input, ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private ParadoxNotion.Serialization.FullSerializer.fsData Parse(System.String input) { }
        private System.Void .ctor(System.String input) { }

    }

    // TypeToken: 0x20004ED
    public class fsJsonPrinter
    {
        // Methods
        private System.Void InsertSpacing(System.IO.TextWriter stream, System.Int32 count) { }
        private System.String EscapeString(System.String str) { }
        private System.Void BuildCompressedString(ParadoxNotion.Serialization.FullSerializer.fsData data, System.IO.TextWriter stream) { }
        private System.Void BuildPrettyString(ParadoxNotion.Serialization.FullSerializer.fsData data, System.IO.TextWriter stream, System.Int32 depth) { }
        private System.String ToJson(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Boolean pretty) { }
        private System.Void PrettyJson(ParadoxNotion.Serialization.FullSerializer.fsData data, System.IO.TextWriter outputStream) { }
        private System.String PrettyJson(ParadoxNotion.Serialization.FullSerializer.fsData data) { }
        private System.Void CompressedJson(ParadoxNotion.Serialization.FullSerializer.fsData data, System.IO.StreamWriter outputStream) { }
        private System.String CompressedJson(ParadoxNotion.Serialization.FullSerializer.fsData data) { }
        private System.String ConvertDoubleToString(System.Double d) { }

    }

    // TypeToken: 0x20004EE
    public class fsMetaProperty
    {
        // Fields
        private System.Reflection.FieldInfo <Field>k__BackingField;        // 0x10
        private System.String <JsonName>k__BackingField;        // 0x18
        private System.Boolean <ReadOnly>k__BackingField;        // 0x20
        private System.Boolean <WriteOnly>k__BackingField;        // 0x21
        private System.Boolean <AutoInstance>k__BackingField;        // 0x22
        private System.Boolean <AsReference>k__BackingField;        // 0x23

        // Methods
        private System.Reflection.FieldInfo get_Field() { }
        private System.Void set_Field(System.Reflection.FieldInfo value) { }
        private System.String get_JsonName() { }
        private System.Void set_JsonName(System.String value) { }
        private System.Type get_StorageType() { }
        private System.String get_MemberName() { }
        private System.Boolean get_ReadOnly() { }
        private System.Void set_ReadOnly(System.Boolean value) { }
        private System.Boolean get_WriteOnly() { }
        private System.Void set_WriteOnly(System.Boolean value) { }
        private System.Boolean get_AutoInstance() { }
        private System.Void set_AutoInstance(System.Boolean value) { }
        private System.Boolean get_AsReference() { }
        private System.Void set_AsReference(System.Boolean value) { }
        private System.Void .ctor(System.Reflection.FieldInfo field) { }
        private System.Object Read(System.Object context) { }
        private System.Void Write(System.Object context, System.Object value) { }

    }

    // TypeToken: 0x20004EF
    public class fsMetaType
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Type,ParadoxNotion.Serialization.FullSerializer.fsMetaType> _metaTypes;        // 0x0
        private static System.Collections.Generic.Dictionary<System.Type,System.Object> _defaultInstances;        // 0x8
        private ParadoxNotion.Serialization.FullSerializer.fsMetaType.ObjectGenerator generator;        // 0x10
        private System.Type <reflectedType>k__BackingField;        // 0x18
        private ParadoxNotion.Serialization.FullSerializer.fsMetaProperty[] <Properties>k__BackingField;        // 0x20
        private System.Boolean <DeserializeOverwriteRequest>k__BackingField;        // 0x28

        // Methods
        private ParadoxNotion.Serialization.FullSerializer.fsMetaType Get(System.Type type) { }
        private System.Void FlushMem() { }
        private System.Type get_reflectedType() { }
        private System.Void set_reflectedType(System.Type value) { }
        private ParadoxNotion.Serialization.FullSerializer.fsMetaProperty[] get_Properties() { }
        private System.Void set_Properties(ParadoxNotion.Serialization.FullSerializer.fsMetaProperty[] value) { }
        private System.Boolean get_DeserializeOverwriteRequest() { }
        private System.Void set_DeserializeOverwriteRequest(System.Boolean value) { }
        private System.Void .ctor(System.Type reflectedType) { }
        private System.Void CollectProperties(System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsMetaProperty> properties, System.Type reflectedType) { }
        private System.Boolean CanSerializeField(System.Reflection.FieldInfo field) { }
        private ParadoxNotion.Serialization.FullSerializer.fsMetaType.ObjectGenerator GetGenerator(System.Type reflectedType) { }
        private System.Boolean HasDefaultConstructor(System.Type reflectedType) { }
        private System.Object GetDefaultInstance() { }
        private System.Object CreateInstance() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20004F3
    public class fsObjectProcessor
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Void OnBeforeSerialize(System.Type storageType, System.Object instance) { }
        private System.Void OnAfterSerialize(System.Type storageType, System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private System.Void OnBeforeDeserialize(System.Type storageType, ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private System.Void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private System.Void OnAfterDeserialize(System.Type storageType, System.Object instance) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004F4
    public struct fsResult
    {
        // Fields
        private static readonly System.String[] EmptyStringArray;        // 0x0
        private System.Boolean _success;        // 0x10
        private System.Collections.Generic.List<System.String> _messages;        // 0x18
        public static ParadoxNotion.Serialization.FullSerializer.fsResult Success;        // 0x8

        // Methods
        private ParadoxNotion.Serialization.FullSerializer.fsResult Warn(System.String warning) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult Fail(System.String warning) { }
        private System.Void AddMessage(System.String message) { }
        private System.Void AddMessages(ParadoxNotion.Serialization.FullSerializer.fsResult result) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult Merge(ParadoxNotion.Serialization.FullSerializer.fsResult other) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult op_Addition(ParadoxNotion.Serialization.FullSerializer.fsResult a, ParadoxNotion.Serialization.FullSerializer.fsResult b) { }
        private System.Boolean get_Failed() { }
        private System.Boolean get_Succeeded() { }
        private System.Boolean get_HasWarnings() { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult AssertSuccess() { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult AssertSuccessWithoutWarnings() { }
        private System.Exception get_AsException() { }
        private System.Collections.Generic.IEnumerable<System.String> get_RawMessages() { }
        private System.String get_FormattedMessages() { }
        private System.String ToString() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20004F5
    public class fsSerializer
    {
        // Fields
        public static System.String KEY_OBJECT_REFERENCE;        // 0x0
        public static System.String KEY_OBJECT_DEFINITION;        // 0x0
        public static System.String KEY_INSTANCE_TYPE;        // 0x0
        public static System.String KEY_VERSION;        // 0x0
        public static System.String KEY_CONTENT;        // 0x0
        private System.Collections.Generic.Dictionary<System.Type,ParadoxNotion.Serialization.FullSerializer.fsBaseConverter> _cachedOverrideConverterInstances;        // 0x10
        private System.Collections.Generic.Dictionary<System.Type,ParadoxNotion.Serialization.FullSerializer.fsBaseConverter> _cachedConverters;        // 0x18
        private readonly System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsConverter> _availableConverters;        // 0x20
        private readonly System.Collections.Generic.Dictionary<System.Type,ParadoxNotion.Serialization.FullSerializer.fsDirectConverter> _availableDirectConverters;        // 0x28
        private readonly System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor> _processors;        // 0x30
        private System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor>> _cachedProcessors;        // 0x38
        private ParadoxNotion.Serialization.FullSerializer.fsCyclicReferenceManager _references;        // 0x40
        private ParadoxNotion.Serialization.FullSerializer.fsSerializer.fsLazyCycleDefinitionWriter _lazyReferenceWriter;        // 0x48
        private System.Collections.Generic.Stack<ParadoxNotion.Serialization.FullSerializer.ISerializationCollector> _collectors;        // 0x50
        private System.Int32 _collectableDepth;        // 0x58
        private System.Collections.Generic.List<UnityEngine.Object> <ReferencesDatabase>k__BackingField;        // 0x60
        private System.Boolean <IgnoreSerializeCycleReferences>k__BackingField;        // 0x68
        private System.Action<System.Object> onBeforeObjectSerialized;        // 0x70
        private System.Action<System.Object,ParadoxNotion.Serialization.FullSerializer.fsData> onAfterObjectSerialized;        // 0x78

        // Methods
        private System.Boolean IsReservedKeyword(System.String key) { }
        private System.Void RemoveMetaData(ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private System.Void EnsureDictionary(ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private System.Boolean IsObjectReference(ParadoxNotion.Serialization.FullSerializer.fsData data) { }
        private System.Boolean IsObjectDefinition(ParadoxNotion.Serialization.FullSerializer.fsData data) { }
        private System.Boolean IsVersioned(ParadoxNotion.Serialization.FullSerializer.fsData data) { }
        private System.Boolean IsTypeSpecified(ParadoxNotion.Serialization.FullSerializer.fsData data) { }
        private System.Boolean IsWrappedData(ParadoxNotion.Serialization.FullSerializer.fsData data) { }
        private System.Void Invoke_OnBeforeSerialize(System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor> processors, System.Type storageType, System.Object instance) { }
        private System.Void Invoke_OnAfterSerialize(System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor> processors, System.Type storageType, System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private System.Void Invoke_OnBeforeDeserialize(System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor> processors, System.Type storageType, ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private System.Void Invoke_OnBeforeDeserializeAfterInstanceCreation(System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor> processors, System.Type storageType, System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private System.Void Invoke_OnAfterDeserialize(System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor> processors, System.Type storageType, System.Object instance) { }
        private System.Collections.Generic.List<UnityEngine.Object> get_ReferencesDatabase() { }
        private System.Void set_ReferencesDatabase(System.Collections.Generic.List<UnityEngine.Object> value) { }
        private System.Boolean get_IgnoreSerializeCycleReferences() { }
        private System.Void set_IgnoreSerializeCycleReferences(System.Boolean value) { }
        private System.Void add_onBeforeObjectSerialized(System.Action<System.Object> value) { }
        private System.Void remove_onBeforeObjectSerialized(System.Action<System.Object> value) { }
        private System.Void add_onAfterObjectSerialized(System.Action<System.Object,ParadoxNotion.Serialization.FullSerializer.fsData> value) { }
        private System.Void remove_onAfterObjectSerialized(System.Action<System.Object,ParadoxNotion.Serialization.FullSerializer.fsData> value) { }
        private System.Void .ctor() { }
        private System.Void PurgeTemporaryData() { }
        private System.Collections.Generic.List<ParadoxNotion.Serialization.FullSerializer.fsObjectProcessor> GetProcessors(System.Type type) { }
        private System.Void AddConverter(ParadoxNotion.Serialization.FullSerializer.fsBaseConverter converter) { }
        private ParadoxNotion.Serialization.FullSerializer.fsBaseConverter GetConverter(System.Type type, System.Type overrideConverterType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Type storageType, System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Type storageType, System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& data, System.Type overrideConverterType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult Internal_Serialize(System.Type storageType, System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& data, System.Type overrideConverterType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType, System.Object& result) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType, System.Object& result, System.Type overrideConverterType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult Internal_Deserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType, System.Object& result, System.Type overrideConverterType) { }
        private System.Void TryPush(System.Object o) { }
        private System.Void TryPop(System.Object o) { }
        private System.Void TrySerializeVersioning(System.Object currentInstance, ParadoxNotion.Serialization.FullSerializer.fsData& data) { }
        private System.Void TryDeserializeVersioning(System.Object& currentInstance, ParadoxNotion.Serialization.FullSerializer.fsData& currentData) { }
        private System.Void TryDeserializeMigration(System.Object& currentInstance, ParadoxNotion.Serialization.FullSerializer.fsData& currentData, System.Type previousType, System.Object previousInstance) { }

    }

    // TypeToken: 0x20004F8
    public interface IMigratable
    {
    }

    // TypeToken: 0x20004F9
    public interface IMigratable`1 : IMigratable
    {
        // Methods
        private System.Void Migrate(T model) { }

    }

    // TypeToken: 0x20004FA
    public interface ISerializationCollector : ISerializationCollectable
    {
        // Methods
        private System.Void OnPush(ParadoxNotion.Serialization.FullSerializer.ISerializationCollector parent) { }
        private System.Void OnCollect(ParadoxNotion.Serialization.FullSerializer.ISerializationCollectable child, System.Int32 depth) { }
        private System.Void OnPop(ParadoxNotion.Serialization.FullSerializer.ISerializationCollector parent) { }

    }

    // TypeToken: 0x20004FB
    public interface ISerializationCollectable
    {
    }

}

namespace ParadoxNotion.Serialization.FullSerializer.Internal
{

    // TypeToken: 0x20004FC
    public class fsArrayConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Boolean RequestCycleSupport(System.Type storageType) { }
        private System.Boolean RequestInheritanceSupport(System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004FD
    public class fsDictionaryConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance_, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance_, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004FE
    public class fsEnumConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Boolean RequestCycleSupport(System.Type storageType) { }
        private System.Boolean RequestInheritanceSupport(System.Type storageType) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Boolean ArrayContains(T[] values, T value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004FF
    public class fsForwardConverter : fsConverter
    {
        // Fields
        private System.String _memberName;        // 0x18

        // Methods
        private System.Void .ctor(ParadoxNotion.Serialization.FullSerializer.fsForwardAttribute attribute) { }
        private System.Boolean CanProcess(System.Type type) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult GetProperty(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsMetaProperty& property) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }

    }

    // TypeToken: 0x2000500
    public class fsListConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance_, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance_, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000501
    public class fsPrimitiveConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Boolean RequestCycleSupport(System.Type storageType) { }
        private System.Boolean RequestInheritanceSupport(System.Type storageType) { }
        private System.Boolean UseBool(System.Type type) { }
        private System.Boolean UseInt64(System.Type type) { }
        private System.Boolean UseDouble(System.Type type) { }
        private System.Boolean UseString(System.Type type) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData storage, System.Object& instance, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000502
    public class fsReflectedConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000503
    public class fsTypeConverter : fsConverter
    {
        // Methods
        private System.Boolean CanProcess(System.Type type) { }
        private System.Boolean RequestCycleSupport(System.Type type) { }
        private System.Boolean RequestInheritanceSupport(System.Type type) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TrySerialize(System.Object instance, ParadoxNotion.Serialization.FullSerializer.fsData& serialized, System.Type storageType) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult TryDeserialize(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

}

namespace ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters
{

    // TypeToken: 0x2000504
    public class AnimationCurve_DirectConverter : fsDirectConverter`1
    {
        // Methods
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.AnimationCurve model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.AnimationCurve& model) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000505
    public class Bounds_DirectConverter : fsDirectConverter`1
    {
        // Methods
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.Bounds model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.Bounds& model) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000506
    public class Gradient_DirectConverter : fsDirectConverter`1
    {
        // Methods
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.Gradient model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.Gradient& model) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000507
    public class GUIStyleState_DirectConverter : fsDirectConverter`1
    {
        // Methods
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.GUIStyleState model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.GUIStyleState& model) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000508
    public class GUIStyle_DirectConverter : fsDirectConverter`1
    {
        // Methods
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.GUIStyle model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.GUIStyle& model) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000509
    public class Keyframe_DirectConverter : fsDirectConverter`1
    {
        // Methods
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.Keyframe model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.Keyframe& model) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200050A
    public class LayerMask_DirectConverter : fsDirectConverter`1
    {
        // Methods
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.LayerMask model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.LayerMask& model) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200050B
    public class RectOffset_DirectConverter : fsDirectConverter`1
    {
        // Methods
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.RectOffset model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.RectOffset& model) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200050C
    public class Rect_DirectConverter : fsDirectConverter`1
    {
        // Methods
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.Rect model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.Rect& model) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200050D
    public class Vector2Int_DirectConverter : fsDirectConverter`1
    {
        // Methods
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.Vector2Int model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.Vector2Int& model) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200050E
    public class Vector2_DirectConverter : fsDirectConverter`1
    {
        // Methods
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.Vector2 model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.Vector2& model) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200050F
    public class Vector3Int_DirectConverter : fsDirectConverter`1
    {
        // Methods
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoSerialize(UnityEngine.Vector3Int model, System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> serialized) { }
        private ParadoxNotion.Serialization.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<System.String,ParadoxNotion.Serialization.FullSerializer.fsData> data, UnityEngine.Vector3Int& model) { }
        private System.Object CreateInstance(ParadoxNotion.Serialization.FullSerializer.fsData data, System.Type storageType) { }
        private System.Void .ctor() { }

    }

}

namespace ParadoxNotion.Services
{

    // TypeToken: 0x20004AD
    public class EventRouter : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IDragHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, IDropHandler
    {
        // Fields
        private ParadoxNotion.Services.EventRouterAnimatorMove _routerAnimatorMove;        // 0x18
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> onPointerEnter;        // 0x20
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> onPointerExit;        // 0x28
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> onPointerDown;        // 0x30
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> onPointerUp;        // 0x38
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> onPointerClick;        // 0x40
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> onDrag;        // 0x48
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> onDrop;        // 0x50
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> onScroll;        // 0x58
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> onUpdateSelected;        // 0x60
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> onSelect;        // 0x68
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> onDeselect;        // 0x70
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.AxisEventData> onMove;        // 0x78
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> onSubmit;        // 0x80
        private ParadoxNotion.Services.EventRouter.EventDelegate onMouseDown;        // 0x88
        private ParadoxNotion.Services.EventRouter.EventDelegate onMouseDrag;        // 0x90
        private ParadoxNotion.Services.EventRouter.EventDelegate onMouseEnter;        // 0x98
        private ParadoxNotion.Services.EventRouter.EventDelegate onMouseExit;        // 0xA0
        private ParadoxNotion.Services.EventRouter.EventDelegate onMouseOver;        // 0xA8
        private ParadoxNotion.Services.EventRouter.EventDelegate onMouseUp;        // 0xB0
        private ParadoxNotion.Services.EventRouter.EventDelegate onEnable;        // 0xB8
        private ParadoxNotion.Services.EventRouter.EventDelegate onDisable;        // 0xC0
        private ParadoxNotion.Services.EventRouter.EventDelegate onDestroy;        // 0xC8
        private ParadoxNotion.Services.EventRouter.EventDelegate onTransformChildrenChanged;        // 0xD0
        private ParadoxNotion.Services.EventRouter.EventDelegate onTransformParentChanged;        // 0xD8
        private ParadoxNotion.Services.EventRouter.EventDelegate<System.Int32> onAnimatorIK;        // 0xE0
        private ParadoxNotion.Services.EventRouter.EventDelegate onBecameInvisible;        // 0xE8
        private ParadoxNotion.Services.EventRouter.EventDelegate onBecameVisible;        // 0xF0
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.ControllerColliderHit> onControllerColliderHit;        // 0xF8
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.GameObject> onParticleCollision;        // 0x100
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision> onCollisionEnter;        // 0x108
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision> onCollisionExit;        // 0x110
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision> onCollisionStay;        // 0x118
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D> onCollisionEnter2D;        // 0x120
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D> onCollisionExit2D;        // 0x128
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D> onCollisionStay2D;        // 0x130
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider> onTriggerEnter;        // 0x138
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider> onTriggerExit;        // 0x140
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider> onTriggerStay;        // 0x148
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D> onTriggerEnter2D;        // 0x150
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D> onTriggerExit2D;        // 0x158
        private ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D> onTriggerStay2D;        // 0x160
        private System.Action<UnityEngine.RenderTexture,UnityEngine.RenderTexture> onRenderImage;        // 0x168
        private ParadoxNotion.Services.EventRouter.EventDelegate onDrawGizmos;        // 0x170
        private ParadoxNotion.Services.EventRouter.CustomEventDelegate onCustomEvent;        // 0x178

        // Methods
        private System.Void add_onPointerEnter(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value) { }
        private System.Void remove_onPointerEnter(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value) { }
        private System.Void add_onPointerExit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value) { }
        private System.Void remove_onPointerExit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value) { }
        private System.Void add_onPointerDown(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value) { }
        private System.Void remove_onPointerDown(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value) { }
        private System.Void add_onPointerUp(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value) { }
        private System.Void remove_onPointerUp(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value) { }
        private System.Void add_onPointerClick(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value) { }
        private System.Void remove_onPointerClick(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value) { }
        private System.Void add_onDrag(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value) { }
        private System.Void remove_onDrag(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value) { }
        private System.Void add_onDrop(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value) { }
        private System.Void remove_onDrop(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value) { }
        private System.Void add_onScroll(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value) { }
        private System.Void remove_onScroll(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.PointerEventData> value) { }
        private System.Void add_onUpdateSelected(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> value) { }
        private System.Void remove_onUpdateSelected(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> value) { }
        private System.Void add_onSelect(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> value) { }
        private System.Void remove_onSelect(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> value) { }
        private System.Void add_onDeselect(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> value) { }
        private System.Void remove_onDeselect(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> value) { }
        private System.Void add_onMove(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.AxisEventData> value) { }
        private System.Void remove_onMove(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.AxisEventData> value) { }
        private System.Void add_onSubmit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> value) { }
        private System.Void remove_onSubmit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.EventSystems.BaseEventData> value) { }
        private System.Void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void UnityEngine.EventSystems.IDragHandler.OnDrag(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void UnityEngine.EventSystems.IDropHandler.OnDrop(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void UnityEngine.EventSystems.IScrollHandler.OnScroll(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void UnityEngine.EventSystems.IUpdateSelectedHandler.OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void UnityEngine.EventSystems.ISelectHandler.OnSelect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void UnityEngine.EventSystems.IDeselectHandler.OnDeselect(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void UnityEngine.EventSystems.IMoveHandler.OnMove(UnityEngine.EventSystems.AxisEventData eventData) { }
        private System.Void UnityEngine.EventSystems.ISubmitHandler.OnSubmit(UnityEngine.EventSystems.BaseEventData eventData) { }
        private System.Void add_onMouseDown(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void remove_onMouseDown(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void add_onMouseDrag(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void remove_onMouseDrag(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void add_onMouseEnter(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void remove_onMouseEnter(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void add_onMouseExit(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void remove_onMouseExit(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void add_onMouseOver(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void remove_onMouseOver(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void add_onMouseUp(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void remove_onMouseUp(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void OnMouseDown() { }
        private System.Void OnMouseDrag() { }
        private System.Void OnMouseEnter() { }
        private System.Void OnMouseExit() { }
        private System.Void OnMouseOver() { }
        private System.Void OnMouseUp() { }
        private System.Void add_onEnable(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void remove_onEnable(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void add_onDisable(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void remove_onDisable(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void add_onDestroy(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void remove_onDestroy(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void add_onTransformChildrenChanged(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void remove_onTransformChildrenChanged(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void add_onTransformParentChanged(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void remove_onTransformParentChanged(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void OnTransformChildrenChanged() { }
        private System.Void OnTransformParentChanged() { }
        private System.Void add_onAnimatorIK(ParadoxNotion.Services.EventRouter.EventDelegate<System.Int32> value) { }
        private System.Void remove_onAnimatorIK(ParadoxNotion.Services.EventRouter.EventDelegate<System.Int32> value) { }
        private System.Void add_onAnimatorMove(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void remove_onAnimatorMove(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void OnAnimatorIK(System.Int32 layerIndex) { }
        private System.Void add_onBecameInvisible(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void remove_onBecameInvisible(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void add_onBecameVisible(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void remove_onBecameVisible(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void OnBecameInvisible() { }
        private System.Void OnBecameVisible() { }
        private System.Void add_onControllerColliderHit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.ControllerColliderHit> value) { }
        private System.Void remove_onControllerColliderHit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.ControllerColliderHit> value) { }
        private System.Void add_onParticleCollision(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.GameObject> value) { }
        private System.Void remove_onParticleCollision(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.GameObject> value) { }
        private System.Void OnControllerColliderHit(UnityEngine.ControllerColliderHit hit) { }
        private System.Void OnParticleCollision(UnityEngine.GameObject other) { }
        private System.Void add_onCollisionEnter(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision> value) { }
        private System.Void remove_onCollisionEnter(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision> value) { }
        private System.Void add_onCollisionExit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision> value) { }
        private System.Void remove_onCollisionExit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision> value) { }
        private System.Void add_onCollisionStay(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision> value) { }
        private System.Void remove_onCollisionStay(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision> value) { }
        private System.Void OnCollisionEnter(UnityEngine.Collision collisionInfo) { }
        private System.Void OnCollisionExit(UnityEngine.Collision collisionInfo) { }
        private System.Void OnCollisionStay(UnityEngine.Collision collisionInfo) { }
        private System.Void add_onCollisionEnter2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D> value) { }
        private System.Void remove_onCollisionEnter2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D> value) { }
        private System.Void add_onCollisionExit2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D> value) { }
        private System.Void remove_onCollisionExit2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D> value) { }
        private System.Void add_onCollisionStay2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D> value) { }
        private System.Void remove_onCollisionStay2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collision2D> value) { }
        private System.Void OnCollisionEnter2D(UnityEngine.Collision2D collisionInfo) { }
        private System.Void OnCollisionExit2D(UnityEngine.Collision2D collisionInfo) { }
        private System.Void OnCollisionStay2D(UnityEngine.Collision2D collisionInfo) { }
        private System.Void add_onTriggerEnter(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider> value) { }
        private System.Void remove_onTriggerEnter(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider> value) { }
        private System.Void add_onTriggerExit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider> value) { }
        private System.Void remove_onTriggerExit(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider> value) { }
        private System.Void add_onTriggerStay(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider> value) { }
        private System.Void remove_onTriggerStay(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider> value) { }
        private System.Void OnTriggerEnter(UnityEngine.Collider other) { }
        private System.Void OnTriggerExit(UnityEngine.Collider other) { }
        private System.Void OnTriggerStay(UnityEngine.Collider other) { }
        private System.Void add_onTriggerEnter2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D> value) { }
        private System.Void remove_onTriggerEnter2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D> value) { }
        private System.Void add_onTriggerExit2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D> value) { }
        private System.Void remove_onTriggerExit2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D> value) { }
        private System.Void add_onTriggerStay2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D> value) { }
        private System.Void remove_onTriggerStay2D(ParadoxNotion.Services.EventRouter.EventDelegate<UnityEngine.Collider2D> value) { }
        private System.Void OnTriggerEnter2D(UnityEngine.Collider2D other) { }
        private System.Void OnTriggerExit2D(UnityEngine.Collider2D other) { }
        private System.Void OnTriggerStay2D(UnityEngine.Collider2D other) { }
        private System.Void add_onRenderImage(System.Action<UnityEngine.RenderTexture,UnityEngine.RenderTexture> value) { }
        private System.Void remove_onRenderImage(System.Action<UnityEngine.RenderTexture,UnityEngine.RenderTexture> value) { }
        private System.Void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination) { }
        private System.Void add_onDrawGizmos(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void remove_onDrawGizmos(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void OnDrawGizmos() { }
        private System.Void add_onCustomEvent(ParadoxNotion.Services.EventRouter.CustomEventDelegate value) { }
        private System.Void remove_onCustomEvent(ParadoxNotion.Services.EventRouter.CustomEventDelegate value) { }
        private System.Void InvokeCustomEvent(System.String name, System.Object value, System.Object sender) { }
        private System.Void InvokeCustomEvent(System.String name, T value, System.Object sender) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004B1
    public class EventRouterAnimatorMove : MonoBehaviour
    {
        // Fields
        private ParadoxNotion.Services.EventRouter.EventDelegate onAnimatorMove;        // 0x18

        // Methods
        private System.Void add_onAnimatorMove(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void remove_onAnimatorMove(ParadoxNotion.Services.EventRouter.EventDelegate value) { }
        private System.Void OnAnimatorMove() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004B2
    public class Logger
    {
        // Fields
        private static System.Collections.Generic.List<ParadoxNotion.Services.Logger.LogHandler> subscribers;        // 0x0

        // Methods
        private System.Void AddListener(ParadoxNotion.Services.Logger.LogHandler callback) { }
        private System.Void RemoveListener(ParadoxNotion.Services.Logger.LogHandler callback) { }
        private System.Void Log(System.Object message, System.String tag, System.Object context) { }
        private System.Void LogWarning(System.Object message, System.String tag, System.Object context) { }
        private System.Void LogError(System.Object message, System.String tag, System.Object context) { }
        private System.Void LogException(System.Exception exception, System.String tag, System.Object context) { }
        private System.Void Internal_Log(UnityEngine.LogType type, System.Object message, System.String tag, System.Object context) { }
        private System.Void ForwardToUnity(UnityEngine.LogType type, System.Object message, System.String tag, System.Object context) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20004B5
    public class MonoManager : MonoBehaviour
    {
        // Fields
        private System.Action onUpdate;        // 0x18
        private System.Action onLateUpdate;        // 0x20
        private System.Action onFixedUpdate;        // 0x28
        private System.Action onApplicationQuit;        // 0x30
        private System.Action<System.Boolean> onApplicationPause;        // 0x38
        private System.Action onGUI;        // 0x40
        private static System.Boolean isQuiting;        // 0x0
        private static ParadoxNotion.Services.MonoManager _current;        // 0x8

        // Methods
        private System.Void add_onUpdate(System.Action value) { }
        private System.Void remove_onUpdate(System.Action value) { }
        private System.Void add_onLateUpdate(System.Action value) { }
        private System.Void remove_onLateUpdate(System.Action value) { }
        private System.Void add_onFixedUpdate(System.Action value) { }
        private System.Void remove_onFixedUpdate(System.Action value) { }
        private System.Void add_onApplicationQuit(System.Action value) { }
        private System.Void remove_onApplicationQuit(System.Action value) { }
        private System.Void add_onApplicationPause(System.Action<System.Boolean> value) { }
        private System.Void remove_onApplicationPause(System.Action<System.Boolean> value) { }
        private System.Void add_onGUI(System.Action value) { }
        private System.Void remove_onGUI(System.Action value) { }
        private ParadoxNotion.Services.MonoManager get_current() { }
        private System.Void Purge() { }
        private System.Void Create() { }
        private System.Void AddUpdateCall(ParadoxNotion.Services.MonoManager.UpdateMode mode, System.Action call) { }
        private System.Void RemoveUpdateCall(ParadoxNotion.Services.MonoManager.UpdateMode mode, System.Action call) { }
        private System.Void Awake() { }
        private System.Void OnApplicationQuit() { }
        private System.Void OnApplicationPause(System.Boolean isPause) { }
        private System.Void Update() { }
        private System.Void LateUpdate() { }
        private System.Void FixedUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20004B7
    public class Threader
    {
        // Fields
        private static System.Boolean <applicationIsPlaying>k__BackingField;        // 0x0

        // Methods
        private System.Void .cctor() { }
        private System.Boolean get_applicationIsPlaying() { }
        private System.Void set_applicationIsPlaying(System.Boolean value) { }
        private System.Boolean get_isMainThread() { }
        private System.Void ManuallySyncIsPlaying() { }
        private System.Threading.Thread StartAction(System.Threading.Thread thread, System.Action function, System.Action callback) { }
        private System.Threading.Thread StartAction(System.Threading.Thread thread, System.Action<T1> function, T1 parameter1, System.Action callback) { }
        private System.Threading.Thread StartAction(System.Threading.Thread thread, System.Action<T1,T2> function, T1 parameter1, T2 parameter2, System.Action callback) { }
        private System.Threading.Thread StartAction(System.Threading.Thread thread, System.Action<T1,T2,T3> function, T1 parameter1, T2 parameter2, T3 parameter3, System.Action callback) { }
        private System.Threading.Thread StartFunction(System.Threading.Thread thread, System.Func<TResult> function, System.Action<TResult> callback) { }
        private System.Threading.Thread StartFunction(System.Threading.Thread thread, System.Func<T1,TResult> function, T1 parameter1, System.Action<TResult> callback) { }
        private System.Threading.Thread StartFunction(System.Threading.Thread thread, System.Func<T1,T2,TResult> function, T1 parameter1, T2 parameter2, System.Action<TResult> callback) { }
        private System.Threading.Thread StartFunction(System.Threading.Thread thread, System.Func<T1,T2,T3,TResult> function, T1 parameter1, T2 parameter2, T3 parameter3, System.Action<TResult> callback) { }
        private System.Void Begin(System.Threading.Thread thread, System.Action callback) { }
        private System.Collections.IEnumerator ThreadMonitor(System.Threading.Thread thread, System.Action callback) { }

    }

}

