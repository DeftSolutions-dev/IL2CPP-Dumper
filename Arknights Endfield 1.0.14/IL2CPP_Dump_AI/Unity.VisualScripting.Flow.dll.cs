// ========================================================
// Dumped by @desirepro
// Assembly: Unity.VisualScripting.Flow.dll
// Classes:  54
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: DebugData
TYPE:  class
TOKEN: 0x200000A
EXTENDS: UnitConnectionDebugData
FIELDS:
  private           System.Object                   <lastValue>k__BackingField  // 0x20
  private           System.Boolean                  <assignedLastValue>k__BackingField  // 0x28
METHODS:
  System.Void set_lastValue(System.Object value)
  System.Void set_assignedLastValue(System.Boolean value)
END_CLASS

CLASS: RecursionNode
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  private   readonly Unity.VisualScripting.IUnitPort <port>k__BackingField  // 0x10
  private   readonly Unity.VisualScripting.IGraphParent<context>k__BackingField  // 0x18
METHODS:
  Unity.VisualScripting.IUnitPort get_port()
  Unity.VisualScripting.IGraphParent get_context()
  System.Void .ctor(Unity.VisualScripting.IUnitPort port, Unity.VisualScripting.GraphPointer pointer)
  System.Boolean Equals(Unity.VisualScripting.Flow.RecursionNode other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: Unity.VisualScripting.ControlConnection
TYPE:  class
TOKEN: 0x2000002
EXTENDS: UnitConnection`2
FIELDS:
METHODS:
  System.Void .ctor(Unity.VisualScripting.ControlOutput source, Unity.VisualScripting.ControlInput destination)
  Unity.VisualScripting.ControlOutput get_source()
  Unity.VisualScripting.ControlInput get_destination()
  Unity.VisualScripting.IUnitOutputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.get_source()
  Unity.VisualScripting.IUnitInputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.get_destination()
  System.Boolean get_sourceExists()
  System.Boolean get_destinationExists()
END_CLASS

CLASS: Unity.VisualScripting.InvalidConnection
TYPE:  class
TOKEN: 0x2000003
EXTENDS: UnitConnection`2
FIELDS:
METHODS:
  System.Void .ctor(Unity.VisualScripting.IUnitOutputPort source, Unity.VisualScripting.IUnitInputPort destination)
  Unity.VisualScripting.IUnitOutputPort get_source()
  Unity.VisualScripting.IUnitInputPort get_destination()
  Unity.VisualScripting.IUnitOutputPort get_validSource()
  Unity.VisualScripting.IUnitInputPort get_validDestination()
  System.Boolean get_sourceExists()
  System.Boolean get_destinationExists()
  System.Boolean get_validSourceExists()
  System.Boolean get_validDestinationExists()
  System.Boolean HandleDependencies()
  System.Boolean <get_source>b__4_0(Unity.VisualScripting.IUnitOutputPort p)
  System.Boolean <get_destination>b__6_0(Unity.VisualScripting.IUnitInputPort p)
  System.Boolean <get_validSource>b__8_0(Unity.VisualScripting.IUnitOutputPort p)
  System.Boolean <get_validDestination>b__10_0(Unity.VisualScripting.IUnitInputPort p)
  System.Boolean <get_sourceExists>b__12_0(Unity.VisualScripting.IUnitOutputPort p)
  System.Boolean <get_destinationExists>b__14_0(Unity.VisualScripting.IUnitInputPort p)
  System.Boolean <get_validSourceExists>b__16_0(Unity.VisualScripting.IUnitOutputPort p)
  System.Boolean <get_validDestinationExists>b__18_0(Unity.VisualScripting.IUnitInputPort p)
END_CLASS

CLASS: Unity.VisualScripting.IUnitConnection
TYPE:  interface
TOKEN: 0x2000004
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.IUnitConnectionDebugData
TYPE:  interface
TOKEN: 0x2000005
FIELDS:
METHODS:
  System.Void set_lastInvokeFrame(System.Int32 value)
  System.Void set_lastInvokeTime(System.Single value)
END_CLASS

CLASS: Unity.VisualScripting.IUnitRelation
TYPE:  interface
TOKEN: 0x2000006
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.UnitConnection`2
TYPE:  class
TOKEN: 0x2000007
EXTENDS: GraphElement`1
FIELDS:
  private           Unity.VisualScripting.IUnit     <sourceUnit>k__BackingField  // 0x0
  private           System.String                   <sourceKey>k__BackingField  // 0x0
  private           Unity.VisualScripting.IUnit     <destinationUnit>k__BackingField  // 0x0
  private           System.String                   <destinationKey>k__BackingField  // 0x0
METHODS:
  System.Void .ctor(TSourcePort source, TDestinationPort destination)
  Unity.VisualScripting.IUnit get_sourceUnit()
  System.Void set_sourceUnit(Unity.VisualScripting.IUnit value)
  System.String get_sourceKey()
  System.Void set_sourceKey(System.String value)
  Unity.VisualScripting.IUnit get_destinationUnit()
  System.Void set_destinationUnit(Unity.VisualScripting.IUnit value)
  System.String get_destinationKey()
  System.Void set_destinationKey(System.String value)
  TSourcePort get_source()
  TDestinationPort get_destination()
  System.Int32 get_dependencyOrder()
  System.Boolean get_sourceExists()
  System.Boolean get_destinationExists()
  System.Boolean HandleDependencies()
END_CLASS

CLASS: Unity.VisualScripting.UnitConnectionDebugData
TYPE:  class
TOKEN: 0x2000008
FIELDS:
  private           System.Int32                    <lastInvokeFrame>k__BackingField  // 0x10
  private           System.Single                   <lastInvokeTime>k__BackingField  // 0x14
  private           System.Exception                <runtimeException>k__BackingField  // 0x18
METHODS:
  System.Void set_lastInvokeFrame(System.Int32 value)
  System.Void set_lastInvokeTime(System.Single value)
  System.Void set_runtimeException(System.Exception value)
END_CLASS

CLASS: Unity.VisualScripting.ValueConnection
TYPE:  class
TOKEN: 0x2000009
EXTENDS: UnitConnection`2
FIELDS:
METHODS:
  System.Void .ctor(Unity.VisualScripting.ValueOutput source, Unity.VisualScripting.ValueInput destination)
  Unity.VisualScripting.ValueOutput get_source()
  Unity.VisualScripting.ValueInput get_destination()
  Unity.VisualScripting.IUnitOutputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.get_source()
  Unity.VisualScripting.IUnitInputPort Unity.VisualScripting.IConnection<Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort>.get_destination()
  System.Boolean get_sourceExists()
  System.Boolean get_destinationExists()
END_CLASS

CLASS: Unity.VisualScripting.PortLabelHiddenAttribute
TYPE:  class
TOKEN: 0x200000B
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.SpecialUnitAttribute
TYPE:  class
TOKEN: 0x200000C
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.UnitHeaderInspectableAttribute
TYPE:  class
TOKEN: 0x200000D
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.UnitShortTitleAttribute
TYPE:  class
TOKEN: 0x200000E
EXTENDS: Attribute
FIELDS:
  private           System.String                   <title>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.String title)
  System.Void set_title(System.String value)
END_CLASS

CLASS: Unity.VisualScripting.UnitTitleAttribute
TYPE:  class
TOKEN: 0x200000F
EXTENDS: Attribute
FIELDS:
  private           System.String                   <title>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.String title)
  System.Void set_title(System.String value)
END_CLASS

CLASS: Unity.VisualScripting.Flow
TYPE:  class
TOKEN: 0x2000010
FIELDS:
  private           Unity.VisualScripting.GraphStack<stack>k__BackingField  // 0x10
  private           Unity.VisualScripting.Recursion<Unity.VisualScripting.Flow.RecursionNode>recursion  // 0x18
  private   readonly System.Collections.Generic.Dictionary<Unity.VisualScripting.IUnitValuePort,System.Object>locals  // 0x20
  public    readonly Unity.VisualScripting.VariableDeclarationsvariables  // 0x28
  private   readonly System.Collections.Generic.Stack<System.Int32>loops  // 0x30
  private   readonly System.Collections.Generic.HashSet<Unity.VisualScripting.GraphStack>preservedStacks  // 0x38
  private           UnityEngine.MonoBehaviour       <coroutineRunner>k__BackingField  // 0x40
  private           System.Collections.Generic.ICollection<Unity.VisualScripting.Flow>activeCoroutinesRegistry  // 0x48
  private           System.Boolean                  coroutineStopRequested  // 0x50
  private           System.Boolean                  <isCoroutine>k__BackingField  // 0x51
  private           System.Collections.IEnumerator  coroutineEnumerator  // 0x58
  private           System.Boolean                  <isPrediction>k__BackingField  // 0x60
  private           System.Boolean                  disposed  // 0x61
  public            System.Int32                    loopIdentifier  // 0x64
METHODS:
  Unity.VisualScripting.GraphStack get_stack()
  System.Void set_stack(Unity.VisualScripting.GraphStack value)
  System.Void set_coroutineRunner(UnityEngine.MonoBehaviour value)
  System.Void set_isCoroutine(System.Boolean value)
  System.Boolean get_isPrediction()
  System.Void set_isPrediction(System.Boolean value)
  System.Boolean get_enableDebug()
  System.Void .ctor()
  Unity.VisualScripting.Flow New(Unity.VisualScripting.GraphReference reference)
  System.Void Unity.VisualScripting.IPoolable.New()
  System.Void Dispose()
  System.Void Unity.VisualScripting.IPoolable.Free()
  System.Void Invoke(Unity.VisualScripting.ControlOutput output)
  Unity.VisualScripting.Flow.RecursionNode BeforeInvoke(Unity.VisualScripting.ControlOutput output, Unity.VisualScripting.Flow.RecursionNode recursionNode)
  System.Void AfterInvoke(Unity.VisualScripting.ControlOutput output, Unity.VisualScripting.Flow.RecursionNode recursionNode)
  Unity.VisualScripting.ControlOutput InvokeDelegate(Unity.VisualScripting.ControlInput input)
  System.Object GetValue(Unity.VisualScripting.ValueInput input)
  System.Object GetValue(Unity.VisualScripting.ValueOutput output)
  System.Object GetValue(Unity.VisualScripting.ValueInput input, System.Type type)
  T GetValue(Unity.VisualScripting.ValueInput input)
  System.Boolean TryGetDefaultValue(Unity.VisualScripting.ValueInput input, System.Object& defaultValue)
  System.Object GetValueDelegate(Unity.VisualScripting.ValueOutput output)
END_CLASS

CLASS: Unity.VisualScripting.FlowGraph
TYPE:  class
TOKEN: 0x2000013
EXTENDS: Graph
FIELDS:
  private           Unity.VisualScripting.GraphConnectionCollection<Unity.VisualScripting.ControlConnection,Unity.VisualScripting.ControlOutput,Unity.VisualScripting.ControlInput><controlConnections>k__BackingField  // 0x20
  private           Unity.VisualScripting.GraphConnectionCollection<Unity.VisualScripting.ValueConnection,Unity.VisualScripting.ValueOutput,Unity.VisualScripting.ValueInput><valueConnections>k__BackingField  // 0x28
  private           Unity.VisualScripting.GraphConnectionCollection<Unity.VisualScripting.InvalidConnection,Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort><invalidConnections>k__BackingField  // 0x30
METHODS:
  Unity.VisualScripting.GraphConnectionCollection<Unity.VisualScripting.ControlConnection,Unity.VisualScripting.ControlOutput,Unity.VisualScripting.ControlInput> get_controlConnections()
  Unity.VisualScripting.GraphConnectionCollection<Unity.VisualScripting.ValueConnection,Unity.VisualScripting.ValueOutput,Unity.VisualScripting.ValueInput> get_valueConnections()
  Unity.VisualScripting.GraphConnectionCollection<Unity.VisualScripting.InvalidConnection,Unity.VisualScripting.IUnitOutputPort,Unity.VisualScripting.IUnitInputPort> get_invalidConnections()
END_CLASS

CLASS: Unity.VisualScripting.EventUnit`1
TYPE:  class
TOKEN: 0x2000014
EXTENDS: Unit
FIELDS:
  private           Unity.VisualScripting.ControlOutput<trigger>k__BackingField  // 0x0
METHODS:
  Unity.VisualScripting.ControlOutput get_trigger()
  System.Void set_trigger(Unity.VisualScripting.ControlOutput value)
  System.Void Definition()
  System.Void .ctor()
  Unity.VisualScripting.FlowGraph Unity.VisualScripting.IUnit.get_graph()
END_CLASS

CLASS: Unity.VisualScripting.ManualEventUnit`1
TYPE:  class
TOKEN: 0x2000015
EXTENDS: EventUnit`1
FIELDS:
METHODS:
  System.String get_hookName()
  System.Void .ctor()
END_CLASS

CLASS: Unity.VisualScripting.MissingType
TYPE:  class
TOKEN: 0x2000016
EXTENDS: Unit
FIELDS:
METHODS:
  System.Void Definition()
END_CLASS

CLASS: Unity.VisualScripting.IUnit
TYPE:  interface
TOKEN: 0x2000017
FIELDS:
METHODS:
  Unity.VisualScripting.FlowGraph get_graph()
  System.Collections.Generic.Dictionary<System.String,System.Object> get_defaultValues()
  Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ControlInput> get_controlInputs()
  Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ControlOutput> get_controlOutputs()
  Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ValueInput> get_valueInputs()
  Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ValueOutput> get_valueOutputs()
  Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.InvalidInput> get_invalidInputs()
  Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.InvalidOutput> get_invalidOutputs()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitInputPort> get_inputs()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitOutputPort> get_outputs()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitInputPort> get_validInputs()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitOutputPort> get_validOutputs()
  System.Void PortsChanged()
END_CLASS

CLASS: Unity.VisualScripting.IUnitDebugData
TYPE:  interface
TOKEN: 0x2000018
FIELDS:
METHODS:
  System.Void set_lastInvokeFrame(System.Int32 value)
  System.Void set_lastInvokeTime(System.Single value)
END_CLASS

CLASS: Unity.VisualScripting.ControlInput
TYPE:  class
TOKEN: 0x2000019
EXTENDS: UnitPort`3
FIELDS:
  private   readonly System.Func<Unity.VisualScripting.Flow,Unity.VisualScripting.ControlOutput>action  // 0x20
METHODS:
  System.Boolean get_requiresCoroutine()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.ControlConnection> get_validConnections()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_invalidConnections()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.ControlOutput> get_validConnectedPorts()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitOutputPort> get_invalidConnectedPorts()
  System.Boolean CanConnectToValid(Unity.VisualScripting.ControlOutput port)
  System.Void ConnectToValid(Unity.VisualScripting.ControlOutput port)
  System.Void ConnectToInvalid(Unity.VisualScripting.IUnitOutputPort port)
  System.Void DisconnectFromValid(Unity.VisualScripting.ControlOutput port)
  System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitOutputPort port)
END_CLASS

CLASS: Unity.VisualScripting.ControlOutput
TYPE:  class
TOKEN: 0x200001C
EXTENDS: UnitPort`3
FIELDS:
METHODS:
  System.Void .ctor(System.String key)
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.ControlConnection> get_validConnections()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_invalidConnections()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.ControlInput> get_validConnectedPorts()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitInputPort> get_invalidConnectedPorts()
  Unity.VisualScripting.ControlConnection get_connection()
  System.Boolean get_hasValidConnection()
  System.Boolean CanConnectToValid(Unity.VisualScripting.ControlInput port)
  System.Void ConnectToValid(Unity.VisualScripting.ControlInput port)
  System.Void ConnectToInvalid(Unity.VisualScripting.IUnitInputPort port)
  System.Void DisconnectFromValid(Unity.VisualScripting.ControlInput port)
  System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitInputPort port)
END_CLASS

CLASS: Unity.VisualScripting.InvalidInput
TYPE:  class
TOKEN: 0x200001F
EXTENDS: UnitPort`3
FIELDS:
METHODS:
  System.Void .ctor(System.String key)
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_validConnections()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_invalidConnections()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitOutputPort> get_validConnectedPorts()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitOutputPort> get_invalidConnectedPorts()
  System.Boolean CanConnectToValid(Unity.VisualScripting.IUnitOutputPort port)
  System.Void ConnectToValid(Unity.VisualScripting.IUnitOutputPort port)
  System.Void ConnectToInvalid(Unity.VisualScripting.IUnitOutputPort port)
  System.Void DisconnectFromValid(Unity.VisualScripting.IUnitOutputPort port)
  System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitOutputPort port)
END_CLASS

CLASS: Unity.VisualScripting.InvalidOutput
TYPE:  class
TOKEN: 0x2000021
EXTENDS: UnitPort`3
FIELDS:
METHODS:
  System.Void .ctor(System.String key)
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_validConnections()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_invalidConnections()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitInputPort> get_validConnectedPorts()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitInputPort> get_invalidConnectedPorts()
  System.Boolean CanConnectToValid(Unity.VisualScripting.IUnitInputPort port)
  System.Void ConnectToValid(Unity.VisualScripting.IUnitInputPort port)
  System.Void ConnectToInvalid(Unity.VisualScripting.IUnitInputPort port)
  System.Void DisconnectFromValid(Unity.VisualScripting.IUnitInputPort port)
  System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitInputPort port)
END_CLASS

CLASS: Unity.VisualScripting.IUnitInputPort
TYPE:  interface
TOKEN: 0x2000023
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.IUnitOutputPort
TYPE:  interface
TOKEN: 0x2000024
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.IUnitPort
TYPE:  interface
TOKEN: 0x2000025
FIELDS:
METHODS:
  Unity.VisualScripting.IUnit get_unit()
  System.Void set_unit(Unity.VisualScripting.IUnit value)
  System.String get_key()
  System.Boolean CanInvalidlyConnectTo(Unity.VisualScripting.IUnitPort port)
  System.Boolean CanValidlyConnectTo(Unity.VisualScripting.IUnitPort port)
  System.Void InvalidlyConnectTo(Unity.VisualScripting.IUnitPort port)
  System.Void ValidlyConnectTo(Unity.VisualScripting.IUnitPort port)
END_CLASS

CLASS: Unity.VisualScripting.IUnitPortCollection`1
TYPE:  interface
TOKEN: 0x2000026
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.IUnitValuePort
TYPE:  interface
TOKEN: 0x2000027
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.VisualScripting.MissingValuePortInputException
TYPE:  class
TOKEN: 0x2000028
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor(System.String key)
END_CLASS

CLASS: Unity.VisualScripting.UnitPort`3
TYPE:  class
TOKEN: 0x2000029
FIELDS:
  private           Unity.VisualScripting.IUnit     <unit>k__BackingField  // 0x0
  private   readonly System.String                   <key>k__BackingField  // 0x0
METHODS:
  System.Void .ctor(System.String key)
  Unity.VisualScripting.IUnit get_unit()
  System.Void set_unit(Unity.VisualScripting.IUnit value)
  System.String get_key()
  System.Collections.Generic.IEnumerable<TExternalConnection> get_validConnections()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_invalidConnections()
  System.Collections.Generic.IEnumerable<TValidOther> get_validConnectedPorts()
  System.Collections.Generic.IEnumerable<TInvalidOther> get_invalidConnectedPorts()
  System.Boolean get_hasValidConnection()
  System.Boolean CanConnectTo(Unity.VisualScripting.IUnitPort port)
  System.Boolean CanValidlyConnectTo(Unity.VisualScripting.IUnitPort port)
  System.Boolean CanInvalidlyConnectTo(Unity.VisualScripting.IUnitPort port)
  System.Void ValidlyConnectTo(Unity.VisualScripting.IUnitPort port)
  System.Void InvalidlyConnectTo(Unity.VisualScripting.IUnitPort port)
  System.Void Disconnect()
  System.Boolean CanConnectToValid(TValidOther port)
  System.Boolean CanConnectToInvalid(TInvalidOther port)
  System.Void ConnectToValid(TValidOther port)
  System.Void ConnectToInvalid(TInvalidOther port)
  System.Void DisconnectFromValid(TValidOther port)
  System.Void DisconnectFromInvalid(TInvalidOther port)
  System.Void ConnectInvalid(Unity.VisualScripting.IUnitOutputPort source, Unity.VisualScripting.IUnitInputPort destination)
  System.Void DisconnectInvalid(Unity.VisualScripting.IUnitOutputPort source, Unity.VisualScripting.IUnitInputPort destination)
END_CLASS

CLASS: Unity.VisualScripting.UnitPortCollection`1
TYPE:  class
TOKEN: 0x200002C
EXTENDS: KeyedCollection`2
FIELDS:
  private   readonly Unity.VisualScripting.IUnit     <unit>k__BackingField  // 0x0
METHODS:
  Unity.VisualScripting.IUnit get_unit()
  System.Void .ctor(Unity.VisualScripting.IUnit unit)
  System.Void BeforeAdd(TPort port)
  System.Void AfterAdd(TPort port)
  System.Void BeforeRemove(TPort port)
  System.Void AfterRemove(TPort port)
  System.String GetKeyForItem(TPort item)
  System.Void InsertItem(System.Int32 index, TPort item)
  System.Void RemoveItem(System.Int32 index)
  System.Void SetItem(System.Int32 index, TPort item)
  System.Void ClearItems()
  TPort Unity.VisualScripting.IKeyedCollection<System.String,TPort>.get_Item(System.String key)
  System.Boolean Unity.VisualScripting.IKeyedCollection<System.String,TPort>.Contains(System.String key)
END_CLASS

CLASS: Unity.VisualScripting.ValueInput
TYPE:  class
TOKEN: 0x200002D
EXTENDS: UnitPort`3
FIELDS:
  private   readonly System.Type                     <type>k__BackingField  // 0x20
  private           System.Boolean                  <nullMeansSelf>k__BackingField  // 0x28
  private   static readonly System.Collections.Generic.HashSet<System.Type>typesWithDefaultValues  // 0x0
METHODS:
  System.Void .ctor(System.String key, System.Type type)
  System.Type get_type()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.ValueConnection> get_validConnections()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_invalidConnections()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.ValueOutput> get_validConnectedPorts()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitOutputPort> get_invalidConnectedPorts()
  System.Boolean get_nullMeansSelf()
  Unity.VisualScripting.ValueConnection get_connection()
  System.Boolean get_hasValidConnection()
  System.Void SetDefaultValue(System.Object value)
  System.Boolean CanConnectToValid(Unity.VisualScripting.ValueOutput port)
  System.Void ConnectToValid(Unity.VisualScripting.ValueOutput port)
  System.Void ConnectToInvalid(Unity.VisualScripting.IUnitOutputPort port)
  System.Void DisconnectFromValid(Unity.VisualScripting.ValueOutput port)
  System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitOutputPort port)
  System.Boolean SupportsDefaultValue(System.Type type)
  System.Void .cctor()
END_CLASS

CLASS: Unity.VisualScripting.ValueOutput
TYPE:  class
TOKEN: 0x2000030
EXTENDS: UnitPort`3
FIELDS:
  private   readonly System.Func<Unity.VisualScripting.Flow,System.Object>getValue  // 0x20
  private   readonly System.Type                     <type>k__BackingField  // 0x28
METHODS:
  System.Void .ctor(System.String key, System.Type type, System.Func<Unity.VisualScripting.Flow,System.Object> getValue)
  System.Boolean get_supportsFetch()
  System.Type get_type()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.ValueConnection> get_validConnections()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.InvalidConnection> get_invalidConnections()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.ValueInput> get_validConnectedPorts()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitInputPort> get_invalidConnectedPorts()
  System.Boolean CanConnectToValid(Unity.VisualScripting.ValueInput port)
  System.Void ConnectToValid(Unity.VisualScripting.ValueInput port)
  System.Void ConnectToInvalid(Unity.VisualScripting.IUnitInputPort port)
  System.Void DisconnectFromValid(Unity.VisualScripting.ValueInput port)
  System.Void DisconnectFromInvalid(Unity.VisualScripting.IUnitInputPort port)
END_CLASS

CLASS: Unity.VisualScripting.Unit
TYPE:  class
TOKEN: 0x2000033
EXTENDS: GraphElement`1
FIELDS:
  private   readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ControlInput><controlInputs>k__BackingField  // 0x28
  private   readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ControlOutput><controlOutputs>k__BackingField  // 0x30
  private   readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ValueInput><valueInputs>k__BackingField  // 0x38
  private   readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ValueOutput><valueOutputs>k__BackingField  // 0x40
  private   readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.InvalidInput><invalidInputs>k__BackingField  // 0x48
  private   readonly Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.InvalidOutput><invalidOutputs>k__BackingField  // 0x50
  private           System.Action                   onPortsChanged  // 0x58
  private           System.Collections.Generic.Dictionary<System.String,System.Object><defaultValues>k__BackingField  // 0x60
  private           Unity.VisualScripting.IConnectionCollection<Unity.VisualScripting.IUnitRelation,Unity.VisualScripting.IUnitPort,Unity.VisualScripting.IUnitPort><relations>k__BackingField  // 0x68
  private           System.Boolean                  <isControlRoot>k__BackingField  // 0x70
METHODS:
  System.Void .ctor()
  System.Void Definition()
  Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ControlInput> get_controlInputs()
  Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ControlOutput> get_controlOutputs()
  Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ValueInput> get_valueInputs()
  Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.ValueOutput> get_valueOutputs()
  Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.InvalidInput> get_invalidInputs()
  Unity.VisualScripting.IUnitPortCollection<Unity.VisualScripting.InvalidOutput> get_invalidOutputs()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitInputPort> get_inputs()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitOutputPort> get_outputs()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitInputPort> get_validInputs()
  System.Collections.Generic.IEnumerable<Unity.VisualScripting.IUnitOutputPort> get_validOutputs()
  System.Void PortsChanged()
  System.Collections.Generic.Dictionary<System.String,System.Object> get_defaultValues()
  System.Void set_defaultValues(System.Collections.Generic.Dictionary<System.String,System.Object> value)
  System.Void set_relations(Unity.VisualScripting.IConnectionCollection<Unity.VisualScripting.IUnitRelation,Unity.VisualScripting.IUnitPort,Unity.VisualScripting.IUnitPort> value)
  System.Void set_isControlRoot(System.Boolean value)
  System.Void EnsureUniqueInput(System.String key)
  System.Void EnsureUniqueOutput(System.String key)
  Unity.VisualScripting.ControlOutput ControlOutput(System.String key)
  Unity.VisualScripting.ValueInput ValueInput(System.Type type, System.String key)
  Unity.VisualScripting.ValueInput ValueInput(System.String key)
  Unity.VisualScripting.ValueInput ValueInput(System.String key, T default)
  Unity.VisualScripting.ValueOutput ValueOutput(System.Type type, System.String key, System.Func<Unity.VisualScripting.Flow,System.Object> getValue)
  Unity.VisualScripting.ValueOutput ValueOutput(System.String key, System.Func<Unity.VisualScripting.Flow,T> getValue)
  Unity.VisualScripting.FlowGraph Unity.VisualScripting.IUnit.get_graph()
END_CLASS

CLASS: Unity.VisualScripting.UnitCategory
TYPE:  class
TOKEN: 0x2000035
EXTENDS: Attribute
FIELDS:
  private   readonly Unity.VisualScripting.UnitCategory<root>k__BackingField  // 0x10
  private   readonly Unity.VisualScripting.UnitCategory<parent>k__BackingField  // 0x18
  private   readonly System.String                   <fullName>k__BackingField  // 0x20
  private   readonly System.String                   <name>k__BackingField  // 0x28
  private   readonly System.Boolean                  <isRoot>k__BackingField  // 0x30
METHODS:
  System.Void .ctor(System.String fullName)
  System.String get_fullName()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Unity.VisualScripting.UnitCategoryConverter
TYPE:  class
TOKEN: 0x2000036
EXTENDS: fsDirectConverter
FIELDS:
METHODS:
  System.Type get_ModelType()
  Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Object instance, Unity.VisualScripting.FullSerializer.fsData& serialized, System.Type storageType)
  Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Object& instance, System.Type storageType)
END_CLASS

