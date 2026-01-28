// ========================================================
// Dumped by @desirepro
// Assembly: Unity.VisualScripting.Flow.dll
// Classes:  54
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x200000A
    public class DebugData : UnitConnectionDebugData
    {
        // Fields
        private System.Object <lastValue>k__BackingField;        // 0x20
        private System.Boolean <assignedLastValue>k__BackingField;        // 0x28

        // Methods
        private System.Void set_lastValue(System.Object value) { }
        private System.Void set_assignedLastValue(System.Boolean value) { }

    }

    // TypeToken: 0x2000011
    public struct RecursionNode, IEquatable`1
    {
        // Fields
        private readonly Unity.VisualScripting.IUnitPort <port>k__BackingField;        // 0x10
        private readonly Unity.VisualScripting.IGraphParent <context>k__BackingField;        // 0x18

        // Methods
        private Unity.VisualScripting.IUnitPort get_port() { }
        private Unity.VisualScripting.IGraphParent get_context() { }
        private System.Void .ctor(Unity.VisualScripting.IUnitPort port, Unity.VisualScripting.GraphPointer pointer) { }
        private System.Boolean Equals(Unity.VisualScripting.Flow.RecursionNode other) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

namespace Unity.VisualScripting
{

    // TypeToken: 0x2000002
    public class ControlConnection : UnitConnection`2, IUnitConnection, IConnection`2, IGraphElementWithDebugData, IGraphElement, IDisposable, IIdentifiable
    {
        // Methods
        private System.Void .ctor(Unity.VisualScripting.ControlOutput source, Unity.VisualScripting.ControlInput destination) { }
        private Unity.VisualScripting.ControlOutput get_source() { }
        private Unity.VisualScripting.ControlInput get_destination() { }
        private Unity.VisualScripting.IUnitOutputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.get_source() { }
        private Unity.VisualScripting.IUnitInputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.get_destination() { }
        private System.Boolean get_sourceExists() { }
        private System.Boolean get_destinationExists() { }

    }

    // TypeToken: 0x2000003
    public class InvalidConnection : UnitConnection`2, IUnitConnection, IConnection`2, IGraphElementWithDebugData, IGraphElement, IDisposable, IIdentifiable
    {
        // Methods
        private System.Void .ctor(Unity.VisualScripting.IUnitOutputPort source, Unity.VisualScripting.IUnitInputPort destination) { }
        private Unity.VisualScripting.IUnitOutputPort get_source() { }
        private Unity.VisualScripting.IUnitInputPort get_destination() { }
        private Unity.VisualScripting.IUnitOutputPort get_validSource() { }
        private Unity.VisualScripting.IUnitInputPort get_validDestination() { }
        private System.Boolean get_sourceExists() { }
        private System.Boolean get_destinationExists() { }
        private System.Boolean get_validSourceExists() { }
        private System.Boolean get_validDestinationExists() { }
        private System.Boolean HandleDependencies() { }
        private System.Boolean <get_source>b__4_0(Unity.VisualScripting.IUnitOutputPort p) { }
        private System.Boolean <get_destination>b__6_0(Unity.VisualScripting.IUnitInputPort p) { }
        private System.Boolean <get_validSource>b__8_0(Unity.VisualScripting.IUnitOutputPort p) { }
        private System.Boolean <get_validDestination>b__10_0(Unity.VisualScripting.IUnitInputPort p) { }
        private System.Boolean <get_sourceExists>b__12_0(Unity.VisualScripting.IUnitOutputPort p) { }
        private System.Boolean <get_destinationExists>b__14_0(Unity.VisualScripting.IUnitInputPort p) { }
        private System.Boolean <get_validSourceExists>b__16_0(Unity.VisualScripting.IUnitOutputPort p) { }
        private System.Boolean <get_validDestinationExists>b__18_0(Unity.VisualScripting.IUnitInputPort p) { }

    }

    // TypeToken: 0x2000004
    public interface IUnitConnection : IConnection`2, IGraphElementWithDebugData, IGraphElement, IDisposable, IIdentifiable
    {
    }

    // TypeToken: 0x2000005
    public interface IUnitConnectionDebugData : IGraphElementDebugData
    {
        // Methods
        private System.Void set_lastInvokeFrame(System.Int32 value) { }
        private System.Void set_lastInvokeTime(System.Single value) { }

    }

    // TypeToken: 0x2000006
    public interface IUnitRelation : IConnection`2
    {
    }

    // TypeToken: 0x2000007
    public class UnitConnection`2 : GraphElement`1, IConnection`2
    {
        // Fields
        private Unity.VisualScripting.IUnit <sourceUnit>k__BackingField;        // 0x0
        private System.String <sourceKey>k__BackingField;        // 0x0
        private Unity.VisualScripting.IUnit <destinationUnit>k__BackingField;        // 0x0
        private System.String <destinationKey>k__BackingField;        // 0x0

        // Methods
        private System.Void .ctor(TSourcePort source, TDestinationPort destination) { }
        private Unity.VisualScripting.IUnit get_sourceUnit() { }
        private System.Void set_sourceUnit(Unity.VisualScripting.IUnit value) { }
        private System.String get_sourceKey() { }
        private System.Void set_sourceKey(System.String value) { }
        private Unity.VisualScripting.IUnit get_destinationUnit() { }
        private System.Void set_destinationUnit(Unity.VisualScripting.IUnit value) { }
        private System.String get_destinationKey() { }
        private System.Void set_destinationKey(System.String value) { }
        private TSourcePort get_source() { }
        private TDestinationPort get_destination() { }
        private System.Int32 get_dependencyOrder() { }
        private System.Boolean get_sourceExists() { }
        private System.Boolean get_destinationExists() { }
        private System.Boolean HandleDependencies() { }

    }

    // TypeToken: 0x2000008
    public class UnitConnectionDebugData, IUnitConnectionDebugData
    {
        // Fields
        private System.Int32 <lastInvokeFrame>k__BackingField;        // 0x10
        private System.Single <lastInvokeTime>k__BackingField;        // 0x14
        private System.Exception <runtimeException>k__BackingField;        // 0x18

        // Methods
        private System.Void set_lastInvokeFrame(System.Int32 value) { }
        private System.Void set_lastInvokeTime(System.Single value) { }
        private System.Void set_runtimeException(System.Exception value) { }

    }

    // TypeToken: 0x2000009
    public class ValueConnection : UnitConnection`2, IUnitConnection, IConnection`2, IGraphElementWithDebugData, IGraphElement, IDisposable, IIdentifiable
    {
        // Methods
        private System.Void .ctor(Unity.VisualScripting.ValueOutput source, Unity.VisualScripting.ValueInput destination) { }
        private Unity.VisualScripting.ValueOutput get_source() { }
        private Unity.VisualScripting.ValueInput get_destination() { }
        private Unity.VisualScripting.IUnitOutputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.get_source() { }
        private Unity.VisualScripting.IUnitInputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.get_destination() { }
        private System.Boolean get_sourceExists() { }
        private System.Boolean get_destinationExists() { }

    }

    // TypeToken: 0x200000B
    public class PortLabelHiddenAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000C
    public class SpecialUnitAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000D
    public class UnitHeaderInspectableAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000E
    public class UnitShortTitleAttribute : Attribute
    {
        // Fields
        private System.String <title>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.String title) { }
        private System.Void set_title(System.String value) { }

    }

    // TypeToken: 0x200000F
    public class UnitTitleAttribute : Attribute
    {
        // Fields
        private System.String <title>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.String title) { }
        private System.Void set_title(System.String value) { }

    }

    // TypeToken: 0x2000010
    public class Flow, IPoolable, IDisposable
    {
        // Fields
        private Unity.VisualScripting.GraphStack <stack>k__BackingField;        // 0x10
        private Unity.VisualScripting.Recursion<Unity.VisualScripting.Flow.RecursionNode> recursion;        // 0x18
        private readonly System.Collections.Generic.Dictionary<Unity.VisualScripting.IUnitValuePort,System.Object> locals;        // 0x20
        public readonly Unity.VisualScripting.VariableDeclarations variables;        // 0x28
        private readonly System.Collections.Generic.Stack<System.Int32> loops;        // 0x30
        private readonly System.Collections.Generic.HashSet<Unity.VisualScripting.GraphStack> preservedStacks;        // 0x38
        private UnityEngine.MonoBehaviour <coroutineRunner>k__BackingField;        // 0x40
        private System.Collections.Generic.ICollection<Unity.VisualScripting.Flow> activeCoroutinesRegistry;        // 0x48
        private System.Boolean coroutineStopRequested;        // 0x50
        private System.Boolean <isCoroutine>k__BackingField;        // 0x51
        private System.Collections.IEnumerator coroutineEnumerator;        // 0x58
        private System.Boolean <isPrediction>k__BackingField;        // 0x60
        private System.Boolean disposed;        // 0x61
        public System.Int32 loopIdentifier;        // 0x64

        // Methods
        private Unity.VisualScripting.GraphStack get_stack() { }
        private System.Void set_stack(Unity.VisualScripting.GraphStack value) { }
        private System.Void set_coroutineRunner(UnityEngine.MonoBehaviour value) { }
        private System.Void set_isCoroutine(System.Boolean value) { }
        private System.Boolean get_isPrediction() { }
        private System.Void set_isPrediction(System.Boolean value) { }
        private System.Boolean get_enableDebug() { }
        private System.Void .ctor() { }
        private Unity.VisualScripting.Flow New(Unity.VisualScripting.GraphReference reference) { }
        private System.Void Unity.VisualScripting.IPoolable.New() { }
        private System.Void Dispose() { }
        private System.Void Unity.VisualScripting.IPoolable.Free() { }
        private System.Void Invoke(Unity.VisualScripting.ControlOutput output) { }
        private Unity.VisualScripting.Flow.RecursionNode BeforeInvoke(Unity.VisualScripting.ControlOutput output, Unity.VisualScripting.Flow.RecursionNode recursionNode) { }
        private System.Void AfterInvoke(Unity.VisualScripting.ControlOutput output, Unity.VisualScripting.Flow.RecursionNode recursionNode) { }
        private Unity.VisualScripting.ControlOutput InvokeDelegate(Unity.VisualScripting.ControlInput input) { }
        private System.Object GetValue(Unity.VisualScripting.ValueInput input) { }
        private System.Object GetValue(Unity.VisualScripting.ValueOutput output) { }
        private System.Object GetValue(Unity.VisualScripting.ValueInput input, System.Type type) { }
        private T GetValue(Unity.VisualScripting.ValueInput input) { }
        private System.Boolean TryGetDefaultValue(Unity.VisualScripting.ValueInput input, System.Object& defaultValue) { }
        private System.Object GetValueDelegate(Unity.VisualScripting.ValueOutput output) { }

    }

    // TypeToken: 0x2000013
    public class FlowGraph : Graph, IGraph, IDisposable, ISerializationDepender, ISerializationCallbackReceiver
    {
        // Fields
        private Unity.VisualScripting.GraphConnectionCollection<Unity.VisualScripting.ControlConnection,Unity.VisualScripting.ControlOutput,Unity.VisualScripting.ControlInput> <controlConnections>k__BackingField;        // 0x20
        private Unity.VisualScripting.GraphConnectionCollection<Unity.VisualScripting.ValueConnection,Unity.VisualScripting.ValueOutput,Unity.VisualScripting.ValueInput> <valueConnections>k__BackingField;        // 0x28
        private Unity.VisualScripting.GraphConnectionCollection<Unity.VisualScripting.InvalidConnection,Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort> <invalidConnections>k__BackingField;        // 0x30

        // Methods
        private Unity.VisualScripting.GraphConnectionCollection<Unity.VisualScripting.ControlConnection,Unity.VisualScripting.ControlOutput,Unity.VisualScripting.ControlInput> get_controlConnections() { }
        private Unity.VisualScripting.GraphConnectionCollection<Unity.VisualScripting.ValueConnection,Unity.VisualScripting.ValueOutput,Unity.VisualScripting.ValueInput> get_valueConnections() { }
        private Unity.VisualScripting.GraphConnectionCollection<Unity.VisualScripting.InvalidConnection,Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort> get_invalidConnections() { }

    }

    // TypeToken: 0x2000014
    public class EventUnit`1 : Unit, IUnit, IGraphElementWithDebugData, IGraphElement, IDisposable, IIdentifiable
    {
        // Fields
        private Unity.VisualScripting.ControlOutput <trigger>k__BackingField;        // 0x0

        // Methods
        private Unity.VisualScripting.ControlOutput get_trigger() { }
        private System.Void set_trigger(Unity.VisualScripting.ControlOutput value) { }
        private System.Void Definition() { }
        private System.Void .ctor() { }
        private Unity.VisualScripting.FlowGraph Unity.VisualScripting.IUnit.get_graph() { }

    }

    // TypeToken: 0x2000015
    public class ManualEventUnit`1 : EventUnit`1
    {
        // Methods
        private System.String get_hookName() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public class MissingType : Unit
    {
        // Methods
        private System.Void Definition() { }

    }

    // TypeToken: 0x2000017
    public interface IUnit : IGraphElementWithDebugData, IGraphElement, IDisposable, IIdentifiable
    {
        // Methods
        private Unity.VisualScripting.FlowGraph get_graph() { }
        private System.Collections.Generic.Dictionary<System.String,System.Object> get_defaultValues() { }
        private Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ControlInput> get_controlInputs() { }
        private Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ControlOutput> get_controlOutputs() { }
        private Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ValueInput> get_valueInputs() { }
        private Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ValueOutput> get_valueOutputs() { }
        private Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.InvalidInput> get_invalidInputs() { }
        private Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.InvalidOutput> get_invalidOutputs() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitInputPort> get_inputs() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitOutputPort> get_outputs() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitInputPort> get_validInputs() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitOutputPort> get_validOutputs() { }
        private System.Void PortsChanged() { }

    }

    // TypeToken: 0x2000018
    public interface IUnitDebugData : IGraphElementDebugData
    {
        // Methods
        private System.Void set_lastInvokeFrame(System.Int32 value) { }
        private System.Void set_lastInvokeTime(System.Single value) { }

    }

    // TypeToken: 0x2000019
    public class ControlInput : UnitPort`3, IUnitPort, IUnitInputPort
    {
        // Fields
        private readonly System.Func<Unity.VisualScripting.Flow,Unity.VisualScripting.ControlOutput> action;        // 0x20

        // Methods
        private System.Boolean get_requiresCoroutine() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.ControlConnection> get_validConnections() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_invalidConnections() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.ControlOutput> get_validConnectedPorts() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitOutputPort> get_invalidConnectedPorts() { }
        private System.Boolean CanConnectToValid(Unity.VisualScripting.ControlOutput port) { }
        private System.Void ConnectToValid(Unity.VisualScripting.ControlOutput port) { }
        private System.Void ConnectToInvalid(Unity.VisualScripting.IUnitOutputPort port) { }
        private System.Void DisconnectFromValid(Unity.VisualScripting.ControlOutput port) { }
        private System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitOutputPort port) { }

    }

    // TypeToken: 0x200001C
    public class ControlOutput : UnitPort`3, IUnitPort, IUnitOutputPort
    {
        // Methods
        private System.Void .ctor(System.String key) { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.ControlConnection> get_validConnections() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_invalidConnections() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.ControlInput> get_validConnectedPorts() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitInputPort> get_invalidConnectedPorts() { }
        private Unity.VisualScripting.ControlConnection get_connection() { }
        private System.Boolean get_hasValidConnection() { }
        private System.Boolean CanConnectToValid(Unity.VisualScripting.ControlInput port) { }
        private System.Void ConnectToValid(Unity.VisualScripting.ControlInput port) { }
        private System.Void ConnectToInvalid(Unity.VisualScripting.IUnitInputPort port) { }
        private System.Void DisconnectFromValid(Unity.VisualScripting.ControlInput port) { }
        private System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitInputPort port) { }

    }

    // TypeToken: 0x200001F
    public class InvalidInput : UnitPort`3, IUnitPort, IUnitInputPort
    {
        // Methods
        private System.Void .ctor(System.String key) { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_validConnections() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_invalidConnections() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitOutputPort> get_validConnectedPorts() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitOutputPort> get_invalidConnectedPorts() { }
        private System.Boolean CanConnectToValid(Unity.VisualScripting.IUnitOutputPort port) { }
        private System.Void ConnectToValid(Unity.VisualScripting.IUnitOutputPort port) { }
        private System.Void ConnectToInvalid(Unity.VisualScripting.IUnitOutputPort port) { }
        private System.Void DisconnectFromValid(Unity.VisualScripting.IUnitOutputPort port) { }
        private System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitOutputPort port) { }

    }

    // TypeToken: 0x2000021
    public class InvalidOutput : UnitPort`3, IUnitPort, IUnitOutputPort
    {
        // Methods
        private System.Void .ctor(System.String key) { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_validConnections() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_invalidConnections() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitInputPort> get_validConnectedPorts() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitInputPort> get_invalidConnectedPorts() { }
        private System.Boolean CanConnectToValid(Unity.VisualScripting.IUnitInputPort port) { }
        private System.Void ConnectToValid(Unity.VisualScripting.IUnitInputPort port) { }
        private System.Void ConnectToInvalid(Unity.VisualScripting.IUnitInputPort port) { }
        private System.Void DisconnectFromValid(Unity.VisualScripting.IUnitInputPort port) { }
        private System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitInputPort port) { }

    }

    // TypeToken: 0x2000023
    public interface IUnitInputPort : IUnitPort
    {
    }

    // TypeToken: 0x2000024
    public interface IUnitOutputPort : IUnitPort
    {
    }

    // TypeToken: 0x2000025
    public interface IUnitPort
    {
        // Methods
        private Unity.VisualScripting.IUnit get_unit() { }
        private System.Void set_unit(Unity.VisualScripting.IUnit value) { }
        private System.String get_key() { }
        private System.Boolean CanInvalidlyConnectTo(Unity.VisualScripting.IUnitPort port) { }
        private System.Boolean CanValidlyConnectTo(Unity.VisualScripting.IUnitPort port) { }
        private System.Void InvalidlyConnectTo(Unity.VisualScripting.IUnitPort port) { }
        private System.Void ValidlyConnectTo(Unity.VisualScripting.IUnitPort port) { }

    }

    // TypeToken: 0x2000026
    public interface IUnitPortCollection`1 : IKeyedCollection`2, ICollection`1, IEnumerable`1, IEnumerable
    {
    }

    // TypeToken: 0x2000027
    public interface IUnitValuePort : IUnitPort
    {
    }

    // TypeToken: 0x2000028
    public class MissingValuePortInputException : Exception
    {
        // Methods
        private System.Void .ctor(System.String key) { }

    }

    // TypeToken: 0x2000029
    public class UnitPort`3, IUnitPort
    {
        // Fields
        private Unity.VisualScripting.IUnit <unit>k__BackingField;        // 0x0
        private readonly System.String <key>k__BackingField;        // 0x0

        // Methods
        private System.Void .ctor(System.String key) { }
        private Unity.VisualScripting.IUnit get_unit() { }
        private System.Void set_unit(Unity.VisualScripting.IUnit value) { }
        private System.String get_key() { }
        private System.Collections.Generic.IEnumerable<TExternalConnection> get_validConnections() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_invalidConnections() { }
        private System.Collections.Generic.IEnumerable<TValidOther> get_validConnectedPorts() { }
        private System.Collections.Generic.IEnumerable<TInvalidOther> get_invalidConnectedPorts() { }
        private System.Boolean get_hasValidConnection() { }
        private System.Boolean CanConnectTo(Unity.VisualScripting.IUnitPort port) { }
        private System.Boolean CanValidlyConnectTo(Unity.VisualScripting.IUnitPort port) { }
        private System.Boolean CanInvalidlyConnectTo(Unity.VisualScripting.IUnitPort port) { }
        private System.Void ValidlyConnectTo(Unity.VisualScripting.IUnitPort port) { }
        private System.Void InvalidlyConnectTo(Unity.VisualScripting.IUnitPort port) { }
        private System.Void Disconnect() { }
        private System.Boolean CanConnectToValid(TValidOther port) { }
        private System.Boolean CanConnectToInvalid(TInvalidOther port) { }
        private System.Void ConnectToValid(TValidOther port) { }
        private System.Void ConnectToInvalid(TInvalidOther port) { }
        private System.Void DisconnectFromValid(TValidOther port) { }
        private System.Void DisconnectFromInvalid(TInvalidOther port) { }
        private System.Void ConnectInvalid(Unity.VisualScripting.IUnitOutputPort source, Unity.VisualScripting.IUnitInputPort destination) { }
        private System.Void DisconnectInvalid(Unity.VisualScripting.IUnitOutputPort source, Unity.VisualScripting.IUnitInputPort destination) { }

    }

    // TypeToken: 0x200002C
    public class UnitPortCollection`1 : KeyedCollection`2, IUnitPortCollection`1, IKeyedCollection`2, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly Unity.VisualScripting.IUnit <unit>k__BackingField;        // 0x0

        // Methods
        private Unity.VisualScripting.IUnit get_unit() { }
        private System.Void .ctor(Unity.VisualScripting.IUnit unit) { }
        private System.Void BeforeAdd(TPort port) { }
        private System.Void AfterAdd(TPort port) { }
        private System.Void BeforeRemove(TPort port) { }
        private System.Void AfterRemove(TPort port) { }
        private System.String GetKeyForItem(TPort item) { }
        private System.Void InsertItem(System.Int32 index, TPort item) { }
        private System.Void RemoveItem(System.Int32 index) { }
        private System.Void SetItem(System.Int32 index, TPort item) { }
        private System.Void ClearItems() { }
        private TPort Unity.VisualScripting.IKeyedCollection<System.String,TPort>.get_Item(System.String key) { }
        private System.Boolean Unity.VisualScripting.IKeyedCollection<System.String,TPort>.Contains(System.String key) { }

    }

    // TypeToken: 0x200002D
    public class ValueInput : UnitPort`3, IUnitValuePort, IUnitPort, IUnitInputPort
    {
        // Fields
        private readonly System.Type <type>k__BackingField;        // 0x20
        private System.Boolean <nullMeansSelf>k__BackingField;        // 0x28
        private static readonly System.Collections.Generic.HashSet<System.Type> typesWithDefaultValues;        // 0x0

        // Methods
        private System.Void .ctor(System.String key, System.Type type) { }
        private System.Type get_type() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.ValueConnection> get_validConnections() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_invalidConnections() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.ValueOutput> get_validConnectedPorts() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitOutputPort> get_invalidConnectedPorts() { }
        private System.Boolean get_nullMeansSelf() { }
        private Unity.VisualScripting.ValueConnection get_connection() { }
        private System.Boolean get_hasValidConnection() { }
        private System.Void SetDefaultValue(System.Object value) { }
        private System.Boolean CanConnectToValid(Unity.VisualScripting.ValueOutput port) { }
        private System.Void ConnectToValid(Unity.VisualScripting.ValueOutput port) { }
        private System.Void ConnectToInvalid(Unity.VisualScripting.IUnitOutputPort port) { }
        private System.Void DisconnectFromValid(Unity.VisualScripting.ValueOutput port) { }
        private System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitOutputPort port) { }
        private System.Boolean SupportsDefaultValue(System.Type type) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000030
    public class ValueOutput : UnitPort`3, IUnitValuePort, IUnitPort, IUnitOutputPort
    {
        // Fields
        private readonly System.Func<Unity.VisualScripting.Flow,System.Object> getValue;        // 0x20
        private readonly System.Type <type>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor(System.String key, System.Type type, System.Func<Unity.VisualScripting.Flow,System.Object> getValue) { }
        private System.Boolean get_supportsFetch() { }
        private System.Type get_type() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.ValueConnection> get_validConnections() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_invalidConnections() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.ValueInput> get_validConnectedPorts() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitInputPort> get_invalidConnectedPorts() { }
        private System.Boolean CanConnectToValid(Unity.VisualScripting.ValueInput port) { }
        private System.Void ConnectToValid(Unity.VisualScripting.ValueInput port) { }
        private System.Void ConnectToInvalid(Unity.VisualScripting.IUnitInputPort port) { }
        private System.Void DisconnectFromValid(Unity.VisualScripting.ValueInput port) { }
        private System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitInputPort port) { }

    }

    // TypeToken: 0x2000033
    public class Unit : GraphElement`1, IUnit, IGraphElementWithDebugData, IGraphElement, IDisposable, IIdentifiable
    {
        // Fields
        private readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ControlInput> <controlInputs>k__BackingField;        // 0x28
        private readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ControlOutput> <controlOutputs>k__BackingField;        // 0x30
        private readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ValueInput> <valueInputs>k__BackingField;        // 0x38
        private readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ValueOutput> <valueOutputs>k__BackingField;        // 0x40
        private readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.InvalidInput> <invalidInputs>k__BackingField;        // 0x48
        private readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.InvalidOutput> <invalidOutputs>k__BackingField;        // 0x50
        private System.Action onPortsChanged;        // 0x58
        private System.Collections.Generic.Dictionary<System.String,System.Object> <defaultValues>k__BackingField;        // 0x60
        private Unity.VisualScripting.IConnectionCollection<Unity.VisualScripting.IUnitRelation,Unity.VisualScripting.IUnitPort,Unity.VisualScripting.IUnitPort> <relations>k__BackingField;        // 0x68
        private System.Boolean <isControlRoot>k__BackingField;        // 0x70

        // Methods
        private System.Void .ctor() { }
        private System.Void Definition() { }
        private Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ControlInput> get_controlInputs() { }
        private Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ControlOutput> get_controlOutputs() { }
        private Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ValueInput> get_valueInputs() { }
        private Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ValueOutput> get_valueOutputs() { }
        private Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.InvalidInput> get_invalidInputs() { }
        private Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.InvalidOutput> get_invalidOutputs() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitInputPort> get_inputs() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitOutputPort> get_outputs() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitInputPort> get_validInputs() { }
        private System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitOutputPort> get_validOutputs() { }
        private System.Void PortsChanged() { }
        private System.Collections.Generic.Dictionary<System.String,System.Object> get_defaultValues() { }
        private System.Void set_defaultValues(System.Collections.Generic.Dictionary<System.String,System.Object> value) { }
        private System.Void set_relations(Unity.VisualScripting.IConnectionCollection<Unity.VisualScripting.IUnitRelation,Unity.VisualScripting.IUnitPort,Unity.VisualScripting.IUnitPort> value) { }
        private System.Void set_isControlRoot(System.Boolean value) { }
        private System.Void EnsureUniqueInput(System.String key) { }
        private System.Void EnsureUniqueOutput(System.String key) { }
        private Unity.VisualScripting.ControlOutput ControlOutput(System.String key) { }
        private Unity.VisualScripting.ValueInput ValueInput(System.Type type, System.String key) { }
        private Unity.VisualScripting.ValueInput ValueInput(System.String key) { }
        private Unity.VisualScripting.ValueInput ValueInput(System.String key, T default) { }
        private Unity.VisualScripting.ValueOutput ValueOutput(System.Type type, System.String key, System.Func<Unity.VisualScripting.Flow,System.Object> getValue) { }
        private Unity.VisualScripting.ValueOutput ValueOutput(System.String key, System.Func<Unity.VisualScripting.Flow,T> getValue) { }
        private Unity.VisualScripting.FlowGraph Unity.VisualScripting.IUnit.get_graph() { }

    }

    // TypeToken: 0x2000035
    public class UnitCategory : Attribute
    {
        // Fields
        private readonly Unity.VisualScripting.UnitCategory <root>k__BackingField;        // 0x10
        private readonly Unity.VisualScripting.UnitCategory <parent>k__BackingField;        // 0x18
        private readonly System.String <fullName>k__BackingField;        // 0x20
        private readonly System.String <name>k__BackingField;        // 0x28
        private readonly System.Boolean <isRoot>k__BackingField;        // 0x30

        // Methods
        private System.Void .ctor(System.String fullName) { }
        private System.String get_fullName() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000036
    public class UnitCategoryConverter : fsDirectConverter
    {
        // Methods
        private System.Type get_ModelType() { }
        private Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType) { }
        private Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType) { }

    }

}

